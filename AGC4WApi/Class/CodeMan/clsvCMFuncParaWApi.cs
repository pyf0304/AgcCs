
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFuncParaWApi
 表名:vCMFuncPara(00050508)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMFuncParaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFuncParaId">函数参数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetCmFuncParaId(this clsvCMFuncParaEN objvCMFuncParaEN, string strCmFuncParaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmFuncParaId, 8, convCMFuncPara.CmFuncParaId);
clsCheckSql.CheckFieldForeignKey(strCmFuncParaId, 8, convCMFuncPara.CmFuncParaId);
objvCMFuncParaEN.CmFuncParaId = strCmFuncParaId; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.CmFuncParaId) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.CmFuncParaId, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.CmFuncParaId] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaName">参数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParaName(this clsvCMFuncParaEN objvCMFuncParaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, convCMFuncPara.ParaName);
clsCheckSql.CheckFieldLen(strParaName, 50, convCMFuncPara.ParaName);
objvCMFuncParaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParaName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParaName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParaName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaComments">参数注释</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParaComments(this clsvCMFuncParaEN objvCMFuncParaEN, string strParaComments, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParaComments, 500, convCMFuncPara.ParaComments);
objvCMFuncParaEN.ParaComments = strParaComments; //参数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParaComments) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParaComments, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParaComments] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterType">参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParameterType(this clsvCMFuncParaEN objvCMFuncParaEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterType, 100, convCMFuncPara.ParameterType);
objvCMFuncParaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParameterType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParameterType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParameterType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetDataTypeId(this clsvCMFuncParaEN objvCMFuncParaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convCMFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convCMFuncPara.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convCMFuncPara.DataTypeId);
objvCMFuncParaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.DataTypeId) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.DataTypeId, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.DataTypeId] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetDataTypeName(this clsvCMFuncParaEN objvCMFuncParaEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convCMFuncPara.DataTypeName);
objvCMFuncParaEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.DataTypeName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.DataTypeName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.DataTypeName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataCnName">数据类型中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetDataCnName(this clsvCMFuncParaEN objvCMFuncParaEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataCnName, convCMFuncPara.DataCnName);
clsCheckSql.CheckFieldLen(strDataCnName, 100, convCMFuncPara.DataCnName);
objvCMFuncParaEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.DataCnName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.DataCnName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.DataCnName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCsType">CS类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetCsType(this clsvCMFuncParaEN objvCMFuncParaEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, convCMFuncPara.CsType);
clsCheckSql.CheckFieldLen(strCsType, 100, convCMFuncPara.CsType);
objvCMFuncParaEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.CsType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.CsType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.CsType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaType">JAVA类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetJavaType(this clsvCMFuncParaEN objvCMFuncParaEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJavaType, convCMFuncPara.JavaType);
clsCheckSql.CheckFieldLen(strJavaType, 100, convCMFuncPara.JavaType);
objvCMFuncParaEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.JavaType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.JavaType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.JavaType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaObjType">JAVA对象类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetJavaObjType(this clsvCMFuncParaEN objvCMFuncParaEN, string strJavaObjType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convCMFuncPara.JavaObjType);
objvCMFuncParaEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.JavaObjType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.JavaObjType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.JavaObjType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strSwiftType">SwiftType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetSwiftType(this clsvCMFuncParaEN objvCMFuncParaEN, string strSwiftType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convCMFuncPara.SwiftType);
objvCMFuncParaEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.SwiftType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.SwiftType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.SwiftType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedQuote">是否需要引号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetIsNeedQuote(this clsvCMFuncParaEN objvCMFuncParaEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedQuote, convCMFuncPara.IsNeedQuote);
objvCMFuncParaEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.IsNeedQuote) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.IsNeedQuote, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.IsNeedQuote] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strOraDbType">Ora数据类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetOraDbType(this clsvCMFuncParaEN objvCMFuncParaEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOraDbType, convCMFuncPara.OraDbType);
clsCheckSql.CheckFieldLen(strOraDbType, 100, convCMFuncPara.OraDbType);
objvCMFuncParaEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.OraDbType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.OraDbType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.OraDbType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMySqlType">MySqlType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetMySqlType(this clsvCMFuncParaEN objvCMFuncParaEN, string strMySqlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMySqlType, 100, convCMFuncPara.MySqlType);
objvCMFuncParaEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.MySqlType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.MySqlType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.MySqlType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterTypeFullName">参数类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParameterTypeFullName(this clsvCMFuncParaEN objvCMFuncParaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convCMFuncPara.ParameterTypeFullName);
objvCMFuncParaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParameterTypeFullName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParameterTypeFullName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParameterTypeFullName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsByRef">是否引用型参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetIsByRef(this clsvCMFuncParaEN objvCMFuncParaEN, bool bolIsByRef, string strComparisonOp="")
	{
objvCMFuncParaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.IsByRef) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.IsByRef, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.IsByRef] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaCnName">参数中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParaCnName(this clsvCMFuncParaEN objvCMFuncParaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, convCMFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(strParaCnName, 50, convCMFuncPara.ParaCnName);
objvCMFuncParaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParaCnName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParaCnName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParaCnName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetPrjId(this clsvCMFuncParaEN objvCMFuncParaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMFuncPara.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFuncPara.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFuncPara.PrjId);
objvCMFuncParaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.PrjId) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.PrjId, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.PrjId] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetUpdDate(this clsvCMFuncParaEN objvCMFuncParaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFuncPara.UpdDate);
objvCMFuncParaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.UpdDate) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.UpdDate, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.UpdDate] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetUpdUser(this clsvCMFuncParaEN objvCMFuncParaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFuncPara.UpdUser);
objvCMFuncParaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.UpdUser) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.UpdUser, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.UpdUser] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetMemo(this clsvCMFuncParaEN objvCMFuncParaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFuncPara.Memo);
objvCMFuncParaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.Memo) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.Memo, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.Memo] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "intFuncCount">函数数目</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetFuncCount(this clsvCMFuncParaEN objvCMFuncParaEN, int intFuncCount, string strComparisonOp="")
	{
objvCMFuncParaEN.FuncCount = intFuncCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.FuncCount) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.FuncCount, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.FuncCount] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMFuncParaEN objvCMFuncParaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.CmFuncParaId) == true)
{
string strComparisonOpCmFuncParaId = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.CmFuncParaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.CmFuncParaId, objvCMFuncParaCond.CmFuncParaId, strComparisonOpCmFuncParaId);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParaName) == true)
{
string strComparisonOpParaName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParaName, objvCMFuncParaCond.ParaName, strComparisonOpParaName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParaComments) == true)
{
string strComparisonOpParaComments = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParaComments];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParaComments, objvCMFuncParaCond.ParaComments, strComparisonOpParaComments);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParameterType) == true)
{
string strComparisonOpParameterType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParameterType, objvCMFuncParaCond.ParameterType, strComparisonOpParameterType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.DataTypeId, objvCMFuncParaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.DataTypeName, objvCMFuncParaCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.DataCnName) == true)
{
string strComparisonOpDataCnName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.DataCnName, objvCMFuncParaCond.DataCnName, strComparisonOpDataCnName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.CsType) == true)
{
string strComparisonOpCsType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.CsType, objvCMFuncParaCond.CsType, strComparisonOpCsType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.JavaType) == true)
{
string strComparisonOpJavaType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.JavaType, objvCMFuncParaCond.JavaType, strComparisonOpJavaType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.JavaObjType, objvCMFuncParaCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.SwiftType) == true)
{
string strComparisonOpSwiftType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.SwiftType, objvCMFuncParaCond.SwiftType, strComparisonOpSwiftType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.IsNeedQuote) == true)
{
if (objvCMFuncParaCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFuncPara.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFuncPara.IsNeedQuote);
}
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.OraDbType) == true)
{
string strComparisonOpOraDbType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.OraDbType, objvCMFuncParaCond.OraDbType, strComparisonOpOraDbType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.MySqlType) == true)
{
string strComparisonOpMySqlType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.MySqlType, objvCMFuncParaCond.MySqlType, strComparisonOpMySqlType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParameterTypeFullName, objvCMFuncParaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.IsByRef) == true)
{
if (objvCMFuncParaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFuncPara.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFuncPara.IsByRef);
}
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParaCnName) == true)
{
string strComparisonOpParaCnName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParaCnName, objvCMFuncParaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.PrjId) == true)
{
string strComparisonOpPrjId = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.PrjId, objvCMFuncParaCond.PrjId, strComparisonOpPrjId);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.UpdDate, objvCMFuncParaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.UpdUser, objvCMFuncParaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.Memo) == true)
{
string strComparisonOpMemo = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.Memo, objvCMFuncParaCond.Memo, strComparisonOpMemo);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.FuncCount) == true)
{
string strComparisonOpFuncCount = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.FuncCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFuncPara.FuncCount, objvCMFuncParaCond.FuncCount, strComparisonOpFuncCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCM函数参数(vCMFuncPara)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMFuncParaWApi
{
private static readonly string mstrApiControllerName = "vCMFuncParaApi";

 public clsvCMFuncParaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFuncParaEN GetObjByCmFuncParaId(string strCmFuncParaId)
{
if (strCmFuncParaId == "") return null;
string strAction = "GetObjByCmFuncParaId";
clsvCMFuncParaEN objvCMFuncParaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFuncParaId"] = strCmFuncParaId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCMFuncParaEN = JsonConvert.DeserializeObject<clsvCMFuncParaEN>(strJson);
return objvCMFuncParaEN;
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
public static clsvCMFuncParaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMFuncParaEN objvCMFuncParaEN;
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
objvCMFuncParaEN = JsonConvert.DeserializeObject<clsvCMFuncParaEN>(strJson);
return objvCMFuncParaEN;
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
public static List<clsvCMFuncParaEN> GetObjLst(string strWhereCond)
{
 List<clsvCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaEN>>(strJson);
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
 /// <param name = "arrCmFuncParaId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFuncParaEN> GetObjLstByCmFuncParaIdLst(List<string> arrCmFuncParaId)
{
 List<clsvCMFuncParaEN> arrObjLst; 
string strAction = "GetObjLstByCmFuncParaIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmFuncParaId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaEN>>(strJson);
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
public static List<clsvCMFuncParaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaEN>>(strJson);
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
public static List<clsvCMFuncParaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaEN>>(strJson);
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
public static List<clsvCMFuncParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaEN>>(strJson);
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
public static List<clsvCMFuncParaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaEN>>(strJson);
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
public static bool IsExist(string strCmFuncParaId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFuncParaId"] = strCmFuncParaId
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
 /// <param name = "objvCMFuncParaENS">源对象</param>
 /// <param name = "objvCMFuncParaENT">目标对象</param>
 public static void CopyTo(clsvCMFuncParaEN objvCMFuncParaENS, clsvCMFuncParaEN objvCMFuncParaENT)
{
try
{
objvCMFuncParaENT.CmFuncParaId = objvCMFuncParaENS.CmFuncParaId; //函数参数Id
objvCMFuncParaENT.ParaName = objvCMFuncParaENS.ParaName; //参数名
objvCMFuncParaENT.ParaComments = objvCMFuncParaENS.ParaComments; //参数注释
objvCMFuncParaENT.ParameterType = objvCMFuncParaENS.ParameterType; //参数类型
objvCMFuncParaENT.DataTypeId = objvCMFuncParaENS.DataTypeId; //数据类型Id
objvCMFuncParaENT.DataTypeName = objvCMFuncParaENS.DataTypeName; //数据类型名称
objvCMFuncParaENT.DataCnName = objvCMFuncParaENS.DataCnName; //数据类型中文名称
objvCMFuncParaENT.CsType = objvCMFuncParaENS.CsType; //CS类型
objvCMFuncParaENT.JavaType = objvCMFuncParaENS.JavaType; //JAVA类型
objvCMFuncParaENT.JavaObjType = objvCMFuncParaENS.JavaObjType; //JAVA对象类型
objvCMFuncParaENT.SwiftType = objvCMFuncParaENS.SwiftType; //SwiftType
objvCMFuncParaENT.IsNeedQuote = objvCMFuncParaENS.IsNeedQuote; //是否需要引号
objvCMFuncParaENT.OraDbType = objvCMFuncParaENS.OraDbType; //Ora数据类型
objvCMFuncParaENT.MySqlType = objvCMFuncParaENS.MySqlType; //MySqlType
objvCMFuncParaENT.ParameterTypeFullName = objvCMFuncParaENS.ParameterTypeFullName; //参数类型全名
objvCMFuncParaENT.IsByRef = objvCMFuncParaENS.IsByRef; //是否引用型参数
objvCMFuncParaENT.ParaCnName = objvCMFuncParaENS.ParaCnName; //参数中文名
objvCMFuncParaENT.PrjId = objvCMFuncParaENS.PrjId; //工程Id
objvCMFuncParaENT.UpdDate = objvCMFuncParaENS.UpdDate; //修改日期
objvCMFuncParaENT.UpdUser = objvCMFuncParaENS.UpdUser; //修改者
objvCMFuncParaENT.Memo = objvCMFuncParaENS.Memo; //说明
objvCMFuncParaENT.FuncCount = objvCMFuncParaENS.FuncCount; //函数数目
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
public static DataTable ToDataTable(List<clsvCMFuncParaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMFuncParaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMFuncParaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMFuncParaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMFuncParaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMFuncParaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvCMFuncParaEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvCMFuncParaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMFuncPara.CmFuncParaId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.ParaName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.ParaComments, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.ParameterType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.DataCnName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.CsType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.JavaType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.JavaObjType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.SwiftType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.IsNeedQuote, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCMFuncPara.OraDbType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.MySqlType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.ParameterTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.IsByRef, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCMFuncPara.ParaCnName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncPara.FuncCount, Type.GetType("System.Int32"));
foreach (clsvCMFuncParaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMFuncPara.CmFuncParaId] = objInFor[convCMFuncPara.CmFuncParaId];
objDR[convCMFuncPara.ParaName] = objInFor[convCMFuncPara.ParaName];
objDR[convCMFuncPara.ParaComments] = objInFor[convCMFuncPara.ParaComments];
objDR[convCMFuncPara.ParameterType] = objInFor[convCMFuncPara.ParameterType];
objDR[convCMFuncPara.DataTypeId] = objInFor[convCMFuncPara.DataTypeId];
objDR[convCMFuncPara.DataTypeName] = objInFor[convCMFuncPara.DataTypeName];
objDR[convCMFuncPara.DataCnName] = objInFor[convCMFuncPara.DataCnName];
objDR[convCMFuncPara.CsType] = objInFor[convCMFuncPara.CsType];
objDR[convCMFuncPara.JavaType] = objInFor[convCMFuncPara.JavaType];
objDR[convCMFuncPara.JavaObjType] = objInFor[convCMFuncPara.JavaObjType];
objDR[convCMFuncPara.SwiftType] = objInFor[convCMFuncPara.SwiftType];
objDR[convCMFuncPara.IsNeedQuote] = objInFor[convCMFuncPara.IsNeedQuote];
objDR[convCMFuncPara.OraDbType] = objInFor[convCMFuncPara.OraDbType];
objDR[convCMFuncPara.MySqlType] = objInFor[convCMFuncPara.MySqlType];
objDR[convCMFuncPara.ParameterTypeFullName] = objInFor[convCMFuncPara.ParameterTypeFullName];
objDR[convCMFuncPara.IsByRef] = objInFor[convCMFuncPara.IsByRef];
objDR[convCMFuncPara.ParaCnName] = objInFor[convCMFuncPara.ParaCnName];
objDR[convCMFuncPara.PrjId] = objInFor[convCMFuncPara.PrjId];
objDR[convCMFuncPara.UpdDate] = objInFor[convCMFuncPara.UpdDate];
objDR[convCMFuncPara.UpdUser] = objInFor[convCMFuncPara.UpdUser];
objDR[convCMFuncPara.Memo] = objInFor[convCMFuncPara.Memo];
objDR[convCMFuncPara.FuncCount] = objInFor[convCMFuncPara.FuncCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}