
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTabBL
 表名:FieldTab(00050021)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:03
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsFieldTabEN.js","../../L0_Entity/Table_Field/clsFieldTabEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsFieldTabEN_js_1 = require("../../L0_Entity/Table_Field/clsFieldTabEN.js");
var clsFieldTabEN_Sim_js_1 = require("../../L0_Entity/Table_Field/clsFieldTabEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 工程字段(FieldTab)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsFieldTabBL = /** @class */ (function () {
function clsFieldTabBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrFieldTabObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsFieldTabBL.prototype.CheckPropertyNew = function(pobjFieldTabEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjFieldTabEN.PrjId 
 || null !== pobjFieldTabEN.PrjId && pobjFieldTabEN.PrjId.toString()  ===  ""
 || null !== pobjFieldTabEN.PrjId && pobjFieldTabEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程字段|工程ID]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
if (null === pobjFieldTabEN.FldName 
 || null !== pobjFieldTabEN.FldName && pobjFieldTabEN.FldName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程字段|字段名]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
if (null === pobjFieldTabEN.Caption 
 || null !== pobjFieldTabEN.Caption && pobjFieldTabEN.Caption.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程字段|标题]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
if (null === pobjFieldTabEN.DataTypeId 
 || null !== pobjFieldTabEN.DataTypeId && pobjFieldTabEN.DataTypeId.toString()  ===  ""
 || null !== pobjFieldTabEN.DataTypeId && pobjFieldTabEN.DataTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程字段|数据类型Id]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
if (null === pobjFieldTabEN.FldLength 
 || null !== pobjFieldTabEN.FldLength && pobjFieldTabEN.FldLength.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程字段|字段长度]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
if (null === pobjFieldTabEN.IsNull 
 || null !== pobjFieldTabEN.IsNull && pobjFieldTabEN.IsNull.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程字段|是否可空]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
if (null === pobjFieldTabEN.IsPrimaryKey 
 || null !== pobjFieldTabEN.IsPrimaryKey && pobjFieldTabEN.IsPrimaryKey.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程字段|是否主键]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
if (null === pobjFieldTabEN.IsNeedTransCode 
 || null !== pobjFieldTabEN.IsNeedTransCode && pobjFieldTabEN.IsNeedTransCode.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程字段|是否需要转换代码]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
if (null === pobjFieldTabEN.FldStateId 
 || null !== pobjFieldTabEN.FldStateId && pobjFieldTabEN.FldStateId.toString()  ===  ""
 || null !== pobjFieldTabEN.FldStateId && pobjFieldTabEN.FldStateId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[工程字段|字段状态Id]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
if (null === pobjFieldTabEN.UpdDate 
 || null !== pobjFieldTabEN.UpdDate && pobjFieldTabEN.UpdDate.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[工程字段|修改日期]不能为空(NULL)!(clsFieldTabBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjFieldTabEN.FldId && GetStrLen(pobjFieldTabEN.FldId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|字段Id(FldId)]的长度不能超过8!值:$(pobjFieldTabEN.FldId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.PrjId && GetStrLen(pobjFieldTabEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|工程ID(PrjId)]的长度不能超过4!值:$(pobjFieldTabEN.PrjId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldName && GetStrLen(pobjFieldTabEN.FldName) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|字段名(FldName)]的长度不能超过50!值:$(pobjFieldTabEN.FldName)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldCnName && GetStrLen(pobjFieldTabEN.FldCnName) > 200)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|字段中文详名(FldCnName)]的长度不能超过200!值:$(pobjFieldTabEN.FldCnName)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldEnName && GetStrLen(pobjFieldTabEN.FldEnName) > 200)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|字段英文详名(FldEnName)]的长度不能超过200!值:$(pobjFieldTabEN.FldEnName)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldName_B && GetStrLen(pobjFieldTabEN.FldName_B) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|字段名_后备(FldName_B)]的长度不能超过50!值:$(pobjFieldTabEN.FldName_B)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldName_G && GetStrLen(pobjFieldTabEN.FldName_G) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|字段名_国标(FldName_G)]的长度不能超过50!值:$(pobjFieldTabEN.FldName_G)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.Caption && GetStrLen(pobjFieldTabEN.Caption) > 200)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|标题(Caption)]的长度不能超过200!值:$(pobjFieldTabEN.Caption)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FieldTypeId && GetStrLen(pobjFieldTabEN.FieldTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|字段类型Id(FieldTypeId)]的长度不能超过2!值:$(pobjFieldTabEN.FieldTypeId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.DataTypeId && GetStrLen(pobjFieldTabEN.DataTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|数据类型Id(DataTypeId)]的长度不能超过2!值:$(pobjFieldTabEN.DataTypeId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldInfo && GetStrLen(pobjFieldTabEN.FldInfo) > 100)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|字段信息(FldInfo)]的长度不能超过100!值:$(pobjFieldTabEN.FldInfo)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.MaxValue && GetStrLen(pobjFieldTabEN.MaxValue) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|最大值(MaxValue)]的长度不能超过50!值:$(pobjFieldTabEN.MaxValue)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.MinValue && GetStrLen(pobjFieldTabEN.MinValue) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|最小值(MinValue)]的长度不能超过50!值:$(pobjFieldTabEN.MinValue)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.DefaultValue && GetStrLen(pobjFieldTabEN.DefaultValue) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|缺省值(DefaultValue)]的长度不能超过50!值:$(pobjFieldTabEN.DefaultValue)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.AppliedScope && GetStrLen(pobjFieldTabEN.AppliedScope) > 10)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|应用范围(AppliedScope)]的长度不能超过10!值:$(pobjFieldTabEN.AppliedScope)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldStateId && GetStrLen(pobjFieldTabEN.FldStateId) > 2)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|字段状态Id(FldStateId)]的长度不能超过2!值:$(pobjFieldTabEN.FldStateId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.CodeTabId && GetStrLen(pobjFieldTabEN.CodeTabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|CodeTabId(CodeTabId)]的长度不能超过8!值:$(pobjFieldTabEN.CodeTabId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.CodeTab_NameId && GetStrLen(pobjFieldTabEN.CodeTab_NameId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|CodeTab_NameId(CodeTab_NameId)]的长度不能超过8!值:$(pobjFieldTabEN.CodeTab_NameId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.CodeTab_CodeId && GetStrLen(pobjFieldTabEN.CodeTab_CodeId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|CodeTab_CodeId(CodeTab_CodeId)]的长度不能超过8!值:$(pobjFieldTabEN.CodeTab_CodeId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.Root4TabId && GetStrLen(pobjFieldTabEN.Root4TabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|主根表Id(Root4TabId)]的长度不能超过8!值:$(pobjFieldTabEN.Root4TabId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.RootFldId && GetStrLen(pobjFieldTabEN.RootFldId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|根字段Id(RootFldId)]的长度不能超过8!值:$(pobjFieldTabEN.RootFldId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.RootTabId && GetStrLen(pobjFieldTabEN.RootTabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|根表Id(RootTabId)]的长度不能超过8!值:$(pobjFieldTabEN.RootTabId)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynchToServerDate && GetStrLen(pobjFieldTabEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjFieldTabEN.SynchToServerDate)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynchToServerUser && GetStrLen(pobjFieldTabEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjFieldTabEN.SynchToServerUser)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynchToClientDate && GetStrLen(pobjFieldTabEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjFieldTabEN.SynchToClientDate)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynchToClientUser && GetStrLen(pobjFieldTabEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjFieldTabEN.SynchToClientUser)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynSource && GetStrLen(pobjFieldTabEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|同步来源(SynSource)]的长度不能超过50!值:$(pobjFieldTabEN.SynSource)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.UpdDate && GetStrLen(pobjFieldTabEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjFieldTabEN.UpdDate)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.UpdUser && GetStrLen(pobjFieldTabEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|修改者(UpdUser)]的长度不能超过20!值:$(pobjFieldTabEN.UpdUser)(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.Memo && GetStrLen(pobjFieldTabEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[工程字段(FieldTab)|说明(Memo)]的长度不能超过1000!值:$(pobjFieldTabEN.Memo)(clsFieldTabBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjFieldTabEN.FldId && undefined !== pobjFieldTabEN.FldId && tzDataType.isString(pobjFieldTabEN.FldId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段Id(FldId)]的值:[$(pobjFieldTabEN.FldId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.PrjId && undefined !== pobjFieldTabEN.PrjId && tzDataType.isString(pobjFieldTabEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|工程ID(PrjId)]的值:[$(pobjFieldTabEN.PrjId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldName && undefined !== pobjFieldTabEN.FldName && tzDataType.isString(pobjFieldTabEN.FldName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段名(FldName)]的值:[$(pobjFieldTabEN.FldName)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldCnName && undefined !== pobjFieldTabEN.FldCnName && tzDataType.isString(pobjFieldTabEN.FldCnName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段中文详名(FldCnName)]的值:[$(pobjFieldTabEN.FldCnName)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldEnName && undefined !== pobjFieldTabEN.FldEnName && tzDataType.isString(pobjFieldTabEN.FldEnName) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段英文详名(FldEnName)]的值:[$(pobjFieldTabEN.FldEnName)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldName_B && undefined !== pobjFieldTabEN.FldName_B && tzDataType.isString(pobjFieldTabEN.FldName_B) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段名_后备(FldName_B)]的值:[$(pobjFieldTabEN.FldName_B)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldName_G && undefined !== pobjFieldTabEN.FldName_G && tzDataType.isString(pobjFieldTabEN.FldName_G) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段名_国标(FldName_G)]的值:[$(pobjFieldTabEN.FldName_G)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.Caption && undefined !== pobjFieldTabEN.Caption && tzDataType.isString(pobjFieldTabEN.Caption) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|标题(Caption)]的值:[$(pobjFieldTabEN.Caption)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FieldTypeId && undefined !== pobjFieldTabEN.FieldTypeId && tzDataType.isString(pobjFieldTabEN.FieldTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段类型Id(FieldTypeId)]的值:[$(pobjFieldTabEN.FieldTypeId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.DataTypeId && undefined !== pobjFieldTabEN.DataTypeId && tzDataType.isString(pobjFieldTabEN.DataTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|数据类型Id(DataTypeId)]的值:[$(pobjFieldTabEN.DataTypeId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldLength && undefined !== pobjFieldTabEN.FldLength && tzDataType.isNumber(pobjFieldTabEN.FldLength) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段长度(FldLength)]的值:[$(pobjFieldTabEN.FldLength)], 非法，应该为数值型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldPrecision && undefined !== pobjFieldTabEN.FldPrecision && tzDataType.isNumber(pobjFieldTabEN.FldPrecision) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|精确度(FldPrecision)]的值:[$(pobjFieldTabEN.FldPrecision)], 非法，应该为数值型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldInfo && undefined !== pobjFieldTabEN.FldInfo && tzDataType.isString(pobjFieldTabEN.FldInfo) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段信息(FldInfo)]的值:[$(pobjFieldTabEN.FldInfo)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsNull && undefined !== pobjFieldTabEN.IsNull && tzDataType.isBoolean(pobjFieldTabEN.IsNull) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否可空(IsNull)]的值:[$(pobjFieldTabEN.IsNull)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsPrimaryKey && undefined !== pobjFieldTabEN.IsPrimaryKey && tzDataType.isBoolean(pobjFieldTabEN.IsPrimaryKey) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否主键(IsPrimaryKey)]的值:[$(pobjFieldTabEN.IsPrimaryKey)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsIdentity && undefined !== pobjFieldTabEN.IsIdentity && tzDataType.isBoolean(pobjFieldTabEN.IsIdentity) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否Identity(IsIdentity)]的值:[$(pobjFieldTabEN.IsIdentity)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsNationStandard && undefined !== pobjFieldTabEN.IsNationStandard && tzDataType.isBoolean(pobjFieldTabEN.IsNationStandard) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否国标(IsNationStandard)]的值:[$(pobjFieldTabEN.IsNationStandard)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsChecked && undefined !== pobjFieldTabEN.IsChecked && tzDataType.isBoolean(pobjFieldTabEN.IsChecked) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否核实(IsChecked)]的值:[$(pobjFieldTabEN.IsChecked)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsArchive && undefined !== pobjFieldTabEN.IsArchive && tzDataType.isBoolean(pobjFieldTabEN.IsArchive) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否存档(IsArchive)]的值:[$(pobjFieldTabEN.IsArchive)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsOnlyOne && undefined !== pobjFieldTabEN.IsOnlyOne && tzDataType.isBoolean(pobjFieldTabEN.IsOnlyOne) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否唯一(IsOnlyOne)]的值:[$(pobjFieldTabEN.IsOnlyOne)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.MaxValue && undefined !== pobjFieldTabEN.MaxValue && tzDataType.isString(pobjFieldTabEN.MaxValue) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|最大值(MaxValue)]的值:[$(pobjFieldTabEN.MaxValue)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.MinValue && undefined !== pobjFieldTabEN.MinValue && tzDataType.isString(pobjFieldTabEN.MinValue) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|最小值(MinValue)]的值:[$(pobjFieldTabEN.MinValue)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.DefaultValue && undefined !== pobjFieldTabEN.DefaultValue && tzDataType.isString(pobjFieldTabEN.DefaultValue) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|缺省值(DefaultValue)]的值:[$(pobjFieldTabEN.DefaultValue)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsNeedTransCode && undefined !== pobjFieldTabEN.IsNeedTransCode && tzDataType.isBoolean(pobjFieldTabEN.IsNeedTransCode) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否需要转换代码(IsNeedTransCode)]的值:[$(pobjFieldTabEN.IsNeedTransCode)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.AppliedScope && undefined !== pobjFieldTabEN.AppliedScope && tzDataType.isString(pobjFieldTabEN.AppliedScope) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|应用范围(AppliedScope)]的值:[$(pobjFieldTabEN.AppliedScope)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.FldStateId && undefined !== pobjFieldTabEN.FldStateId && tzDataType.isString(pobjFieldTabEN.FldStateId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|字段状态Id(FldStateId)]的值:[$(pobjFieldTabEN.FldStateId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.CodeTabId && undefined !== pobjFieldTabEN.CodeTabId && tzDataType.isString(pobjFieldTabEN.CodeTabId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|CodeTabId(CodeTabId)]的值:[$(pobjFieldTabEN.CodeTabId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.CodeTab_NameId && undefined !== pobjFieldTabEN.CodeTab_NameId && tzDataType.isString(pobjFieldTabEN.CodeTab_NameId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|CodeTab_NameId(CodeTab_NameId)]的值:[$(pobjFieldTabEN.CodeTab_NameId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.CodeTab_CodeId && undefined !== pobjFieldTabEN.CodeTab_CodeId && tzDataType.isString(pobjFieldTabEN.CodeTab_CodeId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|CodeTab_CodeId(CodeTab_CodeId)]的值:[$(pobjFieldTabEN.CodeTab_CodeId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsRootFld && undefined !== pobjFieldTabEN.IsRootFld && tzDataType.isBoolean(pobjFieldTabEN.IsRootFld) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否根字段(IsRootFld)]的值:[$(pobjFieldTabEN.IsRootFld)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.Root4TabId && undefined !== pobjFieldTabEN.Root4TabId && tzDataType.isString(pobjFieldTabEN.Root4TabId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|主根表Id(Root4TabId)]的值:[$(pobjFieldTabEN.Root4TabId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.RootFldId && undefined !== pobjFieldTabEN.RootFldId && tzDataType.isString(pobjFieldTabEN.RootFldId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|根字段Id(RootFldId)]的值:[$(pobjFieldTabEN.RootFldId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.RootTabId && undefined !== pobjFieldTabEN.RootTabId && tzDataType.isString(pobjFieldTabEN.RootTabId) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|根表Id(RootTabId)]的值:[$(pobjFieldTabEN.RootTabId)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsSynchToServer && undefined !== pobjFieldTabEN.IsSynchToServer && tzDataType.isBoolean(pobjFieldTabEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否同步到Server(IsSynchToServer)]的值:[$(pobjFieldTabEN.IsSynchToServer)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynchToServerDate && undefined !== pobjFieldTabEN.SynchToServerDate && tzDataType.isString(pobjFieldTabEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|同步到Server日期(SynchToServerDate)]的值:[$(pobjFieldTabEN.SynchToServerDate)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynchToServerUser && undefined !== pobjFieldTabEN.SynchToServerUser && tzDataType.isString(pobjFieldTabEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|同步到Server用户(SynchToServerUser)]的值:[$(pobjFieldTabEN.SynchToServerUser)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.IsSynchToClient && undefined !== pobjFieldTabEN.IsSynchToClient && tzDataType.isBoolean(pobjFieldTabEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|是否同步到Client(IsSynchToClient)]的值:[$(pobjFieldTabEN.IsSynchToClient)], 非法，应该为布尔型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynchToClientDate && undefined !== pobjFieldTabEN.SynchToClientDate && tzDataType.isString(pobjFieldTabEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjFieldTabEN.SynchToClientDate)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynchToClientUser && undefined !== pobjFieldTabEN.SynchToClientUser && tzDataType.isString(pobjFieldTabEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjFieldTabEN.SynchToClientUser)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.SynSource && undefined !== pobjFieldTabEN.SynSource && tzDataType.isString(pobjFieldTabEN.SynSource) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|同步来源(SynSource)]的值:[$(pobjFieldTabEN.SynSource)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.UpdDate && undefined !== pobjFieldTabEN.UpdDate && tzDataType.isString(pobjFieldTabEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|修改日期(UpdDate)]的值:[$(pobjFieldTabEN.UpdDate)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.UpdUser && undefined !== pobjFieldTabEN.UpdUser && tzDataType.isString(pobjFieldTabEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|修改者(UpdUser)]的值:[$(pobjFieldTabEN.UpdUser)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
if (null !== pobjFieldTabEN.Memo && undefined !== pobjFieldTabEN.Memo && tzDataType.isString(pobjFieldTabEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[工程字段(FieldTab)|说明(Memo)]的值:[$(pobjFieldTabEN.Memo)], 非法，应该为字符型!(clsFieldTabBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjFieldTabEN.PrjId != null && GetStrLen(pobjFieldTabEN.PrjId) !=  4)
{
 throw ("(errid:Busi000157)字段[工程字段|工程ID]作为外键字段,长度应该为4!(clsFieldTabBL:CheckPropertyNew)");
}
if (pobjFieldTabEN.DataTypeId != null && GetStrLen(pobjFieldTabEN.DataTypeId) !=  2)
{
 throw ("(errid:Busi000157)字段[工程字段|数据类型Id]作为外键字段,长度应该为2!(clsFieldTabBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjFieldTabEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsFieldTabBL.prototype.CheckProperty4Update  = function(pobjFieldTabEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjFieldTabEN.FldId && GetStrLen(pobjFieldTabEN.FldId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|字段Id(FldId)]的长度不能超过8!值:$(pobjFieldTabEN.FldId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.PrjId && GetStrLen(pobjFieldTabEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|工程ID(PrjId)]的长度不能超过4!值:$(pobjFieldTabEN.PrjId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldName && GetStrLen(pobjFieldTabEN.FldName) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|字段名(FldName)]的长度不能超过50!值:$(pobjFieldTabEN.FldName)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldCnName && GetStrLen(pobjFieldTabEN.FldCnName) > 200)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|字段中文详名(FldCnName)]的长度不能超过200!值:$(pobjFieldTabEN.FldCnName)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldEnName && GetStrLen(pobjFieldTabEN.FldEnName) > 200)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|字段英文详名(FldEnName)]的长度不能超过200!值:$(pobjFieldTabEN.FldEnName)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldName_B && GetStrLen(pobjFieldTabEN.FldName_B) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|字段名_后备(FldName_B)]的长度不能超过50!值:$(pobjFieldTabEN.FldName_B)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldName_G && GetStrLen(pobjFieldTabEN.FldName_G) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|字段名_国标(FldName_G)]的长度不能超过50!值:$(pobjFieldTabEN.FldName_G)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.Caption && GetStrLen(pobjFieldTabEN.Caption) > 200)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|标题(Caption)]的长度不能超过200!值:$(pobjFieldTabEN.Caption)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FieldTypeId && GetStrLen(pobjFieldTabEN.FieldTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|字段类型Id(FieldTypeId)]的长度不能超过2!值:$(pobjFieldTabEN.FieldTypeId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.DataTypeId && GetStrLen(pobjFieldTabEN.DataTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|数据类型Id(DataTypeId)]的长度不能超过2!值:$(pobjFieldTabEN.DataTypeId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldInfo && GetStrLen(pobjFieldTabEN.FldInfo) > 100)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|字段信息(FldInfo)]的长度不能超过100!值:$(pobjFieldTabEN.FldInfo)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.MaxValue && GetStrLen(pobjFieldTabEN.MaxValue) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|最大值(MaxValue)]的长度不能超过50!值:$(pobjFieldTabEN.MaxValue)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.MinValue && GetStrLen(pobjFieldTabEN.MinValue) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|最小值(MinValue)]的长度不能超过50!值:$(pobjFieldTabEN.MinValue)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.DefaultValue && GetStrLen(pobjFieldTabEN.DefaultValue) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|缺省值(DefaultValue)]的长度不能超过50!值:$(pobjFieldTabEN.DefaultValue)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.AppliedScope && GetStrLen(pobjFieldTabEN.AppliedScope) > 10)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|应用范围(AppliedScope)]的长度不能超过10!值:$(pobjFieldTabEN.AppliedScope)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldStateId && GetStrLen(pobjFieldTabEN.FldStateId) > 2)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|字段状态Id(FldStateId)]的长度不能超过2!值:$(pobjFieldTabEN.FldStateId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.CodeTabId && GetStrLen(pobjFieldTabEN.CodeTabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|CodeTabId(CodeTabId)]的长度不能超过8!值:$(pobjFieldTabEN.CodeTabId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.CodeTab_NameId && GetStrLen(pobjFieldTabEN.CodeTab_NameId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|CodeTab_NameId(CodeTab_NameId)]的长度不能超过8!值:$(pobjFieldTabEN.CodeTab_NameId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.CodeTab_CodeId && GetStrLen(pobjFieldTabEN.CodeTab_CodeId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|CodeTab_CodeId(CodeTab_CodeId)]的长度不能超过8!值:$(pobjFieldTabEN.CodeTab_CodeId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.Root4TabId && GetStrLen(pobjFieldTabEN.Root4TabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|主根表Id(Root4TabId)]的长度不能超过8!值:$(pobjFieldTabEN.Root4TabId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.RootFldId && GetStrLen(pobjFieldTabEN.RootFldId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|根字段Id(RootFldId)]的长度不能超过8!值:$(pobjFieldTabEN.RootFldId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.RootTabId && GetStrLen(pobjFieldTabEN.RootTabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|根表Id(RootTabId)]的长度不能超过8!值:$(pobjFieldTabEN.RootTabId)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynchToServerDate && GetStrLen(pobjFieldTabEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjFieldTabEN.SynchToServerDate)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynchToServerUser && GetStrLen(pobjFieldTabEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjFieldTabEN.SynchToServerUser)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynchToClientDate && GetStrLen(pobjFieldTabEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjFieldTabEN.SynchToClientDate)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynchToClientUser && GetStrLen(pobjFieldTabEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjFieldTabEN.SynchToClientUser)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynSource && GetStrLen(pobjFieldTabEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|同步来源(SynSource)]的长度不能超过50!值:$(pobjFieldTabEN.SynSource)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.UpdDate && GetStrLen(pobjFieldTabEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjFieldTabEN.UpdDate)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.UpdUser && GetStrLen(pobjFieldTabEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|修改者(UpdUser)]的长度不能超过20!值:$(pobjFieldTabEN.UpdUser)(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.Memo && GetStrLen(pobjFieldTabEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[工程字段(FieldTab)|说明(Memo)]的长度不能超过1000!值:$(pobjFieldTabEN.Memo)(clsFieldTabBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjFieldTabEN.FldId && undefined !== pobjFieldTabEN.FldId && tzDataType.isString(pobjFieldTabEN.FldId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段Id(FldId)]的值:[$(pobjFieldTabEN.FldId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.PrjId && undefined !== pobjFieldTabEN.PrjId && tzDataType.isString(pobjFieldTabEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|工程ID(PrjId)]的值:[$(pobjFieldTabEN.PrjId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldName && undefined !== pobjFieldTabEN.FldName && tzDataType.isString(pobjFieldTabEN.FldName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段名(FldName)]的值:[$(pobjFieldTabEN.FldName)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldCnName && undefined !== pobjFieldTabEN.FldCnName && tzDataType.isString(pobjFieldTabEN.FldCnName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段中文详名(FldCnName)]的值:[$(pobjFieldTabEN.FldCnName)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldEnName && undefined !== pobjFieldTabEN.FldEnName && tzDataType.isString(pobjFieldTabEN.FldEnName) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段英文详名(FldEnName)]的值:[$(pobjFieldTabEN.FldEnName)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldName_B && undefined !== pobjFieldTabEN.FldName_B && tzDataType.isString(pobjFieldTabEN.FldName_B) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段名_后备(FldName_B)]的值:[$(pobjFieldTabEN.FldName_B)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldName_G && undefined !== pobjFieldTabEN.FldName_G && tzDataType.isString(pobjFieldTabEN.FldName_G) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段名_国标(FldName_G)]的值:[$(pobjFieldTabEN.FldName_G)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.Caption && undefined !== pobjFieldTabEN.Caption && tzDataType.isString(pobjFieldTabEN.Caption) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|标题(Caption)]的值:[$(pobjFieldTabEN.Caption)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FieldTypeId && undefined !== pobjFieldTabEN.FieldTypeId && tzDataType.isString(pobjFieldTabEN.FieldTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段类型Id(FieldTypeId)]的值:[$(pobjFieldTabEN.FieldTypeId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.DataTypeId && undefined !== pobjFieldTabEN.DataTypeId && tzDataType.isString(pobjFieldTabEN.DataTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|数据类型Id(DataTypeId)]的值:[$(pobjFieldTabEN.DataTypeId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldLength && undefined !== pobjFieldTabEN.FldLength && tzDataType.isNumber(pobjFieldTabEN.FldLength) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段长度(FldLength)]的值:[$(pobjFieldTabEN.FldLength)], 非法，应该为数值型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldPrecision && undefined !== pobjFieldTabEN.FldPrecision && tzDataType.isNumber(pobjFieldTabEN.FldPrecision) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|精确度(FldPrecision)]的值:[$(pobjFieldTabEN.FldPrecision)], 非法，应该为数值型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldInfo && undefined !== pobjFieldTabEN.FldInfo && tzDataType.isString(pobjFieldTabEN.FldInfo) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段信息(FldInfo)]的值:[$(pobjFieldTabEN.FldInfo)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsNull && undefined !== pobjFieldTabEN.IsNull && tzDataType.isBoolean(pobjFieldTabEN.IsNull) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否可空(IsNull)]的值:[$(pobjFieldTabEN.IsNull)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsPrimaryKey && undefined !== pobjFieldTabEN.IsPrimaryKey && tzDataType.isBoolean(pobjFieldTabEN.IsPrimaryKey) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否主键(IsPrimaryKey)]的值:[$(pobjFieldTabEN.IsPrimaryKey)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsIdentity && undefined !== pobjFieldTabEN.IsIdentity && tzDataType.isBoolean(pobjFieldTabEN.IsIdentity) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否Identity(IsIdentity)]的值:[$(pobjFieldTabEN.IsIdentity)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsNationStandard && undefined !== pobjFieldTabEN.IsNationStandard && tzDataType.isBoolean(pobjFieldTabEN.IsNationStandard) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否国标(IsNationStandard)]的值:[$(pobjFieldTabEN.IsNationStandard)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsChecked && undefined !== pobjFieldTabEN.IsChecked && tzDataType.isBoolean(pobjFieldTabEN.IsChecked) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否核实(IsChecked)]的值:[$(pobjFieldTabEN.IsChecked)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsArchive && undefined !== pobjFieldTabEN.IsArchive && tzDataType.isBoolean(pobjFieldTabEN.IsArchive) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否存档(IsArchive)]的值:[$(pobjFieldTabEN.IsArchive)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsOnlyOne && undefined !== pobjFieldTabEN.IsOnlyOne && tzDataType.isBoolean(pobjFieldTabEN.IsOnlyOne) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否唯一(IsOnlyOne)]的值:[$(pobjFieldTabEN.IsOnlyOne)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.MaxValue && undefined !== pobjFieldTabEN.MaxValue && tzDataType.isString(pobjFieldTabEN.MaxValue) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|最大值(MaxValue)]的值:[$(pobjFieldTabEN.MaxValue)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.MinValue && undefined !== pobjFieldTabEN.MinValue && tzDataType.isString(pobjFieldTabEN.MinValue) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|最小值(MinValue)]的值:[$(pobjFieldTabEN.MinValue)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.DefaultValue && undefined !== pobjFieldTabEN.DefaultValue && tzDataType.isString(pobjFieldTabEN.DefaultValue) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|缺省值(DefaultValue)]的值:[$(pobjFieldTabEN.DefaultValue)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsNeedTransCode && undefined !== pobjFieldTabEN.IsNeedTransCode && tzDataType.isBoolean(pobjFieldTabEN.IsNeedTransCode) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否需要转换代码(IsNeedTransCode)]的值:[$(pobjFieldTabEN.IsNeedTransCode)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.AppliedScope && undefined !== pobjFieldTabEN.AppliedScope && tzDataType.isString(pobjFieldTabEN.AppliedScope) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|应用范围(AppliedScope)]的值:[$(pobjFieldTabEN.AppliedScope)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.FldStateId && undefined !== pobjFieldTabEN.FldStateId && tzDataType.isString(pobjFieldTabEN.FldStateId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|字段状态Id(FldStateId)]的值:[$(pobjFieldTabEN.FldStateId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.CodeTabId && undefined !== pobjFieldTabEN.CodeTabId && tzDataType.isString(pobjFieldTabEN.CodeTabId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|CodeTabId(CodeTabId)]的值:[$(pobjFieldTabEN.CodeTabId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.CodeTab_NameId && undefined !== pobjFieldTabEN.CodeTab_NameId && tzDataType.isString(pobjFieldTabEN.CodeTab_NameId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|CodeTab_NameId(CodeTab_NameId)]的值:[$(pobjFieldTabEN.CodeTab_NameId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.CodeTab_CodeId && undefined !== pobjFieldTabEN.CodeTab_CodeId && tzDataType.isString(pobjFieldTabEN.CodeTab_CodeId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|CodeTab_CodeId(CodeTab_CodeId)]的值:[$(pobjFieldTabEN.CodeTab_CodeId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsRootFld && undefined !== pobjFieldTabEN.IsRootFld && tzDataType.isBoolean(pobjFieldTabEN.IsRootFld) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否根字段(IsRootFld)]的值:[$(pobjFieldTabEN.IsRootFld)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.Root4TabId && undefined !== pobjFieldTabEN.Root4TabId && tzDataType.isString(pobjFieldTabEN.Root4TabId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|主根表Id(Root4TabId)]的值:[$(pobjFieldTabEN.Root4TabId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.RootFldId && undefined !== pobjFieldTabEN.RootFldId && tzDataType.isString(pobjFieldTabEN.RootFldId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|根字段Id(RootFldId)]的值:[$(pobjFieldTabEN.RootFldId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.RootTabId && undefined !== pobjFieldTabEN.RootTabId && tzDataType.isString(pobjFieldTabEN.RootTabId) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|根表Id(RootTabId)]的值:[$(pobjFieldTabEN.RootTabId)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsSynchToServer && undefined !== pobjFieldTabEN.IsSynchToServer && tzDataType.isBoolean(pobjFieldTabEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否同步到Server(IsSynchToServer)]的值:[$(pobjFieldTabEN.IsSynchToServer)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynchToServerDate && undefined !== pobjFieldTabEN.SynchToServerDate && tzDataType.isString(pobjFieldTabEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|同步到Server日期(SynchToServerDate)]的值:[$(pobjFieldTabEN.SynchToServerDate)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynchToServerUser && undefined !== pobjFieldTabEN.SynchToServerUser && tzDataType.isString(pobjFieldTabEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|同步到Server用户(SynchToServerUser)]的值:[$(pobjFieldTabEN.SynchToServerUser)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.IsSynchToClient && undefined !== pobjFieldTabEN.IsSynchToClient && tzDataType.isBoolean(pobjFieldTabEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|是否同步到Client(IsSynchToClient)]的值:[$(pobjFieldTabEN.IsSynchToClient)], 非法，应该为布尔型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynchToClientDate && undefined !== pobjFieldTabEN.SynchToClientDate && tzDataType.isString(pobjFieldTabEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjFieldTabEN.SynchToClientDate)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynchToClientUser && undefined !== pobjFieldTabEN.SynchToClientUser && tzDataType.isString(pobjFieldTabEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjFieldTabEN.SynchToClientUser)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.SynSource && undefined !== pobjFieldTabEN.SynSource && tzDataType.isString(pobjFieldTabEN.SynSource) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|同步来源(SynSource)]的值:[$(pobjFieldTabEN.SynSource)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.UpdDate && undefined !== pobjFieldTabEN.UpdDate && tzDataType.isString(pobjFieldTabEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|修改日期(UpdDate)]的值:[$(pobjFieldTabEN.UpdDate)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.UpdUser && undefined !== pobjFieldTabEN.UpdUser && tzDataType.isString(pobjFieldTabEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|修改者(UpdUser)]的值:[$(pobjFieldTabEN.UpdUser)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
if (null !== pobjFieldTabEN.Memo && undefined !== pobjFieldTabEN.Memo && tzDataType.isString(pobjFieldTabEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[工程字段(FieldTab)|说明(Memo)]的值:[$(pobjFieldTabEN.Memo)], 非法，应该为字符型!(clsFieldTabBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjFieldTabEN.FldId 
 || null !== pobjFieldTabEN.FldId && pobjFieldTabEN.FldId.toString()  ===  ""
 || null !== pobjFieldTabEN.FldId && pobjFieldTabEN.FldId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[工程字段|字段Id]不能为空(NULL)!(clsFieldTabBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjFieldTabEN.PrjId != null && GetStrLen(pobjFieldTabEN.PrjId) !=  4)
{
 throw ("(errid:Busi000161)字段[工程字段|工程ID]作为外键字段,长度应该为4!(clsFieldTabBL:CheckPropertyNew)");
}
if (pobjFieldTabEN.DataTypeId != null && GetStrLen(pobjFieldTabEN.DataTypeId) !=  2)
{
 throw ("(errid:Busi000161)字段[工程字段|数据类型Id]作为外键字段,长度应该为2!(clsFieldTabBL:CheckPropertyNew)");
}

 pobjFieldTabEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200502010603
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsFieldTabBL.GetJSONStrByObj  = function(pobjFieldTabEN)
{
pobjFieldTabEN.sf_UpdFldSetStr = pobjFieldTabEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjFieldTabEN);
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
 /// 日期:20200502010603
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsFieldTabBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrFieldTabObjLst = new Array();
if (strJSON === "")
{
return arrFieldTabObjLst;
}
try
{
arrFieldTabObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrFieldTabObjLst;
}
return arrFieldTabObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200502010603
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsFieldTabBL.GetObjByJSONStr  = function(strJSON)
{
var pobjFieldTabEN = new clsFieldTabEN();
if (strJSON === "")
{
return pobjFieldTabEN;
}
try
{
pobjFieldTabEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjFieldTabEN;
}
return pobjFieldTabEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objFieldTabENS">源简化对象</param>
 /// <param name = "objFieldTabENT">目标对象</param>
clsFieldTabBL.CopyObjFromSimObj = function(objFieldTabENS, objFieldTabENT) 
{
objFieldTabENT.FldId = objFieldTabENS.FldId; //字段Id
objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程ID
objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
objFieldTabENT.FldCnName = objFieldTabENS.FldCnName; //字段中文详名
objFieldTabENT.FldEnName = objFieldTabENS.FldEnName; //字段英文详名
objFieldTabENT.FldName_B = objFieldTabENS.FldName_B; //字段名_后备
objFieldTabENT.FldName_G = objFieldTabENS.FldName_G; //字段名_国标
objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
objFieldTabENT.FieldTypeId = objFieldTabENS.FieldTypeId; //字段类型Id
objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //数据类型Id
objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
objFieldTabENT.IsNationStandard = objFieldTabENS.IsNationStandard; //是否国标
objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
objFieldTabENT.AppliedScope = objFieldTabENS.AppliedScope; //应用范围
objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
objFieldTabENT.CodeTabId = objFieldTabENS.CodeTabId; //CodeTabId
objFieldTabENT.CodeTab_NameId = objFieldTabENS.CodeTab_NameId; //CodeTab_NameId
objFieldTabENT.CodeTab_CodeId = objFieldTabENS.CodeTab_CodeId; //CodeTab_CodeId
objFieldTabENT.IsRootFld = objFieldTabENS.IsRootFld; //是否根字段
objFieldTabENT.Root4TabId = objFieldTabENS.Root4TabId; //主根表Id
objFieldTabENT.RootFldId = objFieldTabENS.RootFldId; //根字段Id
objFieldTabENT.RootTabId = objFieldTabENS.RootTabId; //根表Id
objFieldTabENT.IsSynchToServer = objFieldTabENS.IsSynchToServer; //是否同步到Server
objFieldTabENT.SynchToServerDate = objFieldTabENS.SynchToServerDate; //同步到Server日期
objFieldTabENT.SynchToServerUser = objFieldTabENS.SynchToServerUser; //同步到Server用户
objFieldTabENT.IsSynchToClient = objFieldTabENS.IsSynchToClient; //是否同步到Client
objFieldTabENT.SynchToClientDate = objFieldTabENS.SynchToClientDate; //同步到Client库日期
objFieldTabENT.SynchToClientUser = objFieldTabENS.SynchToClientUser; //同步到Client库用户
objFieldTabENT.SynSource = objFieldTabENS.SynSource; //同步来源
objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //修改者
objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objFieldTabENS">源对象</param>
 /// <param name = "objFieldTabENT">目标对象</param>
clsFieldTabBL.CopyObjTo = function(objFieldTabENS , objFieldTabENT ) 
{
objFieldTabENT.FldId = objFieldTabENS.FldId; //字段Id
objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程ID
objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
objFieldTabENT.FldCnName = objFieldTabENS.FldCnName; //字段中文详名
objFieldTabENT.FldEnName = objFieldTabENS.FldEnName; //字段英文详名
objFieldTabENT.FldName_B = objFieldTabENS.FldName_B; //字段名_后备
objFieldTabENT.FldName_G = objFieldTabENS.FldName_G; //字段名_国标
objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
objFieldTabENT.FieldTypeId = objFieldTabENS.FieldTypeId; //字段类型Id
objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //数据类型Id
objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
objFieldTabENT.IsNationStandard = objFieldTabENS.IsNationStandard; //是否国标
objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
objFieldTabENT.AppliedScope = objFieldTabENS.AppliedScope; //应用范围
objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
objFieldTabENT.CodeTabId = objFieldTabENS.CodeTabId; //CodeTabId
objFieldTabENT.CodeTab_NameId = objFieldTabENS.CodeTab_NameId; //CodeTab_NameId
objFieldTabENT.CodeTab_CodeId = objFieldTabENS.CodeTab_CodeId; //CodeTab_CodeId
objFieldTabENT.IsRootFld = objFieldTabENS.IsRootFld; //是否根字段
objFieldTabENT.Root4TabId = objFieldTabENS.Root4TabId; //主根表Id
objFieldTabENT.RootFldId = objFieldTabENS.RootFldId; //根字段Id
objFieldTabENT.RootTabId = objFieldTabENS.RootTabId; //根表Id
objFieldTabENT.IsSynchToServer = objFieldTabENS.IsSynchToServer; //是否同步到Server
objFieldTabENT.SynchToServerDate = objFieldTabENS.SynchToServerDate; //同步到Server日期
objFieldTabENT.SynchToServerUser = objFieldTabENS.SynchToServerUser; //同步到Server用户
objFieldTabENT.IsSynchToClient = objFieldTabENS.IsSynchToClient; //是否同步到Client
objFieldTabENT.SynchToClientDate = objFieldTabENS.SynchToClientDate; //同步到Client库日期
objFieldTabENT.SynchToClientUser = objFieldTabENS.SynchToClientUser; //同步到Client库用户
objFieldTabENT.SynSource = objFieldTabENS.SynSource; //同步来源
objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //修改者
objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
objFieldTabENT.sf_UpdFldSetStr = objFieldTabENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objFieldTabENS">源对象</param>
 /// <param name = "objFieldTabENT">目标对象</param>
clsFieldTabBL.CopyObjToSimObj = function(objFieldTabENS , objFieldTabENT ) 
{
objFieldTabENT.FldId = objFieldTabENS.FldId; //字段Id
objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程ID
objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
objFieldTabENT.FldCnName = objFieldTabENS.FldCnName; //字段中文详名
objFieldTabENT.FldEnName = objFieldTabENS.FldEnName; //字段英文详名
objFieldTabENT.FldName_B = objFieldTabENS.FldName_B; //字段名_后备
objFieldTabENT.FldName_G = objFieldTabENS.FldName_G; //字段名_国标
objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
objFieldTabENT.FieldTypeId = objFieldTabENS.FieldTypeId; //字段类型Id
objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //数据类型Id
objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
objFieldTabENT.IsNationStandard = objFieldTabENS.IsNationStandard; //是否国标
objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
objFieldTabENT.AppliedScope = objFieldTabENS.AppliedScope; //应用范围
objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
objFieldTabENT.CodeTabId = objFieldTabENS.CodeTabId; //CodeTabId
objFieldTabENT.CodeTab_NameId = objFieldTabENS.CodeTab_NameId; //CodeTab_NameId
objFieldTabENT.CodeTab_CodeId = objFieldTabENS.CodeTab_CodeId; //CodeTab_CodeId
objFieldTabENT.IsRootFld = objFieldTabENS.IsRootFld; //是否根字段
objFieldTabENT.Root4TabId = objFieldTabENS.Root4TabId; //主根表Id
objFieldTabENT.RootFldId = objFieldTabENS.RootFldId; //根字段Id
objFieldTabENT.RootTabId = objFieldTabENS.RootTabId; //根表Id
objFieldTabENT.IsSynchToServer = objFieldTabENS.IsSynchToServer; //是否同步到Server
objFieldTabENT.SynchToServerDate = objFieldTabENS.SynchToServerDate; //同步到Server日期
objFieldTabENT.SynchToServerUser = objFieldTabENS.SynchToServerUser; //同步到Server用户
objFieldTabENT.IsSynchToClient = objFieldTabENS.IsSynchToClient; //是否同步到Client
objFieldTabENT.SynchToClientDate = objFieldTabENS.SynchToClientDate; //同步到Client库日期
objFieldTabENT.SynchToClientUser = objFieldTabENS.SynchToClientUser; //同步到Client库用户
objFieldTabENT.SynSource = objFieldTabENS.SynSource; //同步来源
objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //修改者
objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
objFieldTabENT.sf_UpdFldSetStr = objFieldTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objFieldTabENT.sf_FldComparisonOp = objFieldTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objFieldTabENS">源简化对象</param>
 /// <param name = "objFieldTabENT">目标对象</param>
clsFieldTabBL.CopyObjFromSimObj4Upd = function(objFieldTabENS, objFieldTabENT )
 {
   var strsf_UpdFldSetStr = objFieldTabENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldId)  >= 0)
{
objFieldTabENT.FldId = objFieldTabENS.FldId; //字段Id
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_PrjId)  >= 0)
{
objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldName)  >= 0)
{
objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldCnName)  >= 0)
{
objFieldTabENT.FldCnName = objFieldTabENS.FldCnName; //字段中文详名
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldEnName)  >= 0)
{
objFieldTabENT.FldEnName = objFieldTabENS.FldEnName; //字段英文详名
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldName_B)  >= 0)
{
objFieldTabENT.FldName_B = objFieldTabENS.FldName_B; //字段名_后备
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldName_G)  >= 0)
{
objFieldTabENT.FldName_G = objFieldTabENS.FldName_G; //字段名_国标
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_Caption)  >= 0)
{
objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FieldTypeId)  >= 0)
{
objFieldTabENT.FieldTypeId = objFieldTabENS.FieldTypeId; //字段类型Id
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_DataTypeId)  >= 0)
{
objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //数据类型Id
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldLength)  >= 0)
{
objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldPrecision)  >= 0)
{
objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldInfo)  >= 0)
{
objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsNull)  >= 0)
{
objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsPrimaryKey)  >= 0)
{
objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsIdentity)  >= 0)
{
objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsNationStandard)  >= 0)
{
objFieldTabENT.IsNationStandard = objFieldTabENS.IsNationStandard; //是否国标
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsChecked)  >= 0)
{
objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsArchive)  >= 0)
{
objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsOnlyOne)  >= 0)
{
objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_MaxValue)  >= 0)
{
objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_MinValue)  >= 0)
{
objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_DefaultValue)  >= 0)
{
objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsNeedTransCode)  >= 0)
{
objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_AppliedScope)  >= 0)
{
objFieldTabENT.AppliedScope = objFieldTabENS.AppliedScope; //应用范围
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_FldStateId)  >= 0)
{
objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_CodeTabId)  >= 0)
{
objFieldTabENT.CodeTabId = objFieldTabENS.CodeTabId; //CodeTabId
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_CodeTab_NameId)  >= 0)
{
objFieldTabENT.CodeTab_NameId = objFieldTabENS.CodeTab_NameId; //CodeTab_NameId
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_CodeTab_CodeId)  >= 0)
{
objFieldTabENT.CodeTab_CodeId = objFieldTabENS.CodeTab_CodeId; //CodeTab_CodeId
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsRootFld)  >= 0)
{
objFieldTabENT.IsRootFld = objFieldTabENS.IsRootFld; //是否根字段
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_Root4TabId)  >= 0)
{
objFieldTabENT.Root4TabId = objFieldTabENS.Root4TabId; //主根表Id
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_RootFldId)  >= 0)
{
objFieldTabENT.RootFldId = objFieldTabENS.RootFldId; //根字段Id
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_RootTabId)  >= 0)
{
objFieldTabENT.RootTabId = objFieldTabENS.RootTabId; //根表Id
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsSynchToServer)  >= 0)
{
objFieldTabENT.IsSynchToServer = objFieldTabENS.IsSynchToServer; //是否同步到Server
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_SynchToServerDate)  >= 0)
{
objFieldTabENT.SynchToServerDate = objFieldTabENS.SynchToServerDate; //同步到Server日期
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_SynchToServerUser)  >= 0)
{
objFieldTabENT.SynchToServerUser = objFieldTabENS.SynchToServerUser; //同步到Server用户
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_IsSynchToClient)  >= 0)
{
objFieldTabENT.IsSynchToClient = objFieldTabENS.IsSynchToClient; //是否同步到Client
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_SynchToClientDate)  >= 0)
{
objFieldTabENT.SynchToClientDate = objFieldTabENS.SynchToClientDate; //同步到Client库日期
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_SynchToClientUser)  >= 0)
{
objFieldTabENT.SynchToClientUser = objFieldTabENS.SynchToClientUser; //同步到Client库用户
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_SynSource)  >= 0)
{
objFieldTabENT.SynSource = objFieldTabENS.SynSource; //同步来源
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_UpdDate)  >= 0)
{
objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_UpdUser)  >= 0)
{
objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsFieldTabEN.con_Memo)  >= 0)
{
objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objFieldTabENS">源对象</param>
 /// <param name = "objFieldTabENT">目标对象</param>
clsFieldTabBL.GetSimObjFromObj = function(objFieldTabENS)
{
var objFieldTabENT = new clsFieldTabEN_Sim_js_1.clsFieldTabEN_Sim();
objFieldTabENT.FldId = objFieldTabENS.FldId; //字段Id
objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程ID
objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
objFieldTabENT.FldCnName = objFieldTabENS.FldCnName; //字段中文详名
objFieldTabENT.FldEnName = objFieldTabENS.FldEnName; //字段英文详名
objFieldTabENT.FldName_B = objFieldTabENS.FldName_B; //字段名_后备
objFieldTabENT.FldName_G = objFieldTabENS.FldName_G; //字段名_国标
objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
objFieldTabENT.FieldTypeId = objFieldTabENS.FieldTypeId; //字段类型Id
objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //数据类型Id
objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
objFieldTabENT.IsNationStandard = objFieldTabENS.IsNationStandard; //是否国标
objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
objFieldTabENT.AppliedScope = objFieldTabENS.AppliedScope; //应用范围
objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
objFieldTabENT.CodeTabId = objFieldTabENS.CodeTabId; //CodeTabId
objFieldTabENT.CodeTab_NameId = objFieldTabENS.CodeTab_NameId; //CodeTab_NameId
objFieldTabENT.CodeTab_CodeId = objFieldTabENS.CodeTab_CodeId; //CodeTab_CodeId
objFieldTabENT.IsRootFld = objFieldTabENS.IsRootFld; //是否根字段
objFieldTabENT.Root4TabId = objFieldTabENS.Root4TabId; //主根表Id
objFieldTabENT.RootFldId = objFieldTabENS.RootFldId; //根字段Id
objFieldTabENT.RootTabId = objFieldTabENS.RootTabId; //根表Id
objFieldTabENT.IsSynchToServer = objFieldTabENS.IsSynchToServer; //是否同步到Server
objFieldTabENT.SynchToServerDate = objFieldTabENS.SynchToServerDate; //同步到Server日期
objFieldTabENT.SynchToServerUser = objFieldTabENS.SynchToServerUser; //同步到Server用户
objFieldTabENT.IsSynchToClient = objFieldTabENS.IsSynchToClient; //是否同步到Client
objFieldTabENT.SynchToClientDate = objFieldTabENS.SynchToClientDate; //同步到Client库日期
objFieldTabENT.SynchToClientUser = objFieldTabENS.SynchToClientUser; //同步到Client库用户
objFieldTabENT.SynSource = objFieldTabENS.SynSource; //同步来源
objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //修改者
objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
objFieldTabENT.sf_UpdFldSetStr = objFieldTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objFieldTabENT.sf_FldComparisonOp = objFieldTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objFieldTabENT;
}
return clsFieldTabBL;
}());
exports.clsFieldTabBL = clsFieldTabBL;
});