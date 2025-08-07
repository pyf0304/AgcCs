
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunction4GeneCodeWApi
 表名:Function4GeneCode(00050311)
 * 版本:2025.08.02.1(服务器:PYF-MINI)
 日期:2025/08/03 18:47:38
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
public static class  clsFunction4GeneCodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncId4GC(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, conFunction4GeneCode.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, conFunction4GeneCode.FuncId4GC);
objFunction4GeneCodeEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncId4GC) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncId4GC, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncId4GC] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncName(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, conFunction4GeneCode.FuncName);
clsCheckSql.CheckFieldLen(strFuncName, 100, conFunction4GeneCode.FuncName);
objFunction4GeneCodeEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncName) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncName, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncName] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncId4Code(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, conFunction4GeneCode.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, conFunction4GeneCode.FuncId4Code);
objFunction4GeneCodeEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncId4Code) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncId4Code, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncId4Code] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4GC">函数名4生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncName4GC(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncName4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName4GC, 50, conFunction4GeneCode.FuncName4GC);
objFunction4GeneCodeEN.FuncName4GC = strFuncName4GC; //函数名4生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncName4GC) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncName4GC, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncName4GC] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCHName4GC">函数中文名4生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncCHName4GC(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncCHName4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCHName4GC, 50, conFunction4GeneCode.FuncCHName4GC);
objFunction4GeneCodeEN.FuncCHName4GC = strFuncCHName4GC; //函数中文名4生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncCHName4GC) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncCHName4GC, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncCHName4GC] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFeatureId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureId, 4, conFunction4GeneCode.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conFunction4GeneCode.FeatureId);
objFunction4GeneCodeEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FeatureId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FeatureId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FeatureId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetProgLangTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, conFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conFunction4GeneCode.ProgLangTypeId);
objFunction4GeneCodeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.ProgLangTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.ProgLangTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.ProgLangTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCodeTypeId">函数代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncCodeTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
objFunction4GeneCodeEN.FuncCodeTypeId = strFuncCodeTypeId; //函数代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncCodeTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncCodeTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncCodeTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetSqlDsTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, conFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, conFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, conFunction4GeneCode.SqlDsTypeId);
objFunction4GeneCodeEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.SqlDsTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.SqlDsTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.SqlDsTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeId">函数生成代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncGCTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncGCTypeId, conFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, conFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, conFunction4GeneCode.FuncGCTypeId);
objFunction4GeneCodeEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncGCTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncGCTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncGCTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetPrjId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFunction4GeneCode.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFunction4GeneCode.PrjId);
objFunction4GeneCodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.PrjId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.PrjId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.PrjId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetReturnTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
objFunction4GeneCodeEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.ReturnTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.ReturnTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.ReturnTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
objFunction4GeneCodeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetIsTemplate(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsTemplate, string strComparisonOp="")
	{
objFunction4GeneCodeEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.IsTemplate) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.IsTemplate, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.IsTemplate] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFunctionSignature(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, conFunction4GeneCode.FunctionSignature);
objFunction4GeneCodeEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FunctionSignature) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FunctionSignature, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FunctionSignature] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCode">函数代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncCode(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncCode, string strComparisonOp="")
	{
objFunction4GeneCodeEN.FuncCode = strFuncCode; //函数代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncCode) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncCode, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncCode] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetUserId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, conFunction4GeneCode.UserId);
objFunction4GeneCodeEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.UserId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.UserId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.UserId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetOrderNum(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conFunction4GeneCode.OrderNum);
objFunction4GeneCodeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.OrderNum) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.OrderNum, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.OrderNum] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetInUse(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolInUse, string strComparisonOp="")
	{
objFunction4GeneCodeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.InUse) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.InUse, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.InUse] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeIds">主键类型s</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetPrimaryTypeIds(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strPrimaryTypeIds, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeIds, 50, conFunction4GeneCode.PrimaryTypeIds);
objFunction4GeneCodeEN.PrimaryTypeIds = strPrimaryTypeIds; //主键类型s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.PrimaryTypeIds) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.PrimaryTypeIds, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.PrimaryTypeIds] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeText">代码文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetCodeText(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strCodeText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeText, 8000, conFunction4GeneCode.CodeText);
objFunction4GeneCodeEN.CodeText = strCodeText; //代码文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.CodeText) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.CodeText, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.CodeText] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intUsedTimes">使用次数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetUsedTimes(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, int intUsedTimes, string strComparisonOp="")
	{
objFunction4GeneCodeEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.UsedTimes) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.UsedTimes, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.UsedTimes] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetUpdDate(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunction4GeneCode.UpdDate);
objFunction4GeneCodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.UpdDate) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.UpdDate, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.UpdDate] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetUpdUser(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunction4GeneCode.UpdUser);
objFunction4GeneCodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.UpdUser) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.UpdUser, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.UpdUser] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetMemo(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunction4GeneCode.Memo);
objFunction4GeneCodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.Memo) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.Memo, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.Memo] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParsedWords">分析的词</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetParsedWords(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strParsedWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParsedWords, 500, conFunction4GeneCode.ParsedWords);
objFunction4GeneCodeEN.ParsedWords = strParsedWords; //分析的词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.ParsedWords) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.ParsedWords, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.ParsedWords] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParsedWordsExcluded">剔除后的词组</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetParsedWordsExcluded(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strParsedWordsExcluded, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParsedWordsExcluded, 500, conFunction4GeneCode.ParsedWordsExcluded);
objFunction4GeneCodeEN.ParsedWordsExcluded = strParsedWordsExcluded; //剔除后的词组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.ParsedWordsExcluded) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.ParsedWordsExcluded, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.ParsedWordsExcluded] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strWordVector">词向量</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetWordVector(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strWordVector, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWordVector, 500, conFunction4GeneCode.WordVector);
objFunction4GeneCodeEN.WordVector = strWordVector; //词向量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.WordVector) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.WordVector, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.WordVector] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsFuncTemplate">是否函数模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetIsFuncTemplate(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsFuncTemplate, string strComparisonOp="")
	{
objFunction4GeneCodeEN.IsFuncTemplate = bolIsFuncTemplate; //是否函数模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.IsFuncTemplate) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.IsFuncTemplate, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.IsFuncTemplate] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunction4GeneCodeEN objFunction4GeneCodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncId4GC, objFunction4GeneCodeCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncName) == true)
{
string strComparisonOpFuncName = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncName, objFunction4GeneCodeCond.FuncName, strComparisonOpFuncName);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncId4Code, objFunction4GeneCodeCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncName4GC) == true)
{
string strComparisonOpFuncName4GC = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncName4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncName4GC, objFunction4GeneCodeCond.FuncName4GC, strComparisonOpFuncName4GC);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncCHName4GC) == true)
{
string strComparisonOpFuncCHName4GC = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncCHName4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncCHName4GC, objFunction4GeneCodeCond.FuncCHName4GC, strComparisonOpFuncCHName4GC);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FeatureId) == true)
{
string strComparisonOpFeatureId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FeatureId, objFunction4GeneCodeCond.FeatureId, strComparisonOpFeatureId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.ProgLangTypeId, objFunction4GeneCodeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncCodeTypeId) == true)
{
string strComparisonOpFuncCodeTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncCodeTypeId, objFunction4GeneCodeCond.FuncCodeTypeId, strComparisonOpFuncCodeTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.SqlDsTypeId, objFunction4GeneCodeCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncGCTypeId, objFunction4GeneCodeCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.PrjId) == true)
{
string strComparisonOpPrjId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.PrjId, objFunction4GeneCodeCond.PrjId, strComparisonOpPrjId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.ReturnTypeId, objFunction4GeneCodeCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncTypeId, objFunction4GeneCodeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.IsTemplate) == true)
{
if (objFunction4GeneCodeCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4GeneCode.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4GeneCode.IsTemplate);
}
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FunctionSignature, objFunction4GeneCodeCond.FunctionSignature, strComparisonOpFunctionSignature);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.UserId) == true)
{
string strComparisonOpUserId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.UserId, objFunction4GeneCodeCond.UserId, strComparisonOpUserId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.OrderNum) == true)
{
string strComparisonOpOrderNum = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4GeneCode.OrderNum, objFunction4GeneCodeCond.OrderNum, strComparisonOpOrderNum);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.InUse) == true)
{
if (objFunction4GeneCodeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4GeneCode.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4GeneCode.InUse);
}
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.PrimaryTypeIds) == true)
{
string strComparisonOpPrimaryTypeIds = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.PrimaryTypeIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.PrimaryTypeIds, objFunction4GeneCodeCond.PrimaryTypeIds, strComparisonOpPrimaryTypeIds);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.CodeText) == true)
{
string strComparisonOpCodeText = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.CodeText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.CodeText, objFunction4GeneCodeCond.CodeText, strComparisonOpCodeText);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4GeneCode.UsedTimes, objFunction4GeneCodeCond.UsedTimes, strComparisonOpUsedTimes);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.UpdDate, objFunction4GeneCodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.UpdUser, objFunction4GeneCodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.Memo) == true)
{
string strComparisonOpMemo = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.Memo, objFunction4GeneCodeCond.Memo, strComparisonOpMemo);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.ParsedWords) == true)
{
string strComparisonOpParsedWords = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.ParsedWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.ParsedWords, objFunction4GeneCodeCond.ParsedWords, strComparisonOpParsedWords);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.ParsedWordsExcluded) == true)
{
string strComparisonOpParsedWordsExcluded = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.ParsedWordsExcluded];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.ParsedWordsExcluded, objFunction4GeneCodeCond.ParsedWordsExcluded, strComparisonOpParsedWordsExcluded);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.WordVector) == true)
{
string strComparisonOpWordVector = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.WordVector];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.WordVector, objFunction4GeneCodeCond.WordVector, strComparisonOpWordVector);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.IsFuncTemplate) == true)
{
if (objFunction4GeneCodeCond.IsFuncTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4GeneCode.IsFuncTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4GeneCode.IsFuncTemplate);
}
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFunction4GeneCodeEN.sfUpdFldSetStr = objFunction4GeneCodeEN.getsfUpdFldSetStr();
clsFunction4GeneCodeWApi.CheckPropertyNew(objFunction4GeneCodeEN); 
bool bolResult = clsFunction4GeneCodeWApi.UpdateRecord(objFunction4GeneCodeEN);
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
 /// 获取唯一性条件串--Function4GeneCode(函数4GeneCode), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncName_FuncCodeTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunction4GeneCodeEN == null) return "";
