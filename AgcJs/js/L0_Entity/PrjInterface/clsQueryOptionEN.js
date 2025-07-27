
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQueryOptionEN
 表名:QueryOption(00050080)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:30
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
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
 /// 查询选项(QueryOption)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsQueryOptionEN = /** @class */ (function (_super) {
__extends(clsQueryOptionEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsQueryOptionEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 4;
_this.AttributeName = new Array("QueryOptionId", "QueryOptionName", "QueryOptionENName", "Memo");
_this.strQueryOptionId = ""; //查询方式Id,
_this.strQueryOptionName = ""; //查询方式名称,
_this.strQueryOptionENName = ""; //查询方式英文名,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 查询方式Id(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsQueryOptionEN.prototype, "QueryOptionId", {
 get: function ()
{
return this.mstrQueryOptionId;
},
 set: function(value)
{
 this.mstrQueryOptionId = value;
    this.hmProperty["QueryOptionId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 查询方式名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsQueryOptionEN.prototype, "QueryOptionName", {
 get: function ()
{
return this.mstrQueryOptionName;
},
 set: function(value)
{
 this.mstrQueryOptionName = value;
    this.hmProperty["QueryOptionName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 查询方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsQueryOptionEN.prototype, "QueryOptionENName", {
 get: function ()
{
return this.mstrQueryOptionENName;
},
 set: function(value)
{
 this.mstrQueryOptionENName = value;
    this.hmProperty["QueryOptionENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsQueryOptionEN.prototype, "Memo", {
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
 /// 常量:"QueryOptionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsQueryOptionEN, "con_QueryOptionId", {
 get: function () {return "QueryOptionId";}  // 查询方式Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"QueryOptionName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsQueryOptionEN, "con_QueryOptionName", {
 get: function () {return "QueryOptionName";}  // 查询方式名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"QueryOptionENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsQueryOptionEN, "con_QueryOptionENName", {
 get: function () {return "QueryOptionENName";}  // 查询方式英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsQueryOptionEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsQueryOptionEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsQueryOptionEN._CurrTabName = "QueryOption"; //当前表名,与该类相关的表名
clsQueryOptionEN._KeyFldName = "QueryOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsQueryOptionEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsQueryOptionEN = clsQueryOptionEN;
});