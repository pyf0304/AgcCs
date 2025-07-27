
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTypeCodeTabEN
 表名:ViewTypeCodeTab(00050104)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:44
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
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
 /// 界面类型码(ViewTypeCodeTab)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsViewTypeCodeTabEN = /** @class */ (function (_super) {
__extends(clsViewTypeCodeTabEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsViewTypeCodeTabEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 23;
_this.AttributeName = new Array("ViewTypeCode", "ViewTypeName", "ViewTypeENName", "IsWinApp", "IsMobileApp", "IsWebApp", "ViewFunction", "OptProcess", "ViewDetail", "ApplicationTypeId", "IsHaveAdd", "IsHaveUpdate", "IsHaveDel", "IsHaveQuery", "IsHaveExcelExport", "IsHaveSetExportExcel", "IsHaveDetail", "IsHaveExeAdd", "IsHaveExeUpdate", "IsHaveMainView", "IsHaveSubView", "OrderNum", "IsUsed");
_this.intViewTypeCode = 0; //界面类型码,
_this.strViewTypeName = ""; //界面类型名称,
_this.strViewTypeENName = ""; //ViewTypeENName,
_this.bolIsWinApp = false; //IsWinApp,
_this.bolIsMobileApp = false; //是否移动终端应用,
_this.bolIsWebApp = false; //IsWebApp,
_this.strViewFunction = ""; //界面功能,
_this.strOptProcess = ""; //操作流程,
_this.strViewDetail = ""; //界面说明,
_this.intApplicationTypeId = 0; //应用程序类型ID,
_this.bolIsHaveAdd = false; //是否有添加,
_this.bolIsHaveUpdate = false; //是否有修改,
_this.bolIsHaveDel = false; //是否有删除,
_this.bolIsHaveQuery = false; //是否有查询,
_this.bolIsHaveExcelExport = false; //是否EXCEL导出,
_this.bolIsHaveSetExportExcel = false; //是否有设置EXCEL导出,
_this.bolIsHaveDetail = false; //是否有详细,
_this.bolIsHaveExeAdd = false; //是否有调用添加,
_this.bolIsHaveExeUpdate = false; //是否有调用修改,
_this.bolIsHaveMainView = false; //是否有主界面,
_this.bolIsHaveSubView = false; //是否有子界面,
_this.intOrderNum = 0; //序号,
_this.bolIsUsed = false; //IsUsed,
  return _this;
 }

