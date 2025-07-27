
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersEN_Sim
 表名:Users(00050001)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:12
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:用户管理
 模块英文名:UserManage
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
 /// 用于用户管理(Users)
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:GeneCode)
 /// </summary>
var clsUsersEN_Sim = /** @class */ (function () {

/// <summary>
 /// (AutoGCLib.EntityLayerRJ_Sim4JavaScript:Gen_EN_ClsProperty)
/// </summary>
 function clsUsersEN_Sim()
 {
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 this.UserId = "";

/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 this.UserName = "";

/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 this.DepartmentId = "";

/// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:True)
 this.UserStateId = "";

/// 角色ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 this.RoleId = "";

/// 权限等级(说明:;字段类型:int;字段长度:4;是否可空:False)
 this.QXDJ = 0;

/// 有效日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 this.EffectiveDate = "";

/// 有效开始日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 this.EffitiveBeginDate = "";

/// 有效结束日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 this.EffitiveEndDate = "";

/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 this.Password = "";

/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 this.IdentityID = "";

/// 电子邮箱(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 this.Email = "";

/// 是否平台用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsGpUser = false;

/// 注册密码(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 this.RegisterPassword = "";

/// 是否注册(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsRegister = false;

/// 注册日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 this.RegisterDate = "";

/// 是否审核(说明:;字段类型:bit;字段长度:1;是否可空:True)
 this.IsAudit = false;

/// 审核人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 this.AuditUser = "";

/// 审核日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 this.AuditDate = "";

/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdDate = "";

/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 this.UpdUser = "";

/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 this.Memo = "";

this.sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
this.sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
 }
return clsUsersEN_Sim;
}());
exports.clsUsersEN_Sim = clsUsersEN_Sim;
});