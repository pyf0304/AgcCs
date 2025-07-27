
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRegionTypeEN
 表名:RegionType(00050081)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/03 10:49:22
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
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
 /// 区域类型(RegionType)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsRegionTypeEN = /** @class */ (function (_super) {
__extends(clsRegionTypeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsRegionTypeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 7;
_this.AttributeName = new Array("RegionTypeId", "RegionTypeName", "RegionTypeENName", "RegionTypeSimName", "DefaWidth", "RegionTypeOrderNum", "Memo");
_this.strRegionTypeId = ""; //区域类型Id,
_this.strRegionTypeName = ""; //区域类型名称,
_this.strRegionTypeENName = ""; //区域类型英文名,
_this.strRegionTypeSimName = ""; //区域类型简名,
_this.intDefaWidth = 0; //缺省宽度,
_this.intRegionTypeOrderNum = 0; //区域类型序号,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsRegionTypeEN.prototype, "RegionTypeId", {
 get: function ()
{
return this.mstrRegionTypeId;
},
 set: function(value)
{
 this.mstrRegionTypeId = value;
    this.hmProperty["RegionTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsRegionTypeEN.prototype, "RegionTypeName", {
 get: function ()
{
return this.mstrRegionTypeName;
},
 set: function(value)
{
 this.mstrRegionTypeName = value;
    this.hmProperty["RegionTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsRegionTypeEN.prototype, "RegionTypeENName", {
 get: function ()
{
return this.mstrRegionTypeENName;
},
 set: function(value)
{
 this.mstrRegionTypeENName = value;
    this.hmProperty["RegionTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域类型简名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsRegionTypeEN.prototype, "RegionTypeSimName", {
 get: function ()
{
return this.mstrRegionTypeSimName;
},
 set: function(value)
{
 this.mstrRegionTypeSimName = value;
    this.hmProperty["RegionTypeSimName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 缺省宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsRegionTypeEN.prototype, "DefaWidth", {
 get: function ()
{
return this.mintDefaWidth;
},
 set: function(value)
{
 this.mintDefaWidth = value;
    this.hmProperty["DefaWidth"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域类型序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsRegionTypeEN.prototype, "RegionTypeOrderNum", {
 get: function ()
{
return this.mintRegionTypeOrderNum;
},
 set: function(value)
{
 this.mintRegionTypeOrderNum = value;
    this.hmProperty["RegionTypeOrderNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsRegionTypeEN.prototype, "Memo", {
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
 /// 常量:"RegionTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsRegionTypeEN, "con_RegionTypeId", {
 get: function () {return "RegionTypeId";}  // 区域类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsRegionTypeEN, "con_RegionTypeName", {
 get: function () {return "RegionTypeName";}  // 区域类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsRegionTypeEN, "con_RegionTypeENName", {
 get: function () {return "RegionTypeENName";}  // 区域类型英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeSimName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsRegionTypeEN, "con_RegionTypeSimName", {
 get: function () {return "RegionTypeSimName";}  // 区域类型简名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DefaWidth"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsRegionTypeEN, "con_DefaWidth", {
 get: function () {return "DefaWidth";}  // 缺省宽度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeOrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsRegionTypeEN, "con_RegionTypeOrderNum", {
 get: function () {return "RegionTypeOrderNum";}  // 区域类型序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsRegionTypeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsRegionTypeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsRegionTypeEN._CurrTabName = "RegionType"; //当前表名,与该类相关的表名
clsRegionTypeEN._KeyFldName = "RegionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsRegionTypeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsRegionTypeEN = clsRegionTypeEN;
});