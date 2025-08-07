
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4GeneCodeBL
 表名:vFunction4GeneCode(00050315)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:32
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
public static class  clsvFunction4GeneCodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4GeneCodeEN GetObj(this K_FuncId4GC_vFunction4GeneCode myKey)
{
clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBL.vFunction4GeneCodeDA.GetObjByFuncId4GC(myKey.Value);
return objvFunction4GeneCodeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncId4GC(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncId4GC, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunction4GeneCode.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunction4GeneCode.FuncId4GC);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunction4GeneCode.FuncName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunction4GeneCode.FuncName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncId4Code(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncId4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFunction4GeneCode.FuncId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFunction4GeneCode.FuncId4Code);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncName4Code(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncName4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFunction4GeneCode.FuncName4Code);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncCHName4Code(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncCHName4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, convFunction4GeneCode.FuncCHName4Code);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFunctionSignatureSim(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFunctionSignatureSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignatureSim, 500, convFunction4GeneCode.FunctionSignatureSim);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFeatureId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFunction4GeneCode.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFunction4GeneCode.FeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFeatureName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFunction4GeneCode.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFeatureDescription(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFeatureDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convFunction4GeneCode.FeatureDescription);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFeatureTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFeatureTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFunction4GeneCode.FeatureTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetProgLangTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunction4GeneCode.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunction4GeneCode.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunction4GeneCode.ProgLangTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetProgLangTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convFunction4GeneCode.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFunction4GeneCode.ProgLangTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetSqlDsTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convFunction4GeneCode.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convFunction4GeneCode.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convFunction4GeneCode.SqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetSqlDsTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convFunction4GeneCode.SqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncGCTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncGCTypeId, convFunction4GeneCode.FuncGCTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, convFunction4GeneCode.FuncGCTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, convFunction4GeneCode.FuncGCTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncGCTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncGCTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncGCTypeName, 50, convFunction4GeneCode.FuncGCTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncGCTypeENName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncGCTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncGCTypeENName, 50, convFunction4GeneCode.FuncGCTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetPrjId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFunction4GeneCode.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFunction4GeneCode.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetReturnTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strReturnTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convFunction4GeneCode.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convFunction4GeneCode.ReturnTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convFunction4GeneCode.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convFunction4GeneCode.FuncTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convFunction4GeneCode.FuncTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFunctionSignature(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFunctionSignature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFunction4GeneCode.FunctionSignature);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetUserId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convFunction4GeneCode.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetCodeText(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strCodeText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeText, 8000, convFunction4GeneCode.CodeText);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetUpdDate(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunction4GeneCode.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetUpdUser(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunction4GeneCode.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetMemo(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunction4GeneCode.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetParsedWords(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strParsedWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParsedWords, 500, convFunction4GeneCode.ParsedWords);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetParsedWordsExcluded(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strParsedWordsExcluded, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParsedWordsExcluded, 500, convFunction4GeneCode.ParsedWordsExcluded);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetWordVector(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strWordVector, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordVector, 500, convFunction4GeneCode.WordVector);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetReturnTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strReturnTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeName, 100, convFunction4GeneCode.ReturnTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetTemplateNum(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, int? intTemplateNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetOrder4FeatureNum(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, int? intOrder4FeatureNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncCodeTypeENName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCodeTypeENName, 50, convFunction4GeneCode.FuncCodeTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncCodeTypeId(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCodeTypeId, 4, convFunction4GeneCode.FuncCodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncCodeTypeId, 4, convFunction4GeneCode.FuncCodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetFuncCodeTypeName(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strFuncCodeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCodeTypeName, 50, convFunction4GeneCode.FuncCodeTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4GeneCodeEN SetProgLangTypeId4FuncCodeType(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, string strProgLangTypeId4FuncCodeType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId4FuncCodeType, 2, convFunction4GeneCode.ProgLangTypeId4FuncCodeType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId4FuncCodeType, 2, convFunction4GeneCode.ProgLangTypeId4FuncCodeType);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeENS">源对象</param>
 /// <param name = "objvFunction4GeneCodeENT">目标对象</param>
 public static void CopyTo(this clsvFunction4GeneCodeEN objvFunction4GeneCodeENS, clsvFunction4GeneCodeEN objvFunction4GeneCodeENT)
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
 /// <param name = "objvFunction4GeneCodeENS">源对象</param>
 /// <returns>目标对象=>clsvFunction4GeneCodeEN:objvFunction4GeneCodeENT</returns>
 public static clsvFunction4GeneCodeEN CopyTo(this clsvFunction4GeneCodeEN objvFunction4GeneCodeENS)
{
try
{
 clsvFunction4GeneCodeEN objvFunction4GeneCodeENT = new clsvFunction4GeneCodeEN()
{
FuncId4GC = objvFunction4GeneCodeENS.FuncId4GC, //函数ID
FuncName = objvFunction4GeneCodeENS.FuncName, //函数名
FuncId4Code = objvFunction4GeneCodeENS.FuncId4Code, //函数Id4Code
FuncName4Code = objvFunction4GeneCodeENS.FuncName4Code, //函数名4Code
FuncCHName4Code = objvFunction4GeneCodeENS.FuncCHName4Code, //函数中文名4Code
FunctionSignatureSim = objvFunction4GeneCodeENS.FunctionSignatureSim, //函数签名_Sim
FeatureId = objvFunction4GeneCodeENS.FeatureId, //功能Id
FeatureName = objvFunction4GeneCodeENS.FeatureName, //功能名称
FeatureDescription = objvFunction4GeneCodeENS.FeatureDescription, //功能说明
FeatureTypeName = objvFunction4GeneCodeENS.FeatureTypeName, //功能类型名称
ProgLangTypeId = objvFunction4GeneCodeENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvFunction4GeneCodeENS.ProgLangTypeName, //编程语言类型名
SqlDsTypeId = objvFunction4GeneCodeENS.SqlDsTypeId, //数据源类型Id
SqlDsTypeName = objvFunction4GeneCodeENS.SqlDsTypeName, //Sql数据源名
FuncGCTypeId = objvFunction4GeneCodeENS.FuncGCTypeId, //函数生成代码类型Id
FuncGCTypeName = objvFunction4GeneCodeENS.FuncGCTypeName, //函数生成代码类型名
FuncGCTypeENName = objvFunction4GeneCodeENS.FuncGCTypeENName, //函数生成代码类型英文名
PrjId = objvFunction4GeneCodeENS.PrjId, //工程Id
ReturnTypeId = objvFunction4GeneCodeENS.ReturnTypeId, //返回类型ID
FuncTypeId = objvFunction4GeneCodeENS.FuncTypeId, //函数类型Id
FuncTypeName = objvFunction4GeneCodeENS.FuncTypeName, //函数类型名
IsTemplate = objvFunction4GeneCodeENS.IsTemplate, //是否模板
FunctionSignature = objvFunction4GeneCodeENS.FunctionSignature, //函数签名
FuncCode = objvFunction4GeneCodeENS.FuncCode, //函数代码
UserId = objvFunction4GeneCodeENS.UserId, //用户Id
OrderNum = objvFunction4GeneCodeENS.OrderNum, //序号
InUse = objvFunction4GeneCodeENS.InUse, //是否在用
CodeText = objvFunction4GeneCodeENS.CodeText, //代码文本
UpdDate = objvFunction4GeneCodeENS.UpdDate, //修改日期
UpdUser = objvFunction4GeneCodeENS.UpdUser, //修改者
Memo = objvFunction4GeneCodeENS.Memo, //说明
ParsedWords = objvFunction4GeneCodeENS.ParsedWords, //分析的词
ParsedWordsExcluded = objvFunction4GeneCodeENS.ParsedWordsExcluded, //剔除后的词组
WordVector = objvFunction4GeneCodeENS.WordVector, //词向量
IsFuncTemplate = objvFunction4GeneCodeENS.IsFuncTemplate, //是否函数模板
ReturnTypeName = objvFunction4GeneCodeENS.ReturnTypeName, //返回类型名
TemplateNum = objvFunction4GeneCodeENS.TemplateNum, //TemplateNum
Order4FeatureNum = objvFunction4GeneCodeENS.Order4FeatureNum, //Order4FeatureNum
FuncCodeTypeENName = objvFunction4GeneCodeENS.FuncCodeTypeENName, //FuncCodeTypeENName
FuncCodeTypeId = objvFunction4GeneCodeENS.FuncCodeTypeId, //函数代码类型Id
FuncCodeTypeName = objvFunction4GeneCodeENS.FuncCodeTypeName, //FuncCodeTypeName
ProgLangTypeId4FuncCodeType = objvFunction4GeneCodeENS.ProgLangTypeId4FuncCodeType, //ProgLangTypeId4FuncCodeType
};
 return objvFunction4GeneCodeENT;
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
public static void CheckProperty4Condition(this clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
{
 clsvFunction4GeneCodeBL.vFunction4GeneCodeDA.CheckProperty4Condition(objvFunction4GeneCodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunction4GeneCode
{
public virtual bool UpdRelaTabDate(string strFuncId4GC, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数4GeneCode(vFunction4GeneCode)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunction4GeneCodeBL
{
public static RelatedActions_vFunction4GeneCode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunction4GeneCodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunction4GeneCodeDA vFunction4GeneCodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunction4GeneCodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunction4GeneCodeBL()
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
if (string.IsNullOrEmpty(clsvFunction4GeneCodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunction4GeneCodeEN._ConnectString);
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
public static DataTable GetDataTable_vFunction4GeneCode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunction4GeneCodeDA.GetDataTable_vFunction4GeneCode(strWhereCond);
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
objDT = vFunction4GeneCodeDA.GetDataTable(strWhereCond);
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
objDT = vFunction4GeneCodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunction4GeneCodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunction4GeneCodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunction4GeneCodeDA.GetDataTable_Top(objTopPara);
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
objDT = vFunction4GeneCodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunction4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunction4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncId4GCLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetObjLstByFuncId4GCLst(List<string> arrFuncId4GCLst)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncId4GCLst, true);
 string strWhereCond = string.Format("FuncId4GC in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncId4GCLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunction4GeneCodeEN> GetObjLstByFuncId4GCLstCache(List<string> arrFuncId4GCLst)
{
string strKey = string.Format("{0}", clsvFunction4GeneCodeEN._CurrTabName);
List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel =
arrvFunction4GeneCodeObjLstCache
.Where(x => arrFuncId4GCLst.Contains(x.FuncId4GC));
return arrvFunction4GeneCodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetObjLst(string strWhereCond)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
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
public static List<clsvFunction4GeneCodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunction4GeneCodeEN> GetSubObjLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeCond)
{
List<clsvFunction4GeneCodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunction4GeneCode._AttributeName)
{
if (objvFunction4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objvFunction4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4GeneCodeCond[strFldName].ToString());
}
else
{
if (objvFunction4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunction4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunction4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunction4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunction4GeneCodeCond[strFldName]));
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
public static List<clsvFunction4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
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
public static List<clsvFunction4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
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
List<clsvFunction4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunction4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunction4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
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
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
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
public static List<clsvFunction4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunction4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
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
public static List<clsvFunction4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4GeneCodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunction4GeneCode(ref clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
{
bool bolResult = vFunction4GeneCodeDA.GetvFunction4GeneCode(ref objvFunction4GeneCodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4GeneCodeEN GetObjByFuncId4GC(string strFuncId4GC)
{
if (strFuncId4GC.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncId4GC]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncId4GC) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncId4GC]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = vFunction4GeneCodeDA.GetObjByFuncId4GC(strFuncId4GC);
return objvFunction4GeneCodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunction4GeneCodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = vFunction4GeneCodeDA.GetFirstObj(strWhereCond);
 return objvFunction4GeneCodeEN;
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
public static clsvFunction4GeneCodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = vFunction4GeneCodeDA.GetObjByDataRow(objRow);
 return objvFunction4GeneCodeEN;
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
public static clsvFunction4GeneCodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = vFunction4GeneCodeDA.GetObjByDataRow(objRow);
 return objvFunction4GeneCodeEN;
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
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <param name = "lstvFunction4GeneCodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunction4GeneCodeEN GetObjByFuncId4GCFromList(string strFuncId4GC, List<clsvFunction4GeneCodeEN> lstvFunction4GeneCodeObjLst)
{
foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in lstvFunction4GeneCodeObjLst)
{
if (objvFunction4GeneCodeEN.FuncId4GC == strFuncId4GC)
{
return objvFunction4GeneCodeEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strFuncId4GC;
 try
 {
 strFuncId4GC = new clsvFunction4GeneCodeDA().GetFirstID(strWhereCond);
 return strFuncId4GC;
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
 arrList = vFunction4GeneCodeDA.GetID(strWhereCond);
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
bool bolIsExist = vFunction4GeneCodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncId4GC]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFunction4GeneCodeDA.IsExist(strFuncId4GC);
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
 bolIsExist = clsvFunction4GeneCodeDA.IsExistTable();
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
 bolIsExist = vFunction4GeneCodeDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunction4GeneCodeEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
{
try
{
objvFunction4GeneCodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunction4GeneCodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunction4GeneCode.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncId4GC = objvFunction4GeneCodeEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncName = objvFunction4GeneCodeEN.FuncName; //函数名
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncId4Code = objvFunction4GeneCodeEN.FuncId4Code == "[null]" ? null :  objvFunction4GeneCodeEN.FuncId4Code; //函数Id4Code
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncName4Code = objvFunction4GeneCodeEN.FuncName4Code == "[null]" ? null :  objvFunction4GeneCodeEN.FuncName4Code; //函数名4Code
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncCHName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncCHName4Code = objvFunction4GeneCodeEN.FuncCHName4Code == "[null]" ? null :  objvFunction4GeneCodeEN.FuncCHName4Code; //函数中文名4Code
}
if (arrFldSet.Contains(convFunction4GeneCode.FunctionSignatureSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FunctionSignatureSim = objvFunction4GeneCodeEN.FunctionSignatureSim == "[null]" ? null :  objvFunction4GeneCodeEN.FunctionSignatureSim; //函数签名_Sim
}
if (arrFldSet.Contains(convFunction4GeneCode.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FeatureId = objvFunction4GeneCodeEN.FeatureId == "[null]" ? null :  objvFunction4GeneCodeEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFunction4GeneCode.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FeatureName = objvFunction4GeneCodeEN.FeatureName == "[null]" ? null :  objvFunction4GeneCodeEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFunction4GeneCode.FeatureDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FeatureDescription = objvFunction4GeneCodeEN.FeatureDescription == "[null]" ? null :  objvFunction4GeneCodeEN.FeatureDescription; //功能说明
}
if (arrFldSet.Contains(convFunction4GeneCode.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FeatureTypeName = objvFunction4GeneCodeEN.FeatureTypeName == "[null]" ? null :  objvFunction4GeneCodeEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(convFunction4GeneCode.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.ProgLangTypeId = objvFunction4GeneCodeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convFunction4GeneCode.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.ProgLangTypeName = objvFunction4GeneCodeEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convFunction4GeneCode.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.SqlDsTypeId = objvFunction4GeneCodeEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convFunction4GeneCode.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.SqlDsTypeName = objvFunction4GeneCodeEN.SqlDsTypeName == "[null]" ? null :  objvFunction4GeneCodeEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncGCTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncGCTypeId = objvFunction4GeneCodeEN.FuncGCTypeId; //函数生成代码类型Id
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncGCTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncGCTypeName = objvFunction4GeneCodeEN.FuncGCTypeName == "[null]" ? null :  objvFunction4GeneCodeEN.FuncGCTypeName; //函数生成代码类型名
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncGCTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncGCTypeENName = objvFunction4GeneCodeEN.FuncGCTypeENName == "[null]" ? null :  objvFunction4GeneCodeEN.FuncGCTypeENName; //函数生成代码类型英文名
}
if (arrFldSet.Contains(convFunction4GeneCode.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.PrjId = objvFunction4GeneCodeEN.PrjId == "[null]" ? null :  objvFunction4GeneCodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFunction4GeneCode.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.ReturnTypeId = objvFunction4GeneCodeEN.ReturnTypeId == "[null]" ? null :  objvFunction4GeneCodeEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncTypeId = objvFunction4GeneCodeEN.FuncTypeId == "[null]" ? null :  objvFunction4GeneCodeEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncTypeName = objvFunction4GeneCodeEN.FuncTypeName == "[null]" ? null :  objvFunction4GeneCodeEN.FuncTypeName; //函数类型名
}
if (arrFldSet.Contains(convFunction4GeneCode.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.IsTemplate = objvFunction4GeneCodeEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(convFunction4GeneCode.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FunctionSignature = objvFunction4GeneCodeEN.FunctionSignature == "[null]" ? null :  objvFunction4GeneCodeEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncCode = objvFunction4GeneCodeEN.FuncCode == "[null]" ? null :  objvFunction4GeneCodeEN.FuncCode; //函数代码
}
if (arrFldSet.Contains(convFunction4GeneCode.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.UserId = objvFunction4GeneCodeEN.UserId == "[null]" ? null :  objvFunction4GeneCodeEN.UserId; //用户Id
}
if (arrFldSet.Contains(convFunction4GeneCode.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.OrderNum = objvFunction4GeneCodeEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFunction4GeneCode.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.InUse = objvFunction4GeneCodeEN.InUse; //是否在用
}
if (arrFldSet.Contains(convFunction4GeneCode.CodeText, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.CodeText = objvFunction4GeneCodeEN.CodeText == "[null]" ? null :  objvFunction4GeneCodeEN.CodeText; //代码文本
}
if (arrFldSet.Contains(convFunction4GeneCode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.UpdDate = objvFunction4GeneCodeEN.UpdDate == "[null]" ? null :  objvFunction4GeneCodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFunction4GeneCode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.UpdUser = objvFunction4GeneCodeEN.UpdUser == "[null]" ? null :  objvFunction4GeneCodeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFunction4GeneCode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.Memo = objvFunction4GeneCodeEN.Memo == "[null]" ? null :  objvFunction4GeneCodeEN.Memo; //说明
}
if (arrFldSet.Contains(convFunction4GeneCode.ParsedWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.ParsedWords = objvFunction4GeneCodeEN.ParsedWords == "[null]" ? null :  objvFunction4GeneCodeEN.ParsedWords; //分析的词
}
if (arrFldSet.Contains(convFunction4GeneCode.ParsedWordsExcluded, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.ParsedWordsExcluded = objvFunction4GeneCodeEN.ParsedWordsExcluded == "[null]" ? null :  objvFunction4GeneCodeEN.ParsedWordsExcluded; //剔除后的词组
}
if (arrFldSet.Contains(convFunction4GeneCode.WordVector, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.WordVector = objvFunction4GeneCodeEN.WordVector == "[null]" ? null :  objvFunction4GeneCodeEN.WordVector; //词向量
}
if (arrFldSet.Contains(convFunction4GeneCode.IsFuncTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.IsFuncTemplate = objvFunction4GeneCodeEN.IsFuncTemplate; //是否函数模板
}
if (arrFldSet.Contains(convFunction4GeneCode.ReturnTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.ReturnTypeName = objvFunction4GeneCodeEN.ReturnTypeName == "[null]" ? null :  objvFunction4GeneCodeEN.ReturnTypeName; //返回类型名
}
if (arrFldSet.Contains(convFunction4GeneCode.TemplateNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.TemplateNum = objvFunction4GeneCodeEN.TemplateNum; //TemplateNum
}
if (arrFldSet.Contains(convFunction4GeneCode.Order4FeatureNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.Order4FeatureNum = objvFunction4GeneCodeEN.Order4FeatureNum; //Order4FeatureNum
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncCodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncCodeTypeENName = objvFunction4GeneCodeEN.FuncCodeTypeENName == "[null]" ? null :  objvFunction4GeneCodeEN.FuncCodeTypeENName; //FuncCodeTypeENName
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncCodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncCodeTypeId = objvFunction4GeneCodeEN.FuncCodeTypeId == "[null]" ? null :  objvFunction4GeneCodeEN.FuncCodeTypeId; //函数代码类型Id
}
if (arrFldSet.Contains(convFunction4GeneCode.FuncCodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.FuncCodeTypeName = objvFunction4GeneCodeEN.FuncCodeTypeName == "[null]" ? null :  objvFunction4GeneCodeEN.FuncCodeTypeName; //FuncCodeTypeName
}
if (arrFldSet.Contains(convFunction4GeneCode.ProgLangTypeId4FuncCodeType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType == "[null]" ? null :  objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType; //ProgLangTypeId4FuncCodeType
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
 /// <param name = "objvFunction4GeneCodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
{
try
{
if (objvFunction4GeneCodeEN.FuncId4Code == "[null]") objvFunction4GeneCodeEN.FuncId4Code = null; //函数Id4Code
if (objvFunction4GeneCodeEN.FuncName4Code == "[null]") objvFunction4GeneCodeEN.FuncName4Code = null; //函数名4Code
if (objvFunction4GeneCodeEN.FuncCHName4Code == "[null]") objvFunction4GeneCodeEN.FuncCHName4Code = null; //函数中文名4Code
if (objvFunction4GeneCodeEN.FunctionSignatureSim == "[null]") objvFunction4GeneCodeEN.FunctionSignatureSim = null; //函数签名_Sim
if (objvFunction4GeneCodeEN.FeatureId == "[null]") objvFunction4GeneCodeEN.FeatureId = null; //功能Id
if (objvFunction4GeneCodeEN.FeatureName == "[null]") objvFunction4GeneCodeEN.FeatureName = null; //功能名称
if (objvFunction4GeneCodeEN.FeatureDescription == "[null]") objvFunction4GeneCodeEN.FeatureDescription = null; //功能说明
if (objvFunction4GeneCodeEN.FeatureTypeName == "[null]") objvFunction4GeneCodeEN.FeatureTypeName = null; //功能类型名称
if (objvFunction4GeneCodeEN.SqlDsTypeName == "[null]") objvFunction4GeneCodeEN.SqlDsTypeName = null; //Sql数据源名
if (objvFunction4GeneCodeEN.FuncGCTypeName == "[null]") objvFunction4GeneCodeEN.FuncGCTypeName = null; //函数生成代码类型名
if (objvFunction4GeneCodeEN.FuncGCTypeENName == "[null]") objvFunction4GeneCodeEN.FuncGCTypeENName = null; //函数生成代码类型英文名
if (objvFunction4GeneCodeEN.PrjId == "[null]") objvFunction4GeneCodeEN.PrjId = null; //工程Id
if (objvFunction4GeneCodeEN.ReturnTypeId == "[null]") objvFunction4GeneCodeEN.ReturnTypeId = null; //返回类型ID
if (objvFunction4GeneCodeEN.FuncTypeId == "[null]") objvFunction4GeneCodeEN.FuncTypeId = null; //函数类型Id
if (objvFunction4GeneCodeEN.FuncTypeName == "[null]") objvFunction4GeneCodeEN.FuncTypeName = null; //函数类型名
if (objvFunction4GeneCodeEN.FunctionSignature == "[null]") objvFunction4GeneCodeEN.FunctionSignature = null; //函数签名
if (objvFunction4GeneCodeEN.FuncCode == "[null]") objvFunction4GeneCodeEN.FuncCode = null; //函数代码
if (objvFunction4GeneCodeEN.UserId == "[null]") objvFunction4GeneCodeEN.UserId = null; //用户Id
if (objvFunction4GeneCodeEN.CodeText == "[null]") objvFunction4GeneCodeEN.CodeText = null; //代码文本
if (objvFunction4GeneCodeEN.UpdDate == "[null]") objvFunction4GeneCodeEN.UpdDate = null; //修改日期
if (objvFunction4GeneCodeEN.UpdUser == "[null]") objvFunction4GeneCodeEN.UpdUser = null; //修改者
if (objvFunction4GeneCodeEN.Memo == "[null]") objvFunction4GeneCodeEN.Memo = null; //说明
if (objvFunction4GeneCodeEN.ParsedWords == "[null]") objvFunction4GeneCodeEN.ParsedWords = null; //分析的词
if (objvFunction4GeneCodeEN.ParsedWordsExcluded == "[null]") objvFunction4GeneCodeEN.ParsedWordsExcluded = null; //剔除后的词组
if (objvFunction4GeneCodeEN.WordVector == "[null]") objvFunction4GeneCodeEN.WordVector = null; //词向量
if (objvFunction4GeneCodeEN.ReturnTypeName == "[null]") objvFunction4GeneCodeEN.ReturnTypeName = null; //返回类型名
if (objvFunction4GeneCodeEN.FuncCodeTypeENName == "[null]") objvFunction4GeneCodeEN.FuncCodeTypeENName = null; //FuncCodeTypeENName
if (objvFunction4GeneCodeEN.FuncCodeTypeId == "[null]") objvFunction4GeneCodeEN.FuncCodeTypeId = null; //函数代码类型Id
if (objvFunction4GeneCodeEN.FuncCodeTypeName == "[null]") objvFunction4GeneCodeEN.FuncCodeTypeName = null; //FuncCodeTypeName
if (objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType == "[null]") objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = null; //ProgLangTypeId4FuncCodeType
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
public static void CheckProperty4Condition(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
{
 vFunction4GeneCodeDA.CheckProperty4Condition(objvFunction4GeneCodeEN);
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
//string strWhereCond = string.Format("1 = 1 order by FuncId4GC");
//if (arrvFunction4GeneCodeObjLstCache == null)
//{
//arrvFunction4GeneCodeObjLstCache = vFunction4GeneCodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunction4GeneCodeEN GetObjByFuncId4GCCache(string strFuncId4GC)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunction4GeneCodeEN._CurrTabName);
List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel =
arrvFunction4GeneCodeObjLstCache
.Where(x=> x.FuncId4GC == strFuncId4GC 
);
if (arrvFunction4GeneCodeObjLst_Sel.Count() == 0)
{
   clsvFunction4GeneCodeEN obj = clsvFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunction4GeneCodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetAllvFunction4GeneCodeObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstCache = GetObjLstCache(); 
return arrvFunction4GeneCodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunction4GeneCodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunction4GeneCodeEN._CurrTabName);
List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunction4GeneCodeObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvFunction4GeneCodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunction4GeneCodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunction4GeneCodeEN._RefreshTimeLst.Count == 0) return "";
return clsvFunction4GeneCodeEN._RefreshTimeLst[clsvFunction4GeneCodeEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFuncId4GC)
{
if (strInFldName != convFunction4GeneCode.FuncId4GC)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunction4GeneCode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunction4GeneCode._AttributeName));
throw new Exception(strMsg);
}
var objvFunction4GeneCode = clsvFunction4GeneCodeBL.GetObjByFuncId4GCCache(strFuncId4GC);
if (objvFunction4GeneCode == null) return "";
return objvFunction4GeneCode[strOutFldName].ToString();
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
int intRecCount = clsvFunction4GeneCodeDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunction4GeneCodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunction4GeneCodeDA.GetRecCount();
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
int intRecCount = clsvFunction4GeneCodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeCond)
{
List<clsvFunction4GeneCodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunction4GeneCode._AttributeName)
{
if (objvFunction4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objvFunction4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4GeneCodeCond[strFldName].ToString());
}
else
{
if (objvFunction4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunction4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunction4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunction4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunction4GeneCodeCond[strFldName]));
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
 List<string> arrList = clsvFunction4GeneCodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunction4GeneCodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunction4GeneCodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}