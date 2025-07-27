
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsApplicationTypeEN
 表名:ApplicationType(00050127)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:43
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
 /// 应用程序类型(ApplicationType)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsApplicationTypeEN = /** @class */ (function (_super) {
__extends(clsApplicationTypeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsApplicationTypeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 13;
_this.AttributeName = new Array("ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "ApplicationTypeENName", "ProgLangTypeId", "ProgLangTypeId2", "ProgLangTypeId3", "ProgLangTypeId4", "ProgLangTypeId5", "IsVisible", "VisitedNum", "OrderNum", "Memo");
_this.intApplicationTypeId = 0; //应用程序类型ID,
_this.strApplicationTypeName = ""; //应用程序类型名称,
_this.strApplicationTypeSimName = ""; //应用程序类型简称,
_this.strApplicationTypeENName = ""; //应用类型英文名,
_this.strProgLangTypeId = ""; //编程语言类型Id,
_this.strProgLangTypeId2 = ""; //编程语言类型Id2,
_this.strProgLangTypeId3 = ""; //编程语言类型Id3,
_this.strProgLangTypeId4 = ""; //编程语言类型Id4,
_this.strProgLangTypeId5 = ""; //编程语言类型Id5,
_this.bolIsVisible = false; //是否显示,
_this.intVisitedNum = 0; //访问数,
_this.intOrderNum = 0; //序号,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "ApplicationTypeId", {
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
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "ApplicationTypeName", {
 get: function ()
{
return this.mstrApplicationTypeName;
},
 set: function(value)
{
 this.mstrApplicationTypeName = value;
    this.hmProperty["ApplicationTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "ApplicationTypeSimName", {
 get: function ()
{
return this.mstrApplicationTypeSimName;
},
 set: function(value)
{
 this.mstrApplicationTypeSimName = value;
    this.hmProperty["ApplicationTypeSimName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "ApplicationTypeENName", {
 get: function ()
{
return this.mstrApplicationTypeENName;
},
 set: function(value)
{
 this.mstrApplicationTypeENName = value;
    this.hmProperty["ApplicationTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "ProgLangTypeId", {
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
/// 编程语言类型Id2(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "ProgLangTypeId2", {
 get: function ()
{
return this.mstrProgLangTypeId2;
},
 set: function(value)
{
 this.mstrProgLangTypeId2 = value;
    this.hmProperty["ProgLangTypeId2"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id3(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "ProgLangTypeId3", {
 get: function ()
{
return this.mstrProgLangTypeId3;
},
 set: function(value)
{
 this.mstrProgLangTypeId3 = value;
    this.hmProperty["ProgLangTypeId3"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id4(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "ProgLangTypeId4", {
 get: function ()
{
return this.mstrProgLangTypeId4;
},
 set: function(value)
{
 this.mstrProgLangTypeId4 = value;
    this.hmProperty["ProgLangTypeId4"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id5(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "ProgLangTypeId5", {
 get: function ()
{
return this.mstrProgLangTypeId5;
},
 set: function(value)
{
 this.mstrProgLangTypeId5 = value;
    this.hmProperty["ProgLangTypeId5"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "IsVisible", {
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
/// 访问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "VisitedNum", {
 get: function ()
{
return this.mintVisitedNum;
},
 set: function(value)
{
 this.mintVisitedNum = value;
    this.hmProperty["VisitedNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "OrderNum", {
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
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsApplicationTypeEN.prototype, "Memo", {
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
 /// 常量:"ApplicationTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_ApplicationTypeId", {
 get: function () {return "ApplicationTypeId";}  // 应用程序类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_ApplicationTypeName", {
 get: function () {return "ApplicationTypeName";}  // 应用程序类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_ApplicationTypeSimName", {
 get: function () {return "ApplicationTypeSimName";}  // 应用程序类型简称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_ApplicationTypeENName", {
 get: function () {return "ApplicationTypeENName";}  // 应用类型英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_ProgLangTypeId", {
 get: function () {return "ProgLangTypeId";}  // 编程语言类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId2"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_ProgLangTypeId2", {
 get: function () {return "ProgLangTypeId2";}  // 编程语言类型Id2
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId3"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_ProgLangTypeId3", {
 get: function () {return "ProgLangTypeId3";}  // 编程语言类型Id3
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId4"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_ProgLangTypeId4", {
 get: function () {return "ProgLangTypeId4";}  // 编程语言类型Id4
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId5"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_ProgLangTypeId5", {
 get: function () {return "ProgLangTypeId5";}  // 编程语言类型Id5
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsVisible"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_IsVisible", {
 get: function () {return "IsVisible";}  // 是否显示
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"VisitedNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_VisitedNum", {
 get: function () {return "VisitedNum";}  // 访问数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_OrderNum", {
 get: function () {return "OrderNum";}  // 序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsApplicationTypeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsApplicationTypeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsApplicationTypeEN._CurrTabName = "ApplicationType"; //当前表名,与该类相关的表名
clsApplicationTypeEN._KeyFldName = "ApplicationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsApplicationTypeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsApplicationTypeEN = clsApplicationTypeEN;
});