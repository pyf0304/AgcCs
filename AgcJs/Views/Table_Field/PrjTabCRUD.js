
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:PrjTabCRUD
 表名:PrjTab(00050009)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:05:50
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
 框架-层名:WA_界面后台_JS(WA_ViewScriptCS_JS)
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
define(["require", "exports", "../../Js/L0_Entity/Table_Field/clsPrjTabEN.js","../../Js/L2_BLL/Table_Field/clsPrjTabBL.js","../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js","clscommonfunc4web","../../Js/L2_BLL/Table_Field/clsvPrjTabBL.js","../../Js/L0_Entity/Table_Field/clsvPrjTabEN.js","../../Js/L3_ForWApi/Table_Field/clsvPrjTabWApi.js","tzdictionary","../../Js/L0_Entity/PrjManage/clsFuncModule_AgcEN.js","../../Js/L3_ForWApi/PrjManage/clsFuncModule_AgcWApi.js","../../Js/L0_Entity/Table_Field/clsTabStateEN.js","../../Js/L3_ForWApi/Table_Field/clsTabStateWApi.js","../../Js/L0_Entity/SysPara/clsTabMainTypeEN.js","../../Js/L3_ForWApi/SysPara/clsTabMainTypeWApi.js","../../Js/L0_Entity/SysPara/clsTabTypeEN.js","../../Js/L3_ForWApi/SysPara/clsTabTypeWApi.js","../../Js/L0_Entity/PrjInterface/clsSQLDSTypeEN.js","../../Js/L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js","../../Js/L0_Entity/Table_Field/clsCacheModeEN.js","../../Js/L3_ForWApi/Table_Field/clsCacheModeWApi.js","../../Js/L0_Entity/Table_Field/clsFieldTabEN.js","../../Js/L3_ForWApi/Table_Field/clsFieldTabWApi.js","../../Js/PubFun/clsPager.js","clsstacktrace","../../Js/PubFun/clsOrderByData.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsDataColumn.js","../../Js/PubFun/clsPubFun.js","../../Js/PubFun/jsString.js","../../Js/PubFun/clsCommonFunc4Web.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsPrjTabEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsPrjTabEN.js");
var clsPrjTabBL_js_1 = require("../../Js/L2_BLL/Table_Field/clsPrjTabBL.js");
var clsPrjTabWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsvPrjTabBL_js_1 = require("../../Js/L2_BLL/Table_Field/clsvPrjTabBL.js");
var clsvPrjTabEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsvPrjTabEN.js");
var clsvPrjTabWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsvPrjTabWApi.js");
var Dictionary_js_1 = require("tzdictionary");
var clsFuncModule_AgcEN_js_1 = require("../../Js/L0_Entity/PrjManage/clsFuncModule_AgcEN.js");
var clsFuncModule_AgcWApi_js_1 = require("../../Js/L3_ForWApi/PrjManage/clsFuncModule_AgcWApi.js");
var clsTabStateEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsTabStateEN.js");
var clsTabStateWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsTabStateWApi.js");
var clsTabMainTypeEN_js_1 = require("../../Js/L0_Entity/SysPara/clsTabMainTypeEN.js");
var clsTabMainTypeWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsTabMainTypeWApi.js");
var clsTabTypeEN_js_1 = require("../../Js/L0_Entity/SysPara/clsTabTypeEN.js");
var clsTabTypeWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsTabTypeWApi.js");
var clsSQLDSTypeEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsSQLDSTypeEN.js");
var clsSQLDSTypeWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js");
var clsCacheModeEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsCacheModeEN.js");
var clsCacheModeWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsCacheModeWApi.js");
var clsFieldTabEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsFieldTabEN.js");
var clsFieldTabWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsFieldTabWApi.js");
var clsPager_js_1 = require("../../Js/PubFun/clsPager.js");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsOrderByData_js_1 = require("../../Js/PubFun/clsOrderByData.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsDataColumn_js_1 = require("../../Js/PubFun/clsDataColumn.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var jsString_js_1 = require("../../Js/PubFun/jsString.js");
var arrSelectedKeys_js_1 = require("../../Js/PubFun/clsCommonFunc4Web.js");
 /* PrjTabCRUD 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
*/
var PrjTabCRUD = /** @class */ (function() {
function PrjTabCRUD()
{
this.mstrListDiv = "divDataLst";
this.objPager = new clsPager_js_1.clsPager();
 /*
 * 每页记录数，在扩展类可以修改
*/
this.RecCount = 0;
}
Object.defineProperty(PrjTabCRUD.prototype, "PageSize", {
get: function() { return 5;},
enumerable: true,
configurable: true
});


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
PrjTabCRUD.AddDPV_Edit = function(divName4Edit) {
var strUrl = "./PrjTab_Edit.html";
console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "html",
data: { },
success: function(data) {
console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
$('#' + divName4Edit).html(data);
resolve(true);
//setTimeout(() => { clsEditObj_js_1.clsEditObj.BindTab(); }, 100);
//clsEditObj_js_1.clsEditObj.BindTab();
},
error: (e) => {
console.log(e);
reject(e);
}
});
});
};

 /// <summary>
 /// 在当前界面的列表区添加分页区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Pager)
 /// </summary>
 /// <returns></returns>
PrjTabCRUD.AddDPV_Pager = function(divName4Pager) {
var strUrl = "../../Js/ShareView/_Pager.html";
console.log("divName4Pager:(In AddDPV_Pager)" + divName4Pager);
$.ajax({
url: strUrl,
method: "GET",
dataType: "html",
data: { },
success: function(data) {
console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
$('#' + divName4Pager).html(data);
//setTimeout(() => { clsPagerObj_js_1.clsPagerObj.BindTab(); }, 100);
//clsPagerObj_js_1.clsPagerObj.BindTab();
},
error: (e) => {
console.log(e);
}
});
};

 /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Page_Load_Cache)
*/
PrjTabCRUD.prototype.Page_Load_Cache = async function()
{
// 在此处放置用户代码以初始化页面
try
{
// 设置建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvPrjTabBy = "TabId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vPrjTab_Cache();
}
catch (e)
{
var strMsg = "页面启动不成功," + e+ ".";
alert(strMsg);
}
}


 /* 函数功能:为编辑区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4EditRegion)
*/
PrjTabCRUD.prototype.BindDdl4EditRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objFuncModule_Agc_Cond = new clsFuncModule_AgcEN_js_1.clsFuncModule_AgcEN();//编辑区域
 var objPrjTab_Cond = new clsPrjTabEN_js_1.clsPrjTabEN();//编辑区域
 var objTabMainType_Cond = new clsTabMainTypeEN_js_1.clsTabMainTypeEN();//编辑区域
 var objTabType_Cond = new clsTabTypeEN_js_1.clsTabTypeEN();//编辑区域
 var objSQLDSType_Cond = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();//编辑区域
 var objTabState_Cond = new clsTabStateEN_js_1.clsTabStateEN();//编辑区域
 var objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();//编辑区域
 var objFieldTab_Cond = new clsFieldTabEN_js_1.clsFieldTabEN();//编辑区域
