
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRelaTabEN
 表名:vViewRelaTab(00050476)
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
 /// v界面相关表(vViewRelaTab)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvViewRelaTabEN = /** @class */ (function (_super) {
__extends(clsvViewRelaTabEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvViewRelaTabEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 18;
_this.AttributeName = new Array("mId", "ViewId", "ViewName", "ViewCnName", "RegionId", "RegionName", "RegionTypeId", "RegionTypeName", "INOUTTypeId", "INOUTTypeName", "ViewTabTypeId", "ViewTabTypeName", "TabId", "TabName", "TabFunction", "UpdDate", "UpdUser", "Memo");
_this.lngmId = 0; //mId,
_this.strViewId = ""; //界面Id,
_this.strViewName = ""; //界面名称,
_this.strViewCnName = ""; //视图中文名,
_this.lngRegionId = 0; //区域Id,
_this.strRegionName = ""; //区域名称,
_this.strRegionTypeId = ""; //区域类型Id,
_this.strRegionTypeName = ""; //区域类型名称,
_this.strINOUTTypeId = ""; //INOUT类型ID,
_this.strINOUTTypeName = ""; //INOUT类型名称,
_this.strViewTabTypeId = ""; //界面表类型码,
_this.strViewTabTypeName = ""; //ViewTabTypeName,
_this.strTabId = ""; //表ID,
_this.strTabName = ""; //表名,
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
Object.defineProperty(clsvViewRelaTabEN.prototype, "mId", {
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
Object.defineProperty(clsvViewRelaTabEN.prototype, "ViewId", {
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
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "ViewName", {
 get: function ()
{
return this.mstrViewName;
},
 set: function(value)
{
 this.mstrViewName = value;
    this.hmProperty["ViewName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "ViewCnName", {
 get: function ()
{
return this.mstrViewCnName;
},
 set: function(value)
{
 this.mstrViewCnName = value;
    this.hmProperty["ViewCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "RegionId", {
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
/// 区域名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "RegionName", {
 get: function ()
{
return this.mstrRegionName;
},
 set: function(value)
{
 this.mstrRegionName = value;
    this.hmProperty["RegionName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "RegionTypeId", {
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
Object.defineProperty(clsvViewRelaTabEN.prototype, "RegionTypeName", {
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
/// INOUT类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "INOUTTypeId", {
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
Object.defineProperty(clsvViewRelaTabEN.prototype, "INOUTTypeName", {
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
/// 界面表类型码(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "ViewTabTypeId", {
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
Object.defineProperty(clsvViewRelaTabEN.prototype, "ViewTabTypeName", {
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
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "TabId", {
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
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "TabName", {
 get: function ()
{
return this.mstrTabName;
},
 set: function(value)
{
 this.mstrTabName = value;
    this.hmProperty["TabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表功能说明(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRelaTabEN.prototype, "TabFunction", {
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
Object.defineProperty(clsvViewRelaTabEN.prototype, "UpdDate", {
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
Object.defineProperty(clsvViewRelaTabEN.prototype, "UpdUser", {
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
Object.defineProperty(clsvViewRelaTabEN.prototype, "Memo", {
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
Object.defineProperty(clsvViewRelaTabEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_ViewId", {
 get: function () {return "ViewId";}  // 界面Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_ViewName", {
 get: function () {return "ViewName";}  // 界面名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_ViewCnName", {
 get: function () {return "ViewCnName";}  // 视图中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_RegionId", {
 get: function () {return "RegionId";}  // 区域Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_RegionName", {
 get: function () {return "RegionName";}  // 区域名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_RegionTypeId", {
 get: function () {return "RegionTypeId";}  // 区域类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_RegionTypeName", {
 get: function () {return "RegionTypeName";}  // 区域类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INOUTTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_INOUTTypeId", {
 get: function () {return "INOUTTypeId";}  // INOUT类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INOUTTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_INOUTTypeName", {
 get: function () {return "INOUTTypeName";}  // INOUT类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewTabTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_ViewTabTypeId", {
 get: function () {return "ViewTabTypeId";}  // 界面表类型码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewTabTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_ViewTabTypeName", {
 get: function () {return "ViewTabTypeName";}  // ViewTabTypeName
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_TabId", {
 get: function () {return "TabId";}  // 表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_TabName", {
 get: function () {return "TabName";}  // 表名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabFunction"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_TabFunction", {
 get: function () {return "TabFunction";}  // 表功能说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRelaTabEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsvViewRelaTabEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvViewRelaTabEN._CurrTabName = "vViewRelaTab"; //当前表名,与该类相关的表名
clsvViewRelaTabEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvViewRelaTabEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvViewRelaTabEN = clsvViewRelaTabEN;
});