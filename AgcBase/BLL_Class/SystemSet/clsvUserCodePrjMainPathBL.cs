
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserCodePrjMainPathBL
 表名:vUserCodePrjMainPath(00050339)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvUserCodePrjMainPathBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserCodePrjMainPathEN GetObj(this K_UserCodePrjMainPathId_vUserCodePrjMainPath myKey)
{
clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = clsvUserCodePrjMainPathBL.vUserCodePrjMainPathDA.GetObjByUserCodePrjMainPathId(myKey.Value);
return objvUserCodePrjMainPathEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetApplicationTypeENName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strApplicationTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convUserCodePrjMainPath.ApplicationTypeENName);
}
objvUserCodePrjMainPathEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.ApplicationTypeENName) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.ApplicationTypeENName, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.ApplicationTypeENName] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserCodePrjMainPathId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserCodePrjMainPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserCodePrjMainPathId, 8, convUserCodePrjMainPath.UserCodePrjMainPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserCodePrjMainPathId, 8, convUserCodePrjMainPath.UserCodePrjMainPathId);
}
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = strUserCodePrjMainPathId; //生成主目录Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.UserCodePrjMainPathId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.UserCodePrjMainPathId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.UserCodePrjMainPathId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetCMProjectAppRelaId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, long lngCMProjectAppRelaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngCMProjectAppRelaId, convUserCodePrjMainPath.CMProjectAppRelaId);
objvUserCodePrjMainPathEN.CMProjectAppRelaId = lngCMProjectAppRelaId; //Cm工程应用关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.CMProjectAppRelaId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.CMProjectAppRelaId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.CMProjectAppRelaId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetPrjId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convUserCodePrjMainPath.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserCodePrjMainPath.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserCodePrjMainPath.PrjId);
}
objvUserCodePrjMainPathEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.PrjId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.PrjId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.PrjId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetPrjName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convUserCodePrjMainPath.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convUserCodePrjMainPath.PrjName);
}
objvUserCodePrjMainPathEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.PrjName) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.PrjName, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.PrjName] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetProgLangTypeId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strProgLangTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convUserCodePrjMainPath.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convUserCodePrjMainPath.ProgLangTypeId);
}
objvUserCodePrjMainPathEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.ProgLangTypeId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.ProgLangTypeId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.ProgLangTypeId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convUserCodePrjMainPath.UserId);
}
objvUserCodePrjMainPathEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.UserId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.UserId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.UserId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUserCodePrjMainPath.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convUserCodePrjMainPath.UserName);
}
objvUserCodePrjMainPathEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.UserName) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.UserName, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.UserName] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetDepartmentId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, convUserCodePrjMainPath.DepartmentId);
}
objvUserCodePrjMainPathEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.DepartmentId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.DepartmentId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.DepartmentId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetDepartmentName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convUserCodePrjMainPath.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 30, convUserCodePrjMainPath.DepartmentName);
}
objvUserCodePrjMainPathEN.DepartmentName = strDepartmentName; //部门名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.DepartmentName) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.DepartmentName, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.DepartmentName] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserStateId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convUserCodePrjMainPath.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convUserCodePrjMainPath.UserStateId);
}
objvUserCodePrjMainPathEN.UserStateId = strUserStateId; //用户状态号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.UserStateId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.UserStateId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.UserStateId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserStateName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convUserCodePrjMainPath.UserStateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convUserCodePrjMainPath.UserStateName);
}
objvUserCodePrjMainPathEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.UserStateName) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.UserStateName, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.UserStateName] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetIsUsePrjMainPath(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, bool bolIsUsePrjMainPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUsePrjMainPath, convUserCodePrjMainPath.IsUsePrjMainPath);
objvUserCodePrjMainPathEN.IsUsePrjMainPath = bolIsUsePrjMainPath; //是否使用主路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.IsUsePrjMainPath) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.IsUsePrjMainPath, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.IsUsePrjMainPath] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetIncludeXmlPath(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strIncludeXmlPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIncludeXmlPath, 150, convUserCodePrjMainPath.IncludeXmlPath);
}
objvUserCodePrjMainPathEN.IncludeXmlPath = strIncludeXmlPath; //包含表Xml路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.IncludeXmlPath) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.IncludeXmlPath, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.IncludeXmlPath] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetIsTemplate(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convUserCodePrjMainPath.IsTemplate);
objvUserCodePrjMainPathEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.IsTemplate) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.IsTemplate, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.IsTemplate] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetInUse(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, bool bolInUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInUse, convUserCodePrjMainPath.InUse);
objvUserCodePrjMainPathEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.InUse) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.InUse, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.InUse] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUpdDate(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserCodePrjMainPath.UpdDate);
}
objvUserCodePrjMainPathEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.UpdDate) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.UpdDate, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.UpdDate] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUpdUserId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convUserCodePrjMainPath.UpdUserId);
}
objvUserCodePrjMainPathEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.UpdUserId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.UpdUserId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.UpdUserId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetMemo(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserCodePrjMainPath.Memo);
}
objvUserCodePrjMainPathEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.Memo) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.Memo, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.Memo] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetApplicationTypeSimName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convUserCodePrjMainPath.ApplicationTypeSimName);
}
objvUserCodePrjMainPathEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.ApplicationTypeSimName) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetCmPrjName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convUserCodePrjMainPath.CmPrjName);
}
objvUserCodePrjMainPathEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.CmPrjName) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.CmPrjName, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.CmPrjName] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetApplicationTypeName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strApplicationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convUserCodePrjMainPath.ApplicationTypeName);
}
objvUserCodePrjMainPathEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.ApplicationTypeName) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.ApplicationTypeName, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.ApplicationTypeName] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetApplicationTypeId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convUserCodePrjMainPath.ApplicationTypeId);
objvUserCodePrjMainPathEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.ApplicationTypeId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.ApplicationTypeId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.ApplicationTypeId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetCmPrjId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strCmPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convUserCodePrjMainPath.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convUserCodePrjMainPath.CmPrjId);
}
objvUserCodePrjMainPathEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.CmPrjId) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.CmPrjId, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.CmPrjId] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetAppOrderNum(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, int? intAppOrderNum, string strComparisonOp="")
	{
objvUserCodePrjMainPathEN.AppOrderNum = intAppOrderNum; //AppOrderNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.AppOrderNum) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.AppOrderNum, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.AppOrderNum] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetAppIsVisible(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, bool bolAppIsVisible, string strComparisonOp="")
	{
objvUserCodePrjMainPathEN.AppIsVisible = bolAppIsVisible; //AppIsVisible
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(convUserCodePrjMainPath.AppIsVisible) == false)
{
objvUserCodePrjMainPathEN.dicFldComparisonOp.Add(convUserCodePrjMainPath.AppIsVisible, strComparisonOp);
}
else
{
objvUserCodePrjMainPathEN.dicFldComparisonOp[convUserCodePrjMainPath.AppIsVisible] = strComparisonOp;
}
}
return objvUserCodePrjMainPathEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathENS">源对象</param>
 /// <param name = "objvUserCodePrjMainPathENT">目标对象</param>
 public static void CopyTo(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathENS, clsvUserCodePrjMainPathEN objvUserCodePrjMainPathENT)
{
try
{
objvUserCodePrjMainPathENT.ApplicationTypeENName = objvUserCodePrjMainPathENS.ApplicationTypeENName; //应用类型英文名
objvUserCodePrjMainPathENT.UserCodePrjMainPathId = objvUserCodePrjMainPathENS.UserCodePrjMainPathId; //生成主目录Id
objvUserCodePrjMainPathENT.CMProjectAppRelaId = objvUserCodePrjMainPathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objvUserCodePrjMainPathENT.PrjId = objvUserCodePrjMainPathENS.PrjId; //工程Id
objvUserCodePrjMainPathENT.PrjName = objvUserCodePrjMainPathENS.PrjName; //工程名称
objvUserCodePrjMainPathENT.ProgLangTypeId = objvUserCodePrjMainPathENS.ProgLangTypeId; //编程语言类型Id
objvUserCodePrjMainPathENT.UserId = objvUserCodePrjMainPathENS.UserId; //用户Id
objvUserCodePrjMainPathENT.UserName = objvUserCodePrjMainPathENS.UserName; //用户名
objvUserCodePrjMainPathENT.DepartmentId = objvUserCodePrjMainPathENS.DepartmentId; //部门ID
objvUserCodePrjMainPathENT.DepartmentName = objvUserCodePrjMainPathENS.DepartmentName; //部门名称
objvUserCodePrjMainPathENT.UserStateId = objvUserCodePrjMainPathENS.UserStateId; //用户状态号
objvUserCodePrjMainPathENT.UserStateName = objvUserCodePrjMainPathENS.UserStateName; //用户状态名
objvUserCodePrjMainPathENT.IsUsePrjMainPath = objvUserCodePrjMainPathENS.IsUsePrjMainPath; //是否使用主路径
objvUserCodePrjMainPathENT.IncludeXmlPath = objvUserCodePrjMainPathENS.IncludeXmlPath; //包含表Xml路径
objvUserCodePrjMainPathENT.IsTemplate = objvUserCodePrjMainPathENS.IsTemplate; //是否模板
objvUserCodePrjMainPathENT.InUse = objvUserCodePrjMainPathENS.InUse; //是否在用
objvUserCodePrjMainPathENT.UpdDate = objvUserCodePrjMainPathENS.UpdDate; //修改日期
objvUserCodePrjMainPathENT.UpdUserId = objvUserCodePrjMainPathENS.UpdUserId; //修改用户Id
objvUserCodePrjMainPathENT.Memo = objvUserCodePrjMainPathENS.Memo; //说明
objvUserCodePrjMainPathENT.ApplicationTypeSimName = objvUserCodePrjMainPathENS.ApplicationTypeSimName; //应用程序类型简称
objvUserCodePrjMainPathENT.CmPrjName = objvUserCodePrjMainPathENS.CmPrjName; //CM工程名
objvUserCodePrjMainPathENT.ApplicationTypeName = objvUserCodePrjMainPathENS.ApplicationTypeName; //应用程序类型名称
objvUserCodePrjMainPathENT.ApplicationTypeId = objvUserCodePrjMainPathENS.ApplicationTypeId; //应用程序类型ID
objvUserCodePrjMainPathENT.CmPrjId = objvUserCodePrjMainPathENS.CmPrjId; //Cm工程Id
objvUserCodePrjMainPathENT.AppOrderNum = objvUserCodePrjMainPathENS.AppOrderNum; //AppOrderNum
objvUserCodePrjMainPathENT.AppIsVisible = objvUserCodePrjMainPathENS.AppIsVisible; //AppIsVisible
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
 /// <param name = "objvUserCodePrjMainPathENS">源对象</param>
 /// <returns>目标对象=>clsvUserCodePrjMainPathEN:objvUserCodePrjMainPathENT</returns>
 public static clsvUserCodePrjMainPathEN CopyTo(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathENS)
{
try
{
 clsvUserCodePrjMainPathEN objvUserCodePrjMainPathENT = new clsvUserCodePrjMainPathEN()
{
ApplicationTypeENName = objvUserCodePrjMainPathENS.ApplicationTypeENName, //应用类型英文名
UserCodePrjMainPathId = objvUserCodePrjMainPathENS.UserCodePrjMainPathId, //生成主目录Id
CMProjectAppRelaId = objvUserCodePrjMainPathENS.CMProjectAppRelaId, //Cm工程应用关系Id
PrjId = objvUserCodePrjMainPathENS.PrjId, //工程Id
PrjName = objvUserCodePrjMainPathENS.PrjName, //工程名称
ProgLangTypeId = objvUserCodePrjMainPathENS.ProgLangTypeId, //编程语言类型Id
UserId = objvUserCodePrjMainPathENS.UserId, //用户Id
UserName = objvUserCodePrjMainPathENS.UserName, //用户名
DepartmentId = objvUserCodePrjMainPathENS.DepartmentId, //部门ID
DepartmentName = objvUserCodePrjMainPathENS.DepartmentName, //部门名称
UserStateId = objvUserCodePrjMainPathENS.UserStateId, //用户状态号
UserStateName = objvUserCodePrjMainPathENS.UserStateName, //用户状态名
IsUsePrjMainPath = objvUserCodePrjMainPathENS.IsUsePrjMainPath, //是否使用主路径
IncludeXmlPath = objvUserCodePrjMainPathENS.IncludeXmlPath, //包含表Xml路径
IsTemplate = objvUserCodePrjMainPathENS.IsTemplate, //是否模板
InUse = objvUserCodePrjMainPathENS.InUse, //是否在用
UpdDate = objvUserCodePrjMainPathENS.UpdDate, //修改日期
UpdUserId = objvUserCodePrjMainPathENS.UpdUserId, //修改用户Id
Memo = objvUserCodePrjMainPathENS.Memo, //说明
ApplicationTypeSimName = objvUserCodePrjMainPathENS.ApplicationTypeSimName, //应用程序类型简称
CmPrjName = objvUserCodePrjMainPathENS.CmPrjName, //CM工程名
ApplicationTypeName = objvUserCodePrjMainPathENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeId = objvUserCodePrjMainPathENS.ApplicationTypeId, //应用程序类型ID
CmPrjId = objvUserCodePrjMainPathENS.CmPrjId, //Cm工程Id
AppOrderNum = objvUserCodePrjMainPathENS.AppOrderNum, //AppOrderNum
AppIsVisible = objvUserCodePrjMainPathENS.AppIsVisible, //AppIsVisible
};
 return objvUserCodePrjMainPathENT;
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
public static void CheckProperty4Condition(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
{
 clsvUserCodePrjMainPathBL.vUserCodePrjMainPathDA.CheckProperty4Condition(objvUserCodePrjMainPathEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.ApplicationTypeENName, objvUserCodePrjMainPathCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.UserCodePrjMainPathId) == true)
{
string strComparisonOpUserCodePrjMainPathId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.UserCodePrjMainPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.UserCodePrjMainPathId, objvUserCodePrjMainPathCond.UserCodePrjMainPathId, strComparisonOpUserCodePrjMainPathId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.CMProjectAppRelaId) == true)
{
string strComparisonOpCMProjectAppRelaId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.CMProjectAppRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserCodePrjMainPath.CMProjectAppRelaId, objvUserCodePrjMainPathCond.CMProjectAppRelaId, strComparisonOpCMProjectAppRelaId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.PrjId) == true)
{
string strComparisonOpPrjId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.PrjId, objvUserCodePrjMainPathCond.PrjId, strComparisonOpPrjId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.PrjName) == true)
{
string strComparisonOpPrjName = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.PrjName, objvUserCodePrjMainPathCond.PrjName, strComparisonOpPrjName);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.ProgLangTypeId, objvUserCodePrjMainPathCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.UserId) == true)
{
string strComparisonOpUserId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.UserId, objvUserCodePrjMainPathCond.UserId, strComparisonOpUserId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.UserName) == true)
{
string strComparisonOpUserName = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.UserName, objvUserCodePrjMainPathCond.UserName, strComparisonOpUserName);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.DepartmentId, objvUserCodePrjMainPathCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.DepartmentName, objvUserCodePrjMainPathCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.UserStateId) == true)
{
string strComparisonOpUserStateId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.UserStateId, objvUserCodePrjMainPathCond.UserStateId, strComparisonOpUserStateId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.UserStateName) == true)
{
string strComparisonOpUserStateName = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.UserStateName, objvUserCodePrjMainPathCond.UserStateName, strComparisonOpUserStateName);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.IsUsePrjMainPath) == true)
{
if (objvUserCodePrjMainPathCond.IsUsePrjMainPath == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePrjMainPath.IsUsePrjMainPath);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePrjMainPath.IsUsePrjMainPath);
}
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.IncludeXmlPath) == true)
{
string strComparisonOpIncludeXmlPath = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.IncludeXmlPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.IncludeXmlPath, objvUserCodePrjMainPathCond.IncludeXmlPath, strComparisonOpIncludeXmlPath);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.IsTemplate) == true)
{
if (objvUserCodePrjMainPathCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePrjMainPath.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePrjMainPath.IsTemplate);
}
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.InUse) == true)
{
if (objvUserCodePrjMainPathCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePrjMainPath.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePrjMainPath.InUse);
}
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.UpdDate) == true)
{
string strComparisonOpUpdDate = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.UpdDate, objvUserCodePrjMainPathCond.UpdDate, strComparisonOpUpdDate);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.UpdUserId, objvUserCodePrjMainPathCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.Memo) == true)
{
string strComparisonOpMemo = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.Memo, objvUserCodePrjMainPathCond.Memo, strComparisonOpMemo);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.ApplicationTypeSimName, objvUserCodePrjMainPathCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.CmPrjName, objvUserCodePrjMainPathCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.ApplicationTypeName, objvUserCodePrjMainPathCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserCodePrjMainPath.ApplicationTypeId, objvUserCodePrjMainPathCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePrjMainPath.CmPrjId, objvUserCodePrjMainPathCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.AppOrderNum) == true)
{
string strComparisonOpAppOrderNum = objvUserCodePrjMainPathCond.dicFldComparisonOp[convUserCodePrjMainPath.AppOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convUserCodePrjMainPath.AppOrderNum, objvUserCodePrjMainPathCond.AppOrderNum, strComparisonOpAppOrderNum);
}
if (objvUserCodePrjMainPathCond.IsUpdated(convUserCodePrjMainPath.AppIsVisible) == true)
{
if (objvUserCodePrjMainPathCond.AppIsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePrjMainPath.AppIsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePrjMainPath.AppIsVisible);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUserCodePrjMainPath
{
public virtual bool UpdRelaTabDate(string strUserCodePrjMainPathId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户生成项目主路径(vUserCodePrjMainPath)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUserCodePrjMainPathBL
{
public static RelatedActions_vUserCodePrjMainPath relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUserCodePrjMainPathDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUserCodePrjMainPathDA vUserCodePrjMainPathDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUserCodePrjMainPathDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUserCodePrjMainPathBL()
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
if (string.IsNullOrEmpty(clsvUserCodePrjMainPathEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserCodePrjMainPathEN._ConnectString);
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
public static DataTable GetDataTable_vUserCodePrjMainPath(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUserCodePrjMainPathDA.GetDataTable_vUserCodePrjMainPath(strWhereCond);
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
objDT = vUserCodePrjMainPathDA.GetDataTable(strWhereCond);
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
objDT = vUserCodePrjMainPathDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vUserCodePrjMainPathDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUserCodePrjMainPathDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vUserCodePrjMainPathDA.GetDataTable_Top(objTopPara);
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
objDT = vUserCodePrjMainPathDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUserCodePrjMainPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUserCodePrjMainPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrUserCodePrjMainPathIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvUserCodePrjMainPathEN> GetObjLstByUserCodePrjMainPathIdLst(List<string> arrUserCodePrjMainPathIdLst)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrUserCodePrjMainPathIdLst, true);
 string strWhereCond = string.Format("UserCodePrjMainPathId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserCodePrjMainPathIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUserCodePrjMainPathEN> GetObjLstByUserCodePrjMainPathIdLstCache(List<string> arrUserCodePrjMainPathIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvUserCodePrjMainPathEN._CurrTabName, strPrjId);
List<clsvUserCodePrjMainPathEN> arrvUserCodePrjMainPathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePrjMainPathEN> arrvUserCodePrjMainPathObjLst_Sel =
arrvUserCodePrjMainPathObjLstCache
.Where(x => arrUserCodePrjMainPathIdLst.Contains(x.UserCodePrjMainPathId));
return arrvUserCodePrjMainPathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePrjMainPathEN> GetObjLst(string strWhereCond)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
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
public static List<clsvUserCodePrjMainPathEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUserCodePrjMainPathEN> GetSubObjLstCache(clsvUserCodePrjMainPathEN objvUserCodePrjMainPathCond)
{
 string strPrjId = objvUserCodePrjMainPathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvUserCodePrjMainPathBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvUserCodePrjMainPathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePrjMainPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserCodePrjMainPath._AttributeName)
{
if (objvUserCodePrjMainPathCond.IsUpdated(strFldName) == false) continue;
if (objvUserCodePrjMainPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserCodePrjMainPathCond[strFldName].ToString());
}
else
{
if (objvUserCodePrjMainPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserCodePrjMainPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserCodePrjMainPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserCodePrjMainPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserCodePrjMainPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserCodePrjMainPathCond[strFldName]));
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
public static List<clsvUserCodePrjMainPathEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
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
public static List<clsvUserCodePrjMainPathEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
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
List<clsvUserCodePrjMainPathEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUserCodePrjMainPathEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePrjMainPathEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUserCodePrjMainPathEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
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
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
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
public static List<clsvUserCodePrjMainPathEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUserCodePrjMainPathEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUserCodePrjMainPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
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
public static List<clsvUserCodePrjMainPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePrjMainPathEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePrjMainPathEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUserCodePrjMainPath(ref clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
{
bool bolResult = vUserCodePrjMainPathDA.GetvUserCodePrjMainPath(ref objvUserCodePrjMainPathEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserCodePrjMainPathEN GetObjByUserCodePrjMainPathId(string strUserCodePrjMainPathId)
{
if (strUserCodePrjMainPathId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strUserCodePrjMainPathId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strUserCodePrjMainPathId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = vUserCodePrjMainPathDA.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
return objvUserCodePrjMainPathEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUserCodePrjMainPathEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = vUserCodePrjMainPathDA.GetFirstObj(strWhereCond);
 return objvUserCodePrjMainPathEN;
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
public static clsvUserCodePrjMainPathEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = vUserCodePrjMainPathDA.GetObjByDataRow(objRow);
 return objvUserCodePrjMainPathEN;
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
public static clsvUserCodePrjMainPathEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = vUserCodePrjMainPathDA.GetObjByDataRow(objRow);
 return objvUserCodePrjMainPathEN;
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
 /// <param name = "strUserCodePrjMainPathId">所给的关键字</param>
 /// <param name = "lstvUserCodePrjMainPathObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserCodePrjMainPathEN GetObjByUserCodePrjMainPathIdFromList(string strUserCodePrjMainPathId, List<clsvUserCodePrjMainPathEN> lstvUserCodePrjMainPathObjLst)
{
foreach (clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN in lstvUserCodePrjMainPathObjLst)
{
if (objvUserCodePrjMainPathEN.UserCodePrjMainPathId == strUserCodePrjMainPathId)
{
return objvUserCodePrjMainPathEN;
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
 string strUserCodePrjMainPathId;
 try
 {
 strUserCodePrjMainPathId = new clsvUserCodePrjMainPathDA().GetFirstID(strWhereCond);
 return strUserCodePrjMainPathId;
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
 arrList = vUserCodePrjMainPathDA.GetID(strWhereCond);
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
bool bolIsExist = vUserCodePrjMainPathDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserCodePrjMainPathId)
{
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strUserCodePrjMainPathId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vUserCodePrjMainPathDA.IsExist(strUserCodePrjMainPathId);
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
 bolIsExist = clsvUserCodePrjMainPathDA.IsExistTable();
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
 bolIsExist = vUserCodePrjMainPathDA.IsExistTable(strTabName);
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
 /// <param name = "objvUserCodePrjMainPathENS">源对象</param>
 /// <param name = "objvUserCodePrjMainPathENT">目标对象</param>
 public static void CopyTo(clsvUserCodePrjMainPathEN objvUserCodePrjMainPathENS, clsvUserCodePrjMainPathEN objvUserCodePrjMainPathENT)
{
try
{
objvUserCodePrjMainPathENT.ApplicationTypeENName = objvUserCodePrjMainPathENS.ApplicationTypeENName; //应用类型英文名
objvUserCodePrjMainPathENT.UserCodePrjMainPathId = objvUserCodePrjMainPathENS.UserCodePrjMainPathId; //生成主目录Id
objvUserCodePrjMainPathENT.CMProjectAppRelaId = objvUserCodePrjMainPathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objvUserCodePrjMainPathENT.PrjId = objvUserCodePrjMainPathENS.PrjId; //工程Id
objvUserCodePrjMainPathENT.PrjName = objvUserCodePrjMainPathENS.PrjName; //工程名称
objvUserCodePrjMainPathENT.ProgLangTypeId = objvUserCodePrjMainPathENS.ProgLangTypeId; //编程语言类型Id
objvUserCodePrjMainPathENT.UserId = objvUserCodePrjMainPathENS.UserId; //用户Id
objvUserCodePrjMainPathENT.UserName = objvUserCodePrjMainPathENS.UserName; //用户名
objvUserCodePrjMainPathENT.DepartmentId = objvUserCodePrjMainPathENS.DepartmentId; //部门ID
objvUserCodePrjMainPathENT.DepartmentName = objvUserCodePrjMainPathENS.DepartmentName; //部门名称
objvUserCodePrjMainPathENT.UserStateId = objvUserCodePrjMainPathENS.UserStateId; //用户状态号
objvUserCodePrjMainPathENT.UserStateName = objvUserCodePrjMainPathENS.UserStateName; //用户状态名
objvUserCodePrjMainPathENT.IsUsePrjMainPath = objvUserCodePrjMainPathENS.IsUsePrjMainPath; //是否使用主路径
objvUserCodePrjMainPathENT.IncludeXmlPath = objvUserCodePrjMainPathENS.IncludeXmlPath; //包含表Xml路径
objvUserCodePrjMainPathENT.IsTemplate = objvUserCodePrjMainPathENS.IsTemplate; //是否模板
objvUserCodePrjMainPathENT.InUse = objvUserCodePrjMainPathENS.InUse; //是否在用
objvUserCodePrjMainPathENT.UpdDate = objvUserCodePrjMainPathENS.UpdDate; //修改日期
objvUserCodePrjMainPathENT.UpdUserId = objvUserCodePrjMainPathENS.UpdUserId; //修改用户Id
objvUserCodePrjMainPathENT.Memo = objvUserCodePrjMainPathENS.Memo; //说明
objvUserCodePrjMainPathENT.ApplicationTypeSimName = objvUserCodePrjMainPathENS.ApplicationTypeSimName; //应用程序类型简称
objvUserCodePrjMainPathENT.CmPrjName = objvUserCodePrjMainPathENS.CmPrjName; //CM工程名
objvUserCodePrjMainPathENT.ApplicationTypeName = objvUserCodePrjMainPathENS.ApplicationTypeName; //应用程序类型名称
objvUserCodePrjMainPathENT.ApplicationTypeId = objvUserCodePrjMainPathENS.ApplicationTypeId; //应用程序类型ID
objvUserCodePrjMainPathENT.CmPrjId = objvUserCodePrjMainPathENS.CmPrjId; //Cm工程Id
objvUserCodePrjMainPathENT.AppOrderNum = objvUserCodePrjMainPathENS.AppOrderNum; //AppOrderNum
objvUserCodePrjMainPathENT.AppIsVisible = objvUserCodePrjMainPathENS.AppIsVisible; //AppIsVisible
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
 /// <param name = "objvUserCodePrjMainPathEN">源简化对象</param>
 public static void SetUpdFlag(clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
{
try
{
objvUserCodePrjMainPathEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUserCodePrjMainPathEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUserCodePrjMainPath.ApplicationTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objvUserCodePrjMainPathEN.ApplicationTypeENName == "[null]" ? null :  objvUserCodePrjMainPathEN.ApplicationTypeENName; //应用类型英文名
}
if (arrFldSet.Contains(convUserCodePrjMainPath.UserCodePrjMainPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objvUserCodePrjMainPathEN.UserCodePrjMainPathId; //生成主目录Id
}
if (arrFldSet.Contains(convUserCodePrjMainPath.CMProjectAppRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.CMProjectAppRelaId = objvUserCodePrjMainPathEN.CMProjectAppRelaId; //Cm工程应用关系Id
}
if (arrFldSet.Contains(convUserCodePrjMainPath.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.PrjId = objvUserCodePrjMainPathEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convUserCodePrjMainPath.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.PrjName = objvUserCodePrjMainPathEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convUserCodePrjMainPath.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.ProgLangTypeId = objvUserCodePrjMainPathEN.ProgLangTypeId == "[null]" ? null :  objvUserCodePrjMainPathEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convUserCodePrjMainPath.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.UserId = objvUserCodePrjMainPathEN.UserId == "[null]" ? null :  objvUserCodePrjMainPathEN.UserId; //用户Id
}
if (arrFldSet.Contains(convUserCodePrjMainPath.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.UserName = objvUserCodePrjMainPathEN.UserName; //用户名
}
if (arrFldSet.Contains(convUserCodePrjMainPath.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.DepartmentId = objvUserCodePrjMainPathEN.DepartmentId == "[null]" ? null :  objvUserCodePrjMainPathEN.DepartmentId; //部门ID
}
if (arrFldSet.Contains(convUserCodePrjMainPath.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.DepartmentName = objvUserCodePrjMainPathEN.DepartmentName; //部门名称
}
if (arrFldSet.Contains(convUserCodePrjMainPath.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.UserStateId = objvUserCodePrjMainPathEN.UserStateId == "[null]" ? null :  objvUserCodePrjMainPathEN.UserStateId; //用户状态号
}
if (arrFldSet.Contains(convUserCodePrjMainPath.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.UserStateName = objvUserCodePrjMainPathEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convUserCodePrjMainPath.IsUsePrjMainPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.IsUsePrjMainPath = objvUserCodePrjMainPathEN.IsUsePrjMainPath; //是否使用主路径
}
if (arrFldSet.Contains(convUserCodePrjMainPath.IncludeXmlPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.IncludeXmlPath = objvUserCodePrjMainPathEN.IncludeXmlPath == "[null]" ? null :  objvUserCodePrjMainPathEN.IncludeXmlPath; //包含表Xml路径
}
if (arrFldSet.Contains(convUserCodePrjMainPath.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.IsTemplate = objvUserCodePrjMainPathEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(convUserCodePrjMainPath.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.InUse = objvUserCodePrjMainPathEN.InUse; //是否在用
}
if (arrFldSet.Contains(convUserCodePrjMainPath.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.UpdDate = objvUserCodePrjMainPathEN.UpdDate == "[null]" ? null :  objvUserCodePrjMainPathEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convUserCodePrjMainPath.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.UpdUserId = objvUserCodePrjMainPathEN.UpdUserId == "[null]" ? null :  objvUserCodePrjMainPathEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convUserCodePrjMainPath.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.Memo = objvUserCodePrjMainPathEN.Memo == "[null]" ? null :  objvUserCodePrjMainPathEN.Memo; //说明
}
if (arrFldSet.Contains(convUserCodePrjMainPath.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objvUserCodePrjMainPathEN.ApplicationTypeSimName == "[null]" ? null :  objvUserCodePrjMainPathEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convUserCodePrjMainPath.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.CmPrjName = objvUserCodePrjMainPathEN.CmPrjName == "[null]" ? null :  objvUserCodePrjMainPathEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convUserCodePrjMainPath.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.ApplicationTypeName = objvUserCodePrjMainPathEN.ApplicationTypeName == "[null]" ? null :  objvUserCodePrjMainPathEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convUserCodePrjMainPath.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.ApplicationTypeId = objvUserCodePrjMainPathEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convUserCodePrjMainPath.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.CmPrjId = objvUserCodePrjMainPathEN.CmPrjId == "[null]" ? null :  objvUserCodePrjMainPathEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convUserCodePrjMainPath.AppOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.AppOrderNum = objvUserCodePrjMainPathEN.AppOrderNum; //AppOrderNum
}
if (arrFldSet.Contains(convUserCodePrjMainPath.AppIsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePrjMainPathEN.AppIsVisible = objvUserCodePrjMainPathEN.AppIsVisible; //AppIsVisible
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
 /// <param name = "objvUserCodePrjMainPathEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
{
try
{
if (objvUserCodePrjMainPathEN.ApplicationTypeENName == "[null]") objvUserCodePrjMainPathEN.ApplicationTypeENName = null; //应用类型英文名
if (objvUserCodePrjMainPathEN.ProgLangTypeId == "[null]") objvUserCodePrjMainPathEN.ProgLangTypeId = null; //编程语言类型Id
if (objvUserCodePrjMainPathEN.UserId == "[null]") objvUserCodePrjMainPathEN.UserId = null; //用户Id
if (objvUserCodePrjMainPathEN.DepartmentId == "[null]") objvUserCodePrjMainPathEN.DepartmentId = null; //部门ID
if (objvUserCodePrjMainPathEN.UserStateId == "[null]") objvUserCodePrjMainPathEN.UserStateId = null; //用户状态号
if (objvUserCodePrjMainPathEN.IncludeXmlPath == "[null]") objvUserCodePrjMainPathEN.IncludeXmlPath = null; //包含表Xml路径
if (objvUserCodePrjMainPathEN.UpdDate == "[null]") objvUserCodePrjMainPathEN.UpdDate = null; //修改日期
if (objvUserCodePrjMainPathEN.UpdUserId == "[null]") objvUserCodePrjMainPathEN.UpdUserId = null; //修改用户Id
if (objvUserCodePrjMainPathEN.Memo == "[null]") objvUserCodePrjMainPathEN.Memo = null; //说明
if (objvUserCodePrjMainPathEN.ApplicationTypeSimName == "[null]") objvUserCodePrjMainPathEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvUserCodePrjMainPathEN.CmPrjName == "[null]") objvUserCodePrjMainPathEN.CmPrjName = null; //CM工程名
if (objvUserCodePrjMainPathEN.ApplicationTypeName == "[null]") objvUserCodePrjMainPathEN.ApplicationTypeName = null; //应用程序类型名称
if (objvUserCodePrjMainPathEN.CmPrjId == "[null]") objvUserCodePrjMainPathEN.CmPrjId = null; //Cm工程Id
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
public static void CheckProperty4Condition(clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
{
 vUserCodePrjMainPathDA.CheckProperty4Condition(objvUserCodePrjMainPathEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_UserCodePrjMainPathId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convUserCodePrjMainPath.UserCodePrjMainPathId); 
List<clsvUserCodePrjMainPathEN> arrObjLst = clsvUserCodePrjMainPathBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN()
{
UserCodePrjMainPathId = "0",
ApplicationTypeName = "选[v用户生成项目主路径]..."
};
arrObjLstSel.Insert(0, objvUserCodePrjMainPathEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convUserCodePrjMainPath.UserCodePrjMainPathId;
objComboBox.DisplayMember = convUserCodePrjMainPath.ApplicationTypeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_UserCodePrjMainPathId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v用户生成项目主路径]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convUserCodePrjMainPath.UserCodePrjMainPathId); 
IEnumerable<clsvUserCodePrjMainPathEN> arrObjLst = clsvUserCodePrjMainPathBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convUserCodePrjMainPath.UserCodePrjMainPathId;
objDDL.DataTextField = convUserCodePrjMainPath.ApplicationTypeName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserCodePrjMainPathIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v用户生成项目主路径]...","0");
List<clsvUserCodePrjMainPathEN> arrvUserCodePrjMainPathObjLst = GetAllvUserCodePrjMainPathObjLstCache(strPrjId); 
objDDL.DataValueField = convUserCodePrjMainPath.UserCodePrjMainPathId;
objDDL.DataTextField = convUserCodePrjMainPath.ApplicationTypeName;
objDDL.DataSource = arrvUserCodePrjMainPathObjLst;
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
if (clsUserCodePrjMainPathBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserCodePrjMainPathBL没有刷新缓存机制(clsUserCodePrjMainPathBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectAppRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectAppRelaBL没有刷新缓存机制(clsCMProjectAppRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDepartmentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDepartmentInfoBL没有刷新缓存机制(clsDepartmentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDepartmentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDepartmentTypeBL没有刷新缓存机制(clsDepartmentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserCodePrjMainPathId");
//if (arrvUserCodePrjMainPathObjLstCache == null)
//{
//arrvUserCodePrjMainPathObjLstCache = vUserCodePrjMainPathDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserCodePrjMainPathEN GetObjByUserCodePrjMainPathIdCache(string strUserCodePrjMainPathId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvUserCodePrjMainPathEN._CurrTabName, strPrjId);
List<clsvUserCodePrjMainPathEN> arrvUserCodePrjMainPathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePrjMainPathEN> arrvUserCodePrjMainPathObjLst_Sel =
arrvUserCodePrjMainPathObjLstCache
.Where(x=> x.UserCodePrjMainPathId == strUserCodePrjMainPathId 
);
if (arrvUserCodePrjMainPathObjLst_Sel.Count() == 0)
{
   clsvUserCodePrjMainPathEN obj = clsvUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strUserCodePrjMainPathId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvUserCodePrjMainPathObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetApplicationTypeNameByUserCodePrjMainPathIdCache(string strUserCodePrjMainPathId, string strPrjId)
{
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true) return "";
//获取缓存中的对象列表
clsvUserCodePrjMainPathEN objvUserCodePrjMainPath = GetObjByUserCodePrjMainPathIdCache(strUserCodePrjMainPathId, strPrjId);
if (objvUserCodePrjMainPath == null) return "";
return objvUserCodePrjMainPath.ApplicationTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByUserCodePrjMainPathIdCache(string strUserCodePrjMainPathId, string strPrjId)
{
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true) return "";
//获取缓存中的对象列表
clsvUserCodePrjMainPathEN objvUserCodePrjMainPath = GetObjByUserCodePrjMainPathIdCache(strUserCodePrjMainPathId, strPrjId);
if (objvUserCodePrjMainPath == null) return "";
return objvUserCodePrjMainPath.ApplicationTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserCodePrjMainPathEN> GetAllvUserCodePrjMainPathObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvUserCodePrjMainPathEN> arrvUserCodePrjMainPathObjLstCache = GetObjLstCache(strPrjId); 
return arrvUserCodePrjMainPathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserCodePrjMainPathEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvUserCodePrjMainPathEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvUserCodePrjMainPathEN> arrvUserCodePrjMainPathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvUserCodePrjMainPathObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvUserCodePrjMainPathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvUserCodePrjMainPathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvUserCodePrjMainPathEN._RefreshTimeLst.Count == 0) return "";
return clsvUserCodePrjMainPathEN._RefreshTimeLst[clsvUserCodePrjMainPathEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strUserCodePrjMainPathId, string strPrjId)
{
if (strInFldName != convUserCodePrjMainPath.UserCodePrjMainPathId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUserCodePrjMainPath._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUserCodePrjMainPath._AttributeName));
throw new Exception(strMsg);
}
var objvUserCodePrjMainPath = clsvUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathIdCache(strUserCodePrjMainPathId, strPrjId);
if (objvUserCodePrjMainPath == null) return "";
return objvUserCodePrjMainPath[strOutFldName].ToString();
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
int intRecCount = clsvUserCodePrjMainPathDA.GetRecCount(strTabName);
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
int intRecCount = clsvUserCodePrjMainPathDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUserCodePrjMainPathDA.GetRecCount();
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
int intRecCount = clsvUserCodePrjMainPathDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUserCodePrjMainPathEN objvUserCodePrjMainPathCond)
{
 string strPrjId = objvUserCodePrjMainPathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvUserCodePrjMainPathBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvUserCodePrjMainPathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePrjMainPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserCodePrjMainPath._AttributeName)
{
if (objvUserCodePrjMainPathCond.IsUpdated(strFldName) == false) continue;
if (objvUserCodePrjMainPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserCodePrjMainPathCond[strFldName].ToString());
}
else
{
if (objvUserCodePrjMainPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserCodePrjMainPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserCodePrjMainPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserCodePrjMainPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserCodePrjMainPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserCodePrjMainPathCond[strFldName]));
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
 List<string> arrList = clsvUserCodePrjMainPathDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUserCodePrjMainPathDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUserCodePrjMainPathDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}