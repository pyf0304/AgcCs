
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunction4CodeWApi
 表名:Function4Code(00050386)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsFunction4CodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncId4Code(this clsFunction4CodeEN objFunction4CodeEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, conFunction4Code.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, conFunction4Code.FuncId4Code);
objFunction4CodeEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncId4Code) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncId4Code, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncId4Code] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4Code">函数名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncName4Code(this clsFunction4CodeEN objFunction4CodeEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, conFunction4Code.FuncName4Code);
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, conFunction4Code.FuncName4Code);
objFunction4CodeEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncName4Code) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncName4Code, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncName4Code] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCHName4Code">函数中文名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncCHName4Code(this clsFunction4CodeEN objFunction4CodeEN, string strFuncCHName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, conFunction4Code.FuncCHName4Code);
objFunction4CodeEN.FuncCHName4Code = strFuncCHName4Code; //函数中文名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncCHName4Code) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncCHName4Code, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncCHName4Code] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrevFuncId">前函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetPrevFuncId(this clsFunction4CodeEN objFunction4CodeEN, string strPrevFuncId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrevFuncId, 8, conFunction4Code.PrevFuncId);
clsCheckSql.CheckFieldForeignKey(strPrevFuncId, 8, conFunction4Code.PrevFuncId);
objFunction4CodeEN.PrevFuncId = strPrevFuncId; //前函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.PrevFuncId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.PrevFuncId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.PrevFuncId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strRootFuncId">根函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetRootFuncId(this clsFunction4CodeEN objFunction4CodeEN, string strRootFuncId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRootFuncId, conFunction4Code.RootFuncId);
clsCheckSql.CheckFieldLen(strRootFuncId, 8, conFunction4Code.RootFuncId);
clsCheckSql.CheckFieldForeignKey(strRootFuncId, 8, conFunction4Code.RootFuncId);
objFunction4CodeEN.RootFuncId = strRootFuncId; //根函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.RootFuncId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.RootFuncId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.RootFuncId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetApplicationTypeId(this clsFunction4CodeEN objFunction4CodeEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conFunction4Code.ApplicationTypeId);
objFunction4CodeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ApplicationTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ApplicationTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ApplicationTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeId">函数生成代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncGCTypeId(this clsFunction4CodeEN objFunction4CodeEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, conFunction4Code.FuncGCTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, conFunction4Code.FuncGCTypeId);
objFunction4CodeEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncGCTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncGCTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncGCTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFunctionSignature(this clsFunction4CodeEN objFunction4CodeEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, conFunction4Code.FunctionSignature);
objFunction4CodeEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FunctionSignature) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FunctionSignature, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FunctionSignature] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignatureSim">函数签名_Sim</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFunctionSignatureSim(this clsFunction4CodeEN objFunction4CodeEN, string strFunctionSignatureSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionSignatureSim, 500, conFunction4Code.FunctionSignatureSim);
objFunction4CodeEN.FunctionSignatureSim = strFunctionSignatureSim; //函数签名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FunctionSignatureSim) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FunctionSignatureSim, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FunctionSignatureSim] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnType">返回类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetReturnType(this clsFunction4CodeEN objFunction4CodeEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnType, 500, conFunction4Code.ReturnType);
objFunction4CodeEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ReturnType) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ReturnType, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ReturnType] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetClsName(this clsFunction4CodeEN objFunction4CodeEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsName, 100, conFunction4Code.ClsName);
objFunction4CodeEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ClsName) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ClsName, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ClsName] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeFullName">返回类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetReturnTypeFullName(this clsFunction4CodeEN objFunction4CodeEN, string strReturnTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeFullName, 500, conFunction4Code.ReturnTypeFullName);
objFunction4CodeEN.ReturnTypeFullName = strReturnTypeFullName; //返回类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ReturnTypeFullName) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ReturnTypeFullName, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ReturnTypeFullName] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetReturnTypeId(this clsFunction4CodeEN objFunction4CodeEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, conFunction4Code.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, conFunction4Code.ReturnTypeId);
objFunction4CodeEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ReturnTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ReturnTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ReturnTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeNameCustom">定制返回类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetReturnTypeNameCustom(this clsFunction4CodeEN objFunction4CodeEN, string strReturnTypeNameCustom, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeNameCustom, 50, conFunction4Code.ReturnTypeNameCustom);
objFunction4CodeEN.ReturnTypeNameCustom = strReturnTypeNameCustom; //定制返回类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ReturnTypeNameCustom) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ReturnTypeNameCustom, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ReturnTypeNameCustom] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetCodeTypeId(this clsFunction4CodeEN objFunction4CodeEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conFunction4Code.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conFunction4Code.CodeTypeId);
objFunction4CodeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.CodeTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.CodeTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.CodeTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncAccessModeId">函数操作模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncAccessModeId(this clsFunction4CodeEN objFunction4CodeEN, string strFuncAccessModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncAccessModeId, 2, conFunction4Code.FuncAccessModeId);
clsCheckSql.CheckFieldForeignKey(strFuncAccessModeId, 2, conFunction4Code.FuncAccessModeId);
objFunction4CodeEN.FuncAccessModeId = strFuncAccessModeId; //函数操作模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncAccessModeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncAccessModeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncAccessModeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetTabName(this clsFunction4CodeEN objFunction4CodeEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 100, conFunction4Code.TabName);
objFunction4CodeEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.TabName) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.TabName, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.TabName] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetTabId(this clsFunction4CodeEN objFunction4CodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, conFunction4Code.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conFunction4Code.TabId);
objFunction4CodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.TabId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.TabId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.TabId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncPurposeId">函数用途Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncPurposeId(this clsFunction4CodeEN objFunction4CodeEN, string strFuncPurposeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncPurposeId, conFunction4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(strFuncPurposeId, 2, conFunction4Code.FuncPurposeId);
clsCheckSql.CheckFieldForeignKey(strFuncPurposeId, 2, conFunction4Code.FuncPurposeId);
objFunction4CodeEN.FuncPurposeId = strFuncPurposeId; //函数用途Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncPurposeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncPurposeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncPurposeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncTypeId(this clsFunction4CodeEN objFunction4CodeEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conFunction4Code.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conFunction4Code.FuncTypeId);
objFunction4CodeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intGetCustomAttributes">GetCustomAttributes</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetGetCustomAttributes(this clsFunction4CodeEN objFunction4CodeEN, int intGetCustomAttributes, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intGetCustomAttributes, conFunction4Code.GetCustomAttributes);
objFunction4CodeEN.GetCustomAttributes = intGetCustomAttributes; //GetCustomAttributes
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.GetCustomAttributes) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.GetCustomAttributes, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.GetCustomAttributes] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSourceFunction">来源函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetSourceFunction(this clsFunction4CodeEN objFunction4CodeEN, string strSourceFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSourceFunction, 500, conFunction4Code.SourceFunction);
objFunction4CodeEN.SourceFunction = strSourceFunction; //来源函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.SourceFunction) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.SourceFunction, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.SourceFunction] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAsyncFunc">是否异步函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetIsAsyncFunc(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objFunction4CodeEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.IsAsyncFunc) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.IsAsyncFunc, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.IsAsyncFunc] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSysFunction">是否系统函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetIsSysFunction(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objFunction4CodeEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.IsSysFunction) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.IsSysFunction, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.IsSysFunction] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetOrderNum(this clsFunction4CodeEN objFunction4CodeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conFunction4Code.OrderNum);
objFunction4CodeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.OrderNum) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.OrderNum, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.OrderNum] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetPrjId(this clsFunction4CodeEN objFunction4CodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFunction4Code.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFunction4Code.PrjId);
objFunction4CodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.PrjId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.PrjId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.PrjId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetIsTemplate(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsTemplate, string strComparisonOp="")
	{
objFunction4CodeEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.IsTemplate) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.IsTemplate, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.IsTemplate] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetUpdDate(this clsFunction4CodeEN objFunction4CodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunction4Code.UpdDate);
objFunction4CodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.UpdDate) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.UpdDate, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.UpdDate] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetUpdUser(this clsFunction4CodeEN objFunction4CodeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunction4Code.UpdUser);
objFunction4CodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.UpdUser) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.UpdUser, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.UpdUser] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetMemo(this clsFunction4CodeEN objFunction4CodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunction4Code.Memo);
objFunction4CodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.Memo) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.Memo, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.Memo] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intUsedTimes">使用次数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetUsedTimes(this clsFunction4CodeEN objFunction4CodeEN, int intUsedTimes, string strComparisonOp="")
	{
objFunction4CodeEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.UsedTimes) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.UsedTimes, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.UsedTimes] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunction4CodeEN objFunction4CodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncId4Code, objFunction4CodeCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncName4Code, objFunction4CodeCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncCHName4Code) == true)
{
string strComparisonOpFuncCHName4Code = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncCHName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncCHName4Code, objFunction4CodeCond.FuncCHName4Code, strComparisonOpFuncCHName4Code);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.PrevFuncId) == true)
{
string strComparisonOpPrevFuncId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.PrevFuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.PrevFuncId, objFunction4CodeCond.PrevFuncId, strComparisonOpPrevFuncId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.RootFuncId) == true)
{
string strComparisonOpRootFuncId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.RootFuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.RootFuncId, objFunction4CodeCond.RootFuncId, strComparisonOpRootFuncId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4Code.ApplicationTypeId, objFunction4CodeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncGCTypeId, objFunction4CodeCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FunctionSignature, objFunction4CodeCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FunctionSignatureSim) == true)
{
string strComparisonOpFunctionSignatureSim = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FunctionSignatureSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FunctionSignatureSim, objFunction4CodeCond.FunctionSignatureSim, strComparisonOpFunctionSignatureSim);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ReturnType) == true)
{
string strComparisonOpReturnType = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ReturnType, objFunction4CodeCond.ReturnType, strComparisonOpReturnType);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ClsName) == true)
{
string strComparisonOpClsName = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ClsName, objFunction4CodeCond.ClsName, strComparisonOpClsName);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ReturnTypeFullName) == true)
{
string strComparisonOpReturnTypeFullName = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ReturnTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ReturnTypeFullName, objFunction4CodeCond.ReturnTypeFullName, strComparisonOpReturnTypeFullName);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ReturnTypeId, objFunction4CodeCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ReturnTypeNameCustom) == true)
{
string strComparisonOpReturnTypeNameCustom = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ReturnTypeNameCustom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ReturnTypeNameCustom, objFunction4CodeCond.ReturnTypeNameCustom, strComparisonOpReturnTypeNameCustom);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.CodeTypeId, objFunction4CodeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncAccessModeId) == true)
{
string strComparisonOpFuncAccessModeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncAccessModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncAccessModeId, objFunction4CodeCond.FuncAccessModeId, strComparisonOpFuncAccessModeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.TabName) == true)
{
string strComparisonOpTabName = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.TabName, objFunction4CodeCond.TabName, strComparisonOpTabName);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.TabId) == true)
{
string strComparisonOpTabId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.TabId, objFunction4CodeCond.TabId, strComparisonOpTabId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncPurposeId) == true)
{
string strComparisonOpFuncPurposeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncPurposeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncPurposeId, objFunction4CodeCond.FuncPurposeId, strComparisonOpFuncPurposeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncTypeId, objFunction4CodeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.GetCustomAttributes) == true)
{
string strComparisonOpGetCustomAttributes = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.GetCustomAttributes];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4Code.GetCustomAttributes, objFunction4CodeCond.GetCustomAttributes, strComparisonOpGetCustomAttributes);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.SourceFunction) == true)
{
string strComparisonOpSourceFunction = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.SourceFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.SourceFunction, objFunction4CodeCond.SourceFunction, strComparisonOpSourceFunction);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.IsAsyncFunc) == true)
{
if (objFunction4CodeCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4Code.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4Code.IsAsyncFunc);
}
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.IsSysFunction) == true)
{
if (objFunction4CodeCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4Code.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4Code.IsSysFunction);
}
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.OrderNum) == true)
{
string strComparisonOpOrderNum = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4Code.OrderNum, objFunction4CodeCond.OrderNum, strComparisonOpOrderNum);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.PrjId) == true)
{
string strComparisonOpPrjId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.PrjId, objFunction4CodeCond.PrjId, strComparisonOpPrjId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.IsTemplate) == true)
{
if (objFunction4CodeCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4Code.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4Code.IsTemplate);
}
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.UpdDate, objFunction4CodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.UpdUser, objFunction4CodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.Memo) == true)
{
string strComparisonOpMemo = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.Memo, objFunction4CodeCond.Memo, strComparisonOpMemo);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4Code.UsedTimes, objFunction4CodeCond.UsedTimes, strComparisonOpUsedTimes);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunction4CodeEN objFunction4CodeEN)
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFunction4CodeEN.sfUpdFldSetStr = objFunction4CodeEN.getsfUpdFldSetStr();
clsFunction4CodeWApi.CheckPropertyNew(objFunction4CodeEN); 
bool bolResult = clsFunction4CodeWApi.UpdateRecord(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--Function4Code(函数4Code), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncName4Code_ClsName_FuncPurposeId_PrjId_CodeTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunction4CodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFunction4CodeEN objFunction4CodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunction4CodeEN == null) return "";
if (objFunction4CodeEN.FuncId4Code == null || objFunction4CodeEN.FuncId4Code == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName4Code = '{0}'", objFunction4CodeEN.FuncName4Code);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objFunction4CodeEN.ClsName);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFunction4CodeEN.FuncPurposeId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFunction4CodeEN.PrjId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunction4CodeEN.CodeTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncId4Code !=  '{0}'", objFunction4CodeEN.FuncId4Code);
 sbCondition.AppendFormat(" and FuncName4Code = '{0}'", objFunction4CodeEN.FuncName4Code);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objFunction4CodeEN.ClsName);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFunction4CodeEN.FuncPurposeId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFunction4CodeEN.PrjId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunction4CodeEN.CodeTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunction4CodeEN objFunction4CodeEN)
{
try
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true || clsFunction4CodeWApi.IsExist(objFunction4CodeEN.FuncId4Code) == true)
 {
     objFunction4CodeEN.FuncId4Code = clsFunction4CodeWApi.GetMaxStrId();
 }
