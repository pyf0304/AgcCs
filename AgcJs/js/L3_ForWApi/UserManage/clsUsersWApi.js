
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersWApi
 表名:Users(00050001)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:12
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:用户管理
 模块英文名:UserManage
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
define(["require", "exports", "jquery", "../../L0_Entity/UserManage/clsUsersEN.js","../../L2_BLL/UserManage/clsCommFun4WA4Users.js","clscommonfunc4web","clsstacktrace","../../L2_BLL/UserManage/clsUsersBL.js","tzdictionary","clssyspara4webapi","../../PubFun/stuTopPara.js","../../PubFun/stuRangePara.js","../../PubFun/stuPagerPara.js","cachehelper","clsfldcomparisonobj"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsUsersEN_js_1 = require("../../L0_Entity/UserManage/clsUsersEN.js");
var clsCommFun4WA4Users_js_1 = require("../../L2_BLL/UserManage/clsCommFun4WA4Users.js");
var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
var clsStackTrace_js_1 = require("clsstacktrace");
var clsUsersBL_js_1 = require("../../L2_BLL/UserManage/clsUsersBL.js");
var Dictionary_js_1 = require("tzdictionary");
var clsSysPara4WebApi_js_1 = require("clssyspara4webapi");
var stuTopPara_js_1 = require("../../PubFun/stuTopPara.js");
var stuRangePara_js_1 = require("../../PubFun/stuRangePara.js");
var stuPagerPara_js_1 = require("../../PubFun/stuPagerPara.js");
var CacheHelper_js_1 = require("cachehelper");
var clsFldComparisonObj_js_1 = require("clsfldcomparisonobj");

 /// <summary>
 /// 用于用户管理(Users)
 /// (AutoGCLib.WA_AccessRJ4JavaScript:GeneCode)
 /// </summary>
var ResponseData;
var clsUsersWApi = /** @class */ (function() {
function clsUsersWApi(pobjUsersEN)
{
this.objUsersEN = new clsUsersEN_js_1.clsUsersEN();
this.objUsersEN = pobjUsersEN;
}

 /// <summary>
 /// 根据关键字获取相应的记录的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">关键字</param>
 /// <returns>对象</returns>
clsUsersWApi.GetObjByUserId = function(strUserId)  
{
var strAction = "GetObjByUserId";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("UserId", strUserId);
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>对象</returns>
clsUsersWApi.GetObjByUserId_Cache = async function(strUserId) {
var arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_Cache();
var obj = new clsUsersEN_js_1.clsUsersEN();
try
{
var arrUsers_Sel = arrUsersObjLst_Cache.filter(x => x.UserId == strUserId);
var objUsers;
if (arrUsers_Sel.length > 0)
{
objUsers = arrUsers_Sel[0];
return objUsers;
}
else
{
return obj;
}
}
catch (e)
{
var strMsg = "根据关键字:[" + strUserId  + "]获取相应的对象不成功!";
alert(strMsg);
}
return obj;
};

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存中获取.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_SetCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>对象</returns>
clsUsersWApi.SetCache = function() {
clsUsersWApi.objCommFun4BL = new clsCommFun4WA4Users_js_1.clsCommFun4WA4Users();
 //把以下三行添加到clsPubFun.js中
//"../L3_ForWApi/UserManage/clsUsersWApi.js"
//var clsUsersWApi_js_1 = require("../L3_ForWApi/UserManage/clsUsersWApi.js");
//clsUsersWApi_js_1.clsUsersWApi.SetCache();
};

 /// <summary>
 /// 根据关键字获取相应的对象
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strUserId">关键字</param>
 /// <returns>对象</returns>
clsUsersWApi.GetObjByUserId_WA_Cache = function(strUserId)  
{
var strAction = "GetObjByUserId_Cache";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("UserId", strUserId);
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
clsUsersWApi.GetFirstID = function(strWhereCond)  
{
var strAction = "GetFirstID";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
clsUsersWApi.GetFirstObj = function(strWhereCond)  
{
var strAction = "GetFirstObj";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
clsUsersWApi.GetObjLst_Cache = async function() 
{
var arrUsersObjLst_Cache;
switch (clsUsersWApi.CacheModeId)
{
case "04"://sessionStorage
arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_localStorage();
break;
case "02"://ClientCache
arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_ClientCache();
break;
default:
arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_ClientCache();
break;
}
return arrUsersObjLst_Cache;
}

 /// <summary>
 /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLst_ClientCache)
 /// </summary>
 /// <returns>从本地缓存中获取的对象列表</returns>
clsUsersWApi.GetObjLst_ClientCache = async function() 
{
//初始化列表缓存
var strWhereCond = "1=1";
clsUsersWApi.InitListCache(); 
var strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper_js_1.CacheHelper.Exsits(strKey))
{
//缓存存在，直接取出返回
var arrUsersObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
return arrUsersObjLst_Cache;
}
try
{
const responseText = await clsUsersWApi.GetObjLst(strWhereCond);
var arrUsersObjLst = responseText;
CacheHelper_js_1.CacheHelper.Add(strKey, arrUsersObjLst);
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrUsersObjLst.length+ " !";
console.log(strInfo);
return arrUsersObjLst;
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
clsUsersWApi.GetObjLst_localStorage = async function() 
{
//初始化列表缓存
var strWhereCond = "1=1";
clsUsersWApi.InitListCache(); 
var strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (localStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = localStorage.getItem(strKey);
var arrUsersObjLst_Cache = JSON.parse(strTempObjLst);
return arrUsersObjLst_Cache;
}
try
{
const responseText = await clsUsersWApi.GetObjLst(strWhereCond);
var arrUsersObjLst = responseText;
localStorage.setItem(strKey, JSON.stringify(arrUsersObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrUsersObjLst.length+ " !";
console.log(strInfo);
return arrUsersObjLst;
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
clsUsersWApi.GetObjLst_sessionStorage = async function() 
{
//初始化列表缓存
var strWhereCond = "1=1";
clsUsersWApi.InitListCache(); 
var strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
if (strKey == "")
{
console.log("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (sessionStorage.hasOwnProperty(strKey))
{
//缓存存在，直接取出返回
var strTempObjLst = sessionStorage.getItem(strKey);
var arrUsersObjLst_Cache = JSON.parse(strTempObjLst);
return arrUsersObjLst_Cache;
}
try
{
const responseText = await clsUsersWApi.GetObjLst(strWhereCond);
var arrUsersObjLst = responseText;
sessionStorage.setItem(strKey, JSON.stringify(arrUsersObjLst));
var strInfo = "Key:[" + strKey+ " ]的缓存已经建立，对象列表数：" + arrUsersObjLst.length+ " !";
console.log(strInfo);
return arrUsersObjLst;
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
clsUsersWApi.GetObjLst_WA_Cache = function()  
{
var strAction = "GetObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "objstrUserId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsUsersWApi.GetSubObjLst_Cache =  async function(objUsers_Cond) {
var objUsers_Sim = clsUsersBL_js_1.clsUsersBL.GetSimObjFromObj(objUsers_Cond);
var arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_Cache();
var arrUsers_Sel = arrUsersObjLst_Cache.filter(x => true);
if (objUsers_Sim.sf_FldComparisonOp == null || objUsers_Sim.sf_FldComparisonOp == "") return arrUsers_Sel;
var dicFldComparisonOp = JSON.parse(objUsers_Sim.sf_FldComparisonOp);
console.log("clsUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objUsers_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objUsers_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrUsers_Sel;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objUsers_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据条件获取相应的记录对象列表
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetSubObjLst_WA_Cache)
 /// </summary>
 /// <param name = "objUsers_Cond">条件对象</param>
 /// <returns>获取的相应记录对象列表</returns>
clsUsersWApi.GetSubObjLst_WA_Cache = function(objUsers_Cond)  
{
var strAction = "GetSubObjLst_Cache";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
var objUsersEN_Sim = clsUsersBL_js_1.clsUsersBL.GetSimObjFromObj(objUsers_Cond);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objUsersEN_Sim,
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
 /// <param name = "arrUserId">关键字列表</param>
 /// <returns>对象列表</returns>
clsUsersWApi.GetObjLstByUserIdLst = function(arrUserId)  
{
var strAction = "GetObjLstByUserIdLst";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrUserId },
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
 /// <param name = "arrstrUserIdLst">关键字列表</param>
 /// <returns>对象列表</returns>
clsUsersWApi.GetObjLstByUserIdLst_Cache =  async function(arrUserIdLst) {
try
{
var arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_Cache();
var arrUsers_Sel = arrUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.UserId)>-1);
return arrUsers_Sel;
}
catch (e)
{
var strMsg = "根据关键字:[" + arrUserIdLst.join(",")  + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return null;
};

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "arrUserId">关键字列表</param>
 /// <returns>对象列表</returns>
clsUsersWApi.GetObjLstByUserIdLst_WA_Cache = function(arrUserId)  
{
var strAction = "GetObjLstByUserIdLst_Cache";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrUserId },
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
clsUsersWApi.GetObjLst = function(strWhereCond)  
{
var strAction = "GetObjLst";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
clsUsersWApi.GetTopObjLst = function(objTopPara)  
{
var strAction = "GetTopObjLst";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
clsUsersWApi.GetObjLstByRange = function(objRangePara)  
{
var strAction = "GetObjLstByRange";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
clsUsersWApi.GetObjLstByPager_Cache =  async function(objPagerPara) {
var arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_Cache();
var arrUsers_Sel = arrUsersObjLst_Cache.filter(x => true);
var obj_Cond = JSON.parse(objPagerPara.WhereCond);
var dicFldComparisonOp = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
console.log("clsUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
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
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
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
arrUsers_Sel = arrUsers_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
}
else {
arrUsers_Sel = arrUsers_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
}
}
arrUsers_Sel = arrUsers_Sel.slice(intStart, intEnd);     
return arrUsers_Sel;
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
clsUsersWApi.GetObjLstByPager_WA_Cache = function(objPagerPara)  
{
var strAction = "GetObjLstByPager_Cache";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
clsUsersWApi.GetObjLstByPager = function(objPagerPara)  
{
var strAction = "GetObjLstByPager";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "strUserId">关键字</param>
 /// <returns>获取删除的结果</returns>
clsUsersWApi.DelRecord = function(strUserId)  
{
var strAction = "DelRecord";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
strUrl =  strUrl+ "/" +  strUserId;
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("strUserId", strUserId);
let strData = mapParam.getParamText();// "例如: strIdentityID =01";
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "DELETE",
dataType: "json",
data: { "": strUserId },
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
 /// <param name = "arrUserId">关键字列表</param>
 /// <returns>实际删除记录的个数</returns>
clsUsersWApi.DelRecordBySign = function(arrUserId) 
{
var strAction = "DelRecordBySign";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrUserId },
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
 /// <param name = "arrUserId">关键字列表</param>
 /// <returns>实际恢复记录的个数</returns>
clsUsersWApi.UnDelRecordBySign = function(arrUserId) 
{
var strAction = "UnDelRecordBySign";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrUserId },
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
 /// <param name = "arrUserId">关键字列表</param>
 /// <returns>实际删除记录的个数</returns>
clsUsersWApi.DelUserss = function(arrUserId) 
{
var strAction = "DelUserss";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: {"": arrUserId },
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
clsUsersWApi.DelUserssByCond = function(strWhereCond) 
{
var strAction = "DelUserssByCond";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "objUsersEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsUsersWApi.AddNewRecordWithMaxId = function(objUsersEN) 
{
var strMsg = "";
var strAction = "AddNewRecordWithMaxId";
var objUsersEN_Sim = clsUsersBL_js_1.clsUsersBL.GetSimObjFromObj(objUsersEN);
 //var strJSON = JSON.stringify(objUsersEN_Sim);
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objUsersEN_Sim,
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
 /// <param name = "objUsersEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsUsersWApi.GoTop = function(objOrderByData) 
{
var strMsg = "";
var strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objUsersEN_Sim);
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "objUsersEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsUsersWApi.UpMove = function(objOrderByData) 
{
var strMsg = "";
var strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objUsersEN_Sim);
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "objUsersEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsUsersWApi.DownMove = function(objOrderByData)
{
var strMsg = "";
var strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objUsersEN_Sim);
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "objUsersEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsUsersWApi.GoBottom = function(objOrderByData) 
{
var strMsg = "";
var strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objUsersEN_Sim);
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "objUsersEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsUsersWApi.ReOrder = function(objOrderByData) 
{
var strMsg = "";
var strAction = "ReOrder";
 //var strJSON = JSON.stringify(objUsersEN_Sim);
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "objUsersEN">需要添加的对象</param>
 /// <returns>获取相应的记录的对象</returns>
clsUsersWApi.AddNewRecord = function(objUsersEN) 
{
var strMsg = "";
var strAction = "AddNewRecord";
if (objUsersEN.UserId === null || objUsersEN.UserId === "")
{
strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
var objUsersEN_Sim = clsUsersBL_js_1.clsUsersBL.GetSimObjFromObj(objUsersEN);
 //var strJSON = JSON.stringify(objUsersEN_Sim);
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objUsersEN_Sim,
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
 /// <param name = "objUsersEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
clsUsersWApi.AddNewRecordWithReturnKey = function(objUsersEN) 
{
var strAction = "AddNewRecordWithReturnKey";
var objUsersEN_Sim = clsUsersBL_js_1.clsUsersBL.GetSimObjFromObj(objUsersEN);
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objUsersEN_Sim,
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
 /// <param name = "objUsersEN">需要添加的对象</param>
 /// <returns>获取修改是否成功？</returns>
clsUsersWApi.UpdateRecord = function(objUsersEN)  
{
var strMsg = "";
var strAction = "UpdateRecord";
 if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "")
{
strMsg = "对象(关键字: " + objUsersEN.UserId + ")的【修改字段集】为空，不能修改!";
 throw strMsg;
 }
var objUsersEN_Sim = clsUsersBL_js_1.clsUsersBL.GetSimObjFromObj(objUsersEN);
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
return new Promise(function(resolve, reject) {
$.ajax({
url: strUrl,
method: "POST",
dataType: "json",
data: objUsersEN_Sim,
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
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
clsUsersWApi.UpdateWithCondition = function(objUsersEN, strWhereCond ) 
{
var strAction = "UpdateWithCondition";
 if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "")
{
var strMsg = "对象(关键字:" + objUsersEN.UserId + ")的【修改字段集】为空，不能修改!";
 throw new Error(strMsg);
 }
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
clsUsersWApi.IsExistRecord = function(strWhereCond)  
{
var strAction = "IsExistRecord";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "objstrUserId_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
clsUsersWApi.IsExistRecord_Cache =  async function(objUsers_Cond) {
var objUsers_Sim = clsUsersBL_js_1.clsUsersBL.GetSimObjFromObj(objUsers_Cond);
var arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_Cache();
var arrUsers_Sel = arrUsersObjLst_Cache.filter(x => true);
if (objUsers_Sim.sf_FldComparisonOp == null || objUsers_Sim.sf_FldComparisonOp == "") return arrUsers_Sel.length>0?true:false;
var dicFldComparisonOp = JSON.parse(objUsers_Sim.sf_FldComparisonOp);
console.log("clsUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objUsers_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objUsers_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
if (arrUsers_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objUsers_Sim) + "]判断是否存在不成功!";
throw new Error(strMsg);
}
return false;
};

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_IsExist)
 /// </summary>
 /// <param name = "strUserId">关键字</param>
 /// <returns>是否存在?存在返回True</returns>
clsUsersWApi.IsExist = function(strUserId) 
{
//检测记录是否存在
var strAction = "IsExist";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
var mapParam = new Dictionary_js_1.Dictionary();
mapParam.add("UserId", strUserId);
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>对象</returns>
clsUsersWApi.IsExist_Cache = async function(strUserId) {
var arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_Cache();
var obj = new clsUsersEN_js_1.clsUsersEN();
try
{
var arrUsers_Sel = arrUsersObjLst_Cache.filter(x => x.UserId == strUserId);
var objUsers;
if (arrUsers_Sel.length > 0)
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
var strMsg = "根据关键字:[" + strUserId  + "]判断是否存在不成功!";
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
clsUsersWApi.GetRecCountByCond = function(strWhereCond)  
{
var strAction = "GetRecCountByCond";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
 /// <param name = "objUsers_Cond">条件对象</param>
 /// <returns>对象列表记录数</returns>
clsUsersWApi.GetRecCountByCond_Cache =  async function(objUsers_Cond) {
var objUsers_Sim = clsUsersBL_js_1.clsUsersBL.GetSimObjFromObj(objUsers_Cond);
var arrUsersObjLst_Cache = await clsUsersWApi.GetObjLst_Cache();
var arrUsers_Sel = arrUsersObjLst_Cache.filter(x => true);
if (objUsers_Sim.sf_FldComparisonOp == null || objUsers_Sim.sf_FldComparisonOp == "") return arrUsers_Sel.length;
var dicFldComparisonOp = JSON.parse(objUsers_Sim.sf_FldComparisonOp);
console.log("clsUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
console.log(dicFldComparisonOp);
try {
var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objUsers_Sim);
console.log(sstrKeys);
for (let strKey of sstrKeys) {
if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
var strComparisonOp = dicFldComparisonOp[strKey];
var strValue = objUsers_Sim[strKey];
var strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
}
break;
case "number":
if (strValue == 0) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] == strValue);
}
else if (strComparisonOp == ">=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] >= strValue);
}
else if (strComparisonOp == "<=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
}
else if (strComparisonOp == ">") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] > strValue);
}
else if (strComparisonOp == "<") {
arrUsers_Sel = arrUsers_Sel.filter(x => x[strKey] <= strValue);
}
break;
}
}
return arrUsers_Sel.length;
}
catch (e) {
var strMsg = "根据条件:[" +JSON.stringify( objUsers_Sim) + "]获取相应的对象不成功!";
throw new Error(strMsg);
}
return 0;
};

 /// <summary>
 /// 获取表的最大关键字
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_GetMaxStrId)
 /// </summary>
 /// <returns>获取表的最大关键字</returns>
clsUsersWApi.GetMaxStrId = function()  
{
var strAction = "GetMaxStrId";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
clsUsersWApi.GetMaxStrIdByPrefix = function(strPrefix)  
{
var strAction = "GetMaxStrIdByPrefix";
let strUrl = this.GetWebApiUrl(clsUsersWApi.mstrController, strAction);
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
clsUsersWApi.GetWebApiUrl = function(strController, strAction) {
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
/// 为下拉框获取数据,从表:[Users]中获取
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_DdlBind_Cache)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
clsUsersWApi.BindDdl_UserId_Cache2 = function(strDdlName, objUsers_Cond) {
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
var arrObjLst_Sel = clsUsersWApi.GetSubObjLst_Cache(objUsers_Cond);
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN_js_1.clsUsersEN.con_UserId, clsUsersEN_js_1.clsUsersEN.con_UserName, "用于用户管理");
console.log("完成BindDdl_UserId!");
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
clsUsersWApi.InitListCache = function() 
{
//初始化列表缓存
//检查缓存刷新机制
var strMsg = "";
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = "类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from " + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction() + ")";
throw new Error(strMsg);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_ReFreshCache)
 /// </summary>
clsUsersWApi.ReFreshCache = function()
{
if (clsUsersWApi.objCommFun4BL != null) 
{
 var strMsg = "刷新缓存成功！(" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2) + "->" + clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction();
console.log(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
switch (clsUsersWApi.CacheModeId)
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
clsUsersWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4JavaScript:Gen_4WA_Js_ReFreshThisCache)
 /// </summary>
clsUsersWApi. ReFreshThisCache = function()
{
var strMsg = "";
if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
var strKey = clsUsersEN_js_1.clsUsersEN._CurrTabName;
switch (clsUsersWApi.CacheModeId)
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
clsUsersWApi.BindDdl_UserId_Cache = async function(strDdlName, objUsers_Cond)
{
var objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
var strMsg = "下拉框：" + strDdlName  + " 不存在！";
alert(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
console.log("开始：BindDdl_UserId_Cache");
var arrObjLst_Sel = await clsUsersWApi.GetSubObjLst_Cache(objUsers_Cond);
clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN_js_1.clsUsersEN.con_UserId, clsUsersEN_js_1.clsUsersEN.con_UserName, "用于用户管理");
}
clsUsersWApi.mstrController = "UsersApi";
clsUsersWApi.CacheModeId = ""; //
return clsUsersWApi;
}());
exports.clsUsersWApi = clsUsersWApi;
});