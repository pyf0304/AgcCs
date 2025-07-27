
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsApplicationTypeBL
 表名:ApplicationType(00050127)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:43
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
define(["require", "exports", "jquery", "../../L0_Entity/GeneCode/clsApplicationTypeEN.js","../../L0_Entity/GeneCode/clsApplicationTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsApplicationTypeEN_js_1 = require("../../L0_Entity/GeneCode/clsApplicationTypeEN.js");
var clsApplicationTypeEN_Sim_js_1 = require("../../L0_Entity/GeneCode/clsApplicationTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 应用程序类型(ApplicationType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsApplicationTypeBL = /** @class */ (function () {
function clsApplicationTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrApplicationTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsApplicationTypeBL.prototype.CheckPropertyNew = function(pobjApplicationTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjApplicationTypeEN.ApplicationTypeName 
 || null !== pobjApplicationTypeEN.ApplicationTypeName && pobjApplicationTypeEN.ApplicationTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[应用程序类型|应用程序类型名称]不能为空(NULL)!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null === pobjApplicationTypeEN.ApplicationTypeENName 
 || null !== pobjApplicationTypeEN.ApplicationTypeENName && pobjApplicationTypeEN.ApplicationTypeENName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[应用程序类型|应用类型英文名]不能为空(NULL)!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null === pobjApplicationTypeEN.OrderNum 
 || null !== pobjApplicationTypeEN.OrderNum && pobjApplicationTypeEN.OrderNum.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[应用程序类型|序号]不能为空(NULL)!(clsApplicationTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjApplicationTypeEN.ApplicationTypeName && GetStrLen(pobjApplicationTypeEN.ApplicationTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[应用程序类型(ApplicationType)|应用程序类型名称(ApplicationTypeName)]的长度不能超过30!值:$(pobjApplicationTypeEN.ApplicationTypeName)(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeSimName && GetStrLen(pobjApplicationTypeEN.ApplicationTypeSimName) > 30)
{
 throw new Error("(errid:Busi000155)字段[应用程序类型(ApplicationType)|应用程序类型简称(ApplicationTypeSimName)]的长度不能超过30!值:$(pobjApplicationTypeEN.ApplicationTypeSimName)(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeENName && GetStrLen(pobjApplicationTypeEN.ApplicationTypeENName) > 30)
{
 throw new Error("(errid:Busi000155)字段[应用程序类型(ApplicationType)|应用类型英文名(ApplicationTypeENName)]的长度不能超过30!值:$(pobjApplicationTypeEN.ApplicationTypeENName)(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[应用程序类型(ApplicationType)|编程语言类型Id(ProgLangTypeId)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId)(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId2 && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId2) > 2)
{
 throw new Error("(errid:Busi000155)字段[应用程序类型(ApplicationType)|编程语言类型Id2(ProgLangTypeId2)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId2)(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId3 && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId3) > 2)
{
 throw new Error("(errid:Busi000155)字段[应用程序类型(ApplicationType)|编程语言类型Id3(ProgLangTypeId3)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId3)(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId4 && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId4) > 2)
{
 throw new Error("(errid:Busi000155)字段[应用程序类型(ApplicationType)|编程语言类型Id4(ProgLangTypeId4)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId4)(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId5 && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId5) > 2)
{
 throw new Error("(errid:Busi000155)字段[应用程序类型(ApplicationType)|编程语言类型Id5(ProgLangTypeId5)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId5)(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.Memo && GetStrLen(pobjApplicationTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[应用程序类型(ApplicationType)|说明(Memo)]的长度不能超过1000!值:$(pobjApplicationTypeEN.Memo)(clsApplicationTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjApplicationTypeEN.ApplicationTypeId && undefined !== pobjApplicationTypeEN.ApplicationTypeId && tzDataType.isNumber(pobjApplicationTypeEN.ApplicationTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|应用程序类型ID(ApplicationTypeId)]的值:[$(pobjApplicationTypeEN.ApplicationTypeId)], 非法，应该为数值型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeName && undefined !== pobjApplicationTypeEN.ApplicationTypeName && tzDataType.isString(pobjApplicationTypeEN.ApplicationTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|应用程序类型名称(ApplicationTypeName)]的值:[$(pobjApplicationTypeEN.ApplicationTypeName)], 非法，应该为字符型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeSimName && undefined !== pobjApplicationTypeEN.ApplicationTypeSimName && tzDataType.isString(pobjApplicationTypeEN.ApplicationTypeSimName) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|应用程序类型简称(ApplicationTypeSimName)]的值:[$(pobjApplicationTypeEN.ApplicationTypeSimName)], 非法，应该为字符型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeENName && undefined !== pobjApplicationTypeEN.ApplicationTypeENName && tzDataType.isString(pobjApplicationTypeEN.ApplicationTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|应用类型英文名(ApplicationTypeENName)]的值:[$(pobjApplicationTypeEN.ApplicationTypeENName)], 非法，应该为字符型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId && undefined !== pobjApplicationTypeEN.ProgLangTypeId && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|编程语言类型Id(ProgLangTypeId)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId)], 非法，应该为字符型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId2 && undefined !== pobjApplicationTypeEN.ProgLangTypeId2 && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId2) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|编程语言类型Id2(ProgLangTypeId2)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId2)], 非法，应该为字符型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId3 && undefined !== pobjApplicationTypeEN.ProgLangTypeId3 && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId3) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|编程语言类型Id3(ProgLangTypeId3)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId3)], 非法，应该为字符型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId4 && undefined !== pobjApplicationTypeEN.ProgLangTypeId4 && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId4) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|编程语言类型Id4(ProgLangTypeId4)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId4)], 非法，应该为字符型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId5 && undefined !== pobjApplicationTypeEN.ProgLangTypeId5 && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId5) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|编程语言类型Id5(ProgLangTypeId5)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId5)], 非法，应该为字符型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.IsVisible && undefined !== pobjApplicationTypeEN.IsVisible && tzDataType.isBoolean(pobjApplicationTypeEN.IsVisible) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|是否显示(IsVisible)]的值:[$(pobjApplicationTypeEN.IsVisible)], 非法，应该为布尔型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.VisitedNum && undefined !== pobjApplicationTypeEN.VisitedNum && tzDataType.isNumber(pobjApplicationTypeEN.VisitedNum) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|访问数(VisitedNum)]的值:[$(pobjApplicationTypeEN.VisitedNum)], 非法，应该为数值型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.OrderNum && undefined !== pobjApplicationTypeEN.OrderNum && tzDataType.isNumber(pobjApplicationTypeEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|序号(OrderNum)]的值:[$(pobjApplicationTypeEN.OrderNum)], 非法，应该为数值型!(clsApplicationTypeBL:CheckPropertyNew)");
}
if (null !== pobjApplicationTypeEN.Memo && undefined !== pobjApplicationTypeEN.Memo && tzDataType.isString(pobjApplicationTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[应用程序类型(ApplicationType)|说明(Memo)]的值:[$(pobjApplicationTypeEN.Memo)], 非法，应该为字符型!(clsApplicationTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjApplicationTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsApplicationTypeBL.prototype.CheckProperty4Update  = function(pobjApplicationTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjApplicationTypeEN.ApplicationTypeName && GetStrLen(pobjApplicationTypeEN.ApplicationTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[应用程序类型(ApplicationType)|应用程序类型名称(ApplicationTypeName)]的长度不能超过30!值:$(pobjApplicationTypeEN.ApplicationTypeName)(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeSimName && GetStrLen(pobjApplicationTypeEN.ApplicationTypeSimName) > 30)
{
 throw new Error("(errid:Busi000158)字段[应用程序类型(ApplicationType)|应用程序类型简称(ApplicationTypeSimName)]的长度不能超过30!值:$(pobjApplicationTypeEN.ApplicationTypeSimName)(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeENName && GetStrLen(pobjApplicationTypeEN.ApplicationTypeENName) > 30)
{
 throw new Error("(errid:Busi000158)字段[应用程序类型(ApplicationType)|应用类型英文名(ApplicationTypeENName)]的长度不能超过30!值:$(pobjApplicationTypeEN.ApplicationTypeENName)(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[应用程序类型(ApplicationType)|编程语言类型Id(ProgLangTypeId)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId)(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId2 && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId2) > 2)
{
 throw new Error("(errid:Busi000158)字段[应用程序类型(ApplicationType)|编程语言类型Id2(ProgLangTypeId2)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId2)(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId3 && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId3) > 2)
{
 throw new Error("(errid:Busi000158)字段[应用程序类型(ApplicationType)|编程语言类型Id3(ProgLangTypeId3)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId3)(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId4 && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId4) > 2)
{
 throw new Error("(errid:Busi000158)字段[应用程序类型(ApplicationType)|编程语言类型Id4(ProgLangTypeId4)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId4)(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId5 && GetStrLen(pobjApplicationTypeEN.ProgLangTypeId5) > 2)
{
 throw new Error("(errid:Busi000158)字段[应用程序类型(ApplicationType)|编程语言类型Id5(ProgLangTypeId5)]的长度不能超过2!值:$(pobjApplicationTypeEN.ProgLangTypeId5)(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.Memo && GetStrLen(pobjApplicationTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[应用程序类型(ApplicationType)|说明(Memo)]的长度不能超过1000!值:$(pobjApplicationTypeEN.Memo)(clsApplicationTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjApplicationTypeEN.ApplicationTypeId && undefined !== pobjApplicationTypeEN.ApplicationTypeId && tzDataType.isNumber(pobjApplicationTypeEN.ApplicationTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|应用程序类型ID(ApplicationTypeId)]的值:[$(pobjApplicationTypeEN.ApplicationTypeId)], 非法，应该为数值型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeName && undefined !== pobjApplicationTypeEN.ApplicationTypeName && tzDataType.isString(pobjApplicationTypeEN.ApplicationTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|应用程序类型名称(ApplicationTypeName)]的值:[$(pobjApplicationTypeEN.ApplicationTypeName)], 非法，应该为字符型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeSimName && undefined !== pobjApplicationTypeEN.ApplicationTypeSimName && tzDataType.isString(pobjApplicationTypeEN.ApplicationTypeSimName) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|应用程序类型简称(ApplicationTypeSimName)]的值:[$(pobjApplicationTypeEN.ApplicationTypeSimName)], 非法，应该为字符型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ApplicationTypeENName && undefined !== pobjApplicationTypeEN.ApplicationTypeENName && tzDataType.isString(pobjApplicationTypeEN.ApplicationTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|应用类型英文名(ApplicationTypeENName)]的值:[$(pobjApplicationTypeEN.ApplicationTypeENName)], 非法，应该为字符型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId && undefined !== pobjApplicationTypeEN.ProgLangTypeId && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|编程语言类型Id(ProgLangTypeId)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId)], 非法，应该为字符型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId2 && undefined !== pobjApplicationTypeEN.ProgLangTypeId2 && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId2) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|编程语言类型Id2(ProgLangTypeId2)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId2)], 非法，应该为字符型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId3 && undefined !== pobjApplicationTypeEN.ProgLangTypeId3 && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId3) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|编程语言类型Id3(ProgLangTypeId3)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId3)], 非法，应该为字符型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId4 && undefined !== pobjApplicationTypeEN.ProgLangTypeId4 && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId4) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|编程语言类型Id4(ProgLangTypeId4)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId4)], 非法，应该为字符型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.ProgLangTypeId5 && undefined !== pobjApplicationTypeEN.ProgLangTypeId5 && tzDataType.isString(pobjApplicationTypeEN.ProgLangTypeId5) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|编程语言类型Id5(ProgLangTypeId5)]的值:[$(pobjApplicationTypeEN.ProgLangTypeId5)], 非法，应该为字符型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.IsVisible && undefined !== pobjApplicationTypeEN.IsVisible && tzDataType.isBoolean(pobjApplicationTypeEN.IsVisible) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|是否显示(IsVisible)]的值:[$(pobjApplicationTypeEN.IsVisible)], 非法，应该为布尔型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.VisitedNum && undefined !== pobjApplicationTypeEN.VisitedNum && tzDataType.isNumber(pobjApplicationTypeEN.VisitedNum) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|访问数(VisitedNum)]的值:[$(pobjApplicationTypeEN.VisitedNum)], 非法，应该为数值型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.OrderNum && undefined !== pobjApplicationTypeEN.OrderNum && tzDataType.isNumber(pobjApplicationTypeEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|序号(OrderNum)]的值:[$(pobjApplicationTypeEN.OrderNum)], 非法，应该为数值型!(clsApplicationTypeBL:CheckProperty4Update)");
}
if (null !== pobjApplicationTypeEN.Memo && undefined !== pobjApplicationTypeEN.Memo && tzDataType.isString(pobjApplicationTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[应用程序类型(ApplicationType)|说明(Memo)]的值:[$(pobjApplicationTypeEN.Memo)], 非法，应该为字符型!(clsApplicationTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjApplicationTypeEN.ApplicationTypeId 
 || null !== pobjApplicationTypeEN.ApplicationTypeId && pobjApplicationTypeEN.ApplicationTypeId.toString()  ===  ""
 || null !== pobjApplicationTypeEN.ApplicationTypeId && pobjApplicationTypeEN.ApplicationTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[应用程序类型|应用程序类型ID]不能为空(NULL)!(clsApplicationTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjApplicationTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024943
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsApplicationTypeBL.GetJSONStrByObj  = function(pobjApplicationTypeEN)
{
pobjApplicationTypeEN.sf_UpdFldSetStr = pobjApplicationTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjApplicationTypeEN);
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
 /// 日期:20200501024943
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsApplicationTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrApplicationTypeObjLst = new Array();
if (strJSON === "")
{
return arrApplicationTypeObjLst;
}
try
{
arrApplicationTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrApplicationTypeObjLst;
}
return arrApplicationTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024943
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsApplicationTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjApplicationTypeEN = new clsApplicationTypeEN();
if (strJSON === "")
{
return pobjApplicationTypeEN;
}
try
{
pobjApplicationTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjApplicationTypeEN;
}
return pobjApplicationTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objApplicationTypeENS">源简化对象</param>
 /// <param name = "objApplicationTypeENT">目标对象</param>
clsApplicationTypeBL.CopyObjFromSimObj = function(objApplicationTypeENS, objApplicationTypeENT) 
{
objApplicationTypeENT.ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objApplicationTypeENT.ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objApplicationTypeENT.ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objApplicationTypeENT.ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objApplicationTypeENT.ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objApplicationTypeENT.ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objApplicationTypeENT.ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objApplicationTypeENT.ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objApplicationTypeENT.ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objApplicationTypeENT.IsVisible = objApplicationTypeENS.IsVisible; //是否显示
objApplicationTypeENT.VisitedNum = objApplicationTypeENS.VisitedNum; //访问数
objApplicationTypeENT.OrderNum = objApplicationTypeENS.OrderNum; //序号
objApplicationTypeENT.Memo = objApplicationTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objApplicationTypeENS">源对象</param>
 /// <param name = "objApplicationTypeENT">目标对象</param>
clsApplicationTypeBL.CopyObjTo = function(objApplicationTypeENS , objApplicationTypeENT ) 
{
objApplicationTypeENT.ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objApplicationTypeENT.ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objApplicationTypeENT.ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objApplicationTypeENT.ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objApplicationTypeENT.ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objApplicationTypeENT.ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objApplicationTypeENT.ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objApplicationTypeENT.ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objApplicationTypeENT.ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objApplicationTypeENT.IsVisible = objApplicationTypeENS.IsVisible; //是否显示
objApplicationTypeENT.VisitedNum = objApplicationTypeENS.VisitedNum; //访问数
objApplicationTypeENT.OrderNum = objApplicationTypeENS.OrderNum; //序号
objApplicationTypeENT.Memo = objApplicationTypeENS.Memo; //说明
objApplicationTypeENT.sf_UpdFldSetStr = objApplicationTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objApplicationTypeENS">源对象</param>
 /// <param name = "objApplicationTypeENT">目标对象</param>
clsApplicationTypeBL.CopyObjToSimObj = function(objApplicationTypeENS , objApplicationTypeENT ) 
{
objApplicationTypeENT.ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objApplicationTypeENT.ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objApplicationTypeENT.ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objApplicationTypeENT.ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objApplicationTypeENT.ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objApplicationTypeENT.ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objApplicationTypeENT.ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objApplicationTypeENT.ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objApplicationTypeENT.ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objApplicationTypeENT.IsVisible = objApplicationTypeENS.IsVisible; //是否显示
objApplicationTypeENT.VisitedNum = objApplicationTypeENS.VisitedNum; //访问数
objApplicationTypeENT.OrderNum = objApplicationTypeENS.OrderNum; //序号
objApplicationTypeENT.Memo = objApplicationTypeENS.Memo; //说明
objApplicationTypeENT.sf_UpdFldSetStr = objApplicationTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objApplicationTypeENT.sf_FldComparisonOp = objApplicationTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objApplicationTypeENS">源简化对象</param>
 /// <param name = "objApplicationTypeENT">目标对象</param>
clsApplicationTypeBL.CopyObjFromSimObj4Upd = function(objApplicationTypeENS, objApplicationTypeENT )
 {
   var strsf_UpdFldSetStr = objApplicationTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_ApplicationTypeId)  >= 0)
{
objApplicationTypeENT.ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_ApplicationTypeName)  >= 0)
{
objApplicationTypeENT.ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_ApplicationTypeSimName)  >= 0)
{
objApplicationTypeENT.ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_ApplicationTypeENName)  >= 0)
{
objApplicationTypeENT.ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_ProgLangTypeId)  >= 0)
{
objApplicationTypeENT.ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_ProgLangTypeId2)  >= 0)
{
objApplicationTypeENT.ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_ProgLangTypeId3)  >= 0)
{
objApplicationTypeENT.ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_ProgLangTypeId4)  >= 0)
{
objApplicationTypeENT.ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_ProgLangTypeId5)  >= 0)
{
objApplicationTypeENT.ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_IsVisible)  >= 0)
{
objApplicationTypeENT.IsVisible = objApplicationTypeENS.IsVisible; //是否显示
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_VisitedNum)  >= 0)
{
objApplicationTypeENT.VisitedNum = objApplicationTypeENS.VisitedNum; //访问数
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_OrderNum)  >= 0)
{
objApplicationTypeENT.OrderNum = objApplicationTypeENS.OrderNum; //序号
}
if (sstrFldSet.indexOf(clsApplicationTypeEN.con_Memo)  >= 0)
{
objApplicationTypeENT.Memo = objApplicationTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objApplicationTypeENS">源对象</param>
 /// <param name = "objApplicationTypeENT">目标对象</param>
clsApplicationTypeBL.GetSimObjFromObj = function(objApplicationTypeENS)
{
var objApplicationTypeENT = new clsApplicationTypeEN_Sim_js_1.clsApplicationTypeEN_Sim();
objApplicationTypeENT.ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objApplicationTypeENT.ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objApplicationTypeENT.ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objApplicationTypeENT.ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objApplicationTypeENT.ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objApplicationTypeENT.ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objApplicationTypeENT.ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objApplicationTypeENT.ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objApplicationTypeENT.ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objApplicationTypeENT.IsVisible = objApplicationTypeENS.IsVisible; //是否显示
objApplicationTypeENT.VisitedNum = objApplicationTypeENS.VisitedNum; //访问数
objApplicationTypeENT.OrderNum = objApplicationTypeENS.OrderNum; //序号
objApplicationTypeENT.Memo = objApplicationTypeENS.Memo; //说明
objApplicationTypeENT.sf_UpdFldSetStr = objApplicationTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objApplicationTypeENT.sf_FldComparisonOp = objApplicationTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objApplicationTypeENT;
}
return clsApplicationTypeBL;
}());
exports.clsApplicationTypeBL = clsApplicationTypeBL;
});