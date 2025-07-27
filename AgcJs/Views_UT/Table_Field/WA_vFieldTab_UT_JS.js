
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_vFieldTab_UT_JS
 表名:vFieldTab(00050119)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:04
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
define(["require", "exports", "../../Js/L0_Entity/Table_Field/clsvFieldTabEN.js","../../Js/L3_ForWApi/Table_Field/clsvFieldTabWApi.js","../../Js/L2_BLL/Table_Field/clsvFieldTabBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsvFieldTabEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsvFieldTabEN.js");
var clsvFieldTabWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsvFieldTabWApi.js");
var clsvFieldTabBL_js_1 = require("../../Js/L2_BLL/Table_Field/clsvFieldTabBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_vFieldTab_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_vFieldTab_UT_JS = /** @class */ (function() {
function WA_vFieldTab_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vFieldTab_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var strFldId = strKeyId;
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.IsExist(strFldId);
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
WA_vFieldTab_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var strFldId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.IsExist_Cache(strFldId, strPrjId);
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
WA_vFieldTab_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.IsExistRecord(strWhereCond);
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
WA_vFieldTab_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objvFieldTab_Cond = new clsvFieldTabEN_js_1.clsvFieldTabEN();
objvFieldTab_Cond.SetCondFldValue(clsvFieldTabEN_js_1.clsvFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFieldTabEN_Sim = clsvFieldTabBL_js_1.clsvFieldTabBL.GetSimObjFromObj(objvFieldTab_Cond);
console.log(objvFieldTabEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.IsExistRecord_Cache(objvFieldTab_Cond, strPrjId);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objvFieldTab_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objvFieldTab_Cond) + "]的相关记录存在!";
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
WA_vFieldTab_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetRecCountByCond(strWhereCond);
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
WA_vFieldTab_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objvFieldTab_Cond = new clsvFieldTabEN_js_1.clsvFieldTabEN();
objvFieldTab_Cond.SetCondFldValue(clsvFieldTabEN_js_1.clsvFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objvFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFieldTabEN_Sim = clsvFieldTabBL_js_1.clsvFieldTabBL.GetSimObjFromObj(objvFieldTab_Cond);
console.log(objvFieldTabEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetRecCountByCond_Cache(objvFieldTab_Cond, strPrjId);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objvFieldTab_Cond) + "]的记录数:" +returnInt + "!";
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
WA_vFieldTab_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetFirstObj(strWhereCond);
var objvFieldTabEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objvFieldTabEN.FldId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvFieldTabObj("divList15", objvFieldTabEN);
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
WA_vFieldTab_UT_JS.btnGetObjByFldId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var strFldId = strKeyId;
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjByFldId(strFldId);
var objvFieldTabEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvFieldTabEN.FldId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvFieldTabObj("divList16", objvFieldTabEN);
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
WA_vFieldTab_UT_JS.btnGetObjByFldId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var strFldId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjByFldId_Cache(strFldId, strPrjId);
var objvFieldTabEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvFieldTabEN.FldId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvFieldTabObj("divList17", objvFieldTabEN);
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
WA_vFieldTab_UT_JS.btnGetObjByFldId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var strFldId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjByFldId_WA_Cache(strFldId, strPrjId);
var objvFieldTabEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvFieldTabEN.FldId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvFieldTabObj("divList18", objvFieldTabEN);
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
WA_vFieldTab_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjLst(strWhereCond);
var arrvFieldTabObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList19", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrFldId = strKeyIdLst.split(',');
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjLstByFldIdLst(arrFldId);
var arrvFieldTabObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList20", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrFldId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjLstByFldIdLst_Cache(arrFldId, strPrjId);
var arrvFieldTabObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList21", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrFldId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjLstByFldIdLst_WA_Cache(arrFldId, strPrjId);
var arrvFieldTabObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList22", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objvFieldTab_Cond = new clsvFieldTabEN_js_1.clsvFieldTabEN();
objvFieldTab_Cond.SetCondFldValue(clsvFieldTabEN_js_1.clsvFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFieldTabEN_Sim = clsvFieldTabBL_js_1.clsvFieldTabBL.GetSimObjFromObj(objvFieldTab_Cond);
console.log(objvFieldTabEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetSubObjLst_Cache(objvFieldTab_Cond, strPrjId);
var arrvFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvFieldTab_Cond) + "],共获取对象列表子集数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList23", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objvFieldTab_Cond = new clsvFieldTabEN_js_1.clsvFieldTabEN();
objvFieldTab_Cond.SetCondFldValue(clsvFieldTabEN_js_1.clsvFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFieldTabEN_Sim = clsvFieldTabBL_js_1.clsvFieldTabBL.GetSimObjFromObj(objvFieldTab_Cond);
console.log(objvFieldTabEN_Sim);
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetSubObjLst_WA_Cache(objvFieldTab_Cond);
var arrvFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvFieldTab_Cond) + "],共获取对象列表子集数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList24", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetTopObjLst(objTopPara);
var arrvFieldTabObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList25", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjLstByPager(objPagerPara);
var arrvFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList26", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objvFieldTab_Cond = new clsvFieldTabEN_js_1.clsvFieldTabEN();
var strPrjId = "0001";
objvFieldTab_Cond.SetCondFldValue(clsvFieldTabEN_js_1.clsvFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFieldTabEN_Sim = clsvFieldTabBL_js_1.clsvFieldTabBL.GetSimObjFromObj(objvFieldTab_Cond);
console.log(objvFieldTabEN_Sim);
strWhereCond = JSON.stringify(objvFieldTabEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjLstByPager_Cache(objPagerPara, strPrjId);
var arrvFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList27", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objvFieldTab_Cond = new clsvFieldTabEN_js_1.clsvFieldTabEN();
objvFieldTab_Cond.SetCondFldValue(clsvFieldTabEN_js_1.clsvFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vFieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvFieldTabEN_Sim = clsvFieldTabBL_js_1.clsvFieldTabBL.GetSimObjFromObj(objvFieldTab_Cond);
console.log(objvFieldTabEN_Sim);
strWhereCond = JSON.stringify(objvFieldTabEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrvFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList28", arrvFieldTabObjLst);
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
WA_vFieldTab_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjLstByRange(objRangePara);
var arrvFieldTabObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrvFieldTabObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vFieldTab("divList29", arrvFieldTabObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示vFieldTab对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrvFieldTabObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_vFieldTab_UT_JS.BindTab_vFieldTab = function(divContainer, arrvFieldTabObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("FldId"); sstrColHeader.push("字段Id");
sstrFldName.push("TabNum"); sstrColHeader.push("TabNum");
sstrFldName.push("PrjId"); sstrColHeader.push("工程ID");
sstrFldName.push("PrjName"); sstrColHeader.push("工程名称");
sstrFldName.push("FldName"); sstrColHeader.push("字段名");
sstrFldName.push("FldCnName"); sstrColHeader.push("字段中文详名");
sstrFldName.push("FldEnName"); sstrColHeader.push("字段英文详名");
sstrFldName.push("FldName_B"); sstrColHeader.push("字段名_后备");
sstrFldName.push("FldName_G"); sstrColHeader.push("字段名_国标");
sstrFldName.push("Caption"); sstrColHeader.push("标题");
sstrFldName.push("FieldTypeId"); sstrColHeader.push("字段类型Id");
sstrFldName.push("FieldTypeName"); sstrColHeader.push("字段类型名");
sstrFldName.push("FieldTypeENName"); sstrColHeader.push("字段类型英文名");
sstrFldName.push("DataTypeId"); sstrColHeader.push("数据类型Id");
sstrFldName.push("DataTypeName"); sstrColHeader.push("数据类型名称");
sstrFldName.push("OraDbType"); sstrColHeader.push("Ora数据类型");
sstrFldName.push("FldLength"); sstrColHeader.push("字段长度");
sstrFldName.push("FldPrecision"); sstrColHeader.push("精确度");
sstrFldName.push("FldInfo"); sstrColHeader.push("字段信息");
sstrFldName.push("IsNull"); sstrColHeader.push("是否可空");
sstrFldName.push("IsPrimaryKey"); sstrColHeader.push("是否主键");
sstrFldName.push("IsIdentity"); sstrColHeader.push("是否Identity");
sstrFldName.push("IsNationStandard"); sstrColHeader.push("是否国标");
sstrFldName.push("IsChecked"); sstrColHeader.push("是否核实");
sstrFldName.push("IsArchive"); sstrColHeader.push("是否存档");
sstrFldName.push("IsOnlyOne"); sstrColHeader.push("是否唯一");
sstrFldName.push("MaxValue"); sstrColHeader.push("最大值");
sstrFldName.push("MinValue"); sstrColHeader.push("最小值");
sstrFldName.push("DefaultValue"); sstrColHeader.push("缺省值");
sstrFldName.push("IsNeedTransCode"); sstrColHeader.push("是否需要转换代码");
sstrFldName.push("AppliedScope"); sstrColHeader.push("应用范围");
sstrFldName.push("FldStateId"); sstrColHeader.push("字段状态Id");
sstrFldName.push("CodeTabId"); sstrColHeader.push("CodeTabId");
sstrFldName.push("CodeTab_NameId"); sstrColHeader.push("CodeTab_NameId");
sstrFldName.push("CodeTab_CodeId"); sstrColHeader.push("CodeTab_CodeId");
sstrFldName.push("IsRootFld"); sstrColHeader.push("是否根字段");
sstrFldName.push("RootFldId"); sstrColHeader.push("根字段Id");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("UpdUser"); sstrColHeader.push("修改者");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
sstrFldName.push("CodeTab"); sstrColHeader.push("代码表");
sstrFldName.push("CodeTab_Name"); sstrColHeader.push("代码表_名称");
sstrFldName.push("CodeTab_Code"); sstrColHeader.push("代码表_代码");
sstrFldName.push("FldBName_B"); sstrColHeader.push("FldBName_B");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrvFieldTabObjLst, sstrFldName, sstrColHeader, "FldId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objvFieldTab">需要显示的对象</param>
 /// <returns></returns>
WA_vFieldTab_UT_JS.ShowvFieldTabObj = function(divContainer, objvFieldTab) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvFieldTab);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objvFieldTab[strKey];
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
WA_vFieldTab_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_vFieldTab_UT_JS.GetArray(objLst) ;
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
WA_vFieldTab_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsvFieldTabEN_js_1.clsvFieldTabEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_vFieldTab_UT_JS.GetLocalObjLst = function() {
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
WA_vFieldTab_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：vFieldTab");
var strPrjId = "0001";
var strKey =  clsvFieldTabEN_js_1.clsvFieldTabEN._CurrTabName + "_" + strPrjId ;
const responseText = await clsvFieldTabWApi_js_1.clsvFieldTabWApi.GetObjLst_Cache(strPrjId);
console.log("获取缓存完成！vFieldTab");
var arrvFieldTabObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrvFieldTabObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrvFieldTabObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_vFieldTab_UT_JS: CreateCache()不成功！");
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
WA_vFieldTab_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_vFieldTab_UT_JS;
}());
exports.WA_vFieldTab_UT_JS = WA_vFieldTab_UT_JS;
});