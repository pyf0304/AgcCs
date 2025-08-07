
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMClassBL
 表名:vCMClass(00050506)
 * 版本:2024.01.24.1(服务器:WIN-SRV103-116)
 日期:2024/01/26 16:18:05
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
public static class  clsvCMClassBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMClassEN GetObj(this K_CmClassId_vCMClass myKey)
{
clsvCMClassEN objvCMClassEN = clsvCMClassBL.vCMClassDA.GetObjByCmClassId(myKey.Value);
return objvCMClassEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetCmClassId(this clsvCMClassEN objvCMClassEN, string strCmClassId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmClassId, 8, convCMClass.CmClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, convCMClass.CmClassId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetApplicationTypeName(this clsvCMClassEN objvCMClassEN, string strApplicationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convCMClass.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetApplicationTypeSimName(this clsvCMClassEN objvCMClassEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMClass.ApplicationTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetProgLangTypeId(this clsvCMClassEN objvCMClassEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convCMClass.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCMClass.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCMClass.ProgLangTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetProgLangTypeName(this clsvCMClassEN objvCMClassEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convCMClass.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convCMClass.ProgLangTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetProgLangTypeSimName(this clsvCMClassEN objvCMClassEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convCMClass.ProgLangTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetTabName(this clsvCMClassEN objvCMClassEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convCMClass.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convCMClass.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetNameSpace(this clsvCMClassEN objvCMClassEN, string strNameSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convCMClass.NameSpace);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetProjectPath(this clsvCMClassEN objvCMClassEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, convCMClass.ProjectPath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectPath, 500, convCMClass.ProjectPath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFilePath(this clsvCMClassEN objvCMClassEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convCMClass.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convCMClass.FilePath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFileName(this clsvCMClassEN objvCMClassEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convCMClass.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convCMClass.FileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFuncModuleAgcId(this clsvCMClassEN objvCMClassEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convCMClass.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMClass.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMClass.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFuncModuleName(this clsvCMClassEN objvCMClassEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCMClass.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMClass.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFuncModuleNameSim(this clsvCMClassEN objvCMClassEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convCMClass.FuncModuleNameSim);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetCodeTypeId(this clsvCMClassEN objvCMClassEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convCMClass.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCMClass.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCMClass.CodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetCodeTypeName(this clsvCMClassEN objvCMClassEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convCMClass.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convCMClass.CodeTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetCodeTypeSimName(this clsvCMClassEN objvCMClassEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, convCMClass.CodeTypeSimName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convCMClass.CodeTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetUserId(this clsvCMClassEN objvCMClassEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convCMClass.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetPrjId(this clsvCMClassEN objvCMClassEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMClass.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMClass.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMClass.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetPrjName(this clsvCMClassEN objvCMClassEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMClass.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMClass.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetUpdDate(this clsvCMClassEN objvCMClassEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMClass.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetUpdUser(this clsvCMClassEN objvCMClassEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMClass.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetMemo(this clsvCMClassEN objvCMClassEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMClass.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassEN SetFuncNum(this clsvCMClassEN objvCMClassEN, int? intFuncNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMClassENS">源对象</param>
 /// <param name = "objvCMClassENT">目标对象</param>
 public static void CopyTo(this clsvCMClassEN objvCMClassENS, clsvCMClassEN objvCMClassENT)
{
try
{
objvCMClassENT.CmClassId = objvCMClassENS.CmClassId; //类Id
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
objvCMClassENT.ClsName = objvCMClassENS.ClsName; //类名
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
 /// <param name = "objvCMClassENS">源对象</param>
 /// <returns>目标对象=>clsvCMClassEN:objvCMClassENT</returns>
 public static clsvCMClassEN CopyTo(this clsvCMClassEN objvCMClassENS)
{
try
{
 clsvCMClassEN objvCMClassENT = new clsvCMClassEN()
{
CmClassId = objvCMClassENS.CmClassId, //类Id
ApplicationTypeId = objvCMClassENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvCMClassENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeSimName = objvCMClassENS.ApplicationTypeSimName, //应用程序类型简称
ProgLangTypeId = objvCMClassENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvCMClassENS.ProgLangTypeName, //编程语言类型名
ProgLangTypeSimName = objvCMClassENS.ProgLangTypeSimName, //编程语言类型简称
TabName = objvCMClassENS.TabName, //表名
NameSpace = objvCMClassENS.NameSpace, //域名
ProjectPath = objvCMClassENS.ProjectPath, //工程路径
FilePath = objvCMClassENS.FilePath, //文件路径
FileName = objvCMClassENS.FileName, //文件名
FileText = objvCMClassENS.FileText, //文件内容
FuncModuleAgcId = objvCMClassENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvCMClassENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objvCMClassENS.FuncModuleNameSim, //功能模块简称
CodeTypeId = objvCMClassENS.CodeTypeId, //代码类型Id
CodeTypeName = objvCMClassENS.CodeTypeName, //代码类型名
CodeTypeSimName = objvCMClassENS.CodeTypeSimName, //简称
UserId = objvCMClassENS.UserId, //用户Id
PrjId = objvCMClassENS.PrjId, //工程ID
PrjName = objvCMClassENS.PrjName, //工程名称
IsOpen = objvCMClassENS.IsOpen, //是否开放
UpdDate = objvCMClassENS.UpdDate, //修改日期
UpdUser = objvCMClassENS.UpdUser, //修改者
Memo = objvCMClassENS.Memo, //说明
FuncNum = objvCMClassENS.FuncNum, //函数个数
ClsName = objvCMClassENS.ClsName, //类名
};
 return objvCMClassENT;
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
public static void CheckProperty4Condition(this clsvCMClassEN objvCMClassEN)
{
 clsvCMClassBL.vCMClassDA.CheckProperty4Condition(objvCMClassEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
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
if (objvCMClassCond.IsUpdated(convCMClass.ClsName) == true)
{
string strComparisonOpClsName = objvCMClassCond.dicFldComparisonOp[convCMClass.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClass.ClsName, objvCMClassCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMClass
{
public virtual bool UpdRelaTabDate(string strCmClassId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM类(vCMClass)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMClassBL
{
public static RelatedActions_vCMClass relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMClassDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMClassDA vCMClassDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMClassDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMClassBL()
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
if (string.IsNullOrEmpty(clsvCMClassEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMClassEN._ConnectString);
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
public static DataTable GetDataTable_vCMClass(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMClassDA.GetDataTable_vCMClass(strWhereCond);
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
objDT = vCMClassDA.GetDataTable(strWhereCond);
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
objDT = vCMClassDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMClassDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMClassDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMClassDA.GetDataTable_Top(objTopPara);
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
objDT = vCMClassDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmClassIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCMClassEN> GetObjLstByCmClassIdLst(List<string> arrCmClassIdLst)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmClassIdLst, true);
 string strWhereCond = string.Format("CmClassId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmClassIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMClassEN> GetObjLstByCmClassIdLstCache(List<string> arrCmClassIdLst)
{
string strKey = string.Format("{0}", clsvCMClassEN._CurrTabName);
List<clsvCMClassEN> arrvCMClassObjLstCache = GetObjLstCache();
IEnumerable <clsvCMClassEN> arrvCMClassObjLst_Sel =
arrvCMClassObjLstCache
.Where(x => arrCmClassIdLst.Contains(x.CmClassId));
return arrvCMClassObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMClassEN> GetObjLst(string strWhereCond)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
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
public static List<clsvCMClassEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMClassEN> GetSubObjLstCache(clsvCMClassEN objvCMClassCond)
{
List<clsvCMClassEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMClass.AttributeName)
{
if (objvCMClassCond.IsUpdated(strFldName) == false) continue;
if (objvCMClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMClassCond[strFldName].ToString());
}
else
{
if (objvCMClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMClassCond[strFldName]));
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
public static List<clsvCMClassEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
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
public static List<clsvCMClassEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
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
List<clsvCMClassEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMClassEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMClassEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMClassEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
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
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
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
public static List<clsvCMClassEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
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
public static List<clsvCMClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMClassEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMClassEN> arrObjLst = new List<clsvCMClassEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassEN objvCMClassEN = new clsvCMClassEN();
try
{
objvCMClassEN.CmClassId = objRow[convCMClass.CmClassId].ToString().Trim(); //类Id
objvCMClassEN.ApplicationTypeId = Int32.Parse(objRow[convCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassEN.ApplicationTypeName = objRow[convCMClass.ApplicationTypeName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMClassEN.ApplicationTypeSimName = objRow[convCMClass.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMClassEN.ProgLangTypeId = objRow[convCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassEN.ProgLangTypeName = objRow[convCMClass.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCMClassEN.ProgLangTypeSimName = objRow[convCMClass.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCMClass.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCMClassEN.TabName = objRow[convCMClass.TabName].ToString().Trim(); //表名
objvCMClassEN.NameSpace = objRow[convCMClass.NameSpace] == DBNull.Value ? null : objRow[convCMClass.NameSpace].ToString().Trim(); //域名
objvCMClassEN.ProjectPath = objRow[convCMClass.ProjectPath].ToString().Trim(); //工程路径
objvCMClassEN.FilePath = objRow[convCMClass.FilePath].ToString().Trim(); //文件路径
objvCMClassEN.FileName = objRow[convCMClass.FileName].ToString().Trim(); //文件名
objvCMClassEN.FileText = objRow[convCMClass.FileText] == DBNull.Value ? null : objRow[convCMClass.FileText].ToString().Trim(); //文件内容
objvCMClassEN.FuncModuleAgcId = objRow[convCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMClassEN.FuncModuleName = objRow[convCMClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMClassEN.FuncModuleNameSim = objRow[convCMClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCMClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCMClassEN.CodeTypeId = objRow[convCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objvCMClassEN.CodeTypeName = objRow[convCMClass.CodeTypeName].ToString().Trim(); //代码类型名
objvCMClassEN.CodeTypeSimName = objRow[convCMClass.CodeTypeSimName].ToString().Trim(); //简称
objvCMClassEN.UserId = objRow[convCMClass.UserId] == DBNull.Value ? null : objRow[convCMClass.UserId].ToString().Trim(); //用户Id
objvCMClassEN.PrjId = objRow[convCMClass.PrjId].ToString().Trim(); //工程ID
objvCMClassEN.PrjName = objRow[convCMClass.PrjName].ToString().Trim(); //工程名称
objvCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convCMClass.IsOpen].ToString().Trim()); //是否开放
objvCMClassEN.UpdDate = objRow[convCMClass.UpdDate] == DBNull.Value ? null : objRow[convCMClass.UpdDate].ToString().Trim(); //修改日期
objvCMClassEN.UpdUser = objRow[convCMClass.UpdUser] == DBNull.Value ? null : objRow[convCMClass.UpdUser].ToString().Trim(); //修改者
objvCMClassEN.Memo = objRow[convCMClass.Memo] == DBNull.Value ? null : objRow[convCMClass.Memo].ToString().Trim(); //说明
objvCMClassEN.FuncNum = objRow[convCMClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClass.FuncNum].ToString().Trim()); //函数个数
objvCMClassEN.ClsName = objRow[convCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMClassEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMClass(ref clsvCMClassEN objvCMClassEN)
{
bool bolResult = vCMClassDA.GetvCMClass(ref objvCMClassEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMClassEN GetObjByCmClassId(string strCmClassId)
{
if (strCmClassId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmClassId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmClassId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmClassId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCMClassEN objvCMClassEN = vCMClassDA.GetObjByCmClassId(strCmClassId);
return objvCMClassEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMClassEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMClassEN objvCMClassEN = vCMClassDA.GetFirstObj(strWhereCond);
 return objvCMClassEN;
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
public static clsvCMClassEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMClassEN objvCMClassEN = vCMClassDA.GetObjByDataRow(objRow);
 return objvCMClassEN;
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
public static clsvCMClassEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMClassEN objvCMClassEN = vCMClassDA.GetObjByDataRow(objRow);
 return objvCMClassEN;
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
 /// <param name = "strCmClassId">所给的关键字</param>
 /// <param name = "lstvCMClassObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMClassEN GetObjByCmClassIdFromList(string strCmClassId, List<clsvCMClassEN> lstvCMClassObjLst)
{
foreach (clsvCMClassEN objvCMClassEN in lstvCMClassObjLst)
{
if (objvCMClassEN.CmClassId == strCmClassId)
{
return objvCMClassEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxCmClassId;
 try
 {
 strMaxCmClassId = clsvCMClassDA.GetMaxStrId();
 return strMaxCmClassId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strCmClassId;
 try
 {
 strCmClassId = new clsvCMClassDA().GetFirstID(strWhereCond);
 return strCmClassId;
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
 arrList = vCMClassDA.GetID(strWhereCond);
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
bool bolIsExist = vCMClassDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmClassId)
{
if (string.IsNullOrEmpty(strCmClassId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmClassId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCMClassDA.IsExist(strCmClassId);
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
 bolIsExist = clsvCMClassDA.IsExistTable();
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
 bolIsExist = vCMClassDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMClassENS">源对象</param>
 /// <param name = "objvCMClassENT">目标对象</param>
 public static void CopyTo(clsvCMClassEN objvCMClassENS, clsvCMClassEN objvCMClassENT)
{
try
{
objvCMClassENT.CmClassId = objvCMClassENS.CmClassId; //类Id
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
objvCMClassENT.ClsName = objvCMClassENS.ClsName; //类名
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
 /// <param name = "objvCMClassEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMClassEN objvCMClassEN)
{
try
{
objvCMClassEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMClassEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMClass.CmClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.CmClassId = objvCMClassEN.CmClassId; //类Id
}
if (arrFldSet.Contains(convCMClass.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.ApplicationTypeId = objvCMClassEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCMClass.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.ApplicationTypeName = objvCMClassEN.ApplicationTypeName == "[null]" ? null :  objvCMClassEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convCMClass.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.ApplicationTypeSimName = objvCMClassEN.ApplicationTypeSimName == "[null]" ? null :  objvCMClassEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convCMClass.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.ProgLangTypeId = objvCMClassEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convCMClass.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.ProgLangTypeName = objvCMClassEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convCMClass.ProgLangTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.ProgLangTypeSimName = objvCMClassEN.ProgLangTypeSimName == "[null]" ? null :  objvCMClassEN.ProgLangTypeSimName; //编程语言类型简称
}
if (arrFldSet.Contains(convCMClass.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.TabName = objvCMClassEN.TabName; //表名
}
if (arrFldSet.Contains(convCMClass.NameSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.NameSpace = objvCMClassEN.NameSpace == "[null]" ? null :  objvCMClassEN.NameSpace; //域名
}
if (arrFldSet.Contains(convCMClass.ProjectPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.ProjectPath = objvCMClassEN.ProjectPath; //工程路径
}
if (arrFldSet.Contains(convCMClass.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.FilePath = objvCMClassEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convCMClass.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.FileName = objvCMClassEN.FileName; //文件名
}
if (arrFldSet.Contains(convCMClass.FileText, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.FileText = objvCMClassEN.FileText == "[null]" ? null :  objvCMClassEN.FileText; //文件内容
}
if (arrFldSet.Contains(convCMClass.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.FuncModuleAgcId = objvCMClassEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convCMClass.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.FuncModuleName = objvCMClassEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCMClass.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.FuncModuleNameSim = objvCMClassEN.FuncModuleNameSim == "[null]" ? null :  objvCMClassEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convCMClass.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.CodeTypeId = objvCMClassEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convCMClass.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.CodeTypeName = objvCMClassEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convCMClass.CodeTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.CodeTypeSimName = objvCMClassEN.CodeTypeSimName; //简称
}
if (arrFldSet.Contains(convCMClass.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.UserId = objvCMClassEN.UserId == "[null]" ? null :  objvCMClassEN.UserId; //用户Id
}
if (arrFldSet.Contains(convCMClass.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.PrjId = objvCMClassEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convCMClass.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.PrjName = objvCMClassEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCMClass.IsOpen, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.IsOpen = objvCMClassEN.IsOpen; //是否开放
}
if (arrFldSet.Contains(convCMClass.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.UpdDate = objvCMClassEN.UpdDate == "[null]" ? null :  objvCMClassEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMClass.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.UpdUser = objvCMClassEN.UpdUser == "[null]" ? null :  objvCMClassEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMClass.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.Memo = objvCMClassEN.Memo == "[null]" ? null :  objvCMClassEN.Memo; //说明
}
if (arrFldSet.Contains(convCMClass.FuncNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.FuncNum = objvCMClassEN.FuncNum; //函数个数
}
if (arrFldSet.Contains(convCMClass.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassEN.ClsName = objvCMClassEN.ClsName; //类名
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
 /// <param name = "objvCMClassEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMClassEN objvCMClassEN)
{
try
{
if (objvCMClassEN.ApplicationTypeName == "[null]") objvCMClassEN.ApplicationTypeName = null; //应用程序类型名称
if (objvCMClassEN.ApplicationTypeSimName == "[null]") objvCMClassEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvCMClassEN.ProgLangTypeSimName == "[null]") objvCMClassEN.ProgLangTypeSimName = null; //编程语言类型简称
if (objvCMClassEN.NameSpace == "[null]") objvCMClassEN.NameSpace = null; //域名
if (objvCMClassEN.FileText == "[null]") objvCMClassEN.FileText = null; //文件内容
if (objvCMClassEN.FuncModuleNameSim == "[null]") objvCMClassEN.FuncModuleNameSim = null; //功能模块简称
if (objvCMClassEN.UserId == "[null]") objvCMClassEN.UserId = null; //用户Id
if (objvCMClassEN.UpdDate == "[null]") objvCMClassEN.UpdDate = null; //修改日期
if (objvCMClassEN.UpdUser == "[null]") objvCMClassEN.UpdUser = null; //修改者
if (objvCMClassEN.Memo == "[null]") objvCMClassEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCMClassEN objvCMClassEN)
{
 vCMClassDA.CheckProperty4Condition(objvCMClassEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CmClassId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMClass.CmClassId); 
List<clsvCMClassEN> arrObjLst = clsvCMClassBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CmClassId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM类]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCMClass.CmClassId); 
IEnumerable<clsvCMClassEN> arrObjLst = clsvCMClassBL.GetObjLst(strCondition);
objDDL.DataValueField = convCMClass.CmClassId;
objDDL.DataTextField = convCMClass.UserId;
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
public static void BindDdl_CmClassIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM类]...","0");
List<clsvCMClassEN> arrvCMClassObjLst = GetAllvCMClassObjLstCache(); 
objDDL.DataValueField = convCMClass.CmClassId;
objDDL.DataTextField = convCMClass.UserId;
objDDL.DataSource = arrvCMClassObjLst;
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
//string strWhereCond = string.Format("1 = 1 order by CmClassId");
//if (arrvCMClassObjLstCache == null)
//{
//arrvCMClassObjLstCache = vCMClassDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmClassId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMClassEN GetObjByCmClassIdCache(string strCmClassId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCMClassEN._CurrTabName);
List<clsvCMClassEN> arrvCMClassObjLstCache = GetObjLstCache();
IEnumerable <clsvCMClassEN> arrvCMClassObjLst_Sel =
arrvCMClassObjLstCache
.Where(x=> x.CmClassId == strCmClassId 
);
if (arrvCMClassObjLst_Sel.Count() == 0)
{
   clsvCMClassEN obj = clsvCMClassBL.GetObjByCmClassId(strCmClassId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCMClassObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmClassId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserIdByCmClassIdCache(string strCmClassId)
{
if (string.IsNullOrEmpty(strCmClassId) == true) return "";
//获取缓存中的对象列表
clsvCMClassEN objvCMClass = GetObjByCmClassIdCache(strCmClassId);
if (objvCMClass == null) return "";
return objvCMClass.UserId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmClassId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmClassIdCache(string strCmClassId)
{
if (string.IsNullOrEmpty(strCmClassId) == true) return "";
//获取缓存中的对象列表
clsvCMClassEN objvCMClass = GetObjByCmClassIdCache(strCmClassId);
if (objvCMClass == null) return "";
return objvCMClass.UserId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMClassEN> GetAllvCMClassObjLstCache()
{
//获取缓存中的对象列表
List<clsvCMClassEN> arrvCMClassObjLstCache = GetObjLstCache(); 
return arrvCMClassObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMClassEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCMClassEN._CurrTabName);
List<clsvCMClassEN> arrvCMClassObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCMClassObjLstCache;
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
public static string Func(string strInFldName, string strOutFldName, string strCmClassId)
{
if (strInFldName != convCMClass.CmClassId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMClass.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMClass.AttributeName));
throw new Exception(strMsg);
}
var objvCMClass = clsvCMClassBL.GetObjByCmClassIdCache(strCmClassId);
if (objvCMClass == null) return "";
return objvCMClass[strOutFldName].ToString();
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
int intRecCount = clsvCMClassDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMClassDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMClassDA.GetRecCount();
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
int intRecCount = clsvCMClassDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMClassEN objvCMClassCond)
{
List<clsvCMClassEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMClass.AttributeName)
{
if (objvCMClassCond.IsUpdated(strFldName) == false) continue;
if (objvCMClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMClassCond[strFldName].ToString());
}
else
{
if (objvCMClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMClassCond[strFldName]));
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
 List<string> arrList = clsvCMClassDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMClassDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMClassDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}