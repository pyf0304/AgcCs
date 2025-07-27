
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewTypeCodeTabEN_Sim
 表名:vViewTypeCodeTab(00050133)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 00:36:53
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
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
 /// v界面类型码(vViewTypeCodeTab)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsvViewTypeCodeTabEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsvViewTypeCodeTabEN_Sim()
 {
/// 界面类型码(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ViewTypeCode = 0;

/// 界面类型名称(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 this.ViewTypeName = "";

/// ViewTypeENName(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 this.ViewTypeENName = "";

/// IsWinApp(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsWinApp = false;

/// 是否移动终端应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsMobileApp = false;

/// IsWebApp(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsWebApp = false;

/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.ViewFunction = "";

/// 操作流程(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.OptProcess = "";

/// 界面说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.ViewDetail = "";

/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ApplicationTypeId = 0;

/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.ApplicationTypeName = "";

/// 是否有添加(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsHaveAdd = false;

/// 是否有修改(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsHaveUpdate = false;

/// 是否有删除(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsHaveDel = false;

/// 是否有查询(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsHaveQuery = false;

/// 是否EXCEL导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsHaveExcelExport = false;

/// 是否有设置EXCEL导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsHaveSetExportExcel = false;

/// 是否有详细(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsHaveDetail = false;

/// 是否有调用添加(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsHaveExeAdd = false;

/// 是否有调用修改(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsHaveExeUpdate = false;

/// 是否有主界面(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsHaveMainView = false;

/// 是否有子界面(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsHaveSubView = false;

/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.OrderNum = 0;

/// IsUsed(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsUsed = false;

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsvViewTypeCodeTabEN_Sim;
}());
exports.clsvViewTypeCodeTabEN_Sim = clsvViewTypeCodeTabEN_Sim;
});