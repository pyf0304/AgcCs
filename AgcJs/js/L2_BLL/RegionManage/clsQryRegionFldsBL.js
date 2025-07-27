
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQryRegionFldsBL
 表名:QryRegionFlds(00050115)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:35
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
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsQryRegionFldsEN.js","../../L0_Entity/RegionManage/clsQryRegionFldsEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsQryRegionFldsEN_js_1 = require("../../L0_Entity/RegionManage/clsQryRegionFldsEN.js");
var clsQryRegionFldsEN_Sim_js_1 = require("../../L0_Entity/RegionManage/clsQryRegionFldsEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 查询区域字段(QryRegionFlds)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsQryRegionFldsBL = /** @class */ (function () {
function clsQryRegionFldsBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrQryRegionFldsObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsQryRegionFldsBL.prototype.CheckPropertyNew = function(pobjQryRegionFldsEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjQryRegionFldsEN.RegionId 
 || null !== pobjQryRegionFldsEN.RegionId && pobjQryRegionFldsEN.RegionId.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[查询区域字段|区域Id]不能为空(NULL)!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjQryRegionFldsEN.TabFldId 
 || null !== pobjQryRegionFldsEN.TabFldId && pobjQryRegionFldsEN.TabFldId.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[查询区域字段|表字段ID]不能为空(NULL)!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjQryRegionFldsEN.QueryOptionId 
 || null !== pobjQryRegionFldsEN.QueryOptionId && pobjQryRegionFldsEN.QueryOptionId.toString()  ===  ""
 || null !== pobjQryRegionFldsEN.QueryOptionId && pobjQryRegionFldsEN.QueryOptionId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[查询区域字段|查询方式Id]不能为空(NULL)!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjQryRegionFldsEN.DDLItemsOptionId 
 || null !== pobjQryRegionFldsEN.DDLItemsOptionId && pobjQryRegionFldsEN.DDLItemsOptionId.toString()  ===  ""
 || null !== pobjQryRegionFldsEN.DDLItemsOptionId && pobjQryRegionFldsEN.DDLItemsOptionId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[查询区域字段|下拉框列表选项ID]不能为空(NULL)!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjQryRegionFldsEN.PrjId 
 || null !== pobjQryRegionFldsEN.PrjId && pobjQryRegionFldsEN.PrjId.toString()  ===  ""
 || null !== pobjQryRegionFldsEN.PrjId && pobjQryRegionFldsEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[查询区域字段|工程ID]不能为空(NULL)!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjQryRegionFldsEN.UpdUser 
 || null !== pobjQryRegionFldsEN.UpdUser && pobjQryRegionFldsEN.UpdUser.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[查询区域字段|修改者]不能为空(NULL)!(clsQryRegionFldsBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjQryRegionFldsEN.LabelCaption && GetStrLen(pobjQryRegionFldsEN.LabelCaption) > 50)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|标签标题(LabelCaption)]的长度不能超过50!值:$(pobjQryRegionFldsEN.LabelCaption)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.CtlTypeId && GetStrLen(pobjQryRegionFldsEN.CtlTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|控件类型号(CtlTypeId)]的长度不能超过2!值:$(pobjQryRegionFldsEN.CtlTypeId)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_TabId && GetStrLen(pobjQryRegionFldsEN.DS_TabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|数据源表ID(DS_TabId)]的长度不能超过8!值:$(pobjQryRegionFldsEN.DS_TabId)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.QueryOptionId && GetStrLen(pobjQryRegionFldsEN.QueryOptionId) > 2)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|查询方式Id(QueryOptionId)]的长度不能超过2!值:$(pobjQryRegionFldsEN.QueryOptionId)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DDLItemsOptionId && GetStrLen(pobjQryRegionFldsEN.DDLItemsOptionId) > 2)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|下拉框列表选项ID(DDLItemsOptionId)]的长度不能超过2!值:$(pobjQryRegionFldsEN.DDLItemsOptionId)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_SQLStr && GetStrLen(pobjQryRegionFldsEN.DS_SQLStr) > 200)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|数据源SQL串(DS_SQLStr)]的长度不能超过200!值:$(pobjQryRegionFldsEN.DS_SQLStr)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_DataTextFieldId && GetStrLen(pobjQryRegionFldsEN.DS_DataTextFieldId) > 8)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|数据源文本字段Id(DS_DataTextFieldId)]的长度不能超过8!值:$(pobjQryRegionFldsEN.DS_DataTextFieldId)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_DataValueFieldId && GetStrLen(pobjQryRegionFldsEN.DS_DataValueFieldId) > 8)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|数据源值字段Id(DS_DataValueFieldId)]的长度不能超过8!值:$(pobjQryRegionFldsEN.DS_DataValueFieldId)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.ItemsString && GetStrLen(pobjQryRegionFldsEN.ItemsString) > 200)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|列表项串(ItemsString)]的长度不能超过200!值:$(pobjQryRegionFldsEN.ItemsString)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_CondStr && GetStrLen(pobjQryRegionFldsEN.DS_CondStr) > 50)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|数据源条件串(DS_CondStr)]的长度不能超过50!值:$(pobjQryRegionFldsEN.DS_CondStr)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.PrjId && GetStrLen(pobjQryRegionFldsEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|工程ID(PrjId)]的长度不能超过4!值:$(pobjQryRegionFldsEN.PrjId)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.UpdUser && GetStrLen(pobjQryRegionFldsEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|修改者(UpdUser)]的长度不能超过20!值:$(pobjQryRegionFldsEN.UpdUser)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.UpdDate && GetStrLen(pobjQryRegionFldsEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjQryRegionFldsEN.UpdDate)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.Memo && GetStrLen(pobjQryRegionFldsEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|说明(Memo)]的长度不能超过1000!值:$(pobjQryRegionFldsEN.Memo)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynchToServerDate && GetStrLen(pobjQryRegionFldsEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjQryRegionFldsEN.SynchToServerDate)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynchToServerUser && GetStrLen(pobjQryRegionFldsEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjQryRegionFldsEN.SynchToServerUser)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynchToClientDate && GetStrLen(pobjQryRegionFldsEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjQryRegionFldsEN.SynchToClientDate)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynchToClientUser && GetStrLen(pobjQryRegionFldsEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjQryRegionFldsEN.SynchToClientUser)(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynSource && GetStrLen(pobjQryRegionFldsEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000155)字段[查询区域字段(QryRegionFlds)|同步来源(SynSource)]的长度不能超过50!值:$(pobjQryRegionFldsEN.SynSource)(clsQryRegionFldsBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjQryRegionFldsEN.mId && undefined !== pobjQryRegionFldsEN.mId && tzDataType.isNumber(pobjQryRegionFldsEN.mId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|mId(mId)]的值:[$(pobjQryRegionFldsEN.mId)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.RegionId && undefined !== pobjQryRegionFldsEN.RegionId && tzDataType.isNumber(pobjQryRegionFldsEN.RegionId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|区域Id(RegionId)]的值:[$(pobjQryRegionFldsEN.RegionId)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.TabFldId && undefined !== pobjQryRegionFldsEN.TabFldId && tzDataType.isNumber(pobjQryRegionFldsEN.TabFldId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|表字段ID(TabFldId)]的值:[$(pobjQryRegionFldsEN.TabFldId)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.LabelCaption && undefined !== pobjQryRegionFldsEN.LabelCaption && tzDataType.isString(pobjQryRegionFldsEN.LabelCaption) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|标签标题(LabelCaption)]的值:[$(pobjQryRegionFldsEN.LabelCaption)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.CtlTypeId && undefined !== pobjQryRegionFldsEN.CtlTypeId && tzDataType.isString(pobjQryRegionFldsEN.CtlTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|控件类型号(CtlTypeId)]的值:[$(pobjQryRegionFldsEN.CtlTypeId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_TabId && undefined !== pobjQryRegionFldsEN.DS_TabId && tzDataType.isString(pobjQryRegionFldsEN.DS_TabId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|数据源表ID(DS_TabId)]的值:[$(pobjQryRegionFldsEN.DS_TabId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.QueryOptionId && undefined !== pobjQryRegionFldsEN.QueryOptionId && tzDataType.isString(pobjQryRegionFldsEN.QueryOptionId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|查询方式Id(QueryOptionId)]的值:[$(pobjQryRegionFldsEN.QueryOptionId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DDLItemsOptionId && undefined !== pobjQryRegionFldsEN.DDLItemsOptionId && tzDataType.isString(pobjQryRegionFldsEN.DDLItemsOptionId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|下拉框列表选项ID(DDLItemsOptionId)]的值:[$(pobjQryRegionFldsEN.DDLItemsOptionId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_SQLStr && undefined !== pobjQryRegionFldsEN.DS_SQLStr && tzDataType.isString(pobjQryRegionFldsEN.DS_SQLStr) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|数据源SQL串(DS_SQLStr)]的值:[$(pobjQryRegionFldsEN.DS_SQLStr)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_DataTextFieldId && undefined !== pobjQryRegionFldsEN.DS_DataTextFieldId && tzDataType.isString(pobjQryRegionFldsEN.DS_DataTextFieldId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|数据源文本字段Id(DS_DataTextFieldId)]的值:[$(pobjQryRegionFldsEN.DS_DataTextFieldId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_DataValueFieldId && undefined !== pobjQryRegionFldsEN.DS_DataValueFieldId && tzDataType.isString(pobjQryRegionFldsEN.DS_DataValueFieldId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|数据源值字段Id(DS_DataValueFieldId)]的值:[$(pobjQryRegionFldsEN.DS_DataValueFieldId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.ItemsString && undefined !== pobjQryRegionFldsEN.ItemsString && tzDataType.isString(pobjQryRegionFldsEN.ItemsString) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|列表项串(ItemsString)]的值:[$(pobjQryRegionFldsEN.ItemsString)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.DS_CondStr && undefined !== pobjQryRegionFldsEN.DS_CondStr && tzDataType.isString(pobjQryRegionFldsEN.DS_CondStr) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|数据源条件串(DS_CondStr)]的值:[$(pobjQryRegionFldsEN.DS_CondStr)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.ColSpan && undefined !== pobjQryRegionFldsEN.ColSpan && tzDataType.isNumber(pobjQryRegionFldsEN.ColSpan) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|跨列数(ColSpan)]的值:[$(pobjQryRegionFldsEN.ColSpan)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.Width && undefined !== pobjQryRegionFldsEN.Width && tzDataType.isNumber(pobjQryRegionFldsEN.Width) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|宽(Width)]的值:[$(pobjQryRegionFldsEN.Width)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SeqNum && undefined !== pobjQryRegionFldsEN.SeqNum && tzDataType.isNumber(pobjQryRegionFldsEN.SeqNum) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|字段序号(SeqNum)]的值:[$(pobjQryRegionFldsEN.SeqNum)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.InUse && undefined !== pobjQryRegionFldsEN.InUse && tzDataType.isBoolean(pobjQryRegionFldsEN.InUse) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|是否在用(InUse)]的值:[$(pobjQryRegionFldsEN.InUse)], 非法，应该为布尔型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.PrjId && undefined !== pobjQryRegionFldsEN.PrjId && tzDataType.isString(pobjQryRegionFldsEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|工程ID(PrjId)]的值:[$(pobjQryRegionFldsEN.PrjId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.UpdUser && undefined !== pobjQryRegionFldsEN.UpdUser && tzDataType.isString(pobjQryRegionFldsEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|修改者(UpdUser)]的值:[$(pobjQryRegionFldsEN.UpdUser)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.UpdDate && undefined !== pobjQryRegionFldsEN.UpdDate && tzDataType.isString(pobjQryRegionFldsEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|修改日期(UpdDate)]的值:[$(pobjQryRegionFldsEN.UpdDate)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.Memo && undefined !== pobjQryRegionFldsEN.Memo && tzDataType.isString(pobjQryRegionFldsEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|说明(Memo)]的值:[$(pobjQryRegionFldsEN.Memo)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.IsSynchToServer && undefined !== pobjQryRegionFldsEN.IsSynchToServer && tzDataType.isBoolean(pobjQryRegionFldsEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|是否同步到Server(IsSynchToServer)]的值:[$(pobjQryRegionFldsEN.IsSynchToServer)], 非法，应该为布尔型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynchToServerDate && undefined !== pobjQryRegionFldsEN.SynchToServerDate && tzDataType.isString(pobjQryRegionFldsEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|同步到Server日期(SynchToServerDate)]的值:[$(pobjQryRegionFldsEN.SynchToServerDate)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynchToServerUser && undefined !== pobjQryRegionFldsEN.SynchToServerUser && tzDataType.isString(pobjQryRegionFldsEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|同步到Server用户(SynchToServerUser)]的值:[$(pobjQryRegionFldsEN.SynchToServerUser)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.IsSynchToClient && undefined !== pobjQryRegionFldsEN.IsSynchToClient && tzDataType.isBoolean(pobjQryRegionFldsEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|是否同步到Client(IsSynchToClient)]的值:[$(pobjQryRegionFldsEN.IsSynchToClient)], 非法，应该为布尔型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynchToClientDate && undefined !== pobjQryRegionFldsEN.SynchToClientDate && tzDataType.isString(pobjQryRegionFldsEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjQryRegionFldsEN.SynchToClientDate)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynchToClientUser && undefined !== pobjQryRegionFldsEN.SynchToClientUser && tzDataType.isString(pobjQryRegionFldsEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjQryRegionFldsEN.SynchToClientUser)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjQryRegionFldsEN.SynSource && undefined !== pobjQryRegionFldsEN.SynSource && tzDataType.isString(pobjQryRegionFldsEN.SynSource) === false)
{
 throw new Error("(errid:Busi000156)字段[查询区域字段(QryRegionFlds)|同步来源(SynSource)]的值:[$(pobjQryRegionFldsEN.SynSource)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjQryRegionFldsEN.CtlTypeId != null && GetStrLen(pobjQryRegionFldsEN.CtlTypeId) !=  2)
{
 throw ("(errid:Busi000157)字段[查询区域字段|控件类型号]作为外键字段,长度应该为2!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (pobjQryRegionFldsEN.DDLItemsOptionId != null && GetStrLen(pobjQryRegionFldsEN.DDLItemsOptionId) !=  2)
{
 throw ("(errid:Busi000157)字段[查询区域字段|下拉框列表选项ID]作为外键字段,长度应该为2!(clsQryRegionFldsBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjQryRegionFldsEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsQryRegionFldsBL.prototype.CheckProperty4Update  = function(pobjQryRegionFldsEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjQryRegionFldsEN.LabelCaption && GetStrLen(pobjQryRegionFldsEN.LabelCaption) > 50)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|标签标题(LabelCaption)]的长度不能超过50!值:$(pobjQryRegionFldsEN.LabelCaption)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.CtlTypeId && GetStrLen(pobjQryRegionFldsEN.CtlTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|控件类型号(CtlTypeId)]的长度不能超过2!值:$(pobjQryRegionFldsEN.CtlTypeId)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_TabId && GetStrLen(pobjQryRegionFldsEN.DS_TabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|数据源表ID(DS_TabId)]的长度不能超过8!值:$(pobjQryRegionFldsEN.DS_TabId)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.QueryOptionId && GetStrLen(pobjQryRegionFldsEN.QueryOptionId) > 2)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|查询方式Id(QueryOptionId)]的长度不能超过2!值:$(pobjQryRegionFldsEN.QueryOptionId)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DDLItemsOptionId && GetStrLen(pobjQryRegionFldsEN.DDLItemsOptionId) > 2)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|下拉框列表选项ID(DDLItemsOptionId)]的长度不能超过2!值:$(pobjQryRegionFldsEN.DDLItemsOptionId)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_SQLStr && GetStrLen(pobjQryRegionFldsEN.DS_SQLStr) > 200)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|数据源SQL串(DS_SQLStr)]的长度不能超过200!值:$(pobjQryRegionFldsEN.DS_SQLStr)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_DataTextFieldId && GetStrLen(pobjQryRegionFldsEN.DS_DataTextFieldId) > 8)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|数据源文本字段Id(DS_DataTextFieldId)]的长度不能超过8!值:$(pobjQryRegionFldsEN.DS_DataTextFieldId)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_DataValueFieldId && GetStrLen(pobjQryRegionFldsEN.DS_DataValueFieldId) > 8)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|数据源值字段Id(DS_DataValueFieldId)]的长度不能超过8!值:$(pobjQryRegionFldsEN.DS_DataValueFieldId)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.ItemsString && GetStrLen(pobjQryRegionFldsEN.ItemsString) > 200)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|列表项串(ItemsString)]的长度不能超过200!值:$(pobjQryRegionFldsEN.ItemsString)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_CondStr && GetStrLen(pobjQryRegionFldsEN.DS_CondStr) > 50)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|数据源条件串(DS_CondStr)]的长度不能超过50!值:$(pobjQryRegionFldsEN.DS_CondStr)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.PrjId && GetStrLen(pobjQryRegionFldsEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|工程ID(PrjId)]的长度不能超过4!值:$(pobjQryRegionFldsEN.PrjId)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.UpdUser && GetStrLen(pobjQryRegionFldsEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|修改者(UpdUser)]的长度不能超过20!值:$(pobjQryRegionFldsEN.UpdUser)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.UpdDate && GetStrLen(pobjQryRegionFldsEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjQryRegionFldsEN.UpdDate)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.Memo && GetStrLen(pobjQryRegionFldsEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|说明(Memo)]的长度不能超过1000!值:$(pobjQryRegionFldsEN.Memo)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynchToServerDate && GetStrLen(pobjQryRegionFldsEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjQryRegionFldsEN.SynchToServerDate)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynchToServerUser && GetStrLen(pobjQryRegionFldsEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjQryRegionFldsEN.SynchToServerUser)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynchToClientDate && GetStrLen(pobjQryRegionFldsEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjQryRegionFldsEN.SynchToClientDate)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynchToClientUser && GetStrLen(pobjQryRegionFldsEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjQryRegionFldsEN.SynchToClientUser)(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynSource && GetStrLen(pobjQryRegionFldsEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000158)字段[查询区域字段(QryRegionFlds)|同步来源(SynSource)]的长度不能超过50!值:$(pobjQryRegionFldsEN.SynSource)(clsQryRegionFldsBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjQryRegionFldsEN.mId && undefined !== pobjQryRegionFldsEN.mId && tzDataType.isNumber(pobjQryRegionFldsEN.mId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|mId(mId)]的值:[$(pobjQryRegionFldsEN.mId)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.RegionId && undefined !== pobjQryRegionFldsEN.RegionId && tzDataType.isNumber(pobjQryRegionFldsEN.RegionId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|区域Id(RegionId)]的值:[$(pobjQryRegionFldsEN.RegionId)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.TabFldId && undefined !== pobjQryRegionFldsEN.TabFldId && tzDataType.isNumber(pobjQryRegionFldsEN.TabFldId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|表字段ID(TabFldId)]的值:[$(pobjQryRegionFldsEN.TabFldId)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.LabelCaption && undefined !== pobjQryRegionFldsEN.LabelCaption && tzDataType.isString(pobjQryRegionFldsEN.LabelCaption) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|标签标题(LabelCaption)]的值:[$(pobjQryRegionFldsEN.LabelCaption)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.CtlTypeId && undefined !== pobjQryRegionFldsEN.CtlTypeId && tzDataType.isString(pobjQryRegionFldsEN.CtlTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|控件类型号(CtlTypeId)]的值:[$(pobjQryRegionFldsEN.CtlTypeId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_TabId && undefined !== pobjQryRegionFldsEN.DS_TabId && tzDataType.isString(pobjQryRegionFldsEN.DS_TabId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|数据源表ID(DS_TabId)]的值:[$(pobjQryRegionFldsEN.DS_TabId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.QueryOptionId && undefined !== pobjQryRegionFldsEN.QueryOptionId && tzDataType.isString(pobjQryRegionFldsEN.QueryOptionId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|查询方式Id(QueryOptionId)]的值:[$(pobjQryRegionFldsEN.QueryOptionId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DDLItemsOptionId && undefined !== pobjQryRegionFldsEN.DDLItemsOptionId && tzDataType.isString(pobjQryRegionFldsEN.DDLItemsOptionId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|下拉框列表选项ID(DDLItemsOptionId)]的值:[$(pobjQryRegionFldsEN.DDLItemsOptionId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_SQLStr && undefined !== pobjQryRegionFldsEN.DS_SQLStr && tzDataType.isString(pobjQryRegionFldsEN.DS_SQLStr) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|数据源SQL串(DS_SQLStr)]的值:[$(pobjQryRegionFldsEN.DS_SQLStr)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_DataTextFieldId && undefined !== pobjQryRegionFldsEN.DS_DataTextFieldId && tzDataType.isString(pobjQryRegionFldsEN.DS_DataTextFieldId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|数据源文本字段Id(DS_DataTextFieldId)]的值:[$(pobjQryRegionFldsEN.DS_DataTextFieldId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_DataValueFieldId && undefined !== pobjQryRegionFldsEN.DS_DataValueFieldId && tzDataType.isString(pobjQryRegionFldsEN.DS_DataValueFieldId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|数据源值字段Id(DS_DataValueFieldId)]的值:[$(pobjQryRegionFldsEN.DS_DataValueFieldId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.ItemsString && undefined !== pobjQryRegionFldsEN.ItemsString && tzDataType.isString(pobjQryRegionFldsEN.ItemsString) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|列表项串(ItemsString)]的值:[$(pobjQryRegionFldsEN.ItemsString)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.DS_CondStr && undefined !== pobjQryRegionFldsEN.DS_CondStr && tzDataType.isString(pobjQryRegionFldsEN.DS_CondStr) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|数据源条件串(DS_CondStr)]的值:[$(pobjQryRegionFldsEN.DS_CondStr)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.ColSpan && undefined !== pobjQryRegionFldsEN.ColSpan && tzDataType.isNumber(pobjQryRegionFldsEN.ColSpan) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|跨列数(ColSpan)]的值:[$(pobjQryRegionFldsEN.ColSpan)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.Width && undefined !== pobjQryRegionFldsEN.Width && tzDataType.isNumber(pobjQryRegionFldsEN.Width) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|宽(Width)]的值:[$(pobjQryRegionFldsEN.Width)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SeqNum && undefined !== pobjQryRegionFldsEN.SeqNum && tzDataType.isNumber(pobjQryRegionFldsEN.SeqNum) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|字段序号(SeqNum)]的值:[$(pobjQryRegionFldsEN.SeqNum)], 非法，应该为数值型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.InUse && undefined !== pobjQryRegionFldsEN.InUse && tzDataType.isBoolean(pobjQryRegionFldsEN.InUse) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|是否在用(InUse)]的值:[$(pobjQryRegionFldsEN.InUse)], 非法，应该为布尔型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.PrjId && undefined !== pobjQryRegionFldsEN.PrjId && tzDataType.isString(pobjQryRegionFldsEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|工程ID(PrjId)]的值:[$(pobjQryRegionFldsEN.PrjId)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.UpdUser && undefined !== pobjQryRegionFldsEN.UpdUser && tzDataType.isString(pobjQryRegionFldsEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|修改者(UpdUser)]的值:[$(pobjQryRegionFldsEN.UpdUser)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.UpdDate && undefined !== pobjQryRegionFldsEN.UpdDate && tzDataType.isString(pobjQryRegionFldsEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|修改日期(UpdDate)]的值:[$(pobjQryRegionFldsEN.UpdDate)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.Memo && undefined !== pobjQryRegionFldsEN.Memo && tzDataType.isString(pobjQryRegionFldsEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|说明(Memo)]的值:[$(pobjQryRegionFldsEN.Memo)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.IsSynchToServer && undefined !== pobjQryRegionFldsEN.IsSynchToServer && tzDataType.isBoolean(pobjQryRegionFldsEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|是否同步到Server(IsSynchToServer)]的值:[$(pobjQryRegionFldsEN.IsSynchToServer)], 非法，应该为布尔型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynchToServerDate && undefined !== pobjQryRegionFldsEN.SynchToServerDate && tzDataType.isString(pobjQryRegionFldsEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|同步到Server日期(SynchToServerDate)]的值:[$(pobjQryRegionFldsEN.SynchToServerDate)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynchToServerUser && undefined !== pobjQryRegionFldsEN.SynchToServerUser && tzDataType.isString(pobjQryRegionFldsEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|同步到Server用户(SynchToServerUser)]的值:[$(pobjQryRegionFldsEN.SynchToServerUser)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.IsSynchToClient && undefined !== pobjQryRegionFldsEN.IsSynchToClient && tzDataType.isBoolean(pobjQryRegionFldsEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|是否同步到Client(IsSynchToClient)]的值:[$(pobjQryRegionFldsEN.IsSynchToClient)], 非法，应该为布尔型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynchToClientDate && undefined !== pobjQryRegionFldsEN.SynchToClientDate && tzDataType.isString(pobjQryRegionFldsEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjQryRegionFldsEN.SynchToClientDate)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynchToClientUser && undefined !== pobjQryRegionFldsEN.SynchToClientUser && tzDataType.isString(pobjQryRegionFldsEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjQryRegionFldsEN.SynchToClientUser)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjQryRegionFldsEN.SynSource && undefined !== pobjQryRegionFldsEN.SynSource && tzDataType.isString(pobjQryRegionFldsEN.SynSource) === false)
{
 throw new Error("(errid:Busi000159)字段[查询区域字段(QryRegionFlds)|同步来源(SynSource)]的值:[$(pobjQryRegionFldsEN.SynSource)], 非法，应该为字符型!(clsQryRegionFldsBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjQryRegionFldsEN.mId 
 || null !== pobjQryRegionFldsEN.mId && pobjQryRegionFldsEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Busi000160)字段[查询区域字段|mId]不能为空(NULL)!(clsQryRegionFldsBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjQryRegionFldsEN.CtlTypeId != null && GetStrLen(pobjQryRegionFldsEN.CtlTypeId) !=  2)
{
 throw ("(errid:Busi000161)字段[查询区域字段|控件类型号]作为外键字段,长度应该为2!(clsQryRegionFldsBL:CheckPropertyNew)");
}
if (pobjQryRegionFldsEN.DDLItemsOptionId != null && GetStrLen(pobjQryRegionFldsEN.DDLItemsOptionId) !=  2)
{
 throw ("(errid:Busi000161)字段[查询区域字段|下拉框列表选项ID]作为外键字段,长度应该为2!(clsQryRegionFldsBL:CheckPropertyNew)");
}

 pobjQryRegionFldsEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024935
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsQryRegionFldsBL.GetJSONStrByObj  = function(pobjQryRegionFldsEN)
{
pobjQryRegionFldsEN.sf_UpdFldSetStr = pobjQryRegionFldsEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjQryRegionFldsEN);
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
 /// 日期:20200501024935
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsQryRegionFldsBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrQryRegionFldsObjLst = new Array();
if (strJSON === "")
{
return arrQryRegionFldsObjLst;
}
try
{
arrQryRegionFldsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrQryRegionFldsObjLst;
}
return arrQryRegionFldsObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024935
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsQryRegionFldsBL.GetObjByJSONStr  = function(strJSON)
{
var pobjQryRegionFldsEN = new clsQryRegionFldsEN();
if (strJSON === "")
{
return pobjQryRegionFldsEN;
}
try
{
pobjQryRegionFldsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjQryRegionFldsEN;
}
return pobjQryRegionFldsEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objQryRegionFldsENS">源简化对象</param>
 /// <param name = "objQryRegionFldsENT">目标对象</param>
clsQryRegionFldsBL.CopyObjFromSimObj = function(objQryRegionFldsENS, objQryRegionFldsENT) 
{
objQryRegionFldsENT.mId = objQryRegionFldsENS.mId; //mId
objQryRegionFldsENT.RegionId = objQryRegionFldsENS.RegionId; //区域Id
objQryRegionFldsENT.TabFldId = objQryRegionFldsENS.TabFldId; //表字段ID
objQryRegionFldsENT.LabelCaption = objQryRegionFldsENS.LabelCaption; //标签标题
objQryRegionFldsENT.CtlTypeId = objQryRegionFldsENS.CtlTypeId; //控件类型号
objQryRegionFldsENT.DS_TabId = objQryRegionFldsENS.DS_TabId; //数据源表ID
objQryRegionFldsENT.QueryOptionId = objQryRegionFldsENS.QueryOptionId; //查询方式Id
objQryRegionFldsENT.DDLItemsOptionId = objQryRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objQryRegionFldsENT.DS_SQLStr = objQryRegionFldsENS.DS_SQLStr; //数据源SQL串
objQryRegionFldsENT.DS_DataTextFieldId = objQryRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objQryRegionFldsENT.DS_DataValueFieldId = objQryRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objQryRegionFldsENT.ItemsString = objQryRegionFldsENS.ItemsString; //列表项串
objQryRegionFldsENT.DS_CondStr = objQryRegionFldsENS.DS_CondStr; //数据源条件串
objQryRegionFldsENT.ColSpan = objQryRegionFldsENS.ColSpan; //跨列数
objQryRegionFldsENT.Width = objQryRegionFldsENS.Width; //宽
objQryRegionFldsENT.SeqNum = objQryRegionFldsENS.SeqNum; //字段序号
objQryRegionFldsENT.InUse = objQryRegionFldsENS.InUse; //是否在用
objQryRegionFldsENT.PrjId = objQryRegionFldsENS.PrjId; //工程ID
objQryRegionFldsENT.UpdUser = objQryRegionFldsENS.UpdUser; //修改者
objQryRegionFldsENT.UpdDate = objQryRegionFldsENS.UpdDate; //修改日期
objQryRegionFldsENT.Memo = objQryRegionFldsENS.Memo; //说明
objQryRegionFldsENT.IsSynchToServer = objQryRegionFldsENS.IsSynchToServer; //是否同步到Server
objQryRegionFldsENT.SynchToServerDate = objQryRegionFldsENS.SynchToServerDate; //同步到Server日期
objQryRegionFldsENT.SynchToServerUser = objQryRegionFldsENS.SynchToServerUser; //同步到Server用户
objQryRegionFldsENT.IsSynchToClient = objQryRegionFldsENS.IsSynchToClient; //是否同步到Client
objQryRegionFldsENT.SynchToClientDate = objQryRegionFldsENS.SynchToClientDate; //同步到Client库日期
objQryRegionFldsENT.SynchToClientUser = objQryRegionFldsENS.SynchToClientUser; //同步到Client库用户
objQryRegionFldsENT.SynSource = objQryRegionFldsENS.SynSource; //同步来源
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objQryRegionFldsENS">源对象</param>
 /// <param name = "objQryRegionFldsENT">目标对象</param>
clsQryRegionFldsBL.CopyObjTo = function(objQryRegionFldsENS , objQryRegionFldsENT ) 
{
objQryRegionFldsENT.mId = objQryRegionFldsENS.mId; //mId
objQryRegionFldsENT.RegionId = objQryRegionFldsENS.RegionId; //区域Id
objQryRegionFldsENT.TabFldId = objQryRegionFldsENS.TabFldId; //表字段ID
objQryRegionFldsENT.LabelCaption = objQryRegionFldsENS.LabelCaption; //标签标题
objQryRegionFldsENT.CtlTypeId = objQryRegionFldsENS.CtlTypeId; //控件类型号
objQryRegionFldsENT.DS_TabId = objQryRegionFldsENS.DS_TabId; //数据源表ID
objQryRegionFldsENT.QueryOptionId = objQryRegionFldsENS.QueryOptionId; //查询方式Id
objQryRegionFldsENT.DDLItemsOptionId = objQryRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objQryRegionFldsENT.DS_SQLStr = objQryRegionFldsENS.DS_SQLStr; //数据源SQL串
objQryRegionFldsENT.DS_DataTextFieldId = objQryRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objQryRegionFldsENT.DS_DataValueFieldId = objQryRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objQryRegionFldsENT.ItemsString = objQryRegionFldsENS.ItemsString; //列表项串
objQryRegionFldsENT.DS_CondStr = objQryRegionFldsENS.DS_CondStr; //数据源条件串
objQryRegionFldsENT.ColSpan = objQryRegionFldsENS.ColSpan; //跨列数
objQryRegionFldsENT.Width = objQryRegionFldsENS.Width; //宽
objQryRegionFldsENT.SeqNum = objQryRegionFldsENS.SeqNum; //字段序号
objQryRegionFldsENT.InUse = objQryRegionFldsENS.InUse; //是否在用
objQryRegionFldsENT.PrjId = objQryRegionFldsENS.PrjId; //工程ID
objQryRegionFldsENT.UpdUser = objQryRegionFldsENS.UpdUser; //修改者
objQryRegionFldsENT.UpdDate = objQryRegionFldsENS.UpdDate; //修改日期
objQryRegionFldsENT.Memo = objQryRegionFldsENS.Memo; //说明
objQryRegionFldsENT.IsSynchToServer = objQryRegionFldsENS.IsSynchToServer; //是否同步到Server
objQryRegionFldsENT.SynchToServerDate = objQryRegionFldsENS.SynchToServerDate; //同步到Server日期
objQryRegionFldsENT.SynchToServerUser = objQryRegionFldsENS.SynchToServerUser; //同步到Server用户
objQryRegionFldsENT.IsSynchToClient = objQryRegionFldsENS.IsSynchToClient; //是否同步到Client
objQryRegionFldsENT.SynchToClientDate = objQryRegionFldsENS.SynchToClientDate; //同步到Client库日期
objQryRegionFldsENT.SynchToClientUser = objQryRegionFldsENS.SynchToClientUser; //同步到Client库用户
objQryRegionFldsENT.SynSource = objQryRegionFldsENS.SynSource; //同步来源
objQryRegionFldsENT.sf_UpdFldSetStr = objQryRegionFldsENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objQryRegionFldsENS">源对象</param>
 /// <param name = "objQryRegionFldsENT">目标对象</param>
clsQryRegionFldsBL.CopyObjToSimObj = function(objQryRegionFldsENS , objQryRegionFldsENT ) 
{
objQryRegionFldsENT.mId = objQryRegionFldsENS.mId; //mId
objQryRegionFldsENT.RegionId = objQryRegionFldsENS.RegionId; //区域Id
objQryRegionFldsENT.TabFldId = objQryRegionFldsENS.TabFldId; //表字段ID
objQryRegionFldsENT.LabelCaption = objQryRegionFldsENS.LabelCaption; //标签标题
objQryRegionFldsENT.CtlTypeId = objQryRegionFldsENS.CtlTypeId; //控件类型号
objQryRegionFldsENT.DS_TabId = objQryRegionFldsENS.DS_TabId; //数据源表ID
objQryRegionFldsENT.QueryOptionId = objQryRegionFldsENS.QueryOptionId; //查询方式Id
objQryRegionFldsENT.DDLItemsOptionId = objQryRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objQryRegionFldsENT.DS_SQLStr = objQryRegionFldsENS.DS_SQLStr; //数据源SQL串
objQryRegionFldsENT.DS_DataTextFieldId = objQryRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objQryRegionFldsENT.DS_DataValueFieldId = objQryRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objQryRegionFldsENT.ItemsString = objQryRegionFldsENS.ItemsString; //列表项串
objQryRegionFldsENT.DS_CondStr = objQryRegionFldsENS.DS_CondStr; //数据源条件串
objQryRegionFldsENT.ColSpan = objQryRegionFldsENS.ColSpan; //跨列数
objQryRegionFldsENT.Width = objQryRegionFldsENS.Width; //宽
objQryRegionFldsENT.SeqNum = objQryRegionFldsENS.SeqNum; //字段序号
objQryRegionFldsENT.InUse = objQryRegionFldsENS.InUse; //是否在用
objQryRegionFldsENT.PrjId = objQryRegionFldsENS.PrjId; //工程ID
objQryRegionFldsENT.UpdUser = objQryRegionFldsENS.UpdUser; //修改者
objQryRegionFldsENT.UpdDate = objQryRegionFldsENS.UpdDate; //修改日期
objQryRegionFldsENT.Memo = objQryRegionFldsENS.Memo; //说明
objQryRegionFldsENT.IsSynchToServer = objQryRegionFldsENS.IsSynchToServer; //是否同步到Server
objQryRegionFldsENT.SynchToServerDate = objQryRegionFldsENS.SynchToServerDate; //同步到Server日期
objQryRegionFldsENT.SynchToServerUser = objQryRegionFldsENS.SynchToServerUser; //同步到Server用户
objQryRegionFldsENT.IsSynchToClient = objQryRegionFldsENS.IsSynchToClient; //是否同步到Client
objQryRegionFldsENT.SynchToClientDate = objQryRegionFldsENS.SynchToClientDate; //同步到Client库日期
objQryRegionFldsENT.SynchToClientUser = objQryRegionFldsENS.SynchToClientUser; //同步到Client库用户
objQryRegionFldsENT.SynSource = objQryRegionFldsENS.SynSource; //同步来源
objQryRegionFldsENT.sf_UpdFldSetStr = objQryRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objQryRegionFldsENT.sf_FldComparisonOp = objQryRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objQryRegionFldsENS">源简化对象</param>
 /// <param name = "objQryRegionFldsENT">目标对象</param>
clsQryRegionFldsBL.CopyObjFromSimObj4Upd = function(objQryRegionFldsENS, objQryRegionFldsENT )
 {
   var strsf_UpdFldSetStr = objQryRegionFldsENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_mId)  >= 0)
{
objQryRegionFldsENT.mId = objQryRegionFldsENS.mId; //mId
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_RegionId)  >= 0)
{
objQryRegionFldsENT.RegionId = objQryRegionFldsENS.RegionId; //区域Id
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_TabFldId)  >= 0)
{
objQryRegionFldsENT.TabFldId = objQryRegionFldsENS.TabFldId; //表字段ID
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_LabelCaption)  >= 0)
{
objQryRegionFldsENT.LabelCaption = objQryRegionFldsENS.LabelCaption; //标签标题
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_CtlTypeId)  >= 0)
{
objQryRegionFldsENT.CtlTypeId = objQryRegionFldsENS.CtlTypeId; //控件类型号
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_DS_TabId)  >= 0)
{
objQryRegionFldsENT.DS_TabId = objQryRegionFldsENS.DS_TabId; //数据源表ID
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_QueryOptionId)  >= 0)
{
objQryRegionFldsENT.QueryOptionId = objQryRegionFldsENS.QueryOptionId; //查询方式Id
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_DDLItemsOptionId)  >= 0)
{
objQryRegionFldsENT.DDLItemsOptionId = objQryRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_DS_SQLStr)  >= 0)
{
objQryRegionFldsENT.DS_SQLStr = objQryRegionFldsENS.DS_SQLStr; //数据源SQL串
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_DS_DataTextFieldId)  >= 0)
{
objQryRegionFldsENT.DS_DataTextFieldId = objQryRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_DS_DataValueFieldId)  >= 0)
{
objQryRegionFldsENT.DS_DataValueFieldId = objQryRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_ItemsString)  >= 0)
{
objQryRegionFldsENT.ItemsString = objQryRegionFldsENS.ItemsString; //列表项串
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_DS_CondStr)  >= 0)
{
objQryRegionFldsENT.DS_CondStr = objQryRegionFldsENS.DS_CondStr; //数据源条件串
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_ColSpan)  >= 0)
{
objQryRegionFldsENT.ColSpan = objQryRegionFldsENS.ColSpan; //跨列数
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_Width)  >= 0)
{
objQryRegionFldsENT.Width = objQryRegionFldsENS.Width; //宽
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_SeqNum)  >= 0)
{
objQryRegionFldsENT.SeqNum = objQryRegionFldsENS.SeqNum; //字段序号
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_InUse)  >= 0)
{
objQryRegionFldsENT.InUse = objQryRegionFldsENS.InUse; //是否在用
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_PrjId)  >= 0)
{
objQryRegionFldsENT.PrjId = objQryRegionFldsENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_UpdUser)  >= 0)
{
objQryRegionFldsENT.UpdUser = objQryRegionFldsENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_UpdDate)  >= 0)
{
objQryRegionFldsENT.UpdDate = objQryRegionFldsENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_Memo)  >= 0)
{
objQryRegionFldsENT.Memo = objQryRegionFldsENS.Memo; //说明
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_IsSynchToServer)  >= 0)
{
objQryRegionFldsENT.IsSynchToServer = objQryRegionFldsENS.IsSynchToServer; //是否同步到Server
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_SynchToServerDate)  >= 0)
{
objQryRegionFldsENT.SynchToServerDate = objQryRegionFldsENS.SynchToServerDate; //同步到Server日期
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_SynchToServerUser)  >= 0)
{
objQryRegionFldsENT.SynchToServerUser = objQryRegionFldsENS.SynchToServerUser; //同步到Server用户
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_IsSynchToClient)  >= 0)
{
objQryRegionFldsENT.IsSynchToClient = objQryRegionFldsENS.IsSynchToClient; //是否同步到Client
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_SynchToClientDate)  >= 0)
{
objQryRegionFldsENT.SynchToClientDate = objQryRegionFldsENS.SynchToClientDate; //同步到Client库日期
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_SynchToClientUser)  >= 0)
{
objQryRegionFldsENT.SynchToClientUser = objQryRegionFldsENS.SynchToClientUser; //同步到Client库用户
}
if (sstrFldSet.indexOf(clsQryRegionFldsEN.con_SynSource)  >= 0)
{
objQryRegionFldsENT.SynSource = objQryRegionFldsENS.SynSource; //同步来源
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objQryRegionFldsENS">源对象</param>
 /// <param name = "objQryRegionFldsENT">目标对象</param>
clsQryRegionFldsBL.GetSimObjFromObj = function(objQryRegionFldsENS)
{
var objQryRegionFldsENT = new clsQryRegionFldsEN_Sim_js_1.clsQryRegionFldsEN_Sim();
objQryRegionFldsENT.mId = objQryRegionFldsENS.mId; //mId
objQryRegionFldsENT.RegionId = objQryRegionFldsENS.RegionId; //区域Id
objQryRegionFldsENT.TabFldId = objQryRegionFldsENS.TabFldId; //表字段ID
objQryRegionFldsENT.LabelCaption = objQryRegionFldsENS.LabelCaption; //标签标题
objQryRegionFldsENT.CtlTypeId = objQryRegionFldsENS.CtlTypeId; //控件类型号
objQryRegionFldsENT.DS_TabId = objQryRegionFldsENS.DS_TabId; //数据源表ID
objQryRegionFldsENT.QueryOptionId = objQryRegionFldsENS.QueryOptionId; //查询方式Id
objQryRegionFldsENT.DDLItemsOptionId = objQryRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objQryRegionFldsENT.DS_SQLStr = objQryRegionFldsENS.DS_SQLStr; //数据源SQL串
objQryRegionFldsENT.DS_DataTextFieldId = objQryRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objQryRegionFldsENT.DS_DataValueFieldId = objQryRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objQryRegionFldsENT.ItemsString = objQryRegionFldsENS.ItemsString; //列表项串
objQryRegionFldsENT.DS_CondStr = objQryRegionFldsENS.DS_CondStr; //数据源条件串
objQryRegionFldsENT.ColSpan = objQryRegionFldsENS.ColSpan; //跨列数
objQryRegionFldsENT.Width = objQryRegionFldsENS.Width; //宽
objQryRegionFldsENT.SeqNum = objQryRegionFldsENS.SeqNum; //字段序号
objQryRegionFldsENT.InUse = objQryRegionFldsENS.InUse; //是否在用
objQryRegionFldsENT.PrjId = objQryRegionFldsENS.PrjId; //工程ID
objQryRegionFldsENT.UpdUser = objQryRegionFldsENS.UpdUser; //修改者
objQryRegionFldsENT.UpdDate = objQryRegionFldsENS.UpdDate; //修改日期
objQryRegionFldsENT.Memo = objQryRegionFldsENS.Memo; //说明
objQryRegionFldsENT.IsSynchToServer = objQryRegionFldsENS.IsSynchToServer; //是否同步到Server
objQryRegionFldsENT.SynchToServerDate = objQryRegionFldsENS.SynchToServerDate; //同步到Server日期
objQryRegionFldsENT.SynchToServerUser = objQryRegionFldsENS.SynchToServerUser; //同步到Server用户
objQryRegionFldsENT.IsSynchToClient = objQryRegionFldsENS.IsSynchToClient; //是否同步到Client
objQryRegionFldsENT.SynchToClientDate = objQryRegionFldsENS.SynchToClientDate; //同步到Client库日期
objQryRegionFldsENT.SynchToClientUser = objQryRegionFldsENS.SynchToClientUser; //同步到Client库用户
objQryRegionFldsENT.SynSource = objQryRegionFldsENS.SynSource; //同步来源
objQryRegionFldsENT.sf_UpdFldSetStr = objQryRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objQryRegionFldsENT.sf_FldComparisonOp = objQryRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objQryRegionFldsENT;
}
return clsQryRegionFldsBL;
}());
exports.clsQryRegionFldsBL = clsQryRegionFldsBL;
});