var strPrjId = PrjTabCRUD.strPrjId_Cache;  //定义条件字段
//var strPrjId = "";//定义条件字段
const ddlFuncModuleAgcId = await clsFuncModule_AgcWApi_js_1.clsFuncModule_AgcWApi.BindDdl_FuncModuleAgcId_Cache("ddlFuncModuleAgcId", objFuncModule_Agc_Cond, strPrjId);//编辑区域
const ddlRelaTabId4View = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlRelaTabId4View", objPrjTab_Cond, strPrjId);//编辑区域
const ddlTabMainTypeId = await clsTabMainTypeWApi_js_1.clsTabMainTypeWApi.BindDdl_TabMainTypeId_Cache("ddlTabMainTypeId", objTabMainType_Cond);//编辑区域
const ddlTabTypeId = await clsTabTypeWApi_js_1.clsTabTypeWApi.BindDdl_TabTypeId_Cache("ddlTabTypeId", objTabType_Cond);//编辑区域
const ddlSQLDSTypeId = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.BindDdl_SQLDSTypeId_Cache("ddlSQLDSTypeId", objSQLDSType_Cond);//编辑区域
const ddlTabStateId = await clsTabStateWApi_js_1.clsTabStateWApi.BindDdl_TabStateId_Cache("ddlTabStateId", objTabState_Cond);//编辑区域
const ddlCacheModeId = await clsCacheModeWApi_js_1.clsCacheModeWApi.BindDdl_CacheModeId_Cache("ddlCacheModeId", objCacheMode_Cond);//编辑区域
const ddlCacheClassifyField = await clsFieldTabWApi_js_1.clsFieldTabWApi.BindDdl_FldId_Cache("ddlCacheClassifyField", objFieldTab_Cond);//编辑区域
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
PrjTabCRUD.prototype.BindDdl4QueryRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objFuncModule_Agc_Cond = new clsFuncModule_AgcEN_js_1.clsFuncModule_AgcEN();//查询区域
 var objTabState_Cond = new clsTabStateEN_js_1.clsTabStateEN();//查询区域
 var objTabMainType_Cond = new clsTabMainTypeEN_js_1.clsTabMainTypeEN();//查询区域
 var objTabType_Cond = new clsTabTypeEN_js_1.clsTabTypeEN();//查询区域
 var objSQLDSType_Cond = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();//查询区域
 var objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();//查询区域
var strPrjId_q = PrjTabCRUD.strPrjId_Cache;  //定义条件字段
//var strPrjId_q = "";//定义条件字段
const ddlFuncModuleAgcId_q = await clsFuncModule_AgcWApi_js_1.clsFuncModule_AgcWApi.BindDdl_FuncModuleAgcId_Cache("ddlFuncModuleAgcId_q", objFuncModule_Agc_Cond, strPrjId_q);//查询区域
const ddlTabStateId_q = await clsTabStateWApi_js_1.clsTabStateWApi.BindDdl_TabStateId_Cache("ddlTabStateId_q", objTabState_Cond);//查询区域
const ddlTabMainTypeId_q = await clsTabMainTypeWApi_js_1.clsTabMainTypeWApi.BindDdl_TabMainTypeId_Cache("ddlTabMainTypeId_q", objTabMainType_Cond);//查询区域
const ddlTabTypeId_q = await clsTabTypeWApi_js_1.clsTabTypeWApi.BindDdl_TabTypeId_Cache("ddlTabTypeId_q", objTabType_Cond);//查询区域
const ddlSQLDSTypeId_q = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.BindDdl_SQLDSTypeId_Cache("ddlSQLDSTypeId_q", objSQLDSType_Cond);//查询区域
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_TrueAndFalse("ddlIsUseCache_q");
const ddlCacheModeId_q = await clsCacheModeWApi_js_1.clsCacheModeWApi.BindDdl_CacheModeId_Cache("ddlCacheModeId_q", objCacheMode_Cond);//查询区域
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
*/
PrjTabCRUD.prototype.btnQuery_Click = async function(strListDiv) 
{
var objvPrjTab_Cond = this.CombinevPrjTabConditionObj();
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_PrjId, PrjTabCRUD.strPrjId_Cache, "=");
var objvPrjTabEN_Sim = clsvPrjTabBL_js_1.clsvPrjTabBL.GetSimObjFromObj(objvPrjTab_Cond);
console.log(objvPrjTabEN_Sim);
var strWhereCond = JSON.stringify(objvPrjTabEN_Sim);
try
{
this.RecCount = await clsvPrjTabWApi_js_1.clsvPrjTabWApi.GetRecCountByCond_Cache(objvPrjTab_Cond, PrjTabCRUD.strPrjId_Cache);
var objPagerPara = {
PageIndex: 1,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvPrjTabBy
};
var arrvPrjTabObjLst = await clsvPrjTabWApi_js_1.clsvPrjTabWApi.GetObjLstByPager_Cache(objPagerPara, PrjTabCRUD.strPrjId_Cache);
this.BindTab_vPrjTab(this.mstrListDiv, arrvPrjTabObjLst);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "查询不成功," + e+ ".";
alert(strMsg);
}
}

 /* 添加新记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnAddNewRecord_Click)
*/
PrjTabCRUD.prototype.btnAddNewRecord_Click = async function() {
this.OpType = "Add";
try
{
if (PrjTabCRUD.bolIsLoadEditRegion == false)  //
{
const responseBool = await PrjTabCRUD.AddDPV_Edit(PrjTabCRUD.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
PrjTabCRUD.bolIsLoadEditRegion = true;  //
const responseText = this.AddNewRecord();
}
else
{
ShowDialog('Add');
const responseText = await this.AddNewRecord();
}
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "添加新记录初始化不成功," + e+ ".";
alert(strMsg);
}
}

 /* 添加新记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnAddNewRecordWithMaxId_Click)
*/
PrjTabCRUD.prototype.btnAddNewRecordWithMaxId_Click = async function() {
this.OpType = "AddWithMaxId";
try
{
const responseText = await this.AddNewRecordWithMaxId();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "添加新记录初始化不成功," + e+ ".";
alert(strMsg);
}
}

 /* 设置字段值-CacheModeId
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnSetFldValue_Click)
 */
PrjTabCRUD.prototype.btnSetCacheModeId_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
let strCacheModeId = $("#ddlCacheModeId_SetFldValue").val();
if (strCacheModeId == "")
{
var strMsg = "请输入缓存方式Id(CacheModeId)!";
alert(strMsg);
return;
}
console.log('strCacheModeId=' + strCacheModeId);
console.log('arrKeyIds=');
console.log(arrKeyIds);
const responseText = await this.SetCacheModeId(arrKeyIds, strCacheModeId);
const responseBindGv = this.BindGv_vPrjTab_Cache();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "设置记录不成功," + e.responseText + ".(In btnSetCacheModeId_Click())";
alert(strMsg);
}
}

 /*
  添加新记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnCopyRecord_Click)
 */
