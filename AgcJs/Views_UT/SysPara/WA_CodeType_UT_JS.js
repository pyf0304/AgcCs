
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_CodeType_UT_JS
 表名:CodeType(00050203)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:59
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
define(["require", "exports", "../../Js/L0_Entity/SysPara/clsCodeTypeEN.js","../../Js/L3_ForWApi/SysPara/clsCodeTypeWApi.js","../../Js/L2_BLL/SysPara/clsCodeTypeBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsCodeTypeEN_js_1 = require("../../Js/L0_Entity/SysPara/clsCodeTypeEN.js");
var clsCodeTypeWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsCodeTypeWApi.js");
var clsCodeTypeBL_js_1 = require("../../Js/L2_BLL/SysPara/clsCodeTypeBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_CodeType_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_CodeType_UT_JS = /** @class */ (function() {
function WA_CodeType_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_CodeType_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.IsExist(strCodeTypeId);
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
WA_CodeType_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.IsExist_Cache(strCodeTypeId);
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
WA_CodeType_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.IsExistRecord(strWhereCond);
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
WA_CodeType_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objCodeType_Cond = new clsCodeTypeEN_js_1.clsCodeTypeEN();
var arrFldComparisonObj = WA_CodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCodeTypeEN_Sim = clsCodeTypeBL_js_1.clsCodeTypeBL.GetSimObjFromObj(objCodeType_Cond);
console.log(objCodeTypeEN_Sim);
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.IsExistRecord_Cache(objCodeType_Cond);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objCodeType_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objCodeType_Cond) + "]的相关记录存在!";
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
WA_CodeType_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetRecCountByCond(strWhereCond);
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
WA_CodeType_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objCodeType_Cond = new clsCodeTypeEN_js_1.clsCodeTypeEN();
var arrFldComparisonObj = WA_CodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCodeTypeEN_Sim = clsCodeTypeBL_js_1.clsCodeTypeBL.GetSimObjFromObj(objCodeType_Cond);
console.log(objCodeTypeEN_Sim);
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetRecCountByCond_Cache(objCodeType_Cond);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objCodeType_Cond) + "]的记录数:" +returnInt + "!";
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
WA_CodeType_UT_JS.btnAddNewRecord_Click = async function() {
$('#hidDivName').val("divAddNewRecord");
var objCodeTypeEN = new clsCodeTypeEN_js_1.clsCodeTypeEN();
objCodeTypeEN.CodeTypeId = "1111";
objCodeTypeEN.CodeTypeName = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.CodeTypeSimName = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.CodeTypeENName = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.GroupName = "111111111111111111111111111111";
objCodeTypeEN.ProgLangTypeId = "11";
objCodeTypeEN.RegionTypeId = "1111";
objCodeTypeEN.Prefix = "1111111111";
objCodeTypeEN.DependsOn = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.FrontOrBack = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.SQLDSTypeId = "11";
objCodeTypeEN.ClassNameFormat = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.FileNameFormat = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.ClassNamePattern = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.IsCSharp = false;
objCodeTypeEN.IsJava = false;
objCodeTypeEN.IsJavaScript = false;
objCodeTypeEN.IsTypeScript = false;
objCodeTypeEN.IsSilverLight = false;
objCodeTypeEN.IsSwift = false;
objCodeTypeEN.IsVB = false;
objCodeTypeEN.IsTableFldConst = false;
objCodeTypeEN.IsPubApp4WinWeb = false;
objCodeTypeEN.IsWeb = false;
objCodeTypeEN.IsAspMvc = false;
objCodeTypeEN.IsWebSrvAccess = false;
objCodeTypeEN.IsWin = false;
objCodeTypeEN.IsMobileApp = false;
objCodeTypeEN.IsExtend = false;
objCodeTypeEN.OrderNum = 0;
objCodeTypeEN.WinOrWeb = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.IsDirByTabName = false;
objCodeTypeEN.IsDefaultOverride = false;
objCodeTypeEN.InUse = false;
objCodeTypeEN.IsAutoParseFile = false;
objCodeTypeEN.UpdDate = "11111111111111111111";
objCodeTypeEN.UpdUser = "11111111111111111111";
objCodeTypeEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.IsExist(objCodeTypeEN.CodeTypeId);
var bolIsExist = responseText;
if (bolIsExist == true)
{
var strMsg = "添加记录时，关键字：" +objCodeTypeEN.CodeTypeId  + "已经存在！";
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.AddNewRecord(objCodeTypeEN);
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
WA_CodeType_UT_JS.btnAddNewRecord4GetMaxStrId_Click = async function() {
$('#hidDivName').val("divAddNewRecord4GetMaxStrId");
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetMaxStrId();
var returnString = responseText.toString();
var objCodeTypeEN = new clsCodeTypeEN_js_1.clsCodeTypeEN();
objCodeTypeEN.CodeTypeId = returnString;
objCodeTypeEN.CodeTypeName = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.CodeTypeSimName = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.CodeTypeENName = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.GroupName = "111111111111111111111111111111";
objCodeTypeEN.ProgLangTypeId = "11";
objCodeTypeEN.RegionTypeId = "1111";
objCodeTypeEN.Prefix = "1111111111";
objCodeTypeEN.DependsOn = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.FrontOrBack = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.SQLDSTypeId = "11";
objCodeTypeEN.ClassNameFormat = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.FileNameFormat = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.ClassNamePattern = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.IsCSharp = false;
objCodeTypeEN.IsJava = false;
objCodeTypeEN.IsJavaScript = false;
objCodeTypeEN.IsTypeScript = false;
objCodeTypeEN.IsSilverLight = false;
objCodeTypeEN.IsSwift = false;
objCodeTypeEN.IsVB = false;
objCodeTypeEN.IsTableFldConst = false;
objCodeTypeEN.IsPubApp4WinWeb = false;
objCodeTypeEN.IsWeb = false;
objCodeTypeEN.IsAspMvc = false;
objCodeTypeEN.IsWebSrvAccess = false;
objCodeTypeEN.IsWin = false;
objCodeTypeEN.IsMobileApp = false;
objCodeTypeEN.IsExtend = false;
objCodeTypeEN.OrderNum = 0;
objCodeTypeEN.WinOrWeb = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.IsDirByTabName = false;
objCodeTypeEN.IsDefaultOverride = false;
objCodeTypeEN.InUse = false;
objCodeTypeEN.IsAutoParseFile = false;
objCodeTypeEN.UpdDate = "11111111111111111111";
objCodeTypeEN.UpdUser = "11111111111111111111";
objCodeTypeEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.AddNewRecord(objCodeTypeEN);
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
WA_CodeType_UT_JS.btnGetMaxStrId_Click = async function() {
$('#hidDivName').val("divGetMaxStrId");
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表CodeType的最大关键字为空，不成功，请检查!";
$('#lblResult9').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表CodeType的最大关键字为：" +returnString + "!";
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
WA_CodeType_UT_JS.btnGetMaxStrIdByPrefix_Click = async function() {
$('#hidDivName').val("divGetMaxStrIdByPrefix");
var strPrefix = $('#txtstrPrefix10').val();
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetMaxStrIdByPrefix(strPrefix);
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表CodeType的最大关键字为空，不成功，请检查!";
$('#lblResult10').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表CodeType的最大关键字为：" +returnString + "!";
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
WA_CodeType_UT_JS.btnUpdateRecord_Click = async function() {
$('#hidDivName').val("divUpdateRecord");
var objCodeTypeEN = new clsCodeTypeEN_js_1.clsCodeTypeEN();
objCodeTypeEN.CodeTypeId = "1111";
objCodeTypeEN.CodeTypeName = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.CodeTypeSimName = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.CodeTypeENName = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.GroupName = "111111111111111111111111111111";
objCodeTypeEN.ProgLangTypeId = "11";
objCodeTypeEN.RegionTypeId = "1111";
objCodeTypeEN.Prefix = "1111111111";
objCodeTypeEN.DependsOn = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.FrontOrBack = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.SQLDSTypeId = "11";
objCodeTypeEN.ClassNameFormat = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.FileNameFormat = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.ClassNamePattern = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.IsCSharp = false;
objCodeTypeEN.IsJava = false;
objCodeTypeEN.IsJavaScript = false;
objCodeTypeEN.IsTypeScript = false;
objCodeTypeEN.IsSilverLight = false;
objCodeTypeEN.IsSwift = false;
objCodeTypeEN.IsVB = false;
objCodeTypeEN.IsTableFldConst = false;
objCodeTypeEN.IsPubApp4WinWeb = false;
objCodeTypeEN.IsWeb = false;
objCodeTypeEN.IsAspMvc = false;
objCodeTypeEN.IsWebSrvAccess = false;
objCodeTypeEN.IsWin = false;
objCodeTypeEN.IsMobileApp = false;
objCodeTypeEN.IsExtend = false;
objCodeTypeEN.OrderNum = 0;
objCodeTypeEN.WinOrWeb = "11111111111111111111111111111111111111111111111111";
objCodeTypeEN.IsDirByTabName = false;
objCodeTypeEN.IsDefaultOverride = false;
objCodeTypeEN.InUse = false;
objCodeTypeEN.IsAutoParseFile = false;
objCodeTypeEN.UpdDate = "11111111111111111111";
objCodeTypeEN.UpdUser = "11111111111111111111";
objCodeTypeEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objCodeTypeEN.sf_UpdFldSetStr = objCodeTypeEN.UpdFldString;//设置哪些字段被修改(脏字段)
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.UpdateRecord(objCodeTypeEN);
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
WA_CodeType_UT_JS.btnDelRecord_Click = async function() {
$('#hidDivName').val("divDelRecord");
var strKeyId = $('#txtstrKeyId12').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.DelRecord(strCodeTypeId);
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
WA_CodeType_UT_JS.btnDelCodeTypes_Click = async function() {
$('#hidDivName').val("divDel[TabName]s");
var strKeyIdLst = $('#txtarrKeyId13').val();
var arrCodeTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.DelCodeTypes(arrCodeTypeId);
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
WA_CodeType_UT_JS.btnDelMultiRecordByCond_Click = async function() {
$('#hidDivName').val("divDelMultiRecordByCond");
var strWhereCond = $('#txtstrWhereCond14').val();
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.DelCodeTypesByCond(strWhereCond);
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
WA_CodeType_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetFirstObj(strWhereCond);
var objCodeTypeEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objCodeTypeEN.CodeTypeId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowCodeTypeObj("divList15", objCodeTypeEN);
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
WA_CodeType_UT_JS.btnGetObjByCodeTypeId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjByCodeTypeId(strCodeTypeId);
var objCodeTypeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objCodeTypeEN.CodeTypeId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowCodeTypeObj("divList16", objCodeTypeEN);
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
WA_CodeType_UT_JS.btnGetObjByCodeTypeId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjByCodeTypeId_Cache(strCodeTypeId);
var objCodeTypeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objCodeTypeEN.CodeTypeId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowCodeTypeObj("divList17", objCodeTypeEN);
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
WA_CodeType_UT_JS.btnGetObjByCodeTypeId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var strCodeTypeId = strKeyId;
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjByCodeTypeId_WA_Cache(strCodeTypeId);
var objCodeTypeEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objCodeTypeEN.CodeTypeId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowCodeTypeObj("divList18", objCodeTypeEN);
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
WA_CodeType_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLst(strWhereCond);
var arrCodeTypeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList19", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrCodeTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLstByCodeTypeIdLst(arrCodeTypeId);
var arrCodeTypeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList20", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrCodeTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLstByCodeTypeIdLst_Cache(arrCodeTypeId);
var arrCodeTypeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList21", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrCodeTypeId = strKeyIdLst.split(',');
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLstByCodeTypeIdLst_WA_Cache(arrCodeTypeId);
var arrCodeTypeObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList22", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objCodeType_Cond = new clsCodeTypeEN_js_1.clsCodeTypeEN();
var arrFldComparisonObj = WA_CodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCodeTypeEN_Sim = clsCodeTypeBL_js_1.clsCodeTypeBL.GetSimObjFromObj(objCodeType_Cond);
console.log(objCodeTypeEN_Sim);
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetSubObjLst_Cache(objCodeType_Cond);
var arrCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objCodeType_Cond) + "],共获取对象列表子集数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList23", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objCodeType_Cond = new clsCodeTypeEN_js_1.clsCodeTypeEN();
var arrFldComparisonObj = WA_CodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCodeTypeEN_Sim = clsCodeTypeBL_js_1.clsCodeTypeBL.GetSimObjFromObj(objCodeType_Cond);
console.log(objCodeTypeEN_Sim);
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetSubObjLst_WA_Cache(objCodeType_Cond);
var arrCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objCodeType_Cond) + "],共获取对象列表子集数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList24", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetTopObjLst(objTopPara);
var arrCodeTypeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList25", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLstByPager(objPagerPara);
var arrCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList26", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objCodeType_Cond = new clsCodeTypeEN_js_1.clsCodeTypeEN();
var arrFldComparisonObj = WA_CodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCodeTypeEN_Sim = clsCodeTypeBL_js_1.clsCodeTypeBL.GetSimObjFromObj(objCodeType_Cond);
console.log(objCodeTypeEN_Sim);
strWhereCond = JSON.stringify(objCodeTypeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLstByPager_Cache(objPagerPara);
var arrCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList27", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objCodeType_Cond = new clsCodeTypeEN_js_1.clsCodeTypeEN();
var arrFldComparisonObj = WA_CodeType_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objCodeType_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objCodeTypeEN_Sim = clsCodeTypeBL_js_1.clsCodeTypeBL.GetSimObjFromObj(objCodeType_Cond);
console.log(objCodeTypeEN_Sim);
strWhereCond = JSON.stringify(objCodeTypeEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrCodeTypeObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList28", arrCodeTypeObjLst);
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
WA_CodeType_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLstByRange(objRangePara);
var arrCodeTypeObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrCodeTypeObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_CodeType("divList29", arrCodeTypeObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示CodeType对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrCodeTypeObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_CodeType_UT_JS.BindTab_CodeType = function(divContainer, arrCodeTypeObjLst) 
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
sstrFldName.push("RegionTypeId"); sstrColHeader.push("区域类型Id");
sstrFldName.push("Prefix"); sstrColHeader.push("前缀");
sstrFldName.push("DependsOn"); sstrColHeader.push("依赖于");
sstrFldName.push("FrontOrBack"); sstrColHeader.push("前台Or后台");
sstrFldName.push("SQLDSTypeId"); sstrColHeader.push("数据源类型");
sstrFldName.push("ClassNameFormat"); sstrColHeader.push("类名格式");
sstrFldName.push("FileNameFormat"); sstrColHeader.push("文件名格式");
sstrFldName.push("ClassNamePattern"); sstrColHeader.push("类名模式");
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
sstrFldName.push("IsExtend"); sstrColHeader.push("是否扩展类");
sstrFldName.push("OrderNum"); sstrColHeader.push("序号");
sstrFldName.push("WinOrWeb"); sstrColHeader.push("WinOrWeb");
sstrFldName.push("IsDirByTabName"); sstrColHeader.push("是否用表名作为路径");
sstrFldName.push("IsDefaultOverride"); sstrColHeader.push("是否默认覆盖");
sstrFldName.push("InUse"); sstrColHeader.push("是否在用");
sstrFldName.push("IsAutoParseFile"); sstrColHeader.push("是否自动分析文件");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("UpdUser"); sstrColHeader.push("修改者");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrCodeTypeObjLst, sstrFldName, sstrColHeader, "CodeTypeId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objCodeType">需要显示的对象</param>
 /// <returns></returns>
WA_CodeType_UT_JS.ShowCodeTypeObj = function(divContainer, objCodeType) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objCodeType);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objCodeType[strKey];
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
WA_CodeType_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_CodeType_UT_JS.GetArray(objLst) ;
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
WA_CodeType_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsCodeTypeEN_js_1.clsCodeTypeEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_CodeType_UT_JS.GetLocalObjLst = function() {
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
WA_CodeType_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：CodeType");
strKey = clsCodeTypeEN_js_1.clsCodeTypeEN._CurrTabName;
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLst_Cache();
console.log("获取缓存完成！CodeType");
var arrCodeTypeObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrCodeTypeObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrCodeTypeObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_CodeType_UT_JS: CreateCache()不成功！");
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
WA_CodeType_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_CodeType_UT_JS;
}());
exports.WA_CodeType_UT_JS = WA_CodeType_UT_JS;
});