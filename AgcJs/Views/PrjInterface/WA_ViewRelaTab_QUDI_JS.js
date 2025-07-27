
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_ViewRelaTab_QUDI_JS
 表名:ViewRelaTab(00050100)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 03:10:38
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
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
define(["require", "exports", "../../Js/L0_Entity/PrjInterface/clsViewRelaTabEN.js","../../Js/L2_BLL/PrjInterface/clsViewRelaTabBL.js","../../Js/L3_ForWApi/PrjInterface/clsViewRelaTabWApi.js","clscommonfunc4web","../../Js/L2_BLL/PrjInterface/clsvViewRelaTabBL.js","../../Js/L0_Entity/PrjInterface/clsvViewRelaTabEN.js","../../Js/L3_ForWApi/PrjInterface/clsvViewRelaTabWApi.js","tzdictionary","../../Js/L0_Entity/PrjInterface/clsViewInfoEN.js","../../Js/L3_ForWApi/PrjInterface/clsViewInfoWApi.js","../../Js/L0_Entity/SysPara/clsINOUTTypeEN.js","../../Js/L3_ForWApi/SysPara/clsINOUTTypeWApi.js","../../Js/L0_Entity/PrjInterface/clsViewTabTypeEN.js","../../Js/L3_ForWApi/PrjInterface/clsViewTabTypeWApi.js","../../Js/L0_Entity/Table_Field/clsPrjTabEN.js","../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js","../../Js/L0_Entity/RegionManage/clsViewRegionEN.js","../../Js/L3_ForWApi/RegionManage/clsViewRegionWApi.js","../../Js/PubFun/clsPager.js","clsstacktrace","../../Js/PubFun/clsOrderByData.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsDataColumn.js","../../Js/PubFun/clsPubFun.js","../../Js/PubFun/jsString.js","../../Js/PubFun/clsCommonFunc4Web.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsViewRelaTabEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsViewRelaTabEN.js");
var clsViewRelaTabBL_js_1 = require("../../Js/L2_BLL/PrjInterface/clsViewRelaTabBL.js");
var clsViewRelaTabWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsViewRelaTabWApi.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsvViewRelaTabBL_js_1 = require("../../Js/L2_BLL/PrjInterface/clsvViewRelaTabBL.js");
var clsvViewRelaTabEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsvViewRelaTabEN.js");
var clsvViewRelaTabWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsvViewRelaTabWApi.js");
var Dictionary_js_1 = require("tzdictionary");
var clsViewInfoEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsViewInfoEN.js");
var clsViewInfoWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsViewInfoWApi.js");
var clsINOUTTypeEN_js_1 = require("../../Js/L0_Entity/SysPara/clsINOUTTypeEN.js");
var clsINOUTTypeWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsINOUTTypeWApi.js");
var clsViewTabTypeEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsViewTabTypeEN.js");
var clsViewTabTypeWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsViewTabTypeWApi.js");
var clsPrjTabEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsPrjTabEN.js");
var clsPrjTabWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js");
var clsViewRegionEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsViewRegionEN.js");
var clsViewRegionWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsViewRegionWApi.js");
var clsPager_js_1 = require("../../Js/PubFun/clsPager.js");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsOrderByData_js_1 = require("../../Js/PubFun/clsOrderByData.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsDataColumn_js_1 = require("../../Js/PubFun/clsDataColumn.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var jsString_js_1 = require("../../Js/PubFun/jsString.js");
var arrSelectedKeys_js_1 = require("../../Js/PubFun/clsCommonFunc4Web.js");
 /* WA_ViewRelaTab_QUDI_JS 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
*/
var WA_ViewRelaTab_QUDI_JS = /** @class */ (function() {
function WA_ViewRelaTab_QUDI_JS()
{
this.mstrListDiv = "divDataLst";
this.objPager = new clsPager_js_1.clsPager();
 /*
 * 每页记录数，在扩展类可以修改
*/
this.RecCount = 0;
}
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "PageSize", {
get: function() { return 5;},
enumerable: true,
configurable: true
});


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
WA_ViewRelaTab_QUDI_JS.AddDPV_Edit = function(divName4Edit) {
var strUrl = "./WA_ViewRelaTab_Edit.html";
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
WA_ViewRelaTab_QUDI_JS.AddDPV_Pager = function(divName4Pager) {
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
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Page_Load)
*/
WA_ViewRelaTab_QUDI_JS.prototype.Page_Load = async function()
{
// 在此处放置用户代码以初始化页面
try
{
//建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvViewRelaTabBy = "mId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vViewRelaTab();
}
catch (e)
{
var strMsg = "页面启动不成功," + e+ ".";
alert(strMsg);
}
}


 /* 函数功能:页面导入,当页面开始运行时所发生的事件
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Page_Load_Cache)
*/
WA_ViewRelaTab_QUDI_JS.prototype.Page_Load_Cache = async function()
{
// 在此处放置用户代码以初始化页面
try
{
// 设置建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvViewRelaTabBy = "mId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vViewRelaTab_Cache();
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
WA_ViewRelaTab_QUDI_JS.prototype.BindDdl4EditRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();//编辑区域
 var objViewRegion_Cond = new clsViewRegionEN_js_1.clsViewRegionEN();//编辑区域
 var objINOUTType_Cond = new clsINOUTTypeEN_js_1.clsINOUTTypeEN();//编辑区域
 var objViewTabType_Cond = new clsViewTabTypeEN_js_1.clsViewTabTypeEN();//编辑区域
 var objPrjTab_Cond = new clsPrjTabEN_js_1.clsPrjTabEN();//编辑区域
var strPrjId = "";  //定义条件字段
//var strPrjId = "";//定义条件字段
const ddlViewId = await clsViewInfoWApi_js_1.clsViewInfoWApi.BindDdl_ViewId_Cache("ddlViewId", objViewInfo_Cond, strPrjId);//编辑区域
var strViewId = "";  //定义条件字段
//var strViewId = "";//定义条件字段
const ddlRegionId = await clsViewRegionWApi_js_1.clsViewRegionWApi.BindDdl_RegionId_Cache("ddlRegionId", objViewRegion_Cond, strViewId);//编辑区域
const ddlINOUTTypeId = await clsINOUTTypeWApi_js_1.clsINOUTTypeWApi.BindDdl_INOUTTypeId_Cache("ddlINOUTTypeId", objINOUTType_Cond);//编辑区域
const ddlViewTabTypeId = await clsViewTabTypeWApi_js_1.clsViewTabTypeWApi.BindDdl_ViewTabTypeId_Cache("ddlViewTabTypeId", objViewTabType_Cond);//编辑区域
const ddlTabId = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlTabId", objPrjTab_Cond, strPrjId);//编辑区域
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
WA_ViewRelaTab_QUDI_JS.prototype.BindDdl4QueryRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();//查询区域
 var objINOUTType_Cond = new clsINOUTTypeEN_js_1.clsINOUTTypeEN();//查询区域
 var objViewTabType_Cond = new clsViewTabTypeEN_js_1.clsViewTabTypeEN();//查询区域
 var objPrjTab_Cond = new clsPrjTabEN_js_1.clsPrjTabEN();//查询区域
var strPrjId_q = "";  //定义条件字段
//var strPrjId_q = "";//定义条件字段
const ddlViewId_q = await clsViewInfoWApi_js_1.clsViewInfoWApi.BindDdl_ViewId_Cache("ddlViewId_q", objViewInfo_Cond, strPrjId_q);//查询区域
const ddlINOUTTypeId_q = await clsINOUTTypeWApi_js_1.clsINOUTTypeWApi.BindDdl_INOUTTypeId_Cache("ddlINOUTTypeId_q", objINOUTType_Cond);//查询区域
const ddlViewTabTypeId_q = await clsViewTabTypeWApi_js_1.clsViewTabTypeWApi.BindDdl_ViewTabTypeId_Cache("ddlViewTabTypeId_q", objViewTabType_Cond);//查询区域
const ddlTabId_q = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlTabId_q", objPrjTab_Cond, strPrjId_q);//查询区域
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
*/
WA_ViewRelaTab_QUDI_JS.prototype.btnQuery_Click = async function(strListDiv) 
{
var strWhereCond = this.CombinevViewRelaTabCondition();
try
{
const responseRecCount = await clsvViewRelaTabWApi_js_1.clsvViewRelaTabWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: 1,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewRelaTabBy
};
const responseObjLst = await clsvViewRelaTabWApi_js_1.clsvViewRelaTabWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
var arrvViewRelaTabObjLst  = jsonData;
this.BindTab_vViewRelaTab(this.mstrListDiv, arrvViewRelaTabObjLst);
});
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
WA_ViewRelaTab_QUDI_JS.prototype.btnAddNewRecord_Click = async function() {
this.OpType = "Add";
try
{
if (WA_ViewRelaTab_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_ViewRelaTab_QUDI_JS.AddDPV_Edit(WA_ViewRelaTab_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
WA_ViewRelaTab_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_ViewRelaTab_QUDI_JS.prototype.btnAddNewRecordWithMaxId_Click = async function() {
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

 /*
  添加新记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnCopyRecord_Click)
 */
WA_ViewRelaTab_QUDI_JS.prototype.btnCopyRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vViewRelaTab();
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
WA_ViewRelaTab_QUDI_JS.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {
this.OpType = "Update";
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
var lngKeyId =  Number(strKeyId);
this.UpdateRecord(lngKeyId);
}

 /* 
 在数据表里删除记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDelRecordInTab_Click)
*/
WA_ViewRelaTab_QUDI_JS.prototype.btnDelRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
var lngKeyId =  Number(strKeyId);
const responseText = await this.DelRecord(lngKeyId);
const responseBindGv = await this.BindGv_vViewRelaTab();
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
WA_ViewRelaTab_QUDI_JS.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
var lngKeyId =  Number(strKeyId);
this.SelectRecord(lngKeyId);
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
WA_ViewRelaTab_QUDI_JS.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {
this.OpType = "Detail";
try
{
 if (strKeyId == "")
{
alert("请选择需要详细信息的记录！");
return "";
}
var lngKeyId =  Number(strKeyId);
this.DetailRecord(lngKeyId);
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
WA_ViewRelaTab_QUDI_JS.prototype.DelRecord = async function(lngmId) {
try
{
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.DelRecord(lngmId);
var returnInt = responseText;
if (returnInt > 0)
{
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
WA_ViewRelaTab_QUDI_JS.prototype.DetailRecord = async function(lngmId) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
try
{
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.GetObjBymId(lngmId);
var objViewRelaTabEN = responseText;
this.GetDataFromViewRelaTabClass(objViewRelaTabEN);
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
WA_ViewRelaTab_QUDI_JS.prototype.SelectRecord = async function(lngmId) 
{
try
{
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.GetObjBymId(lngmId);
var objViewRelaTabEN = responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vViewRelaTab");
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
WA_ViewRelaTab_QUDI_JS.prototype.btnUpdateRecord_Click = async function() {
this.OpType = "Update";
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (WA_ViewRelaTab_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_ViewRelaTab_QUDI_JS.AddDPV_Edit(WA_ViewRelaTab_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
WA_ViewRelaTab_QUDI_JS.bolIsLoadEditRegion = true;  //
var lngKeyId =  Number(strKeyId);
this.UpdateRecord(lngKeyId);
}
else
{
ShowDialog('Update');
var lngKeyId =  Number(strKeyId);
this.UpdateRecord(lngKeyId);
}
}

 /* 按标志恢复删除记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnUnDelRecordBySign_Click)
*/
WA_ViewRelaTab_QUDI_JS.prototype.btnUnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return "";
}
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.UnDelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vViewRelaTab();
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
WA_ViewRelaTab_QUDI_JS.prototype.btnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return "";
}
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.DelRecordBySign(arrKeyIds);
var returnInt = responseText;
if (returnInt > 0)
{
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
const responseText2 = await this.BindGv_vViewRelaTab();
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
WA_ViewRelaTab_QUDI_JS.prototype.btnDelRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vViewRelaTab();
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
WA_ViewRelaTab_QUDI_JS.prototype.btnExportExcel_Click = async function() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await clsvViewRelaTabWApi_js_1.clsvViewRelaTabWApi.GetObjLst(strWhereCond).then((jsonData)=>{
var arrvViewRelaTabObjLst  = jsonData;
this.BindTab_vViewRelaTab(this.mstrListDiv, arrvViewRelaTabObjLst);
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
WA_ViewRelaTab_QUDI_JS.prototype.btnOKUpd_Click = async function()
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
//const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
//var returnBool2 = jsonData;
//if (returnBool2 == true)
//{
//HideDialog();
//this.BindGv_vViewRelaTab();
//}
//});
}
else
{
const responseText2 = await this.AddNewRecordSave().then((jsonData)=>{
var returnBool = jsonData;
if (returnBool == true)
{
HideDialog();
this.BindGv_vViewRelaTab();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool = jsonData;
var strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In WA_ViewRelaTab_QUDI_JS.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_vViewRelaTab();
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
WA_ViewRelaTab_QUDI_JS.prototype.CombinevViewRelaTabCondition = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.ViewId_q != "" && this.ViewId_q != "0")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewId + " = '" + this.ViewId_q + "'";
}
if ( this.ViewName_q != "")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewName + " like '% " + this.ViewName_q + "%'";
}
if ( this.ViewCnName_q != "")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewCnName + " like '% " + this.ViewCnName_q + "%'";
}
if ( this.INOUTTypeId_q != "" && this.INOUTTypeId_q != "0")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_INOUTTypeId + " = '" + this.INOUTTypeId_q + "'";
}
if ( this.ViewTabTypeId_q != "" && this.ViewTabTypeId_q != "0")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewTabTypeId + " = '" + this.ViewTabTypeId_q + "'";
}
if ( this.TabId_q != "" && this.TabId_q != "0")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_TabId + " = '" + this.TabId_q + "'";
}
if ( this.TabFunction_q != "")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_TabFunction + " like '% " + this.TabFunction_q + "%'";
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombineViewRelaTabCondition)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
WA_ViewRelaTab_QUDI_JS.prototype.CombinevViewRelaTabConditionObj = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
var objvViewRelaTab_Cond = new clsViewRelaTabEN_js_1.clsViewRelaTabEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.ViewId_q != "" && this.ViewId_q != "0")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewId + " = '" + this.ViewId_q + "'";
objvViewRelaTab_Cond.SetCondFldValue(clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewId, this.ViewId_q, "=");
}
if ( this.ViewName_q != "")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewName + " like '% " + this.ViewName_q + "%'";
objvViewRelaTab_Cond.SetCondFldValue(clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewName, this.ViewName_q, "like");
}
if ( this.ViewCnName_q != "")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewCnName + " like '% " + this.ViewCnName_q + "%'";
objvViewRelaTab_Cond.SetCondFldValue(clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewCnName, this.ViewCnName_q, "like");
}
if ( this.INOUTTypeId_q != "" && this.INOUTTypeId_q != "0")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_INOUTTypeId + " = '" + this.INOUTTypeId_q + "'";
objvViewRelaTab_Cond.SetCondFldValue(clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_INOUTTypeId, this.INOUTTypeId_q, "=");
}
if ( this.ViewTabTypeId_q != "" && this.ViewTabTypeId_q != "0")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewTabTypeId + " = '" + this.ViewTabTypeId_q + "'";
objvViewRelaTab_Cond.SetCondFldValue(clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_ViewTabTypeId, this.ViewTabTypeId_q, "=");
}
if ( this.TabId_q != "" && this.TabId_q != "0")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_TabId + " = '" + this.TabId_q + "'";
objvViewRelaTab_Cond.SetCondFldValue(clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_TabId, this.TabId_q, "=");
}
if ( this.TabFunction_q != "")
{
strWhereCond += " And " + clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_TabFunction + " like '% " + this.TabFunction_q + "%'";
objvViewRelaTab_Cond.SetCondFldValue(clsViewRelaTabEN_js_1.clsViewRelaTabEN.con_TabFunction, this.TabFunction_q, "like");
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombineViewRelaTabConditionObj)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return objvViewRelaTab_Cond;
}

 /* 显示vViewRelaTab对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrViewRelaTabObjLst">需要绑定的对象列表</param>
*/
WA_ViewRelaTab_QUDI_JS.prototype.BindTab_vViewRelaTab = function(divContainer, arrvViewRelaTabObjLst) 
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
FldName: "mId",
ColHeader: "mId",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ViewId",
ColHeader: "界面Id",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ViewName",
ColHeader: "界面名称",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ViewCnName",
ColHeader: "视图中文名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "RegionName",
ColHeader: "区域名称",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "RegionTypeName",
ColHeader: "区域类型名称",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "INOUTTypeName",
ColHeader: "INOUT类型名称",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ViewTabTypeName",
ColHeader: "ViewTabTypeName",
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
FldName: "TabFunction",
ColHeader: "表功能说明",
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
FldName: "UpdUser",
ColHeader: "修改者",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "Memo",
ColHeader: "说明",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
];
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrvViewRelaTabObjLst, arrDataColumn, "mId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.PageSize = this.PageSize;
this.objPager.ShowPager();
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
WA_ViewRelaTab_QUDI_JS.prototype.IndexPage = function(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.CurrPageIndex = intPageIndex;
this.BindGv_vViewRelaTab();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv)
*/
WA_ViewRelaTab_QUDI_JS.prototype.BindGv_vViewRelaTab = async function() 
{
var strListDiv = this.mstrListDiv;
var strWhereCond = this.CombinevViewRelaTabCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvViewRelaTabObjLst = [];
try
{
const responseRecCount = await clsvViewRelaTabWApi_js_1.clsvViewRelaTabWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewRelaTabBy
};
const responseObjLst = await clsvViewRelaTabWApi_js_1.clsvViewRelaTabWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
arrvViewRelaTabObjLst = jsonData;
});
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvViewRelaTabObjLst.length == 0)
{
var strMsg = "在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！";
alert(strMsg);
return;
}
try
{
this.BindTab_vViewRelaTab(strListDiv, arrvViewRelaTabObjLst);
console.log("完成BindGv_vViewRelaTab!");
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg ="绑定对象列表不成功.Error Massage:" + e+ ".";
alert(strMsg);
}
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv_Cache)
*/
WA_ViewRelaTab_QUDI_JS.prototype.BindGv_vViewRelaTab_Cache = async function() 
{
var strListDiv = this.mstrListDiv;
var objvViewRelaTab_Cond = this.CombinevViewRelaTabConditionObj();
var objvViewRelaTabEN_Sim = clsvViewRelaTabBL_js_1.clsvViewRelaTabBL.GetSimObjFromObj(objvViewRelaTab_Cond);
console.log(objvViewRelaTabEN_Sim);
var strWhereCond = JSON.stringify(objvViewRelaTabEN_Sim);
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvViewRelaTabObjLst = [];
try
{
this.RecCount = await clsvViewRelaTabWApi_js_1.clsvViewRelaTabWApi.GetRecCountByCond_Cache(objvViewRelaTab_Cond);
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewRelaTabBy
};
var arrvViewRelaTabObjLst = await clsvViewRelaTabWApi_js_1.clsvViewRelaTabWApi.GetObjLstByPager_Cache(objPagerPara);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvViewRelaTabObjLst.length == 0)
{
var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=ViewRelaTab)";
alert(strMsg);
return;
}
try
{
this.BindTab_vViewRelaTab(strListDiv, arrvViewRelaTabObjLst);
console.log("完成BindGv_vViewRelaTab!");
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
WA_ViewRelaTab_QUDI_JS.prototype.SortBy = async function(strSortByFld) {
if (this.hidSortvViewRelaTabBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvViewRelaTabBy.indexOf("Asc") >= 0)
{
this.hidSortvViewRelaTabBy = "" + strSortByFld + " Desc";
}
else
{
this.hidSortvViewRelaTabBy = "" + strSortByFld + " Asc";
}
}
else
{
this.hidSortvViewRelaTabBy = "" + strSortByFld + " Asc";
}
const responseBindGv = await this.BindGv_vViewRelaTab();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
*/
WA_ViewRelaTab_QUDI_JS.prototype.QueryvViewRelaTabLst = function(strListDiv) 
{
var strWhereCond = this.CombinevViewRelaTabCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewRelaTabBy
};
const responseText = clsvViewRelaTabWApi_js_1.clsvViewRelaTabWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
var arrvViewRelaTabObjLst  = jsonData;
this.BindTab_vViewRelaTab(strListDiv, arrvViewRelaTabObjLst);
console.log("完成QueryvViewRelaTabLst!");
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
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Clear)
/// </summary>	
WA_ViewRelaTab_QUDI_JS.prototype.Clear = function()
{
}

 /* 获取当前表关键字值的最大值,再加1,避免重复
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
*/
WA_ViewRelaTab_QUDI_JS.prototype.GetMaxStrId = async function(strKeyCtrlName) {
this.DivName = "divGetMaxStrId";
try
{
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表ViewRelaTab的最大关键字为空，不成功，请检查!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
else
{
var strInfo = "获取表ViewRelaTab的最大关键字为：" + returnString + "!";
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
WA_ViewRelaTab_QUDI_JS.prototype.AddNewRecord = async function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucViewRelaTabB1.mId = clsViewRelaTabBL_js_1.clsViewRelaTabBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
*/
WA_ViewRelaTab_QUDI_JS.prototype.AddNewRecordWithMaxId = function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucViewRelaTabB1.mId = clsViewRelaTabBL_js_1.clsViewRelaTabBL.GetMaxStrId_S();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
*/
WA_ViewRelaTab_QUDI_JS.prototype.CopyRecord = async function(arrmId) {
try
{
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.GetObjLstBymIdLst(arrmId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrViewRelaTabObjLst =  responseText;
for (let objInFor of arrViewRelaTabObjLst)
{
const responseText2 = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.AddNewRecord(objInFor);
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

 /* 函数功能:把界面上的属性数据传到类对象中
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_PutDataToClass)
  <param name = "pobjViewRelaTabEN">数据传输的目的类对象</param>
*/
WA_ViewRelaTab_QUDI_JS.prototype.PutDataToViewRelaTabClass = function(pobjViewRelaTabEN)
{
pobjViewRelaTabEN.ViewId = this.ViewId;// 界面Id
pobjViewRelaTabEN.RegionId = this.RegionId;// 区域Id
pobjViewRelaTabEN.INOUTTypeId = this.INOUTTypeId;// INOUT类型ID
pobjViewRelaTabEN.ViewTabTypeId = this.ViewTabTypeId;// 界面表类型码
pobjViewRelaTabEN.TabId = this.TabId;// 表ID
pobjViewRelaTabEN.TabFunction = this.TabFunction;// 表功能说明
pobjViewRelaTabEN.UpdDate = this.UpdDate;// 修改日期
pobjViewRelaTabEN.UpdUser = this.UpdUser;// 修改者
pobjViewRelaTabEN.Memo = this.Memo;// 说明
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
*/
WA_ViewRelaTab_QUDI_JS.prototype.AddNewRecordSave = async function(){
this.DivName = "divAddNewRecordSave";
var objViewRelaTabEN = new clsViewRelaTabEN_js_1.clsViewRelaTabEN();
   this.PutDataToViewRelaTabClass(objViewRelaTabEN);
try
{
const responseText2 = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.AddNewRecord(objViewRelaTabEN);
var returnBool = !!responseText2;
if (returnBool == true)
{
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
  <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
*/
WA_ViewRelaTab_QUDI_JS.prototype.ShowData = async function(lngmId) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objViewRelaTabEN = new clsViewRelaTabEN_js_1.clsViewRelaTabEN();
        try {
            const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.IsExist(lngmId);
            var returnBool = responseText;
            if (returnBool == false) {
                var strInfo = "关键字:[" + lngmId + "] 的记录不存在!";
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
            const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.GetObjBymId(lngmId);
            objViewRelaTabEN = responseText;
        }
        catch (e) {
            var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromViewRelaTabClass(objViewRelaTabEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
  <param name = "pobjViewRelaTabEN">表实体类对象</param>
*/
WA_ViewRelaTab_QUDI_JS.prototype.GetDataFromViewRelaTabClass = function(pobjViewRelaTabEN )
{
 this.ViewId = pobjViewRelaTabEN.ViewId;// 界面Id
 this.RegionId = pobjViewRelaTabEN.RegionId;// 区域Id
 this.INOUTTypeId = pobjViewRelaTabEN.INOUTTypeId;// INOUT类型ID
 this.ViewTabTypeId = pobjViewRelaTabEN.ViewTabTypeId;// 界面表类型码
 this.TabId = pobjViewRelaTabEN.TabId;// 表ID
 this.TabFunction = pobjViewRelaTabEN.TabFunction;// 表功能说明
 this.UpdDate = pobjViewRelaTabEN.UpdDate;// 修改日期
 this.UpdUser = pobjViewRelaTabEN.UpdUser;// 修改者
 this.Memo = pobjViewRelaTabEN.Memo;// 说明
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
WA_ViewRelaTab_QUDI_JS.prototype.UpdateRecord = async function(lngmId) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = lngmId.toString();
try
{
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.GetObjBymId(lngmId);
var objViewRelaTabEN = responseText;
this.GetDataFromViewRelaTabClass(objViewRelaTabEN);
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
WA_ViewRelaTab_QUDI_JS.prototype.UpdateRecordSave = async function() {
this.DivName = "divUpdateRecordSave";
var objViewRelaTabEN = new clsViewRelaTabEN_js_1.clsViewRelaTabEN();
objViewRelaTabEN.mId = Number(this.KeyId);
   this.PutDataToViewRelaTabClass(objViewRelaTabEN);
objViewRelaTabEN.sf_UpdFldSetStr = objViewRelaTabEN.UpdFldString;//设置哪些字段被修改(脏字段)
if (objViewRelaTabEN.mId == 0 || objViewRelaTabEN.mId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.UpdateRecord(objViewRelaTabEN);
var returnBool = !!responseText;
if (returnBool == true)
{
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
WA_ViewRelaTab_QUDI_JS.prototype.DelMultiRecord = async function(arrmId) {
try
{
const responseText = await clsViewRelaTabWApi_js_1.clsViewRelaTabWApi.DelViewRelaTabs(arrmId);
var returnInt = responseText;
if (returnInt > 0)
{
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
  <param name = "objViewRelaTab">需要显示的对象</param>
*/
WA_ViewRelaTab_QUDI_JS.prototype.ShowViewRelaTabObj = function(divContainer, objViewRelaTab) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objViewRelaTab);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objViewRelaTab[strKey];
var li = document.createElement("li");
li.innerHTML = "" + strKey + ":" + strValue + "";
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
  <param name = "pobjViewRelaTabEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
WA_ViewRelaTab_QUDI_JS.prototype.GetFirstKey = function() {
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
WA_ViewRelaTab_QUDI_JS.prototype.Demo_Session = async function()
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
WA_ViewRelaTab_QUDI_JS.prototype.SetSession = function(Key, Value) {
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
WA_ViewRelaTab_QUDI_JS.prototype.GetSession = function(Key) {
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
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "btnCancel", {
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
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "btnOKUpd", {
    get: function()
{
return $("#btnOKUpd").html();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置当前页序号
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "DivName", {
 set: function(value)
{
$("#hidDivName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 设置排序字段-相当使用ViewState功能
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "hidSortvViewRelaTabBy", {
 set: function(value)
{
$("#hidSortvViewRelaTabBy").val(value);
},
    get: function()
{
return $("#hidSortvViewRelaTabBy").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 用户Id
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "hidUserId", {
    get: function()
{
return $("#hidUserId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * INOUT类型ID
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "INOUTTypeId", {
 set: function(value)
{
$("#ddlINOUTTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * INOUT类型ID
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "INOUTTypeId", {
    get: function()
{
return $("#ddlINOUTTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * INOUT类型ID
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "INOUTTypeId_q", {
    get: function()
{
return $("#ddlINOUTTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置关键字的值
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "KeyId", {
    get: function()
{
return $("#hidKeyId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 说明
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "OpType", {
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
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "OpType", {
    get: function()
{
return $("#hidOpType").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 区域Id
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "RegionId", {
 set: function(value)
{
$("#ddlRegionId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 区域Id
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "RegionId", {
    get: function()
{
return $("#ddlRegionId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表功能说明
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "TabFunction", {
 set: function(value)
{
$("#txtTabFunction").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 表功能说明
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "TabFunction", {
    get: function()
{
return $("#txtTabFunction").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表功能说明
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "TabFunction_q", {
    get: function()
{
return $("#txtTabFunction_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表ID
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "TabId", {
 set: function(value)
{
$("#ddlTabId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 表ID
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "TabId", {
    get: function()
{
return $("#ddlTabId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表ID
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "TabId_q", {
    get: function()
{
return $("#ddlTabId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 修改日期
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "UpdDate", {
 set: function(value)
{
$("#txtUpdDate").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 修改日期
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "UpdDate", {
    get: function()
{
return $("#txtUpdDate").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 修改者
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "UpdUser", {
 set: function(value)
{
$("#txtUpdUser").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 修改者
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "UpdUser", {
    get: function()
{
return $("#txtUpdUser").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 视图中文名
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "ViewCnName_q", {
    get: function()
{
return $("#txtViewCnName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面Id
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "ViewId", {
 set: function(value)
{
$("#ddlViewId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 界面Id
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "ViewId", {
    get: function()
{
return $("#ddlViewId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面Id
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "ViewId_q", {
    get: function()
{
return $("#ddlViewId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面名称
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "ViewName_q", {
    get: function()
{
return $("#txtViewName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面表类型码
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "ViewTabTypeId", {
 set: function(value)
{
$("#ddlViewTabTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 界面表类型码
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "ViewTabTypeId", {
    get: function()
{
return $("#ddlViewTabTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面表类型码
*/
Object.defineProperty(WA_ViewRelaTab_QUDI_JS.prototype, "ViewTabTypeId_q", {
    get: function()
{
return $("#ddlViewTabTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
WA_ViewRelaTab_QUDI_JS.bolIsLoadEditRegion = false;  //
WA_ViewRelaTab_QUDI_JS.divName4Edit = "divEdit";  //
return WA_ViewRelaTab_QUDI_JS;
}());
exports.WA_ViewRelaTab_QUDI_JS = WA_ViewRelaTab_QUDI_JS;
});