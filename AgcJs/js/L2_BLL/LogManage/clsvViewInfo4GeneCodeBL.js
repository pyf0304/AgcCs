
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfo4GeneCodeBL
 表名:vViewInfo4GeneCode(00050283)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 00:34:45
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
define(["require", "exports", "jquery", "../../L0_Entity/LogManage/clsvViewInfo4GeneCodeEN.js","../../L0_Entity/LogManage/clsvViewInfo4GeneCodeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvViewInfo4GeneCodeEN_js_1 = require("../../L0_Entity/LogManage/clsvViewInfo4GeneCodeEN.js");
var clsvViewInfo4GeneCodeEN_Sim_js_1 = require("../../L0_Entity/LogManage/clsvViewInfo4GeneCodeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// vViewInfo4GeneCode(vViewInfo4GeneCode)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvViewInfo4GeneCodeBL = /** @class */ (function () {
function clsvViewInfo4GeneCodeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvViewInfo4GeneCodeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501003445
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewInfo4GeneCodeBL.GetJSONStrByObj  = function(pobjvViewInfo4GeneCodeEN)
{
pobjvViewInfo4GeneCodeEN.sf_UpdFldSetStr = pobjvViewInfo4GeneCodeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvViewInfo4GeneCodeEN);
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
 /// 日期:20200501003445
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvViewInfo4GeneCodeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvViewInfo4GeneCodeObjLst = new Array();
if (strJSON === "")
{
return arrvViewInfo4GeneCodeObjLst;
}
try
{
arrvViewInfo4GeneCodeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvViewInfo4GeneCodeObjLst;
}
return arrvViewInfo4GeneCodeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501003445
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewInfo4GeneCodeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvViewInfo4GeneCodeEN = new clsvViewInfo4GeneCodeEN();
if (strJSON === "")
{
return pobjvViewInfo4GeneCodeEN;
}
try
{
pobjvViewInfo4GeneCodeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvViewInfo4GeneCodeEN;
}
return pobjvViewInfo4GeneCodeEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeENS">源对象</param>
 /// <param name = "objvViewInfo4GeneCodeENT">目标对象</param>
clsvViewInfo4GeneCodeBL.CopyObjToSimObj = function(objvViewInfo4GeneCodeENS , objvViewInfo4GeneCodeENT ) 
{
objvViewInfo4GeneCodeENT.ViewId = objvViewInfo4GeneCodeENS.ViewId; //界面Id
objvViewInfo4GeneCodeENT.TitleStyleId = objvViewInfo4GeneCodeENS.TitleStyleId; //标题类型Id
objvViewInfo4GeneCodeENT.TitleStyleName = objvViewInfo4GeneCodeENS.TitleStyleName; //标题类型名
objvViewInfo4GeneCodeENT.DGStyleId = objvViewInfo4GeneCodeENS.DGStyleId; //DG模式ID
objvViewInfo4GeneCodeENT.DGStyleName = objvViewInfo4GeneCodeENS.DGStyleName; //DG模式名
objvViewInfo4GeneCodeENT.Version_GeneCode = objvViewInfo4GeneCodeENS.Version_GeneCode; //生成代码版本
objvViewInfo4GeneCodeENT.ViewName = objvViewInfo4GeneCodeENS.ViewName; //界面名称
objvViewInfo4GeneCodeENT.ViewTypeCode = objvViewInfo4GeneCodeENS.ViewTypeCode; //界面类型码
objvViewInfo4GeneCodeENT.ViewTypeName = objvViewInfo4GeneCodeENS.ViewTypeName; //界面类型名称
objvViewInfo4GeneCodeENT.ApplicationTypeId = objvViewInfo4GeneCodeENS.ApplicationTypeId; //应用程序类型ID
objvViewInfo4GeneCodeENT.ApplicationTypeName = objvViewInfo4GeneCodeENS.ApplicationTypeName; //应用程序类型名称
objvViewInfo4GeneCodeENT.FuncModuleAgcId = objvViewInfo4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvViewInfo4GeneCodeENT.FuncModuleName = objvViewInfo4GeneCodeENS.FuncModuleName; //功能模块名称
objvViewInfo4GeneCodeENT.FuncModuleEnName = objvViewInfo4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvViewInfo4GeneCodeENT.DataBaseName = objvViewInfo4GeneCodeENS.DataBaseName; //数据库名
objvViewInfo4GeneCodeENT.KeyForMainTab = objvViewInfo4GeneCodeENS.KeyForMainTab; //主表关键字
objvViewInfo4GeneCodeENT.KeyForDetailTab = objvViewInfo4GeneCodeENS.KeyForDetailTab; //明细表关键字
objvViewInfo4GeneCodeENT.IsNeedSort = objvViewInfo4GeneCodeENS.IsNeedSort; //是否需要排序
objvViewInfo4GeneCodeENT.IsNeedTransCode = objvViewInfo4GeneCodeENS.IsNeedTransCode; //是否需要转换代码
objvViewInfo4GeneCodeENT.UserId = objvViewInfo4GeneCodeENS.UserId; //用户Id
objvViewInfo4GeneCodeENT.PrjId = objvViewInfo4GeneCodeENS.PrjId; //工程ID
objvViewInfo4GeneCodeENT.PrjName = objvViewInfo4GeneCodeENS.PrjName; //工程名称
objvViewInfo4GeneCodeENT.ViewFunction = objvViewInfo4GeneCodeENS.ViewFunction; //界面功能
objvViewInfo4GeneCodeENT.ViewDetail = objvViewInfo4GeneCodeENS.ViewDetail; //界面说明
objvViewInfo4GeneCodeENT.DefaMenuName = objvViewInfo4GeneCodeENS.DefaMenuName; //缺省菜单名
objvViewInfo4GeneCodeENT.DetailTabId = objvViewInfo4GeneCodeENS.DetailTabId; //明细表ID
objvViewInfo4GeneCodeENT.FileName = objvViewInfo4GeneCodeENS.FileName; //文件名
objvViewInfo4GeneCodeENT.FilePath = objvViewInfo4GeneCodeENS.FilePath; //文件路径
objvViewInfo4GeneCodeENT.MainTabId = objvViewInfo4GeneCodeENS.MainTabId; //主表ID
objvViewInfo4GeneCodeENT.ViewCnName = objvViewInfo4GeneCodeENS.ViewCnName; //视图中文名
objvViewInfo4GeneCodeENT.ViewGroupId = objvViewInfo4GeneCodeENS.ViewGroupId; //界面组ID
objvViewInfo4GeneCodeENT.ViewGroupName = objvViewInfo4GeneCodeENS.ViewGroupName; //界面组名称
objvViewInfo4GeneCodeENT.INSQLDSTypeId = objvViewInfo4GeneCodeENS.INSQLDSTypeId; //输入数据源类型
objvViewInfo4GeneCodeENT.OUTSQLDSTypeId = objvViewInfo4GeneCodeENS.OUTSQLDSTypeId; //输出数据源类型
objvViewInfo4GeneCodeENT.GeneCodeDate = objvViewInfo4GeneCodeENS.GeneCodeDate; //生成代码日期
objvViewInfo4GeneCodeENT.RegionNum = objvViewInfo4GeneCodeENS.RegionNum; //区域数
objvViewInfo4GeneCodeENT.UpdDate = objvViewInfo4GeneCodeENS.UpdDate; //修改日期
objvViewInfo4GeneCodeENT.MainTabName = objvViewInfo4GeneCodeENS.MainTabName; //主表
objvViewInfo4GeneCodeENT.DetailTabName = objvViewInfo4GeneCodeENS.DetailTabName; //详细表
objvViewInfo4GeneCodeENT.MainTabKeyFld = objvViewInfo4GeneCodeENS.MainTabKeyFld; //MainTabKeyFld
objvViewInfo4GeneCodeENT.DetailTabKeyFld = objvViewInfo4GeneCodeENS.DetailTabKeyFld; //DetailTabKeyFld
objvViewInfo4GeneCodeENT.UserId4GeneCode = objvViewInfo4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
objvViewInfo4GeneCodeENT.sf_UpdFldSetStr = objvViewInfo4GeneCodeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewInfo4GeneCodeENT.sf_FldComparisonOp = objvViewInfo4GeneCodeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvViewInfo4GeneCodeENS">源对象</param>
 /// <param name = "objvViewInfo4GeneCodeENT">目标对象</param>
clsvViewInfo4GeneCodeBL.GetSimObjFromObj = function(objvViewInfo4GeneCodeENS)
{
var objvViewInfo4GeneCodeENT = new clsvViewInfo4GeneCodeEN_Sim_js_1.clsvViewInfo4GeneCodeEN_Sim();
objvViewInfo4GeneCodeENT.ViewId = objvViewInfo4GeneCodeENS.ViewId; //界面Id
objvViewInfo4GeneCodeENT.TitleStyleId = objvViewInfo4GeneCodeENS.TitleStyleId; //标题类型Id
objvViewInfo4GeneCodeENT.TitleStyleName = objvViewInfo4GeneCodeENS.TitleStyleName; //标题类型名
objvViewInfo4GeneCodeENT.DGStyleId = objvViewInfo4GeneCodeENS.DGStyleId; //DG模式ID
objvViewInfo4GeneCodeENT.DGStyleName = objvViewInfo4GeneCodeENS.DGStyleName; //DG模式名
objvViewInfo4GeneCodeENT.Version_GeneCode = objvViewInfo4GeneCodeENS.Version_GeneCode; //生成代码版本
objvViewInfo4GeneCodeENT.ViewName = objvViewInfo4GeneCodeENS.ViewName; //界面名称
objvViewInfo4GeneCodeENT.ViewTypeCode = objvViewInfo4GeneCodeENS.ViewTypeCode; //界面类型码
objvViewInfo4GeneCodeENT.ViewTypeName = objvViewInfo4GeneCodeENS.ViewTypeName; //界面类型名称
objvViewInfo4GeneCodeENT.ApplicationTypeId = objvViewInfo4GeneCodeENS.ApplicationTypeId; //应用程序类型ID
objvViewInfo4GeneCodeENT.ApplicationTypeName = objvViewInfo4GeneCodeENS.ApplicationTypeName; //应用程序类型名称
objvViewInfo4GeneCodeENT.FuncModuleAgcId = objvViewInfo4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvViewInfo4GeneCodeENT.FuncModuleName = objvViewInfo4GeneCodeENS.FuncModuleName; //功能模块名称
objvViewInfo4GeneCodeENT.FuncModuleEnName = objvViewInfo4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvViewInfo4GeneCodeENT.DataBaseName = objvViewInfo4GeneCodeENS.DataBaseName; //数据库名
objvViewInfo4GeneCodeENT.KeyForMainTab = objvViewInfo4GeneCodeENS.KeyForMainTab; //主表关键字
objvViewInfo4GeneCodeENT.KeyForDetailTab = objvViewInfo4GeneCodeENS.KeyForDetailTab; //明细表关键字
objvViewInfo4GeneCodeENT.IsNeedSort = objvViewInfo4GeneCodeENS.IsNeedSort; //是否需要排序
objvViewInfo4GeneCodeENT.IsNeedTransCode = objvViewInfo4GeneCodeENS.IsNeedTransCode; //是否需要转换代码
objvViewInfo4GeneCodeENT.UserId = objvViewInfo4GeneCodeENS.UserId; //用户Id
objvViewInfo4GeneCodeENT.PrjId = objvViewInfo4GeneCodeENS.PrjId; //工程ID
objvViewInfo4GeneCodeENT.PrjName = objvViewInfo4GeneCodeENS.PrjName; //工程名称
objvViewInfo4GeneCodeENT.ViewFunction = objvViewInfo4GeneCodeENS.ViewFunction; //界面功能
objvViewInfo4GeneCodeENT.ViewDetail = objvViewInfo4GeneCodeENS.ViewDetail; //界面说明
objvViewInfo4GeneCodeENT.DefaMenuName = objvViewInfo4GeneCodeENS.DefaMenuName; //缺省菜单名
objvViewInfo4GeneCodeENT.DetailTabId = objvViewInfo4GeneCodeENS.DetailTabId; //明细表ID
objvViewInfo4GeneCodeENT.FileName = objvViewInfo4GeneCodeENS.FileName; //文件名
objvViewInfo4GeneCodeENT.FilePath = objvViewInfo4GeneCodeENS.FilePath; //文件路径
objvViewInfo4GeneCodeENT.MainTabId = objvViewInfo4GeneCodeENS.MainTabId; //主表ID
objvViewInfo4GeneCodeENT.ViewCnName = objvViewInfo4GeneCodeENS.ViewCnName; //视图中文名
objvViewInfo4GeneCodeENT.ViewGroupId = objvViewInfo4GeneCodeENS.ViewGroupId; //界面组ID
objvViewInfo4GeneCodeENT.ViewGroupName = objvViewInfo4GeneCodeENS.ViewGroupName; //界面组名称
objvViewInfo4GeneCodeENT.INSQLDSTypeId = objvViewInfo4GeneCodeENS.INSQLDSTypeId; //输入数据源类型
objvViewInfo4GeneCodeENT.OUTSQLDSTypeId = objvViewInfo4GeneCodeENS.OUTSQLDSTypeId; //输出数据源类型
objvViewInfo4GeneCodeENT.GeneCodeDate = objvViewInfo4GeneCodeENS.GeneCodeDate; //生成代码日期
objvViewInfo4GeneCodeENT.RegionNum = objvViewInfo4GeneCodeENS.RegionNum; //区域数
objvViewInfo4GeneCodeENT.UpdDate = objvViewInfo4GeneCodeENS.UpdDate; //修改日期
objvViewInfo4GeneCodeENT.MainTabName = objvViewInfo4GeneCodeENS.MainTabName; //主表
objvViewInfo4GeneCodeENT.DetailTabName = objvViewInfo4GeneCodeENS.DetailTabName; //详细表
objvViewInfo4GeneCodeENT.MainTabKeyFld = objvViewInfo4GeneCodeENS.MainTabKeyFld; //MainTabKeyFld
objvViewInfo4GeneCodeENT.DetailTabKeyFld = objvViewInfo4GeneCodeENS.DetailTabKeyFld; //DetailTabKeyFld
objvViewInfo4GeneCodeENT.UserId4GeneCode = objvViewInfo4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
objvViewInfo4GeneCodeENT.sf_UpdFldSetStr = objvViewInfo4GeneCodeENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewInfo4GeneCodeENT.sf_FldComparisonOp = objvViewInfo4GeneCodeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvViewInfo4GeneCodeENT;
}
return clsvViewInfo4GeneCodeBL;
}());
exports.clsvViewInfo4GeneCodeBL = clsvViewInfo4GeneCodeBL;
});