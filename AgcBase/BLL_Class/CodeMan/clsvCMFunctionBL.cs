
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFunctionBL
 表名:vCMFunction(00050507)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:39:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMFunctionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFunctionEN GetObj(this K_CmFunctionId_vCMFunction myKey)
{
clsvCMFunctionEN objvCMFunctionEN = clsvCMFunctionBL.vCMFunctionDA.GetObjByCmFunctionId(myKey.Value);
return objvCMFunctionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetCmFunctionId(this clsvCMFunctionEN objvCMFunctionEN, string strCmFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, convCMFunction.CmFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, convCMFunction.CmFunctionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetCmClassId(this clsvCMFunctionEN objvCMFunctionEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmClassId, convCMFunction.CmClassId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmClassId, 8, convCMFunction.CmClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, convCMFunction.CmClassId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetApplicationTypeId(this clsvCMFunctionEN objvCMFunctionEN, int? intApplicationTypeId, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetProgLangTypeId(this clsvCMFunctionEN objvCMFunctionEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convCMFunction.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCMFunction.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCMFunction.ProgLangTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetProgLangTypeName(this clsvCMFunctionEN objvCMFunctionEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convCMFunction.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convCMFunction.ProgLangTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetProgLangTypeSimName(this clsvCMFunctionEN objvCMFunctionEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convCMFunction.ProgLangTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetNameSpace(this clsvCMFunctionEN objvCMFunctionEN, string strNameSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convCMFunction.NameSpace);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetProjectPath(this clsvCMFunctionEN objvCMFunctionEN, string strProjectPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectPath, 500, convCMFunction.ProjectPath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFilePath(this clsvCMFunctionEN objvCMFunctionEN, string strFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convCMFunction.FilePath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFileName(this clsvCMFunctionEN objvCMFunctionEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convCMFunction.FileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetCodeTypeId(this clsvCMFunctionEN objvCMFunctionEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCMFunction.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCMFunction.CodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetUserId(this clsvCMFunctionEN objvCMFunctionEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convCMFunction.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetPrjId(this clsvCMFunctionEN objvCMFunctionEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFunction.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFunction.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetPrjName(this clsvCMFunctionEN objvCMFunctionEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMFunction.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFunctionName(this clsvCMFunctionEN objvCMFunctionEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convCMFunction.FunctionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetKeyWords(this clsvCMFunctionEN objvCMFunctionEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convCMFunction.KeyWords);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFuncParaLst(this clsvCMFunctionEN objvCMFunctionEN, string strFuncParaLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, convCMFunction.FuncParaLst);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetFunctionSignature(this clsvCMFunctionEN objvCMFunctionEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convCMFunction.FunctionSignature);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convCMFunction.FunctionSignature);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetReturnType(this clsvCMFunctionEN objvCMFunctionEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnType, convCMFunction.ReturnType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnType, 500, convCMFunction.ReturnType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetReturnTypeId(this clsvCMFunctionEN objvCMFunctionEN, string strReturnTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convCMFunction.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convCMFunction.ReturnTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetClassNameLst(this clsvCMFunctionEN objvCMFunctionEN, string strClassNameLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassNameLst, 500, convCMFunction.ClassNameLst);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetUpdDate(this clsvCMFunctionEN objvCMFunctionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFunction.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetUpdUser(this clsvCMFunctionEN objvCMFunctionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFunction.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetMemo(this clsvCMFunctionEN objvCMFunctionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFunction.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetParaNum(this clsvCMFunctionEN objvCMFunctionEN, int? intParaNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionEN SetClsName(this clsvCMFunctionEN objvCMFunctionEN, string strClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, convCMFunction.ClsName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMFunctionENS">源对象</param>
 /// <param name = "objvCMFunctionENT">目标对象</param>
 public static void CopyTo(this clsvCMFunctionEN objvCMFunctionENS, clsvCMFunctionEN objvCMFunctionENT)
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
 /// <param name = "objvCMFunctionENS">源对象</param>
 /// <returns>目标对象=>clsvCMFunctionEN:objvCMFunctionENT</returns>
 public static clsvCMFunctionEN CopyTo(this clsvCMFunctionEN objvCMFunctionENS)
{
try
{
 clsvCMFunctionEN objvCMFunctionENT = new clsvCMFunctionEN()
{
CmFunctionId = objvCMFunctionENS.CmFunctionId, //函数Id
CmClassId = objvCMFunctionENS.CmClassId, //类Id
ApplicationTypeId = objvCMFunctionENS.ApplicationTypeId, //应用程序类型ID
ProgLangTypeId = objvCMFunctionENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvCMFunctionENS.ProgLangTypeName, //编程语言类型名
ProgLangTypeSimName = objvCMFunctionENS.ProgLangTypeSimName, //编程语言类型简称
NameSpace = objvCMFunctionENS.NameSpace, //域名
ProjectPath = objvCMFunctionENS.ProjectPath, //工程路径
FilePath = objvCMFunctionENS.FilePath, //文件路径
FileName = objvCMFunctionENS.FileName, //文件名
CodeTypeId = objvCMFunctionENS.CodeTypeId, //代码类型Id
UserId = objvCMFunctionENS.UserId, //用户Id
PrjId = objvCMFunctionENS.PrjId, //工程Id
PrjName = objvCMFunctionENS.PrjName, //工程名称
FunctionName = objvCMFunctionENS.FunctionName, //功能名称
FuncContent = objvCMFunctionENS.FuncContent, //函数内容
KeyWords = objvCMFunctionENS.KeyWords, //关键字
FuncParaLst = objvCMFunctionENS.FuncParaLst, //函数参数列表
FuncComments = objvCMFunctionENS.FuncComments, //函数注释
FunctionSignature = objvCMFunctionENS.FunctionSignature, //函数签名
ReturnType = objvCMFunctionENS.ReturnType, //返回类型
IsKnownType = objvCMFunctionENS.IsKnownType, //是否已知类型
ReturnTypeId = objvCMFunctionENS.ReturnTypeId, //返回类型ID
ClassNameLst = objvCMFunctionENS.ClassNameLst, //类名列表
UpdDate = objvCMFunctionENS.UpdDate, //修改日期
UpdUser = objvCMFunctionENS.UpdUser, //修改者
Memo = objvCMFunctionENS.Memo, //说明
ParaNum = objvCMFunctionENS.ParaNum, //参数个数
ClsName = objvCMFunctionENS.ClsName, //类名
};
 return objvCMFunctionENT;
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
public static void CheckProperty4Condition(this clsvCMFunctionEN objvCMFunctionEN)
{
 clsvCMFunctionBL.vCMFunctionDA.CheckProperty4Condition(objvCMFunctionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
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
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMFunction
{
public virtual bool UpdRelaTabDate(string strCmFunctionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM函数(vCMFunction)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMFunctionBL
{
public static RelatedActions_vCMFunction relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMFunctionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMFunctionDA vCMFunctionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMFunctionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMFunctionBL()
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
if (string.IsNullOrEmpty(clsvCMFunctionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFunctionEN._ConnectString);
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
public static DataTable GetDataTable_vCMFunction(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMFunctionDA.GetDataTable_vCMFunction(strWhereCond);
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
objDT = vCMFunctionDA.GetDataTable(strWhereCond);
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
objDT = vCMFunctionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMFunctionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMFunctionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMFunctionDA.GetDataTable_Top(objTopPara);
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
objDT = vCMFunctionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCMFunctionEN> GetObjLstByCmFunctionIdLst(List<string> arrCmFunctionIdLst)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmFunctionIdLst, true);
 string strWhereCond = string.Format("CmFunctionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMFunctionEN> GetObjLstByCmFunctionIdLstCache(List<string> arrCmFunctionIdLst)
{
string strKey = string.Format("{0}", clsvCMFunctionEN._CurrTabName);
List<clsvCMFunctionEN> arrvCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionEN> arrvCMFunctionObjLst_Sel =
arrvCMFunctionObjLstCache
.Where(x => arrCmFunctionIdLst.Contains(x.CmFunctionId));
return arrvCMFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionEN> GetObjLst(string strWhereCond)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
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
public static List<clsvCMFunctionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMFunctionEN> GetSubObjLstCache(clsvCMFunctionEN objvCMFunctionCond)
{
List<clsvCMFunctionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFunction._AttributeName)
{
if (objvCMFunctionCond.IsUpdated(strFldName) == false) continue;
if (objvCMFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFunctionCond[strFldName].ToString());
}
else
{
if (objvCMFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFunctionCond[strFldName]));
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
public static List<clsvCMFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
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
public static List<clsvCMFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
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
List<clsvCMFunctionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMFunctionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
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
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
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
public static List<clsvCMFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
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
public static List<clsvCMFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMFunctionEN> arrObjLst = new List<clsvCMFunctionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionEN objvCMFunctionEN = new clsvCMFunctionEN();
try
{
objvCMFunctionEN.CmFunctionId = objRow[convCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionEN.CmClassId = objRow[convCMFunction.CmClassId].ToString().Trim(); //类Id
objvCMFunctionEN.ApplicationTypeId = objRow[convCMFunction.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionEN.ProgLangTypeId = objRow[convCMFunction.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionEN.ProgLangTypeName = objRow[convCMFunction.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionEN.ProgLangTypeSimName = objRow[convCMFunction.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunction.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionEN.NameSpace = objRow[convCMFunction.NameSpace] == DBNull.Value ? null : objRow[convCMFunction.NameSpace].ToString().Trim(); //域名
objvCMFunctionEN.ProjectPath = objRow[convCMFunction.ProjectPath] == DBNull.Value ? null : objRow[convCMFunction.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionEN.FilePath = objRow[convCMFunction.FilePath] == DBNull.Value ? null : objRow[convCMFunction.FilePath].ToString().Trim(); //文件路径
objvCMFunctionEN.FileName = objRow[convCMFunction.FileName] == DBNull.Value ? null : objRow[convCMFunction.FileName].ToString().Trim(); //文件名
objvCMFunctionEN.CodeTypeId = objRow[convCMFunction.CodeTypeId] == DBNull.Value ? null : objRow[convCMFunction.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionEN.UserId = objRow[convCMFunction.UserId] == DBNull.Value ? null : objRow[convCMFunction.UserId].ToString().Trim(); //用户Id
objvCMFunctionEN.PrjId = objRow[convCMFunction.PrjId] == DBNull.Value ? null : objRow[convCMFunction.PrjId].ToString().Trim(); //工程Id
objvCMFunctionEN.PrjName = objRow[convCMFunction.PrjName] == DBNull.Value ? null : objRow[convCMFunction.PrjName].ToString().Trim(); //工程名称
objvCMFunctionEN.FunctionName = objRow[convCMFunction.FunctionName] == DBNull.Value ? null : objRow[convCMFunction.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionEN.FuncContent = objRow[convCMFunction.FuncContent] == DBNull.Value ? null : objRow[convCMFunction.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionEN.KeyWords = objRow[convCMFunction.KeyWords] == DBNull.Value ? null : objRow[convCMFunction.KeyWords].ToString().Trim(); //关键字
objvCMFunctionEN.FuncParaLst = objRow[convCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionEN.FuncComments = objRow[convCMFunction.FuncComments] == DBNull.Value ? null : objRow[convCMFunction.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionEN.FunctionSignature = objRow[convCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionEN.ReturnType = objRow[convCMFunction.ReturnType].ToString().Trim(); //返回类型
objvCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objvCMFunctionEN.ReturnTypeId = objRow[convCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[convCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvCMFunctionEN.ClassNameLst = objRow[convCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[convCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objvCMFunctionEN.UpdDate = objRow[convCMFunction.UpdDate] == DBNull.Value ? null : objRow[convCMFunction.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionEN.UpdUser = objRow[convCMFunction.UpdUser] == DBNull.Value ? null : objRow[convCMFunction.UpdUser].ToString().Trim(); //修改者
objvCMFunctionEN.Memo = objRow[convCMFunction.Memo] == DBNull.Value ? null : objRow[convCMFunction.Memo].ToString().Trim(); //说明
objvCMFunctionEN.ParaNum = objRow[convCMFunction.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFunction.ParaNum].ToString().Trim()); //参数个数
objvCMFunctionEN.ClsName = objRow[convCMFunction.ClsName] == DBNull.Value ? null : objRow[convCMFunction.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMFunctionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMFunction(ref clsvCMFunctionEN objvCMFunctionEN)
{
bool bolResult = vCMFunctionDA.GetvCMFunction(ref objvCMFunctionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFunctionEN GetObjByCmFunctionId(string strCmFunctionId)
{
if (strCmFunctionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmFunctionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmFunctionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCMFunctionEN objvCMFunctionEN = vCMFunctionDA.GetObjByCmFunctionId(strCmFunctionId);
return objvCMFunctionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMFunctionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMFunctionEN objvCMFunctionEN = vCMFunctionDA.GetFirstObj(strWhereCond);
 return objvCMFunctionEN;
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
public static clsvCMFunctionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMFunctionEN objvCMFunctionEN = vCMFunctionDA.GetObjByDataRow(objRow);
 return objvCMFunctionEN;
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
public static clsvCMFunctionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMFunctionEN objvCMFunctionEN = vCMFunctionDA.GetObjByDataRow(objRow);
 return objvCMFunctionEN;
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
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <param name = "lstvCMFunctionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFunctionEN GetObjByCmFunctionIdFromList(string strCmFunctionId, List<clsvCMFunctionEN> lstvCMFunctionObjLst)
{
foreach (clsvCMFunctionEN objvCMFunctionEN in lstvCMFunctionObjLst)
{
if (objvCMFunctionEN.CmFunctionId == strCmFunctionId)
{
return objvCMFunctionEN;
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
 string strCmFunctionId;
 try
 {
 strCmFunctionId = new clsvCMFunctionDA().GetFirstID(strWhereCond);
 return strCmFunctionId;
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
 arrList = vCMFunctionDA.GetID(strWhereCond);
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
bool bolIsExist = vCMFunctionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmFunctionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCMFunctionDA.IsExist(strCmFunctionId);
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
 bolIsExist = clsvCMFunctionDA.IsExistTable();
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
 bolIsExist = vCMFunctionDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMFunctionEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMFunctionEN objvCMFunctionEN)
{
try
{
objvCMFunctionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMFunctionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMFunction.CmFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.CmFunctionId = objvCMFunctionEN.CmFunctionId; //函数Id
}
if (arrFldSet.Contains(convCMFunction.CmClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.CmClassId = objvCMFunctionEN.CmClassId; //类Id
}
if (arrFldSet.Contains(convCMFunction.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ApplicationTypeId = objvCMFunctionEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCMFunction.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ProgLangTypeId = objvCMFunctionEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convCMFunction.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ProgLangTypeName = objvCMFunctionEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convCMFunction.ProgLangTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ProgLangTypeSimName = objvCMFunctionEN.ProgLangTypeSimName == "[null]" ? null :  objvCMFunctionEN.ProgLangTypeSimName; //编程语言类型简称
}
if (arrFldSet.Contains(convCMFunction.NameSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.NameSpace = objvCMFunctionEN.NameSpace == "[null]" ? null :  objvCMFunctionEN.NameSpace; //域名
}
if (arrFldSet.Contains(convCMFunction.ProjectPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ProjectPath = objvCMFunctionEN.ProjectPath == "[null]" ? null :  objvCMFunctionEN.ProjectPath; //工程路径
}
if (arrFldSet.Contains(convCMFunction.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.FilePath = objvCMFunctionEN.FilePath == "[null]" ? null :  objvCMFunctionEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convCMFunction.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.FileName = objvCMFunctionEN.FileName == "[null]" ? null :  objvCMFunctionEN.FileName; //文件名
}
if (arrFldSet.Contains(convCMFunction.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.CodeTypeId = objvCMFunctionEN.CodeTypeId == "[null]" ? null :  objvCMFunctionEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convCMFunction.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.UserId = objvCMFunctionEN.UserId == "[null]" ? null :  objvCMFunctionEN.UserId; //用户Id
}
if (arrFldSet.Contains(convCMFunction.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.PrjId = objvCMFunctionEN.PrjId == "[null]" ? null :  objvCMFunctionEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMFunction.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.PrjName = objvCMFunctionEN.PrjName == "[null]" ? null :  objvCMFunctionEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCMFunction.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.FunctionName = objvCMFunctionEN.FunctionName == "[null]" ? null :  objvCMFunctionEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(convCMFunction.FuncContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.FuncContent = objvCMFunctionEN.FuncContent == "[null]" ? null :  objvCMFunctionEN.FuncContent; //函数内容
}
if (arrFldSet.Contains(convCMFunction.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.KeyWords = objvCMFunctionEN.KeyWords == "[null]" ? null :  objvCMFunctionEN.KeyWords; //关键字
}
if (arrFldSet.Contains(convCMFunction.FuncParaLst, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.FuncParaLst = objvCMFunctionEN.FuncParaLst == "[null]" ? null :  objvCMFunctionEN.FuncParaLst; //函数参数列表
}
if (arrFldSet.Contains(convCMFunction.FuncComments, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.FuncComments = objvCMFunctionEN.FuncComments == "[null]" ? null :  objvCMFunctionEN.FuncComments; //函数注释
}
if (arrFldSet.Contains(convCMFunction.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.FunctionSignature = objvCMFunctionEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convCMFunction.ReturnType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ReturnType = objvCMFunctionEN.ReturnType; //返回类型
}
if (arrFldSet.Contains(convCMFunction.IsKnownType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.IsKnownType = objvCMFunctionEN.IsKnownType; //是否已知类型
}
if (arrFldSet.Contains(convCMFunction.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ReturnTypeId = objvCMFunctionEN.ReturnTypeId == "[null]" ? null :  objvCMFunctionEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(convCMFunction.ClassNameLst, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ClassNameLst = objvCMFunctionEN.ClassNameLst == "[null]" ? null :  objvCMFunctionEN.ClassNameLst; //类名列表
}
if (arrFldSet.Contains(convCMFunction.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.UpdDate = objvCMFunctionEN.UpdDate == "[null]" ? null :  objvCMFunctionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMFunction.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.UpdUser = objvCMFunctionEN.UpdUser == "[null]" ? null :  objvCMFunctionEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMFunction.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.Memo = objvCMFunctionEN.Memo == "[null]" ? null :  objvCMFunctionEN.Memo; //说明
}
if (arrFldSet.Contains(convCMFunction.ParaNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ParaNum = objvCMFunctionEN.ParaNum; //参数个数
}
if (arrFldSet.Contains(convCMFunction.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionEN.ClsName = objvCMFunctionEN.ClsName == "[null]" ? null :  objvCMFunctionEN.ClsName; //类名
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
 /// <param name = "objvCMFunctionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMFunctionEN objvCMFunctionEN)
{
try
{
if (objvCMFunctionEN.ProgLangTypeSimName == "[null]") objvCMFunctionEN.ProgLangTypeSimName = null; //编程语言类型简称
if (objvCMFunctionEN.NameSpace == "[null]") objvCMFunctionEN.NameSpace = null; //域名
if (objvCMFunctionEN.ProjectPath == "[null]") objvCMFunctionEN.ProjectPath = null; //工程路径
if (objvCMFunctionEN.FilePath == "[null]") objvCMFunctionEN.FilePath = null; //文件路径
if (objvCMFunctionEN.FileName == "[null]") objvCMFunctionEN.FileName = null; //文件名
if (objvCMFunctionEN.CodeTypeId == "[null]") objvCMFunctionEN.CodeTypeId = null; //代码类型Id
if (objvCMFunctionEN.UserId == "[null]") objvCMFunctionEN.UserId = null; //用户Id
if (objvCMFunctionEN.PrjId == "[null]") objvCMFunctionEN.PrjId = null; //工程Id
if (objvCMFunctionEN.PrjName == "[null]") objvCMFunctionEN.PrjName = null; //工程名称
if (objvCMFunctionEN.FunctionName == "[null]") objvCMFunctionEN.FunctionName = null; //功能名称
if (objvCMFunctionEN.FuncContent == "[null]") objvCMFunctionEN.FuncContent = null; //函数内容
if (objvCMFunctionEN.KeyWords == "[null]") objvCMFunctionEN.KeyWords = null; //关键字
if (objvCMFunctionEN.FuncParaLst == "[null]") objvCMFunctionEN.FuncParaLst = null; //函数参数列表
if (objvCMFunctionEN.FuncComments == "[null]") objvCMFunctionEN.FuncComments = null; //函数注释
if (objvCMFunctionEN.ReturnTypeId == "[null]") objvCMFunctionEN.ReturnTypeId = null; //返回类型ID
if (objvCMFunctionEN.ClassNameLst == "[null]") objvCMFunctionEN.ClassNameLst = null; //类名列表
if (objvCMFunctionEN.UpdDate == "[null]") objvCMFunctionEN.UpdDate = null; //修改日期
if (objvCMFunctionEN.UpdUser == "[null]") objvCMFunctionEN.UpdUser = null; //修改者
if (objvCMFunctionEN.Memo == "[null]") objvCMFunctionEN.Memo = null; //说明
if (objvCMFunctionEN.ClsName == "[null]") objvCMFunctionEN.ClsName = null; //类名
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
public static void CheckProperty4Condition(clsvCMFunctionEN objvCMFunctionEN)
{
 vCMFunctionDA.CheckProperty4Condition(objvCMFunctionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CmFunctionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMFunction.CmFunctionId); 
List<clsvCMFunctionEN> arrObjLst = clsvCMFunctionBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CmFunctionId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM函数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCMFunction.CmFunctionId); 
IEnumerable<clsvCMFunctionEN> arrObjLst = clsvCMFunctionBL.GetObjLst(strCondition);
objDDL.DataValueField = convCMFunction.CmFunctionId;
objDDL.DataTextField = convCMFunction.UserId;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CmFunctionIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM函数]...","0");
List<clsvCMFunctionEN> arrvCMFunctionObjLst = GetAllvCMFunctionObjLstCache(); 
objDDL.DataValueField = convCMFunction.CmFunctionId;
objDDL.DataTextField = convCMFunction.UserId;
objDDL.DataSource = arrvCMFunctionObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsCMFunctionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFunctionBL没有刷新缓存机制(clsCMFunctionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMClassBL没有刷新缓存机制(clsCMClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CmFunctionId");
//if (arrvCMFunctionObjLstCache == null)
//{
//arrvCMFunctionObjLstCache = vCMFunctionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFunctionEN GetObjByCmFunctionIdCache(string strCmFunctionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCMFunctionEN._CurrTabName);
List<clsvCMFunctionEN> arrvCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionEN> arrvCMFunctionObjLst_Sel =
arrvCMFunctionObjLstCache
.Where(x=> x.CmFunctionId == strCmFunctionId 
);
if (arrvCMFunctionObjLst_Sel.Count() == 0)
{
   clsvCMFunctionEN obj = clsvCMFunctionBL.GetObjByCmFunctionId(strCmFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCMFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserIdByCmFunctionIdCache(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return "";
//获取缓存中的对象列表
clsvCMFunctionEN objvCMFunction = GetObjByCmFunctionIdCache(strCmFunctionId);
if (objvCMFunction == null) return "";
return objvCMFunction.UserId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmFunctionIdCache(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return "";
//获取缓存中的对象列表
clsvCMFunctionEN objvCMFunction = GetObjByCmFunctionIdCache(strCmFunctionId);
if (objvCMFunction == null) return "";
return objvCMFunction.UserId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFunctionEN> GetAllvCMFunctionObjLstCache()
{
//获取缓存中的对象列表
List<clsvCMFunctionEN> arrvCMFunctionObjLstCache = GetObjLstCache(); 
return arrvCMFunctionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFunctionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCMFunctionEN._CurrTabName);
List<clsvCMFunctionEN> arrvCMFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCMFunctionObjLstCache;
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
string strKey = string.Format("{0}", clsvCMFunctionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvCMFunctionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMFunctionEN._RefreshTimeLst.Count == 0) return "";
return clsvCMFunctionEN._RefreshTimeLst[clsvCMFunctionEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCmFunctionId)
{
if (strInFldName != convCMFunction.CmFunctionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMFunction._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMFunction._AttributeName));
throw new Exception(strMsg);
}
var objvCMFunction = clsvCMFunctionBL.GetObjByCmFunctionIdCache(strCmFunctionId);
if (objvCMFunction == null) return "";
return objvCMFunction[strOutFldName].ToString();
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
int intRecCount = clsvCMFunctionDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMFunctionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMFunctionDA.GetRecCount();
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
int intRecCount = clsvCMFunctionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMFunctionEN objvCMFunctionCond)
{
List<clsvCMFunctionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFunction._AttributeName)
{
if (objvCMFunctionCond.IsUpdated(strFldName) == false) continue;
if (objvCMFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFunctionCond[strFldName].ToString());
}
else
{
if (objvCMFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFunctionCond[strFldName]));
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
 List<string> arrList = clsvCMFunctionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMFunctionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMFunctionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}