
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFrontAndBack4AppTypeBL
 表名:FrontAndBack4AppType(00050423)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:55
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:生成代码
 模块英文名:GeneCode
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
define(["require", "exports", "jquery", "../../L0_Entity/GeneCode/clsFrontAndBack4AppTypeEN.js","../../L0_Entity/GeneCode/clsFrontAndBack4AppTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsFrontAndBack4AppTypeEN_js_1 = require("../../L0_Entity/GeneCode/clsFrontAndBack4AppTypeEN.js");
var clsFrontAndBack4AppTypeEN_Sim_js_1 = require("../../L0_Entity/GeneCode/clsFrontAndBack4AppTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 应用类型的前后台关系(FrontAndBack4AppType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsFrontAndBack4AppTypeBL = /** @class */ (function () {
function clsFrontAndBack4AppTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrFrontAndBack4AppTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsFrontAndBack4AppTypeBL.prototype.CheckPropertyNew = function(pobjFrontAndBack4AppTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjFrontAndBack4AppTypeEN.AppTypeId4Front 
 || null !== pobjFrontAndBack4AppTypeEN.AppTypeId4Front && pobjFrontAndBack4AppTypeEN.AppTypeId4Front.toString()  ===  ""
 || null !== pobjFrontAndBack4AppTypeEN.AppTypeId4Front && pobjFrontAndBack4AppTypeEN.AppTypeId4Front.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[应用类型的前后台关系|应用类型Id4Front]不能为空(NULL)!(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
if (null === pobjFrontAndBack4AppTypeEN.AppTypeId4Back 
 || null !== pobjFrontAndBack4AppTypeEN.AppTypeId4Back && pobjFrontAndBack4AppTypeEN.AppTypeId4Back.toString()  ===  ""
 || null !== pobjFrontAndBack4AppTypeEN.AppTypeId4Back && pobjFrontAndBack4AppTypeEN.AppTypeId4Back.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[应用类型的前后台关系|应用类型Id4Back]不能为空(NULL)!(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjFrontAndBack4AppTypeEN.UpdDate && GetStrLen(pobjFrontAndBack4AppTypeEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[应用类型的前后台关系(FrontAndBack4AppType)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjFrontAndBack4AppTypeEN.UpdDate)(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
if (null !== pobjFrontAndBack4AppTypeEN.UpdUser && GetStrLen(pobjFrontAndBack4AppTypeEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[应用类型的前后台关系(FrontAndBack4AppType)|修改者(UpdUser)]的长度不能超过20!值:$(pobjFrontAndBack4AppTypeEN.UpdUser)(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
if (null !== pobjFrontAndBack4AppTypeEN.Memo && GetStrLen(pobjFrontAndBack4AppTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[应用类型的前后台关系(FrontAndBack4AppType)|说明(Memo)]的长度不能超过1000!值:$(pobjFrontAndBack4AppTypeEN.Memo)(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjFrontAndBack4AppTypeEN.mId && undefined !== pobjFrontAndBack4AppTypeEN.mId && tzDataType.isNumber(pobjFrontAndBack4AppTypeEN.mId) === false)
{
 throw new Error("(errid:Busi000156)字段[应用类型的前后台关系(FrontAndBack4AppType)|mId(mId)]的值:[$(pobjFrontAndBack4AppTypeEN.mId)], 非法，应该为数值型!(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
if (null !== pobjFrontAndBack4AppTypeEN.AppTypeId4Front && undefined !== pobjFrontAndBack4AppTypeEN.AppTypeId4Front && tzDataType.isNumber(pobjFrontAndBack4AppTypeEN.AppTypeId4Front) === false)
{
 throw new Error("(errid:Busi000156)字段[应用类型的前后台关系(FrontAndBack4AppType)|应用类型Id4Front(AppTypeId4Front)]的值:[$(pobjFrontAndBack4AppTypeEN.AppTypeId4Front)], 非法，应该为数值型!(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
if (null !== pobjFrontAndBack4AppTypeEN.AppTypeId4Back && undefined !== pobjFrontAndBack4AppTypeEN.AppTypeId4Back && tzDataType.isNumber(pobjFrontAndBack4AppTypeEN.AppTypeId4Back) === false)
{
 throw new Error("(errid:Busi000156)字段[应用类型的前后台关系(FrontAndBack4AppType)|应用类型Id4Back(AppTypeId4Back)]的值:[$(pobjFrontAndBack4AppTypeEN.AppTypeId4Back)], 非法，应该为数值型!(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
if (null !== pobjFrontAndBack4AppTypeEN.UpdDate && undefined !== pobjFrontAndBack4AppTypeEN.UpdDate && tzDataType.isString(pobjFrontAndBack4AppTypeEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[应用类型的前后台关系(FrontAndBack4AppType)|修改日期(UpdDate)]的值:[$(pobjFrontAndBack4AppTypeEN.UpdDate)], 非法，应该为字符型!(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
if (null !== pobjFrontAndBack4AppTypeEN.UpdUser && undefined !== pobjFrontAndBack4AppTypeEN.UpdUser && tzDataType.isString(pobjFrontAndBack4AppTypeEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[应用类型的前后台关系(FrontAndBack4AppType)|修改者(UpdUser)]的值:[$(pobjFrontAndBack4AppTypeEN.UpdUser)], 非法，应该为字符型!(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
if (null !== pobjFrontAndBack4AppTypeEN.Memo && undefined !== pobjFrontAndBack4AppTypeEN.Memo && tzDataType.isString(pobjFrontAndBack4AppTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[应用类型的前后台关系(FrontAndBack4AppType)|说明(Memo)]的值:[$(pobjFrontAndBack4AppTypeEN.Memo)], 非法，应该为字符型!(clsFrontAndBack4AppTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjFrontAndBack4AppTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsFrontAndBack4AppTypeBL.prototype.CheckProperty4Update  = function(pobjFrontAndBack4AppTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjFrontAndBack4AppTypeEN.UpdDate && GetStrLen(pobjFrontAndBack4AppTypeEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[应用类型的前后台关系(FrontAndBack4AppType)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjFrontAndBack4AppTypeEN.UpdDate)(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
if (null !== pobjFrontAndBack4AppTypeEN.UpdUser && GetStrLen(pobjFrontAndBack4AppTypeEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[应用类型的前后台关系(FrontAndBack4AppType)|修改者(UpdUser)]的长度不能超过20!值:$(pobjFrontAndBack4AppTypeEN.UpdUser)(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
if (null !== pobjFrontAndBack4AppTypeEN.Memo && GetStrLen(pobjFrontAndBack4AppTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[应用类型的前后台关系(FrontAndBack4AppType)|说明(Memo)]的长度不能超过1000!值:$(pobjFrontAndBack4AppTypeEN.Memo)(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjFrontAndBack4AppTypeEN.mId && undefined !== pobjFrontAndBack4AppTypeEN.mId && tzDataType.isNumber(pobjFrontAndBack4AppTypeEN.mId) === false)
{
 throw new Error("(errid:Busi000159)字段[应用类型的前后台关系(FrontAndBack4AppType)|mId(mId)]的值:[$(pobjFrontAndBack4AppTypeEN.mId)], 非法，应该为数值型!(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
if (null !== pobjFrontAndBack4AppTypeEN.AppTypeId4Front && undefined !== pobjFrontAndBack4AppTypeEN.AppTypeId4Front && tzDataType.isNumber(pobjFrontAndBack4AppTypeEN.AppTypeId4Front) === false)
{
 throw new Error("(errid:Busi000159)字段[应用类型的前后台关系(FrontAndBack4AppType)|应用类型Id4Front(AppTypeId4Front)]的值:[$(pobjFrontAndBack4AppTypeEN.AppTypeId4Front)], 非法，应该为数值型!(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
if (null !== pobjFrontAndBack4AppTypeEN.AppTypeId4Back && undefined !== pobjFrontAndBack4AppTypeEN.AppTypeId4Back && tzDataType.isNumber(pobjFrontAndBack4AppTypeEN.AppTypeId4Back) === false)
{
 throw new Error("(errid:Busi000159)字段[应用类型的前后台关系(FrontAndBack4AppType)|应用类型Id4Back(AppTypeId4Back)]的值:[$(pobjFrontAndBack4AppTypeEN.AppTypeId4Back)], 非法，应该为数值型!(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
if (null !== pobjFrontAndBack4AppTypeEN.UpdDate && undefined !== pobjFrontAndBack4AppTypeEN.UpdDate && tzDataType.isString(pobjFrontAndBack4AppTypeEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[应用类型的前后台关系(FrontAndBack4AppType)|修改日期(UpdDate)]的值:[$(pobjFrontAndBack4AppTypeEN.UpdDate)], 非法，应该为字符型!(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
if (null !== pobjFrontAndBack4AppTypeEN.UpdUser && undefined !== pobjFrontAndBack4AppTypeEN.UpdUser && tzDataType.isString(pobjFrontAndBack4AppTypeEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[应用类型的前后台关系(FrontAndBack4AppType)|修改者(UpdUser)]的值:[$(pobjFrontAndBack4AppTypeEN.UpdUser)], 非法，应该为字符型!(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
if (null !== pobjFrontAndBack4AppTypeEN.Memo && undefined !== pobjFrontAndBack4AppTypeEN.Memo && tzDataType.isString(pobjFrontAndBack4AppTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[应用类型的前后台关系(FrontAndBack4AppType)|说明(Memo)]的值:[$(pobjFrontAndBack4AppTypeEN.Memo)], 非法，应该为字符型!(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjFrontAndBack4AppTypeEN.mId 
 || null !== pobjFrontAndBack4AppTypeEN.mId && pobjFrontAndBack4AppTypeEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Busi000160)字段[应用类型的前后台关系|mId]不能为空(NULL)!(clsFrontAndBack4AppTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjFrontAndBack4AppTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024955
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsFrontAndBack4AppTypeBL.GetJSONStrByObj  = function(pobjFrontAndBack4AppTypeEN)
{
pobjFrontAndBack4AppTypeEN.sf_UpdFldSetStr = pobjFrontAndBack4AppTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjFrontAndBack4AppTypeEN);
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
 /// 日期:20200501024955
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsFrontAndBack4AppTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrFrontAndBack4AppTypeObjLst = new Array();
if (strJSON === "")
{
return arrFrontAndBack4AppTypeObjLst;
}
try
{
arrFrontAndBack4AppTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrFrontAndBack4AppTypeObjLst;
}
return arrFrontAndBack4AppTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024955
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsFrontAndBack4AppTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
if (strJSON === "")
{
return pobjFrontAndBack4AppTypeEN;
}
try
{
pobjFrontAndBack4AppTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjFrontAndBack4AppTypeEN;
}
return pobjFrontAndBack4AppTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeENS">源简化对象</param>
 /// <param name = "objFrontAndBack4AppTypeENT">目标对象</param>
clsFrontAndBack4AppTypeBL.CopyObjFromSimObj = function(objFrontAndBack4AppTypeENS, objFrontAndBack4AppTypeENT) 
{
objFrontAndBack4AppTypeENT.mId = objFrontAndBack4AppTypeENS.mId; //mId
objFrontAndBack4AppTypeENT.AppTypeId4Front = objFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objFrontAndBack4AppTypeENT.AppTypeId4Back = objFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objFrontAndBack4AppTypeENT.UpdDate = objFrontAndBack4AppTypeENS.UpdDate; //修改日期
objFrontAndBack4AppTypeENT.UpdUser = objFrontAndBack4AppTypeENS.UpdUser; //修改者
objFrontAndBack4AppTypeENT.Memo = objFrontAndBack4AppTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objFrontAndBack4AppTypeENT">目标对象</param>
clsFrontAndBack4AppTypeBL.CopyObjTo = function(objFrontAndBack4AppTypeENS , objFrontAndBack4AppTypeENT ) 
{
objFrontAndBack4AppTypeENT.mId = objFrontAndBack4AppTypeENS.mId; //mId
objFrontAndBack4AppTypeENT.AppTypeId4Front = objFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objFrontAndBack4AppTypeENT.AppTypeId4Back = objFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objFrontAndBack4AppTypeENT.UpdDate = objFrontAndBack4AppTypeENS.UpdDate; //修改日期
objFrontAndBack4AppTypeENT.UpdUser = objFrontAndBack4AppTypeENS.UpdUser; //修改者
objFrontAndBack4AppTypeENT.Memo = objFrontAndBack4AppTypeENS.Memo; //说明
objFrontAndBack4AppTypeENT.sf_UpdFldSetStr = objFrontAndBack4AppTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objFrontAndBack4AppTypeENT">目标对象</param>
clsFrontAndBack4AppTypeBL.CopyObjToSimObj = function(objFrontAndBack4AppTypeENS , objFrontAndBack4AppTypeENT ) 
{
objFrontAndBack4AppTypeENT.mId = objFrontAndBack4AppTypeENS.mId; //mId
objFrontAndBack4AppTypeENT.AppTypeId4Front = objFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objFrontAndBack4AppTypeENT.AppTypeId4Back = objFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objFrontAndBack4AppTypeENT.UpdDate = objFrontAndBack4AppTypeENS.UpdDate; //修改日期
objFrontAndBack4AppTypeENT.UpdUser = objFrontAndBack4AppTypeENS.UpdUser; //修改者
objFrontAndBack4AppTypeENT.Memo = objFrontAndBack4AppTypeENS.Memo; //说明
objFrontAndBack4AppTypeENT.sf_UpdFldSetStr = objFrontAndBack4AppTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objFrontAndBack4AppTypeENT.sf_FldComparisonOp = objFrontAndBack4AppTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeENS">源简化对象</param>
 /// <param name = "objFrontAndBack4AppTypeENT">目标对象</param>
clsFrontAndBack4AppTypeBL.CopyObjFromSimObj4Upd = function(objFrontAndBack4AppTypeENS, objFrontAndBack4AppTypeENT )
 {
   var strsf_UpdFldSetStr = objFrontAndBack4AppTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsFrontAndBack4AppTypeEN.con_mId)  >= 0)
{
objFrontAndBack4AppTypeENT.mId = objFrontAndBack4AppTypeENS.mId; //mId
}
if (sstrFldSet.indexOf(clsFrontAndBack4AppTypeEN.con_AppTypeId4Front)  >= 0)
{
objFrontAndBack4AppTypeENT.AppTypeId4Front = objFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
}
if (sstrFldSet.indexOf(clsFrontAndBack4AppTypeEN.con_AppTypeId4Back)  >= 0)
{
objFrontAndBack4AppTypeENT.AppTypeId4Back = objFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
}
if (sstrFldSet.indexOf(clsFrontAndBack4AppTypeEN.con_UpdDate)  >= 0)
{
objFrontAndBack4AppTypeENT.UpdDate = objFrontAndBack4AppTypeENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsFrontAndBack4AppTypeEN.con_UpdUser)  >= 0)
{
objFrontAndBack4AppTypeENT.UpdUser = objFrontAndBack4AppTypeENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsFrontAndBack4AppTypeEN.con_Memo)  >= 0)
{
objFrontAndBack4AppTypeENT.Memo = objFrontAndBack4AppTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objFrontAndBack4AppTypeENT">目标对象</param>
clsFrontAndBack4AppTypeBL.GetSimObjFromObj = function(objFrontAndBack4AppTypeENS)
{
var objFrontAndBack4AppTypeENT = new clsFrontAndBack4AppTypeEN_Sim_js_1.clsFrontAndBack4AppTypeEN_Sim();
objFrontAndBack4AppTypeENT.mId = objFrontAndBack4AppTypeENS.mId; //mId
objFrontAndBack4AppTypeENT.AppTypeId4Front = objFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objFrontAndBack4AppTypeENT.AppTypeId4Back = objFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objFrontAndBack4AppTypeENT.UpdDate = objFrontAndBack4AppTypeENS.UpdDate; //修改日期
objFrontAndBack4AppTypeENT.UpdUser = objFrontAndBack4AppTypeENS.UpdUser; //修改者
objFrontAndBack4AppTypeENT.Memo = objFrontAndBack4AppTypeENS.Memo; //说明
objFrontAndBack4AppTypeENT.sf_UpdFldSetStr = objFrontAndBack4AppTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objFrontAndBack4AppTypeENT.sf_FldComparisonOp = objFrontAndBack4AppTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objFrontAndBack4AppTypeENT;
}
return clsFrontAndBack4AppTypeBL;
}());
exports.clsFrontAndBack4AppTypeBL = clsFrontAndBack4AppTypeBL;
});