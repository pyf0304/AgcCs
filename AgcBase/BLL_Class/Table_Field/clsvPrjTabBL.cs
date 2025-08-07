
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabBL
 表名:vPrjTab(00050124)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:49:18
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
public static class  clsvPrjTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabEN GetObj(this K_TabId_vPrjTab myKey)
{
clsvPrjTabEN objvPrjTabEN = clsvPrjTabBL.vPrjTabDA.GetObjByTabId(myKey.Value);
return objvPrjTabEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabId(this clsvPrjTabEN objvPrjTabEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabName(this clsvPrjTabEN objvPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabCnName(this clsvPrjTabEN objvPrjTabEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCnName, convPrjTab.TabCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjTab.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetPrjId(this clsvPrjTabEN objvPrjTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTab.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetSqlDsTypeId(this clsvPrjTabEN objvPrjTabEN, string strSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab.SqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabStateId(this clsvPrjTabEN objvPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab.TabStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab.TabStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetFuncModuleAgcId(this clsvPrjTabEN objvPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetFuncModuleEnName(this clsvPrjTabEN objvPrjTabEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convPrjTab.FuncModuleEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetKeyword(this clsvPrjTabEN objvPrjTabEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, convPrjTab.Keyword);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabTypeId(this clsvPrjTabEN objvPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab.TabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab.TabTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabMainTypeId(this clsvPrjTabEN objvPrjTabEN, string strTabMainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, convPrjTab.TabMainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, convPrjTab.TabMainTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetRelaTabId4View(this clsvPrjTabEN objvPrjTabEN, string strRelaTabId4View, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId4View, 8, convPrjTab.RelaTabId4View);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId4View, 8, convPrjTab.RelaTabId4View);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetParentClass(this clsvPrjTabEN objvPrjTabEN, string strParentClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentClass, 50, convPrjTab.ParentClass);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetCacheClassifyField(this clsvPrjTabEN objvPrjTabEN, string strCacheClassifyField, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheClassifyField, 8, convPrjTab.CacheClassifyField);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField, 8, convPrjTab.CacheClassifyField);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetCacheModeId(this clsvPrjTabEN objvPrjTabEN, string strCacheModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, convPrjTab.CacheModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, convPrjTab.CacheModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabRecNum(this clsvPrjTabEN objvPrjTabEN, int? intTabRecNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetErrMsg(this clsvPrjTabEN objvPrjTabEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrMsg, convPrjTab.ErrMsg);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convPrjTab.ErrMsg);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetUpdUserId(this clsvPrjTabEN objvPrjTabEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convPrjTab.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetUpdDate(this clsvPrjTabEN objvPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjTab.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetMemo(this clsvPrjTabEN objvPrjTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjTab.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetOrderNum4Refer(this clsvPrjTabEN objvPrjTabEN, int? intOrderNum4Refer, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetFuncModuleName(this clsvPrjTabEN objvPrjTabEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convPrjTab.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetFldNum(this clsvPrjTabEN objvPrjTabEN, int? intFldNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetSqlDsTypeName(this clsvPrjTabEN objvPrjTabEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convPrjTab.SqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabStateName(this clsvPrjTabEN objvPrjTabEN, string strTabStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateName, 30, convPrjTab.TabStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabMainTypeName(this clsvPrjTabEN objvPrjTabEN, string strTabMainTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeName, 30, convPrjTab.TabMainTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabTypeName(this clsvPrjTabEN objvPrjTabEN, string strTabTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convPrjTab.TabTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetRelaTabName4View(this clsvPrjTabEN objvPrjTabEN, string strRelaTabName4View, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabName4View, 100, convPrjTab.RelaTabName4View);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetPrjName(this clsvPrjTabEN objvPrjTabEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjTab.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetOwner(this clsvPrjTabEN objvPrjTabEN, string strOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwner, 50, convPrjTab.Owner);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabEnName(this clsvPrjTabEN objvPrjTabEN, string strTabEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabEnName, 200, convPrjTab.TabEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetTabNameB(this clsvPrjTabEN objvPrjTabEN, string strTabNameB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabNameB, convPrjTab.TabNameB);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabNameB, 50, convPrjTab.TabNameB);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetUpdDate2(this clsvPrjTabEN objvPrjTabEN, string strUpdDate2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate2, 20, convPrjTab.UpdDate2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabEN SetDataBaseNameTab(this clsvPrjTabEN objvPrjTabEN, string strDataBaseNameTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseNameTab, 50, convPrjTab.DataBaseNameTab);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjTabENS">源对象</param>
 /// <param name = "objvPrjTabENT">目标对象</param>
 public static void CopyTo(this clsvPrjTabEN objvPrjTabENS, clsvPrjTabEN objvPrjTabENT)
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
 /// <param name = "objvPrjTabENS">源对象</param>
 /// <returns>目标对象=>clsvPrjTabEN:objvPrjTabENT</returns>
 public static clsvPrjTabEN CopyTo(this clsvPrjTabEN objvPrjTabENS)
{
try
{
 clsvPrjTabEN objvPrjTabENT = new clsvPrjTabEN()
{
TabId = objvPrjTabENS.TabId, //表ID
TabName = objvPrjTabENS.TabName, //表名
TabCnName = objvPrjTabENS.TabCnName, //表中文名
PrjId = objvPrjTabENS.PrjId, //工程Id
SqlDsTypeId = objvPrjTabENS.SqlDsTypeId, //数据源类型Id
TabStateId = objvPrjTabENS.TabStateId, //表状态ID
FuncModuleAgcId = objvPrjTabENS.FuncModuleAgcId, //功能模块Id
FuncModuleEnName = objvPrjTabENS.FuncModuleEnName, //功能模块英文名称
IsReleToSqlTab = objvPrjTabENS.IsReleToSqlTab, //是否与SQL表相关
Keyword = objvPrjTabENS.Keyword, //关键字
TabTypeId = objvPrjTabENS.TabTypeId, //表类型Id
TabMainTypeId = objvPrjTabENS.TabMainTypeId, //表主类型Id
RelaTabId4View = objvPrjTabENS.RelaTabId4View, //视图的相关表ID
IsNeedGeneIndexer = objvPrjTabENS.IsNeedGeneIndexer, //是否需要生成索引器
ParentClass = objvPrjTabENS.ParentClass, //父类
IsUseCache = objvPrjTabENS.IsUseCache, //是否使用Cache
IsShare = objvPrjTabENS.IsShare, //是否共享
CacheClassifyField = objvPrjTabENS.CacheClassifyField, //缓存分类字段
CacheModeId = objvPrjTabENS.CacheModeId, //缓存方式Id
IsRefresh4RelaView = objvPrjTabENS.IsRefresh4RelaView, //是否刷新相关视图
TabRecNum = objvPrjTabENS.TabRecNum, //记录数
ErrMsg = objvPrjTabENS.ErrMsg, //错误信息
UpdUserId = objvPrjTabENS.UpdUserId, //修改用户Id
UpdDate = objvPrjTabENS.UpdDate, //修改日期
Memo = objvPrjTabENS.Memo, //说明
OrderNum4Refer = objvPrjTabENS.OrderNum4Refer, //引用序号
FuncModuleName = objvPrjTabENS.FuncModuleName, //功能模块名称
FldNum = objvPrjTabENS.FldNum, //字段数
SqlDsTypeName = objvPrjTabENS.SqlDsTypeName, //Sql数据源名
TabStateName = objvPrjTabENS.TabStateName, //表状态名称
TabMainTypeName = objvPrjTabENS.TabMainTypeName, //表主类型名
TabTypeName = objvPrjTabENS.TabTypeName, //表类型名
RelaTabName4View = objvPrjTabENS.RelaTabName4View, //RelaTabName4View
PrjName = objvPrjTabENS.PrjName, //工程名称
IsChecked = objvPrjTabENS.IsChecked, //是否核实
Owner = objvPrjTabENS.Owner, //拥有者
TabEnName = objvPrjTabENS.TabEnName, //表英文详细名
IsNeedTransCode = objvPrjTabENS.IsNeedTransCode, //是否需要转换代码
TabNameB = objvPrjTabENS.TabNameB, //表名_后备
IsNationStandard = objvPrjTabENS.IsNationStandard, //是否国标
IsParaTab = objvPrjTabENS.IsParaTab, //是否参数表
IsArchive = objvPrjTabENS.IsArchive, //是否存档
UpdDate2 = objvPrjTabENS.UpdDate2, //UpdDate2
DataBaseNameTab = objvPrjTabENS.DataBaseNameTab, //DataBaseName_Tab
};
 return objvPrjTabENT;
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
public static void CheckProperty4Condition(this clsvPrjTabEN objvPrjTabEN)
{
 clsvPrjTabBL.vPrjTabDA.CheckProperty4Condition(objvPrjTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjTab
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程表(vPrjTab)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabBL
{
public static RelatedActions_vPrjTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjTabDA vPrjTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjTabBL()
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
if (string.IsNullOrEmpty(clsvPrjTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTabEN._ConnectString);
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
public static DataTable GetDataTable_vPrjTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTabDA.GetDataTable_vPrjTab(strWhereCond);
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
objDT = vPrjTabDA.GetDataTable(strWhereCond);
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
objDT = vPrjTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjTabDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjTabEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabIdLst, true);
 string strWhereCond = string.Format("TabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjTabEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
List<clsvPrjTabEN> arrvPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabEN> arrvPrjTabObjLst_Sel =
arrvPrjTabObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrvPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabEN> GetObjLst(string strWhereCond)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
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
public static List<clsvPrjTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjTabEN> GetSubObjLstCache(clsvPrjTabEN objvPrjTabCond)
{
 string strPrjId = objvPrjTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPrjTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTab._AttributeName)
{
if (objvPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabCond[strFldName].ToString());
}
else
{
if (objvPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabCond[strFldName]));
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
public static List<clsvPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
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
public static List<clsvPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
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
List<clsvPrjTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
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
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
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
public static List<clsvPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
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
public static List<clsvPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjTab(ref clsvPrjTabEN objvPrjTabEN)
{
bool bolResult = vPrjTabDA.GetvPrjTab(ref objvPrjTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabEN GetObjByTabId(string strTabId)
{
if (strTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjTabEN objvPrjTabEN = vPrjTabDA.GetObjByTabId(strTabId);
return objvPrjTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjTabEN objvPrjTabEN = vPrjTabDA.GetFirstObj(strWhereCond);
 return objvPrjTabEN;
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
public static clsvPrjTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjTabEN objvPrjTabEN = vPrjTabDA.GetObjByDataRow(objRow);
 return objvPrjTabEN;
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
public static clsvPrjTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjTabEN objvPrjTabEN = vPrjTabDA.GetObjByDataRow(objRow);
 return objvPrjTabEN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "lstvPrjTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabEN GetObjByTabIdFromList(string strTabId, List<clsvPrjTabEN> lstvPrjTabObjLst)
{
foreach (clsvPrjTabEN objvPrjTabEN in lstvPrjTabObjLst)
{
if (objvPrjTabEN.TabId == strTabId)
{
return objvPrjTabEN;
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
 string strTabId;
 try
 {
 strTabId = new clsvPrjTabDA().GetFirstID(strWhereCond);
 return strTabId;
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
 arrList = vPrjTabDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjTabDA.IsExist(strTabId);
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
 bolIsExist = clsvPrjTabDA.IsExistTable();
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
 bolIsExist = vPrjTabDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjTabEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjTabEN objvPrjTabEN)
{
try
{
objvPrjTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabId = objvPrjTabEN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjTab.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabName = objvPrjTabEN.TabName; //表名
}
if (arrFldSet.Contains(convPrjTab.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabCnName = objvPrjTabEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convPrjTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.PrjId = objvPrjTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjTab.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.SqlDsTypeId = objvPrjTabEN.SqlDsTypeId == "[null]" ? null :  objvPrjTabEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convPrjTab.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabStateId = objvPrjTabEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convPrjTab.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.FuncModuleAgcId = objvPrjTabEN.FuncModuleAgcId == "[null]" ? null :  objvPrjTabEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convPrjTab.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.FuncModuleEnName = objvPrjTabEN.FuncModuleEnName == "[null]" ? null :  objvPrjTabEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convPrjTab.IsReleToSqlTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsReleToSqlTab = objvPrjTabEN.IsReleToSqlTab; //是否与SQL表相关
}
if (arrFldSet.Contains(convPrjTab.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.Keyword = objvPrjTabEN.Keyword == "[null]" ? null :  objvPrjTabEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPrjTab.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabTypeId = objvPrjTabEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(convPrjTab.TabMainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabMainTypeId = objvPrjTabEN.TabMainTypeId == "[null]" ? null :  objvPrjTabEN.TabMainTypeId; //表主类型Id
}
if (arrFldSet.Contains(convPrjTab.RelaTabId4View, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.RelaTabId4View = objvPrjTabEN.RelaTabId4View == "[null]" ? null :  objvPrjTabEN.RelaTabId4View; //视图的相关表ID
}
if (arrFldSet.Contains(convPrjTab.IsNeedGeneIndexer, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsNeedGeneIndexer = objvPrjTabEN.IsNeedGeneIndexer; //是否需要生成索引器
}
if (arrFldSet.Contains(convPrjTab.ParentClass, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.ParentClass = objvPrjTabEN.ParentClass == "[null]" ? null :  objvPrjTabEN.ParentClass; //父类
}
if (arrFldSet.Contains(convPrjTab.IsUseCache, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsUseCache = objvPrjTabEN.IsUseCache; //是否使用Cache
}
if (arrFldSet.Contains(convPrjTab.IsShare, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsShare = objvPrjTabEN.IsShare; //是否共享
}
if (arrFldSet.Contains(convPrjTab.CacheClassifyField, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.CacheClassifyField = objvPrjTabEN.CacheClassifyField == "[null]" ? null :  objvPrjTabEN.CacheClassifyField; //缓存分类字段
}
if (arrFldSet.Contains(convPrjTab.CacheModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.CacheModeId = objvPrjTabEN.CacheModeId == "[null]" ? null :  objvPrjTabEN.CacheModeId; //缓存方式Id
}
if (arrFldSet.Contains(convPrjTab.IsRefresh4RelaView, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsRefresh4RelaView = objvPrjTabEN.IsRefresh4RelaView; //是否刷新相关视图
}
if (arrFldSet.Contains(convPrjTab.TabRecNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabRecNum = objvPrjTabEN.TabRecNum; //记录数
}
if (arrFldSet.Contains(convPrjTab.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.ErrMsg = objvPrjTabEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(convPrjTab.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.UpdUserId = objvPrjTabEN.UpdUserId == "[null]" ? null :  objvPrjTabEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convPrjTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.UpdDate = objvPrjTabEN.UpdDate == "[null]" ? null :  objvPrjTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.Memo = objvPrjTabEN.Memo == "[null]" ? null :  objvPrjTabEN.Memo; //说明
}
if (arrFldSet.Contains(convPrjTab.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.OrderNum4Refer = objvPrjTabEN.OrderNum4Refer; //引用序号
}
if (arrFldSet.Contains(convPrjTab.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.FuncModuleName = objvPrjTabEN.FuncModuleName == "[null]" ? null :  objvPrjTabEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convPrjTab.FldNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.FldNum = objvPrjTabEN.FldNum; //字段数
}
if (arrFldSet.Contains(convPrjTab.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.SqlDsTypeName = objvPrjTabEN.SqlDsTypeName == "[null]" ? null :  objvPrjTabEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convPrjTab.TabStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabStateName = objvPrjTabEN.TabStateName == "[null]" ? null :  objvPrjTabEN.TabStateName; //表状态名称
}
if (arrFldSet.Contains(convPrjTab.TabMainTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabMainTypeName = objvPrjTabEN.TabMainTypeName == "[null]" ? null :  objvPrjTabEN.TabMainTypeName; //表主类型名
}
if (arrFldSet.Contains(convPrjTab.TabTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabTypeName = objvPrjTabEN.TabTypeName == "[null]" ? null :  objvPrjTabEN.TabTypeName; //表类型名
}
if (arrFldSet.Contains(convPrjTab.RelaTabName4View, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.RelaTabName4View = objvPrjTabEN.RelaTabName4View == "[null]" ? null :  objvPrjTabEN.RelaTabName4View; //RelaTabName4View
}
if (arrFldSet.Contains(convPrjTab.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.PrjName = objvPrjTabEN.PrjName == "[null]" ? null :  objvPrjTabEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convPrjTab.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsChecked = objvPrjTabEN.IsChecked; //是否核实
}
if (arrFldSet.Contains(convPrjTab.Owner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.Owner = objvPrjTabEN.Owner == "[null]" ? null :  objvPrjTabEN.Owner; //拥有者
}
if (arrFldSet.Contains(convPrjTab.TabEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabEnName = objvPrjTabEN.TabEnName == "[null]" ? null :  objvPrjTabEN.TabEnName; //表英文详细名
}
if (arrFldSet.Contains(convPrjTab.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsNeedTransCode = objvPrjTabEN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(convPrjTab.TabNameB, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.TabNameB = objvPrjTabEN.TabNameB; //表名_后备
}
if (arrFldSet.Contains(convPrjTab.IsNationStandard, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsNationStandard = objvPrjTabEN.IsNationStandard; //是否国标
}
if (arrFldSet.Contains(convPrjTab.IsParaTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsParaTab = objvPrjTabEN.IsParaTab; //是否参数表
}
if (arrFldSet.Contains(convPrjTab.IsArchive, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.IsArchive = objvPrjTabEN.IsArchive; //是否存档
}
if (arrFldSet.Contains(convPrjTab.UpdDate2, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.UpdDate2 = objvPrjTabEN.UpdDate2 == "[null]" ? null :  objvPrjTabEN.UpdDate2; //UpdDate2
}
if (arrFldSet.Contains(convPrjTab.DataBaseNameTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabEN.DataBaseNameTab = objvPrjTabEN.DataBaseNameTab == "[null]" ? null :  objvPrjTabEN.DataBaseNameTab; //DataBaseName_Tab
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
 /// <param name = "objvPrjTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjTabEN objvPrjTabEN)
{
try
{
if (objvPrjTabEN.SqlDsTypeId == "[null]") objvPrjTabEN.SqlDsTypeId = null; //数据源类型Id
if (objvPrjTabEN.FuncModuleAgcId == "[null]") objvPrjTabEN.FuncModuleAgcId = null; //功能模块Id
if (objvPrjTabEN.FuncModuleEnName == "[null]") objvPrjTabEN.FuncModuleEnName = null; //功能模块英文名称
if (objvPrjTabEN.Keyword == "[null]") objvPrjTabEN.Keyword = null; //关键字
if (objvPrjTabEN.TabMainTypeId == "[null]") objvPrjTabEN.TabMainTypeId = null; //表主类型Id
if (objvPrjTabEN.RelaTabId4View == "[null]") objvPrjTabEN.RelaTabId4View = null; //视图的相关表ID
if (objvPrjTabEN.ParentClass == "[null]") objvPrjTabEN.ParentClass = null; //父类
if (objvPrjTabEN.CacheClassifyField == "[null]") objvPrjTabEN.CacheClassifyField = null; //缓存分类字段
if (objvPrjTabEN.CacheModeId == "[null]") objvPrjTabEN.CacheModeId = null; //缓存方式Id
if (objvPrjTabEN.UpdUserId == "[null]") objvPrjTabEN.UpdUserId = null; //修改用户Id
if (objvPrjTabEN.UpdDate == "[null]") objvPrjTabEN.UpdDate = null; //修改日期
if (objvPrjTabEN.Memo == "[null]") objvPrjTabEN.Memo = null; //说明
if (objvPrjTabEN.FuncModuleName == "[null]") objvPrjTabEN.FuncModuleName = null; //功能模块名称
if (objvPrjTabEN.SqlDsTypeName == "[null]") objvPrjTabEN.SqlDsTypeName = null; //Sql数据源名
if (objvPrjTabEN.TabStateName == "[null]") objvPrjTabEN.TabStateName = null; //表状态名称
if (objvPrjTabEN.TabMainTypeName == "[null]") objvPrjTabEN.TabMainTypeName = null; //表主类型名
if (objvPrjTabEN.TabTypeName == "[null]") objvPrjTabEN.TabTypeName = null; //表类型名
if (objvPrjTabEN.RelaTabName4View == "[null]") objvPrjTabEN.RelaTabName4View = null; //RelaTabName4View
if (objvPrjTabEN.PrjName == "[null]") objvPrjTabEN.PrjName = null; //工程名称
if (objvPrjTabEN.Owner == "[null]") objvPrjTabEN.Owner = null; //拥有者
if (objvPrjTabEN.TabEnName == "[null]") objvPrjTabEN.TabEnName = null; //表英文详细名
if (objvPrjTabEN.UpdDate2 == "[null]") objvPrjTabEN.UpdDate2 = null; //UpdDate2
if (objvPrjTabEN.DataBaseNameTab == "[null]") objvPrjTabEN.DataBaseNameTab = null; //DataBaseName_Tab
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
public static void CheckProperty4Condition(clsvPrjTabEN objvPrjTabEN)
{
 vPrjTabDA.CheckProperty4Condition(objvPrjTabEN);
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
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrvPrjTabObjLstCache == null)
//{
//arrvPrjTabObjLstCache = vPrjTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabEN GetObjByTabIdCache(string strTabId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
List<clsvPrjTabEN> arrvPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabEN> arrvPrjTabObjLst_Sel =
arrvPrjTabObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrvPrjTabObjLst_Sel.Count() == 0)
{
   clsvPrjTabEN obj = clsvPrjTabBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabEN> GetAllvPrjTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvPrjTabEN> arrvPrjTabObjLstCache = GetObjLstCache(strPrjId); 
return arrvPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvPrjTabEN> arrvPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjTabObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:PrjId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrvPrjTabObjLst">需要排序的对象列表</param>
public static List <clsvPrjTabEN> GetSubSet4vPrjTabObjLstByPrjIdCache(string strPrjId)
{
   if (string.IsNullOrEmpty(strPrjId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
List<clsvPrjTabEN> arrvPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabEN> arrvPrjTabObjLst_Sel1 =
from objvPrjTabEN in arrvPrjTabObjLstCache
where objvPrjTabEN.PrjId == strPrjId
select objvPrjTabEN;
List <clsvPrjTabEN> arrvPrjTabObjLst_Sel = new List<clsvPrjTabEN>();
foreach (clsvPrjTabEN obj in arrvPrjTabObjLst_Sel1)
{
arrvPrjTabObjLst_Sel.Add(obj);
}
return arrvPrjTabObjLst_Sel;
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
string strKey = string.Format("{0}_{1}", clsvPrjTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvPrjTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjTabEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjTabEN._RefreshTimeLst[clsvPrjTabEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strTabId, string strPrjId)
{
if (strInFldName != convPrjTab.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjTab._AttributeName));
throw new Exception(strMsg);
}
var objvPrjTab = clsvPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
if (objvPrjTab == null) return "";
return objvPrjTab[strOutFldName].ToString();
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
int intRecCount = clsvPrjTabDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjTabDA.GetRecCount();
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
int intRecCount = clsvPrjTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjTabEN objvPrjTabCond)
{
 string strPrjId = objvPrjTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPrjTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTab._AttributeName)
{
if (objvPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabCond[strFldName].ToString());
}
else
{
if (objvPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabCond[strFldName]));
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
 List<string> arrList = clsvPrjTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}