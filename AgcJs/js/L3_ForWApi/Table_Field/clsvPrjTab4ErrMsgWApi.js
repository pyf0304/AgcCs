
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4ErrMsgWApi
 表名:vPrjTab4ErrMsg(00050206)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:11
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsvPrjTab4ErrMsgEN.js","clscommonfunc4web","clsstacktrace","../../L2_BLL/Table_Field/clsvPrjTab4ErrMsgBL.js","tzdictionary","clssyspara4webapi","../../PubFun/stuTopPara.js","../../PubFun/stuRangePara.js","../../PubFun/stuPagerPara.js","cachehelper","clsfldcomparisonobj","../../L3_ForWApi/Table_Field/clsPrjTabWApi.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvPrjTab4ErrMsgEN_js_1 = require("../../L0_Entity/Table_Field/clsvPrjTab4ErrMsgEN.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsvPrjTab4ErrMsgBL_js_1 = require("../../L2_BLL/Table_Field/clsvPrjTab4ErrMsgBL.js");
var Dictionary_js_1 = require("tzdictionary");
var clsSysPara4WebApi_js_1 = require("clssyspara4webapi");
var stuTopPara_js_1 = require("../../PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");
var clsPrjTabWApi_js_1 = require("../../L3_ForWApi/Table_Field/clsPrjTabWApi.js");

 /// <summary>
 /// vPrjTab4ErrMsg(vPrjTab4ErrMsg)
 /// (AutoGCLib.WA_AccessRJ4JavaScript:GeneCode)
 /// </summary>
var ResponseData;
var clsvPrjTab4ErrMsgWApi = /** @class */ (function() {
function clsvPrjTab4ErrMsgWApi(pobjvPrjTab4ErrMsgEN)
{
this.objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN();
this.objvPrjTab4ErrMsgEN = pobjvPrjTab4ErrMsgEN;
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">关键字</param>
 /// <returns>对象</returns>
clsvPrjTab4ErrMsgWApi.GetObjByTabId = function(strTabId)  
{
var strAction = "GetObjByTabId";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("TabId", strTabId);
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>对象</returns>
clsvPrjTab4ErrMsgWApi.GetObjByTabId_Cache = async function(strTabId,strPrjId) {
var arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_Cache(strPrjId);
var obj = new clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN();
try
{
var arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsgObjLst_Cache.filter(x => x.TabId == strTabId);
var objvPrjTab4ErrMsg;
if (arrvPrjTab4ErrMsg_Sel.length > 0)
{
objvPrjTab4ErrMsg = arrvPrjTab4ErrMsg_Sel[0];
return objvPrjTab4ErrMsg;
}
else
{
return obj;
}
}
catch (e)
{
var strMsg = "根据关键字:[" + strTabId  + "]获取相应的对象不成功!";
alert(strMsg);
}
return obj;
};

 /// <summary>
 /// 根据关键字获取相应的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strTabId">关键字</param>
 /// <returns>对象</returns>
clsvPrjTab4ErrMsgWApi.GetObjByTabId_WA_Cache = function(strTabId, strPrjId)  
{
var strAction = "GetObjByTabId_Cache";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("TabId", strTabId);
mapParam.add("PrjId", strPrjId);
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
clsvPrjTab4ErrMsgWApi.GetFirstID = function(strWhereCond)  
{
var strAction = "GetFirstID";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
clsvPrjTab4ErrMsgWApi.GetFirstObj = function(strWhereCond)  
{
var strAction = "GetFirstObj";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
clsvPrjTab4ErrMsgWApi.GetObjLst_Cache = async function(strPrjId)
{
var arrvPrjTab4ErrMsgObjLst_Cache;
switch (clsvPrjTab4ErrMsgWApi.CacheModeId)
{
case "04"://sessionStorage
arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_sessionStorage(strPrjId);
break;
case "03"://localStorage
arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_localStorage(strPrjId);
break;
case "02"://ClientCache
arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_ClientCache(strPrjId);
break;
default:
arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_ClientCache(strPrjId);
break;
}
return arrvPrjTab4ErrMsgObjLst_Cache;
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_ClientCache)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsvPrjTab4ErrMsgWApi.GetObjLst_ClientCache = async function(strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
clsvPrjTab4ErrMsgWApi.InitListCache(); 
strWhereCond = "PrjId='" +  strPrjId + "'";
var strKey =   clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN._CurrTabName+ "_" +  strPrjId;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper_js_1.CacheHelper.Exsits(strKey))
{
//缓存存在，直接取出返回
var arrvPrjTab4ErrMsgObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
return arrvPrjTab4ErrMsgObjLst_Cache;
}
try
{
const responseText = await clsvPrjTab4ErrMsgWApi.GetObjLst(strWhereCond);
var arrvPrjTab4ErrMsgObjLst = responseText;
CacheHelper_js_1.CacheHelper.Add(strKey, arrvPrjTab4ErrMsgObjLst);
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrvPrjTab4ErrMsgObjLst.length+ " !";
console.log(strInfo);
return arrvPrjTab4ErrMsgObjLst;
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
clsvPrjTab4ErrMsgWApi.GetObjLst_localStorage = async function(strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
clsvPrjTab4ErrMsgWApi.InitListCache(); 
strWhereCond = "PrjId='" +  strPrjId + "'";
var strKey =   clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN._CurrTabName+ "_" +  strPrjId;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (localStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = localStorage.getItem(strKey);
var arrvPrjTab4ErrMsgObjLst_Cache = JSON.parse(strTempObjLst);
return arrvPrjTab4ErrMsgObjLst_Cache;
}
try
{
const responseText = await clsvPrjTab4ErrMsgWApi.GetObjLst(strWhereCond);
var arrvPrjTab4ErrMsgObjLst = responseText;
localStorage.setItem(strKey, JSON.stringify(arrvPrjTab4ErrMsgObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrvPrjTab4ErrMsgObjLst.length+ " !";
console.log(strInfo);
return arrvPrjTab4ErrMsgObjLst;
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
clsvPrjTab4ErrMsgWApi.GetObjLst_sessionStorage = async function(strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
clsvPrjTab4ErrMsgWApi.InitListCache(); 
strWhereCond = "PrjId='" +  strPrjId + "'";
var strKey =   clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN._CurrTabName+ "_" +  strPrjId;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (sessionStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = sessionStorage.getItem(strKey);
var arrvPrjTab4ErrMsgObjLst_Cache = JSON.parse(strTempObjLst);
return arrvPrjTab4ErrMsgObjLst_Cache;
}
try
{
const responseText = await clsvPrjTab4ErrMsgWApi.GetObjLst(strWhereCond);
var arrvPrjTab4ErrMsgObjLst = responseText;
sessionStorage.setItem(strKey, JSON.stringify(arrvPrjTab4ErrMsgObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrvPrjTab4ErrMsgObjLst.length+ " !";
console.log(strInfo);
return arrvPrjTab4ErrMsgObjLst;
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
clsvPrjTab4ErrMsgWApi.GetObjLst_WA_Cache = function()  
{
var strAction = "GetObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
 /// <param name = "objstrTabId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsvPrjTab4ErrMsgWApi.GetSubObjLst_Cache =  async function(objvPrjTab4ErrMsg_Cond,strPrjId) {
var objvPrjTab4ErrMsg_Sim = clsvPrjTab4ErrMsgBL_js_1.clsvPrjTab4ErrMsgBL.GetSimObjFromObj(objvPrjTab4ErrMsg_Cond);
var arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_Cache(strPrjId);
var arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsgObjLst_Cache.filter(x => true);
if (objvPrjTab4ErrMsg_Sim.sf_FldComparisonOp == null || objvPrjTab4ErrMsg_Sim.sf_FldComparisonOp == "") return arrvPrjTab4ErrMsg_Sel;
var dicFldComparisonOp = JSON.parse(objvPrjTab4ErrMsg_Sim.sf_FldComparisonOp);
console.log("clsvPrjTab4ErrMsgWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvPrjTab4ErrMsg_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objvPrjTab4ErrMsg_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrvPrjTab4ErrMsg_Sel;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objvPrjTab4ErrMsg_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetSubObjLst_WA_Cache)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsg_Cond">条件对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsvPrjTab4ErrMsgWApi.GetSubObjLst_WA_Cache = function(objvPrjTab4ErrMsg_Cond)  
{
var strAction = "GetSubObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
var objvPrjTab4ErrMsgEN_Sim = clsvPrjTab4ErrMsgBL_js_1.clsvPrjTab4ErrMsgBL.GetSimObjFromObj(objvPrjTab4ErrMsg_Cond);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objvPrjTab4ErrMsgEN_Sim,
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
 /// <param name = "arrTabId">关键字列表</param>
 /// <returns>对象列表</returns>
clsvPrjTab4ErrMsgWApi.GetObjLstByTabIdLst = function(arrTabId)  
{
var strAction = "GetObjLstByTabIdLst";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrTabId },
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
 /// <param name = "arrstrTabIdLst">关键字列表</param>
 /// <returns>对象列表</returns>
clsvPrjTab4ErrMsgWApi.GetObjLstByTabIdLst_Cache =  async function(arrTabIdLst,strPrjId) {
try
{
var arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_Cache(strPrjId);
var arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsgObjLst_Cache.filter(x => arrTabIdLst.indexOf(x.TabId)>-1);
return arrvPrjTab4ErrMsg_Sel;
}
catch (e)
{
var strMsg = "根据关键字:[" + arrTabIdLst.join(",")  + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "arrTabId">关键字列表</param>
 /// <returns>对象列表</returns>
clsvPrjTab4ErrMsgWApi.GetObjLstByTabIdLst_WA_Cache = function(arrTabId, strPrjId)  
{
var strAction = "GetObjLstByTabIdLst_Cache";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("PrjId", strPrjId);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrTabId },
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
clsvPrjTab4ErrMsgWApi.GetObjLst = function(strWhereCond)  
{
var strAction = "GetObjLst";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
clsvPrjTab4ErrMsgWApi.GetTopObjLst = function(objTopPara)  
{
var strAction = "GetTopObjLst";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
clsvPrjTab4ErrMsgWApi.GetObjLstByRange = function(objRangePara)  
{
var strAction = "GetObjLstByRange";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
clsvPrjTab4ErrMsgWApi.GetObjLstByPager_Cache =  async function(objPagerPara,strPrjId) {
var arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_Cache(strPrjId);
var arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsgObjLst_Cache.filter(x => true);
var obj_Cond = JSON.parse(objPagerPara.WhereCond);
var dicFldComparisonOp = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
console.log("clsvPrjTab4ErrMsgWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
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
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] <= strValue);
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
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
}
else {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
}
}
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.slice(intStart, intEnd);     
return arrvPrjTab4ErrMsg_Sel;
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
clsvPrjTab4ErrMsgWApi.GetObjLstByPager_WA_Cache = function(objPagerPara)  
{
var strAction = "GetObjLstByPager_Cache";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
clsvPrjTab4ErrMsgWApi.GetObjLstByPager = function(objPagerPara)  
{
var strAction = "GetObjLstByPager";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
 /// 根据条件获取是否存在相应的记录？
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件</param>
 /// <returns>是否存在记录？</returns>
clsvPrjTab4ErrMsgWApi.IsExistRecord = function(strWhereCond)  
{
var strAction = "IsExistRecord";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
 /// <param name = "objstrTabId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsvPrjTab4ErrMsgWApi.IsExistRecord_Cache =  async function(objvPrjTab4ErrMsg_Cond,strPrjId) {
var objvPrjTab4ErrMsg_Sim = clsvPrjTab4ErrMsgBL_js_1.clsvPrjTab4ErrMsgBL.GetSimObjFromObj(objvPrjTab4ErrMsg_Cond);
var arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_Cache(strPrjId);
var arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsgObjLst_Cache.filter(x => true);
if (objvPrjTab4ErrMsg_Sim.sf_FldComparisonOp == null || objvPrjTab4ErrMsg_Sim.sf_FldComparisonOp == "") return arrvPrjTab4ErrMsg_Sel.length>0?true:false;
var dicFldComparisonOp = JSON.parse(objvPrjTab4ErrMsg_Sim.sf_FldComparisonOp);
console.log("clsvPrjTab4ErrMsgWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvPrjTab4ErrMsg_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objvPrjTab4ErrMsg_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
if (arrvPrjTab4ErrMsg_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objvPrjTab4ErrMsg_Sim) + "]判断是否存在不成功!";
throw new Error(strMsg);
}
return false;
};

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExist)
 /// </summary>
 /// <param name = "strTabId">关键字</param>
 /// <returns>是否存在?存在返回True</returns>
clsvPrjTab4ErrMsgWApi.IsExist = function(strTabId) 
{
//检测记录是否存在
var strAction = "IsExist";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("TabId", strTabId);
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>对象</returns>
clsvPrjTab4ErrMsgWApi.IsExist_Cache = async function(strTabId,strPrjId) {
var arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_Cache(strPrjId);
var obj = new clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN();
try
{
var arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsgObjLst_Cache.filter(x => x.TabId == strTabId);
var objvPrjTab4ErrMsg;
if (arrvPrjTab4ErrMsg_Sel.length > 0)
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
var strMsg = "根据关键字:[" + strTabId  + "]判断是否存在不成功!";
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
clsvPrjTab4ErrMsgWApi.GetRecCountByCond = function(strWhereCond)  
{
var strAction = "GetRecCountByCond";
let strUrl = this.GetWebApiUrl(clsvPrjTab4ErrMsgWApi.mstrController, strAction);
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
 /// <param name = "objvPrjTab4ErrMsg_Cond">条件对象</param>
 /// <returns>对象列表记录数</returns>
clsvPrjTab4ErrMsgWApi.GetRecCountByCond_Cache =  async function(objvPrjTab4ErrMsg_Cond,strPrjId) {
var objvPrjTab4ErrMsg_Sim = clsvPrjTab4ErrMsgBL_js_1.clsvPrjTab4ErrMsgBL.GetSimObjFromObj(objvPrjTab4ErrMsg_Cond);
var arrvPrjTab4ErrMsgObjLst_Cache = await clsvPrjTab4ErrMsgWApi.GetObjLst_Cache(strPrjId);
var arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsgObjLst_Cache.filter(x => true);
if (objvPrjTab4ErrMsg_Sim.sf_FldComparisonOp == null || objvPrjTab4ErrMsg_Sim.sf_FldComparisonOp == "") return arrvPrjTab4ErrMsg_Sel.length;
var dicFldComparisonOp = JSON.parse(objvPrjTab4ErrMsg_Sim.sf_FldComparisonOp);
console.log("clsvPrjTab4ErrMsgWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objvPrjTab4ErrMsg_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objvPrjTab4ErrMsg_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrvPrjTab4ErrMsg_Sel = arrvPrjTab4ErrMsg_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrvPrjTab4ErrMsg_Sel.length;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objvPrjTab4ErrMsg_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return 0;
};

 /// <summary>
 /// 获取WebApi的地址
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetWebApiUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
clsvPrjTab4ErrMsgWApi.GetWebApiUrl = function(strController, strAction) {
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
/// 为下拉框获取数据,从表:[vPrjTab4ErrMsg]中获取
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_DdlBind_Cache)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
clsvPrjTab4ErrMsgWApi.BindDdl_TabId_Cache2 = function(strDdlName, objvPrjTab4ErrMsg_Cond, strPrjId) {
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
var arrObjLst_Sel = clsvPrjTab4ErrMsgWApi.GetSubObjLst_Cache(objvPrjTab4ErrMsg_Cond,strPrjId);
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN.con_TabId, clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN.con_TabName, "vPrjTab4ErrMsg");
console.log("完成BindDdl_TabId!");
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
clsvPrjTab4ErrMsgWApi.InitListCache = function() 
{
//初始化列表缓存
if (clsPrjTabWApi_js_1.clsPrjTabWApi.objCommFun4BL == null)
{
strMsg = "类clsPrjTabWApi没有刷新缓存机制(clsPrjTabWApi.objCommFun4BL == null), 请联系程序员！(from {clsStackTrace.GetCurrClassFunction()})";
throw (strMsg);
}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_ReFreshThisCache)
 /// </summary>
clsvPrjTab4ErrMsgWApi. ReFreshThisCache = function(strPrjId)
{
var strMsg = "";
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
var strKey = clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN._CurrTabName + "_" + strPrjId ;
switch (clsvPrjTab4ErrMsgWApi.CacheModeId)
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
clsvPrjTab4ErrMsgWApi.BindDdl_TabId_Cache = async function(strDdlName, objvPrjTab4ErrMsg_Cond, strPrjId)
{
var objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
var strMsg = "下拉框：" + strDdlName  + " 不存在！";
alert(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
console.log("开始：BindDdl_TabId_Cache");
var arrObjLst_Sel = await clsvPrjTab4ErrMsgWApi.GetSubObjLst_Cache(objvPrjTab4ErrMsg_Cond, strPrjId);
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN.con_TabId, clsvPrjTab4ErrMsgEN_js_1.clsvPrjTab4ErrMsgEN.con_TabName, "vPrjTab4ErrMsg");
}
clsvPrjTab4ErrMsgWApi.mstrController = "vPrjTab4ErrMsgApi";
clsvPrjTab4ErrMsgWApi.CacheModeId = ""; //
return clsvPrjTab4ErrMsgWApi;
}());
exports.clsvPrjTab4ErrMsgWApi = clsvPrjTab4ErrMsgWApi;
});