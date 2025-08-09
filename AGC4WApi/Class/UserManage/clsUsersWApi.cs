
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUsersWApi
 表名:Users(00050001)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:39:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsUsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUserId(this clsUsersEN objUsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, conUsers.UserId);
objUsersEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UserId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UserId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UserId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUserName(this clsUsersEN objUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, conUsers.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, conUsers.UserName);
objUsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UserName) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UserName, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UserName] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetDepartmentId(this clsUsersEN objUsersEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, conUsers.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 6, conUsers.DepartmentId);
objUsersEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.DepartmentId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.DepartmentId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.DepartmentId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUserStateId(this clsUsersEN objUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateId, 2, conUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, conUsers.UserStateId);
objUsersEN.UserStateId = strUserStateId; //用户状态号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UserStateId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UserStateId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UserStateId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetRoleId(this clsUsersEN objUsersEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, conUsers.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conUsers.RoleId);
objUsersEN.RoleId = strRoleId; //角色ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.RoleId) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.RoleId, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.RoleId] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "intqxdj">权限等级</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN Setqxdj(this clsUsersEN objUsersEN, int intqxdj, string strComparisonOp="")
	{
objUsersEN.qxdj = intqxdj; //权限等级
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.qxdj) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.qxdj, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.qxdj] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffectiveDate">有效日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetEffectiveDate(this clsUsersEN objUsersEN, string strEffectiveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffectiveDate, 8, conUsers.EffectiveDate);
objUsersEN.EffectiveDate = strEffectiveDate; //有效日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.EffectiveDate) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.EffectiveDate, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.EffectiveDate] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveBeginDate">有效开始日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetEffitiveBeginDate(this clsUsersEN objUsersEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, conUsers.EffitiveBeginDate);
objUsersEN.EffitiveBeginDate = strEffitiveBeginDate; //有效开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.EffitiveBeginDate) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.EffitiveBeginDate, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.EffitiveBeginDate] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveEndDate">有效结束日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetEffitiveEndDate(this clsUsersEN objUsersEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, conUsers.EffitiveEndDate);
objUsersEN.EffitiveEndDate = strEffitiveEndDate; //有效结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.EffitiveEndDate) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.EffitiveEndDate, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.EffitiveEndDate] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strPassword">口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetPassword(this clsUsersEN objUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, conUsers.Password);
clsCheckSql.CheckFieldLen(strPassword, 20, conUsers.Password);
objUsersEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.Password) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.Password, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.Password] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityID">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIdentityID(this clsUsersEN objUsersEN, string strIdentityID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityID, 2, conUsers.IdentityID);
clsCheckSql.CheckFieldForeignKey(strIdentityID, 2, conUsers.IdentityID);
objUsersEN.IdentityID = strIdentityID; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IdentityID) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IdentityID, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IdentityID] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEmail">电子邮箱</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetEmail(this clsUsersEN objUsersEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 50, conUsers.Email);
objUsersEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.Email) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.Email, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.Email] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGpUser">是否平台用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIsGpUser(this clsUsersEN objUsersEN, bool bolIsGpUser, string strComparisonOp="")
	{
objUsersEN.IsGpUser = bolIsGpUser; //是否平台用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IsGpUser) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IsGpUser, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IsGpUser] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegisterPassword">注册密码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetRegisterPassword(this clsUsersEN objUsersEN, string strRegisterPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, conUsers.RegisterPassword);
objUsersEN.RegisterPassword = strRegisterPassword; //注册密码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.RegisterPassword) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.RegisterPassword, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.RegisterPassword] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRegister">是否注册</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIsRegister(this clsUsersEN objUsersEN, bool bolIsRegister, string strComparisonOp="")
	{
objUsersEN.IsRegister = bolIsRegister; //是否注册
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IsRegister) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IsRegister, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IsRegister] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegisterDate">注册日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetRegisterDate(this clsUsersEN objUsersEN, string strRegisterDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterDate, 14, conUsers.RegisterDate);
objUsersEN.RegisterDate = strRegisterDate; //注册日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.RegisterDate) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.RegisterDate, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.RegisterDate] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAudit">是否审核</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetIsAudit(this clsUsersEN objUsersEN, bool bolIsAudit, string strComparisonOp="")
	{
objUsersEN.IsAudit = bolIsAudit; //是否审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.IsAudit) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.IsAudit, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.IsAudit] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strAuditUser">审核人</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetAuditUser(this clsUsersEN objUsersEN, string strAuditUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditUser, 18, conUsers.AuditUser);
objUsersEN.AuditUser = strAuditUser; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.AuditUser) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.AuditUser, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.AuditUser] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strAuditDate">审核日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetAuditDate(this clsUsersEN objUsersEN, string strAuditDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuditDate, 14, conUsers.AuditDate);
objUsersEN.AuditDate = strAuditDate; //审核日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.AuditDate) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.AuditDate, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.AuditDate] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUpdDate(this clsUsersEN objUsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUsers.UpdDate);
objUsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UpdDate) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UpdDate, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UpdDate] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetUpdUser(this clsUsersEN objUsersEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conUsers.UpdUser);
objUsersEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.UpdUser) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.UpdUser, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.UpdUser] = strComparisonOp;
}
}
return objUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUsersEN SetMemo(this clsUsersEN objUsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUsers.Memo);
objUsersEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUsersEN.dicFldComparisonOp.ContainsKey(conUsers.Memo) == false)
{
objUsersEN.dicFldComparisonOp.Add(conUsers.Memo, strComparisonOp);
}
else
{
objUsersEN.dicFldComparisonOp[conUsers.Memo] = strComparisonOp;
}
}
return objUsersEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUsersEN objUsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUsersCond.IsUpdated(conUsers.UserId) == true)
{
string strComparisonOpUserId = objUsersCond.dicFldComparisonOp[conUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UserId, objUsersCond.UserId, strComparisonOpUserId);
}
if (objUsersCond.IsUpdated(conUsers.UserName) == true)
{
string strComparisonOpUserName = objUsersCond.dicFldComparisonOp[conUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UserName, objUsersCond.UserName, strComparisonOpUserName);
}
if (objUsersCond.IsUpdated(conUsers.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objUsersCond.dicFldComparisonOp[conUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.DepartmentId, objUsersCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objUsersCond.IsUpdated(conUsers.UserStateId) == true)
{
string strComparisonOpUserStateId = objUsersCond.dicFldComparisonOp[conUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UserStateId, objUsersCond.UserStateId, strComparisonOpUserStateId);
}
if (objUsersCond.IsUpdated(conUsers.RoleId) == true)
{
string strComparisonOpRoleId = objUsersCond.dicFldComparisonOp[conUsers.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.RoleId, objUsersCond.RoleId, strComparisonOpRoleId);
}
if (objUsersCond.IsUpdated(conUsers.qxdj) == true)
{
string strComparisonOpqxdj = objUsersCond.dicFldComparisonOp[conUsers.qxdj];
strWhereCond += string.Format(" And {0} {2} {1}", conUsers.qxdj, objUsersCond.qxdj, strComparisonOpqxdj);
}
if (objUsersCond.IsUpdated(conUsers.EffectiveDate) == true)
{
string strComparisonOpEffectiveDate = objUsersCond.dicFldComparisonOp[conUsers.EffectiveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.EffectiveDate, objUsersCond.EffectiveDate, strComparisonOpEffectiveDate);
}
if (objUsersCond.IsUpdated(conUsers.EffitiveBeginDate) == true)
{
string strComparisonOpEffitiveBeginDate = objUsersCond.dicFldComparisonOp[conUsers.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.EffitiveBeginDate, objUsersCond.EffitiveBeginDate, strComparisonOpEffitiveBeginDate);
}
if (objUsersCond.IsUpdated(conUsers.EffitiveEndDate) == true)
{
string strComparisonOpEffitiveEndDate = objUsersCond.dicFldComparisonOp[conUsers.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.EffitiveEndDate, objUsersCond.EffitiveEndDate, strComparisonOpEffitiveEndDate);
}
if (objUsersCond.IsUpdated(conUsers.Password) == true)
{
string strComparisonOpPassword = objUsersCond.dicFldComparisonOp[conUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.Password, objUsersCond.Password, strComparisonOpPassword);
}
if (objUsersCond.IsUpdated(conUsers.IdentityID) == true)
{
string strComparisonOpIdentityID = objUsersCond.dicFldComparisonOp[conUsers.IdentityID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.IdentityID, objUsersCond.IdentityID, strComparisonOpIdentityID);
}
if (objUsersCond.IsUpdated(conUsers.Email) == true)
{
string strComparisonOpEmail = objUsersCond.dicFldComparisonOp[conUsers.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.Email, objUsersCond.Email, strComparisonOpEmail);
}
if (objUsersCond.IsUpdated(conUsers.IsGpUser) == true)
{
if (objUsersCond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsGpUser);
}
}
if (objUsersCond.IsUpdated(conUsers.RegisterPassword) == true)
{
string strComparisonOpRegisterPassword = objUsersCond.dicFldComparisonOp[conUsers.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.RegisterPassword, objUsersCond.RegisterPassword, strComparisonOpRegisterPassword);
}
if (objUsersCond.IsUpdated(conUsers.IsRegister) == true)
{
if (objUsersCond.IsRegister == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsRegister);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsRegister);
}
}
if (objUsersCond.IsUpdated(conUsers.RegisterDate) == true)
{
string strComparisonOpRegisterDate = objUsersCond.dicFldComparisonOp[conUsers.RegisterDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.RegisterDate, objUsersCond.RegisterDate, strComparisonOpRegisterDate);
}
if (objUsersCond.IsUpdated(conUsers.IsAudit) == true)
{
if (objUsersCond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUsers.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUsers.IsAudit);
}
}
if (objUsersCond.IsUpdated(conUsers.AuditUser) == true)
{
string strComparisonOpAuditUser = objUsersCond.dicFldComparisonOp[conUsers.AuditUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.AuditUser, objUsersCond.AuditUser, strComparisonOpAuditUser);
}
if (objUsersCond.IsUpdated(conUsers.AuditDate) == true)
{
string strComparisonOpAuditDate = objUsersCond.dicFldComparisonOp[conUsers.AuditDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.AuditDate, objUsersCond.AuditDate, strComparisonOpAuditDate);
}
if (objUsersCond.IsUpdated(conUsers.UpdDate) == true)
{
string strComparisonOpUpdDate = objUsersCond.dicFldComparisonOp[conUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UpdDate, objUsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objUsersCond.IsUpdated(conUsers.UpdUser) == true)
{
string strComparisonOpUpdUser = objUsersCond.dicFldComparisonOp[conUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.UpdUser, objUsersCond.UpdUser, strComparisonOpUpdUser);
}
if (objUsersCond.IsUpdated(conUsers.Memo) == true)
{
string strComparisonOpMemo = objUsersCond.dicFldComparisonOp[conUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUsers.Memo, objUsersCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUsersEN objUsersEN)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objUsersEN.sfUpdFldSetStr = objUsersEN.getsfUpdFldSetStr();
clsUsersWApi.CheckPropertyNew(objUsersEN); 
bool bolResult = clsUsersWApi.UpdateRecord(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUsersEN objUsersEN)
{
 if (string.IsNullOrEmpty(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUsersWApi.IsExist(objUsersEN.UserId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUsersEN.UserId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsUsersWApi.CheckPropertyNew(objUsersEN); 
bool bolResult = clsUsersWApi.AddNewRecord(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objUsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsUsersEN objUsersEN)
{
try
{
clsUsersWApi.CheckPropertyNew(objUsersEN); 
string strUserId = clsUsersWApi.AddNewRecordWithMaxId(objUsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
return strUserId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUsersEN objUsersEN, string strWhereCond)
{
try
{
clsUsersWApi.CheckPropertyNew(objUsersEN); 
bool bolResult = clsUsersWApi.UpdateWithCondition(objUsersEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 用于用户管理(Users)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsUsersWApi
{
private static readonly string mstrApiControllerName = "UsersApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsUsersWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用于用户管理]...","0");
List<clsUsersEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="UserId";
objDDL.DataTextField="UserName";
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

public static void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conUsers.UserId); 
List<clsUsersEN> arrObjLst = clsUsersWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsUsersEN objUsersEN = new clsUsersEN()
{
UserId = "0",
UserName = "选[用于用户管理]..."
};
arrObjLst.Insert(0, objUsersEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conUsers.UserId;
objComboBox.DisplayMember = conUsers.UserName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsUsersEN objUsersEN)
{
if (!Object.Equals(null, objUsersEN.UserId) && GetStrLen(objUsersEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objUsersEN.UserName) && GetStrLen(objUsersEN.UserName) > 30)
{
 throw new Exception("字段[用户名]的长度不能超过30!");
}
if (!Object.Equals(null, objUsersEN.DepartmentId) && GetStrLen(objUsersEN.DepartmentId) > 6)
{
 throw new Exception("字段[部门ID]的长度不能超过6!");
}
if (!Object.Equals(null, objUsersEN.UserStateId) && GetStrLen(objUsersEN.UserStateId) > 2)
{
 throw new Exception("字段[用户状态号]的长度不能超过2!");
}
if (!Object.Equals(null, objUsersEN.RoleId) && GetStrLen(objUsersEN.RoleId) > 8)
{
 throw new Exception("字段[角色ID]的长度不能超过8!");
}
if (!Object.Equals(null, objUsersEN.EffectiveDate) && GetStrLen(objUsersEN.EffectiveDate) > 8)
{
 throw new Exception("字段[有效日期]的长度不能超过8!");
}
if (!Object.Equals(null, objUsersEN.EffitiveBeginDate) && GetStrLen(objUsersEN.EffitiveBeginDate) > 14)
{
 throw new Exception("字段[有效开始日期]的长度不能超过14!");
}
if (!Object.Equals(null, objUsersEN.EffitiveEndDate) && GetStrLen(objUsersEN.EffitiveEndDate) > 14)
{
 throw new Exception("字段[有效结束日期]的长度不能超过14!");
}
if (!Object.Equals(null, objUsersEN.Password) && GetStrLen(objUsersEN.Password) > 20)
{
 throw new Exception("字段[口令]的长度不能超过20!");
}
if (!Object.Equals(null, objUsersEN.IdentityID) && GetStrLen(objUsersEN.IdentityID) > 2)
{
 throw new Exception("字段[身份编号]的长度不能超过2!");
}
if (!Object.Equals(null, objUsersEN.Email) && GetStrLen(objUsersEN.Email) > 50)
{
 throw new Exception("字段[电子邮箱]的长度不能超过50!");
}
if (!Object.Equals(null, objUsersEN.RegisterPassword) && GetStrLen(objUsersEN.RegisterPassword) > 30)
{
 throw new Exception("字段[注册密码]的长度不能超过30!");
}
if (!Object.Equals(null, objUsersEN.RegisterDate) && GetStrLen(objUsersEN.RegisterDate) > 14)
{
 throw new Exception("字段[注册日期]的长度不能超过14!");
}
if (!Object.Equals(null, objUsersEN.AuditUser) && GetStrLen(objUsersEN.AuditUser) > 18)
{
 throw new Exception("字段[审核人]的长度不能超过18!");
}
if (!Object.Equals(null, objUsersEN.AuditDate) && GetStrLen(objUsersEN.AuditDate) > 14)
{
 throw new Exception("字段[审核日期]的长度不能超过14!");
}
if (!Object.Equals(null, objUsersEN.UpdDate) && GetStrLen(objUsersEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objUsersEN.UpdUser) && GetStrLen(objUsersEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objUsersEN.Memo) && GetStrLen(objUsersEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objUsersEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUsersEN GetObjByUserId(string strUserId)
{
if (strUserId == "") return null;
string strAction = "GetObjByUserId";
clsUsersEN objUsersEN;
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
objUsersEN = JsonConvert.DeserializeObject<clsUsersEN>(strJson);
return objUsersEN;
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
public static clsUsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsUsersEN objUsersEN;
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
objUsersEN = JsonConvert.DeserializeObject<clsUsersEN>(strJson);
return objUsersEN;
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUsersEN GetObjByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsUsersEN._CurrTabName);
List<clsUsersEN> arrUsersObjLstCache = GetObjLstCache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel =
from objUsersEN in arrUsersObjLstCache
where objUsersEN.UserId == strUserId 
select objUsersEN;
if (arrUsersObjLst_Sel.Count() == 0)
{
   clsUsersEN obj = clsUsersWApi.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrUsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//初始化列表缓存
List<clsUsersEN> arrUsersObjLstCache = GetObjLstCache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel1 =
from objUsersEN in arrUsersObjLstCache
where objUsersEN.UserId == strUserId 
select objUsersEN;
List <clsUsersEN> arrUsersObjLst_Sel = new List<clsUsersEN>();
foreach (clsUsersEN obj in arrUsersObjLst_Sel1)
{
arrUsersObjLst_Sel.Add(obj);
}
if (arrUsersObjLst_Sel.Count > 0)
{
return arrUsersObjLst_Sel[0].UserName;
}
string strErrMsgForGetObjById = string.Format("在Users对象缓存列表中,找不到记录[UserId = {0}](函数:{1})", strUserId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsUsersBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByUserIdCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//初始化列表缓存
List<clsUsersEN> arrUsersObjLstCache = GetObjLstCache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel1 =
from objUsersEN in arrUsersObjLstCache
where objUsersEN.UserId == strUserId 
select objUsersEN;
List <clsUsersEN> arrUsersObjLst_Sel = new List<clsUsersEN>();
foreach (clsUsersEN obj in arrUsersObjLst_Sel1)
{
arrUsersObjLst_Sel.Add(obj);
}
if (arrUsersObjLst_Sel.Count > 0)
{
return arrUsersObjLst_Sel[0].UserName;
}
string strErrMsgForGetObjById = string.Format("在Users对象缓存列表中,找不到记录的相关名称[UserId = {0}](函数:{1})", strUserId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsUsersBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUsersEN> GetObjLst(string strWhereCond)
{
 List<clsUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>(strJson);
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
public static List<clsUsersEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>(strJson);
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
 /// <param name = "arrUserId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsUsersEN> GetObjLstByUserIdLstCache(List<string> arrUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsUsersEN._CurrTabName);
List<clsUsersEN> arrUsersObjLstCache = GetObjLstCache();
IEnumerable <clsUsersEN> arrUsersObjLst_Sel =
from objUsersEN in arrUsersObjLstCache
where arrUserId.Contains(objUsersEN.UserId)
select objUsersEN;
return arrUsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>(strJson);
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
public static List<clsUsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>(strJson);
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
public static List<clsUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>(strJson);
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
public static List<clsUsersEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUsersEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strUserId)
{
string strAction = "DelRecord";
try
{
 clsUsersEN objUsersEN = clsUsersWApi.GetObjByUserId(strUserId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strUserId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsUsersWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelUserss(List<string> arrUserId)
{
string strAction = "DelUserss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsUsersWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelUserssByCond(string strWhereCond)
{
string strAction = "DelUserssByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsUsersEN objUsersEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUsersEN>(objUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsUsersEN objUsersEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUsersEN>(objUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshCache();
var strUserId = (string)jobjReturn0["returnStr"];
return strUserId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsUsersEN objUsersEN)
{
if (string.IsNullOrEmpty(objUsersEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUsersEN>(objUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsUsersEN objUsersEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objUsersEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUsersEN.UserId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUsersEN>(objUsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objUsersENS">源对象</param>
 /// <param name = "objUsersENT">目标对象</param>
 public static void CopyTo(clsUsersEN objUsersENS, clsUsersEN objUsersENT)
{
try
{
objUsersENT.UserId = objUsersENS.UserId; //用户Id
objUsersENT.UserName = objUsersENS.UserName; //用户名
objUsersENT.DepartmentId = objUsersENS.DepartmentId; //部门ID
objUsersENT.UserStateId = objUsersENS.UserStateId; //用户状态号
objUsersENT.RoleId = objUsersENS.RoleId; //角色ID
objUsersENT.qxdj = objUsersENS.qxdj; //权限等级
objUsersENT.EffectiveDate = objUsersENS.EffectiveDate; //有效日期
objUsersENT.EffitiveBeginDate = objUsersENS.EffitiveBeginDate; //有效开始日期
objUsersENT.EffitiveEndDate = objUsersENS.EffitiveEndDate; //有效结束日期
objUsersENT.Password = objUsersENS.Password; //口令
objUsersENT.IdentityID = objUsersENS.IdentityID; //身份编号
objUsersENT.Email = objUsersENS.Email; //电子邮箱
objUsersENT.IsGpUser = objUsersENS.IsGpUser; //是否平台用户
objUsersENT.RegisterPassword = objUsersENS.RegisterPassword; //注册密码
objUsersENT.IsRegister = objUsersENS.IsRegister; //是否注册
objUsersENT.RegisterDate = objUsersENS.RegisterDate; //注册日期
objUsersENT.IsAudit = objUsersENS.IsAudit; //是否审核
objUsersENT.AuditUser = objUsersENS.AuditUser; //审核人
objUsersENT.AuditDate = objUsersENS.AuditDate; //审核日期
objUsersENT.UpdDate = objUsersENS.UpdDate; //修改日期
objUsersENT.UpdUser = objUsersENS.UpdUser; //修改者
objUsersENT.Memo = objUsersENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsUsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsUsersEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsUsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsUsersEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsUsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsUsersEN._AttributeName)
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
string strKey = string.Format("{0}", clsUsersEN._CurrTabName);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsUsersWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUsersEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUsersWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUsersEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsUsersEN._CurrTabName;
List<clsUsersEN> arrUsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrUsersObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsUsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conUsers.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.UserName, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.qxdj, Type.GetType("System.Int32"));
objDT.Columns.Add(conUsers.EffectiveDate, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.Password, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.IdentityID, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.Email, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUsers.RegisterPassword, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.IsRegister, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUsers.RegisterDate, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.IsAudit, Type.GetType("System.Boolean"));
objDT.Columns.Add(conUsers.AuditUser, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.AuditDate, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conUsers.Memo, Type.GetType("System.String"));
foreach (clsUsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conUsers.UserId] = objInFor[conUsers.UserId];
objDR[conUsers.UserName] = objInFor[conUsers.UserName];
objDR[conUsers.DepartmentId] = objInFor[conUsers.DepartmentId];
objDR[conUsers.UserStateId] = objInFor[conUsers.UserStateId];
objDR[conUsers.RoleId] = objInFor[conUsers.RoleId];
objDR[conUsers.qxdj] = objInFor[conUsers.qxdj];
objDR[conUsers.EffectiveDate] = objInFor[conUsers.EffectiveDate];
objDR[conUsers.EffitiveBeginDate] = objInFor[conUsers.EffitiveBeginDate];
objDR[conUsers.EffitiveEndDate] = objInFor[conUsers.EffitiveEndDate];
objDR[conUsers.Password] = objInFor[conUsers.Password];
objDR[conUsers.IdentityID] = objInFor[conUsers.IdentityID];
objDR[conUsers.Email] = objInFor[conUsers.Email];
objDR[conUsers.IsGpUser] = objInFor[conUsers.IsGpUser];
objDR[conUsers.RegisterPassword] = objInFor[conUsers.RegisterPassword];
objDR[conUsers.IsRegister] = objInFor[conUsers.IsRegister];
objDR[conUsers.RegisterDate] = objInFor[conUsers.RegisterDate];
objDR[conUsers.IsAudit] = objInFor[conUsers.IsAudit];
objDR[conUsers.AuditUser] = objInFor[conUsers.AuditUser];
objDR[conUsers.AuditDate] = objInFor[conUsers.AuditDate];
objDR[conUsers.UpdDate] = objInFor[conUsers.UpdDate];
objDR[conUsers.UpdUser] = objInFor[conUsers.UpdUser];
objDR[conUsers.Memo] = objInFor[conUsers.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用于用户管理(Users)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4Users : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUsersWApi.ReFreshThisCache();
}
}

}