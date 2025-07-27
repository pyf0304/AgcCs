
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDgFuncTypeBL
 表名:DgFuncType(00050114)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:40
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsDgFuncTypeEN.js","../../L0_Entity/PrjInterface/clsDgFuncTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsDgFuncTypeEN_js_1 = require("../../L0_Entity/PrjInterface/clsDgFuncTypeEN.js");
var clsDgFuncTypeEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsDgFuncTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// DG功能类型(DgFuncType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsDgFuncTypeBL = /** @class */ (function () {
function clsDgFuncTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrDgFuncTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsDgFuncTypeBL.prototype.CheckPropertyNew = function(pobjDgFuncTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjDgFuncTypeEN.DgFuncTypeName 
 || null !== pobjDgFuncTypeEN.DgFuncTypeName && pobjDgFuncTypeEN.DgFuncTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[DG功能类型|Dg功能类型名]不能为空(NULL)!(clsDgFuncTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjDgFuncTypeEN.DgFuncTypeId && GetStrLen(pobjDgFuncTypeEN.DgFuncTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[DG功能类型(DgFuncType)|Dg功能类型Id(DgFuncTypeId)]的长度不能超过4!值:$(pobjDgFuncTypeEN.DgFuncTypeId)(clsDgFuncTypeBL:CheckPropertyNew)");
}
if (null !== pobjDgFuncTypeEN.DgFuncTypeName && GetStrLen(pobjDgFuncTypeEN.DgFuncTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[DG功能类型(DgFuncType)|Dg功能类型名(DgFuncTypeName)]的长度不能超过30!值:$(pobjDgFuncTypeEN.DgFuncTypeName)(clsDgFuncTypeBL:CheckPropertyNew)");
}
if (null !== pobjDgFuncTypeEN.Memo && GetStrLen(pobjDgFuncTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[DG功能类型(DgFuncType)|说明(Memo)]的长度不能超过1000!值:$(pobjDgFuncTypeEN.Memo)(clsDgFuncTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjDgFuncTypeEN.DgFuncTypeId && undefined !== pobjDgFuncTypeEN.DgFuncTypeId && tzDataType.isString(pobjDgFuncTypeEN.DgFuncTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[DG功能类型(DgFuncType)|Dg功能类型Id(DgFuncTypeId)]的值:[$(pobjDgFuncTypeEN.DgFuncTypeId)], 非法，应该为字符型!(clsDgFuncTypeBL:CheckPropertyNew)");
}
if (null !== pobjDgFuncTypeEN.DgFuncTypeName && undefined !== pobjDgFuncTypeEN.DgFuncTypeName && tzDataType.isString(pobjDgFuncTypeEN.DgFuncTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[DG功能类型(DgFuncType)|Dg功能类型名(DgFuncTypeName)]的值:[$(pobjDgFuncTypeEN.DgFuncTypeName)], 非法，应该为字符型!(clsDgFuncTypeBL:CheckPropertyNew)");
}
if (null !== pobjDgFuncTypeEN.Memo && undefined !== pobjDgFuncTypeEN.Memo && tzDataType.isString(pobjDgFuncTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[DG功能类型(DgFuncType)|说明(Memo)]的值:[$(pobjDgFuncTypeEN.Memo)], 非法，应该为字符型!(clsDgFuncTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjDgFuncTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsDgFuncTypeBL.prototype.CheckProperty4Update  = function(pobjDgFuncTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjDgFuncTypeEN.DgFuncTypeId && GetStrLen(pobjDgFuncTypeEN.DgFuncTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[DG功能类型(DgFuncType)|Dg功能类型Id(DgFuncTypeId)]的长度不能超过4!值:$(pobjDgFuncTypeEN.DgFuncTypeId)(clsDgFuncTypeBL:CheckProperty4Update)");
}
if (null !== pobjDgFuncTypeEN.DgFuncTypeName && GetStrLen(pobjDgFuncTypeEN.DgFuncTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[DG功能类型(DgFuncType)|Dg功能类型名(DgFuncTypeName)]的长度不能超过30!值:$(pobjDgFuncTypeEN.DgFuncTypeName)(clsDgFuncTypeBL:CheckProperty4Update)");
}
if (null !== pobjDgFuncTypeEN.Memo && GetStrLen(pobjDgFuncTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[DG功能类型(DgFuncType)|说明(Memo)]的长度不能超过1000!值:$(pobjDgFuncTypeEN.Memo)(clsDgFuncTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjDgFuncTypeEN.DgFuncTypeId && undefined !== pobjDgFuncTypeEN.DgFuncTypeId && tzDataType.isString(pobjDgFuncTypeEN.DgFuncTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[DG功能类型(DgFuncType)|Dg功能类型Id(DgFuncTypeId)]的值:[$(pobjDgFuncTypeEN.DgFuncTypeId)], 非法，应该为字符型!(clsDgFuncTypeBL:CheckProperty4Update)");
}
if (null !== pobjDgFuncTypeEN.DgFuncTypeName && undefined !== pobjDgFuncTypeEN.DgFuncTypeName && tzDataType.isString(pobjDgFuncTypeEN.DgFuncTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[DG功能类型(DgFuncType)|Dg功能类型名(DgFuncTypeName)]的值:[$(pobjDgFuncTypeEN.DgFuncTypeName)], 非法，应该为字符型!(clsDgFuncTypeBL:CheckProperty4Update)");
}
if (null !== pobjDgFuncTypeEN.Memo && undefined !== pobjDgFuncTypeEN.Memo && tzDataType.isString(pobjDgFuncTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[DG功能类型(DgFuncType)|说明(Memo)]的值:[$(pobjDgFuncTypeEN.Memo)], 非法，应该为字符型!(clsDgFuncTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjDgFuncTypeEN.DgFuncTypeId 
 || null !== pobjDgFuncTypeEN.DgFuncTypeId && pobjDgFuncTypeEN.DgFuncTypeId.toString()  ===  ""
 || null !== pobjDgFuncTypeEN.DgFuncTypeId && pobjDgFuncTypeEN.DgFuncTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[DG功能类型|Dg功能类型Id]不能为空(NULL)!(clsDgFuncTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjDgFuncTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024940
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsDgFuncTypeBL.GetJSONStrByObj  = function(pobjDgFuncTypeEN)
{
pobjDgFuncTypeEN.sf_UpdFldSetStr = pobjDgFuncTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjDgFuncTypeEN);
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
 /// 日期:20200501024940
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsDgFuncTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrDgFuncTypeObjLst = new Array();
if (strJSON === "")
{
return arrDgFuncTypeObjLst;
}
try
{
arrDgFuncTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrDgFuncTypeObjLst;
}
return arrDgFuncTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024940
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsDgFuncTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjDgFuncTypeEN = new clsDgFuncTypeEN();
if (strJSON === "")
{
return pobjDgFuncTypeEN;
}
try
{
pobjDgFuncTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjDgFuncTypeEN;
}
return pobjDgFuncTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objDgFuncTypeENS">源简化对象</param>
 /// <param name = "objDgFuncTypeENT">目标对象</param>
clsDgFuncTypeBL.CopyObjFromSimObj = function(objDgFuncTypeENS, objDgFuncTypeENT) 
{
objDgFuncTypeENT.DgFuncTypeId = objDgFuncTypeENS.DgFuncTypeId; //Dg功能类型Id
objDgFuncTypeENT.DgFuncTypeName = objDgFuncTypeENS.DgFuncTypeName; //Dg功能类型名
objDgFuncTypeENT.Memo = objDgFuncTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objDgFuncTypeENS">源对象</param>
 /// <param name = "objDgFuncTypeENT">目标对象</param>
clsDgFuncTypeBL.CopyObjTo = function(objDgFuncTypeENS , objDgFuncTypeENT ) 
{
objDgFuncTypeENT.DgFuncTypeId = objDgFuncTypeENS.DgFuncTypeId; //Dg功能类型Id
objDgFuncTypeENT.DgFuncTypeName = objDgFuncTypeENS.DgFuncTypeName; //Dg功能类型名
objDgFuncTypeENT.Memo = objDgFuncTypeENS.Memo; //说明
objDgFuncTypeENT.sf_UpdFldSetStr = objDgFuncTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objDgFuncTypeENS">源对象</param>
 /// <param name = "objDgFuncTypeENT">目标对象</param>
clsDgFuncTypeBL.CopyObjToSimObj = function(objDgFuncTypeENS , objDgFuncTypeENT ) 
{
objDgFuncTypeENT.DgFuncTypeId = objDgFuncTypeENS.DgFuncTypeId; //Dg功能类型Id
objDgFuncTypeENT.DgFuncTypeName = objDgFuncTypeENS.DgFuncTypeName; //Dg功能类型名
objDgFuncTypeENT.Memo = objDgFuncTypeENS.Memo; //说明
objDgFuncTypeENT.sf_UpdFldSetStr = objDgFuncTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objDgFuncTypeENT.sf_FldComparisonOp = objDgFuncTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objDgFuncTypeENS">源简化对象</param>
 /// <param name = "objDgFuncTypeENT">目标对象</param>
clsDgFuncTypeBL.CopyObjFromSimObj4Upd = function(objDgFuncTypeENS, objDgFuncTypeENT )
 {
   var strsf_UpdFldSetStr = objDgFuncTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsDgFuncTypeEN.con_DgFuncTypeId)  >= 0)
{
objDgFuncTypeENT.DgFuncTypeId = objDgFuncTypeENS.DgFuncTypeId; //Dg功能类型Id
}
if (sstrFldSet.indexOf(clsDgFuncTypeEN.con_DgFuncTypeName)  >= 0)
{
objDgFuncTypeENT.DgFuncTypeName = objDgFuncTypeENS.DgFuncTypeName; //Dg功能类型名
}
if (sstrFldSet.indexOf(clsDgFuncTypeEN.con_Memo)  >= 0)
{
objDgFuncTypeENT.Memo = objDgFuncTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objDgFuncTypeENS">源对象</param>
 /// <param name = "objDgFuncTypeENT">目标对象</param>
clsDgFuncTypeBL.GetSimObjFromObj = function(objDgFuncTypeENS)
{
var objDgFuncTypeENT = new clsDgFuncTypeEN_Sim_js_1.clsDgFuncTypeEN_Sim();
objDgFuncTypeENT.DgFuncTypeId = objDgFuncTypeENS.DgFuncTypeId; //Dg功能类型Id
objDgFuncTypeENT.DgFuncTypeName = objDgFuncTypeENS.DgFuncTypeName; //Dg功能类型名
objDgFuncTypeENT.Memo = objDgFuncTypeENS.Memo; //说明
objDgFuncTypeENT.sf_UpdFldSetStr = objDgFuncTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objDgFuncTypeENT.sf_FldComparisonOp = objDgFuncTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objDgFuncTypeENT;
}
return clsDgFuncTypeBL;
}());
exports.clsDgFuncTypeBL = clsDgFuncTypeBL;
});