
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFunctionPropWApi
 表名:vTabFunctionProp(00050524)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:51
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
public static class  clsvTabFunctionPropWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetmId(this clsvTabFunctionPropEN objvTabFunctionPropEN, long lngmId, string strComparisonOp="")
	{
objvTabFunctionPropEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.mId) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.mId, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.mId] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetTabId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFunctionProp.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFunctionProp.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFunctionProp.TabId);
objvTabFunctionPropEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.TabId) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.TabId, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.TabId] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetTabName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convTabFunctionProp.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convTabFunctionProp.TabName);
objvTabFunctionPropEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.TabName) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.TabName, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.TabName] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetTabCnName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabFunctionProp.TabCnName);
objvTabFunctionPropEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.TabCnName) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.TabCnName, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.TabCnName] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateId">函数模板Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFunctionTemplateId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateId, convTabFunctionProp.FunctionTemplateId);
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, convTabFunctionProp.FunctionTemplateId);
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, convTabFunctionProp.FunctionTemplateId);
objvTabFunctionPropEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.FunctionTemplateId) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.FunctionTemplateId, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.FunctionTemplateId] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateName">函数模板名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFunctionTemplateName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFunctionTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateName, convTabFunctionProp.FunctionTemplateName);
clsCheckSql.CheckFieldLen(strFunctionTemplateName, 50, convTabFunctionProp.FunctionTemplateName);
objvTabFunctionPropEN.FunctionTemplateName = strFunctionTemplateName; //函数模板名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.FunctionTemplateName) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.FunctionTemplateName, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.FunctionTemplateName] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetCodeTypeId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convTabFunctionProp.CodeTypeId);
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convTabFunctionProp.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convTabFunctionProp.CodeTypeId);
objvTabFunctionPropEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.CodeTypeId) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.CodeTypeId, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.CodeTypeId] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetCodeTypeName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convTabFunctionProp.CodeTypeName);
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convTabFunctionProp.CodeTypeName);
objvTabFunctionPropEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.CodeTypeName) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.CodeTypeName, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.CodeTypeName] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeENName">代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetCodeTypeENName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convTabFunctionProp.CodeTypeENName);
objvTabFunctionPropEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.CodeTypeENName) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.CodeTypeENName, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.CodeTypeENName] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncId4GC(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, convTabFunctionProp.FuncId4GC);
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convTabFunctionProp.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convTabFunctionProp.FuncId4GC);
objvTabFunctionPropEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.FuncId4GC) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.FuncId4GC, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.FuncId4GC] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convTabFunctionProp.FuncName);
clsCheckSql.CheckFieldLen(strFuncName, 100, convTabFunctionProp.FuncName);
objvTabFunctionPropEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.FuncName) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.FuncName, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.FuncName] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncId4Code(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4Code, convTabFunctionProp.FuncId4Code);
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convTabFunctionProp.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convTabFunctionProp.FuncId4Code);
objvTabFunctionPropEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.FuncId4Code) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.FuncId4Code, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.FuncId4Code] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4Code">函数名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncName4Code(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, convTabFunctionProp.FuncName4Code);
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convTabFunctionProp.FuncName4Code);
objvTabFunctionPropEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.FuncName4Code) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.FuncName4Code, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.FuncName4Code] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCHName4Code">函数中文名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncCHName4Code(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncCHName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, convTabFunctionProp.FuncCHName4Code);
objvTabFunctionPropEN.FuncCHName4Code = strFuncCHName4Code; //函数中文名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.FuncCHName4Code) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.FuncCHName4Code, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.FuncCHName4Code] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetProgLangTypeId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convTabFunctionProp.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convTabFunctionProp.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convTabFunctionProp.ProgLangTypeId);
objvTabFunctionPropEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.ProgLangTypeId) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.ProgLangTypeId, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.ProgLangTypeId] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetProgLangTypeName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convTabFunctionProp.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convTabFunctionProp.ProgLangTypeName);
objvTabFunctionPropEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.ProgLangTypeName) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.ProgLangTypeName, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.ProgLangTypeName] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strMethodModifierId">函数修饰语Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetMethodModifierId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strMethodModifierId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMethodModifierId, 2, convTabFunctionProp.MethodModifierId);
clsCheckSql.CheckFieldForeignKey(strMethodModifierId, 2, convTabFunctionProp.MethodModifierId);
objvTabFunctionPropEN.MethodModifierId = strMethodModifierId; //函数修饰语Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.MethodModifierId) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.MethodModifierId, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.MethodModifierId] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strMethodModifierName">函数修饰语名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetMethodModifierName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strMethodModifierName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMethodModifierName, 50, convTabFunctionProp.MethodModifierName);
objvTabFunctionPropEN.MethodModifierName = strMethodModifierName; //函数修饰语名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.MethodModifierName) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.MethodModifierName, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.MethodModifierName] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForAllTemplate">是否针对所有模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetIsForAllTemplate(this clsvTabFunctionPropEN objvTabFunctionPropEN, bool bolIsForAllTemplate, string strComparisonOp="")
	{
objvTabFunctionPropEN.IsForAllTemplate = bolIsForAllTemplate; //是否针对所有模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.IsForAllTemplate) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.IsForAllTemplate, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.IsForAllTemplate] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetPrjId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFunctionProp.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFunctionProp.PrjId);
objvTabFunctionPropEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.PrjId) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.PrjId, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.PrjId] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetUpdDate(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTabFunctionProp.UpdDate);
objvTabFunctionPropEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.UpdDate) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.UpdDate, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.UpdDate] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetUpdUser(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTabFunctionProp.UpdUser);
objvTabFunctionPropEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.UpdUser) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.UpdUser, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.UpdUser] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetMemo(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFunctionProp.Memo);
objvTabFunctionPropEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.Memo) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.Memo, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.Memo] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrder4Func">Order4函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetOrder4Func(this clsvTabFunctionPropEN objvTabFunctionPropEN, int intOrder4Func, string strComparisonOp="")
	{
objvTabFunctionPropEN.Order4Func = intOrder4Func; //Order4函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFunctionPropEN.dicFldComparisonOp.ContainsKey(convTabFunctionProp.Order4Func) == false)
{
objvTabFunctionPropEN.dicFldComparisonOp.Add(convTabFunctionProp.Order4Func, strComparisonOp);
}
else
{
objvTabFunctionPropEN.dicFldComparisonOp[convTabFunctionProp.Order4Func] = strComparisonOp;
}
}
return objvTabFunctionPropEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTabFunctionPropEN objvTabFunctionPropCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.mId) == true)
{
string strComparisonOpmId = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFunctionProp.mId, objvTabFunctionPropCond.mId, strComparisonOpmId);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.TabId) == true)
{
string strComparisonOpTabId = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.TabId, objvTabFunctionPropCond.TabId, strComparisonOpTabId);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.TabName) == true)
{
string strComparisonOpTabName = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.TabName, objvTabFunctionPropCond.TabName, strComparisonOpTabName);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.TabCnName) == true)
{
string strComparisonOpTabCnName = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.TabCnName, objvTabFunctionPropCond.TabCnName, strComparisonOpTabCnName);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.FunctionTemplateId, objvTabFunctionPropCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.FunctionTemplateName) == true)
{
string strComparisonOpFunctionTemplateName = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.FunctionTemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.FunctionTemplateName, objvTabFunctionPropCond.FunctionTemplateName, strComparisonOpFunctionTemplateName);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.CodeTypeId, objvTabFunctionPropCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.CodeTypeName, objvTabFunctionPropCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.CodeTypeENName, objvTabFunctionPropCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.FuncId4GC, objvTabFunctionPropCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.FuncName) == true)
{
string strComparisonOpFuncName = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.FuncName, objvTabFunctionPropCond.FuncName, strComparisonOpFuncName);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.FuncId4Code, objvTabFunctionPropCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.FuncName4Code, objvTabFunctionPropCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.FuncCHName4Code) == true)
{
string strComparisonOpFuncCHName4Code = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.FuncCHName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.FuncCHName4Code, objvTabFunctionPropCond.FuncCHName4Code, strComparisonOpFuncCHName4Code);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.ProgLangTypeId, objvTabFunctionPropCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.ProgLangTypeName, objvTabFunctionPropCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.MethodModifierId) == true)
{
string strComparisonOpMethodModifierId = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.MethodModifierId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.MethodModifierId, objvTabFunctionPropCond.MethodModifierId, strComparisonOpMethodModifierId);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.MethodModifierName) == true)
{
string strComparisonOpMethodModifierName = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.MethodModifierName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.MethodModifierName, objvTabFunctionPropCond.MethodModifierName, strComparisonOpMethodModifierName);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.IsForAllTemplate) == true)
{
if (objvTabFunctionPropCond.IsForAllTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFunctionProp.IsForAllTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFunctionProp.IsForAllTemplate);
}
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.PrjId) == true)
{
string strComparisonOpPrjId = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.PrjId, objvTabFunctionPropCond.PrjId, strComparisonOpPrjId);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.UpdDate) == true)
{
string strComparisonOpUpdDate = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.UpdDate, objvTabFunctionPropCond.UpdDate, strComparisonOpUpdDate);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.UpdUser) == true)
{
string strComparisonOpUpdUser = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.UpdUser, objvTabFunctionPropCond.UpdUser, strComparisonOpUpdUser);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.Memo) == true)
{
string strComparisonOpMemo = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFunctionProp.Memo, objvTabFunctionPropCond.Memo, strComparisonOpMemo);
}
if (objvTabFunctionPropCond.IsUpdated(convTabFunctionProp.Order4Func) == true)
{
string strComparisonOpOrder4Func = objvTabFunctionPropCond.dicFldComparisonOp[convTabFunctionProp.Order4Func];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFunctionProp.Order4Func, objvTabFunctionPropCond.Order4Func, strComparisonOpOrder4Func);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vTabFunctionProp(vTabFunctionProp)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTabFunctionPropWApi
{
private static readonly string mstrApiControllerName = "vTabFunctionPropApi";

 public clsvTabFunctionPropWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFunctionPropEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvTabFunctionPropEN objvTabFunctionPropEN;
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
objvTabFunctionPropEN = JsonConvert.DeserializeObject<clsvTabFunctionPropEN>(strJson);
return objvTabFunctionPropEN;
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
public static clsvTabFunctionPropEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvTabFunctionPropEN objvTabFunctionPropEN;
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
objvTabFunctionPropEN = JsonConvert.DeserializeObject<clsvTabFunctionPropEN>(strJson);
return objvTabFunctionPropEN;
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
public static clsvTabFunctionPropEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabFunctionPropEN._CurrTabName, strPrjId);
List<clsvTabFunctionPropEN> arrvTabFunctionPropObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFunctionPropEN> arrvTabFunctionPropObjLst_Sel =
from objvTabFunctionPropEN in arrvTabFunctionPropObjLstCache
where objvTabFunctionPropEN.mId == lngmId 
select objvTabFunctionPropEN;
if (arrvTabFunctionPropObjLst_Sel.Count() == 0)
{
   clsvTabFunctionPropEN obj = clsvTabFunctionPropWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTabFunctionPropObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLst(string strWhereCond)
{
 List<clsvTabFunctionPropEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFunctionPropEN>>(strJson);
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
public static List<clsvTabFunctionPropEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvTabFunctionPropEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFunctionPropEN>>(strJson);
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
public static IEnumerable<clsvTabFunctionPropEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabFunctionPropEN._CurrTabName, strPrjId);
List<clsvTabFunctionPropEN> arrvTabFunctionPropObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFunctionPropEN> arrvTabFunctionPropObjLst_Sel =
from objvTabFunctionPropEN in arrvTabFunctionPropObjLstCache
where arrMId.Contains(objvTabFunctionPropEN.mId)
select objvTabFunctionPropEN;
return arrvTabFunctionPropObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTabFunctionPropEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFunctionPropEN>>(strJson);
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
public static List<clsvTabFunctionPropEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTabFunctionPropEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFunctionPropEN>>(strJson);
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
public static List<clsvTabFunctionPropEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTabFunctionPropEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFunctionPropEN>>(strJson);
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
public static List<clsvTabFunctionPropEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvTabFunctionPropEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFunctionPropEN>>(strJson);
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
 /// <param name = "objvTabFunctionPropENS">源对象</param>
 /// <param name = "objvTabFunctionPropENT">目标对象</param>
 public static void CopyTo(clsvTabFunctionPropEN objvTabFunctionPropENS, clsvTabFunctionPropEN objvTabFunctionPropENT)
{
try
{
objvTabFunctionPropENT.mId = objvTabFunctionPropENS.mId; //mId
objvTabFunctionPropENT.TabId = objvTabFunctionPropENS.TabId; //表ID
objvTabFunctionPropENT.TabName = objvTabFunctionPropENS.TabName; //表名
objvTabFunctionPropENT.TabCnName = objvTabFunctionPropENS.TabCnName; //表中文名
objvTabFunctionPropENT.FunctionTemplateId = objvTabFunctionPropENS.FunctionTemplateId; //函数模板Id
objvTabFunctionPropENT.FunctionTemplateName = objvTabFunctionPropENS.FunctionTemplateName; //函数模板名
objvTabFunctionPropENT.CodeTypeId = objvTabFunctionPropENS.CodeTypeId; //代码类型Id
objvTabFunctionPropENT.CodeTypeName = objvTabFunctionPropENS.CodeTypeName; //代码类型名
objvTabFunctionPropENT.CodeTypeENName = objvTabFunctionPropENS.CodeTypeENName; //代码类型英文名
objvTabFunctionPropENT.FuncId4GC = objvTabFunctionPropENS.FuncId4GC; //函数ID
objvTabFunctionPropENT.FuncName = objvTabFunctionPropENS.FuncName; //函数名
objvTabFunctionPropENT.FuncId4Code = objvTabFunctionPropENS.FuncId4Code; //函数Id4Code
objvTabFunctionPropENT.FuncName4Code = objvTabFunctionPropENS.FuncName4Code; //函数名4Code
objvTabFunctionPropENT.FuncCHName4Code = objvTabFunctionPropENS.FuncCHName4Code; //函数中文名4Code
objvTabFunctionPropENT.ProgLangTypeId = objvTabFunctionPropENS.ProgLangTypeId; //编程语言类型Id
objvTabFunctionPropENT.ProgLangTypeName = objvTabFunctionPropENS.ProgLangTypeName; //编程语言类型名
objvTabFunctionPropENT.MethodModifierId = objvTabFunctionPropENS.MethodModifierId; //函数修饰语Id
objvTabFunctionPropENT.MethodModifierName = objvTabFunctionPropENS.MethodModifierName; //函数修饰语名称
objvTabFunctionPropENT.IsForAllTemplate = objvTabFunctionPropENS.IsForAllTemplate; //是否针对所有模板
objvTabFunctionPropENT.PrjId = objvTabFunctionPropENS.PrjId; //工程Id
objvTabFunctionPropENT.UpdDate = objvTabFunctionPropENS.UpdDate; //修改日期
objvTabFunctionPropENT.UpdUser = objvTabFunctionPropENS.UpdUser; //修改者
objvTabFunctionPropENT.Memo = objvTabFunctionPropENS.Memo; //说明
objvTabFunctionPropENT.Order4Func = objvTabFunctionPropENS.Order4Func; //Order4函数
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
public static DataTable ToDataTable(List<clsvTabFunctionPropEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTabFunctionPropEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTabFunctionPropEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTabFunctionPropEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTabFunctionPropEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTabFunctionPropEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabFunctionPropWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabFunctionPropWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvTabFunctionPropEN._CurrTabName, strPrjId);
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
public static List<clsvTabFunctionPropEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabFunctionPropWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabFunctionPropWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvTabFunctionPropEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvTabFunctionPropEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convTabFunctionProp.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvTabFunctionPropEN._CurrTabName, strPrjId);
List<clsvTabFunctionPropEN> arrvTabFunctionPropObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvTabFunctionPropObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvTabFunctionPropEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabFunctionPropWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabFunctionPropWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvTabFunctionPropEN._CurrTabName, strPrjId);
List<clsvTabFunctionPropEN> arrvTabFunctionPropObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvTabFunctionPropObjLstCache = CacheHelper.Get<List<clsvTabFunctionPropEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvTabFunctionPropObjLstCache = CacheHelper.Get<List<clsvTabFunctionPropEN>>(strKey);
}
return arrvTabFunctionPropObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTabFunctionPropEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTabFunctionProp.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convTabFunctionProp.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.FunctionTemplateId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.FunctionTemplateName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.FuncName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.FuncCHName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.MethodModifierId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.MethodModifierName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.IsForAllTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFunctionProp.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTabFunctionProp.Order4Func, Type.GetType("System.Int32"));
foreach (clsvTabFunctionPropEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTabFunctionProp.mId] = objInFor[convTabFunctionProp.mId];
objDR[convTabFunctionProp.TabId] = objInFor[convTabFunctionProp.TabId];
objDR[convTabFunctionProp.TabName] = objInFor[convTabFunctionProp.TabName];
objDR[convTabFunctionProp.TabCnName] = objInFor[convTabFunctionProp.TabCnName];
objDR[convTabFunctionProp.FunctionTemplateId] = objInFor[convTabFunctionProp.FunctionTemplateId];
objDR[convTabFunctionProp.FunctionTemplateName] = objInFor[convTabFunctionProp.FunctionTemplateName];
objDR[convTabFunctionProp.CodeTypeId] = objInFor[convTabFunctionProp.CodeTypeId];
objDR[convTabFunctionProp.CodeTypeName] = objInFor[convTabFunctionProp.CodeTypeName];
objDR[convTabFunctionProp.CodeTypeENName] = objInFor[convTabFunctionProp.CodeTypeENName];
objDR[convTabFunctionProp.FuncId4GC] = objInFor[convTabFunctionProp.FuncId4GC];
objDR[convTabFunctionProp.FuncName] = objInFor[convTabFunctionProp.FuncName];
objDR[convTabFunctionProp.FuncId4Code] = objInFor[convTabFunctionProp.FuncId4Code];
objDR[convTabFunctionProp.FuncName4Code] = objInFor[convTabFunctionProp.FuncName4Code];
objDR[convTabFunctionProp.FuncCHName4Code] = objInFor[convTabFunctionProp.FuncCHName4Code];
objDR[convTabFunctionProp.ProgLangTypeId] = objInFor[convTabFunctionProp.ProgLangTypeId];
objDR[convTabFunctionProp.ProgLangTypeName] = objInFor[convTabFunctionProp.ProgLangTypeName];
objDR[convTabFunctionProp.MethodModifierId] = objInFor[convTabFunctionProp.MethodModifierId];
objDR[convTabFunctionProp.MethodModifierName] = objInFor[convTabFunctionProp.MethodModifierName];
objDR[convTabFunctionProp.IsForAllTemplate] = objInFor[convTabFunctionProp.IsForAllTemplate];
objDR[convTabFunctionProp.PrjId] = objInFor[convTabFunctionProp.PrjId];
objDR[convTabFunctionProp.UpdDate] = objInFor[convTabFunctionProp.UpdDate];
objDR[convTabFunctionProp.UpdUser] = objInFor[convTabFunctionProp.UpdUser];
objDR[convTabFunctionProp.Memo] = objInFor[convTabFunctionProp.Memo];
objDR[convTabFunctionProp.Order4Func] = objInFor[convTabFunctionProp.Order4Func];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}