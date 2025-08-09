
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFuncParaRelaWApi
 表名:vCMFuncParaRela(00050509)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvCMFuncParaRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetmId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, long lngmId, string strComparisonOp="")
	{
objvCMFuncParaRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.mId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.mId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.mId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFuncParaId">函数参数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetCmFuncParaId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strCmFuncParaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFuncParaId, convCMFuncParaRela.CmFuncParaId);
clsCheckSql.CheckFieldLen(strCmFuncParaId, 8, convCMFuncParaRela.CmFuncParaId);
clsCheckSql.CheckFieldForeignKey(strCmFuncParaId, 8, convCMFuncParaRela.CmFuncParaId);
objvCMFuncParaRelaEN.CmFuncParaId = strCmFuncParaId; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.CmFuncParaId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.CmFuncParaId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.CmFuncParaId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaName">参数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParaName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, convCMFuncParaRela.ParaName);
clsCheckSql.CheckFieldLen(strParaName, 50, convCMFuncParaRela.ParaName);
objvCMFuncParaRelaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParaName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParaName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParaName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaComments">参数注释</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParaComments(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParaComments, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParaComments, 500, convCMFuncParaRela.ParaComments);
objvCMFuncParaRelaEN.ParaComments = strParaComments; //参数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParaComments) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParaComments, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParaComments] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterType">参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParameterType(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterType, 100, convCMFuncParaRela.ParameterType);
objvCMFuncParaRelaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParameterType) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParameterType, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParameterType] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetDataTypeId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convCMFuncParaRela.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convCMFuncParaRela.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convCMFuncParaRela.DataTypeId);
objvCMFuncParaRelaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.DataTypeId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.DataTypeId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.DataTypeId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetDataTypeName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convCMFuncParaRela.DataTypeName);
objvCMFuncParaRelaEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.DataTypeName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.DataTypeName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.DataTypeName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCsType">CS类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetCsType(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCsType, 100, convCMFuncParaRela.CsType);
objvCMFuncParaRelaEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.CsType) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.CsType, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.CsType] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaType">JAVA类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetJavaType(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaType, 100, convCMFuncParaRela.JavaType);
objvCMFuncParaRelaEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.JavaType) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.JavaType, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.JavaType] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedQuote">是否需要引号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetIsNeedQuote(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
objvCMFuncParaRelaEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.IsNeedQuote) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.IsNeedQuote, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.IsNeedQuote] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterTypeFullName">参数类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParameterTypeFullName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convCMFuncParaRela.ParameterTypeFullName);
objvCMFuncParaRelaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParameterTypeFullName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParameterTypeFullName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParameterTypeFullName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsByRef">是否引用型参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetIsByRef(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, bool bolIsByRef, string strComparisonOp="")
	{
objvCMFuncParaRelaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.IsByRef) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.IsByRef, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.IsByRef] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaCnName">参数中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParaCnName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, convCMFuncParaRela.ParaCnName);
clsCheckSql.CheckFieldLen(strParaCnName, 50, convCMFuncParaRela.ParaCnName);
objvCMFuncParaRelaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParaCnName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParaCnName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParaCnName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFunctionId">函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetCmFunctionId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFunctionId, convCMFuncParaRela.CmFunctionId);
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, convCMFuncParaRela.CmFunctionId);
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, convCMFuncParaRela.CmFunctionId);
objvCMFuncParaRelaEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.CmFunctionId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.CmFunctionId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.CmFunctionId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetFunctionName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convCMFuncParaRela.FunctionName);
objvCMFuncParaRelaEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.FunctionName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.FunctionName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.FunctionName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetFunctionSignature(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convCMFuncParaRela.FunctionSignature);
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convCMFuncParaRela.FunctionSignature);
objvCMFuncParaRelaEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.FunctionSignature) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.FunctionSignature, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.FunctionSignature] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetOrderNum(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCMFuncParaRela.OrderNum);
objvCMFuncParaRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.OrderNum) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.OrderNum, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.OrderNum] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetPrjId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMFuncParaRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFuncParaRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFuncParaRela.PrjId);
objvCMFuncParaRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.PrjId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.PrjId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.PrjId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetUpdDate(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFuncParaRela.UpdDate);
objvCMFuncParaRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.UpdDate) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.UpdDate, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.UpdDate] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetUpdUser(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFuncParaRela.UpdUser);
objvCMFuncParaRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.UpdUser) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.UpdUser, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.UpdUser] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetMemo(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFuncParaRela.Memo);
objvCMFuncParaRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.Memo) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.Memo, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.Memo] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMFuncParaRelaEN objvCMFuncParaRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.mId) == true)
{
string strComparisonOpmId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFuncParaRela.mId, objvCMFuncParaRelaCond.mId, strComparisonOpmId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.CmFuncParaId) == true)
{
string strComparisonOpCmFuncParaId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.CmFuncParaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.CmFuncParaId, objvCMFuncParaRelaCond.CmFuncParaId, strComparisonOpCmFuncParaId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParaName) == true)
{
string strComparisonOpParaName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParaName, objvCMFuncParaRelaCond.ParaName, strComparisonOpParaName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParaComments) == true)
{
string strComparisonOpParaComments = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParaComments];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParaComments, objvCMFuncParaRelaCond.ParaComments, strComparisonOpParaComments);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParameterType) == true)
{
string strComparisonOpParameterType = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParameterType, objvCMFuncParaRelaCond.ParameterType, strComparisonOpParameterType);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.DataTypeId, objvCMFuncParaRelaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.DataTypeName, objvCMFuncParaRelaCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.CsType) == true)
{
string strComparisonOpCsType = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.CsType, objvCMFuncParaRelaCond.CsType, strComparisonOpCsType);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.JavaType) == true)
{
string strComparisonOpJavaType = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.JavaType, objvCMFuncParaRelaCond.JavaType, strComparisonOpJavaType);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.IsNeedQuote) == true)
{
if (objvCMFuncParaRelaCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFuncParaRela.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFuncParaRela.IsNeedQuote);
}
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParameterTypeFullName, objvCMFuncParaRelaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.IsByRef) == true)
{
if (objvCMFuncParaRelaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFuncParaRela.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFuncParaRela.IsByRef);
}
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParaCnName) == true)
{
string strComparisonOpParaCnName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParaCnName, objvCMFuncParaRelaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.CmFunctionId, objvCMFuncParaRelaCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.FunctionName) == true)
{
string strComparisonOpFunctionName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.FunctionName, objvCMFuncParaRelaCond.FunctionName, strComparisonOpFunctionName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.FunctionSignature, objvCMFuncParaRelaCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFuncParaRela.OrderNum, objvCMFuncParaRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.PrjId) == true)
{
string strComparisonOpPrjId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.PrjId, objvCMFuncParaRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.UpdDate, objvCMFuncParaRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.UpdUser, objvCMFuncParaRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.Memo) == true)
{
string strComparisonOpMemo = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.Memo, objvCMFuncParaRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCM函数参数关系(vCMFuncParaRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMFuncParaRelaWApi
{
private static readonly string mstrApiControllerName = "vCMFuncParaRelaApi";

 public clsvCMFuncParaRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFuncParaRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvCMFuncParaRelaEN objvCMFuncParaRelaEN;
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
objvCMFuncParaRelaEN = JsonConvert.DeserializeObject<clsvCMFuncParaRelaEN>(strJson);
return objvCMFuncParaRelaEN;
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
public static clsvCMFuncParaRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMFuncParaRelaEN objvCMFuncParaRelaEN;
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
objvCMFuncParaRelaEN = JsonConvert.DeserializeObject<clsvCMFuncParaRelaEN>(strJson);
return objvCMFuncParaRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFuncParaRelaEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMFuncParaRelaEN._CurrTabName, strPrjId);
List<clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLst_Sel =
from objvCMFuncParaRelaEN in arrvCMFuncParaRelaObjLstCache
where objvCMFuncParaRelaEN.mId == lngmId 
select objvCMFuncParaRelaEN;
if (arrvCMFuncParaRelaObjLst_Sel.Count() == 0)
{
   clsvCMFuncParaRelaEN obj = clsvCMFuncParaRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCMFuncParaRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvCMFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaRelaEN>>(strJson);
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
public static List<clsvCMFuncParaRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCMFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaRelaEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCMFuncParaRelaEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMFuncParaRelaEN._CurrTabName, strPrjId);
List<clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLst_Sel =
from objvCMFuncParaRelaEN in arrvCMFuncParaRelaObjLstCache
where arrMId.Contains(objvCMFuncParaRelaEN.mId)
select objvCMFuncParaRelaEN;
return arrvCMFuncParaRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaRelaEN>>(strJson);
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
public static List<clsvCMFuncParaRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaRelaEN>>(strJson);
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
public static List<clsvCMFuncParaRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaRelaEN>>(strJson);
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
public static List<clsvCMFuncParaRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMFuncParaRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFuncParaRelaEN>>(strJson);
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
 /// <param name = "objvCMFuncParaRelaENS">源对象</param>
 /// <param name = "objvCMFuncParaRelaENT">目标对象</param>
 public static void CopyTo(clsvCMFuncParaRelaEN objvCMFuncParaRelaENS, clsvCMFuncParaRelaEN objvCMFuncParaRelaENT)
{
try
{
objvCMFuncParaRelaENT.mId = objvCMFuncParaRelaENS.mId; //mId
objvCMFuncParaRelaENT.CmFuncParaId = objvCMFuncParaRelaENS.CmFuncParaId; //函数参数Id
objvCMFuncParaRelaENT.ParaName = objvCMFuncParaRelaENS.ParaName; //参数名
objvCMFuncParaRelaENT.ParaComments = objvCMFuncParaRelaENS.ParaComments; //参数注释
objvCMFuncParaRelaENT.ParameterType = objvCMFuncParaRelaENS.ParameterType; //参数类型
objvCMFuncParaRelaENT.DataTypeId = objvCMFuncParaRelaENS.DataTypeId; //数据类型Id
objvCMFuncParaRelaENT.DataTypeName = objvCMFuncParaRelaENS.DataTypeName; //数据类型名称
objvCMFuncParaRelaENT.CsType = objvCMFuncParaRelaENS.CsType; //CS类型
objvCMFuncParaRelaENT.JavaType = objvCMFuncParaRelaENS.JavaType; //JAVA类型
objvCMFuncParaRelaENT.IsNeedQuote = objvCMFuncParaRelaENS.IsNeedQuote; //是否需要引号
objvCMFuncParaRelaENT.ParameterTypeFullName = objvCMFuncParaRelaENS.ParameterTypeFullName; //参数类型全名
objvCMFuncParaRelaENT.IsByRef = objvCMFuncParaRelaENS.IsByRef; //是否引用型参数
objvCMFuncParaRelaENT.ParaCnName = objvCMFuncParaRelaENS.ParaCnName; //参数中文名
objvCMFuncParaRelaENT.CmFunctionId = objvCMFuncParaRelaENS.CmFunctionId; //函数Id
objvCMFuncParaRelaENT.FunctionName = objvCMFuncParaRelaENS.FunctionName; //功能名称
objvCMFuncParaRelaENT.FunctionSignature = objvCMFuncParaRelaENS.FunctionSignature; //函数签名
objvCMFuncParaRelaENT.OrderNum = objvCMFuncParaRelaENS.OrderNum; //序号
objvCMFuncParaRelaENT.PrjId = objvCMFuncParaRelaENS.PrjId; //工程Id
objvCMFuncParaRelaENT.UpdDate = objvCMFuncParaRelaENS.UpdDate; //修改日期
objvCMFuncParaRelaENT.UpdUser = objvCMFuncParaRelaENS.UpdUser; //修改者
objvCMFuncParaRelaENT.Memo = objvCMFuncParaRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvCMFuncParaRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMFuncParaRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMFuncParaRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMFuncParaRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMFuncParaRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMFuncParaRelaEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMFuncParaRelaWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMFuncParaRelaWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCMFuncParaRelaEN._CurrTabName, strPrjId);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMFuncParaRelaWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMFuncParaRelaWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCMFuncParaRelaEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCMFuncParaRelaEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCMFuncParaRela.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvCMFuncParaRelaEN._CurrTabName, strPrjId);
List<clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCMFuncParaRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvCMFuncParaRelaEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMFuncParaRelaWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMFuncParaRelaWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvCMFuncParaRelaEN._CurrTabName, strPrjId);
List<clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCMFuncParaRelaObjLstCache = CacheHelper.Get<List<clsvCMFuncParaRelaEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCMFuncParaRelaObjLstCache = CacheHelper.Get<List<clsvCMFuncParaRelaEN>>(strKey);
}
return arrvCMFuncParaRelaObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMFuncParaRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMFuncParaRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCMFuncParaRela.CmFuncParaId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.ParaName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.ParaComments, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.ParameterType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.CsType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.JavaType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.IsNeedQuote, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCMFuncParaRela.ParameterTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.IsByRef, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCMFuncParaRela.ParaCnName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.CmFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMFuncParaRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMFuncParaRela.Memo, Type.GetType("System.String"));
foreach (clsvCMFuncParaRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMFuncParaRela.mId] = objInFor[convCMFuncParaRela.mId];
objDR[convCMFuncParaRela.CmFuncParaId] = objInFor[convCMFuncParaRela.CmFuncParaId];
objDR[convCMFuncParaRela.ParaName] = objInFor[convCMFuncParaRela.ParaName];
objDR[convCMFuncParaRela.ParaComments] = objInFor[convCMFuncParaRela.ParaComments];
objDR[convCMFuncParaRela.ParameterType] = objInFor[convCMFuncParaRela.ParameterType];
objDR[convCMFuncParaRela.DataTypeId] = objInFor[convCMFuncParaRela.DataTypeId];
objDR[convCMFuncParaRela.DataTypeName] = objInFor[convCMFuncParaRela.DataTypeName];
objDR[convCMFuncParaRela.CsType] = objInFor[convCMFuncParaRela.CsType];
objDR[convCMFuncParaRela.JavaType] = objInFor[convCMFuncParaRela.JavaType];
objDR[convCMFuncParaRela.IsNeedQuote] = objInFor[convCMFuncParaRela.IsNeedQuote];
objDR[convCMFuncParaRela.ParameterTypeFullName] = objInFor[convCMFuncParaRela.ParameterTypeFullName];
objDR[convCMFuncParaRela.IsByRef] = objInFor[convCMFuncParaRela.IsByRef];
objDR[convCMFuncParaRela.ParaCnName] = objInFor[convCMFuncParaRela.ParaCnName];
objDR[convCMFuncParaRela.CmFunctionId] = objInFor[convCMFuncParaRela.CmFunctionId];
objDR[convCMFuncParaRela.FunctionName] = objInFor[convCMFuncParaRela.FunctionName];
objDR[convCMFuncParaRela.FunctionSignature] = objInFor[convCMFuncParaRela.FunctionSignature];
objDR[convCMFuncParaRela.OrderNum] = objInFor[convCMFuncParaRela.OrderNum];
objDR[convCMFuncParaRela.PrjId] = objInFor[convCMFuncParaRela.PrjId];
objDR[convCMFuncParaRela.UpdDate] = objInFor[convCMFuncParaRela.UpdDate];
objDR[convCMFuncParaRela.UpdUser] = objInFor[convCMFuncParaRela.UpdUser];
objDR[convCMFuncParaRela.Memo] = objInFor[convCMFuncParaRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}