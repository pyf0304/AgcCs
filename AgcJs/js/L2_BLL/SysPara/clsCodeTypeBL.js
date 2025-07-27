
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeTypeBL
 表名:CodeType(00050203)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:50:00
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsCodeTypeEN.js","../../L0_Entity/SysPara/clsCodeTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsCodeTypeEN_js_1 = require("../../L0_Entity/SysPara/clsCodeTypeEN.js");
var clsCodeTypeEN_Sim_js_1 = require("../../L0_Entity/SysPara/clsCodeTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 代码类型(CodeType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsCodeTypeBL = /** @class */ (function () {
function clsCodeTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrCodeTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsCodeTypeBL.prototype.CheckPropertyNew = function(pobjCodeTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjCodeTypeEN.CodeTypeName 
 || null !== pobjCodeTypeEN.CodeTypeName && pobjCodeTypeEN.CodeTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[代码类型|代码类型名]不能为空(NULL)!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null === pobjCodeTypeEN.CodeTypeSimName 
 || null !== pobjCodeTypeEN.CodeTypeSimName && pobjCodeTypeEN.CodeTypeSimName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[代码类型|简称]不能为空(NULL)!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null === pobjCodeTypeEN.ProgLangTypeId 
 || null !== pobjCodeTypeEN.ProgLangTypeId && pobjCodeTypeEN.ProgLangTypeId.toString()  ===  ""
 || null !== pobjCodeTypeEN.ProgLangTypeId && pobjCodeTypeEN.ProgLangTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[代码类型|编程语言类型Id]不能为空(NULL)!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null === pobjCodeTypeEN.RegionTypeId 
 || null !== pobjCodeTypeEN.RegionTypeId && pobjCodeTypeEN.RegionTypeId.toString()  ===  ""
 || null !== pobjCodeTypeEN.RegionTypeId && pobjCodeTypeEN.RegionTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[代码类型|区域类型Id]不能为空(NULL)!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null === pobjCodeTypeEN.SQLDSTypeId 
 || null !== pobjCodeTypeEN.SQLDSTypeId && pobjCodeTypeEN.SQLDSTypeId.toString()  ===  ""
 || null !== pobjCodeTypeEN.SQLDSTypeId && pobjCodeTypeEN.SQLDSTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[代码类型|数据源类型]不能为空(NULL)!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null === pobjCodeTypeEN.IsDefaultOverride 
 || null !== pobjCodeTypeEN.IsDefaultOverride && pobjCodeTypeEN.IsDefaultOverride.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[代码类型|是否默认覆盖]不能为空(NULL)!(clsCodeTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjCodeTypeEN.CodeTypeId && GetStrLen(pobjCodeTypeEN.CodeTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|代码类型Id(CodeTypeId)]的长度不能超过4!值:$(pobjCodeTypeEN.CodeTypeId)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.CodeTypeName && GetStrLen(pobjCodeTypeEN.CodeTypeName) > 50)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|代码类型名(CodeTypeName)]的长度不能超过50!值:$(pobjCodeTypeEN.CodeTypeName)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.CodeTypeSimName && GetStrLen(pobjCodeTypeEN.CodeTypeSimName) > 50)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|简称(CodeTypeSimName)]的长度不能超过50!值:$(pobjCodeTypeEN.CodeTypeSimName)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.CodeTypeENName && GetStrLen(pobjCodeTypeEN.CodeTypeENName) > 50)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|代码类型英文名(CodeTypeENName)]的长度不能超过50!值:$(pobjCodeTypeEN.CodeTypeENName)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.GroupName && GetStrLen(pobjCodeTypeEN.GroupName) > 30)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|组名(GroupName)]的长度不能超过30!值:$(pobjCodeTypeEN.GroupName)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.ProgLangTypeId && GetStrLen(pobjCodeTypeEN.ProgLangTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|编程语言类型Id(ProgLangTypeId)]的长度不能超过2!值:$(pobjCodeTypeEN.ProgLangTypeId)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.RegionTypeId && GetStrLen(pobjCodeTypeEN.RegionTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|区域类型Id(RegionTypeId)]的长度不能超过4!值:$(pobjCodeTypeEN.RegionTypeId)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.Prefix && GetStrLen(pobjCodeTypeEN.Prefix) > 10)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|前缀(Prefix)]的长度不能超过10!值:$(pobjCodeTypeEN.Prefix)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.DependsOn && GetStrLen(pobjCodeTypeEN.DependsOn) > 50)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|依赖于(DependsOn)]的长度不能超过50!值:$(pobjCodeTypeEN.DependsOn)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.FrontOrBack && GetStrLen(pobjCodeTypeEN.FrontOrBack) > 50)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|前台Or后台(FrontOrBack)]的长度不能超过50!值:$(pobjCodeTypeEN.FrontOrBack)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.SQLDSTypeId && GetStrLen(pobjCodeTypeEN.SQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|数据源类型(SQLDSTypeId)]的长度不能超过2!值:$(pobjCodeTypeEN.SQLDSTypeId)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.ClassNameFormat && GetStrLen(pobjCodeTypeEN.ClassNameFormat) > 50)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|类名格式(ClassNameFormat)]的长度不能超过50!值:$(pobjCodeTypeEN.ClassNameFormat)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.FileNameFormat && GetStrLen(pobjCodeTypeEN.FileNameFormat) > 50)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|文件名格式(FileNameFormat)]的长度不能超过50!值:$(pobjCodeTypeEN.FileNameFormat)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.ClassNamePattern && GetStrLen(pobjCodeTypeEN.ClassNamePattern) > 50)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|类名模式(ClassNamePattern)]的长度不能超过50!值:$(pobjCodeTypeEN.ClassNamePattern)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.WinOrWeb && GetStrLen(pobjCodeTypeEN.WinOrWeb) > 50)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|WinOrWeb(WinOrWeb)]的长度不能超过50!值:$(pobjCodeTypeEN.WinOrWeb)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.UpdDate && GetStrLen(pobjCodeTypeEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjCodeTypeEN.UpdDate)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.UpdUser && GetStrLen(pobjCodeTypeEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|修改者(UpdUser)]的长度不能超过20!值:$(pobjCodeTypeEN.UpdUser)(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.Memo && GetStrLen(pobjCodeTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[代码类型(CodeType)|说明(Memo)]的长度不能超过1000!值:$(pobjCodeTypeEN.Memo)(clsCodeTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjCodeTypeEN.CodeTypeId && undefined !== pobjCodeTypeEN.CodeTypeId && tzDataType.isString(pobjCodeTypeEN.CodeTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|代码类型Id(CodeTypeId)]的值:[$(pobjCodeTypeEN.CodeTypeId)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.CodeTypeName && undefined !== pobjCodeTypeEN.CodeTypeName && tzDataType.isString(pobjCodeTypeEN.CodeTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|代码类型名(CodeTypeName)]的值:[$(pobjCodeTypeEN.CodeTypeName)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.CodeTypeSimName && undefined !== pobjCodeTypeEN.CodeTypeSimName && tzDataType.isString(pobjCodeTypeEN.CodeTypeSimName) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|简称(CodeTypeSimName)]的值:[$(pobjCodeTypeEN.CodeTypeSimName)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.CodeTypeENName && undefined !== pobjCodeTypeEN.CodeTypeENName && tzDataType.isString(pobjCodeTypeEN.CodeTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|代码类型英文名(CodeTypeENName)]的值:[$(pobjCodeTypeEN.CodeTypeENName)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.GroupName && undefined !== pobjCodeTypeEN.GroupName && tzDataType.isString(pobjCodeTypeEN.GroupName) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|组名(GroupName)]的值:[$(pobjCodeTypeEN.GroupName)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.ProgLangTypeId && undefined !== pobjCodeTypeEN.ProgLangTypeId && tzDataType.isString(pobjCodeTypeEN.ProgLangTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|编程语言类型Id(ProgLangTypeId)]的值:[$(pobjCodeTypeEN.ProgLangTypeId)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.RegionTypeId && undefined !== pobjCodeTypeEN.RegionTypeId && tzDataType.isString(pobjCodeTypeEN.RegionTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|区域类型Id(RegionTypeId)]的值:[$(pobjCodeTypeEN.RegionTypeId)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.Prefix && undefined !== pobjCodeTypeEN.Prefix && tzDataType.isString(pobjCodeTypeEN.Prefix) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|前缀(Prefix)]的值:[$(pobjCodeTypeEN.Prefix)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.DependsOn && undefined !== pobjCodeTypeEN.DependsOn && tzDataType.isString(pobjCodeTypeEN.DependsOn) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|依赖于(DependsOn)]的值:[$(pobjCodeTypeEN.DependsOn)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.FrontOrBack && undefined !== pobjCodeTypeEN.FrontOrBack && tzDataType.isString(pobjCodeTypeEN.FrontOrBack) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|前台Or后台(FrontOrBack)]的值:[$(pobjCodeTypeEN.FrontOrBack)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.SQLDSTypeId && undefined !== pobjCodeTypeEN.SQLDSTypeId && tzDataType.isString(pobjCodeTypeEN.SQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|数据源类型(SQLDSTypeId)]的值:[$(pobjCodeTypeEN.SQLDSTypeId)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.ClassNameFormat && undefined !== pobjCodeTypeEN.ClassNameFormat && tzDataType.isString(pobjCodeTypeEN.ClassNameFormat) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|类名格式(ClassNameFormat)]的值:[$(pobjCodeTypeEN.ClassNameFormat)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.FileNameFormat && undefined !== pobjCodeTypeEN.FileNameFormat && tzDataType.isString(pobjCodeTypeEN.FileNameFormat) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|文件名格式(FileNameFormat)]的值:[$(pobjCodeTypeEN.FileNameFormat)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.ClassNamePattern && undefined !== pobjCodeTypeEN.ClassNamePattern && tzDataType.isString(pobjCodeTypeEN.ClassNamePattern) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|类名模式(ClassNamePattern)]的值:[$(pobjCodeTypeEN.ClassNamePattern)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsCSharp && undefined !== pobjCodeTypeEN.IsCSharp && tzDataType.isBoolean(pobjCodeTypeEN.IsCSharp) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否CSharp语言(IsCSharp)]的值:[$(pobjCodeTypeEN.IsCSharp)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsJava && undefined !== pobjCodeTypeEN.IsJava && tzDataType.isBoolean(pobjCodeTypeEN.IsJava) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否Java语言(IsJava)]的值:[$(pobjCodeTypeEN.IsJava)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsJavaScript && undefined !== pobjCodeTypeEN.IsJavaScript && tzDataType.isBoolean(pobjCodeTypeEN.IsJavaScript) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否JavaScript语言(IsJavaScript)]的值:[$(pobjCodeTypeEN.IsJavaScript)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsTypeScript && undefined !== pobjCodeTypeEN.IsTypeScript && tzDataType.isBoolean(pobjCodeTypeEN.IsTypeScript) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否TypeScript语言(IsTypeScript)]的值:[$(pobjCodeTypeEN.IsTypeScript)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsSilverLight && undefined !== pobjCodeTypeEN.IsSilverLight && tzDataType.isBoolean(pobjCodeTypeEN.IsSilverLight) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否SilverLight语言(IsSilverLight)]的值:[$(pobjCodeTypeEN.IsSilverLight)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsSwift && undefined !== pobjCodeTypeEN.IsSwift && tzDataType.isBoolean(pobjCodeTypeEN.IsSwift) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否Swift语言(IsSwift)]的值:[$(pobjCodeTypeEN.IsSwift)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsVB && undefined !== pobjCodeTypeEN.IsVB && tzDataType.isBoolean(pobjCodeTypeEN.IsVB) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|IsVB语言(IsVB)]的值:[$(pobjCodeTypeEN.IsVB)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsTableFldConst && undefined !== pobjCodeTypeEN.IsTableFldConst && tzDataType.isBoolean(pobjCodeTypeEN.IsTableFldConst) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|IsTableFldConst(IsTableFldConst)]的值:[$(pobjCodeTypeEN.IsTableFldConst)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsPubApp4WinWeb && undefined !== pobjCodeTypeEN.IsPubApp4WinWeb && tzDataType.isBoolean(pobjCodeTypeEN.IsPubApp4WinWeb) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|IsPubApp4WinWeb(IsPubApp4WinWeb)]的值:[$(pobjCodeTypeEN.IsPubApp4WinWeb)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsWeb && undefined !== pobjCodeTypeEN.IsWeb && tzDataType.isBoolean(pobjCodeTypeEN.IsWeb) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否Web应用(IsWeb)]的值:[$(pobjCodeTypeEN.IsWeb)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsAspMvc && undefined !== pobjCodeTypeEN.IsAspMvc && tzDataType.isBoolean(pobjCodeTypeEN.IsAspMvc) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否AspMvc(IsAspMvc)]的值:[$(pobjCodeTypeEN.IsAspMvc)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsWebSrvAccess && undefined !== pobjCodeTypeEN.IsWebSrvAccess && tzDataType.isBoolean(pobjCodeTypeEN.IsWebSrvAccess) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|IsWebSrvAccess(IsWebSrvAccess)]的值:[$(pobjCodeTypeEN.IsWebSrvAccess)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsWin && undefined !== pobjCodeTypeEN.IsWin && tzDataType.isBoolean(pobjCodeTypeEN.IsWin) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否Win应用(IsWin)]的值:[$(pobjCodeTypeEN.IsWin)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsMobileApp && undefined !== pobjCodeTypeEN.IsMobileApp && tzDataType.isBoolean(pobjCodeTypeEN.IsMobileApp) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否移动终端应用(IsMobileApp)]的值:[$(pobjCodeTypeEN.IsMobileApp)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsExtend && undefined !== pobjCodeTypeEN.IsExtend && tzDataType.isBoolean(pobjCodeTypeEN.IsExtend) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否扩展类(IsExtend)]的值:[$(pobjCodeTypeEN.IsExtend)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.OrderNum && undefined !== pobjCodeTypeEN.OrderNum && tzDataType.isNumber(pobjCodeTypeEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|序号(OrderNum)]的值:[$(pobjCodeTypeEN.OrderNum)], 非法，应该为数值型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.WinOrWeb && undefined !== pobjCodeTypeEN.WinOrWeb && tzDataType.isString(pobjCodeTypeEN.WinOrWeb) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|WinOrWeb(WinOrWeb)]的值:[$(pobjCodeTypeEN.WinOrWeb)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsDirByTabName && undefined !== pobjCodeTypeEN.IsDirByTabName && tzDataType.isBoolean(pobjCodeTypeEN.IsDirByTabName) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否用表名作为路径(IsDirByTabName)]的值:[$(pobjCodeTypeEN.IsDirByTabName)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsDefaultOverride && undefined !== pobjCodeTypeEN.IsDefaultOverride && tzDataType.isBoolean(pobjCodeTypeEN.IsDefaultOverride) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否默认覆盖(IsDefaultOverride)]的值:[$(pobjCodeTypeEN.IsDefaultOverride)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.InUse && undefined !== pobjCodeTypeEN.InUse && tzDataType.isBoolean(pobjCodeTypeEN.InUse) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否在用(InUse)]的值:[$(pobjCodeTypeEN.InUse)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.IsAutoParseFile && undefined !== pobjCodeTypeEN.IsAutoParseFile && tzDataType.isBoolean(pobjCodeTypeEN.IsAutoParseFile) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|是否自动分析文件(IsAutoParseFile)]的值:[$(pobjCodeTypeEN.IsAutoParseFile)], 非法，应该为布尔型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.UpdDate && undefined !== pobjCodeTypeEN.UpdDate && tzDataType.isString(pobjCodeTypeEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|修改日期(UpdDate)]的值:[$(pobjCodeTypeEN.UpdDate)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.UpdUser && undefined !== pobjCodeTypeEN.UpdUser && tzDataType.isString(pobjCodeTypeEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|修改者(UpdUser)]的值:[$(pobjCodeTypeEN.UpdUser)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
if (null !== pobjCodeTypeEN.Memo && undefined !== pobjCodeTypeEN.Memo && tzDataType.isString(pobjCodeTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[代码类型(CodeType)|说明(Memo)]的值:[$(pobjCodeTypeEN.Memo)], 非法，应该为字符型!(clsCodeTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjCodeTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsCodeTypeBL.prototype.CheckProperty4Update  = function(pobjCodeTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjCodeTypeEN.CodeTypeId && GetStrLen(pobjCodeTypeEN.CodeTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|代码类型Id(CodeTypeId)]的长度不能超过4!值:$(pobjCodeTypeEN.CodeTypeId)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.CodeTypeName && GetStrLen(pobjCodeTypeEN.CodeTypeName) > 50)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|代码类型名(CodeTypeName)]的长度不能超过50!值:$(pobjCodeTypeEN.CodeTypeName)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.CodeTypeSimName && GetStrLen(pobjCodeTypeEN.CodeTypeSimName) > 50)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|简称(CodeTypeSimName)]的长度不能超过50!值:$(pobjCodeTypeEN.CodeTypeSimName)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.CodeTypeENName && GetStrLen(pobjCodeTypeEN.CodeTypeENName) > 50)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|代码类型英文名(CodeTypeENName)]的长度不能超过50!值:$(pobjCodeTypeEN.CodeTypeENName)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.GroupName && GetStrLen(pobjCodeTypeEN.GroupName) > 30)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|组名(GroupName)]的长度不能超过30!值:$(pobjCodeTypeEN.GroupName)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.ProgLangTypeId && GetStrLen(pobjCodeTypeEN.ProgLangTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|编程语言类型Id(ProgLangTypeId)]的长度不能超过2!值:$(pobjCodeTypeEN.ProgLangTypeId)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.RegionTypeId && GetStrLen(pobjCodeTypeEN.RegionTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|区域类型Id(RegionTypeId)]的长度不能超过4!值:$(pobjCodeTypeEN.RegionTypeId)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.Prefix && GetStrLen(pobjCodeTypeEN.Prefix) > 10)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|前缀(Prefix)]的长度不能超过10!值:$(pobjCodeTypeEN.Prefix)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.DependsOn && GetStrLen(pobjCodeTypeEN.DependsOn) > 50)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|依赖于(DependsOn)]的长度不能超过50!值:$(pobjCodeTypeEN.DependsOn)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.FrontOrBack && GetStrLen(pobjCodeTypeEN.FrontOrBack) > 50)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|前台Or后台(FrontOrBack)]的长度不能超过50!值:$(pobjCodeTypeEN.FrontOrBack)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.SQLDSTypeId && GetStrLen(pobjCodeTypeEN.SQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|数据源类型(SQLDSTypeId)]的长度不能超过2!值:$(pobjCodeTypeEN.SQLDSTypeId)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.ClassNameFormat && GetStrLen(pobjCodeTypeEN.ClassNameFormat) > 50)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|类名格式(ClassNameFormat)]的长度不能超过50!值:$(pobjCodeTypeEN.ClassNameFormat)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.FileNameFormat && GetStrLen(pobjCodeTypeEN.FileNameFormat) > 50)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|文件名格式(FileNameFormat)]的长度不能超过50!值:$(pobjCodeTypeEN.FileNameFormat)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.ClassNamePattern && GetStrLen(pobjCodeTypeEN.ClassNamePattern) > 50)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|类名模式(ClassNamePattern)]的长度不能超过50!值:$(pobjCodeTypeEN.ClassNamePattern)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.WinOrWeb && GetStrLen(pobjCodeTypeEN.WinOrWeb) > 50)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|WinOrWeb(WinOrWeb)]的长度不能超过50!值:$(pobjCodeTypeEN.WinOrWeb)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.UpdDate && GetStrLen(pobjCodeTypeEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjCodeTypeEN.UpdDate)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.UpdUser && GetStrLen(pobjCodeTypeEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|修改者(UpdUser)]的长度不能超过20!值:$(pobjCodeTypeEN.UpdUser)(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.Memo && GetStrLen(pobjCodeTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[代码类型(CodeType)|说明(Memo)]的长度不能超过1000!值:$(pobjCodeTypeEN.Memo)(clsCodeTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjCodeTypeEN.CodeTypeId && undefined !== pobjCodeTypeEN.CodeTypeId && tzDataType.isString(pobjCodeTypeEN.CodeTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|代码类型Id(CodeTypeId)]的值:[$(pobjCodeTypeEN.CodeTypeId)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.CodeTypeName && undefined !== pobjCodeTypeEN.CodeTypeName && tzDataType.isString(pobjCodeTypeEN.CodeTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|代码类型名(CodeTypeName)]的值:[$(pobjCodeTypeEN.CodeTypeName)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.CodeTypeSimName && undefined !== pobjCodeTypeEN.CodeTypeSimName && tzDataType.isString(pobjCodeTypeEN.CodeTypeSimName) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|简称(CodeTypeSimName)]的值:[$(pobjCodeTypeEN.CodeTypeSimName)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.CodeTypeENName && undefined !== pobjCodeTypeEN.CodeTypeENName && tzDataType.isString(pobjCodeTypeEN.CodeTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|代码类型英文名(CodeTypeENName)]的值:[$(pobjCodeTypeEN.CodeTypeENName)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.GroupName && undefined !== pobjCodeTypeEN.GroupName && tzDataType.isString(pobjCodeTypeEN.GroupName) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|组名(GroupName)]的值:[$(pobjCodeTypeEN.GroupName)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.ProgLangTypeId && undefined !== pobjCodeTypeEN.ProgLangTypeId && tzDataType.isString(pobjCodeTypeEN.ProgLangTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|编程语言类型Id(ProgLangTypeId)]的值:[$(pobjCodeTypeEN.ProgLangTypeId)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.RegionTypeId && undefined !== pobjCodeTypeEN.RegionTypeId && tzDataType.isString(pobjCodeTypeEN.RegionTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|区域类型Id(RegionTypeId)]的值:[$(pobjCodeTypeEN.RegionTypeId)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.Prefix && undefined !== pobjCodeTypeEN.Prefix && tzDataType.isString(pobjCodeTypeEN.Prefix) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|前缀(Prefix)]的值:[$(pobjCodeTypeEN.Prefix)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.DependsOn && undefined !== pobjCodeTypeEN.DependsOn && tzDataType.isString(pobjCodeTypeEN.DependsOn) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|依赖于(DependsOn)]的值:[$(pobjCodeTypeEN.DependsOn)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.FrontOrBack && undefined !== pobjCodeTypeEN.FrontOrBack && tzDataType.isString(pobjCodeTypeEN.FrontOrBack) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|前台Or后台(FrontOrBack)]的值:[$(pobjCodeTypeEN.FrontOrBack)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.SQLDSTypeId && undefined !== pobjCodeTypeEN.SQLDSTypeId && tzDataType.isString(pobjCodeTypeEN.SQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|数据源类型(SQLDSTypeId)]的值:[$(pobjCodeTypeEN.SQLDSTypeId)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.ClassNameFormat && undefined !== pobjCodeTypeEN.ClassNameFormat && tzDataType.isString(pobjCodeTypeEN.ClassNameFormat) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|类名格式(ClassNameFormat)]的值:[$(pobjCodeTypeEN.ClassNameFormat)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.FileNameFormat && undefined !== pobjCodeTypeEN.FileNameFormat && tzDataType.isString(pobjCodeTypeEN.FileNameFormat) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|文件名格式(FileNameFormat)]的值:[$(pobjCodeTypeEN.FileNameFormat)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.ClassNamePattern && undefined !== pobjCodeTypeEN.ClassNamePattern && tzDataType.isString(pobjCodeTypeEN.ClassNamePattern) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|类名模式(ClassNamePattern)]的值:[$(pobjCodeTypeEN.ClassNamePattern)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsCSharp && undefined !== pobjCodeTypeEN.IsCSharp && tzDataType.isBoolean(pobjCodeTypeEN.IsCSharp) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否CSharp语言(IsCSharp)]的值:[$(pobjCodeTypeEN.IsCSharp)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsJava && undefined !== pobjCodeTypeEN.IsJava && tzDataType.isBoolean(pobjCodeTypeEN.IsJava) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否Java语言(IsJava)]的值:[$(pobjCodeTypeEN.IsJava)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsJavaScript && undefined !== pobjCodeTypeEN.IsJavaScript && tzDataType.isBoolean(pobjCodeTypeEN.IsJavaScript) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否JavaScript语言(IsJavaScript)]的值:[$(pobjCodeTypeEN.IsJavaScript)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsTypeScript && undefined !== pobjCodeTypeEN.IsTypeScript && tzDataType.isBoolean(pobjCodeTypeEN.IsTypeScript) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否TypeScript语言(IsTypeScript)]的值:[$(pobjCodeTypeEN.IsTypeScript)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsSilverLight && undefined !== pobjCodeTypeEN.IsSilverLight && tzDataType.isBoolean(pobjCodeTypeEN.IsSilverLight) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否SilverLight语言(IsSilverLight)]的值:[$(pobjCodeTypeEN.IsSilverLight)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsSwift && undefined !== pobjCodeTypeEN.IsSwift && tzDataType.isBoolean(pobjCodeTypeEN.IsSwift) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否Swift语言(IsSwift)]的值:[$(pobjCodeTypeEN.IsSwift)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsVB && undefined !== pobjCodeTypeEN.IsVB && tzDataType.isBoolean(pobjCodeTypeEN.IsVB) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|IsVB语言(IsVB)]的值:[$(pobjCodeTypeEN.IsVB)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsTableFldConst && undefined !== pobjCodeTypeEN.IsTableFldConst && tzDataType.isBoolean(pobjCodeTypeEN.IsTableFldConst) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|IsTableFldConst(IsTableFldConst)]的值:[$(pobjCodeTypeEN.IsTableFldConst)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsPubApp4WinWeb && undefined !== pobjCodeTypeEN.IsPubApp4WinWeb && tzDataType.isBoolean(pobjCodeTypeEN.IsPubApp4WinWeb) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|IsPubApp4WinWeb(IsPubApp4WinWeb)]的值:[$(pobjCodeTypeEN.IsPubApp4WinWeb)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsWeb && undefined !== pobjCodeTypeEN.IsWeb && tzDataType.isBoolean(pobjCodeTypeEN.IsWeb) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否Web应用(IsWeb)]的值:[$(pobjCodeTypeEN.IsWeb)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsAspMvc && undefined !== pobjCodeTypeEN.IsAspMvc && tzDataType.isBoolean(pobjCodeTypeEN.IsAspMvc) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否AspMvc(IsAspMvc)]的值:[$(pobjCodeTypeEN.IsAspMvc)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsWebSrvAccess && undefined !== pobjCodeTypeEN.IsWebSrvAccess && tzDataType.isBoolean(pobjCodeTypeEN.IsWebSrvAccess) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|IsWebSrvAccess(IsWebSrvAccess)]的值:[$(pobjCodeTypeEN.IsWebSrvAccess)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsWin && undefined !== pobjCodeTypeEN.IsWin && tzDataType.isBoolean(pobjCodeTypeEN.IsWin) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否Win应用(IsWin)]的值:[$(pobjCodeTypeEN.IsWin)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsMobileApp && undefined !== pobjCodeTypeEN.IsMobileApp && tzDataType.isBoolean(pobjCodeTypeEN.IsMobileApp) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否移动终端应用(IsMobileApp)]的值:[$(pobjCodeTypeEN.IsMobileApp)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsExtend && undefined !== pobjCodeTypeEN.IsExtend && tzDataType.isBoolean(pobjCodeTypeEN.IsExtend) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否扩展类(IsExtend)]的值:[$(pobjCodeTypeEN.IsExtend)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.OrderNum && undefined !== pobjCodeTypeEN.OrderNum && tzDataType.isNumber(pobjCodeTypeEN.OrderNum) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|序号(OrderNum)]的值:[$(pobjCodeTypeEN.OrderNum)], 非法，应该为数值型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.WinOrWeb && undefined !== pobjCodeTypeEN.WinOrWeb && tzDataType.isString(pobjCodeTypeEN.WinOrWeb) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|WinOrWeb(WinOrWeb)]的值:[$(pobjCodeTypeEN.WinOrWeb)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsDirByTabName && undefined !== pobjCodeTypeEN.IsDirByTabName && tzDataType.isBoolean(pobjCodeTypeEN.IsDirByTabName) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否用表名作为路径(IsDirByTabName)]的值:[$(pobjCodeTypeEN.IsDirByTabName)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsDefaultOverride && undefined !== pobjCodeTypeEN.IsDefaultOverride && tzDataType.isBoolean(pobjCodeTypeEN.IsDefaultOverride) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否默认覆盖(IsDefaultOverride)]的值:[$(pobjCodeTypeEN.IsDefaultOverride)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.InUse && undefined !== pobjCodeTypeEN.InUse && tzDataType.isBoolean(pobjCodeTypeEN.InUse) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否在用(InUse)]的值:[$(pobjCodeTypeEN.InUse)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.IsAutoParseFile && undefined !== pobjCodeTypeEN.IsAutoParseFile && tzDataType.isBoolean(pobjCodeTypeEN.IsAutoParseFile) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|是否自动分析文件(IsAutoParseFile)]的值:[$(pobjCodeTypeEN.IsAutoParseFile)], 非法，应该为布尔型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.UpdDate && undefined !== pobjCodeTypeEN.UpdDate && tzDataType.isString(pobjCodeTypeEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|修改日期(UpdDate)]的值:[$(pobjCodeTypeEN.UpdDate)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.UpdUser && undefined !== pobjCodeTypeEN.UpdUser && tzDataType.isString(pobjCodeTypeEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|修改者(UpdUser)]的值:[$(pobjCodeTypeEN.UpdUser)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
if (null !== pobjCodeTypeEN.Memo && undefined !== pobjCodeTypeEN.Memo && tzDataType.isString(pobjCodeTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[代码类型(CodeType)|说明(Memo)]的值:[$(pobjCodeTypeEN.Memo)], 非法，应该为字符型!(clsCodeTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjCodeTypeEN.CodeTypeId 
 || null !== pobjCodeTypeEN.CodeTypeId && pobjCodeTypeEN.CodeTypeId.toString()  ===  ""
 || null !== pobjCodeTypeEN.CodeTypeId && pobjCodeTypeEN.CodeTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[代码类型|代码类型Id]不能为空(NULL)!(clsCodeTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjCodeTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501025000
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsCodeTypeBL.GetJSONStrByObj  = function(pobjCodeTypeEN)
{
pobjCodeTypeEN.sf_UpdFldSetStr = pobjCodeTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjCodeTypeEN);
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
 /// 日期:20200501025000
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsCodeTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrCodeTypeObjLst = new Array();
if (strJSON === "")
{
return arrCodeTypeObjLst;
}
try
{
arrCodeTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrCodeTypeObjLst;
}
return arrCodeTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501025000
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsCodeTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjCodeTypeEN = new clsCodeTypeEN();
if (strJSON === "")
{
return pobjCodeTypeEN;
}
try
{
pobjCodeTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjCodeTypeEN;
}
return pobjCodeTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objCodeTypeENS">源简化对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
clsCodeTypeBL.CopyObjFromSimObj = function(objCodeTypeENS, objCodeTypeENT) 
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SQLDSTypeId = objCodeTypeENS.SQLDSTypeId; //数据源类型
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //序号
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改者
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
clsCodeTypeBL.CopyObjTo = function(objCodeTypeENS , objCodeTypeENT ) 
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SQLDSTypeId = objCodeTypeENS.SQLDSTypeId; //数据源类型
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //序号
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改者
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //说明
objCodeTypeENT.sf_UpdFldSetStr = objCodeTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
clsCodeTypeBL.CopyObjToSimObj = function(objCodeTypeENS , objCodeTypeENT ) 
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SQLDSTypeId = objCodeTypeENS.SQLDSTypeId; //数据源类型
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //序号
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改者
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //说明
objCodeTypeENT.sf_UpdFldSetStr = objCodeTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objCodeTypeENT.sf_FldComparisonOp = objCodeTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objCodeTypeENS">源简化对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
clsCodeTypeBL.CopyObjFromSimObj4Upd = function(objCodeTypeENS, objCodeTypeENT )
 {
   var strsf_UpdFldSetStr = objCodeTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsCodeTypeEN.con_CodeTypeId)  >= 0)
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_CodeTypeName)  >= 0)
{
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_CodeTypeSimName)  >= 0)
{
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_CodeTypeENName)  >= 0)
{
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_GroupName)  >= 0)
{
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_ProgLangTypeId)  >= 0)
{
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_RegionTypeId)  >= 0)
{
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_Prefix)  >= 0)
{
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_DependsOn)  >= 0)
{
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_FrontOrBack)  >= 0)
{
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_SQLDSTypeId)  >= 0)
{
objCodeTypeENT.SQLDSTypeId = objCodeTypeENS.SQLDSTypeId; //数据源类型
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_ClassNameFormat)  >= 0)
{
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_FileNameFormat)  >= 0)
{
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_ClassNamePattern)  >= 0)
{
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsCSharp)  >= 0)
{
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsJava)  >= 0)
{
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsJavaScript)  >= 0)
{
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsTypeScript)  >= 0)
{
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsSilverLight)  >= 0)
{
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsSwift)  >= 0)
{
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsVB)  >= 0)
{
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsTableFldConst)  >= 0)
{
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsPubApp4WinWeb)  >= 0)
{
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsWeb)  >= 0)
{
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsAspMvc)  >= 0)
{
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsWebSrvAccess)  >= 0)
{
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsWin)  >= 0)
{
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsMobileApp)  >= 0)
{
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsExtend)  >= 0)
{
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_OrderNum)  >= 0)
{
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //序号
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_WinOrWeb)  >= 0)
{
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsDirByTabName)  >= 0)
{
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsDefaultOverride)  >= 0)
{
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_InUse)  >= 0)
{
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_IsAutoParseFile)  >= 0)
{
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_UpdDate)  >= 0)
{
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_UpdUser)  >= 0)
{
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsCodeTypeEN.con_Memo)  >= 0)
{
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
clsCodeTypeBL.GetSimObjFromObj = function(objCodeTypeENS)
{
var objCodeTypeENT = new clsCodeTypeEN_Sim_js_1.clsCodeTypeEN_Sim();
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SQLDSTypeId = objCodeTypeENS.SQLDSTypeId; //数据源类型
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //序号
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改者
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //说明
objCodeTypeENT.sf_UpdFldSetStr = objCodeTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objCodeTypeENT.sf_FldComparisonOp = objCodeTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objCodeTypeENT;
}
return clsCodeTypeBL;
}());
exports.clsCodeTypeBL = clsCodeTypeBL;
});