
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4ErrMsgEN
 表名:vPrjTab4ErrMsg(00050206)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:11
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
 /// vPrjTab4ErrMsg(vPrjTab4ErrMsg)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvPrjTab4ErrMsgEN = /** @class */ (function (_super) {
__extends(clsvPrjTab4ErrMsgEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvPrjTab4ErrMsgEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 38;
_this.AttributeName = new Array("TabId", "FldNum", "TabName", "TabCnName", "PrjId", "PrjName", "IsNeedTransCode", "SQLDSTypeId", "SqlDsTypeName", "TabStateId", "TabStateName", "TabName_B", "IsParaTab", "IsNationStandard", "IsArchive", "IsChecked", "ErrMsg", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "Owner", "IsReleToSqlTab", "KeyWord", "TabTypeId", "TabTypeName", "RelaTabId4View", "OrderNum4Refer", "IsNeedGeneIndexer", "PrimaryTypeId", "PrimaryTypeName", "KeyFldId", "KeyFldName", "UpdUserId", "UpdDate", "Memo", "ErrMsg2", "RelaTabName4View", "DataBaseName_Tab");
_this.strTabId = ""; //表ID,
_this.intFldNum = 0; //字段数,
_this.strTabName = ""; //表名,
_this.strTabCnName = ""; //表中文名,
_this.strPrjId = ""; //工程ID,
_this.strPrjName = ""; //工程名称,
_this.bolIsNeedTransCode = false; //是否需要转换代码,
_this.strSQLDSTypeId = ""; //数据源类型,
_this.strSqlDsTypeName = ""; //Sql数据源名,
_this.strTabStateId = ""; //表状态ID,
_this.strTabStateName = ""; //表状态名称,
_this.strTabName_B = ""; //表名_后备,
_this.bolIsParaTab = false; //是否参数表,
_this.bolIsNationStandard = false; //是否国标,
_this.bolIsArchive = false; //是否存档,
_this.bolIsChecked = false; //是否核实,
_this.strErrMsg = ""; //错误信息,
_this.strFuncModuleAgcId = ""; //功能模块Id,
_this.strFuncModuleName = ""; //功能模块名称,
_this.strFuncModuleEnName = ""; //功能模块英文名称,
_this.strOwner = ""; //拥有者,
_this.bolIsReleToSqlTab = false; //是否与SQL表相关,
_this.strKeyWord = ""; //关键字,
_this.strTabTypeId = ""; //表类型Id,
_this.strTabTypeName = ""; //表类型名,
_this.strRelaTabId4View = ""; //视图的相关表ID,
_this.intOrderNum4Refer = 0; //引用序号,
_this.bolIsNeedGeneIndexer = false; //是否需要生成索引器,
_this.strPrimaryTypeId = ""; //主键类型ID,
_this.strPrimaryTypeName = ""; //主键类型名,
_this.strKeyFldId = ""; //关键字段Id,
_this.strKeyFldName = ""; //关键字段名,
_this.strUpdUserId = ""; //修改用户Id,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
_this.strErrMsg2 = ""; //ErrMsg2,
_this.strRelaTabName4View = ""; //RelaTabName4View,
_this.strDataBaseName_Tab = ""; //DataBaseName_Tab,
  return _this;
 }

