
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersEN
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
 框架-层名:实体层RJ(EntityLayerRJ)
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
define(["require", "exports", "jquery", "clsgeneraltab"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsGeneralTab_js_1 = require("clsgeneraltab");
 /// <summary>
 /// 用于用户管理(Users)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsUsersEN = /** @class */ (function (_super) {
__extends(clsUsersEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsUsersEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 22;
_this.AttributeName = new Array("UserId", "UserName", "DepartmentId", "UserStateId", "RoleId", "QXDJ", "EffectiveDate", "EffitiveBeginDate", "EffitiveEndDate", "Password", "IdentityID", "Email", "IsGpUser", "RegisterPassword", "IsRegister", "RegisterDate", "IsAudit", "AuditUser", "AuditDate", "UpdDate", "UpdUser", "Memo");
_this.strUserId = ""; //用户Id,
_this.strUserName = ""; //用户名,
_this.strDepartmentId = ""; //部门ID,
_this.strUserStateId = ""; //用户状态号,
_this.strRoleId = ""; //角色ID,
_this.intQXDJ = 0; //权限等级,
_this.strEffectiveDate = ""; //有效日期,
_this.strEffitiveBeginDate = ""; //有效开始日期,
_this.strEffitiveEndDate = ""; //有效结束日期,
_this.strPassword = ""; //口令,
_this.strIdentityID = ""; //身份编号,
_this.strEmail = ""; //电子邮箱,
_this.bolIsGpUser = false; //是否平台用户,
_this.strRegisterPassword = ""; //注册密码,
_this.bolIsRegister = false; //是否注册,
_this.strRegisterDate = ""; //注册日期,
_this.bolIsAudit = false; //是否审核,
_this.strAuditUser = ""; //审核人,
_this.strAuditDate = ""; //审核日期,
_this.strUpdDate = ""; //修改日期,
_this.strUpdUser = ""; //修改者,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "UserId", {
 get: function ()
{
return this.mstrUserId;
},
 set: function(value)
{
 this.mstrUserId = value;
    this.hmProperty["UserId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "UserName", {
 get: function ()
{
return this.mstrUserName;
},
 set: function(value)
{
 this.mstrUserName = value;
    this.hmProperty["UserName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "DepartmentId", {
 get: function ()
{
return this.mstrDepartmentId;
},
 set: function(value)
{
 this.mstrDepartmentId = value;
    this.hmProperty["DepartmentId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "UserStateId", {
 get: function ()
{
return this.mstrUserStateId;
},
 set: function(value)
{
 this.mstrUserStateId = value;
    this.hmProperty["UserStateId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 角色ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "RoleId", {
 get: function ()
{
return this.mstrRoleId;
},
 set: function(value)
{
 this.mstrRoleId = value;
    this.hmProperty["RoleId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 权限等级(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "QXDJ", {
 get: function ()
{
return this.mintQXDJ;
},
 set: function(value)
{
 this.mintQXDJ = value;
    this.hmProperty["QXDJ"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 有效日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "EffectiveDate", {
 get: function ()
{
return this.mstrEffectiveDate;
},
 set: function(value)
{
 this.mstrEffectiveDate = value;
    this.hmProperty["EffectiveDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 有效开始日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "EffitiveBeginDate", {
 get: function ()
{
return this.mstrEffitiveBeginDate;
},
 set: function(value)
{
 this.mstrEffitiveBeginDate = value;
    this.hmProperty["EffitiveBeginDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 有效结束日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "EffitiveEndDate", {
 get: function ()
{
return this.mstrEffitiveEndDate;
},
 set: function(value)
{
 this.mstrEffitiveEndDate = value;
    this.hmProperty["EffitiveEndDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "Password", {
 get: function ()
{
return this.mstrPassword;
},
 set: function(value)
{
 this.mstrPassword = value;
    this.hmProperty["Password"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "IdentityID", {
 get: function ()
{
return this.mstrIdentityID;
},
 set: function(value)
{
 this.mstrIdentityID = value;
    this.hmProperty["IdentityID"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 电子邮箱(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "Email", {
 get: function ()
{
return this.mstrEmail;
},
 set: function(value)
{
 this.mstrEmail = value;
    this.hmProperty["Email"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否平台用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "IsGpUser", {
 get: function ()
{
return this.mbolIsGpUser;
},
 set: function(value)
{
 this.mbolIsGpUser = value;
    this.hmProperty["IsGpUser"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 注册密码(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "RegisterPassword", {
 get: function ()
{
return this.mstrRegisterPassword;
},
 set: function(value)
{
 this.mstrRegisterPassword = value;
    this.hmProperty["RegisterPassword"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否注册(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "IsRegister", {
 get: function ()
{
return this.mbolIsRegister;
},
 set: function(value)
{
 this.mbolIsRegister = value;
    this.hmProperty["IsRegister"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 注册日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "RegisterDate", {
 get: function ()
{
return this.mstrRegisterDate;
},
 set: function(value)
{
 this.mstrRegisterDate = value;
    this.hmProperty["RegisterDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否审核(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "IsAudit", {
 get: function ()
{
return this.mbolIsAudit;
},
 set: function(value)
{
 this.mbolIsAudit = value;
    this.hmProperty["IsAudit"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 审核人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "AuditUser", {
 get: function ()
{
return this.mstrAuditUser;
},
 set: function(value)
{
 this.mstrAuditUser = value;
    this.hmProperty["AuditUser"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 审核日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "AuditDate", {
 get: function ()
{
return this.mstrAuditDate;
},
 set: function(value)
{
 this.mstrAuditDate = value;
    this.hmProperty["AuditDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "UpdDate", {
 get: function ()
{
return this.mstrUpdDate;
},
 set: function(value)
{
 this.mstrUpdDate = value;
    this.hmProperty["UpdDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "UpdUser", {
 get: function ()
{
return this.mstrUpdUser;
},
 set: function(value)
{
 this.mstrUpdUser = value;
    this.hmProperty["UpdUser"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUsersEN.prototype, "Memo", {
 get: function ()
{
return this.mstrMemo;
},
 set: function(value)
{
 this.mstrMemo = value;
    this.hmProperty["Memo"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"UserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_UserId", {
 get: function () {return "UserId";}  // 用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_UserName", {
 get: function () {return "UserName";}  // 用户名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DepartmentId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_DepartmentId", {
 get: function () {return "DepartmentId";}  // 部门ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_UserStateId", {
 get: function () {return "UserStateId";}  // 用户状态号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RoleId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_RoleId", {
 get: function () {return "RoleId";}  // 角色ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"QXDJ"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_QXDJ", {
 get: function () {return "QXDJ";}  // 权限等级
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"EffectiveDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_EffectiveDate", {
 get: function () {return "EffectiveDate";}  // 有效日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"EffitiveBeginDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_EffitiveBeginDate", {
 get: function () {return "EffitiveBeginDate";}  // 有效开始日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"EffitiveEndDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_EffitiveEndDate", {
 get: function () {return "EffitiveEndDate";}  // 有效结束日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Password"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_Password", {
 get: function () {return "Password";}  // 口令
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IdentityID"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_IdentityID", {
 get: function () {return "IdentityID";}  // 身份编号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Email"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_Email", {
 get: function () {return "Email";}  // 电子邮箱
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsGpUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_IsGpUser", {
 get: function () {return "IsGpUser";}  // 是否平台用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegisterPassword"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_RegisterPassword", {
 get: function () {return "RegisterPassword";}  // 注册密码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsRegister"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_IsRegister", {
 get: function () {return "IsRegister";}  // 是否注册
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegisterDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_RegisterDate", {
 get: function () {return "RegisterDate";}  // 注册日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsAudit"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_IsAudit", {
 get: function () {return "IsAudit";}  // 是否审核
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"AuditUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_AuditUser", {
 get: function () {return "AuditUser";}  // 审核人
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"AuditDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_AuditDate", {
 get: function () {return "AuditDate";}  // 审核日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUsersEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsUsersEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
this[strFldName] = strFldValue;
if (this.dicFldComparisonOp.hasOwnProperty(strFldName) == false)
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
else
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
}
clsUsersEN._CurrTabName = "Users"; //当前表名,与该类相关的表名
clsUsersEN._KeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsUsersEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsUsersEN = clsUsersEN;
});