
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabTypeBL
 表名:TabType(00050270)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:05:58
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsTabTypeEN.js","../../L0_Entity/SysPara/clsTabTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsTabTypeEN_js_1 = require("../../L0_Entity/SysPara/clsTabTypeEN.js");
var clsTabTypeEN_Sim_js_1 = require("../../L0_Entity/SysPara/clsTabTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 表类型(TabType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsTabTypeBL = /** @class */ (function () {
function clsTabTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrTabTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsTabTypeBL.prototype.CheckPropertyNew = function(pobjTabTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjTabTypeEN.TabTypeName 
 || null !== pobjTabTypeEN.TabTypeName && pobjTabTypeEN.TabTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[表类型|表类型名]不能为空(NULL)!(clsTabTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjTabTypeEN.TabTypeId && GetStrLen(pobjTabTypeEN.TabTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[表类型(TabType)|表类型Id(TabTypeId)]的长度不能超过4!值:$(pobjTabTypeEN.TabTypeId)(clsTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabTypeEN.TabTypeName && GetStrLen(pobjTabTypeEN.TabTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[表类型(TabType)|表类型名(TabTypeName)]的长度不能超过30!值:$(pobjTabTypeEN.TabTypeName)(clsTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabTypeEN.TabTypeENName && GetStrLen(pobjTabTypeEN.TabTypeENName) > 30)
{
 throw new Error("(errid:Busi000155)字段[表类型(TabType)|表类型英文名(TabTypeENName)]的长度不能超过30!值:$(pobjTabTypeEN.TabTypeENName)(clsTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabTypeEN.Memo && GetStrLen(pobjTabTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[表类型(TabType)|说明(Memo)]的长度不能超过1000!值:$(pobjTabTypeEN.Memo)(clsTabTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjTabTypeEN.TabTypeId && undefined !== pobjTabTypeEN.TabTypeId && tzDataType.isString(pobjTabTypeEN.TabTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[表类型(TabType)|表类型Id(TabTypeId)]的值:[$(pobjTabTypeEN.TabTypeId)], 非法，应该为字符型!(clsTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabTypeEN.TabTypeName && undefined !== pobjTabTypeEN.TabTypeName && tzDataType.isString(pobjTabTypeEN.TabTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[表类型(TabType)|表类型名(TabTypeName)]的值:[$(pobjTabTypeEN.TabTypeName)], 非法，应该为字符型!(clsTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabTypeEN.TabTypeENName && undefined !== pobjTabTypeEN.TabTypeENName && tzDataType.isString(pobjTabTypeEN.TabTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[表类型(TabType)|表类型英文名(TabTypeENName)]的值:[$(pobjTabTypeEN.TabTypeENName)], 非法，应该为字符型!(clsTabTypeBL:CheckPropertyNew)");
}
if (null !== pobjTabTypeEN.Memo && undefined !== pobjTabTypeEN.Memo && tzDataType.isString(pobjTabTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[表类型(TabType)|说明(Memo)]的值:[$(pobjTabTypeEN.Memo)], 非法，应该为字符型!(clsTabTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjTabTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsTabTypeBL.prototype.CheckProperty4Update  = function(pobjTabTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjTabTypeEN.TabTypeId && GetStrLen(pobjTabTypeEN.TabTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[表类型(TabType)|表类型Id(TabTypeId)]的长度不能超过4!值:$(pobjTabTypeEN.TabTypeId)(clsTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabTypeEN.TabTypeName && GetStrLen(pobjTabTypeEN.TabTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[表类型(TabType)|表类型名(TabTypeName)]的长度不能超过30!值:$(pobjTabTypeEN.TabTypeName)(clsTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabTypeEN.TabTypeENName && GetStrLen(pobjTabTypeEN.TabTypeENName) > 30)
{
 throw new Error("(errid:Busi000158)字段[表类型(TabType)|表类型英文名(TabTypeENName)]的长度不能超过30!值:$(pobjTabTypeEN.TabTypeENName)(clsTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabTypeEN.Memo && GetStrLen(pobjTabTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[表类型(TabType)|说明(Memo)]的长度不能超过1000!值:$(pobjTabTypeEN.Memo)(clsTabTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjTabTypeEN.TabTypeId && undefined !== pobjTabTypeEN.TabTypeId && tzDataType.isString(pobjTabTypeEN.TabTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[表类型(TabType)|表类型Id(TabTypeId)]的值:[$(pobjTabTypeEN.TabTypeId)], 非法，应该为字符型!(clsTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabTypeEN.TabTypeName && undefined !== pobjTabTypeEN.TabTypeName && tzDataType.isString(pobjTabTypeEN.TabTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[表类型(TabType)|表类型名(TabTypeName)]的值:[$(pobjTabTypeEN.TabTypeName)], 非法，应该为字符型!(clsTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabTypeEN.TabTypeENName && undefined !== pobjTabTypeEN.TabTypeENName && tzDataType.isString(pobjTabTypeEN.TabTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[表类型(TabType)|表类型英文名(TabTypeENName)]的值:[$(pobjTabTypeEN.TabTypeENName)], 非法，应该为字符型!(clsTabTypeBL:CheckProperty4Update)");
}
if (null !== pobjTabTypeEN.Memo && undefined !== pobjTabTypeEN.Memo && tzDataType.isString(pobjTabTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[表类型(TabType)|说明(Memo)]的值:[$(pobjTabTypeEN.Memo)], 非法，应该为字符型!(clsTabTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjTabTypeEN.TabTypeId 
 || null !== pobjTabTypeEN.TabTypeId && pobjTabTypeEN.TabTypeId.toString()  ===  ""
 || null !== pobjTabTypeEN.TabTypeId && pobjTabTypeEN.TabTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[表类型|表类型Id]不能为空(NULL)!(clsTabTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjTabTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200502010558
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsTabTypeBL.GetJSONStrByObj  = function(pobjTabTypeEN)
{
pobjTabTypeEN.sf_UpdFldSetStr = pobjTabTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjTabTypeEN);
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
 /// 日期:20200502010558
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsTabTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrTabTypeObjLst = new Array();
if (strJSON === "")
{
return arrTabTypeObjLst;
}
try
{
arrTabTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrTabTypeObjLst;
}
return arrTabTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200502010558
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsTabTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjTabTypeEN = new clsTabTypeEN();
if (strJSON === "")
{
return pobjTabTypeEN;
}
try
{
pobjTabTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjTabTypeEN;
}
return pobjTabTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objTabTypeENS">源简化对象</param>
 /// <param name = "objTabTypeENT">目标对象</param>
clsTabTypeBL.CopyObjFromSimObj = function(objTabTypeENS, objTabTypeENT) 
{
objTabTypeENT.TabTypeId = objTabTypeENS.TabTypeId; //表类型Id
objTabTypeENT.TabTypeName = objTabTypeENS.TabTypeName; //表类型名
objTabTypeENT.TabTypeENName = objTabTypeENS.TabTypeENName; //表类型英文名
objTabTypeENT.Memo = objTabTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objTabTypeENS">源对象</param>
 /// <param name = "objTabTypeENT">目标对象</param>
clsTabTypeBL.CopyObjTo = function(objTabTypeENS , objTabTypeENT ) 
{
objTabTypeENT.TabTypeId = objTabTypeENS.TabTypeId; //表类型Id
objTabTypeENT.TabTypeName = objTabTypeENS.TabTypeName; //表类型名
objTabTypeENT.TabTypeENName = objTabTypeENS.TabTypeENName; //表类型英文名
objTabTypeENT.Memo = objTabTypeENS.Memo; //说明
objTabTypeENT.sf_UpdFldSetStr = objTabTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objTabTypeENS">源对象</param>
 /// <param name = "objTabTypeENT">目标对象</param>
clsTabTypeBL.CopyObjToSimObj = function(objTabTypeENS , objTabTypeENT ) 
{
objTabTypeENT.TabTypeId = objTabTypeENS.TabTypeId; //表类型Id
objTabTypeENT.TabTypeName = objTabTypeENS.TabTypeName; //表类型名
objTabTypeENT.TabTypeENName = objTabTypeENS.TabTypeENName; //表类型英文名
objTabTypeENT.Memo = objTabTypeENS.Memo; //说明
objTabTypeENT.sf_UpdFldSetStr = objTabTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objTabTypeENT.sf_FldComparisonOp = objTabTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objTabTypeENS">源简化对象</param>
 /// <param name = "objTabTypeENT">目标对象</param>
clsTabTypeBL.CopyObjFromSimObj4Upd = function(objTabTypeENS, objTabTypeENT )
 {
   var strsf_UpdFldSetStr = objTabTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsTabTypeEN.con_TabTypeId)  >= 0)
{
objTabTypeENT.TabTypeId = objTabTypeENS.TabTypeId; //表类型Id
}
if (sstrFldSet.indexOf(clsTabTypeEN.con_TabTypeName)  >= 0)
{
objTabTypeENT.TabTypeName = objTabTypeENS.TabTypeName; //表类型名
}
if (sstrFldSet.indexOf(clsTabTypeEN.con_TabTypeENName)  >= 0)
{
objTabTypeENT.TabTypeENName = objTabTypeENS.TabTypeENName; //表类型英文名
}
if (sstrFldSet.indexOf(clsTabTypeEN.con_Memo)  >= 0)
{
objTabTypeENT.Memo = objTabTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objTabTypeENS">源对象</param>
 /// <param name = "objTabTypeENT">目标对象</param>
clsTabTypeBL.GetSimObjFromObj = function(objTabTypeENS)
{
var objTabTypeENT = new clsTabTypeEN_Sim_js_1.clsTabTypeEN_Sim();
objTabTypeENT.TabTypeId = objTabTypeENS.TabTypeId; //表类型Id
objTabTypeENT.TabTypeName = objTabTypeENS.TabTypeName; //表类型名
objTabTypeENT.TabTypeENName = objTabTypeENS.TabTypeENName; //表类型英文名
objTabTypeENT.Memo = objTabTypeENS.Memo; //说明
objTabTypeENT.sf_UpdFldSetStr = objTabTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objTabTypeENT.sf_FldComparisonOp = objTabTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objTabTypeENT;
}
return clsTabTypeBL;
}());
exports.clsTabTypeBL = clsTabTypeBL;
});