
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfo4GeneCodeEN
 表名:vViewInfo4GeneCode(00050283)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 00:34:44
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
 /// vViewInfo4GeneCode(vViewInfo4GeneCode)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvViewInfo4GeneCodeEN = /** @class */ (function (_super) {
__extends(clsvViewInfo4GeneCodeEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvViewInfo4GeneCodeEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 42;
_this.AttributeName = new Array("ViewId", "TitleStyleId", "TitleStyleName", "DGStyleId", "DGStyleName", "Version_GeneCode", "ViewName", "ViewTypeCode", "ViewTypeName", "ApplicationTypeId", "ApplicationTypeName", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "DataBaseName", "KeyForMainTab", "KeyForDetailTab", "IsNeedSort", "IsNeedTransCode", "UserId", "PrjId", "PrjName", "ViewFunction", "ViewDetail", "DefaMenuName", "DetailTabId", "FileName", "FilePath", "MainTabId", "ViewCnName", "ViewGroupId", "ViewGroupName", "INSQLDSTypeId", "OUTSQLDSTypeId", "GeneCodeDate", "RegionNum", "UpdDate", "MainTabName", "DetailTabName", "MainTabKeyFld", "DetailTabKeyFld", "UserId4GeneCode");
_this.strViewId = ""; //界面Id,
_this.strTitleStyleId = ""; //标题类型Id,
_this.strTitleStyleName = ""; //标题类型名,
_this.strDGStyleId = ""; //DG模式ID,
_this.strDGStyleName = ""; //DG模式名,
_this.strVersion_GeneCode = ""; //生成代码版本,
_this.strViewName = ""; //界面名称,
_this.intViewTypeCode = 0; //界面类型码,
_this.strViewTypeName = ""; //界面类型名称,
_this.intApplicationTypeId = 0; //应用程序类型ID,
_this.strApplicationTypeName = ""; //应用程序类型名称,
_this.strFuncModuleAgcId = ""; //功能模块Id,
_this.strFuncModuleName = ""; //功能模块名称,
_this.strFuncModuleEnName = ""; //功能模块英文名称,
_this.strDataBaseName = ""; //数据库名,
_this.strKeyForMainTab = ""; //主表关键字,
_this.strKeyForDetailTab = ""; //明细表关键字,
_this.bolIsNeedSort = false; //是否需要排序,
_this.bolIsNeedTransCode = false; //是否需要转换代码,
_this.strUserId = ""; //用户Id,
_this.strPrjId = ""; //工程ID,
_this.strPrjName = ""; //工程名称,
_this.strViewFunction = ""; //界面功能,
_this.strViewDetail = ""; //界面说明,
_this.strDefaMenuName = ""; //缺省菜单名,
_this.strDetailTabId = ""; //明细表ID,
_this.strFileName = ""; //文件名,
_this.strFilePath = ""; //文件路径,
_this.strMainTabId = ""; //主表ID,
_this.strViewCnName = ""; //视图中文名,
_this.strViewGroupId = ""; //界面组ID,
_this.strViewGroupName = ""; //界面组名称,
_this.strINSQLDSTypeId = ""; //输入数据源类型,
_this.strOUTSQLDSTypeId = ""; //输出数据源类型,
_this.strGeneCodeDate = ""; //生成代码日期,
_this.intRegionNum = 0; //区域数,
_this.strUpdDate = ""; //修改日期,
_this.strMainTabName = ""; //主表,
_this.strDetailTabName = ""; //详细表,
_this.strMainTabKeyFld = ""; //MainTabKeyFld,
_this.strDetailTabKeyFld = ""; //DetailTabKeyFld,
_this.strUserId4GeneCode = ""; //UserId4GeneCode,
  return _this;
 }

