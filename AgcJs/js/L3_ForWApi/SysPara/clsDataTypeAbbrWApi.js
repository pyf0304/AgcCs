
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataTypeAbbrWApi
 表名:DataTypeAbbr(00050023)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:33
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsDataTypeAbbrEN.js","../../L2_BLL/SysPara/clsCommFun4WA4DataTypeAbbr.js","clscommonfunc4web","clsstacktrace","../../L2_BLL/SysPara/clsDataTypeAbbrBL.js","tzdictionary","clssyspara4webapi","../../PubFun/stuTopPara.js","../../PubFun/stuRangePara.js","../../PubFun/stuPagerPara.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsDataTypeAbbrEN_js_1 = require("../../L0_Entity/SysPara/clsDataTypeAbbrEN.js");
var clsCommFun4WA4DataTypeAbbr_js_1 = require("../../L2_BLL/SysPara/clsCommFun4WA4DataTypeAbbr.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsDataTypeAbbrBL_js_1 = require("../../L2_BLL/SysPara/clsDataTypeAbbrBL.js");
var Dictionary_js_1 = require("tzdictionary");
var clsSysPara4WebApi_js_1 = require("clssyspara4webapi");
var stuTopPara_js_1 = require("../../PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");

 /// <summary>
 /// 数据类型(DataTypeAbbr)
 /// (AutoGCLib.WA_AccessRJ4JavaScript:GeneCode)
 /// </summary>
var ResponseData;
var clsDataTypeAbbrWApi = /** @class */ (function() {
function clsDataTypeAbbrWApi(pobjDataTypeAbbrEN)
{
this.objDataTypeAbbrEN = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
this.objDataTypeAbbrEN = pobjDataTypeAbbrEN;
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDataTypeId">关键字</param>
 /// <returns>对象</returns>
clsDataTypeAbbrWApi.GetObjByDataTypeId = function(strDataTypeId)  
{
var strAction = "GetObjByDataTypeId";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("DataTypeId", strDataTypeId);
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
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <returns>对象</returns>
clsDataTypeAbbrWApi.GetObjByDataTypeId_Cache = async function(strDataTypeId) {
var arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_Cache();
var obj = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
try
{
var arrDataTypeAbbr_Sel = arrDataTypeAbbrObjLst_Cache.filter(x => x.DataTypeId == strDataTypeId);
var objDataTypeAbbr;
if (arrDataTypeAbbr_Sel.length > 0)
{
objDataTypeAbbr = arrDataTypeAbbr_Sel[0];
return objDataTypeAbbr;
}
else
{
return obj;
}
}
catch (e)
{
var strMsg = "根据关键字:[" + strDataTypeId  + "]获取相应的对象不成功!";
alert(strMsg);
}
return obj;
};

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_SetCache)
 /// </summary>
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <returns>对象</returns>
clsDataTypeAbbrWApi.SetCache = function() {
clsDataTypeAbbrWApi.objCommFun4BL = new clsCommFun4WA4DataTypeAbbr_js_1.clsCommFun4WA4DataTypeAbbr();
 //把以下三行添加到clsPubFun.js中
//"../L3_ForWApi/SysPara/clsDataTypeAbbrWApi.js"
//var clsDataTypeAbbrWApi_js_1 = require("../L3_ForWApi/SysPara/clsDataTypeAbbrWApi.js");
//clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.SetCache();
};

 /// <summary>
 /// 根据关键字获取相应的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strDataTypeId">关键字</param>
 /// <returns>对象</returns>
clsDataTypeAbbrWApi.GetObjByDataTypeId_WA_Cache = function(strDataTypeId)  
{
var strAction = "GetObjByDataTypeId_Cache";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("DataTypeId", strDataTypeId);
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
clsDataTypeAbbrWApi.GetFirstID = function(strWhereCond)  
{
var strAction = "GetFirstID";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
clsDataTypeAbbrWApi.GetFirstObj = function(strWhereCond)  
{
var strAction = "GetFirstObj";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
clsDataTypeAbbrWApi.GetObjLst_Cache = async function() 
{
var arrDataTypeAbbrObjLst_Cache;
switch (clsDataTypeAbbrWApi.CacheModeId)
{
case "04"://sessionStorage
arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_localStorage();
break;
case "02"://ClientCache
arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_ClientCache();
break;
default:
arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_ClientCache();
break;
}
return arrDataTypeAbbrObjLst_Cache;
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_ClientCache)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsDataTypeAbbrWApi.GetObjLst_ClientCache = async function() 
{
//初始化列表缓存
var strWhereCond = "1=1";
clsDataTypeAbbrWApi.InitListCache(); 
var strKey = clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper_js_1.CacheHelper.Exsits(strKey))
{
//缓存存在，直接取出返回
var arrDataTypeAbbrObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
return arrDataTypeAbbrObjLst_Cache;
}
try
{
const responseText = await clsDataTypeAbbrWApi.GetObjLst(strWhereCond);
var arrDataTypeAbbrObjLst = responseText;
CacheHelper_js_1.CacheHelper.Add(strKey, arrDataTypeAbbrObjLst);
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrDataTypeAbbrObjLst.length+ " !";
console.log(strInfo);
return arrDataTypeAbbrObjLst;
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
clsDataTypeAbbrWApi.GetObjLst_localStorage = async function() 
{
//初始化列表缓存
var strWhereCond = "1=1";
clsDataTypeAbbrWApi.InitListCache(); 
var strKey = clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (localStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = localStorage.getItem(strKey);
var arrDataTypeAbbrObjLst_Cache = JSON.parse(strTempObjLst);
return arrDataTypeAbbrObjLst_Cache;
}
try
{
const responseText = await clsDataTypeAbbrWApi.GetObjLst(strWhereCond);
var arrDataTypeAbbrObjLst = responseText;
localStorage.setItem(strKey, JSON.stringify(arrDataTypeAbbrObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrDataTypeAbbrObjLst.length+ " !";
console.log(strInfo);
return arrDataTypeAbbrObjLst;
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
clsDataTypeAbbrWApi.GetObjLst_sessionStorage = async function() 
{
//初始化列表缓存
var strWhereCond = "1=1";
clsDataTypeAbbrWApi.InitListCache(); 
var strKey = clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (sessionStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = sessionStorage.getItem(strKey);
var arrDataTypeAbbrObjLst_Cache = JSON.parse(strTempObjLst);
return arrDataTypeAbbrObjLst_Cache;
}
try
{
const responseText = await clsDataTypeAbbrWApi.GetObjLst(strWhereCond);
var arrDataTypeAbbrObjLst = responseText;
sessionStorage.setItem(strKey, JSON.stringify(arrDataTypeAbbrObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrDataTypeAbbrObjLst.length+ " !";
console.log(strInfo);
return arrDataTypeAbbrObjLst;
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
clsDataTypeAbbrWApi.GetObjLst_WA_Cache = function()  
{
var strAction = "GetObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "objstrDataTypeId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsDataTypeAbbrWApi.GetSubObjLst_Cache =  async function(objDataTypeAbbr_Cond) {
var objDataTypeAbbr_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
var arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_Cache();
var arrDataTypeAbbr_Sel = arrDataTypeAbbrObjLst_Cache.filter(x => true);
if (objDataTypeAbbr_Sim.sf_FldComparisonOp == null || objDataTypeAbbr_Sim.sf_FldComparisonOp == "") return arrDataTypeAbbr_Sel;
var dicFldComparisonOp = JSON.parse(objDataTypeAbbr_Sim.sf_FldComparisonOp);
console.log("clsDataTypeAbbrWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objDataTypeAbbr_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objDataTypeAbbr_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrDataTypeAbbr_Sel;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objDataTypeAbbr_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetSubObjLst_WA_Cache)
 /// </summary>
 /// <param name = "objDataTypeAbbr_Cond">条件对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsDataTypeAbbrWApi.GetSubObjLst_WA_Cache = function(objDataTypeAbbr_Cond)  
{
var strAction = "GetSubObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objDataTypeAbbrEN_Sim,
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
 /// <param name = "arrDataTypeId">关键字列表</param>
 /// <returns>对象列表</returns>
clsDataTypeAbbrWApi.GetObjLstByDataTypeIdLst = function(arrDataTypeId)  
{
var strAction = "GetObjLstByDataTypeIdLst";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrDataTypeId },
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
 /// <param name = "arrstrDataTypeIdLst">关键字列表</param>
 /// <returns>对象列表</returns>
clsDataTypeAbbrWApi.GetObjLstByDataTypeIdLst_Cache =  async function(arrDataTypeIdLst) {
try
{
var arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_Cache();
var arrDataTypeAbbr_Sel = arrDataTypeAbbrObjLst_Cache.filter(x => arrDataTypeIdLst.indexOf(x.DataTypeId)>-1);
return arrDataTypeAbbr_Sel;
}
catch (e)
{
var strMsg = "根据关键字:[" + arrDataTypeIdLst.join(",")  + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "arrDataTypeId">关键字列表</param>
 /// <returns>对象列表</returns>
clsDataTypeAbbrWApi.GetObjLstByDataTypeIdLst_WA_Cache = function(arrDataTypeId)  
{
var strAction = "GetObjLstByDataTypeIdLst_Cache";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrDataTypeId },
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
clsDataTypeAbbrWApi.GetObjLst = function(strWhereCond)  
{
var strAction = "GetObjLst";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
clsDataTypeAbbrWApi.GetTopObjLst = function(objTopPara)  
{
var strAction = "GetTopObjLst";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
clsDataTypeAbbrWApi.GetObjLstByRange = function(objRangePara)  
{
var strAction = "GetObjLstByRange";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
clsDataTypeAbbrWApi.GetObjLstByPager_Cache =  async function(objPagerPara) {
var arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_Cache();
var arrDataTypeAbbr_Sel = arrDataTypeAbbrObjLst_Cache.filter(x => true);
var obj_Cond = JSON.parse(objPagerPara.WhereCond);
var dicFldComparisonOp = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
console.log("clsDataTypeAbbrWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
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
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] <= strValue);
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
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
}
else {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
}
}
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.slice(intStart, intEnd);     
return arrDataTypeAbbr_Sel;
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
clsDataTypeAbbrWApi.GetObjLstByPager_WA_Cache = function(objPagerPara)  
{
var strAction = "GetObjLstByPager_Cache";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
clsDataTypeAbbrWApi.GetObjLstByPager = function(objPagerPara)  
{
var strAction = "GetObjLstByPager";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "strDataTypeId">关键字</param>
 /// <returns>获取删除的结果</returns>
clsDataTypeAbbrWApi.DelRecord = function(strDataTypeId)  
{
var strAction = "DelRecord";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
strUrl =  strUrl+ "/" +  strDataTypeId;
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strDataTypeId", strDataTypeId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "DELETE",
dataType: "json",
data: { "": strDataTypeId },
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
 /// <param name = "arrDataTypeId">关键字列表</param>
 /// <returns>实际删除记录的个数</returns>
clsDataTypeAbbrWApi.DelRecordBySign = function(arrDataTypeId) 
{
var strAction = "DelRecordBySign";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrDataTypeId },
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
 /// <param name = "arrDataTypeId">关键字列表</param>
 /// <returns>实际恢复记录的个数</returns>
clsDataTypeAbbrWApi.UnDelRecordBySign = function(arrDataTypeId) 
{
var strAction = "UnDelRecordBySign";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrDataTypeId },
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
 /// <param name = "arrDataTypeId">关键字列表</param>
 /// <returns>实际删除记录的个数</returns>
clsDataTypeAbbrWApi.DelDataTypeAbbrs = function(arrDataTypeId) 
{
var strAction = "DelDataTypeAbbrs";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrDataTypeId },
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
clsDataTypeAbbrWApi.DelDataTypeAbbrsByCond = function(strWhereCond) 
{
var strAction = "DelDataTypeAbbrsByCond";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "objDataTypeAbbrEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsDataTypeAbbrWApi.AddNewRecordWithMaxId = function(objDataTypeAbbrEN) 
{
var strMsg = "";
var strAction = "AddNewRecordWithMaxId";
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbrEN);
 //var strJSON = JSON.stringify(objDataTypeAbbrEN_Sim);
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objDataTypeAbbrEN_Sim,
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
 /// <param name = "objDataTypeAbbrEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsDataTypeAbbrWApi.GoTop = function(objOrderByData) 
{
var strMsg = "";
var strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objDataTypeAbbrEN_Sim);
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "objDataTypeAbbrEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsDataTypeAbbrWApi.UpMove = function(objOrderByData) 
{
var strMsg = "";
var strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objDataTypeAbbrEN_Sim);
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "objDataTypeAbbrEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsDataTypeAbbrWApi.DownMove = function(objOrderByData)
{
var strMsg = "";
var strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objDataTypeAbbrEN_Sim);
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "objDataTypeAbbrEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsDataTypeAbbrWApi.GoBottom = function(objOrderByData) 
{
var strMsg = "";
var strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objDataTypeAbbrEN_Sim);
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "objDataTypeAbbrEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsDataTypeAbbrWApi.ReOrder = function(objOrderByData) 
{
var strMsg = "";
var strAction = "ReOrder";
 //var strJSON = JSON.stringify(objDataTypeAbbrEN_Sim);
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "objDataTypeAbbrEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsDataTypeAbbrWApi.AddNewRecord = function(objDataTypeAbbrEN) 
{
var strMsg = "";
var strAction = "AddNewRecord";
if (objDataTypeAbbrEN.DataTypeId === null || objDataTypeAbbrEN.DataTypeId === "")
{
strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbrEN);
 //var strJSON = JSON.stringify(objDataTypeAbbrEN_Sim);
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objDataTypeAbbrEN_Sim,
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
 /// <param name = "objDataTypeAbbrEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
clsDataTypeAbbrWApi.AddNewRecordWithReturnKey = function(objDataTypeAbbrEN) 
{
var strAction = "AddNewRecordWithReturnKey";
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbrEN);
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objDataTypeAbbrEN_Sim,
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
 /// <param name = "objDataTypeAbbrEN">需要添加的对象</param>
 /// <returns>获取修改是否成功？</returns>
clsDataTypeAbbrWApi.UpdateRecord = function(objDataTypeAbbrEN)  
{
var strMsg = "";
var strAction = "UpdateRecord";
 if (objDataTypeAbbrEN.sf_UpdFldSetStr === null || objDataTypeAbbrEN.sf_UpdFldSetStr === "")
{
strMsg = "对象(关键字: " + objDataTypeAbbrEN.DataTypeId + ")的【修改字段集】为空，不能修改!";
 throw strMsg;
 }
var objDataTypeAbbrEN_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbrEN);
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objDataTypeAbbrEN_Sim,
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
 /// <param name = "objDataTypeAbbrEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
clsDataTypeAbbrWApi.UpdateWithCondition = function(objDataTypeAbbrEN, strWhereCond ) 
{
var strAction = "UpdateWithCondition";
 if (objDataTypeAbbrEN.sf_UpdFldSetStr === null || objDataTypeAbbrEN.sf_UpdFldSetStr === "")
{
var strMsg = "对象(关键字:" + objDataTypeAbbrEN.DataTypeId + ")的【修改字段集】为空，不能修改!";
 throw new Error(strMsg);
 }
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
clsDataTypeAbbrWApi.IsExistRecord = function(strWhereCond)  
{
var strAction = "IsExistRecord";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "objstrDataTypeId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsDataTypeAbbrWApi.IsExistRecord_Cache =  async function(objDataTypeAbbr_Cond) {
var objDataTypeAbbr_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
var arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_Cache();
var arrDataTypeAbbr_Sel = arrDataTypeAbbrObjLst_Cache.filter(x => true);
if (objDataTypeAbbr_Sim.sf_FldComparisonOp == null || objDataTypeAbbr_Sim.sf_FldComparisonOp == "") return arrDataTypeAbbr_Sel.length>0?true:false;
var dicFldComparisonOp = JSON.parse(objDataTypeAbbr_Sim.sf_FldComparisonOp);
console.log("clsDataTypeAbbrWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objDataTypeAbbr_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objDataTypeAbbr_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
if (arrDataTypeAbbr_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objDataTypeAbbr_Sim) + "]判断是否存在不成功!";
throw new Error(strMsg);
}
return false;
};

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExist)
 /// </summary>
 /// <param name = "strDataTypeId">关键字</param>
 /// <returns>是否存在?存在返回True</returns>
clsDataTypeAbbrWApi.IsExist = function(strDataTypeId) 
{
//检测记录是否存在
var strAction = "IsExist";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("DataTypeId", strDataTypeId);
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
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <returns>对象</returns>
clsDataTypeAbbrWApi.IsExist_Cache = async function(strDataTypeId) {
var arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_Cache();
var obj = new clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN();
try
{
var arrDataTypeAbbr_Sel = arrDataTypeAbbrObjLst_Cache.filter(x => x.DataTypeId == strDataTypeId);
var objDataTypeAbbr;
if (arrDataTypeAbbr_Sel.length > 0)
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
var strMsg = "根据关键字:[" + strDataTypeId  + "]判断是否存在不成功!";
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
clsDataTypeAbbrWApi.GetRecCountByCond = function(strWhereCond)  
{
var strAction = "GetRecCountByCond";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
 /// <param name = "objDataTypeAbbr_Cond">条件对象</param>
 /// <returns>对象列表记录数</returns>
clsDataTypeAbbrWApi.GetRecCountByCond_Cache =  async function(objDataTypeAbbr_Cond) {
var objDataTypeAbbr_Sim = clsDataTypeAbbrBL_js_1.clsDataTypeAbbrBL.GetSimObjFromObj(objDataTypeAbbr_Cond);
var arrDataTypeAbbrObjLst_Cache = await clsDataTypeAbbrWApi.GetObjLst_Cache();
var arrDataTypeAbbr_Sel = arrDataTypeAbbrObjLst_Cache.filter(x => true);
if (objDataTypeAbbr_Sim.sf_FldComparisonOp == null || objDataTypeAbbr_Sim.sf_FldComparisonOp == "") return arrDataTypeAbbr_Sel.length;
var dicFldComparisonOp = JSON.parse(objDataTypeAbbr_Sim.sf_FldComparisonOp);
console.log("clsDataTypeAbbrWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objDataTypeAbbr_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objDataTypeAbbr_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrDataTypeAbbr_Sel = arrDataTypeAbbr_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrDataTypeAbbr_Sel.length;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objDataTypeAbbr_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return 0;
};

 /// <summary>
 /// 获取表的最大关键字
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetMaxStrId)
 /// </summary>
 /// <returns>获取表的最大关键字</returns>
clsDataTypeAbbrWApi.GetMaxStrId = function()  
{
var strAction = "GetMaxStrId";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
clsDataTypeAbbrWApi.GetMaxStrIdByPrefix = function(strPrefix)  
{
var strAction = "GetMaxStrIdByPrefix";
let strUrl = this.GetWebApiUrl(clsDataTypeAbbrWApi.mstrController, strAction);
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
clsDataTypeAbbrWApi.GetWebApiUrl = function(strController, strAction) {
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
/// 为下拉框获取数据,从表:[DataTypeAbbr]中获取
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_DdlBind_Cache)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
clsDataTypeAbbrWApi.BindDdl_DataTypeId_Cache2 = function(strDdlName, objDataTypeAbbr_Cond) {
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
var arrObjLst_Sel = clsDataTypeAbbrWApi.GetSubObjLst_Cache(objDataTypeAbbr_Cond);
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN.con_DataTypeId, clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN.con_DataTypeName, "数据类型");
console.log("完成BindDdl_DataTypeId!");
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
clsDataTypeAbbrWApi.InitListCache = function() 
{
//初始化列表缓存
//检查缓存刷新机制
var strMsg = "";
if (clsDataTypeAbbrWApi.objCommFun4BL == null)
{
strMsg = "类clsDataTypeAbbrWApi没有刷新缓存机制(clsDataTypeAbbrWApi.objCommFun4BL == null), 请联系程序员！(from " + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction() + ")";
throw new Error(strMsg);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_ReFreshCache)
 /// </summary>
clsDataTypeAbbrWApi.ReFreshCache = function()
{
if (clsDataTypeAbbrWApi.objCommFun4BL != null) 
{
 var strMsg = "刷新缓存成功！(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction();
console.log(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strKey = clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN._CurrTabName;
switch (clsDataTypeAbbrWApi.CacheModeId)
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
clsDataTypeAbbrWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_ReFreshThisCache)
 /// </summary>
clsDataTypeAbbrWApi. ReFreshThisCache = function()
{
var strMsg = "";
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
var strKey = clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN._CurrTabName;
switch (clsDataTypeAbbrWApi.CacheModeId)
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
clsDataTypeAbbrWApi.BindDdl_DataTypeId_Cache = async function(strDdlName, objDataTypeAbbr_Cond)
{
var objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
var strMsg = "下拉框：" + strDdlName  + " 不存在！";
alert(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
console.log("开始：BindDdl_DataTypeId_Cache");
var arrObjLst_Sel = await clsDataTypeAbbrWApi.GetSubObjLst_Cache(objDataTypeAbbr_Cond);
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN.con_DataTypeId, clsDataTypeAbbrEN_js_1.clsDataTypeAbbrEN.con_DataTypeName, "数据类型");
}
clsDataTypeAbbrWApi.mstrController = "DataTypeAbbrApi";
clsDataTypeAbbrWApi.CacheModeId = ""; //
return clsDataTypeAbbrWApi;
}());
exports.clsDataTypeAbbrWApi = clsDataTypeAbbrWApi;
});