
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPrjGrantBL
 表名:vUserPrjGrant(00050174)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:15
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:权限管理
 模块英文名:AuthorityManage
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
define(["require", "exports", "jquery", "../../L0_Entity/AuthorityManage/clsvUserPrjGrantEN.js","../../L0_Entity/AuthorityManage/clsvUserPrjGrantEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvUserPrjGrantEN_js_1 = require("../../L0_Entity/AuthorityManage/clsvUserPrjGrantEN.js");
var clsvUserPrjGrantEN_Sim_js_1 = require("../../L0_Entity/AuthorityManage/clsvUserPrjGrantEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// vUserPrjGrant(vUserPrjGrant)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvUserPrjGrantBL = /** @class */ (function () {
function clsvUserPrjGrantBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvUserPrjGrantObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024915
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvUserPrjGrantBL.GetJSONStrByObj  = function(pobjvUserPrjGrantEN)
{
pobjvUserPrjGrantEN.sf_UpdFldSetStr = pobjvUserPrjGrantEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvUserPrjGrantEN);
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
 /// 日期:20200501024915
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvUserPrjGrantBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvUserPrjGrantObjLst = new Array();
if (strJSON === "")
{
return arrvUserPrjGrantObjLst;
}
try
{
arrvUserPrjGrantObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvUserPrjGrantObjLst;
}
return arrvUserPrjGrantObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024915
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvUserPrjGrantBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvUserPrjGrantEN = new clsvUserPrjGrantEN();
if (strJSON === "")
{
return pobjvUserPrjGrantEN;
}
try
{
pobjvUserPrjGrantEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvUserPrjGrantEN;
}
return pobjvUserPrjGrantEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvUserPrjGrantENS">源对象</param>
 /// <param name = "objvUserPrjGrantENT">目标对象</param>
clsvUserPrjGrantBL.CopyObjToSimObj = function(objvUserPrjGrantENS , objvUserPrjGrantENT ) 
{
objvUserPrjGrantENT.mId = objvUserPrjGrantENS.mId; //mId
objvUserPrjGrantENT.UserId = objvUserPrjGrantENS.UserId; //用户Id
objvUserPrjGrantENT.UserName = objvUserPrjGrantENS.UserName; //用户名
objvUserPrjGrantENT.UserStateName = objvUserPrjGrantENS.UserStateName; //用户状态名
objvUserPrjGrantENT.DepartmentId = objvUserPrjGrantENS.DepartmentId; //部门ID
objvUserPrjGrantENT.DepartmentName = objvUserPrjGrantENS.DepartmentName; //部门名称
objvUserPrjGrantENT.PrjId = objvUserPrjGrantENS.PrjId; //工程ID
objvUserPrjGrantENT.PrjName = objvUserPrjGrantENS.PrjName; //工程名称
objvUserPrjGrantENT.RoleId = objvUserPrjGrantENS.RoleId; //角色ID
objvUserPrjGrantENT.RoleName = objvUserPrjGrantENS.RoleName; //角色名称
objvUserPrjGrantENT.VisitedNum = objvUserPrjGrantENS.VisitedNum; //访问数
objvUserPrjGrantENT.LastVisitedDate = objvUserPrjGrantENS.LastVisitedDate; //最后访问时间
objvUserPrjGrantENT.OptId = objvUserPrjGrantENS.OptId; //操作者Id
objvUserPrjGrantENT.OptDate = objvUserPrjGrantENS.OptDate; //操作日期
objvUserPrjGrantENT.Memo = objvUserPrjGrantENS.Memo; //说明
objvUserPrjGrantENT.UseStateId = objvUserPrjGrantENS.UseStateId; //使用状态Id
objvUserPrjGrantENT.sf_UpdFldSetStr = objvUserPrjGrantENS.UpdFldString; //专门用于记录某字段属性是否修改
objvUserPrjGrantENT.sf_FldComparisonOp = objvUserPrjGrantENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvUserPrjGrantENS">源对象</param>
 /// <param name = "objvUserPrjGrantENT">目标对象</param>
clsvUserPrjGrantBL.GetSimObjFromObj = function(objvUserPrjGrantENS)
{
var objvUserPrjGrantENT = new clsvUserPrjGrantEN_Sim_js_1.clsvUserPrjGrantEN_Sim();
objvUserPrjGrantENT.mId = objvUserPrjGrantENS.mId; //mId
objvUserPrjGrantENT.UserId = objvUserPrjGrantENS.UserId; //用户Id
objvUserPrjGrantENT.UserName = objvUserPrjGrantENS.UserName; //用户名
objvUserPrjGrantENT.UserStateName = objvUserPrjGrantENS.UserStateName; //用户状态名
objvUserPrjGrantENT.DepartmentId = objvUserPrjGrantENS.DepartmentId; //部门ID
objvUserPrjGrantENT.DepartmentName = objvUserPrjGrantENS.DepartmentName; //部门名称
objvUserPrjGrantENT.PrjId = objvUserPrjGrantENS.PrjId; //工程ID
objvUserPrjGrantENT.PrjName = objvUserPrjGrantENS.PrjName; //工程名称
objvUserPrjGrantENT.RoleId = objvUserPrjGrantENS.RoleId; //角色ID
objvUserPrjGrantENT.RoleName = objvUserPrjGrantENS.RoleName; //角色名称
objvUserPrjGrantENT.VisitedNum = objvUserPrjGrantENS.VisitedNum; //访问数
objvUserPrjGrantENT.LastVisitedDate = objvUserPrjGrantENS.LastVisitedDate; //最后访问时间
objvUserPrjGrantENT.OptId = objvUserPrjGrantENS.OptId; //操作者Id
objvUserPrjGrantENT.OptDate = objvUserPrjGrantENS.OptDate; //操作日期
objvUserPrjGrantENT.Memo = objvUserPrjGrantENS.Memo; //说明
objvUserPrjGrantENT.UseStateId = objvUserPrjGrantENS.UseStateId; //使用状态Id
objvUserPrjGrantENT.sf_UpdFldSetStr = objvUserPrjGrantENS.UpdFldString; //专门用于记录某字段属性是否修改
objvUserPrjGrantENT.sf_FldComparisonOp = objvUserPrjGrantENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvUserPrjGrantENT;
}
return clsvUserPrjGrantBL;
}());
exports.clsvUserPrjGrantBL = clsvUserPrjGrantBL;
});