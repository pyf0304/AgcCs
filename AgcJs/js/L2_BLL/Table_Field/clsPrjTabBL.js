
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabBL
 表名:PrjTab(00050009)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:05:56
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsPrjTabEN.js","../../L0_Entity/Table_Field/clsPrjTabEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsPrjTabEN_js_1 = require("../../L0_Entity/Table_Field/clsPrjTabEN.js");
var clsPrjTabEN_Sim_js_1 = require("../../L0_Entity/Table_Field/clsPrjTabEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 工程表(PrjTab)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsPrjTabBL = /** @class */ (function () {
function clsPrjTabBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrPrjTabObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsPrjTabBL.prototype.CheckPropertyNew = function(pobjPrjTabEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjPrjTabEN.TabName 
 || null !== pobjPrjTabEN.TabName && pobjPrjTabEN.TabName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程表|表名]不能为空(NULL)!(clsPrjTabBL:CheckPropertyNew)");
}
if (null === pobjPrjTabEN.PrjId 
 || null !== pobjPrjTabEN.PrjId && pobjPrjTabEN.PrjId.toString()  ===  ""
 || null !== pobjPrjTabEN.PrjId && pobjPrjTabEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程表|工程ID]不能为空(NULL)!(clsPrjTabBL:CheckPropertyNew)");
}
if (null === pobjPrjTabEN.TabStateId 
 || null !== pobjPrjTabEN.TabStateId && pobjPrjTabEN.TabStateId.toString()  ===  ""
 || null !== pobjPrjTabEN.TabStateId && pobjPrjTabEN.TabStateId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程表|表状态ID]不能为空(NULL)!(clsPrjTabBL:CheckPropertyNew)");
}
if (null === pobjPrjTabEN.IsReleToSqlTab 
 || null !== pobjPrjTabEN.IsReleToSqlTab && pobjPrjTabEN.IsReleToSqlTab.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程表|是否与SQL表相关]不能为空(NULL)!(clsPrjTabBL:CheckPropertyNew)");
}
if (null === pobjPrjTabEN.TabTypeId 
 || null !== pobjPrjTabEN.TabTypeId && pobjPrjTabEN.TabTypeId.toString()  ===  ""
 || null !== pobjPrjTabEN.TabTypeId && pobjPrjTabEN.TabTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程表|表类型Id]不能为空(NULL)!(clsPrjTabBL:CheckPropertyNew)");
}
if (null === pobjPrjTabEN.TabMainTypeId 
 || null !== pobjPrjTabEN.TabMainTypeId && pobjPrjTabEN.TabMainTypeId.toString()  ===  ""
 || null !== pobjPrjTabEN.TabMainTypeId && pobjPrjTabEN.TabMainTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程表|表主类型Id]不能为空(NULL)!(clsPrjTabBL:CheckPropertyNew)");
}
if (null === pobjPrjTabEN.IsNeedTransCode 
 || null !== pobjPrjTabEN.IsNeedTransCode && pobjPrjTabEN.IsNeedTransCode.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程表|是否需要转换代码]不能为空(NULL)!(clsPrjTabBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjPrjTabEN.TabId && GetStrLen(pobjPrjTabEN.TabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|表ID(TabId)]的长度不能超过8!值:$(pobjPrjTabEN.TabId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabName && GetStrLen(pobjPrjTabEN.TabName) > 100)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|表名(TabName)]的长度不能超过100!值:$(pobjPrjTabEN.TabName)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabCnName && GetStrLen(pobjPrjTabEN.TabCnName) > 200)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|表中文名(TabCnName)]的长度不能超过200!值:$(pobjPrjTabEN.TabCnName)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.PrjId && GetStrLen(pobjPrjTabEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|工程ID(PrjId)]的长度不能超过4!值:$(pobjPrjTabEN.PrjId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SQLDSTypeId && GetStrLen(pobjPrjTabEN.SQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|数据源类型(SQLDSTypeId)]的长度不能超过2!值:$(pobjPrjTabEN.SQLDSTypeId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabStateId && GetStrLen(pobjPrjTabEN.TabStateId) > 2)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|表状态ID(TabStateId)]的长度不能超过2!值:$(pobjPrjTabEN.TabStateId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.FuncModuleAgcId && GetStrLen(pobjPrjTabEN.FuncModuleAgcId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|功能模块Id(FuncModuleAgcId)]的长度不能超过8!值:$(pobjPrjTabEN.FuncModuleAgcId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.KeyWord && GetStrLen(pobjPrjTabEN.KeyWord) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|关键字(KeyWord)]的长度不能超过50!值:$(pobjPrjTabEN.KeyWord)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabTypeId && GetStrLen(pobjPrjTabEN.TabTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|表类型Id(TabTypeId)]的长度不能超过4!值:$(pobjPrjTabEN.TabTypeId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabMainTypeId && GetStrLen(pobjPrjTabEN.TabMainTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|表主类型Id(TabMainTypeId)]的长度不能超过4!值:$(pobjPrjTabEN.TabMainTypeId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.RelaTabId4View && GetStrLen(pobjPrjTabEN.RelaTabId4View) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|视图的相关表ID(RelaTabId4View)]的长度不能超过8!值:$(pobjPrjTabEN.RelaTabId4View)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.ParentClass && GetStrLen(pobjPrjTabEN.ParentClass) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|父类(ParentClass)]的长度不能超过50!值:$(pobjPrjTabEN.ParentClass)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.CacheModeId && GetStrLen(pobjPrjTabEN.CacheModeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|缓存方式Id(CacheModeId)]的长度不能超过2!值:$(pobjPrjTabEN.CacheModeId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.CacheClassifyField && GetStrLen(pobjPrjTabEN.CacheClassifyField) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|缓存分类字段(CacheClassifyField)]的长度不能超过8!值:$(pobjPrjTabEN.CacheClassifyField)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.UpdUserId && GetStrLen(pobjPrjTabEN.UpdUserId) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|修改用户Id(UpdUserId)]的长度不能超过20!值:$(pobjPrjTabEN.UpdUserId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.UpdDate && GetStrLen(pobjPrjTabEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjPrjTabEN.UpdDate)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.Memo && GetStrLen(pobjPrjTabEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|说明(Memo)]的长度不能超过1000!值:$(pobjPrjTabEN.Memo)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.ErrMsg && GetStrLen(pobjPrjTabEN.ErrMsg) > 8000)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|错误信息(ErrMsg)]的长度不能超过8000!值:$(pobjPrjTabEN.ErrMsg)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.KeyFldId && GetStrLen(pobjPrjTabEN.KeyFldId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|关键字段Id(KeyFldId)]的长度不能超过8!值:$(pobjPrjTabEN.KeyFldId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.KeyFldName && GetStrLen(pobjPrjTabEN.KeyFldName) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|关键字段名(KeyFldName)]的长度不能超过50!值:$(pobjPrjTabEN.KeyFldName)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.PrimaryTypeId && GetStrLen(pobjPrjTabEN.PrimaryTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|主键类型ID(PrimaryTypeId)]的长度不能超过2!值:$(pobjPrjTabEN.PrimaryTypeId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.PrimaryTypeName && GetStrLen(pobjPrjTabEN.PrimaryTypeName) > 30)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|主键类型名(PrimaryTypeName)]的长度不能超过30!值:$(pobjPrjTabEN.PrimaryTypeName)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynchToServerDate && GetStrLen(pobjPrjTabEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjPrjTabEN.SynchToServerDate)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynchToServerUser && GetStrLen(pobjPrjTabEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjPrjTabEN.SynchToServerUser)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynchToClientDate && GetStrLen(pobjPrjTabEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjPrjTabEN.SynchToClientDate)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynchToClientUser && GetStrLen(pobjPrjTabEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjPrjTabEN.SynchToClientUser)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynSource && GetStrLen(pobjPrjTabEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|同步来源(SynSource)]的长度不能超过50!值:$(pobjPrjTabEN.SynSource)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.RelaViewId && GetStrLen(pobjPrjTabEN.RelaViewId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|RelaViewId(RelaViewId)]的长度不能超过8!值:$(pobjPrjTabEN.RelaViewId)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.Owner && GetStrLen(pobjPrjTabEN.Owner) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|拥有者(Owner)]的长度不能超过50!值:$(pobjPrjTabEN.Owner)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabEnName && GetStrLen(pobjPrjTabEN.TabEnName) > 200)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|表英文详细名(TabEnName)]的长度不能超过200!值:$(pobjPrjTabEN.TabEnName)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabName_B && GetStrLen(pobjPrjTabEN.TabName_B) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|表名_后备(TabName_B)]的长度不能超过50!值:$(pobjPrjTabEN.TabName_B)(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.DataBaseName && GetStrLen(pobjPrjTabEN.DataBaseName) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程表(PrjTab)|数据库名(DataBaseName)]的长度不能超过50!值:$(pobjPrjTabEN.DataBaseName)(clsPrjTabBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjPrjTabEN.TabId && undefined !== pobjPrjTabEN.TabId && tzDataType.isString(pobjPrjTabEN.TabId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|表ID(TabId)]的值:[$(pobjPrjTabEN.TabId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabName && undefined !== pobjPrjTabEN.TabName && tzDataType.isString(pobjPrjTabEN.TabName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|表名(TabName)]的值:[$(pobjPrjTabEN.TabName)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabCnName && undefined !== pobjPrjTabEN.TabCnName && tzDataType.isString(pobjPrjTabEN.TabCnName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|表中文名(TabCnName)]的值:[$(pobjPrjTabEN.TabCnName)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.PrjId && undefined !== pobjPrjTabEN.PrjId && tzDataType.isString(pobjPrjTabEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|工程ID(PrjId)]的值:[$(pobjPrjTabEN.PrjId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SQLDSTypeId && undefined !== pobjPrjTabEN.SQLDSTypeId && tzDataType.isString(pobjPrjTabEN.SQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|数据源类型(SQLDSTypeId)]的值:[$(pobjPrjTabEN.SQLDSTypeId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabStateId && undefined !== pobjPrjTabEN.TabStateId && tzDataType.isString(pobjPrjTabEN.TabStateId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|表状态ID(TabStateId)]的值:[$(pobjPrjTabEN.TabStateId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.FuncModuleAgcId && undefined !== pobjPrjTabEN.FuncModuleAgcId && tzDataType.isString(pobjPrjTabEN.FuncModuleAgcId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|功能模块Id(FuncModuleAgcId)]的值:[$(pobjPrjTabEN.FuncModuleAgcId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsReleToSqlTab && undefined !== pobjPrjTabEN.IsReleToSqlTab && tzDataType.isBoolean(pobjPrjTabEN.IsReleToSqlTab) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否与SQL表相关(IsReleToSqlTab)]的值:[$(pobjPrjTabEN.IsReleToSqlTab)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.KeyWord && undefined !== pobjPrjTabEN.KeyWord && tzDataType.isString(pobjPrjTabEN.KeyWord) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|关键字(KeyWord)]的值:[$(pobjPrjTabEN.KeyWord)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabTypeId && undefined !== pobjPrjTabEN.TabTypeId && tzDataType.isString(pobjPrjTabEN.TabTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|表类型Id(TabTypeId)]的值:[$(pobjPrjTabEN.TabTypeId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabMainTypeId && undefined !== pobjPrjTabEN.TabMainTypeId && tzDataType.isString(pobjPrjTabEN.TabMainTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|表主类型Id(TabMainTypeId)]的值:[$(pobjPrjTabEN.TabMainTypeId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.RelaTabId4View && undefined !== pobjPrjTabEN.RelaTabId4View && tzDataType.isString(pobjPrjTabEN.RelaTabId4View) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|视图的相关表ID(RelaTabId4View)]的值:[$(pobjPrjTabEN.RelaTabId4View)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsNeedGeneIndexer && undefined !== pobjPrjTabEN.IsNeedGeneIndexer && tzDataType.isBoolean(pobjPrjTabEN.IsNeedGeneIndexer) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否需要生成索引器(IsNeedGeneIndexer)]的值:[$(pobjPrjTabEN.IsNeedGeneIndexer)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.ParentClass && undefined !== pobjPrjTabEN.ParentClass && tzDataType.isString(pobjPrjTabEN.ParentClass) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|父类(ParentClass)]的值:[$(pobjPrjTabEN.ParentClass)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsUseCache && undefined !== pobjPrjTabEN.IsUseCache && tzDataType.isBoolean(pobjPrjTabEN.IsUseCache) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否使用Cache(IsUseCache)]的值:[$(pobjPrjTabEN.IsUseCache)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.CacheModeId && undefined !== pobjPrjTabEN.CacheModeId && tzDataType.isString(pobjPrjTabEN.CacheModeId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|缓存方式Id(CacheModeId)]的值:[$(pobjPrjTabEN.CacheModeId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.CacheClassifyField && undefined !== pobjPrjTabEN.CacheClassifyField && tzDataType.isString(pobjPrjTabEN.CacheClassifyField) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|缓存分类字段(CacheClassifyField)]的值:[$(pobjPrjTabEN.CacheClassifyField)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.UpdUserId && undefined !== pobjPrjTabEN.UpdUserId && tzDataType.isString(pobjPrjTabEN.UpdUserId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|修改用户Id(UpdUserId)]的值:[$(pobjPrjTabEN.UpdUserId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.UpdDate && undefined !== pobjPrjTabEN.UpdDate && tzDataType.isString(pobjPrjTabEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|修改日期(UpdDate)]的值:[$(pobjPrjTabEN.UpdDate)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.Memo && undefined !== pobjPrjTabEN.Memo && tzDataType.isString(pobjPrjTabEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|说明(Memo)]的值:[$(pobjPrjTabEN.Memo)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.ErrMsg && undefined !== pobjPrjTabEN.ErrMsg && tzDataType.isString(pobjPrjTabEN.ErrMsg) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|错误信息(ErrMsg)]的值:[$(pobjPrjTabEN.ErrMsg)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.KeyFldId && undefined !== pobjPrjTabEN.KeyFldId && tzDataType.isString(pobjPrjTabEN.KeyFldId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|关键字段Id(KeyFldId)]的值:[$(pobjPrjTabEN.KeyFldId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.KeyFldName && undefined !== pobjPrjTabEN.KeyFldName && tzDataType.isString(pobjPrjTabEN.KeyFldName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|关键字段名(KeyFldName)]的值:[$(pobjPrjTabEN.KeyFldName)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.PrimaryTypeId && undefined !== pobjPrjTabEN.PrimaryTypeId && tzDataType.isString(pobjPrjTabEN.PrimaryTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|主键类型ID(PrimaryTypeId)]的值:[$(pobjPrjTabEN.PrimaryTypeId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.PrimaryTypeName && undefined !== pobjPrjTabEN.PrimaryTypeName && tzDataType.isString(pobjPrjTabEN.PrimaryTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|主键类型名(PrimaryTypeName)]的值:[$(pobjPrjTabEN.PrimaryTypeName)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.OrderNum4Refer && undefined !== pobjPrjTabEN.OrderNum4Refer && tzDataType.isNumber(pobjPrjTabEN.OrderNum4Refer) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|引用序号(OrderNum4Refer)]的值:[$(pobjPrjTabEN.OrderNum4Refer)], 非法，应该为数值型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsNeedCheckTab && undefined !== pobjPrjTabEN.IsNeedCheckTab && tzDataType.isBoolean(pobjPrjTabEN.IsNeedCheckTab) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否需要检查表字段(IsNeedCheckTab)]的值:[$(pobjPrjTabEN.IsNeedCheckTab)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsChecked && undefined !== pobjPrjTabEN.IsChecked && tzDataType.isBoolean(pobjPrjTabEN.IsChecked) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否核实(IsChecked)]的值:[$(pobjPrjTabEN.IsChecked)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsSynchToServer && undefined !== pobjPrjTabEN.IsSynchToServer && tzDataType.isBoolean(pobjPrjTabEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否同步到Server(IsSynchToServer)]的值:[$(pobjPrjTabEN.IsSynchToServer)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynchToServerDate && undefined !== pobjPrjTabEN.SynchToServerDate && tzDataType.isString(pobjPrjTabEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|同步到Server日期(SynchToServerDate)]的值:[$(pobjPrjTabEN.SynchToServerDate)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynchToServerUser && undefined !== pobjPrjTabEN.SynchToServerUser && tzDataType.isString(pobjPrjTabEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|同步到Server用户(SynchToServerUser)]的值:[$(pobjPrjTabEN.SynchToServerUser)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsSynchToClient && undefined !== pobjPrjTabEN.IsSynchToClient && tzDataType.isBoolean(pobjPrjTabEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否同步到Client(IsSynchToClient)]的值:[$(pobjPrjTabEN.IsSynchToClient)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynchToClientDate && undefined !== pobjPrjTabEN.SynchToClientDate && tzDataType.isString(pobjPrjTabEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjPrjTabEN.SynchToClientDate)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynchToClientUser && undefined !== pobjPrjTabEN.SynchToClientUser && tzDataType.isString(pobjPrjTabEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjPrjTabEN.SynchToClientUser)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.SynSource && undefined !== pobjPrjTabEN.SynSource && tzDataType.isString(pobjPrjTabEN.SynSource) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|同步来源(SynSource)]的值:[$(pobjPrjTabEN.SynSource)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.RelaViewId && undefined !== pobjPrjTabEN.RelaViewId && tzDataType.isString(pobjPrjTabEN.RelaViewId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|RelaViewId(RelaViewId)]的值:[$(pobjPrjTabEN.RelaViewId)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.Owner && undefined !== pobjPrjTabEN.Owner && tzDataType.isString(pobjPrjTabEN.Owner) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|拥有者(Owner)]的值:[$(pobjPrjTabEN.Owner)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabEnName && undefined !== pobjPrjTabEN.TabEnName && tzDataType.isString(pobjPrjTabEN.TabEnName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|表英文详细名(TabEnName)]的值:[$(pobjPrjTabEN.TabEnName)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsNeedTransCode && undefined !== pobjPrjTabEN.IsNeedTransCode && tzDataType.isBoolean(pobjPrjTabEN.IsNeedTransCode) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否需要转换代码(IsNeedTransCode)]的值:[$(pobjPrjTabEN.IsNeedTransCode)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.TabName_B && undefined !== pobjPrjTabEN.TabName_B && tzDataType.isString(pobjPrjTabEN.TabName_B) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|表名_后备(TabName_B)]的值:[$(pobjPrjTabEN.TabName_B)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.DataBaseName && undefined !== pobjPrjTabEN.DataBaseName && tzDataType.isString(pobjPrjTabEN.DataBaseName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|数据库名(DataBaseName)]的值:[$(pobjPrjTabEN.DataBaseName)], 非法，应该为字符型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsNationStandard && undefined !== pobjPrjTabEN.IsNationStandard && tzDataType.isBoolean(pobjPrjTabEN.IsNationStandard) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否国标(IsNationStandard)]的值:[$(pobjPrjTabEN.IsNationStandard)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsParaTab && undefined !== pobjPrjTabEN.IsParaTab && tzDataType.isBoolean(pobjPrjTabEN.IsParaTab) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否参数表(IsParaTab)]的值:[$(pobjPrjTabEN.IsParaTab)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
if (null !== pobjPrjTabEN.IsArchive && undefined !== pobjPrjTabEN.IsArchive && tzDataType.isBoolean(pobjPrjTabEN.IsArchive) === false)
{
 throw new Error("(errid:Busi000156)字段[工程表(PrjTab)|是否存档(IsArchive)]的值:[$(pobjPrjTabEN.IsArchive)], 非法，应该为布尔型!(clsPrjTabBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjPrjTabEN.PrjId != null && GetStrLen(pobjPrjTabEN.PrjId) !=  4)
{
 throw ("(errid:Busi000157)字段[工程表|工程ID]作为外键字段,长度应该为4!(clsPrjTabBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPrjTabEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsPrjTabBL.prototype.CheckProperty4Update  = function(pobjPrjTabEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjPrjTabEN.TabId && GetStrLen(pobjPrjTabEN.TabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|表ID(TabId)]的长度不能超过8!值:$(pobjPrjTabEN.TabId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabName && GetStrLen(pobjPrjTabEN.TabName) > 100)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|表名(TabName)]的长度不能超过100!值:$(pobjPrjTabEN.TabName)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabCnName && GetStrLen(pobjPrjTabEN.TabCnName) > 200)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|表中文名(TabCnName)]的长度不能超过200!值:$(pobjPrjTabEN.TabCnName)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.PrjId && GetStrLen(pobjPrjTabEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|工程ID(PrjId)]的长度不能超过4!值:$(pobjPrjTabEN.PrjId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SQLDSTypeId && GetStrLen(pobjPrjTabEN.SQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|数据源类型(SQLDSTypeId)]的长度不能超过2!值:$(pobjPrjTabEN.SQLDSTypeId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabStateId && GetStrLen(pobjPrjTabEN.TabStateId) > 2)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|表状态ID(TabStateId)]的长度不能超过2!值:$(pobjPrjTabEN.TabStateId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.FuncModuleAgcId && GetStrLen(pobjPrjTabEN.FuncModuleAgcId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|功能模块Id(FuncModuleAgcId)]的长度不能超过8!值:$(pobjPrjTabEN.FuncModuleAgcId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.KeyWord && GetStrLen(pobjPrjTabEN.KeyWord) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|关键字(KeyWord)]的长度不能超过50!值:$(pobjPrjTabEN.KeyWord)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabTypeId && GetStrLen(pobjPrjTabEN.TabTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|表类型Id(TabTypeId)]的长度不能超过4!值:$(pobjPrjTabEN.TabTypeId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabMainTypeId && GetStrLen(pobjPrjTabEN.TabMainTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|表主类型Id(TabMainTypeId)]的长度不能超过4!值:$(pobjPrjTabEN.TabMainTypeId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.RelaTabId4View && GetStrLen(pobjPrjTabEN.RelaTabId4View) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|视图的相关表ID(RelaTabId4View)]的长度不能超过8!值:$(pobjPrjTabEN.RelaTabId4View)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.ParentClass && GetStrLen(pobjPrjTabEN.ParentClass) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|父类(ParentClass)]的长度不能超过50!值:$(pobjPrjTabEN.ParentClass)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.CacheModeId && GetStrLen(pobjPrjTabEN.CacheModeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|缓存方式Id(CacheModeId)]的长度不能超过2!值:$(pobjPrjTabEN.CacheModeId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.CacheClassifyField && GetStrLen(pobjPrjTabEN.CacheClassifyField) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|缓存分类字段(CacheClassifyField)]的长度不能超过8!值:$(pobjPrjTabEN.CacheClassifyField)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.UpdUserId && GetStrLen(pobjPrjTabEN.UpdUserId) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|修改用户Id(UpdUserId)]的长度不能超过20!值:$(pobjPrjTabEN.UpdUserId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.UpdDate && GetStrLen(pobjPrjTabEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjPrjTabEN.UpdDate)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.Memo && GetStrLen(pobjPrjTabEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|说明(Memo)]的长度不能超过1000!值:$(pobjPrjTabEN.Memo)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.ErrMsg && GetStrLen(pobjPrjTabEN.ErrMsg) > 8000)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|错误信息(ErrMsg)]的长度不能超过8000!值:$(pobjPrjTabEN.ErrMsg)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.KeyFldId && GetStrLen(pobjPrjTabEN.KeyFldId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|关键字段Id(KeyFldId)]的长度不能超过8!值:$(pobjPrjTabEN.KeyFldId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.KeyFldName && GetStrLen(pobjPrjTabEN.KeyFldName) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|关键字段名(KeyFldName)]的长度不能超过50!值:$(pobjPrjTabEN.KeyFldName)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.PrimaryTypeId && GetStrLen(pobjPrjTabEN.PrimaryTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|主键类型ID(PrimaryTypeId)]的长度不能超过2!值:$(pobjPrjTabEN.PrimaryTypeId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.PrimaryTypeName && GetStrLen(pobjPrjTabEN.PrimaryTypeName) > 30)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|主键类型名(PrimaryTypeName)]的长度不能超过30!值:$(pobjPrjTabEN.PrimaryTypeName)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynchToServerDate && GetStrLen(pobjPrjTabEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjPrjTabEN.SynchToServerDate)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynchToServerUser && GetStrLen(pobjPrjTabEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjPrjTabEN.SynchToServerUser)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynchToClientDate && GetStrLen(pobjPrjTabEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjPrjTabEN.SynchToClientDate)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynchToClientUser && GetStrLen(pobjPrjTabEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjPrjTabEN.SynchToClientUser)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynSource && GetStrLen(pobjPrjTabEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|同步来源(SynSource)]的长度不能超过50!值:$(pobjPrjTabEN.SynSource)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.RelaViewId && GetStrLen(pobjPrjTabEN.RelaViewId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|RelaViewId(RelaViewId)]的长度不能超过8!值:$(pobjPrjTabEN.RelaViewId)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.Owner && GetStrLen(pobjPrjTabEN.Owner) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|拥有者(Owner)]的长度不能超过50!值:$(pobjPrjTabEN.Owner)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabEnName && GetStrLen(pobjPrjTabEN.TabEnName) > 200)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|表英文详细名(TabEnName)]的长度不能超过200!值:$(pobjPrjTabEN.TabEnName)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabName_B && GetStrLen(pobjPrjTabEN.TabName_B) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|表名_后备(TabName_B)]的长度不能超过50!值:$(pobjPrjTabEN.TabName_B)(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.DataBaseName && GetStrLen(pobjPrjTabEN.DataBaseName) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程表(PrjTab)|数据库名(DataBaseName)]的长度不能超过50!值:$(pobjPrjTabEN.DataBaseName)(clsPrjTabBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjPrjTabEN.TabId && undefined !== pobjPrjTabEN.TabId && tzDataType.isString(pobjPrjTabEN.TabId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|表ID(TabId)]的值:[$(pobjPrjTabEN.TabId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabName && undefined !== pobjPrjTabEN.TabName && tzDataType.isString(pobjPrjTabEN.TabName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|表名(TabName)]的值:[$(pobjPrjTabEN.TabName)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabCnName && undefined !== pobjPrjTabEN.TabCnName && tzDataType.isString(pobjPrjTabEN.TabCnName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|表中文名(TabCnName)]的值:[$(pobjPrjTabEN.TabCnName)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.PrjId && undefined !== pobjPrjTabEN.PrjId && tzDataType.isString(pobjPrjTabEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|工程ID(PrjId)]的值:[$(pobjPrjTabEN.PrjId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SQLDSTypeId && undefined !== pobjPrjTabEN.SQLDSTypeId && tzDataType.isString(pobjPrjTabEN.SQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|数据源类型(SQLDSTypeId)]的值:[$(pobjPrjTabEN.SQLDSTypeId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabStateId && undefined !== pobjPrjTabEN.TabStateId && tzDataType.isString(pobjPrjTabEN.TabStateId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|表状态ID(TabStateId)]的值:[$(pobjPrjTabEN.TabStateId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.FuncModuleAgcId && undefined !== pobjPrjTabEN.FuncModuleAgcId && tzDataType.isString(pobjPrjTabEN.FuncModuleAgcId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|功能模块Id(FuncModuleAgcId)]的值:[$(pobjPrjTabEN.FuncModuleAgcId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsReleToSqlTab && undefined !== pobjPrjTabEN.IsReleToSqlTab && tzDataType.isBoolean(pobjPrjTabEN.IsReleToSqlTab) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否与SQL表相关(IsReleToSqlTab)]的值:[$(pobjPrjTabEN.IsReleToSqlTab)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.KeyWord && undefined !== pobjPrjTabEN.KeyWord && tzDataType.isString(pobjPrjTabEN.KeyWord) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|关键字(KeyWord)]的值:[$(pobjPrjTabEN.KeyWord)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabTypeId && undefined !== pobjPrjTabEN.TabTypeId && tzDataType.isString(pobjPrjTabEN.TabTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|表类型Id(TabTypeId)]的值:[$(pobjPrjTabEN.TabTypeId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabMainTypeId && undefined !== pobjPrjTabEN.TabMainTypeId && tzDataType.isString(pobjPrjTabEN.TabMainTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|表主类型Id(TabMainTypeId)]的值:[$(pobjPrjTabEN.TabMainTypeId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.RelaTabId4View && undefined !== pobjPrjTabEN.RelaTabId4View && tzDataType.isString(pobjPrjTabEN.RelaTabId4View) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|视图的相关表ID(RelaTabId4View)]的值:[$(pobjPrjTabEN.RelaTabId4View)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsNeedGeneIndexer && undefined !== pobjPrjTabEN.IsNeedGeneIndexer && tzDataType.isBoolean(pobjPrjTabEN.IsNeedGeneIndexer) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否需要生成索引器(IsNeedGeneIndexer)]的值:[$(pobjPrjTabEN.IsNeedGeneIndexer)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.ParentClass && undefined !== pobjPrjTabEN.ParentClass && tzDataType.isString(pobjPrjTabEN.ParentClass) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|父类(ParentClass)]的值:[$(pobjPrjTabEN.ParentClass)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsUseCache && undefined !== pobjPrjTabEN.IsUseCache && tzDataType.isBoolean(pobjPrjTabEN.IsUseCache) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否使用Cache(IsUseCache)]的值:[$(pobjPrjTabEN.IsUseCache)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.CacheModeId && undefined !== pobjPrjTabEN.CacheModeId && tzDataType.isString(pobjPrjTabEN.CacheModeId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|缓存方式Id(CacheModeId)]的值:[$(pobjPrjTabEN.CacheModeId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.CacheClassifyField && undefined !== pobjPrjTabEN.CacheClassifyField && tzDataType.isString(pobjPrjTabEN.CacheClassifyField) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|缓存分类字段(CacheClassifyField)]的值:[$(pobjPrjTabEN.CacheClassifyField)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.UpdUserId && undefined !== pobjPrjTabEN.UpdUserId && tzDataType.isString(pobjPrjTabEN.UpdUserId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|修改用户Id(UpdUserId)]的值:[$(pobjPrjTabEN.UpdUserId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.UpdDate && undefined !== pobjPrjTabEN.UpdDate && tzDataType.isString(pobjPrjTabEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|修改日期(UpdDate)]的值:[$(pobjPrjTabEN.UpdDate)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.Memo && undefined !== pobjPrjTabEN.Memo && tzDataType.isString(pobjPrjTabEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|说明(Memo)]的值:[$(pobjPrjTabEN.Memo)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.ErrMsg && undefined !== pobjPrjTabEN.ErrMsg && tzDataType.isString(pobjPrjTabEN.ErrMsg) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|错误信息(ErrMsg)]的值:[$(pobjPrjTabEN.ErrMsg)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.KeyFldId && undefined !== pobjPrjTabEN.KeyFldId && tzDataType.isString(pobjPrjTabEN.KeyFldId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|关键字段Id(KeyFldId)]的值:[$(pobjPrjTabEN.KeyFldId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.KeyFldName && undefined !== pobjPrjTabEN.KeyFldName && tzDataType.isString(pobjPrjTabEN.KeyFldName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|关键字段名(KeyFldName)]的值:[$(pobjPrjTabEN.KeyFldName)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.PrimaryTypeId && undefined !== pobjPrjTabEN.PrimaryTypeId && tzDataType.isString(pobjPrjTabEN.PrimaryTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|主键类型ID(PrimaryTypeId)]的值:[$(pobjPrjTabEN.PrimaryTypeId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.PrimaryTypeName && undefined !== pobjPrjTabEN.PrimaryTypeName && tzDataType.isString(pobjPrjTabEN.PrimaryTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|主键类型名(PrimaryTypeName)]的值:[$(pobjPrjTabEN.PrimaryTypeName)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.OrderNum4Refer && undefined !== pobjPrjTabEN.OrderNum4Refer && tzDataType.isNumber(pobjPrjTabEN.OrderNum4Refer) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|引用序号(OrderNum4Refer)]的值:[$(pobjPrjTabEN.OrderNum4Refer)], 非法，应该为数值型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsNeedCheckTab && undefined !== pobjPrjTabEN.IsNeedCheckTab && tzDataType.isBoolean(pobjPrjTabEN.IsNeedCheckTab) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否需要检查表字段(IsNeedCheckTab)]的值:[$(pobjPrjTabEN.IsNeedCheckTab)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsChecked && undefined !== pobjPrjTabEN.IsChecked && tzDataType.isBoolean(pobjPrjTabEN.IsChecked) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否核实(IsChecked)]的值:[$(pobjPrjTabEN.IsChecked)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsSynchToServer && undefined !== pobjPrjTabEN.IsSynchToServer && tzDataType.isBoolean(pobjPrjTabEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否同步到Server(IsSynchToServer)]的值:[$(pobjPrjTabEN.IsSynchToServer)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynchToServerDate && undefined !== pobjPrjTabEN.SynchToServerDate && tzDataType.isString(pobjPrjTabEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|同步到Server日期(SynchToServerDate)]的值:[$(pobjPrjTabEN.SynchToServerDate)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynchToServerUser && undefined !== pobjPrjTabEN.SynchToServerUser && tzDataType.isString(pobjPrjTabEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|同步到Server用户(SynchToServerUser)]的值:[$(pobjPrjTabEN.SynchToServerUser)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsSynchToClient && undefined !== pobjPrjTabEN.IsSynchToClient && tzDataType.isBoolean(pobjPrjTabEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否同步到Client(IsSynchToClient)]的值:[$(pobjPrjTabEN.IsSynchToClient)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynchToClientDate && undefined !== pobjPrjTabEN.SynchToClientDate && tzDataType.isString(pobjPrjTabEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjPrjTabEN.SynchToClientDate)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynchToClientUser && undefined !== pobjPrjTabEN.SynchToClientUser && tzDataType.isString(pobjPrjTabEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjPrjTabEN.SynchToClientUser)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.SynSource && undefined !== pobjPrjTabEN.SynSource && tzDataType.isString(pobjPrjTabEN.SynSource) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|同步来源(SynSource)]的值:[$(pobjPrjTabEN.SynSource)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.RelaViewId && undefined !== pobjPrjTabEN.RelaViewId && tzDataType.isString(pobjPrjTabEN.RelaViewId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|RelaViewId(RelaViewId)]的值:[$(pobjPrjTabEN.RelaViewId)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.Owner && undefined !== pobjPrjTabEN.Owner && tzDataType.isString(pobjPrjTabEN.Owner) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|拥有者(Owner)]的值:[$(pobjPrjTabEN.Owner)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabEnName && undefined !== pobjPrjTabEN.TabEnName && tzDataType.isString(pobjPrjTabEN.TabEnName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|表英文详细名(TabEnName)]的值:[$(pobjPrjTabEN.TabEnName)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsNeedTransCode && undefined !== pobjPrjTabEN.IsNeedTransCode && tzDataType.isBoolean(pobjPrjTabEN.IsNeedTransCode) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否需要转换代码(IsNeedTransCode)]的值:[$(pobjPrjTabEN.IsNeedTransCode)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.TabName_B && undefined !== pobjPrjTabEN.TabName_B && tzDataType.isString(pobjPrjTabEN.TabName_B) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|表名_后备(TabName_B)]的值:[$(pobjPrjTabEN.TabName_B)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.DataBaseName && undefined !== pobjPrjTabEN.DataBaseName && tzDataType.isString(pobjPrjTabEN.DataBaseName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|数据库名(DataBaseName)]的值:[$(pobjPrjTabEN.DataBaseName)], 非法，应该为字符型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsNationStandard && undefined !== pobjPrjTabEN.IsNationStandard && tzDataType.isBoolean(pobjPrjTabEN.IsNationStandard) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否国标(IsNationStandard)]的值:[$(pobjPrjTabEN.IsNationStandard)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsParaTab && undefined !== pobjPrjTabEN.IsParaTab && tzDataType.isBoolean(pobjPrjTabEN.IsParaTab) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否参数表(IsParaTab)]的值:[$(pobjPrjTabEN.IsParaTab)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
if (null !== pobjPrjTabEN.IsArchive && undefined !== pobjPrjTabEN.IsArchive && tzDataType.isBoolean(pobjPrjTabEN.IsArchive) === false)
{
 throw new Error("(errid:Busi000159)字段[工程表(PrjTab)|是否存档(IsArchive)]的值:[$(pobjPrjTabEN.IsArchive)], 非法，应该为布尔型!(clsPrjTabBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPrjTabEN.TabId 
 || null !== pobjPrjTabEN.TabId && pobjPrjTabEN.TabId.toString()  ===  ""
 || null !== pobjPrjTabEN.TabId && pobjPrjTabEN.TabId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[工程表|表ID]不能为空(NULL)!(clsPrjTabBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjPrjTabEN.PrjId != null && GetStrLen(pobjPrjTabEN.PrjId) !=  4)
{
 throw ("(errid:Busi000161)字段[工程表|工程ID]作为外键字段,长度应该为4!(clsPrjTabBL:CheckPropertyNew)");
}

 pobjPrjTabEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200502010556
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsPrjTabBL.GetJSONStrByObj  = function(pobjPrjTabEN)
{
pobjPrjTabEN.sf_UpdFldSetStr = pobjPrjTabEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjPrjTabEN);
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
 /// 日期:20200502010556
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsPrjTabBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrPrjTabObjLst = new Array();
if (strJSON === "")
{
return arrPrjTabObjLst;
}
try
{
arrPrjTabObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPrjTabObjLst;
}
return arrPrjTabObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200502010556
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsPrjTabBL.GetObjByJSONStr  = function(strJSON)
{
var pobjPrjTabEN = new clsPrjTabEN();
if (strJSON === "")
{
return pobjPrjTabEN;
}
try
{
pobjPrjTabEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPrjTabEN;
}
return pobjPrjTabEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objPrjTabENS">源简化对象</param>
 /// <param name = "objPrjTabENT">目标对象</param>
clsPrjTabBL.CopyObjFromSimObj = function(objPrjTabENS, objPrjTabENT) 
{
objPrjTabENT.TabId = objPrjTabENS.TabId; //表ID
objPrjTabENT.TabName = objPrjTabENS.TabName; //表名
objPrjTabENT.TabCnName = objPrjTabENS.TabCnName; //表中文名
objPrjTabENT.PrjId = objPrjTabENS.PrjId; //工程ID
objPrjTabENT.SQLDSTypeId = objPrjTabENS.SQLDSTypeId; //数据源类型
objPrjTabENT.TabStateId = objPrjTabENS.TabStateId; //表状态ID
objPrjTabENT.FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId; //功能模块Id
objPrjTabENT.IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objPrjTabENT.KeyWord = objPrjTabENS.KeyWord; //关键字
objPrjTabENT.TabTypeId = objPrjTabENS.TabTypeId; //表类型Id
objPrjTabENT.TabMainTypeId = objPrjTabENS.TabMainTypeId; //表主类型Id
objPrjTabENT.RelaTabId4View = objPrjTabENS.RelaTabId4View; //视图的相关表ID
objPrjTabENT.IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objPrjTabENT.ParentClass = objPrjTabENS.ParentClass; //父类
objPrjTabENT.IsUseCache = objPrjTabENS.IsUseCache; //是否使用Cache
objPrjTabENT.CacheModeId = objPrjTabENS.CacheModeId; //缓存方式Id
objPrjTabENT.CacheClassifyField = objPrjTabENS.CacheClassifyField; //缓存分类字段
objPrjTabENT.UpdUserId = objPrjTabENS.UpdUserId; //修改用户Id
objPrjTabENT.UpdDate = objPrjTabENS.UpdDate; //修改日期
objPrjTabENT.Memo = objPrjTabENS.Memo; //说明
objPrjTabENT.ErrMsg = objPrjTabENS.ErrMsg; //错误信息
objPrjTabENT.KeyFldId = objPrjTabENS.KeyFldId; //关键字段Id
objPrjTabENT.KeyFldName = objPrjTabENS.KeyFldName; //关键字段名
objPrjTabENT.PrimaryTypeId = objPrjTabENS.PrimaryTypeId; //主键类型ID
objPrjTabENT.PrimaryTypeName = objPrjTabENS.PrimaryTypeName; //主键类型名
objPrjTabENT.OrderNum4Refer = objPrjTabENS.OrderNum4Refer; //引用序号
objPrjTabENT.IsNeedCheckTab = objPrjTabENS.IsNeedCheckTab; //是否需要检查表字段
objPrjTabENT.IsChecked = objPrjTabENS.IsChecked; //是否核实
objPrjTabENT.IsSynchToServer = objPrjTabENS.IsSynchToServer; //是否同步到Server
objPrjTabENT.SynchToServerDate = objPrjTabENS.SynchToServerDate; //同步到Server日期
objPrjTabENT.SynchToServerUser = objPrjTabENS.SynchToServerUser; //同步到Server用户
objPrjTabENT.IsSynchToClient = objPrjTabENS.IsSynchToClient; //是否同步到Client
objPrjTabENT.SynchToClientDate = objPrjTabENS.SynchToClientDate; //同步到Client库日期
objPrjTabENT.SynchToClientUser = objPrjTabENS.SynchToClientUser; //同步到Client库用户
objPrjTabENT.SynSource = objPrjTabENS.SynSource; //同步来源
objPrjTabENT.RelaViewId = objPrjTabENS.RelaViewId; //RelaViewId
objPrjTabENT.Owner = objPrjTabENS.Owner; //拥有者
objPrjTabENT.TabEnName = objPrjTabENS.TabEnName; //表英文详细名
objPrjTabENT.IsNeedTransCode = objPrjTabENS.IsNeedTransCode; //是否需要转换代码
objPrjTabENT.TabName_B = objPrjTabENS.TabName_B; //表名_后备
objPrjTabENT.DataBaseName = objPrjTabENS.DataBaseName; //数据库名
objPrjTabENT.IsNationStandard = objPrjTabENS.IsNationStandard; //是否国标
objPrjTabENT.IsParaTab = objPrjTabENS.IsParaTab; //是否参数表
objPrjTabENT.IsArchive = objPrjTabENS.IsArchive; //是否存档
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objPrjTabENS">源对象</param>
 /// <param name = "objPrjTabENT">目标对象</param>
clsPrjTabBL.CopyObjTo = function(objPrjTabENS , objPrjTabENT ) 
{
objPrjTabENT.TabId = objPrjTabENS.TabId; //表ID
objPrjTabENT.TabName = objPrjTabENS.TabName; //表名
objPrjTabENT.TabCnName = objPrjTabENS.TabCnName; //表中文名
objPrjTabENT.PrjId = objPrjTabENS.PrjId; //工程ID
objPrjTabENT.SQLDSTypeId = objPrjTabENS.SQLDSTypeId; //数据源类型
objPrjTabENT.TabStateId = objPrjTabENS.TabStateId; //表状态ID
objPrjTabENT.FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId; //功能模块Id
objPrjTabENT.IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objPrjTabENT.KeyWord = objPrjTabENS.KeyWord; //关键字
objPrjTabENT.TabTypeId = objPrjTabENS.TabTypeId; //表类型Id
objPrjTabENT.TabMainTypeId = objPrjTabENS.TabMainTypeId; //表主类型Id
objPrjTabENT.RelaTabId4View = objPrjTabENS.RelaTabId4View; //视图的相关表ID
objPrjTabENT.IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objPrjTabENT.ParentClass = objPrjTabENS.ParentClass; //父类
objPrjTabENT.IsUseCache = objPrjTabENS.IsUseCache; //是否使用Cache
objPrjTabENT.CacheModeId = objPrjTabENS.CacheModeId; //缓存方式Id
objPrjTabENT.CacheClassifyField = objPrjTabENS.CacheClassifyField; //缓存分类字段
objPrjTabENT.UpdUserId = objPrjTabENS.UpdUserId; //修改用户Id
objPrjTabENT.UpdDate = objPrjTabENS.UpdDate; //修改日期
objPrjTabENT.Memo = objPrjTabENS.Memo; //说明
objPrjTabENT.ErrMsg = objPrjTabENS.ErrMsg; //错误信息
objPrjTabENT.KeyFldId = objPrjTabENS.KeyFldId; //关键字段Id
objPrjTabENT.KeyFldName = objPrjTabENS.KeyFldName; //关键字段名
objPrjTabENT.PrimaryTypeId = objPrjTabENS.PrimaryTypeId; //主键类型ID
objPrjTabENT.PrimaryTypeName = objPrjTabENS.PrimaryTypeName; //主键类型名
objPrjTabENT.OrderNum4Refer = objPrjTabENS.OrderNum4Refer; //引用序号
objPrjTabENT.IsNeedCheckTab = objPrjTabENS.IsNeedCheckTab; //是否需要检查表字段
objPrjTabENT.IsChecked = objPrjTabENS.IsChecked; //是否核实
objPrjTabENT.IsSynchToServer = objPrjTabENS.IsSynchToServer; //是否同步到Server
objPrjTabENT.SynchToServerDate = objPrjTabENS.SynchToServerDate; //同步到Server日期
objPrjTabENT.SynchToServerUser = objPrjTabENS.SynchToServerUser; //同步到Server用户
objPrjTabENT.IsSynchToClient = objPrjTabENS.IsSynchToClient; //是否同步到Client
objPrjTabENT.SynchToClientDate = objPrjTabENS.SynchToClientDate; //同步到Client库日期
objPrjTabENT.SynchToClientUser = objPrjTabENS.SynchToClientUser; //同步到Client库用户
objPrjTabENT.SynSource = objPrjTabENS.SynSource; //同步来源
objPrjTabENT.RelaViewId = objPrjTabENS.RelaViewId; //RelaViewId
objPrjTabENT.Owner = objPrjTabENS.Owner; //拥有者
objPrjTabENT.TabEnName = objPrjTabENS.TabEnName; //表英文详细名
objPrjTabENT.IsNeedTransCode = objPrjTabENS.IsNeedTransCode; //是否需要转换代码
objPrjTabENT.TabName_B = objPrjTabENS.TabName_B; //表名_后备
objPrjTabENT.DataBaseName = objPrjTabENS.DataBaseName; //数据库名
objPrjTabENT.IsNationStandard = objPrjTabENS.IsNationStandard; //是否国标
objPrjTabENT.IsParaTab = objPrjTabENS.IsParaTab; //是否参数表
objPrjTabENT.IsArchive = objPrjTabENS.IsArchive; //是否存档
objPrjTabENT.sf_UpdFldSetStr = objPrjTabENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objPrjTabENS">源对象</param>
 /// <param name = "objPrjTabENT">目标对象</param>
clsPrjTabBL.CopyObjToSimObj = function(objPrjTabENS , objPrjTabENT ) 
{
objPrjTabENT.TabId = objPrjTabENS.TabId; //表ID
objPrjTabENT.TabName = objPrjTabENS.TabName; //表名
objPrjTabENT.TabCnName = objPrjTabENS.TabCnName; //表中文名
objPrjTabENT.PrjId = objPrjTabENS.PrjId; //工程ID
objPrjTabENT.SQLDSTypeId = objPrjTabENS.SQLDSTypeId; //数据源类型
objPrjTabENT.TabStateId = objPrjTabENS.TabStateId; //表状态ID
objPrjTabENT.FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId; //功能模块Id
objPrjTabENT.IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objPrjTabENT.KeyWord = objPrjTabENS.KeyWord; //关键字
objPrjTabENT.TabTypeId = objPrjTabENS.TabTypeId; //表类型Id
objPrjTabENT.TabMainTypeId = objPrjTabENS.TabMainTypeId; //表主类型Id
objPrjTabENT.RelaTabId4View = objPrjTabENS.RelaTabId4View; //视图的相关表ID
objPrjTabENT.IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objPrjTabENT.ParentClass = objPrjTabENS.ParentClass; //父类
objPrjTabENT.IsUseCache = objPrjTabENS.IsUseCache; //是否使用Cache
objPrjTabENT.CacheModeId = objPrjTabENS.CacheModeId; //缓存方式Id
objPrjTabENT.CacheClassifyField = objPrjTabENS.CacheClassifyField; //缓存分类字段
objPrjTabENT.UpdUserId = objPrjTabENS.UpdUserId; //修改用户Id
objPrjTabENT.UpdDate = objPrjTabENS.UpdDate; //修改日期
objPrjTabENT.Memo = objPrjTabENS.Memo; //说明
objPrjTabENT.ErrMsg = objPrjTabENS.ErrMsg; //错误信息
objPrjTabENT.KeyFldId = objPrjTabENS.KeyFldId; //关键字段Id
objPrjTabENT.KeyFldName = objPrjTabENS.KeyFldName; //关键字段名
objPrjTabENT.PrimaryTypeId = objPrjTabENS.PrimaryTypeId; //主键类型ID
objPrjTabENT.PrimaryTypeName = objPrjTabENS.PrimaryTypeName; //主键类型名
objPrjTabENT.OrderNum4Refer = objPrjTabENS.OrderNum4Refer; //引用序号
objPrjTabENT.IsNeedCheckTab = objPrjTabENS.IsNeedCheckTab; //是否需要检查表字段
objPrjTabENT.IsChecked = objPrjTabENS.IsChecked; //是否核实
objPrjTabENT.IsSynchToServer = objPrjTabENS.IsSynchToServer; //是否同步到Server
objPrjTabENT.SynchToServerDate = objPrjTabENS.SynchToServerDate; //同步到Server日期
objPrjTabENT.SynchToServerUser = objPrjTabENS.SynchToServerUser; //同步到Server用户
objPrjTabENT.IsSynchToClient = objPrjTabENS.IsSynchToClient; //是否同步到Client
objPrjTabENT.SynchToClientDate = objPrjTabENS.SynchToClientDate; //同步到Client库日期
objPrjTabENT.SynchToClientUser = objPrjTabENS.SynchToClientUser; //同步到Client库用户
objPrjTabENT.SynSource = objPrjTabENS.SynSource; //同步来源
objPrjTabENT.RelaViewId = objPrjTabENS.RelaViewId; //RelaViewId
objPrjTabENT.Owner = objPrjTabENS.Owner; //拥有者
objPrjTabENT.TabEnName = objPrjTabENS.TabEnName; //表英文详细名
objPrjTabENT.IsNeedTransCode = objPrjTabENS.IsNeedTransCode; //是否需要转换代码
objPrjTabENT.TabName_B = objPrjTabENS.TabName_B; //表名_后备
objPrjTabENT.DataBaseName = objPrjTabENS.DataBaseName; //数据库名
objPrjTabENT.IsNationStandard = objPrjTabENS.IsNationStandard; //是否国标
objPrjTabENT.IsParaTab = objPrjTabENS.IsParaTab; //是否参数表
objPrjTabENT.IsArchive = objPrjTabENS.IsArchive; //是否存档
objPrjTabENT.sf_UpdFldSetStr = objPrjTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objPrjTabENT.sf_FldComparisonOp = objPrjTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objPrjTabENS">源简化对象</param>
 /// <param name = "objPrjTabENT">目标对象</param>
clsPrjTabBL.CopyObjFromSimObj4Upd = function(objPrjTabENS, objPrjTabENT )
 {
   var strsf_UpdFldSetStr = objPrjTabENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsPrjTabEN.con_TabId)  >= 0)
{
objPrjTabENT.TabId = objPrjTabENS.TabId; //表ID
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_TabName)  >= 0)
{
objPrjTabENT.TabName = objPrjTabENS.TabName; //表名
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_TabCnName)  >= 0)
{
objPrjTabENT.TabCnName = objPrjTabENS.TabCnName; //表中文名
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_PrjId)  >= 0)
{
objPrjTabENT.PrjId = objPrjTabENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_SQLDSTypeId)  >= 0)
{
objPrjTabENT.SQLDSTypeId = objPrjTabENS.SQLDSTypeId; //数据源类型
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_TabStateId)  >= 0)
{
objPrjTabENT.TabStateId = objPrjTabENS.TabStateId; //表状态ID
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_FuncModuleAgcId)  >= 0)
{
objPrjTabENT.FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId; //功能模块Id
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsReleToSqlTab)  >= 0)
{
objPrjTabENT.IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_KeyWord)  >= 0)
{
objPrjTabENT.KeyWord = objPrjTabENS.KeyWord; //关键字
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_TabTypeId)  >= 0)
{
objPrjTabENT.TabTypeId = objPrjTabENS.TabTypeId; //表类型Id
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_TabMainTypeId)  >= 0)
{
objPrjTabENT.TabMainTypeId = objPrjTabENS.TabMainTypeId; //表主类型Id
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_RelaTabId4View)  >= 0)
{
objPrjTabENT.RelaTabId4View = objPrjTabENS.RelaTabId4View; //视图的相关表ID
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsNeedGeneIndexer)  >= 0)
{
objPrjTabENT.IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_ParentClass)  >= 0)
{
objPrjTabENT.ParentClass = objPrjTabENS.ParentClass; //父类
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsUseCache)  >= 0)
{
objPrjTabENT.IsUseCache = objPrjTabENS.IsUseCache; //是否使用Cache
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_CacheModeId)  >= 0)
{
objPrjTabENT.CacheModeId = objPrjTabENS.CacheModeId; //缓存方式Id
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_CacheClassifyField)  >= 0)
{
objPrjTabENT.CacheClassifyField = objPrjTabENS.CacheClassifyField; //缓存分类字段
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_UpdUserId)  >= 0)
{
objPrjTabENT.UpdUserId = objPrjTabENS.UpdUserId; //修改用户Id
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_UpdDate)  >= 0)
{
objPrjTabENT.UpdDate = objPrjTabENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_Memo)  >= 0)
{
objPrjTabENT.Memo = objPrjTabENS.Memo; //说明
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_ErrMsg)  >= 0)
{
objPrjTabENT.ErrMsg = objPrjTabENS.ErrMsg; //错误信息
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_KeyFldId)  >= 0)
{
objPrjTabENT.KeyFldId = objPrjTabENS.KeyFldId; //关键字段Id
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_KeyFldName)  >= 0)
{
objPrjTabENT.KeyFldName = objPrjTabENS.KeyFldName; //关键字段名
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_PrimaryTypeId)  >= 0)
{
objPrjTabENT.PrimaryTypeId = objPrjTabENS.PrimaryTypeId; //主键类型ID
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_PrimaryTypeName)  >= 0)
{
objPrjTabENT.PrimaryTypeName = objPrjTabENS.PrimaryTypeName; //主键类型名
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_OrderNum4Refer)  >= 0)
{
objPrjTabENT.OrderNum4Refer = objPrjTabENS.OrderNum4Refer; //引用序号
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsNeedCheckTab)  >= 0)
{
objPrjTabENT.IsNeedCheckTab = objPrjTabENS.IsNeedCheckTab; //是否需要检查表字段
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsChecked)  >= 0)
{
objPrjTabENT.IsChecked = objPrjTabENS.IsChecked; //是否核实
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsSynchToServer)  >= 0)
{
objPrjTabENT.IsSynchToServer = objPrjTabENS.IsSynchToServer; //是否同步到Server
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_SynchToServerDate)  >= 0)
{
objPrjTabENT.SynchToServerDate = objPrjTabENS.SynchToServerDate; //同步到Server日期
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_SynchToServerUser)  >= 0)
{
objPrjTabENT.SynchToServerUser = objPrjTabENS.SynchToServerUser; //同步到Server用户
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsSynchToClient)  >= 0)
{
objPrjTabENT.IsSynchToClient = objPrjTabENS.IsSynchToClient; //是否同步到Client
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_SynchToClientDate)  >= 0)
{
objPrjTabENT.SynchToClientDate = objPrjTabENS.SynchToClientDate; //同步到Client库日期
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_SynchToClientUser)  >= 0)
{
objPrjTabENT.SynchToClientUser = objPrjTabENS.SynchToClientUser; //同步到Client库用户
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_SynSource)  >= 0)
{
objPrjTabENT.SynSource = objPrjTabENS.SynSource; //同步来源
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_RelaViewId)  >= 0)
{
objPrjTabENT.RelaViewId = objPrjTabENS.RelaViewId; //RelaViewId
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_Owner)  >= 0)
{
objPrjTabENT.Owner = objPrjTabENS.Owner; //拥有者
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_TabEnName)  >= 0)
{
objPrjTabENT.TabEnName = objPrjTabENS.TabEnName; //表英文详细名
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsNeedTransCode)  >= 0)
{
objPrjTabENT.IsNeedTransCode = objPrjTabENS.IsNeedTransCode; //是否需要转换代码
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_TabName_B)  >= 0)
{
objPrjTabENT.TabName_B = objPrjTabENS.TabName_B; //表名_后备
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_DataBaseName)  >= 0)
{
objPrjTabENT.DataBaseName = objPrjTabENS.DataBaseName; //数据库名
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsNationStandard)  >= 0)
{
objPrjTabENT.IsNationStandard = objPrjTabENS.IsNationStandard; //是否国标
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsParaTab)  >= 0)
{
objPrjTabENT.IsParaTab = objPrjTabENS.IsParaTab; //是否参数表
}
if (sstrFldSet.indexOf(clsPrjTabEN.con_IsArchive)  >= 0)
{
objPrjTabENT.IsArchive = objPrjTabENS.IsArchive; //是否存档
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objPrjTabENS">源对象</param>
 /// <param name = "objPrjTabENT">目标对象</param>
clsPrjTabBL.GetSimObjFromObj = function(objPrjTabENS)
{
var objPrjTabENT = new clsPrjTabEN_Sim_js_1.clsPrjTabEN_Sim();
objPrjTabENT.TabId = objPrjTabENS.TabId; //表ID
objPrjTabENT.TabName = objPrjTabENS.TabName; //表名
objPrjTabENT.TabCnName = objPrjTabENS.TabCnName; //表中文名
objPrjTabENT.PrjId = objPrjTabENS.PrjId; //工程ID
objPrjTabENT.SQLDSTypeId = objPrjTabENS.SQLDSTypeId; //数据源类型
objPrjTabENT.TabStateId = objPrjTabENS.TabStateId; //表状态ID
objPrjTabENT.FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId; //功能模块Id
objPrjTabENT.IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objPrjTabENT.KeyWord = objPrjTabENS.KeyWord; //关键字
objPrjTabENT.TabTypeId = objPrjTabENS.TabTypeId; //表类型Id
objPrjTabENT.TabMainTypeId = objPrjTabENS.TabMainTypeId; //表主类型Id
objPrjTabENT.RelaTabId4View = objPrjTabENS.RelaTabId4View; //视图的相关表ID
objPrjTabENT.IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objPrjTabENT.ParentClass = objPrjTabENS.ParentClass; //父类
objPrjTabENT.IsUseCache = objPrjTabENS.IsUseCache; //是否使用Cache
objPrjTabENT.CacheModeId = objPrjTabENS.CacheModeId; //缓存方式Id
objPrjTabENT.CacheClassifyField = objPrjTabENS.CacheClassifyField; //缓存分类字段
objPrjTabENT.UpdUserId = objPrjTabENS.UpdUserId; //修改用户Id
objPrjTabENT.UpdDate = objPrjTabENS.UpdDate; //修改日期
objPrjTabENT.Memo = objPrjTabENS.Memo; //说明
objPrjTabENT.ErrMsg = objPrjTabENS.ErrMsg; //错误信息
objPrjTabENT.KeyFldId = objPrjTabENS.KeyFldId; //关键字段Id
objPrjTabENT.KeyFldName = objPrjTabENS.KeyFldName; //关键字段名
objPrjTabENT.PrimaryTypeId = objPrjTabENS.PrimaryTypeId; //主键类型ID
objPrjTabENT.PrimaryTypeName = objPrjTabENS.PrimaryTypeName; //主键类型名
objPrjTabENT.OrderNum4Refer = objPrjTabENS.OrderNum4Refer; //引用序号
objPrjTabENT.IsNeedCheckTab = objPrjTabENS.IsNeedCheckTab; //是否需要检查表字段
objPrjTabENT.IsChecked = objPrjTabENS.IsChecked; //是否核实
objPrjTabENT.IsSynchToServer = objPrjTabENS.IsSynchToServer; //是否同步到Server
objPrjTabENT.SynchToServerDate = objPrjTabENS.SynchToServerDate; //同步到Server日期
objPrjTabENT.SynchToServerUser = objPrjTabENS.SynchToServerUser; //同步到Server用户
objPrjTabENT.IsSynchToClient = objPrjTabENS.IsSynchToClient; //是否同步到Client
objPrjTabENT.SynchToClientDate = objPrjTabENS.SynchToClientDate; //同步到Client库日期
objPrjTabENT.SynchToClientUser = objPrjTabENS.SynchToClientUser; //同步到Client库用户
objPrjTabENT.SynSource = objPrjTabENS.SynSource; //同步来源
objPrjTabENT.RelaViewId = objPrjTabENS.RelaViewId; //RelaViewId
objPrjTabENT.Owner = objPrjTabENS.Owner; //拥有者
objPrjTabENT.TabEnName = objPrjTabENS.TabEnName; //表英文详细名
objPrjTabENT.IsNeedTransCode = objPrjTabENS.IsNeedTransCode; //是否需要转换代码
objPrjTabENT.TabName_B = objPrjTabENS.TabName_B; //表名_后备
objPrjTabENT.DataBaseName = objPrjTabENS.DataBaseName; //数据库名
objPrjTabENT.IsNationStandard = objPrjTabENS.IsNationStandard; //是否国标
objPrjTabENT.IsParaTab = objPrjTabENS.IsParaTab; //是否参数表
objPrjTabENT.IsArchive = objPrjTabENS.IsArchive; //是否存档
objPrjTabENT.sf_UpdFldSetStr = objPrjTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objPrjTabENT.sf_FldComparisonOp = objPrjTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objPrjTabENT;
}
return clsPrjTabBL;
}());
exports.clsPrjTabBL = clsPrjTabBL;
});