
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEditRegionFldsEN
 表名:EditRegionFlds(00050116)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:37
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
 /// 编辑区域字段(EditRegionFlds)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsEditRegionFldsEN = /** @class */ (function (_super) {
__extends(clsEditRegionFldsEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsEditRegionFldsEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 30;
_this.AttributeName = new Array("mId", "RegionId", "TabFldId", "LabelCaption", "CtlTypeId", "DDLItemsOptionId", "DS_TabId", "DS_DataValueFieldId", "DS_DataTextFieldId", "DS_CondStr", "DS_SQLStr", "ItemsString", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "INOUTTypeId", "InUse", "PrjId", "UpdUser", "UpdDate", "Memo", "IsSynchToServer", "SynchToServerDate", "SynchToServerUser", "IsSynchToClient", "SynchToClientDate", "SynchToClientUser", "SynSource");
_this.lngmId = 0; //mId,
_this.lngRegionId = 0; //区域Id,
_this.lngTabFldId = 0; //表字段ID,
_this.strLabelCaption = ""; //标签标题,
_this.strCtlTypeId = ""; //控件类型号,
_this.strDDLItemsOptionId = ""; //下拉框列表选项ID,
_this.strDS_TabId = ""; //数据源表ID,
_this.strDS_DataValueFieldId = ""; //数据源值字段Id,
_this.strDS_DataTextFieldId = ""; //数据源文本字段Id,
_this.strDS_CondStr = ""; //数据源条件串,
_this.strDS_SQLStr = ""; //数据源SQL串,
_this.strItemsString = ""; //列表项串,
_this.intColSpan = 0; //跨列数,
_this.intColIndex = 0; //列序号,
_this.intWidth = 0; //宽,
_this.bolIsMultiRow = false; //是否多行,
_this.intSeqNum = 0; //字段序号,
_this.strINOUTTypeId = ""; //INOUT类型ID,
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "mId", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "RegionId", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "TabFldId", {
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
/// 标签标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "LabelCaption", {
 get: function ()
{
return this.mstrLabelCaption;
},
 set: function(value)
{
 this.mstrLabelCaption = value;
    this.hmProperty["LabelCaption"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 控件类型号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "CtlTypeId", {
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
/// 下拉框列表选项ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "DDLItemsOptionId", {
 get: function ()
{
return this.mstrDDLItemsOptionId;
},
 set: function(value)
{
 this.mstrDDLItemsOptionId = value;
    this.hmProperty["DDLItemsOptionId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "DS_TabId", {
 get: function ()
{
return this.mstrDS_TabId;
},
 set: function(value)
{
 this.mstrDS_TabId = value;
    this.hmProperty["DS_TabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源值字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "DS_DataValueFieldId", {
 get: function ()
{
return this.mstrDS_DataValueFieldId;
},
 set: function(value)
{
 this.mstrDS_DataValueFieldId = value;
    this.hmProperty["DS_DataValueFieldId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源文本字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "DS_DataTextFieldId", {
 get: function ()
{
return this.mstrDS_DataTextFieldId;
},
 set: function(value)
{
 this.mstrDS_DataTextFieldId = value;
    this.hmProperty["DS_DataTextFieldId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源条件串(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "DS_CondStr", {
 get: function ()
{
return this.mstrDS_CondStr;
},
 set: function(value)
{
 this.mstrDS_CondStr = value;
    this.hmProperty["DS_CondStr"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源SQL串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "DS_SQLStr", {
 get: function ()
{
return this.mstrDS_SQLStr;
},
 set: function(value)
{
 this.mstrDS_SQLStr = value;
    this.hmProperty["DS_SQLStr"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 列表项串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "ItemsString", {
 get: function ()
{
return this.mstrItemsString;
},
 set: function(value)
{
 this.mstrItemsString = value;
    this.hmProperty["ItemsString"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 跨列数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "ColSpan", {
 get: function ()
{
return this.mintColSpan;
},
 set: function(value)
{
 this.mintColSpan = value;
    this.hmProperty["ColSpan"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 列序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "ColIndex", {
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
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "Width", {
 get: function ()
{
return this.mintWidth;
},
 set: function(value)
{
 this.mintWidth = value;
    this.hmProperty["Width"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否多行(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "IsMultiRow", {
 get: function ()
{
return this.mbolIsMultiRow;
},
 set: function(value)
{
 this.mbolIsMultiRow = value;
    this.hmProperty["IsMultiRow"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 字段序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "SeqNum", {
 get: function ()
{
return this.mintSeqNum;
},
 set: function(value)
{
 this.mintSeqNum = value;
    this.hmProperty["SeqNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// INOUT类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "INOUTTypeId", {
 get: function ()
{
return this.mstrINOUTTypeId;
},
 set: function(value)
{
 this.mstrINOUTTypeId = value;
    this.hmProperty["INOUTTypeId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsEditRegionFldsEN.prototype, "InUse", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "PrjId", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "UpdUser", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "UpdDate", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "Memo", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "IsSynchToServer", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "SynchToServerDate", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "SynchToServerUser", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "IsSynchToClient", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "SynchToClientDate", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "SynchToClientUser", {
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
Object.defineProperty(clsEditRegionFldsEN.prototype, "SynSource", {
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
Object.defineProperty(clsEditRegionFldsEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_RegionId", {
 get: function () {return "RegionId";}  // 区域Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_TabFldId", {
 get: function () {return "TabFldId";}  // 表字段ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"LabelCaption"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_LabelCaption", {
 get: function () {return "LabelCaption";}  // 标签标题
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_CtlTypeId", {
 get: function () {return "CtlTypeId";}  // 控件类型号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DDLItemsOptionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_DDLItemsOptionId", {
 get: function () {return "DDLItemsOptionId";}  // 下拉框列表选项ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_DS_TabId", {
 get: function () {return "DS_TabId";}  // 数据源表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataValueFieldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_DS_DataValueFieldId", {
 get: function () {return "DS_DataValueFieldId";}  // 数据源值字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataTextFieldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_DS_DataTextFieldId", {
 get: function () {return "DS_DataTextFieldId";}  // 数据源文本字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_CondStr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_DS_CondStr", {
 get: function () {return "DS_CondStr";}  // 数据源条件串
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_SQLStr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_DS_SQLStr", {
 get: function () {return "DS_SQLStr";}  // 数据源SQL串
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ItemsString"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_ItemsString", {
 get: function () {return "ItemsString";}  // 列表项串
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColSpan"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_ColSpan", {
 get: function () {return "ColSpan";}  // 跨列数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColIndex"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_ColIndex", {
 get: function () {return "ColIndex";}  // 列序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Width"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_Width", {
 get: function () {return "Width";}  // 宽
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsMultiRow"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_IsMultiRow", {
 get: function () {return "IsMultiRow";}  // 是否多行
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SeqNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_SeqNum", {
 get: function () {return "SeqNum";}  // 字段序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INOUTTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_INOUTTypeId", {
 get: function () {return "INOUTTypeId";}  // INOUT类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"InUse"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_InUse", {
 get: function () {return "InUse";}  // 是否在用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToServer"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_IsSynchToServer", {
 get: function () {return "IsSynchToServer";}  // 是否同步到Server
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_SynchToServerDate", {
 get: function () {return "SynchToServerDate";}  // 同步到Server日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToServerUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_SynchToServerUser", {
 get: function () {return "SynchToServerUser";}  // 同步到Server用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsSynchToClient"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_IsSynchToClient", {
 get: function () {return "IsSynchToClient";}  // 是否同步到Client
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_SynchToClientDate", {
 get: function () {return "SynchToClientDate";}  // 同步到Client库日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynchToClientUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_SynchToClientUser", {
 get: function () {return "SynchToClientUser";}  // 同步到Client库用户
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SynSource"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsEditRegionFldsEN, "con_SynSource", {
 get: function () {return "SynSource";}  // 同步来源
,
    enumerable: true,
    configurable: true
});

clsEditRegionFldsEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsEditRegionFldsEN._CurrTabName = "EditRegionFlds"; //当前表名,与该类相关的表名
clsEditRegionFldsEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsEditRegionFldsEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsEditRegionFldsEN = clsEditRegionFldsEN;
});