
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPrjGrantWApi
 表名:vUserPrjGrant(00050174)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:权限管理(AuthorityManage)
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
public static class  clsvUserPrjGrantWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetmId(this clsvUserPrjGrantEN objvUserPrjGrantEN, long lngmId, string strComparisonOp="")
	{
objvUserPrjGrantEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.mId) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.mId, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.mId] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetUserId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convUserPrjGrant.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convUserPrjGrant.UserId);
objvUserPrjGrantEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.UserId) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.UserId, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.UserId] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetUserName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUserPrjGrant.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convUserPrjGrant.UserName);
objvUserPrjGrantEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.UserName) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.UserName, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.UserName] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetUserStateName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convUserPrjGrant.UserStateName);
objvUserPrjGrantEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.UserStateName) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.UserStateName, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.UserStateName] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetDepartmentId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, convUserPrjGrant.DepartmentId);
objvUserPrjGrantEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.DepartmentId) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.DepartmentId, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.DepartmentId] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetDepartmentName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentName, 30, convUserPrjGrant.DepartmentName);
objvUserPrjGrantEN.DepartmentName = strDepartmentName; //部门名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.DepartmentName) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.DepartmentName, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.DepartmentName] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetPrjId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convUserPrjGrant.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserPrjGrant.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserPrjGrant.PrjId);
objvUserPrjGrantEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.PrjId) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.PrjId, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.PrjId] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetPrjName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convUserPrjGrant.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convUserPrjGrant.PrjName);
objvUserPrjGrantEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.PrjName) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.PrjName, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.PrjName] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetRoleId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, convUserPrjGrant.RoleId);
clsCheckSql.CheckFieldLen(strRoleId, 8, convUserPrjGrant.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convUserPrjGrant.RoleId);
objvUserPrjGrantEN.RoleId = strRoleId; //角色ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.RoleId) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.RoleId, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.RoleId] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetRoleName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convUserPrjGrant.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 30, convUserPrjGrant.RoleName);
objvUserPrjGrantEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.RoleName) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.RoleName, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.RoleName] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "intVisitedNum">访问数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetVisitedNum(this clsvUserPrjGrantEN objvUserPrjGrantEN, int intVisitedNum, string strComparisonOp="")
	{
objvUserPrjGrantEN.VisitedNum = intVisitedNum; //访问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.VisitedNum) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.VisitedNum, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.VisitedNum] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strLastVisitedDate">最后访问时间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetLastVisitedDate(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strLastVisitedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 20, convUserPrjGrant.LastVisitedDate);
objvUserPrjGrantEN.LastVisitedDate = strLastVisitedDate; //最后访问时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.LastVisitedDate) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.LastVisitedDate, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.LastVisitedDate] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strOptId">操作者Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetOptId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strOptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptId, 18, convUserPrjGrant.OptId);
objvUserPrjGrantEN.OptId = strOptId; //操作者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.OptId) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.OptId, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.OptId] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strOptDate">操作日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetOptDate(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strOptDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptDate, 20, convUserPrjGrant.OptDate);
objvUserPrjGrantEN.OptDate = strOptDate; //操作日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.OptDate) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.OptDate, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.OptDate] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetMemo(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserPrjGrant.Memo);
objvUserPrjGrantEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.Memo) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.Memo, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.Memo] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetUseStateId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convUserPrjGrant.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convUserPrjGrant.UseStateId);
objvUserPrjGrantEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPrjGrantEN.dicFldComparisonOp.ContainsKey(convUserPrjGrant.UseStateId) == false)
{
objvUserPrjGrantEN.dicFldComparisonOp.Add(convUserPrjGrant.UseStateId, strComparisonOp);
}
else
{
objvUserPrjGrantEN.dicFldComparisonOp[convUserPrjGrant.UseStateId] = strComparisonOp;
}
}
return objvUserPrjGrantEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserPrjGrantEN objvUserPrjGrantCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.mId) == true)
{
string strComparisonOpmId = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserPrjGrant.mId, objvUserPrjGrantCond.mId, strComparisonOpmId);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.UserId) == true)
{
string strComparisonOpUserId = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.UserId, objvUserPrjGrantCond.UserId, strComparisonOpUserId);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.UserName) == true)
{
string strComparisonOpUserName = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.UserName, objvUserPrjGrantCond.UserName, strComparisonOpUserName);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.UserStateName) == true)
{
string strComparisonOpUserStateName = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.UserStateName, objvUserPrjGrantCond.UserStateName, strComparisonOpUserStateName);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.DepartmentId, objvUserPrjGrantCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.DepartmentName, objvUserPrjGrantCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.PrjId) == true)
{
string strComparisonOpPrjId = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.PrjId, objvUserPrjGrantCond.PrjId, strComparisonOpPrjId);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.PrjName) == true)
{
string strComparisonOpPrjName = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.PrjName, objvUserPrjGrantCond.PrjName, strComparisonOpPrjName);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.RoleId) == true)
{
string strComparisonOpRoleId = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.RoleId, objvUserPrjGrantCond.RoleId, strComparisonOpRoleId);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.RoleName) == true)
{
string strComparisonOpRoleName = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.RoleName, objvUserPrjGrantCond.RoleName, strComparisonOpRoleName);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.VisitedNum) == true)
{
string strComparisonOpVisitedNum = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.VisitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", convUserPrjGrant.VisitedNum, objvUserPrjGrantCond.VisitedNum, strComparisonOpVisitedNum);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.LastVisitedDate) == true)
{
string strComparisonOpLastVisitedDate = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.LastVisitedDate, objvUserPrjGrantCond.LastVisitedDate, strComparisonOpLastVisitedDate);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.OptId) == true)
{
string strComparisonOpOptId = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.OptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.OptId, objvUserPrjGrantCond.OptId, strComparisonOpOptId);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.OptDate) == true)
{
string strComparisonOpOptDate = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.OptDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.OptDate, objvUserPrjGrantCond.OptDate, strComparisonOpOptDate);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.Memo) == true)
{
string strComparisonOpMemo = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.Memo, objvUserPrjGrantCond.Memo, strComparisonOpMemo);
}
if (objvUserPrjGrantCond.IsUpdated(convUserPrjGrant.UseStateId) == true)
{
string strComparisonOpUseStateId = objvUserPrjGrantCond.dicFldComparisonOp[convUserPrjGrant.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPrjGrant.UseStateId, objvUserPrjGrantCond.UseStateId, strComparisonOpUseStateId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vUserPrjGrant(vUserPrjGrant)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUserPrjGrantWApi
{
private static readonly string mstrApiControllerName = "vUserPrjGrantApi";

 public clsvUserPrjGrantWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserPrjGrantEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvUserPrjGrantEN objvUserPrjGrantEN;
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
objvUserPrjGrantEN = JsonConvert.DeserializeObject<clsvUserPrjGrantEN>(strJson);
return objvUserPrjGrantEN;
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
public static clsvUserPrjGrantEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvUserPrjGrantEN objvUserPrjGrantEN;
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
objvUserPrjGrantEN = JsonConvert.DeserializeObject<clsvUserPrjGrantEN>(strJson);
return objvUserPrjGrantEN;
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
public static List<clsvUserPrjGrantEN> GetObjLst(string strWhereCond)
{
 List<clsvUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPrjGrantEN>>(strJson);
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
public static List<clsvUserPrjGrantEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPrjGrantEN>>(strJson);
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
public static List<clsvUserPrjGrantEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPrjGrantEN>>(strJson);
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
public static List<clsvUserPrjGrantEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPrjGrantEN>>(strJson);
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
public static List<clsvUserPrjGrantEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPrjGrantEN>>(strJson);
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
public static List<clsvUserPrjGrantEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPrjGrantEN>>(strJson);
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
 /// <param name = "objvUserPrjGrantENS">源对象</param>
 /// <param name = "objvUserPrjGrantENT">目标对象</param>
 public static void CopyTo(clsvUserPrjGrantEN objvUserPrjGrantENS, clsvUserPrjGrantEN objvUserPrjGrantENT)
{
try
{
objvUserPrjGrantENT.mId = objvUserPrjGrantENS.mId; //mId
objvUserPrjGrantENT.UserId = objvUserPrjGrantENS.UserId; //用户Id
objvUserPrjGrantENT.UserName = objvUserPrjGrantENS.UserName; //用户名
objvUserPrjGrantENT.UserStateName = objvUserPrjGrantENS.UserStateName; //用户状态名
objvUserPrjGrantENT.DepartmentId = objvUserPrjGrantENS.DepartmentId; //部门ID
objvUserPrjGrantENT.DepartmentName = objvUserPrjGrantENS.DepartmentName; //部门名称
objvUserPrjGrantENT.PrjId = objvUserPrjGrantENS.PrjId; //工程Id
objvUserPrjGrantENT.PrjName = objvUserPrjGrantENS.PrjName; //工程名称
objvUserPrjGrantENT.RoleId = objvUserPrjGrantENS.RoleId; //角色ID
objvUserPrjGrantENT.RoleName = objvUserPrjGrantENS.RoleName; //角色名称
objvUserPrjGrantENT.VisitedNum = objvUserPrjGrantENS.VisitedNum; //访问数
objvUserPrjGrantENT.LastVisitedDate = objvUserPrjGrantENS.LastVisitedDate; //最后访问时间
objvUserPrjGrantENT.OptId = objvUserPrjGrantENS.OptId; //操作者Id
objvUserPrjGrantENT.OptDate = objvUserPrjGrantENS.OptDate; //操作日期
objvUserPrjGrantENT.Memo = objvUserPrjGrantENS.Memo; //说明
objvUserPrjGrantENT.UseStateId = objvUserPrjGrantENS.UseStateId; //使用状态Id
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
public static DataTable ToDataTable(List<clsvUserPrjGrantEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUserPrjGrantEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUserPrjGrantEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUserPrjGrantEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUserPrjGrantEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUserPrjGrantEN._AttributeName)
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
string strKey = string.Format("{0}", clsvUserPrjGrantEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvUserPrjGrantEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUserPrjGrant.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convUserPrjGrant.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.VisitedNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convUserPrjGrant.LastVisitedDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.OptId, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.OptDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convUserPrjGrant.UseStateId, Type.GetType("System.String"));
foreach (clsvUserPrjGrantEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUserPrjGrant.mId] = objInFor[convUserPrjGrant.mId];
objDR[convUserPrjGrant.UserId] = objInFor[convUserPrjGrant.UserId];
objDR[convUserPrjGrant.UserName] = objInFor[convUserPrjGrant.UserName];
objDR[convUserPrjGrant.UserStateName] = objInFor[convUserPrjGrant.UserStateName];
objDR[convUserPrjGrant.DepartmentId] = objInFor[convUserPrjGrant.DepartmentId];
objDR[convUserPrjGrant.DepartmentName] = objInFor[convUserPrjGrant.DepartmentName];
objDR[convUserPrjGrant.PrjId] = objInFor[convUserPrjGrant.PrjId];
objDR[convUserPrjGrant.PrjName] = objInFor[convUserPrjGrant.PrjName];
objDR[convUserPrjGrant.RoleId] = objInFor[convUserPrjGrant.RoleId];
objDR[convUserPrjGrant.RoleName] = objInFor[convUserPrjGrant.RoleName];
objDR[convUserPrjGrant.VisitedNum] = objInFor[convUserPrjGrant.VisitedNum];
objDR[convUserPrjGrant.LastVisitedDate] = objInFor[convUserPrjGrant.LastVisitedDate];
objDR[convUserPrjGrant.OptId] = objInFor[convUserPrjGrant.OptId];
objDR[convUserPrjGrant.OptDate] = objInFor[convUserPrjGrant.OptDate];
objDR[convUserPrjGrant.Memo] = objInFor[convUserPrjGrant.Memo];
objDR[convUserPrjGrant.UseStateId] = objInFor[convUserPrjGrant.UseStateId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}