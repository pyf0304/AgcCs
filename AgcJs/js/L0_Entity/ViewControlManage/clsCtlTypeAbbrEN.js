
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCtlTypeAbbrEN
 表名:CtlTypeAbbr(00050058)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:29
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面控件管理
 模块英文名:ViewControlManage
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
 /// 控件类型缩写(CtlTypeAbbr)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsCtlTypeAbbrEN = /** @class */ (function (_super) {
__extends(clsCtlTypeAbbrEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsCtlTypeAbbrEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 6;
_this.AttributeName = new Array("CtlTypeId", "CtlTypeName", "CtlTypeENName", "CtlCnName", "CtlTypeAbbr", "Memo");
_this.strCtlTypeId = ""; //控件类型号,
_this.strCtlTypeName = ""; //控件类型名,
_this.strCtlTypeENName = ""; //控件类型英文名,
_this.strCtlCnName = ""; //控件类型中文名,
_this.strCtlTypeAbbr = ""; //控件类型缩写,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCtlTypeAbbrEN.prototype, "CtlTypeId", {
 get: function ()
{
return this.mstrCtlTypeId;
},
 set: function(value)
{
 this.mstrCtlTypeId = value;
    this.hmProperty["CtlTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 控件类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCtlTypeAbbrEN.prototype, "CtlTypeName", {
 get: function ()
{
return this.mstrCtlTypeName;
},
 set: function(value)
{
 this.mstrCtlTypeName = value;
    this.hmProperty["CtlTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 控件类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCtlTypeAbbrEN.prototype, "CtlTypeENName", {
 get: function ()
{
return this.mstrCtlTypeENName;
},
 set: function(value)
{
 this.mstrCtlTypeENName = value;
    this.hmProperty["CtlTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 控件类型中文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCtlTypeAbbrEN.prototype, "CtlCnName", {
 get: function ()
{
return this.mstrCtlCnName;
},
 set: function(value)
{
 this.mstrCtlCnName = value;
    this.hmProperty["CtlCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 控件类型缩写(说明:;字段类型:varchar;字段长度:5;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCtlTypeAbbrEN.prototype, "CtlTypeAbbr", {
 get: function ()
{
return this.mstrCtlTypeAbbr;
},
 set: function(value)
{
 this.mstrCtlTypeAbbr = value;
    this.hmProperty["CtlTypeAbbr"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsCtlTypeAbbrEN.prototype, "Memo", {
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
 /// 常量:"CtlTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCtlTypeAbbrEN, "con_CtlTypeId", {
 get: function () {return "CtlTypeId";}  // 控件类型号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCtlTypeAbbrEN, "con_CtlTypeName", {
 get: function () {return "CtlTypeName";}  // 控件类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCtlTypeAbbrEN, "con_CtlTypeENName", {
 get: function () {return "CtlTypeENName";}  // 控件类型英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCtlTypeAbbrEN, "con_CtlCnName", {
 get: function () {return "CtlCnName";}  // 控件类型中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeAbbr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCtlTypeAbbrEN, "con_CtlTypeAbbr", {
 get: function () {return "CtlTypeAbbr";}  // 控件类型缩写
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsCtlTypeAbbrEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsCtlTypeAbbrEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsCtlTypeAbbrEN._CurrTabName = "CtlTypeAbbr"; //当前表名,与该类相关的表名
clsCtlTypeAbbrEN._KeyFldName = "CtlTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsCtlTypeAbbrEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsCtlTypeAbbrEN = clsCtlTypeAbbrEN;
});