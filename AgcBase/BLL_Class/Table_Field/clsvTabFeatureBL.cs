
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureBL
 表名:vTabFeature(00050464)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvTabFeatureBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeatureEN GetObj(this K_TabFeatureId_vTabFeature myKey)
{
clsvTabFeatureEN objvTabFeatureEN = clsvTabFeatureBL.vTabFeatureDA.GetObjByTabFeatureId(myKey.Value);
return objvTabFeatureEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabFeatureId(this clsvTabFeatureEN objvTabFeatureEN, string strTabFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convTabFeature.TabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convTabFeature.TabFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabFeatureName(this clsvTabFeatureEN objvTabFeatureEN, string strTabFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convTabFeature.TabFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabId(this clsvTabFeatureEN objvTabFeatureEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFeature.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFeature.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFeature.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabName(this clsvTabFeatureEN objvTabFeatureEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convTabFeature.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convTabFeature.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetTabCnName(this clsvTabFeatureEN objvTabFeatureEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabFeature.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetPrjName(this clsvTabFeatureEN objvTabFeatureEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convTabFeature.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convTabFeature.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetSqlDsTypeName(this clsvTabFeatureEN objvTabFeatureEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeName, convTabFeature.SqlDsTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convTabFeature.SqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFuncModuleAgcId(this clsvTabFeatureEN objvTabFeatureEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convTabFeature.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convTabFeature.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convTabFeature.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFuncModuleName(this clsvTabFeatureEN objvTabFeatureEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convTabFeature.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTabFeature.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetOrderNum4Refer(this clsvTabFeatureEN objvTabFeatureEN, int? intOrderNum4Refer, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFeatureId(this clsvTabFeatureEN objvTabFeatureEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convTabFeature.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convTabFeature.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convTabFeature.FeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFeatureName(this clsvTabFeatureEN objvTabFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convTabFeature.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convTabFeature.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetParentFeatureId(this clsvTabFeatureEN objvTabFeatureEN, string strParentFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureId, 4, convTabFeature.ParentFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentFeatureId, 4, convTabFeature.ParentFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetParentFeatureName(this clsvTabFeatureEN objvTabFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convTabFeature.ParentFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFuncNameCs(this clsvTabFeatureEN objvTabFeatureEN, string strFuncNameCs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncNameCs, 100, convTabFeature.FuncNameCs);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFuncNameJs(this clsvTabFeatureEN objvTabFeatureEN, string strFuncNameJs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncNameJs, 100, convTabFeature.FuncNameJs);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetPrjId(this clsvTabFeatureEN objvTabFeatureEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFeature.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFeature.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetUpdUser(this clsvTabFeatureEN objvTabFeatureEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTabFeature.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetUpdDate(this clsvTabFeatureEN objvTabFeatureEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTabFeature.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetMemo(this clsvTabFeatureEN objvTabFeatureEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFeature.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureEN SetFldNum(this clsvTabFeatureEN objvTabFeatureEN, int? intFldNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTabFeatureENS">源对象</param>
 /// <param name = "objvTabFeatureENT">目标对象</param>
 public static void CopyTo(this clsvTabFeatureEN objvTabFeatureENS, clsvTabFeatureEN objvTabFeatureENT)
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
 /// <param name = "objvTabFeatureENS">源对象</param>
 /// <returns>目标对象=>clsvTabFeatureEN:objvTabFeatureENT</returns>
 public static clsvTabFeatureEN CopyTo(this clsvTabFeatureEN objvTabFeatureENS)
{
try
{
 clsvTabFeatureEN objvTabFeatureENT = new clsvTabFeatureEN()
{
TabFeatureId = objvTabFeatureENS.TabFeatureId, //表功能Id
TabFeatureName = objvTabFeatureENS.TabFeatureName, //表功能名
TabId = objvTabFeatureENS.TabId, //表ID
TabName = objvTabFeatureENS.TabName, //表名
TabCnName = objvTabFeatureENS.TabCnName, //表中文名
PrjName = objvTabFeatureENS.PrjName, //工程名称
SqlDsTypeName = objvTabFeatureENS.SqlDsTypeName, //Sql数据源名
FuncModuleAgcId = objvTabFeatureENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvTabFeatureENS.FuncModuleName, //功能模块名称
OrderNum4Refer = objvTabFeatureENS.OrderNum4Refer, //引用序号
FeatureId = objvTabFeatureENS.FeatureId, //功能Id
FeatureName = objvTabFeatureENS.FeatureName, //功能名称
ParentFeatureId = objvTabFeatureENS.ParentFeatureId, //父功能Id
ParentFeatureName = objvTabFeatureENS.ParentFeatureName, //父功能名
FuncNameCs = objvTabFeatureENS.FuncNameCs, //Cs函数名
FuncNameJs = objvTabFeatureENS.FuncNameJs, //Js函数名
OrderNum = objvTabFeatureENS.OrderNum, //序号
InUse = objvTabFeatureENS.InUse, //是否在用
PrjId = objvTabFeatureENS.PrjId, //工程Id
UpdUser = objvTabFeatureENS.UpdUser, //修改者
UpdDate = objvTabFeatureENS.UpdDate, //修改日期
Memo = objvTabFeatureENS.Memo, //说明
FldNum = objvTabFeatureENS.FldNum, //字段数
};
 return objvTabFeatureENT;
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
public static void CheckProperty4Condition(this clsvTabFeatureEN objvTabFeatureEN)
{
 clsvTabFeatureBL.vTabFeatureDA.CheckProperty4Condition(objvTabFeatureEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTabFeature
{
public virtual bool UpdRelaTabDate(string strTabFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v表功能(vTabFeature)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTabFeatureBL
{
public static RelatedActions_vTabFeature relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTabFeatureDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTabFeatureDA vTabFeatureDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTabFeatureDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTabFeatureBL()
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
if (string.IsNullOrEmpty(clsvTabFeatureEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFeatureEN._ConnectString);
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
public static DataTable GetDataTable_vTabFeature(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabFeatureDA.GetDataTable_vTabFeature(strWhereCond);
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
objDT = vTabFeatureDA.GetDataTable(strWhereCond);
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
objDT = vTabFeatureDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTabFeatureDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTabFeatureDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTabFeatureDA.GetDataTable_Top(objTopPara);
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
objDT = vTabFeatureDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTabFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTabFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTabFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTabFeatureEN> GetObjLstByTabFeatureIdLst(List<string> arrTabFeatureIdLst)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabFeatureIdLst, true);
 string strWhereCond = string.Format("TabFeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTabFeatureEN> GetObjLstByTabFeatureIdLstCache(List<string> arrTabFeatureIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvTabFeatureEN._CurrTabName, strPrjId);
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureEN> arrvTabFeatureObjLst_Sel =
arrvTabFeatureObjLstCache
.Where(x => arrTabFeatureIdLst.Contains(x.TabFeatureId));
return arrvTabFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureEN> GetObjLst(string strWhereCond)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
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
public static List<clsvTabFeatureEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTabFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTabFeatureEN> GetSubObjLstCache(clsvTabFeatureEN objvTabFeatureCond)
{
 string strPrjId = objvTabFeatureCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvTabFeatureBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvTabFeatureEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFeature._AttributeName)
{
if (objvTabFeatureCond.IsUpdated(strFldName) == false) continue;
if (objvTabFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureCond[strFldName].ToString());
}
else
{
if (objvTabFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFeatureCond[strFldName]));
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
public static List<clsvTabFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
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
public static List<clsvTabFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
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
List<clsvTabFeatureEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTabFeatureEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTabFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
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
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
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
public static List<clsvTabFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTabFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
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
public static List<clsvTabFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTabFeatureEN> arrObjLst = new List<clsvTabFeatureEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureEN objvTabFeatureEN = new clsvTabFeatureEN();
try
{
objvTabFeatureEN.TabFeatureId = objRow[convTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureEN.TabFeatureName = objRow[convTabFeature.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureEN.TabId = objRow[convTabFeature.TabId].ToString().Trim(); //表ID
objvTabFeatureEN.TabName = objRow[convTabFeature.TabName].ToString().Trim(); //表名
objvTabFeatureEN.TabCnName = objRow[convTabFeature.TabCnName] == DBNull.Value ? null : objRow[convTabFeature.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureEN.PrjName = objRow[convTabFeature.PrjName].ToString().Trim(); //工程名称
objvTabFeatureEN.SqlDsTypeName = objRow[convTabFeature.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureEN.FuncModuleAgcId = objRow[convTabFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureEN.FuncModuleName = objRow[convTabFeature.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureEN.OrderNum4Refer = objRow[convTabFeature.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureEN.FeatureId = objRow[convTabFeature.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureEN.FeatureName = objRow[convTabFeature.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureEN.ParentFeatureId = objRow[convTabFeature.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureEN.ParentFeatureName = objRow[convTabFeature.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeature.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureEN.FuncNameCs = objRow[convTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeatureEN.FuncNameJs = objRow[convTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[convTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeatureEN.OrderNum = Int32.Parse(objRow[convTabFeature.OrderNum].ToString().Trim()); //序号
objvTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature.InUse].ToString().Trim()); //是否在用
objvTabFeatureEN.PrjId = objRow[convTabFeature.PrjId] == DBNull.Value ? null : objRow[convTabFeature.PrjId].ToString().Trim(); //工程Id
objvTabFeatureEN.UpdUser = objRow[convTabFeature.UpdUser] == DBNull.Value ? null : objRow[convTabFeature.UpdUser].ToString().Trim(); //修改者
objvTabFeatureEN.UpdDate = objRow[convTabFeature.UpdDate] == DBNull.Value ? null : objRow[convTabFeature.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureEN.Memo = objRow[convTabFeature.Memo] == DBNull.Value ? null : objRow[convTabFeature.Memo].ToString().Trim(); //说明
objvTabFeatureEN.FldNum = objRow[convTabFeature.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeature.FldNum].ToString().Trim()); //字段数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTabFeatureEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTabFeature(ref clsvTabFeatureEN objvTabFeatureEN)
{
bool bolResult = vTabFeatureDA.GetvTabFeature(ref objvTabFeatureEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeatureEN GetObjByTabFeatureId(string strTabFeatureId)
{
if (strTabFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTabFeatureEN objvTabFeatureEN = vTabFeatureDA.GetObjByTabFeatureId(strTabFeatureId);
return objvTabFeatureEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTabFeatureEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTabFeatureEN objvTabFeatureEN = vTabFeatureDA.GetFirstObj(strWhereCond);
 return objvTabFeatureEN;
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
public static clsvTabFeatureEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTabFeatureEN objvTabFeatureEN = vTabFeatureDA.GetObjByDataRow(objRow);
 return objvTabFeatureEN;
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
public static clsvTabFeatureEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTabFeatureEN objvTabFeatureEN = vTabFeatureDA.GetObjByDataRow(objRow);
 return objvTabFeatureEN;
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
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <param name = "lstvTabFeatureObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFeatureEN GetObjByTabFeatureIdFromList(string strTabFeatureId, List<clsvTabFeatureEN> lstvTabFeatureObjLst)
{
foreach (clsvTabFeatureEN objvTabFeatureEN in lstvTabFeatureObjLst)
{
if (objvTabFeatureEN.TabFeatureId == strTabFeatureId)
{
return objvTabFeatureEN;
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
 string strTabFeatureId;
 try
 {
 strTabFeatureId = new clsvTabFeatureDA().GetFirstID(strWhereCond);
 return strTabFeatureId;
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
 arrList = vTabFeatureDA.GetID(strWhereCond);
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
bool bolIsExist = vTabFeatureDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabFeatureId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTabFeatureDA.IsExist(strTabFeatureId);
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
 bolIsExist = clsvTabFeatureDA.IsExistTable();
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
 bolIsExist = vTabFeatureDA.IsExistTable(strTabName);
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
 /// <param name = "objvTabFeatureEN">源简化对象</param>
 public static void SetUpdFlag(clsvTabFeatureEN objvTabFeatureEN)
{
try
{
objvTabFeatureEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTabFeatureEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTabFeature.TabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.TabFeatureId = objvTabFeatureEN.TabFeatureId; //表功能Id
}
if (arrFldSet.Contains(convTabFeature.TabFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.TabFeatureName = objvTabFeatureEN.TabFeatureName == "[null]" ? null :  objvTabFeatureEN.TabFeatureName; //表功能名
}
if (arrFldSet.Contains(convTabFeature.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.TabId = objvTabFeatureEN.TabId; //表ID
}
if (arrFldSet.Contains(convTabFeature.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.TabName = objvTabFeatureEN.TabName; //表名
}
if (arrFldSet.Contains(convTabFeature.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.TabCnName = objvTabFeatureEN.TabCnName == "[null]" ? null :  objvTabFeatureEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convTabFeature.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.PrjName = objvTabFeatureEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convTabFeature.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.SqlDsTypeName = objvTabFeatureEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convTabFeature.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.FuncModuleAgcId = objvTabFeatureEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convTabFeature.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.FuncModuleName = objvTabFeatureEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convTabFeature.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.OrderNum4Refer = objvTabFeatureEN.OrderNum4Refer; //引用序号
}
if (arrFldSet.Contains(convTabFeature.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.FeatureId = objvTabFeatureEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convTabFeature.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.FeatureName = objvTabFeatureEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convTabFeature.ParentFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.ParentFeatureId = objvTabFeatureEN.ParentFeatureId == "[null]" ? null :  objvTabFeatureEN.ParentFeatureId; //父功能Id
}
if (arrFldSet.Contains(convTabFeature.ParentFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.ParentFeatureName = objvTabFeatureEN.ParentFeatureName == "[null]" ? null :  objvTabFeatureEN.ParentFeatureName; //父功能名
}
if (arrFldSet.Contains(convTabFeature.FuncNameCs, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.FuncNameCs = objvTabFeatureEN.FuncNameCs == "[null]" ? null :  objvTabFeatureEN.FuncNameCs; //Cs函数名
}
if (arrFldSet.Contains(convTabFeature.FuncNameJs, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.FuncNameJs = objvTabFeatureEN.FuncNameJs == "[null]" ? null :  objvTabFeatureEN.FuncNameJs; //Js函数名
}
if (arrFldSet.Contains(convTabFeature.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.OrderNum = objvTabFeatureEN.OrderNum; //序号
}
if (arrFldSet.Contains(convTabFeature.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.InUse = objvTabFeatureEN.InUse; //是否在用
}
if (arrFldSet.Contains(convTabFeature.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.PrjId = objvTabFeatureEN.PrjId == "[null]" ? null :  objvTabFeatureEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convTabFeature.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.UpdUser = objvTabFeatureEN.UpdUser == "[null]" ? null :  objvTabFeatureEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convTabFeature.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.UpdDate = objvTabFeatureEN.UpdDate == "[null]" ? null :  objvTabFeatureEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convTabFeature.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.Memo = objvTabFeatureEN.Memo == "[null]" ? null :  objvTabFeatureEN.Memo; //说明
}
if (arrFldSet.Contains(convTabFeature.FldNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureEN.FldNum = objvTabFeatureEN.FldNum; //字段数
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
 /// <param name = "objvTabFeatureEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTabFeatureEN objvTabFeatureEN)
{
try
{
if (objvTabFeatureEN.TabFeatureName == "[null]") objvTabFeatureEN.TabFeatureName = null; //表功能名
if (objvTabFeatureEN.TabCnName == "[null]") objvTabFeatureEN.TabCnName = null; //表中文名
if (objvTabFeatureEN.ParentFeatureId == "[null]") objvTabFeatureEN.ParentFeatureId = null; //父功能Id
if (objvTabFeatureEN.ParentFeatureName == "[null]") objvTabFeatureEN.ParentFeatureName = null; //父功能名
if (objvTabFeatureEN.FuncNameCs == "[null]") objvTabFeatureEN.FuncNameCs = null; //Cs函数名
if (objvTabFeatureEN.FuncNameJs == "[null]") objvTabFeatureEN.FuncNameJs = null; //Js函数名
if (objvTabFeatureEN.PrjId == "[null]") objvTabFeatureEN.PrjId = null; //工程Id
if (objvTabFeatureEN.UpdUser == "[null]") objvTabFeatureEN.UpdUser = null; //修改者
if (objvTabFeatureEN.UpdDate == "[null]") objvTabFeatureEN.UpdDate = null; //修改日期
if (objvTabFeatureEN.Memo == "[null]") objvTabFeatureEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvTabFeatureEN objvTabFeatureEN)
{
 vTabFeatureDA.CheckProperty4Condition(objvTabFeatureEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_TabFeatureId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convTabFeature.TabFeatureId); 
List<clsvTabFeatureEN> arrObjLst = clsvTabFeatureBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_TabFeatureId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v表功能]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convTabFeature.TabFeatureId); 
IEnumerable<clsvTabFeatureEN> arrObjLst = clsvTabFeatureBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convTabFeature.TabFeatureId;
objDDL.DataTextField = convTabFeature.TabFeatureName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabFeatureIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v表功能]...","0");
List<clsvTabFeatureEN> arrvTabFeatureObjLst = GetAllvTabFeatureObjLstCache(strPrjId); 
arrvTabFeatureObjLst = arrvTabFeatureObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = convTabFeature.TabFeatureId;
objDDL.DataTextField = convTabFeature.TabFeatureName;
objDDL.DataSource = arrvTabFeatureObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFeatureBL没有刷新缓存机制(clsTabFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabStateBL没有刷新缓存机制(clsTabStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabTypeBL没有刷新缓存机制(clsTabTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabMainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabMainTypeBL没有刷新缓存机制(clsTabMainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSoftStructureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSoftStructureBL没有刷新缓存机制(clsSoftStructureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabFeatureId");
//if (arrvTabFeatureObjLstCache == null)
//{
//arrvTabFeatureObjLstCache = vTabFeatureDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFeatureEN GetObjByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvTabFeatureEN._CurrTabName, strPrjId);
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureEN> arrvTabFeatureObjLst_Sel =
arrvTabFeatureObjLstCache
.Where(x=> x.TabFeatureId == strTabFeatureId 
);
if (arrvTabFeatureObjLst_Sel.Count() == 0)
{
   clsvTabFeatureEN obj = clsvTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabFeatureId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvTabFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabFeatureNameByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return "";
//获取缓存中的对象列表
clsvTabFeatureEN objvTabFeature = GetObjByTabFeatureIdCache(strTabFeatureId, strPrjId);
if (objvTabFeature == null) return "";
return objvTabFeature.TabFeatureName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return "";
//获取缓存中的对象列表
clsvTabFeatureEN objvTabFeature = GetObjByTabFeatureIdCache(strTabFeatureId, strPrjId);
if (objvTabFeature == null) return "";
return objvTabFeature.TabFeatureName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeatureEN> GetAllvTabFeatureObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = GetObjLstCache(strPrjId); 
return arrvTabFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeatureEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvTabFeatureEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvTabFeatureEN> arrvTabFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvTabFeatureObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvTabFeatureEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvTabFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvTabFeatureEN._RefreshTimeLst.Count == 0) return "";
return clsvTabFeatureEN._RefreshTimeLst[clsvTabFeatureEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strTabFeatureId, string strPrjId)
{
if (strInFldName != convTabFeature.TabFeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTabFeature._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTabFeature._AttributeName));
throw new Exception(strMsg);
}
var objvTabFeature = clsvTabFeatureBL.GetObjByTabFeatureIdCache(strTabFeatureId, strPrjId);
if (objvTabFeature == null) return "";
return objvTabFeature[strOutFldName].ToString();
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
int intRecCount = clsvTabFeatureDA.GetRecCount(strTabName);
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
int intRecCount = clsvTabFeatureDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTabFeatureDA.GetRecCount();
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
int intRecCount = clsvTabFeatureDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTabFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTabFeatureEN objvTabFeatureCond)
{
 string strPrjId = objvTabFeatureCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvTabFeatureBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvTabFeatureEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFeature._AttributeName)
{
if (objvTabFeatureCond.IsUpdated(strFldName) == false) continue;
if (objvTabFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureCond[strFldName].ToString());
}
else
{
if (objvTabFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFeatureCond[strFldName]));
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
 List<string> arrList = clsvTabFeatureDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTabFeatureDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTabFeatureDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}