/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ViewId", {
 get: function ()
{
return this.mstrViewId;
},
 set: function(value)
{
 this.mstrViewId = value;
    this.hmProperty["ViewId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 标题类型Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "TitleStyleId", {
 get: function ()
{
return this.mstrTitleStyleId;
},
 set: function(value)
{
 this.mstrTitleStyleId = value;
    this.hmProperty["TitleStyleId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 标题类型名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "TitleStyleName", {
 get: function ()
{
return this.mstrTitleStyleName;
},
 set: function(value)
{
 this.mstrTitleStyleName = value;
    this.hmProperty["TitleStyleName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// DG模式ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "DGStyleId", {
 get: function ()
{
return this.mstrDGStyleId;
},
 set: function(value)
{
 this.mstrDGStyleId = value;
    this.hmProperty["DGStyleId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// DG模式名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "DGStyleName", {
 get: function ()
{
return this.mstrDGStyleName;
},
 set: function(value)
{
 this.mstrDGStyleName = value;
    this.hmProperty["DGStyleName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 生成代码版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "Version_GeneCode", {
 get: function ()
{
return this.mstrVersion_GeneCode;
},
 set: function(value)
{
 this.mstrVersion_GeneCode = value;
    this.hmProperty["Version_GeneCode"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ViewName", {
 get: function ()
{
return this.mstrViewName;
},
 set: function(value)
{
 this.mstrViewName = value;
    this.hmProperty["ViewName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 界面类型码(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ViewTypeCode", {
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
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ViewTypeName", {
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
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ApplicationTypeId", {
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
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ApplicationTypeName", {
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
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "FuncModuleAgcId", {
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
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "FuncModuleName", {
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
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "FuncModuleEnName", {
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
/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "DataBaseName", {
 get: function ()
{
return this.mstrDataBaseName;
},
 set: function(value)
{
 this.mstrDataBaseName = value;
    this.hmProperty["DataBaseName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 主表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "KeyForMainTab", {
 get: function ()
{
return this.mstrKeyForMainTab;
},
 set: function(value)
{
 this.mstrKeyForMainTab = value;
    this.hmProperty["KeyForMainTab"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 明细表关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "KeyForDetailTab", {
 get: function ()
{
return this.mstrKeyForDetailTab;
},
 set: function(value)
{
 this.mstrKeyForDetailTab = value;
    this.hmProperty["KeyForDetailTab"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "IsNeedSort", {
 get: function ()
{
return this.mbolIsNeedSort;
},
 set: function(value)
{
 this.mbolIsNeedSort = value;
    this.hmProperty["IsNeedSort"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "IsNeedTransCode", {
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
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "UserId", {
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
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "PrjId", {
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
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "PrjName", {
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
/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ViewFunction", {
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
/// 界面说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ViewDetail", {
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
/// 缺省菜单名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "DefaMenuName", {
 get: function ()
{
return this.mstrDefaMenuName;
},
 set: function(value)
{
 this.mstrDefaMenuName = value;
    this.hmProperty["DefaMenuName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 明细表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "DetailTabId", {
 get: function ()
{
return this.mstrDetailTabId;
},
 set: function(value)
{
 this.mstrDetailTabId = value;
    this.hmProperty["DetailTabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:150;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "FileName", {
 get: function ()
{
return this.mstrFileName;
},
 set: function(value)
{
 this.mstrFileName = value;
    this.hmProperty["FileName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "FilePath", {
 get: function ()
{
return this.mstrFilePath;
},
 set: function(value)
{
 this.mstrFilePath = value;
    this.hmProperty["FilePath"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 主表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "MainTabId", {
 get: function ()
{
return this.mstrMainTabId;
},
 set: function(value)
{
 this.mstrMainTabId = value;
    this.hmProperty["MainTabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 视图中文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ViewCnName", {
 get: function ()
{
return this.mstrViewCnName;
},
 set: function(value)
{
 this.mstrViewCnName = value;
    this.hmProperty["ViewCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 界面组ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ViewGroupId", {
 get: function ()
{
return this.mstrViewGroupId;
},
 set: function(value)
{
 this.mstrViewGroupId = value;
    this.hmProperty["ViewGroupId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 界面组名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "ViewGroupName", {
 get: function ()
{
return this.mstrViewGroupName;
},
 set: function(value)
{
 this.mstrViewGroupName = value;
    this.hmProperty["ViewGroupName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 输入数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "INSQLDSTypeId", {
 get: function ()
{
return this.mstrINSQLDSTypeId;
},
 set: function(value)
{
 this.mstrINSQLDSTypeId = value;
    this.hmProperty["INSQLDSTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 输出数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "OUTSQLDSTypeId", {
 get: function ()
{
return this.mstrOUTSQLDSTypeId;
},
 set: function(value)
{
 this.mstrOUTSQLDSTypeId = value;
    this.hmProperty["OUTSQLDSTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "GeneCodeDate", {
 get: function ()
{
return this.mstrGeneCodeDate;
},
 set: function(value)
{
 this.mstrGeneCodeDate = value;
    this.hmProperty["GeneCodeDate"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "RegionNum", {
 get: function ()
{
return this.mintRegionNum;
},
 set: function(value)
{
 this.mintRegionNum = value;
    this.hmProperty["RegionNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "UpdDate", {
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
/// 主表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "MainTabName", {
 get: function ()
{
return this.mstrMainTabName;
},
 set: function(value)
{
 this.mstrMainTabName = value;
    this.hmProperty["MainTabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 详细表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "DetailTabName", {
 get: function ()
{
return this.mstrDetailTabName;
},
 set: function(value)
{
 this.mstrDetailTabName = value;
    this.hmProperty["DetailTabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// MainTabKeyFld(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "MainTabKeyFld", {
 get: function ()
{
return this.mstrMainTabKeyFld;
},
 set: function(value)
{
 this.mstrMainTabKeyFld = value;
    this.hmProperty["MainTabKeyFld"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// DetailTabKeyFld(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "DetailTabKeyFld", {
 get: function ()
{
return this.mstrDetailTabKeyFld;
},
 set: function(value)
{
 this.mstrDetailTabKeyFld = value;
    this.hmProperty["DetailTabKeyFld"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// UserId4GeneCode(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN.prototype, "UserId4GeneCode", {
 get: function ()
{
return this.mstrUserId4GeneCode;
},
 set: function(value)
{
 this.mstrUserId4GeneCode = value;
    this.hmProperty["UserId4GeneCode"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"ViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ViewId", {
 get: function () {return "ViewId";}  // 界面Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TitleStyleId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_TitleStyleId", {
 get: function () {return "TitleStyleId";}  // 标题类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TitleStyleName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_TitleStyleName", {
 get: function () {return "TitleStyleName";}  // 标题类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DGStyleId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_DGStyleId", {
 get: function () {return "DGStyleId";}  // DG模式ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DGStyleName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_DGStyleName", {
 get: function () {return "DGStyleName";}  // DG模式名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Version_GeneCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_Version_GeneCode", {
 get: function () {return "Version_GeneCode";}  // 生成代码版本
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ViewName", {
 get: function () {return "ViewName";}  // 界面名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewTypeCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ViewTypeCode", {
 get: function () {return "ViewTypeCode";}  // 界面类型码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ViewTypeName", {
 get: function () {return "ViewTypeName";}  // 界面类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ApplicationTypeId", {
 get: function () {return "ApplicationTypeId";}  // 应用程序类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ApplicationTypeName", {
 get: function () {return "ApplicationTypeName";}  // 应用程序类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_FuncModuleAgcId", {
 get: function () {return "FuncModuleAgcId";}  // 功能模块Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_FuncModuleName", {
 get: function () {return "FuncModuleName";}  // 功能模块名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_FuncModuleEnName", {
 get: function () {return "FuncModuleEnName";}  // 功能模块英文名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataBaseName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_DataBaseName", {
 get: function () {return "DataBaseName";}  // 数据库名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyForMainTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_KeyForMainTab", {
 get: function () {return "KeyForMainTab";}  // 主表关键字
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyForDetailTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_KeyForDetailTab", {
 get: function () {return "KeyForDetailTab";}  // 明细表关键字
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedSort"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_IsNeedSort", {
 get: function () {return "IsNeedSort";}  // 是否需要排序
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_IsNeedTransCode", {
 get: function () {return "IsNeedTransCode";}  // 是否需要转换代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_UserId", {
 get: function () {return "UserId";}  // 用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_PrjName", {
 get: function () {return "PrjName";}  // 工程名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewFunction"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ViewFunction", {
 get: function () {return "ViewFunction";}  // 界面功能
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewDetail"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ViewDetail", {
 get: function () {return "ViewDetail";}  // 界面说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DefaMenuName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_DefaMenuName", {
 get: function () {return "DefaMenuName";}  // 缺省菜单名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DetailTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_DetailTabId", {
 get: function () {return "DetailTabId";}  // 明细表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FileName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_FileName", {
 get: function () {return "FileName";}  // 文件名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FilePath"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_FilePath", {
 get: function () {return "FilePath";}  // 文件路径
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MainTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_MainTabId", {
 get: function () {return "MainTabId";}  // 主表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ViewCnName", {
 get: function () {return "ViewCnName";}  // 视图中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewGroupId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ViewGroupId", {
 get: function () {return "ViewGroupId";}  // 界面组ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewGroupName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_ViewGroupName", {
 get: function () {return "ViewGroupName";}  // 界面组名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INSQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_INSQLDSTypeId", {
 get: function () {return "INSQLDSTypeId";}  // 输入数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OUTSQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_OUTSQLDSTypeId", {
 get: function () {return "OUTSQLDSTypeId";}  // 输出数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_GeneCodeDate", {
 get: function () {return "GeneCodeDate";}  // 生成代码日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_RegionNum", {
 get: function () {return "RegionNum";}  // 区域数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MainTabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_MainTabName", {
 get: function () {return "MainTabName";}  // 主表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DetailTabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_DetailTabName", {
 get: function () {return "DetailTabName";}  // 详细表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MainTabKeyFld"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_MainTabKeyFld", {
 get: function () {return "MainTabKeyFld";}  // MainTabKeyFld
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DetailTabKeyFld"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_DetailTabKeyFld", {
 get: function () {return "DetailTabKeyFld";}  // DetailTabKeyFld
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserId4GeneCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvViewInfo4GeneCodeEN, "con_UserId4GeneCode", {
 get: function () {return "UserId4GeneCode";}  // UserId4GeneCode
,
    enumerable: true,
    configurable: true
});

clsvViewInfo4GeneCodeEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvViewInfo4GeneCodeEN._CurrTabName = "vViewInfo4GeneCode"; //当前表名,与该类相关的表名
clsvViewInfo4GeneCodeEN._KeyFldName = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvViewInfo4GeneCodeEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvViewInfo4GeneCodeEN = clsvViewInfo4GeneCodeEN;
});