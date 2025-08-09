
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabCheckResultWApi
 表名:vTabCheckResult(00050191)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsvTabCheckResultWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetmId(this clsvTabCheckResultEN objvTabCheckResultEN, long lngmId, string strComparisonOp="")
	{
objvTabCheckResultEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.mId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.mId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.mId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetPrjId(this clsvTabCheckResultEN objvTabCheckResultEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTabCheckResult.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabCheckResult.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabCheckResult.PrjId);
objvTabCheckResultEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.PrjId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.PrjId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.PrjId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetFldId(this clsvTabCheckResultEN objvTabCheckResultEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convTabCheckResult.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convTabCheckResult.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convTabCheckResult.FldId);
objvTabCheckResultEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.FldId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.FldId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.FldId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetPrjName(this clsvTabCheckResultEN objvTabCheckResultEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convTabCheckResult.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convTabCheckResult.PrjName);
objvTabCheckResultEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.PrjName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.PrjName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.PrjName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseName">项目数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetPrjDataBaseName(this clsvTabCheckResultEN objvTabCheckResultEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convTabCheckResult.PrjDataBaseName);
objvTabCheckResultEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.PrjDataBaseName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.PrjDataBaseName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.PrjDataBaseName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetPrjDataBaseId(this clsvTabCheckResultEN objvTabCheckResultEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convTabCheckResult.PrjDataBaseId);
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convTabCheckResult.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convTabCheckResult.PrjDataBaseId);
objvTabCheckResultEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.PrjDataBaseId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.PrjDataBaseId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.PrjDataBaseId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabId(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabCheckResult.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convTabCheckResult.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabCheckResult.TabId);
objvTabCheckResultEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.TabId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.TabId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.TabId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabName(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convTabCheckResult.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convTabCheckResult.TabName);
objvTabCheckResultEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.TabName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.TabName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.TabName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabCnName(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabCheckResult.TabCnName);
objvTabCheckResultEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.TabCnName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.TabCnName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.TabCnName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetFldName(this clsvTabCheckResultEN objvTabCheckResultEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convTabCheckResult.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convTabCheckResult.FldName);
objvTabCheckResultEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.FldName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.FldName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.FldName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "intErrorLevelId">错误等级Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetErrorLevelId(this clsvTabCheckResultEN objvTabCheckResultEN, int intErrorLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intErrorLevelId, convTabCheckResult.ErrorLevelId);
objvTabCheckResultEN.ErrorLevelId = intErrorLevelId; //错误等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.ErrorLevelId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.ErrorLevelId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.ErrorLevelId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrorLevelName">错误等级名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetErrorLevelName(this clsvTabCheckResultEN objvTabCheckResultEN, string strErrorLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrorLevelName, convTabCheckResult.ErrorLevelName);
clsCheckSql.CheckFieldLen(strErrorLevelName, 50, convTabCheckResult.ErrorLevelName);
objvTabCheckResultEN.ErrorLevelName = strErrorLevelName; //错误等级名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.ErrorLevelName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.ErrorLevelName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.ErrorLevelName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrorMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetErrorMsg(this clsvTabCheckResultEN objvTabCheckResultEN, string strErrorMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrorMsg, convTabCheckResult.ErrorMsg);
clsCheckSql.CheckFieldLen(strErrorMsg, 5000, convTabCheckResult.ErrorMsg);
objvTabCheckResultEN.ErrorMsg = strErrorMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.ErrorMsg) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.ErrorMsg, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.ErrorMsg] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strCheckDate">检查日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetCheckDate(this clsvTabCheckResultEN objvTabCheckResultEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCheckDate, convTabCheckResult.CheckDate);
clsCheckSql.CheckFieldLen(strCheckDate, 20, convTabCheckResult.CheckDate);
objvTabCheckResultEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.CheckDate) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.CheckDate, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.CheckDate] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strCheckUser">检查人</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetCheckUser(this clsvTabCheckResultEN objvTabCheckResultEN, string strCheckUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCheckUser, convTabCheckResult.CheckUser);
clsCheckSql.CheckFieldLen(strCheckUser, 20, convTabCheckResult.CheckUser);
objvTabCheckResultEN.CheckUser = strCheckUser; //检查人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.CheckUser) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.CheckUser, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.CheckUser] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetMemo(this clsvTabCheckResultEN objvTabCheckResultEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabCheckResult.Memo);
objvTabCheckResultEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.Memo) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.Memo, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.Memo] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetSqlDsTypeId(this clsvTabCheckResultEN objvTabCheckResultEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convTabCheckResult.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convTabCheckResult.SqlDsTypeId);
objvTabCheckResultEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.SqlDsTypeId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.SqlDsTypeId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.SqlDsTypeId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetSqlDsTypeName(this clsvTabCheckResultEN objvTabCheckResultEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convTabCheckResult.SqlDsTypeName);
objvTabCheckResultEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.SqlDsTypeName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.SqlDsTypeName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.SqlDsTypeName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetDataBaseName(this clsvTabCheckResultEN objvTabCheckResultEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convTabCheckResult.DataBaseName);
objvTabCheckResultEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.DataBaseName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.DataBaseName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.DataBaseName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetFuncModuleAgcId(this clsvTabCheckResultEN objvTabCheckResultEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convTabCheckResult.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convTabCheckResult.FuncModuleAgcId);
objvTabCheckResultEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.FuncModuleAgcId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.FuncModuleAgcId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.FuncModuleAgcId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetFuncModuleName(this clsvTabCheckResultEN objvTabCheckResultEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTabCheckResult.FuncModuleName);
objvTabCheckResultEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.FuncModuleName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.FuncModuleName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.FuncModuleName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCheckErrorTypeId">表检查错误类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabCheckErrorTypeId(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabCheckErrorTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCheckErrorTypeId, convTabCheckResult.TabCheckErrorTypeId);
clsCheckSql.CheckFieldLen(strTabCheckErrorTypeId, 2, convTabCheckResult.TabCheckErrorTypeId);
clsCheckSql.CheckFieldForeignKey(strTabCheckErrorTypeId, 2, convTabCheckResult.TabCheckErrorTypeId);
objvTabCheckResultEN.TabCheckErrorTypeId = strTabCheckErrorTypeId; //表检查错误类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.TabCheckErrorTypeId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.TabCheckErrorTypeId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.TabCheckErrorTypeId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCheckErrorTypeName">表检查错误类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabCheckErrorTypeName(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabCheckErrorTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCheckErrorTypeName, convTabCheckResult.TabCheckErrorTypeName);
clsCheckSql.CheckFieldLen(strTabCheckErrorTypeName, 30, convTabCheckResult.TabCheckErrorTypeName);
objvTabCheckResultEN.TabCheckErrorTypeName = strTabCheckErrorTypeName; //表检查错误类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.TabCheckErrorTypeName) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.TabCheckErrorTypeName, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.TabCheckErrorTypeName] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabStateId(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convTabCheckResult.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convTabCheckResult.TabStateId);
objvTabCheckResultEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.TabStateId) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.TabStateId, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.TabStateId] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetOrderNum4Refer(this clsvTabCheckResultEN objvTabCheckResultEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objvTabCheckResultEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabCheckResultEN.dicFldComparisonOp.ContainsKey(convTabCheckResult.OrderNum4Refer) == false)
{
objvTabCheckResultEN.dicFldComparisonOp.Add(convTabCheckResult.OrderNum4Refer, strComparisonOp);
}
else
{
objvTabCheckResultEN.dicFldComparisonOp[convTabCheckResult.OrderNum4Refer] = strComparisonOp;
}
}
return objvTabCheckResultEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTabCheckResultEN objvTabCheckResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.mId) == true)
{
string strComparisonOpmId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convTabCheckResult.mId, objvTabCheckResultCond.mId, strComparisonOpmId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.PrjId) == true)
{
string strComparisonOpPrjId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.PrjId, objvTabCheckResultCond.PrjId, strComparisonOpPrjId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.FldId) == true)
{
string strComparisonOpFldId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.FldId, objvTabCheckResultCond.FldId, strComparisonOpFldId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.PrjName) == true)
{
string strComparisonOpPrjName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.PrjName, objvTabCheckResultCond.PrjName, strComparisonOpPrjName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.PrjDataBaseName, objvTabCheckResultCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.PrjDataBaseId, objvTabCheckResultCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.TabId) == true)
{
string strComparisonOpTabId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.TabId, objvTabCheckResultCond.TabId, strComparisonOpTabId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.TabName) == true)
{
string strComparisonOpTabName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.TabName, objvTabCheckResultCond.TabName, strComparisonOpTabName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.TabCnName) == true)
{
string strComparisonOpTabCnName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.TabCnName, objvTabCheckResultCond.TabCnName, strComparisonOpTabCnName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.FldName) == true)
{
string strComparisonOpFldName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.FldName, objvTabCheckResultCond.FldName, strComparisonOpFldName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.ErrorLevelId) == true)
{
string strComparisonOpErrorLevelId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.ErrorLevelId];
strWhereCond += string.Format(" And {0} {2} {1}", convTabCheckResult.ErrorLevelId, objvTabCheckResultCond.ErrorLevelId, strComparisonOpErrorLevelId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.ErrorLevelName) == true)
{
string strComparisonOpErrorLevelName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.ErrorLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.ErrorLevelName, objvTabCheckResultCond.ErrorLevelName, strComparisonOpErrorLevelName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.ErrorMsg) == true)
{
string strComparisonOpErrorMsg = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.ErrorMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.ErrorMsg, objvTabCheckResultCond.ErrorMsg, strComparisonOpErrorMsg);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.CheckDate) == true)
{
string strComparisonOpCheckDate = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.CheckDate, objvTabCheckResultCond.CheckDate, strComparisonOpCheckDate);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.CheckUser) == true)
{
string strComparisonOpCheckUser = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.CheckUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.CheckUser, objvTabCheckResultCond.CheckUser, strComparisonOpCheckUser);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.Memo) == true)
{
string strComparisonOpMemo = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.Memo, objvTabCheckResultCond.Memo, strComparisonOpMemo);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.SqlDsTypeId, objvTabCheckResultCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.SqlDsTypeName, objvTabCheckResultCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.DataBaseName, objvTabCheckResultCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.FuncModuleAgcId, objvTabCheckResultCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.FuncModuleName, objvTabCheckResultCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.TabCheckErrorTypeId) == true)
{
string strComparisonOpTabCheckErrorTypeId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.TabCheckErrorTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.TabCheckErrorTypeId, objvTabCheckResultCond.TabCheckErrorTypeId, strComparisonOpTabCheckErrorTypeId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.TabCheckErrorTypeName) == true)
{
string strComparisonOpTabCheckErrorTypeName = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.TabCheckErrorTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.TabCheckErrorTypeName, objvTabCheckResultCond.TabCheckErrorTypeName, strComparisonOpTabCheckErrorTypeName);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.TabStateId) == true)
{
string strComparisonOpTabStateId = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabCheckResult.TabStateId, objvTabCheckResultCond.TabStateId, strComparisonOpTabStateId);
}
if (objvTabCheckResultCond.IsUpdated(convTabCheckResult.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvTabCheckResultCond.dicFldComparisonOp[convTabCheckResult.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convTabCheckResult.OrderNum4Refer, objvTabCheckResultCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v表检查结果(vTabCheckResult)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTabCheckResultWApi
{
private static readonly string mstrApiControllerName = "vTabCheckResultApi";

 public clsvTabCheckResultWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabCheckResultEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvTabCheckResultEN objvTabCheckResultEN;
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
objvTabCheckResultEN = JsonConvert.DeserializeObject<clsvTabCheckResultEN>(strJson);
return objvTabCheckResultEN;
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
public static clsvTabCheckResultEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvTabCheckResultEN objvTabCheckResultEN;
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
objvTabCheckResultEN = JsonConvert.DeserializeObject<clsvTabCheckResultEN>(strJson);
return objvTabCheckResultEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabCheckResultEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTabCheckResultEN._CurrTabName);
List<clsvTabCheckResultEN> arrvTabCheckResultObjLstCache = GetObjLstCache();
IEnumerable <clsvTabCheckResultEN> arrvTabCheckResultObjLst_Sel =
from objvTabCheckResultEN in arrvTabCheckResultObjLstCache
where objvTabCheckResultEN.mId == lngmId 
select objvTabCheckResultEN;
if (arrvTabCheckResultObjLst_Sel.Count() == 0)
{
   clsvTabCheckResultEN obj = clsvTabCheckResultWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTabCheckResultObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckResultEN> GetObjLst(string strWhereCond)
{
 List<clsvTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckResultEN>>(strJson);
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
public static List<clsvTabCheckResultEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckResultEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvTabCheckResultEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTabCheckResultEN._CurrTabName);
List<clsvTabCheckResultEN> arrvTabCheckResultObjLstCache = GetObjLstCache();
IEnumerable <clsvTabCheckResultEN> arrvTabCheckResultObjLst_Sel =
from objvTabCheckResultEN in arrvTabCheckResultObjLstCache
where arrMId.Contains(objvTabCheckResultEN.mId)
select objvTabCheckResultEN;
return arrvTabCheckResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckResultEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckResultEN>>(strJson);
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
public static List<clsvTabCheckResultEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckResultEN>>(strJson);
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
public static List<clsvTabCheckResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckResultEN>>(strJson);
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
public static List<clsvTabCheckResultEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabCheckResultEN>>(strJson);
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
 /// <param name = "objvTabCheckResultENS">源对象</param>
 /// <param name = "objvTabCheckResultENT">目标对象</param>
 public static void CopyTo(clsvTabCheckResultEN objvTabCheckResultENS, clsvTabCheckResultEN objvTabCheckResultENT)
{
try
{
objvTabCheckResultENT.mId = objvTabCheckResultENS.mId; //mId
objvTabCheckResultENT.PrjId = objvTabCheckResultENS.PrjId; //工程Id
objvTabCheckResultENT.FldId = objvTabCheckResultENS.FldId; //字段Id
objvTabCheckResultENT.PrjName = objvTabCheckResultENS.PrjName; //工程名称
objvTabCheckResultENT.PrjDataBaseName = objvTabCheckResultENS.PrjDataBaseName; //项目数据库名
objvTabCheckResultENT.PrjDataBaseId = objvTabCheckResultENS.PrjDataBaseId; //项目数据库Id
objvTabCheckResultENT.TabId = objvTabCheckResultENS.TabId; //表ID
objvTabCheckResultENT.TabName = objvTabCheckResultENS.TabName; //表名
objvTabCheckResultENT.TabCnName = objvTabCheckResultENS.TabCnName; //表中文名
objvTabCheckResultENT.FldName = objvTabCheckResultENS.FldName; //字段名
objvTabCheckResultENT.ErrorLevelId = objvTabCheckResultENS.ErrorLevelId; //错误等级Id
objvTabCheckResultENT.ErrorLevelName = objvTabCheckResultENS.ErrorLevelName; //错误等级名
objvTabCheckResultENT.ErrorMsg = objvTabCheckResultENS.ErrorMsg; //错误信息
objvTabCheckResultENT.CheckDate = objvTabCheckResultENS.CheckDate; //检查日期
objvTabCheckResultENT.CheckUser = objvTabCheckResultENS.CheckUser; //检查人
objvTabCheckResultENT.Memo = objvTabCheckResultENS.Memo; //说明
objvTabCheckResultENT.SqlDsTypeId = objvTabCheckResultENS.SqlDsTypeId; //数据源类型Id
objvTabCheckResultENT.SqlDsTypeName = objvTabCheckResultENS.SqlDsTypeName; //Sql数据源名
objvTabCheckResultENT.DataBaseName = objvTabCheckResultENS.DataBaseName; //数据库名
objvTabCheckResultENT.FuncModuleAgcId = objvTabCheckResultENS.FuncModuleAgcId; //功能模块Id
objvTabCheckResultENT.FuncModuleName = objvTabCheckResultENS.FuncModuleName; //功能模块名称
objvTabCheckResultENT.TabCheckErrorTypeId = objvTabCheckResultENS.TabCheckErrorTypeId; //表检查错误类型Id
objvTabCheckResultENT.TabCheckErrorTypeName = objvTabCheckResultENS.TabCheckErrorTypeName; //表检查错误类型名
objvTabCheckResultENT.TabStateId = objvTabCheckResultENS.TabStateId; //表状态ID
objvTabCheckResultENT.OrderNum4Refer = objvTabCheckResultENS.OrderNum4Refer; //引用序号
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
public static DataTable ToDataTable(List<clsvTabCheckResultEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTabCheckResultEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTabCheckResultEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTabCheckResultEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTabCheckResultEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTabCheckResultEN._AttributeName)
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
string strKey = string.Format("{0}", clsvTabCheckResultEN._CurrTabName);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabCheckResultEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvTabCheckResultEN._CurrTabName;
List<clsvTabCheckResultEN> arrvTabCheckResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvTabCheckResultObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTabCheckResultEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTabCheckResult.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convTabCheckResult.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.PrjDataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.ErrorLevelId, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabCheckResult.ErrorLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.ErrorMsg, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.CheckDate, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.CheckUser, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.TabCheckErrorTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.TabCheckErrorTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(convTabCheckResult.OrderNum4Refer, Type.GetType("System.Int32"));
foreach (clsvTabCheckResultEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTabCheckResult.mId] = objInFor[convTabCheckResult.mId];
objDR[convTabCheckResult.PrjId] = objInFor[convTabCheckResult.PrjId];
objDR[convTabCheckResult.FldId] = objInFor[convTabCheckResult.FldId];
objDR[convTabCheckResult.PrjName] = objInFor[convTabCheckResult.PrjName];
objDR[convTabCheckResult.PrjDataBaseName] = objInFor[convTabCheckResult.PrjDataBaseName];
objDR[convTabCheckResult.PrjDataBaseId] = objInFor[convTabCheckResult.PrjDataBaseId];
objDR[convTabCheckResult.TabId] = objInFor[convTabCheckResult.TabId];
objDR[convTabCheckResult.TabName] = objInFor[convTabCheckResult.TabName];
objDR[convTabCheckResult.TabCnName] = objInFor[convTabCheckResult.TabCnName];
objDR[convTabCheckResult.FldName] = objInFor[convTabCheckResult.FldName];
objDR[convTabCheckResult.ErrorLevelId] = objInFor[convTabCheckResult.ErrorLevelId];
objDR[convTabCheckResult.ErrorLevelName] = objInFor[convTabCheckResult.ErrorLevelName];
objDR[convTabCheckResult.ErrorMsg] = objInFor[convTabCheckResult.ErrorMsg];
objDR[convTabCheckResult.CheckDate] = objInFor[convTabCheckResult.CheckDate];
objDR[convTabCheckResult.CheckUser] = objInFor[convTabCheckResult.CheckUser];
objDR[convTabCheckResult.Memo] = objInFor[convTabCheckResult.Memo];
objDR[convTabCheckResult.SqlDsTypeId] = objInFor[convTabCheckResult.SqlDsTypeId];
objDR[convTabCheckResult.SqlDsTypeName] = objInFor[convTabCheckResult.SqlDsTypeName];
objDR[convTabCheckResult.DataBaseName] = objInFor[convTabCheckResult.DataBaseName];
objDR[convTabCheckResult.FuncModuleAgcId] = objInFor[convTabCheckResult.FuncModuleAgcId];
objDR[convTabCheckResult.FuncModuleName] = objInFor[convTabCheckResult.FuncModuleName];
objDR[convTabCheckResult.TabCheckErrorTypeId] = objInFor[convTabCheckResult.TabCheckErrorTypeId];
objDR[convTabCheckResult.TabCheckErrorTypeName] = objInFor[convTabCheckResult.TabCheckErrorTypeName];
objDR[convTabCheckResult.TabStateId] = objInFor[convTabCheckResult.TabStateId];
objDR[convTabCheckResult.OrderNum4Refer] = objInFor[convTabCheckResult.OrderNum4Refer];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}