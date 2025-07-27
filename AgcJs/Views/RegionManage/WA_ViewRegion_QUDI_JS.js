
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_ViewRegion_QUDI_JS
 表名:ViewRegion(00050099)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 03:10:38
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
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
define(["require", "exports", "../../Js/L0_Entity/RegionManage/clsViewRegionEN.js","../../Js/L2_BLL/RegionManage/clsViewRegionBL.js","../../Js/L3_ForWApi/RegionManage/clsViewRegionWApi.js","clscommonfunc4web","../../Js/L2_BLL/RegionManage/clsvViewRegionBL.js","../../Js/L0_Entity/RegionManage/clsvViewRegionEN.js","../../Js/L3_ForWApi/RegionManage/clsvViewRegionWApi.js","tzdictionary","../../Js/L0_Entity/PrjInterface/clsViewInfoEN.js","../../Js/L3_ForWApi/PrjInterface/clsViewInfoWApi.js","../../Js/L0_Entity/Table_Field/clsPrjTabEN.js","../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js","../../Js/L0_Entity/PrjInterface/clsSQLDSTypeEN.js","../../Js/L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js","../../Js/L0_Entity/RegionManage/clsRegionTypeEN.js","../../Js/L3_ForWApi/RegionManage/clsRegionTypeWApi.js","../../Js/PubFun/clsPager.js","clsstacktrace","../../Js/PubFun/clsOrderByData.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsDataColumn.js","../../Js/PubFun/clsPubFun.js","../../Js/PubFun/jsString.js","../../Js/PubFun/clsCommonFunc4Web.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsViewRegionEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsViewRegionEN.js");
var clsViewRegionBL_js_1 = require("../../Js/L2_BLL/RegionManage/clsViewRegionBL.js");
var clsViewRegionWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsViewRegionWApi.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsvViewRegionBL_js_1 = require("../../Js/L2_BLL/RegionManage/clsvViewRegionBL.js");
var clsvViewRegionEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsvViewRegionEN.js");
var clsvViewRegionWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsvViewRegionWApi.js");
var Dictionary_js_1 = require("tzdictionary");
var clsViewInfoEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsViewInfoEN.js");
var clsViewInfoWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsViewInfoWApi.js");
var clsPrjTabEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsPrjTabEN.js");
var clsPrjTabWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js");
var clsSQLDSTypeEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsSQLDSTypeEN.js");
var clsSQLDSTypeWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js");
var clsRegionTypeEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsRegionTypeEN.js");
var clsRegionTypeWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsRegionTypeWApi.js");
var clsPager_js_1 = require("../../Js/PubFun/clsPager.js");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsOrderByData_js_1 = require("../../Js/PubFun/clsOrderByData.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsDataColumn_js_1 = require("../../Js/PubFun/clsDataColumn.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var jsString_js_1 = require("../../Js/PubFun/jsString.js");
var arrSelectedKeys_js_1 = require("../../Js/PubFun/clsCommonFunc4Web.js");
 /* WA_ViewRegion_QUDI_JS 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
*/
var WA_ViewRegion_QUDI_JS = /** @class */ (function() {
function WA_ViewRegion_QUDI_JS()
{
this.mstrListDiv = "divDataLst";
this.objPager = new clsPager_js_1.clsPager();
 /*
 * 每页记录数，在扩展类可以修改
*/
this.RecCount = 0;
}
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "PageSize", {
get: function() { return 5;},
enumerable: true,
configurable: true
});


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
WA_ViewRegion_QUDI_JS.AddDPV_Edit = function(divName4Edit) {
var strUrl = "./WA_ViewRegion_Edit.html";
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
WA_ViewRegion_QUDI_JS.AddDPV_Pager = function(divName4Pager) {
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
WA_ViewRegion_QUDI_JS.prototype.Page_Load = async function()
{
// 在此处放置用户代码以初始化页面
try
{
//建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvViewRegionBy = "RegionId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vViewRegion();
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
WA_ViewRegion_QUDI_JS.prototype.Page_Load_Cache = async function()
{
// 在此处放置用户代码以初始化页面
try
{
// 设置建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvViewRegionBy = "RegionId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vViewRegion_Cache();
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
WA_ViewRegion_QUDI_JS.prototype.BindDdl4EditRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();//编辑区域
 var objRegionType_Cond = new clsRegionTypeEN_js_1.clsRegionTypeEN();//编辑区域
 var objPrjTab_Cond = new clsPrjTabEN_js_1.clsPrjTabEN();//编辑区域
 var objSQLDSType_Cond = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();//编辑区域
var strPrjId = WA_ViewRegion_QUDI_JS.strPrjId_Cache;  //定义条件字段
//var strPrjId = "";//定义条件字段
const ddlViewId = await clsViewInfoWApi_js_1.clsViewInfoWApi.BindDdl_ViewId_Cache("ddlViewId", objViewInfo_Cond, strPrjId);//编辑区域
const ddlRegionTypeId = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.BindDdl_RegionTypeId_Cache("ddlRegionTypeId", objRegionType_Cond);//编辑区域
const ddlOUTRelaTabId = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlOUTRelaTabId", objPrjTab_Cond, strPrjId);//编辑区域
const ddlINSQLDSTypeId = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.BindDdl_SQLDSTypeId_Cache("ddlINSQLDSTypeId", objSQLDSType_Cond);//编辑区域
const ddlINRelaTabId = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlINRelaTabId", objPrjTab_Cond, strPrjId);//编辑区域
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
WA_ViewRegion_QUDI_JS.prototype.BindDdl4QueryRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objViewInfo_Cond = new clsViewInfoEN_js_1.clsViewInfoEN();//查询区域
 var objPrjTab_Cond = new clsPrjTabEN_js_1.clsPrjTabEN();//查询区域
 var objSQLDSType_Cond = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();//查询区域
var strPrjId_q = WA_ViewRegion_QUDI_JS.strPrjId_Cache;  //定义条件字段
//var strPrjId_q = "";//定义条件字段
const ddlViewId_q = await clsViewInfoWApi_js_1.clsViewInfoWApi.BindDdl_ViewId_Cache("ddlViewId_q", objViewInfo_Cond, strPrjId_q);//查询区域
const ddlOUTRelaTabId_q = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlOUTRelaTabId_q", objPrjTab_Cond, strPrjId_q);//查询区域
const ddlOUTSQLDSTypeId_q = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.BindDdl_SQLDSTypeId_Cache("ddlOUTSQLDSTypeId_q", objSQLDSType_Cond);//查询区域
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
*/
WA_ViewRegion_QUDI_JS.prototype.btnQuery_Click = async function(strListDiv) 
{
var strWhereCond = this.CombinevViewRegionCondition();
try
{
const responseRecCount = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: 1,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewRegionBy
};
const responseObjLst = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
var arrvViewRegionObjLst  = jsonData;
this.BindTab_vViewRegion(this.mstrListDiv, arrvViewRegionObjLst);
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
WA_ViewRegion_QUDI_JS.prototype.btnAddNewRecord_Click = async function() {
this.OpType = "Add";
try
{
if (WA_ViewRegion_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_ViewRegion_QUDI_JS.AddDPV_Edit(WA_ViewRegion_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
WA_ViewRegion_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_ViewRegion_QUDI_JS.prototype.btnAddNewRecordWithMaxId_Click = async function() {
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

 /* 设置字段值-InUse
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnSetFldValue_Click)
 */
WA_ViewRegion_QUDI_JS.prototype.btnSetInUse_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
console.log('arrKeyIds=');
console.log(arrKeyIds);
const responseText = await this.SetInUse(arrKeyIds);
const responseBindGv = await this.BindGv_vViewRegion();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "设置记录不成功," + e.responseText + ".(In btnSetInUse_Click())";
alert(strMsg);
}
}
 /* 设置字段值-InUse
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnSetFldValue_Click)
 */
WA_ViewRegion_QUDI_JS.prototype.btnSetNotInUse_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
console.log('arrKeyIds=');
console.log(arrKeyIds);
const responseText = await this.SetNotInUse(arrKeyIds);
const responseBindGv = await this.BindGv_vViewRegion();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "设置记录不成功," + e.responseText + ".(In btnSetNotInUse_Click())";
alert(strMsg);
}
}

 /*
  添加新记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnCopyRecord_Click)
 */
WA_ViewRegion_QUDI_JS.prototype.btnCopyRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vViewRegion();
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
WA_ViewRegion_QUDI_JS.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {
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
WA_ViewRegion_QUDI_JS.prototype.btnDelRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
var lngKeyId =  Number(strKeyId);
const responseText = await this.DelRecord(lngKeyId);
const responseBindGv = await this.BindGv_vViewRegion();
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
WA_ViewRegion_QUDI_JS.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {
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
WA_ViewRegion_QUDI_JS.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {
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
WA_ViewRegion_QUDI_JS.prototype.DelRecord = async function(lngRegionId) {
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.DelRecord(lngRegionId);
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
WA_ViewRegion_QUDI_JS.prototype.DetailRecord = async function(lngRegionId) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.GetObjByRegionId(lngRegionId);
var objViewRegionEN = responseText;
this.GetDataFromViewRegionClass(objViewRegionEN);
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
WA_ViewRegion_QUDI_JS.prototype.SelectRecord = async function(lngRegionId) 
{
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.GetObjByRegionId(lngRegionId);
var objViewRegionEN = responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vViewRegion");
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
WA_ViewRegion_QUDI_JS.prototype.btnUpdateRecord_Click = async function() {
this.OpType = "Update";
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (WA_ViewRegion_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_ViewRegion_QUDI_JS.AddDPV_Edit(WA_ViewRegion_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
WA_ViewRegion_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_ViewRegion_QUDI_JS.prototype.btnUnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return "";
}
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.UnDelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vViewRegion();
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
WA_ViewRegion_QUDI_JS.prototype.btnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return "";
}
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.DelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vViewRegion();
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
WA_ViewRegion_QUDI_JS.prototype.btnDelRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vViewRegion();
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
WA_ViewRegion_QUDI_JS.prototype.btnExportExcel_Click = async function() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLst(strWhereCond).then((jsonData)=>{
var arrvViewRegionObjLst  = jsonData;
this.BindTab_vViewRegion(this.mstrListDiv, arrvViewRegionObjLst);
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
WA_ViewRegion_QUDI_JS.prototype.btnOKUpd_Click = async function()
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
//this.BindGv_vViewRegion();
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
this.BindGv_vViewRegion();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool = jsonData;
var strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In WA_ViewRegion_QUDI_JS.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_vViewRegion();
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
WA_ViewRegion_QUDI_JS.prototype.CombinevViewRegionCondition = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if (this.RegionId_q != 0)
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_RegionId + " = " + this.RegionId_q + "";
}
if ( this.RegionName_q != "")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_RegionName + " like '% " + this.RegionName_q + "%'";
}
if ( this.ViewId_q != "" && this.ViewId_q != "0")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_ViewId + " = '" + this.ViewId_q + "'";
}
if ( this.RegionFunction_q != "")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_RegionFunction + " like '% " + this.RegionFunction_q + "%'";
}
if ( this.OUTRelaTabId_q != "" && this.OUTRelaTabId_q != "0")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_OUTRelaTabId + " = '" + this.OUTRelaTabId_q + "'";
}
if ( this.OUTSQLDSTypeId_q != "" && this.OUTSQLDSTypeId_q != "0")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_OUTSQLDSTypeId + " = '" + this.OUTSQLDSTypeId_q + "'";
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombineViewRegionCondition)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
WA_ViewRegion_QUDI_JS.prototype.CombinevViewRegionConditionObj = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
var objvViewRegion_Cond = new clsViewRegionEN_js_1.clsViewRegionEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if (this.RegionId_q != 0)
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_RegionId + " = " + this.RegionId_q + "";
objvViewRegion_Cond.SetCondFldValue(clsViewRegionEN_js_1.clsViewRegionEN.con_RegionId, this.RegionId_q, "=");
}
if ( this.RegionName_q != "")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_RegionName + " like '% " + this.RegionName_q + "%'";
objvViewRegion_Cond.SetCondFldValue(clsViewRegionEN_js_1.clsViewRegionEN.con_RegionName, this.RegionName_q, "like");
}
if ( this.ViewId_q != "" && this.ViewId_q != "0")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_ViewId + " = '" + this.ViewId_q + "'";
objvViewRegion_Cond.SetCondFldValue(clsViewRegionEN_js_1.clsViewRegionEN.con_ViewId, this.ViewId_q, "=");
}
if ( this.RegionFunction_q != "")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_RegionFunction + " like '% " + this.RegionFunction_q + "%'";
objvViewRegion_Cond.SetCondFldValue(clsViewRegionEN_js_1.clsViewRegionEN.con_RegionFunction, this.RegionFunction_q, "like");
}
if ( this.OUTRelaTabId_q != "" && this.OUTRelaTabId_q != "0")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_OUTRelaTabId + " = '" + this.OUTRelaTabId_q + "'";
objvViewRegion_Cond.SetCondFldValue(clsViewRegionEN_js_1.clsViewRegionEN.con_OUTRelaTabId, this.OUTRelaTabId_q, "=");
}
if ( this.OUTSQLDSTypeId_q != "" && this.OUTSQLDSTypeId_q != "0")
{
strWhereCond += " And " + clsViewRegionEN_js_1.clsViewRegionEN.con_OUTSQLDSTypeId + " = '" + this.OUTSQLDSTypeId_q + "'";
objvViewRegion_Cond.SetCondFldValue(clsViewRegionEN_js_1.clsViewRegionEN.con_OUTSQLDSTypeId, this.OUTSQLDSTypeId_q, "=");
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombineViewRegionConditionObj)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return objvViewRegion_Cond;
}

 /* 显示vViewRegion对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrViewRegionObjLst">需要绑定的对象列表</param>
*/
WA_ViewRegion_QUDI_JS.prototype.BindTab_vViewRegion = function(divContainer, arrvViewRegionObjLst) 
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
FldName: "RegionId",
ColHeader: "区域Id",
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
FldName: "INTabName",
ColHeader: "IN表",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "OUTTabName",
ColHeader: "OUT表",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "InUse",
ColHeader: "是否在用",
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
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrvViewRegionObjLst, arrDataColumn, "RegionId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.PageSize = this.PageSize;
this.objPager.ShowPager();
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
WA_ViewRegion_QUDI_JS.prototype.IndexPage = function(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.CurrPageIndex = intPageIndex;
this.BindGv_vViewRegion();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv)
*/
WA_ViewRegion_QUDI_JS.prototype.BindGv_vViewRegion = async function() 
{
var strListDiv = this.mstrListDiv;
var strWhereCond = this.CombinevViewRegionCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvViewRegionObjLst = [];
try
{
const responseRecCount = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewRegionBy
};
const responseObjLst = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
arrvViewRegionObjLst = jsonData;
});
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvViewRegionObjLst.length == 0)
{
var strMsg = "在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！";
alert(strMsg);
return;
}
try
{
this.BindTab_vViewRegion(strListDiv, arrvViewRegionObjLst);
console.log("完成BindGv_vViewRegion!");
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
WA_ViewRegion_QUDI_JS.prototype.BindGv_vViewRegion_Cache = async function() 
{
var strListDiv = this.mstrListDiv;
var objvViewRegion_Cond = this.CombinevViewRegionConditionObj();
objvViewRegion_Cond.SetCondFldValue(clsViewRegionEN_js_1.clsViewRegionEN.con_PrjId, WA_ViewRegion_QUDI_JS.strPrjId_Cache, "=");
var objvViewRegionEN_Sim = clsvViewRegionBL_js_1.clsvViewRegionBL.GetSimObjFromObj(objvViewRegion_Cond);
console.log(objvViewRegionEN_Sim);
var strWhereCond = JSON.stringify(objvViewRegionEN_Sim);
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvViewRegionObjLst = [];
try
{
this.RecCount = await  clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetRecCountByCond_Cache(objvViewRegion_Cond, WA_ViewRegion_QUDI_JS.strPrjId_Cache);
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewRegionBy
};
var arrvViewRegionObjLst = await clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByPager_Cache(objPagerPara, WA_ViewRegion_QUDI_JS.strPrjId_Cache);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvViewRegionObjLst.length == 0)
{
var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=ViewRegion_" + WA_ViewRegion_QUDI_JS.strPrjId_Cache + ")";
alert(strMsg);
return;
}
try
{
this.BindTab_vViewRegion(strListDiv, arrvViewRegionObjLst);
console.log("完成BindGv_vViewRegion!");
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
WA_ViewRegion_QUDI_JS.prototype.SortBy = async function(strSortByFld) {
if (this.hidSortvViewRegionBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvViewRegionBy.indexOf("Asc") >= 0)
{
this.hidSortvViewRegionBy = "" + strSortByFld + " Desc";
}
else
{
this.hidSortvViewRegionBy = "" + strSortByFld + " Asc";
}
}
else
{
this.hidSortvViewRegionBy = "" + strSortByFld + " Asc";
}
const responseBindGv = await this.BindGv_vViewRegion();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
*/
WA_ViewRegion_QUDI_JS.prototype.QueryvViewRegionLst = function(strListDiv) 
{
var strWhereCond = this.CombinevViewRegionCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvViewRegionBy
};
const responseText = clsvViewRegionWApi_js_1.clsvViewRegionWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
var arrvViewRegionObjLst  = jsonData;
this.BindTab_vViewRegion(strListDiv, arrvViewRegionObjLst);
console.log("完成QueryvViewRegionLst!");
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
WA_ViewRegion_QUDI_JS.prototype.Clear = function()
{
}

 /* 获取当前表关键字值的最大值,再加1,避免重复
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
*/
WA_ViewRegion_QUDI_JS.prototype.GetMaxStrId = async function(strKeyCtrlName) {
this.DivName = "divGetMaxStrId";
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表ViewRegion的最大关键字为空，不成功，请检查!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
else
{
var strInfo = "获取表ViewRegion的最大关键字为：" + returnString + "!";
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
WA_ViewRegion_QUDI_JS.prototype.AddNewRecord = async function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucViewRegionB1.RegionId = clsViewRegionBL_js_1.clsViewRegionBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
*/
WA_ViewRegion_QUDI_JS.prototype.AddNewRecordWithMaxId = function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucViewRegionB1.RegionId = clsViewRegionBL_js_1.clsViewRegionBL.GetMaxStrId_S();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
*/
WA_ViewRegion_QUDI_JS.prototype.CopyRecord = async function(arrRegionId) {
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.GetObjLstByRegionIdLst(arrRegionId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrViewRegionObjLst =  responseText;
for (let objInFor of arrViewRegionObjLst)
{
const responseText2 = await clsViewRegionWApi_js_1.clsViewRegionWApi.AddNewRecord(objInFor);
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

 /* 设置字段值-InUse
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SetFieldValue)
 */
WA_ViewRegion_QUDI_JS.prototype.SetInUse = async function(arrRegionId)
{
if (arrRegionId.length == 0)
{
let strMsg = "没有选择记录，不能设置字段值!";
alert(strMsg);
return "";
}
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.GetObjLstByRegionIdLst(arrRegionId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrViewRegionObjLst =  responseText;
for (let objInFor of arrViewRegionObjLst)
{
let objViewRegionEN = new clsViewRegionEN_js_1.clsViewRegionEN();
clsViewRegionBL_js_1.clsViewRegionBL.CopyObjTo(objInFor, objViewRegionEN);
objViewRegionEN.InUse = TransToBool("true");
var returnBool = false;
try
{
    objViewRegionEN.sf_UpdFldSetStr = objViewRegionEN.UpdFldString;//设置哪些字段被修改(脏字段)
const responseUpdate = await clsViewRegionWApi_js_1.clsViewRegionWApi.UpdateRecord(objViewRegionEN);
console.log('responseUpdate=');
console.log(responseUpdate);
returnBool = !!responseUpdate;
}
catch (e)
{
let strMsg = "修改记录出错。" + e.responseText + ". (In SetInUse())";
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
}
catch (e)
{
var strMsg = "设置记录不成功," + e+ ".(In SetInUse())";
alert(strMsg);
}
}
 /* 设置字段值-InUse
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SetFieldValue)
 */
WA_ViewRegion_QUDI_JS.prototype.SetNotInUse = async function(arrRegionId)
{
if (arrRegionId.length == 0)
{
let strMsg = "没有选择记录，不能设置字段值!";
alert(strMsg);
return "";
}
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.GetObjLstByRegionIdLst(arrRegionId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrViewRegionObjLst =  responseText;
for (let objInFor of arrViewRegionObjLst)
{
let objViewRegionEN = new clsViewRegionEN_js_1.clsViewRegionEN();
clsViewRegionBL_js_1.clsViewRegionBL.CopyObjTo(objInFor, objViewRegionEN);
objViewRegionEN.InUse = TransToBool("false");
var returnBool = false;
try
{
    objViewRegionEN.sf_UpdFldSetStr = objViewRegionEN.UpdFldString;//设置哪些字段被修改(脏字段)
const responseUpdate = await clsViewRegionWApi_js_1.clsViewRegionWApi.UpdateRecord(objViewRegionEN);
console.log('responseUpdate=');
console.log(responseUpdate);
returnBool = !!responseUpdate;
}
catch (e)
{
let strMsg = "修改记录出错。" + e.responseText + ". (In SetNotInUse())";
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
}
catch (e)
{
var strMsg = "设置记录不成功," + e+ ".(In SetNotInUse())";
alert(strMsg);
}
}

 /* 函数功能:把界面上的属性数据传到类对象中
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_PutDataToClass)
  <param name = "pobjViewRegionEN">数据传输的目的类对象</param>
*/
WA_ViewRegion_QUDI_JS.prototype.PutDataToViewRegionClass = function(pobjViewRegionEN)
{
pobjViewRegionEN.RegionName = this.RegionName;// 区域名称
pobjViewRegionEN.ViewId = this.ViewId;// 界面ID
pobjViewRegionEN.RegionTypeId = this.RegionTypeId;// 区域类型Id
pobjViewRegionEN.RegionFunction = this.RegionFunction;// 区域功能
pobjViewRegionEN.Height = this.Height;// 高度
pobjViewRegionEN.Width = this.Width;// 宽
pobjViewRegionEN.Memo = this.Memo;// 说明
pobjViewRegionEN.OUTRelaTabId = this.OUTRelaTabId;// 输出数据源表ID
pobjViewRegionEN.INSQLDSTypeId = this.INSQLDSTypeId;// 输入数据源类型
pobjViewRegionEN.INRelaTabId = this.INRelaTabId;// 输入数据源表ID
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
*/
WA_ViewRegion_QUDI_JS.prototype.AddNewRecordSave = async function(){
this.DivName = "divAddNewRecordSave";
var objViewRegionEN = new clsViewRegionEN_js_1.clsViewRegionEN();
   this.PutDataToViewRegionClass(objViewRegionEN);
try
{
const responseText2 = await clsViewRegionWApi_js_1.clsViewRegionWApi.AddNewRecord(objViewRegionEN);
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
  <param name = "lngRegionId">表记录的关键字,显示该表关键字的内容</param>
*/
WA_ViewRegion_QUDI_JS.prototype.ShowData = async function(lngRegionId) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objViewRegionEN = new clsViewRegionEN_js_1.clsViewRegionEN();
        try {
            const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.IsExist(lngRegionId);
            var returnBool = responseText;
            if (returnBool == false) {
                var strInfo = "关键字:[" + lngRegionId + "] 的记录不存在!";
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
            const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.GetObjByRegionId(lngRegionId);
            objViewRegionEN = responseText;
        }
        catch (e) {
            var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromViewRegionClass(objViewRegionEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
  <param name = "pobjViewRegionEN">表实体类对象</param>
*/
WA_ViewRegion_QUDI_JS.prototype.GetDataFromViewRegionClass = function(pobjViewRegionEN )
{
 this.RegionName = pobjViewRegionEN.RegionName;// 区域名称
 this.ViewId = pobjViewRegionEN.ViewId;// 界面ID
 this.RegionTypeId = pobjViewRegionEN.RegionTypeId;// 区域类型Id
 this.RegionFunction = pobjViewRegionEN.RegionFunction;// 区域功能
 this.Height = pobjViewRegionEN.Height;// 高度
 this.Width = pobjViewRegionEN.Width;// 宽
 this.Memo = pobjViewRegionEN.Memo;// 说明
 this.OUTRelaTabId = pobjViewRegionEN.OUTRelaTabId;// 输出数据源表ID
 this.INSQLDSTypeId = pobjViewRegionEN.INSQLDSTypeId;// 输入数据源类型
 this.INRelaTabId = pobjViewRegionEN.INRelaTabId;// 输入数据源表ID
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
WA_ViewRegion_QUDI_JS.prototype.UpdateRecord = async function(lngRegionId) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = lngRegionId.toString();
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.GetObjByRegionId(lngRegionId);
var objViewRegionEN = responseText;
this.GetDataFromViewRegionClass(objViewRegionEN);
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
WA_ViewRegion_QUDI_JS.prototype.UpdateRecordSave = async function() {
this.DivName = "divUpdateRecordSave";
var objViewRegionEN = new clsViewRegionEN_js_1.clsViewRegionEN();
objViewRegionEN.RegionId = Number(this.KeyId);
   this.PutDataToViewRegionClass(objViewRegionEN);
objViewRegionEN.sf_UpdFldSetStr = objViewRegionEN.UpdFldString;//设置哪些字段被修改(脏字段)
if (objViewRegionEN.RegionId == 0 || objViewRegionEN.RegionId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.UpdateRecord(objViewRegionEN);
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
WA_ViewRegion_QUDI_JS.prototype.DelMultiRecord = async function(arrRegionId) {
try
{
const responseText = await clsViewRegionWApi_js_1.clsViewRegionWApi.DelViewRegions(arrRegionId);
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
  <param name = "objViewRegion">需要显示的对象</param>
*/
WA_ViewRegion_QUDI_JS.prototype.ShowViewRegionObj = function(divContainer, objViewRegion) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objViewRegion);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objViewRegion[strKey];
var li = document.createElement("li");
li.innerHTML = "" + strKey + ":" + strValue + "";
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
  <param name = "pobjViewRegionEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
WA_ViewRegion_QUDI_JS.prototype.GetFirstKey = function() {
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
WA_ViewRegion_QUDI_JS.prototype.Demo_Session = async function()
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
WA_ViewRegion_QUDI_JS.prototype.SetSession = function(Key, Value) {
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
WA_ViewRegion_QUDI_JS.prototype.GetSession = function(Key) {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "btnCancel", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "DivName", {
 set: function(value)
{
$("#hidDivName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 高度
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "Height", {
 set: function(value)
{
$("#txtHeight").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 高度
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "Height", {
    get: function()
{
return $("#txtHeight").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置排序字段-相当使用ViewState功能
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "hidSortvViewRegionBy", {
 set: function(value)
{
$("#hidSortvViewRegionBy").val(value);
},
    get: function()
{
return $("#hidSortvViewRegionBy").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 用户Id
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "hidUserId", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "INRelaTabId", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "INRelaTabId", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "INSQLDSTypeId", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "INSQLDSTypeId", {
    get: function()
{
return $("#ddlINSQLDSTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置关键字的值
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "OpType", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "OpType", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "OUTRelaTabId", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "OUTRelaTabId", {
    get: function()
{
return $("#ddlOUTRelaTabId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 输出数据源表ID
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "OUTRelaTabId_q", {
    get: function()
{
return $("#ddlOUTRelaTabId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 输出数据源类型
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "OUTSQLDSTypeId_q", {
    get: function()
{
return $("#ddlOUTSQLDSTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 区域功能
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "RegionFunction", {
 set: function(value)
{
$("#txtRegionFunction").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 区域功能
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "RegionFunction", {
    get: function()
{
return $("#txtRegionFunction").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 区域功能
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "RegionFunction_q", {
    get: function()
{
return $("#txtRegionFunction_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 区域Id
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "RegionId_q", {
    get: function()
{
return $("#txtRegionId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 区域名称
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "RegionName", {
 set: function(value)
{
$("#txtRegionName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 区域名称
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "RegionName", {
    get: function()
{
return $("#txtRegionName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 区域名称
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "RegionName_q", {
    get: function()
{
return $("#txtRegionName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 区域类型Id
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "RegionTypeId", {
 set: function(value)
{
$("#ddlRegionTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 区域类型Id
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "RegionTypeId", {
    get: function()
{
return $("#ddlRegionTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 界面Id
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "ViewId", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "ViewId", {
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
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "ViewId_q", {
    get: function()
{
return $("#ddlViewId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 宽
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "Width", {
 set: function(value)
{
$("#txtWidth").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 宽
*/
Object.defineProperty(WA_ViewRegion_QUDI_JS.prototype, "Width", {
    get: function()
{
return $("#txtWidth").val();
 },
 enumerable: true,
configurable: true
});
WA_ViewRegion_QUDI_JS.strPrjId_Cache = "0001";
WA_ViewRegion_QUDI_JS.bolIsLoadEditRegion = false;  //
WA_ViewRegion_QUDI_JS.divName4Edit = "divEdit";  //
return WA_ViewRegion_QUDI_JS;
}());
exports.WA_ViewRegion_QUDI_JS = WA_ViewRegion_QUDI_JS;
});