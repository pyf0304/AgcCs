
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCopyTaskWApi
 表名:CopyTask(00050643)
 * 版本:2026.04.01.1(服务器:WIN-SRV103-116)
 日期:2026/04/05 23:20:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsCopyTaskWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "lngTaskId">TaskId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetTaskId(this clsCopyTaskEN objCopyTaskEN, long lngTaskId, string strComparisonOp="")
	{
objCopyTaskEN.TaskId = lngTaskId; //TaskId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.TaskId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.TaskId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.TaskId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strSourcePrjId">SourcePrjId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetSourcePrjId(this clsCopyTaskEN objCopyTaskEN, string strSourcePrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourcePrjId, conCopyTask.SourcePrjId);
clsCheckSql.CheckFieldLen(strSourcePrjId, 4, conCopyTask.SourcePrjId);
clsCheckSql.CheckFieldForeignKey(strSourcePrjId, 4, conCopyTask.SourcePrjId);
objCopyTaskEN.SourcePrjId = strSourcePrjId; //SourcePrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.SourcePrjId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.SourcePrjId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.SourcePrjId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strTargetPrjId">TargetPrjId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetTargetPrjId(this clsCopyTaskEN objCopyTaskEN, string strTargetPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTargetPrjId, conCopyTask.TargetPrjId);
clsCheckSql.CheckFieldLen(strTargetPrjId, 4, conCopyTask.TargetPrjId);
clsCheckSql.CheckFieldForeignKey(strTargetPrjId, 4, conCopyTask.TargetPrjId);
objCopyTaskEN.TargetPrjId = strTargetPrjId; //TargetPrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.TargetPrjId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.TargetPrjId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.TargetPrjId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strSourceViewId">SourceViewId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetSourceViewId(this clsCopyTaskEN objCopyTaskEN, string strSourceViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceViewId, conCopyTask.SourceViewId);
clsCheckSql.CheckFieldLen(strSourceViewId, 8, conCopyTask.SourceViewId);
clsCheckSql.CheckFieldForeignKey(strSourceViewId, 8, conCopyTask.SourceViewId);
objCopyTaskEN.SourceViewId = strSourceViewId; //SourceViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.SourceViewId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.SourceViewId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.SourceViewId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strTargetViewId">TargetViewId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetTargetViewId(this clsCopyTaskEN objCopyTaskEN, string strTargetViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTargetViewId, 8, conCopyTask.TargetViewId);
clsCheckSql.CheckFieldForeignKey(strTargetViewId, 8, conCopyTask.TargetViewId);
objCopyTaskEN.TargetViewId = strTargetViewId; //TargetViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.TargetViewId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.TargetViewId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.TargetViewId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strConflictStrategy">ConflictStrategy</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetConflictStrategy(this clsCopyTaskEN objCopyTaskEN, string strConflictStrategy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConflictStrategy, conCopyTask.ConflictStrategy);
clsCheckSql.CheckFieldLen(strConflictStrategy, 20, conCopyTask.ConflictStrategy);
objCopyTaskEN.ConflictStrategy = strConflictStrategy; //ConflictStrategy
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.ConflictStrategy) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.ConflictStrategy, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.ConflictStrategy] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strStatus">Status</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetStatus(this clsCopyTaskEN objCopyTaskEN, string strStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStatus, conCopyTask.Status);
clsCheckSql.CheckFieldLen(strStatus, 20, conCopyTask.Status);
objCopyTaskEN.Status = strStatus; //Status
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.Status) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.Status, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.Status] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strCurrentStep">CurrentStep</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetCurrentStep(this clsCopyTaskEN objCopyTaskEN, string strCurrentStep, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrentStep, conCopyTask.CurrentStep);
clsCheckSql.CheckFieldLen(strCurrentStep, 30, conCopyTask.CurrentStep);
objCopyTaskEN.CurrentStep = strCurrentStep; //CurrentStep
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.CurrentStep) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.CurrentStep, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.CurrentStep] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrorMessage">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetErrorMessage(this clsCopyTaskEN objCopyTaskEN, string strErrorMessage, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrorMessage, 50, conCopyTask.ErrorMessage);
objCopyTaskEN.ErrorMessage = strErrorMessage; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.ErrorMessage) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.ErrorMessage, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.ErrorMessage] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreatedBy">CreatedBy</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetCreatedBy(this clsCopyTaskEN objCopyTaskEN, string strCreatedBy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreatedBy, conCopyTask.CreatedBy);
clsCheckSql.CheckFieldLen(strCreatedBy, 50, conCopyTask.CreatedBy);
objCopyTaskEN.CreatedBy = strCreatedBy; //CreatedBy
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.CreatedBy) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.CreatedBy, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.CreatedBy] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "dteCreatedTime">CreatedTime</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetCreatedTime(this clsCopyTaskEN objCopyTaskEN, DateTime dteCreatedTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteCreatedTime, conCopyTask.CreatedTime);
objCopyTaskEN.CreatedTime = dteCreatedTime; //CreatedTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.CreatedTime) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.CreatedTime, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.CreatedTime] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "dteUpdatedTime">UpdatedTime</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetUpdatedTime(this clsCopyTaskEN objCopyTaskEN, DateTime dteUpdatedTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteUpdatedTime, conCopyTask.UpdatedTime);
objCopyTaskEN.UpdatedTime = dteUpdatedTime; //UpdatedTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.UpdatedTime) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.UpdatedTime, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.UpdatedTime] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strTargetViewName">TargetViewName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetTargetViewName(this clsCopyTaskEN objCopyTaskEN, string strTargetViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTargetViewName, 50, conCopyTask.TargetViewName);
objCopyTaskEN.TargetViewName = strTargetViewName; //TargetViewName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.TargetViewName) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.TargetViewName, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.TargetViewName] = strComparisonOp;
}
}
return objCopyTaskEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCopyTaskEN objCopyTaskCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCopyTaskCond.IsUpdated(conCopyTask.TaskId) == true)
{
string strComparisonOpTaskId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.TaskId];
strWhereCond += string.Format(" And {0} {2} {1}", conCopyTask.TaskId, objCopyTaskCond.TaskId, strComparisonOpTaskId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.SourcePrjId) == true)
{
string strComparisonOpSourcePrjId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.SourcePrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.SourcePrjId, objCopyTaskCond.SourcePrjId, strComparisonOpSourcePrjId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.TargetPrjId) == true)
{
string strComparisonOpTargetPrjId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.TargetPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.TargetPrjId, objCopyTaskCond.TargetPrjId, strComparisonOpTargetPrjId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.SourceViewId) == true)
{
string strComparisonOpSourceViewId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.SourceViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.SourceViewId, objCopyTaskCond.SourceViewId, strComparisonOpSourceViewId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.TargetViewId) == true)
{
string strComparisonOpTargetViewId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.TargetViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.TargetViewId, objCopyTaskCond.TargetViewId, strComparisonOpTargetViewId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.ConflictStrategy) == true)
{
string strComparisonOpConflictStrategy = objCopyTaskCond.dicFldComparisonOp[conCopyTask.ConflictStrategy];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.ConflictStrategy, objCopyTaskCond.ConflictStrategy, strComparisonOpConflictStrategy);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.Status) == true)
{
string strComparisonOpStatus = objCopyTaskCond.dicFldComparisonOp[conCopyTask.Status];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.Status, objCopyTaskCond.Status, strComparisonOpStatus);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.CurrentStep) == true)
{
string strComparisonOpCurrentStep = objCopyTaskCond.dicFldComparisonOp[conCopyTask.CurrentStep];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.CurrentStep, objCopyTaskCond.CurrentStep, strComparisonOpCurrentStep);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.ErrorMessage) == true)
{
string strComparisonOpErrorMessage = objCopyTaskCond.dicFldComparisonOp[conCopyTask.ErrorMessage];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.ErrorMessage, objCopyTaskCond.ErrorMessage, strComparisonOpErrorMessage);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.CreatedBy) == true)
{
string strComparisonOpCreatedBy = objCopyTaskCond.dicFldComparisonOp[conCopyTask.CreatedBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.CreatedBy, objCopyTaskCond.CreatedBy, strComparisonOpCreatedBy);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.CreatedTime) == true)
{
string strComparisonOpCreatedTime = objCopyTaskCond.dicFldComparisonOp[conCopyTask.CreatedTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.CreatedTime, objCopyTaskCond.CreatedTime, strComparisonOpCreatedTime);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.UpdatedTime) == true)
{
string strComparisonOpUpdatedTime = objCopyTaskCond.dicFldComparisonOp[conCopyTask.UpdatedTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.UpdatedTime, objCopyTaskCond.UpdatedTime, strComparisonOpUpdatedTime);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.TargetViewName) == true)
{
string strComparisonOpTargetViewName = objCopyTaskCond.dicFldComparisonOp[conCopyTask.TargetViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.TargetViewName, objCopyTaskCond.TargetViewName, strComparisonOpTargetViewName);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCopyTaskEN objCopyTaskEN)
{
 if (objCopyTaskEN.TaskId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCopyTaskEN.sfUpdFldSetStr = objCopyTaskEN.getsfUpdFldSetStr();
clsCopyTaskWApi.CheckPropertyNew(objCopyTaskEN); 
bool bolResult = clsCopyTaskWApi.UpdateRecord(objCopyTaskEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskWApi.ReFreshCache();
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
 /// 获取唯一性条件串--CopyTask(CopyTask), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SourceViewId_Status_TargetPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCopyTaskEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCopyTaskEN objCopyTaskEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCopyTaskEN == null) return "";
if (objCopyTaskEN.TaskId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SourceViewId = '{0}'", objCopyTaskEN.SourceViewId);
 sbCondition.AppendFormat(" and TargetPrjId = '{0}'", objCopyTaskEN.TargetPrjId);
 sbCondition.AppendFormat(" and Status = '{0}'", objCopyTaskEN.Status);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TaskId !=  {0}", objCopyTaskEN.TaskId);
 sbCondition.AppendFormat(" and SourceViewId = '{0}'", objCopyTaskEN.SourceViewId);
 sbCondition.AppendFormat(" and TargetPrjId = '{0}'", objCopyTaskEN.TargetPrjId);
 sbCondition.AppendFormat(" and Status = '{0}'", objCopyTaskEN.Status);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCopyTaskEN objCopyTaskEN)
{
try
{
clsCopyTaskWApi.CheckPropertyNew(objCopyTaskEN); 
bool bolResult = clsCopyTaskWApi.AddNewRecord(objCopyTaskEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskWApi.ReFreshCache();
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
 /// <param name = "objCopyTaskEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCopyTaskEN objCopyTaskEN, string strWhereCond)
{
try
{
clsCopyTaskWApi.CheckPropertyNew(objCopyTaskEN); 
bool bolResult = clsCopyTaskWApi.UpdateWithCondition(objCopyTaskEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskWApi.ReFreshCache();
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
 /// CopyTask(CopyTask)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCopyTaskWApi
{
private static readonly string mstrApiControllerName = "CopyTaskApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCopyTaskWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCopyTaskEN objCopyTaskEN)
{
if (!Object.Equals(null, objCopyTaskEN.SourcePrjId) && GetStrLen(objCopyTaskEN.SourcePrjId) > 4)
{
 throw new Exception("字段[SourcePrjId]的长度不能超过4!");
}
if (!Object.Equals(null, objCopyTaskEN.TargetPrjId) && GetStrLen(objCopyTaskEN.TargetPrjId) > 4)
{
 throw new Exception("字段[TargetPrjId]的长度不能超过4!");
}
if (!Object.Equals(null, objCopyTaskEN.SourceViewId) && GetStrLen(objCopyTaskEN.SourceViewId) > 8)
{
 throw new Exception("字段[SourceViewId]的长度不能超过8!");
}
if (!Object.Equals(null, objCopyTaskEN.TargetViewId) && GetStrLen(objCopyTaskEN.TargetViewId) > 8)
{
 throw new Exception("字段[TargetViewId]的长度不能超过8!");
}
if (!Object.Equals(null, objCopyTaskEN.ConflictStrategy) && GetStrLen(objCopyTaskEN.ConflictStrategy) > 20)
{
 throw new Exception("字段[ConflictStrategy]的长度不能超过20!");
}
if (!Object.Equals(null, objCopyTaskEN.Status) && GetStrLen(objCopyTaskEN.Status) > 20)
{
 throw new Exception("字段[Status]的长度不能超过20!");
}
if (!Object.Equals(null, objCopyTaskEN.CurrentStep) && GetStrLen(objCopyTaskEN.CurrentStep) > 30)
{
 throw new Exception("字段[CurrentStep]的长度不能超过30!");
}
if (!Object.Equals(null, objCopyTaskEN.ErrorMessage) && GetStrLen(objCopyTaskEN.ErrorMessage) > 50)
{
 throw new Exception("字段[错误信息]的长度不能超过50!");
}
if (!Object.Equals(null, objCopyTaskEN.CreatedBy) && GetStrLen(objCopyTaskEN.CreatedBy) > 50)
{
 throw new Exception("字段[CreatedBy]的长度不能超过50!");
}
if (!Object.Equals(null, objCopyTaskEN.TargetViewName) && GetStrLen(objCopyTaskEN.TargetViewName) > 50)
{
 throw new Exception("字段[TargetViewName]的长度不能超过50!");
}
 objCopyTaskEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngTaskId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCopyTaskEN GetObjByTaskId(long lngTaskId)
{
if (lngTaskId == 0) return null;
string strAction = "GetObjByTaskId";
clsCopyTaskEN objCopyTaskEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngTaskId"] = lngTaskId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCopyTaskEN = JsonConvert.DeserializeObject<clsCopyTaskEN>(strJson);
return objCopyTaskEN;
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
public static clsCopyTaskEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCopyTaskEN objCopyTaskEN;
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
objCopyTaskEN = JsonConvert.DeserializeObject<clsCopyTaskEN>(strJson);
return objCopyTaskEN;
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
 /// <param name = "lngTaskId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCopyTaskEN GetObjByTaskIdCache(long lngTaskId)
{
if (lngTaskId == 0) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCopyTaskEN._CurrTabName);
List<clsCopyTaskEN> arrCopyTaskObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskEN> arrCopyTaskObjLst_Sel =
from objCopyTaskEN in arrCopyTaskObjLstCache
where objCopyTaskEN.TaskId == lngTaskId 
select objCopyTaskEN;
if (arrCopyTaskObjLst_Sel.Count() == 0)
{
   clsCopyTaskEN obj = clsCopyTaskWApi.GetObjByTaskId(lngTaskId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCopyTaskObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskEN> GetObjLst(string strWhereCond)
{
 List<clsCopyTaskEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskEN>>(strJson);
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
 /// <param name = "arrTaskId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskEN> GetObjLstByTaskIdLst(List<long> arrTaskId)
{
 List<clsCopyTaskEN> arrObjLst; 
string strAction = "GetObjLstByTaskIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTaskId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskEN>>(strJson);
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
 /// <param name = "arrTaskId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCopyTaskEN> GetObjLstByTaskIdLstCache(List<long> arrTaskId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCopyTaskEN._CurrTabName);
List<clsCopyTaskEN> arrCopyTaskObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskEN> arrCopyTaskObjLst_Sel =
from objCopyTaskEN in arrCopyTaskObjLstCache
where arrTaskId.Contains(objCopyTaskEN.TaskId)
select objCopyTaskEN;
return arrCopyTaskObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCopyTaskEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskEN>>(strJson);
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
public static List<clsCopyTaskEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCopyTaskEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskEN>>(strJson);
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
public static List<clsCopyTaskEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCopyTaskEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskEN>>(strJson);
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
public static List<clsCopyTaskEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCopyTaskEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskEN>>(strJson);
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
public static int DelRecord(long lngTaskId)
{
string strAction = "DelRecord";
try
{
 clsCopyTaskEN objCopyTaskEN = clsCopyTaskWApi.GetObjByTaskId(lngTaskId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngTaskId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCopyTaskWApi.ReFreshCache();
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
public static int DelCopyTasks(List<string> arrTaskId)
{
string strAction = "DelCopyTasks";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTaskId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCopyTaskWApi.ReFreshCache();
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
public static int DelCopyTasksByCond(string strWhereCond)
{
string strAction = "DelCopyTasksByCond";
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
public static bool AddNewRecord(clsCopyTaskEN objCopyTaskEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCopyTaskEN>(objCopyTaskEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskWApi.ReFreshCache();
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
 /// <param name = "objCopyTaskEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCopyTaskEN objCopyTaskEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCopyTaskEN>(objCopyTaskEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCopyTaskEN objCopyTaskEN)
{
if (string.IsNullOrEmpty(objCopyTaskEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCopyTaskEN.TaskId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCopyTaskEN>(objCopyTaskEN);
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
 /// <param name = "objCopyTaskEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCopyTaskEN objCopyTaskEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCopyTaskEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCopyTaskEN.TaskId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCopyTaskEN.TaskId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCopyTaskEN>(objCopyTaskEN);
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
public static bool IsExist(long lngTaskId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngTaskId"] = lngTaskId.ToString()
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
 /// <param name = "objCopyTaskENS">源对象</param>
 /// <param name = "objCopyTaskENT">目标对象</param>
 public static void CopyTo(clsCopyTaskEN objCopyTaskENS, clsCopyTaskEN objCopyTaskENT)
{
try
{
objCopyTaskENT.TaskId = objCopyTaskENS.TaskId; //TaskId
objCopyTaskENT.SourcePrjId = objCopyTaskENS.SourcePrjId; //SourcePrjId
objCopyTaskENT.TargetPrjId = objCopyTaskENS.TargetPrjId; //TargetPrjId
objCopyTaskENT.SourceViewId = objCopyTaskENS.SourceViewId; //SourceViewId
objCopyTaskENT.TargetViewId = objCopyTaskENS.TargetViewId; //TargetViewId
objCopyTaskENT.ConflictStrategy = objCopyTaskENS.ConflictStrategy; //ConflictStrategy
objCopyTaskENT.Status = objCopyTaskENS.Status; //Status
objCopyTaskENT.CurrentStep = objCopyTaskENS.CurrentStep; //CurrentStep
objCopyTaskENT.ErrorMessage = objCopyTaskENS.ErrorMessage; //错误信息
objCopyTaskENT.CreatedBy = objCopyTaskENS.CreatedBy; //CreatedBy
objCopyTaskENT.CreatedTime = objCopyTaskENS.CreatedTime; //CreatedTime
objCopyTaskENT.UpdatedTime = objCopyTaskENS.UpdatedTime; //UpdatedTime
objCopyTaskENT.TargetViewName = objCopyTaskENS.TargetViewName; //TargetViewName
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
public static DataTable ToDataTable(List<clsCopyTaskEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCopyTaskEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCopyTaskEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCopyTaskEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCopyTaskEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCopyTaskEN._AttributeName)
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
string strKey = string.Format("{0}", clsCopyTaskEN._CurrTabName);
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
if (clsCopyTaskWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCopyTaskEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCopyTaskWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCopyTaskEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsCopyTaskEN._CurrTabName;
List<clsCopyTaskEN> arrCopyTaskObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCopyTaskObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCopyTaskEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCopyTask.TaskId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCopyTask.SourcePrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTask.TargetPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTask.SourceViewId, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTask.TargetViewId, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTask.ConflictStrategy, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTask.Status, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTask.CurrentStep, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTask.ErrorMessage, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTask.CreatedBy, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTask.CreatedTime, Type.GetType("System.DateTime"));
objDT.Columns.Add(conCopyTask.UpdatedTime, Type.GetType("System.DateTime"));
objDT.Columns.Add(conCopyTask.TargetViewName, Type.GetType("System.String"));
foreach (clsCopyTaskEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCopyTask.TaskId] = objInFor[conCopyTask.TaskId];
objDR[conCopyTask.SourcePrjId] = objInFor[conCopyTask.SourcePrjId];
objDR[conCopyTask.TargetPrjId] = objInFor[conCopyTask.TargetPrjId];
objDR[conCopyTask.SourceViewId] = objInFor[conCopyTask.SourceViewId];
objDR[conCopyTask.TargetViewId] = objInFor[conCopyTask.TargetViewId];
objDR[conCopyTask.ConflictStrategy] = objInFor[conCopyTask.ConflictStrategy];
objDR[conCopyTask.Status] = objInFor[conCopyTask.Status];
objDR[conCopyTask.CurrentStep] = objInFor[conCopyTask.CurrentStep];
objDR[conCopyTask.ErrorMessage] = objInFor[conCopyTask.ErrorMessage];
objDR[conCopyTask.CreatedBy] = objInFor[conCopyTask.CreatedBy];
objDR[conCopyTask.CreatedTime] = objInFor[conCopyTask.CreatedTime];
objDR[conCopyTask.UpdatedTime] = objInFor[conCopyTask.UpdatedTime];
objDR[conCopyTask.TargetViewName] = objInFor[conCopyTask.TargetViewName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CopyTask(CopyTask)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CopyTask : clsCommFun4BL
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
clsCopyTaskWApi.ReFreshThisCache();
}
}

}