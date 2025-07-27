
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabStateEN
 表名:TabState(00050108)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:00
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
 /// 表状态(TabState)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsTabStateEN = /** @class */ (function (_super) {
__extends(clsTabStateEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsTabStateEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 4;
_this.AttributeName = new Array("TabStateId", "TabStateName", "TabStateENName", "Memo");
_this.strTabStateId = ""; //表状态ID,
_this.strTabStateName = ""; //表状态名称,
_this.strTabStateENName = ""; //表状态英文名,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsTabStateEN.prototype, "TabStateId", {
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
Object.defineProperty(clsTabStateEN.prototype, "TabStateName", {
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
/// 表状态英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsTabStateEN.prototype, "TabStateENName", {
 get: function ()
{
return this.mstrTabStateENName;
},
 set: function(value)
{
 this.mstrTabStateENName = value;
    this.hmProperty["TabStateENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsTabStateEN.prototype, "Memo", {
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
 /// 常量:"TabStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsTabStateEN, "con_TabStateId", {
 get: function () {return "TabStateId";}  // 表状态ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabStateName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsTabStateEN, "con_TabStateName", {
 get: function () {return "TabStateName";}  // 表状态名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabStateENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsTabStateEN, "con_TabStateENName", {
 get: function () {return "TabStateENName";}  // 表状态英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsTabStateEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsTabStateEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsTabStateEN._CurrTabName = "TabState"; //当前表名,与该类相关的表名
clsTabStateEN._KeyFldName = "TabStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsTabStateEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsTabStateEN = clsTabStateEN;
});