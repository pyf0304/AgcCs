
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTabEN
 表名:vFieldTab(00050119)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:04
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
 /// v工程字段(vFieldTab)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvFieldTabEN = /** @class */ (function (_super) {
__extends(clsvFieldTabEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvFieldTabEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 44;
_this.AttributeName = new Array("FldId", "TabNum", "PrjId", "PrjName", "FldName", "FldCnName", "FldEnName", "FldName_B", "FldName_G", "Caption", "FieldTypeId", "FieldTypeName", "FieldTypeENName", "DataTypeId", "DataTypeName", "OraDbType", "FldLength", "FldPrecision", "FldInfo", "IsNull", "IsPrimaryKey", "IsIdentity", "IsNationStandard", "IsChecked", "IsArchive", "IsOnlyOne", "MaxValue", "MinValue", "DefaultValue", "IsNeedTransCode", "AppliedScope", "FldStateId", "CodeTabId", "CodeTab_NameId", "CodeTab_CodeId", "IsRootFld", "RootFldId", "UpdDate", "UpdUser", "Memo", "CodeTab", "CodeTab_Name", "CodeTab_Code", "FldBName_B");
_this.strFldId = ""; //字段Id,
_this.intTabNum = 0; //TabNum,
_this.strPrjId = ""; //工程ID,
_this.strPrjName = ""; //工程名称,
_this.strFldName = ""; //字段名,
_this.strFldCnName = ""; //字段中文详名,
_this.strFldEnName = ""; //字段英文详名,
_this.strFldName_B = ""; //字段名_后备,
_this.strFldName_G = ""; //字段名_国标,
_this.strCaption = ""; //标题,
_this.strFieldTypeId = ""; //字段类型Id,
_this.strFieldTypeName = ""; //字段类型名,
_this.strFieldTypeENName = ""; //字段类型英文名,
_this.strDataTypeId = ""; //数据类型Id,
_this.strDataTypeName = ""; //数据类型名称,
_this.strOraDbType = ""; //Ora数据类型,
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
_this.strRootFldId = ""; //根字段Id,
_this.strUpdDate = ""; //修改日期,
_this.strUpdUser = ""; //修改者,
_this.strMemo = ""; //说明,
_this.strCodeTab = ""; //代码表,
_this.strCodeTab_Name = ""; //代码表_名称,
_this.strCodeTab_Code = ""; //代码表_代码,
_this.strFldBName_B = ""; //FldBName_B,
  return _this;
 }

