
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfoBL
 表名:vViewInfo(00050157)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:48
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面管理
 模块英文名:PrjInterface
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsvViewInfoEN.js","../../L0_Entity/PrjInterface/clsvViewInfoEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvViewInfoEN_js_1 = require("../../L0_Entity/PrjInterface/clsvViewInfoEN.js");
var clsvViewInfoEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsvViewInfoEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v界面(vViewInfo)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvViewInfoBL = /** @class */ (function () {
function clsvViewInfoBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvViewInfoObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024948
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewInfoBL.GetJSONStrByObj  = function(pobjvViewInfoEN)
{
pobjvViewInfoEN.sf_UpdFldSetStr = pobjvViewInfoEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvViewInfoEN);
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
 /// 日期:20200501024948
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvViewInfoBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvViewInfoObjLst = new Array();
if (strJSON === "")
{
return arrvViewInfoObjLst;
}
try
{
arrvViewInfoObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvViewInfoObjLst;
}
return arrvViewInfoObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024948
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvViewInfoBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvViewInfoEN = new clsvViewInfoEN();
if (strJSON === "")
{
return pobjvViewInfoEN;
}
try
{
pobjvViewInfoEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvViewInfoEN;
}
return pobjvViewInfoEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvViewInfoENS">源对象</param>
 /// <param name = "objvViewInfoENT">目标对象</param>
clsvViewInfoBL.CopyObjToSimObj = function(objvViewInfoENS , objvViewInfoENT ) 
{
objvViewInfoENT.ViewId = objvViewInfoENS.ViewId; //界面Id
objvViewInfoENT.TitleStyleId = objvViewInfoENS.TitleStyleId; //标题类型Id
objvViewInfoENT.TitleStyleName = objvViewInfoENS.TitleStyleName; //标题类型名
objvViewInfoENT.DGStyleId = objvViewInfoENS.DGStyleId; //DG模式ID
objvViewInfoENT.DGStyleName = objvViewInfoENS.DGStyleName; //DG模式名
objvViewInfoENT.ViewName = objvViewInfoENS.ViewName; //界面名称
objvViewInfoENT.ViewTypeCode = objvViewInfoENS.ViewTypeCode; //界面类型码
objvViewInfoENT.ViewTypeName = objvViewInfoENS.ViewTypeName; //界面类型名称
objvViewInfoENT.ApplicationTypeId = objvViewInfoENS.ApplicationTypeId; //应用程序类型ID
objvViewInfoENT.FuncModuleAgcId = objvViewInfoENS.FuncModuleAgcId; //功能模块Id
objvViewInfoENT.FuncModuleName = objvViewInfoENS.FuncModuleName; //功能模块名称
objvViewInfoENT.FuncModuleEnName = objvViewInfoENS.FuncModuleEnName; //功能模块英文名称
objvViewInfoENT.DataBaseName = objvViewInfoENS.DataBaseName; //数据库名
objvViewInfoENT.KeyForMainTab = objvViewInfoENS.KeyForMainTab; //主表关键字
objvViewInfoENT.KeyForDetailTab = objvViewInfoENS.KeyForDetailTab; //明细表关键字
objvViewInfoENT.IsNeedSort = objvViewInfoENS.IsNeedSort; //是否需要排序
objvViewInfoENT.IsNeedTransCode = objvViewInfoENS.IsNeedTransCode; //是否需要转换代码
objvViewInfoENT.IsNeedSetExportFld = objvViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objvViewInfoENT.UserId = objvViewInfoENS.UserId; //用户Id
objvViewInfoENT.PrjId = objvViewInfoENS.PrjId; //工程ID
objvViewInfoENT.PrjName = objvViewInfoENS.PrjName; //工程名称
objvViewInfoENT.ViewFunction = objvViewInfoENS.ViewFunction; //界面功能
objvViewInfoENT.ViewDetail = objvViewInfoENS.ViewDetail; //界面说明
objvViewInfoENT.DefaMenuName = objvViewInfoENS.DefaMenuName; //缺省菜单名
objvViewInfoENT.DetailTabId = objvViewInfoENS.DetailTabId; //明细表ID
objvViewInfoENT.FileName = objvViewInfoENS.FileName; //文件名
objvViewInfoENT.FilePath = objvViewInfoENS.FilePath; //文件路径
objvViewInfoENT.MainTabId = objvViewInfoENS.MainTabId; //主表ID
objvViewInfoENT.ViewCnName = objvViewInfoENS.ViewCnName; //视图中文名
objvViewInfoENT.ViewGroupId = objvViewInfoENS.ViewGroupId; //界面组ID
objvViewInfoENT.ViewGroupName = objvViewInfoENS.ViewGroupName; //界面组名称
objvViewInfoENT.INSQLDSTypeId = objvViewInfoENS.INSQLDSTypeId; //输入数据源类型
objvViewInfoENT.OUTSQLDSTypeId = objvViewInfoENS.OUTSQLDSTypeId; //输出数据源类型
objvViewInfoENT.IsUseCache4List = objvViewInfoENS.IsUseCache4List; //是否使用缓存列表
objvViewInfoENT.GeneCodeDate = objvViewInfoENS.GeneCodeDate; //生成代码日期
objvViewInfoENT.TaskId = objvViewInfoENS.TaskId; //任务Id
objvViewInfoENT.RegionNum = objvViewInfoENS.RegionNum; //区域数
objvViewInfoENT.UpdDate = objvViewInfoENS.UpdDate; //修改日期
objvViewInfoENT.UpdUserId = objvViewInfoENS.UpdUserId; //修改用户Id
objvViewInfoENT.Memo = objvViewInfoENS.Memo; //说明
objvViewInfoENT.MainTabName = objvViewInfoENS.MainTabName; //主表
objvViewInfoENT.DetailTabName = objvViewInfoENS.DetailTabName; //详细表
objvViewInfoENT.MainTabKeyFld = objvViewInfoENS.MainTabKeyFld; //MainTabKeyFld
objvViewInfoENT.DetailTabKeyFld = objvViewInfoENS.DetailTabKeyFld; //DetailTabKeyFld
objvViewInfoENT.ApplicationTypeSimName = objvViewInfoENS.ApplicationTypeSimName; //应用程序类型简称
objvViewInfoENT.sf_UpdFldSetStr = objvViewInfoENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewInfoENT.sf_FldComparisonOp = objvViewInfoENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvViewInfoENS">源对象</param>
 /// <param name = "objvViewInfoENT">目标对象</param>
clsvViewInfoBL.GetSimObjFromObj = function(objvViewInfoENS)
{
var objvViewInfoENT = new clsvViewInfoEN_Sim_js_1.clsvViewInfoEN_Sim();
objvViewInfoENT.ViewId = objvViewInfoENS.ViewId; //界面Id
objvViewInfoENT.TitleStyleId = objvViewInfoENS.TitleStyleId; //标题类型Id
objvViewInfoENT.TitleStyleName = objvViewInfoENS.TitleStyleName; //标题类型名
objvViewInfoENT.DGStyleId = objvViewInfoENS.DGStyleId; //DG模式ID
objvViewInfoENT.DGStyleName = objvViewInfoENS.DGStyleName; //DG模式名
objvViewInfoENT.ViewName = objvViewInfoENS.ViewName; //界面名称
objvViewInfoENT.ViewTypeCode = objvViewInfoENS.ViewTypeCode; //界面类型码
objvViewInfoENT.ViewTypeName = objvViewInfoENS.ViewTypeName; //界面类型名称
objvViewInfoENT.ApplicationTypeId = objvViewInfoENS.ApplicationTypeId; //应用程序类型ID
objvViewInfoENT.FuncModuleAgcId = objvViewInfoENS.FuncModuleAgcId; //功能模块Id
objvViewInfoENT.FuncModuleName = objvViewInfoENS.FuncModuleName; //功能模块名称
objvViewInfoENT.FuncModuleEnName = objvViewInfoENS.FuncModuleEnName; //功能模块英文名称
objvViewInfoENT.DataBaseName = objvViewInfoENS.DataBaseName; //数据库名
objvViewInfoENT.KeyForMainTab = objvViewInfoENS.KeyForMainTab; //主表关键字
objvViewInfoENT.KeyForDetailTab = objvViewInfoENS.KeyForDetailTab; //明细表关键字
objvViewInfoENT.IsNeedSort = objvViewInfoENS.IsNeedSort; //是否需要排序
objvViewInfoENT.IsNeedTransCode = objvViewInfoENS.IsNeedTransCode; //是否需要转换代码
objvViewInfoENT.IsNeedSetExportFld = objvViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objvViewInfoENT.UserId = objvViewInfoENS.UserId; //用户Id
objvViewInfoENT.PrjId = objvViewInfoENS.PrjId; //工程ID
objvViewInfoENT.PrjName = objvViewInfoENS.PrjName; //工程名称
objvViewInfoENT.ViewFunction = objvViewInfoENS.ViewFunction; //界面功能
objvViewInfoENT.ViewDetail = objvViewInfoENS.ViewDetail; //界面说明
objvViewInfoENT.DefaMenuName = objvViewInfoENS.DefaMenuName; //缺省菜单名
objvViewInfoENT.DetailTabId = objvViewInfoENS.DetailTabId; //明细表ID
objvViewInfoENT.FileName = objvViewInfoENS.FileName; //文件名
objvViewInfoENT.FilePath = objvViewInfoENS.FilePath; //文件路径
objvViewInfoENT.MainTabId = objvViewInfoENS.MainTabId; //主表ID
objvViewInfoENT.ViewCnName = objvViewInfoENS.ViewCnName; //视图中文名
objvViewInfoENT.ViewGroupId = objvViewInfoENS.ViewGroupId; //界面组ID
objvViewInfoENT.ViewGroupName = objvViewInfoENS.ViewGroupName; //界面组名称
objvViewInfoENT.INSQLDSTypeId = objvViewInfoENS.INSQLDSTypeId; //输入数据源类型
objvViewInfoENT.OUTSQLDSTypeId = objvViewInfoENS.OUTSQLDSTypeId; //输出数据源类型
objvViewInfoENT.IsUseCache4List = objvViewInfoENS.IsUseCache4List; //是否使用缓存列表
objvViewInfoENT.GeneCodeDate = objvViewInfoENS.GeneCodeDate; //生成代码日期
objvViewInfoENT.TaskId = objvViewInfoENS.TaskId; //任务Id
objvViewInfoENT.RegionNum = objvViewInfoENS.RegionNum; //区域数
objvViewInfoENT.UpdDate = objvViewInfoENS.UpdDate; //修改日期
objvViewInfoENT.UpdUserId = objvViewInfoENS.UpdUserId; //修改用户Id
objvViewInfoENT.Memo = objvViewInfoENS.Memo; //说明
objvViewInfoENT.MainTabName = objvViewInfoENS.MainTabName; //主表
objvViewInfoENT.DetailTabName = objvViewInfoENS.DetailTabName; //详细表
objvViewInfoENT.MainTabKeyFld = objvViewInfoENS.MainTabKeyFld; //MainTabKeyFld
objvViewInfoENT.DetailTabKeyFld = objvViewInfoENS.DetailTabKeyFld; //DetailTabKeyFld
objvViewInfoENT.ApplicationTypeSimName = objvViewInfoENS.ApplicationTypeSimName; //应用程序类型简称
objvViewInfoENT.sf_UpdFldSetStr = objvViewInfoENS.UpdFldString; //专门用于记录某字段属性是否修改
objvViewInfoENT.sf_FldComparisonOp = objvViewInfoENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvViewInfoENT;
}
return clsvViewInfoBL;
}());
exports.clsvViewInfoBL = clsvViewInfoBL;
});