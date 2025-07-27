
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewInfoEN
 表名:ViewInfo(00050006)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:16
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
 /// 界面(ViewInfo)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsViewInfoEN = /** @class */ (function (_super) {
__extends(clsViewInfoEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsViewInfoEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 44;
_this.AttributeName = new Array("ViewId", "ViewName", "ViewTypeCode", "ApplicationTypeId", "FuncModuleAgcId", "DataBaseName", "KeyForMainTab", "KeyForDetailTab", "IsNeedSort", "IsNeedTransCode", "IsNeedSetExportFld", "UserId", "PrjId", "ViewFunction", "ViewDetail", "DefaMenuName", "DetailTabId", "FileName", "FilePath", "MainTabId", "ViewCnName", "ViewGroupId", "INRelaTabId", "INSQLDSTypeId", "OUTRelaTabId", "OUTSQLDSTypeId", "DetailTabType", "DetailViewId", "MainTabType", "IsUseCache4List", "MainViewId", "GeneCodeDate", "TaskId", "RegionNum", "UpdDate", "UpdUserId", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource");
_this.strViewId = ""; //界面Id,
_this.strViewName = ""; //界面名称,
_this.intViewTypeCode = 0; //界面类型码,
_this.intApplicationTypeId = 0; //应用程序类型ID,
_this.strFuncModuleAgcId = ""; //功能模块Id,
_this.strDataBaseName = ""; //数据库名,
_this.strKeyForMainTab = ""; //主表关键字,
_this.strKeyForDetailTab = ""; //明细表关键字,
_this.bolIsNeedSort = false; //是否需要排序,
_this.bolIsNeedTransCode = false; //是否需要转换代码,
_this.bolIsNeedSetExportFld = false; //是否需要设置导出字段,
_this.strUserId = ""; //用户Id,
_this.strPrjId = ""; //工程ID,
_this.strViewFunction = ""; //界面功能,
_this.strViewDetail = ""; //界面说明,
_this.strDefaMenuName = ""; //缺省菜单名,
_this.strDetailTabId = ""; //明细表ID,
_this.strFileName = ""; //文件名,
_this.strFilePath = ""; //文件路径,
_this.strMainTabId = ""; //主表ID,
_this.strViewCnName = ""; //视图中文名,
_this.strViewGroupId = ""; //界面组ID,
_this.strINRelaTabId = ""; //输入数据源表ID,
_this.strINSQLDSTypeId = ""; //输入数据源类型,
_this.strOUTRelaTabId = ""; //输出数据源表ID,
_this.strOUTSQLDSTypeId = ""; //输出数据源类型,
_this.strDetailTabType = ""; //DetailTabType,
_this.strDetailViewId = ""; //DetailViewId,
_this.strMainTabType = ""; //MainTabType,
_this.bolIsUseCache4List = false; //是否使用缓存列表,
_this.strMainViewId = ""; //MainViewId,
_this.strGeneCodeDate = ""; //生成代码日期,
_this.strTaskId = ""; //任务Id,
_this.intRegionNum = 0; //区域数,
_this.strUpdDate = ""; //修改日期,
_this.strUpdUserId = ""; //修改用户Id,
_this.strMemo = ""; //说明,
_this.bolIsSynchToServer = false; //是否同步到Server,
_this.strSynchToServerDate = ""; //同步到Server日期,
_this.strSynchToServerUser = ""; //同步到Server用户,
_this.bolIsSynchToClient = false; //是否同步到Client,
_this.strSynchToClientDate = ""; //同步到Client库日期,
_this.strSynchToClientUser = ""; //同步到Client库用户,
_this.strSynSource = ""; //同步来源,
  return _this;
 }

/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "ViewId", {
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
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "ViewName", {
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
Object.defineProperty(clsViewInfoEN.prototype, "ViewTypeCode", {
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
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "ApplicationTypeId", {
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
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "FuncModuleAgcId", {
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
/// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "DataBaseName", {
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
Object.defineProperty(clsViewInfoEN.prototype, "KeyForMainTab", {
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
Object.defineProperty(clsViewInfoEN.prototype, "KeyForDetailTab", {
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
Object.defineProperty(clsViewInfoEN.prototype, "IsNeedSort", {
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
Object.defineProperty(clsViewInfoEN.prototype, "IsNeedTransCode", {
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
/// 是否需要设置导出字段(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "IsNeedSetExportFld", {
 get: function ()
{
return this.mbolIsNeedSetExportFld;
},
 set: function(value)
{
 this.mbolIsNeedSetExportFld = value;
    this.hmProperty["IsNeedSetExportFld"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "UserId", {
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
Object.defineProperty(clsViewInfoEN.prototype, "PrjId", {
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
/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "ViewFunction", {
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
Object.defineProperty(clsViewInfoEN.prototype, "ViewDetail", {
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
Object.defineProperty(clsViewInfoEN.prototype, "DefaMenuName", {
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
Object.defineProperty(clsViewInfoEN.prototype, "DetailTabId", {
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
Object.defineProperty(clsViewInfoEN.prototype, "FileName", {
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
Object.defineProperty(clsViewInfoEN.prototype, "FilePath", {
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
Object.defineProperty(clsViewInfoEN.prototype, "MainTabId", {
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
Object.defineProperty(clsViewInfoEN.prototype, "ViewCnName", {
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
Object.defineProperty(clsViewInfoEN.prototype, "ViewGroupId", {
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
/// 输入数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "INRelaTabId", {
 get: function ()
{
return this.mstrINRelaTabId;
},
 set: function(value)
{
 this.mstrINRelaTabId = value;
    this.hmProperty["INRelaTabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 输入数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "INSQLDSTypeId", {
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
/// 输出数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "OUTRelaTabId", {
 get: function ()
{
return this.mstrOUTRelaTabId;
},
 set: function(value)
{
 this.mstrOUTRelaTabId = value;
    this.hmProperty["OUTRelaTabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 输出数据源类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "OUTSQLDSTypeId", {
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
/// DetailTabType(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "DetailTabType", {
 get: function ()
{
return this.mstrDetailTabType;
},
 set: function(value)
{
 this.mstrDetailTabType = value;
    this.hmProperty["DetailTabType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// DetailViewId(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "DetailViewId", {
 get: function ()
{
return this.mstrDetailViewId;
},
 set: function(value)
{
 this.mstrDetailViewId = value;
    this.hmProperty["DetailViewId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// MainTabType(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "MainTabType", {
 get: function ()
{
return this.mstrMainTabType;
},
 set: function(value)
{
 this.mstrMainTabType = value;
    this.hmProperty["MainTabType"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否使用缓存列表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "IsUseCache4List", {
 get: function ()
{
return this.mbolIsUseCache4List;
},
 set: function(value)
{
 this.mbolIsUseCache4List = value;
    this.hmProperty["IsUseCache4List"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// MainViewId(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "MainViewId", {
 get: function ()
{
return this.mstrMainViewId;
},
 set: function(value)
{
 this.mstrMainViewId = value;
    this.hmProperty["MainViewId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "GeneCodeDate", {
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
/// 任务Id(说明:;字段类型:char;字段长度:16;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "TaskId", {
 get: function ()
{
return this.mstrTaskId;
},
 set: function(value)
{
 this.mstrTaskId = value;
    this.hmProperty["TaskId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "RegionNum", {
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
Object.defineProperty(clsViewInfoEN.prototype, "UpdDate", {
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
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "UpdUserId", {
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
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "Memo", {
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
/// 是否同步到Server(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsViewInfoEN.prototype, "IsSynchToServer", {
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
Object.defineProperty(clsViewInfoEN.prototype, "SynchToServerDate", {
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
Object.defineProperty(clsViewInfoEN.prototype, "SynchToServerUser", {
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
Object.defineProperty(clsViewInfoEN.prototype, "IsSynchToClient", {
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
Object.defineProperty(clsViewInfoEN.prototype, "SynchToClientDate", {
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
Object.defineProperty(clsViewInfoEN.prototype, "SynchToClientUser", {
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
Object.defineProperty(clsViewInfoEN.prototype, "SynSource", {
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
 /// 常量:"ViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_ViewId", {
 get: function () {return "ViewId";}  // 界面Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_ViewName", {
 get: function () {return "ViewName";}  // 界面名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewTypeCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_ViewTypeCode", {
 get: function () {return "ViewTypeCode";}  // 界面类型码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_ApplicationTypeId", {
 get: function () {return "ApplicationTypeId";}  // 应用程序类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_FuncModuleAgcId", {
 get: function () {return "FuncModuleAgcId";}  // 功能模块Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataBaseName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_DataBaseName", {
 get: function () {return "DataBaseName";}  // 数据库名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyForMainTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_KeyForMainTab", {
 get: function () {return "KeyForMainTab";}  // 主表关键字
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"KeyForDetailTab"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_KeyForDetailTab", {
 get: function () {return "KeyForDetailTab";}  // 明细表关键字
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedSort"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_IsNeedSort", {
 get: function () {return "IsNeedSort";}  // 是否需要排序
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_IsNeedTransCode", {
 get: function () {return "IsNeedTransCode";}  // 是否需要转换代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedSetExportFld"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_IsNeedSetExportFld", {
 get: function () {return "IsNeedSetExportFld";}  // 是否需要设置导出字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_UserId", {
 get: function () {return "UserId";}  // 用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewFunction"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_ViewFunction", {
 get: function () {return "ViewFunction";}  // 界面功能
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewDetail"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_ViewDetail", {
 get: function () {return "ViewDetail";}  // 界面说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DefaMenuName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_DefaMenuName", {
 get: function () {return "DefaMenuName";}  // 缺省菜单名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DetailTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_DetailTabId", {
 get: function () {return "DetailTabId";}  // 明细表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FileName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_FileName", {
 get: function () {return "FileName";}  // 文件名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FilePath"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_FilePath", {
 get: function () {return "FilePath";}  // 文件路径
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MainTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_MainTabId", {
 get: function () {return "MainTabId";}  // 主表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_ViewCnName", {
 get: function () {return "ViewCnName";}  // 视图中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewGroupId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_ViewGroupId", {
 get: function () {return "ViewGroupId";}  // 界面组ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INRelaTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_INRelaTabId", {
 get: function () {return "INRelaTabId";}  // 输入数据源表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INSQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_INSQLDSTypeId", {
 get: function () {return "INSQLDSTypeId";}  // 输入数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OUTRelaTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_OUTRelaTabId", {
 get: function () {return "OUTRelaTabId";}  // 输出数据源表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"OUTSQLDSTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_OUTSQLDSTypeId", {
 get: function () {return "OUTSQLDSTypeId";}  // 输出数据源类型
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DetailTabType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_DetailTabType", {
 get: function () {return "DetailTabType";}  // DetailTabType
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DetailViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_DetailViewId", {
 get: function () {return "DetailViewId";}  // DetailViewId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MainTabType"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_MainTabType", {
 get: function () {return "MainTabType";}  // MainTabType
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsUseCache4List"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_IsUseCache4List", {
 get: function () {return "IsUseCache4List";}  // 是否使用缓存列表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MainViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_MainViewId", {
 get: function () {return "MainViewId";}  // MainViewId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_GeneCodeDate", {
 get: function () {return "GeneCodeDate";}  // 生成代码日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TaskId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_TaskId", {
 get: function () {return "TaskId";}  // 任务Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_RegionNum", {
 get: function () {return "RegionNum";}  // 区域数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUserId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_UpdUserId", {
 get: function () {return "UpdUserId";}  // 修改用户Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToServer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_IsSynchToServer", {
 get: function () {return "IsSynchToServer";}  // 是否同步到Server
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_SynchToServerDate", {
 get: function () {return "SynchToServerDate";}  // 同步到Server日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_SynchToServerUser", {
 get: function () {return "SynchToServerUser";}  // 同步到Server用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToClient"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_IsSynchToClient", {
 get: function () {return "IsSynchToClient";}  // 是否同步到Client
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_SynchToClientDate", {
 get: function () {return "SynchToClientDate";}  // 同步到Client库日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_SynchToClientUser", {
 get: function () {return "SynchToClientUser";}  // 同步到Client库用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynSource"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsViewInfoEN, "con_SynSource", {
 get: function () {return "SynSource";}  // 同步来源
,
    enumerable: true,
    configurable: true
});

clsViewInfoEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsViewInfoEN._CurrTabName = "ViewInfo"; //当前表名,与该类相关的表名
clsViewInfoEN._KeyFldName = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsViewInfoEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsViewInfoEN = clsViewInfoEN;
});