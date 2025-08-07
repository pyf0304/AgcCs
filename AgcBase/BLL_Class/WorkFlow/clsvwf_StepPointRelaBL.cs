
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_StepPointRelaBL
 表名:vwf_StepPointRela(00050487)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:47:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsvwf_StepPointRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_StepPointRelaEN GetObj(this K_WorkFlowStepPointRelaId_vwf_StepPointRela myKey)
{
clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = clsvwf_StepPointRelaBL.vwf_StepPointRelaDA.GetObjByWorkFlowStepPointRelaId(myKey.Value);
return objvwf_StepPointRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetWorkFlowId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strWorkFlowId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowId, convwf_StepPointRela.WorkFlowId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowId, 4, convwf_StepPointRela.WorkFlowId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkFlowId, 4, convwf_StepPointRela.WorkFlowId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetWorkFlowName(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strWorkFlowName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowName, convwf_StepPointRela.WorkFlowName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowName, 50, convwf_StepPointRela.WorkFlowName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetWorkFlowNameSim(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strWorkFlowNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowNameSim, 30, convwf_StepPointRela.WorkFlowNameSim);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPrjId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convwf_StepPointRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convwf_StepPointRela.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPrjName(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convwf_StepPointRela.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPointId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointId, convwf_StepPointRela.PointId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointId, 8, convwf_StepPointRela.PointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPointId, 8, convwf_StepPointRela.PointId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPointName(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPointName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointName, convwf_StepPointRela.PointName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointName, 100, convwf_StepPointRela.PointName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetTabKeyId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strTabKeyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabKeyId, 50, convwf_StepPointRela.TabKeyId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPointTypeId(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPointTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointTypeId, convwf_StepPointRela.PointTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointTypeId, 2, convwf_StepPointRela.PointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPointTypeId, 2, convwf_StepPointRela.PointTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetPointTypeName(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strPointTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointTypeName, convwf_StepPointRela.PointTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointTypeName, 50, convwf_StepPointRela.PointTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetLevelNo(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, int? intLevelNo, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetInDegree(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, int? intInDegree, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetOutDegree(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, int? intOutDegree, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetOrderNum(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetUpdDate(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convwf_StepPointRela.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetUpdUser(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convwf_StepPointRela.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvwf_StepPointRelaEN SetMemo(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convwf_StepPointRela.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaENS">源对象</param>
 /// <param name = "objvwf_StepPointRelaENT">目标对象</param>
 public static void CopyTo(this clsvwf_StepPointRelaEN objvwf_StepPointRelaENS, clsvwf_StepPointRelaEN objvwf_StepPointRelaENT)
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
 /// <param name = "objvwf_StepPointRelaENS">源对象</param>
 /// <returns>目标对象=>clsvwf_StepPointRelaEN:objvwf_StepPointRelaENT</returns>
 public static clsvwf_StepPointRelaEN CopyTo(this clsvwf_StepPointRelaEN objvwf_StepPointRelaENS)
{
try
{
 clsvwf_StepPointRelaEN objvwf_StepPointRelaENT = new clsvwf_StepPointRelaEN()
{
WorkFlowStepPointRelaId = objvwf_StepPointRelaENS.WorkFlowStepPointRelaId, //工作流与结点关系Id
WorkFlowId = objvwf_StepPointRelaENS.WorkFlowId, //工作流Id
WorkFlowName = objvwf_StepPointRelaENS.WorkFlowName, //工作流名称
WorkFlowNameSim = objvwf_StepPointRelaENS.WorkFlowNameSim, //工作流简称
PrjId = objvwf_StepPointRelaENS.PrjId, //工程Id
PrjName = objvwf_StepPointRelaENS.PrjName, //工程名称
PointId = objvwf_StepPointRelaENS.PointId, //结点Id
PointName = objvwf_StepPointRelaENS.PointName, //结点名称
TabKeyId = objvwf_StepPointRelaENS.TabKeyId, //表关键字Id
PointTypeId = objvwf_StepPointRelaENS.PointTypeId, //工作流结点类型Id
PointTypeName = objvwf_StepPointRelaENS.PointTypeName, //工作流结点类型名称
LevelNo = objvwf_StepPointRelaENS.LevelNo, //层序号
InDegree = objvwf_StepPointRelaENS.InDegree, //入度
OutDegree = objvwf_StepPointRelaENS.OutDegree, //出度
OrderNum = objvwf_StepPointRelaENS.OrderNum, //序号
UpdDate = objvwf_StepPointRelaENS.UpdDate, //修改日期
UpdUser = objvwf_StepPointRelaENS.UpdUser, //修改者
Memo = objvwf_StepPointRelaENS.Memo, //说明
};
 return objvwf_StepPointRelaENT;
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
public static void CheckProperty4Condition(this clsvwf_StepPointRelaEN objvwf_StepPointRelaEN)
{
 clsvwf_StepPointRelaBL.vwf_StepPointRelaDA.CheckProperty4Condition(objvwf_StepPointRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vwf_StepPointRela
{
public virtual bool UpdRelaTabDate(long lngWorkFlowStepPointRelaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工作流与结点关系(vwf_StepPointRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvwf_StepPointRelaBL
{
public static RelatedActions_vwf_StepPointRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvwf_StepPointRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvwf_StepPointRelaDA vwf_StepPointRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvwf_StepPointRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvwf_StepPointRelaBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
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
if (string.IsNullOrEmpty(clsvwf_StepPointRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvwf_StepPointRelaEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vwf_StepPointRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vwf_StepPointRelaDA.GetDataTable_vwf_StepPointRela(strWhereCond);
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
objDT = vwf_StepPointRelaDA.GetDataTable(strWhereCond);
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
objDT = vwf_StepPointRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vwf_StepPointRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vwf_StepPointRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vwf_StepPointRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vwf_StepPointRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vwf_StepPointRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vwf_StepPointRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrWorkFlowStepPointRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvwf_StepPointRelaEN> GetObjLstByWorkFlowStepPointRelaIdLst(List<long> arrWorkFlowStepPointRelaIdLst)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWorkFlowStepPointRelaIdLst);
 string strWhereCond = string.Format("WorkFlowStepPointRelaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWorkFlowStepPointRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvwf_StepPointRelaEN> GetObjLstByWorkFlowStepPointRelaIdLstCache(List<long> arrWorkFlowStepPointRelaIdLst)
{
string strKey = string.Format("{0}", clsvwf_StepPointRelaEN._CurrTabName);
List<clsvwf_StepPointRelaEN> arrvwf_StepPointRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_StepPointRelaEN> arrvwf_StepPointRelaObjLst_Sel =
arrvwf_StepPointRelaObjLstCache
.Where(x => arrWorkFlowStepPointRelaIdLst.Contains(x.WorkFlowStepPointRelaId));
return arrvwf_StepPointRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_StepPointRelaEN> GetObjLst(string strWhereCond)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
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
public static List<clsvwf_StepPointRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvwf_StepPointRelaEN> GetSubObjLstCache(clsvwf_StepPointRelaEN objvwf_StepPointRelaCond)
{
List<clsvwf_StepPointRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_StepPointRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_StepPointRela._AttributeName)
{
if (objvwf_StepPointRelaCond.IsUpdated(strFldName) == false) continue;
if (objvwf_StepPointRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepPointRelaCond[strFldName].ToString());
}
else
{
if (objvwf_StepPointRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_StepPointRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepPointRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_StepPointRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_StepPointRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_StepPointRelaCond[strFldName]));
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
public static List<clsvwf_StepPointRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
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
public static List<clsvwf_StepPointRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
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
List<clsvwf_StepPointRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvwf_StepPointRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_StepPointRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvwf_StepPointRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
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
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
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
public static List<clsvwf_StepPointRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvwf_StepPointRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvwf_StepPointRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
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
public static List<clsvwf_StepPointRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_StepPointRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_StepPointRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvwf_StepPointRela(ref clsvwf_StepPointRelaEN objvwf_StepPointRelaEN)
{
bool bolResult = vwf_StepPointRelaDA.Getvwf_StepPointRela(ref objvwf_StepPointRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_StepPointRelaEN GetObjByWorkFlowStepPointRelaId(long lngWorkFlowStepPointRelaId)
{
clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = vwf_StepPointRelaDA.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);
return objvwf_StepPointRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvwf_StepPointRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = vwf_StepPointRelaDA.GetFirstObj(strWhereCond);
 return objvwf_StepPointRelaEN;
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
public static clsvwf_StepPointRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = vwf_StepPointRelaDA.GetObjByDataRow(objRow);
 return objvwf_StepPointRelaEN;
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
public static clsvwf_StepPointRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = vwf_StepPointRelaDA.GetObjByDataRow(objRow);
 return objvwf_StepPointRelaEN;
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
 /// <param name = "lngWorkFlowStepPointRelaId">所给的关键字</param>
 /// <param name = "lstvwf_StepPointRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_StepPointRelaEN GetObjByWorkFlowStepPointRelaIdFromList(long lngWorkFlowStepPointRelaId, List<clsvwf_StepPointRelaEN> lstvwf_StepPointRelaObjLst)
{
foreach (clsvwf_StepPointRelaEN objvwf_StepPointRelaEN in lstvwf_StepPointRelaObjLst)
{
if (objvwf_StepPointRelaEN.WorkFlowStepPointRelaId == lngWorkFlowStepPointRelaId)
{
return objvwf_StepPointRelaEN;
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
 long lngWorkFlowStepPointRelaId;
 try
 {
 lngWorkFlowStepPointRelaId = new clsvwf_StepPointRelaDA().GetFirstID(strWhereCond);
 return lngWorkFlowStepPointRelaId;
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
 arrList = vwf_StepPointRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vwf_StepPointRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngWorkFlowStepPointRelaId)
{
//检测记录是否存在
bool bolIsExist = vwf_StepPointRelaDA.IsExist(lngWorkFlowStepPointRelaId);
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
 bolIsExist = clsvwf_StepPointRelaDA.IsExistTable();
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
 bolIsExist = vwf_StepPointRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvwf_StepPointRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvwf_StepPointRelaEN objvwf_StepPointRelaEN)
{
try
{
objvwf_StepPointRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvwf_StepPointRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convwf_StepPointRela.WorkFlowStepPointRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = objvwf_StepPointRelaEN.WorkFlowStepPointRelaId; //工作流与结点关系Id
}
if (arrFldSet.Contains(convwf_StepPointRela.WorkFlowId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.WorkFlowId = objvwf_StepPointRelaEN.WorkFlowId; //工作流Id
}
if (arrFldSet.Contains(convwf_StepPointRela.WorkFlowName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.WorkFlowName = objvwf_StepPointRelaEN.WorkFlowName; //工作流名称
}
if (arrFldSet.Contains(convwf_StepPointRela.WorkFlowNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.WorkFlowNameSim = objvwf_StepPointRelaEN.WorkFlowNameSim == "[null]" ? null :  objvwf_StepPointRelaEN.WorkFlowNameSim; //工作流简称
}
if (arrFldSet.Contains(convwf_StepPointRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.PrjId = objvwf_StepPointRelaEN.PrjId == "[null]" ? null :  objvwf_StepPointRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convwf_StepPointRela.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.PrjName = objvwf_StepPointRelaEN.PrjName == "[null]" ? null :  objvwf_StepPointRelaEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convwf_StepPointRela.PointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.PointId = objvwf_StepPointRelaEN.PointId; //结点Id
}
if (arrFldSet.Contains(convwf_StepPointRela.PointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.PointName = objvwf_StepPointRelaEN.PointName; //结点名称
}
if (arrFldSet.Contains(convwf_StepPointRela.TabKeyId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.TabKeyId = objvwf_StepPointRelaEN.TabKeyId == "[null]" ? null :  objvwf_StepPointRelaEN.TabKeyId; //表关键字Id
}
if (arrFldSet.Contains(convwf_StepPointRela.PointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.PointTypeId = objvwf_StepPointRelaEN.PointTypeId; //工作流结点类型Id
}
if (arrFldSet.Contains(convwf_StepPointRela.PointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.PointTypeName = objvwf_StepPointRelaEN.PointTypeName; //工作流结点类型名称
}
if (arrFldSet.Contains(convwf_StepPointRela.LevelNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.LevelNo = objvwf_StepPointRelaEN.LevelNo; //层序号
}
if (arrFldSet.Contains(convwf_StepPointRela.InDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.InDegree = objvwf_StepPointRelaEN.InDegree; //入度
}
if (arrFldSet.Contains(convwf_StepPointRela.OutDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.OutDegree = objvwf_StepPointRelaEN.OutDegree; //出度
}
if (arrFldSet.Contains(convwf_StepPointRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.OrderNum = objvwf_StepPointRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convwf_StepPointRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.UpdDate = objvwf_StepPointRelaEN.UpdDate == "[null]" ? null :  objvwf_StepPointRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convwf_StepPointRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.UpdUser = objvwf_StepPointRelaEN.UpdUser == "[null]" ? null :  objvwf_StepPointRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convwf_StepPointRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_StepPointRelaEN.Memo = objvwf_StepPointRelaEN.Memo == "[null]" ? null :  objvwf_StepPointRelaEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvwf_StepPointRelaEN objvwf_StepPointRelaEN)
{
try
{
if (objvwf_StepPointRelaEN.WorkFlowNameSim == "[null]") objvwf_StepPointRelaEN.WorkFlowNameSim = null; //工作流简称
if (objvwf_StepPointRelaEN.PrjId == "[null]") objvwf_StepPointRelaEN.PrjId = null; //工程Id
if (objvwf_StepPointRelaEN.PrjName == "[null]") objvwf_StepPointRelaEN.PrjName = null; //工程名称
if (objvwf_StepPointRelaEN.TabKeyId == "[null]") objvwf_StepPointRelaEN.TabKeyId = null; //表关键字Id
if (objvwf_StepPointRelaEN.UpdDate == "[null]") objvwf_StepPointRelaEN.UpdDate = null; //修改日期
if (objvwf_StepPointRelaEN.UpdUser == "[null]") objvwf_StepPointRelaEN.UpdUser = null; //修改者
if (objvwf_StepPointRelaEN.Memo == "[null]") objvwf_StepPointRelaEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvwf_StepPointRelaEN objvwf_StepPointRelaEN)
{
 vwf_StepPointRelaDA.CheckProperty4Condition(objvwf_StepPointRelaEN);
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
if (clswf_PointTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_PointTypeBL没有刷新缓存机制(clswf_PointTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clswf_PointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_PointBL没有刷新缓存机制(clswf_PointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clswf_StepPointRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_StepPointRelaBL没有刷新缓存机制(clswf_StepPointRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clswf_WorkFlowBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_WorkFlowBL没有刷新缓存机制(clswf_WorkFlowBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clswf_ProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_ProjectsBL没有刷新缓存机制(clswf_ProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WorkFlowStepPointRelaId");
//if (arrvwf_StepPointRelaObjLstCache == null)
//{
//arrvwf_StepPointRelaObjLstCache = vwf_StepPointRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_StepPointRelaEN GetObjByWorkFlowStepPointRelaIdCache(long lngWorkFlowStepPointRelaId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvwf_StepPointRelaEN._CurrTabName);
List<clsvwf_StepPointRelaEN> arrvwf_StepPointRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_StepPointRelaEN> arrvwf_StepPointRelaObjLst_Sel =
arrvwf_StepPointRelaObjLstCache
.Where(x=> x.WorkFlowStepPointRelaId == lngWorkFlowStepPointRelaId 
);
if (arrvwf_StepPointRelaObjLst_Sel.Count() == 0)
{
   clsvwf_StepPointRelaEN obj = clsvwf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvwf_StepPointRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_StepPointRelaEN> GetAllvwf_StepPointRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvwf_StepPointRelaEN> arrvwf_StepPointRelaObjLstCache = GetObjLstCache(); 
return arrvwf_StepPointRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_StepPointRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvwf_StepPointRelaEN._CurrTabName);
List<clsvwf_StepPointRelaEN> arrvwf_StepPointRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvwf_StepPointRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvwf_StepPointRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvwf_StepPointRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvwf_StepPointRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvwf_StepPointRelaEN._RefreshTimeLst[clsvwf_StepPointRelaEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngWorkFlowStepPointRelaId)
{
if (strInFldName != convwf_StepPointRela.WorkFlowStepPointRelaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convwf_StepPointRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convwf_StepPointRela._AttributeName));
throw new Exception(strMsg);
}
var objvwf_StepPointRela = clsvwf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaIdCache(lngWorkFlowStepPointRelaId);
if (objvwf_StepPointRela == null) return "";
return objvwf_StepPointRela[strOutFldName].ToString();
}


 #region 有关JSON操作


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
int intRecCount = clsvwf_StepPointRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvwf_StepPointRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvwf_StepPointRelaDA.GetRecCount();
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
int intRecCount = clsvwf_StepPointRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvwf_StepPointRelaEN objvwf_StepPointRelaCond)
{
List<clsvwf_StepPointRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_StepPointRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_StepPointRela._AttributeName)
{
if (objvwf_StepPointRelaCond.IsUpdated(strFldName) == false) continue;
if (objvwf_StepPointRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepPointRelaCond[strFldName].ToString());
}
else
{
if (objvwf_StepPointRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_StepPointRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_StepPointRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_StepPointRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_StepPointRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_StepPointRelaCond[strFldName]));
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
 List<string> arrList = clsvwf_StepPointRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vwf_StepPointRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vwf_StepPointRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}