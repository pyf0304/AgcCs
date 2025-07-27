
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeTypeBL
 表名:vCodeType(00050410)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:50:01
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsvCodeTypeEN.js","../../L0_Entity/SysPara/clsvCodeTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvCodeTypeEN_js_1 = require("../../L0_Entity/SysPara/clsvCodeTypeEN.js");
var clsvCodeTypeEN_Sim_js_1 = require("../../L0_Entity/SysPara/clsvCodeTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v代码类型(vCodeType)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvCodeTypeBL = /** @class */ (function () {
function clsvCodeTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvCodeTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501025001
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvCodeTypeBL.GetJSONStrByObj  = function(pobjvCodeTypeEN)
{
pobjvCodeTypeEN.sf_UpdFldSetStr = pobjvCodeTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvCodeTypeEN);
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
 /// 日期:20200501025001
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvCodeTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvCodeTypeObjLst = new Array();
if (strJSON === "")
{
return arrvCodeTypeObjLst;
}
try
{
arrvCodeTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvCodeTypeObjLst;
}
return arrvCodeTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501025001
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvCodeTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvCodeTypeEN = new clsvCodeTypeEN();
if (strJSON === "")
{
return pobjvCodeTypeEN;
}
try
{
pobjvCodeTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvCodeTypeEN;
}
return pobjvCodeTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvCodeTypeENS">源对象</param>
 /// <param name = "objvCodeTypeENT">目标对象</param>
clsvCodeTypeBL.CopyObjToSimObj = function(objvCodeTypeENS , objvCodeTypeENT ) 
{
objvCodeTypeENT.CodeTypeId = objvCodeTypeENS.CodeTypeId; //代码类型Id
objvCodeTypeENT.CodeTypeName = objvCodeTypeENS.CodeTypeName; //代码类型名
objvCodeTypeENT.CodeTypeSimName = objvCodeTypeENS.CodeTypeSimName; //简称
objvCodeTypeENT.CodeTypeENName = objvCodeTypeENS.CodeTypeENName; //代码类型英文名
objvCodeTypeENT.GroupName = objvCodeTypeENS.GroupName; //组名
objvCodeTypeENT.ProgLangTypeId = objvCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objvCodeTypeENT.ProgLangTypeName = objvCodeTypeENS.ProgLangTypeName; //编程语言类型名
objvCodeTypeENT.ProgLangTypeSimName = objvCodeTypeENS.ProgLangTypeSimName; //编程语言类型简称
objvCodeTypeENT.RegionTypeId = objvCodeTypeENS.RegionTypeId; //区域类型Id
objvCodeTypeENT.RegionTypeName = objvCodeTypeENS.RegionTypeName; //区域类型名称
objvCodeTypeENT.Prefix = objvCodeTypeENS.Prefix; //前缀
objvCodeTypeENT.DependsOn = objvCodeTypeENS.DependsOn; //依赖于
objvCodeTypeENT.FrontOrBack = objvCodeTypeENS.FrontOrBack; //前台Or后台
objvCodeTypeENT.SQLDSTypeId = objvCodeTypeENS.SQLDSTypeId; //数据源类型
objvCodeTypeENT.SqlDsTypeName = objvCodeTypeENS.SqlDsTypeName; //Sql数据源名
objvCodeTypeENT.ClassNameFormat = objvCodeTypeENS.ClassNameFormat; //类名格式
objvCodeTypeENT.IsCSharp = objvCodeTypeENS.IsCSharp; //是否CSharp语言
objvCodeTypeENT.IsJava = objvCodeTypeENS.IsJava; //是否Java语言
objvCodeTypeENT.IsJavaScript = objvCodeTypeENS.IsJavaScript; //是否JavaScript语言
objvCodeTypeENT.IsTypeScript = objvCodeTypeENS.IsTypeScript; //是否TypeScript语言
objvCodeTypeENT.IsSilverLight = objvCodeTypeENS.IsSilverLight; //是否SilverLight语言
objvCodeTypeENT.IsSwift = objvCodeTypeENS.IsSwift; //是否Swift语言
objvCodeTypeENT.IsVB = objvCodeTypeENS.IsVB; //IsVB语言
objvCodeTypeENT.IsTableFldConst = objvCodeTypeENS.IsTableFldConst; //IsTableFldConst
objvCodeTypeENT.IsPubApp4WinWeb = objvCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objvCodeTypeENT.IsWeb = objvCodeTypeENS.IsWeb; //是否Web应用
objvCodeTypeENT.IsAspMvc = objvCodeTypeENS.IsAspMvc; //是否AspMvc
objvCodeTypeENT.IsWebSrvAccess = objvCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objvCodeTypeENT.IsWin = objvCodeTypeENS.IsWin; //是否Win应用
objvCodeTypeENT.IsMobileApp = objvCodeTypeENS.IsMobileApp; //是否移动终端应用
objvCodeTypeENT.OrderNum = objvCodeTypeENS.OrderNum; //序号
objvCodeTypeENT.WinOrWeb = objvCodeTypeENS.WinOrWeb; //WinOrWeb
objvCodeTypeENT.IsDirByTabName = objvCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objvCodeTypeENT.InUse = objvCodeTypeENS.InUse; //是否在用
objvCodeTypeENT.IsDefaultOverride = objvCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objvCodeTypeENT.UpdDate = objvCodeTypeENS.UpdDate; //修改日期
objvCodeTypeENT.UpdUser = objvCodeTypeENS.UpdUser; //修改者
objvCodeTypeENT.Memo = objvCodeTypeENS.Memo; //说明
objvCodeTypeENT.FuncCount = objvCodeTypeENS.FuncCount; //函数数目
objvCodeTypeENT.AppCount = objvCodeTypeENS.AppCount; //应用数
objvCodeTypeENT.sf_UpdFldSetStr = objvCodeTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvCodeTypeENT.sf_FldComparisonOp = objvCodeTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvCodeTypeENS">源对象</param>
 /// <param name = "objvCodeTypeENT">目标对象</param>
clsvCodeTypeBL.GetSimObjFromObj = function(objvCodeTypeENS)
{
var objvCodeTypeENT = new clsvCodeTypeEN_Sim_js_1.clsvCodeTypeEN_Sim();
objvCodeTypeENT.CodeTypeId = objvCodeTypeENS.CodeTypeId; //代码类型Id
objvCodeTypeENT.CodeTypeName = objvCodeTypeENS.CodeTypeName; //代码类型名
objvCodeTypeENT.CodeTypeSimName = objvCodeTypeENS.CodeTypeSimName; //简称
objvCodeTypeENT.CodeTypeENName = objvCodeTypeENS.CodeTypeENName; //代码类型英文名
objvCodeTypeENT.GroupName = objvCodeTypeENS.GroupName; //组名
objvCodeTypeENT.ProgLangTypeId = objvCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objvCodeTypeENT.ProgLangTypeName = objvCodeTypeENS.ProgLangTypeName; //编程语言类型名
objvCodeTypeENT.ProgLangTypeSimName = objvCodeTypeENS.ProgLangTypeSimName; //编程语言类型简称
objvCodeTypeENT.RegionTypeId = objvCodeTypeENS.RegionTypeId; //区域类型Id
objvCodeTypeENT.RegionTypeName = objvCodeTypeENS.RegionTypeName; //区域类型名称
objvCodeTypeENT.Prefix = objvCodeTypeENS.Prefix; //前缀
objvCodeTypeENT.DependsOn = objvCodeTypeENS.DependsOn; //依赖于
objvCodeTypeENT.FrontOrBack = objvCodeTypeENS.FrontOrBack; //前台Or后台
objvCodeTypeENT.SQLDSTypeId = objvCodeTypeENS.SQLDSTypeId; //数据源类型
objvCodeTypeENT.SqlDsTypeName = objvCodeTypeENS.SqlDsTypeName; //Sql数据源名
objvCodeTypeENT.ClassNameFormat = objvCodeTypeENS.ClassNameFormat; //类名格式
objvCodeTypeENT.IsCSharp = objvCodeTypeENS.IsCSharp; //是否CSharp语言
objvCodeTypeENT.IsJava = objvCodeTypeENS.IsJava; //是否Java语言
objvCodeTypeENT.IsJavaScript = objvCodeTypeENS.IsJavaScript; //是否JavaScript语言
objvCodeTypeENT.IsTypeScript = objvCodeTypeENS.IsTypeScript; //是否TypeScript语言
objvCodeTypeENT.IsSilverLight = objvCodeTypeENS.IsSilverLight; //是否SilverLight语言
objvCodeTypeENT.IsSwift = objvCodeTypeENS.IsSwift; //是否Swift语言
objvCodeTypeENT.IsVB = objvCodeTypeENS.IsVB; //IsVB语言
objvCodeTypeENT.IsTableFldConst = objvCodeTypeENS.IsTableFldConst; //IsTableFldConst
objvCodeTypeENT.IsPubApp4WinWeb = objvCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objvCodeTypeENT.IsWeb = objvCodeTypeENS.IsWeb; //是否Web应用
objvCodeTypeENT.IsAspMvc = objvCodeTypeENS.IsAspMvc; //是否AspMvc
objvCodeTypeENT.IsWebSrvAccess = objvCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objvCodeTypeENT.IsWin = objvCodeTypeENS.IsWin; //是否Win应用
objvCodeTypeENT.IsMobileApp = objvCodeTypeENS.IsMobileApp; //是否移动终端应用
objvCodeTypeENT.OrderNum = objvCodeTypeENS.OrderNum; //序号
objvCodeTypeENT.WinOrWeb = objvCodeTypeENS.WinOrWeb; //WinOrWeb
objvCodeTypeENT.IsDirByTabName = objvCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objvCodeTypeENT.InUse = objvCodeTypeENS.InUse; //是否在用
objvCodeTypeENT.IsDefaultOverride = objvCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objvCodeTypeENT.UpdDate = objvCodeTypeENS.UpdDate; //修改日期
objvCodeTypeENT.UpdUser = objvCodeTypeENS.UpdUser; //修改者
objvCodeTypeENT.Memo = objvCodeTypeENS.Memo; //说明
objvCodeTypeENT.FuncCount = objvCodeTypeENS.FuncCount; //函数数目
objvCodeTypeENT.AppCount = objvCodeTypeENS.AppCount; //应用数
objvCodeTypeENT.sf_UpdFldSetStr = objvCodeTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvCodeTypeENT.sf_FldComparisonOp = objvCodeTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvCodeTypeENT;
}
return clsvCodeTypeBL;
}());
exports.clsvCodeTypeBL = clsvCodeTypeBL;
});