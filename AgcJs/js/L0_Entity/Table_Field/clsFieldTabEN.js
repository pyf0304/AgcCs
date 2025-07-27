
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTabEN
 表名:FieldTab(00050021)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:03
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
 /// 工程字段(FieldTab)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsFieldTabEN = /** @class */ (function (_super) {
__extends(clsFieldTabEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsFieldTabEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 43;
_this.AttributeName = new Array("FldId", "PrjId", "FldName", "FldCnName", "FldEnName", "FldName_B", "FldName_G", "Caption", "FieldTypeId", "DataTypeId", "FldLength", "FldPrecision", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsNationStandard", "IsChecked", "IsArchive", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "IsNeedTransCode", "AppliedScope", "FldStateId", "CodeTabId", "CodeTab_NameId", "CodeTab_CodeId", "IsRootFld", "Root4TabId", "RootFldId", "RootTabId", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource", "UpdDate", "UpdUser", "Memo");
_this.strFldId = ""; //字段Id,
_this.strPrjId = ""; //工程ID,
_this.strFldName = ""; //字段名,
_this.strFldCnName = ""; //字段中文详名,
_this.strFldEnName = ""; //字段英文详名,
_this.strFldName_B = ""; //字段名_后备,
_this.strFldName_G = ""; //字段名_国标,
_this.strCaption = ""; //标题,
_this.strFieldTypeId = ""; //字段类型Id,
_this.strDataTypeId = ""; //数据类型Id,
_this.intFldLength = 0; //字段长度,
_this.intFldPrecision = 0; //精确度,
_this.strFldInfo = ""; //字段信息,
_this.bolIsNull = false; //是否可空,
_this.bolIsPrimaryKey = false; //是否主键,
_this.bolIsIdentity = false; //是否Identity,
_this.bolIsNationStandard = false; //是否国标,
_this.bolIsChecked = false; //是否核实,
_this.bolIsArchive = false; //是否存档,
_this.bolIsOnlyOne = false; //是否唯一,
_this.strMaxValue = ""; //最大值,
_this.strMinValue = ""; //最小值,
_this.strDefaultValue = ""; //缺省值,
_this.bolIsNeedTransCode = false; //是否需要转换代码,
_this.strAppliedScope = ""; //应用范围,
_this.strFldStateId = ""; //字段状态Id,
_this.strCodeTabId = ""; //CodeTabId,
_this.strCodeTab_NameId = ""; //CodeTab_NameId,
_this.strCodeTab_CodeId = ""; //CodeTab_CodeId,
_this.bolIsRootFld = false; //是否根字段,
_this.strRoot4TabId = ""; //主根表Id,
_this.strRootFldId = ""; //根字段Id,
_this.strRootTabId = ""; //根表Id,
_this.bolIsSynchToServer = false; //是否同步到Server,
_this.strSynchToServerDate = ""; //同步到Server日期,
_this.strSynchToServerUser = ""; //同步到Server用户,
_this.bolIsSynchToClient = false; //是否同步到Client,
_this.strSynchToClientDate = ""; //同步到Client库日期,
_this.strSynchToClientUser = ""; //同步到Client库用户,
_this.strSynSource = ""; //同步来源,
_this.strUpdDate = ""; //修改日期,
_this.strUpdUser = ""; //修改者,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldId", {
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
Object.defineProperty(clsFieldTabEN.prototype, "PrjId", {
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
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldName", {
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
/// 字段中文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldCnName", {
 get: function ()
{
return this.mstrFldCnName;
},
 set: function(value)
{
 this.mstrFldCnName = value;
    this.hmProperty["FldCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段英文详名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldEnName", {
 get: function ()
{
return this.mstrFldEnName;
},
 set: function(value)
{
 this.mstrFldEnName = value;
    this.hmProperty["FldEnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldName_B", {
 get: function ()
{
return this.mstrFldName_B;
},
 set: function(value)
{
 this.mstrFldName_B = value;
    this.hmProperty["FldName_B"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段名_国标(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldName_G", {
 get: function ()
{
return this.mstrFldName_G;
},
 set: function(value)
{
 this.mstrFldName_G = value;
    this.hmProperty["FldName_G"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "Caption", {
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
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FieldTypeId", {
 get: function ()
{
return this.mstrFieldTypeId;
},
 set: function(value)
{
 this.mstrFieldTypeId = value;
    this.hmProperty["FieldTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "DataTypeId", {
 get: function ()
{
return this.mstrDataTypeId;
},
 set: function(value)
{
 this.mstrDataTypeId = value;
    this.hmProperty["DataTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldLength", {
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
/// 精确度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldPrecision", {
 get: function ()
{
return this.mintFldPrecision;
},
 set: function(value)
{
 this.mintFldPrecision = value;
    this.hmProperty["FldPrecision"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段信息(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldInfo", {
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
Object.defineProperty(clsFieldTabEN.prototype, "IsNull", {
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
Object.defineProperty(clsFieldTabEN.prototype, "IsPrimaryKey", {
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
Object.defineProperty(clsFieldTabEN.prototype, "IsIdentity", {
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
/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "IsNationStandard", {
 get: function ()
{
return this.mbolIsNationStandard;
},
 set: function(value)
{
 this.mbolIsNationStandard = value;
    this.hmProperty["IsNationStandard"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "IsChecked", {
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
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "IsArchive", {
 get: function ()
{
return this.mbolIsArchive;
},
 set: function(value)
{
 this.mbolIsArchive = value;
    this.hmProperty["IsArchive"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否唯一(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "IsOnlyOne", {
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
Object.defineProperty(clsFieldTabEN.prototype, "MaxValue", {
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
Object.defineProperty(clsFieldTabEN.prototype, "MinValue", {
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
Object.defineProperty(clsFieldTabEN.prototype, "DefaultValue", {
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
Object.defineProperty(clsFieldTabEN.prototype, "IsNeedTransCode", {
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
Object.defineProperty(clsFieldTabEN.prototype, "AppliedScope", {
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
/// 字段状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "FldStateId", {
 get: function ()
{
return this.mstrFldStateId;
},
 set: function(value)
{
 this.mstrFldStateId = value;
    this.hmProperty["FldStateId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CodeTabId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "CodeTabId", {
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
Object.defineProperty(clsFieldTabEN.prototype, "CodeTab_NameId", {
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
Object.defineProperty(clsFieldTabEN.prototype, "CodeTab_CodeId", {
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
/// 是否根字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "IsRootFld", {
 get: function ()
{
return this.mbolIsRootFld;
},
 set: function(value)
{
 this.mbolIsRootFld = value;
    this.hmProperty["IsRootFld"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 主根表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "Root4TabId", {
 get: function ()
{
return this.mstrRoot4TabId;
},
 set: function(value)
{
 this.mstrRoot4TabId = value;
    this.hmProperty["Root4TabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 根字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "RootFldId", {
 get: function ()
{
return this.mstrRootFldId;
},
 set: function(value)
{
 this.mstrRootFldId = value;
    this.hmProperty["RootFldId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 根表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "RootTabId", {
 get: function ()
{
return this.mstrRootTabId;
},
 set: function(value)
{
 this.mstrRootTabId = value;
    this.hmProperty["RootTabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否同步到Server(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "IsSynchToServer", {
 get: function ()
{
return this.mbolIsSynchToServer;
},
 set: function(value)
{
 this.mbolIsSynchToServer = value;
    this.hmProperty["IsSynchToServer"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步到Server日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "SynchToServerDate", {
 get: function ()
{
return this.mstrSynchToServerDate;
},
 set: function(value)
{
 this.mstrSynchToServerDate = value;
    this.hmProperty["SynchToServerDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步到Server用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "SynchToServerUser", {
 get: function ()
{
return this.mstrSynchToServerUser;
},
 set: function(value)
{
 this.mstrSynchToServerUser = value;
    this.hmProperty["SynchToServerUser"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否同步到Client(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "IsSynchToClient", {
 get: function ()
{
return this.mbolIsSynchToClient;
},
 set: function(value)
{
 this.mbolIsSynchToClient = value;
    this.hmProperty["IsSynchToClient"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步到Client库日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "SynchToClientDate", {
 get: function ()
{
return this.mstrSynchToClientDate;
},
 set: function(value)
{
 this.mstrSynchToClientDate = value;
    this.hmProperty["SynchToClientDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步到Client库用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "SynchToClientUser", {
 get: function ()
{
return this.mstrSynchToClientUser;
},
 set: function(value)
{
 this.mstrSynchToClientUser = value;
    this.hmProperty["SynchToClientUser"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 同步来源(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "SynSource", {
 get: function ()
{
return this.mstrSynSource;
},
 set: function(value)
{
 this.mstrSynSource = value;
    this.hmProperty["SynSource"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsFieldTabEN.prototype, "UpdDate", {
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
Object.defineProperty(clsFieldTabEN.prototype, "UpdUser", {
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
Object.defineProperty(clsFieldTabEN.prototype, "Memo", {
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
 /// 常量:"FldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldId", {
 get: function () {return "FldId";}  // 字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldName", {
 get: function () {return "FldName";}  // 字段名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldCnName", {
 get: function () {return "FldCnName";}  // 字段中文详名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldEnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldEnName", {
 get: function () {return "FldEnName";}  // 字段英文详名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName_B"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldName_B", {
 get: function () {return "FldName_B";}  // 字段名_后备
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName_G"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldName_G", {
 get: function () {return "FldName_G";}  // 字段名_国标
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Caption"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_Caption", {
 get: function () {return "Caption";}  // 标题
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FieldTypeId", {
 get: function () {return "FieldTypeId";}  // 字段类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_DataTypeId", {
 get: function () {return "DataTypeId";}  // 数据类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldLength"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldLength", {
 get: function () {return "FldLength";}  // 字段长度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldPrecision"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldPrecision", {
 get: function () {return "FldPrecision";}  // 精确度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldInfo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldInfo", {
 get: function () {return "FldInfo";}  // 字段信息
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNull"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsNull", {
 get: function () {return "IsNull";}  // 是否可空
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsPrimaryKey"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsPrimaryKey", {
 get: function () {return "IsPrimaryKey";}  // 是否主键
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsIdentity"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsIdentity", {
 get: function () {return "IsIdentity";}  // 是否Identity
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNationStandard"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsNationStandard", {
 get: function () {return "IsNationStandard";}  // 是否国标
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsChecked"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsChecked", {
 get: function () {return "IsChecked";}  // 是否核实
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsArchive"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsArchive", {
 get: function () {return "IsArchive";}  // 是否存档
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsOnlyOne"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsOnlyOne", {
 get: function () {return "IsOnlyOne";}  // 是否唯一
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MaxValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_MaxValue", {
 get: function () {return "MaxValue";}  // 最大值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MinValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_MinValue", {
 get: function () {return "MinValue";}  // 最小值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DefaultValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_DefaultValue", {
 get: function () {return "DefaultValue";}  // 缺省值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsNeedTransCode", {
 get: function () {return "IsNeedTransCode";}  // 是否需要转换代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"AppliedScope"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_AppliedScope", {
 get: function () {return "AppliedScope";}  // 应用范围
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_FldStateId", {
 get: function () {return "FldStateId";}  // 字段状态Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_CodeTabId", {
 get: function () {return "CodeTabId";}  // CodeTabId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTab_NameId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_CodeTab_NameId", {
 get: function () {return "CodeTab_NameId";}  // CodeTab_NameId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTab_CodeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_CodeTab_CodeId", {
 get: function () {return "CodeTab_CodeId";}  // CodeTab_CodeId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsRootFld"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsRootFld", {
 get: function () {return "IsRootFld";}  // 是否根字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Root4TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_Root4TabId", {
 get: function () {return "Root4TabId";}  // 主根表Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RootFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_RootFldId", {
 get: function () {return "RootFldId";}  // 根字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RootTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_RootTabId", {
 get: function () {return "RootTabId";}  // 根表Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToServer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsSynchToServer", {
 get: function () {return "IsSynchToServer";}  // 是否同步到Server
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_SynchToServerDate", {
 get: function () {return "SynchToServerDate";}  // 同步到Server日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_SynchToServerUser", {
 get: function () {return "SynchToServerUser";}  // 同步到Server用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToClient"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_IsSynchToClient", {
 get: function () {return "IsSynchToClient";}  // 是否同步到Client
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_SynchToClientDate", {
 get: function () {return "SynchToClientDate";}  // 同步到Client库日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_SynchToClientUser", {
 get: function () {return "SynchToClientUser";}  // 同步到Client库用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynSource"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_SynSource", {
 get: function () {return "SynSource";}  // 同步来源
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsFieldTabEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsFieldTabEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsFieldTabEN._CurrTabName = "FieldTab"; //当前表名,与该类相关的表名
clsFieldTabEN._KeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsFieldTabEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsFieldTabEN = clsFieldTabEN;
});