
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataTypeAbbrEN_Sim
 表名:DataTypeAbbr(00050023)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:33
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
 /// 数据类型(DataTypeAbbr)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsDataTypeAbbrEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsDataTypeAbbrEN_Sim()
 {
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.DataTypeId = "";

/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.DataTypeName = "";

/// DataTypeENName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.DataTypeENName = "";

/// 数据类型中文名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.DataCnName = "";

/// 数据类型缩写(说明:;字段类型:varchar;字段长度:5;是否可空:False)
 this.DataTypeAbbr = "";

/// NET系统类型(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 this.NetSysType = "";

/// VBNET类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.VBNETType = "";

/// CS类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.CSType = "";

/// JAVA类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.JavaType = "";

/// TypeScript类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.TypeScriptType = "";

/// JAVA对象类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.JavaObjType = "";

/// SwiftType(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.SwiftType = "";

/// 是否需要引号(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNeedQuote = false;

/// Ora数据类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.OraDbType = "";

/// 是否可作返回类型(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsReturnType = false;

/// SQL参数类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.SqlParaType = "";

/// MySqlType(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.MySqlType = "";

/// 默认长度(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.DefaFldLength = 0;

/// 默认小数位数(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.DefaFldPrecision = 0;

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsDataTypeAbbrEN_Sim;
}());
exports.clsDataTypeAbbrEN_Sim = clsDataTypeAbbrEN_Sim;
});