
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataTypeAbbrWApi
 表名:DataTypeAbbr(00050023)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
 框架-层名:WA_访问层(CS)(WA_Access,0045)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using AGC.Entity;

namespace AGC4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsDataTypeAbbrWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataTypeId(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conDataTypeAbbr.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conDataTypeAbbr.DataTypeId);
objDataTypeAbbrEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataTypeId) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataTypeId, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataTypeId] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataTypeName(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, conDataTypeAbbr.DataTypeName);
clsCheckSql.CheckFieldLen(strDataTypeName, 100, conDataTypeAbbr.DataTypeName);
objDataTypeAbbrEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataTypeName) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataTypeName, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataTypeName] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeENName">DataTypeENName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataTypeENName(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeENName, 100, conDataTypeAbbr.DataTypeENName);
objDataTypeAbbrEN.DataTypeENName = strDataTypeENName; //DataTypeENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataTypeENName) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataTypeENName, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataTypeENName] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataCnName">数据类型中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataCnName(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataCnName, conDataTypeAbbr.DataCnName);
clsCheckSql.CheckFieldLen(strDataCnName, 100, conDataTypeAbbr.DataCnName);
objDataTypeAbbrEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataCnName) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataCnName, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataCnName] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeAbbr">数据类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataTypeAbbr(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeAbbr, conDataTypeAbbr.DataTypeAbbr);
clsCheckSql.CheckFieldLen(strDataTypeAbbr, 5, conDataTypeAbbr.DataTypeAbbr);
objDataTypeAbbrEN.DataTypeAbbr = strDataTypeAbbr; //数据类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataTypeAbbr) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataTypeAbbr, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataTypeAbbr] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strNetSysType">NET系统类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetNetSysType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strNetSysType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNetSysType, conDataTypeAbbr.NetSysType);
clsCheckSql.CheckFieldLen(strNetSysType, 20, conDataTypeAbbr.NetSysType);
objDataTypeAbbrEN.NetSysType = strNetSysType; //NET系统类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.NetSysType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.NetSysType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.NetSysType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strVbNetType">VBNET类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetVbNetType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strVbNetType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVbNetType, conDataTypeAbbr.VbNetType);
clsCheckSql.CheckFieldLen(strVbNetType, 100, conDataTypeAbbr.VbNetType);
objDataTypeAbbrEN.VbNetType = strVbNetType; //VBNET类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.VbNetType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.VbNetType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.VbNetType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strCsType">CS类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetCsType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, conDataTypeAbbr.CsType);
clsCheckSql.CheckFieldLen(strCsType, 100, conDataTypeAbbr.CsType);
objDataTypeAbbrEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.CsType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.CsType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.CsType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaType">JAVA类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetJavaType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJavaType, conDataTypeAbbr.JavaType);
clsCheckSql.CheckFieldLen(strJavaType, 100, conDataTypeAbbr.JavaType);
objDataTypeAbbrEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.JavaType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.JavaType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.JavaType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strTypeScriptType">TypeScript类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetTypeScriptType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strTypeScriptType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTypeScriptType, 100, conDataTypeAbbr.TypeScriptType);
objDataTypeAbbrEN.TypeScriptType = strTypeScriptType; //TypeScript类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.TypeScriptType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.TypeScriptType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.TypeScriptType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaObjType">JAVA对象类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetJavaObjType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strJavaObjType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, conDataTypeAbbr.JavaObjType);
objDataTypeAbbrEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.JavaObjType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.JavaObjType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.JavaObjType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strSwiftType">SwiftType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetSwiftType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strSwiftType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSwiftType, 100, conDataTypeAbbr.SwiftType);
objDataTypeAbbrEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.SwiftType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.SwiftType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.SwiftType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedQuote">是否需要引号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetIsNeedQuote(this clsDataTypeAbbrEN objDataTypeAbbrEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedQuote, conDataTypeAbbr.IsNeedQuote);
objDataTypeAbbrEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.IsNeedQuote) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.IsNeedQuote, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.IsNeedQuote] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strOraDbType">Ora数据类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetOraDbType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOraDbType, 100, conDataTypeAbbr.OraDbType);
objDataTypeAbbrEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.OraDbType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.OraDbType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.OraDbType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsReturnType">是否可作返回类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetIsReturnType(this clsDataTypeAbbrEN objDataTypeAbbrEN, bool bolIsReturnType, string strComparisonOp="")
	{
objDataTypeAbbrEN.IsReturnType = bolIsReturnType; //是否可作返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.IsReturnType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.IsReturnType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.IsReturnType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlParaType">SQL参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetSqlParaType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strSqlParaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlParaType, 100, conDataTypeAbbr.SqlParaType);
objDataTypeAbbrEN.SqlParaType = strSqlParaType; //SQL参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.SqlParaType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.SqlParaType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.SqlParaType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strMySqlType">MySqlType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetMySqlType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strMySqlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMySqlType, 100, conDataTypeAbbr.MySqlType);
objDataTypeAbbrEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.MySqlType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.MySqlType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.MySqlType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "intDefaFldLength">默认长度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDefaFldLength(this clsDataTypeAbbrEN objDataTypeAbbrEN, int intDefaFldLength, string strComparisonOp="")
	{
objDataTypeAbbrEN.DefaFldLength = intDefaFldLength; //默认长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DefaFldLength) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DefaFldLength, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DefaFldLength] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "intDefaFldPrecision">默认小数位数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDefaFldPrecision(this clsDataTypeAbbrEN objDataTypeAbbrEN, int intDefaFldPrecision, string strComparisonOp="")
	{
objDataTypeAbbrEN.DefaFldPrecision = intDefaFldPrecision; //默认小数位数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DefaFldPrecision) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DefaFldPrecision, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DefaFldPrecision] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetMemo(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataTypeAbbr.Memo);
objDataTypeAbbrEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.Memo) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.Memo, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.Memo] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataTypeAbbrEN objDataTypeAbbrCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataTypeId, objDataTypeAbbrCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataTypeName, objDataTypeAbbrCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataTypeENName) == true)
{
string strComparisonOpDataTypeENName = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataTypeENName, objDataTypeAbbrCond.DataTypeENName, strComparisonOpDataTypeENName);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataCnName) == true)
{
string strComparisonOpDataCnName = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataCnName, objDataTypeAbbrCond.DataCnName, strComparisonOpDataCnName);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataTypeAbbr) == true)
{
string strComparisonOpDataTypeAbbr = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataTypeAbbr, objDataTypeAbbrCond.DataTypeAbbr, strComparisonOpDataTypeAbbr);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.NetSysType) == true)
{
string strComparisonOpNetSysType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.NetSysType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.NetSysType, objDataTypeAbbrCond.NetSysType, strComparisonOpNetSysType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.VbNetType) == true)
{
string strComparisonOpVbNetType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.VbNetType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.VbNetType, objDataTypeAbbrCond.VbNetType, strComparisonOpVbNetType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.CsType) == true)
{
string strComparisonOpCsType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.CsType, objDataTypeAbbrCond.CsType, strComparisonOpCsType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.JavaType) == true)
{
string strComparisonOpJavaType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.JavaType, objDataTypeAbbrCond.JavaType, strComparisonOpJavaType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.TypeScriptType) == true)
{
string strComparisonOpTypeScriptType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.TypeScriptType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.TypeScriptType, objDataTypeAbbrCond.TypeScriptType, strComparisonOpTypeScriptType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.JavaObjType, objDataTypeAbbrCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.SwiftType) == true)
{
string strComparisonOpSwiftType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.SwiftType, objDataTypeAbbrCond.SwiftType, strComparisonOpSwiftType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.IsNeedQuote) == true)
{
if (objDataTypeAbbrCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataTypeAbbr.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataTypeAbbr.IsNeedQuote);
}
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.OraDbType) == true)
{
string strComparisonOpOraDbType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.OraDbType, objDataTypeAbbrCond.OraDbType, strComparisonOpOraDbType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.IsReturnType) == true)
{
if (objDataTypeAbbrCond.IsReturnType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataTypeAbbr.IsReturnType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataTypeAbbr.IsReturnType);
}
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.SqlParaType) == true)
{
string strComparisonOpSqlParaType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.SqlParaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.SqlParaType, objDataTypeAbbrCond.SqlParaType, strComparisonOpSqlParaType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.MySqlType) == true)
{
string strComparisonOpMySqlType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.MySqlType, objDataTypeAbbrCond.MySqlType, strComparisonOpMySqlType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DefaFldLength) == true)
{
string strComparisonOpDefaFldLength = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DefaFldLength];
strWhereCond += string.Format(" And {0} {2} {1}", conDataTypeAbbr.DefaFldLength, objDataTypeAbbrCond.DefaFldLength, strComparisonOpDefaFldLength);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DefaFldPrecision) == true)
{
string strComparisonOpDefaFldPrecision = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DefaFldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", conDataTypeAbbr.DefaFldPrecision, objDataTypeAbbrCond.DefaFldPrecision, strComparisonOpDefaFldPrecision);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.Memo) == true)
{
string strComparisonOpMemo = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.Memo, objDataTypeAbbrCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 if (string.IsNullOrEmpty(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDataTypeAbbrEN.sfUpdFldSetStr = objDataTypeAbbrEN.getsfUpdFldSetStr();
clsDataTypeAbbrWApi.CheckPropertyNew(objDataTypeAbbrEN); 
bool bolResult = clsDataTypeAbbrWApi.UpdateRecord(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 if (string.IsNullOrEmpty(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataTypeAbbrWApi.IsExist(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataTypeAbbrEN.DataTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsDataTypeAbbrWApi.CheckPropertyNew(objDataTypeAbbrEN); 
bool bolResult = clsDataTypeAbbrWApi.AddNewRecord(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDataTypeAbbrEN objDataTypeAbbrEN)
{
try
{
clsDataTypeAbbrWApi.CheckPropertyNew(objDataTypeAbbrEN); 
string strDataTypeId = clsDataTypeAbbrWApi.AddNewRecordWithMaxId(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrWApi.ReFreshCache();
return strDataTypeId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strWhereCond)
{
try
{
clsDataTypeAbbrWApi.CheckPropertyNew(objDataTypeAbbrEN); 
bool bolResult = clsDataTypeAbbrWApi.UpdateWithCondition(objDataTypeAbbrEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumDataTypeAbbrWA
{
 /// <summary>
 /// bigint
 /// </summary>
public const string bigint_01 = "01";
 /// <summary>
 /// binary
 /// </summary>
public const string binary_02 = "02";
 /// <summary>
 /// bit
 /// </summary>
public const string bit_03 = "03";
 /// <summary>
 /// char
 /// </summary>
public const string char_04 = "04";
 /// <summary>
 /// datetime
 /// </summary>
public const string datetime_05 = "05";
 /// <summary>
 /// decimal
 /// </summary>
public const string decimal_06 = "06";
 /// <summary>
 /// float
 /// </summary>
public const string float_07 = "07";
 /// <summary>
 /// image
 /// </summary>
public const string image_08 = "08";
 /// <summary>
 /// int
 /// </summary>
public const string int_09 = "09";
 /// <summary>
 /// int identity
 /// </summary>
public const string intidentity_10 = "10";
 /// <summary>
 /// money
 /// </summary>
public const string money_11 = "11";
 /// <summary>
 /// nchar
 /// </summary>
public const string nchar_12 = "12";
 /// <summary>
 /// ntext
 /// </summary>
public const string ntext_13 = "13";
 /// <summary>
 /// numeric
 /// </summary>
public const string numeric_14 = "14";
 /// <summary>
 /// nvarchar
 /// </summary>
public const string nvarchar_15 = "15";
 /// <summary>
 /// real
 /// </summary>
public const string real_16 = "16";
 /// <summary>
 /// smalldatetime
 /// </summary>
public const string smalldatetime_17 = "17";
 /// <summary>
 /// smallint
 /// </summary>
public const string smallint_18 = "18";
 /// <summary>
 /// smallmoney
 /// </summary>
public const string smallmoney_19 = "19";
 /// <summary>
 /// text
 /// </summary>
public const string text_20 = "20";
 /// <summary>
 /// timestamp
 /// </summary>
public const string timestamp_21 = "21";
 /// <summary>
 /// tinyint
 /// </summary>
public const string tinyint_22 = "22";
 /// <summary>
 /// uniqueidentifier
 /// </summary>
public const string uniqueidentifier_23 = "23";
 /// <summary>
 /// varbinary
 /// </summary>
public const string varbinary_24 = "24";
 /// <summary>
 /// varchar
 /// </summary>
public const string varchar_25 = "25";
 /// <summary>
 /// bigint identity
 /// </summary>
public const string bigintidentity_26 = "26";
 /// <summary>
 /// void
 /// </summary>
public const string void_27 = "27";
 /// <summary>
 /// System.Data.DataSet
 /// </summary>
public const string System_Data_DataSet_28 = "28";
 /// <summary>
 /// Object
 /// </summary>
public const string Object_29 = "29";
 /// <summary>
 /// ObjectLst
 /// </summary>
public const string ObjectLst_30 = "30";
 /// <summary>
 /// Array
 /// </summary>
public const string Array_31 = "31";
 /// <summary>
 /// T
 /// </summary>
public const string T_32 = "32";
 /// <summary>
 /// Var4Key
 /// </summary>
public const string Var4Key_33 = "33";
 /// <summary>
 /// Var4Field
 /// </summary>
public const string Var4Field_34 = "34";
}
 /// <summary>
 /// 数据类型(DataTypeAbbr)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDataTypeAbbrWApi
{
private static readonly string mstrApiControllerName = "DataTypeAbbrApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsDataTypeAbbrWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DataTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据类型]...","0");
List<clsDataTypeAbbrEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DataTypeId";
objDDL.DataTextField="DataTypeName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DataTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDataTypeAbbr.DataTypeId); 
List<clsDataTypeAbbrEN> arrObjLst = clsDataTypeAbbrWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN()
{
DataTypeId = "0",
DataTypeName = "选[数据类型]..."
};
arrObjLst.Insert(0, objDataTypeAbbrEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDataTypeAbbr.DataTypeId;
objComboBox.DisplayMember = conDataTypeAbbr.DataTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
if (!Object.Equals(null, objDataTypeAbbrEN.DataTypeId) && GetStrLen(objDataTypeAbbrEN.DataTypeId) > 2)
{
 throw new Exception("字段[数据类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.DataTypeName) && GetStrLen(objDataTypeAbbrEN.DataTypeName) > 100)
{
 throw new Exception("字段[数据类型名称]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.DataTypeENName) && GetStrLen(objDataTypeAbbrEN.DataTypeENName) > 100)
{
 throw new Exception("字段[DataTypeENName]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.DataCnName) && GetStrLen(objDataTypeAbbrEN.DataCnName) > 100)
{
 throw new Exception("字段[数据类型中文名称]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.DataTypeAbbr) && GetStrLen(objDataTypeAbbrEN.DataTypeAbbr) > 5)
{
 throw new Exception("字段[数据类型缩写]的长度不能超过5!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.NetSysType) && GetStrLen(objDataTypeAbbrEN.NetSysType) > 20)
{
 throw new Exception("字段[NET系统类型]的长度不能超过20!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.VbNetType) && GetStrLen(objDataTypeAbbrEN.VbNetType) > 100)
{
 throw new Exception("字段[VBNET类型]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.CsType) && GetStrLen(objDataTypeAbbrEN.CsType) > 100)
{
 throw new Exception("字段[CS类型]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.JavaType) && GetStrLen(objDataTypeAbbrEN.JavaType) > 100)
{
 throw new Exception("字段[JAVA类型]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.TypeScriptType) && GetStrLen(objDataTypeAbbrEN.TypeScriptType) > 100)
{
 throw new Exception("字段[TypeScript类型]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.JavaObjType) && GetStrLen(objDataTypeAbbrEN.JavaObjType) > 100)
{
 throw new Exception("字段[JAVA对象类型]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.SwiftType) && GetStrLen(objDataTypeAbbrEN.SwiftType) > 100)
{
 throw new Exception("字段[SwiftType]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.OraDbType) && GetStrLen(objDataTypeAbbrEN.OraDbType) > 100)
{
 throw new Exception("字段[Ora数据类型]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.SqlParaType) && GetStrLen(objDataTypeAbbrEN.SqlParaType) > 100)
{
 throw new Exception("字段[SQL参数类型]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.MySqlType) && GetStrLen(objDataTypeAbbrEN.MySqlType) > 100)
{
 throw new Exception("字段[MySqlType]的长度不能超过100!");
}
if (!Object.Equals(null, objDataTypeAbbrEN.Memo) && GetStrLen(objDataTypeAbbrEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDataTypeAbbrEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDataTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataTypeAbbrEN GetObjByDataTypeId(string strDataTypeId)
{
if (strDataTypeId == "") return null;
string strAction = "GetObjByDataTypeId";
clsDataTypeAbbrEN objDataTypeAbbrEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDataTypeId"] = strDataTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objDataTypeAbbrEN = JsonConvert.DeserializeObject<clsDataTypeAbbrEN>(strJson);
return objDataTypeAbbrEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsDataTypeAbbrEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDataTypeAbbrEN objDataTypeAbbrEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objDataTypeAbbrEN = JsonConvert.DeserializeObject<clsDataTypeAbbrEN>(strJson);
return objDataTypeAbbrEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataTypeAbbrEN GetObjByDataTypeIdCache(string strDataTypeId)
{
if (string.IsNullOrEmpty(strDataTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsDataTypeAbbrEN._CurrTabName);
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLstCache = GetObjLstCache();
IEnumerable <clsDataTypeAbbrEN> arrDataTypeAbbrObjLst_Sel =
from objDataTypeAbbrEN in arrDataTypeAbbrObjLstCache
where objDataTypeAbbrEN.DataTypeId == strDataTypeId 
select objDataTypeAbbrEN;
if (arrDataTypeAbbrObjLst_Sel.Count() == 0)
{
   clsDataTypeAbbrEN obj = clsDataTypeAbbrWApi.GetObjByDataTypeId(strDataTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDataTypeAbbrObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataTypeNameByDataTypeIdCache(string strDataTypeId)
{
if (string.IsNullOrEmpty(strDataTypeId) == true) return "";
//初始化列表缓存
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLstCache = GetObjLstCache();
IEnumerable <clsDataTypeAbbrEN> arrDataTypeAbbrObjLst_Sel1 =
from objDataTypeAbbrEN in arrDataTypeAbbrObjLstCache
where objDataTypeAbbrEN.DataTypeId == strDataTypeId 
select objDataTypeAbbrEN;
List <clsDataTypeAbbrEN> arrDataTypeAbbrObjLst_Sel = new List<clsDataTypeAbbrEN>();
foreach (clsDataTypeAbbrEN obj in arrDataTypeAbbrObjLst_Sel1)
{
arrDataTypeAbbrObjLst_Sel.Add(obj);
}
if (arrDataTypeAbbrObjLst_Sel.Count > 0)
{
return arrDataTypeAbbrObjLst_Sel[0].DataTypeName;
}
string strErrMsgForGetObjById = string.Format("在DataTypeAbbr对象缓存列表中,找不到记录[DataTypeId = {0}](函数:{1})", strDataTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDataTypeAbbrBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataTypeIdCache(string strDataTypeId)
{
if (string.IsNullOrEmpty(strDataTypeId) == true) return "";
//初始化列表缓存
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLstCache = GetObjLstCache();
IEnumerable <clsDataTypeAbbrEN> arrDataTypeAbbrObjLst_Sel1 =
from objDataTypeAbbrEN in arrDataTypeAbbrObjLstCache
where objDataTypeAbbrEN.DataTypeId == strDataTypeId 
select objDataTypeAbbrEN;
List <clsDataTypeAbbrEN> arrDataTypeAbbrObjLst_Sel = new List<clsDataTypeAbbrEN>();
foreach (clsDataTypeAbbrEN obj in arrDataTypeAbbrObjLst_Sel1)
{
arrDataTypeAbbrObjLst_Sel.Add(obj);
}
if (arrDataTypeAbbrObjLst_Sel.Count > 0)
{
return arrDataTypeAbbrObjLst_Sel[0].DataTypeName;
}
string strErrMsgForGetObjById = string.Format("在DataTypeAbbr对象缓存列表中,找不到记录的相关名称[DataTypeId = {0}](函数:{1})", strDataTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDataTypeAbbrBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLst(string strWhereCond)
{
 List<clsDataTypeAbbrEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataTypeAbbrEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrDataTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLstByDataTypeIdLst(List<string> arrDataTypeId)
{
 List<clsDataTypeAbbrEN> arrObjLst; 
string strAction = "GetObjLstByDataTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDataTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataTypeAbbrEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDataTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsDataTypeAbbrEN> GetObjLstByDataTypeIdLstCache(List<string> arrDataTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDataTypeAbbrEN._CurrTabName);
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLstCache = GetObjLstCache();
IEnumerable <clsDataTypeAbbrEN> arrDataTypeAbbrObjLst_Sel =
from objDataTypeAbbrEN in arrDataTypeAbbrObjLstCache
where arrDataTypeId.Contains(objDataTypeAbbrEN.DataTypeId)
select objDataTypeAbbrEN;
return arrDataTypeAbbrObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataTypeAbbrEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDataTypeAbbrEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataTypeAbbrEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDataTypeAbbrEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataTypeAbbrEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDataTypeAbbrEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataTypeAbbrEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDataTypeAbbrEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataTypeAbbrEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strDataTypeId)
{
string strAction = "DelRecord";
try
{
 clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrWApi.GetObjByDataTypeId(strDataTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strDataTypeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDataTypeAbbrWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelDataTypeAbbrs(List<string> arrDataTypeId)
{
string strAction = "DelDataTypeAbbrs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDataTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDataTypeAbbrWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelDataTypeAbbrsByCond(string strWhereCond)
{
string strAction = "DelDataTypeAbbrsByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataTypeAbbrEN>(objDataTypeAbbrEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataTypeAbbrEN>(objDataTypeAbbrEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrWApi.ReFreshCache();
var strDataTypeId = (string)jobjReturn0["returnStr"];
return strDataTypeId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
if (string.IsNullOrEmpty(objDataTypeAbbrEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataTypeAbbrEN.DataTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataTypeAbbrEN>(objDataTypeAbbrEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDataTypeAbbrEN objDataTypeAbbrEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDataTypeAbbrEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataTypeAbbrEN.DataTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataTypeAbbrEN.DataTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataTypeAbbrEN>(objDataTypeAbbrEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strDataTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDataTypeId"] = strDataTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objDataTypeAbbrENS">源对象</param>
 /// <param name = "objDataTypeAbbrENT">目标对象</param>
 public static void CopyTo(clsDataTypeAbbrEN objDataTypeAbbrENS, clsDataTypeAbbrEN objDataTypeAbbrENT)
{
try
{
objDataTypeAbbrENT.DataTypeId = objDataTypeAbbrENS.DataTypeId; //数据类型Id
objDataTypeAbbrENT.DataTypeName = objDataTypeAbbrENS.DataTypeName; //数据类型名称
objDataTypeAbbrENT.DataTypeENName = objDataTypeAbbrENS.DataTypeENName; //DataTypeENName
objDataTypeAbbrENT.DataCnName = objDataTypeAbbrENS.DataCnName; //数据类型中文名称
objDataTypeAbbrENT.DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr; //数据类型缩写
objDataTypeAbbrENT.NetSysType = objDataTypeAbbrENS.NetSysType; //NET系统类型
objDataTypeAbbrENT.VbNetType = objDataTypeAbbrENS.VbNetType; //VBNET类型
objDataTypeAbbrENT.CsType = objDataTypeAbbrENS.CsType; //CS类型
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
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsDataTypeAbbrEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDataTypeAbbrEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDataTypeAbbrEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDataTypeAbbrEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDataTypeAbbrEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDataTypeAbbrEN._AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsDataTypeAbbrEN._CurrTabName);
CacheHelper.Remove(strKey);
}
else
{
strMsg0 = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg0);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsDataTypeAbbrWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDataTypeAbbrEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataTypeAbbrWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsDataTypeAbbrEN._CurrTabName;
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDataTypeAbbrObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDataTypeAbbrEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDataTypeAbbr.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.DataTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.DataCnName, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.DataTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.NetSysType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.VbNetType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.CsType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.JavaType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.TypeScriptType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.JavaObjType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.SwiftType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.IsNeedQuote, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataTypeAbbr.OraDbType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.IsReturnType, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataTypeAbbr.SqlParaType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.MySqlType, Type.GetType("System.String"));
objDT.Columns.Add(conDataTypeAbbr.DefaFldLength, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataTypeAbbr.DefaFldPrecision, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataTypeAbbr.Memo, Type.GetType("System.String"));
foreach (clsDataTypeAbbrEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDataTypeAbbr.DataTypeId] = objInFor[conDataTypeAbbr.DataTypeId];
objDR[conDataTypeAbbr.DataTypeName] = objInFor[conDataTypeAbbr.DataTypeName];
objDR[conDataTypeAbbr.DataTypeENName] = objInFor[conDataTypeAbbr.DataTypeENName];
objDR[conDataTypeAbbr.DataCnName] = objInFor[conDataTypeAbbr.DataCnName];
objDR[conDataTypeAbbr.DataTypeAbbr] = objInFor[conDataTypeAbbr.DataTypeAbbr];
objDR[conDataTypeAbbr.NetSysType] = objInFor[conDataTypeAbbr.NetSysType];
objDR[conDataTypeAbbr.VbNetType] = objInFor[conDataTypeAbbr.VbNetType];
objDR[conDataTypeAbbr.CsType] = objInFor[conDataTypeAbbr.CsType];
objDR[conDataTypeAbbr.JavaType] = objInFor[conDataTypeAbbr.JavaType];
objDR[conDataTypeAbbr.TypeScriptType] = objInFor[conDataTypeAbbr.TypeScriptType];
objDR[conDataTypeAbbr.JavaObjType] = objInFor[conDataTypeAbbr.JavaObjType];
objDR[conDataTypeAbbr.SwiftType] = objInFor[conDataTypeAbbr.SwiftType];
objDR[conDataTypeAbbr.IsNeedQuote] = objInFor[conDataTypeAbbr.IsNeedQuote];
objDR[conDataTypeAbbr.OraDbType] = objInFor[conDataTypeAbbr.OraDbType];
objDR[conDataTypeAbbr.IsReturnType] = objInFor[conDataTypeAbbr.IsReturnType];
objDR[conDataTypeAbbr.SqlParaType] = objInFor[conDataTypeAbbr.SqlParaType];
objDR[conDataTypeAbbr.MySqlType] = objInFor[conDataTypeAbbr.MySqlType];
objDR[conDataTypeAbbr.DefaFldLength] = objInFor[conDataTypeAbbr.DefaFldLength];
objDR[conDataTypeAbbr.DefaFldPrecision] = objInFor[conDataTypeAbbr.DefaFldPrecision];
objDR[conDataTypeAbbr.Memo] = objInFor[conDataTypeAbbr.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 数据类型(DataTypeAbbr)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DataTypeAbbr : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrWApi.ReFreshThisCache();
}
}

}