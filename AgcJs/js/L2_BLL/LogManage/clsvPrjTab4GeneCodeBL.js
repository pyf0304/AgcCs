
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4GeneCodeBL
 表名:vPrjTab4GeneCode(00050284)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:13
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:日志管理
 模块英文名:LogManage
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
define(["require", "exports", "jquery", "../../L0_Entity/LogManage/clsvPrjTab4GeneCodeEN.js","../../L0_Entity/LogManage/clsvPrjTab4GeneCodeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvPrjTab4GeneCodeEN_js_1 = require("../../L0_Entity/LogManage/clsvPrjTab4GeneCodeEN.js");
var clsvPrjTab4GeneCodeEN_Sim_js_1 = require("../../L0_Entity/LogManage/clsvPrjTab4GeneCodeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// vPrjTab4GeneCode(vPrjTab4GeneCode)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvPrjTab4GeneCodeBL = /** @class */ (function () {
function clsvPrjTab4GeneCodeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvPrjTab4GeneCodeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200430120613
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvPrjTab4GeneCodeBL.GetJSONStrByObj  = function(pobjvPrjTab4GeneCodeEN)
{
pobjvPrjTab4GeneCodeEN.sf_UpdFldSetStr = pobjvPrjTab4GeneCodeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvPrjTab4GeneCodeEN);
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
 /// 日期:20200430120613
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvPrjTab4GeneCodeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvPrjTab4GeneCodeObjLst = new Array();
if (strJSON === "")
{
return arrvPrjTab4GeneCodeObjLst;
}
try
{
arrvPrjTab4GeneCodeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPrjTab4GeneCodeObjLst;
}
return arrvPrjTab4GeneCodeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200430120613
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvPrjTab4GeneCodeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
if (strJSON === "")
{
return pobjvPrjTab4GeneCodeEN;
}
try
{
pobjvPrjTab4GeneCodeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPrjTab4GeneCodeEN;
}
return pobjvPrjTab4GeneCodeEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeENS">源对象</param>
 /// <param name = "objvPrjTab4GeneCodeENT">目标对象</param>
clsvPrjTab4GeneCodeBL.CopyObjToSimObj = function(objvPrjTab4GeneCodeENS , objvPrjTab4GeneCodeENT ) 
{
objvPrjTab4GeneCodeENT.TabId = objvPrjTab4GeneCodeENS.TabId; //表ID
objvPrjTab4GeneCodeENT.FldNum = objvPrjTab4GeneCodeENS.FldNum; //字段数
objvPrjTab4GeneCodeENT.GeneCodeDate = objvPrjTab4GeneCodeENS.GeneCodeDate; //生成代码日期
objvPrjTab4GeneCodeENT.IsNeedGene = objvPrjTab4GeneCodeENS.IsNeedGene; //是否需要生成
objvPrjTab4GeneCodeENT.Version_GeneCode = objvPrjTab4GeneCodeENS.Version_GeneCode; //生成代码版本
objvPrjTab4GeneCodeENT.ApplicationTypeId = objvPrjTab4GeneCodeENS.ApplicationTypeId; //应用程序类型ID
objvPrjTab4GeneCodeENT.TabName = objvPrjTab4GeneCodeENS.TabName; //表名
objvPrjTab4GeneCodeENT.TabCnName = objvPrjTab4GeneCodeENS.TabCnName; //表中文名
objvPrjTab4GeneCodeENT.PrjId = objvPrjTab4GeneCodeENS.PrjId; //工程ID
objvPrjTab4GeneCodeENT.PrjName = objvPrjTab4GeneCodeENS.PrjName; //工程名称
objvPrjTab4GeneCodeENT.IsNeedTransCode = objvPrjTab4GeneCodeENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4GeneCodeENT.SQLDSTypeId = objvPrjTab4GeneCodeENS.SQLDSTypeId; //数据源类型
objvPrjTab4GeneCodeENT.SqlDsTypeName = objvPrjTab4GeneCodeENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4GeneCodeENT.TabStateId = objvPrjTab4GeneCodeENS.TabStateId; //表状态ID
objvPrjTab4GeneCodeENT.TabStateName = objvPrjTab4GeneCodeENS.TabStateName; //表状态名称
objvPrjTab4GeneCodeENT.TabName_B = objvPrjTab4GeneCodeENS.TabName_B; //表名_后备
objvPrjTab4GeneCodeENT.IsParaTab = objvPrjTab4GeneCodeENS.IsParaTab; //是否参数表
objvPrjTab4GeneCodeENT.IsNationStandard = objvPrjTab4GeneCodeENS.IsNationStandard; //是否国标
objvPrjTab4GeneCodeENT.IsArchive = objvPrjTab4GeneCodeENS.IsArchive; //是否存档
objvPrjTab4GeneCodeENT.IsChecked = objvPrjTab4GeneCodeENS.IsChecked; //是否核实
objvPrjTab4GeneCodeENT.FuncModuleAgcId = objvPrjTab4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4GeneCodeENT.FuncModuleName = objvPrjTab4GeneCodeENS.FuncModuleName; //功能模块名称
objvPrjTab4GeneCodeENT.FuncModuleEnName = objvPrjTab4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4GeneCodeENT.Owner = objvPrjTab4GeneCodeENS.Owner; //拥有者
objvPrjTab4GeneCodeENT.IsReleToSqlTab = objvPrjTab4GeneCodeENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4GeneCodeENT.KeyWord = objvPrjTab4GeneCodeENS.KeyWord; //关键字
objvPrjTab4GeneCodeENT.TabTypeId = objvPrjTab4GeneCodeENS.TabTypeId; //表类型Id
objvPrjTab4GeneCodeENT.TabTypeName = objvPrjTab4GeneCodeENS.TabTypeName; //表类型名
objvPrjTab4GeneCodeENT.TabMainTypeId = objvPrjTab4GeneCodeENS.TabMainTypeId; //表主类型Id
objvPrjTab4GeneCodeENT.TabMainTypeName = objvPrjTab4GeneCodeENS.TabMainTypeName; //表主类型名
objvPrjTab4GeneCodeENT.RelaTabId4View = objvPrjTab4GeneCodeENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4GeneCodeENT.OrderNum4Refer = objvPrjTab4GeneCodeENS.OrderNum4Refer; //引用序号
objvPrjTab4GeneCodeENT.IsNeedGeneIndexer = objvPrjTab4GeneCodeENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4GeneCodeENT.PrimaryTypeId = objvPrjTab4GeneCodeENS.PrimaryTypeId; //主键类型ID
objvPrjTab4GeneCodeENT.PrimaryTypeName = objvPrjTab4GeneCodeENS.PrimaryTypeName; //主键类型名
objvPrjTab4GeneCodeENT.IsUseCache = objvPrjTab4GeneCodeENS.IsUseCache; //是否使用Cache
objvPrjTab4GeneCodeENT.CacheClassifyField = objvPrjTab4GeneCodeENS.CacheClassifyField; //缓存分类字段
objvPrjTab4GeneCodeENT.KeyFldId = objvPrjTab4GeneCodeENS.KeyFldId; //关键字段Id
objvPrjTab4GeneCodeENT.KeyFldName = objvPrjTab4GeneCodeENS.KeyFldName; //关键字段名
objvPrjTab4GeneCodeENT.UpdUserId = objvPrjTab4GeneCodeENS.UpdUserId; //修改用户Id
objvPrjTab4GeneCodeENT.UpdDate = objvPrjTab4GeneCodeENS.UpdDate; //修改日期
objvPrjTab4GeneCodeENT.Memo = objvPrjTab4GeneCodeENS.Memo; //说明
objvPrjTab4GeneCodeENT.ErrMsg2 = objvPrjTab4GeneCodeENS.ErrMsg2; //ErrMsg2
objvPrjTab4GeneCodeENT.DataBaseName_Tab = objvPrjTab4GeneCodeENS.DataBaseName_Tab; //DataBaseName_Tab
objvPrjTab4GeneCodeENT.UserId4GeneCode = objvPrjTab4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
objvPrjTab4GeneCodeENT.sf_UpdFldSetStr = objvPrjTab4GeneCodeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvPrjTab4GeneCodeENT.sf_FldComparisonOp = objvPrjTab4GeneCodeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeENS">源对象</param>
 /// <param name = "objvPrjTab4GeneCodeENT">目标对象</param>
clsvPrjTab4GeneCodeBL.GetSimObjFromObj = function(objvPrjTab4GeneCodeENS)
{
var objvPrjTab4GeneCodeENT = new clsvPrjTab4GeneCodeEN_Sim_js_1.clsvPrjTab4GeneCodeEN_Sim();
objvPrjTab4GeneCodeENT.TabId = objvPrjTab4GeneCodeENS.TabId; //表ID
objvPrjTab4GeneCodeENT.FldNum = objvPrjTab4GeneCodeENS.FldNum; //字段数
objvPrjTab4GeneCodeENT.GeneCodeDate = objvPrjTab4GeneCodeENS.GeneCodeDate; //生成代码日期
objvPrjTab4GeneCodeENT.IsNeedGene = objvPrjTab4GeneCodeENS.IsNeedGene; //是否需要生成
objvPrjTab4GeneCodeENT.Version_GeneCode = objvPrjTab4GeneCodeENS.Version_GeneCode; //生成代码版本
objvPrjTab4GeneCodeENT.ApplicationTypeId = objvPrjTab4GeneCodeENS.ApplicationTypeId; //应用程序类型ID
objvPrjTab4GeneCodeENT.TabName = objvPrjTab4GeneCodeENS.TabName; //表名
objvPrjTab4GeneCodeENT.TabCnName = objvPrjTab4GeneCodeENS.TabCnName; //表中文名
objvPrjTab4GeneCodeENT.PrjId = objvPrjTab4GeneCodeENS.PrjId; //工程ID
objvPrjTab4GeneCodeENT.PrjName = objvPrjTab4GeneCodeENS.PrjName; //工程名称
objvPrjTab4GeneCodeENT.IsNeedTransCode = objvPrjTab4GeneCodeENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4GeneCodeENT.SQLDSTypeId = objvPrjTab4GeneCodeENS.SQLDSTypeId; //数据源类型
objvPrjTab4GeneCodeENT.SqlDsTypeName = objvPrjTab4GeneCodeENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4GeneCodeENT.TabStateId = objvPrjTab4GeneCodeENS.TabStateId; //表状态ID
objvPrjTab4GeneCodeENT.TabStateName = objvPrjTab4GeneCodeENS.TabStateName; //表状态名称
objvPrjTab4GeneCodeENT.TabName_B = objvPrjTab4GeneCodeENS.TabName_B; //表名_后备
objvPrjTab4GeneCodeENT.IsParaTab = objvPrjTab4GeneCodeENS.IsParaTab; //是否参数表
objvPrjTab4GeneCodeENT.IsNationStandard = objvPrjTab4GeneCodeENS.IsNationStandard; //是否国标
objvPrjTab4GeneCodeENT.IsArchive = objvPrjTab4GeneCodeENS.IsArchive; //是否存档
objvPrjTab4GeneCodeENT.IsChecked = objvPrjTab4GeneCodeENS.IsChecked; //是否核实
objvPrjTab4GeneCodeENT.FuncModuleAgcId = objvPrjTab4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4GeneCodeENT.FuncModuleName = objvPrjTab4GeneCodeENS.FuncModuleName; //功能模块名称
objvPrjTab4GeneCodeENT.FuncModuleEnName = objvPrjTab4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4GeneCodeENT.Owner = objvPrjTab4GeneCodeENS.Owner; //拥有者
objvPrjTab4GeneCodeENT.IsReleToSqlTab = objvPrjTab4GeneCodeENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4GeneCodeENT.KeyWord = objvPrjTab4GeneCodeENS.KeyWord; //关键字
objvPrjTab4GeneCodeENT.TabTypeId = objvPrjTab4GeneCodeENS.TabTypeId; //表类型Id
objvPrjTab4GeneCodeENT.TabTypeName = objvPrjTab4GeneCodeENS.TabTypeName; //表类型名
objvPrjTab4GeneCodeENT.TabMainTypeId = objvPrjTab4GeneCodeENS.TabMainTypeId; //表主类型Id
objvPrjTab4GeneCodeENT.TabMainTypeName = objvPrjTab4GeneCodeENS.TabMainTypeName; //表主类型名
objvPrjTab4GeneCodeENT.RelaTabId4View = objvPrjTab4GeneCodeENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4GeneCodeENT.OrderNum4Refer = objvPrjTab4GeneCodeENS.OrderNum4Refer; //引用序号
objvPrjTab4GeneCodeENT.IsNeedGeneIndexer = objvPrjTab4GeneCodeENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4GeneCodeENT.PrimaryTypeId = objvPrjTab4GeneCodeENS.PrimaryTypeId; //主键类型ID
objvPrjTab4GeneCodeENT.PrimaryTypeName = objvPrjTab4GeneCodeENS.PrimaryTypeName; //主键类型名
objvPrjTab4GeneCodeENT.IsUseCache = objvPrjTab4GeneCodeENS.IsUseCache; //是否使用Cache
objvPrjTab4GeneCodeENT.CacheClassifyField = objvPrjTab4GeneCodeENS.CacheClassifyField; //缓存分类字段
objvPrjTab4GeneCodeENT.KeyFldId = objvPrjTab4GeneCodeENS.KeyFldId; //关键字段Id
objvPrjTab4GeneCodeENT.KeyFldName = objvPrjTab4GeneCodeENS.KeyFldName; //关键字段名
objvPrjTab4GeneCodeENT.UpdUserId = objvPrjTab4GeneCodeENS.UpdUserId; //修改用户Id
objvPrjTab4GeneCodeENT.UpdDate = objvPrjTab4GeneCodeENS.UpdDate; //修改日期
objvPrjTab4GeneCodeENT.Memo = objvPrjTab4GeneCodeENS.Memo; //说明
objvPrjTab4GeneCodeENT.ErrMsg2 = objvPrjTab4GeneCodeENS.ErrMsg2; //ErrMsg2
objvPrjTab4GeneCodeENT.DataBaseName_Tab = objvPrjTab4GeneCodeENS.DataBaseName_Tab; //DataBaseName_Tab
objvPrjTab4GeneCodeENT.UserId4GeneCode = objvPrjTab4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
objvPrjTab4GeneCodeENT.sf_UpdFldSetStr = objvPrjTab4GeneCodeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvPrjTab4GeneCodeENT.sf_FldComparisonOp = objvPrjTab4GeneCodeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvPrjTab4GeneCodeENT;
}
return clsvPrjTab4GeneCodeBL;
}());
exports.clsvPrjTab4GeneCodeBL = clsvPrjTab4GeneCodeBL;
});