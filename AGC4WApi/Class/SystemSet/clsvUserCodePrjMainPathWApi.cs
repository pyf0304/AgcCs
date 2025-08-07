
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserCodePrjMainPathWApi
 表名:vUserCodePrjMainPath(00050339)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvUserCodePrjMainPathWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetApplicationTypeENName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convUserCodePrjMainPath.ApplicationTypeENName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserCodePrjMainPathId">生成主目录Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserCodePrjMainPathId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserCodePrjMainPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserCodePrjMainPathId, 8, convUserCodePrjMainPath.UserCodePrjMainPathId);
clsCheckSql.CheckFieldForeignKey(strUserCodePrjMainPathId, 8, convUserCodePrjMainPath.UserCodePrjMainPathId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "lngCMProjectAppRelaId">Cm工程应用关系Id</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetPrjId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convUserCodePrjMainPath.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserCodePrjMainPath.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserCodePrjMainPath.PrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetPrjName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convUserCodePrjMainPath.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convUserCodePrjMainPath.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetProgLangTypeId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convUserCodePrjMainPath.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convUserCodePrjMainPath.ProgLangTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convUserCodePrjMainPath.UserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUserCodePrjMainPath.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convUserCodePrjMainPath.UserName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetDepartmentId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, convUserCodePrjMainPath.DepartmentId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetDepartmentName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convUserCodePrjMainPath.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 30, convUserCodePrjMainPath.DepartmentName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserStateId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convUserCodePrjMainPath.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convUserCodePrjMainPath.UserStateId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUserStateName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convUserCodePrjMainPath.UserStateName);
clsCheckSql.CheckFieldLen(strUserStateName, 20, convUserCodePrjMainPath.UserStateName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUsePrjMainPath">是否使用主路径</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strIncludeXmlPath">包含表Xml路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetIncludeXmlPath(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strIncludeXmlPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIncludeXmlPath, 150, convUserCodePrjMainPath.IncludeXmlPath);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUpdDate(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserCodePrjMainPath.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetUpdUserId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convUserCodePrjMainPath.UpdUserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetMemo(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserCodePrjMainPath.Memo);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetApplicationTypeSimName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convUserCodePrjMainPath.ApplicationTypeSimName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetCmPrjName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convUserCodePrjMainPath.CmPrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetApplicationTypeName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convUserCodePrjMainPath.ApplicationTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetCmPrjId(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convUserCodePrjMainPath.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convUserCodePrjMainPath.CmPrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "intAppOrderNum">AppOrderNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePrjMainPathEN SetAppOrderNum(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN, int intAppOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAppIsVisible">AppIsVisible</param>
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v用户生成项目主路径(vUserCodePrjMainPath)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUserCodePrjMainPathWApi
{
private static readonly string mstrApiControllerName = "vUserCodePrjMainPathApi";

 public clsvUserCodePrjMainPathWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserCodePrjMainPathId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v用户生成项目主路径]...","0");
List<clsvUserCodePrjMainPathEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="UserCodePrjMainPathId";
objDDL.DataTextField="ApplicationTypeName";
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

 /// <param name = "strPrjId"></param>
public static void BindCbo_UserCodePrjMainPathId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convUserCodePrjMainPath.UserCodePrjMainPathId); 
List<clsvUserCodePrjMainPathEN> arrObjLst = clsvUserCodePrjMainPathWApi.GetObjLst(strCondition);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserCodePrjMainPathEN GetObjByUserCodePrjMainPathId(string strUserCodePrjMainPathId)
{
if (strUserCodePrjMainPathId == "") return null;
string strAction = "GetObjByUserCodePrjMainPathId";
clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserCodePrjMainPathId"] = strUserCodePrjMainPathId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvUserCodePrjMainPathEN = JsonConvert.DeserializeObject<clsvUserCodePrjMainPathEN>(strJson);
return objvUserCodePrjMainPathEN;
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
public static clsvUserCodePrjMainPathEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN;
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
objvUserCodePrjMainPathEN = JsonConvert.DeserializeObject<clsvUserCodePrjMainPathEN>(strJson);
return objvUserCodePrjMainPathEN;
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
//该表没有使用Cache,不需要生成[GetApplicationTypeNameByUserCodePrjMainPathIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePrjMainPathEN> GetObjLst(string strWhereCond)
{
 List<clsvUserCodePrjMainPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePrjMainPathEN>>(strJson);
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
 /// <param name = "arrUserCodePrjMainPathId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePrjMainPathEN> GetObjLstByUserCodePrjMainPathIdLst(List<string> arrUserCodePrjMainPathId)
{
 List<clsvUserCodePrjMainPathEN> arrObjLst; 
string strAction = "GetObjLstByUserCodePrjMainPathIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserCodePrjMainPathId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePrjMainPathEN>>(strJson);
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
public static List<clsvUserCodePrjMainPathEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUserCodePrjMainPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePrjMainPathEN>>(strJson);
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
public static List<clsvUserCodePrjMainPathEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUserCodePrjMainPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePrjMainPathEN>>(strJson);
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
public static List<clsvUserCodePrjMainPathEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUserCodePrjMainPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePrjMainPathEN>>(strJson);
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
public static List<clsvUserCodePrjMainPathEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvUserCodePrjMainPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePrjMainPathEN>>(strJson);
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
public static bool IsExist(string strUserCodePrjMainPathId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserCodePrjMainPathId"] = strUserCodePrjMainPathId
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
public static DataTable ToDataTable(List<clsvUserCodePrjMainPathEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUserCodePrjMainPathEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUserCodePrjMainPathEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUserCodePrjMainPathEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUserCodePrjMainPathEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUserCodePrjMainPathEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvUserCodePrjMainPathWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvUserCodePrjMainPathWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvUserCodePrjMainPathEN._CurrTabName, strPrjId);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvUserCodePrjMainPathEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUserCodePrjMainPath.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.UserCodePrjMainPathId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.CMProjectAppRelaId, Type.GetType("System.Int64"));
objDT.Columns.Add(convUserCodePrjMainPath.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.IsUsePrjMainPath, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserCodePrjMainPath.IncludeXmlPath, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserCodePrjMainPath.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserCodePrjMainPath.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convUserCodePrjMainPath.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePrjMainPath.AppOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convUserCodePrjMainPath.AppIsVisible, Type.GetType("System.Boolean"));
foreach (clsvUserCodePrjMainPathEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUserCodePrjMainPath.ApplicationTypeENName] = objInFor[convUserCodePrjMainPath.ApplicationTypeENName];
objDR[convUserCodePrjMainPath.UserCodePrjMainPathId] = objInFor[convUserCodePrjMainPath.UserCodePrjMainPathId];
objDR[convUserCodePrjMainPath.CMProjectAppRelaId] = objInFor[convUserCodePrjMainPath.CMProjectAppRelaId];
objDR[convUserCodePrjMainPath.PrjId] = objInFor[convUserCodePrjMainPath.PrjId];
objDR[convUserCodePrjMainPath.PrjName] = objInFor[convUserCodePrjMainPath.PrjName];
objDR[convUserCodePrjMainPath.ProgLangTypeId] = objInFor[convUserCodePrjMainPath.ProgLangTypeId];
objDR[convUserCodePrjMainPath.UserId] = objInFor[convUserCodePrjMainPath.UserId];
objDR[convUserCodePrjMainPath.UserName] = objInFor[convUserCodePrjMainPath.UserName];
objDR[convUserCodePrjMainPath.DepartmentId] = objInFor[convUserCodePrjMainPath.DepartmentId];
objDR[convUserCodePrjMainPath.DepartmentName] = objInFor[convUserCodePrjMainPath.DepartmentName];
objDR[convUserCodePrjMainPath.UserStateId] = objInFor[convUserCodePrjMainPath.UserStateId];
objDR[convUserCodePrjMainPath.UserStateName] = objInFor[convUserCodePrjMainPath.UserStateName];
objDR[convUserCodePrjMainPath.IsUsePrjMainPath] = objInFor[convUserCodePrjMainPath.IsUsePrjMainPath];
objDR[convUserCodePrjMainPath.IncludeXmlPath] = objInFor[convUserCodePrjMainPath.IncludeXmlPath];
objDR[convUserCodePrjMainPath.IsTemplate] = objInFor[convUserCodePrjMainPath.IsTemplate];
objDR[convUserCodePrjMainPath.InUse] = objInFor[convUserCodePrjMainPath.InUse];
objDR[convUserCodePrjMainPath.UpdDate] = objInFor[convUserCodePrjMainPath.UpdDate];
objDR[convUserCodePrjMainPath.UpdUserId] = objInFor[convUserCodePrjMainPath.UpdUserId];
objDR[convUserCodePrjMainPath.Memo] = objInFor[convUserCodePrjMainPath.Memo];
objDR[convUserCodePrjMainPath.ApplicationTypeSimName] = objInFor[convUserCodePrjMainPath.ApplicationTypeSimName];
objDR[convUserCodePrjMainPath.CmPrjName] = objInFor[convUserCodePrjMainPath.CmPrjName];
objDR[convUserCodePrjMainPath.ApplicationTypeName] = objInFor[convUserCodePrjMainPath.ApplicationTypeName];
objDR[convUserCodePrjMainPath.ApplicationTypeId] = objInFor[convUserCodePrjMainPath.ApplicationTypeId];
objDR[convUserCodePrjMainPath.CmPrjId] = objInFor[convUserCodePrjMainPath.CmPrjId];
objDR[convUserCodePrjMainPath.AppOrderNum] = objInFor[convUserCodePrjMainPath.AppOrderNum];
objDR[convUserCodePrjMainPath.AppIsVisible] = objInFor[convUserCodePrjMainPath.AppIsVisible];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}