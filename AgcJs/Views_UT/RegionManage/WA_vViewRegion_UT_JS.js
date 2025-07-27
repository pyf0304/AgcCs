
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_vViewRegion_UT_JS
 表名:vViewRegion(00050199)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:23
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
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
define(["require", "exports", "../../Js/L0_Entity/RegionManage/clsvViewRegionEN.js","../../Js/L3_ForWApi/RegionManage/clsvViewRegionWApi.js","../../Js/L2_BLL/RegionManage/clsvViewRegionBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsvViewRegionEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsvViewRegionEN.js");
var clsvViewRegionWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsvViewRegionWApi.js");
var clsvViewRegionBL_js_1 = require("../../Js/L2_BLL/RegionManage/clsvViewRegionBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_vViewRegion_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_vViewRegion_UT_JS = /** @class */ (function() {
function WA_vViewRegion_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vViewRegion_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var lngRegionId = Number(strKeyId);
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.IsExist(lngRegionId);
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
WA_vViewRegion_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var lngRegionId = Number(strKeyId);
try
{
var strPrjId = "0001";
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.IsExist_Cache(lngRegionId, strPrjId);
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
WA_vViewRegion_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.IsExistRecord(strWhereCond);
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
WA_vViewRegion_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objvViewRegion_Cond = new clsvViewRegionEN_js_1.clsvViewRegionEN();
objvViewRegion_Cond.SetCondFldValue(clsvViewRegionEN_js_1.clsvViewRegionEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vViewRegion_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvViewRegion_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvViewRegionEN_Sim = clsvViewRegionBL_js_1.clsvViewRegionBL.GetSimObjFromObj(objvViewRegion_Cond);
console.log(objvViewRegionEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.IsExistRecord_Cache(objvViewRegion_Cond, strPrjId);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objvViewRegion_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objvViewRegion_Cond) + "]的相关记录存在!";
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
WA_vViewRegion_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetRecCountByCond(strWhereCond);
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
WA_vViewRegion_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objvViewRegion_Cond = new clsvViewRegionEN_js_1.clsvViewRegionEN();
objvViewRegion_Cond.SetCondFldValue(clsvViewRegionEN_js_1.clsvViewRegionEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vViewRegion_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objvViewRegion_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvViewRegionEN_Sim = clsvViewRegionBL_js_1.clsvViewRegionBL.GetSimObjFromObj(objvViewRegion_Cond);
console.log(objvViewRegionEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetRecCountByCond_Cache(objvViewRegion_Cond, strPrjId);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objvViewRegion_Cond) + "]的记录数:" +returnInt + "!";
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
WA_vViewRegion_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetFirstObj(strWhereCond);
var objvViewRegionEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objvViewRegionEN.RegionId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvViewRegionObj("divList15", objvViewRegionEN);
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
WA_vViewRegion_UT_JS.btnGetObjByRegionId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var lngRegionId = Number(strKeyId);
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjByRegionId(lngRegionId);
var objvViewRegionEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvViewRegionEN.RegionId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvViewRegionObj("divList16", objvViewRegionEN);
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
WA_vViewRegion_UT_JS.btnGetObjByRegionId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var lngRegionId = Number(strKeyId);
try
{
var strPrjId = "0001";
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjByRegionId_Cache(lngRegionId, strPrjId);
var objvViewRegionEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvViewRegionEN.RegionId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvViewRegionObj("divList17", objvViewRegionEN);
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
WA_vViewRegion_UT_JS.btnGetObjByRegionId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var lngRegionId = Number(strKeyId);
try
{
var strPrjId = "0001";
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjByRegionId_WA_Cache(lngRegionId, strPrjId);
var objvViewRegionEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvViewRegionEN.RegionId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvViewRegionObj("divList18", objvViewRegionEN);
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
WA_vViewRegion_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLst(strWhereCond);
var arrvViewRegionObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList19", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrRegionId = strKeyIdLst.split(',');
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByRegionIdLst(arrRegionId);
var arrvViewRegionObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList20", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrRegionId2 = strKeyIdLst.split(',');
var arrRegionId = arrRegionId2.map(x=>Number(x));
try
{
var strPrjId = "0001";
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByRegionIdLst_Cache(arrRegionId, strPrjId);
var arrvViewRegionObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList21", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrRegionId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByRegionIdLst_WA_Cache(arrRegionId, strPrjId);
var arrvViewRegionObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList22", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objvViewRegion_Cond = new clsvViewRegionEN_js_1.clsvViewRegionEN();
objvViewRegion_Cond.SetCondFldValue(clsvViewRegionEN_js_1.clsvViewRegionEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vViewRegion_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvViewRegion_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvViewRegionEN_Sim = clsvViewRegionBL_js_1.clsvViewRegionBL.GetSimObjFromObj(objvViewRegion_Cond);
console.log(objvViewRegionEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetSubObjLst_Cache(objvViewRegion_Cond, strPrjId);
var arrvViewRegionObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvViewRegion_Cond) + "],共获取对象列表子集数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList23", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objvViewRegion_Cond = new clsvViewRegionEN_js_1.clsvViewRegionEN();
objvViewRegion_Cond.SetCondFldValue(clsvViewRegionEN_js_1.clsvViewRegionEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vViewRegion_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvViewRegion_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvViewRegionEN_Sim = clsvViewRegionBL_js_1.clsvViewRegionBL.GetSimObjFromObj(objvViewRegion_Cond);
console.log(objvViewRegionEN_Sim);
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetSubObjLst_WA_Cache(objvViewRegion_Cond);
var arrvViewRegionObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvViewRegion_Cond) + "],共获取对象列表子集数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList24", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetTopObjLst(objTopPara);
var arrvViewRegionObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList25", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByPager(objPagerPara);
var arrvViewRegionObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList26", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objvViewRegion_Cond = new clsvViewRegionEN_js_1.clsvViewRegionEN();
var strPrjId = "0001";
objvViewRegion_Cond.SetCondFldValue(clsvViewRegionEN_js_1.clsvViewRegionEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vViewRegion_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvViewRegion_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvViewRegionEN_Sim = clsvViewRegionBL_js_1.clsvViewRegionBL.GetSimObjFromObj(objvViewRegion_Cond);
console.log(objvViewRegionEN_Sim);
strWhereCond = JSON.stringify(objvViewRegionEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByPager_Cache(objPagerPara, strPrjId);
var arrvViewRegionObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList27", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objvViewRegion_Cond = new clsvViewRegionEN_js_1.clsvViewRegionEN();
objvViewRegion_Cond.SetCondFldValue(clsvViewRegionEN_js_1.clsvViewRegionEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vViewRegion_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvViewRegion_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvViewRegionEN_Sim = clsvViewRegionBL_js_1.clsvViewRegionBL.GetSimObjFromObj(objvViewRegion_Cond);
console.log(objvViewRegionEN_Sim);
strWhereCond = JSON.stringify(objvViewRegionEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrvViewRegionObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList28", arrvViewRegionObjLst);
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
WA_vViewRegion_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByRange(objRangePara);
var arrvViewRegionObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrvViewRegionObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vViewRegion("divList29", arrvViewRegionObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示vViewRegion对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrvViewRegionObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_vViewRegion_UT_JS.BindTab_vViewRegion = function(divContainer, arrvViewRegionObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("RegionId"); sstrColHeader.push("区域Id");
sstrFldName.push("RegionName"); sstrColHeader.push("区域名称");
sstrFldName.push("ViewId"); sstrColHeader.push("界面Id");
sstrFldName.push("ViewName"); sstrColHeader.push("界面名称");
sstrFldName.push("ApplicationTypeId"); sstrColHeader.push("应用程序类型ID");
sstrFldName.push("ViewCnName"); sstrColHeader.push("视图中文名");
sstrFldName.push("RegionTypeId"); sstrColHeader.push("区域类型Id");
sstrFldName.push("RegionTypeName"); sstrColHeader.push("区域类型名称");
sstrFldName.push("RegionTypeSimName"); sstrColHeader.push("区域类型简名");
sstrFldName.push("RegionTypeOrderNum"); sstrColHeader.push("区域类型序号");
sstrFldName.push("RegionFunction"); sstrColHeader.push("区域功能");
sstrFldName.push("ClassName"); sstrColHeader.push("类名");
sstrFldName.push("Height"); sstrColHeader.push("高度");
sstrFldName.push("Width"); sstrColHeader.push("宽");
sstrFldName.push("OUTRelaTabId"); sstrColHeader.push("输出数据源表ID");
sstrFldName.push("INSQLDSTypeId"); sstrColHeader.push("输入数据源类型");
sstrFldName.push("INRelaTabId"); sstrColHeader.push("输入数据源表ID");
sstrFldName.push("OUTSQLDSTypeId"); sstrColHeader.push("输出数据源类型");
sstrFldName.push("InUse"); sstrColHeader.push("是否在用");
sstrFldName.push("PrjId"); sstrColHeader.push("工程ID");
sstrFldName.push("UpdUser"); sstrColHeader.push("修改者");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
sstrFldName.push("OUTSqlDsTypeName"); sstrColHeader.push("OUT数据源类型");
sstrFldName.push("OUTTabName"); sstrColHeader.push("OUT表");
sstrFldName.push("OUTTabCnName"); sstrColHeader.push("OUT表CH");
sstrFldName.push("INSqlDsTypeName"); sstrColHeader.push("IN数据源类型");
sstrFldName.push("INTabName"); sstrColHeader.push("IN表");
sstrFldName.push("INTabCnName"); sstrColHeader.push("IN表中文名");
sstrFldName.push("FeatureNum"); sstrColHeader.push("FeatureNum");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrvViewRegionObjLst, sstrFldName, sstrColHeader, "RegionId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objvViewRegion">需要显示的对象</param>
 /// <returns></returns>
WA_vViewRegion_UT_JS.ShowvViewRegionObj = function(divContainer, objvViewRegion) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvViewRegion);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objvViewRegion[strKey];
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
WA_vViewRegion_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_vViewRegion_UT_JS.GetArray(objLst) ;
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
WA_vViewRegion_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsvViewRegionEN_js_1.clsvViewRegionEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_vViewRegion_UT_JS.GetLocalObjLst = function() {
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
WA_vViewRegion_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：vViewRegion");
var strPrjId = "0001";
var strKey =  clsvViewRegionEN_js_1.clsvViewRegionEN._CurrTabName + "_" + strPrjId ;
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLst_Cache(strPrjId);
console.log("获取缓存完成！vViewRegion");
var arrvViewRegionObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrvViewRegionObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrvViewRegionObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_vViewRegion_UT_JS: CreateCache()不成功！");
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
WA_vViewRegion_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_vViewRegion_UT_JS;
}());
exports.WA_vViewRegion_UT_JS = WA_vViewRegion_UT_JS;
});