
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDgFuncTypeEN
 表名:DgFuncType(00050114)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:40
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
 /// DG功能类型(DgFuncType)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsDgFuncTypeEN = /** @class */ (function (_super) {
__extends(clsDgFuncTypeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsDgFuncTypeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 3;
_this.AttributeName = new Array("DgFuncTypeId", "DgFuncTypeName", "Memo");
_this.strDgFuncTypeId = ""; //Dg功能类型Id,
_this.strDgFuncTypeName = ""; //Dg功能类型名,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// Dg功能类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDgFuncTypeEN.prototype, "DgFuncTypeId", {
 get: function ()
{
return this.mstrDgFuncTypeId;
},
 set: function(value)
{
 this.mstrDgFuncTypeId = value;
    this.hmProperty["DgFuncTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// Dg功能类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDgFuncTypeEN.prototype, "DgFuncTypeName", {
 get: function ()
{
return this.mstrDgFuncTypeName;
},
 set: function(value)
{
 this.mstrDgFuncTypeName = value;
    this.hmProperty["DgFuncTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDgFuncTypeEN.prototype, "Memo", {
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
 /// 常量:"DgFuncTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDgFuncTypeEN, "con_DgFuncTypeId", {
 get: function () {return "DgFuncTypeId";}  // Dg功能类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DgFuncTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDgFuncTypeEN, "con_DgFuncTypeName", {
 get: function () {return "DgFuncTypeName";}  // Dg功能类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDgFuncTypeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsDgFuncTypeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsDgFuncTypeEN._CurrTabName = "DgFuncType"; //当前表名,与该类相关的表名
clsDgFuncTypeEN._KeyFldName = "DgFuncTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsDgFuncTypeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsDgFuncTypeEN = clsDgFuncTypeEN;
});