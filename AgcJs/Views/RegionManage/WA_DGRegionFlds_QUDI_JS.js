
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WA_DGRegionFlds_QUDI_JS
 表名:DGRegionFlds(00050113)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 03:10:39
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
define(["require", "exports", "../../Js/L0_Entity/RegionManage/clsDGRegionFldsEN.js","../../Js/L2_BLL/RegionManage/clsDGRegionFldsBL.js","../../Js/L3_ForWApi/RegionManage/clsDGRegionFldsWApi.js","clscommonfunc4web","../../Js/L2_BLL/RegionManage/clsvDGRegionFldsBL.js","../../Js/L0_Entity/RegionManage/clsvDGRegionFldsEN.js","../../Js/L3_ForWApi/RegionManage/clsvDGRegionFldsWApi.js","tzdictionary","../../Js/L0_Entity/PrjInterface/clsDgFuncTypeEN.js","../../Js/L3_ForWApi/PrjInterface/clsDgFuncTypeWApi.js","../../Js/L0_Entity/ViewControlManage/clsCtlTypeAbbrEN.js","../../Js/L3_ForWApi/ViewControlManage/clsCtlTypeAbbrWApi.js","../../Js/PubFun/clsPager.js","clsstacktrace","../../Js/PubFun/clsOrderByData.js","../../Js/PubFun/stuPagerPara.js","../../Js/PubFun/clsDataColumn.js","../../Js/PubFun/clsPubFun.js","../../Js/PubFun/jsString.js","../../Js/PubFun/clsCommonFunc4Web.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var clsDGRegionFldsEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsDGRegionFldsEN.js");
var clsDGRegionFldsBL_js_1 = require("../../Js/L2_BLL/RegionManage/clsDGRegionFldsBL.js");
var clsDGRegionFldsWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsDGRegionFldsWApi.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsvDGRegionFldsBL_js_1 = require("../../Js/L2_BLL/RegionManage/clsvDGRegionFldsBL.js");
var clsvDGRegionFldsEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsvDGRegionFldsEN.js");
var clsvDGRegionFldsWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsvDGRegionFldsWApi.js");
var Dictionary_js_1 = require("tzdictionary");
var clsDgFuncTypeEN_js_1 = require("../../Js/L0_Entity/PrjInterface/clsDgFuncTypeEN.js");
var clsDgFuncTypeWApi_js_1 = require("../../Js/L3_ForWApi/PrjInterface/clsDgFuncTypeWApi.js");
var clsCtlTypeAbbrEN_js_1 = require("../../Js/L0_Entity/ViewControlManage/clsCtlTypeAbbrEN.js");
var clsCtlTypeAbbrWApi_js_1 = require("../../Js/L3_ForWApi/ViewControlManage/clsCtlTypeAbbrWApi.js");
var clsPager_js_1 = require("../../Js/PubFun/clsPager.js");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsOrderByData_js_1 = require("../../Js/PubFun/clsOrderByData.js");
var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
var clsDataColumn_js_1 = require("../../Js/PubFun/clsDataColumn.js");
var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
var jsString_js_1 = require("../../Js/PubFun/jsString.js");
var arrSelectedKeys_js_1 = require("../../Js/PubFun/clsCommonFunc4Web.js");
 /* WA_DGRegionFlds_QUDI_JS 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
*/
var WA_DGRegionFlds_QUDI_JS = /** @class */ (function() {
function WA_DGRegionFlds_QUDI_JS()
{
this.mstrListDiv = "divDataLst";
this.objPager = new clsPager_js_1.clsPager();
 /*
 * 每页记录数，在扩展类可以修改
*/
this.RecCount = 0;
}
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "PageSize", {
get: function() { return 5;},
enumerable: true,
configurable: true
});


 /// <summary>
 /// 在当前界面中，导入编辑区域
 /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
 /// </summary>
 /// <returns></returns>
WA_DGRegionFlds_QUDI_JS.AddDPV_Edit = function(divName4Edit) {
var strUrl = "./WA_DGRegionFlds_Edit.html";
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
WA_DGRegionFlds_QUDI_JS.AddDPV_Pager = function(divName4Pager) {
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
WA_DGRegionFlds_QUDI_JS.prototype.Page_Load = async function()
{
// 在此处放置用户代码以初始化页面
try
{
//建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvDGRegionFldsBy = "ColIndex Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vDGRegionFlds();
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
WA_DGRegionFlds_QUDI_JS.prototype.Page_Load_Cache = async function()
{
// 在此处放置用户代码以初始化页面
try
{
// 设置建立缓存
clsPubFun_js_1.clsPubFun.SetCommFun4BL();
 // 为查询区绑定下拉框
this.BindDdl4QueryRegion();
this.hidSortvDGRegionFldsBy = "ColIndex Asc";
//2、显示无条件的表内容在GridView中
const gvResult = await this.BindGv_vDGRegionFlds_Cache();
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
WA_DGRegionFlds_QUDI_JS.prototype.BindDdl4EditRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objDgFuncType_Cond = new clsDgFuncTypeEN_js_1.clsDgFuncTypeEN();//编辑区域
 var objCtlTypeAbbr_Cond = new clsCtlTypeAbbrEN_js_1.clsCtlTypeAbbrEN();//编辑区域
const ddlDgFuncTypeId = await clsDgFuncTypeWApi_js_1.clsDgFuncTypeWApi.BindDdl_DgFuncTypeId_Cache("ddlDgFuncTypeId", objDgFuncType_Cond);//编辑区域
const ddlCtlTypeId = await clsCtlTypeAbbrWApi_js_1.clsCtlTypeAbbrWApi.BindDdl_CtlTypeId_Cache("ddlCtlTypeId", objCtlTypeAbbr_Cond);//编辑区域
}


 /* 函数功能:为查询区绑定下拉框
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
*/
WA_DGRegionFlds_QUDI_JS.prototype.BindDdl4QueryRegion = async function()
{
// 在此处放置用户代码以初始化页面
 var objDgFuncType_Cond = new clsDgFuncTypeEN_js_1.clsDgFuncTypeEN();//查询区域
const ddlDgFuncTypeId_q = await clsDgFuncTypeWApi_js_1.clsDgFuncTypeWApi.BindDdl_DgFuncTypeId_Cache("ddlDgFuncTypeId_q", objDgFuncType_Cond);//查询区域
}


 /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
*/
WA_DGRegionFlds_QUDI_JS.prototype.btnQuery_Click = async function(strListDiv) 
{
var strWhereCond = this.CombinevDGRegionFldsCondition();
try
{
const responseRecCount = await clsvDGRegionFldsWApi_js_1.clsvDGRegionFldsWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: 1,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvDGRegionFldsBy
};
const responseObjLst = await clsvDGRegionFldsWApi_js_1.clsvDGRegionFldsWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
var arrvDGRegionFldsObjLst  = jsonData;
this.BindTab_vDGRegionFlds(this.mstrListDiv, arrvDGRegionFldsObjLst);
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
WA_DGRegionFlds_QUDI_JS.prototype.btnAddNewRecord_Click = async function() {
this.OpType = "Add";
try
{
if (WA_DGRegionFlds_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_DGRegionFlds_QUDI_JS.AddDPV_Edit(WA_DGRegionFlds_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Add');
WA_DGRegionFlds_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_DGRegionFlds_QUDI_JS.prototype.btnAddNewRecordWithMaxId_Click = async function() {
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
WA_DGRegionFlds_QUDI_JS.prototype.btnSetInUse_Click = async function() {
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
const responseBindGv = await this.BindGv_vDGRegionFlds();
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
WA_DGRegionFlds_QUDI_JS.prototype.btnSetNotInUse_Click = async function() {
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
const responseBindGv = await this.BindGv_vDGRegionFlds();
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
 重序
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnReOrder_Click)
 */
WA_DGRegionFlds_QUDI_JS.prototype.btnReOrder_Click = async function()
{
if (this.PreCheck4Order() == false) return;
 var strRegionId =this.RegionId_OrderNum;
try
{
var objOrderByData = new clsOrderByData();
var jsonObject =
{
"RegionId": lngRegionId,
};
var jsonStr = JSON.stringify(jsonObject);
objOrderByData.ClassificationFieldValueLst = jsonStr;
const responseRederBy = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.ReOrder(objOrderByData);
}
catch (e)
{
var strMsg = "重序出错。错误:" + e.Message + ".(In " + clsStackTrace.GetCurrClassFunction() + ")";
alert(strMsg);
return;
}
const responseBindGv = await this.BindGv_vDGRegionFlds();
}

 /*
 置底
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnGoBottum_Click)
 */
WA_DGRegionFlds_QUDI_JS.prototype.btnGoBottum_Click = async function()
{
if (this.PreCheck4Order() == false) return;
 var strRegionId =this.RegionId_OrderNum;
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要置底的记录！");
return "";
}
try
{
var objOrderByData = new clsOrderByData();
objOrderByData.KeyIdLst = arrKeyIds;
var jsonObject =
{
"RegionId": lngRegionId,
};
var jsonStr = JSON.stringify(jsonObject);
objOrderByData.ClassificationFieldValueLst = jsonStr;
const responseRederBy = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GoBottom(objOrderByData);
}
catch (e)
{
var strMsg = "置底出错。错误:" + e.Message + ".(In " + clsStackTrace.GetCurrClassFunction() + ")";
alert(strMsg);
return;
}
const responseBindGv = await this.BindGv_vDGRegionFlds();
var strListDiv = this.mstrListDiv;
arrKeyIds.forEach((e) => clsCommonFunc4Web_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
}

 /*
 移动记录序号时的预检查函数
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_PreCheck4Order)
 */
WA_DGRegionFlds_QUDI_JS.prototype.PreCheck4Order = function()
{
 var strRegionId =this.RegionId_OrderNum;
if (strRegionId == "")
{
var strMsg = "请输入RegionId!";
alert(strMsg);
return false;
}
return true;
}

 /*
 下移
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDownMove_Click)
 */
WA_DGRegionFlds_QUDI_JS.prototype.btnDownMove_Click = async function()
{
if (this.PreCheck4Order() == false) return;
 var strRegionId =this.RegionId_OrderNum;
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要下移的记录!");
return;
}
try
{
var objOrderByData = new clsOrderByData();
objOrderByData.KeyIdLst = arrKeyIds;
var jsonObject =
{
"RegionId": lngRegionId,
};
var jsonStr = JSON.stringify(jsonObject);
objOrderByData.ClassificationFieldValueLst = jsonStr;
const responseRederBy = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.DownMove(objOrderByData);
}
catch (e)
{
var strMsg = "下移记录出错。错误:" + e.Message + ".(In " + clsStackTrace.GetCurrClassFunction() + ")";
alert(strMsg);
return;
}
const responseBindGv = await this.BindGv_vDGRegionFlds();
var strListDiv = this.mstrListDiv;
arrKeyIds.forEach((e) => clsCommonFunc4Web_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
}

 /*
 移动记录，包括上移和下移
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_MoveRecord)
 */
WA_DGRegionFlds_QUDI_JS.prototype.MoveRecord = async function(strDirect)
{
if (this.PreCheck4Order() == false) return;
 var strRegionId =$('#txtRegionId_OrderNum').val();
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要移动(" + strDirect + ")的记录!");
return;
}
try
{
const responseRederBy = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.AdjustOrderNum(strDirect, lngmId, strKeyId);
}
catch (e)
{
var strMsg = "移动(" + strDirect + ")记录出错。错误:" + e.Message + ".(In " + clsStackTrace.GetCurrClassFunction() + ")";
alert(strMsg);
return;
}
const responseBindGv = await this.BindGv_vDGRegionFlds();
//类名不存在，请计算国界面区域的类名或者联系管理员！1.SetCheckedItemForGv(lngmId);
}

 /*
 上移
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnUpMove_Click)
 */
WA_DGRegionFlds_QUDI_JS.prototype.btnUpMove_Click = async function()
{
if (this.PreCheck4Order() == false) return;
 var strRegionId =this.RegionId_OrderNum;
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要上移的记录!");
return;
}
try
{
var objOrderByData = new clsOrderByData();
objOrderByData.KeyIdLst = arrKeyIds;
var jsonObject =
{
"RegionId": lngRegionId,
};
var jsonStr = JSON.stringify(jsonObject);
objOrderByData.ClassificationFieldValueLst = jsonStr;
const responseRederBy = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.UpMove(objOrderByData);
}
catch (e)
{
var strMsg = "上移记录出错。错误:" + e.Message + ".(In " + clsStackTrace.GetCurrClassFunction() + ")";
alert(strMsg);
return;
}
const responseBindGv = await this.BindGv_vDGRegionFlds();
var strListDiv = this.mstrListDiv;
arrKeyIds.forEach((e) => clsCommonFunc4Web_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
}

 /* 置顶
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnGoTop_Click)
 */
WA_DGRegionFlds_QUDI_JS.prototype.btnGoTop_Click = async function()
{
if (this.PreCheck4Order() == false) return;
 var strRegionId =this.RegionId_OrderNum;
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要置顶的记录！");
return "";
}
try
{
var objOrderByData = new clsOrderByData();
objOrderByData.KeyIdLst = arrKeyIds;
var jsonObject =
{
"RegionId": lngRegionId,
};
var jsonStr = JSON.stringify(jsonObject);
objOrderByData.ClassificationFieldValueLst = jsonStr;
const responseRederBy = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GoTop(objOrderByData);
}
catch (e)
{
var strMsg = "置顶出错。错误:" + e.Message + ".(In " + clsStackTrace.GetCurrClassFunction() + ")";
alert(strMsg);
return;
}
const responseBindGv = await this.BindGv_vDGRegionFlds();
var strListDiv = this.mstrListDiv;
var strListDiv = this.mstrListDiv;
arrKeyIds.forEach((e) => clsCommonFunc4Web_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
}

 /*
  添加新记录
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnCopyRecord_Click)
 */
WA_DGRegionFlds_QUDI_JS.prototype.btnCopyRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要克隆的记录！");
return "";
}
const responseText = await this.CopyRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vDGRegionFlds();
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
WA_DGRegionFlds_QUDI_JS.prototype.btnUpdateRecordInTab_Click = function(strKeyId) {
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
WA_DGRegionFlds_QUDI_JS.prototype.btnDelRecordInTab_Click = async function(strKeyId) {
try
{
 if (strKeyId == "")
{
alert("请选择需要删除的记录！");
return "";
}
var lngKeyId =  Number(strKeyId);
const responseText = await this.DelRecord(lngKeyId);
const responseBindGv = await this.BindGv_vDGRegionFlds();
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
WA_DGRegionFlds_QUDI_JS.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {
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
WA_DGRegionFlds_QUDI_JS.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {
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
WA_DGRegionFlds_QUDI_JS.prototype.DelRecord = async function(lngmId) {
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.DelRecord(lngmId);
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
WA_DGRegionFlds_QUDI_JS.prototype.DetailRecord = async function(lngmId) 
{
this.btnOKUpd = "";
this.btnCancel = "关闭";
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GetObjBymId(lngmId);
var objDGRegionFldsEN = responseText;
this.GetDataFromDGRegionFldsClass(objDGRegionFldsEN);
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
WA_DGRegionFlds_QUDI_JS.prototype.SelectRecord = async function(lngmId) 
{
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GetObjBymId(lngmId);
var objDGRegionFldsEN = responseText;
console.log("完成SelectRecord!");
clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vDGRegionFlds");
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
WA_DGRegionFlds_QUDI_JS.prototype.btnUpdateRecord_Click = async function() {
this.OpType = "Update";
var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
    if (strKeyId == "")
{
alert("请选择需要修改的记录！");
return;
}
if (WA_DGRegionFlds_QUDI_JS.bolIsLoadEditRegion == false)  //
{
const responseBool = await WA_DGRegionFlds_QUDI_JS.AddDPV_Edit(WA_DGRegionFlds_QUDI_JS.divName4Edit);
 // 为编辑区绑定下拉框
const conBindDdl = await this.BindDdl4EditRegion();
ShowDialog('Update');
WA_DGRegionFlds_QUDI_JS.bolIsLoadEditRegion = true;  //
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
WA_DGRegionFlds_QUDI_JS.prototype.btnUnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要恢复删除的记录！");
return "";
}
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.UnDelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vDGRegionFlds();
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
WA_DGRegionFlds_QUDI_JS.prototype.btnDelRecordBySign_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要按标志删除的记录！");
return "";
}
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.DelRecordBySign(arrKeyIds);
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
const responseText2 = await this.BindGv_vDGRegionFlds();
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
WA_DGRegionFlds_QUDI_JS.prototype.btnDelRecord_Click = async function() {
try
{
var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
if (arrKeyIds.length == 0)
{
alert("请选择需要删除的记录！");
return "";
}
const responseText = await this.DelMultiRecord(arrKeyIds);
const responseBindGv = await this.BindGv_vDGRegionFlds();
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
WA_DGRegionFlds_QUDI_JS.prototype.btnExportExcel_Click = async function() 
{
var strWhereCond =" 1=1 ";
try
{
const responseText = await clsvDGRegionFldsWApi_js_1.clsvDGRegionFldsWApi.GetObjLst(strWhereCond).then((jsonData)=>{
var arrvDGRegionFldsObjLst  = jsonData;
this.BindTab_vDGRegionFlds(this.mstrListDiv, arrvDGRegionFldsObjLst);
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
WA_DGRegionFlds_QUDI_JS.prototype.btnOKUpd_Click = async function()
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
//this.BindGv_vDGRegionFlds();
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
this.BindGv_vDGRegionFlds();
}
});
}
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{
var returnBool = jsonData;
var strInfo = returnBool ? "修改成功！" : "修改不成功！";
strInfo += "(In WA_DGRegionFlds_QUDI_JS.btnOKUpd_Click)";
$('#lblResult51').val(strInfo);
//显示信息框
console.log(strInfo);
alert(strInfo);
if (returnBool == true)
{
HideDialog();
this.BindGv_vDGRegionFlds();
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
WA_DGRegionFlds_QUDI_JS.prototype.CombinevDGRegionFldsCondition = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if (this.ColIndex_q != 0)
{
strWhereCond += " And " + clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_ColIndex + " = " + this.ColIndex_q + "";
}
if ( this.ColCaption_q != "")
{
strWhereCond += " And " + clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_ColCaption + " like '% " + this.ColCaption_q + "%'";
}
if ( this.DgFuncTypeId_q != "" && this.DgFuncTypeId_q != "0")
{
strWhereCond += " And " + clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_DgFuncTypeId + " = '" + this.DgFuncTypeId_q + "'";
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombineDGRegionFldsCondition)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return strWhereCond;
}

 /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
  <returns>条件串(strWhereCond)</returns>
*/
WA_DGRegionFlds_QUDI_JS.prototype.CombinevDGRegionFldsConditionObj = function() 
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
var strWhereCond = " 1 = 1 ";
var objvDGRegionFlds_Cond = new clsDGRegionFldsEN_js_1.clsDGRegionFldsEN();
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
try
{
if (this.ColIndex_q != 0)
{
strWhereCond += " And " + clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_ColIndex + " = " + this.ColIndex_q + "";
objvDGRegionFlds_Cond.SetCondFldValue(clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_ColIndex, this.ColIndex_q, "=");
}
if ( this.ColCaption_q != "")
{
strWhereCond += " And " + clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_ColCaption + " like '% " + this.ColCaption_q + "%'";
objvDGRegionFlds_Cond.SetCondFldValue(clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_ColCaption, this.ColCaption_q, "like");
}
if ( this.DgFuncTypeId_q != "" && this.DgFuncTypeId_q != "0")
{
strWhereCond += " And " + clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_DgFuncTypeId + " = '" + this.DgFuncTypeId_q + "'";
objvDGRegionFlds_Cond.SetCondFldValue(clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_DgFuncTypeId, this.DgFuncTypeId_q, "=");
}
}
catch(objException)
{
var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombineDGRegionFldsConditionObj)时出错!请联系管理员!" + objException.message + "";
throw strMsg;
}
return objvDGRegionFlds_Cond;
}

 /* 显示vDGRegionFlds对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrDGRegionFldsObjLst">需要绑定的对象列表</param>
*/
WA_DGRegionFlds_QUDI_JS.prototype.BindTab_vDGRegionFlds = function(divContainer, arrvDGRegionFldsObjLst) 
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
FldName: "ColIndex",
ColHeader: "序号",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "FldName",
ColHeader: "字段",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "ColCaption",
ColHeader: "标题",
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
FldName: "CtlTypeName",
ColHeader: "控件类型",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsNeedSort",
ColHeader: "排序?",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "IsTransToChkBox",
ColHeader: "换成CheckBox?",
Text: "",
ColumnType: "Label",
OrderNum: 1,
FuncName: () => { }
},
{
FldName: "InUse",
ColHeader: "使用?",
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
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrvDGRegionFldsObjLst, arrDataColumn, "mId"); 
this.objPager.RecCount = this.RecCount;
this.objPager.PageSize = this.PageSize;
this.objPager.ShowPager();
}

 /* 函数功能:在数据 列表中跳转到某一页
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
WA_DGRegionFlds_QUDI_JS.prototype.IndexPage = function(intPageIndex)
{
if (intPageIndex == 0)
{
intPageIndex = this.objPager.PageCount;
}
console.log("跳转到" + intPageIndex + "页");
this.CurrPageIndex = intPageIndex;
this.BindGv_vDGRegionFlds();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv)
*/
WA_DGRegionFlds_QUDI_JS.prototype.BindGv_vDGRegionFlds = async function() 
{
var strListDiv = this.mstrListDiv;
var strWhereCond = this.CombinevDGRegionFldsCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvDGRegionFldsObjLst = [];
try
{
const responseRecCount = await clsvDGRegionFldsWApi_js_1.clsvDGRegionFldsWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
this.RecCount = jsonData;
});
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvDGRegionFldsBy
};
const responseObjLst = await clsvDGRegionFldsWApi_js_1.clsvDGRegionFldsWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
arrvDGRegionFldsObjLst = jsonData;
});
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvDGRegionFldsObjLst.length == 0)
{
var strMsg = "在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！";
alert(strMsg);
return;
}
try
{
this.BindTab_vDGRegionFlds(strListDiv, arrvDGRegionFldsObjLst);
console.log("完成BindGv_vDGRegionFlds!");
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
WA_DGRegionFlds_QUDI_JS.prototype.BindGv_vDGRegionFlds_Cache = async function() 
{
var strListDiv = this.mstrListDiv;
var objvDGRegionFlds_Cond = this.CombinevDGRegionFldsConditionObj();
objvDGRegionFlds_Cond.SetCondFldValue(clsDGRegionFldsEN_js_1.clsDGRegionFldsEN.con_PrjId, WA_DGRegionFlds_QUDI_JS.strPrjId_Cache, "=");
var objvDGRegionFldsEN_Sim = clsvDGRegionFldsBL_js_1.clsvDGRegionFldsBL.GetSimObjFromObj(objvDGRegionFlds_Cond);
console.log(objvDGRegionFldsEN_Sim);
var strWhereCond = JSON.stringify(objvDGRegionFldsEN_Sim);
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
 var arrvDGRegionFldsObjLst = [];
try
{
this.RecCount = await  clsvDGRegionFldsWApi_js_1.clsvDGRegionFldsWApi.GetRecCountByCond_Cache(objvDGRegionFlds_Cond, WA_DGRegionFlds_QUDI_JS.strPrjId_Cache);
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvDGRegionFldsBy
};
var arrvDGRegionFldsObjLst = await clsvDGRegionFldsWApi_js_1.clsvDGRegionFldsWApi.GetObjLstByPager_Cache(objPagerPara, WA_DGRegionFlds_QUDI_JS.strPrjId_Cache);
}
catch(e)
{
console.log('catch(e)=');
console.log(e);
var strMsg = "绑定GridView不成功," + e+ ".";
alert(strMsg);
}
if (arrvDGRegionFldsObjLst.length == 0)
{
var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=DGRegionFlds_" + WA_DGRegionFlds_QUDI_JS.strPrjId_Cache + ")";
alert(strMsg);
return;
}
try
{
this.BindTab_vDGRegionFlds(strListDiv, arrvDGRegionFldsObjLst);
console.log("完成BindGv_vDGRegionFlds!");
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
WA_DGRegionFlds_QUDI_JS.prototype.SortBy = async function(strSortByFld) {
if (this.hidSortvDGRegionFldsBy.indexOf(strSortByFld) >= 0)
{
if (this.hidSortvDGRegionFldsBy.indexOf("Asc") >= 0)
{
this.hidSortvDGRegionFldsBy = "" + strSortByFld + " Desc";
}
else
{
this.hidSortvDGRegionFldsBy = "" + strSortByFld + " Asc";
}
}
else
{
this.hidSortvDGRegionFldsBy = "" + strSortByFld + " Asc";
}
const responseBindGv = await this.BindGv_vDGRegionFlds();
}

 /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
*/
WA_DGRegionFlds_QUDI_JS.prototype.QueryvDGRegionFldsLst = function(strListDiv) 
{
var strWhereCond = this.CombinevDGRegionFldsCondition();
var intCurrPageIndex = this.CurrPageIndex;//获取当前页
return new Promise((resolve, reject) => {
try
{
var objPagerPara = {
PageIndex: intCurrPageIndex,
PageSize: this.PageSize,
WhereCond: strWhereCond,
OrderBy: this.hidSortvDGRegionFldsBy
};
const responseText = clsvDGRegionFldsWApi_js_1.clsvDGRegionFldsWApi.GetObjLstByPager(objPagerPara).then((jsonData)=>{
var arrvDGRegionFldsObjLst  = jsonData;
this.BindTab_vDGRegionFlds(strListDiv, arrvDGRegionFldsObjLst);
console.log("完成QueryvDGRegionFldsLst!");
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
WA_DGRegionFlds_QUDI_JS.prototype.Clear = function()
{
}

 /* 获取当前表关键字值的最大值,再加1,避免重复
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
*/
WA_DGRegionFlds_QUDI_JS.prototype.GetMaxStrId = async function(strKeyCtrlName) {
this.DivName = "divGetMaxStrId";
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GetMaxStrId();
var returnString = responseText.toString();
if (returnString == "")
{
var strInfo = "获取表DGRegionFlds的最大关键字为空，不成功，请检查!";
$('#lblResult49').val(strInfo);
//显示信息框
alert(strInfo);
 $(strKeyCtrlName).val(returnString);
}
else
{
var strInfo = "获取表DGRegionFlds的最大关键字为：" + returnString + "!";
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
WA_DGRegionFlds_QUDI_JS.prototype.AddNewRecord = async function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucDGRegionFldsB1.mId = clsDGRegionFldsBL_js_1.clsDGRegionFldsBL.GetMaxStrId_S();
}

 /* 为插入记录做准备工作
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
*/
WA_DGRegionFlds_QUDI_JS.prototype.AddNewRecordWithMaxId = function()
{
this.btnOKUpd = "确认添加";
this.btnCancel = "取消添加";
this.Clear();
//wucDGRegionFldsB1.mId = clsDGRegionFldsBL_js_1.clsDGRegionFldsBL.GetMaxStrId_S();
}

 /* 复制记录
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
*/
WA_DGRegionFlds_QUDI_JS.prototype.CopyRecord = async function(arrmId) {
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GetObjLstBymIdLst(arrmId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrDGRegionFldsObjLst =  responseText;
for (let objInFor of arrDGRegionFldsObjLst)
{
const responseText2 = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.AddNewRecord(objInFor);
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
WA_DGRegionFlds_QUDI_JS.prototype.SetInUse = async function(arrmId)
{
if (arrmId.length == 0)
{
let strMsg = "没有选择记录，不能设置字段值!";
alert(strMsg);
return "";
}
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GetObjLstBymIdLst(arrmId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrDGRegionFldsObjLst =  responseText;
for (let objInFor of arrDGRegionFldsObjLst)
{
let objDGRegionFldsEN = new clsDGRegionFldsEN_js_1.clsDGRegionFldsEN();
clsDGRegionFldsBL_js_1.clsDGRegionFldsBL.CopyObjTo(objInFor, objDGRegionFldsEN);
objDGRegionFldsEN.InUse = TransToBool("true");
var returnBool = false;
try
{
    objDGRegionFldsEN.sf_UpdFldSetStr = objDGRegionFldsEN.UpdFldString;//设置哪些字段被修改(脏字段)
const responseUpdate = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.UpdateRecord(objDGRegionFldsEN);
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
WA_DGRegionFlds_QUDI_JS.prototype.SetNotInUse = async function(arrmId)
{
if (arrmId.length == 0)
{
let strMsg = "没有选择记录，不能设置字段值!";
alert(strMsg);
return "";
}
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GetObjLstBymIdLst(arrmId);
console.log('responseText=');
console.log(responseText);
var intCount = 0;
var arrDGRegionFldsObjLst =  responseText;
for (let objInFor of arrDGRegionFldsObjLst)
{
let objDGRegionFldsEN = new clsDGRegionFldsEN_js_1.clsDGRegionFldsEN();
clsDGRegionFldsBL_js_1.clsDGRegionFldsBL.CopyObjTo(objInFor, objDGRegionFldsEN);
objDGRegionFldsEN.InUse = TransToBool("false");
var returnBool = false;
try
{
    objDGRegionFldsEN.sf_UpdFldSetStr = objDGRegionFldsEN.UpdFldString;//设置哪些字段被修改(脏字段)
const responseUpdate = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.UpdateRecord(objDGRegionFldsEN);
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
  <param name = "pobjDGRegionFldsEN">数据传输的目的类对象</param>
*/
WA_DGRegionFlds_QUDI_JS.prototype.PutDataToDGRegionFldsClass = function(pobjDGRegionFldsEN)
{
pobjDGRegionFldsEN.IsNeedSort = this.IsNeedSort;// 是否需要排序
pobjDGRegionFldsEN.ColIndex = this.ColIndex;// 列序号
pobjDGRegionFldsEN.ColCaption = this.ColCaption;// 列标题
pobjDGRegionFldsEN.IsTransToChkBox = this.IsTransToChkBox;// 是否转换成CheckBox
pobjDGRegionFldsEN.RegionId = this.RegionId;// 区域Id
pobjDGRegionFldsEN.IsVisible = this.IsVisible;// 是否显示
pobjDGRegionFldsEN.IsFuncFld = this.IsFuncFld;// 是否功能字段
pobjDGRegionFldsEN.DgFuncTypeId = this.DgFuncTypeId;// Dg功能类型Id
pobjDGRegionFldsEN.CtlTypeId = this.CtlTypeId;// 控件类型号
pobjDGRegionFldsEN.Memo = this.Memo;// 说明
pobjDGRegionFldsEN.UpdDate = this.UpdDate;// 修改日期
pobjDGRegionFldsEN.TabFldId = this.TabFldId;// 表字段ID
}


 /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
*/
WA_DGRegionFlds_QUDI_JS.prototype.AddNewRecordSave = async function(){
this.DivName = "divAddNewRecordSave";
var objDGRegionFldsEN = new clsDGRegionFldsEN_js_1.clsDGRegionFldsEN();
   this.PutDataToDGRegionFldsClass(objDGRegionFldsEN);
try
{
const responseText2 = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.AddNewRecord(objDGRegionFldsEN);
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
WA_DGRegionFlds_QUDI_JS.prototype.ShowData = async function(lngmId) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objDGRegionFldsEN = new clsDGRegionFldsEN_js_1.clsDGRegionFldsEN();
        try {
            const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.IsExist(lngmId);
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
            const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GetObjBymId(lngmId);
            objDGRegionFldsEN = responseText;
        }
        catch (e) {
            var strMsg = "根据关键字获取相应的记录的对象不成功," + e+ ".";
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromDGRegionFldsClass(objDGRegionFldsEN);
}

 /* 函数功能:把类对象的属性内容显示到界面上
 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
  如果在设置数据库时,就应该一级字段在前,二级字段在后
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
  <param name = "pobjDGRegionFldsEN">表实体类对象</param>
*/
WA_DGRegionFlds_QUDI_JS.prototype.GetDataFromDGRegionFldsClass = function(pobjDGRegionFldsEN )
{
this.IsNeedSort = pobjDGRegionFldsEN.IsNeedSort;// 是否需要排序
 this.ColIndex = pobjDGRegionFldsEN.ColIndex;// 列序号
 this.ColCaption = pobjDGRegionFldsEN.ColCaption;// 列标题
this.IsTransToChkBox = pobjDGRegionFldsEN.IsTransToChkBox;// 是否转换成CheckBox
 this.RegionId = pobjDGRegionFldsEN.RegionId;// 区域Id
this.IsVisible = pobjDGRegionFldsEN.IsVisible;// 是否显示
this.IsFuncFld = pobjDGRegionFldsEN.IsFuncFld;// 是否功能字段
 this.DgFuncTypeId = pobjDGRegionFldsEN.DgFuncTypeId;// Dg功能类型Id
 this.CtlTypeId = pobjDGRegionFldsEN.CtlTypeId;// 控件类型号
 this.Memo = pobjDGRegionFldsEN.Memo;// 说明
 this.UpdDate = pobjDGRegionFldsEN.UpdDate;// 修改日期
 this.TabFldId = pobjDGRegionFldsEN.TabFldId;// 表字段ID
}

 /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
WA_DGRegionFlds_QUDI_JS.prototype.UpdateRecord = async function(lngmId) 
{
this.btnOKUpd = "确认修改";
this.btnCancel = "取消修改";
this.KeyId = lngmId.toString();
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.GetObjBymId(lngmId);
var objDGRegionFldsEN = responseText;
this.GetDataFromDGRegionFldsClass(objDGRegionFldsEN);
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
WA_DGRegionFlds_QUDI_JS.prototype.UpdateRecordSave = async function() {
this.DivName = "divUpdateRecordSave";
var objDGRegionFldsEN = new clsDGRegionFldsEN_js_1.clsDGRegionFldsEN();
objDGRegionFldsEN.mId = Number(this.KeyId);
   this.PutDataToDGRegionFldsClass(objDGRegionFldsEN);
objDGRegionFldsEN.sf_UpdFldSetStr = objDGRegionFldsEN.UpdFldString;//设置哪些字段被修改(脏字段)
if (objDGRegionFldsEN.mId == 0 || objDGRegionFldsEN.mId == undefined){
throw "关键字不能为空!";
}
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.UpdateRecord(objDGRegionFldsEN);
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
WA_DGRegionFlds_QUDI_JS.prototype.DelMultiRecord = async function(arrmId) {
try
{
const responseText = await clsDGRegionFldsWApi_js_1.clsDGRegionFldsWApi.DelDGRegionFldss(arrmId);
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
  <param name = "objDGRegionFlds">需要显示的对象</param>
*/
WA_DGRegionFlds_QUDI_JS.prototype.ShowDGRegionFldsObj = function(divContainer, objDGRegionFlds) 
{
var o = document.getElementById(divContainer);
if (o == null)
{
alert("" + divContainer + "不存在！");
return;
}
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objDGRegionFlds);
var ul = document.createElement("ul");
for (let strKey of sstrKeys)
{
var strValue = objDGRegionFlds[strKey];
var li = document.createElement("li");
li.innerHTML = "" + strKey + ":" + strValue + "";
ul.appendChild(li);
}
o.appendChild(ul);
}

 /* 函数功能:从界面列表中获取第一个关键字的值
  (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
  <param name = "pobjDGRegionFldsEN">表实体类对象</param>
 <returns>列表的第一个关键字值</returns>
*/
WA_DGRegionFlds_QUDI_JS.prototype.GetFirstKey = function() {
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
WA_DGRegionFlds_QUDI_JS.prototype.Demo_Session = async function()
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
WA_DGRegionFlds_QUDI_JS.prototype.SetSession = function(Key, Value) {
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
WA_DGRegionFlds_QUDI_JS.prototype.GetSession = function(Key) {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "btnCancel", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "btnOKUpd", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "btnOKUpd", {
    get: function()
{
return $("#btnOKUpd").html();
 },
 enumerable: true,
configurable: true
});
 /*
 * 列标题
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "ColCaption", {
 set: function(value)
{
$("#txtColCaption").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 列标题
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "ColCaption", {
    get: function()
{
return $("#txtColCaption").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 列标题
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "ColCaption_q", {
    get: function()
{
return $("#txtColCaption_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 列序号
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "ColIndex", {
 set: function(value)
{
$("#txtColIndex").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 列序号
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "ColIndex", {
    get: function()
{
return $("#txtColIndex").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 列序号
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "ColIndex_q", {
    get: function()
{
return $("#txtColIndex_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 控件类型号
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "CtlTypeId", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "CtlTypeId", {
    get: function()
{
return $("#ddlCtlTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置当前页序号
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "CurrPageIndex", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "CurrPageIndex", {
    get: function()
{
return $("#hidCurrPageIndex").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * Dg功能类型Id
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "DgFuncTypeId", {
 set: function(value)
{
$("#ddlDgFuncTypeId").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * Dg功能类型Id
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "DgFuncTypeId", {
    get: function()
{
return $("#ddlDgFuncTypeId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * Dg功能类型Id
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "DgFuncTypeId_q", {
    get: function()
{
return $("#ddlDgFuncTypeId_q").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 添加、修改用的层名
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "DivName", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "hidSortvDGRegionFldsBy", {
 set: function(value)
{
$("#hidSortvDGRegionFldsBy").val(value);
},
    get: function()
{
return $("#hidSortvDGRegionFldsBy").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 用户Id
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "hidUserId", {
    get: function()
{
return $("#hidUserId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否功能字段
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "IsFuncFld", {
 set: function(value)
{
$("#chkIsFuncFld").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否功能字段
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "IsFuncFld", {
    get: function()
{
return $("#chkIsFuncFld").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否需要排序
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "IsNeedSort", {
 set: function(value)
{
$("#chkIsNeedSort").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否需要排序
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "IsNeedSort", {
    get: function()
{
return $("#chkIsNeedSort").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否转换成CheckBox
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "IsTransToChkBox", {
 set: function(value)
{
$("#chkIsTransToChkBox").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否转换成CheckBox
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "IsTransToChkBox", {
    get: function()
{
return $("#chkIsTransToChkBox").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 是否显示
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "IsVisible", {
 set: function(value)
{
$("#chkIsVisible").val(value);
},
 enumerable: true,
configurable: true
});
 /*
 * 是否显示
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "IsVisible", {
    get: function()
{
return $("#chkIsVisible").prop("checked");
 },
 enumerable: true,
configurable: true
});
 /*
 * 设置关键字的值
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "KeyId", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "Memo", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "OpType", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "OpType", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "RegionId", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "RegionId", {
    get: function()
{
return $("#txtRegionId").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * RegionId
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "RegionId_OrderNum", {
    get: function()
{
return $("#txtRegionId_OrderNum").val();
 },
 enumerable: true,
configurable: true
});
 /*
 * 表字段ID
*/
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "TabFldId", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "TabFldId", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "UpdDate", {
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
Object.defineProperty(WA_DGRegionFlds_QUDI_JS.prototype, "UpdDate", {
    get: function()
{
return $("#txtUpdDate").val();
 },
 enumerable: true,
configurable: true
});
WA_DGRegionFlds_QUDI_JS.strPrjId_Cache = "0001";
WA_DGRegionFlds_QUDI_JS.bolIsLoadEditRegion = false;  //
WA_DGRegionFlds_QUDI_JS.divName4Edit = "divEdit";  //
return WA_DGRegionFlds_QUDI_JS;
}());
exports.WA_DGRegionFlds_QUDI_JS = WA_DGRegionFlds_QUDI_JS;
});