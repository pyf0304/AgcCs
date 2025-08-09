
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPrjGrantBL
 表名:vUserPrjGrant(00050174)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:权限管理(AuthorityManage)
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
public static class  clsvUserPrjGrantBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserPrjGrantEN GetObj(this K_mId_vUserPrjGrant myKey)
{
clsvUserPrjGrantEN objvUserPrjGrantEN = clsvUserPrjGrantBL.vUserPrjGrantDA.GetObjBymId(myKey.Value);
return objvUserPrjGrantEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetUserId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convUserPrjGrant.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convUserPrjGrant.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetUserName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUserPrjGrant.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convUserPrjGrant.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetUserStateName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strUserStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convUserPrjGrant.UserStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetDepartmentId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, convUserPrjGrant.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetDepartmentName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 30, convUserPrjGrant.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetPrjId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convUserPrjGrant.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserPrjGrant.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserPrjGrant.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetPrjName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convUserPrjGrant.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convUserPrjGrant.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetRoleId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, convUserPrjGrant.RoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convUserPrjGrant.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convUserPrjGrant.RoleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetRoleName(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convUserPrjGrant.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 30, convUserPrjGrant.RoleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetVisitedNum(this clsvUserPrjGrantEN objvUserPrjGrantEN, int? intVisitedNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetLastVisitedDate(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strLastVisitedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 20, convUserPrjGrant.LastVisitedDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetOptId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strOptId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptId, 18, convUserPrjGrant.OptId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetOptDate(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strOptDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptDate, 20, convUserPrjGrant.OptDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetMemo(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserPrjGrant.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserPrjGrantEN SetUseStateId(this clsvUserPrjGrantEN objvUserPrjGrantEN, string strUseStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convUserPrjGrant.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convUserPrjGrant.UseStateId);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUserPrjGrantENS">源对象</param>
 /// <param name = "objvUserPrjGrantENT">目标对象</param>
 public static void CopyTo(this clsvUserPrjGrantEN objvUserPrjGrantENS, clsvUserPrjGrantEN objvUserPrjGrantENT)
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
 /// <param name = "objvUserPrjGrantENS">源对象</param>
 /// <returns>目标对象=>clsvUserPrjGrantEN:objvUserPrjGrantENT</returns>
 public static clsvUserPrjGrantEN CopyTo(this clsvUserPrjGrantEN objvUserPrjGrantENS)
{
try
{
 clsvUserPrjGrantEN objvUserPrjGrantENT = new clsvUserPrjGrantEN()
{
mId = objvUserPrjGrantENS.mId, //mId
UserId = objvUserPrjGrantENS.UserId, //用户Id
UserName = objvUserPrjGrantENS.UserName, //用户名
UserStateName = objvUserPrjGrantENS.UserStateName, //用户状态名
DepartmentId = objvUserPrjGrantENS.DepartmentId, //部门ID
DepartmentName = objvUserPrjGrantENS.DepartmentName, //部门名称
PrjId = objvUserPrjGrantENS.PrjId, //工程Id
PrjName = objvUserPrjGrantENS.PrjName, //工程名称
RoleId = objvUserPrjGrantENS.RoleId, //角色ID
RoleName = objvUserPrjGrantENS.RoleName, //角色名称
VisitedNum = objvUserPrjGrantENS.VisitedNum, //访问数
LastVisitedDate = objvUserPrjGrantENS.LastVisitedDate, //最后访问时间
OptId = objvUserPrjGrantENS.OptId, //操作者Id
OptDate = objvUserPrjGrantENS.OptDate, //操作日期
Memo = objvUserPrjGrantENS.Memo, //说明
UseStateId = objvUserPrjGrantENS.UseStateId, //使用状态Id
};
 return objvUserPrjGrantENT;
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
public static void CheckProperty4Condition(this clsvUserPrjGrantEN objvUserPrjGrantEN)
{
 clsvUserPrjGrantBL.vUserPrjGrantDA.CheckProperty4Condition(objvUserPrjGrantEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUserPrjGrant
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vUserPrjGrant(vUserPrjGrant)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUserPrjGrantBL
{
public static RelatedActions_vUserPrjGrant relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUserPrjGrantDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUserPrjGrantDA vUserPrjGrantDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUserPrjGrantDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUserPrjGrantBL()
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
if (string.IsNullOrEmpty(clsvUserPrjGrantEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserPrjGrantEN._ConnectString);
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
public static DataTable GetDataTable_vUserPrjGrant(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUserPrjGrantDA.GetDataTable_vUserPrjGrant(strWhereCond);
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
objDT = vUserPrjGrantDA.GetDataTable(strWhereCond);
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
objDT = vUserPrjGrantDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vUserPrjGrantDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUserPrjGrantDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vUserPrjGrantDA.GetDataTable_Top(objTopPara);
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
objDT = vUserPrjGrantDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUserPrjGrantDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUserPrjGrantDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvUserPrjGrantEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
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
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUserPrjGrantEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvUserPrjGrantEN._CurrTabName);
List<clsvUserPrjGrantEN> arrvUserPrjGrantObjLstCache = GetObjLstCache();
IEnumerable <clsvUserPrjGrantEN> arrvUserPrjGrantObjLst_Sel =
arrvUserPrjGrantObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvUserPrjGrantObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserPrjGrantEN> GetObjLst(string strWhereCond)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
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
public static List<clsvUserPrjGrantEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUserPrjGrantCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUserPrjGrantEN> GetSubObjLstCache(clsvUserPrjGrantEN objvUserPrjGrantCond)
{
List<clsvUserPrjGrantEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserPrjGrantEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserPrjGrant._AttributeName)
{
if (objvUserPrjGrantCond.IsUpdated(strFldName) == false) continue;
if (objvUserPrjGrantCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserPrjGrantCond[strFldName].ToString());
}
else
{
if (objvUserPrjGrantCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserPrjGrantCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserPrjGrantCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserPrjGrantCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserPrjGrantCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserPrjGrantCond[strFldName]));
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
public static List<clsvUserPrjGrantEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
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
public static List<clsvUserPrjGrantEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
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
List<clsvUserPrjGrantEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUserPrjGrantEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserPrjGrantEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUserPrjGrantEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
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
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
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
public static List<clsvUserPrjGrantEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUserPrjGrantEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUserPrjGrantEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
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
public static List<clsvUserPrjGrantEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserPrjGrantEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserPrjGrantEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUserPrjGrant(ref clsvUserPrjGrantEN objvUserPrjGrantEN)
{
bool bolResult = vUserPrjGrantDA.GetvUserPrjGrant(ref objvUserPrjGrantEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserPrjGrantEN GetObjBymId(long lngmId)
{
clsvUserPrjGrantEN objvUserPrjGrantEN = vUserPrjGrantDA.GetObjBymId(lngmId);
return objvUserPrjGrantEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUserPrjGrantEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUserPrjGrantEN objvUserPrjGrantEN = vUserPrjGrantDA.GetFirstObj(strWhereCond);
 return objvUserPrjGrantEN;
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
public static clsvUserPrjGrantEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUserPrjGrantEN objvUserPrjGrantEN = vUserPrjGrantDA.GetObjByDataRow(objRow);
 return objvUserPrjGrantEN;
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
public static clsvUserPrjGrantEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUserPrjGrantEN objvUserPrjGrantEN = vUserPrjGrantDA.GetObjByDataRow(objRow);
 return objvUserPrjGrantEN;
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
 /// <param name = "lstvUserPrjGrantObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserPrjGrantEN GetObjBymIdFromList(long lngmId, List<clsvUserPrjGrantEN> lstvUserPrjGrantObjLst)
{
foreach (clsvUserPrjGrantEN objvUserPrjGrantEN in lstvUserPrjGrantObjLst)
{
if (objvUserPrjGrantEN.mId == lngmId)
{
return objvUserPrjGrantEN;
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
 lngmId = new clsvUserPrjGrantDA().GetFirstID(strWhereCond);
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
 arrList = vUserPrjGrantDA.GetID(strWhereCond);
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
bool bolIsExist = vUserPrjGrantDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vUserPrjGrantDA.IsExist(lngmId);
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
 bolIsExist = clsvUserPrjGrantDA.IsExistTable();
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
 bolIsExist = vUserPrjGrantDA.IsExistTable(strTabName);
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
 /// <param name = "objvUserPrjGrantEN">源简化对象</param>
 public static void SetUpdFlag(clsvUserPrjGrantEN objvUserPrjGrantEN)
{
try
{
objvUserPrjGrantEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUserPrjGrantEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUserPrjGrant.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.mId = objvUserPrjGrantEN.mId; //mId
}
if (arrFldSet.Contains(convUserPrjGrant.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.UserId = objvUserPrjGrantEN.UserId; //用户Id
}
if (arrFldSet.Contains(convUserPrjGrant.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.UserName = objvUserPrjGrantEN.UserName; //用户名
}
if (arrFldSet.Contains(convUserPrjGrant.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.UserStateName = objvUserPrjGrantEN.UserStateName == "[null]" ? null :  objvUserPrjGrantEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convUserPrjGrant.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.DepartmentId = objvUserPrjGrantEN.DepartmentId == "[null]" ? null :  objvUserPrjGrantEN.DepartmentId; //部门ID
}
if (arrFldSet.Contains(convUserPrjGrant.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.DepartmentName = objvUserPrjGrantEN.DepartmentName == "[null]" ? null :  objvUserPrjGrantEN.DepartmentName; //部门名称
}
if (arrFldSet.Contains(convUserPrjGrant.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.PrjId = objvUserPrjGrantEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convUserPrjGrant.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.PrjName = objvUserPrjGrantEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convUserPrjGrant.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.RoleId = objvUserPrjGrantEN.RoleId; //角色ID
}
if (arrFldSet.Contains(convUserPrjGrant.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.RoleName = objvUserPrjGrantEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convUserPrjGrant.VisitedNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.VisitedNum = objvUserPrjGrantEN.VisitedNum; //访问数
}
if (arrFldSet.Contains(convUserPrjGrant.LastVisitedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.LastVisitedDate = objvUserPrjGrantEN.LastVisitedDate == "[null]" ? null :  objvUserPrjGrantEN.LastVisitedDate; //最后访问时间
}
if (arrFldSet.Contains(convUserPrjGrant.OptId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.OptId = objvUserPrjGrantEN.OptId == "[null]" ? null :  objvUserPrjGrantEN.OptId; //操作者Id
}
if (arrFldSet.Contains(convUserPrjGrant.OptDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.OptDate = objvUserPrjGrantEN.OptDate == "[null]" ? null :  objvUserPrjGrantEN.OptDate; //操作日期
}
if (arrFldSet.Contains(convUserPrjGrant.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.Memo = objvUserPrjGrantEN.Memo == "[null]" ? null :  objvUserPrjGrantEN.Memo; //说明
}
if (arrFldSet.Contains(convUserPrjGrant.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserPrjGrantEN.UseStateId = objvUserPrjGrantEN.UseStateId == "[null]" ? null :  objvUserPrjGrantEN.UseStateId; //使用状态Id
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
 /// <param name = "objvUserPrjGrantEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUserPrjGrantEN objvUserPrjGrantEN)
{
try
{
if (objvUserPrjGrantEN.UserStateName == "[null]") objvUserPrjGrantEN.UserStateName = null; //用户状态名
if (objvUserPrjGrantEN.DepartmentId == "[null]") objvUserPrjGrantEN.DepartmentId = null; //部门ID
if (objvUserPrjGrantEN.DepartmentName == "[null]") objvUserPrjGrantEN.DepartmentName = null; //部门名称
if (objvUserPrjGrantEN.LastVisitedDate == "[null]") objvUserPrjGrantEN.LastVisitedDate = null; //最后访问时间
if (objvUserPrjGrantEN.OptId == "[null]") objvUserPrjGrantEN.OptId = null; //操作者Id
if (objvUserPrjGrantEN.OptDate == "[null]") objvUserPrjGrantEN.OptDate = null; //操作日期
if (objvUserPrjGrantEN.Memo == "[null]") objvUserPrjGrantEN.Memo = null; //说明
if (objvUserPrjGrantEN.UseStateId == "[null]") objvUserPrjGrantEN.UseStateId = null; //使用状态Id
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
public static void CheckProperty4Condition(clsvUserPrjGrantEN objvUserPrjGrantEN)
{
 vUserPrjGrantDA.CheckProperty4Condition(objvUserPrjGrantEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsUserPrjGrantBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserPrjGrantBL没有刷新缓存机制(clsUserPrjGrantBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvUserPrjGrantObjLstCache == null)
//{
//arrvUserPrjGrantObjLstCache = vUserPrjGrantDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserPrjGrantEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvUserPrjGrantEN._CurrTabName);
List<clsvUserPrjGrantEN> arrvUserPrjGrantObjLstCache = GetObjLstCache();
IEnumerable <clsvUserPrjGrantEN> arrvUserPrjGrantObjLst_Sel =
arrvUserPrjGrantObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvUserPrjGrantObjLst_Sel.Count() == 0)
{
   clsvUserPrjGrantEN obj = clsvUserPrjGrantBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvUserPrjGrantObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserPrjGrantEN> GetAllvUserPrjGrantObjLstCache()
{
//获取缓存中的对象列表
List<clsvUserPrjGrantEN> arrvUserPrjGrantObjLstCache = GetObjLstCache(); 
return arrvUserPrjGrantObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserPrjGrantEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvUserPrjGrantEN._CurrTabName);
List<clsvUserPrjGrantEN> arrvUserPrjGrantObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUserPrjGrantObjLstCache;
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
string strKey = string.Format("{0}", clsvUserPrjGrantEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvUserPrjGrantEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvUserPrjGrantEN._RefreshTimeLst.Count == 0) return "";
return clsvUserPrjGrantEN._RefreshTimeLst[clsvUserPrjGrantEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convUserPrjGrant.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUserPrjGrant._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUserPrjGrant._AttributeName));
throw new Exception(strMsg);
}
var objvUserPrjGrant = clsvUserPrjGrantBL.GetObjBymIdCache(lngmId);
if (objvUserPrjGrant == null) return "";
return objvUserPrjGrant[strOutFldName].ToString();
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
int intRecCount = clsvUserPrjGrantDA.GetRecCount(strTabName);
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
int intRecCount = clsvUserPrjGrantDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUserPrjGrantDA.GetRecCount();
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
int intRecCount = clsvUserPrjGrantDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUserPrjGrantCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUserPrjGrantEN objvUserPrjGrantCond)
{
List<clsvUserPrjGrantEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserPrjGrantEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserPrjGrant._AttributeName)
{
if (objvUserPrjGrantCond.IsUpdated(strFldName) == false) continue;
if (objvUserPrjGrantCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserPrjGrantCond[strFldName].ToString());
}
else
{
if (objvUserPrjGrantCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserPrjGrantCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserPrjGrantCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserPrjGrantCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserPrjGrantCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserPrjGrantCond[strFldName]));
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
 List<string> arrList = clsvUserPrjGrantDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUserPrjGrantDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUserPrjGrantDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}