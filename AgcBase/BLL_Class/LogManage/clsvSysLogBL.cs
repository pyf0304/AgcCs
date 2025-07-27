
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysLogBL
 表名:vSysLog(00050262)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class clsvSysLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysLogEN GetObj(this K_mId_vSysLog myKey)
{
clsvSysLogEN objvSysLogEN = clsvSysLogBL.vSysLogDA.GetObjBymId(myKey.Value);
return objvSysLogEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetmId(this clsvSysLogEN objvSysLogEN, long lngmId, string strComparisonOp="")
	{
objvSysLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.mId) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.mId, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.mId] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetUserName(this clsvSysLogEN objvSysLogEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convSysLog.UserName);
}
objvSysLogEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.UserName) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.UserName, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.UserName] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetLoginTime(this clsvSysLogEN objvSysLogEN, string strLoginTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginTime, 6, convSysLog.LoginTime);
}
objvSysLogEN.LoginTime = strLoginTime; //登陆时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.LoginTime) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.LoginTime, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.LoginTime] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetLoginDate(this clsvSysLogEN objvSysLogEN, string strLoginDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginDate, 8, convSysLog.LoginDate);
}
objvSysLogEN.LoginDate = strLoginDate; //登陆日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.LoginDate) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.LoginDate, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.LoginDate] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetPrjName(this clsvSysLogEN objvSysLogEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convSysLog.PrjName);
}
objvSysLogEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.PrjName) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.PrjName, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.PrjName] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetTableName(this clsvSysLogEN objvSysLogEN, string strTableName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableName, 100, convSysLog.TableName);
}
objvSysLogEN.TableName = strTableName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.TableName) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.TableName, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.TableName] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetTableKey(this clsvSysLogEN objvSysLogEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 100, convSysLog.TableKey);
}
objvSysLogEN.TableKey = strTableKey; //数据表关键字值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.TableKey) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.TableKey, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.TableKey] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpTypeName(this clsvSysLogEN objvSysLogEN, string strOpTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpTypeName, 100, convSysLog.OpTypeName);
}
objvSysLogEN.OpTypeName = strOpTypeName; //操作类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.OpTypeName) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.OpTypeName, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.OpTypeName] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetUserIp(this clsvSysLogEN objvSysLogEN, string strUserIp, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserIp, 40, convSysLog.UserIp);
}
objvSysLogEN.UserIp = strUserIp; //用户IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.UserIp) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.UserIp, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.UserIp] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpTypeId(this clsvSysLogEN objvSysLogEN, string strOpTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOpTypeId, convSysLog.OpTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpTypeId, 4, convSysLog.OpTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOpTypeId, 4, convSysLog.OpTypeId);
}
objvSysLogEN.OpTypeId = strOpTypeId; //操作类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.OpTypeId) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.OpTypeId, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.OpTypeId] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpContent(this clsvSysLogEN objvSysLogEN, string strOpContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpContent, 1000, convSysLog.OpContent);
}
objvSysLogEN.OpContent = strOpContent; //操作内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.OpContent) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.OpContent, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.OpContent] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpDate(this clsvSysLogEN objvSysLogEN, string strOpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpDate, 8, convSysLog.OpDate);
}
objvSysLogEN.OpDate = strOpDate; //操作日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.OpDate) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.OpDate, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.OpDate] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetPrjId(this clsvSysLogEN objvSysLogEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convSysLog.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSysLog.PrjId);
}
objvSysLogEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.PrjId) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.PrjId, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.PrjId] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpTime(this clsvSysLogEN objvSysLogEN, string strOpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpTime, 6, convSysLog.OpTime);
}
objvSysLogEN.OpTime = strOpTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.OpTime) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.OpTime, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.OpTime] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetUserId(this clsvSysLogEN objvSysLogEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convSysLog.UserId);
}
objvSysLogEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.UserId) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.UserId, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.UserId] = strComparisonOp;
}
}
return objvSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetMemo(this clsvSysLogEN objvSysLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysLog.Memo);
}
objvSysLogEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysLogEN.dicFldComparisonOp.ContainsKey(convSysLog.Memo) == false)
{
objvSysLogEN.dicFldComparisonOp.Add(convSysLog.Memo, strComparisonOp);
}
else
{
objvSysLogEN.dicFldComparisonOp[convSysLog.Memo] = strComparisonOp;
}
}
return objvSysLogEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSysLogENS">源对象</param>
 /// <param name = "objvSysLogENT">目标对象</param>
 public static void CopyTo(this clsvSysLogEN objvSysLogENS, clsvSysLogEN objvSysLogENT)
{
try
{
objvSysLogENT.mId = objvSysLogENS.mId; //mId
objvSysLogENT.UserName = objvSysLogENS.UserName; //用户名
objvSysLogENT.LoginTime = objvSysLogENS.LoginTime; //登陆时间
objvSysLogENT.LoginDate = objvSysLogENS.LoginDate; //登陆日期
objvSysLogENT.PrjName = objvSysLogENS.PrjName; //工程名称
objvSysLogENT.TableName = objvSysLogENS.TableName; //表名
objvSysLogENT.TableKey = objvSysLogENS.TableKey; //数据表关键字值
objvSysLogENT.OpTypeName = objvSysLogENS.OpTypeName; //操作类型名称
objvSysLogENT.UserIp = objvSysLogENS.UserIp; //用户IP
objvSysLogENT.OpTypeId = objvSysLogENS.OpTypeId; //操作类型Id
objvSysLogENT.OpContent = objvSysLogENS.OpContent; //操作内容
objvSysLogENT.OpDate = objvSysLogENS.OpDate; //操作日期
objvSysLogENT.PrjId = objvSysLogENS.PrjId; //工程ID
objvSysLogENT.OpTime = objvSysLogENS.OpTime; //操作时间
objvSysLogENT.UserId = objvSysLogENS.UserId; //用户Id
objvSysLogENT.Memo = objvSysLogENS.Memo; //说明
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
 /// <param name = "objvSysLogENS">源对象</param>
 /// <returns>目标对象=>clsvSysLogEN:objvSysLogENT</returns>
 public static clsvSysLogEN CopyTo(this clsvSysLogEN objvSysLogENS)
{
try
{
 clsvSysLogEN objvSysLogENT = new clsvSysLogEN()
{
mId = objvSysLogENS.mId, //mId
UserName = objvSysLogENS.UserName, //用户名
LoginTime = objvSysLogENS.LoginTime, //登陆时间
LoginDate = objvSysLogENS.LoginDate, //登陆日期
PrjName = objvSysLogENS.PrjName, //工程名称
TableName = objvSysLogENS.TableName, //表名
TableKey = objvSysLogENS.TableKey, //数据表关键字值
OpTypeName = objvSysLogENS.OpTypeName, //操作类型名称
UserIp = objvSysLogENS.UserIp, //用户IP
OpTypeId = objvSysLogENS.OpTypeId, //操作类型Id
OpContent = objvSysLogENS.OpContent, //操作内容
OpDate = objvSysLogENS.OpDate, //操作日期
PrjId = objvSysLogENS.PrjId, //工程ID
OpTime = objvSysLogENS.OpTime, //操作时间
UserId = objvSysLogENS.UserId, //用户Id
Memo = objvSysLogENS.Memo, //说明
};
 return objvSysLogENT;
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
public static void CheckProperty4Condition(this clsvSysLogEN objvSysLogEN)
{
 clsvSysLogBL.vSysLogDA.CheckProperty4Condition(objvSysLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysLogEN objvSysLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysLogCond.IsUpdated(convSysLog.mId) == true)
{
string strComparisonOpmId = objvSysLogCond.dicFldComparisonOp[convSysLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convSysLog.mId, objvSysLogCond.mId, strComparisonOpmId);
}
if (objvSysLogCond.IsUpdated(convSysLog.UserName) == true)
{
string strComparisonOpUserName = objvSysLogCond.dicFldComparisonOp[convSysLog.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.UserName, objvSysLogCond.UserName, strComparisonOpUserName);
}
if (objvSysLogCond.IsUpdated(convSysLog.LoginTime) == true)
{
string strComparisonOpLoginTime = objvSysLogCond.dicFldComparisonOp[convSysLog.LoginTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.LoginTime, objvSysLogCond.LoginTime, strComparisonOpLoginTime);
}
if (objvSysLogCond.IsUpdated(convSysLog.LoginDate) == true)
{
string strComparisonOpLoginDate = objvSysLogCond.dicFldComparisonOp[convSysLog.LoginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.LoginDate, objvSysLogCond.LoginDate, strComparisonOpLoginDate);
}
if (objvSysLogCond.IsUpdated(convSysLog.PrjName) == true)
{
string strComparisonOpPrjName = objvSysLogCond.dicFldComparisonOp[convSysLog.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.PrjName, objvSysLogCond.PrjName, strComparisonOpPrjName);
}
if (objvSysLogCond.IsUpdated(convSysLog.TableName) == true)
{
string strComparisonOpTableName = objvSysLogCond.dicFldComparisonOp[convSysLog.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.TableName, objvSysLogCond.TableName, strComparisonOpTableName);
}
if (objvSysLogCond.IsUpdated(convSysLog.TableKey) == true)
{
string strComparisonOpTableKey = objvSysLogCond.dicFldComparisonOp[convSysLog.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.TableKey, objvSysLogCond.TableKey, strComparisonOpTableKey);
}
if (objvSysLogCond.IsUpdated(convSysLog.OpTypeName) == true)
{
string strComparisonOpOpTypeName = objvSysLogCond.dicFldComparisonOp[convSysLog.OpTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpTypeName, objvSysLogCond.OpTypeName, strComparisonOpOpTypeName);
}
if (objvSysLogCond.IsUpdated(convSysLog.UserIp) == true)
{
string strComparisonOpUserIp = objvSysLogCond.dicFldComparisonOp[convSysLog.UserIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.UserIp, objvSysLogCond.UserIp, strComparisonOpUserIp);
}
if (objvSysLogCond.IsUpdated(convSysLog.OpTypeId) == true)
{
string strComparisonOpOpTypeId = objvSysLogCond.dicFldComparisonOp[convSysLog.OpTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpTypeId, objvSysLogCond.OpTypeId, strComparisonOpOpTypeId);
}
if (objvSysLogCond.IsUpdated(convSysLog.OpContent) == true)
{
string strComparisonOpOpContent = objvSysLogCond.dicFldComparisonOp[convSysLog.OpContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpContent, objvSysLogCond.OpContent, strComparisonOpOpContent);
}
if (objvSysLogCond.IsUpdated(convSysLog.OpDate) == true)
{
string strComparisonOpOpDate = objvSysLogCond.dicFldComparisonOp[convSysLog.OpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpDate, objvSysLogCond.OpDate, strComparisonOpOpDate);
}
if (objvSysLogCond.IsUpdated(convSysLog.PrjId) == true)
{
string strComparisonOpPrjId = objvSysLogCond.dicFldComparisonOp[convSysLog.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.PrjId, objvSysLogCond.PrjId, strComparisonOpPrjId);
}
if (objvSysLogCond.IsUpdated(convSysLog.OpTime) == true)
{
string strComparisonOpOpTime = objvSysLogCond.dicFldComparisonOp[convSysLog.OpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpTime, objvSysLogCond.OpTime, strComparisonOpOpTime);
}
if (objvSysLogCond.IsUpdated(convSysLog.UserId) == true)
{
string strComparisonOpUserId = objvSysLogCond.dicFldComparisonOp[convSysLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.UserId, objvSysLogCond.UserId, strComparisonOpUserId);
}
if (objvSysLogCond.IsUpdated(convSysLog.Memo) == true)
{
string strComparisonOpMemo = objvSysLogCond.dicFldComparisonOp[convSysLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.Memo, objvSysLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSysLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v系统日志(vSysLog)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSysLogBL
{
public static RelatedActions_vSysLog relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vSysLogListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vSysLogList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvSysLogEN> arrvSysLogObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSysLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSysLogDA vSysLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSysLogDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSysLogBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsvSysLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysLogEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vSysLogDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vSysLogDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vSysLogDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vSysLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSysLogDA.GetDataTable_vSysLog(strWhereCond);
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
objDT = vSysLogDA.GetDataTable(strWhereCond);
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
objDT = vSysLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSysLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSysLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSysLogDA.GetDataTable_Top(objTopPara);
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
objDT = vSysLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vSysLogDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vSysLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSysLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vSysLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vSysLogDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vSysLogDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vSysLogDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
public static List<clsvSysLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
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
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSysLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvSysLogEN._CurrTabName);
List<clsvSysLogEN> arrvSysLogObjLstCache = GetObjLstCache();
IEnumerable <clsvSysLogEN> arrvSysLogObjLst_Sel =
arrvSysLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvSysLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetObjLst(string strWhereCond)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
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
public static List<clsvSysLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSysLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSysLogEN> GetSubObjLstCache(clsvSysLogEN objvSysLogCond)
{
List<clsvSysLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSysLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysLog.AttributeName)
{
if (objvSysLogCond.IsUpdated(strFldName) == false) continue;
if (objvSysLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysLogCond[strFldName].ToString());
}
else
{
if (objvSysLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysLogCond[strFldName]));
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
public static List<clsvSysLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
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
public static List<clsvSysLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
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
List<clsvSysLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSysLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSysLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
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
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
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
public static List<clsvSysLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSysLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSysLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
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
public static List<clsvSysLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvSysLogEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvSysLogEN objvSysLogCond, string strOrderBy)
{
List<clsvSysLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSysLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysLog.AttributeName)
{
if (objvSysLogCond.IsUpdated(strFldName) == false) continue;
if (objvSysLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysLogCond[strFldName].ToString());
}
else
{
if (objvSysLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysLogCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvSysLogEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvSysLogEN objvSysLogCond = JsonConvert.DeserializeObject<clsvSysLogEN>(objPagerPara.whereCond);
if (objvSysLogCond.sfFldComparisonOp == null)
{
objvSysLogCond.dicFldComparisonOp = null;
}
else
{
objvSysLogCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvSysLogCond.sfFldComparisonOp);
}
clsvSysLogBL.SetUpdFlag(objvSysLogCond);
 try
{
CheckProperty4Condition(objvSysLogCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvSysLogBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvSysLogCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSysLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSysLog(ref clsvSysLogEN objvSysLogEN)
{
bool bolResult = vSysLogDA.GetvSysLog(ref objvSysLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysLogEN GetObjBymId(long lngmId)
{
clsvSysLogEN objvSysLogEN = vSysLogDA.GetObjBymId(lngmId);
return objvSysLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSysLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSysLogEN objvSysLogEN = vSysLogDA.GetFirstObj(strWhereCond);
 return objvSysLogEN;
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
public static clsvSysLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSysLogEN objvSysLogEN = vSysLogDA.GetObjByDataRow(objRow);
 return objvSysLogEN;
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
public static clsvSysLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSysLogEN objvSysLogEN = vSysLogDA.GetObjByDataRow(objRow);
 return objvSysLogEN;
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
 /// <param name = "lstvSysLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysLogEN GetObjBymIdFromList(long lngmId, List<clsvSysLogEN> lstvSysLogObjLst)
{
foreach (clsvSysLogEN objvSysLogEN in lstvSysLogObjLst)
{
if (objvSysLogEN.mId == lngmId)
{
return objvSysLogEN;
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
 lngmId = new clsvSysLogDA().GetFirstID(strWhereCond);
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
 arrList = vSysLogDA.GetID(strWhereCond);
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
bool bolIsExist = vSysLogDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vSysLogDA.IsExist(lngmId);
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
 bolIsExist = clsvSysLogDA.IsExistTable();
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
 bolIsExist = vSysLogDA.IsExistTable(strTabName);
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
 /// <param name = "objvSysLogENS">源对象</param>
 /// <param name = "objvSysLogENT">目标对象</param>
 public static void CopyTo(clsvSysLogEN objvSysLogENS, clsvSysLogEN objvSysLogENT)
{
try
{
objvSysLogENT.mId = objvSysLogENS.mId; //mId
objvSysLogENT.UserName = objvSysLogENS.UserName; //用户名
objvSysLogENT.LoginTime = objvSysLogENS.LoginTime; //登陆时间
objvSysLogENT.LoginDate = objvSysLogENS.LoginDate; //登陆日期
objvSysLogENT.PrjName = objvSysLogENS.PrjName; //工程名称
objvSysLogENT.TableName = objvSysLogENS.TableName; //表名
objvSysLogENT.TableKey = objvSysLogENS.TableKey; //数据表关键字值
objvSysLogENT.OpTypeName = objvSysLogENS.OpTypeName; //操作类型名称
objvSysLogENT.UserIp = objvSysLogENS.UserIp; //用户IP
objvSysLogENT.OpTypeId = objvSysLogENS.OpTypeId; //操作类型Id
objvSysLogENT.OpContent = objvSysLogENS.OpContent; //操作内容
objvSysLogENT.OpDate = objvSysLogENS.OpDate; //操作日期
objvSysLogENT.PrjId = objvSysLogENS.PrjId; //工程ID
objvSysLogENT.OpTime = objvSysLogENS.OpTime; //操作时间
objvSysLogENT.UserId = objvSysLogENS.UserId; //用户Id
objvSysLogENT.Memo = objvSysLogENS.Memo; //说明
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
 /// <param name = "objvSysLogEN">源简化对象</param>
 public static void SetUpdFlag(clsvSysLogEN objvSysLogEN)
{
try
{
objvSysLogEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvSysLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSysLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.mId = objvSysLogEN.mId; //mId
}
if (arrFldSet.Contains(convSysLog.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.UserName = objvSysLogEN.UserName == "[null]" ? null :  objvSysLogEN.UserName; //用户名
}
if (arrFldSet.Contains(convSysLog.LoginTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.LoginTime = objvSysLogEN.LoginTime == "[null]" ? null :  objvSysLogEN.LoginTime; //登陆时间
}
if (arrFldSet.Contains(convSysLog.LoginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.LoginDate = objvSysLogEN.LoginDate == "[null]" ? null :  objvSysLogEN.LoginDate; //登陆日期
}
if (arrFldSet.Contains(convSysLog.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.PrjName = objvSysLogEN.PrjName == "[null]" ? null :  objvSysLogEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convSysLog.TableName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.TableName = objvSysLogEN.TableName == "[null]" ? null :  objvSysLogEN.TableName; //表名
}
if (arrFldSet.Contains(convSysLog.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.TableKey = objvSysLogEN.TableKey == "[null]" ? null :  objvSysLogEN.TableKey; //数据表关键字值
}
if (arrFldSet.Contains(convSysLog.OpTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.OpTypeName = objvSysLogEN.OpTypeName == "[null]" ? null :  objvSysLogEN.OpTypeName; //操作类型名称
}
if (arrFldSet.Contains(convSysLog.UserIp, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.UserIp = objvSysLogEN.UserIp == "[null]" ? null :  objvSysLogEN.UserIp; //用户IP
}
if (arrFldSet.Contains(convSysLog.OpTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.OpTypeId = objvSysLogEN.OpTypeId; //操作类型Id
}
if (arrFldSet.Contains(convSysLog.OpContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.OpContent = objvSysLogEN.OpContent == "[null]" ? null :  objvSysLogEN.OpContent; //操作内容
}
if (arrFldSet.Contains(convSysLog.OpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.OpDate = objvSysLogEN.OpDate == "[null]" ? null :  objvSysLogEN.OpDate; //操作日期
}
if (arrFldSet.Contains(convSysLog.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.PrjId = objvSysLogEN.PrjId == "[null]" ? null :  objvSysLogEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convSysLog.OpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.OpTime = objvSysLogEN.OpTime == "[null]" ? null :  objvSysLogEN.OpTime; //操作时间
}
if (arrFldSet.Contains(convSysLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.UserId = objvSysLogEN.UserId == "[null]" ? null :  objvSysLogEN.UserId; //用户Id
}
if (arrFldSet.Contains(convSysLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysLogEN.Memo = objvSysLogEN.Memo == "[null]" ? null :  objvSysLogEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvSysLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSysLogEN objvSysLogEN)
{
try
{
if (objvSysLogEN.UserName == "[null]") objvSysLogEN.UserName = null; //用户名
if (objvSysLogEN.LoginTime == "[null]") objvSysLogEN.LoginTime = null; //登陆时间
if (objvSysLogEN.LoginDate == "[null]") objvSysLogEN.LoginDate = null; //登陆日期
if (objvSysLogEN.PrjName == "[null]") objvSysLogEN.PrjName = null; //工程名称
if (objvSysLogEN.TableName == "[null]") objvSysLogEN.TableName = null; //表名
if (objvSysLogEN.TableKey == "[null]") objvSysLogEN.TableKey = null; //数据表关键字值
if (objvSysLogEN.OpTypeName == "[null]") objvSysLogEN.OpTypeName = null; //操作类型名称
if (objvSysLogEN.UserIp == "[null]") objvSysLogEN.UserIp = null; //用户IP
if (objvSysLogEN.OpContent == "[null]") objvSysLogEN.OpContent = null; //操作内容
if (objvSysLogEN.OpDate == "[null]") objvSysLogEN.OpDate = null; //操作日期
if (objvSysLogEN.PrjId == "[null]") objvSysLogEN.PrjId = null; //工程ID
if (objvSysLogEN.OpTime == "[null]") objvSysLogEN.OpTime = null; //操作时间
if (objvSysLogEN.UserId == "[null]") objvSysLogEN.UserId = null; //用户Id
if (objvSysLogEN.Memo == "[null]") objvSysLogEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvSysLogEN objvSysLogEN)
{
 vSysLogDA.CheckProperty4Condition(objvSysLogEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsOperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsOperationTypeBL没有刷新缓存机制(clsOperationTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysLogBL没有刷新缓存机制(clsSysLogBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvSysLogObjLstCache == null)
//{
//arrvSysLogObjLstCache = vSysLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysLogEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSysLogEN._CurrTabName);
List<clsvSysLogEN> arrvSysLogObjLstCache = GetObjLstCache();
IEnumerable <clsvSysLogEN> arrvSysLogObjLst_Sel =
arrvSysLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvSysLogObjLst_Sel.Count() == 0)
{
   clsvSysLogEN obj = clsvSysLogBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSysLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysLogEN> GetAllvSysLogObjLstCache()
{
//获取缓存中的对象列表
List<clsvSysLogEN> arrvSysLogObjLstCache = GetObjLstCache(); 
return arrvSysLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSysLogEN._CurrTabName);
List<clsvSysLogEN> arrvSysLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSysLogObjLstCache;
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
string strKey = string.Format("{0}", clsvSysLogEN._CurrTabName);
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
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvSysLogObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvSysLogEN> lstvSysLogObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvSysLogObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvSysLogObjLst">[clsvSysLogEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvSysLogEN> lstvSysLogObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvSysLogBL.listXmlNode);
writer.WriteStartElement(clsvSysLogBL.itemsXmlNode);
foreach (clsvSysLogEN objvSysLogEN in lstvSysLogObjLst)
{
clsvSysLogBL.SerializeXML(writer, objvSysLogEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvSysLogEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvSysLogEN objvSysLogEN)
{
writer.WriteStartElement(clsvSysLogBL.itemXmlNode);
 
writer.WriteElementString(convSysLog.mId, objvSysLogEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvSysLogEN.UserName != null)
{
writer.WriteElementString(convSysLog.UserName, objvSysLogEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.LoginTime != null)
{
writer.WriteElementString(convSysLog.LoginTime, objvSysLogEN.LoginTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.LoginDate != null)
{
writer.WriteElementString(convSysLog.LoginDate, objvSysLogEN.LoginDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.PrjName != null)
{
writer.WriteElementString(convSysLog.PrjName, objvSysLogEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.TableName != null)
{
writer.WriteElementString(convSysLog.TableName, objvSysLogEN.TableName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.TableKey != null)
{
writer.WriteElementString(convSysLog.TableKey, objvSysLogEN.TableKey.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.OpTypeName != null)
{
writer.WriteElementString(convSysLog.OpTypeName, objvSysLogEN.OpTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.UserIp != null)
{
writer.WriteElementString(convSysLog.UserIp, objvSysLogEN.UserIp.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.OpTypeId != null)
{
writer.WriteElementString(convSysLog.OpTypeId, objvSysLogEN.OpTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.OpContent != null)
{
writer.WriteElementString(convSysLog.OpContent, objvSysLogEN.OpContent.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.OpDate != null)
{
writer.WriteElementString(convSysLog.OpDate, objvSysLogEN.OpDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.PrjId != null)
{
writer.WriteElementString(convSysLog.PrjId, objvSysLogEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.OpTime != null)
{
writer.WriteElementString(convSysLog.OpTime, objvSysLogEN.OpTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.UserId != null)
{
writer.WriteElementString(convSysLog.UserId, objvSysLogEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSysLogEN.Memo != null)
{
writer.WriteElementString(convSysLog.Memo, objvSysLogEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvSysLogEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
reader.Read();
while (!(reader.Name == clsvSysLogBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convSysLog.mId))
{
objvSysLogEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convSysLog.UserName))
{
objvSysLogEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.LoginTime))
{
objvSysLogEN.LoginTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.LoginDate))
{
objvSysLogEN.LoginDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.PrjName))
{
objvSysLogEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.TableName))
{
objvSysLogEN.TableName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.TableKey))
{
objvSysLogEN.TableKey = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.OpTypeName))
{
objvSysLogEN.OpTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.UserIp))
{
objvSysLogEN.UserIp = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.OpTypeId))
{
objvSysLogEN.OpTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.OpContent))
{
objvSysLogEN.OpContent = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.OpDate))
{
objvSysLogEN.OpDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.PrjId))
{
objvSysLogEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.OpTime))
{
objvSysLogEN.OpTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.UserId))
{
objvSysLogEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSysLog.Memo))
{
objvSysLogEN.Memo = reader.ReadElementContentAsString();
}
}
return objvSysLogEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvSysLogObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvSysLogEN GetObjFromXmlStr(string strvSysLogObjXmlStr)
{
clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvSysLogObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvSysLogBL.itemXmlNode))
{
objvSysLogEN = GetObjFromXml(reader);
return objvSysLogEN;
}
}
return objvSysLogEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvSysLogEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvSysLogEN objvSysLogEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvSysLogEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convSysLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSysLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSysLog.AttributeName));
throw new Exception(strMsg);
}
var objvSysLog = clsvSysLogBL.GetObjBymIdCache(lngmId);
if (objvSysLog == null) return "";
return objvSysLog[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvSysLogEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvSysLogEN objvSysLogEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvSysLogEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvSysLogEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvSysLogObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvSysLogEN> lstvSysLogObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvSysLogObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvSysLogEN objvSysLogEN in lstvSysLogObjLst)
{
string strJSON_One = SerializeObjToJSON(objvSysLogEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsvSysLogDA.GetRecCount(strTabName);
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
int intRecCount = clsvSysLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSysLogDA.GetRecCount();
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
int intRecCount = clsvSysLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSysLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSysLogEN objvSysLogCond)
{
List<clsvSysLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSysLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysLog.AttributeName)
{
if (objvSysLogCond.IsUpdated(strFldName) == false) continue;
if (objvSysLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysLogCond[strFldName].ToString());
}
else
{
if (objvSysLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysLogCond[strFldName]));
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
 List<string> arrList = clsvSysLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSysLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSysLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}