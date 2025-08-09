
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureFldsBL
 表名:vTabFeatureFlds(00050456)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvTabFeatureFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeatureFldsEN GetObj(this K_mId_vTabFeatureFlds myKey)
{
clsvTabFeatureFldsEN objvTabFeatureFldsEN = clsvTabFeatureFldsBL.vTabFeatureFldsDA.GetObjBymId(myKey.Value);
return objvTabFeatureFldsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabFeatureId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convTabFeatureFlds.TabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convTabFeatureFlds.TabFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabFeatureName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convTabFeatureFlds.TabFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFeatureFlds.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFeatureFlds.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFeatureFlds.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convTabFeatureFlds.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convTabFeatureFlds.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetTabCnName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convTabFeatureFlds.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetPrjName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convTabFeatureFlds.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convTabFeatureFlds.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetSqlDsTypeName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeName, convTabFeatureFlds.SqlDsTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convTabFeatureFlds.SqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFuncModuleAgcId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convTabFeatureFlds.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convTabFeatureFlds.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convTabFeatureFlds.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFuncModuleName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convTabFeatureFlds.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTabFeatureFlds.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetOrderNum4Refer(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, int? intOrderNum4Refer, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFeatureId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convTabFeatureFlds.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convTabFeatureFlds.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convTabFeatureFlds.FeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFeatureName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convTabFeatureFlds.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetParentFeatureId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strParentFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureId, 4, convTabFeatureFlds.ParentFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentFeatureId, 4, convTabFeatureFlds.ParentFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetParentFeatureName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strParentFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convTabFeatureFlds.ParentFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFldId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convTabFeatureFlds.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convTabFeatureFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convTabFeatureFlds.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFldName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convTabFeatureFlds.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convTabFeatureFlds.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetCaption(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convTabFeatureFlds.Caption);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, convTabFeatureFlds.Caption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetDataTypeId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convTabFeatureFlds.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convTabFeatureFlds.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convTabFeatureFlds.DataTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetDataTypeName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convTabFeatureFlds.DataTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFieldTypeId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convTabFeatureFlds.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convTabFeatureFlds.FieldTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFieldTypeName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFieldTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convTabFeatureFlds.FieldTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetFuncName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convTabFeatureFlds.FuncName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetValueGivingModeId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strValueGivingModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convTabFeatureFlds.ValueGivingModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convTabFeatureFlds.ValueGivingModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetValueGivingModeName(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strValueGivingModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strValueGivingModeName, 50, convTabFeatureFlds.ValueGivingModeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetDefaultValue(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convTabFeatureFlds.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetPrjId(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFeatureFlds.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFeatureFlds.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetUpdUser(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTabFeatureFlds.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetUpdDate(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTabFeatureFlds.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFldsEN SetMemo(this clsvTabFeatureFldsEN objvTabFeatureFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFeatureFlds.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTabFeatureFldsENS">源对象</param>
 /// <param name = "objvTabFeatureFldsENT">目标对象</param>
 public static void CopyTo(this clsvTabFeatureFldsEN objvTabFeatureFldsENS, clsvTabFeatureFldsEN objvTabFeatureFldsENT)
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
 /// <param name = "objvTabFeatureFldsENS">源对象</param>
 /// <returns>目标对象=>clsvTabFeatureFldsEN:objvTabFeatureFldsENT</returns>
 public static clsvTabFeatureFldsEN CopyTo(this clsvTabFeatureFldsEN objvTabFeatureFldsENS)
{
try
{
 clsvTabFeatureFldsEN objvTabFeatureFldsENT = new clsvTabFeatureFldsEN()
{
mId = objvTabFeatureFldsENS.mId, //mId
TabFeatureId = objvTabFeatureFldsENS.TabFeatureId, //表功能Id
TabFeatureName = objvTabFeatureFldsENS.TabFeatureName, //表功能名
TabId = objvTabFeatureFldsENS.TabId, //表ID
TabName = objvTabFeatureFldsENS.TabName, //表名
TabCnName = objvTabFeatureFldsENS.TabCnName, //表中文名
PrjName = objvTabFeatureFldsENS.PrjName, //工程名称
SqlDsTypeName = objvTabFeatureFldsENS.SqlDsTypeName, //Sql数据源名
FuncModuleAgcId = objvTabFeatureFldsENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvTabFeatureFldsENS.FuncModuleName, //功能模块名称
OrderNum4Refer = objvTabFeatureFldsENS.OrderNum4Refer, //引用序号
FeatureId = objvTabFeatureFldsENS.FeatureId, //功能Id
FeatureName = objvTabFeatureFldsENS.FeatureName, //功能名称
ParentFeatureId = objvTabFeatureFldsENS.ParentFeatureId, //父功能Id
ParentFeatureName = objvTabFeatureFldsENS.ParentFeatureName, //父功能名
FldId = objvTabFeatureFldsENS.FldId, //字段Id
FldName = objvTabFeatureFldsENS.FldName, //字段名
Caption = objvTabFeatureFldsENS.Caption, //标题
DataTypeId = objvTabFeatureFldsENS.DataTypeId, //数据类型Id
DataTypeName = objvTabFeatureFldsENS.DataTypeName, //数据类型名称
IsNull = objvTabFeatureFldsENS.IsNull, //是否可空
FieldTypeId = objvTabFeatureFldsENS.FieldTypeId, //字段类型Id
FieldTypeName = objvTabFeatureFldsENS.FieldTypeName, //字段类型名
FuncName = objvTabFeatureFldsENS.FuncName, //函数名
ValueGivingModeId = objvTabFeatureFldsENS.ValueGivingModeId, //给值方式Id
ValueGivingModeName = objvTabFeatureFldsENS.ValueGivingModeName, //给值方式名
DefaultValue = objvTabFeatureFldsENS.DefaultValue, //缺省值
PrjId = objvTabFeatureFldsENS.PrjId, //工程Id
OrderNum = objvTabFeatureFldsENS.OrderNum, //序号
InUse = objvTabFeatureFldsENS.InUse, //是否在用
UpdUser = objvTabFeatureFldsENS.UpdUser, //修改者
UpdDate = objvTabFeatureFldsENS.UpdDate, //修改日期
Memo = objvTabFeatureFldsENS.Memo, //说明
};
 return objvTabFeatureFldsENT;
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
public static void CheckProperty4Condition(this clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
 clsvTabFeatureFldsBL.vTabFeatureFldsDA.CheckProperty4Condition(objvTabFeatureFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// 检查唯一性(Uniqueness)--vTabFeatureFlds(v表功能字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabFeatureId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvTabFeatureFldsEN == null) return true;
if (objvTabFeatureFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objvTabFeatureFldsEN.TabFeatureId == null)
{
 sbCondition.AppendFormat(" and TabFeatureId is null", objvTabFeatureFldsEN.TabFeatureId);
}
else
{
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFldsEN.TabFeatureId);
}
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFldsEN.FldId);
if (clsvTabFeatureFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvTabFeatureFldsEN.mId);
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFldsEN.TabFeatureId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFldsEN.FldId);
if (clsvTabFeatureFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vTabFeatureFlds(v表功能字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabFeatureId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvTabFeatureFldsEN == null) return "";
if (objvTabFeatureFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objvTabFeatureFldsEN.TabFeatureId == null)
{
 sbCondition.AppendFormat(" and TabFeatureId is null", objvTabFeatureFldsEN.TabFeatureId);
}
else
{
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFldsEN.TabFeatureId);
}
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTabFeatureFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v表功能字段(vTabFeatureFlds)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTabFeatureFldsBL
{
public static RelatedActions_vTabFeatureFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTabFeatureFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTabFeatureFldsDA vTabFeatureFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTabFeatureFldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTabFeatureFldsBL()
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
if (string.IsNullOrEmpty(clsvTabFeatureFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFeatureFldsEN._ConnectString);
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
public static DataTable GetDataTable_vTabFeatureFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabFeatureFldsDA.GetDataTable_vTabFeatureFlds(strWhereCond);
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
objDT = vTabFeatureFldsDA.GetDataTable(strWhereCond);
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
objDT = vTabFeatureFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTabFeatureFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTabFeatureFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTabFeatureFldsDA.GetDataTable_Top(objTopPara);
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
objDT = vTabFeatureFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTabFeatureFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTabFeatureFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvTabFeatureFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
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
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTabFeatureFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLst_Sel =
arrvTabFeatureFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvTabFeatureFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFldsEN> GetObjLst(string strWhereCond)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
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
public static List<clsvTabFeatureFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTabFeatureFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTabFeatureFldsEN> GetSubObjLstCache(clsvTabFeatureFldsEN objvTabFeatureFldsCond)
{
 string strPrjId = objvTabFeatureFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvTabFeatureFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvTabFeatureFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFeatureFlds._AttributeName)
{
if (objvTabFeatureFldsCond.IsUpdated(strFldName) == false) continue;
if (objvTabFeatureFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureFldsCond[strFldName].ToString());
}
else
{
if (objvTabFeatureFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFeatureFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFeatureFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFeatureFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFeatureFldsCond[strFldName]));
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
public static List<clsvTabFeatureFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
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
public static List<clsvTabFeatureFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
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
List<clsvTabFeatureFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTabFeatureFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTabFeatureFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
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
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
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
public static List<clsvTabFeatureFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabFeatureFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTabFeatureFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
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
public static List<clsvTabFeatureFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTabFeatureFldsEN> arrObjLst = new List<clsvTabFeatureFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFldsEN objvTabFeatureFldsEN = new clsvTabFeatureFldsEN();
try
{
objvTabFeatureFldsEN.mId = Int32.Parse(objRow[convTabFeatureFlds.mId].ToString().Trim()); //mId
objvTabFeatureFldsEN.TabFeatureId = objRow[convTabFeatureFlds.TabFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFldsEN.TabFeatureName = objRow[convTabFeatureFlds.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeatureFldsEN.TabId = objRow[convTabFeatureFlds.TabId].ToString().Trim(); //表ID
objvTabFeatureFldsEN.TabName = objRow[convTabFeatureFlds.TabName].ToString().Trim(); //表名
objvTabFeatureFldsEN.TabCnName = objRow[convTabFeatureFlds.TabCnName] == DBNull.Value ? null : objRow[convTabFeatureFlds.TabCnName].ToString().Trim(); //表中文名
objvTabFeatureFldsEN.PrjName = objRow[convTabFeatureFlds.PrjName].ToString().Trim(); //工程名称
objvTabFeatureFldsEN.SqlDsTypeName = objRow[convTabFeatureFlds.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabFeatureFldsEN.FuncModuleAgcId = objRow[convTabFeatureFlds.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabFeatureFldsEN.FuncModuleName = objRow[convTabFeatureFlds.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabFeatureFldsEN.OrderNum4Refer = objRow[convTabFeatureFlds.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFeatureFlds.OrderNum4Refer].ToString().Trim()); //引用序号
objvTabFeatureFldsEN.FeatureId = objRow[convTabFeatureFlds.FeatureId].ToString().Trim(); //功能Id
objvTabFeatureFldsEN.FeatureName = objRow[convTabFeatureFlds.FeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FeatureName].ToString().Trim(); //功能名称
objvTabFeatureFldsEN.ParentFeatureId = objRow[convTabFeatureFlds.ParentFeatureId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureId].ToString().Trim(); //父功能Id
objvTabFeatureFldsEN.ParentFeatureName = objRow[convTabFeatureFlds.ParentFeatureName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ParentFeatureName].ToString().Trim(); //父功能名
objvTabFeatureFldsEN.FldId = objRow[convTabFeatureFlds.FldId].ToString().Trim(); //字段Id
objvTabFeatureFldsEN.FldName = objRow[convTabFeatureFlds.FldName].ToString().Trim(); //字段名
objvTabFeatureFldsEN.Caption = objRow[convTabFeatureFlds.Caption].ToString().Trim(); //标题
objvTabFeatureFldsEN.DataTypeId = objRow[convTabFeatureFlds.DataTypeId].ToString().Trim(); //数据类型Id
objvTabFeatureFldsEN.DataTypeName = objRow[convTabFeatureFlds.DataTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFeatureFldsEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.IsNull].ToString().Trim()); //是否可空
objvTabFeatureFldsEN.FieldTypeId = objRow[convTabFeatureFlds.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFldsEN.FieldTypeName = objRow[convTabFeatureFlds.FieldTypeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FieldTypeName].ToString().Trim(); //字段类型名
objvTabFeatureFldsEN.FuncName = objRow[convTabFeatureFlds.FuncName] == DBNull.Value ? null : objRow[convTabFeatureFlds.FuncName].ToString().Trim(); //函数名
objvTabFeatureFldsEN.ValueGivingModeId = objRow[convTabFeatureFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFldsEN.ValueGivingModeName = objRow[convTabFeatureFlds.ValueGivingModeName] == DBNull.Value ? null : objRow[convTabFeatureFlds.ValueGivingModeName].ToString().Trim(); //给值方式名
objvTabFeatureFldsEN.DefaultValue = objRow[convTabFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFldsEN.PrjId = objRow[convTabFeatureFlds.PrjId] == DBNull.Value ? null : objRow[convTabFeatureFlds.PrjId].ToString().Trim(); //工程Id
objvTabFeatureFldsEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds.OrderNum].ToString().Trim()); //序号
objvTabFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds.InUse].ToString().Trim()); //是否在用
objvTabFeatureFldsEN.UpdUser = objRow[convTabFeatureFlds.UpdUser] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdUser].ToString().Trim(); //修改者
objvTabFeatureFldsEN.UpdDate = objRow[convTabFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[convTabFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objvTabFeatureFldsEN.Memo = objRow[convTabFeatureFlds.Memo] == DBNull.Value ? null : objRow[convTabFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTabFeatureFlds(ref clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
bool bolResult = vTabFeatureFldsDA.GetvTabFeatureFlds(ref objvTabFeatureFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeatureFldsEN GetObjBymId(long lngmId)
{
clsvTabFeatureFldsEN objvTabFeatureFldsEN = vTabFeatureFldsDA.GetObjBymId(lngmId);
return objvTabFeatureFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTabFeatureFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTabFeatureFldsEN objvTabFeatureFldsEN = vTabFeatureFldsDA.GetFirstObj(strWhereCond);
 return objvTabFeatureFldsEN;
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
public static clsvTabFeatureFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTabFeatureFldsEN objvTabFeatureFldsEN = vTabFeatureFldsDA.GetObjByDataRow(objRow);
 return objvTabFeatureFldsEN;
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
public static clsvTabFeatureFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTabFeatureFldsEN objvTabFeatureFldsEN = vTabFeatureFldsDA.GetObjByDataRow(objRow);
 return objvTabFeatureFldsEN;
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
 /// <param name = "lstvTabFeatureFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFeatureFldsEN GetObjBymIdFromList(long lngmId, List<clsvTabFeatureFldsEN> lstvTabFeatureFldsObjLst)
{
foreach (clsvTabFeatureFldsEN objvTabFeatureFldsEN in lstvTabFeatureFldsObjLst)
{
if (objvTabFeatureFldsEN.mId == lngmId)
{
return objvTabFeatureFldsEN;
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
 lngmId = new clsvTabFeatureFldsDA().GetFirstID(strWhereCond);
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
 arrList = vTabFeatureFldsDA.GetID(strWhereCond);
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
bool bolIsExist = vTabFeatureFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vTabFeatureFldsDA.IsExist(lngmId);
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
 bolIsExist = clsvTabFeatureFldsDA.IsExistTable();
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
 bolIsExist = vTabFeatureFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objvTabFeatureFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
try
{
objvTabFeatureFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTabFeatureFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTabFeatureFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.mId = objvTabFeatureFldsEN.mId; //mId
}
if (arrFldSet.Contains(convTabFeatureFlds.TabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.TabFeatureId = objvTabFeatureFldsEN.TabFeatureId == "[null]" ? null :  objvTabFeatureFldsEN.TabFeatureId; //表功能Id
}
if (arrFldSet.Contains(convTabFeatureFlds.TabFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.TabFeatureName = objvTabFeatureFldsEN.TabFeatureName == "[null]" ? null :  objvTabFeatureFldsEN.TabFeatureName; //表功能名
}
if (arrFldSet.Contains(convTabFeatureFlds.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.TabId = objvTabFeatureFldsEN.TabId; //表ID
}
if (arrFldSet.Contains(convTabFeatureFlds.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.TabName = objvTabFeatureFldsEN.TabName; //表名
}
if (arrFldSet.Contains(convTabFeatureFlds.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.TabCnName = objvTabFeatureFldsEN.TabCnName == "[null]" ? null :  objvTabFeatureFldsEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convTabFeatureFlds.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.PrjName = objvTabFeatureFldsEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convTabFeatureFlds.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.SqlDsTypeName = objvTabFeatureFldsEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convTabFeatureFlds.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.FuncModuleAgcId = objvTabFeatureFldsEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convTabFeatureFlds.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.FuncModuleName = objvTabFeatureFldsEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convTabFeatureFlds.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.OrderNum4Refer = objvTabFeatureFldsEN.OrderNum4Refer; //引用序号
}
if (arrFldSet.Contains(convTabFeatureFlds.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.FeatureId = objvTabFeatureFldsEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convTabFeatureFlds.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.FeatureName = objvTabFeatureFldsEN.FeatureName == "[null]" ? null :  objvTabFeatureFldsEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convTabFeatureFlds.ParentFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.ParentFeatureId = objvTabFeatureFldsEN.ParentFeatureId == "[null]" ? null :  objvTabFeatureFldsEN.ParentFeatureId; //父功能Id
}
if (arrFldSet.Contains(convTabFeatureFlds.ParentFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.ParentFeatureName = objvTabFeatureFldsEN.ParentFeatureName == "[null]" ? null :  objvTabFeatureFldsEN.ParentFeatureName; //父功能名
}
if (arrFldSet.Contains(convTabFeatureFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.FldId = objvTabFeatureFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(convTabFeatureFlds.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.FldName = objvTabFeatureFldsEN.FldName; //字段名
}
if (arrFldSet.Contains(convTabFeatureFlds.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.Caption = objvTabFeatureFldsEN.Caption; //标题
}
if (arrFldSet.Contains(convTabFeatureFlds.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.DataTypeId = objvTabFeatureFldsEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convTabFeatureFlds.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.DataTypeName = objvTabFeatureFldsEN.DataTypeName == "[null]" ? null :  objvTabFeatureFldsEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convTabFeatureFlds.IsNull, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.IsNull = objvTabFeatureFldsEN.IsNull; //是否可空
}
if (arrFldSet.Contains(convTabFeatureFlds.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.FieldTypeId = objvTabFeatureFldsEN.FieldTypeId == "[null]" ? null :  objvTabFeatureFldsEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convTabFeatureFlds.FieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.FieldTypeName = objvTabFeatureFldsEN.FieldTypeName == "[null]" ? null :  objvTabFeatureFldsEN.FieldTypeName; //字段类型名
}
if (arrFldSet.Contains(convTabFeatureFlds.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.FuncName = objvTabFeatureFldsEN.FuncName == "[null]" ? null :  objvTabFeatureFldsEN.FuncName; //函数名
}
if (arrFldSet.Contains(convTabFeatureFlds.ValueGivingModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.ValueGivingModeId = objvTabFeatureFldsEN.ValueGivingModeId == "[null]" ? null :  objvTabFeatureFldsEN.ValueGivingModeId; //给值方式Id
}
if (arrFldSet.Contains(convTabFeatureFlds.ValueGivingModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.ValueGivingModeName = objvTabFeatureFldsEN.ValueGivingModeName == "[null]" ? null :  objvTabFeatureFldsEN.ValueGivingModeName; //给值方式名
}
if (arrFldSet.Contains(convTabFeatureFlds.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.DefaultValue = objvTabFeatureFldsEN.DefaultValue == "[null]" ? null :  objvTabFeatureFldsEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convTabFeatureFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.PrjId = objvTabFeatureFldsEN.PrjId == "[null]" ? null :  objvTabFeatureFldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convTabFeatureFlds.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.OrderNum = objvTabFeatureFldsEN.OrderNum; //序号
}
if (arrFldSet.Contains(convTabFeatureFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.InUse = objvTabFeatureFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(convTabFeatureFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.UpdUser = objvTabFeatureFldsEN.UpdUser == "[null]" ? null :  objvTabFeatureFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convTabFeatureFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.UpdDate = objvTabFeatureFldsEN.UpdDate == "[null]" ? null :  objvTabFeatureFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convTabFeatureFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFldsEN.Memo = objvTabFeatureFldsEN.Memo == "[null]" ? null :  objvTabFeatureFldsEN.Memo; //说明
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
 /// <param name = "objvTabFeatureFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
try
{
if (objvTabFeatureFldsEN.TabFeatureId == "[null]") objvTabFeatureFldsEN.TabFeatureId = null; //表功能Id
if (objvTabFeatureFldsEN.TabFeatureName == "[null]") objvTabFeatureFldsEN.TabFeatureName = null; //表功能名
if (objvTabFeatureFldsEN.TabCnName == "[null]") objvTabFeatureFldsEN.TabCnName = null; //表中文名
if (objvTabFeatureFldsEN.FeatureName == "[null]") objvTabFeatureFldsEN.FeatureName = null; //功能名称
if (objvTabFeatureFldsEN.ParentFeatureId == "[null]") objvTabFeatureFldsEN.ParentFeatureId = null; //父功能Id
if (objvTabFeatureFldsEN.ParentFeatureName == "[null]") objvTabFeatureFldsEN.ParentFeatureName = null; //父功能名
if (objvTabFeatureFldsEN.DataTypeName == "[null]") objvTabFeatureFldsEN.DataTypeName = null; //数据类型名称
if (objvTabFeatureFldsEN.FieldTypeId == "[null]") objvTabFeatureFldsEN.FieldTypeId = null; //字段类型Id
if (objvTabFeatureFldsEN.FieldTypeName == "[null]") objvTabFeatureFldsEN.FieldTypeName = null; //字段类型名
if (objvTabFeatureFldsEN.FuncName == "[null]") objvTabFeatureFldsEN.FuncName = null; //函数名
if (objvTabFeatureFldsEN.ValueGivingModeId == "[null]") objvTabFeatureFldsEN.ValueGivingModeId = null; //给值方式Id
if (objvTabFeatureFldsEN.ValueGivingModeName == "[null]") objvTabFeatureFldsEN.ValueGivingModeName = null; //给值方式名
if (objvTabFeatureFldsEN.DefaultValue == "[null]") objvTabFeatureFldsEN.DefaultValue = null; //缺省值
if (objvTabFeatureFldsEN.PrjId == "[null]") objvTabFeatureFldsEN.PrjId = null; //工程Id
if (objvTabFeatureFldsEN.UpdUser == "[null]") objvTabFeatureFldsEN.UpdUser = null; //修改者
if (objvTabFeatureFldsEN.UpdDate == "[null]") objvTabFeatureFldsEN.UpdDate = null; //修改日期
if (objvTabFeatureFldsEN.Memo == "[null]") objvTabFeatureFldsEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
 vTabFeatureFldsDA.CheckProperty4Condition(objvTabFeatureFldsEN);
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
if (clsFieldTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTypeBL没有刷新缓存机制(clsFieldTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabFeatureFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFeatureFldsBL没有刷新缓存机制(clsTabFeatureFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsValueGivingModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsValueGivingModeBL没有刷新缓存机制(clsValueGivingModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvTabFeatureFldsObjLstCache == null)
//{
//arrvTabFeatureFldsObjLstCache = vTabFeatureFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFeatureFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLst_Sel =
arrvTabFeatureFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvTabFeatureFldsObjLst_Sel.Count() == 0)
{
   clsvTabFeatureFldsEN obj = clsvTabFeatureFldsBL.GetObjBymId(lngmId);
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
return arrvTabFeatureFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeatureFldsEN> GetAllvTabFeatureFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrvTabFeatureFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeatureFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvTabFeatureFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvTabFeatureFldsEN> arrvTabFeatureFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvTabFeatureFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvTabFeatureFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvTabFeatureFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvTabFeatureFldsEN._RefreshTimeLst.Count == 0) return "";
return clsvTabFeatureFldsEN._RefreshTimeLst[clsvTabFeatureFldsEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vTabFeatureFlds(v表功能字段)
 /// 唯一性条件:TabFeatureId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvTabFeatureFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvTabFeatureFldsEN objvTabFeatureFldsEN)
{
//检测记录是否存在
string strResult = vTabFeatureFldsDA.GetUniCondStr(objvTabFeatureFldsEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convTabFeatureFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTabFeatureFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTabFeatureFlds._AttributeName));
throw new Exception(strMsg);
}
var objvTabFeatureFlds = clsvTabFeatureFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvTabFeatureFlds == null) return "";
return objvTabFeatureFlds[strOutFldName].ToString();
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
int intRecCount = clsvTabFeatureFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsvTabFeatureFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTabFeatureFldsDA.GetRecCount();
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
int intRecCount = clsvTabFeatureFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTabFeatureFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTabFeatureFldsEN objvTabFeatureFldsCond)
{
 string strPrjId = objvTabFeatureFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvTabFeatureFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvTabFeatureFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvTabFeatureFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFeatureFlds._AttributeName)
{
if (objvTabFeatureFldsCond.IsUpdated(strFldName) == false) continue;
if (objvTabFeatureFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureFldsCond[strFldName].ToString());
}
else
{
if (objvTabFeatureFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFeatureFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFeatureFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFeatureFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFeatureFldsCond[strFldName]));
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
 List<string> arrList = clsvTabFeatureFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTabFeatureFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTabFeatureFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}