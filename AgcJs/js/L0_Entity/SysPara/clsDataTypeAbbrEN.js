
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataTypeAbbrEN
 表名:DataTypeAbbr(00050023)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:33
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
 /// 数据类型(DataTypeAbbr)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsDataTypeAbbrEN = /** @class */ (function (_super) {
__extends(clsDataTypeAbbrEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsDataTypeAbbrEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 20;
_this.AttributeName = new Array("DataTypeId", "DataTypeName", "DataTypeENName", "DataCnName", "DataTypeAbbr", "NetSysType", "VBNETType", "CSType", "JavaType", "TypeScriptType", "JavaObjType", "SwiftType", "IsNeedQuote", "OraDbType", "IsReturnType", "SqlParaType", "MySqlType", "DefaFldLength", "DefaFldPrecision", "Memo");
_this.strDataTypeId = ""; //数据类型Id,
_this.strDataTypeName = ""; //数据类型名称,
_this.strDataTypeENName = ""; //DataTypeENName,
_this.strDataCnName = ""; //数据类型中文名称,
_this.strDataTypeAbbr = ""; //数据类型缩写,
_this.strNetSysType = ""; //NET系统类型,
_this.strVBNETType = ""; //VBNET类型,
_this.strCSType = ""; //CS类型,
_this.strJavaType = ""; //JAVA类型,
_this.strTypeScriptType = ""; //TypeScript类型,
_this.strJavaObjType = ""; //JAVA对象类型,
_this.strSwiftType = ""; //SwiftType,
_this.bolIsNeedQuote = false; //是否需要引号,
_this.strOraDbType = ""; //Ora数据类型,
_this.bolIsReturnType = false; //是否可作返回类型,
_this.strSqlParaType = ""; //SQL参数类型,
_this.strMySqlType = ""; //MySqlType,
_this.intDefaFldLength = 0; //默认长度,
_this.intDefaFldPrecision = 0; //默认小数位数,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "DataTypeId", {
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
Object.defineProperty(clsDataTypeAbbrEN.prototype, "DataTypeName", {
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
/// DataTypeENName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "DataTypeENName", {
 get: function ()
{
return this.mstrDataTypeENName;
},
 set: function(value)
{
 this.mstrDataTypeENName = value;
    this.hmProperty["DataTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据类型中文名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "DataCnName", {
 get: function ()
{
return this.mstrDataCnName;
},
 set: function(value)
{
 this.mstrDataCnName = value;
    this.hmProperty["DataCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据类型缩写(说明:;字段类型:varchar;字段长度:5;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "DataTypeAbbr", {
 get: function ()
{
return this.mstrDataTypeAbbr;
},
 set: function(value)
{
 this.mstrDataTypeAbbr = value;
    this.hmProperty["DataTypeAbbr"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// NET系统类型(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "NetSysType", {
 get: function ()
{
return this.mstrNetSysType;
},
 set: function(value)
{
 this.mstrNetSysType = value;
    this.hmProperty["NetSysType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// VBNET类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "VBNETType", {
 get: function ()
{
return this.mstrVBNETType;
},
 set: function(value)
{
 this.mstrVBNETType = value;
    this.hmProperty["VBNETType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CS类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "CSType", {
 get: function ()
{
return this.mstrCSType;
},
 set: function(value)
{
 this.mstrCSType = value;
    this.hmProperty["CSType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// JAVA类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "JavaType", {
 get: function ()
{
return this.mstrJavaType;
},
 set: function(value)
{
 this.mstrJavaType = value;
    this.hmProperty["JavaType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// TypeScript类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "TypeScriptType", {
 get: function ()
{
return this.mstrTypeScriptType;
},
 set: function(value)
{
 this.mstrTypeScriptType = value;
    this.hmProperty["TypeScriptType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// JAVA对象类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "JavaObjType", {
 get: function ()
{
return this.mstrJavaObjType;
},
 set: function(value)
{
 this.mstrJavaObjType = value;
    this.hmProperty["JavaObjType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// SwiftType(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "SwiftType", {
 get: function ()
{
return this.mstrSwiftType;
},
 set: function(value)
{
 this.mstrSwiftType = value;
    this.hmProperty["SwiftType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要引号(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "IsNeedQuote", {
 get: function ()
{
return this.mbolIsNeedQuote;
},
 set: function(value)
{
 this.mbolIsNeedQuote = value;
    this.hmProperty["IsNeedQuote"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// Ora数据类型(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "OraDbType", {
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
/// 是否可作返回类型(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "IsReturnType", {
 get: function ()
{
return this.mbolIsReturnType;
},
 set: function(value)
{
 this.mbolIsReturnType = value;
    this.hmProperty["IsReturnType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// SQL参数类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "SqlParaType", {
 get: function ()
{
return this.mstrSqlParaType;
},
 set: function(value)
{
 this.mstrSqlParaType = value;
    this.hmProperty["SqlParaType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// MySqlType(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "MySqlType", {
 get: function ()
{
return this.mstrMySqlType;
},
 set: function(value)
{
 this.mstrMySqlType = value;
    this.hmProperty["MySqlType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 默认长度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "DefaFldLength", {
 get: function ()
{
return this.mintDefaFldLength;
},
 set: function(value)
{
 this.mintDefaFldLength = value;
    this.hmProperty["DefaFldLength"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 默认小数位数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "DefaFldPrecision", {
 get: function ()
{
return this.mintDefaFldPrecision;
},
 set: function(value)
{
 this.mintDefaFldPrecision = value;
    this.hmProperty["DefaFldPrecision"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDataTypeAbbrEN.prototype, "Memo", {
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
 /// 常量:"DataTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_DataTypeId", {
 get: function () {return "DataTypeId";}  // 数据类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_DataTypeName", {
 get: function () {return "DataTypeName";}  // 数据类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_DataTypeENName", {
 get: function () {return "DataTypeENName";}  // DataTypeENName
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_DataCnName", {
 get: function () {return "DataCnName";}  // 数据类型中文名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeAbbr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_DataTypeAbbr", {
 get: function () {return "DataTypeAbbr";}  // 数据类型缩写
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"NetSysType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_NetSysType", {
 get: function () {return "NetSysType";}  // NET系统类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"VBNETType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_VBNETType", {
 get: function () {return "VBNETType";}  // VBNET类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CSType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_CSType", {
 get: function () {return "CSType";}  // CS类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"JavaType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_JavaType", {
 get: function () {return "JavaType";}  // JAVA类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TypeScriptType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_TypeScriptType", {
 get: function () {return "TypeScriptType";}  // TypeScript类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"JavaObjType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_JavaObjType", {
 get: function () {return "JavaObjType";}  // JAVA对象类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SwiftType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_SwiftType", {
 get: function () {return "SwiftType";}  // SwiftType
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedQuote"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_IsNeedQuote", {
 get: function () {return "IsNeedQuote";}  // 是否需要引号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OraDbType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_OraDbType", {
 get: function () {return "OraDbType";}  // Ora数据类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsReturnType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_IsReturnType", {
 get: function () {return "IsReturnType";}  // 是否可作返回类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SqlParaType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_SqlParaType", {
 get: function () {return "SqlParaType";}  // SQL参数类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MySqlType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_MySqlType", {
 get: function () {return "MySqlType";}  // MySqlType
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DefaFldLength"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_DefaFldLength", {
 get: function () {return "DefaFldLength";}  // 默认长度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DefaFldPrecision"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_DefaFldPrecision", {
 get: function () {return "DefaFldPrecision";}  // 默认小数位数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDataTypeAbbrEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsDataTypeAbbrEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsDataTypeAbbrEN._CurrTabName = "DataTypeAbbr"; //当前表名,与该类相关的表名
clsDataTypeAbbrEN._KeyFldName = "DataTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsDataTypeAbbrEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsDataTypeAbbrEN = clsDataTypeAbbrEN;
});