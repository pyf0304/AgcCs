
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfo4GeneCodeEN_Sim
 表名:vViewInfo4GeneCode(00050283)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 00:34:45
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:日志管理
 模块英文名:LogManage
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
 /// vViewInfo4GeneCode(vViewInfo4GeneCode)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsvViewInfo4GeneCodeEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsvViewInfo4GeneCodeEN_Sim()
 {
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.ViewId = "";

/// 标题类型Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 this.TitleStyleId = "";

/// 标题类型名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 this.TitleStyleName = "";

/// DG模式ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 this.DGStyleId = "";

/// DG模式名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.DGStyleName = "";

/// 生成代码版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.Version_GeneCode = "";

/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.ViewName = "";

/// 界面类型码(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ViewTypeCode = 0;

/// 界面类型名称(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 this.ViewTypeName = "";

/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.ApplicationTypeId = 0;

/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.ApplicationTypeName = "";

/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.FuncModuleAgcId = "";

/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.FuncModuleName = "";

/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 this.FuncModuleEnName = "";

/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 this.DataBaseName = "";

/// 主表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.KeyForMainTab = "";

/// 明细表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.KeyForDetailTab = "";

/// 是否需要排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNeedSort = false;

/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNeedTransCode = false;

/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 this.UserId = "";

/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.PrjId = "";

/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.PrjName = "";

/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.ViewFunction = "";

/// 界面说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.ViewDetail = "";

/// 缺省菜单名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.DefaMenuName = "";

/// 明细表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.DetailTabId = "";

/// 文件名(说明:;字段类型:varchar;字段长度:150;是否可空:False)
 this.FileName = "";

/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 this.FilePath = "";

/// 主表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.MainTabId = "";

/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.ViewCnName = "";

/// 界面组ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.ViewGroupId = "";

/// 界面组名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.ViewGroupName = "";

/// 输入数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.INSQLDSTypeId = "";

/// 输出数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.OUTSQLDSTypeId = "";

/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.GeneCodeDate = "";

/// 区域数(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.RegionNum = 0;

/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdDate = "";

/// 主表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 this.MainTabName = "";

/// 详细表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 this.DetailTabName = "";

/// MainTabKeyFld(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.MainTabKeyFld = "";

/// DetailTabKeyFld(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.DetailTabKeyFld = "";

/// UserId4GeneCode(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 this.UserId4GeneCode = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsvViewInfo4GeneCodeEN_Sim;
}());
exports.clsvViewInfo4GeneCodeEN_Sim = clsvViewInfo4GeneCodeEN_Sim;
});