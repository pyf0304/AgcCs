
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTabEN_Sim
 表名:FieldTab(00050021)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/29 17:27:15
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
 /// 工程字段(FieldTab)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsFieldTabEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsFieldTabEN_Sim()
 {
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.FldId = "";

/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.PrjId = "";

/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 this.FldName = "";

/// 字段中文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 this.FldCnName = "";

/// 字段英文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 this.FldEnName = "";

/// 字段名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.FldName_B = "";

/// 字段名_国标(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.FldName_G = "";

/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 this.Caption = "";

/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.FieldTypeId = "";

/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.DataTypeId = "";

/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.FldLength = 0;

/// 精确度(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.FldPrecision = 0;

/// 字段信息(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.FldInfo = "";

/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNull = false;

/// 是否主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsPrimaryKey = false;

/// 是否Identity(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsIdentity = false;

/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsNationStandard = false;

/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsChecked = false;

/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsArchive = false;

/// 是否唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsOnlyOne = false;

/// 最大值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.MaxValue = "";

/// 最小值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.MinValue = "";

/// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.DefaultValue = "";

/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNeedTransCode = false;

/// 应用范围(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 this.AppliedScope = "";

/// 字段状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.FldStateId = "";

/// CodeTabId(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.CodeTabId = "";

/// CodeTab_NameId(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.CodeTab_NameId = "";

/// CodeTab_CodeId(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.CodeTab_CodeId = "";

/// 是否根字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsRootFld = false;

/// 主根表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.Root4TabId = "";

/// 根字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.RootFldId = "";

/// 根表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.RootTabId = "";

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

/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdDate = "";

/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdUser = "";

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsFieldTabEN_Sim;
}());
exports.clsFieldTabEN_Sim = clsFieldTabEN_Sim;
});