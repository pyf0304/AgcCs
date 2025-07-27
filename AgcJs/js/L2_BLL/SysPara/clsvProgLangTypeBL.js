
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProgLangTypeBL
 表名:vProgLangType(00050405)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:14
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsvProgLangTypeEN.js","../../L0_Entity/SysPara/clsvProgLangTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvProgLangTypeEN_js_1 = require("../../L0_Entity/SysPara/clsvProgLangTypeEN.js");
var clsvProgLangTypeEN_Sim_js_1 = require("../../L0_Entity/SysPara/clsvProgLangTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v编程语言类型(vProgLangType)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvProgLangTypeBL = /** @class */ (function () {
function clsvProgLangTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvProgLangTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200430120614
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvProgLangTypeBL.GetJSONStrByObj  = function(pobjvProgLangTypeEN)
{
pobjvProgLangTypeEN.sf_UpdFldSetStr = pobjvProgLangTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvProgLangTypeEN);
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
 /// 日期:20200430120614
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvProgLangTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvProgLangTypeObjLst = new Array();
if (strJSON === "")
{
return arrvProgLangTypeObjLst;
}
try
{
arrvProgLangTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvProgLangTypeObjLst;
}
return arrvProgLangTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200430120614
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvProgLangTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvProgLangTypeEN = new clsvProgLangTypeEN();
if (strJSON === "")
{
return pobjvProgLangTypeEN;
}
try
{
pobjvProgLangTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvProgLangTypeEN;
}
return pobjvProgLangTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvProgLangTypeENS">源对象</param>
 /// <param name = "objvProgLangTypeENT">目标对象</param>
clsvProgLangTypeBL.CopyObjToSimObj = function(objvProgLangTypeENS , objvProgLangTypeENT ) 
{
objvProgLangTypeENT.ProgLangTypeId = objvProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objvProgLangTypeENT.ProgLangTypeName = objvProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objvProgLangTypeENT.ProgLangTypeENName = objvProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvProgLangTypeENT.CharEncodingId = objvProgLangTypeENS.CharEncodingId; //字符编码
objvProgLangTypeENT.CharEncodingName = objvProgLangTypeENS.CharEncodingName; //字符编码名称
objvProgLangTypeENT.IsVisible = objvProgLangTypeENS.IsVisible; //是否显示
objvProgLangTypeENT.OrderNum = objvProgLangTypeENS.OrderNum; //序号
objvProgLangTypeENT.UpdDate = objvProgLangTypeENS.UpdDate; //修改日期
objvProgLangTypeENT.UpdUserId = objvProgLangTypeENS.UpdUserId; //修改用户Id
objvProgLangTypeENT.Memo = objvProgLangTypeENS.Memo; //说明
objvProgLangTypeENT.sf_UpdFldSetStr = objvProgLangTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvProgLangTypeENT.sf_FldComparisonOp = objvProgLangTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvProgLangTypeENS">源对象</param>
 /// <param name = "objvProgLangTypeENT">目标对象</param>
clsvProgLangTypeBL.GetSimObjFromObj = function(objvProgLangTypeENS)
{
var objvProgLangTypeENT = new clsvProgLangTypeEN_Sim_js_1.clsvProgLangTypeEN_Sim();
objvProgLangTypeENT.ProgLangTypeId = objvProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objvProgLangTypeENT.ProgLangTypeName = objvProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objvProgLangTypeENT.ProgLangTypeENName = objvProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvProgLangTypeENT.CharEncodingId = objvProgLangTypeENS.CharEncodingId; //字符编码
objvProgLangTypeENT.CharEncodingName = objvProgLangTypeENS.CharEncodingName; //字符编码名称
objvProgLangTypeENT.IsVisible = objvProgLangTypeENS.IsVisible; //是否显示
objvProgLangTypeENT.OrderNum = objvProgLangTypeENS.OrderNum; //序号
objvProgLangTypeENT.UpdDate = objvProgLangTypeENS.UpdDate; //修改日期
objvProgLangTypeENT.UpdUserId = objvProgLangTypeENS.UpdUserId; //修改用户Id
objvProgLangTypeENT.Memo = objvProgLangTypeENS.Memo; //说明
objvProgLangTypeENT.sf_UpdFldSetStr = objvProgLangTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvProgLangTypeENT.sf_FldComparisonOp = objvProgLangTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvProgLangTypeENT;
}
return clsvProgLangTypeBL;
}());
exports.clsvProgLangTypeBL = clsvProgLangTypeBL;
});