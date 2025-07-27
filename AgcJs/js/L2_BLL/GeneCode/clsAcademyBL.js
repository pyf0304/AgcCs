
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAcademyBL
 表名:Academy(00050146)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:05:41
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
define(["require", "exports", "jquery", "../../L0_Entity/GeneCode/clsAcademyEN.js","../../L0_Entity/GeneCode/clsAcademyEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsAcademyEN_js_1 = require("../../L0_Entity/GeneCode/clsAcademyEN.js");
var clsAcademyEN_Sim_js_1 = require("../../L0_Entity/GeneCode/clsAcademyEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 学院(Academy)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsAcademyBL = /** @class */ (function () {
function clsAcademyBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrAcademyObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsAcademyBL.prototype.CheckPropertyNew = function(pobjAcademyEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjAcademyEN.AcademyName 
 || null !== pobjAcademyEN.AcademyName && pobjAcademyEN.AcademyName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[学院|学院名称]不能为空(NULL)!(clsAcademyBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjAcademyEN.AcademyId && GetStrLen(pobjAcademyEN.AcademyId) > 6)
{
 throw new Error("(errid:Busi000155)字段[学院(Academy)|学院ID(AcademyId)]的长度不能超过6!值:$(pobjAcademyEN.AcademyId)(clsAcademyBL:CheckPropertyNew)");
}
if (null !== pobjAcademyEN.AcademyName && GetStrLen(pobjAcademyEN.AcademyName) > 40)
{
 throw new Error("(errid:Busi000155)字段[学院(Academy)|学院名称(AcademyName)]的长度不能超过40!值:$(pobjAcademyEN.AcademyName)(clsAcademyBL:CheckPropertyNew)");
}
if (null !== pobjAcademyEN.Memo && GetStrLen(pobjAcademyEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[学院(Academy)|说明(Memo)]的长度不能超过1000!值:$(pobjAcademyEN.Memo)(clsAcademyBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjAcademyEN.AcademyId && undefined !== pobjAcademyEN.AcademyId && tzDataType.isString(pobjAcademyEN.AcademyId) === false)
{
 throw new Error("(errid:Busi000156)字段[学院(Academy)|学院ID(AcademyId)]的值:[$(pobjAcademyEN.AcademyId)], 非法，应该为字符型!(clsAcademyBL:CheckPropertyNew)");
}
if (null !== pobjAcademyEN.AcademyName && undefined !== pobjAcademyEN.AcademyName && tzDataType.isString(pobjAcademyEN.AcademyName) === false)
{
 throw new Error("(errid:Busi000156)字段[学院(Academy)|学院名称(AcademyName)]的值:[$(pobjAcademyEN.AcademyName)], 非法，应该为字符型!(clsAcademyBL:CheckPropertyNew)");
}
if (null !== pobjAcademyEN.Memo && undefined !== pobjAcademyEN.Memo && tzDataType.isString(pobjAcademyEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[学院(Academy)|说明(Memo)]的值:[$(pobjAcademyEN.Memo)], 非法，应该为字符型!(clsAcademyBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjAcademyEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsAcademyBL.prototype.CheckProperty4Update  = function(pobjAcademyEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjAcademyEN.AcademyId && GetStrLen(pobjAcademyEN.AcademyId) > 6)
{
 throw new Error("(errid:Busi000158)字段[学院(Academy)|学院ID(AcademyId)]的长度不能超过6!值:$(pobjAcademyEN.AcademyId)(clsAcademyBL:CheckProperty4Update)");
}
if (null !== pobjAcademyEN.AcademyName && GetStrLen(pobjAcademyEN.AcademyName) > 40)
{
 throw new Error("(errid:Busi000158)字段[学院(Academy)|学院名称(AcademyName)]的长度不能超过40!值:$(pobjAcademyEN.AcademyName)(clsAcademyBL:CheckProperty4Update)");
}
if (null !== pobjAcademyEN.Memo && GetStrLen(pobjAcademyEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[学院(Academy)|说明(Memo)]的长度不能超过1000!值:$(pobjAcademyEN.Memo)(clsAcademyBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjAcademyEN.AcademyId && undefined !== pobjAcademyEN.AcademyId && tzDataType.isString(pobjAcademyEN.AcademyId) === false)
{
 throw new Error("(errid:Busi000159)字段[学院(Academy)|学院ID(AcademyId)]的值:[$(pobjAcademyEN.AcademyId)], 非法，应该为字符型!(clsAcademyBL:CheckProperty4Update)");
}
if (null !== pobjAcademyEN.AcademyName && undefined !== pobjAcademyEN.AcademyName && tzDataType.isString(pobjAcademyEN.AcademyName) === false)
{
 throw new Error("(errid:Busi000159)字段[学院(Academy)|学院名称(AcademyName)]的值:[$(pobjAcademyEN.AcademyName)], 非法，应该为字符型!(clsAcademyBL:CheckProperty4Update)");
}
if (null !== pobjAcademyEN.Memo && undefined !== pobjAcademyEN.Memo && tzDataType.isString(pobjAcademyEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[学院(Academy)|说明(Memo)]的值:[$(pobjAcademyEN.Memo)], 非法，应该为字符型!(clsAcademyBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjAcademyEN.AcademyId 
 || null !== pobjAcademyEN.AcademyId && pobjAcademyEN.AcademyId.toString()  ===  ""
 || null !== pobjAcademyEN.AcademyId && pobjAcademyEN.AcademyId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[学院|学院ID]不能为空(NULL)!(clsAcademyBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjAcademyEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200430120541
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsAcademyBL.GetJSONStrByObj  = function(pobjAcademyEN)
{
pobjAcademyEN.sf_UpdFldSetStr = pobjAcademyEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjAcademyEN);
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
 /// 日期:20200430120541
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsAcademyBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrAcademyObjLst = new Array();
if (strJSON === "")
{
return arrAcademyObjLst;
}
try
{
arrAcademyObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrAcademyObjLst;
}
return arrAcademyObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200430120541
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsAcademyBL.GetObjByJSONStr  = function(strJSON)
{
var pobjAcademyEN = new clsAcademyEN();
if (strJSON === "")
{
return pobjAcademyEN;
}
try
{
pobjAcademyEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjAcademyEN;
}
return pobjAcademyEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objAcademyENS">源简化对象</param>
 /// <param name = "objAcademyENT">目标对象</param>
clsAcademyBL.CopyObjFromSimObj = function(objAcademyENS, objAcademyENT) 
{
objAcademyENT.AcademyId = objAcademyENS.AcademyId; //学院ID
objAcademyENT.AcademyName = objAcademyENS.AcademyName; //学院名称
objAcademyENT.Memo = objAcademyENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objAcademyENS">源对象</param>
 /// <param name = "objAcademyENT">目标对象</param>
clsAcademyBL.CopyObjTo = function(objAcademyENS , objAcademyENT ) 
{
objAcademyENT.AcademyId = objAcademyENS.AcademyId; //学院ID
objAcademyENT.AcademyName = objAcademyENS.AcademyName; //学院名称
objAcademyENT.Memo = objAcademyENS.Memo; //说明
objAcademyENT.sf_UpdFldSetStr = objAcademyENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objAcademyENS">源对象</param>
 /// <param name = "objAcademyENT">目标对象</param>
clsAcademyBL.CopyObjToSimObj = function(objAcademyENS , objAcademyENT ) 
{
objAcademyENT.AcademyId = objAcademyENS.AcademyId; //学院ID
objAcademyENT.AcademyName = objAcademyENS.AcademyName; //学院名称
objAcademyENT.Memo = objAcademyENS.Memo; //说明
objAcademyENT.sf_UpdFldSetStr = objAcademyENS.UpdFldString; //专门用于记录某字段属性是否修改
objAcademyENT.sf_FldComparisonOp = objAcademyENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objAcademyENS">源简化对象</param>
 /// <param name = "objAcademyENT">目标对象</param>
clsAcademyBL.CopyObjFromSimObj4Upd = function(objAcademyENS, objAcademyENT )
 {
   var strsf_UpdFldSetStr = objAcademyENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsAcademyEN.con_AcademyId)  >= 0)
{
objAcademyENT.AcademyId = objAcademyENS.AcademyId; //学院ID
}
if (sstrFldSet.indexOf(clsAcademyEN.con_AcademyName)  >= 0)
{
objAcademyENT.AcademyName = objAcademyENS.AcademyName; //学院名称
}
if (sstrFldSet.indexOf(clsAcademyEN.con_Memo)  >= 0)
{
objAcademyENT.Memo = objAcademyENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objAcademyENS">源对象</param>
 /// <param name = "objAcademyENT">目标对象</param>
clsAcademyBL.GetSimObjFromObj = function(objAcademyENS)
{
var objAcademyENT = new clsAcademyEN_Sim_js_1.clsAcademyEN_Sim();
objAcademyENT.AcademyId = objAcademyENS.AcademyId; //学院ID
objAcademyENT.AcademyName = objAcademyENS.AcademyName; //学院名称
objAcademyENT.Memo = objAcademyENS.Memo; //说明
objAcademyENT.sf_UpdFldSetStr = objAcademyENS.UpdFldString; //专门用于记录某字段属性是否修改
objAcademyENT.sf_FldComparisonOp = objAcademyENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objAcademyENT;
}
return clsAcademyBL;
}());
exports.clsAcademyBL = clsAcademyBL;
});