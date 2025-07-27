
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4ErrMsgENEx
 表名:vPrjTab4ErrMsg(00050206)
 生成代码版本:2020.04.08.1
 生成日期:2020/04/13 18:28:06
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
 框架-层名:实体扩展层RJ(EntityLayerRJEx)
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
 /// (AutoGCLib.EntityLayerRJEx4JavaScript:GeneCode)
 /// </summary>
var clsvPrjTab4ErrMsgENEx = /** @class */ (function (_super) {
__extends(clsvPrjTab4ErrMsgENEx, _super);

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayerRJEx4JavaScript:Gen_ENEx_ClassConstructor1)
/// </summary>
 function clsvPrjTab4ErrMsgENEx()
 {
 var _this = _super.call(this) || this;
  return _this;
 }
return clsvPrjTab4ErrMsgENEx;
}(clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN));
exports.clsvPrjTab4ErrMsgENEx = clsvPrjTab4ErrMsgENEx;
});