/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "TabId", {
 get: function ()
{
return this.mstrTabId;
},
 set: function(value)
{
 this.mstrTabId = value;
    this.hmProperty["TabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "FldNum", {
 get: function ()
{
return this.mintFldNum;
},
 set: function(value)
{
 this.mintFldNum = value;
    this.hmProperty["FldNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "TabName", {
 get: function ()
{
return this.mstrTabName;
},
 set: function(value)
{
 this.mstrTabName = value;
    this.hmProperty["TabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "TabCnName", {
 get: function ()
{
return this.mstrTabCnName;
},
 set: function(value)
{
 this.mstrTabCnName = value;
    this.hmProperty["TabCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "PrjId", {
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
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "PrjName", {
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
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "IsNeedTransCode", {
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
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "SQLDSTypeId", {
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
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "SqlDsTypeName", {
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
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "TabStateId", {
 get: function ()
{
return this.mstrTabStateId;
},
 set: function(value)
{
 this.mstrTabStateId = value;
    this.hmProperty["TabStateId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "TabStateName", {
 get: function ()
{
return this.mstrTabStateName;
},
 set: function(value)
{
 this.mstrTabStateName = value;
    this.hmProperty["TabStateName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表名_后备(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "TabName_B", {
 get: function ()
{
return this.mstrTabName_B;
},
 set: function(value)
{
 this.mstrTabName_B = value;
    this.hmProperty["TabName_B"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "IsParaTab", {
 get: function ()
{
return this.mbolIsParaTab;
},
 set: function(value)
{
 this.mbolIsParaTab = value;
    this.hmProperty["IsParaTab"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否国标(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "IsNationStandard", {
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
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "IsArchive", {
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
/// 是否核实(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "IsChecked", {
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
/// 错误信息(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "ErrMsg", {
 get: function ()
{
return this.mstrErrMsg;
},
 set: function(value)
{
 this.mstrErrMsg = value;
    this.hmProperty["ErrMsg"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "FuncModuleAgcId", {
 get: function ()
{
return this.mstrFuncModuleAgcId;
},
 set: function(value)
{
 this.mstrFuncModuleAgcId = value;
    this.hmProperty["FuncModuleAgcId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "FuncModuleName", {
 get: function ()
{
return this.mstrFuncModuleName;
},
 set: function(value)
{
 this.mstrFuncModuleName = value;
    this.hmProperty["FuncModuleName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 功能模块英文名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "FuncModuleEnName", {
 get: function ()
{
return this.mstrFuncModuleEnName;
},
 set: function(value)
{
 this.mstrFuncModuleEnName = value;
    this.hmProperty["FuncModuleEnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "Owner", {
 get: function ()
{
return this.mstrOwner;
},
 set: function(value)
{
 this.mstrOwner = value;
    this.hmProperty["Owner"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否与SQL表相关(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "IsReleToSqlTab", {
 get: function ()
{
return this.mbolIsReleToSqlTab;
},
 set: function(value)
{
 this.mbolIsReleToSqlTab = value;
    this.hmProperty["IsReleToSqlTab"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "KeyWord", {
 get: function ()
{
return this.mstrKeyWord;
},
 set: function(value)
{
 this.mstrKeyWord = value;
    this.hmProperty["KeyWord"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "TabTypeId", {
 get: function ()
{
return this.mstrTabTypeId;
},
 set: function(value)
{
 this.mstrTabTypeId = value;
    this.hmProperty["TabTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "TabTypeName", {
 get: function ()
{
return this.mstrTabTypeName;
},
 set: function(value)
{
 this.mstrTabTypeName = value;
    this.hmProperty["TabTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 视图的相关表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "RelaTabId4View", {
 get: function ()
{
return this.mstrRelaTabId4View;
},
 set: function(value)
{
 this.mstrRelaTabId4View = value;
    this.hmProperty["RelaTabId4View"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "OrderNum4Refer", {
 get: function ()
{
return this.mintOrderNum4Refer;
},
 set: function(value)
{
 this.mintOrderNum4Refer = value;
    this.hmProperty["OrderNum4Refer"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要生成索引器(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "IsNeedGeneIndexer", {
 get: function ()
{
return this.mbolIsNeedGeneIndexer;
},
 set: function(value)
{
 this.mbolIsNeedGeneIndexer = value;
    this.hmProperty["IsNeedGeneIndexer"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "PrimaryTypeId", {
 get: function ()
{
return this.mstrPrimaryTypeId;
},
 set: function(value)
{
 this.mstrPrimaryTypeId = value;
    this.hmProperty["PrimaryTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "PrimaryTypeName", {
 get: function ()
{
return this.mstrPrimaryTypeName;
},
 set: function(value)
{
 this.mstrPrimaryTypeName = value;
    this.hmProperty["PrimaryTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 关键字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "KeyFldId", {
 get: function ()
{
return this.mstrKeyFldId;
},
 set: function(value)
{
 this.mstrKeyFldId = value;
    this.hmProperty["KeyFldId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 关键字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "KeyFldName", {
 get: function ()
{
return this.mstrKeyFldName;
},
 set: function(value)
{
 this.mstrKeyFldName = value;
    this.hmProperty["KeyFldName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "UpdUserId", {
 get: function ()
{
return this.mstrUpdUserId;
},
 set: function(value)
{
 this.mstrUpdUserId = value;
    this.hmProperty["UpdUserId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "UpdDate", {
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
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "Memo", {
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
/// ErrMsg2(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "ErrMsg2", {
 get: function ()
{
return this.mstrErrMsg2;
},
 set: function(value)
{
 this.mstrErrMsg2 = value;
    this.hmProperty["ErrMsg2"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// RelaTabName4View(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "RelaTabName4View", {
 get: function ()
{
return this.mstrRelaTabName4View;
},
 set: function(value)
{
 this.mstrRelaTabName4View = value;
    this.hmProperty["RelaTabName4View"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// DataBaseName_Tab(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN.prototype, "DataBaseName_Tab", {
 get: function ()
{
return this.mstrDataBaseName_Tab;
},
 set: function(value)
{
 this.mstrDataBaseName_Tab = value;
    this.hmProperty["DataBaseName_Tab"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_TabId", {
 get: function () {return "TabId";}  // 表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_FldNum", {
 get: function () {return "FldNum";}  // 字段数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_TabName", {
 get: function () {return "TabName";}  // 表名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_TabCnName", {
 get: function () {return "TabCnName";}  // 表中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_PrjName", {
 get: function () {return "PrjName";}  // 工程名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_IsNeedTransCode", {
 get: function () {return "IsNeedTransCode";}  // 是否需要转换代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_SQLDSTypeId", {
 get: function () {return "SQLDSTypeId";}  // 数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_SqlDsTypeName", {
 get: function () {return "SqlDsTypeName";}  // Sql数据源名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabStateId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_TabStateId", {
 get: function () {return "TabStateId";}  // 表状态ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabStateName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_TabStateName", {
 get: function () {return "TabStateName";}  // 表状态名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName_B"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_TabName_B", {
 get: function () {return "TabName_B";}  // 表名_后备
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsParaTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_IsParaTab", {
 get: function () {return "IsParaTab";}  // 是否参数表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNationStandard"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_IsNationStandard", {
 get: function () {return "IsNationStandard";}  // 是否国标
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsArchive"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_IsArchive", {
 get: function () {return "IsArchive";}  // 是否存档
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsChecked"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_IsChecked", {
 get: function () {return "IsChecked";}  // 是否核实
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ErrMsg"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_ErrMsg", {
 get: function () {return "ErrMsg";}  // 错误信息
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_FuncModuleAgcId", {
 get: function () {return "FuncModuleAgcId";}  // 功能模块Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_FuncModuleName", {
 get: function () {return "FuncModuleName";}  // 功能模块名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_FuncModuleEnName", {
 get: function () {return "FuncModuleEnName";}  // 功能模块英文名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Owner"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_Owner", {
 get: function () {return "Owner";}  // 拥有者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsReleToSqlTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_IsReleToSqlTab", {
 get: function () {return "IsReleToSqlTab";}  // 是否与SQL表相关
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyWord"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_KeyWord", {
 get: function () {return "KeyWord";}  // 关键字
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_TabTypeId", {
 get: function () {return "TabTypeId";}  // 表类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_TabTypeName", {
 get: function () {return "TabTypeName";}  // 表类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RelaTabId4View"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_RelaTabId4View", {
 get: function () {return "RelaTabId4View";}  // 视图的相关表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum4Refer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_OrderNum4Refer", {
 get: function () {return "OrderNum4Refer";}  // 引用序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedGeneIndexer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_IsNeedGeneIndexer", {
 get: function () {return "IsNeedGeneIndexer";}  // 是否需要生成索引器
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_PrimaryTypeId", {
 get: function () {return "PrimaryTypeId";}  // 主键类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_PrimaryTypeName", {
 get: function () {return "PrimaryTypeName";}  // 主键类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_KeyFldId", {
 get: function () {return "KeyFldId";}  // 关键字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyFldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_KeyFldName", {
 get: function () {return "KeyFldName";}  // 关键字段名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_UpdUserId", {
 get: function () {return "UpdUserId";}  // 修改用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ErrMsg2"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_ErrMsg2", {
 get: function () {return "ErrMsg2";}  // ErrMsg2
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RelaTabName4View"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_RelaTabName4View", {
 get: function () {return "RelaTabName4View";}  // RelaTabName4View
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataBaseName_Tab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvPrjTab4ErrMsgEN, "con_DataBaseName_Tab", {
 get: function () {return "DataBaseName_Tab";}  // DataBaseName_Tab
,
    enumerable: true,
    configurable: true
});

clsvPrjTab4ErrMsgEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvPrjTab4ErrMsgEN._CurrTabName = "vPrjTab4ErrMsg"; //当前表名,与该类相关的表名
clsvPrjTab4ErrMsgEN._KeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvPrjTab4ErrMsgEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvPrjTab4ErrMsgEN = clsvPrjTab4ErrMsgEN;
});