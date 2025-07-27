
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProjectsEN_Sim
 表名:Projects(00050002)
 生成代码版本:2020.04.08.1
 生成日期:2020/04/13 16:55:56
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:工程管理
 模块英文名:PrjManage
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
 /// 工程(Projects)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsProjectsEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsProjectsEN_Sim()
 {
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.PrjId = "";

/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.PrjName = "";

/// 域/包名(说明:;字段类型:varchar;字段长度:128;是否可空:True)
 this.PrjDomain = "";

/// ISO工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.ISOPrjName = "";

/// Java包名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 this.JavaPackageName = "";

/// 表空间(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.TableSpace = "";

/// 虚拟目录(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.VirtualDirectory = "";

/// 工程根目录(说明:;字段类型:varchar;字段长度:255;是否可空:True)
 this.PrjRootDirectory = "";

/// 是否关联数据库(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsRelaDataBase = false;

/// 架构ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.SoftStructureId = "";

/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ApplicationTypeId = 0;

/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.UseStateId = "";

/// 是否支持Mvc(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsSupportMvc = false;

/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 this.UserId = "";

/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdDate = "";

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsProjectsEN_Sim;
}());
exports.clsProjectsEN_Sim = clsProjectsEN_Sim;
});