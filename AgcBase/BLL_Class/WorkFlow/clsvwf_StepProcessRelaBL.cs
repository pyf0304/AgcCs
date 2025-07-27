
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_StepProcessRelaBL
 表名:vwf_StepProcessRela(00050494)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
public static class clsvwf_StepProcessRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngWorkFlowStepProcessRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_StepProcessRelaEN GetObj(this K_WorkFlowStepProcessRelaId_vwf_StepProcessRela myKey)
{
clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = clsvwf_StepProcessRelaBL.vwf_StepProcessRelaDA.GetObjByWorkFlowStepProcessRelaId(myKey.Value);
return objvwf_StepProcessRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetWorkFlowStepProcessRelaId(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, long lngWorkFlowStepProcessRelaId, string strComparisonOp="")
	{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = lngWorkFlowStepProcessRelaId; //工作流与过程关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.WorkFlowStepProcessRelaId) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.WorkFlowStepProcessRelaId, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.WorkFlowStepProcessRelaId] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetWorkFlowId(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strWorkFlowId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowId, convwf_StepProcessRela.WorkFlowId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowId, 4, convwf_StepProcessRela.WorkFlowId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkFlowId, 4, convwf_StepProcessRela.WorkFlowId);
}
objvwf_StepProcessRelaEN.WorkFlowId = strWorkFlowId; //工作流Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.WorkFlowId) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.WorkFlowId, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.WorkFlowId] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetWorkFlowName(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strWorkFlowName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowName, convwf_StepProcessRela.WorkFlowName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowName, 50, convwf_StepProcessRela.WorkFlowName);
}
objvwf_StepProcessRelaEN.WorkFlowName = strWorkFlowName; //工作流名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.WorkFlowName) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.WorkFlowName, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.WorkFlowName] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetWorkFlowNameSim(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strWorkFlowNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowNameSim, 30, convwf_StepProcessRela.WorkFlowNameSim);
}
objvwf_StepProcessRelaEN.WorkFlowNameSim = strWorkFlowNameSim; //工作流简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.WorkFlowNameSim) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.WorkFlowNameSim, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.WorkFlowNameSim] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetPrjId(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convwf_StepProcessRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convwf_StepProcessRela.PrjId);
}
objvwf_StepProcessRelaEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.PrjId) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.PrjId, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.PrjId] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetPrjName(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convwf_StepProcessRela.PrjName);
}
objvwf_StepProcessRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.PrjName) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.PrjName, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.PrjName] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetProcessId(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strProcessId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProcessId, convwf_StepProcessRela.ProcessId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProcessId, 8, convwf_StepProcessRela.ProcessId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProcessId, 8, convwf_StepProcessRela.ProcessId);
}
objvwf_StepProcessRelaEN.ProcessId = strProcessId; //过程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.ProcessId) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.ProcessId, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.ProcessId] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetProcessName(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strProcessName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProcessName, convwf_StepProcessRela.ProcessName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProcessName, 100, convwf_StepProcessRela.ProcessName);
}
objvwf_StepProcessRelaEN.ProcessName = strProcessName; //过程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.ProcessName) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.ProcessName, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.ProcessName] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetEndPoint(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strEndPoint, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEndPoint, convwf_StepProcessRela.EndPoint);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndPoint, 8, convwf_StepProcessRela.EndPoint);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEndPoint, 8, convwf_StepProcessRela.EndPoint);
}
objvwf_StepProcessRelaEN.EndPoint = strEndPoint; //终点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.EndPoint) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.EndPoint, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.EndPoint] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetStartPoint(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strStartPoint, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStartPoint, convwf_StepProcessRela.StartPoint);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartPoint, 8, convwf_StepProcessRela.StartPoint);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStartPoint, 8, convwf_StepProcessRela.StartPoint);
}
objvwf_StepProcessRelaEN.StartPoint = strStartPoint; //起点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.StartPoint) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.StartPoint, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.StartPoint] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetStartPointName(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strStartPointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartPointName, 100, convwf_StepProcessRela.StartPointName);
}
objvwf_StepProcessRelaEN.StartPointName = strStartPointName; //起点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.StartPointName) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.StartPointName, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.StartPointName] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetEndPointName(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strEndPointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndPointName, 100, convwf_StepProcessRela.EndPointName);
}
objvwf_StepProcessRelaEN.EndPointName = strEndPointName; //终点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.EndPointName) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.EndPointName, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.EndPointName] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetOrderNum(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, int intOrderNum, string strComparisonOp="")
	{
objvwf_StepProcessRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.OrderNum) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.OrderNum, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.OrderNum] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetRoleId(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, convwf_StepProcessRela.RoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convwf_StepProcessRela.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convwf_StepProcessRela.RoleId);
}
objvwf_StepProcessRelaEN.RoleId = strRoleId; //角色ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.RoleId) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.RoleId, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.RoleId] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetPageName(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strPageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, convwf_StepProcessRela.PageName);
}
objvwf_StepProcessRelaEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.PageName) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.PageName, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.PageName] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetDepartmentId(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, convwf_StepProcessRela.DepartmentId);
}
objvwf_StepProcessRelaEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.DepartmentId) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.DepartmentId, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.DepartmentId] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetUpdDate(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convwf_StepProcessRela.UpdDate);
}
objvwf_StepProcessRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.UpdDate) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.UpdDate, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.UpdDate] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetUpdUser(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convwf_StepProcessRela.UpdUser);
}
objvwf_StepProcessRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.UpdUser) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.UpdUser, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.UpdUser] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_StepProcessRelaEN SetMemo(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convwf_StepProcessRela.Memo);
}
objvwf_StepProcessRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepProcessRela.Memo) == false)
{
objvwf_StepProcessRelaEN.dicFldComparisonOp.Add(convwf_StepProcessRela.Memo, strComparisonOp);
}
else
{
objvwf_StepProcessRelaEN.dicFldComparisonOp[convwf_StepProcessRela.Memo] = strComparisonOp;
}
}
return objvwf_StepProcessRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaENS">源对象</param>
 /// <param name = "objvwf_StepProcessRelaENT">目标对象</param>
 public static void CopyTo(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENS, clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENT)
{
try
{
objvwf_StepProcessRelaENT.WorkFlowStepProcessRelaId = objvwf_StepProcessRelaENS.WorkFlowStepProcessRelaId; //工作流与过程关系Id
objvwf_StepProcessRelaENT.WorkFlowId = objvwf_StepProcessRelaENS.WorkFlowId; //工作流Id
objvwf_StepProcessRelaENT.WorkFlowName = objvwf_StepProcessRelaENS.WorkFlowName; //工作流名称
objvwf_StepProcessRelaENT.WorkFlowNameSim = objvwf_StepProcessRelaENS.WorkFlowNameSim; //工作流简称
objvwf_StepProcessRelaENT.PrjId = objvwf_StepProcessRelaENS.PrjId; //工程ID
objvwf_StepProcessRelaENT.PrjName = objvwf_StepProcessRelaENS.PrjName; //工程名称
objvwf_StepProcessRelaENT.ProcessId = objvwf_StepProcessRelaENS.ProcessId; //过程ID
objvwf_StepProcessRelaENT.ProcessName = objvwf_StepProcessRelaENS.ProcessName; //过程名称
objvwf_StepProcessRelaENT.EndPoint = objvwf_StepProcessRelaENS.EndPoint; //终点
objvwf_StepProcessRelaENT.StartPoint = objvwf_StepProcessRelaENS.StartPoint; //起点
objvwf_StepProcessRelaENT.StartPointName = objvwf_StepProcessRelaENS.StartPointName; //起点名
objvwf_StepProcessRelaENT.EndPointName = objvwf_StepProcessRelaENS.EndPointName; //终点名
objvwf_StepProcessRelaENT.OrderNum = objvwf_StepProcessRelaENS.OrderNum; //序号
objvwf_StepProcessRelaENT.RoleId = objvwf_StepProcessRelaENS.RoleId; //角色ID
objvwf_StepProcessRelaENT.PageName = objvwf_StepProcessRelaENS.PageName; //页面名称
objvwf_StepProcessRelaENT.DepartmentId = objvwf_StepProcessRelaENS.DepartmentId; //部门ID
objvwf_StepProcessRelaENT.UpdDate = objvwf_StepProcessRelaENS.UpdDate; //修改日期
objvwf_StepProcessRelaENT.UpdUser = objvwf_StepProcessRelaENS.UpdUser; //修改者
objvwf_StepProcessRelaENT.Memo = objvwf_StepProcessRelaENS.Memo; //说明
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
 /// <param name = "objvwf_StepProcessRelaENS">源对象</param>
 /// <returns>目标对象=>clsvwf_StepProcessRelaEN:objvwf_StepProcessRelaENT</returns>
 public static clsvwf_StepProcessRelaEN CopyTo(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENS)
{
try
{
 clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENT = new clsvwf_StepProcessRelaEN()
{
WorkFlowStepProcessRelaId = objvwf_StepProcessRelaENS.WorkFlowStepProcessRelaId, //工作流与过程关系Id
WorkFlowId = objvwf_StepProcessRelaENS.WorkFlowId, //工作流Id
WorkFlowName = objvwf_StepProcessRelaENS.WorkFlowName, //工作流名称
WorkFlowNameSim = objvwf_StepProcessRelaENS.WorkFlowNameSim, //工作流简称
PrjId = objvwf_StepProcessRelaENS.PrjId, //工程ID
PrjName = objvwf_StepProcessRelaENS.PrjName, //工程名称
ProcessId = objvwf_StepProcessRelaENS.ProcessId, //过程ID
ProcessName = objvwf_StepProcessRelaENS.ProcessName, //过程名称
EndPoint = objvwf_StepProcessRelaENS.EndPoint, //终点
StartPoint = objvwf_StepProcessRelaENS.StartPoint, //起点
StartPointName = objvwf_StepProcessRelaENS.StartPointName, //起点名
EndPointName = objvwf_StepProcessRelaENS.EndPointName, //终点名
OrderNum = objvwf_StepProcessRelaENS.OrderNum, //序号
RoleId = objvwf_StepProcessRelaENS.RoleId, //角色ID
PageName = objvwf_StepProcessRelaENS.PageName, //页面名称
DepartmentId = objvwf_StepProcessRelaENS.DepartmentId, //部门ID
UpdDate = objvwf_StepProcessRelaENS.UpdDate, //修改日期
UpdUser = objvwf_StepProcessRelaENS.UpdUser, //修改者
Memo = objvwf_StepProcessRelaENS.Memo, //说明
};
 return objvwf_StepProcessRelaENT;
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
public static void CheckProperty4Condition(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
 clsvwf_StepProcessRelaBL.vwf_StepProcessRelaDA.CheckProperty4Condition(objvwf_StepProcessRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvwf_StepProcessRelaEN objvwf_StepProcessRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.WorkFlowStepProcessRelaId) == true)
{
string strComparisonOpWorkFlowStepProcessRelaId = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.WorkFlowStepProcessRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", convwf_StepProcessRela.WorkFlowStepProcessRelaId, objvwf_StepProcessRelaCond.WorkFlowStepProcessRelaId, strComparisonOpWorkFlowStepProcessRelaId);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.WorkFlowId) == true)
{
string strComparisonOpWorkFlowId = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.WorkFlowId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.WorkFlowId, objvwf_StepProcessRelaCond.WorkFlowId, strComparisonOpWorkFlowId);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.WorkFlowName) == true)
{
string strComparisonOpWorkFlowName = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.WorkFlowName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.WorkFlowName, objvwf_StepProcessRelaCond.WorkFlowName, strComparisonOpWorkFlowName);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.WorkFlowNameSim) == true)
{
string strComparisonOpWorkFlowNameSim = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.WorkFlowNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.WorkFlowNameSim, objvwf_StepProcessRelaCond.WorkFlowNameSim, strComparisonOpWorkFlowNameSim);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.PrjId) == true)
{
string strComparisonOpPrjId = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.PrjId, objvwf_StepProcessRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.PrjName) == true)
{
string strComparisonOpPrjName = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.PrjName, objvwf_StepProcessRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.ProcessId) == true)
{
string strComparisonOpProcessId = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.ProcessId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.ProcessId, objvwf_StepProcessRelaCond.ProcessId, strComparisonOpProcessId);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.ProcessName) == true)
{
string strComparisonOpProcessName = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.ProcessName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.ProcessName, objvwf_StepProcessRelaCond.ProcessName, strComparisonOpProcessName);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.EndPoint) == true)
{
string strComparisonOpEndPoint = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.EndPoint];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.EndPoint, objvwf_StepProcessRelaCond.EndPoint, strComparisonOpEndPoint);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.StartPoint) == true)
{
string strComparisonOpStartPoint = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.StartPoint];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.StartPoint, objvwf_StepProcessRelaCond.StartPoint, strComparisonOpStartPoint);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.StartPointName) == true)
{
string strComparisonOpStartPointName = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.StartPointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.StartPointName, objvwf_StepProcessRelaCond.StartPointName, strComparisonOpStartPointName);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.EndPointName) == true)
{
string strComparisonOpEndPointName = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.EndPointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.EndPointName, objvwf_StepProcessRelaCond.EndPointName, strComparisonOpEndPointName);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convwf_StepProcessRela.OrderNum, objvwf_StepProcessRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.RoleId) == true)
{
string strComparisonOpRoleId = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.RoleId, objvwf_StepProcessRelaCond.RoleId, strComparisonOpRoleId);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.PageName) == true)
{
string strComparisonOpPageName = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.PageName, objvwf_StepProcessRelaCond.PageName, strComparisonOpPageName);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.DepartmentId, objvwf_StepProcessRelaCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.UpdDate, objvwf_StepProcessRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.UpdUser, objvwf_StepProcessRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvwf_StepProcessRelaCond.IsUpdated(convwf_StepProcessRela.Memo) == true)
{
string strComparisonOpMemo = objvwf_StepProcessRelaCond.dicFldComparisonOp[convwf_StepProcessRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepProcessRela.Memo, objvwf_StepProcessRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vwf_StepProcessRela
{
public virtual bool UpdRelaTabDate(long lngWorkFlowStepProcessRelaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工作流步骤过程关系(vwf_StepProcessRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvwf_StepProcessRelaBL
{
public static RelatedActions_vwf_StepProcessRela relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vwf_StepProcessRelaListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vwf_StepProcessRelaList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvwf_StepProcessRelaEN> arrvwf_StepProcessRelaObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvwf_StepProcessRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvwf_StepProcessRelaDA vwf_StepProcessRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvwf_StepProcessRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvwf_StepProcessRelaBL()
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
if (string.IsNullOrEmpty(clsvwf_StepProcessRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvwf_StepProcessRelaEN._ConnectString);
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
objDS = vwf_StepProcessRelaDA.GetDataSet(strWhereCond);
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
objDS = vwf_StepProcessRelaDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vwf_StepProcessRelaDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vwf_StepProcessRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vwf_StepProcessRelaDA.GetDataTable_vwf_StepProcessRela(strWhereCond);
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
objDT = vwf_StepProcessRelaDA.GetDataTable(strWhereCond);
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
objDT = vwf_StepProcessRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vwf_StepProcessRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vwf_StepProcessRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vwf_StepProcessRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vwf_StepProcessRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vwf_StepProcessRelaDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vwf_StepProcessRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vwf_StepProcessRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vwf_StepProcessRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vwf_StepProcessRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vwf_StepProcessRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vwf_StepProcessRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrWorkFlowStepProcessRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvwf_StepProcessRelaEN> GetObjLstByWorkFlowStepProcessRelaIdLst(List<long> arrWorkFlowStepProcessRelaIdLst)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWorkFlowStepProcessRelaIdLst);
 string strWhereCond = string.Format("WorkFlowStepProcessRelaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWorkFlowStepProcessRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvwf_StepProcessRelaEN> GetObjLstByWorkFlowStepProcessRelaIdLstCache(List<long> arrWorkFlowStepProcessRelaIdLst)
{
string strKey = string.Format("{0}", clsvwf_StepProcessRelaEN._CurrTabName);
List<clsvwf_StepProcessRelaEN> arrvwf_StepProcessRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_StepProcessRelaEN> arrvwf_StepProcessRelaObjLst_Sel =
arrvwf_StepProcessRelaObjLstCache
.Where(x => arrWorkFlowStepProcessRelaIdLst.Contains(x.WorkFlowStepProcessRelaId));
return arrvwf_StepProcessRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_StepProcessRelaEN> GetObjLst(string strWhereCond)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
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
public static List<clsvwf_StepProcessRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvwf_StepProcessRelaEN> GetSubObjLstCache(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaCond)
{
List<clsvwf_StepProcessRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_StepProcessRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_StepProcessRela.AttributeName)
{
if (objvwf_StepProcessRelaCond.IsUpdated(strFldName) == false) continue;
if (objvwf_StepProcessRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepProcessRelaCond[strFldName].ToString());
}
else
{
if (objvwf_StepProcessRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_StepProcessRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepProcessRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_StepProcessRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_StepProcessRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_StepProcessRelaCond[strFldName]));
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
public static List<clsvwf_StepProcessRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
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
public static List<clsvwf_StepProcessRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
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
List<clsvwf_StepProcessRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvwf_StepProcessRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_StepProcessRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvwf_StepProcessRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
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
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
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
public static List<clsvwf_StepProcessRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvwf_StepProcessRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvwf_StepProcessRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
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
public static List<clsvwf_StepProcessRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
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
public static IEnumerable<clsvwf_StepProcessRelaEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvwf_StepProcessRelaEN objvwf_StepProcessRelaCond, string strOrderBy)
{
List<clsvwf_StepProcessRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_StepProcessRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_StepProcessRela.AttributeName)
{
if (objvwf_StepProcessRelaCond.IsUpdated(strFldName) == false) continue;
if (objvwf_StepProcessRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepProcessRelaCond[strFldName].ToString());
}
else
{
if (objvwf_StepProcessRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_StepProcessRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepProcessRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_StepProcessRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_StepProcessRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_StepProcessRelaCond[strFldName]));
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
public static IEnumerable<clsvwf_StepProcessRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvwf_StepProcessRelaEN objvwf_StepProcessRelaCond = JsonConvert.DeserializeObject<clsvwf_StepProcessRelaEN>(objPagerPara.whereCond);
if (objvwf_StepProcessRelaCond.sfFldComparisonOp == null)
{
objvwf_StepProcessRelaCond.dicFldComparisonOp = null;
}
else
{
objvwf_StepProcessRelaCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvwf_StepProcessRelaCond.sfFldComparisonOp);
}
clsvwf_StepProcessRelaBL.SetUpdFlag(objvwf_StepProcessRelaCond);
 try
{
CheckProperty4Condition(objvwf_StepProcessRelaCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvwf_StepProcessRelaBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvwf_StepProcessRelaCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_StepProcessRelaEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvwf_StepProcessRelaEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
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
public static List<clsvwf_StepProcessRelaEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_StepProcessRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvwf_StepProcessRelaEN> arrObjLst = new List<clsvwf_StepProcessRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
try
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[convwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objvwf_StepProcessRelaEN.WorkFlowId = objRow[convwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepProcessRelaEN.WorkFlowName = objRow[convwf_StepProcessRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepProcessRelaEN.WorkFlowNameSim = objRow[convwf_StepProcessRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepProcessRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepProcessRelaEN.PrjId = objRow[convwf_StepProcessRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjId].ToString().Trim(); //工程ID
objvwf_StepProcessRelaEN.PrjName = objRow[convwf_StepProcessRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepProcessRelaEN.ProcessId = objRow[convwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objvwf_StepProcessRelaEN.ProcessName = objRow[convwf_StepProcessRela.ProcessName].ToString().Trim(); //过程名称
objvwf_StepProcessRelaEN.EndPoint = objRow[convwf_StepProcessRela.EndPoint].ToString().Trim(); //终点
objvwf_StepProcessRelaEN.StartPoint = objRow[convwf_StepProcessRela.StartPoint].ToString().Trim(); //起点
objvwf_StepProcessRelaEN.StartPointName = objRow[convwf_StepProcessRela.StartPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.StartPointName].ToString().Trim(); //起点名
objvwf_StepProcessRelaEN.EndPointName = objRow[convwf_StepProcessRela.EndPointName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.EndPointName].ToString().Trim(); //终点名
objvwf_StepProcessRelaEN.OrderNum = objRow[convwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objvwf_StepProcessRelaEN.RoleId = objRow[convwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objvwf_StepProcessRelaEN.PageName = objRow[convwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[convwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objvwf_StepProcessRelaEN.DepartmentId = objRow[convwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[convwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objvwf_StepProcessRelaEN.UpdDate = objRow[convwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepProcessRelaEN.UpdUser = objRow[convwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepProcessRelaEN.Memo = objRow[convwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[convwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepProcessRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvwf_StepProcessRela(ref clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
bool bolResult = vwf_StepProcessRelaDA.Getvwf_StepProcessRela(ref objvwf_StepProcessRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngWorkFlowStepProcessRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_StepProcessRelaEN GetObjByWorkFlowStepProcessRelaId(long lngWorkFlowStepProcessRelaId)
{
clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = vwf_StepProcessRelaDA.GetObjByWorkFlowStepProcessRelaId(lngWorkFlowStepProcessRelaId);
return objvwf_StepProcessRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvwf_StepProcessRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = vwf_StepProcessRelaDA.GetFirstObj(strWhereCond);
 return objvwf_StepProcessRelaEN;
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
public static clsvwf_StepProcessRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = vwf_StepProcessRelaDA.GetObjByDataRow(objRow);
 return objvwf_StepProcessRelaEN;
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
public static clsvwf_StepProcessRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = vwf_StepProcessRelaDA.GetObjByDataRow(objRow);
 return objvwf_StepProcessRelaEN;
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
 /// <param name = "lngWorkFlowStepProcessRelaId">所给的关键字</param>
 /// <param name = "lstvwf_StepProcessRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_StepProcessRelaEN GetObjByWorkFlowStepProcessRelaIdFromList(long lngWorkFlowStepProcessRelaId, List<clsvwf_StepProcessRelaEN> lstvwf_StepProcessRelaObjLst)
{
foreach (clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN in lstvwf_StepProcessRelaObjLst)
{
if (objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId == lngWorkFlowStepProcessRelaId)
{
return objvwf_StepProcessRelaEN;
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
 long lngWorkFlowStepProcessRelaId;
 try
 {
 lngWorkFlowStepProcessRelaId = new clsvwf_StepProcessRelaDA().GetFirstID(strWhereCond);
 return lngWorkFlowStepProcessRelaId;
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
 arrList = vwf_StepProcessRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vwf_StepProcessRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngWorkFlowStepProcessRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngWorkFlowStepProcessRelaId)
{
//检测记录是否存在
bool bolIsExist = vwf_StepProcessRelaDA.IsExist(lngWorkFlowStepProcessRelaId);
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
 bolIsExist = clsvwf_StepProcessRelaDA.IsExistTable();
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
 bolIsExist = vwf_StepProcessRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvwf_StepProcessRelaENS">源对象</param>
 /// <param name = "objvwf_StepProcessRelaENT">目标对象</param>
 public static void CopyTo(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENS, clsvwf_StepProcessRelaEN objvwf_StepProcessRelaENT)
{
try
{
objvwf_StepProcessRelaENT.WorkFlowStepProcessRelaId = objvwf_StepProcessRelaENS.WorkFlowStepProcessRelaId; //工作流与过程关系Id
objvwf_StepProcessRelaENT.WorkFlowId = objvwf_StepProcessRelaENS.WorkFlowId; //工作流Id
objvwf_StepProcessRelaENT.WorkFlowName = objvwf_StepProcessRelaENS.WorkFlowName; //工作流名称
objvwf_StepProcessRelaENT.WorkFlowNameSim = objvwf_StepProcessRelaENS.WorkFlowNameSim; //工作流简称
objvwf_StepProcessRelaENT.PrjId = objvwf_StepProcessRelaENS.PrjId; //工程ID
objvwf_StepProcessRelaENT.PrjName = objvwf_StepProcessRelaENS.PrjName; //工程名称
objvwf_StepProcessRelaENT.ProcessId = objvwf_StepProcessRelaENS.ProcessId; //过程ID
objvwf_StepProcessRelaENT.ProcessName = objvwf_StepProcessRelaENS.ProcessName; //过程名称
objvwf_StepProcessRelaENT.EndPoint = objvwf_StepProcessRelaENS.EndPoint; //终点
objvwf_StepProcessRelaENT.StartPoint = objvwf_StepProcessRelaENS.StartPoint; //起点
objvwf_StepProcessRelaENT.StartPointName = objvwf_StepProcessRelaENS.StartPointName; //起点名
objvwf_StepProcessRelaENT.EndPointName = objvwf_StepProcessRelaENS.EndPointName; //终点名
objvwf_StepProcessRelaENT.OrderNum = objvwf_StepProcessRelaENS.OrderNum; //序号
objvwf_StepProcessRelaENT.RoleId = objvwf_StepProcessRelaENS.RoleId; //角色ID
objvwf_StepProcessRelaENT.PageName = objvwf_StepProcessRelaENS.PageName; //页面名称
objvwf_StepProcessRelaENT.DepartmentId = objvwf_StepProcessRelaENS.DepartmentId; //部门ID
objvwf_StepProcessRelaENT.UpdDate = objvwf_StepProcessRelaENS.UpdDate; //修改日期
objvwf_StepProcessRelaENT.UpdUser = objvwf_StepProcessRelaENS.UpdUser; //修改者
objvwf_StepProcessRelaENT.Memo = objvwf_StepProcessRelaENS.Memo; //说明
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
 /// <param name = "objvwf_StepProcessRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
try
{
objvwf_StepProcessRelaEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvwf_StepProcessRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convwf_StepProcessRela.WorkFlowStepProcessRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId; //工作流与过程关系Id
}
if (arrFldSet.Contains(convwf_StepProcessRela.WorkFlowId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.WorkFlowId = objvwf_StepProcessRelaEN.WorkFlowId; //工作流Id
}
if (arrFldSet.Contains(convwf_StepProcessRela.WorkFlowName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.WorkFlowName = objvwf_StepProcessRelaEN.WorkFlowName; //工作流名称
}
if (arrFldSet.Contains(convwf_StepProcessRela.WorkFlowNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.WorkFlowNameSim = objvwf_StepProcessRelaEN.WorkFlowNameSim == "[null]" ? null :  objvwf_StepProcessRelaEN.WorkFlowNameSim; //工作流简称
}
if (arrFldSet.Contains(convwf_StepProcessRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.PrjId = objvwf_StepProcessRelaEN.PrjId == "[null]" ? null :  objvwf_StepProcessRelaEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convwf_StepProcessRela.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.PrjName = objvwf_StepProcessRelaEN.PrjName == "[null]" ? null :  objvwf_StepProcessRelaEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convwf_StepProcessRela.ProcessId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.ProcessId = objvwf_StepProcessRelaEN.ProcessId; //过程ID
}
if (arrFldSet.Contains(convwf_StepProcessRela.ProcessName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.ProcessName = objvwf_StepProcessRelaEN.ProcessName; //过程名称
}
if (arrFldSet.Contains(convwf_StepProcessRela.EndPoint, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.EndPoint = objvwf_StepProcessRelaEN.EndPoint; //终点
}
if (arrFldSet.Contains(convwf_StepProcessRela.StartPoint, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.StartPoint = objvwf_StepProcessRelaEN.StartPoint; //起点
}
if (arrFldSet.Contains(convwf_StepProcessRela.StartPointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.StartPointName = objvwf_StepProcessRelaEN.StartPointName == "[null]" ? null :  objvwf_StepProcessRelaEN.StartPointName; //起点名
}
if (arrFldSet.Contains(convwf_StepProcessRela.EndPointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.EndPointName = objvwf_StepProcessRelaEN.EndPointName == "[null]" ? null :  objvwf_StepProcessRelaEN.EndPointName; //终点名
}
if (arrFldSet.Contains(convwf_StepProcessRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.OrderNum = objvwf_StepProcessRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convwf_StepProcessRela.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.RoleId = objvwf_StepProcessRelaEN.RoleId; //角色ID
}
if (arrFldSet.Contains(convwf_StepProcessRela.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.PageName = objvwf_StepProcessRelaEN.PageName == "[null]" ? null :  objvwf_StepProcessRelaEN.PageName; //页面名称
}
if (arrFldSet.Contains(convwf_StepProcessRela.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.DepartmentId = objvwf_StepProcessRelaEN.DepartmentId == "[null]" ? null :  objvwf_StepProcessRelaEN.DepartmentId; //部门ID
}
if (arrFldSet.Contains(convwf_StepProcessRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.UpdDate = objvwf_StepProcessRelaEN.UpdDate == "[null]" ? null :  objvwf_StepProcessRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convwf_StepProcessRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.UpdUser = objvwf_StepProcessRelaEN.UpdUser == "[null]" ? null :  objvwf_StepProcessRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convwf_StepProcessRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepProcessRelaEN.Memo = objvwf_StepProcessRelaEN.Memo == "[null]" ? null :  objvwf_StepProcessRelaEN.Memo; //说明
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
 /// <param name = "objvwf_StepProcessRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
try
{
if (objvwf_StepProcessRelaEN.WorkFlowNameSim == "[null]") objvwf_StepProcessRelaEN.WorkFlowNameSim = null; //工作流简称
if (objvwf_StepProcessRelaEN.PrjId == "[null]") objvwf_StepProcessRelaEN.PrjId = null; //工程ID
if (objvwf_StepProcessRelaEN.PrjName == "[null]") objvwf_StepProcessRelaEN.PrjName = null; //工程名称
if (objvwf_StepProcessRelaEN.StartPointName == "[null]") objvwf_StepProcessRelaEN.StartPointName = null; //起点名
if (objvwf_StepProcessRelaEN.EndPointName == "[null]") objvwf_StepProcessRelaEN.EndPointName = null; //终点名
if (objvwf_StepProcessRelaEN.PageName == "[null]") objvwf_StepProcessRelaEN.PageName = null; //页面名称
if (objvwf_StepProcessRelaEN.DepartmentId == "[null]") objvwf_StepProcessRelaEN.DepartmentId = null; //部门ID
if (objvwf_StepProcessRelaEN.UpdDate == "[null]") objvwf_StepProcessRelaEN.UpdDate = null; //修改日期
if (objvwf_StepProcessRelaEN.UpdUser == "[null]") objvwf_StepProcessRelaEN.UpdUser = null; //修改者
if (objvwf_StepProcessRelaEN.Memo == "[null]") objvwf_StepProcessRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
 vwf_StepProcessRelaDA.CheckProperty4Condition(objvwf_StepProcessRelaEN);
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
if (clswf_StepProcessRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_StepProcessRelaBL没有刷新缓存机制(clswf_StepProcessRelaBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clswf_WorkFlowBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_WorkFlowBL没有刷新缓存机制(clswf_WorkFlowBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clswf_ProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_ProjectsBL没有刷新缓存机制(clswf_ProjectsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clswf_ProcessBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_ProcessBL没有刷新缓存机制(clswf_ProcessBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clswf_PointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_PointBL没有刷新缓存机制(clswf_PointBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WorkFlowStepProcessRelaId");
//if (arrvwf_StepProcessRelaObjLstCache == null)
//{
//arrvwf_StepProcessRelaObjLstCache = vwf_StepProcessRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngWorkFlowStepProcessRelaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_StepProcessRelaEN GetObjByWorkFlowStepProcessRelaIdCache(long lngWorkFlowStepProcessRelaId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvwf_StepProcessRelaEN._CurrTabName);
List<clsvwf_StepProcessRelaEN> arrvwf_StepProcessRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_StepProcessRelaEN> arrvwf_StepProcessRelaObjLst_Sel =
arrvwf_StepProcessRelaObjLstCache
.Where(x=> x.WorkFlowStepProcessRelaId == lngWorkFlowStepProcessRelaId 
);
if (arrvwf_StepProcessRelaObjLst_Sel.Count() == 0)
{
   clsvwf_StepProcessRelaEN obj = clsvwf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(lngWorkFlowStepProcessRelaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvwf_StepProcessRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_StepProcessRelaEN> GetAllvwf_StepProcessRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvwf_StepProcessRelaEN> arrvwf_StepProcessRelaObjLstCache = GetObjLstCache(); 
return arrvwf_StepProcessRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_StepProcessRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvwf_StepProcessRelaEN._CurrTabName);
List<clsvwf_StepProcessRelaEN> arrvwf_StepProcessRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvwf_StepProcessRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvwf_StepProcessRelaEN._CurrTabName);
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
 /// <param name = "lstvwf_StepProcessRelaObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvwf_StepProcessRelaEN> lstvwf_StepProcessRelaObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvwf_StepProcessRelaObjLst, writer);
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
 /// <param name = "lstvwf_StepProcessRelaObjLst">[clsvwf_StepProcessRelaEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvwf_StepProcessRelaEN> lstvwf_StepProcessRelaObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvwf_StepProcessRelaBL.listXmlNode);
writer.WriteStartElement(clsvwf_StepProcessRelaBL.itemsXmlNode);
foreach (clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN in lstvwf_StepProcessRelaObjLst)
{
clsvwf_StepProcessRelaBL.SerializeXML(writer, objvwf_StepProcessRelaEN);
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
 /// <param name = "objvwf_StepProcessRelaEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
writer.WriteStartElement(clsvwf_StepProcessRelaBL.itemXmlNode);
 
writer.WriteElementString(convwf_StepProcessRela.WorkFlowStepProcessRelaId, objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId.ToString(CultureInfo.InvariantCulture));
 
if (objvwf_StepProcessRelaEN.WorkFlowId != null)
{
writer.WriteElementString(convwf_StepProcessRela.WorkFlowId, objvwf_StepProcessRelaEN.WorkFlowId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.WorkFlowName != null)
{
writer.WriteElementString(convwf_StepProcessRela.WorkFlowName, objvwf_StepProcessRelaEN.WorkFlowName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.WorkFlowNameSim != null)
{
writer.WriteElementString(convwf_StepProcessRela.WorkFlowNameSim, objvwf_StepProcessRelaEN.WorkFlowNameSim.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.PrjId != null)
{
writer.WriteElementString(convwf_StepProcessRela.PrjId, objvwf_StepProcessRelaEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.PrjName != null)
{
writer.WriteElementString(convwf_StepProcessRela.PrjName, objvwf_StepProcessRelaEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.ProcessId != null)
{
writer.WriteElementString(convwf_StepProcessRela.ProcessId, objvwf_StepProcessRelaEN.ProcessId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.ProcessName != null)
{
writer.WriteElementString(convwf_StepProcessRela.ProcessName, objvwf_StepProcessRelaEN.ProcessName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.EndPoint != null)
{
writer.WriteElementString(convwf_StepProcessRela.EndPoint, objvwf_StepProcessRelaEN.EndPoint.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.StartPoint != null)
{
writer.WriteElementString(convwf_StepProcessRela.StartPoint, objvwf_StepProcessRelaEN.StartPoint.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.StartPointName != null)
{
writer.WriteElementString(convwf_StepProcessRela.StartPointName, objvwf_StepProcessRelaEN.StartPointName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.EndPointName != null)
{
writer.WriteElementString(convwf_StepProcessRela.EndPointName, objvwf_StepProcessRelaEN.EndPointName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convwf_StepProcessRela.OrderNum, objvwf_StepProcessRelaEN.OrderNum.ToString());
 
if (objvwf_StepProcessRelaEN.RoleId != null)
{
writer.WriteElementString(convwf_StepProcessRela.RoleId, objvwf_StepProcessRelaEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.PageName != null)
{
writer.WriteElementString(convwf_StepProcessRela.PageName, objvwf_StepProcessRelaEN.PageName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.DepartmentId != null)
{
writer.WriteElementString(convwf_StepProcessRela.DepartmentId, objvwf_StepProcessRelaEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.UpdDate != null)
{
writer.WriteElementString(convwf_StepProcessRela.UpdDate, objvwf_StepProcessRelaEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.UpdUser != null)
{
writer.WriteElementString(convwf_StepProcessRela.UpdUser, objvwf_StepProcessRelaEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_StepProcessRelaEN.Memo != null)
{
writer.WriteElementString(convwf_StepProcessRela.Memo, objvwf_StepProcessRelaEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvwf_StepProcessRelaEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
reader.Read();
while (!(reader.Name == clsvwf_StepProcessRelaBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convwf_StepProcessRela.WorkFlowStepProcessRelaId))
{
objvwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convwf_StepProcessRela.WorkFlowId))
{
objvwf_StepProcessRelaEN.WorkFlowId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.WorkFlowName))
{
objvwf_StepProcessRelaEN.WorkFlowName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.WorkFlowNameSim))
{
objvwf_StepProcessRelaEN.WorkFlowNameSim = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.PrjId))
{
objvwf_StepProcessRelaEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.PrjName))
{
objvwf_StepProcessRelaEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.ProcessId))
{
objvwf_StepProcessRelaEN.ProcessId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.ProcessName))
{
objvwf_StepProcessRelaEN.ProcessName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.EndPoint))
{
objvwf_StepProcessRelaEN.EndPoint = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.StartPoint))
{
objvwf_StepProcessRelaEN.StartPoint = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.StartPointName))
{
objvwf_StepProcessRelaEN.StartPointName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.EndPointName))
{
objvwf_StepProcessRelaEN.EndPointName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.OrderNum))
{
objvwf_StepProcessRelaEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convwf_StepProcessRela.RoleId))
{
objvwf_StepProcessRelaEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.PageName))
{
objvwf_StepProcessRelaEN.PageName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.DepartmentId))
{
objvwf_StepProcessRelaEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.UpdDate))
{
objvwf_StepProcessRelaEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.UpdUser))
{
objvwf_StepProcessRelaEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_StepProcessRela.Memo))
{
objvwf_StepProcessRelaEN.Memo = reader.ReadElementContentAsString();
}
}
return objvwf_StepProcessRelaEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvwf_StepProcessRelaObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvwf_StepProcessRelaEN GetObjFromXmlStr(string strvwf_StepProcessRelaObjXmlStr)
{
clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN = new clsvwf_StepProcessRelaEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvwf_StepProcessRelaObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvwf_StepProcessRelaBL.itemXmlNode))
{
objvwf_StepProcessRelaEN = GetObjFromXml(reader);
return objvwf_StepProcessRelaEN;
}
}
return objvwf_StepProcessRelaEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvwf_StepProcessRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngWorkFlowStepProcessRelaId)
{
if (strInFldName != convwf_StepProcessRela.WorkFlowStepProcessRelaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convwf_StepProcessRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convwf_StepProcessRela.AttributeName));
throw new Exception(strMsg);
}
var objvwf_StepProcessRela = clsvwf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaIdCache(lngWorkFlowStepProcessRelaId);
if (objvwf_StepProcessRela == null) return "";
return objvwf_StepProcessRela[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvwf_StepProcessRelaEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvwf_StepProcessRelaEN[strField]);
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
 /// <param name = "lstvwf_StepProcessRelaObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvwf_StepProcessRelaEN> lstvwf_StepProcessRelaObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvwf_StepProcessRelaObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvwf_StepProcessRelaEN objvwf_StepProcessRelaEN in lstvwf_StepProcessRelaObjLst)
{
string strJSON_One = SerializeObjToJSON(objvwf_StepProcessRelaEN);
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
int intRecCount = clsvwf_StepProcessRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvwf_StepProcessRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvwf_StepProcessRelaDA.GetRecCount();
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
int intRecCount = clsvwf_StepProcessRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvwf_StepProcessRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvwf_StepProcessRelaEN objvwf_StepProcessRelaCond)
{
List<clsvwf_StepProcessRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_StepProcessRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_StepProcessRela.AttributeName)
{
if (objvwf_StepProcessRelaCond.IsUpdated(strFldName) == false) continue;
if (objvwf_StepProcessRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepProcessRelaCond[strFldName].ToString());
}
else
{
if (objvwf_StepProcessRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_StepProcessRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepProcessRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_StepProcessRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_StepProcessRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_StepProcessRelaCond[strFldName]));
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
 List<string> arrList = clsvwf_StepProcessRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vwf_StepProcessRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vwf_StepProcessRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}