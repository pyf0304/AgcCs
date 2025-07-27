
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDDLItemsOptionBL
 表名:DDLItemsOption(00050059)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:31
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:界面控件管理
 模块英文名:ViewControlManage
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
define(["require", "exports", "jquery", "../../L0_Entity/ViewControlManage/clsDDLItemsOptionEN.js","../../L0_Entity/ViewControlManage/clsDDLItemsOptionEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsDDLItemsOptionEN_js_1 = require("../../L0_Entity/ViewControlManage/clsDDLItemsOptionEN.js");
var clsDDLItemsOptionEN_Sim_js_1 = require("../../L0_Entity/ViewControlManage/clsDDLItemsOptionEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 下拉框列表选项(DDLItemsOption)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsDDLItemsOptionBL = /** @class */ (function () {
function clsDDLItemsOptionBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrDDLItemsOptionObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsDDLItemsOptionBL.prototype.CheckPropertyNew = function(pobjDDLItemsOptionEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjDDLItemsOptionEN.DDLItemsOptionName 
 || null !== pobjDDLItemsOptionEN.DDLItemsOptionName && pobjDDLItemsOptionEN.DDLItemsOptionName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[下拉框列表选项|下拉选项名]不能为空(NULL)!(clsDDLItemsOptionBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionId && GetStrLen(pobjDDLItemsOptionEN.DDLItemsOptionId) > 2)
{
 throw new Error("(errid:Busi000155)字段[下拉框列表选项(DDLItemsOption)|下拉框列表选项ID(DDLItemsOptionId)]的长度不能超过2!值:$(pobjDDLItemsOptionEN.DDLItemsOptionId)(clsDDLItemsOptionBL:CheckPropertyNew)");
}
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionName && GetStrLen(pobjDDLItemsOptionEN.DDLItemsOptionName) > 20)
{
 throw new Error("(errid:Busi000155)字段[下拉框列表选项(DDLItemsOption)|下拉选项名(DDLItemsOptionName)]的长度不能超过20!值:$(pobjDDLItemsOptionEN.DDLItemsOptionName)(clsDDLItemsOptionBL:CheckPropertyNew)");
}
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionENName && GetStrLen(pobjDDLItemsOptionEN.DDLItemsOptionENName) > 50)
{
 throw new Error("(errid:Busi000155)字段[下拉框列表选项(DDLItemsOption)|下拉框列表选项英文名(DDLItemsOptionENName)]的长度不能超过50!值:$(pobjDDLItemsOptionEN.DDLItemsOptionENName)(clsDDLItemsOptionBL:CheckPropertyNew)");
}
if (null !== pobjDDLItemsOptionEN.Memo && GetStrLen(pobjDDLItemsOptionEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[下拉框列表选项(DDLItemsOption)|说明(Memo)]的长度不能超过1000!值:$(pobjDDLItemsOptionEN.Memo)(clsDDLItemsOptionBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionId && undefined !== pobjDDLItemsOptionEN.DDLItemsOptionId && tzDataType.isString(pobjDDLItemsOptionEN.DDLItemsOptionId) === false)
{
 throw new Error("(errid:Busi000156)字段[下拉框列表选项(DDLItemsOption)|下拉框列表选项ID(DDLItemsOptionId)]的值:[$(pobjDDLItemsOptionEN.DDLItemsOptionId)], 非法，应该为字符型!(clsDDLItemsOptionBL:CheckPropertyNew)");
}
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionName && undefined !== pobjDDLItemsOptionEN.DDLItemsOptionName && tzDataType.isString(pobjDDLItemsOptionEN.DDLItemsOptionName) === false)
{
 throw new Error("(errid:Busi000156)字段[下拉框列表选项(DDLItemsOption)|下拉选项名(DDLItemsOptionName)]的值:[$(pobjDDLItemsOptionEN.DDLItemsOptionName)], 非法，应该为字符型!(clsDDLItemsOptionBL:CheckPropertyNew)");
}
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionENName && undefined !== pobjDDLItemsOptionEN.DDLItemsOptionENName && tzDataType.isString(pobjDDLItemsOptionEN.DDLItemsOptionENName) === false)
{
 throw new Error("(errid:Busi000156)字段[下拉框列表选项(DDLItemsOption)|下拉框列表选项英文名(DDLItemsOptionENName)]的值:[$(pobjDDLItemsOptionEN.DDLItemsOptionENName)], 非法，应该为字符型!(clsDDLItemsOptionBL:CheckPropertyNew)");
}
if (null !== pobjDDLItemsOptionEN.Memo && undefined !== pobjDDLItemsOptionEN.Memo && tzDataType.isString(pobjDDLItemsOptionEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[下拉框列表选项(DDLItemsOption)|说明(Memo)]的值:[$(pobjDDLItemsOptionEN.Memo)], 非法，应该为字符型!(clsDDLItemsOptionBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjDDLItemsOptionEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsDDLItemsOptionBL.prototype.CheckProperty4Update  = function(pobjDDLItemsOptionEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionId && GetStrLen(pobjDDLItemsOptionEN.DDLItemsOptionId) > 2)
{
 throw new Error("(errid:Busi000158)字段[下拉框列表选项(DDLItemsOption)|下拉框列表选项ID(DDLItemsOptionId)]的长度不能超过2!值:$(pobjDDLItemsOptionEN.DDLItemsOptionId)(clsDDLItemsOptionBL:CheckProperty4Update)");
}
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionName && GetStrLen(pobjDDLItemsOptionEN.DDLItemsOptionName) > 20)
{
 throw new Error("(errid:Busi000158)字段[下拉框列表选项(DDLItemsOption)|下拉选项名(DDLItemsOptionName)]的长度不能超过20!值:$(pobjDDLItemsOptionEN.DDLItemsOptionName)(clsDDLItemsOptionBL:CheckProperty4Update)");
}
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionENName && GetStrLen(pobjDDLItemsOptionEN.DDLItemsOptionENName) > 50)
{
 throw new Error("(errid:Busi000158)字段[下拉框列表选项(DDLItemsOption)|下拉框列表选项英文名(DDLItemsOptionENName)]的长度不能超过50!值:$(pobjDDLItemsOptionEN.DDLItemsOptionENName)(clsDDLItemsOptionBL:CheckProperty4Update)");
}
if (null !== pobjDDLItemsOptionEN.Memo && GetStrLen(pobjDDLItemsOptionEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[下拉框列表选项(DDLItemsOption)|说明(Memo)]的长度不能超过1000!值:$(pobjDDLItemsOptionEN.Memo)(clsDDLItemsOptionBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionId && undefined !== pobjDDLItemsOptionEN.DDLItemsOptionId && tzDataType.isString(pobjDDLItemsOptionEN.DDLItemsOptionId) === false)
{
 throw new Error("(errid:Busi000159)字段[下拉框列表选项(DDLItemsOption)|下拉框列表选项ID(DDLItemsOptionId)]的值:[$(pobjDDLItemsOptionEN.DDLItemsOptionId)], 非法，应该为字符型!(clsDDLItemsOptionBL:CheckProperty4Update)");
}
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionName && undefined !== pobjDDLItemsOptionEN.DDLItemsOptionName && tzDataType.isString(pobjDDLItemsOptionEN.DDLItemsOptionName) === false)
{
 throw new Error("(errid:Busi000159)字段[下拉框列表选项(DDLItemsOption)|下拉选项名(DDLItemsOptionName)]的值:[$(pobjDDLItemsOptionEN.DDLItemsOptionName)], 非法，应该为字符型!(clsDDLItemsOptionBL:CheckProperty4Update)");
}
if (null !== pobjDDLItemsOptionEN.DDLItemsOptionENName && undefined !== pobjDDLItemsOptionEN.DDLItemsOptionENName && tzDataType.isString(pobjDDLItemsOptionEN.DDLItemsOptionENName) === false)
{
 throw new Error("(errid:Busi000159)字段[下拉框列表选项(DDLItemsOption)|下拉框列表选项英文名(DDLItemsOptionENName)]的值:[$(pobjDDLItemsOptionEN.DDLItemsOptionENName)], 非法，应该为字符型!(clsDDLItemsOptionBL:CheckProperty4Update)");
}
if (null !== pobjDDLItemsOptionEN.Memo && undefined !== pobjDDLItemsOptionEN.Memo && tzDataType.isString(pobjDDLItemsOptionEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[下拉框列表选项(DDLItemsOption)|说明(Memo)]的值:[$(pobjDDLItemsOptionEN.Memo)], 非法，应该为字符型!(clsDDLItemsOptionBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjDDLItemsOptionEN.DDLItemsOptionId 
 || null !== pobjDDLItemsOptionEN.DDLItemsOptionId && pobjDDLItemsOptionEN.DDLItemsOptionId.toString()  ===  ""
 || null !== pobjDDLItemsOptionEN.DDLItemsOptionId && pobjDDLItemsOptionEN.DDLItemsOptionId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[下拉框列表选项|下拉框列表选项ID]不能为空(NULL)!(clsDDLItemsOptionBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjDDLItemsOptionEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024931
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsDDLItemsOptionBL.GetJSONStrByObj  = function(pobjDDLItemsOptionEN)
{
pobjDDLItemsOptionEN.sf_UpdFldSetStr = pobjDDLItemsOptionEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjDDLItemsOptionEN);
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
 /// 日期:20200501024931
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsDDLItemsOptionBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrDDLItemsOptionObjLst = new Array();
if (strJSON === "")
{
return arrDDLItemsOptionObjLst;
}
try
{
arrDDLItemsOptionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrDDLItemsOptionObjLst;
}
return arrDDLItemsOptionObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024931
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsDDLItemsOptionBL.GetObjByJSONStr  = function(strJSON)
{
var pobjDDLItemsOptionEN = new clsDDLItemsOptionEN();
if (strJSON === "")
{
return pobjDDLItemsOptionEN;
}
try
{
pobjDDLItemsOptionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjDDLItemsOptionEN;
}
return pobjDDLItemsOptionEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objDDLItemsOptionENS">源简化对象</param>
 /// <param name = "objDDLItemsOptionENT">目标对象</param>
clsDDLItemsOptionBL.CopyObjFromSimObj = function(objDDLItemsOptionENS, objDDLItemsOptionENT) 
{
objDDLItemsOptionENT.DDLItemsOptionId = objDDLItemsOptionENS.DDLItemsOptionId; //下拉框列表选项ID
objDDLItemsOptionENT.DDLItemsOptionName = objDDLItemsOptionENS.DDLItemsOptionName; //下拉选项名
objDDLItemsOptionENT.DDLItemsOptionENName = objDDLItemsOptionENS.DDLItemsOptionENName; //下拉框列表选项英文名
objDDLItemsOptionENT.Memo = objDDLItemsOptionENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objDDLItemsOptionENS">源对象</param>
 /// <param name = "objDDLItemsOptionENT">目标对象</param>
clsDDLItemsOptionBL.CopyObjTo = function(objDDLItemsOptionENS , objDDLItemsOptionENT ) 
{
objDDLItemsOptionENT.DDLItemsOptionId = objDDLItemsOptionENS.DDLItemsOptionId; //下拉框列表选项ID
objDDLItemsOptionENT.DDLItemsOptionName = objDDLItemsOptionENS.DDLItemsOptionName; //下拉选项名
objDDLItemsOptionENT.DDLItemsOptionENName = objDDLItemsOptionENS.DDLItemsOptionENName; //下拉框列表选项英文名
objDDLItemsOptionENT.Memo = objDDLItemsOptionENS.Memo; //说明
objDDLItemsOptionENT.sf_UpdFldSetStr = objDDLItemsOptionENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objDDLItemsOptionENS">源对象</param>
 /// <param name = "objDDLItemsOptionENT">目标对象</param>
clsDDLItemsOptionBL.CopyObjToSimObj = function(objDDLItemsOptionENS , objDDLItemsOptionENT ) 
{
objDDLItemsOptionENT.DDLItemsOptionId = objDDLItemsOptionENS.DDLItemsOptionId; //下拉框列表选项ID
objDDLItemsOptionENT.DDLItemsOptionName = objDDLItemsOptionENS.DDLItemsOptionName; //下拉选项名
objDDLItemsOptionENT.DDLItemsOptionENName = objDDLItemsOptionENS.DDLItemsOptionENName; //下拉框列表选项英文名
objDDLItemsOptionENT.Memo = objDDLItemsOptionENS.Memo; //说明
objDDLItemsOptionENT.sf_UpdFldSetStr = objDDLItemsOptionENS.UpdFldString; //专门用于记录某字段属性是否修改
objDDLItemsOptionENT.sf_FldComparisonOp = objDDLItemsOptionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objDDLItemsOptionENS">源简化对象</param>
 /// <param name = "objDDLItemsOptionENT">目标对象</param>
clsDDLItemsOptionBL.CopyObjFromSimObj4Upd = function(objDDLItemsOptionENS, objDDLItemsOptionENT )
 {
   var strsf_UpdFldSetStr = objDDLItemsOptionENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsDDLItemsOptionEN.con_DDLItemsOptionId)  >= 0)
{
objDDLItemsOptionENT.DDLItemsOptionId = objDDLItemsOptionENS.DDLItemsOptionId; //下拉框列表选项ID
}
if (sstrFldSet.indexOf(clsDDLItemsOptionEN.con_DDLItemsOptionName)  >= 0)
{
objDDLItemsOptionENT.DDLItemsOptionName = objDDLItemsOptionENS.DDLItemsOptionName; //下拉选项名
}
if (sstrFldSet.indexOf(clsDDLItemsOptionEN.con_DDLItemsOptionENName)  >= 0)
{
objDDLItemsOptionENT.DDLItemsOptionENName = objDDLItemsOptionENS.DDLItemsOptionENName; //下拉框列表选项英文名
}
if (sstrFldSet.indexOf(clsDDLItemsOptionEN.con_Memo)  >= 0)
{
objDDLItemsOptionENT.Memo = objDDLItemsOptionENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objDDLItemsOptionENS">源对象</param>
 /// <param name = "objDDLItemsOptionENT">目标对象</param>
clsDDLItemsOptionBL.GetSimObjFromObj = function(objDDLItemsOptionENS)
{
var objDDLItemsOptionENT = new clsDDLItemsOptionEN_Sim_js_1.clsDDLItemsOptionEN_Sim();
objDDLItemsOptionENT.DDLItemsOptionId = objDDLItemsOptionENS.DDLItemsOptionId; //下拉框列表选项ID
objDDLItemsOptionENT.DDLItemsOptionName = objDDLItemsOptionENS.DDLItemsOptionName; //下拉选项名
objDDLItemsOptionENT.DDLItemsOptionENName = objDDLItemsOptionENS.DDLItemsOptionENName; //下拉框列表选项英文名
objDDLItemsOptionENT.Memo = objDDLItemsOptionENS.Memo; //说明
objDDLItemsOptionENT.sf_UpdFldSetStr = objDDLItemsOptionENS.UpdFldString; //专门用于记录某字段属性是否修改
objDDLItemsOptionENT.sf_FldComparisonOp = objDDLItemsOptionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objDDLItemsOptionENT;
}
return clsDDLItemsOptionBL;
}());
exports.clsDDLItemsOptionBL = clsDDLItemsOptionBL;
});