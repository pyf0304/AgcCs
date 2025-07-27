
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRegionTypeBL
 表名:RegionType(00050081)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/03 10:49:22
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
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
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsRegionTypeEN.js","../../L0_Entity/RegionManage/clsRegionTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsRegionTypeEN_js_1 = require("../../L0_Entity/RegionManage/clsRegionTypeEN.js");
var clsRegionTypeEN_Sim_js_1 = require("../../L0_Entity/RegionManage/clsRegionTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 区域类型(RegionType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsRegionTypeBL = /** @class */ (function () {
function clsRegionTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrRegionTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsRegionTypeBL.prototype.CheckPropertyNew = function(pobjRegionTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjRegionTypeEN.RegionTypeName 
 || null !== pobjRegionTypeEN.RegionTypeName && pobjRegionTypeEN.RegionTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[区域类型|区域类型名称]不能为空(NULL)!(clsRegionTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjRegionTypeEN.RegionTypeId && GetStrLen(pobjRegionTypeEN.RegionTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[区域类型(RegionType)|区域类型Id(RegionTypeId)]的长度不能超过4!值:$(pobjRegionTypeEN.RegionTypeId)(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.RegionTypeName && GetStrLen(pobjRegionTypeEN.RegionTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[区域类型(RegionType)|区域类型名称(RegionTypeName)]的长度不能超过30!值:$(pobjRegionTypeEN.RegionTypeName)(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.RegionTypeENName && GetStrLen(pobjRegionTypeEN.RegionTypeENName) > 30)
{
 throw new Error("(errid:Busi000155)字段[区域类型(RegionType)|区域类型英文名(RegionTypeENName)]的长度不能超过30!值:$(pobjRegionTypeEN.RegionTypeENName)(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.RegionTypeSimName && GetStrLen(pobjRegionTypeEN.RegionTypeSimName) > 10)
{
 throw new Error("(errid:Busi000155)字段[区域类型(RegionType)|区域类型简名(RegionTypeSimName)]的长度不能超过10!值:$(pobjRegionTypeEN.RegionTypeSimName)(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.Memo && GetStrLen(pobjRegionTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[区域类型(RegionType)|说明(Memo)]的长度不能超过1000!值:$(pobjRegionTypeEN.Memo)(clsRegionTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjRegionTypeEN.RegionTypeId && undefined !== pobjRegionTypeEN.RegionTypeId && tzDataType.isString(pobjRegionTypeEN.RegionTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[区域类型(RegionType)|区域类型Id(RegionTypeId)]的值:[$(pobjRegionTypeEN.RegionTypeId)], 非法，应该为字符型!(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.RegionTypeName && undefined !== pobjRegionTypeEN.RegionTypeName && tzDataType.isString(pobjRegionTypeEN.RegionTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[区域类型(RegionType)|区域类型名称(RegionTypeName)]的值:[$(pobjRegionTypeEN.RegionTypeName)], 非法，应该为字符型!(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.RegionTypeENName && undefined !== pobjRegionTypeEN.RegionTypeENName && tzDataType.isString(pobjRegionTypeEN.RegionTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[区域类型(RegionType)|区域类型英文名(RegionTypeENName)]的值:[$(pobjRegionTypeEN.RegionTypeENName)], 非法，应该为字符型!(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.RegionTypeSimName && undefined !== pobjRegionTypeEN.RegionTypeSimName && tzDataType.isString(pobjRegionTypeEN.RegionTypeSimName) === false)
{
 throw new Error("(errid:Busi000156)字段[区域类型(RegionType)|区域类型简名(RegionTypeSimName)]的值:[$(pobjRegionTypeEN.RegionTypeSimName)], 非法，应该为字符型!(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.DefaWidth && undefined !== pobjRegionTypeEN.DefaWidth && tzDataType.isNumber(pobjRegionTypeEN.DefaWidth) === false)
{
 throw new Error("(errid:Busi000156)字段[区域类型(RegionType)|缺省宽度(DefaWidth)]的值:[$(pobjRegionTypeEN.DefaWidth)], 非法，应该为数值型!(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.RegionTypeOrderNum && undefined !== pobjRegionTypeEN.RegionTypeOrderNum && tzDataType.isNumber(pobjRegionTypeEN.RegionTypeOrderNum) === false)
{
 throw new Error("(errid:Busi000156)字段[区域类型(RegionType)|区域类型序号(RegionTypeOrderNum)]的值:[$(pobjRegionTypeEN.RegionTypeOrderNum)], 非法，应该为数值型!(clsRegionTypeBL:CheckPropertyNew)");
}
if (null !== pobjRegionTypeEN.Memo && undefined !== pobjRegionTypeEN.Memo && tzDataType.isString(pobjRegionTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[区域类型(RegionType)|说明(Memo)]的值:[$(pobjRegionTypeEN.Memo)], 非法，应该为字符型!(clsRegionTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjRegionTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsRegionTypeBL.prototype.CheckProperty4Update  = function(pobjRegionTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjRegionTypeEN.RegionTypeId && GetStrLen(pobjRegionTypeEN.RegionTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[区域类型(RegionType)|区域类型Id(RegionTypeId)]的长度不能超过4!值:$(pobjRegionTypeEN.RegionTypeId)(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.RegionTypeName && GetStrLen(pobjRegionTypeEN.RegionTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[区域类型(RegionType)|区域类型名称(RegionTypeName)]的长度不能超过30!值:$(pobjRegionTypeEN.RegionTypeName)(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.RegionTypeENName && GetStrLen(pobjRegionTypeEN.RegionTypeENName) > 30)
{
 throw new Error("(errid:Busi000158)字段[区域类型(RegionType)|区域类型英文名(RegionTypeENName)]的长度不能超过30!值:$(pobjRegionTypeEN.RegionTypeENName)(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.RegionTypeSimName && GetStrLen(pobjRegionTypeEN.RegionTypeSimName) > 10)
{
 throw new Error("(errid:Busi000158)字段[区域类型(RegionType)|区域类型简名(RegionTypeSimName)]的长度不能超过10!值:$(pobjRegionTypeEN.RegionTypeSimName)(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.Memo && GetStrLen(pobjRegionTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[区域类型(RegionType)|说明(Memo)]的长度不能超过1000!值:$(pobjRegionTypeEN.Memo)(clsRegionTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjRegionTypeEN.RegionTypeId && undefined !== pobjRegionTypeEN.RegionTypeId && tzDataType.isString(pobjRegionTypeEN.RegionTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[区域类型(RegionType)|区域类型Id(RegionTypeId)]的值:[$(pobjRegionTypeEN.RegionTypeId)], 非法，应该为字符型!(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.RegionTypeName && undefined !== pobjRegionTypeEN.RegionTypeName && tzDataType.isString(pobjRegionTypeEN.RegionTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[区域类型(RegionType)|区域类型名称(RegionTypeName)]的值:[$(pobjRegionTypeEN.RegionTypeName)], 非法，应该为字符型!(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.RegionTypeENName && undefined !== pobjRegionTypeEN.RegionTypeENName && tzDataType.isString(pobjRegionTypeEN.RegionTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[区域类型(RegionType)|区域类型英文名(RegionTypeENName)]的值:[$(pobjRegionTypeEN.RegionTypeENName)], 非法，应该为字符型!(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.RegionTypeSimName && undefined !== pobjRegionTypeEN.RegionTypeSimName && tzDataType.isString(pobjRegionTypeEN.RegionTypeSimName) === false)
{
 throw new Error("(errid:Busi000159)字段[区域类型(RegionType)|区域类型简名(RegionTypeSimName)]的值:[$(pobjRegionTypeEN.RegionTypeSimName)], 非法，应该为字符型!(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.DefaWidth && undefined !== pobjRegionTypeEN.DefaWidth && tzDataType.isNumber(pobjRegionTypeEN.DefaWidth) === false)
{
 throw new Error("(errid:Busi000159)字段[区域类型(RegionType)|缺省宽度(DefaWidth)]的值:[$(pobjRegionTypeEN.DefaWidth)], 非法，应该为数值型!(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.RegionTypeOrderNum && undefined !== pobjRegionTypeEN.RegionTypeOrderNum && tzDataType.isNumber(pobjRegionTypeEN.RegionTypeOrderNum) === false)
{
 throw new Error("(errid:Busi000159)字段[区域类型(RegionType)|区域类型序号(RegionTypeOrderNum)]的值:[$(pobjRegionTypeEN.RegionTypeOrderNum)], 非法，应该为数值型!(clsRegionTypeBL:CheckProperty4Update)");
}
if (null !== pobjRegionTypeEN.Memo && undefined !== pobjRegionTypeEN.Memo && tzDataType.isString(pobjRegionTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[区域类型(RegionType)|说明(Memo)]的值:[$(pobjRegionTypeEN.Memo)], 非法，应该为字符型!(clsRegionTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjRegionTypeEN.RegionTypeId 
 || null !== pobjRegionTypeEN.RegionTypeId && pobjRegionTypeEN.RegionTypeId.toString()  ===  ""
 || null !== pobjRegionTypeEN.RegionTypeId && pobjRegionTypeEN.RegionTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[区域类型|区域类型Id]不能为空(NULL)!(clsRegionTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjRegionTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200503104922
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsRegionTypeBL.GetJSONStrByObj  = function(pobjRegionTypeEN)
{
pobjRegionTypeEN.sf_UpdFldSetStr = pobjRegionTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjRegionTypeEN);
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
 /// 日期:20200503104922
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsRegionTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrRegionTypeObjLst = new Array();
if (strJSON === "")
{
return arrRegionTypeObjLst;
}
try
{
arrRegionTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrRegionTypeObjLst;
}
return arrRegionTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200503104922
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsRegionTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjRegionTypeEN = new clsRegionTypeEN();
if (strJSON === "")
{
return pobjRegionTypeEN;
}
try
{
pobjRegionTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjRegionTypeEN;
}
return pobjRegionTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objRegionTypeENS">源简化对象</param>
 /// <param name = "objRegionTypeENT">目标对象</param>
clsRegionTypeBL.CopyObjFromSimObj = function(objRegionTypeENS, objRegionTypeENT) 
{
objRegionTypeENT.RegionTypeId = objRegionTypeENS.RegionTypeId; //区域类型Id
objRegionTypeENT.RegionTypeName = objRegionTypeENS.RegionTypeName; //区域类型名称
objRegionTypeENT.RegionTypeENName = objRegionTypeENS.RegionTypeENName; //区域类型英文名
objRegionTypeENT.RegionTypeSimName = objRegionTypeENS.RegionTypeSimName; //区域类型简名
objRegionTypeENT.DefaWidth = objRegionTypeENS.DefaWidth; //缺省宽度
objRegionTypeENT.RegionTypeOrderNum = objRegionTypeENS.RegionTypeOrderNum; //区域类型序号
objRegionTypeENT.Memo = objRegionTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objRegionTypeENS">源对象</param>
 /// <param name = "objRegionTypeENT">目标对象</param>
clsRegionTypeBL.CopyObjTo = function(objRegionTypeENS , objRegionTypeENT ) 
{
objRegionTypeENT.RegionTypeId = objRegionTypeENS.RegionTypeId; //区域类型Id
objRegionTypeENT.RegionTypeName = objRegionTypeENS.RegionTypeName; //区域类型名称
objRegionTypeENT.RegionTypeENName = objRegionTypeENS.RegionTypeENName; //区域类型英文名
objRegionTypeENT.RegionTypeSimName = objRegionTypeENS.RegionTypeSimName; //区域类型简名
objRegionTypeENT.DefaWidth = objRegionTypeENS.DefaWidth; //缺省宽度
objRegionTypeENT.RegionTypeOrderNum = objRegionTypeENS.RegionTypeOrderNum; //区域类型序号
objRegionTypeENT.Memo = objRegionTypeENS.Memo; //说明
objRegionTypeENT.sf_UpdFldSetStr = objRegionTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objRegionTypeENS">源对象</param>
 /// <param name = "objRegionTypeENT">目标对象</param>
clsRegionTypeBL.CopyObjToSimObj = function(objRegionTypeENS , objRegionTypeENT ) 
{
objRegionTypeENT.RegionTypeId = objRegionTypeENS.RegionTypeId; //区域类型Id
objRegionTypeENT.RegionTypeName = objRegionTypeENS.RegionTypeName; //区域类型名称
objRegionTypeENT.RegionTypeENName = objRegionTypeENS.RegionTypeENName; //区域类型英文名
objRegionTypeENT.RegionTypeSimName = objRegionTypeENS.RegionTypeSimName; //区域类型简名
objRegionTypeENT.DefaWidth = objRegionTypeENS.DefaWidth; //缺省宽度
objRegionTypeENT.RegionTypeOrderNum = objRegionTypeENS.RegionTypeOrderNum; //区域类型序号
objRegionTypeENT.Memo = objRegionTypeENS.Memo; //说明
objRegionTypeENT.sf_UpdFldSetStr = objRegionTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objRegionTypeENT.sf_FldComparisonOp = objRegionTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objRegionTypeENS">源简化对象</param>
 /// <param name = "objRegionTypeENT">目标对象</param>
clsRegionTypeBL.CopyObjFromSimObj4Upd = function(objRegionTypeENS, objRegionTypeENT )
 {
   var strsf_UpdFldSetStr = objRegionTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsRegionTypeEN.con_RegionTypeId)  >= 0)
{
objRegionTypeENT.RegionTypeId = objRegionTypeENS.RegionTypeId; //区域类型Id
}
if (sstrFldSet.indexOf(clsRegionTypeEN.con_RegionTypeName)  >= 0)
{
objRegionTypeENT.RegionTypeName = objRegionTypeENS.RegionTypeName; //区域类型名称
}
if (sstrFldSet.indexOf(clsRegionTypeEN.con_RegionTypeENName)  >= 0)
{
objRegionTypeENT.RegionTypeENName = objRegionTypeENS.RegionTypeENName; //区域类型英文名
}
if (sstrFldSet.indexOf(clsRegionTypeEN.con_RegionTypeSimName)  >= 0)
{
objRegionTypeENT.RegionTypeSimName = objRegionTypeENS.RegionTypeSimName; //区域类型简名
}
if (sstrFldSet.indexOf(clsRegionTypeEN.con_DefaWidth)  >= 0)
{
objRegionTypeENT.DefaWidth = objRegionTypeENS.DefaWidth; //缺省宽度
}
if (sstrFldSet.indexOf(clsRegionTypeEN.con_RegionTypeOrderNum)  >= 0)
{
objRegionTypeENT.RegionTypeOrderNum = objRegionTypeENS.RegionTypeOrderNum; //区域类型序号
}
if (sstrFldSet.indexOf(clsRegionTypeEN.con_Memo)  >= 0)
{
objRegionTypeENT.Memo = objRegionTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objRegionTypeENS">源对象</param>
 /// <param name = "objRegionTypeENT">目标对象</param>
clsRegionTypeBL.GetSimObjFromObj = function(objRegionTypeENS)
{
var objRegionTypeENT = new clsRegionTypeEN_Sim_js_1.clsRegionTypeEN_Sim();
objRegionTypeENT.RegionTypeId = objRegionTypeENS.RegionTypeId; //区域类型Id
objRegionTypeENT.RegionTypeName = objRegionTypeENS.RegionTypeName; //区域类型名称
objRegionTypeENT.RegionTypeENName = objRegionTypeENS.RegionTypeENName; //区域类型英文名
objRegionTypeENT.RegionTypeSimName = objRegionTypeENS.RegionTypeSimName; //区域类型简名
objRegionTypeENT.DefaWidth = objRegionTypeENS.DefaWidth; //缺省宽度
objRegionTypeENT.RegionTypeOrderNum = objRegionTypeENS.RegionTypeOrderNum; //区域类型序号
objRegionTypeENT.Memo = objRegionTypeENS.Memo; //说明
objRegionTypeENT.sf_UpdFldSetStr = objRegionTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objRegionTypeENT.sf_FldComparisonOp = objRegionTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objRegionTypeENT;
}
return clsRegionTypeBL;
}());
exports.clsRegionTypeBL = clsRegionTypeBL;
});