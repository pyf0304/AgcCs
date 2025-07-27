
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRelaTabEN
 表名:ViewRelaTab(00050100)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:27
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
 /// 界面相关表(ViewRelaTab)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsViewRelaTabEN = /** @class */ (function (_super) {
__extends(clsViewRelaTabEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsViewRelaTabEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 10;
_this.AttributeName = new Array("mId", "ViewId", "RegionId", "INOUTTypeId", "ViewTabTypeId", "TabId", "TabFunction", "UpdDate", "UpdUser", "Memo");
_this.lngmId = 0; //mId,
_this.strViewId = ""; //界面Id,
_this.lngRegionId = 0; //区域Id,
_this.strINOUTTypeId = ""; //INOUT类型ID,
_this.strViewTabTypeId = ""; //界面表类型码,
_this.strTabId = ""; //表ID,
_this.strTabFunction = ""; //表功能说明,
_this.strUpdDate = ""; //修改日期,
_this.strUpdUser = ""; //修改者,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewRelaTabEN.prototype, "mId", {
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
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewRelaTabEN.prototype, "ViewId", {
 get: function ()
{
return this.mstrViewId;
},
 set: function(value)
{
 this.mstrViewId = value;
    this.hmProperty["ViewId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewRelaTabEN.prototype, "RegionId", {
 get: function ()
{
return this.mlngRegionId;
},
 set: function(value)
{
 this.mlngRegionId = value;
    this.hmProperty["RegionId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// INOUT类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewRelaTabEN.prototype, "INOUTTypeId", {
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
/// 界面表类型码(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewRelaTabEN.prototype, "ViewTabTypeId", {
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
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewRelaTabEN.prototype, "TabId", {
 get: function ()
{
return this.mstrTabId;
},
 set: function(value)
{
 this.mstrTabId = value;
    this.hmProperty["TabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表功能说明(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewRelaTabEN.prototype, "TabFunction", {
 get: function ()
{
return this.mstrTabFunction;
},
 set: function(value)
{
 this.mstrTabFunction = value;
    this.hmProperty["TabFunction"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewRelaTabEN.prototype, "UpdDate", {
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
Object.defineProperty(clsViewRelaTabEN.prototype, "UpdUser", {
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
Object.defineProperty(clsViewRelaTabEN.prototype, "Memo", {
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
Object.defineProperty(clsViewRelaTabEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewRelaTabEN, "con_ViewId", {
 get: function () {return "ViewId";}  // 界面Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewRelaTabEN, "con_RegionId", {
 get: function () {return "RegionId";}  // 区域Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INOUTTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewRelaTabEN, "con_INOUTTypeId", {
 get: function () {return "INOUTTypeId";}  // INOUT类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewTabTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewRelaTabEN, "con_ViewTabTypeId", {
 get: function () {return "ViewTabTypeId";}  // 界面表类型码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewRelaTabEN, "con_TabId", {
 get: function () {return "TabId";}  // 表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabFunction"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewRelaTabEN, "con_TabFunction", {
 get: function () {return "TabFunction";}  // 表功能说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewRelaTabEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewRelaTabEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewRelaTabEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsViewRelaTabEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsViewRelaTabEN._CurrTabName = "ViewRelaTab"; //当前表名,与该类相关的表名
clsViewRelaTabEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsViewRelaTabEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsViewRelaTabEN = clsViewRelaTabEN;
});