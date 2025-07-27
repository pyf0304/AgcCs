
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTabTypeBL
 表名:ViewTabType(00050103)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:26
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsViewTabTypeEN.js","../../L0_Entity/PrjInterface/clsViewTabTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsViewTabTypeEN_js_1 = require("../../L0_Entity/PrjInterface/clsViewTabTypeEN.js");
var clsViewTabTypeEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsViewTabTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 界面表类型(ViewTabType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsViewTabTypeBL = /** @class */ (function () {
function clsViewTabTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrViewTabTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewTabTypeBL.prototype.CheckPropertyNew = function(pobjViewTabTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjViewTabTypeEN.ViewTabTypeName 
 || null !== pobjViewTabTypeEN.ViewTabTypeName && pobjViewTabTypeEN.ViewTabTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面表类型|ViewTabTypeName]不能为空(NULL)!(clsViewTabTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewTabTypeEN.ViewTabTypeId && GetStrLen(pobjViewTabTypeEN.ViewTabTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[界面表类型(ViewTabType)|界面表类型码(ViewTabTypeId)]的长度不能超过4!值:$(pobjViewTabTypeEN.ViewTabTypeId)(clsViewTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjViewTabTypeEN.ViewTabTypeName && GetStrLen(pobjViewTabTypeEN.ViewTabTypeName) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面表类型(ViewTabType)|ViewTabTypeName(ViewTabTypeName)]的长度不能超过20!值:$(pobjViewTabTypeEN.ViewTabTypeName)(clsViewTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjViewTabTypeEN.TabTypeFunction && GetStrLen(pobjViewTabTypeEN.TabTypeFunction) > 500)
{
 throw new Error("(errid:Busi000155)字段[界面表类型(ViewTabType)|TabTypeFunction(TabTypeFunction)]的长度不能超过500!值:$(pobjViewTabTypeEN.TabTypeFunction)(clsViewTabTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewTabTypeEN.ViewTabTypeId && undefined !== pobjViewTabTypeEN.ViewTabTypeId && tzDataType.isString(pobjViewTabTypeEN.ViewTabTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面表类型(ViewTabType)|界面表类型码(ViewTabTypeId)]的值:[$(pobjViewTabTypeEN.ViewTabTypeId)], 非法，应该为字符型!(clsViewTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjViewTabTypeEN.ViewTabTypeName && undefined !== pobjViewTabTypeEN.ViewTabTypeName && tzDataType.isString(pobjViewTabTypeEN.ViewTabTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面表类型(ViewTabType)|ViewTabTypeName(ViewTabTypeName)]的值:[$(pobjViewTabTypeEN.ViewTabTypeName)], 非法，应该为字符型!(clsViewTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjViewTabTypeEN.TabTypeFunction && undefined !== pobjViewTabTypeEN.TabTypeFunction && tzDataType.isString(pobjViewTabTypeEN.TabTypeFunction) === false)
{
 throw new Error("(errid:Busi000156)字段[界面表类型(ViewTabType)|TabTypeFunction(TabTypeFunction)]的值:[$(pobjViewTabTypeEN.TabTypeFunction)], 非法，应该为字符型!(clsViewTabTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjViewTabTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewTabTypeBL.prototype.CheckProperty4Update  = function(pobjViewTabTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewTabTypeEN.ViewTabTypeId && GetStrLen(pobjViewTabTypeEN.ViewTabTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[界面表类型(ViewTabType)|界面表类型码(ViewTabTypeId)]的长度不能超过4!值:$(pobjViewTabTypeEN.ViewTabTypeId)(clsViewTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjViewTabTypeEN.ViewTabTypeName && GetStrLen(pobjViewTabTypeEN.ViewTabTypeName) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面表类型(ViewTabType)|ViewTabTypeName(ViewTabTypeName)]的长度不能超过20!值:$(pobjViewTabTypeEN.ViewTabTypeName)(clsViewTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjViewTabTypeEN.TabTypeFunction && GetStrLen(pobjViewTabTypeEN.TabTypeFunction) > 500)
{
 throw new Error("(errid:Busi000158)字段[界面表类型(ViewTabType)|TabTypeFunction(TabTypeFunction)]的长度不能超过500!值:$(pobjViewTabTypeEN.TabTypeFunction)(clsViewTabTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewTabTypeEN.ViewTabTypeId && undefined !== pobjViewTabTypeEN.ViewTabTypeId && tzDataType.isString(pobjViewTabTypeEN.ViewTabTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面表类型(ViewTabType)|界面表类型码(ViewTabTypeId)]的值:[$(pobjViewTabTypeEN.ViewTabTypeId)], 非法，应该为字符型!(clsViewTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjViewTabTypeEN.ViewTabTypeName && undefined !== pobjViewTabTypeEN.ViewTabTypeName && tzDataType.isString(pobjViewTabTypeEN.ViewTabTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面表类型(ViewTabType)|ViewTabTypeName(ViewTabTypeName)]的值:[$(pobjViewTabTypeEN.ViewTabTypeName)], 非法，应该为字符型!(clsViewTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjViewTabTypeEN.TabTypeFunction && undefined !== pobjViewTabTypeEN.TabTypeFunction && tzDataType.isString(pobjViewTabTypeEN.TabTypeFunction) === false)
{
 throw new Error("(errid:Busi000159)字段[界面表类型(ViewTabType)|TabTypeFunction(TabTypeFunction)]的值:[$(pobjViewTabTypeEN.TabTypeFunction)], 非法，应该为字符型!(clsViewTabTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjViewTabTypeEN.ViewTabTypeId 
 || null !== pobjViewTabTypeEN.ViewTabTypeId && pobjViewTabTypeEN.ViewTabTypeId.toString()  ===  ""
 || null !== pobjViewTabTypeEN.ViewTabTypeId && pobjViewTabTypeEN.ViewTabTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[界面表类型|界面表类型码]不能为空(NULL)!(clsViewTabTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjViewTabTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024926
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewTabTypeBL.GetJSONStrByObj  = function(pobjViewTabTypeEN)
{
pobjViewTabTypeEN.sf_UpdFldSetStr = pobjViewTabTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjViewTabTypeEN);
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
 /// 日期:20200501024926
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsViewTabTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrViewTabTypeObjLst = new Array();
if (strJSON === "")
{
return arrViewTabTypeObjLst;
}
try
{
arrViewTabTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrViewTabTypeObjLst;
}
return arrViewTabTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024926
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewTabTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjViewTabTypeEN = new clsViewTabTypeEN();
if (strJSON === "")
{
return pobjViewTabTypeEN;
}
try
{
pobjViewTabTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjViewTabTypeEN;
}
return pobjViewTabTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objViewTabTypeENS">源简化对象</param>
 /// <param name = "objViewTabTypeENT">目标对象</param>
clsViewTabTypeBL.CopyObjFromSimObj = function(objViewTabTypeENS, objViewTabTypeENT) 
{
objViewTabTypeENT.ViewTabTypeId = objViewTabTypeENS.ViewTabTypeId; //界面表类型码
objViewTabTypeENT.ViewTabTypeName = objViewTabTypeENS.ViewTabTypeName; //ViewTabTypeName
objViewTabTypeENT.TabTypeFunction = objViewTabTypeENS.TabTypeFunction; //TabTypeFunction
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objViewTabTypeENS">源对象</param>
 /// <param name = "objViewTabTypeENT">目标对象</param>
clsViewTabTypeBL.CopyObjTo = function(objViewTabTypeENS , objViewTabTypeENT ) 
{
objViewTabTypeENT.ViewTabTypeId = objViewTabTypeENS.ViewTabTypeId; //界面表类型码
objViewTabTypeENT.ViewTabTypeName = objViewTabTypeENS.ViewTabTypeName; //ViewTabTypeName
objViewTabTypeENT.TabTypeFunction = objViewTabTypeENS.TabTypeFunction; //TabTypeFunction
objViewTabTypeENT.sf_UpdFldSetStr = objViewTabTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objViewTabTypeENS">源对象</param>
 /// <param name = "objViewTabTypeENT">目标对象</param>
clsViewTabTypeBL.CopyObjToSimObj = function(objViewTabTypeENS , objViewTabTypeENT ) 
{
objViewTabTypeENT.ViewTabTypeId = objViewTabTypeENS.ViewTabTypeId; //界面表类型码
objViewTabTypeENT.ViewTabTypeName = objViewTabTypeENS.ViewTabTypeName; //ViewTabTypeName
objViewTabTypeENT.TabTypeFunction = objViewTabTypeENS.TabTypeFunction; //TabTypeFunction
objViewTabTypeENT.sf_UpdFldSetStr = objViewTabTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewTabTypeENT.sf_FldComparisonOp = objViewTabTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objViewTabTypeENS">源简化对象</param>
 /// <param name = "objViewTabTypeENT">目标对象</param>
clsViewTabTypeBL.CopyObjFromSimObj4Upd = function(objViewTabTypeENS, objViewTabTypeENT )
 {
   var strsf_UpdFldSetStr = objViewTabTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsViewTabTypeEN.con_ViewTabTypeId)  >= 0)
{
objViewTabTypeENT.ViewTabTypeId = objViewTabTypeENS.ViewTabTypeId; //界面表类型码
}
if (sstrFldSet.indexOf(clsViewTabTypeEN.con_ViewTabTypeName)  >= 0)
{
objViewTabTypeENT.ViewTabTypeName = objViewTabTypeENS.ViewTabTypeName; //ViewTabTypeName
}
if (sstrFldSet.indexOf(clsViewTabTypeEN.con_TabTypeFunction)  >= 0)
{
objViewTabTypeENT.TabTypeFunction = objViewTabTypeENS.TabTypeFunction; //TabTypeFunction
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objViewTabTypeENS">源对象</param>
 /// <param name = "objViewTabTypeENT">目标对象</param>
clsViewTabTypeBL.GetSimObjFromObj = function(objViewTabTypeENS)
{
var objViewTabTypeENT = new clsViewTabTypeEN_Sim_js_1.clsViewTabTypeEN_Sim();
objViewTabTypeENT.ViewTabTypeId = objViewTabTypeENS.ViewTabTypeId; //界面表类型码
objViewTabTypeENT.ViewTabTypeName = objViewTabTypeENS.ViewTabTypeName; //ViewTabTypeName
objViewTabTypeENT.TabTypeFunction = objViewTabTypeENS.TabTypeFunction; //TabTypeFunction
objViewTabTypeENT.sf_UpdFldSetStr = objViewTabTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewTabTypeENT.sf_FldComparisonOp = objViewTabTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objViewTabTypeENT;
}
return clsViewTabTypeBL;
}());
exports.clsViewTabTypeBL = clsViewTabTypeBL;
});