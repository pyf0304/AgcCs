
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFunctionKeyWordWApi
 表名:vCMFunctionKeyWord(00050516)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/23 23:10:47
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
public static class  clsvCMFunctionKeyWordWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetmId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, long lngmId, string strComparisonOp="")
	{
objvCMFunctionKeyWordEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.mId) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.mId, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.mId] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFunctionId">函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetCmFunctionId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFunctionId, convCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, convCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, convCMFunctionKeyWord.CmFunctionId);
objvCMFunctionKeyWordEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.CmFunctionId) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.CmFunctionId, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.CmFunctionId] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetCmClassId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmClassId, convCMFunctionKeyWord.CmClassId);
clsCheckSql.CheckFieldLen(strCmClassId, 8, convCMFunctionKeyWord.CmClassId);
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, convCMFunctionKeyWord.CmClassId);
objvCMFunctionKeyWordEN.CmClassId = strCmClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.CmClassId) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.CmClassId, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.CmClassId] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetClassName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strClassName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassName, convCMFunctionKeyWord.ClsName);
clsCheckSql.CheckFieldLen(strClassName, 100, convCMFunctionKeyWord.ClsName);
objvCMFunctionKeyWordEN.ClsName = strClassName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.ClsName) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.ClsName, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.ClsName] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetApplicationTypeId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convCMFunctionKeyWord.ApplicationTypeId);
objvCMFunctionKeyWordEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.ApplicationTypeId) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetProgLangTypeId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convCMFunctionKeyWord.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCMFunctionKeyWord.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCMFunctionKeyWord.ProgLangTypeId);
objvCMFunctionKeyWordEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.ProgLangTypeId) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.ProgLangTypeId, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.ProgLangTypeId] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetProgLangTypeName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convCMFunctionKeyWord.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convCMFunctionKeyWord.ProgLangTypeName);
objvCMFunctionKeyWordEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.ProgLangTypeName) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.ProgLangTypeName, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.ProgLangTypeName] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeSimName">编程语言类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetProgLangTypeSimName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convCMFunctionKeyWord.ProgLangTypeSimName);
objvCMFunctionKeyWordEN.ProgLangTypeSimName = strProgLangTypeSimName; //编程语言类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.ProgLangTypeSimName) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.ProgLangTypeSimName, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.ProgLangTypeSimName] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strNameSpace">域名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetNameSpace(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strNameSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convCMFunctionKeyWord.NameSpace);
objvCMFunctionKeyWordEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.NameSpace) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.NameSpace, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.NameSpace] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectPath">工程路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetProjectPath(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, convCMFunctionKeyWord.ProjectPath);
clsCheckSql.CheckFieldLen(strProjectPath, 500, convCMFunctionKeyWord.ProjectPath);
objvCMFunctionKeyWordEN.ProjectPath = strProjectPath; //工程路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.ProjectPath) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.ProjectPath, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.ProjectPath] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFilePath(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convCMFunctionKeyWord.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convCMFunctionKeyWord.FilePath);
objvCMFunctionKeyWordEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.FilePath) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.FilePath, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.FilePath] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFileName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convCMFunctionKeyWord.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, convCMFunctionKeyWord.FileName);
objvCMFunctionKeyWordEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.FileName) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.FileName, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.FileName] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetCodeTypeId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convCMFunctionKeyWord.CodeTypeId);
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCMFunctionKeyWord.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCMFunctionKeyWord.CodeTypeId);
objvCMFunctionKeyWordEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.CodeTypeId) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.CodeTypeId, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.CodeTypeId] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetUserId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convCMFunctionKeyWord.UserId);
objvCMFunctionKeyWordEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.UserId) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.UserId, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.UserId] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetPrjId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMFunctionKeyWord.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFunctionKeyWord.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFunctionKeyWord.PrjId);
objvCMFunctionKeyWordEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.PrjId) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.PrjId, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.PrjId] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetPrjName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMFunctionKeyWord.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMFunctionKeyWord.PrjName);
objvCMFunctionKeyWordEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.PrjName) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.PrjName, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.PrjName] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFunctionName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convCMFunctionKeyWord.FunctionName);
objvCMFunctionKeyWordEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.FunctionName) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.FunctionName, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.FunctionName] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncContent">函数内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFuncContent(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFuncContent, string strComparisonOp="")
	{
objvCMFunctionKeyWordEN.FuncContent = strFuncContent; //函数内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.FuncContent) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.FuncContent, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.FuncContent] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncParaLst">函数参数列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFuncParaLst(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFuncParaLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, convCMFunctionKeyWord.FuncParaLst);
objvCMFunctionKeyWordEN.FuncParaLst = strFuncParaLst; //函数参数列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.FuncParaLst) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.FuncParaLst, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.FuncParaLst] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncComments">函数注释</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFuncComments(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFuncComments, string strComparisonOp="")
	{
objvCMFunctionKeyWordEN.FuncComments = strFuncComments; //函数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.FuncComments) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.FuncComments, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.FuncComments] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFunctionSignature(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convCMFunctionKeyWord.FunctionSignature);
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convCMFunctionKeyWord.FunctionSignature);
objvCMFunctionKeyWordEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.FunctionSignature) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.FunctionSignature, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.FunctionSignature] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetKeyword(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 50, convCMFunctionKeyWord.Keyword);
objvCMFunctionKeyWordEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.Keyword) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.Keyword, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.Keyword] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetUpdDate(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFunctionKeyWord.UpdDate);
objvCMFunctionKeyWordEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.UpdDate) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.UpdDate, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.UpdDate] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetUpdUser(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFunctionKeyWord.UpdUser);
objvCMFunctionKeyWordEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.UpdUser) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.UpdUser, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.UpdUser] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetMemo(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFunctionKeyWord.Memo);
objvCMFunctionKeyWordEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(convCMFunctionKeyWord.Memo) == false)
{
objvCMFunctionKeyWordEN.dicFldComparisonOp.Add(convCMFunctionKeyWord.Memo, strComparisonOp);
}
else
{
objvCMFunctionKeyWordEN.dicFldComparisonOp[convCMFunctionKeyWord.Memo] = strComparisonOp;
}
}
return objvCMFunctionKeyWordEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.mId) == true)
{
string strComparisonOpmId = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFunctionKeyWord.mId, objvCMFunctionKeyWordCond.mId, strComparisonOpmId);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.CmFunctionId, objvCMFunctionKeyWordCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.CmClassId) == true)
{
string strComparisonOpCmClassId = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.CmClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.CmClassId, objvCMFunctionKeyWordCond.CmClassId, strComparisonOpCmClassId);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.ClsName) == true)
{
string strComparisonOpClassName = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.ClsName, objvCMFunctionKeyWordCond.ClsName, strComparisonOpClassName);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFunctionKeyWord.ApplicationTypeId, objvCMFunctionKeyWordCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.ProgLangTypeId, objvCMFunctionKeyWordCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.ProgLangTypeName, objvCMFunctionKeyWordCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.ProgLangTypeSimName) == true)
{
string strComparisonOpProgLangTypeSimName = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.ProgLangTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.ProgLangTypeSimName, objvCMFunctionKeyWordCond.ProgLangTypeSimName, strComparisonOpProgLangTypeSimName);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.NameSpace) == true)
{
string strComparisonOpNameSpace = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.NameSpace, objvCMFunctionKeyWordCond.NameSpace, strComparisonOpNameSpace);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.ProjectPath) == true)
{
string strComparisonOpProjectPath = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.ProjectPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.ProjectPath, objvCMFunctionKeyWordCond.ProjectPath, strComparisonOpProjectPath);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.FilePath) == true)
{
string strComparisonOpFilePath = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.FilePath, objvCMFunctionKeyWordCond.FilePath, strComparisonOpFilePath);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.FileName) == true)
{
string strComparisonOpFileName = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.FileName, objvCMFunctionKeyWordCond.FileName, strComparisonOpFileName);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.CodeTypeId, objvCMFunctionKeyWordCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.UserId) == true)
{
string strComparisonOpUserId = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.UserId, objvCMFunctionKeyWordCond.UserId, strComparisonOpUserId);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.PrjId) == true)
{
string strComparisonOpPrjId = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.PrjId, objvCMFunctionKeyWordCond.PrjId, strComparisonOpPrjId);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.PrjName) == true)
{
string strComparisonOpPrjName = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.PrjName, objvCMFunctionKeyWordCond.PrjName, strComparisonOpPrjName);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.FunctionName) == true)
{
string strComparisonOpFunctionName = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.FunctionName, objvCMFunctionKeyWordCond.FunctionName, strComparisonOpFunctionName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.FuncParaLst) == true)
{
string strComparisonOpFuncParaLst = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.FuncParaLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.FuncParaLst, objvCMFunctionKeyWordCond.FuncParaLst, strComparisonOpFuncParaLst);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.FunctionSignature, objvCMFunctionKeyWordCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.Keyword) == true)
{
string strComparisonOpKeyword = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.Keyword, objvCMFunctionKeyWordCond.Keyword, strComparisonOpKeyword);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.UpdDate, objvCMFunctionKeyWordCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.UpdUser, objvCMFunctionKeyWordCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.Memo) == true)
{
string strComparisonOpMemo = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.Memo, objvCMFunctionKeyWordCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCM函数关键字(vCMFunctionKeyWord)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMFunctionKeyWordWApi
{
private static readonly string mstrApiControllerName = "vCMFunctionKeyWordApi";

 public clsvCMFunctionKeyWordWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM函数关键字]...","0");
List<clsvCMFunctionKeyWordEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="mId";
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

public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMFunctionKeyWord.mId); 
List<clsvCMFunctionKeyWordEN> arrObjLst = clsvCMFunctionKeyWordWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN()
{
mId = 0,
UserId = "选[vCM函数关键字]..."
};
arrObjLst.Insert(0, objvCMFunctionKeyWordEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCMFunctionKeyWord.mId;
objComboBox.DisplayMember = convCMFunctionKeyWord.UserId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFunctionKeyWordEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN;
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
objvCMFunctionKeyWordEN = JsonConvert.DeserializeObject<clsvCMFunctionKeyWordEN>(strJson);
return objvCMFunctionKeyWordEN;
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
public static clsvCMFunctionKeyWordEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN;
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
objvCMFunctionKeyWordEN = JsonConvert.DeserializeObject<clsvCMFunctionKeyWordEN>(strJson);
return objvCMFunctionKeyWordEN;
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
//该表没有使用Cache,不需要生成[GetUserIdBymIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionKeyWordEN> GetObjLst(string strWhereCond)
{
 List<clsvCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionKeyWordEN>>(strJson);
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
public static List<clsvCMFunctionKeyWordEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionKeyWordEN>>(strJson);
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
public static List<clsvCMFunctionKeyWordEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionKeyWordEN>>(strJson);
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
public static List<clsvCMFunctionKeyWordEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionKeyWordEN>>(strJson);
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
public static List<clsvCMFunctionKeyWordEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionKeyWordEN>>(strJson);
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
public static List<clsvCMFunctionKeyWordEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMFunctionKeyWordEN>>(strJson);
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
 /// <param name = "objvCMFunctionKeyWordENS">源对象</param>
 /// <param name = "objvCMFunctionKeyWordENT">目标对象</param>
 public static void CopyTo(clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENS, clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENT)
{
try
{
objvCMFunctionKeyWordENT.mId = objvCMFunctionKeyWordENS.mId; //mId
objvCMFunctionKeyWordENT.CmFunctionId = objvCMFunctionKeyWordENS.CmFunctionId; //函数Id
objvCMFunctionKeyWordENT.CmClassId = objvCMFunctionKeyWordENS.CmClassId; //类Id
objvCMFunctionKeyWordENT.ClsName = objvCMFunctionKeyWordENS.ClsName; //类名
objvCMFunctionKeyWordENT.ApplicationTypeId = objvCMFunctionKeyWordENS.ApplicationTypeId; //应用程序类型ID
objvCMFunctionKeyWordENT.ProgLangTypeId = objvCMFunctionKeyWordENS.ProgLangTypeId; //编程语言类型Id
objvCMFunctionKeyWordENT.ProgLangTypeName = objvCMFunctionKeyWordENS.ProgLangTypeName; //编程语言类型名
objvCMFunctionKeyWordENT.ProgLangTypeSimName = objvCMFunctionKeyWordENS.ProgLangTypeSimName; //编程语言类型简称
objvCMFunctionKeyWordENT.NameSpace = objvCMFunctionKeyWordENS.NameSpace; //域名
objvCMFunctionKeyWordENT.ProjectPath = objvCMFunctionKeyWordENS.ProjectPath; //工程路径
objvCMFunctionKeyWordENT.FilePath = objvCMFunctionKeyWordENS.FilePath; //文件路径
objvCMFunctionKeyWordENT.FileName = objvCMFunctionKeyWordENS.FileName; //文件名
objvCMFunctionKeyWordENT.CodeTypeId = objvCMFunctionKeyWordENS.CodeTypeId; //代码类型Id
objvCMFunctionKeyWordENT.UserId = objvCMFunctionKeyWordENS.UserId; //用户Id
objvCMFunctionKeyWordENT.PrjId = objvCMFunctionKeyWordENS.PrjId; //工程ID
objvCMFunctionKeyWordENT.PrjName = objvCMFunctionKeyWordENS.PrjName; //工程名称
objvCMFunctionKeyWordENT.FunctionName = objvCMFunctionKeyWordENS.FunctionName; //功能名称
objvCMFunctionKeyWordENT.FuncContent = objvCMFunctionKeyWordENS.FuncContent; //函数内容
objvCMFunctionKeyWordENT.FuncParaLst = objvCMFunctionKeyWordENS.FuncParaLst; //函数参数列表
objvCMFunctionKeyWordENT.FuncComments = objvCMFunctionKeyWordENS.FuncComments; //函数注释
objvCMFunctionKeyWordENT.FunctionSignature = objvCMFunctionKeyWordENS.FunctionSignature; //函数签名
objvCMFunctionKeyWordENT.Keyword = objvCMFunctionKeyWordENS.Keyword; //关键字
objvCMFunctionKeyWordENT.UpdDate = objvCMFunctionKeyWordENS.UpdDate; //修改日期
objvCMFunctionKeyWordENT.UpdUser = objvCMFunctionKeyWordENS.UpdUser; //修改者
objvCMFunctionKeyWordENT.Memo = objvCMFunctionKeyWordENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvCMFunctionKeyWordEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMFunctionKeyWordEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMFunctionKeyWordEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMFunctionKeyWordEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMFunctionKeyWordEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMFunctionKeyWordEN.AttributeName)
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
string strKey = string.Format("{0}", clsvCMFunctionKeyWordEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvCMFunctionKeyWordEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMFunctionKeyWord.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCMFunctionKeyWord.CmFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.CmClassId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.ClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMFunctionKeyWord.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.ProgLangTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.NameSpace, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.ProjectPath, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.FuncContent, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.FuncParaLst, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.FuncComments, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMFunctionKeyWord.Memo, Type.GetType("System.String"));
foreach (clsvCMFunctionKeyWordEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMFunctionKeyWord.mId] = objInFor[convCMFunctionKeyWord.mId];
objDR[convCMFunctionKeyWord.CmFunctionId] = objInFor[convCMFunctionKeyWord.CmFunctionId];
objDR[convCMFunctionKeyWord.CmClassId] = objInFor[convCMFunctionKeyWord.CmClassId];
objDR[convCMFunctionKeyWord.ClsName] = objInFor[convCMFunctionKeyWord.ClsName];
objDR[convCMFunctionKeyWord.ApplicationTypeId] = objInFor[convCMFunctionKeyWord.ApplicationTypeId];
objDR[convCMFunctionKeyWord.ProgLangTypeId] = objInFor[convCMFunctionKeyWord.ProgLangTypeId];
objDR[convCMFunctionKeyWord.ProgLangTypeName] = objInFor[convCMFunctionKeyWord.ProgLangTypeName];
objDR[convCMFunctionKeyWord.ProgLangTypeSimName] = objInFor[convCMFunctionKeyWord.ProgLangTypeSimName];
objDR[convCMFunctionKeyWord.NameSpace] = objInFor[convCMFunctionKeyWord.NameSpace];
objDR[convCMFunctionKeyWord.ProjectPath] = objInFor[convCMFunctionKeyWord.ProjectPath];
objDR[convCMFunctionKeyWord.FilePath] = objInFor[convCMFunctionKeyWord.FilePath];
objDR[convCMFunctionKeyWord.FileName] = objInFor[convCMFunctionKeyWord.FileName];
objDR[convCMFunctionKeyWord.CodeTypeId] = objInFor[convCMFunctionKeyWord.CodeTypeId];
objDR[convCMFunctionKeyWord.UserId] = objInFor[convCMFunctionKeyWord.UserId];
objDR[convCMFunctionKeyWord.PrjId] = objInFor[convCMFunctionKeyWord.PrjId];
objDR[convCMFunctionKeyWord.PrjName] = objInFor[convCMFunctionKeyWord.PrjName];
objDR[convCMFunctionKeyWord.FunctionName] = objInFor[convCMFunctionKeyWord.FunctionName];
objDR[convCMFunctionKeyWord.FuncContent] = objInFor[convCMFunctionKeyWord.FuncContent];
objDR[convCMFunctionKeyWord.FuncParaLst] = objInFor[convCMFunctionKeyWord.FuncParaLst];
objDR[convCMFunctionKeyWord.FuncComments] = objInFor[convCMFunctionKeyWord.FuncComments];
objDR[convCMFunctionKeyWord.FunctionSignature] = objInFor[convCMFunctionKeyWord.FunctionSignature];
objDR[convCMFunctionKeyWord.Keyword] = objInFor[convCMFunctionKeyWord.Keyword];
objDR[convCMFunctionKeyWord.UpdDate] = objInFor[convCMFunctionKeyWord.UpdDate];
objDR[convCMFunctionKeyWord.UpdUser] = objInFor[convCMFunctionKeyWord.UpdUser];
objDR[convCMFunctionKeyWord.Memo] = objInFor[convCMFunctionKeyWord.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}