
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionBL
 表名:ViewRegion(00050099)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:22
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
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsViewRegionEN.js","../../L0_Entity/RegionManage/clsViewRegionEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsViewRegionEN_js_1 = require("../../L0_Entity/RegionManage/clsViewRegionEN.js");
var clsViewRegionEN_Sim_js_1 = require("../../L0_Entity/RegionManage/clsViewRegionEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 界面区域(ViewRegion)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsViewRegionBL = /** @class */ (function () {
function clsViewRegionBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrViewRegionObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewRegionBL.prototype.CheckPropertyNew = function(pobjViewRegionEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjViewRegionEN.RegionName 
 || null !== pobjViewRegionEN.RegionName && pobjViewRegionEN.RegionName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面区域|区域名称]不能为空(NULL)!(clsViewRegionBL:CheckPropertyNew)");
}
if (null === pobjViewRegionEN.ViewId 
 || null !== pobjViewRegionEN.ViewId && pobjViewRegionEN.ViewId.toString()  ===  ""
 || null !== pobjViewRegionEN.ViewId && pobjViewRegionEN.ViewId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面区域|界面Id]不能为空(NULL)!(clsViewRegionBL:CheckPropertyNew)");
}
if (null === pobjViewRegionEN.RegionTypeId 
 || null !== pobjViewRegionEN.RegionTypeId && pobjViewRegionEN.RegionTypeId.toString()  ===  ""
 || null !== pobjViewRegionEN.RegionTypeId && pobjViewRegionEN.RegionTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面区域|区域类型Id]不能为空(NULL)!(clsViewRegionBL:CheckPropertyNew)");
}
if (null === pobjViewRegionEN.PrjId 
 || null !== pobjViewRegionEN.PrjId && pobjViewRegionEN.PrjId.toString()  ===  ""
 || null !== pobjViewRegionEN.PrjId && pobjViewRegionEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面区域|工程ID]不能为空(NULL)!(clsViewRegionBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewRegionEN.RegionName && GetStrLen(pobjViewRegionEN.RegionName) > 50)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|区域名称(RegionName)]的长度不能超过50!值:$(pobjViewRegionEN.RegionName)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.ViewId && GetStrLen(pobjViewRegionEN.ViewId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|界面Id(ViewId)]的长度不能超过8!值:$(pobjViewRegionEN.ViewId)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.RegionTypeId && GetStrLen(pobjViewRegionEN.RegionTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|区域类型Id(RegionTypeId)]的长度不能超过4!值:$(pobjViewRegionEN.RegionTypeId)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.RegionFunction && GetStrLen(pobjViewRegionEN.RegionFunction) > 500)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|区域功能(RegionFunction)]的长度不能超过500!值:$(pobjViewRegionEN.RegionFunction)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.ClassName && GetStrLen(pobjViewRegionEN.ClassName) > 100)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|类名(ClassName)]的长度不能超过100!值:$(pobjViewRegionEN.ClassName)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.OUTRelaTabId && GetStrLen(pobjViewRegionEN.OUTRelaTabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|输出数据源表ID(OUTRelaTabId)]的长度不能超过8!值:$(pobjViewRegionEN.OUTRelaTabId)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.INSQLDSTypeId && GetStrLen(pobjViewRegionEN.INSQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|输入数据源类型(INSQLDSTypeId)]的长度不能超过2!值:$(pobjViewRegionEN.INSQLDSTypeId)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.INRelaTabId && GetStrLen(pobjViewRegionEN.INRelaTabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|输入数据源表ID(INRelaTabId)]的长度不能超过8!值:$(pobjViewRegionEN.INRelaTabId)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.OUTSQLDSTypeId && GetStrLen(pobjViewRegionEN.OUTSQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|输出数据源类型(OUTSQLDSTypeId)]的长度不能超过2!值:$(pobjViewRegionEN.OUTSQLDSTypeId)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.PrjId && GetStrLen(pobjViewRegionEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|工程ID(PrjId)]的长度不能超过4!值:$(pobjViewRegionEN.PrjId)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.UpdUser && GetStrLen(pobjViewRegionEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|修改者(UpdUser)]的长度不能超过20!值:$(pobjViewRegionEN.UpdUser)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.UpdDate && GetStrLen(pobjViewRegionEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjViewRegionEN.UpdDate)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.Memo && GetStrLen(pobjViewRegionEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|说明(Memo)]的长度不能超过1000!值:$(pobjViewRegionEN.Memo)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynchToServerDate && GetStrLen(pobjViewRegionEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjViewRegionEN.SynchToServerDate)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynchToServerUser && GetStrLen(pobjViewRegionEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjViewRegionEN.SynchToServerUser)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynchToClientDate && GetStrLen(pobjViewRegionEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjViewRegionEN.SynchToClientDate)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynchToClientUser && GetStrLen(pobjViewRegionEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjViewRegionEN.SynchToClientUser)(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynSource && GetStrLen(pobjViewRegionEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000155)字段[界面区域(ViewRegion)|同步来源(SynSource)]的长度不能超过50!值:$(pobjViewRegionEN.SynSource)(clsViewRegionBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewRegionEN.RegionId && undefined !== pobjViewRegionEN.RegionId && tzDataType.isNumber(pobjViewRegionEN.RegionId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|区域Id(RegionId)]的值:[$(pobjViewRegionEN.RegionId)], 非法，应该为数值型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.RegionName && undefined !== pobjViewRegionEN.RegionName && tzDataType.isString(pobjViewRegionEN.RegionName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|区域名称(RegionName)]的值:[$(pobjViewRegionEN.RegionName)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.ViewId && undefined !== pobjViewRegionEN.ViewId && tzDataType.isString(pobjViewRegionEN.ViewId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|界面Id(ViewId)]的值:[$(pobjViewRegionEN.ViewId)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.RegionTypeId && undefined !== pobjViewRegionEN.RegionTypeId && tzDataType.isString(pobjViewRegionEN.RegionTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|区域类型Id(RegionTypeId)]的值:[$(pobjViewRegionEN.RegionTypeId)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.RegionFunction && undefined !== pobjViewRegionEN.RegionFunction && tzDataType.isString(pobjViewRegionEN.RegionFunction) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|区域功能(RegionFunction)]的值:[$(pobjViewRegionEN.RegionFunction)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.ClassName && undefined !== pobjViewRegionEN.ClassName && tzDataType.isString(pobjViewRegionEN.ClassName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|类名(ClassName)]的值:[$(pobjViewRegionEN.ClassName)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.Height && undefined !== pobjViewRegionEN.Height && tzDataType.isNumber(pobjViewRegionEN.Height) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|高度(Height)]的值:[$(pobjViewRegionEN.Height)], 非法，应该为数值型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.Width && undefined !== pobjViewRegionEN.Width && tzDataType.isNumber(pobjViewRegionEN.Width) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|宽(Width)]的值:[$(pobjViewRegionEN.Width)], 非法，应该为数值型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.OUTRelaTabId && undefined !== pobjViewRegionEN.OUTRelaTabId && tzDataType.isString(pobjViewRegionEN.OUTRelaTabId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|输出数据源表ID(OUTRelaTabId)]的值:[$(pobjViewRegionEN.OUTRelaTabId)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.INSQLDSTypeId && undefined !== pobjViewRegionEN.INSQLDSTypeId && tzDataType.isString(pobjViewRegionEN.INSQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|输入数据源类型(INSQLDSTypeId)]的值:[$(pobjViewRegionEN.INSQLDSTypeId)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.INRelaTabId && undefined !== pobjViewRegionEN.INRelaTabId && tzDataType.isString(pobjViewRegionEN.INRelaTabId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|输入数据源表ID(INRelaTabId)]的值:[$(pobjViewRegionEN.INRelaTabId)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.OUTSQLDSTypeId && undefined !== pobjViewRegionEN.OUTSQLDSTypeId && tzDataType.isString(pobjViewRegionEN.OUTSQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|输出数据源类型(OUTSQLDSTypeId)]的值:[$(pobjViewRegionEN.OUTSQLDSTypeId)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.InUse && undefined !== pobjViewRegionEN.InUse && tzDataType.isBoolean(pobjViewRegionEN.InUse) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|是否在用(InUse)]的值:[$(pobjViewRegionEN.InUse)], 非法，应该为布尔型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.PrjId && undefined !== pobjViewRegionEN.PrjId && tzDataType.isString(pobjViewRegionEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|工程ID(PrjId)]的值:[$(pobjViewRegionEN.PrjId)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.UpdUser && undefined !== pobjViewRegionEN.UpdUser && tzDataType.isString(pobjViewRegionEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|修改者(UpdUser)]的值:[$(pobjViewRegionEN.UpdUser)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.UpdDate && undefined !== pobjViewRegionEN.UpdDate && tzDataType.isString(pobjViewRegionEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|修改日期(UpdDate)]的值:[$(pobjViewRegionEN.UpdDate)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.Memo && undefined !== pobjViewRegionEN.Memo && tzDataType.isString(pobjViewRegionEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|说明(Memo)]的值:[$(pobjViewRegionEN.Memo)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.IsSynchToServer && undefined !== pobjViewRegionEN.IsSynchToServer && tzDataType.isBoolean(pobjViewRegionEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|是否同步到Server(IsSynchToServer)]的值:[$(pobjViewRegionEN.IsSynchToServer)], 非法，应该为布尔型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynchToServerDate && undefined !== pobjViewRegionEN.SynchToServerDate && tzDataType.isString(pobjViewRegionEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|同步到Server日期(SynchToServerDate)]的值:[$(pobjViewRegionEN.SynchToServerDate)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynchToServerUser && undefined !== pobjViewRegionEN.SynchToServerUser && tzDataType.isString(pobjViewRegionEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|同步到Server用户(SynchToServerUser)]的值:[$(pobjViewRegionEN.SynchToServerUser)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.IsSynchToClient && undefined !== pobjViewRegionEN.IsSynchToClient && tzDataType.isBoolean(pobjViewRegionEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|是否同步到Client(IsSynchToClient)]的值:[$(pobjViewRegionEN.IsSynchToClient)], 非法，应该为布尔型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynchToClientDate && undefined !== pobjViewRegionEN.SynchToClientDate && tzDataType.isString(pobjViewRegionEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjViewRegionEN.SynchToClientDate)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynchToClientUser && undefined !== pobjViewRegionEN.SynchToClientUser && tzDataType.isString(pobjViewRegionEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjViewRegionEN.SynchToClientUser)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
if (null !== pobjViewRegionEN.SynSource && undefined !== pobjViewRegionEN.SynSource && tzDataType.isString(pobjViewRegionEN.SynSource) === false)
{
 throw new Error("(errid:Busi000156)字段[界面区域(ViewRegion)|同步来源(SynSource)]的值:[$(pobjViewRegionEN.SynSource)], 非法，应该为字符型!(clsViewRegionBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjViewRegionEN.ViewId != null && GetStrLen(pobjViewRegionEN.ViewId) !=  8)
{
 throw ("(errid:Busi000157)字段[界面区域|界面Id]作为外键字段,长度应该为8!(clsViewRegionBL:CheckPropertyNew)");
}
if (pobjViewRegionEN.RegionTypeId != null && GetStrLen(pobjViewRegionEN.RegionTypeId) !=  4)
{
 throw ("(errid:Busi000157)字段[界面区域|区域类型Id]作为外键字段,长度应该为4!(clsViewRegionBL:CheckPropertyNew)");
}
if (pobjViewRegionEN.OUTRelaTabId != null && GetStrLen(pobjViewRegionEN.OUTRelaTabId) !=  8)
{
 throw ("(errid:Busi000157)字段[界面区域|输出数据源表ID]作为外键字段,长度应该为8!(clsViewRegionBL:CheckPropertyNew)");
}
if (pobjViewRegionEN.OUTSQLDSTypeId != null && GetStrLen(pobjViewRegionEN.OUTSQLDSTypeId) !=  2)
{
 throw ("(errid:Busi000157)字段[界面区域|输出数据源类型]作为外键字段,长度应该为2!(clsViewRegionBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjViewRegionEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewRegionBL.prototype.CheckProperty4Update  = function(pobjViewRegionEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewRegionEN.RegionName && GetStrLen(pobjViewRegionEN.RegionName) > 50)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|区域名称(RegionName)]的长度不能超过50!值:$(pobjViewRegionEN.RegionName)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.ViewId && GetStrLen(pobjViewRegionEN.ViewId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|界面Id(ViewId)]的长度不能超过8!值:$(pobjViewRegionEN.ViewId)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.RegionTypeId && GetStrLen(pobjViewRegionEN.RegionTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|区域类型Id(RegionTypeId)]的长度不能超过4!值:$(pobjViewRegionEN.RegionTypeId)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.RegionFunction && GetStrLen(pobjViewRegionEN.RegionFunction) > 500)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|区域功能(RegionFunction)]的长度不能超过500!值:$(pobjViewRegionEN.RegionFunction)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.ClassName && GetStrLen(pobjViewRegionEN.ClassName) > 100)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|类名(ClassName)]的长度不能超过100!值:$(pobjViewRegionEN.ClassName)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.OUTRelaTabId && GetStrLen(pobjViewRegionEN.OUTRelaTabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|输出数据源表ID(OUTRelaTabId)]的长度不能超过8!值:$(pobjViewRegionEN.OUTRelaTabId)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.INSQLDSTypeId && GetStrLen(pobjViewRegionEN.INSQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|输入数据源类型(INSQLDSTypeId)]的长度不能超过2!值:$(pobjViewRegionEN.INSQLDSTypeId)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.INRelaTabId && GetStrLen(pobjViewRegionEN.INRelaTabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|输入数据源表ID(INRelaTabId)]的长度不能超过8!值:$(pobjViewRegionEN.INRelaTabId)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.OUTSQLDSTypeId && GetStrLen(pobjViewRegionEN.OUTSQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|输出数据源类型(OUTSQLDSTypeId)]的长度不能超过2!值:$(pobjViewRegionEN.OUTSQLDSTypeId)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.PrjId && GetStrLen(pobjViewRegionEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|工程ID(PrjId)]的长度不能超过4!值:$(pobjViewRegionEN.PrjId)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.UpdUser && GetStrLen(pobjViewRegionEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|修改者(UpdUser)]的长度不能超过20!值:$(pobjViewRegionEN.UpdUser)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.UpdDate && GetStrLen(pobjViewRegionEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjViewRegionEN.UpdDate)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.Memo && GetStrLen(pobjViewRegionEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|说明(Memo)]的长度不能超过1000!值:$(pobjViewRegionEN.Memo)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynchToServerDate && GetStrLen(pobjViewRegionEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjViewRegionEN.SynchToServerDate)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynchToServerUser && GetStrLen(pobjViewRegionEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjViewRegionEN.SynchToServerUser)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynchToClientDate && GetStrLen(pobjViewRegionEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjViewRegionEN.SynchToClientDate)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynchToClientUser && GetStrLen(pobjViewRegionEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjViewRegionEN.SynchToClientUser)(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynSource && GetStrLen(pobjViewRegionEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000158)字段[界面区域(ViewRegion)|同步来源(SynSource)]的长度不能超过50!值:$(pobjViewRegionEN.SynSource)(clsViewRegionBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewRegionEN.RegionId && undefined !== pobjViewRegionEN.RegionId && tzDataType.isNumber(pobjViewRegionEN.RegionId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|区域Id(RegionId)]的值:[$(pobjViewRegionEN.RegionId)], 非法，应该为数值型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.RegionName && undefined !== pobjViewRegionEN.RegionName && tzDataType.isString(pobjViewRegionEN.RegionName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|区域名称(RegionName)]的值:[$(pobjViewRegionEN.RegionName)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.ViewId && undefined !== pobjViewRegionEN.ViewId && tzDataType.isString(pobjViewRegionEN.ViewId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|界面Id(ViewId)]的值:[$(pobjViewRegionEN.ViewId)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.RegionTypeId && undefined !== pobjViewRegionEN.RegionTypeId && tzDataType.isString(pobjViewRegionEN.RegionTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|区域类型Id(RegionTypeId)]的值:[$(pobjViewRegionEN.RegionTypeId)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.RegionFunction && undefined !== pobjViewRegionEN.RegionFunction && tzDataType.isString(pobjViewRegionEN.RegionFunction) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|区域功能(RegionFunction)]的值:[$(pobjViewRegionEN.RegionFunction)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.ClassName && undefined !== pobjViewRegionEN.ClassName && tzDataType.isString(pobjViewRegionEN.ClassName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|类名(ClassName)]的值:[$(pobjViewRegionEN.ClassName)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.Height && undefined !== pobjViewRegionEN.Height && tzDataType.isNumber(pobjViewRegionEN.Height) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|高度(Height)]的值:[$(pobjViewRegionEN.Height)], 非法，应该为数值型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.Width && undefined !== pobjViewRegionEN.Width && tzDataType.isNumber(pobjViewRegionEN.Width) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|宽(Width)]的值:[$(pobjViewRegionEN.Width)], 非法，应该为数值型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.OUTRelaTabId && undefined !== pobjViewRegionEN.OUTRelaTabId && tzDataType.isString(pobjViewRegionEN.OUTRelaTabId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|输出数据源表ID(OUTRelaTabId)]的值:[$(pobjViewRegionEN.OUTRelaTabId)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.INSQLDSTypeId && undefined !== pobjViewRegionEN.INSQLDSTypeId && tzDataType.isString(pobjViewRegionEN.INSQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|输入数据源类型(INSQLDSTypeId)]的值:[$(pobjViewRegionEN.INSQLDSTypeId)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.INRelaTabId && undefined !== pobjViewRegionEN.INRelaTabId && tzDataType.isString(pobjViewRegionEN.INRelaTabId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|输入数据源表ID(INRelaTabId)]的值:[$(pobjViewRegionEN.INRelaTabId)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.OUTSQLDSTypeId && undefined !== pobjViewRegionEN.OUTSQLDSTypeId && tzDataType.isString(pobjViewRegionEN.OUTSQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|输出数据源类型(OUTSQLDSTypeId)]的值:[$(pobjViewRegionEN.OUTSQLDSTypeId)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.InUse && undefined !== pobjViewRegionEN.InUse && tzDataType.isBoolean(pobjViewRegionEN.InUse) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|是否在用(InUse)]的值:[$(pobjViewRegionEN.InUse)], 非法，应该为布尔型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.PrjId && undefined !== pobjViewRegionEN.PrjId && tzDataType.isString(pobjViewRegionEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|工程ID(PrjId)]的值:[$(pobjViewRegionEN.PrjId)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.UpdUser && undefined !== pobjViewRegionEN.UpdUser && tzDataType.isString(pobjViewRegionEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|修改者(UpdUser)]的值:[$(pobjViewRegionEN.UpdUser)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.UpdDate && undefined !== pobjViewRegionEN.UpdDate && tzDataType.isString(pobjViewRegionEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|修改日期(UpdDate)]的值:[$(pobjViewRegionEN.UpdDate)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.Memo && undefined !== pobjViewRegionEN.Memo && tzDataType.isString(pobjViewRegionEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|说明(Memo)]的值:[$(pobjViewRegionEN.Memo)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.IsSynchToServer && undefined !== pobjViewRegionEN.IsSynchToServer && tzDataType.isBoolean(pobjViewRegionEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|是否同步到Server(IsSynchToServer)]的值:[$(pobjViewRegionEN.IsSynchToServer)], 非法，应该为布尔型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynchToServerDate && undefined !== pobjViewRegionEN.SynchToServerDate && tzDataType.isString(pobjViewRegionEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|同步到Server日期(SynchToServerDate)]的值:[$(pobjViewRegionEN.SynchToServerDate)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynchToServerUser && undefined !== pobjViewRegionEN.SynchToServerUser && tzDataType.isString(pobjViewRegionEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|同步到Server用户(SynchToServerUser)]的值:[$(pobjViewRegionEN.SynchToServerUser)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.IsSynchToClient && undefined !== pobjViewRegionEN.IsSynchToClient && tzDataType.isBoolean(pobjViewRegionEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|是否同步到Client(IsSynchToClient)]的值:[$(pobjViewRegionEN.IsSynchToClient)], 非法，应该为布尔型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynchToClientDate && undefined !== pobjViewRegionEN.SynchToClientDate && tzDataType.isString(pobjViewRegionEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjViewRegionEN.SynchToClientDate)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynchToClientUser && undefined !== pobjViewRegionEN.SynchToClientUser && tzDataType.isString(pobjViewRegionEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjViewRegionEN.SynchToClientUser)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
if (null !== pobjViewRegionEN.SynSource && undefined !== pobjViewRegionEN.SynSource && tzDataType.isString(pobjViewRegionEN.SynSource) === false)
{
 throw new Error("(errid:Busi000159)字段[界面区域(ViewRegion)|同步来源(SynSource)]的值:[$(pobjViewRegionEN.SynSource)], 非法，应该为字符型!(clsViewRegionBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjViewRegionEN.RegionId 
 || null !== pobjViewRegionEN.RegionId && pobjViewRegionEN.RegionId.toString()  ===  "")
{
 throw new Error("(errid:Busi000160)字段[界面区域|区域Id]不能为空(NULL)!(clsViewRegionBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjViewRegionEN.ViewId != null && GetStrLen(pobjViewRegionEN.ViewId) !=  8)
{
 throw ("(errid:Busi000161)字段[界面区域|界面Id]作为外键字段,长度应该为8!(clsViewRegionBL:CheckPropertyNew)");
}
if (pobjViewRegionEN.RegionTypeId != null && GetStrLen(pobjViewRegionEN.RegionTypeId) !=  4)
{
 throw ("(errid:Busi000161)字段[界面区域|区域类型Id]作为外键字段,长度应该为4!(clsViewRegionBL:CheckPropertyNew)");
}
if (pobjViewRegionEN.OUTRelaTabId != null && GetStrLen(pobjViewRegionEN.OUTRelaTabId) !=  8)
{
 throw ("(errid:Busi000161)字段[界面区域|输出数据源表ID]作为外键字段,长度应该为8!(clsViewRegionBL:CheckPropertyNew)");
}
if (pobjViewRegionEN.OUTSQLDSTypeId != null && GetStrLen(pobjViewRegionEN.OUTSQLDSTypeId) !=  2)
{
 throw ("(errid:Busi000161)字段[界面区域|输出数据源类型]作为外键字段,长度应该为2!(clsViewRegionBL:CheckPropertyNew)");
}

 pobjViewRegionEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024922
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewRegionBL.GetJSONStrByObj  = function(pobjViewRegionEN)
{
pobjViewRegionEN.sf_UpdFldSetStr = pobjViewRegionEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjViewRegionEN);
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
 /// 日期:20200501024922
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsViewRegionBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrViewRegionObjLst = new Array();
if (strJSON === "")
{
return arrViewRegionObjLst;
}
try
{
arrViewRegionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrViewRegionObjLst;
}
return arrViewRegionObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024922
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewRegionBL.GetObjByJSONStr  = function(strJSON)
{
var pobjViewRegionEN = new clsViewRegionEN();
if (strJSON === "")
{
return pobjViewRegionEN;
}
try
{
pobjViewRegionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjViewRegionEN;
}
return pobjViewRegionEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objViewRegionENS">源简化对象</param>
 /// <param name = "objViewRegionENT">目标对象</param>
clsViewRegionBL.CopyObjFromSimObj = function(objViewRegionENS, objViewRegionENT) 
{
objViewRegionENT.RegionId = objViewRegionENS.RegionId; //区域Id
objViewRegionENT.RegionName = objViewRegionENS.RegionName; //区域名称
objViewRegionENT.ViewId = objViewRegionENS.ViewId; //界面Id
objViewRegionENT.RegionTypeId = objViewRegionENS.RegionTypeId; //区域类型Id
objViewRegionENT.RegionFunction = objViewRegionENS.RegionFunction; //区域功能
objViewRegionENT.ClassName = objViewRegionENS.ClassName; //类名
objViewRegionENT.Height = objViewRegionENS.Height; //高度
objViewRegionENT.Width = objViewRegionENS.Width; //宽
objViewRegionENT.OUTRelaTabId = objViewRegionENS.OUTRelaTabId; //输出数据源表ID
objViewRegionENT.INSQLDSTypeId = objViewRegionENS.INSQLDSTypeId; //输入数据源类型
objViewRegionENT.INRelaTabId = objViewRegionENS.INRelaTabId; //输入数据源表ID
objViewRegionENT.OUTSQLDSTypeId = objViewRegionENS.OUTSQLDSTypeId; //输出数据源类型
objViewRegionENT.InUse = objViewRegionENS.InUse; //是否在用
objViewRegionENT.PrjId = objViewRegionENS.PrjId; //工程ID
objViewRegionENT.UpdUser = objViewRegionENS.UpdUser; //修改者
objViewRegionENT.UpdDate = objViewRegionENS.UpdDate; //修改日期
objViewRegionENT.Memo = objViewRegionENS.Memo; //说明
objViewRegionENT.IsSynchToServer = objViewRegionENS.IsSynchToServer; //是否同步到Server
objViewRegionENT.SynchToServerDate = objViewRegionENS.SynchToServerDate; //同步到Server日期
objViewRegionENT.SynchToServerUser = objViewRegionENS.SynchToServerUser; //同步到Server用户
objViewRegionENT.IsSynchToClient = objViewRegionENS.IsSynchToClient; //是否同步到Client
objViewRegionENT.SynchToClientDate = objViewRegionENS.SynchToClientDate; //同步到Client库日期
objViewRegionENT.SynchToClientUser = objViewRegionENS.SynchToClientUser; //同步到Client库用户
objViewRegionENT.SynSource = objViewRegionENS.SynSource; //同步来源
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objViewRegionENS">源对象</param>
 /// <param name = "objViewRegionENT">目标对象</param>
clsViewRegionBL.CopyObjTo = function(objViewRegionENS , objViewRegionENT ) 
{
objViewRegionENT.RegionId = objViewRegionENS.RegionId; //区域Id
objViewRegionENT.RegionName = objViewRegionENS.RegionName; //区域名称
objViewRegionENT.ViewId = objViewRegionENS.ViewId; //界面Id
objViewRegionENT.RegionTypeId = objViewRegionENS.RegionTypeId; //区域类型Id
objViewRegionENT.RegionFunction = objViewRegionENS.RegionFunction; //区域功能
objViewRegionENT.ClassName = objViewRegionENS.ClassName; //类名
objViewRegionENT.Height = objViewRegionENS.Height; //高度
objViewRegionENT.Width = objViewRegionENS.Width; //宽
objViewRegionENT.OUTRelaTabId = objViewRegionENS.OUTRelaTabId; //输出数据源表ID
objViewRegionENT.INSQLDSTypeId = objViewRegionENS.INSQLDSTypeId; //输入数据源类型
objViewRegionENT.INRelaTabId = objViewRegionENS.INRelaTabId; //输入数据源表ID
objViewRegionENT.OUTSQLDSTypeId = objViewRegionENS.OUTSQLDSTypeId; //输出数据源类型
objViewRegionENT.InUse = objViewRegionENS.InUse; //是否在用
objViewRegionENT.PrjId = objViewRegionENS.PrjId; //工程ID
objViewRegionENT.UpdUser = objViewRegionENS.UpdUser; //修改者
objViewRegionENT.UpdDate = objViewRegionENS.UpdDate; //修改日期
objViewRegionENT.Memo = objViewRegionENS.Memo; //说明
objViewRegionENT.IsSynchToServer = objViewRegionENS.IsSynchToServer; //是否同步到Server
objViewRegionENT.SynchToServerDate = objViewRegionENS.SynchToServerDate; //同步到Server日期
objViewRegionENT.SynchToServerUser = objViewRegionENS.SynchToServerUser; //同步到Server用户
objViewRegionENT.IsSynchToClient = objViewRegionENS.IsSynchToClient; //是否同步到Client
objViewRegionENT.SynchToClientDate = objViewRegionENS.SynchToClientDate; //同步到Client库日期
objViewRegionENT.SynchToClientUser = objViewRegionENS.SynchToClientUser; //同步到Client库用户
objViewRegionENT.SynSource = objViewRegionENS.SynSource; //同步来源
objViewRegionENT.sf_UpdFldSetStr = objViewRegionENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objViewRegionENS">源对象</param>
 /// <param name = "objViewRegionENT">目标对象</param>
clsViewRegionBL.CopyObjToSimObj = function(objViewRegionENS , objViewRegionENT ) 
{
objViewRegionENT.RegionId = objViewRegionENS.RegionId; //区域Id
objViewRegionENT.RegionName = objViewRegionENS.RegionName; //区域名称
objViewRegionENT.ViewId = objViewRegionENS.ViewId; //界面Id
objViewRegionENT.RegionTypeId = objViewRegionENS.RegionTypeId; //区域类型Id
objViewRegionENT.RegionFunction = objViewRegionENS.RegionFunction; //区域功能
objViewRegionENT.ClassName = objViewRegionENS.ClassName; //类名
objViewRegionENT.Height = objViewRegionENS.Height; //高度
objViewRegionENT.Width = objViewRegionENS.Width; //宽
objViewRegionENT.OUTRelaTabId = objViewRegionENS.OUTRelaTabId; //输出数据源表ID
objViewRegionENT.INSQLDSTypeId = objViewRegionENS.INSQLDSTypeId; //输入数据源类型
objViewRegionENT.INRelaTabId = objViewRegionENS.INRelaTabId; //输入数据源表ID
objViewRegionENT.OUTSQLDSTypeId = objViewRegionENS.OUTSQLDSTypeId; //输出数据源类型
objViewRegionENT.InUse = objViewRegionENS.InUse; //是否在用
objViewRegionENT.PrjId = objViewRegionENS.PrjId; //工程ID
objViewRegionENT.UpdUser = objViewRegionENS.UpdUser; //修改者
objViewRegionENT.UpdDate = objViewRegionENS.UpdDate; //修改日期
objViewRegionENT.Memo = objViewRegionENS.Memo; //说明
objViewRegionENT.IsSynchToServer = objViewRegionENS.IsSynchToServer; //是否同步到Server
objViewRegionENT.SynchToServerDate = objViewRegionENS.SynchToServerDate; //同步到Server日期
objViewRegionENT.SynchToServerUser = objViewRegionENS.SynchToServerUser; //同步到Server用户
objViewRegionENT.IsSynchToClient = objViewRegionENS.IsSynchToClient; //是否同步到Client
objViewRegionENT.SynchToClientDate = objViewRegionENS.SynchToClientDate; //同步到Client库日期
objViewRegionENT.SynchToClientUser = objViewRegionENS.SynchToClientUser; //同步到Client库用户
objViewRegionENT.SynSource = objViewRegionENS.SynSource; //同步来源
objViewRegionENT.sf_UpdFldSetStr = objViewRegionENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewRegionENT.sf_FldComparisonOp = objViewRegionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objViewRegionENS">源简化对象</param>
 /// <param name = "objViewRegionENT">目标对象</param>
clsViewRegionBL.CopyObjFromSimObj4Upd = function(objViewRegionENS, objViewRegionENT )
 {
   var strsf_UpdFldSetStr = objViewRegionENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsViewRegionEN.con_RegionId)  >= 0)
{
objViewRegionENT.RegionId = objViewRegionENS.RegionId; //区域Id
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_RegionName)  >= 0)
{
objViewRegionENT.RegionName = objViewRegionENS.RegionName; //区域名称
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_ViewId)  >= 0)
{
objViewRegionENT.ViewId = objViewRegionENS.ViewId; //界面Id
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_RegionTypeId)  >= 0)
{
objViewRegionENT.RegionTypeId = objViewRegionENS.RegionTypeId; //区域类型Id
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_RegionFunction)  >= 0)
{
objViewRegionENT.RegionFunction = objViewRegionENS.RegionFunction; //区域功能
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_ClassName)  >= 0)
{
objViewRegionENT.ClassName = objViewRegionENS.ClassName; //类名
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_Height)  >= 0)
{
objViewRegionENT.Height = objViewRegionENS.Height; //高度
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_Width)  >= 0)
{
objViewRegionENT.Width = objViewRegionENS.Width; //宽
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_OUTRelaTabId)  >= 0)
{
objViewRegionENT.OUTRelaTabId = objViewRegionENS.OUTRelaTabId; //输出数据源表ID
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_INSQLDSTypeId)  >= 0)
{
objViewRegionENT.INSQLDSTypeId = objViewRegionENS.INSQLDSTypeId; //输入数据源类型
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_INRelaTabId)  >= 0)
{
objViewRegionENT.INRelaTabId = objViewRegionENS.INRelaTabId; //输入数据源表ID
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_OUTSQLDSTypeId)  >= 0)
{
objViewRegionENT.OUTSQLDSTypeId = objViewRegionENS.OUTSQLDSTypeId; //输出数据源类型
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_InUse)  >= 0)
{
objViewRegionENT.InUse = objViewRegionENS.InUse; //是否在用
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_PrjId)  >= 0)
{
objViewRegionENT.PrjId = objViewRegionENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_UpdUser)  >= 0)
{
objViewRegionENT.UpdUser = objViewRegionENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_UpdDate)  >= 0)
{
objViewRegionENT.UpdDate = objViewRegionENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_Memo)  >= 0)
{
objViewRegionENT.Memo = objViewRegionENS.Memo; //说明
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_IsSynchToServer)  >= 0)
{
objViewRegionENT.IsSynchToServer = objViewRegionENS.IsSynchToServer; //是否同步到Server
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_SynchToServerDate)  >= 0)
{
objViewRegionENT.SynchToServerDate = objViewRegionENS.SynchToServerDate; //同步到Server日期
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_SynchToServerUser)  >= 0)
{
objViewRegionENT.SynchToServerUser = objViewRegionENS.SynchToServerUser; //同步到Server用户
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_IsSynchToClient)  >= 0)
{
objViewRegionENT.IsSynchToClient = objViewRegionENS.IsSynchToClient; //是否同步到Client
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_SynchToClientDate)  >= 0)
{
objViewRegionENT.SynchToClientDate = objViewRegionENS.SynchToClientDate; //同步到Client库日期
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_SynchToClientUser)  >= 0)
{
objViewRegionENT.SynchToClientUser = objViewRegionENS.SynchToClientUser; //同步到Client库用户
}
if (sstrFldSet.indexOf(clsViewRegionEN.con_SynSource)  >= 0)
{
objViewRegionENT.SynSource = objViewRegionENS.SynSource; //同步来源
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objViewRegionENS">源对象</param>
 /// <param name = "objViewRegionENT">目标对象</param>
clsViewRegionBL.GetSimObjFromObj = function(objViewRegionENS)
{
var objViewRegionENT = new clsViewRegionEN_Sim_js_1.clsViewRegionEN_Sim();
objViewRegionENT.RegionId = objViewRegionENS.RegionId; //区域Id
objViewRegionENT.RegionName = objViewRegionENS.RegionName; //区域名称
objViewRegionENT.ViewId = objViewRegionENS.ViewId; //界面Id
objViewRegionENT.RegionTypeId = objViewRegionENS.RegionTypeId; //区域类型Id
objViewRegionENT.RegionFunction = objViewRegionENS.RegionFunction; //区域功能
objViewRegionENT.ClassName = objViewRegionENS.ClassName; //类名
objViewRegionENT.Height = objViewRegionENS.Height; //高度
objViewRegionENT.Width = objViewRegionENS.Width; //宽
objViewRegionENT.OUTRelaTabId = objViewRegionENS.OUTRelaTabId; //输出数据源表ID
objViewRegionENT.INSQLDSTypeId = objViewRegionENS.INSQLDSTypeId; //输入数据源类型
objViewRegionENT.INRelaTabId = objViewRegionENS.INRelaTabId; //输入数据源表ID
objViewRegionENT.OUTSQLDSTypeId = objViewRegionENS.OUTSQLDSTypeId; //输出数据源类型
objViewRegionENT.InUse = objViewRegionENS.InUse; //是否在用
objViewRegionENT.PrjId = objViewRegionENS.PrjId; //工程ID
objViewRegionENT.UpdUser = objViewRegionENS.UpdUser; //修改者
objViewRegionENT.UpdDate = objViewRegionENS.UpdDate; //修改日期
objViewRegionENT.Memo = objViewRegionENS.Memo; //说明
objViewRegionENT.IsSynchToServer = objViewRegionENS.IsSynchToServer; //是否同步到Server
objViewRegionENT.SynchToServerDate = objViewRegionENS.SynchToServerDate; //同步到Server日期
objViewRegionENT.SynchToServerUser = objViewRegionENS.SynchToServerUser; //同步到Server用户
objViewRegionENT.IsSynchToClient = objViewRegionENS.IsSynchToClient; //是否同步到Client
objViewRegionENT.SynchToClientDate = objViewRegionENS.SynchToClientDate; //同步到Client库日期
objViewRegionENT.SynchToClientUser = objViewRegionENS.SynchToClientUser; //同步到Client库用户
objViewRegionENT.SynSource = objViewRegionENS.SynSource; //同步来源
objViewRegionENT.sf_UpdFldSetStr = objViewRegionENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewRegionENT.sf_FldComparisonOp = objViewRegionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objViewRegionENT;
}
return clsViewRegionBL;
}());
exports.clsViewRegionBL = clsViewRegionBL;
});