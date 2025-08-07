
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFunctionPropBL
 表名:vTabFunctionProp(00050524)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:13
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvTabFunctionPropBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFunctionPropEN GetObj(this K_mId_vTabFunctionProp myKey)
{
clsvTabFunctionPropEN objvTabFunctionPropEN = clsvTabFunctionPropBL.vTabFunctionPropDA.GetObjBymId(myKey.Value);
return objvTabFunctionPropEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetTabId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFunctionProp.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFunctionProp.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFunctionProp.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetTabName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convTabFunctionProp.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convTabFunctionProp.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetTabCnName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabFunctionProp.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFunctionTemplateId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateId, convTabFunctionProp.FunctionTemplateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, convTabFunctionProp.FunctionTemplateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, convTabFunctionProp.FunctionTemplateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFunctionTemplateName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFunctionTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateName, convTabFunctionProp.FunctionTemplateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateName, 50, convTabFunctionProp.FunctionTemplateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetCodeTypeId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convTabFunctionProp.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convTabFunctionProp.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convTabFunctionProp.CodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetCodeTypeName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convTabFunctionProp.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convTabFunctionProp.CodeTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetCodeTypeENName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convTabFunctionProp.CodeTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncId4GC(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, convTabFunctionProp.FuncId4GC);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convTabFunctionProp.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convTabFunctionProp.FuncId4GC);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convTabFunctionProp.FuncName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convTabFunctionProp.FuncName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncId4Code(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4Code, convTabFunctionProp.FuncId4Code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convTabFunctionProp.FuncId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convTabFunctionProp.FuncId4Code);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncName4Code(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, convTabFunctionProp.FuncName4Code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convTabFunctionProp.FuncName4Code);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetFuncCHName4Code(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strFuncCHName4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, convTabFunctionProp.FuncCHName4Code);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetProgLangTypeId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convTabFunctionProp.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convTabFunctionProp.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convTabFunctionProp.ProgLangTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetProgLangTypeName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convTabFunctionProp.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convTabFunctionProp.ProgLangTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetMethodModifierId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strMethodModifierId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMethodModifierId, 2, convTabFunctionProp.MethodModifierId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMethodModifierId, 2, convTabFunctionProp.MethodModifierId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetMethodModifierName(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strMethodModifierName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMethodModifierName, 50, convTabFunctionProp.MethodModifierName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetPrjId(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFunctionProp.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFunctionProp.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetUpdDate(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTabFunctionProp.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetUpdUser(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTabFunctionProp.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetMemo(this clsvTabFunctionPropEN objvTabFunctionPropEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFunctionProp.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFunctionPropEN SetOrder4Func(this clsvTabFunctionPropEN objvTabFunctionPropEN, int? intOrder4Func, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTabFunctionPropENS">源对象</param>
 /// <param name = "objvTabFunctionPropENT">目标对象</param>
 public static void CopyTo(this clsvTabFunctionPropEN objvTabFunctionPropENS, clsvTabFunctionPropEN objvTabFunctionPropENT)
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
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvTabFunctionPropENS">源对象</param>
 /// <returns>目标对象=>clsvTabFunctionPropEN:objvTabFunctionPropENT</returns>
 public static clsvTabFunctionPropEN CopyTo(this clsvTabFunctionPropEN objvTabFunctionPropENS)
{
try
{
 clsvTabFunctionPropEN objvTabFunctionPropENT = new clsvTabFunctionPropEN()
{
mId = objvTabFunctionPropENS.mId, //mId
TabId = objvTabFunctionPropENS.TabId, //表ID
TabName = objvTabFunctionPropENS.TabName, //表名
TabCnName = objvTabFunctionPropENS.TabCnName, //表中文名
FunctionTemplateId = objvTabFunctionPropENS.FunctionTemplateId, //函数模板Id
FunctionTemplateName = objvTabFunctionPropENS.FunctionTemplateName, //函数模板名
CodeTypeId = objvTabFunctionPropENS.CodeTypeId, //代码类型Id
CodeTypeName = objvTabFunctionPropENS.CodeTypeName, //代码类型名
CodeTypeENName = objvTabFunctionPropENS.CodeTypeENName, //代码类型英文名
FuncId4GC = objvTabFunctionPropENS.FuncId4GC, //函数ID
FuncName = objvTabFunctionPropENS.FuncName, //函数名
FuncId4Code = objvTabFunctionPropENS.FuncId4Code, //函数Id4Code
FuncName4Code = objvTabFunctionPropENS.FuncName4Code, //函数名4Code
FuncCHName4Code = objvTabFunctionPropENS.FuncCHName4Code, //函数中文名4Code
ProgLangTypeId = objvTabFunctionPropENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvTabFunctionPropENS.ProgLangTypeName, //编程语言类型名
MethodModifierId = objvTabFunctionPropENS.MethodModifierId, //函数修饰语Id
MethodModifierName = objvTabFunctionPropENS.MethodModifierName, //函数修饰语名称
IsForAllTemplate = objvTabFunctionPropENS.IsForAllTemplate, //是否针对所有模板
PrjId = objvTabFunctionPropENS.PrjId, //工程Id
UpdDate = objvTabFunctionPropENS.UpdDate, //修改日期
UpdUser = objvTabFunctionPropENS.UpdUser, //修改者
Memo = objvTabFunctionPropENS.Memo, //说明
Order4Func = objvTabFunctionPropENS.Order4Func, //Order4函数
};
 return objvTabFunctionPropENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvTabFunctionPropEN objvTabFunctionPropEN)
{
 clsvTabFunctionPropBL.vTabFunctionPropDA.CheckProperty4Condition(objvTabFunctionPropEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTabFunctionProp
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vTabFunctionProp(vTabFunctionProp)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTabFunctionPropBL
{
public static RelatedActions_vTabFunctionProp relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTabFunctionPropDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTabFunctionPropDA vTabFunctionPropDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTabFunctionPropDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTabFunctionPropBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvTabFunctionPropEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFunctionPropEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vTabFunctionProp(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabFunctionPropDA.GetDataTable_vTabFunctionProp(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabFunctionPropDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTabFunctionPropDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vTabFunctionPropDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTabFunctionPropDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vTabFunctionPropDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTabFunctionPropDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vTabFunctionPropDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vTabFunctionPropDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTabFunctionPropEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvTabFunctionPropEN._CurrTabName, strPrjId);
List<clsvTabFunctionPropEN> arrvTabFunctionPropObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFunctionPropEN> arrvTabFunctionPropObjLst_Sel =
arrvTabFunctionPropObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvTabFunctionPropObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLst(string strWhereCond)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTabFunctionPropCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTabFunctionPropEN> GetSubObjLstCache(clsvTabFunctionPropEN objvTabFunctionPropCond)
{
 string strPrjId = objvTabFunctionPropCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvTabFunctionPropBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvTabFunctionPropEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFunctionPropEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFunctionProp._AttributeName)
{
if (objvTabFunctionPropCond.IsUpdated(strFldName) == false) continue;
if (objvTabFunctionPropCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFunctionPropCond[strFldName].ToString());
}
else
{
if (objvTabFunctionPropCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFunctionPropCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFunctionPropCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFunctionPropCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFunctionPropCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFunctionPropCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvTabFunctionPropEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabFunctionPropEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTabFunctionPropEN> arrObjLst = new List<clsvTabFunctionPropEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFunctionPropEN objvTabFunctionPropEN = new clsvTabFunctionPropEN();
try
{
objvTabFunctionPropEN.mId = Int32.Parse(objRow[convTabFunctionProp.mId].ToString().Trim()); //mId
objvTabFunctionPropEN.TabId = objRow[convTabFunctionProp.TabId].ToString().Trim(); //表ID
objvTabFunctionPropEN.TabName = objRow[convTabFunctionProp.TabName].ToString().Trim(); //表名
objvTabFunctionPropEN.TabCnName = objRow[convTabFunctionProp.TabCnName] == DBNull.Value ? null : objRow[convTabFunctionProp.TabCnName].ToString().Trim(); //表中文名
objvTabFunctionPropEN.FunctionTemplateId = objRow[convTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objvTabFunctionPropEN.FunctionTemplateName = objRow[convTabFunctionProp.FunctionTemplateName].ToString().Trim(); //函数模板名
objvTabFunctionPropEN.CodeTypeId = objRow[convTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objvTabFunctionPropEN.CodeTypeName = objRow[convTabFunctionProp.CodeTypeName].ToString().Trim(); //代码类型名
objvTabFunctionPropEN.CodeTypeENName = objRow[convTabFunctionProp.CodeTypeENName] == DBNull.Value ? null : objRow[convTabFunctionProp.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvTabFunctionPropEN.FuncId4GC = objRow[convTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objvTabFunctionPropEN.FuncName = objRow[convTabFunctionProp.FuncName].ToString().Trim(); //函数名
objvTabFunctionPropEN.FuncId4Code = objRow[convTabFunctionProp.FuncId4Code].ToString().Trim(); //函数Id4Code
objvTabFunctionPropEN.FuncName4Code = objRow[convTabFunctionProp.FuncName4Code].ToString().Trim(); //函数名4Code
objvTabFunctionPropEN.FuncCHName4Code = objRow[convTabFunctionProp.FuncCHName4Code] == DBNull.Value ? null : objRow[convTabFunctionProp.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvTabFunctionPropEN.ProgLangTypeId = objRow[convTabFunctionProp.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvTabFunctionPropEN.ProgLangTypeName = objRow[convTabFunctionProp.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvTabFunctionPropEN.MethodModifierId = objRow[convTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objvTabFunctionPropEN.MethodModifierName = objRow[convTabFunctionProp.MethodModifierName] == DBNull.Value ? null : objRow[convTabFunctionProp.MethodModifierName].ToString().Trim(); //函数修饰语名称
objvTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[convTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objvTabFunctionPropEN.PrjId = objRow[convTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[convTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objvTabFunctionPropEN.UpdDate = objRow[convTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objvTabFunctionPropEN.UpdUser = objRow[convTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[convTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objvTabFunctionPropEN.Memo = objRow[convTabFunctionProp.Memo] == DBNull.Value ? null : objRow[convTabFunctionProp.Memo].ToString().Trim(); //说明
objvTabFunctionPropEN.Order4Func = objRow[convTabFunctionProp.Order4Func] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFunctionProp.Order4Func].ToString().Trim()); //Order4函数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFunctionPropEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTabFunctionProp(ref clsvTabFunctionPropEN objvTabFunctionPropEN)
{
bool bolResult = vTabFunctionPropDA.GetvTabFunctionProp(ref objvTabFunctionPropEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFunctionPropEN GetObjBymId(long lngmId)
{
clsvTabFunctionPropEN objvTabFunctionPropEN = vTabFunctionPropDA.GetObjBymId(lngmId);
return objvTabFunctionPropEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTabFunctionPropEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTabFunctionPropEN objvTabFunctionPropEN = vTabFunctionPropDA.GetFirstObj(strWhereCond);
 return objvTabFunctionPropEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvTabFunctionPropEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTabFunctionPropEN objvTabFunctionPropEN = vTabFunctionPropDA.GetObjByDataRow(objRow);
 return objvTabFunctionPropEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvTabFunctionPropEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTabFunctionPropEN objvTabFunctionPropEN = vTabFunctionPropDA.GetObjByDataRow(objRow);
 return objvTabFunctionPropEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvTabFunctionPropObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFunctionPropEN GetObjBymIdFromList(long lngmId, List<clsvTabFunctionPropEN> lstvTabFunctionPropObjLst)
{
foreach (clsvTabFunctionPropEN objvTabFunctionPropEN in lstvTabFunctionPropObjLst)
{
if (objvTabFunctionPropEN.mId == lngmId)
{
return objvTabFunctionPropEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvTabFunctionPropDA().GetFirstID(strWhereCond);
 return lngmId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vTabFunctionPropDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vTabFunctionPropDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vTabFunctionPropDA.IsExist(lngmId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvTabFunctionPropDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vTabFunctionPropDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">源简化对象</param>
 public static void SetUpdFlag(clsvTabFunctionPropEN objvTabFunctionPropEN)
{
try
{
objvTabFunctionPropEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTabFunctionPropEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTabFunctionProp.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.mId = objvTabFunctionPropEN.mId; //mId
}
if (arrFldSet.Contains(convTabFunctionProp.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.TabId = objvTabFunctionPropEN.TabId; //表ID
}
if (arrFldSet.Contains(convTabFunctionProp.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.TabName = objvTabFunctionPropEN.TabName; //表名
}
if (arrFldSet.Contains(convTabFunctionProp.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.TabCnName = objvTabFunctionPropEN.TabCnName == "[null]" ? null :  objvTabFunctionPropEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convTabFunctionProp.FunctionTemplateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.FunctionTemplateId = objvTabFunctionPropEN.FunctionTemplateId; //函数模板Id
}
if (arrFldSet.Contains(convTabFunctionProp.FunctionTemplateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.FunctionTemplateName = objvTabFunctionPropEN.FunctionTemplateName; //函数模板名
}
if (arrFldSet.Contains(convTabFunctionProp.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.CodeTypeId = objvTabFunctionPropEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convTabFunctionProp.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.CodeTypeName = objvTabFunctionPropEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convTabFunctionProp.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.CodeTypeENName = objvTabFunctionPropEN.CodeTypeENName == "[null]" ? null :  objvTabFunctionPropEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(convTabFunctionProp.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.FuncId4GC = objvTabFunctionPropEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(convTabFunctionProp.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.FuncName = objvTabFunctionPropEN.FuncName; //函数名
}
if (arrFldSet.Contains(convTabFunctionProp.FuncId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.FuncId4Code = objvTabFunctionPropEN.FuncId4Code; //函数Id4Code
}
if (arrFldSet.Contains(convTabFunctionProp.FuncName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.FuncName4Code = objvTabFunctionPropEN.FuncName4Code; //函数名4Code
}
if (arrFldSet.Contains(convTabFunctionProp.FuncCHName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.FuncCHName4Code = objvTabFunctionPropEN.FuncCHName4Code == "[null]" ? null :  objvTabFunctionPropEN.FuncCHName4Code; //函数中文名4Code
}
if (arrFldSet.Contains(convTabFunctionProp.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.ProgLangTypeId = objvTabFunctionPropEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convTabFunctionProp.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.ProgLangTypeName = objvTabFunctionPropEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convTabFunctionProp.MethodModifierId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.MethodModifierId = objvTabFunctionPropEN.MethodModifierId == "[null]" ? null :  objvTabFunctionPropEN.MethodModifierId; //函数修饰语Id
}
if (arrFldSet.Contains(convTabFunctionProp.MethodModifierName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.MethodModifierName = objvTabFunctionPropEN.MethodModifierName == "[null]" ? null :  objvTabFunctionPropEN.MethodModifierName; //函数修饰语名称
}
if (arrFldSet.Contains(convTabFunctionProp.IsForAllTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.IsForAllTemplate = objvTabFunctionPropEN.IsForAllTemplate; //是否针对所有模板
}
if (arrFldSet.Contains(convTabFunctionProp.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.PrjId = objvTabFunctionPropEN.PrjId == "[null]" ? null :  objvTabFunctionPropEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convTabFunctionProp.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.UpdDate = objvTabFunctionPropEN.UpdDate == "[null]" ? null :  objvTabFunctionPropEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convTabFunctionProp.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.UpdUser = objvTabFunctionPropEN.UpdUser == "[null]" ? null :  objvTabFunctionPropEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convTabFunctionProp.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.Memo = objvTabFunctionPropEN.Memo == "[null]" ? null :  objvTabFunctionPropEN.Memo; //说明
}
if (arrFldSet.Contains(convTabFunctionProp.Order4Func, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFunctionPropEN.Order4Func = objvTabFunctionPropEN.Order4Func; //Order4函数
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvTabFunctionPropEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTabFunctionPropEN objvTabFunctionPropEN)
{
try
{
if (objvTabFunctionPropEN.TabCnName == "[null]") objvTabFunctionPropEN.TabCnName = null; //表中文名
if (objvTabFunctionPropEN.CodeTypeENName == "[null]") objvTabFunctionPropEN.CodeTypeENName = null; //代码类型英文名
if (objvTabFunctionPropEN.FuncCHName4Code == "[null]") objvTabFunctionPropEN.FuncCHName4Code = null; //函数中文名4Code
if (objvTabFunctionPropEN.MethodModifierId == "[null]") objvTabFunctionPropEN.MethodModifierId = null; //函数修饰语Id
if (objvTabFunctionPropEN.MethodModifierName == "[null]") objvTabFunctionPropEN.MethodModifierName = null; //函数修饰语名称
if (objvTabFunctionPropEN.PrjId == "[null]") objvTabFunctionPropEN.PrjId = null; //工程Id
if (objvTabFunctionPropEN.UpdDate == "[null]") objvTabFunctionPropEN.UpdDate = null; //修改日期
if (objvTabFunctionPropEN.UpdUser == "[null]") objvTabFunctionPropEN.UpdUser = null; //修改者
if (objvTabFunctionPropEN.Memo == "[null]") objvTabFunctionPropEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvTabFunctionPropEN objvTabFunctionPropEN)
{
 vTabFunctionPropDA.CheckProperty4Condition(objvTabFunctionPropEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabFunctionPropBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFunctionPropBL没有刷新缓存机制(clsTabFunctionPropBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMethodModifierBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMethodModifierBL没有刷新缓存机制(clsMethodModifierBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTypeBL没有刷新缓存机制(clsFunctionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunction4GeneCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4GeneCodeBL没有刷新缓存机制(clsFunction4GeneCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunction4CodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4CodeBL没有刷新缓存机制(clsFunction4CodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncGCTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncGCTypeBL没有刷新缓存机制(clsFuncGCTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTemplateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTemplateBL没有刷新缓存机制(clsFunctionTemplateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureTypeBL没有刷新缓存机制(clsPrjFeatureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupBL没有刷新缓存机制(clsFunctionGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvTabFunctionPropObjLstCache == null)
//{
//arrvTabFunctionPropObjLstCache = vTabFunctionPropDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFunctionPropEN GetObjBymIdCache(long lngmId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvTabFunctionPropEN._CurrTabName, strPrjId);
List<clsvTabFunctionPropEN> arrvTabFunctionPropObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFunctionPropEN> arrvTabFunctionPropObjLst_Sel =
arrvTabFunctionPropObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvTabFunctionPropObjLst_Sel.Count() == 0)
{
   clsvTabFunctionPropEN obj = clsvTabFunctionPropBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvTabFunctionPropObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFunctionPropEN> GetAllvTabFunctionPropObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvTabFunctionPropEN> arrvTabFunctionPropObjLstCache = GetObjLstCache(strPrjId); 
return arrvTabFunctionPropObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFunctionPropEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvTabFunctionPropEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvTabFunctionPropEN> arrvTabFunctionPropObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvTabFunctionPropObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvTabFunctionPropEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvTabFunctionPropEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvTabFunctionPropEN._RefreshTimeLst.Count == 0) return "";
return clsvTabFunctionPropEN._RefreshTimeLst[clsvTabFunctionPropEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convTabFunctionProp.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTabFunctionProp._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTabFunctionProp._AttributeName));
throw new Exception(strMsg);
}
var objvTabFunctionProp = clsvTabFunctionPropBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvTabFunctionProp == null) return "";
return objvTabFunctionProp[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvTabFunctionPropDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvTabFunctionPropDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTabFunctionPropDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvTabFunctionPropDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTabFunctionPropCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTabFunctionPropEN objvTabFunctionPropCond)
{
 string strPrjId = objvTabFunctionPropCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvTabFunctionPropBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvTabFunctionPropEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFunctionPropEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFunctionProp._AttributeName)
{
if (objvTabFunctionPropCond.IsUpdated(strFldName) == false) continue;
if (objvTabFunctionPropCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFunctionPropCond[strFldName].ToString());
}
else
{
if (objvTabFunctionPropCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFunctionPropCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFunctionPropCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFunctionPropCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFunctionPropCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFunctionPropCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvTabFunctionPropDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vTabFunctionPropDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vTabFunctionPropDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}