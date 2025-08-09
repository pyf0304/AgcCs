
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckStatusWApi
 表名:TabCheckStatus(00050568)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:40:11
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsTabCheckStatusWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetmId(this clsTabCheckStatusEN objTabCheckStatusEN, long lngmId, string strComparisonOp="")
	{
objTabCheckStatusEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.mId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.mId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.mId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetPrjId(this clsTabCheckStatusEN objTabCheckStatusEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabCheckStatus.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabCheckStatus.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabCheckStatus.PrjId);
objTabCheckStatusEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.PrjId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.PrjId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.PrjId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetPrjDataBaseId(this clsTabCheckStatusEN objTabCheckStatusEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, conTabCheckStatus.PrjDataBaseId);
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, conTabCheckStatus.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, conTabCheckStatus.PrjDataBaseId);
objTabCheckStatusEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.PrjDataBaseId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.PrjDataBaseId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.PrjDataBaseId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetTabId(this clsTabCheckStatusEN objTabCheckStatusEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conTabCheckStatus.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conTabCheckStatus.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conTabCheckStatus.TabId);
objTabCheckStatusEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.TabId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.TabId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.TabId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedCheckTab">是否需要检查表字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetIsNeedCheckTab(this clsTabCheckStatusEN objTabCheckStatusEN, bool bolIsNeedCheckTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedCheckTab, conTabCheckStatus.IsNeedCheckTab);
objTabCheckStatusEN.IsNeedCheckTab = bolIsNeedCheckTab; //是否需要检查表字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.IsNeedCheckTab) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.IsNeedCheckTab, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.IsNeedCheckTab] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "intErrorLevelId">错误等级Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetErrorLevelId(this clsTabCheckStatusEN objTabCheckStatusEN, int intErrorLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intErrorLevelId, conTabCheckStatus.ErrorLevelId);
objTabCheckStatusEN.ErrorLevelId = intErrorLevelId; //错误等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.ErrorLevelId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.ErrorLevelId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.ErrorLevelId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrorMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetErrorMsg(this clsTabCheckStatusEN objTabCheckStatusEN, string strErrorMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrorMsg, 5000, conTabCheckStatus.ErrorMsg);
objTabCheckStatusEN.ErrorMsg = strErrorMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.ErrorMsg) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.ErrorMsg, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.ErrorMsg] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCheckErrorTypeId">表检查错误类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetTabCheckErrorTypeId(this clsTabCheckStatusEN objTabCheckStatusEN, string strTabCheckErrorTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCheckErrorTypeId, 2, conTabCheckStatus.TabCheckErrorTypeId);
clsCheckSql.CheckFieldForeignKey(strTabCheckErrorTypeId, 2, conTabCheckStatus.TabCheckErrorTypeId);
objTabCheckStatusEN.TabCheckErrorTypeId = strTabCheckErrorTypeId; //表检查错误类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.TabCheckErrorTypeId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.TabCheckErrorTypeId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.TabCheckErrorTypeId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetUpdDate(this clsTabCheckStatusEN objTabCheckStatusEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conTabCheckStatus.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTabCheckStatus.UpdDate);
objTabCheckStatusEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.UpdDate) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.UpdDate, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.UpdDate] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetUpdUser(this clsTabCheckStatusEN objTabCheckStatusEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conTabCheckStatus.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conTabCheckStatus.UpdUser);
objTabCheckStatusEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.UpdUser) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.UpdUser, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.UpdUser] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetMemo(this clsTabCheckStatusEN objTabCheckStatusEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabCheckStatus.Memo);
objTabCheckStatusEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.Memo) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.Memo, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.Memo] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabCheckStatusEN objTabCheckStatusCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.mId) == true)
{
string strComparisonOpmId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabCheckStatus.mId, objTabCheckStatusCond.mId, strComparisonOpmId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.PrjId) == true)
{
string strComparisonOpPrjId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.PrjId, objTabCheckStatusCond.PrjId, strComparisonOpPrjId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.PrjDataBaseId, objTabCheckStatusCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.TabId) == true)
{
string strComparisonOpTabId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.TabId, objTabCheckStatusCond.TabId, strComparisonOpTabId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.IsNeedCheckTab) == true)
{
if (objTabCheckStatusCond.IsNeedCheckTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabCheckStatus.IsNeedCheckTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabCheckStatus.IsNeedCheckTab);
}
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.ErrorLevelId) == true)
{
string strComparisonOpErrorLevelId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.ErrorLevelId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabCheckStatus.ErrorLevelId, objTabCheckStatusCond.ErrorLevelId, strComparisonOpErrorLevelId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.ErrorMsg) == true)
{
string strComparisonOpErrorMsg = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.ErrorMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.ErrorMsg, objTabCheckStatusCond.ErrorMsg, strComparisonOpErrorMsg);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.TabCheckErrorTypeId) == true)
{
string strComparisonOpTabCheckErrorTypeId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.TabCheckErrorTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.TabCheckErrorTypeId, objTabCheckStatusCond.TabCheckErrorTypeId, strComparisonOpTabCheckErrorTypeId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.UpdDate) == true)
{
string strComparisonOpUpdDate = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.UpdDate, objTabCheckStatusCond.UpdDate, strComparisonOpUpdDate);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.UpdUser) == true)
{
string strComparisonOpUpdUser = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.UpdUser, objTabCheckStatusCond.UpdUser, strComparisonOpUpdUser);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.Memo) == true)
{
string strComparisonOpMemo = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.Memo, objTabCheckStatusCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabCheckStatusEN objTabCheckStatusEN)
{
 if (objTabCheckStatusEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTabCheckStatusEN.sfUpdFldSetStr = objTabCheckStatusEN.getsfUpdFldSetStr();
clsTabCheckStatusWApi.CheckPropertyNew(objTabCheckStatusEN); 
bool bolResult = clsTabCheckStatusWApi.UpdateRecord(objTabCheckStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusWApi.ReFreshCache(objTabCheckStatusEN.PrjId);
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
 /// 获取唯一性条件串--TabCheckStatus(表检查状态), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_PrjDataBaseId_TabId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsTabCheckStatusEN objTabCheckStatusEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabCheckStatusEN == null) return "";
if (objTabCheckStatusEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckStatusEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckStatusEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckStatusEN.TabId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabCheckStatusEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckStatusEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckStatusEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckStatusEN.TabId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabCheckStatusEN objTabCheckStatusEN)
{
try
{
clsTabCheckStatusWApi.CheckPropertyNew(objTabCheckStatusEN); 
bool bolResult = clsTabCheckStatusWApi.AddNewRecord(objTabCheckStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusWApi.ReFreshCache(objTabCheckStatusEN.PrjId);
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
 /// <param name = "objTabCheckStatusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabCheckStatusEN objTabCheckStatusEN, string strWhereCond)
{
try
{
clsTabCheckStatusWApi.CheckPropertyNew(objTabCheckStatusEN); 
bool bolResult = clsTabCheckStatusWApi.UpdateWithCondition(objTabCheckStatusEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusWApi.ReFreshCache(objTabCheckStatusEN.PrjId);
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
 /// 表检查状态(TabCheckStatus)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTabCheckStatusWApi
{
private static readonly string mstrApiControllerName = "TabCheckStatusApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsTabCheckStatusWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTabCheckStatusEN objTabCheckStatusEN)
{
if (!Object.Equals(null, objTabCheckStatusEN.PrjId) && GetStrLen(objTabCheckStatusEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTabCheckStatusEN.PrjDataBaseId) && GetStrLen(objTabCheckStatusEN.PrjDataBaseId) > 4)
{
 throw new Exception("字段[项目数据库Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTabCheckStatusEN.TabId) && GetStrLen(objTabCheckStatusEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objTabCheckStatusEN.ErrorMsg) && GetStrLen(objTabCheckStatusEN.ErrorMsg) > 5000)
{
 throw new Exception("字段[错误信息]的长度不能超过5000!");
}
if (!Object.Equals(null, objTabCheckStatusEN.TabCheckErrorTypeId) && GetStrLen(objTabCheckStatusEN.TabCheckErrorTypeId) > 2)
{
 throw new Exception("字段[表检查错误类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTabCheckStatusEN.UpdDate) && GetStrLen(objTabCheckStatusEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTabCheckStatusEN.UpdUser) && GetStrLen(objTabCheckStatusEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objTabCheckStatusEN.Memo) && GetStrLen(objTabCheckStatusEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objTabCheckStatusEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabCheckStatusEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsTabCheckStatusEN objTabCheckStatusEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objTabCheckStatusEN = JsonConvert.DeserializeObject<clsTabCheckStatusEN>(strJson);
return objTabCheckStatusEN;
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
public static clsTabCheckStatusEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsTabCheckStatusEN objTabCheckStatusEN;
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
objTabCheckStatusEN = JsonConvert.DeserializeObject<clsTabCheckStatusEN>(strJson);
return objTabCheckStatusEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabCheckStatusEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
List<clsTabCheckStatusEN> arrTabCheckStatusObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabCheckStatusEN> arrTabCheckStatusObjLst_Sel =
from objTabCheckStatusEN in arrTabCheckStatusObjLstCache
where objTabCheckStatusEN.mId == lngmId 
select objTabCheckStatusEN;
if (arrTabCheckStatusObjLst_Sel.Count() == 0)
{
   clsTabCheckStatusEN obj = clsTabCheckStatusWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTabCheckStatusObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckStatusEN> GetObjLst(string strWhereCond)
{
 List<clsTabCheckStatusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckStatusEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckStatusEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsTabCheckStatusEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckStatusEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsTabCheckStatusEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
List<clsTabCheckStatusEN> arrTabCheckStatusObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabCheckStatusEN> arrTabCheckStatusObjLst_Sel =
from objTabCheckStatusEN in arrTabCheckStatusObjLstCache
where arrMId.Contains(objTabCheckStatusEN.mId)
select objTabCheckStatusEN;
return arrTabCheckStatusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckStatusEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTabCheckStatusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckStatusEN>>(strJson);
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
public static List<clsTabCheckStatusEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTabCheckStatusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckStatusEN>>(strJson);
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
public static List<clsTabCheckStatusEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTabCheckStatusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckStatusEN>>(strJson);
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
public static List<clsTabCheckStatusEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsTabCheckStatusEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckStatusEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTabCheckStatusWApi.ReFreshCache(objTabCheckStatusEN.PrjId);
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
public static int DelTabCheckStatuss(List<string> arrmId)
{
string strAction = "DelTabCheckStatuss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusWApi.GetObjBymId(long.Parse(arrmId[0]));
clsTabCheckStatusWApi.ReFreshCache(objTabCheckStatusEN.PrjId);
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
public static int DelTabCheckStatussByCond(string strWhereCond)
{
string strAction = "DelTabCheckStatussByCond";
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
public static bool AddNewRecord(clsTabCheckStatusEN objTabCheckStatusEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabCheckStatusEN>(objTabCheckStatusEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusWApi.ReFreshCache(objTabCheckStatusEN.PrjId);
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
 /// <param name = "objTabCheckStatusEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsTabCheckStatusEN objTabCheckStatusEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabCheckStatusEN>(objTabCheckStatusEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusWApi.ReFreshCache(objTabCheckStatusEN.PrjId);
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
public static bool UpdateRecord(clsTabCheckStatusEN objTabCheckStatusEN)
{
if (string.IsNullOrEmpty(objTabCheckStatusEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabCheckStatusEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabCheckStatusEN>(objTabCheckStatusEN);
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
 /// <param name = "objTabCheckStatusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTabCheckStatusEN objTabCheckStatusEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTabCheckStatusEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabCheckStatusEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabCheckStatusEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabCheckStatusEN>(objTabCheckStatusEN);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objTabCheckStatusENS">源对象</param>
 /// <param name = "objTabCheckStatusENT">目标对象</param>
 public static void CopyTo(clsTabCheckStatusEN objTabCheckStatusENS, clsTabCheckStatusEN objTabCheckStatusENT)
{
try
{
objTabCheckStatusENT.mId = objTabCheckStatusENS.mId; //mId
objTabCheckStatusENT.PrjId = objTabCheckStatusENS.PrjId; //工程Id
objTabCheckStatusENT.PrjDataBaseId = objTabCheckStatusENS.PrjDataBaseId; //项目数据库Id
objTabCheckStatusENT.TabId = objTabCheckStatusENS.TabId; //表ID
objTabCheckStatusENT.IsNeedCheckTab = objTabCheckStatusENS.IsNeedCheckTab; //是否需要检查表字段
objTabCheckStatusENT.ErrorLevelId = objTabCheckStatusENS.ErrorLevelId; //错误等级Id
objTabCheckStatusENT.ErrorMsg = objTabCheckStatusENS.ErrorMsg; //错误信息
objTabCheckStatusENT.TabCheckErrorTypeId = objTabCheckStatusENS.TabCheckErrorTypeId; //表检查错误类型Id
objTabCheckStatusENT.UpdDate = objTabCheckStatusENS.UpdDate; //修改日期
objTabCheckStatusENT.UpdUser = objTabCheckStatusENS.UpdUser; //修改者
objTabCheckStatusENT.Memo = objTabCheckStatusENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsTabCheckStatusEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTabCheckStatusEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTabCheckStatusEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTabCheckStatusEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTabCheckStatusEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTabCheckStatusEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsTabCheckStatusWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsTabCheckStatusWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
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
if (clsTabCheckStatusWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsTabCheckStatusWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabCheckStatusEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsTabCheckStatusWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsTabCheckStatusWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsTabCheckStatusEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsTabCheckStatusEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conTabCheckStatus.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
List<clsTabCheckStatusEN> arrTabCheckStatusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrTabCheckStatusObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabCheckStatusEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsTabCheckStatusEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsTabCheckStatusWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsTabCheckStatusWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
List<clsTabCheckStatusEN> arrTabCheckStatusObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrTabCheckStatusObjLstCache = CacheHelper.Get<List<clsTabCheckStatusEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrTabCheckStatusObjLstCache = CacheHelper.Get<List<clsTabCheckStatusEN>>(strKey);
}
return arrTabCheckStatusObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTabCheckStatusEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTabCheckStatus.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conTabCheckStatus.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckStatus.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckStatus.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckStatus.IsNeedCheckTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabCheckStatus.ErrorLevelId, Type.GetType("System.Int32"));
objDT.Columns.Add(conTabCheckStatus.ErrorMsg, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckStatus.TabCheckErrorTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckStatus.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckStatus.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckStatus.Memo, Type.GetType("System.String"));
foreach (clsTabCheckStatusEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTabCheckStatus.mId] = objInFor[conTabCheckStatus.mId];
objDR[conTabCheckStatus.PrjId] = objInFor[conTabCheckStatus.PrjId];
objDR[conTabCheckStatus.PrjDataBaseId] = objInFor[conTabCheckStatus.PrjDataBaseId];
objDR[conTabCheckStatus.TabId] = objInFor[conTabCheckStatus.TabId];
objDR[conTabCheckStatus.IsNeedCheckTab] = objInFor[conTabCheckStatus.IsNeedCheckTab];
objDR[conTabCheckStatus.ErrorLevelId] = objInFor[conTabCheckStatus.ErrorLevelId];
objDR[conTabCheckStatus.ErrorMsg] = objInFor[conTabCheckStatus.ErrorMsg];
objDR[conTabCheckStatus.TabCheckErrorTypeId] = objInFor[conTabCheckStatus.TabCheckErrorTypeId];
objDR[conTabCheckStatus.UpdDate] = objInFor[conTabCheckStatus.UpdDate];
objDR[conTabCheckStatus.UpdUser] = objInFor[conTabCheckStatus.UpdUser];
objDR[conTabCheckStatus.Memo] = objInFor[conTabCheckStatus.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 表检查状态(TabCheckStatus)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4TabCheckStatus : clsCommFun4BLV2
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
clsTabCheckStatusWApi.ReFreshThisCache(strPrjId);
}
}

}