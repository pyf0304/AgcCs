
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_ViewRelaTab_QUDI_JSEx
 表名:ViewRelaTab(00050100)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:48:58
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
 框架-层名:WA_界面后台Ex_JS(WA_ViewScriptCSEx_JS)
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
(function(factory) {
if (typeof module === "object" && typeof module.exports === "object")
{
var v = factory(require, exports);
if (v !== undefined) module.exports = v;
}
else if (typeof define === "function" && define.amd)
{
define(["require", "exports", "./WA_ViewRelaTab_QUDI_JS.js","clscommonfunc4web"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var WA_ViewRelaTab_QUDI_JS_js_1 = require("./WA_ViewRelaTab_QUDI_JS.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
 /* WA_ViewRelaTab_QUDI_JSEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCSEx_JS4JavaScript:GeneCode)
*/
var WA_ViewRelaTab_QUDI_JSEx = /** @class */ (function(_super) {
__extends(WA_ViewRelaTab_QUDI_JSEx, _super);
function WA_ViewRelaTab_QUDI_JSEx()
{
return _super !== null && _super.apply(this, arguments) || this;
}
Object.defineProperty(WA_ViewRelaTab_QUDI_JSEx.prototype, "PageSize", {
get: function() { return 10;},
enumerable: true,
configurable: true
});


 /*
  按钮单击,用于调用Js函数中btn_Click
 (AutoGCLib.WA_ViewScriptCSEx_JS4JavaScript:Gen_WApi_JS_btn_Click)
 */
WA_ViewRelaTab_QUDI_JSEx.btn_Click = function(strCommandName, strKeyId) {
var objPage = new WA_ViewRelaTab_QUDI_JSEx();
switch (strCommandName)
{
case "Query":    //查询记录
objPage.btnQuery_Click();
break;
case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
ShowDialog('AddWithMaxId');
objPage.btnAddNewRecordWithMaxId_Click();
break;
case "AddNewRecord":            //添加记录
case "Create":            //添加记录
objPage.btnAddNewRecord_Click();
break;
case "UpdateRecord":            //修改记录
case "Update":            //修改记录
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
objPage.btnUpdateRecord_Click();
break;
case "CopyRecord":            //复制记录
case "Clone":            //复制记录
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要复制的记录！");
return;
}
objPage.btnCopyRecord_Click();
break;
case "DelRecord":            //删除记录
case "Delete":            //删除记录
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return;
}
objPage.btnDelRecord_Click();
break;
case "DelRecordBySign":            //按标志删除记录
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return;
}
objPage.btnDelRecordBySign_Click();
break;
case "UnDelRecordBySign":            //按标志恢复删除记录
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return;
}
objPage.btnUnDelRecordBySign_Click();
break;
case "GoTop":            //置顶记录
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要置顶的记录！");
return;
}
objPage.btnGoTop_Click();
break;
case "GoBottum":            //移底记录
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要移底的记录！");
return;
}
objPage.btnGoBottum_Click();
break;
case "UpMove":            //上移记录
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要上移的记录！");
return;
}
objPage.btnUpMove_Click();
break;
case "DownMove":            //下移记录
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要下移的记录！");
return;
}
objPage.btnDownMove_Click();
break;
case "ReOrder":            //重序记录
objPage.btnReOrder_Click();
break;
default:
var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
alert(strMsg);
break;
case "ExportExcel":            //导出Excel
alert("导出Excel功能还没有开通！");
break;
}
}
return WA_ViewRelaTab_QUDI_JSEx;
}(WA_ViewRelaTab_QUDI_JS_js_1.WA_ViewRelaTab_QUDI_JS));
exports.WA_ViewRelaTab_QUDI_JSEx = WA_ViewRelaTab_QUDI_JSEx;
});