
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_WorkFlowBL
 表名:vwf_WorkFlow(00050490)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:38
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
public static class clsvwf_WorkFlowBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strWorkFlowId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_WorkFlowEN GetObj(this K_WorkFlowId_vwf_WorkFlow myKey)
{
clsvwf_WorkFlowEN objvwf_WorkFlowEN = clsvwf_WorkFlowBL.vwf_WorkFlowDA.GetObjByWorkFlowId(myKey.Value);
return objvwf_WorkFlowEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_WorkFlowEN SetWorkFlowId(this clsvwf_WorkFlowEN objvwf_WorkFlowEN, string strWorkFlowId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowId, 4, convwf_WorkFlow.WorkFlowId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkFlowId, 4, convwf_WorkFlow.WorkFlowId);
}
objvwf_WorkFlowEN.WorkFlowId = strWorkFlowId; //工作流Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(convwf_WorkFlow.WorkFlowId) == false)
{
objvwf_WorkFlowEN.dicFldComparisonOp.Add(convwf_WorkFlow.WorkFlowId, strComparisonOp);
}
else
{
objvwf_WorkFlowEN.dicFldComparisonOp[convwf_WorkFlow.WorkFlowId] = strComparisonOp;
}
}
return objvwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_WorkFlowEN SetWorkFlowName(this clsvwf_WorkFlowEN objvwf_WorkFlowEN, string strWorkFlowName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowName, convwf_WorkFlow.WorkFlowName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowName, 50, convwf_WorkFlow.WorkFlowName);
}
objvwf_WorkFlowEN.WorkFlowName = strWorkFlowName; //工作流名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(convwf_WorkFlow.WorkFlowName) == false)
{
objvwf_WorkFlowEN.dicFldComparisonOp.Add(convwf_WorkFlow.WorkFlowName, strComparisonOp);
}
else
{
objvwf_WorkFlowEN.dicFldComparisonOp[convwf_WorkFlow.WorkFlowName] = strComparisonOp;
}
}
return objvwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_WorkFlowEN SetWorkFlowNameSim(this clsvwf_WorkFlowEN objvwf_WorkFlowEN, string strWorkFlowNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowNameSim, 30, convwf_WorkFlow.WorkFlowNameSim);
}
objvwf_WorkFlowEN.WorkFlowNameSim = strWorkFlowNameSim; //工作流简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(convwf_WorkFlow.WorkFlowNameSim) == false)
{
objvwf_WorkFlowEN.dicFldComparisonOp.Add(convwf_WorkFlow.WorkFlowNameSim, strComparisonOp);
}
else
{
objvwf_WorkFlowEN.dicFldComparisonOp[convwf_WorkFlow.WorkFlowNameSim] = strComparisonOp;
}
}
return objvwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_WorkFlowEN SetPrjId(this clsvwf_WorkFlowEN objvwf_WorkFlowEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convwf_WorkFlow.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convwf_WorkFlow.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convwf_WorkFlow.PrjId);
}
objvwf_WorkFlowEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(convwf_WorkFlow.PrjId) == false)
{
objvwf_WorkFlowEN.dicFldComparisonOp.Add(convwf_WorkFlow.PrjId, strComparisonOp);
}
else
{
objvwf_WorkFlowEN.dicFldComparisonOp[convwf_WorkFlow.PrjId] = strComparisonOp;
}
}
return objvwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_WorkFlowEN SetPrjName(this clsvwf_WorkFlowEN objvwf_WorkFlowEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convwf_WorkFlow.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convwf_WorkFlow.PrjName);
}
objvwf_WorkFlowEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(convwf_WorkFlow.PrjName) == false)
{
objvwf_WorkFlowEN.dicFldComparisonOp.Add(convwf_WorkFlow.PrjName, strComparisonOp);
}
else
{
objvwf_WorkFlowEN.dicFldComparisonOp[convwf_WorkFlow.PrjName] = strComparisonOp;
}
}
return objvwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_WorkFlowEN SetUpdDate(this clsvwf_WorkFlowEN objvwf_WorkFlowEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convwf_WorkFlow.UpdDate);
}
objvwf_WorkFlowEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(convwf_WorkFlow.UpdDate) == false)
{
objvwf_WorkFlowEN.dicFldComparisonOp.Add(convwf_WorkFlow.UpdDate, strComparisonOp);
}
else
{
objvwf_WorkFlowEN.dicFldComparisonOp[convwf_WorkFlow.UpdDate] = strComparisonOp;
}
}
return objvwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_WorkFlowEN SetUpdUser(this clsvwf_WorkFlowEN objvwf_WorkFlowEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convwf_WorkFlow.UpdUser);
}
objvwf_WorkFlowEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(convwf_WorkFlow.UpdUser) == false)
{
objvwf_WorkFlowEN.dicFldComparisonOp.Add(convwf_WorkFlow.UpdUser, strComparisonOp);
}
else
{
objvwf_WorkFlowEN.dicFldComparisonOp[convwf_WorkFlow.UpdUser] = strComparisonOp;
}
}
return objvwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_WorkFlowEN SetMemo(this clsvwf_WorkFlowEN objvwf_WorkFlowEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convwf_WorkFlow.Memo);
}
objvwf_WorkFlowEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(convwf_WorkFlow.Memo) == false)
{
objvwf_WorkFlowEN.dicFldComparisonOp.Add(convwf_WorkFlow.Memo, strComparisonOp);
}
else
{
objvwf_WorkFlowEN.dicFldComparisonOp[convwf_WorkFlow.Memo] = strComparisonOp;
}
}
return objvwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_WorkFlowEN SetIsCurrentUse(this clsvwf_WorkFlowEN objvwf_WorkFlowEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
objvwf_WorkFlowEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(convwf_WorkFlow.IsCurrentUse) == false)
{
objvwf_WorkFlowEN.dicFldComparisonOp.Add(convwf_WorkFlow.IsCurrentUse, strComparisonOp);
}
else
{
objvwf_WorkFlowEN.dicFldComparisonOp[convwf_WorkFlow.IsCurrentUse] = strComparisonOp;
}
}
return objvwf_WorkFlowEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvwf_WorkFlowENS">源对象</param>
 /// <param name = "objvwf_WorkFlowENT">目标对象</param>
 public static void CopyTo(this clsvwf_WorkFlowEN objvwf_WorkFlowENS, clsvwf_WorkFlowEN objvwf_WorkFlowENT)
{
try
{
objvwf_WorkFlowENT.WorkFlowId = objvwf_WorkFlowENS.WorkFlowId; //工作流Id
objvwf_WorkFlowENT.WorkFlowName = objvwf_WorkFlowENS.WorkFlowName; //工作流名称
objvwf_WorkFlowENT.WorkFlowNameSim = objvwf_WorkFlowENS.WorkFlowNameSim; //工作流简称
objvwf_WorkFlowENT.PrjId = objvwf_WorkFlowENS.PrjId; //工程ID
objvwf_WorkFlowENT.PrjName = objvwf_WorkFlowENS.PrjName; //工程名称
objvwf_WorkFlowENT.UpdDate = objvwf_WorkFlowENS.UpdDate; //修改日期
objvwf_WorkFlowENT.UpdUser = objvwf_WorkFlowENS.UpdUser; //修改者
objvwf_WorkFlowENT.Memo = objvwf_WorkFlowENS.Memo; //说明
objvwf_WorkFlowENT.IsCurrentUse = objvwf_WorkFlowENS.IsCurrentUse; //是否当前使用
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
 /// <param name = "objvwf_WorkFlowENS">源对象</param>
 /// <returns>目标对象=>clsvwf_WorkFlowEN:objvwf_WorkFlowENT</returns>
 public static clsvwf_WorkFlowEN CopyTo(this clsvwf_WorkFlowEN objvwf_WorkFlowENS)
{
try
{
 clsvwf_WorkFlowEN objvwf_WorkFlowENT = new clsvwf_WorkFlowEN()
{
WorkFlowId = objvwf_WorkFlowENS.WorkFlowId, //工作流Id
WorkFlowName = objvwf_WorkFlowENS.WorkFlowName, //工作流名称
WorkFlowNameSim = objvwf_WorkFlowENS.WorkFlowNameSim, //工作流简称
PrjId = objvwf_WorkFlowENS.PrjId, //工程ID
PrjName = objvwf_WorkFlowENS.PrjName, //工程名称
UpdDate = objvwf_WorkFlowENS.UpdDate, //修改日期
UpdUser = objvwf_WorkFlowENS.UpdUser, //修改者
Memo = objvwf_WorkFlowENS.Memo, //说明
IsCurrentUse = objvwf_WorkFlowENS.IsCurrentUse, //是否当前使用
};
 return objvwf_WorkFlowENT;
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
public static void CheckProperty4Condition(this clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
 clsvwf_WorkFlowBL.vwf_WorkFlowDA.CheckProperty4Condition(objvwf_WorkFlowEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvwf_WorkFlowEN objvwf_WorkFlowCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvwf_WorkFlowCond.IsUpdated(convwf_WorkFlow.WorkFlowId) == true)
{
string strComparisonOpWorkFlowId = objvwf_WorkFlowCond.dicFldComparisonOp[convwf_WorkFlow.WorkFlowId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_WorkFlow.WorkFlowId, objvwf_WorkFlowCond.WorkFlowId, strComparisonOpWorkFlowId);
}
if (objvwf_WorkFlowCond.IsUpdated(convwf_WorkFlow.WorkFlowName) == true)
{
string strComparisonOpWorkFlowName = objvwf_WorkFlowCond.dicFldComparisonOp[convwf_WorkFlow.WorkFlowName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_WorkFlow.WorkFlowName, objvwf_WorkFlowCond.WorkFlowName, strComparisonOpWorkFlowName);
}
if (objvwf_WorkFlowCond.IsUpdated(convwf_WorkFlow.WorkFlowNameSim) == true)
{
string strComparisonOpWorkFlowNameSim = objvwf_WorkFlowCond.dicFldComparisonOp[convwf_WorkFlow.WorkFlowNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_WorkFlow.WorkFlowNameSim, objvwf_WorkFlowCond.WorkFlowNameSim, strComparisonOpWorkFlowNameSim);
}
if (objvwf_WorkFlowCond.IsUpdated(convwf_WorkFlow.PrjId) == true)
{
string strComparisonOpPrjId = objvwf_WorkFlowCond.dicFldComparisonOp[convwf_WorkFlow.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_WorkFlow.PrjId, objvwf_WorkFlowCond.PrjId, strComparisonOpPrjId);
}
if (objvwf_WorkFlowCond.IsUpdated(convwf_WorkFlow.PrjName) == true)
{
string strComparisonOpPrjName = objvwf_WorkFlowCond.dicFldComparisonOp[convwf_WorkFlow.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_WorkFlow.PrjName, objvwf_WorkFlowCond.PrjName, strComparisonOpPrjName);
}
if (objvwf_WorkFlowCond.IsUpdated(convwf_WorkFlow.UpdDate) == true)
{
string strComparisonOpUpdDate = objvwf_WorkFlowCond.dicFldComparisonOp[convwf_WorkFlow.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_WorkFlow.UpdDate, objvwf_WorkFlowCond.UpdDate, strComparisonOpUpdDate);
}
if (objvwf_WorkFlowCond.IsUpdated(convwf_WorkFlow.UpdUser) == true)
{
string strComparisonOpUpdUser = objvwf_WorkFlowCond.dicFldComparisonOp[convwf_WorkFlow.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_WorkFlow.UpdUser, objvwf_WorkFlowCond.UpdUser, strComparisonOpUpdUser);
}
if (objvwf_WorkFlowCond.IsUpdated(convwf_WorkFlow.Memo) == true)
{
string strComparisonOpMemo = objvwf_WorkFlowCond.dicFldComparisonOp[convwf_WorkFlow.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_WorkFlow.Memo, objvwf_WorkFlowCond.Memo, strComparisonOpMemo);
}
if (objvwf_WorkFlowCond.IsUpdated(convwf_WorkFlow.IsCurrentUse) == true)
{
if (objvwf_WorkFlowCond.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convwf_WorkFlow.IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convwf_WorkFlow.IsCurrentUse);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vwf_WorkFlow
{
public virtual bool UpdRelaTabDate(string strWorkFlowId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工作流(vwf_WorkFlow)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvwf_WorkFlowBL
{
public static RelatedActions_vwf_WorkFlow relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vwf_WorkFlowListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vwf_WorkFlowList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvwf_WorkFlowEN> arrvwf_WorkFlowObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvwf_WorkFlowDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvwf_WorkFlowDA vwf_WorkFlowDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvwf_WorkFlowDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvwf_WorkFlowBL()
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
if (string.IsNullOrEmpty(clsvwf_WorkFlowEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvwf_WorkFlowEN._ConnectString);
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
objDS = vwf_WorkFlowDA.GetDataSet(strWhereCond);
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
objDS = vwf_WorkFlowDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vwf_WorkFlowDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vwf_WorkFlow(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vwf_WorkFlowDA.GetDataTable_vwf_WorkFlow(strWhereCond);
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
objDT = vwf_WorkFlowDA.GetDataTable(strWhereCond);
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
objDT = vwf_WorkFlowDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vwf_WorkFlowDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vwf_WorkFlowDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vwf_WorkFlowDA.GetDataTable_Top(objTopPara);
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
objDT = vwf_WorkFlowDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vwf_WorkFlowDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vwf_WorkFlowDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vwf_WorkFlowDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vwf_WorkFlowDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vwf_WorkFlowDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vwf_WorkFlowDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vwf_WorkFlowDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrWorkFlowIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvwf_WorkFlowEN> GetObjLstByWorkFlowIdLst(List<string> arrWorkFlowIdLst)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWorkFlowIdLst, true);
 string strWhereCond = string.Format("WorkFlowId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWorkFlowIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvwf_WorkFlowEN> GetObjLstByWorkFlowIdLstCache(List<string> arrWorkFlowIdLst)
{
string strKey = string.Format("{0}", clsvwf_WorkFlowEN._CurrTabName);
List<clsvwf_WorkFlowEN> arrvwf_WorkFlowObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_WorkFlowEN> arrvwf_WorkFlowObjLst_Sel =
arrvwf_WorkFlowObjLstCache
.Where(x => arrWorkFlowIdLst.Contains(x.WorkFlowId));
return arrvwf_WorkFlowObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_WorkFlowEN> GetObjLst(string strWhereCond)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
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
public static List<clsvwf_WorkFlowEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvwf_WorkFlowCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvwf_WorkFlowEN> GetSubObjLstCache(clsvwf_WorkFlowEN objvwf_WorkFlowCond)
{
List<clsvwf_WorkFlowEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_WorkFlowEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_WorkFlow.AttributeName)
{
if (objvwf_WorkFlowCond.IsUpdated(strFldName) == false) continue;
if (objvwf_WorkFlowCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_WorkFlowCond[strFldName].ToString());
}
else
{
if (objvwf_WorkFlowCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_WorkFlowCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_WorkFlowCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_WorkFlowCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_WorkFlowCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_WorkFlowCond[strFldName]));
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
public static List<clsvwf_WorkFlowEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
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
public static List<clsvwf_WorkFlowEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
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
List<clsvwf_WorkFlowEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvwf_WorkFlowEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_WorkFlowEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvwf_WorkFlowEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
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
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
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
public static List<clsvwf_WorkFlowEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvwf_WorkFlowEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvwf_WorkFlowEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
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
public static List<clsvwf_WorkFlowEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
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
public static IEnumerable<clsvwf_WorkFlowEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvwf_WorkFlowEN objvwf_WorkFlowCond, string strOrderBy)
{
List<clsvwf_WorkFlowEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_WorkFlowEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_WorkFlow.AttributeName)
{
if (objvwf_WorkFlowCond.IsUpdated(strFldName) == false) continue;
if (objvwf_WorkFlowCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_WorkFlowCond[strFldName].ToString());
}
else
{
if (objvwf_WorkFlowCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_WorkFlowCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_WorkFlowCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_WorkFlowCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_WorkFlowCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_WorkFlowCond[strFldName]));
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
public static IEnumerable<clsvwf_WorkFlowEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvwf_WorkFlowEN objvwf_WorkFlowCond = JsonConvert.DeserializeObject<clsvwf_WorkFlowEN>(objPagerPara.whereCond);
if (objvwf_WorkFlowCond.sfFldComparisonOp == null)
{
objvwf_WorkFlowCond.dicFldComparisonOp = null;
}
else
{
objvwf_WorkFlowCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvwf_WorkFlowCond.sfFldComparisonOp);
}
clsvwf_WorkFlowBL.SetUpdFlag(objvwf_WorkFlowCond);
 try
{
CheckProperty4Condition(objvwf_WorkFlowCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvwf_WorkFlowBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvwf_WorkFlowCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_WorkFlowEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvwf_WorkFlowEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
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
public static List<clsvwf_WorkFlowEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_WorkFlowEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvwf_WorkFlowEN> arrObjLst = new List<clsvwf_WorkFlowEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
try
{
objvwf_WorkFlowEN.WorkFlowId = objRow[convwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_WorkFlowEN.WorkFlowName = objRow[convwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_WorkFlowEN.WorkFlowNameSim = objRow[convwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_WorkFlowEN.PrjId = objRow[convwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objvwf_WorkFlowEN.PrjName = objRow[convwf_WorkFlow.PrjName].ToString().Trim(); //工程名称
objvwf_WorkFlowEN.UpdDate = objRow[convwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objvwf_WorkFlowEN.UpdUser = objRow[convwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[convwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objvwf_WorkFlowEN.Memo = objRow[convwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[convwf_WorkFlow.Memo].ToString().Trim(); //说明
objvwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_WorkFlowEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvwf_WorkFlow(ref clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
bool bolResult = vwf_WorkFlowDA.Getvwf_WorkFlow(ref objvwf_WorkFlowEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strWorkFlowId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_WorkFlowEN GetObjByWorkFlowId(string strWorkFlowId)
{
if (strWorkFlowId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strWorkFlowId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strWorkFlowId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strWorkFlowId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvwf_WorkFlowEN objvwf_WorkFlowEN = vwf_WorkFlowDA.GetObjByWorkFlowId(strWorkFlowId);
return objvwf_WorkFlowEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvwf_WorkFlowEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvwf_WorkFlowEN objvwf_WorkFlowEN = vwf_WorkFlowDA.GetFirstObj(strWhereCond);
 return objvwf_WorkFlowEN;
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
public static clsvwf_WorkFlowEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvwf_WorkFlowEN objvwf_WorkFlowEN = vwf_WorkFlowDA.GetObjByDataRow(objRow);
 return objvwf_WorkFlowEN;
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
public static clsvwf_WorkFlowEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvwf_WorkFlowEN objvwf_WorkFlowEN = vwf_WorkFlowDA.GetObjByDataRow(objRow);
 return objvwf_WorkFlowEN;
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
 /// <param name = "strWorkFlowId">所给的关键字</param>
 /// <param name = "lstvwf_WorkFlowObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_WorkFlowEN GetObjByWorkFlowIdFromList(string strWorkFlowId, List<clsvwf_WorkFlowEN> lstvwf_WorkFlowObjLst)
{
foreach (clsvwf_WorkFlowEN objvwf_WorkFlowEN in lstvwf_WorkFlowObjLst)
{
if (objvwf_WorkFlowEN.WorkFlowId == strWorkFlowId)
{
return objvwf_WorkFlowEN;
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
 string strWorkFlowId;
 try
 {
 strWorkFlowId = new clsvwf_WorkFlowDA().GetFirstID(strWhereCond);
 return strWorkFlowId;
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
 arrList = vwf_WorkFlowDA.GetID(strWhereCond);
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
bool bolIsExist = vwf_WorkFlowDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strWorkFlowId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strWorkFlowId)
{
if (string.IsNullOrEmpty(strWorkFlowId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strWorkFlowId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vwf_WorkFlowDA.IsExist(strWorkFlowId);
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
 bolIsExist = clsvwf_WorkFlowDA.IsExistTable();
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
 bolIsExist = vwf_WorkFlowDA.IsExistTable(strTabName);
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
 /// <param name = "objvwf_WorkFlowENS">源对象</param>
 /// <param name = "objvwf_WorkFlowENT">目标对象</param>
 public static void CopyTo(clsvwf_WorkFlowEN objvwf_WorkFlowENS, clsvwf_WorkFlowEN objvwf_WorkFlowENT)
{
try
{
objvwf_WorkFlowENT.WorkFlowId = objvwf_WorkFlowENS.WorkFlowId; //工作流Id
objvwf_WorkFlowENT.WorkFlowName = objvwf_WorkFlowENS.WorkFlowName; //工作流名称
objvwf_WorkFlowENT.WorkFlowNameSim = objvwf_WorkFlowENS.WorkFlowNameSim; //工作流简称
objvwf_WorkFlowENT.PrjId = objvwf_WorkFlowENS.PrjId; //工程ID
objvwf_WorkFlowENT.PrjName = objvwf_WorkFlowENS.PrjName; //工程名称
objvwf_WorkFlowENT.UpdDate = objvwf_WorkFlowENS.UpdDate; //修改日期
objvwf_WorkFlowENT.UpdUser = objvwf_WorkFlowENS.UpdUser; //修改者
objvwf_WorkFlowENT.Memo = objvwf_WorkFlowENS.Memo; //说明
objvwf_WorkFlowENT.IsCurrentUse = objvwf_WorkFlowENS.IsCurrentUse; //是否当前使用
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
 /// <param name = "objvwf_WorkFlowEN">源简化对象</param>
 public static void SetUpdFlag(clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
try
{
objvwf_WorkFlowEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvwf_WorkFlowEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convwf_WorkFlow.WorkFlowId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_WorkFlowEN.WorkFlowId = objvwf_WorkFlowEN.WorkFlowId; //工作流Id
}
if (arrFldSet.Contains(convwf_WorkFlow.WorkFlowName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_WorkFlowEN.WorkFlowName = objvwf_WorkFlowEN.WorkFlowName; //工作流名称
}
if (arrFldSet.Contains(convwf_WorkFlow.WorkFlowNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_WorkFlowEN.WorkFlowNameSim = objvwf_WorkFlowEN.WorkFlowNameSim == "[null]" ? null :  objvwf_WorkFlowEN.WorkFlowNameSim; //工作流简称
}
if (arrFldSet.Contains(convwf_WorkFlow.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_WorkFlowEN.PrjId = objvwf_WorkFlowEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convwf_WorkFlow.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_WorkFlowEN.PrjName = objvwf_WorkFlowEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convwf_WorkFlow.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_WorkFlowEN.UpdDate = objvwf_WorkFlowEN.UpdDate == "[null]" ? null :  objvwf_WorkFlowEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convwf_WorkFlow.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_WorkFlowEN.UpdUser = objvwf_WorkFlowEN.UpdUser == "[null]" ? null :  objvwf_WorkFlowEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convwf_WorkFlow.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_WorkFlowEN.Memo = objvwf_WorkFlowEN.Memo == "[null]" ? null :  objvwf_WorkFlowEN.Memo; //说明
}
if (arrFldSet.Contains(convwf_WorkFlow.IsCurrentUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_WorkFlowEN.IsCurrentUse = objvwf_WorkFlowEN.IsCurrentUse; //是否当前使用
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
 /// <param name = "objvwf_WorkFlowEN">源简化对象</param>
 public static void AccessFldValueNull(clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
try
{
if (objvwf_WorkFlowEN.WorkFlowNameSim == "[null]") objvwf_WorkFlowEN.WorkFlowNameSim = null; //工作流简称
if (objvwf_WorkFlowEN.UpdDate == "[null]") objvwf_WorkFlowEN.UpdDate = null; //修改日期
if (objvwf_WorkFlowEN.UpdUser == "[null]") objvwf_WorkFlowEN.UpdUser = null; //修改者
if (objvwf_WorkFlowEN.Memo == "[null]") objvwf_WorkFlowEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
 vwf_WorkFlowDA.CheckProperty4Condition(objvwf_WorkFlowEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_WorkFlowId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convwf_WorkFlow.WorkFlowId); 
List<clsvwf_WorkFlowEN> arrObjLst = clsvwf_WorkFlowBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN()
{
WorkFlowId = "0",
WorkFlowName = "选[v工作流]..."
};
arrObjLst.Insert(0, objvwf_WorkFlowEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convwf_WorkFlow.WorkFlowId;
objComboBox.DisplayMember = convwf_WorkFlow.WorkFlowName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlWorkFlowId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工作流]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convwf_WorkFlow.WorkFlowId); 
IEnumerable<clsvwf_WorkFlowEN> arrObjLst = clsvwf_WorkFlowBL.GetObjLst(strCondition);
objDDL.DataValueField = convwf_WorkFlow.WorkFlowId;
objDDL.DataTextField = convwf_WorkFlow.WorkFlowName;
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
public static void BindDdlWorkFlowIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工作流]...","0");
List<clsvwf_WorkFlowEN> arrvwf_WorkFlowObjLst = GetAllvwf_WorkFlowObjLstCache(); 
objDDL.DataValueField = convwf_WorkFlow.WorkFlowId;
objDDL.DataTextField = convwf_WorkFlow.WorkFlowName;
objDDL.DataSource = arrvwf_WorkFlowObjLst;
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WorkFlowId");
//if (arrvwf_WorkFlowObjLstCache == null)
//{
//arrvwf_WorkFlowObjLstCache = vwf_WorkFlowDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strWorkFlowId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_WorkFlowEN GetObjByWorkFlowIdCache(string strWorkFlowId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvwf_WorkFlowEN._CurrTabName);
List<clsvwf_WorkFlowEN> arrvwf_WorkFlowObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_WorkFlowEN> arrvwf_WorkFlowObjLst_Sel =
arrvwf_WorkFlowObjLstCache
.Where(x=> x.WorkFlowId == strWorkFlowId 
);
if (arrvwf_WorkFlowObjLst_Sel.Count() == 0)
{
   clsvwf_WorkFlowEN obj = clsvwf_WorkFlowBL.GetObjByWorkFlowId(strWorkFlowId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvwf_WorkFlowObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strWorkFlowId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetWorkFlowNameByWorkFlowIdCache(string strWorkFlowId)
{
if (string.IsNullOrEmpty(strWorkFlowId) == true) return "";
//获取缓存中的对象列表
clsvwf_WorkFlowEN objvwf_WorkFlow = GetObjByWorkFlowIdCache(strWorkFlowId);
if (objvwf_WorkFlow == null) return "";
return objvwf_WorkFlow.WorkFlowName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strWorkFlowId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByWorkFlowIdCache(string strWorkFlowId)
{
if (string.IsNullOrEmpty(strWorkFlowId) == true) return "";
//获取缓存中的对象列表
clsvwf_WorkFlowEN objvwf_WorkFlow = GetObjByWorkFlowIdCache(strWorkFlowId);
if (objvwf_WorkFlow == null) return "";
return objvwf_WorkFlow.WorkFlowName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_WorkFlowEN> GetAllvwf_WorkFlowObjLstCache()
{
//获取缓存中的对象列表
List<clsvwf_WorkFlowEN> arrvwf_WorkFlowObjLstCache = GetObjLstCache(); 
return arrvwf_WorkFlowObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_WorkFlowEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvwf_WorkFlowEN._CurrTabName);
List<clsvwf_WorkFlowEN> arrvwf_WorkFlowObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvwf_WorkFlowObjLstCache;
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
string strKey = string.Format("{0}", clsvwf_WorkFlowEN._CurrTabName);
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
 /// <param name = "lstvwf_WorkFlowObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvwf_WorkFlowEN> lstvwf_WorkFlowObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvwf_WorkFlowObjLst, writer);
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
 /// <param name = "lstvwf_WorkFlowObjLst">[clsvwf_WorkFlowEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvwf_WorkFlowEN> lstvwf_WorkFlowObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvwf_WorkFlowBL.listXmlNode);
writer.WriteStartElement(clsvwf_WorkFlowBL.itemsXmlNode);
foreach (clsvwf_WorkFlowEN objvwf_WorkFlowEN in lstvwf_WorkFlowObjLst)
{
clsvwf_WorkFlowBL.SerializeXML(writer, objvwf_WorkFlowEN);
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
 /// <param name = "objvwf_WorkFlowEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
writer.WriteStartElement(clsvwf_WorkFlowBL.itemXmlNode);
 
if (objvwf_WorkFlowEN.WorkFlowId != null)
{
writer.WriteElementString(convwf_WorkFlow.WorkFlowId, objvwf_WorkFlowEN.WorkFlowId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_WorkFlowEN.WorkFlowName != null)
{
writer.WriteElementString(convwf_WorkFlow.WorkFlowName, objvwf_WorkFlowEN.WorkFlowName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_WorkFlowEN.WorkFlowNameSim != null)
{
writer.WriteElementString(convwf_WorkFlow.WorkFlowNameSim, objvwf_WorkFlowEN.WorkFlowNameSim.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_WorkFlowEN.PrjId != null)
{
writer.WriteElementString(convwf_WorkFlow.PrjId, objvwf_WorkFlowEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_WorkFlowEN.PrjName != null)
{
writer.WriteElementString(convwf_WorkFlow.PrjName, objvwf_WorkFlowEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_WorkFlowEN.UpdDate != null)
{
writer.WriteElementString(convwf_WorkFlow.UpdDate, objvwf_WorkFlowEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_WorkFlowEN.UpdUser != null)
{
writer.WriteElementString(convwf_WorkFlow.UpdUser, objvwf_WorkFlowEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_WorkFlowEN.Memo != null)
{
writer.WriteElementString(convwf_WorkFlow.Memo, objvwf_WorkFlowEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convwf_WorkFlow.IsCurrentUse, objvwf_WorkFlowEN.IsCurrentUse.ToString().ToLower(CultureInfo.InvariantCulture));
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
public static clsvwf_WorkFlowEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
reader.Read();
while (!(reader.Name == clsvwf_WorkFlowBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convwf_WorkFlow.WorkFlowId))
{
objvwf_WorkFlowEN.WorkFlowId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_WorkFlow.WorkFlowName))
{
objvwf_WorkFlowEN.WorkFlowName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_WorkFlow.WorkFlowNameSim))
{
objvwf_WorkFlowEN.WorkFlowNameSim = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_WorkFlow.PrjId))
{
objvwf_WorkFlowEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_WorkFlow.PrjName))
{
objvwf_WorkFlowEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_WorkFlow.UpdDate))
{
objvwf_WorkFlowEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_WorkFlow.UpdUser))
{
objvwf_WorkFlowEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_WorkFlow.Memo))
{
objvwf_WorkFlowEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_WorkFlow.IsCurrentUse))
{
objvwf_WorkFlowEN.IsCurrentUse = reader.ReadElementContentAsBoolean();
}
}
return objvwf_WorkFlowEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvwf_WorkFlowObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvwf_WorkFlowEN GetObjFromXmlStr(string strvwf_WorkFlowObjXmlStr)
{
clsvwf_WorkFlowEN objvwf_WorkFlowEN = new clsvwf_WorkFlowEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvwf_WorkFlowObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvwf_WorkFlowBL.itemXmlNode))
{
objvwf_WorkFlowEN = GetObjFromXml(reader);
return objvwf_WorkFlowEN;
}
}
return objvwf_WorkFlowEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvwf_WorkFlowEN);
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
public static string Func(string strInFldName, string strOutFldName, string strWorkFlowId)
{
if (strInFldName != convwf_WorkFlow.WorkFlowId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convwf_WorkFlow.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convwf_WorkFlow.AttributeName));
throw new Exception(strMsg);
}
var objvwf_WorkFlow = clsvwf_WorkFlowBL.GetObjByWorkFlowIdCache(strWorkFlowId);
if (objvwf_WorkFlow == null) return "";
return objvwf_WorkFlow[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvwf_WorkFlowEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvwf_WorkFlowEN objvwf_WorkFlowEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvwf_WorkFlowEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvwf_WorkFlowEN[strField]);
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
 /// <param name = "lstvwf_WorkFlowObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvwf_WorkFlowEN> lstvwf_WorkFlowObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvwf_WorkFlowObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvwf_WorkFlowEN objvwf_WorkFlowEN in lstvwf_WorkFlowObjLst)
{
string strJSON_One = SerializeObjToJSON(objvwf_WorkFlowEN);
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
int intRecCount = clsvwf_WorkFlowDA.GetRecCount(strTabName);
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
int intRecCount = clsvwf_WorkFlowDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvwf_WorkFlowDA.GetRecCount();
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
int intRecCount = clsvwf_WorkFlowDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvwf_WorkFlowCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvwf_WorkFlowEN objvwf_WorkFlowCond)
{
List<clsvwf_WorkFlowEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_WorkFlowEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_WorkFlow.AttributeName)
{
if (objvwf_WorkFlowCond.IsUpdated(strFldName) == false) continue;
if (objvwf_WorkFlowCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_WorkFlowCond[strFldName].ToString());
}
else
{
if (objvwf_WorkFlowCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_WorkFlowCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_WorkFlowCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_WorkFlowCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_WorkFlowCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_WorkFlowCond[strFldName]));
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
 List<string> arrList = clsvwf_WorkFlowDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vwf_WorkFlowDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vwf_WorkFlowDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}