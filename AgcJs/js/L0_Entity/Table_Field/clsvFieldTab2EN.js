
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab2EN
 表名:vFieldTab2(00050120)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:05
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
 /// vFieldTab2(vFieldTab2)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvFieldTab2EN = /** @class */ (function (_super) {
__extends(clsvFieldTab2EN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvFieldTab2EN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 24;
_this.AttributeName = new Array("DataTypeName", "FldId", "PrjId", "PrjName", "FldName", "Caption", "FldLength", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsChecked", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "IsNeedTransCode", "AppliedScope", "CodeTabId", "CodeTab_NameId", "CodeTab_CodeId", "UpdDate", "UpdUser", "UserName");
_this.strDataTypeName = ""; //数据类型名称,
_this.strFldId = ""; //字段Id,
_this.strPrjId = ""; //工程ID,
_this.strPrjName = ""; //工程名称,
_this.strFldName = ""; //字段名,
_this.strCaption = ""; //标题,
_this.intFldLength = 0; //字段长度,
_this.strFldInfo = ""; //字段信息,
_this.bolIsNull = false; //是否可空,
_this.bolIsPrimaryKey = false; //是否主键,
_this.bolIsIdentity = false; //是否Identity,
_this.bolIsChecked = false; //是否核实,
_this.bolIsOnlyOne = false; //是否唯一,
_this.strMaxValue = ""; //最大值,
_this.strMinValue = ""; //最小值,
_this.strDefaultValue = ""; //缺省值,
_this.bolIsNeedTransCode = false; //是否需要转换代码,
_this.strAppliedScope = ""; //应用范围,
_this.strCodeTabId = ""; //CodeTabId,
_this.strCodeTab_NameId = ""; //CodeTab_NameId,
_this.strCodeTab_CodeId = ""; //CodeTab_CodeId,
_this.strUpdDate = ""; //修改日期,
_this.strUpdUser = ""; //修改者,
_this.strUserName = ""; //用户名,
  return _this;
 }

/// <summary>
/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "DataTypeName", {
 get: function ()
{
return this.mstrDataTypeName;
},
 set: function(value)
{
 this.mstrDataTypeName = value;
    this.hmProperty["DataTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "FldId", {
 get: function ()
{
return this.mstrFldId;
},
 set: function(value)
{
 this.mstrFldId = value;
    this.hmProperty["FldId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "PrjId", {
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
Object.defineProperty(clsvFieldTab2EN.prototype, "PrjName", {
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
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "FldName", {
 get: function ()
{
return this.mstrFldName;
},
 set: function(value)
{
 this.mstrFldName = value;
    this.hmProperty["FldName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "Caption", {
 get: function ()
{
return this.mstrCaption;
},
 set: function(value)
{
 this.mstrCaption = value;
    this.hmProperty["Caption"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "FldLength", {
 get: function ()
{
return this.mintFldLength;
},
 set: function(value)
{
 this.mintFldLength = value;
    this.hmProperty["FldLength"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段信息(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "FldInfo", {
 get: function ()
{
return this.mstrFldInfo;
},
 set: function(value)
{
 this.mstrFldInfo = value;
    this.hmProperty["FldInfo"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "IsNull", {
 get: function ()
{
return this.mbolIsNull;
},
 set: function(value)
{
 this.mbolIsNull = value;
    this.hmProperty["IsNull"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否主键(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "IsPrimaryKey", {
 get: function ()
{
return this.mbolIsPrimaryKey;
},
 set: function(value)
{
 this.mbolIsPrimaryKey = value;
    this.hmProperty["IsPrimaryKey"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否Identity(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "IsIdentity", {
 get: function ()
{
return this.mbolIsIdentity;
},
 set: function(value)
{
 this.mbolIsIdentity = value;
    this.hmProperty["IsIdentity"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "IsChecked", {
 get: function ()
{
return this.mbolIsChecked;
},
 set: function(value)
{
 this.mbolIsChecked = value;
    this.hmProperty["IsChecked"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "IsOnlyOne", {
 get: function ()
{
return this.mbolIsOnlyOne;
},
 set: function(value)
{
 this.mbolIsOnlyOne = value;
    this.hmProperty["IsOnlyOne"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 最大值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "MaxValue", {
 get: function ()
{
return this.mstrMaxValue;
},
 set: function(value)
{
 this.mstrMaxValue = value;
    this.hmProperty["MaxValue"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 最小值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "MinValue", {
 get: function ()
{
return this.mstrMinValue;
},
 set: function(value)
{
 this.mstrMinValue = value;
    this.hmProperty["MinValue"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "DefaultValue", {
 get: function ()
{
return this.mstrDefaultValue;
},
 set: function(value)
{
 this.mstrDefaultValue = value;
    this.hmProperty["DefaultValue"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "IsNeedTransCode", {
 get: function ()
{
return this.mbolIsNeedTransCode;
},
 set: function(value)
{
 this.mbolIsNeedTransCode = value;
    this.hmProperty["IsNeedTransCode"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用范围(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "AppliedScope", {
 get: function ()
{
return this.mstrAppliedScope;
},
 set: function(value)
{
 this.mstrAppliedScope = value;
    this.hmProperty["AppliedScope"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CodeTabId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "CodeTabId", {
 get: function ()
{
return this.mstrCodeTabId;
},
 set: function(value)
{
 this.mstrCodeTabId = value;
    this.hmProperty["CodeTabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CodeTab_NameId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "CodeTab_NameId", {
 get: function ()
{
return this.mstrCodeTab_NameId;
},
 set: function(value)
{
 this.mstrCodeTab_NameId = value;
    this.hmProperty["CodeTab_NameId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CodeTab_CodeId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "CodeTab_CodeId", {
 get: function ()
{
return this.mstrCodeTab_CodeId;
},
 set: function(value)
{
 this.mstrCodeTab_CodeId = value;
    this.hmProperty["CodeTab_CodeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "UpdDate", {
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
Object.defineProperty(clsvFieldTab2EN.prototype, "UpdUser", {
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
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTab2EN.prototype, "UserName", {
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
 /// 常量:"DataTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_DataTypeName", {
 get: function () {return "DataTypeName";}  // 数据类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_FldId", {
 get: function () {return "FldId";}  // 字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_PrjName", {
 get: function () {return "PrjName";}  // 工程名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_FldName", {
 get: function () {return "FldName";}  // 字段名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Caption"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_Caption", {
 get: function () {return "Caption";}  // 标题
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldLength"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_FldLength", {
 get: function () {return "FldLength";}  // 字段长度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldInfo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_FldInfo", {
 get: function () {return "FldInfo";}  // 字段信息
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNull"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_IsNull", {
 get: function () {return "IsNull";}  // 是否可空
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsPrimaryKey"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_IsPrimaryKey", {
 get: function () {return "IsPrimaryKey";}  // 是否主键
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsIdentity"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_IsIdentity", {
 get: function () {return "IsIdentity";}  // 是否Identity
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsChecked"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_IsChecked", {
 get: function () {return "IsChecked";}  // 是否核实
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsOnlyOne"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_IsOnlyOne", {
 get: function () {return "IsOnlyOne";}  // 是否唯一
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MaxValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_MaxValue", {
 get: function () {return "MaxValue";}  // 最大值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MinValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_MinValue", {
 get: function () {return "MinValue";}  // 最小值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DefaultValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_DefaultValue", {
 get: function () {return "DefaultValue";}  // 缺省值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_IsNeedTransCode", {
 get: function () {return "IsNeedTransCode";}  // 是否需要转换代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"AppliedScope"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_AppliedScope", {
 get: function () {return "AppliedScope";}  // 应用范围
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_CodeTabId", {
 get: function () {return "CodeTabId";}  // CodeTabId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTab_NameId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_CodeTab_NameId", {
 get: function () {return "CodeTab_NameId";}  // CodeTab_NameId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTab_CodeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_CodeTab_CodeId", {
 get: function () {return "CodeTab_CodeId";}  // CodeTab_CodeId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTab2EN, "con_UserName", {
 get: function () {return "UserName";}  // 用户名
,
    enumerable: true,
    configurable: true
});

clsvFieldTab2EN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvFieldTab2EN._CurrTabName = "vFieldTab2"; //当前表名,与该类相关的表名
clsvFieldTab2EN._KeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvFieldTab2EN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvFieldTab2EN = clsvFieldTab2EN;
});