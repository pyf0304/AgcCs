
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDDLItemsOptionEN
 表名:DDLItemsOption(00050059)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:31
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面控件管理
 模块英文名:ViewControlManage
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
 /// 下拉框列表选项(DDLItemsOption)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:GeneCode)
 /// </summary>
var clsDDLItemsOptionEN = /** @class */ (function (_super) {
__extends(clsDDLItemsOptionEN, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClassConstructor1)
/// </summary>
 function clsDDLItemsOptionEN()
 {
 var _this = _super.call(this) || this;
_this.mintAttributeCount = 4;
_this.AttributeName = new Array("DDLItemsOptionId", "DDLItemsOptionName", "DDLItemsOptionENName", "Memo");
_this.strDDLItemsOptionId = ""; //下拉框列表选项ID,
_this.strDDLItemsOptionName = ""; //下拉选项名,
_this.strDDLItemsOptionENName = ""; //下拉框列表选项英文名,
_this.strMemo = ""; //说明,
  return _this;
 }

/// <summary>
/// 下拉框列表选项ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDDLItemsOptionEN.prototype, "DDLItemsOptionId", {
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
Object.defineProperty(clsDDLItemsOptionEN.prototype, "DDLItemsOptionName", {
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
/// 下拉框列表选项英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDDLItemsOptionEN.prototype, "DDLItemsOptionENName", {
 get: function ()
{
return this.mstrDDLItemsOptionENName;
},
 set: function(value)
{
 this.mstrDDLItemsOptionENName = value;
    this.hmProperty["DDLItemsOptionENName"] = true;
},
    enumerable: true,
    configurable: true
});
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_ClsProperty)
/// </summary>
Object.defineProperty(clsDDLItemsOptionEN.prototype, "Memo", {
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
 /// 常量:"DDLItemsOptionId"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDDLItemsOptionEN, "con_DDLItemsOptionId", {
 get: function () {return "DDLItemsOptionId";}  // 下拉框列表选项ID
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DDLItemsOptionName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDDLItemsOptionEN, "con_DDLItemsOptionName", {
 get: function () {return "DDLItemsOptionName";}  // 下拉选项名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"DDLItemsOptionENName"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDDLItemsOptionEN, "con_DDLItemsOptionENName", {
 get: function () {return "DDLItemsOptionENName";}  // 下拉框列表选项英文名
,
    enumerable: true,
    configurable: true
});
 /// <summary>
 /// 常量:"Memo"
 /// (AutoGCLib.EntityLayerRJ4JavaScript:Gen_EN_PropertyNameConst)
 /// </summary>
Object.defineProperty(clsDDLItemsOptionEN, "con_Memo", {
 get: function () {return "Memo";}  // 说明
,
    enumerable: true,
    configurable: true
});

clsDDLItemsOptionEN.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){                
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
clsDDLItemsOptionEN._CurrTabName = "DDLItemsOption"; //当前表名,与该类相关的表名
clsDDLItemsOptionEN._KeyFldName = "DDLItemsOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
return clsDDLItemsOptionEN;
}(clsGeneralTab_js_1.clsGeneralTab));
exports.clsDDLItemsOptionEN = clsDDLItemsOptionEN;
});