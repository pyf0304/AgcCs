
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvFunctionsWApi
 表名:WebSrvFunctions(00050342)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:39:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsWebSrvFunctionsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvFunctionId">函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetWebSrvFunctionId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strWebSrvFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSrvFunctionId, 8, conWebSrvFunctions.WebSrvFunctionId);
clsCheckSql.CheckFieldForeignKey(strWebSrvFunctionId, 8, conWebSrvFunctions.WebSrvFunctionId);
objWebSrvFunctionsEN.WebSrvFunctionId = strWebSrvFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.WebSrvFunctionId) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.WebSrvFunctionId, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.WebSrvFunctionId] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetWebSrvClassId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvClassId, conWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, conWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, conWebSrvFunctions.WebSrvClassId);
objWebSrvFunctionsEN.WebSrvClassId = strWebSrvClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.WebSrvClassId) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.WebSrvClassId, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.WebSrvClassId] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetFunctionName(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionName, conWebSrvFunctions.FunctionName);
clsCheckSql.CheckFieldLen(strFunctionName, 200, conWebSrvFunctions.FunctionName);
objWebSrvFunctionsEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.FunctionName) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.FunctionName, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.FunctionName] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "intGetCustomAttributes">GetCustomAttributes</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetGetCustomAttributes(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, int intGetCustomAttributes, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intGetCustomAttributes, conWebSrvFunctions.GetCustomAttributes);
objWebSrvFunctionsEN.GetCustomAttributes = intGetCustomAttributes; //GetCustomAttributes
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.GetCustomAttributes) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.GetCustomAttributes, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.GetCustomAttributes] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetFunctionSignature(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, conWebSrvFunctions.FunctionSignature);
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, conWebSrvFunctions.FunctionSignature);
objWebSrvFunctionsEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.FunctionSignature) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.FunctionSignature, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.FunctionSignature] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetFuncTypeId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeId, conWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conWebSrvFunctions.FuncTypeId);
objWebSrvFunctionsEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.FuncTypeId) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.FuncTypeId, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.FuncTypeId] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnType">返回类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetReturnType(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnType, conWebSrvFunctions.ReturnType);
clsCheckSql.CheckFieldLen(strReturnType, 500, conWebSrvFunctions.ReturnType);
objWebSrvFunctionsEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.ReturnType) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.ReturnType, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.ReturnType] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeFullName">返回类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetReturnTypeFullName(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strReturnTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeFullName, 500, conWebSrvFunctions.ReturnTypeFullName);
objWebSrvFunctionsEN.ReturnTypeFullName = strReturnTypeFullName; //返回类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.ReturnTypeFullName) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.ReturnTypeFullName, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.ReturnTypeFullName] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsKnownType">是否已知类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetIsKnownType(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsKnownType, string strComparisonOp="")
	{
objWebSrvFunctionsEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.IsKnownType) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.IsKnownType, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.IsKnownType] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetReturnTypeId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, conWebSrvFunctions.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, conWebSrvFunctions.ReturnTypeId);
objWebSrvFunctionsEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.ReturnTypeId) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.ReturnTypeId, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.ReturnTypeId] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAsyncFunc">是否异步函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetIsAsyncFunc(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objWebSrvFunctionsEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.IsAsyncFunc) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.IsAsyncFunc, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.IsAsyncFunc] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSourceFunction">来源函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetSourceFunction(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strSourceFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSourceFunction, 500, conWebSrvFunctions.SourceFunction);
objWebSrvFunctionsEN.SourceFunction = strSourceFunction; //来源函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.SourceFunction) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.SourceFunction, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.SourceFunction] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGeneCode">是否生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetIsGeneCode(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objWebSrvFunctionsEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.IsGeneCode) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.IsGeneCode, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.IsGeneCode] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnValueDescription">返回值说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetReturnValueDescription(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strReturnValueDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnValueDescription, 500, conWebSrvFunctions.ReturnValueDescription);
objWebSrvFunctionsEN.ReturnValueDescription = strReturnValueDescription; //返回值说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.ReturnValueDescription) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.ReturnValueDescription, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.ReturnValueDescription] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncParaLst">函数参数列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetFuncParaLst(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strFuncParaLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, conWebSrvFunctions.FuncParaLst);
objWebSrvFunctionsEN.FuncParaLst = strFuncParaLst; //函数参数列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.FuncParaLst) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.FuncParaLst, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.FuncParaLst] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSysFunction">是否系统函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetIsSysFunction(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objWebSrvFunctionsEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.IsSysFunction) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.IsSysFunction, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.IsSysFunction] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetUpdDate(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conWebSrvFunctions.UpdDate);
objWebSrvFunctionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.UpdDate) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.UpdDate, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.UpdDate] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetUpdUser(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conWebSrvFunctions.UpdUser);
objWebSrvFunctionsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.UpdUser) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.UpdUser, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.UpdUser] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetMemo(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conWebSrvFunctions.Memo);
objWebSrvFunctionsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.Memo) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.Memo, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.Memo] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsWebSrvFunctionsEN objWebSrvFunctionsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.WebSrvFunctionId) == true)
{
string strComparisonOpWebSrvFunctionId = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.WebSrvFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.WebSrvFunctionId, objWebSrvFunctionsCond.WebSrvFunctionId, strComparisonOpWebSrvFunctionId);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.WebSrvClassId) == true)
{
string strComparisonOpWebSrvClassId = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.WebSrvClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.WebSrvClassId, objWebSrvFunctionsCond.WebSrvClassId, strComparisonOpWebSrvClassId);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.FunctionName) == true)
{
string strComparisonOpFunctionName = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.FunctionName, objWebSrvFunctionsCond.FunctionName, strComparisonOpFunctionName);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.GetCustomAttributes) == true)
{
string strComparisonOpGetCustomAttributes = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.GetCustomAttributes];
strWhereCond += string.Format(" And {0} {2} {1}", conWebSrvFunctions.GetCustomAttributes, objWebSrvFunctionsCond.GetCustomAttributes, strComparisonOpGetCustomAttributes);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.FunctionSignature, objWebSrvFunctionsCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.FuncTypeId, objWebSrvFunctionsCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.ReturnType) == true)
{
string strComparisonOpReturnType = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.ReturnType, objWebSrvFunctionsCond.ReturnType, strComparisonOpReturnType);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.ReturnTypeFullName) == true)
{
string strComparisonOpReturnTypeFullName = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.ReturnTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.ReturnTypeFullName, objWebSrvFunctionsCond.ReturnTypeFullName, strComparisonOpReturnTypeFullName);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.IsKnownType) == true)
{
if (objWebSrvFunctionsCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFunctions.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFunctions.IsKnownType);
}
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.ReturnTypeId, objWebSrvFunctionsCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.IsAsyncFunc) == true)
{
if (objWebSrvFunctionsCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFunctions.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFunctions.IsAsyncFunc);
}
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.SourceFunction) == true)
{
string strComparisonOpSourceFunction = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.SourceFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.SourceFunction, objWebSrvFunctionsCond.SourceFunction, strComparisonOpSourceFunction);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.IsGeneCode) == true)
{
if (objWebSrvFunctionsCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFunctions.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFunctions.IsGeneCode);
}
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.ReturnValueDescription) == true)
{
string strComparisonOpReturnValueDescription = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.ReturnValueDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.ReturnValueDescription, objWebSrvFunctionsCond.ReturnValueDescription, strComparisonOpReturnValueDescription);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.FuncParaLst) == true)
{
string strComparisonOpFuncParaLst = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.FuncParaLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.FuncParaLst, objWebSrvFunctionsCond.FuncParaLst, strComparisonOpFuncParaLst);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.IsSysFunction) == true)
{
if (objWebSrvFunctionsCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFunctions.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFunctions.IsSysFunction);
}
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.UpdDate) == true)
{
string strComparisonOpUpdDate = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.UpdDate, objWebSrvFunctionsCond.UpdDate, strComparisonOpUpdDate);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.UpdUser) == true)
{
string strComparisonOpUpdUser = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.UpdUser, objWebSrvFunctionsCond.UpdUser, strComparisonOpUpdUser);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.Memo) == true)
{
string strComparisonOpMemo = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.Memo, objWebSrvFunctionsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objWebSrvFunctionsEN.sfUpdFldSetStr = objWebSrvFunctionsEN.getsfUpdFldSetStr();
clsWebSrvFunctionsWApi.CheckPropertyNew(objWebSrvFunctionsEN); 
bool bolResult = clsWebSrvFunctionsWApi.UpdateRecord(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsWApi.ReFreshCache();
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
 /// 获取唯一性条件串--WebSrvFunctions(WebSrv函数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FunctionName_WebSrvClassId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objWebSrvFunctionsEN == null) return "";
if (objWebSrvFunctionsEN.WebSrvFunctionId == null || objWebSrvFunctionsEN.WebSrvFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objWebSrvFunctionsEN.FunctionName);
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objWebSrvFunctionsEN.WebSrvClassId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("WebSrvFunctionId !=  '{0}'", objWebSrvFunctionsEN.WebSrvFunctionId);
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objWebSrvFunctionsEN.FunctionName);
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objWebSrvFunctionsEN.WebSrvClassId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
try
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true || clsWebSrvFunctionsWApi.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
     objWebSrvFunctionsEN.WebSrvFunctionId = clsWebSrvFunctionsWApi.GetMaxStrId();
 }
