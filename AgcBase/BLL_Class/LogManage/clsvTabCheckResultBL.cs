
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabCheckResultBL
 表名:vTabCheckResult(00050191)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsvTabCheckResultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabCheckResultEN GetObj(this K_mId_vTabCheckResult myKey)
{
clsvTabCheckResultEN objvTabCheckResultEN = clsvTabCheckResultBL.vTabCheckResultDA.GetObjBymId(myKey.Value);
return objvTabCheckResultEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetPrjId(this clsvTabCheckResultEN objvTabCheckResultEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTabCheckResult.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabCheckResult.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabCheckResult.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetFldId(this clsvTabCheckResultEN objvTabCheckResultEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convTabCheckResult.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convTabCheckResult.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convTabCheckResult.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetPrjName(this clsvTabCheckResultEN objvTabCheckResultEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convTabCheckResult.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convTabCheckResult.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetPrjDataBaseName(this clsvTabCheckResultEN objvTabCheckResultEN, string strPrjDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convTabCheckResult.PrjDataBaseName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetPrjDataBaseId(this clsvTabCheckResultEN objvTabCheckResultEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convTabCheckResult.PrjDataBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convTabCheckResult.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convTabCheckResult.PrjDataBaseId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabId(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabCheckResult.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convTabCheckResult.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabCheckResult.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabName(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convTabCheckResult.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convTabCheckResult.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabCnName(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabCheckResult.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetFldName(this clsvTabCheckResultEN objvTabCheckResultEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convTabCheckResult.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convTabCheckResult.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetErrorLevelName(this clsvTabCheckResultEN objvTabCheckResultEN, string strErrorLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrorLevelName, convTabCheckResult.ErrorLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrorLevelName, 50, convTabCheckResult.ErrorLevelName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetErrorMsg(this clsvTabCheckResultEN objvTabCheckResultEN, string strErrorMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrorMsg, convTabCheckResult.ErrorMsg);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrorMsg, 5000, convTabCheckResult.ErrorMsg);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetCheckDate(this clsvTabCheckResultEN objvTabCheckResultEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCheckDate, convTabCheckResult.CheckDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDate, 20, convTabCheckResult.CheckDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetCheckUser(this clsvTabCheckResultEN objvTabCheckResultEN, string strCheckUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCheckUser, convTabCheckResult.CheckUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckUser, 20, convTabCheckResult.CheckUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetMemo(this clsvTabCheckResultEN objvTabCheckResultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabCheckResult.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetSqlDsTypeId(this clsvTabCheckResultEN objvTabCheckResultEN, string strSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convTabCheckResult.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convTabCheckResult.SqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetSqlDsTypeName(this clsvTabCheckResultEN objvTabCheckResultEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convTabCheckResult.SqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetDataBaseName(this clsvTabCheckResultEN objvTabCheckResultEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convTabCheckResult.DataBaseName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetFuncModuleAgcId(this clsvTabCheckResultEN objvTabCheckResultEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convTabCheckResult.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convTabCheckResult.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetFuncModuleName(this clsvTabCheckResultEN objvTabCheckResultEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTabCheckResult.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabCheckErrorTypeId(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabCheckErrorTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCheckErrorTypeId, convTabCheckResult.TabCheckErrorTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCheckErrorTypeId, 2, convTabCheckResult.TabCheckErrorTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabCheckErrorTypeId, 2, convTabCheckResult.TabCheckErrorTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabCheckErrorTypeName(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabCheckErrorTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCheckErrorTypeName, convTabCheckResult.TabCheckErrorTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCheckErrorTypeName, 30, convTabCheckResult.TabCheckErrorTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetTabStateId(this clsvTabCheckResultEN objvTabCheckResultEN, string strTabStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convTabCheckResult.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convTabCheckResult.TabStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabCheckResultEN SetOrderNum4Refer(this clsvTabCheckResultEN objvTabCheckResultEN, int? intOrderNum4Refer, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTabCheckResultENS">源对象</param>
 /// <param name = "objvTabCheckResultENT">目标对象</param>
 public static void CopyTo(this clsvTabCheckResultEN objvTabCheckResultENS, clsvTabCheckResultEN objvTabCheckResultENT)
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
 /// <param name = "objvTabCheckResultENS">源对象</param>
 /// <returns>目标对象=>clsvTabCheckResultEN:objvTabCheckResultENT</returns>
 public static clsvTabCheckResultEN CopyTo(this clsvTabCheckResultEN objvTabCheckResultENS)
{
try
{
 clsvTabCheckResultEN objvTabCheckResultENT = new clsvTabCheckResultEN()
{
mId = objvTabCheckResultENS.mId, //mId
PrjId = objvTabCheckResultENS.PrjId, //工程Id
FldId = objvTabCheckResultENS.FldId, //字段Id
PrjName = objvTabCheckResultENS.PrjName, //工程名称
PrjDataBaseName = objvTabCheckResultENS.PrjDataBaseName, //项目数据库名
PrjDataBaseId = objvTabCheckResultENS.PrjDataBaseId, //项目数据库Id
TabId = objvTabCheckResultENS.TabId, //表ID
TabName = objvTabCheckResultENS.TabName, //表名
TabCnName = objvTabCheckResultENS.TabCnName, //表中文名
FldName = objvTabCheckResultENS.FldName, //字段名
ErrorLevelId = objvTabCheckResultENS.ErrorLevelId, //错误等级Id
ErrorLevelName = objvTabCheckResultENS.ErrorLevelName, //错误等级名
ErrorMsg = objvTabCheckResultENS.ErrorMsg, //错误信息
CheckDate = objvTabCheckResultENS.CheckDate, //检查日期
CheckUser = objvTabCheckResultENS.CheckUser, //检查人
Memo = objvTabCheckResultENS.Memo, //说明
SqlDsTypeId = objvTabCheckResultENS.SqlDsTypeId, //数据源类型Id
SqlDsTypeName = objvTabCheckResultENS.SqlDsTypeName, //Sql数据源名
DataBaseName = objvTabCheckResultENS.DataBaseName, //数据库名
FuncModuleAgcId = objvTabCheckResultENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvTabCheckResultENS.FuncModuleName, //功能模块名称
TabCheckErrorTypeId = objvTabCheckResultENS.TabCheckErrorTypeId, //表检查错误类型Id
TabCheckErrorTypeName = objvTabCheckResultENS.TabCheckErrorTypeName, //表检查错误类型名
TabStateId = objvTabCheckResultENS.TabStateId, //表状态ID
OrderNum4Refer = objvTabCheckResultENS.OrderNum4Refer, //引用序号
};
 return objvTabCheckResultENT;
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
public static void CheckProperty4Condition(this clsvTabCheckResultEN objvTabCheckResultEN)
{
 clsvTabCheckResultBL.vTabCheckResultDA.CheckProperty4Condition(objvTabCheckResultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTabCheckResult
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v表检查结果(vTabCheckResult)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTabCheckResultBL
{
public static RelatedActions_vTabCheckResult relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTabCheckResultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTabCheckResultDA vTabCheckResultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTabCheckResultDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTabCheckResultBL()
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
if (string.IsNullOrEmpty(clsvTabCheckResultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabCheckResultEN._ConnectString);
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
public static DataTable GetDataTable_vTabCheckResult(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabCheckResultDA.GetDataTable_vTabCheckResult(strWhereCond);
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
objDT = vTabCheckResultDA.GetDataTable(strWhereCond);
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
objDT = vTabCheckResultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTabCheckResultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTabCheckResultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTabCheckResultDA.GetDataTable_Top(objTopPara);
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
objDT = vTabCheckResultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTabCheckResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTabCheckResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvTabCheckResultEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
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
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTabCheckResultEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvTabCheckResultEN._CurrTabName);
List<clsvTabCheckResultEN> arrvTabCheckResultObjLstCache = GetObjLstCache();
IEnumerable <clsvTabCheckResultEN> arrvTabCheckResultObjLst_Sel =
arrvTabCheckResultObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvTabCheckResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckResultEN> GetObjLst(string strWhereCond)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
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
public static List<clsvTabCheckResultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTabCheckResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTabCheckResultEN> GetSubObjLstCache(clsvTabCheckResultEN objvTabCheckResultCond)
{
List<clsvTabCheckResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTabCheckResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabCheckResult._AttributeName)
{
if (objvTabCheckResultCond.IsUpdated(strFldName) == false) continue;
if (objvTabCheckResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabCheckResultCond[strFldName].ToString());
}
else
{
if (objvTabCheckResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabCheckResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabCheckResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabCheckResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabCheckResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabCheckResultCond[strFldName]));
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
public static List<clsvTabCheckResultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
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
public static List<clsvTabCheckResultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
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
List<clsvTabCheckResultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTabCheckResultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckResultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTabCheckResultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
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
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
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
public static List<clsvTabCheckResultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabCheckResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTabCheckResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
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
public static List<clsvTabCheckResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabCheckResultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabCheckResultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTabCheckResult(ref clsvTabCheckResultEN objvTabCheckResultEN)
{
bool bolResult = vTabCheckResultDA.GetvTabCheckResult(ref objvTabCheckResultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabCheckResultEN GetObjBymId(long lngmId)
{
clsvTabCheckResultEN objvTabCheckResultEN = vTabCheckResultDA.GetObjBymId(lngmId);
return objvTabCheckResultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTabCheckResultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTabCheckResultEN objvTabCheckResultEN = vTabCheckResultDA.GetFirstObj(strWhereCond);
 return objvTabCheckResultEN;
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
public static clsvTabCheckResultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTabCheckResultEN objvTabCheckResultEN = vTabCheckResultDA.GetObjByDataRow(objRow);
 return objvTabCheckResultEN;
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
public static clsvTabCheckResultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTabCheckResultEN objvTabCheckResultEN = vTabCheckResultDA.GetObjByDataRow(objRow);
 return objvTabCheckResultEN;
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
 /// <param name = "lstvTabCheckResultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabCheckResultEN GetObjBymIdFromList(long lngmId, List<clsvTabCheckResultEN> lstvTabCheckResultObjLst)
{
foreach (clsvTabCheckResultEN objvTabCheckResultEN in lstvTabCheckResultObjLst)
{
if (objvTabCheckResultEN.mId == lngmId)
{
return objvTabCheckResultEN;
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
 lngmId = new clsvTabCheckResultDA().GetFirstID(strWhereCond);
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
 arrList = vTabCheckResultDA.GetID(strWhereCond);
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
bool bolIsExist = vTabCheckResultDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vTabCheckResultDA.IsExist(lngmId);
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
 bolIsExist = clsvTabCheckResultDA.IsExistTable();
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
 bolIsExist = vTabCheckResultDA.IsExistTable(strTabName);
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
 /// <param name = "objvTabCheckResultEN">源简化对象</param>
 public static void SetUpdFlag(clsvTabCheckResultEN objvTabCheckResultEN)
{
try
{
objvTabCheckResultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTabCheckResultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTabCheckResult.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.mId = objvTabCheckResultEN.mId; //mId
}
if (arrFldSet.Contains(convTabCheckResult.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.PrjId = objvTabCheckResultEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convTabCheckResult.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.FldId = objvTabCheckResultEN.FldId; //字段Id
}
if (arrFldSet.Contains(convTabCheckResult.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.PrjName = objvTabCheckResultEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convTabCheckResult.PrjDataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.PrjDataBaseName = objvTabCheckResultEN.PrjDataBaseName == "[null]" ? null :  objvTabCheckResultEN.PrjDataBaseName; //项目数据库名
}
if (arrFldSet.Contains(convTabCheckResult.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.PrjDataBaseId = objvTabCheckResultEN.PrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(convTabCheckResult.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.TabId = objvTabCheckResultEN.TabId; //表ID
}
if (arrFldSet.Contains(convTabCheckResult.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.TabName = objvTabCheckResultEN.TabName; //表名
}
if (arrFldSet.Contains(convTabCheckResult.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.TabCnName = objvTabCheckResultEN.TabCnName == "[null]" ? null :  objvTabCheckResultEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convTabCheckResult.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.FldName = objvTabCheckResultEN.FldName; //字段名
}
if (arrFldSet.Contains(convTabCheckResult.ErrorLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.ErrorLevelId = objvTabCheckResultEN.ErrorLevelId; //错误等级Id
}
if (arrFldSet.Contains(convTabCheckResult.ErrorLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.ErrorLevelName = objvTabCheckResultEN.ErrorLevelName; //错误等级名
}
if (arrFldSet.Contains(convTabCheckResult.ErrorMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.ErrorMsg = objvTabCheckResultEN.ErrorMsg; //错误信息
}
if (arrFldSet.Contains(convTabCheckResult.CheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.CheckDate = objvTabCheckResultEN.CheckDate; //检查日期
}
if (arrFldSet.Contains(convTabCheckResult.CheckUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.CheckUser = objvTabCheckResultEN.CheckUser; //检查人
}
if (arrFldSet.Contains(convTabCheckResult.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.Memo = objvTabCheckResultEN.Memo == "[null]" ? null :  objvTabCheckResultEN.Memo; //说明
}
if (arrFldSet.Contains(convTabCheckResult.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.SqlDsTypeId = objvTabCheckResultEN.SqlDsTypeId == "[null]" ? null :  objvTabCheckResultEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convTabCheckResult.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.SqlDsTypeName = objvTabCheckResultEN.SqlDsTypeName == "[null]" ? null :  objvTabCheckResultEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convTabCheckResult.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.DataBaseName = objvTabCheckResultEN.DataBaseName == "[null]" ? null :  objvTabCheckResultEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(convTabCheckResult.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.FuncModuleAgcId = objvTabCheckResultEN.FuncModuleAgcId == "[null]" ? null :  objvTabCheckResultEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convTabCheckResult.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.FuncModuleName = objvTabCheckResultEN.FuncModuleName == "[null]" ? null :  objvTabCheckResultEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convTabCheckResult.TabCheckErrorTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.TabCheckErrorTypeId = objvTabCheckResultEN.TabCheckErrorTypeId; //表检查错误类型Id
}
if (arrFldSet.Contains(convTabCheckResult.TabCheckErrorTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.TabCheckErrorTypeName = objvTabCheckResultEN.TabCheckErrorTypeName; //表检查错误类型名
}
if (arrFldSet.Contains(convTabCheckResult.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.TabStateId = objvTabCheckResultEN.TabStateId == "[null]" ? null :  objvTabCheckResultEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convTabCheckResult.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabCheckResultEN.OrderNum4Refer = objvTabCheckResultEN.OrderNum4Refer; //引用序号
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
 /// <param name = "objvTabCheckResultEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTabCheckResultEN objvTabCheckResultEN)
{
try
{
if (objvTabCheckResultEN.PrjDataBaseName == "[null]") objvTabCheckResultEN.PrjDataBaseName = null; //项目数据库名
if (objvTabCheckResultEN.TabCnName == "[null]") objvTabCheckResultEN.TabCnName = null; //表中文名
if (objvTabCheckResultEN.Memo == "[null]") objvTabCheckResultEN.Memo = null; //说明
if (objvTabCheckResultEN.SqlDsTypeId == "[null]") objvTabCheckResultEN.SqlDsTypeId = null; //数据源类型Id
if (objvTabCheckResultEN.SqlDsTypeName == "[null]") objvTabCheckResultEN.SqlDsTypeName = null; //Sql数据源名
if (objvTabCheckResultEN.DataBaseName == "[null]") objvTabCheckResultEN.DataBaseName = null; //数据库名
if (objvTabCheckResultEN.FuncModuleAgcId == "[null]") objvTabCheckResultEN.FuncModuleAgcId = null; //功能模块Id
if (objvTabCheckResultEN.FuncModuleName == "[null]") objvTabCheckResultEN.FuncModuleName = null; //功能模块名称
if (objvTabCheckResultEN.TabStateId == "[null]") objvTabCheckResultEN.TabStateId = null; //表状态ID
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
public static void CheckProperty4Condition(clsvTabCheckResultEN objvTabCheckResultEN)
{
 vTabCheckResultDA.CheckProperty4Condition(objvTabCheckResultEN);
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
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjDataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjDataBaseBL没有刷新缓存机制(clsPrjDataBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabCheckResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabCheckResultBL没有刷新缓存机制(clsTabCheckResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsErrorLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsErrorLevelBL没有刷新缓存机制(clsErrorLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabCheckErrorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabCheckErrorTypeBL没有刷新缓存机制(clsTabCheckErrorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabStateBL没有刷新缓存机制(clsTabStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabTypeBL没有刷新缓存机制(clsTabTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabMainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabMainTypeBL没有刷新缓存机制(clsTabMainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSoftStructureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSoftStructureBL没有刷新缓存机制(clsSoftStructureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvTabCheckResultObjLstCache == null)
//{
//arrvTabCheckResultObjLstCache = vTabCheckResultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabCheckResultEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTabCheckResultEN._CurrTabName);
List<clsvTabCheckResultEN> arrvTabCheckResultObjLstCache = GetObjLstCache();
IEnumerable <clsvTabCheckResultEN> arrvTabCheckResultObjLst_Sel =
arrvTabCheckResultObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvTabCheckResultObjLst_Sel.Count() == 0)
{
   clsvTabCheckResultEN obj = clsvTabCheckResultBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTabCheckResultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabCheckResultEN> GetAllvTabCheckResultObjLstCache()
{
//获取缓存中的对象列表
List<clsvTabCheckResultEN> arrvTabCheckResultObjLstCache = GetObjLstCache(); 
return arrvTabCheckResultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabCheckResultEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTabCheckResultEN._CurrTabName);
List<clsvTabCheckResultEN> arrvTabCheckResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTabCheckResultObjLstCache;
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
string strKey = string.Format("{0}", clsvTabCheckResultEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvTabCheckResultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvTabCheckResultEN._RefreshTimeLst.Count == 0) return "";
return clsvTabCheckResultEN._RefreshTimeLst[clsvTabCheckResultEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convTabCheckResult.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTabCheckResult._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTabCheckResult._AttributeName));
throw new Exception(strMsg);
}
var objvTabCheckResult = clsvTabCheckResultBL.GetObjBymIdCache(lngmId);
if (objvTabCheckResult == null) return "";
return objvTabCheckResult[strOutFldName].ToString();
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
int intRecCount = clsvTabCheckResultDA.GetRecCount(strTabName);
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
int intRecCount = clsvTabCheckResultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTabCheckResultDA.GetRecCount();
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
int intRecCount = clsvTabCheckResultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTabCheckResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTabCheckResultEN objvTabCheckResultCond)
{
List<clsvTabCheckResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTabCheckResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabCheckResult._AttributeName)
{
if (objvTabCheckResultCond.IsUpdated(strFldName) == false) continue;
if (objvTabCheckResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabCheckResultCond[strFldName].ToString());
}
else
{
if (objvTabCheckResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabCheckResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabCheckResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabCheckResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabCheckResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabCheckResultCond[strFldName]));
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
 List<string> arrList = clsvTabCheckResultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTabCheckResultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTabCheckResultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}