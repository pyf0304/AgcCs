
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabWApi
 表名:PrjTab(00050009)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:32:47
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
public static class  clsPrjTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabId(this clsPrjTabEN objPrjTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, conPrjTab.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conPrjTab.TabId);
objPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabName(this clsPrjTabEN objPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, conPrjTab.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, conPrjTab.TabName);
objPrjTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabName) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabName, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabName] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabCnName(this clsPrjTabEN objPrjTabEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, conPrjTab.TabCnName);
objPrjTabEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabCnName) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabCnName, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabCnName] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetPrjId(this clsPrjTabEN objPrjTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conPrjTab.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjTab.PrjId);
objPrjTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.PrjId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.PrjId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.PrjId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetSqlDsTypeId(this clsPrjTabEN objPrjTabEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, conPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, conPrjTab.SqlDsTypeId);
objPrjTabEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.SqlDsTypeId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.SqlDsTypeId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.SqlDsTypeId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabStateId(this clsPrjTabEN objPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, conPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(strTabStateId, 2, conPrjTab.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, conPrjTab.TabStateId);
objPrjTabEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabStateId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabStateId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabStateId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetFuncModuleAgcId(this clsPrjTabEN objPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conPrjTab.FuncModuleAgcId);
objPrjTabEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.FuncModuleAgcId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.FuncModuleAgcId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.FuncModuleAgcId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsReleToSqlTab">是否与SQL表相关</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsReleToSqlTab(this clsPrjTabEN objPrjTabEN, bool bolIsReleToSqlTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsReleToSqlTab, conPrjTab.IsReleToSqlTab);
objPrjTabEN.IsReleToSqlTab = bolIsReleToSqlTab; //是否与SQL表相关
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsReleToSqlTab) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsReleToSqlTab, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsReleToSqlTab] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetKeyword(this clsPrjTabEN objPrjTabEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 50, conPrjTab.Keyword);
objPrjTabEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.Keyword) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.Keyword, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.Keyword] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabTypeId(this clsPrjTabEN objPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, conPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(strTabTypeId, 4, conPrjTab.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, conPrjTab.TabTypeId);
objPrjTabEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabTypeId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabTypeId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabTypeId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeId">表主类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabMainTypeId(this clsPrjTabEN objPrjTabEN, string strTabMainTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabMainTypeId, conPrjTab.TabMainTypeId);
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, conPrjTab.TabMainTypeId);
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, conPrjTab.TabMainTypeId);
objPrjTabEN.TabMainTypeId = strTabMainTypeId; //表主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabMainTypeId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabMainTypeId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabMainTypeId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId4View">视图的相关表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetRelaTabId4View(this clsPrjTabEN objPrjTabEN, string strRelaTabId4View, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId4View, 8, conPrjTab.RelaTabId4View);
clsCheckSql.CheckFieldForeignKey(strRelaTabId4View, 8, conPrjTab.RelaTabId4View);
objPrjTabEN.RelaTabId4View = strRelaTabId4View; //视图的相关表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.RelaTabId4View) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.RelaTabId4View, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.RelaTabId4View] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGeneIndexer">是否需要生成索引器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsNeedGeneIndexer(this clsPrjTabEN objPrjTabEN, bool bolIsNeedGeneIndexer, string strComparisonOp="")
	{
objPrjTabEN.IsNeedGeneIndexer = bolIsNeedGeneIndexer; //是否需要生成索引器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsNeedGeneIndexer) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsNeedGeneIndexer, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsNeedGeneIndexer] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strParentClass">父类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetParentClass(this clsPrjTabEN objPrjTabEN, string strParentClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentClass, 50, conPrjTab.ParentClass);
objPrjTabEN.ParentClass = strParentClass; //父类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.ParentClass) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.ParentClass, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.ParentClass] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsShare">是否共享</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsShare(this clsPrjTabEN objPrjTabEN, bool bolIsShare, string strComparisonOp="")
	{
objPrjTabEN.IsShare = bolIsShare; //是否共享
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsShare) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsShare, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsShare] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUseDelSign">是否使用删除标记</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsUseDelSign(this clsPrjTabEN objPrjTabEN, bool bolIsUseDelSign, string strComparisonOp="")
	{
objPrjTabEN.IsUseDelSign = bolIsUseDelSign; //是否使用删除标记
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsUseDelSign) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsUseDelSign, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsUseDelSign] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUseCache">是否使用Cache</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsUseCache(this clsPrjTabEN objPrjTabEN, bool bolIsUseCache, string strComparisonOp="")
	{
objPrjTabEN.IsUseCache = bolIsUseCache; //是否使用Cache
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsUseCache) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsUseCache, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsUseCache] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsMultiKeyClassify">是否可以多个关键字分类共存</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsMultiKeyClassify(this clsPrjTabEN objPrjTabEN, bool bolIsMultiKeyClassify, string strComparisonOp="")
	{
objPrjTabEN.IsMultiKeyClassify = bolIsMultiKeyClassify; //是否可以多个关键字分类共存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsMultiKeyClassify) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsMultiKeyClassify, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsMultiKeyClassify] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheClassifyField">缓存分类字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheClassifyField(this clsPrjTabEN objPrjTabEN, string strCacheClassifyField, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheClassifyField, 8, conPrjTab.CacheClassifyField);
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField, 8, conPrjTab.CacheClassifyField);
objPrjTabEN.CacheClassifyField = strCacheClassifyField; //缓存分类字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheClassifyField) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheClassifyField, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheClassifyField] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheClassifyField2">缓存分类字段2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheClassifyField2(this clsPrjTabEN objPrjTabEN, string strCacheClassifyField2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheClassifyField2, 8, conPrjTab.CacheClassifyField2);
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField2, 8, conPrjTab.CacheClassifyField2);
objPrjTabEN.CacheClassifyField2 = strCacheClassifyField2; //缓存分类字段2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheClassifyField2) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheClassifyField2, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheClassifyField2] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheModeId">缓存方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheModeId(this clsPrjTabEN objPrjTabEN, string strCacheModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, conPrjTab.CacheModeId);
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, conPrjTab.CacheModeId);
objPrjTabEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheModeId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheModeId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheModeId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheClassifyFieldTS">缓存分类字段_TS</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheClassifyFieldTS(this clsPrjTabEN objPrjTabEN, string strCacheClassifyFieldTS, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheClassifyFieldTS, 8, conPrjTab.CacheClassifyFieldTS);
clsCheckSql.CheckFieldForeignKey(strCacheClassifyFieldTS, 8, conPrjTab.CacheClassifyFieldTS);
objPrjTabEN.CacheClassifyFieldTS = strCacheClassifyFieldTS; //缓存分类字段_TS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheClassifyFieldTS) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheClassifyFieldTS, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheClassifyFieldTS] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheClassifyField2TS">缓存分类字段2_TS</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheClassifyField2TS(this clsPrjTabEN objPrjTabEN, string strCacheClassifyField2TS, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheClassifyField2TS, 8, conPrjTab.CacheClassifyField2TS);
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField2TS, 8, conPrjTab.CacheClassifyField2TS);
objPrjTabEN.CacheClassifyField2TS = strCacheClassifyField2TS; //缓存分类字段2_TS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheClassifyField2TS) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheClassifyField2TS, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheClassifyField2TS] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaVar2TS">参数变量2_TS</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetParaVar2TS(this clsPrjTabEN objPrjTabEN, string strParaVar2TS, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParaVar2TS, 8, conPrjTab.ParaVar2TS);
clsCheckSql.CheckFieldForeignKey(strParaVar2TS, 8, conPrjTab.ParaVar2TS);
objPrjTabEN.ParaVar2TS = strParaVar2TS; //参数变量2_TS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.ParaVar2TS) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.ParaVar2TS, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.ParaVar2TS] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaVar1TS">参数变量_TS</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetParaVar1TS(this clsPrjTabEN objPrjTabEN, string strParaVar1TS, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParaVar1TS, 8, conPrjTab.ParaVar1TS);
clsCheckSql.CheckFieldForeignKey(strParaVar1TS, 8, conPrjTab.ParaVar1TS);
objPrjTabEN.ParaVar1TS = strParaVar1TS; //参数变量_TS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.ParaVar1TS) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.ParaVar1TS, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.ParaVar1TS] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strWhereFormat">缓存条件格式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetWhereFormat(this clsPrjTabEN objPrjTabEN, string strWhereFormat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWhereFormat, 500, conPrjTab.WhereFormat);
objPrjTabEN.WhereFormat = strWhereFormat; //缓存条件格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.WhereFormat) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.WhereFormat, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.WhereFormat] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strWhereFormatBack">后台缓存条件格式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetWhereFormatBack(this clsPrjTabEN objPrjTabEN, string strWhereFormatBack, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWhereFormatBack, 500, conPrjTab.WhereFormatBack);
objPrjTabEN.WhereFormatBack = strWhereFormatBack; //后台缓存条件格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.WhereFormatBack) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.WhereFormatBack, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.WhereFormatBack] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRefresh4RelaView">是否刷新相关视图</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsRefresh4RelaView(this clsPrjTabEN objPrjTabEN, bool bolIsRefresh4RelaView, string strComparisonOp="")
	{
objPrjTabEN.IsRefresh4RelaView = bolIsRefresh4RelaView; //是否刷新相关视图
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsRefresh4RelaView) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsRefresh4RelaView, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsRefresh4RelaView] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabRecNum">记录数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabRecNum(this clsPrjTabEN objPrjTabEN, int intTabRecNum, string strComparisonOp="")
	{
objPrjTabEN.TabRecNum = intTabRecNum; //记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabRecNum) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabRecNum, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabRecNum] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyId4Test">测试关键字Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetKeyId4Test(this clsPrjTabEN objPrjTabEN, string strKeyId4Test, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, conPrjTab.KeyId4Test);
objPrjTabEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.KeyId4Test) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.KeyId4Test, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.KeyId4Test] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetErrMsg(this clsPrjTabEN objPrjTabEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conPrjTab.ErrMsg);
objPrjTabEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.ErrMsg) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.ErrMsg, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.ErrMsg] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldNum">字段数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetFldNum(this clsPrjTabEN objPrjTabEN, int intFldNum, string strComparisonOp="")
	{
objPrjTabEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.FldNum) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.FldNum, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.FldNum] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetUpdUserId(this clsPrjTabEN objPrjTabEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conPrjTab.UpdUserId);
objPrjTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.UpdUserId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.UpdUserId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.UpdUserId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetUpdDate(this clsPrjTabEN objPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjTab.UpdDate);
objPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.UpdDate) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.UpdDate, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.UpdDate] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetMemo(this clsPrjTabEN objPrjTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjTab.Memo);
objPrjTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.Memo) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.Memo, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.Memo] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetOrderNum4Refer(this clsPrjTabEN objPrjTabEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objPrjTabEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.OrderNum4Refer) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.OrderNum4Refer, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.OrderNum4Refer] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsChecked">是否核实</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsChecked(this clsPrjTabEN objPrjTabEN, bool bolIsChecked, string strComparisonOp="")
	{
objPrjTabEN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsChecked) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsChecked, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsChecked] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOwner">拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetOwner(this clsPrjTabEN objPrjTabEN, string strOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwner, 50, conPrjTab.Owner);
objPrjTabEN.Owner = strOwner; //拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.Owner) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.Owner, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.Owner] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabEnName">表英文详细名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabEnName(this clsPrjTabEN objPrjTabEN, string strTabEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabEnName, 200, conPrjTab.TabEnName);
objPrjTabEN.TabEnName = strTabEnName; //表英文详细名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabEnName) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabEnName, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabEnName] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsNeedTransCode(this clsPrjTabEN objPrjTabEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, conPrjTab.IsNeedTransCode);
objPrjTabEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsNeedTransCode) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsNeedTransCode, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsNeedTransCode] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabNameB">表名_后备</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabNameB(this clsPrjTabEN objPrjTabEN, string strTabNameB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabNameB, 50, conPrjTab.TabNameB);
objPrjTabEN.TabNameB = strTabNameB; //表名_后备
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabNameB) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabNameB, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabNameB] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaViewId">RelaViewId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetRelaViewId(this clsPrjTabEN objPrjTabEN, string strRelaViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaViewId, 8, conPrjTab.RelaViewId);
clsCheckSql.CheckFieldForeignKey(strRelaViewId, 8, conPrjTab.RelaViewId);
objPrjTabEN.RelaViewId = strRelaViewId; //RelaViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.RelaViewId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.RelaViewId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.RelaViewId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetDataBaseName(this clsPrjTabEN objPrjTabEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, conPrjTab.DataBaseName);
objPrjTabEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.DataBaseName) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.DataBaseName, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.DataBaseName] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNationStandard">是否国标</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsNationStandard(this clsPrjTabEN objPrjTabEN, bool bolIsNationStandard, string strComparisonOp="")
	{
objPrjTabEN.IsNationStandard = bolIsNationStandard; //是否国标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsNationStandard) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsNationStandard, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsNationStandard] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsParaTab">是否参数表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsParaTab(this clsPrjTabEN objPrjTabEN, bool bolIsParaTab, string strComparisonOp="")
	{
objPrjTabEN.IsParaTab = bolIsParaTab; //是否参数表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsParaTab) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsParaTab, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsParaTab] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsArchive">是否存档</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsArchive(this clsPrjTabEN objPrjTabEN, bool bolIsArchive, string strComparisonOp="")
	{
objPrjTabEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsArchive) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsArchive, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsArchive] = strComparisonOp;
}
}
return objPrjTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjTabEN objPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjTabCond.IsUpdated(conPrjTab.TabId) == true)
{
string strComparisonOpTabId = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabId, objPrjTabCond.TabId, strComparisonOpTabId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabName) == true)
{
string strComparisonOpTabName = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabName, objPrjTabCond.TabName, strComparisonOpTabName);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabCnName) == true)
{
string strComparisonOpTabCnName = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabCnName, objPrjTabCond.TabCnName, strComparisonOpTabCnName);
}
if (objPrjTabCond.IsUpdated(conPrjTab.PrjId) == true)
{
string strComparisonOpPrjId = objPrjTabCond.dicFldComparisonOp[conPrjTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.PrjId, objPrjTabCond.PrjId, strComparisonOpPrjId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objPrjTabCond.dicFldComparisonOp[conPrjTab.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.SqlDsTypeId, objPrjTabCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabStateId) == true)
{
string strComparisonOpTabStateId = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabStateId, objPrjTabCond.TabStateId, strComparisonOpTabStateId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objPrjTabCond.dicFldComparisonOp[conPrjTab.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.FuncModuleAgcId, objPrjTabCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsReleToSqlTab) == true)
{
if (objPrjTabCond.IsReleToSqlTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsReleToSqlTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsReleToSqlTab);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.Keyword) == true)
{
string strComparisonOpKeyword = objPrjTabCond.dicFldComparisonOp[conPrjTab.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.Keyword, objPrjTabCond.Keyword, strComparisonOpKeyword);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabTypeId, objPrjTabCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabMainTypeId) == true)
{
string strComparisonOpTabMainTypeId = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabMainTypeId, objPrjTabCond.TabMainTypeId, strComparisonOpTabMainTypeId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.RelaTabId4View) == true)
{
string strComparisonOpRelaTabId4View = objPrjTabCond.dicFldComparisonOp[conPrjTab.RelaTabId4View];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.RelaTabId4View, objPrjTabCond.RelaTabId4View, strComparisonOpRelaTabId4View);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsNeedGeneIndexer) == true)
{
if (objPrjTabCond.IsNeedGeneIndexer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsNeedGeneIndexer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsNeedGeneIndexer);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.ParentClass) == true)
{
string strComparisonOpParentClass = objPrjTabCond.dicFldComparisonOp[conPrjTab.ParentClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.ParentClass, objPrjTabCond.ParentClass, strComparisonOpParentClass);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsShare) == true)
{
if (objPrjTabCond.IsShare == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsShare);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsShare);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsUseDelSign) == true)
{
if (objPrjTabCond.IsUseDelSign == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsUseDelSign);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsUseDelSign);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsUseCache) == true)
{
if (objPrjTabCond.IsUseCache == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsUseCache);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsUseCache);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsMultiKeyClassify) == true)
{
if (objPrjTabCond.IsMultiKeyClassify == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsMultiKeyClassify);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsMultiKeyClassify);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheClassifyField) == true)
{
string strComparisonOpCacheClassifyField = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheClassifyField];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheClassifyField, objPrjTabCond.CacheClassifyField, strComparisonOpCacheClassifyField);
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheClassifyField2) == true)
{
string strComparisonOpCacheClassifyField2 = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheClassifyField2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheClassifyField2, objPrjTabCond.CacheClassifyField2, strComparisonOpCacheClassifyField2);
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheModeId, objPrjTabCond.CacheModeId, strComparisonOpCacheModeId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheClassifyFieldTS) == true)
{
string strComparisonOpCacheClassifyFieldTS = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheClassifyFieldTS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheClassifyFieldTS, objPrjTabCond.CacheClassifyFieldTS, strComparisonOpCacheClassifyFieldTS);
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheClassifyField2TS) == true)
{
string strComparisonOpCacheClassifyField2TS = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheClassifyField2TS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheClassifyField2TS, objPrjTabCond.CacheClassifyField2TS, strComparisonOpCacheClassifyField2TS);
}
if (objPrjTabCond.IsUpdated(conPrjTab.ParaVar2TS) == true)
{
string strComparisonOpParaVar2TS = objPrjTabCond.dicFldComparisonOp[conPrjTab.ParaVar2TS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.ParaVar2TS, objPrjTabCond.ParaVar2TS, strComparisonOpParaVar2TS);
}
if (objPrjTabCond.IsUpdated(conPrjTab.ParaVar1TS) == true)
{
string strComparisonOpParaVar1TS = objPrjTabCond.dicFldComparisonOp[conPrjTab.ParaVar1TS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.ParaVar1TS, objPrjTabCond.ParaVar1TS, strComparisonOpParaVar1TS);
}
if (objPrjTabCond.IsUpdated(conPrjTab.WhereFormat) == true)
{
string strComparisonOpWhereFormat = objPrjTabCond.dicFldComparisonOp[conPrjTab.WhereFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.WhereFormat, objPrjTabCond.WhereFormat, strComparisonOpWhereFormat);
}
if (objPrjTabCond.IsUpdated(conPrjTab.WhereFormatBack) == true)
{
string strComparisonOpWhereFormatBack = objPrjTabCond.dicFldComparisonOp[conPrjTab.WhereFormatBack];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.WhereFormatBack, objPrjTabCond.WhereFormatBack, strComparisonOpWhereFormatBack);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsRefresh4RelaView) == true)
{
if (objPrjTabCond.IsRefresh4RelaView == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsRefresh4RelaView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsRefresh4RelaView);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabRecNum) == true)
{
string strComparisonOpTabRecNum = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTab.TabRecNum, objPrjTabCond.TabRecNum, strComparisonOpTabRecNum);
}
if (objPrjTabCond.IsUpdated(conPrjTab.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objPrjTabCond.dicFldComparisonOp[conPrjTab.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.KeyId4Test, objPrjTabCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objPrjTabCond.IsUpdated(conPrjTab.ErrMsg) == true)
{
string strComparisonOpErrMsg = objPrjTabCond.dicFldComparisonOp[conPrjTab.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.ErrMsg, objPrjTabCond.ErrMsg, strComparisonOpErrMsg);
}
if (objPrjTabCond.IsUpdated(conPrjTab.FldNum) == true)
{
string strComparisonOpFldNum = objPrjTabCond.dicFldComparisonOp[conPrjTab.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTab.FldNum, objPrjTabCond.FldNum, strComparisonOpFldNum);
}
if (objPrjTabCond.IsUpdated(conPrjTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objPrjTabCond.dicFldComparisonOp[conPrjTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.UpdUserId, objPrjTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjTabCond.dicFldComparisonOp[conPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.UpdDate, objPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjTabCond.IsUpdated(conPrjTab.Memo) == true)
{
string strComparisonOpMemo = objPrjTabCond.dicFldComparisonOp[conPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.Memo, objPrjTabCond.Memo, strComparisonOpMemo);
}
if (objPrjTabCond.IsUpdated(conPrjTab.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objPrjTabCond.dicFldComparisonOp[conPrjTab.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTab.OrderNum4Refer, objPrjTabCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsChecked) == true)
{
if (objPrjTabCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsChecked);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.Owner) == true)
{
string strComparisonOpOwner = objPrjTabCond.dicFldComparisonOp[conPrjTab.Owner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.Owner, objPrjTabCond.Owner, strComparisonOpOwner);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabEnName) == true)
{
string strComparisonOpTabEnName = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabEnName, objPrjTabCond.TabEnName, strComparisonOpTabEnName);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsNeedTransCode) == true)
{
if (objPrjTabCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsNeedTransCode);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabNameB) == true)
{
string strComparisonOpTabNameB = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabNameB];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabNameB, objPrjTabCond.TabNameB, strComparisonOpTabNameB);
}
if (objPrjTabCond.IsUpdated(conPrjTab.RelaViewId) == true)
{
string strComparisonOpRelaViewId = objPrjTabCond.dicFldComparisonOp[conPrjTab.RelaViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.RelaViewId, objPrjTabCond.RelaViewId, strComparisonOpRelaViewId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objPrjTabCond.dicFldComparisonOp[conPrjTab.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.DataBaseName, objPrjTabCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsNationStandard) == true)
{
if (objPrjTabCond.IsNationStandard == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsNationStandard);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsNationStandard);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsParaTab) == true)
{
if (objPrjTabCond.IsParaTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsParaTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsParaTab);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsArchive) == true)
{
if (objPrjTabCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsArchive);
}
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTabEN objPrjTabEN)
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPrjTabEN.sfUpdFldSetStr = objPrjTabEN.getsfUpdFldSetStr();
clsPrjTabWApi.CheckPropertyNew(objPrjTabEN); 
bool bolResult = clsPrjTabWApi.UpdateRecord(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
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
 /// 获取唯一性条件串--PrjTab(工程表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_TabName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsPrjTabEN objPrjTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjTabEN == null) return "";
if (objPrjTabEN.TabId == null || objPrjTabEN.TabId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objPrjTabEN.TabName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjTabEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TabId !=  '{0}'", objPrjTabEN.TabId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objPrjTabEN.TabName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjTabEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjTabEN objPrjTabEN)
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjTabWApi.IsExist(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsPrjTabWApi.CheckPropertyNew(objPrjTabEN); 
bool bolResult = clsPrjTabWApi.AddNewRecord(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjTabEN objPrjTabEN)
{
try
{
clsPrjTabWApi.CheckPropertyNew(objPrjTabEN); 
string strTabId = clsPrjTabWApi.AddNewRecordWithMaxId(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
return strTabId;
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
 /// <param name = "objPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTabEN objPrjTabEN, string strWhereCond)
{
try
{
clsPrjTabWApi.CheckPropertyNew(objPrjTabEN); 
bool bolResult = clsPrjTabWApi.UpdateWithCondition(objPrjTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
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
 /// 工程表(PrjTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPrjTabWApi
{
private static readonly string mstrApiControllerName = "PrjTabApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsPrjTabWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表]...","0");
List<clsPrjTabEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TabId";
objDDL.DataTextField="TabName";
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
public static void BindCbo_TabId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjTab.TabId); 
List<clsPrjTabEN> arrObjLst = clsPrjTabWApi.GetObjLst(strCondition).OrderBy(x=>x.TabName).ToList();
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjTabEN objPrjTabEN = new clsPrjTabEN()
{
TabId = "0",
TabName = "选[工程表]..."
};
arrObjLstSel.Insert(0, objPrjTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjTab.TabId;
objComboBox.DisplayMember = conPrjTab.TabName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPrjTabEN objPrjTabEN)
{
if (!Object.Equals(null, objPrjTabEN.TabId) && GetStrLen(objPrjTabEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.TabName) && GetStrLen(objPrjTabEN.TabName) > 100)
{
 throw new Exception("字段[表名]的长度不能超过100!");
}
if (!Object.Equals(null, objPrjTabEN.TabCnName) && GetStrLen(objPrjTabEN.TabCnName) > 200)
{
 throw new Exception("字段[表中文名]的长度不能超过200!");
}
if (!Object.Equals(null, objPrjTabEN.PrjId) && GetStrLen(objPrjTabEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjTabEN.SqlDsTypeId) && GetStrLen(objPrjTabEN.SqlDsTypeId) > 2)
{
 throw new Exception("字段[数据源类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjTabEN.TabStateId) && GetStrLen(objPrjTabEN.TabStateId) > 2)
{
 throw new Exception("字段[表状态ID]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjTabEN.FuncModuleAgcId) && GetStrLen(objPrjTabEN.FuncModuleAgcId) > 8)
{
 throw new Exception("字段[功能模块Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.Keyword) && GetStrLen(objPrjTabEN.Keyword) > 50)
{
 throw new Exception("字段[关键字]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjTabEN.TabTypeId) && GetStrLen(objPrjTabEN.TabTypeId) > 4)
{
 throw new Exception("字段[表类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjTabEN.TabMainTypeId) && GetStrLen(objPrjTabEN.TabMainTypeId) > 4)
{
 throw new Exception("字段[表主类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjTabEN.RelaTabId4View) && GetStrLen(objPrjTabEN.RelaTabId4View) > 8)
{
 throw new Exception("字段[视图的相关表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.ParentClass) && GetStrLen(objPrjTabEN.ParentClass) > 50)
{
 throw new Exception("字段[父类]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjTabEN.CacheClassifyField) && GetStrLen(objPrjTabEN.CacheClassifyField) > 8)
{
 throw new Exception("字段[缓存分类字段]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.CacheClassifyField2) && GetStrLen(objPrjTabEN.CacheClassifyField2) > 8)
{
 throw new Exception("字段[缓存分类字段2]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.CacheModeId) && GetStrLen(objPrjTabEN.CacheModeId) > 2)
{
 throw new Exception("字段[缓存方式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjTabEN.CacheClassifyFieldTS) && GetStrLen(objPrjTabEN.CacheClassifyFieldTS) > 8)
{
 throw new Exception("字段[缓存分类字段_TS]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.CacheClassifyField2TS) && GetStrLen(objPrjTabEN.CacheClassifyField2TS) > 8)
{
 throw new Exception("字段[缓存分类字段2_TS]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.ParaVar2TS) && GetStrLen(objPrjTabEN.ParaVar2TS) > 8)
{
 throw new Exception("字段[参数变量2_TS]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.ParaVar1TS) && GetStrLen(objPrjTabEN.ParaVar1TS) > 8)
{
 throw new Exception("字段[参数变量_TS]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.WhereFormat) && GetStrLen(objPrjTabEN.WhereFormat) > 500)
{
 throw new Exception("字段[缓存条件格式]的长度不能超过500!");
}
if (!Object.Equals(null, objPrjTabEN.WhereFormatBack) && GetStrLen(objPrjTabEN.WhereFormatBack) > 500)
{
 throw new Exception("字段[后台缓存条件格式]的长度不能超过500!");
}
if (!Object.Equals(null, objPrjTabEN.KeyId4Test) && GetStrLen(objPrjTabEN.KeyId4Test) > 50)
{
 throw new Exception("字段[测试关键字Id]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjTabEN.ErrMsg) && GetStrLen(objPrjTabEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objPrjTabEN.UpdUserId) && GetStrLen(objPrjTabEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjTabEN.UpdDate) && GetStrLen(objPrjTabEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjTabEN.Memo) && GetStrLen(objPrjTabEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objPrjTabEN.Owner) && GetStrLen(objPrjTabEN.Owner) > 50)
{
 throw new Exception("字段[拥有者]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjTabEN.TabEnName) && GetStrLen(objPrjTabEN.TabEnName) > 200)
{
 throw new Exception("字段[表英文详细名]的长度不能超过200!");
}
if (!Object.Equals(null, objPrjTabEN.TabNameB) && GetStrLen(objPrjTabEN.TabNameB) > 50)
{
 throw new Exception("字段[表名_后备]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjTabEN.RelaViewId) && GetStrLen(objPrjTabEN.RelaViewId) > 8)
{
 throw new Exception("字段[RelaViewId]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabEN.DataBaseName) && GetStrLen(objPrjTabEN.DataBaseName) > 50)
{
 throw new Exception("字段[数据库名]的长度不能超过50!");
}
 objPrjTabEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTabEN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsPrjTabEN objPrjTabEN;
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
objPrjTabEN = JsonConvert.DeserializeObject<clsPrjTabEN>(strJson);
return objPrjTabEN;
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
public static clsPrjTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsPrjTabEN objPrjTabEN;
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
objPrjTabEN = JsonConvert.DeserializeObject<clsPrjTabEN>(strJson);
return objPrjTabEN;
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
public static clsPrjTabEN GetObjByTabIdCache(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache();
IEnumerable <clsPrjTabEN> arrPrjTabObjLst_Sel =
from objPrjTabEN in arrPrjTabObjLstCache
where objPrjTabEN.TabId == strTabId 
select objPrjTabEN;
if (arrPrjTabObjLst_Sel.Count() == 0)
{
   clsPrjTabEN obj = clsPrjTabWApi.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabNameByTabIdCache(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//初始化列表缓存
List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache();
IEnumerable <clsPrjTabEN> arrPrjTabObjLst_Sel1 =
from objPrjTabEN in arrPrjTabObjLstCache
where objPrjTabEN.TabId == strTabId 
select objPrjTabEN;
List <clsPrjTabEN> arrPrjTabObjLst_Sel = new List<clsPrjTabEN>();
foreach (clsPrjTabEN obj in arrPrjTabObjLst_Sel1)
{
arrPrjTabObjLst_Sel.Add(obj);
}
if (arrPrjTabObjLst_Sel.Count > 0)
{
return arrPrjTabObjLst_Sel[0].TabName;
}
string strErrMsgForGetObjById = string.Format("在PrjTab对象缓存列表中,找不到记录[TabId = {0}](函数:{1})", strTabId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabIdCache(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//初始化列表缓存
List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache();
IEnumerable <clsPrjTabEN> arrPrjTabObjLst_Sel1 =
from objPrjTabEN in arrPrjTabObjLstCache
where objPrjTabEN.TabId == strTabId 
select objPrjTabEN;
List <clsPrjTabEN> arrPrjTabObjLst_Sel = new List<clsPrjTabEN>();
foreach (clsPrjTabEN obj in arrPrjTabObjLst_Sel1)
{
arrPrjTabObjLst_Sel.Add(obj);
}
if (arrPrjTabObjLst_Sel.Count > 0)
{
return arrPrjTabObjLst_Sel[0].TabName;
}
string strErrMsgForGetObjById = string.Format("在PrjTab对象缓存列表中,找不到记录的相关名称[TabId = {0}](函数:{1})", strTabId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabEN> GetObjLst(string strWhereCond)
{
 List<clsPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabEN>>(strJson);
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
public static List<clsPrjTabEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabEN>>(strJson);
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
public static IEnumerable<clsPrjTabEN> GetObjLstByTabIdLstCache(List<string> arrTabId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache();
IEnumerable <clsPrjTabEN> arrPrjTabObjLst_Sel =
from objPrjTabEN in arrPrjTabObjLstCache
where arrTabId.Contains(objPrjTabEN.TabId)
select objPrjTabEN;
return arrPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabEN>>(strJson);
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
public static List<clsPrjTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabEN>>(strJson);
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
public static List<clsPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabEN>>(strJson);
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
public static List<clsPrjTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabEN>>(strJson);
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
public static int DelRecord(string strTabId)
{
string strAction = "DelRecord";
try
{
 clsPrjTabEN objPrjTabEN = clsPrjTabWApi.GetObjByTabId(strTabId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strTabId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
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
public static int DelPrjTabs(List<string> arrTabId)
{
string strAction = "DelPrjTabs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTabId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsPrjTabEN objPrjTabEN = clsPrjTabWApi.GetObjByTabId(arrTabId[0]);
clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
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
public static int DelPrjTabsByCond(string strWhereCond)
{
string strAction = "DelPrjTabsByCond";
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
public static bool AddNewRecord(clsPrjTabEN objPrjTabEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabEN>(objPrjTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
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
public static string AddNewRecordWithMaxId(clsPrjTabEN objPrjTabEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabEN>(objPrjTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabWApi.ReFreshCache(objPrjTabEN.PrjId);
var strTabId = (string)jobjReturn0["returnStr"];
return strTabId;
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
public static bool UpdateRecord(clsPrjTabEN objPrjTabEN)
{
if (string.IsNullOrEmpty(objPrjTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjTabEN.TabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabEN>(objPrjTabEN);
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
 /// <param name = "objPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPrjTabEN objPrjTabEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPrjTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjTabEN.TabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjTabEN.TabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabEN>(objPrjTabEN);
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
 /// <param name = "objPrjTabENS">源对象</param>
 /// <param name = "objPrjTabENT">目标对象</param>
 public static void CopyTo(clsPrjTabEN objPrjTabENS, clsPrjTabEN objPrjTabENT)
{
try
{
objPrjTabENT.TabId = objPrjTabENS.TabId; //表ID
objPrjTabENT.TabName = objPrjTabENS.TabName; //表名
objPrjTabENT.TabCnName = objPrjTabENS.TabCnName; //表中文名
objPrjTabENT.PrjId = objPrjTabENS.PrjId; //工程Id
objPrjTabENT.SqlDsTypeId = objPrjTabENS.SqlDsTypeId; //数据源类型Id
objPrjTabENT.TabStateId = objPrjTabENS.TabStateId; //表状态ID
objPrjTabENT.FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId; //功能模块Id
objPrjTabENT.IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objPrjTabENT.Keyword = objPrjTabENS.Keyword; //关键字
objPrjTabENT.TabTypeId = objPrjTabENS.TabTypeId; //表类型Id
objPrjTabENT.TabMainTypeId = objPrjTabENS.TabMainTypeId; //表主类型Id
objPrjTabENT.RelaTabId4View = objPrjTabENS.RelaTabId4View; //视图的相关表ID
objPrjTabENT.IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objPrjTabENT.ParentClass = objPrjTabENS.ParentClass; //父类
objPrjTabENT.IsShare = objPrjTabENS.IsShare; //是否共享
objPrjTabENT.IsUseDelSign = objPrjTabENS.IsUseDelSign; //是否使用删除标记
objPrjTabENT.IsUseCache = objPrjTabENS.IsUseCache; //是否使用Cache
objPrjTabENT.IsMultiKeyClassify = objPrjTabENS.IsMultiKeyClassify; //是否可以多个关键字分类共存
objPrjTabENT.CacheClassifyField = objPrjTabENS.CacheClassifyField; //缓存分类字段
objPrjTabENT.CacheClassifyField2 = objPrjTabENS.CacheClassifyField2; //缓存分类字段2
objPrjTabENT.CacheModeId = objPrjTabENS.CacheModeId; //缓存方式Id
objPrjTabENT.CacheClassifyFieldTS = objPrjTabENS.CacheClassifyFieldTS; //缓存分类字段_TS
objPrjTabENT.CacheClassifyField2TS = objPrjTabENS.CacheClassifyField2TS; //缓存分类字段2_TS
objPrjTabENT.ParaVar2TS = objPrjTabENS.ParaVar2TS; //参数变量2_TS
objPrjTabENT.ParaVar1TS = objPrjTabENS.ParaVar1TS; //参数变量_TS
objPrjTabENT.WhereFormat = objPrjTabENS.WhereFormat; //缓存条件格式
objPrjTabENT.WhereFormatBack = objPrjTabENS.WhereFormatBack; //后台缓存条件格式
objPrjTabENT.IsRefresh4RelaView = objPrjTabENS.IsRefresh4RelaView; //是否刷新相关视图
objPrjTabENT.TabRecNum = objPrjTabENS.TabRecNum; //记录数
objPrjTabENT.KeyId4Test = objPrjTabENS.KeyId4Test; //测试关键字Id
objPrjTabENT.ErrMsg = objPrjTabENS.ErrMsg; //错误信息
objPrjTabENT.FldNum = objPrjTabENS.FldNum; //字段数
objPrjTabENT.UpdUserId = objPrjTabENS.UpdUserId; //修改用户Id
objPrjTabENT.UpdDate = objPrjTabENS.UpdDate; //修改日期
objPrjTabENT.Memo = objPrjTabENS.Memo; //说明
objPrjTabENT.OrderNum4Refer = objPrjTabENS.OrderNum4Refer; //引用序号
objPrjTabENT.IsChecked = objPrjTabENS.IsChecked; //是否核实
objPrjTabENT.Owner = objPrjTabENS.Owner; //拥有者
objPrjTabENT.TabEnName = objPrjTabENS.TabEnName; //表英文详细名
objPrjTabENT.IsNeedTransCode = objPrjTabENS.IsNeedTransCode; //是否需要转换代码
objPrjTabENT.TabNameB = objPrjTabENS.TabNameB; //表名_后备
objPrjTabENT.RelaViewId = objPrjTabENS.RelaViewId; //RelaViewId
objPrjTabENT.DataBaseName = objPrjTabENS.DataBaseName; //数据库名
objPrjTabENT.IsNationStandard = objPrjTabENS.IsNationStandard; //是否国标
objPrjTabENT.IsParaTab = objPrjTabENS.IsParaTab; //是否参数表
objPrjTabENT.IsArchive = objPrjTabENS.IsArchive; //是否存档
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
public static DataTable ToDataTable(List<clsPrjTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPrjTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPrjTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPrjTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPrjTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPrjTabEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjTabWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjTabWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsPrjTabWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTabWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjTabWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjTabWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsPrjTabEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsPrjTabEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conPrjTab.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
List<clsPrjTabEN> arrPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabEN> GetObjLstCacheFromObjLst(List<clsPrjTabEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjTabWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjTabWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
List<clsPrjTabEN> arrPrjTabObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrPrjTabObjLstCache = CacheHelper.Get<List<clsPrjTabEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrPrjTabObjLstCache = CacheHelper.Get<List<clsPrjTabEN>>(strKey);
}
return arrPrjTabObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPrjTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPrjTab.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.TabName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.IsReleToSqlTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.TabMainTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.RelaTabId4View, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.IsNeedGeneIndexer, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.ParentClass, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.IsShare, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.IsUseDelSign, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.IsUseCache, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.IsMultiKeyClassify, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.CacheClassifyField, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.CacheClassifyField2, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.CacheModeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.CacheClassifyFieldTS, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.CacheClassifyField2TS, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.ParaVar2TS, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.ParaVar1TS, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.WhereFormat, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.WhereFormatBack, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.IsRefresh4RelaView, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.TabRecNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conPrjTab.KeyId4Test, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.FldNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conPrjTab.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.OrderNum4Refer, Type.GetType("System.Int32"));
objDT.Columns.Add(conPrjTab.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.Owner, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.TabEnName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.TabNameB, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.RelaViewId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTab.IsNationStandard, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.IsParaTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTab.IsArchive, Type.GetType("System.Boolean"));
foreach (clsPrjTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPrjTab.TabId] = objInFor[conPrjTab.TabId];
objDR[conPrjTab.TabName] = objInFor[conPrjTab.TabName];
objDR[conPrjTab.TabCnName] = objInFor[conPrjTab.TabCnName];
objDR[conPrjTab.PrjId] = objInFor[conPrjTab.PrjId];
objDR[conPrjTab.SqlDsTypeId] = objInFor[conPrjTab.SqlDsTypeId];
objDR[conPrjTab.TabStateId] = objInFor[conPrjTab.TabStateId];
objDR[conPrjTab.FuncModuleAgcId] = objInFor[conPrjTab.FuncModuleAgcId];
objDR[conPrjTab.IsReleToSqlTab] = objInFor[conPrjTab.IsReleToSqlTab];
objDR[conPrjTab.Keyword] = objInFor[conPrjTab.Keyword];
objDR[conPrjTab.TabTypeId] = objInFor[conPrjTab.TabTypeId];
objDR[conPrjTab.TabMainTypeId] = objInFor[conPrjTab.TabMainTypeId];
objDR[conPrjTab.RelaTabId4View] = objInFor[conPrjTab.RelaTabId4View];
objDR[conPrjTab.IsNeedGeneIndexer] = objInFor[conPrjTab.IsNeedGeneIndexer];
objDR[conPrjTab.ParentClass] = objInFor[conPrjTab.ParentClass];
objDR[conPrjTab.IsShare] = objInFor[conPrjTab.IsShare];
objDR[conPrjTab.IsUseDelSign] = objInFor[conPrjTab.IsUseDelSign];
objDR[conPrjTab.IsUseCache] = objInFor[conPrjTab.IsUseCache];
objDR[conPrjTab.IsMultiKeyClassify] = objInFor[conPrjTab.IsMultiKeyClassify];
objDR[conPrjTab.CacheClassifyField] = objInFor[conPrjTab.CacheClassifyField];
objDR[conPrjTab.CacheClassifyField2] = objInFor[conPrjTab.CacheClassifyField2];
objDR[conPrjTab.CacheModeId] = objInFor[conPrjTab.CacheModeId];
objDR[conPrjTab.CacheClassifyFieldTS] = objInFor[conPrjTab.CacheClassifyFieldTS];
objDR[conPrjTab.CacheClassifyField2TS] = objInFor[conPrjTab.CacheClassifyField2TS];
objDR[conPrjTab.ParaVar2TS] = objInFor[conPrjTab.ParaVar2TS];
objDR[conPrjTab.ParaVar1TS] = objInFor[conPrjTab.ParaVar1TS];
objDR[conPrjTab.WhereFormat] = objInFor[conPrjTab.WhereFormat];
objDR[conPrjTab.WhereFormatBack] = objInFor[conPrjTab.WhereFormatBack];
objDR[conPrjTab.IsRefresh4RelaView] = objInFor[conPrjTab.IsRefresh4RelaView];
objDR[conPrjTab.TabRecNum] = objInFor[conPrjTab.TabRecNum];
objDR[conPrjTab.KeyId4Test] = objInFor[conPrjTab.KeyId4Test];
objDR[conPrjTab.ErrMsg] = objInFor[conPrjTab.ErrMsg];
objDR[conPrjTab.FldNum] = objInFor[conPrjTab.FldNum];
objDR[conPrjTab.UpdUserId] = objInFor[conPrjTab.UpdUserId];
objDR[conPrjTab.UpdDate] = objInFor[conPrjTab.UpdDate];
objDR[conPrjTab.Memo] = objInFor[conPrjTab.Memo];
objDR[conPrjTab.OrderNum4Refer] = objInFor[conPrjTab.OrderNum4Refer];
objDR[conPrjTab.IsChecked] = objInFor[conPrjTab.IsChecked];
objDR[conPrjTab.Owner] = objInFor[conPrjTab.Owner];
objDR[conPrjTab.TabEnName] = objInFor[conPrjTab.TabEnName];
objDR[conPrjTab.IsNeedTransCode] = objInFor[conPrjTab.IsNeedTransCode];
objDR[conPrjTab.TabNameB] = objInFor[conPrjTab.TabNameB];
objDR[conPrjTab.RelaViewId] = objInFor[conPrjTab.RelaViewId];
objDR[conPrjTab.DataBaseName] = objInFor[conPrjTab.DataBaseName];
objDR[conPrjTab.IsNationStandard] = objInFor[conPrjTab.IsNationStandard];
objDR[conPrjTab.IsParaTab] = objInFor[conPrjTab.IsParaTab];
objDR[conPrjTab.IsArchive] = objInFor[conPrjTab.IsArchive];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工程表(PrjTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4PrjTab : clsCommFun4BL
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
clsPrjTabWApi.ReFreshThisCache();
}
}

}