
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLog4CreateView4SqlWApi
 表名:Log4CreateView4Sql(00050294)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsLog4CreateView4SqlWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4CreateView4SqlEN SetmId(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN, long lngmId, string strComparisonOp="")
	{
objLog4CreateView4SqlEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(conLog4CreateView4Sql.mId) == false)
{
objLog4CreateView4SqlEN.dicFldComparisonOp.Add(conLog4CreateView4Sql.mId, strComparisonOp);
}
else
{
objLog4CreateView4SqlEN.dicFldComparisonOp[conLog4CreateView4Sql.mId] = strComparisonOp;
}
}
return objLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewId">Sql视图Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4CreateView4SqlEN SetSqlViewId(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, conLog4CreateView4Sql.SqlViewId);
clsCheckSql.CheckFieldLen(strSqlViewId, 8, conLog4CreateView4Sql.SqlViewId);
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, conLog4CreateView4Sql.SqlViewId);
objLog4CreateView4SqlEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(conLog4CreateView4Sql.SqlViewId) == false)
{
objLog4CreateView4SqlEN.dicFldComparisonOp.Add(conLog4CreateView4Sql.SqlViewId, strComparisonOp);
}
else
{
objLog4CreateView4SqlEN.dicFldComparisonOp[conLog4CreateView4Sql.SqlViewId] = strComparisonOp;
}
}
return objLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4CreateView4SqlEN SetPrjDataBaseId(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, conLog4CreateView4Sql.PrjDataBaseId);
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, conLog4CreateView4Sql.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, conLog4CreateView4Sql.PrjDataBaseId);
objLog4CreateView4SqlEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(conLog4CreateView4Sql.PrjDataBaseId) == false)
{
objLog4CreateView4SqlEN.dicFldComparisonOp.Add(conLog4CreateView4Sql.PrjDataBaseId, strComparisonOp);
}
else
{
objLog4CreateView4SqlEN.dicFldComparisonOp[conLog4CreateView4Sql.PrjDataBaseId] = strComparisonOp;
}
}
return objLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateViewDate">建立视图日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4CreateView4SqlEN SetCreateViewDate(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN, string strCreateViewDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateViewDate, 14, conLog4CreateView4Sql.CreateViewDate);
objLog4CreateView4SqlEN.CreateViewDate = strCreateViewDate; //建立视图日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(conLog4CreateView4Sql.CreateViewDate) == false)
{
objLog4CreateView4SqlEN.dicFldComparisonOp.Add(conLog4CreateView4Sql.CreateViewDate, strComparisonOp);
}
else
{
objLog4CreateView4SqlEN.dicFldComparisonOp[conLog4CreateView4Sql.CreateViewDate] = strComparisonOp;
}
}
return objLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4CreateView4SqlEN SetPrjId(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conLog4CreateView4Sql.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conLog4CreateView4Sql.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conLog4CreateView4Sql.PrjId);
objLog4CreateView4SqlEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(conLog4CreateView4Sql.PrjId) == false)
{
objLog4CreateView4SqlEN.dicFldComparisonOp.Add(conLog4CreateView4Sql.PrjId, strComparisonOp);
}
else
{
objLog4CreateView4SqlEN.dicFldComparisonOp[conLog4CreateView4Sql.PrjId] = strComparisonOp;
}
}
return objLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4CreateView4SqlEN SetUserId(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, conLog4CreateView4Sql.UserId);
objLog4CreateView4SqlEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(conLog4CreateView4Sql.UserId) == false)
{
objLog4CreateView4SqlEN.dicFldComparisonOp.Add(conLog4CreateView4Sql.UserId, strComparisonOp);
}
else
{
objLog4CreateView4SqlEN.dicFldComparisonOp[conLog4CreateView4Sql.UserId] = strComparisonOp;
}
}
return objLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4CreateView4SqlEN SetMemo(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conLog4CreateView4Sql.Memo);
objLog4CreateView4SqlEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(conLog4CreateView4Sql.Memo) == false)
{
objLog4CreateView4SqlEN.dicFldComparisonOp.Add(conLog4CreateView4Sql.Memo, strComparisonOp);
}
else
{
objLog4CreateView4SqlEN.dicFldComparisonOp[conLog4CreateView4Sql.Memo] = strComparisonOp;
}
}
return objLog4CreateView4SqlEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsLog4CreateView4SqlEN objLog4CreateView4SqlCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objLog4CreateView4SqlCond.IsUpdated(conLog4CreateView4Sql.mId) == true)
{
string strComparisonOpmId = objLog4CreateView4SqlCond.dicFldComparisonOp[conLog4CreateView4Sql.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conLog4CreateView4Sql.mId, objLog4CreateView4SqlCond.mId, strComparisonOpmId);
}
if (objLog4CreateView4SqlCond.IsUpdated(conLog4CreateView4Sql.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objLog4CreateView4SqlCond.dicFldComparisonOp[conLog4CreateView4Sql.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4CreateView4Sql.SqlViewId, objLog4CreateView4SqlCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objLog4CreateView4SqlCond.IsUpdated(conLog4CreateView4Sql.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objLog4CreateView4SqlCond.dicFldComparisonOp[conLog4CreateView4Sql.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4CreateView4Sql.PrjDataBaseId, objLog4CreateView4SqlCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objLog4CreateView4SqlCond.IsUpdated(conLog4CreateView4Sql.CreateViewDate) == true)
{
string strComparisonOpCreateViewDate = objLog4CreateView4SqlCond.dicFldComparisonOp[conLog4CreateView4Sql.CreateViewDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4CreateView4Sql.CreateViewDate, objLog4CreateView4SqlCond.CreateViewDate, strComparisonOpCreateViewDate);
}
if (objLog4CreateView4SqlCond.IsUpdated(conLog4CreateView4Sql.PrjId) == true)
{
string strComparisonOpPrjId = objLog4CreateView4SqlCond.dicFldComparisonOp[conLog4CreateView4Sql.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4CreateView4Sql.PrjId, objLog4CreateView4SqlCond.PrjId, strComparisonOpPrjId);
}
if (objLog4CreateView4SqlCond.IsUpdated(conLog4CreateView4Sql.UserId) == true)
{
string strComparisonOpUserId = objLog4CreateView4SqlCond.dicFldComparisonOp[conLog4CreateView4Sql.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4CreateView4Sql.UserId, objLog4CreateView4SqlCond.UserId, strComparisonOpUserId);
}
if (objLog4CreateView4SqlCond.IsUpdated(conLog4CreateView4Sql.Memo) == true)
{
string strComparisonOpMemo = objLog4CreateView4SqlCond.dicFldComparisonOp[conLog4CreateView4Sql.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4CreateView4Sql.Memo, objLog4CreateView4SqlCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN)
{
 if (objLog4CreateView4SqlEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objLog4CreateView4SqlEN.sfUpdFldSetStr = objLog4CreateView4SqlEN.getsfUpdFldSetStr();
clsLog4CreateView4SqlWApi.CheckPropertyNew(objLog4CreateView4SqlEN); 
bool bolResult = clsLog4CreateView4SqlWApi.UpdateRecord(objLog4CreateView4SqlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4CreateView4SqlWApi.ReFreshCache();
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
 /// 获取唯一性条件串--Log4CreateView4Sql(建立视图日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SqlViewId_PrjDataBaseId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objLog4CreateView4SqlEN == null) return "";
if (objLog4CreateView4SqlEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objLog4CreateView4SqlEN.SqlViewId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objLog4CreateView4SqlEN.PrjDataBaseId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objLog4CreateView4SqlEN.mId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objLog4CreateView4SqlEN.SqlViewId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objLog4CreateView4SqlEN.PrjDataBaseId);
 return sbCondition.ToString();
}
}
 /// <summary>
 /// 获取唯一性条件串--Log4CreateView4Sql(建立视图日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_PrjDataBaseId_SqlViewId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_V2(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objLog4CreateView4SqlEN == null) return "";
if (objLog4CreateView4SqlEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objLog4CreateView4SqlEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objLog4CreateView4SqlEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objLog4CreateView4SqlEN.SqlViewId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objLog4CreateView4SqlEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objLog4CreateView4SqlEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objLog4CreateView4SqlEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objLog4CreateView4SqlEN.SqlViewId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objLog4CreateView4SqlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN)
{
try
{
clsLog4CreateView4SqlWApi.CheckPropertyNew(objLog4CreateView4SqlEN); 
bool bolResult = clsLog4CreateView4SqlWApi.AddNewRecord(objLog4CreateView4SqlEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4CreateView4SqlWApi.ReFreshCache();
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
 /// <param name = "objLog4CreateView4SqlEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLog4CreateView4SqlEN objLog4CreateView4SqlEN, string strWhereCond)
{
try
{
clsLog4CreateView4SqlWApi.CheckPropertyNew(objLog4CreateView4SqlEN); 
bool bolResult = clsLog4CreateView4SqlWApi.UpdateWithCondition(objLog4CreateView4SqlEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4CreateView4SqlWApi.ReFreshCache();
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
 /// 建立视图日志(Log4CreateView4Sql)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsLog4CreateView4SqlWApi
{
private static readonly string mstrApiControllerName = "Log4CreateView4SqlApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsLog4CreateView4SqlWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsLog4CreateView4SqlEN objLog4CreateView4SqlEN)
{
if (!Object.Equals(null, objLog4CreateView4SqlEN.SqlViewId) && GetStrLen(objLog4CreateView4SqlEN.SqlViewId) > 8)
{
 throw new Exception("字段[Sql视图Id]的长度不能超过8!");
}
if (!Object.Equals(null, objLog4CreateView4SqlEN.PrjDataBaseId) && GetStrLen(objLog4CreateView4SqlEN.PrjDataBaseId) > 4)
{
 throw new Exception("字段[项目数据库Id]的长度不能超过4!");
}
if (!Object.Equals(null, objLog4CreateView4SqlEN.CreateViewDate) && GetStrLen(objLog4CreateView4SqlEN.CreateViewDate) > 14)
{
 throw new Exception("字段[建立视图日期]的长度不能超过14!");
}
if (!Object.Equals(null, objLog4CreateView4SqlEN.PrjId) && GetStrLen(objLog4CreateView4SqlEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objLog4CreateView4SqlEN.UserId) && GetStrLen(objLog4CreateView4SqlEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objLog4CreateView4SqlEN.Memo) && GetStrLen(objLog4CreateView4SqlEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objLog4CreateView4SqlEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLog4CreateView4SqlEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsLog4CreateView4SqlEN objLog4CreateView4SqlEN;
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
objLog4CreateView4SqlEN = JsonConvert.DeserializeObject<clsLog4CreateView4SqlEN>(strJson);
return objLog4CreateView4SqlEN;
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
public static clsLog4CreateView4SqlEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsLog4CreateView4SqlEN objLog4CreateView4SqlEN;
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
objLog4CreateView4SqlEN = JsonConvert.DeserializeObject<clsLog4CreateView4SqlEN>(strJson);
return objLog4CreateView4SqlEN;
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
public static clsLog4CreateView4SqlEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsLog4CreateView4SqlEN._CurrTabName);
List<clsLog4CreateView4SqlEN> arrLog4CreateView4SqlObjLstCache = GetObjLstCache();
IEnumerable <clsLog4CreateView4SqlEN> arrLog4CreateView4SqlObjLst_Sel =
from objLog4CreateView4SqlEN in arrLog4CreateView4SqlObjLstCache
where objLog4CreateView4SqlEN.mId == lngmId 
select objLog4CreateView4SqlEN;
if (arrLog4CreateView4SqlObjLst_Sel.Count() == 0)
{
   clsLog4CreateView4SqlEN obj = clsLog4CreateView4SqlWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrLog4CreateView4SqlObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsLog4CreateView4SqlEN> GetObjLst(string strWhereCond)
{
 List<clsLog4CreateView4SqlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4CreateView4SqlEN>>(strJson);
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
public static List<clsLog4CreateView4SqlEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsLog4CreateView4SqlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4CreateView4SqlEN>>(strJson);
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
public static IEnumerable<clsLog4CreateView4SqlEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsLog4CreateView4SqlEN._CurrTabName);
List<clsLog4CreateView4SqlEN> arrLog4CreateView4SqlObjLstCache = GetObjLstCache();
IEnumerable <clsLog4CreateView4SqlEN> arrLog4CreateView4SqlObjLst_Sel =
from objLog4CreateView4SqlEN in arrLog4CreateView4SqlObjLstCache
where arrMId.Contains(objLog4CreateView4SqlEN.mId)
select objLog4CreateView4SqlEN;
return arrLog4CreateView4SqlObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsLog4CreateView4SqlEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsLog4CreateView4SqlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4CreateView4SqlEN>>(strJson);
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
public static List<clsLog4CreateView4SqlEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsLog4CreateView4SqlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4CreateView4SqlEN>>(strJson);
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
public static List<clsLog4CreateView4SqlEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsLog4CreateView4SqlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4CreateView4SqlEN>>(strJson);
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
public static List<clsLog4CreateView4SqlEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsLog4CreateView4SqlEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4CreateView4SqlEN>>(strJson);
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
 clsLog4CreateView4SqlEN objLog4CreateView4SqlEN = clsLog4CreateView4SqlWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsLog4CreateView4SqlWApi.ReFreshCache();
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
public static int DelLog4CreateView4Sqls(List<string> arrmId)
{
string strAction = "DelLog4CreateView4Sqls";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsLog4CreateView4SqlWApi.ReFreshCache();
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
public static int DelLog4CreateView4SqlsByCond(string strWhereCond)
{
string strAction = "DelLog4CreateView4SqlsByCond";
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
public static bool AddNewRecord(clsLog4CreateView4SqlEN objLog4CreateView4SqlEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLog4CreateView4SqlEN>(objLog4CreateView4SqlEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4CreateView4SqlWApi.ReFreshCache();
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
 /// <param name = "objLog4CreateView4SqlEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsLog4CreateView4SqlEN objLog4CreateView4SqlEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLog4CreateView4SqlEN>(objLog4CreateView4SqlEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4CreateView4SqlWApi.ReFreshCache();
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
public static bool UpdateRecord(clsLog4CreateView4SqlEN objLog4CreateView4SqlEN)
{
if (string.IsNullOrEmpty(objLog4CreateView4SqlEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objLog4CreateView4SqlEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLog4CreateView4SqlEN>(objLog4CreateView4SqlEN);
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
 /// <param name = "objLog4CreateView4SqlEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsLog4CreateView4SqlEN objLog4CreateView4SqlEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objLog4CreateView4SqlEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objLog4CreateView4SqlEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objLog4CreateView4SqlEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLog4CreateView4SqlEN>(objLog4CreateView4SqlEN);
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
 /// <param name = "objLog4CreateView4SqlENS">源对象</param>
 /// <param name = "objLog4CreateView4SqlENT">目标对象</param>
 public static void CopyTo(clsLog4CreateView4SqlEN objLog4CreateView4SqlENS, clsLog4CreateView4SqlEN objLog4CreateView4SqlENT)
{
try
{
objLog4CreateView4SqlENT.mId = objLog4CreateView4SqlENS.mId; //mId
objLog4CreateView4SqlENT.SqlViewId = objLog4CreateView4SqlENS.SqlViewId; //Sql视图Id
objLog4CreateView4SqlENT.PrjDataBaseId = objLog4CreateView4SqlENS.PrjDataBaseId; //项目数据库Id
objLog4CreateView4SqlENT.CreateViewDate = objLog4CreateView4SqlENS.CreateViewDate; //建立视图日期
objLog4CreateView4SqlENT.PrjId = objLog4CreateView4SqlENS.PrjId; //工程Id
objLog4CreateView4SqlENT.UserId = objLog4CreateView4SqlENS.UserId; //用户Id
objLog4CreateView4SqlENT.Memo = objLog4CreateView4SqlENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsLog4CreateView4SqlEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsLog4CreateView4SqlEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsLog4CreateView4SqlEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsLog4CreateView4SqlEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsLog4CreateView4SqlEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsLog4CreateView4SqlEN._AttributeName)
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
string strKey = string.Format("{0}", clsLog4CreateView4SqlEN._CurrTabName);
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
if (clsLog4CreateView4SqlWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsLog4CreateView4SqlEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLog4CreateView4SqlWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLog4CreateView4SqlEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsLog4CreateView4SqlEN._CurrTabName;
List<clsLog4CreateView4SqlEN> arrLog4CreateView4SqlObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrLog4CreateView4SqlObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsLog4CreateView4SqlEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conLog4CreateView4Sql.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conLog4CreateView4Sql.SqlViewId, Type.GetType("System.String"));
objDT.Columns.Add(conLog4CreateView4Sql.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(conLog4CreateView4Sql.CreateViewDate, Type.GetType("System.String"));
objDT.Columns.Add(conLog4CreateView4Sql.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conLog4CreateView4Sql.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conLog4CreateView4Sql.Memo, Type.GetType("System.String"));
foreach (clsLog4CreateView4SqlEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conLog4CreateView4Sql.mId] = objInFor[conLog4CreateView4Sql.mId];
objDR[conLog4CreateView4Sql.SqlViewId] = objInFor[conLog4CreateView4Sql.SqlViewId];
objDR[conLog4CreateView4Sql.PrjDataBaseId] = objInFor[conLog4CreateView4Sql.PrjDataBaseId];
objDR[conLog4CreateView4Sql.CreateViewDate] = objInFor[conLog4CreateView4Sql.CreateViewDate];
objDR[conLog4CreateView4Sql.PrjId] = objInFor[conLog4CreateView4Sql.PrjId];
objDR[conLog4CreateView4Sql.UserId] = objInFor[conLog4CreateView4Sql.UserId];
objDR[conLog4CreateView4Sql.Memo] = objInFor[conLog4CreateView4Sql.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 建立视图日志(Log4CreateView4Sql)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4Log4CreateView4Sql : clsCommFun4BL
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
clsLog4CreateView4SqlWApi.ReFreshThisCache();
}
}

}