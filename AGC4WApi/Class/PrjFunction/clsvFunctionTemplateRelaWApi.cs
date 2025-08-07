
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateRelaWApi
 表名:vFunctionTemplateRela(00050317)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:59
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
public static class  clsvFunctionTemplateRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetmId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, long lngmId, string strComparisonOp="")
	{
objvFunctionTemplateRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.mId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.mId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.mId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateId">函数模板Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFunctionTemplateId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateId, convFunctionTemplateRela.FunctionTemplateId);
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, convFunctionTemplateRela.FunctionTemplateId);
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, convFunctionTemplateRela.FunctionTemplateId);
objvFunctionTemplateRelaEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FunctionTemplateId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FunctionTemplateId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FunctionTemplateId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateName">函数模板名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFunctionTemplateName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFunctionTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateName, convFunctionTemplateRela.FunctionTemplateName);
clsCheckSql.CheckFieldLen(strFunctionTemplateName, 50, convFunctionTemplateRela.FunctionTemplateName);
objvFunctionTemplateRelaEN.FunctionTemplateName = strFunctionTemplateName; //函数模板名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FunctionTemplateName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FunctionTemplateName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FunctionTemplateName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetCreateUserId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convFunctionTemplateRela.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convFunctionTemplateRela.CreateUserId);
objvFunctionTemplateRelaEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.CreateUserId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.CreateUserId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.CreateUserId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetCodeTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convFunctionTemplateRela.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convFunctionTemplateRela.CodeTypeId);
objvFunctionTemplateRelaEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.CodeTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.CodeTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetCodeTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convFunctionTemplateRela.CodeTypeName);
objvFunctionTemplateRelaEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.CodeTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.CodeTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeENName">代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetCodeTypeENName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convFunctionTemplateRela.CodeTypeENName);
objvFunctionTemplateRelaEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.CodeTypeENName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.CodeTypeENName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeENName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetRegionTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convFunctionTemplateRela.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convFunctionTemplateRela.RegionTypeId);
objvFunctionTemplateRelaEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.RegionTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.RegionTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.RegionTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetRegionTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convFunctionTemplateRela.RegionTypeName);
objvFunctionTemplateRelaEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.RegionTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.RegionTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.RegionTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncId4GC(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, convFunctionTemplateRela.FuncId4GC);
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunctionTemplateRela.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunctionTemplateRela.FuncId4GC);
objvFunctionTemplateRelaEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncId4GC) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncId4GC, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncId4GC] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunctionTemplateRela.FuncName);
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunctionTemplateRela.FuncName);
objvFunctionTemplateRelaEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncId4Code(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFunctionTemplateRela.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFunctionTemplateRela.FuncId4Code);
objvFunctionTemplateRelaEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncId4Code) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncId4Code, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncId4Code] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4Code">函数名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncName4Code(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFunctionTemplateRela.FuncName4Code);
objvFunctionTemplateRelaEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncName4Code) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncName4Code, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncName4Code] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCHName4Code">函数中文名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncCHName4Code(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncCHName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, convFunctionTemplateRela.FuncCHName4Code);
objvFunctionTemplateRelaEN.FuncCHName4Code = strFuncCHName4Code; //函数中文名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncCHName4Code) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncCHName4Code, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncCHName4Code] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetProgLangTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunctionTemplateRela.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunctionTemplateRela.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunctionTemplateRela.ProgLangTypeId);
objvFunctionTemplateRelaEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.ProgLangTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetProgLangTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convFunctionTemplateRela.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFunctionTemplateRela.ProgLangTypeName);
objvFunctionTemplateRelaEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.ProgLangTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.ProgLangTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.ProgLangTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetSqlDsTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convFunctionTemplateRela.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convFunctionTemplateRela.SqlDsTypeId);
objvFunctionTemplateRelaEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.SqlDsTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.SqlDsTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.SqlDsTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetSqlDsTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convFunctionTemplateRela.SqlDsTypeName);
objvFunctionTemplateRelaEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.SqlDsTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.SqlDsTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.SqlDsTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetReturnTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convFunctionTemplateRela.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convFunctionTemplateRela.ReturnTypeId);
objvFunctionTemplateRelaEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.ReturnTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.ReturnTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.ReturnTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncTypeId(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convFunctionTemplateRela.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convFunctionTemplateRela.FuncTypeId);
objvFunctionTemplateRelaEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncTypeId) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeName">函数类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFuncTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convFunctionTemplateRela.FuncTypeName);
objvFunctionTemplateRelaEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FuncTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FuncTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FuncTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetIsTemplate(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convFunctionTemplateRela.IsTemplate);
objvFunctionTemplateRelaEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.IsTemplate) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.IsTemplate, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.IsTemplate] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetFunctionSignature(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFunctionTemplateRela.FunctionSignature);
objvFunctionTemplateRelaEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.FunctionSignature) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.FunctionSignature, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.FunctionSignature] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeName">返回类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetReturnTypeName(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strReturnTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeName, 100, convFunctionTemplateRela.ReturnTypeName);
objvFunctionTemplateRelaEN.ReturnTypeName = strReturnTypeName; //返回类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.ReturnTypeName) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.ReturnTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.ReturnTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGeneCode">是否生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetIsGeneCode(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objvFunctionTemplateRelaEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.IsGeneCode) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.IsGeneCode, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.IsGeneCode] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetOrderNum(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFunctionTemplateRela.OrderNum);
objvFunctionTemplateRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.OrderNum) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.OrderNum, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.OrderNum] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetUpdDate(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionTemplateRela.UpdDate);
objvFunctionTemplateRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.UpdDate) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.UpdDate, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.UpdDate] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetUpdUser(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionTemplateRela.UpdUser);
objvFunctionTemplateRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.UpdUser) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.UpdUser, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.UpdUser] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetMemo(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionTemplateRela.Memo);
objvFunctionTemplateRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.Memo) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.Memo, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.Memo] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrder4FuncNum">Order4FuncNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRelaEN SetOrder4FuncNum(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN, int intOrder4FuncNum, string strComparisonOp="")
	{
objvFunctionTemplateRelaEN.Order4FuncNum = intOrder4FuncNum; //Order4FuncNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela.Order4FuncNum) == false)
{
objvFunctionTemplateRelaEN.dicFldComparisonOp.Add(convFunctionTemplateRela.Order4FuncNum, strComparisonOp);
}
else
{
objvFunctionTemplateRelaEN.dicFldComparisonOp[convFunctionTemplateRela.Order4FuncNum] = strComparisonOp;
}
}
return objvFunctionTemplateRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionTemplateRelaEN objvFunctionTemplateRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.mId) == true)
{
string strComparisonOpmId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionTemplateRela.mId, objvFunctionTemplateRelaCond.mId, strComparisonOpmId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FunctionTemplateId, objvFunctionTemplateRelaCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FunctionTemplateName) == true)
{
string strComparisonOpFunctionTemplateName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FunctionTemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FunctionTemplateName, objvFunctionTemplateRelaCond.FunctionTemplateName, strComparisonOpFunctionTemplateName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.CreateUserId, objvFunctionTemplateRelaCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.CodeTypeId, objvFunctionTemplateRelaCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.CodeTypeName, objvFunctionTemplateRelaCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.CodeTypeENName, objvFunctionTemplateRelaCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.RegionTypeId, objvFunctionTemplateRelaCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.RegionTypeName, objvFunctionTemplateRelaCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncId4GC, objvFunctionTemplateRelaCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncName) == true)
{
string strComparisonOpFuncName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncName, objvFunctionTemplateRelaCond.FuncName, strComparisonOpFuncName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncId4Code, objvFunctionTemplateRelaCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncName4Code, objvFunctionTemplateRelaCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncCHName4Code) == true)
{
string strComparisonOpFuncCHName4Code = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncCHName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncCHName4Code, objvFunctionTemplateRelaCond.FuncCHName4Code, strComparisonOpFuncCHName4Code);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.ProgLangTypeId, objvFunctionTemplateRelaCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.ProgLangTypeName, objvFunctionTemplateRelaCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.SqlDsTypeId, objvFunctionTemplateRelaCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.SqlDsTypeName, objvFunctionTemplateRelaCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.ReturnTypeId, objvFunctionTemplateRelaCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncTypeId, objvFunctionTemplateRelaCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FuncTypeName, objvFunctionTemplateRelaCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.IsTemplate) == true)
{
if (objvFunctionTemplateRelaCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunctionTemplateRela.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunctionTemplateRela.IsTemplate);
}
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.FunctionSignature, objvFunctionTemplateRelaCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.ReturnTypeName) == true)
{
string strComparisonOpReturnTypeName = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.ReturnTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.ReturnTypeName, objvFunctionTemplateRelaCond.ReturnTypeName, strComparisonOpReturnTypeName);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.IsGeneCode) == true)
{
if (objvFunctionTemplateRelaCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunctionTemplateRela.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunctionTemplateRela.IsGeneCode);
}
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionTemplateRela.OrderNum, objvFunctionTemplateRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.UpdDate, objvFunctionTemplateRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.UpdUser, objvFunctionTemplateRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.Memo) == true)
{
string strComparisonOpMemo = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela.Memo, objvFunctionTemplateRelaCond.Memo, strComparisonOpMemo);
}
if (objvFunctionTemplateRelaCond.IsUpdated(convFunctionTemplateRela.Order4FuncNum) == true)
{
string strComparisonOpOrder4FuncNum = objvFunctionTemplateRelaCond.dicFldComparisonOp[convFunctionTemplateRela.Order4FuncNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionTemplateRela.Order4FuncNum, objvFunctionTemplateRelaCond.Order4FuncNum, strComparisonOpOrder4FuncNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数与模板关系(vFunctionTemplateRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionTemplateRelaWApi
{
private static readonly string mstrApiControllerName = "vFunctionTemplateRelaApi";

 public clsvFunctionTemplateRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionTemplateRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN;
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
objvFunctionTemplateRelaEN = JsonConvert.DeserializeObject<clsvFunctionTemplateRelaEN>(strJson);
return objvFunctionTemplateRelaEN;
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
public static clsvFunctionTemplateRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunctionTemplateRelaEN objvFunctionTemplateRelaEN;
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
objvFunctionTemplateRelaEN = JsonConvert.DeserializeObject<clsvFunctionTemplateRelaEN>(strJson);
return objvFunctionTemplateRelaEN;
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
public static List<clsvFunctionTemplateRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFunctionTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRelaEN>>(strJson);
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
public static List<clsvFunctionTemplateRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFunctionTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRelaEN>>(strJson);
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
public static List<clsvFunctionTemplateRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunctionTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRelaEN>>(strJson);
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
public static List<clsvFunctionTemplateRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunctionTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRelaEN>>(strJson);
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
public static List<clsvFunctionTemplateRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunctionTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRelaEN>>(strJson);
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
public static List<clsvFunctionTemplateRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunctionTemplateRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRelaEN>>(strJson);
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
 /// <param name = "objvFunctionTemplateRelaENS">源对象</param>
 /// <param name = "objvFunctionTemplateRelaENT">目标对象</param>
 public static void CopyTo(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENS, clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENT)
{
try
{
objvFunctionTemplateRelaENT.mId = objvFunctionTemplateRelaENS.mId; //mId
objvFunctionTemplateRelaENT.FunctionTemplateId = objvFunctionTemplateRelaENS.FunctionTemplateId; //函数模板Id
objvFunctionTemplateRelaENT.FunctionTemplateName = objvFunctionTemplateRelaENS.FunctionTemplateName; //函数模板名
objvFunctionTemplateRelaENT.CreateUserId = objvFunctionTemplateRelaENS.CreateUserId; //建立用户Id
objvFunctionTemplateRelaENT.CodeTypeId = objvFunctionTemplateRelaENS.CodeTypeId; //代码类型Id
objvFunctionTemplateRelaENT.CodeTypeName = objvFunctionTemplateRelaENS.CodeTypeName; //代码类型名
objvFunctionTemplateRelaENT.CodeTypeENName = objvFunctionTemplateRelaENS.CodeTypeENName; //代码类型英文名
objvFunctionTemplateRelaENT.RegionTypeId = objvFunctionTemplateRelaENS.RegionTypeId; //区域类型Id
objvFunctionTemplateRelaENT.RegionTypeName = objvFunctionTemplateRelaENS.RegionTypeName; //区域类型名称
objvFunctionTemplateRelaENT.FuncId4GC = objvFunctionTemplateRelaENS.FuncId4GC; //函数ID
objvFunctionTemplateRelaENT.FuncName = objvFunctionTemplateRelaENS.FuncName; //函数名
objvFunctionTemplateRelaENT.FuncId4Code = objvFunctionTemplateRelaENS.FuncId4Code; //函数Id4Code
objvFunctionTemplateRelaENT.FuncName4Code = objvFunctionTemplateRelaENS.FuncName4Code; //函数名4Code
objvFunctionTemplateRelaENT.FuncCHName4Code = objvFunctionTemplateRelaENS.FuncCHName4Code; //函数中文名4Code
objvFunctionTemplateRelaENT.ProgLangTypeId = objvFunctionTemplateRelaENS.ProgLangTypeId; //编程语言类型Id
objvFunctionTemplateRelaENT.ProgLangTypeName = objvFunctionTemplateRelaENS.ProgLangTypeName; //编程语言类型名
objvFunctionTemplateRelaENT.SqlDsTypeId = objvFunctionTemplateRelaENS.SqlDsTypeId; //数据源类型Id
objvFunctionTemplateRelaENT.SqlDsTypeName = objvFunctionTemplateRelaENS.SqlDsTypeName; //Sql数据源名
objvFunctionTemplateRelaENT.ReturnTypeId = objvFunctionTemplateRelaENS.ReturnTypeId; //返回类型ID
objvFunctionTemplateRelaENT.FuncTypeId = objvFunctionTemplateRelaENS.FuncTypeId; //函数类型Id
objvFunctionTemplateRelaENT.FuncTypeName = objvFunctionTemplateRelaENS.FuncTypeName; //函数类型名
objvFunctionTemplateRelaENT.IsTemplate = objvFunctionTemplateRelaENS.IsTemplate; //是否模板
objvFunctionTemplateRelaENT.FunctionSignature = objvFunctionTemplateRelaENS.FunctionSignature; //函数签名
objvFunctionTemplateRelaENT.ReturnTypeName = objvFunctionTemplateRelaENS.ReturnTypeName; //返回类型名
objvFunctionTemplateRelaENT.IsGeneCode = objvFunctionTemplateRelaENS.IsGeneCode; //是否生成代码
objvFunctionTemplateRelaENT.OrderNum = objvFunctionTemplateRelaENS.OrderNum; //序号
objvFunctionTemplateRelaENT.UpdDate = objvFunctionTemplateRelaENS.UpdDate; //修改日期
objvFunctionTemplateRelaENT.UpdUser = objvFunctionTemplateRelaENS.UpdUser; //修改者
objvFunctionTemplateRelaENT.Memo = objvFunctionTemplateRelaENS.Memo; //说明
objvFunctionTemplateRelaENT.Order4FuncNum = objvFunctionTemplateRelaENS.Order4FuncNum; //Order4FuncNum
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
public static DataTable ToDataTable(List<clsvFunctionTemplateRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunctionTemplateRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunctionTemplateRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunctionTemplateRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunctionTemplateRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunctionTemplateRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunctionTemplateRelaEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvFunctionTemplateRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunctionTemplateRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFunctionTemplateRela.FunctionTemplateId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.FunctionTemplateName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.FuncName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.FuncCHName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.FuncTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFunctionTemplateRela.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.ReturnTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.IsGeneCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFunctionTemplateRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunctionTemplateRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela.Order4FuncNum, Type.GetType("System.Int32"));
foreach (clsvFunctionTemplateRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunctionTemplateRela.mId] = objInFor[convFunctionTemplateRela.mId];
objDR[convFunctionTemplateRela.FunctionTemplateId] = objInFor[convFunctionTemplateRela.FunctionTemplateId];
objDR[convFunctionTemplateRela.FunctionTemplateName] = objInFor[convFunctionTemplateRela.FunctionTemplateName];
objDR[convFunctionTemplateRela.CreateUserId] = objInFor[convFunctionTemplateRela.CreateUserId];
objDR[convFunctionTemplateRela.CodeTypeId] = objInFor[convFunctionTemplateRela.CodeTypeId];
objDR[convFunctionTemplateRela.CodeTypeName] = objInFor[convFunctionTemplateRela.CodeTypeName];
objDR[convFunctionTemplateRela.CodeTypeENName] = objInFor[convFunctionTemplateRela.CodeTypeENName];
objDR[convFunctionTemplateRela.RegionTypeId] = objInFor[convFunctionTemplateRela.RegionTypeId];
objDR[convFunctionTemplateRela.RegionTypeName] = objInFor[convFunctionTemplateRela.RegionTypeName];
objDR[convFunctionTemplateRela.FuncId4GC] = objInFor[convFunctionTemplateRela.FuncId4GC];
objDR[convFunctionTemplateRela.FuncName] = objInFor[convFunctionTemplateRela.FuncName];
objDR[convFunctionTemplateRela.FuncId4Code] = objInFor[convFunctionTemplateRela.FuncId4Code];
objDR[convFunctionTemplateRela.FuncName4Code] = objInFor[convFunctionTemplateRela.FuncName4Code];
objDR[convFunctionTemplateRela.FuncCHName4Code] = objInFor[convFunctionTemplateRela.FuncCHName4Code];
objDR[convFunctionTemplateRela.ProgLangTypeId] = objInFor[convFunctionTemplateRela.ProgLangTypeId];
objDR[convFunctionTemplateRela.ProgLangTypeName] = objInFor[convFunctionTemplateRela.ProgLangTypeName];
objDR[convFunctionTemplateRela.SqlDsTypeId] = objInFor[convFunctionTemplateRela.SqlDsTypeId];
objDR[convFunctionTemplateRela.SqlDsTypeName] = objInFor[convFunctionTemplateRela.SqlDsTypeName];
objDR[convFunctionTemplateRela.ReturnTypeId] = objInFor[convFunctionTemplateRela.ReturnTypeId];
objDR[convFunctionTemplateRela.FuncTypeId] = objInFor[convFunctionTemplateRela.FuncTypeId];
objDR[convFunctionTemplateRela.FuncTypeName] = objInFor[convFunctionTemplateRela.FuncTypeName];
objDR[convFunctionTemplateRela.IsTemplate] = objInFor[convFunctionTemplateRela.IsTemplate];
objDR[convFunctionTemplateRela.FunctionSignature] = objInFor[convFunctionTemplateRela.FunctionSignature];
objDR[convFunctionTemplateRela.ReturnTypeName] = objInFor[convFunctionTemplateRela.ReturnTypeName];
objDR[convFunctionTemplateRela.IsGeneCode] = objInFor[convFunctionTemplateRela.IsGeneCode];
objDR[convFunctionTemplateRela.OrderNum] = objInFor[convFunctionTemplateRela.OrderNum];
objDR[convFunctionTemplateRela.UpdDate] = objInFor[convFunctionTemplateRela.UpdDate];
objDR[convFunctionTemplateRela.UpdUser] = objInFor[convFunctionTemplateRela.UpdUser];
objDR[convFunctionTemplateRela.Memo] = objInFor[convFunctionTemplateRela.Memo];
objDR[convFunctionTemplateRela.Order4FuncNum] = objInFor[convFunctionTemplateRela.Order4FuncNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}