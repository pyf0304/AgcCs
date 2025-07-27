
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_FieldTab_UT_JS
 表名:FieldTab(00050021)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:02
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
define(["require", "exports", "../../Js/L0_Entity/Table_Field/clsFieldTabEN.js","../../Js/L3_ForWApi/Table_Field/clsFieldTabWApi.js","../../Js/L2_BLL/Table_Field/clsFieldTabBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsFieldTabEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsFieldTabEN.js");
var clsFieldTabWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsFieldTabWApi.js");
var clsFieldTabBL_js_1 = require("../../Js/L2_BLL/Table_Field/clsFieldTabBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_FieldTab_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_FieldTab_UT_JS = /** @class */ (function() {
function WA_FieldTab_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_FieldTab_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var strFldId = strKeyId;
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.IsExist(strFldId);
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
WA_FieldTab_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var strFldId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.IsExist_Cache(strFldId, strPrjId);
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
WA_FieldTab_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.IsExistRecord(strWhereCond);
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
WA_FieldTab_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objFieldTab_Cond = new clsFieldTabEN_js_1.clsFieldTabEN();
objFieldTab_Cond.SetCondFldValue(clsFieldTabEN_js_1.clsFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_FieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objFieldTabEN_Sim = clsFieldTabBL_js_1.clsFieldTabBL.GetSimObjFromObj(objFieldTab_Cond);
console.log(objFieldTabEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.IsExistRecord_Cache(objFieldTab_Cond, strPrjId);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objFieldTab_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objFieldTab_Cond) + "]的相关记录存在!";
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
WA_FieldTab_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetRecCountByCond(strWhereCond);
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
WA_FieldTab_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objFieldTab_Cond = new clsFieldTabEN_js_1.clsFieldTabEN();
objFieldTab_Cond.SetCondFldValue(clsFieldTabEN_js_1.clsFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_FieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objFieldTabEN_Sim = clsFieldTabBL_js_1.clsFieldTabBL.GetSimObjFromObj(objFieldTab_Cond);
console.log(objFieldTabEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetRecCountByCond_Cache(objFieldTab_Cond, strPrjId);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objFieldTab_Cond) + "]的记录数:" +returnInt + "!";
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
WA_FieldTab_UT_JS.btnAddNewRecord_Click = async function() {
$('#hidDivName').val("divAddNewRecord");
var objFieldTabEN = new clsFieldTabEN_js_1.clsFieldTabEN();
objFieldTabEN.FldId = "11111111";
objFieldTabEN.PrjId = "1111";
objFieldTabEN.FldName = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.FldCnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.FldEnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.FldName_B = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.FldName_G = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.Caption = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.FieldTypeId = "11";
objFieldTabEN.DataTypeId = "11";
objFieldTabEN.FldLength = 0;
objFieldTabEN.FldPrecision = 0;
objFieldTabEN.FldInfo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.IsNull = false;
objFieldTabEN.IsPrimaryKey = false;
objFieldTabEN.IsIdentity = false;
objFieldTabEN.IsNationStandard = false;
objFieldTabEN.IsChecked = false;
objFieldTabEN.IsArchive = false;
objFieldTabEN.IsOnlyOne = false;
objFieldTabEN.MaxValue = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.MinValue = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.DefaultValue = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.IsNeedTransCode = false;
objFieldTabEN.AppliedScope = "1111111111";
objFieldTabEN.FldStateId = "11";
objFieldTabEN.CodeTabId = "11111111";
objFieldTabEN.CodeTab_NameId = "11111111";
objFieldTabEN.CodeTab_CodeId = "11111111";
objFieldTabEN.IsRootFld = false;
objFieldTabEN.Root4TabId = "11111111";
objFieldTabEN.RootFldId = "11111111";
objFieldTabEN.RootTabId = "11111111";
objFieldTabEN.IsSynchToServer = false;
objFieldTabEN.SynchToServerDate = "11111111111111111111";
objFieldTabEN.SynchToServerUser = "11111111111111111111";
objFieldTabEN.IsSynchToClient = false;
objFieldTabEN.SynchToClientDate = "11111111111111111111";
objFieldTabEN.SynchToClientUser = "11111111111111111111";
objFieldTabEN.SynSource = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.UpdDate = "11111111111111111111";
objFieldTabEN.UpdUser = "11111111111111111111";
objFieldTabEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.IsExist(objFieldTabEN.FldId);
var bolIsExist = responseText;
if (bolIsExist == true)
{
var strMsg = "添加记录时，关键字：" +objFieldTabEN.FldId  + "已经存在！";
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsFieldTabWApi_js_1.clsFieldTabWApi.AddNewRecord(objFieldTabEN);
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
WA_FieldTab_UT_JS.btnAddNewRecord4GetMaxStrId_Click = async function() {
$('#hidDivName').val("divAddNewRecord4GetMaxStrId");
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetMaxStrId();
var returnString = responseText.toString();
var objFieldTabEN = new clsFieldTabEN_js_1.clsFieldTabEN();
objFieldTabEN.FldId = returnString;
objFieldTabEN.PrjId = "1111";
objFieldTabEN.FldName = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.FldCnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.FldEnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.FldName_B = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.FldName_G = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.Caption = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.FieldTypeId = "11";
objFieldTabEN.DataTypeId = "11";
objFieldTabEN.FldLength = 0;
objFieldTabEN.FldPrecision = 0;
objFieldTabEN.FldInfo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.IsNull = false;
objFieldTabEN.IsPrimaryKey = false;
objFieldTabEN.IsIdentity = false;
objFieldTabEN.IsNationStandard = false;
objFieldTabEN.IsChecked = false;
objFieldTabEN.IsArchive = false;
objFieldTabEN.IsOnlyOne = false;
objFieldTabEN.MaxValue = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.MinValue = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.DefaultValue = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.IsNeedTransCode = false;
objFieldTabEN.AppliedScope = "1111111111";
objFieldTabEN.FldStateId = "11";
objFieldTabEN.CodeTabId = "11111111";
objFieldTabEN.CodeTab_NameId = "11111111";
objFieldTabEN.CodeTab_CodeId = "11111111";
objFieldTabEN.IsRootFld = false;
objFieldTabEN.Root4TabId = "11111111";
objFieldTabEN.RootFldId = "11111111";
objFieldTabEN.RootTabId = "11111111";
objFieldTabEN.IsSynchToServer = false;
objFieldTabEN.SynchToServerDate = "11111111111111111111";
objFieldTabEN.SynchToServerUser = "11111111111111111111";
objFieldTabEN.IsSynchToClient = false;
objFieldTabEN.SynchToClientDate = "11111111111111111111";
objFieldTabEN.SynchToClientUser = "11111111111111111111";
objFieldTabEN.SynSource = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.UpdDate = "11111111111111111111";
objFieldTabEN.UpdUser = "11111111111111111111";
objFieldTabEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.AddNewRecord(objFieldTabEN);
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
WA_FieldTab_UT_JS.btnGetMaxStrId_Click = async function() {
$('#hidDivName').val("divGetMaxStrId");
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表FieldTab的最大关键字为空，不成功，请检查!";
$('#lblResult9').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表FieldTab的最大关键字为：" +returnString + "!";
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
WA_FieldTab_UT_JS.btnGetMaxStrIdByPrefix_Click = async function() {
$('#hidDivName').val("divGetMaxStrIdByPrefix");
var strPrefix = $('#txtstrPrefix10').val();
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetMaxStrIdByPrefix(strPrefix);
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表FieldTab的最大关键字为空，不成功，请检查!";
$('#lblResult10').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表FieldTab的最大关键字为：" +returnString + "!";
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
WA_FieldTab_UT_JS.btnUpdateRecord_Click = async function() {
$('#hidDivName').val("divUpdateRecord");
var objFieldTabEN = new clsFieldTabEN_js_1.clsFieldTabEN();
objFieldTabEN.FldId = "11111111";
objFieldTabEN.PrjId = "1111";
objFieldTabEN.FldName = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.FldCnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.FldEnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.FldName_B = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.FldName_G = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.Caption = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.FieldTypeId = "11";
objFieldTabEN.DataTypeId = "11";
objFieldTabEN.FldLength = 0;
objFieldTabEN.FldPrecision = 0;
objFieldTabEN.FldInfo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.IsNull = false;
objFieldTabEN.IsPrimaryKey = false;
objFieldTabEN.IsIdentity = false;
objFieldTabEN.IsNationStandard = false;
objFieldTabEN.IsChecked = false;
objFieldTabEN.IsArchive = false;
objFieldTabEN.IsOnlyOne = false;
objFieldTabEN.MaxValue = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.MinValue = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.DefaultValue = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.IsNeedTransCode = false;
objFieldTabEN.AppliedScope = "1111111111";
objFieldTabEN.FldStateId = "11";
objFieldTabEN.CodeTabId = "11111111";
objFieldTabEN.CodeTab_NameId = "11111111";
objFieldTabEN.CodeTab_CodeId = "11111111";
objFieldTabEN.IsRootFld = false;
objFieldTabEN.Root4TabId = "11111111";
objFieldTabEN.RootFldId = "11111111";
objFieldTabEN.RootTabId = "11111111";
objFieldTabEN.IsSynchToServer = false;
objFieldTabEN.SynchToServerDate = "11111111111111111111";
objFieldTabEN.SynchToServerUser = "11111111111111111111";
objFieldTabEN.IsSynchToClient = false;
objFieldTabEN.SynchToClientDate = "11111111111111111111";
objFieldTabEN.SynchToClientUser = "11111111111111111111";
objFieldTabEN.SynSource = "11111111111111111111111111111111111111111111111111";
objFieldTabEN.UpdDate = "11111111111111111111";
objFieldTabEN.UpdUser = "11111111111111111111";
objFieldTabEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objFieldTabEN.sf_UpdFldSetStr = objFieldTabEN.UpdFldString;//设置哪些字段被修改(脏字段)
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.UpdateRecord(objFieldTabEN);
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
WA_FieldTab_UT_JS.btnDelRecord_Click = async function() {
$('#hidDivName').val("divDelRecord");
var strKeyId = $('#txtstrKeyId12').val();
var strFldId = strKeyId;
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.DelRecord(strFldId);
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
WA_FieldTab_UT_JS.btnDelFieldTabs_Click = async function() {
$('#hidDivName').val("divDel[TabName]s");
var strKeyIdLst = $('#txtarrKeyId13').val();
var arrFldId = strKeyIdLst.split(',');
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.DelFieldTabs(arrFldId);
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
WA_FieldTab_UT_JS.btnDelMultiRecordByCond_Click = async function() {
$('#hidDivName').val("divDelMultiRecordByCond");
var strWhereCond = $('#txtstrWhereCond14').val();
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.DelFieldTabsByCond(strWhereCond);
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
WA_FieldTab_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetFirstObj(strWhereCond);
var objFieldTabEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objFieldTabEN.FldId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowFieldTabObj("divList15", objFieldTabEN);
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
WA_FieldTab_UT_JS.btnGetObjByFldId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var strFldId = strKeyId;
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjByFldId(strFldId);
var objFieldTabEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objFieldTabEN.FldId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowFieldTabObj("divList16", objFieldTabEN);
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
WA_FieldTab_UT_JS.btnGetObjByFldId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var strFldId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjByFldId_Cache(strFldId, strPrjId);
var objFieldTabEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objFieldTabEN.FldId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowFieldTabObj("divList17", objFieldTabEN);
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
WA_FieldTab_UT_JS.btnGetObjByFldId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var strFldId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjByFldId_WA_Cache(strFldId, strPrjId);
var objFieldTabEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objFieldTabEN.FldId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowFieldTabObj("divList18", objFieldTabEN);
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
WA_FieldTab_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjLst(strWhereCond);
var arrFieldTabObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrFieldTabObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList19", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrFldId = strKeyIdLst.split(',');
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjLstByFldIdLst(arrFldId);
var arrFieldTabObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrFieldTabObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList20", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrFldId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjLstByFldIdLst_Cache(arrFldId, strPrjId);
var arrFieldTabObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrFieldTabObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList21", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrFldId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjLstByFldIdLst_WA_Cache(arrFldId, strPrjId);
var arrFieldTabObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrFieldTabObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList22", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objFieldTab_Cond = new clsFieldTabEN_js_1.clsFieldTabEN();
objFieldTab_Cond.SetCondFldValue(clsFieldTabEN_js_1.clsFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_FieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objFieldTabEN_Sim = clsFieldTabBL_js_1.clsFieldTabBL.GetSimObjFromObj(objFieldTab_Cond);
console.log(objFieldTabEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetSubObjLst_Cache(objFieldTab_Cond, strPrjId);
var arrFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objFieldTab_Cond) + "],共获取对象列表子集数：" +arrFieldTabObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList23", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objFieldTab_Cond = new clsFieldTabEN_js_1.clsFieldTabEN();
objFieldTab_Cond.SetCondFldValue(clsFieldTabEN_js_1.clsFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_FieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objFieldTabEN_Sim = clsFieldTabBL_js_1.clsFieldTabBL.GetSimObjFromObj(objFieldTab_Cond);
console.log(objFieldTabEN_Sim);
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetSubObjLst_WA_Cache(objFieldTab_Cond);
var arrFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objFieldTab_Cond) + "],共获取对象列表子集数：" +arrFieldTabObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList24", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetTopObjLst(objTopPara);
var arrFieldTabObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrFieldTabObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList25", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjLstByPager(objPagerPara);
var arrFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrFieldTabObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList26", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objFieldTab_Cond = new clsFieldTabEN_js_1.clsFieldTabEN();
var strPrjId = "0001";
objFieldTab_Cond.SetCondFldValue(clsFieldTabEN_js_1.clsFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_FieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objFieldTabEN_Sim = clsFieldTabBL_js_1.clsFieldTabBL.GetSimObjFromObj(objFieldTab_Cond);
console.log(objFieldTabEN_Sim);
strWhereCond = JSON.stringify(objFieldTabEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjLstByPager_Cache(objPagerPara, strPrjId);
var arrFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrFieldTabObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList27", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objFieldTab_Cond = new clsFieldTabEN_js_1.clsFieldTabEN();
objFieldTab_Cond.SetCondFldValue(clsFieldTabEN_js_1.clsFieldTabEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_FieldTab_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objFieldTab_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objFieldTabEN_Sim = clsFieldTabBL_js_1.clsFieldTabBL.GetSimObjFromObj(objFieldTab_Cond);
console.log(objFieldTabEN_Sim);
strWhereCond = JSON.stringify(objFieldTabEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrFieldTabObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrFieldTabObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList28", arrFieldTabObjLst);
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
WA_FieldTab_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjLstByRange(objRangePara);
var arrFieldTabObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrFieldTabObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_FieldTab("divList29", arrFieldTabObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示FieldTab对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrFieldTabObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_FieldTab_UT_JS.BindTab_FieldTab = function(divContainer, arrFieldTabObjLst) 
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
sstrFldName.push("PrjId"); sstrColHeader.push("工程ID");
sstrFldName.push("FldName"); sstrColHeader.push("字段名");
sstrFldName.push("FldCnName"); sstrColHeader.push("字段中文详名");
sstrFldName.push("FldEnName"); sstrColHeader.push("字段英文详名");
sstrFldName.push("FldName_B"); sstrColHeader.push("字段名_后备");
sstrFldName.push("FldName_G"); sstrColHeader.push("字段名_国标");
sstrFldName.push("Caption"); sstrColHeader.push("标题");
sstrFldName.push("FieldTypeId"); sstrColHeader.push("字段类型Id");
sstrFldName.push("DataTypeId"); sstrColHeader.push("数据类型Id");
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
sstrFldName.push("Root4TabId"); sstrColHeader.push("主根表Id");
sstrFldName.push("RootFldId"); sstrColHeader.push("根字段Id");
sstrFldName.push("RootTabId"); sstrColHeader.push("根表Id");
sstrFldName.push("IsSynchToServer"); sstrColHeader.push("是否同步到Server");
sstrFldName.push("SynchToServerDate"); sstrColHeader.push("同步到Server日期");
sstrFldName.push("SynchToServerUser"); sstrColHeader.push("同步到Server用户");
sstrFldName.push("IsSynchToClient"); sstrColHeader.push("是否同步到Client");
sstrFldName.push("SynchToClientDate"); sstrColHeader.push("同步到Client库日期");
sstrFldName.push("SynchToClientUser"); sstrColHeader.push("同步到Client库用户");
sstrFldName.push("SynSource"); sstrColHeader.push("同步来源");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("UpdUser"); sstrColHeader.push("修改者");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrFieldTabObjLst, sstrFldName, sstrColHeader, "FldId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objFieldTab">需要显示的对象</param>
 /// <returns></returns>
WA_FieldTab_UT_JS.ShowFieldTabObj = function(divContainer, objFieldTab) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objFieldTab);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objFieldTab[strKey];
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
WA_FieldTab_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_FieldTab_UT_JS.GetArray(objLst) ;
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
WA_FieldTab_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsFieldTabEN_js_1.clsFieldTabEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_FieldTab_UT_JS.GetLocalObjLst = function() {
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
WA_FieldTab_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：FieldTab");
var strPrjId = "0001";
var strKey =  clsFieldTabEN_js_1.clsFieldTabEN._CurrTabName + "_" + strPrjId ;
const responseText = await clsFieldTabWApi_js_1.clsFieldTabWApi.GetObjLst_Cache(strPrjId);
console.log("获取缓存完成！FieldTab");
var arrFieldTabObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrFieldTabObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrFieldTabObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_FieldTab_UT_JS: CreateCache()不成功！");
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
WA_FieldTab_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_FieldTab_UT_JS;
}());
exports.WA_FieldTab_UT_JS = WA_FieldTab_UT_JS;
});