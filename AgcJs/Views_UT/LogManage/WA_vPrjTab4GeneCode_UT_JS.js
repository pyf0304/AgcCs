
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_vPrjTab4GeneCode_UT_JS
 表名:vPrjTab4GeneCode(00050284)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:12
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:日志管理
 模块英文名:LogManage
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
define(["require", "exports", "../../Js/L0_Entity/LogManage/clsvPrjTab4GeneCodeEN.js","../../Js/L3_ForWApi/LogManage/clsvPrjTab4GeneCodeWApi.js","../../Js/L2_BLL/LogManage/clsvPrjTab4GeneCodeBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsvPrjTab4GeneCodeEN_js_1 = require("../../Js/L0_Entity/LogManage/clsvPrjTab4GeneCodeEN.js");
var clsvPrjTab4GeneCodeWApi_js_1 = require("../../Js/L3_ForWApi/LogManage/clsvPrjTab4GeneCodeWApi.js");
var clsvPrjTab4GeneCodeBL_js_1 = require("../../Js/L2_BLL/LogManage/clsvPrjTab4GeneCodeBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_vPrjTab4GeneCode_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_vPrjTab4GeneCode_UT_JS = /** @class */ (function() {
function WA_vPrjTab4GeneCode_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vPrjTab4GeneCode_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var strTabId = strKeyId;
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.IsExist(strTabId);
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
WA_vPrjTab4GeneCode_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var strTabId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.IsExist_Cache(strTabId, strPrjId);
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
WA_vPrjTab4GeneCode_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.IsExistRecord(strWhereCond);
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
WA_vPrjTab4GeneCode_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objvPrjTab4GeneCode_Cond = new clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN();
objvPrjTab4GeneCode_Cond.SetCondFldValue(clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vPrjTab4GeneCode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvPrjTab4GeneCode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvPrjTab4GeneCodeEN_Sim = clsvPrjTab4GeneCodeBL_js_1.clsvPrjTab4GeneCodeBL.GetSimObjFromObj(objvPrjTab4GeneCode_Cond);
console.log(objvPrjTab4GeneCodeEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.IsExistRecord_Cache(objvPrjTab4GeneCode_Cond, strPrjId);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objvPrjTab4GeneCode_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objvPrjTab4GeneCode_Cond) + "]的相关记录存在!";
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
WA_vPrjTab4GeneCode_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetRecCountByCond(strWhereCond);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objvPrjTab4GeneCode_Cond = new clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN();
objvPrjTab4GeneCode_Cond.SetCondFldValue(clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vPrjTab4GeneCode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objvPrjTab4GeneCode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvPrjTab4GeneCodeEN_Sim = clsvPrjTab4GeneCodeBL_js_1.clsvPrjTab4GeneCodeBL.GetSimObjFromObj(objvPrjTab4GeneCode_Cond);
console.log(objvPrjTab4GeneCodeEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetRecCountByCond_Cache(objvPrjTab4GeneCode_Cond, strPrjId);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objvPrjTab4GeneCode_Cond) + "]的记录数:" +returnInt + "!";
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
WA_vPrjTab4GeneCode_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetFirstObj(strWhereCond);
var objvPrjTab4GeneCodeEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objvPrjTab4GeneCodeEN.TabId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvPrjTab4GeneCodeObj("divList15", objvPrjTab4GeneCodeEN);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjByTabId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var strTabId = strKeyId;
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjByTabId(strTabId);
var objvPrjTab4GeneCodeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvPrjTab4GeneCodeEN.TabId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvPrjTab4GeneCodeObj("divList16", objvPrjTab4GeneCodeEN);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjByTabId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var strTabId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjByTabId_Cache(strTabId, strPrjId);
var objvPrjTab4GeneCodeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvPrjTab4GeneCodeEN.TabId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvPrjTab4GeneCodeObj("divList17", objvPrjTab4GeneCodeEN);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjByTabId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var strTabId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjByTabId_WA_Cache(strTabId, strPrjId);
var objvPrjTab4GeneCodeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvPrjTab4GeneCodeEN.TabId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvPrjTab4GeneCodeObj("divList18", objvPrjTab4GeneCodeEN);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjLst(strWhereCond);
var arrvPrjTab4GeneCodeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList19", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrTabId = strKeyIdLst.split(',');
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjLstByTabIdLst(arrTabId);
var arrvPrjTab4GeneCodeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList20", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrTabId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjLstByTabIdLst_Cache(arrTabId, strPrjId);
var arrvPrjTab4GeneCodeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList21", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrTabId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjLstByTabIdLst_WA_Cache(arrTabId, strPrjId);
var arrvPrjTab4GeneCodeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList22", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objvPrjTab4GeneCode_Cond = new clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN();
objvPrjTab4GeneCode_Cond.SetCondFldValue(clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vPrjTab4GeneCode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvPrjTab4GeneCode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvPrjTab4GeneCodeEN_Sim = clsvPrjTab4GeneCodeBL_js_1.clsvPrjTab4GeneCodeBL.GetSimObjFromObj(objvPrjTab4GeneCode_Cond);
console.log(objvPrjTab4GeneCodeEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetSubObjLst_Cache(objvPrjTab4GeneCode_Cond, strPrjId);
var arrvPrjTab4GeneCodeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvPrjTab4GeneCode_Cond) + "],共获取对象列表子集数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList23", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objvPrjTab4GeneCode_Cond = new clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN();
objvPrjTab4GeneCode_Cond.SetCondFldValue(clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vPrjTab4GeneCode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvPrjTab4GeneCode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvPrjTab4GeneCodeEN_Sim = clsvPrjTab4GeneCodeBL_js_1.clsvPrjTab4GeneCodeBL.GetSimObjFromObj(objvPrjTab4GeneCode_Cond);
console.log(objvPrjTab4GeneCodeEN_Sim);
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetSubObjLst_WA_Cache(objvPrjTab4GeneCode_Cond);
var arrvPrjTab4GeneCodeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvPrjTab4GeneCode_Cond) + "],共获取对象列表子集数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList24", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetTopObjLst(objTopPara);
var arrvPrjTab4GeneCodeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList25", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjLstByPager(objPagerPara);
var arrvPrjTab4GeneCodeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList26", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objvPrjTab4GeneCode_Cond = new clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN();
var strPrjId = "0001";
objvPrjTab4GeneCode_Cond.SetCondFldValue(clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vPrjTab4GeneCode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvPrjTab4GeneCode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvPrjTab4GeneCodeEN_Sim = clsvPrjTab4GeneCodeBL_js_1.clsvPrjTab4GeneCodeBL.GetSimObjFromObj(objvPrjTab4GeneCode_Cond);
console.log(objvPrjTab4GeneCodeEN_Sim);
strWhereCond = JSON.stringify(objvPrjTab4GeneCodeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjLstByPager_Cache(objPagerPara, strPrjId);
var arrvPrjTab4GeneCodeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList27", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objvPrjTab4GeneCode_Cond = new clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN();
objvPrjTab4GeneCode_Cond.SetCondFldValue(clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vPrjTab4GeneCode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvPrjTab4GeneCode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvPrjTab4GeneCodeEN_Sim = clsvPrjTab4GeneCodeBL_js_1.clsvPrjTab4GeneCodeBL.GetSimObjFromObj(objvPrjTab4GeneCode_Cond);
console.log(objvPrjTab4GeneCodeEN_Sim);
strWhereCond = JSON.stringify(objvPrjTab4GeneCodeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrvPrjTab4GeneCodeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList28", arrvPrjTab4GeneCodeObjLst);
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
WA_vPrjTab4GeneCode_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjLstByRange(objRangePara);
var arrvPrjTab4GeneCodeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrvPrjTab4GeneCodeObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vPrjTab4GeneCode("divList29", arrvPrjTab4GeneCodeObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示vPrjTab4GeneCode对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrvPrjTab4GeneCodeObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_vPrjTab4GeneCode_UT_JS.BindTab_vPrjTab4GeneCode = function(divContainer, arrvPrjTab4GeneCodeObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("TabId"); sstrColHeader.push("表ID");
sstrFldName.push("FldNum"); sstrColHeader.push("字段数");
sstrFldName.push("GeneCodeDate"); sstrColHeader.push("生成代码日期");
sstrFldName.push("IsNeedGene"); sstrColHeader.push("是否需要生成");
sstrFldName.push("Version_GeneCode"); sstrColHeader.push("生成代码版本");
sstrFldName.push("ApplicationTypeId"); sstrColHeader.push("应用程序类型ID");
sstrFldName.push("TabName"); sstrColHeader.push("表名");
sstrFldName.push("TabCnName"); sstrColHeader.push("表中文名");
sstrFldName.push("PrjId"); sstrColHeader.push("工程ID");
sstrFldName.push("PrjName"); sstrColHeader.push("工程名称");
sstrFldName.push("IsNeedTransCode"); sstrColHeader.push("是否需要转换代码");
sstrFldName.push("SQLDSTypeId"); sstrColHeader.push("数据源类型");
sstrFldName.push("SqlDsTypeName"); sstrColHeader.push("Sql数据源名");
sstrFldName.push("TabStateId"); sstrColHeader.push("表状态ID");
sstrFldName.push("TabStateName"); sstrColHeader.push("表状态名称");
sstrFldName.push("TabName_B"); sstrColHeader.push("表名_后备");
sstrFldName.push("IsParaTab"); sstrColHeader.push("是否参数表");
sstrFldName.push("IsNationStandard"); sstrColHeader.push("是否国标");
sstrFldName.push("IsArchive"); sstrColHeader.push("是否存档");
sstrFldName.push("IsChecked"); sstrColHeader.push("是否核实");
sstrFldName.push("FuncModuleAgcId"); sstrColHeader.push("功能模块Id");
sstrFldName.push("FuncModuleName"); sstrColHeader.push("功能模块名称");
sstrFldName.push("FuncModuleEnName"); sstrColHeader.push("功能模块英文名称");
sstrFldName.push("Owner"); sstrColHeader.push("拥有者");
sstrFldName.push("IsReleToSqlTab"); sstrColHeader.push("是否与SQL表相关");
sstrFldName.push("KeyWord"); sstrColHeader.push("关键字");
sstrFldName.push("TabTypeId"); sstrColHeader.push("表类型Id");
sstrFldName.push("TabTypeName"); sstrColHeader.push("表类型名");
sstrFldName.push("TabMainTypeId"); sstrColHeader.push("表主类型Id");
sstrFldName.push("TabMainTypeName"); sstrColHeader.push("表主类型名");
sstrFldName.push("RelaTabId4View"); sstrColHeader.push("视图的相关表ID");
sstrFldName.push("OrderNum4Refer"); sstrColHeader.push("引用序号");
sstrFldName.push("IsNeedGeneIndexer"); sstrColHeader.push("是否需要生成索引器");
sstrFldName.push("PrimaryTypeId"); sstrColHeader.push("主键类型ID");
sstrFldName.push("PrimaryTypeName"); sstrColHeader.push("主键类型名");
sstrFldName.push("IsUseCache"); sstrColHeader.push("是否使用Cache");
sstrFldName.push("CacheClassifyField"); sstrColHeader.push("缓存分类字段");
sstrFldName.push("KeyFldId"); sstrColHeader.push("关键字段Id");
sstrFldName.push("KeyFldName"); sstrColHeader.push("关键字段名");
sstrFldName.push("UpdUserId"); sstrColHeader.push("修改用户Id");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
sstrFldName.push("ErrMsg2"); sstrColHeader.push("ErrMsg2");
sstrFldName.push("DataBaseName_Tab"); sstrColHeader.push("DataBaseName_Tab");
sstrFldName.push("UserId4GeneCode"); sstrColHeader.push("UserId4GeneCode");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrvPrjTab4GeneCodeObjLst, sstrFldName, sstrColHeader, "TabId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objvPrjTab4GeneCode">需要显示的对象</param>
 /// <returns></returns>
WA_vPrjTab4GeneCode_UT_JS.ShowvPrjTab4GeneCodeObj = function(divContainer, objvPrjTab4GeneCode) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvPrjTab4GeneCode);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objvPrjTab4GeneCode[strKey];
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
WA_vPrjTab4GeneCode_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_vPrjTab4GeneCode_UT_JS.GetArray(objLst) ;
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
WA_vPrjTab4GeneCode_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_vPrjTab4GeneCode_UT_JS.GetLocalObjLst = function() {
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
WA_vPrjTab4GeneCode_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：vPrjTab4GeneCode");
var strPrjId = "0001";
var strKey =  clsvPrjTab4GeneCodeEN_js_1.clsvPrjTab4GeneCodeEN._CurrTabName + "_" + strPrjId ;
const responseText = await clsvPrjTab4GeneCodeWApi_js_1.clsvPrjTab4GeneCodeWApi.GetObjLst_Cache(strPrjId);
console.log("获取缓存完成！vPrjTab4GeneCode");
var arrvPrjTab4GeneCodeObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrvPrjTab4GeneCodeObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrvPrjTab4GeneCodeObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_vPrjTab4GeneCode_UT_JS: CreateCache()不成功！");
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
WA_vPrjTab4GeneCode_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_vPrjTab4GeneCode_UT_JS;
}());
exports.WA_vPrjTab4GeneCode_UT_JS = WA_vPrjTab4GeneCode_UT_JS;
});