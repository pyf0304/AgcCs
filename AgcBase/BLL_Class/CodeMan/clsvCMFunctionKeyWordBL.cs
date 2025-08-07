
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFunctionKeyWordBL
 表名:vCMFunctionKeyWord(00050516)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:18:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class  clsvCMFunctionKeyWordBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFunctionKeyWordEN GetObj(this K_mId_vCMFunctionKeyWord myKey)
{
clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = clsvCMFunctionKeyWordBL.vCMFunctionKeyWordDA.GetObjBymId(myKey.Value);
return objvCMFunctionKeyWordEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetCmFunctionId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFunctionId, convCMFunctionKeyWord.CmFunctionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, convCMFunctionKeyWord.CmFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, convCMFunctionKeyWord.CmFunctionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetCmClassId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmClassId, convCMFunctionKeyWord.CmClassId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmClassId, 8, convCMFunctionKeyWord.CmClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, convCMFunctionKeyWord.CmClassId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetProgLangTypeId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convCMFunctionKeyWord.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCMFunctionKeyWord.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCMFunctionKeyWord.ProgLangTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetProgLangTypeName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convCMFunctionKeyWord.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convCMFunctionKeyWord.ProgLangTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetProgLangTypeSimName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convCMFunctionKeyWord.ProgLangTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetNameSpace(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strNameSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convCMFunctionKeyWord.NameSpace);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetProjectPath(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, convCMFunctionKeyWord.ProjectPath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectPath, 500, convCMFunctionKeyWord.ProjectPath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFilePath(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convCMFunctionKeyWord.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convCMFunctionKeyWord.FilePath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFileName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convCMFunctionKeyWord.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convCMFunctionKeyWord.FileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetCodeTypeId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convCMFunctionKeyWord.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCMFunctionKeyWord.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCMFunctionKeyWord.CodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetUserId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convCMFunctionKeyWord.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetPrjId(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMFunctionKeyWord.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFunctionKeyWord.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFunctionKeyWord.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetPrjName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMFunctionKeyWord.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMFunctionKeyWord.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFunctionName(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convCMFunctionKeyWord.FunctionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFuncParaLst(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFuncParaLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, convCMFunctionKeyWord.FuncParaLst);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetFunctionSignature(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convCMFunctionKeyWord.FunctionSignature);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convCMFunctionKeyWord.FunctionSignature);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetKeyword(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, convCMFunctionKeyWord.Keyword);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetUpdDate(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFunctionKeyWord.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetUpdUser(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFunctionKeyWord.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFunctionKeyWordEN SetMemo(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFunctionKeyWord.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordENS">源对象</param>
 /// <param name = "objvCMFunctionKeyWordENT">目标对象</param>
 public static void CopyTo(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENS, clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENT)
{
try
{
objvCMFunctionKeyWordENT.mId = objvCMFunctionKeyWordENS.mId; //mId
objvCMFunctionKeyWordENT.CmFunctionId = objvCMFunctionKeyWordENS.CmFunctionId; //函数Id
objvCMFunctionKeyWordENT.CmClassId = objvCMFunctionKeyWordENS.CmClassId; //类Id
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
objvCMFunctionKeyWordENT.ClsName = objvCMFunctionKeyWordENS.ClsName; //类名
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
 /// <param name = "objvCMFunctionKeyWordENS">源对象</param>
 /// <returns>目标对象=>clsvCMFunctionKeyWordEN:objvCMFunctionKeyWordENT</returns>
 public static clsvCMFunctionKeyWordEN CopyTo(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENS)
{
try
{
 clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENT = new clsvCMFunctionKeyWordEN()
{
mId = objvCMFunctionKeyWordENS.mId, //mId
CmFunctionId = objvCMFunctionKeyWordENS.CmFunctionId, //函数Id
CmClassId = objvCMFunctionKeyWordENS.CmClassId, //类Id
ApplicationTypeId = objvCMFunctionKeyWordENS.ApplicationTypeId, //应用程序类型ID
ProgLangTypeId = objvCMFunctionKeyWordENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvCMFunctionKeyWordENS.ProgLangTypeName, //编程语言类型名
ProgLangTypeSimName = objvCMFunctionKeyWordENS.ProgLangTypeSimName, //编程语言类型简称
NameSpace = objvCMFunctionKeyWordENS.NameSpace, //域名
ProjectPath = objvCMFunctionKeyWordENS.ProjectPath, //工程路径
FilePath = objvCMFunctionKeyWordENS.FilePath, //文件路径
FileName = objvCMFunctionKeyWordENS.FileName, //文件名
CodeTypeId = objvCMFunctionKeyWordENS.CodeTypeId, //代码类型Id
UserId = objvCMFunctionKeyWordENS.UserId, //用户Id
PrjId = objvCMFunctionKeyWordENS.PrjId, //工程ID
PrjName = objvCMFunctionKeyWordENS.PrjName, //工程名称
FunctionName = objvCMFunctionKeyWordENS.FunctionName, //功能名称
FuncContent = objvCMFunctionKeyWordENS.FuncContent, //函数内容
FuncParaLst = objvCMFunctionKeyWordENS.FuncParaLst, //函数参数列表
FuncComments = objvCMFunctionKeyWordENS.FuncComments, //函数注释
FunctionSignature = objvCMFunctionKeyWordENS.FunctionSignature, //函数签名
Keyword = objvCMFunctionKeyWordENS.Keyword, //关键字
UpdDate = objvCMFunctionKeyWordENS.UpdDate, //修改日期
UpdUser = objvCMFunctionKeyWordENS.UpdUser, //修改者
Memo = objvCMFunctionKeyWordENS.Memo, //说明
ClsName = objvCMFunctionKeyWordENS.ClsName, //类名
};
 return objvCMFunctionKeyWordENT;
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
public static void CheckProperty4Condition(this clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN)
{
 clsvCMFunctionKeyWordBL.vCMFunctionKeyWordDA.CheckProperty4Condition(objvCMFunctionKeyWordEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.FuncParaLst) == true)
{
string strComparisonOpFuncParaLst = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.FuncParaLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.FuncParaLst, objvCMFunctionKeyWordCond.FuncParaLst, strComparisonOpFuncParaLst);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
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
if (objvCMFunctionKeyWordCond.IsUpdated(convCMFunctionKeyWord.ClsName) == true)
{
string strComparisonOpClsName = objvCMFunctionKeyWordCond.dicFldComparisonOp[convCMFunctionKeyWord.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFunctionKeyWord.ClsName, objvCMFunctionKeyWordCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMFunctionKeyWord
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM函数关键字(vCMFunctionKeyWord)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMFunctionKeyWordBL
{
public static RelatedActions_vCMFunctionKeyWord relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMFunctionKeyWordDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMFunctionKeyWordDA vCMFunctionKeyWordDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMFunctionKeyWordDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMFunctionKeyWordBL()
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
if (string.IsNullOrEmpty(clsvCMFunctionKeyWordEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFunctionKeyWordEN._ConnectString);
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
public static DataTable GetDataTable_vCMFunctionKeyWord(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMFunctionKeyWordDA.GetDataTable_vCMFunctionKeyWord(strWhereCond);
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
objDT = vCMFunctionKeyWordDA.GetDataTable(strWhereCond);
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
objDT = vCMFunctionKeyWordDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMFunctionKeyWordDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMFunctionKeyWordDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMFunctionKeyWordDA.GetDataTable_Top(objTopPara);
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
objDT = vCMFunctionKeyWordDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMFunctionKeyWordDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMFunctionKeyWordDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCMFunctionKeyWordEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMFunctionKeyWordEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvCMFunctionKeyWordEN._CurrTabName);
List<clsvCMFunctionKeyWordEN> arrvCMFunctionKeyWordObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionKeyWordEN> arrvCMFunctionKeyWordObjLst_Sel =
arrvCMFunctionKeyWordObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCMFunctionKeyWordObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionKeyWordEN> GetObjLst(string strWhereCond)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
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
public static List<clsvCMFunctionKeyWordEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMFunctionKeyWordEN> GetSubObjLstCache(clsvCMFunctionKeyWordEN objvCMFunctionKeyWordCond)
{
List<clsvCMFunctionKeyWordEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionKeyWordEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFunctionKeyWord.AttributeName)
{
if (objvCMFunctionKeyWordCond.IsUpdated(strFldName) == false) continue;
if (objvCMFunctionKeyWordCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFunctionKeyWordCond[strFldName].ToString());
}
else
{
if (objvCMFunctionKeyWordCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFunctionKeyWordCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFunctionKeyWordCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFunctionKeyWordCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFunctionKeyWordCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFunctionKeyWordCond[strFldName]));
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
public static List<clsvCMFunctionKeyWordEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
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
public static List<clsvCMFunctionKeyWordEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
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
List<clsvCMFunctionKeyWordEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMFunctionKeyWordEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionKeyWordEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMFunctionKeyWordEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
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
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
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
public static List<clsvCMFunctionKeyWordEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMFunctionKeyWordEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMFunctionKeyWordEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
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
public static List<clsvCMFunctionKeyWordEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFunctionKeyWordEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMFunctionKeyWordEN> arrObjLst = new List<clsvCMFunctionKeyWordEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = new clsvCMFunctionKeyWordEN();
try
{
objvCMFunctionKeyWordEN.mId = Int32.Parse(objRow[convCMFunctionKeyWord.mId].ToString().Trim()); //mId
objvCMFunctionKeyWordEN.CmFunctionId = objRow[convCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objvCMFunctionKeyWordEN.CmClassId = objRow[convCMFunctionKeyWord.CmClassId].ToString().Trim(); //类Id
objvCMFunctionKeyWordEN.ApplicationTypeId = Int32.Parse(objRow[convCMFunctionKeyWord.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMFunctionKeyWordEN.ProgLangTypeId = objRow[convCMFunctionKeyWord.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMFunctionKeyWordEN.ProgLangTypeName = objRow[convCMFunctionKeyWord.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objRow[convCMFunctionKeyWord.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMFunctionKeyWordEN.NameSpace = objRow[convCMFunctionKeyWord.NameSpace] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.NameSpace].ToString().Trim(); //域名
objvCMFunctionKeyWordEN.ProjectPath = objRow[convCMFunctionKeyWord.ProjectPath].ToString().Trim(); //工程路径
objvCMFunctionKeyWordEN.FilePath = objRow[convCMFunctionKeyWord.FilePath].ToString().Trim(); //文件路径
objvCMFunctionKeyWordEN.FileName = objRow[convCMFunctionKeyWord.FileName].ToString().Trim(); //文件名
objvCMFunctionKeyWordEN.CodeTypeId = objRow[convCMFunctionKeyWord.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMFunctionKeyWordEN.UserId = objRow[convCMFunctionKeyWord.UserId] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UserId].ToString().Trim(); //用户Id
objvCMFunctionKeyWordEN.PrjId = objRow[convCMFunctionKeyWord.PrjId].ToString().Trim(); //工程ID
objvCMFunctionKeyWordEN.PrjName = objRow[convCMFunctionKeyWord.PrjName].ToString().Trim(); //工程名称
objvCMFunctionKeyWordEN.FunctionName = objRow[convCMFunctionKeyWord.FunctionName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FunctionName].ToString().Trim(); //功能名称
objvCMFunctionKeyWordEN.FuncContent = objRow[convCMFunctionKeyWord.FuncContent] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncContent].ToString().Trim(); //函数内容
objvCMFunctionKeyWordEN.FuncParaLst = objRow[convCMFunctionKeyWord.FuncParaLst] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncParaLst].ToString().Trim(); //函数参数列表
objvCMFunctionKeyWordEN.FuncComments = objRow[convCMFunctionKeyWord.FuncComments] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.FuncComments].ToString().Trim(); //函数注释
objvCMFunctionKeyWordEN.FunctionSignature = objRow[convCMFunctionKeyWord.FunctionSignature].ToString().Trim(); //函数签名
objvCMFunctionKeyWordEN.Keyword = objRow[convCMFunctionKeyWord.Keyword] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objvCMFunctionKeyWordEN.UpdDate = objRow[convCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objvCMFunctionKeyWordEN.UpdUser = objRow[convCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objvCMFunctionKeyWordEN.Memo = objRow[convCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objvCMFunctionKeyWordEN.ClsName = objRow[convCMFunctionKeyWord.ClsName] == DBNull.Value ? null : objRow[convCMFunctionKeyWord.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFunctionKeyWordEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMFunctionKeyWord(ref clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN)
{
bool bolResult = vCMFunctionKeyWordDA.GetvCMFunctionKeyWord(ref objvCMFunctionKeyWordEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFunctionKeyWordEN GetObjBymId(long lngmId)
{
clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = vCMFunctionKeyWordDA.GetObjBymId(lngmId);
return objvCMFunctionKeyWordEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMFunctionKeyWordEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = vCMFunctionKeyWordDA.GetFirstObj(strWhereCond);
 return objvCMFunctionKeyWordEN;
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
public static clsvCMFunctionKeyWordEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = vCMFunctionKeyWordDA.GetObjByDataRow(objRow);
 return objvCMFunctionKeyWordEN;
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
public static clsvCMFunctionKeyWordEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN = vCMFunctionKeyWordDA.GetObjByDataRow(objRow);
 return objvCMFunctionKeyWordEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvCMFunctionKeyWordObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFunctionKeyWordEN GetObjBymIdFromList(long lngmId, List<clsvCMFunctionKeyWordEN> lstvCMFunctionKeyWordObjLst)
{
foreach (clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN in lstvCMFunctionKeyWordObjLst)
{
if (objvCMFunctionKeyWordEN.mId == lngmId)
{
return objvCMFunctionKeyWordEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvCMFunctionKeyWordDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vCMFunctionKeyWordDA.GetID(strWhereCond);
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
bool bolIsExist = vCMFunctionKeyWordDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vCMFunctionKeyWordDA.IsExist(lngmId);
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
 bolIsExist = clsvCMFunctionKeyWordDA.IsExistTable();
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
 bolIsExist = vCMFunctionKeyWordDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMFunctionKeyWordENS">源对象</param>
 /// <param name = "objvCMFunctionKeyWordENT">目标对象</param>
 public static void CopyTo(clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENS, clsvCMFunctionKeyWordEN objvCMFunctionKeyWordENT)
{
try
{
objvCMFunctionKeyWordENT.mId = objvCMFunctionKeyWordENS.mId; //mId
objvCMFunctionKeyWordENT.CmFunctionId = objvCMFunctionKeyWordENS.CmFunctionId; //函数Id
objvCMFunctionKeyWordENT.CmClassId = objvCMFunctionKeyWordENS.CmClassId; //类Id
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
objvCMFunctionKeyWordENT.ClsName = objvCMFunctionKeyWordENS.ClsName; //类名
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
 /// <param name = "objvCMFunctionKeyWordEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN)
{
try
{
objvCMFunctionKeyWordEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMFunctionKeyWordEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMFunctionKeyWord.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.mId = objvCMFunctionKeyWordEN.mId; //mId
}
if (arrFldSet.Contains(convCMFunctionKeyWord.CmFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.CmFunctionId = objvCMFunctionKeyWordEN.CmFunctionId; //函数Id
}
if (arrFldSet.Contains(convCMFunctionKeyWord.CmClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.CmClassId = objvCMFunctionKeyWordEN.CmClassId; //类Id
}
if (arrFldSet.Contains(convCMFunctionKeyWord.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.ApplicationTypeId = objvCMFunctionKeyWordEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCMFunctionKeyWord.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.ProgLangTypeId = objvCMFunctionKeyWordEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convCMFunctionKeyWord.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.ProgLangTypeName = objvCMFunctionKeyWordEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convCMFunctionKeyWord.ProgLangTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.ProgLangTypeSimName = objvCMFunctionKeyWordEN.ProgLangTypeSimName == "[null]" ? null :  objvCMFunctionKeyWordEN.ProgLangTypeSimName; //编程语言类型简称
}
if (arrFldSet.Contains(convCMFunctionKeyWord.NameSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.NameSpace = objvCMFunctionKeyWordEN.NameSpace == "[null]" ? null :  objvCMFunctionKeyWordEN.NameSpace; //域名
}
if (arrFldSet.Contains(convCMFunctionKeyWord.ProjectPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.ProjectPath = objvCMFunctionKeyWordEN.ProjectPath; //工程路径
}
if (arrFldSet.Contains(convCMFunctionKeyWord.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.FilePath = objvCMFunctionKeyWordEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convCMFunctionKeyWord.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.FileName = objvCMFunctionKeyWordEN.FileName; //文件名
}
if (arrFldSet.Contains(convCMFunctionKeyWord.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.CodeTypeId = objvCMFunctionKeyWordEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convCMFunctionKeyWord.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.UserId = objvCMFunctionKeyWordEN.UserId == "[null]" ? null :  objvCMFunctionKeyWordEN.UserId; //用户Id
}
if (arrFldSet.Contains(convCMFunctionKeyWord.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.PrjId = objvCMFunctionKeyWordEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convCMFunctionKeyWord.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.PrjName = objvCMFunctionKeyWordEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCMFunctionKeyWord.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.FunctionName = objvCMFunctionKeyWordEN.FunctionName == "[null]" ? null :  objvCMFunctionKeyWordEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(convCMFunctionKeyWord.FuncContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.FuncContent = objvCMFunctionKeyWordEN.FuncContent == "[null]" ? null :  objvCMFunctionKeyWordEN.FuncContent; //函数内容
}
if (arrFldSet.Contains(convCMFunctionKeyWord.FuncParaLst, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.FuncParaLst = objvCMFunctionKeyWordEN.FuncParaLst == "[null]" ? null :  objvCMFunctionKeyWordEN.FuncParaLst; //函数参数列表
}
if (arrFldSet.Contains(convCMFunctionKeyWord.FuncComments, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.FuncComments = objvCMFunctionKeyWordEN.FuncComments == "[null]" ? null :  objvCMFunctionKeyWordEN.FuncComments; //函数注释
}
if (arrFldSet.Contains(convCMFunctionKeyWord.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.FunctionSignature = objvCMFunctionKeyWordEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convCMFunctionKeyWord.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.Keyword = objvCMFunctionKeyWordEN.Keyword == "[null]" ? null :  objvCMFunctionKeyWordEN.Keyword; //关键字
}
if (arrFldSet.Contains(convCMFunctionKeyWord.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.UpdDate = objvCMFunctionKeyWordEN.UpdDate == "[null]" ? null :  objvCMFunctionKeyWordEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMFunctionKeyWord.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.UpdUser = objvCMFunctionKeyWordEN.UpdUser == "[null]" ? null :  objvCMFunctionKeyWordEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMFunctionKeyWord.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.Memo = objvCMFunctionKeyWordEN.Memo == "[null]" ? null :  objvCMFunctionKeyWordEN.Memo; //说明
}
if (arrFldSet.Contains(convCMFunctionKeyWord.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFunctionKeyWordEN.ClsName = objvCMFunctionKeyWordEN.ClsName == "[null]" ? null :  objvCMFunctionKeyWordEN.ClsName; //类名
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
 /// <param name = "objvCMFunctionKeyWordEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN)
{
try
{
if (objvCMFunctionKeyWordEN.ProgLangTypeSimName == "[null]") objvCMFunctionKeyWordEN.ProgLangTypeSimName = null; //编程语言类型简称
if (objvCMFunctionKeyWordEN.NameSpace == "[null]") objvCMFunctionKeyWordEN.NameSpace = null; //域名
if (objvCMFunctionKeyWordEN.UserId == "[null]") objvCMFunctionKeyWordEN.UserId = null; //用户Id
if (objvCMFunctionKeyWordEN.FunctionName == "[null]") objvCMFunctionKeyWordEN.FunctionName = null; //功能名称
if (objvCMFunctionKeyWordEN.FuncContent == "[null]") objvCMFunctionKeyWordEN.FuncContent = null; //函数内容
if (objvCMFunctionKeyWordEN.FuncParaLst == "[null]") objvCMFunctionKeyWordEN.FuncParaLst = null; //函数参数列表
if (objvCMFunctionKeyWordEN.FuncComments == "[null]") objvCMFunctionKeyWordEN.FuncComments = null; //函数注释
if (objvCMFunctionKeyWordEN.Keyword == "[null]") objvCMFunctionKeyWordEN.Keyword = null; //关键字
if (objvCMFunctionKeyWordEN.UpdDate == "[null]") objvCMFunctionKeyWordEN.UpdDate = null; //修改日期
if (objvCMFunctionKeyWordEN.UpdUser == "[null]") objvCMFunctionKeyWordEN.UpdUser = null; //修改者
if (objvCMFunctionKeyWordEN.Memo == "[null]") objvCMFunctionKeyWordEN.Memo = null; //说明
if (objvCMFunctionKeyWordEN.ClsName == "[null]") objvCMFunctionKeyWordEN.ClsName = null; //类名
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
public static void CheckProperty4Condition(clsvCMFunctionKeyWordEN objvCMFunctionKeyWordEN)
{
 vCMFunctionKeyWordDA.CheckProperty4Condition(objvCMFunctionKeyWordEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMFunctionKeyWord.mId); 
List<clsvCMFunctionKeyWordEN> arrObjLst = clsvCMFunctionKeyWordBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM函数关键字]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCMFunctionKeyWord.mId); 
IEnumerable<clsvCMFunctionKeyWordEN> arrObjLst = clsvCMFunctionKeyWordBL.GetObjLst(strCondition);
objDDL.DataValueField = convCMFunctionKeyWord.mId;
objDDL.DataTextField = convCMFunctionKeyWord.UserId;
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
public static void BindDdl_mIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM函数关键字]...","0");
List<clsvCMFunctionKeyWordEN> arrvCMFunctionKeyWordObjLst = GetAllvCMFunctionKeyWordObjLstCache(); 
objDDL.DataValueField = convCMFunctionKeyWord.mId;
objDDL.DataTextField = convCMFunctionKeyWord.UserId;
objDDL.DataSource = arrvCMFunctionKeyWordObjLst;
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
if (clsCMFunctionKeyWordBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFunctionKeyWordBL没有刷新缓存机制(clsCMFunctionKeyWordBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCMFunctionKeyWordObjLstCache == null)
//{
//arrvCMFunctionKeyWordObjLstCache = vCMFunctionKeyWordDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFunctionKeyWordEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCMFunctionKeyWordEN._CurrTabName);
List<clsvCMFunctionKeyWordEN> arrvCMFunctionKeyWordObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionKeyWordEN> arrvCMFunctionKeyWordObjLst_Sel =
arrvCMFunctionKeyWordObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCMFunctionKeyWordObjLst_Sel.Count() == 0)
{
   clsvCMFunctionKeyWordEN obj = clsvCMFunctionKeyWordBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCMFunctionKeyWordObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserIdBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsvCMFunctionKeyWordEN objvCMFunctionKeyWord = GetObjBymIdCache(lngmId);
if (objvCMFunctionKeyWord == null) return "";
return objvCMFunctionKeyWord.UserId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsvCMFunctionKeyWordEN objvCMFunctionKeyWord = GetObjBymIdCache(lngmId);
if (objvCMFunctionKeyWord == null) return "";
return objvCMFunctionKeyWord.UserId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFunctionKeyWordEN> GetAllvCMFunctionKeyWordObjLstCache()
{
//获取缓存中的对象列表
List<clsvCMFunctionKeyWordEN> arrvCMFunctionKeyWordObjLstCache = GetObjLstCache(); 
return arrvCMFunctionKeyWordObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFunctionKeyWordEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCMFunctionKeyWordEN._CurrTabName);
List<clsvCMFunctionKeyWordEN> arrvCMFunctionKeyWordObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCMFunctionKeyWordObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-01-26
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convCMFunctionKeyWord.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMFunctionKeyWord.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMFunctionKeyWord.AttributeName));
throw new Exception(strMsg);
}
var objvCMFunctionKeyWord = clsvCMFunctionKeyWordBL.GetObjBymIdCache(lngmId);
if (objvCMFunctionKeyWord == null) return "";
return objvCMFunctionKeyWord[strOutFldName].ToString();
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
int intRecCount = clsvCMFunctionKeyWordDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMFunctionKeyWordDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMFunctionKeyWordDA.GetRecCount();
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
int intRecCount = clsvCMFunctionKeyWordDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMFunctionKeyWordCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMFunctionKeyWordEN objvCMFunctionKeyWordCond)
{
List<clsvCMFunctionKeyWordEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFunctionKeyWordEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFunctionKeyWord.AttributeName)
{
if (objvCMFunctionKeyWordCond.IsUpdated(strFldName) == false) continue;
if (objvCMFunctionKeyWordCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFunctionKeyWordCond[strFldName].ToString());
}
else
{
if (objvCMFunctionKeyWordCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFunctionKeyWordCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFunctionKeyWordCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFunctionKeyWordCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFunctionKeyWordCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFunctionKeyWordCond[strFldName]));
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
 List<string> arrList = clsvCMFunctionKeyWordDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMFunctionKeyWordDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMFunctionKeyWordDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}