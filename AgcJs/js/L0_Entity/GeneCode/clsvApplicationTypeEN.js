
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvApplicationTypeEN
 表名:vApplicationType(00050403)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:02
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:生成代码
 模块英文名:GeneCode
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
 /// v应用程序类型(vApplicationType)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvApplicationTypeEN = /** @class */ (function (_super) {
__extends(clsvApplicationTypeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvApplicationTypeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 29;
_this.AttributeName = new Array("ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeSimName", "ApplicationTypeENName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeENName", "CharEncodingId", "CharEncodingName", "ProgLangTypeId2", "ProgLangTypeId3", "ProgLangTypeId4", "ProgLangTypeId5", "IsVisible", "OrderNum", "Memo", "CharEncodingId2", "CharEncodingId3", "CharEncodingName2", "CharEncodingName3", "ProgLangTypeName2", "ProgLangTypeName3", "ProgLangTypeName5", "CodeTypeCount", "CharEncodingId4", "CharEncodingName4", "ProgLangTypeName4", "CharEncodingId5", "CharEncodingName5");
_this.intApplicationTypeId = 0; //应用程序类型ID,
_this.strApplicationTypeName = ""; //应用程序类型名称,
_this.strApplicationTypeSimName = ""; //应用程序类型简称,
_this.strApplicationTypeENName = ""; //应用类型英文名,
_this.strProgLangTypeId = ""; //编程语言类型Id,
_this.strProgLangTypeName = ""; //编程语言类型名,
_this.strProgLangTypeENName = ""; //编程语言类型英文名,
_this.strCharEncodingId = ""; //字符编码,
_this.strCharEncodingName = ""; //字符编码名称,
_this.strProgLangTypeId2 = ""; //编程语言类型Id2,
_this.strProgLangTypeId3 = ""; //编程语言类型Id3,
_this.strProgLangTypeId4 = ""; //编程语言类型Id4,
_this.strProgLangTypeId5 = ""; //编程语言类型Id5,
_this.bolIsVisible = false; //是否显示,
_this.intOrderNum = 0; //序号,
_this.strMemo = ""; //说明,
_this.strCharEncodingId2 = ""; //CharEncodingId2,
_this.strCharEncodingId3 = ""; //CharEncodingId3,
_this.strCharEncodingName2 = ""; //CharEncodingName2,
_this.strCharEncodingName3 = ""; //CharEncodingName3,
_this.strProgLangTypeName2 = ""; //ProgLangTypeName2,
_this.strProgLangTypeName3 = ""; //ProgLangTypeName3,
_this.strProgLangTypeName5 = ""; //ProgLangTypeName5,
_this.intCodeTypeCount = 0; //代码类型数,
_this.strCharEncodingId4 = ""; //CharEncodingId4,
_this.strCharEncodingName4 = ""; //CharEncodingName4,
_this.strProgLangTypeName4 = ""; //ProgLangTypeName4,
_this.strCharEncodingId5 = ""; //CharEncodingId5,
_this.strCharEncodingName5 = ""; //CharEncodingName5,
  return _this;
 }

