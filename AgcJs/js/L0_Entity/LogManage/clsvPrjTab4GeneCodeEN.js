
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4GeneCodeEN
 表名:vPrjTab4GeneCode(00050284)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:13
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:日志管理
 模块英文名:LogManage
 框架-层名:实体层RJ(EntityLayerRJ)
 编程语言:JavaScript
 == == == == == == == == == == == == 
 */
var __extends = (this && this.__extends) || (function() {
var extendStatics = function(d, b) {
extendStatics = Object.setPrototypeOf ||
({ __proto__: [] }
instanceof Array && function(d, b) { d.__proto__ = b; }) ||
function(d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
return extendStatics(d, b);
};
return function(d, b) {
extendStatics(d, b);
function __() { this.constructor = d; }
d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
})();
var __importStar = (this && this.__importStar) || function(mod) {
if (mod && mod.__esModule) return mod;
var result = { };
if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
result["default"] = mod;
return result;
};
(function(factory) {
if (typeof module === "object" && typeof module.exports === "object")
{
var v = factory(require, exports);
if (v !== undefined) module.exports = v;
}
else if (typeof define === "function" && define.amd)
{
define(["require", "exports", "jquery", "clsgeneraltab"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsGeneralTab_js_1 = require("clsgeneraltab");
 /// <summary>
 /// vPrjTab4GeneCode(vPrjTab4GeneCode)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvPrjTab4GeneCodeEN = /** @class */ (function (_super) {
__extends(clsvPrjTab4GeneCodeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvPrjTab4GeneCodeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 45;
_this.AttributeName = new Array("TabId", "FldNum", "GeneCodeDate", "IsNeedGene", "Version_GeneCode", "ApplicationTypeId", "TabName", "TabCnName", "PrjId", "PrjName", "IsNeedTransCode", "SQLDSTypeId", "SqlDsTypeName", "TabStateId", "TabStateName", "TabName_B", "IsParaTab", "IsNationStandard", "IsArchive", "IsChecked", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "Owner", "IsReleToSqlTab", "KeyWord", "TabTypeId", "TabTypeName", "TabMainTypeId", "TabMainTypeName", "RelaTabId4View", "OrderNum4Refer", "IsNeedGeneIndexer", "PrimaryTypeId", "PrimaryTypeName", "IsUseCache", "CacheClassifyField", "KeyFldId", "KeyFldName", "UpdUserId", "UpdDate", "Memo", "ErrMsg2", "DataBaseName_Tab", "UserId4GeneCode");
_this.strTabId = ""; //表ID,
_this.intFldNum = 0; //字段数,
_this.strGeneCodeDate = ""; //生成代码日期,
_this.bolIsNeedGene = false; //是否需要生成,
_this.strVersion_GeneCode = ""; //生成代码版本,
_this.intApplicationTypeId = 0; //应用程序类型ID,
_this.strTabName = ""; //表名,
_this.strTabCnName = ""; //表中文名,
_this.strPrjId = ""; //工程ID,
_this.strPrjName = ""; //工程名称,
_this.bolIsNeedTransCode = false; //是否需要转换代码,
_this.strSQLDSTypeId = ""; //数据源类型,
_this.strSqlDsTypeName = ""; //Sql数据源名,
_this.strTabStateId = ""; //表状态ID,
_this.strTabStateName = ""; //表状态名称,
_this.strTabName_B = ""; //表名_后备,
_this.bolIsParaTab = false; //是否参数表,
_this.bolIsNationStandard = false; //是否国标,
_this.bolIsArchive = false; //是否存档,
_this.bolIsChecked = false; //是否核实,
_this.strFuncModuleAgcId = ""; //功能模块Id,
_this.strFuncModuleName = ""; //功能模块名称,
_this.strFuncModuleEnName = ""; //功能模块英文名称,
_this.strOwner = ""; //拥有者,
_this.bolIsReleToSqlTab = false; //是否与SQL表相关,
_this.strKeyWord = ""; //关键字,
_this.strTabTypeId = ""; //表类型Id,
_this.strTabTypeName = ""; //表类型名,
_this.strTabMainTypeId = ""; //表主类型Id,
_this.strTabMainTypeName = ""; //表主类型名,
_this.strRelaTabId4View = ""; //视图的相关表ID,
_this.intOrderNum4Refer = 0; //引用序号,
_this.bolIsNeedGeneIndexer = false; //是否需要生成索引器,
_this.strPrimaryTypeId = ""; //主键类型ID,
_this.strPrimaryTypeName = ""; //主键类型名,
_this.bolIsUseCache = false; //是否使用Cache,
_this.strCacheClassifyField = ""; //缓存分类字段,
_this.strKeyFldId = ""; //关键字段Id,
_this.strKeyFldName = ""; //关键字段名,
_this.strUpdUserId = ""; //修改用户Id,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
_this.strErrMsg2 = ""; //ErrMsg2,
_this.strDataBaseName_Tab = ""; //DataBaseName_Tab,
_this.strUserId4GeneCode = ""; //UserId4GeneCode,
  return _this;
 }

/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabId", {
 get: function ()
{
return this.mstrTabId;
},
 set: function(value)
{
 this.mstrTabId = value;
    this.hmProperty["TabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "FldNum", {
 get: function ()
{
return this.mintFldNum;
},
 set: function(value)
{
 this.mintFldNum = value;
    this.hmProperty["FldNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "GeneCodeDate", {
 get: function ()
{
return this.mstrGeneCodeDate;
},
 set: function(value)
{
 this.mstrGeneCodeDate = value;
    this.hmProperty["GeneCodeDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要生成(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "IsNeedGene", {
 get: function ()
{
return this.mbolIsNeedGene;
},
 set: function(value)
{
 this.mbolIsNeedGene = value;
    this.hmProperty["IsNeedGene"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 生成代码版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "Version_GeneCode", {
 get: function ()
{
return this.mstrVersion_GeneCode;
},
 set: function(value)
{
 this.mstrVersion_GeneCode = value;
    this.hmProperty["Version_GeneCode"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "ApplicationTypeId", {
 get: function ()
{
return this.mintApplicationTypeId;
},
 set: function(value)
{
 this.mintApplicationTypeId = value;
    this.hmProperty["ApplicationTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabName", {
 get: function ()
{
return this.mstrTabName;
},
 set: function(value)
{
 this.mstrTabName = value;
    this.hmProperty["TabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabCnName", {
 get: function ()
{
return this.mstrTabCnName;
},
 set: function(value)
{
 this.mstrTabCnName = value;
    this.hmProperty["TabCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "PrjId", {
 get: function ()
{
return this.mstrPrjId;
},
 set: function(value)
{
 this.mstrPrjId = value;
    this.hmProperty["PrjId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "PrjName", {
 get: function ()
{
return this.mstrPrjName;
},
 set: function(value)
{
 this.mstrPrjName = value;
    this.hmProperty["PrjName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "IsNeedTransCode", {
 get: function ()
{
return this.mbolIsNeedTransCode;
},
 set: function(value)
{
 this.mbolIsNeedTransCode = value;
    this.hmProperty["IsNeedTransCode"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "SQLDSTypeId", {
 get: function ()
{
return this.mstrSQLDSTypeId;
},
 set: function(value)
{
 this.mstrSQLDSTypeId = value;
    this.hmProperty["SQLDSTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "SqlDsTypeName", {
 get: function ()
{
return this.mstrSqlDsTypeName;
},
 set: function(value)
{
 this.mstrSqlDsTypeName = value;
    this.hmProperty["SqlDsTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabStateId", {
 get: function ()
{
return this.mstrTabStateId;
},
 set: function(value)
{
 this.mstrTabStateId = value;
    this.hmProperty["TabStateId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabStateName", {
 get: function ()
{
return this.mstrTabStateName;
},
 set: function(value)
{
 this.mstrTabStateName = value;
    this.hmProperty["TabStateName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabName_B", {
 get: function ()
{
return this.mstrTabName_B;
},
 set: function(value)
{
 this.mstrTabName_B = value;
    this.hmProperty["TabName_B"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "IsParaTab", {
 get: function ()
{
return this.mbolIsParaTab;
},
 set: function(value)
{
 this.mbolIsParaTab = value;
    this.hmProperty["IsParaTab"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "IsNationStandard", {
 get: function ()
{
return this.mbolIsNationStandard;
},
 set: function(value)
{
 this.mbolIsNationStandard = value;
    this.hmProperty["IsNationStandard"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "IsArchive", {
 get: function ()
{
return this.mbolIsArchive;
},
 set: function(value)
{
 this.mbolIsArchive = value;
    this.hmProperty["IsArchive"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "IsChecked", {
 get: function ()
{
return this.mbolIsChecked;
},
 set: function(value)
{
 this.mbolIsChecked = value;
    this.hmProperty["IsChecked"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "FuncModuleAgcId", {
 get: function ()
{
return this.mstrFuncModuleAgcId;
},
 set: function(value)
{
 this.mstrFuncModuleAgcId = value;
    this.hmProperty["FuncModuleAgcId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "FuncModuleName", {
 get: function ()
{
return this.mstrFuncModuleName;
},
 set: function(value)
{
 this.mstrFuncModuleName = value;
    this.hmProperty["FuncModuleName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "FuncModuleEnName", {
 get: function ()
{
return this.mstrFuncModuleEnName;
},
 set: function(value)
{
 this.mstrFuncModuleEnName = value;
    this.hmProperty["FuncModuleEnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "Owner", {
 get: function ()
{
return this.mstrOwner;
},
 set: function(value)
{
 this.mstrOwner = value;
    this.hmProperty["Owner"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否与SQL表相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "IsReleToSqlTab", {
 get: function ()
{
return this.mbolIsReleToSqlTab;
},
 set: function(value)
{
 this.mbolIsReleToSqlTab = value;
    this.hmProperty["IsReleToSqlTab"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "KeyWord", {
 get: function ()
{
return this.mstrKeyWord;
},
 set: function(value)
{
 this.mstrKeyWord = value;
    this.hmProperty["KeyWord"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabTypeId", {
 get: function ()
{
return this.mstrTabTypeId;
},
 set: function(value)
{
 this.mstrTabTypeId = value;
    this.hmProperty["TabTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabTypeName", {
 get: function ()
{
return this.mstrTabTypeName;
},
 set: function(value)
{
 this.mstrTabTypeName = value;
    this.hmProperty["TabTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表主类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabMainTypeId", {
 get: function ()
{
return this.mstrTabMainTypeId;
},
 set: function(value)
{
 this.mstrTabMainTypeId = value;
    this.hmProperty["TabMainTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表主类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "TabMainTypeName", {
 get: function ()
{
return this.mstrTabMainTypeName;
},
 set: function(value)
{
 this.mstrTabMainTypeName = value;
    this.hmProperty["TabMainTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 视图的相关表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "RelaTabId4View", {
 get: function ()
{
return this.mstrRelaTabId4View;
},
 set: function(value)
{
 this.mstrRelaTabId4View = value;
    this.hmProperty["RelaTabId4View"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "OrderNum4Refer", {
 get: function ()
{
return this.mintOrderNum4Refer;
},
 set: function(value)
{
 this.mintOrderNum4Refer = value;
    this.hmProperty["OrderNum4Refer"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要生成索引器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "IsNeedGeneIndexer", {
 get: function ()
{
return this.mbolIsNeedGeneIndexer;
},
 set: function(value)
{
 this.mbolIsNeedGeneIndexer = value;
    this.hmProperty["IsNeedGeneIndexer"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "PrimaryTypeId", {
 get: function ()
{
return this.mstrPrimaryTypeId;
},
 set: function(value)
{
 this.mstrPrimaryTypeId = value;
    this.hmProperty["PrimaryTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "PrimaryTypeName", {
 get: function ()
{
return this.mstrPrimaryTypeName;
},
 set: function(value)
{
 this.mstrPrimaryTypeName = value;
    this.hmProperty["PrimaryTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否使用Cache(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "IsUseCache", {
 get: function ()
{
return this.mbolIsUseCache;
},
 set: function(value)
{
 this.mbolIsUseCache = value;
    this.hmProperty["IsUseCache"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 缓存分类字段(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "CacheClassifyField", {
 get: function ()
{
return this.mstrCacheClassifyField;
},
 set: function(value)
{
 this.mstrCacheClassifyField = value;
    this.hmProperty["CacheClassifyField"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 关键字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "KeyFldId", {
 get: function ()
{
return this.mstrKeyFldId;
},
 set: function(value)
{
 this.mstrKeyFldId = value;
    this.hmProperty["KeyFldId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 关键字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "KeyFldName", {
 get: function ()
{
return this.mstrKeyFldName;
},
 set: function(value)
{
 this.mstrKeyFldName = value;
    this.hmProperty["KeyFldName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "UpdUserId", {
 get: function ()
{
return this.mstrUpdUserId;
},
 set: function(value)
{
 this.mstrUpdUserId = value;
    this.hmProperty["UpdUserId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "UpdDate", {
 get: function ()
{
return this.mstrUpdDate;
},
 set: function(value)
{
 this.mstrUpdDate = value;
    this.hmProperty["UpdDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "Memo", {
 get: function ()
{
return this.mstrMemo;
},
 set: function(value)
{
 this.mstrMemo = value;
    this.hmProperty["Memo"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ErrMsg2(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "ErrMsg2", {
 get: function ()
{
return this.mstrErrMsg2;
},
 set: function(value)
{
 this.mstrErrMsg2 = value;
    this.hmProperty["ErrMsg2"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// DataBaseName_Tab(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "DataBaseName_Tab", {
 get: function ()
{
return this.mstrDataBaseName_Tab;
},
 set: function(value)
{
 this.mstrDataBaseName_Tab = value;
    this.hmProperty["DataBaseName_Tab"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// UserId4GeneCode(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN.prototype, "UserId4GeneCode", {
 get: function ()
{
return this.mstrUserId4GeneCode;
},
 set: function(value)
{
 this.mstrUserId4GeneCode = value;
    this.hmProperty["UserId4GeneCode"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabId", {
 get: function () {return "TabId";}  // 表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_FldNum", {
 get: function () {return "FldNum";}  // 字段数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_GeneCodeDate", {
 get: function () {return "GeneCodeDate";}  // 生成代码日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedGene"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_IsNeedGene", {
 get: function () {return "IsNeedGene";}  // 是否需要生成
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Version_GeneCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_Version_GeneCode", {
 get: function () {return "Version_GeneCode";}  // 生成代码版本
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_ApplicationTypeId", {
 get: function () {return "ApplicationTypeId";}  // 应用程序类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabName", {
 get: function () {return "TabName";}  // 表名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabCnName", {
 get: function () {return "TabCnName";}  // 表中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_PrjName", {
 get: function () {return "PrjName";}  // 工程名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_IsNeedTransCode", {
 get: function () {return "IsNeedTransCode";}  // 是否需要转换代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_SQLDSTypeId", {
 get: function () {return "SQLDSTypeId";}  // 数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_SqlDsTypeName", {
 get: function () {return "SqlDsTypeName";}  // Sql数据源名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabStateId", {
 get: function () {return "TabStateId";}  // 表状态ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabStateName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabStateName", {
 get: function () {return "TabStateName";}  // 表状态名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName_B"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabName_B", {
 get: function () {return "TabName_B";}  // 表名_后备
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsParaTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_IsParaTab", {
 get: function () {return "IsParaTab";}  // 是否参数表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNationStandard"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_IsNationStandard", {
 get: function () {return "IsNationStandard";}  // 是否国标
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsArchive"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_IsArchive", {
 get: function () {return "IsArchive";}  // 是否存档
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsChecked"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_IsChecked", {
 get: function () {return "IsChecked";}  // 是否核实
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_FuncModuleAgcId", {
 get: function () {return "FuncModuleAgcId";}  // 功能模块Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_FuncModuleName", {
 get: function () {return "FuncModuleName";}  // 功能模块名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_FuncModuleEnName", {
 get: function () {return "FuncModuleEnName";}  // 功能模块英文名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Owner"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_Owner", {
 get: function () {return "Owner";}  // 拥有者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsReleToSqlTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_IsReleToSqlTab", {
 get: function () {return "IsReleToSqlTab";}  // 是否与SQL表相关
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyWord"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_KeyWord", {
 get: function () {return "KeyWord";}  // 关键字
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabTypeId", {
 get: function () {return "TabTypeId";}  // 表类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabTypeName", {
 get: function () {return "TabTypeName";}  // 表类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabMainTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabMainTypeId", {
 get: function () {return "TabMainTypeId";}  // 表主类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabMainTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_TabMainTypeName", {
 get: function () {return "TabMainTypeName";}  // 表主类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RelaTabId4View"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_RelaTabId4View", {
 get: function () {return "RelaTabId4View";}  // 视图的相关表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum4Refer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_OrderNum4Refer", {
 get: function () {return "OrderNum4Refer";}  // 引用序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedGeneIndexer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_IsNeedGeneIndexer", {
 get: function () {return "IsNeedGeneIndexer";}  // 是否需要生成索引器
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_PrimaryTypeId", {
 get: function () {return "PrimaryTypeId";}  // 主键类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_PrimaryTypeName", {
 get: function () {return "PrimaryTypeName";}  // 主键类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsUseCache"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_IsUseCache", {
 get: function () {return "IsUseCache";}  // 是否使用Cache
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CacheClassifyField"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_CacheClassifyField", {
 get: function () {return "CacheClassifyField";}  // 缓存分类字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_KeyFldId", {
 get: function () {return "KeyFldId";}  // 关键字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyFldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_KeyFldName", {
 get: function () {return "KeyFldName";}  // 关键字段名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_UpdUserId", {
 get: function () {return "UpdUserId";}  // 修改用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ErrMsg2"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_ErrMsg2", {
 get: function () {return "ErrMsg2";}  // ErrMsg2
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataBaseName_Tab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_DataBaseName_Tab", {
 get: function () {return "DataBaseName_Tab";}  // DataBaseName_Tab
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserId4GeneCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4GeneCodeEN, "con_UserId4GeneCode", {
 get: function () {return "UserId4GeneCode";}  // UserId4GeneCode
,
    enumerable: true,
    configurable: true
});

clsvPrjTab4GeneCodeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
this[strFldName] = strFldValue;
if (this.dicFldComparisonOp.hasOwnProperty(strFldName) == false)
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
else
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
}
clsvPrjTab4GeneCodeEN._CurrTabName = "vPrjTab4GeneCode"; //当前表名,与该类相关的表名
clsvPrjTab4GeneCodeEN._KeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvPrjTab4GeneCodeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvPrjTab4GeneCodeEN = clsvPrjTab4GeneCodeEN;
});