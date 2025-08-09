
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_StepPointRelaWApi
 表名:wf_StepPointRela(00050486)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:41:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clswf_StepPointRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngWorkFlowStepPointRelaId">工作流与结点关系Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetWorkFlowStepPointRelaId(this clswf_StepPointRelaEN objwf_StepPointRelaEN, long lngWorkFlowStepPointRelaId, string strComparisonOp="")
	{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = lngWorkFlowStepPointRelaId; //工作流与结点关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.WorkFlowStepPointRelaId) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.WorkFlowStepPointRelaId, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.WorkFlowStepPointRelaId] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strWorkFlowId">工作流Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetWorkFlowId(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strWorkFlowId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowId, conwf_StepPointRela.WorkFlowId);
clsCheckSql.CheckFieldLen(strWorkFlowId, 4, conwf_StepPointRela.WorkFlowId);
clsCheckSql.CheckFieldForeignKey(strWorkFlowId, 4, conwf_StepPointRela.WorkFlowId);
objwf_StepPointRelaEN.WorkFlowId = strWorkFlowId; //工作流Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.WorkFlowId) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.WorkFlowId, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.WorkFlowId] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPointId">结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetPointId(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strPointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointId, conwf_StepPointRela.PointId);
clsCheckSql.CheckFieldLen(strPointId, 8, conwf_StepPointRela.PointId);
clsCheckSql.CheckFieldForeignKey(strPointId, 8, conwf_StepPointRela.PointId);
objwf_StepPointRelaEN.PointId = strPointId; //结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.PointId) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.PointId, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.PointId] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPointTypeId">工作流结点类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetPointTypeId(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strPointTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointTypeId, conwf_StepPointRela.PointTypeId);
clsCheckSql.CheckFieldLen(strPointTypeId, 2, conwf_StepPointRela.PointTypeId);
clsCheckSql.CheckFieldForeignKey(strPointTypeId, 2, conwf_StepPointRela.PointTypeId);
objwf_StepPointRelaEN.PointTypeId = strPointTypeId; //工作流结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.PointTypeId) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.PointTypeId, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.PointTypeId] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intLevelNo">层序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetLevelNo(this clswf_StepPointRelaEN objwf_StepPointRelaEN, int intLevelNo, string strComparisonOp="")
	{
objwf_StepPointRelaEN.LevelNo = intLevelNo; //层序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.LevelNo) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.LevelNo, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.LevelNo] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intInDegree">入度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetInDegree(this clswf_StepPointRelaEN objwf_StepPointRelaEN, int intInDegree, string strComparisonOp="")
	{
objwf_StepPointRelaEN.InDegree = intInDegree; //入度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.InDegree) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.InDegree, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.InDegree] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOutDegree">出度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetOutDegree(this clswf_StepPointRelaEN objwf_StepPointRelaEN, int intOutDegree, string strComparisonOp="")
	{
objwf_StepPointRelaEN.OutDegree = intOutDegree; //出度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.OutDegree) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.OutDegree, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.OutDegree] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetOrderNum(this clswf_StepPointRelaEN objwf_StepPointRelaEN, int intOrderNum, string strComparisonOp="")
	{
objwf_StepPointRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.OrderNum) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.OrderNum, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.OrderNum] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetUpdDate(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conwf_StepPointRela.UpdDate);
objwf_StepPointRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.UpdDate) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.UpdDate, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.UpdDate] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetUpdUser(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conwf_StepPointRela.UpdUser);
objwf_StepPointRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.UpdUser) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.UpdUser, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.UpdUser] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetMemo(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conwf_StepPointRela.Memo);
objwf_StepPointRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.Memo) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.Memo, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.Memo] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clswf_StepPointRelaEN objwf_StepPointRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.WorkFlowStepPointRelaId) == true)
{
string strComparisonOpWorkFlowStepPointRelaId = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.WorkFlowStepPointRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.WorkFlowStepPointRelaId, objwf_StepPointRelaCond.WorkFlowStepPointRelaId, strComparisonOpWorkFlowStepPointRelaId);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.WorkFlowId) == true)
{
string strComparisonOpWorkFlowId = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.WorkFlowId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.WorkFlowId, objwf_StepPointRelaCond.WorkFlowId, strComparisonOpWorkFlowId);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.PointId) == true)
{
string strComparisonOpPointId = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.PointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.PointId, objwf_StepPointRelaCond.PointId, strComparisonOpPointId);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.PointTypeId) == true)
{
string strComparisonOpPointTypeId = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.PointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.PointTypeId, objwf_StepPointRelaCond.PointTypeId, strComparisonOpPointTypeId);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.LevelNo) == true)
{
string strComparisonOpLevelNo = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.LevelNo, objwf_StepPointRelaCond.LevelNo, strComparisonOpLevelNo);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.InDegree) == true)
{
string strComparisonOpInDegree = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.InDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.InDegree, objwf_StepPointRelaCond.InDegree, strComparisonOpInDegree);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.OutDegree) == true)
{
string strComparisonOpOutDegree = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.OutDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.OutDegree, objwf_StepPointRelaCond.OutDegree, strComparisonOpOutDegree);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.OrderNum, objwf_StepPointRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.UpdDate, objwf_StepPointRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.UpdUser, objwf_StepPointRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.Memo) == true)
{
string strComparisonOpMemo = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.Memo, objwf_StepPointRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
 if (objwf_StepPointRelaEN.WorkFlowStepPointRelaId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objwf_StepPointRelaEN.sfUpdFldSetStr = objwf_StepPointRelaEN.getsfUpdFldSetStr();
clswf_StepPointRelaWApi.CheckPropertyNew(objwf_StepPointRelaEN); 
bool bolResult = clswf_StepPointRelaWApi.UpdateRecord(objwf_StepPointRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaWApi.ReFreshCache();
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
 /// 获取唯一性条件串--wf_StepPointRela(工作流与结点关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:WorkFlowId_PointId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objwf_StepPointRelaEN == null) return "";
if (objwf_StepPointRelaEN.WorkFlowStepPointRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepPointRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and PointId = '{0}'", objwf_StepPointRelaEN.PointId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("WorkFlowStepPointRelaId !=  {0}", objwf_StepPointRelaEN.WorkFlowStepPointRelaId);
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepPointRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and PointId = '{0}'", objwf_StepPointRelaEN.PointId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
try
{
clswf_StepPointRelaWApi.CheckPropertyNew(objwf_StepPointRelaEN); 
bool bolResult = clswf_StepPointRelaWApi.AddNewRecord(objwf_StepPointRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaWApi.ReFreshCache();
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
 /// <param name = "objwf_StepPointRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strWhereCond)
{
try
{
clswf_StepPointRelaWApi.CheckPropertyNew(objwf_StepPointRelaEN); 
bool bolResult = clswf_StepPointRelaWApi.UpdateWithCondition(objwf_StepPointRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaWApi.ReFreshCache();
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
 /// 工作流与结点关系(wf_StepPointRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clswf_StepPointRelaWApi
{
private static readonly string mstrApiControllerName = "wf_StepPointRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clswf_StepPointRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
if (!Object.Equals(null, objwf_StepPointRelaEN.WorkFlowId) && GetStrLen(objwf_StepPointRelaEN.WorkFlowId) > 4)
{
 throw new Exception("字段[工作流Id]的长度不能超过4!");
}
if (!Object.Equals(null, objwf_StepPointRelaEN.PointId) && GetStrLen(objwf_StepPointRelaEN.PointId) > 8)
{
 throw new Exception("字段[结点Id]的长度不能超过8!");
}
if (!Object.Equals(null, objwf_StepPointRelaEN.PointTypeId) && GetStrLen(objwf_StepPointRelaEN.PointTypeId) > 2)
{
 throw new Exception("字段[工作流结点类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objwf_StepPointRelaEN.UpdDate) && GetStrLen(objwf_StepPointRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objwf_StepPointRelaEN.UpdUser) && GetStrLen(objwf_StepPointRelaEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objwf_StepPointRelaEN.Memo) && GetStrLen(objwf_StepPointRelaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objwf_StepPointRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_StepPointRelaEN GetObjByWorkFlowStepPointRelaId(long lngWorkFlowStepPointRelaId)
{
if (lngWorkFlowStepPointRelaId == 0) return null;
string strAction = "GetObjByWorkFlowStepPointRelaId";
clswf_StepPointRelaEN objwf_StepPointRelaEN;
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
objwf_StepPointRelaEN = JsonConvert.DeserializeObject<clswf_StepPointRelaEN>(strJson);
return objwf_StepPointRelaEN;
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
public static clswf_StepPointRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clswf_StepPointRelaEN objwf_StepPointRelaEN;
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
objwf_StepPointRelaEN = JsonConvert.DeserializeObject<clswf_StepPointRelaEN>(strJson);
return objwf_StepPointRelaEN;
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
 /// <param name = "lngWorkFlowStepPointRelaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_StepPointRelaEN GetObjByWorkFlowStepPointRelaIdCache(long lngWorkFlowStepPointRelaId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clswf_StepPointRelaEN._CurrTabName);
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel =
from objwf_StepPointRelaEN in arrwf_StepPointRelaObjLstCache
where objwf_StepPointRelaEN.WorkFlowStepPointRelaId == lngWorkFlowStepPointRelaId 
select objwf_StepPointRelaEN;
if (arrwf_StepPointRelaObjLst_Sel.Count() == 0)
{
   clswf_StepPointRelaEN obj = clswf_StepPointRelaWApi.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrwf_StepPointRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_StepPointRelaEN> GetObjLst(string strWhereCond)
{
 List<clswf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clswf_StepPointRelaEN>>(strJson);
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
public static List<clswf_StepPointRelaEN> GetObjLstByWorkFlowStepPointRelaIdLst(List<long> arrWorkFlowStepPointRelaId)
{
 List<clswf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clswf_StepPointRelaEN>>(strJson);
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
 /// <param name = "arrWorkFlowStepPointRelaId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clswf_StepPointRelaEN> GetObjLstByWorkFlowStepPointRelaIdLstCache(List<long> arrWorkFlowStepPointRelaId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clswf_StepPointRelaEN._CurrTabName);
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel =
from objwf_StepPointRelaEN in arrwf_StepPointRelaObjLstCache
where arrWorkFlowStepPointRelaId.Contains(objwf_StepPointRelaEN.WorkFlowStepPointRelaId)
select objwf_StepPointRelaEN;
return arrwf_StepPointRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_StepPointRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clswf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clswf_StepPointRelaEN>>(strJson);
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
public static List<clswf_StepPointRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clswf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clswf_StepPointRelaEN>>(strJson);
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
public static List<clswf_StepPointRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clswf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clswf_StepPointRelaEN>>(strJson);
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
public static List<clswf_StepPointRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clswf_StepPointRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clswf_StepPointRelaEN>>(strJson);
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
public static int DelRecord(long lngWorkFlowStepPointRelaId)
{
string strAction = "DelRecord";
try
{
 clswf_StepPointRelaEN objwf_StepPointRelaEN = clswf_StepPointRelaWApi.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngWorkFlowStepPointRelaId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clswf_StepPointRelaWApi.ReFreshCache();
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
public static int Delwf_StepPointRelas(List<string> arrWorkFlowStepPointRelaId)
{
string strAction = "Delwf_StepPointRelas";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrWorkFlowStepPointRelaId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clswf_StepPointRelaWApi.ReFreshCache();
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
public static int Delwf_StepPointRelasByCond(string strWhereCond)
{
string strAction = "Delwf_StepPointRelasByCond";
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
public static bool AddNewRecord(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clswf_StepPointRelaEN>(objwf_StepPointRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaWApi.ReFreshCache();
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
 /// <param name = "objwf_StepPointRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clswf_StepPointRelaEN>(objwf_StepPointRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaWApi.ReFreshCache();
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
public static bool UpdateRecord(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
if (string.IsNullOrEmpty(objwf_StepPointRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clswf_StepPointRelaEN>(objwf_StepPointRelaEN);
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
 /// <param name = "objwf_StepPointRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clswf_StepPointRelaEN objwf_StepPointRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objwf_StepPointRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clswf_StepPointRelaEN>(objwf_StepPointRelaEN);
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
 /// <param name = "objwf_StepPointRelaENS">源对象</param>
 /// <param name = "objwf_StepPointRelaENT">目标对象</param>
 public static void CopyTo(clswf_StepPointRelaEN objwf_StepPointRelaENS, clswf_StepPointRelaEN objwf_StepPointRelaENT)
{
try
{
objwf_StepPointRelaENT.WorkFlowStepPointRelaId = objwf_StepPointRelaENS.WorkFlowStepPointRelaId; //工作流与结点关系Id
objwf_StepPointRelaENT.WorkFlowId = objwf_StepPointRelaENS.WorkFlowId; //工作流Id
objwf_StepPointRelaENT.PointId = objwf_StepPointRelaENS.PointId; //结点Id
objwf_StepPointRelaENT.PointTypeId = objwf_StepPointRelaENS.PointTypeId; //工作流结点类型Id
objwf_StepPointRelaENT.LevelNo = objwf_StepPointRelaENS.LevelNo; //层序号
objwf_StepPointRelaENT.InDegree = objwf_StepPointRelaENS.InDegree; //入度
objwf_StepPointRelaENT.OutDegree = objwf_StepPointRelaENS.OutDegree; //出度
objwf_StepPointRelaENT.OrderNum = objwf_StepPointRelaENS.OrderNum; //序号
objwf_StepPointRelaENT.UpdDate = objwf_StepPointRelaENS.UpdDate; //修改日期
objwf_StepPointRelaENT.UpdUser = objwf_StepPointRelaENS.UpdUser; //修改者
objwf_StepPointRelaENT.Memo = objwf_StepPointRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clswf_StepPointRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clswf_StepPointRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clswf_StepPointRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clswf_StepPointRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clswf_StepPointRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clswf_StepPointRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clswf_StepPointRelaEN._CurrTabName);
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
if (clswf_StepPointRelaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clswf_StepPointRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clswf_StepPointRelaWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_StepPointRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clswf_StepPointRelaEN._CurrTabName;
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrwf_StepPointRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clswf_StepPointRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conwf_StepPointRela.WorkFlowStepPointRelaId, Type.GetType("System.Int64"));
objDT.Columns.Add(conwf_StepPointRela.WorkFlowId, Type.GetType("System.String"));
objDT.Columns.Add(conwf_StepPointRela.PointId, Type.GetType("System.String"));
objDT.Columns.Add(conwf_StepPointRela.PointTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conwf_StepPointRela.LevelNo, Type.GetType("System.Int32"));
objDT.Columns.Add(conwf_StepPointRela.InDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(conwf_StepPointRela.OutDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(conwf_StepPointRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conwf_StepPointRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conwf_StepPointRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conwf_StepPointRela.Memo, Type.GetType("System.String"));
foreach (clswf_StepPointRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conwf_StepPointRela.WorkFlowStepPointRelaId] = objInFor[conwf_StepPointRela.WorkFlowStepPointRelaId];
objDR[conwf_StepPointRela.WorkFlowId] = objInFor[conwf_StepPointRela.WorkFlowId];
objDR[conwf_StepPointRela.PointId] = objInFor[conwf_StepPointRela.PointId];
objDR[conwf_StepPointRela.PointTypeId] = objInFor[conwf_StepPointRela.PointTypeId];
objDR[conwf_StepPointRela.LevelNo] = objInFor[conwf_StepPointRela.LevelNo];
objDR[conwf_StepPointRela.InDegree] = objInFor[conwf_StepPointRela.InDegree];
objDR[conwf_StepPointRela.OutDegree] = objInFor[conwf_StepPointRela.OutDegree];
objDR[conwf_StepPointRela.OrderNum] = objInFor[conwf_StepPointRela.OrderNum];
objDR[conwf_StepPointRela.UpdDate] = objInFor[conwf_StepPointRela.UpdDate];
objDR[conwf_StepPointRela.UpdUser] = objInFor[conwf_StepPointRela.UpdUser];
objDR[conwf_StepPointRela.Memo] = objInFor[conwf_StepPointRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工作流与结点关系(wf_StepPointRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4wf_StepPointRela : clsCommFun4BL
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
clswf_StepPointRelaWApi.ReFreshThisCache();
}
}

}