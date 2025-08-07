
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncPara4CodeWApi
 表名:vFuncPara4Code(00050385)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFuncPara4CodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncParaId4Code">函数参数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetFuncParaId4Code(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strFuncParaId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncParaId4Code, 8, convFuncPara4Code.FuncParaId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncParaId4Code, 8, convFuncPara4Code.FuncParaId4Code);
objvFuncPara4CodeEN.FuncParaId4Code = strFuncParaId4Code; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.FuncParaId4Code) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.FuncParaId4Code, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.FuncParaId4Code] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaName">参数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetParaName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, convFuncPara4Code.ParaName);
clsCheckSql.CheckFieldLen(strParaName, 50, convFuncPara4Code.ParaName);
objvFuncPara4CodeEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.ParaName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.ParaName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.ParaName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaCnName">参数中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetParaCnName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, convFuncPara4Code.ParaCnName);
clsCheckSql.CheckFieldLen(strParaCnName, 50, convFuncPara4Code.ParaCnName);
objvFuncPara4CodeEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.ParaCnName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.ParaCnName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.ParaCnName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetDataTypeId(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convFuncPara4Code.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFuncPara4Code.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFuncPara4Code.DataTypeId);
objvFuncPara4CodeEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.DataTypeId) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.DataTypeId, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.DataTypeId] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetDataTypeName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFuncPara4Code.DataTypeName);
objvFuncPara4CodeEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.DataTypeName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.DataTypeName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.DataTypeName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataCnName">数据类型中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetDataCnName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataCnName, convFuncPara4Code.DataCnName);
clsCheckSql.CheckFieldLen(strDataCnName, 100, convFuncPara4Code.DataCnName);
objvFuncPara4CodeEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.DataCnName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.DataCnName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.DataCnName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCsType">CS类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetCsType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, convFuncPara4Code.CsType);
clsCheckSql.CheckFieldLen(strCsType, 100, convFuncPara4Code.CsType);
objvFuncPara4CodeEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.CsType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.CsType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.CsType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaType">JAVA类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetJavaType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJavaType, convFuncPara4Code.JavaType);
clsCheckSql.CheckFieldLen(strJavaType, 100, convFuncPara4Code.JavaType);
objvFuncPara4CodeEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.JavaType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.JavaType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.JavaType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaObjType">JAVA对象类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetJavaObjType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strJavaObjType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convFuncPara4Code.JavaObjType);
objvFuncPara4CodeEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.JavaObjType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.JavaObjType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.JavaObjType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSwiftType">SwiftType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetSwiftType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strSwiftType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convFuncPara4Code.SwiftType);
objvFuncPara4CodeEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.SwiftType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.SwiftType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.SwiftType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedQuote">是否需要引号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetIsNeedQuote(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedQuote, convFuncPara4Code.IsNeedQuote);
objvFuncPara4CodeEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.IsNeedQuote) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.IsNeedQuote, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.IsNeedQuote] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strOraDbType">Ora数据类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetOraDbType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOraDbType, convFuncPara4Code.OraDbType);
clsCheckSql.CheckFieldLen(strOraDbType, 100, convFuncPara4Code.OraDbType);
objvFuncPara4CodeEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.OraDbType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.OraDbType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.OraDbType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMySqlType">MySqlType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetMySqlType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strMySqlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMySqlType, 100, convFuncPara4Code.MySqlType);
objvFuncPara4CodeEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.MySqlType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.MySqlType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.MySqlType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterType">参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetParameterType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterType, 100, convFuncPara4Code.ParameterType);
objvFuncPara4CodeEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.ParameterType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.ParameterType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.ParameterType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterTypeFullName">参数类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetParameterTypeFullName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strParameterTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convFuncPara4Code.ParameterTypeFullName);
objvFuncPara4CodeEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.ParameterTypeFullName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.ParameterTypeFullName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.ParameterTypeFullName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsByRef">是否引用型参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetIsByRef(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, bool bolIsByRef, string strComparisonOp="")
	{
objvFuncPara4CodeEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.IsByRef) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.IsByRef, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.IsByRef] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetPrjId(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFuncPara4Code.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFuncPara4Code.PrjId);
objvFuncPara4CodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.PrjId) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.PrjId, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.PrjId] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncPurposeId">函数用途Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetFuncPurposeId(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strFuncPurposeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncPurposeId, convFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(strFuncPurposeId, 2, convFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckFieldForeignKey(strFuncPurposeId, 2, convFuncPara4Code.FuncPurposeId);
objvFuncPara4CodeEN.FuncPurposeId = strFuncPurposeId; //函数用途Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.FuncPurposeId) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.FuncPurposeId, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.FuncPurposeId] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetUpdDate(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncPara4Code.UpdDate);
objvFuncPara4CodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.UpdDate) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.UpdDate, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.UpdDate] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetUpdUser(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFuncPara4Code.UpdUser);
objvFuncPara4CodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.UpdUser) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.UpdUser, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.UpdUser] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetMemo(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncPara4Code.Memo);
objvFuncPara4CodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.Memo) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.Memo, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.Memo] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intFuncCount">函数数目</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetFuncCount(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, int intFuncCount, string strComparisonOp="")
	{
objvFuncPara4CodeEN.FuncCount = intFuncCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.FuncCount) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.FuncCount, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.FuncCount] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncPara4CodeEN objvFuncPara4CodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.FuncParaId4Code) == true)
{
string strComparisonOpFuncParaId4Code = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.FuncParaId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.FuncParaId4Code, objvFuncPara4CodeCond.FuncParaId4Code, strComparisonOpFuncParaId4Code);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.ParaName) == true)
{
string strComparisonOpParaName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.ParaName, objvFuncPara4CodeCond.ParaName, strComparisonOpParaName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.ParaCnName) == true)
{
string strComparisonOpParaCnName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.ParaCnName, objvFuncPara4CodeCond.ParaCnName, strComparisonOpParaCnName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.DataTypeId, objvFuncPara4CodeCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.DataTypeName, objvFuncPara4CodeCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.DataCnName) == true)
{
string strComparisonOpDataCnName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.DataCnName, objvFuncPara4CodeCond.DataCnName, strComparisonOpDataCnName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.CsType) == true)
{
string strComparisonOpCsType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.CsType, objvFuncPara4CodeCond.CsType, strComparisonOpCsType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.JavaType) == true)
{
string strComparisonOpJavaType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.JavaType, objvFuncPara4CodeCond.JavaType, strComparisonOpJavaType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.JavaObjType, objvFuncPara4CodeCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.SwiftType) == true)
{
string strComparisonOpSwiftType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.SwiftType, objvFuncPara4CodeCond.SwiftType, strComparisonOpSwiftType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.IsNeedQuote) == true)
{
if (objvFuncPara4CodeCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncPara4Code.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncPara4Code.IsNeedQuote);
}
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.OraDbType) == true)
{
string strComparisonOpOraDbType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.OraDbType, objvFuncPara4CodeCond.OraDbType, strComparisonOpOraDbType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.MySqlType) == true)
{
string strComparisonOpMySqlType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.MySqlType, objvFuncPara4CodeCond.MySqlType, strComparisonOpMySqlType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.ParameterType) == true)
{
string strComparisonOpParameterType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.ParameterType, objvFuncPara4CodeCond.ParameterType, strComparisonOpParameterType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.ParameterTypeFullName, objvFuncPara4CodeCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.IsByRef) == true)
{
if (objvFuncPara4CodeCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncPara4Code.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncPara4Code.IsByRef);
}
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.PrjId) == true)
{
string strComparisonOpPrjId = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.PrjId, objvFuncPara4CodeCond.PrjId, strComparisonOpPrjId);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.FuncPurposeId) == true)
{
string strComparisonOpFuncPurposeId = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.FuncPurposeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.FuncPurposeId, objvFuncPara4CodeCond.FuncPurposeId, strComparisonOpFuncPurposeId);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.UpdDate, objvFuncPara4CodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.UpdUser, objvFuncPara4CodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.Memo) == true)
{
string strComparisonOpMemo = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.Memo, objvFuncPara4CodeCond.Memo, strComparisonOpMemo);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.FuncCount) == true)
{
string strComparisonOpFuncCount = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.FuncCount];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncPara4Code.FuncCount, objvFuncPara4CodeCond.FuncCount, strComparisonOpFuncCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数参数4Code(vFuncPara4Code)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFuncPara4CodeWApi
{
private static readonly string mstrApiControllerName = "vFuncPara4CodeApi";

 public clsvFuncPara4CodeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncParaId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncPara4CodeEN GetObjByFuncParaId4Code(string strFuncParaId4Code)
{
if (strFuncParaId4Code == "") return null;
string strAction = "GetObjByFuncParaId4Code";
clsvFuncPara4CodeEN objvFuncPara4CodeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncParaId4Code"] = strFuncParaId4Code,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFuncPara4CodeEN = JsonConvert.DeserializeObject<clsvFuncPara4CodeEN>(strJson);
return objvFuncPara4CodeEN;
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
public static clsvFuncPara4CodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFuncPara4CodeEN objvFuncPara4CodeEN;
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
objvFuncPara4CodeEN = JsonConvert.DeserializeObject<clsvFuncPara4CodeEN>(strJson);
return objvFuncPara4CodeEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetObjLst(string strWhereCond)
{
 List<clsvFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncPara4CodeEN>>(strJson);
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
 /// <param name = "arrFuncParaId4Code">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetObjLstByFuncParaId4CodeLst(List<string> arrFuncParaId4Code)
{
 List<clsvFuncPara4CodeEN> arrObjLst; 
string strAction = "GetObjLstByFuncParaId4CodeLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncParaId4Code);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncPara4CodeEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncPara4CodeEN>>(strJson);
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
public static List<clsvFuncPara4CodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncPara4CodeEN>>(strJson);
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
public static List<clsvFuncPara4CodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncPara4CodeEN>>(strJson);
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
public static List<clsvFuncPara4CodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncPara4CodeEN>>(strJson);
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
public static bool IsExist(string strFuncParaId4Code)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncParaId4Code"] = strFuncParaId4Code
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvFuncPara4CodeENS">源对象</param>
 /// <param name = "objvFuncPara4CodeENT">目标对象</param>
 public static void CopyTo(clsvFuncPara4CodeEN objvFuncPara4CodeENS, clsvFuncPara4CodeEN objvFuncPara4CodeENT)
{
try
{
objvFuncPara4CodeENT.FuncParaId4Code = objvFuncPara4CodeENS.FuncParaId4Code; //函数参数Id
objvFuncPara4CodeENT.ParaName = objvFuncPara4CodeENS.ParaName; //参数名
objvFuncPara4CodeENT.ParaCnName = objvFuncPara4CodeENS.ParaCnName; //参数中文名
objvFuncPara4CodeENT.DataTypeId = objvFuncPara4CodeENS.DataTypeId; //数据类型Id
objvFuncPara4CodeENT.DataTypeName = objvFuncPara4CodeENS.DataTypeName; //数据类型名称
objvFuncPara4CodeENT.DataCnName = objvFuncPara4CodeENS.DataCnName; //数据类型中文名称
objvFuncPara4CodeENT.CsType = objvFuncPara4CodeENS.CsType; //CS类型
objvFuncPara4CodeENT.JavaType = objvFuncPara4CodeENS.JavaType; //JAVA类型
objvFuncPara4CodeENT.JavaObjType = objvFuncPara4CodeENS.JavaObjType; //JAVA对象类型
objvFuncPara4CodeENT.SwiftType = objvFuncPara4CodeENS.SwiftType; //SwiftType
objvFuncPara4CodeENT.IsNeedQuote = objvFuncPara4CodeENS.IsNeedQuote; //是否需要引号
objvFuncPara4CodeENT.OraDbType = objvFuncPara4CodeENS.OraDbType; //Ora数据类型
objvFuncPara4CodeENT.MySqlType = objvFuncPara4CodeENS.MySqlType; //MySqlType
objvFuncPara4CodeENT.ParameterType = objvFuncPara4CodeENS.ParameterType; //参数类型
objvFuncPara4CodeENT.ParameterTypeFullName = objvFuncPara4CodeENS.ParameterTypeFullName; //参数类型全名
objvFuncPara4CodeENT.IsByRef = objvFuncPara4CodeENS.IsByRef; //是否引用型参数
objvFuncPara4CodeENT.PrjId = objvFuncPara4CodeENS.PrjId; //工程Id
objvFuncPara4CodeENT.FuncPurposeId = objvFuncPara4CodeENS.FuncPurposeId; //函数用途Id
objvFuncPara4CodeENT.UpdDate = objvFuncPara4CodeENS.UpdDate; //修改日期
objvFuncPara4CodeENT.UpdUser = objvFuncPara4CodeENS.UpdUser; //修改者
objvFuncPara4CodeENT.Memo = objvFuncPara4CodeENS.Memo; //说明
objvFuncPara4CodeENT.FuncCount = objvFuncPara4CodeENS.FuncCount; //函数数目
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
public static DataTable ToDataTable(List<clsvFuncPara4CodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFuncPara4CodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFuncPara4CodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFuncPara4CodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFuncPara4CodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFuncPara4CodeEN._AttributeName)
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
public static void ReFreshThisCache(string strFuncPurposeId = "")
{


if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
  var strMsg = string.Format("参数:[strFuncPurposeId]不能为空！(In clsvFuncPara4CodeWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strFuncPurposeId.Length != 2)
{
var strMsg = string.Format("缓存分类变量:[strFuncPurposeId]的长度:[{0}]不正确！(clsvFuncPara4CodeWApi.ReFreshThisCache)", strFuncPurposeId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFuncPara4CodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFuncPara4Code.FuncParaId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.ParaName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.ParaCnName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.DataCnName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.CsType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.JavaType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.JavaObjType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.SwiftType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.IsNeedQuote, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFuncPara4Code.OraDbType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.MySqlType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.ParameterType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.ParameterTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.IsByRef, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFuncPara4Code.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.FuncPurposeId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFuncPara4Code.FuncCount, Type.GetType("System.Int32"));
foreach (clsvFuncPara4CodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFuncPara4Code.FuncParaId4Code] = objInFor[convFuncPara4Code.FuncParaId4Code];
objDR[convFuncPara4Code.ParaName] = objInFor[convFuncPara4Code.ParaName];
objDR[convFuncPara4Code.ParaCnName] = objInFor[convFuncPara4Code.ParaCnName];
objDR[convFuncPara4Code.DataTypeId] = objInFor[convFuncPara4Code.DataTypeId];
objDR[convFuncPara4Code.DataTypeName] = objInFor[convFuncPara4Code.DataTypeName];
objDR[convFuncPara4Code.DataCnName] = objInFor[convFuncPara4Code.DataCnName];
objDR[convFuncPara4Code.CsType] = objInFor[convFuncPara4Code.CsType];
objDR[convFuncPara4Code.JavaType] = objInFor[convFuncPara4Code.JavaType];
objDR[convFuncPara4Code.JavaObjType] = objInFor[convFuncPara4Code.JavaObjType];
objDR[convFuncPara4Code.SwiftType] = objInFor[convFuncPara4Code.SwiftType];
objDR[convFuncPara4Code.IsNeedQuote] = objInFor[convFuncPara4Code.IsNeedQuote];
objDR[convFuncPara4Code.OraDbType] = objInFor[convFuncPara4Code.OraDbType];
objDR[convFuncPara4Code.MySqlType] = objInFor[convFuncPara4Code.MySqlType];
objDR[convFuncPara4Code.ParameterType] = objInFor[convFuncPara4Code.ParameterType];
objDR[convFuncPara4Code.ParameterTypeFullName] = objInFor[convFuncPara4Code.ParameterTypeFullName];
objDR[convFuncPara4Code.IsByRef] = objInFor[convFuncPara4Code.IsByRef];
objDR[convFuncPara4Code.PrjId] = objInFor[convFuncPara4Code.PrjId];
objDR[convFuncPara4Code.FuncPurposeId] = objInFor[convFuncPara4Code.FuncPurposeId];
objDR[convFuncPara4Code.UpdDate] = objInFor[convFuncPara4Code.UpdDate];
objDR[convFuncPara4Code.UpdUser] = objInFor[convFuncPara4Code.UpdUser];
objDR[convFuncPara4Code.Memo] = objInFor[convFuncPara4Code.Memo];
objDR[convFuncPara4Code.FuncCount] = objInFor[convFuncPara4Code.FuncCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}