
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabMainTypeBL
 表名:TabMainType(00050534)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:05:57
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsTabMainTypeEN.js","../../L0_Entity/SysPara/clsTabMainTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsTabMainTypeEN_js_1 = require("../../L0_Entity/SysPara/clsTabMainTypeEN.js");
var clsTabMainTypeEN_Sim_js_1 = require("../../L0_Entity/SysPara/clsTabMainTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// TabMainType(TabMainType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsTabMainTypeBL = /** @class */ (function () {
function clsTabMainTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrTabMainTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsTabMainTypeBL.prototype.CheckPropertyNew = function(pobjTabMainTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjTabMainTypeEN.TabMainTypeName 
 || null !== pobjTabMainTypeEN.TabMainTypeName && pobjTabMainTypeEN.TabMainTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[TabMainType|表主类型名]不能为空(NULL)!(clsTabMainTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjTabMainTypeEN.TabMainTypeId && GetStrLen(pobjTabMainTypeEN.TabMainTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[TabMainType(TabMainType)|表主类型Id(TabMainTypeId)]的长度不能超过4!值:$(pobjTabMainTypeEN.TabMainTypeId)(clsTabMainTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabMainTypeEN.TabMainTypeName && GetStrLen(pobjTabMainTypeEN.TabMainTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[TabMainType(TabMainType)|表主类型名(TabMainTypeName)]的长度不能超过30!值:$(pobjTabMainTypeEN.TabMainTypeName)(clsTabMainTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabMainTypeEN.TabMainTypeENName && GetStrLen(pobjTabMainTypeEN.TabMainTypeENName) > 30)
{
 throw new Error("(errid:Busi000155)字段[TabMainType(TabMainType)|表主类型英文名(TabMainTypeENName)]的长度不能超过30!值:$(pobjTabMainTypeEN.TabMainTypeENName)(clsTabMainTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabMainTypeEN.Memo && GetStrLen(pobjTabMainTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[TabMainType(TabMainType)|说明(Memo)]的长度不能超过1000!值:$(pobjTabMainTypeEN.Memo)(clsTabMainTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjTabMainTypeEN.TabMainTypeId && undefined !== pobjTabMainTypeEN.TabMainTypeId && tzDataType.isString(pobjTabMainTypeEN.TabMainTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[TabMainType(TabMainType)|表主类型Id(TabMainTypeId)]的值:[$(pobjTabMainTypeEN.TabMainTypeId)], 非法，应该为字符型!(clsTabMainTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabMainTypeEN.TabMainTypeName && undefined !== pobjTabMainTypeEN.TabMainTypeName && tzDataType.isString(pobjTabMainTypeEN.TabMainTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[TabMainType(TabMainType)|表主类型名(TabMainTypeName)]的值:[$(pobjTabMainTypeEN.TabMainTypeName)], 非法，应该为字符型!(clsTabMainTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabMainTypeEN.TabMainTypeENName && undefined !== pobjTabMainTypeEN.TabMainTypeENName && tzDataType.isString(pobjTabMainTypeEN.TabMainTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[TabMainType(TabMainType)|表主类型英文名(TabMainTypeENName)]的值:[$(pobjTabMainTypeEN.TabMainTypeENName)], 非法，应该为字符型!(clsTabMainTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabMainTypeEN.Memo && undefined !== pobjTabMainTypeEN.Memo && tzDataType.isString(pobjTabMainTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[TabMainType(TabMainType)|说明(Memo)]的值:[$(pobjTabMainTypeEN.Memo)], 非法，应该为字符型!(clsTabMainTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjTabMainTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsTabMainTypeBL.prototype.CheckProperty4Update  = function(pobjTabMainTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjTabMainTypeEN.TabMainTypeId && GetStrLen(pobjTabMainTypeEN.TabMainTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[TabMainType(TabMainType)|表主类型Id(TabMainTypeId)]的长度不能超过4!值:$(pobjTabMainTypeEN.TabMainTypeId)(clsTabMainTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabMainTypeEN.TabMainTypeName && GetStrLen(pobjTabMainTypeEN.TabMainTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[TabMainType(TabMainType)|表主类型名(TabMainTypeName)]的长度不能超过30!值:$(pobjTabMainTypeEN.TabMainTypeName)(clsTabMainTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabMainTypeEN.TabMainTypeENName && GetStrLen(pobjTabMainTypeEN.TabMainTypeENName) > 30)
{
 throw new Error("(errid:Busi000158)字段[TabMainType(TabMainType)|表主类型英文名(TabMainTypeENName)]的长度不能超过30!值:$(pobjTabMainTypeEN.TabMainTypeENName)(clsTabMainTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabMainTypeEN.Memo && GetStrLen(pobjTabMainTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[TabMainType(TabMainType)|说明(Memo)]的长度不能超过1000!值:$(pobjTabMainTypeEN.Memo)(clsTabMainTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjTabMainTypeEN.TabMainTypeId && undefined !== pobjTabMainTypeEN.TabMainTypeId && tzDataType.isString(pobjTabMainTypeEN.TabMainTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[TabMainType(TabMainType)|表主类型Id(TabMainTypeId)]的值:[$(pobjTabMainTypeEN.TabMainTypeId)], 非法，应该为字符型!(clsTabMainTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabMainTypeEN.TabMainTypeName && undefined !== pobjTabMainTypeEN.TabMainTypeName && tzDataType.isString(pobjTabMainTypeEN.TabMainTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[TabMainType(TabMainType)|表主类型名(TabMainTypeName)]的值:[$(pobjTabMainTypeEN.TabMainTypeName)], 非法，应该为字符型!(clsTabMainTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabMainTypeEN.TabMainTypeENName && undefined !== pobjTabMainTypeEN.TabMainTypeENName && tzDataType.isString(pobjTabMainTypeEN.TabMainTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[TabMainType(TabMainType)|表主类型英文名(TabMainTypeENName)]的值:[$(pobjTabMainTypeEN.TabMainTypeENName)], 非法，应该为字符型!(clsTabMainTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabMainTypeEN.Memo && undefined !== pobjTabMainTypeEN.Memo && tzDataType.isString(pobjTabMainTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[TabMainType(TabMainType)|说明(Memo)]的值:[$(pobjTabMainTypeEN.Memo)], 非法，应该为字符型!(clsTabMainTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjTabMainTypeEN.TabMainTypeId 
 || null !== pobjTabMainTypeEN.TabMainTypeId && pobjTabMainTypeEN.TabMainTypeId.toString()  ===  ""
 || null !== pobjTabMainTypeEN.TabMainTypeId && pobjTabMainTypeEN.TabMainTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[TabMainType|表主类型Id]不能为空(NULL)!(clsTabMainTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjTabMainTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200502010557
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsTabMainTypeBL.GetJSONStrByObj  = function(pobjTabMainTypeEN)
{
pobjTabMainTypeEN.sf_UpdFldSetStr = pobjTabMainTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjTabMainTypeEN);
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
 /// 日期:20200502010557
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsTabMainTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrTabMainTypeObjLst = new Array();
if (strJSON === "")
{
return arrTabMainTypeObjLst;
}
try
{
arrTabMainTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrTabMainTypeObjLst;
}
return arrTabMainTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200502010557
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsTabMainTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjTabMainTypeEN = new clsTabMainTypeEN();
if (strJSON === "")
{
return pobjTabMainTypeEN;
}
try
{
pobjTabMainTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjTabMainTypeEN;
}
return pobjTabMainTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objTabMainTypeENS">源简化对象</param>
 /// <param name = "objTabMainTypeENT">目标对象</param>
clsTabMainTypeBL.CopyObjFromSimObj = function(objTabMainTypeENS, objTabMainTypeENT) 
{
objTabMainTypeENT.TabMainTypeId = objTabMainTypeENS.TabMainTypeId; //表主类型Id
objTabMainTypeENT.TabMainTypeName = objTabMainTypeENS.TabMainTypeName; //表主类型名
objTabMainTypeENT.TabMainTypeENName = objTabMainTypeENS.TabMainTypeENName; //表主类型英文名
objTabMainTypeENT.Memo = objTabMainTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objTabMainTypeENS">源对象</param>
 /// <param name = "objTabMainTypeENT">目标对象</param>
clsTabMainTypeBL.CopyObjTo = function(objTabMainTypeENS , objTabMainTypeENT ) 
{
objTabMainTypeENT.TabMainTypeId = objTabMainTypeENS.TabMainTypeId; //表主类型Id
objTabMainTypeENT.TabMainTypeName = objTabMainTypeENS.TabMainTypeName; //表主类型名
objTabMainTypeENT.TabMainTypeENName = objTabMainTypeENS.TabMainTypeENName; //表主类型英文名
objTabMainTypeENT.Memo = objTabMainTypeENS.Memo; //说明
objTabMainTypeENT.sf_UpdFldSetStr = objTabMainTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objTabMainTypeENS">源对象</param>
 /// <param name = "objTabMainTypeENT">目标对象</param>
clsTabMainTypeBL.CopyObjToSimObj = function(objTabMainTypeENS , objTabMainTypeENT ) 
{
objTabMainTypeENT.TabMainTypeId = objTabMainTypeENS.TabMainTypeId; //表主类型Id
objTabMainTypeENT.TabMainTypeName = objTabMainTypeENS.TabMainTypeName; //表主类型名
objTabMainTypeENT.TabMainTypeENName = objTabMainTypeENS.TabMainTypeENName; //表主类型英文名
objTabMainTypeENT.Memo = objTabMainTypeENS.Memo; //说明
objTabMainTypeENT.sf_UpdFldSetStr = objTabMainTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objTabMainTypeENT.sf_FldComparisonOp = objTabMainTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objTabMainTypeENS">源简化对象</param>
 /// <param name = "objTabMainTypeENT">目标对象</param>
clsTabMainTypeBL.CopyObjFromSimObj4Upd = function(objTabMainTypeENS, objTabMainTypeENT )
 {
   var strsf_UpdFldSetStr = objTabMainTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsTabMainTypeEN.con_TabMainTypeId)  >= 0)
{
objTabMainTypeENT.TabMainTypeId = objTabMainTypeENS.TabMainTypeId; //表主类型Id
}
if (sstrFldSet.indexOf(clsTabMainTypeEN.con_TabMainTypeName)  >= 0)
{
objTabMainTypeENT.TabMainTypeName = objTabMainTypeENS.TabMainTypeName; //表主类型名
}
if (sstrFldSet.indexOf(clsTabMainTypeEN.con_TabMainTypeENName)  >= 0)
{
objTabMainTypeENT.TabMainTypeENName = objTabMainTypeENS.TabMainTypeENName; //表主类型英文名
}
if (sstrFldSet.indexOf(clsTabMainTypeEN.con_Memo)  >= 0)
{
objTabMainTypeENT.Memo = objTabMainTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objTabMainTypeENS">源对象</param>
 /// <param name = "objTabMainTypeENT">目标对象</param>
clsTabMainTypeBL.GetSimObjFromObj = function(objTabMainTypeENS)
{
var objTabMainTypeENT = new clsTabMainTypeEN_Sim_js_1.clsTabMainTypeEN_Sim();
objTabMainTypeENT.TabMainTypeId = objTabMainTypeENS.TabMainTypeId; //表主类型Id
objTabMainTypeENT.TabMainTypeName = objTabMainTypeENS.TabMainTypeName; //表主类型名
objTabMainTypeENT.TabMainTypeENName = objTabMainTypeENS.TabMainTypeENName; //表主类型英文名
objTabMainTypeENT.Memo = objTabMainTypeENS.Memo; //说明
objTabMainTypeENT.sf_UpdFldSetStr = objTabMainTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objTabMainTypeENT.sf_FldComparisonOp = objTabMainTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objTabMainTypeENT;
}
return clsTabMainTypeBL;
}());
exports.clsTabMainTypeBL = clsTabMainTypeBL;
});