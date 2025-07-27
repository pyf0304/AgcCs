
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeTypeEN
 表名:vCodeType(00050410)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:50:01
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
 /// v代码类型(vCodeType)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvCodeTypeEN = /** @class */ (function (_super) {
__extends(clsvCodeTypeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvCodeTypeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 40;
_this.AttributeName = new Array("CodeTypeId", "CodeTypeName", "CodeTypeSimName", "CodeTypeENName", "GroupName", "ProgLangTypeId", "ProgLangTypeName", "ProgLangTypeSimName", "RegionTypeId", "RegionTypeName", "Prefix", "DependsOn", "FrontOrBack", "SQLDSTypeId", "SqlDsTypeName", "ClassNameFormat", "IsCSharp", "IsJava", "IsJavaScript", "IsTypeScript", "IsSilverLight", "IsSwift", "IsVB", "IsTableFldConst", "IsPubApp4WinWeb", "IsWeb", "IsAspMvc", "IsWebSrvAccess", "IsWin", "IsMobileApp", "OrderNum", "WinOrWeb", "IsDirByTabName", "InUse", "IsDefaultOverride", "UpdDate", "UpdUser", "Memo", "FuncCount", "AppCount");
_this.strCodeTypeId = ""; //代码类型Id,
_this.strCodeTypeName = ""; //代码类型名,
_this.strCodeTypeSimName = ""; //简称,
_this.strCodeTypeENName = ""; //代码类型英文名,
_this.strGroupName = ""; //组名,
_this.strProgLangTypeId = ""; //编程语言类型Id,
_this.strProgLangTypeName = ""; //编程语言类型名,
_this.strProgLangTypeSimName = ""; //编程语言类型简称,
_this.strRegionTypeId = ""; //区域类型Id,
_this.strRegionTypeName = ""; //区域类型名称,
_this.strPrefix = ""; //前缀,
_this.strDependsOn = ""; //依赖于,
_this.strFrontOrBack = ""; //前台Or后台,
_this.strSQLDSTypeId = ""; //数据源类型,
_this.strSqlDsTypeName = ""; //Sql数据源名,
_this.strClassNameFormat = ""; //类名格式,
_this.bolIsCSharp = false; //是否CSharp语言,
_this.bolIsJava = false; //是否Java语言,
_this.bolIsJavaScript = false; //是否JavaScript语言,
_this.bolIsTypeScript = false; //是否TypeScript语言,
_this.bolIsSilverLight = false; //是否SilverLight语言,
_this.bolIsSwift = false; //是否Swift语言,
_this.bolIsVB = false; //IsVB语言,
_this.bolIsTableFldConst = false; //IsTableFldConst,
_this.bolIsPubApp4WinWeb = false; //IsPubApp4WinWeb,
_this.bolIsWeb = false; //是否Web应用,
_this.bolIsAspMvc = false; //是否AspMvc,
_this.bolIsWebSrvAccess = false; //IsWebSrvAccess,
_this.bolIsWin = false; //是否Win应用,
_this.bolIsMobileApp = false; //是否移动终端应用,
_this.intOrderNum = 0; //序号,
_this.strWinOrWeb = ""; //WinOrWeb,
_this.bolIsDirByTabName = false; //是否用表名作为路径,
_this.bolInUse = false; //是否在用,
_this.bolIsDefaultOverride = false; //是否默认覆盖,
_this.strUpdDate = ""; //修改日期,
_this.strUpdUser = ""; //修改者,
_this.strMemo = ""; //说明,
_this.intFuncCount = 0; //函数数目,
_this.intAppCount = 0; //应用数,
  return _this;
 }

