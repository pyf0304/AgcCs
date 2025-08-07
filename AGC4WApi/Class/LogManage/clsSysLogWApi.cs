
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysLogWApi
 表名:SysLog(00050129)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsSysLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetmId(this clsSysLogEN objSysLogEN, long lngmId, string strComparisonOp="")
	{
objSysLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.mId) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.mId, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.mId] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strLoginTime">登陆时间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetLoginTime(this clsSysLogEN objSysLogEN, string strLoginTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLoginTime, 6, conSysLog.LoginTime);
objSysLogEN.LoginTime = strLoginTime; //登陆时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.LoginTime) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.LoginTime, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.LoginTime] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strLoginDate">登陆日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetLoginDate(this clsSysLogEN objSysLogEN, string strLoginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLoginDate, 8, conSysLog.LoginDate);
objSysLogEN.LoginDate = strLoginDate; //登陆日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.LoginDate) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.LoginDate, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.LoginDate] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetTableName(this clsSysLogEN objSysLogEN, string strTableName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableName, 100, conSysLog.TableName);
objSysLogEN.TableName = strTableName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.TableName) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.TableName, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.TableName] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableKey">数据表关键字值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetTableKey(this clsSysLogEN objSysLogEN, string strTableKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableKey, 100, conSysLog.TableKey);
objSysLogEN.TableKey = strTableKey; //数据表关键字值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.TableKey) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.TableKey, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.TableKey] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserIp">用户IP</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetUserIp(this clsSysLogEN objSysLogEN, string strUserIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserIp, 40, conSysLog.UserIp);
objSysLogEN.UserIp = strUserIp; //用户IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.UserIp) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.UserIp, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.UserIp] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strOpTypeId">操作类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetOpTypeId(this clsSysLogEN objSysLogEN, string strOpTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOpTypeId, conSysLog.OpTypeId);
clsCheckSql.CheckFieldLen(strOpTypeId, 4, conSysLog.OpTypeId);
clsCheckSql.CheckFieldForeignKey(strOpTypeId, 4, conSysLog.OpTypeId);
objSysLogEN.OpTypeId = strOpTypeId; //操作类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.OpTypeId) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.OpTypeId, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.OpTypeId] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strOpContent">操作内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetOpContent(this clsSysLogEN objSysLogEN, string strOpContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpContent, 1000, conSysLog.OpContent);
objSysLogEN.OpContent = strOpContent; //操作内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.OpContent) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.OpContent, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.OpContent] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strOpDate">操作日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetOpDate(this clsSysLogEN objSysLogEN, string strOpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpDate, 8, conSysLog.OpDate);
objSysLogEN.OpDate = strOpDate; //操作日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.OpDate) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.OpDate, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.OpDate] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strOpTime">操作时间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetOpTime(this clsSysLogEN objSysLogEN, string strOpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpTime, 6, conSysLog.OpTime);
objSysLogEN.OpTime = strOpTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.OpTime) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.OpTime, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.OpTime] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetPrjId(this clsSysLogEN objSysLogEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSysLog.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSysLog.PrjId);
objSysLogEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.PrjId) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.PrjId, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.PrjId] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetUserId(this clsSysLogEN objSysLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, conSysLog.UserId);
objSysLogEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.UserId) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.UserId, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.UserId] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetMemo(this clsSysLogEN objSysLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysLog.Memo);
objSysLogEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.Memo) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.Memo, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.Memo] = strComparisonOp;
}
}
return objSysLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysLogEN objSysLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysLogCond.IsUpdated(conSysLog.mId) == true)
{
string strComparisonOpmId = objSysLogCond.dicFldComparisonOp[conSysLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conSysLog.mId, objSysLogCond.mId, strComparisonOpmId);
}
if (objSysLogCond.IsUpdated(conSysLog.LoginTime) == true)
{
string strComparisonOpLoginTime = objSysLogCond.dicFldComparisonOp[conSysLog.LoginTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.LoginTime, objSysLogCond.LoginTime, strComparisonOpLoginTime);
}
if (objSysLogCond.IsUpdated(conSysLog.LoginDate) == true)
{
string strComparisonOpLoginDate = objSysLogCond.dicFldComparisonOp[conSysLog.LoginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.LoginDate, objSysLogCond.LoginDate, strComparisonOpLoginDate);
}
if (objSysLogCond.IsUpdated(conSysLog.TableName) == true)
{
string strComparisonOpTableName = objSysLogCond.dicFldComparisonOp[conSysLog.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.TableName, objSysLogCond.TableName, strComparisonOpTableName);
}
if (objSysLogCond.IsUpdated(conSysLog.TableKey) == true)
{
string strComparisonOpTableKey = objSysLogCond.dicFldComparisonOp[conSysLog.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.TableKey, objSysLogCond.TableKey, strComparisonOpTableKey);
}
if (objSysLogCond.IsUpdated(conSysLog.UserIp) == true)
{
string strComparisonOpUserIp = objSysLogCond.dicFldComparisonOp[conSysLog.UserIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.UserIp, objSysLogCond.UserIp, strComparisonOpUserIp);
}
if (objSysLogCond.IsUpdated(conSysLog.OpTypeId) == true)
{
string strComparisonOpOpTypeId = objSysLogCond.dicFldComparisonOp[conSysLog.OpTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.OpTypeId, objSysLogCond.OpTypeId, strComparisonOpOpTypeId);
}
if (objSysLogCond.IsUpdated(conSysLog.OpContent) == true)
{
string strComparisonOpOpContent = objSysLogCond.dicFldComparisonOp[conSysLog.OpContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.OpContent, objSysLogCond.OpContent, strComparisonOpOpContent);
}
if (objSysLogCond.IsUpdated(conSysLog.OpDate) == true)
{
string strComparisonOpOpDate = objSysLogCond.dicFldComparisonOp[conSysLog.OpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.OpDate, objSysLogCond.OpDate, strComparisonOpOpDate);
}
if (objSysLogCond.IsUpdated(conSysLog.OpTime) == true)
{
string strComparisonOpOpTime = objSysLogCond.dicFldComparisonOp[conSysLog.OpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.OpTime, objSysLogCond.OpTime, strComparisonOpOpTime);
}
if (objSysLogCond.IsUpdated(conSysLog.PrjId) == true)
{
string strComparisonOpPrjId = objSysLogCond.dicFldComparisonOp[conSysLog.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.PrjId, objSysLogCond.PrjId, strComparisonOpPrjId);
}
if (objSysLogCond.IsUpdated(conSysLog.UserId) == true)
{
string strComparisonOpUserId = objSysLogCond.dicFldComparisonOp[conSysLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.UserId, objSysLogCond.UserId, strComparisonOpUserId);
}
if (objSysLogCond.IsUpdated(conSysLog.Memo) == true)
{
string strComparisonOpMemo = objSysLogCond.dicFldComparisonOp[conSysLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.Memo, objSysLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysLogEN objSysLogEN)
{
 if (objSysLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSysLogEN.sfUpdFldSetStr = objSysLogEN.getsfUpdFldSetStr();
clsSysLogWApi.CheckPropertyNew(objSysLogEN); 
bool bolResult = clsSysLogWApi.UpdateRecord(objSysLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--SysLog(系统日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_OpDate_OpTime_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsSysLogEN objSysLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysLogEN == null) return "";
if (objSysLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysLogEN.UserId);
 sbCondition.AppendFormat(" and OpDate = '{0}'", objSysLogEN.OpDate);
 sbCondition.AppendFormat(" and OpTime = '{0}'", objSysLogEN.OpTime);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysLogEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSysLogEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysLogEN.UserId);
 sbCondition.AppendFormat(" and OpDate = '{0}'", objSysLogEN.OpDate);
 sbCondition.AppendFormat(" and OpTime = '{0}'", objSysLogEN.OpTime);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysLogEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysLogEN objSysLogEN)
{
try
{
clsSysLogWApi.CheckPropertyNew(objSysLogEN); 
bool bolResult = clsSysLogWApi.AddNewRecord(objSysLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objSysLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysLogEN objSysLogEN, string strWhereCond)
{
try
{
clsSysLogWApi.CheckPropertyNew(objSysLogEN); 
bool bolResult = clsSysLogWApi.UpdateWithCondition(objSysLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 系统日志(SysLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSysLogWApi
{
private static readonly string mstrApiControllerName = "SysLogApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsSysLogWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSysLogEN objSysLogEN)
{
if (!Object.Equals(null, objSysLogEN.LoginTime) && GetStrLen(objSysLogEN.LoginTime) > 6)
{
 throw new Exception("字段[登陆时间]的长度不能超过6!");
}
if (!Object.Equals(null, objSysLogEN.LoginDate) && GetStrLen(objSysLogEN.LoginDate) > 8)
{
 throw new Exception("字段[登陆日期]的长度不能超过8!");
}
if (!Object.Equals(null, objSysLogEN.TableName) && GetStrLen(objSysLogEN.TableName) > 100)
{
 throw new Exception("字段[表名]的长度不能超过100!");
}
if (!Object.Equals(null, objSysLogEN.TableKey) && GetStrLen(objSysLogEN.TableKey) > 100)
{
 throw new Exception("字段[数据表关键字值]的长度不能超过100!");
}
if (!Object.Equals(null, objSysLogEN.UserIp) && GetStrLen(objSysLogEN.UserIp) > 40)
{
 throw new Exception("字段[用户IP]的长度不能超过40!");
}
if (!Object.Equals(null, objSysLogEN.OpTypeId) && GetStrLen(objSysLogEN.OpTypeId) > 4)
{
 throw new Exception("字段[操作类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSysLogEN.OpContent) && GetStrLen(objSysLogEN.OpContent) > 1000)
{
 throw new Exception("字段[操作内容]的长度不能超过1000!");
}
if (!Object.Equals(null, objSysLogEN.OpDate) && GetStrLen(objSysLogEN.OpDate) > 8)
{
 throw new Exception("字段[操作日期]的长度不能超过8!");
}
if (!Object.Equals(null, objSysLogEN.OpTime) && GetStrLen(objSysLogEN.OpTime) > 6)
{
 throw new Exception("字段[操作时间]的长度不能超过6!");
}
if (!Object.Equals(null, objSysLogEN.PrjId) && GetStrLen(objSysLogEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSysLogEN.UserId) && GetStrLen(objSysLogEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objSysLogEN.Memo) && GetStrLen(objSysLogEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objSysLogEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysLogEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsSysLogEN objSysLogEN;
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
objSysLogEN = JsonConvert.DeserializeObject<clsSysLogEN>(strJson);
return objSysLogEN;
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
public static clsSysLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsSysLogEN objSysLogEN;
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
objSysLogEN = JsonConvert.DeserializeObject<clsSysLogEN>(strJson);
return objSysLogEN;
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
public static List<clsSysLogEN> GetObjLst(string strWhereCond)
{
 List<clsSysLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSysLogEN>>(strJson);
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
public static List<clsSysLogEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsSysLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSysLogEN>>(strJson);
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
public static List<clsSysLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSysLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSysLogEN>>(strJson);
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
public static List<clsSysLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSysLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSysLogEN>>(strJson);
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
public static List<clsSysLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSysLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSysLogEN>>(strJson);
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
public static List<clsSysLogEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsSysLogEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSysLogEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsSysLogEN objSysLogEN = clsSysLogWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelSysLogs(List<string> arrmId)
{
string strAction = "DelSysLogs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelSysLogsByCond(string strWhereCond)
{
string strAction = "DelSysLogsByCond";
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
public static bool AddNewRecord(clsSysLogEN objSysLogEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSysLogEN>(objSysLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objSysLogEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsSysLogEN objSysLogEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSysLogEN>(objSysLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsSysLogEN objSysLogEN)
{
if (string.IsNullOrEmpty(objSysLogEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSysLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSysLogEN>(objSysLogEN);
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
 /// <param name = "objSysLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSysLogEN objSysLogEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSysLogEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSysLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSysLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSysLogEN>(objSysLogEN);
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
 /// <param name = "objSysLogENS">源对象</param>
 /// <param name = "objSysLogENT">目标对象</param>
 public static void CopyTo(clsSysLogEN objSysLogENS, clsSysLogEN objSysLogENT)
{
try
{
objSysLogENT.mId = objSysLogENS.mId; //mId
objSysLogENT.LoginTime = objSysLogENS.LoginTime; //登陆时间
objSysLogENT.LoginDate = objSysLogENS.LoginDate; //登陆日期
objSysLogENT.TableName = objSysLogENS.TableName; //表名
objSysLogENT.TableKey = objSysLogENS.TableKey; //数据表关键字值
objSysLogENT.UserIp = objSysLogENS.UserIp; //用户IP
objSysLogENT.OpTypeId = objSysLogENS.OpTypeId; //操作类型Id
objSysLogENT.OpContent = objSysLogENS.OpContent; //操作内容
objSysLogENT.OpDate = objSysLogENS.OpDate; //操作日期
objSysLogENT.OpTime = objSysLogENS.OpTime; //操作时间
objSysLogENT.PrjId = objSysLogENS.PrjId; //工程Id
objSysLogENT.UserId = objSysLogENS.UserId; //用户Id
objSysLogENT.Memo = objSysLogENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsSysLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSysLogEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSysLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSysLogEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSysLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSysLogEN._AttributeName)
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
string strKey = string.Format("{0}", clsSysLogEN._CurrTabName);
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
if (clsSysLogWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysLogWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsSysLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSysLog.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conSysLog.LoginTime, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.LoginDate, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.TableName, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.TableKey, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.UserIp, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.OpTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.OpContent, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.OpDate, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.OpTime, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conSysLog.Memo, Type.GetType("System.String"));
foreach (clsSysLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSysLog.mId] = objInFor[conSysLog.mId];
objDR[conSysLog.LoginTime] = objInFor[conSysLog.LoginTime];
objDR[conSysLog.LoginDate] = objInFor[conSysLog.LoginDate];
objDR[conSysLog.TableName] = objInFor[conSysLog.TableName];
objDR[conSysLog.TableKey] = objInFor[conSysLog.TableKey];
objDR[conSysLog.UserIp] = objInFor[conSysLog.UserIp];
objDR[conSysLog.OpTypeId] = objInFor[conSysLog.OpTypeId];
objDR[conSysLog.OpContent] = objInFor[conSysLog.OpContent];
objDR[conSysLog.OpDate] = objInFor[conSysLog.OpDate];
objDR[conSysLog.OpTime] = objInFor[conSysLog.OpTime];
objDR[conSysLog.PrjId] = objInFor[conSysLog.PrjId];
objDR[conSysLog.UserId] = objInFor[conSysLog.UserId];
objDR[conSysLog.Memo] = objInFor[conSysLog.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 系统日志(SysLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4SysLog : clsCommFun4BL
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
clsSysLogWApi.ReFreshThisCache();
}
}

}