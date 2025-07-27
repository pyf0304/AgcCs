
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTabBL
 表名:vFieldTab(00050119)
 生成代码版本:2020.04.24.1
 生成日期:2020/04/30 12:06:05
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
define(["require", "exports", "jquery", "../../L0_Entity/Table_Field/clsvFieldTabEN.js","../../L0_Entity/Table_Field/clsvFieldTabEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvFieldTabEN_js_1 = require("../../L0_Entity/Table_Field/clsvFieldTabEN.js");
var clsvFieldTabEN_Sim_js_1 = require("../../L0_Entity/Table_Field/clsvFieldTabEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v工程字段(vFieldTab)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvFieldTabBL = /** @class */ (function () {
function clsvFieldTabBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvFieldTabObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200430120605
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvFieldTabBL.GetJSONStrByObj  = function(pobjvFieldTabEN)
{
pobjvFieldTabEN.sf_UpdFldSetStr = pobjvFieldTabEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvFieldTabEN);
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
 /// 日期:20200430120605
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvFieldTabBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvFieldTabObjLst = new Array();
if (strJSON === "")
{
return arrvFieldTabObjLst;
}
try
{
arrvFieldTabObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvFieldTabObjLst;
}
return arrvFieldTabObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200430120605
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvFieldTabBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvFieldTabEN = new clsvFieldTabEN();
if (strJSON === "")
{
return pobjvFieldTabEN;
}
try
{
pobjvFieldTabEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvFieldTabEN;
}
return pobjvFieldTabEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvFieldTabENS">源对象</param>
 /// <param name = "objvFieldTabENT">目标对象</param>
clsvFieldTabBL.CopyObjToSimObj = function(objvFieldTabENS , objvFieldTabENT ) 
{
objvFieldTabENT.FldId = objvFieldTabENS.FldId; //字段Id
objvFieldTabENT.TabNum = objvFieldTabENS.TabNum; //TabNum
objvFieldTabENT.PrjId = objvFieldTabENS.PrjId; //工程ID
objvFieldTabENT.PrjName = objvFieldTabENS.PrjName; //工程名称
objvFieldTabENT.FldName = objvFieldTabENS.FldName; //字段名
objvFieldTabENT.FldCnName = objvFieldTabENS.FldCnName; //字段中文详名
objvFieldTabENT.FldEnName = objvFieldTabENS.FldEnName; //字段英文详名
objvFieldTabENT.FldName_B = objvFieldTabENS.FldName_B; //字段名_后备
objvFieldTabENT.FldName_G = objvFieldTabENS.FldName_G; //字段名_国标
objvFieldTabENT.Caption = objvFieldTabENS.Caption; //标题
objvFieldTabENT.FieldTypeId = objvFieldTabENS.FieldTypeId; //字段类型Id
objvFieldTabENT.FieldTypeName = objvFieldTabENS.FieldTypeName; //字段类型名
objvFieldTabENT.FieldTypeENName = objvFieldTabENS.FieldTypeENName; //字段类型英文名
objvFieldTabENT.DataTypeId = objvFieldTabENS.DataTypeId; //数据类型Id
objvFieldTabENT.DataTypeName = objvFieldTabENS.DataTypeName; //数据类型名称
objvFieldTabENT.OraDbType = objvFieldTabENS.OraDbType; //Ora数据类型
objvFieldTabENT.FldLength = objvFieldTabENS.FldLength; //字段长度
objvFieldTabENT.FldPrecision = objvFieldTabENS.FldPrecision; //精确度
objvFieldTabENT.FldInfo = objvFieldTabENS.FldInfo; //字段信息
objvFieldTabENT.IsNull = objvFieldTabENS.IsNull; //是否可空
objvFieldTabENT.IsPrimaryKey = objvFieldTabENS.IsPrimaryKey; //是否主键
objvFieldTabENT.IsIdentity = objvFieldTabENS.IsIdentity; //是否Identity
objvFieldTabENT.IsNationStandard = objvFieldTabENS.IsNationStandard; //是否国标
objvFieldTabENT.IsChecked = objvFieldTabENS.IsChecked; //是否核实
objvFieldTabENT.IsArchive = objvFieldTabENS.IsArchive; //是否存档
objvFieldTabENT.IsOnlyOne = objvFieldTabENS.IsOnlyOne; //是否唯一
objvFieldTabENT.MaxValue = objvFieldTabENS.MaxValue; //最大值
objvFieldTabENT.MinValue = objvFieldTabENS.MinValue; //最小值
objvFieldTabENT.DefaultValue = objvFieldTabENS.DefaultValue; //缺省值
objvFieldTabENT.IsNeedTransCode = objvFieldTabENS.IsNeedTransCode; //是否需要转换代码
objvFieldTabENT.AppliedScope = objvFieldTabENS.AppliedScope; //应用范围
objvFieldTabENT.FldStateId = objvFieldTabENS.FldStateId; //字段状态Id
objvFieldTabENT.CodeTabId = objvFieldTabENS.CodeTabId; //CodeTabId
objvFieldTabENT.CodeTab_NameId = objvFieldTabENS.CodeTab_NameId; //CodeTab_NameId
objvFieldTabENT.CodeTab_CodeId = objvFieldTabENS.CodeTab_CodeId; //CodeTab_CodeId
objvFieldTabENT.IsRootFld = objvFieldTabENS.IsRootFld; //是否根字段
objvFieldTabENT.RootFldId = objvFieldTabENS.RootFldId; //根字段Id
objvFieldTabENT.UpdDate = objvFieldTabENS.UpdDate; //修改日期
objvFieldTabENT.UpdUser = objvFieldTabENS.UpdUser; //修改者
objvFieldTabENT.Memo = objvFieldTabENS.Memo; //说明
objvFieldTabENT.CodeTab = objvFieldTabENS.CodeTab; //代码表
objvFieldTabENT.CodeTab_Name = objvFieldTabENS.CodeTab_Name; //代码表_名称
objvFieldTabENT.CodeTab_Code = objvFieldTabENS.CodeTab_Code; //代码表_代码
objvFieldTabENT.FldBName_B = objvFieldTabENS.FldBName_B; //FldBName_B
objvFieldTabENT.sf_UpdFldSetStr = objvFieldTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objvFieldTabENT.sf_FldComparisonOp = objvFieldTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvFieldTabENS">源对象</param>
 /// <param name = "objvFieldTabENT">目标对象</param>
clsvFieldTabBL.GetSimObjFromObj = function(objvFieldTabENS)
{
var objvFieldTabENT = new clsvFieldTabEN_Sim_js_1.clsvFieldTabEN_Sim();
objvFieldTabENT.FldId = objvFieldTabENS.FldId; //字段Id
objvFieldTabENT.TabNum = objvFieldTabENS.TabNum; //TabNum
objvFieldTabENT.PrjId = objvFieldTabENS.PrjId; //工程ID
objvFieldTabENT.PrjName = objvFieldTabENS.PrjName; //工程名称
objvFieldTabENT.FldName = objvFieldTabENS.FldName; //字段名
objvFieldTabENT.FldCnName = objvFieldTabENS.FldCnName; //字段中文详名
objvFieldTabENT.FldEnName = objvFieldTabENS.FldEnName; //字段英文详名
objvFieldTabENT.FldName_B = objvFieldTabENS.FldName_B; //字段名_后备
objvFieldTabENT.FldName_G = objvFieldTabENS.FldName_G; //字段名_国标
objvFieldTabENT.Caption = objvFieldTabENS.Caption; //标题
objvFieldTabENT.FieldTypeId = objvFieldTabENS.FieldTypeId; //字段类型Id
objvFieldTabENT.FieldTypeName = objvFieldTabENS.FieldTypeName; //字段类型名
objvFieldTabENT.FieldTypeENName = objvFieldTabENS.FieldTypeENName; //字段类型英文名
objvFieldTabENT.DataTypeId = objvFieldTabENS.DataTypeId; //数据类型Id
objvFieldTabENT.DataTypeName = objvFieldTabENS.DataTypeName; //数据类型名称
objvFieldTabENT.OraDbType = objvFieldTabENS.OraDbType; //Ora数据类型
objvFieldTabENT.FldLength = objvFieldTabENS.FldLength; //字段长度
objvFieldTabENT.FldPrecision = objvFieldTabENS.FldPrecision; //精确度
objvFieldTabENT.FldInfo = objvFieldTabENS.FldInfo; //字段信息
objvFieldTabENT.IsNull = objvFieldTabENS.IsNull; //是否可空
objvFieldTabENT.IsPrimaryKey = objvFieldTabENS.IsPrimaryKey; //是否主键
objvFieldTabENT.IsIdentity = objvFieldTabENS.IsIdentity; //是否Identity
objvFieldTabENT.IsNationStandard = objvFieldTabENS.IsNationStandard; //是否国标
objvFieldTabENT.IsChecked = objvFieldTabENS.IsChecked; //是否核实
objvFieldTabENT.IsArchive = objvFieldTabENS.IsArchive; //是否存档
objvFieldTabENT.IsOnlyOne = objvFieldTabENS.IsOnlyOne; //是否唯一
objvFieldTabENT.MaxValue = objvFieldTabENS.MaxValue; //最大值
objvFieldTabENT.MinValue = objvFieldTabENS.MinValue; //最小值
objvFieldTabENT.DefaultValue = objvFieldTabENS.DefaultValue; //缺省值
objvFieldTabENT.IsNeedTransCode = objvFieldTabENS.IsNeedTransCode; //是否需要转换代码
objvFieldTabENT.AppliedScope = objvFieldTabENS.AppliedScope; //应用范围
objvFieldTabENT.FldStateId = objvFieldTabENS.FldStateId; //字段状态Id
objvFieldTabENT.CodeTabId = objvFieldTabENS.CodeTabId; //CodeTabId
objvFieldTabENT.CodeTab_NameId = objvFieldTabENS.CodeTab_NameId; //CodeTab_NameId
objvFieldTabENT.CodeTab_CodeId = objvFieldTabENS.CodeTab_CodeId; //CodeTab_CodeId
objvFieldTabENT.IsRootFld = objvFieldTabENS.IsRootFld; //是否根字段
objvFieldTabENT.RootFldId = objvFieldTabENS.RootFldId; //根字段Id
objvFieldTabENT.UpdDate = objvFieldTabENS.UpdDate; //修改日期
objvFieldTabENT.UpdUser = objvFieldTabENS.UpdUser; //修改者
objvFieldTabENT.Memo = objvFieldTabENS.Memo; //说明
objvFieldTabENT.CodeTab = objvFieldTabENS.CodeTab; //代码表
objvFieldTabENT.CodeTab_Name = objvFieldTabENS.CodeTab_Name; //代码表_名称
objvFieldTabENT.CodeTab_Code = objvFieldTabENS.CodeTab_Code; //代码表_代码
objvFieldTabENT.FldBName_B = objvFieldTabENS.FldBName_B; //FldBName_B
objvFieldTabENT.sf_UpdFldSetStr = objvFieldTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objvFieldTabENT.sf_FldComparisonOp = objvFieldTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvFieldTabENT;
}
return clsvFieldTabBL;
}());
exports.clsvFieldTabBL = clsvFieldTabBL;
});