/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "CodeTypeId", {
 get: function ()
{
return this.mstrCodeTypeId;
},
 set: function(value)
{
 this.mstrCodeTypeId = value;
    this.hmProperty["CodeTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "CodeTypeName", {
 get: function ()
{
return this.mstrCodeTypeName;
},
 set: function(value)
{
 this.mstrCodeTypeName = value;
    this.hmProperty["CodeTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 简称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "CodeTypeSimName", {
 get: function ()
{
return this.mstrCodeTypeSimName;
},
 set: function(value)
{
 this.mstrCodeTypeSimName = value;
    this.hmProperty["CodeTypeSimName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 代码类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "CodeTypeENName", {
 get: function ()
{
return this.mstrCodeTypeENName;
},
 set: function(value)
{
 this.mstrCodeTypeENName = value;
    this.hmProperty["CodeTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "GroupName", {
 get: function ()
{
return this.mstrGroupName;
},
 set: function(value)
{
 this.mstrGroupName = value;
    this.hmProperty["GroupName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "ProgLangTypeId", {
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
Object.defineProperty(clsvCodeTypeEN.prototype, "ProgLangTypeName", {
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
/// 编程语言类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "ProgLangTypeSimName", {
 get: function ()
{
return this.mstrProgLangTypeSimName;
},
 set: function(value)
{
 this.mstrProgLangTypeSimName = value;
    this.hmProperty["ProgLangTypeSimName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "RegionTypeId", {
 get: function ()
{
return this.mstrRegionTypeId;
},
 set: function(value)
{
 this.mstrRegionTypeId = value;
    this.hmProperty["RegionTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "RegionTypeName", {
 get: function ()
{
return this.mstrRegionTypeName;
},
 set: function(value)
{
 this.mstrRegionTypeName = value;
    this.hmProperty["RegionTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 前缀(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "Prefix", {
 get: function ()
{
return this.mstrPrefix;
},
 set: function(value)
{
 this.mstrPrefix = value;
    this.hmProperty["Prefix"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 依赖于(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "DependsOn", {
 get: function ()
{
return this.mstrDependsOn;
},
 set: function(value)
{
 this.mstrDependsOn = value;
    this.hmProperty["DependsOn"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 前台Or后台(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "FrontOrBack", {
 get: function ()
{
return this.mstrFrontOrBack;
},
 set: function(value)
{
 this.mstrFrontOrBack = value;
    this.hmProperty["FrontOrBack"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "SQLDSTypeId", {
 get: function ()
{
return this.mstrSQLDSTypeId;
},
 set: function(value)
{
 this.mstrSQLDSTypeId = value;
    this.hmProperty["SQLDSTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "SqlDsTypeName", {
 get: function ()
{
return this.mstrSqlDsTypeName;
},
 set: function(value)
{
 this.mstrSqlDsTypeName = value;
    this.hmProperty["SqlDsTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 类名格式(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "ClassNameFormat", {
 get: function ()
{
return this.mstrClassNameFormat;
},
 set: function(value)
{
 this.mstrClassNameFormat = value;
    this.hmProperty["ClassNameFormat"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否CSharp语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsCSharp", {
 get: function ()
{
return this.mbolIsCSharp;
},
 set: function(value)
{
 this.mbolIsCSharp = value;
    this.hmProperty["IsCSharp"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否Java语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsJava", {
 get: function ()
{
return this.mbolIsJava;
},
 set: function(value)
{
 this.mbolIsJava = value;
    this.hmProperty["IsJava"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否JavaScript语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsJavaScript", {
 get: function ()
{
return this.mbolIsJavaScript;
},
 set: function(value)
{
 this.mbolIsJavaScript = value;
    this.hmProperty["IsJavaScript"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否TypeScript语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsTypeScript", {
 get: function ()
{
return this.mbolIsTypeScript;
},
 set: function(value)
{
 this.mbolIsTypeScript = value;
    this.hmProperty["IsTypeScript"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否SilverLight语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsSilverLight", {
 get: function ()
{
return this.mbolIsSilverLight;
},
 set: function(value)
{
 this.mbolIsSilverLight = value;
    this.hmProperty["IsSilverLight"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否Swift语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsSwift", {
 get: function ()
{
return this.mbolIsSwift;
},
 set: function(value)
{
 this.mbolIsSwift = value;
    this.hmProperty["IsSwift"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// IsVB语言(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsVB", {
 get: function ()
{
return this.mbolIsVB;
},
 set: function(value)
{
 this.mbolIsVB = value;
    this.hmProperty["IsVB"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// IsTableFldConst(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsTableFldConst", {
 get: function ()
{
return this.mbolIsTableFldConst;
},
 set: function(value)
{
 this.mbolIsTableFldConst = value;
    this.hmProperty["IsTableFldConst"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// IsPubApp4WinWeb(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsPubApp4WinWeb", {
 get: function ()
{
return this.mbolIsPubApp4WinWeb;
},
 set: function(value)
{
 this.mbolIsPubApp4WinWeb = value;
    this.hmProperty["IsPubApp4WinWeb"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否Web应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsWeb", {
 get: function ()
{
return this.mbolIsWeb;
},
 set: function(value)
{
 this.mbolIsWeb = value;
    this.hmProperty["IsWeb"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否AspMvc(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsAspMvc", {
 get: function ()
{
return this.mbolIsAspMvc;
},
 set: function(value)
{
 this.mbolIsAspMvc = value;
    this.hmProperty["IsAspMvc"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// IsWebSrvAccess(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsWebSrvAccess", {
 get: function ()
{
return this.mbolIsWebSrvAccess;
},
 set: function(value)
{
 this.mbolIsWebSrvAccess = value;
    this.hmProperty["IsWebSrvAccess"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否Win应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsWin", {
 get: function ()
{
return this.mbolIsWin;
},
 set: function(value)
{
 this.mbolIsWin = value;
    this.hmProperty["IsWin"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否移动终端应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsMobileApp", {
 get: function ()
{
return this.mbolIsMobileApp;
},
 set: function(value)
{
 this.mbolIsMobileApp = value;
    this.hmProperty["IsMobileApp"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "OrderNum", {
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
/// WinOrWeb(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "WinOrWeb", {
 get: function ()
{
return this.mstrWinOrWeb;
},
 set: function(value)
{
 this.mstrWinOrWeb = value;
    this.hmProperty["WinOrWeb"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否用表名作为路径(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsDirByTabName", {
 get: function ()
{
return this.mbolIsDirByTabName;
},
 set: function(value)
{
 this.mbolIsDirByTabName = value;
    this.hmProperty["IsDirByTabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "InUse", {
 get: function ()
{
return this.mbolInUse;
},
 set: function(value)
{
 this.mbolInUse = value;
    this.hmProperty["InUse"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否默认覆盖(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "IsDefaultOverride", {
 get: function ()
{
return this.mbolIsDefaultOverride;
},
 set: function(value)
{
 this.mbolIsDefaultOverride = value;
    this.hmProperty["IsDefaultOverride"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "UpdDate", {
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
Object.defineProperty(clsvCodeTypeEN.prototype, "UpdUser", {
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
Object.defineProperty(clsvCodeTypeEN.prototype, "Memo", {
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
/// 函数数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "FuncCount", {
 get: function ()
{
return this.mintFuncCount;
},
 set: function(value)
{
 this.mintFuncCount = value;
    this.hmProperty["FuncCount"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvCodeTypeEN.prototype, "AppCount", {
 get: function ()
{
return this.mintAppCount;
},
 set: function(value)
{
 this.mintAppCount = value;
    this.hmProperty["AppCount"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_CodeTypeId", {
 get: function () {return "CodeTypeId";}  // 代码类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_CodeTypeName", {
 get: function () {return "CodeTypeName";}  // 代码类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTypeSimName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_CodeTypeSimName", {
 get: function () {return "CodeTypeSimName";}  // 简称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CodeTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_CodeTypeENName", {
 get: function () {return "CodeTypeENName";}  // 代码类型英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"GroupName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_GroupName", {
 get: function () {return "GroupName";}  // 组名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_ProgLangTypeId", {
 get: function () {return "ProgLangTypeId";}  // 编程语言类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_ProgLangTypeName", {
 get: function () {return "ProgLangTypeName";}  // 编程语言类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ProgLangTypeSimName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_ProgLangTypeSimName", {
 get: function () {return "ProgLangTypeSimName";}  // 编程语言类型简称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_RegionTypeId", {
 get: function () {return "RegionTypeId";}  // 区域类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_RegionTypeName", {
 get: function () {return "RegionTypeName";}  // 区域类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Prefix"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_Prefix", {
 get: function () {return "Prefix";}  // 前缀
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DependsOn"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_DependsOn", {
 get: function () {return "DependsOn";}  // 依赖于
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FrontOrBack"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_FrontOrBack", {
 get: function () {return "FrontOrBack";}  // 前台Or后台
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_SQLDSTypeId", {
 get: function () {return "SQLDSTypeId";}  // 数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_SqlDsTypeName", {
 get: function () {return "SqlDsTypeName";}  // Sql数据源名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ClassNameFormat"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_ClassNameFormat", {
 get: function () {return "ClassNameFormat";}  // 类名格式
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsCSharp"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsCSharp", {
 get: function () {return "IsCSharp";}  // 是否CSharp语言
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsJava"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsJava", {
 get: function () {return "IsJava";}  // 是否Java语言
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsJavaScript"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsJavaScript", {
 get: function () {return "IsJavaScript";}  // 是否JavaScript语言
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsTypeScript"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsTypeScript", {
 get: function () {return "IsTypeScript";}  // 是否TypeScript语言
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSilverLight"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsSilverLight", {
 get: function () {return "IsSilverLight";}  // 是否SilverLight语言
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSwift"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsSwift", {
 get: function () {return "IsSwift";}  // 是否Swift语言
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsVB"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsVB", {
 get: function () {return "IsVB";}  // IsVB语言
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsTableFldConst"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsTableFldConst", {
 get: function () {return "IsTableFldConst";}  // IsTableFldConst
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsPubApp4WinWeb"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsPubApp4WinWeb", {
 get: function () {return "IsPubApp4WinWeb";}  // IsPubApp4WinWeb
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsWeb"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsWeb", {
 get: function () {return "IsWeb";}  // 是否Web应用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsAspMvc"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsAspMvc", {
 get: function () {return "IsAspMvc";}  // 是否AspMvc
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsWebSrvAccess"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsWebSrvAccess", {
 get: function () {return "IsWebSrvAccess";}  // IsWebSrvAccess
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsWin"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsWin", {
 get: function () {return "IsWin";}  // 是否Win应用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsMobileApp"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsMobileApp", {
 get: function () {return "IsMobileApp";}  // 是否移动终端应用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_OrderNum", {
 get: function () {return "OrderNum";}  // 序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"WinOrWeb"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_WinOrWeb", {
 get: function () {return "WinOrWeb";}  // WinOrWeb
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsDirByTabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsDirByTabName", {
 get: function () {return "IsDirByTabName";}  // 是否用表名作为路径
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"InUse"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_InUse", {
 get: function () {return "InUse";}  // 是否在用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsDefaultOverride"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_IsDefaultOverride", {
 get: function () {return "IsDefaultOverride";}  // 是否默认覆盖
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncCount"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_FuncCount", {
 get: function () {return "FuncCount";}  // 函数数目
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"AppCount"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvCodeTypeEN, "con_AppCount", {
 get: function () {return "AppCount";}  // 应用数
,
    enumerable: true,
    configurable: true
});

clsvCodeTypeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvCodeTypeEN._CurrTabName = "vCodeType"; //当前表名,与该类相关的表名
clsvCodeTypeEN._KeyFldName = "CodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvCodeTypeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvCodeTypeEN = clsvCodeTypeEN;
});