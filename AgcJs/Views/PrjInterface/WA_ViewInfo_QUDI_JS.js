
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_ViewInfo_QUDI_JS
 表名:ViewInfo(00050006)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 03:10:39
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
define(["require", "exports", "../../Js/L0_Entity/PrjInterface/clsViewInfoEN.js","../../Js/L2_BLL/PrjInterface/clsViewInfoBL.js","../../Js/L3_ForWApi/PrjInterface/clsViewInfoWApi.js","clscommonfunc4web","../../Js/L2_BLL/PrjInterface/clsvViewInfoBL.js","../../Js/L0_Entity/PrjInterface/clsvViewInfoEN.js","../../Js/L3_ForWApi/PrjInterface/clsvViewInfoWApi.js","tzdictionary","../../Js/L0_Entity/GeneCode/clsApplicationTypeEN.js","../../Js/L3_ForWApi/GeneCode/clsApplicationTypeWApi.js","../../Js/L0_Entity/PrjManage/clsFuncModule_AgcEN.js","../../Js/L3_ForWApi/PrjManage/clsFuncModule_AgcWApi.js","../../Js/L0_Entity/Table_Field/clsPrjTabEN.js","../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js","../../Js/L0_Entity/PrjInterface/clsViewTypeCodeTabEN.js","../../Js/L3_ForWApi/PrjInterface/clsViewTypeCodeTabWApi.js","../../Js/L0_Entity/PrjInterface/clsSQLDSTypeEN.js","../../Js/L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js","../../Js/PubFun/clsPager.js","clsstacktrace","../../Js/PubFun/clsOrderByData.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsDataColumn.js","../../Js/PubFun/clsPubFun.js","../../Js/PubFun/jsString.js","../../Js/PubFun/clsCommonFunc4Web.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsViewInfoEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsViewInfoEN.js");
var clsViewInfoBL_js_1 = require("../../Js/L2_BLL/PrjInterface/clsViewInfoBL.js");
var clsViewInfoWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsViewInfoWApi.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsvViewInfoBL_js_1 = require("../../Js/L2_BLL/PrjInterface/clsvViewInfoBL.js");
var clsvViewInfoEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsvViewInfoEN.js");
var clsvViewInfoWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsvViewInfoWApi.js");
var Dictionary_js_1 = require("tzdictionary");
var clsApplicationTypeEN_js_1 = require("../../Js/L0_Entity/GeneCode/clsApplicationTypeEN.js");
var clsApplicationTypeWApi_js_1 = require("../../Js/L3_ForWApi/GeneCode/clsApplicationTypeWApi.js");
var clsFuncModule_AgcEN_js_1 = require("../../Js/L0_Entity/PrjManage/clsFuncModule_AgcEN.js");
var clsFuncModule_AgcWApi_js_1 = require("../../Js/L3_ForWApi/PrjManage/clsFuncModule_AgcWApi.js");
var clsPrjTabEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsPrjTabEN.js");
var clsPrjTabWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js");
var clsViewTypeCodeTabEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsViewTypeCodeTabEN.js");
var clsViewTypeCodeTabWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsViewTypeCodeTabWApi.js");
var clsSQLDSTypeEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsSQLDSTypeEN.js");
var clsSQLDSTypeWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js");
var clsPager_js_1 = require("../../Js/PubFun/clsPager.js");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsOrderByData_js_1 = require("../../Js/PubFun/clsOrderByData.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsDataColumn_js_1 = require("../../Js/PubFun/clsDataColumn.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var jsString_js_1 = require("../../Js/PubFun/jsString.js");
var arrSelectedKeys_js_1 = require("../../Js/PubFun/clsCommonFunc4Web.js");
 /* WA_ViewInfo_QUDI_JS 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
*/
var WA_ViewInfo_QUDI_JS = /** @class */ (function() {
function WA_ViewInfo_QUDI_JS()
{
this.mstrListDiv = "divDataLst";
this.objPager = new clsPager_js_1.clsPager();
 /*
 * 每页记录数，在扩展类可以修改
*/
this.RecCount = 0;
}
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "PageSize", {
get: function() { return 5;},
enumerable: true,
configurable: true
});


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
WA_ViewInfo_QUDI_JS.AddDPV_Edit = function(divName4Edit) {
var strUrl = "./WA_ViewInfo_Edit.html";
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
WA_ViewInfo_QUDI_JS.AddDPV_Pager = function(divName4Pager) {
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
WA_ViewInfo_QUDI_JS.prototype.Page_Load = async function()
{
// 在此处放置用户代码以初始化页面
try
{
//建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvViewInfoBy = "ViewId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vViewInfo();
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
WA_ViewInfo_QUDI_JS.prototype.Page_Load_Cache = async function()
{
// 在此处放置用户代码以初始化页面
try
{
// 设置建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvViewInfoBy = "ViewId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vViewInfo_Cache();
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
WA_ViewInfo_QUDI_JS.prototype.BindDdl4EditRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objPrjTab_Cond = new clsPrjTabEN_js_1.clsPrjTabEN();//编辑区域
 var objApplicationType_Cond = new clsApplicationTypeEN_js_1.clsApplicationTypeEN();//编辑区域
 var objViewTypeCodeTab_Cond = new clsViewTypeCodeTabEN_js_1.clsViewTypeCodeTabEN();//编辑区域
 var objFuncModule_Agc_Cond = new clsFuncModule_AgcEN_js_1.clsFuncModule_AgcEN();//编辑区域
 var objSQLDSType_Cond = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();//编辑区域
var strPrjId = WA_ViewInfo_QUDI_JS.strPrjId_Cache;  //定义条件字段
//var strPrjId = "";//定义条件字段
const ddlMainTabId = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlMainTabId", objPrjTab_Cond, strPrjId);//编辑区域
var bolIsVisible = WA_ViewInfo_QUDI_JS.strPrjId_Cache;  //定义条件字段
//var bolIsVisible = "";//定义条件字段
const ddlApplicationTypeId = await clsApplicationTypeWApi_js_1.clsApplicationTypeWApi.BindDdl_ApplicationTypeId_Cache("ddlApplicationTypeId", objApplicationType_Cond, bolIsVisible);//编辑区域
const ddlViewTypeCode = await clsViewTypeCodeTabWApi_js_1.clsViewTypeCodeTabWApi.BindDdl_ViewTypeCode_Cache("ddlViewTypeCode", objViewTypeCodeTab_Cond);//编辑区域
const ddlFuncModuleAgcId = await clsFuncModule_AgcWApi_js_1.clsFuncModule_AgcWApi.BindDdl_FuncModuleAgcId_Cache("ddlFuncModuleAgcId", objFuncModule_Agc_Cond, strPrjId);//编辑区域
const ddlINSQLDSTypeId = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.BindDdl_SQLDSTypeId_Cache("ddlINSQLDSTypeId", objSQLDSType_Cond);//编辑区域
const ddlINRelaTabId = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlINRelaTabId", objPrjTab_Cond, strPrjId);//编辑区域
const ddlOUTSQLDSTypeId = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.BindDdl_SQLDSTypeId_Cache("ddlOUTSQLDSTypeId", objSQLDSType_Cond);//编辑区域
const ddlOUTRelaTabId = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlOUTRelaTabId", objPrjTab_Cond, strPrjId);//编辑区域
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
WA_ViewInfo_QUDI_JS.prototype.BindDdl4QueryRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objApplicationType_Cond = new clsApplicationTypeEN_js_1.clsApplicationTypeEN();//查询区域
 var objFuncModule_Agc_Cond = new clsFuncModule_AgcEN_js_1.clsFuncModule_AgcEN();//查询区域
 var objPrjTab_Cond = new clsPrjTabEN_js_1.clsPrjTabEN();//查询区域
 var objViewTypeCodeTab_Cond = new clsViewTypeCodeTabEN_js_1.clsViewTypeCodeTabEN();//查询区域
var bolIsVisible_q = WA_ViewInfo_QUDI_JS.strPrjId_Cache;  //定义条件字段
//var bolIsVisible_q = "";//定义条件字段
const ddlApplicationTypeId_q = await clsApplicationTypeWApi_js_1.clsApplicationTypeWApi.BindDdl_ApplicationTypeId_Cache("ddlApplicationTypeId_q", objApplicationType_Cond, bolIsVisible_q);//查询区域
var strPrjId_q = WA_ViewInfo_QUDI_JS.strPrjId_Cache;  //定义条件字段
//var strPrjId_q = "";//定义条件字段
const ddlFuncModuleAgcId_q = await clsFuncModule_AgcWApi_js_1.clsFuncModule_AgcWApi.BindDdl_FuncModuleAgcId_Cache("ddlFuncModuleAgcId_q", objFuncModule_Agc_Cond, strPrjId_q);//查询区域
const ddlMainTabId_q = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlMainTabId_q", objPrjTab_Cond, strPrjId_q);//查询区域
const ddlViewTypeCode_q = await clsViewTypeCodeTabWApi_js_1.clsViewTypeCodeTabWApi.BindDdl_ViewTypeCode_Cache("ddlViewTypeCode_q", objViewTypeCodeTab_Cond);//查询区域
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
*/
WA_ViewInfo_QUDI_JS.prototype.btnQuery_Click = async function(strListDiv) 
{
var strWhereCond = this.CombinevViewInfoCondition();
try
{
const responseRecCount = await clsvViewInfoWApi_js_1.clsvViewInfoWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: 1,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewInfoBy
};
const responseObjLst = await clsvViewInfoWApi_js_1.clsvViewInfoWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
var arrvViewInfoObjLst  = jsonData;
this.BindTab_vViewInfo(this.mstrListDiv, arrvViewInfoObjLst);
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
WA_ViewInfo_QUDI_JS.prototype.btnAddNewRecord_Click = async function() {
this.OpType = "Add";
try
{
if (WA_ViewInfo_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_ViewInfo_QUDI_JS.AddDPV_Edit(WA_ViewInfo_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
WA_ViewInfo_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_ViewInfo_QUDI_JS.prototype.btnAddNewRecordWithMaxId_Click = async function() {
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
WA_ViewInfo_QUDI_JS.prototype.btnCopyRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vViewInfo();
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
WA_ViewInfo_QUDI_JS.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {
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
WA_ViewInfo_QUDI_JS.prototype.btnDelRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelRecord(strKeyId);
const responseBindGv = await this.BindGv_vViewInfo();
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
WA_ViewInfo_QUDI_JS.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {
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
WA_ViewInfo_QUDI_JS.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {
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
WA_ViewInfo_QUDI_JS.prototype.DelRecord = async function(strViewId) {
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.DelRecord(strViewId);
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
WA_ViewInfo_QUDI_JS.prototype.DetailRecord = async function(strViewId) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjByViewId(strViewId);
var objViewInfoEN = responseText;
this.GetDataFromViewInfoClass(objViewInfoEN);
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
WA_ViewInfo_QUDI_JS.prototype.SelectRecord = async function(strViewId) 
{
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjByViewId(strViewId);
var objViewInfoEN = responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vViewInfo");
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
WA_ViewInfo_QUDI_JS.prototype.btnUpdateRecord_Click = async function() {
this.OpType = "Update";
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (WA_ViewInfo_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_ViewInfo_QUDI_JS.AddDPV_Edit(WA_ViewInfo_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
WA_ViewInfo_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_ViewInfo_QUDI_JS.prototype.btnUnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return "";
}
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.UnDelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vViewInfo();
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
WA_ViewInfo_QUDI_JS.prototype.btnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return "";
}
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.DelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vViewInfo();
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
WA_ViewInfo_QUDI_JS.prototype.btnDelRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vViewInfo();
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
WA_ViewInfo_QUDI_JS.prototype.btnExportExcel_Click = async function() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await clsvViewInfoWApi_js_1.clsvViewInfoWApi.GetObjLst(strWhereCond).then((jsonData)=>{
var arrvViewInfoObjLst  = jsonData;
this.BindTab_vViewInfo(this.mstrListDiv, arrvViewInfoObjLst);
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
WA_ViewInfo_QUDI_JS.prototype.btnOKUpd_Click = async function()
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
this.BindGv_vViewInfo();
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
this.BindGv_vViewInfo();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool = jsonData;
var strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In WA_ViewInfo_QUDI_JS.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_vViewInfo();
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
WA_ViewInfo_QUDI_JS.prototype.CombinevViewInfoCondition = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.ViewId_q != "")
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_ViewId + " like '% " + this.ViewId_q + "%'";
}
if ( this.ViewName_q != "")
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_ViewName + " like '% " + this.ViewName_q + "%'";
}
if (this.ApplicationTypeId_q != 0)
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_ApplicationTypeId + " = " + this.ApplicationTypeId_q + "";
}
if ( this.FuncModuleAgcId_q != "" && this.FuncModuleAgcId_q != "0")
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_FuncModuleAgcId + " = '" + this.FuncModuleAgcId_q + "'";
}
if ( this.MainTabId_q != "" && this.MainTabId_q != "0")
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_MainTabId + " = '" + this.MainTabId_q + "'";
}
if (this.ViewTypeCode_q != 0)
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_ViewTypeCode + " = " + this.ViewTypeCode_q + "";
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombineViewInfoCondition)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
WA_ViewInfo_QUDI_JS.prototype.CombinevViewInfoConditionObj = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
var objvViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.ViewId_q != "")
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_ViewId + " like '% " + this.ViewId_q + "%'";
objvViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_ViewId, this.ViewId_q, "like");
}
if ( this.ViewName_q != "")
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_ViewName + " like '% " + this.ViewName_q + "%'";
objvViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_ViewName, this.ViewName_q, "like");
}
if (this.ApplicationTypeId_q != 0)
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_ApplicationTypeId + " = " + this.ApplicationTypeId_q + "";
objvViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_ApplicationTypeId, this.ApplicationTypeId_q, "=");
}
if ( this.FuncModuleAgcId_q != "" && this.FuncModuleAgcId_q != "0")
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_FuncModuleAgcId + " = '" + this.FuncModuleAgcId_q + "'";
objvViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_FuncModuleAgcId, this.FuncModuleAgcId_q, "=");
}
if ( this.MainTabId_q != "" && this.MainTabId_q != "0")
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_MainTabId + " = '" + this.MainTabId_q + "'";
objvViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_MainTabId, this.MainTabId_q, "=");
}
if (this.ViewTypeCode_q != 0)
{
strWhereCond += " And " + clsViewInfoEN_js_1.clsViewInfoEN.con_ViewTypeCode + " = " + this.ViewTypeCode_q + "";
objvViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_ViewTypeCode, this.ViewTypeCode_q, "=");
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombineViewInfoConditionObj)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return objvViewInfo_Cond;
}

 /* 显示vViewInfo对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrViewInfoObjLst">需要绑定的对象列表</param>
*/
WA_ViewInfo_QUDI_JS.prototype.BindTab_vViewInfo = function(divContainer, arrvViewInfoObjLst) 
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
FldName: "ViewId",
ColHeader: "界面ID",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ViewName",
ColHeader: "界面名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ViewCnName",
ColHeader: "中文名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ViewTypeName",
ColHeader: "界面类型",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "MainTabName",
ColHeader: "主表",
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
FldName: "UpdDate",
ColHeader: "修改日期",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "TitleStyleName",
ColHeader: "标题类型",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "DGStyleName",
ColHeader: "DG模式名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "RegionNum",
ColHeader: "区域数",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsUseCache4List",
ColHeader: "列表缓存?",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ApplicationTypeSimName",
ColHeader: "应用程序类型简称",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
];
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrvViewInfoObjLst, arrDataColumn, "ViewId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.PageSize = this.PageSize;
this.objPager.ShowPager();
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
WA_ViewInfo_QUDI_JS.prototype.IndexPage = function(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.CurrPageIndex = intPageIndex;
this.BindGv_vViewInfo();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv)
*/
WA_ViewInfo_QUDI_JS.prototype.BindGv_vViewInfo = async function() 
{
var strListDiv = this.mstrListDiv;
var strWhereCond = this.CombinevViewInfoCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvViewInfoObjLst = [];
try
{
const responseRecCount = await clsvViewInfoWApi_js_1.clsvViewInfoWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewInfoBy
};
const responseObjLst = await clsvViewInfoWApi_js_1.clsvViewInfoWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
arrvViewInfoObjLst = jsonData;
});
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvViewInfoObjLst.length == 0)
{
var strMsg = "在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！";
alert(strMsg);
return;
}
try
{
this.BindTab_vViewInfo(strListDiv, arrvViewInfoObjLst);
console.log("完成BindGv_vViewInfo!");
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
WA_ViewInfo_QUDI_JS.prototype.BindGv_vViewInfo_Cache = async function() 
{
var strListDiv = this.mstrListDiv;
var objvViewInfo_Cond = this.CombinevViewInfoConditionObj();
objvViewInfo_Cond.SetCondFldValue(clsViewInfoEN_js_1.clsViewInfoEN.con_PrjId, WA_ViewInfo_QUDI_JS.strPrjId_Cache, "=");
var objvViewInfoEN_Sim = clsvViewInfoBL_js_1.clsvViewInfoBL.GetSimObjFromObj(objvViewInfo_Cond);
console.log(objvViewInfoEN_Sim);
var strWhereCond = JSON.stringify(objvViewInfoEN_Sim);
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvViewInfoObjLst = [];
try
{
this.RecCount = await  clsvViewInfoWApi_js_1.clsvViewInfoWApi.GetRecCountByCond_Cache(objvViewInfo_Cond, WA_ViewInfo_QUDI_JS.strPrjId_Cache);
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewInfoBy
};
var arrvViewInfoObjLst = await clsvViewInfoWApi_js_1.clsvViewInfoWApi.GetObjLstByPager_Cache(objPagerPara, WA_ViewInfo_QUDI_JS.strPrjId_Cache);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvViewInfoObjLst.length == 0)
{
var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=ViewInfo_" + WA_ViewInfo_QUDI_JS.strPrjId_Cache + ")";
alert(strMsg);
return;
}
try
{
this.BindTab_vViewInfo(strListDiv, arrvViewInfoObjLst);
console.log("完成BindGv_vViewInfo!");
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
WA_ViewInfo_QUDI_JS.prototype.SortBy = async function(strSortByFld) {
if (this.hidSortvViewInfoBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvViewInfoBy.indexOf("Asc") >= 0)
{
this.hidSortvViewInfoBy = "" + strSortByFld + " Desc";
}
else
{
this.hidSortvViewInfoBy = "" + strSortByFld + " Asc";
}
}
else
{
this.hidSortvViewInfoBy = "" + strSortByFld + " Asc";
}
const responseBindGv = await this.BindGv_vViewInfo();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
*/
WA_ViewInfo_QUDI_JS.prototype.QueryvViewInfoLst = function(strListDiv) 
{
var strWhereCond = this.CombinevViewInfoCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewInfoBy
};
const responseText = clsvViewInfoWApi_js_1.clsvViewInfoWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
var arrvViewInfoObjLst  = jsonData;
this.BindTab_vViewInfo(strListDiv, arrvViewInfoObjLst);
console.log("完成QueryvViewInfoLst!");
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
WA_ViewInfo_QUDI_JS.prototype.SetKeyReadOnly = function(bolReadonly)
{
$('#txtViewId').prop['ReadOnly'] = bolReadonly;
}

/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Clear)
/// </summary>	
WA_ViewInfo_QUDI_JS.prototype.Clear = function()
{
}

 /* 获取当前表关键字值的最大值,再加1,避免重复
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
*/
WA_ViewInfo_QUDI_JS.prototype.GetMaxStrId = async function(strKeyCtrlName) {
this.DivName = "divGetMaxStrId";
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表ViewInfo的最大关键字为空，不成功，请检查!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
else
{
var strInfo = "获取表ViewInfo的最大关键字为：" + returnString + "!";
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
WA_ViewInfo_QUDI_JS.prototype.AddNewRecord = async function()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucViewInfoB1.ViewId = clsViewInfoBL_js_1.clsViewInfoBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
*/
WA_ViewInfo_QUDI_JS.prototype.AddNewRecordWithMaxId = function()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucViewInfoB1.ViewId = clsViewInfoBL_js_1.clsViewInfoBL.GetMaxStrId_S();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
*/
WA_ViewInfo_QUDI_JS.prototype.CopyRecord = async function(arrViewId) {
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjLstByViewIdLst(arrViewId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrViewInfoObjLst =  responseText;
for (let objInFor of arrViewInfoObjLst)
{
const responseText2 = await clsViewInfoWApi_js_1.clsViewInfoWApi.AddNewRecord(objInFor);
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
  <param name = "pobjViewInfoEN">数据传输的目的类对象</param>
*/
WA_ViewInfo_QUDI_JS.prototype.PutDataToViewInfoClass = function(pobjViewInfoEN)
{
pobjViewInfoEN.MainTabId = this.MainTabId;// 主表ID
pobjViewInfoEN.ViewId = this.ViewId;// 界面ID
pobjViewInfoEN.ApplicationTypeId = this.ApplicationTypeId;// 应用类型
pobjViewInfoEN.ViewTypeCode = this.ViewTypeCode;// 界面类型
pobjViewInfoEN.FuncModuleAgcId = this.FuncModuleAgcId;// 功能模块
pobjViewInfoEN.IsUseCache4List = this.IsUseCache4List;// 是否使用缓存列表
pobjViewInfoEN.ViewName = this.ViewName;// 界面名称
pobjViewInfoEN.FileName = this.FileName;// 文件名
pobjViewInfoEN.ViewCnName = this.ViewCnName;// 中文名
pobjViewInfoEN.DefaMenuName = this.DefaMenuName;// 缺省菜单名
pobjViewInfoEN.FilePath = this.FilePath;// 文件路径
pobjViewInfoEN.IsNeedSetExportFld = this.IsNeedSetExportFld;// 是否需要设置导出字段
pobjViewInfoEN.INSQLDSTypeId = this.INSQLDSTypeId;// 输入数据源类型
pobjViewInfoEN.INRelaTabId = this.INRelaTabId;// 输入数据源表ID
pobjViewInfoEN.OUTSQLDSTypeId = this.OUTSQLDSTypeId;// 输出数据源类型
pobjViewInfoEN.OUTRelaTabId = this.OUTRelaTabId;// 输出数据源表ID
pobjViewInfoEN.ViewFunction = this.ViewFunction;// 界面功能
pobjViewInfoEN.ViewDetail = this.ViewDetail;// 界面说明
pobjViewInfoEN.Memo = this.Memo;// 说明
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
*/
WA_ViewInfo_QUDI_JS.prototype.AddNewRecordSave = async function(){
this.DivName = "divAddNewRecordSave";
var objViewInfoEN = new clsViewInfoEN_js_1.clsViewInfoEN();
   this.PutDataToViewInfoClass(objViewInfoEN);
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.IsExist(objViewInfoEN.ViewId);
var bolIsExist = responseText;
if (bolIsExist == true)
{
var strMsg = "添加记录时，关键字：" + objViewInfoEN.ViewId + "已经存在！";
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsViewInfoWApi_js_1.clsViewInfoWApi.AddNewRecord(objViewInfoEN);
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

 /* 添加新记录，由后台自动获取最大值的关键字。保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxIdSave)
*/
WA_ViewInfo_QUDI_JS.prototype.AddNewRecordWithMaxIdSave = async function(){
this.DivName = "divAddNewRecordWithMaxIdSave";
var objViewInfoEN = new clsViewInfoEN_js_1.clsViewInfoEN();
   this.PutDataToViewInfoClass(objViewInfoEN);
try
{
const responseText2 = await clsViewInfoWApi_js_1.clsViewInfoWApi.AddNewRecordWithMaxId(objViewInfoEN);
var returnBool = !!responseText2;
if (returnBool == true)
{
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
  <param name = "strViewId">表记录的关键字,显示该表关键字的内容</param>
*/
WA_ViewInfo_QUDI_JS.prototype.ShowData = async function(strViewId) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objViewInfoEN = new clsViewInfoEN_js_1.clsViewInfoEN();
        try {
            const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.IsExist(strViewId);
            var returnBool = responseText;
            if (returnBool == false) {
                var strInfo = "关键字:[" + strViewId + "] 的记录不存在!";
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
            const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjByViewId(strViewId);
            objViewInfoEN = responseText;
        }
        catch (e) {
            var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromViewInfoClass(objViewInfoEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
  <param name = "pobjViewInfoEN">表实体类对象</param>
*/
WA_ViewInfo_QUDI_JS.prototype.GetDataFromViewInfoClass = function(pobjViewInfoEN )
{
 this.MainTabId = pobjViewInfoEN.MainTabId;// 主表ID
 this.ViewId = pobjViewInfoEN.ViewId;// 界面ID
 this.ApplicationTypeId = pobjViewInfoEN.ApplicationTypeId;// 应用类型
 this.ViewTypeCode = pobjViewInfoEN.ViewTypeCode;// 界面类型
 this.FuncModuleAgcId = pobjViewInfoEN.FuncModuleAgcId;// 功能模块
this.IsUseCache4List = pobjViewInfoEN.IsUseCache4List;// 是否使用缓存列表
 this.ViewName = pobjViewInfoEN.ViewName;// 界面名称
 this.FileName = pobjViewInfoEN.FileName;// 文件名
 this.ViewCnName = pobjViewInfoEN.ViewCnName;// 中文名
 this.DefaMenuName = pobjViewInfoEN.DefaMenuName;// 缺省菜单名
 this.FilePath = pobjViewInfoEN.FilePath;// 文件路径
this.IsNeedSetExportFld = pobjViewInfoEN.IsNeedSetExportFld;// 是否需要设置导出字段
 this.INSQLDSTypeId = pobjViewInfoEN.INSQLDSTypeId;// 输入数据源类型
 this.INRelaTabId = pobjViewInfoEN.INRelaTabId;// 输入数据源表ID
 this.OUTSQLDSTypeId = pobjViewInfoEN.OUTSQLDSTypeId;// 输出数据源类型
 this.OUTRelaTabId = pobjViewInfoEN.OUTRelaTabId;// 输出数据源表ID
 this.ViewFunction = pobjViewInfoEN.ViewFunction;// 界面功能
 this.ViewDetail = pobjViewInfoEN.ViewDetail;// 界面说明
 this.Memo = pobjViewInfoEN.Memo;// 说明
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
WA_ViewInfo_QUDI_JS.prototype.UpdateRecord = async function(strViewId) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = strViewId;
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.GetObjByViewId(strViewId);
var objViewInfoEN = responseText;
this.GetDataFromViewInfoClass(objViewInfoEN);
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
WA_ViewInfo_QUDI_JS.prototype.UpdateRecordSave = async function() {
this.DivName = "divUpdateRecordSave";
var objViewInfoEN = new clsViewInfoEN_js_1.clsViewInfoEN();
objViewInfoEN.ViewId = this.KeyId;
   this.PutDataToViewInfoClass(objViewInfoEN);
objViewInfoEN.sf_UpdFldSetStr = objViewInfoEN.UpdFldString;//设置哪些字段被修改(脏字段)
if (objViewInfoEN.ViewId == "" || objViewInfoEN.ViewId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.UpdateRecord(objViewInfoEN);
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
WA_ViewInfo_QUDI_JS.prototype.DelMultiRecord = async function(arrViewId) {
try
{
const responseText = await clsViewInfoWApi_js_1.clsViewInfoWApi.DelViewInfos(arrViewId);
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
  <param name = "objViewInfo">需要显示的对象</param>
*/
WA_ViewInfo_QUDI_JS.prototype.ShowViewInfoObj = function(divContainer, objViewInfo) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objViewInfo);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objViewInfo[strKey];
var li = document.createElement("li");
li.innerHTML = "" + strKey + ":" + strValue + "";
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
  <param name = "pobjViewInfoEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
WA_ViewInfo_QUDI_JS.prototype.GetFirstKey = function() {
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
WA_ViewInfo_QUDI_JS.prototype.Demo_Session = async function()
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
WA_ViewInfo_QUDI_JS.prototype.SetSession = function(Key, Value) {
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
WA_ViewInfo_QUDI_JS.prototype.GetSession = function(Key) {
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
 * 应用程序类型ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ApplicationTypeId", {
 set: function(value)
{
$("#ddlApplicationTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 应用程序类型ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ApplicationTypeId", {
    get: function()
{
return $("#ddlApplicationTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 应用程序类型ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ApplicationTypeId_q", {
    get: function()
{
return $("#ddlApplicationTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置取消按钮的标题
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "btnCancel", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "CurrPageIndex", {
    get: function()
{
return $("#hidCurrPageIndex").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 缺省菜单名
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "DefaMenuName", {
 set: function(value)
{
$("#txtDefaMenuName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 缺省菜单名
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "DefaMenuName", {
    get: function()
{
return $("#txtDefaMenuName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 添加、修改用的层名
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "DivName", {
 set: function(value)
{
$("#hidDivName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 文件名
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "FileName", {
 set: function(value)
{
$("#txtFileName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 文件名
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "FileName", {
    get: function()
{
return $("#txtFileName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 文件路径
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "FilePath", {
 set: function(value)
{
$("#txtFilePath").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 文件路径
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "FilePath", {
    get: function()
{
return $("#txtFilePath").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 功能模块Id
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "FuncModuleAgcId", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "FuncModuleAgcId", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "FuncModuleAgcId_q", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "hidSortvViewInfoBy", {
 set: function(value)
{
$("#hidSortvViewInfoBy").val(value);
},
    get: function()
{
return $("#hidSortvViewInfoBy").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 用户Id
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "hidUserId", {
    get: function()
{
return $("#hidUserId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 输入数据源表ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "INRelaTabId", {
 set: function(value)
{
$("#ddlINRelaTabId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 输入数据源表ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "INRelaTabId", {
    get: function()
{
return $("#ddlINRelaTabId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 输入数据源类型
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "INSQLDSTypeId", {
 set: function(value)
{
$("#ddlINSQLDSTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 输入数据源类型
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "INSQLDSTypeId", {
    get: function()
{
return $("#ddlINSQLDSTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否需要设置导出字段
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "IsNeedSetExportFld", {
 set: function(value)
{
$("#chkIsNeedSetExportFld").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否需要设置导出字段
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "IsNeedSetExportFld", {
    get: function()
{
return $("#chkIsNeedSetExportFld").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否使用缓存列表
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "IsUseCache4List", {
 set: function(value)
{
$("#chkIsUseCache4List").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否使用缓存列表
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "IsUseCache4List", {
    get: function()
{
return $("#chkIsUseCache4List").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置关键字的值
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "KeyId", {
    get: function()
{
return $("#hidKeyId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 主表ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "MainTabId", {
 set: function(value)
{
$("#ddlMainTabId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 主表ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "MainTabId", {
    get: function()
{
return $("#ddlMainTabId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 主表ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "MainTabId_q", {
    get: function()
{
return $("#ddlMainTabId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 说明
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "OpType", {
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
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "OpType", {
    get: function()
{
return $("#hidOpType").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 输出数据源表ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "OUTRelaTabId", {
 set: function(value)
{
$("#ddlOUTRelaTabId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 输出数据源表ID
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "OUTRelaTabId", {
    get: function()
{
return $("#ddlOUTRelaTabId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 输出数据源类型
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "OUTSQLDSTypeId", {
 set: function(value)
{
$("#ddlOUTSQLDSTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 输出数据源类型
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "OUTSQLDSTypeId", {
    get: function()
{
return $("#ddlOUTSQLDSTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 视图中文名
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewCnName", {
 set: function(value)
{
$("#txtViewCnName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 视图中文名
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewCnName", {
    get: function()
{
return $("#txtViewCnName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面说明
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewDetail", {
 set: function(value)
{
$("#txtViewDetail").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 界面说明
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewDetail", {
    get: function()
{
return $("#txtViewDetail").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面功能
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewFunction", {
 set: function(value)
{
$("#txtViewFunction").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 界面功能
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewFunction", {
    get: function()
{
return $("#txtViewFunction").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面Id
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewId", {
 set: function(value)
{
$("#txtViewId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 界面Id
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewId", {
    get: function()
{
return $("#txtViewId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面Id
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewId_q", {
    get: function()
{
return $("#txtViewId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面名称
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewName", {
 set: function(value)
{
$("#txtViewName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 界面名称
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewName", {
    get: function()
{
return $("#txtViewName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面名称
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewName_q", {
    get: function()
{
return $("#txtViewName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面类型码
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewTypeCode", {
 set: function(value)
{
$("#ddlViewTypeCode").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 界面类型码
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewTypeCode", {
    get: function()
{
return $("#ddlViewTypeCode").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面类型码
*/
Object.defineProperty(WA_ViewInfo_QUDI_JS.prototype, "ViewTypeCode_q", {
    get: function()
{
return $("#ddlViewTypeCode_q").val();
 },
 enumerable: true,
configurable: true
});
WA_ViewInfo_QUDI_JS.strPrjId_Cache = "0001";
WA_ViewInfo_QUDI_JS.bolIsLoadEditRegion = false;  //
WA_ViewInfo_QUDI_JS.divName4Edit = "divEdit";  //
return WA_ViewInfo_QUDI_JS;
}());
exports.WA_ViewInfo_QUDI_JS = WA_ViewInfo_QUDI_JS;
});