PrjTabCRUD.prototype.btnCopyRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = this.BindGv_vPrjTab_Cache();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "复制记录不成功," + e+ ".";
alert(strMsg);
}
}

 /* 在数据表里修改记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnUpdateRecordInTab_Click)
*/
PrjTabCRUD.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {
this.OpType = "Update";
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
this.UpdateRecord(strKeyId);
}

 /* 
 在数据表里删除记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDelRecordInTab_Click)
*/
PrjTabCRUD.prototype.btnDelRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelRecord(strKeyId);
const responseBindGv = this.BindGv_vPrjTab_Cache();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "删除记录不成功. " + e+ ".";
alert(strMsg);
}
}

 /* 
 在数据表里选择记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnSelectRecordInTab_Click)
*/
PrjTabCRUD.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
this.SelectRecord(strKeyId);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "选择记录不成功. " + e+ ".";
alert(strMsg);
}
}

 /* 
 在数据表里详细信息记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDetailRecordInTab_Click)
*/
PrjTabCRUD.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {
this.OpType = "Detail";
try
{
 if (strKeyId == "")
{
alert("请选择需要详细信息的记录！");
return "";
}
this.DetailRecord(strKeyId);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "详细信息记录不成功. " + e+ ".";
alert(strMsg);
}
}

 /* 
 根据关键字删除记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_DelRecord)
*/
PrjTabCRUD.prototype.DelRecord = async function(strTabId) {
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.DelRecord(strTabId);
var returnInt = responseText;
if (returnInt > 0)
{
clsPrjTabWApi_js_1.clsPrjTabWApi.ReFreshCache(PrjTabCRUD.strPrjId_Cache);
var strInfo = "删除记录成功,共删除" + returnInt + "条记录!";
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "删除记录不成功!";
//显示信息框
alert(strInfo);
}
console.log("完成DelRecord!");
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "删除记录不成功. " + e+ ".";
alert(strMsg);
}
}

 /* 
 根据关键字详细信息记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_DetailRecord)
  <param name = "sender">参数列表</param>
*/
PrjTabCRUD.prototype.DetailRecord = async function(strTabId) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.GetObjByTabId(strTabId);
var objPrjTabEN = responseText;
this.GetDataFromPrjTabClass(objPrjTabEN);
console.log("完成DetailRecord!");
}
catch(e)
{
console.log(e);
var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
alert(strMsg);
}
}

 /* 
 根据关键字选择相应的记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SelectRecord)
  <param name = "sender">参数列表</param>
*/
PrjTabCRUD.prototype.SelectRecord = async function(strTabId) 
{
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.GetObjByTabId(strTabId);
var objPrjTabEN = responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vPrjTab");
}
catch(e)
{
console.log(e);
var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
alert(strMsg);
}
}

 /* 修改记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnUpdateRecord_Click)
*/
PrjTabCRUD.prototype.btnUpdateRecord_Click = async function() {
this.OpType = "Update";
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (PrjTabCRUD.bolIsLoadEditRegion == false)  //
{
const responseBool = await PrjTabCRUD.AddDPV_Edit(PrjTabCRUD.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
PrjTabCRUD.bolIsLoadEditRegion = true;  //
this.UpdateRecord(strKeyId);
}
else
{
ShowDialog('Update');
this.UpdateRecord(strKeyId);
}
}

 /* 按标志恢复删除记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnUnDelRecordBySign_Click)
*/
PrjTabCRUD.prototype.btnUnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return "";
}
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.UnDelRecordBySign(arrKeyIds);
var returnInt = responseText;
if (returnInt > 0)
{
var strInfo = "按标志恢复记录成功,共恢复了" + returnInt + "条记录!";
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "按标志恢复记录不成功!";
//显示信息框
alert(strInfo);
return;
}
const responseText2 = await this.BindGv_vPrjTab_Cache();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "按标志恢复记录不成功. " + e+ ".";
alert(strMsg);
}
}

 /* 按标志删除记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDelRecordBySign_Click)
*/
PrjTabCRUD.prototype.btnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return "";
}
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.DelRecordBySign(arrKeyIds);
var returnInt = responseText;
if (returnInt > 0)
{
clsPrjTabWApi_js_1.clsPrjTabWApi.ReFreshCache(PrjTabCRUD.strPrjId_Cache);
var strInfo = "按标志删除记录成功,共删除" + returnInt + "条记录!";
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "按标志删除记录不成功!";
//显示信息框
alert(strInfo);
return;
}
const responseText2 = await this.BindGv_vPrjTab_Cache();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "按标志删除记录不成功. " + e+ ".";
alert(strMsg);
}
}

 /* 删除记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDelRecord_Click)
*/
PrjTabCRUD.prototype.btnDelRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = this.BindGv_vPrjTab_Cache();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "删除记录不成功. " + e+ ".";
alert(strMsg);
}
}











 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnExportExcel_Click)
*/
PrjTabCRUD.prototype.btnExportExcel_Click = async function() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await clsvPrjTabWApi_js_1.clsvPrjTabWApi.GetObjLst(strWhereCond).then((jsonData)=>{
var arrvPrjTabObjLst  = jsonData;
this.BindTab_vPrjTab(this.mstrListDiv, arrvPrjTabObjLst);
});
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "导出Excel不成功," + e+ ".";
alert(strMsg);
}
}

 /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
  具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnOKUpd_Click)
