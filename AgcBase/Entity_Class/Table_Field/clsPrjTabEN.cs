
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabEN
 表名:PrjTab(00050009)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:20
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
 /// 表PrjTab的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_PrjTab
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
public K_TabId_PrjTab(string strTabId)
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
 /// <returns>返回:[K_TabId_PrjTab]类型的对象</returns>
public static implicit operator K_TabId_PrjTab(string value)
{
return new K_TabId_PrjTab(value);
}
}
 /// <summary>
 /// 工程表(PrjTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPrjTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int _AttributeCount = 46;
public static string[] _AttributeName = new string[] {"TabId", "TabName", "TabCnName", "PrjId", "SqlDsTypeId", "TabStateId", "FuncModuleAgcId", "IsReleToSqlTab", "Keyword", "TabTypeId", "TabMainTypeId", "RelaTabId4View", "IsNeedGeneIndexer", "ParentClass", "IsShare", "IsUseDelSign", "IsUseCache", "IsMultiKeyClassify", "CacheClassifyField", "CacheClassifyField2", "CacheModeId", "CacheClassifyFieldTS", "CacheClassifyField2TS", "ParaVar2TS", "ParaVar1TS", "WhereFormat", "WhereFormatBack", "IsRefresh4RelaView", "TabRecNum", "KeyId4Test", "ErrMsg", "FldNum", "UpdUserId", "UpdDate", "Memo", "OrderNum4Refer", "IsChecked", "Owner", "TabEnName", "IsNeedTransCode", "TabNameB", "RelaViewId", "DataBaseName", "IsNationStandard", "IsParaTab", "IsArchive"};

protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrTabCnName;    //表中文名
protected string mstrPrjId;    //工程Id
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrTabStateId;    //表状态ID
protected string mstrFuncModuleAgcId;    //功能模块Id
protected bool mbolIsReleToSqlTab;    //是否与SQL表相关
protected string mstrKeyword;    //关键字
protected string mstrTabTypeId;    //表类型Id
protected string mstrTabMainTypeId;    //表主类型Id
protected string mstrRelaTabId4View;    //视图的相关表ID
protected bool mbolIsNeedGeneIndexer;    //是否需要生成索引器
protected string mstrParentClass;    //父类
protected bool mbolIsShare;    //是否共享
protected bool mbolIsUseDelSign;    //是否使用删除标记
protected bool mbolIsUseCache;    //是否使用Cache
protected bool mbolIsMultiKeyClassify;    //是否可以多个关键字分类共存
protected string mstrCacheClassifyField;    //缓存分类字段
protected string mstrCacheClassifyField2;    //缓存分类字段2
protected string mstrCacheModeId;    //缓存方式Id
protected string mstrCacheClassifyFieldTS;    //缓存分类字段_TS
protected string mstrCacheClassifyField2TS;    //缓存分类字段2_TS
protected string mstrParaVar2TS;    //参数变量2_TS
protected string mstrParaVar1TS;    //参数变量_TS
protected string mstrWhereFormat;    //缓存条件格式
protected string mstrWhereFormatBack;    //后台缓存条件格式
protected bool mbolIsRefresh4RelaView;    //是否刷新相关视图
protected int? mintTabRecNum;    //记录数
protected string mstrKeyId4Test;    //测试关键字Id
protected string mstrErrMsg;    //错误信息
protected int? mintFldNum;    //字段数
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明
protected int? mintOrderNum4Refer;    //引用序号
protected bool mbolIsChecked;    //是否核实
protected string mstrOwner;    //拥有者
protected string mstrTabEnName;    //表英文详细名
protected bool mbolIsNeedTransCode;    //是否需要转换代码
protected string mstrTabNameB;    //表名_后备
protected string mstrRelaViewId;    //RelaViewId
protected string mstrDataBaseName;    //数据库名
protected bool mbolIsNationStandard;    //是否国标
protected bool mbolIsParaTab;    //是否参数表
protected bool mbolIsArchive;    //是否存档

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenClassConstructor1)
/// </summary>
 public clsPrjTabEN()
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
public clsPrjTabEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:PrjTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:PrjTab中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conPrjTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conPrjTab.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  conPrjTab.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  conPrjTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPrjTab.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  conPrjTab.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  conPrjTab.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  conPrjTab.IsReleToSqlTab)
{
return mbolIsReleToSqlTab;
}
else if (strAttributeName  ==  conPrjTab.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  conPrjTab.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  conPrjTab.TabMainTypeId)
{
return mstrTabMainTypeId;
}
else if (strAttributeName  ==  conPrjTab.RelaTabId4View)
{
return mstrRelaTabId4View;
}
else if (strAttributeName  ==  conPrjTab.IsNeedGeneIndexer)
{
return mbolIsNeedGeneIndexer;
}
else if (strAttributeName  ==  conPrjTab.ParentClass)
{
return mstrParentClass;
}
else if (strAttributeName  ==  conPrjTab.IsShare)
{
return mbolIsShare;
}
else if (strAttributeName  ==  conPrjTab.IsUseDelSign)
{
return mbolIsUseDelSign;
}
else if (strAttributeName  ==  conPrjTab.IsUseCache)
{
return mbolIsUseCache;
}
else if (strAttributeName  ==  conPrjTab.IsMultiKeyClassify)
{
return mbolIsMultiKeyClassify;
}
else if (strAttributeName  ==  conPrjTab.CacheClassifyField)
{
return mstrCacheClassifyField;
}
else if (strAttributeName  ==  conPrjTab.CacheClassifyField2)
{
return mstrCacheClassifyField2;
}
else if (strAttributeName  ==  conPrjTab.CacheModeId)
{
return mstrCacheModeId;
}
else if (strAttributeName  ==  conPrjTab.CacheClassifyFieldTS)
{
return mstrCacheClassifyFieldTS;
}
else if (strAttributeName  ==  conPrjTab.CacheClassifyField2TS)
{
return mstrCacheClassifyField2TS;
}
else if (strAttributeName  ==  conPrjTab.ParaVar2TS)
{
return mstrParaVar2TS;
}
else if (strAttributeName  ==  conPrjTab.ParaVar1TS)
{
return mstrParaVar1TS;
}
else if (strAttributeName  ==  conPrjTab.WhereFormat)
{
return mstrWhereFormat;
}
else if (strAttributeName  ==  conPrjTab.WhereFormatBack)
{
return mstrWhereFormatBack;
}
else if (strAttributeName  ==  conPrjTab.IsRefresh4RelaView)
{
return mbolIsRefresh4RelaView;
}
else if (strAttributeName  ==  conPrjTab.TabRecNum)
{
return mintTabRecNum;
}
else if (strAttributeName  ==  conPrjTab.KeyId4Test)
{
return mstrKeyId4Test;
}
else if (strAttributeName  ==  conPrjTab.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conPrjTab.FldNum)
{
return mintFldNum;
}
else if (strAttributeName  ==  conPrjTab.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conPrjTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPrjTab.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conPrjTab.OrderNum4Refer)
{
return mintOrderNum4Refer;
}
else if (strAttributeName  ==  conPrjTab.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  conPrjTab.Owner)
{
return mstrOwner;
}
else if (strAttributeName  ==  conPrjTab.TabEnName)
{
return mstrTabEnName;
}
else if (strAttributeName  ==  conPrjTab.IsNeedTransCode)
{
return mbolIsNeedTransCode;
}
else if (strAttributeName  ==  conPrjTab.TabNameB)
{
return mstrTabNameB;
}
else if (strAttributeName  ==  conPrjTab.RelaViewId)
{
return mstrRelaViewId;
}
else if (strAttributeName  ==  conPrjTab.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  conPrjTab.IsNationStandard)
{
return mbolIsNationStandard;
}
else if (strAttributeName  ==  conPrjTab.IsParaTab)
{
return mbolIsParaTab;
}
else if (strAttributeName  ==  conPrjTab.IsArchive)
{
return mbolIsArchive;
}
return null;
}
set
{
if (strAttributeName  ==  conPrjTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTab.TabId);
}
else if (strAttributeName  ==  conPrjTab.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(conPrjTab.TabName);
}
else if (strAttributeName  ==  conPrjTab.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(conPrjTab.TabCnName);
}
else if (strAttributeName  ==  conPrjTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjTab.PrjId);
}
else if (strAttributeName  ==  conPrjTab.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conPrjTab.SqlDsTypeId);
}
else if (strAttributeName  ==  conPrjTab.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(conPrjTab.TabStateId);
}
else if (strAttributeName  ==  conPrjTab.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conPrjTab.FuncModuleAgcId);
}
else if (strAttributeName  ==  conPrjTab.IsReleToSqlTab)
{
mbolIsReleToSqlTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsReleToSqlTab);
}
else if (strAttributeName  ==  conPrjTab.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conPrjTab.Keyword);
}
else if (strAttributeName  ==  conPrjTab.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(conPrjTab.TabTypeId);
}
else if (strAttributeName  ==  conPrjTab.TabMainTypeId)
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conPrjTab.TabMainTypeId);
}
else if (strAttributeName  ==  conPrjTab.RelaTabId4View)
{
mstrRelaTabId4View = value.ToString();
 AddUpdatedFld(conPrjTab.RelaTabId4View);
}
else if (strAttributeName  ==  conPrjTab.IsNeedGeneIndexer)
{
mbolIsNeedGeneIndexer = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsNeedGeneIndexer);
}
else if (strAttributeName  ==  conPrjTab.ParentClass)
{
mstrParentClass = value.ToString();
 AddUpdatedFld(conPrjTab.ParentClass);
}
else if (strAttributeName  ==  conPrjTab.IsShare)
{
mbolIsShare = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsShare);
}
else if (strAttributeName  ==  conPrjTab.IsUseDelSign)
{
mbolIsUseDelSign = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsUseDelSign);
}
else if (strAttributeName  ==  conPrjTab.IsUseCache)
{
mbolIsUseCache = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsUseCache);
}
else if (strAttributeName  ==  conPrjTab.IsMultiKeyClassify)
{
mbolIsMultiKeyClassify = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsMultiKeyClassify);
}
else if (strAttributeName  ==  conPrjTab.CacheClassifyField)
{
mstrCacheClassifyField = value.ToString();
 AddUpdatedFld(conPrjTab.CacheClassifyField);
}
else if (strAttributeName  ==  conPrjTab.CacheClassifyField2)
{
mstrCacheClassifyField2 = value.ToString();
 AddUpdatedFld(conPrjTab.CacheClassifyField2);
}
else if (strAttributeName  ==  conPrjTab.CacheModeId)
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(conPrjTab.CacheModeId);
}
else if (strAttributeName  ==  conPrjTab.CacheClassifyFieldTS)
{
mstrCacheClassifyFieldTS = value.ToString();
 AddUpdatedFld(conPrjTab.CacheClassifyFieldTS);
}
else if (strAttributeName  ==  conPrjTab.CacheClassifyField2TS)
{
mstrCacheClassifyField2TS = value.ToString();
 AddUpdatedFld(conPrjTab.CacheClassifyField2TS);
}
else if (strAttributeName  ==  conPrjTab.ParaVar2TS)
{
mstrParaVar2TS = value.ToString();
 AddUpdatedFld(conPrjTab.ParaVar2TS);
}
else if (strAttributeName  ==  conPrjTab.ParaVar1TS)
{
mstrParaVar1TS = value.ToString();
 AddUpdatedFld(conPrjTab.ParaVar1TS);
}
else if (strAttributeName  ==  conPrjTab.WhereFormat)
{
mstrWhereFormat = value.ToString();
 AddUpdatedFld(conPrjTab.WhereFormat);
}
else if (strAttributeName  ==  conPrjTab.WhereFormatBack)
{
mstrWhereFormatBack = value.ToString();
 AddUpdatedFld(conPrjTab.WhereFormatBack);
}
else if (strAttributeName  ==  conPrjTab.IsRefresh4RelaView)
{
mbolIsRefresh4RelaView = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsRefresh4RelaView);
}
else if (strAttributeName  ==  conPrjTab.TabRecNum)
{
mintTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTab.TabRecNum);
}
else if (strAttributeName  ==  conPrjTab.KeyId4Test)
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(conPrjTab.KeyId4Test);
}
else if (strAttributeName  ==  conPrjTab.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conPrjTab.ErrMsg);
}
else if (strAttributeName  ==  conPrjTab.FldNum)
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTab.FldNum);
}
else if (strAttributeName  ==  conPrjTab.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPrjTab.UpdUserId);
}
else if (strAttributeName  ==  conPrjTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjTab.UpdDate);
}
else if (strAttributeName  ==  conPrjTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTab.Memo);
}
else if (strAttributeName  ==  conPrjTab.OrderNum4Refer)
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTab.OrderNum4Refer);
}
else if (strAttributeName  ==  conPrjTab.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsChecked);
}
else if (strAttributeName  ==  conPrjTab.Owner)
{
mstrOwner = value.ToString();
 AddUpdatedFld(conPrjTab.Owner);
}
else if (strAttributeName  ==  conPrjTab.TabEnName)
{
mstrTabEnName = value.ToString();
 AddUpdatedFld(conPrjTab.TabEnName);
}
else if (strAttributeName  ==  conPrjTab.IsNeedTransCode)
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsNeedTransCode);
}
else if (strAttributeName  ==  conPrjTab.TabNameB)
{
mstrTabNameB = value.ToString();
 AddUpdatedFld(conPrjTab.TabNameB);
}
else if (strAttributeName  ==  conPrjTab.RelaViewId)
{
mstrRelaViewId = value.ToString();
 AddUpdatedFld(conPrjTab.RelaViewId);
}
else if (strAttributeName  ==  conPrjTab.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conPrjTab.DataBaseName);
}
else if (strAttributeName  ==  conPrjTab.IsNationStandard)
{
mbolIsNationStandard = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsNationStandard);
}
else if (strAttributeName  ==  conPrjTab.IsParaTab)
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsParaTab);
}
else if (strAttributeName  ==  conPrjTab.IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsArchive);
}
}
}
public object this[int intIndex]
{
get
{
if (conPrjTab.TabId  ==  _AttributeName[intIndex])
{
return mstrTabId;
}
else if (conPrjTab.TabName  ==  _AttributeName[intIndex])
{
return mstrTabName;
}
else if (conPrjTab.TabCnName  ==  _AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (conPrjTab.PrjId  ==  _AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPrjTab.SqlDsTypeId  ==  _AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (conPrjTab.TabStateId  ==  _AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (conPrjTab.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (conPrjTab.IsReleToSqlTab  ==  _AttributeName[intIndex])
{
return mbolIsReleToSqlTab;
}
else if (conPrjTab.Keyword  ==  _AttributeName[intIndex])
{
return mstrKeyword;
}
else if (conPrjTab.TabTypeId  ==  _AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (conPrjTab.TabMainTypeId  ==  _AttributeName[intIndex])
{
return mstrTabMainTypeId;
}
else if (conPrjTab.RelaTabId4View  ==  _AttributeName[intIndex])
{
return mstrRelaTabId4View;
}
else if (conPrjTab.IsNeedGeneIndexer  ==  _AttributeName[intIndex])
{
return mbolIsNeedGeneIndexer;
}
else if (conPrjTab.ParentClass  ==  _AttributeName[intIndex])
{
return mstrParentClass;
}
else if (conPrjTab.IsShare  ==  _AttributeName[intIndex])
{
return mbolIsShare;
}
else if (conPrjTab.IsUseDelSign  ==  _AttributeName[intIndex])
{
return mbolIsUseDelSign;
}
else if (conPrjTab.IsUseCache  ==  _AttributeName[intIndex])
{
return mbolIsUseCache;
}
else if (conPrjTab.IsMultiKeyClassify  ==  _AttributeName[intIndex])
{
return mbolIsMultiKeyClassify;
}
else if (conPrjTab.CacheClassifyField  ==  _AttributeName[intIndex])
{
return mstrCacheClassifyField;
}
else if (conPrjTab.CacheClassifyField2  ==  _AttributeName[intIndex])
{
return mstrCacheClassifyField2;
}
else if (conPrjTab.CacheModeId  ==  _AttributeName[intIndex])
{
return mstrCacheModeId;
}
else if (conPrjTab.CacheClassifyFieldTS  ==  _AttributeName[intIndex])
{
return mstrCacheClassifyFieldTS;
}
else if (conPrjTab.CacheClassifyField2TS  ==  _AttributeName[intIndex])
{
return mstrCacheClassifyField2TS;
}
else if (conPrjTab.ParaVar2TS  ==  _AttributeName[intIndex])
{
return mstrParaVar2TS;
}
else if (conPrjTab.ParaVar1TS  ==  _AttributeName[intIndex])
{
return mstrParaVar1TS;
}
else if (conPrjTab.WhereFormat  ==  _AttributeName[intIndex])
{
return mstrWhereFormat;
}
else if (conPrjTab.WhereFormatBack  ==  _AttributeName[intIndex])
{
return mstrWhereFormatBack;
}
else if (conPrjTab.IsRefresh4RelaView  ==  _AttributeName[intIndex])
{
return mbolIsRefresh4RelaView;
}
else if (conPrjTab.TabRecNum  ==  _AttributeName[intIndex])
{
return mintTabRecNum;
}
else if (conPrjTab.KeyId4Test  ==  _AttributeName[intIndex])
{
return mstrKeyId4Test;
}
else if (conPrjTab.ErrMsg  ==  _AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conPrjTab.FldNum  ==  _AttributeName[intIndex])
{
return mintFldNum;
}
else if (conPrjTab.UpdUserId  ==  _AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conPrjTab.UpdDate  ==  _AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPrjTab.Memo  ==  _AttributeName[intIndex])
{
return mstrMemo;
}
else if (conPrjTab.OrderNum4Refer  ==  _AttributeName[intIndex])
{
return mintOrderNum4Refer;
}
else if (conPrjTab.IsChecked  ==  _AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (conPrjTab.Owner  ==  _AttributeName[intIndex])
{
return mstrOwner;
}
else if (conPrjTab.TabEnName  ==  _AttributeName[intIndex])
{
return mstrTabEnName;
}
else if (conPrjTab.IsNeedTransCode  ==  _AttributeName[intIndex])
{
return mbolIsNeedTransCode;
}
else if (conPrjTab.TabNameB  ==  _AttributeName[intIndex])
{
return mstrTabNameB;
}
else if (conPrjTab.RelaViewId  ==  _AttributeName[intIndex])
{
return mstrRelaViewId;
}
else if (conPrjTab.DataBaseName  ==  _AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (conPrjTab.IsNationStandard  ==  _AttributeName[intIndex])
{
return mbolIsNationStandard;
}
else if (conPrjTab.IsParaTab  ==  _AttributeName[intIndex])
{
return mbolIsParaTab;
}
else if (conPrjTab.IsArchive  ==  _AttributeName[intIndex])
{
return mbolIsArchive;
}
return null;
}
set
{
if (conPrjTab.TabId  ==  _AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conPrjTab.TabId);
}
else if (conPrjTab.TabName  ==  _AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(conPrjTab.TabName);
}
else if (conPrjTab.TabCnName  ==  _AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(conPrjTab.TabCnName);
}
else if (conPrjTab.PrjId  ==  _AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPrjTab.PrjId);
}
else if (conPrjTab.SqlDsTypeId  ==  _AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(conPrjTab.SqlDsTypeId);
}
else if (conPrjTab.TabStateId  ==  _AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(conPrjTab.TabStateId);
}
else if (conPrjTab.FuncModuleAgcId  ==  _AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conPrjTab.FuncModuleAgcId);
}
else if (conPrjTab.IsReleToSqlTab  ==  _AttributeName[intIndex])
{
mbolIsReleToSqlTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsReleToSqlTab);
}
else if (conPrjTab.Keyword  ==  _AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conPrjTab.Keyword);
}
else if (conPrjTab.TabTypeId  ==  _AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(conPrjTab.TabTypeId);
}
else if (conPrjTab.TabMainTypeId  ==  _AttributeName[intIndex])
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conPrjTab.TabMainTypeId);
}
else if (conPrjTab.RelaTabId4View  ==  _AttributeName[intIndex])
{
mstrRelaTabId4View = value.ToString();
 AddUpdatedFld(conPrjTab.RelaTabId4View);
}
else if (conPrjTab.IsNeedGeneIndexer  ==  _AttributeName[intIndex])
{
mbolIsNeedGeneIndexer = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsNeedGeneIndexer);
}
else if (conPrjTab.ParentClass  ==  _AttributeName[intIndex])
{
mstrParentClass = value.ToString();
 AddUpdatedFld(conPrjTab.ParentClass);
}
else if (conPrjTab.IsShare  ==  _AttributeName[intIndex])
{
mbolIsShare = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsShare);
}
else if (conPrjTab.IsUseDelSign  ==  _AttributeName[intIndex])
{
mbolIsUseDelSign = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsUseDelSign);
}
else if (conPrjTab.IsUseCache  ==  _AttributeName[intIndex])
{
mbolIsUseCache = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsUseCache);
}
else if (conPrjTab.IsMultiKeyClassify  ==  _AttributeName[intIndex])
{
mbolIsMultiKeyClassify = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsMultiKeyClassify);
}
else if (conPrjTab.CacheClassifyField  ==  _AttributeName[intIndex])
{
mstrCacheClassifyField = value.ToString();
 AddUpdatedFld(conPrjTab.CacheClassifyField);
}
else if (conPrjTab.CacheClassifyField2  ==  _AttributeName[intIndex])
{
mstrCacheClassifyField2 = value.ToString();
 AddUpdatedFld(conPrjTab.CacheClassifyField2);
}
else if (conPrjTab.CacheModeId  ==  _AttributeName[intIndex])
{
mstrCacheModeId = value.ToString();
 AddUpdatedFld(conPrjTab.CacheModeId);
}
else if (conPrjTab.CacheClassifyFieldTS  ==  _AttributeName[intIndex])
{
mstrCacheClassifyFieldTS = value.ToString();
 AddUpdatedFld(conPrjTab.CacheClassifyFieldTS);
}
else if (conPrjTab.CacheClassifyField2TS  ==  _AttributeName[intIndex])
{
mstrCacheClassifyField2TS = value.ToString();
 AddUpdatedFld(conPrjTab.CacheClassifyField2TS);
}
else if (conPrjTab.ParaVar2TS  ==  _AttributeName[intIndex])
{
mstrParaVar2TS = value.ToString();
 AddUpdatedFld(conPrjTab.ParaVar2TS);
}
else if (conPrjTab.ParaVar1TS  ==  _AttributeName[intIndex])
{
mstrParaVar1TS = value.ToString();
 AddUpdatedFld(conPrjTab.ParaVar1TS);
}
else if (conPrjTab.WhereFormat  ==  _AttributeName[intIndex])
{
mstrWhereFormat = value.ToString();
 AddUpdatedFld(conPrjTab.WhereFormat);
}
else if (conPrjTab.WhereFormatBack  ==  _AttributeName[intIndex])
{
mstrWhereFormatBack = value.ToString();
 AddUpdatedFld(conPrjTab.WhereFormatBack);
}
else if (conPrjTab.IsRefresh4RelaView  ==  _AttributeName[intIndex])
{
mbolIsRefresh4RelaView = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsRefresh4RelaView);
}
else if (conPrjTab.TabRecNum  ==  _AttributeName[intIndex])
{
mintTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTab.TabRecNum);
}
else if (conPrjTab.KeyId4Test  ==  _AttributeName[intIndex])
{
mstrKeyId4Test = value.ToString();
 AddUpdatedFld(conPrjTab.KeyId4Test);
}
else if (conPrjTab.ErrMsg  ==  _AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conPrjTab.ErrMsg);
}
else if (conPrjTab.FldNum  ==  _AttributeName[intIndex])
{
mintFldNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTab.FldNum);
}
else if (conPrjTab.UpdUserId  ==  _AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conPrjTab.UpdUserId);
}
else if (conPrjTab.UpdDate  ==  _AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPrjTab.UpdDate);
}
else if (conPrjTab.Memo  ==  _AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPrjTab.Memo);
}
else if (conPrjTab.OrderNum4Refer  ==  _AttributeName[intIndex])
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(conPrjTab.OrderNum4Refer);
}
else if (conPrjTab.IsChecked  ==  _AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsChecked);
}
else if (conPrjTab.Owner  ==  _AttributeName[intIndex])
{
mstrOwner = value.ToString();
 AddUpdatedFld(conPrjTab.Owner);
}
else if (conPrjTab.TabEnName  ==  _AttributeName[intIndex])
{
mstrTabEnName = value.ToString();
 AddUpdatedFld(conPrjTab.TabEnName);
}
else if (conPrjTab.IsNeedTransCode  ==  _AttributeName[intIndex])
{
mbolIsNeedTransCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsNeedTransCode);
}
else if (conPrjTab.TabNameB  ==  _AttributeName[intIndex])
{
mstrTabNameB = value.ToString();
 AddUpdatedFld(conPrjTab.TabNameB);
}
else if (conPrjTab.RelaViewId  ==  _AttributeName[intIndex])
{
mstrRelaViewId = value.ToString();
 AddUpdatedFld(conPrjTab.RelaViewId);
}
else if (conPrjTab.DataBaseName  ==  _AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conPrjTab.DataBaseName);
}
else if (conPrjTab.IsNationStandard  ==  _AttributeName[intIndex])
{
mbolIsNationStandard = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsNationStandard);
}
else if (conPrjTab.IsParaTab  ==  _AttributeName[intIndex])
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsParaTab);
}
else if (conPrjTab.IsArchive  ==  _AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conPrjTab.IsArchive);
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
 AddUpdatedFld(conPrjTab.TabId);
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
 AddUpdatedFld(conPrjTab.TabName);
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
 AddUpdatedFld(conPrjTab.TabCnName);
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
 AddUpdatedFld(conPrjTab.PrjId);
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
 AddUpdatedFld(conPrjTab.SqlDsTypeId);
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
 AddUpdatedFld(conPrjTab.TabStateId);
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
 AddUpdatedFld(conPrjTab.FuncModuleAgcId);
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
 AddUpdatedFld(conPrjTab.IsReleToSqlTab);
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
 AddUpdatedFld(conPrjTab.Keyword);
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
 AddUpdatedFld(conPrjTab.TabTypeId);
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
 AddUpdatedFld(conPrjTab.TabMainTypeId);
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
 AddUpdatedFld(conPrjTab.RelaTabId4View);
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
 AddUpdatedFld(conPrjTab.IsNeedGeneIndexer);
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
 AddUpdatedFld(conPrjTab.ParentClass);
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
 AddUpdatedFld(conPrjTab.IsShare);
}
}
/// <summary>
/// 是否使用删除标记(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseDelSign
{
get
{
return mbolIsUseDelSign;
}
set
{
 mbolIsUseDelSign = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTab.IsUseDelSign);
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
 AddUpdatedFld(conPrjTab.IsUseCache);
}
}
/// <summary>
/// 是否可以多个关键字分类共存(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMultiKeyClassify
{
get
{
return mbolIsMultiKeyClassify;
}
set
{
 mbolIsMultiKeyClassify = value;
//记录修改过的字段
 AddUpdatedFld(conPrjTab.IsMultiKeyClassify);
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
 AddUpdatedFld(conPrjTab.CacheClassifyField);
}
}
/// <summary>
/// 缓存分类字段2(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheClassifyField2
{
get
{
return mstrCacheClassifyField2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheClassifyField2 = value;
}
else
{
 mstrCacheClassifyField2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab.CacheClassifyField2);
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
 AddUpdatedFld(conPrjTab.CacheModeId);
}
}
/// <summary>
/// 缓存分类字段_TS(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheClassifyFieldTS
{
get
{
return mstrCacheClassifyFieldTS;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheClassifyFieldTS = value;
}
else
{
 mstrCacheClassifyFieldTS = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab.CacheClassifyFieldTS);
}
}
/// <summary>
/// 缓存分类字段2_TS(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CacheClassifyField2TS
{
get
{
return mstrCacheClassifyField2TS;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCacheClassifyField2TS = value;
}
else
{
 mstrCacheClassifyField2TS = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab.CacheClassifyField2TS);
}
}
/// <summary>
/// 参数变量2_TS(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaVar2TS
{
get
{
return mstrParaVar2TS;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaVar2TS = value;
}
else
{
 mstrParaVar2TS = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab.ParaVar2TS);
}
}
/// <summary>
/// 参数变量_TS(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParaVar1TS
{
get
{
return mstrParaVar1TS;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParaVar1TS = value;
}
else
{
 mstrParaVar1TS = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab.ParaVar1TS);
}
}
/// <summary>
/// 缓存条件格式(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WhereFormat
{
get
{
return mstrWhereFormat;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWhereFormat = value;
}
else
{
 mstrWhereFormat = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab.WhereFormat);
}
}
/// <summary>
/// 后台缓存条件格式(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WhereFormatBack
{
get
{
return mstrWhereFormatBack;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWhereFormatBack = value;
}
else
{
 mstrWhereFormatBack = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab.WhereFormatBack);
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
 AddUpdatedFld(conPrjTab.IsRefresh4RelaView);
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
 AddUpdatedFld(conPrjTab.TabRecNum);
}
}
/// <summary>
/// 测试关键字Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyId4Test
{
get
{
return mstrKeyId4Test;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyId4Test = value;
}
else
{
 mstrKeyId4Test = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab.KeyId4Test);
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
 AddUpdatedFld(conPrjTab.ErrMsg);
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
 AddUpdatedFld(conPrjTab.FldNum);
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
 AddUpdatedFld(conPrjTab.UpdUserId);
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
 AddUpdatedFld(conPrjTab.UpdDate);
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
 AddUpdatedFld(conPrjTab.Memo);
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
 AddUpdatedFld(conPrjTab.OrderNum4Refer);
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
 AddUpdatedFld(conPrjTab.IsChecked);
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
 AddUpdatedFld(conPrjTab.Owner);
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
 AddUpdatedFld(conPrjTab.TabEnName);
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
 AddUpdatedFld(conPrjTab.IsNeedTransCode);
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
 AddUpdatedFld(conPrjTab.TabNameB);
}
}
/// <summary>
/// RelaViewId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaViewId
{
get
{
return mstrRelaViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaViewId = value;
}
else
{
 mstrRelaViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPrjTab.RelaViewId);
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
 AddUpdatedFld(conPrjTab.DataBaseName);
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
 AddUpdatedFld(conPrjTab.IsNationStandard);
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
 AddUpdatedFld(conPrjTab.IsParaTab);
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
 AddUpdatedFld(conPrjTab.IsArchive);
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
 /// 工程表(PrjTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPrjTab
{
public const string _CurrTabName = "PrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] _AttributeName = new string[] {"TabId", "TabName", "TabCnName", "PrjId", "SqlDsTypeId", "TabStateId", "FuncModuleAgcId", "IsReleToSqlTab", "Keyword", "TabTypeId", "TabMainTypeId", "RelaTabId4View", "IsNeedGeneIndexer", "ParentClass", "IsShare", "IsUseDelSign", "IsUseCache", "IsMultiKeyClassify", "CacheClassifyField", "CacheClassifyField2", "CacheModeId", "CacheClassifyFieldTS", "CacheClassifyField2TS", "ParaVar2TS", "ParaVar1TS", "WhereFormat", "WhereFormatBack", "IsRefresh4RelaView", "TabRecNum", "KeyId4Test", "ErrMsg", "FldNum", "UpdUserId", "UpdDate", "Memo", "OrderNum4Refer", "IsChecked", "Owner", "TabEnName", "IsNeedTransCode", "TabNameB", "RelaViewId", "DataBaseName", "IsNationStandard", "IsParaTab", "IsArchive"};
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
 /// 常量:"IsShare"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShare = "IsShare";    //是否共享

 /// <summary>
 /// 常量:"IsUseDelSign"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseDelSign = "IsUseDelSign";    //是否使用删除标记

 /// <summary>
 /// 常量:"IsUseCache"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseCache = "IsUseCache";    //是否使用Cache

 /// <summary>
 /// 常量:"IsMultiKeyClassify"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMultiKeyClassify = "IsMultiKeyClassify";    //是否可以多个关键字分类共存

 /// <summary>
 /// 常量:"CacheClassifyField"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheClassifyField = "CacheClassifyField";    //缓存分类字段

 /// <summary>
 /// 常量:"CacheClassifyField2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheClassifyField2 = "CacheClassifyField2";    //缓存分类字段2

 /// <summary>
 /// 常量:"CacheModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheModeId = "CacheModeId";    //缓存方式Id

 /// <summary>
 /// 常量:"CacheClassifyFieldTS"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheClassifyFieldTS = "CacheClassifyFieldTS";    //缓存分类字段_TS

 /// <summary>
 /// 常量:"CacheClassifyField2TS"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CacheClassifyField2TS = "CacheClassifyField2TS";    //缓存分类字段2_TS

 /// <summary>
 /// 常量:"ParaVar2TS"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaVar2TS = "ParaVar2TS";    //参数变量2_TS

 /// <summary>
 /// 常量:"ParaVar1TS"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParaVar1TS = "ParaVar1TS";    //参数变量_TS

 /// <summary>
 /// 常量:"WhereFormat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WhereFormat = "WhereFormat";    //缓存条件格式

 /// <summary>
 /// 常量:"WhereFormatBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WhereFormatBack = "WhereFormatBack";    //后台缓存条件格式

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
 /// 常量:"KeyId4Test"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyId4Test = "KeyId4Test";    //测试关键字Id

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldNum = "FldNum";    //字段数

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
 /// 常量:"RelaViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaViewId = "RelaViewId";    //RelaViewId

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名

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
}

}