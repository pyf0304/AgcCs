
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewTypeCodeTabBL
 表名:vViewTypeCodeTab(00050133)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 00:36:53
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsvViewTypeCodeTabEN.js","../../L0_Entity/PrjInterface/clsvViewTypeCodeTabEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvViewTypeCodeTabEN_js_1 = require("../../L0_Entity/PrjInterface/clsvViewTypeCodeTabEN.js");
var clsvViewTypeCodeTabEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsvViewTypeCodeTabEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v界面类型码(vViewTypeCodeTab)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvViewTypeCodeTabBL = /** @class */ (function () {
function clsvViewTypeCodeTabBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvViewTypeCodeTabObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501003653
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewTypeCodeTabBL.GetJSONStrByObj  = function(pobjvViewTypeCodeTabEN)
{
pobjvViewTypeCodeTabEN.sf_UpdFldSetStr = pobjvViewTypeCodeTabEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvViewTypeCodeTabEN);
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
 /// 日期:20200501003653
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvViewTypeCodeTabBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvViewTypeCodeTabObjLst = new Array();
if (strJSON === "")
{
return arrvViewTypeCodeTabObjLst;
}
try
{
arrvViewTypeCodeTabObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvViewTypeCodeTabObjLst;
}
return arrvViewTypeCodeTabObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501003653
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewTypeCodeTabBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvViewTypeCodeTabEN = new clsvViewTypeCodeTabEN();
if (strJSON === "")
{
return pobjvViewTypeCodeTabEN;
}
try
{
pobjvViewTypeCodeTabEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvViewTypeCodeTabEN;
}
return pobjvViewTypeCodeTabEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabENS">源对象</param>
 /// <param name = "objvViewTypeCodeTabENT">目标对象</param>
clsvViewTypeCodeTabBL.CopyObjToSimObj = function(objvViewTypeCodeTabENS , objvViewTypeCodeTabENT ) 
{
objvViewTypeCodeTabENT.ViewTypeCode = objvViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objvViewTypeCodeTabENT.ViewTypeName = objvViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objvViewTypeCodeTabENT.ViewTypeENName = objvViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objvViewTypeCodeTabENT.IsWinApp = objvViewTypeCodeTabENS.IsWinApp; //IsWinApp
objvViewTypeCodeTabENT.IsMobileApp = objvViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objvViewTypeCodeTabENT.IsWebApp = objvViewTypeCodeTabENS.IsWebApp; //IsWebApp
objvViewTypeCodeTabENT.ViewFunction = objvViewTypeCodeTabENS.ViewFunction; //界面功能
objvViewTypeCodeTabENT.OptProcess = objvViewTypeCodeTabENS.OptProcess; //操作流程
objvViewTypeCodeTabENT.ViewDetail = objvViewTypeCodeTabENS.ViewDetail; //界面说明
objvViewTypeCodeTabENT.ApplicationTypeId = objvViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objvViewTypeCodeTabENT.ApplicationTypeName = objvViewTypeCodeTabENS.ApplicationTypeName; //应用程序类型名称
objvViewTypeCodeTabENT.IsHaveAdd = objvViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objvViewTypeCodeTabENT.IsHaveUpdate = objvViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objvViewTypeCodeTabENT.IsHaveDel = objvViewTypeCodeTabENS.IsHaveDel; //是否有删除
objvViewTypeCodeTabENT.IsHaveQuery = objvViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objvViewTypeCodeTabENT.IsHaveExcelExport = objvViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objvViewTypeCodeTabENT.IsHaveSetExportExcel = objvViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objvViewTypeCodeTabENT.IsHaveDetail = objvViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objvViewTypeCodeTabENT.IsHaveExeAdd = objvViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objvViewTypeCodeTabENT.IsHaveExeUpdate = objvViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objvViewTypeCodeTabENT.IsHaveMainView = objvViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objvViewTypeCodeTabENT.IsHaveSubView = objvViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objvViewTypeCodeTabENT.OrderNum = objvViewTypeCodeTabENS.OrderNum; //序号
objvViewTypeCodeTabENT.IsUsed = objvViewTypeCodeTabENS.IsUsed; //IsUsed
objvViewTypeCodeTabENT.sf_UpdFldSetStr = objvViewTypeCodeTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewTypeCodeTabENT.sf_FldComparisonOp = objvViewTypeCodeTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvViewTypeCodeTabENS">源对象</param>
 /// <param name = "objvViewTypeCodeTabENT">目标对象</param>
clsvViewTypeCodeTabBL.GetSimObjFromObj = function(objvViewTypeCodeTabENS)
{
var objvViewTypeCodeTabENT = new clsvViewTypeCodeTabEN_Sim_js_1.clsvViewTypeCodeTabEN_Sim();
objvViewTypeCodeTabENT.ViewTypeCode = objvViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objvViewTypeCodeTabENT.ViewTypeName = objvViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objvViewTypeCodeTabENT.ViewTypeENName = objvViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objvViewTypeCodeTabENT.IsWinApp = objvViewTypeCodeTabENS.IsWinApp; //IsWinApp
objvViewTypeCodeTabENT.IsMobileApp = objvViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objvViewTypeCodeTabENT.IsWebApp = objvViewTypeCodeTabENS.IsWebApp; //IsWebApp
objvViewTypeCodeTabENT.ViewFunction = objvViewTypeCodeTabENS.ViewFunction; //界面功能
objvViewTypeCodeTabENT.OptProcess = objvViewTypeCodeTabENS.OptProcess; //操作流程
objvViewTypeCodeTabENT.ViewDetail = objvViewTypeCodeTabENS.ViewDetail; //界面说明
objvViewTypeCodeTabENT.ApplicationTypeId = objvViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objvViewTypeCodeTabENT.ApplicationTypeName = objvViewTypeCodeTabENS.ApplicationTypeName; //应用程序类型名称
objvViewTypeCodeTabENT.IsHaveAdd = objvViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objvViewTypeCodeTabENT.IsHaveUpdate = objvViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objvViewTypeCodeTabENT.IsHaveDel = objvViewTypeCodeTabENS.IsHaveDel; //是否有删除
objvViewTypeCodeTabENT.IsHaveQuery = objvViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objvViewTypeCodeTabENT.IsHaveExcelExport = objvViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objvViewTypeCodeTabENT.IsHaveSetExportExcel = objvViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objvViewTypeCodeTabENT.IsHaveDetail = objvViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objvViewTypeCodeTabENT.IsHaveExeAdd = objvViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objvViewTypeCodeTabENT.IsHaveExeUpdate = objvViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objvViewTypeCodeTabENT.IsHaveMainView = objvViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objvViewTypeCodeTabENT.IsHaveSubView = objvViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objvViewTypeCodeTabENT.OrderNum = objvViewTypeCodeTabENS.OrderNum; //序号
objvViewTypeCodeTabENT.IsUsed = objvViewTypeCodeTabENS.IsUsed; //IsUsed
objvViewTypeCodeTabENT.sf_UpdFldSetStr = objvViewTypeCodeTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewTypeCodeTabENT.sf_FldComparisonOp = objvViewTypeCodeTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvViewTypeCodeTabENT;
}
return clsvViewTypeCodeTabBL;
}());
exports.clsvViewTypeCodeTabBL = clsvViewTypeCodeTabBL;
});