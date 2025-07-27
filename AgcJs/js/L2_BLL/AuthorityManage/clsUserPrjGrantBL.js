
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPrjGrantBL
 表名:UserPrjGrant(00050092)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:14
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:权限管理
 模块英文名:AuthorityManage
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
define(["require", "exports", "jquery", "../../L0_Entity/AuthorityManage/clsUserPrjGrantEN.js","../../L0_Entity/AuthorityManage/clsUserPrjGrantEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsUserPrjGrantEN_js_1 = require("../../L0_Entity/AuthorityManage/clsUserPrjGrantEN.js");
var clsUserPrjGrantEN_Sim_js_1 = require("../../L0_Entity/AuthorityManage/clsUserPrjGrantEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// UserPrjGrant(UserPrjGrant)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsUserPrjGrantBL = /** @class */ (function () {
function clsUserPrjGrantBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrUserPrjGrantObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsUserPrjGrantBL.prototype.CheckPropertyNew = function(pobjUserPrjGrantEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjUserPrjGrantEN.UserId 
 || null !== pobjUserPrjGrantEN.UserId && pobjUserPrjGrantEN.UserId.toString()  ===  ""
 || null !== pobjUserPrjGrantEN.UserId && pobjUserPrjGrantEN.UserId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[UserPrjGrant|用户Id]不能为空(NULL)!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null === pobjUserPrjGrantEN.PrjId 
 || null !== pobjUserPrjGrantEN.PrjId && pobjUserPrjGrantEN.PrjId.toString()  ===  ""
 || null !== pobjUserPrjGrantEN.PrjId && pobjUserPrjGrantEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[UserPrjGrant|工程ID]不能为空(NULL)!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null === pobjUserPrjGrantEN.RoleId 
 || null !== pobjUserPrjGrantEN.RoleId && pobjUserPrjGrantEN.RoleId.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[UserPrjGrant|角色ID]不能为空(NULL)!(clsUserPrjGrantBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjUserPrjGrantEN.UserId && GetStrLen(pobjUserPrjGrantEN.UserId) > 18)
{
 throw new Error("(errid:Busi000155)字段[UserPrjGrant(UserPrjGrant)|用户Id(UserId)]的长度不能超过18!值:$(pobjUserPrjGrantEN.UserId)(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.PrjId && GetStrLen(pobjUserPrjGrantEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[UserPrjGrant(UserPrjGrant)|工程ID(PrjId)]的长度不能超过4!值:$(pobjUserPrjGrantEN.PrjId)(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.RoleId && GetStrLen(pobjUserPrjGrantEN.RoleId) > 8)
{
 throw new Error("(errid:Busi000155)字段[UserPrjGrant(UserPrjGrant)|角色ID(RoleId)]的长度不能超过8!值:$(pobjUserPrjGrantEN.RoleId)(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.LastVisitedDate && GetStrLen(pobjUserPrjGrantEN.LastVisitedDate) > 14)
{
 throw new Error("(errid:Busi000155)字段[UserPrjGrant(UserPrjGrant)|最后访问时间(LastVisitedDate)]的长度不能超过14!值:$(pobjUserPrjGrantEN.LastVisitedDate)(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.OptId && GetStrLen(pobjUserPrjGrantEN.OptId) > 18)
{
 throw new Error("(errid:Busi000155)字段[UserPrjGrant(UserPrjGrant)|操作者Id(OptId)]的长度不能超过18!值:$(pobjUserPrjGrantEN.OptId)(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.OptDate && GetStrLen(pobjUserPrjGrantEN.OptDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[UserPrjGrant(UserPrjGrant)|操作日期(OptDate)]的长度不能超过20!值:$(pobjUserPrjGrantEN.OptDate)(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.Memo && GetStrLen(pobjUserPrjGrantEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[UserPrjGrant(UserPrjGrant)|说明(Memo)]的长度不能超过1000!值:$(pobjUserPrjGrantEN.Memo)(clsUserPrjGrantBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjUserPrjGrantEN.mId && undefined !== pobjUserPrjGrantEN.mId && tzDataType.isNumber(pobjUserPrjGrantEN.mId) === false)
{
 throw new Error("(errid:Busi000156)字段[UserPrjGrant(UserPrjGrant)|mId(mId)]的值:[$(pobjUserPrjGrantEN.mId)], 非法，应该为数值型!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.UserId && undefined !== pobjUserPrjGrantEN.UserId && tzDataType.isString(pobjUserPrjGrantEN.UserId) === false)
{
 throw new Error("(errid:Busi000156)字段[UserPrjGrant(UserPrjGrant)|用户Id(UserId)]的值:[$(pobjUserPrjGrantEN.UserId)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.PrjId && undefined !== pobjUserPrjGrantEN.PrjId && tzDataType.isString(pobjUserPrjGrantEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[UserPrjGrant(UserPrjGrant)|工程ID(PrjId)]的值:[$(pobjUserPrjGrantEN.PrjId)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.RoleId && undefined !== pobjUserPrjGrantEN.RoleId && tzDataType.isString(pobjUserPrjGrantEN.RoleId) === false)
{
 throw new Error("(errid:Busi000156)字段[UserPrjGrant(UserPrjGrant)|角色ID(RoleId)]的值:[$(pobjUserPrjGrantEN.RoleId)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.VisitedNum && undefined !== pobjUserPrjGrantEN.VisitedNum && tzDataType.isNumber(pobjUserPrjGrantEN.VisitedNum) === false)
{
 throw new Error("(errid:Busi000156)字段[UserPrjGrant(UserPrjGrant)|访问数(VisitedNum)]的值:[$(pobjUserPrjGrantEN.VisitedNum)], 非法，应该为数值型!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.LastVisitedDate && undefined !== pobjUserPrjGrantEN.LastVisitedDate && tzDataType.isString(pobjUserPrjGrantEN.LastVisitedDate) === false)
{
 throw new Error("(errid:Busi000156)字段[UserPrjGrant(UserPrjGrant)|最后访问时间(LastVisitedDate)]的值:[$(pobjUserPrjGrantEN.LastVisitedDate)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.OptId && undefined !== pobjUserPrjGrantEN.OptId && tzDataType.isString(pobjUserPrjGrantEN.OptId) === false)
{
 throw new Error("(errid:Busi000156)字段[UserPrjGrant(UserPrjGrant)|操作者Id(OptId)]的值:[$(pobjUserPrjGrantEN.OptId)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.OptDate && undefined !== pobjUserPrjGrantEN.OptDate && tzDataType.isString(pobjUserPrjGrantEN.OptDate) === false)
{
 throw new Error("(errid:Busi000156)字段[UserPrjGrant(UserPrjGrant)|操作日期(OptDate)]的值:[$(pobjUserPrjGrantEN.OptDate)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckPropertyNew)");
}
if (null !== pobjUserPrjGrantEN.Memo && undefined !== pobjUserPrjGrantEN.Memo && tzDataType.isString(pobjUserPrjGrantEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[UserPrjGrant(UserPrjGrant)|说明(Memo)]的值:[$(pobjUserPrjGrantEN.Memo)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjUserPrjGrantEN.RoleId != null && GetStrLen(pobjUserPrjGrantEN.RoleId) !=  8)
{
 throw ("(errid:Busi000157)字段[UserPrjGrant|角色ID]作为外键字段,长度应该为8!(clsUserPrjGrantBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjUserPrjGrantEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsUserPrjGrantBL.prototype.CheckProperty4Update  = function(pobjUserPrjGrantEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjUserPrjGrantEN.UserId && GetStrLen(pobjUserPrjGrantEN.UserId) > 18)
{
 throw new Error("(errid:Busi000158)字段[UserPrjGrant(UserPrjGrant)|用户Id(UserId)]的长度不能超过18!值:$(pobjUserPrjGrantEN.UserId)(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.PrjId && GetStrLen(pobjUserPrjGrantEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[UserPrjGrant(UserPrjGrant)|工程ID(PrjId)]的长度不能超过4!值:$(pobjUserPrjGrantEN.PrjId)(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.RoleId && GetStrLen(pobjUserPrjGrantEN.RoleId) > 8)
{
 throw new Error("(errid:Busi000158)字段[UserPrjGrant(UserPrjGrant)|角色ID(RoleId)]的长度不能超过8!值:$(pobjUserPrjGrantEN.RoleId)(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.LastVisitedDate && GetStrLen(pobjUserPrjGrantEN.LastVisitedDate) > 14)
{
 throw new Error("(errid:Busi000158)字段[UserPrjGrant(UserPrjGrant)|最后访问时间(LastVisitedDate)]的长度不能超过14!值:$(pobjUserPrjGrantEN.LastVisitedDate)(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.OptId && GetStrLen(pobjUserPrjGrantEN.OptId) > 18)
{
 throw new Error("(errid:Busi000158)字段[UserPrjGrant(UserPrjGrant)|操作者Id(OptId)]的长度不能超过18!值:$(pobjUserPrjGrantEN.OptId)(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.OptDate && GetStrLen(pobjUserPrjGrantEN.OptDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[UserPrjGrant(UserPrjGrant)|操作日期(OptDate)]的长度不能超过20!值:$(pobjUserPrjGrantEN.OptDate)(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.Memo && GetStrLen(pobjUserPrjGrantEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[UserPrjGrant(UserPrjGrant)|说明(Memo)]的长度不能超过1000!值:$(pobjUserPrjGrantEN.Memo)(clsUserPrjGrantBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjUserPrjGrantEN.mId && undefined !== pobjUserPrjGrantEN.mId && tzDataType.isNumber(pobjUserPrjGrantEN.mId) === false)
{
 throw new Error("(errid:Busi000159)字段[UserPrjGrant(UserPrjGrant)|mId(mId)]的值:[$(pobjUserPrjGrantEN.mId)], 非法，应该为数值型!(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.UserId && undefined !== pobjUserPrjGrantEN.UserId && tzDataType.isString(pobjUserPrjGrantEN.UserId) === false)
{
 throw new Error("(errid:Busi000159)字段[UserPrjGrant(UserPrjGrant)|用户Id(UserId)]的值:[$(pobjUserPrjGrantEN.UserId)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.PrjId && undefined !== pobjUserPrjGrantEN.PrjId && tzDataType.isString(pobjUserPrjGrantEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[UserPrjGrant(UserPrjGrant)|工程ID(PrjId)]的值:[$(pobjUserPrjGrantEN.PrjId)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.RoleId && undefined !== pobjUserPrjGrantEN.RoleId && tzDataType.isString(pobjUserPrjGrantEN.RoleId) === false)
{
 throw new Error("(errid:Busi000159)字段[UserPrjGrant(UserPrjGrant)|角色ID(RoleId)]的值:[$(pobjUserPrjGrantEN.RoleId)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.VisitedNum && undefined !== pobjUserPrjGrantEN.VisitedNum && tzDataType.isNumber(pobjUserPrjGrantEN.VisitedNum) === false)
{
 throw new Error("(errid:Busi000159)字段[UserPrjGrant(UserPrjGrant)|访问数(VisitedNum)]的值:[$(pobjUserPrjGrantEN.VisitedNum)], 非法，应该为数值型!(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.LastVisitedDate && undefined !== pobjUserPrjGrantEN.LastVisitedDate && tzDataType.isString(pobjUserPrjGrantEN.LastVisitedDate) === false)
{
 throw new Error("(errid:Busi000159)字段[UserPrjGrant(UserPrjGrant)|最后访问时间(LastVisitedDate)]的值:[$(pobjUserPrjGrantEN.LastVisitedDate)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.OptId && undefined !== pobjUserPrjGrantEN.OptId && tzDataType.isString(pobjUserPrjGrantEN.OptId) === false)
{
 throw new Error("(errid:Busi000159)字段[UserPrjGrant(UserPrjGrant)|操作者Id(OptId)]的值:[$(pobjUserPrjGrantEN.OptId)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.OptDate && undefined !== pobjUserPrjGrantEN.OptDate && tzDataType.isString(pobjUserPrjGrantEN.OptDate) === false)
{
 throw new Error("(errid:Busi000159)字段[UserPrjGrant(UserPrjGrant)|操作日期(OptDate)]的值:[$(pobjUserPrjGrantEN.OptDate)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckProperty4Update)");
}
if (null !== pobjUserPrjGrantEN.Memo && undefined !== pobjUserPrjGrantEN.Memo && tzDataType.isString(pobjUserPrjGrantEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[UserPrjGrant(UserPrjGrant)|说明(Memo)]的值:[$(pobjUserPrjGrantEN.Memo)], 非法，应该为字符型!(clsUserPrjGrantBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjUserPrjGrantEN.mId 
 || null !== pobjUserPrjGrantEN.mId && pobjUserPrjGrantEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Busi000160)字段[UserPrjGrant|mId]不能为空(NULL)!(clsUserPrjGrantBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjUserPrjGrantEN.RoleId != null && GetStrLen(pobjUserPrjGrantEN.RoleId) !=  8)
{
 throw ("(errid:Busi000161)字段[UserPrjGrant|角色ID]作为外键字段,长度应该为8!(clsUserPrjGrantBL:CheckPropertyNew)");
}

 pobjUserPrjGrantEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024914
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsUserPrjGrantBL.GetJSONStrByObj  = function(pobjUserPrjGrantEN)
{
pobjUserPrjGrantEN.sf_UpdFldSetStr = pobjUserPrjGrantEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjUserPrjGrantEN);
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
 /// 日期:20200501024914
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsUserPrjGrantBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrUserPrjGrantObjLst = new Array();
if (strJSON === "")
{
return arrUserPrjGrantObjLst;
}
try
{
arrUserPrjGrantObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrUserPrjGrantObjLst;
}
return arrUserPrjGrantObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024914
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsUserPrjGrantBL.GetObjByJSONStr  = function(strJSON)
{
var pobjUserPrjGrantEN = new clsUserPrjGrantEN();
if (strJSON === "")
{
return pobjUserPrjGrantEN;
}
try
{
pobjUserPrjGrantEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjUserPrjGrantEN;
}
return pobjUserPrjGrantEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objUserPrjGrantENS">源简化对象</param>
 /// <param name = "objUserPrjGrantENT">目标对象</param>
clsUserPrjGrantBL.CopyObjFromSimObj = function(objUserPrjGrantENS, objUserPrjGrantENT) 
{
objUserPrjGrantENT.mId = objUserPrjGrantENS.mId; //mId
objUserPrjGrantENT.UserId = objUserPrjGrantENS.UserId; //用户Id
objUserPrjGrantENT.PrjId = objUserPrjGrantENS.PrjId; //工程ID
objUserPrjGrantENT.RoleId = objUserPrjGrantENS.RoleId; //角色ID
objUserPrjGrantENT.VisitedNum = objUserPrjGrantENS.VisitedNum; //访问数
objUserPrjGrantENT.LastVisitedDate = objUserPrjGrantENS.LastVisitedDate; //最后访问时间
objUserPrjGrantENT.OptId = objUserPrjGrantENS.OptId; //操作者Id
objUserPrjGrantENT.OptDate = objUserPrjGrantENS.OptDate; //操作日期
objUserPrjGrantENT.Memo = objUserPrjGrantENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objUserPrjGrantENS">源对象</param>
 /// <param name = "objUserPrjGrantENT">目标对象</param>
clsUserPrjGrantBL.CopyObjTo = function(objUserPrjGrantENS , objUserPrjGrantENT ) 
{
objUserPrjGrantENT.mId = objUserPrjGrantENS.mId; //mId
objUserPrjGrantENT.UserId = objUserPrjGrantENS.UserId; //用户Id
objUserPrjGrantENT.PrjId = objUserPrjGrantENS.PrjId; //工程ID
objUserPrjGrantENT.RoleId = objUserPrjGrantENS.RoleId; //角色ID
objUserPrjGrantENT.VisitedNum = objUserPrjGrantENS.VisitedNum; //访问数
objUserPrjGrantENT.LastVisitedDate = objUserPrjGrantENS.LastVisitedDate; //最后访问时间
objUserPrjGrantENT.OptId = objUserPrjGrantENS.OptId; //操作者Id
objUserPrjGrantENT.OptDate = objUserPrjGrantENS.OptDate; //操作日期
objUserPrjGrantENT.Memo = objUserPrjGrantENS.Memo; //说明
objUserPrjGrantENT.sf_UpdFldSetStr = objUserPrjGrantENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objUserPrjGrantENS">源对象</param>
 /// <param name = "objUserPrjGrantENT">目标对象</param>
clsUserPrjGrantBL.CopyObjToSimObj = function(objUserPrjGrantENS , objUserPrjGrantENT ) 
{
objUserPrjGrantENT.mId = objUserPrjGrantENS.mId; //mId
objUserPrjGrantENT.UserId = objUserPrjGrantENS.UserId; //用户Id
objUserPrjGrantENT.PrjId = objUserPrjGrantENS.PrjId; //工程ID
objUserPrjGrantENT.RoleId = objUserPrjGrantENS.RoleId; //角色ID
objUserPrjGrantENT.VisitedNum = objUserPrjGrantENS.VisitedNum; //访问数
objUserPrjGrantENT.LastVisitedDate = objUserPrjGrantENS.LastVisitedDate; //最后访问时间
objUserPrjGrantENT.OptId = objUserPrjGrantENS.OptId; //操作者Id
objUserPrjGrantENT.OptDate = objUserPrjGrantENS.OptDate; //操作日期
objUserPrjGrantENT.Memo = objUserPrjGrantENS.Memo; //说明
objUserPrjGrantENT.sf_UpdFldSetStr = objUserPrjGrantENS.UpdFldString; //专门用于记录某字段属性是否修改
objUserPrjGrantENT.sf_FldComparisonOp = objUserPrjGrantENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objUserPrjGrantENS">源简化对象</param>
 /// <param name = "objUserPrjGrantENT">目标对象</param>
clsUserPrjGrantBL.CopyObjFromSimObj4Upd = function(objUserPrjGrantENS, objUserPrjGrantENT )
 {
   var strsf_UpdFldSetStr = objUserPrjGrantENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsUserPrjGrantEN.con_mId)  >= 0)
{
objUserPrjGrantENT.mId = objUserPrjGrantENS.mId; //mId
}
if (sstrFldSet.indexOf(clsUserPrjGrantEN.con_UserId)  >= 0)
{
objUserPrjGrantENT.UserId = objUserPrjGrantENS.UserId; //用户Id
}
if (sstrFldSet.indexOf(clsUserPrjGrantEN.con_PrjId)  >= 0)
{
objUserPrjGrantENT.PrjId = objUserPrjGrantENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsUserPrjGrantEN.con_RoleId)  >= 0)
{
objUserPrjGrantENT.RoleId = objUserPrjGrantENS.RoleId; //角色ID
}
if (sstrFldSet.indexOf(clsUserPrjGrantEN.con_VisitedNum)  >= 0)
{
objUserPrjGrantENT.VisitedNum = objUserPrjGrantENS.VisitedNum; //访问数
}
if (sstrFldSet.indexOf(clsUserPrjGrantEN.con_LastVisitedDate)  >= 0)
{
objUserPrjGrantENT.LastVisitedDate = objUserPrjGrantENS.LastVisitedDate; //最后访问时间
}
if (sstrFldSet.indexOf(clsUserPrjGrantEN.con_OptId)  >= 0)
{
objUserPrjGrantENT.OptId = objUserPrjGrantENS.OptId; //操作者Id
}
if (sstrFldSet.indexOf(clsUserPrjGrantEN.con_OptDate)  >= 0)
{
objUserPrjGrantENT.OptDate = objUserPrjGrantENS.OptDate; //操作日期
}
if (sstrFldSet.indexOf(clsUserPrjGrantEN.con_Memo)  >= 0)
{
objUserPrjGrantENT.Memo = objUserPrjGrantENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objUserPrjGrantENS">源对象</param>
 /// <param name = "objUserPrjGrantENT">目标对象</param>
clsUserPrjGrantBL.GetSimObjFromObj = function(objUserPrjGrantENS)
{
var objUserPrjGrantENT = new clsUserPrjGrantEN_Sim_js_1.clsUserPrjGrantEN_Sim();
objUserPrjGrantENT.mId = objUserPrjGrantENS.mId; //mId
objUserPrjGrantENT.UserId = objUserPrjGrantENS.UserId; //用户Id
objUserPrjGrantENT.PrjId = objUserPrjGrantENS.PrjId; //工程ID
objUserPrjGrantENT.RoleId = objUserPrjGrantENS.RoleId; //角色ID
objUserPrjGrantENT.VisitedNum = objUserPrjGrantENS.VisitedNum; //访问数
objUserPrjGrantENT.LastVisitedDate = objUserPrjGrantENS.LastVisitedDate; //最后访问时间
objUserPrjGrantENT.OptId = objUserPrjGrantENS.OptId; //操作者Id
objUserPrjGrantENT.OptDate = objUserPrjGrantENS.OptDate; //操作日期
objUserPrjGrantENT.Memo = objUserPrjGrantENS.Memo; //说明
objUserPrjGrantENT.sf_UpdFldSetStr = objUserPrjGrantENS.UpdFldString; //专门用于记录某字段属性是否修改
objUserPrjGrantENT.sf_FldComparisonOp = objUserPrjGrantENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objUserPrjGrantENT;
}
return clsUserPrjGrantBL;
}());
exports.clsUserPrjGrantBL = clsUserPrjGrantBL;
});