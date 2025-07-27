
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDGRegionFldsBL
 表名:vDGRegionFlds(00050201)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:43
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
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsvDGRegionFldsEN.js","../../L0_Entity/RegionManage/clsvDGRegionFldsEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvDGRegionFldsEN_js_1 = require("../../L0_Entity/RegionManage/clsvDGRegionFldsEN.js");
var clsvDGRegionFldsEN_Sim_js_1 = require("../../L0_Entity/RegionManage/clsvDGRegionFldsEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// vDG区域字段(vDGRegionFlds)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvDGRegionFldsBL = /** @class */ (function () {
function clsvDGRegionFldsBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvDGRegionFldsObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024943
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvDGRegionFldsBL.GetJSONStrByObj  = function(pobjvDGRegionFldsEN)
{
pobjvDGRegionFldsEN.sf_UpdFldSetStr = pobjvDGRegionFldsEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvDGRegionFldsEN);
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
 /// 日期:20200501024943
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvDGRegionFldsBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvDGRegionFldsObjLst = new Array();
if (strJSON === "")
{
return arrvDGRegionFldsObjLst;
}
try
{
arrvDGRegionFldsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvDGRegionFldsObjLst;
}
return arrvDGRegionFldsObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024943
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvDGRegionFldsBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvDGRegionFldsEN = new clsvDGRegionFldsEN();
if (strJSON === "")
{
return pobjvDGRegionFldsEN;
}
try
{
pobjvDGRegionFldsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvDGRegionFldsEN;
}
return pobjvDGRegionFldsEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvDGRegionFldsENS">源对象</param>
 /// <param name = "objvDGRegionFldsENT">目标对象</param>
clsvDGRegionFldsBL.CopyObjToSimObj = function(objvDGRegionFldsENS , objvDGRegionFldsENT ) 
{
objvDGRegionFldsENT.mId = objvDGRegionFldsENS.mId; //mId
objvDGRegionFldsENT.TabId = objvDGRegionFldsENS.TabId; //表ID
objvDGRegionFldsENT.TabName = objvDGRegionFldsENS.TabName; //表名
objvDGRegionFldsENT.FldId = objvDGRegionFldsENS.FldId; //字段Id
objvDGRegionFldsENT.FldName = objvDGRegionFldsENS.FldName; //字段名
objvDGRegionFldsENT.DataTypeName = objvDGRegionFldsENS.DataTypeName; //数据类型名称
objvDGRegionFldsENT.FldLength = objvDGRegionFldsENS.FldLength; //字段长度
objvDGRegionFldsENT.Caption = objvDGRegionFldsENS.Caption; //标题
objvDGRegionFldsENT.MaxValue = objvDGRegionFldsENS.MaxValue; //最大值
objvDGRegionFldsENT.MinValue = objvDGRegionFldsENS.MinValue; //最小值
objvDGRegionFldsENT.IsNeedTransCode = objvDGRegionFldsENS.IsNeedTransCode; //是否需要转换代码
objvDGRegionFldsENT.DataTypeId = objvDGRegionFldsENS.DataTypeId; //数据类型Id
objvDGRegionFldsENT.PrjId = objvDGRegionFldsENS.PrjId; //工程ID
objvDGRegionFldsENT.FieldTypeId = objvDGRegionFldsENS.FieldTypeId; //字段类型Id
objvDGRegionFldsENT.FieldTypeName = objvDGRegionFldsENS.FieldTypeName; //字段类型名
objvDGRegionFldsENT.IsTabNullable = objvDGRegionFldsENS.IsTabNullable; //是否表中可空
objvDGRegionFldsENT.IsTabForeignKey = objvDGRegionFldsENS.IsTabForeignKey; //是否表外键
objvDGRegionFldsENT.IsParentObj = objvDGRegionFldsENS.IsParentObj; //是否父对象
objvDGRegionFldsENT.PrimaryTypeId = objvDGRegionFldsENS.PrimaryTypeId; //主键类型ID
objvDGRegionFldsENT.PrimaryTypeName = objvDGRegionFldsENS.PrimaryTypeName; //主键类型名
objvDGRegionFldsENT.ForeignKeyTabId = objvDGRegionFldsENS.ForeignKeyTabId; //外键表ID
objvDGRegionFldsENT.SequenceNumber = objvDGRegionFldsENS.SequenceNumber; //顺序号
objvDGRegionFldsENT.ForeignTabName = objvDGRegionFldsENS.ForeignTabName; //外键表
objvDGRegionFldsENT.RegionId = objvDGRegionFldsENS.RegionId; //区域Id
objvDGRegionFldsENT.RegionName = objvDGRegionFldsENS.RegionName; //区域名称
objvDGRegionFldsENT.ViewId = objvDGRegionFldsENS.ViewId; //界面Id
objvDGRegionFldsENT.ViewName = objvDGRegionFldsENS.ViewName; //界面名称
objvDGRegionFldsENT.RegionTypeName = objvDGRegionFldsENS.RegionTypeName; //区域类型名称
objvDGRegionFldsENT.TabFldId = objvDGRegionFldsENS.TabFldId; //表字段ID
objvDGRegionFldsENT.ColIndex = objvDGRegionFldsENS.ColIndex; //列序号
objvDGRegionFldsENT.ColCaption = objvDGRegionFldsENS.ColCaption; //列标题
objvDGRegionFldsENT.CtlTypeId = objvDGRegionFldsENS.CtlTypeId; //控件类型号
objvDGRegionFldsENT.CtlTypeName = objvDGRegionFldsENS.CtlTypeName; //控件类型名
objvDGRegionFldsENT.CtlCnName = objvDGRegionFldsENS.CtlCnName; //控件类型中文名
objvDGRegionFldsENT.DgFuncTypeId = objvDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objvDGRegionFldsENT.DgFuncTypeName = objvDGRegionFldsENS.DgFuncTypeName; //Dg功能类型名
objvDGRegionFldsENT.IsNeedSort = objvDGRegionFldsENS.IsNeedSort; //是否需要排序
objvDGRegionFldsENT.IsTransToChkBox = objvDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objvDGRegionFldsENT.IsVisible = objvDGRegionFldsENS.IsVisible; //是否显示
objvDGRegionFldsENT.IsFuncFld = objvDGRegionFldsENS.IsFuncFld; //是否功能字段
objvDGRegionFldsENT.InUse = objvDGRegionFldsENS.InUse; //是否在用
objvDGRegionFldsENT.UpdUser = objvDGRegionFldsENS.UpdUser; //修改者
objvDGRegionFldsENT.UpdDate = objvDGRegionFldsENS.UpdDate; //修改日期
objvDGRegionFldsENT.Memo = objvDGRegionFldsENS.Memo; //说明
objvDGRegionFldsENT.sf_UpdFldSetStr = objvDGRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objvDGRegionFldsENT.sf_FldComparisonOp = objvDGRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvDGRegionFldsENS">源对象</param>
 /// <param name = "objvDGRegionFldsENT">目标对象</param>
clsvDGRegionFldsBL.GetSimObjFromObj = function(objvDGRegionFldsENS)
{
var objvDGRegionFldsENT = new clsvDGRegionFldsEN_Sim_js_1.clsvDGRegionFldsEN_Sim();
objvDGRegionFldsENT.mId = objvDGRegionFldsENS.mId; //mId
objvDGRegionFldsENT.TabId = objvDGRegionFldsENS.TabId; //表ID
objvDGRegionFldsENT.TabName = objvDGRegionFldsENS.TabName; //表名
objvDGRegionFldsENT.FldId = objvDGRegionFldsENS.FldId; //字段Id
objvDGRegionFldsENT.FldName = objvDGRegionFldsENS.FldName; //字段名
objvDGRegionFldsENT.DataTypeName = objvDGRegionFldsENS.DataTypeName; //数据类型名称
objvDGRegionFldsENT.FldLength = objvDGRegionFldsENS.FldLength; //字段长度
objvDGRegionFldsENT.Caption = objvDGRegionFldsENS.Caption; //标题
objvDGRegionFldsENT.MaxValue = objvDGRegionFldsENS.MaxValue; //最大值
objvDGRegionFldsENT.MinValue = objvDGRegionFldsENS.MinValue; //最小值
objvDGRegionFldsENT.IsNeedTransCode = objvDGRegionFldsENS.IsNeedTransCode; //是否需要转换代码
objvDGRegionFldsENT.DataTypeId = objvDGRegionFldsENS.DataTypeId; //数据类型Id
objvDGRegionFldsENT.PrjId = objvDGRegionFldsENS.PrjId; //工程ID
objvDGRegionFldsENT.FieldTypeId = objvDGRegionFldsENS.FieldTypeId; //字段类型Id
objvDGRegionFldsENT.FieldTypeName = objvDGRegionFldsENS.FieldTypeName; //字段类型名
objvDGRegionFldsENT.IsTabNullable = objvDGRegionFldsENS.IsTabNullable; //是否表中可空
objvDGRegionFldsENT.IsTabForeignKey = objvDGRegionFldsENS.IsTabForeignKey; //是否表外键
objvDGRegionFldsENT.IsParentObj = objvDGRegionFldsENS.IsParentObj; //是否父对象
objvDGRegionFldsENT.PrimaryTypeId = objvDGRegionFldsENS.PrimaryTypeId; //主键类型ID
objvDGRegionFldsENT.PrimaryTypeName = objvDGRegionFldsENS.PrimaryTypeName; //主键类型名
objvDGRegionFldsENT.ForeignKeyTabId = objvDGRegionFldsENS.ForeignKeyTabId; //外键表ID
objvDGRegionFldsENT.SequenceNumber = objvDGRegionFldsENS.SequenceNumber; //顺序号
objvDGRegionFldsENT.ForeignTabName = objvDGRegionFldsENS.ForeignTabName; //外键表
objvDGRegionFldsENT.RegionId = objvDGRegionFldsENS.RegionId; //区域Id
objvDGRegionFldsENT.RegionName = objvDGRegionFldsENS.RegionName; //区域名称
objvDGRegionFldsENT.ViewId = objvDGRegionFldsENS.ViewId; //界面Id
objvDGRegionFldsENT.ViewName = objvDGRegionFldsENS.ViewName; //界面名称
objvDGRegionFldsENT.RegionTypeName = objvDGRegionFldsENS.RegionTypeName; //区域类型名称
objvDGRegionFldsENT.TabFldId = objvDGRegionFldsENS.TabFldId; //表字段ID
objvDGRegionFldsENT.ColIndex = objvDGRegionFldsENS.ColIndex; //列序号
objvDGRegionFldsENT.ColCaption = objvDGRegionFldsENS.ColCaption; //列标题
objvDGRegionFldsENT.CtlTypeId = objvDGRegionFldsENS.CtlTypeId; //控件类型号
objvDGRegionFldsENT.CtlTypeName = objvDGRegionFldsENS.CtlTypeName; //控件类型名
objvDGRegionFldsENT.CtlCnName = objvDGRegionFldsENS.CtlCnName; //控件类型中文名
objvDGRegionFldsENT.DgFuncTypeId = objvDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objvDGRegionFldsENT.DgFuncTypeName = objvDGRegionFldsENS.DgFuncTypeName; //Dg功能类型名
objvDGRegionFldsENT.IsNeedSort = objvDGRegionFldsENS.IsNeedSort; //是否需要排序
objvDGRegionFldsENT.IsTransToChkBox = objvDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objvDGRegionFldsENT.IsVisible = objvDGRegionFldsENS.IsVisible; //是否显示
objvDGRegionFldsENT.IsFuncFld = objvDGRegionFldsENS.IsFuncFld; //是否功能字段
objvDGRegionFldsENT.InUse = objvDGRegionFldsENS.InUse; //是否在用
objvDGRegionFldsENT.UpdUser = objvDGRegionFldsENS.UpdUser; //修改者
objvDGRegionFldsENT.UpdDate = objvDGRegionFldsENS.UpdDate; //修改日期
objvDGRegionFldsENT.Memo = objvDGRegionFldsENS.Memo; //说明
objvDGRegionFldsENT.sf_UpdFldSetStr = objvDGRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objvDGRegionFldsENT.sf_FldComparisonOp = objvDGRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvDGRegionFldsENT;
}
return clsvDGRegionFldsBL;
}());
exports.clsvDGRegionFldsBL = clsvDGRegionFldsBL;
});