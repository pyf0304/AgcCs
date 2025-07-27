
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_vCodeType_UT_JS
 表名:vCodeType(00050410)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:50:01
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
define(["require", "exports", "../../Js/L0_Entity/SysPara/clsvCodeTypeEN.js","../../Js/L3_ForWApi/SysPara/clsvCodeTypeWApi.js","../../Js/L2_BLL/SysPara/clsvCodeTypeBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsvCodeTypeEN_js_1 = require("../../Js/L0_Entity/SysPara/clsvCodeTypeEN.js");
var clsvCodeTypeWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsvCodeTypeWApi.js");
var clsvCodeTypeBL_js_1 = require("../../Js/L2_BLL/SysPara/clsvCodeTypeBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_vCodeType_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_vCodeType_UT_JS = /** @class */ (function() {
function WA_vCodeType_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_vCodeType_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.IsExist(strCodeTypeId);
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
WA_vCodeType_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.IsExist_Cache(strCodeTypeId);
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
WA_vCodeType_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.IsExistRecord(strWhereCond);
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
WA_vCodeType_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objvCodeType_Cond = new clsvCodeTypeEN_js_1.clsvCodeTypeEN();
var arrFldComparisonObj = WA_vCodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvCodeTypeEN_Sim = clsvCodeTypeBL_js_1.clsvCodeTypeBL.GetSimObjFromObj(objvCodeType_Cond);
console.log(objvCodeTypeEN_Sim);
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.IsExistRecord_Cache(objvCodeType_Cond);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objvCodeType_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objvCodeType_Cond) + "]的相关记录存在!";
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
WA_vCodeType_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetRecCountByCond(strWhereCond);
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
WA_vCodeType_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objvCodeType_Cond = new clsvCodeTypeEN_js_1.clsvCodeTypeEN();
var arrFldComparisonObj = WA_vCodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objvCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvCodeTypeEN_Sim = clsvCodeTypeBL_js_1.clsvCodeTypeBL.GetSimObjFromObj(objvCodeType_Cond);
console.log(objvCodeTypeEN_Sim);
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetRecCountByCond_Cache(objvCodeType_Cond);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objvCodeType_Cond) + "]的记录数:" +returnInt + "!";
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
WA_vCodeType_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetFirstObj(strWhereCond);
var objvCodeTypeEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objvCodeTypeEN.CodeTypeId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvCodeTypeObj("divList15", objvCodeTypeEN);
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
WA_vCodeType_UT_JS.btnGetObjByCodeTypeId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjByCodeTypeId(strCodeTypeId);
var objvCodeTypeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvCodeTypeEN.CodeTypeId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvCodeTypeObj("divList16", objvCodeTypeEN);
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
WA_vCodeType_UT_JS.btnGetObjByCodeTypeId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjByCodeTypeId_Cache(strCodeTypeId);
var objvCodeTypeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvCodeTypeEN.CodeTypeId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvCodeTypeObj("divList17", objvCodeTypeEN);
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
WA_vCodeType_UT_JS.btnGetObjByCodeTypeId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjByCodeTypeId_WA_Cache(strCodeTypeId);
var objvCodeTypeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objvCodeTypeEN.CodeTypeId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowvCodeTypeObj("divList18", objvCodeTypeEN);
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
WA_vCodeType_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLst(strWhereCond);
var arrvCodeTypeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList19", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrCodeTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByCodeTypeIdLst(arrCodeTypeId);
var arrvCodeTypeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList20", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrCodeTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByCodeTypeIdLst_Cache(arrCodeTypeId);
var arrvCodeTypeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList21", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrCodeTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByCodeTypeIdLst_WA_Cache(arrCodeTypeId);
var arrvCodeTypeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList22", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objvCodeType_Cond = new clsvCodeTypeEN_js_1.clsvCodeTypeEN();
var arrFldComparisonObj = WA_vCodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvCodeTypeEN_Sim = clsvCodeTypeBL_js_1.clsvCodeTypeBL.GetSimObjFromObj(objvCodeType_Cond);
console.log(objvCodeTypeEN_Sim);
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetSubObjLst_Cache(objvCodeType_Cond);
var arrvCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvCodeType_Cond) + "],共获取对象列表子集数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList23", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objvCodeType_Cond = new clsvCodeTypeEN_js_1.clsvCodeTypeEN();
var arrFldComparisonObj = WA_vCodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvCodeTypeEN_Sim = clsvCodeTypeBL_js_1.clsvCodeTypeBL.GetSimObjFromObj(objvCodeType_Cond);
console.log(objvCodeTypeEN_Sim);
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetSubObjLst_WA_Cache(objvCodeType_Cond);
var arrvCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objvCodeType_Cond) + "],共获取对象列表子集数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList24", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetTopObjLst(objTopPara);
var arrvCodeTypeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList25", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByPager(objPagerPara);
var arrvCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList26", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objvCodeType_Cond = new clsvCodeTypeEN_js_1.clsvCodeTypeEN();
var arrFldComparisonObj = WA_vCodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvCodeTypeEN_Sim = clsvCodeTypeBL_js_1.clsvCodeTypeBL.GetSimObjFromObj(objvCodeType_Cond);
console.log(objvCodeTypeEN_Sim);
strWhereCond = JSON.stringify(objvCodeTypeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByPager_Cache(objPagerPara);
var arrvCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList27", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objvCodeType_Cond = new clsvCodeTypeEN_js_1.clsvCodeTypeEN();
var arrFldComparisonObj = WA_vCodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objvCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objvCodeTypeEN_Sim = clsvCodeTypeBL_js_1.clsvCodeTypeBL.GetSimObjFromObj(objvCodeType_Cond);
console.log(objvCodeTypeEN_Sim);
strWhereCond = JSON.stringify(objvCodeTypeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrvCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList28", arrvCodeTypeObjLst);
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
WA_vCodeType_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByRange(objRangePara);
var arrvCodeTypeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrvCodeTypeObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_vCodeType("divList29", arrvCodeTypeObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示vCodeType对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrvCodeTypeObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_vCodeType_UT_JS.BindTab_vCodeType = function(divContainer, arrvCodeTypeObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("CodeTypeId"); sstrColHeader.push("代码类型Id");
sstrFldName.push("CodeTypeName"); sstrColHeader.push("代码类型名");
sstrFldName.push("CodeTypeSimName"); sstrColHeader.push("简称");
sstrFldName.push("CodeTypeENName"); sstrColHeader.push("代码类型英文名");
sstrFldName.push("GroupName"); sstrColHeader.push("组名");
sstrFldName.push("ProgLangTypeId"); sstrColHeader.push("编程语言类型Id");
sstrFldName.push("ProgLangTypeName"); sstrColHeader.push("编程语言类型名");
sstrFldName.push("ProgLangTypeSimName"); sstrColHeader.push("编程语言类型简称");
sstrFldName.push("RegionTypeId"); sstrColHeader.push("区域类型Id");
sstrFldName.push("RegionTypeName"); sstrColHeader.push("区域类型名称");
sstrFldName.push("Prefix"); sstrColHeader.push("前缀");
sstrFldName.push("DependsOn"); sstrColHeader.push("依赖于");
sstrFldName.push("FrontOrBack"); sstrColHeader.push("前台Or后台");
sstrFldName.push("SQLDSTypeId"); sstrColHeader.push("数据源类型");
sstrFldName.push("SqlDsTypeName"); sstrColHeader.push("Sql数据源名");
sstrFldName.push("ClassNameFormat"); sstrColHeader.push("类名格式");
sstrFldName.push("IsCSharp"); sstrColHeader.push("是否CSharp语言");
sstrFldName.push("IsJava"); sstrColHeader.push("是否Java语言");
sstrFldName.push("IsJavaScript"); sstrColHeader.push("是否JavaScript语言");
sstrFldName.push("IsTypeScript"); sstrColHeader.push("是否TypeScript语言");
sstrFldName.push("IsSilverLight"); sstrColHeader.push("是否SilverLight语言");
sstrFldName.push("IsSwift"); sstrColHeader.push("是否Swift语言");
sstrFldName.push("IsVB"); sstrColHeader.push("IsVB语言");
sstrFldName.push("IsTableFldConst"); sstrColHeader.push("IsTableFldConst");
sstrFldName.push("IsPubApp4WinWeb"); sstrColHeader.push("IsPubApp4WinWeb");
sstrFldName.push("IsWeb"); sstrColHeader.push("是否Web应用");
sstrFldName.push("IsAspMvc"); sstrColHeader.push("是否AspMvc");
sstrFldName.push("IsWebSrvAccess"); sstrColHeader.push("IsWebSrvAccess");
sstrFldName.push("IsWin"); sstrColHeader.push("是否Win应用");
sstrFldName.push("IsMobileApp"); sstrColHeader.push("是否移动终端应用");
sstrFldName.push("OrderNum"); sstrColHeader.push("序号");
sstrFldName.push("WinOrWeb"); sstrColHeader.push("WinOrWeb");
sstrFldName.push("IsDirByTabName"); sstrColHeader.push("是否用表名作为路径");
sstrFldName.push("InUse"); sstrColHeader.push("是否在用");
sstrFldName.push("IsDefaultOverride"); sstrColHeader.push("是否默认覆盖");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("UpdUser"); sstrColHeader.push("修改者");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
sstrFldName.push("FuncCount"); sstrColHeader.push("函数数目");
sstrFldName.push("AppCount"); sstrColHeader.push("应用数");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrvCodeTypeObjLst, sstrFldName, sstrColHeader, "CodeTypeId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objvCodeType">需要显示的对象</param>
 /// <returns></returns>
WA_vCodeType_UT_JS.ShowvCodeTypeObj = function(divContainer, objvCodeType) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvCodeType);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objvCodeType[strKey];
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
WA_vCodeType_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_vCodeType_UT_JS.GetArray(objLst) ;
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
WA_vCodeType_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsvCodeTypeEN_js_1.clsvCodeTypeEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_vCodeType_UT_JS.GetLocalObjLst = function() {
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
WA_vCodeType_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：vCodeType");
strKey = clsvCodeTypeEN_js_1.clsvCodeTypeEN._CurrTabName;
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLst_Cache();
console.log("获取缓存完成！vCodeType");
var arrvCodeTypeObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrvCodeTypeObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrvCodeTypeObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_vCodeType_UT_JS: CreateCache()不成功！");
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
WA_vCodeType_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_vCodeType_UT_JS;
}());
exports.WA_vCodeType_UT_JS = WA_vCodeType_UT_JS;
});