clsWebSrvFunctionsWApi.CheckPropertyNew(objWebSrvFunctionsEN); 
bool bolResult = clsWebSrvFunctionsWApi.AddNewRecord(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsWApi.ReFreshCache();
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
try
{
clsWebSrvFunctionsWApi.CheckPropertyNew(objWebSrvFunctionsEN); 
string strWebSrvFunctionId = clsWebSrvFunctionsWApi.AddNewRecordWithMaxId(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsWApi.ReFreshCache();
return strWebSrvFunctionId;
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
 /// <param name = "objWebSrvFunctionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strWhereCond)
{
try
{
clsWebSrvFunctionsWApi.CheckPropertyNew(objWebSrvFunctionsEN); 
bool bolResult = clsWebSrvFunctionsWApi.UpdateWithCondition(objWebSrvFunctionsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsWApi.ReFreshCache();
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
 /// WebSrv函数(WebSrvFunctions)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsWebSrvFunctionsWApi
{
private static readonly string mstrApiControllerName = "WebSrvFunctionsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsWebSrvFunctionsWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_WebSrvFunctionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[WebSrv函数]...","0");
List<clsWebSrvFunctionsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="WebSrvFunctionId";
objDDL.DataTextField="FunctionName";
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

public static void BindCbo_WebSrvFunctionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conWebSrvFunctions.WebSrvFunctionId); 
List<clsWebSrvFunctionsEN> arrObjLst = clsWebSrvFunctionsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN()
{
WebSrvFunctionId = "0",
FunctionName = "选[WebSrv函数]..."
};
arrObjLst.Insert(0, objWebSrvFunctionsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conWebSrvFunctions.WebSrvFunctionId;
objComboBox.DisplayMember = conWebSrvFunctions.FunctionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
if (!Object.Equals(null, objWebSrvFunctionsEN.WebSrvFunctionId) && GetStrLen(objWebSrvFunctionsEN.WebSrvFunctionId) > 8)
{
 throw new Exception("字段[函数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.WebSrvClassId) && GetStrLen(objWebSrvFunctionsEN.WebSrvClassId) > 8)
{
 throw new Exception("字段[类Id]的长度不能超过8!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.FunctionName) && GetStrLen(objWebSrvFunctionsEN.FunctionName) > 200)
{
 throw new Exception("字段[功能名称]的长度不能超过200!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.FunctionSignature) && GetStrLen(objWebSrvFunctionsEN.FunctionSignature) > 500)
{
 throw new Exception("字段[函数签名]的长度不能超过500!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.FuncTypeId) && GetStrLen(objWebSrvFunctionsEN.FuncTypeId) > 2)
{
 throw new Exception("字段[函数类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.ReturnType) && GetStrLen(objWebSrvFunctionsEN.ReturnType) > 500)
{
 throw new Exception("字段[返回类型]的长度不能超过500!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.ReturnTypeFullName) && GetStrLen(objWebSrvFunctionsEN.ReturnTypeFullName) > 500)
{
 throw new Exception("字段[返回类型全名]的长度不能超过500!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.ReturnTypeId) && GetStrLen(objWebSrvFunctionsEN.ReturnTypeId) > 2)
{
 throw new Exception("字段[返回类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.SourceFunction) && GetStrLen(objWebSrvFunctionsEN.SourceFunction) > 500)
{
 throw new Exception("字段[来源函数]的长度不能超过500!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.ReturnValueDescription) && GetStrLen(objWebSrvFunctionsEN.ReturnValueDescription) > 500)
{
 throw new Exception("字段[返回值说明]的长度不能超过500!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.FuncParaLst) && GetStrLen(objWebSrvFunctionsEN.FuncParaLst) > 500)
{
 throw new Exception("字段[函数参数列表]的长度不能超过500!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.UpdDate) && GetStrLen(objWebSrvFunctionsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.UpdUser) && GetStrLen(objWebSrvFunctionsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objWebSrvFunctionsEN.Memo) && GetStrLen(objWebSrvFunctionsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objWebSrvFunctionsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsWebSrvFunctionsEN GetObjByWebSrvFunctionId(string strWebSrvFunctionId)
{
if (strWebSrvFunctionId == "") return null;
string strAction = "GetObjByWebSrvFunctionId";
clsWebSrvFunctionsEN objWebSrvFunctionsEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWebSrvFunctionId"] = strWebSrvFunctionId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objWebSrvFunctionsEN = JsonConvert.DeserializeObject<clsWebSrvFunctionsEN>(strJson);
return objWebSrvFunctionsEN;
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
public static clsWebSrvFunctionsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsWebSrvFunctionsEN objWebSrvFunctionsEN;
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
objWebSrvFunctionsEN = JsonConvert.DeserializeObject<clsWebSrvFunctionsEN>(strJson);
return objWebSrvFunctionsEN;
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
 /// <param name = "strWebSrvFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsWebSrvFunctionsEN GetObjByWebSrvFunctionIdCache(string strWebSrvFunctionId,string strWebSrvClassId)
{
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel =
from objWebSrvFunctionsEN in arrWebSrvFunctionsObjLstCache
where objWebSrvFunctionsEN.WebSrvFunctionId == strWebSrvFunctionId 
select objWebSrvFunctionsEN;
if (arrWebSrvFunctionsObjLst_Sel.Count() == 0)
{
   clsWebSrvFunctionsEN obj = clsWebSrvFunctionsWApi.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrWebSrvFunctionsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFunctionNameByWebSrvFunctionIdCache(string strWebSrvFunctionId)
{
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true) return "";
//初始化列表缓存
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel1 =
from objWebSrvFunctionsEN in arrWebSrvFunctionsObjLstCache
where objWebSrvFunctionsEN.WebSrvFunctionId == strWebSrvFunctionId 
select objWebSrvFunctionsEN;
List <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel = new List<clsWebSrvFunctionsEN>();
foreach (clsWebSrvFunctionsEN obj in arrWebSrvFunctionsObjLst_Sel1)
{
arrWebSrvFunctionsObjLst_Sel.Add(obj);
}
if (arrWebSrvFunctionsObjLst_Sel.Count > 0)
{
return arrWebSrvFunctionsObjLst_Sel[0].FunctionName;
}
string strErrMsgForGetObjById = string.Format("在WebSrvFunctions对象缓存列表中,找不到记录[WebSrvFunctionId = {0}](函数:{1})", strWebSrvFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsWebSrvFunctionsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByWebSrvFunctionIdCache(string strWebSrvFunctionId)
{
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true) return "";
//初始化列表缓存
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel1 =
from objWebSrvFunctionsEN in arrWebSrvFunctionsObjLstCache
where objWebSrvFunctionsEN.WebSrvFunctionId == strWebSrvFunctionId 
select objWebSrvFunctionsEN;
List <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel = new List<clsWebSrvFunctionsEN>();
foreach (clsWebSrvFunctionsEN obj in arrWebSrvFunctionsObjLst_Sel1)
{
arrWebSrvFunctionsObjLst_Sel.Add(obj);
}
if (arrWebSrvFunctionsObjLst_Sel.Count > 0)
{
return arrWebSrvFunctionsObjLst_Sel[0].FunctionName;
}
string strErrMsgForGetObjById = string.Format("在WebSrvFunctions对象缓存列表中,找不到记录的相关名称[WebSrvFunctionId = {0}](函数:{1})", strWebSrvFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsWebSrvFunctionsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetObjLst(string strWhereCond)
{
 List<clsWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFunctionsEN>>(strJson);
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
 /// <param name = "arrWebSrvFunctionId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetObjLstByWebSrvFunctionIdLst(List<string> arrWebSrvFunctionId)
{
 List<clsWebSrvFunctionsEN> arrObjLst; 
string strAction = "GetObjLstByWebSrvFunctionIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrWebSrvFunctionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFunctionsEN>>(strJson);
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
 /// <param name = "arrWebSrvFunctionId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsWebSrvFunctionsEN> GetObjLstByWebSrvFunctionIdLstCache(List<string> arrWebSrvFunctionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel =
from objWebSrvFunctionsEN in arrWebSrvFunctionsObjLstCache
where arrWebSrvFunctionId.Contains(objWebSrvFunctionsEN.WebSrvFunctionId)
select objWebSrvFunctionsEN;
return arrWebSrvFunctionsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFunctionsEN>>(strJson);
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
public static List<clsWebSrvFunctionsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFunctionsEN>>(strJson);
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
public static List<clsWebSrvFunctionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFunctionsEN>>(strJson);
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
public static List<clsWebSrvFunctionsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFunctionsEN>>(strJson);
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
public static int DelRecord(string strWebSrvFunctionId)
{
string strAction = "DelRecord";
try
{
 clsWebSrvFunctionsEN objWebSrvFunctionsEN = clsWebSrvFunctionsWApi.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strWebSrvFunctionId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsWebSrvFunctionsWApi.ReFreshCache();
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
public static int DelWebSrvFunctionss(List<string> arrWebSrvFunctionId)
{
string strAction = "DelWebSrvFunctionss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrWebSrvFunctionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsWebSrvFunctionsWApi.ReFreshCache();
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
public static int DelWebSrvFunctionssByCond(string strWhereCond)
{
string strAction = "DelWebSrvFunctionssByCond";
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
public static bool AddNewRecord(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWebSrvFunctionsEN>(objWebSrvFunctionsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWebSrvFunctionsEN>(objWebSrvFunctionsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsWApi.ReFreshCache();
var strWebSrvFunctionId = (string)jobjReturn0["returnStr"];
return strWebSrvFunctionId;
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
public static bool UpdateRecord(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
if (string.IsNullOrEmpty(objWebSrvFunctionsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objWebSrvFunctionsEN.WebSrvFunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWebSrvFunctionsEN>(objWebSrvFunctionsEN);
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
 /// <param name = "objWebSrvFunctionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objWebSrvFunctionsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objWebSrvFunctionsEN.WebSrvFunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objWebSrvFunctionsEN.WebSrvFunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWebSrvFunctionsEN>(objWebSrvFunctionsEN);
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
public static bool IsExist(string strWebSrvFunctionId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWebSrvFunctionId"] = strWebSrvFunctionId
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
 /// <param name = "objWebSrvFunctionsENS">源对象</param>
 /// <param name = "objWebSrvFunctionsENT">目标对象</param>
 public static void CopyTo(clsWebSrvFunctionsEN objWebSrvFunctionsENS, clsWebSrvFunctionsEN objWebSrvFunctionsENT)
{
try
{
objWebSrvFunctionsENT.WebSrvFunctionId = objWebSrvFunctionsENS.WebSrvFunctionId; //函数Id
objWebSrvFunctionsENT.WebSrvClassId = objWebSrvFunctionsENS.WebSrvClassId; //类Id
objWebSrvFunctionsENT.FunctionName = objWebSrvFunctionsENS.FunctionName; //功能名称
objWebSrvFunctionsENT.GetCustomAttributes = objWebSrvFunctionsENS.GetCustomAttributes; //GetCustomAttributes
objWebSrvFunctionsENT.FunctionSignature = objWebSrvFunctionsENS.FunctionSignature; //函数签名
objWebSrvFunctionsENT.FuncTypeId = objWebSrvFunctionsENS.FuncTypeId; //函数类型Id
objWebSrvFunctionsENT.ReturnType = objWebSrvFunctionsENS.ReturnType; //返回类型
objWebSrvFunctionsENT.ReturnTypeFullName = objWebSrvFunctionsENS.ReturnTypeFullName; //返回类型全名
objWebSrvFunctionsENT.IsKnownType = objWebSrvFunctionsENS.IsKnownType; //是否已知类型
objWebSrvFunctionsENT.ReturnTypeId = objWebSrvFunctionsENS.ReturnTypeId; //返回类型ID
objWebSrvFunctionsENT.IsAsyncFunc = objWebSrvFunctionsENS.IsAsyncFunc; //是否异步函数
objWebSrvFunctionsENT.SourceFunction = objWebSrvFunctionsENS.SourceFunction; //来源函数
objWebSrvFunctionsENT.IsGeneCode = objWebSrvFunctionsENS.IsGeneCode; //是否生成代码
objWebSrvFunctionsENT.ReturnValueDescription = objWebSrvFunctionsENS.ReturnValueDescription; //返回值说明
objWebSrvFunctionsENT.FuncParaLst = objWebSrvFunctionsENS.FuncParaLst; //函数参数列表
objWebSrvFunctionsENT.IsSysFunction = objWebSrvFunctionsENS.IsSysFunction; //是否系统函数
objWebSrvFunctionsENT.UpdDate = objWebSrvFunctionsENS.UpdDate; //修改日期
objWebSrvFunctionsENT.UpdUser = objWebSrvFunctionsENS.UpdUser; //修改者
objWebSrvFunctionsENT.Memo = objWebSrvFunctionsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsWebSrvFunctionsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsWebSrvFunctionsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsWebSrvFunctionsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsWebSrvFunctionsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsWebSrvFunctionsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsWebSrvFunctionsEN._AttributeName)
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
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
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
if (clsWebSrvFunctionsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsWebSrvFunctionsWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetObjLstCache(string strWebSrvClassId)
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsWebSrvFunctionsEN._CurrTabName;
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrWebSrvFunctionsObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsWebSrvFunctionsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conWebSrvFunctions.WebSrvFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.WebSrvClassId, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.GetCustomAttributes, Type.GetType("System.Int32"));
objDT.Columns.Add(conWebSrvFunctions.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.ReturnType, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.ReturnTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.IsKnownType, Type.GetType("System.Boolean"));
objDT.Columns.Add(conWebSrvFunctions.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.IsAsyncFunc, Type.GetType("System.Boolean"));
objDT.Columns.Add(conWebSrvFunctions.SourceFunction, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.IsGeneCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(conWebSrvFunctions.ReturnValueDescription, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.FuncParaLst, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.IsSysFunction, Type.GetType("System.Boolean"));
objDT.Columns.Add(conWebSrvFunctions.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFunctions.Memo, Type.GetType("System.String"));
foreach (clsWebSrvFunctionsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conWebSrvFunctions.WebSrvFunctionId] = objInFor[conWebSrvFunctions.WebSrvFunctionId];
objDR[conWebSrvFunctions.WebSrvClassId] = objInFor[conWebSrvFunctions.WebSrvClassId];
objDR[conWebSrvFunctions.FunctionName] = objInFor[conWebSrvFunctions.FunctionName];
objDR[conWebSrvFunctions.GetCustomAttributes] = objInFor[conWebSrvFunctions.GetCustomAttributes];
objDR[conWebSrvFunctions.FunctionSignature] = objInFor[conWebSrvFunctions.FunctionSignature];
objDR[conWebSrvFunctions.FuncTypeId] = objInFor[conWebSrvFunctions.FuncTypeId];
objDR[conWebSrvFunctions.ReturnType] = objInFor[conWebSrvFunctions.ReturnType];
objDR[conWebSrvFunctions.ReturnTypeFullName] = objInFor[conWebSrvFunctions.ReturnTypeFullName];
objDR[conWebSrvFunctions.IsKnownType] = objInFor[conWebSrvFunctions.IsKnownType];
objDR[conWebSrvFunctions.ReturnTypeId] = objInFor[conWebSrvFunctions.ReturnTypeId];
objDR[conWebSrvFunctions.IsAsyncFunc] = objInFor[conWebSrvFunctions.IsAsyncFunc];
objDR[conWebSrvFunctions.SourceFunction] = objInFor[conWebSrvFunctions.SourceFunction];
objDR[conWebSrvFunctions.IsGeneCode] = objInFor[conWebSrvFunctions.IsGeneCode];
objDR[conWebSrvFunctions.ReturnValueDescription] = objInFor[conWebSrvFunctions.ReturnValueDescription];
objDR[conWebSrvFunctions.FuncParaLst] = objInFor[conWebSrvFunctions.FuncParaLst];
objDR[conWebSrvFunctions.IsSysFunction] = objInFor[conWebSrvFunctions.IsSysFunction];
objDR[conWebSrvFunctions.UpdDate] = objInFor[conWebSrvFunctions.UpdDate];
objDR[conWebSrvFunctions.UpdUser] = objInFor[conWebSrvFunctions.UpdUser];
objDR[conWebSrvFunctions.Memo] = objInFor[conWebSrvFunctions.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// WebSrv函数(WebSrvFunctions)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4WebSrvFunctions : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strWebSrvClassId)
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
clsWebSrvFunctionsWApi.ReFreshThisCache(strWebSrvClassId);
}
}

}