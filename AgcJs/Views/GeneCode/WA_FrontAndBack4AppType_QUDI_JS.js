
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_FrontAndBack4AppType_QUDI_JS
 表名:FrontAndBack4AppType(00050423)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 03:10:40
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:生成代码
 模块英文名:GeneCode
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
define(["require", "exports", "../../Js/L0_Entity/GeneCode/clsFrontAndBack4AppTypeEN.js","../../Js/L2_BLL/GeneCode/clsFrontAndBack4AppTypeBL.js","../../Js/L3_ForWApi/GeneCode/clsFrontAndBack4AppTypeWApi.js","clscommonfunc4web","../../Js/L2_BLL/GeneCode/clsvFrontAndBack4AppTypeBL.js","../../Js/L0_Entity/GeneCode/clsvFrontAndBack4AppTypeEN.js","../../Js/L3_ForWApi/GeneCode/clsvFrontAndBack4AppTypeWApi.js","tzdictionary","../../Js/L0_Entity/GeneCode/clsApplicationTypeEN.js","../../Js/L3_ForWApi/GeneCode/clsApplicationTypeWApi.js","../../Js/PubFun/clsPager.js","clsstacktrace","../../Js/PubFun/clsOrderByData.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsDataColumn.js","../../Js/PubFun/clsPubFun.js","../../Js/PubFun/jsString.js","../../Js/PubFun/clsCommonFunc4Web.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsFrontAndBack4AppTypeEN_js_1 = require("../../Js/L0_Entity/GeneCode/clsFrontAndBack4AppTypeEN.js");
var clsFrontAndBack4AppTypeBL_js_1 = require("../../Js/L2_BLL/GeneCode/clsFrontAndBack4AppTypeBL.js");
var clsFrontAndBack4AppTypeWApi_js_1 = require("../../Js/L3_ForWApi/GeneCode/clsFrontAndBack4AppTypeWApi.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsvFrontAndBack4AppTypeBL_js_1 = require("../../Js/L2_BLL/GeneCode/clsvFrontAndBack4AppTypeBL.js");
var clsvFrontAndBack4AppTypeEN_js_1 = require("../../Js/L0_Entity/GeneCode/clsvFrontAndBack4AppTypeEN.js");
var clsvFrontAndBack4AppTypeWApi_js_1 = require("../../Js/L3_ForWApi/GeneCode/clsvFrontAndBack4AppTypeWApi.js");
var Dictionary_js_1 = require("tzdictionary");
var clsApplicationTypeEN_js_1 = require("../../Js/L0_Entity/GeneCode/clsApplicationTypeEN.js");
var clsApplicationTypeWApi_js_1 = require("../../Js/L3_ForWApi/GeneCode/clsApplicationTypeWApi.js");
var clsPager_js_1 = require("../../Js/PubFun/clsPager.js");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsOrderByData_js_1 = require("../../Js/PubFun/clsOrderByData.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsDataColumn_js_1 = require("../../Js/PubFun/clsDataColumn.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var jsString_js_1 = require("../../Js/PubFun/jsString.js");
var arrSelectedKeys_js_1 = require("../../Js/PubFun/clsCommonFunc4Web.js");
 /* WA_FrontAndBack4AppType_QUDI_JS 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
*/
var WA_FrontAndBack4AppType_QUDI_JS = /** @class */ (function() {
function WA_FrontAndBack4AppType_QUDI_JS()
{
this.mstrListDiv = "divDataLst";
this.objPager = new clsPager_js_1.clsPager();
 /*
 * 每页记录数，在扩展类可以修改
*/
this.RecCount = 0;
}
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "PageSize", {
get: function() { return 5;},
enumerable: true,
configurable: true
});


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
WA_FrontAndBack4AppType_QUDI_JS.AddDPV_Edit = function(divName4Edit) {
var strUrl = "./WA_FrontAndBack4AppType_Edit.html";
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
WA_FrontAndBack4AppType_QUDI_JS.AddDPV_Pager = function(divName4Pager) {
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.Page_Load = async function()
{
// 在此处放置用户代码以初始化页面
try
{
//建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvFrontAndBack4AppTypeBy = "mId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vFrontAndBack4AppType();
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.Page_Load_Cache = async function()
{
// 在此处放置用户代码以初始化页面
try
{
// 设置建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvFrontAndBack4AppTypeBy = "mId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vFrontAndBack4AppType_Cache();
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.BindDdl4EditRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objApplicationType_Cond = new clsApplicationTypeEN_js_1.clsApplicationTypeEN();//编辑区域
var bolIsVisible = "";  //定义条件字段
//var bolIsVisible = "";//定义条件字段
const ddlAppTypeId4Front = await clsApplicationTypeWApi_js_1.clsApplicationTypeWApi.BindDdl_ApplicationTypeId_Cache("ddlAppTypeId4Front", objApplicationType_Cond, bolIsVisible);//编辑区域
const ddlAppTypeId4Back = await clsApplicationTypeWApi_js_1.clsApplicationTypeWApi.BindDdl_ApplicationTypeId_Cache("ddlAppTypeId4Back", objApplicationType_Cond, bolIsVisible);//编辑区域
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.BindDdl4QueryRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objApplicationType_Cond = new clsApplicationTypeEN_js_1.clsApplicationTypeEN();//查询区域
var bolIsVisible_q = "";  //定义条件字段
//var bolIsVisible_q = "";//定义条件字段
const ddlAppTypeId4Front_q = await clsApplicationTypeWApi_js_1.clsApplicationTypeWApi.BindDdl_ApplicationTypeId_Cache("ddlAppTypeId4Front_q", objApplicationType_Cond, bolIsVisible_q);//查询区域
const ddlAppTypeId4Back_q = await clsApplicationTypeWApi_js_1.clsApplicationTypeWApi.BindDdl_ApplicationTypeId_Cache("ddlAppTypeId4Back_q", objApplicationType_Cond, bolIsVisible_q);//查询区域
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnQuery_Click = async function(strListDiv) 
{
var strWhereCond = this.CombinevFrontAndBack4AppTypeCondition();
try
{
const responseRecCount = await clsvFrontAndBack4AppTypeWApi_js_1.clsvFrontAndBack4AppTypeWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: 1,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvFrontAndBack4AppTypeBy
};
const responseObjLst = await clsvFrontAndBack4AppTypeWApi_js_1.clsvFrontAndBack4AppTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
var arrvFrontAndBack4AppTypeObjLst  = jsonData;
this.BindTab_vFrontAndBack4AppType(this.mstrListDiv, arrvFrontAndBack4AppTypeObjLst);
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnAddNewRecord_Click = async function() {
this.OpType = "Add";
try
{
if (WA_FrontAndBack4AppType_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_FrontAndBack4AppType_QUDI_JS.AddDPV_Edit(WA_FrontAndBack4AppType_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
WA_FrontAndBack4AppType_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnAddNewRecordWithMaxId_Click = async function() {
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnCopyRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vFrontAndBack4AppType();
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnDelRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
var lngKeyId =  Number(strKeyId);
const responseText = await this.DelRecord(lngKeyId);
const responseBindGv = await this.BindGv_vFrontAndBack4AppType();
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.DelRecord = async function(lngmId) {
try
{
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.DelRecord(lngmId);
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.DetailRecord = async function(lngmId) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
try
{
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.GetObjBymId(lngmId);
var objFrontAndBack4AppTypeEN = responseText;
this.GetDataFromFrontAndBack4AppTypeClass(objFrontAndBack4AppTypeEN);
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.SelectRecord = async function(lngmId) 
{
try
{
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.GetObjBymId(lngmId);
var objFrontAndBack4AppTypeEN = responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vFrontAndBack4AppType");
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnUpdateRecord_Click = async function() {
this.OpType = "Update";
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (WA_FrontAndBack4AppType_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_FrontAndBack4AppType_QUDI_JS.AddDPV_Edit(WA_FrontAndBack4AppType_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
WA_FrontAndBack4AppType_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnUnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return "";
}
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.UnDelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vFrontAndBack4AppType();
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return "";
}
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.DelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vFrontAndBack4AppType();
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnDelRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vFrontAndBack4AppType();
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnExportExcel_Click = async function() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await clsvFrontAndBack4AppTypeWApi_js_1.clsvFrontAndBack4AppTypeWApi.GetObjLst(strWhereCond).then((jsonData)=>{
var arrvFrontAndBack4AppTypeObjLst  = jsonData;
this.BindTab_vFrontAndBack4AppType(this.mstrListDiv, arrvFrontAndBack4AppTypeObjLst);
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.btnOKUpd_Click = async function()
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
//this.BindGv_vFrontAndBack4AppType();
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
this.BindGv_vFrontAndBack4AppType();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool = jsonData;
var strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In WA_FrontAndBack4AppType_QUDI_JS.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_vFrontAndBack4AppType();
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.CombinevFrontAndBack4AppTypeCondition = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if (this.AppTypeId4Front_q != 0)
{
strWhereCond += " And " + clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN.con_AppTypeId4Front + " = " + this.AppTypeId4Front_q + "";
}
if (this.AppTypeId4Back_q != 0)
{
strWhereCond += " And " + clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN.con_AppTypeId4Back + " = " + this.AppTypeId4Back_q + "";
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombineFrontAndBack4AppTypeCondition)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.CombinevFrontAndBack4AppTypeConditionObj = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
var objvFrontAndBack4AppType_Cond = new clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if (this.AppTypeId4Front_q != 0)
{
strWhereCond += " And " + clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN.con_AppTypeId4Front + " = " + this.AppTypeId4Front_q + "";
objvFrontAndBack4AppType_Cond.SetCondFldValue(clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN.con_AppTypeId4Front, this.AppTypeId4Front_q, "=");
}
if (this.AppTypeId4Back_q != 0)
{
strWhereCond += " And " + clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN.con_AppTypeId4Back + " = " + this.AppTypeId4Back_q + "";
objvFrontAndBack4AppType_Cond.SetCondFldValue(clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN.con_AppTypeId4Back, this.AppTypeId4Back_q, "=");
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombineFrontAndBack4AppTypeConditionObj)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return objvFrontAndBack4AppType_Cond;
}

 /* 显示vFrontAndBack4AppType对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrFrontAndBack4AppTypeObjLst">需要绑定的对象列表</param>
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.BindTab_vFrontAndBack4AppType = function(divContainer, arrvFrontAndBack4AppTypeObjLst) 
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
FldName: "OrderNum",
ColHeader: "序号",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "AppTypeId4Front",
ColHeader: "应用类型Id4Front",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ApplTypeName4Front",
ColHeader: "ApplTypeName4Front",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsVisible",
ColHeader: "是否显示",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "AppTypeId4Back",
ColHeader: "应用类型Id4Back",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ApplTypeName4Back",
ColHeader: "ApplTypeName4Back",
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
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrvFrontAndBack4AppTypeObjLst, arrDataColumn, "mId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.PageSize = this.PageSize;
this.objPager.ShowPager();
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.IndexPage = function(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.CurrPageIndex = intPageIndex;
this.BindGv_vFrontAndBack4AppType();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv)
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.BindGv_vFrontAndBack4AppType = async function() 
{
var strListDiv = this.mstrListDiv;
var strWhereCond = this.CombinevFrontAndBack4AppTypeCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvFrontAndBack4AppTypeObjLst = [];
try
{
const responseRecCount = await clsvFrontAndBack4AppTypeWApi_js_1.clsvFrontAndBack4AppTypeWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvFrontAndBack4AppTypeBy
};
const responseObjLst = await clsvFrontAndBack4AppTypeWApi_js_1.clsvFrontAndBack4AppTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
arrvFrontAndBack4AppTypeObjLst = jsonData;
});
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvFrontAndBack4AppTypeObjLst.length == 0)
{
var strMsg = "在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！";
alert(strMsg);
return;
}
try
{
this.BindTab_vFrontAndBack4AppType(strListDiv, arrvFrontAndBack4AppTypeObjLst);
console.log("完成BindGv_vFrontAndBack4AppType!");
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.BindGv_vFrontAndBack4AppType_Cache = async function() 
{
var strListDiv = this.mstrListDiv;
var objvFrontAndBack4AppType_Cond = this.CombinevFrontAndBack4AppTypeConditionObj();
var objvFrontAndBack4AppTypeEN_Sim = clsvFrontAndBack4AppTypeBL_js_1.clsvFrontAndBack4AppTypeBL.GetSimObjFromObj(objvFrontAndBack4AppType_Cond);
console.log(objvFrontAndBack4AppTypeEN_Sim);
var strWhereCond = JSON.stringify(objvFrontAndBack4AppTypeEN_Sim);
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvFrontAndBack4AppTypeObjLst = [];
try
{
this.RecCount = await clsvFrontAndBack4AppTypeWApi_js_1.clsvFrontAndBack4AppTypeWApi.GetRecCountByCond_Cache(objvFrontAndBack4AppType_Cond);
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvFrontAndBack4AppTypeBy
};
var arrvFrontAndBack4AppTypeObjLst = await clsvFrontAndBack4AppTypeWApi_js_1.clsvFrontAndBack4AppTypeWApi.GetObjLstByPager_Cache(objPagerPara);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvFrontAndBack4AppTypeObjLst.length == 0)
{
var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=FrontAndBack4AppType)";
alert(strMsg);
return;
}
try
{
this.BindTab_vFrontAndBack4AppType(strListDiv, arrvFrontAndBack4AppTypeObjLst);
console.log("完成BindGv_vFrontAndBack4AppType!");
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.SortBy = async function(strSortByFld) {
if (this.hidSortvFrontAndBack4AppTypeBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvFrontAndBack4AppTypeBy.indexOf("Asc") >= 0)
{
this.hidSortvFrontAndBack4AppTypeBy = "" + strSortByFld + " Desc";
}
else
{
this.hidSortvFrontAndBack4AppTypeBy = "" + strSortByFld + " Asc";
}
}
else
{
this.hidSortvFrontAndBack4AppTypeBy = "" + strSortByFld + " Asc";
}
const responseBindGv = await this.BindGv_vFrontAndBack4AppType();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.QueryvFrontAndBack4AppTypeLst = function(strListDiv) 
{
var strWhereCond = this.CombinevFrontAndBack4AppTypeCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvFrontAndBack4AppTypeBy
};
const responseText = clsvFrontAndBack4AppTypeWApi_js_1.clsvFrontAndBack4AppTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
var arrvFrontAndBack4AppTypeObjLst  = jsonData;
this.BindTab_vFrontAndBack4AppType(strListDiv, arrvFrontAndBack4AppTypeObjLst);
console.log("完成QueryvFrontAndBack4AppTypeLst!");
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.Clear = function()
{
}

 /* 获取当前表关键字值的最大值,再加1,避免重复
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.GetMaxStrId = async function(strKeyCtrlName) {
this.DivName = "divGetMaxStrId";
try
{
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表FrontAndBack4AppType的最大关键字为空，不成功，请检查!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
else
{
var strInfo = "获取表FrontAndBack4AppType的最大关键字为：" + returnString + "!";
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.AddNewRecord = async function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucFrontAndBack4AppTypeB1.mId = clsFrontAndBack4AppTypeBL_js_1.clsFrontAndBack4AppTypeBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.AddNewRecordWithMaxId = function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucFrontAndBack4AppTypeB1.mId = clsFrontAndBack4AppTypeBL_js_1.clsFrontAndBack4AppTypeBL.GetMaxStrId_S();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.CopyRecord = async function(arrmId) {
try
{
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.GetObjLstBymIdLst(arrmId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrFrontAndBack4AppTypeObjLst =  responseText;
for (let objInFor of arrFrontAndBack4AppTypeObjLst)
{
const responseText2 = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.AddNewRecord(objInFor);
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
  <param name = "pobjFrontAndBack4AppTypeEN">数据传输的目的类对象</param>
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.PutDataToFrontAndBack4AppTypeClass = function(pobjFrontAndBack4AppTypeEN)
{
pobjFrontAndBack4AppTypeEN.AppTypeId4Front = this.AppTypeId4Front;// 应用类型Id4Front
pobjFrontAndBack4AppTypeEN.AppTypeId4Back = this.AppTypeId4Back;// 应用类型Id4Back
pobjFrontAndBack4AppTypeEN.UpdDate = this.UpdDate;// 修改日期
pobjFrontAndBack4AppTypeEN.UpdUser = this.UpdUser;// 修改者
pobjFrontAndBack4AppTypeEN.Memo = this.Memo;// 说明
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.AddNewRecordSave = async function(){
this.DivName = "divAddNewRecordSave";
var objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN();
   this.PutDataToFrontAndBack4AppTypeClass(objFrontAndBack4AppTypeEN);
try
{
const responseText2 = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.AddNewRecord(objFrontAndBack4AppTypeEN);
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.ShowData = async function(lngmId) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN();
        try {
            const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.IsExist(lngmId);
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
            const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.GetObjBymId(lngmId);
            objFrontAndBack4AppTypeEN = responseText;
        }
        catch (e) {
            var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromFrontAndBack4AppTypeClass(objFrontAndBack4AppTypeEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
  <param name = "pobjFrontAndBack4AppTypeEN">表实体类对象</param>
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.GetDataFromFrontAndBack4AppTypeClass = function(pobjFrontAndBack4AppTypeEN )
{
 this.AppTypeId4Front = pobjFrontAndBack4AppTypeEN.AppTypeId4Front;// 应用类型Id4Front
 this.AppTypeId4Back = pobjFrontAndBack4AppTypeEN.AppTypeId4Back;// 应用类型Id4Back
 this.UpdDate = pobjFrontAndBack4AppTypeEN.UpdDate;// 修改日期
 this.UpdUser = pobjFrontAndBack4AppTypeEN.UpdUser;// 修改者
 this.Memo = pobjFrontAndBack4AppTypeEN.Memo;// 说明
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.UpdateRecord = async function(lngmId) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = lngmId.toString();
try
{
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.GetObjBymId(lngmId);
var objFrontAndBack4AppTypeEN = responseText;
this.GetDataFromFrontAndBack4AppTypeClass(objFrontAndBack4AppTypeEN);
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.UpdateRecordSave = async function() {
this.DivName = "divUpdateRecordSave";
var objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN_js_1.clsFrontAndBack4AppTypeEN();
objFrontAndBack4AppTypeEN.mId = Number(this.KeyId);
   this.PutDataToFrontAndBack4AppTypeClass(objFrontAndBack4AppTypeEN);
objFrontAndBack4AppTypeEN.sf_UpdFldSetStr = objFrontAndBack4AppTypeEN.UpdFldString;//设置哪些字段被修改(脏字段)
if (objFrontAndBack4AppTypeEN.mId == 0 || objFrontAndBack4AppTypeEN.mId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.UpdateRecord(objFrontAndBack4AppTypeEN);
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.DelMultiRecord = async function(arrmId) {
try
{
const responseText = await clsFrontAndBack4AppTypeWApi_js_1.clsFrontAndBack4AppTypeWApi.DelFrontAndBack4AppTypes(arrmId);
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
  <param name = "objFrontAndBack4AppType">需要显示的对象</param>
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.ShowFrontAndBack4AppTypeObj = function(divContainer, objFrontAndBack4AppType) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objFrontAndBack4AppType);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objFrontAndBack4AppType[strKey];
var li = document.createElement("li");
li.innerHTML = "" + strKey + ":" + strValue + "";
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
  <param name = "pobjFrontAndBack4AppTypeEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
WA_FrontAndBack4AppType_QUDI_JS.prototype.GetFirstKey = function() {
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.Demo_Session = async function()
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.SetSession = function(Key, Value) {
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
WA_FrontAndBack4AppType_QUDI_JS.prototype.GetSession = function(Key) {
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
 * 应用类型Id4Back
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "AppTypeId4Back", {
 set: function(value)
{
$("#ddlAppTypeId4Back").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 应用类型Id4Back
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "AppTypeId4Back", {
    get: function()
{
return $("#ddlAppTypeId4Back").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 应用类型Id4Back
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "AppTypeId4Back_q", {
    get: function()
{
return $("#ddlAppTypeId4Back_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 应用类型Id4Front
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "AppTypeId4Front", {
 set: function(value)
{
$("#ddlAppTypeId4Front").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 应用类型Id4Front
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "AppTypeId4Front", {
    get: function()
{
return $("#ddlAppTypeId4Front").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 应用类型Id4Front
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "AppTypeId4Front_q", {
    get: function()
{
return $("#ddlAppTypeId4Front_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置取消按钮的标题
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "btnCancel", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "DivName", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "hidSortvFrontAndBack4AppTypeBy", {
 set: function(value)
{
$("#hidSortvFrontAndBack4AppTypeBy").val(value);
},
    get: function()
{
return $("#hidSortvFrontAndBack4AppTypeBy").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 用户Id
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "hidUserId", {
    get: function()
{
return $("#hidUserId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置关键字的值
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "OpType", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "OpType", {
    get: function()
{
return $("#hidOpType").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 修改日期
*/
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "UpdDate", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "UpdDate", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "UpdUser", {
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
Object.defineProperty(WA_FrontAndBack4AppType_QUDI_JS.prototype, "UpdUser", {
    get: function()
{
return $("#txtUpdUser").val();
 },
 enumerable: true,
configurable: true
});
WA_FrontAndBack4AppType_QUDI_JS.bolIsLoadEditRegion = false;  //
WA_FrontAndBack4AppType_QUDI_JS.divName4Edit = "divEdit";  //
return WA_FrontAndBack4AppType_QUDI_JS;
}());
exports.WA_FrontAndBack4AppType_QUDI_JS = WA_FrontAndBack4AppType_QUDI_JS;
});