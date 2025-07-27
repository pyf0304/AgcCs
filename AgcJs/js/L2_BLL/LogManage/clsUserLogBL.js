
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserLogBL
 表名:UserLog(00050130)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:11
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:日志管理
 模块英文名:LogManage
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
define(["require", "exports", "jquery", "../../L0_Entity/LogManage/clsUserLogEN.js","../../L0_Entity/LogManage/clsUserLogEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsUserLogEN_js_1 = require("../../L0_Entity/LogManage/clsUserLogEN.js");
var clsUserLogEN_Sim_js_1 = require("../../L0_Entity/LogManage/clsUserLogEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 用户日志(UserLog)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsUserLogBL = /** @class */ (function () {
function clsUserLogBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrUserLogObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsUserLogBL.prototype.CheckPropertyNew = function(pobjUserLogEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjUserLogEN.OrderNum 
 || null !== pobjUserLogEN.OrderNum && pobjUserLogEN.OrderNum.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[用户日志|序号]不能为空(NULL)!(clsUserLogBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjUserLogEN.UserId && GetStrLen(pobjUserLogEN.UserId) > 18)
{
 throw new Error("(errid:Busi000155)字段[用户日志(UserLog)|用户Id(UserId)]的长度不能超过18!值:$(pobjUserLogEN.UserId)(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.LoginTime && GetStrLen(pobjUserLogEN.LoginTime) > 6)
{
 throw new Error("(errid:Busi000155)字段[用户日志(UserLog)|登陆时间(LoginTime)]的长度不能超过6!值:$(pobjUserLogEN.LoginTime)(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.LoginDate && GetStrLen(pobjUserLogEN.LoginDate) > 8)
{
 throw new Error("(errid:Busi000155)字段[用户日志(UserLog)|登陆日期(LoginDate)]的长度不能超过8!值:$(pobjUserLogEN.LoginDate)(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.UserIp && GetStrLen(pobjUserLogEN.UserIp) > 40)
{
 throw new Error("(errid:Busi000155)字段[用户日志(UserLog)|用户IP(UserIp)]的长度不能超过40!值:$(pobjUserLogEN.UserIp)(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.ObjectTable && GetStrLen(pobjUserLogEN.ObjectTable) > 50)
{
 throw new Error("(errid:Busi000155)字段[用户日志(UserLog)|对象表(ObjectTable)]的长度不能超过50!值:$(pobjUserLogEN.ObjectTable)(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.UsedValue && GetStrLen(pobjUserLogEN.UsedValue) > 50)
{
 throw new Error("(errid:Busi000155)字段[用户日志(UserLog)|使用值(UsedValue)]的长度不能超过50!值:$(pobjUserLogEN.UsedValue)(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.UpdDate && GetStrLen(pobjUserLogEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[用户日志(UserLog)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjUserLogEN.UpdDate)(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.Memo && GetStrLen(pobjUserLogEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[用户日志(UserLog)|说明(Memo)]的长度不能超过1000!值:$(pobjUserLogEN.Memo)(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN._DeletedDate && GetStrLen(pobjUserLogEN._DeletedDate) > 50)
{
 throw new Error("(errid:Busi000155)字段[用户日志(UserLog)|删除日期(_DeletedDate)]的长度不能超过50!值:$(pobjUserLogEN._DeletedDate)(clsUserLogBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjUserLogEN.mId && undefined !== pobjUserLogEN.mId && tzDataType.isNumber(pobjUserLogEN.mId) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|mId(mId)]的值:[$(pobjUserLogEN.mId)], 非法，应该为数值型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.UserId && undefined !== pobjUserLogEN.UserId && tzDataType.isString(pobjUserLogEN.UserId) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|用户Id(UserId)]的值:[$(pobjUserLogEN.UserId)], 非法，应该为字符型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.LoginTime && undefined !== pobjUserLogEN.LoginTime && tzDataType.isString(pobjUserLogEN.LoginTime) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|登陆时间(LoginTime)]的值:[$(pobjUserLogEN.LoginTime)], 非法，应该为字符型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.LoginDate && undefined !== pobjUserLogEN.LoginDate && tzDataType.isString(pobjUserLogEN.LoginDate) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|登陆日期(LoginDate)]的值:[$(pobjUserLogEN.LoginDate)], 非法，应该为字符型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.UserIp && undefined !== pobjUserLogEN.UserIp && tzDataType.isString(pobjUserLogEN.UserIp) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|用户IP(UserIp)]的值:[$(pobjUserLogEN.UserIp)], 非法，应该为字符型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.ObjectTable && undefined !== pobjUserLogEN.ObjectTable && tzDataType.isString(pobjUserLogEN.ObjectTable) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|对象表(ObjectTable)]的值:[$(pobjUserLogEN.ObjectTable)], 非法，应该为字符型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.UsedValue && undefined !== pobjUserLogEN.UsedValue && tzDataType.isString(pobjUserLogEN.UsedValue) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|使用值(UsedValue)]的值:[$(pobjUserLogEN.UsedValue)], 非法，应该为字符型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.UpdDate && undefined !== pobjUserLogEN.UpdDate && tzDataType.isString(pobjUserLogEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|修改日期(UpdDate)]的值:[$(pobjUserLogEN.UpdDate)], 非法，应该为字符型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.Memo && undefined !== pobjUserLogEN.Memo && tzDataType.isString(pobjUserLogEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|说明(Memo)]的值:[$(pobjUserLogEN.Memo)], 非法，应该为字符型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN._IsDeleted && undefined !== pobjUserLogEN._IsDeleted && tzDataType.isBoolean(pobjUserLogEN._IsDeleted) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|是否删除(_IsDeleted)]的值:[$(pobjUserLogEN._IsDeleted)], 非法，应该为布尔型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN.OrderNum && undefined !== pobjUserLogEN.OrderNum && tzDataType.isNumber(pobjUserLogEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|序号(OrderNum)]的值:[$(pobjUserLogEN.OrderNum)], 非法，应该为数值型!(clsUserLogBL:CheckPropertyNew)");
}
if (null !== pobjUserLogEN._DeletedDate && undefined !== pobjUserLogEN._DeletedDate && tzDataType.isString(pobjUserLogEN._DeletedDate) === false)
{
 throw new Error("(errid:Busi000156)字段[用户日志(UserLog)|删除日期(_DeletedDate)]的值:[$(pobjUserLogEN._DeletedDate)], 非法，应该为字符型!(clsUserLogBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjUserLogEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsUserLogBL.prototype.CheckProperty4Update  = function(pobjUserLogEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjUserLogEN.UserId && GetStrLen(pobjUserLogEN.UserId) > 18)
{
 throw new Error("(errid:Busi000158)字段[用户日志(UserLog)|用户Id(UserId)]的长度不能超过18!值:$(pobjUserLogEN.UserId)(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.LoginTime && GetStrLen(pobjUserLogEN.LoginTime) > 6)
{
 throw new Error("(errid:Busi000158)字段[用户日志(UserLog)|登陆时间(LoginTime)]的长度不能超过6!值:$(pobjUserLogEN.LoginTime)(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.LoginDate && GetStrLen(pobjUserLogEN.LoginDate) > 8)
{
 throw new Error("(errid:Busi000158)字段[用户日志(UserLog)|登陆日期(LoginDate)]的长度不能超过8!值:$(pobjUserLogEN.LoginDate)(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.UserIp && GetStrLen(pobjUserLogEN.UserIp) > 40)
{
 throw new Error("(errid:Busi000158)字段[用户日志(UserLog)|用户IP(UserIp)]的长度不能超过40!值:$(pobjUserLogEN.UserIp)(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.ObjectTable && GetStrLen(pobjUserLogEN.ObjectTable) > 50)
{
 throw new Error("(errid:Busi000158)字段[用户日志(UserLog)|对象表(ObjectTable)]的长度不能超过50!值:$(pobjUserLogEN.ObjectTable)(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.UsedValue && GetStrLen(pobjUserLogEN.UsedValue) > 50)
{
 throw new Error("(errid:Busi000158)字段[用户日志(UserLog)|使用值(UsedValue)]的长度不能超过50!值:$(pobjUserLogEN.UsedValue)(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.UpdDate && GetStrLen(pobjUserLogEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[用户日志(UserLog)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjUserLogEN.UpdDate)(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.Memo && GetStrLen(pobjUserLogEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[用户日志(UserLog)|说明(Memo)]的长度不能超过1000!值:$(pobjUserLogEN.Memo)(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN._DeletedDate && GetStrLen(pobjUserLogEN._DeletedDate) > 50)
{
 throw new Error("(errid:Busi000158)字段[用户日志(UserLog)|删除日期(_DeletedDate)]的长度不能超过50!值:$(pobjUserLogEN._DeletedDate)(clsUserLogBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjUserLogEN.mId && undefined !== pobjUserLogEN.mId && tzDataType.isNumber(pobjUserLogEN.mId) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|mId(mId)]的值:[$(pobjUserLogEN.mId)], 非法，应该为数值型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.UserId && undefined !== pobjUserLogEN.UserId && tzDataType.isString(pobjUserLogEN.UserId) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|用户Id(UserId)]的值:[$(pobjUserLogEN.UserId)], 非法，应该为字符型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.LoginTime && undefined !== pobjUserLogEN.LoginTime && tzDataType.isString(pobjUserLogEN.LoginTime) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|登陆时间(LoginTime)]的值:[$(pobjUserLogEN.LoginTime)], 非法，应该为字符型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.LoginDate && undefined !== pobjUserLogEN.LoginDate && tzDataType.isString(pobjUserLogEN.LoginDate) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|登陆日期(LoginDate)]的值:[$(pobjUserLogEN.LoginDate)], 非法，应该为字符型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.UserIp && undefined !== pobjUserLogEN.UserIp && tzDataType.isString(pobjUserLogEN.UserIp) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|用户IP(UserIp)]的值:[$(pobjUserLogEN.UserIp)], 非法，应该为字符型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.ObjectTable && undefined !== pobjUserLogEN.ObjectTable && tzDataType.isString(pobjUserLogEN.ObjectTable) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|对象表(ObjectTable)]的值:[$(pobjUserLogEN.ObjectTable)], 非法，应该为字符型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.UsedValue && undefined !== pobjUserLogEN.UsedValue && tzDataType.isString(pobjUserLogEN.UsedValue) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|使用值(UsedValue)]的值:[$(pobjUserLogEN.UsedValue)], 非法，应该为字符型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.UpdDate && undefined !== pobjUserLogEN.UpdDate && tzDataType.isString(pobjUserLogEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|修改日期(UpdDate)]的值:[$(pobjUserLogEN.UpdDate)], 非法，应该为字符型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.Memo && undefined !== pobjUserLogEN.Memo && tzDataType.isString(pobjUserLogEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|说明(Memo)]的值:[$(pobjUserLogEN.Memo)], 非法，应该为字符型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN._IsDeleted && undefined !== pobjUserLogEN._IsDeleted && tzDataType.isBoolean(pobjUserLogEN._IsDeleted) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|是否删除(_IsDeleted)]的值:[$(pobjUserLogEN._IsDeleted)], 非法，应该为布尔型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN.OrderNum && undefined !== pobjUserLogEN.OrderNum && tzDataType.isNumber(pobjUserLogEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|序号(OrderNum)]的值:[$(pobjUserLogEN.OrderNum)], 非法，应该为数值型!(clsUserLogBL:CheckProperty4Update)");
}
if (null !== pobjUserLogEN._DeletedDate && undefined !== pobjUserLogEN._DeletedDate && tzDataType.isString(pobjUserLogEN._DeletedDate) === false)
{
 throw new Error("(errid:Busi000159)字段[用户日志(UserLog)|删除日期(_DeletedDate)]的值:[$(pobjUserLogEN._DeletedDate)], 非法，应该为字符型!(clsUserLogBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjUserLogEN.mId 
 || null !== pobjUserLogEN.mId && pobjUserLogEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Busi000160)字段[用户日志|mId]不能为空(NULL)!(clsUserLogBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjUserLogEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024911
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsUserLogBL.GetJSONStrByObj  = function(pobjUserLogEN)
{
pobjUserLogEN.sf_UpdFldSetStr = pobjUserLogEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjUserLogEN);
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
 /// 日期:20200501024911
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsUserLogBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrUserLogObjLst = new Array();
if (strJSON === "")
{
return arrUserLogObjLst;
}
try
{
arrUserLogObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrUserLogObjLst;
}
return arrUserLogObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024911
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsUserLogBL.GetObjByJSONStr  = function(strJSON)
{
var pobjUserLogEN = new clsUserLogEN();
if (strJSON === "")
{
return pobjUserLogEN;
}
try
{
pobjUserLogEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjUserLogEN;
}
return pobjUserLogEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objUserLogENS">源简化对象</param>
 /// <param name = "objUserLogENT">目标对象</param>
clsUserLogBL.CopyObjFromSimObj = function(objUserLogENS, objUserLogENT) 
{
objUserLogENT.mId = objUserLogENS.mId; //mId
objUserLogENT.UserId = objUserLogENS.UserId; //用户Id
objUserLogENT.LoginTime = objUserLogENS.LoginTime; //登陆时间
objUserLogENT.LoginDate = objUserLogENS.LoginDate; //登陆日期
objUserLogENT.UserIp = objUserLogENS.UserIp; //用户IP
objUserLogENT.ObjectTable = objUserLogENS.ObjectTable; //对象表
objUserLogENT.UsedValue = objUserLogENS.UsedValue; //使用值
objUserLogENT.UpdDate = objUserLogENS.UpdDate; //修改日期
objUserLogENT.Memo = objUserLogENS.Memo; //说明
objUserLogENT._IsDeleted = objUserLogENS._IsDeleted; //是否删除
objUserLogENT.OrderNum = objUserLogENS.OrderNum; //序号
objUserLogENT._DeletedDate = objUserLogENS._DeletedDate; //删除日期
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objUserLogENS">源对象</param>
 /// <param name = "objUserLogENT">目标对象</param>
clsUserLogBL.CopyObjTo = function(objUserLogENS , objUserLogENT ) 
{
objUserLogENT.mId = objUserLogENS.mId; //mId
objUserLogENT.UserId = objUserLogENS.UserId; //用户Id
objUserLogENT.LoginTime = objUserLogENS.LoginTime; //登陆时间
objUserLogENT.LoginDate = objUserLogENS.LoginDate; //登陆日期
objUserLogENT.UserIp = objUserLogENS.UserIp; //用户IP
objUserLogENT.ObjectTable = objUserLogENS.ObjectTable; //对象表
objUserLogENT.UsedValue = objUserLogENS.UsedValue; //使用值
objUserLogENT.UpdDate = objUserLogENS.UpdDate; //修改日期
objUserLogENT.Memo = objUserLogENS.Memo; //说明
objUserLogENT._IsDeleted = objUserLogENS._IsDeleted; //是否删除
objUserLogENT.OrderNum = objUserLogENS.OrderNum; //序号
objUserLogENT._DeletedDate = objUserLogENS._DeletedDate; //删除日期
objUserLogENT.sf_UpdFldSetStr = objUserLogENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objUserLogENS">源对象</param>
 /// <param name = "objUserLogENT">目标对象</param>
clsUserLogBL.CopyObjToSimObj = function(objUserLogENS , objUserLogENT ) 
{
objUserLogENT.mId = objUserLogENS.mId; //mId
objUserLogENT.UserId = objUserLogENS.UserId; //用户Id
objUserLogENT.LoginTime = objUserLogENS.LoginTime; //登陆时间
objUserLogENT.LoginDate = objUserLogENS.LoginDate; //登陆日期
objUserLogENT.UserIp = objUserLogENS.UserIp; //用户IP
objUserLogENT.ObjectTable = objUserLogENS.ObjectTable; //对象表
objUserLogENT.UsedValue = objUserLogENS.UsedValue; //使用值
objUserLogENT.UpdDate = objUserLogENS.UpdDate; //修改日期
objUserLogENT.Memo = objUserLogENS.Memo; //说明
objUserLogENT._IsDeleted = objUserLogENS._IsDeleted; //是否删除
objUserLogENT.OrderNum = objUserLogENS.OrderNum; //序号
objUserLogENT._DeletedDate = objUserLogENS._DeletedDate; //删除日期
objUserLogENT.sf_UpdFldSetStr = objUserLogENS.UpdFldString; //专门用于记录某字段属性是否修改
objUserLogENT.sf_FldComparisonOp = objUserLogENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objUserLogENS">源简化对象</param>
 /// <param name = "objUserLogENT">目标对象</param>
clsUserLogBL.CopyObjFromSimObj4Upd = function(objUserLogENS, objUserLogENT )
 {
   var strsf_UpdFldSetStr = objUserLogENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsUserLogEN.con_mId)  >= 0)
{
objUserLogENT.mId = objUserLogENS.mId; //mId
}
if (sstrFldSet.indexOf(clsUserLogEN.con_UserId)  >= 0)
{
objUserLogENT.UserId = objUserLogENS.UserId; //用户Id
}
if (sstrFldSet.indexOf(clsUserLogEN.con_LoginTime)  >= 0)
{
objUserLogENT.LoginTime = objUserLogENS.LoginTime; //登陆时间
}
if (sstrFldSet.indexOf(clsUserLogEN.con_LoginDate)  >= 0)
{
objUserLogENT.LoginDate = objUserLogENS.LoginDate; //登陆日期
}
if (sstrFldSet.indexOf(clsUserLogEN.con_UserIp)  >= 0)
{
objUserLogENT.UserIp = objUserLogENS.UserIp; //用户IP
}
if (sstrFldSet.indexOf(clsUserLogEN.con_ObjectTable)  >= 0)
{
objUserLogENT.ObjectTable = objUserLogENS.ObjectTable; //对象表
}
if (sstrFldSet.indexOf(clsUserLogEN.con_UsedValue)  >= 0)
{
objUserLogENT.UsedValue = objUserLogENS.UsedValue; //使用值
}
if (sstrFldSet.indexOf(clsUserLogEN.con_UpdDate)  >= 0)
{
objUserLogENT.UpdDate = objUserLogENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsUserLogEN.con_Memo)  >= 0)
{
objUserLogENT.Memo = objUserLogENS.Memo; //说明
}
if (sstrFldSet.indexOf(clsUserLogEN.con__IsDeleted)  >= 0)
{
objUserLogENT._IsDeleted = objUserLogENS._IsDeleted; //是否删除
}
if (sstrFldSet.indexOf(clsUserLogEN.con_OrderNum)  >= 0)
{
objUserLogENT.OrderNum = objUserLogENS.OrderNum; //序号
}
if (sstrFldSet.indexOf(clsUserLogEN.con__DeletedDate)  >= 0)
{
objUserLogENT._DeletedDate = objUserLogENS._DeletedDate; //删除日期
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objUserLogENS">源对象</param>
 /// <param name = "objUserLogENT">目标对象</param>
clsUserLogBL.GetSimObjFromObj = function(objUserLogENS)
{
var objUserLogENT = new clsUserLogEN_Sim_js_1.clsUserLogEN_Sim();
objUserLogENT.mId = objUserLogENS.mId; //mId
objUserLogENT.UserId = objUserLogENS.UserId; //用户Id
objUserLogENT.LoginTime = objUserLogENS.LoginTime; //登陆时间
objUserLogENT.LoginDate = objUserLogENS.LoginDate; //登陆日期
objUserLogENT.UserIp = objUserLogENS.UserIp; //用户IP
objUserLogENT.ObjectTable = objUserLogENS.ObjectTable; //对象表
objUserLogENT.UsedValue = objUserLogENS.UsedValue; //使用值
objUserLogENT.UpdDate = objUserLogENS.UpdDate; //修改日期
objUserLogENT.Memo = objUserLogENS.Memo; //说明
objUserLogENT._IsDeleted = objUserLogENS._IsDeleted; //是否删除
objUserLogENT.OrderNum = objUserLogENS.OrderNum; //序号
objUserLogENT._DeletedDate = objUserLogENS._DeletedDate; //删除日期
objUserLogENT.sf_UpdFldSetStr = objUserLogENS.UpdFldString; //专门用于记录某字段属性是否修改
objUserLogENT.sf_FldComparisonOp = objUserLogENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objUserLogENT;
}
return clsUserLogBL;
}());
exports.clsUserLogBL = clsUserLogBL;
});