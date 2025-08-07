
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:jsvPrjTabEN
 表名:vPrjTab
 生成代码版本:2017.07.08.1
 生成日期:2017/07/11 06:31:16
 生成者:
 生成服务器IP:1011.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:字段、表维护
 模块英文名:Table_Field
 框架-层名:实体层
 编程语言:JavaScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 == == == == == == == == == == == == 
 */
 /// <summary>
 /// v工程表(vPrjTab)
 /// (AutoGCLib.AutoGC6Js_M:A_GenEntityLayerCode)
 /// </summary>
/// <reference path="../PubFun/jsGeneralTab.js" />
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中
include(VirtualRootPath + "/js/PubFun/jsGeneralTab.js");
var clsvPrjTabEN = function(strTabId)
{
clsvPrjTabEN.prototype = new clsGeneralTab();
clsGeneralTab.call(this);
this.TabId = strTabId || "";
var CurrTabName_S = "vPrjTab"; //当前表名,与该类相关的表名
var CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
var mintAttributeCount = 42;
var AttributeName = new Array("TabId", "FldNum", "GeneCodeDate", "IsNeedGene", "TabName", "TabEnName", "TabCnName", "PrjId", "PrjName", "IsNeedTransCode", "SQLDSTypeId", "SqlDsTypeName", "TabStateId", "TabStateName", "TabName_B", "IsParaTab", "IsNationStandard", "IsArchive", "IsChecked", "ErrMsg", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "Owner", "IsReleToSqlTab", "KeyWord", "TabTypeId", "TabTypeName", "RelaTabId4View", "IsNeedCheckTab", "OrderNum4Refer", "IsNeedGeneIndexer", "KeyFldId", "KeyFldName", "PrimaryTypeId", "PrimaryTypeName", "UpdUserId", "UpdDate", "Memo", "DataBaseName_Tab", "RelaTabName4View", "UpdDate2");
//以下是属性变量

var TabId;    //表ID
var FldNum;    //FldNum
var GeneCodeDate;    //生成代码日期
var IsNeedGene;    //是否需要生成
var TabName;    //表名
var TabEnName;    //表英文详细名
var TabCnName;    //表中文名
var PrjId;    //工程ID
var PrjName;    //工程名称
var IsNeedTransCode;    //是否需要转换代码
var SQLDSTypeId;    //数据源类型
var SqlDsTypeName;    //Sql数据源名
var TabStateId;    //表状态ID
var TabStateName;    //表状态名称
var TabName_B;    //表名_后备
var IsParaTab;    //是否参数表
var IsNationStandard;    //是否国标
var IsArchive;    //是否存档
var IsChecked;    //是否核实
var ErrMsg;    //错误信息
var FuncModuleAgcId;    //功能模块Id
var FuncModuleName;    //功能模块名称
var FuncModuleEnName;    //功能模块英文名称
var Owner;    //拥有者
var IsReleToSqlTab;    //是否与SQL表相关
var KeyWord;    //关键字
var TabTypeId;    //表类型Id
var TabTypeName;    //表类型名
var RelaTabId4View;    //视图的相关表ID
var IsNeedCheckTab;    //是否需要检查表字段
var OrderNum4Refer;    //引用序号
var IsNeedGeneIndexer;    //是否需要生成索引器
var KeyFldId;    //关键字Id列表
var KeyFldName;    //关键字名称列表
var PrimaryTypeId;    //主键类型ID
var PrimaryTypeName;    //主键类型名
var UpdUserId;    //修改用户Id
var UpdDate;    //修改日期
var Memo;    //说明
var DataBaseName_Tab;    //DataBaseName_Tab
var RelaTabName4View;    //RelaTabName4View
var UpdDate2;    //UpdDate2


 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FldNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_FldNum = "FldNum";    //FldNum

 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_GeneCodeDate = "GeneCodeDate";    //生成代码日期

 /// <summary>
 /// 常量:"IsNeedGene"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_IsNeedGene = "IsNeedGene";    //是否需要生成

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"TabEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_TabEnName = "TabEnName";    //表英文详细名

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_IsNeedTransCode = "IsNeedTransCode";    //是否需要转换代码

 /// <summary>
 /// 常量:"SQLDSTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_SQLDSTypeId = "SQLDSTypeId";    //数据源类型

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"TabStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_TabStateName = "TabStateName";    //表状态名称

 /// <summary>
 /// 常量:"TabName_B"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_TabName_B = "TabName_B";    //表名_后备

 /// <summary>
 /// 常量:"IsParaTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_IsParaTab = "IsParaTab";    //是否参数表

 /// <summary>
 /// 常量:"IsNationStandard"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_IsNationStandard = "IsNationStandard";    //是否国标

 /// <summary>
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_IsArchive = "IsArchive";    //是否存档

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_IsChecked = "IsChecked";    //是否核实

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_FuncModuleEnName = "FuncModuleEnName";    //功能模块英文名称

 /// <summary>
 /// 常量:"Owner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_Owner = "Owner";    //拥有者

 /// <summary>
 /// 常量:"IsReleToSqlTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_IsReleToSqlTab = "IsReleToSqlTab";    //是否与SQL表相关

 /// <summary>
 /// 常量:"KeyWord"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_KeyWord = "KeyWord";    //关键字

 /// <summary>
 /// 常量:"TabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_TabTypeId = "TabTypeId";    //表类型Id

 /// <summary>
 /// 常量:"TabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_TabTypeName = "TabTypeName";    //表类型名

 /// <summary>
 /// 常量:"RelaTabId4View"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_RelaTabId4View = "RelaTabId4View";    //视图的相关表ID

 /// <summary>
 /// 常量:"IsNeedCheckTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_IsNeedCheckTab = "IsNeedCheckTab";    //是否需要检查表字段

 /// <summary>
 /// 常量:"OrderNum4Refer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_OrderNum4Refer = "OrderNum4Refer";    //引用序号

 /// <summary>
 /// 常量:"IsNeedGeneIndexer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_IsNeedGeneIndexer = "IsNeedGeneIndexer";    //是否需要生成索引器

 /// <summary>
 /// 常量:"KeyFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_KeyFldId = "KeyFldId";    //关键字Id列表

 /// <summary>
 /// 常量:"KeyFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_KeyFldName = "KeyFldName";    //关键字名称列表

 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_PrimaryTypeName = "PrimaryTypeName";    //主键类型名

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"DataBaseName_Tab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_DataBaseName_Tab = "DataBaseName_Tab";    //DataBaseName_Tab

 /// <summary>
 /// 常量:"RelaTabName4View"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_RelaTabName4View = "RelaTabName4View";    //RelaTabName4View

 /// <summary>
 /// 常量:"UpdDate2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 var con_UpdDate2 = "UpdDate2";    //UpdDate2

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1_JavaScript)
/// </summary>
 this.init = function()
 {
 this.hmProperty = new Dictionary();
 this.SetInit();
 CurrTabName = "vPrjTab";
 KeyFldName = "TabId";
 }


