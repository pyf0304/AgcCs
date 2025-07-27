
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFrontAndBack4AppTypeBL
 表名:vFrontAndBack4AppType(00050424)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:56
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:生成代码
 模块英文名:GeneCode
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
define(["require", "exports", "jquery", "../../L0_Entity/GeneCode/clsvFrontAndBack4AppTypeEN.js","../../L0_Entity/GeneCode/clsvFrontAndBack4AppTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvFrontAndBack4AppTypeEN_js_1 = require("../../L0_Entity/GeneCode/clsvFrontAndBack4AppTypeEN.js");
var clsvFrontAndBack4AppTypeEN_Sim_js_1 = require("../../L0_Entity/GeneCode/clsvFrontAndBack4AppTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v应用类型的前后台关系(vFrontAndBack4AppType)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvFrontAndBack4AppTypeBL = /** @class */ (function () {
function clsvFrontAndBack4AppTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvFrontAndBack4AppTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024956
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvFrontAndBack4AppTypeBL.GetJSONStrByObj  = function(pobjvFrontAndBack4AppTypeEN)
{
pobjvFrontAndBack4AppTypeEN.sf_UpdFldSetStr = pobjvFrontAndBack4AppTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvFrontAndBack4AppTypeEN);
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
 /// 日期:20200501024956
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvFrontAndBack4AppTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvFrontAndBack4AppTypeObjLst = new Array();
if (strJSON === "")
{
return arrvFrontAndBack4AppTypeObjLst;
}
try
{
arrvFrontAndBack4AppTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvFrontAndBack4AppTypeObjLst;
}
return arrvFrontAndBack4AppTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024956
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvFrontAndBack4AppTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
if (strJSON === "")
{
return pobjvFrontAndBack4AppTypeEN;
}
try
{
pobjvFrontAndBack4AppTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvFrontAndBack4AppTypeEN;
}
return pobjvFrontAndBack4AppTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objvFrontAndBack4AppTypeENT">目标对象</param>
clsvFrontAndBack4AppTypeBL.CopyObjToSimObj = function(objvFrontAndBack4AppTypeENS , objvFrontAndBack4AppTypeENT ) 
{
objvFrontAndBack4AppTypeENT.mId = objvFrontAndBack4AppTypeENS.mId; //mId
objvFrontAndBack4AppTypeENT.OrderNum = objvFrontAndBack4AppTypeENS.OrderNum; //序号
objvFrontAndBack4AppTypeENT.AppTypeId4Front = objvFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objvFrontAndBack4AppTypeENT.ApplTypeName4Front = objvFrontAndBack4AppTypeENS.ApplTypeName4Front; //ApplTypeName4Front
objvFrontAndBack4AppTypeENT.IsVisible = objvFrontAndBack4AppTypeENS.IsVisible; //是否显示
objvFrontAndBack4AppTypeENT.AppTypeId4Back = objvFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objvFrontAndBack4AppTypeENT.ApplTypeName4Back = objvFrontAndBack4AppTypeENS.ApplTypeName4Back; //ApplTypeName4Back
objvFrontAndBack4AppTypeENT.UpdDate = objvFrontAndBack4AppTypeENS.UpdDate; //修改日期
objvFrontAndBack4AppTypeENT.UpdUser = objvFrontAndBack4AppTypeENS.UpdUser; //修改者
objvFrontAndBack4AppTypeENT.Memo = objvFrontAndBack4AppTypeENS.Memo; //说明
objvFrontAndBack4AppTypeENT.sf_UpdFldSetStr = objvFrontAndBack4AppTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvFrontAndBack4AppTypeENT.sf_FldComparisonOp = objvFrontAndBack4AppTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objvFrontAndBack4AppTypeENT">目标对象</param>
clsvFrontAndBack4AppTypeBL.GetSimObjFromObj = function(objvFrontAndBack4AppTypeENS)
{
var objvFrontAndBack4AppTypeENT = new clsvFrontAndBack4AppTypeEN_Sim_js_1.clsvFrontAndBack4AppTypeEN_Sim();
objvFrontAndBack4AppTypeENT.mId = objvFrontAndBack4AppTypeENS.mId; //mId
objvFrontAndBack4AppTypeENT.OrderNum = objvFrontAndBack4AppTypeENS.OrderNum; //序号
objvFrontAndBack4AppTypeENT.AppTypeId4Front = objvFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objvFrontAndBack4AppTypeENT.ApplTypeName4Front = objvFrontAndBack4AppTypeENS.ApplTypeName4Front; //ApplTypeName4Front
objvFrontAndBack4AppTypeENT.IsVisible = objvFrontAndBack4AppTypeENS.IsVisible; //是否显示
objvFrontAndBack4AppTypeENT.AppTypeId4Back = objvFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objvFrontAndBack4AppTypeENT.ApplTypeName4Back = objvFrontAndBack4AppTypeENS.ApplTypeName4Back; //ApplTypeName4Back
objvFrontAndBack4AppTypeENT.UpdDate = objvFrontAndBack4AppTypeENS.UpdDate; //修改日期
objvFrontAndBack4AppTypeENT.UpdUser = objvFrontAndBack4AppTypeENS.UpdUser; //修改者
objvFrontAndBack4AppTypeENT.Memo = objvFrontAndBack4AppTypeENS.Memo; //说明
objvFrontAndBack4AppTypeENT.sf_UpdFldSetStr = objvFrontAndBack4AppTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvFrontAndBack4AppTypeENT.sf_FldComparisonOp = objvFrontAndBack4AppTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvFrontAndBack4AppTypeENT;
}
return clsvFrontAndBack4AppTypeBL;
}());
exports.clsvFrontAndBack4AppTypeBL = clsvFrontAndBack4AppTypeBL;
});