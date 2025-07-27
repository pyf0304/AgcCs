
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_QryRegionFlds_QUDI_JS
 表名:QryRegionFlds(00050115)
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
define(["require", "exports", "../../Js/L0_Entity/RegionManage/clsQryRegionFldsEN.js","../../Js/L2_BLL/RegionManage/clsQryRegionFldsBL.js","../../Js/L3_ForWApi/RegionManage/clsQryRegionFldsWApi.js","clscommonfunc4web","../../Js/L2_BLL/RegionManage/clsvQryRegionFldsBL.js","../../Js/L0_Entity/RegionManage/clsvQryRegionFldsEN.js","../../Js/L3_ForWApi/RegionManage/clsvQryRegionFldsWApi.js","tzdictionary","../../Js/L0_Entity/SysPara/clsDataTypeAbbrEN.js","../../Js/L3_ForWApi/SysPara/clsDataTypeAbbrWApi.js","../../Js/L0_Entity/ViewControlManage/clsCtlTypeAbbrEN.js","../../Js/L3_ForWApi/ViewControlManage/clsCtlTypeAbbrWApi.js","../../Js/L0_Entity/Table_Field/clsPrjTabEN.js","../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js","../../Js/L0_Entity/PrjInterface/clsQueryOptionEN.js","../../Js/L3_ForWApi/PrjInterface/clsQueryOptionWApi.js","../../Js/L0_Entity/ViewControlManage/clsDDLItemsOptionEN.js","../../Js/L3_ForWApi/ViewControlManage/clsDDLItemsOptionWApi.js","../../Js/L0_Entity/Table_Field/clsFieldTabEN.js","../../Js/L3_ForWApi/Table_Field/clsFieldTabWApi.js","../../Js/PubFun/clsPager.js","clsstacktrace","../../Js/PubFun/clsOrderByData.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsDataColumn.js","../../Js/PubFun/clsPubFun.js","../../Js/PubFun/jsString.js","../../Js/PubFun/clsCommonFunc4Web.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsQryRegionFldsEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsQryRegionFldsEN.js");
var clsQryRegionFldsBL_js_1 = require("../../Js/L2_BLL/RegionManage/clsQryRegionFldsBL.js");
var clsQryRegionFldsWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsQryRegionFldsWApi.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsvQryRegionFldsBL_js_1 = require("../../Js/L2_BLL/RegionManage/clsvQryRegionFldsBL.js");
var clsvQryRegionFldsEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsvQryRegionFldsEN.js");
var clsvQryRegionFldsWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsvQryRegionFldsWApi.js");
var Dictionary_js_1 = require("tzdictionary");
var clsDataTypeAbbrEN_js_1 = require("../../Js/L0_Entity/SysPara/clsDataTypeAbbrEN.js");
var clsDataTypeAbbrWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsDataTypeAbbrWApi.js");
var clsCtlTypeAbbrEN_js_1 = require("../../Js/L0_Entity/ViewControlManage/clsCtlTypeAbbrEN.js");
var clsCtlTypeAbbrWApi_js_1 = require("../../Js/L3_ForWApi/ViewControlManage/clsCtlTypeAbbrWApi.js");
var clsPrjTabEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsPrjTabEN.js");
var clsPrjTabWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsPrjTabWApi.js");
var clsQueryOptionEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsQueryOptionEN.js");
var clsQueryOptionWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsQueryOptionWApi.js");
var clsDDLItemsOptionEN_js_1 = require("../../Js/L0_Entity/ViewControlManage/clsDDLItemsOptionEN.js");
var clsDDLItemsOptionWApi_js_1 = require("../../Js/L3_ForWApi/ViewControlManage/clsDDLItemsOptionWApi.js");
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
 /* WA_QryRegionFlds_QUDI_JS 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
*/
var WA_QryRegionFlds_QUDI_JS = /** @class */ (function() {
function WA_QryRegionFlds_QUDI_JS()
{
this.mstrListDiv = "divDataLst";
this.objPager = new clsPager_js_1.clsPager();
 /*
 * 每页记录数，在扩展类可以修改
*/
this.RecCount = 0;
}
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "PageSize", {
get: function() { return 5;},
enumerable: true,
configurable: true
});


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
WA_QryRegionFlds_QUDI_JS.AddDPV_Edit = function(divName4Edit) {
var strUrl = "./WA_QryRegionFlds_Edit.html";
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
WA_QryRegionFlds_QUDI_JS.AddDPV_Pager = function(divName4Pager) {
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
WA_QryRegionFlds_QUDI_JS.prototype.Page_Load = async function()
{
// 在此处放置用户代码以初始化页面
try
{
//建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvQryRegionFldsBy = "SeqNum Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vQryRegionFlds();
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
WA_QryRegionFlds_QUDI_JS.prototype.Page_Load_Cache = async function()
{
// 在此处放置用户代码以初始化页面
try
{
// 设置建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvQryRegionFldsBy = "SeqNum Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vQryRegionFlds_Cache();
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
WA_QryRegionFlds_QUDI_JS.prototype.BindDdl4EditRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objCtlTypeAbbr_Cond = new clsCtlTypeAbbrEN_js_1.clsCtlTypeAbbrEN();//编辑区域
 var objPrjTab_Cond = new clsPrjTabEN_js_1.clsPrjTabEN();//编辑区域
 var objQueryOption_Cond = new clsQueryOptionEN_js_1.clsQueryOptionEN();//编辑区域
 var objDDLItemsOption_Cond = new clsDDLItemsOptionEN_js_1.clsDDLItemsOptionEN();//编辑区域
 var objFieldTab_Cond = new clsFieldTabEN_js_1.clsFieldTabEN();//编辑区域
const ddlCtlTypeId = await clsCtlTypeAbbrWApi_js_1.clsCtlTypeAbbrWApi.BindDdl_CtlTypeId_Cache("ddlCtlTypeId", objCtlTypeAbbr_Cond);//编辑区域
var strPrjId = WA_QryRegionFlds_QUDI_JS.strPrjId_Cache;  //定义条件字段
//var strPrjId = "";//定义条件字段
const ddlDS_TabId = await clsPrjTabWApi_js_1.clsPrjTabWApi.BindDdl_TabId_Cache("ddlDS_TabId", objPrjTab_Cond, strPrjId);//编辑区域
const ddlQueryOptionId = await clsQueryOptionWApi_js_1.clsQueryOptionWApi.BindDdl_QueryOptionId_Cache("ddlQueryOptionId", objQueryOption_Cond);//编辑区域
const ddlDDLItemsOptionId = await clsDDLItemsOptionWApi_js_1.clsDDLItemsOptionWApi.BindDdl_DDLItemsOptionId_Cache("ddlDDLItemsOptionId", objDDLItemsOption_Cond);//编辑区域
const ddlDS_DataTextFieldId = await clsFieldTabWApi_js_1.clsFieldTabWApi.BindDdl_FldId_Cache("ddlDS_DataTextFieldId", objFieldTab_Cond);//编辑区域
const ddlDS_DataValueFieldId = await clsFieldTabWApi_js_1.clsFieldTabWApi.BindDdl_FldId_Cache("ddlDS_DataValueFieldId", objFieldTab_Cond);//编辑区域
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
WA_QryRegionFlds_QUDI_JS.prototype.BindDdl4QueryRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objDataTypeAbbr_Cond = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();//查询区域
 var objCtlTypeAbbr_Cond = new clsCtlTypeAbbrEN_js_1.clsCtlTypeAbbrEN();//查询区域
const ddlDataTypeId_q = await clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.BindDdl_DataTypeId_Cache("ddlDataTypeId_q", objDataTypeAbbr_Cond);//查询区域
const ddlCtlTypeId_q = await clsCtlTypeAbbrWApi_js_1.clsCtlTypeAbbrWApi.BindDdl_CtlTypeId_Cache("ddlCtlTypeId_q", objCtlTypeAbbr_Cond);//查询区域
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
*/
WA_QryRegionFlds_QUDI_JS.prototype.btnQuery_Click = async function(strListDiv) 
{
var strWhereCond = this.CombinevQryRegionFldsCondition();
try
{
const responseRecCount = await clsvQryRegionFldsWApi_js_1.clsvQryRegionFldsWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: 1,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvQryRegionFldsBy
};
const responseObjLst = await clsvQryRegionFldsWApi_js_1.clsvQryRegionFldsWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
var arrvQryRegionFldsObjLst  = jsonData;
this.BindTab_vQryRegionFlds(this.mstrListDiv, arrvQryRegionFldsObjLst);
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
WA_QryRegionFlds_QUDI_JS.prototype.btnAddNewRecord_Click = async function() {
this.OpType = "Add";
try
{
if (WA_QryRegionFlds_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_QryRegionFlds_QUDI_JS.AddDPV_Edit(WA_QryRegionFlds_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
WA_QryRegionFlds_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_QryRegionFlds_QUDI_JS.prototype.btnAddNewRecordWithMaxId_Click = async function() {
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
WA_QryRegionFlds_QUDI_JS.prototype.btnCopyRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vQryRegionFlds();
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
WA_QryRegionFlds_QUDI_JS.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {
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
WA_QryRegionFlds_QUDI_JS.prototype.btnDelRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
var lngKeyId =  Number(strKeyId);
const responseText = await this.DelRecord(lngKeyId);
const responseBindGv = await this.BindGv_vQryRegionFlds();
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
WA_QryRegionFlds_QUDI_JS.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {
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
WA_QryRegionFlds_QUDI_JS.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {
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
WA_QryRegionFlds_QUDI_JS.prototype.DelRecord = async function(lngmId) {
try
{
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.DelRecord(lngmId);
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
WA_QryRegionFlds_QUDI_JS.prototype.DetailRecord = async function(lngmId) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
try
{
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.GetObjBymId(lngmId);
var objQryRegionFldsEN = responseText;
this.GetDataFromQryRegionFldsClass(objQryRegionFldsEN);
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
WA_QryRegionFlds_QUDI_JS.prototype.SelectRecord = async function(lngmId) 
{
try
{
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.GetObjBymId(lngmId);
var objQryRegionFldsEN = responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vQryRegionFlds");
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
WA_QryRegionFlds_QUDI_JS.prototype.btnUpdateRecord_Click = async function() {
this.OpType = "Update";
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (WA_QryRegionFlds_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_QryRegionFlds_QUDI_JS.AddDPV_Edit(WA_QryRegionFlds_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
WA_QryRegionFlds_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_QryRegionFlds_QUDI_JS.prototype.btnUnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return "";
}
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.UnDelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vQryRegionFlds();
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
WA_QryRegionFlds_QUDI_JS.prototype.btnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return "";
}
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.DelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vQryRegionFlds();
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
WA_QryRegionFlds_QUDI_JS.prototype.btnDelRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vQryRegionFlds();
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
WA_QryRegionFlds_QUDI_JS.prototype.btnExportExcel_Click = async function() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await clsvQryRegionFldsWApi_js_1.clsvQryRegionFldsWApi.GetObjLst(strWhereCond).then((jsonData)=>{
var arrvQryRegionFldsObjLst  = jsonData;
this.BindTab_vQryRegionFlds(this.mstrListDiv, arrvQryRegionFldsObjLst);
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
WA_QryRegionFlds_QUDI_JS.prototype.btnOKUpd_Click = async function()
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
//this.BindGv_vQryRegionFlds();
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
this.BindGv_vQryRegionFlds();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool = jsonData;
var strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In WA_QryRegionFlds_QUDI_JS.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_vQryRegionFlds();
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
WA_QryRegionFlds_QUDI_JS.prototype.CombinevQryRegionFldsCondition = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.FldName_q != "")
{
strWhereCond += " And " + clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_FldName + " like '% " + this.FldName_q + "%'";
}
if ( this.LabelCaption_q != "")
{
strWhereCond += " And " + clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_LabelCaption + " like '% " + this.LabelCaption_q + "%'";
}
if ( this.DataTypeId_q != "" && this.DataTypeId_q != "0")
{
strWhereCond += " And " + clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_DataTypeId + " = '" + this.DataTypeId_q + "'";
}
if ( this.CtlTypeId_q != "" && this.CtlTypeId_q != "0")
{
strWhereCond += " And " + clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_CtlTypeId + " = '" + this.CtlTypeId_q + "'";
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombineQryRegionFldsCondition)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
WA_QryRegionFlds_QUDI_JS.prototype.CombinevQryRegionFldsConditionObj = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
var objvQryRegionFlds_Cond = new clsQryRegionFldsEN_js_1.clsQryRegionFldsEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.FldName_q != "")
{
strWhereCond += " And " + clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_FldName + " like '% " + this.FldName_q + "%'";
objvQryRegionFlds_Cond.SetCondFldValue(clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_FldName, this.FldName_q, "like");
}
if ( this.LabelCaption_q != "")
{
strWhereCond += " And " + clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_LabelCaption + " like '% " + this.LabelCaption_q + "%'";
objvQryRegionFlds_Cond.SetCondFldValue(clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_LabelCaption, this.LabelCaption_q, "like");
}
if ( this.DataTypeId_q != "" && this.DataTypeId_q != "0")
{
strWhereCond += " And " + clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_DataTypeId + " = '" + this.DataTypeId_q + "'";
objvQryRegionFlds_Cond.SetCondFldValue(clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_DataTypeId, this.DataTypeId_q, "=");
}
if ( this.CtlTypeId_q != "" && this.CtlTypeId_q != "0")
{
strWhereCond += " And " + clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_CtlTypeId + " = '" + this.CtlTypeId_q + "'";
objvQryRegionFlds_Cond.SetCondFldValue(clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_CtlTypeId, this.CtlTypeId_q, "=");
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombineQryRegionFldsConditionObj)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return objvQryRegionFlds_Cond;
}

 /* 显示vQryRegionFlds对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrQryRegionFldsObjLst">需要绑定的对象列表</param>
*/
WA_QryRegionFlds_QUDI_JS.prototype.BindTab_vQryRegionFlds = function(divContainer, arrvQryRegionFldsObjLst) 
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
FldName: "SeqNum",
ColHeader: "序号",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "FldName",
ColHeader: "字段名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "CtlTypeName",
ColHeader: "控件类型",
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
FldName: "InUse",
ColHeader: "在用?",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "DS_DataValueFieldName",
ColHeader: "数据源值字段",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "DS_DataTextFieldName",
ColHeader: "数据源文本字段",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "DS_TabName",
ColHeader: "数据源表",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "QueryOptionName",
ColHeader: "查询方式",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "DDLItemsOptionName",
ColHeader: "下拉选项名",
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
FldName: "UpdDate",
ColHeader: "修改日期",
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
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrvQryRegionFldsObjLst, arrDataColumn, "mId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.PageSize = this.PageSize;
this.objPager.ShowPager();
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
WA_QryRegionFlds_QUDI_JS.prototype.IndexPage = function(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.CurrPageIndex = intPageIndex;
this.BindGv_vQryRegionFlds();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv)
*/
WA_QryRegionFlds_QUDI_JS.prototype.BindGv_vQryRegionFlds = async function() 
{
var strListDiv = this.mstrListDiv;
var strWhereCond = this.CombinevQryRegionFldsCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvQryRegionFldsObjLst = [];
try
{
const responseRecCount = await clsvQryRegionFldsWApi_js_1.clsvQryRegionFldsWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvQryRegionFldsBy
};
const responseObjLst = await clsvQryRegionFldsWApi_js_1.clsvQryRegionFldsWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
arrvQryRegionFldsObjLst = jsonData;
});
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvQryRegionFldsObjLst.length == 0)
{
var strMsg = "在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！";
alert(strMsg);
return;
}
try
{
this.BindTab_vQryRegionFlds(strListDiv, arrvQryRegionFldsObjLst);
console.log("完成BindGv_vQryRegionFlds!");
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
WA_QryRegionFlds_QUDI_JS.prototype.BindGv_vQryRegionFlds_Cache = async function() 
{
var strListDiv = this.mstrListDiv;
var objvQryRegionFlds_Cond = this.CombinevQryRegionFldsConditionObj();
objvQryRegionFlds_Cond.SetCondFldValue(clsQryRegionFldsEN_js_1.clsQryRegionFldsEN.con_PrjId, WA_QryRegionFlds_QUDI_JS.strPrjId_Cache, "=");
var objvQryRegionFldsEN_Sim = clsvQryRegionFldsBL_js_1.clsvQryRegionFldsBL.GetSimObjFromObj(objvQryRegionFlds_Cond);
console.log(objvQryRegionFldsEN_Sim);
var strWhereCond = JSON.stringify(objvQryRegionFldsEN_Sim);
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvQryRegionFldsObjLst = [];
try
{
this.RecCount = await  clsvQryRegionFldsWApi_js_1.clsvQryRegionFldsWApi.GetRecCountByCond_Cache(objvQryRegionFlds_Cond, WA_QryRegionFlds_QUDI_JS.strPrjId_Cache);
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvQryRegionFldsBy
};
var arrvQryRegionFldsObjLst = await clsvQryRegionFldsWApi_js_1.clsvQryRegionFldsWApi.GetObjLstByPager_Cache(objPagerPara, WA_QryRegionFlds_QUDI_JS.strPrjId_Cache);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvQryRegionFldsObjLst.length == 0)
{
var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=QryRegionFlds_" + WA_QryRegionFlds_QUDI_JS.strPrjId_Cache + ")";
alert(strMsg);
return;
}
try
{
this.BindTab_vQryRegionFlds(strListDiv, arrvQryRegionFldsObjLst);
console.log("完成BindGv_vQryRegionFlds!");
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
WA_QryRegionFlds_QUDI_JS.prototype.SortBy = async function(strSortByFld) {
if (this.hidSortvQryRegionFldsBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvQryRegionFldsBy.indexOf("Asc") >= 0)
{
this.hidSortvQryRegionFldsBy = "" + strSortByFld + " Desc";
}
else
{
this.hidSortvQryRegionFldsBy = "" + strSortByFld + " Asc";
}
}
else
{
this.hidSortvQryRegionFldsBy = "" + strSortByFld + " Asc";
}
const responseBindGv = await this.BindGv_vQryRegionFlds();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
*/
WA_QryRegionFlds_QUDI_JS.prototype.QueryvQryRegionFldsLst = function(strListDiv) 
{
var strWhereCond = this.CombinevQryRegionFldsCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvQryRegionFldsBy
};
const responseText = clsvQryRegionFldsWApi_js_1.clsvQryRegionFldsWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
var arrvQryRegionFldsObjLst  = jsonData;
this.BindTab_vQryRegionFlds(strListDiv, arrvQryRegionFldsObjLst);
console.log("完成QueryvQryRegionFldsLst!");
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
WA_QryRegionFlds_QUDI_JS.prototype.Clear = function()
{
}

 /* 获取当前表关键字值的最大值,再加1,避免重复
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
*/
WA_QryRegionFlds_QUDI_JS.prototype.GetMaxStrId = async function(strKeyCtrlName) {
this.DivName = "divGetMaxStrId";
try
{
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表QryRegionFlds的最大关键字为空，不成功，请检查!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
else
{
var strInfo = "获取表QryRegionFlds的最大关键字为：" + returnString + "!";
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
WA_QryRegionFlds_QUDI_JS.prototype.AddNewRecord = async function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucQryRegionFldsB1.mId = clsQryRegionFldsBL_js_1.clsQryRegionFldsBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
*/
WA_QryRegionFlds_QUDI_JS.prototype.AddNewRecordWithMaxId = function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucQryRegionFldsB1.mId = clsQryRegionFldsBL_js_1.clsQryRegionFldsBL.GetMaxStrId_S();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
*/
WA_QryRegionFlds_QUDI_JS.prototype.CopyRecord = async function(arrmId) {
try
{
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.GetObjLstBymIdLst(arrmId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrQryRegionFldsObjLst =  responseText;
for (let objInFor of arrQryRegionFldsObjLst)
{
const responseText2 = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.AddNewRecord(objInFor);
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
  <param name = "pobjQryRegionFldsEN">数据传输的目的类对象</param>
*/
WA_QryRegionFlds_QUDI_JS.prototype.PutDataToQryRegionFldsClass = function(pobjQryRegionFldsEN)
{
pobjQryRegionFldsEN.RegionId = this.RegionId;// 区域Id
pobjQryRegionFldsEN.TabFldId = this.TabFldId;// 表字段ID
pobjQryRegionFldsEN.CtlTypeId = this.CtlTypeId;// 控件类型号
pobjQryRegionFldsEN.DS_TabId = this.DS_TabId;// 数据源表ID
pobjQryRegionFldsEN.QueryOptionId = this.QueryOptionId;// 查询方式Id
pobjQryRegionFldsEN.DDLItemsOptionId = this.DDLItemsOptionId;// 下拉框列表选项ID
pobjQryRegionFldsEN.DS_SQLStr = this.DS_SQLStr;// 数据源SQL串
pobjQryRegionFldsEN.DS_DataTextFieldId = this.DS_DataTextFieldId;// 数据源文本字段Id
pobjQryRegionFldsEN.DS_DataValueFieldId = this.DS_DataValueFieldId;// 数据源值字段Id
pobjQryRegionFldsEN.ItemsString = this.ItemsString;// 列表项串
pobjQryRegionFldsEN.DS_CondStr = this.DS_CondStr;// 数据源条件串
pobjQryRegionFldsEN.SeqNum = this.SeqNum;// 字段序号
pobjQryRegionFldsEN.Memo = this.Memo;// 说明
pobjQryRegionFldsEN.UpdDate = this.UpdDate;// 修改日期
pobjQryRegionFldsEN.InUse = this.InUse;// 是否在用
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
*/
WA_QryRegionFlds_QUDI_JS.prototype.AddNewRecordSave = async function(){
this.DivName = "divAddNewRecordSave";
var objQryRegionFldsEN = new clsQryRegionFldsEN_js_1.clsQryRegionFldsEN();
   this.PutDataToQryRegionFldsClass(objQryRegionFldsEN);
try
{
const responseText2 = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.AddNewRecord(objQryRegionFldsEN);
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
WA_QryRegionFlds_QUDI_JS.prototype.ShowData = async function(lngmId) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objQryRegionFldsEN = new clsQryRegionFldsEN_js_1.clsQryRegionFldsEN();
        try {
            const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.IsExist(lngmId);
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
            const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.GetObjBymId(lngmId);
            objQryRegionFldsEN = responseText;
        }
        catch (e) {
            var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromQryRegionFldsClass(objQryRegionFldsEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
  <param name = "pobjQryRegionFldsEN">表实体类对象</param>
*/
WA_QryRegionFlds_QUDI_JS.prototype.GetDataFromQryRegionFldsClass = function(pobjQryRegionFldsEN )
{
 this.RegionId = pobjQryRegionFldsEN.RegionId;// 区域Id
 this.TabFldId = pobjQryRegionFldsEN.TabFldId;// 表字段ID
 this.CtlTypeId = pobjQryRegionFldsEN.CtlTypeId;// 控件类型号
 this.DS_TabId = pobjQryRegionFldsEN.DS_TabId;// 数据源表ID
 this.QueryOptionId = pobjQryRegionFldsEN.QueryOptionId;// 查询方式Id
 this.DDLItemsOptionId = pobjQryRegionFldsEN.DDLItemsOptionId;// 下拉框列表选项ID
 this.DS_SQLStr = pobjQryRegionFldsEN.DS_SQLStr;// 数据源SQL串
 this.DS_DataTextFieldId = pobjQryRegionFldsEN.DS_DataTextFieldId;// 数据源文本字段Id
 this.DS_DataValueFieldId = pobjQryRegionFldsEN.DS_DataValueFieldId;// 数据源值字段Id
 this.ItemsString = pobjQryRegionFldsEN.ItemsString;// 列表项串
 this.DS_CondStr = pobjQryRegionFldsEN.DS_CondStr;// 数据源条件串
 this.SeqNum = pobjQryRegionFldsEN.SeqNum;// 字段序号
 this.Memo = pobjQryRegionFldsEN.Memo;// 说明
 this.UpdDate = pobjQryRegionFldsEN.UpdDate;// 修改日期
this.InUse = pobjQryRegionFldsEN.InUse;// 是否在用
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
WA_QryRegionFlds_QUDI_JS.prototype.UpdateRecord = async function(lngmId) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = lngmId.toString();
try
{
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.GetObjBymId(lngmId);
var objQryRegionFldsEN = responseText;
this.GetDataFromQryRegionFldsClass(objQryRegionFldsEN);
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
WA_QryRegionFlds_QUDI_JS.prototype.UpdateRecordSave = async function() {
this.DivName = "divUpdateRecordSave";
var objQryRegionFldsEN = new clsQryRegionFldsEN_js_1.clsQryRegionFldsEN();
objQryRegionFldsEN.mId = Number(this.KeyId);
   this.PutDataToQryRegionFldsClass(objQryRegionFldsEN);
objQryRegionFldsEN.sf_UpdFldSetStr = objQryRegionFldsEN.UpdFldString;//设置哪些字段被修改(脏字段)
if (objQryRegionFldsEN.mId == 0 || objQryRegionFldsEN.mId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.UpdateRecord(objQryRegionFldsEN);
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
WA_QryRegionFlds_QUDI_JS.prototype.DelMultiRecord = async function(arrmId) {
try
{
const responseText = await clsQryRegionFldsWApi_js_1.clsQryRegionFldsWApi.DelQryRegionFldss(arrmId);
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
  <param name = "objQryRegionFlds">需要显示的对象</param>
*/
WA_QryRegionFlds_QUDI_JS.prototype.ShowQryRegionFldsObj = function(divContainer, objQryRegionFlds) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objQryRegionFlds);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objQryRegionFlds[strKey];
var li = document.createElement("li");
li.innerHTML = "" + strKey + ":" + strValue + "";
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
  <param name = "pobjQryRegionFldsEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
WA_QryRegionFlds_QUDI_JS.prototype.GetFirstKey = function() {
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
WA_QryRegionFlds_QUDI_JS.prototype.Demo_Session = async function()
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
WA_QryRegionFlds_QUDI_JS.prototype.SetSession = function(Key, Value) {
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
WA_QryRegionFlds_QUDI_JS.prototype.GetSession = function(Key) {
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
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "btnCancel", {
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
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "btnOKUpd", {
    get: function()
{
return $("#btnOKUpd").html();
 },
 enumerable: true,
configurable: true
});
 /*
 * 控件类型号
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "CtlTypeId", {
 set: function(value)
{
$("#ddlCtlTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 控件类型号
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "CtlTypeId", {
    get: function()
{
return $("#ddlCtlTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 控件类型号
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "CtlTypeId_q", {
    get: function()
{
return $("#ddlCtlTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置当前页序号
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "CurrPageIndex", {
    get: function()
{
return $("#hidCurrPageIndex").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 数据类型Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DataTypeId_q", {
    get: function()
{
return $("#ddlDataTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 下拉框列表选项ID
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DDLItemsOptionId", {
 set: function(value)
{
$("#ddlDDLItemsOptionId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 下拉框列表选项ID
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DDLItemsOptionId", {
    get: function()
{
return $("#ddlDDLItemsOptionId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 添加、修改用的层名
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DivName", {
 set: function(value)
{
$("#hidDivName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 数据源条件串
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_CondStr", {
 set: function(value)
{
$("#txtDS_CondStr").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 数据源条件串
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_CondStr", {
    get: function()
{
return $("#txtDS_CondStr").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 数据源文本字段Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_DataTextFieldId", {
 set: function(value)
{
$("#ddlDS_DataTextFieldId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 数据源文本字段Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_DataTextFieldId", {
    get: function()
{
return $("#ddlDS_DataTextFieldId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 数据源值字段Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_DataValueFieldId", {
 set: function(value)
{
$("#ddlDS_DataValueFieldId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 数据源值字段Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_DataValueFieldId", {
    get: function()
{
return $("#ddlDS_DataValueFieldId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 数据源SQL串
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_SQLStr", {
 set: function(value)
{
$("#txtDS_SQLStr").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 数据源SQL串
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_SQLStr", {
    get: function()
{
return $("#txtDS_SQLStr").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 数据源表ID
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_TabId", {
 set: function(value)
{
$("#ddlDS_TabId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 数据源表ID
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "DS_TabId", {
    get: function()
{
return $("#ddlDS_TabId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 字段名
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "FldName_q", {
    get: function()
{
return $("#txtFldName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置排序字段-相当使用ViewState功能
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "hidSortvQryRegionFldsBy", {
 set: function(value)
{
$("#hidSortvQryRegionFldsBy").val(value);
},
    get: function()
{
return $("#hidSortvQryRegionFldsBy").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 用户Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "hidUserId", {
    get: function()
{
return $("#hidUserId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否在用
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "InUse", {
 set: function(value)
{
$("#chkInUse").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否在用
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "InUse", {
    get: function()
{
return $("#chkInUse").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 列表项串
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "ItemsString", {
 set: function(value)
{
$("#txtItemsString").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 列表项串
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "ItemsString", {
    get: function()
{
return $("#txtItemsString").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置关键字的值
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "KeyId", {
    get: function()
{
return $("#hidKeyId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 标签标题
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "LabelCaption_q", {
    get: function()
{
return $("#txtLabelCaption_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 说明
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "OpType", {
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
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "OpType", {
    get: function()
{
return $("#hidOpType").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 查询方式Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "QueryOptionId", {
 set: function(value)
{
$("#ddlQueryOptionId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 查询方式Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "QueryOptionId", {
    get: function()
{
return $("#ddlQueryOptionId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 区域Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "RegionId", {
 set: function(value)
{
$("#txtRegionId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 区域Id
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "RegionId", {
    get: function()
{
return $("#txtRegionId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 字段序号
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "SeqNum", {
 set: function(value)
{
$("#txtSeqNum").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 字段序号
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "SeqNum", {
    get: function()
{
return $("#txtSeqNum").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表字段ID
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "TabFldId", {
 set: function(value)
{
$("#txtTabFldId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 表字段ID
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "TabFldId", {
    get: function()
{
return $("#txtTabFldId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 修改日期
*/
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "UpdDate", {
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
Object.defineProperty(WA_QryRegionFlds_QUDI_JS.prototype, "UpdDate", {
    get: function()
{
return $("#txtUpdDate").val();
 },
 enumerable: true,
configurable: true
});
WA_QryRegionFlds_QUDI_JS.strPrjId_Cache = "0001";
WA_QryRegionFlds_QUDI_JS.bolIsLoadEditRegion = false;  //
WA_QryRegionFlds_QUDI_JS.divName4Edit = "divEdit";  //
return WA_QryRegionFlds_QUDI_JS;
}());
exports.WA_QryRegionFlds_QUDI_JS = WA_QryRegionFlds_QUDI_JS;
});