/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabId = function()
{
return this.TabId;
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabId = function(value)
{
 this.TabId = value;
    this.hmProperty.add("TabId", "true");
}

/// <summary>
/// FldNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getFldNum = function()
{
return this.FldNum;
}
/// <summary>
/// FldNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setFldNum = function(value)
{
 this.FldNum = value;
    this.hmProperty.add("FldNum", "true");
}

/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getGeneCodeDate = function()
{
return this.GeneCodeDate;
}
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setGeneCodeDate = function(value)
{
 this.GeneCodeDate = value;
    this.hmProperty.add("GeneCodeDate", "true");
}

/// <summary>
/// 是否需要生成(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNeedGene = function()
{
return this.IsNeedGene;
}
/// <summary>
/// 是否需要生成(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNeedGene = function(value)
{
 this.IsNeedGene = value;
    this.hmProperty.add("IsNeedGene", "true");
}

/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabName = function()
{
return this.TabName;
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabName = function(value)
{
 this.TabName = value;
    this.hmProperty.add("TabName", "true");
}

/// <summary>
/// 表英文详细名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabEnName = function()
{
return this.TabEnName;
}
/// <summary>
/// 表英文详细名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabEnName = function(value)
{
 this.TabEnName = value;
    this.hmProperty.add("TabEnName", "true");
}

/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabCnName = function()
{
return this.TabCnName;
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabCnName = function(value)
{
 this.TabCnName = value;
    this.hmProperty.add("TabCnName", "true");
}

/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getPrjId = function()
{
return this.PrjId;
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setPrjId = function(value)
{
 this.PrjId = value;
    this.hmProperty.add("PrjId", "true");
}

/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getPrjName = function()
{
return this.PrjName;
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setPrjName = function(value)
{
 this.PrjName = value;
    this.hmProperty.add("PrjName", "true");
}

/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNeedTransCode = function()
{
return this.IsNeedTransCode;
}
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNeedTransCode = function(value)
{
 this.IsNeedTransCode = value;
    this.hmProperty.add("IsNeedTransCode", "true");
}

/// <summary>
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getSQLDSTypeId = function()
{
return this.SQLDSTypeId;
}
/// <summary>
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setSQLDSTypeId = function(value)
{
 this.SQLDSTypeId = value;
    this.hmProperty.add("SQLDSTypeId", "true");
}

/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getSqlDsTypeName = function()
{
return this.SqlDsTypeName;
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setSqlDsTypeName = function(value)
{
 this.SqlDsTypeName = value;
    this.hmProperty.add("SqlDsTypeName", "true");
}

/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabStateId = function()
{
return this.TabStateId;
}
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabStateId = function(value)
{
 this.TabStateId = value;
    this.hmProperty.add("TabStateId", "true");
}

/// <summary>
/// 表状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabStateName = function()
{
return this.TabStateName;
}
/// <summary>
/// 表状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabStateName = function(value)
{
 this.TabStateName = value;
    this.hmProperty.add("TabStateName", "true");
}

/// <summary>
/// 表名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabName_B = function()
{
return this.TabName_B;
}
/// <summary>
/// 表名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabName_B = function(value)
{
 this.TabName_B = value;
    this.hmProperty.add("TabName_B", "true");
}

/// <summary>
/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsParaTab = function()
{
return this.IsParaTab;
}
/// <summary>
/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsParaTab = function(value)
{
 this.IsParaTab = value;
    this.hmProperty.add("IsParaTab", "true");
}

/// <summary>
/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNationStandard = function()
{
return this.IsNationStandard;
}
/// <summary>
/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNationStandard = function(value)
{
 this.IsNationStandard = value;
    this.hmProperty.add("IsNationStandard", "true");
}

/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsArchive = function()
{
return this.IsArchive;
}
/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsArchive = function(value)
{
 this.IsArchive = value;
    this.hmProperty.add("IsArchive", "true");
}

/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsChecked = function()
{
return this.IsChecked;
}
/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsChecked = function(value)
{
 this.IsChecked = value;
    this.hmProperty.add("IsChecked", "true");
}

/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getErrMsg = function()
{
return this.ErrMsg;
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setErrMsg = function(value)
{
 this.ErrMsg = value;
    this.hmProperty.add("ErrMsg", "true");
}

/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getFuncModuleAgcId = function()
{
return this.FuncModuleAgcId;
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setFuncModuleAgcId = function(value)
{
 this.FuncModuleAgcId = value;
    this.hmProperty.add("FuncModuleAgcId", "true");
}

/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getFuncModuleName = function()
{
return this.FuncModuleName;
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setFuncModuleName = function(value)
{
 this.FuncModuleName = value;
    this.hmProperty.add("FuncModuleName", "true");
}

/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getFuncModuleEnName = function()
{
return this.FuncModuleEnName;
}
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setFuncModuleEnName = function(value)
{
 this.FuncModuleEnName = value;
    this.hmProperty.add("FuncModuleEnName", "true");
}

/// <summary>
/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getOwner = function()
{
return this.Owner;
}
/// <summary>
/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setOwner = function(value)
{
 this.Owner = value;
    this.hmProperty.add("Owner", "true");
}

/// <summary>
/// 是否与SQL表相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsReleToSqlTab = function()
{
return this.IsReleToSqlTab;
}
/// <summary>
/// 是否与SQL表相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsReleToSqlTab = function(value)
{
 this.IsReleToSqlTab = value;
    this.hmProperty.add("IsReleToSqlTab", "true");
}

/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getKeyword = function()
{
return this.KeyWord;
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setKeyword = function(value)
{
 this.KeyWord = value;
    this.hmProperty.add("KeyWord", "true");
}

/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabTypeId = function()
{
return this.TabTypeId;
}
/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabTypeId = function(value)
{
 this.TabTypeId = value;
    this.hmProperty.add("TabTypeId", "true");
}

/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getTabTypeName = function()
{
return this.TabTypeName;
}
/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setTabTypeName = function(value)
{
 this.TabTypeName = value;
    this.hmProperty.add("TabTypeName", "true");
}

/// <summary>
/// 视图的相关表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getRelaTabId4View = function()
{
return this.RelaTabId4View;
}
/// <summary>
/// 视图的相关表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setRelaTabId4View = function(value)
{
 this.RelaTabId4View = value;
    this.hmProperty.add("RelaTabId4View", "true");
}

/// <summary>
/// 是否需要检查表字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNeedCheckTab = function()
{
return this.IsNeedCheckTab;
}
/// <summary>
/// 是否需要检查表字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNeedCheckTab = function(value)
{
 this.IsNeedCheckTab = value;
    this.hmProperty.add("IsNeedCheckTab", "true");
}

/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getOrderNum4Refer = function()
{
return this.OrderNum4Refer;
}
/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setOrderNum4Refer = function(value)
{
 this.OrderNum4Refer = value;
    this.hmProperty.add("OrderNum4Refer", "true");
}

/// <summary>
/// 是否需要生成索引器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getIsNeedGeneIndexer = function()
{
return this.IsNeedGeneIndexer;
}
/// <summary>
/// 是否需要生成索引器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setIsNeedGeneIndexer = function(value)
{
 this.IsNeedGeneIndexer = value;
    this.hmProperty.add("IsNeedGeneIndexer", "true");
}

/// <summary>
/// 关键字Id列表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getKeyFldId = function()
{
return this.KeyFldId;
}
/// <summary>
/// 关键字Id列表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setKeyFldId = function(value)
{
 this.KeyFldId = value;
    this.hmProperty.add("KeyFldId", "true");
}

/// <summary>
/// 关键字名称列表(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getKeyFldName = function()
{
return this.KeyFldName;
}
/// <summary>
/// 关键字名称列表(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setKeyFldName = function(value)
{
 this.KeyFldName = value;
    this.hmProperty.add("KeyFldName", "true");
}

/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getPrimaryTypeId = function()
{
return this.PrimaryTypeId;
}
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setPrimaryTypeId = function(value)
{
 this.PrimaryTypeId = value;
    this.hmProperty.add("PrimaryTypeId", "true");
}

/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getPrimaryTypeName = function()
{
return this.PrimaryTypeName;
}
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setPrimaryTypeName = function(value)
{
 this.PrimaryTypeName = value;
    this.hmProperty.add("PrimaryTypeName", "true");
}

/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getUpdUserId = function()
{
return this.UpdUserId;
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setUpdUserId = function(value)
{
 this.UpdUserId = value;
    this.hmProperty.add("UpdUserId", "true");
}

/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getUpdDate = function()
{
return this.UpdDate;
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setUpdDate = function(value)
{
 this.UpdDate = value;
    this.hmProperty.add("UpdDate", "true");
}

/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getMemo = function()
{
return this.Memo;
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setMemo = function(value)
{
 this.Memo = value;
    this.hmProperty.add("Memo", "true");
}

/// <summary>
/// DataBaseName_Tab(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getDataBaseName_Tab = function()
{
return this.DataBaseName_Tab;
}
/// <summary>
/// DataBaseName_Tab(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setDataBaseName_Tab = function(value)
{
 this.DataBaseName_Tab = value;
    this.hmProperty.add("DataBaseName_Tab", "true");
}

/// <summary>
/// RelaTabName4View(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getRelaTabName4View = function()
{
return this.RelaTabName4View;
}
/// <summary>
/// RelaTabName4View(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setRelaTabName4View = function(value)
{
 this.RelaTabName4View = value;
    this.hmProperty.add("RelaTabName4View", "true");
}

/// <summary>
/// UpdDate2(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.getUpdDate2 = function()
{
return this.UpdDate2;
}
/// <summary>
/// UpdDate2(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 this.setUpdDate2 = function(value)
{
 this.UpdDate2 = value;
    this.hmProperty.add("UpdDate2", "true");
}
this.init();
}