/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "FldId", {
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
/// TabNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "TabNum", {
 get: function ()
{
return this.mintTabNum;
},
 set: function(value)
{
 this.mintTabNum = value;
    this.hmProperty["TabNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "PrjId", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "PrjName", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "FldName", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "FldCnName", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "FldEnName", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "FldName_B", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "FldName_G", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "Caption", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "FieldTypeId", {
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
/// 字段类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "FieldTypeName", {
 get: function ()
{
return this.mstrFieldTypeName;
},
 set: function(value)
{
 this.mstrFieldTypeName = value;
    this.hmProperty["FieldTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "FieldTypeENName", {
 get: function ()
{
return this.mstrFieldTypeENName;
},
 set: function(value)
{
 this.mstrFieldTypeENName = value;
    this.hmProperty["FieldTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "DataTypeId", {
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
/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "DataTypeName", {
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
/// Ora数据类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "OraDbType", {
 get: function ()
{
return this.mstrOraDbType;
},
 set: function(value)
{
 this.mstrOraDbType = value;
    this.hmProperty["OraDbType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "FldLength", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "FldPrecision", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "FldInfo", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "IsNull", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "IsPrimaryKey", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "IsIdentity", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "IsNationStandard", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "IsChecked", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "IsArchive", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "IsOnlyOne", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "MaxValue", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "MinValue", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "DefaultValue", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "IsNeedTransCode", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "AppliedScope", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "FldStateId", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "CodeTabId", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "CodeTab_NameId", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "CodeTab_CodeId", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "IsRootFld", {
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
/// 根字段Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "RootFldId", {
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
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "UpdDate", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "UpdUser", {
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
Object.defineProperty(clsvFieldTabEN.prototype, "Memo", {
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
/// 代码表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "CodeTab", {
 get: function ()
{
return this.mstrCodeTab;
},
 set: function(value)
{
 this.mstrCodeTab = value;
    this.hmProperty["CodeTab"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 代码表_名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "CodeTab_Name", {
 get: function ()
{
return this.mstrCodeTab_Name;
},
 set: function(value)
{
 this.mstrCodeTab_Name = value;
    this.hmProperty["CodeTab_Name"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 代码表_代码(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "CodeTab_Code", {
 get: function ()
{
return this.mstrCodeTab_Code;
},
 set: function(value)
{
 this.mstrCodeTab_Code = value;
    this.hmProperty["CodeTab_Code"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// FldBName_B(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvFieldTabEN.prototype, "FldBName_B", {
 get: function ()
{
return this.mstrFldBName_B;
},
 set: function(value)
{
 this.mstrFldBName_B = value;
    this.hmProperty["FldBName_B"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"FldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldId", {
 get: function () {return "FldId";}  // 字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_TabNum", {
 get: function () {return "TabNum";}  // TabNum
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_PrjName", {
 get: function () {return "PrjName";}  // 工程名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldName", {
 get: function () {return "FldName";}  // 字段名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldCnName", {
 get: function () {return "FldCnName";}  // 字段中文详名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldEnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldEnName", {
 get: function () {return "FldEnName";}  // 字段英文详名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName_B"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldName_B", {
 get: function () {return "FldName_B";}  // 字段名_后备
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName_G"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldName_G", {
 get: function () {return "FldName_G";}  // 字段名_国标
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Caption"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_Caption", {
 get: function () {return "Caption";}  // 标题
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FieldTypeId", {
 get: function () {return "FieldTypeId";}  // 字段类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FieldTypeName", {
 get: function () {return "FieldTypeName";}  // 字段类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FieldTypeENName", {
 get: function () {return "FieldTypeENName";}  // 字段类型英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_DataTypeId", {
 get: function () {return "DataTypeId";}  // 数据类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_DataTypeName", {
 get: function () {return "DataTypeName";}  // 数据类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OraDbType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_OraDbType", {
 get: function () {return "OraDbType";}  // Ora数据类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldLength"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldLength", {
 get: function () {return "FldLength";}  // 字段长度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldPrecision"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldPrecision", {
 get: function () {return "FldPrecision";}  // 精确度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldInfo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldInfo", {
 get: function () {return "FldInfo";}  // 字段信息
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNull"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_IsNull", {
 get: function () {return "IsNull";}  // 是否可空
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsPrimaryKey"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_IsPrimaryKey", {
 get: function () {return "IsPrimaryKey";}  // 是否主键
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsIdentity"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_IsIdentity", {
 get: function () {return "IsIdentity";}  // 是否Identity
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNationStandard"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_IsNationStandard", {
 get: function () {return "IsNationStandard";}  // 是否国标
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsChecked"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_IsChecked", {
 get: function () {return "IsChecked";}  // 是否核实
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsArchive"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_IsArchive", {
 get: function () {return "IsArchive";}  // 是否存档
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsOnlyOne"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_IsOnlyOne", {
 get: function () {return "IsOnlyOne";}  // 是否唯一
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MaxValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_MaxValue", {
 get: function () {return "MaxValue";}  // 最大值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MinValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_MinValue", {
 get: function () {return "MinValue";}  // 最小值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DefaultValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_DefaultValue", {
 get: function () {return "DefaultValue";}  // 缺省值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_IsNeedTransCode", {
 get: function () {return "IsNeedTransCode";}  // 是否需要转换代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"AppliedScope"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_AppliedScope", {
 get: function () {return "AppliedScope";}  // 应用范围
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldStateId", {
 get: function () {return "FldStateId";}  // 字段状态Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_CodeTabId", {
 get: function () {return "CodeTabId";}  // CodeTabId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTab_NameId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_CodeTab_NameId", {
 get: function () {return "CodeTab_NameId";}  // CodeTab_NameId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTab_CodeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_CodeTab_CodeId", {
 get: function () {return "CodeTab_CodeId";}  // CodeTab_CodeId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsRootFld"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_IsRootFld", {
 get: function () {return "IsRootFld";}  // 是否根字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RootFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_RootFldId", {
 get: function () {return "RootFldId";}  // 根字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_CodeTab", {
 get: function () {return "CodeTab";}  // 代码表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTab_Name"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_CodeTab_Name", {
 get: function () {return "CodeTab_Name";}  // 代码表_名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTab_Code"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_CodeTab_Code", {
 get: function () {return "CodeTab_Code";}  // 代码表_代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldBName_B"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvFieldTabEN, "con_FldBName_B", {
 get: function () {return "FldBName_B";}  // FldBName_B
,
    enumerable: true,
    configurable: true
});

clsvFieldTabEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvFieldTabEN._CurrTabName = "vFieldTab"; //当前表名,与该类相关的表名
clsvFieldTabEN._KeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvFieldTabEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvFieldTabEN = clsvFieldTabEN;
});