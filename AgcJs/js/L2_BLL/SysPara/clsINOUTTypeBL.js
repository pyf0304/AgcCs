
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsINOUTTypeBL
 表名:INOUTType(00050135)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:24
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsINOUTTypeEN.js","../../L0_Entity/SysPara/clsINOUTTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsINOUTTypeEN_js_1 = require("../../L0_Entity/SysPara/clsINOUTTypeEN.js");
var clsINOUTTypeEN_Sim_js_1 = require("../../L0_Entity/SysPara/clsINOUTTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// InOut类型(INOUTType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsINOUTTypeBL = /** @class */ (function () {
function clsINOUTTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrINOUTTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsINOUTTypeBL.prototype.CheckPropertyNew = function(pobjINOUTTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjINOUTTypeEN.INOUTTypeName 
 || null !== pobjINOUTTypeEN.INOUTTypeName && pobjINOUTTypeEN.INOUTTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[InOut类型|INOUT类型名称]不能为空(NULL)!(clsINOUTTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjINOUTTypeEN.INOUTTypeId && GetStrLen(pobjINOUTTypeEN.INOUTTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[InOut类型(INOUTType)|INOUT类型ID(INOUTTypeId)]的长度不能超过2!值:$(pobjINOUTTypeEN.INOUTTypeId)(clsINOUTTypeBL:CheckPropertyNew)");
}
if (null !== pobjINOUTTypeEN.INOUTTypeName && GetStrLen(pobjINOUTTypeEN.INOUTTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[InOut类型(INOUTType)|INOUT类型名称(INOUTTypeName)]的长度不能超过30!值:$(pobjINOUTTypeEN.INOUTTypeName)(clsINOUTTypeBL:CheckPropertyNew)");
}
if (null !== pobjINOUTTypeEN.INOUTTypeENName && GetStrLen(pobjINOUTTypeEN.INOUTTypeENName) > 30)
{
 throw new Error("(errid:Busi000155)字段[InOut类型(INOUTType)|INOUT类型英文名(INOUTTypeENName)]的长度不能超过30!值:$(pobjINOUTTypeEN.INOUTTypeENName)(clsINOUTTypeBL:CheckPropertyNew)");
}
if (null !== pobjINOUTTypeEN.Memo && GetStrLen(pobjINOUTTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[InOut类型(INOUTType)|说明(Memo)]的长度不能超过1000!值:$(pobjINOUTTypeEN.Memo)(clsINOUTTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjINOUTTypeEN.INOUTTypeId && undefined !== pobjINOUTTypeEN.INOUTTypeId && tzDataType.isString(pobjINOUTTypeEN.INOUTTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[InOut类型(INOUTType)|INOUT类型ID(INOUTTypeId)]的值:[$(pobjINOUTTypeEN.INOUTTypeId)], 非法，应该为字符型!(clsINOUTTypeBL:CheckPropertyNew)");
}
if (null !== pobjINOUTTypeEN.INOUTTypeName && undefined !== pobjINOUTTypeEN.INOUTTypeName && tzDataType.isString(pobjINOUTTypeEN.INOUTTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[InOut类型(INOUTType)|INOUT类型名称(INOUTTypeName)]的值:[$(pobjINOUTTypeEN.INOUTTypeName)], 非法，应该为字符型!(clsINOUTTypeBL:CheckPropertyNew)");
}
if (null !== pobjINOUTTypeEN.INOUTTypeENName && undefined !== pobjINOUTTypeEN.INOUTTypeENName && tzDataType.isString(pobjINOUTTypeEN.INOUTTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[InOut类型(INOUTType)|INOUT类型英文名(INOUTTypeENName)]的值:[$(pobjINOUTTypeEN.INOUTTypeENName)], 非法，应该为字符型!(clsINOUTTypeBL:CheckPropertyNew)");
}
if (null !== pobjINOUTTypeEN.Memo && undefined !== pobjINOUTTypeEN.Memo && tzDataType.isString(pobjINOUTTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[InOut类型(INOUTType)|说明(Memo)]的值:[$(pobjINOUTTypeEN.Memo)], 非法，应该为字符型!(clsINOUTTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjINOUTTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsINOUTTypeBL.prototype.CheckProperty4Update  = function(pobjINOUTTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjINOUTTypeEN.INOUTTypeId && GetStrLen(pobjINOUTTypeEN.INOUTTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[InOut类型(INOUTType)|INOUT类型ID(INOUTTypeId)]的长度不能超过2!值:$(pobjINOUTTypeEN.INOUTTypeId)(clsINOUTTypeBL:CheckProperty4Update)");
}
if (null !== pobjINOUTTypeEN.INOUTTypeName && GetStrLen(pobjINOUTTypeEN.INOUTTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[InOut类型(INOUTType)|INOUT类型名称(INOUTTypeName)]的长度不能超过30!值:$(pobjINOUTTypeEN.INOUTTypeName)(clsINOUTTypeBL:CheckProperty4Update)");
}
if (null !== pobjINOUTTypeEN.INOUTTypeENName && GetStrLen(pobjINOUTTypeEN.INOUTTypeENName) > 30)
{
 throw new Error("(errid:Busi000158)字段[InOut类型(INOUTType)|INOUT类型英文名(INOUTTypeENName)]的长度不能超过30!值:$(pobjINOUTTypeEN.INOUTTypeENName)(clsINOUTTypeBL:CheckProperty4Update)");
}
if (null !== pobjINOUTTypeEN.Memo && GetStrLen(pobjINOUTTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[InOut类型(INOUTType)|说明(Memo)]的长度不能超过1000!值:$(pobjINOUTTypeEN.Memo)(clsINOUTTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjINOUTTypeEN.INOUTTypeId && undefined !== pobjINOUTTypeEN.INOUTTypeId && tzDataType.isString(pobjINOUTTypeEN.INOUTTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[InOut类型(INOUTType)|INOUT类型ID(INOUTTypeId)]的值:[$(pobjINOUTTypeEN.INOUTTypeId)], 非法，应该为字符型!(clsINOUTTypeBL:CheckProperty4Update)");
}
if (null !== pobjINOUTTypeEN.INOUTTypeName && undefined !== pobjINOUTTypeEN.INOUTTypeName && tzDataType.isString(pobjINOUTTypeEN.INOUTTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[InOut类型(INOUTType)|INOUT类型名称(INOUTTypeName)]的值:[$(pobjINOUTTypeEN.INOUTTypeName)], 非法，应该为字符型!(clsINOUTTypeBL:CheckProperty4Update)");
}
if (null !== pobjINOUTTypeEN.INOUTTypeENName && undefined !== pobjINOUTTypeEN.INOUTTypeENName && tzDataType.isString(pobjINOUTTypeEN.INOUTTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[InOut类型(INOUTType)|INOUT类型英文名(INOUTTypeENName)]的值:[$(pobjINOUTTypeEN.INOUTTypeENName)], 非法，应该为字符型!(clsINOUTTypeBL:CheckProperty4Update)");
}
if (null !== pobjINOUTTypeEN.Memo && undefined !== pobjINOUTTypeEN.Memo && tzDataType.isString(pobjINOUTTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[InOut类型(INOUTType)|说明(Memo)]的值:[$(pobjINOUTTypeEN.Memo)], 非法，应该为字符型!(clsINOUTTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjINOUTTypeEN.INOUTTypeId 
 || null !== pobjINOUTTypeEN.INOUTTypeId && pobjINOUTTypeEN.INOUTTypeId.toString()  ===  ""
 || null !== pobjINOUTTypeEN.INOUTTypeId && pobjINOUTTypeEN.INOUTTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[InOut类型|INOUT类型ID]不能为空(NULL)!(clsINOUTTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjINOUTTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024924
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsINOUTTypeBL.GetJSONStrByObj  = function(pobjINOUTTypeEN)
{
pobjINOUTTypeEN.sf_UpdFldSetStr = pobjINOUTTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjINOUTTypeEN);
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
 /// 日期:20200501024924
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsINOUTTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrINOUTTypeObjLst = new Array();
if (strJSON === "")
{
return arrINOUTTypeObjLst;
}
try
{
arrINOUTTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrINOUTTypeObjLst;
}
return arrINOUTTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024924
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsINOUTTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjINOUTTypeEN = new clsINOUTTypeEN();
if (strJSON === "")
{
return pobjINOUTTypeEN;
}
try
{
pobjINOUTTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjINOUTTypeEN;
}
return pobjINOUTTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objINOUTTypeENS">源简化对象</param>
 /// <param name = "objINOUTTypeENT">目标对象</param>
clsINOUTTypeBL.CopyObjFromSimObj = function(objINOUTTypeENS, objINOUTTypeENT) 
{
objINOUTTypeENT.INOUTTypeId = objINOUTTypeENS.INOUTTypeId; //INOUT类型ID
objINOUTTypeENT.INOUTTypeName = objINOUTTypeENS.INOUTTypeName; //INOUT类型名称
objINOUTTypeENT.INOUTTypeENName = objINOUTTypeENS.INOUTTypeENName; //INOUT类型英文名
objINOUTTypeENT.Memo = objINOUTTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objINOUTTypeENS">源对象</param>
 /// <param name = "objINOUTTypeENT">目标对象</param>
clsINOUTTypeBL.CopyObjTo = function(objINOUTTypeENS , objINOUTTypeENT ) 
{
objINOUTTypeENT.INOUTTypeId = objINOUTTypeENS.INOUTTypeId; //INOUT类型ID
objINOUTTypeENT.INOUTTypeName = objINOUTTypeENS.INOUTTypeName; //INOUT类型名称
objINOUTTypeENT.INOUTTypeENName = objINOUTTypeENS.INOUTTypeENName; //INOUT类型英文名
objINOUTTypeENT.Memo = objINOUTTypeENS.Memo; //说明
objINOUTTypeENT.sf_UpdFldSetStr = objINOUTTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objINOUTTypeENS">源对象</param>
 /// <param name = "objINOUTTypeENT">目标对象</param>
clsINOUTTypeBL.CopyObjToSimObj = function(objINOUTTypeENS , objINOUTTypeENT ) 
{
objINOUTTypeENT.INOUTTypeId = objINOUTTypeENS.INOUTTypeId; //INOUT类型ID
objINOUTTypeENT.INOUTTypeName = objINOUTTypeENS.INOUTTypeName; //INOUT类型名称
objINOUTTypeENT.INOUTTypeENName = objINOUTTypeENS.INOUTTypeENName; //INOUT类型英文名
objINOUTTypeENT.Memo = objINOUTTypeENS.Memo; //说明
objINOUTTypeENT.sf_UpdFldSetStr = objINOUTTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objINOUTTypeENT.sf_FldComparisonOp = objINOUTTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objINOUTTypeENS">源简化对象</param>
 /// <param name = "objINOUTTypeENT">目标对象</param>
clsINOUTTypeBL.CopyObjFromSimObj4Upd = function(objINOUTTypeENS, objINOUTTypeENT )
 {
   var strsf_UpdFldSetStr = objINOUTTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsINOUTTypeEN.con_INOUTTypeId)  >= 0)
{
objINOUTTypeENT.INOUTTypeId = objINOUTTypeENS.INOUTTypeId; //INOUT类型ID
}
if (sstrFldSet.indexOf(clsINOUTTypeEN.con_INOUTTypeName)  >= 0)
{
objINOUTTypeENT.INOUTTypeName = objINOUTTypeENS.INOUTTypeName; //INOUT类型名称
}
if (sstrFldSet.indexOf(clsINOUTTypeEN.con_INOUTTypeENName)  >= 0)
{
objINOUTTypeENT.INOUTTypeENName = objINOUTTypeENS.INOUTTypeENName; //INOUT类型英文名
}
if (sstrFldSet.indexOf(clsINOUTTypeEN.con_Memo)  >= 0)
{
objINOUTTypeENT.Memo = objINOUTTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objINOUTTypeENS">源对象</param>
 /// <param name = "objINOUTTypeENT">目标对象</param>
clsINOUTTypeBL.GetSimObjFromObj = function(objINOUTTypeENS)
{
var objINOUTTypeENT = new clsINOUTTypeEN_Sim_js_1.clsINOUTTypeEN_Sim();
objINOUTTypeENT.INOUTTypeId = objINOUTTypeENS.INOUTTypeId; //INOUT类型ID
objINOUTTypeENT.INOUTTypeName = objINOUTTypeENS.INOUTTypeName; //INOUT类型名称
objINOUTTypeENT.INOUTTypeENName = objINOUTTypeENS.INOUTTypeENName; //INOUT类型英文名
objINOUTTypeENT.Memo = objINOUTTypeENS.Memo; //说明
objINOUTTypeENT.sf_UpdFldSetStr = objINOUTTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objINOUTTypeENT.sf_FldComparisonOp = objINOUTTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objINOUTTypeENT;
}
return clsINOUTTypeBL;
}());
exports.clsINOUTTypeBL = clsINOUTTypeBL;
});