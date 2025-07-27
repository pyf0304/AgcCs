
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabBL
 表名:vPrjTab(00050124)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:05
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsvPrjTabEN.js","../../L0_Entity/Table_Field/clsvPrjTabEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvPrjTabEN_js_1 = require("../../L0_Entity/Table_Field/clsvPrjTabEN.js");
var clsvPrjTabEN_Sim_js_1 = require("../../L0_Entity/Table_Field/clsvPrjTabEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v工程表(vPrjTab)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvPrjTabBL = /** @class */ (function () {
function clsvPrjTabBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvPrjTabObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200502010605
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvPrjTabBL.GetJSONStrByObj  = function(pobjvPrjTabEN)
{
pobjvPrjTabEN.sf_UpdFldSetStr = pobjvPrjTabEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvPrjTabEN);
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
 /// 日期:20200502010605
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvPrjTabBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvPrjTabObjLst = new Array();
if (strJSON === "")
{
return arrvPrjTabObjLst;
}
try
{
arrvPrjTabObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPrjTabObjLst;
}
return arrvPrjTabObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200502010605
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvPrjTabBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvPrjTabEN = new clsvPrjTabEN();
if (strJSON === "")
{
return pobjvPrjTabEN;
}
try
{
pobjvPrjTabEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPrjTabEN;
}
return pobjvPrjTabEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvPrjTabENS">源对象</param>
 /// <param name = "objvPrjTabENT">目标对象</param>
clsvPrjTabBL.CopyObjToSimObj = function(objvPrjTabENS , objvPrjTabENT ) 
{
objvPrjTabENT.TabId = objvPrjTabENS.TabId; //表ID
objvPrjTabENT.FldNum = objvPrjTabENS.FldNum; //字段数
objvPrjTabENT.TabName = objvPrjTabENS.TabName; //表名
objvPrjTabENT.TabCnName = objvPrjTabENS.TabCnName; //表中文名
objvPrjTabENT.PrjId = objvPrjTabENS.PrjId; //工程ID
objvPrjTabENT.PrjName = objvPrjTabENS.PrjName; //工程名称
objvPrjTabENT.SQLDSTypeId = objvPrjTabENS.SQLDSTypeId; //数据源类型
objvPrjTabENT.SqlDsTypeName = objvPrjTabENS.SqlDsTypeName; //Sql数据源名
objvPrjTabENT.TabStateId = objvPrjTabENS.TabStateId; //表状态ID
objvPrjTabENT.TabStateName = objvPrjTabENS.TabStateName; //表状态名称
objvPrjTabENT.FuncModuleAgcId = objvPrjTabENS.FuncModuleAgcId; //功能模块Id
objvPrjTabENT.FuncModuleName = objvPrjTabENS.FuncModuleName; //功能模块名称
objvPrjTabENT.FuncModuleEnName = objvPrjTabENS.FuncModuleEnName; //功能模块英文名称
objvPrjTabENT.IsReleToSqlTab = objvPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTabENT.KeyWord = objvPrjTabENS.KeyWord; //关键字
objvPrjTabENT.TabTypeId = objvPrjTabENS.TabTypeId; //表类型Id
objvPrjTabENT.TabTypeName = objvPrjTabENS.TabTypeName; //表类型名
objvPrjTabENT.TabMainTypeId = objvPrjTabENS.TabMainTypeId; //表主类型Id
objvPrjTabENT.TabMainTypeName = objvPrjTabENS.TabMainTypeName; //表主类型名
objvPrjTabENT.RelaTabId4View = objvPrjTabENS.RelaTabId4View; //视图的相关表ID
objvPrjTabENT.IsNeedGeneIndexer = objvPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTabENT.ParentClass = objvPrjTabENS.ParentClass; //父类
objvPrjTabENT.IsUseCache = objvPrjTabENS.IsUseCache; //是否使用Cache
objvPrjTabENT.CacheClassifyField = objvPrjTabENS.CacheClassifyField; //缓存分类字段
objvPrjTabENT.UpdUserId = objvPrjTabENS.UpdUserId; //修改用户Id
objvPrjTabENT.UpdDate = objvPrjTabENS.UpdDate; //修改日期
objvPrjTabENT.Memo = objvPrjTabENS.Memo; //说明
objvPrjTabENT.DataBaseName_Tab = objvPrjTabENS.DataBaseName_Tab; //DataBaseName_Tab
objvPrjTabENT.RelaTabName4View = objvPrjTabENS.RelaTabName4View; //RelaTabName4View
objvPrjTabENT.UpdDate2 = objvPrjTabENS.UpdDate2; //UpdDate2
objvPrjTabENT.CacheModeId = objvPrjTabENS.CacheModeId; //缓存方式Id
objvPrjTabENT.ErrMsg = objvPrjTabENS.ErrMsg; //错误信息
objvPrjTabENT.PrimaryTypeId = objvPrjTabENS.PrimaryTypeId; //主键类型ID
objvPrjTabENT.PrimaryTypeName = objvPrjTabENS.PrimaryTypeName; //主键类型名
objvPrjTabENT.KeyFldId = objvPrjTabENS.KeyFldId; //关键字段Id
objvPrjTabENT.KeyFldName = objvPrjTabENS.KeyFldName; //关键字段名
objvPrjTabENT.IsChecked = objvPrjTabENS.IsChecked; //是否核实
objvPrjTabENT.IsNeedCheckTab = objvPrjTabENS.IsNeedCheckTab; //是否需要检查表字段
objvPrjTabENT.OrderNum4Refer = objvPrjTabENS.OrderNum4Refer; //引用序号
objvPrjTabENT.TabEnName = objvPrjTabENS.TabEnName; //表英文详细名
objvPrjTabENT.IsNeedTransCode = objvPrjTabENS.IsNeedTransCode; //是否需要转换代码
objvPrjTabENT.TabName_B = objvPrjTabENS.TabName_B; //表名_后备
objvPrjTabENT.IsParaTab = objvPrjTabENS.IsParaTab; //是否参数表
objvPrjTabENT.IsNationStandard = objvPrjTabENS.IsNationStandard; //是否国标
objvPrjTabENT.IsArchive = objvPrjTabENS.IsArchive; //是否存档
objvPrjTabENT.Owner = objvPrjTabENS.Owner; //拥有者
objvPrjTabENT.sf_UpdFldSetStr = objvPrjTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objvPrjTabENT.sf_FldComparisonOp = objvPrjTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvPrjTabENS">源对象</param>
 /// <param name = "objvPrjTabENT">目标对象</param>
clsvPrjTabBL.GetSimObjFromObj = function(objvPrjTabENS)
{
var objvPrjTabENT = new clsvPrjTabEN_Sim_js_1.clsvPrjTabEN_Sim();
objvPrjTabENT.TabId = objvPrjTabENS.TabId; //表ID
objvPrjTabENT.FldNum = objvPrjTabENS.FldNum; //字段数
objvPrjTabENT.TabName = objvPrjTabENS.TabName; //表名
objvPrjTabENT.TabCnName = objvPrjTabENS.TabCnName; //表中文名
objvPrjTabENT.PrjId = objvPrjTabENS.PrjId; //工程ID
objvPrjTabENT.PrjName = objvPrjTabENS.PrjName; //工程名称
objvPrjTabENT.SQLDSTypeId = objvPrjTabENS.SQLDSTypeId; //数据源类型
objvPrjTabENT.SqlDsTypeName = objvPrjTabENS.SqlDsTypeName; //Sql数据源名
objvPrjTabENT.TabStateId = objvPrjTabENS.TabStateId; //表状态ID
objvPrjTabENT.TabStateName = objvPrjTabENS.TabStateName; //表状态名称
objvPrjTabENT.FuncModuleAgcId = objvPrjTabENS.FuncModuleAgcId; //功能模块Id
objvPrjTabENT.FuncModuleName = objvPrjTabENS.FuncModuleName; //功能模块名称
objvPrjTabENT.FuncModuleEnName = objvPrjTabENS.FuncModuleEnName; //功能模块英文名称
objvPrjTabENT.IsReleToSqlTab = objvPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTabENT.KeyWord = objvPrjTabENS.KeyWord; //关键字
objvPrjTabENT.TabTypeId = objvPrjTabENS.TabTypeId; //表类型Id
objvPrjTabENT.TabTypeName = objvPrjTabENS.TabTypeName; //表类型名
objvPrjTabENT.TabMainTypeId = objvPrjTabENS.TabMainTypeId; //表主类型Id
objvPrjTabENT.TabMainTypeName = objvPrjTabENS.TabMainTypeName; //表主类型名
objvPrjTabENT.RelaTabId4View = objvPrjTabENS.RelaTabId4View; //视图的相关表ID
objvPrjTabENT.IsNeedGeneIndexer = objvPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTabENT.ParentClass = objvPrjTabENS.ParentClass; //父类
objvPrjTabENT.IsUseCache = objvPrjTabENS.IsUseCache; //是否使用Cache
objvPrjTabENT.CacheClassifyField = objvPrjTabENS.CacheClassifyField; //缓存分类字段
objvPrjTabENT.UpdUserId = objvPrjTabENS.UpdUserId; //修改用户Id
objvPrjTabENT.UpdDate = objvPrjTabENS.UpdDate; //修改日期
objvPrjTabENT.Memo = objvPrjTabENS.Memo; //说明
objvPrjTabENT.DataBaseName_Tab = objvPrjTabENS.DataBaseName_Tab; //DataBaseName_Tab
objvPrjTabENT.RelaTabName4View = objvPrjTabENS.RelaTabName4View; //RelaTabName4View
objvPrjTabENT.UpdDate2 = objvPrjTabENS.UpdDate2; //UpdDate2
objvPrjTabENT.CacheModeId = objvPrjTabENS.CacheModeId; //缓存方式Id
objvPrjTabENT.ErrMsg = objvPrjTabENS.ErrMsg; //错误信息
objvPrjTabENT.PrimaryTypeId = objvPrjTabENS.PrimaryTypeId; //主键类型ID
objvPrjTabENT.PrimaryTypeName = objvPrjTabENS.PrimaryTypeName; //主键类型名
objvPrjTabENT.KeyFldId = objvPrjTabENS.KeyFldId; //关键字段Id
objvPrjTabENT.KeyFldName = objvPrjTabENS.KeyFldName; //关键字段名
objvPrjTabENT.IsChecked = objvPrjTabENS.IsChecked; //是否核实
objvPrjTabENT.IsNeedCheckTab = objvPrjTabENS.IsNeedCheckTab; //是否需要检查表字段
objvPrjTabENT.OrderNum4Refer = objvPrjTabENS.OrderNum4Refer; //引用序号
objvPrjTabENT.TabEnName = objvPrjTabENS.TabEnName; //表英文详细名
objvPrjTabENT.IsNeedTransCode = objvPrjTabENS.IsNeedTransCode; //是否需要转换代码
objvPrjTabENT.TabName_B = objvPrjTabENS.TabName_B; //表名_后备
objvPrjTabENT.IsParaTab = objvPrjTabENS.IsParaTab; //是否参数表
objvPrjTabENT.IsNationStandard = objvPrjTabENS.IsNationStandard; //是否国标
objvPrjTabENT.IsArchive = objvPrjTabENS.IsArchive; //是否存档
objvPrjTabENT.Owner = objvPrjTabENS.Owner; //拥有者
objvPrjTabENT.sf_UpdFldSetStr = objvPrjTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objvPrjTabENT.sf_FldComparisonOp = objvPrjTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvPrjTabENT;
}
return clsvPrjTabBL;
}());
exports.clsvPrjTabBL = clsvPrjTabBL;
});