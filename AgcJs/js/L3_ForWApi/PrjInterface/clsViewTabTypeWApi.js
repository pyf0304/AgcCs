
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTabTypeWApi
 表名:ViewTabType(00050103)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:25
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
 框架-层名:WA_访问层RJ(WA_AccessRJ)
 编程语言:JavaScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
var __importStar = (this && this.__importStar) || function(mod) {
if (mod && mod.__esModule) return mod;
var result = { };
if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
result["default"] = mod;
return result;
};
(function(factory) {
if (typeof module === "object" && typeof module.exports === "object")
{
var v = factory(require, exports);
if (v !== undefined) module.exports = v;
}
else if (typeof define === "function" && define.amd)
{
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsViewTabTypeEN.js","../../L2_BLL/PrjInterface/clsCommFun4WA4ViewTabType.js","clscommonfunc4web","clsstacktrace","../../L2_BLL/PrjInterface/clsViewTabTypeBL.js","tzdictionary","clssyspara4webapi","../../PubFun/stuTopPara.js","../../PubFun/stuRangePara.js","../../PubFun/stuPagerPara.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsViewTabTypeEN_js_1 = require("../../L0_Entity/PrjInterface/clsViewTabTypeEN.js");
var clsCommFun4WA4ViewTabType_js_1 = require("../../L2_BLL/PrjInterface/clsCommFun4WA4ViewTabType.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsViewTabTypeBL_js_1 = require("../../L2_BLL/PrjInterface/clsViewTabTypeBL.js");
var Dictionary_js_1 = require("tzdictionary");
var clsSysPara4WebApi_js_1 = require("clssyspara4webapi");
var stuTopPara_js_1 = require("../../PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");

 /// <summary>
 /// 界面表类型(ViewTabType)
 /// (AutoGCLib.WA_AccessRJ4JavaScript:GeneCode)
 /// </summary>
var ResponseData;
var clsViewTabTypeWApi = /** @class */ (function() {
function clsViewTabTypeWApi(pobjViewTabTypeEN)
{
this.objViewTabTypeEN = new clsViewTabTypeEN_js_1.clsViewTabTypeEN();
this.objViewTabTypeEN = pobjViewTabTypeEN;
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewTabTypeId">关键字</param>
 /// <returns>对象</returns>
clsViewTabTypeWApi.GetObjByViewTabTypeId = function(strViewTabTypeId)  
{
var strAction = "GetObjByViewTabTypeId";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("ViewTabTypeId", strViewTabTypeId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObj = JSON.parse(data.ReturnObj);
//console.log(returnObj);
resolve(returnObj);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId_Cache)
 /// </summary>
 /// <param name = "strViewTabTypeId">所给的关键字</param>
 /// <returns>对象</returns>
clsViewTabTypeWApi.GetObjByViewTabTypeId_Cache = async function(strViewTabTypeId) {
var arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_Cache();
var obj = new clsViewTabTypeEN_js_1.clsViewTabTypeEN();
try
{
var arrViewTabType_Sel = arrViewTabTypeObjLst_Cache.filter(x => x.ViewTabTypeId == strViewTabTypeId);
var objViewTabType;
if (arrViewTabType_Sel.length > 0)
{
objViewTabType = arrViewTabType_Sel[0];
return objViewTabType;
}
else
{
return obj;
}
}
catch (e)
{
var strMsg = "根据关键字:[" + strViewTabTypeId  + "]获取相应的对象不成功!";
alert(strMsg);
}
return obj;
};

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_SetCache)
 /// </summary>
 /// <param name = "strViewTabTypeId">所给的关键字</param>
 /// <returns>对象</returns>
clsViewTabTypeWApi.SetCache = function() {
clsViewTabTypeWApi.objCommFun4BL = new clsCommFun4WA4ViewTabType_js_1.clsCommFun4WA4ViewTabType();
 //把以下三行添加到clsPubFun.js中
//"../L3_ForWApi/PrjInterface/clsViewTabTypeWApi.js"
//var clsViewTabTypeWApi_js_1 = require("../L3_ForWApi/PrjInterface/clsViewTabTypeWApi.js");
//clsViewTabTypeWApi_js_1.clsViewTabTypeWApi.SetCache();
};

 /// <summary>
 /// 根据关键字获取相应的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strViewTabTypeId">关键字</param>
 /// <returns>对象</returns>
clsViewTabTypeWApi.GetObjByViewTabTypeId_WA_Cache = function(strViewTabTypeId)  
{
var strAction = "GetObjByViewTabTypeId_Cache";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("ViewTabTypeId", strViewTabTypeId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObj = JSON.parse(data.ReturnObj);
//console.log(returnObj);
resolve(returnObj);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetFirstId)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>返回的第一条记录的关键字值</returns>
clsViewTabTypeWApi.GetFirstID = function(strWhereCond)  
{
var strAction = "GetFirstID";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnStr);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象</returns>
clsViewTabTypeWApi.GetFirstObj = function(strWhereCond)  
{
var strAction = "GetFirstObj";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObj = JSON.parse(data.ReturnObj);
//console.log(returnObj);
resolve(returnObj);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_Cache)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsViewTabTypeWApi.GetObjLst_Cache = async function() 
{
var arrViewTabTypeObjLst_Cache;
switch (clsViewTabTypeWApi.CacheModeId)
{
case "04"://sessionStorage
arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_localStorage();
break;
case "02"://ClientCache
arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_ClientCache();
break;
default:
arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_ClientCache();
break;
}
return arrViewTabTypeObjLst_Cache;
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_ClientCache)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsViewTabTypeWApi.GetObjLst_ClientCache = async function() 
{
//初始化列表缓存
var strWhereCond = "1=1";
clsViewTabTypeWApi.InitListCache(); 
var strKey = clsViewTabTypeEN_js_1.clsViewTabTypeEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper_js_1.CacheHelper.Exsits(strKey))
{
//缓存存在，直接取出返回
var arrViewTabTypeObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
return arrViewTabTypeObjLst_Cache;
}
try
{
const responseText = await clsViewTabTypeWApi.GetObjLst(strWhereCond);
var arrViewTabTypeObjLst = responseText;
CacheHelper_js_1.CacheHelper.Add(strKey, arrViewTabTypeObjLst);
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrViewTabTypeObjLst.length+ " !";
console.log(strInfo);
return arrViewTabTypeObjLst;
}
catch (e)
{
console.log("GetObjLst_Cache:e");
console.log(e);
var strMsg = "从缓存中获取所有对象列表出错," +e + ".";
throw (strMsg);
}
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_localStorage)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsViewTabTypeWApi.GetObjLst_localStorage = async function() 
{
//初始化列表缓存
var strWhereCond = "1=1";
clsViewTabTypeWApi.InitListCache(); 
var strKey = clsViewTabTypeEN_js_1.clsViewTabTypeEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (localStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = localStorage.getItem(strKey);
var arrViewTabTypeObjLst_Cache = JSON.parse(strTempObjLst);
return arrViewTabTypeObjLst_Cache;
}
try
{
const responseText = await clsViewTabTypeWApi.GetObjLst(strWhereCond);
var arrViewTabTypeObjLst = responseText;
localStorage.setItem(strKey, JSON.stringify(arrViewTabTypeObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrViewTabTypeObjLst.length+ " !";
console.log(strInfo);
return arrViewTabTypeObjLst;
}
catch (e)
{
console.log("GetObjLst_Cache:e");
console.log(e);
var strMsg = "从缓存中获取所有对象列表出错," +e + ".";
throw (strMsg);
}
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_sessionStorage)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsViewTabTypeWApi.GetObjLst_sessionStorage = async function() 
{
//初始化列表缓存
var strWhereCond = "1=1";
clsViewTabTypeWApi.InitListCache(); 
var strKey = clsViewTabTypeEN_js_1.clsViewTabTypeEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (sessionStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = sessionStorage.getItem(strKey);
var arrViewTabTypeObjLst_Cache = JSON.parse(strTempObjLst);
return arrViewTabTypeObjLst_Cache;
}
try
{
const responseText = await clsViewTabTypeWApi.GetObjLst(strWhereCond);
var arrViewTabTypeObjLst = responseText;
sessionStorage.setItem(strKey, JSON.stringify(arrViewTabTypeObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrViewTabTypeObjLst.length+ " !";
console.log(strInfo);
return arrViewTabTypeObjLst;
}
catch (e)
{
console.log("GetObjLst_Cache:e");
console.log(e);
var strMsg = "从缓存中获取所有对象列表出错," +e + ".";
throw (strMsg);
}
}

 /// <summary>
 /// 获取服务器缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象列表</returns>
clsViewTabTypeWApi.GetObjLst_WA_Cache = function()  
{
var strAction = "GetObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件对象, 从缓存的对象列表中获取子集.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objstrViewTabTypeId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsViewTabTypeWApi.GetSubObjLst_Cache =  async function(objViewTabType_Cond) {
var objViewTabType_Sim = clsViewTabTypeBL_js_1.clsViewTabTypeBL.GetSimObjFromObj(objViewTabType_Cond);
var arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_Cache();
var arrViewTabType_Sel = arrViewTabTypeObjLst_Cache.filter(x => true);
if (objViewTabType_Sim.sf_FldComparisonOp == null || objViewTabType_Sim.sf_FldComparisonOp == "") return arrViewTabType_Sel;
var dicFldComparisonOp = JSON.parse(objViewTabType_Sim.sf_FldComparisonOp);
console.log("clsViewTabTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objViewTabType_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objViewTabType_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrViewTabType_Sel;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objViewTabType_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetSubObjLst_WA_Cache)
 /// </summary>
 /// <param name = "objViewTabType_Cond">条件对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsViewTabTypeWApi.GetSubObjLst_WA_Cache = function(objViewTabType_Cond)  
{
var strAction = "GetSubObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var objViewTabTypeEN_Sim = clsViewTabTypeBL_js_1.clsViewTabTypeBL.GetSimObjFromObj(objViewTabType_Cond);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objViewTabTypeEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrViewTabTypeId">关键字列表</param>
 /// <returns>对象列表</returns>
clsViewTabTypeWApi.GetObjLstByViewTabTypeIdLst = function(arrViewTabTypeId)  
{
var strAction = "GetObjLstByViewTabTypeIdLst";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrViewTabTypeId },
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 从缓存中获取.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrstrViewTabTypeIdLst">关键字列表</param>
 /// <returns>对象列表</returns>
clsViewTabTypeWApi.GetObjLstByViewTabTypeIdLst_Cache =  async function(arrViewTabTypeIdLst) {
try
{
var arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_Cache();
var arrViewTabType_Sel = arrViewTabTypeObjLst_Cache.filter(x => arrViewTabTypeIdLst.indexOf(x.ViewTabTypeId)>-1);
return arrViewTabType_Sel;
}
catch (e)
{
var strMsg = "根据关键字:[" + arrViewTabTypeIdLst.join(",")  + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "arrViewTabTypeId">关键字列表</param>
 /// <returns>对象列表</returns>
clsViewTabTypeWApi.GetObjLstByViewTabTypeIdLst_WA_Cache = function(arrViewTabTypeId)  
{
var strAction = "GetObjLstByViewTabTypeIdLst_Cache";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrViewTabTypeId },
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取的相应对象列表</returns>
clsViewTabTypeWApi.GetObjLst = function(strWhereCond)  
{
var strAction = "GetObjLst";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>获取的相应对象列表</returns>
clsViewTabTypeWApi.GetTopObjLst = function(objTopPara)  
{
var strAction = "GetTopObjLst";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam =  stuTopPara_js_1.stuTopPara.GetMapParam(objTopPara);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objTopPara,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsViewTabTypeWApi.GetObjLstByRange = function(objRangePara)  
{
var strAction = "GetObjLstByRange";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = stuRangePara_js_1.stuRangePara.GetMapParam(objRangePara);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objRangePara,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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

 /// <summary>
 /// 从缓存中获取分页对象列表.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页参数结构</param>
 /// <returns>对象列表</returns>
clsViewTabTypeWApi.GetObjLstByPager_Cache =  async function(objPagerPara) {
var arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_Cache();
var arrViewTabType_Sel = arrViewTabTypeObjLst_Cache.filter(x => true);
var obj_Cond = JSON.parse(objPagerPara.WhereCond);
var dicFldComparisonOp = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
console.log("clsViewTabTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(obj_Cond);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = obj_Cond[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
var intStart = objPagerPara.PageSize* (objPagerPara.PageIndex - 1);
if (intStart <= 0) intStart = 0;
var intEnd = intStart + objPagerPara.PageSize;
if (objPagerPara.OrderBy.length>0) {
var sstrSplit = objPagerPara.OrderBy.split(" ");
var strSortType = "asc";
var strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
if (strSortType.toLowerCase() == "asc") {
arrViewTabType_Sel = arrViewTabType_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
}
else {
arrViewTabType_Sel = arrViewTabType_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
}
}
arrViewTabType_Sel = arrViewTabType_Sel.slice(intStart, intEnd);     
return arrViewTabType_Sel;
}
catch (e) {
var strMsg = "根据条件:[" +objPagerPara.WhereCond + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByPager_WA_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsViewTabTypeWApi.GetObjLstByPager_WA_Cache = function(objPagerPara)  
{
var strAction = "GetObjLstByPager_Cache";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = stuPagerPara_js_1.stuPagerPara.GetMapParam(objPagerPara);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objPagerPara,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsViewTabTypeWApi.GetObjLstByPager = function(objPagerPara)  
{
var strAction = "GetObjLstByPager";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = stuPagerPara_js_1.stuPagerPara.GetMapParam(objPagerPara);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objPagerPara,
success: function(data) {
if (data.ErrorId == 0)
{
var returnObjLst = JSON.parse(data.ReturnObjLst);
//console.log(returnObjLst);
resolve(returnObjLst);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 调用WebApi来删除记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_DelRecord)
 /// </summary>
 /// <param name = "strViewTabTypeId">关键字</param>
 /// <returns>获取删除的结果</returns>
clsViewTabTypeWApi.DelRecord = function(strViewTabTypeId)  
{
var strAction = "DelRecord";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
strUrl =  strUrl+ "/" +  strViewTabTypeId;
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strViewTabTypeId", strViewTabTypeId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "DELETE",
dataType: "json",
data: { "": strViewTabTypeId },
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据关键字列表按标志删除记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_DelRecordBySign)
 /// </summary>
 /// <param name = "arrViewTabTypeId">关键字列表</param>
 /// <returns>实际删除记录的个数</returns>
clsViewTabTypeWApi.DelRecordBySign = function(arrViewTabTypeId) 
{
var strAction = "DelRecordBySign";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrViewTabTypeId },
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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

 /// <summary>
 /// 根据关键字列表按标志恢复记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_UnDelRecordBySign)
 /// </summary>
 /// <param name = "arrViewTabTypeId">关键字列表</param>
 /// <returns>实际恢复记录的个数</returns>
clsViewTabTypeWApi.UnDelRecordBySign = function(arrViewTabTypeId) 
{
var strAction = "UnDelRecordBySign";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrViewTabTypeId },
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_DelMultiRecord)
 /// </summary>
 /// <param name = "arrViewTabTypeId">关键字列表</param>
 /// <returns>实际删除记录的个数</returns>
clsViewTabTypeWApi.DelViewTabTypes = function(arrViewTabTypeId) 
{
var strAction = "DelViewTabTypes";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrViewTabTypeId },
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
clsViewTabTypeWApi.DelViewTabTypesByCond = function(strWhereCond) 
{
var strAction = "DelViewTabTypesByCond";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"":strWhereCond},
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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

 /// <summary>
 /// 调用WebApi来添加记录，数据传递使用JSON串
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsViewTabTypeWApi.AddNewRecordWithMaxId = function(objViewTabTypeEN) 
{
var strMsg = "";
var strAction = "AddNewRecordWithMaxId";
var objViewTabTypeEN_Sim = clsViewTabTypeBL_js_1.clsViewTabTypeBL.GetSimObjFromObj(objViewTabTypeEN);
 //var strJSON = JSON.stringify(objViewTabTypeEN_Sim);
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objViewTabTypeEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 把所给的关键字列表相关的记录移顶
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GoTop)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsViewTabTypeWApi.GoTop = function(objOrderByData) 
{
var strMsg = "";
var strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objViewTabTypeEN_Sim);
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objOrderByData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 把所给的关键字列表相关的记录上移
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_UpMove)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsViewTabTypeWApi.UpMove = function(objOrderByData) 
{
var strMsg = "";
var strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objViewTabTypeEN_Sim);
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objOrderByData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 把所给的关键字列表相关的记录下移
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_DownMove)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsViewTabTypeWApi.DownMove = function(objOrderByData)
{
var strMsg = "";
var strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objViewTabTypeEN_Sim);
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objOrderByData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 把所给的关键字列表相关的记录移底
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GoBottom)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsViewTabTypeWApi.GoBottom = function(objOrderByData) 
{
var strMsg = "";
var strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objViewTabTypeEN_Sim);
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objOrderByData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 把列表记录重序
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_ReOrder)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsViewTabTypeWApi.ReOrder = function(objOrderByData) 
{
var strMsg = "";
var strAction = "ReOrder";
 //var strJSON = JSON.stringify(objViewTabTypeEN_Sim);
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objOrderByData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 调用WebApi来添加记录，数据传递使用JSON串
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_AddNewRecord)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsViewTabTypeWApi.AddNewRecord = function(objViewTabTypeEN) 
{
var strMsg = "";
var strAction = "AddNewRecord";
if (objViewTabTypeEN.ViewTabTypeId === null || objViewTabTypeEN.ViewTabTypeId === "")
{
strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
var objViewTabTypeEN_Sim = clsViewTabTypeBL_js_1.clsViewTabTypeBL.GetSimObjFromObj(objViewTabTypeEN);
 //var strJSON = JSON.stringify(objViewTabTypeEN_Sim);
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objViewTabTypeEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
clsViewTabTypeWApi.AddNewRecordWithReturnKey = function(objViewTabTypeEN) 
{
var strAction = "AddNewRecordWithReturnKey";
var objViewTabTypeEN_Sim = clsViewTabTypeBL_js_1.clsViewTabTypeBL.GetSimObjFromObj(objViewTabTypeEN);
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objViewTabTypeEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnStr);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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

 /// <summary>
 /// 调用WebApi来修改记录，数据传递使用JSON串
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_UpdateRecord)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要添加的对象</param>
 /// <returns>获取修改是否成功？</returns>
clsViewTabTypeWApi.UpdateRecord = function(objViewTabTypeEN)  
{
var strMsg = "";
var strAction = "UpdateRecord";
 if (objViewTabTypeEN.sf_UpdFldSetStr === null || objViewTabTypeEN.sf_UpdFldSetStr === "")
{
strMsg = "对象(关键字: " + objViewTabTypeEN.ViewTabTypeId + ")的【修改字段集】为空，不能修改!";
 throw strMsg;
 }
var objViewTabTypeEN_Sim = clsViewTabTypeBL_js_1.clsViewTabTypeBL.GetSimObjFromObj(objViewTabTypeEN);
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objViewTabTypeEN_Sim,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件来修改记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_UpdateWithCondition)
 /// </summary>
 /// <param name = "objViewTabTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
clsViewTabTypeWApi.UpdateWithCondition = function(objViewTabTypeEN, strWhereCond ) 
{
var strAction = "UpdateWithCondition";
 if (objViewTabTypeEN.sf_UpdFldSetStr === null || objViewTabTypeEN.sf_UpdFldSetStr === "")
{
var strMsg = "对象(关键字:" + objViewTabTypeEN.ViewTabTypeId + ")的【修改字段集】为空，不能修改!";
 throw new Error(strMsg);
 }
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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

 /// <summary>
 /// 根据条件获取是否存在相应的记录？
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否存在记录？</returns>
clsViewTabTypeWApi.IsExistRecord = function(strWhereCond)  
{
var strAction = "IsExistRecord";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件对象, 从缓存的对象列表中获取子集.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExistRecord_Cache)
 /// </summary>
 /// <param name = "objstrViewTabTypeId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsViewTabTypeWApi.IsExistRecord_Cache =  async function(objViewTabType_Cond) {
var objViewTabType_Sim = clsViewTabTypeBL_js_1.clsViewTabTypeBL.GetSimObjFromObj(objViewTabType_Cond);
var arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_Cache();
var arrViewTabType_Sel = arrViewTabTypeObjLst_Cache.filter(x => true);
if (objViewTabType_Sim.sf_FldComparisonOp == null || objViewTabType_Sim.sf_FldComparisonOp == "") return arrViewTabType_Sel.length>0?true:false;
var dicFldComparisonOp = JSON.parse(objViewTabType_Sim.sf_FldComparisonOp);
console.log("clsViewTabTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objViewTabType_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objViewTabType_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
if (arrViewTabType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objViewTabType_Sim) + "]判断是否存在不成功!";
throw new Error(strMsg);
}
return false;
};

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExist)
 /// </summary>
 /// <param name = "strViewTabTypeId">关键字</param>
 /// <returns>是否存在?存在返回True</returns>
clsViewTabTypeWApi.IsExist = function(strViewTabTypeId) 
{
//检测记录是否存在
var strAction = "IsExist";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("ViewTabTypeId", strViewTabTypeId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnBool);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
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

 /// <summary>
 /// 根据关键字判断是否存在记录, 从本地缓存中判断.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExist_Cache)
 /// </summary>
 /// <param name = "strViewTabTypeId">所给的关键字</param>
 /// <returns>对象</returns>
clsViewTabTypeWApi.IsExist_Cache = async function(strViewTabTypeId) {
var arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_Cache();
var obj = new clsViewTabTypeEN_js_1.clsViewTabTypeEN();
try
{
var arrViewTabType_Sel = arrViewTabTypeObjLst_Cache.filter(x => x.ViewTabTypeId == strViewTabTypeId);
var objViewTabType;
if (arrViewTabType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e)
{
var strMsg = "根据关键字:[" + strViewTabTypeId  + "]判断是否存在不成功!";
alert(strMsg);
}
return false;
};

 /// <summary>
 /// 获取某一条件的记录数
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>获取某一条件的记录数</returns>
clsViewTabTypeWApi.GetRecCountByCond = function(strWhereCond)  
{
var strAction = "GetRecCountByCond";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strWhereCond", strWhereCond);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
console.log('GetRecCountByCond:strData:');
console.log(strData);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnInt);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据条件对象, 从缓存的对象列表中获取记录数.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetRecCountByCond_Cache)
 /// </summary>
 /// <param name = "objViewTabType_Cond">条件对象</param>
 /// <returns>对象列表记录数</returns>
clsViewTabTypeWApi.GetRecCountByCond_Cache =  async function(objViewTabType_Cond) {
var objViewTabType_Sim = clsViewTabTypeBL_js_1.clsViewTabTypeBL.GetSimObjFromObj(objViewTabType_Cond);
var arrViewTabTypeObjLst_Cache = await clsViewTabTypeWApi.GetObjLst_Cache();
var arrViewTabType_Sel = arrViewTabTypeObjLst_Cache.filter(x => true);
if (objViewTabType_Sim.sf_FldComparisonOp == null || objViewTabType_Sim.sf_FldComparisonOp == "") return arrViewTabType_Sel.length;
var dicFldComparisonOp = JSON.parse(objViewTabType_Sim.sf_FldComparisonOp);
console.log("clsViewTabTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objViewTabType_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objViewTabType_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrViewTabType_Sel = arrViewTabType_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrViewTabType_Sel.length;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objViewTabType_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return 0;
};

 /// <summary>
 /// 获取表的最大关键字
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetMaxStrId)
 /// </summary>
 /// <returns>获取表的最大关键字</returns>
clsViewTabTypeWApi.GetMaxStrId = function()  
{
var strAction = "GetMaxStrId";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnStr);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetMaxStrIdByPrefix)
 /// </summary>
 /// <param name = "mapParam">参数列表</param>
 /// <returns>获取当前表关键字值的最大值</returns>
clsViewTabTypeWApi.GetMaxStrIdByPrefix = function(strPrefix)  
{
var strAction = "GetMaxStrIdByPrefix";
let strUrl = this.GetWebApiUrl(clsViewTabTypeWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strPrefix", strPrefix);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "GET",
dataType: "json",
data: strData,
success: function(data) {
if (data.ErrorId == 0)
{
resolve(data.ReturnStr);
}
else
{
console.log(data.ErrorMsg);
reject(data.ErrorMsg);
}
},
error: function(result) {
console.log(result);
console.log(JSON.stringify(result));
if (result.statusText == "error")
{
var strInfo = "网络错误！访问地址:" + strUrl + "不成功！";
reject(strInfo);
}
else
{
reject(result.statusText);
}
}
});
});
};

 /// <summary>
 /// 获取WebApi的地址
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetWebApiUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
clsViewTabTypeWApi.GetWebApiUrl = function(strController, strAction) {
var strServiceUrl;
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
strServiceUrl = "http://" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort+ "/" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx+ "/" + strController+ "/" + strAction;
}
else {
strServiceUrl = "http://" +  clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local+ "/" +  clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx+ "/" + strController+ "/" + strAction;
}
return strServiceUrl;
}

/// <summary>
/// 为下拉框获取数据,从表:[ViewTabType]中获取
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_DdlBind_Cache)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
clsViewTabTypeWApi.BindDdl_ViewTabTypeId_Cache2 = function(strDdlName, objViewTabType_Cond) {
//var strWhereCond = " 1 =1 ";
var objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
var strMsg = "下拉框：" + strDdlName  + " 不存在！";
alert(strMsg);
throw (strMsg);
}
return new Promise((resolve, reject) => {
try
{
var arrObjLst_Sel = clsViewTabTypeWApi.GetSubObjLst_Cache(objViewTabType_Cond);
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsViewTabTypeEN_js_1.clsViewTabTypeEN.con_ViewTabTypeId, clsViewTabTypeEN_js_1.clsViewTabTypeEN.con_ViewTabTypeName, "界面表类型");
console.log("完成BindDdl_ViewTabTypeId!");
}
catch (e)
{
var strMsg = "使用缓存对象列表绑定下拉框出错," +e + ".";
alert(strMsg);
}
});
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_InitListCache)
 /// </summary>
clsViewTabTypeWApi.InitListCache = function() 
{
//初始化列表缓存
//检查缓存刷新机制
var strMsg = "";
if (clsViewTabTypeWApi.objCommFun4BL == null)
{
strMsg = "类clsViewTabTypeWApi没有刷新缓存机制(clsViewTabTypeWApi.objCommFun4BL == null), 请联系程序员！(from " + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction() + ")";
throw new Error(strMsg);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_ReFreshCache)
 /// </summary>
clsViewTabTypeWApi.ReFreshCache = function()
{
if (clsViewTabTypeWApi.objCommFun4BL != null) 
{
 var strMsg = "刷新缓存成功！(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction();
console.log(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strKey = clsViewTabTypeEN_js_1.clsViewTabTypeEN._CurrTabName;
switch (clsViewTabTypeWApi.CacheModeId)
{
case "04"://sessionStorage
sessionStorage.removeItem(strKey);
break;
case "03"://localStorage
localStorage.removeItem(strKey);
break;
case "02"://ClientCache
CacheHelper_js_1.CacheHelper.Remove(strKey);
break;
default:
CacheHelper_js_1.CacheHelper.Remove(strKey);
break;
}
clsViewTabTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_ReFreshThisCache)
 /// </summary>
clsViewTabTypeWApi. ReFreshThisCache = function()
{
var strMsg = "";
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
var strKey = clsViewTabTypeEN_js_1.clsViewTabTypeEN._CurrTabName;
switch (clsViewTabTypeWApi.CacheModeId)
{
case "04"://sessionStorage
sessionStorage.removeItem(strKey);
break;
case "03"://localStorage
localStorage.removeItem(strKey);
break;
case "02"://ClientCache
CacheHelper_js_1.CacheHelper.Remove(strKey);
break;
default:
CacheHelper_js_1.CacheHelper.Remove(strKey);
break;
}
strMsg = "刷新缓存成功！(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction();
console.log(strMsg);
}
else
{
strMsg = "刷新缓存已经关闭。(clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == false)(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()+ ")";
console.log(strMsg);
}
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
clsViewTabTypeWApi.BindDdl_ViewTabTypeId_Cache = async function(strDdlName, objViewTabType_Cond)
{
var objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
var strMsg = "下拉框：" + strDdlName  + " 不存在！";
alert(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
console.log("开始：BindDdl_ViewTabTypeId_Cache");
var arrObjLst_Sel = await clsViewTabTypeWApi.GetSubObjLst_Cache(objViewTabType_Cond);
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsViewTabTypeEN_js_1.clsViewTabTypeEN.con_ViewTabTypeId, clsViewTabTypeEN_js_1.clsViewTabTypeEN.con_ViewTabTypeName, "界面表类型");
}
clsViewTabTypeWApi.mstrController = "ViewTabTypeApi";
clsViewTabTypeWApi.CacheModeId = "03"; //localStorage
return clsViewTabTypeWApi;
}());
exports.clsViewTabTypeWApi = clsViewTabTypeWApi;
});