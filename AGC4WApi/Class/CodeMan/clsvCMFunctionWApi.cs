
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFunctionWApi
 表名:vCMFunction(00050507)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:11
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
public static class  clsvCMFunctionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFunctionId">函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetCmFunctionId(this clsvCMFunctionEN objvCMFunctionEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, convCMFunction.CmFunctionId);
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, convCMFunction.CmFunctionId);
objvCMFunctionEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.CmFunctionId) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.CmFunctionId, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.CmFunctionId] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetCmClassId(this clsvCMFunctionEN objvCMFunctionEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmClassId, convCMFunction.CmClassId);
clsCheckSql.CheckFieldLen(strCmClassId, 8, convCMFunction.CmClassId);
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, convCMFunction.CmClassId);
objvCMFunctionEN.CmClassId = strCmClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.CmClassId) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.CmClassId, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.CmClassId] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetApplicationTypeId(this clsvCMFunctionEN objvCMFunctionEN, int intApplicationTypeId, string strComparisonOp="")
	{
objvCMFunctionEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ApplicationTypeId) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetProgLangTypeId(this clsvCMFunctionEN objvCMFunctionEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convCMFunction.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCMFunction.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCMFunction.ProgLangTypeId);
objvCMFunctionEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ProgLangTypeId) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ProgLangTypeId, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ProgLangTypeId] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetProgLangTypeName(this clsvCMFunctionEN objvCMFunctionEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convCMFunction.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convCMFunction.ProgLangTypeName);
objvCMFunctionEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ProgLangTypeName) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ProgLangTypeName, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ProgLangTypeName] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeSimName">编程语言类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetProgLangTypeSimName(this clsvCMFunctionEN objvCMFunctionEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convCMFunction.ProgLangTypeSimName);
objvCMFunctionEN.ProgLangTypeSimName = strProgLangTypeSimName; //编程语言类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ProgLangTypeSimName) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ProgLangTypeSimName, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ProgLangTypeSimName] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strNameSpace">域名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetNameSpace(this clsvCMFunctionEN objvCMFunctionEN, string strNameSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convCMFunction.NameSpace);
objvCMFunctionEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.NameSpace) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.NameSpace, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.NameSpace] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectPath">工程路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetProjectPath(this clsvCMFunctionEN objvCMFunctionEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProjectPath, 500, convCMFunction.ProjectPath);
objvCMFunctionEN.ProjectPath = strProjectPath; //工程路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ProjectPath) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ProjectPath, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ProjectPath] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFilePath(this clsvCMFunctionEN objvCMFunctionEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFilePath, 500, convCMFunction.FilePath);
objvCMFunctionEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.FilePath) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.FilePath, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.FilePath] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFileName(this clsvCMFunctionEN objvCMFunctionEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 150, convCMFunction.FileName);
objvCMFunctionEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.FileName) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.FileName, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.FileName] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetCodeTypeId(this clsvCMFunctionEN objvCMFunctionEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCMFunction.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCMFunction.CodeTypeId);
objvCMFunctionEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.CodeTypeId) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.CodeTypeId, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.CodeTypeId] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetUserId(this clsvCMFunctionEN objvCMFunctionEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convCMFunction.UserId);
objvCMFunctionEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.UserId) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.UserId, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.UserId] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetPrjId(this clsvCMFunctionEN objvCMFunctionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFunction.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFunction.PrjId);
objvCMFunctionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.PrjId) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.PrjId, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.PrjId] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetPrjName(this clsvCMFunctionEN objvCMFunctionEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMFunction.PrjName);
objvCMFunctionEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.PrjName) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.PrjName, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.PrjName] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFunctionName(this clsvCMFunctionEN objvCMFunctionEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convCMFunction.FunctionName);
objvCMFunctionEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.FunctionName) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.FunctionName, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.FunctionName] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncContent">函数内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFuncContent(this clsvCMFunctionEN objvCMFunctionEN, string strFuncContent, string strComparisonOp="")
	{
objvCMFunctionEN.FuncContent = strFuncContent; //函数内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.FuncContent) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.FuncContent, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.FuncContent] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetKeyWords(this clsvCMFunctionEN objvCMFunctionEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convCMFunction.KeyWords);
objvCMFunctionEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.KeyWords) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.KeyWords, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.KeyWords] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncParaLst">函数参数列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFuncParaLst(this clsvCMFunctionEN objvCMFunctionEN, string strFuncParaLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, convCMFunction.FuncParaLst);
objvCMFunctionEN.FuncParaLst = strFuncParaLst; //函数参数列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.FuncParaLst) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.FuncParaLst, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.FuncParaLst] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncComments">函数注释</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFuncComments(this clsvCMFunctionEN objvCMFunctionEN, string strFuncComments, string strComparisonOp="")
	{
objvCMFunctionEN.FuncComments = strFuncComments; //函数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.FuncComments) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.FuncComments, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.FuncComments] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFunctionSignature(this clsvCMFunctionEN objvCMFunctionEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convCMFunction.FunctionSignature);
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convCMFunction.FunctionSignature);
objvCMFunctionEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.FunctionSignature) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.FunctionSignature, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.FunctionSignature] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnType">返回类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetReturnType(this clsvCMFunctionEN objvCMFunctionEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnType, convCMFunction.ReturnType);
clsCheckSql.CheckFieldLen(strReturnType, 500, convCMFunction.ReturnType);
objvCMFunctionEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ReturnType) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ReturnType, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ReturnType] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsKnownType">是否已知类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetIsKnownType(this clsvCMFunctionEN objvCMFunctionEN, bool bolIsKnownType, string strComparisonOp="")
	{
objvCMFunctionEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.IsKnownType) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.IsKnownType, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.IsKnownType] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetReturnTypeId(this clsvCMFunctionEN objvCMFunctionEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convCMFunction.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convCMFunction.ReturnTypeId);
objvCMFunctionEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ReturnTypeId) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ReturnTypeId, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ReturnTypeId] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassNameLst">类名列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetClassNameLst(this clsvCMFunctionEN objvCMFunctionEN, string strClassNameLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClassNameLst, 500, convCMFunction.ClassNameLst);
objvCMFunctionEN.ClassNameLst = strClassNameLst; //类名列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ClassNameLst) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ClassNameLst, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ClassNameLst] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetUpdDate(this clsvCMFunctionEN objvCMFunctionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFunction.UpdDate);
objvCMFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.UpdDate) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.UpdDate, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.UpdDate] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetUpdUser(this clsvCMFunctionEN objvCMFunctionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFunction.UpdUser);
objvCMFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.UpdUser) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.UpdUser, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.UpdUser] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetMemo(this clsvCMFunctionEN objvCMFunctionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFunction.Memo);
objvCMFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.Memo) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.Memo, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.Memo] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "intParaNum">参数个数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetParaNum(this clsvCMFunctionEN objvCMFunctionEN, int intParaNum, string strComparisonOp="")
	{
objvCMFunctionEN.ParaNum = intParaNum; //参数个数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ParaNum) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ParaNum, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ParaNum] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetClsName(this clsvCMFunctionEN objvCMFunctionEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsName, 100, convCMFunction.ClsName);
objvCMFunctionEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionEN.dicFldComparisonOp.ContainsKey(convCMFunction.ClsName) == false)
{
objvCMFunctionEN.dicFldComparisonOp.Add(convCMFunction.ClsName, strComparisonOp);
}
else
{
objvCMFunctionEN.dicFldComparisonOp[convCMFunction.ClsName] = strComparisonOp;
}
}
return objvCMFunctionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMFunctionEN objvCMFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMFunctionCond.IsUpdated(convCMFunction.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.CmFunctionId, objvCMFunctionCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.CmClassId) == true)
{
string strComparisonOpCmClassId = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.CmClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.CmClassId, objvCMFunctionCond.CmClassId, strComparisonOpCmClassId);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFunction.ApplicationTypeId, objvCMFunctionCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.ProgLangTypeId, objvCMFunctionCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.ProgLangTypeName, objvCMFunctionCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ProgLangTypeSimName) == true)
{
string strComparisonOpProgLangTypeSimName = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ProgLangTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.ProgLangTypeSimName, objvCMFunctionCond.ProgLangTypeSimName, strComparisonOpProgLangTypeSimName);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.NameSpace) == true)
{
string strComparisonOpNameSpace = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.NameSpace, objvCMFunctionCond.NameSpace, strComparisonOpNameSpace);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ProjectPath) == true)
{
string strComparisonOpProjectPath = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ProjectPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.ProjectPath, objvCMFunctionCond.ProjectPath, strComparisonOpProjectPath);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.FilePath) == true)
{
string strComparisonOpFilePath = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.FilePath, objvCMFunctionCond.FilePath, strComparisonOpFilePath);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.FileName) == true)
{
string strComparisonOpFileName = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.FileName, objvCMFunctionCond.FileName, strComparisonOpFileName);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.CodeTypeId, objvCMFunctionCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.UserId) == true)
{
string strComparisonOpUserId = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.UserId, objvCMFunctionCond.UserId, strComparisonOpUserId);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.PrjId) == true)
{
string strComparisonOpPrjId = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.PrjId, objvCMFunctionCond.PrjId, strComparisonOpPrjId);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.PrjName) == true)
{
string strComparisonOpPrjName = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.PrjName, objvCMFunctionCond.PrjName, strComparisonOpPrjName);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.FunctionName) == true)
{
string strComparisonOpFunctionName = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.FunctionName, objvCMFunctionCond.FunctionName, strComparisonOpFunctionName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objvCMFunctionCond.IsUpdated(convCMFunction.KeyWords) == true)
{
string strComparisonOpKeyWords = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.KeyWords, objvCMFunctionCond.KeyWords, strComparisonOpKeyWords);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.FuncParaLst) == true)
{
string strComparisonOpFuncParaLst = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.FuncParaLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.FuncParaLst, objvCMFunctionCond.FuncParaLst, strComparisonOpFuncParaLst);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objvCMFunctionCond.IsUpdated(convCMFunction.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.FunctionSignature, objvCMFunctionCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ReturnType) == true)
{
string strComparisonOpReturnType = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.ReturnType, objvCMFunctionCond.ReturnType, strComparisonOpReturnType);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.IsKnownType) == true)
{
if (objvCMFunctionCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFunction.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFunction.IsKnownType);
}
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.ReturnTypeId, objvCMFunctionCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ClassNameLst) == true)
{
string strComparisonOpClassNameLst = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ClassNameLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.ClassNameLst, objvCMFunctionCond.ClassNameLst, strComparisonOpClassNameLst);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.UpdDate, objvCMFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.UpdUser, objvCMFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.Memo) == true)
{
string strComparisonOpMemo = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.Memo, objvCMFunctionCond.Memo, strComparisonOpMemo);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ParaNum) == true)
{
string strComparisonOpParaNum = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ParaNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFunction.ParaNum, objvCMFunctionCond.ParaNum, strComparisonOpParaNum);
}
if (objvCMFunctionCond.IsUpdated(convCMFunction.ClsName) == true)
{
string strComparisonOpClsName = objvCMFunctionCond.dicFldComparisonOp[convCMFunction.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunction.ClsName, objvCMFunctionCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCM函数(vCMFunction)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMFunctionWApi
{
private static readonly string mstrApiControllerName = "vCMFunctionApi";

 public clsvCMFunctionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CmFunctionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM函数]...","0");
List<clsvCMFunctionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CmFunctionId";
objDDL.DataTextField="UserId";
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

public static void BindCbo_CmFunctionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMFunction.CmFunctionId); 
List<clsvCMFunctionEN> arrObjLst = clsvCMFunctionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN()
{
CmFunctionId = "0",
UserId = "选[vCM函数]..."
};
arrObjLst.Insert(0, objvCMFunctionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCMFunction.CmFunctionId;
objComboBox.DisplayMember = convCMFunction.UserId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFunctionEN GetObjByCmFunctionId(string strCmFunctionId)
{
if (strCmFunctionId == "") return null;
string strAction = "GetObjByCmFunctionId";
clsvCMFunctionEN objvCMFunctionEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFunctionId"] = strCmFunctionId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCMFunctionEN = JsonConvert.DeserializeObject<clsvCMFunctionEN>(strJson);
return objvCMFunctionEN;
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
public static clsvCMFunctionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMFunctionEN objvCMFunctionEN;
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
objvCMFunctionEN = JsonConvert.DeserializeObject<clsvCMFunctionEN>(strJson);
return objvCMFunctionEN;
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
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFunctionEN GetObjByCmFunctionIdCache(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCMFunctionEN._CurrTabName);
List<clsvCMFunctionEN> arrvCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionEN> arrvCMFunctionObjLst_Sel =
from objvCMFunctionEN in arrvCMFunctionObjLstCache
where objvCMFunctionEN.CmFunctionId == strCmFunctionId 
select objvCMFunctionEN;
if (arrvCMFunctionObjLst_Sel.Count() == 0)
{
   clsvCMFunctionEN obj = clsvCMFunctionWApi.GetObjByCmFunctionId(strCmFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCMFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserIdByCmFunctionIdCache(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return "";
//初始化列表缓存
List<clsvCMFunctionEN> arrvCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionEN> arrvCMFunctionObjLst_Sel1 =
from objvCMFunctionEN in arrvCMFunctionObjLstCache
where objvCMFunctionEN.CmFunctionId == strCmFunctionId 
select objvCMFunctionEN;
List <clsvCMFunctionEN> arrvCMFunctionObjLst_Sel = new List<clsvCMFunctionEN>();
foreach (clsvCMFunctionEN obj in arrvCMFunctionObjLst_Sel1)
{
arrvCMFunctionObjLst_Sel.Add(obj);
}
if (arrvCMFunctionObjLst_Sel.Count > 0)
{
return arrvCMFunctionObjLst_Sel[0].UserId;
}
string strErrMsgForGetObjById = string.Format("在vCMFunction对象缓存列表中,找不到记录[CmFunctionId = {0}](函数:{1})", strCmFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCMFunctionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmFunctionIdCache(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return "";
//初始化列表缓存
List<clsvCMFunctionEN> arrvCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionEN> arrvCMFunctionObjLst_Sel1 =
from objvCMFunctionEN in arrvCMFunctionObjLstCache
where objvCMFunctionEN.CmFunctionId == strCmFunctionId 
select objvCMFunctionEN;
List <clsvCMFunctionEN> arrvCMFunctionObjLst_Sel = new List<clsvCMFunctionEN>();
foreach (clsvCMFunctionEN obj in arrvCMFunctionObjLst_Sel1)
{
arrvCMFunctionObjLst_Sel.Add(obj);
}
if (arrvCMFunctionObjLst_Sel.Count > 0)
{
return arrvCMFunctionObjLst_Sel[0].UserId;
}
string strErrMsgForGetObjById = string.Format("在vCMFunction对象缓存列表中,找不到记录的相关名称[CmFunctionId = {0}](函数:{1})", strCmFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCMFunctionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionEN> GetObjLst(string strWhereCond)
{
 List<clsvCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionEN>>(strJson);
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
 /// <param name = "arrCmFunctionId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionEN> GetObjLstByCmFunctionIdLst(List<string> arrCmFunctionId)
{
 List<clsvCMFunctionEN> arrObjLst; 
string strAction = "GetObjLstByCmFunctionIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmFunctionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionEN>>(strJson);
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
 /// <param name = "arrCmFunctionId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCMFunctionEN> GetObjLstByCmFunctionIdLstCache(List<string> arrCmFunctionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCMFunctionEN._CurrTabName);
List<clsvCMFunctionEN> arrvCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionEN> arrvCMFunctionObjLst_Sel =
from objvCMFunctionEN in arrvCMFunctionObjLstCache
where arrCmFunctionId.Contains(objvCMFunctionEN.CmFunctionId)
select objvCMFunctionEN;
return arrvCMFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionEN>>(strJson);
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
public static List<clsvCMFunctionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionEN>>(strJson);
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
public static List<clsvCMFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionEN>>(strJson);
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
public static List<clsvCMFunctionEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionEN>>(strJson);
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
public static bool IsExist(string strCmFunctionId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFunctionId"] = strCmFunctionId
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
 /// <param name = "objvCMFunctionENS">源对象</param>
 /// <param name = "objvCMFunctionENT">目标对象</param>
 public static void CopyTo(clsvCMFunctionEN objvCMFunctionENS, clsvCMFunctionEN objvCMFunctionENT)
{
try
{
objvCMFunctionENT.CmFunctionId = objvCMFunctionENS.CmFunctionId; //函数Id
objvCMFunctionENT.CmClassId = objvCMFunctionENS.CmClassId; //类Id
objvCMFunctionENT.ApplicationTypeId = objvCMFunctionENS.ApplicationTypeId; //应用程序类型ID
objvCMFunctionENT.ProgLangTypeId = objvCMFunctionENS.ProgLangTypeId; //编程语言类型Id
objvCMFunctionENT.ProgLangTypeName = objvCMFunctionENS.ProgLangTypeName; //编程语言类型名
objvCMFunctionENT.ProgLangTypeSimName = objvCMFunctionENS.ProgLangTypeSimName; //编程语言类型简称
objvCMFunctionENT.NameSpace = objvCMFunctionENS.NameSpace; //域名
objvCMFunctionENT.ProjectPath = objvCMFunctionENS.ProjectPath; //工程路径
objvCMFunctionENT.FilePath = objvCMFunctionENS.FilePath; //文件路径
objvCMFunctionENT.FileName = objvCMFunctionENS.FileName; //文件名
objvCMFunctionENT.CodeTypeId = objvCMFunctionENS.CodeTypeId; //代码类型Id
objvCMFunctionENT.UserId = objvCMFunctionENS.UserId; //用户Id
objvCMFunctionENT.PrjId = objvCMFunctionENS.PrjId; //工程Id
objvCMFunctionENT.PrjName = objvCMFunctionENS.PrjName; //工程名称
objvCMFunctionENT.FunctionName = objvCMFunctionENS.FunctionName; //功能名称
objvCMFunctionENT.FuncContent = objvCMFunctionENS.FuncContent; //函数内容
objvCMFunctionENT.KeyWords = objvCMFunctionENS.KeyWords; //关键字
objvCMFunctionENT.FuncParaLst = objvCMFunctionENS.FuncParaLst; //函数参数列表
objvCMFunctionENT.FuncComments = objvCMFunctionENS.FuncComments; //函数注释
objvCMFunctionENT.FunctionSignature = objvCMFunctionENS.FunctionSignature; //函数签名
objvCMFunctionENT.ReturnType = objvCMFunctionENS.ReturnType; //返回类型
objvCMFunctionENT.IsKnownType = objvCMFunctionENS.IsKnownType; //是否已知类型
objvCMFunctionENT.ReturnTypeId = objvCMFunctionENS.ReturnTypeId; //返回类型ID
objvCMFunctionENT.ClassNameLst = objvCMFunctionENS.ClassNameLst; //类名列表
objvCMFunctionENT.UpdDate = objvCMFunctionENS.UpdDate; //修改日期
objvCMFunctionENT.UpdUser = objvCMFunctionENS.UpdUser; //修改者
objvCMFunctionENT.Memo = objvCMFunctionENS.Memo; //说明
objvCMFunctionENT.ParaNum = objvCMFunctionENS.ParaNum; //参数个数
objvCMFunctionENT.ClsName = objvCMFunctionENS.ClsName; //类名
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
public static DataTable ToDataTable(List<clsvCMFunctionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMFunctionEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMFunctionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMFunctionEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMFunctionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMFunctionEN._AttributeName)
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
string strKey = string.Format("{0}", clsvCMFunctionEN._CurrTabName);
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
public static List<clsvCMFunctionEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvCMFunctionEN._CurrTabName;
List<clsvCMFunctionEN> arrvCMFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCMFunctionObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMFunctionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMFunction.CmFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.CmClassId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMFunction.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.ProgLangTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.NameSpace, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.ProjectPath, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.FuncContent, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.FuncParaLst, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.FuncComments, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.ReturnType, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.IsKnownType, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCMFunction.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.ClassNameLst, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunction.ParaNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMFunction.ClsName, Type.GetType("System.String"));
foreach (clsvCMFunctionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMFunction.CmFunctionId] = objInFor[convCMFunction.CmFunctionId];
objDR[convCMFunction.CmClassId] = objInFor[convCMFunction.CmClassId];
objDR[convCMFunction.ApplicationTypeId] = objInFor[convCMFunction.ApplicationTypeId];
objDR[convCMFunction.ProgLangTypeId] = objInFor[convCMFunction.ProgLangTypeId];
objDR[convCMFunction.ProgLangTypeName] = objInFor[convCMFunction.ProgLangTypeName];
objDR[convCMFunction.ProgLangTypeSimName] = objInFor[convCMFunction.ProgLangTypeSimName];
objDR[convCMFunction.NameSpace] = objInFor[convCMFunction.NameSpace];
objDR[convCMFunction.ProjectPath] = objInFor[convCMFunction.ProjectPath];
objDR[convCMFunction.FilePath] = objInFor[convCMFunction.FilePath];
objDR[convCMFunction.FileName] = objInFor[convCMFunction.FileName];
objDR[convCMFunction.CodeTypeId] = objInFor[convCMFunction.CodeTypeId];
objDR[convCMFunction.UserId] = objInFor[convCMFunction.UserId];
objDR[convCMFunction.PrjId] = objInFor[convCMFunction.PrjId];
objDR[convCMFunction.PrjName] = objInFor[convCMFunction.PrjName];
objDR[convCMFunction.FunctionName] = objInFor[convCMFunction.FunctionName];
objDR[convCMFunction.FuncContent] = objInFor[convCMFunction.FuncContent];
objDR[convCMFunction.KeyWords] = objInFor[convCMFunction.KeyWords];
objDR[convCMFunction.FuncParaLst] = objInFor[convCMFunction.FuncParaLst];
objDR[convCMFunction.FuncComments] = objInFor[convCMFunction.FuncComments];
objDR[convCMFunction.FunctionSignature] = objInFor[convCMFunction.FunctionSignature];
objDR[convCMFunction.ReturnType] = objInFor[convCMFunction.ReturnType];
objDR[convCMFunction.IsKnownType] = objInFor[convCMFunction.IsKnownType];
objDR[convCMFunction.ReturnTypeId] = objInFor[convCMFunction.ReturnTypeId];
objDR[convCMFunction.ClassNameLst] = objInFor[convCMFunction.ClassNameLst];
objDR[convCMFunction.UpdDate] = objInFor[convCMFunction.UpdDate];
objDR[convCMFunction.UpdUser] = objInFor[convCMFunction.UpdUser];
objDR[convCMFunction.Memo] = objInFor[convCMFunction.Memo];
objDR[convCMFunction.ParaNum] = objInFor[convCMFunction.ParaNum];
objDR[convCMFunction.ClsName] = objInFor[convCMFunction.ClsName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}