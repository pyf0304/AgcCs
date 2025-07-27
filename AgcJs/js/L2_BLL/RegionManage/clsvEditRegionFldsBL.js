
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEditRegionFldsBL
 表名:vEditRegionFlds(00050126)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:39
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
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsvEditRegionFldsEN.js","../../L0_Entity/RegionManage/clsvEditRegionFldsEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvEditRegionFldsEN_js_1 = require("../../L0_Entity/RegionManage/clsvEditRegionFldsEN.js");
var clsvEditRegionFldsEN_Sim_js_1 = require("../../L0_Entity/RegionManage/clsvEditRegionFldsEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v编辑区域字段(vEditRegionFlds)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvEditRegionFldsBL = /** @class */ (function () {
function clsvEditRegionFldsBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvEditRegionFldsObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024939
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvEditRegionFldsBL.GetJSONStrByObj  = function(pobjvEditRegionFldsEN)
{
pobjvEditRegionFldsEN.sf_UpdFldSetStr = pobjvEditRegionFldsEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvEditRegionFldsEN);
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
 /// 日期:20200501024939
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvEditRegionFldsBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvEditRegionFldsObjLst = new Array();
if (strJSON === "")
{
return arrvEditRegionFldsObjLst;
}
try
{
arrvEditRegionFldsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvEditRegionFldsObjLst;
}
return arrvEditRegionFldsObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024939
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvEditRegionFldsBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvEditRegionFldsEN = new clsvEditRegionFldsEN();
if (strJSON === "")
{
return pobjvEditRegionFldsEN;
}
try
{
pobjvEditRegionFldsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvEditRegionFldsEN;
}
return pobjvEditRegionFldsEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvEditRegionFldsENS">源对象</param>
 /// <param name = "objvEditRegionFldsENT">目标对象</param>
clsvEditRegionFldsBL.CopyObjToSimObj = function(objvEditRegionFldsENS , objvEditRegionFldsENT ) 
{
objvEditRegionFldsENT.mId = objvEditRegionFldsENS.mId; //mId
objvEditRegionFldsENT.TabId = objvEditRegionFldsENS.TabId; //表ID
objvEditRegionFldsENT.FldId = objvEditRegionFldsENS.FldId; //字段Id
objvEditRegionFldsENT.FldName = objvEditRegionFldsENS.FldName; //字段名
objvEditRegionFldsENT.DataTypeName = objvEditRegionFldsENS.DataTypeName; //数据类型名称
objvEditRegionFldsENT.FldLength = objvEditRegionFldsENS.FldLength; //字段长度
objvEditRegionFldsENT.DataTypeId = objvEditRegionFldsENS.DataTypeId; //数据类型Id
objvEditRegionFldsENT.FieldTypeId = objvEditRegionFldsENS.FieldTypeId; //字段类型Id
objvEditRegionFldsENT.FieldTypeName = objvEditRegionFldsENS.FieldTypeName; //字段类型名
objvEditRegionFldsENT.IsTabNullable = objvEditRegionFldsENS.IsTabNullable; //是否表中可空
objvEditRegionFldsENT.IsTabForeignKey = objvEditRegionFldsENS.IsTabForeignKey; //是否表外键
objvEditRegionFldsENT.IsParentObj = objvEditRegionFldsENS.IsParentObj; //是否父对象
objvEditRegionFldsENT.PrimaryTypeId = objvEditRegionFldsENS.PrimaryTypeId; //主键类型ID
objvEditRegionFldsENT.PrimaryTypeName = objvEditRegionFldsENS.PrimaryTypeName; //主键类型名
objvEditRegionFldsENT.ForeignKeyTabId = objvEditRegionFldsENS.ForeignKeyTabId; //外键表ID
objvEditRegionFldsENT.ForeignTabName = objvEditRegionFldsENS.ForeignTabName; //外键表
objvEditRegionFldsENT.RegionId = objvEditRegionFldsENS.RegionId; //区域Id
objvEditRegionFldsENT.ColNum = objvEditRegionFldsENS.ColNum; //列数
objvEditRegionFldsENT.IsUseCtrl = objvEditRegionFldsENS.IsUseCtrl; //是否使用控件
objvEditRegionFldsENT.ViewId = objvEditRegionFldsENS.ViewId; //界面Id
objvEditRegionFldsENT.RegionTypeId = objvEditRegionFldsENS.RegionTypeId; //区域类型Id
objvEditRegionFldsENT.RegionTypeName = objvEditRegionFldsENS.RegionTypeName; //区域类型名称
objvEditRegionFldsENT.TabFldId = objvEditRegionFldsENS.TabFldId; //表字段ID
objvEditRegionFldsENT.LabelCaption = objvEditRegionFldsENS.LabelCaption; //标签标题
objvEditRegionFldsENT.CtlTypeId = objvEditRegionFldsENS.CtlTypeId; //控件类型号
objvEditRegionFldsENT.CtlTypeName = objvEditRegionFldsENS.CtlTypeName; //控件类型名
objvEditRegionFldsENT.CtlCnName = objvEditRegionFldsENS.CtlCnName; //控件类型中文名
objvEditRegionFldsENT.CtlTypeAbbr = objvEditRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvEditRegionFldsENT.DDLItemsOptionId = objvEditRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objvEditRegionFldsENT.DDLItemsOptionName = objvEditRegionFldsENS.DDLItemsOptionName; //下拉选项名
objvEditRegionFldsENT.DS_TabId = objvEditRegionFldsENS.DS_TabId; //数据源表ID
objvEditRegionFldsENT.TabName = objvEditRegionFldsENS.TabName; //表名
objvEditRegionFldsENT.DS_DataValueFieldId = objvEditRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objvEditRegionFldsENT.DS_DataTextFieldId = objvEditRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objvEditRegionFldsENT.DS_CondStr = objvEditRegionFldsENS.DS_CondStr; //数据源条件串
objvEditRegionFldsENT.DS_SQLStr = objvEditRegionFldsENS.DS_SQLStr; //数据源SQL串
objvEditRegionFldsENT.ItemsString = objvEditRegionFldsENS.ItemsString; //列表项串
objvEditRegionFldsENT.ColSpan = objvEditRegionFldsENS.ColSpan; //跨列数
objvEditRegionFldsENT.ColIndex = objvEditRegionFldsENS.ColIndex; //列序号
objvEditRegionFldsENT.Width = objvEditRegionFldsENS.Width; //宽
objvEditRegionFldsENT.IsMultiRow = objvEditRegionFldsENS.IsMultiRow; //是否多行
objvEditRegionFldsENT.SeqNum = objvEditRegionFldsENS.SeqNum; //字段序号
objvEditRegionFldsENT.INOUTTypeId = objvEditRegionFldsENS.INOUTTypeId; //INOUT类型ID
objvEditRegionFldsENT.INOUTTypeName = objvEditRegionFldsENS.INOUTTypeName; //INOUT类型名称
objvEditRegionFldsENT.InUse = objvEditRegionFldsENS.InUse; //是否在用
objvEditRegionFldsENT.PrjId = objvEditRegionFldsENS.PrjId; //工程ID
objvEditRegionFldsENT.UpdUser = objvEditRegionFldsENS.UpdUser; //修改者
objvEditRegionFldsENT.UpdDate = objvEditRegionFldsENS.UpdDate; //修改日期
objvEditRegionFldsENT.Memo = objvEditRegionFldsENS.Memo; //说明
objvEditRegionFldsENT.DS_TabName = objvEditRegionFldsENS.DS_TabName; //数据源表
objvEditRegionFldsENT.DS_DataValueFieldName = objvEditRegionFldsENS.DS_DataValueFieldName; //数据源值字段
objvEditRegionFldsENT.DS_DataTextFieldName = objvEditRegionFldsENS.DS_DataTextFieldName; //数据源文本字段
objvEditRegionFldsENT.sf_UpdFldSetStr = objvEditRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objvEditRegionFldsENT.sf_FldComparisonOp = objvEditRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvEditRegionFldsENS">源对象</param>
 /// <param name = "objvEditRegionFldsENT">目标对象</param>
clsvEditRegionFldsBL.GetSimObjFromObj = function(objvEditRegionFldsENS)
{
var objvEditRegionFldsENT = new clsvEditRegionFldsEN_Sim_js_1.clsvEditRegionFldsEN_Sim();
objvEditRegionFldsENT.mId = objvEditRegionFldsENS.mId; //mId
objvEditRegionFldsENT.TabId = objvEditRegionFldsENS.TabId; //表ID
objvEditRegionFldsENT.FldId = objvEditRegionFldsENS.FldId; //字段Id
objvEditRegionFldsENT.FldName = objvEditRegionFldsENS.FldName; //字段名
objvEditRegionFldsENT.DataTypeName = objvEditRegionFldsENS.DataTypeName; //数据类型名称
objvEditRegionFldsENT.FldLength = objvEditRegionFldsENS.FldLength; //字段长度
objvEditRegionFldsENT.DataTypeId = objvEditRegionFldsENS.DataTypeId; //数据类型Id
objvEditRegionFldsENT.FieldTypeId = objvEditRegionFldsENS.FieldTypeId; //字段类型Id
objvEditRegionFldsENT.FieldTypeName = objvEditRegionFldsENS.FieldTypeName; //字段类型名
objvEditRegionFldsENT.IsTabNullable = objvEditRegionFldsENS.IsTabNullable; //是否表中可空
objvEditRegionFldsENT.IsTabForeignKey = objvEditRegionFldsENS.IsTabForeignKey; //是否表外键
objvEditRegionFldsENT.IsParentObj = objvEditRegionFldsENS.IsParentObj; //是否父对象
objvEditRegionFldsENT.PrimaryTypeId = objvEditRegionFldsENS.PrimaryTypeId; //主键类型ID
objvEditRegionFldsENT.PrimaryTypeName = objvEditRegionFldsENS.PrimaryTypeName; //主键类型名
objvEditRegionFldsENT.ForeignKeyTabId = objvEditRegionFldsENS.ForeignKeyTabId; //外键表ID
objvEditRegionFldsENT.ForeignTabName = objvEditRegionFldsENS.ForeignTabName; //外键表
objvEditRegionFldsENT.RegionId = objvEditRegionFldsENS.RegionId; //区域Id
objvEditRegionFldsENT.ColNum = objvEditRegionFldsENS.ColNum; //列数
objvEditRegionFldsENT.IsUseCtrl = objvEditRegionFldsENS.IsUseCtrl; //是否使用控件
objvEditRegionFldsENT.ViewId = objvEditRegionFldsENS.ViewId; //界面Id
objvEditRegionFldsENT.RegionTypeId = objvEditRegionFldsENS.RegionTypeId; //区域类型Id
objvEditRegionFldsENT.RegionTypeName = objvEditRegionFldsENS.RegionTypeName; //区域类型名称
objvEditRegionFldsENT.TabFldId = objvEditRegionFldsENS.TabFldId; //表字段ID
objvEditRegionFldsENT.LabelCaption = objvEditRegionFldsENS.LabelCaption; //标签标题
objvEditRegionFldsENT.CtlTypeId = objvEditRegionFldsENS.CtlTypeId; //控件类型号
objvEditRegionFldsENT.CtlTypeName = objvEditRegionFldsENS.CtlTypeName; //控件类型名
objvEditRegionFldsENT.CtlCnName = objvEditRegionFldsENS.CtlCnName; //控件类型中文名
objvEditRegionFldsENT.CtlTypeAbbr = objvEditRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvEditRegionFldsENT.DDLItemsOptionId = objvEditRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objvEditRegionFldsENT.DDLItemsOptionName = objvEditRegionFldsENS.DDLItemsOptionName; //下拉选项名
objvEditRegionFldsENT.DS_TabId = objvEditRegionFldsENS.DS_TabId; //数据源表ID
objvEditRegionFldsENT.TabName = objvEditRegionFldsENS.TabName; //表名
objvEditRegionFldsENT.DS_DataValueFieldId = objvEditRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objvEditRegionFldsENT.DS_DataTextFieldId = objvEditRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objvEditRegionFldsENT.DS_CondStr = objvEditRegionFldsENS.DS_CondStr; //数据源条件串
objvEditRegionFldsENT.DS_SQLStr = objvEditRegionFldsENS.DS_SQLStr; //数据源SQL串
objvEditRegionFldsENT.ItemsString = objvEditRegionFldsENS.ItemsString; //列表项串
objvEditRegionFldsENT.ColSpan = objvEditRegionFldsENS.ColSpan; //跨列数
objvEditRegionFldsENT.ColIndex = objvEditRegionFldsENS.ColIndex; //列序号
objvEditRegionFldsENT.Width = objvEditRegionFldsENS.Width; //宽
objvEditRegionFldsENT.IsMultiRow = objvEditRegionFldsENS.IsMultiRow; //是否多行
objvEditRegionFldsENT.SeqNum = objvEditRegionFldsENS.SeqNum; //字段序号
objvEditRegionFldsENT.INOUTTypeId = objvEditRegionFldsENS.INOUTTypeId; //INOUT类型ID
objvEditRegionFldsENT.INOUTTypeName = objvEditRegionFldsENS.INOUTTypeName; //INOUT类型名称
objvEditRegionFldsENT.InUse = objvEditRegionFldsENS.InUse; //是否在用
objvEditRegionFldsENT.PrjId = objvEditRegionFldsENS.PrjId; //工程ID
objvEditRegionFldsENT.UpdUser = objvEditRegionFldsENS.UpdUser; //修改者
objvEditRegionFldsENT.UpdDate = objvEditRegionFldsENS.UpdDate; //修改日期
objvEditRegionFldsENT.Memo = objvEditRegionFldsENS.Memo; //说明
objvEditRegionFldsENT.DS_TabName = objvEditRegionFldsENS.DS_TabName; //数据源表
objvEditRegionFldsENT.DS_DataValueFieldName = objvEditRegionFldsENS.DS_DataValueFieldName; //数据源值字段
objvEditRegionFldsENT.DS_DataTextFieldName = objvEditRegionFldsENS.DS_DataTextFieldName; //数据源文本字段
objvEditRegionFldsENT.sf_UpdFldSetStr = objvEditRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objvEditRegionFldsENT.sf_FldComparisonOp = objvEditRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvEditRegionFldsENT;
}
return clsvEditRegionFldsBL;
}());
exports.clsvEditRegionFldsBL = clsvEditRegionFldsBL;
});