
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQryRegionFldsEN
 表名:vQryRegionFlds(00050151)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/05 02:47:42
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
 /// v查询区域字段(vQryRegionFlds)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvQryRegionFldsEN = /** @class */ (function (_super) {
__extends(clsvQryRegionFldsEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvQryRegionFldsEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 40;
_this.AttributeName = new Array("mId", "FldId", "FldName", "DataTypeName", "DataTypeId", "FieldTypeId", "FieldTypeName", "RegionId", "RegionName", "ViewId", "ViewName", "TabFldId", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "DS_TabId", "TabName", "QueryOptionId", "QueryOptionName", "DDLItemsOptionId", "DDLItemsOptionName", "DS_SQLStr", "DS_DataTextFieldId", "DS_DataValueFieldId", "ItemsString", "DS_CondStr", "ColSpan", "Width", "SeqNum", "InUse", "PrjId", "UpdUser", "UpdDate", "Memo", "DS_TabName", "DS_DataValueFieldName", "DS_DataTextFieldName", "RelaTabId");
_this.lngmId = 0; //mId,
_this.strFldId = ""; //字段Id,
_this.strFldName = ""; //字段名,
_this.strDataTypeName = ""; //数据类型名称,
_this.strDataTypeId = ""; //数据类型Id,
_this.strFieldTypeId = ""; //字段类型Id,
_this.strFieldTypeName = ""; //字段类型名,
_this.lngRegionId = 0; //区域Id,
_this.strRegionName = ""; //区域名称,
_this.strViewId = ""; //界面Id,
_this.strViewName = ""; //界面名称,
_this.lngTabFldId = 0; //表字段ID,
_this.strLabelCaption = ""; //标签标题,
_this.strCtlTypeId = ""; //控件类型号,
_this.strCtlTypeName = ""; //控件类型名,
_this.strCtlCnName = ""; //控件类型中文名,
_this.strCtlTypeAbbr = ""; //控件类型缩写,
_this.strDS_TabId = ""; //数据源表ID,
_this.strTabName = ""; //表名,
_this.strQueryOptionId = ""; //查询方式Id,
_this.strQueryOptionName = ""; //查询方式名称,
_this.strDDLItemsOptionId = ""; //下拉框列表选项ID,
_this.strDDLItemsOptionName = ""; //下拉选项名,
_this.strDS_SQLStr = ""; //数据源SQL串,
_this.strDS_DataTextFieldId = ""; //数据源文本字段Id,
_this.strDS_DataValueFieldId = ""; //数据源值字段Id,
_this.strItemsString = ""; //列表项串,
_this.strDS_CondStr = ""; //数据源条件串,
_this.intColSpan = 0; //跨列数,
_this.intWidth = 0; //宽,
_this.intSeqNum = 0; //字段序号,
_this.bolInUse = false; //是否在用,
_this.strPrjId = ""; //工程ID,
_this.strUpdUser = ""; //修改者,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
_this.strDS_TabName = ""; //数据源表,
_this.strDS_DataValueFieldName = ""; //数据源值字段,
_this.strDS_DataTextFieldName = ""; //数据源文本字段,
_this.strRelaTabId = ""; //RelaTabId,
  return _this;
 }

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "mId", {
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
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "FldId", {
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
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "FldName", {
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
/// 数据类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DataTypeName", {
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
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DataTypeId", {
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
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "FieldTypeId", {
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
Object.defineProperty(clsvQryRegionFldsEN.prototype, "FieldTypeName", {
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
/// 区域Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "RegionId", {
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
/// 区域名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "RegionName", {
 get: function ()
{
return this.mstrRegionName;
},
 set: function(value)
{
 this.mstrRegionName = value;
    this.hmProperty["RegionName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "ViewId", {
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
Object.defineProperty(clsvQryRegionFldsEN.prototype, "ViewName", {
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
/// 表字段ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "TabFldId", {
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
Object.defineProperty(clsvQryRegionFldsEN.prototype, "LabelCaption", {
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
Object.defineProperty(clsvQryRegionFldsEN.prototype, "CtlTypeId", {
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
/// 控件类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "CtlTypeName", {
 get: function ()
{
return this.mstrCtlTypeName;
},
 set: function(value)
{
 this.mstrCtlTypeName = value;
    this.hmProperty["CtlTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 控件类型中文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "CtlCnName", {
 get: function ()
{
return this.mstrCtlCnName;
},
 set: function(value)
{
 this.mstrCtlCnName = value;
    this.hmProperty["CtlCnName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 控件类型缩写(说明:;字段类型:varchar;字段长度:5;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "CtlTypeAbbr", {
 get: function ()
{
return this.mstrCtlTypeAbbr;
},
 set: function(value)
{
 this.mstrCtlTypeAbbr = value;
    this.hmProperty["CtlTypeAbbr"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DS_TabId", {
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
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "TabName", {
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
/// 查询方式Id(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "QueryOptionId", {
 get: function ()
{
return this.mstrQueryOptionId;
},
 set: function(value)
{
 this.mstrQueryOptionId = value;
    this.hmProperty["QueryOptionId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 查询方式名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "QueryOptionName", {
 get: function ()
{
return this.mstrQueryOptionName;
},
 set: function(value)
{
 this.mstrQueryOptionName = value;
    this.hmProperty["QueryOptionName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 下拉框列表选项ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DDLItemsOptionId", {
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
/// 下拉选项名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DDLItemsOptionName", {
 get: function ()
{
return this.mstrDDLItemsOptionName;
},
 set: function(value)
{
 this.mstrDDLItemsOptionName = value;
    this.hmProperty["DDLItemsOptionName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源SQL串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DS_SQLStr", {
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
/// 数据源文本字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DS_DataTextFieldId", {
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
/// 数据源值字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DS_DataValueFieldId", {
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
/// 列表项串(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "ItemsString", {
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
/// 数据源条件串(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DS_CondStr", {
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
/// 跨列数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "ColSpan", {
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
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "Width", {
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
/// 字段序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "SeqNum", {
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
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "InUse", {
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
Object.defineProperty(clsvQryRegionFldsEN.prototype, "PrjId", {
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
Object.defineProperty(clsvQryRegionFldsEN.prototype, "UpdUser", {
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
Object.defineProperty(clsvQryRegionFldsEN.prototype, "UpdDate", {
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
Object.defineProperty(clsvQryRegionFldsEN.prototype, "Memo", {
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
/// 数据源表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DS_TabName", {
 get: function ()
{
return this.mstrDS_TabName;
},
 set: function(value)
{
 this.mstrDS_TabName = value;
    this.hmProperty["DS_TabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源值字段(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DS_DataValueFieldName", {
 get: function ()
{
return this.mstrDS_DataValueFieldName;
},
 set: function(value)
{
 this.mstrDS_DataValueFieldName = value;
    this.hmProperty["DS_DataValueFieldName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据源文本字段(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "DS_DataTextFieldName", {
 get: function ()
{
return this.mstrDS_DataTextFieldName;
},
 set: function(value)
{
 this.mstrDS_DataTextFieldName = value;
    this.hmProperty["DS_DataTextFieldName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// RelaTabId(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvQryRegionFldsEN.prototype, "RelaTabId", {
 get: function ()
{
return this.mstrRelaTabId;
},
 set: function(value)
{
 this.mstrRelaTabId = value;
    this.hmProperty["RelaTabId"] = true;
},
    enumerable: true,
    configurable: true
});

 /// <summary>
 /// 常量:"mId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_FldId", {
 get: function () {return "FldId";}  // 字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_FldName", {
 get: function () {return "FldName";}  // 字段名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DataTypeName", {
 get: function () {return "DataTypeName";}  // 数据类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DataTypeId", {
 get: function () {return "DataTypeId";}  // 数据类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_FieldTypeId", {
 get: function () {return "FieldTypeId";}  // 字段类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_FieldTypeName", {
 get: function () {return "FieldTypeName";}  // 字段类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_RegionId", {
 get: function () {return "RegionId";}  // 区域Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_RegionName", {
 get: function () {return "RegionName";}  // 区域名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_ViewId", {
 get: function () {return "ViewId";}  // 界面Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_ViewName", {
 get: function () {return "ViewName";}  // 界面名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_TabFldId", {
 get: function () {return "TabFldId";}  // 表字段ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"LabelCaption"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_LabelCaption", {
 get: function () {return "LabelCaption";}  // 标签标题
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_CtlTypeId", {
 get: function () {return "CtlTypeId";}  // 控件类型号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_CtlTypeName", {
 get: function () {return "CtlTypeName";}  // 控件类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_CtlCnName", {
 get: function () {return "CtlCnName";}  // 控件类型中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeAbbr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_CtlTypeAbbr", {
 get: function () {return "CtlTypeAbbr";}  // 控件类型缩写
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DS_TabId", {
 get: function () {return "DS_TabId";}  // 数据源表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_TabName", {
 get: function () {return "TabName";}  // 表名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"QueryOptionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_QueryOptionId", {
 get: function () {return "QueryOptionId";}  // 查询方式Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"QueryOptionName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_QueryOptionName", {
 get: function () {return "QueryOptionName";}  // 查询方式名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DDLItemsOptionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DDLItemsOptionId", {
 get: function () {return "DDLItemsOptionId";}  // 下拉框列表选项ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DDLItemsOptionName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DDLItemsOptionName", {
 get: function () {return "DDLItemsOptionName";}  // 下拉选项名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_SQLStr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DS_SQLStr", {
 get: function () {return "DS_SQLStr";}  // 数据源SQL串
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataTextFieldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DS_DataTextFieldId", {
 get: function () {return "DS_DataTextFieldId";}  // 数据源文本字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataValueFieldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DS_DataValueFieldId", {
 get: function () {return "DS_DataValueFieldId";}  // 数据源值字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ItemsString"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_ItemsString", {
 get: function () {return "ItemsString";}  // 列表项串
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_CondStr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DS_CondStr", {
 get: function () {return "DS_CondStr";}  // 数据源条件串
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColSpan"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_ColSpan", {
 get: function () {return "ColSpan";}  // 跨列数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Width"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_Width", {
 get: function () {return "Width";}  // 宽
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SeqNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_SeqNum", {
 get: function () {return "SeqNum";}  // 字段序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"InUse"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_InUse", {
 get: function () {return "InUse";}  // 是否在用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_TabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DS_TabName", {
 get: function () {return "DS_TabName";}  // 数据源表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataValueFieldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DS_DataValueFieldName", {
 get: function () {return "DS_DataValueFieldName";}  // 数据源值字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataTextFieldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_DS_DataTextFieldName", {
 get: function () {return "DS_DataTextFieldName";}  // 数据源文本字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RelaTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvQryRegionFldsEN, "con_RelaTabId", {
 get: function () {return "RelaTabId";}  // RelaTabId
,
    enumerable: true,
    configurable: true
});

clsvQryRegionFldsEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvQryRegionFldsEN._CurrTabName = "vQryRegionFlds"; //当前表名,与该类相关的表名
clsvQryRegionFldsEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvQryRegionFldsEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvQryRegionFldsEN = clsvQryRegionFldsEN;
});