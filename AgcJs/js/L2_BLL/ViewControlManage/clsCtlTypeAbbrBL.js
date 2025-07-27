
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCtlTypeAbbrBL
 表名:CtlTypeAbbr(00050058)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:29
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面控件管理
 模块英文名:ViewControlManage
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
define(["require", "exports", "jquery", "../../L0_Entity/ViewControlManage/clsCtlTypeAbbrEN.js","../../L0_Entity/ViewControlManage/clsCtlTypeAbbrEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsCtlTypeAbbrEN_js_1 = require("../../L0_Entity/ViewControlManage/clsCtlTypeAbbrEN.js");
var clsCtlTypeAbbrEN_Sim_js_1 = require("../../L0_Entity/ViewControlManage/clsCtlTypeAbbrEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 控件类型缩写(CtlTypeAbbr)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsCtlTypeAbbrBL = /** @class */ (function () {
function clsCtlTypeAbbrBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrCtlTypeAbbrObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsCtlTypeAbbrBL.prototype.CheckPropertyNew = function(pobjCtlTypeAbbrEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjCtlTypeAbbrEN.CtlTypeName 
 || null !== pobjCtlTypeAbbrEN.CtlTypeName && pobjCtlTypeAbbrEN.CtlTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[控件类型缩写|控件类型名]不能为空(NULL)!(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null === pobjCtlTypeAbbrEN.CtlCnName 
 || null !== pobjCtlTypeAbbrEN.CtlCnName && pobjCtlTypeAbbrEN.CtlCnName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[控件类型缩写|控件类型中文名]不能为空(NULL)!(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null === pobjCtlTypeAbbrEN.CtlTypeAbbr 
 || null !== pobjCtlTypeAbbrEN.CtlTypeAbbr && pobjCtlTypeAbbrEN.CtlTypeAbbr.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[控件类型缩写|控件类型缩写]不能为空(NULL)!(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjCtlTypeAbbrEN.CtlTypeId && GetStrLen(pobjCtlTypeAbbrEN.CtlTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[控件类型缩写(CtlTypeAbbr)|控件类型号(CtlTypeId)]的长度不能超过2!值:$(pobjCtlTypeAbbrEN.CtlTypeId)(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeName && GetStrLen(pobjCtlTypeAbbrEN.CtlTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[控件类型缩写(CtlTypeAbbr)|控件类型名(CtlTypeName)]的长度不能超过30!值:$(pobjCtlTypeAbbrEN.CtlTypeName)(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeENName && GetStrLen(pobjCtlTypeAbbrEN.CtlTypeENName) > 50)
{
 throw new Error("(errid:Busi000155)字段[控件类型缩写(CtlTypeAbbr)|控件类型英文名(CtlTypeENName)]的长度不能超过50!值:$(pobjCtlTypeAbbrEN.CtlTypeENName)(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.CtlCnName && GetStrLen(pobjCtlTypeAbbrEN.CtlCnName) > 50)
{
 throw new Error("(errid:Busi000155)字段[控件类型缩写(CtlTypeAbbr)|控件类型中文名(CtlCnName)]的长度不能超过50!值:$(pobjCtlTypeAbbrEN.CtlCnName)(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeAbbr && GetStrLen(pobjCtlTypeAbbrEN.CtlTypeAbbr) > 5)
{
 throw new Error("(errid:Busi000155)字段[控件类型缩写(CtlTypeAbbr)|控件类型缩写(CtlTypeAbbr)]的长度不能超过5!值:$(pobjCtlTypeAbbrEN.CtlTypeAbbr)(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.Memo && GetStrLen(pobjCtlTypeAbbrEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[控件类型缩写(CtlTypeAbbr)|说明(Memo)]的长度不能超过1000!值:$(pobjCtlTypeAbbrEN.Memo)(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjCtlTypeAbbrEN.CtlTypeId && undefined !== pobjCtlTypeAbbrEN.CtlTypeId && tzDataType.isString(pobjCtlTypeAbbrEN.CtlTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[控件类型缩写(CtlTypeAbbr)|控件类型号(CtlTypeId)]的值:[$(pobjCtlTypeAbbrEN.CtlTypeId)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeName && undefined !== pobjCtlTypeAbbrEN.CtlTypeName && tzDataType.isString(pobjCtlTypeAbbrEN.CtlTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[控件类型缩写(CtlTypeAbbr)|控件类型名(CtlTypeName)]的值:[$(pobjCtlTypeAbbrEN.CtlTypeName)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeENName && undefined !== pobjCtlTypeAbbrEN.CtlTypeENName && tzDataType.isString(pobjCtlTypeAbbrEN.CtlTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[控件类型缩写(CtlTypeAbbr)|控件类型英文名(CtlTypeENName)]的值:[$(pobjCtlTypeAbbrEN.CtlTypeENName)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.CtlCnName && undefined !== pobjCtlTypeAbbrEN.CtlCnName && tzDataType.isString(pobjCtlTypeAbbrEN.CtlCnName) === false)
{
 throw new Error("(errid:Busi000156)字段[控件类型缩写(CtlTypeAbbr)|控件类型中文名(CtlCnName)]的值:[$(pobjCtlTypeAbbrEN.CtlCnName)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeAbbr && undefined !== pobjCtlTypeAbbrEN.CtlTypeAbbr && tzDataType.isString(pobjCtlTypeAbbrEN.CtlTypeAbbr) === false)
{
 throw new Error("(errid:Busi000156)字段[控件类型缩写(CtlTypeAbbr)|控件类型缩写(CtlTypeAbbr)]的值:[$(pobjCtlTypeAbbrEN.CtlTypeAbbr)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjCtlTypeAbbrEN.Memo && undefined !== pobjCtlTypeAbbrEN.Memo && tzDataType.isString(pobjCtlTypeAbbrEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[控件类型缩写(CtlTypeAbbr)|说明(Memo)]的值:[$(pobjCtlTypeAbbrEN.Memo)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjCtlTypeAbbrEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsCtlTypeAbbrBL.prototype.CheckProperty4Update  = function(pobjCtlTypeAbbrEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjCtlTypeAbbrEN.CtlTypeId && GetStrLen(pobjCtlTypeAbbrEN.CtlTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[控件类型缩写(CtlTypeAbbr)|控件类型号(CtlTypeId)]的长度不能超过2!值:$(pobjCtlTypeAbbrEN.CtlTypeId)(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeName && GetStrLen(pobjCtlTypeAbbrEN.CtlTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[控件类型缩写(CtlTypeAbbr)|控件类型名(CtlTypeName)]的长度不能超过30!值:$(pobjCtlTypeAbbrEN.CtlTypeName)(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeENName && GetStrLen(pobjCtlTypeAbbrEN.CtlTypeENName) > 50)
{
 throw new Error("(errid:Busi000158)字段[控件类型缩写(CtlTypeAbbr)|控件类型英文名(CtlTypeENName)]的长度不能超过50!值:$(pobjCtlTypeAbbrEN.CtlTypeENName)(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.CtlCnName && GetStrLen(pobjCtlTypeAbbrEN.CtlCnName) > 50)
{
 throw new Error("(errid:Busi000158)字段[控件类型缩写(CtlTypeAbbr)|控件类型中文名(CtlCnName)]的长度不能超过50!值:$(pobjCtlTypeAbbrEN.CtlCnName)(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeAbbr && GetStrLen(pobjCtlTypeAbbrEN.CtlTypeAbbr) > 5)
{
 throw new Error("(errid:Busi000158)字段[控件类型缩写(CtlTypeAbbr)|控件类型缩写(CtlTypeAbbr)]的长度不能超过5!值:$(pobjCtlTypeAbbrEN.CtlTypeAbbr)(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.Memo && GetStrLen(pobjCtlTypeAbbrEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[控件类型缩写(CtlTypeAbbr)|说明(Memo)]的长度不能超过1000!值:$(pobjCtlTypeAbbrEN.Memo)(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjCtlTypeAbbrEN.CtlTypeId && undefined !== pobjCtlTypeAbbrEN.CtlTypeId && tzDataType.isString(pobjCtlTypeAbbrEN.CtlTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[控件类型缩写(CtlTypeAbbr)|控件类型号(CtlTypeId)]的值:[$(pobjCtlTypeAbbrEN.CtlTypeId)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeName && undefined !== pobjCtlTypeAbbrEN.CtlTypeName && tzDataType.isString(pobjCtlTypeAbbrEN.CtlTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[控件类型缩写(CtlTypeAbbr)|控件类型名(CtlTypeName)]的值:[$(pobjCtlTypeAbbrEN.CtlTypeName)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeENName && undefined !== pobjCtlTypeAbbrEN.CtlTypeENName && tzDataType.isString(pobjCtlTypeAbbrEN.CtlTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[控件类型缩写(CtlTypeAbbr)|控件类型英文名(CtlTypeENName)]的值:[$(pobjCtlTypeAbbrEN.CtlTypeENName)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.CtlCnName && undefined !== pobjCtlTypeAbbrEN.CtlCnName && tzDataType.isString(pobjCtlTypeAbbrEN.CtlCnName) === false)
{
 throw new Error("(errid:Busi000159)字段[控件类型缩写(CtlTypeAbbr)|控件类型中文名(CtlCnName)]的值:[$(pobjCtlTypeAbbrEN.CtlCnName)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.CtlTypeAbbr && undefined !== pobjCtlTypeAbbrEN.CtlTypeAbbr && tzDataType.isString(pobjCtlTypeAbbrEN.CtlTypeAbbr) === false)
{
 throw new Error("(errid:Busi000159)字段[控件类型缩写(CtlTypeAbbr)|控件类型缩写(CtlTypeAbbr)]的值:[$(pobjCtlTypeAbbrEN.CtlTypeAbbr)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjCtlTypeAbbrEN.Memo && undefined !== pobjCtlTypeAbbrEN.Memo && tzDataType.isString(pobjCtlTypeAbbrEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[控件类型缩写(CtlTypeAbbr)|说明(Memo)]的值:[$(pobjCtlTypeAbbrEN.Memo)], 非法，应该为字符型!(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjCtlTypeAbbrEN.CtlTypeId 
 || null !== pobjCtlTypeAbbrEN.CtlTypeId && pobjCtlTypeAbbrEN.CtlTypeId.toString()  ===  ""
 || null !== pobjCtlTypeAbbrEN.CtlTypeId && pobjCtlTypeAbbrEN.CtlTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[控件类型缩写|控件类型号]不能为空(NULL)!(clsCtlTypeAbbrBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjCtlTypeAbbrEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024929
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsCtlTypeAbbrBL.GetJSONStrByObj  = function(pobjCtlTypeAbbrEN)
{
pobjCtlTypeAbbrEN.sf_UpdFldSetStr = pobjCtlTypeAbbrEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjCtlTypeAbbrEN);
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
 /// 日期:20200501024929
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsCtlTypeAbbrBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrCtlTypeAbbrObjLst = new Array();
if (strJSON === "")
{
return arrCtlTypeAbbrObjLst;
}
try
{
arrCtlTypeAbbrObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrCtlTypeAbbrObjLst;
}
return arrCtlTypeAbbrObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024929
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsCtlTypeAbbrBL.GetObjByJSONStr  = function(strJSON)
{
var pobjCtlTypeAbbrEN = new clsCtlTypeAbbrEN();
if (strJSON === "")
{
return pobjCtlTypeAbbrEN;
}
try
{
pobjCtlTypeAbbrEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjCtlTypeAbbrEN;
}
return pobjCtlTypeAbbrEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objCtlTypeAbbrENS">源简化对象</param>
 /// <param name = "objCtlTypeAbbrENT">目标对象</param>
clsCtlTypeAbbrBL.CopyObjFromSimObj = function(objCtlTypeAbbrENS, objCtlTypeAbbrENT) 
{
objCtlTypeAbbrENT.CtlTypeId = objCtlTypeAbbrENS.CtlTypeId; //控件类型号
objCtlTypeAbbrENT.CtlTypeName = objCtlTypeAbbrENS.CtlTypeName; //控件类型名
objCtlTypeAbbrENT.CtlTypeENName = objCtlTypeAbbrENS.CtlTypeENName; //控件类型英文名
objCtlTypeAbbrENT.CtlCnName = objCtlTypeAbbrENS.CtlCnName; //控件类型中文名
objCtlTypeAbbrENT.CtlTypeAbbr = objCtlTypeAbbrENS.CtlTypeAbbr; //控件类型缩写
objCtlTypeAbbrENT.Memo = objCtlTypeAbbrENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objCtlTypeAbbrENS">源对象</param>
 /// <param name = "objCtlTypeAbbrENT">目标对象</param>
clsCtlTypeAbbrBL.CopyObjTo = function(objCtlTypeAbbrENS , objCtlTypeAbbrENT ) 
{
objCtlTypeAbbrENT.CtlTypeId = objCtlTypeAbbrENS.CtlTypeId; //控件类型号
objCtlTypeAbbrENT.CtlTypeName = objCtlTypeAbbrENS.CtlTypeName; //控件类型名
objCtlTypeAbbrENT.CtlTypeENName = objCtlTypeAbbrENS.CtlTypeENName; //控件类型英文名
objCtlTypeAbbrENT.CtlCnName = objCtlTypeAbbrENS.CtlCnName; //控件类型中文名
objCtlTypeAbbrENT.CtlTypeAbbr = objCtlTypeAbbrENS.CtlTypeAbbr; //控件类型缩写
objCtlTypeAbbrENT.Memo = objCtlTypeAbbrENS.Memo; //说明
objCtlTypeAbbrENT.sf_UpdFldSetStr = objCtlTypeAbbrENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objCtlTypeAbbrENS">源对象</param>
 /// <param name = "objCtlTypeAbbrENT">目标对象</param>
clsCtlTypeAbbrBL.CopyObjToSimObj = function(objCtlTypeAbbrENS , objCtlTypeAbbrENT ) 
{
objCtlTypeAbbrENT.CtlTypeId = objCtlTypeAbbrENS.CtlTypeId; //控件类型号
objCtlTypeAbbrENT.CtlTypeName = objCtlTypeAbbrENS.CtlTypeName; //控件类型名
objCtlTypeAbbrENT.CtlTypeENName = objCtlTypeAbbrENS.CtlTypeENName; //控件类型英文名
objCtlTypeAbbrENT.CtlCnName = objCtlTypeAbbrENS.CtlCnName; //控件类型中文名
objCtlTypeAbbrENT.CtlTypeAbbr = objCtlTypeAbbrENS.CtlTypeAbbr; //控件类型缩写
objCtlTypeAbbrENT.Memo = objCtlTypeAbbrENS.Memo; //说明
objCtlTypeAbbrENT.sf_UpdFldSetStr = objCtlTypeAbbrENS.UpdFldString; //专门用于记录某字段属性是否修改
objCtlTypeAbbrENT.sf_FldComparisonOp = objCtlTypeAbbrENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objCtlTypeAbbrENS">源简化对象</param>
 /// <param name = "objCtlTypeAbbrENT">目标对象</param>
clsCtlTypeAbbrBL.CopyObjFromSimObj4Upd = function(objCtlTypeAbbrENS, objCtlTypeAbbrENT )
 {
   var strsf_UpdFldSetStr = objCtlTypeAbbrENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsCtlTypeAbbrEN.con_CtlTypeId)  >= 0)
{
objCtlTypeAbbrENT.CtlTypeId = objCtlTypeAbbrENS.CtlTypeId; //控件类型号
}
if (sstrFldSet.indexOf(clsCtlTypeAbbrEN.con_CtlTypeName)  >= 0)
{
objCtlTypeAbbrENT.CtlTypeName = objCtlTypeAbbrENS.CtlTypeName; //控件类型名
}
if (sstrFldSet.indexOf(clsCtlTypeAbbrEN.con_CtlTypeENName)  >= 0)
{
objCtlTypeAbbrENT.CtlTypeENName = objCtlTypeAbbrENS.CtlTypeENName; //控件类型英文名
}
if (sstrFldSet.indexOf(clsCtlTypeAbbrEN.con_CtlCnName)  >= 0)
{
objCtlTypeAbbrENT.CtlCnName = objCtlTypeAbbrENS.CtlCnName; //控件类型中文名
}
if (sstrFldSet.indexOf(clsCtlTypeAbbrEN.con_CtlTypeAbbr)  >= 0)
{
objCtlTypeAbbrENT.CtlTypeAbbr = objCtlTypeAbbrENS.CtlTypeAbbr; //控件类型缩写
}
if (sstrFldSet.indexOf(clsCtlTypeAbbrEN.con_Memo)  >= 0)
{
objCtlTypeAbbrENT.Memo = objCtlTypeAbbrENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objCtlTypeAbbrENS">源对象</param>
 /// <param name = "objCtlTypeAbbrENT">目标对象</param>
clsCtlTypeAbbrBL.GetSimObjFromObj = function(objCtlTypeAbbrENS)
{
var objCtlTypeAbbrENT = new clsCtlTypeAbbrEN_Sim_js_1.clsCtlTypeAbbrEN_Sim();
objCtlTypeAbbrENT.CtlTypeId = objCtlTypeAbbrENS.CtlTypeId; //控件类型号
objCtlTypeAbbrENT.CtlTypeName = objCtlTypeAbbrENS.CtlTypeName; //控件类型名
objCtlTypeAbbrENT.CtlTypeENName = objCtlTypeAbbrENS.CtlTypeENName; //控件类型英文名
objCtlTypeAbbrENT.CtlCnName = objCtlTypeAbbrENS.CtlCnName; //控件类型中文名
objCtlTypeAbbrENT.CtlTypeAbbr = objCtlTypeAbbrENS.CtlTypeAbbr; //控件类型缩写
objCtlTypeAbbrENT.Memo = objCtlTypeAbbrENS.Memo; //说明
objCtlTypeAbbrENT.sf_UpdFldSetStr = objCtlTypeAbbrENS.UpdFldString; //专门用于记录某字段属性是否修改
objCtlTypeAbbrENT.sf_FldComparisonOp = objCtlTypeAbbrENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objCtlTypeAbbrENT;
}
return clsCtlTypeAbbrBL;
}());
exports.clsCtlTypeAbbrBL = clsCtlTypeAbbrBL;
});