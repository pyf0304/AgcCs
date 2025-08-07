
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjCasesWApi
 表名:vPrjCases(00050258)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用例管理(CaseManage)
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
public static class  clsvPrjCasesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaseId">CaseId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseId(this clsvPrjCasesEN objvPrjCasesEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseId, 8, convPrjCases.CaseId);
objvPrjCasesEN.CaseId = strCaseId; //CaseId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaseName">CaseName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseName(this clsvPrjCasesEN objvPrjCasesEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, convPrjCases.CaseName);
clsCheckSql.CheckFieldLen(strCaseName, 20, convPrjCases.CaseName);
objvPrjCasesEN.CaseName = strCaseName; //CaseName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseName) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseName, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseName] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetPrjId(this clsvPrjCasesEN objvPrjCasesEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjCases.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjCases.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjCases.PrjId);
objvPrjCasesEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.PrjId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.PrjId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.PrjId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetPrjName(this clsvPrjCasesEN objvPrjCasesEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjCases.PrjName);
objvPrjCasesEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.PrjName) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.PrjName, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.PrjName] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaseContent">CaseContent</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseContent(this clsvPrjCasesEN objvPrjCasesEN, string strCaseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseContent, convPrjCases.CaseContent);
clsCheckSql.CheckFieldLen(strCaseContent, 1000, convPrjCases.CaseContent);
objvPrjCasesEN.CaseContent = strCaseContent; //CaseContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseContent) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseContent, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseContent] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaseTypeId">CaseTypeId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseTypeId(this clsvPrjCasesEN objvPrjCasesEN, string strCaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseTypeId, convPrjCases.CaseTypeId);
clsCheckSql.CheckFieldLen(strCaseTypeId, 4, convPrjCases.CaseTypeId);
objvPrjCasesEN.CaseTypeId = strCaseTypeId; //CaseTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseTypeId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseTypeId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseTypeId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaseTypeName">案例类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseTypeName(this clsvPrjCasesEN objvPrjCasesEN, string strCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseTypeName, 30, convPrjCases.CaseTypeName);
objvPrjCasesEN.CaseTypeName = strCaseTypeName; //案例类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseTypeName) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseTypeName, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseTypeName] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strImportLevelId">重要程度Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetImportLevelId(this clsvPrjCasesEN objvPrjCasesEN, string strImportLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImportLevelId, 4, convPrjCases.ImportLevelId);
objvPrjCasesEN.ImportLevelId = strImportLevelId; //重要程度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.ImportLevelId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.ImportLevelId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.ImportLevelId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetUserId(this clsvPrjCasesEN objvPrjCasesEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convPrjCases.UserId);
objvPrjCasesEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.UserId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.UserId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.UserId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetUpdDate(this clsvPrjCasesEN objvPrjCasesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjCases.UpdDate);
objvPrjCasesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.UpdDate) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.UpdDate, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.UpdDate] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strImportLevelName">重要程度名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetImportLevelName(this clsvPrjCasesEN objvPrjCasesEN, string strImportLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImportLevelName, 20, convPrjCases.ImportLevelName);
objvPrjCasesEN.ImportLevelName = strImportLevelName; //重要程度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.ImportLevelName) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.ImportLevelName, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.ImportLevelName] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetMemo(this clsvPrjCasesEN objvPrjCasesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjCases.Memo);
objvPrjCasesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.Memo) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.Memo, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.Memo] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjCasesEN objvPrjCasesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseId) == true)
{
string strComparisonOpCaseId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseId, objvPrjCasesCond.CaseId, strComparisonOpCaseId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseName) == true)
{
string strComparisonOpCaseName = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseName, objvPrjCasesCond.CaseName, strComparisonOpCaseName);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.PrjId, objvPrjCasesCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.PrjName, objvPrjCasesCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseContent) == true)
{
string strComparisonOpCaseContent = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseContent, objvPrjCasesCond.CaseContent, strComparisonOpCaseContent);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseTypeId) == true)
{
string strComparisonOpCaseTypeId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseTypeId, objvPrjCasesCond.CaseTypeId, strComparisonOpCaseTypeId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseTypeName) == true)
{
string strComparisonOpCaseTypeName = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseTypeName, objvPrjCasesCond.CaseTypeName, strComparisonOpCaseTypeName);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.ImportLevelId) == true)
{
string strComparisonOpImportLevelId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.ImportLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.ImportLevelId, objvPrjCasesCond.ImportLevelId, strComparisonOpImportLevelId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.UserId) == true)
{
string strComparisonOpUserId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.UserId, objvPrjCasesCond.UserId, strComparisonOpUserId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.UpdDate, objvPrjCasesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.ImportLevelName) == true)
{
string strComparisonOpImportLevelName = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.ImportLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.ImportLevelName, objvPrjCasesCond.ImportLevelName, strComparisonOpImportLevelName);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.Memo) == true)
{
string strComparisonOpMemo = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.Memo, objvPrjCasesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程用例(vPrjCases)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjCasesWApi
{
private static readonly string mstrApiControllerName = "vPrjCasesApi";

 public clsvPrjCasesWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjCasesEN GetObjByCaseId(string strCaseId)
{
if (strCaseId == "") return null;
string strAction = "GetObjByCaseId";
clsvPrjCasesEN objvPrjCasesEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCaseId"] = strCaseId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvPrjCasesEN = JsonConvert.DeserializeObject<clsvPrjCasesEN>(strJson);
return objvPrjCasesEN;
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
public static clsvPrjCasesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjCasesEN objvPrjCasesEN;
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
objvPrjCasesEN = JsonConvert.DeserializeObject<clsvPrjCasesEN>(strJson);
return objvPrjCasesEN;
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
public static List<clsvPrjCasesEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjCasesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjCasesEN>>(strJson);
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
 /// <param name = "arrCaseId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjCasesEN> GetObjLstByCaseIdLst(List<string> arrCaseId)
{
 List<clsvPrjCasesEN> arrObjLst; 
string strAction = "GetObjLstByCaseIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCaseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjCasesEN>>(strJson);
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
public static List<clsvPrjCasesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjCasesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjCasesEN>>(strJson);
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
public static List<clsvPrjCasesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjCasesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjCasesEN>>(strJson);
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
public static List<clsvPrjCasesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjCasesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjCasesEN>>(strJson);
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
public static List<clsvPrjCasesEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjCasesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjCasesEN>>(strJson);
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
public static bool IsExist(string strCaseId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCaseId"] = strCaseId
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvPrjCasesENS">源对象</param>
 /// <param name = "objvPrjCasesENT">目标对象</param>
 public static void CopyTo(clsvPrjCasesEN objvPrjCasesENS, clsvPrjCasesEN objvPrjCasesENT)
{
try
{
objvPrjCasesENT.CaseId = objvPrjCasesENS.CaseId; //CaseId
objvPrjCasesENT.CaseName = objvPrjCasesENS.CaseName; //CaseName
objvPrjCasesENT.PrjId = objvPrjCasesENS.PrjId; //工程Id
objvPrjCasesENT.PrjName = objvPrjCasesENS.PrjName; //工程名称
objvPrjCasesENT.CaseContent = objvPrjCasesENS.CaseContent; //CaseContent
objvPrjCasesENT.CaseTypeId = objvPrjCasesENS.CaseTypeId; //CaseTypeId
objvPrjCasesENT.CaseTypeName = objvPrjCasesENS.CaseTypeName; //案例类型名
objvPrjCasesENT.ImportLevelId = objvPrjCasesENS.ImportLevelId; //重要程度Id
objvPrjCasesENT.UserId = objvPrjCasesENS.UserId; //用户Id
objvPrjCasesENT.UpdDate = objvPrjCasesENS.UpdDate; //修改日期
objvPrjCasesENT.ImportLevelName = objvPrjCasesENS.ImportLevelName; //重要程度名称
objvPrjCasesENT.Memo = objvPrjCasesENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvPrjCasesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjCasesEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjCasesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjCasesEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjCasesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjCasesEN._AttributeName)
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
string strKey = string.Format("{0}", clsvPrjCasesEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjCasesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjCases.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.CaseContent, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.CaseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.CaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.ImportLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.ImportLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjCases.Memo, Type.GetType("System.String"));
foreach (clsvPrjCasesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjCases.CaseId] = objInFor[convPrjCases.CaseId];
objDR[convPrjCases.CaseName] = objInFor[convPrjCases.CaseName];
objDR[convPrjCases.PrjId] = objInFor[convPrjCases.PrjId];
objDR[convPrjCases.PrjName] = objInFor[convPrjCases.PrjName];
objDR[convPrjCases.CaseContent] = objInFor[convPrjCases.CaseContent];
objDR[convPrjCases.CaseTypeId] = objInFor[convPrjCases.CaseTypeId];
objDR[convPrjCases.CaseTypeName] = objInFor[convPrjCases.CaseTypeName];
objDR[convPrjCases.ImportLevelId] = objInFor[convPrjCases.ImportLevelId];
objDR[convPrjCases.UserId] = objInFor[convPrjCases.UserId];
objDR[convPrjCases.UpdDate] = objInFor[convPrjCases.UpdDate];
objDR[convPrjCases.ImportLevelName] = objInFor[convPrjCases.ImportLevelName];
objDR[convPrjCases.Memo] = objInFor[convPrjCases.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}