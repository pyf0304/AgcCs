
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersWApi
 表名:vUsers(00050261)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
public static class  clsvUsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUserId(this clsvUsersEN objvUsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convUsers.UserId);
objvUsersEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UserId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UserId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UserId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUserName(this clsvUsersEN objvUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUsers.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convUsers.UserName);
objvUsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UserName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UserName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UserName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetDepartmentId(this clsvUsersEN objvUsersEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convUsers.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 6, convUsers.DepartmentId);
objvUsersEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.DepartmentId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.DepartmentId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.DepartmentId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetDepartmentName(this clsvUsersEN objvUsersEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentName, 30, convUsers.DepartmentName);
objvUsersEN.DepartmentName = strDepartmentName; //部门名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.DepartmentName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.DepartmentName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.DepartmentName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentAbbrName">部门简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetDepartmentAbbrName(this clsvUsersEN objvUsersEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convUsers.DepartmentAbbrName);
objvUsersEN.DepartmentAbbrName = strDepartmentAbbrName; //部门简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.DepartmentAbbrName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.DepartmentAbbrName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.DepartmentAbbrName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeId">部门类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetDepartmentTypeId(this clsvUsersEN objvUsersEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convUsers.DepartmentTypeId);
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convUsers.DepartmentTypeId);
objvUsersEN.DepartmentTypeId = strDepartmentTypeId; //部门类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.DepartmentTypeId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.DepartmentTypeId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.DepartmentTypeId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentId">上级部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUpDepartmentId(this clsvUsersEN objvUsersEN, string strUpDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convUsers.UpDepartmentId);
objvUsersEN.UpDepartmentId = strUpDepartmentId; //上级部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UpDepartmentId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UpDepartmentId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UpDepartmentId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeName">部门类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetDepartmentTypeName(this clsvUsersEN objvUsersEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convUsers.DepartmentTypeName);
objvUsersEN.DepartmentTypeName = strDepartmentTypeName; //部门类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.DepartmentTypeName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.DepartmentTypeName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.DepartmentTypeName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentName">上级部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUpDepartmentName(this clsvUsersEN objvUsersEN, string strUpDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 30, convUsers.UpDepartmentName);
objvUsersEN.UpDepartmentName = strUpDepartmentName; //上级部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UpDepartmentName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UpDepartmentName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UpDepartmentName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUserStateId(this clsvUsersEN objvUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convUsers.UserStateId);
objvUsersEN.UserStateId = strUserStateId; //用户状态号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UserStateId) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UserStateId, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UserStateId] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUserStateName(this clsvUsersEN objvUsersEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convUsers.UserStateName);
objvUsersEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UserStateName) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UserStateName, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UserStateName] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffectiveDate">有效日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetEffectiveDate(this clsvUsersEN objvUsersEN, string strEffectiveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffectiveDate, 8, convUsers.EffectiveDate);
objvUsersEN.EffectiveDate = strEffectiveDate; //有效日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.EffectiveDate) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.EffectiveDate, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.EffectiveDate] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveBeginDate">有效开始日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetEffitiveBeginDate(this clsvUsersEN objvUsersEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveBeginDate, convUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, convUsers.EffitiveBeginDate);
objvUsersEN.EffitiveBeginDate = strEffitiveBeginDate; //有效开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.EffitiveBeginDate) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.EffitiveBeginDate, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.EffitiveBeginDate] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveEndDate">有效结束日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetEffitiveEndDate(this clsvUsersEN objvUsersEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveEndDate, convUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, convUsers.EffitiveEndDate);
objvUsersEN.EffitiveEndDate = strEffitiveEndDate; //有效结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.EffitiveEndDate) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.EffitiveEndDate, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.EffitiveEndDate] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strPassword">口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetPassword(this clsvUsersEN objvUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, convUsers.Password);
clsCheckSql.CheckFieldLen(strPassword, 20, convUsers.Password);
objvUsersEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.Password) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.Password, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.Password] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityID">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIdentityID(this clsvUsersEN objvUsersEN, string strIdentityID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityID, 2, convUsers.IdentityID);
clsCheckSql.CheckFieldForeignKey(strIdentityID, 2, convUsers.IdentityID);
objvUsersEN.IdentityID = strIdentityID; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IdentityID) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IdentityID, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IdentityID] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIdentityDesc(this clsvUsersEN objvUsersEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convUsers.IdentityDesc);
objvUsersEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IdentityDesc) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IdentityDesc, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IdentityDesc] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEmail">电子邮箱</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetEmail(this clsvUsersEN objvUsersEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 50, convUsers.Email);
objvUsersEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.Email) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.Email, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.Email] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGpUser">是否平台用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIsGpUser(this clsvUsersEN objvUsersEN, bool bolIsGpUser, string strComparisonOp="")
	{
objvUsersEN.IsGpUser = bolIsGpUser; //是否平台用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IsGpUser) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IsGpUser, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IsGpUser] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegisterPassword">注册密码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetRegisterPassword(this clsvUsersEN objvUsersEN, string strRegisterPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, convUsers.RegisterPassword);
objvUsersEN.RegisterPassword = strRegisterPassword; //注册密码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.RegisterPassword) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.RegisterPassword, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.RegisterPassword] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRegister">是否注册</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIsRegister(this clsvUsersEN objvUsersEN, bool bolIsRegister, string strComparisonOp="")
	{
objvUsersEN.IsRegister = bolIsRegister; //是否注册
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IsRegister) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IsRegister, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IsRegister] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegisterDate">注册日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetRegisterDate(this clsvUsersEN objvUsersEN, string strRegisterDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterDate, 14, convUsers.RegisterDate);
objvUsersEN.RegisterDate = strRegisterDate; //注册日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.RegisterDate) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.RegisterDate, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.RegisterDate] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAudit">是否审核</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetIsAudit(this clsvUsersEN objvUsersEN, bool bolIsAudit, string strComparisonOp="")
	{
objvUsersEN.IsAudit = bolIsAudit; //是否审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.IsAudit) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.IsAudit, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.IsAudit] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strAuditUser">审核人</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetAuditUser(this clsvUsersEN objvUsersEN, string strAuditUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditUser, 18, convUsers.AuditUser);
objvUsersEN.AuditUser = strAuditUser; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.AuditUser) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.AuditUser, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.AuditUser] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strAuditDate">审核日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetAuditDate(this clsvUsersEN objvUsersEN, string strAuditDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditDate, 14, convUsers.AuditDate);
objvUsersEN.AuditDate = strAuditDate; //审核日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.AuditDate) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.AuditDate, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.AuditDate] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUpdDate(this clsvUsersEN objvUsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUsers.UpdDate);
objvUsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UpdDate) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UpdDate, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UpdDate] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetUpdUser(this clsvUsersEN objvUsersEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convUsers.UpdUser);
objvUsersEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.UpdUser) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.UpdUser, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.UpdUser] = strComparisonOp;
}
}
return objvUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUsersEN SetMemo(this clsvUsersEN objvUsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUsers.Memo);
objvUsersEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUsersEN.dicFldComparisonOp.ContainsKey(convUsers.Memo) == false)
{
objvUsersEN.dicFldComparisonOp.Add(convUsers.Memo, strComparisonOp);
}
else
{
objvUsersEN.dicFldComparisonOp[convUsers.Memo] = strComparisonOp;
}
}
return objvUsersEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUsersEN objvUsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUsersCond.IsUpdated(convUsers.UserId) == true)
{
string strComparisonOpUserId = objvUsersCond.dicFldComparisonOp[convUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserId, objvUsersCond.UserId, strComparisonOpUserId);
}
if (objvUsersCond.IsUpdated(convUsers.UserName) == true)
{
string strComparisonOpUserName = objvUsersCond.dicFldComparisonOp[convUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserName, objvUsersCond.UserName, strComparisonOpUserName);
}
if (objvUsersCond.IsUpdated(convUsers.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvUsersCond.dicFldComparisonOp[convUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.DepartmentId, objvUsersCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvUsersCond.IsUpdated(convUsers.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvUsersCond.dicFldComparisonOp[convUsers.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.DepartmentName, objvUsersCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvUsersCond.IsUpdated(convUsers.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvUsersCond.dicFldComparisonOp[convUsers.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.DepartmentAbbrName, objvUsersCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvUsersCond.IsUpdated(convUsers.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objvUsersCond.dicFldComparisonOp[convUsers.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.DepartmentTypeId, objvUsersCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objvUsersCond.IsUpdated(convUsers.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objvUsersCond.dicFldComparisonOp[convUsers.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UpDepartmentId, objvUsersCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objvUsersCond.IsUpdated(convUsers.DepartmentTypeName) == true)
{
string strComparisonOpDepartmentTypeName = objvUsersCond.dicFldComparisonOp[convUsers.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.DepartmentTypeName, objvUsersCond.DepartmentTypeName, strComparisonOpDepartmentTypeName);
}
if (objvUsersCond.IsUpdated(convUsers.UpDepartmentName) == true)
{
string strComparisonOpUpDepartmentName = objvUsersCond.dicFldComparisonOp[convUsers.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UpDepartmentName, objvUsersCond.UpDepartmentName, strComparisonOpUpDepartmentName);
}
if (objvUsersCond.IsUpdated(convUsers.UserStateId) == true)
{
string strComparisonOpUserStateId = objvUsersCond.dicFldComparisonOp[convUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserStateId, objvUsersCond.UserStateId, strComparisonOpUserStateId);
}
if (objvUsersCond.IsUpdated(convUsers.UserStateName) == true)
{
string strComparisonOpUserStateName = objvUsersCond.dicFldComparisonOp[convUsers.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UserStateName, objvUsersCond.UserStateName, strComparisonOpUserStateName);
}
if (objvUsersCond.IsUpdated(convUsers.EffectiveDate) == true)
{
string strComparisonOpEffectiveDate = objvUsersCond.dicFldComparisonOp[convUsers.EffectiveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.EffectiveDate, objvUsersCond.EffectiveDate, strComparisonOpEffectiveDate);
}
if (objvUsersCond.IsUpdated(convUsers.EffitiveBeginDate) == true)
{
string strComparisonOpEffitiveBeginDate = objvUsersCond.dicFldComparisonOp[convUsers.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.EffitiveBeginDate, objvUsersCond.EffitiveBeginDate, strComparisonOpEffitiveBeginDate);
}
if (objvUsersCond.IsUpdated(convUsers.EffitiveEndDate) == true)
{
string strComparisonOpEffitiveEndDate = objvUsersCond.dicFldComparisonOp[convUsers.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.EffitiveEndDate, objvUsersCond.EffitiveEndDate, strComparisonOpEffitiveEndDate);
}
if (objvUsersCond.IsUpdated(convUsers.Password) == true)
{
string strComparisonOpPassword = objvUsersCond.dicFldComparisonOp[convUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Password, objvUsersCond.Password, strComparisonOpPassword);
}
if (objvUsersCond.IsUpdated(convUsers.IdentityID) == true)
{
string strComparisonOpIdentityID = objvUsersCond.dicFldComparisonOp[convUsers.IdentityID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.IdentityID, objvUsersCond.IdentityID, strComparisonOpIdentityID);
}
if (objvUsersCond.IsUpdated(convUsers.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvUsersCond.dicFldComparisonOp[convUsers.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.IdentityDesc, objvUsersCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvUsersCond.IsUpdated(convUsers.Email) == true)
{
string strComparisonOpEmail = objvUsersCond.dicFldComparisonOp[convUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Email, objvUsersCond.Email, strComparisonOpEmail);
}
if (objvUsersCond.IsUpdated(convUsers.IsGpUser) == true)
{
if (objvUsersCond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsGpUser);
}
}
if (objvUsersCond.IsUpdated(convUsers.RegisterPassword) == true)
{
string strComparisonOpRegisterPassword = objvUsersCond.dicFldComparisonOp[convUsers.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.RegisterPassword, objvUsersCond.RegisterPassword, strComparisonOpRegisterPassword);
}
if (objvUsersCond.IsUpdated(convUsers.IsRegister) == true)
{
if (objvUsersCond.IsRegister == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsRegister);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsRegister);
}
}
if (objvUsersCond.IsUpdated(convUsers.RegisterDate) == true)
{
string strComparisonOpRegisterDate = objvUsersCond.dicFldComparisonOp[convUsers.RegisterDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.RegisterDate, objvUsersCond.RegisterDate, strComparisonOpRegisterDate);
}
if (objvUsersCond.IsUpdated(convUsers.IsAudit) == true)
{
if (objvUsersCond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUsers.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUsers.IsAudit);
}
}
if (objvUsersCond.IsUpdated(convUsers.AuditUser) == true)
{
string strComparisonOpAuditUser = objvUsersCond.dicFldComparisonOp[convUsers.AuditUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.AuditUser, objvUsersCond.AuditUser, strComparisonOpAuditUser);
}
if (objvUsersCond.IsUpdated(convUsers.AuditDate) == true)
{
string strComparisonOpAuditDate = objvUsersCond.dicFldComparisonOp[convUsers.AuditDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.AuditDate, objvUsersCond.AuditDate, strComparisonOpAuditDate);
}
if (objvUsersCond.IsUpdated(convUsers.UpdDate) == true)
{
string strComparisonOpUpdDate = objvUsersCond.dicFldComparisonOp[convUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UpdDate, objvUsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objvUsersCond.IsUpdated(convUsers.UpdUser) == true)
{
string strComparisonOpUpdUser = objvUsersCond.dicFldComparisonOp[convUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.UpdUser, objvUsersCond.UpdUser, strComparisonOpUpdUser);
}
if (objvUsersCond.IsUpdated(convUsers.Memo) == true)
{
string strComparisonOpMemo = objvUsersCond.dicFldComparisonOp[convUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUsers.Memo, objvUsersCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用于用户管理(vUsers)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUsersWApi
{
private static readonly string mstrApiControllerName = "vUsersApi";

 public clsvUsersWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUsersEN GetObjByUserId(string strUserId)
{
if (strUserId == "") return null;
string strAction = "GetObjByUserId";
clsvUsersEN objvUsersEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvUsersEN = JsonConvert.DeserializeObject<clsvUsersEN>(strJson);
return objvUsersEN;
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
public static clsvUsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvUsersEN objvUsersEN;
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
objvUsersEN = JsonConvert.DeserializeObject<clsvUsersEN>(strJson);
return objvUsersEN;
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

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersEN> GetObjLst(string strWhereCond)
{
 List<clsvUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>(strJson);
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
 /// <param name = "arrUserId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUsersEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsvUsersEN> arrObjLst; 
string strAction = "GetObjLstByUserIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>(strJson);
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
public static List<clsvUsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>(strJson);
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
public static List<clsvUsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>(strJson);
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
public static List<clsvUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>(strJson);
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
public static List<clsvUsersEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUsersEN>>(strJson);
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
public static bool IsExist(string strUserId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId
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
 /// <param name = "objvUsersENS">源对象</param>
 /// <param name = "objvUsersENT">目标对象</param>
 public static void CopyTo(clsvUsersEN objvUsersENS, clsvUsersEN objvUsersENT)
{
try
{
objvUsersENT.UserId = objvUsersENS.UserId; //用户Id
objvUsersENT.UserName = objvUsersENS.UserName; //用户名
objvUsersENT.DepartmentId = objvUsersENS.DepartmentId; //部门ID
objvUsersENT.DepartmentName = objvUsersENS.DepartmentName; //部门名称
objvUsersENT.DepartmentAbbrName = objvUsersENS.DepartmentAbbrName; //部门简称
objvUsersENT.DepartmentTypeId = objvUsersENS.DepartmentTypeId; //部门类型Id
objvUsersENT.UpDepartmentId = objvUsersENS.UpDepartmentId; //上级部门Id
objvUsersENT.DepartmentTypeName = objvUsersENS.DepartmentTypeName; //部门类型
objvUsersENT.UpDepartmentName = objvUsersENS.UpDepartmentName; //上级部门名
objvUsersENT.UserStateId = objvUsersENS.UserStateId; //用户状态号
objvUsersENT.UserStateName = objvUsersENS.UserStateName; //用户状态名
objvUsersENT.EffectiveDate = objvUsersENS.EffectiveDate; //有效日期
objvUsersENT.EffitiveBeginDate = objvUsersENS.EffitiveBeginDate; //有效开始日期
objvUsersENT.EffitiveEndDate = objvUsersENS.EffitiveEndDate; //有效结束日期
objvUsersENT.Password = objvUsersENS.Password; //口令
objvUsersENT.IdentityID = objvUsersENS.IdentityID; //身份编号
objvUsersENT.IdentityDesc = objvUsersENS.IdentityDesc; //身份描述
objvUsersENT.Email = objvUsersENS.Email; //电子邮箱
objvUsersENT.IsGpUser = objvUsersENS.IsGpUser; //是否平台用户
objvUsersENT.RegisterPassword = objvUsersENS.RegisterPassword; //注册密码
objvUsersENT.IsRegister = objvUsersENS.IsRegister; //是否注册
objvUsersENT.RegisterDate = objvUsersENS.RegisterDate; //注册日期
objvUsersENT.IsAudit = objvUsersENS.IsAudit; //是否审核
objvUsersENT.AuditUser = objvUsersENS.AuditUser; //审核人
objvUsersENT.AuditDate = objvUsersENS.AuditDate; //审核日期
objvUsersENT.UpdDate = objvUsersENS.UpdDate; //修改日期
objvUsersENT.UpdUser = objvUsersENS.UpdUser; //修改者
objvUsersENT.Memo = objvUsersENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvUsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUsersEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUsersEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUsersEN._AttributeName)
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
string strKey = string.Format("{0}", clsvUsersEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvUsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUsers.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.DepartmentAbbrName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.DepartmentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UpDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.DepartmentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UpDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.EffectiveDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.Password, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IdentityID, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.Email, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsers.RegisterPassword, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IsRegister, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsers.RegisterDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.IsAudit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUsers.AuditUser, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.AuditDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convUsers.Memo, Type.GetType("System.String"));
foreach (clsvUsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUsers.UserId] = objInFor[convUsers.UserId];
objDR[convUsers.UserName] = objInFor[convUsers.UserName];
objDR[convUsers.DepartmentId] = objInFor[convUsers.DepartmentId];
objDR[convUsers.DepartmentName] = objInFor[convUsers.DepartmentName];
objDR[convUsers.DepartmentAbbrName] = objInFor[convUsers.DepartmentAbbrName];
objDR[convUsers.DepartmentTypeId] = objInFor[convUsers.DepartmentTypeId];
objDR[convUsers.UpDepartmentId] = objInFor[convUsers.UpDepartmentId];
objDR[convUsers.DepartmentTypeName] = objInFor[convUsers.DepartmentTypeName];
objDR[convUsers.UpDepartmentName] = objInFor[convUsers.UpDepartmentName];
objDR[convUsers.UserStateId] = objInFor[convUsers.UserStateId];
objDR[convUsers.UserStateName] = objInFor[convUsers.UserStateName];
objDR[convUsers.EffectiveDate] = objInFor[convUsers.EffectiveDate];
objDR[convUsers.EffitiveBeginDate] = objInFor[convUsers.EffitiveBeginDate];
objDR[convUsers.EffitiveEndDate] = objInFor[convUsers.EffitiveEndDate];
objDR[convUsers.Password] = objInFor[convUsers.Password];
objDR[convUsers.IdentityID] = objInFor[convUsers.IdentityID];
objDR[convUsers.IdentityDesc] = objInFor[convUsers.IdentityDesc];
objDR[convUsers.Email] = objInFor[convUsers.Email];
objDR[convUsers.IsGpUser] = objInFor[convUsers.IsGpUser];
objDR[convUsers.RegisterPassword] = objInFor[convUsers.RegisterPassword];
objDR[convUsers.IsRegister] = objInFor[convUsers.IsRegister];
objDR[convUsers.RegisterDate] = objInFor[convUsers.RegisterDate];
objDR[convUsers.IsAudit] = objInFor[convUsers.IsAudit];
objDR[convUsers.AuditUser] = objInFor[convUsers.AuditUser];
objDR[convUsers.AuditDate] = objInFor[convUsers.AuditDate];
objDR[convUsers.UpdDate] = objInFor[convUsers.UpdDate];
objDR[convUsers.UpdUser] = objInFor[convUsers.UpdUser];
objDR[convUsers.Memo] = objInFor[convUsers.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}