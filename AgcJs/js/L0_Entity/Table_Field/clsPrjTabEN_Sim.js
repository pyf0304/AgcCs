
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabEN_Sim
 表名:PrjTab(00050009)
 生成代码版本:2020.04.08.1
 生成日期:2020/04/13 16:56:03
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
 /// 工程表(PrjTab)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsPrjTabEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsPrjTabEN_Sim()
 {
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.TabId = "";

/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 this.TabName = "";

/// 表英文详细名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 this.TabEnName = "";

/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 this.TabCnName = "";

/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.PrjId = "";

/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 this.IsNeedTransCode = false;

/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.SQLDSTypeId = "";

/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.TabStateId = "";

/// 表名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.TabName_B = "";

/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsParaTab = false;

/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsNationStandard = false;

/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsArchive = false;

/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsChecked = false;

/// 错误信息(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 this.ErrMsg = "";

/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.FuncModuleAgcId = "";

/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 this.DataBaseName = "";

/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 this.Owner = "";

/// 是否与SQL表相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsReleToSqlTab = false;

/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.KeyWord = "";

/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.TabTypeId = "";

/// 表主类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 this.TabMainTypeId = "";

/// 视图的相关表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 this.RelaTabId4View = "";

/// 是否需要检查表字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsNeedCheckTab = false;

/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.OrderNum4Refer = 0;

/// 是否需要生成索引器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsNeedGeneIndexer = false;

/// RelaViewId(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.RelaViewId = "";

/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.PrimaryTypeId = "";

/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.PrimaryTypeName = "";

/// 父类(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.ParentClass = "";

/// 是否使用Cache(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsUseCache = false;

/// 缓存分类字段(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.CacheClassifyField = "";

/// 关键字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.KeyFldId = "";

/// 关键字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.KeyFldName = "";

/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdUserId = "";

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
return clsPrjTabEN_Sim;
}());
exports.clsPrjTabEN_Sim = clsPrjTabEN_Sim;
});