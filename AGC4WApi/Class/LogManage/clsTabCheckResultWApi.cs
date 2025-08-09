
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckResultWApi
 表名:TabCheckResult(00050188)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:39:13
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
public static class  clsTabCheckResultWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetmId(this clsTabCheckResultEN objTabCheckResultEN, long lngmId, string strComparisonOp="")
	{
objTabCheckResultEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.mId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.mId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.mId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetPrjId(this clsTabCheckResultEN objTabCheckResultEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabCheckResult.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabCheckResult.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabCheckResult.PrjId);
objTabCheckResultEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.PrjId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.PrjId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.PrjId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetPrjDataBaseId(this clsTabCheckResultEN objTabCheckResultEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, conTabCheckResult.PrjDataBaseId);
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, conTabCheckResult.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, conTabCheckResult.PrjDataBaseId);
objTabCheckResultEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.PrjDataBaseId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.PrjDataBaseId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.PrjDataBaseId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetTabId(this clsTabCheckResultEN objTabCheckResultEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, conTabCheckResult.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conTabCheckResult.TabId);
objTabCheckResultEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.TabId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.TabId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.TabId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetFldId(this clsTabCheckResultEN objTabCheckResultEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conTabCheckResult.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conTabCheckResult.FldId);
objTabCheckResultEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.FldId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.FldId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.FldId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "intErrorLevelId">错误等级Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetErrorLevelId(this clsTabCheckResultEN objTabCheckResultEN, int intErrorLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intErrorLevelId, conTabCheckResult.ErrorLevelId);
objTabCheckResultEN.ErrorLevelId = intErrorLevelId; //错误等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.ErrorLevelId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.ErrorLevelId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.ErrorLevelId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrorMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetErrorMsg(this clsTabCheckResultEN objTabCheckResultEN, string strErrorMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrorMsg, conTabCheckResult.ErrorMsg);
clsCheckSql.CheckFieldLen(strErrorMsg, 5000, conTabCheckResult.ErrorMsg);
objTabCheckResultEN.ErrorMsg = strErrorMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.ErrorMsg) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.ErrorMsg, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.ErrorMsg] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCheckErrorTypeId">表检查错误类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetTabCheckErrorTypeId(this clsTabCheckResultEN objTabCheckResultEN, string strTabCheckErrorTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCheckErrorTypeId, conTabCheckResult.TabCheckErrorTypeId);
clsCheckSql.CheckFieldLen(strTabCheckErrorTypeId, 2, conTabCheckResult.TabCheckErrorTypeId);
clsCheckSql.CheckFieldForeignKey(strTabCheckErrorTypeId, 2, conTabCheckResult.TabCheckErrorTypeId);
objTabCheckResultEN.TabCheckErrorTypeId = strTabCheckErrorTypeId; //表检查错误类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.TabCheckErrorTypeId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.TabCheckErrorTypeId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.TabCheckErrorTypeId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strCheckDate">检查日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetCheckDate(this clsTabCheckResultEN objTabCheckResultEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCheckDate, conTabCheckResult.CheckDate);
clsCheckSql.CheckFieldLen(strCheckDate, 20, conTabCheckResult.CheckDate);
objTabCheckResultEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.CheckDate) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.CheckDate, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.CheckDate] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strCheckUser">检查人</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetCheckUser(this clsTabCheckResultEN objTabCheckResultEN, string strCheckUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCheckUser, conTabCheckResult.CheckUser);
clsCheckSql.CheckFieldLen(strCheckUser, 20, conTabCheckResult.CheckUser);
objTabCheckResultEN.CheckUser = strCheckUser; //检查人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.CheckUser) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.CheckUser, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.CheckUser] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetMemo(this clsTabCheckResultEN objTabCheckResultEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabCheckResult.Memo);
objTabCheckResultEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.Memo) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.Memo, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.Memo] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabCheckResultEN objTabCheckResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.mId) == true)
{
string strComparisonOpmId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabCheckResult.mId, objTabCheckResultCond.mId, strComparisonOpmId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.PrjId) == true)
{
string strComparisonOpPrjId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.PrjId, objTabCheckResultCond.PrjId, strComparisonOpPrjId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.PrjDataBaseId, objTabCheckResultCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.TabId) == true)
{
string strComparisonOpTabId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.TabId, objTabCheckResultCond.TabId, strComparisonOpTabId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.FldId) == true)
{
string strComparisonOpFldId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.FldId, objTabCheckResultCond.FldId, strComparisonOpFldId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.ErrorLevelId) == true)
{
string strComparisonOpErrorLevelId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.ErrorLevelId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabCheckResult.ErrorLevelId, objTabCheckResultCond.ErrorLevelId, strComparisonOpErrorLevelId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.ErrorMsg) == true)
{
string strComparisonOpErrorMsg = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.ErrorMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.ErrorMsg, objTabCheckResultCond.ErrorMsg, strComparisonOpErrorMsg);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.TabCheckErrorTypeId) == true)
{
string strComparisonOpTabCheckErrorTypeId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.TabCheckErrorTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.TabCheckErrorTypeId, objTabCheckResultCond.TabCheckErrorTypeId, strComparisonOpTabCheckErrorTypeId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.CheckDate) == true)
{
string strComparisonOpCheckDate = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.CheckDate, objTabCheckResultCond.CheckDate, strComparisonOpCheckDate);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.CheckUser) == true)
{
string strComparisonOpCheckUser = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.CheckUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.CheckUser, objTabCheckResultCond.CheckUser, strComparisonOpCheckUser);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.Memo) == true)
{
string strComparisonOpMemo = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.Memo, objTabCheckResultCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabCheckResultEN objTabCheckResultEN)
{
 if (objTabCheckResultEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTabCheckResultEN.sfUpdFldSetStr = objTabCheckResultEN.getsfUpdFldSetStr();
clsTabCheckResultWApi.CheckPropertyNew(objTabCheckResultEN); 
bool bolResult = clsTabCheckResultWApi.UpdateRecord(objTabCheckResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultWApi.ReFreshCache();
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
 /// 获取唯一性条件串--TabCheckResult(表检查结果), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_PrjDataBaseId_TabId_FldId_ErrorMsg
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabCheckResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsTabCheckResultEN objTabCheckResultEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabCheckResultEN == null) return "";
if (objTabCheckResultEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckResultEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckResultEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckResultEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabCheckResultEN.FldId);
 sbCondition.AppendFormat(" and ErrorMsg = '{0}'", objTabCheckResultEN.ErrorMsg);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabCheckResultEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckResultEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckResultEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckResultEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabCheckResultEN.FldId);
 sbCondition.AppendFormat(" and ErrorMsg = '{0}'", objTabCheckResultEN.ErrorMsg);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabCheckResultEN objTabCheckResultEN)
{
try
{
clsTabCheckResultWApi.CheckPropertyNew(objTabCheckResultEN); 
bool bolResult = clsTabCheckResultWApi.AddNewRecord(objTabCheckResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultWApi.ReFreshCache();
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
 /// <param name = "objTabCheckResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabCheckResultEN objTabCheckResultEN, string strWhereCond)
{
try
{
clsTabCheckResultWApi.CheckPropertyNew(objTabCheckResultEN); 
bool bolResult = clsTabCheckResultWApi.UpdateWithCondition(objTabCheckResultEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultWApi.ReFreshCache();
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
 /// 表检查结果(TabCheckResult)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTabCheckResultWApi
{
private static readonly string mstrApiControllerName = "TabCheckResultApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsTabCheckResultWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTabCheckResultEN objTabCheckResultEN)
{
if (!Object.Equals(null, objTabCheckResultEN.PrjId) && GetStrLen(objTabCheckResultEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTabCheckResultEN.PrjDataBaseId) && GetStrLen(objTabCheckResultEN.PrjDataBaseId) > 4)
{
 throw new Exception("字段[项目数据库Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTabCheckResultEN.TabId) && GetStrLen(objTabCheckResultEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objTabCheckResultEN.FldId) && GetStrLen(objTabCheckResultEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTabCheckResultEN.ErrorMsg) && GetStrLen(objTabCheckResultEN.ErrorMsg) > 5000)
{
 throw new Exception("字段[错误信息]的长度不能超过5000!");
}
if (!Object.Equals(null, objTabCheckResultEN.TabCheckErrorTypeId) && GetStrLen(objTabCheckResultEN.TabCheckErrorTypeId) > 2)
{
 throw new Exception("字段[表检查错误类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTabCheckResultEN.CheckDate) && GetStrLen(objTabCheckResultEN.CheckDate) > 20)
{
 throw new Exception("字段[检查日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTabCheckResultEN.CheckUser) && GetStrLen(objTabCheckResultEN.CheckUser) > 20)
{
 throw new Exception("字段[检查人]的长度不能超过20!");
}
if (!Object.Equals(null, objTabCheckResultEN.Memo) && GetStrLen(objTabCheckResultEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objTabCheckResultEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabCheckResultEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsTabCheckResultEN objTabCheckResultEN;
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
objTabCheckResultEN = JsonConvert.DeserializeObject<clsTabCheckResultEN>(strJson);
return objTabCheckResultEN;
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
public static clsTabCheckResultEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsTabCheckResultEN objTabCheckResultEN;
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
objTabCheckResultEN = JsonConvert.DeserializeObject<clsTabCheckResultEN>(strJson);
return objTabCheckResultEN;
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
public static clsTabCheckResultEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTabCheckResultEN._CurrTabName);
List<clsTabCheckResultEN> arrTabCheckResultObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckResultEN> arrTabCheckResultObjLst_Sel =
from objTabCheckResultEN in arrTabCheckResultObjLstCache
where objTabCheckResultEN.mId == lngmId 
select objTabCheckResultEN;
if (arrTabCheckResultObjLst_Sel.Count() == 0)
{
   clsTabCheckResultEN obj = clsTabCheckResultWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTabCheckResultObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLst(string strWhereCond)
{
 List<clsTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckResultEN>>(strJson);
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
public static List<clsTabCheckResultEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckResultEN>>(strJson);
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
public static IEnumerable<clsTabCheckResultEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTabCheckResultEN._CurrTabName);
List<clsTabCheckResultEN> arrTabCheckResultObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckResultEN> arrTabCheckResultObjLst_Sel =
from objTabCheckResultEN in arrTabCheckResultObjLstCache
where arrMId.Contains(objTabCheckResultEN.mId)
select objTabCheckResultEN;
return arrTabCheckResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckResultEN>>(strJson);
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
public static List<clsTabCheckResultEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckResultEN>>(strJson);
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
public static List<clsTabCheckResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckResultEN>>(strJson);
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
public static List<clsTabCheckResultEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsTabCheckResultEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabCheckResultEN>>(strJson);
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
 clsTabCheckResultEN objTabCheckResultEN = clsTabCheckResultWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTabCheckResultWApi.ReFreshCache();
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
public static int DelTabCheckResults(List<string> arrmId)
{
string strAction = "DelTabCheckResults";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTabCheckResultWApi.ReFreshCache();
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
public static int DelTabCheckResultsByCond(string strWhereCond)
{
string strAction = "DelTabCheckResultsByCond";
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
public static bool AddNewRecord(clsTabCheckResultEN objTabCheckResultEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabCheckResultEN>(objTabCheckResultEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultWApi.ReFreshCache();
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
 /// <param name = "objTabCheckResultEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsTabCheckResultEN objTabCheckResultEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabCheckResultEN>(objTabCheckResultEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultWApi.ReFreshCache();
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
public static bool UpdateRecord(clsTabCheckResultEN objTabCheckResultEN)
{
if (string.IsNullOrEmpty(objTabCheckResultEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabCheckResultEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabCheckResultEN>(objTabCheckResultEN);
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
 /// <param name = "objTabCheckResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTabCheckResultEN objTabCheckResultEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTabCheckResultEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabCheckResultEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabCheckResultEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabCheckResultEN>(objTabCheckResultEN);
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
 /// <param name = "objTabCheckResultENS">源对象</param>
 /// <param name = "objTabCheckResultENT">目标对象</param>
 public static void CopyTo(clsTabCheckResultEN objTabCheckResultENS, clsTabCheckResultEN objTabCheckResultENT)
{
try
{
objTabCheckResultENT.mId = objTabCheckResultENS.mId; //mId
objTabCheckResultENT.PrjId = objTabCheckResultENS.PrjId; //工程Id
objTabCheckResultENT.PrjDataBaseId = objTabCheckResultENS.PrjDataBaseId; //项目数据库Id
objTabCheckResultENT.TabId = objTabCheckResultENS.TabId; //表ID
objTabCheckResultENT.FldId = objTabCheckResultENS.FldId; //字段Id
objTabCheckResultENT.ErrorLevelId = objTabCheckResultENS.ErrorLevelId; //错误等级Id
objTabCheckResultENT.ErrorMsg = objTabCheckResultENS.ErrorMsg; //错误信息
objTabCheckResultENT.TabCheckErrorTypeId = objTabCheckResultENS.TabCheckErrorTypeId; //表检查错误类型Id
objTabCheckResultENT.CheckDate = objTabCheckResultENS.CheckDate; //检查日期
objTabCheckResultENT.CheckUser = objTabCheckResultENS.CheckUser; //检查人
objTabCheckResultENT.Memo = objTabCheckResultENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsTabCheckResultEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTabCheckResultEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTabCheckResultEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTabCheckResultEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTabCheckResultEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTabCheckResultEN._AttributeName)
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
string strKey = string.Format("{0}", clsTabCheckResultEN._CurrTabName);
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
if (clsTabCheckResultWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTabCheckResultEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabCheckResultWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsTabCheckResultEN._CurrTabName;
List<clsTabCheckResultEN> arrTabCheckResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrTabCheckResultObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTabCheckResultEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTabCheckResult.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conTabCheckResult.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckResult.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckResult.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckResult.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckResult.ErrorLevelId, Type.GetType("System.Int32"));
objDT.Columns.Add(conTabCheckResult.ErrorMsg, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckResult.TabCheckErrorTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckResult.CheckDate, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckResult.CheckUser, Type.GetType("System.String"));
objDT.Columns.Add(conTabCheckResult.Memo, Type.GetType("System.String"));
foreach (clsTabCheckResultEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTabCheckResult.mId] = objInFor[conTabCheckResult.mId];
objDR[conTabCheckResult.PrjId] = objInFor[conTabCheckResult.PrjId];
objDR[conTabCheckResult.PrjDataBaseId] = objInFor[conTabCheckResult.PrjDataBaseId];
objDR[conTabCheckResult.TabId] = objInFor[conTabCheckResult.TabId];
objDR[conTabCheckResult.FldId] = objInFor[conTabCheckResult.FldId];
objDR[conTabCheckResult.ErrorLevelId] = objInFor[conTabCheckResult.ErrorLevelId];
objDR[conTabCheckResult.ErrorMsg] = objInFor[conTabCheckResult.ErrorMsg];
objDR[conTabCheckResult.TabCheckErrorTypeId] = objInFor[conTabCheckResult.TabCheckErrorTypeId];
objDR[conTabCheckResult.CheckDate] = objInFor[conTabCheckResult.CheckDate];
objDR[conTabCheckResult.CheckUser] = objInFor[conTabCheckResult.CheckUser];
objDR[conTabCheckResult.Memo] = objInFor[conTabCheckResult.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 表检查结果(TabCheckResult)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4TabCheckResult : clsCommFun4BL
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
clsTabCheckResultWApi.ReFreshThisCache();
}
}

}