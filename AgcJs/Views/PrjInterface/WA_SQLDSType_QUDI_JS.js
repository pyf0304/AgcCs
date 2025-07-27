
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_SQLDSType_QUDI_JS
 表名:SQLDSType(00050014)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 03:10:41
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
define(["require", "exports", "../../Js/L0_Entity/PrjInterface/clsSQLDSTypeEN.js","../../Js/L2_BLL/PrjInterface/clsSQLDSTypeBL.js","../../Js/L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js","clscommonfunc4web","tzdictionary","../../Js/PubFun/clsPager.js","clsstacktrace","../../Js/PubFun/clsOrderByData.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsDataColumn.js","../../Js/PubFun/clsPubFun.js","../../Js/PubFun/jsString.js","../../Js/PubFun/clsCommonFunc4Web.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsSQLDSTypeEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsSQLDSTypeEN.js");
var clsSQLDSTypeBL_js_1 = require("../../Js/L2_BLL/PrjInterface/clsSQLDSTypeBL.js");
var clsSQLDSTypeWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var Dictionary_js_1 = require("tzdictionary");
var clsPager_js_1 = require("../../Js/PubFun/clsPager.js");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsOrderByData_js_1 = require("../../Js/PubFun/clsOrderByData.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsDataColumn_js_1 = require("../../Js/PubFun/clsDataColumn.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var jsString_js_1 = require("../../Js/PubFun/jsString.js");
var arrSelectedKeys_js_1 = require("../../Js/PubFun/clsCommonFunc4Web.js");
 /* WA_SQLDSType_QUDI_JS 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
*/
var WA_SQLDSType_QUDI_JS = /** @class */ (function() {
function WA_SQLDSType_QUDI_JS()
{
this.mstrListDiv = "divDataLst";
this.objPager = new clsPager_js_1.clsPager();
 /*
 * 每页记录数，在扩展类可以修改
*/
this.RecCount = 0;
}
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "PageSize", {
get: function() { return 5;},
enumerable: true,
configurable: true
});


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
WA_SQLDSType_QUDI_JS.AddDPV_Edit = function(divName4Edit) {
var strUrl = "./WA_SQLDSType_Edit.html";
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
WA_SQLDSType_QUDI_JS.AddDPV_Pager = function(divName4Pager) {
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
WA_SQLDSType_QUDI_JS.prototype.Page_Load = async function()
{
// 在此处放置用户代码以初始化页面
try
{
//建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortSQLDSTypeBy = "SQLDSTypeId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_SQLDSType();
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
WA_SQLDSType_QUDI_JS.prototype.Page_Load_Cache = async function()
{
// 在此处放置用户代码以初始化页面
try
{
// 设置建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortSQLDSTypeBy = "SQLDSTypeId Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_SQLDSType_Cache();
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
WA_SQLDSType_QUDI_JS.prototype.BindDdl4EditRegion = async function()
{
// 在此处放置用户代码以初始化页面
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
WA_SQLDSType_QUDI_JS.prototype.BindDdl4QueryRegion = async function()
{
// 在此处放置用户代码以初始化页面
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
*/
WA_SQLDSType_QUDI_JS.prototype.btnQuery_Click = async function(strListDiv) 
{
var strWhereCond = this.CombineSQLDSTypeCondition();
try
{
const responseRecCount = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: 1,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortSQLDSTypeBy
};
const responseObjLst = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
var arrSQLDSTypeObjLst  = jsonData;
this.BindTab_SQLDSType(this.mstrListDiv, arrSQLDSTypeObjLst);
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
WA_SQLDSType_QUDI_JS.prototype.btnAddNewRecord_Click = async function() {
this.OpType = "Add";
try
{
if (WA_SQLDSType_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_SQLDSType_QUDI_JS.AddDPV_Edit(WA_SQLDSType_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
WA_SQLDSType_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_SQLDSType_QUDI_JS.prototype.btnAddNewRecordWithMaxId_Click = async function() {
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
WA_SQLDSType_QUDI_JS.prototype.btnCopyRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = await this.BindGv_SQLDSType();
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
WA_SQLDSType_QUDI_JS.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {
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
WA_SQLDSType_QUDI_JS.prototype.btnDelRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelRecord(strKeyId);
const responseBindGv = await this.BindGv_SQLDSType();
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
WA_SQLDSType_QUDI_JS.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {
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
WA_SQLDSType_QUDI_JS.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {
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
WA_SQLDSType_QUDI_JS.prototype.DelRecord = async function(strSQLDSTypeId) {
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.DelRecord(strSQLDSTypeId);
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
WA_SQLDSType_QUDI_JS.prototype.DetailRecord = async function(strSQLDSTypeId) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjBySQLDSTypeId(strSQLDSTypeId);
var objSQLDSTypeEN = responseText;
this.GetDataFromSQLDSTypeClass(objSQLDSTypeEN);
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
WA_SQLDSType_QUDI_JS.prototype.SelectRecord = async function(strSQLDSTypeId) 
{
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjBySQLDSTypeId(strSQLDSTypeId);
var objSQLDSTypeEN = responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_SQLDSType");
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
WA_SQLDSType_QUDI_JS.prototype.btnUpdateRecord_Click = async function() {
this.OpType = "Update";
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (WA_SQLDSType_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_SQLDSType_QUDI_JS.AddDPV_Edit(WA_SQLDSType_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
WA_SQLDSType_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_SQLDSType_QUDI_JS.prototype.btnUnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return "";
}
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.UnDelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_SQLDSType();
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
WA_SQLDSType_QUDI_JS.prototype.btnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return "";
}
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.DelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_SQLDSType();
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
WA_SQLDSType_QUDI_JS.prototype.btnDelRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = await this.BindGv_SQLDSType();
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
WA_SQLDSType_QUDI_JS.prototype.btnExportExcel_Click = async function() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjLst(strWhereCond).then((jsonData)=>{
var arrSQLDSTypeObjLst  = jsonData;
this.BindTab_SQLDSType(this.mstrListDiv, arrSQLDSTypeObjLst);
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
WA_SQLDSType_QUDI_JS.prototype.btnOKUpd_Click = async function()
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
this.BindGv_SQLDSType();
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
this.BindGv_SQLDSType();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool = jsonData;
var strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In WA_SQLDSType_QUDI_JS.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_SQLDSType();
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
WA_SQLDSType_QUDI_JS.prototype.CombineSQLDSTypeCondition = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.SQLDSTypeId_q != "")
{
strWhereCond += " And " + clsSQLDSTypeEN_js_1.clsSQLDSTypeEN.con_SQLDSTypeId + " like '% " + this.SQLDSTypeId_q + "%'";
}
if ( this.SqlDsTypeName_q != "")
{
strWhereCond += " And " + clsSQLDSTypeEN_js_1.clsSQLDSTypeEN.con_SqlDsTypeName + " like '% " + this.SqlDsTypeName_q + "%'";
}
if ( this.SqlDsTypeENName_q != "")
{
strWhereCond += " And " + clsSQLDSTypeEN_js_1.clsSQLDSTypeEN.con_SqlDsTypeENName + " like '% " + this.SqlDsTypeENName_q + "%'";
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombineSQLDSTypeCondition)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
WA_SQLDSType_QUDI_JS.prototype.CombineSQLDSTypeConditionObj = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
var objSQLDSType_Cond = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if ( this.SQLDSTypeId_q != "")
{
strWhereCond += " And " + clsSQLDSTypeEN_js_1.clsSQLDSTypeEN.con_SQLDSTypeId + " like '% " + this.SQLDSTypeId_q + "%'";
objSQLDSType_Cond.SetCondFldValue(clsSQLDSTypeEN_js_1.clsSQLDSTypeEN.con_SQLDSTypeId, this.SQLDSTypeId_q, "like");
}
if ( this.SqlDsTypeName_q != "")
{
strWhereCond += " And " + clsSQLDSTypeEN_js_1.clsSQLDSTypeEN.con_SqlDsTypeName + " like '% " + this.SqlDsTypeName_q + "%'";
objSQLDSType_Cond.SetCondFldValue(clsSQLDSTypeEN_js_1.clsSQLDSTypeEN.con_SqlDsTypeName, this.SqlDsTypeName_q, "like");
}
if ( this.SqlDsTypeENName_q != "")
{
strWhereCond += " And " + clsSQLDSTypeEN_js_1.clsSQLDSTypeEN.con_SqlDsTypeENName + " like '% " + this.SqlDsTypeENName_q + "%'";
objSQLDSType_Cond.SetCondFldValue(clsSQLDSTypeEN_js_1.clsSQLDSTypeEN.con_SqlDsTypeENName, this.SqlDsTypeENName_q, "like");
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombineSQLDSTypeConditionObj)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return objSQLDSType_Cond;
}

 /* 显示SQLDSType对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrSQLDSTypeObjLst">需要绑定的对象列表</param>
*/
WA_SQLDSType_QUDI_JS.prototype.BindTab_SQLDSType = function(divContainer, arrSQLDSTypeObjLst) 
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
FldName: "SQLDSTypeId",
ColHeader: "数据源类型",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "SqlDsTypeName",
ColHeader: "Sql数据源名",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "SqlDsTypeENName",
ColHeader: "Sql数据源英文名",
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
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrSQLDSTypeObjLst, arrDataColumn, "SQLDSTypeId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.PageSize = this.PageSize;
this.objPager.ShowPager();
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
WA_SQLDSType_QUDI_JS.prototype.IndexPage = function(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.CurrPageIndex = intPageIndex;
this.BindGv_SQLDSType();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv)
*/
WA_SQLDSType_QUDI_JS.prototype.BindGv_SQLDSType = async function() 
{
var strListDiv = this.mstrListDiv;
var strWhereCond = this.CombineSQLDSTypeCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrSQLDSTypeObjLst = [];
try
{
const responseRecCount = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortSQLDSTypeBy
};
const responseObjLst = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
arrSQLDSTypeObjLst = jsonData;
});
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrSQLDSTypeObjLst.length == 0)
{
var strMsg = "在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！";
alert(strMsg);
return;
}
try
{
this.BindTab_SQLDSType(strListDiv, arrSQLDSTypeObjLst);
console.log("完成BindGv_SQLDSType!");
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
WA_SQLDSType_QUDI_JS.prototype.BindGv_SQLDSType_Cache = async function() 
{
var strListDiv = this.mstrListDiv;
var objSQLDSType_Cond = this.CombineSQLDSTypeConditionObj();
var objSQLDSTypeEN_Sim = clsSQLDSTypeBL_js_1.clsSQLDSTypeBL.GetSimObjFromObj(objSQLDSType_Cond);
console.log(objSQLDSTypeEN_Sim);
var strWhereCond = JSON.stringify(objSQLDSTypeEN_Sim);
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrSQLDSTypeObjLst = [];
try
{
this.RecCount = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetRecCountByCond_Cache(objSQLDSType_Cond);
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortSQLDSTypeBy
};
var arrSQLDSTypeObjLst = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjLstByPager_Cache(objPagerPara);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrSQLDSTypeObjLst.length == 0)
{
var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=SQLDSType)";
alert(strMsg);
return;
}
try
{
this.BindTab_SQLDSType(strListDiv, arrSQLDSTypeObjLst);
console.log("完成BindGv_SQLDSType!");
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
WA_SQLDSType_QUDI_JS.prototype.SortBy = async function(strSortByFld) {
if (this.hidSortSQLDSTypeBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortSQLDSTypeBy.indexOf("Asc") >= 0)
{
this.hidSortSQLDSTypeBy = "" + strSortByFld + " Desc";
}
else
{
this.hidSortSQLDSTypeBy = "" + strSortByFld + " Asc";
}
}
else
{
this.hidSortSQLDSTypeBy = "" + strSortByFld + " Asc";
}
const responseBindGv = await this.BindGv_SQLDSType();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
*/
WA_SQLDSType_QUDI_JS.prototype.QuerySQLDSTypeLst = function(strListDiv) 
{
var strWhereCond = this.CombineSQLDSTypeCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortSQLDSTypeBy
};
const responseText = clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
var arrSQLDSTypeObjLst  = jsonData;
this.BindTab_SQLDSType(strListDiv, arrSQLDSTypeObjLst);
console.log("完成QuerySQLDSTypeLst!");
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
WA_SQLDSType_QUDI_JS.prototype.SetKeyReadOnly = function(bolReadonly)
{
$('#txtSQLDSTypeId').prop['ReadOnly'] = bolReadonly;
}

/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Clear)
/// </summary>	
WA_SQLDSType_QUDI_JS.prototype.Clear = function()
{
}

 /* 获取当前表关键字值的最大值,再加1,避免重复
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
*/
WA_SQLDSType_QUDI_JS.prototype.GetMaxStrId = async function(strKeyCtrlName) {
this.DivName = "divGetMaxStrId";
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表SQLDSType的最大关键字为空，不成功，请检查!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
else
{
var strInfo = "获取表SQLDSType的最大关键字为：" + returnString + "!";
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
WA_SQLDSType_QUDI_JS.prototype.AddNewRecord = async function()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucSQLDSTypeB1.SQLDSTypeId = clsSQLDSTypeBL_js_1.clsSQLDSTypeBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
*/
WA_SQLDSType_QUDI_JS.prototype.AddNewRecordWithMaxId = function()
{
this.SetKeyReadOnly(false);
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucSQLDSTypeB1.SQLDSTypeId = clsSQLDSTypeBL_js_1.clsSQLDSTypeBL.GetMaxStrId_S();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
*/
WA_SQLDSType_QUDI_JS.prototype.CopyRecord = async function(arrSQLDSTypeId) {
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjLstBySQLDSTypeIdLst(arrSQLDSTypeId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrSQLDSTypeObjLst =  responseText;
for (let objInFor of arrSQLDSTypeObjLst)
{
const responseText2 = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.AddNewRecord(objInFor);
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
  <param name = "pobjSQLDSTypeEN">数据传输的目的类对象</param>
*/
WA_SQLDSType_QUDI_JS.prototype.PutDataToSQLDSTypeClass = function(pobjSQLDSTypeEN)
{
pobjSQLDSTypeEN.SQLDSTypeId = this.SQLDSTypeId;// 数据源类型
pobjSQLDSTypeEN.SqlDsTypeName = this.SqlDsTypeName;// Sql数据源名
pobjSQLDSTypeEN.SqlDsTypeENName = this.SqlDsTypeENName;// Sql数据源英文名
pobjSQLDSTypeEN.Memo = this.Memo;// 说明
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
*/
WA_SQLDSType_QUDI_JS.prototype.AddNewRecordSave = async function(){
this.DivName = "divAddNewRecordSave";
var objSQLDSTypeEN = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();
   this.PutDataToSQLDSTypeClass(objSQLDSTypeEN);
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.IsExist(objSQLDSTypeEN.SQLDSTypeId);
var bolIsExist = responseText;
if (bolIsExist == true)
{
var strMsg = "添加记录时，关键字：" + objSQLDSTypeEN.SQLDSTypeId + "已经存在！";
alert(strMsg);
return responseText;//一定要有一个返回值，否则会出错！
}
const responseText2 = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.AddNewRecord(objSQLDSTypeEN);
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
WA_SQLDSType_QUDI_JS.prototype.AddNewRecordWithMaxIdSave = async function(){
this.DivName = "divAddNewRecordWithMaxIdSave";
var objSQLDSTypeEN = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();
   this.PutDataToSQLDSTypeClass(objSQLDSTypeEN);
try
{
const responseText2 = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.AddNewRecordWithMaxId(objSQLDSTypeEN);
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
  <param name = "strSQLDSTypeId">表记录的关键字,显示该表关键字的内容</param>
*/
WA_SQLDSType_QUDI_JS.prototype.ShowData = async function(strSQLDSTypeId) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objSQLDSTypeEN = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();
        try {
            const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.IsExist(strSQLDSTypeId);
            var returnBool = responseText;
            if (returnBool == false) {
                var strInfo = "关键字:[" + strSQLDSTypeId + "] 的记录不存在!";
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
            const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjBySQLDSTypeId(strSQLDSTypeId);
            objSQLDSTypeEN = responseText;
        }
        catch (e) {
            var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromSQLDSTypeClass(objSQLDSTypeEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
  <param name = "pobjSQLDSTypeEN">表实体类对象</param>
*/
WA_SQLDSType_QUDI_JS.prototype.GetDataFromSQLDSTypeClass = function(pobjSQLDSTypeEN )
{
 this.SQLDSTypeId = pobjSQLDSTypeEN.SQLDSTypeId;// 数据源类型
 this.SqlDsTypeName = pobjSQLDSTypeEN.SqlDsTypeName;// Sql数据源名
 this.SqlDsTypeENName = pobjSQLDSTypeEN.SqlDsTypeENName;// Sql数据源英文名
 this.Memo = pobjSQLDSTypeEN.Memo;// 说明
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
WA_SQLDSType_QUDI_JS.prototype.UpdateRecord = async function(strSQLDSTypeId) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = strSQLDSTypeId;
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.GetObjBySQLDSTypeId(strSQLDSTypeId);
var objSQLDSTypeEN = responseText;
this.GetDataFromSQLDSTypeClass(objSQLDSTypeEN);
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
WA_SQLDSType_QUDI_JS.prototype.UpdateRecordSave = async function() {
this.DivName = "divUpdateRecordSave";
var objSQLDSTypeEN = new clsSQLDSTypeEN_js_1.clsSQLDSTypeEN();
objSQLDSTypeEN.SQLDSTypeId = this.KeyId;
   this.PutDataToSQLDSTypeClass(objSQLDSTypeEN);
objSQLDSTypeEN.sf_UpdFldSetStr = objSQLDSTypeEN.UpdFldString;//设置哪些字段被修改(脏字段)
if (objSQLDSTypeEN.SQLDSTypeId == "" || objSQLDSTypeEN.SQLDSTypeId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.UpdateRecord(objSQLDSTypeEN);
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
WA_SQLDSType_QUDI_JS.prototype.DelMultiRecord = async function(arrSQLDSTypeId) {
try
{
const responseText = await clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.DelSQLDSTypes(arrSQLDSTypeId);
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
  <param name = "objSQLDSType">需要显示的对象</param>
*/
WA_SQLDSType_QUDI_JS.prototype.ShowSQLDSTypeObj = function(divContainer, objSQLDSType) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objSQLDSType);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objSQLDSType[strKey];
var li = document.createElement("li");
li.innerHTML = "" + strKey + ":" + strValue + "";
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
  <param name = "pobjSQLDSTypeEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
WA_SQLDSType_QUDI_JS.prototype.GetFirstKey = function() {
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
WA_SQLDSType_QUDI_JS.prototype.Demo_Session = async function()
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
WA_SQLDSType_QUDI_JS.prototype.SetSession = function(Key, Value) {
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
WA_SQLDSType_QUDI_JS.prototype.GetSession = function(Key) {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "btnCancel", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "DivName", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "hidSortSQLDSTypeBy", {
 set: function(value)
{
$("#hidSortSQLDSTypeBy").val(value);
},
    get: function()
{
return $("#hidSortSQLDSTypeBy").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 用户Id
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "hidUserId", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "OpType", {
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
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "OpType", {
    get: function()
{
return $("#hidOpType").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * Sql数据源英文名
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "SqlDsTypeENName", {
 set: function(value)
{
$("#txtSqlDsTypeENName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * Sql数据源英文名
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "SqlDsTypeENName", {
    get: function()
{
return $("#txtSqlDsTypeENName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * Sql数据源英文名
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "SqlDsTypeENName_q", {
    get: function()
{
return $("#txtSqlDsTypeENName_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 数据源类型
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "SQLDSTypeId", {
 set: function(value)
{
$("#txtSQLDSTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 数据源类型
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "SQLDSTypeId", {
    get: function()
{
return $("#txtSQLDSTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 数据源类型
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "SQLDSTypeId_q", {
    get: function()
{
return $("#txtSQLDSTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * Sql数据源名
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "SqlDsTypeName", {
 set: function(value)
{
$("#txtSqlDsTypeName").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * Sql数据源名
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "SqlDsTypeName", {
    get: function()
{
return $("#txtSqlDsTypeName").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * Sql数据源名
*/
Object.defineProperty(WA_SQLDSType_QUDI_JS.prototype, "SqlDsTypeName_q", {
    get: function()
{
return $("#txtSqlDsTypeName_q").val();
 },
 enumerable: true,
configurable: true
});
WA_SQLDSType_QUDI_JS.bolIsLoadEditRegion = false;  //
WA_SQLDSType_QUDI_JS.divName4Edit = "divEdit";  //
return WA_SQLDSType_QUDI_JS;
}());
exports.WA_SQLDSType_QUDI_JS = WA_SQLDSType_QUDI_JS;
});