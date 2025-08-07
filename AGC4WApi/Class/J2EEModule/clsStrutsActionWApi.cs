
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStrutsActionWApi
 表名:StrutsAction(00050142)
 生成代码版本:2020.06.21.1
 生成日期:2020/06/27 00:00:14
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:J2EE模块
 模块英文名:J2EEModule
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
using AGC.Const;

namespace AGC4WApi
{
public static class clsStrutsActionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetActionId(this clsStrutsActionEN objStrutsActionEN, string strActionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strActionId, 10, clsStrutsActionEN.con_ActionId);
clsCheckSql.CheckFieldForeignKey(strActionId, 10, clsStrutsActionEN.con_ActionId);
objStrutsActionEN.ActionId = strActionId; //ActionId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_ActionId) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_ActionId, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_ActionId] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetActionName(this clsStrutsActionEN objStrutsActionEN, string strActionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strActionName, clsStrutsActionEN.con_ActionName);
clsCheckSql.CheckFieldLen(strActionName, 100, clsStrutsActionEN.con_ActionName);
objStrutsActionEN.ActionName = strActionName; //Action名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_ActionName) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_ActionName, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_ActionName] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetActionParameter(this clsStrutsActionEN objStrutsActionEN, string strActionParameter, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strActionParameter, 20, clsStrutsActionEN.con_ActionParameter);
objStrutsActionEN.ActionParameter = strActionParameter; //Action参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_ActionParameter) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_ActionParameter, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_ActionParameter] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetActionPath(this clsStrutsActionEN objStrutsActionEN, string strActionPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strActionPath, 100, clsStrutsActionEN.con_ActionPath);
objStrutsActionEN.ActionPath = strActionPath; //Action路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_ActionPath) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_ActionPath, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_ActionPath] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetActionScope(this clsStrutsActionEN objStrutsActionEN, string strActionScope, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strActionScope, 20, clsStrutsActionEN.con_ActionScope);
objStrutsActionEN.ActionScope = strActionScope; //Action范围
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_ActionScope) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_ActionScope, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_ActionScope] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetActionType(this clsStrutsActionEN objStrutsActionEN, string strActionType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strActionType, 100, clsStrutsActionEN.con_ActionType);
objStrutsActionEN.ActionType = strActionType; //Action类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_ActionType) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_ActionType, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_ActionType] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetViewGroupId(this clsStrutsActionEN objStrutsActionEN, string strViewGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupId, clsStrutsActionEN.con_ViewGroupId);
clsCheckSql.CheckFieldLen(strViewGroupId, 8, clsStrutsActionEN.con_ViewGroupId);
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, clsStrutsActionEN.con_ViewGroupId);
objStrutsActionEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_ViewGroupId) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_ViewGroupId, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_ViewGroupId] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetPrjId(this clsStrutsActionEN objStrutsActionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, clsStrutsActionEN.con_PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, clsStrutsActionEN.con_PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, clsStrutsActionEN.con_PrjId);
objStrutsActionEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_PrjId) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_PrjId, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_PrjId] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetUpdDate(this clsStrutsActionEN objStrutsActionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, clsStrutsActionEN.con_UpdDate);
objStrutsActionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_UpdDate) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_UpdDate, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_UpdDate] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetUserId(this clsStrutsActionEN objStrutsActionEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, clsStrutsActionEN.con_UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, clsStrutsActionEN.con_UserId);
objStrutsActionEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_UserId) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_UserId, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_UserId] = strComparisonOp;
}
}
return objStrutsActionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStrutsActionEN SetMemo(this clsStrutsActionEN objStrutsActionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, clsStrutsActionEN.con_Memo);
objStrutsActionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStrutsActionEN.dicFldComparisonOp.ContainsKey(clsStrutsActionEN.con_Memo) == false)
{
objStrutsActionEN.dicFldComparisonOp.Add(clsStrutsActionEN.con_Memo, strComparisonOp);
}
else
{
objStrutsActionEN.dicFldComparisonOp[clsStrutsActionEN.con_Memo] = strComparisonOp;
}
}
return objStrutsActionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsStrutsActionEN objStrutsAction_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_ActionId) == true)
{
string strComparisonOp_ActionId = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_ActionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_ActionId, objStrutsAction_Cond.ActionId, strComparisonOp_ActionId);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_ActionName) == true)
{
string strComparisonOp_ActionName = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_ActionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_ActionName, objStrutsAction_Cond.ActionName, strComparisonOp_ActionName);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_ActionParameter) == true)
{
string strComparisonOp_ActionParameter = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_ActionParameter];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_ActionParameter, objStrutsAction_Cond.ActionParameter, strComparisonOp_ActionParameter);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_ActionPath) == true)
{
string strComparisonOp_ActionPath = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_ActionPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_ActionPath, objStrutsAction_Cond.ActionPath, strComparisonOp_ActionPath);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_ActionScope) == true)
{
string strComparisonOp_ActionScope = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_ActionScope];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_ActionScope, objStrutsAction_Cond.ActionScope, strComparisonOp_ActionScope);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_ActionType) == true)
{
string strComparisonOp_ActionType = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_ActionType];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_ActionType, objStrutsAction_Cond.ActionType, strComparisonOp_ActionType);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_ViewGroupId) == true)
{
string strComparisonOp_ViewGroupId = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_ViewGroupId, objStrutsAction_Cond.ViewGroupId, strComparisonOp_ViewGroupId);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_PrjId) == true)
{
string strComparisonOp_PrjId = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_PrjId, objStrutsAction_Cond.PrjId, strComparisonOp_PrjId);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_UpdDate) == true)
{
string strComparisonOp_UpdDate = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_UpdDate, objStrutsAction_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_UserId) == true)
{
string strComparisonOp_UserId = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_UserId, objStrutsAction_Cond.UserId, strComparisonOp_UserId);
}
if (objStrutsAction_Cond.IsUpdated(clsStrutsActionEN.con_Memo) == true)
{
string strComparisonOp_Memo = objStrutsAction_Cond.dicFldComparisonOp[clsStrutsActionEN.con_Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsStrutsActionEN.con_Memo, objStrutsAction_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsStrutsActionEN objStrutsActionEN)
{
 if (string.IsNullOrEmpty(objStrutsActionEN.ActionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objStrutsActionEN.sf_UpdFldSetStr = objStrutsActionEN.getsf_UpdFldSetStr();
clsStrutsActionWApi.CheckPropertyNew(objStrutsActionEN); 
bool bolResult = clsStrutsActionWApi.UpdateRecord(objStrutsActionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStrutsActionWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objStrutsActionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsStrutsActionEN objStrutsActionEN)
{
 if (string.IsNullOrEmpty(objStrutsActionEN.ActionId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsStrutsActionWApi.IsExist(objStrutsActionEN.ActionId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objStrutsActionEN.ActionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsStrutsActionWApi.CheckPropertyNew(objStrutsActionEN); 
bool bolResult = clsStrutsActionWApi.AddNewRecord(objStrutsActionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStrutsActionWApi.ReFreshCache();
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
 /// <param name = "objStrutsActionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordWithMaxId(this clsStrutsActionEN objStrutsActionEN)
{
try
{
clsStrutsActionWApi.CheckPropertyNew(objStrutsActionEN); 
bool bolResult = clsStrutsActionWApi.AddNewRecordWithMaxId(objStrutsActionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStrutsActionWApi.ReFreshCache();
return bolResult;
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
 /// <param name = "objStrutsActionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsStrutsActionEN objStrutsActionEN, string strWhereCond)
{
try
{
clsStrutsActionWApi.CheckPropertyNew(objStrutsActionEN); 
bool bolResult = clsStrutsActionWApi.UpdateWithCondition(objStrutsActionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStrutsActionWApi.ReFreshCache();
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
 /// StrutsAction(StrutsAction)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsStrutsActionWApi
{
private static readonly string mstrApiControllerName = "StrutsActionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsStrutsActionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ActionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[StrutsAction]...","0");
List<clsStrutsActionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ActionId";
objDDL.DataTextField="ActionName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_ActionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", clsStrutsActionEN.con_ActionId); 
List<clsStrutsActionEN> arrObjLst = clsStrutsActionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsStrutsActionEN objStrutsActionEN = new clsStrutsActionEN()
{
ActionId = "0",
ActionName = "选[StrutsAction]..."
};
arrObjLst.Insert(0, objStrutsActionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = clsStrutsActionEN.con_ActionId;
objComboBox.DisplayMember = clsStrutsActionEN.con_ActionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsStrutsActionEN objStrutsActionEN)
{
if (!Object.Equals(null, objStrutsActionEN.ActionId) && GetStrLen(objStrutsActionEN.ActionId) > 10)
{
 throw new Exception("字段[ActionId]的长度不能超过10!");
}
if (!Object.Equals(null, objStrutsActionEN.ActionName) && GetStrLen(objStrutsActionEN.ActionName) > 100)
{
 throw new Exception("字段[Action名称]的长度不能超过100!");
}
if (!Object.Equals(null, objStrutsActionEN.ActionParameter) && GetStrLen(objStrutsActionEN.ActionParameter) > 20)
{
 throw new Exception("字段[Action参数]的长度不能超过20!");
}
if (!Object.Equals(null, objStrutsActionEN.ActionPath) && GetStrLen(objStrutsActionEN.ActionPath) > 100)
{
 throw new Exception("字段[Action路径]的长度不能超过100!");
}
if (!Object.Equals(null, objStrutsActionEN.ActionScope) && GetStrLen(objStrutsActionEN.ActionScope) > 20)
{
 throw new Exception("字段[Action范围]的长度不能超过20!");
}
if (!Object.Equals(null, objStrutsActionEN.ActionType) && GetStrLen(objStrutsActionEN.ActionType) > 100)
{
 throw new Exception("字段[Action类型]的长度不能超过100!");
}
if (!Object.Equals(null, objStrutsActionEN.ViewGroupId) && GetStrLen(objStrutsActionEN.ViewGroupId) > 8)
{
 throw new Exception("字段[界面组ID]的长度不能超过8!");
}
if (!Object.Equals(null, objStrutsActionEN.PrjId) && GetStrLen(objStrutsActionEN.PrjId) > 4)
{
 throw new Exception("字段[工程ID]的长度不能超过4!");
}
if (!Object.Equals(null, objStrutsActionEN.UpdDate) && GetStrLen(objStrutsActionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objStrutsActionEN.UserId) && GetStrLen(objStrutsActionEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objStrutsActionEN.Memo) && GetStrLen(objStrutsActionEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objStrutsActionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strActionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsStrutsActionEN GetObjByActionId(string strActionId)
{
string strAction = "GetObjByActionId";
string strErrMsg = string.Empty;
string strResult = "";
clsStrutsActionEN objStrutsActionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ActionId"] = strActionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objStrutsActionEN = JsonConvert.DeserializeObject<clsStrutsActionEN>((string)jobjReturn["ReturnObj"]);
return objStrutsActionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strActionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsStrutsActionEN GetObjByActionId_WA_Cache(string strActionId)
{
string strAction = "GetObjByActionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsStrutsActionEN objStrutsActionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ActionId"] = strActionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objStrutsActionEN = JsonConvert.DeserializeObject<clsStrutsActionEN>((string)jobjReturn["ReturnObj"]);
return objStrutsActionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static clsStrutsActionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsStrutsActionEN objStrutsActionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objStrutsActionEN = JsonConvert.DeserializeObject<clsStrutsActionEN>((string)jobjReturn["ReturnObj"]);
return objStrutsActionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strActionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsStrutsActionEN GetObjByActionId_Cache(string strActionId)
{
if (string.IsNullOrEmpty(strActionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsStrutsActionEN._CurrTabName_S);
List<clsStrutsActionEN> arrStrutsActionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStrutsActionEN> arrStrutsActionObjLst_Sel =
from objStrutsActionEN in arrStrutsActionObjLst_Cache
where objStrutsActionEN.ActionId == strActionId
select objStrutsActionEN;
if (arrStrutsActionObjLst_Sel.Count() == 0)
{
   clsStrutsActionEN obj = clsStrutsActionWApi.GetObjByActionId(strActionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrStrutsActionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strActionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetActionNameByActionId_Cache(string strActionId)
{
if (string.IsNullOrEmpty(strActionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsStrutsActionEN._CurrTabName_S);
List<clsStrutsActionEN> arrStrutsActionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStrutsActionEN> arrStrutsActionObjLst_Sel1 =
from objStrutsActionEN in arrStrutsActionObjLst_Cache
where objStrutsActionEN.ActionId == strActionId
select objStrutsActionEN;
List <clsStrutsActionEN> arrStrutsActionObjLst_Sel = new List<clsStrutsActionEN>();
foreach (clsStrutsActionEN obj in arrStrutsActionObjLst_Sel1)
{
arrStrutsActionObjLst_Sel.Add(obj);
}
if (arrStrutsActionObjLst_Sel.Count > 0)
{
return arrStrutsActionObjLst_Sel[0].ActionName;
}
string strErrMsgForGetObjById = string.Format("在StrutsAction对象缓存列表中,找不到记录[ActionId = {0}](函数:{1})", strActionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsStrutsActionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strActionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByActionId_Cache(string strActionId)
{
if (string.IsNullOrEmpty(strActionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsStrutsActionEN._CurrTabName_S);
List<clsStrutsActionEN> arrStrutsActionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStrutsActionEN> arrStrutsActionObjLst_Sel1 =
from objStrutsActionEN in arrStrutsActionObjLst_Cache
where objStrutsActionEN.ActionId == strActionId
select objStrutsActionEN;
List <clsStrutsActionEN> arrStrutsActionObjLst_Sel = new List<clsStrutsActionEN>();
foreach (clsStrutsActionEN obj in arrStrutsActionObjLst_Sel1)
{
arrStrutsActionObjLst_Sel.Add(obj);
}
if (arrStrutsActionObjLst_Sel.Count > 0)
{
return arrStrutsActionObjLst_Sel[0].ActionName;
}
string strErrMsgForGetObjById = string.Format("在StrutsAction对象缓存列表中,找不到记录的相关名称[ActionId = {0}](函数:{1})", strActionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsStrutsActionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsStrutsActionEN> GetObjLst(string strWhereCond)
{
 List<clsStrutsActionEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStrutsActionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsStrutsActionEN> GetObjLstByActionIdLst(List<string> arrActionId)
{
 List<clsStrutsActionEN> arrObjLst = null; 
string strAction = "GetObjLstByActionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrActionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStrutsActionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strActionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsStrutsActionEN> GetObjLstByActionIdLst_Cache(List<string> arrActionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsStrutsActionEN._CurrTabName_S);
List<clsStrutsActionEN> arrStrutsActionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStrutsActionEN> arrStrutsActionObjLst_Sel =
from objStrutsActionEN in arrStrutsActionObjLst_Cache
where arrActionId.Contains(objStrutsActionEN.ActionId)
select objStrutsActionEN;
return arrStrutsActionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsStrutsActionEN> GetObjLstByActionIdLst_WA_Cache(List<string> arrActionId)
{
 List<clsStrutsActionEN> arrObjLst = null; 
string strAction = "GetObjLstByActionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrActionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStrutsActionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsStrutsActionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsStrutsActionEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStrutsActionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsStrutsActionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsStrutsActionEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStrutsActionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsStrutsActionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsStrutsActionEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStrutsActionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsStrutsActionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsStrutsActionEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStrutsActionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static int DelRecord(string strActionId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strActionId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsStrutsActionWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static int DelStrutsActions(List<string> arrActionId)
{
string strAction = "DelStrutsActions";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrActionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsStrutsActionWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static int DelStrutsActionsByCond(string strWhereCond)
{
string strAction = "DelStrutsActionsByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static bool AddNewRecord(clsStrutsActionEN objStrutsActionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStrutsActionEN>(objStrutsActionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStrutsActionWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <returns>是否成功?</returns>
public static bool AddNewRecordWithMaxId(clsStrutsActionEN objStrutsActionEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStrutsActionEN>(objStrutsActionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStrutsActionWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsStrutsActionEN objStrutsActionEN)
{
if (string.IsNullOrEmpty(objStrutsActionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objStrutsActionEN.ActionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStrutsActionEN>(objStrutsActionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "objStrutsActionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsStrutsActionEN objStrutsActionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objStrutsActionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objStrutsActionEN.ActionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objStrutsActionEN.ActionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStrutsActionEN>(objStrutsActionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static bool IsExist(string strActionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ActionId"] = strActionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
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
 /// <param name = "objStrutsActionENS">源对象</param>
 /// <param name = "objStrutsActionENT">目标对象</param>
 public static void CopyTo(clsStrutsActionEN objStrutsActionENS, clsStrutsActionEN objStrutsActionENT)
{
try
{
objStrutsActionENT.ActionId = objStrutsActionENS.ActionId; //ActionId
objStrutsActionENT.ActionName = objStrutsActionENS.ActionName; //Action名称
objStrutsActionENT.ActionParameter = objStrutsActionENS.ActionParameter; //Action参数
objStrutsActionENT.ActionPath = objStrutsActionENS.ActionPath; //Action路径
objStrutsActionENT.ActionScope = objStrutsActionENS.ActionScope; //Action范围
objStrutsActionENT.ActionType = objStrutsActionENS.ActionType; //Action类型
objStrutsActionENT.ViewGroupId = objStrutsActionENS.ViewGroupId; //界面组ID
objStrutsActionENT.PrjId = objStrutsActionENS.PrjId; //工程ID
objStrutsActionENT.UpdDate = objStrutsActionENS.UpdDate; //修改日期
objStrutsActionENT.UserId = objStrutsActionENS.UserId; //用户Id
objStrutsActionENT.Memo = objStrutsActionENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsStrutsActionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsStrutsActionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsStrutsActionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsStrutsActionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsStrutsActionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsStrutsActionEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsStrutsActionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStrutsActionWApi没有刷新缓存机制(clsStrutsActionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ActionId");
//if (arrStrutsActionObjLst_Cache == null)
//{
//arrStrutsActionObjLst_Cache = await clsStrutsActionWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsStrutsActionEN._CurrTabName_S);
CacheHelper.Remove(strKey);
strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
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
if (clsStrutsActionWApi.objCommFun4BL != null) 
{
 string strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsStrutsActionEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsStrutsActionWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsStrutsActionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsStrutsActionEN._CurrTabName_S);
List<clsStrutsActionEN> arrStrutsActionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrStrutsActionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsStrutsActionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conStrutsAction.ActionId, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.ActionName, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.ActionParameter, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.ActionPath, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.ActionScope, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.ActionType, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.ViewGroupId, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conStrutsAction.Memo, Type.GetType("System.String"));
foreach (clsStrutsActionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conStrutsAction.ActionId] = objInFor[conStrutsAction.ActionId];
objDR[conStrutsAction.ActionName] = objInFor[conStrutsAction.ActionName];
objDR[conStrutsAction.ActionParameter] = objInFor[conStrutsAction.ActionParameter];
objDR[conStrutsAction.ActionPath] = objInFor[conStrutsAction.ActionPath];
objDR[conStrutsAction.ActionScope] = objInFor[conStrutsAction.ActionScope];
objDR[conStrutsAction.ActionType] = objInFor[conStrutsAction.ActionType];
objDR[conStrutsAction.ViewGroupId] = objInFor[conStrutsAction.ViewGroupId];
objDR[conStrutsAction.PrjId] = objInFor[conStrutsAction.PrjId];
objDR[conStrutsAction.UpdDate] = objInFor[conStrutsAction.UpdDate];
objDR[conStrutsAction.UserId] = objInFor[conStrutsAction.UserId];
objDR[conStrutsAction.Memo] = objInFor[conStrutsAction.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}