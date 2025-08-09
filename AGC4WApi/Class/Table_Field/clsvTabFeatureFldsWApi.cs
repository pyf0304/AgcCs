
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureFldsWApi
 表名:vTabFeatureFlds(00050456)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:21
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
public static class  clsvTabFeatureFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetmId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, long lngmId, string strComparisonOp="")
	{
objvTabFeatureFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.mId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.mId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.mId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId">表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabFeatureId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convTabFeatureFlds.TabFeatureId);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convTabFeatureFlds.TabFeatureId);
objvTabFeatureFldsEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.TabFeatureId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.TabFeatureId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.TabFeatureId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureName">表功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabFeatureName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convTabFeatureFlds.TabFeatureName);
objvTabFeatureFldsEN.TabFeatureName = strTabFeatureName; //表功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.TabFeatureName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.TabFeatureName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.TabFeatureName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFeatureFlds.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFeatureFlds.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFeatureFlds.TabId);
objvTabFeatureFldsEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.TabId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.TabId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.TabId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convTabFeatureFlds.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convTabFeatureFlds.TabName);
objvTabFeatureFldsEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.TabName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.TabName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.TabName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabCnName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabFeatureFlds.TabCnName);
objvTabFeatureFldsEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.TabCnName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.TabCnName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.TabCnName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetPrjName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convTabFeatureFlds.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convTabFeatureFlds.PrjName);
objvTabFeatureFldsEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.PrjName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.PrjName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.PrjName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetSqlDsTypeName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeName, convTabFeatureFlds.SqlDsTypeName);
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convTabFeatureFlds.SqlDsTypeName);
objvTabFeatureFldsEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.SqlDsTypeName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.SqlDsTypeName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.SqlDsTypeName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFuncModuleAgcId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convTabFeatureFlds.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convTabFeatureFlds.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convTabFeatureFlds.FuncModuleAgcId);
objvTabFeatureFldsEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.FuncModuleAgcId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.FuncModuleAgcId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.FuncModuleAgcId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFuncModuleName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convTabFeatureFlds.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTabFeatureFlds.FuncModuleName);
objvTabFeatureFldsEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.FuncModuleName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.FuncModuleName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.FuncModuleName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetOrderNum4Refer(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objvTabFeatureFldsEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.OrderNum4Refer) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.OrderNum4Refer, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.OrderNum4Refer] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFeatureId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convTabFeatureFlds.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convTabFeatureFlds.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convTabFeatureFlds.FeatureId);
objvTabFeatureFldsEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.FeatureId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.FeatureId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.FeatureId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFeatureName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convTabFeatureFlds.FeatureName);
objvTabFeatureFldsEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.FeatureName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.FeatureName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.FeatureName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureId">父功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetParentFeatureId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strParentFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureId, 4, convTabFeatureFlds.ParentFeatureId);
clsCheckSql.CheckFieldForeignKey(strParentFeatureId, 4, convTabFeatureFlds.ParentFeatureId);
objvTabFeatureFldsEN.ParentFeatureId = strParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.ParentFeatureId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.ParentFeatureId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.ParentFeatureId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentFeatureName">父功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetParentFeatureName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strParentFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convTabFeatureFlds.ParentFeatureName);
objvTabFeatureFldsEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.ParentFeatureName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.ParentFeatureName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.ParentFeatureName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFldId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convTabFeatureFlds.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convTabFeatureFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convTabFeatureFlds.FldId);
objvTabFeatureFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.FldId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.FldId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.FldId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFldName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convTabFeatureFlds.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convTabFeatureFlds.FldName);
objvTabFeatureFldsEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.FldName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.FldName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.FldName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetCaption(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convTabFeatureFlds.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, convTabFeatureFlds.Caption);
objvTabFeatureFldsEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.Caption) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.Caption, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.Caption] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetDataTypeId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convTabFeatureFlds.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convTabFeatureFlds.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convTabFeatureFlds.DataTypeId);
objvTabFeatureFldsEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.DataTypeId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.DataTypeId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.DataTypeId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetDataTypeName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convTabFeatureFlds.DataTypeName);
objvTabFeatureFldsEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.DataTypeName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.DataTypeName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.DataTypeName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNull">是否可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetIsNull(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, bool bolIsNull, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNull, convTabFeatureFlds.IsNull);
objvTabFeatureFldsEN.IsNull = bolIsNull; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.IsNull) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.IsNull, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.IsNull] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFieldTypeId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convTabFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convTabFeatureFlds.FieldTypeId);
objvTabFeatureFldsEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.FieldTypeId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.FieldTypeId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.FieldTypeId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeName">字段类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFieldTypeName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convTabFeatureFlds.FieldTypeName);
objvTabFeatureFldsEN.FieldTypeName = strFieldTypeName; //字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.FieldTypeName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.FieldTypeName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.FieldTypeName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFuncName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName, 100, convTabFeatureFlds.FuncName);
objvTabFeatureFldsEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.FuncName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.FuncName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.FuncName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeId">给值方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetValueGivingModeId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strValueGivingModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convTabFeatureFlds.ValueGivingModeId);
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convTabFeatureFlds.ValueGivingModeId);
objvTabFeatureFldsEN.ValueGivingModeId = strValueGivingModeId; //给值方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.ValueGivingModeId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.ValueGivingModeId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.ValueGivingModeId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeName">给值方式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetValueGivingModeName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strValueGivingModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeName, 50, convTabFeatureFlds.ValueGivingModeName);
objvTabFeatureFldsEN.ValueGivingModeName = strValueGivingModeName; //给值方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.ValueGivingModeName) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.ValueGivingModeName, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.ValueGivingModeName] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetDefaultValue(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convTabFeatureFlds.DefaultValue);
objvTabFeatureFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.DefaultValue) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.DefaultValue, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.DefaultValue] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetPrjId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFeatureFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFeatureFlds.PrjId);
objvTabFeatureFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.PrjId) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.PrjId, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.PrjId] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetOrderNum(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convTabFeatureFlds.OrderNum);
objvTabFeatureFldsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.OrderNum) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.OrderNum, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.OrderNum] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetInUse(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, bool bolInUse, string strComparisonOp="")
	{
objvTabFeatureFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.InUse) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.InUse, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.InUse] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetUpdUser(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTabFeatureFlds.UpdUser);
objvTabFeatureFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.UpdUser) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.UpdUser, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.UpdUser] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetUpdDate(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTabFeatureFlds.UpdDate);
objvTabFeatureFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.UpdDate) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.UpdDate, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.UpdDate] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetMemo(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFeatureFlds.Memo);
objvTabFeatureFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds.Memo) == false)
{
objvTabFeatureFldsEN.dicFldComparisonOp.Add(convTabFeatureFlds.Memo, strComparisonOp);
}
else
{
objvTabFeatureFldsEN.dicFldComparisonOp[convTabFeatureFlds.Memo] = strComparisonOp;
}
}
return objvTabFeatureFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTabFeatureFldsEN objvTabFeatureFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.mId) == true)
{
string strComparisonOpmId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFeatureFlds.mId, objvTabFeatureFldsCond.mId, strComparisonOpmId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.TabFeatureId, objvTabFeatureFldsCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.TabFeatureName) == true)
{
string strComparisonOpTabFeatureName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.TabFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.TabFeatureName, objvTabFeatureFldsCond.TabFeatureName, strComparisonOpTabFeatureName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.TabId) == true)
{
string strComparisonOpTabId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.TabId, objvTabFeatureFldsCond.TabId, strComparisonOpTabId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.TabName) == true)
{
string strComparisonOpTabName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.TabName, objvTabFeatureFldsCond.TabName, strComparisonOpTabName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.TabCnName) == true)
{
string strComparisonOpTabCnName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.TabCnName, objvTabFeatureFldsCond.TabCnName, strComparisonOpTabCnName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.PrjName) == true)
{
string strComparisonOpPrjName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.PrjName, objvTabFeatureFldsCond.PrjName, strComparisonOpPrjName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.SqlDsTypeName, objvTabFeatureFldsCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.FuncModuleAgcId, objvTabFeatureFldsCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.FuncModuleName, objvTabFeatureFldsCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFeatureFlds.OrderNum4Refer, objvTabFeatureFldsCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.FeatureId) == true)
{
string strComparisonOpFeatureId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.FeatureId, objvTabFeatureFldsCond.FeatureId, strComparisonOpFeatureId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.FeatureName) == true)
{
string strComparisonOpFeatureName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.FeatureName, objvTabFeatureFldsCond.FeatureName, strComparisonOpFeatureName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.ParentFeatureId) == true)
{
string strComparisonOpParentFeatureId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.ParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.ParentFeatureId, objvTabFeatureFldsCond.ParentFeatureId, strComparisonOpParentFeatureId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.ParentFeatureName, objvTabFeatureFldsCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.FldId) == true)
{
string strComparisonOpFldId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.FldId, objvTabFeatureFldsCond.FldId, strComparisonOpFldId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.FldName) == true)
{
string strComparisonOpFldName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.FldName, objvTabFeatureFldsCond.FldName, strComparisonOpFldName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.Caption) == true)
{
string strComparisonOpCaption = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.Caption, objvTabFeatureFldsCond.Caption, strComparisonOpCaption);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.DataTypeId, objvTabFeatureFldsCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.DataTypeName, objvTabFeatureFldsCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.IsNull) == true)
{
if (objvTabFeatureFldsCond.IsNull == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeatureFlds.IsNull);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeatureFlds.IsNull);
}
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.FieldTypeId, objvTabFeatureFldsCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.FieldTypeName) == true)
{
string strComparisonOpFieldTypeName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.FieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.FieldTypeName, objvTabFeatureFldsCond.FieldTypeName, strComparisonOpFieldTypeName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.FuncName) == true)
{
string strComparisonOpFuncName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.FuncName, objvTabFeatureFldsCond.FuncName, strComparisonOpFuncName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.ValueGivingModeId) == true)
{
string strComparisonOpValueGivingModeId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.ValueGivingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.ValueGivingModeId, objvTabFeatureFldsCond.ValueGivingModeId, strComparisonOpValueGivingModeId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.ValueGivingModeName) == true)
{
string strComparisonOpValueGivingModeName = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.ValueGivingModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.ValueGivingModeName, objvTabFeatureFldsCond.ValueGivingModeName, strComparisonOpValueGivingModeName);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.DefaultValue, objvTabFeatureFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.PrjId) == true)
{
string strComparisonOpPrjId = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.PrjId, objvTabFeatureFldsCond.PrjId, strComparisonOpPrjId);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.OrderNum) == true)
{
string strComparisonOpOrderNum = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFeatureFlds.OrderNum, objvTabFeatureFldsCond.OrderNum, strComparisonOpOrderNum);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.InUse) == true)
{
if (objvTabFeatureFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeatureFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeatureFlds.InUse);
}
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.UpdUser, objvTabFeatureFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.UpdDate, objvTabFeatureFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvTabFeatureFldsCond.IsUpdated(convTabFeatureFlds.Memo) == true)
{
string strComparisonOpMemo = objvTabFeatureFldsCond.dicFldComparisonOp[convTabFeatureFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds.Memo, objvTabFeatureFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 获取唯一性条件串--vTabFeatureFlds(v表功能字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabFeatureId_FldId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvTabFeatureFldsEN == null) return "";
if (objvTabFeatureFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFldsEN.TabFeatureId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFldsEN.FldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvTabFeatureFldsEN.mId);
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFldsEN.TabFeatureId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFldsEN.FldId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// v表功能字段(vTabFeatureFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTabFeatureFldsWApi
{
private static readonly string mstrApiControllerName = "vTabFeatureFldsApi";

 public clsvTabFeatureFldsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeatureFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvTabFeatureFldsEN objvTabFeatureFldsEN;
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
objvTabFeatureFldsEN = JsonConvert.DeserializeObject<clsvTabFeatureFldsEN>(strJson);
return objvTabFeatureFldsEN;
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
public static clsvTabFeatureFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvTabFeatureFldsEN objvTabFeatureFldsEN;
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
objvTabFeatureFldsEN = JsonConvert.DeserializeObject<clsvTabFeatureFldsEN>(strJson);
return objvTabFeatureFldsEN;
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
public static clsvTabFeatureFldsEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLst_Sel =
from objvTabFeatureFldsEN in arrvTabFeatureFldsObjLstCache
where objvTabFeatureFldsEN.mId == lngmId 
select objvTabFeatureFldsEN;
if (arrvTabFeatureFldsObjLst_Sel.Count() == 0)
{
   clsvTabFeatureFldsEN obj = clsvTabFeatureFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTabFeatureFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFldsEN> GetObjLst(string strWhereCond)
{
 List<clsvTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFldsEN>>(strJson);
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
public static List<clsvTabFeatureFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFldsEN>>(strJson);
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
public static IEnumerable<clsvTabFeatureFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLst_Sel =
from objvTabFeatureFldsEN in arrvTabFeatureFldsObjLstCache
where arrMId.Contains(objvTabFeatureFldsEN.mId)
select objvTabFeatureFldsEN;
return arrvTabFeatureFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFldsEN>>(strJson);
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
public static List<clsvTabFeatureFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFldsEN>>(strJson);
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
public static List<clsvTabFeatureFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFldsEN>>(strJson);
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
public static List<clsvTabFeatureFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFldsEN>>(strJson);
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
 /// <param name = "objvTabFeatureFldsENS">源对象</param>
 /// <param name = "objvTabFeatureFldsENT">目标对象</param>
 public static void CopyTo(clsvTabFeatureFldsEN objvTabFeatureFldsENS, clsvTabFeatureFldsEN objvTabFeatureFldsENT)
{
try
{
objvTabFeatureFldsENT.mId = objvTabFeatureFldsENS.mId; //mId
objvTabFeatureFldsENT.TabFeatureId = objvTabFeatureFldsENS.TabFeatureId; //表功能Id
objvTabFeatureFldsENT.TabFeatureName = objvTabFeatureFldsENS.TabFeatureName; //表功能名
objvTabFeatureFldsENT.TabId = objvTabFeatureFldsENS.TabId; //表ID
objvTabFeatureFldsENT.TabName = objvTabFeatureFldsENS.TabName; //表名
objvTabFeatureFldsENT.TabCnName = objvTabFeatureFldsENS.TabCnName; //表中文名
objvTabFeatureFldsENT.PrjName = objvTabFeatureFldsENS.PrjName; //工程名称
objvTabFeatureFldsENT.SqlDsTypeName = objvTabFeatureFldsENS.SqlDsTypeName; //Sql数据源名
objvTabFeatureFldsENT.FuncModuleAgcId = objvTabFeatureFldsENS.FuncModuleAgcId; //功能模块Id
objvTabFeatureFldsENT.FuncModuleName = objvTabFeatureFldsENS.FuncModuleName; //功能模块名称
objvTabFeatureFldsENT.OrderNum4Refer = objvTabFeatureFldsENS.OrderNum4Refer; //引用序号
objvTabFeatureFldsENT.FeatureId = objvTabFeatureFldsENS.FeatureId; //功能Id
objvTabFeatureFldsENT.FeatureName = objvTabFeatureFldsENS.FeatureName; //功能名称
objvTabFeatureFldsENT.ParentFeatureId = objvTabFeatureFldsENS.ParentFeatureId; //父功能Id
objvTabFeatureFldsENT.ParentFeatureName = objvTabFeatureFldsENS.ParentFeatureName; //父功能名
objvTabFeatureFldsENT.FldId = objvTabFeatureFldsENS.FldId; //字段Id
objvTabFeatureFldsENT.FldName = objvTabFeatureFldsENS.FldName; //字段名
objvTabFeatureFldsENT.Caption = objvTabFeatureFldsENS.Caption; //标题
objvTabFeatureFldsENT.DataTypeId = objvTabFeatureFldsENS.DataTypeId; //数据类型Id
objvTabFeatureFldsENT.DataTypeName = objvTabFeatureFldsENS.DataTypeName; //数据类型名称
objvTabFeatureFldsENT.IsNull = objvTabFeatureFldsENS.IsNull; //是否可空
objvTabFeatureFldsENT.FieldTypeId = objvTabFeatureFldsENS.FieldTypeId; //字段类型Id
objvTabFeatureFldsENT.FieldTypeName = objvTabFeatureFldsENS.FieldTypeName; //字段类型名
objvTabFeatureFldsENT.FuncName = objvTabFeatureFldsENS.FuncName; //函数名
objvTabFeatureFldsENT.ValueGivingModeId = objvTabFeatureFldsENS.ValueGivingModeId; //给值方式Id
objvTabFeatureFldsENT.ValueGivingModeName = objvTabFeatureFldsENS.ValueGivingModeName; //给值方式名
objvTabFeatureFldsENT.DefaultValue = objvTabFeatureFldsENS.DefaultValue; //缺省值
objvTabFeatureFldsENT.PrjId = objvTabFeatureFldsENS.PrjId; //工程Id
objvTabFeatureFldsENT.OrderNum = objvTabFeatureFldsENS.OrderNum; //序号
objvTabFeatureFldsENT.InUse = objvTabFeatureFldsENS.InUse; //是否在用
objvTabFeatureFldsENT.UpdUser = objvTabFeatureFldsENS.UpdUser; //修改者
objvTabFeatureFldsENT.UpdDate = objvTabFeatureFldsENS.UpdDate; //修改日期
objvTabFeatureFldsENT.Memo = objvTabFeatureFldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvTabFeatureFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTabFeatureFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTabFeatureFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTabFeatureFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTabFeatureFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTabFeatureFldsEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabFeatureFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabFeatureFldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvTabFeatureFldsEN._CurrTabName, strPrjId);
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
public static List<clsvTabFeatureFldsEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabFeatureFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabFeatureFldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvTabFeatureFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvTabFeatureFldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convTabFeatureFlds.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvTabFeatureFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeatureFldsEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvTabFeatureFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvTabFeatureFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvTabFeatureFldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvTabFeatureFldsObjLstCache = CacheHelper.Get<List<clsvTabFeatureFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvTabFeatureFldsObjLstCache = CacheHelper.Get<List<clsvTabFeatureFldsEN>>(strKey);
}
return arrvTabFeatureFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTabFeatureFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTabFeatureFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convTabFeatureFlds.TabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.TabFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.OrderNum4Refer, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabFeatureFlds.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.ParentFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.ParentFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.IsNull, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeatureFlds.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.FieldTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.ValueGivingModeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.ValueGivingModeName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabFeatureFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeatureFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds.Memo, Type.GetType("System.String"));
foreach (clsvTabFeatureFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTabFeatureFlds.mId] = objInFor[convTabFeatureFlds.mId];
objDR[convTabFeatureFlds.TabFeatureId] = objInFor[convTabFeatureFlds.TabFeatureId];
objDR[convTabFeatureFlds.TabFeatureName] = objInFor[convTabFeatureFlds.TabFeatureName];
objDR[convTabFeatureFlds.TabId] = objInFor[convTabFeatureFlds.TabId];
objDR[convTabFeatureFlds.TabName] = objInFor[convTabFeatureFlds.TabName];
objDR[convTabFeatureFlds.TabCnName] = objInFor[convTabFeatureFlds.TabCnName];
objDR[convTabFeatureFlds.PrjName] = objInFor[convTabFeatureFlds.PrjName];
objDR[convTabFeatureFlds.SqlDsTypeName] = objInFor[convTabFeatureFlds.SqlDsTypeName];
objDR[convTabFeatureFlds.FuncModuleAgcId] = objInFor[convTabFeatureFlds.FuncModuleAgcId];
objDR[convTabFeatureFlds.FuncModuleName] = objInFor[convTabFeatureFlds.FuncModuleName];
objDR[convTabFeatureFlds.OrderNum4Refer] = objInFor[convTabFeatureFlds.OrderNum4Refer];
objDR[convTabFeatureFlds.FeatureId] = objInFor[convTabFeatureFlds.FeatureId];
objDR[convTabFeatureFlds.FeatureName] = objInFor[convTabFeatureFlds.FeatureName];
objDR[convTabFeatureFlds.ParentFeatureId] = objInFor[convTabFeatureFlds.ParentFeatureId];
objDR[convTabFeatureFlds.ParentFeatureName] = objInFor[convTabFeatureFlds.ParentFeatureName];
objDR[convTabFeatureFlds.FldId] = objInFor[convTabFeatureFlds.FldId];
objDR[convTabFeatureFlds.FldName] = objInFor[convTabFeatureFlds.FldName];
objDR[convTabFeatureFlds.Caption] = objInFor[convTabFeatureFlds.Caption];
objDR[convTabFeatureFlds.DataTypeId] = objInFor[convTabFeatureFlds.DataTypeId];
objDR[convTabFeatureFlds.DataTypeName] = objInFor[convTabFeatureFlds.DataTypeName];
objDR[convTabFeatureFlds.IsNull] = objInFor[convTabFeatureFlds.IsNull];
objDR[convTabFeatureFlds.FieldTypeId] = objInFor[convTabFeatureFlds.FieldTypeId];
objDR[convTabFeatureFlds.FieldTypeName] = objInFor[convTabFeatureFlds.FieldTypeName];
objDR[convTabFeatureFlds.FuncName] = objInFor[convTabFeatureFlds.FuncName];
objDR[convTabFeatureFlds.ValueGivingModeId] = objInFor[convTabFeatureFlds.ValueGivingModeId];
objDR[convTabFeatureFlds.ValueGivingModeName] = objInFor[convTabFeatureFlds.ValueGivingModeName];
objDR[convTabFeatureFlds.DefaultValue] = objInFor[convTabFeatureFlds.DefaultValue];
objDR[convTabFeatureFlds.PrjId] = objInFor[convTabFeatureFlds.PrjId];
objDR[convTabFeatureFlds.OrderNum] = objInFor[convTabFeatureFlds.OrderNum];
objDR[convTabFeatureFlds.InUse] = objInFor[convTabFeatureFlds.InUse];
objDR[convTabFeatureFlds.UpdUser] = objInFor[convTabFeatureFlds.UpdUser];
objDR[convTabFeatureFlds.UpdDate] = objInFor[convTabFeatureFlds.UpdDate];
objDR[convTabFeatureFlds.Memo] = objInFor[convTabFeatureFlds.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}