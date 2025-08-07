
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewFldWApi
 表名:vSqlViewFld(00050252)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
public static class  clsvSqlViewFldWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetmId(this clsvSqlViewFldEN objvSqlViewFldEN, long lngmId, string strComparisonOp="")
	{
objvSqlViewFldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.mId) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.mId, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.mId] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewId">Sql视图Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetSqlViewId(this clsvSqlViewFldEN objvSqlViewFldEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, convSqlViewFld.SqlViewId);
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convSqlViewFld.SqlViewId);
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convSqlViewFld.SqlViewId);
objvSqlViewFldEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.SqlViewId) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.SqlViewId, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.SqlViewId] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewName">数据视图名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetSqlViewName(this clsvSqlViewFldEN objvSqlViewFldEN, string strSqlViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewName, convSqlViewFld.SqlViewName);
clsCheckSql.CheckFieldLen(strSqlViewName, 100, convSqlViewFld.SqlViewName);
objvSqlViewFldEN.SqlViewName = strSqlViewName; //数据视图名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.SqlViewName) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.SqlViewName, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.SqlViewName] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewCNName">Sql视图中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetSqlViewCNName(this clsvSqlViewFldEN objvSqlViewFldEN, string strSqlViewCNName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewCNName, 200, convSqlViewFld.SqlViewCNName);
objvSqlViewFldEN.SqlViewCNName = strSqlViewCNName; //Sql视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.SqlViewCNName) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.SqlViewCNName, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.SqlViewCNName] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetRelaTabId(this clsvSqlViewFldEN objvSqlViewFldEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, convSqlViewFld.RelaTabId);
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, convSqlViewFld.RelaTabId);
objvSqlViewFldEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.RelaTabId) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.RelaTabId, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.RelaTabId] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabId(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convSqlViewFld.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convSqlViewFld.TabId);
objvSqlViewFldEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.TabId) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.TabId, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.TabId] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabName(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convSqlViewFld.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convSqlViewFld.TabName);
objvSqlViewFldEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.TabName) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.TabName, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.TabName] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabCnName(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convSqlViewFld.TabCnName);
objvSqlViewFldEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.TabCnName) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.TabCnName, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.TabCnName] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabAliases">表别名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabAliases(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabAliases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabAliases, 100, convSqlViewFld.TabAliases);
objvSqlViewFldEN.TabAliases = strTabAliases; //表别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.TabAliases) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.TabAliases, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.TabAliases] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabRelationText">表关系文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabRelationText(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabRelationText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabRelationText, 500, convSqlViewFld.TabRelationText);
objvSqlViewFldEN.TabRelationText = strTabRelationText; //表关系文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.TabRelationText) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.TabRelationText, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.TabRelationText] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFldId(this clsvSqlViewFldEN objvSqlViewFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convSqlViewFld.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convSqlViewFld.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convSqlViewFld.FldId);
objvSqlViewFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.FldId) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.FldId, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.FldId] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFldName(this clsvSqlViewFldEN objvSqlViewFldEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convSqlViewFld.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convSqlViewFld.FldName);
objvSqlViewFldEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.FldName) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.FldName, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.FldName] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldCnName">字段中文详名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFldCnName(this clsvSqlViewFldEN objvSqlViewFldEN, string strFldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convSqlViewFld.FldCnName);
objvSqlViewFldEN.FldCnName = strFldCnName; //字段中文详名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.FldCnName) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.FldCnName, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.FldCnName] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldExpression">字段表达式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFldExpression(this clsvSqlViewFldEN objvSqlViewFldEN, string strFldExpression, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldExpression, 500, convSqlViewFld.FldExpression);
objvSqlViewFldEN.FldExpression = strFldExpression; //字段表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.FldExpression) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.FldExpression, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.FldExpression] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldAliases">字段别名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFieldAliases(this clsvSqlViewFldEN objvSqlViewFldEN, string strFieldAliases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldAliases, 50, convSqlViewFld.FieldAliases);
objvSqlViewFldEN.FieldAliases = strFieldAliases; //字段别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.FieldAliases) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.FieldAliases, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.FieldAliases] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilters">筛选器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFilters(this clsvSqlViewFldEN objvSqlViewFldEN, string strFilters, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFilters, 50, convSqlViewFld.Filters);
objvSqlViewFldEN.Filters = strFilters; //筛选器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.Filters) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.Filters, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.Filters] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetOrderNum(this clsvSqlViewFldEN objvSqlViewFldEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convSqlViewFld.OrderNum);
objvSqlViewFldEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.OrderNum) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.OrderNum, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.OrderNum] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetPrjId(this clsvSqlViewFldEN objvSqlViewFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlViewFld.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlViewFld.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlViewFld.PrjId);
objvSqlViewFldEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.PrjId) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.PrjId, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.PrjId] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetUpdDate(this clsvSqlViewFldEN objvSqlViewFldEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlViewFld.UpdDate);
objvSqlViewFldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.UpdDate) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.UpdDate, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.UpdDate] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetUpdUserId(this clsvSqlViewFldEN objvSqlViewFldEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlViewFld.UpdUserId);
objvSqlViewFldEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.UpdUserId) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.UpdUserId, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.UpdUserId] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetMemo(this clsvSqlViewFldEN objvSqlViewFldEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlViewFld.Memo);
objvSqlViewFldEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.Memo) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.Memo, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.Memo] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId4SqlView">RelaTabId4SqlView</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetRelaTabId4SqlView(this clsvSqlViewFldEN objvSqlViewFldEN, string strRelaTabId4SqlView, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId4SqlView, 8, convSqlViewFld.RelaTabId4SqlView);
clsCheckSql.CheckFieldForeignKey(strRelaTabId4SqlView, 8, convSqlViewFld.RelaTabId4SqlView);
objvSqlViewFldEN.RelaTabId4SqlView = strRelaTabId4SqlView; //RelaTabId4SqlView
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewFldEN.dicFldComparisonOp.ContainsKey(convSqlViewFld.RelaTabId4SqlView) == false)
{
objvSqlViewFldEN.dicFldComparisonOp.Add(convSqlViewFld.RelaTabId4SqlView, strComparisonOp);
}
else
{
objvSqlViewFldEN.dicFldComparisonOp[convSqlViewFld.RelaTabId4SqlView] = strComparisonOp;
}
}
return objvSqlViewFldEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSqlViewFldEN objvSqlViewFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.mId) == true)
{
string strComparisonOpmId = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convSqlViewFld.mId, objvSqlViewFldCond.mId, strComparisonOpmId);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.SqlViewId, objvSqlViewFldCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.SqlViewName) == true)
{
string strComparisonOpSqlViewName = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.SqlViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.SqlViewName, objvSqlViewFldCond.SqlViewName, strComparisonOpSqlViewName);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.SqlViewCNName) == true)
{
string strComparisonOpSqlViewCNName = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.SqlViewCNName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.SqlViewCNName, objvSqlViewFldCond.SqlViewCNName, strComparisonOpSqlViewCNName);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.RelaTabId, objvSqlViewFldCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.TabId) == true)
{
string strComparisonOpTabId = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.TabId, objvSqlViewFldCond.TabId, strComparisonOpTabId);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.TabName) == true)
{
string strComparisonOpTabName = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.TabName, objvSqlViewFldCond.TabName, strComparisonOpTabName);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.TabCnName) == true)
{
string strComparisonOpTabCnName = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.TabCnName, objvSqlViewFldCond.TabCnName, strComparisonOpTabCnName);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.TabAliases) == true)
{
string strComparisonOpTabAliases = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.TabAliases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.TabAliases, objvSqlViewFldCond.TabAliases, strComparisonOpTabAliases);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.TabRelationText) == true)
{
string strComparisonOpTabRelationText = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.TabRelationText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.TabRelationText, objvSqlViewFldCond.TabRelationText, strComparisonOpTabRelationText);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.FldId) == true)
{
string strComparisonOpFldId = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.FldId, objvSqlViewFldCond.FldId, strComparisonOpFldId);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.FldName) == true)
{
string strComparisonOpFldName = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.FldName, objvSqlViewFldCond.FldName, strComparisonOpFldName);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.FldCnName) == true)
{
string strComparisonOpFldCnName = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.FldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.FldCnName, objvSqlViewFldCond.FldCnName, strComparisonOpFldCnName);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.FldExpression) == true)
{
string strComparisonOpFldExpression = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.FldExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.FldExpression, objvSqlViewFldCond.FldExpression, strComparisonOpFldExpression);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.FieldAliases) == true)
{
string strComparisonOpFieldAliases = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.FieldAliases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.FieldAliases, objvSqlViewFldCond.FieldAliases, strComparisonOpFieldAliases);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.Filters) == true)
{
string strComparisonOpFilters = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.Filters];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.Filters, objvSqlViewFldCond.Filters, strComparisonOpFilters);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.OrderNum) == true)
{
string strComparisonOpOrderNum = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSqlViewFld.OrderNum, objvSqlViewFldCond.OrderNum, strComparisonOpOrderNum);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.PrjId) == true)
{
string strComparisonOpPrjId = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.PrjId, objvSqlViewFldCond.PrjId, strComparisonOpPrjId);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.UpdDate, objvSqlViewFldCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.UpdUserId, objvSqlViewFldCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.Memo) == true)
{
string strComparisonOpMemo = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.Memo, objvSqlViewFldCond.Memo, strComparisonOpMemo);
}
if (objvSqlViewFldCond.IsUpdated(convSqlViewFld.RelaTabId4SqlView) == true)
{
string strComparisonOpRelaTabId4SqlView = objvSqlViewFldCond.dicFldComparisonOp[convSqlViewFld.RelaTabId4SqlView];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewFld.RelaTabId4SqlView, objvSqlViewFldCond.RelaTabId4SqlView, strComparisonOpRelaTabId4SqlView);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vSql视图字段(vSqlViewFld)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSqlViewFldWApi
{
private static readonly string mstrApiControllerName = "vSqlViewFldApi";

 public clsvSqlViewFldWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlViewFldEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvSqlViewFldEN objvSqlViewFldEN;
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
objvSqlViewFldEN = JsonConvert.DeserializeObject<clsvSqlViewFldEN>(strJson);
return objvSqlViewFldEN;
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
public static clsvSqlViewFldEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvSqlViewFldEN objvSqlViewFldEN;
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
objvSqlViewFldEN = JsonConvert.DeserializeObject<clsvSqlViewFldEN>(strJson);
return objvSqlViewFldEN;
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
public static List<clsvSqlViewFldEN> GetObjLst(string strWhereCond)
{
 List<clsvSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewFldEN>>(strJson);
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
public static List<clsvSqlViewFldEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewFldEN>>(strJson);
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
public static List<clsvSqlViewFldEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewFldEN>>(strJson);
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
public static List<clsvSqlViewFldEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewFldEN>>(strJson);
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
public static List<clsvSqlViewFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewFldEN>>(strJson);
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
public static List<clsvSqlViewFldEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvSqlViewFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewFldEN>>(strJson);
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
 /// <param name = "objvSqlViewFldENS">源对象</param>
 /// <param name = "objvSqlViewFldENT">目标对象</param>
 public static void CopyTo(clsvSqlViewFldEN objvSqlViewFldENS, clsvSqlViewFldEN objvSqlViewFldENT)
{
try
{
objvSqlViewFldENT.mId = objvSqlViewFldENS.mId; //mId
objvSqlViewFldENT.SqlViewId = objvSqlViewFldENS.SqlViewId; //Sql视图Id
objvSqlViewFldENT.SqlViewName = objvSqlViewFldENS.SqlViewName; //数据视图名称
objvSqlViewFldENT.SqlViewCNName = objvSqlViewFldENS.SqlViewCNName; //Sql视图中文名
objvSqlViewFldENT.RelaTabId = objvSqlViewFldENS.RelaTabId; //相关表Id
objvSqlViewFldENT.TabId = objvSqlViewFldENS.TabId; //表ID
objvSqlViewFldENT.TabName = objvSqlViewFldENS.TabName; //表名
objvSqlViewFldENT.TabCnName = objvSqlViewFldENS.TabCnName; //表中文名
objvSqlViewFldENT.TabAliases = objvSqlViewFldENS.TabAliases; //表别名
objvSqlViewFldENT.TabRelationText = objvSqlViewFldENS.TabRelationText; //表关系文本
objvSqlViewFldENT.FldId = objvSqlViewFldENS.FldId; //字段Id
objvSqlViewFldENT.FldName = objvSqlViewFldENS.FldName; //字段名
objvSqlViewFldENT.FldCnName = objvSqlViewFldENS.FldCnName; //字段中文详名
objvSqlViewFldENT.FldExpression = objvSqlViewFldENS.FldExpression; //字段表达式
objvSqlViewFldENT.FieldAliases = objvSqlViewFldENS.FieldAliases; //字段别名
objvSqlViewFldENT.Filters = objvSqlViewFldENS.Filters; //筛选器
objvSqlViewFldENT.OrderNum = objvSqlViewFldENS.OrderNum; //序号
objvSqlViewFldENT.PrjId = objvSqlViewFldENS.PrjId; //工程Id
objvSqlViewFldENT.UpdDate = objvSqlViewFldENS.UpdDate; //修改日期
objvSqlViewFldENT.UpdUserId = objvSqlViewFldENS.UpdUserId; //修改用户Id
objvSqlViewFldENT.Memo = objvSqlViewFldENS.Memo; //说明
objvSqlViewFldENT.RelaTabId4SqlView = objvSqlViewFldENS.RelaTabId4SqlView; //RelaTabId4SqlView
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
public static DataTable ToDataTable(List<clsvSqlViewFldEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSqlViewFldEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSqlViewFldEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSqlViewFldEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSqlViewFldEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSqlViewFldEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvSqlViewFldWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvSqlViewFldWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvSqlViewFldEN._CurrTabName, strPrjId);
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
public static DataTable GetDataTableByObjLst(List<clsvSqlViewFldEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSqlViewFld.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convSqlViewFld.SqlViewId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.SqlViewName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.SqlViewCNName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.RelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.TabAliases, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.TabRelationText, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.FldCnName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.FldExpression, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.FieldAliases, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.Filters, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convSqlViewFld.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewFld.RelaTabId4SqlView, Type.GetType("System.String"));
foreach (clsvSqlViewFldEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSqlViewFld.mId] = objInFor[convSqlViewFld.mId];
objDR[convSqlViewFld.SqlViewId] = objInFor[convSqlViewFld.SqlViewId];
objDR[convSqlViewFld.SqlViewName] = objInFor[convSqlViewFld.SqlViewName];
objDR[convSqlViewFld.SqlViewCNName] = objInFor[convSqlViewFld.SqlViewCNName];
objDR[convSqlViewFld.RelaTabId] = objInFor[convSqlViewFld.RelaTabId];
objDR[convSqlViewFld.TabId] = objInFor[convSqlViewFld.TabId];
objDR[convSqlViewFld.TabName] = objInFor[convSqlViewFld.TabName];
objDR[convSqlViewFld.TabCnName] = objInFor[convSqlViewFld.TabCnName];
objDR[convSqlViewFld.TabAliases] = objInFor[convSqlViewFld.TabAliases];
objDR[convSqlViewFld.TabRelationText] = objInFor[convSqlViewFld.TabRelationText];
objDR[convSqlViewFld.FldId] = objInFor[convSqlViewFld.FldId];
objDR[convSqlViewFld.FldName] = objInFor[convSqlViewFld.FldName];
objDR[convSqlViewFld.FldCnName] = objInFor[convSqlViewFld.FldCnName];
objDR[convSqlViewFld.FldExpression] = objInFor[convSqlViewFld.FldExpression];
objDR[convSqlViewFld.FieldAliases] = objInFor[convSqlViewFld.FieldAliases];
objDR[convSqlViewFld.Filters] = objInFor[convSqlViewFld.Filters];
objDR[convSqlViewFld.OrderNum] = objInFor[convSqlViewFld.OrderNum];
objDR[convSqlViewFld.PrjId] = objInFor[convSqlViewFld.PrjId];
objDR[convSqlViewFld.UpdDate] = objInFor[convSqlViewFld.UpdDate];
objDR[convSqlViewFld.UpdUserId] = objInFor[convSqlViewFld.UpdUserId];
objDR[convSqlViewFld.Memo] = objInFor[convSqlViewFld.Memo];
objDR[convSqlViewFld.RelaTabId4SqlView] = objInFor[convSqlViewFld.RelaTabId4SqlView];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}