
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureWApi
 表名:vTabFeature(00050464)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvTabFeatureWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId">表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabFeatureId(this clsvTabFeatureEN objvTabFeatureEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convTabFeature.TabFeatureId);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convTabFeature.TabFeatureId);
objvTabFeatureEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.TabFeatureId) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.TabFeatureId, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.TabFeatureId] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureName">表功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabFeatureName(this clsvTabFeatureEN objvTabFeatureEN, string strTabFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convTabFeature.TabFeatureName);
objvTabFeatureEN.TabFeatureName = strTabFeatureName; //表功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.TabFeatureName) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.TabFeatureName, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.TabFeatureName] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabId(this clsvTabFeatureEN objvTabFeatureEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFeature.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFeature.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFeature.TabId);
objvTabFeatureEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.TabId) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.TabId, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.TabId] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabName(this clsvTabFeatureEN objvTabFeatureEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convTabFeature.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convTabFeature.TabName);
objvTabFeatureEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.TabName) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.TabName, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.TabName] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabCnName(this clsvTabFeatureEN objvTabFeatureEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabFeature.TabCnName);
objvTabFeatureEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.TabCnName) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.TabCnName, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.TabCnName] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetPrjName(this clsvTabFeatureEN objvTabFeatureEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convTabFeature.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convTabFeature.PrjName);
objvTabFeatureEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.PrjName) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.PrjName, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.PrjName] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetSqlDsTypeName(this clsvTabFeatureEN objvTabFeatureEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeName, convTabFeature.SqlDsTypeName);
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convTabFeature.SqlDsTypeName);
objvTabFeatureEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.SqlDsTypeName) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.SqlDsTypeName, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.SqlDsTypeName] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFuncModuleAgcId(this clsvTabFeatureEN objvTabFeatureEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convTabFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convTabFeature.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convTabFeature.FuncModuleAgcId);
objvTabFeatureEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.FuncModuleAgcId) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.FuncModuleAgcId, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.FuncModuleAgcId] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFuncModuleName(this clsvTabFeatureEN objvTabFeatureEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convTabFeature.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTabFeature.FuncModuleName);
objvTabFeatureEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.FuncModuleName) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.FuncModuleName, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.FuncModuleName] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetOrderNum4Refer(this clsvTabFeatureEN objvTabFeatureEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objvTabFeatureEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.OrderNum4Refer) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.OrderNum4Refer, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.OrderNum4Refer] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFeatureId(this clsvTabFeatureEN objvTabFeatureEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convTabFeature.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convTabFeature.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convTabFeature.FeatureId);
objvTabFeatureEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.FeatureId) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.FeatureId, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.FeatureId] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFeatureName(this clsvTabFeatureEN objvTabFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convTabFeature.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convTabFeature.FeatureName);
objvTabFeatureEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.FeatureName) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.FeatureName, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.FeatureName] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureId">父功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetParentFeatureId(this clsvTabFeatureEN objvTabFeatureEN, string strParentFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureId, 4, convTabFeature.ParentFeatureId);
clsCheckSql.CheckFieldForeignKey(strParentFeatureId, 4, convTabFeature.ParentFeatureId);
objvTabFeatureEN.ParentFeatureId = strParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.ParentFeatureId) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.ParentFeatureId, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.ParentFeatureId] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureName">父功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetParentFeatureName(this clsvTabFeatureEN objvTabFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convTabFeature.ParentFeatureName);
objvTabFeatureEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.ParentFeatureName) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.ParentFeatureName, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.ParentFeatureName] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncNameCs">Cs函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFuncNameCs(this clsvTabFeatureEN objvTabFeatureEN, string strFuncNameCs, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncNameCs, 100, convTabFeature.FuncNameCs);
objvTabFeatureEN.FuncNameCs = strFuncNameCs; //Cs函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.FuncNameCs) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.FuncNameCs, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.FuncNameCs] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncNameJs">Js函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFuncNameJs(this clsvTabFeatureEN objvTabFeatureEN, string strFuncNameJs, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncNameJs, 100, convTabFeature.FuncNameJs);
objvTabFeatureEN.FuncNameJs = strFuncNameJs; //Js函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.FuncNameJs) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.FuncNameJs, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.FuncNameJs] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetOrderNum(this clsvTabFeatureEN objvTabFeatureEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convTabFeature.OrderNum);
objvTabFeatureEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.OrderNum) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.OrderNum, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.OrderNum] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetInUse(this clsvTabFeatureEN objvTabFeatureEN, bool bolInUse, string strComparisonOp="")
	{
objvTabFeatureEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.InUse) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.InUse, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.InUse] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetPrjId(this clsvTabFeatureEN objvTabFeatureEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFeature.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFeature.PrjId);
objvTabFeatureEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.PrjId) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.PrjId, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.PrjId] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetUpdUser(this clsvTabFeatureEN objvTabFeatureEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTabFeature.UpdUser);
objvTabFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.UpdUser) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.UpdUser, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.UpdUser] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetUpdDate(this clsvTabFeatureEN objvTabFeatureEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTabFeature.UpdDate);
objvTabFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.UpdDate) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.UpdDate, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.UpdDate] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetMemo(this clsvTabFeatureEN objvTabFeatureEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFeature.Memo);
objvTabFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.Memo) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.Memo, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.Memo] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldNum">字段数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFldNum(this clsvTabFeatureEN objvTabFeatureEN, int intFldNum, string strComparisonOp="")
	{
objvTabFeatureEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureEN.dicFldComparisonOp.ContainsKey(convTabFeature.FldNum) == false)
{
objvTabFeatureEN.dicFldComparisonOp.Add(convTabFeature.FldNum, strComparisonOp);
}
else
{
objvTabFeatureEN.dicFldComparisonOp[convTabFeature.FldNum] = strComparisonOp;
}
}
return objvTabFeatureEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTabFeatureEN objvTabFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTabFeatureCond.IsUpdated(convTabFeature.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.TabFeatureId, objvTabFeatureCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.TabFeatureName) == true)
{
string strComparisonOpTabFeatureName = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.TabFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.TabFeatureName, objvTabFeatureCond.TabFeatureName, strComparisonOpTabFeatureName);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.TabId) == true)
{
string strComparisonOpTabId = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.TabId, objvTabFeatureCond.TabId, strComparisonOpTabId);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.TabName) == true)
{
string strComparisonOpTabName = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.TabName, objvTabFeatureCond.TabName, strComparisonOpTabName);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.TabCnName) == true)
{
string strComparisonOpTabCnName = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.TabCnName, objvTabFeatureCond.TabCnName, strComparisonOpTabCnName);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.PrjName) == true)
{
string strComparisonOpPrjName = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.PrjName, objvTabFeatureCond.PrjName, strComparisonOpPrjName);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.SqlDsTypeName, objvTabFeatureCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.FuncModuleAgcId, objvTabFeatureCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.FuncModuleName, objvTabFeatureCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFeature.OrderNum4Refer, objvTabFeatureCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.FeatureId) == true)
{
string strComparisonOpFeatureId = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.FeatureId, objvTabFeatureCond.FeatureId, strComparisonOpFeatureId);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.FeatureName) == true)
{
string strComparisonOpFeatureName = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.FeatureName, objvTabFeatureCond.FeatureName, strComparisonOpFeatureName);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.ParentFeatureId) == true)
{
string strComparisonOpParentFeatureId = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.ParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.ParentFeatureId, objvTabFeatureCond.ParentFeatureId, strComparisonOpParentFeatureId);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.ParentFeatureName, objvTabFeatureCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.FuncNameCs) == true)
{
string strComparisonOpFuncNameCs = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.FuncNameCs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.FuncNameCs, objvTabFeatureCond.FuncNameCs, strComparisonOpFuncNameCs);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.FuncNameJs) == true)
{
string strComparisonOpFuncNameJs = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.FuncNameJs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.FuncNameJs, objvTabFeatureCond.FuncNameJs, strComparisonOpFuncNameJs);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.OrderNum) == true)
{
string strComparisonOpOrderNum = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFeature.OrderNum, objvTabFeatureCond.OrderNum, strComparisonOpOrderNum);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.InUse) == true)
{
if (objvTabFeatureCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeature.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeature.InUse);
}
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.PrjId) == true)
{
string strComparisonOpPrjId = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.PrjId, objvTabFeatureCond.PrjId, strComparisonOpPrjId);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.UpdUser, objvTabFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.UpdDate, objvTabFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.Memo) == true)
{
string strComparisonOpMemo = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature.Memo, objvTabFeatureCond.Memo, strComparisonOpMemo);
}
if (objvTabFeatureCond.IsUpdated(convTabFeature.FldNum) == true)
{
string strComparisonOpFldNum = objvTabFeatureCond.dicFldComparisonOp[convTabFeature.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFeature.FldNum, objvTabFeatureCond.FldNum, strComparisonOpFldNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v表功能(vTabFeature)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTabFeatureWApi
{
private static readonly string mstrApiControllerName = "vTabFeatureApi";

 public clsvTabFeatureWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabFeatureId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v表功能]...","0");
List<clsvTabFeatureEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TabFeatureId";
objDDL.DataTextField="TabFeatureName";
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

 /// <param name = "strPrjId"></param>
public static void BindCbo_TabFeatureId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convTabFeature.TabFeatureId); 
List<clsvTabFeatureEN> arrObjLst = clsvTabFeatureWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN()
{
TabFeatureId = "0",
TabFeatureName = "选[v表功能]..."
};
arrObjLstSel.Insert(0, objvTabFeatureEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convTabFeature.TabFeatureId;
objComboBox.DisplayMember = convTabFeature.TabFeatureName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeatureEN GetObjByTabFeatureId(string strTabFeatureId)
{
if (strTabFeatureId == "") return null;
string strAction = "GetObjByTabFeatureId";
clsvTabFeatureEN objvTabFeatureEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabFeatureId"] = strTabFeatureId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvTabFeatureEN = JsonConvert.DeserializeObject<clsvTabFeatureEN>(strJson);
return objvTabFeatureEN;
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
public static clsvTabFeatureEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvTabFeatureEN objvTabFeatureEN;
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
objvTabFeatureEN = JsonConvert.DeserializeObject<clsvTabFeatureEN>(strJson);
return objvTabFeatureEN;
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
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFeatureEN GetObjByTabFeatureIdCache(string strTabFeatureId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabFeatureEN._CurrTabName, strPrjId);
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureEN> arrvTabFeatureObjLst_Sel =
from objvTabFeatureEN in arrvTabFeatureObjLstCache
where objvTabFeatureEN.TabFeatureId == strTabFeatureId 
select objvTabFeatureEN;
if (arrvTabFeatureObjLst_Sel.Count() == 0)
{
   clsvTabFeatureEN obj = clsvTabFeatureWApi.GetObjByTabFeatureId(strTabFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTabFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabFeatureNameByTabFeatureIdCache(string strTabFeatureId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return "";
//初始化列表缓存
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureEN> arrvTabFeatureObjLst_Sel1 =
from objvTabFeatureEN in arrvTabFeatureObjLstCache
where objvTabFeatureEN.TabFeatureId == strTabFeatureId 
select objvTabFeatureEN;
List <clsvTabFeatureEN> arrvTabFeatureObjLst_Sel = new List<clsvTabFeatureEN>();
foreach (clsvTabFeatureEN obj in arrvTabFeatureObjLst_Sel1)
{
arrvTabFeatureObjLst_Sel.Add(obj);
}
if (arrvTabFeatureObjLst_Sel.Count > 0)
{
return arrvTabFeatureObjLst_Sel[0].TabFeatureName;
}
string strErrMsgForGetObjById = string.Format("在vTabFeature对象缓存列表中,找不到记录[TabFeatureId = {0}](函数:{1})", strTabFeatureId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTabFeatureBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabFeatureIdCache(string strTabFeatureId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return "";
//初始化列表缓存
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureEN> arrvTabFeatureObjLst_Sel1 =
from objvTabFeatureEN in arrvTabFeatureObjLstCache
where objvTabFeatureEN.TabFeatureId == strTabFeatureId 
select objvTabFeatureEN;
List <clsvTabFeatureEN> arrvTabFeatureObjLst_Sel = new List<clsvTabFeatureEN>();
foreach (clsvTabFeatureEN obj in arrvTabFeatureObjLst_Sel1)
{
arrvTabFeatureObjLst_Sel.Add(obj);
}
if (arrvTabFeatureObjLst_Sel.Count > 0)
{
return arrvTabFeatureObjLst_Sel[0].TabFeatureName;
}
string strErrMsgForGetObjById = string.Format("在vTabFeature对象缓存列表中,找不到记录的相关名称[TabFeatureId = {0}](函数:{1})", strTabFeatureId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTabFeatureBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureEN> GetObjLst(string strWhereCond)
{
 List<clsvTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureEN>>(strJson);
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
 /// <param name = "arrTabFeatureId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureEN> GetObjLstByTabFeatureIdLst(List<string> arrTabFeatureId)
{
 List<clsvTabFeatureEN> arrObjLst; 
string strAction = "GetObjLstByTabFeatureIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTabFeatureId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureEN>>(strJson);
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
 /// <param name = "arrTabFeatureId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvTabFeatureEN> GetObjLstByTabFeatureIdLstCache(List<string> arrTabFeatureId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabFeatureEN._CurrTabName, strPrjId);
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureEN> arrvTabFeatureObjLst_Sel =
from objvTabFeatureEN in arrvTabFeatureObjLstCache
where arrTabFeatureId.Contains(objvTabFeatureEN.TabFeatureId)
select objvTabFeatureEN;
return arrvTabFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureEN>>(strJson);
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
public static List<clsvTabFeatureEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureEN>>(strJson);
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
public static List<clsvTabFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureEN>>(strJson);
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
public static List<clsvTabFeatureEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvTabFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureEN>>(strJson);
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
public static bool IsExist(string strTabFeatureId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabFeatureId"] = strTabFeatureId
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
 /// <param name = "objvTabFeatureENS">源对象</param>
 /// <param name = "objvTabFeatureENT">目标对象</param>
 public static void CopyTo(clsvTabFeatureEN objvTabFeatureENS, clsvTabFeatureEN objvTabFeatureENT)
{
try
{
objvTabFeatureENT.TabFeatureId = objvTabFeatureENS.TabFeatureId; //表功能Id
objvTabFeatureENT.TabFeatureName = objvTabFeatureENS.TabFeatureName; //表功能名
objvTabFeatureENT.TabId = objvTabFeatureENS.TabId; //表ID
objvTabFeatureENT.TabName = objvTabFeatureENS.TabName; //表名
objvTabFeatureENT.TabCnName = objvTabFeatureENS.TabCnName; //表中文名
objvTabFeatureENT.PrjName = objvTabFeatureENS.PrjName; //工程名称
objvTabFeatureENT.SqlDsTypeName = objvTabFeatureENS.SqlDsTypeName; //Sql数据源名
objvTabFeatureENT.FuncModuleAgcId = objvTabFeatureENS.FuncModuleAgcId; //功能模块Id
objvTabFeatureENT.FuncModuleName = objvTabFeatureENS.FuncModuleName; //功能模块名称
objvTabFeatureENT.OrderNum4Refer = objvTabFeatureENS.OrderNum4Refer; //引用序号
objvTabFeatureENT.FeatureId = objvTabFeatureENS.FeatureId; //功能Id
objvTabFeatureENT.FeatureName = objvTabFeatureENS.FeatureName; //功能名称
objvTabFeatureENT.ParentFeatureId = objvTabFeatureENS.ParentFeatureId; //父功能Id
objvTabFeatureENT.ParentFeatureName = objvTabFeatureENS.ParentFeatureName; //父功能名
objvTabFeatureENT.FuncNameCs = objvTabFeatureENS.FuncNameCs; //Cs函数名
objvTabFeatureENT.FuncNameJs = objvTabFeatureENS.FuncNameJs; //Js函数名
objvTabFeatureENT.OrderNum = objvTabFeatureENS.OrderNum; //序号
objvTabFeatureENT.InUse = objvTabFeatureENS.InUse; //是否在用
objvTabFeatureENT.PrjId = objvTabFeatureENS.PrjId; //工程Id
objvTabFeatureENT.UpdUser = objvTabFeatureENS.UpdUser; //修改者
objvTabFeatureENT.UpdDate = objvTabFeatureENS.UpdDate; //修改日期
objvTabFeatureENT.Memo = objvTabFeatureENS.Memo; //说明
objvTabFeatureENT.FldNum = objvTabFeatureENS.FldNum; //字段数
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
public static DataTable ToDataTable(List<clsvTabFeatureEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTabFeatureEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTabFeatureEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTabFeatureEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTabFeatureEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTabFeatureEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabFeatureWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabFeatureWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvTabFeatureEN._CurrTabName, strPrjId);
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
public static List<clsvTabFeatureEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabFeatureWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabFeatureWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvTabFeatureEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvTabFeatureEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convTabFeature.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvTabFeatureEN._CurrTabName, strPrjId);
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvTabFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeatureEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvTabFeatureEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabFeatureWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabFeatureWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvTabFeatureEN._CurrTabName, strPrjId);
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvTabFeatureObjLstCache = CacheHelper.Get<List<clsvTabFeatureEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvTabFeatureObjLstCache = CacheHelper.Get<List<clsvTabFeatureEN>>(strKey);
}
return arrvTabFeatureObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTabFeatureEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTabFeature.TabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.TabFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.OrderNum4Refer, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabFeature.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.ParentFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.ParentFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.FuncNameCs, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.FuncNameJs, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabFeature.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeature.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature.FldNum, Type.GetType("System.Int32"));
foreach (clsvTabFeatureEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTabFeature.TabFeatureId] = objInFor[convTabFeature.TabFeatureId];
objDR[convTabFeature.TabFeatureName] = objInFor[convTabFeature.TabFeatureName];
objDR[convTabFeature.TabId] = objInFor[convTabFeature.TabId];
objDR[convTabFeature.TabName] = objInFor[convTabFeature.TabName];
objDR[convTabFeature.TabCnName] = objInFor[convTabFeature.TabCnName];
objDR[convTabFeature.PrjName] = objInFor[convTabFeature.PrjName];
objDR[convTabFeature.SqlDsTypeName] = objInFor[convTabFeature.SqlDsTypeName];
objDR[convTabFeature.FuncModuleAgcId] = objInFor[convTabFeature.FuncModuleAgcId];
objDR[convTabFeature.FuncModuleName] = objInFor[convTabFeature.FuncModuleName];
objDR[convTabFeature.OrderNum4Refer] = objInFor[convTabFeature.OrderNum4Refer];
objDR[convTabFeature.FeatureId] = objInFor[convTabFeature.FeatureId];
objDR[convTabFeature.FeatureName] = objInFor[convTabFeature.FeatureName];
objDR[convTabFeature.ParentFeatureId] = objInFor[convTabFeature.ParentFeatureId];
objDR[convTabFeature.ParentFeatureName] = objInFor[convTabFeature.ParentFeatureName];
objDR[convTabFeature.FuncNameCs] = objInFor[convTabFeature.FuncNameCs];
objDR[convTabFeature.FuncNameJs] = objInFor[convTabFeature.FuncNameJs];
objDR[convTabFeature.OrderNum] = objInFor[convTabFeature.OrderNum];
objDR[convTabFeature.InUse] = objInFor[convTabFeature.InUse];
objDR[convTabFeature.PrjId] = objInFor[convTabFeature.PrjId];
objDR[convTabFeature.UpdUser] = objInFor[convTabFeature.UpdUser];
objDR[convTabFeature.UpdDate] = objInFor[convTabFeature.UpdDate];
objDR[convTabFeature.Memo] = objInFor[convTabFeature.Memo];
objDR[convTabFeature.FldNum] = objInFor[convTabFeature.FldNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}