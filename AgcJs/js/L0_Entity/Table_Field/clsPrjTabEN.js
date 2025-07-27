
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabEN
 表名:PrjTab(00050009)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:05:55
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
 /// 工程表(PrjTab)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsPrjTabEN = /** @class */ (function (_super) {
__extends(clsPrjTabEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsPrjTabEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 44;
_this.AttributeName = new Array("TabId", "TabName", "TabCnName", "PrjId", "SQLDSTypeId", "TabStateId", "FuncModuleAgcId", "IsReleToSqlTab", "KeyWord", "TabTypeId", "TabMainTypeId", "RelaTabId4View", "IsNeedGeneIndexer", "ParentClass", "IsUseCache", "CacheModeId", "CacheClassifyField", "UpdUserId", "UpdDate", "Memo", "ErrMsg", "KeyFldId", "KeyFldName", "PrimaryTypeId", "PrimaryTypeName", "OrderNum4Refer", "IsNeedCheckTab", "IsChecked", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource", "RelaViewId", "Owner", "TabEnName", "IsNeedTransCode", "TabName_B", "DataBaseName", "IsNationStandard", "IsParaTab", "IsArchive");
_this.strTabId = ""; //表ID,
_this.strTabName = ""; //表名,
_this.strTabCnName = ""; //表中文名,
_this.strPrjId = ""; //工程ID,
_this.strSQLDSTypeId = ""; //数据源类型,
_this.strTabStateId = ""; //表状态ID,
_this.strFuncModuleAgcId = ""; //功能模块Id,
_this.bolIsReleToSqlTab = false; //是否与SQL表相关,
_this.strKeyWord = ""; //关键字,
_this.strTabTypeId = ""; //表类型Id,
_this.strTabMainTypeId = ""; //表主类型Id,
_this.strRelaTabId4View = ""; //视图的相关表ID,
_this.bolIsNeedGeneIndexer = false; //是否需要生成索引器,
_this.strParentClass = ""; //父类,
_this.bolIsUseCache = false; //是否使用Cache,
_this.strCacheModeId = ""; //缓存方式Id,
_this.strCacheClassifyField = ""; //缓存分类字段,
_this.strUpdUserId = ""; //修改用户Id,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
_this.strErrMsg = ""; //错误信息,
_this.strKeyFldId = ""; //关键字段Id,
_this.strKeyFldName = ""; //关键字段名,
_this.strPrimaryTypeId = ""; //主键类型ID,
_this.strPrimaryTypeName = ""; //主键类型名,
_this.intOrderNum4Refer = 0; //引用序号,
_this.bolIsNeedCheckTab = false; //是否需要检查表字段,
_this.bolIsChecked = false; //是否核实,
_this.bolIsSynchToServer = false; //是否同步到Server,
_this.strSynchToServerDate = ""; //同步到Server日期,
_this.strSynchToServerUser = ""; //同步到Server用户,
_this.bolIsSynchToClient = false; //是否同步到Client,
_this.strSynchToClientDate = ""; //同步到Client库日期,
_this.strSynchToClientUser = ""; //同步到Client库用户,
_this.strSynSource = ""; //同步来源,
_this.strRelaViewId = ""; //RelaViewId,
_this.strOwner = ""; //拥有者,
_this.strTabEnName = ""; //表英文详细名,
_this.bolIsNeedTransCode = false; //是否需要转换代码,
_this.strTabName_B = ""; //表名_后备,
_this.strDataBaseName = ""; //数据库名,
_this.bolIsNationStandard = false; //是否国标,
_this.bolIsParaTab = false; //是否参数表,
_this.bolIsArchive = false; //是否存档,
  return _this;
 }

/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "TabId", {
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
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "TabName", {
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
Object.defineProperty(clsPrjTabEN.prototype, "TabCnName", {
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
Object.defineProperty(clsPrjTabEN.prototype, "PrjId", {
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
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "SQLDSTypeId", {
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
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "TabStateId", {
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
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "FuncModuleAgcId", {
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
/// 是否与SQL表相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsReleToSqlTab", {
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
Object.defineProperty(clsPrjTabEN.prototype, "KeyWord", {
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
Object.defineProperty(clsPrjTabEN.prototype, "TabTypeId", {
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
/// 表主类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "TabMainTypeId", {
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
/// 视图的相关表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "RelaTabId4View", {
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
/// 是否需要生成索引器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsNeedGeneIndexer", {
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
/// 父类(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "ParentClass", {
 get: function ()
{
return this.mstrParentClass;
},
 set: function(value)
{
 this.mstrParentClass = value;
    this.hmProperty["ParentClass"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否使用Cache(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsUseCache", {
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
/// 缓存方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "CacheModeId", {
 get: function ()
{
return this.mstrCacheModeId;
},
 set: function(value)
{
 this.mstrCacheModeId = value;
    this.hmProperty["CacheModeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 缓存分类字段(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "CacheClassifyField", {
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
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "UpdUserId", {
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
Object.defineProperty(clsPrjTabEN.prototype, "UpdDate", {
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
Object.defineProperty(clsPrjTabEN.prototype, "Memo", {
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
/// 错误信息(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "ErrMsg", {
 get: function ()
{
return this.mstrErrMsg;
},
 set: function(value)
{
 this.mstrErrMsg = value;
    this.hmProperty["ErrMsg"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 关键字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "KeyFldId", {
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
Object.defineProperty(clsPrjTabEN.prototype, "KeyFldName", {
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
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "PrimaryTypeId", {
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
Object.defineProperty(clsPrjTabEN.prototype, "PrimaryTypeName", {
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
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "OrderNum4Refer", {
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
/// 是否需要检查表字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsNeedCheckTab", {
 get: function ()
{
return this.mbolIsNeedCheckTab;
},
 set: function(value)
{
 this.mbolIsNeedCheckTab = value;
    this.hmProperty["IsNeedCheckTab"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsChecked", {
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
/// 是否同步到Server(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsSynchToServer", {
 get: function ()
{
return this.mbolIsSynchToServer;
},
 set: function(value)
{
 this.mbolIsSynchToServer = value;
    this.hmProperty["IsSynchToServer"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步到Server日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "SynchToServerDate", {
 get: function ()
{
return this.mstrSynchToServerDate;
},
 set: function(value)
{
 this.mstrSynchToServerDate = value;
    this.hmProperty["SynchToServerDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步到Server用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "SynchToServerUser", {
 get: function ()
{
return this.mstrSynchToServerUser;
},
 set: function(value)
{
 this.mstrSynchToServerUser = value;
    this.hmProperty["SynchToServerUser"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否同步到Client(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsSynchToClient", {
 get: function ()
{
return this.mbolIsSynchToClient;
},
 set: function(value)
{
 this.mbolIsSynchToClient = value;
    this.hmProperty["IsSynchToClient"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步到Client库日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "SynchToClientDate", {
 get: function ()
{
return this.mstrSynchToClientDate;
},
 set: function(value)
{
 this.mstrSynchToClientDate = value;
    this.hmProperty["SynchToClientDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步到Client库用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "SynchToClientUser", {
 get: function ()
{
return this.mstrSynchToClientUser;
},
 set: function(value)
{
 this.mstrSynchToClientUser = value;
    this.hmProperty["SynchToClientUser"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步来源(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "SynSource", {
 get: function ()
{
return this.mstrSynSource;
},
 set: function(value)
{
 this.mstrSynSource = value;
    this.hmProperty["SynSource"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// RelaViewId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "RelaViewId", {
 get: function ()
{
return this.mstrRelaViewId;
},
 set: function(value)
{
 this.mstrRelaViewId = value;
    this.hmProperty["RelaViewId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "Owner", {
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
/// 表英文详细名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "TabEnName", {
 get: function ()
{
return this.mstrTabEnName;
},
 set: function(value)
{
 this.mstrTabEnName = value;
    this.hmProperty["TabEnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsNeedTransCode", {
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
/// 表名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "TabName_B", {
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
/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "DataBaseName", {
 get: function ()
{
return this.mstrDataBaseName;
},
 set: function(value)
{
 this.mstrDataBaseName = value;
    this.hmProperty["DataBaseName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsNationStandard", {
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
/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsParaTab", {
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
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsPrjTabEN.prototype, "IsArchive", {
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
 /// 常量:"TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_TabId", {
 get: function () {return "TabId";}  // 表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_TabName", {
 get: function () {return "TabName";}  // 表名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_TabCnName", {
 get: function () {return "TabCnName";}  // 表中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_SQLDSTypeId", {
 get: function () {return "SQLDSTypeId";}  // 数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_TabStateId", {
 get: function () {return "TabStateId";}  // 表状态ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_FuncModuleAgcId", {
 get: function () {return "FuncModuleAgcId";}  // 功能模块Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsReleToSqlTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsReleToSqlTab", {
 get: function () {return "IsReleToSqlTab";}  // 是否与SQL表相关
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyWord"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_KeyWord", {
 get: function () {return "KeyWord";}  // 关键字
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_TabTypeId", {
 get: function () {return "TabTypeId";}  // 表类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabMainTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_TabMainTypeId", {
 get: function () {return "TabMainTypeId";}  // 表主类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RelaTabId4View"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_RelaTabId4View", {
 get: function () {return "RelaTabId4View";}  // 视图的相关表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedGeneIndexer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsNeedGeneIndexer", {
 get: function () {return "IsNeedGeneIndexer";}  // 是否需要生成索引器
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ParentClass"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_ParentClass", {
 get: function () {return "ParentClass";}  // 父类
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsUseCache"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsUseCache", {
 get: function () {return "IsUseCache";}  // 是否使用Cache
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CacheModeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_CacheModeId", {
 get: function () {return "CacheModeId";}  // 缓存方式Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CacheClassifyField"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_CacheClassifyField", {
 get: function () {return "CacheClassifyField";}  // 缓存分类字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_UpdUserId", {
 get: function () {return "UpdUserId";}  // 修改用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ErrMsg"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_ErrMsg", {
 get: function () {return "ErrMsg";}  // 错误信息
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_KeyFldId", {
 get: function () {return "KeyFldId";}  // 关键字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyFldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_KeyFldName", {
 get: function () {return "KeyFldName";}  // 关键字段名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_PrimaryTypeId", {
 get: function () {return "PrimaryTypeId";}  // 主键类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_PrimaryTypeName", {
 get: function () {return "PrimaryTypeName";}  // 主键类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum4Refer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_OrderNum4Refer", {
 get: function () {return "OrderNum4Refer";}  // 引用序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedCheckTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsNeedCheckTab", {
 get: function () {return "IsNeedCheckTab";}  // 是否需要检查表字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsChecked"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsChecked", {
 get: function () {return "IsChecked";}  // 是否核实
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToServer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsSynchToServer", {
 get: function () {return "IsSynchToServer";}  // 是否同步到Server
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_SynchToServerDate", {
 get: function () {return "SynchToServerDate";}  // 同步到Server日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_SynchToServerUser", {
 get: function () {return "SynchToServerUser";}  // 同步到Server用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToClient"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsSynchToClient", {
 get: function () {return "IsSynchToClient";}  // 是否同步到Client
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_SynchToClientDate", {
 get: function () {return "SynchToClientDate";}  // 同步到Client库日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_SynchToClientUser", {
 get: function () {return "SynchToClientUser";}  // 同步到Client库用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynSource"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_SynSource", {
 get: function () {return "SynSource";}  // 同步来源
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RelaViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_RelaViewId", {
 get: function () {return "RelaViewId";}  // RelaViewId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Owner"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_Owner", {
 get: function () {return "Owner";}  // 拥有者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabEnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_TabEnName", {
 get: function () {return "TabEnName";}  // 表英文详细名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsNeedTransCode", {
 get: function () {return "IsNeedTransCode";}  // 是否需要转换代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName_B"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_TabName_B", {
 get: function () {return "TabName_B";}  // 表名_后备
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataBaseName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_DataBaseName", {
 get: function () {return "DataBaseName";}  // 数据库名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNationStandard"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsNationStandard", {
 get: function () {return "IsNationStandard";}  // 是否国标
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsParaTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsParaTab", {
 get: function () {return "IsParaTab";}  // 是否参数表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsArchive"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsPrjTabEN, "con_IsArchive", {
 get: function () {return "IsArchive";}  // 是否存档
,
    enumerable: true,
    configurable: true
});

clsPrjTabEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsPrjTabEN._CurrTabName = "PrjTab"; //当前表名,与该类相关的表名
clsPrjTabEN._KeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsPrjTabEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsPrjTabEN = clsPrjTabEN;
});