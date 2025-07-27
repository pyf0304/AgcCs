
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsINOUTTypeEN
 表名:INOUTType(00050135)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:24
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
 /// InOut类型(INOUTType)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsINOUTTypeEN = /** @class */ (function (_super) {
__extends(clsINOUTTypeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsINOUTTypeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 4;
_this.AttributeName = new Array("INOUTTypeId", "INOUTTypeName", "INOUTTypeENName", "Memo");
_this.strINOUTTypeId = ""; //INOUT类型ID,
_this.strINOUTTypeName = ""; //INOUT类型名称,
_this.strINOUTTypeENName = ""; //INOUT类型英文名,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// INOUT类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsINOUTTypeEN.prototype, "INOUTTypeId", {
 get: function ()
{
return this.mstrINOUTTypeId;
},
 set: function(value)
{
 this.mstrINOUTTypeId = value;
    this.hmProperty["INOUTTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// INOUT类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsINOUTTypeEN.prototype, "INOUTTypeName", {
 get: function ()
{
return this.mstrINOUTTypeName;
},
 set: function(value)
{
 this.mstrINOUTTypeName = value;
    this.hmProperty["INOUTTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// INOUT类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsINOUTTypeEN.prototype, "INOUTTypeENName", {
 get: function ()
{
return this.mstrINOUTTypeENName;
},
 set: function(value)
{
 this.mstrINOUTTypeENName = value;
    this.hmProperty["INOUTTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsINOUTTypeEN.prototype, "Memo", {
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
 /// 常量:"INOUTTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsINOUTTypeEN, "con_INOUTTypeId", {
 get: function () {return "INOUTTypeId";}  // INOUT类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INOUTTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsINOUTTypeEN, "con_INOUTTypeName", {
 get: function () {return "INOUTTypeName";}  // INOUT类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INOUTTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsINOUTTypeEN, "con_INOUTTypeENName", {
 get: function () {return "INOUTTypeENName";}  // INOUT类型英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsINOUTTypeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsINOUTTypeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsINOUTTypeEN._CurrTabName = "INOUTType"; //当前表名,与该类相关的表名
clsINOUTTypeEN._KeyFldName = "INOUTTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsINOUTTypeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsINOUTTypeEN = clsINOUTTypeEN;
});