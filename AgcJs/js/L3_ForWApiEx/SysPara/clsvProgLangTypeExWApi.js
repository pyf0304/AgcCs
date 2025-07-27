
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProgLangTypeExWApi
 表名:vProgLangType(00050405)
 生成代码版本:2020.04.08.1
 生成日期:2020/04/13 00:09:54
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
 框架-层名:WA_访问扩展层RJ(WA_AccessRJEx)
 编程语言:JavaScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsvProgLangTypeEN.js","clscommonfunc4web","clsstacktrace","clssyspara4webapi"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvProgLangTypeEN_js_1 = require("../../L0_Entity/SysPara/clsvProgLangTypeEN.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsSysPara4WebApi_js_1 = require("clssyspara4webapi");

 /// <summary>
 /// v编程语言类型(vProgLangType)
 /// (AutoGCLib.WA_AccessRJEx4JavaScript:GeneCode)
 /// </summary>
var ResponseData;
var clsvProgLangTypeExWApi = /** @class */ (function() {
function clsvProgLangTypeExWApi(pobjvProgLangTypeEN)
{
this.objvProgLangTypeEN = new clsvProgLangTypeEN_js_1.clsvProgLangTypeEN();
this.objvProgLangTypeEN = pobjvProgLangTypeEN;
}

 /// <summary>
 /// 获取WebApi的地址
 /// (AutoGCLib.WA_AccessRJEx4JavaScript:Gen_4WAEx_Js_GetWebApiUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
clsvProgLangTypeExWApi.GetWebApiUrl = function(strController, strAction) {
var strServiceUrl;
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
strServiceUrl = "http://" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort+ "/" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx+ "/" + strController+ "/" + strAction;
}
else {
strServiceUrl = "http://" +  clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local+ "/" +  clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx+ "/" + strController+ "/" + strAction;
}
return strServiceUrl;
}
clsvProgLangTypeExWApi.mstrController = "vProgLangTypeExApi";
return clsvProgLangTypeExWApi;
}());
exports.clsvProgLangTypeExWApi = clsvProgLangTypeExWApi;
});