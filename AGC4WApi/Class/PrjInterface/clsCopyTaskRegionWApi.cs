
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCopyTaskRegionWApi
 表名:CopyTaskRegion(00050644)
 * 版本:2026.04.01.1(服务器:WIN-SRV103-116)
 日期:2026/04/05 23:30:34
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
public static class  clsCopyTaskRegionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "lngRowId">RowId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetRowId(this clsCopyTaskRegionEN objCopyTaskRegionEN, long lngRowId, string strComparisonOp="")
	{
objCopyTaskRegionEN.RowId = lngRowId; //RowId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.RowId) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.RowId, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.RowId] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "lngTaskId">TaskId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetTaskId(this clsCopyTaskRegionEN objCopyTaskRegionEN, long lngTaskId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngTaskId, conCopyTaskRegion.TaskId);
objCopyTaskRegionEN.TaskId = lngTaskId; //TaskId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.TaskId) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.TaskId, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.TaskId] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strSourceRegionId">SourceRegionId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetSourceRegionId(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strSourceRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceRegionId, conCopyTaskRegion.SourceRegionId);
clsCheckSql.CheckFieldLen(strSourceRegionId, 10, conCopyTaskRegion.SourceRegionId);
clsCheckSql.CheckFieldForeignKey(strSourceRegionId, 10, conCopyTaskRegion.SourceRegionId);
objCopyTaskRegionEN.SourceRegionId = strSourceRegionId; //SourceRegionId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.SourceRegionId) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.SourceRegionId, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.SourceRegionId] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strSourceClsName">SourceClsName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetSourceClsName(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strSourceClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceClsName, conCopyTaskRegion.SourceClsName);
clsCheckSql.CheckFieldLen(strSourceClsName, 100, conCopyTaskRegion.SourceClsName);
objCopyTaskRegionEN.SourceClsName = strSourceClsName; //SourceClsName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.SourceClsName) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.SourceClsName, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.SourceClsName] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strTargetRegionId">TargetRegionId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetTargetRegionId(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strTargetRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTargetRegionId, 10, conCopyTaskRegion.TargetRegionId);
clsCheckSql.CheckFieldForeignKey(strTargetRegionId, 10, conCopyTaskRegion.TargetRegionId);
objCopyTaskRegionEN.TargetRegionId = strTargetRegionId; //TargetRegionId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.TargetRegionId) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.TargetRegionId, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.TargetRegionId] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strCopyStatus">CopyStatus</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetCopyStatus(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strCopyStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCopyStatus, conCopyTaskRegion.CopyStatus);
clsCheckSql.CheckFieldLen(strCopyStatus, 20, conCopyTaskRegion.CopyStatus);
objCopyTaskRegionEN.CopyStatus = strCopyStatus; //CopyStatus
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.CopyStatus) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.CopyStatus, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.CopyStatus] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelationStatus">RelationStatus</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetRelationStatus(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strRelationStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelationStatus, conCopyTaskRegion.RelationStatus);
clsCheckSql.CheckFieldLen(strRelationStatus, 20, conCopyTaskRegion.RelationStatus);
objCopyTaskRegionEN.RelationStatus = strRelationStatus; //RelationStatus
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.RelationStatus) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.RelationStatus, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.RelationStatus] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrorMessage">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetErrorMessage(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strErrorMessage, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrorMessage, 50, conCopyTaskRegion.ErrorMessage);
objCopyTaskRegionEN.ErrorMessage = strErrorMessage; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.ErrorMessage) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.ErrorMessage, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.ErrorMessage] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "intStepOrder">StepOrder</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetStepOrder(this clsCopyTaskRegionEN objCopyTaskRegionEN, int intStepOrder, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intStepOrder, conCopyTaskRegion.StepOrder);
objCopyTaskRegionEN.StepOrder = intStepOrder; //StepOrder
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.StepOrder) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.StepOrder, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.StepOrder] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "dteUpdatedTime">UpdatedTime</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetUpdatedTime(this clsCopyTaskRegionEN objCopyTaskRegionEN, DateTime dteUpdatedTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteUpdatedTime, conCopyTaskRegion.UpdatedTime);
objCopyTaskRegionEN.UpdatedTime = dteUpdatedTime; //UpdatedTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.UpdatedTime) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.UpdatedTime, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.UpdatedTime] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCopyTaskRegionEN objCopyTaskRegionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.RowId) == true)
{
string strComparisonOpRowId = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.RowId];
strWhereCond += string.Format(" And {0} {2} {1}", conCopyTaskRegion.RowId, objCopyTaskRegionCond.RowId, strComparisonOpRowId);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.TaskId) == true)
{
string strComparisonOpTaskId = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.TaskId];
strWhereCond += string.Format(" And {0} {2} {1}", conCopyTaskRegion.TaskId, objCopyTaskRegionCond.TaskId, strComparisonOpTaskId);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.SourceRegionId) == true)
{
string strComparisonOpSourceRegionId = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.SourceRegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.SourceRegionId, objCopyTaskRegionCond.SourceRegionId, strComparisonOpSourceRegionId);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.SourceClsName) == true)
{
string strComparisonOpSourceClsName = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.SourceClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.SourceClsName, objCopyTaskRegionCond.SourceClsName, strComparisonOpSourceClsName);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.TargetRegionId) == true)
{
string strComparisonOpTargetRegionId = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.TargetRegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.TargetRegionId, objCopyTaskRegionCond.TargetRegionId, strComparisonOpTargetRegionId);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.CopyStatus) == true)
{
string strComparisonOpCopyStatus = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.CopyStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.CopyStatus, objCopyTaskRegionCond.CopyStatus, strComparisonOpCopyStatus);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.RelationStatus) == true)
{
string strComparisonOpRelationStatus = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.RelationStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.RelationStatus, objCopyTaskRegionCond.RelationStatus, strComparisonOpRelationStatus);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.ErrorMessage) == true)
{
string strComparisonOpErrorMessage = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.ErrorMessage];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.ErrorMessage, objCopyTaskRegionCond.ErrorMessage, strComparisonOpErrorMessage);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.StepOrder) == true)
{
string strComparisonOpStepOrder = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.StepOrder];
strWhereCond += string.Format(" And {0} {2} {1}", conCopyTaskRegion.StepOrder, objCopyTaskRegionCond.StepOrder, strComparisonOpStepOrder);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.UpdatedTime) == true)
{
string strComparisonOpUpdatedTime = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.UpdatedTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.UpdatedTime, objCopyTaskRegionCond.UpdatedTime, strComparisonOpUpdatedTime);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 if (objCopyTaskRegionEN.RowId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCopyTaskRegionEN.sfUpdFldSetStr = objCopyTaskRegionEN.getsfUpdFldSetStr();
clsCopyTaskRegionWApi.CheckPropertyNew(objCopyTaskRegionEN); 
bool bolResult = clsCopyTaskRegionWApi.UpdateRecord(objCopyTaskRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionWApi.ReFreshCache();
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
 /// 获取唯一性条件串--CopyTaskRegion(CopyTaskRegion), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TargetRegionId_TaskId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCopyTaskRegionEN == null) return "";
if (objCopyTaskRegionEN.RowId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TaskId = '{0}'", objCopyTaskRegionEN.TaskId);
 sbCondition.AppendFormat(" and TargetRegionId = '{0}'", objCopyTaskRegionEN.TargetRegionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RowId !=  {0}", objCopyTaskRegionEN.RowId);
 sbCondition.AppendFormat(" and TaskId = '{0}'", objCopyTaskRegionEN.TaskId);
 sbCondition.AppendFormat(" and TargetRegionId = '{0}'", objCopyTaskRegionEN.TargetRegionId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
try
{
clsCopyTaskRegionWApi.CheckPropertyNew(objCopyTaskRegionEN); 
bool bolResult = clsCopyTaskRegionWApi.AddNewRecord(objCopyTaskRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionWApi.ReFreshCache();
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
 /// <param name = "objCopyTaskRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strWhereCond)
{
try
{
clsCopyTaskRegionWApi.CheckPropertyNew(objCopyTaskRegionEN); 
bool bolResult = clsCopyTaskRegionWApi.UpdateWithCondition(objCopyTaskRegionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionWApi.ReFreshCache();
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
 /// CopyTaskRegion(CopyTaskRegion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCopyTaskRegionWApi
{
private static readonly string mstrApiControllerName = "CopyTaskRegionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCopyTaskRegionWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
if (!Object.Equals(null, objCopyTaskRegionEN.SourceRegionId) && GetStrLen(objCopyTaskRegionEN.SourceRegionId) > 10)
{
 throw new Exception("字段[SourceRegionId]的长度不能超过10!");
}
if (!Object.Equals(null, objCopyTaskRegionEN.SourceClsName) && GetStrLen(objCopyTaskRegionEN.SourceClsName) > 100)
{
 throw new Exception("字段[SourceClsName]的长度不能超过100!");
}
if (!Object.Equals(null, objCopyTaskRegionEN.TargetRegionId) && GetStrLen(objCopyTaskRegionEN.TargetRegionId) > 10)
{
 throw new Exception("字段[TargetRegionId]的长度不能超过10!");
}
if (!Object.Equals(null, objCopyTaskRegionEN.CopyStatus) && GetStrLen(objCopyTaskRegionEN.CopyStatus) > 20)
{
 throw new Exception("字段[CopyStatus]的长度不能超过20!");
}
if (!Object.Equals(null, objCopyTaskRegionEN.RelationStatus) && GetStrLen(objCopyTaskRegionEN.RelationStatus) > 20)
{
 throw new Exception("字段[RelationStatus]的长度不能超过20!");
}
if (!Object.Equals(null, objCopyTaskRegionEN.ErrorMessage) && GetStrLen(objCopyTaskRegionEN.ErrorMessage) > 50)
{
 throw new Exception("字段[错误信息]的长度不能超过50!");
}
 objCopyTaskRegionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRowId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCopyTaskRegionEN GetObjByRowId(long lngRowId)
{
if (lngRowId == 0) return null;
string strAction = "GetObjByRowId";
clsCopyTaskRegionEN objCopyTaskRegionEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRowId"] = lngRowId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCopyTaskRegionEN = JsonConvert.DeserializeObject<clsCopyTaskRegionEN>(strJson);
return objCopyTaskRegionEN;
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
public static clsCopyTaskRegionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCopyTaskRegionEN objCopyTaskRegionEN;
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
objCopyTaskRegionEN = JsonConvert.DeserializeObject<clsCopyTaskRegionEN>(strJson);
return objCopyTaskRegionEN;
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
 /// <param name = "lngRowId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCopyTaskRegionEN GetObjByRowIdCache(long lngRowId)
{
if (lngRowId == 0) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCopyTaskRegionEN._CurrTabName);
List<clsCopyTaskRegionEN> arrCopyTaskRegionObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskRegionEN> arrCopyTaskRegionObjLst_Sel =
from objCopyTaskRegionEN in arrCopyTaskRegionObjLstCache
where objCopyTaskRegionEN.RowId == lngRowId 
select objCopyTaskRegionEN;
if (arrCopyTaskRegionObjLst_Sel.Count() == 0)
{
   clsCopyTaskRegionEN obj = clsCopyTaskRegionWApi.GetObjByRowId(lngRowId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCopyTaskRegionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskRegionEN> GetObjLst(string strWhereCond)
{
 List<clsCopyTaskRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskRegionEN>>(strJson);
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
 /// <param name = "arrRowId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskRegionEN> GetObjLstByRowIdLst(List<long> arrRowId)
{
 List<clsCopyTaskRegionEN> arrObjLst; 
string strAction = "GetObjLstByRowIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRowId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskRegionEN>>(strJson);
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
 /// <param name = "arrRowId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCopyTaskRegionEN> GetObjLstByRowIdLstCache(List<long> arrRowId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCopyTaskRegionEN._CurrTabName);
List<clsCopyTaskRegionEN> arrCopyTaskRegionObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskRegionEN> arrCopyTaskRegionObjLst_Sel =
from objCopyTaskRegionEN in arrCopyTaskRegionObjLstCache
where arrRowId.Contains(objCopyTaskRegionEN.RowId)
select objCopyTaskRegionEN;
return arrCopyTaskRegionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskRegionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCopyTaskRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskRegionEN>>(strJson);
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
public static List<clsCopyTaskRegionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCopyTaskRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskRegionEN>>(strJson);
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
public static List<clsCopyTaskRegionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCopyTaskRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskRegionEN>>(strJson);
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
public static List<clsCopyTaskRegionEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCopyTaskRegionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCopyTaskRegionEN>>(strJson);
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
public static int DelRecord(long lngRowId)
{
string strAction = "DelRecord";
try
{
 clsCopyTaskRegionEN objCopyTaskRegionEN = clsCopyTaskRegionWApi.GetObjByRowId(lngRowId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngRowId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCopyTaskRegionWApi.ReFreshCache();
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
public static int DelCopyTaskRegions(List<string> arrRowId)
{
string strAction = "DelCopyTaskRegions";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRowId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCopyTaskRegionWApi.ReFreshCache();
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
public static int DelCopyTaskRegionsByCond(string strWhereCond)
{
string strAction = "DelCopyTaskRegionsByCond";
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
public static bool AddNewRecord(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCopyTaskRegionEN>(objCopyTaskRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionWApi.ReFreshCache();
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
 /// <param name = "objCopyTaskRegionEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCopyTaskRegionEN>(objCopyTaskRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
if (string.IsNullOrEmpty(objCopyTaskRegionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCopyTaskRegionEN.RowId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCopyTaskRegionEN>(objCopyTaskRegionEN);
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
 /// <param name = "objCopyTaskRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCopyTaskRegionEN objCopyTaskRegionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCopyTaskRegionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCopyTaskRegionEN.RowId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCopyTaskRegionEN.RowId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCopyTaskRegionEN>(objCopyTaskRegionEN);
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
public static bool IsExist(long lngRowId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRowId"] = lngRowId.ToString()
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
 /// <param name = "objCopyTaskRegionENS">源对象</param>
 /// <param name = "objCopyTaskRegionENT">目标对象</param>
 public static void CopyTo(clsCopyTaskRegionEN objCopyTaskRegionENS, clsCopyTaskRegionEN objCopyTaskRegionENT)
{
try
{
objCopyTaskRegionENT.RowId = objCopyTaskRegionENS.RowId; //RowId
objCopyTaskRegionENT.TaskId = objCopyTaskRegionENS.TaskId; //TaskId
objCopyTaskRegionENT.SourceRegionId = objCopyTaskRegionENS.SourceRegionId; //SourceRegionId
objCopyTaskRegionENT.SourceClsName = objCopyTaskRegionENS.SourceClsName; //SourceClsName
objCopyTaskRegionENT.TargetRegionId = objCopyTaskRegionENS.TargetRegionId; //TargetRegionId
objCopyTaskRegionENT.CopyStatus = objCopyTaskRegionENS.CopyStatus; //CopyStatus
objCopyTaskRegionENT.RelationStatus = objCopyTaskRegionENS.RelationStatus; //RelationStatus
objCopyTaskRegionENT.ErrorMessage = objCopyTaskRegionENS.ErrorMessage; //错误信息
objCopyTaskRegionENT.StepOrder = objCopyTaskRegionENS.StepOrder; //StepOrder
objCopyTaskRegionENT.UpdatedTime = objCopyTaskRegionENS.UpdatedTime; //UpdatedTime
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
public static DataTable ToDataTable(List<clsCopyTaskRegionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCopyTaskRegionEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCopyTaskRegionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCopyTaskRegionEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCopyTaskRegionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCopyTaskRegionEN._AttributeName)
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
string strKey = string.Format("{0}", clsCopyTaskRegionEN._CurrTabName);
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
if (clsCopyTaskRegionWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCopyTaskRegionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCopyTaskRegionWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCopyTaskRegionEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsCopyTaskRegionEN._CurrTabName;
List<clsCopyTaskRegionEN> arrCopyTaskRegionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCopyTaskRegionObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCopyTaskRegionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCopyTaskRegion.RowId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCopyTaskRegion.TaskId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCopyTaskRegion.SourceRegionId, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTaskRegion.SourceClsName, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTaskRegion.TargetRegionId, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTaskRegion.CopyStatus, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTaskRegion.RelationStatus, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTaskRegion.ErrorMessage, Type.GetType("System.String"));
objDT.Columns.Add(conCopyTaskRegion.StepOrder, Type.GetType("System.Int32"));
objDT.Columns.Add(conCopyTaskRegion.UpdatedTime, Type.GetType("System.DateTime"));
foreach (clsCopyTaskRegionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCopyTaskRegion.RowId] = objInFor[conCopyTaskRegion.RowId];
objDR[conCopyTaskRegion.TaskId] = objInFor[conCopyTaskRegion.TaskId];
objDR[conCopyTaskRegion.SourceRegionId] = objInFor[conCopyTaskRegion.SourceRegionId];
objDR[conCopyTaskRegion.SourceClsName] = objInFor[conCopyTaskRegion.SourceClsName];
objDR[conCopyTaskRegion.TargetRegionId] = objInFor[conCopyTaskRegion.TargetRegionId];
objDR[conCopyTaskRegion.CopyStatus] = objInFor[conCopyTaskRegion.CopyStatus];
objDR[conCopyTaskRegion.RelationStatus] = objInFor[conCopyTaskRegion.RelationStatus];
objDR[conCopyTaskRegion.ErrorMessage] = objInFor[conCopyTaskRegion.ErrorMessage];
objDR[conCopyTaskRegion.StepOrder] = objInFor[conCopyTaskRegion.StepOrder];
objDR[conCopyTaskRegion.UpdatedTime] = objInFor[conCopyTaskRegion.UpdatedTime];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CopyTaskRegion(CopyTaskRegion)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CopyTaskRegion : clsCommFun4BL
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
clsCopyTaskRegionWApi.ReFreshThisCache();
}
}

}