*/
PrjTabCRUD.prototype.btnOKUpd_Click = async function()
{
var strCommandText = this.btnOKUpd;
try {
switch(strCommandText)
{
case "添加":
const responseText1 = await this.AddNewRecord();
break;				
case "确认添加":
//这是一个单表的插入的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
if (this.OpType == "AddWithMaxId")
{
const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
var returnBool2 = jsonData;
if (returnBool2 == true)
{
HideDialog();
this.BindGv_vPrjTab_Cache();
}
});
}
else
{
const responseText2 = await this.AddNewRecordSave().then((jsonData)=>{
var returnBool = jsonData;
if (returnBool == true)
{
HideDialog();
this.BindGv_vPrjTab_Cache();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool = jsonData;
var strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In PrjTabCRUD.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_vPrjTab_Cache();
}
});
break;
default:
var strMsg = "strCommandText:" + strCommandText + "在switch中没有处理！(In btnOKUpd_Click())"
alert(strMsg);
break;
}
}
catch (e)
{
var strMsg = "(errid: WiTsCs0033)在保存记录时(" + strCommandText + ")时出错!请联系管理员!" + e+ "";
alert(strMsg);
}
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
PrjTabCRUD.prototype.CombinevPrjTabCondition = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.TabName_q != "")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabName + " like '% " + this.TabName_q + "%'";
}
if ( this.FuncModuleAgcId_q != "" && this.FuncModuleAgcId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_FuncModuleAgcId + " = '" + this.FuncModuleAgcId_q + "'";
}
if ( this.TabStateId_q != "" && this.TabStateId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabStateId + " = '" + this.TabStateId_q + "'";
}
if ( this.TabMainTypeId_q != "" && this.TabMainTypeId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabMainTypeId + " = '" + this.TabMainTypeId_q + "'";
}
if ( this.TabTypeId_q != "" && this.TabTypeId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabTypeId + " = '" + this.TabTypeId_q + "'";
}
if ( this.TabCnName_q != "")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabCnName + " like '% " + this.TabCnName_q + "%'";
}
if ( this.SQLDSTypeId_q != "" && this.SQLDSTypeId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_SQLDSTypeId + " = '" + this.SQLDSTypeId_q + "'";
}
if ($("#ddlIsUseCache_q").prop("SelectedIndex") == 1)
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_IsUseCache + " = '1'"; 
}
else if ($("#ddlIsUseCache_q").prop("SelectedIndex") == 2)
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_IsUseCache + " = '0'";
}
if ( this.CacheModeId_q != "" && this.CacheModeId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_CacheModeId + " = '" + this.CacheModeId_q + "'";
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombinePrjTabCondition)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
PrjTabCRUD.prototype.CombinevPrjTabConditionObj = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
var objvPrjTab_Cond = new clsPrjTabEN_js_1.clsPrjTabEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.TabName_q != "")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabName + " like '% " + this.TabName_q + "%'";
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_TabName, this.TabName_q, "like");
}
if ( this.FuncModuleAgcId_q != "" && this.FuncModuleAgcId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_FuncModuleAgcId + " = '" + this.FuncModuleAgcId_q + "'";
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_FuncModuleAgcId, this.FuncModuleAgcId_q, "=");
}
if ( this.TabStateId_q != "" && this.TabStateId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabStateId + " = '" + this.TabStateId_q + "'";
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_TabStateId, this.TabStateId_q, "=");
}
if ( this.TabMainTypeId_q != "" && this.TabMainTypeId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabMainTypeId + " = '" + this.TabMainTypeId_q + "'";
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_TabMainTypeId, this.TabMainTypeId_q, "=");
}
if ( this.TabTypeId_q != "" && this.TabTypeId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabTypeId + " = '" + this.TabTypeId_q + "'";
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_TabTypeId, this.TabTypeId_q, "=");
}
if ( this.TabCnName_q != "")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_TabCnName + " like '% " + this.TabCnName_q + "%'";
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_TabCnName, this.TabCnName_q, "like");
}
if ( this.SQLDSTypeId_q != "" && this.SQLDSTypeId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_SQLDSTypeId + " = '" + this.SQLDSTypeId_q + "'";
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_SQLDSTypeId, this.SQLDSTypeId_q, "=");
}
if ($("#ddlIsUseCache_q").prop("SelectedIndex") == 1)
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_IsUseCache + " = '1'"; 
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_IsUseCache, true, "=");
}
else if ($("#ddlIsUseCache_q").prop("SelectedIndex") == 2)
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_IsUseCache + " = '0'";
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_IsUseCache, false, "=");
}
if ( this.CacheModeId_q != "" && this.CacheModeId_q != "0")
{
strWhereCond += " And " + clsPrjTabEN_js_1.clsPrjTabEN.con_CacheModeId + " = '" + this.CacheModeId_q + "'";
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_CacheModeId, this.CacheModeId_q, "=");
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombinePrjTabConditionObj)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return objvPrjTab_Cond;
}

 /* 显示vPrjTab对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrPrjTabObjLst">需要绑定的对象列表</param>
*/
PrjTabCRUD.prototype.BindTab_vPrjTab = function(divContainer, arrvPrjTabObjLst) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var arrDataColumn =
       [
{
FldName: "",
ColHeader: "",
Text: "",
ColumnType: "CheckBox",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "TabId",
ColHeader: "表ID",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "FldNum",
ColHeader: "字段数",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "TabName",
ColHeader: "表名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "TabCnName",
ColHeader: "表中文名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "SqlDsTypeName",
ColHeader: "Sql数据源",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "TabStateName",
ColHeader: "表状态名称",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "FuncModuleName",
ColHeader: "模块",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsReleToSqlTab",
ColHeader: "与SQL表相关？",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "TabTypeName",
ColHeader: "表类型",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "TabMainTypeName",
ColHeader: "表主类型名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ParentClass",
ColHeader: "父类",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsUseCache",
ColHeader: "是否使用Cache",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "UpdDate",
ColHeader: "修改日期",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "KeyFldName",
ColHeader: "关键字段名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "",
ColHeader: "修改",
Text: "修改",
ColumnType: "Button",
OrderNum: 1,
FuncName: (strKeyId, strText) => { 
var btn1 = document.createElement("button");
btn1.innerText = strText;
btn1.className = "btn btn-outline-info btn-sm";
btn1.setAttribute("onclick", "btnUpdateRecordInTab_Click('" + strKeyId + "');");
return btn1;
}
},
{
FldName: "",
ColHeader: "删除",
Text: "删除",
ColumnType: "Button",
OrderNum: 1,
FuncName: (strKeyId, strText) => { 
var btn1 = document.createElement("button");
btn1.innerText = strText;
btn1.className = "btn btn-outline-info btn-sm";
btn1.setAttribute("onclick", "btnDelRecordInTab_Click('" + strKeyId + "');");
return btn1;
}
},
];
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrvPrjTabObjLst, arrDataColumn, "TabId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.PageSize = this.PageSize;
this.objPager.ShowPager();
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
PrjTabCRUD.prototype.IndexPage = function(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.CurrPageIndex = intPageIndex;
this.BindGv_vPrjTab_Cache();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv_Cache)
*/
PrjTabCRUD.prototype.BindGv_vPrjTab_Cache = async function() 
{
var strListDiv = this.mstrListDiv;
var objvPrjTab_Cond = this.CombinevPrjTabConditionObj();
objvPrjTab_Cond.SetCondFldValue(clsPrjTabEN_js_1.clsPrjTabEN.con_PrjId, PrjTabCRUD.strPrjId_Cache, "=");
var objvPrjTabEN_Sim = clsvPrjTabBL_js_1.clsvPrjTabBL.GetSimObjFromObj(objvPrjTab_Cond);
console.log(objvPrjTabEN_Sim);
var strWhereCond = JSON.stringify(objvPrjTabEN_Sim);
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvPrjTabObjLst = [];
try
{
this.RecCount = await  clsvPrjTabWApi_js_1.clsvPrjTabWApi.GetRecCountByCond_Cache(objvPrjTab_Cond, PrjTabCRUD.strPrjId_Cache);
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvPrjTabBy
};
var arrvPrjTabObjLst = await clsvPrjTabWApi_js_1.clsvPrjTabWApi.GetObjLstByPager_Cache(objPagerPara, PrjTabCRUD.strPrjId_Cache);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvPrjTabObjLst.length == 0)
{
var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=PrjTab_" + PrjTabCRUD.strPrjId_Cache + ")";
alert(strMsg);
return;
}
try
{
this.BindTab_vPrjTab(strListDiv, arrvPrjTabObjLst);
console.log("完成BindGv_vPrjTab!");
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg ="绑定对象列表不成功.Error Massage:" + e+ ".";
alert(strMsg);
}
}

 /* 函数功能:从界面列表中根据某一个字段排序
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SortBy)
  <param name = "strSortByFld">排序的字段</param>
*/
PrjTabCRUD.prototype.SortBy = async function(strSortByFld) {
if (this.hidSortvPrjTabBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvPrjTabBy.indexOf("Asc") >= 0)
{
this.hidSortvPrjTabBy = "" + strSortByFld + " Desc";
}
else
{
this.hidSortvPrjTabBy = "" + strSortByFld + " Asc";
}
}
else
{
this.hidSortvPrjTabBy = "" + strSortByFld + " Asc";
}
const responseBindGv = this.BindGv_vPrjTab_Cache();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
*/
PrjTabCRUD.prototype.QueryvPrjTabLst = function(strListDiv) 
{
var strWhereCond = this.CombinevPrjTabCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvPrjTabBy
};
const responseText = clsvPrjTabWApi_js_1.clsvPrjTabWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
var arrvPrjTabObjLst  = jsonData;
this.BindTab_vPrjTab(strListDiv, arrvPrjTabObjLst);
console.log("完成QueryvPrjTabLst!");
resolve(jsonData);
});
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "查询对象列表不成功," + e+ ".";
alert(strMsg);
}
});
}

