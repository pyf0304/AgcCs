
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProgLangTypeBL
 表名:ProgLangType(00050303)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:58
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsProgLangTypeEN.js","../../L0_Entity/SysPara/clsProgLangTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsProgLangTypeEN_js_1 = require("../../L0_Entity/SysPara/clsProgLangTypeEN.js");
var clsProgLangTypeEN_Sim_js_1 = require("../../L0_Entity/SysPara/clsProgLangTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 编程语言类型(ProgLangType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsProgLangTypeBL = /** @class */ (function () {
function clsProgLangTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrProgLangTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsProgLangTypeBL.prototype.CheckPropertyNew = function(pobjProgLangTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjProgLangTypeEN.ProgLangTypeName 
 || null !== pobjProgLangTypeEN.ProgLangTypeName && pobjProgLangTypeEN.ProgLangTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[编程语言类型|编程语言类型名]不能为空(NULL)!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null === pobjProgLangTypeEN.CharEncodingId 
 || null !== pobjProgLangTypeEN.CharEncodingId && pobjProgLangTypeEN.CharEncodingId.toString()  ===  ""
 || null !== pobjProgLangTypeEN.CharEncodingId && pobjProgLangTypeEN.CharEncodingId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[编程语言类型|字符编码]不能为空(NULL)!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null === pobjProgLangTypeEN.OrderNum 
 || null !== pobjProgLangTypeEN.OrderNum && pobjProgLangTypeEN.OrderNum.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[编程语言类型|序号]不能为空(NULL)!(clsProgLangTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjProgLangTypeEN.ProgLangTypeId && GetStrLen(pobjProgLangTypeEN.ProgLangTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[编程语言类型(ProgLangType)|编程语言类型Id(ProgLangTypeId)]的长度不能超过2!值:$(pobjProgLangTypeEN.ProgLangTypeId)(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeName && GetStrLen(pobjProgLangTypeEN.ProgLangTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[编程语言类型(ProgLangType)|编程语言类型名(ProgLangTypeName)]的长度不能超过30!值:$(pobjProgLangTypeEN.ProgLangTypeName)(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeSimName && GetStrLen(pobjProgLangTypeEN.ProgLangTypeSimName) > 30)
{
 throw new Error("(errid:Busi000155)字段[编程语言类型(ProgLangType)|编程语言类型简称(ProgLangTypeSimName)]的长度不能超过30!值:$(pobjProgLangTypeEN.ProgLangTypeSimName)(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeENName && GetStrLen(pobjProgLangTypeEN.ProgLangTypeENName) > 50)
{
 throw new Error("(errid:Busi000155)字段[编程语言类型(ProgLangType)|编程语言类型英文名(ProgLangTypeENName)]的长度不能超过50!值:$(pobjProgLangTypeEN.ProgLangTypeENName)(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.CharEncodingId && GetStrLen(pobjProgLangTypeEN.CharEncodingId) > 20)
{
 throw new Error("(errid:Busi000155)字段[编程语言类型(ProgLangType)|字符编码(CharEncodingId)]的长度不能超过20!值:$(pobjProgLangTypeEN.CharEncodingId)(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.UpdDate && GetStrLen(pobjProgLangTypeEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[编程语言类型(ProgLangType)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjProgLangTypeEN.UpdDate)(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.UpdUserId && GetStrLen(pobjProgLangTypeEN.UpdUserId) > 20)
{
 throw new Error("(errid:Busi000155)字段[编程语言类型(ProgLangType)|修改用户Id(UpdUserId)]的长度不能超过20!值:$(pobjProgLangTypeEN.UpdUserId)(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.Memo && GetStrLen(pobjProgLangTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[编程语言类型(ProgLangType)|说明(Memo)]的长度不能超过1000!值:$(pobjProgLangTypeEN.Memo)(clsProgLangTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjProgLangTypeEN.ProgLangTypeId && undefined !== pobjProgLangTypeEN.ProgLangTypeId && tzDataType.isString(pobjProgLangTypeEN.ProgLangTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|编程语言类型Id(ProgLangTypeId)]的值:[$(pobjProgLangTypeEN.ProgLangTypeId)], 非法，应该为字符型!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeName && undefined !== pobjProgLangTypeEN.ProgLangTypeName && tzDataType.isString(pobjProgLangTypeEN.ProgLangTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|编程语言类型名(ProgLangTypeName)]的值:[$(pobjProgLangTypeEN.ProgLangTypeName)], 非法，应该为字符型!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeSimName && undefined !== pobjProgLangTypeEN.ProgLangTypeSimName && tzDataType.isString(pobjProgLangTypeEN.ProgLangTypeSimName) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|编程语言类型简称(ProgLangTypeSimName)]的值:[$(pobjProgLangTypeEN.ProgLangTypeSimName)], 非法，应该为字符型!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeENName && undefined !== pobjProgLangTypeEN.ProgLangTypeENName && tzDataType.isString(pobjProgLangTypeEN.ProgLangTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|编程语言类型英文名(ProgLangTypeENName)]的值:[$(pobjProgLangTypeEN.ProgLangTypeENName)], 非法，应该为字符型!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.CharEncodingId && undefined !== pobjProgLangTypeEN.CharEncodingId && tzDataType.isString(pobjProgLangTypeEN.CharEncodingId) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|字符编码(CharEncodingId)]的值:[$(pobjProgLangTypeEN.CharEncodingId)], 非法，应该为字符型!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.IsVisible && undefined !== pobjProgLangTypeEN.IsVisible && tzDataType.isBoolean(pobjProgLangTypeEN.IsVisible) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|是否显示(IsVisible)]的值:[$(pobjProgLangTypeEN.IsVisible)], 非法，应该为布尔型!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.OrderNum && undefined !== pobjProgLangTypeEN.OrderNum && tzDataType.isNumber(pobjProgLangTypeEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|序号(OrderNum)]的值:[$(pobjProgLangTypeEN.OrderNum)], 非法，应该为数值型!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.UpdDate && undefined !== pobjProgLangTypeEN.UpdDate && tzDataType.isString(pobjProgLangTypeEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|修改日期(UpdDate)]的值:[$(pobjProgLangTypeEN.UpdDate)], 非法，应该为字符型!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.UpdUserId && undefined !== pobjProgLangTypeEN.UpdUserId && tzDataType.isString(pobjProgLangTypeEN.UpdUserId) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|修改用户Id(UpdUserId)]的值:[$(pobjProgLangTypeEN.UpdUserId)], 非法，应该为字符型!(clsProgLangTypeBL:CheckPropertyNew)");
}
if (null !== pobjProgLangTypeEN.Memo && undefined !== pobjProgLangTypeEN.Memo && tzDataType.isString(pobjProgLangTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[编程语言类型(ProgLangType)|说明(Memo)]的值:[$(pobjProgLangTypeEN.Memo)], 非法，应该为字符型!(clsProgLangTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjProgLangTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsProgLangTypeBL.prototype.CheckProperty4Update  = function(pobjProgLangTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjProgLangTypeEN.ProgLangTypeId && GetStrLen(pobjProgLangTypeEN.ProgLangTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[编程语言类型(ProgLangType)|编程语言类型Id(ProgLangTypeId)]的长度不能超过2!值:$(pobjProgLangTypeEN.ProgLangTypeId)(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeName && GetStrLen(pobjProgLangTypeEN.ProgLangTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[编程语言类型(ProgLangType)|编程语言类型名(ProgLangTypeName)]的长度不能超过30!值:$(pobjProgLangTypeEN.ProgLangTypeName)(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeSimName && GetStrLen(pobjProgLangTypeEN.ProgLangTypeSimName) > 30)
{
 throw new Error("(errid:Busi000158)字段[编程语言类型(ProgLangType)|编程语言类型简称(ProgLangTypeSimName)]的长度不能超过30!值:$(pobjProgLangTypeEN.ProgLangTypeSimName)(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeENName && GetStrLen(pobjProgLangTypeEN.ProgLangTypeENName) > 50)
{
 throw new Error("(errid:Busi000158)字段[编程语言类型(ProgLangType)|编程语言类型英文名(ProgLangTypeENName)]的长度不能超过50!值:$(pobjProgLangTypeEN.ProgLangTypeENName)(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.CharEncodingId && GetStrLen(pobjProgLangTypeEN.CharEncodingId) > 20)
{
 throw new Error("(errid:Busi000158)字段[编程语言类型(ProgLangType)|字符编码(CharEncodingId)]的长度不能超过20!值:$(pobjProgLangTypeEN.CharEncodingId)(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.UpdDate && GetStrLen(pobjProgLangTypeEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[编程语言类型(ProgLangType)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjProgLangTypeEN.UpdDate)(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.UpdUserId && GetStrLen(pobjProgLangTypeEN.UpdUserId) > 20)
{
 throw new Error("(errid:Busi000158)字段[编程语言类型(ProgLangType)|修改用户Id(UpdUserId)]的长度不能超过20!值:$(pobjProgLangTypeEN.UpdUserId)(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.Memo && GetStrLen(pobjProgLangTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[编程语言类型(ProgLangType)|说明(Memo)]的长度不能超过1000!值:$(pobjProgLangTypeEN.Memo)(clsProgLangTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjProgLangTypeEN.ProgLangTypeId && undefined !== pobjProgLangTypeEN.ProgLangTypeId && tzDataType.isString(pobjProgLangTypeEN.ProgLangTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|编程语言类型Id(ProgLangTypeId)]的值:[$(pobjProgLangTypeEN.ProgLangTypeId)], 非法，应该为字符型!(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeName && undefined !== pobjProgLangTypeEN.ProgLangTypeName && tzDataType.isString(pobjProgLangTypeEN.ProgLangTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|编程语言类型名(ProgLangTypeName)]的值:[$(pobjProgLangTypeEN.ProgLangTypeName)], 非法，应该为字符型!(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeSimName && undefined !== pobjProgLangTypeEN.ProgLangTypeSimName && tzDataType.isString(pobjProgLangTypeEN.ProgLangTypeSimName) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|编程语言类型简称(ProgLangTypeSimName)]的值:[$(pobjProgLangTypeEN.ProgLangTypeSimName)], 非法，应该为字符型!(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.ProgLangTypeENName && undefined !== pobjProgLangTypeEN.ProgLangTypeENName && tzDataType.isString(pobjProgLangTypeEN.ProgLangTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|编程语言类型英文名(ProgLangTypeENName)]的值:[$(pobjProgLangTypeEN.ProgLangTypeENName)], 非法，应该为字符型!(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.CharEncodingId && undefined !== pobjProgLangTypeEN.CharEncodingId && tzDataType.isString(pobjProgLangTypeEN.CharEncodingId) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|字符编码(CharEncodingId)]的值:[$(pobjProgLangTypeEN.CharEncodingId)], 非法，应该为字符型!(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.IsVisible && undefined !== pobjProgLangTypeEN.IsVisible && tzDataType.isBoolean(pobjProgLangTypeEN.IsVisible) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|是否显示(IsVisible)]的值:[$(pobjProgLangTypeEN.IsVisible)], 非法，应该为布尔型!(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.OrderNum && undefined !== pobjProgLangTypeEN.OrderNum && tzDataType.isNumber(pobjProgLangTypeEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|序号(OrderNum)]的值:[$(pobjProgLangTypeEN.OrderNum)], 非法，应该为数值型!(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.UpdDate && undefined !== pobjProgLangTypeEN.UpdDate && tzDataType.isString(pobjProgLangTypeEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|修改日期(UpdDate)]的值:[$(pobjProgLangTypeEN.UpdDate)], 非法，应该为字符型!(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.UpdUserId && undefined !== pobjProgLangTypeEN.UpdUserId && tzDataType.isString(pobjProgLangTypeEN.UpdUserId) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|修改用户Id(UpdUserId)]的值:[$(pobjProgLangTypeEN.UpdUserId)], 非法，应该为字符型!(clsProgLangTypeBL:CheckProperty4Update)");
}
if (null !== pobjProgLangTypeEN.Memo && undefined !== pobjProgLangTypeEN.Memo && tzDataType.isString(pobjProgLangTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[编程语言类型(ProgLangType)|说明(Memo)]的值:[$(pobjProgLangTypeEN.Memo)], 非法，应该为字符型!(clsProgLangTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjProgLangTypeEN.ProgLangTypeId 
 || null !== pobjProgLangTypeEN.ProgLangTypeId && pobjProgLangTypeEN.ProgLangTypeId.toString()  ===  ""
 || null !== pobjProgLangTypeEN.ProgLangTypeId && pobjProgLangTypeEN.ProgLangTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[编程语言类型|编程语言类型Id]不能为空(NULL)!(clsProgLangTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjProgLangTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024958
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsProgLangTypeBL.GetJSONStrByObj  = function(pobjProgLangTypeEN)
{
pobjProgLangTypeEN.sf_UpdFldSetStr = pobjProgLangTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjProgLangTypeEN);
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
 /// 日期:20200501024958
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsProgLangTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrProgLangTypeObjLst = new Array();
if (strJSON === "")
{
return arrProgLangTypeObjLst;
}
try
{
arrProgLangTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrProgLangTypeObjLst;
}
return arrProgLangTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024958
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsProgLangTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjProgLangTypeEN = new clsProgLangTypeEN();
if (strJSON === "")
{
return pobjProgLangTypeEN;
}
try
{
pobjProgLangTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjProgLangTypeEN;
}
return pobjProgLangTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objProgLangTypeENS">源简化对象</param>
 /// <param name = "objProgLangTypeENT">目标对象</param>
clsProgLangTypeBL.CopyObjFromSimObj = function(objProgLangTypeENS, objProgLangTypeENT) 
{
objProgLangTypeENT.ProgLangTypeId = objProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objProgLangTypeENT.ProgLangTypeName = objProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objProgLangTypeENT.ProgLangTypeSimName = objProgLangTypeENS.ProgLangTypeSimName; //编程语言类型简称
objProgLangTypeENT.ProgLangTypeENName = objProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objProgLangTypeENT.CharEncodingId = objProgLangTypeENS.CharEncodingId; //字符编码
objProgLangTypeENT.IsVisible = objProgLangTypeENS.IsVisible; //是否显示
objProgLangTypeENT.OrderNum = objProgLangTypeENS.OrderNum; //序号
objProgLangTypeENT.UpdDate = objProgLangTypeENS.UpdDate; //修改日期
objProgLangTypeENT.UpdUserId = objProgLangTypeENS.UpdUserId; //修改用户Id
objProgLangTypeENT.Memo = objProgLangTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objProgLangTypeENS">源对象</param>
 /// <param name = "objProgLangTypeENT">目标对象</param>
clsProgLangTypeBL.CopyObjTo = function(objProgLangTypeENS , objProgLangTypeENT ) 
{
objProgLangTypeENT.ProgLangTypeId = objProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objProgLangTypeENT.ProgLangTypeName = objProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objProgLangTypeENT.ProgLangTypeSimName = objProgLangTypeENS.ProgLangTypeSimName; //编程语言类型简称
objProgLangTypeENT.ProgLangTypeENName = objProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objProgLangTypeENT.CharEncodingId = objProgLangTypeENS.CharEncodingId; //字符编码
objProgLangTypeENT.IsVisible = objProgLangTypeENS.IsVisible; //是否显示
objProgLangTypeENT.OrderNum = objProgLangTypeENS.OrderNum; //序号
objProgLangTypeENT.UpdDate = objProgLangTypeENS.UpdDate; //修改日期
objProgLangTypeENT.UpdUserId = objProgLangTypeENS.UpdUserId; //修改用户Id
objProgLangTypeENT.Memo = objProgLangTypeENS.Memo; //说明
objProgLangTypeENT.sf_UpdFldSetStr = objProgLangTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objProgLangTypeENS">源对象</param>
 /// <param name = "objProgLangTypeENT">目标对象</param>
clsProgLangTypeBL.CopyObjToSimObj = function(objProgLangTypeENS , objProgLangTypeENT ) 
{
objProgLangTypeENT.ProgLangTypeId = objProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objProgLangTypeENT.ProgLangTypeName = objProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objProgLangTypeENT.ProgLangTypeSimName = objProgLangTypeENS.ProgLangTypeSimName; //编程语言类型简称
objProgLangTypeENT.ProgLangTypeENName = objProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objProgLangTypeENT.CharEncodingId = objProgLangTypeENS.CharEncodingId; //字符编码
objProgLangTypeENT.IsVisible = objProgLangTypeENS.IsVisible; //是否显示
objProgLangTypeENT.OrderNum = objProgLangTypeENS.OrderNum; //序号
objProgLangTypeENT.UpdDate = objProgLangTypeENS.UpdDate; //修改日期
objProgLangTypeENT.UpdUserId = objProgLangTypeENS.UpdUserId; //修改用户Id
objProgLangTypeENT.Memo = objProgLangTypeENS.Memo; //说明
objProgLangTypeENT.sf_UpdFldSetStr = objProgLangTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objProgLangTypeENT.sf_FldComparisonOp = objProgLangTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objProgLangTypeENS">源简化对象</param>
 /// <param name = "objProgLangTypeENT">目标对象</param>
clsProgLangTypeBL.CopyObjFromSimObj4Upd = function(objProgLangTypeENS, objProgLangTypeENT )
 {
   var strsf_UpdFldSetStr = objProgLangTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_ProgLangTypeId)  >= 0)
{
objProgLangTypeENT.ProgLangTypeId = objProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
}
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_ProgLangTypeName)  >= 0)
{
objProgLangTypeENT.ProgLangTypeName = objProgLangTypeENS.ProgLangTypeName; //编程语言类型名
}
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_ProgLangTypeSimName)  >= 0)
{
objProgLangTypeENT.ProgLangTypeSimName = objProgLangTypeENS.ProgLangTypeSimName; //编程语言类型简称
}
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_ProgLangTypeENName)  >= 0)
{
objProgLangTypeENT.ProgLangTypeENName = objProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
}
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_CharEncodingId)  >= 0)
{
objProgLangTypeENT.CharEncodingId = objProgLangTypeENS.CharEncodingId; //字符编码
}
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_IsVisible)  >= 0)
{
objProgLangTypeENT.IsVisible = objProgLangTypeENS.IsVisible; //是否显示
}
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_OrderNum)  >= 0)
{
objProgLangTypeENT.OrderNum = objProgLangTypeENS.OrderNum; //序号
}
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_UpdDate)  >= 0)
{
objProgLangTypeENT.UpdDate = objProgLangTypeENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_UpdUserId)  >= 0)
{
objProgLangTypeENT.UpdUserId = objProgLangTypeENS.UpdUserId; //修改用户Id
}
if (sstrFldSet.indexOf(clsProgLangTypeEN.con_Memo)  >= 0)
{
objProgLangTypeENT.Memo = objProgLangTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objProgLangTypeENS">源对象</param>
 /// <param name = "objProgLangTypeENT">目标对象</param>
clsProgLangTypeBL.GetSimObjFromObj = function(objProgLangTypeENS)
{
var objProgLangTypeENT = new clsProgLangTypeEN_Sim_js_1.clsProgLangTypeEN_Sim();
objProgLangTypeENT.ProgLangTypeId = objProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objProgLangTypeENT.ProgLangTypeName = objProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objProgLangTypeENT.ProgLangTypeSimName = objProgLangTypeENS.ProgLangTypeSimName; //编程语言类型简称
objProgLangTypeENT.ProgLangTypeENName = objProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objProgLangTypeENT.CharEncodingId = objProgLangTypeENS.CharEncodingId; //字符编码
objProgLangTypeENT.IsVisible = objProgLangTypeENS.IsVisible; //是否显示
objProgLangTypeENT.OrderNum = objProgLangTypeENS.OrderNum; //序号
objProgLangTypeENT.UpdDate = objProgLangTypeENS.UpdDate; //修改日期
objProgLangTypeENT.UpdUserId = objProgLangTypeENS.UpdUserId; //修改用户Id
objProgLangTypeENT.Memo = objProgLangTypeENS.Memo; //说明
objProgLangTypeENT.sf_UpdFldSetStr = objProgLangTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objProgLangTypeENT.sf_FldComparisonOp = objProgLangTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objProgLangTypeENT;
}
return clsProgLangTypeBL;
}());
exports.clsProgLangTypeBL = clsProgLangTypeBL;
});