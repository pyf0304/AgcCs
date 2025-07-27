
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvApplicationTypeBL
 表名:vApplicationType(00050403)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:02
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
define(["require", "exports", "jquery", "../../L0_Entity/GeneCode/clsvApplicationTypeEN.js","../../L0_Entity/GeneCode/clsvApplicationTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvApplicationTypeEN_js_1 = require("../../L0_Entity/GeneCode/clsvApplicationTypeEN.js");
var clsvApplicationTypeEN_Sim_js_1 = require("../../L0_Entity/GeneCode/clsvApplicationTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v应用程序类型(vApplicationType)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvApplicationTypeBL = /** @class */ (function () {
function clsvApplicationTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvApplicationTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200430120602
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvApplicationTypeBL.GetJSONStrByObj  = function(pobjvApplicationTypeEN)
{
pobjvApplicationTypeEN.sf_UpdFldSetStr = pobjvApplicationTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvApplicationTypeEN);
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
 /// 日期:20200430120602
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvApplicationTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvApplicationTypeObjLst = new Array();
if (strJSON === "")
{
return arrvApplicationTypeObjLst;
}
try
{
arrvApplicationTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvApplicationTypeObjLst;
}
return arrvApplicationTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200430120602
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvApplicationTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvApplicationTypeEN = new clsvApplicationTypeEN();
if (strJSON === "")
{
return pobjvApplicationTypeEN;
}
try
{
pobjvApplicationTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvApplicationTypeEN;
}
return pobjvApplicationTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvApplicationTypeENS">源对象</param>
 /// <param name = "objvApplicationTypeENT">目标对象</param>
clsvApplicationTypeBL.CopyObjToSimObj = function(objvApplicationTypeENS , objvApplicationTypeENT ) 
{
objvApplicationTypeENT.ApplicationTypeId = objvApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objvApplicationTypeENT.ApplicationTypeName = objvApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objvApplicationTypeENT.ApplicationTypeSimName = objvApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objvApplicationTypeENT.ApplicationTypeENName = objvApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objvApplicationTypeENT.ProgLangTypeId = objvApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objvApplicationTypeENT.ProgLangTypeName = objvApplicationTypeENS.ProgLangTypeName; //编程语言类型名
objvApplicationTypeENT.ProgLangTypeENName = objvApplicationTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvApplicationTypeENT.CharEncodingId = objvApplicationTypeENS.CharEncodingId; //字符编码
objvApplicationTypeENT.CharEncodingName = objvApplicationTypeENS.CharEncodingName; //字符编码名称
objvApplicationTypeENT.ProgLangTypeId2 = objvApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objvApplicationTypeENT.ProgLangTypeId3 = objvApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objvApplicationTypeENT.ProgLangTypeId4 = objvApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objvApplicationTypeENT.ProgLangTypeId5 = objvApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objvApplicationTypeENT.IsVisible = objvApplicationTypeENS.IsVisible; //是否显示
objvApplicationTypeENT.OrderNum = objvApplicationTypeENS.OrderNum; //序号
objvApplicationTypeENT.Memo = objvApplicationTypeENS.Memo; //说明
objvApplicationTypeENT.CharEncodingId2 = objvApplicationTypeENS.CharEncodingId2; //CharEncodingId2
objvApplicationTypeENT.CharEncodingId3 = objvApplicationTypeENS.CharEncodingId3; //CharEncodingId3
objvApplicationTypeENT.CharEncodingName2 = objvApplicationTypeENS.CharEncodingName2; //CharEncodingName2
objvApplicationTypeENT.CharEncodingName3 = objvApplicationTypeENS.CharEncodingName3; //CharEncodingName3
objvApplicationTypeENT.ProgLangTypeName2 = objvApplicationTypeENS.ProgLangTypeName2; //ProgLangTypeName2
objvApplicationTypeENT.ProgLangTypeName3 = objvApplicationTypeENS.ProgLangTypeName3; //ProgLangTypeName3
objvApplicationTypeENT.ProgLangTypeName5 = objvApplicationTypeENS.ProgLangTypeName5; //ProgLangTypeName5
objvApplicationTypeENT.CodeTypeCount = objvApplicationTypeENS.CodeTypeCount; //代码类型数
objvApplicationTypeENT.CharEncodingId4 = objvApplicationTypeENS.CharEncodingId4; //CharEncodingId4
objvApplicationTypeENT.CharEncodingName4 = objvApplicationTypeENS.CharEncodingName4; //CharEncodingName4
objvApplicationTypeENT.ProgLangTypeName4 = objvApplicationTypeENS.ProgLangTypeName4; //ProgLangTypeName4
objvApplicationTypeENT.CharEncodingId5 = objvApplicationTypeENS.CharEncodingId5; //CharEncodingId5
objvApplicationTypeENT.CharEncodingName5 = objvApplicationTypeENS.CharEncodingName5; //CharEncodingName5
objvApplicationTypeENT.sf_UpdFldSetStr = objvApplicationTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvApplicationTypeENT.sf_FldComparisonOp = objvApplicationTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvApplicationTypeENS">源对象</param>
 /// <param name = "objvApplicationTypeENT">目标对象</param>
clsvApplicationTypeBL.GetSimObjFromObj = function(objvApplicationTypeENS)
{
var objvApplicationTypeENT = new clsvApplicationTypeEN_Sim_js_1.clsvApplicationTypeEN_Sim();
objvApplicationTypeENT.ApplicationTypeId = objvApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objvApplicationTypeENT.ApplicationTypeName = objvApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objvApplicationTypeENT.ApplicationTypeSimName = objvApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objvApplicationTypeENT.ApplicationTypeENName = objvApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objvApplicationTypeENT.ProgLangTypeId = objvApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objvApplicationTypeENT.ProgLangTypeName = objvApplicationTypeENS.ProgLangTypeName; //编程语言类型名
objvApplicationTypeENT.ProgLangTypeENName = objvApplicationTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvApplicationTypeENT.CharEncodingId = objvApplicationTypeENS.CharEncodingId; //字符编码
objvApplicationTypeENT.CharEncodingName = objvApplicationTypeENS.CharEncodingName; //字符编码名称
objvApplicationTypeENT.ProgLangTypeId2 = objvApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objvApplicationTypeENT.ProgLangTypeId3 = objvApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objvApplicationTypeENT.ProgLangTypeId4 = objvApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objvApplicationTypeENT.ProgLangTypeId5 = objvApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objvApplicationTypeENT.IsVisible = objvApplicationTypeENS.IsVisible; //是否显示
objvApplicationTypeENT.OrderNum = objvApplicationTypeENS.OrderNum; //序号
objvApplicationTypeENT.Memo = objvApplicationTypeENS.Memo; //说明
objvApplicationTypeENT.CharEncodingId2 = objvApplicationTypeENS.CharEncodingId2; //CharEncodingId2
objvApplicationTypeENT.CharEncodingId3 = objvApplicationTypeENS.CharEncodingId3; //CharEncodingId3
objvApplicationTypeENT.CharEncodingName2 = objvApplicationTypeENS.CharEncodingName2; //CharEncodingName2
objvApplicationTypeENT.CharEncodingName3 = objvApplicationTypeENS.CharEncodingName3; //CharEncodingName3
objvApplicationTypeENT.ProgLangTypeName2 = objvApplicationTypeENS.ProgLangTypeName2; //ProgLangTypeName2
objvApplicationTypeENT.ProgLangTypeName3 = objvApplicationTypeENS.ProgLangTypeName3; //ProgLangTypeName3
objvApplicationTypeENT.ProgLangTypeName5 = objvApplicationTypeENS.ProgLangTypeName5; //ProgLangTypeName5
objvApplicationTypeENT.CodeTypeCount = objvApplicationTypeENS.CodeTypeCount; //代码类型数
objvApplicationTypeENT.CharEncodingId4 = objvApplicationTypeENS.CharEncodingId4; //CharEncodingId4
objvApplicationTypeENT.CharEncodingName4 = objvApplicationTypeENS.CharEncodingName4; //CharEncodingName4
objvApplicationTypeENT.ProgLangTypeName4 = objvApplicationTypeENS.ProgLangTypeName4; //ProgLangTypeName4
objvApplicationTypeENT.CharEncodingId5 = objvApplicationTypeENS.CharEncodingId5; //CharEncodingId5
objvApplicationTypeENT.CharEncodingName5 = objvApplicationTypeENS.CharEncodingName5; //CharEncodingName5
objvApplicationTypeENT.sf_UpdFldSetStr = objvApplicationTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvApplicationTypeENT.sf_FldComparisonOp = objvApplicationTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvApplicationTypeENT;
}
return clsvApplicationTypeBL;
}());
exports.clsvApplicationTypeBL = clsvApplicationTypeBL;
});