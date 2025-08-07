
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePrjMainPath_MachineNameWApi
 表名:UserCodePrjMainPath_MachineName(00050614)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:42
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsUserCodePrjMainPath_MachineNameWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserCodePrjMainPathId">生成主目录Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetUserCodePrjMainPathId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strUserCodePrjMainPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserCodePrjMainPathId, 8, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
clsCheckSql.CheckFieldForeignKey(strUserCodePrjMainPathId, 8, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = strUserCodePrjMainPathId; //生成主目录Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strMachineName">机器名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetMachineName(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strMachineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMachineName, 50, conUserCodePrjMainPath_MachineName.MachineName);
objUserCodePrjMainPath_MachineNameEN.MachineName = strMachineName; //机器名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.MachineName) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.MachineName, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.MachineName] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodePath">代码路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetCodePath(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strCodePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePath, conUserCodePrjMainPath_MachineName.CodePath);
clsCheckSql.CheckFieldLen(strCodePath, 200, conUserCodePrjMainPath_MachineName.CodePath);
objUserCodePrjMainPath_MachineNameEN.CodePath = strCodePath; //代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.CodePath) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.CodePath, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.CodePath] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strGcPathId">GC路径Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetGcPathId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strGcPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
clsCheckSql.CheckFieldForeignKey(strGcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
objUserCodePrjMainPath_MachineNameEN.GcPathId = strGcPathId; //GC路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.GcPathId) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.GcPathId, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.GcPathId] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodePathBackup">备份代码路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetCodePathBackup(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strCodePathBackup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePathBackup, conUserCodePrjMainPath_MachineName.CodePathBackup);
clsCheckSql.CheckFieldLen(strCodePathBackup, 200, conUserCodePrjMainPath_MachineName.CodePathBackup);
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = strCodePathBackup; //备份代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.CodePathBackup) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.CodePathBackup, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.CodePathBackup] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strLogPath">日志路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetLogPath(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strLogPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLogPath, 150, conUserCodePrjMainPath_MachineName.LogPath);
objUserCodePrjMainPath_MachineNameEN.LogPath = strLogPath; //日志路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.LogPath) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.LogPath, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.LogPath] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strIncludeXmlPath">包含表Xml路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetIncludeXmlPath(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strIncludeXmlPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIncludeXmlPath, 150, conUserCodePrjMainPath_MachineName.IncludeXmlPath);
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = strIncludeXmlPath; //包含表Xml路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.IncludeXmlPath) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.IncludeXmlPath, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.IncludeXmlPath] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetPrjId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conUserCodePrjMainPath_MachineName.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conUserCodePrjMainPath_MachineName.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conUserCodePrjMainPath_MachineName.PrjId);
objUserCodePrjMainPath_MachineNameEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.PrjId) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.PrjId, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.PrjId] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetUpdDate(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserCodePrjMainPath_MachineName.UpdDate);
objUserCodePrjMainPath_MachineNameEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.UpdDate) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.UpdDate, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UpdDate] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetUpdUserId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conUserCodePrjMainPath_MachineName.UpdUserId);
objUserCodePrjMainPath_MachineNameEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.UpdUserId) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.UpdUserId, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UpdUserId] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetMemo(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserCodePrjMainPath_MachineName.Memo);
objUserCodePrjMainPath_MachineNameEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.Memo) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.Memo, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.Memo] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId) == true)
{
string strComparisonOpUserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, objUserCodePrjMainPath_MachineNameCond.UserCodePrjMainPathId, strComparisonOpUserCodePrjMainPathId);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.MachineName) == true)
{
string strComparisonOpMachineName = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.MachineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.MachineName, objUserCodePrjMainPath_MachineNameCond.MachineName, strComparisonOpMachineName);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.CodePath) == true)
{
string strComparisonOpCodePath = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.CodePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.CodePath, objUserCodePrjMainPath_MachineNameCond.CodePath, strComparisonOpCodePath);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.GcPathId) == true)
{
string strComparisonOpGcPathId = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.GcPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.GcPathId, objUserCodePrjMainPath_MachineNameCond.GcPathId, strComparisonOpGcPathId);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.CodePathBackup) == true)
{
string strComparisonOpCodePathBackup = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.CodePathBackup];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.CodePathBackup, objUserCodePrjMainPath_MachineNameCond.CodePathBackup, strComparisonOpCodePathBackup);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.LogPath) == true)
{
string strComparisonOpLogPath = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.LogPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.LogPath, objUserCodePrjMainPath_MachineNameCond.LogPath, strComparisonOpLogPath);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.IncludeXmlPath) == true)
{
string strComparisonOpIncludeXmlPath = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.IncludeXmlPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.IncludeXmlPath, objUserCodePrjMainPath_MachineNameCond.IncludeXmlPath, strComparisonOpIncludeXmlPath);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.PrjId) == true)
{
string strComparisonOpPrjId = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.PrjId, objUserCodePrjMainPath_MachineNameCond.PrjId, strComparisonOpPrjId);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.UpdDate, objUserCodePrjMainPath_MachineNameCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.UpdUserId, objUserCodePrjMainPath_MachineNameCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.Memo) == true)
{
string strComparisonOpMemo = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.Memo, objUserCodePrjMainPath_MachineNameCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objUserCodePrjMainPath_MachineNameEN.sfUpdFldSetStr = objUserCodePrjMainPath_MachineNameEN.getsfUpdFldSetStr();
clsUserCodePrjMainPath_MachineNameWApi.CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN); 
bool bolResult = clsUserCodePrjMainPath_MachineNameWApi.UpdateRecord(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameWApi.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);
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
 /// 获取唯一性条件串--UserCodePrjMainPath_MachineName(用户生成项目主路径_PC), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserCodePrjMainPathId_MachineName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserCodePrjMainPath_MachineNameEN == null) return "";
