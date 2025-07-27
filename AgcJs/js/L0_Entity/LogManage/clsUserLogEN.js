
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserLogEN
 表名:UserLog(00050130)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:10
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:日志管理
 模块英文名:LogManage
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
 /// 用户日志(UserLog)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsUserLogEN = /** @class */ (function (_super) {
__extends(clsUserLogEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsUserLogEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 12;
_this.AttributeName = new Array("mId", "UserId", "LoginTime", "LoginDate", "UserIp", "ObjectTable", "UsedValue", "UpdDate", "Memo", "_IsDeleted", "OrderNum", "_DeletedDate");
_this.lngmId = 0; //mId,
_this.strUserId = ""; //用户Id,
_this.strLoginTime = ""; //登陆时间,
_this.strLoginDate = ""; //登陆日期,
_this.strUserIp = ""; //用户IP,
_this.strObjectTable = ""; //对象表,
_this.strUsedValue = ""; //使用值,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
_this.bol_IsDeleted = false; //是否删除,
_this.intOrderNum = 0; //序号,
_this.str_DeletedDate = ""; //删除日期,
  return _this;
 }

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "mId", {
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
Object.defineProperty(clsUserLogEN.prototype, "UserId", {
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
/// 登陆时间(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "LoginTime", {
 get: function ()
{
return this.mstrLoginTime;
},
 set: function(value)
{
 this.mstrLoginTime = value;
    this.hmProperty["LoginTime"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 登陆日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "LoginDate", {
 get: function ()
{
return this.mstrLoginDate;
},
 set: function(value)
{
 this.mstrLoginDate = value;
    this.hmProperty["LoginDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 用户IP(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "UserIp", {
 get: function ()
{
return this.mstrUserIp;
},
 set: function(value)
{
 this.mstrUserIp = value;
    this.hmProperty["UserIp"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 对象表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "ObjectTable", {
 get: function ()
{
return this.mstrObjectTable;
},
 set: function(value)
{
 this.mstrObjectTable = value;
    this.hmProperty["ObjectTable"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 使用值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "UsedValue", {
 get: function ()
{
return this.mstrUsedValue;
},
 set: function(value)
{
 this.mstrUsedValue = value;
    this.hmProperty["UsedValue"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "UpdDate", {
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
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "Memo", {
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
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "_IsDeleted", {
 get: function ()
{
return this.mbol_IsDeleted;
},
 set: function(value)
{
 this.mbol_IsDeleted = value;
    this.hmProperty["_IsDeleted"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "OrderNum", {
 get: function ()
{
return this.mintOrderNum;
},
 set: function(value)
{
 this.mintOrderNum = value;
    this.hmProperty["OrderNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsUserLogEN.prototype, "_DeletedDate", {
 get: function ()
{
return this.mstr_DeletedDate;
},
 set: function(value)
{
 this.mstr_DeletedDate = value;
    this.hmProperty["_DeletedDate"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"mId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_UserId", {
 get: function () {return "UserId";}  // 用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"LoginTime"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_LoginTime", {
 get: function () {return "LoginTime";}  // 登陆时间
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"LoginDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_LoginDate", {
 get: function () {return "LoginDate";}  // 登陆日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserIp"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_UserIp", {
 get: function () {return "UserIp";}  // 用户IP
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ObjectTable"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_ObjectTable", {
 get: function () {return "ObjectTable";}  // 对象表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UsedValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_UsedValue", {
 get: function () {return "UsedValue";}  // 使用值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"_IsDeleted"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con__IsDeleted", {
 get: function () {return "_IsDeleted";}  // 是否删除
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con_OrderNum", {
 get: function () {return "OrderNum";}  // 序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"_DeletedDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsUserLogEN, "con__DeletedDate", {
 get: function () {return "_DeletedDate";}  // 删除日期
,
    enumerable: true,
    configurable: true
});

clsUserLogEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsUserLogEN._CurrTabName = "UserLog"; //当前表名,与该类相关的表名
clsUserLogEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsUserLogEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsUserLogEN = clsUserLogEN;
});