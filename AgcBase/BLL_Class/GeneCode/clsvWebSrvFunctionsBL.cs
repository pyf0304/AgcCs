
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvFunctionsBL
 表名:vWebSrvFunctions(00050343)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:55
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvWebSrvFunctionsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvFunctionsEN GetObj(this K_WebSrvFunctionId_vWebSrvFunctions myKey)
{
clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = clsvWebSrvFunctionsBL.vWebSrvFunctionsDA.GetObjByWebSrvFunctionId(myKey.Value);
return objvWebSrvFunctionsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetWebSrvFunctionId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strWebSrvFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvFunctionId, 8, convWebSrvFunctions.WebSrvFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvFunctionId, 8, convWebSrvFunctions.WebSrvFunctionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetWebSrvClassId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvClassId, convWebSrvFunctions.WebSrvClassId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convWebSrvFunctions.WebSrvClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convWebSrvFunctions.WebSrvClassId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetNameSpace(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strNameSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convWebSrvFunctions.NameSpace);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetWebSrvUrl(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strWebSrvUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvUrl, 300, convWebSrvFunctions.WebSrvUrl);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFuncModuleAgcId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convWebSrvFunctions.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convWebSrvFunctions.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetPrjId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convWebSrvFunctions.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convWebSrvFunctions.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFunctionName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convWebSrvFunctions.FunctionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFunctionSignature(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convWebSrvFunctions.FunctionSignature);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convWebSrvFunctions.FunctionSignature);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFuncTypeId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeId, convWebSrvFunctions.FuncTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convWebSrvFunctions.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convWebSrvFunctions.FuncTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFuncTypeName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeName, convWebSrvFunctions.FuncTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convWebSrvFunctions.FuncTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetReturnType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnType, convWebSrvFunctions.ReturnType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnType, 500, convWebSrvFunctions.ReturnType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetReturnTypeFullName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strReturnTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeFullName, 500, convWebSrvFunctions.ReturnTypeFullName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetReturnTypeId(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strReturnTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convWebSrvFunctions.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convWebSrvFunctions.ReturnTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetDataTypeName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convWebSrvFunctions.DataTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetDataTypeAbbr(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strDataTypeAbbr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeAbbr, 5, convWebSrvFunctions.DataTypeAbbr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetNetSysType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strNetSysType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNetSysType, 20, convWebSrvFunctions.NetSysType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetCsType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strCsType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCsType, 100, convWebSrvFunctions.CsType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetJavaType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strJavaType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaType, 100, convWebSrvFunctions.JavaType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetJavaObjType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strJavaObjType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convWebSrvFunctions.JavaObjType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetSwiftType(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strSwiftType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convWebSrvFunctions.SwiftType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetSourceFunction(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strSourceFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceFunction, 500, convWebSrvFunctions.SourceFunction);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetReturnValueDescription(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strReturnValueDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnValueDescription, 500, convWebSrvFunctions.ReturnValueDescription);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetFuncParaLst(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strFuncParaLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, convWebSrvFunctions.FuncParaLst);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetUpdDate(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWebSrvFunctions.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetUpdUser(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convWebSrvFunctions.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetMemo(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWebSrvFunctions.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFunctionsEN SetClsName(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN, string strClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, convWebSrvFunctions.ClsName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsENS">源对象</param>
 /// <param name = "objvWebSrvFunctionsENT">目标对象</param>
 public static void CopyTo(this clsvWebSrvFunctionsEN objvWebSrvFunctionsENS, clsvWebSrvFunctionsEN objvWebSrvFunctionsENT)
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
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsENS">源对象</param>
 /// <returns>目标对象=>clsvWebSrvFunctionsEN:objvWebSrvFunctionsENT</returns>
 public static clsvWebSrvFunctionsEN CopyTo(this clsvWebSrvFunctionsEN objvWebSrvFunctionsENS)
{
try
{
 clsvWebSrvFunctionsEN objvWebSrvFunctionsENT = new clsvWebSrvFunctionsEN()
{
WebSrvFunctionId = objvWebSrvFunctionsENS.WebSrvFunctionId, //函数Id
WebSrvClassId = objvWebSrvFunctionsENS.WebSrvClassId, //类Id
NameSpace = objvWebSrvFunctionsENS.NameSpace, //域名
WebSrvUrl = objvWebSrvFunctionsENS.WebSrvUrl, //WebSrv地址
FuncModuleAgcId = objvWebSrvFunctionsENS.FuncModuleAgcId, //功能模块Id
PrjId = objvWebSrvFunctionsENS.PrjId, //工程Id
FunctionName = objvWebSrvFunctionsENS.FunctionName, //功能名称
GetCustomAttributes = objvWebSrvFunctionsENS.GetCustomAttributes, //GetCustomAttributes
FunctionSignature = objvWebSrvFunctionsENS.FunctionSignature, //函数签名
FuncTypeId = objvWebSrvFunctionsENS.FuncTypeId, //函数类型Id
FuncTypeName = objvWebSrvFunctionsENS.FuncTypeName, //函数类型名
ReturnType = objvWebSrvFunctionsENS.ReturnType, //返回类型
ReturnTypeFullName = objvWebSrvFunctionsENS.ReturnTypeFullName, //返回类型全名
IsKnownType = objvWebSrvFunctionsENS.IsKnownType, //是否已知类型
ReturnTypeId = objvWebSrvFunctionsENS.ReturnTypeId, //返回类型ID
DataTypeName = objvWebSrvFunctionsENS.DataTypeName, //数据类型名称
DataTypeAbbr = objvWebSrvFunctionsENS.DataTypeAbbr, //数据类型缩写
NetSysType = objvWebSrvFunctionsENS.NetSysType, //NET系统类型
CsType = objvWebSrvFunctionsENS.CsType, //CS类型
JavaType = objvWebSrvFunctionsENS.JavaType, //JAVA类型
JavaObjType = objvWebSrvFunctionsENS.JavaObjType, //JAVA对象类型
SwiftType = objvWebSrvFunctionsENS.SwiftType, //SwiftType
IsNeedQuote = objvWebSrvFunctionsENS.IsNeedQuote, //是否需要引号
IsAsyncFunc = objvWebSrvFunctionsENS.IsAsyncFunc, //是否异步函数
SourceFunction = objvWebSrvFunctionsENS.SourceFunction, //来源函数
IsGeneCode = objvWebSrvFunctionsENS.IsGeneCode, //是否生成代码
ReturnValueDescription = objvWebSrvFunctionsENS.ReturnValueDescription, //返回值说明
FuncParaLst = objvWebSrvFunctionsENS.FuncParaLst, //函数参数列表
UpdDate = objvWebSrvFunctionsENS.UpdDate, //修改日期
UpdUser = objvWebSrvFunctionsENS.UpdUser, //修改者
Memo = objvWebSrvFunctionsENS.Memo, //说明
ClsName = objvWebSrvFunctionsENS.ClsName, //类名
};
 return objvWebSrvFunctionsENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvWebSrvFunctionsEN objvWebSrvFunctionsEN)
{
 clsvWebSrvFunctionsBL.vWebSrvFunctionsDA.CheckProperty4Condition(objvWebSrvFunctionsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vWebSrvFunctions
{
public virtual bool UpdRelaTabDate(string strWebSrvFunctionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vWebSrv函数(vWebSrvFunctions)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvWebSrvFunctionsBL
{
public static RelatedActions_vWebSrvFunctions relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvWebSrvFunctionsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvWebSrvFunctionsDA vWebSrvFunctionsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvWebSrvFunctionsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvWebSrvFunctionsBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvWebSrvFunctionsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWebSrvFunctionsEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vWebSrvFunctions(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vWebSrvFunctionsDA.GetDataTable_vWebSrvFunctions(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vWebSrvFunctionsDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vWebSrvFunctionsDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vWebSrvFunctionsDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vWebSrvFunctionsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vWebSrvFunctionsDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vWebSrvFunctionsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vWebSrvFunctionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vWebSrvFunctionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrWebSrvFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLstByWebSrvFunctionIdLst(List<string> arrWebSrvFunctionIdLst)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWebSrvFunctionIdLst, true);
 string strWhereCond = string.Format("WebSrvFunctionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWebSrvFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvWebSrvFunctionsEN> GetObjLstByWebSrvFunctionIdLstCache(List<string> arrWebSrvFunctionIdLst)
{
string strKey = string.Format("{0}", clsvWebSrvFunctionsEN._CurrTabName);
List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLst_Sel =
arrvWebSrvFunctionsObjLstCache
.Where(x => arrWebSrvFunctionIdLst.Contains(x.WebSrvFunctionId));
return arrvWebSrvFunctionsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLst(string strWhereCond)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvWebSrvFunctionsEN> GetSubObjLstCache(clsvWebSrvFunctionsEN objvWebSrvFunctionsCond)
{
List<clsvWebSrvFunctionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFunctionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convWebSrvFunctions._AttributeName)
{
if (objvWebSrvFunctionsCond.IsUpdated(strFldName) == false) continue;
if (objvWebSrvFunctionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvFunctionsCond[strFldName].ToString());
}
else
{
if (objvWebSrvFunctionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvWebSrvFunctionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvFunctionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvWebSrvFunctionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvWebSrvFunctionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvWebSrvFunctionsCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvWebSrvFunctionsEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvFunctionsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvWebSrvFunctions(ref clsvWebSrvFunctionsEN objvWebSrvFunctionsEN)
{
bool bolResult = vWebSrvFunctionsDA.GetvWebSrvFunctions(ref objvWebSrvFunctionsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvFunctionsEN GetObjByWebSrvFunctionId(string strWebSrvFunctionId)
{
if (strWebSrvFunctionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strWebSrvFunctionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strWebSrvFunctionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = vWebSrvFunctionsDA.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
return objvWebSrvFunctionsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvWebSrvFunctionsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = vWebSrvFunctionsDA.GetFirstObj(strWhereCond);
 return objvWebSrvFunctionsEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvWebSrvFunctionsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = vWebSrvFunctionsDA.GetObjByDataRow(objRow);
 return objvWebSrvFunctionsEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvWebSrvFunctionsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = vWebSrvFunctionsDA.GetObjByDataRow(objRow);
 return objvWebSrvFunctionsEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">所给的关键字</param>
 /// <param name = "lstvWebSrvFunctionsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvFunctionsEN GetObjByWebSrvFunctionIdFromList(string strWebSrvFunctionId, List<clsvWebSrvFunctionsEN> lstvWebSrvFunctionsObjLst)
{
foreach (clsvWebSrvFunctionsEN objvWebSrvFunctionsEN in lstvWebSrvFunctionsObjLst)
{
if (objvWebSrvFunctionsEN.WebSrvFunctionId == strWebSrvFunctionId)
{
return objvWebSrvFunctionsEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strWebSrvFunctionId;
 try
 {
 strWebSrvFunctionId = new clsvWebSrvFunctionsDA().GetFirstID(strWhereCond);
 return strWebSrvFunctionId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vWebSrvFunctionsDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vWebSrvFunctionsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strWebSrvFunctionId)
{
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strWebSrvFunctionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vWebSrvFunctionsDA.IsExist(strWebSrvFunctionId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvWebSrvFunctionsDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vWebSrvFunctionsDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">源简化对象</param>
 public static void SetUpdFlag(clsvWebSrvFunctionsEN objvWebSrvFunctionsEN)
{
try
{
objvWebSrvFunctionsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvWebSrvFunctionsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convWebSrvFunctions.WebSrvFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objvWebSrvFunctionsEN.WebSrvFunctionId; //函数Id
}
if (arrFldSet.Contains(convWebSrvFunctions.WebSrvClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.WebSrvClassId = objvWebSrvFunctionsEN.WebSrvClassId; //类Id
}
if (arrFldSet.Contains(convWebSrvFunctions.NameSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.NameSpace = objvWebSrvFunctionsEN.NameSpace == "[null]" ? null :  objvWebSrvFunctionsEN.NameSpace; //域名
}
if (arrFldSet.Contains(convWebSrvFunctions.WebSrvUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.WebSrvUrl = objvWebSrvFunctionsEN.WebSrvUrl == "[null]" ? null :  objvWebSrvFunctionsEN.WebSrvUrl; //WebSrv地址
}
if (arrFldSet.Contains(convWebSrvFunctions.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.FuncModuleAgcId = objvWebSrvFunctionsEN.FuncModuleAgcId == "[null]" ? null :  objvWebSrvFunctionsEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convWebSrvFunctions.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.PrjId = objvWebSrvFunctionsEN.PrjId == "[null]" ? null :  objvWebSrvFunctionsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convWebSrvFunctions.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.FunctionName = objvWebSrvFunctionsEN.FunctionName == "[null]" ? null :  objvWebSrvFunctionsEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(convWebSrvFunctions.GetCustomAttributes, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.GetCustomAttributes = objvWebSrvFunctionsEN.GetCustomAttributes; //GetCustomAttributes
}
if (arrFldSet.Contains(convWebSrvFunctions.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.FunctionSignature = objvWebSrvFunctionsEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convWebSrvFunctions.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.FuncTypeId = objvWebSrvFunctionsEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(convWebSrvFunctions.FuncTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.FuncTypeName = objvWebSrvFunctionsEN.FuncTypeName; //函数类型名
}
if (arrFldSet.Contains(convWebSrvFunctions.ReturnType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.ReturnType = objvWebSrvFunctionsEN.ReturnType; //返回类型
}
if (arrFldSet.Contains(convWebSrvFunctions.ReturnTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.ReturnTypeFullName = objvWebSrvFunctionsEN.ReturnTypeFullName == "[null]" ? null :  objvWebSrvFunctionsEN.ReturnTypeFullName; //返回类型全名
}
if (arrFldSet.Contains(convWebSrvFunctions.IsKnownType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.IsKnownType = objvWebSrvFunctionsEN.IsKnownType; //是否已知类型
}
if (arrFldSet.Contains(convWebSrvFunctions.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.ReturnTypeId = objvWebSrvFunctionsEN.ReturnTypeId == "[null]" ? null :  objvWebSrvFunctionsEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(convWebSrvFunctions.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.DataTypeName = objvWebSrvFunctionsEN.DataTypeName == "[null]" ? null :  objvWebSrvFunctionsEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convWebSrvFunctions.DataTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.DataTypeAbbr = objvWebSrvFunctionsEN.DataTypeAbbr == "[null]" ? null :  objvWebSrvFunctionsEN.DataTypeAbbr; //数据类型缩写
}
if (arrFldSet.Contains(convWebSrvFunctions.NetSysType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.NetSysType = objvWebSrvFunctionsEN.NetSysType == "[null]" ? null :  objvWebSrvFunctionsEN.NetSysType; //NET系统类型
}
if (arrFldSet.Contains(convWebSrvFunctions.CsType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.CsType = objvWebSrvFunctionsEN.CsType == "[null]" ? null :  objvWebSrvFunctionsEN.CsType; //CS类型
}
if (arrFldSet.Contains(convWebSrvFunctions.JavaType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.JavaType = objvWebSrvFunctionsEN.JavaType == "[null]" ? null :  objvWebSrvFunctionsEN.JavaType; //JAVA类型
}
if (arrFldSet.Contains(convWebSrvFunctions.JavaObjType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.JavaObjType = objvWebSrvFunctionsEN.JavaObjType == "[null]" ? null :  objvWebSrvFunctionsEN.JavaObjType; //JAVA对象类型
}
if (arrFldSet.Contains(convWebSrvFunctions.SwiftType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.SwiftType = objvWebSrvFunctionsEN.SwiftType == "[null]" ? null :  objvWebSrvFunctionsEN.SwiftType; //SwiftType
}
if (arrFldSet.Contains(convWebSrvFunctions.IsNeedQuote, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.IsNeedQuote = objvWebSrvFunctionsEN.IsNeedQuote; //是否需要引号
}
if (arrFldSet.Contains(convWebSrvFunctions.IsAsyncFunc, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.IsAsyncFunc = objvWebSrvFunctionsEN.IsAsyncFunc; //是否异步函数
}
if (arrFldSet.Contains(convWebSrvFunctions.SourceFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.SourceFunction = objvWebSrvFunctionsEN.SourceFunction == "[null]" ? null :  objvWebSrvFunctionsEN.SourceFunction; //来源函数
}
if (arrFldSet.Contains(convWebSrvFunctions.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.IsGeneCode = objvWebSrvFunctionsEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(convWebSrvFunctions.ReturnValueDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.ReturnValueDescription = objvWebSrvFunctionsEN.ReturnValueDescription == "[null]" ? null :  objvWebSrvFunctionsEN.ReturnValueDescription; //返回值说明
}
if (arrFldSet.Contains(convWebSrvFunctions.FuncParaLst, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.FuncParaLst = objvWebSrvFunctionsEN.FuncParaLst == "[null]" ? null :  objvWebSrvFunctionsEN.FuncParaLst; //函数参数列表
}
if (arrFldSet.Contains(convWebSrvFunctions.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.UpdDate = objvWebSrvFunctionsEN.UpdDate == "[null]" ? null :  objvWebSrvFunctionsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convWebSrvFunctions.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.UpdUser = objvWebSrvFunctionsEN.UpdUser == "[null]" ? null :  objvWebSrvFunctionsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convWebSrvFunctions.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.Memo = objvWebSrvFunctionsEN.Memo == "[null]" ? null :  objvWebSrvFunctionsEN.Memo; //说明
}
if (arrFldSet.Contains(convWebSrvFunctions.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFunctionsEN.ClsName = objvWebSrvFunctionsEN.ClsName == "[null]" ? null :  objvWebSrvFunctionsEN.ClsName; //类名
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvWebSrvFunctionsEN objvWebSrvFunctionsEN)
{
try
{
if (objvWebSrvFunctionsEN.NameSpace == "[null]") objvWebSrvFunctionsEN.NameSpace = null; //域名
if (objvWebSrvFunctionsEN.WebSrvUrl == "[null]") objvWebSrvFunctionsEN.WebSrvUrl = null; //WebSrv地址
if (objvWebSrvFunctionsEN.FuncModuleAgcId == "[null]") objvWebSrvFunctionsEN.FuncModuleAgcId = null; //功能模块Id
if (objvWebSrvFunctionsEN.PrjId == "[null]") objvWebSrvFunctionsEN.PrjId = null; //工程Id
if (objvWebSrvFunctionsEN.FunctionName == "[null]") objvWebSrvFunctionsEN.FunctionName = null; //功能名称
if (objvWebSrvFunctionsEN.ReturnTypeFullName == "[null]") objvWebSrvFunctionsEN.ReturnTypeFullName = null; //返回类型全名
if (objvWebSrvFunctionsEN.ReturnTypeId == "[null]") objvWebSrvFunctionsEN.ReturnTypeId = null; //返回类型ID
if (objvWebSrvFunctionsEN.DataTypeName == "[null]") objvWebSrvFunctionsEN.DataTypeName = null; //数据类型名称
if (objvWebSrvFunctionsEN.DataTypeAbbr == "[null]") objvWebSrvFunctionsEN.DataTypeAbbr = null; //数据类型缩写
if (objvWebSrvFunctionsEN.NetSysType == "[null]") objvWebSrvFunctionsEN.NetSysType = null; //NET系统类型
if (objvWebSrvFunctionsEN.CsType == "[null]") objvWebSrvFunctionsEN.CsType = null; //CS类型
if (objvWebSrvFunctionsEN.JavaType == "[null]") objvWebSrvFunctionsEN.JavaType = null; //JAVA类型
if (objvWebSrvFunctionsEN.JavaObjType == "[null]") objvWebSrvFunctionsEN.JavaObjType = null; //JAVA对象类型
if (objvWebSrvFunctionsEN.SwiftType == "[null]") objvWebSrvFunctionsEN.SwiftType = null; //SwiftType
if (objvWebSrvFunctionsEN.SourceFunction == "[null]") objvWebSrvFunctionsEN.SourceFunction = null; //来源函数
if (objvWebSrvFunctionsEN.ReturnValueDescription == "[null]") objvWebSrvFunctionsEN.ReturnValueDescription = null; //返回值说明
if (objvWebSrvFunctionsEN.FuncParaLst == "[null]") objvWebSrvFunctionsEN.FuncParaLst = null; //函数参数列表
if (objvWebSrvFunctionsEN.UpdDate == "[null]") objvWebSrvFunctionsEN.UpdDate = null; //修改日期
if (objvWebSrvFunctionsEN.UpdUser == "[null]") objvWebSrvFunctionsEN.UpdUser = null; //修改者
if (objvWebSrvFunctionsEN.Memo == "[null]") objvWebSrvFunctionsEN.Memo = null; //说明
if (objvWebSrvFunctionsEN.ClsName == "[null]") objvWebSrvFunctionsEN.ClsName = null; //类名
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvWebSrvFunctionsEN objvWebSrvFunctionsEN)
{
 vWebSrvFunctionsDA.CheckProperty4Condition(objvWebSrvFunctionsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTypeBL没有刷新缓存机制(clsFunctionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWebSrvFunctionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebSrvFunctionsBL没有刷新缓存机制(clsWebSrvFunctionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWebSrvClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebSrvClassBL没有刷新缓存机制(clsWebSrvClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WebSrvFunctionId");
//if (arrvWebSrvFunctionsObjLstCache == null)
//{
//arrvWebSrvFunctionsObjLstCache = vWebSrvFunctionsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvFunctionsEN GetObjByWebSrvFunctionIdCache(string strWebSrvFunctionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvWebSrvFunctionsEN._CurrTabName);
List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLst_Sel =
arrvWebSrvFunctionsObjLstCache
.Where(x=> x.WebSrvFunctionId == strWebSrvFunctionId 
);
if (arrvWebSrvFunctionsObjLst_Sel.Count() == 0)
{
   clsvWebSrvFunctionsEN obj = clsvWebSrvFunctionsBL.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvWebSrvFunctionsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetAllvWebSrvFunctionsObjLstCache()
{
//获取缓存中的对象列表
List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLstCache = GetObjLstCache(); 
return arrvWebSrvFunctionsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvWebSrvFunctionsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvWebSrvFunctionsEN._CurrTabName);
List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvWebSrvFunctionsObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvWebSrvFunctionsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvWebSrvFunctionsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}
/// <summary>
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvWebSrvFunctionsEN._RefreshTimeLst.Count == 0) return "";
return clsvWebSrvFunctionsEN._RefreshTimeLst[clsvWebSrvFunctionsEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strWebSrvFunctionId)
{
if (strInFldName != convWebSrvFunctions.WebSrvFunctionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convWebSrvFunctions._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convWebSrvFunctions._AttributeName));
throw new Exception(strMsg);
}
var objvWebSrvFunctions = clsvWebSrvFunctionsBL.GetObjByWebSrvFunctionIdCache(strWebSrvFunctionId);
if (objvWebSrvFunctions == null) return "";
return objvWebSrvFunctions[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvWebSrvFunctionsDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvWebSrvFunctionsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvWebSrvFunctionsDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvWebSrvFunctionsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvWebSrvFunctionsEN objvWebSrvFunctionsCond)
{
List<clsvWebSrvFunctionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFunctionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convWebSrvFunctions._AttributeName)
{
if (objvWebSrvFunctionsCond.IsUpdated(strFldName) == false) continue;
if (objvWebSrvFunctionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvFunctionsCond[strFldName].ToString());
}
else
{
if (objvWebSrvFunctionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvWebSrvFunctionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvFunctionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvWebSrvFunctionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvWebSrvFunctionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvWebSrvFunctionsCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvWebSrvFunctionsDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vWebSrvFunctionsDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vWebSrvFunctionsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}