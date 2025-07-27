
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDGRegionFldsBL
 表名:DGRegionFlds(00050113)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:41
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
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsDGRegionFldsEN.js","../../L0_Entity/RegionManage/clsDGRegionFldsEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsDGRegionFldsEN_js_1 = require("../../L0_Entity/RegionManage/clsDGRegionFldsEN.js");
var clsDGRegionFldsEN_Sim_js_1 = require("../../L0_Entity/RegionManage/clsDGRegionFldsEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// DG区域字段(DGRegionFlds)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsDGRegionFldsBL = /** @class */ (function () {
function clsDGRegionFldsBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrDGRegionFldsObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsDGRegionFldsBL.prototype.CheckPropertyNew = function(pobjDGRegionFldsEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjDGRegionFldsEN.RegionId 
 || null !== pobjDGRegionFldsEN.RegionId && pobjDGRegionFldsEN.RegionId.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[DG区域字段|区域Id]不能为空(NULL)!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjDGRegionFldsEN.TabFldId 
 || null !== pobjDGRegionFldsEN.TabFldId && pobjDGRegionFldsEN.TabFldId.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[DG区域字段|表字段ID]不能为空(NULL)!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjDGRegionFldsEN.ColIndex 
 || null !== pobjDGRegionFldsEN.ColIndex && pobjDGRegionFldsEN.ColIndex.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[DG区域字段|列序号]不能为空(NULL)!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjDGRegionFldsEN.DgFuncTypeId 
 || null !== pobjDGRegionFldsEN.DgFuncTypeId && pobjDGRegionFldsEN.DgFuncTypeId.toString()  ===  ""
 || null !== pobjDGRegionFldsEN.DgFuncTypeId && pobjDGRegionFldsEN.DgFuncTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[DG区域字段|Dg功能类型Id]不能为空(NULL)!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjDGRegionFldsEN.IsNeedSort 
 || null !== pobjDGRegionFldsEN.IsNeedSort && pobjDGRegionFldsEN.IsNeedSort.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[DG区域字段|是否需要排序]不能为空(NULL)!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjDGRegionFldsEN.PrjId 
 || null !== pobjDGRegionFldsEN.PrjId && pobjDGRegionFldsEN.PrjId.toString()  ===  ""
 || null !== pobjDGRegionFldsEN.PrjId && pobjDGRegionFldsEN.PrjId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[DG区域字段|工程ID]不能为空(NULL)!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null === pobjDGRegionFldsEN.UpdUser 
 || null !== pobjDGRegionFldsEN.UpdUser && pobjDGRegionFldsEN.UpdUser.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[DG区域字段|修改者]不能为空(NULL)!(clsDGRegionFldsBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjDGRegionFldsEN.ColCaption && GetStrLen(pobjDGRegionFldsEN.ColCaption) > 100)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|列标题(ColCaption)]的长度不能超过100!值:$(pobjDGRegionFldsEN.ColCaption)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.CtlTypeId && GetStrLen(pobjDGRegionFldsEN.CtlTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|控件类型号(CtlTypeId)]的长度不能超过2!值:$(pobjDGRegionFldsEN.CtlTypeId)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.DgFuncTypeId && GetStrLen(pobjDGRegionFldsEN.DgFuncTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|Dg功能类型Id(DgFuncTypeId)]的长度不能超过4!值:$(pobjDGRegionFldsEN.DgFuncTypeId)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.PrjId && GetStrLen(pobjDGRegionFldsEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|工程ID(PrjId)]的长度不能超过4!值:$(pobjDGRegionFldsEN.PrjId)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.UpdUser && GetStrLen(pobjDGRegionFldsEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|修改者(UpdUser)]的长度不能超过20!值:$(pobjDGRegionFldsEN.UpdUser)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.UpdDate && GetStrLen(pobjDGRegionFldsEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjDGRegionFldsEN.UpdDate)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.Memo && GetStrLen(pobjDGRegionFldsEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|说明(Memo)]的长度不能超过1000!值:$(pobjDGRegionFldsEN.Memo)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynchToServerDate && GetStrLen(pobjDGRegionFldsEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjDGRegionFldsEN.SynchToServerDate)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynchToServerUser && GetStrLen(pobjDGRegionFldsEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjDGRegionFldsEN.SynchToServerUser)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynchToClientDate && GetStrLen(pobjDGRegionFldsEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjDGRegionFldsEN.SynchToClientDate)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynchToClientUser && GetStrLen(pobjDGRegionFldsEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjDGRegionFldsEN.SynchToClientUser)(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynSource && GetStrLen(pobjDGRegionFldsEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000155)字段[DG区域字段(DGRegionFlds)|同步来源(SynSource)]的长度不能超过50!值:$(pobjDGRegionFldsEN.SynSource)(clsDGRegionFldsBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjDGRegionFldsEN.mId && undefined !== pobjDGRegionFldsEN.mId && tzDataType.isNumber(pobjDGRegionFldsEN.mId) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|mId(mId)]的值:[$(pobjDGRegionFldsEN.mId)], 非法，应该为数值型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.RegionId && undefined !== pobjDGRegionFldsEN.RegionId && tzDataType.isNumber(pobjDGRegionFldsEN.RegionId) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|区域Id(RegionId)]的值:[$(pobjDGRegionFldsEN.RegionId)], 非法，应该为数值型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.TabFldId && undefined !== pobjDGRegionFldsEN.TabFldId && tzDataType.isNumber(pobjDGRegionFldsEN.TabFldId) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|表字段ID(TabFldId)]的值:[$(pobjDGRegionFldsEN.TabFldId)], 非法，应该为数值型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.ColIndex && undefined !== pobjDGRegionFldsEN.ColIndex && tzDataType.isNumber(pobjDGRegionFldsEN.ColIndex) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|列序号(ColIndex)]的值:[$(pobjDGRegionFldsEN.ColIndex)], 非法，应该为数值型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.ColCaption && undefined !== pobjDGRegionFldsEN.ColCaption && tzDataType.isString(pobjDGRegionFldsEN.ColCaption) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|列标题(ColCaption)]的值:[$(pobjDGRegionFldsEN.ColCaption)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.CtlTypeId && undefined !== pobjDGRegionFldsEN.CtlTypeId && tzDataType.isString(pobjDGRegionFldsEN.CtlTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|控件类型号(CtlTypeId)]的值:[$(pobjDGRegionFldsEN.CtlTypeId)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.DgFuncTypeId && undefined !== pobjDGRegionFldsEN.DgFuncTypeId && tzDataType.isString(pobjDGRegionFldsEN.DgFuncTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|Dg功能类型Id(DgFuncTypeId)]的值:[$(pobjDGRegionFldsEN.DgFuncTypeId)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.IsNeedSort && undefined !== pobjDGRegionFldsEN.IsNeedSort && tzDataType.isBoolean(pobjDGRegionFldsEN.IsNeedSort) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|是否需要排序(IsNeedSort)]的值:[$(pobjDGRegionFldsEN.IsNeedSort)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.IsTransToChkBox && undefined !== pobjDGRegionFldsEN.IsTransToChkBox && tzDataType.isBoolean(pobjDGRegionFldsEN.IsTransToChkBox) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|是否转换成CheckBox(IsTransToChkBox)]的值:[$(pobjDGRegionFldsEN.IsTransToChkBox)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.IsVisible && undefined !== pobjDGRegionFldsEN.IsVisible && tzDataType.isBoolean(pobjDGRegionFldsEN.IsVisible) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|是否显示(IsVisible)]的值:[$(pobjDGRegionFldsEN.IsVisible)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.IsFuncFld && undefined !== pobjDGRegionFldsEN.IsFuncFld && tzDataType.isBoolean(pobjDGRegionFldsEN.IsFuncFld) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|是否功能字段(IsFuncFld)]的值:[$(pobjDGRegionFldsEN.IsFuncFld)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.InUse && undefined !== pobjDGRegionFldsEN.InUse && tzDataType.isBoolean(pobjDGRegionFldsEN.InUse) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|是否在用(InUse)]的值:[$(pobjDGRegionFldsEN.InUse)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.PrjId && undefined !== pobjDGRegionFldsEN.PrjId && tzDataType.isString(pobjDGRegionFldsEN.PrjId) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|工程ID(PrjId)]的值:[$(pobjDGRegionFldsEN.PrjId)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.UpdUser && undefined !== pobjDGRegionFldsEN.UpdUser && tzDataType.isString(pobjDGRegionFldsEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|修改者(UpdUser)]的值:[$(pobjDGRegionFldsEN.UpdUser)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.UpdDate && undefined !== pobjDGRegionFldsEN.UpdDate && tzDataType.isString(pobjDGRegionFldsEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|修改日期(UpdDate)]的值:[$(pobjDGRegionFldsEN.UpdDate)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.Memo && undefined !== pobjDGRegionFldsEN.Memo && tzDataType.isString(pobjDGRegionFldsEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|说明(Memo)]的值:[$(pobjDGRegionFldsEN.Memo)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.IsSynchToServer && undefined !== pobjDGRegionFldsEN.IsSynchToServer && tzDataType.isBoolean(pobjDGRegionFldsEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|是否同步到Server(IsSynchToServer)]的值:[$(pobjDGRegionFldsEN.IsSynchToServer)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynchToServerDate && undefined !== pobjDGRegionFldsEN.SynchToServerDate && tzDataType.isString(pobjDGRegionFldsEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|同步到Server日期(SynchToServerDate)]的值:[$(pobjDGRegionFldsEN.SynchToServerDate)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynchToServerUser && undefined !== pobjDGRegionFldsEN.SynchToServerUser && tzDataType.isString(pobjDGRegionFldsEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|同步到Server用户(SynchToServerUser)]的值:[$(pobjDGRegionFldsEN.SynchToServerUser)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.IsSynchToClient && undefined !== pobjDGRegionFldsEN.IsSynchToClient && tzDataType.isBoolean(pobjDGRegionFldsEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|是否同步到Client(IsSynchToClient)]的值:[$(pobjDGRegionFldsEN.IsSynchToClient)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynchToClientDate && undefined !== pobjDGRegionFldsEN.SynchToClientDate && tzDataType.isString(pobjDGRegionFldsEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjDGRegionFldsEN.SynchToClientDate)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynchToClientUser && undefined !== pobjDGRegionFldsEN.SynchToClientUser && tzDataType.isString(pobjDGRegionFldsEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjDGRegionFldsEN.SynchToClientUser)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (null !== pobjDGRegionFldsEN.SynSource && undefined !== pobjDGRegionFldsEN.SynSource && tzDataType.isString(pobjDGRegionFldsEN.SynSource) === false)
{
 throw new Error("(errid:Busi000156)字段[DG区域字段(DGRegionFlds)|同步来源(SynSource)]的值:[$(pobjDGRegionFldsEN.SynSource)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjDGRegionFldsEN.CtlTypeId != null && GetStrLen(pobjDGRegionFldsEN.CtlTypeId) !=  2)
{
 throw ("(errid:Busi000157)字段[DG区域字段|控件类型号]作为外键字段,长度应该为2!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (pobjDGRegionFldsEN.DgFuncTypeId != null && GetStrLen(pobjDGRegionFldsEN.DgFuncTypeId) !=  4)
{
 throw ("(errid:Busi000157)字段[DG区域字段|Dg功能类型Id]作为外键字段,长度应该为4!(clsDGRegionFldsBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjDGRegionFldsEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsDGRegionFldsBL.prototype.CheckProperty4Update  = function(pobjDGRegionFldsEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjDGRegionFldsEN.ColCaption && GetStrLen(pobjDGRegionFldsEN.ColCaption) > 100)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|列标题(ColCaption)]的长度不能超过100!值:$(pobjDGRegionFldsEN.ColCaption)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.CtlTypeId && GetStrLen(pobjDGRegionFldsEN.CtlTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|控件类型号(CtlTypeId)]的长度不能超过2!值:$(pobjDGRegionFldsEN.CtlTypeId)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.DgFuncTypeId && GetStrLen(pobjDGRegionFldsEN.DgFuncTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|Dg功能类型Id(DgFuncTypeId)]的长度不能超过4!值:$(pobjDGRegionFldsEN.DgFuncTypeId)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.PrjId && GetStrLen(pobjDGRegionFldsEN.PrjId) > 4)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|工程ID(PrjId)]的长度不能超过4!值:$(pobjDGRegionFldsEN.PrjId)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.UpdUser && GetStrLen(pobjDGRegionFldsEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|修改者(UpdUser)]的长度不能超过20!值:$(pobjDGRegionFldsEN.UpdUser)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.UpdDate && GetStrLen(pobjDGRegionFldsEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjDGRegionFldsEN.UpdDate)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.Memo && GetStrLen(pobjDGRegionFldsEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|说明(Memo)]的长度不能超过1000!值:$(pobjDGRegionFldsEN.Memo)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynchToServerDate && GetStrLen(pobjDGRegionFldsEN.SynchToServerDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|同步到Server日期(SynchToServerDate)]的长度不能超过20!值:$(pobjDGRegionFldsEN.SynchToServerDate)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynchToServerUser && GetStrLen(pobjDGRegionFldsEN.SynchToServerUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|同步到Server用户(SynchToServerUser)]的长度不能超过20!值:$(pobjDGRegionFldsEN.SynchToServerUser)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynchToClientDate && GetStrLen(pobjDGRegionFldsEN.SynchToClientDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|同步到Client库日期(SynchToClientDate)]的长度不能超过20!值:$(pobjDGRegionFldsEN.SynchToClientDate)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynchToClientUser && GetStrLen(pobjDGRegionFldsEN.SynchToClientUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|同步到Client库用户(SynchToClientUser)]的长度不能超过20!值:$(pobjDGRegionFldsEN.SynchToClientUser)(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynSource && GetStrLen(pobjDGRegionFldsEN.SynSource) > 50)
{
 throw new Error("(errid:Busi000158)字段[DG区域字段(DGRegionFlds)|同步来源(SynSource)]的长度不能超过50!值:$(pobjDGRegionFldsEN.SynSource)(clsDGRegionFldsBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjDGRegionFldsEN.mId && undefined !== pobjDGRegionFldsEN.mId && tzDataType.isNumber(pobjDGRegionFldsEN.mId) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|mId(mId)]的值:[$(pobjDGRegionFldsEN.mId)], 非法，应该为数值型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.RegionId && undefined !== pobjDGRegionFldsEN.RegionId && tzDataType.isNumber(pobjDGRegionFldsEN.RegionId) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|区域Id(RegionId)]的值:[$(pobjDGRegionFldsEN.RegionId)], 非法，应该为数值型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.TabFldId && undefined !== pobjDGRegionFldsEN.TabFldId && tzDataType.isNumber(pobjDGRegionFldsEN.TabFldId) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|表字段ID(TabFldId)]的值:[$(pobjDGRegionFldsEN.TabFldId)], 非法，应该为数值型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.ColIndex && undefined !== pobjDGRegionFldsEN.ColIndex && tzDataType.isNumber(pobjDGRegionFldsEN.ColIndex) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|列序号(ColIndex)]的值:[$(pobjDGRegionFldsEN.ColIndex)], 非法，应该为数值型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.ColCaption && undefined !== pobjDGRegionFldsEN.ColCaption && tzDataType.isString(pobjDGRegionFldsEN.ColCaption) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|列标题(ColCaption)]的值:[$(pobjDGRegionFldsEN.ColCaption)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.CtlTypeId && undefined !== pobjDGRegionFldsEN.CtlTypeId && tzDataType.isString(pobjDGRegionFldsEN.CtlTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|控件类型号(CtlTypeId)]的值:[$(pobjDGRegionFldsEN.CtlTypeId)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.DgFuncTypeId && undefined !== pobjDGRegionFldsEN.DgFuncTypeId && tzDataType.isString(pobjDGRegionFldsEN.DgFuncTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|Dg功能类型Id(DgFuncTypeId)]的值:[$(pobjDGRegionFldsEN.DgFuncTypeId)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.IsNeedSort && undefined !== pobjDGRegionFldsEN.IsNeedSort && tzDataType.isBoolean(pobjDGRegionFldsEN.IsNeedSort) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|是否需要排序(IsNeedSort)]的值:[$(pobjDGRegionFldsEN.IsNeedSort)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.IsTransToChkBox && undefined !== pobjDGRegionFldsEN.IsTransToChkBox && tzDataType.isBoolean(pobjDGRegionFldsEN.IsTransToChkBox) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|是否转换成CheckBox(IsTransToChkBox)]的值:[$(pobjDGRegionFldsEN.IsTransToChkBox)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.IsVisible && undefined !== pobjDGRegionFldsEN.IsVisible && tzDataType.isBoolean(pobjDGRegionFldsEN.IsVisible) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|是否显示(IsVisible)]的值:[$(pobjDGRegionFldsEN.IsVisible)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.IsFuncFld && undefined !== pobjDGRegionFldsEN.IsFuncFld && tzDataType.isBoolean(pobjDGRegionFldsEN.IsFuncFld) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|是否功能字段(IsFuncFld)]的值:[$(pobjDGRegionFldsEN.IsFuncFld)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.InUse && undefined !== pobjDGRegionFldsEN.InUse && tzDataType.isBoolean(pobjDGRegionFldsEN.InUse) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|是否在用(InUse)]的值:[$(pobjDGRegionFldsEN.InUse)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.PrjId && undefined !== pobjDGRegionFldsEN.PrjId && tzDataType.isString(pobjDGRegionFldsEN.PrjId) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|工程ID(PrjId)]的值:[$(pobjDGRegionFldsEN.PrjId)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.UpdUser && undefined !== pobjDGRegionFldsEN.UpdUser && tzDataType.isString(pobjDGRegionFldsEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|修改者(UpdUser)]的值:[$(pobjDGRegionFldsEN.UpdUser)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.UpdDate && undefined !== pobjDGRegionFldsEN.UpdDate && tzDataType.isString(pobjDGRegionFldsEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|修改日期(UpdDate)]的值:[$(pobjDGRegionFldsEN.UpdDate)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.Memo && undefined !== pobjDGRegionFldsEN.Memo && tzDataType.isString(pobjDGRegionFldsEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|说明(Memo)]的值:[$(pobjDGRegionFldsEN.Memo)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.IsSynchToServer && undefined !== pobjDGRegionFldsEN.IsSynchToServer && tzDataType.isBoolean(pobjDGRegionFldsEN.IsSynchToServer) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|是否同步到Server(IsSynchToServer)]的值:[$(pobjDGRegionFldsEN.IsSynchToServer)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynchToServerDate && undefined !== pobjDGRegionFldsEN.SynchToServerDate && tzDataType.isString(pobjDGRegionFldsEN.SynchToServerDate) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|同步到Server日期(SynchToServerDate)]的值:[$(pobjDGRegionFldsEN.SynchToServerDate)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynchToServerUser && undefined !== pobjDGRegionFldsEN.SynchToServerUser && tzDataType.isString(pobjDGRegionFldsEN.SynchToServerUser) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|同步到Server用户(SynchToServerUser)]的值:[$(pobjDGRegionFldsEN.SynchToServerUser)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.IsSynchToClient && undefined !== pobjDGRegionFldsEN.IsSynchToClient && tzDataType.isBoolean(pobjDGRegionFldsEN.IsSynchToClient) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|是否同步到Client(IsSynchToClient)]的值:[$(pobjDGRegionFldsEN.IsSynchToClient)], 非法，应该为布尔型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynchToClientDate && undefined !== pobjDGRegionFldsEN.SynchToClientDate && tzDataType.isString(pobjDGRegionFldsEN.SynchToClientDate) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|同步到Client库日期(SynchToClientDate)]的值:[$(pobjDGRegionFldsEN.SynchToClientDate)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynchToClientUser && undefined !== pobjDGRegionFldsEN.SynchToClientUser && tzDataType.isString(pobjDGRegionFldsEN.SynchToClientUser) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|同步到Client库用户(SynchToClientUser)]的值:[$(pobjDGRegionFldsEN.SynchToClientUser)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
if (null !== pobjDGRegionFldsEN.SynSource && undefined !== pobjDGRegionFldsEN.SynSource && tzDataType.isString(pobjDGRegionFldsEN.SynSource) === false)
{
 throw new Error("(errid:Busi000159)字段[DG区域字段(DGRegionFlds)|同步来源(SynSource)]的值:[$(pobjDGRegionFldsEN.SynSource)], 非法，应该为字符型!(clsDGRegionFldsBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjDGRegionFldsEN.mId 
 || null !== pobjDGRegionFldsEN.mId && pobjDGRegionFldsEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Busi000160)字段[DG区域字段|mId]不能为空(NULL)!(clsDGRegionFldsBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjDGRegionFldsEN.CtlTypeId != null && GetStrLen(pobjDGRegionFldsEN.CtlTypeId) !=  2)
{
 throw ("(errid:Busi000161)字段[DG区域字段|控件类型号]作为外键字段,长度应该为2!(clsDGRegionFldsBL:CheckPropertyNew)");
}
if (pobjDGRegionFldsEN.DgFuncTypeId != null && GetStrLen(pobjDGRegionFldsEN.DgFuncTypeId) !=  4)
{
 throw ("(errid:Busi000161)字段[DG区域字段|Dg功能类型Id]作为外键字段,长度应该为4!(clsDGRegionFldsBL:CheckPropertyNew)");
}

 pobjDGRegionFldsEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024941
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsDGRegionFldsBL.GetJSONStrByObj  = function(pobjDGRegionFldsEN)
{
pobjDGRegionFldsEN.sf_UpdFldSetStr = pobjDGRegionFldsEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjDGRegionFldsEN);
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
 /// 日期:20200501024941
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsDGRegionFldsBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrDGRegionFldsObjLst = new Array();
if (strJSON === "")
{
return arrDGRegionFldsObjLst;
}
try
{
arrDGRegionFldsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrDGRegionFldsObjLst;
}
return arrDGRegionFldsObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024941
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsDGRegionFldsBL.GetObjByJSONStr  = function(strJSON)
{
var pobjDGRegionFldsEN = new clsDGRegionFldsEN();
if (strJSON === "")
{
return pobjDGRegionFldsEN;
}
try
{
pobjDGRegionFldsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjDGRegionFldsEN;
}
return pobjDGRegionFldsEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objDGRegionFldsENS">源简化对象</param>
 /// <param name = "objDGRegionFldsENT">目标对象</param>
clsDGRegionFldsBL.CopyObjFromSimObj = function(objDGRegionFldsENS, objDGRegionFldsENT) 
{
objDGRegionFldsENT.mId = objDGRegionFldsENS.mId; //mId
objDGRegionFldsENT.RegionId = objDGRegionFldsENS.RegionId; //区域Id
objDGRegionFldsENT.TabFldId = objDGRegionFldsENS.TabFldId; //表字段ID
objDGRegionFldsENT.ColIndex = objDGRegionFldsENS.ColIndex; //列序号
objDGRegionFldsENT.ColCaption = objDGRegionFldsENS.ColCaption; //列标题
objDGRegionFldsENT.CtlTypeId = objDGRegionFldsENS.CtlTypeId; //控件类型号
objDGRegionFldsENT.DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objDGRegionFldsENT.IsNeedSort = objDGRegionFldsENS.IsNeedSort; //是否需要排序
objDGRegionFldsENT.IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objDGRegionFldsENT.IsVisible = objDGRegionFldsENS.IsVisible; //是否显示
objDGRegionFldsENT.IsFuncFld = objDGRegionFldsENS.IsFuncFld; //是否功能字段
objDGRegionFldsENT.InUse = objDGRegionFldsENS.InUse; //是否在用
objDGRegionFldsENT.PrjId = objDGRegionFldsENS.PrjId; //工程ID
objDGRegionFldsENT.UpdUser = objDGRegionFldsENS.UpdUser; //修改者
objDGRegionFldsENT.UpdDate = objDGRegionFldsENS.UpdDate; //修改日期
objDGRegionFldsENT.Memo = objDGRegionFldsENS.Memo; //说明
objDGRegionFldsENT.IsSynchToServer = objDGRegionFldsENS.IsSynchToServer; //是否同步到Server
objDGRegionFldsENT.SynchToServerDate = objDGRegionFldsENS.SynchToServerDate; //同步到Server日期
objDGRegionFldsENT.SynchToServerUser = objDGRegionFldsENS.SynchToServerUser; //同步到Server用户
objDGRegionFldsENT.IsSynchToClient = objDGRegionFldsENS.IsSynchToClient; //是否同步到Client
objDGRegionFldsENT.SynchToClientDate = objDGRegionFldsENS.SynchToClientDate; //同步到Client库日期
objDGRegionFldsENT.SynchToClientUser = objDGRegionFldsENS.SynchToClientUser; //同步到Client库用户
objDGRegionFldsENT.SynSource = objDGRegionFldsENS.SynSource; //同步来源
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objDGRegionFldsENS">源对象</param>
 /// <param name = "objDGRegionFldsENT">目标对象</param>
clsDGRegionFldsBL.CopyObjTo = function(objDGRegionFldsENS , objDGRegionFldsENT ) 
{
objDGRegionFldsENT.mId = objDGRegionFldsENS.mId; //mId
objDGRegionFldsENT.RegionId = objDGRegionFldsENS.RegionId; //区域Id
objDGRegionFldsENT.TabFldId = objDGRegionFldsENS.TabFldId; //表字段ID
objDGRegionFldsENT.ColIndex = objDGRegionFldsENS.ColIndex; //列序号
objDGRegionFldsENT.ColCaption = objDGRegionFldsENS.ColCaption; //列标题
objDGRegionFldsENT.CtlTypeId = objDGRegionFldsENS.CtlTypeId; //控件类型号
objDGRegionFldsENT.DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objDGRegionFldsENT.IsNeedSort = objDGRegionFldsENS.IsNeedSort; //是否需要排序
objDGRegionFldsENT.IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objDGRegionFldsENT.IsVisible = objDGRegionFldsENS.IsVisible; //是否显示
objDGRegionFldsENT.IsFuncFld = objDGRegionFldsENS.IsFuncFld; //是否功能字段
objDGRegionFldsENT.InUse = objDGRegionFldsENS.InUse; //是否在用
objDGRegionFldsENT.PrjId = objDGRegionFldsENS.PrjId; //工程ID
objDGRegionFldsENT.UpdUser = objDGRegionFldsENS.UpdUser; //修改者
objDGRegionFldsENT.UpdDate = objDGRegionFldsENS.UpdDate; //修改日期
objDGRegionFldsENT.Memo = objDGRegionFldsENS.Memo; //说明
objDGRegionFldsENT.IsSynchToServer = objDGRegionFldsENS.IsSynchToServer; //是否同步到Server
objDGRegionFldsENT.SynchToServerDate = objDGRegionFldsENS.SynchToServerDate; //同步到Server日期
objDGRegionFldsENT.SynchToServerUser = objDGRegionFldsENS.SynchToServerUser; //同步到Server用户
objDGRegionFldsENT.IsSynchToClient = objDGRegionFldsENS.IsSynchToClient; //是否同步到Client
objDGRegionFldsENT.SynchToClientDate = objDGRegionFldsENS.SynchToClientDate; //同步到Client库日期
objDGRegionFldsENT.SynchToClientUser = objDGRegionFldsENS.SynchToClientUser; //同步到Client库用户
objDGRegionFldsENT.SynSource = objDGRegionFldsENS.SynSource; //同步来源
objDGRegionFldsENT.sf_UpdFldSetStr = objDGRegionFldsENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objDGRegionFldsENS">源对象</param>
 /// <param name = "objDGRegionFldsENT">目标对象</param>
clsDGRegionFldsBL.CopyObjToSimObj = function(objDGRegionFldsENS , objDGRegionFldsENT ) 
{
objDGRegionFldsENT.mId = objDGRegionFldsENS.mId; //mId
objDGRegionFldsENT.RegionId = objDGRegionFldsENS.RegionId; //区域Id
objDGRegionFldsENT.TabFldId = objDGRegionFldsENS.TabFldId; //表字段ID
objDGRegionFldsENT.ColIndex = objDGRegionFldsENS.ColIndex; //列序号
objDGRegionFldsENT.ColCaption = objDGRegionFldsENS.ColCaption; //列标题
objDGRegionFldsENT.CtlTypeId = objDGRegionFldsENS.CtlTypeId; //控件类型号
objDGRegionFldsENT.DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objDGRegionFldsENT.IsNeedSort = objDGRegionFldsENS.IsNeedSort; //是否需要排序
objDGRegionFldsENT.IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objDGRegionFldsENT.IsVisible = objDGRegionFldsENS.IsVisible; //是否显示
objDGRegionFldsENT.IsFuncFld = objDGRegionFldsENS.IsFuncFld; //是否功能字段
objDGRegionFldsENT.InUse = objDGRegionFldsENS.InUse; //是否在用
objDGRegionFldsENT.PrjId = objDGRegionFldsENS.PrjId; //工程ID
objDGRegionFldsENT.UpdUser = objDGRegionFldsENS.UpdUser; //修改者
objDGRegionFldsENT.UpdDate = objDGRegionFldsENS.UpdDate; //修改日期
objDGRegionFldsENT.Memo = objDGRegionFldsENS.Memo; //说明
objDGRegionFldsENT.IsSynchToServer = objDGRegionFldsENS.IsSynchToServer; //是否同步到Server
objDGRegionFldsENT.SynchToServerDate = objDGRegionFldsENS.SynchToServerDate; //同步到Server日期
objDGRegionFldsENT.SynchToServerUser = objDGRegionFldsENS.SynchToServerUser; //同步到Server用户
objDGRegionFldsENT.IsSynchToClient = objDGRegionFldsENS.IsSynchToClient; //是否同步到Client
objDGRegionFldsENT.SynchToClientDate = objDGRegionFldsENS.SynchToClientDate; //同步到Client库日期
objDGRegionFldsENT.SynchToClientUser = objDGRegionFldsENS.SynchToClientUser; //同步到Client库用户
objDGRegionFldsENT.SynSource = objDGRegionFldsENS.SynSource; //同步来源
objDGRegionFldsENT.sf_UpdFldSetStr = objDGRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objDGRegionFldsENT.sf_FldComparisonOp = objDGRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objDGRegionFldsENS">源简化对象</param>
 /// <param name = "objDGRegionFldsENT">目标对象</param>
clsDGRegionFldsBL.CopyObjFromSimObj4Upd = function(objDGRegionFldsENS, objDGRegionFldsENT )
 {
   var strsf_UpdFldSetStr = objDGRegionFldsENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_mId)  >= 0)
{
objDGRegionFldsENT.mId = objDGRegionFldsENS.mId; //mId
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_RegionId)  >= 0)
{
objDGRegionFldsENT.RegionId = objDGRegionFldsENS.RegionId; //区域Id
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_TabFldId)  >= 0)
{
objDGRegionFldsENT.TabFldId = objDGRegionFldsENS.TabFldId; //表字段ID
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_ColIndex)  >= 0)
{
objDGRegionFldsENT.ColIndex = objDGRegionFldsENS.ColIndex; //列序号
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_ColCaption)  >= 0)
{
objDGRegionFldsENT.ColCaption = objDGRegionFldsENS.ColCaption; //列标题
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_CtlTypeId)  >= 0)
{
objDGRegionFldsENT.CtlTypeId = objDGRegionFldsENS.CtlTypeId; //控件类型号
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_DgFuncTypeId)  >= 0)
{
objDGRegionFldsENT.DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_IsNeedSort)  >= 0)
{
objDGRegionFldsENT.IsNeedSort = objDGRegionFldsENS.IsNeedSort; //是否需要排序
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_IsTransToChkBox)  >= 0)
{
objDGRegionFldsENT.IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_IsVisible)  >= 0)
{
objDGRegionFldsENT.IsVisible = objDGRegionFldsENS.IsVisible; //是否显示
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_IsFuncFld)  >= 0)
{
objDGRegionFldsENT.IsFuncFld = objDGRegionFldsENS.IsFuncFld; //是否功能字段
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_InUse)  >= 0)
{
objDGRegionFldsENT.InUse = objDGRegionFldsENS.InUse; //是否在用
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_PrjId)  >= 0)
{
objDGRegionFldsENT.PrjId = objDGRegionFldsENS.PrjId; //工程ID
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_UpdUser)  >= 0)
{
objDGRegionFldsENT.UpdUser = objDGRegionFldsENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_UpdDate)  >= 0)
{
objDGRegionFldsENT.UpdDate = objDGRegionFldsENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_Memo)  >= 0)
{
objDGRegionFldsENT.Memo = objDGRegionFldsENS.Memo; //说明
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_IsSynchToServer)  >= 0)
{
objDGRegionFldsENT.IsSynchToServer = objDGRegionFldsENS.IsSynchToServer; //是否同步到Server
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_SynchToServerDate)  >= 0)
{
objDGRegionFldsENT.SynchToServerDate = objDGRegionFldsENS.SynchToServerDate; //同步到Server日期
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_SynchToServerUser)  >= 0)
{
objDGRegionFldsENT.SynchToServerUser = objDGRegionFldsENS.SynchToServerUser; //同步到Server用户
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_IsSynchToClient)  >= 0)
{
objDGRegionFldsENT.IsSynchToClient = objDGRegionFldsENS.IsSynchToClient; //是否同步到Client
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_SynchToClientDate)  >= 0)
{
objDGRegionFldsENT.SynchToClientDate = objDGRegionFldsENS.SynchToClientDate; //同步到Client库日期
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_SynchToClientUser)  >= 0)
{
objDGRegionFldsENT.SynchToClientUser = objDGRegionFldsENS.SynchToClientUser; //同步到Client库用户
}
if (sstrFldSet.indexOf(clsDGRegionFldsEN.con_SynSource)  >= 0)
{
objDGRegionFldsENT.SynSource = objDGRegionFldsENS.SynSource; //同步来源
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objDGRegionFldsENS">源对象</param>
 /// <param name = "objDGRegionFldsENT">目标对象</param>
clsDGRegionFldsBL.GetSimObjFromObj = function(objDGRegionFldsENS)
{
var objDGRegionFldsENT = new clsDGRegionFldsEN_Sim_js_1.clsDGRegionFldsEN_Sim();
objDGRegionFldsENT.mId = objDGRegionFldsENS.mId; //mId
objDGRegionFldsENT.RegionId = objDGRegionFldsENS.RegionId; //区域Id
objDGRegionFldsENT.TabFldId = objDGRegionFldsENS.TabFldId; //表字段ID
objDGRegionFldsENT.ColIndex = objDGRegionFldsENS.ColIndex; //列序号
objDGRegionFldsENT.ColCaption = objDGRegionFldsENS.ColCaption; //列标题
objDGRegionFldsENT.CtlTypeId = objDGRegionFldsENS.CtlTypeId; //控件类型号
objDGRegionFldsENT.DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objDGRegionFldsENT.IsNeedSort = objDGRegionFldsENS.IsNeedSort; //是否需要排序
objDGRegionFldsENT.IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objDGRegionFldsENT.IsVisible = objDGRegionFldsENS.IsVisible; //是否显示
objDGRegionFldsENT.IsFuncFld = objDGRegionFldsENS.IsFuncFld; //是否功能字段
objDGRegionFldsENT.InUse = objDGRegionFldsENS.InUse; //是否在用
objDGRegionFldsENT.PrjId = objDGRegionFldsENS.PrjId; //工程ID
objDGRegionFldsENT.UpdUser = objDGRegionFldsENS.UpdUser; //修改者
objDGRegionFldsENT.UpdDate = objDGRegionFldsENS.UpdDate; //修改日期
objDGRegionFldsENT.Memo = objDGRegionFldsENS.Memo; //说明
objDGRegionFldsENT.IsSynchToServer = objDGRegionFldsENS.IsSynchToServer; //是否同步到Server
objDGRegionFldsENT.SynchToServerDate = objDGRegionFldsENS.SynchToServerDate; //同步到Server日期
objDGRegionFldsENT.SynchToServerUser = objDGRegionFldsENS.SynchToServerUser; //同步到Server用户
objDGRegionFldsENT.IsSynchToClient = objDGRegionFldsENS.IsSynchToClient; //是否同步到Client
objDGRegionFldsENT.SynchToClientDate = objDGRegionFldsENS.SynchToClientDate; //同步到Client库日期
objDGRegionFldsENT.SynchToClientUser = objDGRegionFldsENS.SynchToClientUser; //同步到Client库用户
objDGRegionFldsENT.SynSource = objDGRegionFldsENS.SynSource; //同步来源
objDGRegionFldsENT.sf_UpdFldSetStr = objDGRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objDGRegionFldsENT.sf_FldComparisonOp = objDGRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objDGRegionFldsENT;
}
return clsDGRegionFldsBL;
}());
exports.clsDGRegionFldsBL = clsDGRegionFldsBL;
});