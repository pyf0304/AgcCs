
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFuncTemplateRelaWApi
 表名:vPrjFuncTemplateRela(00050318)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvPrjFuncTemplateRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetProgLangTypeName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convPrjFuncTemplateRela.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convPrjFuncTemplateRela.ProgLangTypeName);
objvPrjFuncTemplateRelaEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.ProgLangTypeName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.ProgLangTypeName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.ProgLangTypeName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateName">函数模板名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetFunctionTemplateName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strFunctionTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateName, convPrjFuncTemplateRela.FunctionTemplateName);
clsCheckSql.CheckFieldLen(strFunctionTemplateName, 50, convPrjFuncTemplateRela.FunctionTemplateName);
objvPrjFuncTemplateRelaEN.FunctionTemplateName = strFunctionTemplateName; //函数模板名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.FunctionTemplateName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.FunctionTemplateName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.FunctionTemplateName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeENName">代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetCodeTypeENName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convPrjFuncTemplateRela.CodeTypeENName);
objvPrjFuncTemplateRelaEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.CodeTypeENName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.CodeTypeENName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeENName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetCodeTypeName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convPrjFuncTemplateRela.CodeTypeName);
objvPrjFuncTemplateRelaEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.CodeTypeName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.CodeTypeName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetmId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, long lngmId, string strComparisonOp="")
	{
objvPrjFuncTemplateRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.mId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.mId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.mId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetPrjId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjFuncTemplateRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjFuncTemplateRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjFuncTemplateRela.PrjId);
objvPrjFuncTemplateRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.PrjId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.PrjId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.PrjId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetPrjName(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convPrjFuncTemplateRela.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjFuncTemplateRela.PrjName);
objvPrjFuncTemplateRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.PrjName) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.PrjName, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.PrjName] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetCodeTypeId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convPrjFuncTemplateRela.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convPrjFuncTemplateRela.CodeTypeId);
objvPrjFuncTemplateRelaEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.CodeTypeId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.CodeTypeId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetProgLangTypeId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convPrjFuncTemplateRela.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convPrjFuncTemplateRela.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convPrjFuncTemplateRela.ProgLangTypeId);
objvPrjFuncTemplateRelaEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.ProgLangTypeId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.ProgLangTypeId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.ProgLangTypeId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateId">函数模板Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetFunctionTemplateId(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateId, convPrjFuncTemplateRela.FunctionTemplateId);
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, convPrjFuncTemplateRela.FunctionTemplateId);
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, convPrjFuncTemplateRela.FunctionTemplateId);
objvPrjFuncTemplateRelaEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.FunctionTemplateId) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.FunctionTemplateId, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.FunctionTemplateId] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetUpdDate(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjFuncTemplateRela.UpdDate);
objvPrjFuncTemplateRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.UpdDate) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.UpdDate, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.UpdDate] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetUpdUser(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPrjFuncTemplateRela.UpdUser);
objvPrjFuncTemplateRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.UpdUser) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.UpdUser, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.UpdUser] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFuncTemplateRelaEN SetMemo(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjFuncTemplateRela.Memo);
objvPrjFuncTemplateRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFuncTemplateRelaEN.dicFldComparisonOp.ContainsKey(convPrjFuncTemplateRela.Memo) == false)
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp.Add(convPrjFuncTemplateRela.Memo, strComparisonOp);
}
else
{
objvPrjFuncTemplateRelaEN.dicFldComparisonOp[convPrjFuncTemplateRela.Memo] = strComparisonOp;
}
}
return objvPrjFuncTemplateRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.ProgLangTypeName, objvPrjFuncTemplateRelaCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.FunctionTemplateName) == true)
{
string strComparisonOpFunctionTemplateName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.FunctionTemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.FunctionTemplateName, objvPrjFuncTemplateRelaCond.FunctionTemplateName, strComparisonOpFunctionTemplateName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.CodeTypeENName, objvPrjFuncTemplateRelaCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.CodeTypeName, objvPrjFuncTemplateRelaCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.mId) == true)
{
string strComparisonOpmId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjFuncTemplateRela.mId, objvPrjFuncTemplateRelaCond.mId, strComparisonOpmId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.PrjId, objvPrjFuncTemplateRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.PrjName, objvPrjFuncTemplateRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.CodeTypeId, objvPrjFuncTemplateRelaCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.ProgLangTypeId, objvPrjFuncTemplateRelaCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.FunctionTemplateId, objvPrjFuncTemplateRelaCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.UpdDate, objvPrjFuncTemplateRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.UpdUser, objvPrjFuncTemplateRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPrjFuncTemplateRelaCond.IsUpdated(convPrjFuncTemplateRela.Memo) == true)
{
string strComparisonOpMemo = objvPrjFuncTemplateRelaCond.dicFldComparisonOp[convPrjFuncTemplateRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFuncTemplateRela.Memo, objvPrjFuncTemplateRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程与函数模板关系(vPrjFuncTemplateRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjFuncTemplateRelaWApi
{
private static readonly string mstrApiControllerName = "vPrjFuncTemplateRelaApi";

 public clsvPrjFuncTemplateRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFuncTemplateRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN;
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
objvPrjFuncTemplateRelaEN = JsonConvert.DeserializeObject<clsvPrjFuncTemplateRelaEN>(strJson);
return objvPrjFuncTemplateRelaEN;
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
public static clsvPrjFuncTemplateRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaEN;
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
objvPrjFuncTemplateRelaEN = JsonConvert.DeserializeObject<clsvPrjFuncTemplateRelaEN>(strJson);
return objvPrjFuncTemplateRelaEN;
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
public static clsvPrjFuncTemplateRelaEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPrjFuncTemplateRelaEN._CurrTabName);
List<clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLst_Sel =
from objvPrjFuncTemplateRelaEN in arrvPrjFuncTemplateRelaObjLstCache
where objvPrjFuncTemplateRelaEN.mId == lngmId 
select objvPrjFuncTemplateRelaEN;
if (arrvPrjFuncTemplateRelaObjLst_Sel.Count() == 0)
{
   clsvPrjFuncTemplateRelaEN obj = clsvPrjFuncTemplateRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjFuncTemplateRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFuncTemplateRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjFuncTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFuncTemplateRelaEN>>(strJson);
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvPrjFuncTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFuncTemplateRelaEN>>(strJson);
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
public static IEnumerable<clsvPrjFuncTemplateRelaEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPrjFuncTemplateRelaEN._CurrTabName);
List<clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLst_Sel =
from objvPrjFuncTemplateRelaEN in arrvPrjFuncTemplateRelaObjLstCache
where arrMId.Contains(objvPrjFuncTemplateRelaEN.mId)
select objvPrjFuncTemplateRelaEN;
return arrvPrjFuncTemplateRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFuncTemplateRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjFuncTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFuncTemplateRelaEN>>(strJson);
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjFuncTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFuncTemplateRelaEN>>(strJson);
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjFuncTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFuncTemplateRelaEN>>(strJson);
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
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjFuncTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjFuncTemplateRelaEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvPrjFuncTemplateRelaENS">源对象</param>
 /// <param name = "objvPrjFuncTemplateRelaENT">目标对象</param>
 public static void CopyTo(clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENS, clsvPrjFuncTemplateRelaEN objvPrjFuncTemplateRelaENT)
{
try
{
objvPrjFuncTemplateRelaENT.ProgLangTypeName = objvPrjFuncTemplateRelaENS.ProgLangTypeName; //编程语言类型名
objvPrjFuncTemplateRelaENT.FunctionTemplateName = objvPrjFuncTemplateRelaENS.FunctionTemplateName; //函数模板名
objvPrjFuncTemplateRelaENT.CodeTypeENName = objvPrjFuncTemplateRelaENS.CodeTypeENName; //代码类型英文名
objvPrjFuncTemplateRelaENT.CodeTypeName = objvPrjFuncTemplateRelaENS.CodeTypeName; //代码类型名
objvPrjFuncTemplateRelaENT.mId = objvPrjFuncTemplateRelaENS.mId; //mId
objvPrjFuncTemplateRelaENT.PrjId = objvPrjFuncTemplateRelaENS.PrjId; //工程Id
objvPrjFuncTemplateRelaENT.PrjName = objvPrjFuncTemplateRelaENS.PrjName; //工程名称
objvPrjFuncTemplateRelaENT.CodeTypeId = objvPrjFuncTemplateRelaENS.CodeTypeId; //代码类型Id
objvPrjFuncTemplateRelaENT.ProgLangTypeId = objvPrjFuncTemplateRelaENS.ProgLangTypeId; //编程语言类型Id
objvPrjFuncTemplateRelaENT.FunctionTemplateId = objvPrjFuncTemplateRelaENS.FunctionTemplateId; //函数模板Id
objvPrjFuncTemplateRelaENT.UpdDate = objvPrjFuncTemplateRelaENS.UpdDate; //修改日期
objvPrjFuncTemplateRelaENT.UpdUser = objvPrjFuncTemplateRelaENS.UpdUser; //修改者
objvPrjFuncTemplateRelaENT.Memo = objvPrjFuncTemplateRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvPrjFuncTemplateRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjFuncTemplateRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjFuncTemplateRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjFuncTemplateRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjFuncTemplateRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjFuncTemplateRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvPrjFuncTemplateRelaEN._CurrTabName);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjFuncTemplateRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvPrjFuncTemplateRelaEN._CurrTabName;
List<clsvPrjFuncTemplateRelaEN> arrvPrjFuncTemplateRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjFuncTemplateRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjFuncTemplateRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjFuncTemplateRela.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.FunctionTemplateName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPrjFuncTemplateRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.FunctionTemplateId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convPrjFuncTemplateRela.Memo, Type.GetType("System.String"));
foreach (clsvPrjFuncTemplateRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjFuncTemplateRela.ProgLangTypeName] = objInFor[convPrjFuncTemplateRela.ProgLangTypeName];
objDR[convPrjFuncTemplateRela.FunctionTemplateName] = objInFor[convPrjFuncTemplateRela.FunctionTemplateName];
objDR[convPrjFuncTemplateRela.CodeTypeENName] = objInFor[convPrjFuncTemplateRela.CodeTypeENName];
objDR[convPrjFuncTemplateRela.CodeTypeName] = objInFor[convPrjFuncTemplateRela.CodeTypeName];
objDR[convPrjFuncTemplateRela.mId] = objInFor[convPrjFuncTemplateRela.mId];
objDR[convPrjFuncTemplateRela.PrjId] = objInFor[convPrjFuncTemplateRela.PrjId];
objDR[convPrjFuncTemplateRela.PrjName] = objInFor[convPrjFuncTemplateRela.PrjName];
objDR[convPrjFuncTemplateRela.CodeTypeId] = objInFor[convPrjFuncTemplateRela.CodeTypeId];
objDR[convPrjFuncTemplateRela.ProgLangTypeId] = objInFor[convPrjFuncTemplateRela.ProgLangTypeId];
objDR[convPrjFuncTemplateRela.FunctionTemplateId] = objInFor[convPrjFuncTemplateRela.FunctionTemplateId];
objDR[convPrjFuncTemplateRela.UpdDate] = objInFor[convPrjFuncTemplateRela.UpdDate];
objDR[convPrjFuncTemplateRela.UpdUser] = objInFor[convPrjFuncTemplateRela.UpdUser];
objDR[convPrjFuncTemplateRela.Memo] = objInFor[convPrjFuncTemplateRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}