clsFunction4CodeWApi.CheckPropertyNew(objFunction4CodeEN); 
bool bolResult = clsFunction4CodeWApi.AddNewRecord(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeWApi.ReFreshCache();
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
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunction4CodeEN objFunction4CodeEN)
{
try
{
clsFunction4CodeWApi.CheckPropertyNew(objFunction4CodeEN); 
string strFuncId4Code = clsFunction4CodeWApi.AddNewRecordWithMaxId(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeWApi.ReFreshCache();
return strFuncId4Code;
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
 /// <param name = "objFunction4CodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunction4CodeEN objFunction4CodeEN, string strWhereCond)
{
try
{
clsFunction4CodeWApi.CheckPropertyNew(objFunction4CodeEN); 
bool bolResult = clsFunction4CodeWApi.UpdateWithCondition(objFunction4CodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeWApi.ReFreshCache();
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
 /// 函数4Code(Function4Code)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFunction4CodeWApi
{
private static readonly string mstrApiControllerName = "Function4CodeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFunction4CodeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncId4Code(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数4Code]...","0");
List<clsFunction4CodeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncId4Code";
objDDL.DataTextField="FuncName4Code";
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

 /// <param name = "strFuncPurposeId"></param>
public static void BindCbo_FuncId4Code(System.Windows.Forms.ComboBox objComboBox , string strFuncPurposeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFunction4Code.FuncId4Code); 
List<clsFunction4CodeEN> arrObjLst = clsFunction4CodeWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncPurposeId == strFuncPurposeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN()
{
FuncId4Code = "0",
FuncName4Code = "选[函数4Code]..."
};
arrObjLstSel.Insert(0, objFunction4CodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFunction4Code.FuncId4Code;
objComboBox.DisplayMember = conFunction4Code.FuncName4Code;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFunction4CodeEN objFunction4CodeEN)
{
if (!Object.Equals(null, objFunction4CodeEN.FuncId4Code) && GetStrLen(objFunction4CodeEN.FuncId4Code) > 8)
{
 throw new Exception("字段[函数Id4Code]的长度不能超过8!");
}
if (!Object.Equals(null, objFunction4CodeEN.FuncName4Code) && GetStrLen(objFunction4CodeEN.FuncName4Code) > 100)
{
 throw new Exception("字段[函数名4Code]的长度不能超过100!");
}
if (!Object.Equals(null, objFunction4CodeEN.FuncCHName4Code) && GetStrLen(objFunction4CodeEN.FuncCHName4Code) > 200)
{
 throw new Exception("字段[函数中文名4Code]的长度不能超过200!");
}
if (!Object.Equals(null, objFunction4CodeEN.PrevFuncId) && GetStrLen(objFunction4CodeEN.PrevFuncId) > 8)
{
 throw new Exception("字段[前函数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFunction4CodeEN.RootFuncId) && GetStrLen(objFunction4CodeEN.RootFuncId) > 8)
{
 throw new Exception("字段[根函数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFunction4CodeEN.FuncGCTypeId) && GetStrLen(objFunction4CodeEN.FuncGCTypeId) > 2)
{
 throw new Exception("字段[函数生成代码类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4CodeEN.FunctionSignature) && GetStrLen(objFunction4CodeEN.FunctionSignature) > 500)
{
 throw new Exception("字段[函数签名]的长度不能超过500!");
}
if (!Object.Equals(null, objFunction4CodeEN.FunctionSignatureSim) && GetStrLen(objFunction4CodeEN.FunctionSignatureSim) > 500)
{
 throw new Exception("字段[函数签名_Sim]的长度不能超过500!");
}
if (!Object.Equals(null, objFunction4CodeEN.ReturnType) && GetStrLen(objFunction4CodeEN.ReturnType) > 500)
{
 throw new Exception("字段[返回类型]的长度不能超过500!");
}
if (!Object.Equals(null, objFunction4CodeEN.ClsName) && GetStrLen(objFunction4CodeEN.ClsName) > 100)
{
 throw new Exception("字段[类名]的长度不能超过100!");
}
if (!Object.Equals(null, objFunction4CodeEN.ReturnTypeFullName) && GetStrLen(objFunction4CodeEN.ReturnTypeFullName) > 500)
{
 throw new Exception("字段[返回类型全名]的长度不能超过500!");
}
if (!Object.Equals(null, objFunction4CodeEN.ReturnTypeId) && GetStrLen(objFunction4CodeEN.ReturnTypeId) > 2)
{
 throw new Exception("字段[返回类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4CodeEN.ReturnTypeNameCustom) && GetStrLen(objFunction4CodeEN.ReturnTypeNameCustom) > 50)
{
 throw new Exception("字段[定制返回类型名]的长度不能超过50!");
}
if (!Object.Equals(null, objFunction4CodeEN.CodeTypeId) && GetStrLen(objFunction4CodeEN.CodeTypeId) > 4)
{
 throw new Exception("字段[代码类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFunction4CodeEN.FuncAccessModeId) && GetStrLen(objFunction4CodeEN.FuncAccessModeId) > 2)
{
 throw new Exception("字段[函数操作模式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4CodeEN.TabName) && GetStrLen(objFunction4CodeEN.TabName) > 100)
{
 throw new Exception("字段[表名]的长度不能超过100!");
}
if (!Object.Equals(null, objFunction4CodeEN.TabId) && GetStrLen(objFunction4CodeEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objFunction4CodeEN.FuncPurposeId) && GetStrLen(objFunction4CodeEN.FuncPurposeId) > 2)
{
 throw new Exception("字段[函数用途Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4CodeEN.FuncTypeId) && GetStrLen(objFunction4CodeEN.FuncTypeId) > 2)
{
 throw new Exception("字段[函数类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4CodeEN.SourceFunction) && GetStrLen(objFunction4CodeEN.SourceFunction) > 500)
{
 throw new Exception("字段[来源函数]的长度不能超过500!");
}
if (!Object.Equals(null, objFunction4CodeEN.PrjId) && GetStrLen(objFunction4CodeEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFunction4CodeEN.UpdDate) && GetStrLen(objFunction4CodeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFunction4CodeEN.UpdUser) && GetStrLen(objFunction4CodeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFunction4CodeEN.Memo) && GetStrLen(objFunction4CodeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFunction4CodeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunction4CodeEN GetObjByFuncId4Code(string strFuncId4Code)
{
if (strFuncId4Code == "") return null;
string strAction = "GetObjByFuncId4Code";
clsFunction4CodeEN objFunction4CodeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId4Code"] = strFuncId4Code,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objFunction4CodeEN = JsonConvert.DeserializeObject<clsFunction4CodeEN>(strJson);
return objFunction4CodeEN;
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
public static clsFunction4CodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFunction4CodeEN objFunction4CodeEN;
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
objFunction4CodeEN = JsonConvert.DeserializeObject<clsFunction4CodeEN>(strJson);
return objFunction4CodeEN;
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
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunction4CodeEN GetObjByFuncId4CodeCache(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunction4CodeEN._CurrTabName);
List<clsFunction4CodeEN> arrFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4CodeEN> arrFunction4CodeObjLst_Sel =
from objFunction4CodeEN in arrFunction4CodeObjLstCache
where objFunction4CodeEN.FuncId4Code == strFuncId4Code 
select objFunction4CodeEN;
if (arrFunction4CodeObjLst_Sel.Count() == 0)
{
   clsFunction4CodeEN obj = clsFunction4CodeWApi.GetObjByFuncId4Code(strFuncId4Code);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFunction4CodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncName4CodeByFuncId4CodeCache(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true) return "";
//初始化列表缓存
List<clsFunction4CodeEN> arrFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4CodeEN> arrFunction4CodeObjLst_Sel1 =
from objFunction4CodeEN in arrFunction4CodeObjLstCache
where objFunction4CodeEN.FuncId4Code == strFuncId4Code 
select objFunction4CodeEN;
List <clsFunction4CodeEN> arrFunction4CodeObjLst_Sel = new List<clsFunction4CodeEN>();
foreach (clsFunction4CodeEN obj in arrFunction4CodeObjLst_Sel1)
{
arrFunction4CodeObjLst_Sel.Add(obj);
}
if (arrFunction4CodeObjLst_Sel.Count > 0)
{
return arrFunction4CodeObjLst_Sel[0].FuncName4Code;
}
string strErrMsgForGetObjById = string.Format("在Function4Code对象缓存列表中,找不到记录[FuncId4Code = {0}](函数:{1})", strFuncId4Code, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunction4CodeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncId4CodeCache(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true) return "";
//初始化列表缓存
List<clsFunction4CodeEN> arrFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4CodeEN> arrFunction4CodeObjLst_Sel1 =
from objFunction4CodeEN in arrFunction4CodeObjLstCache
where objFunction4CodeEN.FuncId4Code == strFuncId4Code 
select objFunction4CodeEN;
List <clsFunction4CodeEN> arrFunction4CodeObjLst_Sel = new List<clsFunction4CodeEN>();
foreach (clsFunction4CodeEN obj in arrFunction4CodeObjLst_Sel1)
{
arrFunction4CodeObjLst_Sel.Add(obj);
}
if (arrFunction4CodeObjLst_Sel.Count > 0)
{
return arrFunction4CodeObjLst_Sel[0].FuncName4Code;
}
string strErrMsgForGetObjById = string.Format("在Function4Code对象缓存列表中,找不到记录的相关名称[FuncId4Code = {0}](函数:{1})", strFuncId4Code, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunction4CodeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4CodeEN> GetObjLst(string strWhereCond)
{
 List<clsFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4CodeEN>>(strJson);
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
 /// <param name = "arrFuncId4Code">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4CodeEN> GetObjLstByFuncId4CodeLst(List<string> arrFuncId4Code)
{
 List<clsFunction4CodeEN> arrObjLst; 
string strAction = "GetObjLstByFuncId4CodeLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncId4Code);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4CodeEN>>(strJson);
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
 /// <param name = "arrFuncId4Code">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsFunction4CodeEN> GetObjLstByFuncId4CodeLstCache(List<string> arrFuncId4Code)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFunction4CodeEN._CurrTabName);
List<clsFunction4CodeEN> arrFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4CodeEN> arrFunction4CodeObjLst_Sel =
from objFunction4CodeEN in arrFunction4CodeObjLstCache
where arrFuncId4Code.Contains(objFunction4CodeEN.FuncId4Code)
select objFunction4CodeEN;
return arrFunction4CodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4CodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4CodeEN>>(strJson);
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
public static List<clsFunction4CodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4CodeEN>>(strJson);
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
public static List<clsFunction4CodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4CodeEN>>(strJson);
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
public static List<clsFunction4CodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4CodeEN>>(strJson);
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
public static int DelRecord(string strFuncId4Code)
{
string strAction = "DelRecord";
try
{
 clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeWApi.GetObjByFuncId4Code(strFuncId4Code);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFuncId4Code.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFunction4CodeWApi.ReFreshCache();
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
public static int DelFunction4Codes(List<string> arrFuncId4Code)
{
string strAction = "DelFunction4Codes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncId4Code);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFunction4CodeWApi.ReFreshCache();
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
public static int DelFunction4CodesByCond(string strWhereCond)
{
string strAction = "DelFunction4CodesByCond";
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
public static bool AddNewRecord(clsFunction4CodeEN objFunction4CodeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunction4CodeEN>(objFunction4CodeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsFunction4CodeEN objFunction4CodeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunction4CodeEN>(objFunction4CodeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeWApi.ReFreshCache();
var strFuncId4Code = (string)jobjReturn0["returnStr"];
return strFuncId4Code;
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
public static bool UpdateRecord(clsFunction4CodeEN objFunction4CodeEN)
{
if (string.IsNullOrEmpty(objFunction4CodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunction4CodeEN.FuncId4Code, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunction4CodeEN>(objFunction4CodeEN);
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
 /// <param name = "objFunction4CodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFunction4CodeEN objFunction4CodeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFunction4CodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunction4CodeEN.FuncId4Code, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunction4CodeEN.FuncId4Code, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunction4CodeEN>(objFunction4CodeEN);
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
public static bool IsExist(string strFuncId4Code)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId4Code"] = strFuncId4Code
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
 /// <param name = "objFunction4CodeENS">源对象</param>
 /// <param name = "objFunction4CodeENT">目标对象</param>
 public static void CopyTo(clsFunction4CodeEN objFunction4CodeENS, clsFunction4CodeEN objFunction4CodeENT)
{
try
{
objFunction4CodeENT.FuncId4Code = objFunction4CodeENS.FuncId4Code; //函数Id4Code
objFunction4CodeENT.FuncName4Code = objFunction4CodeENS.FuncName4Code; //函数名4Code
objFunction4CodeENT.FuncCHName4Code = objFunction4CodeENS.FuncCHName4Code; //函数中文名4Code
objFunction4CodeENT.PrevFuncId = objFunction4CodeENS.PrevFuncId; //前函数Id
objFunction4CodeENT.RootFuncId = objFunction4CodeENS.RootFuncId; //根函数Id
objFunction4CodeENT.ApplicationTypeId = objFunction4CodeENS.ApplicationTypeId; //应用程序类型ID
objFunction4CodeENT.FuncGCTypeId = objFunction4CodeENS.FuncGCTypeId; //函数生成代码类型Id
objFunction4CodeENT.FunctionSignature = objFunction4CodeENS.FunctionSignature; //函数签名
objFunction4CodeENT.FunctionSignatureSim = objFunction4CodeENS.FunctionSignatureSim; //函数签名_Sim
objFunction4CodeENT.ReturnType = objFunction4CodeENS.ReturnType; //返回类型
objFunction4CodeENT.ClsName = objFunction4CodeENS.ClsName; //类名
objFunction4CodeENT.ReturnTypeFullName = objFunction4CodeENS.ReturnTypeFullName; //返回类型全名
objFunction4CodeENT.ReturnTypeId = objFunction4CodeENS.ReturnTypeId; //返回类型ID
objFunction4CodeENT.ReturnTypeNameCustom = objFunction4CodeENS.ReturnTypeNameCustom; //定制返回类型名
objFunction4CodeENT.CodeTypeId = objFunction4CodeENS.CodeTypeId; //代码类型Id
objFunction4CodeENT.FuncAccessModeId = objFunction4CodeENS.FuncAccessModeId; //函数操作模式Id
objFunction4CodeENT.TabName = objFunction4CodeENS.TabName; //表名
objFunction4CodeENT.TabId = objFunction4CodeENS.TabId; //表ID
objFunction4CodeENT.FuncPurposeId = objFunction4CodeENS.FuncPurposeId; //函数用途Id
objFunction4CodeENT.FuncTypeId = objFunction4CodeENS.FuncTypeId; //函数类型Id
objFunction4CodeENT.GetCustomAttributes = objFunction4CodeENS.GetCustomAttributes; //GetCustomAttributes
objFunction4CodeENT.SourceFunction = objFunction4CodeENS.SourceFunction; //来源函数
objFunction4CodeENT.IsAsyncFunc = objFunction4CodeENS.IsAsyncFunc; //是否异步函数
objFunction4CodeENT.IsSysFunction = objFunction4CodeENS.IsSysFunction; //是否系统函数
objFunction4CodeENT.OrderNum = objFunction4CodeENS.OrderNum; //序号
objFunction4CodeENT.PrjId = objFunction4CodeENS.PrjId; //工程Id
objFunction4CodeENT.IsTemplate = objFunction4CodeENS.IsTemplate; //是否模板
objFunction4CodeENT.UpdDate = objFunction4CodeENS.UpdDate; //修改日期
objFunction4CodeENT.UpdUser = objFunction4CodeENS.UpdUser; //修改者
objFunction4CodeENT.Memo = objFunction4CodeENS.Memo; //说明
objFunction4CodeENT.UsedTimes = objFunction4CodeENS.UsedTimes; //使用次数
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
public static DataTable ToDataTable(List<clsFunction4CodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFunction4CodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFunction4CodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFunction4CodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFunction4CodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFunction4CodeEN._AttributeName)
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
string strKey = string.Format("{0}", clsFunction4CodeEN._CurrTabName);
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
if (clsFunction4CodeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunction4CodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunction4CodeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunction4CodeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsFunction4CodeEN._CurrTabName;
List<clsFunction4CodeEN> arrFunction4CodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFunction4CodeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFunction4CodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFunction4Code.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.FuncName4Code, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.FuncCHName4Code, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.PrevFuncId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.RootFuncId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conFunction4Code.FuncGCTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.FunctionSignatureSim, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.ReturnType, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.ClsName, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.ReturnTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.ReturnTypeNameCustom, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.FuncAccessModeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.TabName, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.FuncPurposeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.GetCustomAttributes, Type.GetType("System.Int32"));
objDT.Columns.Add(conFunction4Code.SourceFunction, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.IsAsyncFunc, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunction4Code.IsSysFunction, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunction4Code.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conFunction4Code.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunction4Code.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4Code.UsedTimes, Type.GetType("System.Int32"));
foreach (clsFunction4CodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFunction4Code.FuncId4Code] = objInFor[conFunction4Code.FuncId4Code];
objDR[conFunction4Code.FuncName4Code] = objInFor[conFunction4Code.FuncName4Code];
objDR[conFunction4Code.FuncCHName4Code] = objInFor[conFunction4Code.FuncCHName4Code];
objDR[conFunction4Code.PrevFuncId] = objInFor[conFunction4Code.PrevFuncId];
objDR[conFunction4Code.RootFuncId] = objInFor[conFunction4Code.RootFuncId];
objDR[conFunction4Code.ApplicationTypeId] = objInFor[conFunction4Code.ApplicationTypeId];
objDR[conFunction4Code.FuncGCTypeId] = objInFor[conFunction4Code.FuncGCTypeId];
objDR[conFunction4Code.FunctionSignature] = objInFor[conFunction4Code.FunctionSignature];
objDR[conFunction4Code.FunctionSignatureSim] = objInFor[conFunction4Code.FunctionSignatureSim];
objDR[conFunction4Code.ReturnType] = objInFor[conFunction4Code.ReturnType];
objDR[conFunction4Code.ClsName] = objInFor[conFunction4Code.ClsName];
objDR[conFunction4Code.ReturnTypeFullName] = objInFor[conFunction4Code.ReturnTypeFullName];
objDR[conFunction4Code.ReturnTypeId] = objInFor[conFunction4Code.ReturnTypeId];
objDR[conFunction4Code.ReturnTypeNameCustom] = objInFor[conFunction4Code.ReturnTypeNameCustom];
objDR[conFunction4Code.CodeTypeId] = objInFor[conFunction4Code.CodeTypeId];
objDR[conFunction4Code.FuncAccessModeId] = objInFor[conFunction4Code.FuncAccessModeId];
objDR[conFunction4Code.TabName] = objInFor[conFunction4Code.TabName];
objDR[conFunction4Code.TabId] = objInFor[conFunction4Code.TabId];
objDR[conFunction4Code.FuncPurposeId] = objInFor[conFunction4Code.FuncPurposeId];
objDR[conFunction4Code.FuncTypeId] = objInFor[conFunction4Code.FuncTypeId];
objDR[conFunction4Code.GetCustomAttributes] = objInFor[conFunction4Code.GetCustomAttributes];
objDR[conFunction4Code.SourceFunction] = objInFor[conFunction4Code.SourceFunction];
objDR[conFunction4Code.IsAsyncFunc] = objInFor[conFunction4Code.IsAsyncFunc];
objDR[conFunction4Code.IsSysFunction] = objInFor[conFunction4Code.IsSysFunction];
objDR[conFunction4Code.OrderNum] = objInFor[conFunction4Code.OrderNum];
objDR[conFunction4Code.PrjId] = objInFor[conFunction4Code.PrjId];
objDR[conFunction4Code.IsTemplate] = objInFor[conFunction4Code.IsTemplate];
objDR[conFunction4Code.UpdDate] = objInFor[conFunction4Code.UpdDate];
objDR[conFunction4Code.UpdUser] = objInFor[conFunction4Code.UpdUser];
objDR[conFunction4Code.Memo] = objInFor[conFunction4Code.Memo];
objDR[conFunction4Code.UsedTimes] = objInFor[conFunction4Code.UsedTimes];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 函数4Code(Function4Code)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4Function4Code : clsCommFun4BL
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
clsFunction4CodeWApi.ReFreshThisCache();
}
}

}