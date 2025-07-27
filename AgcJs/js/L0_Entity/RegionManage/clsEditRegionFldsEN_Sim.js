
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEditRegionFldsEN_Sim
 表名:EditRegionFlds(00050116)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:37
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
 /// 编辑区域字段(EditRegionFlds)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsEditRegionFldsEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsEditRegionFldsEN_Sim()
 {
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 this.mId = 0;

/// 区域Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 this.RegionId = 0;

/// 表字段ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 this.TabFldId = 0;

/// 标签标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.LabelCaption = "";

/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.CtlTypeId = "";

/// 下拉框列表选项ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.DDLItemsOptionId = "";

/// 数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.DS_TabId = "";

/// 数据源值字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.DS_DataValueFieldId = "";

/// 数据源文本字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.DS_DataTextFieldId = "";

/// 数据源条件串(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.DS_CondStr = "";

/// 数据源SQL串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 this.DS_SQLStr = "";

/// 列表项串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 this.ItemsString = "";

/// 跨列数(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.ColSpan = 0;

/// 列序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ColIndex = 0;

/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.Width = 0;

/// 是否多行(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsMultiRow = false;

/// 字段序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.SeqNum = 0;

/// INOUT类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.INOUTTypeId = "";

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

/// 是否同步到Server(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsSynchToServer = false;

/// 同步到Server日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.SynchToServerDate = "";

/// 同步到Server用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.SynchToServerUser = "";

/// 是否同步到Client(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsSynchToClient = false;

/// 同步到Client库日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.SynchToClientDate = "";

/// 同步到Client库用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.SynchToClientUser = "";

/// 同步来源(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.SynSource = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsEditRegionFldsEN_Sim;
}());
exports.clsEditRegionFldsEN_Sim = clsEditRegionFldsEN_Sim;
});