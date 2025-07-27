
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_vApplicationType_UT_JS
 表名:vApplicationType(00050403)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:01
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:生成代码
 模块英文名:GeneCode
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
define(["require", "exports", "../../Js/L0_Entity/GeneCode/clsvApplicationTypeEN.js","../../Js/L3_ForWApi/GeneCode/clsvApplicationTypeWApi.js","../../Js/L2_BLL/GeneCode/clsvApplicationTypeBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsvApplicationTypeEN_js_1 = require("../../Js/L0_Entity/GeneCode/clsvApplicationTypeEN.js");
var clsvApplicationTypeWApi_js_1 = require("../../Js/L3_ForWApi/GeneCode/clsvApplicationTypeWApi.js");
var clsvApplicationTypeBL_js_1 = require("../../Js/L2_BLL/GeneCode/clsvApplicationTypeBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_vApplicationType_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_vApplicationType_UT_JS = /** @class */ (function() {
function WA_vApplicationType_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vApplicationType_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var intApplicationTypeId = Number(strKeyId);
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.IsExist(intApplicationTypeId);
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
WA_vApplicationType_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var intApplicationTypeId = Number(strKeyId);
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.IsExist_Cache(intApplicationTypeId);
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
WA_vApplicationType_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.IsExistRecord(strWhereCond);
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
WA_vApplicationType_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objvApplicationType_Cond = new clsvApplicationTypeEN_js_1.clsvApplicationTypeEN();
var arrFldComparisonObj = WA_vApplicationType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvApplicationType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvApplicationTypeEN_Sim = clsvApplicationTypeBL_js_1.clsvApplicationTypeBL.GetSimObjFromObj(objvApplicationType_Cond);
console.log(objvApplicationTypeEN_Sim);
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.IsExistRecord_Cache(objvApplicationType_Cond);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objvApplicationType_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objvApplicationType_Cond) + "]的相关记录存在!";
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
WA_vApplicationType_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetRecCountByCond(strWhereCond);
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
WA_vApplicationType_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objvApplicationType_Cond = new clsvApplicationTypeEN_js_1.clsvApplicationTypeEN();
var arrFldComparisonObj = WA_vApplicationType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objvApplicationType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvApplicationTypeEN_Sim = clsvApplicationTypeBL_js_1.clsvApplicationTypeBL.GetSimObjFromObj(objvApplicationType_Cond);
console.log(objvApplicationTypeEN_Sim);
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetRecCountByCond_Cache(objvApplicationType_Cond);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objvApplicationType_Cond) + "]的记录数:" +returnInt + "!";
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
WA_vApplicationType_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetFirstObj(strWhereCond);
var objvApplicationTypeEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objvApplicationTypeEN.ApplicationTypeId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvApplicationTypeObj("divList15", objvApplicationTypeEN);
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
WA_vApplicationType_UT_JS.btnGetObjByApplicationTypeId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var intApplicationTypeId = Number(strKeyId);
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjByApplicationTypeId(intApplicationTypeId);
var objvApplicationTypeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvApplicationTypeEN.ApplicationTypeId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvApplicationTypeObj("divList16", objvApplicationTypeEN);
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
WA_vApplicationType_UT_JS.btnGetObjByApplicationTypeId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var intApplicationTypeId = Number(strKeyId);
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjByApplicationTypeId_Cache(intApplicationTypeId);
var objvApplicationTypeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvApplicationTypeEN.ApplicationTypeId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvApplicationTypeObj("divList17", objvApplicationTypeEN);
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
WA_vApplicationType_UT_JS.btnGetObjByApplicationTypeId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var intApplicationTypeId = Number(strKeyId);
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjByApplicationTypeId_WA_Cache(intApplicationTypeId);
var objvApplicationTypeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvApplicationTypeEN.ApplicationTypeId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvApplicationTypeObj("divList18", objvApplicationTypeEN);
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
WA_vApplicationType_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjLst(strWhereCond);
var arrvApplicationTypeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList19", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrApplicationTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjLstByApplicationTypeIdLst(arrApplicationTypeId);
var arrvApplicationTypeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList20", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrApplicationTypeId2 = strKeyIdLst.split(',');
var arrApplicationTypeId = arrApplicationTypeId2.map(x=>Number(x));
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjLstByApplicationTypeIdLst_Cache(arrApplicationTypeId);
var arrvApplicationTypeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList21", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrApplicationTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjLstByApplicationTypeIdLst_WA_Cache(arrApplicationTypeId);
var arrvApplicationTypeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList22", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objvApplicationType_Cond = new clsvApplicationTypeEN_js_1.clsvApplicationTypeEN();
var arrFldComparisonObj = WA_vApplicationType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvApplicationType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvApplicationTypeEN_Sim = clsvApplicationTypeBL_js_1.clsvApplicationTypeBL.GetSimObjFromObj(objvApplicationType_Cond);
console.log(objvApplicationTypeEN_Sim);
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetSubObjLst_Cache(objvApplicationType_Cond);
var arrvApplicationTypeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvApplicationType_Cond) + "],共获取对象列表子集数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList23", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objvApplicationType_Cond = new clsvApplicationTypeEN_js_1.clsvApplicationTypeEN();
var arrFldComparisonObj = WA_vApplicationType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvApplicationType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvApplicationTypeEN_Sim = clsvApplicationTypeBL_js_1.clsvApplicationTypeBL.GetSimObjFromObj(objvApplicationType_Cond);
console.log(objvApplicationTypeEN_Sim);
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetSubObjLst_WA_Cache(objvApplicationType_Cond);
var arrvApplicationTypeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvApplicationType_Cond) + "],共获取对象列表子集数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList24", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetTopObjLst(objTopPara);
var arrvApplicationTypeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList25", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjLstByPager(objPagerPara);
var arrvApplicationTypeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList26", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objvApplicationType_Cond = new clsvApplicationTypeEN_js_1.clsvApplicationTypeEN();
var arrFldComparisonObj = WA_vApplicationType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvApplicationType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvApplicationTypeEN_Sim = clsvApplicationTypeBL_js_1.clsvApplicationTypeBL.GetSimObjFromObj(objvApplicationType_Cond);
console.log(objvApplicationTypeEN_Sim);
strWhereCond = JSON.stringify(objvApplicationTypeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjLstByPager_Cache(objPagerPara);
var arrvApplicationTypeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList27", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objvApplicationType_Cond = new clsvApplicationTypeEN_js_1.clsvApplicationTypeEN();
var arrFldComparisonObj = WA_vApplicationType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvApplicationType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvApplicationTypeEN_Sim = clsvApplicationTypeBL_js_1.clsvApplicationTypeBL.GetSimObjFromObj(objvApplicationType_Cond);
console.log(objvApplicationTypeEN_Sim);
strWhereCond = JSON.stringify(objvApplicationTypeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrvApplicationTypeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList28", arrvApplicationTypeObjLst);
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
WA_vApplicationType_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjLstByRange(objRangePara);
var arrvApplicationTypeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrvApplicationTypeObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vApplicationType("divList29", arrvApplicationTypeObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示vApplicationType对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrvApplicationTypeObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_vApplicationType_UT_JS.BindTab_vApplicationType = function(divContainer, arrvApplicationTypeObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("ApplicationTypeId"); sstrColHeader.push("应用程序类型ID");
sstrFldName.push("ApplicationTypeName"); sstrColHeader.push("应用程序类型名称");
sstrFldName.push("ApplicationTypeSimName"); sstrColHeader.push("应用程序类型简称");
sstrFldName.push("ApplicationTypeENName"); sstrColHeader.push("应用类型英文名");
sstrFldName.push("ProgLangTypeId"); sstrColHeader.push("编程语言类型Id");
sstrFldName.push("ProgLangTypeName"); sstrColHeader.push("编程语言类型名");
sstrFldName.push("ProgLangTypeENName"); sstrColHeader.push("编程语言类型英文名");
sstrFldName.push("CharEncodingId"); sstrColHeader.push("字符编码");
sstrFldName.push("CharEncodingName"); sstrColHeader.push("字符编码名称");
sstrFldName.push("ProgLangTypeId2"); sstrColHeader.push("编程语言类型Id2");
sstrFldName.push("ProgLangTypeId3"); sstrColHeader.push("编程语言类型Id3");
sstrFldName.push("ProgLangTypeId4"); sstrColHeader.push("编程语言类型Id4");
sstrFldName.push("ProgLangTypeId5"); sstrColHeader.push("编程语言类型Id5");
sstrFldName.push("IsVisible"); sstrColHeader.push("是否显示");
sstrFldName.push("OrderNum"); sstrColHeader.push("序号");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
sstrFldName.push("CharEncodingId2"); sstrColHeader.push("CharEncodingId2");
sstrFldName.push("CharEncodingId3"); sstrColHeader.push("CharEncodingId3");
sstrFldName.push("CharEncodingName2"); sstrColHeader.push("CharEncodingName2");
sstrFldName.push("CharEncodingName3"); sstrColHeader.push("CharEncodingName3");
sstrFldName.push("ProgLangTypeName2"); sstrColHeader.push("ProgLangTypeName2");
sstrFldName.push("ProgLangTypeName3"); sstrColHeader.push("ProgLangTypeName3");
sstrFldName.push("ProgLangTypeName5"); sstrColHeader.push("ProgLangTypeName5");
sstrFldName.push("CodeTypeCount"); sstrColHeader.push("代码类型数");
sstrFldName.push("CharEncodingId4"); sstrColHeader.push("CharEncodingId4");
sstrFldName.push("CharEncodingName4"); sstrColHeader.push("CharEncodingName4");
sstrFldName.push("ProgLangTypeName4"); sstrColHeader.push("ProgLangTypeName4");
sstrFldName.push("CharEncodingId5"); sstrColHeader.push("CharEncodingId5");
sstrFldName.push("CharEncodingName5"); sstrColHeader.push("CharEncodingName5");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrvApplicationTypeObjLst, sstrFldName, sstrColHeader, "ApplicationTypeId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objvApplicationType">需要显示的对象</param>
 /// <returns></returns>
WA_vApplicationType_UT_JS.ShowvApplicationTypeObj = function(divContainer, objvApplicationType) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvApplicationType);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objvApplicationType[strKey];
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
WA_vApplicationType_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_vApplicationType_UT_JS.GetArray(objLst) ;
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
WA_vApplicationType_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsvApplicationTypeEN_js_1.clsvApplicationTypeEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_vApplicationType_UT_JS.GetLocalObjLst = function() {
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
WA_vApplicationType_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：vApplicationType");
strKey = clsvApplicationTypeEN_js_1.clsvApplicationTypeEN._CurrTabName;
const responseText = await clsvApplicationTypeWApi_js_1.clsvApplicationTypeWApi.GetObjLst_Cache();
console.log("获取缓存完成！vApplicationType");
var arrvApplicationTypeObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrvApplicationTypeObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrvApplicationTypeObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_vApplicationType_UT_JS: CreateCache()不成功！");
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
WA_vApplicationType_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_vApplicationType_UT_JS;
}());
exports.WA_vApplicationType_UT_JS = WA_vApplicationType_UT_JS;
});