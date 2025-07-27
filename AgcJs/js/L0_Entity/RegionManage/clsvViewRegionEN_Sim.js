
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionEN_Sim
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
 框架-层名:简化实体层RJ(EntityLayerRJ_Sim)
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
define(["require", "exports", "jquery", ], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
 /// <summary>
 /// v界面区域(vViewRegion)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsvViewRegionEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsvViewRegionEN_Sim()
 {
/// 区域Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 this.RegionId = 0;

/// 区域名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 this.RegionName = "";

/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.ViewId = "";

/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.ViewName = "";

/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ApplicationTypeId = 0;

/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.ViewCnName = "";

/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.RegionTypeId = "";

/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.RegionTypeName = "";

/// 区域类型简名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 this.RegionTypeSimName = "";

/// 区域类型序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.RegionTypeOrderNum = 0;

/// 区域功能(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 this.RegionFunction = "";

/// 类名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.ClassName = "";

/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.Height = 0;

/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.Width = 0;

/// 输出数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.OUTRelaTabId = "";

/// 输入数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.INSQLDSTypeId = "";

/// 输入数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.INRelaTabId = "";

/// 输出数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.OUTSQLDSTypeId = "";

/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.InUse = false;

/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.PrjId = "";

/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdUser = "";

/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdDate = "";

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

/// OUT数据源类型(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.OUTSqlDsTypeName = "";

/// OUT表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 this.OUTTabName = "";

/// OUT表CH(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 this.OUTTabCnName = "";

/// IN数据源类型(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.INSqlDsTypeName = "";

/// IN表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 this.INTabName = "";

/// IN表中文名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 this.INTabCnName = "";

/// FeatureNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.FeatureNum = 0;

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsvViewRegionEN_Sim;
}());
exports.clsvViewRegionEN_Sim = clsvViewRegionEN_Sim;
});