
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewInfoBL
 表名:ViewInfo(00050006)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:17
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsViewInfoEN.js","../../L0_Entity/PrjInterface/clsViewInfoEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsViewInfoEN_js_1 = require("../../L0_Entity/PrjInterface/clsViewInfoEN.js");
var clsViewInfoEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsViewInfoEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 界面(ViewInfo)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsViewInfoBL = /** @class */ (function () {
function clsViewInfoBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrViewInfoObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewInfoBL.prototype.CheckPropertyNew = function(pobjViewInfoEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjViewInfoEN.ViewName 
 || null !== pobjViewInfoEN.ViewName && pobjViewInfoEN.ViewName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面|界面名称]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.ViewTypeCode 
 || null !== pobjViewInfoEN.ViewTypeCode && pobjViewInfoEN.ViewTypeCode.toString()  ===  ""
 || null !== pobjViewInfoEN.ViewTypeCode && pobjViewInfoEN.ViewTypeCode.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面|界面类型码]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.IsNeedSort 
 || null !== pobjViewInfoEN.IsNeedSort && pobjViewInfoEN.IsNeedSort.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面|是否需要排序]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.IsNeedTransCode 
 || null !== pobjViewInfoEN.IsNeedTransCode && pobjViewInfoEN.IsNeedTransCode.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面|是否需要转换代码]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.IsNeedSetExportFld 
 || null !== pobjViewInfoEN.IsNeedSetExportFld && pobjViewInfoEN.IsNeedSetExportFld.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面|是否需要设置导出字段]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.UserId 
 || null !== pobjViewInfoEN.UserId && pobjViewInfoEN.UserId.toString()  ===  ""
 || null !== pobjViewInfoEN.UserId && pobjViewInfoEN.UserId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面|用户Id]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.PrjId 
 || null !== pobjViewInfoEN.PrjId && pobjViewInfoEN.PrjId.toString()  ===  ""
 || null !== pobjViewInfoEN.PrjId && pobjViewInfoEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面|工程ID]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.DefaMenuName 
 || null !== pobjViewInfoEN.DefaMenuName && pobjViewInfoEN.DefaMenuName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面|缺省菜单名]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.FileName 
 || null !== pobjViewInfoEN.FileName && pobjViewInfoEN.FileName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面|文件名]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.FilePath 
 || null !== pobjViewInfoEN.FilePath && pobjViewInfoEN.FilePath.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面|文件路径]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
