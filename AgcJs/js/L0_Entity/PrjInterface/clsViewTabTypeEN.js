
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTabTypeEN
 表名:ViewTabType(00050103)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:25
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
 /// 界面表类型(ViewTabType)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsViewTabTypeEN = /** @class */ (function (_super) {
__extends(clsViewTabTypeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsViewTabTypeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 3;
_this.AttributeName = new Array("ViewTabTypeId", "ViewTabTypeName", "TabTypeFunction");
_this.strViewTabTypeId = ""; //界面表类型码,
_this.strViewTabTypeName = ""; //ViewTabTypeName,
_this.strTabTypeFunction = ""; //TabTypeFunction,
  return _this;
 }

/// <summary>
/// 界面表类型码(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTabTypeEN.prototype, "ViewTabTypeId", {
 get: function ()
{
return this.mstrViewTabTypeId;
},
 set: function(value)
{
 this.mstrViewTabTypeId = value;
    this.hmProperty["ViewTabTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ViewTabTypeName(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTabTypeEN.prototype, "ViewTabTypeName", {
 get: function ()
{
return this.mstrViewTabTypeName;
},
 set: function(value)
{
 this.mstrViewTabTypeName = value;
    this.hmProperty["ViewTabTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// TabTypeFunction(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTabTypeEN.prototype, "TabTypeFunction", {
 get: function ()
{
return this.mstrTabTypeFunction;
},
 set: function(value)
{
 this.mstrTabTypeFunction = value;
    this.hmProperty["TabTypeFunction"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"ViewTabTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTabTypeEN, "con_ViewTabTypeId", {
 get: function () {return "ViewTabTypeId";}  // 界面表类型码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewTabTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTabTypeEN, "con_ViewTabTypeName", {
 get: function () {return "ViewTabTypeName";}  // ViewTabTypeName
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabTypeFunction"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTabTypeEN, "con_TabTypeFunction", {
 get: function () {return "TabTypeFunction";}  // TabTypeFunction
,
    enumerable: true,
    configurable: true
});

clsViewTabTypeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsViewTabTypeEN._CurrTabName = "ViewTabType"; //当前表名,与该类相关的表名
clsViewTabTypeEN._KeyFldName = "ViewTabTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsViewTabTypeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsViewTabTypeEN = clsViewTabTypeEN;
});