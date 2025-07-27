
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrimaryTypeBL
 表名:PrimaryType(00050020)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:57
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsPrimaryTypeEN.js","../../L0_Entity/Table_Field/clsPrimaryTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsPrimaryTypeEN_js_1 = require("../../L0_Entity/Table_Field/clsPrimaryTypeEN.js");
var clsPrimaryTypeEN_Sim_js_1 = require("../../L0_Entity/Table_Field/clsPrimaryTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 主键类型(PrimaryType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsPrimaryTypeBL = /** @class */ (function () {
function clsPrimaryTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrPrimaryTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsPrimaryTypeBL.prototype.CheckPropertyNew = function(pobjPrimaryTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjPrimaryTypeEN.PrimaryTypeName 
 || null !== pobjPrimaryTypeEN.PrimaryTypeName && pobjPrimaryTypeEN.PrimaryTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[主键类型|主键类型名]不能为空(NULL)!(clsPrimaryTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjPrimaryTypeEN.PrimaryTypeId && GetStrLen(pobjPrimaryTypeEN.PrimaryTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[主键类型(PrimaryType)|主键类型ID(PrimaryTypeId)]的长度不能超过2!值:$(pobjPrimaryTypeEN.PrimaryTypeId)(clsPrimaryTypeBL:CheckPropertyNew)");
}
if (null !== pobjPrimaryTypeEN.PrimaryTypeName && GetStrLen(pobjPrimaryTypeEN.PrimaryTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[主键类型(PrimaryType)|主键类型名(PrimaryTypeName)]的长度不能超过30!值:$(pobjPrimaryTypeEN.PrimaryTypeName)(clsPrimaryTypeBL:CheckPropertyNew)");
}
if (null !== pobjPrimaryTypeEN.PrimaryTypeENName && GetStrLen(pobjPrimaryTypeEN.PrimaryTypeENName) > 50)
{
 throw new Error("(errid:Busi000155)字段[主键类型(PrimaryType)|主键类型英文名(PrimaryTypeENName)]的长度不能超过50!值:$(pobjPrimaryTypeEN.PrimaryTypeENName)(clsPrimaryTypeBL:CheckPropertyNew)");
}
if (null !== pobjPrimaryTypeEN.Memo && GetStrLen(pobjPrimaryTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[主键类型(PrimaryType)|说明(Memo)]的长度不能超过1000!值:$(pobjPrimaryTypeEN.Memo)(clsPrimaryTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjPrimaryTypeEN.PrimaryTypeId && undefined !== pobjPrimaryTypeEN.PrimaryTypeId && tzDataType.isString(pobjPrimaryTypeEN.PrimaryTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[主键类型(PrimaryType)|主键类型ID(PrimaryTypeId)]的值:[$(pobjPrimaryTypeEN.PrimaryTypeId)], 非法，应该为字符型!(clsPrimaryTypeBL:CheckPropertyNew)");
}
if (null !== pobjPrimaryTypeEN.PrimaryTypeName && undefined !== pobjPrimaryTypeEN.PrimaryTypeName && tzDataType.isString(pobjPrimaryTypeEN.PrimaryTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[主键类型(PrimaryType)|主键类型名(PrimaryTypeName)]的值:[$(pobjPrimaryTypeEN.PrimaryTypeName)], 非法，应该为字符型!(clsPrimaryTypeBL:CheckPropertyNew)");
}
if (null !== pobjPrimaryTypeEN.PrimaryTypeENName && undefined !== pobjPrimaryTypeEN.PrimaryTypeENName && tzDataType.isString(pobjPrimaryTypeEN.PrimaryTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[主键类型(PrimaryType)|主键类型英文名(PrimaryTypeENName)]的值:[$(pobjPrimaryTypeEN.PrimaryTypeENName)], 非法，应该为字符型!(clsPrimaryTypeBL:CheckPropertyNew)");
}
if (null !== pobjPrimaryTypeEN.Memo && undefined !== pobjPrimaryTypeEN.Memo && tzDataType.isString(pobjPrimaryTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[主键类型(PrimaryType)|说明(Memo)]的值:[$(pobjPrimaryTypeEN.Memo)], 非法，应该为字符型!(clsPrimaryTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPrimaryTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsPrimaryTypeBL.prototype.CheckProperty4Update  = function(pobjPrimaryTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjPrimaryTypeEN.PrimaryTypeId && GetStrLen(pobjPrimaryTypeEN.PrimaryTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[主键类型(PrimaryType)|主键类型ID(PrimaryTypeId)]的长度不能超过2!值:$(pobjPrimaryTypeEN.PrimaryTypeId)(clsPrimaryTypeBL:CheckProperty4Update)");
}
if (null !== pobjPrimaryTypeEN.PrimaryTypeName && GetStrLen(pobjPrimaryTypeEN.PrimaryTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[主键类型(PrimaryType)|主键类型名(PrimaryTypeName)]的长度不能超过30!值:$(pobjPrimaryTypeEN.PrimaryTypeName)(clsPrimaryTypeBL:CheckProperty4Update)");
}
if (null !== pobjPrimaryTypeEN.PrimaryTypeENName && GetStrLen(pobjPrimaryTypeEN.PrimaryTypeENName) > 50)
{
 throw new Error("(errid:Busi000158)字段[主键类型(PrimaryType)|主键类型英文名(PrimaryTypeENName)]的长度不能超过50!值:$(pobjPrimaryTypeEN.PrimaryTypeENName)(clsPrimaryTypeBL:CheckProperty4Update)");
}
if (null !== pobjPrimaryTypeEN.Memo && GetStrLen(pobjPrimaryTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[主键类型(PrimaryType)|说明(Memo)]的长度不能超过1000!值:$(pobjPrimaryTypeEN.Memo)(clsPrimaryTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjPrimaryTypeEN.PrimaryTypeId && undefined !== pobjPrimaryTypeEN.PrimaryTypeId && tzDataType.isString(pobjPrimaryTypeEN.PrimaryTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[主键类型(PrimaryType)|主键类型ID(PrimaryTypeId)]的值:[$(pobjPrimaryTypeEN.PrimaryTypeId)], 非法，应该为字符型!(clsPrimaryTypeBL:CheckProperty4Update)");
}
if (null !== pobjPrimaryTypeEN.PrimaryTypeName && undefined !== pobjPrimaryTypeEN.PrimaryTypeName && tzDataType.isString(pobjPrimaryTypeEN.PrimaryTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[主键类型(PrimaryType)|主键类型名(PrimaryTypeName)]的值:[$(pobjPrimaryTypeEN.PrimaryTypeName)], 非法，应该为字符型!(clsPrimaryTypeBL:CheckProperty4Update)");
}
if (null !== pobjPrimaryTypeEN.PrimaryTypeENName && undefined !== pobjPrimaryTypeEN.PrimaryTypeENName && tzDataType.isString(pobjPrimaryTypeEN.PrimaryTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[主键类型(PrimaryType)|主键类型英文名(PrimaryTypeENName)]的值:[$(pobjPrimaryTypeEN.PrimaryTypeENName)], 非法，应该为字符型!(clsPrimaryTypeBL:CheckProperty4Update)");
}
if (null !== pobjPrimaryTypeEN.Memo && undefined !== pobjPrimaryTypeEN.Memo && tzDataType.isString(pobjPrimaryTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[主键类型(PrimaryType)|说明(Memo)]的值:[$(pobjPrimaryTypeEN.Memo)], 非法，应该为字符型!(clsPrimaryTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPrimaryTypeEN.PrimaryTypeId 
 || null !== pobjPrimaryTypeEN.PrimaryTypeId && pobjPrimaryTypeEN.PrimaryTypeId.toString()  ===  ""
 || null !== pobjPrimaryTypeEN.PrimaryTypeId && pobjPrimaryTypeEN.PrimaryTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[主键类型|主键类型ID]不能为空(NULL)!(clsPrimaryTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPrimaryTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024957
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsPrimaryTypeBL.GetJSONStrByObj  = function(pobjPrimaryTypeEN)
{
pobjPrimaryTypeEN.sf_UpdFldSetStr = pobjPrimaryTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjPrimaryTypeEN);
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
 /// 日期:20200501024957
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsPrimaryTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrPrimaryTypeObjLst = new Array();
if (strJSON === "")
{
return arrPrimaryTypeObjLst;
}
try
{
arrPrimaryTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPrimaryTypeObjLst;
}
return arrPrimaryTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024957
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsPrimaryTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjPrimaryTypeEN = new clsPrimaryTypeEN();
if (strJSON === "")
{
return pobjPrimaryTypeEN;
}
try
{
pobjPrimaryTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPrimaryTypeEN;
}
return pobjPrimaryTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objPrimaryTypeENS">源简化对象</param>
 /// <param name = "objPrimaryTypeENT">目标对象</param>
clsPrimaryTypeBL.CopyObjFromSimObj = function(objPrimaryTypeENS, objPrimaryTypeENT) 
{
objPrimaryTypeENT.PrimaryTypeId = objPrimaryTypeENS.PrimaryTypeId; //主键类型ID
objPrimaryTypeENT.PrimaryTypeName = objPrimaryTypeENS.PrimaryTypeName; //主键类型名
objPrimaryTypeENT.PrimaryTypeENName = objPrimaryTypeENS.PrimaryTypeENName; //主键类型英文名
objPrimaryTypeENT.Memo = objPrimaryTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objPrimaryTypeENS">源对象</param>
 /// <param name = "objPrimaryTypeENT">目标对象</param>
clsPrimaryTypeBL.CopyObjTo = function(objPrimaryTypeENS , objPrimaryTypeENT ) 
{
objPrimaryTypeENT.PrimaryTypeId = objPrimaryTypeENS.PrimaryTypeId; //主键类型ID
objPrimaryTypeENT.PrimaryTypeName = objPrimaryTypeENS.PrimaryTypeName; //主键类型名
objPrimaryTypeENT.PrimaryTypeENName = objPrimaryTypeENS.PrimaryTypeENName; //主键类型英文名
objPrimaryTypeENT.Memo = objPrimaryTypeENS.Memo; //说明
objPrimaryTypeENT.sf_UpdFldSetStr = objPrimaryTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objPrimaryTypeENS">源对象</param>
 /// <param name = "objPrimaryTypeENT">目标对象</param>
clsPrimaryTypeBL.CopyObjToSimObj = function(objPrimaryTypeENS , objPrimaryTypeENT ) 
{
objPrimaryTypeENT.PrimaryTypeId = objPrimaryTypeENS.PrimaryTypeId; //主键类型ID
objPrimaryTypeENT.PrimaryTypeName = objPrimaryTypeENS.PrimaryTypeName; //主键类型名
objPrimaryTypeENT.PrimaryTypeENName = objPrimaryTypeENS.PrimaryTypeENName; //主键类型英文名
objPrimaryTypeENT.Memo = objPrimaryTypeENS.Memo; //说明
objPrimaryTypeENT.sf_UpdFldSetStr = objPrimaryTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objPrimaryTypeENT.sf_FldComparisonOp = objPrimaryTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objPrimaryTypeENS">源简化对象</param>
 /// <param name = "objPrimaryTypeENT">目标对象</param>
clsPrimaryTypeBL.CopyObjFromSimObj4Upd = function(objPrimaryTypeENS, objPrimaryTypeENT )
 {
   var strsf_UpdFldSetStr = objPrimaryTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsPrimaryTypeEN.con_PrimaryTypeId)  >= 0)
{
objPrimaryTypeENT.PrimaryTypeId = objPrimaryTypeENS.PrimaryTypeId; //主键类型ID
}
if (sstrFldSet.indexOf(clsPrimaryTypeEN.con_PrimaryTypeName)  >= 0)
{
objPrimaryTypeENT.PrimaryTypeName = objPrimaryTypeENS.PrimaryTypeName; //主键类型名
}
if (sstrFldSet.indexOf(clsPrimaryTypeEN.con_PrimaryTypeENName)  >= 0)
{
objPrimaryTypeENT.PrimaryTypeENName = objPrimaryTypeENS.PrimaryTypeENName; //主键类型英文名
}
if (sstrFldSet.indexOf(clsPrimaryTypeEN.con_Memo)  >= 0)
{
objPrimaryTypeENT.Memo = objPrimaryTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objPrimaryTypeENS">源对象</param>
 /// <param name = "objPrimaryTypeENT">目标对象</param>
clsPrimaryTypeBL.GetSimObjFromObj = function(objPrimaryTypeENS)
{
var objPrimaryTypeENT = new clsPrimaryTypeEN_Sim_js_1.clsPrimaryTypeEN_Sim();
objPrimaryTypeENT.PrimaryTypeId = objPrimaryTypeENS.PrimaryTypeId; //主键类型ID
objPrimaryTypeENT.PrimaryTypeName = objPrimaryTypeENS.PrimaryTypeName; //主键类型名
objPrimaryTypeENT.PrimaryTypeENName = objPrimaryTypeENS.PrimaryTypeENName; //主键类型英文名
objPrimaryTypeENT.Memo = objPrimaryTypeENS.Memo; //说明
objPrimaryTypeENT.sf_UpdFldSetStr = objPrimaryTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objPrimaryTypeENT.sf_FldComparisonOp = objPrimaryTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objPrimaryTypeENT;
}
return clsPrimaryTypeBL;
}());
exports.clsPrimaryTypeBL = clsPrimaryTypeBL;
});