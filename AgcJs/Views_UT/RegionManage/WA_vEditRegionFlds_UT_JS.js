
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_vEditRegionFlds_UT_JS
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
define(["require", "exports", "../../Js/L0_Entity/RegionManage/clsvEditRegionFldsEN.js","../../Js/L3_ForWApi/RegionManage/clsvEditRegionFldsWApi.js","../../Js/L2_BLL/RegionManage/clsvEditRegionFldsBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsvEditRegionFldsEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsvEditRegionFldsEN.js");
var clsvEditRegionFldsWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsvEditRegionFldsWApi.js");
var clsvEditRegionFldsBL_js_1 = require("../../Js/L2_BLL/RegionManage/clsvEditRegionFldsBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_vEditRegionFlds_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_vEditRegionFlds_UT_JS = /** @class */ (function() {
function WA_vEditRegionFlds_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vEditRegionFlds_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var lngmId = Number(strKeyId);
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.IsExist(lngmId);
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
WA_vEditRegionFlds_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var lngmId = Number(strKeyId);
try
{
var strPrjId = "0001";
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.IsExist_Cache(lngmId, strPrjId);
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
WA_vEditRegionFlds_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.IsExistRecord(strWhereCond);
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
WA_vEditRegionFlds_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objvEditRegionFlds_Cond = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN();
objvEditRegionFlds_Cond.SetCondFldValue(clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vEditRegionFlds_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvEditRegionFlds_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvEditRegionFldsEN_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
console.log(objvEditRegionFldsEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.IsExistRecord_Cache(objvEditRegionFlds_Cond, strPrjId);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objvEditRegionFlds_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objvEditRegionFlds_Cond) + "]的相关记录存在!";
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
WA_vEditRegionFlds_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetRecCountByCond(strWhereCond);
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
WA_vEditRegionFlds_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objvEditRegionFlds_Cond = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN();
objvEditRegionFlds_Cond.SetCondFldValue(clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vEditRegionFlds_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objvEditRegionFlds_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvEditRegionFldsEN_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
console.log(objvEditRegionFldsEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetRecCountByCond_Cache(objvEditRegionFlds_Cond, strPrjId);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objvEditRegionFlds_Cond) + "]的记录数:" +returnInt + "!";
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
WA_vEditRegionFlds_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetFirstObj(strWhereCond);
var objvEditRegionFldsEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objvEditRegionFldsEN.mId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvEditRegionFldsObj("divList15", objvEditRegionFldsEN);
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
WA_vEditRegionFlds_UT_JS.btnGetObjBymId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var lngmId = Number(strKeyId);
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjBymId(lngmId);
var objvEditRegionFldsEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvEditRegionFldsEN.mId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvEditRegionFldsObj("divList16", objvEditRegionFldsEN);
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
WA_vEditRegionFlds_UT_JS.btnGetObjBymId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var lngmId = Number(strKeyId);
try
{
var strPrjId = "0001";
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjBymId_Cache(lngmId, strPrjId);
var objvEditRegionFldsEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvEditRegionFldsEN.mId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvEditRegionFldsObj("divList17", objvEditRegionFldsEN);
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
WA_vEditRegionFlds_UT_JS.btnGetObjBymId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var lngmId = Number(strKeyId);
try
{
var strPrjId = "0001";
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjBymId_WA_Cache(lngmId, strPrjId);
var objvEditRegionFldsEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvEditRegionFldsEN.mId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvEditRegionFldsObj("divList18", objvEditRegionFldsEN);
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
WA_vEditRegionFlds_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjLst(strWhereCond);
var arrvEditRegionFldsObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList19", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrmId = strKeyIdLst.split(',');
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjLstBymIdLst(arrmId);
var arrvEditRegionFldsObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList20", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrmId2 = strKeyIdLst.split(',');
var arrmId = arrmId2.map(x=>Number(x));
try
{
var strPrjId = "0001";
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjLstBymIdLst_Cache(arrmId, strPrjId);
var arrvEditRegionFldsObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList21", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrmId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjLstBymIdLst_WA_Cache(arrmId, strPrjId);
var arrvEditRegionFldsObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList22", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objvEditRegionFlds_Cond = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN();
objvEditRegionFlds_Cond.SetCondFldValue(clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vEditRegionFlds_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvEditRegionFlds_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvEditRegionFldsEN_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
console.log(objvEditRegionFldsEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetSubObjLst_Cache(objvEditRegionFlds_Cond, strPrjId);
var arrvEditRegionFldsObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvEditRegionFlds_Cond) + "],共获取对象列表子集数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList23", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objvEditRegionFlds_Cond = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN();
objvEditRegionFlds_Cond.SetCondFldValue(clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vEditRegionFlds_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvEditRegionFlds_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvEditRegionFldsEN_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
console.log(objvEditRegionFldsEN_Sim);
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetSubObjLst_WA_Cache(objvEditRegionFlds_Cond);
var arrvEditRegionFldsObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvEditRegionFlds_Cond) + "],共获取对象列表子集数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList24", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetTopObjLst(objTopPara);
var arrvEditRegionFldsObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList25", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjLstByPager(objPagerPara);
var arrvEditRegionFldsObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList26", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objvEditRegionFlds_Cond = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN();
var strPrjId = "0001";
objvEditRegionFlds_Cond.SetCondFldValue(clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vEditRegionFlds_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvEditRegionFlds_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvEditRegionFldsEN_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
console.log(objvEditRegionFldsEN_Sim);
strWhereCond = JSON.stringify(objvEditRegionFldsEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjLstByPager_Cache(objPagerPara, strPrjId);
var arrvEditRegionFldsObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList27", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objvEditRegionFlds_Cond = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN();
objvEditRegionFlds_Cond.SetCondFldValue(clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_vEditRegionFlds_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvEditRegionFlds_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvEditRegionFldsEN_Sim = clsvEditRegionFldsBL_js_1.clsvEditRegionFldsBL.GetSimObjFromObj(objvEditRegionFlds_Cond);
console.log(objvEditRegionFldsEN_Sim);
strWhereCond = JSON.stringify(objvEditRegionFldsEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrvEditRegionFldsObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList28", arrvEditRegionFldsObjLst);
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
WA_vEditRegionFlds_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjLstByRange(objRangePara);
var arrvEditRegionFldsObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrvEditRegionFldsObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vEditRegionFlds("divList29", arrvEditRegionFldsObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示vEditRegionFlds对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrvEditRegionFldsObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_vEditRegionFlds_UT_JS.BindTab_vEditRegionFlds = function(divContainer, arrvEditRegionFldsObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("mId"); sstrColHeader.push("mId");
sstrFldName.push("TabId"); sstrColHeader.push("表ID");
sstrFldName.push("FldId"); sstrColHeader.push("字段Id");
sstrFldName.push("FldName"); sstrColHeader.push("字段名");
sstrFldName.push("DataTypeName"); sstrColHeader.push("数据类型名称");
sstrFldName.push("FldLength"); sstrColHeader.push("字段长度");
sstrFldName.push("DataTypeId"); sstrColHeader.push("数据类型Id");
sstrFldName.push("FieldTypeId"); sstrColHeader.push("字段类型Id");
sstrFldName.push("FieldTypeName"); sstrColHeader.push("字段类型名");
sstrFldName.push("IsTabNullable"); sstrColHeader.push("是否表中可空");
sstrFldName.push("IsTabForeignKey"); sstrColHeader.push("是否表外键");
sstrFldName.push("IsParentObj"); sstrColHeader.push("是否父对象");
sstrFldName.push("PrimaryTypeId"); sstrColHeader.push("主键类型ID");
sstrFldName.push("PrimaryTypeName"); sstrColHeader.push("主键类型名");
sstrFldName.push("ForeignKeyTabId"); sstrColHeader.push("外键表ID");
sstrFldName.push("ForeignTabName"); sstrColHeader.push("外键表");
sstrFldName.push("RegionId"); sstrColHeader.push("区域Id");
sstrFldName.push("ColNum"); sstrColHeader.push("列数");
sstrFldName.push("IsUseCtrl"); sstrColHeader.push("是否使用控件");
sstrFldName.push("ViewId"); sstrColHeader.push("界面Id");
sstrFldName.push("RegionTypeId"); sstrColHeader.push("区域类型Id");
sstrFldName.push("RegionTypeName"); sstrColHeader.push("区域类型名称");
sstrFldName.push("TabFldId"); sstrColHeader.push("表字段ID");
sstrFldName.push("LabelCaption"); sstrColHeader.push("标签标题");
sstrFldName.push("CtlTypeId"); sstrColHeader.push("控件类型号");
sstrFldName.push("CtlTypeName"); sstrColHeader.push("控件类型名");
sstrFldName.push("CtlCnName"); sstrColHeader.push("控件类型中文名");
sstrFldName.push("CtlTypeAbbr"); sstrColHeader.push("控件类型缩写");
sstrFldName.push("DDLItemsOptionId"); sstrColHeader.push("下拉框列表选项ID");
sstrFldName.push("DDLItemsOptionName"); sstrColHeader.push("下拉选项名");
sstrFldName.push("DS_TabId"); sstrColHeader.push("数据源表ID");
sstrFldName.push("TabName"); sstrColHeader.push("表名");
sstrFldName.push("DS_DataValueFieldId"); sstrColHeader.push("数据源值字段Id");
sstrFldName.push("DS_DataTextFieldId"); sstrColHeader.push("数据源文本字段Id");
sstrFldName.push("DS_CondStr"); sstrColHeader.push("数据源条件串");
sstrFldName.push("DS_SQLStr"); sstrColHeader.push("数据源SQL串");
sstrFldName.push("ItemsString"); sstrColHeader.push("列表项串");
sstrFldName.push("ColSpan"); sstrColHeader.push("跨列数");
sstrFldName.push("ColIndex"); sstrColHeader.push("列序号");
sstrFldName.push("Width"); sstrColHeader.push("宽");
sstrFldName.push("IsMultiRow"); sstrColHeader.push("是否多行");
sstrFldName.push("SeqNum"); sstrColHeader.push("字段序号");
sstrFldName.push("INOUTTypeId"); sstrColHeader.push("INOUT类型ID");
sstrFldName.push("INOUTTypeName"); sstrColHeader.push("INOUT类型名称");
sstrFldName.push("InUse"); sstrColHeader.push("是否在用");
sstrFldName.push("PrjId"); sstrColHeader.push("工程ID");
sstrFldName.push("UpdUser"); sstrColHeader.push("修改者");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
sstrFldName.push("DS_TabName"); sstrColHeader.push("数据源表");
sstrFldName.push("DS_DataValueFieldName"); sstrColHeader.push("数据源值字段");
sstrFldName.push("DS_DataTextFieldName"); sstrColHeader.push("数据源文本字段");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrvEditRegionFldsObjLst, sstrFldName, sstrColHeader, "mId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objvEditRegionFlds">需要显示的对象</param>
 /// <returns></returns>
WA_vEditRegionFlds_UT_JS.ShowvEditRegionFldsObj = function(divContainer, objvEditRegionFlds) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvEditRegionFlds);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objvEditRegionFlds[strKey];
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
WA_vEditRegionFlds_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_vEditRegionFlds_UT_JS.GetArray(objLst) ;
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
WA_vEditRegionFlds_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_vEditRegionFlds_UT_JS.GetLocalObjLst = function() {
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
WA_vEditRegionFlds_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：vEditRegionFlds");
var strPrjId = "0001";
var strKey =  clsvEditRegionFldsEN_js_1.clsvEditRegionFldsEN._CurrTabName + "_" + strPrjId ;
const responseText = await clsvEditRegionFldsWApi_js_1.clsvEditRegionFldsWApi.GetObjLst_Cache(strPrjId);
console.log("获取缓存完成！vEditRegionFlds");
var arrvEditRegionFldsObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrvEditRegionFldsObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrvEditRegionFldsObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_vEditRegionFlds_UT_JS: CreateCache()不成功！");
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
WA_vEditRegionFlds_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_vEditRegionFlds_UT_JS;
}());
exports.WA_vEditRegionFlds_UT_JS = WA_vEditRegionFlds_UT_JS;
});