
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabWApi
 表名:vPrjTab(00050124)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:17
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvPrjTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabId(this clsvPrjTabEN objvPrjTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab.TabId);
objvPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabId) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabId, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabId] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabName(this clsvPrjTabEN objvPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab.TabName);
objvPrjTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabCnName(this clsvPrjTabEN objvPrjTabEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCnName, convPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjTab.TabCnName);
objvPrjTabEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabCnName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabCnName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabCnName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetPrjId(this clsvPrjTabEN objvPrjTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTab.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTab.PrjId);
objvPrjTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.PrjId) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.PrjId, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.PrjId] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetSqlDsTypeId(this clsvPrjTabEN objvPrjTabEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab.SqlDsTypeId);
objvPrjTabEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.SqlDsTypeId) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.SqlDsTypeId, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.SqlDsTypeId] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabStateId(this clsvPrjTabEN objvPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab.TabStateId);
objvPrjTabEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabStateId) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabStateId, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabStateId] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetFuncModuleAgcId(this clsvPrjTabEN objvPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab.FuncModuleAgcId);
objvPrjTabEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.FuncModuleAgcId) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.FuncModuleAgcId, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.FuncModuleAgcId] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetFuncModuleEnName(this clsvPrjTabEN objvPrjTabEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convPrjTab.FuncModuleEnName);
objvPrjTabEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.FuncModuleEnName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.FuncModuleEnName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.FuncModuleEnName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsReleToSqlTab">是否与SQL表相关</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsReleToSqlTab(this clsvPrjTabEN objvPrjTabEN, bool bolIsReleToSqlTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsReleToSqlTab, convPrjTab.IsReleToSqlTab);
objvPrjTabEN.IsReleToSqlTab = bolIsReleToSqlTab; //是否与SQL表相关
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsReleToSqlTab) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsReleToSqlTab, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsReleToSqlTab] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetKeyword(this clsvPrjTabEN objvPrjTabEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 50, convPrjTab.Keyword);
objvPrjTabEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.Keyword) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.Keyword, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.Keyword] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabTypeId(this clsvPrjTabEN objvPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab.TabTypeId);
objvPrjTabEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabTypeId) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabTypeId, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabTypeId] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeId">表主类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabMainTypeId(this clsvPrjTabEN objvPrjTabEN, string strTabMainTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, convPrjTab.TabMainTypeId);
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, convPrjTab.TabMainTypeId);
objvPrjTabEN.TabMainTypeId = strTabMainTypeId; //表主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabMainTypeId) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabMainTypeId, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabMainTypeId] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId4View">视图的相关表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetRelaTabId4View(this clsvPrjTabEN objvPrjTabEN, string strRelaTabId4View, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId4View, 8, convPrjTab.RelaTabId4View);
clsCheckSql.CheckFieldForeignKey(strRelaTabId4View, 8, convPrjTab.RelaTabId4View);
objvPrjTabEN.RelaTabId4View = strRelaTabId4View; //视图的相关表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.RelaTabId4View) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.RelaTabId4View, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.RelaTabId4View] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGeneIndexer">是否需要生成索引器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsNeedGeneIndexer(this clsvPrjTabEN objvPrjTabEN, bool bolIsNeedGeneIndexer, string strComparisonOp="")
	{
objvPrjTabEN.IsNeedGeneIndexer = bolIsNeedGeneIndexer; //是否需要生成索引器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsNeedGeneIndexer) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsNeedGeneIndexer, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsNeedGeneIndexer] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentClass">父类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetParentClass(this clsvPrjTabEN objvPrjTabEN, string strParentClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentClass, 50, convPrjTab.ParentClass);
objvPrjTabEN.ParentClass = strParentClass; //父类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.ParentClass) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.ParentClass, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.ParentClass] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUseCache">是否使用Cache</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsUseCache(this clsvPrjTabEN objvPrjTabEN, bool bolIsUseCache, string strComparisonOp="")
	{
objvPrjTabEN.IsUseCache = bolIsUseCache; //是否使用Cache
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsUseCache) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsUseCache, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsUseCache] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsShare">是否共享</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsShare(this clsvPrjTabEN objvPrjTabEN, bool bolIsShare, string strComparisonOp="")
	{
objvPrjTabEN.IsShare = bolIsShare; //是否共享
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsShare) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsShare, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsShare] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheClassifyField">缓存分类字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetCacheClassifyField(this clsvPrjTabEN objvPrjTabEN, string strCacheClassifyField, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheClassifyField, 8, convPrjTab.CacheClassifyField);
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField, 8, convPrjTab.CacheClassifyField);
objvPrjTabEN.CacheClassifyField = strCacheClassifyField; //缓存分类字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.CacheClassifyField) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.CacheClassifyField, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.CacheClassifyField] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheModeId">缓存方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetCacheModeId(this clsvPrjTabEN objvPrjTabEN, string strCacheModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, convPrjTab.CacheModeId);
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, convPrjTab.CacheModeId);
objvPrjTabEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.CacheModeId) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.CacheModeId, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.CacheModeId] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRefresh4RelaView">是否刷新相关视图</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsRefresh4RelaView(this clsvPrjTabEN objvPrjTabEN, bool bolIsRefresh4RelaView, string strComparisonOp="")
	{
objvPrjTabEN.IsRefresh4RelaView = bolIsRefresh4RelaView; //是否刷新相关视图
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsRefresh4RelaView) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsRefresh4RelaView, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsRefresh4RelaView] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabRecNum">记录数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabRecNum(this clsvPrjTabEN objvPrjTabEN, int intTabRecNum, string strComparisonOp="")
	{
objvPrjTabEN.TabRecNum = intTabRecNum; //记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabRecNum) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabRecNum, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabRecNum] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetErrMsg(this clsvPrjTabEN objvPrjTabEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrMsg, convPrjTab.ErrMsg);
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convPrjTab.ErrMsg);
objvPrjTabEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.ErrMsg) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.ErrMsg, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.ErrMsg] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetUpdUserId(this clsvPrjTabEN objvPrjTabEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convPrjTab.UpdUserId);
objvPrjTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.UpdUserId) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.UpdUserId, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.UpdUserId] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetUpdDate(this clsvPrjTabEN objvPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjTab.UpdDate);
objvPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.UpdDate) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.UpdDate, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.UpdDate] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetMemo(this clsvPrjTabEN objvPrjTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjTab.Memo);
objvPrjTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.Memo) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.Memo, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.Memo] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetOrderNum4Refer(this clsvPrjTabEN objvPrjTabEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objvPrjTabEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.OrderNum4Refer) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.OrderNum4Refer, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.OrderNum4Refer] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetFuncModuleName(this clsvPrjTabEN objvPrjTabEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convPrjTab.FuncModuleName);
objvPrjTabEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.FuncModuleName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.FuncModuleName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.FuncModuleName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldNum">字段数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetFldNum(this clsvPrjTabEN objvPrjTabEN, int intFldNum, string strComparisonOp="")
	{
objvPrjTabEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.FldNum) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.FldNum, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.FldNum] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetSqlDsTypeName(this clsvPrjTabEN objvPrjTabEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convPrjTab.SqlDsTypeName);
objvPrjTabEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.SqlDsTypeName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.SqlDsTypeName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.SqlDsTypeName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateName">表状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabStateName(this clsvPrjTabEN objvPrjTabEN, string strTabStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabStateName, 30, convPrjTab.TabStateName);
objvPrjTabEN.TabStateName = strTabStateName; //表状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabStateName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabStateName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabStateName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeName">表主类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabMainTypeName(this clsvPrjTabEN objvPrjTabEN, string strTabMainTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabMainTypeName, 30, convPrjTab.TabMainTypeName);
objvPrjTabEN.TabMainTypeName = strTabMainTypeName; //表主类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabMainTypeName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabMainTypeName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabMainTypeName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeName">表类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabTypeName(this clsvPrjTabEN objvPrjTabEN, string strTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convPrjTab.TabTypeName);
objvPrjTabEN.TabTypeName = strTabTypeName; //表类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabTypeName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabTypeName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabTypeName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabName4View">RelaTabName4View</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetRelaTabName4View(this clsvPrjTabEN objvPrjTabEN, string strRelaTabName4View, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabName4View, 100, convPrjTab.RelaTabName4View);
objvPrjTabEN.RelaTabName4View = strRelaTabName4View; //RelaTabName4View
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.RelaTabName4View) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.RelaTabName4View, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.RelaTabName4View] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetPrjName(this clsvPrjTabEN objvPrjTabEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjTab.PrjName);
objvPrjTabEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.PrjName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.PrjName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.PrjName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsChecked">是否核实</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsChecked(this clsvPrjTabEN objvPrjTabEN, bool bolIsChecked, string strComparisonOp="")
	{
objvPrjTabEN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsChecked) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsChecked, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsChecked] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOwner">拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetOwner(this clsvPrjTabEN objvPrjTabEN, string strOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwner, 50, convPrjTab.Owner);
objvPrjTabEN.Owner = strOwner; //拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.Owner) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.Owner, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.Owner] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabEnName">表英文详细名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabEnName(this clsvPrjTabEN objvPrjTabEN, string strTabEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabEnName, 200, convPrjTab.TabEnName);
objvPrjTabEN.TabEnName = strTabEnName; //表英文详细名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabEnName) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabEnName, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabEnName] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsNeedTransCode(this clsvPrjTabEN objvPrjTabEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, convPrjTab.IsNeedTransCode);
objvPrjTabEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsNeedTransCode) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsNeedTransCode, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsNeedTransCode] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabNameB">表名_后备</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabNameB(this clsvPrjTabEN objvPrjTabEN, string strTabNameB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabNameB, convPrjTab.TabNameB);
clsCheckSql.CheckFieldLen(strTabNameB, 50, convPrjTab.TabNameB);
objvPrjTabEN.TabNameB = strTabNameB; //表名_后备
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.TabNameB) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.TabNameB, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.TabNameB] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNationStandard">是否国标</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsNationStandard(this clsvPrjTabEN objvPrjTabEN, bool bolIsNationStandard, string strComparisonOp="")
	{
objvPrjTabEN.IsNationStandard = bolIsNationStandard; //是否国标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsNationStandard) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsNationStandard, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsNationStandard] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsParaTab">是否参数表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsParaTab(this clsvPrjTabEN objvPrjTabEN, bool bolIsParaTab, string strComparisonOp="")
	{
objvPrjTabEN.IsParaTab = bolIsParaTab; //是否参数表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsParaTab) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsParaTab, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsParaTab] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsArchive">是否存档</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetIsArchive(this clsvPrjTabEN objvPrjTabEN, bool bolIsArchive, string strComparisonOp="")
	{
objvPrjTabEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.IsArchive) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.IsArchive, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.IsArchive] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate2">UpdDate2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetUpdDate2(this clsvPrjTabEN objvPrjTabEN, string strUpdDate2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate2, 20, convPrjTab.UpdDate2);
objvPrjTabEN.UpdDate2 = strUpdDate2; //UpdDate2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.UpdDate2) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.UpdDate2, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.UpdDate2] = strComparisonOp;
}
}
return objvPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseNameTab">DataBaseName_Tab</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetDataBaseNameTab(this clsvPrjTabEN objvPrjTabEN, string strDataBaseNameTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseNameTab, 50, convPrjTab.DataBaseNameTab);
objvPrjTabEN.DataBaseNameTab = strDataBaseNameTab; //DataBaseName_Tab
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabEN.dicFldComparisonOp.ContainsKey(convPrjTab.DataBaseNameTab) == false)
{
objvPrjTabEN.dicFldComparisonOp.Add(convPrjTab.DataBaseNameTab, strComparisonOp);
}
else
{
objvPrjTabEN.dicFldComparisonOp[convPrjTab.DataBaseNameTab] = strComparisonOp;
}
}
return objvPrjTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTabEN objvPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTabCond.IsUpdated(convPrjTab.TabId) == true)
{
string strComparisonOpTabId = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabId, objvPrjTabCond.TabId, strComparisonOpTabId);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabName) == true)
{
string strComparisonOpTabName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabName, objvPrjTabCond.TabName, strComparisonOpTabName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabCnName) == true)
{
string strComparisonOpTabCnName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabCnName, objvPrjTabCond.TabCnName, strComparisonOpTabCnName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTabCond.dicFldComparisonOp[convPrjTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.PrjId, objvPrjTabCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvPrjTabCond.dicFldComparisonOp[convPrjTab.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.SqlDsTypeId, objvPrjTabCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabStateId) == true)
{
string strComparisonOpTabStateId = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabStateId, objvPrjTabCond.TabStateId, strComparisonOpTabStateId);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvPrjTabCond.dicFldComparisonOp[convPrjTab.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.FuncModuleAgcId, objvPrjTabCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.FuncModuleEnName, objvPrjTabCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsReleToSqlTab) == true)
{
if (objvPrjTabCond.IsReleToSqlTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsReleToSqlTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsReleToSqlTab);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.Keyword) == true)
{
string strComparisonOpKeyword = objvPrjTabCond.dicFldComparisonOp[convPrjTab.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.Keyword, objvPrjTabCond.Keyword, strComparisonOpKeyword);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabTypeId, objvPrjTabCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabMainTypeId) == true)
{
string strComparisonOpTabMainTypeId = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabMainTypeId, objvPrjTabCond.TabMainTypeId, strComparisonOpTabMainTypeId);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.RelaTabId4View) == true)
{
string strComparisonOpRelaTabId4View = objvPrjTabCond.dicFldComparisonOp[convPrjTab.RelaTabId4View];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.RelaTabId4View, objvPrjTabCond.RelaTabId4View, strComparisonOpRelaTabId4View);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsNeedGeneIndexer) == true)
{
if (objvPrjTabCond.IsNeedGeneIndexer == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsNeedGeneIndexer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsNeedGeneIndexer);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.ParentClass) == true)
{
string strComparisonOpParentClass = objvPrjTabCond.dicFldComparisonOp[convPrjTab.ParentClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.ParentClass, objvPrjTabCond.ParentClass, strComparisonOpParentClass);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsUseCache) == true)
{
if (objvPrjTabCond.IsUseCache == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsUseCache);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsUseCache);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsShare) == true)
{
if (objvPrjTabCond.IsShare == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsShare);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsShare);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.CacheClassifyField) == true)
{
string strComparisonOpCacheClassifyField = objvPrjTabCond.dicFldComparisonOp[convPrjTab.CacheClassifyField];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.CacheClassifyField, objvPrjTabCond.CacheClassifyField, strComparisonOpCacheClassifyField);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objvPrjTabCond.dicFldComparisonOp[convPrjTab.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.CacheModeId, objvPrjTabCond.CacheModeId, strComparisonOpCacheModeId);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsRefresh4RelaView) == true)
{
if (objvPrjTabCond.IsRefresh4RelaView == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsRefresh4RelaView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsRefresh4RelaView);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabRecNum) == true)
{
string strComparisonOpTabRecNum = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab.TabRecNum, objvPrjTabCond.TabRecNum, strComparisonOpTabRecNum);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.ErrMsg) == true)
{
string strComparisonOpErrMsg = objvPrjTabCond.dicFldComparisonOp[convPrjTab.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.ErrMsg, objvPrjTabCond.ErrMsg, strComparisonOpErrMsg);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvPrjTabCond.dicFldComparisonOp[convPrjTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.UpdUserId, objvPrjTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjTabCond.dicFldComparisonOp[convPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.UpdDate, objvPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.Memo) == true)
{
string strComparisonOpMemo = objvPrjTabCond.dicFldComparisonOp[convPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.Memo, objvPrjTabCond.Memo, strComparisonOpMemo);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvPrjTabCond.dicFldComparisonOp[convPrjTab.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab.OrderNum4Refer, objvPrjTabCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.FuncModuleName, objvPrjTabCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.FldNum) == true)
{
string strComparisonOpFldNum = objvPrjTabCond.dicFldComparisonOp[convPrjTab.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab.FldNum, objvPrjTabCond.FldNum, strComparisonOpFldNum);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.SqlDsTypeName, objvPrjTabCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabStateName) == true)
{
string strComparisonOpTabStateName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabStateName, objvPrjTabCond.TabStateName, strComparisonOpTabStateName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabMainTypeName) == true)
{
string strComparisonOpTabMainTypeName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabMainTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabMainTypeName, objvPrjTabCond.TabMainTypeName, strComparisonOpTabMainTypeName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabTypeName) == true)
{
string strComparisonOpTabTypeName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabTypeName, objvPrjTabCond.TabTypeName, strComparisonOpTabTypeName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.RelaTabName4View) == true)
{
string strComparisonOpRelaTabName4View = objvPrjTabCond.dicFldComparisonOp[convPrjTab.RelaTabName4View];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.RelaTabName4View, objvPrjTabCond.RelaTabName4View, strComparisonOpRelaTabName4View);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.PrjName, objvPrjTabCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsChecked) == true)
{
if (objvPrjTabCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsChecked);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.Owner) == true)
{
string strComparisonOpOwner = objvPrjTabCond.dicFldComparisonOp[convPrjTab.Owner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.Owner, objvPrjTabCond.Owner, strComparisonOpOwner);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabEnName) == true)
{
string strComparisonOpTabEnName = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabEnName, objvPrjTabCond.TabEnName, strComparisonOpTabEnName);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsNeedTransCode) == true)
{
if (objvPrjTabCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsNeedTransCode);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.TabNameB) == true)
{
string strComparisonOpTabNameB = objvPrjTabCond.dicFldComparisonOp[convPrjTab.TabNameB];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.TabNameB, objvPrjTabCond.TabNameB, strComparisonOpTabNameB);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsNationStandard) == true)
{
if (objvPrjTabCond.IsNationStandard == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsNationStandard);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsNationStandard);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsParaTab) == true)
{
if (objvPrjTabCond.IsParaTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsParaTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsParaTab);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.IsArchive) == true)
{
if (objvPrjTabCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab.IsArchive);
}
}
if (objvPrjTabCond.IsUpdated(convPrjTab.UpdDate2) == true)
{
string strComparisonOpUpdDate2 = objvPrjTabCond.dicFldComparisonOp[convPrjTab.UpdDate2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.UpdDate2, objvPrjTabCond.UpdDate2, strComparisonOpUpdDate2);
}
if (objvPrjTabCond.IsUpdated(convPrjTab.DataBaseNameTab) == true)
{
string strComparisonOpDataBaseNameTab = objvPrjTabCond.dicFldComparisonOp[convPrjTab.DataBaseNameTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab.DataBaseNameTab, objvPrjTabCond.DataBaseNameTab, strComparisonOpDataBaseNameTab);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程表(vPrjTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabWApi
{
private static readonly string mstrApiControllerName = "vPrjTabApi";

 public clsvPrjTabWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabEN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsvPrjTabEN objvPrjTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabId"] = strTabId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvPrjTabEN = JsonConvert.DeserializeObject<clsvPrjTabEN>(strJson);
return objvPrjTabEN;
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
public static clsvPrjTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjTabEN objvPrjTabEN;
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
objvPrjTabEN = JsonConvert.DeserializeObject<clsvPrjTabEN>(strJson);
return objvPrjTabEN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabEN GetObjByTabIdCache(string strTabId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
List<clsvPrjTabEN> arrvPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabEN> arrvPrjTabObjLst_Sel =
from objvPrjTabEN in arrvPrjTabObjLstCache
where objvPrjTabEN.TabId == strTabId 
select objvPrjTabEN;
if (arrvPrjTabObjLst_Sel.Count() == 0)
{
   clsvPrjTabEN obj = clsvPrjTabWApi.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabEN>>(strJson);
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
 /// <param name = "arrTabId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsvPrjTabEN> arrObjLst; 
string strAction = "GetObjLstByTabIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTabId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabEN>>(strJson);
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
 /// <param name = "arrTabId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvPrjTabEN> GetObjLstByTabIdLstCache(List<string> arrTabId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
List<clsvPrjTabEN> arrvPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabEN> arrvPrjTabObjLst_Sel =
from objvPrjTabEN in arrvPrjTabObjLstCache
where arrTabId.Contains(objvPrjTabEN.TabId)
select objvPrjTabEN;
return arrvPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabEN>>(strJson);
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
public static List<clsvPrjTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabEN>>(strJson);
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
public static List<clsvPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabEN>>(strJson);
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
public static List<clsvPrjTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabEN>>(strJson);
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
public static bool IsExist(string strTabId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabId"] = strTabId
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
 /// <param name = "objvPrjTabENS">源对象</param>
 /// <param name = "objvPrjTabENT">目标对象</param>
 public static void CopyTo(clsvPrjTabEN objvPrjTabENS, clsvPrjTabEN objvPrjTabENT)
{
try
{
objvPrjTabENT.TabId = objvPrjTabENS.TabId; //表ID
objvPrjTabENT.TabName = objvPrjTabENS.TabName; //表名
objvPrjTabENT.TabCnName = objvPrjTabENS.TabCnName; //表中文名
objvPrjTabENT.PrjId = objvPrjTabENS.PrjId; //工程Id
objvPrjTabENT.SqlDsTypeId = objvPrjTabENS.SqlDsTypeId; //数据源类型Id
objvPrjTabENT.TabStateId = objvPrjTabENS.TabStateId; //表状态ID
objvPrjTabENT.FuncModuleAgcId = objvPrjTabENS.FuncModuleAgcId; //功能模块Id
objvPrjTabENT.FuncModuleEnName = objvPrjTabENS.FuncModuleEnName; //功能模块英文名称
objvPrjTabENT.IsReleToSqlTab = objvPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTabENT.Keyword = objvPrjTabENS.Keyword; //关键字
objvPrjTabENT.TabTypeId = objvPrjTabENS.TabTypeId; //表类型Id
objvPrjTabENT.TabMainTypeId = objvPrjTabENS.TabMainTypeId; //表主类型Id
objvPrjTabENT.RelaTabId4View = objvPrjTabENS.RelaTabId4View; //视图的相关表ID
objvPrjTabENT.IsNeedGeneIndexer = objvPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTabENT.ParentClass = objvPrjTabENS.ParentClass; //父类
objvPrjTabENT.IsUseCache = objvPrjTabENS.IsUseCache; //是否使用Cache
objvPrjTabENT.IsShare = objvPrjTabENS.IsShare; //是否共享
objvPrjTabENT.CacheClassifyField = objvPrjTabENS.CacheClassifyField; //缓存分类字段
objvPrjTabENT.CacheModeId = objvPrjTabENS.CacheModeId; //缓存方式Id
objvPrjTabENT.IsRefresh4RelaView = objvPrjTabENS.IsRefresh4RelaView; //是否刷新相关视图
objvPrjTabENT.TabRecNum = objvPrjTabENS.TabRecNum; //记录数
objvPrjTabENT.ErrMsg = objvPrjTabENS.ErrMsg; //错误信息
objvPrjTabENT.UpdUserId = objvPrjTabENS.UpdUserId; //修改用户Id
objvPrjTabENT.UpdDate = objvPrjTabENS.UpdDate; //修改日期
objvPrjTabENT.Memo = objvPrjTabENS.Memo; //说明
objvPrjTabENT.OrderNum4Refer = objvPrjTabENS.OrderNum4Refer; //引用序号
objvPrjTabENT.FuncModuleName = objvPrjTabENS.FuncModuleName; //功能模块名称
objvPrjTabENT.FldNum = objvPrjTabENS.FldNum; //字段数
objvPrjTabENT.SqlDsTypeName = objvPrjTabENS.SqlDsTypeName; //Sql数据源名
objvPrjTabENT.TabStateName = objvPrjTabENS.TabStateName; //表状态名称
objvPrjTabENT.TabMainTypeName = objvPrjTabENS.TabMainTypeName; //表主类型名
objvPrjTabENT.TabTypeName = objvPrjTabENS.TabTypeName; //表类型名
objvPrjTabENT.RelaTabName4View = objvPrjTabENS.RelaTabName4View; //RelaTabName4View
objvPrjTabENT.PrjName = objvPrjTabENS.PrjName; //工程名称
objvPrjTabENT.IsChecked = objvPrjTabENS.IsChecked; //是否核实
objvPrjTabENT.Owner = objvPrjTabENS.Owner; //拥有者
objvPrjTabENT.TabEnName = objvPrjTabENS.TabEnName; //表英文详细名
objvPrjTabENT.IsNeedTransCode = objvPrjTabENS.IsNeedTransCode; //是否需要转换代码
objvPrjTabENT.TabNameB = objvPrjTabENS.TabNameB; //表名_后备
objvPrjTabENT.IsNationStandard = objvPrjTabENS.IsNationStandard; //是否国标
objvPrjTabENT.IsParaTab = objvPrjTabENS.IsParaTab; //是否参数表
objvPrjTabENT.IsArchive = objvPrjTabENS.IsArchive; //是否存档
objvPrjTabENT.UpdDate2 = objvPrjTabENS.UpdDate2; //UpdDate2
objvPrjTabENT.DataBaseNameTab = objvPrjTabENS.DataBaseNameTab; //DataBaseName_Tab
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
public static DataTable ToDataTable(List<clsvPrjTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjTabEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTabWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTabWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
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
public static List<clsvPrjTabEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTabWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTabWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvPrjTabEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvPrjTabEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convPrjTab.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
List<clsvPrjTabEN> arrvPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvPrjTabEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTabWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTabWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
List<clsvPrjTabEN> arrvPrjTabObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvPrjTabObjLstCache = CacheHelper.Get<List<clsvPrjTabEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvPrjTabObjLstCache = CacheHelper.Get<List<clsvPrjTabEN>>(strKey);
}
return arrvPrjTabObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjTab.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.IsReleToSqlTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.TabMainTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.RelaTabId4View, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.IsNeedGeneIndexer, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.ParentClass, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.IsUseCache, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.IsShare, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.CacheClassifyField, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.CacheModeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.IsRefresh4RelaView, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.TabRecNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTab.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.OrderNum4Refer, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTab.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.FldNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTab.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.TabStateName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.TabMainTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.TabTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.RelaTabName4View, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.Owner, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.TabEnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.TabNameB, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.IsNationStandard, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.IsParaTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.IsArchive, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab.UpdDate2, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab.DataBaseNameTab, Type.GetType("System.String"));
foreach (clsvPrjTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjTab.TabId] = objInFor[convPrjTab.TabId];
objDR[convPrjTab.TabName] = objInFor[convPrjTab.TabName];
objDR[convPrjTab.TabCnName] = objInFor[convPrjTab.TabCnName];
objDR[convPrjTab.PrjId] = objInFor[convPrjTab.PrjId];
objDR[convPrjTab.SqlDsTypeId] = objInFor[convPrjTab.SqlDsTypeId];
objDR[convPrjTab.TabStateId] = objInFor[convPrjTab.TabStateId];
objDR[convPrjTab.FuncModuleAgcId] = objInFor[convPrjTab.FuncModuleAgcId];
objDR[convPrjTab.FuncModuleEnName] = objInFor[convPrjTab.FuncModuleEnName];
objDR[convPrjTab.IsReleToSqlTab] = objInFor[convPrjTab.IsReleToSqlTab];
objDR[convPrjTab.Keyword] = objInFor[convPrjTab.Keyword];
objDR[convPrjTab.TabTypeId] = objInFor[convPrjTab.TabTypeId];
objDR[convPrjTab.TabMainTypeId] = objInFor[convPrjTab.TabMainTypeId];
objDR[convPrjTab.RelaTabId4View] = objInFor[convPrjTab.RelaTabId4View];
objDR[convPrjTab.IsNeedGeneIndexer] = objInFor[convPrjTab.IsNeedGeneIndexer];
objDR[convPrjTab.ParentClass] = objInFor[convPrjTab.ParentClass];
objDR[convPrjTab.IsUseCache] = objInFor[convPrjTab.IsUseCache];
objDR[convPrjTab.IsShare] = objInFor[convPrjTab.IsShare];
objDR[convPrjTab.CacheClassifyField] = objInFor[convPrjTab.CacheClassifyField];
objDR[convPrjTab.CacheModeId] = objInFor[convPrjTab.CacheModeId];
objDR[convPrjTab.IsRefresh4RelaView] = objInFor[convPrjTab.IsRefresh4RelaView];
objDR[convPrjTab.TabRecNum] = objInFor[convPrjTab.TabRecNum];
objDR[convPrjTab.ErrMsg] = objInFor[convPrjTab.ErrMsg];
objDR[convPrjTab.UpdUserId] = objInFor[convPrjTab.UpdUserId];
objDR[convPrjTab.UpdDate] = objInFor[convPrjTab.UpdDate];
objDR[convPrjTab.Memo] = objInFor[convPrjTab.Memo];
objDR[convPrjTab.OrderNum4Refer] = objInFor[convPrjTab.OrderNum4Refer];
objDR[convPrjTab.FuncModuleName] = objInFor[convPrjTab.FuncModuleName];
objDR[convPrjTab.FldNum] = objInFor[convPrjTab.FldNum];
objDR[convPrjTab.SqlDsTypeName] = objInFor[convPrjTab.SqlDsTypeName];
objDR[convPrjTab.TabStateName] = objInFor[convPrjTab.TabStateName];
objDR[convPrjTab.TabMainTypeName] = objInFor[convPrjTab.TabMainTypeName];
objDR[convPrjTab.TabTypeName] = objInFor[convPrjTab.TabTypeName];
objDR[convPrjTab.RelaTabName4View] = objInFor[convPrjTab.RelaTabName4View];
objDR[convPrjTab.PrjName] = objInFor[convPrjTab.PrjName];
objDR[convPrjTab.IsChecked] = objInFor[convPrjTab.IsChecked];
objDR[convPrjTab.Owner] = objInFor[convPrjTab.Owner];
objDR[convPrjTab.TabEnName] = objInFor[convPrjTab.TabEnName];
objDR[convPrjTab.IsNeedTransCode] = objInFor[convPrjTab.IsNeedTransCode];
objDR[convPrjTab.TabNameB] = objInFor[convPrjTab.TabNameB];
objDR[convPrjTab.IsNationStandard] = objInFor[convPrjTab.IsNationStandard];
objDR[convPrjTab.IsParaTab] = objInFor[convPrjTab.IsParaTab];
objDR[convPrjTab.IsArchive] = objInFor[convPrjTab.IsArchive];
objDR[convPrjTab.UpdDate2] = objInFor[convPrjTab.UpdDate2];
objDR[convPrjTab.DataBaseNameTab] = objInFor[convPrjTab.DataBaseNameTab];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}