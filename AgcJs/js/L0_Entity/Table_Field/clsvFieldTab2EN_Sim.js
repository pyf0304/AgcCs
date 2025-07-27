
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab2EN_Sim
 表名:vFieldTab2(00050120)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/29 18:00:09
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
 /// vFieldTab2(vFieldTab2)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsvFieldTab2EN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsvFieldTab2EN_Sim()
 {
/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.DataTypeName = "";

/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.FldId = "";

/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.PrjId = "";

/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.PrjName = "";

/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 this.FldName = "";

/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 this.Caption = "";

/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.FldLength = 0;

/// 字段信息(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.FldInfo = "";

/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNull = false;

/// 是否主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsPrimaryKey = false;

/// 是否Identity(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsIdentity = false;

/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsChecked = false;

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

/// CodeTabId(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.CodeTabId = "";

/// CodeTab_NameId(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.CodeTab_NameId = "";

/// CodeTab_CodeId(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.CodeTab_CodeId = "";

/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdDate = "";

/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdUser = "";

/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.UserName = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsvFieldTab2EN_Sim;
}());
exports.clsvFieldTab2EN_Sim = clsvFieldTab2EN_Sim;
});