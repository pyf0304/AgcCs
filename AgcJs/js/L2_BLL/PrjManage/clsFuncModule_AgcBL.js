
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncModule_AgcBL
 表名:FuncModule_Agc(00050015)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:05:54
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:工程管理
 模块英文名:PrjManage
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjManage/clsFuncModule_AgcEN.js","../../L0_Entity/PrjManage/clsFuncModule_AgcEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsFuncModule_AgcEN_js_1 = require("../../L0_Entity/PrjManage/clsFuncModule_AgcEN.js");
var clsFuncModule_AgcEN_Sim_js_1 = require("../../L0_Entity/PrjManage/clsFuncModule_AgcEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 功能模块_Agc(FuncModule_Agc)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsFuncModule_AgcBL = /** @class */ (function () {
function clsFuncModule_AgcBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrFuncModule_AgcObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsFuncModule_AgcBL.prototype.CheckPropertyNew = function(pobjFuncModule_AgcEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjFuncModule_AgcEN.FuncModuleName 
 || null !== pobjFuncModule_AgcEN.FuncModuleName && pobjFuncModule_AgcEN.FuncModuleName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[功能模块_Agc|功能模块名称]不能为空(NULL)!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null === pobjFuncModule_AgcEN.PrjId 
 || null !== pobjFuncModule_AgcEN.PrjId && pobjFuncModule_AgcEN.PrjId.toString()  ===  ""
 || null !== pobjFuncModule_AgcEN.PrjId && pobjFuncModule_AgcEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[功能模块_Agc|工程ID]不能为空(NULL)!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null === pobjFuncModule_AgcEN.OrderNum 
 || null !== pobjFuncModule_AgcEN.OrderNum && pobjFuncModule_AgcEN.OrderNum.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[功能模块_Agc|序号]不能为空(NULL)!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null === pobjFuncModule_AgcEN.UseStateId 
 || null !== pobjFuncModule_AgcEN.UseStateId && pobjFuncModule_AgcEN.UseStateId.toString()  ===  ""
 || null !== pobjFuncModule_AgcEN.UseStateId && pobjFuncModule_AgcEN.UseStateId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[功能模块_Agc|使用状态Id]不能为空(NULL)!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjFuncModule_AgcEN.FuncModuleAgcId && GetStrLen(pobjFuncModule_AgcEN.FuncModuleAgcId) > 8)
{
 throw new Error("(errid:Busi000155)字段[功能模块_Agc(FuncModule_Agc)|功能模块Id(FuncModuleAgcId)]的长度不能超过8!值:$(pobjFuncModule_AgcEN.FuncModuleAgcId)(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleName && GetStrLen(pobjFuncModule_AgcEN.FuncModuleName) > 30)
{
 throw new Error("(errid:Busi000155)字段[功能模块_Agc(FuncModule_Agc)|功能模块名称(FuncModuleName)]的长度不能超过30!值:$(pobjFuncModule_AgcEN.FuncModuleName)(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleEnName && GetStrLen(pobjFuncModule_AgcEN.FuncModuleEnName) > 30)
{
 throw new Error("(errid:Busi000155)字段[功能模块_Agc(FuncModule_Agc)|功能模块英文名称(FuncModuleEnName)]的长度不能超过30!值:$(pobjFuncModule_AgcEN.FuncModuleEnName)(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleName_Sim && GetStrLen(pobjFuncModule_AgcEN.FuncModuleName_Sim) > 30)
{
 throw new Error("(errid:Busi000155)字段[功能模块_Agc(FuncModule_Agc)|功能模块简称(FuncModuleName_Sim)]的长度不能超过30!值:$(pobjFuncModule_AgcEN.FuncModuleName_Sim)(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.PrjId && GetStrLen(pobjFuncModule_AgcEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[功能模块_Agc(FuncModule_Agc)|工程ID(PrjId)]的长度不能超过4!值:$(pobjFuncModule_AgcEN.PrjId)(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.UseStateId && GetStrLen(pobjFuncModule_AgcEN.UseStateId) > 4)
{
 throw new Error("(errid:Busi000155)字段[功能模块_Agc(FuncModule_Agc)|使用状态Id(UseStateId)]的长度不能超过4!值:$(pobjFuncModule_AgcEN.UseStateId)(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.UpdUser && GetStrLen(pobjFuncModule_AgcEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[功能模块_Agc(FuncModule_Agc)|修改者(UpdUser)]的长度不能超过20!值:$(pobjFuncModule_AgcEN.UpdUser)(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.UpdDate && GetStrLen(pobjFuncModule_AgcEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[功能模块_Agc(FuncModule_Agc)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjFuncModule_AgcEN.UpdDate)(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.Memo && GetStrLen(pobjFuncModule_AgcEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[功能模块_Agc(FuncModule_Agc)|说明(Memo)]的长度不能超过1000!值:$(pobjFuncModule_AgcEN.Memo)(clsFuncModule_AgcBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjFuncModule_AgcEN.FuncModuleAgcId && undefined !== pobjFuncModule_AgcEN.FuncModuleAgcId && tzDataType.isString(pobjFuncModule_AgcEN.FuncModuleAgcId) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|功能模块Id(FuncModuleAgcId)]的值:[$(pobjFuncModule_AgcEN.FuncModuleAgcId)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleName && undefined !== pobjFuncModule_AgcEN.FuncModuleName && tzDataType.isString(pobjFuncModule_AgcEN.FuncModuleName) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|功能模块名称(FuncModuleName)]的值:[$(pobjFuncModule_AgcEN.FuncModuleName)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleEnName && undefined !== pobjFuncModule_AgcEN.FuncModuleEnName && tzDataType.isString(pobjFuncModule_AgcEN.FuncModuleEnName) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|功能模块英文名称(FuncModuleEnName)]的值:[$(pobjFuncModule_AgcEN.FuncModuleEnName)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleName_Sim && undefined !== pobjFuncModule_AgcEN.FuncModuleName_Sim && tzDataType.isString(pobjFuncModule_AgcEN.FuncModuleName_Sim) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|功能模块简称(FuncModuleName_Sim)]的值:[$(pobjFuncModule_AgcEN.FuncModuleName_Sim)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.PrjId && undefined !== pobjFuncModule_AgcEN.PrjId && tzDataType.isString(pobjFuncModule_AgcEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|工程ID(PrjId)]的值:[$(pobjFuncModule_AgcEN.PrjId)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.OrderNum && undefined !== pobjFuncModule_AgcEN.OrderNum && tzDataType.isNumber(pobjFuncModule_AgcEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|序号(OrderNum)]的值:[$(pobjFuncModule_AgcEN.OrderNum)], 非法，应该为数值型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.UseStateId && undefined !== pobjFuncModule_AgcEN.UseStateId && tzDataType.isString(pobjFuncModule_AgcEN.UseStateId) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|使用状态Id(UseStateId)]的值:[$(pobjFuncModule_AgcEN.UseStateId)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.UpdUser && undefined !== pobjFuncModule_AgcEN.UpdUser && tzDataType.isString(pobjFuncModule_AgcEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|修改者(UpdUser)]的值:[$(pobjFuncModule_AgcEN.UpdUser)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.UpdDate && undefined !== pobjFuncModule_AgcEN.UpdDate && tzDataType.isString(pobjFuncModule_AgcEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|修改日期(UpdDate)]的值:[$(pobjFuncModule_AgcEN.UpdDate)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (null !== pobjFuncModule_AgcEN.Memo && undefined !== pobjFuncModule_AgcEN.Memo && tzDataType.isString(pobjFuncModule_AgcEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[功能模块_Agc(FuncModule_Agc)|说明(Memo)]的值:[$(pobjFuncModule_AgcEN.Memo)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjFuncModule_AgcEN.PrjId != null && GetStrLen(pobjFuncModule_AgcEN.PrjId) !=  4)
{
 throw ("(errid:Busi000157)字段[功能模块_Agc|工程ID]作为外键字段,长度应该为4!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (pobjFuncModule_AgcEN.UseStateId != null && GetStrLen(pobjFuncModule_AgcEN.UseStateId) !=  4)
{
 throw ("(errid:Busi000157)字段[功能模块_Agc|使用状态Id]作为外键字段,长度应该为4!(clsFuncModule_AgcBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjFuncModule_AgcEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsFuncModule_AgcBL.prototype.CheckProperty4Update  = function(pobjFuncModule_AgcEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjFuncModule_AgcEN.FuncModuleAgcId && GetStrLen(pobjFuncModule_AgcEN.FuncModuleAgcId) > 8)
{
 throw new Error("(errid:Busi000158)字段[功能模块_Agc(FuncModule_Agc)|功能模块Id(FuncModuleAgcId)]的长度不能超过8!值:$(pobjFuncModule_AgcEN.FuncModuleAgcId)(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleName && GetStrLen(pobjFuncModule_AgcEN.FuncModuleName) > 30)
{
 throw new Error("(errid:Busi000158)字段[功能模块_Agc(FuncModule_Agc)|功能模块名称(FuncModuleName)]的长度不能超过30!值:$(pobjFuncModule_AgcEN.FuncModuleName)(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleEnName && GetStrLen(pobjFuncModule_AgcEN.FuncModuleEnName) > 30)
{
 throw new Error("(errid:Busi000158)字段[功能模块_Agc(FuncModule_Agc)|功能模块英文名称(FuncModuleEnName)]的长度不能超过30!值:$(pobjFuncModule_AgcEN.FuncModuleEnName)(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleName_Sim && GetStrLen(pobjFuncModule_AgcEN.FuncModuleName_Sim) > 30)
{
 throw new Error("(errid:Busi000158)字段[功能模块_Agc(FuncModule_Agc)|功能模块简称(FuncModuleName_Sim)]的长度不能超过30!值:$(pobjFuncModule_AgcEN.FuncModuleName_Sim)(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.PrjId && GetStrLen(pobjFuncModule_AgcEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[功能模块_Agc(FuncModule_Agc)|工程ID(PrjId)]的长度不能超过4!值:$(pobjFuncModule_AgcEN.PrjId)(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.UseStateId && GetStrLen(pobjFuncModule_AgcEN.UseStateId) > 4)
{
 throw new Error("(errid:Busi000158)字段[功能模块_Agc(FuncModule_Agc)|使用状态Id(UseStateId)]的长度不能超过4!值:$(pobjFuncModule_AgcEN.UseStateId)(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.UpdUser && GetStrLen(pobjFuncModule_AgcEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[功能模块_Agc(FuncModule_Agc)|修改者(UpdUser)]的长度不能超过20!值:$(pobjFuncModule_AgcEN.UpdUser)(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.UpdDate && GetStrLen(pobjFuncModule_AgcEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[功能模块_Agc(FuncModule_Agc)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjFuncModule_AgcEN.UpdDate)(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.Memo && GetStrLen(pobjFuncModule_AgcEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[功能模块_Agc(FuncModule_Agc)|说明(Memo)]的长度不能超过1000!值:$(pobjFuncModule_AgcEN.Memo)(clsFuncModule_AgcBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjFuncModule_AgcEN.FuncModuleAgcId && undefined !== pobjFuncModule_AgcEN.FuncModuleAgcId && tzDataType.isString(pobjFuncModule_AgcEN.FuncModuleAgcId) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|功能模块Id(FuncModuleAgcId)]的值:[$(pobjFuncModule_AgcEN.FuncModuleAgcId)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleName && undefined !== pobjFuncModule_AgcEN.FuncModuleName && tzDataType.isString(pobjFuncModule_AgcEN.FuncModuleName) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|功能模块名称(FuncModuleName)]的值:[$(pobjFuncModule_AgcEN.FuncModuleName)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleEnName && undefined !== pobjFuncModule_AgcEN.FuncModuleEnName && tzDataType.isString(pobjFuncModule_AgcEN.FuncModuleEnName) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|功能模块英文名称(FuncModuleEnName)]的值:[$(pobjFuncModule_AgcEN.FuncModuleEnName)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.FuncModuleName_Sim && undefined !== pobjFuncModule_AgcEN.FuncModuleName_Sim && tzDataType.isString(pobjFuncModule_AgcEN.FuncModuleName_Sim) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|功能模块简称(FuncModuleName_Sim)]的值:[$(pobjFuncModule_AgcEN.FuncModuleName_Sim)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.PrjId && undefined !== pobjFuncModule_AgcEN.PrjId && tzDataType.isString(pobjFuncModule_AgcEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|工程ID(PrjId)]的值:[$(pobjFuncModule_AgcEN.PrjId)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.OrderNum && undefined !== pobjFuncModule_AgcEN.OrderNum && tzDataType.isNumber(pobjFuncModule_AgcEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|序号(OrderNum)]的值:[$(pobjFuncModule_AgcEN.OrderNum)], 非法，应该为数值型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.UseStateId && undefined !== pobjFuncModule_AgcEN.UseStateId && tzDataType.isString(pobjFuncModule_AgcEN.UseStateId) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|使用状态Id(UseStateId)]的值:[$(pobjFuncModule_AgcEN.UseStateId)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.UpdUser && undefined !== pobjFuncModule_AgcEN.UpdUser && tzDataType.isString(pobjFuncModule_AgcEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|修改者(UpdUser)]的值:[$(pobjFuncModule_AgcEN.UpdUser)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.UpdDate && undefined !== pobjFuncModule_AgcEN.UpdDate && tzDataType.isString(pobjFuncModule_AgcEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|修改日期(UpdDate)]的值:[$(pobjFuncModule_AgcEN.UpdDate)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
if (null !== pobjFuncModule_AgcEN.Memo && undefined !== pobjFuncModule_AgcEN.Memo && tzDataType.isString(pobjFuncModule_AgcEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[功能模块_Agc(FuncModule_Agc)|说明(Memo)]的值:[$(pobjFuncModule_AgcEN.Memo)], 非法，应该为字符型!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjFuncModule_AgcEN.FuncModuleAgcId 
 || null !== pobjFuncModule_AgcEN.FuncModuleAgcId && pobjFuncModule_AgcEN.FuncModuleAgcId.toString()  ===  ""
 || null !== pobjFuncModule_AgcEN.FuncModuleAgcId && pobjFuncModule_AgcEN.FuncModuleAgcId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[功能模块_Agc|功能模块Id]不能为空(NULL)!(clsFuncModule_AgcBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjFuncModule_AgcEN.PrjId != null && GetStrLen(pobjFuncModule_AgcEN.PrjId) !=  4)
{
 throw ("(errid:Busi000161)字段[功能模块_Agc|工程ID]作为外键字段,长度应该为4!(clsFuncModule_AgcBL:CheckPropertyNew)");
}
if (pobjFuncModule_AgcEN.UseStateId != null && GetStrLen(pobjFuncModule_AgcEN.UseStateId) !=  4)
{
 throw ("(errid:Busi000161)字段[功能模块_Agc|使用状态Id]作为外键字段,长度应该为4!(clsFuncModule_AgcBL:CheckPropertyNew)");
}

 pobjFuncModule_AgcEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200502010554
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsFuncModule_AgcBL.GetJSONStrByObj  = function(pobjFuncModule_AgcEN)
{
pobjFuncModule_AgcEN.sf_UpdFldSetStr = pobjFuncModule_AgcEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjFuncModule_AgcEN);
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
 /// 日期:20200502010554
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsFuncModule_AgcBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrFuncModule_AgcObjLst = new Array();
if (strJSON === "")
{
return arrFuncModule_AgcObjLst;
}
try
{
arrFuncModule_AgcObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrFuncModule_AgcObjLst;
}
return arrFuncModule_AgcObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200502010554
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsFuncModule_AgcBL.GetObjByJSONStr  = function(strJSON)
{
var pobjFuncModule_AgcEN = new clsFuncModule_AgcEN();
if (strJSON === "")
{
return pobjFuncModule_AgcEN;
}
try
{
pobjFuncModule_AgcEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjFuncModule_AgcEN;
}
return pobjFuncModule_AgcEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objFuncModule_AgcENS">源简化对象</param>
 /// <param name = "objFuncModule_AgcENT">目标对象</param>
clsFuncModule_AgcBL.CopyObjFromSimObj = function(objFuncModule_AgcENS, objFuncModule_AgcENT) 
{
objFuncModule_AgcENT.FuncModuleAgcId = objFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objFuncModule_AgcENT.FuncModuleName = objFuncModule_AgcENS.FuncModuleName; //功能模块名称
objFuncModule_AgcENT.FuncModuleEnName = objFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objFuncModule_AgcENT.FuncModuleName_Sim = objFuncModule_AgcENS.FuncModuleName_Sim; //功能模块简称
objFuncModule_AgcENT.PrjId = objFuncModule_AgcENS.PrjId; //工程ID
objFuncModule_AgcENT.OrderNum = objFuncModule_AgcENS.OrderNum; //序号
objFuncModule_AgcENT.UseStateId = objFuncModule_AgcENS.UseStateId; //使用状态Id
objFuncModule_AgcENT.UpdUser = objFuncModule_AgcENS.UpdUser; //修改者
objFuncModule_AgcENT.UpdDate = objFuncModule_AgcENS.UpdDate; //修改日期
objFuncModule_AgcENT.Memo = objFuncModule_AgcENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objFuncModule_AgcENS">源对象</param>
 /// <param name = "objFuncModule_AgcENT">目标对象</param>
clsFuncModule_AgcBL.CopyObjTo = function(objFuncModule_AgcENS , objFuncModule_AgcENT ) 
{
objFuncModule_AgcENT.FuncModuleAgcId = objFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objFuncModule_AgcENT.FuncModuleName = objFuncModule_AgcENS.FuncModuleName; //功能模块名称
objFuncModule_AgcENT.FuncModuleEnName = objFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objFuncModule_AgcENT.FuncModuleName_Sim = objFuncModule_AgcENS.FuncModuleName_Sim; //功能模块简称
objFuncModule_AgcENT.PrjId = objFuncModule_AgcENS.PrjId; //工程ID
objFuncModule_AgcENT.OrderNum = objFuncModule_AgcENS.OrderNum; //序号
objFuncModule_AgcENT.UseStateId = objFuncModule_AgcENS.UseStateId; //使用状态Id
objFuncModule_AgcENT.UpdUser = objFuncModule_AgcENS.UpdUser; //修改者
objFuncModule_AgcENT.UpdDate = objFuncModule_AgcENS.UpdDate; //修改日期
objFuncModule_AgcENT.Memo = objFuncModule_AgcENS.Memo; //说明
objFuncModule_AgcENT.sf_UpdFldSetStr = objFuncModule_AgcENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objFuncModule_AgcENS">源对象</param>
 /// <param name = "objFuncModule_AgcENT">目标对象</param>
clsFuncModule_AgcBL.CopyObjToSimObj = function(objFuncModule_AgcENS , objFuncModule_AgcENT ) 
{
objFuncModule_AgcENT.FuncModuleAgcId = objFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objFuncModule_AgcENT.FuncModuleName = objFuncModule_AgcENS.FuncModuleName; //功能模块名称
objFuncModule_AgcENT.FuncModuleEnName = objFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objFuncModule_AgcENT.FuncModuleName_Sim = objFuncModule_AgcENS.FuncModuleName_Sim; //功能模块简称
objFuncModule_AgcENT.PrjId = objFuncModule_AgcENS.PrjId; //工程ID
objFuncModule_AgcENT.OrderNum = objFuncModule_AgcENS.OrderNum; //序号
objFuncModule_AgcENT.UseStateId = objFuncModule_AgcENS.UseStateId; //使用状态Id
objFuncModule_AgcENT.UpdUser = objFuncModule_AgcENS.UpdUser; //修改者
objFuncModule_AgcENT.UpdDate = objFuncModule_AgcENS.UpdDate; //修改日期
objFuncModule_AgcENT.Memo = objFuncModule_AgcENS.Memo; //说明
objFuncModule_AgcENT.sf_UpdFldSetStr = objFuncModule_AgcENS.UpdFldString; //专门用于记录某字段属性是否修改
objFuncModule_AgcENT.sf_FldComparisonOp = objFuncModule_AgcENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objFuncModule_AgcENS">源简化对象</param>
 /// <param name = "objFuncModule_AgcENT">目标对象</param>
clsFuncModule_AgcBL.CopyObjFromSimObj4Upd = function(objFuncModule_AgcENS, objFuncModule_AgcENT )
 {
   var strsf_UpdFldSetStr = objFuncModule_AgcENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_FuncModuleAgcId)  >= 0)
{
objFuncModule_AgcENT.FuncModuleAgcId = objFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
}
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_FuncModuleName)  >= 0)
{
objFuncModule_AgcENT.FuncModuleName = objFuncModule_AgcENS.FuncModuleName; //功能模块名称
}
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_FuncModuleEnName)  >= 0)
{
objFuncModule_AgcENT.FuncModuleEnName = objFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
}
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_FuncModuleName_Sim)  >= 0)
{
objFuncModule_AgcENT.FuncModuleName_Sim = objFuncModule_AgcENS.FuncModuleName_Sim; //功能模块简称
}
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_PrjId)  >= 0)
{
objFuncModule_AgcENT.PrjId = objFuncModule_AgcENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_OrderNum)  >= 0)
{
objFuncModule_AgcENT.OrderNum = objFuncModule_AgcENS.OrderNum; //序号
}
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_UseStateId)  >= 0)
{
objFuncModule_AgcENT.UseStateId = objFuncModule_AgcENS.UseStateId; //使用状态Id
}
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_UpdUser)  >= 0)
{
objFuncModule_AgcENT.UpdUser = objFuncModule_AgcENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_UpdDate)  >= 0)
{
objFuncModule_AgcENT.UpdDate = objFuncModule_AgcENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsFuncModule_AgcEN.con_Memo)  >= 0)
{
objFuncModule_AgcENT.Memo = objFuncModule_AgcENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objFuncModule_AgcENS">源对象</param>
 /// <param name = "objFuncModule_AgcENT">目标对象</param>
clsFuncModule_AgcBL.GetSimObjFromObj = function(objFuncModule_AgcENS)
{
var objFuncModule_AgcENT = new clsFuncModule_AgcEN_Sim_js_1.clsFuncModule_AgcEN_Sim();
objFuncModule_AgcENT.FuncModuleAgcId = objFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objFuncModule_AgcENT.FuncModuleName = objFuncModule_AgcENS.FuncModuleName; //功能模块名称
objFuncModule_AgcENT.FuncModuleEnName = objFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objFuncModule_AgcENT.FuncModuleName_Sim = objFuncModule_AgcENS.FuncModuleName_Sim; //功能模块简称
objFuncModule_AgcENT.PrjId = objFuncModule_AgcENS.PrjId; //工程ID
objFuncModule_AgcENT.OrderNum = objFuncModule_AgcENS.OrderNum; //序号
objFuncModule_AgcENT.UseStateId = objFuncModule_AgcENS.UseStateId; //使用状态Id
objFuncModule_AgcENT.UpdUser = objFuncModule_AgcENS.UpdUser; //修改者
objFuncModule_AgcENT.UpdDate = objFuncModule_AgcENS.UpdDate; //修改日期
objFuncModule_AgcENT.Memo = objFuncModule_AgcENS.Memo; //说明
objFuncModule_AgcENT.sf_UpdFldSetStr = objFuncModule_AgcENS.UpdFldString; //专门用于记录某字段属性是否修改
objFuncModule_AgcENT.sf_FldComparisonOp = objFuncModule_AgcENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objFuncModule_AgcENT;
}
return clsFuncModule_AgcBL;
}());
exports.clsFuncModule_AgcBL = clsFuncModule_AgcBL;
});