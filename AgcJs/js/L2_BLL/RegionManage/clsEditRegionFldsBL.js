
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEditRegionFldsBL
 表名:EditRegionFlds(00050116)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:37
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
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsEditRegionFldsEN.js","../../L0_Entity/RegionManage/clsEditRegionFldsEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsEditRegionFldsEN_js_1 = require("../../L0_Entity/RegionManage/clsEditRegionFldsEN.js");
var clsEditRegionFldsEN_Sim_js_1 = require("../../L0_Entity/RegionManage/clsEditRegionFldsEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 编辑区域字段(EditRegionFlds)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsEditRegionFldsBL = /** @class */ (function () {
function clsEditRegionFldsBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrEditRegionFldsObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsEditRegionFldsBL.prototype.CheckPropertyNew = function(pobjEditRegionFldsEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjEditRegionFldsEN.RegionId 
 || null !== pobjEditRegionFldsEN.RegionId && pobjEditRegionFldsEN.RegionId.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[编辑区域字段|区域Id]不能为空(NULL)!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjEditRegionFldsEN.TabFldId 
 || null !== pobjEditRegionFldsEN.TabFldId && pobjEditRegionFldsEN.TabFldId.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[编辑区域字段|表字段ID]不能为空(NULL)!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjEditRegionFldsEN.CtlTypeId 
 || null !== pobjEditRegionFldsEN.CtlTypeId && pobjEditRegionFldsEN.CtlTypeId.toString()  ===  ""
 || null !== pobjEditRegionFldsEN.CtlTypeId && pobjEditRegionFldsEN.CtlTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[编辑区域字段|控件类型号]不能为空(NULL)!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjEditRegionFldsEN.DDLItemsOptionId 
 || null !== pobjEditRegionFldsEN.DDLItemsOptionId && pobjEditRegionFldsEN.DDLItemsOptionId.toString()  ===  ""
 || null !== pobjEditRegionFldsEN.DDLItemsOptionId && pobjEditRegionFldsEN.DDLItemsOptionId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[编辑区域字段|下拉框列表选项ID]不能为空(NULL)!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjEditRegionFldsEN.PrjId 
 || null !== pobjEditRegionFldsEN.PrjId && pobjEditRegionFldsEN.PrjId.toString()  ===  ""
 || null !== pobjEditRegionFldsEN.PrjId && pobjEditRegionFldsEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[编辑区域字段|工程ID]不能为空(NULL)!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjEditRegionFldsEN.UpdUser 
 || null !== pobjEditRegionFldsEN.UpdUser && pobjEditRegionFldsEN.UpdUser.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[编辑区域字段|修改者]不能为空(NULL)!(clsEditRegionFldsBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjEditRegionFldsEN.LabelCaption && GetStrLen(pobjEditRegionFldsEN.LabelCaption) > 50)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|标签标题(LabelCaption)]的长度不能超过50!值:$(pobjEditRegionFldsEN.LabelCaption)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.CtlTypeId && GetStrLen(pobjEditRegionFldsEN.CtlTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|控件类型号(CtlTypeId)]的长度不能超过2!值:$(pobjEditRegionFldsEN.CtlTypeId)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DDLItemsOptionId && GetStrLen(pobjEditRegionFldsEN.DDLItemsOptionId) > 2)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|下拉框列表选项ID(DDLItemsOptionId)]的长度不能超过2!值:$(pobjEditRegionFldsEN.DDLItemsOptionId)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_TabId && GetStrLen(pobjEditRegionFldsEN.DS_TabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|数据源表ID(DS_TabId)]的长度不能超过8!值:$(pobjEditRegionFldsEN.DS_TabId)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_DataValueFieldId && GetStrLen(pobjEditRegionFldsEN.DS_DataValueFieldId) > 8)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|数据源值字段Id(DS_DataValueFieldId)]的长度不能超过8!值:$(pobjEditRegionFldsEN.DS_DataValueFieldId)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_DataTextFieldId && GetStrLen(pobjEditRegionFldsEN.DS_DataTextFieldId) > 8)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|数据源文本字段Id(DS_DataTextFieldId)]的长度不能超过8!值:$(pobjEditRegionFldsEN.DS_DataTextFieldId)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_CondStr && GetStrLen(pobjEditRegionFldsEN.DS_CondStr) > 50)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|数据源条件串(DS_CondStr)]的长度不能超过50!值:$(pobjEditRegionFldsEN.DS_CondStr)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_SQLStr && GetStrLen(pobjEditRegionFldsEN.DS_SQLStr) > 200)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|数据源SQL串(DS_SQLStr)]的长度不能超过200!值:$(pobjEditRegionFldsEN.DS_SQLStr)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.ItemsString && GetStrLen(pobjEditRegionFldsEN.ItemsString) > 200)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|列表项串(ItemsString)]的长度不能超过200!值:$(pobjEditRegionFldsEN.ItemsString)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.INOUTTypeId && GetStrLen(pobjEditRegionFldsEN.INOUTTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|INOUT类型ID(INOUTTypeId)]的长度不能超过2!值:$(pobjEditRegionFldsEN.INOUTTypeId)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.PrjId && GetStrLen(pobjEditRegionFldsEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|工程ID(PrjId)]的长度不能超过4!值:$(pobjEditRegionFldsEN.PrjId)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.UpdUser && GetStrLen(pobjEditRegionFldsEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|修改者(UpdUser)]的长度不能超过20!值:$(pobjEditRegionFldsEN.UpdUser)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.UpdDate && GetStrLen(pobjEditRegionFldsEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjEditRegionFldsEN.UpdDate)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.Memo && GetStrLen(pobjEditRegionFldsEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|说明(Memo)]的长度不能超过1000!值:$(pobjEditRegionFldsEN.Memo)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynchToServerDate && GetStrLen(pobjEditRegionFldsEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjEditRegionFldsEN.SynchToServerDate)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynchToServerUser && GetStrLen(pobjEditRegionFldsEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjEditRegionFldsEN.SynchToServerUser)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynchToClientDate && GetStrLen(pobjEditRegionFldsEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjEditRegionFldsEN.SynchToClientDate)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynchToClientUser && GetStrLen(pobjEditRegionFldsEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjEditRegionFldsEN.SynchToClientUser)(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynSource && GetStrLen(pobjEditRegionFldsEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000155)字段[编辑区域字段(EditRegionFlds)|同步来源(SynSource)]的长度不能超过50!值:$(pobjEditRegionFldsEN.SynSource)(clsEditRegionFldsBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjEditRegionFldsEN.mId && undefined !== pobjEditRegionFldsEN.mId && tzDataType.isNumber(pobjEditRegionFldsEN.mId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|mId(mId)]的值:[$(pobjEditRegionFldsEN.mId)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.RegionId && undefined !== pobjEditRegionFldsEN.RegionId && tzDataType.isNumber(pobjEditRegionFldsEN.RegionId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|区域Id(RegionId)]的值:[$(pobjEditRegionFldsEN.RegionId)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.TabFldId && undefined !== pobjEditRegionFldsEN.TabFldId && tzDataType.isNumber(pobjEditRegionFldsEN.TabFldId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|表字段ID(TabFldId)]的值:[$(pobjEditRegionFldsEN.TabFldId)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.LabelCaption && undefined !== pobjEditRegionFldsEN.LabelCaption && tzDataType.isString(pobjEditRegionFldsEN.LabelCaption) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|标签标题(LabelCaption)]的值:[$(pobjEditRegionFldsEN.LabelCaption)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.CtlTypeId && undefined !== pobjEditRegionFldsEN.CtlTypeId && tzDataType.isString(pobjEditRegionFldsEN.CtlTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|控件类型号(CtlTypeId)]的值:[$(pobjEditRegionFldsEN.CtlTypeId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DDLItemsOptionId && undefined !== pobjEditRegionFldsEN.DDLItemsOptionId && tzDataType.isString(pobjEditRegionFldsEN.DDLItemsOptionId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|下拉框列表选项ID(DDLItemsOptionId)]的值:[$(pobjEditRegionFldsEN.DDLItemsOptionId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_TabId && undefined !== pobjEditRegionFldsEN.DS_TabId && tzDataType.isString(pobjEditRegionFldsEN.DS_TabId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|数据源表ID(DS_TabId)]的值:[$(pobjEditRegionFldsEN.DS_TabId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_DataValueFieldId && undefined !== pobjEditRegionFldsEN.DS_DataValueFieldId && tzDataType.isString(pobjEditRegionFldsEN.DS_DataValueFieldId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|数据源值字段Id(DS_DataValueFieldId)]的值:[$(pobjEditRegionFldsEN.DS_DataValueFieldId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_DataTextFieldId && undefined !== pobjEditRegionFldsEN.DS_DataTextFieldId && tzDataType.isString(pobjEditRegionFldsEN.DS_DataTextFieldId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|数据源文本字段Id(DS_DataTextFieldId)]的值:[$(pobjEditRegionFldsEN.DS_DataTextFieldId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_CondStr && undefined !== pobjEditRegionFldsEN.DS_CondStr && tzDataType.isString(pobjEditRegionFldsEN.DS_CondStr) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|数据源条件串(DS_CondStr)]的值:[$(pobjEditRegionFldsEN.DS_CondStr)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.DS_SQLStr && undefined !== pobjEditRegionFldsEN.DS_SQLStr && tzDataType.isString(pobjEditRegionFldsEN.DS_SQLStr) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|数据源SQL串(DS_SQLStr)]的值:[$(pobjEditRegionFldsEN.DS_SQLStr)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.ItemsString && undefined !== pobjEditRegionFldsEN.ItemsString && tzDataType.isString(pobjEditRegionFldsEN.ItemsString) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|列表项串(ItemsString)]的值:[$(pobjEditRegionFldsEN.ItemsString)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.ColSpan && undefined !== pobjEditRegionFldsEN.ColSpan && tzDataType.isNumber(pobjEditRegionFldsEN.ColSpan) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|跨列数(ColSpan)]的值:[$(pobjEditRegionFldsEN.ColSpan)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.ColIndex && undefined !== pobjEditRegionFldsEN.ColIndex && tzDataType.isNumber(pobjEditRegionFldsEN.ColIndex) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|列序号(ColIndex)]的值:[$(pobjEditRegionFldsEN.ColIndex)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.Width && undefined !== pobjEditRegionFldsEN.Width && tzDataType.isNumber(pobjEditRegionFldsEN.Width) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|宽(Width)]的值:[$(pobjEditRegionFldsEN.Width)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.IsMultiRow && undefined !== pobjEditRegionFldsEN.IsMultiRow && tzDataType.isBoolean(pobjEditRegionFldsEN.IsMultiRow) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|是否多行(IsMultiRow)]的值:[$(pobjEditRegionFldsEN.IsMultiRow)], 非法，应该为布尔型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SeqNum && undefined !== pobjEditRegionFldsEN.SeqNum && tzDataType.isNumber(pobjEditRegionFldsEN.SeqNum) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|字段序号(SeqNum)]的值:[$(pobjEditRegionFldsEN.SeqNum)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.INOUTTypeId && undefined !== pobjEditRegionFldsEN.INOUTTypeId && tzDataType.isString(pobjEditRegionFldsEN.INOUTTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|INOUT类型ID(INOUTTypeId)]的值:[$(pobjEditRegionFldsEN.INOUTTypeId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.InUse && undefined !== pobjEditRegionFldsEN.InUse && tzDataType.isBoolean(pobjEditRegionFldsEN.InUse) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|是否在用(InUse)]的值:[$(pobjEditRegionFldsEN.InUse)], 非法，应该为布尔型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.PrjId && undefined !== pobjEditRegionFldsEN.PrjId && tzDataType.isString(pobjEditRegionFldsEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|工程ID(PrjId)]的值:[$(pobjEditRegionFldsEN.PrjId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.UpdUser && undefined !== pobjEditRegionFldsEN.UpdUser && tzDataType.isString(pobjEditRegionFldsEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|修改者(UpdUser)]的值:[$(pobjEditRegionFldsEN.UpdUser)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.UpdDate && undefined !== pobjEditRegionFldsEN.UpdDate && tzDataType.isString(pobjEditRegionFldsEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|修改日期(UpdDate)]的值:[$(pobjEditRegionFldsEN.UpdDate)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.Memo && undefined !== pobjEditRegionFldsEN.Memo && tzDataType.isString(pobjEditRegionFldsEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|说明(Memo)]的值:[$(pobjEditRegionFldsEN.Memo)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.IsSynchToServer && undefined !== pobjEditRegionFldsEN.IsSynchToServer && tzDataType.isBoolean(pobjEditRegionFldsEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|是否同步到Server(IsSynchToServer)]的值:[$(pobjEditRegionFldsEN.IsSynchToServer)], 非法，应该为布尔型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynchToServerDate && undefined !== pobjEditRegionFldsEN.SynchToServerDate && tzDataType.isString(pobjEditRegionFldsEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|同步到Server日期(SynchToServerDate)]的值:[$(pobjEditRegionFldsEN.SynchToServerDate)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynchToServerUser && undefined !== pobjEditRegionFldsEN.SynchToServerUser && tzDataType.isString(pobjEditRegionFldsEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|同步到Server用户(SynchToServerUser)]的值:[$(pobjEditRegionFldsEN.SynchToServerUser)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.IsSynchToClient && undefined !== pobjEditRegionFldsEN.IsSynchToClient && tzDataType.isBoolean(pobjEditRegionFldsEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|是否同步到Client(IsSynchToClient)]的值:[$(pobjEditRegionFldsEN.IsSynchToClient)], 非法，应该为布尔型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynchToClientDate && undefined !== pobjEditRegionFldsEN.SynchToClientDate && tzDataType.isString(pobjEditRegionFldsEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjEditRegionFldsEN.SynchToClientDate)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynchToClientUser && undefined !== pobjEditRegionFldsEN.SynchToClientUser && tzDataType.isString(pobjEditRegionFldsEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjEditRegionFldsEN.SynchToClientUser)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjEditRegionFldsEN.SynSource && undefined !== pobjEditRegionFldsEN.SynSource && tzDataType.isString(pobjEditRegionFldsEN.SynSource) === false)
{
 throw new Error("(errid:Busi000156)字段[编辑区域字段(EditRegionFlds)|同步来源(SynSource)]的值:[$(pobjEditRegionFldsEN.SynSource)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjEditRegionFldsEN.CtlTypeId != null && GetStrLen(pobjEditRegionFldsEN.CtlTypeId) !=  2)
{
 throw ("(errid:Busi000157)字段[编辑区域字段|控件类型号]作为外键字段,长度应该为2!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (pobjEditRegionFldsEN.DDLItemsOptionId != null && GetStrLen(pobjEditRegionFldsEN.DDLItemsOptionId) !=  2)
{
 throw ("(errid:Busi000157)字段[编辑区域字段|下拉框列表选项ID]作为外键字段,长度应该为2!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (pobjEditRegionFldsEN.INOUTTypeId != null && GetStrLen(pobjEditRegionFldsEN.INOUTTypeId) !=  2)
{
 throw ("(errid:Busi000157)字段[编辑区域字段|INOUT类型ID]作为外键字段,长度应该为2!(clsEditRegionFldsBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjEditRegionFldsEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsEditRegionFldsBL.prototype.CheckProperty4Update  = function(pobjEditRegionFldsEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjEditRegionFldsEN.LabelCaption && GetStrLen(pobjEditRegionFldsEN.LabelCaption) > 50)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|标签标题(LabelCaption)]的长度不能超过50!值:$(pobjEditRegionFldsEN.LabelCaption)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.CtlTypeId && GetStrLen(pobjEditRegionFldsEN.CtlTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|控件类型号(CtlTypeId)]的长度不能超过2!值:$(pobjEditRegionFldsEN.CtlTypeId)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DDLItemsOptionId && GetStrLen(pobjEditRegionFldsEN.DDLItemsOptionId) > 2)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|下拉框列表选项ID(DDLItemsOptionId)]的长度不能超过2!值:$(pobjEditRegionFldsEN.DDLItemsOptionId)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_TabId && GetStrLen(pobjEditRegionFldsEN.DS_TabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|数据源表ID(DS_TabId)]的长度不能超过8!值:$(pobjEditRegionFldsEN.DS_TabId)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_DataValueFieldId && GetStrLen(pobjEditRegionFldsEN.DS_DataValueFieldId) > 8)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|数据源值字段Id(DS_DataValueFieldId)]的长度不能超过8!值:$(pobjEditRegionFldsEN.DS_DataValueFieldId)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_DataTextFieldId && GetStrLen(pobjEditRegionFldsEN.DS_DataTextFieldId) > 8)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|数据源文本字段Id(DS_DataTextFieldId)]的长度不能超过8!值:$(pobjEditRegionFldsEN.DS_DataTextFieldId)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_CondStr && GetStrLen(pobjEditRegionFldsEN.DS_CondStr) > 50)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|数据源条件串(DS_CondStr)]的长度不能超过50!值:$(pobjEditRegionFldsEN.DS_CondStr)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_SQLStr && GetStrLen(pobjEditRegionFldsEN.DS_SQLStr) > 200)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|数据源SQL串(DS_SQLStr)]的长度不能超过200!值:$(pobjEditRegionFldsEN.DS_SQLStr)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.ItemsString && GetStrLen(pobjEditRegionFldsEN.ItemsString) > 200)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|列表项串(ItemsString)]的长度不能超过200!值:$(pobjEditRegionFldsEN.ItemsString)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.INOUTTypeId && GetStrLen(pobjEditRegionFldsEN.INOUTTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|INOUT类型ID(INOUTTypeId)]的长度不能超过2!值:$(pobjEditRegionFldsEN.INOUTTypeId)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.PrjId && GetStrLen(pobjEditRegionFldsEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|工程ID(PrjId)]的长度不能超过4!值:$(pobjEditRegionFldsEN.PrjId)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.UpdUser && GetStrLen(pobjEditRegionFldsEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|修改者(UpdUser)]的长度不能超过20!值:$(pobjEditRegionFldsEN.UpdUser)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.UpdDate && GetStrLen(pobjEditRegionFldsEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjEditRegionFldsEN.UpdDate)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.Memo && GetStrLen(pobjEditRegionFldsEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|说明(Memo)]的长度不能超过1000!值:$(pobjEditRegionFldsEN.Memo)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynchToServerDate && GetStrLen(pobjEditRegionFldsEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjEditRegionFldsEN.SynchToServerDate)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynchToServerUser && GetStrLen(pobjEditRegionFldsEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjEditRegionFldsEN.SynchToServerUser)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynchToClientDate && GetStrLen(pobjEditRegionFldsEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjEditRegionFldsEN.SynchToClientDate)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynchToClientUser && GetStrLen(pobjEditRegionFldsEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjEditRegionFldsEN.SynchToClientUser)(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynSource && GetStrLen(pobjEditRegionFldsEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000158)字段[编辑区域字段(EditRegionFlds)|同步来源(SynSource)]的长度不能超过50!值:$(pobjEditRegionFldsEN.SynSource)(clsEditRegionFldsBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjEditRegionFldsEN.mId && undefined !== pobjEditRegionFldsEN.mId && tzDataType.isNumber(pobjEditRegionFldsEN.mId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|mId(mId)]的值:[$(pobjEditRegionFldsEN.mId)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.RegionId && undefined !== pobjEditRegionFldsEN.RegionId && tzDataType.isNumber(pobjEditRegionFldsEN.RegionId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|区域Id(RegionId)]的值:[$(pobjEditRegionFldsEN.RegionId)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.TabFldId && undefined !== pobjEditRegionFldsEN.TabFldId && tzDataType.isNumber(pobjEditRegionFldsEN.TabFldId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|表字段ID(TabFldId)]的值:[$(pobjEditRegionFldsEN.TabFldId)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.LabelCaption && undefined !== pobjEditRegionFldsEN.LabelCaption && tzDataType.isString(pobjEditRegionFldsEN.LabelCaption) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|标签标题(LabelCaption)]的值:[$(pobjEditRegionFldsEN.LabelCaption)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.CtlTypeId && undefined !== pobjEditRegionFldsEN.CtlTypeId && tzDataType.isString(pobjEditRegionFldsEN.CtlTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|控件类型号(CtlTypeId)]的值:[$(pobjEditRegionFldsEN.CtlTypeId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DDLItemsOptionId && undefined !== pobjEditRegionFldsEN.DDLItemsOptionId && tzDataType.isString(pobjEditRegionFldsEN.DDLItemsOptionId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|下拉框列表选项ID(DDLItemsOptionId)]的值:[$(pobjEditRegionFldsEN.DDLItemsOptionId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_TabId && undefined !== pobjEditRegionFldsEN.DS_TabId && tzDataType.isString(pobjEditRegionFldsEN.DS_TabId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|数据源表ID(DS_TabId)]的值:[$(pobjEditRegionFldsEN.DS_TabId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_DataValueFieldId && undefined !== pobjEditRegionFldsEN.DS_DataValueFieldId && tzDataType.isString(pobjEditRegionFldsEN.DS_DataValueFieldId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|数据源值字段Id(DS_DataValueFieldId)]的值:[$(pobjEditRegionFldsEN.DS_DataValueFieldId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_DataTextFieldId && undefined !== pobjEditRegionFldsEN.DS_DataTextFieldId && tzDataType.isString(pobjEditRegionFldsEN.DS_DataTextFieldId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|数据源文本字段Id(DS_DataTextFieldId)]的值:[$(pobjEditRegionFldsEN.DS_DataTextFieldId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_CondStr && undefined !== pobjEditRegionFldsEN.DS_CondStr && tzDataType.isString(pobjEditRegionFldsEN.DS_CondStr) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|数据源条件串(DS_CondStr)]的值:[$(pobjEditRegionFldsEN.DS_CondStr)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.DS_SQLStr && undefined !== pobjEditRegionFldsEN.DS_SQLStr && tzDataType.isString(pobjEditRegionFldsEN.DS_SQLStr) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|数据源SQL串(DS_SQLStr)]的值:[$(pobjEditRegionFldsEN.DS_SQLStr)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.ItemsString && undefined !== pobjEditRegionFldsEN.ItemsString && tzDataType.isString(pobjEditRegionFldsEN.ItemsString) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|列表项串(ItemsString)]的值:[$(pobjEditRegionFldsEN.ItemsString)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.ColSpan && undefined !== pobjEditRegionFldsEN.ColSpan && tzDataType.isNumber(pobjEditRegionFldsEN.ColSpan) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|跨列数(ColSpan)]的值:[$(pobjEditRegionFldsEN.ColSpan)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.ColIndex && undefined !== pobjEditRegionFldsEN.ColIndex && tzDataType.isNumber(pobjEditRegionFldsEN.ColIndex) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|列序号(ColIndex)]的值:[$(pobjEditRegionFldsEN.ColIndex)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.Width && undefined !== pobjEditRegionFldsEN.Width && tzDataType.isNumber(pobjEditRegionFldsEN.Width) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|宽(Width)]的值:[$(pobjEditRegionFldsEN.Width)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.IsMultiRow && undefined !== pobjEditRegionFldsEN.IsMultiRow && tzDataType.isBoolean(pobjEditRegionFldsEN.IsMultiRow) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|是否多行(IsMultiRow)]的值:[$(pobjEditRegionFldsEN.IsMultiRow)], 非法，应该为布尔型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SeqNum && undefined !== pobjEditRegionFldsEN.SeqNum && tzDataType.isNumber(pobjEditRegionFldsEN.SeqNum) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|字段序号(SeqNum)]的值:[$(pobjEditRegionFldsEN.SeqNum)], 非法，应该为数值型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.INOUTTypeId && undefined !== pobjEditRegionFldsEN.INOUTTypeId && tzDataType.isString(pobjEditRegionFldsEN.INOUTTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|INOUT类型ID(INOUTTypeId)]的值:[$(pobjEditRegionFldsEN.INOUTTypeId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.InUse && undefined !== pobjEditRegionFldsEN.InUse && tzDataType.isBoolean(pobjEditRegionFldsEN.InUse) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|是否在用(InUse)]的值:[$(pobjEditRegionFldsEN.InUse)], 非法，应该为布尔型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.PrjId && undefined !== pobjEditRegionFldsEN.PrjId && tzDataType.isString(pobjEditRegionFldsEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|工程ID(PrjId)]的值:[$(pobjEditRegionFldsEN.PrjId)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.UpdUser && undefined !== pobjEditRegionFldsEN.UpdUser && tzDataType.isString(pobjEditRegionFldsEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|修改者(UpdUser)]的值:[$(pobjEditRegionFldsEN.UpdUser)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.UpdDate && undefined !== pobjEditRegionFldsEN.UpdDate && tzDataType.isString(pobjEditRegionFldsEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|修改日期(UpdDate)]的值:[$(pobjEditRegionFldsEN.UpdDate)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.Memo && undefined !== pobjEditRegionFldsEN.Memo && tzDataType.isString(pobjEditRegionFldsEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|说明(Memo)]的值:[$(pobjEditRegionFldsEN.Memo)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.IsSynchToServer && undefined !== pobjEditRegionFldsEN.IsSynchToServer && tzDataType.isBoolean(pobjEditRegionFldsEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|是否同步到Server(IsSynchToServer)]的值:[$(pobjEditRegionFldsEN.IsSynchToServer)], 非法，应该为布尔型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynchToServerDate && undefined !== pobjEditRegionFldsEN.SynchToServerDate && tzDataType.isString(pobjEditRegionFldsEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|同步到Server日期(SynchToServerDate)]的值:[$(pobjEditRegionFldsEN.SynchToServerDate)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynchToServerUser && undefined !== pobjEditRegionFldsEN.SynchToServerUser && tzDataType.isString(pobjEditRegionFldsEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|同步到Server用户(SynchToServerUser)]的值:[$(pobjEditRegionFldsEN.SynchToServerUser)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.IsSynchToClient && undefined !== pobjEditRegionFldsEN.IsSynchToClient && tzDataType.isBoolean(pobjEditRegionFldsEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|是否同步到Client(IsSynchToClient)]的值:[$(pobjEditRegionFldsEN.IsSynchToClient)], 非法，应该为布尔型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynchToClientDate && undefined !== pobjEditRegionFldsEN.SynchToClientDate && tzDataType.isString(pobjEditRegionFldsEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjEditRegionFldsEN.SynchToClientDate)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynchToClientUser && undefined !== pobjEditRegionFldsEN.SynchToClientUser && tzDataType.isString(pobjEditRegionFldsEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjEditRegionFldsEN.SynchToClientUser)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjEditRegionFldsEN.SynSource && undefined !== pobjEditRegionFldsEN.SynSource && tzDataType.isString(pobjEditRegionFldsEN.SynSource) === false)
{
 throw new Error("(errid:Busi000159)字段[编辑区域字段(EditRegionFlds)|同步来源(SynSource)]的值:[$(pobjEditRegionFldsEN.SynSource)], 非法，应该为字符型!(clsEditRegionFldsBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjEditRegionFldsEN.mId 
 || null !== pobjEditRegionFldsEN.mId && pobjEditRegionFldsEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Busi000160)字段[编辑区域字段|mId]不能为空(NULL)!(clsEditRegionFldsBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjEditRegionFldsEN.CtlTypeId != null && GetStrLen(pobjEditRegionFldsEN.CtlTypeId) !=  2)
{
 throw ("(errid:Busi000161)字段[编辑区域字段|控件类型号]作为外键字段,长度应该为2!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (pobjEditRegionFldsEN.DDLItemsOptionId != null && GetStrLen(pobjEditRegionFldsEN.DDLItemsOptionId) !=  2)
{
 throw ("(errid:Busi000161)字段[编辑区域字段|下拉框列表选项ID]作为外键字段,长度应该为2!(clsEditRegionFldsBL:CheckPropertyNew)");
}
if (pobjEditRegionFldsEN.INOUTTypeId != null && GetStrLen(pobjEditRegionFldsEN.INOUTTypeId) !=  2)
{
 throw ("(errid:Busi000161)字段[编辑区域字段|INOUT类型ID]作为外键字段,长度应该为2!(clsEditRegionFldsBL:CheckPropertyNew)");
}

 pobjEditRegionFldsEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024937
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsEditRegionFldsBL.GetJSONStrByObj  = function(pobjEditRegionFldsEN)
{
pobjEditRegionFldsEN.sf_UpdFldSetStr = pobjEditRegionFldsEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjEditRegionFldsEN);
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
 /// 日期:20200501024937
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsEditRegionFldsBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrEditRegionFldsObjLst = new Array();
if (strJSON === "")
{
return arrEditRegionFldsObjLst;
}
try
{
arrEditRegionFldsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrEditRegionFldsObjLst;
}
return arrEditRegionFldsObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024937
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsEditRegionFldsBL.GetObjByJSONStr  = function(strJSON)
{
var pobjEditRegionFldsEN = new clsEditRegionFldsEN();
if (strJSON === "")
{
return pobjEditRegionFldsEN;
}
try
{
pobjEditRegionFldsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjEditRegionFldsEN;
}
return pobjEditRegionFldsEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objEditRegionFldsENS">源简化对象</param>
 /// <param name = "objEditRegionFldsENT">目标对象</param>
clsEditRegionFldsBL.CopyObjFromSimObj = function(objEditRegionFldsENS, objEditRegionFldsENT) 
{
objEditRegionFldsENT.mId = objEditRegionFldsENS.mId; //mId
objEditRegionFldsENT.RegionId = objEditRegionFldsENS.RegionId; //区域Id
objEditRegionFldsENT.TabFldId = objEditRegionFldsENS.TabFldId; //表字段ID
objEditRegionFldsENT.LabelCaption = objEditRegionFldsENS.LabelCaption; //标签标题
objEditRegionFldsENT.CtlTypeId = objEditRegionFldsENS.CtlTypeId; //控件类型号
objEditRegionFldsENT.DDLItemsOptionId = objEditRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objEditRegionFldsENT.DS_TabId = objEditRegionFldsENS.DS_TabId; //数据源表ID
objEditRegionFldsENT.DS_DataValueFieldId = objEditRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objEditRegionFldsENT.DS_DataTextFieldId = objEditRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objEditRegionFldsENT.DS_CondStr = objEditRegionFldsENS.DS_CondStr; //数据源条件串
objEditRegionFldsENT.DS_SQLStr = objEditRegionFldsENS.DS_SQLStr; //数据源SQL串
objEditRegionFldsENT.ItemsString = objEditRegionFldsENS.ItemsString; //列表项串
objEditRegionFldsENT.ColSpan = objEditRegionFldsENS.ColSpan; //跨列数
objEditRegionFldsENT.ColIndex = objEditRegionFldsENS.ColIndex; //列序号
objEditRegionFldsENT.Width = objEditRegionFldsENS.Width; //宽
objEditRegionFldsENT.IsMultiRow = objEditRegionFldsENS.IsMultiRow; //是否多行
objEditRegionFldsENT.SeqNum = objEditRegionFldsENS.SeqNum; //字段序号
objEditRegionFldsENT.INOUTTypeId = objEditRegionFldsENS.INOUTTypeId; //INOUT类型ID
objEditRegionFldsENT.InUse = objEditRegionFldsENS.InUse; //是否在用
objEditRegionFldsENT.PrjId = objEditRegionFldsENS.PrjId; //工程ID
objEditRegionFldsENT.UpdUser = objEditRegionFldsENS.UpdUser; //修改者
objEditRegionFldsENT.UpdDate = objEditRegionFldsENS.UpdDate; //修改日期
objEditRegionFldsENT.Memo = objEditRegionFldsENS.Memo; //说明
objEditRegionFldsENT.IsSynchToServer = objEditRegionFldsENS.IsSynchToServer; //是否同步到Server
objEditRegionFldsENT.SynchToServerDate = objEditRegionFldsENS.SynchToServerDate; //同步到Server日期
objEditRegionFldsENT.SynchToServerUser = objEditRegionFldsENS.SynchToServerUser; //同步到Server用户
objEditRegionFldsENT.IsSynchToClient = objEditRegionFldsENS.IsSynchToClient; //是否同步到Client
objEditRegionFldsENT.SynchToClientDate = objEditRegionFldsENS.SynchToClientDate; //同步到Client库日期
objEditRegionFldsENT.SynchToClientUser = objEditRegionFldsENS.SynchToClientUser; //同步到Client库用户
objEditRegionFldsENT.SynSource = objEditRegionFldsENS.SynSource; //同步来源
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objEditRegionFldsENS">源对象</param>
 /// <param name = "objEditRegionFldsENT">目标对象</param>
clsEditRegionFldsBL.CopyObjTo = function(objEditRegionFldsENS , objEditRegionFldsENT ) 
{
objEditRegionFldsENT.mId = objEditRegionFldsENS.mId; //mId
objEditRegionFldsENT.RegionId = objEditRegionFldsENS.RegionId; //区域Id
objEditRegionFldsENT.TabFldId = objEditRegionFldsENS.TabFldId; //表字段ID
objEditRegionFldsENT.LabelCaption = objEditRegionFldsENS.LabelCaption; //标签标题
objEditRegionFldsENT.CtlTypeId = objEditRegionFldsENS.CtlTypeId; //控件类型号
objEditRegionFldsENT.DDLItemsOptionId = objEditRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objEditRegionFldsENT.DS_TabId = objEditRegionFldsENS.DS_TabId; //数据源表ID
objEditRegionFldsENT.DS_DataValueFieldId = objEditRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objEditRegionFldsENT.DS_DataTextFieldId = objEditRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objEditRegionFldsENT.DS_CondStr = objEditRegionFldsENS.DS_CondStr; //数据源条件串
objEditRegionFldsENT.DS_SQLStr = objEditRegionFldsENS.DS_SQLStr; //数据源SQL串
objEditRegionFldsENT.ItemsString = objEditRegionFldsENS.ItemsString; //列表项串
objEditRegionFldsENT.ColSpan = objEditRegionFldsENS.ColSpan; //跨列数
objEditRegionFldsENT.ColIndex = objEditRegionFldsENS.ColIndex; //列序号
objEditRegionFldsENT.Width = objEditRegionFldsENS.Width; //宽
objEditRegionFldsENT.IsMultiRow = objEditRegionFldsENS.IsMultiRow; //是否多行
objEditRegionFldsENT.SeqNum = objEditRegionFldsENS.SeqNum; //字段序号
objEditRegionFldsENT.INOUTTypeId = objEditRegionFldsENS.INOUTTypeId; //INOUT类型ID
objEditRegionFldsENT.InUse = objEditRegionFldsENS.InUse; //是否在用
objEditRegionFldsENT.PrjId = objEditRegionFldsENS.PrjId; //工程ID
objEditRegionFldsENT.UpdUser = objEditRegionFldsENS.UpdUser; //修改者
objEditRegionFldsENT.UpdDate = objEditRegionFldsENS.UpdDate; //修改日期
objEditRegionFldsENT.Memo = objEditRegionFldsENS.Memo; //说明
objEditRegionFldsENT.IsSynchToServer = objEditRegionFldsENS.IsSynchToServer; //是否同步到Server
objEditRegionFldsENT.SynchToServerDate = objEditRegionFldsENS.SynchToServerDate; //同步到Server日期
objEditRegionFldsENT.SynchToServerUser = objEditRegionFldsENS.SynchToServerUser; //同步到Server用户
objEditRegionFldsENT.IsSynchToClient = objEditRegionFldsENS.IsSynchToClient; //是否同步到Client
objEditRegionFldsENT.SynchToClientDate = objEditRegionFldsENS.SynchToClientDate; //同步到Client库日期
objEditRegionFldsENT.SynchToClientUser = objEditRegionFldsENS.SynchToClientUser; //同步到Client库用户
objEditRegionFldsENT.SynSource = objEditRegionFldsENS.SynSource; //同步来源
objEditRegionFldsENT.sf_UpdFldSetStr = objEditRegionFldsENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objEditRegionFldsENS">源对象</param>
 /// <param name = "objEditRegionFldsENT">目标对象</param>
clsEditRegionFldsBL.CopyObjToSimObj = function(objEditRegionFldsENS , objEditRegionFldsENT ) 
{
objEditRegionFldsENT.mId = objEditRegionFldsENS.mId; //mId
objEditRegionFldsENT.RegionId = objEditRegionFldsENS.RegionId; //区域Id
objEditRegionFldsENT.TabFldId = objEditRegionFldsENS.TabFldId; //表字段ID
objEditRegionFldsENT.LabelCaption = objEditRegionFldsENS.LabelCaption; //标签标题
objEditRegionFldsENT.CtlTypeId = objEditRegionFldsENS.CtlTypeId; //控件类型号
objEditRegionFldsENT.DDLItemsOptionId = objEditRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objEditRegionFldsENT.DS_TabId = objEditRegionFldsENS.DS_TabId; //数据源表ID
objEditRegionFldsENT.DS_DataValueFieldId = objEditRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objEditRegionFldsENT.DS_DataTextFieldId = objEditRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objEditRegionFldsENT.DS_CondStr = objEditRegionFldsENS.DS_CondStr; //数据源条件串
objEditRegionFldsENT.DS_SQLStr = objEditRegionFldsENS.DS_SQLStr; //数据源SQL串
objEditRegionFldsENT.ItemsString = objEditRegionFldsENS.ItemsString; //列表项串
objEditRegionFldsENT.ColSpan = objEditRegionFldsENS.ColSpan; //跨列数
objEditRegionFldsENT.ColIndex = objEditRegionFldsENS.ColIndex; //列序号
objEditRegionFldsENT.Width = objEditRegionFldsENS.Width; //宽
objEditRegionFldsENT.IsMultiRow = objEditRegionFldsENS.IsMultiRow; //是否多行
objEditRegionFldsENT.SeqNum = objEditRegionFldsENS.SeqNum; //字段序号
objEditRegionFldsENT.INOUTTypeId = objEditRegionFldsENS.INOUTTypeId; //INOUT类型ID
objEditRegionFldsENT.InUse = objEditRegionFldsENS.InUse; //是否在用
objEditRegionFldsENT.PrjId = objEditRegionFldsENS.PrjId; //工程ID
objEditRegionFldsENT.UpdUser = objEditRegionFldsENS.UpdUser; //修改者
objEditRegionFldsENT.UpdDate = objEditRegionFldsENS.UpdDate; //修改日期
objEditRegionFldsENT.Memo = objEditRegionFldsENS.Memo; //说明
objEditRegionFldsENT.IsSynchToServer = objEditRegionFldsENS.IsSynchToServer; //是否同步到Server
objEditRegionFldsENT.SynchToServerDate = objEditRegionFldsENS.SynchToServerDate; //同步到Server日期
objEditRegionFldsENT.SynchToServerUser = objEditRegionFldsENS.SynchToServerUser; //同步到Server用户
objEditRegionFldsENT.IsSynchToClient = objEditRegionFldsENS.IsSynchToClient; //是否同步到Client
objEditRegionFldsENT.SynchToClientDate = objEditRegionFldsENS.SynchToClientDate; //同步到Client库日期
objEditRegionFldsENT.SynchToClientUser = objEditRegionFldsENS.SynchToClientUser; //同步到Client库用户
objEditRegionFldsENT.SynSource = objEditRegionFldsENS.SynSource; //同步来源
objEditRegionFldsENT.sf_UpdFldSetStr = objEditRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objEditRegionFldsENT.sf_FldComparisonOp = objEditRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objEditRegionFldsENS">源简化对象</param>
 /// <param name = "objEditRegionFldsENT">目标对象</param>
clsEditRegionFldsBL.CopyObjFromSimObj4Upd = function(objEditRegionFldsENS, objEditRegionFldsENT )
 {
   var strsf_UpdFldSetStr = objEditRegionFldsENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_mId)  >= 0)
{
objEditRegionFldsENT.mId = objEditRegionFldsENS.mId; //mId
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_RegionId)  >= 0)
{
objEditRegionFldsENT.RegionId = objEditRegionFldsENS.RegionId; //区域Id
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_TabFldId)  >= 0)
{
objEditRegionFldsENT.TabFldId = objEditRegionFldsENS.TabFldId; //表字段ID
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_LabelCaption)  >= 0)
{
objEditRegionFldsENT.LabelCaption = objEditRegionFldsENS.LabelCaption; //标签标题
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_CtlTypeId)  >= 0)
{
objEditRegionFldsENT.CtlTypeId = objEditRegionFldsENS.CtlTypeId; //控件类型号
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_DDLItemsOptionId)  >= 0)
{
objEditRegionFldsENT.DDLItemsOptionId = objEditRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_DS_TabId)  >= 0)
{
objEditRegionFldsENT.DS_TabId = objEditRegionFldsENS.DS_TabId; //数据源表ID
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_DS_DataValueFieldId)  >= 0)
{
objEditRegionFldsENT.DS_DataValueFieldId = objEditRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_DS_DataTextFieldId)  >= 0)
{
objEditRegionFldsENT.DS_DataTextFieldId = objEditRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_DS_CondStr)  >= 0)
{
objEditRegionFldsENT.DS_CondStr = objEditRegionFldsENS.DS_CondStr; //数据源条件串
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_DS_SQLStr)  >= 0)
{
objEditRegionFldsENT.DS_SQLStr = objEditRegionFldsENS.DS_SQLStr; //数据源SQL串
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_ItemsString)  >= 0)
{
objEditRegionFldsENT.ItemsString = objEditRegionFldsENS.ItemsString; //列表项串
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_ColSpan)  >= 0)
{
objEditRegionFldsENT.ColSpan = objEditRegionFldsENS.ColSpan; //跨列数
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_ColIndex)  >= 0)
{
objEditRegionFldsENT.ColIndex = objEditRegionFldsENS.ColIndex; //列序号
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_Width)  >= 0)
{
objEditRegionFldsENT.Width = objEditRegionFldsENS.Width; //宽
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_IsMultiRow)  >= 0)
{
objEditRegionFldsENT.IsMultiRow = objEditRegionFldsENS.IsMultiRow; //是否多行
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_SeqNum)  >= 0)
{
objEditRegionFldsENT.SeqNum = objEditRegionFldsENS.SeqNum; //字段序号
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_INOUTTypeId)  >= 0)
{
objEditRegionFldsENT.INOUTTypeId = objEditRegionFldsENS.INOUTTypeId; //INOUT类型ID
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_InUse)  >= 0)
{
objEditRegionFldsENT.InUse = objEditRegionFldsENS.InUse; //是否在用
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_PrjId)  >= 0)
{
objEditRegionFldsENT.PrjId = objEditRegionFldsENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_UpdUser)  >= 0)
{
objEditRegionFldsENT.UpdUser = objEditRegionFldsENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_UpdDate)  >= 0)
{
objEditRegionFldsENT.UpdDate = objEditRegionFldsENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_Memo)  >= 0)
{
objEditRegionFldsENT.Memo = objEditRegionFldsENS.Memo; //说明
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_IsSynchToServer)  >= 0)
{
objEditRegionFldsENT.IsSynchToServer = objEditRegionFldsENS.IsSynchToServer; //是否同步到Server
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_SynchToServerDate)  >= 0)
{
objEditRegionFldsENT.SynchToServerDate = objEditRegionFldsENS.SynchToServerDate; //同步到Server日期
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_SynchToServerUser)  >= 0)
{
objEditRegionFldsENT.SynchToServerUser = objEditRegionFldsENS.SynchToServerUser; //同步到Server用户
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_IsSynchToClient)  >= 0)
{
objEditRegionFldsENT.IsSynchToClient = objEditRegionFldsENS.IsSynchToClient; //是否同步到Client
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_SynchToClientDate)  >= 0)
{
objEditRegionFldsENT.SynchToClientDate = objEditRegionFldsENS.SynchToClientDate; //同步到Client库日期
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_SynchToClientUser)  >= 0)
{
objEditRegionFldsENT.SynchToClientUser = objEditRegionFldsENS.SynchToClientUser; //同步到Client库用户
}
if (sstrFldSet.indexOf(clsEditRegionFldsEN.con_SynSource)  >= 0)
{
objEditRegionFldsENT.SynSource = objEditRegionFldsENS.SynSource; //同步来源
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objEditRegionFldsENS">源对象</param>
 /// <param name = "objEditRegionFldsENT">目标对象</param>
clsEditRegionFldsBL.GetSimObjFromObj = function(objEditRegionFldsENS)
{
var objEditRegionFldsENT = new clsEditRegionFldsEN_Sim_js_1.clsEditRegionFldsEN_Sim();
objEditRegionFldsENT.mId = objEditRegionFldsENS.mId; //mId
objEditRegionFldsENT.RegionId = objEditRegionFldsENS.RegionId; //区域Id
objEditRegionFldsENT.TabFldId = objEditRegionFldsENS.TabFldId; //表字段ID
objEditRegionFldsENT.LabelCaption = objEditRegionFldsENS.LabelCaption; //标签标题
objEditRegionFldsENT.CtlTypeId = objEditRegionFldsENS.CtlTypeId; //控件类型号
objEditRegionFldsENT.DDLItemsOptionId = objEditRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objEditRegionFldsENT.DS_TabId = objEditRegionFldsENS.DS_TabId; //数据源表ID
objEditRegionFldsENT.DS_DataValueFieldId = objEditRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objEditRegionFldsENT.DS_DataTextFieldId = objEditRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objEditRegionFldsENT.DS_CondStr = objEditRegionFldsENS.DS_CondStr; //数据源条件串
objEditRegionFldsENT.DS_SQLStr = objEditRegionFldsENS.DS_SQLStr; //数据源SQL串
objEditRegionFldsENT.ItemsString = objEditRegionFldsENS.ItemsString; //列表项串
objEditRegionFldsENT.ColSpan = objEditRegionFldsENS.ColSpan; //跨列数
objEditRegionFldsENT.ColIndex = objEditRegionFldsENS.ColIndex; //列序号
objEditRegionFldsENT.Width = objEditRegionFldsENS.Width; //宽
objEditRegionFldsENT.IsMultiRow = objEditRegionFldsENS.IsMultiRow; //是否多行
objEditRegionFldsENT.SeqNum = objEditRegionFldsENS.SeqNum; //字段序号
objEditRegionFldsENT.INOUTTypeId = objEditRegionFldsENS.INOUTTypeId; //INOUT类型ID
objEditRegionFldsENT.InUse = objEditRegionFldsENS.InUse; //是否在用
objEditRegionFldsENT.PrjId = objEditRegionFldsENS.PrjId; //工程ID
objEditRegionFldsENT.UpdUser = objEditRegionFldsENS.UpdUser; //修改者
objEditRegionFldsENT.UpdDate = objEditRegionFldsENS.UpdDate; //修改日期
objEditRegionFldsENT.Memo = objEditRegionFldsENS.Memo; //说明
objEditRegionFldsENT.IsSynchToServer = objEditRegionFldsENS.IsSynchToServer; //是否同步到Server
objEditRegionFldsENT.SynchToServerDate = objEditRegionFldsENS.SynchToServerDate; //同步到Server日期
objEditRegionFldsENT.SynchToServerUser = objEditRegionFldsENS.SynchToServerUser; //同步到Server用户
objEditRegionFldsENT.IsSynchToClient = objEditRegionFldsENS.IsSynchToClient; //是否同步到Client
objEditRegionFldsENT.SynchToClientDate = objEditRegionFldsENS.SynchToClientDate; //同步到Client库日期
objEditRegionFldsENT.SynchToClientUser = objEditRegionFldsENS.SynchToClientUser; //同步到Client库用户
objEditRegionFldsENT.SynSource = objEditRegionFldsENS.SynSource; //同步来源
objEditRegionFldsENT.sf_UpdFldSetStr = objEditRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objEditRegionFldsENT.sf_FldComparisonOp = objEditRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objEditRegionFldsENT;
}
return clsEditRegionFldsBL;
}());
exports.clsEditRegionFldsBL = clsEditRegionFldsBL;
});