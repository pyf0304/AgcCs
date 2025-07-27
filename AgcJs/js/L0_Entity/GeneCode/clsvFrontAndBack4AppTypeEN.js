
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFrontAndBack4AppTypeEN
 表名:vFrontAndBack4AppType(00050424)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:56
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
 /// v应用类型的前后台关系(vFrontAndBack4AppType)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvFrontAndBack4AppTypeEN = /** @class */ (function (_super) {
__extends(clsvFrontAndBack4AppTypeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvFrontAndBack4AppTypeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 10;
_this.AttributeName = new Array("mId", "OrderNum", "AppTypeId4Front", "ApplTypeName4Front", "IsVisible", "AppTypeId4Back", "ApplTypeName4Back", "UpdDate", "UpdUser", "Memo");
_this.lngmId = 0; //mId,
_this.intOrderNum = 0; //序号,
_this.intAppTypeId4Front = 0; //应用类型Id4Front,
_this.strApplTypeName4Front = ""; //ApplTypeName4Front,
_this.bolIsVisible = false; //是否显示,
_this.intAppTypeId4Back = 0; //应用类型Id4Back,
_this.strApplTypeName4Back = ""; //ApplTypeName4Back,
_this.strUpdDate = ""; //修改日期,
_this.strUpdUser = ""; //修改者,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "mId", {
 get: function ()
{
return this.mlngmId;
},
 set: function(value)
{
 this.mlngmId = value;
    this.hmProperty["mId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "OrderNum", {
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
/// 应用类型Id4Front(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "AppTypeId4Front", {
 get: function ()
{
return this.mintAppTypeId4Front;
},
 set: function(value)
{
 this.mintAppTypeId4Front = value;
    this.hmProperty["AppTypeId4Front"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ApplTypeName4Front(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "ApplTypeName4Front", {
 get: function ()
{
return this.mstrApplTypeName4Front;
},
 set: function(value)
{
 this.mstrApplTypeName4Front = value;
    this.hmProperty["ApplTypeName4Front"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "IsVisible", {
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
/// 应用类型Id4Back(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "AppTypeId4Back", {
 get: function ()
{
return this.mintAppTypeId4Back;
},
 set: function(value)
{
 this.mintAppTypeId4Back = value;
    this.hmProperty["AppTypeId4Back"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ApplTypeName4Back(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "ApplTypeName4Back", {
 get: function ()
{
return this.mstrApplTypeName4Back;
},
 set: function(value)
{
 this.mstrApplTypeName4Back = value;
    this.hmProperty["ApplTypeName4Back"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "UpdDate", {
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
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "UpdUser", {
 get: function ()
{
return this.mstrUpdUser;
},
 set: function(value)
{
 this.mstrUpdUser = value;
    this.hmProperty["UpdUser"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN.prototype, "Memo", {
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
 /// 常量:"mId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_OrderNum", {
 get: function () {return "OrderNum";}  // 序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"AppTypeId4Front"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_AppTypeId4Front", {
 get: function () {return "AppTypeId4Front";}  // 应用类型Id4Front
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplTypeName4Front"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_ApplTypeName4Front", {
 get: function () {return "ApplTypeName4Front";}  // ApplTypeName4Front
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsVisible"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_IsVisible", {
 get: function () {return "IsVisible";}  // 是否显示
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"AppTypeId4Back"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_AppTypeId4Back", {
 get: function () {return "AppTypeId4Back";}  // 应用类型Id4Back
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplTypeName4Back"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_ApplTypeName4Back", {
 get: function () {return "ApplTypeName4Back";}  // ApplTypeName4Back
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFrontAndBack4AppTypeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsvFrontAndBack4AppTypeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvFrontAndBack4AppTypeEN._CurrTabName = "vFrontAndBack4AppType"; //当前表名,与该类相关的表名
clsvFrontAndBack4AppTypeEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvFrontAndBack4AppTypeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvFrontAndBack4AppTypeEN = clsvFrontAndBack4AppTypeEN;
});