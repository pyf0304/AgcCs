
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_CodeType_QUDI_Cache
 表名:CodeType(00050203)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 03:10:41
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
define(["require", "exports", "../../Js/L0_Entity/SysPara/clsCodeTypeEN.js","../../Js/L2_BLL/SysPara/clsCodeTypeBL.js","../../Js/L3_ForWApi/SysPara/clsCodeTypeWApi.js","clscommonfunc4web","../../Js/L2_BLL/SysPara/clsvCodeTypeBL.js","../../Js/L0_Entity/SysPara/clsvCodeTypeEN.js","../../Js/L3_ForWApi/SysPara/clsvCodeTypeWApi.js","tzdictionary","../../Js/L0_Entity/SysPara/clsProgLangTypeEN.js","../../Js/L3_ForWApi/SysPara/clsProgLangTypeWApi.js","../../Js/L0_Entity/RegionManage/clsRegionTypeEN.js","../../Js/L3_ForWApi/RegionManage/clsRegionTypeWApi.js","../../Js/L0_Entity/PrjInterface/clsSQLDSTypeEN.js","../../Js/L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js","../../Js/PubFun/clsPager.js","clsstacktrace","../../Js/PubFun/clsOrderByData.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsDataColumn.js","../../Js/PubFun/clsPubFun.js","../../Js/PubFun/jsString.js","../../Js/PubFun/clsCommonFunc4Web.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsCodeTypeEN_js_1 = require("../../Js/L0_Entity/SysPara/clsCodeTypeEN.js");
var clsCodeTypeBL_js_1 = require("../../Js/L2_BLL/SysPara/clsCodeTypeBL.js");
var clsCodeTypeWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsCodeTypeWApi.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsvCodeTypeBL_js_1 = require("../../Js/L2_BLL/SysPara/clsvCodeTypeBL.js");
var clsvCodeTypeEN_js_1 = require("../../Js/L0_Entity/SysPara/clsvCodeTypeEN.js");
var clsvCodeTypeWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsvCodeTypeWApi.js");
var Dictionary_js_1 = require("tzdictionary");
var clsProgLangTypeEN_js_1 = require("../../Js/L0_Entity/SysPara/clsProgLangTypeEN.js");
var clsProgLangTypeWApi_js_1 = require("../../Js/L3_ForWApi/SysPara/clsProgLangTypeWApi.js");
var clsRegionTypeEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsRegionTypeEN.js");
var clsRegionTypeWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsRegionTypeWApi.js");
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
 /* WA_CodeType_QUDI_Cache 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
*/
var WA_CodeType_QUDI_Cache = /** @class */ (function() {
function WA_CodeType_QUDI_Cache()
{
this.mstrListDiv = "divDataLst";
this.objPager = new clsPager_js_1.clsPager();
 /*
 * 每页记录数，在扩展类可以修改
*/
this.RecCount = 0;
}
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "PageSize", {
get: function() { return 5;},
enumerable: true,
configurable: true
});


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
WA_CodeType_QUDI_Cache.AddDPV_Edit = function(divName4Edit) {
var strUrl = "./WA_CodeType_Edit.html";
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
WA_CodeType_QUDI_Cache.AddDPV_Pager = function(divName4Pager) {
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
WA_CodeType_QUDI_Cache.prototype.Page_Load_Cache = async function()
{
// 在此处放置用户代码以初始化页面
try
{
// 设置建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvCodeTypeBy = "CodeTypeId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vCodeType_Cache();
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
WA_CodeType_QUDI_Cache.prototype.BindDdl4EditRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objProgLangType_Cond = new clsProgLangTypeEN_js_1.clsProgLangTypeEN();//编辑区域
 var objRegionType_Cond = new clsRegionTypeEN_js_1.clsRegionTypeEN();//编辑区域
var bolIsVisible = "";  //定义条件字段
//var bolIsVisible = "";//定义条件字段
const ddlProgLangTypeId = await clsProgLangTypeWApi_js_1.clsProgLangTypeWApi.BindDdl_ProgLangTypeId_Cache("ddlProgLangTypeId", objProgLangType_Cond, bolIsVisible);//编辑区域
const ddlRegionTypeId = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.BindDdl_RegionTypeId_Cache("ddlRegionTypeId", objRegionType_Cond);//编辑区域
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
WA_CodeType_QUDI_Cache.prototype.BindDdl4QueryRegion = async function()
{
// 在此处放置用户代码以初始化页面
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
*/
WA_CodeType_QUDI_Cache.prototype.btnQuery_Click = async function(strListDiv) 
{
var objvCodeType_Cond = this.CombinevCodeTypeConditionObj();
var objvCodeTypeEN_Sim = clsvCodeTypeBL_js_1.clsvCodeTypeBL.GetSimObjFromObj(objvCodeType_Cond);
console.log(objvCodeTypeEN_Sim);
var strWhereCond = JSON.stringify(objvCodeTypeEN_Sim);
try
{
this.RecCount = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetRecCountByCond_Cache(objvCodeType_Cond);
var objPagerPara = {
PageIndex: 1,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvCodeTypeBy
};
var arrvCodeTypeObjLst = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByPager_Cache(objPagerPara);
this.BindTab_vCodeType(this.mstrListDiv, arrvCodeTypeObjLst);
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
WA_CodeType_QUDI_Cache.prototype.btnAddNewRecord_Click = async function() {
this.OpType = "Add";
try
{
if (WA_CodeType_QUDI_Cache.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_CodeType_QUDI_Cache.AddDPV_Edit(WA_CodeType_QUDI_Cache.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
WA_CodeType_QUDI_Cache.bolIsLoadEditRegion = true;  //
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
WA_CodeType_QUDI_Cache.prototype.btnAddNewRecordWithMaxId_Click = async function() {
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

 /* 设置字段值-SQLDSTypeId
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnSetFldValue_Click)
 */
WA_CodeType_QUDI_Cache.prototype.btnSetSQLDSTypeId_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
let strSQLDSTypeId = $("#ddlSQLDSTypeId_SetFldValue_SetFldValue").val();
if (strSQLDSTypeId == "")
{
var strMsg = "请输入数据源类型(SQLDSTypeId)!";
alert(strMsg);
return;
}
console.log('strSQLDSTypeId=' + strSQLDSTypeId);
console.log('arrKeyIds=');
console.log(arrKeyIds);
const responseText = await this.SetSQLDSTypeId(arrKeyIds, strSQLDSTypeId);
const responseBindGv = this.BindGv_vCodeType_Cache();
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "设置记录不成功," + e.responseText + ".(In btnSetSQLDSTypeId_Click())";
alert(strMsg);
}
}

 /*
  添加新记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnCopyRecord_Click)
 */
WA_CodeType_QUDI_Cache.prototype.btnCopyRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = this.BindGv_vCodeType_Cache();
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
WA_CodeType_QUDI_Cache.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {
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
WA_CodeType_QUDI_Cache.prototype.btnDelRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelRecord(strKeyId);
const responseBindGv = this.BindGv_vCodeType_Cache();
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
WA_CodeType_QUDI_Cache.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {
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
WA_CodeType_QUDI_Cache.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {
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
WA_CodeType_QUDI_Cache.prototype.DelRecord = async function(strCodeTypeId) {
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.DelRecord(strCodeTypeId);
var returnInt = responseText;
if (returnInt > 0)
{
clsCodeTypeWApi_js_1.clsCodeTypeWApi.ReFreshCache();
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
WA_CodeType_QUDI_Cache.prototype.DetailRecord = async function(strCodeTypeId) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjByCodeTypeId(strCodeTypeId);
var objCodeTypeEN = responseText;
this.GetDataFromCodeTypeClass(objCodeTypeEN);
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
WA_CodeType_QUDI_Cache.prototype.SelectRecord = async function(strCodeTypeId) 
{
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjByCodeTypeId(strCodeTypeId);
var objCodeTypeEN = responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vCodeType");
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
WA_CodeType_QUDI_Cache.prototype.btnUpdateRecord_Click = async function() {
this.OpType = "Update";
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (WA_CodeType_QUDI_Cache.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_CodeType_QUDI_Cache.AddDPV_Edit(WA_CodeType_QUDI_Cache.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
WA_CodeType_QUDI_Cache.bolIsLoadEditRegion = true;  //
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
WA_CodeType_QUDI_Cache.prototype.btnUnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return "";
}
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.UnDelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vCodeType_Cache();
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
WA_CodeType_QUDI_Cache.prototype.btnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return "";
}
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.DelRecordBySign(arrKeyIds);
var returnInt = responseText;
if (returnInt > 0)
{
clsCodeTypeWApi_js_1.clsCodeTypeWApi.ReFreshCache();
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
const responseText2 = await this.BindGv_vCodeType_Cache();
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
WA_CodeType_QUDI_Cache.prototype.btnDelRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = this.BindGv_vCodeType_Cache();
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
WA_CodeType_QUDI_Cache.prototype.btnExportExcel_Click = async function() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLst(strWhereCond).then((jsonData)=>{
var arrvCodeTypeObjLst  = jsonData;
this.BindTab_vCodeType(this.mstrListDiv, arrvCodeTypeObjLst);
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
WA_CodeType_QUDI_Cache.prototype.btnOKUpd_Click = async function()
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
this.BindGv_vCodeType_Cache();
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
this.BindGv_vCodeType_Cache();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool = jsonData;
var strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In WA_CodeType_QUDI_Cache.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_vCodeType_Cache();
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
WA_CodeType_QUDI_Cache.prototype.CombinevCodeTypeCondition = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.CodeTypeId_q != "")
{
strWhereCond += " And " + clsCodeTypeEN_js_1.clsCodeTypeEN.con_CodeTypeId + " like '% " + this.CodeTypeId_q + "%'";
}
if ( this.CodeTypeName_q != "")
{
strWhereCond += " And " + clsCodeTypeEN_js_1.clsCodeTypeEN.con_CodeTypeName + " like '% " + this.CodeTypeName_q + "%'";
}
if ( this.CodeTypeENName_q != "")
{
strWhereCond += " And " + clsCodeTypeEN_js_1.clsCodeTypeEN.con_CodeTypeENName + " like '% " + this.CodeTypeENName_q + "%'";
}
if ( this.FrontOrBack_q != "")
{
strWhereCond += " And " + clsCodeTypeEN_js_1.clsCodeTypeEN.con_FrontOrBack + " like '% " + this.FrontOrBack_q + "%'";
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombineCodeTypeCondition)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
WA_CodeType_QUDI_Cache.prototype.CombinevCodeTypeConditionObj = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
var objvCodeType_Cond = new clsCodeTypeEN_js_1.clsCodeTypeEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.CodeTypeId_q != "")
{
strWhereCond += " And " + clsCodeTypeEN_js_1.clsCodeTypeEN.con_CodeTypeId + " like '% " + this.CodeTypeId_q + "%'";
objvCodeType_Cond.SetCondFldValue(clsCodeTypeEN_js_1.clsCodeTypeEN.con_CodeTypeId, this.CodeTypeId_q, "like");
}
if ( this.CodeTypeName_q != "")
{
strWhereCond += " And " + clsCodeTypeEN_js_1.clsCodeTypeEN.con_CodeTypeName + " like '% " + this.CodeTypeName_q + "%'";
objvCodeType_Cond.SetCondFldValue(clsCodeTypeEN_js_1.clsCodeTypeEN.con_CodeTypeName, this.CodeTypeName_q, "like");
}
if ( this.CodeTypeENName_q != "")
{
strWhereCond += " And " + clsCodeTypeEN_js_1.clsCodeTypeEN.con_CodeTypeENName + " like '% " + this.CodeTypeENName_q + "%'";
objvCodeType_Cond.SetCondFldValue(clsCodeTypeEN_js_1.clsCodeTypeEN.con_CodeTypeENName, this.CodeTypeENName_q, "like");
}
if ( this.FrontOrBack_q != "")
{
strWhereCond += " And " + clsCodeTypeEN_js_1.clsCodeTypeEN.con_FrontOrBack + " like '% " + this.FrontOrBack_q + "%'";
objvCodeType_Cond.SetCondFldValue(clsCodeTypeEN_js_1.clsCodeTypeEN.con_FrontOrBack, this.FrontOrBack_q, "like");
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombineCodeTypeConditionObj)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return objvCodeType_Cond;
}

 /* 显示vCodeType对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrCodeTypeObjLst">需要绑定的对象列表</param>
*/
WA_CodeType_QUDI_Cache.prototype.BindTab_vCodeType = function(divContainer, arrvCodeTypeObjLst) 
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
FldName: "CodeTypeId",
ColHeader: "代码类型Id",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "CodeTypeName",
ColHeader: "代码类型名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "CodeTypeENName",
ColHeader: "代码类型英文名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "FrontOrBack",
ColHeader: "前台Or后台",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsWeb",
ColHeader: "是否Web应用",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsWin",
ColHeader: "是否Win应用",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsMobileApp",
ColHeader: "是否移动终端应用",
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
FldName: "WinOrWeb",
ColHeader: "WinOrWeb",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsDefaultOverride",
ColHeader: "是否默认覆盖",
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
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrvCodeTypeObjLst, arrDataColumn, "CodeTypeId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.PageSize = this.PageSize;
this.objPager.ShowPager();
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
WA_CodeType_QUDI_Cache.prototype.IndexPage = function(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.CurrPageIndex = intPageIndex;
this.BindGv_vCodeType_Cache();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv_Cache)
*/
WA_CodeType_QUDI_Cache.prototype.BindGv_vCodeType_Cache = async function() 
{
var strListDiv = this.mstrListDiv;
var objvCodeType_Cond = this.CombinevCodeTypeConditionObj();
var objvCodeTypeEN_Sim = clsvCodeTypeBL_js_1.clsvCodeTypeBL.GetSimObjFromObj(objvCodeType_Cond);
console.log(objvCodeTypeEN_Sim);
var strWhereCond = JSON.stringify(objvCodeTypeEN_Sim);
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvCodeTypeObjLst = [];
try
{
this.RecCount = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetRecCountByCond_Cache(objvCodeType_Cond);
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvCodeTypeBy
};
var arrvCodeTypeObjLst = await clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByPager_Cache(objPagerPara);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvCodeTypeObjLst.length == 0)
{
var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=CodeType)";
alert(strMsg);
return;
}
try
{
this.BindTab_vCodeType(strListDiv, arrvCodeTypeObjLst);
console.log("完成BindGv_vCodeType!");
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
WA_CodeType_QUDI_Cache.prototype.SortBy = async function(strSortByFld) {
if (this.hidSortvCodeTypeBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvCodeTypeBy.indexOf("Asc") >= 0)
{
this.hidSortvCodeTypeBy = "" + strSortByFld + " Desc";
}
else
{
this.hidSortvCodeTypeBy = "" + strSortByFld + " Asc";
}
}
else
{
this.hidSortvCodeTypeBy = "" + strSortByFld + " Asc";
}
const responseBindGv = this.BindGv_vCodeType_Cache();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
*/
WA_CodeType_QUDI_Cache.prototype.QueryvCodeTypeLst = function(strListDiv) 
{
var strWhereCond = this.CombinevCodeTypeCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvCodeTypeBy
};
const responseText = clsvCodeTypeWApi_js_1.clsvCodeTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
var arrvCodeTypeObjLst  = jsonData;
this.BindTab_vCodeType(strListDiv, arrvCodeTypeObjLst);
console.log("完成QueryvCodeTypeLst!");
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
WA_CodeType_QUDI_Cache.prototype.SetKeyReadOnly = function(bolReadonly)
{
$('#txtCodeTypeId').prop['ReadOnly'] = bolReadonly;
}

/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Clear)
/// </summary>	
WA_CodeType_QUDI_Cache.prototype.Clear = function()
{
}

 /* 获取当前表关键字值的最大值,再加1,避免重复
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
*/
WA_CodeType_QUDI_Cache.prototype.GetMaxStrId = async function(strKeyCtrlName) {
this.DivName = "divGetMaxStrId";
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表CodeType的最大关键字为空，不成功，请检查!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
else
{
var strInfo = "获取表CodeType的最大关键字为：" + returnString + "!";
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
WA_CodeType_QUDI_Cache.prototype.AddNewRecord = async function()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucCodeTypeB1.CodeTypeId = clsCodeTypeBL_js_1.clsCodeTypeBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
*/
WA_CodeType_QUDI_Cache.prototype.AddNewRecordWithMaxId = function()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucCodeTypeB1.CodeTypeId = clsCodeTypeBL_js_1.clsCodeTypeBL.GetMaxStrId_S();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
*/
WA_CodeType_QUDI_Cache.prototype.CopyRecord = async function(arrCodeTypeId) {
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLstByCodeTypeIdLst(arrCodeTypeId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrCodeTypeObjLst =  responseText;
for (let objInFor of arrCodeTypeObjLst)
{
const responseText2 = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.AddNewRecord(objInFor);
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

 /* 设置字段值-SQLDSTypeId
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SetFieldValue)
 */
WA_CodeType_QUDI_Cache.prototype.SetSQLDSTypeId = async function(arrCodeTypeId, strSQLDSTypeId)
{
if (strSQLDSTypeId == null || strSQLDSTypeId == "" )
{
var strMsg = "请输入数据源类型(SQLDSTypeId)!";
alert(strMsg);
return "";
}
if (arrCodeTypeId.length == 0)
{
let strMsg = "没有选择记录，不能设置字段值!";
alert(strMsg);
return "";
}
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjLstByCodeTypeIdLst(arrCodeTypeId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrCodeTypeObjLst =  responseText;
for (let objInFor of arrCodeTypeObjLst)
{
let objCodeTypeEN = new clsCodeTypeEN_js_1.clsCodeTypeEN();
clsCodeTypeBL_js_1.clsCodeTypeBL.CopyObjTo(objInFor, objCodeTypeEN);
objCodeTypeEN.SQLDSTypeId = strSQLDSTypeId;
var returnBool = false;
try
{
    objCodeTypeEN.sf_UpdFldSetStr = objCodeTypeEN.UpdFldString;//设置哪些字段被修改(脏字段)
const responseUpdate = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.UpdateRecord(objCodeTypeEN);
console.log('responseUpdate=');
console.log(responseUpdate);
returnBool = !!responseUpdate;
}
catch (e)
{
let strMsg = "修改记录出错。" + e.responseText + ". (In SetSQLDSTypeId())";
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
clsCodeTypeWApi_js_1.clsCodeTypeWApi.ReFreshCache();
}
}
catch (e)
{
var strMsg = "设置记录不成功," + e+ ".(In SetSQLDSTypeId())";
alert(strMsg);
}
}

 /* 函数功能:把界面上的属性数据传到类对象中
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_PutDataToClass)
  <param name = "pobjCodeTypeEN">数据传输的目的类对象</param>
*/
WA_CodeType_QUDI_Cache.prototype.PutDataToCodeTypeClass = function(pobjCodeTypeEN)
{
pobjCodeTypeEN.CodeTypeId = this.CodeTypeId;// 代码类型Id
pobjCodeTypeEN.CodeTypeName = this.CodeTypeName;// 代码类型名
pobjCodeTypeEN.CodeTypeENName = this.CodeTypeENName;// 代码类型英文名
pobjCodeTypeEN.FrontOrBack = this.FrontOrBack;// 前台Or后台
pobjCodeTypeEN.IsWin = this.IsWin;// 是否Win应用
pobjCodeTypeEN.IsMobileApp = this.IsMobileApp;// 是否移动终端应用
pobjCodeTypeEN.OrderNum = this.OrderNum;// 序号
pobjCodeTypeEN.Memo = this.Memo;// 说明
pobjCodeTypeEN.IsDefaultOverride = this.IsDefaultOverride;// 是否默认覆盖
pobjCodeTypeEN.WinOrWeb = this.WinOrWeb;// WinOrWeb
pobjCodeTypeEN.CodeTypeSimName = this.CodeTypeSimName;// 简称
pobjCodeTypeEN.GroupName = this.GroupName;// 组名
pobjCodeTypeEN.ProgLangTypeId = this.ProgLangTypeId;// 编程语言类型Id
pobjCodeTypeEN.RegionTypeId = this.RegionTypeId;// 区域类型Id
pobjCodeTypeEN.Prefix = this.Prefix;// 前缀
pobjCodeTypeEN.DependsOn = this.DependsOn;// 依赖于
pobjCodeTypeEN.ClassNameFormat = this.ClassNameFormat;// 类名格式
pobjCodeTypeEN.IsTableFldConst = this.IsTableFldConst;// IsTableFldConst
pobjCodeTypeEN.IsPubApp4WinWeb = this.IsPubApp4WinWeb;// IsPubApp4WinWeb
pobjCodeTypeEN.IsAspMvc = this.IsAspMvc;// 是否AspMvc
pobjCodeTypeEN.IsWebSrvAccess = this.IsWebSrvAccess;// IsWebSrvAccess
pobjCodeTypeEN.IsDirByTabName = this.IsDirByTabName;// 是否用表名作为路径
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
*/
WA_CodeType_QUDI_Cache.prototype.AddNewRecordSave = async function(){
this.DivName = "divAddNewRecordSave";
var objCodeTypeEN = new clsCodeTypeEN_js_1.clsCodeTypeEN();
   this.PutDataToCodeTypeClass(objCodeTypeEN);
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.IsExist(objCodeTypeEN.CodeTypeId);
var bolIsExist = responseText;
if (bolIsExist == true)
{
var strMsg = "添加记录时，关键字：" + objCodeTypeEN.CodeTypeId + "已经存在！";
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.AddNewRecord(objCodeTypeEN);
var returnBool = !!responseText2;
if (returnBool == true)
{
clsCodeTypeWApi_js_1.clsCodeTypeWApi.ReFreshCache();
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
WA_CodeType_QUDI_Cache.prototype.AddNewRecordWithMaxIdSave = async function(){
this.DivName = "divAddNewRecordWithMaxIdSave";
var objCodeTypeEN = new clsCodeTypeEN_js_1.clsCodeTypeEN();
   this.PutDataToCodeTypeClass(objCodeTypeEN);
try
{
const responseText2 = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.AddNewRecordWithMaxId(objCodeTypeEN);
var returnBool = !!responseText2;
if (returnBool == true)
{
clsCodeTypeWApi_js_1.clsCodeTypeWApi.ReFreshCache();
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
  <param name = "strCodeTypeId">表记录的关键字,显示该表关键字的内容</param>
*/
WA_CodeType_QUDI_Cache.prototype.ShowData = async function(strCodeTypeId) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objCodeTypeEN = new clsCodeTypeEN_js_1.clsCodeTypeEN();
        try {
            const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.IsExist(strCodeTypeId);
            var returnBool = responseText;
            if (returnBool == false) {
                var strInfo = "关键字:[" + strCodeTypeId + "] 的记录不存在!";
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
            const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjByCodeTypeId(strCodeTypeId);
            objCodeTypeEN = responseText;
        }
        catch (e) {
            var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromCodeTypeClass(objCodeTypeEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
  <param name = "pobjCodeTypeEN">表实体类对象</param>
*/
WA_CodeType_QUDI_Cache.prototype.GetDataFromCodeTypeClass = function(pobjCodeTypeEN )
{
 this.CodeTypeId = pobjCodeTypeEN.CodeTypeId;// 代码类型Id
 this.CodeTypeName = pobjCodeTypeEN.CodeTypeName;// 代码类型名
 this.CodeTypeENName = pobjCodeTypeEN.CodeTypeENName;// 代码类型英文名
 this.FrontOrBack = pobjCodeTypeEN.FrontOrBack;// 前台Or后台
this.IsWin = pobjCodeTypeEN.IsWin;// 是否Win应用
this.IsMobileApp = pobjCodeTypeEN.IsMobileApp;// 是否移动终端应用
 this.OrderNum = pobjCodeTypeEN.OrderNum;// 序号
 this.Memo = pobjCodeTypeEN.Memo;// 说明
this.IsDefaultOverride = pobjCodeTypeEN.IsDefaultOverride;// 是否默认覆盖
 this.WinOrWeb = pobjCodeTypeEN.WinOrWeb;// WinOrWeb
 this.CodeTypeSimName = pobjCodeTypeEN.CodeTypeSimName;// 简称
 this.GroupName = pobjCodeTypeEN.GroupName;// 组名
 this.ProgLangTypeId = pobjCodeTypeEN.ProgLangTypeId;// 编程语言类型Id
 this.RegionTypeId = pobjCodeTypeEN.RegionTypeId;// 区域类型Id
 this.Prefix = pobjCodeTypeEN.Prefix;// 前缀
 this.DependsOn = pobjCodeTypeEN.DependsOn;// 依赖于
 this.ClassNameFormat = pobjCodeTypeEN.ClassNameFormat;// 类名格式
this.IsTableFldConst = pobjCodeTypeEN.IsTableFldConst;// IsTableFldConst
this.IsPubApp4WinWeb = pobjCodeTypeEN.IsPubApp4WinWeb;// IsPubApp4WinWeb
this.IsAspMvc = pobjCodeTypeEN.IsAspMvc;// 是否AspMvc
this.IsWebSrvAccess = pobjCodeTypeEN.IsWebSrvAccess;// IsWebSrvAccess
this.IsDirByTabName = pobjCodeTypeEN.IsDirByTabName;// 是否用表名作为路径
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
WA_CodeType_QUDI_Cache.prototype.UpdateRecord = async function(strCodeTypeId) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = strCodeTypeId;
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.GetObjByCodeTypeId(strCodeTypeId);
var objCodeTypeEN = responseText;
this.GetDataFromCodeTypeClass(objCodeTypeEN);
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
WA_CodeType_QUDI_Cache.prototype.UpdateRecordSave = async function() {
this.DivName = "divUpdateRecordSave";
var objCodeTypeEN = new clsCodeTypeEN_js_1.clsCodeTypeEN();
objCodeTypeEN.CodeTypeId = this.KeyId;
   this.PutDataToCodeTypeClass(objCodeTypeEN);
objCodeTypeEN.sf_UpdFldSetStr = objCodeTypeEN.UpdFldString;//设置哪些字段被修改(脏字段)
if (objCodeTypeEN.CodeTypeId == "" || objCodeTypeEN.CodeTypeId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.UpdateRecord(objCodeTypeEN);
var returnBool = !!responseText;
if (returnBool == true)
{
clsCodeTypeWApi_js_1.clsCodeTypeWApi.ReFreshCache();
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
WA_CodeType_QUDI_Cache.prototype.DelMultiRecord = async function(arrCodeTypeId) {
try
{
const responseText = await clsCodeTypeWApi_js_1.clsCodeTypeWApi.DelCodeTypes(arrCodeTypeId);
var returnInt = responseText;
if (returnInt > 0)
{
clsCodeTypeWApi_js_1.clsCodeTypeWApi.ReFreshCache();
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
  <param name = "objCodeType">需要显示的对象</param>
*/
WA_CodeType_QUDI_Cache.prototype.ShowCodeTypeObj = function(divContainer, objCodeType) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objCodeType);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objCodeType[strKey];
var li = document.createElement("li");
li.innerHTML = "" + strKey + ":" + strValue + "";
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
  <param name = "pobjCodeTypeEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
WA_CodeType_QUDI_Cache.prototype.GetFirstKey = function() {
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
WA_CodeType_QUDI_Cache.prototype.Demo_Session = async function()
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
WA_CodeType_QUDI_Cache.prototype.SetSession = function(Key, Value) {
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
WA_CodeType_QUDI_Cache.prototype.GetSession = function(Key) {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "btnCancel", {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "btnOKUpd", {
    get: function()
{
return $("#btnOKUpd").html();
 },
 enumerable: true,
configurable: true
});
 /*
 * 类名格式
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "ClassNameFormat", {
 set: function(value)
{
$("#txtClassNameFormat").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 类名格式
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "ClassNameFormat", {
    get: function()
{
return $("#txtClassNameFormat").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 代码类型英文名
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeENName", {
 set: function(value)
{
$("#txtCodeTypeENName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 代码类型英文名
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeENName", {
    get: function()
{
return $("#txtCodeTypeENName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 代码类型英文名
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeENName_q", {
    get: function()
{
return $("#txtCodeTypeENName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 代码类型Id
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeId", {
 set: function(value)
{
$("#txtCodeTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 代码类型Id
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeId", {
    get: function()
{
return $("#txtCodeTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 代码类型Id
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeId_q", {
    get: function()
{
return $("#txtCodeTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 代码类型名
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeName", {
 set: function(value)
{
$("#txtCodeTypeName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 代码类型名
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeName", {
    get: function()
{
return $("#txtCodeTypeName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 代码类型名
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeName_q", {
    get: function()
{
return $("#txtCodeTypeName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 简称
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeSimName", {
 set: function(value)
{
$("#txtCodeTypeSimName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 简称
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CodeTypeSimName", {
    get: function()
{
return $("#txtCodeTypeSimName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置当前页序号
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "CurrPageIndex", {
    get: function()
{
return $("#hidCurrPageIndex").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 依赖于
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "DependsOn", {
 set: function(value)
{
$("#txtDependsOn").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 依赖于
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "DependsOn", {
    get: function()
{
return $("#txtDependsOn").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 添加、修改用的层名
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "DivName", {
 set: function(value)
{
$("#hidDivName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 前台Or后台
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "FrontOrBack", {
 set: function(value)
{
$("#txtFrontOrBack").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 前台Or后台
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "FrontOrBack", {
    get: function()
{
return $("#txtFrontOrBack").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 前台Or后台
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "FrontOrBack_q", {
    get: function()
{
return $("#txtFrontOrBack_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 组名
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "GroupName", {
 set: function(value)
{
$("#txtGroupName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 组名
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "GroupName", {
    get: function()
{
return $("#txtGroupName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置排序字段-相当使用ViewState功能
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "hidSortvCodeTypeBy", {
 set: function(value)
{
$("#hidSortvCodeTypeBy").val(value);
},
    get: function()
{
return $("#hidSortvCodeTypeBy").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 用户Id
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "hidUserId", {
    get: function()
{
return $("#hidUserId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否AspMvc
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsAspMvc", {
 set: function(value)
{
$("#chkIsAspMvc").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否AspMvc
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsAspMvc", {
    get: function()
{
return $("#chkIsAspMvc").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否默认覆盖
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsDefaultOverride", {
 set: function(value)
{
$("#chkIsDefaultOverride").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否默认覆盖
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsDefaultOverride", {
    get: function()
{
return $("#chkIsDefaultOverride").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否用表名作为路径
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsDirByTabName", {
 set: function(value)
{
$("#chkIsDirByTabName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否用表名作为路径
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsDirByTabName", {
    get: function()
{
return $("#chkIsDirByTabName").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否移动终端应用
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsMobileApp", {
 set: function(value)
{
$("#chkIsMobileApp").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否移动终端应用
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsMobileApp", {
    get: function()
{
return $("#chkIsMobileApp").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * IsPubApp4WinWeb
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsPubApp4WinWeb", {
 set: function(value)
{
$("#chkIsPubApp4WinWeb").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * IsPubApp4WinWeb
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsPubApp4WinWeb", {
    get: function()
{
return $("#chkIsPubApp4WinWeb").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * IsTableFldConst
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsTableFldConst", {
 set: function(value)
{
$("#chkIsTableFldConst").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * IsTableFldConst
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsTableFldConst", {
    get: function()
{
return $("#chkIsTableFldConst").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * IsWebSrvAccess
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsWebSrvAccess", {
 set: function(value)
{
$("#chkIsWebSrvAccess").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * IsWebSrvAccess
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsWebSrvAccess", {
    get: function()
{
return $("#chkIsWebSrvAccess").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否Win应用
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsWin", {
 set: function(value)
{
$("#chkIsWin").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否Win应用
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "IsWin", {
    get: function()
{
return $("#chkIsWin").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置关键字的值
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "KeyId", {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "KeyId", {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "Memo", {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "Memo", {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "OpType", {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "OpType", {
    get: function()
{
return $("#hidOpType").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 序号
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "OrderNum", {
 set: function(value)
{
$("#txtOrderNum").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 序号
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "OrderNum", {
    get: function()
{
return $("#txtOrderNum").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 前缀
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "Prefix", {
 set: function(value)
{
$("#txtPrefix").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 前缀
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "Prefix", {
    get: function()
{
return $("#txtPrefix").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 编程语言类型Id
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "ProgLangTypeId", {
 set: function(value)
{
$("#ddlProgLangTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 编程语言类型Id
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "ProgLangTypeId", {
    get: function()
{
return $("#ddlProgLangTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 区域类型Id
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "RegionTypeId", {
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
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "RegionTypeId", {
    get: function()
{
return $("#ddlRegionTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * WinOrWeb
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "WinOrWeb", {
 set: function(value)
{
$("#txtWinOrWeb").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * WinOrWeb
*/
Object.defineProperty(WA_CodeType_QUDI_Cache.prototype, "WinOrWeb", {
    get: function()
{
return $("#txtWinOrWeb").val();
 },
 enumerable: true,
configurable: true
});
WA_CodeType_QUDI_Cache.bolIsLoadEditRegion = false;  //
WA_CodeType_QUDI_Cache.divName4Edit = "divEdit";  //
return WA_CodeType_QUDI_Cache;
}());
exports.WA_CodeType_QUDI_Cache = WA_CodeType_QUDI_Cache;
});