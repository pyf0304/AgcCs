
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQryRegionFldsBL
 表名:vQryRegionFlds(00050151)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/05 02:47:42
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
define(["require", "exports", "jquery", "../../L0_Entity/RegionManage/clsvQryRegionFldsEN.js","../../L0_Entity/RegionManage/clsvQryRegionFldsEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsvQryRegionFldsEN_js_1 = require("../../L0_Entity/RegionManage/clsvQryRegionFldsEN.js");
var clsvQryRegionFldsEN_Sim_js_1 = require("../../L0_Entity/RegionManage/clsvQryRegionFldsEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// v查询区域字段(vQryRegionFlds)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsvQryRegionFldsBL = /** @class */ (function () {
function clsvQryRegionFldsBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrvQryRegionFldsObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200505024742
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvQryRegionFldsBL.GetJSONStrByObj  = function(pobjvQryRegionFldsEN)
{
pobjvQryRegionFldsEN.sf_UpdFldSetStr = pobjvQryRegionFldsEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvQryRegionFldsEN);
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
 /// 日期:20200505024742
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsvQryRegionFldsBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrvQryRegionFldsObjLst = new Array();
if (strJSON === "")
{
return arrvQryRegionFldsObjLst;
}
try
{
arrvQryRegionFldsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvQryRegionFldsObjLst;
}
return arrvQryRegionFldsObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200505024742
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsvQryRegionFldsBL.GetObjByJSONStr  = function(strJSON)
{
var pobjvQryRegionFldsEN = new clsvQryRegionFldsEN();
if (strJSON === "")
{
return pobjvQryRegionFldsEN;
}
try
{
pobjvQryRegionFldsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvQryRegionFldsEN;
}
return pobjvQryRegionFldsEN;
};

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objvQryRegionFldsENS">源对象</param>
 /// <param name = "objvQryRegionFldsENT">目标对象</param>
clsvQryRegionFldsBL.CopyObjToSimObj = function(objvQryRegionFldsENS , objvQryRegionFldsENT ) 
{
objvQryRegionFldsENT.mId = objvQryRegionFldsENS.mId; //mId
objvQryRegionFldsENT.FldId = objvQryRegionFldsENS.FldId; //字段Id
objvQryRegionFldsENT.FldName = objvQryRegionFldsENS.FldName; //字段名
objvQryRegionFldsENT.DataTypeName = objvQryRegionFldsENS.DataTypeName; //数据类型名称
objvQryRegionFldsENT.DataTypeId = objvQryRegionFldsENS.DataTypeId; //数据类型Id
objvQryRegionFldsENT.FieldTypeId = objvQryRegionFldsENS.FieldTypeId; //字段类型Id
objvQryRegionFldsENT.FieldTypeName = objvQryRegionFldsENS.FieldTypeName; //字段类型名
objvQryRegionFldsENT.RegionId = objvQryRegionFldsENS.RegionId; //区域Id
objvQryRegionFldsENT.RegionName = objvQryRegionFldsENS.RegionName; //区域名称
objvQryRegionFldsENT.ViewId = objvQryRegionFldsENS.ViewId; //界面Id
objvQryRegionFldsENT.ViewName = objvQryRegionFldsENS.ViewName; //界面名称
objvQryRegionFldsENT.TabFldId = objvQryRegionFldsENS.TabFldId; //表字段ID
objvQryRegionFldsENT.LabelCaption = objvQryRegionFldsENS.LabelCaption; //标签标题
objvQryRegionFldsENT.CtlTypeId = objvQryRegionFldsENS.CtlTypeId; //控件类型号
objvQryRegionFldsENT.CtlTypeName = objvQryRegionFldsENS.CtlTypeName; //控件类型名
objvQryRegionFldsENT.CtlCnName = objvQryRegionFldsENS.CtlCnName; //控件类型中文名
objvQryRegionFldsENT.CtlTypeAbbr = objvQryRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvQryRegionFldsENT.DS_TabId = objvQryRegionFldsENS.DS_TabId; //数据源表ID
objvQryRegionFldsENT.TabName = objvQryRegionFldsENS.TabName; //表名
objvQryRegionFldsENT.QueryOptionId = objvQryRegionFldsENS.QueryOptionId; //查询方式Id
objvQryRegionFldsENT.QueryOptionName = objvQryRegionFldsENS.QueryOptionName; //查询方式名称
objvQryRegionFldsENT.DDLItemsOptionId = objvQryRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objvQryRegionFldsENT.DDLItemsOptionName = objvQryRegionFldsENS.DDLItemsOptionName; //下拉选项名
objvQryRegionFldsENT.DS_SQLStr = objvQryRegionFldsENS.DS_SQLStr; //数据源SQL串
objvQryRegionFldsENT.DS_DataTextFieldId = objvQryRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objvQryRegionFldsENT.DS_DataValueFieldId = objvQryRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objvQryRegionFldsENT.ItemsString = objvQryRegionFldsENS.ItemsString; //列表项串
objvQryRegionFldsENT.DS_CondStr = objvQryRegionFldsENS.DS_CondStr; //数据源条件串
objvQryRegionFldsENT.ColSpan = objvQryRegionFldsENS.ColSpan; //跨列数
objvQryRegionFldsENT.Width = objvQryRegionFldsENS.Width; //宽
objvQryRegionFldsENT.SeqNum = objvQryRegionFldsENS.SeqNum; //字段序号
objvQryRegionFldsENT.InUse = objvQryRegionFldsENS.InUse; //是否在用
objvQryRegionFldsENT.PrjId = objvQryRegionFldsENS.PrjId; //工程ID
objvQryRegionFldsENT.UpdUser = objvQryRegionFldsENS.UpdUser; //修改者
objvQryRegionFldsENT.UpdDate = objvQryRegionFldsENS.UpdDate; //修改日期
objvQryRegionFldsENT.Memo = objvQryRegionFldsENS.Memo; //说明
objvQryRegionFldsENT.DS_TabName = objvQryRegionFldsENS.DS_TabName; //数据源表
objvQryRegionFldsENT.DS_DataValueFieldName = objvQryRegionFldsENS.DS_DataValueFieldName; //数据源值字段
objvQryRegionFldsENT.DS_DataTextFieldName = objvQryRegionFldsENS.DS_DataTextFieldName; //数据源文本字段
objvQryRegionFldsENT.RelaTabId = objvQryRegionFldsENS.RelaTabId; //RelaTabId
objvQryRegionFldsENT.sf_UpdFldSetStr = objvQryRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objvQryRegionFldsENT.sf_FldComparisonOp = objvQryRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objvQryRegionFldsENS">源对象</param>
 /// <param name = "objvQryRegionFldsENT">目标对象</param>
clsvQryRegionFldsBL.GetSimObjFromObj = function(objvQryRegionFldsENS)
{
var objvQryRegionFldsENT = new clsvQryRegionFldsEN_Sim_js_1.clsvQryRegionFldsEN_Sim();
objvQryRegionFldsENT.mId = objvQryRegionFldsENS.mId; //mId
objvQryRegionFldsENT.FldId = objvQryRegionFldsENS.FldId; //字段Id
objvQryRegionFldsENT.FldName = objvQryRegionFldsENS.FldName; //字段名
objvQryRegionFldsENT.DataTypeName = objvQryRegionFldsENS.DataTypeName; //数据类型名称
objvQryRegionFldsENT.DataTypeId = objvQryRegionFldsENS.DataTypeId; //数据类型Id
objvQryRegionFldsENT.FieldTypeId = objvQryRegionFldsENS.FieldTypeId; //字段类型Id
objvQryRegionFldsENT.FieldTypeName = objvQryRegionFldsENS.FieldTypeName; //字段类型名
objvQryRegionFldsENT.RegionId = objvQryRegionFldsENS.RegionId; //区域Id
objvQryRegionFldsENT.RegionName = objvQryRegionFldsENS.RegionName; //区域名称
objvQryRegionFldsENT.ViewId = objvQryRegionFldsENS.ViewId; //界面Id
objvQryRegionFldsENT.ViewName = objvQryRegionFldsENS.ViewName; //界面名称
objvQryRegionFldsENT.TabFldId = objvQryRegionFldsENS.TabFldId; //表字段ID
objvQryRegionFldsENT.LabelCaption = objvQryRegionFldsENS.LabelCaption; //标签标题
objvQryRegionFldsENT.CtlTypeId = objvQryRegionFldsENS.CtlTypeId; //控件类型号
objvQryRegionFldsENT.CtlTypeName = objvQryRegionFldsENS.CtlTypeName; //控件类型名
objvQryRegionFldsENT.CtlCnName = objvQryRegionFldsENS.CtlCnName; //控件类型中文名
objvQryRegionFldsENT.CtlTypeAbbr = objvQryRegionFldsENS.CtlTypeAbbr; //控件类型缩写
objvQryRegionFldsENT.DS_TabId = objvQryRegionFldsENS.DS_TabId; //数据源表ID
objvQryRegionFldsENT.TabName = objvQryRegionFldsENS.TabName; //表名
objvQryRegionFldsENT.QueryOptionId = objvQryRegionFldsENS.QueryOptionId; //查询方式Id
objvQryRegionFldsENT.QueryOptionName = objvQryRegionFldsENS.QueryOptionName; //查询方式名称
objvQryRegionFldsENT.DDLItemsOptionId = objvQryRegionFldsENS.DDLItemsOptionId; //下拉框列表选项ID
objvQryRegionFldsENT.DDLItemsOptionName = objvQryRegionFldsENS.DDLItemsOptionName; //下拉选项名
objvQryRegionFldsENT.DS_SQLStr = objvQryRegionFldsENS.DS_SQLStr; //数据源SQL串
objvQryRegionFldsENT.DS_DataTextFieldId = objvQryRegionFldsENS.DS_DataTextFieldId; //数据源文本字段Id
objvQryRegionFldsENT.DS_DataValueFieldId = objvQryRegionFldsENS.DS_DataValueFieldId; //数据源值字段Id
objvQryRegionFldsENT.ItemsString = objvQryRegionFldsENS.ItemsString; //列表项串
objvQryRegionFldsENT.DS_CondStr = objvQryRegionFldsENS.DS_CondStr; //数据源条件串
objvQryRegionFldsENT.ColSpan = objvQryRegionFldsENS.ColSpan; //跨列数
objvQryRegionFldsENT.Width = objvQryRegionFldsENS.Width; //宽
objvQryRegionFldsENT.SeqNum = objvQryRegionFldsENS.SeqNum; //字段序号
objvQryRegionFldsENT.InUse = objvQryRegionFldsENS.InUse; //是否在用
objvQryRegionFldsENT.PrjId = objvQryRegionFldsENS.PrjId; //工程ID
objvQryRegionFldsENT.UpdUser = objvQryRegionFldsENS.UpdUser; //修改者
objvQryRegionFldsENT.UpdDate = objvQryRegionFldsENS.UpdDate; //修改日期
objvQryRegionFldsENT.Memo = objvQryRegionFldsENS.Memo; //说明
objvQryRegionFldsENT.DS_TabName = objvQryRegionFldsENS.DS_TabName; //数据源表
objvQryRegionFldsENT.DS_DataValueFieldName = objvQryRegionFldsENS.DS_DataValueFieldName; //数据源值字段
objvQryRegionFldsENT.DS_DataTextFieldName = objvQryRegionFldsENS.DS_DataTextFieldName; //数据源文本字段
objvQryRegionFldsENT.RelaTabId = objvQryRegionFldsENS.RelaTabId; //RelaTabId
objvQryRegionFldsENT.sf_UpdFldSetStr = objvQryRegionFldsENS.UpdFldString; //专门用于记录某字段属性是否修改
objvQryRegionFldsENT.sf_FldComparisonOp = objvQryRegionFldsENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objvQryRegionFldsENT;
}
return clsvQryRegionFldsBL;
}());
exports.clsvQryRegionFldsBL = clsvQryRegionFldsBL;
});