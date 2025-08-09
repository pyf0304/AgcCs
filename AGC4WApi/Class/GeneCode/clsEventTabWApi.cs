
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEventTabWApi
 表名:EventTab(00050031)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:41:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsEventTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "lngEventId">EventId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetEventId(this clsEventTabEN objEventTabEN, long lngEventId, string strComparisonOp="")
	{
objEventTabEN.EventId = lngEventId; //EventId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.EventId) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.EventId, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.EventId] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetTabName(this clsEventTabEN objEventTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, conEventTab.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, conEventTab.TabName);
objEventTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.TabName) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.TabName, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.TabName] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strColName">ColName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetColName(this clsEventTabEN objEventTabEN, string strColName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strColName, conEventTab.ColName);
clsCheckSql.CheckFieldLen(strColName, 30, conEventTab.ColName);
objEventTabEN.ColName = strColName; //ColName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.ColName) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.ColName, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.ColName] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRecordId">RecordId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetRecordId(this clsEventTabEN objEventTabEN, string strRecordId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecordId, 30, conEventTab.RecordId);
objEventTabEN.RecordId = strRecordId; //RecordId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.RecordId) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.RecordId, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.RecordId] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strInitValue">初始值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetInitValue(this clsEventTabEN objEventTabEN, string strInitValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInitValue, 1000, conEventTab.InitValue);
objEventTabEN.InitValue = strInitValue; //初始值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.InitValue) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.InitValue, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.InitValue] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdateValue">UpdateValue</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetUpdateValue(this clsEventTabEN objEventTabEN, string strUpdateValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdateValue, 1000, conEventTab.UpdateValue);
objEventTabEN.UpdateValue = strUpdateValue; //UpdateValue
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.UpdateValue) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.UpdateValue, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.UpdateValue] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetUpdDate(this clsEventTabEN objEventTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conEventTab.UpdDate);
objEventTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.UpdDate) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.UpdDate, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.UpdDate] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdTime">修改时间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetUpdTime(this clsEventTabEN objEventTabEN, string strUpdTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdTime, 6, conEventTab.UpdTime);
objEventTabEN.UpdTime = strUpdTime; //修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.UpdTime) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.UpdTime, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.UpdTime] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdNameId">UpdNameId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetUpdNameId(this clsEventTabEN objEventTabEN, string strUpdNameId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdNameId, 18, conEventTab.UpdNameId);
objEventTabEN.UpdNameId = strUpdNameId; //UpdNameId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.UpdNameId) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.UpdNameId, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.UpdNameId] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOpdType">OpdType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetOpdType(this clsEventTabEN objEventTabEN, string strOpdType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpdType, 20, conEventTab.OpdType);
objEventTabEN.OpdType = strOpdType; //OpdType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.OpdType) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.OpdType, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.OpdType] = strComparisonOp;
}
}
return objEventTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEventTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEventTabEN SetMemo(this clsEventTabEN objEventTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conEventTab.Memo);
objEventTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEventTabEN.dicFldComparisonOp.ContainsKey(conEventTab.Memo) == false)
{
objEventTabEN.dicFldComparisonOp.Add(conEventTab.Memo, strComparisonOp);
}
else
{
objEventTabEN.dicFldComparisonOp[conEventTab.Memo] = strComparisonOp;
}
}
return objEventTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsEventTabEN objEventTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objEventTabCond.IsUpdated(conEventTab.EventId) == true)
{
string strComparisonOpEventId = objEventTabCond.dicFldComparisonOp[conEventTab.EventId];
strWhereCond += string.Format(" And {0} {2} {1}", conEventTab.EventId, objEventTabCond.EventId, strComparisonOpEventId);
}
if (objEventTabCond.IsUpdated(conEventTab.TabName) == true)
{
string strComparisonOpTabName = objEventTabCond.dicFldComparisonOp[conEventTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.TabName, objEventTabCond.TabName, strComparisonOpTabName);
}
if (objEventTabCond.IsUpdated(conEventTab.ColName) == true)
{
string strComparisonOpColName = objEventTabCond.dicFldComparisonOp[conEventTab.ColName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.ColName, objEventTabCond.ColName, strComparisonOpColName);
}
if (objEventTabCond.IsUpdated(conEventTab.RecordId) == true)
{
string strComparisonOpRecordId = objEventTabCond.dicFldComparisonOp[conEventTab.RecordId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.RecordId, objEventTabCond.RecordId, strComparisonOpRecordId);
}
if (objEventTabCond.IsUpdated(conEventTab.InitValue) == true)
{
string strComparisonOpInitValue = objEventTabCond.dicFldComparisonOp[conEventTab.InitValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.InitValue, objEventTabCond.InitValue, strComparisonOpInitValue);
}
if (objEventTabCond.IsUpdated(conEventTab.UpdateValue) == true)
{
string strComparisonOpUpdateValue = objEventTabCond.dicFldComparisonOp[conEventTab.UpdateValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.UpdateValue, objEventTabCond.UpdateValue, strComparisonOpUpdateValue);
}
if (objEventTabCond.IsUpdated(conEventTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objEventTabCond.dicFldComparisonOp[conEventTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.UpdDate, objEventTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objEventTabCond.IsUpdated(conEventTab.UpdTime) == true)
{
string strComparisonOpUpdTime = objEventTabCond.dicFldComparisonOp[conEventTab.UpdTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.UpdTime, objEventTabCond.UpdTime, strComparisonOpUpdTime);
}
if (objEventTabCond.IsUpdated(conEventTab.UpdNameId) == true)
{
string strComparisonOpUpdNameId = objEventTabCond.dicFldComparisonOp[conEventTab.UpdNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.UpdNameId, objEventTabCond.UpdNameId, strComparisonOpUpdNameId);
}
if (objEventTabCond.IsUpdated(conEventTab.OpdType) == true)
{
string strComparisonOpOpdType = objEventTabCond.dicFldComparisonOp[conEventTab.OpdType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.OpdType, objEventTabCond.OpdType, strComparisonOpOpdType);
}
if (objEventTabCond.IsUpdated(conEventTab.Memo) == true)
{
string strComparisonOpMemo = objEventTabCond.dicFldComparisonOp[conEventTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEventTab.Memo, objEventTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsEventTabEN objEventTabEN)
{
 if (objEventTabEN.EventId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objEventTabEN.sfUpdFldSetStr = objEventTabEN.getsfUpdFldSetStr();
clsEventTabWApi.CheckPropertyNew(objEventTabEN); 
bool bolResult = clsEventTabWApi.UpdateRecord(objEventTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabWApi.ReFreshCache();
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
 /// 获取唯一性条件串--EventTab(事件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabName_ColName_OpdType
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objEventTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsEventTabEN objEventTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objEventTabEN == null) return "";
if (objEventTabEN.EventId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objEventTabEN.TabName);
 sbCondition.AppendFormat(" and ColName = '{0}'", objEventTabEN.ColName);
 sbCondition.AppendFormat(" and OpdType = '{0}'", objEventTabEN.OpdType);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("EventId !=  {0}", objEventTabEN.EventId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objEventTabEN.TabName);
 sbCondition.AppendFormat(" and ColName = '{0}'", objEventTabEN.ColName);
 sbCondition.AppendFormat(" and OpdType = '{0}'", objEventTabEN.OpdType);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsEventTabEN objEventTabEN)
{
try
{
clsEventTabWApi.CheckPropertyNew(objEventTabEN); 
bool bolResult = clsEventTabWApi.AddNewRecord(objEventTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabWApi.ReFreshCache();
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
 /// <param name = "objEventTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsEventTabEN objEventTabEN, string strWhereCond)
{
try
{
clsEventTabWApi.CheckPropertyNew(objEventTabEN); 
bool bolResult = clsEventTabWApi.UpdateWithCondition(objEventTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabWApi.ReFreshCache();
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
 /// 事件(EventTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsEventTabWApi
{
private static readonly string mstrApiControllerName = "EventTabApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsEventTabWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsEventTabEN objEventTabEN)
{
if (!Object.Equals(null, objEventTabEN.TabName) && GetStrLen(objEventTabEN.TabName) > 100)
{
 throw new Exception("字段[表名]的长度不能超过100!");
}
if (!Object.Equals(null, objEventTabEN.ColName) && GetStrLen(objEventTabEN.ColName) > 30)
{
 throw new Exception("字段[ColName]的长度不能超过30!");
}
if (!Object.Equals(null, objEventTabEN.RecordId) && GetStrLen(objEventTabEN.RecordId) > 30)
{
 throw new Exception("字段[RecordId]的长度不能超过30!");
}
if (!Object.Equals(null, objEventTabEN.InitValue) && GetStrLen(objEventTabEN.InitValue) > 1000)
{
 throw new Exception("字段[初始值]的长度不能超过1000!");
}
if (!Object.Equals(null, objEventTabEN.UpdateValue) && GetStrLen(objEventTabEN.UpdateValue) > 1000)
{
 throw new Exception("字段[UpdateValue]的长度不能超过1000!");
}
if (!Object.Equals(null, objEventTabEN.UpdDate) && GetStrLen(objEventTabEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objEventTabEN.UpdTime) && GetStrLen(objEventTabEN.UpdTime) > 6)
{
 throw new Exception("字段[修改时间]的长度不能超过6!");
}
if (!Object.Equals(null, objEventTabEN.UpdNameId) && GetStrLen(objEventTabEN.UpdNameId) > 18)
{
 throw new Exception("字段[UpdNameId]的长度不能超过18!");
}
if (!Object.Equals(null, objEventTabEN.OpdType) && GetStrLen(objEventTabEN.OpdType) > 20)
{
 throw new Exception("字段[OpdType]的长度不能超过20!");
}
if (!Object.Equals(null, objEventTabEN.Memo) && GetStrLen(objEventTabEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objEventTabEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngEventId">表关键字</param>
 /// <returns>表对象</returns>
public static clsEventTabEN GetObjByEventId(long lngEventId)
{
if (lngEventId == 0) return null;
string strAction = "GetObjByEventId";
clsEventTabEN objEventTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngEventId"] = lngEventId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objEventTabEN = JsonConvert.DeserializeObject<clsEventTabEN>(strJson);
return objEventTabEN;
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
public static clsEventTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsEventTabEN objEventTabEN;
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
objEventTabEN = JsonConvert.DeserializeObject<clsEventTabEN>(strJson);
return objEventTabEN;
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
 /// <param name = "lngEventId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsEventTabEN GetObjByEventIdCache(long lngEventId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsEventTabEN._CurrTabName);
List<clsEventTabEN> arrEventTabObjLstCache = GetObjLstCache();
IEnumerable <clsEventTabEN> arrEventTabObjLst_Sel =
from objEventTabEN in arrEventTabObjLstCache
where objEventTabEN.EventId == lngEventId 
select objEventTabEN;
if (arrEventTabObjLst_Sel.Count() == 0)
{
   clsEventTabEN obj = clsEventTabWApi.GetObjByEventId(lngEventId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrEventTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsEventTabEN> GetObjLst(string strWhereCond)
{
 List<clsEventTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEventTabEN>>(strJson);
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
 /// <param name = "arrEventId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsEventTabEN> GetObjLstByEventIdLst(List<long> arrEventId)
{
 List<clsEventTabEN> arrObjLst; 
string strAction = "GetObjLstByEventIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrEventId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsEventTabEN>>(strJson);
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
 /// <param name = "arrEventId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsEventTabEN> GetObjLstByEventIdLstCache(List<long> arrEventId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsEventTabEN._CurrTabName);
List<clsEventTabEN> arrEventTabObjLstCache = GetObjLstCache();
IEnumerable <clsEventTabEN> arrEventTabObjLst_Sel =
from objEventTabEN in arrEventTabObjLstCache
where arrEventId.Contains(objEventTabEN.EventId)
select objEventTabEN;
return arrEventTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsEventTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsEventTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEventTabEN>>(strJson);
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
public static List<clsEventTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsEventTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEventTabEN>>(strJson);
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
public static List<clsEventTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsEventTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEventTabEN>>(strJson);
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
public static List<clsEventTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsEventTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsEventTabEN>>(strJson);
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
public static int DelRecord(long lngEventId)
{
string strAction = "DelRecord";
try
{
 clsEventTabEN objEventTabEN = clsEventTabWApi.GetObjByEventId(lngEventId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngEventId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsEventTabWApi.ReFreshCache();
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
public static int DelEventTabs(List<string> arrEventId)
{
string strAction = "DelEventTabs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrEventId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsEventTabWApi.ReFreshCache();
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
public static int DelEventTabsByCond(string strWhereCond)
{
string strAction = "DelEventTabsByCond";
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
public static bool AddNewRecord(clsEventTabEN objEventTabEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEventTabEN>(objEventTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabWApi.ReFreshCache();
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
 /// <param name = "objEventTabEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsEventTabEN objEventTabEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEventTabEN>(objEventTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEventTabWApi.ReFreshCache();
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
public static bool UpdateRecord(clsEventTabEN objEventTabEN)
{
if (string.IsNullOrEmpty(objEventTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objEventTabEN.EventId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEventTabEN>(objEventTabEN);
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
 /// <param name = "objEventTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsEventTabEN objEventTabEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objEventTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objEventTabEN.EventId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objEventTabEN.EventId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEventTabEN>(objEventTabEN);
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
public static bool IsExist(long lngEventId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngEventId"] = lngEventId.ToString()
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
 /// <param name = "objEventTabENS">源对象</param>
 /// <param name = "objEventTabENT">目标对象</param>
 public static void CopyTo(clsEventTabEN objEventTabENS, clsEventTabEN objEventTabENT)
{
try
{
objEventTabENT.EventId = objEventTabENS.EventId; //EventId
objEventTabENT.TabName = objEventTabENS.TabName; //表名
objEventTabENT.ColName = objEventTabENS.ColName; //ColName
objEventTabENT.RecordId = objEventTabENS.RecordId; //RecordId
objEventTabENT.InitValue = objEventTabENS.InitValue; //初始值
objEventTabENT.UpdateValue = objEventTabENS.UpdateValue; //UpdateValue
objEventTabENT.UpdDate = objEventTabENS.UpdDate; //修改日期
objEventTabENT.UpdTime = objEventTabENS.UpdTime; //修改时间
objEventTabENT.UpdNameId = objEventTabENS.UpdNameId; //UpdNameId
objEventTabENT.OpdType = objEventTabENS.OpdType; //OpdType
objEventTabENT.Memo = objEventTabENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsEventTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsEventTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsEventTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsEventTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsEventTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsEventTabEN._AttributeName)
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
string strKey = string.Format("{0}", clsEventTabEN._CurrTabName);
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
if (clsEventTabWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsEventTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsEventTabWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsEventTabEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsEventTabEN._CurrTabName;
List<clsEventTabEN> arrEventTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrEventTabObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsEventTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conEventTab.EventId, Type.GetType("System.Int64"));
objDT.Columns.Add(conEventTab.TabName, Type.GetType("System.String"));
objDT.Columns.Add(conEventTab.ColName, Type.GetType("System.String"));
objDT.Columns.Add(conEventTab.RecordId, Type.GetType("System.String"));
objDT.Columns.Add(conEventTab.InitValue, Type.GetType("System.String"));
objDT.Columns.Add(conEventTab.UpdateValue, Type.GetType("System.String"));
objDT.Columns.Add(conEventTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conEventTab.UpdTime, Type.GetType("System.String"));
objDT.Columns.Add(conEventTab.UpdNameId, Type.GetType("System.String"));
objDT.Columns.Add(conEventTab.OpdType, Type.GetType("System.String"));
objDT.Columns.Add(conEventTab.Memo, Type.GetType("System.String"));
foreach (clsEventTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conEventTab.EventId] = objInFor[conEventTab.EventId];
objDR[conEventTab.TabName] = objInFor[conEventTab.TabName];
objDR[conEventTab.ColName] = objInFor[conEventTab.ColName];
objDR[conEventTab.RecordId] = objInFor[conEventTab.RecordId];
objDR[conEventTab.InitValue] = objInFor[conEventTab.InitValue];
objDR[conEventTab.UpdateValue] = objInFor[conEventTab.UpdateValue];
objDR[conEventTab.UpdDate] = objInFor[conEventTab.UpdDate];
objDR[conEventTab.UpdTime] = objInFor[conEventTab.UpdTime];
objDR[conEventTab.UpdNameId] = objInFor[conEventTab.UpdNameId];
objDR[conEventTab.OpdType] = objInFor[conEventTab.OpdType];
objDR[conEventTab.Memo] = objInFor[conEventTab.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 事件(EventTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4EventTab : clsCommFun4BL
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
clsEventTabWApi.ReFreshThisCache();
}
}

}