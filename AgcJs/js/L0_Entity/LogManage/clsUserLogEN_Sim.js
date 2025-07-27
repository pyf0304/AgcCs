
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserLogEN_Sim
 表名:UserLog(00050130)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:11
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
 /// 用户日志(UserLog)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsUserLogEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsUserLogEN_Sim()
 {
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 this.mId = 0;

/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 this.UserId = "";

/// 登陆时间(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 this.LoginTime = "";

/// 登陆日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.LoginDate = "";

/// 用户IP(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 this.UserIp = "";

/// 对象表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.ObjectTable = "";

/// 使用值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.UsedValue = "";

/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdDate = "";

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this._IsDeleted = false;

/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.OrderNum = 0;

/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this._DeletedDate = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsUserLogEN_Sim;
}());
exports.clsUserLogEN_Sim = clsUserLogEN_Sim;
});