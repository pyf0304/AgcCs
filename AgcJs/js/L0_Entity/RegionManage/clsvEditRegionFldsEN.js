
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEditRegionFldsEN
 表名:vEditRegionFlds(00050126)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:38
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
 /// v编辑区域字段(vEditRegionFlds)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvEditRegionFldsEN = /** @class */ (function (_super) {
__extends(clsvEditRegionFldsEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvEditRegionFldsEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 52;
_this.AttributeName = new Array("mId", "TabId", "FldId", "FldName", "DataTypeName", "FldLength", "DataTypeId", "FieldTypeId", "FieldTypeName", "IsTabNullable", "IsTabForeignKey", "IsParentObj", "PrimaryTypeId", "PrimaryTypeName", "ForeignKeyTabId", "ForeignTabName", "RegionId", "ColNum", "IsUseCtrl", "ViewId", "RegionTypeId", "RegionTypeName", "TabFldId", "LabelCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "CtlTypeAbbr", "DDLItemsOptionId", "DDLItemsOptionName", "DS_TabId", "TabName", "DS_DataValueFieldId", "DS_DataTextFieldId", "DS_CondStr", "DS_SQLStr", "ItemsString", "ColSpan", "ColIndex", "Width", "IsMultiRow", "SeqNum", "INOUTTypeId", "INOUTTypeName", "InUse", "PrjId", "UpdUser", "UpdDate", "Memo", "DS_TabName", "DS_DataValueFieldName", "DS_DataTextFieldName");
_this.lngmId = 0; //mId,
_this.strTabId = ""; //表ID,
_this.strFldId = ""; //字段Id,
_this.strFldName = ""; //字段名,
_this.strDataTypeName = ""; //数据类型名称,
_this.intFldLength = 0; //字段长度,
_this.strDataTypeId = ""; //数据类型Id,
_this.strFieldTypeId = ""; //字段类型Id,
_this.strFieldTypeName = ""; //字段类型名,
_this.bolIsTabNullable = false; //是否表中可空,
_this.bolIsTabForeignKey = false; //是否表外键,
_this.bolIsParentObj = false; //是否父对象,
_this.strPrimaryTypeId = ""; //主键类型ID,
_this.strPrimaryTypeName = ""; //主键类型名,
_this.strForeignKeyTabId = ""; //外键表ID,
_this.strForeignTabName = ""; //外键表,
_this.lngRegionId = 0; //区域Id,
_this.intColNum = 0; //列数,
_this.bolIsUseCtrl = false; //是否使用控件,
_this.strViewId = ""; //界面Id,
_this.strRegionTypeId = ""; //区域类型Id,
_this.strRegionTypeName = ""; //区域类型名称,
_this.lngTabFldId = 0; //表字段ID,
_this.strLabelCaption = ""; //标签标题,
_this.strCtlTypeId = ""; //控件类型号,
_this.strCtlTypeName = ""; //控件类型名,
_this.strCtlCnName = ""; //控件类型中文名,
_this.strCtlTypeAbbr = ""; //控件类型缩写,
_this.strDDLItemsOptionId = ""; //下拉框列表选项ID,
_this.strDDLItemsOptionName = ""; //下拉选项名,
_this.strDS_TabId = ""; //数据源表ID,
_this.strTabName = ""; //表名,
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
_this.strINOUTTypeName = ""; //INOUT类型名称,
_this.bolInUse = false; //是否在用,
_this.strPrjId = ""; //工程ID,
_this.strUpdUser = ""; //修改者,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
_this.strDS_TabName = ""; //数据源表,
_this.strDS_DataValueFieldName = ""; //数据源值字段,
_this.strDS_DataTextFieldName = ""; //数据源文本字段,
  return _this;
 }

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "mId", {
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
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "TabId", {
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
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "FldId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "FldName", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DataTypeName", {
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
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "FldLength", {
 get: function ()
{
return this.mintFldLength;
},
 set: function(value)
{
 this.mintFldLength = value;
    this.hmProperty["FldLength"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DataTypeId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "FieldTypeId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "FieldTypeName", {
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
/// 是否表中可空(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "IsTabNullable", {
 get: function ()
{
return this.mbolIsTabNullable;
},
 set: function(value)
{
 this.mbolIsTabNullable = value;
    this.hmProperty["IsTabNullable"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否表外键(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "IsTabForeignKey", {
 get: function ()
{
return this.mbolIsTabForeignKey;
},
 set: function(value)
{
 this.mbolIsTabForeignKey = value;
    this.hmProperty["IsTabForeignKey"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否父对象(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "IsParentObj", {
 get: function ()
{
return this.mbolIsParentObj;
},
 set: function(value)
{
 this.mbolIsParentObj = value;
    this.hmProperty["IsParentObj"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "PrimaryTypeId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "PrimaryTypeName", {
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
/// 外键表ID(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "ForeignKeyTabId", {
 get: function ()
{
return this.mstrForeignKeyTabId;
},
 set: function(value)
{
 this.mstrForeignKeyTabId = value;
    this.hmProperty["ForeignKeyTabId"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 外键表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "ForeignTabName", {
 get: function ()
{
return this.mstrForeignTabName;
},
 set: function(value)
{
 this.mstrForeignTabName = value;
    this.hmProperty["ForeignTabName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 区域Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "RegionId", {
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
/// 列数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "ColNum", {
 get: function ()
{
return this.mintColNum;
},
 set: function(value)
{
 this.mintColNum = value;
    this.hmProperty["ColNum"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否使用控件(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "IsUseCtrl", {
 get: function ()
{
return this.mbolIsUseCtrl;
},
 set: function(value)
{
 this.mbolIsUseCtrl = value;
    this.hmProperty["IsUseCtrl"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 界面Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "ViewId", {
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
/// 区域类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "RegionTypeId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "RegionTypeName", {
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
/// 表字段ID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "TabFldId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "LabelCaption", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "CtlTypeId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "CtlTypeName", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "CtlCnName", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "CtlTypeAbbr", {
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
/// 下拉框列表选项ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DDLItemsOptionId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DDLItemsOptionName", {
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
/// 数据源表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DS_TabId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "TabName", {
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
/// 数据源值字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DS_DataValueFieldId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DS_DataTextFieldId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DS_CondStr", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DS_SQLStr", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "ItemsString", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "ColSpan", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "ColIndex", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "Width", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "IsMultiRow", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "SeqNum", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "INOUTTypeId", {
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
/// INOUT类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "INOUTTypeName", {
 get: function ()
{
return this.mstrINOUTTypeName;
},
 set: function(value)
{
 this.mstrINOUTTypeName = value;
    this.hmProperty["INOUTTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvEditRegionFldsEN.prototype, "InUse", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "PrjId", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "UpdUser", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "UpdDate", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "Memo", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DS_TabName", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DS_DataValueFieldName", {
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
Object.defineProperty(clsvEditRegionFldsEN.prototype, "DS_DataTextFieldName", {
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
 /// 常量:"mId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_TabId", {
 get: function () {return "TabId";}  // 表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_FldId", {
 get: function () {return "FldId";}  // 字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_FldName", {
 get: function () {return "FldName";}  // 字段名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DataTypeName", {
 get: function () {return "DataTypeName";}  // 数据类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldLength"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_FldLength", {
 get: function () {return "FldLength";}  // 字段长度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DataTypeId", {
 get: function () {return "DataTypeId";}  // 数据类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_FieldTypeId", {
 get: function () {return "FieldTypeId";}  // 字段类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_FieldTypeName", {
 get: function () {return "FieldTypeName";}  // 字段类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsTabNullable"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_IsTabNullable", {
 get: function () {return "IsTabNullable";}  // 是否表中可空
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsTabForeignKey"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_IsTabForeignKey", {
 get: function () {return "IsTabForeignKey";}  // 是否表外键
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsParentObj"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_IsParentObj", {
 get: function () {return "IsParentObj";}  // 是否父对象
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_PrimaryTypeId", {
 get: function () {return "PrimaryTypeId";}  // 主键类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_PrimaryTypeName", {
 get: function () {return "PrimaryTypeName";}  // 主键类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ForeignKeyTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_ForeignKeyTabId", {
 get: function () {return "ForeignKeyTabId";}  // 外键表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ForeignTabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_ForeignTabName", {
 get: function () {return "ForeignTabName";}  // 外键表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_RegionId", {
 get: function () {return "RegionId";}  // 区域Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_ColNum", {
 get: function () {return "ColNum";}  // 列数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsUseCtrl"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_IsUseCtrl", {
 get: function () {return "IsUseCtrl";}  // 是否使用控件
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_ViewId", {
 get: function () {return "ViewId";}  // 界面Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_RegionTypeId", {
 get: function () {return "RegionTypeId";}  // 区域类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_RegionTypeName", {
 get: function () {return "RegionTypeName";}  // 区域类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_TabFldId", {
 get: function () {return "TabFldId";}  // 表字段ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"LabelCaption"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_LabelCaption", {
 get: function () {return "LabelCaption";}  // 标签标题
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_CtlTypeId", {
 get: function () {return "CtlTypeId";}  // 控件类型号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_CtlTypeName", {
 get: function () {return "CtlTypeName";}  // 控件类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_CtlCnName", {
 get: function () {return "CtlCnName";}  // 控件类型中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeAbbr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_CtlTypeAbbr", {
 get: function () {return "CtlTypeAbbr";}  // 控件类型缩写
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DDLItemsOptionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DDLItemsOptionId", {
 get: function () {return "DDLItemsOptionId";}  // 下拉框列表选项ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DDLItemsOptionName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DDLItemsOptionName", {
 get: function () {return "DDLItemsOptionName";}  // 下拉选项名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DS_TabId", {
 get: function () {return "DS_TabId";}  // 数据源表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_TabName", {
 get: function () {return "TabName";}  // 表名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataValueFieldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DS_DataValueFieldId", {
 get: function () {return "DS_DataValueFieldId";}  // 数据源值字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataTextFieldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DS_DataTextFieldId", {
 get: function () {return "DS_DataTextFieldId";}  // 数据源文本字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_CondStr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DS_CondStr", {
 get: function () {return "DS_CondStr";}  // 数据源条件串
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_SQLStr"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DS_SQLStr", {
 get: function () {return "DS_SQLStr";}  // 数据源SQL串
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ItemsString"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_ItemsString", {
 get: function () {return "ItemsString";}  // 列表项串
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColSpan"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_ColSpan", {
 get: function () {return "ColSpan";}  // 跨列数
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColIndex"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_ColIndex", {
 get: function () {return "ColIndex";}  // 列序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Width"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_Width", {
 get: function () {return "Width";}  // 宽
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsMultiRow"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_IsMultiRow", {
 get: function () {return "IsMultiRow";}  // 是否多行
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SeqNum"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_SeqNum", {
 get: function () {return "SeqNum";}  // 字段序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INOUTTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_INOUTTypeId", {
 get: function () {return "INOUTTypeId";}  // INOUT类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"INOUTTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_INOUTTypeName", {
 get: function () {return "INOUTTypeName";}  // INOUT类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"InUse"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_InUse", {
 get: function () {return "InUse";}  // 是否在用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_TabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DS_TabName", {
 get: function () {return "DS_TabName";}  // 数据源表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataValueFieldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DS_DataValueFieldName", {
 get: function () {return "DS_DataValueFieldName";}  // 数据源值字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DS_DataTextFieldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvEditRegionFldsEN, "con_DS_DataTextFieldName", {
 get: function () {return "DS_DataTextFieldName";}  // 数据源文本字段
,
    enumerable: true,
    configurable: true
});

clsvEditRegionFldsEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvEditRegionFldsEN._CurrTabName = "vEditRegionFlds"; //当前表名,与该类相关的表名
clsvEditRegionFldsEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvEditRegionFldsEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvEditRegionFldsEN = clsvEditRegionFldsEN;
});