
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionTemplateWApi
 表名:FunctionTemplate(00050312)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsFunctionTemplateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateId">函数模板Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateEN SetFunctionTemplateId(this clsFunctionTemplateEN objFunctionTemplateEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, conFunctionTemplate.FunctionTemplateId);
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, conFunctionTemplate.FunctionTemplateId);
objFunctionTemplateEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateEN.dicFldComparisonOp.ContainsKey(conFunctionTemplate.FunctionTemplateId) == false)
{
objFunctionTemplateEN.dicFldComparisonOp.Add(conFunctionTemplate.FunctionTemplateId, strComparisonOp);
}
else
{
objFunctionTemplateEN.dicFldComparisonOp[conFunctionTemplate.FunctionTemplateId] = strComparisonOp;
}
}
return objFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateName">函数模板名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateEN SetFunctionTemplateName(this clsFunctionTemplateEN objFunctionTemplateEN, string strFunctionTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateName, conFunctionTemplate.FunctionTemplateName);
clsCheckSql.CheckFieldLen(strFunctionTemplateName, 50, conFunctionTemplate.FunctionTemplateName);
objFunctionTemplateEN.FunctionTemplateName = strFunctionTemplateName; //函数模板名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateEN.dicFldComparisonOp.ContainsKey(conFunctionTemplate.FunctionTemplateName) == false)
{
objFunctionTemplateEN.dicFldComparisonOp.Add(conFunctionTemplate.FunctionTemplateName, strComparisonOp);
}
else
{
objFunctionTemplateEN.dicFldComparisonOp[conFunctionTemplate.FunctionTemplateName] = strComparisonOp;
}
}
return objFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateENName">函数模板英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateEN SetFunctionTemplateENName(this clsFunctionTemplateEN objFunctionTemplateEN, string strFunctionTemplateENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateENName, conFunctionTemplate.FunctionTemplateENName);
clsCheckSql.CheckFieldLen(strFunctionTemplateENName, 50, conFunctionTemplate.FunctionTemplateENName);
objFunctionTemplateEN.FunctionTemplateENName = strFunctionTemplateENName; //函数模板英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateEN.dicFldComparisonOp.ContainsKey(conFunctionTemplate.FunctionTemplateENName) == false)
{
objFunctionTemplateEN.dicFldComparisonOp.Add(conFunctionTemplate.FunctionTemplateENName, strComparisonOp);
}
else
{
objFunctionTemplateEN.dicFldComparisonOp[conFunctionTemplate.FunctionTemplateENName] = strComparisonOp;
}
}
return objFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateEN SetProgLangTypeId(this clsFunctionTemplateEN objFunctionTemplateEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, conFunctionTemplate.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conFunctionTemplate.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conFunctionTemplate.ProgLangTypeId);
objFunctionTemplateEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateEN.dicFldComparisonOp.ContainsKey(conFunctionTemplate.ProgLangTypeId) == false)
{
objFunctionTemplateEN.dicFldComparisonOp.Add(conFunctionTemplate.ProgLangTypeId, strComparisonOp);
}
else
{
objFunctionTemplateEN.dicFldComparisonOp[conFunctionTemplate.ProgLangTypeId] = strComparisonOp;
}
}
return objFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateEN SetCreateUserId(this clsFunctionTemplateEN objFunctionTemplateEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, conFunctionTemplate.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, conFunctionTemplate.CreateUserId);
objFunctionTemplateEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateEN.dicFldComparisonOp.ContainsKey(conFunctionTemplate.CreateUserId) == false)
{
objFunctionTemplateEN.dicFldComparisonOp.Add(conFunctionTemplate.CreateUserId, strComparisonOp);
}
else
{
objFunctionTemplateEN.dicFldComparisonOp[conFunctionTemplate.CreateUserId] = strComparisonOp;
}
}
return objFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateEN SetUpdDate(this clsFunctionTemplateEN objFunctionTemplateEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunctionTemplate.UpdDate);
objFunctionTemplateEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateEN.dicFldComparisonOp.ContainsKey(conFunctionTemplate.UpdDate) == false)
{
objFunctionTemplateEN.dicFldComparisonOp.Add(conFunctionTemplate.UpdDate, strComparisonOp);
}
else
{
objFunctionTemplateEN.dicFldComparisonOp[conFunctionTemplate.UpdDate] = strComparisonOp;
}
}
return objFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateEN SetUpdUser(this clsFunctionTemplateEN objFunctionTemplateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunctionTemplate.UpdUser);
objFunctionTemplateEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateEN.dicFldComparisonOp.ContainsKey(conFunctionTemplate.UpdUser) == false)
{
objFunctionTemplateEN.dicFldComparisonOp.Add(conFunctionTemplate.UpdUser, strComparisonOp);
}
else
{
objFunctionTemplateEN.dicFldComparisonOp[conFunctionTemplate.UpdUser] = strComparisonOp;
}
}
return objFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateEN SetMemo(this clsFunctionTemplateEN objFunctionTemplateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionTemplate.Memo);
objFunctionTemplateEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateEN.dicFldComparisonOp.ContainsKey(conFunctionTemplate.Memo) == false)
{
objFunctionTemplateEN.dicFldComparisonOp.Add(conFunctionTemplate.Memo, strComparisonOp);
}
else
{
objFunctionTemplateEN.dicFldComparisonOp[conFunctionTemplate.Memo] = strComparisonOp;
}
}
return objFunctionTemplateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionTemplateEN objFunctionTemplateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionTemplateCond.IsUpdated(conFunctionTemplate.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objFunctionTemplateCond.dicFldComparisonOp[conFunctionTemplate.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplate.FunctionTemplateId, objFunctionTemplateCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objFunctionTemplateCond.IsUpdated(conFunctionTemplate.FunctionTemplateName) == true)
{
string strComparisonOpFunctionTemplateName = objFunctionTemplateCond.dicFldComparisonOp[conFunctionTemplate.FunctionTemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplate.FunctionTemplateName, objFunctionTemplateCond.FunctionTemplateName, strComparisonOpFunctionTemplateName);
}
if (objFunctionTemplateCond.IsUpdated(conFunctionTemplate.FunctionTemplateENName) == true)
{
string strComparisonOpFunctionTemplateENName = objFunctionTemplateCond.dicFldComparisonOp[conFunctionTemplate.FunctionTemplateENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplate.FunctionTemplateENName, objFunctionTemplateCond.FunctionTemplateENName, strComparisonOpFunctionTemplateENName);
}
if (objFunctionTemplateCond.IsUpdated(conFunctionTemplate.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objFunctionTemplateCond.dicFldComparisonOp[conFunctionTemplate.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplate.ProgLangTypeId, objFunctionTemplateCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objFunctionTemplateCond.IsUpdated(conFunctionTemplate.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objFunctionTemplateCond.dicFldComparisonOp[conFunctionTemplate.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplate.CreateUserId, objFunctionTemplateCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objFunctionTemplateCond.IsUpdated(conFunctionTemplate.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunctionTemplateCond.dicFldComparisonOp[conFunctionTemplate.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplate.UpdDate, objFunctionTemplateCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunctionTemplateCond.IsUpdated(conFunctionTemplate.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunctionTemplateCond.dicFldComparisonOp[conFunctionTemplate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplate.UpdUser, objFunctionTemplateCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunctionTemplateCond.IsUpdated(conFunctionTemplate.Memo) == true)
{
string strComparisonOpMemo = objFunctionTemplateCond.dicFldComparisonOp[conFunctionTemplate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplate.Memo, objFunctionTemplateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionTemplateEN objFunctionTemplateEN)
{
 if (string.IsNullOrEmpty(objFunctionTemplateEN.FunctionTemplateId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFunctionTemplateEN.sfUpdFldSetStr = objFunctionTemplateEN.getsfUpdFldSetStr();
clsFunctionTemplateWApi.CheckPropertyNew(objFunctionTemplateEN); 
bool bolResult = clsFunctionTemplateWApi.UpdateRecord(objFunctionTemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateWApi.ReFreshCache();
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
 /// 获取唯一性条件串--FunctionTemplate(函数模板), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FunctionTemplateName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFunctionTemplateEN objFunctionTemplateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunctionTemplateEN == null) return "";
if (objFunctionTemplateEN.FunctionTemplateId == null || objFunctionTemplateEN.FunctionTemplateId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionTemplateName = '{0}'", objFunctionTemplateEN.FunctionTemplateName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FunctionTemplateId !=  '{0}'", objFunctionTemplateEN.FunctionTemplateId);
 sbCondition.AppendFormat(" and FunctionTemplateName = '{0}'", objFunctionTemplateEN.FunctionTemplateName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionTemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionTemplateEN objFunctionTemplateEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionTemplateEN.FunctionTemplateId) == true || clsFunctionTemplateWApi.IsExist(objFunctionTemplateEN.FunctionTemplateId) == true)
 {
     objFunctionTemplateEN.FunctionTemplateId = clsFunctionTemplateWApi.GetMaxStrId();
 }
clsFunctionTemplateWApi.CheckPropertyNew(objFunctionTemplateEN); 
bool bolResult = clsFunctionTemplateWApi.AddNewRecord(objFunctionTemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateWApi.ReFreshCache();
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
 /// <param name = "objFunctionTemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunctionTemplateEN objFunctionTemplateEN)
{
try
{
clsFunctionTemplateWApi.CheckPropertyNew(objFunctionTemplateEN); 
string strFunctionTemplateId = clsFunctionTemplateWApi.AddNewRecordWithMaxId(objFunctionTemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateWApi.ReFreshCache();
return strFunctionTemplateId;
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
 /// <param name = "objFunctionTemplateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionTemplateEN objFunctionTemplateEN, string strWhereCond)
{
try
{
clsFunctionTemplateWApi.CheckPropertyNew(objFunctionTemplateEN); 
bool bolResult = clsFunctionTemplateWApi.UpdateWithCondition(objFunctionTemplateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumFunctionTemplateWA
{
 /// <summary>
 /// 全部函数集
 /// </summary>
public const string AllFunctionSet_0001 = "0001";
 /// <summary>
 /// 简要函数集
 /// </summary>
public const string BriefFunctionSet_0002 = "0002";
 /// <summary>
 /// 自定义函数集
 /// </summary>
public const string CustomFunctionSet_0003 = "0003";
 /// <summary>
 /// 区域函数集
 /// </summary>
public const string RegionFunctionSet_0004 = "0004";
 /// <summary>
 /// 区域函数详细集
 /// </summary>
public const string RegionFunctionDetailSet_0005 = "0005";
 /// <summary>
 /// 精要函数集
 /// </summary>
public const string EssentialFunctionSet_0006 = "0006";
 /// <summary>
 /// WebApi函数集
 /// </summary>
public const string WebApiFunctionSet_0007 = "0007";
}
 /// <summary>
 /// 函数模板(FunctionTemplate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFunctionTemplateWApi
{
private static readonly string mstrApiControllerName = "FunctionTemplateApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFunctionTemplateWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FunctionTemplateId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数模板]...","0");
List<clsFunctionTemplateEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FunctionTemplateId";
objDDL.DataTextField="FunctionTemplateName";
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

public static void BindCbo_FunctionTemplateId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFunctionTemplate.FunctionTemplateId); 
List<clsFunctionTemplateEN> arrObjLst = clsFunctionTemplateWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFunctionTemplateEN objFunctionTemplateEN = new clsFunctionTemplateEN()
{
FunctionTemplateId = "0",
FunctionTemplateName = "选[函数模板]..."
};
arrObjLst.Insert(0, objFunctionTemplateEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFunctionTemplate.FunctionTemplateId;
objComboBox.DisplayMember = conFunctionTemplate.FunctionTemplateName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFunctionTemplateEN objFunctionTemplateEN)
{
if (!Object.Equals(null, objFunctionTemplateEN.FunctionTemplateId) && GetStrLen(objFunctionTemplateEN.FunctionTemplateId) > 4)
{
 throw new Exception("字段[函数模板Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFunctionTemplateEN.FunctionTemplateName) && GetStrLen(objFunctionTemplateEN.FunctionTemplateName) > 50)
{
 throw new Exception("字段[函数模板名]的长度不能超过50!");
}
if (!Object.Equals(null, objFunctionTemplateEN.FunctionTemplateENName) && GetStrLen(objFunctionTemplateEN.FunctionTemplateENName) > 50)
{
 throw new Exception("字段[函数模板英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objFunctionTemplateEN.ProgLangTypeId) && GetStrLen(objFunctionTemplateEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunctionTemplateEN.CreateUserId) && GetStrLen(objFunctionTemplateEN.CreateUserId) > 18)
{
 throw new Exception("字段[建立用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objFunctionTemplateEN.UpdDate) && GetStrLen(objFunctionTemplateEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFunctionTemplateEN.UpdUser) && GetStrLen(objFunctionTemplateEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFunctionTemplateEN.Memo) && GetStrLen(objFunctionTemplateEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFunctionTemplateEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionTemplateEN GetObjByFunctionTemplateId(string strFunctionTemplateId)
{
if (strFunctionTemplateId == "") return null;
string strAction = "GetObjByFunctionTemplateId";
clsFunctionTemplateEN objFunctionTemplateEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionTemplateId"] = strFunctionTemplateId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objFunctionTemplateEN = JsonConvert.DeserializeObject<clsFunctionTemplateEN>(strJson);
return objFunctionTemplateEN;
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
public static string GetFirstID(string strWhereCond)
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsFunctionTemplateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFunctionTemplateEN objFunctionTemplateEN;
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
objFunctionTemplateEN = JsonConvert.DeserializeObject<clsFunctionTemplateEN>(strJson);
return objFunctionTemplateEN;
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
 /// <param name = "strFunctionTemplateId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionTemplateEN GetObjByFunctionTemplateIdCache(string strFunctionTemplateId)
{
if (string.IsNullOrEmpty(strFunctionTemplateId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionTemplateEN._CurrTabName);
List<clsFunctionTemplateEN> arrFunctionTemplateObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTemplateEN> arrFunctionTemplateObjLst_Sel =
from objFunctionTemplateEN in arrFunctionTemplateObjLstCache
where objFunctionTemplateEN.FunctionTemplateId == strFunctionTemplateId 
select objFunctionTemplateEN;
if (arrFunctionTemplateObjLst_Sel.Count() == 0)
{
   clsFunctionTemplateEN obj = clsFunctionTemplateWApi.GetObjByFunctionTemplateId(strFunctionTemplateId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFunctionTemplateObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFunctionTemplateId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFunctionTemplateNameByFunctionTemplateIdCache(string strFunctionTemplateId)
{
if (string.IsNullOrEmpty(strFunctionTemplateId) == true) return "";
//初始化列表缓存
List<clsFunctionTemplateEN> arrFunctionTemplateObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTemplateEN> arrFunctionTemplateObjLst_Sel1 =
from objFunctionTemplateEN in arrFunctionTemplateObjLstCache
where objFunctionTemplateEN.FunctionTemplateId == strFunctionTemplateId 
select objFunctionTemplateEN;
List <clsFunctionTemplateEN> arrFunctionTemplateObjLst_Sel = new List<clsFunctionTemplateEN>();
foreach (clsFunctionTemplateEN obj in arrFunctionTemplateObjLst_Sel1)
{
arrFunctionTemplateObjLst_Sel.Add(obj);
}
if (arrFunctionTemplateObjLst_Sel.Count > 0)
{
return arrFunctionTemplateObjLst_Sel[0].FunctionTemplateName;
}
string strErrMsgForGetObjById = string.Format("在FunctionTemplate对象缓存列表中,找不到记录[FunctionTemplateId = {0}](函数:{1})", strFunctionTemplateId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunctionTemplateBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFunctionTemplateId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFunctionTemplateIdCache(string strFunctionTemplateId)
{
if (string.IsNullOrEmpty(strFunctionTemplateId) == true) return "";
//初始化列表缓存
List<clsFunctionTemplateEN> arrFunctionTemplateObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTemplateEN> arrFunctionTemplateObjLst_Sel1 =
from objFunctionTemplateEN in arrFunctionTemplateObjLstCache
where objFunctionTemplateEN.FunctionTemplateId == strFunctionTemplateId 
select objFunctionTemplateEN;
List <clsFunctionTemplateEN> arrFunctionTemplateObjLst_Sel = new List<clsFunctionTemplateEN>();
foreach (clsFunctionTemplateEN obj in arrFunctionTemplateObjLst_Sel1)
{
arrFunctionTemplateObjLst_Sel.Add(obj);
}
if (arrFunctionTemplateObjLst_Sel.Count > 0)
{
return arrFunctionTemplateObjLst_Sel[0].FunctionTemplateName;
}
string strErrMsgForGetObjById = string.Format("在FunctionTemplate对象缓存列表中,找不到记录的相关名称[FunctionTemplateId = {0}](函数:{1})", strFunctionTemplateId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunctionTemplateBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTemplateEN> GetObjLst(string strWhereCond)
{
 List<clsFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTemplateEN>>(strJson);
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
 /// <param name = "arrFunctionTemplateId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTemplateEN> GetObjLstByFunctionTemplateIdLst(List<string> arrFunctionTemplateId)
{
 List<clsFunctionTemplateEN> arrObjLst; 
string strAction = "GetObjLstByFunctionTemplateIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionTemplateId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTemplateEN>>(strJson);
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
 /// <param name = "arrFunctionTemplateId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsFunctionTemplateEN> GetObjLstByFunctionTemplateIdLstCache(List<string> arrFunctionTemplateId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionTemplateEN._CurrTabName);
List<clsFunctionTemplateEN> arrFunctionTemplateObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTemplateEN> arrFunctionTemplateObjLst_Sel =
from objFunctionTemplateEN in arrFunctionTemplateObjLstCache
where arrFunctionTemplateId.Contains(objFunctionTemplateEN.FunctionTemplateId)
select objFunctionTemplateEN;
return arrFunctionTemplateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTemplateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTemplateEN>>(strJson);
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
public static List<clsFunctionTemplateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTemplateEN>>(strJson);
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
public static List<clsFunctionTemplateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTemplateEN>>(strJson);
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
public static List<clsFunctionTemplateEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTemplateEN>>(strJson);
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
public static int DelRecord(string strFunctionTemplateId)
{
string strAction = "DelRecord";
try
{
 clsFunctionTemplateEN objFunctionTemplateEN = clsFunctionTemplateWApi.GetObjByFunctionTemplateId(strFunctionTemplateId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFunctionTemplateId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFunctionTemplateWApi.ReFreshCache();
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
public static int DelFunctionTemplates(List<string> arrFunctionTemplateId)
{
string strAction = "DelFunctionTemplates";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionTemplateId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFunctionTemplateWApi.ReFreshCache();
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
public static int DelFunctionTemplatesByCond(string strWhereCond)
{
string strAction = "DelFunctionTemplatesByCond";
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
public static bool AddNewRecord(clsFunctionTemplateEN objFunctionTemplateEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionTemplateEN>(objFunctionTemplateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateWApi.ReFreshCache();
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsFunctionTemplateEN objFunctionTemplateEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionTemplateEN>(objFunctionTemplateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateWApi.ReFreshCache();
var strFunctionTemplateId = (string)jobjReturn0["returnStr"];
return strFunctionTemplateId;
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
public static bool UpdateRecord(clsFunctionTemplateEN objFunctionTemplateEN)
{
if (string.IsNullOrEmpty(objFunctionTemplateEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionTemplateEN.FunctionTemplateId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionTemplateEN>(objFunctionTemplateEN);
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
 /// <param name = "objFunctionTemplateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFunctionTemplateEN objFunctionTemplateEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFunctionTemplateEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionTemplateEN.FunctionTemplateId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionTemplateEN.FunctionTemplateId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionTemplateEN>(objFunctionTemplateEN);
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
public static bool IsExist(string strFunctionTemplateId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionTemplateId"] = strFunctionTemplateId
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFunctionTemplateENS">源对象</param>
 /// <param name = "objFunctionTemplateENT">目标对象</param>
 public static void CopyTo(clsFunctionTemplateEN objFunctionTemplateENS, clsFunctionTemplateEN objFunctionTemplateENT)
{
try
{
objFunctionTemplateENT.FunctionTemplateId = objFunctionTemplateENS.FunctionTemplateId; //函数模板Id
objFunctionTemplateENT.FunctionTemplateName = objFunctionTemplateENS.FunctionTemplateName; //函数模板名
objFunctionTemplateENT.FunctionTemplateENName = objFunctionTemplateENS.FunctionTemplateENName; //函数模板英文名
objFunctionTemplateENT.ProgLangTypeId = objFunctionTemplateENS.ProgLangTypeId; //编程语言类型Id
objFunctionTemplateENT.CreateUserId = objFunctionTemplateENS.CreateUserId; //建立用户Id
objFunctionTemplateENT.UpdDate = objFunctionTemplateENS.UpdDate; //修改日期
objFunctionTemplateENT.UpdUser = objFunctionTemplateENS.UpdUser; //修改者
objFunctionTemplateENT.Memo = objFunctionTemplateENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFunctionTemplateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFunctionTemplateEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFunctionTemplateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFunctionTemplateEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFunctionTemplateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFunctionTemplateEN._AttributeName)
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
string strKey = string.Format("{0}", clsFunctionTemplateEN._CurrTabName);
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
if (clsFunctionTemplateWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionTemplateEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionTemplateWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionTemplateEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsFunctionTemplateEN._CurrTabName;
List<clsFunctionTemplateEN> arrFunctionTemplateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFunctionTemplateObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFunctionTemplateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFunctionTemplate.FunctionTemplateId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionTemplate.FunctionTemplateName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionTemplate.FunctionTemplateENName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionTemplate.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionTemplate.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionTemplate.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionTemplate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionTemplate.Memo, Type.GetType("System.String"));
foreach (clsFunctionTemplateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFunctionTemplate.FunctionTemplateId] = objInFor[conFunctionTemplate.FunctionTemplateId];
objDR[conFunctionTemplate.FunctionTemplateName] = objInFor[conFunctionTemplate.FunctionTemplateName];
objDR[conFunctionTemplate.FunctionTemplateENName] = objInFor[conFunctionTemplate.FunctionTemplateENName];
objDR[conFunctionTemplate.ProgLangTypeId] = objInFor[conFunctionTemplate.ProgLangTypeId];
objDR[conFunctionTemplate.CreateUserId] = objInFor[conFunctionTemplate.CreateUserId];
objDR[conFunctionTemplate.UpdDate] = objInFor[conFunctionTemplate.UpdDate];
objDR[conFunctionTemplate.UpdUser] = objInFor[conFunctionTemplate.UpdUser];
objDR[conFunctionTemplate.Memo] = objInFor[conFunctionTemplate.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 函数模板(FunctionTemplate)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FunctionTemplate : clsCommFun4BL
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
clsFunctionTemplateWApi.ReFreshThisCache();
}
}

}