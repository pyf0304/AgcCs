
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMClassWApi
 表名:vCMClass(00050506)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 23:10:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
 框架-层名:WA_访问层(CS)(WA_Access)
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
public static class  clsvCMClassWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetCmClassId(this clsvCMClassEN objvCMClassEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmClassId, 8, convCMClass.CmClassId);
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, convCMClass.CmClassId);
objvCMClassEN.CmClassId = strCmClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.CmClassId) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.CmClassId, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.CmClassId] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetClassName(this clsvCMClassEN objvCMClassEN, string strClassName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassName, convCMClass.ClsName);
clsCheckSql.CheckFieldLen(strClassName, 100, convCMClass.ClsName);
objvCMClassEN.ClsName = strClassName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.ClsName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.ClsName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.ClsName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetApplicationTypeId(this clsvCMClassEN objvCMClassEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convCMClass.ApplicationTypeId);
objvCMClassEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.ApplicationTypeId) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetApplicationTypeName(this clsvCMClassEN objvCMClassEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convCMClass.ApplicationTypeName);
objvCMClassEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.ApplicationTypeName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.ApplicationTypeName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.ApplicationTypeName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetApplicationTypeSimName(this clsvCMClassEN objvCMClassEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMClass.ApplicationTypeSimName);
objvCMClassEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.ApplicationTypeSimName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetProgLangTypeId(this clsvCMClassEN objvCMClassEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convCMClass.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCMClass.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCMClass.ProgLangTypeId);
objvCMClassEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.ProgLangTypeId) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.ProgLangTypeId, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.ProgLangTypeId] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetProgLangTypeName(this clsvCMClassEN objvCMClassEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convCMClass.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convCMClass.ProgLangTypeName);
objvCMClassEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.ProgLangTypeName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.ProgLangTypeName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.ProgLangTypeName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeSimName">编程语言类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetProgLangTypeSimName(this clsvCMClassEN objvCMClassEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convCMClass.ProgLangTypeSimName);
objvCMClassEN.ProgLangTypeSimName = strProgLangTypeSimName; //编程语言类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.ProgLangTypeSimName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.ProgLangTypeSimName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.ProgLangTypeSimName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetTabName(this clsvCMClassEN objvCMClassEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convCMClass.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convCMClass.TabName);
objvCMClassEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.TabName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.TabName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.TabName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strNameSpace">域名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetNameSpace(this clsvCMClassEN objvCMClassEN, string strNameSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convCMClass.NameSpace);
objvCMClassEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.NameSpace) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.NameSpace, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.NameSpace] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectPath">工程路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetProjectPath(this clsvCMClassEN objvCMClassEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, convCMClass.ProjectPath);
clsCheckSql.CheckFieldLen(strProjectPath, 500, convCMClass.ProjectPath);
objvCMClassEN.ProjectPath = strProjectPath; //工程路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.ProjectPath) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.ProjectPath, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.ProjectPath] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFilePath(this clsvCMClassEN objvCMClassEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convCMClass.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convCMClass.FilePath);
objvCMClassEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.FilePath) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.FilePath, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.FilePath] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFileName(this clsvCMClassEN objvCMClassEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convCMClass.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, convCMClass.FileName);
objvCMClassEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.FileName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.FileName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.FileName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileText">文件内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFileText(this clsvCMClassEN objvCMClassEN, string strFileText, string strComparisonOp="")
	{
objvCMClassEN.FileText = strFileText; //文件内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.FileText) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.FileText, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.FileText] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFuncModuleAgcId(this clsvCMClassEN objvCMClassEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convCMClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMClass.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMClass.FuncModuleAgcId);
objvCMClassEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.FuncModuleAgcId) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.FuncModuleAgcId, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.FuncModuleAgcId] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFuncModuleName(this clsvCMClassEN objvCMClassEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCMClass.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMClass.FuncModuleName);
objvCMClassEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.FuncModuleName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.FuncModuleName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.FuncModuleName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">功能模块简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFuncModuleNameSim(this clsvCMClassEN objvCMClassEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convCMClass.FuncModuleNameSim);
objvCMClassEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.FuncModuleNameSim) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.FuncModuleNameSim, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.FuncModuleNameSim] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetCodeTypeId(this clsvCMClassEN objvCMClassEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convCMClass.CodeTypeId);
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCMClass.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCMClass.CodeTypeId);
objvCMClassEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.CodeTypeId) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.CodeTypeId, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.CodeTypeId] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetCodeTypeName(this clsvCMClassEN objvCMClassEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convCMClass.CodeTypeName);
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convCMClass.CodeTypeName);
objvCMClassEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.CodeTypeName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.CodeTypeName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.CodeTypeName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeSimName">简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetCodeTypeSimName(this clsvCMClassEN objvCMClassEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, convCMClass.CodeTypeSimName);
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convCMClass.CodeTypeSimName);
objvCMClassEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.CodeTypeSimName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.CodeTypeSimName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.CodeTypeSimName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetUserId(this clsvCMClassEN objvCMClassEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convCMClass.UserId);
objvCMClassEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.UserId) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.UserId, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.UserId] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetPrjId(this clsvCMClassEN objvCMClassEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMClass.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMClass.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMClass.PrjId);
objvCMClassEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.PrjId) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.PrjId, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.PrjId] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetPrjName(this clsvCMClassEN objvCMClassEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMClass.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMClass.PrjName);
objvCMClassEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.PrjName) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.PrjName, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.PrjName] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsOpen">是否开放</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetIsOpen(this clsvCMClassEN objvCMClassEN, bool bolIsOpen, string strComparisonOp="")
	{
objvCMClassEN.IsOpen = bolIsOpen; //是否开放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.IsOpen) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.IsOpen, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.IsOpen] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetUpdDate(this clsvCMClassEN objvCMClassEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMClass.UpdDate);
objvCMClassEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.UpdDate) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.UpdDate, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.UpdDate] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetUpdUser(this clsvCMClassEN objvCMClassEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMClass.UpdUser);
objvCMClassEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.UpdUser) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.UpdUser, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.UpdUser] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetMemo(this clsvCMClassEN objvCMClassEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMClass.Memo);
objvCMClassEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.Memo) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.Memo, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.Memo] = strComparisonOp;
}
}
return objvCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "intFuncNum">函数个数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFuncNum(this clsvCMClassEN objvCMClassEN, int intFuncNum, string strComparisonOp="")
	{
objvCMClassEN.FuncNum = intFuncNum; //函数个数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassEN.dicFldComparisonOp.ContainsKey(convCMClass.FuncNum) == false)
{
objvCMClassEN.dicFldComparisonOp.Add(convCMClass.FuncNum, strComparisonOp);
}
else
{
objvCMClassEN.dicFldComparisonOp[convCMClass.FuncNum] = strComparisonOp;
}
}
return objvCMClassEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMClassEN objvCMClassCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMClassCond.IsUpdated(convCMClass.CmClassId) == true)
{
string strComparisonOpCmClassId = objvCMClassCond.dicFldComparisonOp[convCMClass.CmClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.CmClassId, objvCMClassCond.CmClassId, strComparisonOpCmClassId);
}
if (objvCMClassCond.IsUpdated(convCMClass.ClsName) == true)
{
string strComparisonOpClassName = objvCMClassCond.dicFldComparisonOp[convCMClass.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.ClsName, objvCMClassCond.ClsName, strComparisonOpClassName);
}
if (objvCMClassCond.IsUpdated(convCMClass.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMClassCond.dicFldComparisonOp[convCMClass.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMClass.ApplicationTypeId, objvCMClassCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMClassCond.IsUpdated(convCMClass.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvCMClassCond.dicFldComparisonOp[convCMClass.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.ApplicationTypeName, objvCMClassCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvCMClassCond.IsUpdated(convCMClass.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvCMClassCond.dicFldComparisonOp[convCMClass.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.ApplicationTypeSimName, objvCMClassCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvCMClassCond.IsUpdated(convCMClass.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvCMClassCond.dicFldComparisonOp[convCMClass.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.ProgLangTypeId, objvCMClassCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvCMClassCond.IsUpdated(convCMClass.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvCMClassCond.dicFldComparisonOp[convCMClass.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.ProgLangTypeName, objvCMClassCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvCMClassCond.IsUpdated(convCMClass.ProgLangTypeSimName) == true)
{
string strComparisonOpProgLangTypeSimName = objvCMClassCond.dicFldComparisonOp[convCMClass.ProgLangTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.ProgLangTypeSimName, objvCMClassCond.ProgLangTypeSimName, strComparisonOpProgLangTypeSimName);
}
if (objvCMClassCond.IsUpdated(convCMClass.TabName) == true)
{
string strComparisonOpTabName = objvCMClassCond.dicFldComparisonOp[convCMClass.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.TabName, objvCMClassCond.TabName, strComparisonOpTabName);
}
if (objvCMClassCond.IsUpdated(convCMClass.NameSpace) == true)
{
string strComparisonOpNameSpace = objvCMClassCond.dicFldComparisonOp[convCMClass.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.NameSpace, objvCMClassCond.NameSpace, strComparisonOpNameSpace);
}
if (objvCMClassCond.IsUpdated(convCMClass.ProjectPath) == true)
{
string strComparisonOpProjectPath = objvCMClassCond.dicFldComparisonOp[convCMClass.ProjectPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.ProjectPath, objvCMClassCond.ProjectPath, strComparisonOpProjectPath);
}
if (objvCMClassCond.IsUpdated(convCMClass.FilePath) == true)
{
string strComparisonOpFilePath = objvCMClassCond.dicFldComparisonOp[convCMClass.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.FilePath, objvCMClassCond.FilePath, strComparisonOpFilePath);
}
if (objvCMClassCond.IsUpdated(convCMClass.FileName) == true)
{
string strComparisonOpFileName = objvCMClassCond.dicFldComparisonOp[convCMClass.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.FileName, objvCMClassCond.FileName, strComparisonOpFileName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objvCMClassCond.IsUpdated(convCMClass.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvCMClassCond.dicFldComparisonOp[convCMClass.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.FuncModuleAgcId, objvCMClassCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvCMClassCond.IsUpdated(convCMClass.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCMClassCond.dicFldComparisonOp[convCMClass.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.FuncModuleName, objvCMClassCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCMClassCond.IsUpdated(convCMClass.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvCMClassCond.dicFldComparisonOp[convCMClass.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.FuncModuleNameSim, objvCMClassCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvCMClassCond.IsUpdated(convCMClass.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvCMClassCond.dicFldComparisonOp[convCMClass.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.CodeTypeId, objvCMClassCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvCMClassCond.IsUpdated(convCMClass.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvCMClassCond.dicFldComparisonOp[convCMClass.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.CodeTypeName, objvCMClassCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvCMClassCond.IsUpdated(convCMClass.CodeTypeSimName) == true)
{
string strComparisonOpCodeTypeSimName = objvCMClassCond.dicFldComparisonOp[convCMClass.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.CodeTypeSimName, objvCMClassCond.CodeTypeSimName, strComparisonOpCodeTypeSimName);
}
if (objvCMClassCond.IsUpdated(convCMClass.UserId) == true)
{
string strComparisonOpUserId = objvCMClassCond.dicFldComparisonOp[convCMClass.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.UserId, objvCMClassCond.UserId, strComparisonOpUserId);
}
if (objvCMClassCond.IsUpdated(convCMClass.PrjId) == true)
{
string strComparisonOpPrjId = objvCMClassCond.dicFldComparisonOp[convCMClass.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.PrjId, objvCMClassCond.PrjId, strComparisonOpPrjId);
}
if (objvCMClassCond.IsUpdated(convCMClass.PrjName) == true)
{
string strComparisonOpPrjName = objvCMClassCond.dicFldComparisonOp[convCMClass.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.PrjName, objvCMClassCond.PrjName, strComparisonOpPrjName);
}
if (objvCMClassCond.IsUpdated(convCMClass.IsOpen) == true)
{
if (objvCMClassCond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMClass.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMClass.IsOpen);
}
}
if (objvCMClassCond.IsUpdated(convCMClass.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMClassCond.dicFldComparisonOp[convCMClass.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.UpdDate, objvCMClassCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMClassCond.IsUpdated(convCMClass.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMClassCond.dicFldComparisonOp[convCMClass.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.UpdUser, objvCMClassCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMClassCond.IsUpdated(convCMClass.Memo) == true)
{
string strComparisonOpMemo = objvCMClassCond.dicFldComparisonOp[convCMClass.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.Memo, objvCMClassCond.Memo, strComparisonOpMemo);
}
if (objvCMClassCond.IsUpdated(convCMClass.FuncNum) == true)
{
string strComparisonOpFuncNum = objvCMClassCond.dicFldComparisonOp[convCMClass.FuncNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMClass.FuncNum, objvCMClassCond.FuncNum, strComparisonOpFuncNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 获取唯一性条件串--vCMClass(vCM类), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ClassName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvCMClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsvCMClassEN objvCMClassEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvCMClassEN == null) return "";
if (objvCMClassEN.CmClassId == null || objvCMClassEN.CmClassId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objvCMClassEN.PrjId);
 sbCondition.AppendFormat(" and ClassName = '{0}'", objvCMClassEN.ClsName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmClassId !=  '{0}'", objvCMClassEN.CmClassId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objvCMClassEN.PrjId);
 sbCondition.AppendFormat(" and ClassName = '{0}'", objvCMClassEN.ClsName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// vCM类(vCMClass)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMClassWApi
{
private static readonly string mstrApiControllerName = "vCMClassApi";

 public clsvCMClassWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CmClassId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM类]...","0");
List<clsvCMClassEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CmClassId";
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

public static void BindCbo_CmClassId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMClass.CmClassId); 
List<clsvCMClassEN> arrObjLst = clsvCMClassWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCMClassEN objvCMClassEN = new clsvCMClassEN()
{
CmClassId = "0",
UserId = "选[vCM类]..."
};
arrObjLst.Insert(0, objvCMClassEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCMClass.CmClassId;
objComboBox.DisplayMember = convCMClass.UserId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMClassEN GetObjByCmClassId(string strCmClassId)
{
string strAction = "GetObjByCmClassId";
clsvCMClassEN objvCMClassEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmClassId"] = strCmClassId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCMClassEN = JsonConvert.DeserializeObject<clsvCMClassEN>(strJson);
return objvCMClassEN;
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
public static clsvCMClassEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMClassEN objvCMClassEN;
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
objvCMClassEN = JsonConvert.DeserializeObject<clsvCMClassEN>(strJson);
return objvCMClassEN;
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
//该表没有使用Cache,不需要生成[GetUserIdByCmClassIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMClassEN> GetObjLst(string strWhereCond)
{
 List<clsvCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMClassEN>>(strJson);
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
 /// <param name = "arrCmClassId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMClassEN> GetObjLstByCmClassIdLst(List<string> arrCmClassId)
{
 List<clsvCMClassEN> arrObjLst; 
string strAction = "GetObjLstByCmClassIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmClassId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMClassEN>>(strJson);
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
public static List<clsvCMClassEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMClassEN>>(strJson);
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
public static List<clsvCMClassEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMClassEN>>(strJson);
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
public static List<clsvCMClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMClassEN>>(strJson);
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
public static List<clsvCMClassEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMClassEN>>(strJson);
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
public static bool IsExist(string strCmClassId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmClassId"] = strCmClassId
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
 /// <param name = "objvCMClassENS">源对象</param>
 /// <param name = "objvCMClassENT">目标对象</param>
 public static void CopyTo(clsvCMClassEN objvCMClassENS, clsvCMClassEN objvCMClassENT)
{
try
{
objvCMClassENT.CmClassId = objvCMClassENS.CmClassId; //类Id
objvCMClassENT.ClsName = objvCMClassENS.ClsName; //类名
objvCMClassENT.ApplicationTypeId = objvCMClassENS.ApplicationTypeId; //应用程序类型ID
objvCMClassENT.ApplicationTypeName = objvCMClassENS.ApplicationTypeName; //应用程序类型名称
objvCMClassENT.ApplicationTypeSimName = objvCMClassENS.ApplicationTypeSimName; //应用程序类型简称
objvCMClassENT.ProgLangTypeId = objvCMClassENS.ProgLangTypeId; //编程语言类型Id
objvCMClassENT.ProgLangTypeName = objvCMClassENS.ProgLangTypeName; //编程语言类型名
objvCMClassENT.ProgLangTypeSimName = objvCMClassENS.ProgLangTypeSimName; //编程语言类型简称
objvCMClassENT.TabName = objvCMClassENS.TabName; //表名
objvCMClassENT.NameSpace = objvCMClassENS.NameSpace; //域名
objvCMClassENT.ProjectPath = objvCMClassENS.ProjectPath; //工程路径
objvCMClassENT.FilePath = objvCMClassENS.FilePath; //文件路径
objvCMClassENT.FileName = objvCMClassENS.FileName; //文件名
objvCMClassENT.FileText = objvCMClassENS.FileText; //文件内容
objvCMClassENT.FuncModuleAgcId = objvCMClassENS.FuncModuleAgcId; //功能模块Id
objvCMClassENT.FuncModuleName = objvCMClassENS.FuncModuleName; //功能模块名称
objvCMClassENT.FuncModuleNameSim = objvCMClassENS.FuncModuleNameSim; //功能模块简称
objvCMClassENT.CodeTypeId = objvCMClassENS.CodeTypeId; //代码类型Id
objvCMClassENT.CodeTypeName = objvCMClassENS.CodeTypeName; //代码类型名
objvCMClassENT.CodeTypeSimName = objvCMClassENS.CodeTypeSimName; //简称
objvCMClassENT.UserId = objvCMClassENS.UserId; //用户Id
objvCMClassENT.PrjId = objvCMClassENS.PrjId; //工程ID
objvCMClassENT.PrjName = objvCMClassENS.PrjName; //工程名称
objvCMClassENT.IsOpen = objvCMClassENS.IsOpen; //是否开放
objvCMClassENT.UpdDate = objvCMClassENS.UpdDate; //修改日期
objvCMClassENT.UpdUser = objvCMClassENS.UpdUser; //修改者
objvCMClassENT.Memo = objvCMClassENS.Memo; //说明
objvCMClassENT.FuncNum = objvCMClassENS.FuncNum; //函数个数
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
public static DataTable ToDataTable(List<clsvCMClassEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMClassEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMClassEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMClassEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMClassEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMClassEN.AttributeName)
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
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvCMClassEN._CurrTabName);
CacheHelper.Remove(strKey);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMClassEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMClass.CmClassId, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.ClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMClass.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.ProgLangTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.NameSpace, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.ProjectPath, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.FileText, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.CodeTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.IsOpen, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCMClass.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCMClass.FuncNum, Type.GetType("System.Int32"));
foreach (clsvCMClassEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMClass.CmClassId] = objInFor[convCMClass.CmClassId];
objDR[convCMClass.ClsName] = objInFor[convCMClass.ClsName];
objDR[convCMClass.ApplicationTypeId] = objInFor[convCMClass.ApplicationTypeId];
objDR[convCMClass.ApplicationTypeName] = objInFor[convCMClass.ApplicationTypeName];
objDR[convCMClass.ApplicationTypeSimName] = objInFor[convCMClass.ApplicationTypeSimName];
objDR[convCMClass.ProgLangTypeId] = objInFor[convCMClass.ProgLangTypeId];
objDR[convCMClass.ProgLangTypeName] = objInFor[convCMClass.ProgLangTypeName];
objDR[convCMClass.ProgLangTypeSimName] = objInFor[convCMClass.ProgLangTypeSimName];
objDR[convCMClass.TabName] = objInFor[convCMClass.TabName];
objDR[convCMClass.NameSpace] = objInFor[convCMClass.NameSpace];
objDR[convCMClass.ProjectPath] = objInFor[convCMClass.ProjectPath];
objDR[convCMClass.FilePath] = objInFor[convCMClass.FilePath];
objDR[convCMClass.FileName] = objInFor[convCMClass.FileName];
objDR[convCMClass.FileText] = objInFor[convCMClass.FileText];
objDR[convCMClass.FuncModuleAgcId] = objInFor[convCMClass.FuncModuleAgcId];
objDR[convCMClass.FuncModuleName] = objInFor[convCMClass.FuncModuleName];
objDR[convCMClass.FuncModuleNameSim] = objInFor[convCMClass.FuncModuleNameSim];
objDR[convCMClass.CodeTypeId] = objInFor[convCMClass.CodeTypeId];
objDR[convCMClass.CodeTypeName] = objInFor[convCMClass.CodeTypeName];
objDR[convCMClass.CodeTypeSimName] = objInFor[convCMClass.CodeTypeSimName];
objDR[convCMClass.UserId] = objInFor[convCMClass.UserId];
objDR[convCMClass.PrjId] = objInFor[convCMClass.PrjId];
objDR[convCMClass.PrjName] = objInFor[convCMClass.PrjName];
objDR[convCMClass.IsOpen] = objInFor[convCMClass.IsOpen];
objDR[convCMClass.UpdDate] = objInFor[convCMClass.UpdDate];
objDR[convCMClass.UpdUser] = objInFor[convCMClass.UpdUser];
objDR[convCMClass.Memo] = objInFor[convCMClass.Memo];
objDR[convCMClass.FuncNum] = objInFor[convCMClass.FuncNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}