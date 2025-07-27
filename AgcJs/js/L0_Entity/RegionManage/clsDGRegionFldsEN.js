
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDGRegionFldsEN
 表名:DGRegionFlds(00050113)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:41
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
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
 /// DG区域字段(DGRegionFlds)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsDGRegionFldsEN = /** @class */ (function (_super) {
__extends(clsDGRegionFldsEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsDGRegionFldsEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 23;
_this.AttributeName = new Array("mId", "RegionId", "TabFldId", "ColIndex", "ColCaption", "CtlTypeId", "DgFuncTypeId", "IsNeedSort", "IsTransToChkBox", "IsVisible", "IsFuncFld", "InUse", "PrjId", "UpdUser", "UpdDate", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource");
_this.lngmId = 0; //mId,
_this.lngRegionId = 0; //区域Id,
_this.lngTabFldId = 0; //表字段ID,
_this.intColIndex = 0; //列序号,
_this.strColCaption = ""; //列标题,
_this.strCtlTypeId = ""; //控件类型号,
_this.strDgFuncTypeId = ""; //Dg功能类型Id,
_this.bolIsNeedSort = false; //是否需要排序,
_this.bolIsTransToChkBox = false; //是否转换成CheckBox,
_this.bolIsVisible = false; //是否显示,
_this.bolIsFuncFld = false; //是否功能字段,
_this.bolInUse = false; //是否在用,
_this.strPrjId = ""; //工程ID,
_this.strUpdUser = ""; //修改者,
_this.strUpdDate = ""; //修改日期,
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
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "mId", {
 get: function ()
{
return this.mlngmId;
},
 set: function(value)
{
 this.mlngmId = value;
    this.hmProperty["mId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "RegionId", {
 get: function ()
{
return this.mlngRegionId;
},
 set: function(value)
{
 this.mlngRegionId = value;
    this.hmProperty["RegionId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 表字段ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "TabFldId", {
 get: function ()
{
return this.mlngTabFldId;
},
 set: function(value)
{
 this.mlngTabFldId = value;
    this.hmProperty["TabFldId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 列序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "ColIndex", {
 get: function ()
{
return this.mintColIndex;
},
 set: function(value)
{
 this.mintColIndex = value;
    this.hmProperty["ColIndex"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 列标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "ColCaption", {
 get: function ()
{
return this.mstrColCaption;
},
 set: function(value)
{
 this.mstrColCaption = value;
    this.hmProperty["ColCaption"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "CtlTypeId", {
 get: function ()
{
return this.mstrCtlTypeId;
},
 set: function(value)
{
 this.mstrCtlTypeId = value;
    this.hmProperty["CtlTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// Dg功能类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "DgFuncTypeId", {
 get: function ()
{
return this.mstrDgFuncTypeId;
},
 set: function(value)
{
 this.mstrDgFuncTypeId = value;
    this.hmProperty["DgFuncTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "IsNeedSort", {
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
/// 是否转换成CheckBox(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "IsTransToChkBox", {
 get: function ()
{
return this.mbolIsTransToChkBox;
},
 set: function(value)
{
 this.mbolIsTransToChkBox = value;
    this.hmProperty["IsTransToChkBox"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "IsVisible", {
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
/// 是否功能字段(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "IsFuncFld", {
 get: function ()
{
return this.mbolIsFuncFld;
},
 set: function(value)
{
 this.mbolIsFuncFld = value;
    this.hmProperty["IsFuncFld"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "InUse", {
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
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "PrjId", {
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
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "UpdUser", {
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
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDGRegionFldsEN.prototype, "UpdDate", {
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
Object.defineProperty(clsDGRegionFldsEN.prototype, "Memo", {
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
Object.defineProperty(clsDGRegionFldsEN.prototype, "IsSynchToServer", {
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
Object.defineProperty(clsDGRegionFldsEN.prototype, "SynchToServerDate", {
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
Object.defineProperty(clsDGRegionFldsEN.prototype, "SynchToServerUser", {
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
Object.defineProperty(clsDGRegionFldsEN.prototype, "IsSynchToClient", {
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
Object.defineProperty(clsDGRegionFldsEN.prototype, "SynchToClientDate", {
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
Object.defineProperty(clsDGRegionFldsEN.prototype, "SynchToClientUser", {
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
Object.defineProperty(clsDGRegionFldsEN.prototype, "SynSource", {
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
 /// 常量:"mId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_RegionId", {
 get: function () {return "RegionId";}  // 区域Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_TabFldId", {
 get: function () {return "TabFldId";}  // 表字段ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColIndex"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_ColIndex", {
 get: function () {return "ColIndex";}  // 列序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColCaption"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_ColCaption", {
 get: function () {return "ColCaption";}  // 列标题
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_CtlTypeId", {
 get: function () {return "CtlTypeId";}  // 控件类型号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DgFuncTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_DgFuncTypeId", {
 get: function () {return "DgFuncTypeId";}  // Dg功能类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedSort"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_IsNeedSort", {
 get: function () {return "IsNeedSort";}  // 是否需要排序
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsTransToChkBox"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_IsTransToChkBox", {
 get: function () {return "IsTransToChkBox";}  // 是否转换成CheckBox
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsVisible"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_IsVisible", {
 get: function () {return "IsVisible";}  // 是否显示
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsFuncFld"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_IsFuncFld", {
 get: function () {return "IsFuncFld";}  // 是否功能字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"InUse"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_InUse", {
 get: function () {return "InUse";}  // 是否在用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToServer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_IsSynchToServer", {
 get: function () {return "IsSynchToServer";}  // 是否同步到Server
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_SynchToServerDate", {
 get: function () {return "SynchToServerDate";}  // 同步到Server日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_SynchToServerUser", {
 get: function () {return "SynchToServerUser";}  // 同步到Server用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToClient"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_IsSynchToClient", {
 get: function () {return "IsSynchToClient";}  // 是否同步到Client
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_SynchToClientDate", {
 get: function () {return "SynchToClientDate";}  // 同步到Client库日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_SynchToClientUser", {
 get: function () {return "SynchToClientUser";}  // 同步到Client库用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynSource"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDGRegionFldsEN, "con_SynSource", {
 get: function () {return "SynSource";}  // 同步来源
,
    enumerable: true,
    configurable: true
});

clsDGRegionFldsEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsDGRegionFldsEN._CurrTabName = "DGRegionFlds"; //当前表名,与该类相关的表名
clsDGRegionFldsEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsDGRegionFldsEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsDGRegionFldsEN = clsDGRegionFldsEN;
});