
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionEN
 表名:vViewRegion(00050199)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:23
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
 /// v界面区域(vViewRegion)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvViewRegionEN = /** @class */ (function (_super) {
__extends(clsvViewRegionEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvViewRegionEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 30;
_this.AttributeName = new Array("RegionId", "RegionName", "ViewId", "ViewName", "ApplicationTypeId", "ViewCnName", "RegionTypeId", "RegionTypeName", "RegionTypeSimName", "RegionTypeOrderNum", "RegionFunction", "ClassName", "Height", "Width", "OUTRelaTabId", "INSQLDSTypeId", "INRelaTabId", "OUTSQLDSTypeId", "InUse", "PrjId", "UpdUser", "UpdDate", "Memo", "OUTSqlDsTypeName", "OUTTabName", "OUTTabCnName", "INSqlDsTypeName", "INTabName", "INTabCnName", "FeatureNum");
_this.lngRegionId = 0; //区域Id,
_this.strRegionName = ""; //区域名称,
_this.strViewId = ""; //界面Id,
_this.strViewName = ""; //界面名称,
_this.intApplicationTypeId = 0; //应用程序类型ID,
_this.strViewCnName = ""; //视图中文名,
_this.strRegionTypeId = ""; //区域类型Id,
_this.strRegionTypeName = ""; //区域类型名称,
_this.strRegionTypeSimName = ""; //区域类型简名,
_this.intRegionTypeOrderNum = 0; //区域类型序号,
_this.strRegionFunction = ""; //区域功能,
_this.strClassName = ""; //类名,
_this.intHeight = 0; //高度,
_this.intWidth = 0; //宽,
_this.strOUTRelaTabId = ""; //输出数据源表ID,
_this.strINSQLDSTypeId = ""; //输入数据源类型,
_this.strINRelaTabId = ""; //输入数据源表ID,
_this.strOUTSQLDSTypeId = ""; //输出数据源类型,
_this.bolInUse = false; //是否在用,
_this.strPrjId = ""; //工程ID,
_this.strUpdUser = ""; //修改者,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
_this.strOUTSqlDsTypeName = ""; //OUT数据源类型,
_this.strOUTTabName = ""; //OUT表,
_this.strOUTTabCnName = ""; //OUT表CH,
_this.strINSqlDsTypeName = ""; //IN数据源类型,
_this.strINTabName = ""; //IN表,
_this.strINTabCnName = ""; //IN表中文名,
_this.intFeatureNum = 0; //FeatureNum,
  return _this;
 }

