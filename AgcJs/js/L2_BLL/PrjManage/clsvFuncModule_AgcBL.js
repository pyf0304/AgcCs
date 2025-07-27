
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModule_AgcBL
 表名:vFuncModule_Agc(00050125)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:08
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjManage/clsvFuncModule_AgcEN.js","../../L0_Entity/PrjManage/clsvFuncModule_AgcEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvFuncModule_AgcEN_js_1 = require("../../L0_Entity/PrjManage/clsvFuncModule_AgcEN.js");
var clsvFuncModule_AgcEN_Sim_js_1 = require("../../L0_Entity/PrjManage/clsvFuncModule_AgcEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v功能模块_Agc(vFuncModule_Agc)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvFuncModule_AgcBL = /** @class */ (function () {
function clsvFuncModule_AgcBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvFuncModule_AgcObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200430120608
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvFuncModule_AgcBL.GetJSONStrByObj  = function(pobjvFuncModule_AgcEN)
{
pobjvFuncModule_AgcEN.sf_UpdFldSetStr = pobjvFuncModule_AgcEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvFuncModule_AgcEN);
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
 /// 日期:20200430120608
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvFuncModule_AgcBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvFuncModule_AgcObjLst = new Array();
if (strJSON === "")
{
return arrvFuncModule_AgcObjLst;
}
try
{
arrvFuncModule_AgcObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvFuncModule_AgcObjLst;
}
return arrvFuncModule_AgcObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200430120608
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvFuncModule_AgcBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
if (strJSON === "")
{
return pobjvFuncModule_AgcEN;
}
try
{
pobjvFuncModule_AgcEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvFuncModule_AgcEN;
}
return pobjvFuncModule_AgcEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvFuncModule_AgcENS">源对象</param>
 /// <param name = "objvFuncModule_AgcENT">目标对象</param>
clsvFuncModule_AgcBL.CopyObjToSimObj = function(objvFuncModule_AgcENS , objvFuncModule_AgcENT ) 
{
objvFuncModule_AgcENT.FuncModuleAgcId = objvFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objvFuncModule_AgcENT.TabNum = objvFuncModule_AgcENS.TabNum; //TabNum
objvFuncModule_AgcENT.ViewNum = objvFuncModule_AgcENS.ViewNum; //ViewNum
objvFuncModule_AgcENT.ObjNum = objvFuncModule_AgcENS.ObjNum; //ObjNum
objvFuncModule_AgcENT.PrjViewNum = objvFuncModule_AgcENS.PrjViewNum; //PrjViewNum
objvFuncModule_AgcENT.FuncModuleName = objvFuncModule_AgcENS.FuncModuleName; //功能模块名称
objvFuncModule_AgcENT.FuncModuleEnName = objvFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objvFuncModule_AgcENT.PrjId = objvFuncModule_AgcENS.PrjId; //工程ID
objvFuncModule_AgcENT.PrjName = objvFuncModule_AgcENS.PrjName; //工程名称
objvFuncModule_AgcENT.OrderNum = objvFuncModule_AgcENS.OrderNum; //序号
objvFuncModule_AgcENT.UseStateId = objvFuncModule_AgcENS.UseStateId; //使用状态Id
objvFuncModule_AgcENT.UseStateName = objvFuncModule_AgcENS.UseStateName; //使用状态名称
objvFuncModule_AgcENT.UpdDate = objvFuncModule_AgcENS.UpdDate; //修改日期
objvFuncModule_AgcENT.Memo = objvFuncModule_AgcENS.Memo; //说明
objvFuncModule_AgcENT.UpdUser = objvFuncModule_AgcENS.UpdUser; //修改者
objvFuncModule_AgcENT.sf_UpdFldSetStr = objvFuncModule_AgcENS.UpdFldString; //专门用于记录某字段属性是否修改
objvFuncModule_AgcENT.sf_FldComparisonOp = objvFuncModule_AgcENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvFuncModule_AgcENS">源对象</param>
 /// <param name = "objvFuncModule_AgcENT">目标对象</param>
clsvFuncModule_AgcBL.GetSimObjFromObj = function(objvFuncModule_AgcENS)
{
var objvFuncModule_AgcENT = new clsvFuncModule_AgcEN_Sim_js_1.clsvFuncModule_AgcEN_Sim();
objvFuncModule_AgcENT.FuncModuleAgcId = objvFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objvFuncModule_AgcENT.TabNum = objvFuncModule_AgcENS.TabNum; //TabNum
objvFuncModule_AgcENT.ViewNum = objvFuncModule_AgcENS.ViewNum; //ViewNum
objvFuncModule_AgcENT.ObjNum = objvFuncModule_AgcENS.ObjNum; //ObjNum
objvFuncModule_AgcENT.PrjViewNum = objvFuncModule_AgcENS.PrjViewNum; //PrjViewNum
objvFuncModule_AgcENT.FuncModuleName = objvFuncModule_AgcENS.FuncModuleName; //功能模块名称
objvFuncModule_AgcENT.FuncModuleEnName = objvFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objvFuncModule_AgcENT.PrjId = objvFuncModule_AgcENS.PrjId; //工程ID
objvFuncModule_AgcENT.PrjName = objvFuncModule_AgcENS.PrjName; //工程名称
objvFuncModule_AgcENT.OrderNum = objvFuncModule_AgcENS.OrderNum; //序号
objvFuncModule_AgcENT.UseStateId = objvFuncModule_AgcENS.UseStateId; //使用状态Id
objvFuncModule_AgcENT.UseStateName = objvFuncModule_AgcENS.UseStateName; //使用状态名称
objvFuncModule_AgcENT.UpdDate = objvFuncModule_AgcENS.UpdDate; //修改日期
objvFuncModule_AgcENT.Memo = objvFuncModule_AgcENS.Memo; //说明
objvFuncModule_AgcENT.UpdUser = objvFuncModule_AgcENS.UpdUser; //修改者
objvFuncModule_AgcENT.sf_UpdFldSetStr = objvFuncModule_AgcENS.UpdFldString; //专门用于记录某字段属性是否修改
objvFuncModule_AgcENT.sf_FldComparisonOp = objvFuncModule_AgcENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvFuncModule_AgcENT;
}
return clsvFuncModule_AgcBL;
}());
exports.clsvFuncModule_AgcBL = clsvFuncModule_AgcBL;
});