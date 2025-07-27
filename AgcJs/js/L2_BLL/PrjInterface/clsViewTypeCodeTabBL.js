
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTypeCodeTabBL
 表名:ViewTypeCodeTab(00050104)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:45
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsViewTypeCodeTabEN.js","../../L0_Entity/PrjInterface/clsViewTypeCodeTabEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsViewTypeCodeTabEN_js_1 = require("../../L0_Entity/PrjInterface/clsViewTypeCodeTabEN.js");
var clsViewTypeCodeTabEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsViewTypeCodeTabEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 界面类型码(ViewTypeCodeTab)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsViewTypeCodeTabBL = /** @class */ (function () {
function clsViewTypeCodeTabBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrViewTypeCodeTabObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewTypeCodeTabBL.prototype.CheckPropertyNew = function(pobjViewTypeCodeTabEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjViewTypeCodeTabEN.ViewTypeName 
 || null !== pobjViewTypeCodeTabEN.ViewTypeName && pobjViewTypeCodeTabEN.ViewTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|界面类型名称]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.ApplicationTypeId 
 || null !== pobjViewTypeCodeTabEN.ApplicationTypeId && pobjViewTypeCodeTabEN.ApplicationTypeId.toString()  ===  ""
 || null !== pobjViewTypeCodeTabEN.ApplicationTypeId && pobjViewTypeCodeTabEN.ApplicationTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面类型码|应用程序类型ID]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveAdd 
 || null !== pobjViewTypeCodeTabEN.IsHaveAdd && pobjViewTypeCodeTabEN.IsHaveAdd.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有添加]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveUpdate 
 || null !== pobjViewTypeCodeTabEN.IsHaveUpdate && pobjViewTypeCodeTabEN.IsHaveUpdate.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有修改]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveDel 
 || null !== pobjViewTypeCodeTabEN.IsHaveDel && pobjViewTypeCodeTabEN.IsHaveDel.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有删除]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveQuery 
 || null !== pobjViewTypeCodeTabEN.IsHaveQuery && pobjViewTypeCodeTabEN.IsHaveQuery.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有查询]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveExcelExport 
 || null !== pobjViewTypeCodeTabEN.IsHaveExcelExport && pobjViewTypeCodeTabEN.IsHaveExcelExport.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否EXCEL导出]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveSetExportExcel 
 || null !== pobjViewTypeCodeTabEN.IsHaveSetExportExcel && pobjViewTypeCodeTabEN.IsHaveSetExportExcel.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有设置EXCEL导出]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveDetail 
 || null !== pobjViewTypeCodeTabEN.IsHaveDetail && pobjViewTypeCodeTabEN.IsHaveDetail.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有详细]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveExeAdd 
 || null !== pobjViewTypeCodeTabEN.IsHaveExeAdd && pobjViewTypeCodeTabEN.IsHaveExeAdd.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有调用添加]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveExeUpdate 
 || null !== pobjViewTypeCodeTabEN.IsHaveExeUpdate && pobjViewTypeCodeTabEN.IsHaveExeUpdate.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有调用修改]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveMainView 
 || null !== pobjViewTypeCodeTabEN.IsHaveMainView && pobjViewTypeCodeTabEN.IsHaveMainView.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有主界面]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null === pobjViewTypeCodeTabEN.IsHaveSubView 
 || null !== pobjViewTypeCodeTabEN.IsHaveSubView && pobjViewTypeCodeTabEN.IsHaveSubView.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面类型码|是否有子界面]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewTypeCodeTabEN.ViewTypeName && GetStrLen(pobjViewTypeCodeTabEN.ViewTypeName) > 40)
{
 throw new Error("(errid:Busi000155)字段[界面类型码(ViewTypeCodeTab)|界面类型名称(ViewTypeName)]的长度不能超过40!值:$(pobjViewTypeCodeTabEN.ViewTypeName)(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.ViewTypeENName && GetStrLen(pobjViewTypeCodeTabEN.ViewTypeENName) > 40)
{
 throw new Error("(errid:Busi000155)字段[界面类型码(ViewTypeCodeTab)|ViewTypeENName(ViewTypeENName)]的长度不能超过40!值:$(pobjViewTypeCodeTabEN.ViewTypeENName)(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.ViewFunction && GetStrLen(pobjViewTypeCodeTabEN.ViewFunction) > 100)
{
 throw new Error("(errid:Busi000155)字段[界面类型码(ViewTypeCodeTab)|界面功能(ViewFunction)]的长度不能超过100!值:$(pobjViewTypeCodeTabEN.ViewFunction)(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.OptProcess && GetStrLen(pobjViewTypeCodeTabEN.OptProcess) > 1000)
{
 throw new Error("(errid:Busi000155)字段[界面类型码(ViewTypeCodeTab)|操作流程(OptProcess)]的长度不能超过1000!值:$(pobjViewTypeCodeTabEN.OptProcess)(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.ViewDetail && GetStrLen(pobjViewTypeCodeTabEN.ViewDetail) > 1000)
{
 throw new Error("(errid:Busi000155)字段[界面类型码(ViewTypeCodeTab)|界面说明(ViewDetail)]的长度不能超过1000!值:$(pobjViewTypeCodeTabEN.ViewDetail)(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewTypeCodeTabEN.ViewTypeCode && undefined !== pobjViewTypeCodeTabEN.ViewTypeCode && tzDataType.isNumber(pobjViewTypeCodeTabEN.ViewTypeCode) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|界面类型码(ViewTypeCode)]的值:[$(pobjViewTypeCodeTabEN.ViewTypeCode)], 非法，应该为数值型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.ViewTypeName && undefined !== pobjViewTypeCodeTabEN.ViewTypeName && tzDataType.isString(pobjViewTypeCodeTabEN.ViewTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|界面类型名称(ViewTypeName)]的值:[$(pobjViewTypeCodeTabEN.ViewTypeName)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.ViewTypeENName && undefined !== pobjViewTypeCodeTabEN.ViewTypeENName && tzDataType.isString(pobjViewTypeCodeTabEN.ViewTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|ViewTypeENName(ViewTypeENName)]的值:[$(pobjViewTypeCodeTabEN.ViewTypeENName)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsWinApp && undefined !== pobjViewTypeCodeTabEN.IsWinApp && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsWinApp) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|IsWinApp(IsWinApp)]的值:[$(pobjViewTypeCodeTabEN.IsWinApp)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsMobileApp && undefined !== pobjViewTypeCodeTabEN.IsMobileApp && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsMobileApp) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否移动终端应用(IsMobileApp)]的值:[$(pobjViewTypeCodeTabEN.IsMobileApp)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsWebApp && undefined !== pobjViewTypeCodeTabEN.IsWebApp && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsWebApp) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|IsWebApp(IsWebApp)]的值:[$(pobjViewTypeCodeTabEN.IsWebApp)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.ViewFunction && undefined !== pobjViewTypeCodeTabEN.ViewFunction && tzDataType.isString(pobjViewTypeCodeTabEN.ViewFunction) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|界面功能(ViewFunction)]的值:[$(pobjViewTypeCodeTabEN.ViewFunction)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.OptProcess && undefined !== pobjViewTypeCodeTabEN.OptProcess && tzDataType.isString(pobjViewTypeCodeTabEN.OptProcess) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|操作流程(OptProcess)]的值:[$(pobjViewTypeCodeTabEN.OptProcess)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.ViewDetail && undefined !== pobjViewTypeCodeTabEN.ViewDetail && tzDataType.isString(pobjViewTypeCodeTabEN.ViewDetail) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|界面说明(ViewDetail)]的值:[$(pobjViewTypeCodeTabEN.ViewDetail)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.ApplicationTypeId && undefined !== pobjViewTypeCodeTabEN.ApplicationTypeId && tzDataType.isNumber(pobjViewTypeCodeTabEN.ApplicationTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|应用程序类型ID(ApplicationTypeId)]的值:[$(pobjViewTypeCodeTabEN.ApplicationTypeId)], 非法，应该为数值型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveAdd && undefined !== pobjViewTypeCodeTabEN.IsHaveAdd && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveAdd) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有添加(IsHaveAdd)]的值:[$(pobjViewTypeCodeTabEN.IsHaveAdd)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveUpdate && undefined !== pobjViewTypeCodeTabEN.IsHaveUpdate && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveUpdate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有修改(IsHaveUpdate)]的值:[$(pobjViewTypeCodeTabEN.IsHaveUpdate)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveDel && undefined !== pobjViewTypeCodeTabEN.IsHaveDel && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveDel) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有删除(IsHaveDel)]的值:[$(pobjViewTypeCodeTabEN.IsHaveDel)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveQuery && undefined !== pobjViewTypeCodeTabEN.IsHaveQuery && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveQuery) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有查询(IsHaveQuery)]的值:[$(pobjViewTypeCodeTabEN.IsHaveQuery)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveExcelExport && undefined !== pobjViewTypeCodeTabEN.IsHaveExcelExport && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveExcelExport) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否EXCEL导出(IsHaveExcelExport)]的值:[$(pobjViewTypeCodeTabEN.IsHaveExcelExport)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveSetExportExcel && undefined !== pobjViewTypeCodeTabEN.IsHaveSetExportExcel && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveSetExportExcel) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有设置EXCEL导出(IsHaveSetExportExcel)]的值:[$(pobjViewTypeCodeTabEN.IsHaveSetExportExcel)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveDetail && undefined !== pobjViewTypeCodeTabEN.IsHaveDetail && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveDetail) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有详细(IsHaveDetail)]的值:[$(pobjViewTypeCodeTabEN.IsHaveDetail)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveExeAdd && undefined !== pobjViewTypeCodeTabEN.IsHaveExeAdd && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveExeAdd) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有调用添加(IsHaveExeAdd)]的值:[$(pobjViewTypeCodeTabEN.IsHaveExeAdd)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveExeUpdate && undefined !== pobjViewTypeCodeTabEN.IsHaveExeUpdate && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveExeUpdate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有调用修改(IsHaveExeUpdate)]的值:[$(pobjViewTypeCodeTabEN.IsHaveExeUpdate)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveMainView && undefined !== pobjViewTypeCodeTabEN.IsHaveMainView && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveMainView) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有主界面(IsHaveMainView)]的值:[$(pobjViewTypeCodeTabEN.IsHaveMainView)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveSubView && undefined !== pobjViewTypeCodeTabEN.IsHaveSubView && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveSubView) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|是否有子界面(IsHaveSubView)]的值:[$(pobjViewTypeCodeTabEN.IsHaveSubView)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.OrderNum && undefined !== pobjViewTypeCodeTabEN.OrderNum && tzDataType.isNumber(pobjViewTypeCodeTabEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|序号(OrderNum)]的值:[$(pobjViewTypeCodeTabEN.OrderNum)], 非法，应该为数值型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
if (null !== pobjViewTypeCodeTabEN.IsUsed && undefined !== pobjViewTypeCodeTabEN.IsUsed && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsUsed) === false)
{
 throw new Error("(errid:Busi000156)字段[界面类型码(ViewTypeCodeTab)|IsUsed(IsUsed)]的值:[$(pobjViewTypeCodeTabEN.IsUsed)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjViewTypeCodeTabEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewTypeCodeTabBL.prototype.CheckProperty4Update  = function(pobjViewTypeCodeTabEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewTypeCodeTabEN.ViewTypeName && GetStrLen(pobjViewTypeCodeTabEN.ViewTypeName) > 40)
{
 throw new Error("(errid:Busi000158)字段[界面类型码(ViewTypeCodeTab)|界面类型名称(ViewTypeName)]的长度不能超过40!值:$(pobjViewTypeCodeTabEN.ViewTypeName)(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.ViewTypeENName && GetStrLen(pobjViewTypeCodeTabEN.ViewTypeENName) > 40)
{
 throw new Error("(errid:Busi000158)字段[界面类型码(ViewTypeCodeTab)|ViewTypeENName(ViewTypeENName)]的长度不能超过40!值:$(pobjViewTypeCodeTabEN.ViewTypeENName)(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.ViewFunction && GetStrLen(pobjViewTypeCodeTabEN.ViewFunction) > 100)
{
 throw new Error("(errid:Busi000158)字段[界面类型码(ViewTypeCodeTab)|界面功能(ViewFunction)]的长度不能超过100!值:$(pobjViewTypeCodeTabEN.ViewFunction)(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.OptProcess && GetStrLen(pobjViewTypeCodeTabEN.OptProcess) > 1000)
{
 throw new Error("(errid:Busi000158)字段[界面类型码(ViewTypeCodeTab)|操作流程(OptProcess)]的长度不能超过1000!值:$(pobjViewTypeCodeTabEN.OptProcess)(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.ViewDetail && GetStrLen(pobjViewTypeCodeTabEN.ViewDetail) > 1000)
{
 throw new Error("(errid:Busi000158)字段[界面类型码(ViewTypeCodeTab)|界面说明(ViewDetail)]的长度不能超过1000!值:$(pobjViewTypeCodeTabEN.ViewDetail)(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewTypeCodeTabEN.ViewTypeCode && undefined !== pobjViewTypeCodeTabEN.ViewTypeCode && tzDataType.isNumber(pobjViewTypeCodeTabEN.ViewTypeCode) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|界面类型码(ViewTypeCode)]的值:[$(pobjViewTypeCodeTabEN.ViewTypeCode)], 非法，应该为数值型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.ViewTypeName && undefined !== pobjViewTypeCodeTabEN.ViewTypeName && tzDataType.isString(pobjViewTypeCodeTabEN.ViewTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|界面类型名称(ViewTypeName)]的值:[$(pobjViewTypeCodeTabEN.ViewTypeName)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.ViewTypeENName && undefined !== pobjViewTypeCodeTabEN.ViewTypeENName && tzDataType.isString(pobjViewTypeCodeTabEN.ViewTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|ViewTypeENName(ViewTypeENName)]的值:[$(pobjViewTypeCodeTabEN.ViewTypeENName)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsWinApp && undefined !== pobjViewTypeCodeTabEN.IsWinApp && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsWinApp) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|IsWinApp(IsWinApp)]的值:[$(pobjViewTypeCodeTabEN.IsWinApp)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsMobileApp && undefined !== pobjViewTypeCodeTabEN.IsMobileApp && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsMobileApp) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否移动终端应用(IsMobileApp)]的值:[$(pobjViewTypeCodeTabEN.IsMobileApp)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsWebApp && undefined !== pobjViewTypeCodeTabEN.IsWebApp && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsWebApp) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|IsWebApp(IsWebApp)]的值:[$(pobjViewTypeCodeTabEN.IsWebApp)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.ViewFunction && undefined !== pobjViewTypeCodeTabEN.ViewFunction && tzDataType.isString(pobjViewTypeCodeTabEN.ViewFunction) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|界面功能(ViewFunction)]的值:[$(pobjViewTypeCodeTabEN.ViewFunction)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.OptProcess && undefined !== pobjViewTypeCodeTabEN.OptProcess && tzDataType.isString(pobjViewTypeCodeTabEN.OptProcess) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|操作流程(OptProcess)]的值:[$(pobjViewTypeCodeTabEN.OptProcess)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.ViewDetail && undefined !== pobjViewTypeCodeTabEN.ViewDetail && tzDataType.isString(pobjViewTypeCodeTabEN.ViewDetail) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|界面说明(ViewDetail)]的值:[$(pobjViewTypeCodeTabEN.ViewDetail)], 非法，应该为字符型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.ApplicationTypeId && undefined !== pobjViewTypeCodeTabEN.ApplicationTypeId && tzDataType.isNumber(pobjViewTypeCodeTabEN.ApplicationTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|应用程序类型ID(ApplicationTypeId)]的值:[$(pobjViewTypeCodeTabEN.ApplicationTypeId)], 非法，应该为数值型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveAdd && undefined !== pobjViewTypeCodeTabEN.IsHaveAdd && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveAdd) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有添加(IsHaveAdd)]的值:[$(pobjViewTypeCodeTabEN.IsHaveAdd)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveUpdate && undefined !== pobjViewTypeCodeTabEN.IsHaveUpdate && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveUpdate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有修改(IsHaveUpdate)]的值:[$(pobjViewTypeCodeTabEN.IsHaveUpdate)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveDel && undefined !== pobjViewTypeCodeTabEN.IsHaveDel && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveDel) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有删除(IsHaveDel)]的值:[$(pobjViewTypeCodeTabEN.IsHaveDel)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveQuery && undefined !== pobjViewTypeCodeTabEN.IsHaveQuery && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveQuery) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有查询(IsHaveQuery)]的值:[$(pobjViewTypeCodeTabEN.IsHaveQuery)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveExcelExport && undefined !== pobjViewTypeCodeTabEN.IsHaveExcelExport && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveExcelExport) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否EXCEL导出(IsHaveExcelExport)]的值:[$(pobjViewTypeCodeTabEN.IsHaveExcelExport)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveSetExportExcel && undefined !== pobjViewTypeCodeTabEN.IsHaveSetExportExcel && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveSetExportExcel) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有设置EXCEL导出(IsHaveSetExportExcel)]的值:[$(pobjViewTypeCodeTabEN.IsHaveSetExportExcel)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveDetail && undefined !== pobjViewTypeCodeTabEN.IsHaveDetail && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveDetail) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有详细(IsHaveDetail)]的值:[$(pobjViewTypeCodeTabEN.IsHaveDetail)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveExeAdd && undefined !== pobjViewTypeCodeTabEN.IsHaveExeAdd && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveExeAdd) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有调用添加(IsHaveExeAdd)]的值:[$(pobjViewTypeCodeTabEN.IsHaveExeAdd)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveExeUpdate && undefined !== pobjViewTypeCodeTabEN.IsHaveExeUpdate && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveExeUpdate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有调用修改(IsHaveExeUpdate)]的值:[$(pobjViewTypeCodeTabEN.IsHaveExeUpdate)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveMainView && undefined !== pobjViewTypeCodeTabEN.IsHaveMainView && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveMainView) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有主界面(IsHaveMainView)]的值:[$(pobjViewTypeCodeTabEN.IsHaveMainView)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsHaveSubView && undefined !== pobjViewTypeCodeTabEN.IsHaveSubView && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsHaveSubView) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|是否有子界面(IsHaveSubView)]的值:[$(pobjViewTypeCodeTabEN.IsHaveSubView)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.OrderNum && undefined !== pobjViewTypeCodeTabEN.OrderNum && tzDataType.isNumber(pobjViewTypeCodeTabEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|序号(OrderNum)]的值:[$(pobjViewTypeCodeTabEN.OrderNum)], 非法，应该为数值型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
if (null !== pobjViewTypeCodeTabEN.IsUsed && undefined !== pobjViewTypeCodeTabEN.IsUsed && tzDataType.isBoolean(pobjViewTypeCodeTabEN.IsUsed) === false)
{
 throw new Error("(errid:Busi000159)字段[界面类型码(ViewTypeCodeTab)|IsUsed(IsUsed)]的值:[$(pobjViewTypeCodeTabEN.IsUsed)], 非法，应该为布尔型!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjViewTypeCodeTabEN.ViewTypeCode 
 || null !== pobjViewTypeCodeTabEN.ViewTypeCode && pobjViewTypeCodeTabEN.ViewTypeCode.toString()  ===  ""
 || null !== pobjViewTypeCodeTabEN.ViewTypeCode && pobjViewTypeCodeTabEN.ViewTypeCode.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[界面类型码|界面类型码]不能为空(NULL)!(clsViewTypeCodeTabBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjViewTypeCodeTabEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024945
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewTypeCodeTabBL.GetJSONStrByObj  = function(pobjViewTypeCodeTabEN)
{
pobjViewTypeCodeTabEN.sf_UpdFldSetStr = pobjViewTypeCodeTabEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjViewTypeCodeTabEN);
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
 /// 日期:20200501024945
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsViewTypeCodeTabBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrViewTypeCodeTabObjLst = new Array();
if (strJSON === "")
{
return arrViewTypeCodeTabObjLst;
}
try
{
arrViewTypeCodeTabObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrViewTypeCodeTabObjLst;
}
return arrViewTypeCodeTabObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024945
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewTypeCodeTabBL.GetObjByJSONStr  = function(strJSON)
{
var pobjViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
if (strJSON === "")
{
return pobjViewTypeCodeTabEN;
}
try
{
pobjViewTypeCodeTabEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjViewTypeCodeTabEN;
}
return pobjViewTypeCodeTabEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objViewTypeCodeTabENS">源简化对象</param>
 /// <param name = "objViewTypeCodeTabENT">目标对象</param>
clsViewTypeCodeTabBL.CopyObjFromSimObj = function(objViewTypeCodeTabENS, objViewTypeCodeTabENT) 
{
objViewTypeCodeTabENT.ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objViewTypeCodeTabENT.ViewTypeName = objViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objViewTypeCodeTabENT.ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objViewTypeCodeTabENT.IsWinApp = objViewTypeCodeTabENS.IsWinApp; //IsWinApp
objViewTypeCodeTabENT.IsMobileApp = objViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objViewTypeCodeTabENT.IsWebApp = objViewTypeCodeTabENS.IsWebApp; //IsWebApp
objViewTypeCodeTabENT.ViewFunction = objViewTypeCodeTabENS.ViewFunction; //界面功能
objViewTypeCodeTabENT.OptProcess = objViewTypeCodeTabENS.OptProcess; //操作流程
objViewTypeCodeTabENT.ViewDetail = objViewTypeCodeTabENS.ViewDetail; //界面说明
objViewTypeCodeTabENT.ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objViewTypeCodeTabENT.IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objViewTypeCodeTabENT.IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objViewTypeCodeTabENT.IsHaveDel = objViewTypeCodeTabENS.IsHaveDel; //是否有删除
objViewTypeCodeTabENT.IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objViewTypeCodeTabENT.IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objViewTypeCodeTabENT.IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objViewTypeCodeTabENT.IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objViewTypeCodeTabENT.IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objViewTypeCodeTabENT.IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objViewTypeCodeTabENT.IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objViewTypeCodeTabENT.IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objViewTypeCodeTabENT.OrderNum = objViewTypeCodeTabENS.OrderNum; //序号
objViewTypeCodeTabENT.IsUsed = objViewTypeCodeTabENS.IsUsed; //IsUsed
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objViewTypeCodeTabENS">源对象</param>
 /// <param name = "objViewTypeCodeTabENT">目标对象</param>
clsViewTypeCodeTabBL.CopyObjTo = function(objViewTypeCodeTabENS , objViewTypeCodeTabENT ) 
{
objViewTypeCodeTabENT.ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objViewTypeCodeTabENT.ViewTypeName = objViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objViewTypeCodeTabENT.ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objViewTypeCodeTabENT.IsWinApp = objViewTypeCodeTabENS.IsWinApp; //IsWinApp
objViewTypeCodeTabENT.IsMobileApp = objViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objViewTypeCodeTabENT.IsWebApp = objViewTypeCodeTabENS.IsWebApp; //IsWebApp
objViewTypeCodeTabENT.ViewFunction = objViewTypeCodeTabENS.ViewFunction; //界面功能
objViewTypeCodeTabENT.OptProcess = objViewTypeCodeTabENS.OptProcess; //操作流程
objViewTypeCodeTabENT.ViewDetail = objViewTypeCodeTabENS.ViewDetail; //界面说明
objViewTypeCodeTabENT.ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objViewTypeCodeTabENT.IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objViewTypeCodeTabENT.IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objViewTypeCodeTabENT.IsHaveDel = objViewTypeCodeTabENS.IsHaveDel; //是否有删除
objViewTypeCodeTabENT.IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objViewTypeCodeTabENT.IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objViewTypeCodeTabENT.IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objViewTypeCodeTabENT.IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objViewTypeCodeTabENT.IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objViewTypeCodeTabENT.IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objViewTypeCodeTabENT.IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objViewTypeCodeTabENT.IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objViewTypeCodeTabENT.OrderNum = objViewTypeCodeTabENS.OrderNum; //序号
objViewTypeCodeTabENT.IsUsed = objViewTypeCodeTabENS.IsUsed; //IsUsed
objViewTypeCodeTabENT.sf_UpdFldSetStr = objViewTypeCodeTabENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objViewTypeCodeTabENS">源对象</param>
 /// <param name = "objViewTypeCodeTabENT">目标对象</param>
clsViewTypeCodeTabBL.CopyObjToSimObj = function(objViewTypeCodeTabENS , objViewTypeCodeTabENT ) 
{
objViewTypeCodeTabENT.ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objViewTypeCodeTabENT.ViewTypeName = objViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objViewTypeCodeTabENT.ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objViewTypeCodeTabENT.IsWinApp = objViewTypeCodeTabENS.IsWinApp; //IsWinApp
objViewTypeCodeTabENT.IsMobileApp = objViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objViewTypeCodeTabENT.IsWebApp = objViewTypeCodeTabENS.IsWebApp; //IsWebApp
objViewTypeCodeTabENT.ViewFunction = objViewTypeCodeTabENS.ViewFunction; //界面功能
objViewTypeCodeTabENT.OptProcess = objViewTypeCodeTabENS.OptProcess; //操作流程
objViewTypeCodeTabENT.ViewDetail = objViewTypeCodeTabENS.ViewDetail; //界面说明
objViewTypeCodeTabENT.ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objViewTypeCodeTabENT.IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objViewTypeCodeTabENT.IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objViewTypeCodeTabENT.IsHaveDel = objViewTypeCodeTabENS.IsHaveDel; //是否有删除
objViewTypeCodeTabENT.IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objViewTypeCodeTabENT.IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objViewTypeCodeTabENT.IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objViewTypeCodeTabENT.IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objViewTypeCodeTabENT.IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objViewTypeCodeTabENT.IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objViewTypeCodeTabENT.IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objViewTypeCodeTabENT.IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objViewTypeCodeTabENT.OrderNum = objViewTypeCodeTabENS.OrderNum; //序号
objViewTypeCodeTabENT.IsUsed = objViewTypeCodeTabENS.IsUsed; //IsUsed
objViewTypeCodeTabENT.sf_UpdFldSetStr = objViewTypeCodeTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewTypeCodeTabENT.sf_FldComparisonOp = objViewTypeCodeTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objViewTypeCodeTabENS">源简化对象</param>
 /// <param name = "objViewTypeCodeTabENT">目标对象</param>
clsViewTypeCodeTabBL.CopyObjFromSimObj4Upd = function(objViewTypeCodeTabENS, objViewTypeCodeTabENT )
 {
   var strsf_UpdFldSetStr = objViewTypeCodeTabENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_ViewTypeCode)  >= 0)
{
objViewTypeCodeTabENT.ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode; //界面类型码
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_ViewTypeName)  >= 0)
{
objViewTypeCodeTabENT.ViewTypeName = objViewTypeCodeTabENS.ViewTypeName; //界面类型名称
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_ViewTypeENName)  >= 0)
{
objViewTypeCodeTabENT.ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsWinApp)  >= 0)
{
objViewTypeCodeTabENT.IsWinApp = objViewTypeCodeTabENS.IsWinApp; //IsWinApp
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsMobileApp)  >= 0)
{
objViewTypeCodeTabENT.IsMobileApp = objViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsWebApp)  >= 0)
{
objViewTypeCodeTabENT.IsWebApp = objViewTypeCodeTabENS.IsWebApp; //IsWebApp
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_ViewFunction)  >= 0)
{
objViewTypeCodeTabENT.ViewFunction = objViewTypeCodeTabENS.ViewFunction; //界面功能
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_OptProcess)  >= 0)
{
objViewTypeCodeTabENT.OptProcess = objViewTypeCodeTabENS.OptProcess; //操作流程
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_ViewDetail)  >= 0)
{
objViewTypeCodeTabENT.ViewDetail = objViewTypeCodeTabENS.ViewDetail; //界面说明
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_ApplicationTypeId)  >= 0)
{
objViewTypeCodeTabENT.ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveAdd)  >= 0)
{
objViewTypeCodeTabENT.IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd; //是否有添加
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveUpdate)  >= 0)
{
objViewTypeCodeTabENT.IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveDel)  >= 0)
{
objViewTypeCodeTabENT.IsHaveDel = objViewTypeCodeTabENS.IsHaveDel; //是否有删除
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveQuery)  >= 0)
{
objViewTypeCodeTabENT.IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery; //是否有查询
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveExcelExport)  >= 0)
{
objViewTypeCodeTabENT.IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveSetExportExcel)  >= 0)
{
objViewTypeCodeTabENT.IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveDetail)  >= 0)
{
objViewTypeCodeTabENT.IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail; //是否有详细
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveExeAdd)  >= 0)
{
objViewTypeCodeTabENT.IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveExeUpdate)  >= 0)
{
objViewTypeCodeTabENT.IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveMainView)  >= 0)
{
objViewTypeCodeTabENT.IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsHaveSubView)  >= 0)
{
objViewTypeCodeTabENT.IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_OrderNum)  >= 0)
{
objViewTypeCodeTabENT.OrderNum = objViewTypeCodeTabENS.OrderNum; //序号
}
if (sstrFldSet.indexOf(clsViewTypeCodeTabEN.con_IsUsed)  >= 0)
{
objViewTypeCodeTabENT.IsUsed = objViewTypeCodeTabENS.IsUsed; //IsUsed
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objViewTypeCodeTabENS">源对象</param>
 /// <param name = "objViewTypeCodeTabENT">目标对象</param>
clsViewTypeCodeTabBL.GetSimObjFromObj = function(objViewTypeCodeTabENS)
{
var objViewTypeCodeTabENT = new clsViewTypeCodeTabEN_Sim_js_1.clsViewTypeCodeTabEN_Sim();
objViewTypeCodeTabENT.ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objViewTypeCodeTabENT.ViewTypeName = objViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objViewTypeCodeTabENT.ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objViewTypeCodeTabENT.IsWinApp = objViewTypeCodeTabENS.IsWinApp; //IsWinApp
objViewTypeCodeTabENT.IsMobileApp = objViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objViewTypeCodeTabENT.IsWebApp = objViewTypeCodeTabENS.IsWebApp; //IsWebApp
objViewTypeCodeTabENT.ViewFunction = objViewTypeCodeTabENS.ViewFunction; //界面功能
objViewTypeCodeTabENT.OptProcess = objViewTypeCodeTabENS.OptProcess; //操作流程
objViewTypeCodeTabENT.ViewDetail = objViewTypeCodeTabENS.ViewDetail; //界面说明
objViewTypeCodeTabENT.ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objViewTypeCodeTabENT.IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objViewTypeCodeTabENT.IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objViewTypeCodeTabENT.IsHaveDel = objViewTypeCodeTabENS.IsHaveDel; //是否有删除
objViewTypeCodeTabENT.IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objViewTypeCodeTabENT.IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objViewTypeCodeTabENT.IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objViewTypeCodeTabENT.IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objViewTypeCodeTabENT.IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objViewTypeCodeTabENT.IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objViewTypeCodeTabENT.IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objViewTypeCodeTabENT.IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objViewTypeCodeTabENT.OrderNum = objViewTypeCodeTabENS.OrderNum; //序号
objViewTypeCodeTabENT.IsUsed = objViewTypeCodeTabENS.IsUsed; //IsUsed
objViewTypeCodeTabENT.sf_UpdFldSetStr = objViewTypeCodeTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewTypeCodeTabENT.sf_FldComparisonOp = objViewTypeCodeTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objViewTypeCodeTabENT;
}
return clsViewTypeCodeTabBL;
}());
exports.clsViewTypeCodeTabBL = clsViewTypeCodeTabBL;
});