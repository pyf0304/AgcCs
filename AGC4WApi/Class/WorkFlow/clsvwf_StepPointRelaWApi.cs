
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_StepPointRelaWApi
 表名:vwf_StepPointRela(00050487)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
public static class  clsvwf_StepPointRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngWorkFlowStepPointRelaId">工作流与结点关系Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetWorkFlowStepPointRelaId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, long lngWorkFlowStepPointRelaId, string strComparisonOp="")
	{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = lngWorkFlowStepPointRelaId; //工作流与结点关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.WorkFlowStepPointRelaId) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.WorkFlowStepPointRelaId, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.WorkFlowStepPointRelaId] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strWorkFlowId">工作流Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetWorkFlowId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strWorkFlowId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowId, convwf_StepPointRela.WorkFlowId);
clsCheckSql.CheckFieldLen(strWorkFlowId, 4, convwf_StepPointRela.WorkFlowId);
clsCheckSql.CheckFieldForeignKey(strWorkFlowId, 4, convwf_StepPointRela.WorkFlowId);
objvwf_StepPointRelaEN.WorkFlowId = strWorkFlowId; //工作流Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.WorkFlowId) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.WorkFlowId, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.WorkFlowId] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strWorkFlowName">工作流名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetWorkFlowName(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strWorkFlowName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowName, convwf_StepPointRela.WorkFlowName);
clsCheckSql.CheckFieldLen(strWorkFlowName, 50, convwf_StepPointRela.WorkFlowName);
objvwf_StepPointRelaEN.WorkFlowName = strWorkFlowName; //工作流名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.WorkFlowName) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.WorkFlowName, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.WorkFlowName] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strWorkFlowNameSim">工作流简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetWorkFlowNameSim(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strWorkFlowNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkFlowNameSim, 30, convwf_StepPointRela.WorkFlowNameSim);
objvwf_StepPointRelaEN.WorkFlowNameSim = strWorkFlowNameSim; //工作流简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.WorkFlowNameSim) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.WorkFlowNameSim, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.WorkFlowNameSim] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPrjId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convwf_StepPointRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convwf_StepPointRela.PrjId);
objvwf_StepPointRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.PrjId) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.PrjId, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.PrjId] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPrjName(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convwf_StepPointRela.PrjName);
objvwf_StepPointRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.PrjName) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.PrjName, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.PrjName] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPointId">结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPointId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointId, convwf_StepPointRela.PointId);
clsCheckSql.CheckFieldLen(strPointId, 8, convwf_StepPointRela.PointId);
clsCheckSql.CheckFieldForeignKey(strPointId, 8, convwf_StepPointRela.PointId);
objvwf_StepPointRelaEN.PointId = strPointId; //结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.PointId) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.PointId, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.PointId] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPointName">结点名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPointName(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPointName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointName, convwf_StepPointRela.PointName);
clsCheckSql.CheckFieldLen(strPointName, 100, convwf_StepPointRela.PointName);
objvwf_StepPointRelaEN.PointName = strPointName; //结点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.PointName) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.PointName, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.PointName] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabKeyId">表关键字Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetTabKeyId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strTabKeyId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabKeyId, 50, convwf_StepPointRela.TabKeyId);
objvwf_StepPointRelaEN.TabKeyId = strTabKeyId; //表关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.TabKeyId) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.TabKeyId, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.TabKeyId] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPointTypeId">工作流结点类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPointTypeId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPointTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointTypeId, convwf_StepPointRela.PointTypeId);
clsCheckSql.CheckFieldLen(strPointTypeId, 2, convwf_StepPointRela.PointTypeId);
clsCheckSql.CheckFieldForeignKey(strPointTypeId, 2, convwf_StepPointRela.PointTypeId);
objvwf_StepPointRelaEN.PointTypeId = strPointTypeId; //工作流结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.PointTypeId) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.PointTypeId, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.PointTypeId] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPointTypeName">工作流结点类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPointTypeName(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPointTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointTypeName, convwf_StepPointRela.PointTypeName);
clsCheckSql.CheckFieldLen(strPointTypeName, 50, convwf_StepPointRela.PointTypeName);
objvwf_StepPointRelaEN.PointTypeName = strPointTypeName; //工作流结点类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.PointTypeName) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.PointTypeName, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.PointTypeName] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intLevelNo">层序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetLevelNo(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, int intLevelNo, string strComparisonOp="")
	{
objvwf_StepPointRelaEN.LevelNo = intLevelNo; //层序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.LevelNo) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.LevelNo, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.LevelNo] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intInDegree">入度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetInDegree(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, int intInDegree, string strComparisonOp="")
	{
objvwf_StepPointRelaEN.InDegree = intInDegree; //入度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.InDegree) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.InDegree, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.InDegree] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOutDegree">出度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetOutDegree(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, int intOutDegree, string strComparisonOp="")
	{
objvwf_StepPointRelaEN.OutDegree = intOutDegree; //出度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.OutDegree) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.OutDegree, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.OutDegree] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetOrderNum(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, int intOrderNum, string strComparisonOp="")
	{
objvwf_StepPointRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.OrderNum) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.OrderNum, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.OrderNum] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetUpdDate(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convwf_StepPointRela.UpdDate);
objvwf_StepPointRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.UpdDate) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.UpdDate, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.UpdDate] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetUpdUser(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convwf_StepPointRela.UpdUser);
objvwf_StepPointRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.UpdUser) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.UpdUser, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.UpdUser] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetMemo(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convwf_StepPointRela.Memo);
objvwf_StepPointRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(convwf_StepPointRela.Memo) == false)
{
objvwf_StepPointRelaEN.dicFldComparisonOp.Add(convwf_StepPointRela.Memo, strComparisonOp);
}
else
{
objvwf_StepPointRelaEN.dicFldComparisonOp[convwf_StepPointRela.Memo] = strComparisonOp;
}
}
return objvwf_StepPointRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvwf_StepPointRelaEN objvwf_StepPointRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.WorkFlowStepPointRelaId) == true)
{
string strComparisonOpWorkFlowStepPointRelaId = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.WorkFlowStepPointRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", convwf_StepPointRela.WorkFlowStepPointRelaId, objvwf_StepPointRelaCond.WorkFlowStepPointRelaId, strComparisonOpWorkFlowStepPointRelaId);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.WorkFlowId) == true)
{
string strComparisonOpWorkFlowId = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.WorkFlowId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.WorkFlowId, objvwf_StepPointRelaCond.WorkFlowId, strComparisonOpWorkFlowId);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.WorkFlowName) == true)
{
string strComparisonOpWorkFlowName = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.WorkFlowName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.WorkFlowName, objvwf_StepPointRelaCond.WorkFlowName, strComparisonOpWorkFlowName);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.WorkFlowNameSim) == true)
{
string strComparisonOpWorkFlowNameSim = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.WorkFlowNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.WorkFlowNameSim, objvwf_StepPointRelaCond.WorkFlowNameSim, strComparisonOpWorkFlowNameSim);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.PrjId) == true)
{
string strComparisonOpPrjId = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.PrjId, objvwf_StepPointRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.PrjName) == true)
{
string strComparisonOpPrjName = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.PrjName, objvwf_StepPointRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.PointId) == true)
{
string strComparisonOpPointId = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.PointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.PointId, objvwf_StepPointRelaCond.PointId, strComparisonOpPointId);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.PointName) == true)
{
string strComparisonOpPointName = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.PointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.PointName, objvwf_StepPointRelaCond.PointName, strComparisonOpPointName);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.TabKeyId) == true)
{
string strComparisonOpTabKeyId = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.TabKeyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.TabKeyId, objvwf_StepPointRelaCond.TabKeyId, strComparisonOpTabKeyId);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.PointTypeId) == true)
{
string strComparisonOpPointTypeId = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.PointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.PointTypeId, objvwf_StepPointRelaCond.PointTypeId, strComparisonOpPointTypeId);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.PointTypeName) == true)
{
string strComparisonOpPointTypeName = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.PointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.PointTypeName, objvwf_StepPointRelaCond.PointTypeName, strComparisonOpPointTypeName);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.LevelNo) == true)
{
string strComparisonOpLevelNo = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", convwf_StepPointRela.LevelNo, objvwf_StepPointRelaCond.LevelNo, strComparisonOpLevelNo);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.InDegree) == true)
{
string strComparisonOpInDegree = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.InDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convwf_StepPointRela.InDegree, objvwf_StepPointRelaCond.InDegree, strComparisonOpInDegree);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.OutDegree) == true)
{
string strComparisonOpOutDegree = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.OutDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convwf_StepPointRela.OutDegree, objvwf_StepPointRelaCond.OutDegree, strComparisonOpOutDegree);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convwf_StepPointRela.OrderNum, objvwf_StepPointRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.UpdDate, objvwf_StepPointRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.UpdUser, objvwf_StepPointRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvwf_StepPointRelaCond.IsUpdated(convwf_StepPointRela.Memo) == true)
{
string strComparisonOpMemo = objvwf_StepPointRelaCond.dicFldComparisonOp[convwf_StepPointRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_StepPointRela.Memo, objvwf_StepPointRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工作流与结点关系(vwf_StepPointRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvwf_StepPointRelaWApi
{
private static readonly string mstrApiControllerName = "vwf_StepPointRelaApi";

 public clsvwf_StepPointRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_StepPointRelaEN GetObjByWorkFlowStepPointRelaId(long lngWorkFlowStepPointRelaId)
{
if (lngWorkFlowStepPointRelaId == 0) return null;
string strAction = "GetObjByWorkFlowStepPointRelaId";
clsvwf_StepPointRelaEN objvwf_StepPointRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngWorkFlowStepPointRelaId"] = lngWorkFlowStepPointRelaId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvwf_StepPointRelaEN = JsonConvert.DeserializeObject<clsvwf_StepPointRelaEN>(strJson);
return objvwf_StepPointRelaEN;
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
public static clsvwf_StepPointRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvwf_StepPointRelaEN objvwf_StepPointRelaEN;
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
objvwf_StepPointRelaEN = JsonConvert.DeserializeObject<clsvwf_StepPointRelaEN>(strJson);
return objvwf_StepPointRelaEN;
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
public static List<clsvwf_StepPointRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvwf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvwf_StepPointRelaEN>>(strJson);
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
 /// <param name = "arrWorkFlowStepPointRelaId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_StepPointRelaEN> GetObjLstByWorkFlowStepPointRelaIdLst(List<long> arrWorkFlowStepPointRelaId)
{
 List<clsvwf_StepPointRelaEN> arrObjLst; 
string strAction = "GetObjLstByWorkFlowStepPointRelaIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrWorkFlowStepPointRelaId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvwf_StepPointRelaEN>>(strJson);
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
public static List<clsvwf_StepPointRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvwf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvwf_StepPointRelaEN>>(strJson);
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
public static List<clsvwf_StepPointRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvwf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvwf_StepPointRelaEN>>(strJson);
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
public static List<clsvwf_StepPointRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvwf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvwf_StepPointRelaEN>>(strJson);
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
public static List<clsvwf_StepPointRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvwf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvwf_StepPointRelaEN>>(strJson);
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
public static bool IsExist(long lngWorkFlowStepPointRelaId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngWorkFlowStepPointRelaId"] = lngWorkFlowStepPointRelaId.ToString()
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaENS">源对象</param>
 /// <param name = "objvwf_StepPointRelaENT">目标对象</param>
 public static void CopyTo(clsvwf_StepPointRelaEN objvwf_StepPointRelaENS, clsvwf_StepPointRelaEN objvwf_StepPointRelaENT)
{
try
{
objvwf_StepPointRelaENT.WorkFlowStepPointRelaId = objvwf_StepPointRelaENS.WorkFlowStepPointRelaId; //工作流与结点关系Id
objvwf_StepPointRelaENT.WorkFlowId = objvwf_StepPointRelaENS.WorkFlowId; //工作流Id
objvwf_StepPointRelaENT.WorkFlowName = objvwf_StepPointRelaENS.WorkFlowName; //工作流名称
objvwf_StepPointRelaENT.WorkFlowNameSim = objvwf_StepPointRelaENS.WorkFlowNameSim; //工作流简称
objvwf_StepPointRelaENT.PrjId = objvwf_StepPointRelaENS.PrjId; //工程Id
objvwf_StepPointRelaENT.PrjName = objvwf_StepPointRelaENS.PrjName; //工程名称
objvwf_StepPointRelaENT.PointId = objvwf_StepPointRelaENS.PointId; //结点Id
objvwf_StepPointRelaENT.PointName = objvwf_StepPointRelaENS.PointName; //结点名称
objvwf_StepPointRelaENT.TabKeyId = objvwf_StepPointRelaENS.TabKeyId; //表关键字Id
objvwf_StepPointRelaENT.PointTypeId = objvwf_StepPointRelaENS.PointTypeId; //工作流结点类型Id
objvwf_StepPointRelaENT.PointTypeName = objvwf_StepPointRelaENS.PointTypeName; //工作流结点类型名称
objvwf_StepPointRelaENT.LevelNo = objvwf_StepPointRelaENS.LevelNo; //层序号
objvwf_StepPointRelaENT.InDegree = objvwf_StepPointRelaENS.InDegree; //入度
objvwf_StepPointRelaENT.OutDegree = objvwf_StepPointRelaENS.OutDegree; //出度
objvwf_StepPointRelaENT.OrderNum = objvwf_StepPointRelaENS.OrderNum; //序号
objvwf_StepPointRelaENT.UpdDate = objvwf_StepPointRelaENS.UpdDate; //修改日期
objvwf_StepPointRelaENT.UpdUser = objvwf_StepPointRelaENS.UpdUser; //修改者
objvwf_StepPointRelaENT.Memo = objvwf_StepPointRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvwf_StepPointRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvwf_StepPointRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvwf_StepPointRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvwf_StepPointRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvwf_StepPointRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvwf_StepPointRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvwf_StepPointRelaEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvwf_StepPointRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convwf_StepPointRela.WorkFlowStepPointRelaId, Type.GetType("System.Int64"));
objDT.Columns.Add(convwf_StepPointRela.WorkFlowId, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.WorkFlowName, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.WorkFlowNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.PointId, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.PointName, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.TabKeyId, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.PointTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.PointTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.LevelNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convwf_StepPointRela.InDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(convwf_StepPointRela.OutDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(convwf_StepPointRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convwf_StepPointRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convwf_StepPointRela.Memo, Type.GetType("System.String"));
foreach (clsvwf_StepPointRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convwf_StepPointRela.WorkFlowStepPointRelaId] = objInFor[convwf_StepPointRela.WorkFlowStepPointRelaId];
objDR[convwf_StepPointRela.WorkFlowId] = objInFor[convwf_StepPointRela.WorkFlowId];
objDR[convwf_StepPointRela.WorkFlowName] = objInFor[convwf_StepPointRela.WorkFlowName];
objDR[convwf_StepPointRela.WorkFlowNameSim] = objInFor[convwf_StepPointRela.WorkFlowNameSim];
objDR[convwf_StepPointRela.PrjId] = objInFor[convwf_StepPointRela.PrjId];
objDR[convwf_StepPointRela.PrjName] = objInFor[convwf_StepPointRela.PrjName];
objDR[convwf_StepPointRela.PointId] = objInFor[convwf_StepPointRela.PointId];
objDR[convwf_StepPointRela.PointName] = objInFor[convwf_StepPointRela.PointName];
objDR[convwf_StepPointRela.TabKeyId] = objInFor[convwf_StepPointRela.TabKeyId];
objDR[convwf_StepPointRela.PointTypeId] = objInFor[convwf_StepPointRela.PointTypeId];
objDR[convwf_StepPointRela.PointTypeName] = objInFor[convwf_StepPointRela.PointTypeName];
objDR[convwf_StepPointRela.LevelNo] = objInFor[convwf_StepPointRela.LevelNo];
objDR[convwf_StepPointRela.InDegree] = objInFor[convwf_StepPointRela.InDegree];
objDR[convwf_StepPointRela.OutDegree] = objInFor[convwf_StepPointRela.OutDegree];
objDR[convwf_StepPointRela.OrderNum] = objInFor[convwf_StepPointRela.OrderNum];
objDR[convwf_StepPointRela.UpdDate] = objInFor[convwf_StepPointRela.UpdDate];
objDR[convwf_StepPointRela.UpdUser] = objInFor[convwf_StepPointRela.UpdUser];
objDR[convwf_StepPointRela.Memo] = objInFor[convwf_StepPointRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}