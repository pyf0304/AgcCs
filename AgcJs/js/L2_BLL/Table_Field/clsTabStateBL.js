
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabStateBL
 表名:TabState(00050108)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:01
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsTabStateEN.js","../../L0_Entity/Table_Field/clsTabStateEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsTabStateEN_js_1 = require("../../L0_Entity/Table_Field/clsTabStateEN.js");
var clsTabStateEN_Sim_js_1 = require("../../L0_Entity/Table_Field/clsTabStateEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 表状态(TabState)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsTabStateBL = /** @class */ (function () {
function clsTabStateBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrTabStateObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsTabStateBL.prototype.CheckPropertyNew = function(pobjTabStateEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjTabStateEN.TabStateName 
 || null !== pobjTabStateEN.TabStateName && pobjTabStateEN.TabStateName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[表状态|表状态名称]不能为空(NULL)!(clsTabStateBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjTabStateEN.TabStateId && GetStrLen(pobjTabStateEN.TabStateId) > 2)
{
 throw new Error("(errid:Busi000155)字段[表状态(TabState)|表状态ID(TabStateId)]的长度不能超过2!值:$(pobjTabStateEN.TabStateId)(clsTabStateBL:CheckPropertyNew)");
}
if (null !== pobjTabStateEN.TabStateName && GetStrLen(pobjTabStateEN.TabStateName) > 30)
{
 throw new Error("(errid:Busi000155)字段[表状态(TabState)|表状态名称(TabStateName)]的长度不能超过30!值:$(pobjTabStateEN.TabStateName)(clsTabStateBL:CheckPropertyNew)");
}
if (null !== pobjTabStateEN.TabStateENName && GetStrLen(pobjTabStateEN.TabStateENName) > 30)
{
 throw new Error("(errid:Busi000155)字段[表状态(TabState)|表状态英文名(TabStateENName)]的长度不能超过30!值:$(pobjTabStateEN.TabStateENName)(clsTabStateBL:CheckPropertyNew)");
}
if (null !== pobjTabStateEN.Memo && GetStrLen(pobjTabStateEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[表状态(TabState)|说明(Memo)]的长度不能超过1000!值:$(pobjTabStateEN.Memo)(clsTabStateBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjTabStateEN.TabStateId && undefined !== pobjTabStateEN.TabStateId && tzDataType.isString(pobjTabStateEN.TabStateId) === false)
{
 throw new Error("(errid:Busi000156)字段[表状态(TabState)|表状态ID(TabStateId)]的值:[$(pobjTabStateEN.TabStateId)], 非法，应该为字符型!(clsTabStateBL:CheckPropertyNew)");
}
if (null !== pobjTabStateEN.TabStateName && undefined !== pobjTabStateEN.TabStateName && tzDataType.isString(pobjTabStateEN.TabStateName) === false)
{
 throw new Error("(errid:Busi000156)字段[表状态(TabState)|表状态名称(TabStateName)]的值:[$(pobjTabStateEN.TabStateName)], 非法，应该为字符型!(clsTabStateBL:CheckPropertyNew)");
}
if (null !== pobjTabStateEN.TabStateENName && undefined !== pobjTabStateEN.TabStateENName && tzDataType.isString(pobjTabStateEN.TabStateENName) === false)
{
 throw new Error("(errid:Busi000156)字段[表状态(TabState)|表状态英文名(TabStateENName)]的值:[$(pobjTabStateEN.TabStateENName)], 非法，应该为字符型!(clsTabStateBL:CheckPropertyNew)");
}
if (null !== pobjTabStateEN.Memo && undefined !== pobjTabStateEN.Memo && tzDataType.isString(pobjTabStateEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[表状态(TabState)|说明(Memo)]的值:[$(pobjTabStateEN.Memo)], 非法，应该为字符型!(clsTabStateBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjTabStateEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsTabStateBL.prototype.CheckProperty4Update  = function(pobjTabStateEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjTabStateEN.TabStateId && GetStrLen(pobjTabStateEN.TabStateId) > 2)
{
 throw new Error("(errid:Busi000158)字段[表状态(TabState)|表状态ID(TabStateId)]的长度不能超过2!值:$(pobjTabStateEN.TabStateId)(clsTabStateBL:CheckProperty4Update)");
}
if (null !== pobjTabStateEN.TabStateName && GetStrLen(pobjTabStateEN.TabStateName) > 30)
{
 throw new Error("(errid:Busi000158)字段[表状态(TabState)|表状态名称(TabStateName)]的长度不能超过30!值:$(pobjTabStateEN.TabStateName)(clsTabStateBL:CheckProperty4Update)");
}
if (null !== pobjTabStateEN.TabStateENName && GetStrLen(pobjTabStateEN.TabStateENName) > 30)
{
 throw new Error("(errid:Busi000158)字段[表状态(TabState)|表状态英文名(TabStateENName)]的长度不能超过30!值:$(pobjTabStateEN.TabStateENName)(clsTabStateBL:CheckProperty4Update)");
}
if (null !== pobjTabStateEN.Memo && GetStrLen(pobjTabStateEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[表状态(TabState)|说明(Memo)]的长度不能超过1000!值:$(pobjTabStateEN.Memo)(clsTabStateBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjTabStateEN.TabStateId && undefined !== pobjTabStateEN.TabStateId && tzDataType.isString(pobjTabStateEN.TabStateId) === false)
{
 throw new Error("(errid:Busi000159)字段[表状态(TabState)|表状态ID(TabStateId)]的值:[$(pobjTabStateEN.TabStateId)], 非法，应该为字符型!(clsTabStateBL:CheckProperty4Update)");
}
if (null !== pobjTabStateEN.TabStateName && undefined !== pobjTabStateEN.TabStateName && tzDataType.isString(pobjTabStateEN.TabStateName) === false)
{
 throw new Error("(errid:Busi000159)字段[表状态(TabState)|表状态名称(TabStateName)]的值:[$(pobjTabStateEN.TabStateName)], 非法，应该为字符型!(clsTabStateBL:CheckProperty4Update)");
}
if (null !== pobjTabStateEN.TabStateENName && undefined !== pobjTabStateEN.TabStateENName && tzDataType.isString(pobjTabStateEN.TabStateENName) === false)
{
 throw new Error("(errid:Busi000159)字段[表状态(TabState)|表状态英文名(TabStateENName)]的值:[$(pobjTabStateEN.TabStateENName)], 非法，应该为字符型!(clsTabStateBL:CheckProperty4Update)");
}
if (null !== pobjTabStateEN.Memo && undefined !== pobjTabStateEN.Memo && tzDataType.isString(pobjTabStateEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[表状态(TabState)|说明(Memo)]的值:[$(pobjTabStateEN.Memo)], 非法，应该为字符型!(clsTabStateBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjTabStateEN.TabStateId 
 || null !== pobjTabStateEN.TabStateId && pobjTabStateEN.TabStateId.toString()  ===  ""
 || null !== pobjTabStateEN.TabStateId && pobjTabStateEN.TabStateId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[表状态|表状态ID]不能为空(NULL)!(clsTabStateBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjTabStateEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200502010601
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsTabStateBL.GetJSONStrByObj  = function(pobjTabStateEN)
{
pobjTabStateEN.sf_UpdFldSetStr = pobjTabStateEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjTabStateEN);
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
 /// 日期:20200502010601
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsTabStateBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrTabStateObjLst = new Array();
if (strJSON === "")
{
return arrTabStateObjLst;
}
try
{
arrTabStateObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrTabStateObjLst;
}
return arrTabStateObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200502010601
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsTabStateBL.GetObjByJSONStr  = function(strJSON)
{
var pobjTabStateEN = new clsTabStateEN();
if (strJSON === "")
{
return pobjTabStateEN;
}
try
{
pobjTabStateEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjTabStateEN;
}
return pobjTabStateEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objTabStateENS">源简化对象</param>
 /// <param name = "objTabStateENT">目标对象</param>
clsTabStateBL.CopyObjFromSimObj = function(objTabStateENS, objTabStateENT) 
{
objTabStateENT.TabStateId = objTabStateENS.TabStateId; //表状态ID
objTabStateENT.TabStateName = objTabStateENS.TabStateName; //表状态名称
objTabStateENT.TabStateENName = objTabStateENS.TabStateENName; //表状态英文名
objTabStateENT.Memo = objTabStateENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objTabStateENS">源对象</param>
 /// <param name = "objTabStateENT">目标对象</param>
clsTabStateBL.CopyObjTo = function(objTabStateENS , objTabStateENT ) 
{
objTabStateENT.TabStateId = objTabStateENS.TabStateId; //表状态ID
objTabStateENT.TabStateName = objTabStateENS.TabStateName; //表状态名称
objTabStateENT.TabStateENName = objTabStateENS.TabStateENName; //表状态英文名
objTabStateENT.Memo = objTabStateENS.Memo; //说明
objTabStateENT.sf_UpdFldSetStr = objTabStateENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objTabStateENS">源对象</param>
 /// <param name = "objTabStateENT">目标对象</param>
clsTabStateBL.CopyObjToSimObj = function(objTabStateENS , objTabStateENT ) 
{
objTabStateENT.TabStateId = objTabStateENS.TabStateId; //表状态ID
objTabStateENT.TabStateName = objTabStateENS.TabStateName; //表状态名称
objTabStateENT.TabStateENName = objTabStateENS.TabStateENName; //表状态英文名
objTabStateENT.Memo = objTabStateENS.Memo; //说明
objTabStateENT.sf_UpdFldSetStr = objTabStateENS.UpdFldString; //专门用于记录某字段属性是否修改
objTabStateENT.sf_FldComparisonOp = objTabStateENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objTabStateENS">源简化对象</param>
 /// <param name = "objTabStateENT">目标对象</param>
clsTabStateBL.CopyObjFromSimObj4Upd = function(objTabStateENS, objTabStateENT )
 {
   var strsf_UpdFldSetStr = objTabStateENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsTabStateEN.con_TabStateId)  >= 0)
{
objTabStateENT.TabStateId = objTabStateENS.TabStateId; //表状态ID
}
if (sstrFldSet.indexOf(clsTabStateEN.con_TabStateName)  >= 0)
{
objTabStateENT.TabStateName = objTabStateENS.TabStateName; //表状态名称
}
if (sstrFldSet.indexOf(clsTabStateEN.con_TabStateENName)  >= 0)
{
objTabStateENT.TabStateENName = objTabStateENS.TabStateENName; //表状态英文名
}
if (sstrFldSet.indexOf(clsTabStateEN.con_Memo)  >= 0)
{
objTabStateENT.Memo = objTabStateENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objTabStateENS">源对象</param>
 /// <param name = "objTabStateENT">目标对象</param>
clsTabStateBL.GetSimObjFromObj = function(objTabStateENS)
{
var objTabStateENT = new clsTabStateEN_Sim_js_1.clsTabStateEN_Sim();
objTabStateENT.TabStateId = objTabStateENS.TabStateId; //表状态ID
objTabStateENT.TabStateName = objTabStateENS.TabStateName; //表状态名称
objTabStateENT.TabStateENName = objTabStateENS.TabStateENName; //表状态英文名
objTabStateENT.Memo = objTabStateENS.Memo; //说明
objTabStateENT.sf_UpdFldSetStr = objTabStateENS.UpdFldString; //专门用于记录某字段属性是否修改
objTabStateENT.sf_FldComparisonOp = objTabStateENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objTabStateENT;
}
return clsTabStateBL;
}());
exports.clsTabStateBL = clsTabStateBL;
});