/// <summary>
/// 区域Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "RegionId", {
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
Object.defineProperty(clsvViewRegionEN.prototype, "RegionName", {
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
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "ViewId", {
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
Object.defineProperty(clsvViewRegionEN.prototype, "ViewName", {
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
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "ApplicationTypeId", {
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
/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "ViewCnName", {
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
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "RegionTypeId", {
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
Object.defineProperty(clsvViewRegionEN.prototype, "RegionTypeName", {
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
/// 区域类型简名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "RegionTypeSimName", {
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
/// 区域类型序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "RegionTypeOrderNum", {
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
/// 区域功能(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "RegionFunction", {
 get: function ()
{
return this.mstrRegionFunction;
},
 set: function(value)
{
 this.mstrRegionFunction = value;
    this.hmProperty["RegionFunction"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 类名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "ClassName", {
 get: function ()
{
return this.mstrClassName;
},
 set: function(value)
{
 this.mstrClassName = value;
    this.hmProperty["ClassName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "Height", {
 get: function ()
{
return this.mintHeight;
},
 set: function(value)
{
 this.mintHeight = value;
    this.hmProperty["Height"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "Width", {
 get: function ()
{
return this.mintWidth;
},
 set: function(value)
{
 this.mintWidth = value;
    this.hmProperty["Width"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 输出数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "OUTRelaTabId", {
 get: function ()
{
return this.mstrOUTRelaTabId;
},
 set: function(value)
{
 this.mstrOUTRelaTabId = value;
    this.hmProperty["OUTRelaTabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 输入数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "INSQLDSTypeId", {
 get: function ()
{
return this.mstrINSQLDSTypeId;
},
 set: function(value)
{
 this.mstrINSQLDSTypeId = value;
    this.hmProperty["INSQLDSTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 输入数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "INRelaTabId", {
 get: function ()
{
return this.mstrINRelaTabId;
},
 set: function(value)
{
 this.mstrINRelaTabId = value;
    this.hmProperty["INRelaTabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 输出数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "OUTSQLDSTypeId", {
 get: function ()
{
return this.mstrOUTSQLDSTypeId;
},
 set: function(value)
{
 this.mstrOUTSQLDSTypeId = value;
    this.hmProperty["OUTSQLDSTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "InUse", {
 get: function ()
{
return this.mbolInUse;
},
 set: function(value)
{
 this.mbolInUse = value;
    this.hmProperty["InUse"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "PrjId", {
 get: function ()
{
return this.mstrPrjId;
},
 set: function(value)
{
 this.mstrPrjId = value;
    this.hmProperty["PrjId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "UpdUser", {
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
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "UpdDate", {
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
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "Memo", {
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
/// OUT数据源类型(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "OUTSqlDsTypeName", {
 get: function ()
{
return this.mstrOUTSqlDsTypeName;
},
 set: function(value)
{
 this.mstrOUTSqlDsTypeName = value;
    this.hmProperty["OUTSqlDsTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// OUT表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "OUTTabName", {
 get: function ()
{
return this.mstrOUTTabName;
},
 set: function(value)
{
 this.mstrOUTTabName = value;
    this.hmProperty["OUTTabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// OUT表CH(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "OUTTabCnName", {
 get: function ()
{
return this.mstrOUTTabCnName;
},
 set: function(value)
{
 this.mstrOUTTabCnName = value;
    this.hmProperty["OUTTabCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// IN数据源类型(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "INSqlDsTypeName", {
 get: function ()
{
return this.mstrINSqlDsTypeName;
},
 set: function(value)
{
 this.mstrINSqlDsTypeName = value;
    this.hmProperty["INSqlDsTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// IN表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "INTabName", {
 get: function ()
{
return this.mstrINTabName;
},
 set: function(value)
{
 this.mstrINTabName = value;
    this.hmProperty["INTabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// IN表中文名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "INTabCnName", {
 get: function ()
{
return this.mstrINTabCnName;
},
 set: function(value)
{
 this.mstrINTabCnName = value;
    this.hmProperty["INTabCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// FeatureNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewRegionEN.prototype, "FeatureNum", {
 get: function ()
{
return this.mintFeatureNum;
},
 set: function(value)
{
 this.mintFeatureNum = value;
    this.hmProperty["FeatureNum"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"RegionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_RegionId", {
 get: function () {return "RegionId";}  // 区域Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_RegionName", {
 get: function () {return "RegionName";}  // 区域名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_ViewId", {
 get: function () {return "ViewId";}  // 界面Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_ViewName", {
 get: function () {return "ViewName";}  // 界面名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_ApplicationTypeId", {
 get: function () {return "ApplicationTypeId";}  // 应用程序类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_ViewCnName", {
 get: function () {return "ViewCnName";}  // 视图中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_RegionTypeId", {
 get: function () {return "RegionTypeId";}  // 区域类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_RegionTypeName", {
 get: function () {return "RegionTypeName";}  // 区域类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeSimName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_RegionTypeSimName", {
 get: function () {return "RegionTypeSimName";}  // 区域类型简名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeOrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_RegionTypeOrderNum", {
 get: function () {return "RegionTypeOrderNum";}  // 区域类型序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionFunction"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_RegionFunction", {
 get: function () {return "RegionFunction";}  // 区域功能
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ClassName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_ClassName", {
 get: function () {return "ClassName";}  // 类名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Height"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_Height", {
 get: function () {return "Height";}  // 高度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Width"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_Width", {
 get: function () {return "Width";}  // 宽
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OUTRelaTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_OUTRelaTabId", {
 get: function () {return "OUTRelaTabId";}  // 输出数据源表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INSQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_INSQLDSTypeId", {
 get: function () {return "INSQLDSTypeId";}  // 输入数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INRelaTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_INRelaTabId", {
 get: function () {return "INRelaTabId";}  // 输入数据源表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OUTSQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_OUTSQLDSTypeId", {
 get: function () {return "OUTSQLDSTypeId";}  // 输出数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"InUse"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_InUse", {
 get: function () {return "InUse";}  // 是否在用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OUTSqlDsTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_OUTSqlDsTypeName", {
 get: function () {return "OUTSqlDsTypeName";}  // OUT数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OUTTabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_OUTTabName", {
 get: function () {return "OUTTabName";}  // OUT表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OUTTabCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_OUTTabCnName", {
 get: function () {return "OUTTabCnName";}  // OUT表CH
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INSqlDsTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_INSqlDsTypeName", {
 get: function () {return "INSqlDsTypeName";}  // IN数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INTabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_INTabName", {
 get: function () {return "INTabName";}  // IN表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INTabCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_INTabCnName", {
 get: function () {return "INTabCnName";}  // IN表中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FeatureNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewRegionEN, "con_FeatureNum", {
 get: function () {return "FeatureNum";}  // FeatureNum
,
    enumerable: true,
    configurable: true
});

clsvViewRegionEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvViewRegionEN._CurrTabName = "vViewRegion"; //当前表名,与该类相关的表名
clsvViewRegionEN._KeyFldName = "RegionId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvViewRegionEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvViewRegionEN = clsvViewRegionEN;
});