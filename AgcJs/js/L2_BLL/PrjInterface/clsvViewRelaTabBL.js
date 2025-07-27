
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRelaTabBL
 表名:vViewRelaTab(00050476)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:28
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsvViewRelaTabEN.js","../../L0_Entity/PrjInterface/clsvViewRelaTabEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvViewRelaTabEN_js_1 = require("../../L0_Entity/PrjInterface/clsvViewRelaTabEN.js");
var clsvViewRelaTabEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsvViewRelaTabEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v界面相关表(vViewRelaTab)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvViewRelaTabBL = /** @class */ (function () {
function clsvViewRelaTabBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvViewRelaTabObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024928
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewRelaTabBL.GetJSONStrByObj  = function(pobjvViewRelaTabEN)
{
pobjvViewRelaTabEN.sf_UpdFldSetStr = pobjvViewRelaTabEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvViewRelaTabEN);
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
 /// 日期:20200501024928
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvViewRelaTabBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvViewRelaTabObjLst = new Array();
if (strJSON === "")
{
return arrvViewRelaTabObjLst;
}
try
{
arrvViewRelaTabObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvViewRelaTabObjLst;
}
return arrvViewRelaTabObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024928
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewRelaTabBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvViewRelaTabEN = new clsvViewRelaTabEN();
if (strJSON === "")
{
return pobjvViewRelaTabEN;
}
try
{
pobjvViewRelaTabEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvViewRelaTabEN;
}
return pobjvViewRelaTabEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvViewRelaTabENS">源对象</param>
 /// <param name = "objvViewRelaTabENT">目标对象</param>
clsvViewRelaTabBL.CopyObjToSimObj = function(objvViewRelaTabENS , objvViewRelaTabENT ) 
{
objvViewRelaTabENT.mId = objvViewRelaTabENS.mId; //mId
objvViewRelaTabENT.ViewId = objvViewRelaTabENS.ViewId; //界面Id
objvViewRelaTabENT.ViewName = objvViewRelaTabENS.ViewName; //界面名称
objvViewRelaTabENT.ViewCnName = objvViewRelaTabENS.ViewCnName; //视图中文名
objvViewRelaTabENT.RegionId = objvViewRelaTabENS.RegionId; //区域Id
objvViewRelaTabENT.RegionName = objvViewRelaTabENS.RegionName; //区域名称
objvViewRelaTabENT.RegionTypeId = objvViewRelaTabENS.RegionTypeId; //区域类型Id
objvViewRelaTabENT.RegionTypeName = objvViewRelaTabENS.RegionTypeName; //区域类型名称
objvViewRelaTabENT.INOUTTypeId = objvViewRelaTabENS.INOUTTypeId; //INOUT类型ID
objvViewRelaTabENT.INOUTTypeName = objvViewRelaTabENS.INOUTTypeName; //INOUT类型名称
objvViewRelaTabENT.ViewTabTypeId = objvViewRelaTabENS.ViewTabTypeId; //界面表类型码
objvViewRelaTabENT.ViewTabTypeName = objvViewRelaTabENS.ViewTabTypeName; //ViewTabTypeName
objvViewRelaTabENT.TabId = objvViewRelaTabENS.TabId; //表ID
objvViewRelaTabENT.TabName = objvViewRelaTabENS.TabName; //表名
objvViewRelaTabENT.TabFunction = objvViewRelaTabENS.TabFunction; //表功能说明
objvViewRelaTabENT.UpdDate = objvViewRelaTabENS.UpdDate; //修改日期
objvViewRelaTabENT.UpdUser = objvViewRelaTabENS.UpdUser; //修改者
objvViewRelaTabENT.Memo = objvViewRelaTabENS.Memo; //说明
objvViewRelaTabENT.sf_UpdFldSetStr = objvViewRelaTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewRelaTabENT.sf_FldComparisonOp = objvViewRelaTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvViewRelaTabENS">源对象</param>
 /// <param name = "objvViewRelaTabENT">目标对象</param>
clsvViewRelaTabBL.GetSimObjFromObj = function(objvViewRelaTabENS)
{
var objvViewRelaTabENT = new clsvViewRelaTabEN_Sim_js_1.clsvViewRelaTabEN_Sim();
objvViewRelaTabENT.mId = objvViewRelaTabENS.mId; //mId
objvViewRelaTabENT.ViewId = objvViewRelaTabENS.ViewId; //界面Id
objvViewRelaTabENT.ViewName = objvViewRelaTabENS.ViewName; //界面名称
objvViewRelaTabENT.ViewCnName = objvViewRelaTabENS.ViewCnName; //视图中文名
objvViewRelaTabENT.RegionId = objvViewRelaTabENS.RegionId; //区域Id
objvViewRelaTabENT.RegionName = objvViewRelaTabENS.RegionName; //区域名称
objvViewRelaTabENT.RegionTypeId = objvViewRelaTabENS.RegionTypeId; //区域类型Id
objvViewRelaTabENT.RegionTypeName = objvViewRelaTabENS.RegionTypeName; //区域类型名称
objvViewRelaTabENT.INOUTTypeId = objvViewRelaTabENS.INOUTTypeId; //INOUT类型ID
objvViewRelaTabENT.INOUTTypeName = objvViewRelaTabENS.INOUTTypeName; //INOUT类型名称
objvViewRelaTabENT.ViewTabTypeId = objvViewRelaTabENS.ViewTabTypeId; //界面表类型码
objvViewRelaTabENT.ViewTabTypeName = objvViewRelaTabENS.ViewTabTypeName; //ViewTabTypeName
objvViewRelaTabENT.TabId = objvViewRelaTabENS.TabId; //表ID
objvViewRelaTabENT.TabName = objvViewRelaTabENS.TabName; //表名
objvViewRelaTabENT.TabFunction = objvViewRelaTabENS.TabFunction; //表功能说明
objvViewRelaTabENT.UpdDate = objvViewRelaTabENS.UpdDate; //修改日期
objvViewRelaTabENT.UpdUser = objvViewRelaTabENS.UpdUser; //修改者
objvViewRelaTabENT.Memo = objvViewRelaTabENS.Memo; //说明
objvViewRelaTabENT.sf_UpdFldSetStr = objvViewRelaTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewRelaTabENT.sf_FldComparisonOp = objvViewRelaTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvViewRelaTabENT;
}
return clsvViewRelaTabBL;
}());
exports.clsvViewRelaTabBL = clsvViewRelaTabBL;
});