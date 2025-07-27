
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSQLDSTypeBL
 表名:SQLDSType(00050014)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/02 01:06:00
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
define(["require", "exports", "jquery", "../../L0_Entity/PrjInterface/clsSQLDSTypeEN.js","../../L0_Entity/PrjInterface/clsSQLDSTypeEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsSQLDSTypeEN_js_1 = require("../../L0_Entity/PrjInterface/clsSQLDSTypeEN.js");
var clsSQLDSTypeEN_Sim_js_1 = require("../../L0_Entity/PrjInterface/clsSQLDSTypeEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// Sql数据源类型(SQLDSType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsSQLDSTypeBL = /** @class */ (function () {
function clsSQLDSTypeBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrSQLDSTypeObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsSQLDSTypeBL.prototype.CheckPropertyNew = function(pobjSQLDSTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjSQLDSTypeEN.SqlDsTypeName 
 || null !== pobjSQLDSTypeEN.SqlDsTypeName && pobjSQLDSTypeEN.SqlDsTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[Sql数据源类型|Sql数据源名]不能为空(NULL)!(clsSQLDSTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjSQLDSTypeEN.SQLDSTypeId && GetStrLen(pobjSQLDSTypeEN.SQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[Sql数据源类型(SQLDSType)|数据源类型(SQLDSTypeId)]的长度不能超过2!值:$(pobjSQLDSTypeEN.SQLDSTypeId)(clsSQLDSTypeBL:CheckPropertyNew)");
}
if (null !== pobjSQLDSTypeEN.SqlDsTypeName && GetStrLen(pobjSQLDSTypeEN.SqlDsTypeName) > 20)
{
 throw new Error("(errid:Busi000155)字段[Sql数据源类型(SQLDSType)|Sql数据源名(SqlDsTypeName)]的长度不能超过20!值:$(pobjSQLDSTypeEN.SqlDsTypeName)(clsSQLDSTypeBL:CheckPropertyNew)");
}
if (null !== pobjSQLDSTypeEN.SqlDsTypeENName && GetStrLen(pobjSQLDSTypeEN.SqlDsTypeENName) > 50)
{
 throw new Error("(errid:Busi000155)字段[Sql数据源类型(SQLDSType)|Sql数据源英文名(SqlDsTypeENName)]的长度不能超过50!值:$(pobjSQLDSTypeEN.SqlDsTypeENName)(clsSQLDSTypeBL:CheckPropertyNew)");
}
if (null !== pobjSQLDSTypeEN.Memo && GetStrLen(pobjSQLDSTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[Sql数据源类型(SQLDSType)|说明(Memo)]的长度不能超过1000!值:$(pobjSQLDSTypeEN.Memo)(clsSQLDSTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjSQLDSTypeEN.SQLDSTypeId && undefined !== pobjSQLDSTypeEN.SQLDSTypeId && tzDataType.isString(pobjSQLDSTypeEN.SQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[Sql数据源类型(SQLDSType)|数据源类型(SQLDSTypeId)]的值:[$(pobjSQLDSTypeEN.SQLDSTypeId)], 非法，应该为字符型!(clsSQLDSTypeBL:CheckPropertyNew)");
}
if (null !== pobjSQLDSTypeEN.SqlDsTypeName && undefined !== pobjSQLDSTypeEN.SqlDsTypeName && tzDataType.isString(pobjSQLDSTypeEN.SqlDsTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[Sql数据源类型(SQLDSType)|Sql数据源名(SqlDsTypeName)]的值:[$(pobjSQLDSTypeEN.SqlDsTypeName)], 非法，应该为字符型!(clsSQLDSTypeBL:CheckPropertyNew)");
}
if (null !== pobjSQLDSTypeEN.SqlDsTypeENName && undefined !== pobjSQLDSTypeEN.SqlDsTypeENName && tzDataType.isString(pobjSQLDSTypeEN.SqlDsTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[Sql数据源类型(SQLDSType)|Sql数据源英文名(SqlDsTypeENName)]的值:[$(pobjSQLDSTypeEN.SqlDsTypeENName)], 非法，应该为字符型!(clsSQLDSTypeBL:CheckPropertyNew)");
}
if (null !== pobjSQLDSTypeEN.Memo && undefined !== pobjSQLDSTypeEN.Memo && tzDataType.isString(pobjSQLDSTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[Sql数据源类型(SQLDSType)|说明(Memo)]的值:[$(pobjSQLDSTypeEN.Memo)], 非法，应该为字符型!(clsSQLDSTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSQLDSTypeEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsSQLDSTypeBL.prototype.CheckProperty4Update  = function(pobjSQLDSTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjSQLDSTypeEN.SQLDSTypeId && GetStrLen(pobjSQLDSTypeEN.SQLDSTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[Sql数据源类型(SQLDSType)|数据源类型(SQLDSTypeId)]的长度不能超过2!值:$(pobjSQLDSTypeEN.SQLDSTypeId)(clsSQLDSTypeBL:CheckProperty4Update)");
}
if (null !== pobjSQLDSTypeEN.SqlDsTypeName && GetStrLen(pobjSQLDSTypeEN.SqlDsTypeName) > 20)
{
 throw new Error("(errid:Busi000158)字段[Sql数据源类型(SQLDSType)|Sql数据源名(SqlDsTypeName)]的长度不能超过20!值:$(pobjSQLDSTypeEN.SqlDsTypeName)(clsSQLDSTypeBL:CheckProperty4Update)");
}
if (null !== pobjSQLDSTypeEN.SqlDsTypeENName && GetStrLen(pobjSQLDSTypeEN.SqlDsTypeENName) > 50)
{
 throw new Error("(errid:Busi000158)字段[Sql数据源类型(SQLDSType)|Sql数据源英文名(SqlDsTypeENName)]的长度不能超过50!值:$(pobjSQLDSTypeEN.SqlDsTypeENName)(clsSQLDSTypeBL:CheckProperty4Update)");
}
if (null !== pobjSQLDSTypeEN.Memo && GetStrLen(pobjSQLDSTypeEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[Sql数据源类型(SQLDSType)|说明(Memo)]的长度不能超过1000!值:$(pobjSQLDSTypeEN.Memo)(clsSQLDSTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjSQLDSTypeEN.SQLDSTypeId && undefined !== pobjSQLDSTypeEN.SQLDSTypeId && tzDataType.isString(pobjSQLDSTypeEN.SQLDSTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[Sql数据源类型(SQLDSType)|数据源类型(SQLDSTypeId)]的值:[$(pobjSQLDSTypeEN.SQLDSTypeId)], 非法，应该为字符型!(clsSQLDSTypeBL:CheckProperty4Update)");
}
if (null !== pobjSQLDSTypeEN.SqlDsTypeName && undefined !== pobjSQLDSTypeEN.SqlDsTypeName && tzDataType.isString(pobjSQLDSTypeEN.SqlDsTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[Sql数据源类型(SQLDSType)|Sql数据源名(SqlDsTypeName)]的值:[$(pobjSQLDSTypeEN.SqlDsTypeName)], 非法，应该为字符型!(clsSQLDSTypeBL:CheckProperty4Update)");
}
if (null !== pobjSQLDSTypeEN.SqlDsTypeENName && undefined !== pobjSQLDSTypeEN.SqlDsTypeENName && tzDataType.isString(pobjSQLDSTypeEN.SqlDsTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[Sql数据源类型(SQLDSType)|Sql数据源英文名(SqlDsTypeENName)]的值:[$(pobjSQLDSTypeEN.SqlDsTypeENName)], 非法，应该为字符型!(clsSQLDSTypeBL:CheckProperty4Update)");
}
if (null !== pobjSQLDSTypeEN.Memo && undefined !== pobjSQLDSTypeEN.Memo && tzDataType.isString(pobjSQLDSTypeEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[Sql数据源类型(SQLDSType)|说明(Memo)]的值:[$(pobjSQLDSTypeEN.Memo)], 非法，应该为字符型!(clsSQLDSTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjSQLDSTypeEN.SQLDSTypeId 
 || null !== pobjSQLDSTypeEN.SQLDSTypeId && pobjSQLDSTypeEN.SQLDSTypeId.toString()  ===  ""
 || null !== pobjSQLDSTypeEN.SQLDSTypeId && pobjSQLDSTypeEN.SQLDSTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[Sql数据源类型|数据源类型]不能为空(NULL)!(clsSQLDSTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSQLDSTypeEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200502010600
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsSQLDSTypeBL.GetJSONStrByObj  = function(pobjSQLDSTypeEN)
{
pobjSQLDSTypeEN.sf_UpdFldSetStr = pobjSQLDSTypeEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjSQLDSTypeEN);
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
 /// 日期:20200502010600
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsSQLDSTypeBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrSQLDSTypeObjLst = new Array();
if (strJSON === "")
{
return arrSQLDSTypeObjLst;
}
try
{
arrSQLDSTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSQLDSTypeObjLst;
}
return arrSQLDSTypeObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200502010600
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsSQLDSTypeBL.GetObjByJSONStr  = function(strJSON)
{
var pobjSQLDSTypeEN = new clsSQLDSTypeEN();
if (strJSON === "")
{
return pobjSQLDSTypeEN;
}
try
{
pobjSQLDSTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSQLDSTypeEN;
}
return pobjSQLDSTypeEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objSQLDSTypeENS">源简化对象</param>
 /// <param name = "objSQLDSTypeENT">目标对象</param>
clsSQLDSTypeBL.CopyObjFromSimObj = function(objSQLDSTypeENS, objSQLDSTypeENT) 
{
objSQLDSTypeENT.SQLDSTypeId = objSQLDSTypeENS.SQLDSTypeId; //数据源类型
objSQLDSTypeENT.SqlDsTypeName = objSQLDSTypeENS.SqlDsTypeName; //Sql数据源名
objSQLDSTypeENT.SqlDsTypeENName = objSQLDSTypeENS.SqlDsTypeENName; //Sql数据源英文名
objSQLDSTypeENT.Memo = objSQLDSTypeENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objSQLDSTypeENS">源对象</param>
 /// <param name = "objSQLDSTypeENT">目标对象</param>
clsSQLDSTypeBL.CopyObjTo = function(objSQLDSTypeENS , objSQLDSTypeENT ) 
{
objSQLDSTypeENT.SQLDSTypeId = objSQLDSTypeENS.SQLDSTypeId; //数据源类型
objSQLDSTypeENT.SqlDsTypeName = objSQLDSTypeENS.SqlDsTypeName; //Sql数据源名
objSQLDSTypeENT.SqlDsTypeENName = objSQLDSTypeENS.SqlDsTypeENName; //Sql数据源英文名
objSQLDSTypeENT.Memo = objSQLDSTypeENS.Memo; //说明
objSQLDSTypeENT.sf_UpdFldSetStr = objSQLDSTypeENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objSQLDSTypeENS">源对象</param>
 /// <param name = "objSQLDSTypeENT">目标对象</param>
clsSQLDSTypeBL.CopyObjToSimObj = function(objSQLDSTypeENS , objSQLDSTypeENT ) 
{
objSQLDSTypeENT.SQLDSTypeId = objSQLDSTypeENS.SQLDSTypeId; //数据源类型
objSQLDSTypeENT.SqlDsTypeName = objSQLDSTypeENS.SqlDsTypeName; //Sql数据源名
objSQLDSTypeENT.SqlDsTypeENName = objSQLDSTypeENS.SqlDsTypeENName; //Sql数据源英文名
objSQLDSTypeENT.Memo = objSQLDSTypeENS.Memo; //说明
objSQLDSTypeENT.sf_UpdFldSetStr = objSQLDSTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objSQLDSTypeENT.sf_FldComparisonOp = objSQLDSTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objSQLDSTypeENS">源简化对象</param>
 /// <param name = "objSQLDSTypeENT">目标对象</param>
clsSQLDSTypeBL.CopyObjFromSimObj4Upd = function(objSQLDSTypeENS, objSQLDSTypeENT )
 {
   var strsf_UpdFldSetStr = objSQLDSTypeENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsSQLDSTypeEN.con_SQLDSTypeId)  >= 0)
{
objSQLDSTypeENT.SQLDSTypeId = objSQLDSTypeENS.SQLDSTypeId; //数据源类型
}
if (sstrFldSet.indexOf(clsSQLDSTypeEN.con_SqlDsTypeName)  >= 0)
{
objSQLDSTypeENT.SqlDsTypeName = objSQLDSTypeENS.SqlDsTypeName; //Sql数据源名
}
if (sstrFldSet.indexOf(clsSQLDSTypeEN.con_SqlDsTypeENName)  >= 0)
{
objSQLDSTypeENT.SqlDsTypeENName = objSQLDSTypeENS.SqlDsTypeENName; //Sql数据源英文名
}
if (sstrFldSet.indexOf(clsSQLDSTypeEN.con_Memo)  >= 0)
{
objSQLDSTypeENT.Memo = objSQLDSTypeENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objSQLDSTypeENS">源对象</param>
 /// <param name = "objSQLDSTypeENT">目标对象</param>
clsSQLDSTypeBL.GetSimObjFromObj = function(objSQLDSTypeENS)
{
var objSQLDSTypeENT = new clsSQLDSTypeEN_Sim_js_1.clsSQLDSTypeEN_Sim();
objSQLDSTypeENT.SQLDSTypeId = objSQLDSTypeENS.SQLDSTypeId; //数据源类型
objSQLDSTypeENT.SqlDsTypeName = objSQLDSTypeENS.SqlDsTypeName; //Sql数据源名
objSQLDSTypeENT.SqlDsTypeENName = objSQLDSTypeENS.SqlDsTypeENName; //Sql数据源英文名
objSQLDSTypeENT.Memo = objSQLDSTypeENS.Memo; //说明
objSQLDSTypeENT.sf_UpdFldSetStr = objSQLDSTypeENS.UpdFldString; //专门用于记录某字段属性是否修改
objSQLDSTypeENT.sf_FldComparisonOp = objSQLDSTypeENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objSQLDSTypeENT;
}
return clsSQLDSTypeBL;
}());
exports.clsSQLDSTypeBL = clsSQLDSTypeBL;
});