/// <summary>
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SetKeyReadOnly)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
PrjTabCRUD.prototype.SetKeyReadOnly = function(bolReadonly)
{
$('#txtTabId').prop['ReadOnly'] = bolReadonly;
}

/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Clear)
/// </summary>	
PrjTabCRUD.prototype.Clear = function()
{
}

 /* 获取当前表关键字值的最大值,再加1,避免重复
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
*/
PrjTabCRUD.prototype.GetMaxStrId = async function(strKeyCtrlName) {
this.DivName = "divGetMaxStrId";
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表PrjTab的最大关键字为空，不成功，请检查!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
else
{
var strInfo = "获取表PrjTab的最大关键字为：" + returnString + "!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "获取表关键字的最大值不成功," + e+ ".";
alert(strMsg);
}
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecord)
*/
PrjTabCRUD.prototype.AddNewRecord = async function()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucPrjTabB1.TabId = clsPrjTabBL_js_1.clsPrjTabBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
*/
PrjTabCRUD.prototype.AddNewRecordWithMaxId = function()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucPrjTabB1.TabId = clsPrjTabBL_js_1.clsPrjTabBL.GetMaxStrId_S();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
*/
PrjTabCRUD.prototype.CopyRecord = async function(arrTabId) {
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.GetObjLstByTabIdLst(arrTabId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrPrjTabObjLst =  responseText;
for (let objInFor of arrPrjTabObjLst)
{
const responseText2 = await clsPrjTabWApi_js_1.clsPrjTabWApi.AddNewRecord(objInFor);
console.log('responseText2=');
console.log(responseText2);
var returnBool = !!responseText2;
if (returnBool == true)
{
var strInfo = "克隆记录成功!";
intCount++;
}
else
{
var strInfo = "克隆记录不成功!";
//显示信息框
alert(strInfo);
}
}
var strInfo = "共克隆了" + intCount + "条记录!";
alert(strInfo);
console.log('完成！');
}
catch (e)
{
var strMsg = "复制记录不成功," + e+ ".";
alert(strMsg);
}
}

 /* 设置字段值-CacheModeId
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SetFieldValue)
 */
