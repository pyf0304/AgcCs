
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewRegionBL
 表名:vViewRegion(00050199)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:23
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
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
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsvViewRegionEN.js","../../L0_Entity/RegionManage/clsvViewRegionEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvViewRegionEN_js_1 = require("../../L0_Entity/RegionManage/clsvViewRegionEN.js");
var clsvViewRegionEN_Sim_js_1 = require("../../L0_Entity/RegionManage/clsvViewRegionEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v界面区域(vViewRegion)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvViewRegionBL = /** @class */ (function () {
function clsvViewRegionBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvViewRegionObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024923
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewRegionBL.GetJSONStrByObj  = function(pobjvViewRegionEN)
{
pobjvViewRegionEN.sf_UpdFldSetStr = pobjvViewRegionEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvViewRegionEN);
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
 /// 日期:20200501024923
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvViewRegionBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvViewRegionObjLst = new Array();
if (strJSON === "")
{
return arrvViewRegionObjLst;
}
try
{
arrvViewRegionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvViewRegionObjLst;
}
return arrvViewRegionObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024923
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewRegionBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvViewRegionEN = new clsvViewRegionEN();
if (strJSON === "")
{
return pobjvViewRegionEN;
}
try
{
pobjvViewRegionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvViewRegionEN;
}
return pobjvViewRegionEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvViewRegionENS">源对象</param>
 /// <param name = "objvViewRegionENT">目标对象</param>
clsvViewRegionBL.CopyObjToSimObj = function(objvViewRegionENS , objvViewRegionENT ) 
{
objvViewRegionENT.RegionId = objvViewRegionENS.RegionId; //区域Id
objvViewRegionENT.RegionName = objvViewRegionENS.RegionName; //区域名称
objvViewRegionENT.ViewId = objvViewRegionENS.ViewId; //界面Id
objvViewRegionENT.ViewName = objvViewRegionENS.ViewName; //界面名称
objvViewRegionENT.ApplicationTypeId = objvViewRegionENS.ApplicationTypeId; //应用程序类型ID
objvViewRegionENT.ViewCnName = objvViewRegionENS.ViewCnName; //视图中文名
objvViewRegionENT.RegionTypeId = objvViewRegionENS.RegionTypeId; //区域类型Id
objvViewRegionENT.RegionTypeName = objvViewRegionENS.RegionTypeName; //区域类型名称
objvViewRegionENT.RegionTypeSimName = objvViewRegionENS.RegionTypeSimName; //区域类型简名
objvViewRegionENT.RegionTypeOrderNum = objvViewRegionENS.RegionTypeOrderNum; //区域类型序号
objvViewRegionENT.RegionFunction = objvViewRegionENS.RegionFunction; //区域功能
objvViewRegionENT.ClassName = objvViewRegionENS.ClassName; //类名
objvViewRegionENT.Height = objvViewRegionENS.Height; //高度
objvViewRegionENT.Width = objvViewRegionENS.Width; //宽
objvViewRegionENT.OUTRelaTabId = objvViewRegionENS.OUTRelaTabId; //输出数据源表ID
objvViewRegionENT.INSQLDSTypeId = objvViewRegionENS.INSQLDSTypeId; //输入数据源类型
objvViewRegionENT.INRelaTabId = objvViewRegionENS.INRelaTabId; //输入数据源表ID
objvViewRegionENT.OUTSQLDSTypeId = objvViewRegionENS.OUTSQLDSTypeId; //输出数据源类型
objvViewRegionENT.InUse = objvViewRegionENS.InUse; //是否在用
objvViewRegionENT.PrjId = objvViewRegionENS.PrjId; //工程ID
objvViewRegionENT.UpdUser = objvViewRegionENS.UpdUser; //修改者
objvViewRegionENT.UpdDate = objvViewRegionENS.UpdDate; //修改日期
objvViewRegionENT.Memo = objvViewRegionENS.Memo; //说明
objvViewRegionENT.OUTSqlDsTypeName = objvViewRegionENS.OUTSqlDsTypeName; //OUT数据源类型
objvViewRegionENT.OUTTabName = objvViewRegionENS.OUTTabName; //OUT表
objvViewRegionENT.OUTTabCnName = objvViewRegionENS.OUTTabCnName; //OUT表CH
objvViewRegionENT.INSqlDsTypeName = objvViewRegionENS.INSqlDsTypeName; //IN数据源类型
objvViewRegionENT.INTabName = objvViewRegionENS.INTabName; //IN表
objvViewRegionENT.INTabCnName = objvViewRegionENS.INTabCnName; //IN表中文名
objvViewRegionENT.FeatureNum = objvViewRegionENS.FeatureNum; //FeatureNum
objvViewRegionENT.sf_UpdFldSetStr = objvViewRegionENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewRegionENT.sf_FldComparisonOp = objvViewRegionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvViewRegionENS">源对象</param>
 /// <param name = "objvViewRegionENT">目标对象</param>
clsvViewRegionBL.GetSimObjFromObj = function(objvViewRegionENS)
{
var objvViewRegionENT = new clsvViewRegionEN_Sim_js_1.clsvViewRegionEN_Sim();
objvViewRegionENT.RegionId = objvViewRegionENS.RegionId; //区域Id
objvViewRegionENT.RegionName = objvViewRegionENS.RegionName; //区域名称
objvViewRegionENT.ViewId = objvViewRegionENS.ViewId; //界面Id
objvViewRegionENT.ViewName = objvViewRegionENS.ViewName; //界面名称
objvViewRegionENT.ApplicationTypeId = objvViewRegionENS.ApplicationTypeId; //应用程序类型ID
objvViewRegionENT.ViewCnName = objvViewRegionENS.ViewCnName; //视图中文名
objvViewRegionENT.RegionTypeId = objvViewRegionENS.RegionTypeId; //区域类型Id
objvViewRegionENT.RegionTypeName = objvViewRegionENS.RegionTypeName; //区域类型名称
objvViewRegionENT.RegionTypeSimName = objvViewRegionENS.RegionTypeSimName; //区域类型简名
objvViewRegionENT.RegionTypeOrderNum = objvViewRegionENS.RegionTypeOrderNum; //区域类型序号
objvViewRegionENT.RegionFunction = objvViewRegionENS.RegionFunction; //区域功能
objvViewRegionENT.ClassName = objvViewRegionENS.ClassName; //类名
objvViewRegionENT.Height = objvViewRegionENS.Height; //高度
objvViewRegionENT.Width = objvViewRegionENS.Width; //宽
objvViewRegionENT.OUTRelaTabId = objvViewRegionENS.OUTRelaTabId; //输出数据源表ID
objvViewRegionENT.INSQLDSTypeId = objvViewRegionENS.INSQLDSTypeId; //输入数据源类型
objvViewRegionENT.INRelaTabId = objvViewRegionENS.INRelaTabId; //输入数据源表ID
objvViewRegionENT.OUTSQLDSTypeId = objvViewRegionENS.OUTSQLDSTypeId; //输出数据源类型
objvViewRegionENT.InUse = objvViewRegionENS.InUse; //是否在用
objvViewRegionENT.PrjId = objvViewRegionENS.PrjId; //工程ID
objvViewRegionENT.UpdUser = objvViewRegionENS.UpdUser; //修改者
objvViewRegionENT.UpdDate = objvViewRegionENS.UpdDate; //修改日期
objvViewRegionENT.Memo = objvViewRegionENS.Memo; //说明
objvViewRegionENT.OUTSqlDsTypeName = objvViewRegionENS.OUTSqlDsTypeName; //OUT数据源类型
objvViewRegionENT.OUTTabName = objvViewRegionENS.OUTTabName; //OUT表
objvViewRegionENT.OUTTabCnName = objvViewRegionENS.OUTTabCnName; //OUT表CH
objvViewRegionENT.INSqlDsTypeName = objvViewRegionENS.INSqlDsTypeName; //IN数据源类型
objvViewRegionENT.INTabName = objvViewRegionENS.INTabName; //IN表
objvViewRegionENT.INTabCnName = objvViewRegionENS.INTabCnName; //IN表中文名
objvViewRegionENT.FeatureNum = objvViewRegionENS.FeatureNum; //FeatureNum
objvViewRegionENT.sf_UpdFldSetStr = objvViewRegionENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewRegionENT.sf_FldComparisonOp = objvViewRegionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvViewRegionENT;
}
return clsvViewRegionBL;
}());
exports.clsvViewRegionBL = clsvViewRegionBL;
});