
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4CodeWApi
 表名:vFunction4Code(00050387)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:36
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
public static class  clsvFunction4CodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncId4Code(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFunction4Code.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFunction4Code.FuncId4Code);
objvFunction4CodeEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncId4Code) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncId4Code, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncId4Code] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4Code">函数名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncName4Code(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, convFunction4Code.FuncName4Code);
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFunction4Code.FuncName4Code);
objvFunction4CodeEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncName4Code) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncName4Code, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncName4Code] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCHName4Code">函数中文名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncCHName4Code(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncCHName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, convFunction4Code.FuncCHName4Code);
objvFunction4CodeEN.FuncCHName4Code = strFuncCHName4Code; //函数中文名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncCHName4Code) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncCHName4Code, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncCHName4Code] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrevFuncId">前函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetPrevFuncId(this clsvFunction4CodeEN objvFunction4CodeEN, string strPrevFuncId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrevFuncId, 8, convFunction4Code.PrevFuncId);
clsCheckSql.CheckFieldForeignKey(strPrevFuncId, 8, convFunction4Code.PrevFuncId);
objvFunction4CodeEN.PrevFuncId = strPrevFuncId; //前函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.PrevFuncId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.PrevFuncId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.PrevFuncId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strRootFuncId">根函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetRootFuncId(this clsvFunction4CodeEN objvFunction4CodeEN, string strRootFuncId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRootFuncId, 8, convFunction4Code.RootFuncId);
clsCheckSql.CheckFieldForeignKey(strRootFuncId, 8, convFunction4Code.RootFuncId);
objvFunction4CodeEN.RootFuncId = strRootFuncId; //根函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.RootFuncId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.RootFuncId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.RootFuncId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetApplicationTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convFunction4Code.ApplicationTypeId);
objvFunction4CodeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ApplicationTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ApplicationTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ApplicationTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetApplicationTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convFunction4Code.ApplicationTypeName);
objvFunction4CodeEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ApplicationTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ApplicationTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ApplicationTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeId">函数生成代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncGCTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncGCTypeId, convFunction4Code.FuncGCTypeId);
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, convFunction4Code.FuncGCTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, convFunction4Code.FuncGCTypeId);
objvFunction4CodeEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncGCTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncGCTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncGCTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeName">函数生成代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncGCTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncGCTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncGCTypeName, 50, convFunction4Code.FuncGCTypeName);
objvFunction4CodeEN.FuncGCTypeName = strFuncGCTypeName; //函数生成代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncGCTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncGCTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncGCTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeENName">函数生成代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncGCTypeENName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncGCTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncGCTypeENName, 50, convFunction4Code.FuncGCTypeENName);
objvFunction4CodeEN.FuncGCTypeENName = strFuncGCTypeENName; //函数生成代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncGCTypeENName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncGCTypeENName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncGCTypeENName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFunctionSignature(this clsvFunction4CodeEN objvFunction4CodeEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convFunction4Code.FunctionSignature);
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFunction4Code.FunctionSignature);
objvFunction4CodeEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FunctionSignature) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FunctionSignature, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FunctionSignature] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignatureSim">函数签名_Sim</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFunctionSignatureSim(this clsvFunction4CodeEN objvFunction4CodeEN, string strFunctionSignatureSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionSignatureSim, 500, convFunction4Code.FunctionSignatureSim);
objvFunction4CodeEN.FunctionSignatureSim = strFunctionSignatureSim; //函数签名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FunctionSignatureSim) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FunctionSignatureSim, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FunctionSignatureSim] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnType">返回类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetReturnType(this clsvFunction4CodeEN objvFunction4CodeEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnType, convFunction4Code.ReturnType);
clsCheckSql.CheckFieldLen(strReturnType, 500, convFunction4Code.ReturnType);
objvFunction4CodeEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ReturnType) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ReturnType, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ReturnType] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetReturnTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convFunction4Code.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convFunction4Code.ReturnTypeId);
objvFunction4CodeEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ReturnTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ReturnTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ReturnTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeNameCustom">定制返回类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetReturnTypeNameCustom(this clsvFunction4CodeEN objvFunction4CodeEN, string strReturnTypeNameCustom, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeNameCustom, 50, convFunction4Code.ReturnTypeNameCustom);
objvFunction4CodeEN.ReturnTypeNameCustom = strReturnTypeNameCustom; //定制返回类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ReturnTypeNameCustom) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ReturnTypeNameCustom, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ReturnTypeNameCustom] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetCodeTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convFunction4Code.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convFunction4Code.CodeTypeId);
objvFunction4CodeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.CodeTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.CodeTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.CodeTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetCodeTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convFunction4Code.CodeTypeName);
objvFunction4CodeEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.CodeTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.CodeTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.CodeTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetProgLangTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunction4Code.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunction4Code.ProgLangTypeId);
objvFunction4CodeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ProgLangTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncAccessModeId">函数操作模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncAccessModeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncAccessModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncAccessModeId, 2, convFunction4Code.FuncAccessModeId);
clsCheckSql.CheckFieldForeignKey(strFuncAccessModeId, 2, convFunction4Code.FuncAccessModeId);
objvFunction4CodeEN.FuncAccessModeId = strFuncAccessModeId; //函数操作模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncAccessModeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncAccessModeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncAccessModeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncAccessModeName">函数操作模式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncAccessModeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncAccessModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncAccessModeName, 50, convFunction4Code.FuncAccessModeName);
objvFunction4CodeEN.FuncAccessModeName = strFuncAccessModeName; //函数操作模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncAccessModeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncAccessModeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncAccessModeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetTabName(this clsvFunction4CodeEN objvFunction4CodeEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 100, convFunction4Code.TabName);
objvFunction4CodeEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.TabName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.TabName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.TabName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetTabId(this clsvFunction4CodeEN objvFunction4CodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convFunction4Code.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convFunction4Code.TabId);
objvFunction4CodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.TabId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.TabId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.TabId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncPurposeId">函数用途Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncPurposeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncPurposeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncPurposeId, convFunction4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(strFuncPurposeId, 2, convFunction4Code.FuncPurposeId);
clsCheckSql.CheckFieldForeignKey(strFuncPurposeId, 2, convFunction4Code.FuncPurposeId);
objvFunction4CodeEN.FuncPurposeId = strFuncPurposeId; //函数用途Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncPurposeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncPurposeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncPurposeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncPurposeName">函数用途名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncPurposeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncPurposeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncPurposeName, 20, convFunction4Code.FuncPurposeName);
objvFunction4CodeEN.FuncPurposeName = strFuncPurposeName; //函数用途名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncPurposeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncPurposeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncPurposeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeId, convFunction4Code.FuncTypeId);
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convFunction4Code.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convFunction4Code.FuncTypeId);
objvFunction4CodeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeName">函数类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeName, convFunction4Code.FuncTypeName);
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convFunction4Code.FuncTypeName);
objvFunction4CodeEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAsyncFunc">是否异步函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetIsAsyncFunc(this clsvFunction4CodeEN objvFunction4CodeEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objvFunction4CodeEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.IsAsyncFunc) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.IsAsyncFunc, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.IsAsyncFunc] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSysFunction">是否系统函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetIsSysFunction(this clsvFunction4CodeEN objvFunction4CodeEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objvFunction4CodeEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.IsSysFunction) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.IsSysFunction, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.IsSysFunction] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetOrderNum(this clsvFunction4CodeEN objvFunction4CodeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFunction4Code.OrderNum);
objvFunction4CodeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.OrderNum) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.OrderNum, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.OrderNum] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetPrjId(this clsvFunction4CodeEN objvFunction4CodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFunction4Code.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFunction4Code.PrjId);
objvFunction4CodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.PrjId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.PrjId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.PrjId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetUpdDate(this clsvFunction4CodeEN objvFunction4CodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunction4Code.UpdDate);
objvFunction4CodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.UpdDate) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.UpdDate, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.UpdDate] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetUpdUser(this clsvFunction4CodeEN objvFunction4CodeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunction4Code.UpdUser);
objvFunction4CodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.UpdUser) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.UpdUser, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.UpdUser] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetMemo(this clsvFunction4CodeEN objvFunction4CodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunction4Code.Memo);
objvFunction4CodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.Memo) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.Memo, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.Memo] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeName">返回类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetReturnTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strReturnTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeName, 100, convFunction4Code.ReturnTypeName);
objvFunction4CodeEN.ReturnTypeName = strReturnTypeName; //返回类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ReturnTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ReturnTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ReturnTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName2">TabName2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetTabName2(this clsvFunction4CodeEN objvFunction4CodeEN, string strTabName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName2, 100, convFunction4Code.TabName2);
objvFunction4CodeEN.TabName2 = strTabName2; //TabName2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.TabName2) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.TabName2, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.TabName2] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intFunc4GCCount">函数4GC数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFunc4GCCount(this clsvFunction4CodeEN objvFunction4CodeEN, int intFunc4GCCount, string strComparisonOp="")
	{
objvFunction4CodeEN.Func4GCCount = intFunc4GCCount; //函数4GC数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.Func4GCCount) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.Func4GCCount, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.Func4GCCount] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intParaNum">参数个数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetParaNum(this clsvFunction4CodeEN objvFunction4CodeEN, int intParaNum, string strComparisonOp="")
	{
objvFunction4CodeEN.ParaNum = intParaNum; //参数个数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ParaNum) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ParaNum, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ParaNum] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intFeatureCount">功能数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFeatureCount(this clsvFunction4CodeEN objvFunction4CodeEN, int intFeatureCount, string strComparisonOp="")
	{
objvFunction4CodeEN.FeatureCount = intFeatureCount; //功能数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FeatureCount) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FeatureCount, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FeatureCount] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetClsName(this clsvFunction4CodeEN objvFunction4CodeEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsName, 100, convFunction4Code.ClsName);
objvFunction4CodeEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ClsName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ClsName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ClsName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunction4CodeEN objvFunction4CodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncId4Code, objvFunction4CodeCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncName4Code, objvFunction4CodeCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncCHName4Code) == true)
{
string strComparisonOpFuncCHName4Code = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncCHName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncCHName4Code, objvFunction4CodeCond.FuncCHName4Code, strComparisonOpFuncCHName4Code);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.PrevFuncId) == true)
{
string strComparisonOpPrevFuncId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.PrevFuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.PrevFuncId, objvFunction4CodeCond.PrevFuncId, strComparisonOpPrevFuncId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.RootFuncId) == true)
{
string strComparisonOpRootFuncId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.RootFuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.RootFuncId, objvFunction4CodeCond.RootFuncId, strComparisonOpRootFuncId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.ApplicationTypeId, objvFunction4CodeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ApplicationTypeName, objvFunction4CodeCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncGCTypeId, objvFunction4CodeCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncGCTypeName) == true)
{
string strComparisonOpFuncGCTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncGCTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncGCTypeName, objvFunction4CodeCond.FuncGCTypeName, strComparisonOpFuncGCTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncGCTypeENName) == true)
{
string strComparisonOpFuncGCTypeENName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncGCTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncGCTypeENName, objvFunction4CodeCond.FuncGCTypeENName, strComparisonOpFuncGCTypeENName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FunctionSignature, objvFunction4CodeCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FunctionSignatureSim) == true)
{
string strComparisonOpFunctionSignatureSim = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FunctionSignatureSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FunctionSignatureSim, objvFunction4CodeCond.FunctionSignatureSim, strComparisonOpFunctionSignatureSim);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ReturnType) == true)
{
string strComparisonOpReturnType = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ReturnType, objvFunction4CodeCond.ReturnType, strComparisonOpReturnType);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ReturnTypeId, objvFunction4CodeCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ReturnTypeNameCustom) == true)
{
string strComparisonOpReturnTypeNameCustom = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ReturnTypeNameCustom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ReturnTypeNameCustom, objvFunction4CodeCond.ReturnTypeNameCustom, strComparisonOpReturnTypeNameCustom);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.CodeTypeId, objvFunction4CodeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.CodeTypeName, objvFunction4CodeCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ProgLangTypeId, objvFunction4CodeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncAccessModeId) == true)
{
string strComparisonOpFuncAccessModeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncAccessModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncAccessModeId, objvFunction4CodeCond.FuncAccessModeId, strComparisonOpFuncAccessModeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncAccessModeName) == true)
{
string strComparisonOpFuncAccessModeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncAccessModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncAccessModeName, objvFunction4CodeCond.FuncAccessModeName, strComparisonOpFuncAccessModeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.TabName) == true)
{
string strComparisonOpTabName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.TabName, objvFunction4CodeCond.TabName, strComparisonOpTabName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.TabId) == true)
{
string strComparisonOpTabId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.TabId, objvFunction4CodeCond.TabId, strComparisonOpTabId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncPurposeId) == true)
{
string strComparisonOpFuncPurposeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncPurposeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncPurposeId, objvFunction4CodeCond.FuncPurposeId, strComparisonOpFuncPurposeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncPurposeName) == true)
{
string strComparisonOpFuncPurposeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncPurposeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncPurposeName, objvFunction4CodeCond.FuncPurposeName, strComparisonOpFuncPurposeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncTypeId, objvFunction4CodeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncTypeName, objvFunction4CodeCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.IsAsyncFunc) == true)
{
if (objvFunction4CodeCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunction4Code.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunction4Code.IsAsyncFunc);
}
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.IsSysFunction) == true)
{
if (objvFunction4CodeCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunction4Code.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunction4Code.IsSysFunction);
}
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.OrderNum, objvFunction4CodeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.PrjId) == true)
{
string strComparisonOpPrjId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.PrjId, objvFunction4CodeCond.PrjId, strComparisonOpPrjId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.UpdDate, objvFunction4CodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.UpdUser, objvFunction4CodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.Memo) == true)
{
string strComparisonOpMemo = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.Memo, objvFunction4CodeCond.Memo, strComparisonOpMemo);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ReturnTypeName) == true)
{
string strComparisonOpReturnTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ReturnTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ReturnTypeName, objvFunction4CodeCond.ReturnTypeName, strComparisonOpReturnTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.TabName2) == true)
{
string strComparisonOpTabName2 = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.TabName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.TabName2, objvFunction4CodeCond.TabName2, strComparisonOpTabName2);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.Func4GCCount) == true)
{
string strComparisonOpFunc4GCCount = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.Func4GCCount];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.Func4GCCount, objvFunction4CodeCond.Func4GCCount, strComparisonOpFunc4GCCount);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ParaNum) == true)
{
string strComparisonOpParaNum = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ParaNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.ParaNum, objvFunction4CodeCond.ParaNum, strComparisonOpParaNum);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FeatureCount) == true)
{
string strComparisonOpFeatureCount = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FeatureCount];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.FeatureCount, objvFunction4CodeCond.FeatureCount, strComparisonOpFeatureCount);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ClsName) == true)
{
string strComparisonOpClsName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ClsName, objvFunction4CodeCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数4Code(vFunction4Code)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunction4CodeWApi
{
private static readonly string mstrApiControllerName = "vFunction4CodeApi";

 public clsvFunction4CodeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4CodeEN GetObjByFuncId4Code(string strFuncId4Code)
{
if (strFuncId4Code == "") return null;
string strAction = "GetObjByFuncId4Code";
clsvFunction4CodeEN objvFunction4CodeEN;
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
objvFunction4CodeEN = JsonConvert.DeserializeObject<clsvFunction4CodeEN>(strJson);
return objvFunction4CodeEN;
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
public static clsvFunction4CodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunction4CodeEN objvFunction4CodeEN;
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
objvFunction4CodeEN = JsonConvert.DeserializeObject<clsvFunction4CodeEN>(strJson);
return objvFunction4CodeEN;
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
public static clsvFunction4CodeEN GetObjByFuncId4CodeCache(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunction4CodeEN._CurrTabName);
List<clsvFunction4CodeEN> arrvFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4CodeEN> arrvFunction4CodeObjLst_Sel =
from objvFunction4CodeEN in arrvFunction4CodeObjLstCache
where objvFunction4CodeEN.FuncId4Code == strFuncId4Code 
select objvFunction4CodeEN;
if (arrvFunction4CodeObjLst_Sel.Count() == 0)
{
   clsvFunction4CodeEN obj = clsvFunction4CodeWApi.GetObjByFuncId4Code(strFuncId4Code);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFunction4CodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4CodeEN> GetObjLst(string strWhereCond)
{
 List<clsvFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4CodeEN>>(strJson);
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
public static List<clsvFunction4CodeEN> GetObjLstByFuncId4CodeLst(List<string> arrFuncId4Code)
{
 List<clsvFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4CodeEN>>(strJson);
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
public static IEnumerable<clsvFunction4CodeEN> GetObjLstByFuncId4CodeLstCache(List<string> arrFuncId4Code)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunction4CodeEN._CurrTabName);
List<clsvFunction4CodeEN> arrvFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4CodeEN> arrvFunction4CodeObjLst_Sel =
from objvFunction4CodeEN in arrvFunction4CodeObjLstCache
where arrFuncId4Code.Contains(objvFunction4CodeEN.FuncId4Code)
select objvFunction4CodeEN;
return arrvFunction4CodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4CodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4CodeEN>>(strJson);
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
public static List<clsvFunction4CodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4CodeEN>>(strJson);
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
public static List<clsvFunction4CodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4CodeEN>>(strJson);
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
public static List<clsvFunction4CodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunction4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4CodeEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvFunction4CodeENS">源对象</param>
 /// <param name = "objvFunction4CodeENT">目标对象</param>
 public static void CopyTo(clsvFunction4CodeEN objvFunction4CodeENS, clsvFunction4CodeEN objvFunction4CodeENT)
{
try
{
objvFunction4CodeENT.FuncId4Code = objvFunction4CodeENS.FuncId4Code; //函数Id4Code
objvFunction4CodeENT.FuncName4Code = objvFunction4CodeENS.FuncName4Code; //函数名4Code
objvFunction4CodeENT.FuncCHName4Code = objvFunction4CodeENS.FuncCHName4Code; //函数中文名4Code
objvFunction4CodeENT.PrevFuncId = objvFunction4CodeENS.PrevFuncId; //前函数Id
objvFunction4CodeENT.RootFuncId = objvFunction4CodeENS.RootFuncId; //根函数Id
objvFunction4CodeENT.ApplicationTypeId = objvFunction4CodeENS.ApplicationTypeId; //应用程序类型ID
objvFunction4CodeENT.ApplicationTypeName = objvFunction4CodeENS.ApplicationTypeName; //应用程序类型名称
objvFunction4CodeENT.FuncGCTypeId = objvFunction4CodeENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4CodeENT.FuncGCTypeName = objvFunction4CodeENS.FuncGCTypeName; //函数生成代码类型名
objvFunction4CodeENT.FuncGCTypeENName = objvFunction4CodeENS.FuncGCTypeENName; //函数生成代码类型英文名
objvFunction4CodeENT.FunctionSignature = objvFunction4CodeENS.FunctionSignature; //函数签名
objvFunction4CodeENT.FunctionSignatureSim = objvFunction4CodeENS.FunctionSignatureSim; //函数签名_Sim
objvFunction4CodeENT.ReturnType = objvFunction4CodeENS.ReturnType; //返回类型
objvFunction4CodeENT.ReturnTypeId = objvFunction4CodeENS.ReturnTypeId; //返回类型ID
objvFunction4CodeENT.ReturnTypeNameCustom = objvFunction4CodeENS.ReturnTypeNameCustom; //定制返回类型名
objvFunction4CodeENT.CodeTypeId = objvFunction4CodeENS.CodeTypeId; //代码类型Id
objvFunction4CodeENT.CodeTypeName = objvFunction4CodeENS.CodeTypeName; //代码类型名
objvFunction4CodeENT.ProgLangTypeId = objvFunction4CodeENS.ProgLangTypeId; //编程语言类型Id
objvFunction4CodeENT.FuncAccessModeId = objvFunction4CodeENS.FuncAccessModeId; //函数操作模式Id
objvFunction4CodeENT.FuncAccessModeName = objvFunction4CodeENS.FuncAccessModeName; //函数操作模式名
objvFunction4CodeENT.TabName = objvFunction4CodeENS.TabName; //表名
objvFunction4CodeENT.TabId = objvFunction4CodeENS.TabId; //表ID
objvFunction4CodeENT.FuncPurposeId = objvFunction4CodeENS.FuncPurposeId; //函数用途Id
objvFunction4CodeENT.FuncPurposeName = objvFunction4CodeENS.FuncPurposeName; //函数用途名
objvFunction4CodeENT.FuncTypeId = objvFunction4CodeENS.FuncTypeId; //函数类型Id
objvFunction4CodeENT.FuncTypeName = objvFunction4CodeENS.FuncTypeName; //函数类型名
objvFunction4CodeENT.IsAsyncFunc = objvFunction4CodeENS.IsAsyncFunc; //是否异步函数
objvFunction4CodeENT.IsSysFunction = objvFunction4CodeENS.IsSysFunction; //是否系统函数
objvFunction4CodeENT.OrderNum = objvFunction4CodeENS.OrderNum; //序号
objvFunction4CodeENT.PrjId = objvFunction4CodeENS.PrjId; //工程Id
objvFunction4CodeENT.UpdDate = objvFunction4CodeENS.UpdDate; //修改日期
objvFunction4CodeENT.UpdUser = objvFunction4CodeENS.UpdUser; //修改者
objvFunction4CodeENT.Memo = objvFunction4CodeENS.Memo; //说明
objvFunction4CodeENT.ReturnTypeName = objvFunction4CodeENS.ReturnTypeName; //返回类型名
objvFunction4CodeENT.TabName2 = objvFunction4CodeENS.TabName2; //TabName2
objvFunction4CodeENT.Func4GCCount = objvFunction4CodeENS.Func4GCCount; //函数4GC数
objvFunction4CodeENT.ParaNum = objvFunction4CodeENS.ParaNum; //参数个数
objvFunction4CodeENT.FeatureCount = objvFunction4CodeENS.FeatureCount; //功能数
objvFunction4CodeENT.ClsName = objvFunction4CodeENS.ClsName; //类名
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
public static DataTable ToDataTable(List<clsvFunction4CodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunction4CodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunction4CodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunction4CodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunction4CodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunction4CodeEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunction4CodeEN._CurrTabName);
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
public static List<clsvFunction4CodeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFunction4CodeEN._CurrTabName;
List<clsvFunction4CodeEN> arrvFunction4CodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFunction4CodeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunction4CodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunction4Code.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncCHName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.PrevFuncId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.RootFuncId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4Code.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncGCTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncGCTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncGCTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FunctionSignatureSim, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.ReturnType, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.ReturnTypeNameCustom, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncAccessModeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncAccessModeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncPurposeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncPurposeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.FuncTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.IsAsyncFunc, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFunction4Code.IsSysFunction, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFunction4Code.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4Code.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.ReturnTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.TabName2, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code.Func4GCCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4Code.ParaNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4Code.FeatureCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4Code.ClsName, Type.GetType("System.String"));
foreach (clsvFunction4CodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunction4Code.FuncId4Code] = objInFor[convFunction4Code.FuncId4Code];
objDR[convFunction4Code.FuncName4Code] = objInFor[convFunction4Code.FuncName4Code];
objDR[convFunction4Code.FuncCHName4Code] = objInFor[convFunction4Code.FuncCHName4Code];
objDR[convFunction4Code.PrevFuncId] = objInFor[convFunction4Code.PrevFuncId];
objDR[convFunction4Code.RootFuncId] = objInFor[convFunction4Code.RootFuncId];
objDR[convFunction4Code.ApplicationTypeId] = objInFor[convFunction4Code.ApplicationTypeId];
objDR[convFunction4Code.ApplicationTypeName] = objInFor[convFunction4Code.ApplicationTypeName];
objDR[convFunction4Code.FuncGCTypeId] = objInFor[convFunction4Code.FuncGCTypeId];
objDR[convFunction4Code.FuncGCTypeName] = objInFor[convFunction4Code.FuncGCTypeName];
objDR[convFunction4Code.FuncGCTypeENName] = objInFor[convFunction4Code.FuncGCTypeENName];
objDR[convFunction4Code.FunctionSignature] = objInFor[convFunction4Code.FunctionSignature];
objDR[convFunction4Code.FunctionSignatureSim] = objInFor[convFunction4Code.FunctionSignatureSim];
objDR[convFunction4Code.ReturnType] = objInFor[convFunction4Code.ReturnType];
objDR[convFunction4Code.ReturnTypeId] = objInFor[convFunction4Code.ReturnTypeId];
objDR[convFunction4Code.ReturnTypeNameCustom] = objInFor[convFunction4Code.ReturnTypeNameCustom];
objDR[convFunction4Code.CodeTypeId] = objInFor[convFunction4Code.CodeTypeId];
objDR[convFunction4Code.CodeTypeName] = objInFor[convFunction4Code.CodeTypeName];
objDR[convFunction4Code.ProgLangTypeId] = objInFor[convFunction4Code.ProgLangTypeId];
objDR[convFunction4Code.FuncAccessModeId] = objInFor[convFunction4Code.FuncAccessModeId];
objDR[convFunction4Code.FuncAccessModeName] = objInFor[convFunction4Code.FuncAccessModeName];
objDR[convFunction4Code.TabName] = objInFor[convFunction4Code.TabName];
objDR[convFunction4Code.TabId] = objInFor[convFunction4Code.TabId];
objDR[convFunction4Code.FuncPurposeId] = objInFor[convFunction4Code.FuncPurposeId];
objDR[convFunction4Code.FuncPurposeName] = objInFor[convFunction4Code.FuncPurposeName];
objDR[convFunction4Code.FuncTypeId] = objInFor[convFunction4Code.FuncTypeId];
objDR[convFunction4Code.FuncTypeName] = objInFor[convFunction4Code.FuncTypeName];
objDR[convFunction4Code.IsAsyncFunc] = objInFor[convFunction4Code.IsAsyncFunc];
objDR[convFunction4Code.IsSysFunction] = objInFor[convFunction4Code.IsSysFunction];
objDR[convFunction4Code.OrderNum] = objInFor[convFunction4Code.OrderNum];
objDR[convFunction4Code.PrjId] = objInFor[convFunction4Code.PrjId];
objDR[convFunction4Code.UpdDate] = objInFor[convFunction4Code.UpdDate];
objDR[convFunction4Code.UpdUser] = objInFor[convFunction4Code.UpdUser];
objDR[convFunction4Code.Memo] = objInFor[convFunction4Code.Memo];
objDR[convFunction4Code.ReturnTypeName] = objInFor[convFunction4Code.ReturnTypeName];
objDR[convFunction4Code.TabName2] = objInFor[convFunction4Code.TabName2];
objDR[convFunction4Code.Func4GCCount] = objInFor[convFunction4Code.Func4GCCount];
objDR[convFunction4Code.ParaNum] = objInFor[convFunction4Code.ParaNum];
objDR[convFunction4Code.FeatureCount] = objInFor[convFunction4Code.FeatureCount];
objDR[convFunction4Code.ClsName] = objInFor[convFunction4Code.ClsName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}