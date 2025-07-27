
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvApplicationTypeEN_Sim
 表名:vApplicationType(00050403)
 生成代码版本:2020.04.08.1
 生成日期:2020/04/13 16:09:02
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:生成代码
 模块英文名:GeneCode
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
 /// v应用程序类型(vApplicationType)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsvApplicationTypeEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsvApplicationTypeEN_Sim()
 {
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ApplicationTypeId = 0;

/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.ApplicationTypeName = "";

/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 this.ApplicationTypeSimName = "";

/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.ApplicationTypeENName = "";

/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.ProgLangTypeId = "";

/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.ProgLangTypeName = "";

/// 编程语言类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.ProgLangTypeENName = "";

/// 字符编码(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 this.CharEncodingId = "";

/// 字符编码名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.CharEncodingName = "";

/// 编程语言类型Id2(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.ProgLangTypeId2 = "";

/// 编程语言类型Id3(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.ProgLangTypeId3 = "";

/// 编程语言类型Id4(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.ProgLangTypeId4 = "";

/// 编程语言类型Id5(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.ProgLangTypeId5 = "";

/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsVisible = false;

/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.OrderNum = 0;

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

/// CharEncodingId2(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.CharEncodingId2 = "";

/// CharEncodingId3(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.CharEncodingId3 = "";

/// CharEncodingName2(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.CharEncodingName2 = "";

/// CharEncodingName3(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.CharEncodingName3 = "";

/// ProgLangTypeName2(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 this.ProgLangTypeName2 = "";

/// ProgLangTypeName3(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 this.ProgLangTypeName3 = "";

/// ProgLangTypeName5(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 this.ProgLangTypeName5 = "";

/// 代码类型数(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.CodeTypeCount = 0;

/// CharEncodingId4(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.CharEncodingId4 = "";

/// CharEncodingName4(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.CharEncodingName4 = "";

/// ProgLangTypeName4(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 this.ProgLangTypeName4 = "";

/// CharEncodingId5(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.CharEncodingId5 = "";

/// CharEncodingName5(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.CharEncodingName5 = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsvApplicationTypeEN_Sim;
}());
exports.clsvApplicationTypeEN_Sim = clsvApplicationTypeEN_Sim;
});