if (null === pobjViewInfoEN.ViewCnName 
 || null !== pobjViewInfoEN.ViewCnName && pobjViewInfoEN.ViewCnName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面|视图中文名]不能为空(NULL)!(clsViewInfoBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewInfoEN.ViewId && GetStrLen(pobjViewInfoEN.ViewId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|界面Id(ViewId)]的长度不能超过8!值:$(pobjViewInfoEN.ViewId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewName && GetStrLen(pobjViewInfoEN.ViewName) > 100)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|界面名称(ViewName)]的长度不能超过100!值:$(pobjViewInfoEN.ViewName)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.FuncModuleAgcId && GetStrLen(pobjViewInfoEN.FuncModuleAgcId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|功能模块Id(FuncModuleAgcId)]的长度不能超过8!值:$(pobjViewInfoEN.FuncModuleAgcId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DataBaseName && GetStrLen(pobjViewInfoEN.DataBaseName) > 50)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|数据库名(DataBaseName)]的长度不能超过50!值:$(pobjViewInfoEN.DataBaseName)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.KeyForMainTab && GetStrLen(pobjViewInfoEN.KeyForMainTab) > 50)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|主表关键字(KeyForMainTab)]的长度不能超过50!值:$(pobjViewInfoEN.KeyForMainTab)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.KeyForDetailTab && GetStrLen(pobjViewInfoEN.KeyForDetailTab) > 50)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|明细表关键字(KeyForDetailTab)]的长度不能超过50!值:$(pobjViewInfoEN.KeyForDetailTab)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.UserId && GetStrLen(pobjViewInfoEN.UserId) > 18)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|用户Id(UserId)]的长度不能超过18!值:$(pobjViewInfoEN.UserId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.PrjId && GetStrLen(pobjViewInfoEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|工程ID(PrjId)]的长度不能超过4!值:$(pobjViewInfoEN.PrjId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewFunction && GetStrLen(pobjViewInfoEN.ViewFunction) > 100)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|界面功能(ViewFunction)]的长度不能超过100!值:$(pobjViewInfoEN.ViewFunction)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewDetail && GetStrLen(pobjViewInfoEN.ViewDetail) > 1000)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|界面说明(ViewDetail)]的长度不能超过1000!值:$(pobjViewInfoEN.ViewDetail)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DefaMenuName && GetStrLen(pobjViewInfoEN.DefaMenuName) > 100)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|缺省菜单名(DefaMenuName)]的长度不能超过100!值:$(pobjViewInfoEN.DefaMenuName)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DetailTabId && GetStrLen(pobjViewInfoEN.DetailTabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|明细表ID(DetailTabId)]的长度不能超过8!值:$(pobjViewInfoEN.DetailTabId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.FileName && GetStrLen(pobjViewInfoEN.FileName) > 150)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|文件名(FileName)]的长度不能超过150!值:$(pobjViewInfoEN.FileName)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.FilePath && GetStrLen(pobjViewInfoEN.FilePath) > 500)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|文件路径(FilePath)]的长度不能超过500!值:$(pobjViewInfoEN.FilePath)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.MainTabId && GetStrLen(pobjViewInfoEN.MainTabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|主表ID(MainTabId)]的长度不能超过8!值:$(pobjViewInfoEN.MainTabId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewCnName && GetStrLen(pobjViewInfoEN.ViewCnName) > 100)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|视图中文名(ViewCnName)]的长度不能超过100!值:$(pobjViewInfoEN.ViewCnName)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewGroupId && GetStrLen(pobjViewInfoEN.ViewGroupId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|界面组ID(ViewGroupId)]的长度不能超过8!值:$(pobjViewInfoEN.ViewGroupId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.INRelaTabId && GetStrLen(pobjViewInfoEN.INRelaTabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|输入数据源表ID(INRelaTabId)]的长度不能超过8!值:$(pobjViewInfoEN.INRelaTabId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.INSQLDSTypeId && GetStrLen(pobjViewInfoEN.INSQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|输入数据源类型(INSQLDSTypeId)]的长度不能超过2!值:$(pobjViewInfoEN.INSQLDSTypeId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.OUTRelaTabId && GetStrLen(pobjViewInfoEN.OUTRelaTabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|输出数据源表ID(OUTRelaTabId)]的长度不能超过8!值:$(pobjViewInfoEN.OUTRelaTabId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.OUTSQLDSTypeId && GetStrLen(pobjViewInfoEN.OUTSQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|输出数据源类型(OUTSQLDSTypeId)]的长度不能超过2!值:$(pobjViewInfoEN.OUTSQLDSTypeId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DetailTabType && GetStrLen(pobjViewInfoEN.DetailTabType) > 10)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|DetailTabType(DetailTabType)]的长度不能超过10!值:$(pobjViewInfoEN.DetailTabType)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DetailViewId && GetStrLen(pobjViewInfoEN.DetailViewId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|DetailViewId(DetailViewId)]的长度不能超过8!值:$(pobjViewInfoEN.DetailViewId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.MainTabType && GetStrLen(pobjViewInfoEN.MainTabType) > 10)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|MainTabType(MainTabType)]的长度不能超过10!值:$(pobjViewInfoEN.MainTabType)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.MainViewId && GetStrLen(pobjViewInfoEN.MainViewId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|MainViewId(MainViewId)]的长度不能超过8!值:$(pobjViewInfoEN.MainViewId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.GeneCodeDate && GetStrLen(pobjViewInfoEN.GeneCodeDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|生成代码日期(GeneCodeDate)]的长度不能超过20!值:$(pobjViewInfoEN.GeneCodeDate)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.TaskId && GetStrLen(pobjViewInfoEN.TaskId) > 16)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|任务Id(TaskId)]的长度不能超过16!值:$(pobjViewInfoEN.TaskId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.UpdDate && GetStrLen(pobjViewInfoEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjViewInfoEN.UpdDate)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.UpdUserId && GetStrLen(pobjViewInfoEN.UpdUserId) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|修改用户Id(UpdUserId)]的长度不能超过20!值:$(pobjViewInfoEN.UpdUserId)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.Memo && GetStrLen(pobjViewInfoEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|说明(Memo)]的长度不能超过1000!值:$(pobjViewInfoEN.Memo)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynchToServerDate && GetStrLen(pobjViewInfoEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjViewInfoEN.SynchToServerDate)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynchToServerUser && GetStrLen(pobjViewInfoEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjViewInfoEN.SynchToServerUser)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynchToClientDate && GetStrLen(pobjViewInfoEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjViewInfoEN.SynchToClientDate)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynchToClientUser && GetStrLen(pobjViewInfoEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjViewInfoEN.SynchToClientUser)(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynSource && GetStrLen(pobjViewInfoEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000155)字段[界面(ViewInfo)|同步来源(SynSource)]的长度不能超过50!值:$(pobjViewInfoEN.SynSource)(clsViewInfoBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewInfoEN.ViewId && undefined !== pobjViewInfoEN.ViewId && tzDataType.isString(pobjViewInfoEN.ViewId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|界面Id(ViewId)]的值:[$(pobjViewInfoEN.ViewId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewName && undefined !== pobjViewInfoEN.ViewName && tzDataType.isString(pobjViewInfoEN.ViewName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|界面名称(ViewName)]的值:[$(pobjViewInfoEN.ViewName)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewTypeCode && undefined !== pobjViewInfoEN.ViewTypeCode && tzDataType.isNumber(pobjViewInfoEN.ViewTypeCode) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|界面类型码(ViewTypeCode)]的值:[$(pobjViewInfoEN.ViewTypeCode)], 非法，应该为数值型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ApplicationTypeId && undefined !== pobjViewInfoEN.ApplicationTypeId && tzDataType.isNumber(pobjViewInfoEN.ApplicationTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|应用程序类型ID(ApplicationTypeId)]的值:[$(pobjViewInfoEN.ApplicationTypeId)], 非法，应该为数值型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.FuncModuleAgcId && undefined !== pobjViewInfoEN.FuncModuleAgcId && tzDataType.isString(pobjViewInfoEN.FuncModuleAgcId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|功能模块Id(FuncModuleAgcId)]的值:[$(pobjViewInfoEN.FuncModuleAgcId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DataBaseName && undefined !== pobjViewInfoEN.DataBaseName && tzDataType.isString(pobjViewInfoEN.DataBaseName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|数据库名(DataBaseName)]的值:[$(pobjViewInfoEN.DataBaseName)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.KeyForMainTab && undefined !== pobjViewInfoEN.KeyForMainTab && tzDataType.isString(pobjViewInfoEN.KeyForMainTab) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|主表关键字(KeyForMainTab)]的值:[$(pobjViewInfoEN.KeyForMainTab)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.KeyForDetailTab && undefined !== pobjViewInfoEN.KeyForDetailTab && tzDataType.isString(pobjViewInfoEN.KeyForDetailTab) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|明细表关键字(KeyForDetailTab)]的值:[$(pobjViewInfoEN.KeyForDetailTab)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.IsNeedSort && undefined !== pobjViewInfoEN.IsNeedSort && tzDataType.isBoolean(pobjViewInfoEN.IsNeedSort) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|是否需要排序(IsNeedSort)]的值:[$(pobjViewInfoEN.IsNeedSort)], 非法，应该为布尔型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.IsNeedTransCode && undefined !== pobjViewInfoEN.IsNeedTransCode && tzDataType.isBoolean(pobjViewInfoEN.IsNeedTransCode) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|是否需要转换代码(IsNeedTransCode)]的值:[$(pobjViewInfoEN.IsNeedTransCode)], 非法，应该为布尔型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.IsNeedSetExportFld && undefined !== pobjViewInfoEN.IsNeedSetExportFld && tzDataType.isBoolean(pobjViewInfoEN.IsNeedSetExportFld) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|是否需要设置导出字段(IsNeedSetExportFld)]的值:[$(pobjViewInfoEN.IsNeedSetExportFld)], 非法，应该为布尔型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.UserId && undefined !== pobjViewInfoEN.UserId && tzDataType.isString(pobjViewInfoEN.UserId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|用户Id(UserId)]的值:[$(pobjViewInfoEN.UserId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.PrjId && undefined !== pobjViewInfoEN.PrjId && tzDataType.isString(pobjViewInfoEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|工程ID(PrjId)]的值:[$(pobjViewInfoEN.PrjId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewFunction && undefined !== pobjViewInfoEN.ViewFunction && tzDataType.isString(pobjViewInfoEN.ViewFunction) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|界面功能(ViewFunction)]的值:[$(pobjViewInfoEN.ViewFunction)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewDetail && undefined !== pobjViewInfoEN.ViewDetail && tzDataType.isString(pobjViewInfoEN.ViewDetail) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|界面说明(ViewDetail)]的值:[$(pobjViewInfoEN.ViewDetail)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DefaMenuName && undefined !== pobjViewInfoEN.DefaMenuName && tzDataType.isString(pobjViewInfoEN.DefaMenuName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|缺省菜单名(DefaMenuName)]的值:[$(pobjViewInfoEN.DefaMenuName)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DetailTabId && undefined !== pobjViewInfoEN.DetailTabId && tzDataType.isString(pobjViewInfoEN.DetailTabId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|明细表ID(DetailTabId)]的值:[$(pobjViewInfoEN.DetailTabId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.FileName && undefined !== pobjViewInfoEN.FileName && tzDataType.isString(pobjViewInfoEN.FileName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|文件名(FileName)]的值:[$(pobjViewInfoEN.FileName)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.FilePath && undefined !== pobjViewInfoEN.FilePath && tzDataType.isString(pobjViewInfoEN.FilePath) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|文件路径(FilePath)]的值:[$(pobjViewInfoEN.FilePath)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.MainTabId && undefined !== pobjViewInfoEN.MainTabId && tzDataType.isString(pobjViewInfoEN.MainTabId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|主表ID(MainTabId)]的值:[$(pobjViewInfoEN.MainTabId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewCnName && undefined !== pobjViewInfoEN.ViewCnName && tzDataType.isString(pobjViewInfoEN.ViewCnName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|视图中文名(ViewCnName)]的值:[$(pobjViewInfoEN.ViewCnName)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.ViewGroupId && undefined !== pobjViewInfoEN.ViewGroupId && tzDataType.isString(pobjViewInfoEN.ViewGroupId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|界面组ID(ViewGroupId)]的值:[$(pobjViewInfoEN.ViewGroupId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.INRelaTabId && undefined !== pobjViewInfoEN.INRelaTabId && tzDataType.isString(pobjViewInfoEN.INRelaTabId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|输入数据源表ID(INRelaTabId)]的值:[$(pobjViewInfoEN.INRelaTabId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.INSQLDSTypeId && undefined !== pobjViewInfoEN.INSQLDSTypeId && tzDataType.isString(pobjViewInfoEN.INSQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|输入数据源类型(INSQLDSTypeId)]的值:[$(pobjViewInfoEN.INSQLDSTypeId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.OUTRelaTabId && undefined !== pobjViewInfoEN.OUTRelaTabId && tzDataType.isString(pobjViewInfoEN.OUTRelaTabId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|输出数据源表ID(OUTRelaTabId)]的值:[$(pobjViewInfoEN.OUTRelaTabId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.OUTSQLDSTypeId && undefined !== pobjViewInfoEN.OUTSQLDSTypeId && tzDataType.isString(pobjViewInfoEN.OUTSQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|输出数据源类型(OUTSQLDSTypeId)]的值:[$(pobjViewInfoEN.OUTSQLDSTypeId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DetailTabType && undefined !== pobjViewInfoEN.DetailTabType && tzDataType.isString(pobjViewInfoEN.DetailTabType) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|DetailTabType(DetailTabType)]的值:[$(pobjViewInfoEN.DetailTabType)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.DetailViewId && undefined !== pobjViewInfoEN.DetailViewId && tzDataType.isString(pobjViewInfoEN.DetailViewId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|DetailViewId(DetailViewId)]的值:[$(pobjViewInfoEN.DetailViewId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.MainTabType && undefined !== pobjViewInfoEN.MainTabType && tzDataType.isString(pobjViewInfoEN.MainTabType) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|MainTabType(MainTabType)]的值:[$(pobjViewInfoEN.MainTabType)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.IsUseCache4List && undefined !== pobjViewInfoEN.IsUseCache4List && tzDataType.isBoolean(pobjViewInfoEN.IsUseCache4List) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|是否使用缓存列表(IsUseCache4List)]的值:[$(pobjViewInfoEN.IsUseCache4List)], 非法，应该为布尔型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.MainViewId && undefined !== pobjViewInfoEN.MainViewId && tzDataType.isString(pobjViewInfoEN.MainViewId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|MainViewId(MainViewId)]的值:[$(pobjViewInfoEN.MainViewId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.GeneCodeDate && undefined !== pobjViewInfoEN.GeneCodeDate && tzDataType.isString(pobjViewInfoEN.GeneCodeDate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|生成代码日期(GeneCodeDate)]的值:[$(pobjViewInfoEN.GeneCodeDate)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.TaskId && undefined !== pobjViewInfoEN.TaskId && tzDataType.isString(pobjViewInfoEN.TaskId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|任务Id(TaskId)]的值:[$(pobjViewInfoEN.TaskId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.RegionNum && undefined !== pobjViewInfoEN.RegionNum && tzDataType.isNumber(pobjViewInfoEN.RegionNum) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|区域数(RegionNum)]的值:[$(pobjViewInfoEN.RegionNum)], 非法，应该为数值型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.UpdDate && undefined !== pobjViewInfoEN.UpdDate && tzDataType.isString(pobjViewInfoEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|修改日期(UpdDate)]的值:[$(pobjViewInfoEN.UpdDate)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.UpdUserId && undefined !== pobjViewInfoEN.UpdUserId && tzDataType.isString(pobjViewInfoEN.UpdUserId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|修改用户Id(UpdUserId)]的值:[$(pobjViewInfoEN.UpdUserId)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.Memo && undefined !== pobjViewInfoEN.Memo && tzDataType.isString(pobjViewInfoEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|说明(Memo)]的值:[$(pobjViewInfoEN.Memo)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.IsSynchToServer && undefined !== pobjViewInfoEN.IsSynchToServer && tzDataType.isBoolean(pobjViewInfoEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|是否同步到Server(IsSynchToServer)]的值:[$(pobjViewInfoEN.IsSynchToServer)], 非法，应该为布尔型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynchToServerDate && undefined !== pobjViewInfoEN.SynchToServerDate && tzDataType.isString(pobjViewInfoEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|同步到Server日期(SynchToServerDate)]的值:[$(pobjViewInfoEN.SynchToServerDate)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynchToServerUser && undefined !== pobjViewInfoEN.SynchToServerUser && tzDataType.isString(pobjViewInfoEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|同步到Server用户(SynchToServerUser)]的值:[$(pobjViewInfoEN.SynchToServerUser)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.IsSynchToClient && undefined !== pobjViewInfoEN.IsSynchToClient && tzDataType.isBoolean(pobjViewInfoEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|是否同步到Client(IsSynchToClient)]的值:[$(pobjViewInfoEN.IsSynchToClient)], 非法，应该为布尔型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynchToClientDate && undefined !== pobjViewInfoEN.SynchToClientDate && tzDataType.isString(pobjViewInfoEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjViewInfoEN.SynchToClientDate)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynchToClientUser && undefined !== pobjViewInfoEN.SynchToClientUser && tzDataType.isString(pobjViewInfoEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjViewInfoEN.SynchToClientUser)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
if (null !== pobjViewInfoEN.SynSource && undefined !== pobjViewInfoEN.SynSource && tzDataType.isString(pobjViewInfoEN.SynSource) === false)
{
 throw new Error("(errid:Busi000156)字段[界面(ViewInfo)|同步来源(SynSource)]的值:[$(pobjViewInfoEN.SynSource)], 非法，应该为字符型!(clsViewInfoBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjViewInfoEN.FuncModuleAgcId != null && GetStrLen(pobjViewInfoEN.FuncModuleAgcId) !=  8)
{
 throw ("(errid:Busi000157)字段[界面|功能模块Id]作为外键字段,长度应该为8!(clsViewInfoBL:CheckPropertyNew)");
}
if (pobjViewInfoEN.PrjId != null && GetStrLen(pobjViewInfoEN.PrjId) !=  4)
{
 throw ("(errid:Busi000157)字段[界面|工程ID]作为外键字段,长度应该为4!(clsViewInfoBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjViewInfoEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewInfoBL.prototype.CheckProperty4Update  = function(pobjViewInfoEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewInfoEN.ViewId && GetStrLen(pobjViewInfoEN.ViewId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|界面Id(ViewId)]的长度不能超过8!值:$(pobjViewInfoEN.ViewId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewName && GetStrLen(pobjViewInfoEN.ViewName) > 100)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|界面名称(ViewName)]的长度不能超过100!值:$(pobjViewInfoEN.ViewName)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.FuncModuleAgcId && GetStrLen(pobjViewInfoEN.FuncModuleAgcId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|功能模块Id(FuncModuleAgcId)]的长度不能超过8!值:$(pobjViewInfoEN.FuncModuleAgcId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DataBaseName && GetStrLen(pobjViewInfoEN.DataBaseName) > 50)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|数据库名(DataBaseName)]的长度不能超过50!值:$(pobjViewInfoEN.DataBaseName)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.KeyForMainTab && GetStrLen(pobjViewInfoEN.KeyForMainTab) > 50)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|主表关键字(KeyForMainTab)]的长度不能超过50!值:$(pobjViewInfoEN.KeyForMainTab)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.KeyForDetailTab && GetStrLen(pobjViewInfoEN.KeyForDetailTab) > 50)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|明细表关键字(KeyForDetailTab)]的长度不能超过50!值:$(pobjViewInfoEN.KeyForDetailTab)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.UserId && GetStrLen(pobjViewInfoEN.UserId) > 18)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|用户Id(UserId)]的长度不能超过18!值:$(pobjViewInfoEN.UserId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.PrjId && GetStrLen(pobjViewInfoEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|工程ID(PrjId)]的长度不能超过4!值:$(pobjViewInfoEN.PrjId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewFunction && GetStrLen(pobjViewInfoEN.ViewFunction) > 100)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|界面功能(ViewFunction)]的长度不能超过100!值:$(pobjViewInfoEN.ViewFunction)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewDetail && GetStrLen(pobjViewInfoEN.ViewDetail) > 1000)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|界面说明(ViewDetail)]的长度不能超过1000!值:$(pobjViewInfoEN.ViewDetail)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DefaMenuName && GetStrLen(pobjViewInfoEN.DefaMenuName) > 100)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|缺省菜单名(DefaMenuName)]的长度不能超过100!值:$(pobjViewInfoEN.DefaMenuName)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DetailTabId && GetStrLen(pobjViewInfoEN.DetailTabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|明细表ID(DetailTabId)]的长度不能超过8!值:$(pobjViewInfoEN.DetailTabId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.FileName && GetStrLen(pobjViewInfoEN.FileName) > 150)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|文件名(FileName)]的长度不能超过150!值:$(pobjViewInfoEN.FileName)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.FilePath && GetStrLen(pobjViewInfoEN.FilePath) > 500)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|文件路径(FilePath)]的长度不能超过500!值:$(pobjViewInfoEN.FilePath)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.MainTabId && GetStrLen(pobjViewInfoEN.MainTabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|主表ID(MainTabId)]的长度不能超过8!值:$(pobjViewInfoEN.MainTabId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewCnName && GetStrLen(pobjViewInfoEN.ViewCnName) > 100)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|视图中文名(ViewCnName)]的长度不能超过100!值:$(pobjViewInfoEN.ViewCnName)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewGroupId && GetStrLen(pobjViewInfoEN.ViewGroupId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|界面组ID(ViewGroupId)]的长度不能超过8!值:$(pobjViewInfoEN.ViewGroupId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.INRelaTabId && GetStrLen(pobjViewInfoEN.INRelaTabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|输入数据源表ID(INRelaTabId)]的长度不能超过8!值:$(pobjViewInfoEN.INRelaTabId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.INSQLDSTypeId && GetStrLen(pobjViewInfoEN.INSQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|输入数据源类型(INSQLDSTypeId)]的长度不能超过2!值:$(pobjViewInfoEN.INSQLDSTypeId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.OUTRelaTabId && GetStrLen(pobjViewInfoEN.OUTRelaTabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|输出数据源表ID(OUTRelaTabId)]的长度不能超过8!值:$(pobjViewInfoEN.OUTRelaTabId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.OUTSQLDSTypeId && GetStrLen(pobjViewInfoEN.OUTSQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|输出数据源类型(OUTSQLDSTypeId)]的长度不能超过2!值:$(pobjViewInfoEN.OUTSQLDSTypeId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DetailTabType && GetStrLen(pobjViewInfoEN.DetailTabType) > 10)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|DetailTabType(DetailTabType)]的长度不能超过10!值:$(pobjViewInfoEN.DetailTabType)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DetailViewId && GetStrLen(pobjViewInfoEN.DetailViewId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|DetailViewId(DetailViewId)]的长度不能超过8!值:$(pobjViewInfoEN.DetailViewId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.MainTabType && GetStrLen(pobjViewInfoEN.MainTabType) > 10)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|MainTabType(MainTabType)]的长度不能超过10!值:$(pobjViewInfoEN.MainTabType)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.MainViewId && GetStrLen(pobjViewInfoEN.MainViewId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|MainViewId(MainViewId)]的长度不能超过8!值:$(pobjViewInfoEN.MainViewId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.GeneCodeDate && GetStrLen(pobjViewInfoEN.GeneCodeDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|生成代码日期(GeneCodeDate)]的长度不能超过20!值:$(pobjViewInfoEN.GeneCodeDate)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.TaskId && GetStrLen(pobjViewInfoEN.TaskId) > 16)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|任务Id(TaskId)]的长度不能超过16!值:$(pobjViewInfoEN.TaskId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.UpdDate && GetStrLen(pobjViewInfoEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjViewInfoEN.UpdDate)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.UpdUserId && GetStrLen(pobjViewInfoEN.UpdUserId) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|修改用户Id(UpdUserId)]的长度不能超过20!值:$(pobjViewInfoEN.UpdUserId)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.Memo && GetStrLen(pobjViewInfoEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|说明(Memo)]的长度不能超过1000!值:$(pobjViewInfoEN.Memo)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynchToServerDate && GetStrLen(pobjViewInfoEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjViewInfoEN.SynchToServerDate)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynchToServerUser && GetStrLen(pobjViewInfoEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjViewInfoEN.SynchToServerUser)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynchToClientDate && GetStrLen(pobjViewInfoEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjViewInfoEN.SynchToClientDate)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynchToClientUser && GetStrLen(pobjViewInfoEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjViewInfoEN.SynchToClientUser)(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynSource && GetStrLen(pobjViewInfoEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000158)字段[界面(ViewInfo)|同步来源(SynSource)]的长度不能超过50!值:$(pobjViewInfoEN.SynSource)(clsViewInfoBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewInfoEN.ViewId && undefined !== pobjViewInfoEN.ViewId && tzDataType.isString(pobjViewInfoEN.ViewId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|界面Id(ViewId)]的值:[$(pobjViewInfoEN.ViewId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewName && undefined !== pobjViewInfoEN.ViewName && tzDataType.isString(pobjViewInfoEN.ViewName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|界面名称(ViewName)]的值:[$(pobjViewInfoEN.ViewName)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewTypeCode && undefined !== pobjViewInfoEN.ViewTypeCode && tzDataType.isNumber(pobjViewInfoEN.ViewTypeCode) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|界面类型码(ViewTypeCode)]的值:[$(pobjViewInfoEN.ViewTypeCode)], 非法，应该为数值型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ApplicationTypeId && undefined !== pobjViewInfoEN.ApplicationTypeId && tzDataType.isNumber(pobjViewInfoEN.ApplicationTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|应用程序类型ID(ApplicationTypeId)]的值:[$(pobjViewInfoEN.ApplicationTypeId)], 非法，应该为数值型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.FuncModuleAgcId && undefined !== pobjViewInfoEN.FuncModuleAgcId && tzDataType.isString(pobjViewInfoEN.FuncModuleAgcId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|功能模块Id(FuncModuleAgcId)]的值:[$(pobjViewInfoEN.FuncModuleAgcId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DataBaseName && undefined !== pobjViewInfoEN.DataBaseName && tzDataType.isString(pobjViewInfoEN.DataBaseName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|数据库名(DataBaseName)]的值:[$(pobjViewInfoEN.DataBaseName)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.KeyForMainTab && undefined !== pobjViewInfoEN.KeyForMainTab && tzDataType.isString(pobjViewInfoEN.KeyForMainTab) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|主表关键字(KeyForMainTab)]的值:[$(pobjViewInfoEN.KeyForMainTab)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.KeyForDetailTab && undefined !== pobjViewInfoEN.KeyForDetailTab && tzDataType.isString(pobjViewInfoEN.KeyForDetailTab) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|明细表关键字(KeyForDetailTab)]的值:[$(pobjViewInfoEN.KeyForDetailTab)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.IsNeedSort && undefined !== pobjViewInfoEN.IsNeedSort && tzDataType.isBoolean(pobjViewInfoEN.IsNeedSort) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|是否需要排序(IsNeedSort)]的值:[$(pobjViewInfoEN.IsNeedSort)], 非法，应该为布尔型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.IsNeedTransCode && undefined !== pobjViewInfoEN.IsNeedTransCode && tzDataType.isBoolean(pobjViewInfoEN.IsNeedTransCode) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|是否需要转换代码(IsNeedTransCode)]的值:[$(pobjViewInfoEN.IsNeedTransCode)], 非法，应该为布尔型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.IsNeedSetExportFld && undefined !== pobjViewInfoEN.IsNeedSetExportFld && tzDataType.isBoolean(pobjViewInfoEN.IsNeedSetExportFld) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|是否需要设置导出字段(IsNeedSetExportFld)]的值:[$(pobjViewInfoEN.IsNeedSetExportFld)], 非法，应该为布尔型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.UserId && undefined !== pobjViewInfoEN.UserId && tzDataType.isString(pobjViewInfoEN.UserId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|用户Id(UserId)]的值:[$(pobjViewInfoEN.UserId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.PrjId && undefined !== pobjViewInfoEN.PrjId && tzDataType.isString(pobjViewInfoEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|工程ID(PrjId)]的值:[$(pobjViewInfoEN.PrjId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewFunction && undefined !== pobjViewInfoEN.ViewFunction && tzDataType.isString(pobjViewInfoEN.ViewFunction) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|界面功能(ViewFunction)]的值:[$(pobjViewInfoEN.ViewFunction)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewDetail && undefined !== pobjViewInfoEN.ViewDetail && tzDataType.isString(pobjViewInfoEN.ViewDetail) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|界面说明(ViewDetail)]的值:[$(pobjViewInfoEN.ViewDetail)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DefaMenuName && undefined !== pobjViewInfoEN.DefaMenuName && tzDataType.isString(pobjViewInfoEN.DefaMenuName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|缺省菜单名(DefaMenuName)]的值:[$(pobjViewInfoEN.DefaMenuName)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DetailTabId && undefined !== pobjViewInfoEN.DetailTabId && tzDataType.isString(pobjViewInfoEN.DetailTabId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|明细表ID(DetailTabId)]的值:[$(pobjViewInfoEN.DetailTabId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.FileName && undefined !== pobjViewInfoEN.FileName && tzDataType.isString(pobjViewInfoEN.FileName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|文件名(FileName)]的值:[$(pobjViewInfoEN.FileName)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.FilePath && undefined !== pobjViewInfoEN.FilePath && tzDataType.isString(pobjViewInfoEN.FilePath) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|文件路径(FilePath)]的值:[$(pobjViewInfoEN.FilePath)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.MainTabId && undefined !== pobjViewInfoEN.MainTabId && tzDataType.isString(pobjViewInfoEN.MainTabId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|主表ID(MainTabId)]的值:[$(pobjViewInfoEN.MainTabId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewCnName && undefined !== pobjViewInfoEN.ViewCnName && tzDataType.isString(pobjViewInfoEN.ViewCnName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|视图中文名(ViewCnName)]的值:[$(pobjViewInfoEN.ViewCnName)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.ViewGroupId && undefined !== pobjViewInfoEN.ViewGroupId && tzDataType.isString(pobjViewInfoEN.ViewGroupId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|界面组ID(ViewGroupId)]的值:[$(pobjViewInfoEN.ViewGroupId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.INRelaTabId && undefined !== pobjViewInfoEN.INRelaTabId && tzDataType.isString(pobjViewInfoEN.INRelaTabId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|输入数据源表ID(INRelaTabId)]的值:[$(pobjViewInfoEN.INRelaTabId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.INSQLDSTypeId && undefined !== pobjViewInfoEN.INSQLDSTypeId && tzDataType.isString(pobjViewInfoEN.INSQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|输入数据源类型(INSQLDSTypeId)]的值:[$(pobjViewInfoEN.INSQLDSTypeId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.OUTRelaTabId && undefined !== pobjViewInfoEN.OUTRelaTabId && tzDataType.isString(pobjViewInfoEN.OUTRelaTabId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|输出数据源表ID(OUTRelaTabId)]的值:[$(pobjViewInfoEN.OUTRelaTabId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.OUTSQLDSTypeId && undefined !== pobjViewInfoEN.OUTSQLDSTypeId && tzDataType.isString(pobjViewInfoEN.OUTSQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|输出数据源类型(OUTSQLDSTypeId)]的值:[$(pobjViewInfoEN.OUTSQLDSTypeId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DetailTabType && undefined !== pobjViewInfoEN.DetailTabType && tzDataType.isString(pobjViewInfoEN.DetailTabType) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|DetailTabType(DetailTabType)]的值:[$(pobjViewInfoEN.DetailTabType)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.DetailViewId && undefined !== pobjViewInfoEN.DetailViewId && tzDataType.isString(pobjViewInfoEN.DetailViewId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|DetailViewId(DetailViewId)]的值:[$(pobjViewInfoEN.DetailViewId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.MainTabType && undefined !== pobjViewInfoEN.MainTabType && tzDataType.isString(pobjViewInfoEN.MainTabType) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|MainTabType(MainTabType)]的值:[$(pobjViewInfoEN.MainTabType)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.IsUseCache4List && undefined !== pobjViewInfoEN.IsUseCache4List && tzDataType.isBoolean(pobjViewInfoEN.IsUseCache4List) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|是否使用缓存列表(IsUseCache4List)]的值:[$(pobjViewInfoEN.IsUseCache4List)], 非法，应该为布尔型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.MainViewId && undefined !== pobjViewInfoEN.MainViewId && tzDataType.isString(pobjViewInfoEN.MainViewId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|MainViewId(MainViewId)]的值:[$(pobjViewInfoEN.MainViewId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.GeneCodeDate && undefined !== pobjViewInfoEN.GeneCodeDate && tzDataType.isString(pobjViewInfoEN.GeneCodeDate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|生成代码日期(GeneCodeDate)]的值:[$(pobjViewInfoEN.GeneCodeDate)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.TaskId && undefined !== pobjViewInfoEN.TaskId && tzDataType.isString(pobjViewInfoEN.TaskId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|任务Id(TaskId)]的值:[$(pobjViewInfoEN.TaskId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.RegionNum && undefined !== pobjViewInfoEN.RegionNum && tzDataType.isNumber(pobjViewInfoEN.RegionNum) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|区域数(RegionNum)]的值:[$(pobjViewInfoEN.RegionNum)], 非法，应该为数值型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.UpdDate && undefined !== pobjViewInfoEN.UpdDate && tzDataType.isString(pobjViewInfoEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|修改日期(UpdDate)]的值:[$(pobjViewInfoEN.UpdDate)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.UpdUserId && undefined !== pobjViewInfoEN.UpdUserId && tzDataType.isString(pobjViewInfoEN.UpdUserId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|修改用户Id(UpdUserId)]的值:[$(pobjViewInfoEN.UpdUserId)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.Memo && undefined !== pobjViewInfoEN.Memo && tzDataType.isString(pobjViewInfoEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|说明(Memo)]的值:[$(pobjViewInfoEN.Memo)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.IsSynchToServer && undefined !== pobjViewInfoEN.IsSynchToServer && tzDataType.isBoolean(pobjViewInfoEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|是否同步到Server(IsSynchToServer)]的值:[$(pobjViewInfoEN.IsSynchToServer)], 非法，应该为布尔型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynchToServerDate && undefined !== pobjViewInfoEN.SynchToServerDate && tzDataType.isString(pobjViewInfoEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|同步到Server日期(SynchToServerDate)]的值:[$(pobjViewInfoEN.SynchToServerDate)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynchToServerUser && undefined !== pobjViewInfoEN.SynchToServerUser && tzDataType.isString(pobjViewInfoEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|同步到Server用户(SynchToServerUser)]的值:[$(pobjViewInfoEN.SynchToServerUser)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.IsSynchToClient && undefined !== pobjViewInfoEN.IsSynchToClient && tzDataType.isBoolean(pobjViewInfoEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|是否同步到Client(IsSynchToClient)]的值:[$(pobjViewInfoEN.IsSynchToClient)], 非法，应该为布尔型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynchToClientDate && undefined !== pobjViewInfoEN.SynchToClientDate && tzDataType.isString(pobjViewInfoEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjViewInfoEN.SynchToClientDate)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynchToClientUser && undefined !== pobjViewInfoEN.SynchToClientUser && tzDataType.isString(pobjViewInfoEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjViewInfoEN.SynchToClientUser)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
if (null !== pobjViewInfoEN.SynSource && undefined !== pobjViewInfoEN.SynSource && tzDataType.isString(pobjViewInfoEN.SynSource) === false)
{
 throw new Error("(errid:Busi000159)字段[界面(ViewInfo)|同步来源(SynSource)]的值:[$(pobjViewInfoEN.SynSource)], 非法，应该为字符型!(clsViewInfoBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjViewInfoEN.ViewId 
 || null !== pobjViewInfoEN.ViewId && pobjViewInfoEN.ViewId.toString()  ===  ""
 || null !== pobjViewInfoEN.ViewId && pobjViewInfoEN.ViewId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[界面|界面Id]不能为空(NULL)!(clsViewInfoBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjViewInfoEN.FuncModuleAgcId != null && GetStrLen(pobjViewInfoEN.FuncModuleAgcId) !=  8)
{
 throw ("(errid:Busi000161)字段[界面|功能模块Id]作为外键字段,长度应该为8!(clsViewInfoBL:CheckPropertyNew)");
}
if (pobjViewInfoEN.PrjId != null && GetStrLen(pobjViewInfoEN.PrjId) !=  4)
{
 throw ("(errid:Busi000161)字段[界面|工程ID]作为外键字段,长度应该为4!(clsViewInfoBL:CheckPropertyNew)");
}

 pobjViewInfoEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024917
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewInfoBL.GetJSONStrByObj  = function(pobjViewInfoEN)
{
pobjViewInfoEN.sf_UpdFldSetStr = pobjViewInfoEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjViewInfoEN);
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
 /// 日期:20200501024917
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsViewInfoBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrViewInfoObjLst = new Array();
if (strJSON === "")
{
return arrViewInfoObjLst;
}
try
{
arrViewInfoObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrViewInfoObjLst;
}
return arrViewInfoObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024917
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewInfoBL.GetObjByJSONStr  = function(strJSON)
{
var pobjViewInfoEN = new clsViewInfoEN();
if (strJSON === "")
{
return pobjViewInfoEN;
}
try
{
pobjViewInfoEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjViewInfoEN;
}
return pobjViewInfoEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objViewInfoENS">源简化对象</param>
 /// <param name = "objViewInfoENT">目标对象</param>
clsViewInfoBL.CopyObjFromSimObj = function(objViewInfoENS, objViewInfoENT) 
{
objViewInfoENT.ViewId = objViewInfoENS.ViewId; //界面Id
objViewInfoENT.ViewName = objViewInfoENS.ViewName; //界面名称
objViewInfoENT.ViewTypeCode = objViewInfoENS.ViewTypeCode; //界面类型码
objViewInfoENT.ApplicationTypeId = objViewInfoENS.ApplicationTypeId; //应用程序类型ID
objViewInfoENT.FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId; //功能模块Id
objViewInfoENT.DataBaseName = objViewInfoENS.DataBaseName; //数据库名
objViewInfoENT.KeyForMainTab = objViewInfoENS.KeyForMainTab; //主表关键字
objViewInfoENT.KeyForDetailTab = objViewInfoENS.KeyForDetailTab; //明细表关键字
objViewInfoENT.IsNeedSort = objViewInfoENS.IsNeedSort; //是否需要排序
objViewInfoENT.IsNeedTransCode = objViewInfoENS.IsNeedTransCode; //是否需要转换代码
objViewInfoENT.IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objViewInfoENT.UserId = objViewInfoENS.UserId; //用户Id
objViewInfoENT.PrjId = objViewInfoENS.PrjId; //工程ID
objViewInfoENT.ViewFunction = objViewInfoENS.ViewFunction; //界面功能
objViewInfoENT.ViewDetail = objViewInfoENS.ViewDetail; //界面说明
objViewInfoENT.DefaMenuName = objViewInfoENS.DefaMenuName; //缺省菜单名
objViewInfoENT.DetailTabId = objViewInfoENS.DetailTabId; //明细表ID
objViewInfoENT.FileName = objViewInfoENS.FileName; //文件名
objViewInfoENT.FilePath = objViewInfoENS.FilePath; //文件路径
objViewInfoENT.MainTabId = objViewInfoENS.MainTabId; //主表ID
objViewInfoENT.ViewCnName = objViewInfoENS.ViewCnName; //视图中文名
objViewInfoENT.ViewGroupId = objViewInfoENS.ViewGroupId; //界面组ID
objViewInfoENT.INRelaTabId = objViewInfoENS.INRelaTabId; //输入数据源表ID
objViewInfoENT.INSQLDSTypeId = objViewInfoENS.INSQLDSTypeId; //输入数据源类型
objViewInfoENT.OUTRelaTabId = objViewInfoENS.OUTRelaTabId; //输出数据源表ID
objViewInfoENT.OUTSQLDSTypeId = objViewInfoENS.OUTSQLDSTypeId; //输出数据源类型
objViewInfoENT.DetailTabType = objViewInfoENS.DetailTabType; //DetailTabType
objViewInfoENT.DetailViewId = objViewInfoENS.DetailViewId; //DetailViewId
objViewInfoENT.MainTabType = objViewInfoENS.MainTabType; //MainTabType
objViewInfoENT.IsUseCache4List = objViewInfoENS.IsUseCache4List; //是否使用缓存列表
objViewInfoENT.MainViewId = objViewInfoENS.MainViewId; //MainViewId
objViewInfoENT.GeneCodeDate = objViewInfoENS.GeneCodeDate; //生成代码日期
objViewInfoENT.TaskId = objViewInfoENS.TaskId; //任务Id
objViewInfoENT.RegionNum = objViewInfoENS.RegionNum; //区域数
objViewInfoENT.UpdDate = objViewInfoENS.UpdDate; //修改日期
objViewInfoENT.UpdUserId = objViewInfoENS.UpdUserId; //修改用户Id
objViewInfoENT.Memo = objViewInfoENS.Memo; //说明
objViewInfoENT.IsSynchToServer = objViewInfoENS.IsSynchToServer; //是否同步到Server
objViewInfoENT.SynchToServerDate = objViewInfoENS.SynchToServerDate; //同步到Server日期
objViewInfoENT.SynchToServerUser = objViewInfoENS.SynchToServerUser; //同步到Server用户
objViewInfoENT.IsSynchToClient = objViewInfoENS.IsSynchToClient; //是否同步到Client
objViewInfoENT.SynchToClientDate = objViewInfoENS.SynchToClientDate; //同步到Client库日期
objViewInfoENT.SynchToClientUser = objViewInfoENS.SynchToClientUser; //同步到Client库用户
objViewInfoENT.SynSource = objViewInfoENS.SynSource; //同步来源
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objViewInfoENS">源对象</param>
 /// <param name = "objViewInfoENT">目标对象</param>
clsViewInfoBL.CopyObjTo = function(objViewInfoENS , objViewInfoENT ) 
{
objViewInfoENT.ViewId = objViewInfoENS.ViewId; //界面Id
objViewInfoENT.ViewName = objViewInfoENS.ViewName; //界面名称
objViewInfoENT.ViewTypeCode = objViewInfoENS.ViewTypeCode; //界面类型码
objViewInfoENT.ApplicationTypeId = objViewInfoENS.ApplicationTypeId; //应用程序类型ID
objViewInfoENT.FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId; //功能模块Id
objViewInfoENT.DataBaseName = objViewInfoENS.DataBaseName; //数据库名
objViewInfoENT.KeyForMainTab = objViewInfoENS.KeyForMainTab; //主表关键字
objViewInfoENT.KeyForDetailTab = objViewInfoENS.KeyForDetailTab; //明细表关键字
objViewInfoENT.IsNeedSort = objViewInfoENS.IsNeedSort; //是否需要排序
objViewInfoENT.IsNeedTransCode = objViewInfoENS.IsNeedTransCode; //是否需要转换代码
objViewInfoENT.IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objViewInfoENT.UserId = objViewInfoENS.UserId; //用户Id
objViewInfoENT.PrjId = objViewInfoENS.PrjId; //工程ID
objViewInfoENT.ViewFunction = objViewInfoENS.ViewFunction; //界面功能
objViewInfoENT.ViewDetail = objViewInfoENS.ViewDetail; //界面说明
objViewInfoENT.DefaMenuName = objViewInfoENS.DefaMenuName; //缺省菜单名
objViewInfoENT.DetailTabId = objViewInfoENS.DetailTabId; //明细表ID
objViewInfoENT.FileName = objViewInfoENS.FileName; //文件名
objViewInfoENT.FilePath = objViewInfoENS.FilePath; //文件路径
objViewInfoENT.MainTabId = objViewInfoENS.MainTabId; //主表ID
objViewInfoENT.ViewCnName = objViewInfoENS.ViewCnName; //视图中文名
objViewInfoENT.ViewGroupId = objViewInfoENS.ViewGroupId; //界面组ID
objViewInfoENT.INRelaTabId = objViewInfoENS.INRelaTabId; //输入数据源表ID
objViewInfoENT.INSQLDSTypeId = objViewInfoENS.INSQLDSTypeId; //输入数据源类型
objViewInfoENT.OUTRelaTabId = objViewInfoENS.OUTRelaTabId; //输出数据源表ID
objViewInfoENT.OUTSQLDSTypeId = objViewInfoENS.OUTSQLDSTypeId; //输出数据源类型
objViewInfoENT.DetailTabType = objViewInfoENS.DetailTabType; //DetailTabType
objViewInfoENT.DetailViewId = objViewInfoENS.DetailViewId; //DetailViewId
objViewInfoENT.MainTabType = objViewInfoENS.MainTabType; //MainTabType
objViewInfoENT.IsUseCache4List = objViewInfoENS.IsUseCache4List; //是否使用缓存列表
objViewInfoENT.MainViewId = objViewInfoENS.MainViewId; //MainViewId
objViewInfoENT.GeneCodeDate = objViewInfoENS.GeneCodeDate; //生成代码日期
objViewInfoENT.TaskId = objViewInfoENS.TaskId; //任务Id
objViewInfoENT.RegionNum = objViewInfoENS.RegionNum; //区域数
objViewInfoENT.UpdDate = objViewInfoENS.UpdDate; //修改日期
objViewInfoENT.UpdUserId = objViewInfoENS.UpdUserId; //修改用户Id
objViewInfoENT.Memo = objViewInfoENS.Memo; //说明
objViewInfoENT.IsSynchToServer = objViewInfoENS.IsSynchToServer; //是否同步到Server
objViewInfoENT.SynchToServerDate = objViewInfoENS.SynchToServerDate; //同步到Server日期
objViewInfoENT.SynchToServerUser = objViewInfoENS.SynchToServerUser; //同步到Server用户
objViewInfoENT.IsSynchToClient = objViewInfoENS.IsSynchToClient; //是否同步到Client
objViewInfoENT.SynchToClientDate = objViewInfoENS.SynchToClientDate; //同步到Client库日期
objViewInfoENT.SynchToClientUser = objViewInfoENS.SynchToClientUser; //同步到Client库用户
objViewInfoENT.SynSource = objViewInfoENS.SynSource; //同步来源
objViewInfoENT.sf_UpdFldSetStr = objViewInfoENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objViewInfoENS">源对象</param>
 /// <param name = "objViewInfoENT">目标对象</param>
clsViewInfoBL.CopyObjToSimObj = function(objViewInfoENS , objViewInfoENT ) 
{
objViewInfoENT.ViewId = objViewInfoENS.ViewId; //界面Id
objViewInfoENT.ViewName = objViewInfoENS.ViewName; //界面名称
objViewInfoENT.ViewTypeCode = objViewInfoENS.ViewTypeCode; //界面类型码
objViewInfoENT.ApplicationTypeId = objViewInfoENS.ApplicationTypeId; //应用程序类型ID
objViewInfoENT.FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId; //功能模块Id
objViewInfoENT.DataBaseName = objViewInfoENS.DataBaseName; //数据库名
objViewInfoENT.KeyForMainTab = objViewInfoENS.KeyForMainTab; //主表关键字
objViewInfoENT.KeyForDetailTab = objViewInfoENS.KeyForDetailTab; //明细表关键字
objViewInfoENT.IsNeedSort = objViewInfoENS.IsNeedSort; //是否需要排序
objViewInfoENT.IsNeedTransCode = objViewInfoENS.IsNeedTransCode; //是否需要转换代码
objViewInfoENT.IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objViewInfoENT.UserId = objViewInfoENS.UserId; //用户Id
objViewInfoENT.PrjId = objViewInfoENS.PrjId; //工程ID
objViewInfoENT.ViewFunction = objViewInfoENS.ViewFunction; //界面功能
objViewInfoENT.ViewDetail = objViewInfoENS.ViewDetail; //界面说明
objViewInfoENT.DefaMenuName = objViewInfoENS.DefaMenuName; //缺省菜单名
objViewInfoENT.DetailTabId = objViewInfoENS.DetailTabId; //明细表ID
objViewInfoENT.FileName = objViewInfoENS.FileName; //文件名
objViewInfoENT.FilePath = objViewInfoENS.FilePath; //文件路径
objViewInfoENT.MainTabId = objViewInfoENS.MainTabId; //主表ID
objViewInfoENT.ViewCnName = objViewInfoENS.ViewCnName; //视图中文名
objViewInfoENT.ViewGroupId = objViewInfoENS.ViewGroupId; //界面组ID
objViewInfoENT.INRelaTabId = objViewInfoENS.INRelaTabId; //输入数据源表ID
objViewInfoENT.INSQLDSTypeId = objViewInfoENS.INSQLDSTypeId; //输入数据源类型
objViewInfoENT.OUTRelaTabId = objViewInfoENS.OUTRelaTabId; //输出数据源表ID
objViewInfoENT.OUTSQLDSTypeId = objViewInfoENS.OUTSQLDSTypeId; //输出数据源类型
objViewInfoENT.DetailTabType = objViewInfoENS.DetailTabType; //DetailTabType
objViewInfoENT.DetailViewId = objViewInfoENS.DetailViewId; //DetailViewId
objViewInfoENT.MainTabType = objViewInfoENS.MainTabType; //MainTabType
objViewInfoENT.IsUseCache4List = objViewInfoENS.IsUseCache4List; //是否使用缓存列表
objViewInfoENT.MainViewId = objViewInfoENS.MainViewId; //MainViewId
objViewInfoENT.GeneCodeDate = objViewInfoENS.GeneCodeDate; //生成代码日期
objViewInfoENT.TaskId = objViewInfoENS.TaskId; //任务Id
objViewInfoENT.RegionNum = objViewInfoENS.RegionNum; //区域数
objViewInfoENT.UpdDate = objViewInfoENS.UpdDate; //修改日期
objViewInfoENT.UpdUserId = objViewInfoENS.UpdUserId; //修改用户Id
objViewInfoENT.Memo = objViewInfoENS.Memo; //说明
objViewInfoENT.IsSynchToServer = objViewInfoENS.IsSynchToServer; //是否同步到Server
objViewInfoENT.SynchToServerDate = objViewInfoENS.SynchToServerDate; //同步到Server日期
objViewInfoENT.SynchToServerUser = objViewInfoENS.SynchToServerUser; //同步到Server用户
objViewInfoENT.IsSynchToClient = objViewInfoENS.IsSynchToClient; //是否同步到Client
objViewInfoENT.SynchToClientDate = objViewInfoENS.SynchToClientDate; //同步到Client库日期
objViewInfoENT.SynchToClientUser = objViewInfoENS.SynchToClientUser; //同步到Client库用户
objViewInfoENT.SynSource = objViewInfoENS.SynSource; //同步来源
objViewInfoENT.sf_UpdFldSetStr = objViewInfoENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewInfoENT.sf_FldComparisonOp = objViewInfoENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objViewInfoENS">源简化对象</param>
 /// <param name = "objViewInfoENT">目标对象</param>
clsViewInfoBL.CopyObjFromSimObj4Upd = function(objViewInfoENS, objViewInfoENT )
 {
   var strsf_UpdFldSetStr = objViewInfoENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsViewInfoEN.con_ViewId)  >= 0)
{
objViewInfoENT.ViewId = objViewInfoENS.ViewId; //界面Id
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_ViewName)  >= 0)
{
objViewInfoENT.ViewName = objViewInfoENS.ViewName; //界面名称
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_ViewTypeCode)  >= 0)
{
objViewInfoENT.ViewTypeCode = objViewInfoENS.ViewTypeCode; //界面类型码
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_ApplicationTypeId)  >= 0)
{
objViewInfoENT.ApplicationTypeId = objViewInfoENS.ApplicationTypeId; //应用程序类型ID
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_FuncModuleAgcId)  >= 0)
{
objViewInfoENT.FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId; //功能模块Id
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_DataBaseName)  >= 0)
{
objViewInfoENT.DataBaseName = objViewInfoENS.DataBaseName; //数据库名
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_KeyForMainTab)  >= 0)
{
objViewInfoENT.KeyForMainTab = objViewInfoENS.KeyForMainTab; //主表关键字
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_KeyForDetailTab)  >= 0)
{
objViewInfoENT.KeyForDetailTab = objViewInfoENS.KeyForDetailTab; //明细表关键字
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_IsNeedSort)  >= 0)
{
objViewInfoENT.IsNeedSort = objViewInfoENS.IsNeedSort; //是否需要排序
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_IsNeedTransCode)  >= 0)
{
objViewInfoENT.IsNeedTransCode = objViewInfoENS.IsNeedTransCode; //是否需要转换代码
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_IsNeedSetExportFld)  >= 0)
{
objViewInfoENT.IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_UserId)  >= 0)
{
objViewInfoENT.UserId = objViewInfoENS.UserId; //用户Id
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_PrjId)  >= 0)
{
objViewInfoENT.PrjId = objViewInfoENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_ViewFunction)  >= 0)
{
objViewInfoENT.ViewFunction = objViewInfoENS.ViewFunction; //界面功能
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_ViewDetail)  >= 0)
{
objViewInfoENT.ViewDetail = objViewInfoENS.ViewDetail; //界面说明
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_DefaMenuName)  >= 0)
{
objViewInfoENT.DefaMenuName = objViewInfoENS.DefaMenuName; //缺省菜单名
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_DetailTabId)  >= 0)
{
objViewInfoENT.DetailTabId = objViewInfoENS.DetailTabId; //明细表ID
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_FileName)  >= 0)
{
objViewInfoENT.FileName = objViewInfoENS.FileName; //文件名
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_FilePath)  >= 0)
{
objViewInfoENT.FilePath = objViewInfoENS.FilePath; //文件路径
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_MainTabId)  >= 0)
{
objViewInfoENT.MainTabId = objViewInfoENS.MainTabId; //主表ID
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_ViewCnName)  >= 0)
{
objViewInfoENT.ViewCnName = objViewInfoENS.ViewCnName; //视图中文名
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_ViewGroupId)  >= 0)
{
objViewInfoENT.ViewGroupId = objViewInfoENS.ViewGroupId; //界面组ID
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_INRelaTabId)  >= 0)
{
objViewInfoENT.INRelaTabId = objViewInfoENS.INRelaTabId; //输入数据源表ID
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_INSQLDSTypeId)  >= 0)
{
objViewInfoENT.INSQLDSTypeId = objViewInfoENS.INSQLDSTypeId; //输入数据源类型
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_OUTRelaTabId)  >= 0)
{
objViewInfoENT.OUTRelaTabId = objViewInfoENS.OUTRelaTabId; //输出数据源表ID
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_OUTSQLDSTypeId)  >= 0)
{
objViewInfoENT.OUTSQLDSTypeId = objViewInfoENS.OUTSQLDSTypeId; //输出数据源类型
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_DetailTabType)  >= 0)
{
objViewInfoENT.DetailTabType = objViewInfoENS.DetailTabType; //DetailTabType
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_DetailViewId)  >= 0)
{
objViewInfoENT.DetailViewId = objViewInfoENS.DetailViewId; //DetailViewId
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_MainTabType)  >= 0)
{
objViewInfoENT.MainTabType = objViewInfoENS.MainTabType; //MainTabType
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_IsUseCache4List)  >= 0)
{
objViewInfoENT.IsUseCache4List = objViewInfoENS.IsUseCache4List; //是否使用缓存列表
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_MainViewId)  >= 0)
{
objViewInfoENT.MainViewId = objViewInfoENS.MainViewId; //MainViewId
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_GeneCodeDate)  >= 0)
{
objViewInfoENT.GeneCodeDate = objViewInfoENS.GeneCodeDate; //生成代码日期
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_TaskId)  >= 0)
{
objViewInfoENT.TaskId = objViewInfoENS.TaskId; //任务Id
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_RegionNum)  >= 0)
{
objViewInfoENT.RegionNum = objViewInfoENS.RegionNum; //区域数
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_UpdDate)  >= 0)
{
objViewInfoENT.UpdDate = objViewInfoENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_UpdUserId)  >= 0)
{
objViewInfoENT.UpdUserId = objViewInfoENS.UpdUserId; //修改用户Id
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_Memo)  >= 0)
{
objViewInfoENT.Memo = objViewInfoENS.Memo; //说明
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_IsSynchToServer)  >= 0)
{
objViewInfoENT.IsSynchToServer = objViewInfoENS.IsSynchToServer; //是否同步到Server
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_SynchToServerDate)  >= 0)
{
objViewInfoENT.SynchToServerDate = objViewInfoENS.SynchToServerDate; //同步到Server日期
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_SynchToServerUser)  >= 0)
{
objViewInfoENT.SynchToServerUser = objViewInfoENS.SynchToServerUser; //同步到Server用户
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_IsSynchToClient)  >= 0)
{
objViewInfoENT.IsSynchToClient = objViewInfoENS.IsSynchToClient; //是否同步到Client
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_SynchToClientDate)  >= 0)
{
objViewInfoENT.SynchToClientDate = objViewInfoENS.SynchToClientDate; //同步到Client库日期
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_SynchToClientUser)  >= 0)
{
objViewInfoENT.SynchToClientUser = objViewInfoENS.SynchToClientUser; //同步到Client库用户
}
if (sstrFldSet.indexOf(clsViewInfoEN.con_SynSource)  >= 0)
{
objViewInfoENT.SynSource = objViewInfoENS.SynSource; //同步来源
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objViewInfoENS">源对象</param>
 /// <param name = "objViewInfoENT">目标对象</param>
clsViewInfoBL.GetSimObjFromObj = function(objViewInfoENS)
{
var objViewInfoENT = new clsViewInfoEN_Sim_js_1.clsViewInfoEN_Sim();
objViewInfoENT.ViewId = objViewInfoENS.ViewId; //界面Id
objViewInfoENT.ViewName = objViewInfoENS.ViewName; //界面名称
objViewInfoENT.ViewTypeCode = objViewInfoENS.ViewTypeCode; //界面类型码
objViewInfoENT.ApplicationTypeId = objViewInfoENS.ApplicationTypeId; //应用程序类型ID
objViewInfoENT.FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId; //功能模块Id
objViewInfoENT.DataBaseName = objViewInfoENS.DataBaseName; //数据库名
objViewInfoENT.KeyForMainTab = objViewInfoENS.KeyForMainTab; //主表关键字
objViewInfoENT.KeyForDetailTab = objViewInfoENS.KeyForDetailTab; //明细表关键字
objViewInfoENT.IsNeedSort = objViewInfoENS.IsNeedSort; //是否需要排序
objViewInfoENT.IsNeedTransCode = objViewInfoENS.IsNeedTransCode; //是否需要转换代码
objViewInfoENT.IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objViewInfoENT.UserId = objViewInfoENS.UserId; //用户Id
objViewInfoENT.PrjId = objViewInfoENS.PrjId; //工程ID
objViewInfoENT.ViewFunction = objViewInfoENS.ViewFunction; //界面功能
objViewInfoENT.ViewDetail = objViewInfoENS.ViewDetail; //界面说明
objViewInfoENT.DefaMenuName = objViewInfoENS.DefaMenuName; //缺省菜单名
objViewInfoENT.DetailTabId = objViewInfoENS.DetailTabId; //明细表ID
objViewInfoENT.FileName = objViewInfoENS.FileName; //文件名
objViewInfoENT.FilePath = objViewInfoENS.FilePath; //文件路径
objViewInfoENT.MainTabId = objViewInfoENS.MainTabId; //主表ID
objViewInfoENT.ViewCnName = objViewInfoENS.ViewCnName; //视图中文名
objViewInfoENT.ViewGroupId = objViewInfoENS.ViewGroupId; //界面组ID
objViewInfoENT.INRelaTabId = objViewInfoENS.INRelaTabId; //输入数据源表ID
objViewInfoENT.INSQLDSTypeId = objViewInfoENS.INSQLDSTypeId; //输入数据源类型
objViewInfoENT.OUTRelaTabId = objViewInfoENS.OUTRelaTabId; //输出数据源表ID
objViewInfoENT.OUTSQLDSTypeId = objViewInfoENS.OUTSQLDSTypeId; //输出数据源类型
objViewInfoENT.DetailTabType = objViewInfoENS.DetailTabType; //DetailTabType
objViewInfoENT.DetailViewId = objViewInfoENS.DetailViewId; //DetailViewId
objViewInfoENT.MainTabType = objViewInfoENS.MainTabType; //MainTabType
objViewInfoENT.IsUseCache4List = objViewInfoENS.IsUseCache4List; //是否使用缓存列表
objViewInfoENT.MainViewId = objViewInfoENS.MainViewId; //MainViewId
objViewInfoENT.GeneCodeDate = objViewInfoENS.GeneCodeDate; //生成代码日期
objViewInfoENT.TaskId = objViewInfoENS.TaskId; //任务Id
objViewInfoENT.RegionNum = objViewInfoENS.RegionNum; //区域数
objViewInfoENT.UpdDate = objViewInfoENS.UpdDate; //修改日期
objViewInfoENT.UpdUserId = objViewInfoENS.UpdUserId; //修改用户Id
objViewInfoENT.Memo = objViewInfoENS.Memo; //说明
objViewInfoENT.IsSynchToServer = objViewInfoENS.IsSynchToServer; //是否同步到Server
objViewInfoENT.SynchToServerDate = objViewInfoENS.SynchToServerDate; //同步到Server日期
objViewInfoENT.SynchToServerUser = objViewInfoENS.SynchToServerUser; //同步到Server用户
objViewInfoENT.IsSynchToClient = objViewInfoENS.IsSynchToClient; //是否同步到Client
objViewInfoENT.SynchToClientDate = objViewInfoENS.SynchToClientDate; //同步到Client库日期
objViewInfoENT.SynchToClientUser = objViewInfoENS.SynchToClientUser; //同步到Client库用户
objViewInfoENT.SynSource = objViewInfoENS.SynSource; //同步来源
objViewInfoENT.sf_UpdFldSetStr = objViewInfoENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewInfoENT.sf_FldComparisonOp = objViewInfoENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objViewInfoENT;
}
return clsViewInfoBL;
}());
exports.clsViewInfoBL = clsViewInfoBL;
});