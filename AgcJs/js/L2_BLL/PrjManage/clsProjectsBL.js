
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProjectsBL
 表名:Projects(00050002)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:13
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjManage/clsProjectsEN.js","../../L0_Entity/PrjManage/clsProjectsEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsProjectsEN_js_1 = require("../../L0_Entity/PrjManage/clsProjectsEN.js");
var clsProjectsEN_Sim_js_1 = require("../../L0_Entity/PrjManage/clsProjectsEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 工程(Projects)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsProjectsBL = /** @class */ (function () {
function clsProjectsBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrProjectsObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsProjectsBL.prototype.CheckPropertyNew = function(pobjProjectsEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjProjectsEN.PrjName 
 || null !== pobjProjectsEN.PrjName && pobjProjectsEN.PrjName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程|工程名称]不能为空(NULL)!(clsProjectsBL:CheckPropertyNew)");
}
if (null === pobjProjectsEN.SoftStructureId 
 || null !== pobjProjectsEN.SoftStructureId && pobjProjectsEN.SoftStructureId.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程|架构ID]不能为空(NULL)!(clsProjectsBL:CheckPropertyNew)");
}
if (null === pobjProjectsEN.ApplicationTypeId 
 || null !== pobjProjectsEN.ApplicationTypeId && pobjProjectsEN.ApplicationTypeId.toString()  ===  ""
 || null !== pobjProjectsEN.ApplicationTypeId && pobjProjectsEN.ApplicationTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程|应用程序类型ID]不能为空(NULL)!(clsProjectsBL:CheckPropertyNew)");
}
if (null === pobjProjectsEN.UseStateId 
 || null !== pobjProjectsEN.UseStateId && pobjProjectsEN.UseStateId.toString()  ===  ""
 || null !== pobjProjectsEN.UseStateId && pobjProjectsEN.UseStateId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程|使用状态Id]不能为空(NULL)!(clsProjectsBL:CheckPropertyNew)");
}
if (null === pobjProjectsEN.IsSupportMvc 
 || null !== pobjProjectsEN.IsSupportMvc && pobjProjectsEN.IsSupportMvc.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程|是否支持Mvc]不能为空(NULL)!(clsProjectsBL:CheckPropertyNew)");
}
if (null === pobjProjectsEN.UserId 
 || null !== pobjProjectsEN.UserId && pobjProjectsEN.UserId.toString()  ===  ""
 || null !== pobjProjectsEN.UserId && pobjProjectsEN.UserId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程|用户Id]不能为空(NULL)!(clsProjectsBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjProjectsEN.PrjId && GetStrLen(pobjProjectsEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|工程ID(PrjId)]的长度不能超过4!值:$(pobjProjectsEN.PrjId)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.PrjName && GetStrLen(pobjProjectsEN.PrjName) > 30)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|工程名称(PrjName)]的长度不能超过30!值:$(pobjProjectsEN.PrjName)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.PrjDomain && GetStrLen(pobjProjectsEN.PrjDomain) > 128)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|域/包名(PrjDomain)]的长度不能超过128!值:$(pobjProjectsEN.PrjDomain)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.ISOPrjName && GetStrLen(pobjProjectsEN.ISOPrjName) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|ISO工程名(ISOPrjName)]的长度不能超过50!值:$(pobjProjectsEN.ISOPrjName)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.JavaPackageName && GetStrLen(pobjProjectsEN.JavaPackageName) > 200)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|Java包名(JavaPackageName)]的长度不能超过200!值:$(pobjProjectsEN.JavaPackageName)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.TableSpace && GetStrLen(pobjProjectsEN.TableSpace) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|表空间(TableSpace)]的长度不能超过50!值:$(pobjProjectsEN.TableSpace)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.VirtualDirectory && GetStrLen(pobjProjectsEN.VirtualDirectory) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|虚拟目录(VirtualDirectory)]的长度不能超过50!值:$(pobjProjectsEN.VirtualDirectory)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.PrjRootDirectory && GetStrLen(pobjProjectsEN.PrjRootDirectory) > 255)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|工程根目录(PrjRootDirectory)]的长度不能超过255!值:$(pobjProjectsEN.PrjRootDirectory)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.SoftStructureId && GetStrLen(pobjProjectsEN.SoftStructureId) > 4)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|架构ID(SoftStructureId)]的长度不能超过4!值:$(pobjProjectsEN.SoftStructureId)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.UseStateId && GetStrLen(pobjProjectsEN.UseStateId) > 4)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|使用状态Id(UseStateId)]的长度不能超过4!值:$(pobjProjectsEN.UseStateId)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.UserId && GetStrLen(pobjProjectsEN.UserId) > 18)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|用户Id(UserId)]的长度不能超过18!值:$(pobjProjectsEN.UserId)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.UpdDate && GetStrLen(pobjProjectsEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjProjectsEN.UpdDate)(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.Memo && GetStrLen(pobjProjectsEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[工程(Projects)|说明(Memo)]的长度不能超过1000!值:$(pobjProjectsEN.Memo)(clsProjectsBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjProjectsEN.PrjId && undefined !== pobjProjectsEN.PrjId && tzDataType.isString(pobjProjectsEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|工程ID(PrjId)]的值:[$(pobjProjectsEN.PrjId)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.PrjName && undefined !== pobjProjectsEN.PrjName && tzDataType.isString(pobjProjectsEN.PrjName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|工程名称(PrjName)]的值:[$(pobjProjectsEN.PrjName)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.PrjDomain && undefined !== pobjProjectsEN.PrjDomain && tzDataType.isString(pobjProjectsEN.PrjDomain) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|域/包名(PrjDomain)]的值:[$(pobjProjectsEN.PrjDomain)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.ISOPrjName && undefined !== pobjProjectsEN.ISOPrjName && tzDataType.isString(pobjProjectsEN.ISOPrjName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|ISO工程名(ISOPrjName)]的值:[$(pobjProjectsEN.ISOPrjName)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.JavaPackageName && undefined !== pobjProjectsEN.JavaPackageName && tzDataType.isString(pobjProjectsEN.JavaPackageName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|Java包名(JavaPackageName)]的值:[$(pobjProjectsEN.JavaPackageName)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.TableSpace && undefined !== pobjProjectsEN.TableSpace && tzDataType.isString(pobjProjectsEN.TableSpace) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|表空间(TableSpace)]的值:[$(pobjProjectsEN.TableSpace)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.VirtualDirectory && undefined !== pobjProjectsEN.VirtualDirectory && tzDataType.isString(pobjProjectsEN.VirtualDirectory) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|虚拟目录(VirtualDirectory)]的值:[$(pobjProjectsEN.VirtualDirectory)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.PrjRootDirectory && undefined !== pobjProjectsEN.PrjRootDirectory && tzDataType.isString(pobjProjectsEN.PrjRootDirectory) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|工程根目录(PrjRootDirectory)]的值:[$(pobjProjectsEN.PrjRootDirectory)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.IsRelaDataBase && undefined !== pobjProjectsEN.IsRelaDataBase && tzDataType.isBoolean(pobjProjectsEN.IsRelaDataBase) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|是否关联数据库(IsRelaDataBase)]的值:[$(pobjProjectsEN.IsRelaDataBase)], 非法，应该为布尔型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.SoftStructureId && undefined !== pobjProjectsEN.SoftStructureId && tzDataType.isString(pobjProjectsEN.SoftStructureId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|架构ID(SoftStructureId)]的值:[$(pobjProjectsEN.SoftStructureId)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.ApplicationTypeId && undefined !== pobjProjectsEN.ApplicationTypeId && tzDataType.isNumber(pobjProjectsEN.ApplicationTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|应用程序类型ID(ApplicationTypeId)]的值:[$(pobjProjectsEN.ApplicationTypeId)], 非法，应该为数值型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.UseStateId && undefined !== pobjProjectsEN.UseStateId && tzDataType.isString(pobjProjectsEN.UseStateId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|使用状态Id(UseStateId)]的值:[$(pobjProjectsEN.UseStateId)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.IsSupportMvc && undefined !== pobjProjectsEN.IsSupportMvc && tzDataType.isBoolean(pobjProjectsEN.IsSupportMvc) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|是否支持Mvc(IsSupportMvc)]的值:[$(pobjProjectsEN.IsSupportMvc)], 非法，应该为布尔型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.UserId && undefined !== pobjProjectsEN.UserId && tzDataType.isString(pobjProjectsEN.UserId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|用户Id(UserId)]的值:[$(pobjProjectsEN.UserId)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.UpdDate && undefined !== pobjProjectsEN.UpdDate && tzDataType.isString(pobjProjectsEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|修改日期(UpdDate)]的值:[$(pobjProjectsEN.UpdDate)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
if (null !== pobjProjectsEN.Memo && undefined !== pobjProjectsEN.Memo && tzDataType.isString(pobjProjectsEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[工程(Projects)|说明(Memo)]的值:[$(pobjProjectsEN.Memo)], 非法，应该为字符型!(clsProjectsBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjProjectsEN.UseStateId != null && GetStrLen(pobjProjectsEN.UseStateId) !=  4)
{
 throw ("(errid:Busi000157)字段[工程|使用状态Id]作为外键字段,长度应该为4!(clsProjectsBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjProjectsEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsProjectsBL.prototype.CheckProperty4Update  = function(pobjProjectsEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjProjectsEN.PrjId && GetStrLen(pobjProjectsEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|工程ID(PrjId)]的长度不能超过4!值:$(pobjProjectsEN.PrjId)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.PrjName && GetStrLen(pobjProjectsEN.PrjName) > 30)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|工程名称(PrjName)]的长度不能超过30!值:$(pobjProjectsEN.PrjName)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.PrjDomain && GetStrLen(pobjProjectsEN.PrjDomain) > 128)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|域/包名(PrjDomain)]的长度不能超过128!值:$(pobjProjectsEN.PrjDomain)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.ISOPrjName && GetStrLen(pobjProjectsEN.ISOPrjName) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|ISO工程名(ISOPrjName)]的长度不能超过50!值:$(pobjProjectsEN.ISOPrjName)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.JavaPackageName && GetStrLen(pobjProjectsEN.JavaPackageName) > 200)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|Java包名(JavaPackageName)]的长度不能超过200!值:$(pobjProjectsEN.JavaPackageName)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.TableSpace && GetStrLen(pobjProjectsEN.TableSpace) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|表空间(TableSpace)]的长度不能超过50!值:$(pobjProjectsEN.TableSpace)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.VirtualDirectory && GetStrLen(pobjProjectsEN.VirtualDirectory) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|虚拟目录(VirtualDirectory)]的长度不能超过50!值:$(pobjProjectsEN.VirtualDirectory)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.PrjRootDirectory && GetStrLen(pobjProjectsEN.PrjRootDirectory) > 255)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|工程根目录(PrjRootDirectory)]的长度不能超过255!值:$(pobjProjectsEN.PrjRootDirectory)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.SoftStructureId && GetStrLen(pobjProjectsEN.SoftStructureId) > 4)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|架构ID(SoftStructureId)]的长度不能超过4!值:$(pobjProjectsEN.SoftStructureId)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.UseStateId && GetStrLen(pobjProjectsEN.UseStateId) > 4)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|使用状态Id(UseStateId)]的长度不能超过4!值:$(pobjProjectsEN.UseStateId)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.UserId && GetStrLen(pobjProjectsEN.UserId) > 18)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|用户Id(UserId)]的长度不能超过18!值:$(pobjProjectsEN.UserId)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.UpdDate && GetStrLen(pobjProjectsEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjProjectsEN.UpdDate)(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.Memo && GetStrLen(pobjProjectsEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[工程(Projects)|说明(Memo)]的长度不能超过1000!值:$(pobjProjectsEN.Memo)(clsProjectsBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjProjectsEN.PrjId && undefined !== pobjProjectsEN.PrjId && tzDataType.isString(pobjProjectsEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|工程ID(PrjId)]的值:[$(pobjProjectsEN.PrjId)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.PrjName && undefined !== pobjProjectsEN.PrjName && tzDataType.isString(pobjProjectsEN.PrjName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|工程名称(PrjName)]的值:[$(pobjProjectsEN.PrjName)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.PrjDomain && undefined !== pobjProjectsEN.PrjDomain && tzDataType.isString(pobjProjectsEN.PrjDomain) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|域/包名(PrjDomain)]的值:[$(pobjProjectsEN.PrjDomain)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.ISOPrjName && undefined !== pobjProjectsEN.ISOPrjName && tzDataType.isString(pobjProjectsEN.ISOPrjName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|ISO工程名(ISOPrjName)]的值:[$(pobjProjectsEN.ISOPrjName)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.JavaPackageName && undefined !== pobjProjectsEN.JavaPackageName && tzDataType.isString(pobjProjectsEN.JavaPackageName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|Java包名(JavaPackageName)]的值:[$(pobjProjectsEN.JavaPackageName)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.TableSpace && undefined !== pobjProjectsEN.TableSpace && tzDataType.isString(pobjProjectsEN.TableSpace) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|表空间(TableSpace)]的值:[$(pobjProjectsEN.TableSpace)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.VirtualDirectory && undefined !== pobjProjectsEN.VirtualDirectory && tzDataType.isString(pobjProjectsEN.VirtualDirectory) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|虚拟目录(VirtualDirectory)]的值:[$(pobjProjectsEN.VirtualDirectory)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.PrjRootDirectory && undefined !== pobjProjectsEN.PrjRootDirectory && tzDataType.isString(pobjProjectsEN.PrjRootDirectory) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|工程根目录(PrjRootDirectory)]的值:[$(pobjProjectsEN.PrjRootDirectory)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.IsRelaDataBase && undefined !== pobjProjectsEN.IsRelaDataBase && tzDataType.isBoolean(pobjProjectsEN.IsRelaDataBase) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|是否关联数据库(IsRelaDataBase)]的值:[$(pobjProjectsEN.IsRelaDataBase)], 非法，应该为布尔型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.SoftStructureId && undefined !== pobjProjectsEN.SoftStructureId && tzDataType.isString(pobjProjectsEN.SoftStructureId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|架构ID(SoftStructureId)]的值:[$(pobjProjectsEN.SoftStructureId)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.ApplicationTypeId && undefined !== pobjProjectsEN.ApplicationTypeId && tzDataType.isNumber(pobjProjectsEN.ApplicationTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|应用程序类型ID(ApplicationTypeId)]的值:[$(pobjProjectsEN.ApplicationTypeId)], 非法，应该为数值型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.UseStateId && undefined !== pobjProjectsEN.UseStateId && tzDataType.isString(pobjProjectsEN.UseStateId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|使用状态Id(UseStateId)]的值:[$(pobjProjectsEN.UseStateId)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.IsSupportMvc && undefined !== pobjProjectsEN.IsSupportMvc && tzDataType.isBoolean(pobjProjectsEN.IsSupportMvc) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|是否支持Mvc(IsSupportMvc)]的值:[$(pobjProjectsEN.IsSupportMvc)], 非法，应该为布尔型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.UserId && undefined !== pobjProjectsEN.UserId && tzDataType.isString(pobjProjectsEN.UserId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|用户Id(UserId)]的值:[$(pobjProjectsEN.UserId)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.UpdDate && undefined !== pobjProjectsEN.UpdDate && tzDataType.isString(pobjProjectsEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|修改日期(UpdDate)]的值:[$(pobjProjectsEN.UpdDate)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
if (null !== pobjProjectsEN.Memo && undefined !== pobjProjectsEN.Memo && tzDataType.isString(pobjProjectsEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[工程(Projects)|说明(Memo)]的值:[$(pobjProjectsEN.Memo)], 非法，应该为字符型!(clsProjectsBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjProjectsEN.PrjId 
 || null !== pobjProjectsEN.PrjId && pobjProjectsEN.PrjId.toString()  ===  ""
 || null !== pobjProjectsEN.PrjId && pobjProjectsEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[工程|工程ID]不能为空(NULL)!(clsProjectsBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjProjectsEN.UseStateId != null && GetStrLen(pobjProjectsEN.UseStateId) !=  4)
{
 throw ("(errid:Busi000161)字段[工程|使用状态Id]作为外键字段,长度应该为4!(clsProjectsBL:CheckPropertyNew)");
}

 pobjProjectsEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024913
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsProjectsBL.GetJSONStrByObj  = function(pobjProjectsEN)
{
pobjProjectsEN.sf_UpdFldSetStr = pobjProjectsEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjProjectsEN);
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
 /// 日期:20200501024913
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsProjectsBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrProjectsObjLst = new Array();
if (strJSON === "")
{
return arrProjectsObjLst;
}
try
{
arrProjectsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrProjectsObjLst;
}
return arrProjectsObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024913
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsProjectsBL.GetObjByJSONStr  = function(strJSON)
{
var pobjProjectsEN = new clsProjectsEN();
if (strJSON === "")
{
return pobjProjectsEN;
}
try
{
pobjProjectsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjProjectsEN;
}
return pobjProjectsEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objProjectsENS">源简化对象</param>
 /// <param name = "objProjectsENT">目标对象</param>
clsProjectsBL.CopyObjFromSimObj = function(objProjectsENS, objProjectsENT) 
{
objProjectsENT.PrjId = objProjectsENS.PrjId; //工程ID
objProjectsENT.PrjName = objProjectsENS.PrjName; //工程名称
objProjectsENT.PrjDomain = objProjectsENS.PrjDomain; //域/包名
objProjectsENT.ISOPrjName = objProjectsENS.ISOPrjName; //ISO工程名
objProjectsENT.JavaPackageName = objProjectsENS.JavaPackageName; //Java包名
objProjectsENT.TableSpace = objProjectsENS.TableSpace; //表空间
objProjectsENT.VirtualDirectory = objProjectsENS.VirtualDirectory; //虚拟目录
objProjectsENT.PrjRootDirectory = objProjectsENS.PrjRootDirectory; //工程根目录
objProjectsENT.IsRelaDataBase = objProjectsENS.IsRelaDataBase; //是否关联数据库
objProjectsENT.SoftStructureId = objProjectsENS.SoftStructureId; //架构ID
objProjectsENT.ApplicationTypeId = objProjectsENS.ApplicationTypeId; //应用程序类型ID
objProjectsENT.UseStateId = objProjectsENS.UseStateId; //使用状态Id
objProjectsENT.IsSupportMvc = objProjectsENS.IsSupportMvc; //是否支持Mvc
objProjectsENT.UserId = objProjectsENS.UserId; //用户Id
objProjectsENT.UpdDate = objProjectsENS.UpdDate; //修改日期
objProjectsENT.Memo = objProjectsENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objProjectsENS">源对象</param>
 /// <param name = "objProjectsENT">目标对象</param>
clsProjectsBL.CopyObjTo = function(objProjectsENS , objProjectsENT ) 
{
objProjectsENT.PrjId = objProjectsENS.PrjId; //工程ID
objProjectsENT.PrjName = objProjectsENS.PrjName; //工程名称
objProjectsENT.PrjDomain = objProjectsENS.PrjDomain; //域/包名
objProjectsENT.ISOPrjName = objProjectsENS.ISOPrjName; //ISO工程名
objProjectsENT.JavaPackageName = objProjectsENS.JavaPackageName; //Java包名
objProjectsENT.TableSpace = objProjectsENS.TableSpace; //表空间
objProjectsENT.VirtualDirectory = objProjectsENS.VirtualDirectory; //虚拟目录
objProjectsENT.PrjRootDirectory = objProjectsENS.PrjRootDirectory; //工程根目录
objProjectsENT.IsRelaDataBase = objProjectsENS.IsRelaDataBase; //是否关联数据库
objProjectsENT.SoftStructureId = objProjectsENS.SoftStructureId; //架构ID
objProjectsENT.ApplicationTypeId = objProjectsENS.ApplicationTypeId; //应用程序类型ID
objProjectsENT.UseStateId = objProjectsENS.UseStateId; //使用状态Id
objProjectsENT.IsSupportMvc = objProjectsENS.IsSupportMvc; //是否支持Mvc
objProjectsENT.UserId = objProjectsENS.UserId; //用户Id
objProjectsENT.UpdDate = objProjectsENS.UpdDate; //修改日期
objProjectsENT.Memo = objProjectsENS.Memo; //说明
objProjectsENT.sf_UpdFldSetStr = objProjectsENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objProjectsENS">源对象</param>
 /// <param name = "objProjectsENT">目标对象</param>
clsProjectsBL.CopyObjToSimObj = function(objProjectsENS , objProjectsENT ) 
{
objProjectsENT.PrjId = objProjectsENS.PrjId; //工程ID
objProjectsENT.PrjName = objProjectsENS.PrjName; //工程名称
objProjectsENT.PrjDomain = objProjectsENS.PrjDomain; //域/包名
objProjectsENT.ISOPrjName = objProjectsENS.ISOPrjName; //ISO工程名
objProjectsENT.JavaPackageName = objProjectsENS.JavaPackageName; //Java包名
objProjectsENT.TableSpace = objProjectsENS.TableSpace; //表空间
objProjectsENT.VirtualDirectory = objProjectsENS.VirtualDirectory; //虚拟目录
objProjectsENT.PrjRootDirectory = objProjectsENS.PrjRootDirectory; //工程根目录
objProjectsENT.IsRelaDataBase = objProjectsENS.IsRelaDataBase; //是否关联数据库
objProjectsENT.SoftStructureId = objProjectsENS.SoftStructureId; //架构ID
objProjectsENT.ApplicationTypeId = objProjectsENS.ApplicationTypeId; //应用程序类型ID
objProjectsENT.UseStateId = objProjectsENS.UseStateId; //使用状态Id
objProjectsENT.IsSupportMvc = objProjectsENS.IsSupportMvc; //是否支持Mvc
objProjectsENT.UserId = objProjectsENS.UserId; //用户Id
objProjectsENT.UpdDate = objProjectsENS.UpdDate; //修改日期
objProjectsENT.Memo = objProjectsENS.Memo; //说明
objProjectsENT.sf_UpdFldSetStr = objProjectsENS.UpdFldString; //专门用于记录某字段属性是否修改
objProjectsENT.sf_FldComparisonOp = objProjectsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objProjectsENS">源简化对象</param>
 /// <param name = "objProjectsENT">目标对象</param>
clsProjectsBL.CopyObjFromSimObj4Upd = function(objProjectsENS, objProjectsENT )
 {
   var strsf_UpdFldSetStr = objProjectsENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsProjectsEN.con_PrjId)  >= 0)
{
objProjectsENT.PrjId = objProjectsENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsProjectsEN.con_PrjName)  >= 0)
{
objProjectsENT.PrjName = objProjectsENS.PrjName; //工程名称
}
if (sstrFldSet.indexOf(clsProjectsEN.con_PrjDomain)  >= 0)
{
objProjectsENT.PrjDomain = objProjectsENS.PrjDomain; //域/包名
}
if (sstrFldSet.indexOf(clsProjectsEN.con_ISOPrjName)  >= 0)
{
objProjectsENT.ISOPrjName = objProjectsENS.ISOPrjName; //ISO工程名
}
if (sstrFldSet.indexOf(clsProjectsEN.con_JavaPackageName)  >= 0)
{
objProjectsENT.JavaPackageName = objProjectsENS.JavaPackageName; //Java包名
}
if (sstrFldSet.indexOf(clsProjectsEN.con_TableSpace)  >= 0)
{
objProjectsENT.TableSpace = objProjectsENS.TableSpace; //表空间
}
if (sstrFldSet.indexOf(clsProjectsEN.con_VirtualDirectory)  >= 0)
{
objProjectsENT.VirtualDirectory = objProjectsENS.VirtualDirectory; //虚拟目录
}
if (sstrFldSet.indexOf(clsProjectsEN.con_PrjRootDirectory)  >= 0)
{
objProjectsENT.PrjRootDirectory = objProjectsENS.PrjRootDirectory; //工程根目录
}
if (sstrFldSet.indexOf(clsProjectsEN.con_IsRelaDataBase)  >= 0)
{
objProjectsENT.IsRelaDataBase = objProjectsENS.IsRelaDataBase; //是否关联数据库
}
if (sstrFldSet.indexOf(clsProjectsEN.con_SoftStructureId)  >= 0)
{
objProjectsENT.SoftStructureId = objProjectsENS.SoftStructureId; //架构ID
}
if (sstrFldSet.indexOf(clsProjectsEN.con_ApplicationTypeId)  >= 0)
{
objProjectsENT.ApplicationTypeId = objProjectsENS.ApplicationTypeId; //应用程序类型ID
}
if (sstrFldSet.indexOf(clsProjectsEN.con_UseStateId)  >= 0)
{
objProjectsENT.UseStateId = objProjectsENS.UseStateId; //使用状态Id
}
if (sstrFldSet.indexOf(clsProjectsEN.con_IsSupportMvc)  >= 0)
{
objProjectsENT.IsSupportMvc = objProjectsENS.IsSupportMvc; //是否支持Mvc
}
if (sstrFldSet.indexOf(clsProjectsEN.con_UserId)  >= 0)
{
objProjectsENT.UserId = objProjectsENS.UserId; //用户Id
}
if (sstrFldSet.indexOf(clsProjectsEN.con_UpdDate)  >= 0)
{
objProjectsENT.UpdDate = objProjectsENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsProjectsEN.con_Memo)  >= 0)
{
objProjectsENT.Memo = objProjectsENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objProjectsENS">源对象</param>
 /// <param name = "objProjectsENT">目标对象</param>
clsProjectsBL.GetSimObjFromObj = function(objProjectsENS)
{
var objProjectsENT = new clsProjectsEN_Sim_js_1.clsProjectsEN_Sim();
objProjectsENT.PrjId = objProjectsENS.PrjId; //工程ID
objProjectsENT.PrjName = objProjectsENS.PrjName; //工程名称
objProjectsENT.PrjDomain = objProjectsENS.PrjDomain; //域/包名
objProjectsENT.ISOPrjName = objProjectsENS.ISOPrjName; //ISO工程名
objProjectsENT.JavaPackageName = objProjectsENS.JavaPackageName; //Java包名
objProjectsENT.TableSpace = objProjectsENS.TableSpace; //表空间
objProjectsENT.VirtualDirectory = objProjectsENS.VirtualDirectory; //虚拟目录
objProjectsENT.PrjRootDirectory = objProjectsENS.PrjRootDirectory; //工程根目录
objProjectsENT.IsRelaDataBase = objProjectsENS.IsRelaDataBase; //是否关联数据库
objProjectsENT.SoftStructureId = objProjectsENS.SoftStructureId; //架构ID
objProjectsENT.ApplicationTypeId = objProjectsENS.ApplicationTypeId; //应用程序类型ID
objProjectsENT.UseStateId = objProjectsENS.UseStateId; //使用状态Id
objProjectsENT.IsSupportMvc = objProjectsENS.IsSupportMvc; //是否支持Mvc
objProjectsENT.UserId = objProjectsENS.UserId; //用户Id
objProjectsENT.UpdDate = objProjectsENS.UpdDate; //修改日期
objProjectsENT.Memo = objProjectsENS.Memo; //说明
objProjectsENT.sf_UpdFldSetStr = objProjectsENS.UpdFldString; //专门用于记录某字段属性是否修改
objProjectsENT.sf_FldComparisonOp = objProjectsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objProjectsENT;
}
return clsProjectsBL;
}());
exports.clsProjectsBL = clsProjectsBL;
});