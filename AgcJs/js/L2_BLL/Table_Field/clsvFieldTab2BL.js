
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab2BL
 表名:vFieldTab2(00050120)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:06
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsvFieldTab2EN.js","../../L0_Entity/Table_Field/clsvFieldTab2EN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvFieldTab2EN_js_1 = require("../../L0_Entity/Table_Field/clsvFieldTab2EN.js");
var clsvFieldTab2EN_Sim_js_1 = require("../../L0_Entity/Table_Field/clsvFieldTab2EN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// vFieldTab2(vFieldTab2)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvFieldTab2BL = /** @class */ (function () {
function clsvFieldTab2BL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvFieldTab2ObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200430120606
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvFieldTab2BL.GetJSONStrByObj  = function(pobjvFieldTab2EN)
{
pobjvFieldTab2EN.sf_UpdFldSetStr = pobjvFieldTab2EN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvFieldTab2EN);
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
 /// 日期:20200430120606
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvFieldTab2BL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvFieldTab2ObjLst = new Array();
if (strJSON === "")
{
return arrvFieldTab2ObjLst;
}
try
{
arrvFieldTab2ObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvFieldTab2ObjLst;
}
return arrvFieldTab2ObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200430120606
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvFieldTab2BL.GetObjByJSONStr  = function(strJSON)
{
var pobjvFieldTab2EN = new clsvFieldTab2EN();
if (strJSON === "")
{
return pobjvFieldTab2EN;
}
try
{
pobjvFieldTab2EN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvFieldTab2EN;
}
return pobjvFieldTab2EN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvFieldTab2ENS">源对象</param>
 /// <param name = "objvFieldTab2ENT">目标对象</param>
clsvFieldTab2BL.CopyObjToSimObj = function(objvFieldTab2ENS , objvFieldTab2ENT ) 
{
objvFieldTab2ENT.DataTypeName = objvFieldTab2ENS.DataTypeName; //数据类型名称
objvFieldTab2ENT.FldId = objvFieldTab2ENS.FldId; //字段Id
objvFieldTab2ENT.PrjId = objvFieldTab2ENS.PrjId; //工程ID
objvFieldTab2ENT.PrjName = objvFieldTab2ENS.PrjName; //工程名称
objvFieldTab2ENT.FldName = objvFieldTab2ENS.FldName; //字段名
objvFieldTab2ENT.Caption = objvFieldTab2ENS.Caption; //标题
objvFieldTab2ENT.FldLength = objvFieldTab2ENS.FldLength; //字段长度
objvFieldTab2ENT.FldInfo = objvFieldTab2ENS.FldInfo; //字段信息
objvFieldTab2ENT.IsNull = objvFieldTab2ENS.IsNull; //是否可空
objvFieldTab2ENT.IsPrimaryKey = objvFieldTab2ENS.IsPrimaryKey; //是否主键
objvFieldTab2ENT.IsIdentity = objvFieldTab2ENS.IsIdentity; //是否Identity
objvFieldTab2ENT.IsChecked = objvFieldTab2ENS.IsChecked; //是否核实
objvFieldTab2ENT.IsOnlyOne = objvFieldTab2ENS.IsOnlyOne; //是否唯一
objvFieldTab2ENT.MaxValue = objvFieldTab2ENS.MaxValue; //最大值
objvFieldTab2ENT.MinValue = objvFieldTab2ENS.MinValue; //最小值
objvFieldTab2ENT.DefaultValue = objvFieldTab2ENS.DefaultValue; //缺省值
objvFieldTab2ENT.IsNeedTransCode = objvFieldTab2ENS.IsNeedTransCode; //是否需要转换代码
objvFieldTab2ENT.AppliedScope = objvFieldTab2ENS.AppliedScope; //应用范围
objvFieldTab2ENT.CodeTabId = objvFieldTab2ENS.CodeTabId; //CodeTabId
objvFieldTab2ENT.CodeTab_NameId = objvFieldTab2ENS.CodeTab_NameId; //CodeTab_NameId
objvFieldTab2ENT.CodeTab_CodeId = objvFieldTab2ENS.CodeTab_CodeId; //CodeTab_CodeId
objvFieldTab2ENT.UpdDate = objvFieldTab2ENS.UpdDate; //修改日期
objvFieldTab2ENT.UpdUser = objvFieldTab2ENS.UpdUser; //修改者
objvFieldTab2ENT.UserName = objvFieldTab2ENS.UserName; //用户名
objvFieldTab2ENT.sf_UpdFldSetStr = objvFieldTab2ENS.UpdFldString; //专门用于记录某字段属性是否修改
objvFieldTab2ENT.sf_FldComparisonOp = objvFieldTab2ENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvFieldTab2ENS">源对象</param>
 /// <param name = "objvFieldTab2ENT">目标对象</param>
clsvFieldTab2BL.GetSimObjFromObj = function(objvFieldTab2ENS)
{
var objvFieldTab2ENT = new clsvFieldTab2EN_Sim_js_1.clsvFieldTab2EN_Sim();
objvFieldTab2ENT.DataTypeName = objvFieldTab2ENS.DataTypeName; //数据类型名称
objvFieldTab2ENT.FldId = objvFieldTab2ENS.FldId; //字段Id
objvFieldTab2ENT.PrjId = objvFieldTab2ENS.PrjId; //工程ID
objvFieldTab2ENT.PrjName = objvFieldTab2ENS.PrjName; //工程名称
objvFieldTab2ENT.FldName = objvFieldTab2ENS.FldName; //字段名
objvFieldTab2ENT.Caption = objvFieldTab2ENS.Caption; //标题
objvFieldTab2ENT.FldLength = objvFieldTab2ENS.FldLength; //字段长度
objvFieldTab2ENT.FldInfo = objvFieldTab2ENS.FldInfo; //字段信息
objvFieldTab2ENT.IsNull = objvFieldTab2ENS.IsNull; //是否可空
objvFieldTab2ENT.IsPrimaryKey = objvFieldTab2ENS.IsPrimaryKey; //是否主键
objvFieldTab2ENT.IsIdentity = objvFieldTab2ENS.IsIdentity; //是否Identity
objvFieldTab2ENT.IsChecked = objvFieldTab2ENS.IsChecked; //是否核实
objvFieldTab2ENT.IsOnlyOne = objvFieldTab2ENS.IsOnlyOne; //是否唯一
objvFieldTab2ENT.MaxValue = objvFieldTab2ENS.MaxValue; //最大值
objvFieldTab2ENT.MinValue = objvFieldTab2ENS.MinValue; //最小值
objvFieldTab2ENT.DefaultValue = objvFieldTab2ENS.DefaultValue; //缺省值
objvFieldTab2ENT.IsNeedTransCode = objvFieldTab2ENS.IsNeedTransCode; //是否需要转换代码
objvFieldTab2ENT.AppliedScope = objvFieldTab2ENS.AppliedScope; //应用范围
objvFieldTab2ENT.CodeTabId = objvFieldTab2ENS.CodeTabId; //CodeTabId
objvFieldTab2ENT.CodeTab_NameId = objvFieldTab2ENS.CodeTab_NameId; //CodeTab_NameId
objvFieldTab2ENT.CodeTab_CodeId = objvFieldTab2ENS.CodeTab_CodeId; //CodeTab_CodeId
objvFieldTab2ENT.UpdDate = objvFieldTab2ENS.UpdDate; //修改日期
objvFieldTab2ENT.UpdUser = objvFieldTab2ENS.UpdUser; //修改者
objvFieldTab2ENT.UserName = objvFieldTab2ENS.UserName; //用户名
objvFieldTab2ENT.sf_UpdFldSetStr = objvFieldTab2ENS.UpdFldString; //专门用于记录某字段属性是否修改
objvFieldTab2ENT.sf_FldComparisonOp = objvFieldTab2ENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvFieldTab2ENT;
}
return clsvFieldTab2BL;
}());
exports.clsvFieldTab2BL = clsvFieldTab2BL;
});