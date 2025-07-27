
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeTypeEN_Sim
 表名:CodeType(00050203)
 生成代码版本:2020.04.08.1
 生成日期:2020/04/12 15:39:59
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
 /// 代码类型(CodeType)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsCodeTypeEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsCodeTypeEN_Sim()
 {
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.CodeTypeId = "";

/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 this.CodeTypeName = "";

/// 简称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 this.CodeTypeSimName = "";

/// 代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.CodeTypeENName = "";

/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.GroupName = "";

/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.ProgLangTypeId = "";

/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.RegionTypeId = "";

/// 前缀(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 this.Prefix = "";

/// 依赖于(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.DependsOn = "";

/// 前台Or后台(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.FrontOrBack = "";

/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.SQLDSTypeId = "";

/// 类名格式(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.ClassNameFormat = "";

/// 文件名格式(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.FileNameFormat = "";

/// 类名模式(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.ClassNamePattern = "";

/// 是否CSharp语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsCSharp = false;

/// 是否Java语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsJava = false;

/// 是否JavaScript语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsJavaScript = false;

/// 是否TypeScript语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsTypeScript = false;

/// 是否SilverLight语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsSilverLight = false;

/// 是否Swift语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsSwift = false;

/// IsVB语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsVB = false;

/// IsTableFldConst(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsTableFldConst = false;

/// IsPubApp4WinWeb(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsPubApp4WinWeb = false;

/// 是否Web应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsWeb = false;

/// 是否AspMvc(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsAspMvc = false;

/// IsWebSrvAccess(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsWebSrvAccess = false;

/// 是否Win应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsWin = false;

/// 是否移动终端应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsMobileApp = false;

/// 是否扩展类(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsExtend = false;

/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.OrderNum = 0;

/// WinOrWeb(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.WinOrWeb = "";

/// 是否用表名作为路径(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsDirByTabName = false;

/// 是否默认覆盖(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsDefaultOverride = false;

/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.InUse = false;

/// 是否自动分析文件(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsAutoParseFile = false;

/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdDate = "";

/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdUser = "";

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsCodeTypeEN_Sim;
}());
exports.clsCodeTypeEN_Sim = clsCodeTypeEN_Sim;
});