if (objFunction4GeneCodeEN.FuncId4GC == null || objFunction4GeneCodeEN.FuncId4GC == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName = '{0}'", objFunction4GeneCodeEN.FuncName);
 sbCondition.AppendFormat(" and FuncCodeTypeId = '{0}'", objFunction4GeneCodeEN.FuncCodeTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncId4GC !=  '{0}'", objFunction4GeneCodeEN.FuncId4GC);
 sbCondition.AppendFormat(" and FuncName = '{0}'", objFunction4GeneCodeEN.FuncName);
 sbCondition.AppendFormat(" and FuncCodeTypeId = '{0}'", objFunction4GeneCodeEN.FuncCodeTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
try
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true || clsFunction4GeneCodeWApi.IsExist(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
     objFunction4GeneCodeEN.FuncId4GC = clsFunction4GeneCodeWApi.GetMaxStrId();
 }
clsFunction4GeneCodeWApi.CheckPropertyNew(objFunction4GeneCodeEN); 
bool bolResult = clsFunction4GeneCodeWApi.AddNewRecord(objFunction4GeneCodeEN);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
try
{
clsFunction4GeneCodeWApi.CheckPropertyNew(objFunction4GeneCodeEN); 
string strFuncId4GC = clsFunction4GeneCodeWApi.AddNewRecordWithMaxId(objFunction4GeneCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return strFuncId4GC;
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
 /// <param name = "objFunction4GeneCodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strWhereCond)
{
try
{
clsFunction4GeneCodeWApi.CheckPropertyNew(objFunction4GeneCodeEN); 
bool bolResult = clsFunction4GeneCodeWApi.UpdateWithCondition(objFunction4GeneCodeEN, strWhereCond);
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
 /// 函数4GeneCode(Function4GeneCode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFunction4GeneCodeWApi
{
private static readonly string mstrApiControllerName = "Function4GeneCodeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFunction4GeneCodeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncId4GC(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数4GeneCode]...","0");
List<clsFunction4GeneCodeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncId4GC";
objDDL.DataTextField="FuncName";
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

 /// <param name = "strFuncCodeTypeId"></param>
public static void BindCbo_FuncId4GC(System.Windows.Forms.ComboBox objComboBox , string strFuncCodeTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFunction4GeneCode.FuncId4GC); 
List<clsFunction4GeneCodeEN> arrObjLst = clsFunction4GeneCodeWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncCodeTypeId == strFuncCodeTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN()
{
FuncId4GC = "0",
FuncName = "选[函数4GeneCode]..."
};
arrObjLstSel.Insert(0, objFunction4GeneCodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFunction4GeneCode.FuncId4GC;
objComboBox.DisplayMember = conFunction4GeneCode.FuncName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
if (!Object.Equals(null, objFunction4GeneCodeEN.FuncId4GC) && GetStrLen(objFunction4GeneCodeEN.FuncId4GC) > 10)
{
 throw new Exception("字段[函数ID]的长度不能超过10!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.FuncName) && GetStrLen(objFunction4GeneCodeEN.FuncName) > 100)
{
 throw new Exception("字段[函数名]的长度不能超过100!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.FuncId4Code) && GetStrLen(objFunction4GeneCodeEN.FuncId4Code) > 8)
{
 throw new Exception("字段[函数Id4Code]的长度不能超过8!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.FuncName4GC) && GetStrLen(objFunction4GeneCodeEN.FuncName4GC) > 50)
{
 throw new Exception("字段[函数名4生成代码]的长度不能超过50!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.FuncCHName4GC) && GetStrLen(objFunction4GeneCodeEN.FuncCHName4GC) > 50)
{
 throw new Exception("字段[函数中文名4生成代码]的长度不能超过50!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.FeatureId) && GetStrLen(objFunction4GeneCodeEN.FeatureId) > 4)
{
 throw new Exception("字段[功能Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.ProgLangTypeId) && GetStrLen(objFunction4GeneCodeEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.FuncCodeTypeId) && GetStrLen(objFunction4GeneCodeEN.FuncCodeTypeId) > 4)
{
 throw new Exception("字段[函数代码类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.SqlDsTypeId) && GetStrLen(objFunction4GeneCodeEN.SqlDsTypeId) > 2)
{
 throw new Exception("字段[数据源类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.FuncGCTypeId) && GetStrLen(objFunction4GeneCodeEN.FuncGCTypeId) > 2)
{
 throw new Exception("字段[函数生成代码类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.PrjId) && GetStrLen(objFunction4GeneCodeEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.ReturnTypeId) && GetStrLen(objFunction4GeneCodeEN.ReturnTypeId) > 2)
{
 throw new Exception("字段[返回类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.FuncTypeId) && GetStrLen(objFunction4GeneCodeEN.FuncTypeId) > 2)
{
 throw new Exception("字段[函数类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.FunctionSignature) && GetStrLen(objFunction4GeneCodeEN.FunctionSignature) > 500)
{
 throw new Exception("字段[函数签名]的长度不能超过500!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.UserId) && GetStrLen(objFunction4GeneCodeEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.PrimaryTypeIds) && GetStrLen(objFunction4GeneCodeEN.PrimaryTypeIds) > 50)
{
 throw new Exception("字段[主键类型s]的长度不能超过50!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.CodeText) && GetStrLen(objFunction4GeneCodeEN.CodeText) > 8000)
{
 throw new Exception("字段[代码文本]的长度不能超过8000!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.UpdDate) && GetStrLen(objFunction4GeneCodeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.UpdUser) && GetStrLen(objFunction4GeneCodeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.Memo) && GetStrLen(objFunction4GeneCodeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.ParsedWords) && GetStrLen(objFunction4GeneCodeEN.ParsedWords) > 500)
{
 throw new Exception("字段[分析的词]的长度不能超过500!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.ParsedWordsExcluded) && GetStrLen(objFunction4GeneCodeEN.ParsedWordsExcluded) > 500)
{
 throw new Exception("字段[剔除后的词组]的长度不能超过500!");
}
if (!Object.Equals(null, objFunction4GeneCodeEN.WordVector) && GetStrLen(objFunction4GeneCodeEN.WordVector) > 500)
{
 throw new Exception("字段[词向量]的长度不能超过500!");
}
 objFunction4GeneCodeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunction4GeneCodeEN GetObjByFuncId4GC(string strFuncId4GC)
{
if (strFuncId4GC == "") return null;
string strAction = "GetObjByFuncId4GC";
clsFunction4GeneCodeEN objFunction4GeneCodeEN;
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
objFunction4GeneCodeEN = JsonConvert.DeserializeObject<clsFunction4GeneCodeEN>(strJson);
return objFunction4GeneCodeEN;
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
public static clsFunction4GeneCodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFunction4GeneCodeEN objFunction4GeneCodeEN;
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
objFunction4GeneCodeEN = JsonConvert.DeserializeObject<clsFunction4GeneCodeEN>(strJson);
return objFunction4GeneCodeEN;
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
//该表没有使用Cache,不需要生成[GetFuncNameByFuncId4GCCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4GeneCodeEN> GetObjLst(string strWhereCond)
{
 List<clsFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4GeneCodeEN>>(strJson);
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
public static List<clsFunction4GeneCodeEN> GetObjLstByFuncId4GCLst(List<string> arrFuncId4GC)
{
 List<clsFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4GeneCodeEN>>(strJson);
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
public static List<clsFunction4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4GeneCodeEN>>(strJson);
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
public static List<clsFunction4GeneCodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4GeneCodeEN>>(strJson);
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
public static List<clsFunction4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4GeneCodeEN>>(strJson);
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
public static List<clsFunction4GeneCodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFunction4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunction4GeneCodeEN>>(strJson);
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
public static int DelRecord(string strFuncId4GC)
{
string strAction = "DelRecord";
try
{
 clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeWApi.GetObjByFuncId4GC(strFuncId4GC);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFuncId4GC.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelFunction4GeneCodes(List<string> arrFuncId4GC)
{
string strAction = "DelFunction4GeneCodes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncId4GC);
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
public static int DelFunction4GeneCodesByCond(string strWhereCond)
{
string strAction = "DelFunction4GeneCodesByCond";
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
public static bool AddNewRecord(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunction4GeneCodeEN>(objFunction4GeneCodeEN);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunction4GeneCodeEN>(objFunction4GeneCodeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strFuncId4GC = (string)jobjReturn0["returnStr"];
return strFuncId4GC;
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
public static bool UpdateRecord(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
if (string.IsNullOrEmpty(objFunction4GeneCodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunction4GeneCodeEN.FuncId4GC, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunction4GeneCodeEN>(objFunction4GeneCodeEN);
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
 /// <param name = "objFunction4GeneCodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFunction4GeneCodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunction4GeneCodeEN.FuncId4GC, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunction4GeneCodeEN.FuncId4GC, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunction4GeneCodeEN>(objFunction4GeneCodeEN);
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
 /// <param name = "objFunction4GeneCodeENS">源对象</param>
 /// <param name = "objFunction4GeneCodeENT">目标对象</param>
 public static void CopyTo(clsFunction4GeneCodeEN objFunction4GeneCodeENS, clsFunction4GeneCodeEN objFunction4GeneCodeENT)
{
try
{
objFunction4GeneCodeENT.FuncId4GC = objFunction4GeneCodeENS.FuncId4GC; //函数ID
objFunction4GeneCodeENT.FuncName = objFunction4GeneCodeENS.FuncName; //函数名
objFunction4GeneCodeENT.FuncId4Code = objFunction4GeneCodeENS.FuncId4Code; //函数Id4Code
objFunction4GeneCodeENT.FuncName4GC = objFunction4GeneCodeENS.FuncName4GC; //函数名4生成代码
objFunction4GeneCodeENT.FuncCHName4GC = objFunction4GeneCodeENS.FuncCHName4GC; //函数中文名4生成代码
objFunction4GeneCodeENT.FeatureId = objFunction4GeneCodeENS.FeatureId; //功能Id
objFunction4GeneCodeENT.ProgLangTypeId = objFunction4GeneCodeENS.ProgLangTypeId; //编程语言类型Id
objFunction4GeneCodeENT.FuncCodeTypeId = objFunction4GeneCodeENS.FuncCodeTypeId; //函数代码类型Id
objFunction4GeneCodeENT.SqlDsTypeId = objFunction4GeneCodeENS.SqlDsTypeId; //数据源类型Id
objFunction4GeneCodeENT.FuncGCTypeId = objFunction4GeneCodeENS.FuncGCTypeId; //函数生成代码类型Id
objFunction4GeneCodeENT.PrjId = objFunction4GeneCodeENS.PrjId; //工程Id
objFunction4GeneCodeENT.ReturnTypeId = objFunction4GeneCodeENS.ReturnTypeId; //返回类型ID
objFunction4GeneCodeENT.FuncTypeId = objFunction4GeneCodeENS.FuncTypeId; //函数类型Id
objFunction4GeneCodeENT.IsTemplate = objFunction4GeneCodeENS.IsTemplate; //是否模板
objFunction4GeneCodeENT.FunctionSignature = objFunction4GeneCodeENS.FunctionSignature; //函数签名
objFunction4GeneCodeENT.FuncCode = objFunction4GeneCodeENS.FuncCode; //函数代码
objFunction4GeneCodeENT.UserId = objFunction4GeneCodeENS.UserId; //用户Id
objFunction4GeneCodeENT.OrderNum = objFunction4GeneCodeENS.OrderNum; //序号
objFunction4GeneCodeENT.InUse = objFunction4GeneCodeENS.InUse; //是否在用
objFunction4GeneCodeENT.PrimaryTypeIds = objFunction4GeneCodeENS.PrimaryTypeIds; //主键类型s
objFunction4GeneCodeENT.CodeText = objFunction4GeneCodeENS.CodeText; //代码文本
objFunction4GeneCodeENT.UsedTimes = objFunction4GeneCodeENS.UsedTimes; //使用次数
objFunction4GeneCodeENT.UpdDate = objFunction4GeneCodeENS.UpdDate; //修改日期
objFunction4GeneCodeENT.UpdUser = objFunction4GeneCodeENS.UpdUser; //修改者
objFunction4GeneCodeENT.Memo = objFunction4GeneCodeENS.Memo; //说明
objFunction4GeneCodeENT.ParsedWords = objFunction4GeneCodeENS.ParsedWords; //分析的词
objFunction4GeneCodeENT.ParsedWordsExcluded = objFunction4GeneCodeENS.ParsedWordsExcluded; //剔除后的词组
objFunction4GeneCodeENT.WordVector = objFunction4GeneCodeENS.WordVector; //词向量
objFunction4GeneCodeENT.IsFuncTemplate = objFunction4GeneCodeENS.IsFuncTemplate; //是否函数模板
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
public static DataTable ToDataTable(List<clsFunction4GeneCodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFunction4GeneCodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFunction4GeneCodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFunction4GeneCodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFunction4GeneCodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFunction4GeneCodeEN._AttributeName)
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
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
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
if (clsFunction4GeneCodeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunction4GeneCodeWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsFunction4GeneCodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFunction4GeneCode.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.FuncName4GC, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.FuncCHName4GC, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.FuncCodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.FuncGCTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunction4GeneCode.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.FuncCode, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conFunction4GeneCode.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunction4GeneCode.PrimaryTypeIds, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.CodeText, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.UsedTimes, Type.GetType("System.Int32"));
objDT.Columns.Add(conFunction4GeneCode.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.ParsedWords, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.ParsedWordsExcluded, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.WordVector, Type.GetType("System.String"));
objDT.Columns.Add(conFunction4GeneCode.IsFuncTemplate, Type.GetType("System.Boolean"));
foreach (clsFunction4GeneCodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFunction4GeneCode.FuncId4GC] = objInFor[conFunction4GeneCode.FuncId4GC];
objDR[conFunction4GeneCode.FuncName] = objInFor[conFunction4GeneCode.FuncName];
objDR[conFunction4GeneCode.FuncId4Code] = objInFor[conFunction4GeneCode.FuncId4Code];
objDR[conFunction4GeneCode.FuncName4GC] = objInFor[conFunction4GeneCode.FuncName4GC];
objDR[conFunction4GeneCode.FuncCHName4GC] = objInFor[conFunction4GeneCode.FuncCHName4GC];
objDR[conFunction4GeneCode.FeatureId] = objInFor[conFunction4GeneCode.FeatureId];
objDR[conFunction4GeneCode.ProgLangTypeId] = objInFor[conFunction4GeneCode.ProgLangTypeId];
objDR[conFunction4GeneCode.FuncCodeTypeId] = objInFor[conFunction4GeneCode.FuncCodeTypeId];
objDR[conFunction4GeneCode.SqlDsTypeId] = objInFor[conFunction4GeneCode.SqlDsTypeId];
objDR[conFunction4GeneCode.FuncGCTypeId] = objInFor[conFunction4GeneCode.FuncGCTypeId];
objDR[conFunction4GeneCode.PrjId] = objInFor[conFunction4GeneCode.PrjId];
objDR[conFunction4GeneCode.ReturnTypeId] = objInFor[conFunction4GeneCode.ReturnTypeId];
objDR[conFunction4GeneCode.FuncTypeId] = objInFor[conFunction4GeneCode.FuncTypeId];
objDR[conFunction4GeneCode.IsTemplate] = objInFor[conFunction4GeneCode.IsTemplate];
objDR[conFunction4GeneCode.FunctionSignature] = objInFor[conFunction4GeneCode.FunctionSignature];
objDR[conFunction4GeneCode.FuncCode] = objInFor[conFunction4GeneCode.FuncCode];
objDR[conFunction4GeneCode.UserId] = objInFor[conFunction4GeneCode.UserId];
objDR[conFunction4GeneCode.OrderNum] = objInFor[conFunction4GeneCode.OrderNum];
objDR[conFunction4GeneCode.InUse] = objInFor[conFunction4GeneCode.InUse];
objDR[conFunction4GeneCode.PrimaryTypeIds] = objInFor[conFunction4GeneCode.PrimaryTypeIds];
objDR[conFunction4GeneCode.CodeText] = objInFor[conFunction4GeneCode.CodeText];
objDR[conFunction4GeneCode.UsedTimes] = objInFor[conFunction4GeneCode.UsedTimes];
objDR[conFunction4GeneCode.UpdDate] = objInFor[conFunction4GeneCode.UpdDate];
objDR[conFunction4GeneCode.UpdUser] = objInFor[conFunction4GeneCode.UpdUser];
objDR[conFunction4GeneCode.Memo] = objInFor[conFunction4GeneCode.Memo];
objDR[conFunction4GeneCode.ParsedWords] = objInFor[conFunction4GeneCode.ParsedWords];
objDR[conFunction4GeneCode.ParsedWordsExcluded] = objInFor[conFunction4GeneCode.ParsedWordsExcluded];
objDR[conFunction4GeneCode.WordVector] = objInFor[conFunction4GeneCode.WordVector];
objDR[conFunction4GeneCode.IsFuncTemplate] = objInFor[conFunction4GeneCode.IsFuncTemplate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 函数4GeneCode(Function4GeneCode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4Function4GeneCode : clsCommFun4BL
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
clsFunction4GeneCodeWApi.ReFreshThisCache();
}
}

}