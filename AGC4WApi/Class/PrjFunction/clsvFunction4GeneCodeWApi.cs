
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4GeneCodeWApi
 表名:vFunction4GeneCode(00050315)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:46
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
public static class  clsvFunction4GeneCodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncId4GC(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunction4GeneCode.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunction4GeneCode.FuncId4GC);
objvFunction4GeneCodeEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncId4GC) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncId4GC, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncId4GC] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunction4GeneCode.FuncName);
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunction4GeneCode.FuncName);
objvFunction4GeneCodeEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncId4Code(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFunction4GeneCode.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFunction4GeneCode.FuncId4Code);
objvFunction4GeneCodeEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncId4Code) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncId4Code, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncId4Code] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4Code">函数名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncName4Code(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFunction4GeneCode.FuncName4Code);
objvFunction4GeneCodeEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncName4Code) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncName4Code, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncName4Code] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCHName4Code">函数中文名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncCHName4Code(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncCHName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, convFunction4GeneCode.FuncCHName4Code);
objvFunction4GeneCodeEN.FuncCHName4Code = strFuncCHName4Code; //函数中文名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncCHName4Code) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncCHName4Code, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncCHName4Code] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignatureSim">函数签名_Sim</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFunctionSignatureSim(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFunctionSignatureSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionSignatureSim, 500, convFunction4GeneCode.FunctionSignatureSim);
objvFunction4GeneCodeEN.FunctionSignatureSim = strFunctionSignatureSim; //函数签名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FunctionSignatureSim) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FunctionSignatureSim, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FunctionSignatureSim] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFeatureId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFunction4GeneCode.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFunction4GeneCode.FeatureId);
objvFunction4GeneCodeEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FeatureId) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FeatureId, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FeatureId] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFeatureName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFunction4GeneCode.FeatureName);
objvFunction4GeneCodeEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FeatureName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FeatureName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FeatureName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureDescription">功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFeatureDescription(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFeatureDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convFunction4GeneCode.FeatureDescription);
objvFunction4GeneCodeEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FeatureDescription) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FeatureDescription, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FeatureDescription] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFeatureTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFunction4GeneCode.FeatureTypeName);
objvFunction4GeneCodeEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FeatureTypeName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FeatureTypeName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FeatureTypeName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetProgLangTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunction4GeneCode.ProgLangTypeId);
objvFunction4GeneCodeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.ProgLangTypeId) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetProgLangTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convFunction4GeneCode.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFunction4GeneCode.ProgLangTypeName);
objvFunction4GeneCodeEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.ProgLangTypeName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.ProgLangTypeName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.ProgLangTypeName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetSqlDsTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convFunction4GeneCode.SqlDsTypeId);
objvFunction4GeneCodeEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.SqlDsTypeId) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.SqlDsTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.SqlDsTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetSqlDsTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convFunction4GeneCode.SqlDsTypeName);
objvFunction4GeneCodeEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.SqlDsTypeName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.SqlDsTypeName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.SqlDsTypeName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeId">函数生成代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncGCTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncGCTypeId, convFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, convFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, convFunction4GeneCode.FuncGCTypeId);
objvFunction4GeneCodeEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncGCTypeId) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncGCTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncGCTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeName">函数生成代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncGCTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncGCTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncGCTypeName, 50, convFunction4GeneCode.FuncGCTypeName);
objvFunction4GeneCodeEN.FuncGCTypeName = strFuncGCTypeName; //函数生成代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncGCTypeName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncGCTypeName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncGCTypeName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeENName">函数生成代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncGCTypeENName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncGCTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncGCTypeENName, 50, convFunction4GeneCode.FuncGCTypeENName);
objvFunction4GeneCodeEN.FuncGCTypeENName = strFuncGCTypeENName; //函数生成代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncGCTypeENName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncGCTypeENName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncGCTypeENName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetPrjId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFunction4GeneCode.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFunction4GeneCode.PrjId);
objvFunction4GeneCodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.PrjId) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.PrjId, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.PrjId] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetReturnTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convFunction4GeneCode.ReturnTypeId);
objvFunction4GeneCodeEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.ReturnTypeId) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.ReturnTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.ReturnTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convFunction4GeneCode.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convFunction4GeneCode.FuncTypeId);
objvFunction4GeneCodeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncTypeId) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeName">函数类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convFunction4GeneCode.FuncTypeName);
objvFunction4GeneCodeEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncTypeName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncTypeName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncTypeName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetIsTemplate(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convFunction4GeneCode.IsTemplate);
objvFunction4GeneCodeEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.IsTemplate) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.IsTemplate, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.IsTemplate] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFunctionSignature(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFunction4GeneCode.FunctionSignature);
objvFunction4GeneCodeEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FunctionSignature) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FunctionSignature, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FunctionSignature] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCode">函数代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncCode(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncCode, string strComparisonOp="")
	{
objvFunction4GeneCodeEN.FuncCode = strFuncCode; //函数代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncCode) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncCode, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncCode] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetUserId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convFunction4GeneCode.UserId);
objvFunction4GeneCodeEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.UserId) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.UserId, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.UserId] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetOrderNum(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFunction4GeneCode.OrderNum);
objvFunction4GeneCodeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.OrderNum) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.OrderNum, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.OrderNum] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetInUse(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, bool bolInUse, string strComparisonOp="")
	{
objvFunction4GeneCodeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.InUse) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.InUse, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.InUse] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeText">代码文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetCodeText(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strCodeText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeText, 8000, convFunction4GeneCode.CodeText);
objvFunction4GeneCodeEN.CodeText = strCodeText; //代码文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.CodeText) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.CodeText, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.CodeText] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetUpdDate(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunction4GeneCode.UpdDate);
objvFunction4GeneCodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.UpdDate) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.UpdDate, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.UpdDate] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetUpdUser(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunction4GeneCode.UpdUser);
objvFunction4GeneCodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.UpdUser) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.UpdUser, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.UpdUser] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetMemo(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunction4GeneCode.Memo);
objvFunction4GeneCodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.Memo) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.Memo, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.Memo] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParsedWords">分析的词</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetParsedWords(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strParsedWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParsedWords, 500, convFunction4GeneCode.ParsedWords);
objvFunction4GeneCodeEN.ParsedWords = strParsedWords; //分析的词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.ParsedWords) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.ParsedWords, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.ParsedWords] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParsedWordsExcluded">剔除后的词组</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetParsedWordsExcluded(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strParsedWordsExcluded, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParsedWordsExcluded, 500, convFunction4GeneCode.ParsedWordsExcluded);
objvFunction4GeneCodeEN.ParsedWordsExcluded = strParsedWordsExcluded; //剔除后的词组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.ParsedWordsExcluded) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.ParsedWordsExcluded, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.ParsedWordsExcluded] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strWordVector">词向量</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetWordVector(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strWordVector, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordVector, 500, convFunction4GeneCode.WordVector);
objvFunction4GeneCodeEN.WordVector = strWordVector; //词向量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.WordVector) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.WordVector, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.WordVector] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsFuncTemplate">是否函数模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetIsFuncTemplate(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, bool bolIsFuncTemplate, string strComparisonOp="")
	{
objvFunction4GeneCodeEN.IsFuncTemplate = bolIsFuncTemplate; //是否函数模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.IsFuncTemplate) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.IsFuncTemplate, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.IsFuncTemplate] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeName">返回类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetReturnTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strReturnTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeName, 100, convFunction4GeneCode.ReturnTypeName);
objvFunction4GeneCodeEN.ReturnTypeName = strReturnTypeName; //返回类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.ReturnTypeName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.ReturnTypeName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.ReturnTypeName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intTemplateNum">TemplateNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetTemplateNum(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, int intTemplateNum, string strComparisonOp="")
	{
objvFunction4GeneCodeEN.TemplateNum = intTemplateNum; //TemplateNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.TemplateNum) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.TemplateNum, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.TemplateNum] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrder4FeatureNum">Order4FeatureNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetOrder4FeatureNum(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, int intOrder4FeatureNum, string strComparisonOp="")
	{
objvFunction4GeneCodeEN.Order4FeatureNum = intOrder4FeatureNum; //Order4FeatureNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.Order4FeatureNum) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.Order4FeatureNum, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.Order4FeatureNum] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCodeTypeENName">FuncCodeTypeENName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncCodeTypeENName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCodeTypeENName, 50, convFunction4GeneCode.FuncCodeTypeENName);
objvFunction4GeneCodeEN.FuncCodeTypeENName = strFuncCodeTypeENName; //FuncCodeTypeENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncCodeTypeENName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncCodeTypeENName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncCodeTypeENName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCodeTypeId">函数代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncCodeTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCodeTypeId, 4, convFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncCodeTypeId, 4, convFunction4GeneCode.FuncCodeTypeId);
objvFunction4GeneCodeEN.FuncCodeTypeId = strFuncCodeTypeId; //函数代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncCodeTypeId) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncCodeTypeId, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncCodeTypeId] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCodeTypeName">FuncCodeTypeName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncCodeTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCodeTypeName, 50, convFunction4GeneCode.FuncCodeTypeName);
objvFunction4GeneCodeEN.FuncCodeTypeName = strFuncCodeTypeName; //FuncCodeTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.FuncCodeTypeName) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.FuncCodeTypeName, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.FuncCodeTypeName] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId4FuncCodeType">ProgLangTypeId4FuncCodeType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetProgLangTypeId4FuncCodeType(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strProgLangTypeId4FuncCodeType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId4FuncCodeType, 2, convFunction4GeneCode.ProgLangTypeId4FuncCodeType);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId4FuncCodeType, 2, convFunction4GeneCode.ProgLangTypeId4FuncCodeType);
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = strProgLangTypeId4FuncCodeType; //ProgLangTypeId4FuncCodeType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(convFunction4GeneCode.ProgLangTypeId4FuncCodeType) == false)
{
objvFunction4GeneCodeEN.dicFldComparisonOp.Add(convFunction4GeneCode.ProgLangTypeId4FuncCodeType, strComparisonOp);
}
else
{
objvFunction4GeneCodeEN.dicFldComparisonOp[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] = strComparisonOp;
}
}
return objvFunction4GeneCodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunction4GeneCodeEN objvFunction4GeneCodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncId4GC, objvFunction4GeneCodeCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncName) == true)
{
string strComparisonOpFuncName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncName, objvFunction4GeneCodeCond.FuncName, strComparisonOpFuncName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncId4Code, objvFunction4GeneCodeCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncName4Code, objvFunction4GeneCodeCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncCHName4Code) == true)
{
string strComparisonOpFuncCHName4Code = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncCHName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncCHName4Code, objvFunction4GeneCodeCond.FuncCHName4Code, strComparisonOpFuncCHName4Code);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FunctionSignatureSim) == true)
{
string strComparisonOpFunctionSignatureSim = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FunctionSignatureSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FunctionSignatureSim, objvFunction4GeneCodeCond.FunctionSignatureSim, strComparisonOpFunctionSignatureSim);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FeatureId, objvFunction4GeneCodeCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FeatureName, objvFunction4GeneCodeCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FeatureDescription, objvFunction4GeneCodeCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FeatureTypeName, objvFunction4GeneCodeCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.ProgLangTypeId, objvFunction4GeneCodeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.ProgLangTypeName, objvFunction4GeneCodeCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.SqlDsTypeId, objvFunction4GeneCodeCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.SqlDsTypeName, objvFunction4GeneCodeCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncGCTypeId, objvFunction4GeneCodeCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncGCTypeName) == true)
{
string strComparisonOpFuncGCTypeName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncGCTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncGCTypeName, objvFunction4GeneCodeCond.FuncGCTypeName, strComparisonOpFuncGCTypeName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncGCTypeENName) == true)
{
string strComparisonOpFuncGCTypeENName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncGCTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncGCTypeENName, objvFunction4GeneCodeCond.FuncGCTypeENName, strComparisonOpFuncGCTypeENName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.PrjId) == true)
{
string strComparisonOpPrjId = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.PrjId, objvFunction4GeneCodeCond.PrjId, strComparisonOpPrjId);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.ReturnTypeId, objvFunction4GeneCodeCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncTypeId, objvFunction4GeneCodeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncTypeName, objvFunction4GeneCodeCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.IsTemplate) == true)
{
if (objvFunction4GeneCodeCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunction4GeneCode.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunction4GeneCode.IsTemplate);
}
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FunctionSignature, objvFunction4GeneCodeCond.FunctionSignature, strComparisonOpFunctionSignature);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.UserId) == true)
{
string strComparisonOpUserId = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.UserId, objvFunction4GeneCodeCond.UserId, strComparisonOpUserId);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4GeneCode.OrderNum, objvFunction4GeneCodeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.InUse) == true)
{
if (objvFunction4GeneCodeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunction4GeneCode.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunction4GeneCode.InUse);
}
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.CodeText) == true)
{
string strComparisonOpCodeText = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.CodeText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.CodeText, objvFunction4GeneCodeCond.CodeText, strComparisonOpCodeText);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.UpdDate, objvFunction4GeneCodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.UpdUser, objvFunction4GeneCodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.Memo) == true)
{
string strComparisonOpMemo = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.Memo, objvFunction4GeneCodeCond.Memo, strComparisonOpMemo);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.ParsedWords) == true)
{
string strComparisonOpParsedWords = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.ParsedWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.ParsedWords, objvFunction4GeneCodeCond.ParsedWords, strComparisonOpParsedWords);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.ParsedWordsExcluded) == true)
{
string strComparisonOpParsedWordsExcluded = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.ParsedWordsExcluded];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.ParsedWordsExcluded, objvFunction4GeneCodeCond.ParsedWordsExcluded, strComparisonOpParsedWordsExcluded);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.WordVector) == true)
{
string strComparisonOpWordVector = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.WordVector];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.WordVector, objvFunction4GeneCodeCond.WordVector, strComparisonOpWordVector);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.IsFuncTemplate) == true)
{
if (objvFunction4GeneCodeCond.IsFuncTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunction4GeneCode.IsFuncTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunction4GeneCode.IsFuncTemplate);
}
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.ReturnTypeName) == true)
{
string strComparisonOpReturnTypeName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.ReturnTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.ReturnTypeName, objvFunction4GeneCodeCond.ReturnTypeName, strComparisonOpReturnTypeName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.TemplateNum) == true)
{
string strComparisonOpTemplateNum = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.TemplateNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4GeneCode.TemplateNum, objvFunction4GeneCodeCond.TemplateNum, strComparisonOpTemplateNum);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.Order4FeatureNum) == true)
{
string strComparisonOpOrder4FeatureNum = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.Order4FeatureNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4GeneCode.Order4FeatureNum, objvFunction4GeneCodeCond.Order4FeatureNum, strComparisonOpOrder4FeatureNum);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncCodeTypeENName) == true)
{
string strComparisonOpFuncCodeTypeENName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncCodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncCodeTypeENName, objvFunction4GeneCodeCond.FuncCodeTypeENName, strComparisonOpFuncCodeTypeENName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncCodeTypeId) == true)
{
string strComparisonOpFuncCodeTypeId = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncCodeTypeId, objvFunction4GeneCodeCond.FuncCodeTypeId, strComparisonOpFuncCodeTypeId);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.FuncCodeTypeName) == true)
{
string strComparisonOpFuncCodeTypeName = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.FuncCodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.FuncCodeTypeName, objvFunction4GeneCodeCond.FuncCodeTypeName, strComparisonOpFuncCodeTypeName);
}
if (objvFunction4GeneCodeCond.IsUpdated(convFunction4GeneCode.ProgLangTypeId4FuncCodeType) == true)
{
string strComparisonOpProgLangTypeId4FuncCodeType = objvFunction4GeneCodeCond.dicFldComparisonOp[convFunction4GeneCode.ProgLangTypeId4FuncCodeType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4GeneCode.ProgLangTypeId4FuncCodeType, objvFunction4GeneCodeCond.ProgLangTypeId4FuncCodeType, strComparisonOpProgLangTypeId4FuncCodeType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数4GeneCode(vFunction4GeneCode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunction4GeneCodeWApi
{
private static readonly string mstrApiControllerName = "vFunction4GeneCodeApi";

 public clsvFunction4GeneCodeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4GeneCodeEN GetObjByFuncId4GC(string strFuncId4GC)
{
if (strFuncId4GC == "") return null;
string strAction = "GetObjByFuncId4GC";
clsvFunction4GeneCodeEN objvFunction4GeneCodeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId4GC"] = strFuncId4GC,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFunction4GeneCodeEN = JsonConvert.DeserializeObject<clsvFunction4GeneCodeEN>(strJson);
return objvFunction4GeneCodeEN;
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
public static clsvFunction4GeneCodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunction4GeneCodeEN objvFunction4GeneCodeEN;
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
objvFunction4GeneCodeEN = JsonConvert.DeserializeObject<clsvFunction4GeneCodeEN>(strJson);
return objvFunction4GeneCodeEN;
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
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunction4GeneCodeEN GetObjByFuncId4GCCache(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunction4GeneCodeEN._CurrTabName);
List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel =
from objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLstCache
where objvFunction4GeneCodeEN.FuncId4GC == strFuncId4GC 
select objvFunction4GeneCodeEN;
if (arrvFunction4GeneCodeObjLst_Sel.Count() == 0)
{
   clsvFunction4GeneCodeEN obj = clsvFunction4GeneCodeWApi.GetObjByFuncId4GC(strFuncId4GC);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFunction4GeneCodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetObjLst(string strWhereCond)
{
 List<clsvFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCodeEN>>(strJson);
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
 /// <param name = "arrFuncId4GC">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetObjLstByFuncId4GCLst(List<string> arrFuncId4GC)
{
 List<clsvFunction4GeneCodeEN> arrObjLst; 
string strAction = "GetObjLstByFuncId4GCLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncId4GC);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCodeEN>>(strJson);
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
 /// <param name = "arrFuncId4GC">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFunction4GeneCodeEN> GetObjLstByFuncId4GCLstCache(List<string> arrFuncId4GC)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunction4GeneCodeEN._CurrTabName);
List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel =
from objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLstCache
where arrFuncId4GC.Contains(objvFunction4GeneCodeEN.FuncId4GC)
select objvFunction4GeneCodeEN;
return arrvFunction4GeneCodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCodeEN>>(strJson);
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
public static List<clsvFunction4GeneCodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCodeEN>>(strJson);
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
public static List<clsvFunction4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCodeEN>>(strJson);
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
public static List<clsvFunction4GeneCodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4GeneCodeEN>>(strJson);
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
public static bool IsExist(string strFuncId4GC)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId4GC"] = strFuncId4GC
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
 /// <param name = "objvFunction4GeneCodeENS">源对象</param>
 /// <param name = "objvFunction4GeneCodeENT">目标对象</param>
 public static void CopyTo(clsvFunction4GeneCodeEN objvFunction4GeneCodeENS, clsvFunction4GeneCodeEN objvFunction4GeneCodeENT)
{
try
{
objvFunction4GeneCodeENT.FuncId4GC = objvFunction4GeneCodeENS.FuncId4GC; //函数ID
objvFunction4GeneCodeENT.FuncName = objvFunction4GeneCodeENS.FuncName; //函数名
objvFunction4GeneCodeENT.FuncId4Code = objvFunction4GeneCodeENS.FuncId4Code; //函数Id4Code
objvFunction4GeneCodeENT.FuncName4Code = objvFunction4GeneCodeENS.FuncName4Code; //函数名4Code
objvFunction4GeneCodeENT.FuncCHName4Code = objvFunction4GeneCodeENS.FuncCHName4Code; //函数中文名4Code
objvFunction4GeneCodeENT.FunctionSignatureSim = objvFunction4GeneCodeENS.FunctionSignatureSim; //函数签名_Sim
objvFunction4GeneCodeENT.FeatureId = objvFunction4GeneCodeENS.FeatureId; //功能Id
objvFunction4GeneCodeENT.FeatureName = objvFunction4GeneCodeENS.FeatureName; //功能名称
objvFunction4GeneCodeENT.FeatureDescription = objvFunction4GeneCodeENS.FeatureDescription; //功能说明
objvFunction4GeneCodeENT.FeatureTypeName = objvFunction4GeneCodeENS.FeatureTypeName; //功能类型名称
objvFunction4GeneCodeENT.ProgLangTypeId = objvFunction4GeneCodeENS.ProgLangTypeId; //编程语言类型Id
objvFunction4GeneCodeENT.ProgLangTypeName = objvFunction4GeneCodeENS.ProgLangTypeName; //编程语言类型名
objvFunction4GeneCodeENT.SqlDsTypeId = objvFunction4GeneCodeENS.SqlDsTypeId; //数据源类型Id
objvFunction4GeneCodeENT.SqlDsTypeName = objvFunction4GeneCodeENS.SqlDsTypeName; //Sql数据源名
objvFunction4GeneCodeENT.FuncGCTypeId = objvFunction4GeneCodeENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4GeneCodeENT.FuncGCTypeName = objvFunction4GeneCodeENS.FuncGCTypeName; //函数生成代码类型名
objvFunction4GeneCodeENT.FuncGCTypeENName = objvFunction4GeneCodeENS.FuncGCTypeENName; //函数生成代码类型英文名
objvFunction4GeneCodeENT.PrjId = objvFunction4GeneCodeENS.PrjId; //工程Id
objvFunction4GeneCodeENT.ReturnTypeId = objvFunction4GeneCodeENS.ReturnTypeId; //返回类型ID
objvFunction4GeneCodeENT.FuncTypeId = objvFunction4GeneCodeENS.FuncTypeId; //函数类型Id
objvFunction4GeneCodeENT.FuncTypeName = objvFunction4GeneCodeENS.FuncTypeName; //函数类型名
objvFunction4GeneCodeENT.IsTemplate = objvFunction4GeneCodeENS.IsTemplate; //是否模板
objvFunction4GeneCodeENT.FunctionSignature = objvFunction4GeneCodeENS.FunctionSignature; //函数签名
objvFunction4GeneCodeENT.FuncCode = objvFunction4GeneCodeENS.FuncCode; //函数代码
objvFunction4GeneCodeENT.UserId = objvFunction4GeneCodeENS.UserId; //用户Id
objvFunction4GeneCodeENT.OrderNum = objvFunction4GeneCodeENS.OrderNum; //序号
objvFunction4GeneCodeENT.InUse = objvFunction4GeneCodeENS.InUse; //是否在用
objvFunction4GeneCodeENT.CodeText = objvFunction4GeneCodeENS.CodeText; //代码文本
objvFunction4GeneCodeENT.UpdDate = objvFunction4GeneCodeENS.UpdDate; //修改日期
objvFunction4GeneCodeENT.UpdUser = objvFunction4GeneCodeENS.UpdUser; //修改者
objvFunction4GeneCodeENT.Memo = objvFunction4GeneCodeENS.Memo; //说明
objvFunction4GeneCodeENT.ParsedWords = objvFunction4GeneCodeENS.ParsedWords; //分析的词
objvFunction4GeneCodeENT.ParsedWordsExcluded = objvFunction4GeneCodeENS.ParsedWordsExcluded; //剔除后的词组
objvFunction4GeneCodeENT.WordVector = objvFunction4GeneCodeENS.WordVector; //词向量
objvFunction4GeneCodeENT.IsFuncTemplate = objvFunction4GeneCodeENS.IsFuncTemplate; //是否函数模板
objvFunction4GeneCodeENT.ReturnTypeName = objvFunction4GeneCodeENS.ReturnTypeName; //返回类型名
objvFunction4GeneCodeENT.TemplateNum = objvFunction4GeneCodeENS.TemplateNum; //TemplateNum
objvFunction4GeneCodeENT.Order4FeatureNum = objvFunction4GeneCodeENS.Order4FeatureNum; //Order4FeatureNum
objvFunction4GeneCodeENT.FuncCodeTypeENName = objvFunction4GeneCodeENS.FuncCodeTypeENName; //FuncCodeTypeENName
objvFunction4GeneCodeENT.FuncCodeTypeId = objvFunction4GeneCodeENS.FuncCodeTypeId; //函数代码类型Id
objvFunction4GeneCodeENT.FuncCodeTypeName = objvFunction4GeneCodeENS.FuncCodeTypeName; //FuncCodeTypeName
objvFunction4GeneCodeENT.ProgLangTypeId4FuncCodeType = objvFunction4GeneCodeENS.ProgLangTypeId4FuncCodeType; //ProgLangTypeId4FuncCodeType
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
public static DataTable ToDataTable(List<clsvFunction4GeneCodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunction4GeneCodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunction4GeneCodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunction4GeneCodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunction4GeneCodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunction4GeneCodeEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunction4GeneCodeEN._CurrTabName);
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
public static List<clsvFunction4GeneCodeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFunction4GeneCodeEN._CurrTabName;
List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFunction4GeneCodeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunction4GeneCodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunction4GeneCode.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncCHName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FunctionSignatureSim, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FeatureDescription, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncGCTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncGCTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncGCTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFunction4GeneCode.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncCode, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4GeneCode.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFunction4GeneCode.CodeText, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.ParsedWords, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.ParsedWordsExcluded, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.WordVector, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.IsFuncTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFunction4GeneCode.ReturnTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.TemplateNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4GeneCode.Order4FeatureNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4GeneCode.FuncCodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncCodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.FuncCodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4GeneCode.ProgLangTypeId4FuncCodeType, Type.GetType("System.String"));
foreach (clsvFunction4GeneCodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunction4GeneCode.FuncId4GC] = objInFor[convFunction4GeneCode.FuncId4GC];
objDR[convFunction4GeneCode.FuncName] = objInFor[convFunction4GeneCode.FuncName];
objDR[convFunction4GeneCode.FuncId4Code] = objInFor[convFunction4GeneCode.FuncId4Code];
objDR[convFunction4GeneCode.FuncName4Code] = objInFor[convFunction4GeneCode.FuncName4Code];
objDR[convFunction4GeneCode.FuncCHName4Code] = objInFor[convFunction4GeneCode.FuncCHName4Code];
objDR[convFunction4GeneCode.FunctionSignatureSim] = objInFor[convFunction4GeneCode.FunctionSignatureSim];
objDR[convFunction4GeneCode.FeatureId] = objInFor[convFunction4GeneCode.FeatureId];
objDR[convFunction4GeneCode.FeatureName] = objInFor[convFunction4GeneCode.FeatureName];
objDR[convFunction4GeneCode.FeatureDescription] = objInFor[convFunction4GeneCode.FeatureDescription];
objDR[convFunction4GeneCode.FeatureTypeName] = objInFor[convFunction4GeneCode.FeatureTypeName];
objDR[convFunction4GeneCode.ProgLangTypeId] = objInFor[convFunction4GeneCode.ProgLangTypeId];
objDR[convFunction4GeneCode.ProgLangTypeName] = objInFor[convFunction4GeneCode.ProgLangTypeName];
objDR[convFunction4GeneCode.SqlDsTypeId] = objInFor[convFunction4GeneCode.SqlDsTypeId];
objDR[convFunction4GeneCode.SqlDsTypeName] = objInFor[convFunction4GeneCode.SqlDsTypeName];
objDR[convFunction4GeneCode.FuncGCTypeId] = objInFor[convFunction4GeneCode.FuncGCTypeId];
objDR[convFunction4GeneCode.FuncGCTypeName] = objInFor[convFunction4GeneCode.FuncGCTypeName];
objDR[convFunction4GeneCode.FuncGCTypeENName] = objInFor[convFunction4GeneCode.FuncGCTypeENName];
objDR[convFunction4GeneCode.PrjId] = objInFor[convFunction4GeneCode.PrjId];
objDR[convFunction4GeneCode.ReturnTypeId] = objInFor[convFunction4GeneCode.ReturnTypeId];
objDR[convFunction4GeneCode.FuncTypeId] = objInFor[convFunction4GeneCode.FuncTypeId];
objDR[convFunction4GeneCode.FuncTypeName] = objInFor[convFunction4GeneCode.FuncTypeName];
objDR[convFunction4GeneCode.IsTemplate] = objInFor[convFunction4GeneCode.IsTemplate];
objDR[convFunction4GeneCode.FunctionSignature] = objInFor[convFunction4GeneCode.FunctionSignature];
objDR[convFunction4GeneCode.FuncCode] = objInFor[convFunction4GeneCode.FuncCode];
objDR[convFunction4GeneCode.UserId] = objInFor[convFunction4GeneCode.UserId];
objDR[convFunction4GeneCode.OrderNum] = objInFor[convFunction4GeneCode.OrderNum];
objDR[convFunction4GeneCode.InUse] = objInFor[convFunction4GeneCode.InUse];
objDR[convFunction4GeneCode.CodeText] = objInFor[convFunction4GeneCode.CodeText];
objDR[convFunction4GeneCode.UpdDate] = objInFor[convFunction4GeneCode.UpdDate];
objDR[convFunction4GeneCode.UpdUser] = objInFor[convFunction4GeneCode.UpdUser];
objDR[convFunction4GeneCode.Memo] = objInFor[convFunction4GeneCode.Memo];
objDR[convFunction4GeneCode.ParsedWords] = objInFor[convFunction4GeneCode.ParsedWords];
objDR[convFunction4GeneCode.ParsedWordsExcluded] = objInFor[convFunction4GeneCode.ParsedWordsExcluded];
objDR[convFunction4GeneCode.WordVector] = objInFor[convFunction4GeneCode.WordVector];
objDR[convFunction4GeneCode.IsFuncTemplate] = objInFor[convFunction4GeneCode.IsFuncTemplate];
objDR[convFunction4GeneCode.ReturnTypeName] = objInFor[convFunction4GeneCode.ReturnTypeName];
objDR[convFunction4GeneCode.TemplateNum] = objInFor[convFunction4GeneCode.TemplateNum];
objDR[convFunction4GeneCode.Order4FeatureNum] = objInFor[convFunction4GeneCode.Order4FeatureNum];
objDR[convFunction4GeneCode.FuncCodeTypeENName] = objInFor[convFunction4GeneCode.FuncCodeTypeENName];
objDR[convFunction4GeneCode.FuncCodeTypeId] = objInFor[convFunction4GeneCode.FuncCodeTypeId];
objDR[convFunction4GeneCode.FuncCodeTypeName] = objInFor[convFunction4GeneCode.FuncCodeTypeName];
objDR[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] = objInFor[convFunction4GeneCode.ProgLangTypeId4FuncCodeType];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}