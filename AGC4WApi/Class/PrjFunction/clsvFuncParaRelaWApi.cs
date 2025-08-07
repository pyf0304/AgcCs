
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncParaRelaWApi
 表名:vFuncParaRela(00050499)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:33
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
public static class  clsvFuncParaRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetmId(this clsvFuncParaRelaEN objvFuncParaRelaEN, long lngmId, string strComparisonOp="")
	{
objvFuncParaRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.mId) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.mId, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.mId] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncParaId4Code">函数参数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetFuncParaId4Code(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strFuncParaId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncParaId4Code, convFuncParaRela.FuncParaId4Code);
clsCheckSql.CheckFieldLen(strFuncParaId4Code, 8, convFuncParaRela.FuncParaId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncParaId4Code, 8, convFuncParaRela.FuncParaId4Code);
objvFuncParaRelaEN.FuncParaId4Code = strFuncParaId4Code; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.FuncParaId4Code) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.FuncParaId4Code, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.FuncParaId4Code] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaName">参数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetParaName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParaName, 50, convFuncParaRela.ParaName);
objvFuncParaRelaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.ParaName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.ParaName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.ParaName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaCnName">参数中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetParaCnName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParaCnName, 50, convFuncParaRela.ParaCnName);
objvFuncParaRelaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.ParaCnName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.ParaCnName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.ParaCnName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetDataTypeId(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFuncParaRela.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFuncParaRela.DataTypeId);
objvFuncParaRelaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.DataTypeId) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.DataTypeId, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.DataTypeId] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetDataTypeName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFuncParaRela.DataTypeName);
objvFuncParaRelaEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.DataTypeName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.DataTypeName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.DataTypeName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataCnName">数据类型中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetDataCnName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataCnName, 100, convFuncParaRela.DataCnName);
objvFuncParaRelaEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.DataCnName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.DataCnName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.DataCnName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCsType">CS类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetCsType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCsType, 100, convFuncParaRela.CsType);
objvFuncParaRelaEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.CsType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.CsType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.CsType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaType">JAVA类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetJavaType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaType, 100, convFuncParaRela.JavaType);
objvFuncParaRelaEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.JavaType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.JavaType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.JavaType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaObjType">JAVA对象类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetJavaObjType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strJavaObjType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convFuncParaRela.JavaObjType);
objvFuncParaRelaEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.JavaObjType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.JavaObjType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.JavaObjType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strSwiftType">SwiftType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetSwiftType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strSwiftType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convFuncParaRela.SwiftType);
objvFuncParaRelaEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.SwiftType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.SwiftType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.SwiftType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedQuote">是否需要引号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetIsNeedQuote(this clsvFuncParaRelaEN objvFuncParaRelaEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
objvFuncParaRelaEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.IsNeedQuote) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.IsNeedQuote, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.IsNeedQuote] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strOraDbType">Ora数据类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetOraDbType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOraDbType, 100, convFuncParaRela.OraDbType);
objvFuncParaRelaEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.OraDbType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.OraDbType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.OraDbType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMySqlType">MySqlType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetMySqlType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strMySqlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMySqlType, 100, convFuncParaRela.MySqlType);
objvFuncParaRelaEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.MySqlType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.MySqlType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.MySqlType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterType">参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetParameterType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterType, 100, convFuncParaRela.ParameterType);
objvFuncParaRelaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.ParameterType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.ParameterType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.ParameterType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterTypeFullName">参数类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetParameterTypeFullName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convFuncParaRela.ParameterTypeFullName);
objvFuncParaRelaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.ParameterTypeFullName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.ParameterTypeFullName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.ParameterTypeFullName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsByRef">是否引用型参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetIsByRef(this clsvFuncParaRelaEN objvFuncParaRelaEN, bool bolIsByRef, string strComparisonOp="")
	{
objvFuncParaRelaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.IsByRef) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.IsByRef, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.IsByRef] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetPrjId(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFuncParaRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFuncParaRela.PrjId);
objvFuncParaRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.PrjId) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.PrjId, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.PrjId] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetFuncId4Code(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4Code, convFuncParaRela.FuncId4Code);
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFuncParaRela.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFuncParaRela.FuncId4Code);
objvFuncParaRelaEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.FuncId4Code) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.FuncId4Code, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.FuncId4Code] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4Code">函数名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetFuncName4Code(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, convFuncParaRela.FuncName4Code);
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFuncParaRela.FuncName4Code);
objvFuncParaRelaEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.FuncName4Code) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.FuncName4Code, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.FuncName4Code] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetFunctionSignature(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFuncParaRela.FunctionSignature);
objvFuncParaRelaEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.FunctionSignature) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.FunctionSignature, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.FunctionSignature] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAsyncFunc">是否异步函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetIsAsyncFunc(this clsvFuncParaRelaEN objvFuncParaRelaEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objvFuncParaRelaEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.IsAsyncFunc) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.IsAsyncFunc, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.IsAsyncFunc] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSysFunction">是否系统函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetIsSysFunction(this clsvFuncParaRelaEN objvFuncParaRelaEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objvFuncParaRelaEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.IsSysFunction) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.IsSysFunction, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.IsSysFunction] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetOrderNum(this clsvFuncParaRelaEN objvFuncParaRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFuncParaRela.OrderNum);
objvFuncParaRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.OrderNum) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.OrderNum, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.OrderNum] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetUpdDate(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncParaRela.UpdDate);
objvFuncParaRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.UpdDate) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.UpdDate, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.UpdDate] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetUpdUser(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFuncParaRela.UpdUser);
objvFuncParaRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.UpdUser) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.UpdUser, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.UpdUser] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetMemo(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncParaRela.Memo);
objvFuncParaRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.Memo) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.Memo, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.Memo] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncParaRelaEN objvFuncParaRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.mId) == true)
{
string strComparisonOpmId = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncParaRela.mId, objvFuncParaRelaCond.mId, strComparisonOpmId);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.FuncParaId4Code) == true)
{
string strComparisonOpFuncParaId4Code = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.FuncParaId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.FuncParaId4Code, objvFuncParaRelaCond.FuncParaId4Code, strComparisonOpFuncParaId4Code);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.ParaName) == true)
{
string strComparisonOpParaName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.ParaName, objvFuncParaRelaCond.ParaName, strComparisonOpParaName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.ParaCnName) == true)
{
string strComparisonOpParaCnName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.ParaCnName, objvFuncParaRelaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.DataTypeId, objvFuncParaRelaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.DataTypeName, objvFuncParaRelaCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.DataCnName) == true)
{
string strComparisonOpDataCnName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.DataCnName, objvFuncParaRelaCond.DataCnName, strComparisonOpDataCnName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.CsType) == true)
{
string strComparisonOpCsType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.CsType, objvFuncParaRelaCond.CsType, strComparisonOpCsType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.JavaType) == true)
{
string strComparisonOpJavaType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.JavaType, objvFuncParaRelaCond.JavaType, strComparisonOpJavaType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.JavaObjType, objvFuncParaRelaCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.SwiftType) == true)
{
string strComparisonOpSwiftType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.SwiftType, objvFuncParaRelaCond.SwiftType, strComparisonOpSwiftType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.IsNeedQuote) == true)
{
if (objvFuncParaRelaCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncParaRela.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncParaRela.IsNeedQuote);
}
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.OraDbType) == true)
{
string strComparisonOpOraDbType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.OraDbType, objvFuncParaRelaCond.OraDbType, strComparisonOpOraDbType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.MySqlType) == true)
{
string strComparisonOpMySqlType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.MySqlType, objvFuncParaRelaCond.MySqlType, strComparisonOpMySqlType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.ParameterType) == true)
{
string strComparisonOpParameterType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.ParameterType, objvFuncParaRelaCond.ParameterType, strComparisonOpParameterType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.ParameterTypeFullName, objvFuncParaRelaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.IsByRef) == true)
{
if (objvFuncParaRelaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncParaRela.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncParaRela.IsByRef);
}
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.PrjId) == true)
{
string strComparisonOpPrjId = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.PrjId, objvFuncParaRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.FuncId4Code, objvFuncParaRelaCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.FuncName4Code, objvFuncParaRelaCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.FunctionSignature, objvFuncParaRelaCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.IsAsyncFunc) == true)
{
if (objvFuncParaRelaCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncParaRela.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncParaRela.IsAsyncFunc);
}
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.IsSysFunction) == true)
{
if (objvFuncParaRelaCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncParaRela.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncParaRela.IsSysFunction);
}
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncParaRela.OrderNum, objvFuncParaRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.UpdDate, objvFuncParaRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.UpdUser, objvFuncParaRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.Memo) == true)
{
string strComparisonOpMemo = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.Memo, objvFuncParaRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vFuncParaRela(vFuncParaRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFuncParaRelaWApi
{
private static readonly string mstrApiControllerName = "vFuncParaRelaApi";

 public clsvFuncParaRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncParaRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFuncParaRelaEN objvFuncParaRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFuncParaRelaEN = JsonConvert.DeserializeObject<clsvFuncParaRelaEN>(strJson);
return objvFuncParaRelaEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvFuncParaRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFuncParaRelaEN objvFuncParaRelaEN;
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
objvFuncParaRelaEN = JsonConvert.DeserializeObject<clsvFuncParaRelaEN>(strJson);
return objvFuncParaRelaEN;
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
public static List<clsvFuncParaRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncParaRelaEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncParaRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFuncParaRelaEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncParaRelaEN>>(strJson);
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
public static List<clsvFuncParaRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncParaRelaEN>>(strJson);
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
public static List<clsvFuncParaRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncParaRelaEN>>(strJson);
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
public static List<clsvFuncParaRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncParaRelaEN>>(strJson);
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
public static List<clsvFuncParaRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncParaRelaEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvFuncParaRelaENS">源对象</param>
 /// <param name = "objvFuncParaRelaENT">目标对象</param>
 public static void CopyTo(clsvFuncParaRelaEN objvFuncParaRelaENS, clsvFuncParaRelaEN objvFuncParaRelaENT)
{
try
{
objvFuncParaRelaENT.mId = objvFuncParaRelaENS.mId; //mId
objvFuncParaRelaENT.FuncParaId4Code = objvFuncParaRelaENS.FuncParaId4Code; //函数参数Id
objvFuncParaRelaENT.ParaName = objvFuncParaRelaENS.ParaName; //参数名
objvFuncParaRelaENT.ParaCnName = objvFuncParaRelaENS.ParaCnName; //参数中文名
objvFuncParaRelaENT.DataTypeId = objvFuncParaRelaENS.DataTypeId; //数据类型Id
objvFuncParaRelaENT.DataTypeName = objvFuncParaRelaENS.DataTypeName; //数据类型名称
objvFuncParaRelaENT.DataCnName = objvFuncParaRelaENS.DataCnName; //数据类型中文名称
objvFuncParaRelaENT.CsType = objvFuncParaRelaENS.CsType; //CS类型
objvFuncParaRelaENT.JavaType = objvFuncParaRelaENS.JavaType; //JAVA类型
objvFuncParaRelaENT.JavaObjType = objvFuncParaRelaENS.JavaObjType; //JAVA对象类型
objvFuncParaRelaENT.SwiftType = objvFuncParaRelaENS.SwiftType; //SwiftType
objvFuncParaRelaENT.IsNeedQuote = objvFuncParaRelaENS.IsNeedQuote; //是否需要引号
objvFuncParaRelaENT.OraDbType = objvFuncParaRelaENS.OraDbType; //Ora数据类型
objvFuncParaRelaENT.MySqlType = objvFuncParaRelaENS.MySqlType; //MySqlType
objvFuncParaRelaENT.ParameterType = objvFuncParaRelaENS.ParameterType; //参数类型
objvFuncParaRelaENT.ParameterTypeFullName = objvFuncParaRelaENS.ParameterTypeFullName; //参数类型全名
objvFuncParaRelaENT.IsByRef = objvFuncParaRelaENS.IsByRef; //是否引用型参数
objvFuncParaRelaENT.PrjId = objvFuncParaRelaENS.PrjId; //工程Id
objvFuncParaRelaENT.FuncId4Code = objvFuncParaRelaENS.FuncId4Code; //函数Id4Code
objvFuncParaRelaENT.FuncName4Code = objvFuncParaRelaENS.FuncName4Code; //函数名4Code
objvFuncParaRelaENT.FunctionSignature = objvFuncParaRelaENS.FunctionSignature; //函数签名
objvFuncParaRelaENT.IsAsyncFunc = objvFuncParaRelaENS.IsAsyncFunc; //是否异步函数
objvFuncParaRelaENT.IsSysFunction = objvFuncParaRelaENS.IsSysFunction; //是否系统函数
objvFuncParaRelaENT.OrderNum = objvFuncParaRelaENS.OrderNum; //序号
objvFuncParaRelaENT.UpdDate = objvFuncParaRelaENS.UpdDate; //修改日期
objvFuncParaRelaENT.UpdUser = objvFuncParaRelaENS.UpdUser; //修改者
objvFuncParaRelaENT.Memo = objvFuncParaRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFuncParaRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFuncParaRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFuncParaRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFuncParaRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFuncParaRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFuncParaRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFuncParaRelaEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvFuncParaRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFuncParaRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFuncParaRela.FuncParaId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.ParaName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.ParaCnName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.DataCnName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.CsType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.JavaType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.JavaObjType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.SwiftType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.IsNeedQuote, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFuncParaRela.OraDbType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.MySqlType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.ParameterType, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.ParameterTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.IsByRef, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFuncParaRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.FuncName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.IsAsyncFunc, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFuncParaRela.IsSysFunction, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFuncParaRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFuncParaRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFuncParaRela.Memo, Type.GetType("System.String"));
foreach (clsvFuncParaRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFuncParaRela.mId] = objInFor[convFuncParaRela.mId];
objDR[convFuncParaRela.FuncParaId4Code] = objInFor[convFuncParaRela.FuncParaId4Code];
objDR[convFuncParaRela.ParaName] = objInFor[convFuncParaRela.ParaName];
objDR[convFuncParaRela.ParaCnName] = objInFor[convFuncParaRela.ParaCnName];
objDR[convFuncParaRela.DataTypeId] = objInFor[convFuncParaRela.DataTypeId];
objDR[convFuncParaRela.DataTypeName] = objInFor[convFuncParaRela.DataTypeName];
objDR[convFuncParaRela.DataCnName] = objInFor[convFuncParaRela.DataCnName];
objDR[convFuncParaRela.CsType] = objInFor[convFuncParaRela.CsType];
objDR[convFuncParaRela.JavaType] = objInFor[convFuncParaRela.JavaType];
objDR[convFuncParaRela.JavaObjType] = objInFor[convFuncParaRela.JavaObjType];
objDR[convFuncParaRela.SwiftType] = objInFor[convFuncParaRela.SwiftType];
objDR[convFuncParaRela.IsNeedQuote] = objInFor[convFuncParaRela.IsNeedQuote];
objDR[convFuncParaRela.OraDbType] = objInFor[convFuncParaRela.OraDbType];
objDR[convFuncParaRela.MySqlType] = objInFor[convFuncParaRela.MySqlType];
objDR[convFuncParaRela.ParameterType] = objInFor[convFuncParaRela.ParameterType];
objDR[convFuncParaRela.ParameterTypeFullName] = objInFor[convFuncParaRela.ParameterTypeFullName];
objDR[convFuncParaRela.IsByRef] = objInFor[convFuncParaRela.IsByRef];
objDR[convFuncParaRela.PrjId] = objInFor[convFuncParaRela.PrjId];
objDR[convFuncParaRela.FuncId4Code] = objInFor[convFuncParaRela.FuncId4Code];
objDR[convFuncParaRela.FuncName4Code] = objInFor[convFuncParaRela.FuncName4Code];
objDR[convFuncParaRela.FunctionSignature] = objInFor[convFuncParaRela.FunctionSignature];
objDR[convFuncParaRela.IsAsyncFunc] = objInFor[convFuncParaRela.IsAsyncFunc];
objDR[convFuncParaRela.IsSysFunction] = objInFor[convFuncParaRela.IsSysFunction];
objDR[convFuncParaRela.OrderNum] = objInFor[convFuncParaRela.OrderNum];
objDR[convFuncParaRela.UpdDate] = objInFor[convFuncParaRela.UpdDate];
objDR[convFuncParaRela.UpdUser] = objInFor[convFuncParaRela.UpdUser];
objDR[convFuncParaRela.Memo] = objInFor[convFuncParaRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}