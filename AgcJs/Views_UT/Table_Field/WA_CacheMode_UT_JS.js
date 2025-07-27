
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_CacheMode_UT_JS
 表名:CacheMode(00050538)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:01
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
define(["require", "exports", "../../Js/L0_Entity/Table_Field/clsCacheModeEN.js","../../Js/L3_ForWApi/Table_Field/clsCacheModeWApi.js","../../Js/L2_BLL/Table_Field/clsCacheModeBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsCacheModeEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsCacheModeEN.js");
var clsCacheModeWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsCacheModeWApi.js");
var clsCacheModeBL_js_1 = require("../../Js/L2_BLL/Table_Field/clsCacheModeBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_CacheMode_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_CacheMode_UT_JS = /** @class */ (function() {
function WA_CacheMode_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_CacheMode_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var strCacheModeId = strKeyId;
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.IsExist(strCacheModeId);
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
WA_CacheMode_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var strCacheModeId = strKeyId;
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.IsExist_Cache(strCacheModeId);
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
WA_CacheMode_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.IsExistRecord(strWhereCond);
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
WA_CacheMode_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();
var arrFldComparisonObj = WA_CacheMode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCacheMode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCacheModeEN_Sim = clsCacheModeBL_js_1.clsCacheModeBL.GetSimObjFromObj(objCacheMode_Cond);
console.log(objCacheModeEN_Sim);
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.IsExistRecord_Cache(objCacheMode_Cond);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objCacheMode_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objCacheMode_Cond) + "]的相关记录存在!";
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
WA_CacheMode_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetRecCountByCond(strWhereCond);
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
WA_CacheMode_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();
var arrFldComparisonObj = WA_CacheMode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objCacheMode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCacheModeEN_Sim = clsCacheModeBL_js_1.clsCacheModeBL.GetSimObjFromObj(objCacheMode_Cond);
console.log(objCacheModeEN_Sim);
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetRecCountByCond_Cache(objCacheMode_Cond);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objCacheMode_Cond) + "]的记录数:" +returnInt + "!";
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
 /// 添加新记录
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickAddNewRecord)
 /// </summary>
 /// <returns></returns>