/// <summary>
/// 界面类型码(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "ViewTypeCode", {
 get: function ()
{
return this.mintViewTypeCode;
},
 set: function(value)
{
 this.mintViewTypeCode = value;
    this.hmProperty["ViewTypeCode"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 界面类型名称(说明:;字段类型:varchar;字段长度:40;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "ViewTypeName", {
 get: function ()
{
return this.mstrViewTypeName;
},
 set: function(value)
{
 this.mstrViewTypeName = value;
    this.hmProperty["ViewTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// ViewTypeENName(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "ViewTypeENName", {
 get: function ()
{
return this.mstrViewTypeENName;
},
 set: function(value)
{
 this.mstrViewTypeENName = value;
    this.hmProperty["ViewTypeENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// IsWinApp(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsWinApp", {
 get: function ()
{
return this.mbolIsWinApp;
},
 set: function(value)
{
 this.mbolIsWinApp = value;
    this.hmProperty["IsWinApp"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否移动终端应用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsMobileApp", {
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
/// IsWebApp(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsWebApp", {
 get: function ()
{
return this.mbolIsWebApp;
},
 set: function(value)
{
 this.mbolIsWebApp = value;
    this.hmProperty["IsWebApp"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "ViewFunction", {
 get: function ()
{
return this.mstrViewFunction;
},
 set: function(value)
{
 this.mstrViewFunction = value;
    this.hmProperty["ViewFunction"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 操作流程(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "OptProcess", {
 get: function ()
{
return this.mstrOptProcess;
},
 set: function(value)
{
 this.mstrOptProcess = value;
    this.hmProperty["OptProcess"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 界面说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "ViewDetail", {
 get: function ()
{
return this.mstrViewDetail;
},
 set: function(value)
{
 this.mstrViewDetail = value;
    this.hmProperty["ViewDetail"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "ApplicationTypeId", {
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
/// 是否有添加(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveAdd", {
 get: function ()
{
return this.mbolIsHaveAdd;
},
 set: function(value)
{
 this.mbolIsHaveAdd = value;
    this.hmProperty["IsHaveAdd"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否有修改(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveUpdate", {
 get: function ()
{
return this.mbolIsHaveUpdate;
},
 set: function(value)
{
 this.mbolIsHaveUpdate = value;
    this.hmProperty["IsHaveUpdate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否有删除(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveDel", {
 get: function ()
{
return this.mbolIsHaveDel;
},
 set: function(value)
{
 this.mbolIsHaveDel = value;
    this.hmProperty["IsHaveDel"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否有查询(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveQuery", {
 get: function ()
{
return this.mbolIsHaveQuery;
},
 set: function(value)
{
 this.mbolIsHaveQuery = value;
    this.hmProperty["IsHaveQuery"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否EXCEL导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveExcelExport", {
 get: function ()
{
return this.mbolIsHaveExcelExport;
},
 set: function(value)
{
 this.mbolIsHaveExcelExport = value;
    this.hmProperty["IsHaveExcelExport"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否有设置EXCEL导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveSetExportExcel", {
 get: function ()
{
return this.mbolIsHaveSetExportExcel;
},
 set: function(value)
{
 this.mbolIsHaveSetExportExcel = value;
    this.hmProperty["IsHaveSetExportExcel"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否有详细(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveDetail", {
 get: function ()
{
return this.mbolIsHaveDetail;
},
 set: function(value)
{
 this.mbolIsHaveDetail = value;
    this.hmProperty["IsHaveDetail"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否有调用添加(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveExeAdd", {
 get: function ()
{
return this.mbolIsHaveExeAdd;
},
 set: function(value)
{
 this.mbolIsHaveExeAdd = value;
    this.hmProperty["IsHaveExeAdd"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否有调用修改(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveExeUpdate", {
 get: function ()
{
return this.mbolIsHaveExeUpdate;
},
 set: function(value)
{
 this.mbolIsHaveExeUpdate = value;
    this.hmProperty["IsHaveExeUpdate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否有主界面(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveMainView", {
 get: function ()
{
return this.mbolIsHaveMainView;
},
 set: function(value)
{
 this.mbolIsHaveMainView = value;
    this.hmProperty["IsHaveMainView"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否有子界面(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsHaveSubView", {
 get: function ()
{
return this.mbolIsHaveSubView;
},
 set: function(value)
{
 this.mbolIsHaveSubView = value;
    this.hmProperty["IsHaveSubView"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "OrderNum", {
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
/// IsUsed(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewTypeCodeTabEN.prototype, "IsUsed", {
 get: function ()
{
return this.mbolIsUsed;
},
 set: function(value)
{
 this.mbolIsUsed = value;
    this.hmProperty["IsUsed"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"ViewTypeCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_ViewTypeCode", {
 get: function () {return "ViewTypeCode";}  // 界面类型码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_ViewTypeName", {
 get: function () {return "ViewTypeName";}  // 界面类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewTypeENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_ViewTypeENName", {
 get: function () {return "ViewTypeENName";}  // ViewTypeENName
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsWinApp"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsWinApp", {
 get: function () {return "IsWinApp";}  // IsWinApp
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsMobileApp"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsMobileApp", {
 get: function () {return "IsMobileApp";}  // 是否移动终端应用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsWebApp"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsWebApp", {
 get: function () {return "IsWebApp";}  // IsWebApp
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewFunction"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_ViewFunction", {
 get: function () {return "ViewFunction";}  // 界面功能
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OptProcess"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_OptProcess", {
 get: function () {return "OptProcess";}  // 操作流程
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewDetail"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_ViewDetail", {
 get: function () {return "ViewDetail";}  // 界面说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_ApplicationTypeId", {
 get: function () {return "ApplicationTypeId";}  // 应用程序类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveAdd"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveAdd", {
 get: function () {return "IsHaveAdd";}  // 是否有添加
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveUpdate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveUpdate", {
 get: function () {return "IsHaveUpdate";}  // 是否有修改
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveDel"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveDel", {
 get: function () {return "IsHaveDel";}  // 是否有删除
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveQuery"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveQuery", {
 get: function () {return "IsHaveQuery";}  // 是否有查询
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveExcelExport"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveExcelExport", {
 get: function () {return "IsHaveExcelExport";}  // 是否EXCEL导出
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveSetExportExcel"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveSetExportExcel", {
 get: function () {return "IsHaveSetExportExcel";}  // 是否有设置EXCEL导出
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveDetail"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveDetail", {
 get: function () {return "IsHaveDetail";}  // 是否有详细
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveExeAdd"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveExeAdd", {
 get: function () {return "IsHaveExeAdd";}  // 是否有调用添加
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveExeUpdate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveExeUpdate", {
 get: function () {return "IsHaveExeUpdate";}  // 是否有调用修改
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveMainView"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveMainView", {
 get: function () {return "IsHaveMainView";}  // 是否有主界面
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsHaveSubView"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsHaveSubView", {
 get: function () {return "IsHaveSubView";}  // 是否有子界面
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OrderNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_OrderNum", {
 get: function () {return "OrderNum";}  // 序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsUsed"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewTypeCodeTabEN, "con_IsUsed", {
 get: function () {return "IsUsed";}  // IsUsed
,
    enumerable: true,
    configurable: true
});

clsViewTypeCodeTabEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsViewTypeCodeTabEN._CurrTabName = "ViewTypeCodeTab"; //当前表名,与该类相关的表名
clsViewTypeCodeTabEN._KeyFldName = "ViewTypeCode"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsViewTypeCodeTabEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsViewTypeCodeTabEN = clsViewTypeCodeTabEN;
});