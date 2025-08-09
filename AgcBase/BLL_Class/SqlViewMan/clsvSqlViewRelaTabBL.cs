
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewRelaTabBL
 表名:vSqlViewRelaTab(00050251)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
public static class  clsvSqlViewRelaTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRelaTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlViewRelaTabEN GetObj(this K_RelaTabId_vSqlViewRelaTab myKey)
{
clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = clsvSqlViewRelaTabBL.vSqlViewRelaTabDA.GetObjByRelaTabId(myKey.Value);
return objvSqlViewRelaTabEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaTabId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, convSqlViewRelaTab.RelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, convSqlViewRelaTab.RelaTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSqlViewId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, convSqlViewRelaTab.SqlViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convSqlViewRelaTab.SqlViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convSqlViewRelaTab.SqlViewId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSqlViewCNName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSqlViewCNName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewCNName, 200, convSqlViewRelaTab.SqlViewCNName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSqlViewName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSqlViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewName, convSqlViewRelaTab.SqlViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewName, 100, convSqlViewRelaTab.SqlViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convSqlViewRelaTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convSqlViewRelaTab.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convSqlViewRelaTab.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convSqlViewRelaTab.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabCnName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convSqlViewRelaTab.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabAliases(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabAliases, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabAliases, 100, convSqlViewRelaTab.TabAliases);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSvRelaTabTypeName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSvRelaTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSvRelaTabTypeName, convSqlViewRelaTab.SvRelaTabTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSvRelaTabTypeName, 30, convSqlViewRelaTab.SvRelaTabTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetSvRelaTabTypeId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strSvRelaTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSvRelaTabTypeId, convSqlViewRelaTab.SvRelaTabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSvRelaTabTypeId, 2, convSqlViewRelaTab.SvRelaTabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSvRelaTabTypeId, 2, convSqlViewRelaTab.SvRelaTabTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabRelationTypeId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabRelationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabRelationTypeId, convSqlViewRelaTab.TabRelationTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabRelationTypeId, 2, convSqlViewRelaTab.TabRelationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabRelationTypeId, 2, convSqlViewRelaTab.TabRelationTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabRelationTypeName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabRelationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabRelationTypeName, convSqlViewRelaTab.TabRelationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabRelationTypeName, 30, convSqlViewRelaTab.TabRelationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetTabRelationText(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strTabRelationText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabRelationText, 500, convSqlViewRelaTab.TabRelationText);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherFldCnName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherFldCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOtherFldCnName, 200, convSqlViewRelaTab.OtherFldCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherFldName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOtherFldName, 50, convSqlViewRelaTab.OtherFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherTabName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOtherTabName, 100, convSqlViewRelaTab.OtherTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaFldCnName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaFldCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaFldCnName, 200, convSqlViewRelaTab.RelaFldCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaFldName(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaFldName, 50, convSqlViewRelaTab.RelaFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaFldId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaFldId, 8, convSqlViewRelaTab.RelaFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaFldId, 8, convSqlViewRelaTab.RelaFldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherFldId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOtherFldId, 8, convSqlViewRelaTab.OtherFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOtherFldId, 8, convSqlViewRelaTab.OtherFldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetOtherTabId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strOtherTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOtherTabId, 8, convSqlViewRelaTab.OtherTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOtherTabId, 8, convSqlViewRelaTab.OtherTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetPrjId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlViewRelaTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlViewRelaTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlViewRelaTab.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetUpdDate(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlViewRelaTab.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetUpdUserId(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlViewRelaTab.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetMemo(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlViewRelaTab.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewRelaTabEN SetRelaTabId4SqlView(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN, string strRelaTabId4SqlView, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId4SqlView, 8, convSqlViewRelaTab.RelaTabId4SqlView);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId4SqlView, 8, convSqlViewRelaTab.RelaTabId4SqlView);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabENS">源对象</param>
 /// <param name = "objvSqlViewRelaTabENT">目标对象</param>
 public static void CopyTo(this clsvSqlViewRelaTabEN objvSqlViewRelaTabENS, clsvSqlViewRelaTabEN objvSqlViewRelaTabENT)
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
 /// <param name = "objvSqlViewRelaTabENS">源对象</param>
 /// <returns>目标对象=>clsvSqlViewRelaTabEN:objvSqlViewRelaTabENT</returns>
 public static clsvSqlViewRelaTabEN CopyTo(this clsvSqlViewRelaTabEN objvSqlViewRelaTabENS)
{
try
{
 clsvSqlViewRelaTabEN objvSqlViewRelaTabENT = new clsvSqlViewRelaTabEN()
{
RelaTabId = objvSqlViewRelaTabENS.RelaTabId, //相关表Id
SqlViewId = objvSqlViewRelaTabENS.SqlViewId, //Sql视图Id
SqlViewCNName = objvSqlViewRelaTabENS.SqlViewCNName, //Sql视图中文名
SqlViewName = objvSqlViewRelaTabENS.SqlViewName, //数据视图名称
TabId = objvSqlViewRelaTabENS.TabId, //表ID
TabName = objvSqlViewRelaTabENS.TabName, //表名
TabCnName = objvSqlViewRelaTabENS.TabCnName, //表中文名
TabAliases = objvSqlViewRelaTabENS.TabAliases, //表别名
SvRelaTabTypeName = objvSqlViewRelaTabENS.SvRelaTabTypeName, //Sql视图相关表类型名
SvRelaTabTypeId = objvSqlViewRelaTabENS.SvRelaTabTypeId, //Sql视图相关表类型Id
TabRelationTypeId = objvSqlViewRelaTabENS.TabRelationTypeId, //表关系类型Id
TabRelationTypeName = objvSqlViewRelaTabENS.TabRelationTypeName, //表关系类型名
TabRelationText = objvSqlViewRelaTabENS.TabRelationText, //表关系文本
OrderNum = objvSqlViewRelaTabENS.OrderNum, //序号
OtherFldCnName = objvSqlViewRelaTabENS.OtherFldCnName, //他表字段中文名
OtherFldName = objvSqlViewRelaTabENS.OtherFldName, //他表字段名
OtherTabName = objvSqlViewRelaTabENS.OtherTabName, //他表名
RelaFldCnName = objvSqlViewRelaTabENS.RelaFldCnName, //关系字段中文名
RelaFldName = objvSqlViewRelaTabENS.RelaFldName, //关系字段名
RelaFldId = objvSqlViewRelaTabENS.RelaFldId, //关系字段
OtherFldId = objvSqlViewRelaTabENS.OtherFldId, //其他表字段
OtherTabId = objvSqlViewRelaTabENS.OtherTabId, //其他表Id
PrjId = objvSqlViewRelaTabENS.PrjId, //工程Id
UpdDate = objvSqlViewRelaTabENS.UpdDate, //修改日期
UpdUserId = objvSqlViewRelaTabENS.UpdUserId, //修改用户Id
Memo = objvSqlViewRelaTabENS.Memo, //说明
RelaTabId4SqlView = objvSqlViewRelaTabENS.RelaTabId4SqlView, //RelaTabId4SqlView
};
 return objvSqlViewRelaTabENT;
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
public static void CheckProperty4Condition(this clsvSqlViewRelaTabEN objvSqlViewRelaTabEN)
{
 clsvSqlViewRelaTabBL.vSqlViewRelaTabDA.CheckProperty4Condition(objvSqlViewRelaTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSqlViewRelaTab
{
public virtual bool UpdRelaTabDate(string strRelaTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vSql视图相关(vSqlViewRelaTab)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSqlViewRelaTabBL
{
public static RelatedActions_vSqlViewRelaTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSqlViewRelaTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSqlViewRelaTabDA vSqlViewRelaTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSqlViewRelaTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSqlViewRelaTabBL()
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
if (string.IsNullOrEmpty(clsvSqlViewRelaTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlViewRelaTabEN._ConnectString);
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
public static DataTable GetDataTable_vSqlViewRelaTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSqlViewRelaTabDA.GetDataTable_vSqlViewRelaTab(strWhereCond);
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
objDT = vSqlViewRelaTabDA.GetDataTable(strWhereCond);
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
objDT = vSqlViewRelaTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSqlViewRelaTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSqlViewRelaTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSqlViewRelaTabDA.GetDataTable_Top(objTopPara);
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
objDT = vSqlViewRelaTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSqlViewRelaTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSqlViewRelaTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRelaTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetObjLstByRelaTabIdLst(List<string> arrRelaTabIdLst)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRelaTabIdLst, true);
 string strWhereCond = string.Format("RelaTabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRelaTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSqlViewRelaTabEN> GetObjLstByRelaTabIdLstCache(List<string> arrRelaTabIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLst_Sel =
arrvSqlViewRelaTabObjLstCache
.Where(x => arrRelaTabIdLst.Contains(x.RelaTabId));
return arrvSqlViewRelaTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetObjLst(string strWhereCond)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
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
public static List<clsvSqlViewRelaTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSqlViewRelaTabEN> GetSubObjLstCache(clsvSqlViewRelaTabEN objvSqlViewRelaTabCond)
{
 string strPrjId = objvSqlViewRelaTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvSqlViewRelaTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvSqlViewRelaTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewRelaTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlViewRelaTab._AttributeName)
{
if (objvSqlViewRelaTabCond.IsUpdated(strFldName) == false) continue;
if (objvSqlViewRelaTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewRelaTabCond[strFldName].ToString());
}
else
{
if (objvSqlViewRelaTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlViewRelaTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewRelaTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlViewRelaTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlViewRelaTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlViewRelaTabCond[strFldName]));
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
public static List<clsvSqlViewRelaTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
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
public static List<clsvSqlViewRelaTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
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
List<clsvSqlViewRelaTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSqlViewRelaTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSqlViewRelaTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
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
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
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
public static List<clsvSqlViewRelaTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSqlViewRelaTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
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
public static List<clsvSqlViewRelaTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewRelaTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSqlViewRelaTab(ref clsvSqlViewRelaTabEN objvSqlViewRelaTabEN)
{
bool bolResult = vSqlViewRelaTabDA.GetvSqlViewRelaTab(ref objvSqlViewRelaTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRelaTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlViewRelaTabEN GetObjByRelaTabId(string strRelaTabId)
{
if (strRelaTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRelaTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRelaTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRelaTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = vSqlViewRelaTabDA.GetObjByRelaTabId(strRelaTabId);
return objvSqlViewRelaTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSqlViewRelaTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = vSqlViewRelaTabDA.GetFirstObj(strWhereCond);
 return objvSqlViewRelaTabEN;
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
public static clsvSqlViewRelaTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = vSqlViewRelaTabDA.GetObjByDataRow(objRow);
 return objvSqlViewRelaTabEN;
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
public static clsvSqlViewRelaTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = vSqlViewRelaTabDA.GetObjByDataRow(objRow);
 return objvSqlViewRelaTabEN;
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
 /// <param name = "strRelaTabId">所给的关键字</param>
 /// <param name = "lstvSqlViewRelaTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlViewRelaTabEN GetObjByRelaTabIdFromList(string strRelaTabId, List<clsvSqlViewRelaTabEN> lstvSqlViewRelaTabObjLst)
{
foreach (clsvSqlViewRelaTabEN objvSqlViewRelaTabEN in lstvSqlViewRelaTabObjLst)
{
if (objvSqlViewRelaTabEN.RelaTabId == strRelaTabId)
{
return objvSqlViewRelaTabEN;
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
 string strRelaTabId;
 try
 {
 strRelaTabId = new clsvSqlViewRelaTabDA().GetFirstID(strWhereCond);
 return strRelaTabId;
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
 arrList = vSqlViewRelaTabDA.GetID(strWhereCond);
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
bool bolIsExist = vSqlViewRelaTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRelaTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRelaTabId)
{
if (string.IsNullOrEmpty(strRelaTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRelaTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSqlViewRelaTabDA.IsExist(strRelaTabId);
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
 bolIsExist = clsvSqlViewRelaTabDA.IsExistTable();
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
 bolIsExist = vSqlViewRelaTabDA.IsExistTable(strTabName);
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
 /// <param name = "objvSqlViewRelaTabEN">源简化对象</param>
 public static void SetUpdFlag(clsvSqlViewRelaTabEN objvSqlViewRelaTabEN)
{
try
{
objvSqlViewRelaTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSqlViewRelaTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSqlViewRelaTab.RelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.RelaTabId = objvSqlViewRelaTabEN.RelaTabId; //相关表Id
}
if (arrFldSet.Contains(convSqlViewRelaTab.SqlViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.SqlViewId = objvSqlViewRelaTabEN.SqlViewId; //Sql视图Id
}
if (arrFldSet.Contains(convSqlViewRelaTab.SqlViewCNName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.SqlViewCNName = objvSqlViewRelaTabEN.SqlViewCNName == "[null]" ? null :  objvSqlViewRelaTabEN.SqlViewCNName; //Sql视图中文名
}
if (arrFldSet.Contains(convSqlViewRelaTab.SqlViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.SqlViewName = objvSqlViewRelaTabEN.SqlViewName; //数据视图名称
}
if (arrFldSet.Contains(convSqlViewRelaTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.TabId = objvSqlViewRelaTabEN.TabId == "[null]" ? null :  objvSqlViewRelaTabEN.TabId; //表ID
}
if (arrFldSet.Contains(convSqlViewRelaTab.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.TabName = objvSqlViewRelaTabEN.TabName; //表名
}
if (arrFldSet.Contains(convSqlViewRelaTab.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.TabCnName = objvSqlViewRelaTabEN.TabCnName == "[null]" ? null :  objvSqlViewRelaTabEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convSqlViewRelaTab.TabAliases, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.TabAliases = objvSqlViewRelaTabEN.TabAliases == "[null]" ? null :  objvSqlViewRelaTabEN.TabAliases; //表别名
}
if (arrFldSet.Contains(convSqlViewRelaTab.SvRelaTabTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.SvRelaTabTypeName = objvSqlViewRelaTabEN.SvRelaTabTypeName; //Sql视图相关表类型名
}
if (arrFldSet.Contains(convSqlViewRelaTab.SvRelaTabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.SvRelaTabTypeId = objvSqlViewRelaTabEN.SvRelaTabTypeId; //Sql视图相关表类型Id
}
if (arrFldSet.Contains(convSqlViewRelaTab.TabRelationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.TabRelationTypeId = objvSqlViewRelaTabEN.TabRelationTypeId; //表关系类型Id
}
if (arrFldSet.Contains(convSqlViewRelaTab.TabRelationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.TabRelationTypeName = objvSqlViewRelaTabEN.TabRelationTypeName; //表关系类型名
}
if (arrFldSet.Contains(convSqlViewRelaTab.TabRelationText, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.TabRelationText = objvSqlViewRelaTabEN.TabRelationText == "[null]" ? null :  objvSqlViewRelaTabEN.TabRelationText; //表关系文本
}
if (arrFldSet.Contains(convSqlViewRelaTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.OrderNum = objvSqlViewRelaTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(convSqlViewRelaTab.OtherFldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.OtherFldCnName = objvSqlViewRelaTabEN.OtherFldCnName == "[null]" ? null :  objvSqlViewRelaTabEN.OtherFldCnName; //他表字段中文名
}
if (arrFldSet.Contains(convSqlViewRelaTab.OtherFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.OtherFldName = objvSqlViewRelaTabEN.OtherFldName == "[null]" ? null :  objvSqlViewRelaTabEN.OtherFldName; //他表字段名
}
if (arrFldSet.Contains(convSqlViewRelaTab.OtherTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.OtherTabName = objvSqlViewRelaTabEN.OtherTabName == "[null]" ? null :  objvSqlViewRelaTabEN.OtherTabName; //他表名
}
if (arrFldSet.Contains(convSqlViewRelaTab.RelaFldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.RelaFldCnName = objvSqlViewRelaTabEN.RelaFldCnName == "[null]" ? null :  objvSqlViewRelaTabEN.RelaFldCnName; //关系字段中文名
}
if (arrFldSet.Contains(convSqlViewRelaTab.RelaFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.RelaFldName = objvSqlViewRelaTabEN.RelaFldName == "[null]" ? null :  objvSqlViewRelaTabEN.RelaFldName; //关系字段名
}
if (arrFldSet.Contains(convSqlViewRelaTab.RelaFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.RelaFldId = objvSqlViewRelaTabEN.RelaFldId == "[null]" ? null :  objvSqlViewRelaTabEN.RelaFldId; //关系字段
}
if (arrFldSet.Contains(convSqlViewRelaTab.OtherFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.OtherFldId = objvSqlViewRelaTabEN.OtherFldId == "[null]" ? null :  objvSqlViewRelaTabEN.OtherFldId; //其他表字段
}
if (arrFldSet.Contains(convSqlViewRelaTab.OtherTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.OtherTabId = objvSqlViewRelaTabEN.OtherTabId == "[null]" ? null :  objvSqlViewRelaTabEN.OtherTabId; //其他表Id
}
if (arrFldSet.Contains(convSqlViewRelaTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.PrjId = objvSqlViewRelaTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convSqlViewRelaTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.UpdDate = objvSqlViewRelaTabEN.UpdDate == "[null]" ? null :  objvSqlViewRelaTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSqlViewRelaTab.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.UpdUserId = objvSqlViewRelaTabEN.UpdUserId == "[null]" ? null :  objvSqlViewRelaTabEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convSqlViewRelaTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.Memo = objvSqlViewRelaTabEN.Memo == "[null]" ? null :  objvSqlViewRelaTabEN.Memo; //说明
}
if (arrFldSet.Contains(convSqlViewRelaTab.RelaTabId4SqlView, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewRelaTabEN.RelaTabId4SqlView = objvSqlViewRelaTabEN.RelaTabId4SqlView == "[null]" ? null :  objvSqlViewRelaTabEN.RelaTabId4SqlView; //RelaTabId4SqlView
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
 /// <param name = "objvSqlViewRelaTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSqlViewRelaTabEN objvSqlViewRelaTabEN)
{
try
{
if (objvSqlViewRelaTabEN.SqlViewCNName == "[null]") objvSqlViewRelaTabEN.SqlViewCNName = null; //Sql视图中文名
if (objvSqlViewRelaTabEN.TabId == "[null]") objvSqlViewRelaTabEN.TabId = null; //表ID
if (objvSqlViewRelaTabEN.TabCnName == "[null]") objvSqlViewRelaTabEN.TabCnName = null; //表中文名
if (objvSqlViewRelaTabEN.TabAliases == "[null]") objvSqlViewRelaTabEN.TabAliases = null; //表别名
if (objvSqlViewRelaTabEN.TabRelationText == "[null]") objvSqlViewRelaTabEN.TabRelationText = null; //表关系文本
if (objvSqlViewRelaTabEN.OtherFldCnName == "[null]") objvSqlViewRelaTabEN.OtherFldCnName = null; //他表字段中文名
if (objvSqlViewRelaTabEN.OtherFldName == "[null]") objvSqlViewRelaTabEN.OtherFldName = null; //他表字段名
if (objvSqlViewRelaTabEN.OtherTabName == "[null]") objvSqlViewRelaTabEN.OtherTabName = null; //他表名
if (objvSqlViewRelaTabEN.RelaFldCnName == "[null]") objvSqlViewRelaTabEN.RelaFldCnName = null; //关系字段中文名
if (objvSqlViewRelaTabEN.RelaFldName == "[null]") objvSqlViewRelaTabEN.RelaFldName = null; //关系字段名
if (objvSqlViewRelaTabEN.RelaFldId == "[null]") objvSqlViewRelaTabEN.RelaFldId = null; //关系字段
if (objvSqlViewRelaTabEN.OtherFldId == "[null]") objvSqlViewRelaTabEN.OtherFldId = null; //其他表字段
if (objvSqlViewRelaTabEN.OtherTabId == "[null]") objvSqlViewRelaTabEN.OtherTabId = null; //其他表Id
if (objvSqlViewRelaTabEN.UpdDate == "[null]") objvSqlViewRelaTabEN.UpdDate = null; //修改日期
if (objvSqlViewRelaTabEN.UpdUserId == "[null]") objvSqlViewRelaTabEN.UpdUserId = null; //修改用户Id
if (objvSqlViewRelaTabEN.Memo == "[null]") objvSqlViewRelaTabEN.Memo = null; //说明
if (objvSqlViewRelaTabEN.RelaTabId4SqlView == "[null]") objvSqlViewRelaTabEN.RelaTabId4SqlView = null; //RelaTabId4SqlView
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
public static void CheckProperty4Condition(clsvSqlViewRelaTabEN objvSqlViewRelaTabEN)
{
 vSqlViewRelaTabDA.CheckProperty4Condition(objvSqlViewRelaTabEN);
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabRelationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabRelationTypeBL没有刷新缓存机制(clsTabRelationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSqlViewRelaTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlViewRelaTabBL没有刷新缓存机制(clsSqlViewRelaTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSV_RelaTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSV_RelaTabTypeBL没有刷新缓存机制(clsSV_RelaTabTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSqlViewBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlViewBL没有刷新缓存机制(clsSqlViewBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTextResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTextResourceTypeBL没有刷新缓存机制(clsTextResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelaTabId");
//if (arrvSqlViewRelaTabObjLstCache == null)
//{
//arrvSqlViewRelaTabObjLstCache = vSqlViewRelaTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRelaTabId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlViewRelaTabEN GetObjByRelaTabIdCache(string strRelaTabId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLst_Sel =
arrvSqlViewRelaTabObjLstCache
.Where(x=> x.RelaTabId == strRelaTabId 
);
if (arrvSqlViewRelaTabObjLst_Sel.Count() == 0)
{
   clsvSqlViewRelaTabEN obj = clsvSqlViewRelaTabBL.GetObjByRelaTabId(strRelaTabId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strRelaTabId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvSqlViewRelaTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetAllvSqlViewRelaTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId); 
return arrvSqlViewRelaTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlViewRelaTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvSqlViewRelaTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvSqlViewRelaTabObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvSqlViewRelaTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvSqlViewRelaTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvSqlViewRelaTabEN._RefreshTimeLst.Count == 0) return "";
return clsvSqlViewRelaTabEN._RefreshTimeLst[clsvSqlViewRelaTabEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strRelaTabId, string strPrjId)
{
if (strInFldName != convSqlViewRelaTab.RelaTabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSqlViewRelaTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSqlViewRelaTab._AttributeName));
throw new Exception(strMsg);
}
var objvSqlViewRelaTab = clsvSqlViewRelaTabBL.GetObjByRelaTabIdCache(strRelaTabId, strPrjId);
if (objvSqlViewRelaTab == null) return "";
return objvSqlViewRelaTab[strOutFldName].ToString();
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
int intRecCount = clsvSqlViewRelaTabDA.GetRecCount(strTabName);
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
int intRecCount = clsvSqlViewRelaTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSqlViewRelaTabDA.GetRecCount();
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
int intRecCount = clsvSqlViewRelaTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSqlViewRelaTabEN objvSqlViewRelaTabCond)
{
 string strPrjId = objvSqlViewRelaTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvSqlViewRelaTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvSqlViewRelaTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewRelaTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlViewRelaTab._AttributeName)
{
if (objvSqlViewRelaTabCond.IsUpdated(strFldName) == false) continue;
if (objvSqlViewRelaTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewRelaTabCond[strFldName].ToString());
}
else
{
if (objvSqlViewRelaTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlViewRelaTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewRelaTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlViewRelaTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlViewRelaTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlViewRelaTabCond[strFldName]));
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
 List<string> arrList = clsvSqlViewRelaTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSqlViewRelaTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSqlViewRelaTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}