
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPrjGrantEN
 表名:vUserPrjGrant(00050174)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:15
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:权限管理
 模块英文名:AuthorityManage
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
 /// vUserPrjGrant(vUserPrjGrant)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvUserPrjGrantEN = /** @class */ (function (_super) {
__extends(clsvUserPrjGrantEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvUserPrjGrantEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 16;
_this.AttributeName = new Array("mId", "UserId", "UserName", "UserStateName", "DepartmentId", "DepartmentName", "PrjId", "PrjName", "RoleId", "RoleName", "VisitedNum", "LastVisitedDate", "OptId", "OptDate", "Memo", "UseStateId");
_this.lngmId = 0; //mId,
_this.strUserId = ""; //用户Id,
_this.strUserName = ""; //用户名,
_this.strUserStateName = ""; //用户状态名,
_this.strDepartmentId = ""; //部门ID,
_this.strDepartmentName = ""; //部门名称,
_this.strPrjId = ""; //工程ID,
_this.strPrjName = ""; //工程名称,
_this.strRoleId = ""; //角色ID,
_this.strRoleName = ""; //角色名称,
_this.intVisitedNum = 0; //访问数,
_this.strLastVisitedDate = ""; //最后访问时间,
_this.strOptId = ""; //操作者Id,
_this.strOptDate = ""; //操作日期,
_this.strMemo = ""; //说明,
_this.strUseStateId = ""; //使用状态Id,
  return _this;
 }

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "mId", {
 get: function ()
{
return this.mlngmId;
},
 set: function(value)
{
 this.mlngmId = value;
    this.hmProperty["mId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "UserId", {
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
Object.defineProperty(clsvUserPrjGrantEN.prototype, "UserName", {
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
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "UserStateName", {
 get: function ()
{
return this.mstrUserStateName;
},
 set: function(value)
{
 this.mstrUserStateName = value;
    this.hmProperty["UserStateName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "DepartmentId", {
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
/// 部门名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "DepartmentName", {
 get: function ()
{
return this.mstrDepartmentName;
},
 set: function(value)
{
 this.mstrDepartmentName = value;
    this.hmProperty["DepartmentName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "PrjId", {
 get: function ()
{
return this.mstrPrjId;
},
 set: function(value)
{
 this.mstrPrjId = value;
    this.hmProperty["PrjId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "PrjName", {
 get: function ()
{
return this.mstrPrjName;
},
 set: function(value)
{
 this.mstrPrjName = value;
    this.hmProperty["PrjName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 角色ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "RoleId", {
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
/// 角色名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "RoleName", {
 get: function ()
{
return this.mstrRoleName;
},
 set: function(value)
{
 this.mstrRoleName = value;
    this.hmProperty["RoleName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 访问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "VisitedNum", {
 get: function ()
{
return this.mintVisitedNum;
},
 set: function(value)
{
 this.mintVisitedNum = value;
    this.hmProperty["VisitedNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 最后访问时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "LastVisitedDate", {
 get: function ()
{
return this.mstrLastVisitedDate;
},
 set: function(value)
{
 this.mstrLastVisitedDate = value;
    this.hmProperty["LastVisitedDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 操作者Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "OptId", {
 get: function ()
{
return this.mstrOptId;
},
 set: function(value)
{
 this.mstrOptId = value;
    this.hmProperty["OptId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 操作日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "OptDate", {
 get: function ()
{
return this.mstrOptDate;
},
 set: function(value)
{
 this.mstrOptDate = value;
    this.hmProperty["OptDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "Memo", {
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
/// 使用状态Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvUserPrjGrantEN.prototype, "UseStateId", {
 get: function ()
{
return this.mstrUseStateId;
},
 set: function(value)
{
 this.mstrUseStateId = value;
    this.hmProperty["UseStateId"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"mId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_UserId", {
 get: function () {return "UserId";}  // 用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_UserName", {
 get: function () {return "UserName";}  // 用户名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserStateName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_UserStateName", {
 get: function () {return "UserStateName";}  // 用户状态名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DepartmentId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_DepartmentId", {
 get: function () {return "DepartmentId";}  // 部门ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DepartmentName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_DepartmentName", {
 get: function () {return "DepartmentName";}  // 部门名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_PrjName", {
 get: function () {return "PrjName";}  // 工程名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RoleId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_RoleId", {
 get: function () {return "RoleId";}  // 角色ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RoleName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_RoleName", {
 get: function () {return "RoleName";}  // 角色名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"VisitedNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_VisitedNum", {
 get: function () {return "VisitedNum";}  // 访问数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"LastVisitedDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_LastVisitedDate", {
 get: function () {return "LastVisitedDate";}  // 最后访问时间
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OptId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_OptId", {
 get: function () {return "OptId";}  // 操作者Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OptDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_OptDate", {
 get: function () {return "OptDate";}  // 操作日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UseStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvUserPrjGrantEN, "con_UseStateId", {
 get: function () {return "UseStateId";}  // 使用状态Id
,
    enumerable: true,
    configurable: true
});

clsvUserPrjGrantEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvUserPrjGrantEN._CurrTabName = "vUserPrjGrant"; //当前表名,与该类相关的表名
clsvUserPrjGrantEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvUserPrjGrantEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvUserPrjGrantEN = clsvUserPrjGrantEN;
});