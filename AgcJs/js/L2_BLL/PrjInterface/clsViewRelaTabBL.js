
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRelaTabBL
 表名:ViewRelaTab(00050100)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:27
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsViewRelaTabEN.js","../../L0_Entity/PrjInterface/clsViewRelaTabEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsViewRelaTabEN_js_1 = require("../../L0_Entity/PrjInterface/clsViewRelaTabEN.js");
var clsViewRelaTabEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsViewRelaTabEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 界面相关表(ViewRelaTab)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsViewRelaTabBL = /** @class */ (function () {
function clsViewRelaTabBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrViewRelaTabObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewRelaTabBL.prototype.CheckPropertyNew = function(pobjViewRelaTabEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjViewRelaTabEN.ViewId 
 || null !== pobjViewRelaTabEN.ViewId && pobjViewRelaTabEN.ViewId.toString()  ===  ""
 || null !== pobjViewRelaTabEN.ViewId && pobjViewRelaTabEN.ViewId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面相关表|界面Id]不能为空(NULL)!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null === pobjViewRelaTabEN.RegionId 
 || null !== pobjViewRelaTabEN.RegionId && pobjViewRelaTabEN.RegionId.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[界面相关表|区域Id]不能为空(NULL)!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null === pobjViewRelaTabEN.INOUTTypeId 
 || null !== pobjViewRelaTabEN.INOUTTypeId && pobjViewRelaTabEN.INOUTTypeId.toString()  ===  ""
 || null !== pobjViewRelaTabEN.INOUTTypeId && pobjViewRelaTabEN.INOUTTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面相关表|INOUT类型ID]不能为空(NULL)!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null === pobjViewRelaTabEN.ViewTabTypeId 
 || null !== pobjViewRelaTabEN.ViewTabTypeId && pobjViewRelaTabEN.ViewTabTypeId.toString()  ===  ""
 || null !== pobjViewRelaTabEN.ViewTabTypeId && pobjViewRelaTabEN.ViewTabTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面相关表|界面表类型码]不能为空(NULL)!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null === pobjViewRelaTabEN.TabId 
 || null !== pobjViewRelaTabEN.TabId && pobjViewRelaTabEN.TabId.toString()  ===  ""
 || null !== pobjViewRelaTabEN.TabId && pobjViewRelaTabEN.TabId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000154)字段[界面相关表|表ID]不能为空(NULL)!(clsViewRelaTabBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewRelaTabEN.ViewId && GetStrLen(pobjViewRelaTabEN.ViewId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面相关表(ViewRelaTab)|界面Id(ViewId)]的长度不能超过8!值:$(pobjViewRelaTabEN.ViewId)(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.INOUTTypeId && GetStrLen(pobjViewRelaTabEN.INOUTTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[界面相关表(ViewRelaTab)|INOUT类型ID(INOUTTypeId)]的长度不能超过2!值:$(pobjViewRelaTabEN.INOUTTypeId)(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.ViewTabTypeId && GetStrLen(pobjViewRelaTabEN.ViewTabTypeId) > 4)
{
 throw new Error("(errid:Busi000155)字段[界面相关表(ViewRelaTab)|界面表类型码(ViewTabTypeId)]的长度不能超过4!值:$(pobjViewRelaTabEN.ViewTabTypeId)(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.TabId && GetStrLen(pobjViewRelaTabEN.TabId) > 8)
{
 throw new Error("(errid:Busi000155)字段[界面相关表(ViewRelaTab)|表ID(TabId)]的长度不能超过8!值:$(pobjViewRelaTabEN.TabId)(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.TabFunction && GetStrLen(pobjViewRelaTabEN.TabFunction) > 500)
{
 throw new Error("(errid:Busi000155)字段[界面相关表(ViewRelaTab)|表功能说明(TabFunction)]的长度不能超过500!值:$(pobjViewRelaTabEN.TabFunction)(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.UpdDate && GetStrLen(pobjViewRelaTabEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面相关表(ViewRelaTab)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjViewRelaTabEN.UpdDate)(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.UpdUser && GetStrLen(pobjViewRelaTabEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000155)字段[界面相关表(ViewRelaTab)|修改者(UpdUser)]的长度不能超过20!值:$(pobjViewRelaTabEN.UpdUser)(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.Memo && GetStrLen(pobjViewRelaTabEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[界面相关表(ViewRelaTab)|说明(Memo)]的长度不能超过1000!值:$(pobjViewRelaTabEN.Memo)(clsViewRelaTabBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewRelaTabEN.mId && undefined !== pobjViewRelaTabEN.mId && tzDataType.isNumber(pobjViewRelaTabEN.mId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|mId(mId)]的值:[$(pobjViewRelaTabEN.mId)], 非法，应该为数值型!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.ViewId && undefined !== pobjViewRelaTabEN.ViewId && tzDataType.isString(pobjViewRelaTabEN.ViewId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|界面Id(ViewId)]的值:[$(pobjViewRelaTabEN.ViewId)], 非法，应该为字符型!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.RegionId && undefined !== pobjViewRelaTabEN.RegionId && tzDataType.isNumber(pobjViewRelaTabEN.RegionId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|区域Id(RegionId)]的值:[$(pobjViewRelaTabEN.RegionId)], 非法，应该为数值型!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.INOUTTypeId && undefined !== pobjViewRelaTabEN.INOUTTypeId && tzDataType.isString(pobjViewRelaTabEN.INOUTTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|INOUT类型ID(INOUTTypeId)]的值:[$(pobjViewRelaTabEN.INOUTTypeId)], 非法，应该为字符型!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.ViewTabTypeId && undefined !== pobjViewRelaTabEN.ViewTabTypeId && tzDataType.isString(pobjViewRelaTabEN.ViewTabTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|界面表类型码(ViewTabTypeId)]的值:[$(pobjViewRelaTabEN.ViewTabTypeId)], 非法，应该为字符型!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.TabId && undefined !== pobjViewRelaTabEN.TabId && tzDataType.isString(pobjViewRelaTabEN.TabId) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|表ID(TabId)]的值:[$(pobjViewRelaTabEN.TabId)], 非法，应该为字符型!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.TabFunction && undefined !== pobjViewRelaTabEN.TabFunction && tzDataType.isString(pobjViewRelaTabEN.TabFunction) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|表功能说明(TabFunction)]的值:[$(pobjViewRelaTabEN.TabFunction)], 非法，应该为字符型!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.UpdDate && undefined !== pobjViewRelaTabEN.UpdDate && tzDataType.isString(pobjViewRelaTabEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|修改日期(UpdDate)]的值:[$(pobjViewRelaTabEN.UpdDate)], 非法，应该为字符型!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.UpdUser && undefined !== pobjViewRelaTabEN.UpdUser && tzDataType.isString(pobjViewRelaTabEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|修改者(UpdUser)]的值:[$(pobjViewRelaTabEN.UpdUser)], 非法，应该为字符型!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (null !== pobjViewRelaTabEN.Memo && undefined !== pobjViewRelaTabEN.Memo && tzDataType.isString(pobjViewRelaTabEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[界面相关表(ViewRelaTab)|说明(Memo)]的值:[$(pobjViewRelaTabEN.Memo)], 非法，应该为字符型!(clsViewRelaTabBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjViewRelaTabEN.ViewId != null && GetStrLen(pobjViewRelaTabEN.ViewId) !=  8)
{
 throw ("(errid:Busi000157)字段[界面相关表|界面Id]作为外键字段,长度应该为8!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (pobjViewRelaTabEN.TabId != null && GetStrLen(pobjViewRelaTabEN.TabId) !=  8)
{
 throw ("(errid:Busi000157)字段[界面相关表|表ID]作为外键字段,长度应该为8!(clsViewRelaTabBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjViewRelaTabEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsViewRelaTabBL.prototype.CheckProperty4Update  = function(pobjViewRelaTabEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjViewRelaTabEN.ViewId && GetStrLen(pobjViewRelaTabEN.ViewId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面相关表(ViewRelaTab)|界面Id(ViewId)]的长度不能超过8!值:$(pobjViewRelaTabEN.ViewId)(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.INOUTTypeId && GetStrLen(pobjViewRelaTabEN.INOUTTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[界面相关表(ViewRelaTab)|INOUT类型ID(INOUTTypeId)]的长度不能超过2!值:$(pobjViewRelaTabEN.INOUTTypeId)(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.ViewTabTypeId && GetStrLen(pobjViewRelaTabEN.ViewTabTypeId) > 4)
{
 throw new Error("(errid:Busi000158)字段[界面相关表(ViewRelaTab)|界面表类型码(ViewTabTypeId)]的长度不能超过4!值:$(pobjViewRelaTabEN.ViewTabTypeId)(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.TabId && GetStrLen(pobjViewRelaTabEN.TabId) > 8)
{
 throw new Error("(errid:Busi000158)字段[界面相关表(ViewRelaTab)|表ID(TabId)]的长度不能超过8!值:$(pobjViewRelaTabEN.TabId)(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.TabFunction && GetStrLen(pobjViewRelaTabEN.TabFunction) > 500)
{
 throw new Error("(errid:Busi000158)字段[界面相关表(ViewRelaTab)|表功能说明(TabFunction)]的长度不能超过500!值:$(pobjViewRelaTabEN.TabFunction)(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.UpdDate && GetStrLen(pobjViewRelaTabEN.UpdDate) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面相关表(ViewRelaTab)|修改日期(UpdDate)]的长度不能超过20!值:$(pobjViewRelaTabEN.UpdDate)(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.UpdUser && GetStrLen(pobjViewRelaTabEN.UpdUser) > 20)
{
 throw new Error("(errid:Busi000158)字段[界面相关表(ViewRelaTab)|修改者(UpdUser)]的长度不能超过20!值:$(pobjViewRelaTabEN.UpdUser)(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.Memo && GetStrLen(pobjViewRelaTabEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[界面相关表(ViewRelaTab)|说明(Memo)]的长度不能超过1000!值:$(pobjViewRelaTabEN.Memo)(clsViewRelaTabBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjViewRelaTabEN.mId && undefined !== pobjViewRelaTabEN.mId && tzDataType.isNumber(pobjViewRelaTabEN.mId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|mId(mId)]的值:[$(pobjViewRelaTabEN.mId)], 非法，应该为数值型!(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.ViewId && undefined !== pobjViewRelaTabEN.ViewId && tzDataType.isString(pobjViewRelaTabEN.ViewId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|界面Id(ViewId)]的值:[$(pobjViewRelaTabEN.ViewId)], 非法，应该为字符型!(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.RegionId && undefined !== pobjViewRelaTabEN.RegionId && tzDataType.isNumber(pobjViewRelaTabEN.RegionId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|区域Id(RegionId)]的值:[$(pobjViewRelaTabEN.RegionId)], 非法，应该为数值型!(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.INOUTTypeId && undefined !== pobjViewRelaTabEN.INOUTTypeId && tzDataType.isString(pobjViewRelaTabEN.INOUTTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|INOUT类型ID(INOUTTypeId)]的值:[$(pobjViewRelaTabEN.INOUTTypeId)], 非法，应该为字符型!(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.ViewTabTypeId && undefined !== pobjViewRelaTabEN.ViewTabTypeId && tzDataType.isString(pobjViewRelaTabEN.ViewTabTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|界面表类型码(ViewTabTypeId)]的值:[$(pobjViewRelaTabEN.ViewTabTypeId)], 非法，应该为字符型!(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.TabId && undefined !== pobjViewRelaTabEN.TabId && tzDataType.isString(pobjViewRelaTabEN.TabId) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|表ID(TabId)]的值:[$(pobjViewRelaTabEN.TabId)], 非法，应该为字符型!(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.TabFunction && undefined !== pobjViewRelaTabEN.TabFunction && tzDataType.isString(pobjViewRelaTabEN.TabFunction) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|表功能说明(TabFunction)]的值:[$(pobjViewRelaTabEN.TabFunction)], 非法，应该为字符型!(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.UpdDate && undefined !== pobjViewRelaTabEN.UpdDate && tzDataType.isString(pobjViewRelaTabEN.UpdDate) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|修改日期(UpdDate)]的值:[$(pobjViewRelaTabEN.UpdDate)], 非法，应该为字符型!(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.UpdUser && undefined !== pobjViewRelaTabEN.UpdUser && tzDataType.isString(pobjViewRelaTabEN.UpdUser) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|修改者(UpdUser)]的值:[$(pobjViewRelaTabEN.UpdUser)], 非法，应该为字符型!(clsViewRelaTabBL:CheckProperty4Update)");
}
if (null !== pobjViewRelaTabEN.Memo && undefined !== pobjViewRelaTabEN.Memo && tzDataType.isString(pobjViewRelaTabEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[界面相关表(ViewRelaTab)|说明(Memo)]的值:[$(pobjViewRelaTabEN.Memo)], 非法，应该为字符型!(clsViewRelaTabBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjViewRelaTabEN.mId 
 || null !== pobjViewRelaTabEN.mId && pobjViewRelaTabEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Busi000160)字段[界面相关表|mId]不能为空(NULL)!(clsViewRelaTabBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (pobjViewRelaTabEN.ViewId != null && GetStrLen(pobjViewRelaTabEN.ViewId) !=  8)
{
 throw ("(errid:Busi000161)字段[界面相关表|界面Id]作为外键字段,长度应该为8!(clsViewRelaTabBL:CheckPropertyNew)");
}
if (pobjViewRelaTabEN.TabId != null && GetStrLen(pobjViewRelaTabEN.TabId) !=  8)
{
 throw ("(errid:Busi000161)字段[界面相关表|表ID]作为外键字段,长度应该为8!(clsViewRelaTabBL:CheckPropertyNew)");
}

 pobjViewRelaTabEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024927
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewRelaTabBL.GetJSONStrByObj  = function(pobjViewRelaTabEN)
{
pobjViewRelaTabEN.sf_UpdFldSetStr = pobjViewRelaTabEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjViewRelaTabEN);
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
 /// 日期:20200501024927
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsViewRelaTabBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrViewRelaTabObjLst = new Array();
if (strJSON === "")
{
return arrViewRelaTabObjLst;
}
try
{
arrViewRelaTabObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrViewRelaTabObjLst;
}
return arrViewRelaTabObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024927
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsViewRelaTabBL.GetObjByJSONStr  = function(strJSON)
{
var pobjViewRelaTabEN = new clsViewRelaTabEN();
if (strJSON === "")
{
return pobjViewRelaTabEN;
}
try
{
pobjViewRelaTabEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjViewRelaTabEN;
}
return pobjViewRelaTabEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objViewRelaTabENS">源简化对象</param>
 /// <param name = "objViewRelaTabENT">目标对象</param>
clsViewRelaTabBL.CopyObjFromSimObj = function(objViewRelaTabENS, objViewRelaTabENT) 
{
objViewRelaTabENT.mId = objViewRelaTabENS.mId; //mId
objViewRelaTabENT.ViewId = objViewRelaTabENS.ViewId; //界面Id
objViewRelaTabENT.RegionId = objViewRelaTabENS.RegionId; //区域Id
objViewRelaTabENT.INOUTTypeId = objViewRelaTabENS.INOUTTypeId; //INOUT类型ID
objViewRelaTabENT.ViewTabTypeId = objViewRelaTabENS.ViewTabTypeId; //界面表类型码
objViewRelaTabENT.TabId = objViewRelaTabENS.TabId; //表ID
objViewRelaTabENT.TabFunction = objViewRelaTabENS.TabFunction; //表功能说明
objViewRelaTabENT.UpdDate = objViewRelaTabENS.UpdDate; //修改日期
objViewRelaTabENT.UpdUser = objViewRelaTabENS.UpdUser; //修改者
objViewRelaTabENT.Memo = objViewRelaTabENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objViewRelaTabENS">源对象</param>
 /// <param name = "objViewRelaTabENT">目标对象</param>
clsViewRelaTabBL.CopyObjTo = function(objViewRelaTabENS , objViewRelaTabENT ) 
{
objViewRelaTabENT.mId = objViewRelaTabENS.mId; //mId
objViewRelaTabENT.ViewId = objViewRelaTabENS.ViewId; //界面Id
objViewRelaTabENT.RegionId = objViewRelaTabENS.RegionId; //区域Id
objViewRelaTabENT.INOUTTypeId = objViewRelaTabENS.INOUTTypeId; //INOUT类型ID
objViewRelaTabENT.ViewTabTypeId = objViewRelaTabENS.ViewTabTypeId; //界面表类型码
objViewRelaTabENT.TabId = objViewRelaTabENS.TabId; //表ID
objViewRelaTabENT.TabFunction = objViewRelaTabENS.TabFunction; //表功能说明
objViewRelaTabENT.UpdDate = objViewRelaTabENS.UpdDate; //修改日期
objViewRelaTabENT.UpdUser = objViewRelaTabENS.UpdUser; //修改者
objViewRelaTabENT.Memo = objViewRelaTabENS.Memo; //说明
objViewRelaTabENT.sf_UpdFldSetStr = objViewRelaTabENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objViewRelaTabENS">源对象</param>
 /// <param name = "objViewRelaTabENT">目标对象</param>
clsViewRelaTabBL.CopyObjToSimObj = function(objViewRelaTabENS , objViewRelaTabENT ) 
{
objViewRelaTabENT.mId = objViewRelaTabENS.mId; //mId
objViewRelaTabENT.ViewId = objViewRelaTabENS.ViewId; //界面Id
objViewRelaTabENT.RegionId = objViewRelaTabENS.RegionId; //区域Id
objViewRelaTabENT.INOUTTypeId = objViewRelaTabENS.INOUTTypeId; //INOUT类型ID
objViewRelaTabENT.ViewTabTypeId = objViewRelaTabENS.ViewTabTypeId; //界面表类型码
objViewRelaTabENT.TabId = objViewRelaTabENS.TabId; //表ID
objViewRelaTabENT.TabFunction = objViewRelaTabENS.TabFunction; //表功能说明
objViewRelaTabENT.UpdDate = objViewRelaTabENS.UpdDate; //修改日期
objViewRelaTabENT.UpdUser = objViewRelaTabENS.UpdUser; //修改者
objViewRelaTabENT.Memo = objViewRelaTabENS.Memo; //说明
objViewRelaTabENT.sf_UpdFldSetStr = objViewRelaTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewRelaTabENT.sf_FldComparisonOp = objViewRelaTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objViewRelaTabENS">源简化对象</param>
 /// <param name = "objViewRelaTabENT">目标对象</param>
clsViewRelaTabBL.CopyObjFromSimObj4Upd = function(objViewRelaTabENS, objViewRelaTabENT )
 {
   var strsf_UpdFldSetStr = objViewRelaTabENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_mId)  >= 0)
{
objViewRelaTabENT.mId = objViewRelaTabENS.mId; //mId
}
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_ViewId)  >= 0)
{
objViewRelaTabENT.ViewId = objViewRelaTabENS.ViewId; //界面Id
}
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_RegionId)  >= 0)
{
objViewRelaTabENT.RegionId = objViewRelaTabENS.RegionId; //区域Id
}
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_INOUTTypeId)  >= 0)
{
objViewRelaTabENT.INOUTTypeId = objViewRelaTabENS.INOUTTypeId; //INOUT类型ID
}
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_ViewTabTypeId)  >= 0)
{
objViewRelaTabENT.ViewTabTypeId = objViewRelaTabENS.ViewTabTypeId; //界面表类型码
}
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_TabId)  >= 0)
{
objViewRelaTabENT.TabId = objViewRelaTabENS.TabId; //表ID
}
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_TabFunction)  >= 0)
{
objViewRelaTabENT.TabFunction = objViewRelaTabENS.TabFunction; //表功能说明
}
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_UpdDate)  >= 0)
{
objViewRelaTabENT.UpdDate = objViewRelaTabENS.UpdDate; //修改日期
}
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_UpdUser)  >= 0)
{
objViewRelaTabENT.UpdUser = objViewRelaTabENS.UpdUser; //修改者
}
if (sstrFldSet.indexOf(clsViewRelaTabEN.con_Memo)  >= 0)
{
objViewRelaTabENT.Memo = objViewRelaTabENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objViewRelaTabENS">源对象</param>
 /// <param name = "objViewRelaTabENT">目标对象</param>
clsViewRelaTabBL.GetSimObjFromObj = function(objViewRelaTabENS)
{
var objViewRelaTabENT = new clsViewRelaTabEN_Sim_js_1.clsViewRelaTabEN_Sim();
objViewRelaTabENT.mId = objViewRelaTabENS.mId; //mId
objViewRelaTabENT.ViewId = objViewRelaTabENS.ViewId; //界面Id
objViewRelaTabENT.RegionId = objViewRelaTabENS.RegionId; //区域Id
objViewRelaTabENT.INOUTTypeId = objViewRelaTabENS.INOUTTypeId; //INOUT类型ID
objViewRelaTabENT.ViewTabTypeId = objViewRelaTabENS.ViewTabTypeId; //界面表类型码
objViewRelaTabENT.TabId = objViewRelaTabENS.TabId; //表ID
objViewRelaTabENT.TabFunction = objViewRelaTabENS.TabFunction; //表功能说明
objViewRelaTabENT.UpdDate = objViewRelaTabENS.UpdDate; //修改日期
objViewRelaTabENT.UpdUser = objViewRelaTabENS.UpdUser; //修改者
objViewRelaTabENT.Memo = objViewRelaTabENS.Memo; //说明
objViewRelaTabENT.sf_UpdFldSetStr = objViewRelaTabENS.UpdFldString; //专门用于记录某字段属性是否修改
objViewRelaTabENT.sf_FldComparisonOp = objViewRelaTabENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objViewRelaTabENT;
}
return clsViewRelaTabBL;
}());
exports.clsViewRelaTabBL = clsViewRelaTabBL;
});