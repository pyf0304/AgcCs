
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQueryOptionBL
 表名:QueryOption(00050080)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:30
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsQueryOptionEN.js","../../L0_Entity/PrjInterface/clsQueryOptionEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsQueryOptionEN_js_1 = require("../../L0_Entity/PrjInterface/clsQueryOptionEN.js");
var clsQueryOptionEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsQueryOptionEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 查询选项(QueryOption)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsQueryOptionBL = /** @class */ (function () {
function clsQueryOptionBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrQueryOptionObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsQueryOptionBL.prototype.CheckPropertyNew = function(pobjQueryOptionEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjQueryOptionEN.QueryOptionName 
 || null !== pobjQueryOptionEN.QueryOptionName && pobjQueryOptionEN.QueryOptionName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[查询选项|查询方式名称]不能为空(NULL)!(clsQueryOptionBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjQueryOptionEN.QueryOptionId && GetStrLen(pobjQueryOptionEN.QueryOptionId) > 2)
{
 throw new Error("(errid:Busi000155)字段[查询选项(QueryOption)|查询方式Id(QueryOptionId)]的长度不能超过2!值:$(pobjQueryOptionEN.QueryOptionId)(clsQueryOptionBL:CheckPropertyNew)");
}
if (null !== pobjQueryOptionEN.QueryOptionName && GetStrLen(pobjQueryOptionEN.QueryOptionName) > 20)
{
 throw new Error("(errid:Busi000155)字段[查询选项(QueryOption)|查询方式名称(QueryOptionName)]的长度不能超过20!值:$(pobjQueryOptionEN.QueryOptionName)(clsQueryOptionBL:CheckPropertyNew)");
}
if (null !== pobjQueryOptionEN.QueryOptionENName && GetStrLen(pobjQueryOptionEN.QueryOptionENName) > 50)
{
 throw new Error("(errid:Busi000155)字段[查询选项(QueryOption)|查询方式英文名(QueryOptionENName)]的长度不能超过50!值:$(pobjQueryOptionEN.QueryOptionENName)(clsQueryOptionBL:CheckPropertyNew)");
}
if (null !== pobjQueryOptionEN.Memo && GetStrLen(pobjQueryOptionEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[查询选项(QueryOption)|说明(Memo)]的长度不能超过1000!值:$(pobjQueryOptionEN.Memo)(clsQueryOptionBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjQueryOptionEN.QueryOptionId && undefined !== pobjQueryOptionEN.QueryOptionId && tzDataType.isString(pobjQueryOptionEN.QueryOptionId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询选项(QueryOption)|查询方式Id(QueryOptionId)]的值:[$(pobjQueryOptionEN.QueryOptionId)], 非法，应该为字符型!(clsQueryOptionBL:CheckPropertyNew)");
}
if (null !== pobjQueryOptionEN.QueryOptionName && undefined !== pobjQueryOptionEN.QueryOptionName && tzDataType.isString(pobjQueryOptionEN.QueryOptionName) === false)
{
 throw new Error("(errid:Busi000156)字段[查询选项(QueryOption)|查询方式名称(QueryOptionName)]的值:[$(pobjQueryOptionEN.QueryOptionName)], 非法，应该为字符型!(clsQueryOptionBL:CheckPropertyNew)");
}
if (null !== pobjQueryOptionEN.QueryOptionENName && undefined !== pobjQueryOptionEN.QueryOptionENName && tzDataType.isString(pobjQueryOptionEN.QueryOptionENName) === false)
{
 throw new Error("(errid:Busi000156)字段[查询选项(QueryOption)|查询方式英文名(QueryOptionENName)]的值:[$(pobjQueryOptionEN.QueryOptionENName)], 非法，应该为字符型!(clsQueryOptionBL:CheckPropertyNew)");
}
if (null !== pobjQueryOptionEN.Memo && undefined !== pobjQueryOptionEN.Memo && tzDataType.isString(pobjQueryOptionEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[查询选项(QueryOption)|说明(Memo)]的值:[$(pobjQueryOptionEN.Memo)], 非法，应该为字符型!(clsQueryOptionBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjQueryOptionEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsQueryOptionBL.prototype.CheckProperty4Update  = function(pobjQueryOptionEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjQueryOptionEN.QueryOptionId && GetStrLen(pobjQueryOptionEN.QueryOptionId) > 2)
{
 throw new Error("(errid:Busi000158)字段[查询选项(QueryOption)|查询方式Id(QueryOptionId)]的长度不能超过2!值:$(pobjQueryOptionEN.QueryOptionId)(clsQueryOptionBL:CheckProperty4Update)");
}
if (null !== pobjQueryOptionEN.QueryOptionName && GetStrLen(pobjQueryOptionEN.QueryOptionName) > 20)
{
 throw new Error("(errid:Busi000158)字段[查询选项(QueryOption)|查询方式名称(QueryOptionName)]的长度不能超过20!值:$(pobjQueryOptionEN.QueryOptionName)(clsQueryOptionBL:CheckProperty4Update)");
}
if (null !== pobjQueryOptionEN.QueryOptionENName && GetStrLen(pobjQueryOptionEN.QueryOptionENName) > 50)
{
 throw new Error("(errid:Busi000158)字段[查询选项(QueryOption)|查询方式英文名(QueryOptionENName)]的长度不能超过50!值:$(pobjQueryOptionEN.QueryOptionENName)(clsQueryOptionBL:CheckProperty4Update)");
}
if (null !== pobjQueryOptionEN.Memo && GetStrLen(pobjQueryOptionEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[查询选项(QueryOption)|说明(Memo)]的长度不能超过1000!值:$(pobjQueryOptionEN.Memo)(clsQueryOptionBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjQueryOptionEN.QueryOptionId && undefined !== pobjQueryOptionEN.QueryOptionId && tzDataType.isString(pobjQueryOptionEN.QueryOptionId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询选项(QueryOption)|查询方式Id(QueryOptionId)]的值:[$(pobjQueryOptionEN.QueryOptionId)], 非法，应该为字符型!(clsQueryOptionBL:CheckProperty4Update)");
}
if (null !== pobjQueryOptionEN.QueryOptionName && undefined !== pobjQueryOptionEN.QueryOptionName && tzDataType.isString(pobjQueryOptionEN.QueryOptionName) === false)
{
 throw new Error("(errid:Busi000159)字段[查询选项(QueryOption)|查询方式名称(QueryOptionName)]的值:[$(pobjQueryOptionEN.QueryOptionName)], 非法，应该为字符型!(clsQueryOptionBL:CheckProperty4Update)");
}
if (null !== pobjQueryOptionEN.QueryOptionENName && undefined !== pobjQueryOptionEN.QueryOptionENName && tzDataType.isString(pobjQueryOptionEN.QueryOptionENName) === false)
{
 throw new Error("(errid:Busi000159)字段[查询选项(QueryOption)|查询方式英文名(QueryOptionENName)]的值:[$(pobjQueryOptionEN.QueryOptionENName)], 非法，应该为字符型!(clsQueryOptionBL:CheckProperty4Update)");
}
if (null !== pobjQueryOptionEN.Memo && undefined !== pobjQueryOptionEN.Memo && tzDataType.isString(pobjQueryOptionEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[查询选项(QueryOption)|说明(Memo)]的值:[$(pobjQueryOptionEN.Memo)], 非法，应该为字符型!(clsQueryOptionBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjQueryOptionEN.QueryOptionId 
 || null !== pobjQueryOptionEN.QueryOptionId && pobjQueryOptionEN.QueryOptionId.toString()  ===  ""
 || null !== pobjQueryOptionEN.QueryOptionId && pobjQueryOptionEN.QueryOptionId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[查询选项|查询方式Id]不能为空(NULL)!(clsQueryOptionBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjQueryOptionEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024930
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsQueryOptionBL.GetJSONStrByObj  = function(pobjQueryOptionEN)
{
pobjQueryOptionEN.sf_UpdFldSetStr = pobjQueryOptionEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjQueryOptionEN);
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
 /// 日期:20200501024930
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsQueryOptionBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrQueryOptionObjLst = new Array();
if (strJSON === "")
{
return arrQueryOptionObjLst;
}
try
{
arrQueryOptionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrQueryOptionObjLst;
}
return arrQueryOptionObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024930
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsQueryOptionBL.GetObjByJSONStr  = function(strJSON)
{
var pobjQueryOptionEN = new clsQueryOptionEN();
if (strJSON === "")
{
return pobjQueryOptionEN;
}
try
{
pobjQueryOptionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjQueryOptionEN;
}
return pobjQueryOptionEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objQueryOptionENS">源简化对象</param>
 /// <param name = "objQueryOptionENT">目标对象</param>
clsQueryOptionBL.CopyObjFromSimObj = function(objQueryOptionENS, objQueryOptionENT) 
{
objQueryOptionENT.QueryOptionId = objQueryOptionENS.QueryOptionId; //查询方式Id
objQueryOptionENT.QueryOptionName = objQueryOptionENS.QueryOptionName; //查询方式名称
objQueryOptionENT.QueryOptionENName = objQueryOptionENS.QueryOptionENName; //查询方式英文名
objQueryOptionENT.Memo = objQueryOptionENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objQueryOptionENS">源对象</param>
 /// <param name = "objQueryOptionENT">目标对象</param>
clsQueryOptionBL.CopyObjTo = function(objQueryOptionENS , objQueryOptionENT ) 
{
objQueryOptionENT.QueryOptionId = objQueryOptionENS.QueryOptionId; //查询方式Id
objQueryOptionENT.QueryOptionName = objQueryOptionENS.QueryOptionName; //查询方式名称
objQueryOptionENT.QueryOptionENName = objQueryOptionENS.QueryOptionENName; //查询方式英文名
objQueryOptionENT.Memo = objQueryOptionENS.Memo; //说明
objQueryOptionENT.sf_UpdFldSetStr = objQueryOptionENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objQueryOptionENS">源对象</param>
 /// <param name = "objQueryOptionENT">目标对象</param>
clsQueryOptionBL.CopyObjToSimObj = function(objQueryOptionENS , objQueryOptionENT ) 
{
objQueryOptionENT.QueryOptionId = objQueryOptionENS.QueryOptionId; //查询方式Id
objQueryOptionENT.QueryOptionName = objQueryOptionENS.QueryOptionName; //查询方式名称
objQueryOptionENT.QueryOptionENName = objQueryOptionENS.QueryOptionENName; //查询方式英文名
objQueryOptionENT.Memo = objQueryOptionENS.Memo; //说明
objQueryOptionENT.sf_UpdFldSetStr = objQueryOptionENS.UpdFldString; //专门用于记录某字段属性是否修改
objQueryOptionENT.sf_FldComparisonOp = objQueryOptionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objQueryOptionENS">源简化对象</param>
 /// <param name = "objQueryOptionENT">目标对象</param>
clsQueryOptionBL.CopyObjFromSimObj4Upd = function(objQueryOptionENS, objQueryOptionENT )
 {
   var strsf_UpdFldSetStr = objQueryOptionENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsQueryOptionEN.con_QueryOptionId)  >= 0)
{
objQueryOptionENT.QueryOptionId = objQueryOptionENS.QueryOptionId; //查询方式Id
}
if (sstrFldSet.indexOf(clsQueryOptionEN.con_QueryOptionName)  >= 0)
{
objQueryOptionENT.QueryOptionName = objQueryOptionENS.QueryOptionName; //查询方式名称
}
if (sstrFldSet.indexOf(clsQueryOptionEN.con_QueryOptionENName)  >= 0)
{
objQueryOptionENT.QueryOptionENName = objQueryOptionENS.QueryOptionENName; //查询方式英文名
}
if (sstrFldSet.indexOf(clsQueryOptionEN.con_Memo)  >= 0)
{
objQueryOptionENT.Memo = objQueryOptionENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objQueryOptionENS">源对象</param>
 /// <param name = "objQueryOptionENT">目标对象</param>
clsQueryOptionBL.GetSimObjFromObj = function(objQueryOptionENS)
{
var objQueryOptionENT = new clsQueryOptionEN_Sim_js_1.clsQueryOptionEN_Sim();
objQueryOptionENT.QueryOptionId = objQueryOptionENS.QueryOptionId; //查询方式Id
objQueryOptionENT.QueryOptionName = objQueryOptionENS.QueryOptionName; //查询方式名称
objQueryOptionENT.QueryOptionENName = objQueryOptionENS.QueryOptionENName; //查询方式英文名
objQueryOptionENT.Memo = objQueryOptionENS.Memo; //说明
objQueryOptionENT.sf_UpdFldSetStr = objQueryOptionENS.UpdFldString; //专门用于记录某字段属性是否修改
objQueryOptionENT.sf_FldComparisonOp = objQueryOptionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objQueryOptionENT;
}
return clsQueryOptionBL;
}());
exports.clsQueryOptionBL = clsQueryOptionBL;
});