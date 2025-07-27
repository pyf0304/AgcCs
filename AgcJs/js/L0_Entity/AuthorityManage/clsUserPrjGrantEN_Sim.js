
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPrjGrantEN_Sim
 表名:UserPrjGrant(00050092)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:14
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:权限管理
 模块英文名:AuthorityManage
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
 /// UserPrjGrant(UserPrjGrant)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsUserPrjGrantEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsUserPrjGrantEN_Sim()
 {
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 this.mId = 0;

/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 this.UserId = "";

/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 this.PrjId = "";

/// 角色ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.RoleId = "";

/// 访问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 this.VisitedNum = 0;

/// 最后访问时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 this.LastVisitedDate = "";

/// 操作者Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 this.OptId = "";

/// 操作日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 this.OptDate = "";

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsUserPrjGrantEN_Sim;
}());
exports.clsUserPrjGrantEN_Sim = clsUserPrjGrantEN_Sim;
});