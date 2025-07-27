
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCacheModeBL
 表名:CacheMode(00050538)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:02
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
 框架-层名:业务逻辑层RJ(BusinessLogicRJ)
 编程语言:JavaScript
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsCacheModeEN.js","../../L0_Entity/Table_Field/clsCacheModeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsCacheModeEN_js_1 = require("../../L0_Entity/Table_Field/clsCacheModeEN.js");
var clsCacheModeEN_Sim_js_1 = require("../../L0_Entity/Table_Field/clsCacheModeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 缓存方式(CacheMode)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsCacheModeBL = /** @class */ (function () {
function clsCacheModeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrCacheModeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsCacheModeBL.prototype.CheckPropertyNew = function(pobjCacheModeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjCacheModeEN.CacheModeName 
 || null !== pobjCacheModeEN.CacheModeName && pobjCacheModeEN.CacheModeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[缓存方式|缓存方式名]不能为空(NULL)!(clsCacheModeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjCacheModeEN.CacheModeId && GetStrLen(pobjCacheModeEN.CacheModeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[缓存方式(CacheMode)|缓存方式Id(CacheModeId)]的长度不能超过2!值:$(pobjCacheModeEN.CacheModeId)(clsCacheModeBL:CheckPropertyNew)");
}
if (null !== pobjCacheModeEN.CacheModeName && GetStrLen(pobjCacheModeEN.CacheModeName) > 50)
{
 throw new Error("(errid:Busi000155)字段[缓存方式(CacheMode)|缓存方式名(CacheModeName)]的长度不能超过50!值:$(pobjCacheModeEN.CacheModeName)(clsCacheModeBL:CheckPropertyNew)");
}
if (null !== pobjCacheModeEN.CacheModeENName && GetStrLen(pobjCacheModeEN.CacheModeENName) > 50)
{
 throw new Error("(errid:Busi000155)字段[缓存方式(CacheMode)|缓存方式英文名(CacheModeENName)]的长度不能超过50!值:$(pobjCacheModeEN.CacheModeENName)(clsCacheModeBL:CheckPropertyNew)");
}
if (null !== pobjCacheModeEN.Memo && GetStrLen(pobjCacheModeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[缓存方式(CacheMode)|说明(Memo)]的长度不能超过1000!值:$(pobjCacheModeEN.Memo)(clsCacheModeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjCacheModeEN.CacheModeId && undefined !== pobjCacheModeEN.CacheModeId && tzDataType.isString(pobjCacheModeEN.CacheModeId) === false)
{
 throw new Error("(errid:Busi000156)字段[缓存方式(CacheMode)|缓存方式Id(CacheModeId)]的值:[$(pobjCacheModeEN.CacheModeId)], 非法，应该为字符型!(clsCacheModeBL:CheckPropertyNew)");
}
if (null !== pobjCacheModeEN.CacheModeName && undefined !== pobjCacheModeEN.CacheModeName && tzDataType.isString(pobjCacheModeEN.CacheModeName) === false)
{
 throw new Error("(errid:Busi000156)字段[缓存方式(CacheMode)|缓存方式名(CacheModeName)]的值:[$(pobjCacheModeEN.CacheModeName)], 非法，应该为字符型!(clsCacheModeBL:CheckPropertyNew)");
}
if (null !== pobjCacheModeEN.CacheModeENName && undefined !== pobjCacheModeEN.CacheModeENName && tzDataType.isString(pobjCacheModeEN.CacheModeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[缓存方式(CacheMode)|缓存方式英文名(CacheModeENName)]的值:[$(pobjCacheModeEN.CacheModeENName)], 非法，应该为字符型!(clsCacheModeBL:CheckPropertyNew)");
}
if (null !== pobjCacheModeEN.Memo && undefined !== pobjCacheModeEN.Memo && tzDataType.isString(pobjCacheModeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[缓存方式(CacheMode)|说明(Memo)]的值:[$(pobjCacheModeEN.Memo)], 非法，应该为字符型!(clsCacheModeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjCacheModeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsCacheModeBL.prototype.CheckProperty4Update  = function(pobjCacheModeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjCacheModeEN.CacheModeId && GetStrLen(pobjCacheModeEN.CacheModeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[缓存方式(CacheMode)|缓存方式Id(CacheModeId)]的长度不能超过2!值:$(pobjCacheModeEN.CacheModeId)(clsCacheModeBL:CheckProperty4Update)");
}
if (null !== pobjCacheModeEN.CacheModeName && GetStrLen(pobjCacheModeEN.CacheModeName) > 50)
{
 throw new Error("(errid:Busi000158)字段[缓存方式(CacheMode)|缓存方式名(CacheModeName)]的长度不能超过50!值:$(pobjCacheModeEN.CacheModeName)(clsCacheModeBL:CheckProperty4Update)");
}
if (null !== pobjCacheModeEN.CacheModeENName && GetStrLen(pobjCacheModeEN.CacheModeENName) > 50)
{
 throw new Error("(errid:Busi000158)字段[缓存方式(CacheMode)|缓存方式英文名(CacheModeENName)]的长度不能超过50!值:$(pobjCacheModeEN.CacheModeENName)(clsCacheModeBL:CheckProperty4Update)");
}
if (null !== pobjCacheModeEN.Memo && GetStrLen(pobjCacheModeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[缓存方式(CacheMode)|说明(Memo)]的长度不能超过1000!值:$(pobjCacheModeEN.Memo)(clsCacheModeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjCacheModeEN.CacheModeId && undefined !== pobjCacheModeEN.CacheModeId && tzDataType.isString(pobjCacheModeEN.CacheModeId) === false)
{
 throw new Error("(errid:Busi000159)字段[缓存方式(CacheMode)|缓存方式Id(CacheModeId)]的值:[$(pobjCacheModeEN.CacheModeId)], 非法，应该为字符型!(clsCacheModeBL:CheckProperty4Update)");
}
if (null !== pobjCacheModeEN.CacheModeName && undefined !== pobjCacheModeEN.CacheModeName && tzDataType.isString(pobjCacheModeEN.CacheModeName) === false)
{
 throw new Error("(errid:Busi000159)字段[缓存方式(CacheMode)|缓存方式名(CacheModeName)]的值:[$(pobjCacheModeEN.CacheModeName)], 非法，应该为字符型!(clsCacheModeBL:CheckProperty4Update)");
}
if (null !== pobjCacheModeEN.CacheModeENName && undefined !== pobjCacheModeEN.CacheModeENName && tzDataType.isString(pobjCacheModeEN.CacheModeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[缓存方式(CacheMode)|缓存方式英文名(CacheModeENName)]的值:[$(pobjCacheModeEN.CacheModeENName)], 非法，应该为字符型!(clsCacheModeBL:CheckProperty4Update)");
}
if (null !== pobjCacheModeEN.Memo && undefined !== pobjCacheModeEN.Memo && tzDataType.isString(pobjCacheModeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[缓存方式(CacheMode)|说明(Memo)]的值:[$(pobjCacheModeEN.Memo)], 非法，应该为字符型!(clsCacheModeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjCacheModeEN.CacheModeId 
 || null !== pobjCacheModeEN.CacheModeId && pobjCacheModeEN.CacheModeId.toString()  ===  ""
 || null !== pobjCacheModeEN.CacheModeId && pobjCacheModeEN.CacheModeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[缓存方式|缓存方式Id]不能为空(NULL)!(clsCacheModeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjCacheModeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200502010602
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsCacheModeBL.GetJSONStrByObj  = function(pobjCacheModeEN)
{
pobjCacheModeEN.sf_UpdFldSetStr = pobjCacheModeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjCacheModeEN);
}
catch(objException)
{
myShowErrorMsg(objException.message);
}
return strJson;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象列表
 /// 作者:
 /// 日期:20200502010602
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsCacheModeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrCacheModeObjLst = new Array();
if (strJSON === "")
{
return arrCacheModeObjLst;
}
try
{
arrCacheModeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrCacheModeObjLst;
}
return arrCacheModeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200502010602
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsCacheModeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjCacheModeEN = new clsCacheModeEN();
if (strJSON === "")
{
return pobjCacheModeEN;
}
try
{
pobjCacheModeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjCacheModeEN;
}
return pobjCacheModeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objCacheModeENS">源简化对象</param>
 /// <param name = "objCacheModeENT">目标对象</param>
clsCacheModeBL.CopyObjFromSimObj = function(objCacheModeENS, objCacheModeENT) 
{
objCacheModeENT.CacheModeId = objCacheModeENS.CacheModeId; //缓存方式Id
objCacheModeENT.CacheModeName = objCacheModeENS.CacheModeName; //缓存方式名
objCacheModeENT.CacheModeENName = objCacheModeENS.CacheModeENName; //缓存方式英文名
objCacheModeENT.Memo = objCacheModeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objCacheModeENS">源对象</param>
 /// <param name = "objCacheModeENT">目标对象</param>
clsCacheModeBL.CopyObjTo = function(objCacheModeENS , objCacheModeENT ) 
{
objCacheModeENT.CacheModeId = objCacheModeENS.CacheModeId; //缓存方式Id
objCacheModeENT.CacheModeName = objCacheModeENS.CacheModeName; //缓存方式名
objCacheModeENT.CacheModeENName = objCacheModeENS.CacheModeENName; //缓存方式英文名
objCacheModeENT.Memo = objCacheModeENS.Memo; //说明
objCacheModeENT.sf_UpdFldSetStr = objCacheModeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objCacheModeENS">源对象</param>
 /// <param name = "objCacheModeENT">目标对象</param>
clsCacheModeBL.CopyObjToSimObj = function(objCacheModeENS , objCacheModeENT ) 
{
objCacheModeENT.CacheModeId = objCacheModeENS.CacheModeId; //缓存方式Id
objCacheModeENT.CacheModeName = objCacheModeENS.CacheModeName; //缓存方式名
objCacheModeENT.CacheModeENName = objCacheModeENS.CacheModeENName; //缓存方式英文名
objCacheModeENT.Memo = objCacheModeENS.Memo; //说明
objCacheModeENT.sf_UpdFldSetStr = objCacheModeENS.UpdFldString; //专门用于记录某字段属性是否修改
objCacheModeENT.sf_FldComparisonOp = objCacheModeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objCacheModeENS">源简化对象</param>
 /// <param name = "objCacheModeENT">目标对象</param>
clsCacheModeBL.CopyObjFromSimObj4Upd = function(objCacheModeENS, objCacheModeENT )
 {
   var strsf_UpdFldSetStr = objCacheModeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsCacheModeEN.con_CacheModeId)  >= 0)
{
objCacheModeENT.CacheModeId = objCacheModeENS.CacheModeId; //缓存方式Id
}
if (sstrFldSet.indexOf(clsCacheModeEN.con_CacheModeName)  >= 0)
{
objCacheModeENT.CacheModeName = objCacheModeENS.CacheModeName; //缓存方式名
}
if (sstrFldSet.indexOf(clsCacheModeEN.con_CacheModeENName)  >= 0)
{
objCacheModeENT.CacheModeENName = objCacheModeENS.CacheModeENName; //缓存方式英文名
}
if (sstrFldSet.indexOf(clsCacheModeEN.con_Memo)  >= 0)
{
objCacheModeENT.Memo = objCacheModeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objCacheModeENS">源对象</param>
 /// <param name = "objCacheModeENT">目标对象</param>
clsCacheModeBL.GetSimObjFromObj = function(objCacheModeENS)
{
var objCacheModeENT = new clsCacheModeEN_Sim_js_1.clsCacheModeEN_Sim();
objCacheModeENT.CacheModeId = objCacheModeENS.CacheModeId; //缓存方式Id
objCacheModeENT.CacheModeName = objCacheModeENS.CacheModeName; //缓存方式名
objCacheModeENT.CacheModeENName = objCacheModeENS.CacheModeENName; //缓存方式英文名
objCacheModeENT.Memo = objCacheModeENS.Memo; //说明
objCacheModeENT.sf_UpdFldSetStr = objCacheModeENS.UpdFldString; //专门用于记录某字段属性是否修改
objCacheModeENT.sf_FldComparisonOp = objCacheModeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objCacheModeENT;
}
return clsCacheModeBL;
}());
exports.clsCacheModeBL = clsCacheModeBL;
});