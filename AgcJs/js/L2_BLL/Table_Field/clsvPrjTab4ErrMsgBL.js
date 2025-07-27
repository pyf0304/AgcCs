
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4ErrMsgBL
 表名:vPrjTab4ErrMsg(00050206)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:11
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsvPrjTab4ErrMsgEN.js","../../L0_Entity/Table_Field/clsvPrjTab4ErrMsgEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvPrjTab4ErrMsgEN_js_1 = require("../../L0_Entity/Table_Field/clsvPrjTab4ErrMsgEN.js");
var clsvPrjTab4ErrMsgEN_Sim_js_1 = require("../../L0_Entity/Table_Field/clsvPrjTab4ErrMsgEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// vPrjTab4ErrMsg(vPrjTab4ErrMsg)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvPrjTab4ErrMsgBL = /** @class */ (function () {
function clsvPrjTab4ErrMsgBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvPrjTab4ErrMsgObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200430120611
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvPrjTab4ErrMsgBL.GetJSONStrByObj  = function(pobjvPrjTab4ErrMsgEN)
{
pobjvPrjTab4ErrMsgEN.sf_UpdFldSetStr = pobjvPrjTab4ErrMsgEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvPrjTab4ErrMsgEN);
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
 /// 日期:20200430120611
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvPrjTab4ErrMsgBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvPrjTab4ErrMsgObjLst = new Array();
if (strJSON === "")
{
return arrvPrjTab4ErrMsgObjLst;
}
try
{
arrvPrjTab4ErrMsgObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPrjTab4ErrMsgObjLst;
}
return arrvPrjTab4ErrMsgObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200430120611
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvPrjTab4ErrMsgBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
if (strJSON === "")
{
return pobjvPrjTab4ErrMsgEN;
}
try
{
pobjvPrjTab4ErrMsgEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPrjTab4ErrMsgEN;
}
return pobjvPrjTab4ErrMsgEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgENS">源对象</param>
 /// <param name = "objvPrjTab4ErrMsgENT">目标对象</param>
clsvPrjTab4ErrMsgBL.CopyObjToSimObj = function(objvPrjTab4ErrMsgENS , objvPrjTab4ErrMsgENT ) 
{
objvPrjTab4ErrMsgENT.TabId = objvPrjTab4ErrMsgENS.TabId; //表ID
objvPrjTab4ErrMsgENT.FldNum = objvPrjTab4ErrMsgENS.FldNum; //字段数
objvPrjTab4ErrMsgENT.TabName = objvPrjTab4ErrMsgENS.TabName; //表名
objvPrjTab4ErrMsgENT.TabCnName = objvPrjTab4ErrMsgENS.TabCnName; //表中文名
objvPrjTab4ErrMsgENT.PrjId = objvPrjTab4ErrMsgENS.PrjId; //工程ID
objvPrjTab4ErrMsgENT.PrjName = objvPrjTab4ErrMsgENS.PrjName; //工程名称
objvPrjTab4ErrMsgENT.IsNeedTransCode = objvPrjTab4ErrMsgENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4ErrMsgENT.SQLDSTypeId = objvPrjTab4ErrMsgENS.SQLDSTypeId; //数据源类型
objvPrjTab4ErrMsgENT.SqlDsTypeName = objvPrjTab4ErrMsgENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4ErrMsgENT.TabStateId = objvPrjTab4ErrMsgENS.TabStateId; //表状态ID
objvPrjTab4ErrMsgENT.TabStateName = objvPrjTab4ErrMsgENS.TabStateName; //表状态名称
objvPrjTab4ErrMsgENT.TabName_B = objvPrjTab4ErrMsgENS.TabName_B; //表名_后备
objvPrjTab4ErrMsgENT.IsParaTab = objvPrjTab4ErrMsgENS.IsParaTab; //是否参数表
objvPrjTab4ErrMsgENT.IsNationStandard = objvPrjTab4ErrMsgENS.IsNationStandard; //是否国标
objvPrjTab4ErrMsgENT.IsArchive = objvPrjTab4ErrMsgENS.IsArchive; //是否存档
objvPrjTab4ErrMsgENT.IsChecked = objvPrjTab4ErrMsgENS.IsChecked; //是否核实
objvPrjTab4ErrMsgENT.ErrMsg = objvPrjTab4ErrMsgENS.ErrMsg; //错误信息
objvPrjTab4ErrMsgENT.FuncModuleAgcId = objvPrjTab4ErrMsgENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4ErrMsgENT.FuncModuleName = objvPrjTab4ErrMsgENS.FuncModuleName; //功能模块名称
objvPrjTab4ErrMsgENT.FuncModuleEnName = objvPrjTab4ErrMsgENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4ErrMsgENT.Owner = objvPrjTab4ErrMsgENS.Owner; //拥有者
objvPrjTab4ErrMsgENT.IsReleToSqlTab = objvPrjTab4ErrMsgENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4ErrMsgENT.KeyWord = objvPrjTab4ErrMsgENS.KeyWord; //关键字
objvPrjTab4ErrMsgENT.TabTypeId = objvPrjTab4ErrMsgENS.TabTypeId; //表类型Id
objvPrjTab4ErrMsgENT.TabTypeName = objvPrjTab4ErrMsgENS.TabTypeName; //表类型名
objvPrjTab4ErrMsgENT.RelaTabId4View = objvPrjTab4ErrMsgENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4ErrMsgENT.OrderNum4Refer = objvPrjTab4ErrMsgENS.OrderNum4Refer; //引用序号
objvPrjTab4ErrMsgENT.IsNeedGeneIndexer = objvPrjTab4ErrMsgENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4ErrMsgENT.PrimaryTypeId = objvPrjTab4ErrMsgENS.PrimaryTypeId; //主键类型ID
objvPrjTab4ErrMsgENT.PrimaryTypeName = objvPrjTab4ErrMsgENS.PrimaryTypeName; //主键类型名
objvPrjTab4ErrMsgENT.KeyFldId = objvPrjTab4ErrMsgENS.KeyFldId; //关键字段Id
objvPrjTab4ErrMsgENT.KeyFldName = objvPrjTab4ErrMsgENS.KeyFldName; //关键字段名
objvPrjTab4ErrMsgENT.UpdUserId = objvPrjTab4ErrMsgENS.UpdUserId; //修改用户Id
objvPrjTab4ErrMsgENT.UpdDate = objvPrjTab4ErrMsgENS.UpdDate; //修改日期
objvPrjTab4ErrMsgENT.Memo = objvPrjTab4ErrMsgENS.Memo; //说明
objvPrjTab4ErrMsgENT.ErrMsg2 = objvPrjTab4ErrMsgENS.ErrMsg2; //ErrMsg2
objvPrjTab4ErrMsgENT.RelaTabName4View = objvPrjTab4ErrMsgENS.RelaTabName4View; //RelaTabName4View
objvPrjTab4ErrMsgENT.DataBaseName_Tab = objvPrjTab4ErrMsgENS.DataBaseName_Tab; //DataBaseName_Tab
objvPrjTab4ErrMsgENT.sf_UpdFldSetStr = objvPrjTab4ErrMsgENS.UpdFldString; //专门用于记录某字段属性是否修改
objvPrjTab4ErrMsgENT.sf_FldComparisonOp = objvPrjTab4ErrMsgENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgENS">源对象</param>
 /// <param name = "objvPrjTab4ErrMsgENT">目标对象</param>
clsvPrjTab4ErrMsgBL.GetSimObjFromObj = function(objvPrjTab4ErrMsgENS)
{
var objvPrjTab4ErrMsgENT = new clsvPrjTab4ErrMsgEN_Sim_js_1.clsvPrjTab4ErrMsgEN_Sim();
objvPrjTab4ErrMsgENT.TabId = objvPrjTab4ErrMsgENS.TabId; //表ID
objvPrjTab4ErrMsgENT.FldNum = objvPrjTab4ErrMsgENS.FldNum; //字段数
objvPrjTab4ErrMsgENT.TabName = objvPrjTab4ErrMsgENS.TabName; //表名
objvPrjTab4ErrMsgENT.TabCnName = objvPrjTab4ErrMsgENS.TabCnName; //表中文名
objvPrjTab4ErrMsgENT.PrjId = objvPrjTab4ErrMsgENS.PrjId; //工程ID
objvPrjTab4ErrMsgENT.PrjName = objvPrjTab4ErrMsgENS.PrjName; //工程名称
objvPrjTab4ErrMsgENT.IsNeedTransCode = objvPrjTab4ErrMsgENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4ErrMsgENT.SQLDSTypeId = objvPrjTab4ErrMsgENS.SQLDSTypeId; //数据源类型
objvPrjTab4ErrMsgENT.SqlDsTypeName = objvPrjTab4ErrMsgENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4ErrMsgENT.TabStateId = objvPrjTab4ErrMsgENS.TabStateId; //表状态ID
objvPrjTab4ErrMsgENT.TabStateName = objvPrjTab4ErrMsgENS.TabStateName; //表状态名称
objvPrjTab4ErrMsgENT.TabName_B = objvPrjTab4ErrMsgENS.TabName_B; //表名_后备
objvPrjTab4ErrMsgENT.IsParaTab = objvPrjTab4ErrMsgENS.IsParaTab; //是否参数表
objvPrjTab4ErrMsgENT.IsNationStandard = objvPrjTab4ErrMsgENS.IsNationStandard; //是否国标
objvPrjTab4ErrMsgENT.IsArchive = objvPrjTab4ErrMsgENS.IsArchive; //是否存档
objvPrjTab4ErrMsgENT.IsChecked = objvPrjTab4ErrMsgENS.IsChecked; //是否核实
objvPrjTab4ErrMsgENT.ErrMsg = objvPrjTab4ErrMsgENS.ErrMsg; //错误信息
objvPrjTab4ErrMsgENT.FuncModuleAgcId = objvPrjTab4ErrMsgENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4ErrMsgENT.FuncModuleName = objvPrjTab4ErrMsgENS.FuncModuleName; //功能模块名称
objvPrjTab4ErrMsgENT.FuncModuleEnName = objvPrjTab4ErrMsgENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4ErrMsgENT.Owner = objvPrjTab4ErrMsgENS.Owner; //拥有者
objvPrjTab4ErrMsgENT.IsReleToSqlTab = objvPrjTab4ErrMsgENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4ErrMsgENT.KeyWord = objvPrjTab4ErrMsgENS.KeyWord; //关键字
objvPrjTab4ErrMsgENT.TabTypeId = objvPrjTab4ErrMsgENS.TabTypeId; //表类型Id
objvPrjTab4ErrMsgENT.TabTypeName = objvPrjTab4ErrMsgENS.TabTypeName; //表类型名
objvPrjTab4ErrMsgENT.RelaTabId4View = objvPrjTab4ErrMsgENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4ErrMsgENT.OrderNum4Refer = objvPrjTab4ErrMsgENS.OrderNum4Refer; //引用序号
objvPrjTab4ErrMsgENT.IsNeedGeneIndexer = objvPrjTab4ErrMsgENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4ErrMsgENT.PrimaryTypeId = objvPrjTab4ErrMsgENS.PrimaryTypeId; //主键类型ID
objvPrjTab4ErrMsgENT.PrimaryTypeName = objvPrjTab4ErrMsgENS.PrimaryTypeName; //主键类型名
objvPrjTab4ErrMsgENT.KeyFldId = objvPrjTab4ErrMsgENS.KeyFldId; //关键字段Id
objvPrjTab4ErrMsgENT.KeyFldName = objvPrjTab4ErrMsgENS.KeyFldName; //关键字段名
objvPrjTab4ErrMsgENT.UpdUserId = objvPrjTab4ErrMsgENS.UpdUserId; //修改用户Id
objvPrjTab4ErrMsgENT.UpdDate = objvPrjTab4ErrMsgENS.UpdDate; //修改日期
objvPrjTab4ErrMsgENT.Memo = objvPrjTab4ErrMsgENS.Memo; //说明
objvPrjTab4ErrMsgENT.ErrMsg2 = objvPrjTab4ErrMsgENS.ErrMsg2; //ErrMsg2
objvPrjTab4ErrMsgENT.RelaTabName4View = objvPrjTab4ErrMsgENS.RelaTabName4View; //RelaTabName4View
objvPrjTab4ErrMsgENT.DataBaseName_Tab = objvPrjTab4ErrMsgENS.DataBaseName_Tab; //DataBaseName_Tab
objvPrjTab4ErrMsgENT.sf_UpdFldSetStr = objvPrjTab4ErrMsgENS.UpdFldString; //专门用于记录某字段属性是否修改
objvPrjTab4ErrMsgENT.sf_FldComparisonOp = objvPrjTab4ErrMsgENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvPrjTab4ErrMsgENT;
}
return clsvPrjTab4ErrMsgBL;
}());
exports.clsvPrjTab4ErrMsgBL = clsvPrjTab4ErrMsgBL;
});