PrjTabCRUD.prototype.SetCacheModeId = async function(arrTabId, strCacheModeId)
{
if (strCacheModeId == null || strCacheModeId == "" )
{
var strMsg = "请输入缓存方式Id(CacheModeId)!";
alert(strMsg);
return "";
}
if (arrTabId.length == 0)
{
let strMsg = "没有选择记录，不能设置字段值!";
alert(strMsg);
return "";
}
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.GetObjLstByTabIdLst(arrTabId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrPrjTabObjLst =  responseText;
for (let objInFor of arrPrjTabObjLst)
{
let objPrjTabEN = new clsPrjTabEN_js_1.clsPrjTabEN();
clsPrjTabBL_js_1.clsPrjTabBL.CopyObjTo(objInFor, objPrjTabEN);
objPrjTabEN.CacheModeId = strCacheModeId;
var returnBool = false;
try
{
    objPrjTabEN.sf_UpdFldSetStr = objPrjTabEN.UpdFldString;//设置哪些字段被修改(脏字段)
const responseUpdate = await clsPrjTabWApi_js_1.clsPrjTabWApi.UpdateRecord(objPrjTabEN);
console.log('responseUpdate=');
console.log(responseUpdate);
returnBool = !!responseUpdate;
}
catch (e)
{
let strMsg = "修改记录出错。" + e.responseText + ". (In SetCacheModeId())";
throw (strMsg);
}
if (returnBool == true)
{
var strInfo = "设置记录成功!";
intCount++;
}
else
{
var strInfo = "设置记录不成功!";
//显示信息框
alert(strInfo);
}
}
var strInfo = "共设置了" + intCount + "条记录!";
alert(strInfo);
console.log('完成！');
if (intCount > 0)
{
clsPrjTabWApi_js_1.clsPrjTabWApi.ReFreshCache(PrjTabCRUD.strPrjId_Cache);
}
}
catch (e)
{
var strMsg = "设置记录不成功," + e+ ".(In SetCacheModeId())";
alert(strMsg);
}
}

 /* 函数功能:把界面上的属性数据传到类对象中
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_PutDataToClass)
  <param name = "pobjPrjTabEN">数据传输的目的类对象</param>
*/
PrjTabCRUD.prototype.PutDataToPrjTabClass = function(pobjPrjTabEN)
{
pobjPrjTabEN.TabId = this.TabId;// 表ID
pobjPrjTabEN.ParentClass = this.ParentClass;// 父类
pobjPrjTabEN.TabName = this.TabName;// 表名
pobjPrjTabEN.TabCnName = this.TabCnName;// 表中文名
pobjPrjTabEN.PrjId = this.PrjId;// 工程ID
pobjPrjTabEN.FuncModuleAgcId = this.FuncModuleAgcId;// 功能模块
pobjPrjTabEN.KeyWord = this.KeyWord;// 关键字
pobjPrjTabEN.RelaTabId4View = this.RelaTabId4View;// 视图的相关表
pobjPrjTabEN.TabMainTypeId = this.TabMainTypeId;// 表主类型
pobjPrjTabEN.TabTypeId = this.TabTypeId;// 表类型Id
pobjPrjTabEN.SQLDSTypeId = this.SQLDSTypeId;// 数据源类型
pobjPrjTabEN.TabStateId = this.TabStateId;// 表状态
pobjPrjTabEN.IsReleToSqlTab = this.IsReleToSqlTab;// 是否与SQL表相关
pobjPrjTabEN.IsNeedGeneIndexer = this.IsNeedGeneIndexer;// 是否需要生成索引器
pobjPrjTabEN.IsUseCache = this.IsUseCache;// 是否使用Cache
pobjPrjTabEN.CacheModeId = this.CacheModeId;// 缓存方式Id
pobjPrjTabEN.CacheClassifyField = this.CacheClassifyField;// 缓存分类字段
pobjPrjTabEN.UpdUserId = this.UpdUserId;// 修改用户Id
pobjPrjTabEN.UpdDate = this.UpdDate;// 修改日期
pobjPrjTabEN.Memo = this.Memo;// 说明
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
*/
PrjTabCRUD.prototype.AddNewRecordSave = async function(){
this.DivName = "divAddNewRecordSave";
var objPrjTabEN = new clsPrjTabEN_js_1.clsPrjTabEN();
   this.PutDataToPrjTabClass(objPrjTabEN);
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.IsExist(objPrjTabEN.TabId);
var bolIsExist = responseText;
if (bolIsExist == true)
{
var strMsg = "添加记录时，关键字：" + objPrjTabEN.TabId + "已经存在！";
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsPrjTabWApi_js_1.clsPrjTabWApi.AddNewRecord(objPrjTabEN);
var returnBool = !!responseText2;
if (returnBool == true)
{
clsPrjTabWApi_js_1.clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
var strInfo = "添加记录成功!";
$('#lblResult55').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "添加记录不成功!";
$('#lblResult55').val(strInfo);
//显示信息框
alert(strInfo);
return false;//一定要有一个返回值，否则会出错！
}
return responseText2;//一定要有一个返回值，否则会出错！
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "添加记录不成功," + e+ ".";
alert(strMsg);
return false;//一定要有一个返回值，否则会出错！
}
return true;//一定要有一个返回值，否则会出错！
}

 /* 添加新记录，由后台自动获取最大值的关键字。保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxIdSave)
*/
PrjTabCRUD.prototype.AddNewRecordWithMaxIdSave = async function(){
this.DivName = "divAddNewRecordWithMaxIdSave";
var objPrjTabEN = new clsPrjTabEN_js_1.clsPrjTabEN();
   this.PutDataToPrjTabClass(objPrjTabEN);
try
{
const responseText2 = await clsPrjTabWApi_js_1.clsPrjTabWApi.AddNewRecordWithMaxId(objPrjTabEN);
var returnBool = !!responseText2;
if (returnBool == true)
{
clsPrjTabWApi_js_1.clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
var strInfo = "添加记录成功!";
$('#lblResult56').val(strInfo);
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "添加记录不成功!";
$('#lblResult56').val(strInfo);
//显示信息框
alert(strInfo);
}
return responseText2;//一定要有一个返回值，否则会出错！
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "添加记录不成功," + e+ ".";
alert(strMsg);
}
return true;//一定要有一个返回值，否则会出错！
}

 /* 函数功能:把以该关键字的记录内容显示在界面上,
 　　　   在这里是把值传到表控件中
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_ShowData)
  <param name = "strTabId">表记录的关键字,显示该表关键字的内容</param>
*/
PrjTabCRUD.prototype.ShowData = async function(strTabId) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objPrjTabEN = new clsPrjTabEN_js_1.clsPrjTabEN();
        try {
            const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.IsExist(strTabId);
            var returnBool = responseText;
            if (returnBool == false) {
                var strInfo = "关键字:[" + strTabId + "] 的记录不存在!";
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
            }
        }
        catch (e) {
            var strMsg = "检查相应关键字的记录存在不成功, " + e+ ".";
            alert(strMsg);
        }
        try {
            const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.GetObjByTabId(strTabId);
            objPrjTabEN = responseText;
        }
        catch (e) {
            var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromPrjTabClass(objPrjTabEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
  <param name = "pobjPrjTabEN">表实体类对象</param>
*/
PrjTabCRUD.prototype.GetDataFromPrjTabClass = function(pobjPrjTabEN )
{
 this.TabId = pobjPrjTabEN.TabId;// 表ID
 this.ParentClass = pobjPrjTabEN.ParentClass;// 父类
 this.TabName = pobjPrjTabEN.TabName;// 表名
 this.TabCnName = pobjPrjTabEN.TabCnName;// 表中文名
 this.PrjId = pobjPrjTabEN.PrjId;// 工程ID
 this.FuncModuleAgcId = pobjPrjTabEN.FuncModuleAgcId;// 功能模块
 this.KeyWord = pobjPrjTabEN.KeyWord;// 关键字
 this.RelaTabId4View = pobjPrjTabEN.RelaTabId4View;// 视图的相关表
 this.TabMainTypeId = pobjPrjTabEN.TabMainTypeId;// 表主类型
 this.TabTypeId = pobjPrjTabEN.TabTypeId;// 表类型Id
 this.SQLDSTypeId = pobjPrjTabEN.SQLDSTypeId;// 数据源类型
 this.TabStateId = pobjPrjTabEN.TabStateId;// 表状态
this.IsReleToSqlTab = pobjPrjTabEN.IsReleToSqlTab;// 是否与SQL表相关
this.IsNeedGeneIndexer = pobjPrjTabEN.IsNeedGeneIndexer;// 是否需要生成索引器
this.IsUseCache = pobjPrjTabEN.IsUseCache;// 是否使用Cache
 this.CacheModeId = pobjPrjTabEN.CacheModeId;// 缓存方式Id
 this.CacheClassifyField = pobjPrjTabEN.CacheClassifyField;// 缓存分类字段
 this.UpdUserId = pobjPrjTabEN.UpdUserId;// 修改用户Id
 this.UpdDate = pobjPrjTabEN.UpdDate;// 修改日期
 this.Memo = pobjPrjTabEN.Memo;// 说明
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
PrjTabCRUD.prototype.UpdateRecord = async function(strTabId) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = strTabId;
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.GetObjByTabId(strTabId);
var objPrjTabEN = responseText;
this.GetDataFromPrjTabClass(objPrjTabEN);
console.log("完成UpdateRecord!");
}
catch(e)
{
console.log(e);
var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
alert(strMsg);
}
}

 /* 修改记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecordSave)
*/
PrjTabCRUD.prototype.UpdateRecordSave = async function() {
this.DivName = "divUpdateRecordSave";
var objPrjTabEN = new clsPrjTabEN_js_1.clsPrjTabEN();
objPrjTabEN.TabId = this.KeyId;
   this.PutDataToPrjTabClass(objPrjTabEN);
objPrjTabEN.sf_UpdFldSetStr = objPrjTabEN.UpdFldString;//设置哪些字段被修改(脏字段)
if (objPrjTabEN.TabId == "" || objPrjTabEN.TabId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.UpdateRecord(objPrjTabEN);
var returnBool = !!responseText;
if (returnBool == true)
{
clsPrjTabWApi_js_1.clsPrjTabWApi.ReFreshCache(PrjTabCRUD.strPrjId_Cache);
}
return returnBool;
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "修改记录不成功," + e+ ".";
alert(strMsg);
}
return true;
}

 /* 根据关键字列表删除记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_DelMultiRecord)
*/
PrjTabCRUD.prototype.DelMultiRecord = async function(arrTabId) {
try
{
const responseText = await clsPrjTabWApi_js_1.clsPrjTabWApi.DelPrjTabs(arrTabId);
var returnInt = responseText;
if (returnInt > 0)
{
clsPrjTabWApi_js_1.clsPrjTabWApi.ReFreshCache(PrjTabCRUD.strPrjId_Cache);
var strInfo = "删除记录成功,共删除" + returnInt + "条记录!";
//显示信息框
alert(strInfo);
}
else
{
var strInfo = "删除记录不成功!";
//显示信息框
alert(strInfo);
}
console.log("完成DelMultiRecord!");
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "删除记录不成功. " + e+ ".";
alert(strMsg);
}
}

 /* 显示{0}对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_ShowTabObj)
  <param name = "divContainer">显示容器</param>
  <param name = "objPrjTab">需要显示的对象</param>
*/
PrjTabCRUD.prototype.ShowPrjTabObj = function(divContainer, objPrjTab) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objPrjTab);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objPrjTab[strKey];
var li = document.createElement("li");
li.innerHTML = "" + strKey + ":" + strValue + "";
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
  <param name = "pobjPrjTabEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
PrjTabCRUD.prototype.GetFirstKey = function() {
if (arrSelectedKeys.length == 1) {
return arrSelectedKeys[0];
}
else {
alert("请选择一个关键字！目前选择了:" + arrSelectedKeys.length + "个关键字。");
return "";
}
}

/*
演示Session 操作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Demo_Session)
*/
PrjTabCRUD.prototype.Demo_Session = async function()
{
try
{
//设置Session
var strUserId = "TestUserId";
await this.SetSession("UserId", strUserId);
//获取Session
var strUserId_Value1 = await this.GetSession("UserId");
console.log('strUserId_Value1:' + strUserId_Value1);
//获取Session方法2：直接读取页面中的hidUserId
var strUserId_Value2 = this.hidUserId;
console.log('strUserId_Value2:' + strUserId_Value2);
}
catch (e)
{
var strMsg = "演示Session不成功," + e+ ".";
alert(strMsg);
}
}

/*
设置Session
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SetSession)
<param name = "Key">关键字</param>
<param name = "Value">值</param>
*/
PrjTabCRUD.prototype.SetSession = function(Key, Value) {
return new Promise(function(resolve, reject) {
            $.ajax({
url: strUrl_Session_SetString,
cache: false,
async: false,
type: 'get',
dataType: "json",
data: {
Key: Key,
Value: Value
},
success: function (data) {
var strKey = data.key;
var strValue = data.value;
console.log('strKey, strValue=' + strKey + strValue);
}
});
});
}

/*
获取Session 关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetSession)
<param name = "Key">关键字</param>
 <return>值</return>
*/
PrjTabCRUD.prototype.GetSession = function(Key) {
return new Promise(function(resolve, reject) {
            $.ajax({
url: strUrl_Session_GetString,
cache: false,
async: false,
type: 'get',
dataType: "json",
data: {
Key: Key,
},
success: function (data) {
var strKey = data.key;
var strValue = data.value;
console.log('strKey, strValue=' + strKey + strValue);
resolve(data);
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问网络不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
}
 /*
 * 设置取消按钮的标题
*/
Object.defineProperty(PrjTabCRUD.prototype, "btnCancel", {
 set: function(value)
{
$("#btnCancel").html(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 设置确定按钮的标题
*/
Object.defineProperty(PrjTabCRUD.prototype, "btnOKUpd", {
 set: function(value)
{
$("#btnOKUpd").html(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 获取按钮的标题
*/
Object.defineProperty(PrjTabCRUD.prototype, "btnOKUpd", {
    get: function()
{
return $("#btnOKUpd").html();
 },
 enumerable: true,
configurable: true
});
 /*
 * 缓存分类字段
*/
Object.defineProperty(PrjTabCRUD.prototype, "CacheClassifyField", {
 set: function(value)
{
$("#ddlCacheClassifyField").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 缓存分类字段
*/
Object.defineProperty(PrjTabCRUD.prototype, "CacheClassifyField", {
    get: function()
{
return $("#ddlCacheClassifyField").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 缓存方式Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "CacheModeId", {
 set: function(value)
{
$("#ddlCacheModeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 缓存方式Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "CacheModeId", {
    get: function()
{
return $("#ddlCacheModeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 缓存方式Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "CacheModeId_q", {
    get: function()
{
return $("#ddlCacheModeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置当前页序号
*/
Object.defineProperty(PrjTabCRUD.prototype, "CurrPageIndex", {
 set: function(value)
{
$("#hidCurrPageIndex").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 获取当前页序号
*/
Object.defineProperty(PrjTabCRUD.prototype, "CurrPageIndex", {
    get: function()
{
return $("#hidCurrPageIndex").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 添加、修改用的层名
*/
Object.defineProperty(PrjTabCRUD.prototype, "DivName", {
 set: function(value)
{
$("#hidDivName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 功能模块Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "FuncModuleAgcId", {
 set: function(value)
{
$("#ddlFuncModuleAgcId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 功能模块Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "FuncModuleAgcId", {
    get: function()
{
return $("#ddlFuncModuleAgcId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 功能模块Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "FuncModuleAgcId_q", {
    get: function()
{
return $("#ddlFuncModuleAgcId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置排序字段-相当使用ViewState功能
*/
Object.defineProperty(PrjTabCRUD.prototype, "hidSortvPrjTabBy", {
 set: function(value)
{
$("#hidSortvPrjTabBy").val(value);
},
    get: function()
{
return $("#hidSortvPrjTabBy").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 用户Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "hidUserId", {
    get: function()
{
return $("#hidUserId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否需要生成索引器
*/
Object.defineProperty(PrjTabCRUD.prototype, "IsNeedGeneIndexer", {
 set: function(value)
{
$("#chkIsNeedGeneIndexer").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否需要生成索引器
*/
Object.defineProperty(PrjTabCRUD.prototype, "IsNeedGeneIndexer", {
    get: function()
{
return $("#chkIsNeedGeneIndexer").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否与SQL表相关
*/
Object.defineProperty(PrjTabCRUD.prototype, "IsReleToSqlTab", {
 set: function(value)
{
$("#chkIsReleToSqlTab").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否与SQL表相关
*/
Object.defineProperty(PrjTabCRUD.prototype, "IsReleToSqlTab", {
    get: function()
{
return $("#chkIsReleToSqlTab").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否使用Cache
*/
Object.defineProperty(PrjTabCRUD.prototype, "IsUseCache", {
 set: function(value)
{
$("#chkIsUseCache").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否使用Cache
*/
Object.defineProperty(PrjTabCRUD.prototype, "IsUseCache", {
    get: function()
{
return $("#chkIsUseCache").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否使用Cache
*/
Object.defineProperty(PrjTabCRUD.prototype, "IsUseCache_q", {
    get: function()
{
return $("#ddlIsUseCache_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置关键字的值
*/
Object.defineProperty(PrjTabCRUD.prototype, "KeyId", {
 set: function(value)
{
$("#hidKeyId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 设置关键字的值
*/
Object.defineProperty(PrjTabCRUD.prototype, "KeyId", {
    get: function()
{
return $("#hidKeyId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 关键字
*/
Object.defineProperty(PrjTabCRUD.prototype, "KeyWord", {
 set: function(value)
{
$("#txtKeyWord").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 关键字
*/
Object.defineProperty(PrjTabCRUD.prototype, "KeyWord", {
    get: function()
{
return $("#txtKeyWord").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 说明
*/
Object.defineProperty(PrjTabCRUD.prototype, "Memo", {
 set: function(value)
{
$("#txtMemo").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 说明
*/
Object.defineProperty(PrjTabCRUD.prototype, "Memo", {
    get: function()
{
return $("#txtMemo").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置操作类型：Add||Update||Detail
*/
Object.defineProperty(PrjTabCRUD.prototype, "OpType", {
 set: function(value)
{
$("#hidOpType").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 设置操作类型：Add||Update||Detail
*/
Object.defineProperty(PrjTabCRUD.prototype, "OpType", {
    get: function()
{
return $("#hidOpType").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 父类
*/
Object.defineProperty(PrjTabCRUD.prototype, "ParentClass", {
 set: function(value)
{
$("#txtParentClass").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 父类
*/
Object.defineProperty(PrjTabCRUD.prototype, "ParentClass", {
    get: function()
{
return $("#txtParentClass").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 工程ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "PrjId", {
 set: function(value)
{
$("#ccfPrjId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 工程ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "PrjId", {
    get: function()
{
return $("#ccfPrjId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 工程ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "PrjId_q", {
    get: function()
{
return $("#ccfPrjId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 视图的相关表ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "RelaTabId4View", {
 set: function(value)
{
$("#ddlRelaTabId4View").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 视图的相关表ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "RelaTabId4View", {
    get: function()
{
return $("#ddlRelaTabId4View").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 数据源类型
*/
Object.defineProperty(PrjTabCRUD.prototype, "SQLDSTypeId", {
 set: function(value)
{
$("#ddlSQLDSTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 数据源类型
*/
Object.defineProperty(PrjTabCRUD.prototype, "SQLDSTypeId", {
    get: function()
{
return $("#ddlSQLDSTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 数据源类型
*/
Object.defineProperty(PrjTabCRUD.prototype, "SQLDSTypeId_q", {
    get: function()
{
return $("#ddlSQLDSTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表中文名
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabCnName", {
 set: function(value)
{
$("#txtTabCnName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 表中文名
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabCnName", {
    get: function()
{
return $("#txtTabCnName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表中文名
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabCnName_q", {
    get: function()
{
return $("#txtTabCnName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabId", {
 set: function(value)
{
$("#txtTabId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 表ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabId", {
    get: function()
{
return $("#txtTabId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表主类型Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabMainTypeId", {
 set: function(value)
{
$("#ddlTabMainTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 表主类型Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabMainTypeId", {
    get: function()
{
return $("#ddlTabMainTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表主类型Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabMainTypeId_q", {
    get: function()
{
return $("#ddlTabMainTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表名
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabName", {
 set: function(value)
{
$("#txtTabName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 表名
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabName", {
    get: function()
{
return $("#txtTabName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表名
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabName_q", {
    get: function()
{
return $("#txtTabName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表状态ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabStateId", {
 set: function(value)
{
$("#ddlTabStateId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 表状态ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabStateId", {
    get: function()
{
return $("#ddlTabStateId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表状态ID
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabStateId_q", {
    get: function()
{
return $("#ddlTabStateId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表类型Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabTypeId", {
 set: function(value)
{
$("#ddlTabTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 表类型Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabTypeId", {
    get: function()
{
return $("#ddlTabTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表类型Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "TabTypeId_q", {
    get: function()
{
return $("#ddlTabTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 修改日期
*/
Object.defineProperty(PrjTabCRUD.prototype, "UpdDate", {
 set: function(value)
{
$("#gvUpdDate").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 修改日期
*/
Object.defineProperty(PrjTabCRUD.prototype, "UpdDate", {
    get: function()
{
return $("#gvUpdDate").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 修改用户Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "UpdUserId", {
 set: function(value)
{
$("#gvUpdUserId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 修改用户Id
*/
Object.defineProperty(PrjTabCRUD.prototype, "UpdUserId", {
    get: function()
{
return $("#gvUpdUserId").val();
 },
 enumerable: true,
configurable: true
});
PrjTabCRUD.strPrjId_Cache = "0005";
PrjTabCRUD.bolIsLoadEditRegion = false;  //
PrjTabCRUD.divName4Edit = "divEdit";  //
return PrjTabCRUD;
}());
exports.PrjTabCRUD = PrjTabCRUD;
});