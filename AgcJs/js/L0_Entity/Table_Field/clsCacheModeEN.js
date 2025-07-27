
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCacheModeEN
 表名:CacheMode(00050538)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:02
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
 /// 缓存方式(CacheMode)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsCacheModeEN = /** @class */ (function (_super) {
__extends(clsCacheModeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsCacheModeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 4;
_this.AttributeName = new Array("CacheModeId", "CacheModeName", "CacheModeENName", "Memo");
_this.strCacheModeId = ""; //缓存方式Id,
_this.strCacheModeName = ""; //缓存方式名,
_this.strCacheModeENName = ""; //缓存方式英文名,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 缓存方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCacheModeEN.prototype, "CacheModeId", {
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
/// 缓存方式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCacheModeEN.prototype, "CacheModeName", {
 get: function ()
{
return this.mstrCacheModeName;
},
 set: function(value)
{
 this.mstrCacheModeName = value;
    this.hmProperty["CacheModeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 缓存方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCacheModeEN.prototype, "CacheModeENName", {
 get: function ()
{
return this.mstrCacheModeENName;
},
 set: function(value)
{
 this.mstrCacheModeENName = value;
    this.hmProperty["CacheModeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCacheModeEN.prototype, "Memo", {
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
 /// 常量:"CacheModeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCacheModeEN, "con_CacheModeId", {
 get: function () {return "CacheModeId";}  // 缓存方式Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CacheModeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCacheModeEN, "con_CacheModeName", {
 get: function () {return "CacheModeName";}  // 缓存方式名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CacheModeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCacheModeEN, "con_CacheModeENName", {
 get: function () {return "CacheModeENName";}  // 缓存方式英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCacheModeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsCacheModeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsCacheModeEN._CurrTabName = "CacheMode"; //当前表名,与该类相关的表名
clsCacheModeEN._KeyFldName = "CacheModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsCacheModeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsCacheModeEN = clsCacheModeEN;
});