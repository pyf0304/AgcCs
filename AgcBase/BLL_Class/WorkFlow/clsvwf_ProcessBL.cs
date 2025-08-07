
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_ProcessBL
 表名:vwf_Process(00050492)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:24
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
public static class clsvwf_ProcessBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strProcessId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_ProcessEN GetObj(this K_ProcessId_vwf_Process myKey)
{
clsvwf_ProcessEN objvwf_ProcessEN = clsvwf_ProcessBL.vwf_ProcessDA.GetObjByProcessId(myKey.Value);
return objvwf_ProcessEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetProcessId(this clsvwf_ProcessEN objvwf_ProcessEN, string strProcessId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProcessId, 8, convwf_Process.ProcessId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProcessId, 8, convwf_Process.ProcessId);
}
objvwf_ProcessEN.ProcessId = strProcessId; //过程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.ProcessId) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.ProcessId, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.ProcessId] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetProcessName(this clsvwf_ProcessEN objvwf_ProcessEN, string strProcessName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProcessName, convwf_Process.ProcessName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProcessName, 100, convwf_Process.ProcessName);
}
objvwf_ProcessEN.ProcessName = strProcessName; //过程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.ProcessName) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.ProcessName, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.ProcessName] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetPrjId(this clsvwf_ProcessEN objvwf_ProcessEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convwf_Process.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convwf_Process.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convwf_Process.PrjId);
}
objvwf_ProcessEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.PrjId) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.PrjId, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.PrjId] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetPrjName(this clsvwf_ProcessEN objvwf_ProcessEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convwf_Process.PrjName);
}
objvwf_ProcessEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.PrjName) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.PrjName, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.PrjName] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetEndPoint(this clsvwf_ProcessEN objvwf_ProcessEN, string strEndPoint, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEndPoint, convwf_Process.EndPoint);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndPoint, 8, convwf_Process.EndPoint);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEndPoint, 8, convwf_Process.EndPoint);
}
objvwf_ProcessEN.EndPoint = strEndPoint; //终点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.EndPoint) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.EndPoint, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.EndPoint] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetStartPoint(this clsvwf_ProcessEN objvwf_ProcessEN, string strStartPoint, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStartPoint, convwf_Process.StartPoint);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartPoint, 8, convwf_Process.StartPoint);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStartPoint, 8, convwf_Process.StartPoint);
}
objvwf_ProcessEN.StartPoint = strStartPoint; //起点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.StartPoint) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.StartPoint, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.StartPoint] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetWorkPage(this clsvwf_ProcessEN objvwf_ProcessEN, string strWorkPage, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkPage, 500, convwf_Process.WorkPage);
}
objvwf_ProcessEN.WorkPage = strWorkPage; //工作页面
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.WorkPage) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.WorkPage, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.WorkPage] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetExamPhaseId(this clsvwf_ProcessEN objvwf_ProcessEN, string strExamPhaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPhaseId, convwf_Process.ExamPhaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPhaseId, 2, convwf_Process.ExamPhaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamPhaseId, 2, convwf_Process.ExamPhaseId);
}
objvwf_ProcessEN.ExamPhaseId = strExamPhaseId; //考核阶段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.ExamPhaseId) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.ExamPhaseId, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.ExamPhaseId] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetOrderNum(this clsvwf_ProcessEN objvwf_ProcessEN, int intOrderNum, string strComparisonOp="")
	{
objvwf_ProcessEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.OrderNum) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.OrderNum, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.OrderNum] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetUpdDate(this clsvwf_ProcessEN objvwf_ProcessEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convwf_Process.UpdDate);
}
objvwf_ProcessEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.UpdDate) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.UpdDate, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.UpdDate] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetUpdUser(this clsvwf_ProcessEN objvwf_ProcessEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convwf_Process.UpdUser);
}
objvwf_ProcessEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.UpdUser) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.UpdUser, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.UpdUser] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetMemo(this clsvwf_ProcessEN objvwf_ProcessEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convwf_Process.Memo);
}
objvwf_ProcessEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.Memo) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.Memo, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.Memo] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetStartPointName(this clsvwf_ProcessEN objvwf_ProcessEN, string strStartPointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartPointName, 100, convwf_Process.StartPointName);
}
objvwf_ProcessEN.StartPointName = strStartPointName; //起点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.StartPointName) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.StartPointName, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.StartPointName] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_ProcessEN SetEndPointName(this clsvwf_ProcessEN objvwf_ProcessEN, string strEndPointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndPointName, 100, convwf_Process.EndPointName);
}
objvwf_ProcessEN.EndPointName = strEndPointName; //终点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_ProcessEN.dicFldComparisonOp.ContainsKey(convwf_Process.EndPointName) == false)
{
objvwf_ProcessEN.dicFldComparisonOp.Add(convwf_Process.EndPointName, strComparisonOp);
}
else
{
objvwf_ProcessEN.dicFldComparisonOp[convwf_Process.EndPointName] = strComparisonOp;
}
}
return objvwf_ProcessEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvwf_ProcessENS">源对象</param>
 /// <param name = "objvwf_ProcessENT">目标对象</param>
 public static void CopyTo(this clsvwf_ProcessEN objvwf_ProcessENS, clsvwf_ProcessEN objvwf_ProcessENT)
{
try
{
objvwf_ProcessENT.ProcessId = objvwf_ProcessENS.ProcessId; //过程ID
objvwf_ProcessENT.ProcessName = objvwf_ProcessENS.ProcessName; //过程名称
objvwf_ProcessENT.PrjId = objvwf_ProcessENS.PrjId; //工程ID
objvwf_ProcessENT.PrjName = objvwf_ProcessENS.PrjName; //工程名称
objvwf_ProcessENT.EndPoint = objvwf_ProcessENS.EndPoint; //终点
objvwf_ProcessENT.StartPoint = objvwf_ProcessENS.StartPoint; //起点
objvwf_ProcessENT.WorkPage = objvwf_ProcessENS.WorkPage; //工作页面
objvwf_ProcessENT.ExamPhaseId = objvwf_ProcessENS.ExamPhaseId; //考核阶段Id
objvwf_ProcessENT.OrderNum = objvwf_ProcessENS.OrderNum; //序号
objvwf_ProcessENT.UpdDate = objvwf_ProcessENS.UpdDate; //修改日期
objvwf_ProcessENT.UpdUser = objvwf_ProcessENS.UpdUser; //修改者
objvwf_ProcessENT.Memo = objvwf_ProcessENS.Memo; //说明
objvwf_ProcessENT.StartPointName = objvwf_ProcessENS.StartPointName; //起点名
objvwf_ProcessENT.EndPointName = objvwf_ProcessENS.EndPointName; //终点名
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
 /// <param name = "objvwf_ProcessENS">源对象</param>
 /// <returns>目标对象=>clsvwf_ProcessEN:objvwf_ProcessENT</returns>
 public static clsvwf_ProcessEN CopyTo(this clsvwf_ProcessEN objvwf_ProcessENS)
{
try
{
 clsvwf_ProcessEN objvwf_ProcessENT = new clsvwf_ProcessEN()
{
ProcessId = objvwf_ProcessENS.ProcessId, //过程ID
ProcessName = objvwf_ProcessENS.ProcessName, //过程名称
PrjId = objvwf_ProcessENS.PrjId, //工程ID
PrjName = objvwf_ProcessENS.PrjName, //工程名称
EndPoint = objvwf_ProcessENS.EndPoint, //终点
StartPoint = objvwf_ProcessENS.StartPoint, //起点
WorkPage = objvwf_ProcessENS.WorkPage, //工作页面
ExamPhaseId = objvwf_ProcessENS.ExamPhaseId, //考核阶段Id
OrderNum = objvwf_ProcessENS.OrderNum, //序号
UpdDate = objvwf_ProcessENS.UpdDate, //修改日期
UpdUser = objvwf_ProcessENS.UpdUser, //修改者
Memo = objvwf_ProcessENS.Memo, //说明
StartPointName = objvwf_ProcessENS.StartPointName, //起点名
EndPointName = objvwf_ProcessENS.EndPointName, //终点名
};
 return objvwf_ProcessENT;
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
public static void CheckProperty4Condition(this clsvwf_ProcessEN objvwf_ProcessEN)
{
 clsvwf_ProcessBL.vwf_ProcessDA.CheckProperty4Condition(objvwf_ProcessEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvwf_ProcessEN objvwf_ProcessCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvwf_ProcessCond.IsUpdated(convwf_Process.ProcessId) == true)
{
string strComparisonOpProcessId = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.ProcessId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.ProcessId, objvwf_ProcessCond.ProcessId, strComparisonOpProcessId);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.ProcessName) == true)
{
string strComparisonOpProcessName = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.ProcessName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.ProcessName, objvwf_ProcessCond.ProcessName, strComparisonOpProcessName);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.PrjId) == true)
{
string strComparisonOpPrjId = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.PrjId, objvwf_ProcessCond.PrjId, strComparisonOpPrjId);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.PrjName) == true)
{
string strComparisonOpPrjName = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.PrjName, objvwf_ProcessCond.PrjName, strComparisonOpPrjName);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.EndPoint) == true)
{
string strComparisonOpEndPoint = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.EndPoint];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.EndPoint, objvwf_ProcessCond.EndPoint, strComparisonOpEndPoint);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.StartPoint) == true)
{
string strComparisonOpStartPoint = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.StartPoint];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.StartPoint, objvwf_ProcessCond.StartPoint, strComparisonOpStartPoint);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.WorkPage) == true)
{
string strComparisonOpWorkPage = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.WorkPage];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.WorkPage, objvwf_ProcessCond.WorkPage, strComparisonOpWorkPage);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.ExamPhaseId) == true)
{
string strComparisonOpExamPhaseId = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.ExamPhaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.ExamPhaseId, objvwf_ProcessCond.ExamPhaseId, strComparisonOpExamPhaseId);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.OrderNum) == true)
{
string strComparisonOpOrderNum = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convwf_Process.OrderNum, objvwf_ProcessCond.OrderNum, strComparisonOpOrderNum);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.UpdDate) == true)
{
string strComparisonOpUpdDate = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.UpdDate, objvwf_ProcessCond.UpdDate, strComparisonOpUpdDate);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.UpdUser) == true)
{
string strComparisonOpUpdUser = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.UpdUser, objvwf_ProcessCond.UpdUser, strComparisonOpUpdUser);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.Memo) == true)
{
string strComparisonOpMemo = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.Memo, objvwf_ProcessCond.Memo, strComparisonOpMemo);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.StartPointName) == true)
{
string strComparisonOpStartPointName = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.StartPointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.StartPointName, objvwf_ProcessCond.StartPointName, strComparisonOpStartPointName);
}
if (objvwf_ProcessCond.IsUpdated(convwf_Process.EndPointName) == true)
{
string strComparisonOpEndPointName = objvwf_ProcessCond.dicFldComparisonOp[convwf_Process.EndPointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Process.EndPointName, objvwf_ProcessCond.EndPointName, strComparisonOpEndPointName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vwf_Process
{
public virtual bool UpdRelaTabDate(string strProcessId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工作流过程(vwf_Process)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvwf_ProcessBL
{
public static RelatedActions_vwf_Process relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vwf_ProcessListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vwf_ProcessList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvwf_ProcessEN> arrvwf_ProcessObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvwf_ProcessDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvwf_ProcessDA vwf_ProcessDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvwf_ProcessDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvwf_ProcessBL()
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
if (string.IsNullOrEmpty(clsvwf_ProcessEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvwf_ProcessEN._ConnectString);
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
objDS = vwf_ProcessDA.GetDataSet(strWhereCond);
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
objDS = vwf_ProcessDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vwf_ProcessDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vwf_Process(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vwf_ProcessDA.GetDataTable_vwf_Process(strWhereCond);
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
objDT = vwf_ProcessDA.GetDataTable(strWhereCond);
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
objDT = vwf_ProcessDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vwf_ProcessDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vwf_ProcessDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vwf_ProcessDA.GetDataTable_Top(objTopPara);
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
objDT = vwf_ProcessDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vwf_ProcessDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vwf_ProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vwf_ProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vwf_ProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vwf_ProcessDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vwf_ProcessDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vwf_ProcessDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrProcessIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvwf_ProcessEN> GetObjLstByProcessIdLst(List<string> arrProcessIdLst)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrProcessIdLst, true);
 string strWhereCond = string.Format("ProcessId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrProcessIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvwf_ProcessEN> GetObjLstByProcessIdLstCache(List<string> arrProcessIdLst)
{
string strKey = string.Format("{0}", clsvwf_ProcessEN._CurrTabName);
List<clsvwf_ProcessEN> arrvwf_ProcessObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_ProcessEN> arrvwf_ProcessObjLst_Sel =
arrvwf_ProcessObjLstCache
.Where(x => arrProcessIdLst.Contains(x.ProcessId));
return arrvwf_ProcessObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_ProcessEN> GetObjLst(string strWhereCond)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
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
public static List<clsvwf_ProcessEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvwf_ProcessCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvwf_ProcessEN> GetSubObjLstCache(clsvwf_ProcessEN objvwf_ProcessCond)
{
List<clsvwf_ProcessEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_ProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_Process.AttributeName)
{
if (objvwf_ProcessCond.IsUpdated(strFldName) == false) continue;
if (objvwf_ProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_ProcessCond[strFldName].ToString());
}
else
{
if (objvwf_ProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_ProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_ProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_ProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_ProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_ProcessCond[strFldName]));
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
public static List<clsvwf_ProcessEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
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
public static List<clsvwf_ProcessEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
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
List<clsvwf_ProcessEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvwf_ProcessEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_ProcessEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvwf_ProcessEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
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
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
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
public static List<clsvwf_ProcessEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvwf_ProcessEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvwf_ProcessEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
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
public static List<clsvwf_ProcessEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
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
public static IEnumerable<clsvwf_ProcessEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvwf_ProcessEN objvwf_ProcessCond, string strOrderBy)
{
List<clsvwf_ProcessEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_ProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_Process.AttributeName)
{
if (objvwf_ProcessCond.IsUpdated(strFldName) == false) continue;
if (objvwf_ProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_ProcessCond[strFldName].ToString());
}
else
{
if (objvwf_ProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_ProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_ProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_ProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_ProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_ProcessCond[strFldName]));
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
public static IEnumerable<clsvwf_ProcessEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvwf_ProcessEN objvwf_ProcessCond = JsonConvert.DeserializeObject<clsvwf_ProcessEN>(objPagerPara.whereCond);
if (objvwf_ProcessCond.sfFldComparisonOp == null)
{
objvwf_ProcessCond.dicFldComparisonOp = null;
}
else
{
objvwf_ProcessCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvwf_ProcessCond.sfFldComparisonOp);
}
clsvwf_ProcessBL.SetUpdFlag(objvwf_ProcessCond);
 try
{
CheckProperty4Condition(objvwf_ProcessCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvwf_ProcessBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvwf_ProcessCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_ProcessEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvwf_ProcessEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
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
public static List<clsvwf_ProcessEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_ProcessEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvwf_ProcessEN> arrObjLst = new List<clsvwf_ProcessEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
try
{
objvwf_ProcessEN.ProcessId = objRow[convwf_Process.ProcessId].ToString().Trim(); //过程ID
objvwf_ProcessEN.ProcessName = objRow[convwf_Process.ProcessName].ToString().Trim(); //过程名称
objvwf_ProcessEN.PrjId = objRow[convwf_Process.PrjId].ToString().Trim(); //工程ID
objvwf_ProcessEN.PrjName = objRow[convwf_Process.PrjName] == DBNull.Value ? null : objRow[convwf_Process.PrjName].ToString().Trim(); //工程名称
objvwf_ProcessEN.EndPoint = objRow[convwf_Process.EndPoint].ToString().Trim(); //终点
objvwf_ProcessEN.StartPoint = objRow[convwf_Process.StartPoint].ToString().Trim(); //起点
objvwf_ProcessEN.WorkPage = objRow[convwf_Process.WorkPage] == DBNull.Value ? null : objRow[convwf_Process.WorkPage].ToString().Trim(); //工作页面
objvwf_ProcessEN.ExamPhaseId = objRow[convwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objvwf_ProcessEN.OrderNum = objRow[convwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_Process.OrderNum].ToString().Trim()); //序号
objvwf_ProcessEN.UpdDate = objRow[convwf_Process.UpdDate] == DBNull.Value ? null : objRow[convwf_Process.UpdDate].ToString().Trim(); //修改日期
objvwf_ProcessEN.UpdUser = objRow[convwf_Process.UpdUser] == DBNull.Value ? null : objRow[convwf_Process.UpdUser].ToString().Trim(); //修改者
objvwf_ProcessEN.Memo = objRow[convwf_Process.Memo] == DBNull.Value ? null : objRow[convwf_Process.Memo].ToString().Trim(); //说明
objvwf_ProcessEN.StartPointName = objRow[convwf_Process.StartPointName] == DBNull.Value ? null : objRow[convwf_Process.StartPointName].ToString().Trim(); //起点名
objvwf_ProcessEN.EndPointName = objRow[convwf_Process.EndPointName] == DBNull.Value ? null : objRow[convwf_Process.EndPointName].ToString().Trim(); //终点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_ProcessEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvwf_Process(ref clsvwf_ProcessEN objvwf_ProcessEN)
{
bool bolResult = vwf_ProcessDA.Getvwf_Process(ref objvwf_ProcessEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strProcessId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_ProcessEN GetObjByProcessId(string strProcessId)
{
if (strProcessId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strProcessId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strProcessId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strProcessId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvwf_ProcessEN objvwf_ProcessEN = vwf_ProcessDA.GetObjByProcessId(strProcessId);
return objvwf_ProcessEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvwf_ProcessEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvwf_ProcessEN objvwf_ProcessEN = vwf_ProcessDA.GetFirstObj(strWhereCond);
 return objvwf_ProcessEN;
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
public static clsvwf_ProcessEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvwf_ProcessEN objvwf_ProcessEN = vwf_ProcessDA.GetObjByDataRow(objRow);
 return objvwf_ProcessEN;
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
public static clsvwf_ProcessEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvwf_ProcessEN objvwf_ProcessEN = vwf_ProcessDA.GetObjByDataRow(objRow);
 return objvwf_ProcessEN;
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
 /// <param name = "strProcessId">所给的关键字</param>
 /// <param name = "lstvwf_ProcessObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_ProcessEN GetObjByProcessIdFromList(string strProcessId, List<clsvwf_ProcessEN> lstvwf_ProcessObjLst)
{
foreach (clsvwf_ProcessEN objvwf_ProcessEN in lstvwf_ProcessObjLst)
{
if (objvwf_ProcessEN.ProcessId == strProcessId)
{
return objvwf_ProcessEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strProcessId;
 try
 {
 strProcessId = new clsvwf_ProcessDA().GetFirstID(strWhereCond);
 return strProcessId;
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
 arrList = vwf_ProcessDA.GetID(strWhereCond);
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
bool bolIsExist = vwf_ProcessDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strProcessId)
{
if (string.IsNullOrEmpty(strProcessId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strProcessId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vwf_ProcessDA.IsExist(strProcessId);
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
 bolIsExist = clsvwf_ProcessDA.IsExistTable();
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
 bolIsExist = vwf_ProcessDA.IsExistTable(strTabName);
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
 /// <param name = "objvwf_ProcessENS">源对象</param>
 /// <param name = "objvwf_ProcessENT">目标对象</param>
 public static void CopyTo(clsvwf_ProcessEN objvwf_ProcessENS, clsvwf_ProcessEN objvwf_ProcessENT)
{
try
{
objvwf_ProcessENT.ProcessId = objvwf_ProcessENS.ProcessId; //过程ID
objvwf_ProcessENT.ProcessName = objvwf_ProcessENS.ProcessName; //过程名称
objvwf_ProcessENT.PrjId = objvwf_ProcessENS.PrjId; //工程ID
objvwf_ProcessENT.PrjName = objvwf_ProcessENS.PrjName; //工程名称
objvwf_ProcessENT.EndPoint = objvwf_ProcessENS.EndPoint; //终点
objvwf_ProcessENT.StartPoint = objvwf_ProcessENS.StartPoint; //起点
objvwf_ProcessENT.WorkPage = objvwf_ProcessENS.WorkPage; //工作页面
objvwf_ProcessENT.ExamPhaseId = objvwf_ProcessENS.ExamPhaseId; //考核阶段Id
objvwf_ProcessENT.OrderNum = objvwf_ProcessENS.OrderNum; //序号
objvwf_ProcessENT.UpdDate = objvwf_ProcessENS.UpdDate; //修改日期
objvwf_ProcessENT.UpdUser = objvwf_ProcessENS.UpdUser; //修改者
objvwf_ProcessENT.Memo = objvwf_ProcessENS.Memo; //说明
objvwf_ProcessENT.StartPointName = objvwf_ProcessENS.StartPointName; //起点名
objvwf_ProcessENT.EndPointName = objvwf_ProcessENS.EndPointName; //终点名
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
 /// <param name = "objvwf_ProcessEN">源简化对象</param>
 public static void SetUpdFlag(clsvwf_ProcessEN objvwf_ProcessEN)
{
try
{
objvwf_ProcessEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvwf_ProcessEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convwf_Process.ProcessId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.ProcessId = objvwf_ProcessEN.ProcessId; //过程ID
}
if (arrFldSet.Contains(convwf_Process.ProcessName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.ProcessName = objvwf_ProcessEN.ProcessName; //过程名称
}
if (arrFldSet.Contains(convwf_Process.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.PrjId = objvwf_ProcessEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convwf_Process.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.PrjName = objvwf_ProcessEN.PrjName == "[null]" ? null :  objvwf_ProcessEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convwf_Process.EndPoint, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.EndPoint = objvwf_ProcessEN.EndPoint; //终点
}
if (arrFldSet.Contains(convwf_Process.StartPoint, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.StartPoint = objvwf_ProcessEN.StartPoint; //起点
}
if (arrFldSet.Contains(convwf_Process.WorkPage, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.WorkPage = objvwf_ProcessEN.WorkPage == "[null]" ? null :  objvwf_ProcessEN.WorkPage; //工作页面
}
if (arrFldSet.Contains(convwf_Process.ExamPhaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.ExamPhaseId = objvwf_ProcessEN.ExamPhaseId; //考核阶段Id
}
if (arrFldSet.Contains(convwf_Process.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.OrderNum = objvwf_ProcessEN.OrderNum; //序号
}
if (arrFldSet.Contains(convwf_Process.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.UpdDate = objvwf_ProcessEN.UpdDate == "[null]" ? null :  objvwf_ProcessEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convwf_Process.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.UpdUser = objvwf_ProcessEN.UpdUser == "[null]" ? null :  objvwf_ProcessEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convwf_Process.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.Memo = objvwf_ProcessEN.Memo == "[null]" ? null :  objvwf_ProcessEN.Memo; //说明
}
if (arrFldSet.Contains(convwf_Process.StartPointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.StartPointName = objvwf_ProcessEN.StartPointName == "[null]" ? null :  objvwf_ProcessEN.StartPointName; //起点名
}
if (arrFldSet.Contains(convwf_Process.EndPointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_ProcessEN.EndPointName = objvwf_ProcessEN.EndPointName == "[null]" ? null :  objvwf_ProcessEN.EndPointName; //终点名
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
 /// <param name = "objvwf_ProcessEN">源简化对象</param>
 public static void AccessFldValueNull(clsvwf_ProcessEN objvwf_ProcessEN)
{
try
{
if (objvwf_ProcessEN.PrjName == "[null]") objvwf_ProcessEN.PrjName = null; //工程名称
if (objvwf_ProcessEN.WorkPage == "[null]") objvwf_ProcessEN.WorkPage = null; //工作页面
if (objvwf_ProcessEN.UpdDate == "[null]") objvwf_ProcessEN.UpdDate = null; //修改日期
if (objvwf_ProcessEN.UpdUser == "[null]") objvwf_ProcessEN.UpdUser = null; //修改者
if (objvwf_ProcessEN.Memo == "[null]") objvwf_ProcessEN.Memo = null; //说明
if (objvwf_ProcessEN.StartPointName == "[null]") objvwf_ProcessEN.StartPointName = null; //起点名
if (objvwf_ProcessEN.EndPointName == "[null]") objvwf_ProcessEN.EndPointName = null; //终点名
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
public static void CheckProperty4Condition(clsvwf_ProcessEN objvwf_ProcessEN)
{
 vwf_ProcessDA.CheckProperty4Condition(objvwf_ProcessEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_ProcessId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convwf_Process.ProcessId); 
List<clsvwf_ProcessEN> arrObjLst = clsvwf_ProcessBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN()
{
ProcessId = "0",
ProcessName = "选[v工作流过程]..."
};
arrObjLst.Insert(0, objvwf_ProcessEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convwf_Process.ProcessId;
objComboBox.DisplayMember = convwf_Process.ProcessName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlProcessId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工作流过程]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convwf_Process.ProcessId); 
IEnumerable<clsvwf_ProcessEN> arrObjLst = clsvwf_ProcessBL.GetObjLst(strCondition);
objDDL.DataValueField = convwf_Process.ProcessId;
objDDL.DataTextField = convwf_Process.ProcessName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlProcessIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工作流过程]...","0");
List<clsvwf_ProcessEN> arrvwf_ProcessObjLst = GetAllvwf_ProcessObjLstCache(); 
objDDL.DataValueField = convwf_Process.ProcessId;
objDDL.DataTextField = convwf_Process.ProcessName;
objDDL.DataSource = arrvwf_ProcessObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clswf_ProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_ProjectsBL没有刷新缓存机制(clswf_ProjectsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ProcessId");
//if (arrvwf_ProcessObjLstCache == null)
//{
//arrvwf_ProcessObjLstCache = vwf_ProcessDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strProcessId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_ProcessEN GetObjByProcessIdCache(string strProcessId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvwf_ProcessEN._CurrTabName);
List<clsvwf_ProcessEN> arrvwf_ProcessObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_ProcessEN> arrvwf_ProcessObjLst_Sel =
arrvwf_ProcessObjLstCache
.Where(x=> x.ProcessId == strProcessId 
);
if (arrvwf_ProcessObjLst_Sel.Count() == 0)
{
   clsvwf_ProcessEN obj = clsvwf_ProcessBL.GetObjByProcessId(strProcessId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvwf_ProcessObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProcessId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetProcessNameByProcessIdCache(string strProcessId)
{
if (string.IsNullOrEmpty(strProcessId) == true) return "";
//获取缓存中的对象列表
clsvwf_ProcessEN objvwf_Process = GetObjByProcessIdCache(strProcessId);
if (objvwf_Process == null) return "";
return objvwf_Process.ProcessName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProcessId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByProcessIdCache(string strProcessId)
{
if (string.IsNullOrEmpty(strProcessId) == true) return "";
//获取缓存中的对象列表
clsvwf_ProcessEN objvwf_Process = GetObjByProcessIdCache(strProcessId);
if (objvwf_Process == null) return "";
return objvwf_Process.ProcessName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_ProcessEN> GetAllvwf_ProcessObjLstCache()
{
//获取缓存中的对象列表
List<clsvwf_ProcessEN> arrvwf_ProcessObjLstCache = GetObjLstCache(); 
return arrvwf_ProcessObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_ProcessEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvwf_ProcessEN._CurrTabName);
List<clsvwf_ProcessEN> arrvwf_ProcessObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvwf_ProcessObjLstCache;
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
string strKey = string.Format("{0}", clsvwf_ProcessEN._CurrTabName);
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
 /// <param name = "lstvwf_ProcessObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvwf_ProcessEN> lstvwf_ProcessObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvwf_ProcessObjLst, writer);
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
 /// <param name = "lstvwf_ProcessObjLst">[clsvwf_ProcessEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvwf_ProcessEN> lstvwf_ProcessObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvwf_ProcessBL.listXmlNode);
writer.WriteStartElement(clsvwf_ProcessBL.itemsXmlNode);
foreach (clsvwf_ProcessEN objvwf_ProcessEN in lstvwf_ProcessObjLst)
{
clsvwf_ProcessBL.SerializeXML(writer, objvwf_ProcessEN);
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
 /// <param name = "objvwf_ProcessEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvwf_ProcessEN objvwf_ProcessEN)
{
writer.WriteStartElement(clsvwf_ProcessBL.itemXmlNode);
 
if (objvwf_ProcessEN.ProcessId != null)
{
writer.WriteElementString(convwf_Process.ProcessId, objvwf_ProcessEN.ProcessId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.ProcessName != null)
{
writer.WriteElementString(convwf_Process.ProcessName, objvwf_ProcessEN.ProcessName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.PrjId != null)
{
writer.WriteElementString(convwf_Process.PrjId, objvwf_ProcessEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.PrjName != null)
{
writer.WriteElementString(convwf_Process.PrjName, objvwf_ProcessEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.EndPoint != null)
{
writer.WriteElementString(convwf_Process.EndPoint, objvwf_ProcessEN.EndPoint.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.StartPoint != null)
{
writer.WriteElementString(convwf_Process.StartPoint, objvwf_ProcessEN.StartPoint.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.WorkPage != null)
{
writer.WriteElementString(convwf_Process.WorkPage, objvwf_ProcessEN.WorkPage.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.ExamPhaseId != null)
{
writer.WriteElementString(convwf_Process.ExamPhaseId, objvwf_ProcessEN.ExamPhaseId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convwf_Process.OrderNum, objvwf_ProcessEN.OrderNum.ToString());
 
if (objvwf_ProcessEN.UpdDate != null)
{
writer.WriteElementString(convwf_Process.UpdDate, objvwf_ProcessEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.UpdUser != null)
{
writer.WriteElementString(convwf_Process.UpdUser, objvwf_ProcessEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.Memo != null)
{
writer.WriteElementString(convwf_Process.Memo, objvwf_ProcessEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.StartPointName != null)
{
writer.WriteElementString(convwf_Process.StartPointName, objvwf_ProcessEN.StartPointName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_ProcessEN.EndPointName != null)
{
writer.WriteElementString(convwf_Process.EndPointName, objvwf_ProcessEN.EndPointName.ToString(CultureInfo.InvariantCulture));
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
public static clsvwf_ProcessEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
reader.Read();
while (!(reader.Name == clsvwf_ProcessBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convwf_Process.ProcessId))
{
objvwf_ProcessEN.ProcessId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.ProcessName))
{
objvwf_ProcessEN.ProcessName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.PrjId))
{
objvwf_ProcessEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.PrjName))
{
objvwf_ProcessEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.EndPoint))
{
objvwf_ProcessEN.EndPoint = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.StartPoint))
{
objvwf_ProcessEN.StartPoint = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.WorkPage))
{
objvwf_ProcessEN.WorkPage = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.ExamPhaseId))
{
objvwf_ProcessEN.ExamPhaseId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.OrderNum))
{
objvwf_ProcessEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convwf_Process.UpdDate))
{
objvwf_ProcessEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.UpdUser))
{
objvwf_ProcessEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.Memo))
{
objvwf_ProcessEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.StartPointName))
{
objvwf_ProcessEN.StartPointName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Process.EndPointName))
{
objvwf_ProcessEN.EndPointName = reader.ReadElementContentAsString();
}
}
return objvwf_ProcessEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvwf_ProcessObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvwf_ProcessEN GetObjFromXmlStr(string strvwf_ProcessObjXmlStr)
{
clsvwf_ProcessEN objvwf_ProcessEN = new clsvwf_ProcessEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvwf_ProcessObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvwf_ProcessBL.itemXmlNode))
{
objvwf_ProcessEN = GetObjFromXml(reader);
return objvwf_ProcessEN;
}
}
return objvwf_ProcessEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvwf_ProcessEN objvwf_ProcessEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvwf_ProcessEN);
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
public static string Func(string strInFldName, string strOutFldName, string strProcessId)
{
if (strInFldName != convwf_Process.ProcessId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convwf_Process.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convwf_Process.AttributeName));
throw new Exception(strMsg);
}
var objvwf_Process = clsvwf_ProcessBL.GetObjByProcessIdCache(strProcessId);
if (objvwf_Process == null) return "";
return objvwf_Process[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvwf_ProcessEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvwf_ProcessEN objvwf_ProcessEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvwf_ProcessEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvwf_ProcessEN[strField]);
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
 /// <param name = "lstvwf_ProcessObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvwf_ProcessEN> lstvwf_ProcessObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvwf_ProcessObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvwf_ProcessEN objvwf_ProcessEN in lstvwf_ProcessObjLst)
{
string strJSON_One = SerializeObjToJSON(objvwf_ProcessEN);
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
int intRecCount = clsvwf_ProcessDA.GetRecCount(strTabName);
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
int intRecCount = clsvwf_ProcessDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvwf_ProcessDA.GetRecCount();
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
int intRecCount = clsvwf_ProcessDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvwf_ProcessCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvwf_ProcessEN objvwf_ProcessCond)
{
List<clsvwf_ProcessEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_ProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_Process.AttributeName)
{
if (objvwf_ProcessCond.IsUpdated(strFldName) == false) continue;
if (objvwf_ProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_ProcessCond[strFldName].ToString());
}
else
{
if (objvwf_ProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_ProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_ProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_ProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_ProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_ProcessCond[strFldName]));
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
 List<string> arrList = clsvwf_ProcessDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vwf_ProcessDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vwf_ProcessDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}