if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId == null || objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserCodePrjMainPath_MachineNameEN.MachineName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("UserCodePrjMainPathId !=  '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserCodePrjMainPath_MachineNameEN.MachineName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserCodePrjMainPath_MachineNameWApi.IsExist(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsUserCodePrjMainPath_MachineNameWApi.CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN); 
bool bolResult = clsUserCodePrjMainPath_MachineNameWApi.AddNewRecord(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameWApi.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
try
{
clsUserCodePrjMainPath_MachineNameWApi.CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN); 
string strUserCodePrjMainPathId = clsUserCodePrjMainPath_MachineNameWApi.AddNewRecordWithMaxId(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameWApi.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);
return strUserCodePrjMainPathId;
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strWhereCond)
{
try
{
clsUserCodePrjMainPath_MachineNameWApi.CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN); 
bool bolResult = clsUserCodePrjMainPath_MachineNameWApi.UpdateWithCondition(objUserCodePrjMainPath_MachineNameEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameWApi.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);
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
 /// 用户生成项目主路径_PC(UserCodePrjMainPath_MachineName)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsUserCodePrjMainPath_MachineNameWApi
{
private static readonly string mstrApiControllerName = "UserCodePrjMainPath_MachineNameApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsUserCodePrjMainPath_MachineNameWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) > 8)
{
 throw new Exception("字段[生成主目录Id]的长度不能超过8!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.MachineName) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.MachineName) > 50)
{
 throw new Exception("字段[机器名]的长度不能超过50!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.CodePath) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.CodePath) > 200)
{
 throw new Exception("字段[代码路径]的长度不能超过200!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.GcPathId) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.GcPathId) > 8)
{
 throw new Exception("字段[GC路径Id]的长度不能超过8!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.CodePathBackup) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.CodePathBackup) > 200)
{
 throw new Exception("字段[备份代码路径]的长度不能超过200!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.LogPath) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.LogPath) > 150)
{
 throw new Exception("字段[日志路径]的长度不能超过150!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath) > 150)
{
 throw new Exception("字段[包含表Xml路径]的长度不能超过150!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.PrjId) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.UpdDate) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.UpdUserId) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objUserCodePrjMainPath_MachineNameEN.Memo) && GetStrLen(objUserCodePrjMainPath_MachineNameEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objUserCodePrjMainPath_MachineNameEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strMachineName">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserCodePrjMainPath_MachineNameEN GetObjByKeyLst(string strUserCodePrjMainPathId,string strMachineName)
{
if (strUserCodePrjMainPathId == "") return null;
if (strMachineName == "") return null;
string strAction = "GetObjByKeyLst";
clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserCodePrjMainPathId"] = strUserCodePrjMainPathId,
["strMachineName"] = strMachineName,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objUserCodePrjMainPath_MachineNameEN = JsonConvert.DeserializeObject<clsUserCodePrjMainPath_MachineNameEN>(strJson);
return objUserCodePrjMainPath_MachineNameEN;
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
public static clsUserCodePrjMainPath_MachineNameEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN;
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
objUserCodePrjMainPath_MachineNameEN = JsonConvert.DeserializeObject<clsUserCodePrjMainPath_MachineNameEN>(strJson);
return objUserCodePrjMainPath_MachineNameEN;
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
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strMachineName">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserCodePrjMainPath_MachineNameEN GetObjByKeyLstCache(string strUserCodePrjMainPathId,string strMachineName,string strPrjId)
{
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true) return null;
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLst_Sel =
from objUserCodePrjMainPath_MachineNameEN in arrUserCodePrjMainPath_MachineNameObjLstCache
where objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId == strUserCodePrjMainPathId 
 && objUserCodePrjMainPath_MachineNameEN.MachineName == strMachineName 
select objUserCodePrjMainPath_MachineNameEN;
if (arrUserCodePrjMainPath_MachineNameObjLst_Sel.Count() == 0)
{
   clsUserCodePrjMainPath_MachineNameEN obj = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLst(strUserCodePrjMainPathId,strMachineName);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrUserCodePrjMainPath_MachineNameObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLst(string strWhereCond)
{
 List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPath_MachineNameEN>>(strJson);
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
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strMachineName">表关键字</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByKeyLsts(List<string> arrUserCodePrjMainPathId)
{
 List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst; 
string strAction = "GetObjLstByKeyLsts";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserCodePrjMainPathId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPath_MachineNameEN>>(strJson);
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
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strMachineName">表关键字</param>
 /// <param name = "strPrjId">分类字段值</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByKeyLstsCache(List<string> arrUserCodePrjMainPathId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLst_Sel =
from objUserCodePrjMainPath_MachineNameEN in arrUserCodePrjMainPath_MachineNameObjLstCache
where arrUserCodePrjMainPathId.Contains(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId)
select objUserCodePrjMainPath_MachineNameEN;
return arrUserCodePrjMainPath_MachineNameObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPath_MachineNameEN>>(strJson);
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPath_MachineNameEN>>(strJson);
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPath_MachineNameEN>>(strJson);
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserCodePrjMainPath_MachineNameEN>>(strJson);
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
public static int DelRecord(string strUserCodePrjMainPathId,string strMachineName)
{
string strAction = "DelRecord";
try
{
 clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLst(strUserCodePrjMainPathId,strMachineName);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strUserCodePrjMainPathId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsUserCodePrjMainPath_MachineNameWApi.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelUserCodePrjMainPath_MachineNamesByCond(string strWhereCond)
{
string strAction = "DelUserCodePrjMainPath_MachineNamesByCond";
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
public static bool AddNewRecord(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserCodePrjMainPath_MachineNameEN>(objUserCodePrjMainPath_MachineNameEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameWApi.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);
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
public static string AddNewRecordWithMaxId(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserCodePrjMainPath_MachineNameEN>(objUserCodePrjMainPath_MachineNameEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameWApi.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);
var strUserCodePrjMainPathId = (string)jobjReturn0["returnStr"];
return strUserCodePrjMainPathId;
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
public static bool UpdateRecord(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserCodePrjMainPath_MachineNameEN>(objUserCodePrjMainPath_MachineNameEN);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserCodePrjMainPath_MachineNameEN>(objUserCodePrjMainPath_MachineNameEN);
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
public static bool IsExist(string strUserCodePrjMainPathId,string strMachineName)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserCodePrjMainPathId"] = strUserCodePrjMainPathId,
["strMachineName"] = strMachineName,
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
 /// <param name = "objUserCodePrjMainPath_MachineNameENS">源对象</param>
 /// <param name = "objUserCodePrjMainPath_MachineNameENT">目标对象</param>
 public static void CopyTo(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENS, clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENT)
{
try
{
objUserCodePrjMainPath_MachineNameENT.UserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameENS.UserCodePrjMainPathId; //生成主目录Id
objUserCodePrjMainPath_MachineNameENT.MachineName = objUserCodePrjMainPath_MachineNameENS.MachineName; //机器名
objUserCodePrjMainPath_MachineNameENT.CodePath = objUserCodePrjMainPath_MachineNameENS.CodePath; //代码路径
objUserCodePrjMainPath_MachineNameENT.GcPathId = objUserCodePrjMainPath_MachineNameENS.GcPathId; //GC路径Id
objUserCodePrjMainPath_MachineNameENT.CodePathBackup = objUserCodePrjMainPath_MachineNameENS.CodePathBackup; //备份代码路径
objUserCodePrjMainPath_MachineNameENT.LogPath = objUserCodePrjMainPath_MachineNameENS.LogPath; //日志路径
objUserCodePrjMainPath_MachineNameENT.IncludeXmlPath = objUserCodePrjMainPath_MachineNameENS.IncludeXmlPath; //包含表Xml路径
objUserCodePrjMainPath_MachineNameENT.PrjId = objUserCodePrjMainPath_MachineNameENS.PrjId; //工程Id
objUserCodePrjMainPath_MachineNameENT.UpdDate = objUserCodePrjMainPath_MachineNameENS.UpdDate; //修改日期
objUserCodePrjMainPath_MachineNameENT.UpdUserId = objUserCodePrjMainPath_MachineNameENS.UpdUserId; //修改用户Id
objUserCodePrjMainPath_MachineNameENT.Memo = objUserCodePrjMainPath_MachineNameENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsUserCodePrjMainPath_MachineNameEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsUserCodePrjMainPath_MachineNameEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsUserCodePrjMainPath_MachineNameEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsUserCodePrjMainPath_MachineNameEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsUserCodePrjMainPath_MachineNameEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsUserCodePrjMainPath_MachineNameEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsUserCodePrjMainPath_MachineNameWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsUserCodePrjMainPath_MachineNameWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsUserCodePrjMainPath_MachineNameWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsUserCodePrjMainPath_MachineNameWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsUserCodePrjMainPath_MachineNameWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsUserCodePrjMainPath_MachineNameWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsUserCodePrjMainPath_MachineNameEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsUserCodePrjMainPath_MachineNameEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conUserCodePrjMainPath_MachineName.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrUserCodePrjMainPath_MachineNameObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsUserCodePrjMainPath_MachineNameWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsUserCodePrjMainPath_MachineNameWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrUserCodePrjMainPath_MachineNameObjLstCache = CacheHelper.Get<List<clsUserCodePrjMainPath_MachineNameEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrUserCodePrjMainPath_MachineNameObjLstCache = CacheHelper.Get<List<clsUserCodePrjMainPath_MachineNameEN>>(strKey);
}
return arrUserCodePrjMainPath_MachineNameObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.MachineName, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.CodePath, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.GcPathId, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.CodePathBackup, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.LogPath, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.IncludeXmlPath, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conUserCodePrjMainPath_MachineName.Memo, Type.GetType("System.String"));
foreach (clsUserCodePrjMainPath_MachineNameEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId] = objInFor[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId];
objDR[conUserCodePrjMainPath_MachineName.MachineName] = objInFor[conUserCodePrjMainPath_MachineName.MachineName];
objDR[conUserCodePrjMainPath_MachineName.CodePath] = objInFor[conUserCodePrjMainPath_MachineName.CodePath];
objDR[conUserCodePrjMainPath_MachineName.GcPathId] = objInFor[conUserCodePrjMainPath_MachineName.GcPathId];
objDR[conUserCodePrjMainPath_MachineName.CodePathBackup] = objInFor[conUserCodePrjMainPath_MachineName.CodePathBackup];
objDR[conUserCodePrjMainPath_MachineName.LogPath] = objInFor[conUserCodePrjMainPath_MachineName.LogPath];
objDR[conUserCodePrjMainPath_MachineName.IncludeXmlPath] = objInFor[conUserCodePrjMainPath_MachineName.IncludeXmlPath];
objDR[conUserCodePrjMainPath_MachineName.PrjId] = objInFor[conUserCodePrjMainPath_MachineName.PrjId];
objDR[conUserCodePrjMainPath_MachineName.UpdDate] = objInFor[conUserCodePrjMainPath_MachineName.UpdDate];
objDR[conUserCodePrjMainPath_MachineName.UpdUserId] = objInFor[conUserCodePrjMainPath_MachineName.UpdUserId];
objDR[conUserCodePrjMainPath_MachineName.Memo] = objInFor[conUserCodePrjMainPath_MachineName.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户生成项目主路径_PC(UserCodePrjMainPath_MachineName)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4UserCodePrjMainPath_MachineName : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsUserCodePrjMainPath_MachineNameWApi.ReFreshThisCache(strPrjId);
}
}

}