
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProgLangTypeEN
 表名:ProgLangType(00050303)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:58
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
 /// 编程语言类型(ProgLangType)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsProgLangTypeEN = /** @class */ (function (_super) {
__extends(clsProgLangTypeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsProgLangTypeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 10;
_this.AttributeName = new Array("ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "ProgLangTypeENName", "CharEncodingId", "IsVisible", "OrderNum", "UpdDate", "UpdUserId", "Memo");
_this.strProgLangTypeId = ""; //编程语言类型Id,
_this.strProgLangTypeName = ""; //编程语言类型名,
_this.strProgLangTypeSimName = ""; //编程语言类型简称,
_this.strProgLangTypeENName = ""; //编程语言类型英文名,
_this.strCharEncodingId = ""; //字符编码,
_this.bolIsVisible = false; //是否显示,
_this.intOrderNum = 0; //序号,
_this.strUpdDate = ""; //修改日期,
_this.strUpdUserId = ""; //修改用户Id,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "ProgLangTypeId", {
 get: function ()
{
return this.mstrProgLangTypeId;
},
 set: function(value)
{
 this.mstrProgLangTypeId = value;
    this.hmProperty["ProgLangTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "ProgLangTypeName", {
 get: function ()
{
return this.mstrProgLangTypeName;
},
 set: function(value)
{
 this.mstrProgLangTypeName = value;
    this.hmProperty["ProgLangTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "ProgLangTypeSimName", {
 get: function ()
{
return this.mstrProgLangTypeSimName;
},
 set: function(value)
{
 this.mstrProgLangTypeSimName = value;
    this.hmProperty["ProgLangTypeSimName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "ProgLangTypeENName", {
 get: function ()
{
return this.mstrProgLangTypeENName;
},
 set: function(value)
{
 this.mstrProgLangTypeENName = value;
    this.hmProperty["ProgLangTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字符编码(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "CharEncodingId", {
 get: function ()
{
return this.mstrCharEncodingId;
},
 set: function(value)
{
 this.mstrCharEncodingId = value;
    this.hmProperty["CharEncodingId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "IsVisible", {
 get: function ()
{
return this.mbolIsVisible;
},
 set: function(value)
{
 this.mbolIsVisible = value;
    this.hmProperty["IsVisible"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "OrderNum", {
 get: function ()
{
return this.mintOrderNum;
},
 set: function(value)
{
 this.mintOrderNum = value;
    this.hmProperty["OrderNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "UpdDate", {
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
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "UpdUserId", {
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
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsProgLangTypeEN.prototype, "Memo", {
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
 /// 常量:"ProgLangTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_ProgLangTypeId", {
 get: function () {return "ProgLangTypeId";}  // 编程语言类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_ProgLangTypeName", {
 get: function () {return "ProgLangTypeName";}  // 编程语言类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeSimName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_ProgLangTypeSimName", {
 get: function () {return "ProgLangTypeSimName";}  // 编程语言类型简称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_ProgLangTypeENName", {
 get: function () {return "ProgLangTypeENName";}  // 编程语言类型英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_CharEncodingId", {
 get: function () {return "CharEncodingId";}  // 字符编码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsVisible"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_IsVisible", {
 get: function () {return "IsVisible";}  // 是否显示
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_OrderNum", {
 get: function () {return "OrderNum";}  // 序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_UpdUserId", {
 get: function () {return "UpdUserId";}  // 修改用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsProgLangTypeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsProgLangTypeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsProgLangTypeEN._CurrTabName = "ProgLangType"; //当前表名,与该类相关的表名
clsProgLangTypeEN._KeyFldName = "ProgLangTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsProgLangTypeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsProgLangTypeEN = clsProgLangTypeEN;
});