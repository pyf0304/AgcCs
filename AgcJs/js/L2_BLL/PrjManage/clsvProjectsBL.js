
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProjectsBL
 表名:vProjects(00050167)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:15
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:工程管理
 模块英文名:PrjManage
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjManage/clsvProjectsEN.js","../../L0_Entity/PrjManage/clsvProjectsEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvProjectsEN_js_1 = require("../../L0_Entity/PrjManage/clsvProjectsEN.js");
var clsvProjectsEN_Sim_js_1 = require("../../L0_Entity/PrjManage/clsvProjectsEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v工程(vProjects)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvProjectsBL = /** @class */ (function () {
function clsvProjectsBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvProjectsObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200430120615
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvProjectsBL.GetJSONStrByObj  = function(pobjvProjectsEN)
{
pobjvProjectsEN.sf_UpdFldSetStr = pobjvProjectsEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvProjectsEN);
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
 /// 日期:20200430120615
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvProjectsBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvProjectsObjLst = new Array();
if (strJSON === "")
{
return arrvProjectsObjLst;
}
try
{
arrvProjectsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvProjectsObjLst;
}
return arrvProjectsObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200430120615
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvProjectsBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvProjectsEN = new clsvProjectsEN();
if (strJSON === "")
{
return pobjvProjectsEN;
}
try
{
pobjvProjectsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvProjectsEN;
}
return pobjvProjectsEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvProjectsENS">源对象</param>
 /// <param name = "objvProjectsENT">目标对象</param>
clsvProjectsBL.CopyObjToSimObj = function(objvProjectsENS , objvProjectsENT ) 
{
objvProjectsENT.PrjId = objvProjectsENS.PrjId; //工程ID
objvProjectsENT.PrjName = objvProjectsENS.PrjName; //工程名称
objvProjectsENT.PrjDomain = objvProjectsENS.PrjDomain; //域/包名
objvProjectsENT.ISOPrjName = objvProjectsENS.ISOPrjName; //ISO工程名
objvProjectsENT.JavaPackageName = objvProjectsENS.JavaPackageName; //Java包名
objvProjectsENT.IsRelaDataBase = objvProjectsENS.IsRelaDataBase; //是否关联数据库
objvProjectsENT.SoftStructureId = objvProjectsENS.SoftStructureId; //架构ID
objvProjectsENT.SoftStructureName = objvProjectsENS.SoftStructureName; //架构名称
objvProjectsENT.ApplicationTypeId = objvProjectsENS.ApplicationTypeId; //应用程序类型ID
objvProjectsENT.ApplicationTypeName = objvProjectsENS.ApplicationTypeName; //应用程序类型名称
objvProjectsENT.UseStateId = objvProjectsENS.UseStateId; //使用状态Id
objvProjectsENT.UseStateName = objvProjectsENS.UseStateName; //使用状态名称
objvProjectsENT.IsSupportMvc = objvProjectsENS.IsSupportMvc; //是否支持Mvc
objvProjectsENT.UserId = objvProjectsENS.UserId; //用户Id
objvProjectsENT.UpdDate = objvProjectsENS.UpdDate; //修改日期
objvProjectsENT.Memo = objvProjectsENS.Memo; //说明
objvProjectsENT.sf_UpdFldSetStr = objvProjectsENS.UpdFldString; //专门用于记录某字段属性是否修改
objvProjectsENT.sf_FldComparisonOp = objvProjectsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvProjectsENS">源对象</param>
 /// <param name = "objvProjectsENT">目标对象</param>
clsvProjectsBL.GetSimObjFromObj = function(objvProjectsENS)
{
var objvProjectsENT = new clsvProjectsEN_Sim_js_1.clsvProjectsEN_Sim();
objvProjectsENT.PrjId = objvProjectsENS.PrjId; //工程ID
objvProjectsENT.PrjName = objvProjectsENS.PrjName; //工程名称
objvProjectsENT.PrjDomain = objvProjectsENS.PrjDomain; //域/包名
objvProjectsENT.ISOPrjName = objvProjectsENS.ISOPrjName; //ISO工程名
objvProjectsENT.JavaPackageName = objvProjectsENS.JavaPackageName; //Java包名
objvProjectsENT.IsRelaDataBase = objvProjectsENS.IsRelaDataBase; //是否关联数据库
objvProjectsENT.SoftStructureId = objvProjectsENS.SoftStructureId; //架构ID
objvProjectsENT.SoftStructureName = objvProjectsENS.SoftStructureName; //架构名称
objvProjectsENT.ApplicationTypeId = objvProjectsENS.ApplicationTypeId; //应用程序类型ID
objvProjectsENT.ApplicationTypeName = objvProjectsENS.ApplicationTypeName; //应用程序类型名称
objvProjectsENT.UseStateId = objvProjectsENS.UseStateId; //使用状态Id
objvProjectsENT.UseStateName = objvProjectsENS.UseStateName; //使用状态名称
objvProjectsENT.IsSupportMvc = objvProjectsENS.IsSupportMvc; //是否支持Mvc
objvProjectsENT.UserId = objvProjectsENS.UserId; //用户Id
objvProjectsENT.UpdDate = objvProjectsENS.UpdDate; //修改日期
objvProjectsENT.Memo = objvProjectsENS.Memo; //说明
objvProjectsENT.sf_UpdFldSetStr = objvProjectsENS.UpdFldString; //专门用于记录某字段属性是否修改
objvProjectsENT.sf_FldComparisonOp = objvProjectsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvProjectsENT;
}
return clsvProjectsBL;
}());
exports.clsvProjectsBL = clsvProjectsBL;
});