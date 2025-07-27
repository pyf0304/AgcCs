
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDGRegionFldsEN
 表名:vDGRegionFlds(00050201)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:42
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
 /// vDG区域字段(vDGRegionFlds)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsvDGRegionFldsEN = /** @class */ (function (_super) {
__extends(clsvDGRegionFldsEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsvDGRegionFldsEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 44;
_this.AttributeName = new Array("mId", "TabId", "TabName", "FldId", "FldName", "DataTypeName", "FldLength", "Caption", "MaxValue", "MinValue", "IsNeedTransCode", "DataTypeId", "PrjId", "FieldTypeId", "FieldTypeName", "IsTabNullable", "IsTabForeignKey", "IsParentObj", "PrimaryTypeId", "PrimaryTypeName", "ForeignKeyTabId", "SequenceNumber", "ForeignTabName", "RegionId", "RegionName", "ViewId", "ViewName", "RegionTypeName", "TabFldId", "ColIndex", "ColCaption", "CtlTypeId", "CtlTypeName", "CtlCnName", "DgFuncTypeId", "DgFuncTypeName", "IsNeedSort", "IsTransToChkBox", "IsVisible", "IsFuncFld", "InUse", "UpdUser", "UpdDate", "Memo");
_this.lngmId = 0; //mId,
_this.strTabId = ""; //表ID,
_this.strTabName = ""; //表名,
_this.strFldId = ""; //字段Id,
_this.strFldName = ""; //字段名,
_this.strDataTypeName = ""; //数据类型名称,
_this.intFldLength = 0; //字段长度,
_this.strCaption = ""; //标题,
_this.strMaxValue = ""; //最大值,
_this.strMinValue = ""; //最小值,
_this.bolIsNeedTransCode = false; //是否需要转换代码,
_this.strDataTypeId = ""; //数据类型Id,
_this.strPrjId = ""; //工程ID,
_this.strFieldTypeId = ""; //字段类型Id,
_this.strFieldTypeName = ""; //字段类型名,
_this.bolIsTabNullable = false; //是否表中可空,
_this.bolIsTabForeignKey = false; //是否表外键,
_this.bolIsParentObj = false; //是否父对象,
_this.strPrimaryTypeId = ""; //主键类型ID,
_this.strPrimaryTypeName = ""; //主键类型名,
_this.strForeignKeyTabId = ""; //外键表ID,
_this.intSequenceNumber = 0; //顺序号,
_this.strForeignTabName = ""; //外键表,
_this.lngRegionId = 0; //区域Id,
_this.strRegionName = ""; //区域名称,
_this.strViewId = ""; //界面Id,
_this.strViewName = ""; //界面名称,
_this.strRegionTypeName = ""; //区域类型名称,
_this.lngTabFldId = 0; //表字段ID,
_this.intColIndex = 0; //列序号,
_this.strColCaption = ""; //列标题,
_this.strCtlTypeId = ""; //控件类型号,
_this.strCtlTypeName = ""; //控件类型名,
_this.strCtlCnName = ""; //控件类型中文名,
_this.strDgFuncTypeId = ""; //Dg功能类型Id,
_this.strDgFuncTypeName = ""; //Dg功能类型名,
_this.bolIsNeedSort = false; //是否需要排序,
_this.bolIsTransToChkBox = false; //是否转换成CheckBox,
_this.bolIsVisible = false; //是否显示,
_this.bolIsFuncFld = false; //是否功能字段,
_this.bolInUse = false; //是否在用,
_this.strUpdUser = ""; //修改者,
_this.strUpdDate = ""; //修改日期,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "mId", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "TabId", {
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
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "TabName", {
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
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "FldId", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "FldName", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "DataTypeName", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "FldLength", {
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
/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "Caption", {
 get: function ()
{
return this.mstrCaption;
},
 set: function(value)
{
 this.mstrCaption = value;
    this.hmProperty["Caption"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 最大值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "MaxValue", {
 get: function ()
{
return this.mstrMaxValue;
},
 set: function(value)
{
 this.mstrMaxValue = value;
    this.hmProperty["MaxValue"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 最小值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "MinValue", {
 get: function ()
{
return this.mstrMinValue;
},
 set: function(value)
{
 this.mstrMinValue = value;
    this.hmProperty["MinValue"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要转换代码(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "IsNeedTransCode", {
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
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "DataTypeId", {
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
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "PrjId", {
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
/// 字段类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "FieldTypeId", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "FieldTypeName", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "IsTabNullable", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "IsTabForeignKey", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "IsParentObj", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "PrimaryTypeId", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "PrimaryTypeName", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "ForeignKeyTabId", {
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
/// 顺序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "SequenceNumber", {
 get: function ()
{
return this.mintSequenceNumber;
},
 set: function(value)
{
 this.mintSequenceNumber = value;
    this.hmProperty["SequenceNumber"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 外键表(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "ForeignTabName", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "RegionId", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "RegionName", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "ViewId", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "ViewName", {
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
/// 区域类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "RegionTypeName", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "TabFldId", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "ColIndex", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "ColCaption", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "CtlTypeId", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "CtlTypeName", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "CtlCnName", {
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
/// Dg功能类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "DgFuncTypeId", {
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
/// Dg功能类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "DgFuncTypeName", {
 get: function ()
{
return this.mstrDgFuncTypeName;
},
 set: function(value)
{
 this.mstrDgFuncTypeName = value;
    this.hmProperty["DgFuncTypeName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 是否需要排序(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "IsNeedSort", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "IsTransToChkBox", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "IsVisible", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "IsFuncFld", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "InUse", {
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
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsvDGRegionFldsEN.prototype, "UpdUser", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "UpdDate", {
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
Object.defineProperty(clsvDGRegionFldsEN.prototype, "Memo", {
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
 /// 常量:"mId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_mId", {
 get: function () {return "mId";}  // mId
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_TabId", {
 get: function () {return "TabId";}  // 表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_TabName", {
 get: function () {return "TabName";}  // 表名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_FldId", {
 get: function () {return "FldId";}  // 字段Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_FldName", {
 get: function () {return "FldName";}  // 字段名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_DataTypeName", {
 get: function () {return "DataTypeName";}  // 数据类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FldLength"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_FldLength", {
 get: function () {return "FldLength";}  // 字段长度
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Caption"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_Caption", {
 get: function () {return "Caption";}  // 标题
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MaxValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_MaxValue", {
 get: function () {return "MaxValue";}  // 最大值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"MinValue"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_MinValue", {
 get: function () {return "MinValue";}  // 最小值
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedTransCode"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_IsNeedTransCode", {
 get: function () {return "IsNeedTransCode";}  // 是否需要转换代码
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DataTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_DataTypeId", {
 get: function () {return "DataTypeId";}  // 数据类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrjId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_PrjId", {
 get: function () {return "PrjId";}  // 工程ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_FieldTypeId", {
 get: function () {return "FieldTypeId";}  // 字段类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"FieldTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_FieldTypeName", {
 get: function () {return "FieldTypeName";}  // 字段类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsTabNullable"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_IsTabNullable", {
 get: function () {return "IsTabNullable";}  // 是否表中可空
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsTabForeignKey"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_IsTabForeignKey", {
 get: function () {return "IsTabForeignKey";}  // 是否表外键
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsParentObj"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_IsParentObj", {
 get: function () {return "IsParentObj";}  // 是否父对象
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_PrimaryTypeId", {
 get: function () {return "PrimaryTypeId";}  // 主键类型ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_PrimaryTypeName", {
 get: function () {return "PrimaryTypeName";}  // 主键类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ForeignKeyTabId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_ForeignKeyTabId", {
 get: function () {return "ForeignKeyTabId";}  // 外键表ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"SequenceNumber"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_SequenceNumber", {
 get: function () {return "SequenceNumber";}  // 顺序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ForeignTabName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_ForeignTabName", {
 get: function () {return "ForeignTabName";}  // 外键表
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_RegionId", {
 get: function () {return "RegionId";}  // 区域Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_RegionName", {
 get: function () {return "RegionName";}  // 区域名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_ViewId", {
 get: function () {return "ViewId";}  // 界面Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ViewName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_ViewName", {
 get: function () {return "ViewName";}  // 界面名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"RegionTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_RegionTypeName", {
 get: function () {return "RegionTypeName";}  // 区域类型名称
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"TabFldId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_TabFldId", {
 get: function () {return "TabFldId";}  // 表字段ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColIndex"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_ColIndex", {
 get: function () {return "ColIndex";}  // 列序号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"ColCaption"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_ColCaption", {
 get: function () {return "ColCaption";}  // 列标题
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_CtlTypeId", {
 get: function () {return "CtlTypeId";}  // 控件类型号
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_CtlTypeName", {
 get: function () {return "CtlTypeName";}  // 控件类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"CtlCnName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_CtlCnName", {
 get: function () {return "CtlCnName";}  // 控件类型中文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DgFuncTypeId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_DgFuncTypeId", {
 get: function () {return "DgFuncTypeId";}  // Dg功能类型Id
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DgFuncTypeName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_DgFuncTypeName", {
 get: function () {return "DgFuncTypeName";}  // Dg功能类型名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsNeedSort"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_IsNeedSort", {
 get: function () {return "IsNeedSort";}  // 是否需要排序
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsTransToChkBox"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_IsTransToChkBox", {
 get: function () {return "IsTransToChkBox";}  // 是否转换成CheckBox
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsVisible"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_IsVisible", {
 get: function () {return "IsVisible";}  // 是否显示
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"IsFuncFld"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_IsFuncFld", {
 get: function () {return "IsFuncFld";}  // 是否功能字段
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"InUse"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_InUse", {
 get: function () {return "InUse";}  // 是否在用
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdUser"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_UpdUser", {
 get: function () {return "UpdUser";}  // 修改者
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"UpdDate"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_UpdDate", {
 get: function () {return "UpdDate";}  // 修改日期
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsvDGRegionFldsEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsvDGRegionFldsEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsvDGRegionFldsEN._CurrTabName = "vDGRegionFlds"; //当前表名,与该类相关的表名
clsvDGRegionFldsEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsvDGRegionFldsEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsvDGRegionFldsEN = clsvDGRegionFldsEN;
});