/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ApplicationTypeId", {
 get: function ()
{
return this.mintApplicationTypeId;
},
 set: function(value)
{
 this.mintApplicationTypeId = value;
    this.hmProperty["ApplicationTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ApplicationTypeName", {
 get: function ()
{
return this.mstrApplicationTypeName;
},
 set: function(value)
{
 this.mstrApplicationTypeName = value;
    this.hmProperty["ApplicationTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用程序类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ApplicationTypeSimName", {
 get: function ()
{
return this.mstrApplicationTypeSimName;
},
 set: function(value)
{
 this.mstrApplicationTypeSimName = value;
    this.hmProperty["ApplicationTypeSimName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ApplicationTypeENName", {
 get: function ()
{
return this.mstrApplicationTypeENName;
},
 set: function(value)
{
 this.mstrApplicationTypeENName = value;
    this.hmProperty["ApplicationTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeId", {
 get: function ()
{
return this.mstrProgLangTypeId;
},
 set: function(value)
{
 this.mstrProgLangTypeId = value;
    this.hmProperty["ProgLangTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeName", {
 get: function ()
{
return this.mstrProgLangTypeName;
},
 set: function(value)
{
 this.mstrProgLangTypeName = value;
    this.hmProperty["ProgLangTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeENName", {
 get: function ()
{
return this.mstrProgLangTypeENName;
},
 set: function(value)
{
 this.mstrProgLangTypeENName = value;
    this.hmProperty["ProgLangTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字符编码(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingId", {
 get: function ()
{
return this.mstrCharEncodingId;
},
 set: function(value)
{
 this.mstrCharEncodingId = value;
    this.hmProperty["CharEncodingId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字符编码名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingName", {
 get: function ()
{
return this.mstrCharEncodingName;
},
 set: function(value)
{
 this.mstrCharEncodingName = value;
    this.hmProperty["CharEncodingName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id2(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeId2", {
 get: function ()
{
return this.mstrProgLangTypeId2;
},
 set: function(value)
{
 this.mstrProgLangTypeId2 = value;
    this.hmProperty["ProgLangTypeId2"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id3(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeId3", {
 get: function ()
{
return this.mstrProgLangTypeId3;
},
 set: function(value)
{
 this.mstrProgLangTypeId3 = value;
    this.hmProperty["ProgLangTypeId3"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id4(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeId4", {
 get: function ()
{
return this.mstrProgLangTypeId4;
},
 set: function(value)
{
 this.mstrProgLangTypeId4 = value;
    this.hmProperty["ProgLangTypeId4"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id5(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeId5", {
 get: function ()
{
return this.mstrProgLangTypeId5;
},
 set: function(value)
{
 this.mstrProgLangTypeId5 = value;
    this.hmProperty["ProgLangTypeId5"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "IsVisible", {
 get: function ()
{
return this.mbolIsVisible;
},
 set: function(value)
{
 this.mbolIsVisible = value;
    this.hmProperty["IsVisible"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "OrderNum", {
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
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "Memo", {
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
/// CharEncodingId2(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingId2", {
 get: function ()
{
return this.mstrCharEncodingId2;
},
 set: function(value)
{
 this.mstrCharEncodingId2 = value;
    this.hmProperty["CharEncodingId2"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CharEncodingId3(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingId3", {
 get: function ()
{
return this.mstrCharEncodingId3;
},
 set: function(value)
{
 this.mstrCharEncodingId3 = value;
    this.hmProperty["CharEncodingId3"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CharEncodingName2(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingName2", {
 get: function ()
{
return this.mstrCharEncodingName2;
},
 set: function(value)
{
 this.mstrCharEncodingName2 = value;
    this.hmProperty["CharEncodingName2"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CharEncodingName3(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingName3", {
 get: function ()
{
return this.mstrCharEncodingName3;
},
 set: function(value)
{
 this.mstrCharEncodingName3 = value;
    this.hmProperty["CharEncodingName3"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ProgLangTypeName2(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeName2", {
 get: function ()
{
return this.mstrProgLangTypeName2;
},
 set: function(value)
{
 this.mstrProgLangTypeName2 = value;
    this.hmProperty["ProgLangTypeName2"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ProgLangTypeName3(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeName3", {
 get: function ()
{
return this.mstrProgLangTypeName3;
},
 set: function(value)
{
 this.mstrProgLangTypeName3 = value;
    this.hmProperty["ProgLangTypeName3"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ProgLangTypeName5(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeName5", {
 get: function ()
{
return this.mstrProgLangTypeName5;
},
 set: function(value)
{
 this.mstrProgLangTypeName5 = value;
    this.hmProperty["ProgLangTypeName5"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 代码类型数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CodeTypeCount", {
 get: function ()
{
return this.mintCodeTypeCount;
},
 set: function(value)
{
 this.mintCodeTypeCount = value;
    this.hmProperty["CodeTypeCount"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CharEncodingId4(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingId4", {
 get: function ()
{
return this.mstrCharEncodingId4;
},
 set: function(value)
{
 this.mstrCharEncodingId4 = value;
    this.hmProperty["CharEncodingId4"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CharEncodingName4(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingName4", {
 get: function ()
{
return this.mstrCharEncodingName4;
},
 set: function(value)
{
 this.mstrCharEncodingName4 = value;
    this.hmProperty["CharEncodingName4"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ProgLangTypeName4(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "ProgLangTypeName4", {
 get: function ()
{
return this.mstrProgLangTypeName4;
},
 set: function(value)
{
 this.mstrProgLangTypeName4 = value;
    this.hmProperty["ProgLangTypeName4"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CharEncodingId5(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingId5", {
 get: function ()
{
return this.mstrCharEncodingId5;
},
 set: function(value)
{
 this.mstrCharEncodingId5 = value;
    this.hmProperty["CharEncodingId5"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// CharEncodingName5(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvApplicationTypeEN.prototype, "CharEncodingName5", {
 get: function ()
{
return this.mstrCharEncodingName5;
},
 set: function(value)
{
 this.mstrCharEncodingName5 = value;
    this.hmProperty["CharEncodingName5"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ApplicationTypeId", {
 get: function () {return "ApplicationTypeId";}  // 应用程序类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ApplicationTypeName", {
 get: function () {return "ApplicationTypeName";}  // 应用程序类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeSimName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ApplicationTypeSimName", {
 get: function () {return "ApplicationTypeSimName";}  // 应用程序类型简称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ApplicationTypeENName", {
 get: function () {return "ApplicationTypeENName";}  // 应用类型英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeId", {
 get: function () {return "ProgLangTypeId";}  // 编程语言类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeName", {
 get: function () {return "ProgLangTypeName";}  // 编程语言类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeENName", {
 get: function () {return "ProgLangTypeENName";}  // 编程语言类型英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingId", {
 get: function () {return "CharEncodingId";}  // 字符编码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingName", {
 get: function () {return "CharEncodingName";}  // 字符编码名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId2"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeId2", {
 get: function () {return "ProgLangTypeId2";}  // 编程语言类型Id2
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId3"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeId3", {
 get: function () {return "ProgLangTypeId3";}  // 编程语言类型Id3
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId4"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeId4", {
 get: function () {return "ProgLangTypeId4";}  // 编程语言类型Id4
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId5"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeId5", {
 get: function () {return "ProgLangTypeId5";}  // 编程语言类型Id5
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsVisible"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_IsVisible", {
 get: function () {return "IsVisible";}  // 是否显示
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_OrderNum", {
 get: function () {return "OrderNum";}  // 序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingId2"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingId2", {
 get: function () {return "CharEncodingId2";}  // CharEncodingId2
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingId3"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingId3", {
 get: function () {return "CharEncodingId3";}  // CharEncodingId3
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingName2"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingName2", {
 get: function () {return "CharEncodingName2";}  // CharEncodingName2
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingName3"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingName3", {
 get: function () {return "CharEncodingName3";}  // CharEncodingName3
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeName2"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeName2", {
 get: function () {return "ProgLangTypeName2";}  // ProgLangTypeName2
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeName3"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeName3", {
 get: function () {return "ProgLangTypeName3";}  // ProgLangTypeName3
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeName5"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeName5", {
 get: function () {return "ProgLangTypeName5";}  // ProgLangTypeName5
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTypeCount"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CodeTypeCount", {
 get: function () {return "CodeTypeCount";}  // 代码类型数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingId4"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingId4", {
 get: function () {return "CharEncodingId4";}  // CharEncodingId4
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingName4"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingName4", {
 get: function () {return "CharEncodingName4";}  // CharEncodingName4
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeName4"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_ProgLangTypeName4", {
 get: function () {return "ProgLangTypeName4";}  // ProgLangTypeName4
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingId5"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingId5", {
 get: function () {return "CharEncodingId5";}  // CharEncodingId5
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CharEncodingName5"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvApplicationTypeEN, "con_CharEncodingName5", {
 get: function () {return "CharEncodingName5";}  // CharEncodingName5
,
    enumerable: true,
    configurable: true
});

clsvApplicationTypeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvApplicationTypeEN._CurrTabName = "vApplicationType"; //当前表名,与该类相关的表名
clsvApplicationTypeEN._KeyFldName = "ApplicationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvApplicationTypeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvApplicationTypeEN = clsvApplicationTypeEN;
});