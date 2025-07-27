
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAcademyEN
 表名:Academy(00050146)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:05:41
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:生成代码
 模块英文名:GeneCode
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
 /// 学院(Academy)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsAcademyEN = /** @class */ (function (_super) {
__extends(clsAcademyEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsAcademyEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 3;
_this.AttributeName = new Array("AcademyId", "AcademyName", "Memo");
_this.strAcademyId = ""; //学院ID,
_this.strAcademyName = ""; //学院名称,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:6;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsAcademyEN.prototype, "AcademyId", {
 get: function ()
{
return this.mstrAcademyId;
},
 set: function(value)
{
 this.mstrAcademyId = value;
    this.hmProperty["AcademyId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsAcademyEN.prototype, "AcademyName", {
 get: function ()
{
return this.mstrAcademyName;
},
 set: function(value)
{
 this.mstrAcademyName = value;
    this.hmProperty["AcademyName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsAcademyEN.prototype, "Memo", {
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
 /// 常量:"AcademyId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsAcademyEN, "con_AcademyId", {
 get: function () {return "AcademyId";}  // 学院ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"AcademyName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsAcademyEN, "con_AcademyName", {
 get: function () {return "AcademyName";}  // 学院名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsAcademyEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsAcademyEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsAcademyEN._CurrTabName = "Academy"; //当前表名,与该类相关的表名
clsAcademyEN._KeyFldName = "AcademyId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsAcademyEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsAcademyEN = clsAcademyEN;
});