WA_CacheMode_UT_JS.btnAddNewRecord_Click = async function() {
$('#hidDivName').val("divAddNewRecord");
var objCacheModeEN = new clsCacheModeEN_js_1.clsCacheModeEN();
objCacheModeEN.CacheModeId = "11";
objCacheModeEN.CacheModeName = "11111111111111111111111111111111111111111111111111";
objCacheModeEN.CacheModeENName = "11111111111111111111111111111111111111111111111111";
objCacheModeEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.IsExist(objCacheModeEN.CacheModeId);
var bolIsExist = responseText;
if (bolIsExist == true)
{
var strMsg = "添加记录时，关键字：" +objCacheModeEN.CacheModeId  + "已经存在！";
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsCacheModeWApi_js_1.clsCacheModeWApi.AddNewRecord(objCacheModeEN);
var returnBool = !!responseText2;
if (returnBool == true)
{
var strInfo = "添加记录成功!";
$('#lblResult7').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "添加记录不成功!";
$('#lblResult7').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "添加记录不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickAddNewRecord4GetMaxStrId)
 /// </summary>
 /// <returns></returns>
WA_CacheMode_UT_JS.btnAddNewRecord4GetMaxStrId_Click = async function() {
$('#hidDivName').val("divAddNewRecord4GetMaxStrId");
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetMaxStrId();
var returnString = responseText.toString();
var objCacheModeEN = new clsCacheModeEN_js_1.clsCacheModeEN();
objCacheModeEN.CacheModeId = returnString;
objCacheModeEN.CacheModeName = "11111111111111111111111111111111111111111111111111";
objCacheModeEN.CacheModeENName = "11111111111111111111111111111111111111111111111111";
objCacheModeEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.AddNewRecord(objCacheModeEN);
var returnBool = responseText;
if (returnBool == true)
{
var strInfo = "添加记录成功!";
$('#lblResult8').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "添加记录不成功!";
$('#lblResult8').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "添加记录不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetMaxStrId)
 /// </summary>
 /// <returns></returns>
WA_CacheMode_UT_JS.btnGetMaxStrId_Click = async function() {
$('#hidDivName').val("divGetMaxStrId");
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表CacheMode的最大关键字为空，不成功，请检查!";
$('#lblResult9').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表CacheMode的最大关键字为：" +returnString + "!";
$('#lblResult9').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "获取表关键字的最大值不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns></returns>
WA_CacheMode_UT_JS.btnGetMaxStrIdByPrefix_Click = async function() {
$('#hidDivName').val("divGetMaxStrIdByPrefix");
var strPrefix = $('#txtstrPrefix10').val();
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetMaxStrIdByPrefix(strPrefix);
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表CacheMode的最大关键字为空，不成功，请检查!";
$('#lblResult10').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表CacheMode的最大关键字为：" +returnString + "!";
$('#lblResult10').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "获取表关键字的最大值不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickUpdateRecord)
 /// </summary>
 /// <returns></returns>
WA_CacheMode_UT_JS.btnUpdateRecord_Click = async function() {
$('#hidDivName').val("divUpdateRecord");
var objCacheModeEN = new clsCacheModeEN_js_1.clsCacheModeEN();
objCacheModeEN.CacheModeId = "11";
objCacheModeEN.CacheModeName = "11111111111111111111111111111111111111111111111111";
objCacheModeEN.CacheModeENName = "11111111111111111111111111111111111111111111111111";
objCacheModeEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objCacheModeEN.sf_UpdFldSetStr = objCacheModeEN.UpdFldString;//设置哪些字段被修改(脏字段)
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.UpdateRecord(objCacheModeEN);
var returnBool = responseText;
if (returnBool == true)
{
var strInfo = "修改记录成功!";
$('#lblResult11').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "修改记录不成功!";
$('#lblResult11').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "修改记录不成功," +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 删除记录
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickDelRecord)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_CacheMode_UT_JS.btnDelRecord_Click = async function() {
$('#hidDivName').val("divDelRecord");
var strKeyId = $('#txtstrKeyId12').val();
var strCacheModeId = strKeyId;
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.DelRecord(strCacheModeId);
var returnInt = responseText;
if (returnInt > 0)
{
var strInfo = "删除记录成功, 共删除了" +returnInt + "条记录!";
$('#lblResult12').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "删除记录不成功!";
$('#lblResult12').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "删除记录不成功. " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickDelMultiRecord)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_CacheMode_UT_JS.btnDelCacheModes_Click = async function() {
$('#hidDivName').val("divDel[TabName]s");
var strKeyIdLst = $('#txtarrKeyId13').val();
var arrCacheModeId = strKeyIdLst.split(',');
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.DelCacheModes(arrCacheModeId);
var returnInt = responseText;
if (returnInt > 0)
{
var strInfo = "删除记录成功,共删除" +returnInt + "条记录!";
$('#lblResult13').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "删除记录不成功!";
$('#lblResult13').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "删除记录不成功. " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件删除多条记录
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickDelMultiRecordByCond)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_CacheMode_UT_JS.btnDelMultiRecordByCond_Click = async function() {
$('#hidDivName').val("divDelMultiRecordByCond");
var strWhereCond = $('#txtstrWhereCond14').val();
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.DelCacheModesByCond(strWhereCond);
var returnInt = responseText;
if (returnInt > 0)
{
var strInfo = "删除记录成功,共删除" +returnInt + "条记录!";
$('#lblResult14').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "删除记录不成功!";
$('#lblResult14').val(strInfo);
//显示信息框
alert(strInfo);
}
}
catch(e)
{
var strMsg = "删除记录不成功. " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相应的第一条记录的对象
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickGetFirstObj)
 /// </summary>
 /// <param name = "sender">事件发送者</param>
 /// <returns></returns>
WA_CacheMode_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetFirstObj(strWhereCond);
var objCacheModeEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objCacheModeEN.CacheModeId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowCacheModeObj("divList15", objCacheModeEN);
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
WA_CacheMode_UT_JS.btnGetObjByCacheModeId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var strCacheModeId = strKeyId;
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjByCacheModeId(strCacheModeId);
var objCacheModeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objCacheModeEN.CacheModeId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowCacheModeObj("divList16", objCacheModeEN);
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
WA_CacheMode_UT_JS.btnGetObjByCacheModeId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var strCacheModeId = strKeyId;
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjByCacheModeId_Cache(strCacheModeId);
var objCacheModeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objCacheModeEN.CacheModeId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowCacheModeObj("divList17", objCacheModeEN);
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
WA_CacheMode_UT_JS.btnGetObjByCacheModeId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var strCacheModeId = strKeyId;
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjByCacheModeId_WA_Cache(strCacheModeId);
var objCacheModeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objCacheModeEN.CacheModeId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowCacheModeObj("divList18", objCacheModeEN);
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
WA_CacheMode_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjLst(strWhereCond);
var arrCacheModeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrCacheModeObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList19", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrCacheModeId = strKeyIdLst.split(',');
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjLstByCacheModeIdLst(arrCacheModeId);
var arrCacheModeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrCacheModeObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList20", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrCacheModeId = strKeyIdLst.split(',');
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjLstByCacheModeIdLst_Cache(arrCacheModeId);
var arrCacheModeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrCacheModeObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList21", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrCacheModeId = strKeyIdLst.split(',');
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjLstByCacheModeIdLst_WA_Cache(arrCacheModeId);
var arrCacheModeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrCacheModeObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList22", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();
var arrFldComparisonObj = WA_CacheMode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCacheMode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCacheModeEN_Sim = clsCacheModeBL_js_1.clsCacheModeBL.GetSimObjFromObj(objCacheMode_Cond);
console.log(objCacheModeEN_Sim);
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetSubObjLst_Cache(objCacheMode_Cond);
var arrCacheModeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objCacheMode_Cond) + "],共获取对象列表子集数：" +arrCacheModeObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList23", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();
var arrFldComparisonObj = WA_CacheMode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCacheMode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCacheModeEN_Sim = clsCacheModeBL_js_1.clsCacheModeBL.GetSimObjFromObj(objCacheMode_Cond);
console.log(objCacheModeEN_Sim);
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetSubObjLst_WA_Cache(objCacheMode_Cond);
var arrCacheModeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objCacheMode_Cond) + "],共获取对象列表子集数：" +arrCacheModeObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList24", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetTopObjLst(objTopPara);
var arrCacheModeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrCacheModeObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList25", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjLstByPager(objPagerPara);
var arrCacheModeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrCacheModeObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList26", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();
var arrFldComparisonObj = WA_CacheMode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCacheMode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCacheModeEN_Sim = clsCacheModeBL_js_1.clsCacheModeBL.GetSimObjFromObj(objCacheMode_Cond);
console.log(objCacheModeEN_Sim);
strWhereCond = JSON.stringify(objCacheModeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjLstByPager_Cache(objPagerPara);
var arrCacheModeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrCacheModeObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList27", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();
var arrFldComparisonObj = WA_CacheMode_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCacheMode_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCacheModeEN_Sim = clsCacheModeBL_js_1.clsCacheModeBL.GetSimObjFromObj(objCacheMode_Cond);
console.log(objCacheModeEN_Sim);
strWhereCond = JSON.stringify(objCacheModeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrCacheModeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrCacheModeObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList28", arrCacheModeObjLst);
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
WA_CacheMode_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjLstByRange(objRangePara);
var arrCacheModeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrCacheModeObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CacheMode("divList29", arrCacheModeObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示CacheMode对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrCacheModeObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_CacheMode_UT_JS.BindTab_CacheMode = function(divContainer, arrCacheModeObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("CacheModeId"); sstrColHeader.push("缓存方式Id");
sstrFldName.push("CacheModeName"); sstrColHeader.push("缓存方式名");
sstrFldName.push("CacheModeENName"); sstrColHeader.push("缓存方式英文名");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrCacheModeObjLst, sstrFldName, sstrColHeader, "CacheModeId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objCacheMode">需要显示的对象</param>
 /// <returns></returns>
WA_CacheMode_UT_JS.ShowCacheModeObj = function(divContainer, objCacheMode) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objCacheMode);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objCacheMode[strKey];
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
WA_CacheMode_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_CacheMode_UT_JS.GetArray(objLst) ;
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
WA_CacheMode_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsCacheModeEN_js_1.clsCacheModeEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_CacheMode_UT_JS.GetLocalObjLst = function() {
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
WA_CacheMode_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：CacheMode");
strKey = clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName;
const responseText = await clsCacheModeWApi_js_1.clsCacheModeWApi.GetObjLst_Cache();
console.log("获取缓存完成！CacheMode");
var arrCacheModeObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrCacheModeObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrCacheModeObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_CacheMode_UT_JS: CreateCache()不成功！");
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
WA_CacheMode_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_CacheMode_UT_JS;
}());
exports.WA_CacheMode_UT_JS = WA_CacheMode_UT_JS;
});