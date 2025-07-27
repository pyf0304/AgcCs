
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysLogWApi
 表名:vSysLog(00050262)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:29:39
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理
 模块英文名:LogManage
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsvSysLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetUserName(this clsvSysLogEN objvSysLogEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 30, convSysLog.UserName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetLoginTime(this clsvSysLogEN objvSysLogEN, string strLoginTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLoginTime, 6, convSysLog.LoginTime);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetLoginDate(this clsvSysLogEN objvSysLogEN, string strLoginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLoginDate, 8, convSysLog.LoginDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetPrjName(this clsvSysLogEN objvSysLogEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convSysLog.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetTableName(this clsvSysLogEN objvSysLogEN, string strTableName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableName, 100, convSysLog.TableName);
objvSysLogEN.TableName = strTableName; //数据表名
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetTableKey(this clsvSysLogEN objvSysLogEN, string strTableKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableKey, 100, convSysLog.TableKey);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpTypeName(this clsvSysLogEN objvSysLogEN, string strOpTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpTypeName, 100, convSysLog.OpTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetUserIp(this clsvSysLogEN objvSysLogEN, string strUserIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserIp, 40, convSysLog.UserIp);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpTypeId(this clsvSysLogEN objvSysLogEN, string strOpTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOpTypeId, convSysLog.OpTypeId);
clsCheckSql.CheckFieldLen(strOpTypeId, 4, convSysLog.OpTypeId);
clsCheckSql.CheckFieldForeignKey(strOpTypeId, 4, convSysLog.OpTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpContent(this clsvSysLogEN objvSysLogEN, string strOpContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpContent, 1000, convSysLog.OpContent);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpDate(this clsvSysLogEN objvSysLogEN, string strOpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpDate, 8, convSysLog.OpDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetPrjId(this clsvSysLogEN objvSysLogEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convSysLog.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSysLog.PrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetOpTime(this clsvSysLogEN objvSysLogEN, string strOpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpTime, 6, convSysLog.OpTime);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetUserId(this clsvSysLogEN objvSysLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convSysLog.UserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysLogEN SetMemo(this clsvSysLogEN objvSysLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysLog.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysLogEN objvSysLog_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysLog_Cond.IsUpdated(convSysLog.mId) == true)
{
string strComparisonOp_mId = objvSysLog_Cond.dicFldComparisonOp[convSysLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convSysLog.mId, objvSysLog_Cond.mId, strComparisonOp_mId);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.UserName) == true)
{
string strComparisonOp_UserName = objvSysLog_Cond.dicFldComparisonOp[convSysLog.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.UserName, objvSysLog_Cond.UserName, strComparisonOp_UserName);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.LoginTime) == true)
{
string strComparisonOp_LoginTime = objvSysLog_Cond.dicFldComparisonOp[convSysLog.LoginTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.LoginTime, objvSysLog_Cond.LoginTime, strComparisonOp_LoginTime);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.LoginDate) == true)
{
string strComparisonOp_LoginDate = objvSysLog_Cond.dicFldComparisonOp[convSysLog.LoginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.LoginDate, objvSysLog_Cond.LoginDate, strComparisonOp_LoginDate);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.PrjName) == true)
{
string strComparisonOp_PrjName = objvSysLog_Cond.dicFldComparisonOp[convSysLog.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.PrjName, objvSysLog_Cond.PrjName, strComparisonOp_PrjName);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.TableName) == true)
{
string strComparisonOp_TableName = objvSysLog_Cond.dicFldComparisonOp[convSysLog.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.TableName, objvSysLog_Cond.TableName, strComparisonOp_TableName);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.TableKey) == true)
{
string strComparisonOp_TableKey = objvSysLog_Cond.dicFldComparisonOp[convSysLog.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.TableKey, objvSysLog_Cond.TableKey, strComparisonOp_TableKey);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.OpTypeName) == true)
{
string strComparisonOp_OpTypeName = objvSysLog_Cond.dicFldComparisonOp[convSysLog.OpTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpTypeName, objvSysLog_Cond.OpTypeName, strComparisonOp_OpTypeName);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.UserIp) == true)
{
string strComparisonOp_UserIp = objvSysLog_Cond.dicFldComparisonOp[convSysLog.UserIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.UserIp, objvSysLog_Cond.UserIp, strComparisonOp_UserIp);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.OpTypeId) == true)
{
string strComparisonOp_OpTypeId = objvSysLog_Cond.dicFldComparisonOp[convSysLog.OpTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpTypeId, objvSysLog_Cond.OpTypeId, strComparisonOp_OpTypeId);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.OpContent) == true)
{
string strComparisonOp_OpContent = objvSysLog_Cond.dicFldComparisonOp[convSysLog.OpContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpContent, objvSysLog_Cond.OpContent, strComparisonOp_OpContent);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.OpDate) == true)
{
string strComparisonOp_OpDate = objvSysLog_Cond.dicFldComparisonOp[convSysLog.OpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpDate, objvSysLog_Cond.OpDate, strComparisonOp_OpDate);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.PrjId) == true)
{
string strComparisonOp_PrjId = objvSysLog_Cond.dicFldComparisonOp[convSysLog.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.PrjId, objvSysLog_Cond.PrjId, strComparisonOp_PrjId);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.OpTime) == true)
{
string strComparisonOp_OpTime = objvSysLog_Cond.dicFldComparisonOp[convSysLog.OpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.OpTime, objvSysLog_Cond.OpTime, strComparisonOp_OpTime);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.UserId) == true)
{
string strComparisonOp_UserId = objvSysLog_Cond.dicFldComparisonOp[convSysLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.UserId, objvSysLog_Cond.UserId, strComparisonOp_UserId);
}
if (objvSysLog_Cond.IsUpdated(convSysLog.Memo) == true)
{
string strComparisonOp_Memo = objvSysLog_Cond.dicFldComparisonOp[convSysLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysLog.Memo, objvSysLog_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v系统日志(vSysLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSysLogWApi
{
private static readonly string mstrApiControllerName = "vSysLogApi";

 public clsvSysLogWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysLogEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvSysLogEN objvSysLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvSysLogEN = JsonConvert.DeserializeObject<clsvSysLogEN>((string)jobjReturn["returnObj"]);
return objvSysLogEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysLogEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvSysLogEN objvSysLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvSysLogEN = JsonConvert.DeserializeObject<clsvSysLogEN>((string)jobjReturn["returnObj"]);
return objvSysLogEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static clsvSysLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvSysLogEN objvSysLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvSysLogEN = JsonConvert.DeserializeObject<clsvSysLogEN>((string)jobjReturn["returnObj"]);
return objvSysLogEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysLogEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSysLogEN._CurrTabName);
List<clsvSysLogEN> arrvSysLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSysLogEN> arrvSysLogObjLst_Sel =
from objvSysLogEN in arrvSysLogObjLst_Cache
where objvSysLogEN.mId == lngmId
select objvSysLogEN;
if (arrvSysLogObjLst_Sel.Count() == 0)
{
   clsvSysLogEN obj = clsvSysLogWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSysLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetObjLst(string strWhereCond)
{
 List<clsvSysLogEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysLogEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvSysLogEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysLogEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvSysLogEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSysLogEN._CurrTabName);
List<clsvSysLogEN> arrvSysLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSysLogEN> arrvSysLogObjLst_Sel =
from objvSysLogEN in arrvSysLogObjLst_Cache
where arrMId.Contains(objvSysLogEN.mId)
select objvSysLogEN;
return arrvSysLogObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvSysLogEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysLogEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSysLogEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysLogEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvSysLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSysLogEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysLogEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvSysLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSysLogEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysLogEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvSysLogEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvSysLogEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysLogEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
objvSysLogENT.TableName = objvSysLogENS.TableName; //数据表名
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
public static DataTable ToDataTable(List<clsvSysLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSysLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSysLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSysLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSysLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSysLogEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsUsersWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsProjectsWApi没有刷新缓存机制(clsProjectsWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsOperationTypeWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsOperationTypeWApi没有刷新缓存机制(clsOperationTypeWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysLogWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsSysLogWApi没有刷新缓存机制(clsSysLogWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvSysLogObjLst_Cache == null)
//{
//arrvSysLogObjLst_Cache = await clsvSysLogWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
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

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysLogEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvSysLogEN._CurrTabName);
List<clsvSysLogEN> arrvSysLogObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSysLogObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSysLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSysLog.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convSysLog.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.LoginTime, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.LoginDate, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.TableName, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.TableKey, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.OpTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.UserIp, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.OpTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.OpContent, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.OpDate, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.OpTime, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convSysLog.Memo, Type.GetType("System.String"));
foreach (clsvSysLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSysLog.mId] = objInFor[convSysLog.mId];
objDR[convSysLog.UserName] = objInFor[convSysLog.UserName];
objDR[convSysLog.LoginTime] = objInFor[convSysLog.LoginTime];
objDR[convSysLog.LoginDate] = objInFor[convSysLog.LoginDate];
objDR[convSysLog.PrjName] = objInFor[convSysLog.PrjName];
objDR[convSysLog.TableName] = objInFor[convSysLog.TableName];
objDR[convSysLog.TableKey] = objInFor[convSysLog.TableKey];
objDR[convSysLog.OpTypeName] = objInFor[convSysLog.OpTypeName];
objDR[convSysLog.UserIp] = objInFor[convSysLog.UserIp];
objDR[convSysLog.OpTypeId] = objInFor[convSysLog.OpTypeId];
objDR[convSysLog.OpContent] = objInFor[convSysLog.OpContent];
objDR[convSysLog.OpDate] = objInFor[convSysLog.OpDate];
objDR[convSysLog.PrjId] = objInFor[convSysLog.PrjId];
objDR[convSysLog.OpTime] = objInFor[convSysLog.OpTime];
objDR[convSysLog.UserId] = objInFor[convSysLog.UserId];
objDR[convSysLog.Memo] = objInFor[convSysLog.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}