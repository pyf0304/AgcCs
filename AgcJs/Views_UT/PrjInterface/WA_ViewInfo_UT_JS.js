
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_ViewInfo_UT_JS
 表名:ViewInfo(00050006)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:16
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
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
define(["require", "exports", "../../Js/L0_Entity/PrjInterface/clsViewInfoEN.js","../../Js/L3_ForWApi/PrjInterface/clsViewInfoWApi.js","../../Js/L2_BLL/PrjInterface/clsViewInfoBL.js","clscommonfunc4web","../../Js/PubFun/stuTopPara.js","../../Js/PubFun/stuRangePara.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsPubFun.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
/////import * as $ from "jquery";
var clsViewInfoEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsViewInfoEN.js");
var clsViewInfoWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsViewInfoWApi.js");
var clsViewInfoBL_js_1 = require("../../Js/L2_BLL/PrjInterface/clsViewInfoBL.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var stuTopPara_js_1 = require("../../Js/PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../Js/PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
 /// <summary>
 /// WA_ViewInfo_UT_JS 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.WA_ViewUTScriptCSRJ4JavaScript:GeneCode)
 /// </summary>
var WA_ViewInfo_UT_JS = /** @class */ (function() {
function WA_ViewInfo_UT_JS()
{
}


 /// <summary>
 /// 检查相应关键字的记录是否存在
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_btnClickIsExist)
 /// </summary>
 /// <param name = "sender">发送者</param>
 /// <returns>返回是否存在</returns>
WA_ViewInfo_UT_JS.btnIsExist_Click = async function() {
$('#hidDivName').val("divIsExist");
var strKeyId = $('#txtstrKeyId1').val();
var strViewId = strKeyId;
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.IsExist(strViewId);
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
WA_ViewInfo_UT_JS.btnIsExist_Cache_Click = async function() {
$('#hidDivName').val("divIsExist_Cache");
var strKeyId = $('#txtstrKeyId2').val();
var strViewId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.IsExist_Cache(strViewId, strPrjId);
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
WA_ViewInfo_UT_JS.btnIsExistRecord_Click = async function() {
$('#hidDivName').val("divIsExistRecord");
var strWhereCond = $('#txtstrWhereCond3').val();
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.IsExistRecord(strWhereCond);
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
WA_ViewInfo_UT_JS.btnIsExistRecord_Cache_Click = async function() {
$('#hidDivName').val("divIsExistRecord_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond4').val();
var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();
objViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_ViewInfo_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objViewInfo_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objViewInfoEN_Sim = clsViewInfoBL_js_1.clsViewInfoBL.GetSimObjFromObj(objViewInfo_Cond);
console.log(objViewInfoEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.IsExistRecord_Cache(objViewInfo_Cond, strPrjId);
var returnBool = responseText;
if (returnBool == false)
{
var strInfo = "根据条件:[" +JSON.stringify(objViewInfo_Cond) + "]的记录不存在!";
$('#lblResult4').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "根据条件:[" +JSON.stringify(objViewInfo_Cond) + "]的相关记录存在!";
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
WA_ViewInfo_UT_JS.btnGetRecCountByCond_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond");
var strWhereCond = $('#txtstrWhereCond5').val();
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetRecCountByCond(strWhereCond);
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
WA_ViewInfo_UT_JS.btnGetRecCountByCond_Cache_Click = async function() {
$('#hidDivName').val("divGetRecCountByCond_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond6').val();
var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();
objViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_ViewInfo_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length );
arrFldComparisonObj.forEach(x => { objViewInfo_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objViewInfoEN_Sim = clsViewInfoBL_js_1.clsViewInfoBL.GetSimObjFromObj(objViewInfo_Cond);
console.log(objViewInfoEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetRecCountByCond_Cache(objViewInfo_Cond, strPrjId);
var returnInt = Number(responseText);
var strInfo = "根据条件:[" +JSON.stringify(objViewInfo_Cond) + "]的记录数:" +returnInt + "!";
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
WA_ViewInfo_UT_JS.btnAddNewRecord_Click = async function() {
$('#hidDivName').val("divAddNewRecord");
var objViewInfoEN = new clsViewInfoEN_js_1.clsViewInfoEN();
objViewInfoEN.ViewId = "11111111";
objViewInfoEN.ViewName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.ViewTypeCode = 0;
objViewInfoEN.ApplicationTypeId = 0;
objViewInfoEN.FuncModuleAgcId = "11111111";
objViewInfoEN.DataBaseName = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.KeyForMainTab = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.KeyForDetailTab = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.IsNeedSort = false;
objViewInfoEN.IsNeedTransCode = false;
objViewInfoEN.IsNeedSetExportFld = false;
objViewInfoEN.UserId = "111111111111111111";
objViewInfoEN.PrjId = "1111";
objViewInfoEN.ViewFunction = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.ViewDetail = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.DefaMenuName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.DetailTabId = "11111111";
objViewInfoEN.FileName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.FilePath = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.MainTabId = "11111111";
objViewInfoEN.ViewCnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.ViewGroupId = "11111111";
objViewInfoEN.INRelaTabId = "11111111";
objViewInfoEN.INSQLDSTypeId = "11";
objViewInfoEN.OUTRelaTabId = "11111111";
objViewInfoEN.OUTSQLDSTypeId = "11";
objViewInfoEN.DetailTabType = "1111111111";
objViewInfoEN.DetailViewId = "11111111";
objViewInfoEN.MainTabType = "1111111111";
objViewInfoEN.IsUseCache4List = false;
objViewInfoEN.MainViewId = "11111111";
objViewInfoEN.GeneCodeDate = "11111111111111111111";
objViewInfoEN.TaskId = "1111111111111111";
objViewInfoEN.RegionNum = 0;
objViewInfoEN.UpdDate = "11111111111111111111";
objViewInfoEN.UpdUserId = "11111111111111111111";
objViewInfoEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.IsSynchToServer = false;
objViewInfoEN.SynchToServerDate = "11111111111111111111";
objViewInfoEN.SynchToServerUser = "11111111111111111111";
objViewInfoEN.IsSynchToClient = false;
objViewInfoEN.SynchToClientDate = "11111111111111111111";
objViewInfoEN.SynchToClientUser = "11111111111111111111";
objViewInfoEN.SynSource = "11111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.IsExist(objViewInfoEN.ViewId);
var bolIsExist = responseText;
if (bolIsExist == true)
{
var strMsg = "添加记录时，关键字：" +objViewInfoEN.ViewId  + "已经存在！";
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsViewInfoWApi_js_1.clsViewInfoWApi.AddNewRecord(objViewInfoEN);
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
WA_ViewInfo_UT_JS.btnAddNewRecord4GetMaxStrId_Click = async function() {
$('#hidDivName').val("divAddNewRecord4GetMaxStrId");
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetMaxStrId();
var returnString = responseText.toString();
var objViewInfoEN = new clsViewInfoEN_js_1.clsViewInfoEN();
objViewInfoEN.ViewId = returnString;
objViewInfoEN.ViewName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.ViewTypeCode = 0;
objViewInfoEN.ApplicationTypeId = 0;
objViewInfoEN.FuncModuleAgcId = "11111111";
objViewInfoEN.DataBaseName = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.KeyForMainTab = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.KeyForDetailTab = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.IsNeedSort = false;
objViewInfoEN.IsNeedTransCode = false;
objViewInfoEN.IsNeedSetExportFld = false;
objViewInfoEN.UserId = "111111111111111111";
objViewInfoEN.PrjId = "1111";
objViewInfoEN.ViewFunction = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.ViewDetail = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.DefaMenuName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.DetailTabId = "11111111";
objViewInfoEN.FileName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.FilePath = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.MainTabId = "11111111";
objViewInfoEN.ViewCnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.ViewGroupId = "11111111";
objViewInfoEN.INRelaTabId = "11111111";
objViewInfoEN.INSQLDSTypeId = "11";
objViewInfoEN.OUTRelaTabId = "11111111";
objViewInfoEN.OUTSQLDSTypeId = "11";
objViewInfoEN.DetailTabType = "1111111111";
objViewInfoEN.DetailViewId = "11111111";
objViewInfoEN.MainTabType = "1111111111";
objViewInfoEN.IsUseCache4List = false;
objViewInfoEN.MainViewId = "11111111";
objViewInfoEN.GeneCodeDate = "11111111111111111111";
objViewInfoEN.TaskId = "1111111111111111";
objViewInfoEN.RegionNum = 0;
objViewInfoEN.UpdDate = "11111111111111111111";
objViewInfoEN.UpdUserId = "11111111111111111111";
objViewInfoEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.IsSynchToServer = false;
objViewInfoEN.SynchToServerDate = "11111111111111111111";
objViewInfoEN.SynchToServerUser = "11111111111111111111";
objViewInfoEN.IsSynchToClient = false;
objViewInfoEN.SynchToClientDate = "11111111111111111111";
objViewInfoEN.SynchToClientUser = "11111111111111111111";
objViewInfoEN.SynSource = "11111111111111111111111111111111111111111111111111";
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.AddNewRecord(objViewInfoEN);
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
WA_ViewInfo_UT_JS.btnGetMaxStrId_Click = async function() {
$('#hidDivName').val("divGetMaxStrId");
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表ViewInfo的最大关键字为空，不成功，请检查!";
$('#lblResult9').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表ViewInfo的最大关键字为：" +returnString + "!";
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
WA_ViewInfo_UT_JS.btnGetMaxStrIdByPrefix_Click = async function() {
$('#hidDivName').val("divGetMaxStrIdByPrefix");
var strPrefix = $('#txtstrPrefix10').val();
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetMaxStrIdByPrefix(strPrefix);
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表ViewInfo的最大关键字为空，不成功，请检查!";
$('#lblResult10').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "获取表ViewInfo的最大关键字为：" +returnString + "!";
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
WA_ViewInfo_UT_JS.btnUpdateRecord_Click = async function() {
$('#hidDivName').val("divUpdateRecord");
var objViewInfoEN = new clsViewInfoEN_js_1.clsViewInfoEN();
objViewInfoEN.ViewId = "11111111";
objViewInfoEN.ViewName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.ViewTypeCode = 0;
objViewInfoEN.ApplicationTypeId = 0;
objViewInfoEN.FuncModuleAgcId = "11111111";
objViewInfoEN.DataBaseName = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.KeyForMainTab = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.KeyForDetailTab = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.IsNeedSort = false;
objViewInfoEN.IsNeedTransCode = false;
objViewInfoEN.IsNeedSetExportFld = false;
objViewInfoEN.UserId = "111111111111111111";
objViewInfoEN.PrjId = "1111";
objViewInfoEN.ViewFunction = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.ViewDetail = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.DefaMenuName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.DetailTabId = "11111111";
objViewInfoEN.FileName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.FilePath = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.MainTabId = "11111111";
objViewInfoEN.ViewCnName = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.ViewGroupId = "11111111";
objViewInfoEN.INRelaTabId = "11111111";
objViewInfoEN.INSQLDSTypeId = "11";
objViewInfoEN.OUTRelaTabId = "11111111";
objViewInfoEN.OUTSQLDSTypeId = "11";
objViewInfoEN.DetailTabType = "1111111111";
objViewInfoEN.DetailViewId = "11111111";
objViewInfoEN.MainTabType = "1111111111";
objViewInfoEN.IsUseCache4List = false;
objViewInfoEN.MainViewId = "11111111";
objViewInfoEN.GeneCodeDate = "11111111111111111111";
objViewInfoEN.TaskId = "1111111111111111";
objViewInfoEN.RegionNum = 0;
objViewInfoEN.UpdDate = "11111111111111111111";
objViewInfoEN.UpdUserId = "11111111111111111111";
objViewInfoEN.Memo = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
objViewInfoEN.IsSynchToServer = false;
objViewInfoEN.SynchToServerDate = "11111111111111111111";
objViewInfoEN.SynchToServerUser = "11111111111111111111";
objViewInfoEN.IsSynchToClient = false;
objViewInfoEN.SynchToClientDate = "11111111111111111111";
objViewInfoEN.SynchToClientUser = "11111111111111111111";
objViewInfoEN.SynSource = "11111111111111111111111111111111111111111111111111";
objViewInfoEN.sf_UpdFldSetStr = objViewInfoEN.UpdFldString;//设置哪些字段被修改(脏字段)
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.UpdateRecord(objViewInfoEN);
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
WA_ViewInfo_UT_JS.btnDelRecord_Click = async function() {
$('#hidDivName').val("divDelRecord");
var strKeyId = $('#txtstrKeyId12').val();
var strViewId = strKeyId;
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.DelRecord(strViewId);
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
WA_ViewInfo_UT_JS.btnDelViewInfos_Click = async function() {
$('#hidDivName').val("divDel[TabName]s");
var strKeyIdLst = $('#txtarrKeyId13').val();
var arrViewId = strKeyIdLst.split(',');
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.DelViewInfos(arrViewId);
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
WA_ViewInfo_UT_JS.btnDelMultiRecordByCond_Click = async function() {
$('#hidDivName').val("divDelMultiRecordByCond");
var strWhereCond = $('#txtstrWhereCond14').val();
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.DelViewInfosByCond(strWhereCond);
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
WA_ViewInfo_UT_JS.btnGetFirstObj_Click = async function() {
$('#hidDivName').val("divGetFirstObj");
var strWhereCond = $('#txtstrWhereCond15').val();
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetFirstObj(strWhereCond);
var objViewInfoEN = responseText;
strWhereCond = $('#txtstrWhereCond15').val();
var strInfo = "根据条件:[" +strWhereCond + "] 获取第一个记录对象：" +objViewInfoEN.ViewId  + "!";
$('#lblResult15').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowViewInfoObj("divList15", objViewInfoEN);
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
WA_ViewInfo_UT_JS.btnGetObjByViewId_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]");
var strKeyId = $('#txtvarKeyId16').val();
var strViewId = strKeyId;
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjByViewId(strViewId);
var objViewInfoEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objViewInfoEN.ViewId  + "!";
$('#lblResult16').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowViewInfoObj("divList16", objViewInfoEN);
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
WA_ViewInfo_UT_JS.btnGetObjByViewId_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_Cache");
var strKeyId = $('#txtvarKeyId17').val();
var strViewId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjByViewId_Cache(strViewId, strPrjId);
var objViewInfoEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objViewInfoEN.ViewId  + "!";
$('#lblResult17').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowViewInfoObj("divList17", objViewInfoEN);
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
WA_ViewInfo_UT_JS.btnGetObjByViewId_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjBy[Key]_WA_Cache");
var strKeyId = $('#txtvarKeyId18').val();
var strViewId = strKeyId;
try
{
var strPrjId = "0001";
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjByViewId_WA_Cache(strViewId, strPrjId);
var objViewInfoEN = responseText;
var strInfo = "根据关键字:[" +strKeyId + "]获取对象：" +objViewInfoEN.ViewId  + "!";
$('#lblResult18').val(strInfo);
//显示信息框
alert(strInfo);
this.ShowViewInfoObj("divList18", objViewInfoEN);
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
WA_ViewInfo_UT_JS.btnGetObjLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLst");
var strWhereCond = $('#txtstrWhereCond19').val();
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLst(strWhereCond);
var arrViewInfoObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "]共获取对象列表数：" +arrViewInfoObjLst.length + "!";
$('#lblResult19').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList19", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetObjLstByKeyLst_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst");
var strKeyIdLst = $('#txtarrKeyId20').val();
var arrViewId = strKeyIdLst.split(',');
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLstByViewIdLst(arrViewId);
var arrViewInfoObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrViewInfoObjLst.length + "!";
$('#lblResult20').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList20", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetObjLstByKeyLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_Cache");
var strKeyIdLst = $('#txtarrKeyId21').val();
var arrViewId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLstByViewIdLst_Cache(arrViewId, strPrjId);
var arrViewInfoObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrViewInfoObjLst.length + "!";
$('#lblResult21').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList21", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetObjLstByKeyLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByKeyLst_WA_Cache");
var strKeyIdLst = $('#txtarrKeyId22').val();
var arrViewId = strKeyIdLst.split(',');
try
{
var strPrjId = "0001";
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLstByViewIdLst_WA_Cache(arrViewId, strPrjId);
var arrViewInfoObjLst  = responseText;
var strInfo = "根据关键字列表:[" +strKeyIdLst + "]共获取对象列表数：" +arrViewInfoObjLst.length + "!";
$('#lblResult22').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList22", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetSubObjLst_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond23').val();
var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();
objViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_ViewInfo_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objViewInfo_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objViewInfoEN_Sim = clsViewInfoBL_js_1.clsViewInfoBL.GetSimObjFromObj(objViewInfo_Cond);
console.log(objViewInfoEN_Sim);
try
{
var strPrjId = "0001";
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetSubObjLst_Cache(objViewInfo_Cond, strPrjId);
var arrViewInfoObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objViewInfo_Cond) + "],共获取对象列表子集数：" +arrViewInfoObjLst.length + "!";
$('#lblResult23').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList23", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetSubObjLst_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetSubObjLst_WA_Cache");
var objTabName_Cond = $('#txtobjTabName_Cond24').val();
var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();
objViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_ViewInfo_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objViewInfo_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objViewInfoEN_Sim = clsViewInfoBL_js_1.clsViewInfoBL.GetSimObjFromObj(objViewInfo_Cond);
console.log(objViewInfoEN_Sim);
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetSubObjLst_WA_Cache(objViewInfo_Cond);
var arrViewInfoObjLst = responseText;
var strInfo = "根据条件:[" +JSON.stringify(objViewInfo_Cond) + "],共获取对象列表子集数：" +arrViewInfoObjLst.length + "!";
$('#lblResult24').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList24", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetTopObjLst_Click = async function() 
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
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetTopObjLst(objTopPara);
var arrViewInfoObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],顶部数:[" +intTopSize + "]共获取顶部对象列表数：" +arrViewInfoObjLst.length + "!";
$('#lblResult25').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList25", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetObjLstByPager_Click = async function() 
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
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLstByPager(objPagerPara);
var arrViewInfoObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrViewInfoObjLst.length + "!";
$('#lblResult26').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList26", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetObjLstByPager_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_Cache");
var intPageIndex = Number($('#txtintPageIndex27').val());
var intPageSize = Number($('#txtintPageSize27').val());
var strOrderBy = $('#txtstrOrderBy27').val();
var strWhereCond = $('#txtstrWhereCond27').val();
var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();
var strPrjId = "0001";
objViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_ViewInfo_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objViewInfo_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objViewInfoEN_Sim = clsViewInfoBL_js_1.clsViewInfoBL.GetSimObjFromObj(objViewInfo_Cond);
console.log(objViewInfoEN_Sim);
strWhereCond = JSON.stringify(objViewInfoEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLstByPager_Cache(objPagerPara, strPrjId);
var arrViewInfoObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrViewInfoObjLst.length + "!";
$('#lblResult27').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList27", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetObjLstByPager_WA_Cache_Click = async function() 
{
$('#hidDivName').val("divGetObjLstByPager_WA_Cache");
var intPageIndex = Number($('#txtintPageIndex28').val());
var intPageSize = Number($('#txtintPageSize28').val());
var strOrderBy = $('#txtstrOrderBy28').val();
var strWhereCond = $('#txtstrWhereCond28').val();
var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();
objViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_PrjId,"0001", "=");
var arrFldComparisonObj = WA_ViewInfo_UT_JS.GetLocalObjLst();
console.log("字段比较对象记录数(本地获取)：" + arrFldComparisonObj.length);
arrFldComparisonObj.forEach(x => { objViewInfo_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); });
var objViewInfoEN_Sim = clsViewInfoBL_js_1.clsViewInfoBL.GetSimObjFromObj(objViewInfo_Cond);
console.log(objViewInfoEN_Sim);
strWhereCond = JSON.stringify(objViewInfoEN_Sim);
var objPagerPara = {
PageIndex: intPageIndex,
PageSize: intPageSize,
WhereCond: strWhereCond,
OrderBy: strOrderBy
};
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLstByPager_WA_Cache(objPagerPara);
var arrViewInfoObjLst = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],每页记录数:[" +intPageSize + "],第[" +intPageIndex + "]页,共获取分页对象列表数：" +arrViewInfoObjLst.length + "!";
$('#lblResult28').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList28", arrViewInfoObjLst);
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
WA_ViewInfo_UT_JS.btnGetObjLstByRange_Click = async function() 
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
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLstByRange(objRangePara);
var arrViewInfoObjLst  = responseText;
var strInfo = "根据条件:[" +strWhereCond + "],最小记录号:[" +intMinNum + "],最大记录号:[" +intMaxNum + "],共获取分页对象列表数：" +arrViewInfoObjLst.length + "!";
$('#lblResult29').val(strInfo);
//显示信息框
//alert(strInfo);
this.BindTab_ViewInfo("divList29", arrViewInfoObjLst);
}
catch(e)
{
var strMsg = "根据条件获取范围内相应的对象列表不成功, " +e + ".";
alert(strMsg);
}
}

 /// <summary>
 /// 显示ViewInfo对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_BindTab)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "arrViewInfoObjLst">需要绑定的对象列表</param>
 /// <returns></returns>
WA_ViewInfo_UT_JS.BindTab_ViewInfo = function(divContainer, arrViewInfoObjLst) 
{
var o = document.getElementById(divContainer) ;
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrFldName = new Array();
var sstrColHeader = new Array();
sstrFldName.push("ViewId"); sstrColHeader.push("界面Id");
sstrFldName.push("ViewName"); sstrColHeader.push("界面名称");
sstrFldName.push("ViewTypeCode"); sstrColHeader.push("界面类型码");
sstrFldName.push("ApplicationTypeId"); sstrColHeader.push("应用程序类型ID");
sstrFldName.push("FuncModuleAgcId"); sstrColHeader.push("功能模块Id");
sstrFldName.push("DataBaseName"); sstrColHeader.push("数据库名");
sstrFldName.push("KeyForMainTab"); sstrColHeader.push("主表关键字");
sstrFldName.push("KeyForDetailTab"); sstrColHeader.push("明细表关键字");
sstrFldName.push("IsNeedSort"); sstrColHeader.push("是否需要排序");
sstrFldName.push("IsNeedTransCode"); sstrColHeader.push("是否需要转换代码");
sstrFldName.push("IsNeedSetExportFld"); sstrColHeader.push("是否需要设置导出字段");
sstrFldName.push("UserId"); sstrColHeader.push("用户Id");
sstrFldName.push("PrjId"); sstrColHeader.push("工程ID");
sstrFldName.push("ViewFunction"); sstrColHeader.push("界面功能");
sstrFldName.push("ViewDetail"); sstrColHeader.push("界面说明");
sstrFldName.push("DefaMenuName"); sstrColHeader.push("缺省菜单名");
sstrFldName.push("DetailTabId"); sstrColHeader.push("明细表ID");
sstrFldName.push("FileName"); sstrColHeader.push("文件名");
sstrFldName.push("FilePath"); sstrColHeader.push("文件路径");
sstrFldName.push("MainTabId"); sstrColHeader.push("主表ID");
sstrFldName.push("ViewCnName"); sstrColHeader.push("视图中文名");
sstrFldName.push("ViewGroupId"); sstrColHeader.push("界面组ID");
sstrFldName.push("INRelaTabId"); sstrColHeader.push("输入数据源表ID");
sstrFldName.push("INSQLDSTypeId"); sstrColHeader.push("输入数据源类型");
sstrFldName.push("OUTRelaTabId"); sstrColHeader.push("输出数据源表ID");
sstrFldName.push("OUTSQLDSTypeId"); sstrColHeader.push("输出数据源类型");
sstrFldName.push("DetailTabType"); sstrColHeader.push("DetailTabType");
sstrFldName.push("DetailViewId"); sstrColHeader.push("DetailViewId");
sstrFldName.push("MainTabType"); sstrColHeader.push("MainTabType");
sstrFldName.push("IsUseCache4List"); sstrColHeader.push("是否使用缓存列表");
sstrFldName.push("MainViewId"); sstrColHeader.push("MainViewId");
sstrFldName.push("GeneCodeDate"); sstrColHeader.push("生成代码日期");
sstrFldName.push("TaskId"); sstrColHeader.push("任务Id");
sstrFldName.push("RegionNum"); sstrColHeader.push("区域数");
sstrFldName.push("UpdDate"); sstrColHeader.push("修改日期");
sstrFldName.push("UpdUserId"); sstrColHeader.push("修改用户Id");
sstrFldName.push("Memo"); sstrColHeader.push("说明");
sstrFldName.push("IsSynchToServer"); sstrColHeader.push("是否同步到Server");
sstrFldName.push("SynchToServerDate"); sstrColHeader.push("同步到Server日期");
sstrFldName.push("SynchToServerUser"); sstrColHeader.push("同步到Server用户");
sstrFldName.push("IsSynchToClient"); sstrColHeader.push("是否同步到Client");
sstrFldName.push("SynchToClientDate"); sstrColHeader.push("同步到Client库日期");
sstrFldName.push("SynchToClientUser"); sstrColHeader.push("同步到Client库用户");
sstrFldName.push("SynSource"); sstrColHeader.push("同步来源");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTab(o, arrViewInfoObjLst, sstrFldName, sstrColHeader, "ViewId"); 
}

 /// <summary>
 /// 显示{0}对象的所有属性值
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_UT_ShowTabObj)
 /// </summary>
 /// <param name = "divContainer">显示容器</param>
 /// <param name = "objViewInfo">需要显示的对象</param>
 /// <returns></returns>
WA_ViewInfo_UT_JS.ShowViewInfoObj = function(divContainer, objViewInfo) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert(divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objViewInfo);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objViewInfo[strKey];
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
WA_ViewInfo_UT_JS.AddDPV_FldComparison = function(divName4Edit) {
var objLst = document.getElementsByTagName("div");
var strStartName = "divEditFldComparison";
let arrElement = WA_ViewInfo_UT_JS.GetArray(objLst) ;
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
WA_ViewInfo_UT_JS.GetFldNameLst = function(func) {
var arrFldName = new clsViewInfoEN_js_1.clsViewInfoEN().AttributeName;
var strFldNameLst1 = arrFldName.join(",");
clsFldComparisonObj_js_1.clsFldComparisonObj.arrFldNameLst = arrFldName;
func(strFldNameLst1);
}

 /// <summary>
 /// 获取当前表的字段名列表
 /// (AutoGCLib.WA_ViewUTScriptCS4JavaScript:Gen_WA_WCSUT_Js_GetLocalObjLst)
 /// </summary>
 /// <returns></returns>
   WA_ViewInfo_UT_JS.GetLocalObjLst = function() {
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
WA_ViewInfo_UT_JS.CreateCache = async function() 
{
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
var strKey = "";
try
{
console.log("开始获取缓存：ViewInfo");
var strPrjId = "0001";
var strKey =  clsViewInfoEN_js_1.clsViewInfoEN._CurrTabName + "_" + strPrjId ;
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLst_Cache(strPrjId);
console.log("获取缓存完成！ViewInfo");
var arrViewInfoObjLst = CacheHelper_js_1.CacheHelper.Get(strKey);
if (arrViewInfoObjLst != null)
{
var strInfo = "建立缓存Key=[" +strKey + "]完成: 共获取对象列表数：" + arrViewInfoObjLst.length  + "!";
$('#lblPageStatusContent').html(strInfo);
}
else
{
var strInfo = "建立缓存Key=[" +strKey + "]不成功!";
$('#lblPageStatusContent').html(strInfo);
}
}
catch (e) {
console.log("WA_ViewInfo_UT_JS: CreateCache()不成功！");
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
WA_ViewInfo_UT_JS.GetArray = function(arr) {
let arrLst = new Array();
for (var i = 0; i < arr.length; i++)
{
var chk = arr[i];
arrLst.push(chk);
}
return arrLst;
};
return WA_ViewInfo_UT_JS;
}());
exports.WA_ViewInfo_UT_JS = WA_ViewInfo_UT_JS;
});