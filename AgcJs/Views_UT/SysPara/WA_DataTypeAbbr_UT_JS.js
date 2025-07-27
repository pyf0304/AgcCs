
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_DataTypeAbbr_UT_JS
 表名:DataTypeAbbr(00050023)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:33
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
define(["require", "exports", "../../Js/L0_Entity/SysPara/clsDataTypeAbbrEN.js","../../Js/L3_ForWApi/SysPara/clsDataTypeAbbrWApi.js","../../Js/L2_BLL/SysPara/clsDataTypeAbbrBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsDataTypeAbbrEN_js_1 = require("../../Js/L0_Entity/SysPara/clsDataTypeAbbrEN.js");
var clsDataTypeAbbrWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsDataTypeAbbrWApi.js");
var clsDataTypeAbbrBL_js_1 = require("../../Js/L2_BLL/SysPara/clsDataTypeAbbrBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_DataTypeAbbr_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_DataTypeAbbr_UT_JS = /** @class */ (function() {
function WA_DataTypeAbbr_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_DataTypeAbbr_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var strDataTypeId = strKeyId;
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.IsExist(strDataTypeId);
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
WA_DataTypeAbbr_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var strDataTypeId = strKeyId;
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.IsExist_Cache(strDataTypeId);
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
WA_DataTypeAbbr_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.IsExistRecord(strWhereCond);
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
WA_DataTypeAbbr_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objDataTypeAbbr_Cond = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
var arrFldComparisonObj = WA_DataTypeAbbr_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objDataTypeAbbr_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
console.log(objDataTypeAbbrEN_Sim);
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.IsExistRecord_Cache(objDataTypeAbbr_Cond);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objDataTypeAbbr_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objDataTypeAbbr_Cond) + "]的相关记录存在!";
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
WA_DataTypeAbbr_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetRecCountByCond(strWhereCond);
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
WA_DataTypeAbbr_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objDataTypeAbbr_Cond = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
var arrFldComparisonObj = WA_DataTypeAbbr_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objDataTypeAbbr_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
console.log(objDataTypeAbbrEN_Sim);
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetRecCountByCond_Cache(objDataTypeAbbr_Cond);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objDataTypeAbbr_Cond) + "]的记录数:" +returnInt + "!";
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
WA_DataTypeAbbr_UT_JS.btnAddNewRecord_Click = async function() {
$('#hidDivName').val("divAddNewRecord");
var objDataTypeAbbrEN = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
objDataTypeAbbrEN.DataTypeId = "11";
objDataTypeAbbrEN.DataTypeName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DataTypeENName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DataCnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DataTypeAbbr = "11111";
objDataTypeAbbrEN.NetSysType = "11111111111111111111";
objDataTypeAbbrEN.VBNETType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.CSType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.JavaType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.TypeScriptType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.JavaObjType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.SwiftType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.IsNeedQuote = false;
objDataTypeAbbrEN.OraDbType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.IsReturnType = false;
objDataTypeAbbrEN.SqlParaType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.MySqlType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DefaFldLength = 0;
objDataTypeAbbrEN.DefaFldPrecision = 0;
objDataTypeAbbrEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.IsExist(objDataTypeAbbrEN.DataTypeId);
var bolIsExist = responseText;
if (bolIsExist == true)
{
var strMsg = "添加记录时，关键字：" +objDataTypeAbbrEN.DataTypeId  + "已经存在！";
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.AddNewRecord(objDataTypeAbbrEN);
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
WA_DataTypeAbbr_UT_JS.btnAddNewRecord4GetMaxStrId_Click = async function() {
$('#hidDivName').val("divAddNewRecord4GetMaxStrId");
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetMaxStrId();
var returnString = responseText.toString();
var objDataTypeAbbrEN = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
objDataTypeAbbrEN.DataTypeId = returnString;
objDataTypeAbbrEN.DataTypeName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DataTypeENName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DataCnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DataTypeAbbr = "11111";
objDataTypeAbbrEN.NetSysType = "11111111111111111111";
objDataTypeAbbrEN.VBNETType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.CSType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.JavaType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.TypeScriptType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.JavaObjType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.SwiftType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.IsNeedQuote = false;
objDataTypeAbbrEN.OraDbType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.IsReturnType = false;
objDataTypeAbbrEN.SqlParaType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.MySqlType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DefaFldLength = 0;
objDataTypeAbbrEN.DefaFldPrecision = 0;
objDataTypeAbbrEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.AddNewRecord(objDataTypeAbbrEN);
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
WA_DataTypeAbbr_UT_JS.btnGetMaxStrId_Click = async function() {
$('#hidDivName').val("divGetMaxStrId");
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表DataTypeAbbr的最大关键字为空，不成功，请检查!";
$('#lblResult9').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表DataTypeAbbr的最大关键字为：" +returnString + "!";
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
WA_DataTypeAbbr_UT_JS.btnGetMaxStrIdByPrefix_Click = async function() {
$('#hidDivName').val("divGetMaxStrIdByPrefix");
var strPrefix = $('#txtstrPrefix10').val();
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetMaxStrIdByPrefix(strPrefix);
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表DataTypeAbbr的最大关键字为空，不成功，请检查!";
$('#lblResult10').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表DataTypeAbbr的最大关键字为：" +returnString + "!";
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
WA_DataTypeAbbr_UT_JS.btnUpdateRecord_Click = async function() {
$('#hidDivName').val("divUpdateRecord");
var objDataTypeAbbrEN = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
objDataTypeAbbrEN.DataTypeId = "11";
objDataTypeAbbrEN.DataTypeName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DataTypeENName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DataCnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DataTypeAbbr = "11111";
objDataTypeAbbrEN.NetSysType = "11111111111111111111";
objDataTypeAbbrEN.VBNETType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.CSType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.JavaType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.TypeScriptType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.JavaObjType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.SwiftType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.IsNeedQuote = false;
objDataTypeAbbrEN.OraDbType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.IsReturnType = false;
objDataTypeAbbrEN.SqlParaType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.MySqlType = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.DefaFldLength = 0;
objDataTypeAbbrEN.DefaFldPrecision = 0;
objDataTypeAbbrEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objDataTypeAbbrEN.sf_UpdFldSetStr = objDataTypeAbbrEN.UpdFldString;//设置哪些字段被修改(脏字段)
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.UpdateRecord(objDataTypeAbbrEN);
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
WA_DataTypeAbbr_UT_JS.btnDelRecord_Click = async function() {
$('#hidDivName').val("divDelRecord");
var strKeyId = $('#txtstrKeyId12').val();
var strDataTypeId = strKeyId;
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.DelRecord(strDataTypeId);
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
WA_DataTypeAbbr_UT_JS.btnDelDataTypeAbbrs_Click = async function() {
$('#hidDivName').val("divDel[TabName]s");
var strKeyIdLst = $('#txtarrKeyId13').val();
var arrDataTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.DelDataTypeAbbrs(arrDataTypeId);
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
WA_DataTypeAbbr_UT_JS.btnDelMultiRecordByCond_Click = async function() {
$('#hidDivName').val("divDelMultiRecordByCond");
var strWhereCond = $('#txtstrWhereCond14').val();
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.DelDataTypeAbbrsByCond(strWhereCond);
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
WA_DataTypeAbbr_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetFirstObj(strWhereCond);
var objDataTypeAbbrEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objDataTypeAbbrEN.DataTypeId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowDataTypeAbbrObj("divList15", objDataTypeAbbrEN);
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
WA_DataTypeAbbr_UT_JS.btnGetObjByDataTypeId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var strDataTypeId = strKeyId;
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjByDataTypeId(strDataTypeId);
var objDataTypeAbbrEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objDataTypeAbbrEN.DataTypeId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowDataTypeAbbrObj("divList16", objDataTypeAbbrEN);
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
WA_DataTypeAbbr_UT_JS.btnGetObjByDataTypeId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var strDataTypeId = strKeyId;
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjByDataTypeId_Cache(strDataTypeId);
var objDataTypeAbbrEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objDataTypeAbbrEN.DataTypeId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowDataTypeAbbrObj("divList17", objDataTypeAbbrEN);
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
WA_DataTypeAbbr_UT_JS.btnGetObjByDataTypeId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var strDataTypeId = strKeyId;
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjByDataTypeId_WA_Cache(strDataTypeId);
var objDataTypeAbbrEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objDataTypeAbbrEN.DataTypeId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowDataTypeAbbrObj("divList18", objDataTypeAbbrEN);
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
WA_DataTypeAbbr_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjLst(strWhereCond);
var arrDataTypeAbbrObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList19", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrDataTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjLstByDataTypeIdLst(arrDataTypeId);
var arrDataTypeAbbrObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList20", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrDataTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjLstByDataTypeIdLst_Cache(arrDataTypeId);
var arrDataTypeAbbrObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList21", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrDataTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjLstByDataTypeIdLst_WA_Cache(arrDataTypeId);
var arrDataTypeAbbrObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList22", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objDataTypeAbbr_Cond = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
var arrFldComparisonObj = WA_DataTypeAbbr_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objDataTypeAbbr_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
console.log(objDataTypeAbbrEN_Sim);
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetSubObjLst_Cache(objDataTypeAbbr_Cond);
var arrDataTypeAbbrObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objDataTypeAbbr_Cond) + "],共获取对象列表子集数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList23", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objDataTypeAbbr_Cond = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
var arrFldComparisonObj = WA_DataTypeAbbr_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objDataTypeAbbr_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
console.log(objDataTypeAbbrEN_Sim);
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetSubObjLst_WA_Cache(objDataTypeAbbr_Cond);
var arrDataTypeAbbrObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objDataTypeAbbr_Cond) + "],共获取对象列表子集数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList24", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetTopObjLst(objTopPara);
var arrDataTypeAbbrObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList25", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjLstByPager(objPagerPara);
var arrDataTypeAbbrObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList26", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objDataTypeAbbr_Cond = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
var arrFldComparisonObj = WA_DataTypeAbbr_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objDataTypeAbbr_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
console.log(objDataTypeAbbrEN_Sim);
strWhereCond = JSON.stringify(objDataTypeAbbrEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjLstByPager_Cache(objPagerPara);
var arrDataTypeAbbrObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList27", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objDataTypeAbbr_Cond = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
var arrFldComparisonObj = WA_DataTypeAbbr_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objDataTypeAbbr_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
console.log(objDataTypeAbbrEN_Sim);
strWhereCond = JSON.stringify(objDataTypeAbbrEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrDataTypeAbbrObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList28", arrDataTypeAbbrObjLst);
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
WA_DataTypeAbbr_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjLstByRange(objRangePara);
var arrDataTypeAbbrObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrDataTypeAbbrObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_DataTypeAbbr("divList29", arrDataTypeAbbrObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示DataTypeAbbr对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrDataTypeAbbrObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_DataTypeAbbr_UT_JS.BindTab_DataTypeAbbr = function(divContainer, arrDataTypeAbbrObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("DataTypeId"); sstrColHeader.push("数据类型Id");
sstrFldName.push("DataTypeName"); sstrColHeader.push("数据类型名称");
sstrFldName.push("DataTypeENName"); sstrColHeader.push("DataTypeENName");
sstrFldName.push("DataCnName"); sstrColHeader.push("数据类型中文名称");
sstrFldName.push("DataTypeAbbr"); sstrColHeader.push("数据类型缩写");
sstrFldName.push("NetSysType"); sstrColHeader.push("NET系统类型");
sstrFldName.push("VBNETType"); sstrColHeader.push("VBNET类型");
sstrFldName.push("CSType"); sstrColHeader.push("CS类型");
sstrFldName.push("JavaType"); sstrColHeader.push("JAVA类型");
sstrFldName.push("TypeScriptType"); sstrColHeader.push("TypeScript类型");
sstrFldName.push("JavaObjType"); sstrColHeader.push("JAVA对象类型");
sstrFldName.push("SwiftType"); sstrColHeader.push("SwiftType");
sstrFldName.push("IsNeedQuote"); sstrColHeader.push("是否需要引号");
sstrFldName.push("OraDbType"); sstrColHeader.push("Ora数据类型");
sstrFldName.push("IsReturnType"); sstrColHeader.push("是否可作返回类型");
sstrFldName.push("SqlParaType"); sstrColHeader.push("SQL参数类型");
sstrFldName.push("MySqlType"); sstrColHeader.push("MySqlType");
sstrFldName.push("DefaFldLength"); sstrColHeader.push("默认长度");
sstrFldName.push("DefaFldPrecision"); sstrColHeader.push("默认小数位数");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrDataTypeAbbrObjLst, sstrFldName, sstrColHeader, "DataTypeId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objDataTypeAbbr">需要显示的对象</param>
 /// <returns></returns>
WA_DataTypeAbbr_UT_JS.ShowDataTypeAbbrObj = function(divContainer, objDataTypeAbbr) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objDataTypeAbbr);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objDataTypeAbbr[strKey];
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
WA_DataTypeAbbr_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_DataTypeAbbr_UT_JS.GetArray(objLst) ;
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
WA_DataTypeAbbr_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_DataTypeAbbr_UT_JS.GetLocalObjLst = function() {
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
WA_DataTypeAbbr_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：DataTypeAbbr");
strKey = clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN._CurrTabName;
const responseText = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.GetObjLst_Cache();
console.log("获取缓存完成！DataTypeAbbr");
var arrDataTypeAbbrObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrDataTypeAbbrObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrDataTypeAbbrObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_DataTypeAbbr_UT_JS: CreateCache()不成功！");
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
WA_DataTypeAbbr_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_DataTypeAbbr_UT_JS;
}());
exports.WA_DataTypeAbbr_UT_JS = WA_DataTypeAbbr_UT_JS;
});