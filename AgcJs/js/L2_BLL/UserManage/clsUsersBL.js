
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersBL
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
 框架-层名:业务逻辑层RJ(BusinessLogicRJ)
 编程语言:JavaScript
 == == == == == == == == == == == == 
 */
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
define(["require", "exports", "jquery", "../../L0_Entity/UserManage/clsUsersEN.js","../../L0_Entity/UserManage/clsUsersEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsUsersEN_js_1 = require("../../L0_Entity/UserManage/clsUsersEN.js");
var clsUsersEN_Sim_js_1 = require("../../L0_Entity/UserManage/clsUsersEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 用于用户管理(Users)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsUsersBL = /** @class */ (function () {
function clsUsersBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrUsersObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsUsersBL.prototype.CheckPropertyNew = function(pobjUsersEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjUsersEN.UserName 
 || null !== pobjUsersEN.UserName && pobjUsersEN.UserName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[用于用户管理|用户名]不能为空(NULL)!(clsUsersBL:CheckPropertyNew)");
}
if (null === pobjUsersEN.DepartmentId 
 || null !== pobjUsersEN.DepartmentId && pobjUsersEN.DepartmentId.toString()  ===  ""
 || null !== pobjUsersEN.DepartmentId && pobjUsersEN.DepartmentId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[用于用户管理|部门ID]不能为空(NULL)!(clsUsersBL:CheckPropertyNew)");
}
if (null === pobjUsersEN.Password 
 || null !== pobjUsersEN.Password && pobjUsersEN.Password.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[用于用户管理|口令]不能为空(NULL)!(clsUsersBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjUsersEN.UserId && GetStrLen(pobjUsersEN.UserId) > 18)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|用户Id(UserId)]的长度不能超过18!值:$(pobjUsersEN.UserId)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.UserName && GetStrLen(pobjUsersEN.UserName) > 30)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|用户名(UserName)]的长度不能超过30!值:$(pobjUsersEN.UserName)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.DepartmentId && GetStrLen(pobjUsersEN.DepartmentId) > 6)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|部门ID(DepartmentId)]的长度不能超过6!值:$(pobjUsersEN.DepartmentId)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.UserStateId && GetStrLen(pobjUsersEN.UserStateId) > 2)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|用户状态号(UserStateId)]的长度不能超过2!值:$(pobjUsersEN.UserStateId)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.RoleId && GetStrLen(pobjUsersEN.RoleId) > 8)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|角色ID(RoleId)]的长度不能超过8!值:$(pobjUsersEN.RoleId)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.EffectiveDate && GetStrLen(pobjUsersEN.EffectiveDate) > 8)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|有效日期(EffectiveDate)]的长度不能超过8!值:$(pobjUsersEN.EffectiveDate)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.EffitiveBeginDate && GetStrLen(pobjUsersEN.EffitiveBeginDate) > 14)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|有效开始日期(EffitiveBeginDate)]的长度不能超过14!值:$(pobjUsersEN.EffitiveBeginDate)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.EffitiveEndDate && GetStrLen(pobjUsersEN.EffitiveEndDate) > 14)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|有效结束日期(EffitiveEndDate)]的长度不能超过14!值:$(pobjUsersEN.EffitiveEndDate)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.Password && GetStrLen(pobjUsersEN.Password) > 20)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|口令(Password)]的长度不能超过20!值:$(pobjUsersEN.Password)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.IdentityID && GetStrLen(pobjUsersEN.IdentityID) > 2)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|身份编号(IdentityID)]的长度不能超过2!值:$(pobjUsersEN.IdentityID)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.Email && GetStrLen(pobjUsersEN.Email) > 50)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|电子邮箱(Email)]的长度不能超过50!值:$(pobjUsersEN.Email)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.RegisterPassword && GetStrLen(pobjUsersEN.RegisterPassword) > 30)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|注册密码(RegisterPassword)]的长度不能超过30!值:$(pobjUsersEN.RegisterPassword)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.RegisterDate && GetStrLen(pobjUsersEN.RegisterDate) > 14)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|注册日期(RegisterDate)]的长度不能超过14!值:$(pobjUsersEN.RegisterDate)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.AuditUser && GetStrLen(pobjUsersEN.AuditUser) > 18)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|审核人(AuditUser)]的长度不能超过18!值:$(pobjUsersEN.AuditUser)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.AuditDate && GetStrLen(pobjUsersEN.AuditDate) > 14)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|审核日期(AuditDate)]的长度不能超过14!值:$(pobjUsersEN.AuditDate)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.UpdDate && GetStrLen(pobjUsersEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjUsersEN.UpdDate)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.UpdUser && GetStrLen(pobjUsersEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|修改者(UpdUser)]的长度不能超过20!值:$(pobjUsersEN.UpdUser)(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.Memo && GetStrLen(pobjUsersEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[用于用户管理(Users)|说明(Memo)]的长度不能超过1000!值:$(pobjUsersEN.Memo)(clsUsersBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjUsersEN.UserId && undefined !== pobjUsersEN.UserId && tzDataType.isString(pobjUsersEN.UserId) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|用户Id(UserId)]的值:[$(pobjUsersEN.UserId)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.UserName && undefined !== pobjUsersEN.UserName && tzDataType.isString(pobjUsersEN.UserName) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|用户名(UserName)]的值:[$(pobjUsersEN.UserName)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.DepartmentId && undefined !== pobjUsersEN.DepartmentId && tzDataType.isString(pobjUsersEN.DepartmentId) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|部门ID(DepartmentId)]的值:[$(pobjUsersEN.DepartmentId)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.UserStateId && undefined !== pobjUsersEN.UserStateId && tzDataType.isString(pobjUsersEN.UserStateId) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|用户状态号(UserStateId)]的值:[$(pobjUsersEN.UserStateId)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.RoleId && undefined !== pobjUsersEN.RoleId && tzDataType.isString(pobjUsersEN.RoleId) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|角色ID(RoleId)]的值:[$(pobjUsersEN.RoleId)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.QXDJ && undefined !== pobjUsersEN.QXDJ && tzDataType.isNumber(pobjUsersEN.QXDJ) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|权限等级(QXDJ)]的值:[$(pobjUsersEN.QXDJ)], 非法，应该为数值型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.EffectiveDate && undefined !== pobjUsersEN.EffectiveDate && tzDataType.isString(pobjUsersEN.EffectiveDate) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|有效日期(EffectiveDate)]的值:[$(pobjUsersEN.EffectiveDate)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.EffitiveBeginDate && undefined !== pobjUsersEN.EffitiveBeginDate && tzDataType.isString(pobjUsersEN.EffitiveBeginDate) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|有效开始日期(EffitiveBeginDate)]的值:[$(pobjUsersEN.EffitiveBeginDate)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.EffitiveEndDate && undefined !== pobjUsersEN.EffitiveEndDate && tzDataType.isString(pobjUsersEN.EffitiveEndDate) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|有效结束日期(EffitiveEndDate)]的值:[$(pobjUsersEN.EffitiveEndDate)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.Password && undefined !== pobjUsersEN.Password && tzDataType.isString(pobjUsersEN.Password) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|口令(Password)]的值:[$(pobjUsersEN.Password)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.IdentityID && undefined !== pobjUsersEN.IdentityID && tzDataType.isString(pobjUsersEN.IdentityID) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|身份编号(IdentityID)]的值:[$(pobjUsersEN.IdentityID)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.Email && undefined !== pobjUsersEN.Email && tzDataType.isString(pobjUsersEN.Email) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|电子邮箱(Email)]的值:[$(pobjUsersEN.Email)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.IsGpUser && undefined !== pobjUsersEN.IsGpUser && tzDataType.isBoolean(pobjUsersEN.IsGpUser) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|是否平台用户(IsGpUser)]的值:[$(pobjUsersEN.IsGpUser)], 非法，应该为布尔型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.RegisterPassword && undefined !== pobjUsersEN.RegisterPassword && tzDataType.isString(pobjUsersEN.RegisterPassword) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|注册密码(RegisterPassword)]的值:[$(pobjUsersEN.RegisterPassword)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.IsRegister && undefined !== pobjUsersEN.IsRegister && tzDataType.isBoolean(pobjUsersEN.IsRegister) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|是否注册(IsRegister)]的值:[$(pobjUsersEN.IsRegister)], 非法，应该为布尔型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.RegisterDate && undefined !== pobjUsersEN.RegisterDate && tzDataType.isString(pobjUsersEN.RegisterDate) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|注册日期(RegisterDate)]的值:[$(pobjUsersEN.RegisterDate)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.IsAudit && undefined !== pobjUsersEN.IsAudit && tzDataType.isBoolean(pobjUsersEN.IsAudit) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|是否审核(IsAudit)]的值:[$(pobjUsersEN.IsAudit)], 非法，应该为布尔型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.AuditUser && undefined !== pobjUsersEN.AuditUser && tzDataType.isString(pobjUsersEN.AuditUser) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|审核人(AuditUser)]的值:[$(pobjUsersEN.AuditUser)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.AuditDate && undefined !== pobjUsersEN.AuditDate && tzDataType.isString(pobjUsersEN.AuditDate) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|审核日期(AuditDate)]的值:[$(pobjUsersEN.AuditDate)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.UpdDate && undefined !== pobjUsersEN.UpdDate && tzDataType.isString(pobjUsersEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|修改日期(UpdDate)]的值:[$(pobjUsersEN.UpdDate)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.UpdUser && undefined !== pobjUsersEN.UpdUser && tzDataType.isString(pobjUsersEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|修改者(UpdUser)]的值:[$(pobjUsersEN.UpdUser)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
if (null !== pobjUsersEN.Memo && undefined !== pobjUsersEN.Memo && tzDataType.isString(pobjUsersEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[用于用户管理(Users)|说明(Memo)]的值:[$(pobjUsersEN.Memo)], 非法，应该为字符型!(clsUsersBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjUsersEN.UserStateId != null && GetStrLen(pobjUsersEN.UserStateId) !=  2)
{
 throw ("(errid:Busi000157)字段[用于用户管理|用户状态号]作为外键字段,长度应该为2!(clsUsersBL:CheckPropertyNew)");
}
if (pobjUsersEN.RoleId != null && GetStrLen(pobjUsersEN.RoleId) !=  8)
{
 throw ("(errid:Busi000157)字段[用于用户管理|角色ID]作为外键字段,长度应该为8!(clsUsersBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjUsersEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsUsersBL.prototype.CheckProperty4Update  = function(pobjUsersEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjUsersEN.UserId && GetStrLen(pobjUsersEN.UserId) > 18)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|用户Id(UserId)]的长度不能超过18!值:$(pobjUsersEN.UserId)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.UserName && GetStrLen(pobjUsersEN.UserName) > 30)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|用户名(UserName)]的长度不能超过30!值:$(pobjUsersEN.UserName)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.DepartmentId && GetStrLen(pobjUsersEN.DepartmentId) > 6)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|部门ID(DepartmentId)]的长度不能超过6!值:$(pobjUsersEN.DepartmentId)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.UserStateId && GetStrLen(pobjUsersEN.UserStateId) > 2)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|用户状态号(UserStateId)]的长度不能超过2!值:$(pobjUsersEN.UserStateId)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.RoleId && GetStrLen(pobjUsersEN.RoleId) > 8)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|角色ID(RoleId)]的长度不能超过8!值:$(pobjUsersEN.RoleId)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.EffectiveDate && GetStrLen(pobjUsersEN.EffectiveDate) > 8)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|有效日期(EffectiveDate)]的长度不能超过8!值:$(pobjUsersEN.EffectiveDate)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.EffitiveBeginDate && GetStrLen(pobjUsersEN.EffitiveBeginDate) > 14)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|有效开始日期(EffitiveBeginDate)]的长度不能超过14!值:$(pobjUsersEN.EffitiveBeginDate)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.EffitiveEndDate && GetStrLen(pobjUsersEN.EffitiveEndDate) > 14)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|有效结束日期(EffitiveEndDate)]的长度不能超过14!值:$(pobjUsersEN.EffitiveEndDate)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.Password && GetStrLen(pobjUsersEN.Password) > 20)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|口令(Password)]的长度不能超过20!值:$(pobjUsersEN.Password)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.IdentityID && GetStrLen(pobjUsersEN.IdentityID) > 2)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|身份编号(IdentityID)]的长度不能超过2!值:$(pobjUsersEN.IdentityID)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.Email && GetStrLen(pobjUsersEN.Email) > 50)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|电子邮箱(Email)]的长度不能超过50!值:$(pobjUsersEN.Email)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.RegisterPassword && GetStrLen(pobjUsersEN.RegisterPassword) > 30)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|注册密码(RegisterPassword)]的长度不能超过30!值:$(pobjUsersEN.RegisterPassword)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.RegisterDate && GetStrLen(pobjUsersEN.RegisterDate) > 14)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|注册日期(RegisterDate)]的长度不能超过14!值:$(pobjUsersEN.RegisterDate)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.AuditUser && GetStrLen(pobjUsersEN.AuditUser) > 18)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|审核人(AuditUser)]的长度不能超过18!值:$(pobjUsersEN.AuditUser)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.AuditDate && GetStrLen(pobjUsersEN.AuditDate) > 14)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|审核日期(AuditDate)]的长度不能超过14!值:$(pobjUsersEN.AuditDate)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.UpdDate && GetStrLen(pobjUsersEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjUsersEN.UpdDate)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.UpdUser && GetStrLen(pobjUsersEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|修改者(UpdUser)]的长度不能超过20!值:$(pobjUsersEN.UpdUser)(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.Memo && GetStrLen(pobjUsersEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[用于用户管理(Users)|说明(Memo)]的长度不能超过1000!值:$(pobjUsersEN.Memo)(clsUsersBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjUsersEN.UserId && undefined !== pobjUsersEN.UserId && tzDataType.isString(pobjUsersEN.UserId) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|用户Id(UserId)]的值:[$(pobjUsersEN.UserId)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.UserName && undefined !== pobjUsersEN.UserName && tzDataType.isString(pobjUsersEN.UserName) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|用户名(UserName)]的值:[$(pobjUsersEN.UserName)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.DepartmentId && undefined !== pobjUsersEN.DepartmentId && tzDataType.isString(pobjUsersEN.DepartmentId) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|部门ID(DepartmentId)]的值:[$(pobjUsersEN.DepartmentId)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.UserStateId && undefined !== pobjUsersEN.UserStateId && tzDataType.isString(pobjUsersEN.UserStateId) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|用户状态号(UserStateId)]的值:[$(pobjUsersEN.UserStateId)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.RoleId && undefined !== pobjUsersEN.RoleId && tzDataType.isString(pobjUsersEN.RoleId) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|角色ID(RoleId)]的值:[$(pobjUsersEN.RoleId)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.QXDJ && undefined !== pobjUsersEN.QXDJ && tzDataType.isNumber(pobjUsersEN.QXDJ) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|权限等级(QXDJ)]的值:[$(pobjUsersEN.QXDJ)], 非法，应该为数值型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.EffectiveDate && undefined !== pobjUsersEN.EffectiveDate && tzDataType.isString(pobjUsersEN.EffectiveDate) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|有效日期(EffectiveDate)]的值:[$(pobjUsersEN.EffectiveDate)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.EffitiveBeginDate && undefined !== pobjUsersEN.EffitiveBeginDate && tzDataType.isString(pobjUsersEN.EffitiveBeginDate) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|有效开始日期(EffitiveBeginDate)]的值:[$(pobjUsersEN.EffitiveBeginDate)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.EffitiveEndDate && undefined !== pobjUsersEN.EffitiveEndDate && tzDataType.isString(pobjUsersEN.EffitiveEndDate) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|有效结束日期(EffitiveEndDate)]的值:[$(pobjUsersEN.EffitiveEndDate)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.Password && undefined !== pobjUsersEN.Password && tzDataType.isString(pobjUsersEN.Password) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|口令(Password)]的值:[$(pobjUsersEN.Password)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.IdentityID && undefined !== pobjUsersEN.IdentityID && tzDataType.isString(pobjUsersEN.IdentityID) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|身份编号(IdentityID)]的值:[$(pobjUsersEN.IdentityID)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.Email && undefined !== pobjUsersEN.Email && tzDataType.isString(pobjUsersEN.Email) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|电子邮箱(Email)]的值:[$(pobjUsersEN.Email)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.IsGpUser && undefined !== pobjUsersEN.IsGpUser && tzDataType.isBoolean(pobjUsersEN.IsGpUser) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|是否平台用户(IsGpUser)]的值:[$(pobjUsersEN.IsGpUser)], 非法，应该为布尔型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.RegisterPassword && undefined !== pobjUsersEN.RegisterPassword && tzDataType.isString(pobjUsersEN.RegisterPassword) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|注册密码(RegisterPassword)]的值:[$(pobjUsersEN.RegisterPassword)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.IsRegister && undefined !== pobjUsersEN.IsRegister && tzDataType.isBoolean(pobjUsersEN.IsRegister) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|是否注册(IsRegister)]的值:[$(pobjUsersEN.IsRegister)], 非法，应该为布尔型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.RegisterDate && undefined !== pobjUsersEN.RegisterDate && tzDataType.isString(pobjUsersEN.RegisterDate) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|注册日期(RegisterDate)]的值:[$(pobjUsersEN.RegisterDate)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.IsAudit && undefined !== pobjUsersEN.IsAudit && tzDataType.isBoolean(pobjUsersEN.IsAudit) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|是否审核(IsAudit)]的值:[$(pobjUsersEN.IsAudit)], 非法，应该为布尔型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.AuditUser && undefined !== pobjUsersEN.AuditUser && tzDataType.isString(pobjUsersEN.AuditUser) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|审核人(AuditUser)]的值:[$(pobjUsersEN.AuditUser)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.AuditDate && undefined !== pobjUsersEN.AuditDate && tzDataType.isString(pobjUsersEN.AuditDate) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|审核日期(AuditDate)]的值:[$(pobjUsersEN.AuditDate)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.UpdDate && undefined !== pobjUsersEN.UpdDate && tzDataType.isString(pobjUsersEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|修改日期(UpdDate)]的值:[$(pobjUsersEN.UpdDate)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.UpdUser && undefined !== pobjUsersEN.UpdUser && tzDataType.isString(pobjUsersEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|修改者(UpdUser)]的值:[$(pobjUsersEN.UpdUser)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
if (null !== pobjUsersEN.Memo && undefined !== pobjUsersEN.Memo && tzDataType.isString(pobjUsersEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[用于用户管理(Users)|说明(Memo)]的值:[$(pobjUsersEN.Memo)], 非法，应该为字符型!(clsUsersBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjUsersEN.UserId 
 || null !== pobjUsersEN.UserId && pobjUsersEN.UserId.toString()  ===  ""
 || null !== pobjUsersEN.UserId && pobjUsersEN.UserId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[用于用户管理|用户Id]不能为空(NULL)!(clsUsersBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjUsersEN.UserStateId != null && GetStrLen(pobjUsersEN.UserStateId) !=  2)
{
 throw ("(errid:Busi000161)字段[用于用户管理|用户状态号]作为外键字段,长度应该为2!(clsUsersBL:CheckPropertyNew)");
}
if (pobjUsersEN.RoleId != null && GetStrLen(pobjUsersEN.RoleId) !=  8)
{
 throw ("(errid:Busi000161)字段[用于用户管理|角色ID]作为外键字段,长度应该为8!(clsUsersBL:CheckPropertyNew)");
}

 pobjUsersEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024912
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsUsersBL.GetJSONStrByObj  = function(pobjUsersEN)
{
pobjUsersEN.sf_UpdFldSetStr = pobjUsersEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjUsersEN);
}
catch(objException)
{
myShowErrorMsg(objException.message);
}
return strJson;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象列表
 /// 作者:
 /// 日期:20200501024912
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsUsersBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrUsersObjLst = new Array();
if (strJSON === "")
{
return arrUsersObjLst;
}
try
{
arrUsersObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrUsersObjLst;
}
return arrUsersObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024912
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsUsersBL.GetObjByJSONStr  = function(strJSON)
{
var pobjUsersEN = new clsUsersEN();
if (strJSON === "")
{
return pobjUsersEN;
}
try
{
pobjUsersEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjUsersEN;
}
return pobjUsersEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objUsersENS">源简化对象</param>
 /// <param name = "objUsersENT">目标对象</param>
clsUsersBL.CopyObjFromSimObj = function(objUsersENS, objUsersENT) 
{
objUsersENT.UserId = objUsersENS.UserId; //用户Id
objUsersENT.UserName = objUsersENS.UserName; //用户名
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门ID
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态号
objUsersENT.RoleId = objUsersENS.RoleId; //角色ID
objUsersENT.QXDJ = objUsersENS.QXDJ; //权限等级
objUsersENT.EffectiveDate = objUsersENS.EffectiveDate; //有效日期
objUsersENT.EffitiveBeginDate = objUsersENS.EffitiveBeginDate; //有效开始日期
objUsersENT.EffitiveEndDate = objUsersENS.EffitiveEndDate; //有效结束日期
objUsersENT.Password = objUsersENS.Password; //口令
objUsersENT.IdentityID = objUsersENS.IdentityID; //身份编号
objUsersENT.Email = objUsersENS.Email; //电子邮箱
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否平台用户
objUsersENT.RegisterPassword = objUsersENS.RegisterPassword; //注册密码
objUsersENT.IsRegister = objUsersENS.IsRegister; //是否注册
objUsersENT.RegisterDate = objUsersENS.RegisterDate; //注册日期
objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
objUsersENT.AuditUser = objUsersENS.AuditUser; //审核人
objUsersENT.AuditDate = objUsersENS.AuditDate; //审核日期
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改者
objUsersENT.Memo = objUsersENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objUsersENS">源对象</param>
 /// <param name = "objUsersENT">目标对象</param>
clsUsersBL.CopyObjTo = function(objUsersENS , objUsersENT ) 
{
objUsersENT.UserId = objUsersENS.UserId; //用户Id
objUsersENT.UserName = objUsersENS.UserName; //用户名
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门ID
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态号
objUsersENT.RoleId = objUsersENS.RoleId; //角色ID
objUsersENT.QXDJ = objUsersENS.QXDJ; //权限等级
objUsersENT.EffectiveDate = objUsersENS.EffectiveDate; //有效日期
objUsersENT.EffitiveBeginDate = objUsersENS.EffitiveBeginDate; //有效开始日期
objUsersENT.EffitiveEndDate = objUsersENS.EffitiveEndDate; //有效结束日期
objUsersENT.Password = objUsersENS.Password; //口令
objUsersENT.IdentityID = objUsersENS.IdentityID; //身份编号
objUsersENT.Email = objUsersENS.Email; //电子邮箱
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否平台用户
objUsersENT.RegisterPassword = objUsersENS.RegisterPassword; //注册密码
objUsersENT.IsRegister = objUsersENS.IsRegister; //是否注册
objUsersENT.RegisterDate = objUsersENS.RegisterDate; //注册日期
objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
objUsersENT.AuditUser = objUsersENS.AuditUser; //审核人
objUsersENT.AuditDate = objUsersENS.AuditDate; //审核日期
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改者
objUsersENT.Memo = objUsersENS.Memo; //说明
objUsersENT.sf_UpdFldSetStr = objUsersENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objUsersENS">源对象</param>
 /// <param name = "objUsersENT">目标对象</param>
clsUsersBL.CopyObjToSimObj = function(objUsersENS , objUsersENT ) 
{
objUsersENT.UserId = objUsersENS.UserId; //用户Id
objUsersENT.UserName = objUsersENS.UserName; //用户名
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门ID
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态号
objUsersENT.RoleId = objUsersENS.RoleId; //角色ID
objUsersENT.QXDJ = objUsersENS.QXDJ; //权限等级
objUsersENT.EffectiveDate = objUsersENS.EffectiveDate; //有效日期
objUsersENT.EffitiveBeginDate = objUsersENS.EffitiveBeginDate; //有效开始日期
objUsersENT.EffitiveEndDate = objUsersENS.EffitiveEndDate; //有效结束日期
objUsersENT.Password = objUsersENS.Password; //口令
objUsersENT.IdentityID = objUsersENS.IdentityID; //身份编号
objUsersENT.Email = objUsersENS.Email; //电子邮箱
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否平台用户
objUsersENT.RegisterPassword = objUsersENS.RegisterPassword; //注册密码
objUsersENT.IsRegister = objUsersENS.IsRegister; //是否注册
objUsersENT.RegisterDate = objUsersENS.RegisterDate; //注册日期
objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
objUsersENT.AuditUser = objUsersENS.AuditUser; //审核人
objUsersENT.AuditDate = objUsersENS.AuditDate; //审核日期
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改者
objUsersENT.Memo = objUsersENS.Memo; //说明
objUsersENT.sf_UpdFldSetStr = objUsersENS.UpdFldString; //专门用于记录某字段属性是否修改
objUsersENT.sf_FldComparisonOp = objUsersENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objUsersENS">源简化对象</param>
 /// <param name = "objUsersENT">目标对象</param>
clsUsersBL.CopyObjFromSimObj4Upd = function(objUsersENS, objUsersENT )
 {
   var strsf_UpdFldSetStr = objUsersENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsUsersEN.con_UserId)  >= 0)
{
objUsersENT.UserId = objUsersENS.UserId; //用户Id
}
if (sstrFldSet.indexOf(clsUsersEN.con_UserName)  >= 0)
{
objUsersENT.UserName = objUsersENS.UserName; //用户名
}
if (sstrFldSet.indexOf(clsUsersEN.con_DepartmentId)  >= 0)
{
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门ID
}
if (sstrFldSet.indexOf(clsUsersEN.con_UserStateId)  >= 0)
{
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态号
}
if (sstrFldSet.indexOf(clsUsersEN.con_RoleId)  >= 0)
{
objUsersENT.RoleId = objUsersENS.RoleId; //角色ID
}
if (sstrFldSet.indexOf(clsUsersEN.con_QXDJ)  >= 0)
{
objUsersENT.QXDJ = objUsersENS.QXDJ; //权限等级
}
if (sstrFldSet.indexOf(clsUsersEN.con_EffectiveDate)  >= 0)
{
objUsersENT.EffectiveDate = objUsersENS.EffectiveDate; //有效日期
}
if (sstrFldSet.indexOf(clsUsersEN.con_EffitiveBeginDate)  >= 0)
{
objUsersENT.EffitiveBeginDate = objUsersENS.EffitiveBeginDate; //有效开始日期
}
if (sstrFldSet.indexOf(clsUsersEN.con_EffitiveEndDate)  >= 0)
{
objUsersENT.EffitiveEndDate = objUsersENS.EffitiveEndDate; //有效结束日期
}
if (sstrFldSet.indexOf(clsUsersEN.con_Password)  >= 0)
{
objUsersENT.Password = objUsersENS.Password; //口令
}
if (sstrFldSet.indexOf(clsUsersEN.con_IdentityID)  >= 0)
{
objUsersENT.IdentityID = objUsersENS.IdentityID; //身份编号
}
if (sstrFldSet.indexOf(clsUsersEN.con_Email)  >= 0)
{
objUsersENT.Email = objUsersENS.Email; //电子邮箱
}
if (sstrFldSet.indexOf(clsUsersEN.con_IsGpUser)  >= 0)
{
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否平台用户
}
if (sstrFldSet.indexOf(clsUsersEN.con_RegisterPassword)  >= 0)
{
objUsersENT.RegisterPassword = objUsersENS.RegisterPassword; //注册密码
}
if (sstrFldSet.indexOf(clsUsersEN.con_IsRegister)  >= 0)
{
objUsersENT.IsRegister = objUsersENS.IsRegister; //是否注册
}
if (sstrFldSet.indexOf(clsUsersEN.con_RegisterDate)  >= 0)
{
objUsersENT.RegisterDate = objUsersENS.RegisterDate; //注册日期
}
if (sstrFldSet.indexOf(clsUsersEN.con_IsAudit)  >= 0)
{
objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
}
if (sstrFldSet.indexOf(clsUsersEN.con_AuditUser)  >= 0)
{
objUsersENT.AuditUser = objUsersENS.AuditUser; //审核人
}
if (sstrFldSet.indexOf(clsUsersEN.con_AuditDate)  >= 0)
{
objUsersENT.AuditDate = objUsersENS.AuditDate; //审核日期
}
if (sstrFldSet.indexOf(clsUsersEN.con_UpdDate)  >= 0)
{
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsUsersEN.con_UpdUser)  >= 0)
{
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsUsersEN.con_Memo)  >= 0)
{
objUsersENT.Memo = objUsersENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objUsersENS">源对象</param>
 /// <param name = "objUsersENT">目标对象</param>
clsUsersBL.GetSimObjFromObj = function(objUsersENS)
{
var objUsersENT = new clsUsersEN_Sim_js_1.clsUsersEN_Sim();
objUsersENT.UserId = objUsersENS.UserId; //用户Id
objUsersENT.UserName = objUsersENS.UserName; //用户名
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门ID
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态号
objUsersENT.RoleId = objUsersENS.RoleId; //角色ID
objUsersENT.QXDJ = objUsersENS.QXDJ; //权限等级
objUsersENT.EffectiveDate = objUsersENS.EffectiveDate; //有效日期
objUsersENT.EffitiveBeginDate = objUsersENS.EffitiveBeginDate; //有效开始日期
objUsersENT.EffitiveEndDate = objUsersENS.EffitiveEndDate; //有效结束日期
objUsersENT.Password = objUsersENS.Password; //口令
objUsersENT.IdentityID = objUsersENS.IdentityID; //身份编号
objUsersENT.Email = objUsersENS.Email; //电子邮箱
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否平台用户
objUsersENT.RegisterPassword = objUsersENS.RegisterPassword; //注册密码
objUsersENT.IsRegister = objUsersENS.IsRegister; //是否注册
objUsersENT.RegisterDate = objUsersENS.RegisterDate; //注册日期
objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
objUsersENT.AuditUser = objUsersENS.AuditUser; //审核人
objUsersENT.AuditDate = objUsersENS.AuditDate; //审核日期
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改者
objUsersENT.Memo = objUsersENS.Memo; //说明
objUsersENT.sf_UpdFldSetStr = objUsersENS.UpdFldString; //专门用于记录某字段属性是否修改
objUsersENT.sf_FldComparisonOp = objUsersENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objUsersENT;
}
return clsUsersBL;
}());
exports.clsUsersBL = clsUsersBL;
});