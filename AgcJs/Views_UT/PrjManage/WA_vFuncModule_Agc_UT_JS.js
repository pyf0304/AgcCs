
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_vFuncModule_Agc_UT_JS
 表名:vFuncModule_Agc(00050125)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:07
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:工程管理
 模块英文名:PrjManage
 框架-层名:WA_界面UT后台RJ(WA_ViewUTScriptCSRJ)
 编程语言:JavaScript
 == == == == == == == == == == == == 
 */
(function(factory) {
if (typeof module === "object" && typeof module.exports === "object")
{
var v = factory(require, exports);
if (v !== undefined) module.exports = v;
}
else if (typeof define === "function" && define.amd)
{
define(["require", "exports", "../../Js/L0_Entity/PrjManage/clsvFuncModule_AgcEN.js","../../Js/L3_ForWApi/PrjManage/clsvFuncModule_AgcWApi.js","../../Js/L2_BLL/PrjManage/clsvFuncModule_AgcBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsvFuncModule_AgcEN_js_1 = require("../../Js/L0_Entity/PrjManage/clsvFuncModule_AgcEN.js");
var clsvFuncModule_AgcWApi_js_1 = require("../../Js/L3_ForWApi/PrjManage/clsvFuncModule_AgcWApi.js");
var clsvFuncModule_AgcBL_js_1 = require("../../Js/L2_BLL/PrjManage/clsvFuncModule_AgcBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_vFuncModule_Agc_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_vFuncModule_Agc_UT_JS = /** @class */ (function() {
function WA_vFuncModule_Agc_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vFuncModule_Agc_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var strFuncModuleAgcId = strKeyId;
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.IsExist(strFuncModuleAgcId);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "关键字:[" +strKeyId + "] 的记录不存在!";
$('#lblResult1').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "关键字:[" +strKeyId + "]的相关记录存在!";
$('#lblResult1').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "检查相应关键字的记录存在不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist_Cache)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vFuncModule_Agc_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var strFuncModuleAgcId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.IsExist_Cache(strFuncModuleAgcId, strPrjId);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "关键字:[" +strKeyId + "] 的记录不存在!";
$('#lblResult2').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "关键字:[" +strKeyId + "]的相关记录存在!";
$('#lblResult2').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "检查相应关键字的记录存在不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExistRecord)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vFuncModule_Agc_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.IsExistRecord(strWhereCond);
var returnBool = responseText;
if (returnBool == false)
{
strWhereCond = $('#txtstrWhereCond3').val();
var strInfo = "根据条件:[" +strWhereCond + "] 的记录不存在!";
$('#lblResult3').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
strWhereCond = $('#txtstrWhereCond3').val();
var strInfo = "根据条件:[" +strWhereCond + "]的相关记录存在!";
$('#lblResult3').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "检查条件的记录存在不成功, " +(e) + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExistRecord_Cache)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vFuncModule_Agc_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objvFuncModule_Agc_Cond = new clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN();
objvFuncModule_Agc_Cond.SetCondFldValue(clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFuncModule_Agc_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFuncModule_Agc_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFuncModule_AgcEN_Sim = clsvFuncModule_AgcBL_js_1.clsvFuncModule_AgcBL.GetSimObjFromObj(objvFuncModule_Agc_Cond);
console.log(objvFuncModule_AgcEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.IsExistRecord_Cache(objvFuncModule_Agc_Cond, strPrjId);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objvFuncModule_Agc_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objvFuncModule_Agc_Cond) + "]的相关记录存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "检查条件的记录存在不成功, " +(e) + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 获取某一条件的记录数
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetRecCountByCond)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vFuncModule_Agc_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetRecCountByCond(strWhereCond);
var returnInt = Number(responseText);
strWhereCond = $('#txtstrWhereCond5').val();
var strInfo = "根据条件:" +strWhereCond + "的记录数:" +returnInt + "!";
$('#lblResult5').val(strInfo);
//显示信息框
alert(strInfo);
}
catch(e)
{
var strMsg = "获取某一条件的记录数不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 获取某一条件的记录数
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetRecCountByCond_Cache)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vFuncModule_Agc_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objvFuncModule_Agc_Cond = new clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN();
objvFuncModule_Agc_Cond.SetCondFldValue(clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFuncModule_Agc_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objvFuncModule_Agc_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFuncModule_AgcEN_Sim = clsvFuncModule_AgcBL_js_1.clsvFuncModule_AgcBL.GetSimObjFromObj(objvFuncModule_Agc_Cond);
console.log(objvFuncModule_AgcEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetRecCountByCond_Cache(objvFuncModule_Agc_Cond, strPrjId);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objvFuncModule_Agc_Cond) + "]的记录数:" +returnInt + "!";
$('#lblResult6').val(strInfo);
//显示信息框
alert(strInfo);
}
catch(e)
{
var strMsg = "获取某一条件的记录数不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的第一条记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetFirstObj)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetFirstObj(strWhereCond);
var objvFuncModule_AgcEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objvFuncModule_AgcEN.FuncModuleAgcId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvFuncModule_AgcObj("divList15", objvFuncModule_AgcEN);
}
catch(e)
{
var strMsg = "根据条件获取相应的第一条记录的对象不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjByKey)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjByFuncModuleAgcId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var strFuncModuleAgcId = strKeyId;
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
var objvFuncModule_AgcEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvFuncModule_AgcEN.FuncModuleAgcId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvFuncModule_AgcObj("divList16", objvFuncModule_AgcEN);
}
catch(e)
{
var strMsg = "根据关键字获取相应的记录的对象不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjByKey_Cache)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjByFuncModuleAgcId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var strFuncModuleAgcId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjByFuncModuleAgcId_Cache(strFuncModuleAgcId, strPrjId);
var objvFuncModule_AgcEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvFuncModule_AgcEN.FuncModuleAgcId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvFuncModule_AgcObj("divList17", objvFuncModule_AgcEN);
}
catch(e)
{
var strMsg = "根据关键字获取相应的记录的对象不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjByKey_WA_Cache)
 /// </summary>
 /// <param name = "sender">参数列表</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjByFuncModuleAgcId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var strFuncModuleAgcId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjByFuncModuleAgcId_WA_Cache(strFuncModuleAgcId, strPrjId);
var objvFuncModule_AgcEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvFuncModule_AgcEN.FuncModuleAgcId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvFuncModule_AgcObj("divList18", objvFuncModule_AgcEN);
}
catch(e)
{
var strMsg = "根据关键字获取相应的记录的对象不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjLst(strWhereCond);
var arrvFuncModule_AgcObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList19", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据条件获取相应的对象列表不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjLstByKeyLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrFuncModuleAgcId = strKeyIdLst.split(',');
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjLstByFuncModuleAgcIdLst(arrFuncModuleAgcId);
var arrvFuncModule_AgcObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList20", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据关键字列表获取相应对象列表不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrFuncModuleAgcId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjLstByFuncModuleAgcIdLst_Cache(arrFuncModuleAgcId, strPrjId);
var arrvFuncModule_AgcObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList21", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据关键字列表获取相应对象列表不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrFuncModuleAgcId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjLstByFuncModuleAgcIdLst_WA_Cache(arrFuncModuleAgcId, strPrjId);
var arrvFuncModule_AgcObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList22", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据关键字列表获取相应对象列表不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetSubObjLst_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objvFuncModule_Agc_Cond = new clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN();
objvFuncModule_Agc_Cond.SetCondFldValue(clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFuncModule_Agc_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFuncModule_Agc_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFuncModule_AgcEN_Sim = clsvFuncModule_AgcBL_js_1.clsvFuncModule_AgcBL.GetSimObjFromObj(objvFuncModule_Agc_Cond);
console.log(objvFuncModule_AgcEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetSubObjLst_Cache(objvFuncModule_Agc_Cond, strPrjId);
var arrvFuncModule_AgcObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvFuncModule_Agc_Cond) + "],共获取对象列表子集数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList23", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据条件对象获取相应的对象列表子集不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetSubObjLst_WA_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objvFuncModule_Agc_Cond = new clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN();
objvFuncModule_Agc_Cond.SetCondFldValue(clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFuncModule_Agc_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFuncModule_Agc_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFuncModule_AgcEN_Sim = clsvFuncModule_AgcBL_js_1.clsvFuncModule_AgcBL.GetSimObjFromObj(objvFuncModule_Agc_Cond);
console.log(objvFuncModule_AgcEN_Sim);
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetSubObjLst_WA_Cache(objvFuncModule_Agc_Cond);
var arrvFuncModule_AgcObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvFuncModule_Agc_Cond) + "],共获取对象列表子集数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList24", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据条件对象获取相应的对象列表子集不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的顶部对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetTopObjLst)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetTopObjLst_Click = async function() 
{
$('#hidDivName').val("divGetTopObjLst");
var intTopSize = Number($('#txtintTopSize25').val());
var strOrderBy = $('#txtstrOrderBy25').val();
var strWhereCond = $('#txtstrWhereCond25').val();
var objTopPara =
{
WhereCond: strWhereCond,
TopSize: intTopSize,
OrderBy: "",
IsCheckSQLAttack: "false",
Exclude:""
}
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetTopObjLst(objTopPara);
var arrvFuncModule_AgcObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList25", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据条件获取相应的顶部对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjLstByPager)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjLstByPager_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager");
var intPageIndex = Number($('#txtintPageIndex26').val());
var intPageSize = Number($('#txtintPageSize26').val());
var strOrderBy = $('#txtstrOrderBy26').val();
var strWhereCond = $('#txtstrWhereCond26').val();
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjLstByPager(objPagerPara);
var arrvFuncModule_AgcObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList26", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据条件获取相应的分页对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objvFuncModule_Agc_Cond = new clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN();
var strPrjId = "0001";
objvFuncModule_Agc_Cond.SetCondFldValue(clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFuncModule_Agc_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFuncModule_Agc_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFuncModule_AgcEN_Sim = clsvFuncModule_AgcBL_js_1.clsvFuncModule_AgcBL.GetSimObjFromObj(objvFuncModule_Agc_Cond);
console.log(objvFuncModule_AgcEN_Sim);
strWhereCond = JSON.stringify(objvFuncModule_AgcEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjLstByPager_Cache(objPagerPara, strPrjId);
var arrvFuncModule_AgcObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList27", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据条件获取相应的分页对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的分页对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjLstByPager_WA_Cache)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objvFuncModule_Agc_Cond = new clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN();
objvFuncModule_Agc_Cond.SetCondFldValue(clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFuncModule_Agc_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFuncModule_Agc_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFuncModule_AgcEN_Sim = clsvFuncModule_AgcBL_js_1.clsvFuncModule_AgcBL.GetSimObjFromObj(objvFuncModule_Agc_Cond);
console.log(objvFuncModule_AgcEN_Sim);
strWhereCond = JSON.stringify(objvFuncModule_AgcEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrvFuncModule_AgcObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList28", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据条件获取相应的分页对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内相应的对象列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetObjLstByRange)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.btnGetObjLstByRange_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByRange");
var strOrderBy = $('#txtstrOrderBy29').val();
var intMaxNum = Number($('#txtintMaxNum29').val());
var intMinNum = Number($('#txtintMinNum29').val());
var strWhereCond = $('#txtstrWhereCond29').val();
var objRangePara = {
  MaxNum: intMaxNum,
MinNum: intMinNum,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjLstByRange(objRangePara);
var arrvFuncModule_AgcObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrvFuncModule_AgcObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFuncModule_Agc("divList29", arrvFuncModule_AgcObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示vFuncModule_Agc对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrvFuncModule_AgcObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.BindTab_vFuncModule_Agc = function(divContainer, arrvFuncModule_AgcObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("FuncModuleAgcId"); sstrColHeader.push("功能模块Id");
sstrFldName.push("TabNum"); sstrColHeader.push("TabNum");
sstrFldName.push("ViewNum"); sstrColHeader.push("ViewNum");
sstrFldName.push("ObjNum"); sstrColHeader.push("ObjNum");
sstrFldName.push("PrjViewNum"); sstrColHeader.push("PrjViewNum");
sstrFldName.push("FuncModuleName"); sstrColHeader.push("功能模块名称");
sstrFldName.push("FuncModuleEnName"); sstrColHeader.push("功能模块英文名称");
sstrFldName.push("PrjId"); sstrColHeader.push("工程ID");
sstrFldName.push("PrjName"); sstrColHeader.push("工程名称");
sstrFldName.push("OrderNum"); sstrColHeader.push("序号");
sstrFldName.push("UseStateId"); sstrColHeader.push("使用状态Id");
sstrFldName.push("UseStateName"); sstrColHeader.push("使用状态名称");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
sstrFldName.push("UpdUser"); sstrColHeader.push("修改者");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrvFuncModule_AgcObjLst, sstrFldName, sstrColHeader, "FuncModuleAgcId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objvFuncModule_Agc">需要显示的对象</param>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.ShowvFuncModule_AgcObj = function(divContainer, objvFuncModule_Agc) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvFuncModule_Agc);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objvFuncModule_Agc[strKey];
var li = document.createElement("li");
li.innerHTML =  strKey + ":" + strValue;
ul.appendChild(li);
}
o.appendChild(ul);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_AddDPV_FldComparison)
 /// </summary>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_vFuncModule_Agc_UT_JS.GetArray(objLst) ;
let arrDiv = arrElement ;
let arrFind = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);
arrFind.forEach(x => x.innerHTML = "");
//var o = document.getElementById("div") ;
var strUrl = "../../Js/ShareView/_FldComparison.html";
console.log("divName4Edit:(In AddDPV_FldComparison)" + divName4Edit);
$.ajax({
url: strUrl,
method: "GET",
dataType: "html",
data: { },
success: function(data) {
console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
$('#' + divName4Edit).html(data);
//setTimeout(() => { clsFldComparisonObj_js_1.clsFldComparisonObj.BindTab(); }, 100);
clsFldComparisonObj_js_1.clsFldComparisonObj.BindTab();
},
error: (e) => {
console.log(e);
}
});
};

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetFldNameLst)
 /// </summary>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_vFuncModule_Agc_UT_JS.GetLocalObjLst = function() {
var strFldComparisonObjLst = $("#hidFldComparisonObjLst").val();
if (strFldComparisonObjLst == null || strFldComparisonObjLst == "")
{
return null;
}
var arrFldComparisonObj = JSON.parse(strFldComparisonObjLst);
return arrFldComparisonObj;
};

 /// <summary>
 /// 建立缓存
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_CreateCache)
 /// </summary>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：vFuncModule_Agc");
var strPrjId = "0001";
var strKey =  clsvFuncModule_AgcEN_js_1.clsvFuncModule_AgcEN._CurrTabName + "_" + strPrjId ;
const responseText = await clsvFuncModule_AgcWApi_js_1.clsvFuncModule_AgcWApi.GetObjLst_Cache(strPrjId);
console.log("获取缓存完成！vFuncModule_Agc");
var arrvFuncModule_AgcObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrvFuncModule_AgcObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrvFuncModule_AgcObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_vFuncModule_Agc_UT_JS: CreateCache()不成功！");
console.log(e);
var strInfo = "建立缓存Key=[" +strKey + "]失败:" +e + "!";
console.log(strInfo);
$('#lblPageStatusContent').html(strInfo);
}  
}

 /// <summary>
 /// 把Html控件集合转换成Array列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetArray)
 /// </summary>
 /// <returns></returns>
WA_vFuncModule_Agc_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_vFuncModule_Agc_UT_JS;
}());
exports.WA_vFuncModule_Agc_UT_JS = WA_vFuncModule_Agc_UT_JS;
});