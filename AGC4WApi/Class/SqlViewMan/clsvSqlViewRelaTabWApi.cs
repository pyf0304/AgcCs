
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewRelaTabWApi
 表名:vSqlViewRelaTab(00050251)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvSqlViewRelaTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaTabId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, convSqlViewRelaTab.RelaTabId);
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, convSqlViewRelaTab.RelaTabId);
objvSqlViewRelaTabEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.RelaTabId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.RelaTabId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.RelaTabId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewId">Sql视图Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSqlViewId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, convSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convSqlViewRelaTab.SqlViewId);
objvSqlViewRelaTabEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.SqlViewId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.SqlViewId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.SqlViewId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewCNName">Sql视图中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSqlViewCNName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSqlViewCNName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewCNName, 200, convSqlViewRelaTab.SqlViewCNName);
objvSqlViewRelaTabEN.SqlViewCNName = strSqlViewCNName; //Sql视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.SqlViewCNName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.SqlViewCNName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.SqlViewCNName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewName">数据视图名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSqlViewName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSqlViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewName, convSqlViewRelaTab.SqlViewName);
clsCheckSql.CheckFieldLen(strSqlViewName, 100, convSqlViewRelaTab.SqlViewName);
objvSqlViewRelaTabEN.SqlViewName = strSqlViewName; //数据视图名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.SqlViewName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.SqlViewName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.SqlViewName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convSqlViewRelaTab.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convSqlViewRelaTab.TabId);
objvSqlViewRelaTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.TabId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.TabId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.TabId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convSqlViewRelaTab.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convSqlViewRelaTab.TabName);
objvSqlViewRelaTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.TabName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.TabName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.TabName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabCnName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convSqlViewRelaTab.TabCnName);
objvSqlViewRelaTabEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.TabCnName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.TabCnName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.TabCnName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabAliases">表别名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabAliases(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabAliases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabAliases, 100, convSqlViewRelaTab.TabAliases);
objvSqlViewRelaTabEN.TabAliases = strTabAliases; //表别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.TabAliases) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.TabAliases, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.TabAliases] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSvRelaTabTypeName">Sql视图相关表类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSvRelaTabTypeName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSvRelaTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSvRelaTabTypeName, convSqlViewRelaTab.SvRelaTabTypeName);
clsCheckSql.CheckFieldLen(strSvRelaTabTypeName, 30, convSqlViewRelaTab.SvRelaTabTypeName);
objvSqlViewRelaTabEN.SvRelaTabTypeName = strSvRelaTabTypeName; //Sql视图相关表类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.SvRelaTabTypeName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.SvRelaTabTypeName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.SvRelaTabTypeName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSvRelaTabTypeId">Sql视图相关表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSvRelaTabTypeId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSvRelaTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSvRelaTabTypeId, convSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckFieldLen(strSvRelaTabTypeId, 2, convSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckFieldForeignKey(strSvRelaTabTypeId, 2, convSqlViewRelaTab.SvRelaTabTypeId);
objvSqlViewRelaTabEN.SvRelaTabTypeId = strSvRelaTabTypeId; //Sql视图相关表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.SvRelaTabTypeId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.SvRelaTabTypeId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.SvRelaTabTypeId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabRelationTypeId">表关系类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabRelationTypeId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabRelationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabRelationTypeId, convSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckFieldLen(strTabRelationTypeId, 2, convSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckFieldForeignKey(strTabRelationTypeId, 2, convSqlViewRelaTab.TabRelationTypeId);
objvSqlViewRelaTabEN.TabRelationTypeId = strTabRelationTypeId; //表关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.TabRelationTypeId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.TabRelationTypeId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.TabRelationTypeId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabRelationTypeName">表关系类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabRelationTypeName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabRelationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabRelationTypeName, convSqlViewRelaTab.TabRelationTypeName);
clsCheckSql.CheckFieldLen(strTabRelationTypeName, 30, convSqlViewRelaTab.TabRelationTypeName);
objvSqlViewRelaTabEN.TabRelationTypeName = strTabRelationTypeName; //表关系类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.TabRelationTypeName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.TabRelationTypeName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.TabRelationTypeName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabRelationText">表关系文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabRelationText(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabRelationText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabRelationText, 500, convSqlViewRelaTab.TabRelationText);
objvSqlViewRelaTabEN.TabRelationText = strTabRelationText; //表关系文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.TabRelationText) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.TabRelationText, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.TabRelationText] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOrderNum(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convSqlViewRelaTab.OrderNum);
objvSqlViewRelaTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.OrderNum) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.OrderNum, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.OrderNum] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOtherFldCnName">他表字段中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherFldCnName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherFldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOtherFldCnName, 200, convSqlViewRelaTab.OtherFldCnName);
objvSqlViewRelaTabEN.OtherFldCnName = strOtherFldCnName; //他表字段中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.OtherFldCnName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.OtherFldCnName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.OtherFldCnName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOtherFldName">他表字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherFldName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOtherFldName, 50, convSqlViewRelaTab.OtherFldName);
objvSqlViewRelaTabEN.OtherFldName = strOtherFldName; //他表字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.OtherFldName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.OtherFldName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.OtherFldName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOtherTabName">他表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherTabName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOtherTabName, 100, convSqlViewRelaTab.OtherTabName);
objvSqlViewRelaTabEN.OtherTabName = strOtherTabName; //他表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.OtherTabName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.OtherTabName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.OtherTabName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaFldCnName">关系字段中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaFldCnName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaFldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaFldCnName, 200, convSqlViewRelaTab.RelaFldCnName);
objvSqlViewRelaTabEN.RelaFldCnName = strRelaFldCnName; //关系字段中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.RelaFldCnName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.RelaFldCnName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.RelaFldCnName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaFldName">关系字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaFldName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaFldName, 50, convSqlViewRelaTab.RelaFldName);
objvSqlViewRelaTabEN.RelaFldName = strRelaFldName; //关系字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.RelaFldName) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.RelaFldName, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.RelaFldName] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaFldId">关系字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaFldId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaFldId, 8, convSqlViewRelaTab.RelaFldId);
clsCheckSql.CheckFieldForeignKey(strRelaFldId, 8, convSqlViewRelaTab.RelaFldId);
objvSqlViewRelaTabEN.RelaFldId = strRelaFldId; //关系字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.RelaFldId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.RelaFldId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.RelaFldId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOtherFldId">其他表字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherFldId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOtherFldId, 8, convSqlViewRelaTab.OtherFldId);
clsCheckSql.CheckFieldForeignKey(strOtherFldId, 8, convSqlViewRelaTab.OtherFldId);
objvSqlViewRelaTabEN.OtherFldId = strOtherFldId; //其他表字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.OtherFldId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.OtherFldId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.OtherFldId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOtherTabId">其他表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherTabId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOtherTabId, 8, convSqlViewRelaTab.OtherTabId);
clsCheckSql.CheckFieldForeignKey(strOtherTabId, 8, convSqlViewRelaTab.OtherTabId);
objvSqlViewRelaTabEN.OtherTabId = strOtherTabId; //其他表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.OtherTabId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.OtherTabId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.OtherTabId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetPrjId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlViewRelaTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlViewRelaTab.PrjId);
objvSqlViewRelaTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.PrjId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.PrjId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.PrjId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetUpdDate(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlViewRelaTab.UpdDate);
objvSqlViewRelaTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.UpdDate) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.UpdDate, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.UpdDate] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetUpdUserId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlViewRelaTab.UpdUserId);
objvSqlViewRelaTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.UpdUserId) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.UpdUserId, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.UpdUserId] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetMemo(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlViewRelaTab.Memo);
objvSqlViewRelaTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.Memo) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.Memo, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.Memo] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId4SqlView">RelaTabId4SqlView</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaTabId4SqlView(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaTabId4SqlView, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId4SqlView, 8, convSqlViewRelaTab.RelaTabId4SqlView);
clsCheckSql.CheckFieldForeignKey(strRelaTabId4SqlView, 8, convSqlViewRelaTab.RelaTabId4SqlView);
objvSqlViewRelaTabEN.RelaTabId4SqlView = strRelaTabId4SqlView; //RelaTabId4SqlView
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(convSqlViewRelaTab.RelaTabId4SqlView) == false)
{
objvSqlViewRelaTabEN.dicFldComparisonOp.Add(convSqlViewRelaTab.RelaTabId4SqlView, strComparisonOp);
}
else
{
objvSqlViewRelaTabEN.dicFldComparisonOp[convSqlViewRelaTab.RelaTabId4SqlView] = strComparisonOp;
}
}
return objvSqlViewRelaTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSqlViewRelaTabEN objvSqlViewRelaTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.RelaTabId, objvSqlViewRelaTabCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.SqlViewId, objvSqlViewRelaTabCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.SqlViewCNName) == true)
{
string strComparisonOpSqlViewCNName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.SqlViewCNName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.SqlViewCNName, objvSqlViewRelaTabCond.SqlViewCNName, strComparisonOpSqlViewCNName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.SqlViewName) == true)
{
string strComparisonOpSqlViewName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.SqlViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.SqlViewName, objvSqlViewRelaTabCond.SqlViewName, strComparisonOpSqlViewName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.TabId) == true)
{
string strComparisonOpTabId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.TabId, objvSqlViewRelaTabCond.TabId, strComparisonOpTabId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.TabName) == true)
{
string strComparisonOpTabName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.TabName, objvSqlViewRelaTabCond.TabName, strComparisonOpTabName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.TabCnName) == true)
{
string strComparisonOpTabCnName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.TabCnName, objvSqlViewRelaTabCond.TabCnName, strComparisonOpTabCnName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.TabAliases) == true)
{
string strComparisonOpTabAliases = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.TabAliases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.TabAliases, objvSqlViewRelaTabCond.TabAliases, strComparisonOpTabAliases);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.SvRelaTabTypeName) == true)
{
string strComparisonOpSvRelaTabTypeName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.SvRelaTabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.SvRelaTabTypeName, objvSqlViewRelaTabCond.SvRelaTabTypeName, strComparisonOpSvRelaTabTypeName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.SvRelaTabTypeId) == true)
{
string strComparisonOpSvRelaTabTypeId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.SvRelaTabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.SvRelaTabTypeId, objvSqlViewRelaTabCond.SvRelaTabTypeId, strComparisonOpSvRelaTabTypeId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.TabRelationTypeId) == true)
{
string strComparisonOpTabRelationTypeId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.TabRelationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.TabRelationTypeId, objvSqlViewRelaTabCond.TabRelationTypeId, strComparisonOpTabRelationTypeId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.TabRelationTypeName) == true)
{
string strComparisonOpTabRelationTypeName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.TabRelationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.TabRelationTypeName, objvSqlViewRelaTabCond.TabRelationTypeName, strComparisonOpTabRelationTypeName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.TabRelationText) == true)
{
string strComparisonOpTabRelationText = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.TabRelationText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.TabRelationText, objvSqlViewRelaTabCond.TabRelationText, strComparisonOpTabRelationText);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSqlViewRelaTab.OrderNum, objvSqlViewRelaTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.OtherFldCnName) == true)
{
string strComparisonOpOtherFldCnName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.OtherFldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.OtherFldCnName, objvSqlViewRelaTabCond.OtherFldCnName, strComparisonOpOtherFldCnName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.OtherFldName) == true)
{
string strComparisonOpOtherFldName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.OtherFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.OtherFldName, objvSqlViewRelaTabCond.OtherFldName, strComparisonOpOtherFldName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.OtherTabName) == true)
{
string strComparisonOpOtherTabName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.OtherTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.OtherTabName, objvSqlViewRelaTabCond.OtherTabName, strComparisonOpOtherTabName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.RelaFldCnName) == true)
{
string strComparisonOpRelaFldCnName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.RelaFldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.RelaFldCnName, objvSqlViewRelaTabCond.RelaFldCnName, strComparisonOpRelaFldCnName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.RelaFldName) == true)
{
string strComparisonOpRelaFldName = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.RelaFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.RelaFldName, objvSqlViewRelaTabCond.RelaFldName, strComparisonOpRelaFldName);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.RelaFldId) == true)
{
string strComparisonOpRelaFldId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.RelaFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.RelaFldId, objvSqlViewRelaTabCond.RelaFldId, strComparisonOpRelaFldId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.OtherFldId) == true)
{
string strComparisonOpOtherFldId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.OtherFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.OtherFldId, objvSqlViewRelaTabCond.OtherFldId, strComparisonOpOtherFldId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.OtherTabId) == true)
{
string strComparisonOpOtherTabId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.OtherTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.OtherTabId, objvSqlViewRelaTabCond.OtherTabId, strComparisonOpOtherTabId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.PrjId) == true)
{
string strComparisonOpPrjId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.PrjId, objvSqlViewRelaTabCond.PrjId, strComparisonOpPrjId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.UpdDate, objvSqlViewRelaTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.UpdUserId, objvSqlViewRelaTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.Memo) == true)
{
string strComparisonOpMemo = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.Memo, objvSqlViewRelaTabCond.Memo, strComparisonOpMemo);
}
if (objvSqlViewRelaTabCond.IsUpdated(convSqlViewRelaTab.RelaTabId4SqlView) == true)
{
string strComparisonOpRelaTabId4SqlView = objvSqlViewRelaTabCond.dicFldComparisonOp[convSqlViewRelaTab.RelaTabId4SqlView];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlViewRelaTab.RelaTabId4SqlView, objvSqlViewRelaTabCond.RelaTabId4SqlView, strComparisonOpRelaTabId4SqlView);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vSql视图相关(vSqlViewRelaTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSqlViewRelaTabWApi
{
private static readonly string mstrApiControllerName = "vSqlViewRelaTabApi";

 public clsvSqlViewRelaTabWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRelaTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlViewRelaTabEN GetObjByRelaTabId(string strRelaTabId)
{
if (strRelaTabId == "") return null;
string strAction = "GetObjByRelaTabId";
clsvSqlViewRelaTabEN objvSqlViewRelaTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRelaTabId"] = strRelaTabId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvSqlViewRelaTabEN = JsonConvert.DeserializeObject<clsvSqlViewRelaTabEN>(strJson);
return objvSqlViewRelaTabEN;
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
public static clsvSqlViewRelaTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvSqlViewRelaTabEN objvSqlViewRelaTabEN;
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
objvSqlViewRelaTabEN = JsonConvert.DeserializeObject<clsvSqlViewRelaTabEN>(strJson);
return objvSqlViewRelaTabEN;
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
 /// <param name = "strRelaTabId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlViewRelaTabEN GetObjByRelaTabIdCache(string strRelaTabId,string strPrjId)
{
if (string.IsNullOrEmpty(strRelaTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLst_Sel =
from objvSqlViewRelaTabEN in arrvSqlViewRelaTabObjLstCache
where objvSqlViewRelaTabEN.RelaTabId == strRelaTabId 
select objvSqlViewRelaTabEN;
if (arrvSqlViewRelaTabObjLst_Sel.Count() == 0)
{
   clsvSqlViewRelaTabEN obj = clsvSqlViewRelaTabWApi.GetObjByRelaTabId(strRelaTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSqlViewRelaTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetObjLst(string strWhereCond)
{
 List<clsvSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewRelaTabEN>>(strJson);
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
 /// <param name = "arrRelaTabId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetObjLstByRelaTabIdLst(List<string> arrRelaTabId)
{
 List<clsvSqlViewRelaTabEN> arrObjLst; 
string strAction = "GetObjLstByRelaTabIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelaTabId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewRelaTabEN>>(strJson);
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
 /// <param name = "arrRelaTabId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvSqlViewRelaTabEN> GetObjLstByRelaTabIdLstCache(List<string> arrRelaTabId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLst_Sel =
from objvSqlViewRelaTabEN in arrvSqlViewRelaTabObjLstCache
where arrRelaTabId.Contains(objvSqlViewRelaTabEN.RelaTabId)
select objvSqlViewRelaTabEN;
return arrvSqlViewRelaTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewRelaTabEN>>(strJson);
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
public static List<clsvSqlViewRelaTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewRelaTabEN>>(strJson);
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
public static List<clsvSqlViewRelaTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewRelaTabEN>>(strJson);
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
public static List<clsvSqlViewRelaTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvSqlViewRelaTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewRelaTabEN>>(strJson);
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
public static bool IsExist(string strRelaTabId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRelaTabId"] = strRelaTabId
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
 /// <param name = "objvSqlViewRelaTabENS">源对象</param>
 /// <param name = "objvSqlViewRelaTabENT">目标对象</param>
 public static void CopyTo(clsvSqlViewRelaTabEN objvSqlViewRelaTabENS, clsvSqlViewRelaTabEN objvSqlViewRelaTabENT)
{
try
{
objvSqlViewRelaTabENT.RelaTabId = objvSqlViewRelaTabENS.RelaTabId; //相关表Id
objvSqlViewRelaTabENT.SqlViewId = objvSqlViewRelaTabENS.SqlViewId; //Sql视图Id
objvSqlViewRelaTabENT.SqlViewCNName = objvSqlViewRelaTabENS.SqlViewCNName; //Sql视图中文名
objvSqlViewRelaTabENT.SqlViewName = objvSqlViewRelaTabENS.SqlViewName; //数据视图名称
objvSqlViewRelaTabENT.TabId = objvSqlViewRelaTabENS.TabId; //表ID
objvSqlViewRelaTabENT.TabName = objvSqlViewRelaTabENS.TabName; //表名
objvSqlViewRelaTabENT.TabCnName = objvSqlViewRelaTabENS.TabCnName; //表中文名
objvSqlViewRelaTabENT.TabAliases = objvSqlViewRelaTabENS.TabAliases; //表别名
objvSqlViewRelaTabENT.SvRelaTabTypeName = objvSqlViewRelaTabENS.SvRelaTabTypeName; //Sql视图相关表类型名
objvSqlViewRelaTabENT.SvRelaTabTypeId = objvSqlViewRelaTabENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objvSqlViewRelaTabENT.TabRelationTypeId = objvSqlViewRelaTabENS.TabRelationTypeId; //表关系类型Id
objvSqlViewRelaTabENT.TabRelationTypeName = objvSqlViewRelaTabENS.TabRelationTypeName; //表关系类型名
objvSqlViewRelaTabENT.TabRelationText = objvSqlViewRelaTabENS.TabRelationText; //表关系文本
objvSqlViewRelaTabENT.OrderNum = objvSqlViewRelaTabENS.OrderNum; //序号
objvSqlViewRelaTabENT.OtherFldCnName = objvSqlViewRelaTabENS.OtherFldCnName; //他表字段中文名
objvSqlViewRelaTabENT.OtherFldName = objvSqlViewRelaTabENS.OtherFldName; //他表字段名
objvSqlViewRelaTabENT.OtherTabName = objvSqlViewRelaTabENS.OtherTabName; //他表名
objvSqlViewRelaTabENT.RelaFldCnName = objvSqlViewRelaTabENS.RelaFldCnName; //关系字段中文名
objvSqlViewRelaTabENT.RelaFldName = objvSqlViewRelaTabENS.RelaFldName; //关系字段名
objvSqlViewRelaTabENT.RelaFldId = objvSqlViewRelaTabENS.RelaFldId; //关系字段
objvSqlViewRelaTabENT.OtherFldId = objvSqlViewRelaTabENS.OtherFldId; //其他表字段
objvSqlViewRelaTabENT.OtherTabId = objvSqlViewRelaTabENS.OtherTabId; //其他表Id
objvSqlViewRelaTabENT.PrjId = objvSqlViewRelaTabENS.PrjId; //工程Id
objvSqlViewRelaTabENT.UpdDate = objvSqlViewRelaTabENS.UpdDate; //修改日期
objvSqlViewRelaTabENT.UpdUserId = objvSqlViewRelaTabENS.UpdUserId; //修改用户Id
objvSqlViewRelaTabENT.Memo = objvSqlViewRelaTabENS.Memo; //说明
objvSqlViewRelaTabENT.RelaTabId4SqlView = objvSqlViewRelaTabENS.RelaTabId4SqlView; //RelaTabId4SqlView
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
public static DataTable ToDataTable(List<clsvSqlViewRelaTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSqlViewRelaTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSqlViewRelaTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSqlViewRelaTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSqlViewRelaTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSqlViewRelaTabEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvSqlViewRelaTabWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvSqlViewRelaTabWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvSqlViewRelaTabEN._CurrTabName, strPrjId);
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
public static List<clsvSqlViewRelaTabEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvSqlViewRelaTabWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvSqlViewRelaTabWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvSqlViewRelaTabEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvSqlViewRelaTabEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convSqlViewRelaTab.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvSqlViewRelaTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvSqlViewRelaTabEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvSqlViewRelaTabWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvSqlViewRelaTabWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvSqlViewRelaTabObjLstCache = CacheHelper.Get<List<clsvSqlViewRelaTabEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvSqlViewRelaTabObjLstCache = CacheHelper.Get<List<clsvSqlViewRelaTabEN>>(strKey);
}
return arrvSqlViewRelaTabObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSqlViewRelaTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSqlViewRelaTab.RelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.SqlViewId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.SqlViewCNName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.SqlViewName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.TabAliases, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.SvRelaTabTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.SvRelaTabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.TabRelationTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.TabRelationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.TabRelationText, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convSqlViewRelaTab.OtherFldCnName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.OtherFldName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.OtherTabName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.RelaFldCnName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.RelaFldName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.RelaFldId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.OtherFldId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.OtherTabId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convSqlViewRelaTab.RelaTabId4SqlView, Type.GetType("System.String"));
foreach (clsvSqlViewRelaTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSqlViewRelaTab.RelaTabId] = objInFor[convSqlViewRelaTab.RelaTabId];
objDR[convSqlViewRelaTab.SqlViewId] = objInFor[convSqlViewRelaTab.SqlViewId];
objDR[convSqlViewRelaTab.SqlViewCNName] = objInFor[convSqlViewRelaTab.SqlViewCNName];
objDR[convSqlViewRelaTab.SqlViewName] = objInFor[convSqlViewRelaTab.SqlViewName];
objDR[convSqlViewRelaTab.TabId] = objInFor[convSqlViewRelaTab.TabId];
objDR[convSqlViewRelaTab.TabName] = objInFor[convSqlViewRelaTab.TabName];
objDR[convSqlViewRelaTab.TabCnName] = objInFor[convSqlViewRelaTab.TabCnName];
objDR[convSqlViewRelaTab.TabAliases] = objInFor[convSqlViewRelaTab.TabAliases];
objDR[convSqlViewRelaTab.SvRelaTabTypeName] = objInFor[convSqlViewRelaTab.SvRelaTabTypeName];
objDR[convSqlViewRelaTab.SvRelaTabTypeId] = objInFor[convSqlViewRelaTab.SvRelaTabTypeId];
objDR[convSqlViewRelaTab.TabRelationTypeId] = objInFor[convSqlViewRelaTab.TabRelationTypeId];
objDR[convSqlViewRelaTab.TabRelationTypeName] = objInFor[convSqlViewRelaTab.TabRelationTypeName];
objDR[convSqlViewRelaTab.TabRelationText] = objInFor[convSqlViewRelaTab.TabRelationText];
objDR[convSqlViewRelaTab.OrderNum] = objInFor[convSqlViewRelaTab.OrderNum];
objDR[convSqlViewRelaTab.OtherFldCnName] = objInFor[convSqlViewRelaTab.OtherFldCnName];
objDR[convSqlViewRelaTab.OtherFldName] = objInFor[convSqlViewRelaTab.OtherFldName];
objDR[convSqlViewRelaTab.OtherTabName] = objInFor[convSqlViewRelaTab.OtherTabName];
objDR[convSqlViewRelaTab.RelaFldCnName] = objInFor[convSqlViewRelaTab.RelaFldCnName];
objDR[convSqlViewRelaTab.RelaFldName] = objInFor[convSqlViewRelaTab.RelaFldName];
objDR[convSqlViewRelaTab.RelaFldId] = objInFor[convSqlViewRelaTab.RelaFldId];
objDR[convSqlViewRelaTab.OtherFldId] = objInFor[convSqlViewRelaTab.OtherFldId];
objDR[convSqlViewRelaTab.OtherTabId] = objInFor[convSqlViewRelaTab.OtherTabId];
objDR[convSqlViewRelaTab.PrjId] = objInFor[convSqlViewRelaTab.PrjId];
objDR[convSqlViewRelaTab.UpdDate] = objInFor[convSqlViewRelaTab.UpdDate];
objDR[convSqlViewRelaTab.UpdUserId] = objInFor[convSqlViewRelaTab.UpdUserId];
objDR[convSqlViewRelaTab.Memo] = objInFor[convSqlViewRelaTab.Memo];
objDR[convSqlViewRelaTab.RelaTabId4SqlView] = objInFor[convSqlViewRelaTab.RelaTabId4SqlView];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}