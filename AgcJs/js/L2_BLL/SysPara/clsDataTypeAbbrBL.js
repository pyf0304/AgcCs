
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataTypeAbbrBL
 表名:DataTypeAbbr(00050023)
 生成代码版本:2020.05.01.1
 生成日期:2020/05/01 02:49:33
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
define(["require", "exports", "jquery", "../../L0_Entity/SysPara/clsDataTypeAbbrEN.js","../../L0_Entity/SysPara/clsDataTypeAbbrEN_Sim.js","../../PubFun/jsString.js","../../PubFun/tzPubFun.js"], factory);
}
})(function(require, exports) {
"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var $ = __importStar(require("jquery"));
var clsDataTypeAbbrEN_js_1 = require("../../L0_Entity/SysPara/clsDataTypeAbbrEN.js");
var clsDataTypeAbbrEN_Sim_js_1 = require("../../L0_Entity/SysPara/clsDataTypeAbbrEN_Sim.js");
var tzDataType_js_1 = require("../../PubFun/jsString.js");
var tzPubFun_js_1 = require("../../PubFun/tzPubFun.js");
 /// <summary>
 /// 数据类型(DataTypeAbbr)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:GeneCode)
 /// </summary>
var clsDataTypeAbbrBL = /** @class */ (function () {
function clsDataTypeAbbrBL()
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// </summary>
this.arrDataTypeAbbrObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// </summary>
this.intFindFailCount = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsDataTypeAbbrBL.prototype.CheckPropertyNew = function(pobjDataTypeAbbrEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (null === pobjDataTypeAbbrEN.DataTypeName 
 || null !== pobjDataTypeAbbrEN.DataTypeName && pobjDataTypeAbbrEN.DataTypeName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[数据类型|数据类型名称]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null === pobjDataTypeAbbrEN.DataCnName 
 || null !== pobjDataTypeAbbrEN.DataCnName && pobjDataTypeAbbrEN.DataCnName.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[数据类型|数据类型中文名称]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null === pobjDataTypeAbbrEN.DataTypeAbbr 
 || null !== pobjDataTypeAbbrEN.DataTypeAbbr && pobjDataTypeAbbrEN.DataTypeAbbr.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[数据类型|数据类型缩写]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null === pobjDataTypeAbbrEN.NetSysType 
 || null !== pobjDataTypeAbbrEN.NetSysType && pobjDataTypeAbbrEN.NetSysType.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[数据类型|NET系统类型]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null === pobjDataTypeAbbrEN.VBNETType 
 || null !== pobjDataTypeAbbrEN.VBNETType && pobjDataTypeAbbrEN.VBNETType.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[数据类型|VBNET类型]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null === pobjDataTypeAbbrEN.CSType 
 || null !== pobjDataTypeAbbrEN.CSType && pobjDataTypeAbbrEN.CSType.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[数据类型|CS类型]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null === pobjDataTypeAbbrEN.JavaType 
 || null !== pobjDataTypeAbbrEN.JavaType && pobjDataTypeAbbrEN.JavaType.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[数据类型|JAVA类型]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null === pobjDataTypeAbbrEN.IsNeedQuote 
 || null !== pobjDataTypeAbbrEN.IsNeedQuote && pobjDataTypeAbbrEN.IsNeedQuote.toString()  ===  "")
{
 throw new Error("(errid:Busi000154)字段[数据类型|是否需要引号]不能为空(NULL)!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjDataTypeAbbrEN.DataTypeId && GetStrLen(pobjDataTypeAbbrEN.DataTypeId) > 2)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|数据类型Id(DataTypeId)]的长度不能超过2!值:$(pobjDataTypeAbbrEN.DataTypeId)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeName && GetStrLen(pobjDataTypeAbbrEN.DataTypeName) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|数据类型名称(DataTypeName)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.DataTypeName)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeENName && GetStrLen(pobjDataTypeAbbrEN.DataTypeENName) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|DataTypeENName(DataTypeENName)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.DataTypeENName)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DataCnName && GetStrLen(pobjDataTypeAbbrEN.DataCnName) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|数据类型中文名称(DataCnName)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.DataCnName)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeAbbr && GetStrLen(pobjDataTypeAbbrEN.DataTypeAbbr) > 5)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|数据类型缩写(DataTypeAbbr)]的长度不能超过5!值:$(pobjDataTypeAbbrEN.DataTypeAbbr)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.NetSysType && GetStrLen(pobjDataTypeAbbrEN.NetSysType) > 20)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|NET系统类型(NetSysType)]的长度不能超过20!值:$(pobjDataTypeAbbrEN.NetSysType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.VBNETType && GetStrLen(pobjDataTypeAbbrEN.VBNETType) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|VBNET类型(VBNETType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.VBNETType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.CSType && GetStrLen(pobjDataTypeAbbrEN.CSType) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|CS类型(CSType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.CSType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.JavaType && GetStrLen(pobjDataTypeAbbrEN.JavaType) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|JAVA类型(JavaType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.JavaType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.TypeScriptType && GetStrLen(pobjDataTypeAbbrEN.TypeScriptType) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|TypeScript类型(TypeScriptType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.TypeScriptType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.JavaObjType && GetStrLen(pobjDataTypeAbbrEN.JavaObjType) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|JAVA对象类型(JavaObjType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.JavaObjType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.SwiftType && GetStrLen(pobjDataTypeAbbrEN.SwiftType) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|SwiftType(SwiftType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.SwiftType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.OraDbType && GetStrLen(pobjDataTypeAbbrEN.OraDbType) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|Ora数据类型(OraDbType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.OraDbType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.SqlParaType && GetStrLen(pobjDataTypeAbbrEN.SqlParaType) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|SQL参数类型(SqlParaType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.SqlParaType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.MySqlType && GetStrLen(pobjDataTypeAbbrEN.MySqlType) > 100)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|MySqlType(MySqlType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.MySqlType)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.Memo && GetStrLen(pobjDataTypeAbbrEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000155)字段[数据类型(DataTypeAbbr)|说明(Memo)]的长度不能超过1000!值:$(pobjDataTypeAbbrEN.Memo)(clsDataTypeAbbrBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null !== pobjDataTypeAbbrEN.DataTypeId && undefined !== pobjDataTypeAbbrEN.DataTypeId && tzDataType.isString(pobjDataTypeAbbrEN.DataTypeId) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|数据类型Id(DataTypeId)]的值:[$(pobjDataTypeAbbrEN.DataTypeId)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeName && undefined !== pobjDataTypeAbbrEN.DataTypeName && tzDataType.isString(pobjDataTypeAbbrEN.DataTypeName) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|数据类型名称(DataTypeName)]的值:[$(pobjDataTypeAbbrEN.DataTypeName)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeENName && undefined !== pobjDataTypeAbbrEN.DataTypeENName && tzDataType.isString(pobjDataTypeAbbrEN.DataTypeENName) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|DataTypeENName(DataTypeENName)]的值:[$(pobjDataTypeAbbrEN.DataTypeENName)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DataCnName && undefined !== pobjDataTypeAbbrEN.DataCnName && tzDataType.isString(pobjDataTypeAbbrEN.DataCnName) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|数据类型中文名称(DataCnName)]的值:[$(pobjDataTypeAbbrEN.DataCnName)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeAbbr && undefined !== pobjDataTypeAbbrEN.DataTypeAbbr && tzDataType.isString(pobjDataTypeAbbrEN.DataTypeAbbr) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|数据类型缩写(DataTypeAbbr)]的值:[$(pobjDataTypeAbbrEN.DataTypeAbbr)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.NetSysType && undefined !== pobjDataTypeAbbrEN.NetSysType && tzDataType.isString(pobjDataTypeAbbrEN.NetSysType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|NET系统类型(NetSysType)]的值:[$(pobjDataTypeAbbrEN.NetSysType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.VBNETType && undefined !== pobjDataTypeAbbrEN.VBNETType && tzDataType.isString(pobjDataTypeAbbrEN.VBNETType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|VBNET类型(VBNETType)]的值:[$(pobjDataTypeAbbrEN.VBNETType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.CSType && undefined !== pobjDataTypeAbbrEN.CSType && tzDataType.isString(pobjDataTypeAbbrEN.CSType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|CS类型(CSType)]的值:[$(pobjDataTypeAbbrEN.CSType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.JavaType && undefined !== pobjDataTypeAbbrEN.JavaType && tzDataType.isString(pobjDataTypeAbbrEN.JavaType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|JAVA类型(JavaType)]的值:[$(pobjDataTypeAbbrEN.JavaType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.TypeScriptType && undefined !== pobjDataTypeAbbrEN.TypeScriptType && tzDataType.isString(pobjDataTypeAbbrEN.TypeScriptType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|TypeScript类型(TypeScriptType)]的值:[$(pobjDataTypeAbbrEN.TypeScriptType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.JavaObjType && undefined !== pobjDataTypeAbbrEN.JavaObjType && tzDataType.isString(pobjDataTypeAbbrEN.JavaObjType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|JAVA对象类型(JavaObjType)]的值:[$(pobjDataTypeAbbrEN.JavaObjType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.SwiftType && undefined !== pobjDataTypeAbbrEN.SwiftType && tzDataType.isString(pobjDataTypeAbbrEN.SwiftType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|SwiftType(SwiftType)]的值:[$(pobjDataTypeAbbrEN.SwiftType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.IsNeedQuote && undefined !== pobjDataTypeAbbrEN.IsNeedQuote && tzDataType.isBoolean(pobjDataTypeAbbrEN.IsNeedQuote) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|是否需要引号(IsNeedQuote)]的值:[$(pobjDataTypeAbbrEN.IsNeedQuote)], 非法，应该为布尔型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.OraDbType && undefined !== pobjDataTypeAbbrEN.OraDbType && tzDataType.isString(pobjDataTypeAbbrEN.OraDbType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|Ora数据类型(OraDbType)]的值:[$(pobjDataTypeAbbrEN.OraDbType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.IsReturnType && undefined !== pobjDataTypeAbbrEN.IsReturnType && tzDataType.isBoolean(pobjDataTypeAbbrEN.IsReturnType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|是否可作返回类型(IsReturnType)]的值:[$(pobjDataTypeAbbrEN.IsReturnType)], 非法，应该为布尔型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.SqlParaType && undefined !== pobjDataTypeAbbrEN.SqlParaType && tzDataType.isString(pobjDataTypeAbbrEN.SqlParaType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|SQL参数类型(SqlParaType)]的值:[$(pobjDataTypeAbbrEN.SqlParaType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.MySqlType && undefined !== pobjDataTypeAbbrEN.MySqlType && tzDataType.isString(pobjDataTypeAbbrEN.MySqlType) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|MySqlType(MySqlType)]的值:[$(pobjDataTypeAbbrEN.MySqlType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DefaFldLength && undefined !== pobjDataTypeAbbrEN.DefaFldLength && tzDataType.isNumber(pobjDataTypeAbbrEN.DefaFldLength) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|默认长度(DefaFldLength)]的值:[$(pobjDataTypeAbbrEN.DefaFldLength)], 非法，应该为数值型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.DefaFldPrecision && undefined !== pobjDataTypeAbbrEN.DefaFldPrecision && tzDataType.isNumber(pobjDataTypeAbbrEN.DefaFldPrecision) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|默认小数位数(DefaFldPrecision)]的值:[$(pobjDataTypeAbbrEN.DefaFldPrecision)], 非法，应该为数值型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
if (null !== pobjDataTypeAbbrEN.Memo && undefined !== pobjDataTypeAbbrEN.Memo && tzDataType.isString(pobjDataTypeAbbrEN.Memo) === false)
{
 throw new Error("(errid:Busi000156)字段[数据类型(DataTypeAbbr)|说明(Memo)]的值:[$(pobjDataTypeAbbrEN.Memo)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjDataTypeAbbrEN._IsCheckProperty = true;
};
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CheckPropertyNew)
 /// </summary>
 clsDataTypeAbbrBL.prototype.CheckProperty4Update  = function(pobjDataTypeAbbrEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (null !== pobjDataTypeAbbrEN.DataTypeId && GetStrLen(pobjDataTypeAbbrEN.DataTypeId) > 2)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|数据类型Id(DataTypeId)]的长度不能超过2!值:$(pobjDataTypeAbbrEN.DataTypeId)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeName && GetStrLen(pobjDataTypeAbbrEN.DataTypeName) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|数据类型名称(DataTypeName)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.DataTypeName)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeENName && GetStrLen(pobjDataTypeAbbrEN.DataTypeENName) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|DataTypeENName(DataTypeENName)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.DataTypeENName)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DataCnName && GetStrLen(pobjDataTypeAbbrEN.DataCnName) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|数据类型中文名称(DataCnName)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.DataCnName)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeAbbr && GetStrLen(pobjDataTypeAbbrEN.DataTypeAbbr) > 5)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|数据类型缩写(DataTypeAbbr)]的长度不能超过5!值:$(pobjDataTypeAbbrEN.DataTypeAbbr)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.NetSysType && GetStrLen(pobjDataTypeAbbrEN.NetSysType) > 20)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|NET系统类型(NetSysType)]的长度不能超过20!值:$(pobjDataTypeAbbrEN.NetSysType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.VBNETType && GetStrLen(pobjDataTypeAbbrEN.VBNETType) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|VBNET类型(VBNETType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.VBNETType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.CSType && GetStrLen(pobjDataTypeAbbrEN.CSType) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|CS类型(CSType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.CSType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.JavaType && GetStrLen(pobjDataTypeAbbrEN.JavaType) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|JAVA类型(JavaType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.JavaType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.TypeScriptType && GetStrLen(pobjDataTypeAbbrEN.TypeScriptType) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|TypeScript类型(TypeScriptType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.TypeScriptType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.JavaObjType && GetStrLen(pobjDataTypeAbbrEN.JavaObjType) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|JAVA对象类型(JavaObjType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.JavaObjType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.SwiftType && GetStrLen(pobjDataTypeAbbrEN.SwiftType) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|SwiftType(SwiftType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.SwiftType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.OraDbType && GetStrLen(pobjDataTypeAbbrEN.OraDbType) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|Ora数据类型(OraDbType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.OraDbType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.SqlParaType && GetStrLen(pobjDataTypeAbbrEN.SqlParaType) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|SQL参数类型(SqlParaType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.SqlParaType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.MySqlType && GetStrLen(pobjDataTypeAbbrEN.MySqlType) > 100)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|MySqlType(MySqlType)]的长度不能超过100!值:$(pobjDataTypeAbbrEN.MySqlType)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.Memo && GetStrLen(pobjDataTypeAbbrEN.Memo) > 1000)
{
 throw new Error("(errid:Busi000158)字段[数据类型(DataTypeAbbr)|说明(Memo)]的长度不能超过1000!值:$(pobjDataTypeAbbrEN.Memo)(clsDataTypeAbbrBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null !== pobjDataTypeAbbrEN.DataTypeId && undefined !== pobjDataTypeAbbrEN.DataTypeId && tzDataType.isString(pobjDataTypeAbbrEN.DataTypeId) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|数据类型Id(DataTypeId)]的值:[$(pobjDataTypeAbbrEN.DataTypeId)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeName && undefined !== pobjDataTypeAbbrEN.DataTypeName && tzDataType.isString(pobjDataTypeAbbrEN.DataTypeName) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|数据类型名称(DataTypeName)]的值:[$(pobjDataTypeAbbrEN.DataTypeName)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeENName && undefined !== pobjDataTypeAbbrEN.DataTypeENName && tzDataType.isString(pobjDataTypeAbbrEN.DataTypeENName) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|DataTypeENName(DataTypeENName)]的值:[$(pobjDataTypeAbbrEN.DataTypeENName)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DataCnName && undefined !== pobjDataTypeAbbrEN.DataCnName && tzDataType.isString(pobjDataTypeAbbrEN.DataCnName) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|数据类型中文名称(DataCnName)]的值:[$(pobjDataTypeAbbrEN.DataCnName)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DataTypeAbbr && undefined !== pobjDataTypeAbbrEN.DataTypeAbbr && tzDataType.isString(pobjDataTypeAbbrEN.DataTypeAbbr) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|数据类型缩写(DataTypeAbbr)]的值:[$(pobjDataTypeAbbrEN.DataTypeAbbr)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.NetSysType && undefined !== pobjDataTypeAbbrEN.NetSysType && tzDataType.isString(pobjDataTypeAbbrEN.NetSysType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|NET系统类型(NetSysType)]的值:[$(pobjDataTypeAbbrEN.NetSysType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.VBNETType && undefined !== pobjDataTypeAbbrEN.VBNETType && tzDataType.isString(pobjDataTypeAbbrEN.VBNETType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|VBNET类型(VBNETType)]的值:[$(pobjDataTypeAbbrEN.VBNETType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.CSType && undefined !== pobjDataTypeAbbrEN.CSType && tzDataType.isString(pobjDataTypeAbbrEN.CSType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|CS类型(CSType)]的值:[$(pobjDataTypeAbbrEN.CSType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.JavaType && undefined !== pobjDataTypeAbbrEN.JavaType && tzDataType.isString(pobjDataTypeAbbrEN.JavaType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|JAVA类型(JavaType)]的值:[$(pobjDataTypeAbbrEN.JavaType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.TypeScriptType && undefined !== pobjDataTypeAbbrEN.TypeScriptType && tzDataType.isString(pobjDataTypeAbbrEN.TypeScriptType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|TypeScript类型(TypeScriptType)]的值:[$(pobjDataTypeAbbrEN.TypeScriptType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.JavaObjType && undefined !== pobjDataTypeAbbrEN.JavaObjType && tzDataType.isString(pobjDataTypeAbbrEN.JavaObjType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|JAVA对象类型(JavaObjType)]的值:[$(pobjDataTypeAbbrEN.JavaObjType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.SwiftType && undefined !== pobjDataTypeAbbrEN.SwiftType && tzDataType.isString(pobjDataTypeAbbrEN.SwiftType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|SwiftType(SwiftType)]的值:[$(pobjDataTypeAbbrEN.SwiftType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.IsNeedQuote && undefined !== pobjDataTypeAbbrEN.IsNeedQuote && tzDataType.isBoolean(pobjDataTypeAbbrEN.IsNeedQuote) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|是否需要引号(IsNeedQuote)]的值:[$(pobjDataTypeAbbrEN.IsNeedQuote)], 非法，应该为布尔型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.OraDbType && undefined !== pobjDataTypeAbbrEN.OraDbType && tzDataType.isString(pobjDataTypeAbbrEN.OraDbType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|Ora数据类型(OraDbType)]的值:[$(pobjDataTypeAbbrEN.OraDbType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.IsReturnType && undefined !== pobjDataTypeAbbrEN.IsReturnType && tzDataType.isBoolean(pobjDataTypeAbbrEN.IsReturnType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|是否可作返回类型(IsReturnType)]的值:[$(pobjDataTypeAbbrEN.IsReturnType)], 非法，应该为布尔型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.SqlParaType && undefined !== pobjDataTypeAbbrEN.SqlParaType && tzDataType.isString(pobjDataTypeAbbrEN.SqlParaType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|SQL参数类型(SqlParaType)]的值:[$(pobjDataTypeAbbrEN.SqlParaType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.MySqlType && undefined !== pobjDataTypeAbbrEN.MySqlType && tzDataType.isString(pobjDataTypeAbbrEN.MySqlType) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|MySqlType(MySqlType)]的值:[$(pobjDataTypeAbbrEN.MySqlType)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DefaFldLength && undefined !== pobjDataTypeAbbrEN.DefaFldLength && tzDataType.isNumber(pobjDataTypeAbbrEN.DefaFldLength) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|默认长度(DefaFldLength)]的值:[$(pobjDataTypeAbbrEN.DefaFldLength)], 非法，应该为数值型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.DefaFldPrecision && undefined !== pobjDataTypeAbbrEN.DefaFldPrecision && tzDataType.isNumber(pobjDataTypeAbbrEN.DefaFldPrecision) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|默认小数位数(DefaFldPrecision)]的值:[$(pobjDataTypeAbbrEN.DefaFldPrecision)], 非法，应该为数值型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
if (null !== pobjDataTypeAbbrEN.Memo && undefined !== pobjDataTypeAbbrEN.Memo && tzDataType.isString(pobjDataTypeAbbrEN.Memo) === false)
{
 throw new Error("(errid:Busi000159)字段[数据类型(DataTypeAbbr)|说明(Memo)]的值:[$(pobjDataTypeAbbrEN.Memo)], 非法，应该为字符型!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjDataTypeAbbrEN.DataTypeId 
 || null !== pobjDataTypeAbbrEN.DataTypeId && pobjDataTypeAbbrEN.DataTypeId.toString()  ===  ""
 || null !== pobjDataTypeAbbrEN.DataTypeId && pobjDataTypeAbbrEN.DataTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Busi000160)字段[数据类型|数据类型Id]不能为空(NULL)!(clsDataTypeAbbrBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjDataTypeAbbrEN._IsCheckProperty = true;
};

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20200501024933
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getJSONStrByRecObj)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsDataTypeAbbrBL.GetJSONStrByObj  = function(pobjDataTypeAbbrEN)
{
pobjDataTypeAbbrEN.sf_UpdFldSetStr = pobjDataTypeAbbrEN.UpdFldString;
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjDataTypeAbbrEN);
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
 /// 日期:20200501024933
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getObjLstByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
clsDataTypeAbbrBL.GetObjLstByJSONStr  = function(strJSON)
{
var arrDataTypeAbbrObjLst = new Array();
if (strJSON === "")
{
return arrDataTypeAbbrObjLst;
}
try
{
arrDataTypeAbbrObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrDataTypeAbbrObjLst;
}
return arrDataTypeAbbrObjLst;
};

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20200501024933
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_getRecObjByJSONStr)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
clsDataTypeAbbrBL.GetObjByJSONStr  = function(strJSON)
{
var pobjDataTypeAbbrEN = new clsDataTypeAbbrEN();
if (strJSON === "")
{
return pobjDataTypeAbbrEN;
}
try
{
pobjDataTypeAbbrEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjDataTypeAbbrEN;
}
return pobjDataTypeAbbrEN;
};

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj)
 /// </summary>
 /// <param name = "objDataTypeAbbrENS">源简化对象</param>
 /// <param name = "objDataTypeAbbrENT">目标对象</param>
clsDataTypeAbbrBL.CopyObjFromSimObj = function(objDataTypeAbbrENS, objDataTypeAbbrENT) 
{
objDataTypeAbbrENT.DataTypeId = objDataTypeAbbrENS.DataTypeId; //数据类型Id
objDataTypeAbbrENT.DataTypeName = objDataTypeAbbrENS.DataTypeName; //数据类型名称
objDataTypeAbbrENT.DataTypeENName = objDataTypeAbbrENS.DataTypeENName; //DataTypeENName
objDataTypeAbbrENT.DataCnName = objDataTypeAbbrENS.DataCnName; //数据类型中文名称
objDataTypeAbbrENT.DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr; //数据类型缩写
objDataTypeAbbrENT.NetSysType = objDataTypeAbbrENS.NetSysType; //NET系统类型
objDataTypeAbbrENT.VBNETType = objDataTypeAbbrENS.VBNETType; //VBNET类型
objDataTypeAbbrENT.CSType = objDataTypeAbbrENS.CSType; //CS类型
objDataTypeAbbrENT.JavaType = objDataTypeAbbrENS.JavaType; //JAVA类型
objDataTypeAbbrENT.TypeScriptType = objDataTypeAbbrENS.TypeScriptType; //TypeScript类型
objDataTypeAbbrENT.JavaObjType = objDataTypeAbbrENS.JavaObjType; //JAVA对象类型
objDataTypeAbbrENT.SwiftType = objDataTypeAbbrENS.SwiftType; //SwiftType
objDataTypeAbbrENT.IsNeedQuote = objDataTypeAbbrENS.IsNeedQuote; //是否需要引号
objDataTypeAbbrENT.OraDbType = objDataTypeAbbrENS.OraDbType; //Ora数据类型
objDataTypeAbbrENT.IsReturnType = objDataTypeAbbrENS.IsReturnType; //是否可作返回类型
objDataTypeAbbrENT.SqlParaType = objDataTypeAbbrENS.SqlParaType; //SQL参数类型
objDataTypeAbbrENT.MySqlType = objDataTypeAbbrENS.MySqlType; //MySqlType
objDataTypeAbbrENT.DefaFldLength = objDataTypeAbbrENS.DefaFldLength; //默认长度
objDataTypeAbbrENT.DefaFldPrecision = objDataTypeAbbrENS.DefaFldPrecision; //默认小数位数
objDataTypeAbbrENT.Memo = objDataTypeAbbrENS.Memo; //说明
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjTo)
 /// </summary>
 /// <param name = "objDataTypeAbbrENS">源对象</param>
 /// <param name = "objDataTypeAbbrENT">目标对象</param>
clsDataTypeAbbrBL.CopyObjTo = function(objDataTypeAbbrENS , objDataTypeAbbrENT ) 
{
objDataTypeAbbrENT.DataTypeId = objDataTypeAbbrENS.DataTypeId; //数据类型Id
objDataTypeAbbrENT.DataTypeName = objDataTypeAbbrENS.DataTypeName; //数据类型名称
objDataTypeAbbrENT.DataTypeENName = objDataTypeAbbrENS.DataTypeENName; //DataTypeENName
objDataTypeAbbrENT.DataCnName = objDataTypeAbbrENS.DataCnName; //数据类型中文名称
objDataTypeAbbrENT.DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr; //数据类型缩写
objDataTypeAbbrENT.NetSysType = objDataTypeAbbrENS.NetSysType; //NET系统类型
objDataTypeAbbrENT.VBNETType = objDataTypeAbbrENS.VBNETType; //VBNET类型
objDataTypeAbbrENT.CSType = objDataTypeAbbrENS.CSType; //CS类型
objDataTypeAbbrENT.JavaType = objDataTypeAbbrENS.JavaType; //JAVA类型
objDataTypeAbbrENT.TypeScriptType = objDataTypeAbbrENS.TypeScriptType; //TypeScript类型
objDataTypeAbbrENT.JavaObjType = objDataTypeAbbrENS.JavaObjType; //JAVA对象类型
objDataTypeAbbrENT.SwiftType = objDataTypeAbbrENS.SwiftType; //SwiftType
objDataTypeAbbrENT.IsNeedQuote = objDataTypeAbbrENS.IsNeedQuote; //是否需要引号
objDataTypeAbbrENT.OraDbType = objDataTypeAbbrENS.OraDbType; //Ora数据类型
objDataTypeAbbrENT.IsReturnType = objDataTypeAbbrENS.IsReturnType; //是否可作返回类型
objDataTypeAbbrENT.SqlParaType = objDataTypeAbbrENS.SqlParaType; //SQL参数类型
objDataTypeAbbrENT.MySqlType = objDataTypeAbbrENS.MySqlType; //MySqlType
objDataTypeAbbrENT.DefaFldLength = objDataTypeAbbrENS.DefaFldLength; //默认长度
objDataTypeAbbrENT.DefaFldPrecision = objDataTypeAbbrENS.DefaFldPrecision; //默认小数位数
objDataTypeAbbrENT.Memo = objDataTypeAbbrENS.Memo; //说明
objDataTypeAbbrENT.sf_UpdFldSetStr = objDataTypeAbbrENS.UpdFldString; //sf_UpdFldSetStr
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjToSimObj)
 /// </summary>
 /// <param name = "objDataTypeAbbrENS">源对象</param>
 /// <param name = "objDataTypeAbbrENT">目标对象</param>
clsDataTypeAbbrBL.CopyObjToSimObj = function(objDataTypeAbbrENS , objDataTypeAbbrENT ) 
{
objDataTypeAbbrENT.DataTypeId = objDataTypeAbbrENS.DataTypeId; //数据类型Id
objDataTypeAbbrENT.DataTypeName = objDataTypeAbbrENS.DataTypeName; //数据类型名称
objDataTypeAbbrENT.DataTypeENName = objDataTypeAbbrENS.DataTypeENName; //DataTypeENName
objDataTypeAbbrENT.DataCnName = objDataTypeAbbrENS.DataCnName; //数据类型中文名称
objDataTypeAbbrENT.DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr; //数据类型缩写
objDataTypeAbbrENT.NetSysType = objDataTypeAbbrENS.NetSysType; //NET系统类型
objDataTypeAbbrENT.VBNETType = objDataTypeAbbrENS.VBNETType; //VBNET类型
objDataTypeAbbrENT.CSType = objDataTypeAbbrENS.CSType; //CS类型
objDataTypeAbbrENT.JavaType = objDataTypeAbbrENS.JavaType; //JAVA类型
objDataTypeAbbrENT.TypeScriptType = objDataTypeAbbrENS.TypeScriptType; //TypeScript类型
objDataTypeAbbrENT.JavaObjType = objDataTypeAbbrENS.JavaObjType; //JAVA对象类型
objDataTypeAbbrENT.SwiftType = objDataTypeAbbrENS.SwiftType; //SwiftType
objDataTypeAbbrENT.IsNeedQuote = objDataTypeAbbrENS.IsNeedQuote; //是否需要引号
objDataTypeAbbrENT.OraDbType = objDataTypeAbbrENS.OraDbType; //Ora数据类型
objDataTypeAbbrENT.IsReturnType = objDataTypeAbbrENS.IsReturnType; //是否可作返回类型
objDataTypeAbbrENT.SqlParaType = objDataTypeAbbrENS.SqlParaType; //SQL参数类型
objDataTypeAbbrENT.MySqlType = objDataTypeAbbrENS.MySqlType; //MySqlType
objDataTypeAbbrENT.DefaFldLength = objDataTypeAbbrENS.DefaFldLength; //默认长度
objDataTypeAbbrENT.DefaFldPrecision = objDataTypeAbbrENS.DefaFldPrecision; //默认小数位数
objDataTypeAbbrENT.Memo = objDataTypeAbbrENS.Memo; //说明
objDataTypeAbbrENT.sf_UpdFldSetStr = objDataTypeAbbrENS.UpdFldString; //专门用于记录某字段属性是否修改
objDataTypeAbbrENT.sf_FldComparisonOp = objDataTypeAbbrENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
}

 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_CopyObjFromSimObj4Upd)
 /// </summary>
 /// <param name = "objDataTypeAbbrENS">源简化对象</param>
 /// <param name = "objDataTypeAbbrENT">目标对象</param>
clsDataTypeAbbrBL.CopyObjFromSimObj4Upd = function(objDataTypeAbbrENS, objDataTypeAbbrENT )
 {
   var strsf_UpdFldSetStr = objDataTypeAbbrENS.sf_UpdFldSetStr;
    var sstrFldSet = strsf_UpdFldSetStr.split('|');
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_DataTypeId)  >= 0)
{
objDataTypeAbbrENT.DataTypeId = objDataTypeAbbrENS.DataTypeId; //数据类型Id
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_DataTypeName)  >= 0)
{
objDataTypeAbbrENT.DataTypeName = objDataTypeAbbrENS.DataTypeName; //数据类型名称
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_DataTypeENName)  >= 0)
{
objDataTypeAbbrENT.DataTypeENName = objDataTypeAbbrENS.DataTypeENName; //DataTypeENName
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_DataCnName)  >= 0)
{
objDataTypeAbbrENT.DataCnName = objDataTypeAbbrENS.DataCnName; //数据类型中文名称
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_DataTypeAbbr)  >= 0)
{
objDataTypeAbbrENT.DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr; //数据类型缩写
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_NetSysType)  >= 0)
{
objDataTypeAbbrENT.NetSysType = objDataTypeAbbrENS.NetSysType; //NET系统类型
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_VBNETType)  >= 0)
{
objDataTypeAbbrENT.VBNETType = objDataTypeAbbrENS.VBNETType; //VBNET类型
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_CSType)  >= 0)
{
objDataTypeAbbrENT.CSType = objDataTypeAbbrENS.CSType; //CS类型
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_JavaType)  >= 0)
{
objDataTypeAbbrENT.JavaType = objDataTypeAbbrENS.JavaType; //JAVA类型
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_TypeScriptType)  >= 0)
{
objDataTypeAbbrENT.TypeScriptType = objDataTypeAbbrENS.TypeScriptType; //TypeScript类型
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_JavaObjType)  >= 0)
{
objDataTypeAbbrENT.JavaObjType = objDataTypeAbbrENS.JavaObjType; //JAVA对象类型
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_SwiftType)  >= 0)
{
objDataTypeAbbrENT.SwiftType = objDataTypeAbbrENS.SwiftType; //SwiftType
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_IsNeedQuote)  >= 0)
{
objDataTypeAbbrENT.IsNeedQuote = objDataTypeAbbrENS.IsNeedQuote; //是否需要引号
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_OraDbType)  >= 0)
{
objDataTypeAbbrENT.OraDbType = objDataTypeAbbrENS.OraDbType; //Ora数据类型
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_IsReturnType)  >= 0)
{
objDataTypeAbbrENT.IsReturnType = objDataTypeAbbrENS.IsReturnType; //是否可作返回类型
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_SqlParaType)  >= 0)
{
objDataTypeAbbrENT.SqlParaType = objDataTypeAbbrENS.SqlParaType; //SQL参数类型
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_MySqlType)  >= 0)
{
objDataTypeAbbrENT.MySqlType = objDataTypeAbbrENS.MySqlType; //MySqlType
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_DefaFldLength)  >= 0)
{
objDataTypeAbbrENT.DefaFldLength = objDataTypeAbbrENS.DefaFldLength; //默认长度
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_DefaFldPrecision)  >= 0)
{
objDataTypeAbbrENT.DefaFldPrecision = objDataTypeAbbrENS.DefaFldPrecision; //默认小数位数
}
if (sstrFldSet.indexOf(clsDataTypeAbbrEN.con_Memo)  >= 0)
{
objDataTypeAbbrENT.Memo = objDataTypeAbbrENS.Memo; //说明
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// (AutoGCLib.BusinessLogicRJ4JavaScript:Gen_4BL_Ts_GetSimObjFromObj)
 /// </summary>
 /// <param name = "objDataTypeAbbrENS">源对象</param>
 /// <param name = "objDataTypeAbbrENT">目标对象</param>
clsDataTypeAbbrBL.GetSimObjFromObj = function(objDataTypeAbbrENS)
{
var objDataTypeAbbrENT = new clsDataTypeAbbrEN_Sim_js_1.clsDataTypeAbbrEN_Sim();
objDataTypeAbbrENT.DataTypeId = objDataTypeAbbrENS.DataTypeId; //数据类型Id
objDataTypeAbbrENT.DataTypeName = objDataTypeAbbrENS.DataTypeName; //数据类型名称
objDataTypeAbbrENT.DataTypeENName = objDataTypeAbbrENS.DataTypeENName; //DataTypeENName
objDataTypeAbbrENT.DataCnName = objDataTypeAbbrENS.DataCnName; //数据类型中文名称
objDataTypeAbbrENT.DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr; //数据类型缩写
objDataTypeAbbrENT.NetSysType = objDataTypeAbbrENS.NetSysType; //NET系统类型
objDataTypeAbbrENT.VBNETType = objDataTypeAbbrENS.VBNETType; //VBNET类型
objDataTypeAbbrENT.CSType = objDataTypeAbbrENS.CSType; //CS类型
objDataTypeAbbrENT.JavaType = objDataTypeAbbrENS.JavaType; //JAVA类型
objDataTypeAbbrENT.TypeScriptType = objDataTypeAbbrENS.TypeScriptType; //TypeScript类型
objDataTypeAbbrENT.JavaObjType = objDataTypeAbbrENS.JavaObjType; //JAVA对象类型
objDataTypeAbbrENT.SwiftType = objDataTypeAbbrENS.SwiftType; //SwiftType
objDataTypeAbbrENT.IsNeedQuote = objDataTypeAbbrENS.IsNeedQuote; //是否需要引号
objDataTypeAbbrENT.OraDbType = objDataTypeAbbrENS.OraDbType; //Ora数据类型
objDataTypeAbbrENT.IsReturnType = objDataTypeAbbrENS.IsReturnType; //是否可作返回类型
objDataTypeAbbrENT.SqlParaType = objDataTypeAbbrENS.SqlParaType; //SQL参数类型
objDataTypeAbbrENT.MySqlType = objDataTypeAbbrENS.MySqlType; //MySqlType
objDataTypeAbbrENT.DefaFldLength = objDataTypeAbbrENS.DefaFldLength; //默认长度
objDataTypeAbbrENT.DefaFldPrecision = objDataTypeAbbrENS.DefaFldPrecision; //默认小数位数
objDataTypeAbbrENT.Memo = objDataTypeAbbrENS.Memo; //说明
objDataTypeAbbrENT.sf_UpdFldSetStr = objDataTypeAbbrENS.UpdFldString; //专门用于记录某字段属性是否修改
objDataTypeAbbrENT.sf_FldComparisonOp = objDataTypeAbbrENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
 return objDataTypeAbbrENT;
}
return clsDataTypeAbbrBL;
}());
exports.clsDataTypeAbbrBL = clsDataTypeAbbrBL;
});