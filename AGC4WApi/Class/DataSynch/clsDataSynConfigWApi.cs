
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataSynConfigWApi
 表名:DataSynConfig(00050346)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:30:35
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步
 模块英文名:DataSynch
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
public static class clsDataSynConfigWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetmId(this clsDataSynConfigEN objDataSynConfigEN, long lngmId, string strComparisonOp="")
	{
objDataSynConfigEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.mId) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.mId, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.mId] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetTabName(this clsDataSynConfigEN objDataSynConfigEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 100, conDataSynConfig.TabName);
objDataSynConfigEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.TabName) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.TabName, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.TabName] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetIsSynch(this clsDataSynConfigEN objDataSynConfigEN, bool bolIsSynch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSynch, conDataSynConfig.IsSynch);
objDataSynConfigEN.IsSynch = bolIsSynch; //是否同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.IsSynch) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.IsSynch, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.IsSynch] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetSynCondition(this clsDataSynConfigEN objDataSynConfigEN, string strSynCondition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynCondition, conDataSynConfig.SynCondition);
clsCheckSql.CheckFieldLen(strSynCondition, 5000, conDataSynConfig.SynCondition);
objDataSynConfigEN.SynCondition = strSynCondition; //同步条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynCondition) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynCondition, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynCondition] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetSynCondition4Web(this clsDataSynConfigEN objDataSynConfigEN, string strSynCondition4Web, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynCondition4Web, 5000, conDataSynConfig.SynCondition4Web);
objDataSynConfigEN.SynCondition4Web = strSynCondition4Web; //同步条件4Web
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynCondition4Web) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynCondition4Web, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynCondition4Web] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetSynchCycle(this clsDataSynConfigEN objDataSynConfigEN, string strSynchCycle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynchCycle, conDataSynConfig.SynchCycle);
clsCheckSql.CheckFieldLen(strSynchCycle, 30, conDataSynConfig.SynchCycle);
objDataSynConfigEN.SynchCycle = strSynchCycle; //同步周期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchCycle) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchCycle, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchCycle] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetSynchDate(this clsDataSynConfigEN objDataSynConfigEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynchDate, conDataSynConfig.SynchDate);
clsCheckSql.CheckFieldLen(strSynchDate, 30, conDataSynConfig.SynchDate);
objDataSynConfigEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchDate) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchDate, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchDate] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetSynchTime(this clsDataSynConfigEN objDataSynConfigEN, string strSynchTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSynchTime, conDataSynConfig.SynchTime);
clsCheckSql.CheckFieldLen(strSynchTime, 30, conDataSynConfig.SynchTime);
objDataSynConfigEN.SynchTime = strSynchTime; //同步时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchTime) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchTime, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchTime] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetSenderUser(this clsDataSynConfigEN objDataSynConfigEN, string strSenderUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenderUser, 30, conDataSynConfig.SenderUser);
objDataSynConfigEN.SenderUser = strSenderUser; //发送邮件用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SenderUser) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SenderUser, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SenderUser] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetSenderPwd(this clsDataSynConfigEN objDataSynConfigEN, string strSenderPwd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenderPwd, 30, conDataSynConfig.SenderPwd);
objDataSynConfigEN.SenderPwd = strSenderPwd; //发送邮件口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SenderPwd) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SenderPwd, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SenderPwd] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN Setsmtp(this clsDataSynConfigEN objDataSynConfigEN, string strsmtp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsmtp, 50, conDataSynConfig.smtp);
objDataSynConfigEN.smtp = strsmtp; //发送邮件服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.smtp) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.smtp, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.smtp] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetReceiver(this clsDataSynConfigEN objDataSynConfigEN, string strReceiver, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReceiver, 50, conDataSynConfig.Receiver);
objDataSynConfigEN.Receiver = strReceiver; //接收者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.Receiver) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.Receiver, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.Receiver] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetlastMailDate(this clsDataSynConfigEN objDataSynConfigEN, string strlastMailDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strlastMailDate, 50, conDataSynConfig.lastMailDate);
objDataSynConfigEN.lastMailDate = strlastMailDate; //最后发邮件日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.lastMailDate) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.lastMailDate, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.lastMailDate] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetlastExecuteDate(this clsDataSynConfigEN objDataSynConfigEN, string strlastExecuteDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strlastExecuteDate, 50, conDataSynConfig.lastExecuteDate);
objDataSynConfigEN.lastExecuteDate = strlastExecuteDate; //最后执行日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.lastExecuteDate) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.lastExecuteDate, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.lastExecuteDate] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetSynchStartTime(this clsDataSynConfigEN objDataSynConfigEN, string strSynchStartTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchStartTime, 14, conDataSynConfig.SynchStartTime);
objDataSynConfigEN.SynchStartTime = strSynchStartTime; //同步开始时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchStartTime) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchStartTime, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchStartTime] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetSynchEndTime(this clsDataSynConfigEN objDataSynConfigEN, string strSynchEndTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchEndTime, 14, conDataSynConfig.SynchEndTime);
objDataSynConfigEN.SynchEndTime = strSynchEndTime; //同步结束时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.SynchEndTime) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.SynchEndTime, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.SynchEndTime] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetOrderNum(this clsDataSynConfigEN objDataSynConfigEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conDataSynConfig.OrderNum);
objDataSynConfigEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.OrderNum) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.OrderNum, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.OrderNum] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataSynConfigEN SetMemo(this clsDataSynConfigEN objDataSynConfigEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataSynConfig.Memo);
objDataSynConfigEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataSynConfigEN.dicFldComparisonOp.ContainsKey(conDataSynConfig.Memo) == false)
{
objDataSynConfigEN.dicFldComparisonOp.Add(conDataSynConfig.Memo, strComparisonOp);
}
else
{
objDataSynConfigEN.dicFldComparisonOp[conDataSynConfig.Memo] = strComparisonOp;
}
}
return objDataSynConfigEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataSynConfigEN objDataSynConfig_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.mId) == true)
{
string strComparisonOp_mId = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataSynConfig.mId, objDataSynConfig_Cond.mId, strComparisonOp_mId);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.TabName) == true)
{
string strComparisonOp_TabName = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.TabName, objDataSynConfig_Cond.TabName, strComparisonOp_TabName);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.IsSynch) == true)
{
if (objDataSynConfig_Cond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataSynConfig.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataSynConfig.IsSynch);
}
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.SynCondition) == true)
{
string strComparisonOp_SynCondition = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.SynCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynCondition, objDataSynConfig_Cond.SynCondition, strComparisonOp_SynCondition);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.SynCondition4Web) == true)
{
string strComparisonOp_SynCondition4Web = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.SynCondition4Web];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynCondition4Web, objDataSynConfig_Cond.SynCondition4Web, strComparisonOp_SynCondition4Web);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.SynchCycle) == true)
{
string strComparisonOp_SynchCycle = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.SynchCycle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchCycle, objDataSynConfig_Cond.SynchCycle, strComparisonOp_SynchCycle);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.SynchDate) == true)
{
string strComparisonOp_SynchDate = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchDate, objDataSynConfig_Cond.SynchDate, strComparisonOp_SynchDate);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.SynchTime) == true)
{
string strComparisonOp_SynchTime = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.SynchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchTime, objDataSynConfig_Cond.SynchTime, strComparisonOp_SynchTime);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.SenderUser) == true)
{
string strComparisonOp_SenderUser = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.SenderUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SenderUser, objDataSynConfig_Cond.SenderUser, strComparisonOp_SenderUser);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.SenderPwd) == true)
{
string strComparisonOp_SenderPwd = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.SenderPwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SenderPwd, objDataSynConfig_Cond.SenderPwd, strComparisonOp_SenderPwd);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.smtp) == true)
{
string strComparisonOp_smtp = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.smtp];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.smtp, objDataSynConfig_Cond.smtp, strComparisonOp_smtp);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.Receiver) == true)
{
string strComparisonOp_Receiver = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.Receiver];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.Receiver, objDataSynConfig_Cond.Receiver, strComparisonOp_Receiver);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.lastMailDate) == true)
{
string strComparisonOp_lastMailDate = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.lastMailDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.lastMailDate, objDataSynConfig_Cond.lastMailDate, strComparisonOp_lastMailDate);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.lastExecuteDate) == true)
{
string strComparisonOp_lastExecuteDate = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.lastExecuteDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.lastExecuteDate, objDataSynConfig_Cond.lastExecuteDate, strComparisonOp_lastExecuteDate);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.SynchStartTime) == true)
{
string strComparisonOp_SynchStartTime = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.SynchStartTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchStartTime, objDataSynConfig_Cond.SynchStartTime, strComparisonOp_SynchStartTime);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.SynchEndTime) == true)
{
string strComparisonOp_SynchEndTime = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.SynchEndTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.SynchEndTime, objDataSynConfig_Cond.SynchEndTime, strComparisonOp_SynchEndTime);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.OrderNum) == true)
{
string strComparisonOp_OrderNum = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDataSynConfig.OrderNum, objDataSynConfig_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objDataSynConfig_Cond.IsUpdated(conDataSynConfig.Memo) == true)
{
string strComparisonOp_Memo = objDataSynConfig_Cond.dicFldComparisonOp[conDataSynConfig.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataSynConfig.Memo, objDataSynConfig_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataSynConfigEN objDataSynConfigEN)
{
 if (objDataSynConfigEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDataSynConfigEN.sfUpdFldSetStr = objDataSynConfigEN.getsfUpdFldSetStr();
clsDataSynConfigWApi.CheckPropertyNew(objDataSynConfigEN); 
bool bolResult = clsDataSynConfigWApi.UpdateRecord(objDataSynConfigEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--DataSynConfig(同步配置), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDataSynConfigEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_TabName(this clsDataSynConfigEN objDataSynConfigEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDataSynConfigEN == null) return "";
if (objDataSynConfigEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objDataSynConfigEN.TabName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDataSynConfigEN.mId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objDataSynConfigEN.TabName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataSynConfigEN objDataSynConfigEN)
{
try
{
clsDataSynConfigWApi.CheckPropertyNew(objDataSynConfigEN); 
bool bolResult = clsDataSynConfigWApi.AddNewRecord(objDataSynConfigEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataSynConfigEN objDataSynConfigEN, string strWhereCond)
{
try
{
clsDataSynConfigWApi.CheckPropertyNew(objDataSynConfigEN); 
bool bolResult = clsDataSynConfigWApi.UpdateWithCondition(objDataSynConfigEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigWApi.ReFreshCache();
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
 /// 同步配置(DataSynConfig)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDataSynConfigWApi
{
private static readonly string mstrApiControllerName = "DataSynConfigApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsDataSynConfigWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDataSynConfigEN objDataSynConfigEN)
{
if (!Object.Equals(null, objDataSynConfigEN.TabName) && GetStrLen(objDataSynConfigEN.TabName) > 100)
{
 throw new Exception("字段[表名]的长度不能超过100!");
}
if (!Object.Equals(null, objDataSynConfigEN.SynCondition) && GetStrLen(objDataSynConfigEN.SynCondition) > 5000)
{
 throw new Exception("字段[同步条件]的长度不能超过5000!");
}
if (!Object.Equals(null, objDataSynConfigEN.SynCondition4Web) && GetStrLen(objDataSynConfigEN.SynCondition4Web) > 5000)
{
 throw new Exception("字段[同步条件4Web]的长度不能超过5000!");
}
if (!Object.Equals(null, objDataSynConfigEN.SynchCycle) && GetStrLen(objDataSynConfigEN.SynchCycle) > 30)
{
 throw new Exception("字段[同步周期]的长度不能超过30!");
}
if (!Object.Equals(null, objDataSynConfigEN.SynchDate) && GetStrLen(objDataSynConfigEN.SynchDate) > 30)
{
 throw new Exception("字段[同步日期]的长度不能超过30!");
}
if (!Object.Equals(null, objDataSynConfigEN.SynchTime) && GetStrLen(objDataSynConfigEN.SynchTime) > 30)
{
 throw new Exception("字段[同步时间]的长度不能超过30!");
}
if (!Object.Equals(null, objDataSynConfigEN.SenderUser) && GetStrLen(objDataSynConfigEN.SenderUser) > 30)
{
 throw new Exception("字段[发送邮件用户]的长度不能超过30!");
}
if (!Object.Equals(null, objDataSynConfigEN.SenderPwd) && GetStrLen(objDataSynConfigEN.SenderPwd) > 30)
{
 throw new Exception("字段[发送邮件口令]的长度不能超过30!");
}
if (!Object.Equals(null, objDataSynConfigEN.smtp) && GetStrLen(objDataSynConfigEN.smtp) > 50)
{
 throw new Exception("字段[发送邮件服务器]的长度不能超过50!");
}
if (!Object.Equals(null, objDataSynConfigEN.Receiver) && GetStrLen(objDataSynConfigEN.Receiver) > 50)
{
 throw new Exception("字段[接收者]的长度不能超过50!");
}
if (!Object.Equals(null, objDataSynConfigEN.lastMailDate) && GetStrLen(objDataSynConfigEN.lastMailDate) > 50)
{
 throw new Exception("字段[最后发邮件日期]的长度不能超过50!");
}
if (!Object.Equals(null, objDataSynConfigEN.lastExecuteDate) && GetStrLen(objDataSynConfigEN.lastExecuteDate) > 50)
{
 throw new Exception("字段[最后执行日期]的长度不能超过50!");
}
if (!Object.Equals(null, objDataSynConfigEN.SynchStartTime) && GetStrLen(objDataSynConfigEN.SynchStartTime) > 14)
{
 throw new Exception("字段[同步开始时间]的长度不能超过14!");
}
if (!Object.Equals(null, objDataSynConfigEN.SynchEndTime) && GetStrLen(objDataSynConfigEN.SynchEndTime) > 14)
{
 throw new Exception("字段[同步结束时间]的长度不能超过14!");
}
if (!Object.Equals(null, objDataSynConfigEN.Memo) && GetStrLen(objDataSynConfigEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDataSynConfigEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataSynConfigEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsDataSynConfigEN objDataSynConfigEN = null;
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
objDataSynConfigEN = JsonConvert.DeserializeObject<clsDataSynConfigEN>((string)jobjReturn["returnObj"]);
return objDataSynConfigEN;
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
public static clsDataSynConfigEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsDataSynConfigEN objDataSynConfigEN = null;
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
objDataSynConfigEN = JsonConvert.DeserializeObject<clsDataSynConfigEN>((string)jobjReturn["returnObj"]);
return objDataSynConfigEN;
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
public static clsDataSynConfigEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsDataSynConfigEN objDataSynConfigEN = null;
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
objDataSynConfigEN = JsonConvert.DeserializeObject<clsDataSynConfigEN>((string)jobjReturn["returnObj"]);
return objDataSynConfigEN;
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
public static clsDataSynConfigEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
List<clsDataSynConfigEN> arrDataSynConfigObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsDataSynConfigEN> arrDataSynConfigObjLst_Sel =
from objDataSynConfigEN in arrDataSynConfigObjLst_Cache
where objDataSynConfigEN.mId == lngmId
select objDataSynConfigEN;
if (arrDataSynConfigObjLst_Sel.Count() == 0)
{
   clsDataSynConfigEN obj = clsDataSynConfigWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDataSynConfigObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataSynConfigEN> GetObjLst(string strWhereCond)
{
 List<clsDataSynConfigEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataSynConfigEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsDataSynConfigEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsDataSynConfigEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataSynConfigEN>>((string)jobjReturn["returnObjLst"]);
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
public static IEnumerable<clsDataSynConfigEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
List<clsDataSynConfigEN> arrDataSynConfigObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsDataSynConfigEN> arrDataSynConfigObjLst_Sel =
from objDataSynConfigEN in arrDataSynConfigObjLst_Cache
where arrMId.Contains(objDataSynConfigEN.mId)
select objDataSynConfigEN;
return arrDataSynConfigObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataSynConfigEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsDataSynConfigEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataSynConfigEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsDataSynConfigEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDataSynConfigEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataSynConfigEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsDataSynConfigEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDataSynConfigEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataSynConfigEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsDataSynConfigEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDataSynConfigEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataSynConfigEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsDataSynConfigEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsDataSynConfigEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataSynConfigEN>>((string)jobjReturn["returnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsDataSynConfigEN objDataSynConfigEN = clsDataSynConfigWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsDataSynConfigWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["returnInt"];
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
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
public static int DelDataSynConfigs(List<string> arrmId)
{
string strAction = "DelDataSynConfigs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsDataSynConfigWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["returnInt"];
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
public static int DelDataSynConfigsByCond(string strWhereCond)
{
string strAction = "DelDataSynConfigsByCond";
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
var intReturnInt = (int)jobjReturn["returnInt"];
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
public static bool AddNewRecord(clsDataSynConfigEN objDataSynConfigEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataSynConfigEN>(objDataSynConfigEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsDataSynConfigEN objDataSynConfigEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataSynConfigEN>(objDataSynConfigEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataSynConfigWApi.ReFreshCache();
var strReturnStr = (string)jobjReturn["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool UpdateRecord(clsDataSynConfigEN objDataSynConfigEN)
{
if (string.IsNullOrEmpty(objDataSynConfigEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDataSynConfigEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataSynConfigEN>(objDataSynConfigEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// <param name = "objDataSynConfigEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDataSynConfigEN objDataSynConfigEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDataSynConfigEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDataSynConfigEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDataSynConfigEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataSynConfigEN>(objDataSynConfigEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
var intReturnInt = (int)jobjReturn["returnInt"];
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
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
 /// <param name = "objDataSynConfigENS">源对象</param>
 /// <param name = "objDataSynConfigENT">目标对象</param>
 public static void CopyTo(clsDataSynConfigEN objDataSynConfigENS, clsDataSynConfigEN objDataSynConfigENT)
{
try
{
objDataSynConfigENT.mId = objDataSynConfigENS.mId; //mId
objDataSynConfigENT.TabName = objDataSynConfigENS.TabName; //表名
objDataSynConfigENT.IsSynch = objDataSynConfigENS.IsSynch; //是否同步
objDataSynConfigENT.SynCondition = objDataSynConfigENS.SynCondition; //同步条件
objDataSynConfigENT.SynCondition4Web = objDataSynConfigENS.SynCondition4Web; //同步条件4Web
objDataSynConfigENT.SynchCycle = objDataSynConfigENS.SynchCycle; //同步周期
objDataSynConfigENT.SynchDate = objDataSynConfigENS.SynchDate; //同步日期
objDataSynConfigENT.SynchTime = objDataSynConfigENS.SynchTime; //同步时间
objDataSynConfigENT.SenderUser = objDataSynConfigENS.SenderUser; //发送邮件用户
objDataSynConfigENT.SenderPwd = objDataSynConfigENS.SenderPwd; //发送邮件口令
objDataSynConfigENT.smtp = objDataSynConfigENS.smtp; //发送邮件服务器
objDataSynConfigENT.Receiver = objDataSynConfigENS.Receiver; //接收者
objDataSynConfigENT.lastMailDate = objDataSynConfigENS.lastMailDate; //最后发邮件日期
objDataSynConfigENT.lastExecuteDate = objDataSynConfigENS.lastExecuteDate; //最后执行日期
objDataSynConfigENT.SynchStartTime = objDataSynConfigENS.SynchStartTime; //同步开始时间
objDataSynConfigENT.SynchEndTime = objDataSynConfigENS.SynchEndTime; //同步结束时间
objDataSynConfigENT.OrderNum = objDataSynConfigENS.OrderNum; //序号
objDataSynConfigENT.Memo = objDataSynConfigENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDataSynConfigEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDataSynConfigEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDataSynConfigEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDataSynConfigEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDataSynConfigEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDataSynConfigEN.AttributeName)
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
if (clsDataSynConfigWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsDataSynConfigWApi没有刷新缓存机制(clsDataSynConfigWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrDataSynConfigObjLst_Cache == null)
//{
//arrDataSynConfigObjLst_Cache = await clsDataSynConfigWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
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
if (clsDataSynConfigWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataSynConfigWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataSynConfigEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsDataSynConfigEN._CurrTabName);
List<clsDataSynConfigEN> arrDataSynConfigObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDataSynConfigObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDataSynConfigEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDataSynConfig.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDataSynConfig.TabName, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.IsSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataSynConfig.SynCondition, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.SynCondition4Web, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.SynchCycle, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.SynchDate, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.SynchTime, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.SenderUser, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.SenderPwd, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.smtp, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.Receiver, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.lastMailDate, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.lastExecuteDate, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.SynchStartTime, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.SynchEndTime, Type.GetType("System.String"));
objDT.Columns.Add(conDataSynConfig.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataSynConfig.Memo, Type.GetType("System.String"));
foreach (clsDataSynConfigEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDataSynConfig.mId] = objInFor[conDataSynConfig.mId];
objDR[conDataSynConfig.TabName] = objInFor[conDataSynConfig.TabName];
objDR[conDataSynConfig.IsSynch] = objInFor[conDataSynConfig.IsSynch];
objDR[conDataSynConfig.SynCondition] = objInFor[conDataSynConfig.SynCondition];
objDR[conDataSynConfig.SynCondition4Web] = objInFor[conDataSynConfig.SynCondition4Web];
objDR[conDataSynConfig.SynchCycle] = objInFor[conDataSynConfig.SynchCycle];
objDR[conDataSynConfig.SynchDate] = objInFor[conDataSynConfig.SynchDate];
objDR[conDataSynConfig.SynchTime] = objInFor[conDataSynConfig.SynchTime];
objDR[conDataSynConfig.SenderUser] = objInFor[conDataSynConfig.SenderUser];
objDR[conDataSynConfig.SenderPwd] = objInFor[conDataSynConfig.SenderPwd];
objDR[conDataSynConfig.smtp] = objInFor[conDataSynConfig.smtp];
objDR[conDataSynConfig.Receiver] = objInFor[conDataSynConfig.Receiver];
objDR[conDataSynConfig.lastMailDate] = objInFor[conDataSynConfig.lastMailDate];
objDR[conDataSynConfig.lastExecuteDate] = objInFor[conDataSynConfig.lastExecuteDate];
objDR[conDataSynConfig.SynchStartTime] = objInFor[conDataSynConfig.SynchStartTime];
objDR[conDataSynConfig.SynchEndTime] = objInFor[conDataSynConfig.SynchEndTime];
objDR[conDataSynConfig.OrderNum] = objInFor[conDataSynConfig.OrderNum];
objDR[conDataSynConfig.Memo] = objInFor[conDataSynConfig.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 同步配置(DataSynConfig)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4DataSynConfig : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clsDataSynConfigWApi.ReFreshThisCache();
}
}

}