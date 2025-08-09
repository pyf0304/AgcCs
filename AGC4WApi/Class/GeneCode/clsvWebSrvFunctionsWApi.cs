
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvFunctionsWApi
 表名:vWebSrvFunctions(00050343)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:02
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
public static class  clsvWebSrvFunctionsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvFunctionId">函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetWebSrvFunctionId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strWebSrvFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSrvFunctionId, 8, convWebSrvFunctions.WebSrvFunctionId);
clsCheckSql.CheckFieldForeignKey(strWebSrvFunctionId, 8, convWebSrvFunctions.WebSrvFunctionId);
objvWebSrvFunctionsEN.WebSrvFunctionId = strWebSrvFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.WebSrvFunctionId) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.WebSrvFunctionId, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.WebSrvFunctionId] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetWebSrvClassId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvClassId, convWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convWebSrvFunctions.WebSrvClassId);
objvWebSrvFunctionsEN.WebSrvClassId = strWebSrvClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.WebSrvClassId) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.WebSrvClassId, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.WebSrvClassId] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strNameSpace">域名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetNameSpace(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strNameSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convWebSrvFunctions.NameSpace);
objvWebSrvFunctionsEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.NameSpace) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.NameSpace, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.NameSpace] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvUrl">WebSrv地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetWebSrvUrl(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strWebSrvUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSrvUrl, 300, convWebSrvFunctions.WebSrvUrl);
objvWebSrvFunctionsEN.WebSrvUrl = strWebSrvUrl; //WebSrv地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.WebSrvUrl) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.WebSrvUrl, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.WebSrvUrl] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFuncModuleAgcId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convWebSrvFunctions.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convWebSrvFunctions.FuncModuleAgcId);
objvWebSrvFunctionsEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.FuncModuleAgcId) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.FuncModuleAgcId, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.FuncModuleAgcId] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetPrjId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convWebSrvFunctions.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convWebSrvFunctions.PrjId);
objvWebSrvFunctionsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.PrjId) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.PrjId, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.PrjId] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFunctionName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convWebSrvFunctions.FunctionName);
objvWebSrvFunctionsEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.FunctionName) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.FunctionName, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.FunctionName] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "intGetCustomAttributes">GetCustomAttributes</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetGetCustomAttributes(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, int intGetCustomAttributes, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intGetCustomAttributes, convWebSrvFunctions.GetCustomAttributes);
objvWebSrvFunctionsEN.GetCustomAttributes = intGetCustomAttributes; //GetCustomAttributes
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.GetCustomAttributes) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.GetCustomAttributes, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.GetCustomAttributes] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFunctionSignature(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convWebSrvFunctions.FunctionSignature);
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convWebSrvFunctions.FunctionSignature);
objvWebSrvFunctionsEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.FunctionSignature) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.FunctionSignature, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.FunctionSignature] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFuncTypeId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeId, convWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convWebSrvFunctions.FuncTypeId);
objvWebSrvFunctionsEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.FuncTypeId) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.FuncTypeId, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.FuncTypeId] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeName">函数类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFuncTypeName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeName, convWebSrvFunctions.FuncTypeName);
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convWebSrvFunctions.FuncTypeName);
objvWebSrvFunctionsEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.FuncTypeName) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.FuncTypeName, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.FuncTypeName] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnType">返回类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetReturnType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnType, convWebSrvFunctions.ReturnType);
clsCheckSql.CheckFieldLen(strReturnType, 500, convWebSrvFunctions.ReturnType);
objvWebSrvFunctionsEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.ReturnType) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.ReturnType, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.ReturnType] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeFullName">返回类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetReturnTypeFullName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strReturnTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeFullName, 500, convWebSrvFunctions.ReturnTypeFullName);
objvWebSrvFunctionsEN.ReturnTypeFullName = strReturnTypeFullName; //返回类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.ReturnTypeFullName) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.ReturnTypeFullName, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.ReturnTypeFullName] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsKnownType">是否已知类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetIsKnownType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, bool bolIsKnownType, string strComparisonOp="")
	{
objvWebSrvFunctionsEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.IsKnownType) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.IsKnownType, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.IsKnownType] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetReturnTypeId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convWebSrvFunctions.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convWebSrvFunctions.ReturnTypeId);
objvWebSrvFunctionsEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.ReturnTypeId) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.ReturnTypeId, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.ReturnTypeId] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetDataTypeName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convWebSrvFunctions.DataTypeName);
objvWebSrvFunctionsEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.DataTypeName) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.DataTypeName, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.DataTypeName] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeAbbr">数据类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetDataTypeAbbr(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strDataTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeAbbr, 5, convWebSrvFunctions.DataTypeAbbr);
objvWebSrvFunctionsEN.DataTypeAbbr = strDataTypeAbbr; //数据类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.DataTypeAbbr) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.DataTypeAbbr, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.DataTypeAbbr] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strNetSysType">NET系统类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetNetSysType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strNetSysType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNetSysType, 20, convWebSrvFunctions.NetSysType);
objvWebSrvFunctionsEN.NetSysType = strNetSysType; //NET系统类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.NetSysType) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.NetSysType, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.NetSysType] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCsType">CS类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetCsType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCsType, 100, convWebSrvFunctions.CsType);
objvWebSrvFunctionsEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.CsType) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.CsType, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.CsType] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaType">JAVA类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetJavaType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaType, 100, convWebSrvFunctions.JavaType);
objvWebSrvFunctionsEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.JavaType) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.JavaType, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.JavaType] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaObjType">JAVA对象类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetJavaObjType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strJavaObjType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convWebSrvFunctions.JavaObjType);
objvWebSrvFunctionsEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.JavaObjType) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.JavaObjType, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.JavaObjType] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSwiftType">SwiftType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetSwiftType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strSwiftType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convWebSrvFunctions.SwiftType);
objvWebSrvFunctionsEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.SwiftType) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.SwiftType, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.SwiftType] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedQuote">是否需要引号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetIsNeedQuote(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
objvWebSrvFunctionsEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.IsNeedQuote) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.IsNeedQuote, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.IsNeedQuote] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAsyncFunc">是否异步函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetIsAsyncFunc(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objvWebSrvFunctionsEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.IsAsyncFunc) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.IsAsyncFunc, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.IsAsyncFunc] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSourceFunction">来源函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetSourceFunction(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strSourceFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSourceFunction, 500, convWebSrvFunctions.SourceFunction);
objvWebSrvFunctionsEN.SourceFunction = strSourceFunction; //来源函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.SourceFunction) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.SourceFunction, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.SourceFunction] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGeneCode">是否生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetIsGeneCode(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objvWebSrvFunctionsEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.IsGeneCode) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.IsGeneCode, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.IsGeneCode] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnValueDescription">返回值说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetReturnValueDescription(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strReturnValueDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnValueDescription, 500, convWebSrvFunctions.ReturnValueDescription);
objvWebSrvFunctionsEN.ReturnValueDescription = strReturnValueDescription; //返回值说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.ReturnValueDescription) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.ReturnValueDescription, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.ReturnValueDescription] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncParaLst">函数参数列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFuncParaLst(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFuncParaLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, convWebSrvFunctions.FuncParaLst);
objvWebSrvFunctionsEN.FuncParaLst = strFuncParaLst; //函数参数列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.FuncParaLst) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.FuncParaLst, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.FuncParaLst] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetUpdDate(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWebSrvFunctions.UpdDate);
objvWebSrvFunctionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.UpdDate) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.UpdDate, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.UpdDate] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetUpdUser(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convWebSrvFunctions.UpdUser);
objvWebSrvFunctionsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.UpdUser) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.UpdUser, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.UpdUser] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetMemo(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWebSrvFunctions.Memo);
objvWebSrvFunctionsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.Memo) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.Memo, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.Memo] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetClsName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsName, 100, convWebSrvFunctions.ClsName);
objvWebSrvFunctionsEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(convWebSrvFunctions.ClsName) == false)
{
objvWebSrvFunctionsEN.dicFldComparisonOp.Add(convWebSrvFunctions.ClsName, strComparisonOp);
}
else
{
objvWebSrvFunctionsEN.dicFldComparisonOp[convWebSrvFunctions.ClsName] = strComparisonOp;
}
}
return objvWebSrvFunctionsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvWebSrvFunctionsEN objvWebSrvFunctionsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.WebSrvFunctionId) == true)
{
string strComparisonOpWebSrvFunctionId = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.WebSrvFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.WebSrvFunctionId, objvWebSrvFunctionsCond.WebSrvFunctionId, strComparisonOpWebSrvFunctionId);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.WebSrvClassId) == true)
{
string strComparisonOpWebSrvClassId = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.WebSrvClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.WebSrvClassId, objvWebSrvFunctionsCond.WebSrvClassId, strComparisonOpWebSrvClassId);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.NameSpace) == true)
{
string strComparisonOpNameSpace = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.NameSpace, objvWebSrvFunctionsCond.NameSpace, strComparisonOpNameSpace);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.WebSrvUrl) == true)
{
string strComparisonOpWebSrvUrl = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.WebSrvUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.WebSrvUrl, objvWebSrvFunctionsCond.WebSrvUrl, strComparisonOpWebSrvUrl);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.FuncModuleAgcId, objvWebSrvFunctionsCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.PrjId) == true)
{
string strComparisonOpPrjId = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.PrjId, objvWebSrvFunctionsCond.PrjId, strComparisonOpPrjId);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.FunctionName) == true)
{
string strComparisonOpFunctionName = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.FunctionName, objvWebSrvFunctionsCond.FunctionName, strComparisonOpFunctionName);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.GetCustomAttributes) == true)
{
string strComparisonOpGetCustomAttributes = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.GetCustomAttributes];
strWhereCond += string.Format(" And {0} {2} {1}", convWebSrvFunctions.GetCustomAttributes, objvWebSrvFunctionsCond.GetCustomAttributes, strComparisonOpGetCustomAttributes);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.FunctionSignature, objvWebSrvFunctionsCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.FuncTypeId, objvWebSrvFunctionsCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.FuncTypeName, objvWebSrvFunctionsCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.ReturnType) == true)
{
string strComparisonOpReturnType = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.ReturnType, objvWebSrvFunctionsCond.ReturnType, strComparisonOpReturnType);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.ReturnTypeFullName) == true)
{
string strComparisonOpReturnTypeFullName = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.ReturnTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.ReturnTypeFullName, objvWebSrvFunctionsCond.ReturnTypeFullName, strComparisonOpReturnTypeFullName);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.IsKnownType) == true)
{
if (objvWebSrvFunctionsCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvFunctions.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvFunctions.IsKnownType);
}
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.ReturnTypeId, objvWebSrvFunctionsCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.DataTypeName, objvWebSrvFunctionsCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.DataTypeAbbr) == true)
{
string strComparisonOpDataTypeAbbr = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.DataTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.DataTypeAbbr, objvWebSrvFunctionsCond.DataTypeAbbr, strComparisonOpDataTypeAbbr);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.NetSysType) == true)
{
string strComparisonOpNetSysType = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.NetSysType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.NetSysType, objvWebSrvFunctionsCond.NetSysType, strComparisonOpNetSysType);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.CsType) == true)
{
string strComparisonOpCsType = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.CsType, objvWebSrvFunctionsCond.CsType, strComparisonOpCsType);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.JavaType) == true)
{
string strComparisonOpJavaType = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.JavaType, objvWebSrvFunctionsCond.JavaType, strComparisonOpJavaType);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.JavaObjType, objvWebSrvFunctionsCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.SwiftType) == true)
{
string strComparisonOpSwiftType = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.SwiftType, objvWebSrvFunctionsCond.SwiftType, strComparisonOpSwiftType);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.IsNeedQuote) == true)
{
if (objvWebSrvFunctionsCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvFunctions.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvFunctions.IsNeedQuote);
}
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.IsAsyncFunc) == true)
{
if (objvWebSrvFunctionsCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvFunctions.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvFunctions.IsAsyncFunc);
}
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.SourceFunction) == true)
{
string strComparisonOpSourceFunction = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.SourceFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.SourceFunction, objvWebSrvFunctionsCond.SourceFunction, strComparisonOpSourceFunction);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.IsGeneCode) == true)
{
if (objvWebSrvFunctionsCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvFunctions.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvFunctions.IsGeneCode);
}
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.ReturnValueDescription) == true)
{
string strComparisonOpReturnValueDescription = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.ReturnValueDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.ReturnValueDescription, objvWebSrvFunctionsCond.ReturnValueDescription, strComparisonOpReturnValueDescription);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.FuncParaLst) == true)
{
string strComparisonOpFuncParaLst = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.FuncParaLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.FuncParaLst, objvWebSrvFunctionsCond.FuncParaLst, strComparisonOpFuncParaLst);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.UpdDate) == true)
{
string strComparisonOpUpdDate = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.UpdDate, objvWebSrvFunctionsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.UpdUser) == true)
{
string strComparisonOpUpdUser = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.UpdUser, objvWebSrvFunctionsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.Memo) == true)
{
string strComparisonOpMemo = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.Memo, objvWebSrvFunctionsCond.Memo, strComparisonOpMemo);
}
if (objvWebSrvFunctionsCond.IsUpdated(convWebSrvFunctions.ClsName) == true)
{
string strComparisonOpClsName = objvWebSrvFunctionsCond.dicFldComparisonOp[convWebSrvFunctions.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFunctions.ClsName, objvWebSrvFunctionsCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vWebSrv函数(vWebSrvFunctions)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvWebSrvFunctionsWApi
{
private static readonly string mstrApiControllerName = "vWebSrvFunctionsApi";

 public clsvWebSrvFunctionsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvFunctionsEN GetObjByWebSrvFunctionId(string strWebSrvFunctionId)
{
if (strWebSrvFunctionId == "") return null;
string strAction = "GetObjByWebSrvFunctionId";
clsvWebSrvFunctionsEN objvWebSrvFunctionsEN;
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
objvWebSrvFunctionsEN = JsonConvert.DeserializeObject<clsvWebSrvFunctionsEN>(strJson);
return objvWebSrvFunctionsEN;
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
public static clsvWebSrvFunctionsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvWebSrvFunctionsEN objvWebSrvFunctionsEN;
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
objvWebSrvFunctionsEN = JsonConvert.DeserializeObject<clsvWebSrvFunctionsEN>(strJson);
return objvWebSrvFunctionsEN;
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
public static clsvWebSrvFunctionsEN GetObjByWebSrvFunctionIdCache(string strWebSrvFunctionId)
{
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvWebSrvFunctionsEN._CurrTabName);
List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLst_Sel =
from objvWebSrvFunctionsEN in arrvWebSrvFunctionsObjLstCache
where objvWebSrvFunctionsEN.WebSrvFunctionId == strWebSrvFunctionId 
select objvWebSrvFunctionsEN;
if (arrvWebSrvFunctionsObjLst_Sel.Count() == 0)
{
   clsvWebSrvFunctionsEN obj = clsvWebSrvFunctionsWApi.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvWebSrvFunctionsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLst(string strWhereCond)
{
 List<clsvWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFunctionsEN>>(strJson);
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
public static List<clsvWebSrvFunctionsEN> GetObjLstByWebSrvFunctionIdLst(List<string> arrWebSrvFunctionId)
{
 List<clsvWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFunctionsEN>>(strJson);
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
public static IEnumerable<clsvWebSrvFunctionsEN> GetObjLstByWebSrvFunctionIdLstCache(List<string> arrWebSrvFunctionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWebSrvFunctionsEN._CurrTabName);
List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLst_Sel =
from objvWebSrvFunctionsEN in arrvWebSrvFunctionsObjLstCache
where arrWebSrvFunctionId.Contains(objvWebSrvFunctionsEN.WebSrvFunctionId)
select objvWebSrvFunctionsEN;
return arrvWebSrvFunctionsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFunctionsEN>>(strJson);
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
public static List<clsvWebSrvFunctionsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFunctionsEN>>(strJson);
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
public static List<clsvWebSrvFunctionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFunctionsEN>>(strJson);
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
public static List<clsvWebSrvFunctionsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvWebSrvFunctionsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFunctionsEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsENS">源对象</param>
 /// <param name = "objvWebSrvFunctionsENT">目标对象</param>
 public static void CopyTo(clsvWebSrvFunctionsEN objvWebSrvFunctionsENS, clsvWebSrvFunctionsEN objvWebSrvFunctionsENT)
{
try
{
objvWebSrvFunctionsENT.WebSrvFunctionId = objvWebSrvFunctionsENS.WebSrvFunctionId; //函数Id
objvWebSrvFunctionsENT.WebSrvClassId = objvWebSrvFunctionsENS.WebSrvClassId; //类Id
objvWebSrvFunctionsENT.NameSpace = objvWebSrvFunctionsENS.NameSpace; //域名
objvWebSrvFunctionsENT.WebSrvUrl = objvWebSrvFunctionsENS.WebSrvUrl; //WebSrv地址
objvWebSrvFunctionsENT.FuncModuleAgcId = objvWebSrvFunctionsENS.FuncModuleAgcId; //功能模块Id
objvWebSrvFunctionsENT.PrjId = objvWebSrvFunctionsENS.PrjId; //工程Id
objvWebSrvFunctionsENT.FunctionName = objvWebSrvFunctionsENS.FunctionName; //功能名称
objvWebSrvFunctionsENT.GetCustomAttributes = objvWebSrvFunctionsENS.GetCustomAttributes; //GetCustomAttributes
objvWebSrvFunctionsENT.FunctionSignature = objvWebSrvFunctionsENS.FunctionSignature; //函数签名
objvWebSrvFunctionsENT.FuncTypeId = objvWebSrvFunctionsENS.FuncTypeId; //函数类型Id
objvWebSrvFunctionsENT.FuncTypeName = objvWebSrvFunctionsENS.FuncTypeName; //函数类型名
objvWebSrvFunctionsENT.ReturnType = objvWebSrvFunctionsENS.ReturnType; //返回类型
objvWebSrvFunctionsENT.ReturnTypeFullName = objvWebSrvFunctionsENS.ReturnTypeFullName; //返回类型全名
objvWebSrvFunctionsENT.IsKnownType = objvWebSrvFunctionsENS.IsKnownType; //是否已知类型
objvWebSrvFunctionsENT.ReturnTypeId = objvWebSrvFunctionsENS.ReturnTypeId; //返回类型ID
objvWebSrvFunctionsENT.DataTypeName = objvWebSrvFunctionsENS.DataTypeName; //数据类型名称
objvWebSrvFunctionsENT.DataTypeAbbr = objvWebSrvFunctionsENS.DataTypeAbbr; //数据类型缩写
objvWebSrvFunctionsENT.NetSysType = objvWebSrvFunctionsENS.NetSysType; //NET系统类型
objvWebSrvFunctionsENT.CsType = objvWebSrvFunctionsENS.CsType; //CS类型
objvWebSrvFunctionsENT.JavaType = objvWebSrvFunctionsENS.JavaType; //JAVA类型
objvWebSrvFunctionsENT.JavaObjType = objvWebSrvFunctionsENS.JavaObjType; //JAVA对象类型
objvWebSrvFunctionsENT.SwiftType = objvWebSrvFunctionsENS.SwiftType; //SwiftType
objvWebSrvFunctionsENT.IsNeedQuote = objvWebSrvFunctionsENS.IsNeedQuote; //是否需要引号
objvWebSrvFunctionsENT.IsAsyncFunc = objvWebSrvFunctionsENS.IsAsyncFunc; //是否异步函数
objvWebSrvFunctionsENT.SourceFunction = objvWebSrvFunctionsENS.SourceFunction; //来源函数
objvWebSrvFunctionsENT.IsGeneCode = objvWebSrvFunctionsENS.IsGeneCode; //是否生成代码
objvWebSrvFunctionsENT.ReturnValueDescription = objvWebSrvFunctionsENS.ReturnValueDescription; //返回值说明
objvWebSrvFunctionsENT.FuncParaLst = objvWebSrvFunctionsENS.FuncParaLst; //函数参数列表
objvWebSrvFunctionsENT.UpdDate = objvWebSrvFunctionsENS.UpdDate; //修改日期
objvWebSrvFunctionsENT.UpdUser = objvWebSrvFunctionsENS.UpdUser; //修改者
objvWebSrvFunctionsENT.Memo = objvWebSrvFunctionsENS.Memo; //说明
objvWebSrvFunctionsENT.ClsName = objvWebSrvFunctionsENS.ClsName; //类名
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
public static DataTable ToDataTable(List<clsvWebSrvFunctionsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvWebSrvFunctionsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvWebSrvFunctionsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvWebSrvFunctionsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvWebSrvFunctionsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvWebSrvFunctionsEN._AttributeName)
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
string strKey = string.Format("{0}", clsvWebSrvFunctionsEN._CurrTabName);
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
public static List<clsvWebSrvFunctionsEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvWebSrvFunctionsEN._CurrTabName;
List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvWebSrvFunctionsObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvWebSrvFunctionsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convWebSrvFunctions.WebSrvFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.WebSrvClassId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.NameSpace, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.WebSrvUrl, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.GetCustomAttributes, Type.GetType("System.Int32"));
objDT.Columns.Add(convWebSrvFunctions.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.FuncTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.ReturnType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.ReturnTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.IsKnownType, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvFunctions.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.DataTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.NetSysType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.CsType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.JavaType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.JavaObjType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.SwiftType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.IsNeedQuote, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvFunctions.IsAsyncFunc, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvFunctions.SourceFunction, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.IsGeneCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvFunctions.ReturnValueDescription, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.FuncParaLst, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFunctions.ClsName, Type.GetType("System.String"));
foreach (clsvWebSrvFunctionsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convWebSrvFunctions.WebSrvFunctionId] = objInFor[convWebSrvFunctions.WebSrvFunctionId];
objDR[convWebSrvFunctions.WebSrvClassId] = objInFor[convWebSrvFunctions.WebSrvClassId];
objDR[convWebSrvFunctions.NameSpace] = objInFor[convWebSrvFunctions.NameSpace];
objDR[convWebSrvFunctions.WebSrvUrl] = objInFor[convWebSrvFunctions.WebSrvUrl];
objDR[convWebSrvFunctions.FuncModuleAgcId] = objInFor[convWebSrvFunctions.FuncModuleAgcId];
objDR[convWebSrvFunctions.PrjId] = objInFor[convWebSrvFunctions.PrjId];
objDR[convWebSrvFunctions.FunctionName] = objInFor[convWebSrvFunctions.FunctionName];
objDR[convWebSrvFunctions.GetCustomAttributes] = objInFor[convWebSrvFunctions.GetCustomAttributes];
objDR[convWebSrvFunctions.FunctionSignature] = objInFor[convWebSrvFunctions.FunctionSignature];
objDR[convWebSrvFunctions.FuncTypeId] = objInFor[convWebSrvFunctions.FuncTypeId];
objDR[convWebSrvFunctions.FuncTypeName] = objInFor[convWebSrvFunctions.FuncTypeName];
objDR[convWebSrvFunctions.ReturnType] = objInFor[convWebSrvFunctions.ReturnType];
objDR[convWebSrvFunctions.ReturnTypeFullName] = objInFor[convWebSrvFunctions.ReturnTypeFullName];
objDR[convWebSrvFunctions.IsKnownType] = objInFor[convWebSrvFunctions.IsKnownType];
objDR[convWebSrvFunctions.ReturnTypeId] = objInFor[convWebSrvFunctions.ReturnTypeId];
objDR[convWebSrvFunctions.DataTypeName] = objInFor[convWebSrvFunctions.DataTypeName];
objDR[convWebSrvFunctions.DataTypeAbbr] = objInFor[convWebSrvFunctions.DataTypeAbbr];
objDR[convWebSrvFunctions.NetSysType] = objInFor[convWebSrvFunctions.NetSysType];
objDR[convWebSrvFunctions.CsType] = objInFor[convWebSrvFunctions.CsType];
objDR[convWebSrvFunctions.JavaType] = objInFor[convWebSrvFunctions.JavaType];
objDR[convWebSrvFunctions.JavaObjType] = objInFor[convWebSrvFunctions.JavaObjType];
objDR[convWebSrvFunctions.SwiftType] = objInFor[convWebSrvFunctions.SwiftType];
objDR[convWebSrvFunctions.IsNeedQuote] = objInFor[convWebSrvFunctions.IsNeedQuote];
objDR[convWebSrvFunctions.IsAsyncFunc] = objInFor[convWebSrvFunctions.IsAsyncFunc];
objDR[convWebSrvFunctions.SourceFunction] = objInFor[convWebSrvFunctions.SourceFunction];
objDR[convWebSrvFunctions.IsGeneCode] = objInFor[convWebSrvFunctions.IsGeneCode];
objDR[convWebSrvFunctions.ReturnValueDescription] = objInFor[convWebSrvFunctions.ReturnValueDescription];
objDR[convWebSrvFunctions.FuncParaLst] = objInFor[convWebSrvFunctions.FuncParaLst];
objDR[convWebSrvFunctions.UpdDate] = objInFor[convWebSrvFunctions.UpdDate];
objDR[convWebSrvFunctions.UpdUser] = objInFor[convWebSrvFunctions.UpdUser];
objDR[convWebSrvFunctions.Memo] = objInFor[convWebSrvFunctions.Memo];
objDR[convWebSrvFunctions.ClsName] = objInFor[convWebSrvFunctions.ClsName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}