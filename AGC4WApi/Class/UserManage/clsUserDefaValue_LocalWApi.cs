
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserDefaValue_LocalWApi
 表名:UserDefaValue_Local(00050089)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
public static class  clsUserDefaValue_LocalWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetmId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, long lngmId, string strComparisonOp="")
	{
objUserDefaValue_LocalEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.mId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.mId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.mId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaValNameId">DefaValNameId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetDefaValNameId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strDefaValNameId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaValNameId, conUserDefaValue_Local.DefaValNameId);
clsCheckSql.CheckFieldLen(strDefaValNameId, 8, conUserDefaValue_Local.DefaValNameId);
objUserDefaValue_LocalEN.DefaValNameId = strDefaValNameId; //DefaValNameId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.DefaValNameId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.DefaValNameId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.DefaValNameId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetUserId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conUserDefaValue_Local.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conUserDefaValue_Local.UserId);
objUserDefaValue_LocalEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.UserId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.UserId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.UserId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserDefaValue">UserDefaValue</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetUserDefaValue(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strUserDefaValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserDefaValue, conUserDefaValue_Local.UserDefaValue);
clsCheckSql.CheckFieldLen(strUserDefaValue, 100, conUserDefaValue_Local.UserDefaValue);
objUserDefaValue_LocalEN.UserDefaValue = strUserDefaValue; //UserDefaValue
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.UserDefaValue) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.UserDefaValue, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.UserDefaValue] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetPrjId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conUserDefaValue_Local.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conUserDefaValue_Local.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conUserDefaValue_Local.PrjId);
objUserDefaValue_LocalEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.PrjId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.PrjId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.PrjId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetUpdDate(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserDefaValue_Local.UpdDate);
objUserDefaValue_LocalEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.UpdDate) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.UpdDate, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.UpdDate] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetUpdUserId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conUserDefaValue_Local.UpdUserId);
objUserDefaValue_LocalEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.UpdUserId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.UpdUserId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.UpdUserId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetMemo(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserDefaValue_Local.Memo);
objUserDefaValue_LocalEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.Memo) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.Memo, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.Memo] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserDefaValue_LocalEN objUserDefaValue_LocalCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.mId) == true)
{
string strComparisonOpmId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserDefaValue_Local.mId, objUserDefaValue_LocalCond.mId, strComparisonOpmId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.DefaValNameId) == true)
{
string strComparisonOpDefaValNameId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.DefaValNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.DefaValNameId, objUserDefaValue_LocalCond.DefaValNameId, strComparisonOpDefaValNameId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.UserId) == true)
{
string strComparisonOpUserId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.UserId, objUserDefaValue_LocalCond.UserId, strComparisonOpUserId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.UserDefaValue) == true)
{
string strComparisonOpUserDefaValue = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.UserDefaValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.UserDefaValue, objUserDefaValue_LocalCond.UserDefaValue, strComparisonOpUserDefaValue);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.PrjId) == true)
{
string strComparisonOpPrjId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.PrjId, objUserDefaValue_LocalCond.PrjId, strComparisonOpPrjId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.UpdDate, objUserDefaValue_LocalCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.UpdUserId, objUserDefaValue_LocalCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.Memo) == true)
{
string strComparisonOpMemo = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.Memo, objUserDefaValue_LocalCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
 if (objUserDefaValue_LocalEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objUserDefaValue_LocalEN.sfUpdFldSetStr = objUserDefaValue_LocalEN.getsfUpdFldSetStr();
clsUserDefaValue_LocalWApi.CheckPropertyNew(objUserDefaValue_LocalEN); 
bool bolResult = clsUserDefaValue_LocalWApi.UpdateRecord(objUserDefaValue_LocalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--UserDefaValue_Local(用户缺省值), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_UserId_DefaValNameId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserDefaValue_LocalEN == null) return "";
if (objUserDefaValue_LocalEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserDefaValue_LocalEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserDefaValue_LocalEN.UserId);
 sbCondition.AppendFormat(" and DefaValNameId = '{0}'", objUserDefaValue_LocalEN.DefaValNameId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserDefaValue_LocalEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserDefaValue_LocalEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserDefaValue_LocalEN.UserId);
 sbCondition.AppendFormat(" and DefaValNameId = '{0}'", objUserDefaValue_LocalEN.DefaValNameId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
try
{
clsUserDefaValue_LocalWApi.CheckPropertyNew(objUserDefaValue_LocalEN); 
bool bolResult = clsUserDefaValue_LocalWApi.AddNewRecord(objUserDefaValue_LocalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objUserDefaValue_LocalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strWhereCond)
{
try
{
clsUserDefaValue_LocalWApi.CheckPropertyNew(objUserDefaValue_LocalEN); 
bool bolResult = clsUserDefaValue_LocalWApi.UpdateWithCondition(objUserDefaValue_LocalEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 用户缺省值(UserDefaValue_Local)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsUserDefaValue_LocalWApi
{
private static readonly string mstrApiControllerName = "UserDefaValue_LocalApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsUserDefaValue_LocalWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
if (!Object.Equals(null, objUserDefaValue_LocalEN.DefaValNameId) && GetStrLen(objUserDefaValue_LocalEN.DefaValNameId) > 8)
{
 throw new Exception("字段[DefaValNameId]的长度不能超过8!");
}
if (!Object.Equals(null, objUserDefaValue_LocalEN.UserId) && GetStrLen(objUserDefaValue_LocalEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objUserDefaValue_LocalEN.UserDefaValue) && GetStrLen(objUserDefaValue_LocalEN.UserDefaValue) > 100)
{
 throw new Exception("字段[UserDefaValue]的长度不能超过100!");
}
if (!Object.Equals(null, objUserDefaValue_LocalEN.PrjId) && GetStrLen(objUserDefaValue_LocalEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objUserDefaValue_LocalEN.UpdDate) && GetStrLen(objUserDefaValue_LocalEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objUserDefaValue_LocalEN.UpdUserId) && GetStrLen(objUserDefaValue_LocalEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objUserDefaValue_LocalEN.Memo) && GetStrLen(objUserDefaValue_LocalEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objUserDefaValue_LocalEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserDefaValue_LocalEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsUserDefaValue_LocalEN objUserDefaValue_LocalEN;
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
objUserDefaValue_LocalEN = JsonConvert.DeserializeObject<clsUserDefaValue_LocalEN>(strJson);
return objUserDefaValue_LocalEN;
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
public static clsUserDefaValue_LocalEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsUserDefaValue_LocalEN objUserDefaValue_LocalEN;
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
objUserDefaValue_LocalEN = JsonConvert.DeserializeObject<clsUserDefaValue_LocalEN>(strJson);
return objUserDefaValue_LocalEN;
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
public static List<clsUserDefaValue_LocalEN> GetObjLst(string strWhereCond)
{
 List<clsUserDefaValue_LocalEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserDefaValue_LocalEN>>(strJson);
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
public static List<clsUserDefaValue_LocalEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsUserDefaValue_LocalEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserDefaValue_LocalEN>>(strJson);
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
public static List<clsUserDefaValue_LocalEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsUserDefaValue_LocalEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserDefaValue_LocalEN>>(strJson);
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
public static List<clsUserDefaValue_LocalEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsUserDefaValue_LocalEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserDefaValue_LocalEN>>(strJson);
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
public static List<clsUserDefaValue_LocalEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsUserDefaValue_LocalEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserDefaValue_LocalEN>>(strJson);
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
public static List<clsUserDefaValue_LocalEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsUserDefaValue_LocalEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserDefaValue_LocalEN>>(strJson);
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
 clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = clsUserDefaValue_LocalWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelUserDefaValue_Locals(List<string> arrmId)
{
string strAction = "DelUserDefaValue_Locals";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelUserDefaValue_LocalsByCond(string strWhereCond)
{
string strAction = "DelUserDefaValue_LocalsByCond";
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
public static bool AddNewRecord(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserDefaValue_LocalEN>(objUserDefaValue_LocalEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserDefaValue_LocalEN>(objUserDefaValue_LocalEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static bool UpdateRecord(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
if (string.IsNullOrEmpty(objUserDefaValue_LocalEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserDefaValue_LocalEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserDefaValue_LocalEN>(objUserDefaValue_LocalEN);
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
 /// <param name = "objUserDefaValue_LocalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objUserDefaValue_LocalEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserDefaValue_LocalEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserDefaValue_LocalEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserDefaValue_LocalEN>(objUserDefaValue_LocalEN);
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
 /// <param name = "objUserDefaValue_LocalENS">源对象</param>
 /// <param name = "objUserDefaValue_LocalENT">目标对象</param>
 public static void CopyTo(clsUserDefaValue_LocalEN objUserDefaValue_LocalENS, clsUserDefaValue_LocalEN objUserDefaValue_LocalENT)
{
try
{
objUserDefaValue_LocalENT.mId = objUserDefaValue_LocalENS.mId; //mId
objUserDefaValue_LocalENT.DefaValNameId = objUserDefaValue_LocalENS.DefaValNameId; //DefaValNameId
objUserDefaValue_LocalENT.UserId = objUserDefaValue_LocalENS.UserId; //用户Id
objUserDefaValue_LocalENT.UserDefaValue = objUserDefaValue_LocalENS.UserDefaValue; //UserDefaValue
objUserDefaValue_LocalENT.PrjId = objUserDefaValue_LocalENS.PrjId; //工程Id
objUserDefaValue_LocalENT.UpdDate = objUserDefaValue_LocalENS.UpdDate; //修改日期
objUserDefaValue_LocalENT.UpdUserId = objUserDefaValue_LocalENS.UpdUserId; //修改用户Id
objUserDefaValue_LocalENT.Memo = objUserDefaValue_LocalENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsUserDefaValue_LocalEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsUserDefaValue_LocalEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsUserDefaValue_LocalEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsUserDefaValue_LocalEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsUserDefaValue_LocalEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsUserDefaValue_LocalEN._AttributeName)
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
string strKey = string.Format("{0}", clsUserDefaValue_LocalEN._CurrTabName);
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
if (clsUserDefaValue_LocalWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUserDefaValue_LocalEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserDefaValue_LocalWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsUserDefaValue_LocalEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conUserDefaValue_Local.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conUserDefaValue_Local.DefaValNameId, Type.GetType("System.String"));
objDT.Columns.Add(conUserDefaValue_Local.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conUserDefaValue_Local.UserDefaValue, Type.GetType("System.String"));
objDT.Columns.Add(conUserDefaValue_Local.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conUserDefaValue_Local.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conUserDefaValue_Local.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conUserDefaValue_Local.Memo, Type.GetType("System.String"));
foreach (clsUserDefaValue_LocalEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conUserDefaValue_Local.mId] = objInFor[conUserDefaValue_Local.mId];
objDR[conUserDefaValue_Local.DefaValNameId] = objInFor[conUserDefaValue_Local.DefaValNameId];
objDR[conUserDefaValue_Local.UserId] = objInFor[conUserDefaValue_Local.UserId];
objDR[conUserDefaValue_Local.UserDefaValue] = objInFor[conUserDefaValue_Local.UserDefaValue];
objDR[conUserDefaValue_Local.PrjId] = objInFor[conUserDefaValue_Local.PrjId];
objDR[conUserDefaValue_Local.UpdDate] = objInFor[conUserDefaValue_Local.UpdDate];
objDR[conUserDefaValue_Local.UpdUserId] = objInFor[conUserDefaValue_Local.UpdUserId];
objDR[conUserDefaValue_Local.Memo] = objInFor[conUserDefaValue_Local.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户缺省值(UserDefaValue_Local)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4UserDefaValue_Local : clsCommFun4BL
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
clsUserDefaValue_LocalWApi.ReFreshThisCache();
}
}

}