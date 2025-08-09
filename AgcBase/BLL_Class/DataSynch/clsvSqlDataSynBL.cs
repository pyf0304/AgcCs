
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlDataSynBL
 表名:vSqlDataSyn(00050271)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
public static class  clsvSqlDataSynBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlDataSynEN GetObj(this K_TabId_vSqlDataSyn myKey)
{
clsvSqlDataSynEN objvSqlDataSynEN = clsvSqlDataSynBL.vSqlDataSynDA.GetObjByTabId(myKey.Value);
return objvSqlDataSynEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetPrimaryTypeId(this clsvSqlDataSynEN objvSqlDataSynEN, string strPrimaryTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convSqlDataSyn.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convSqlDataSyn.PrimaryTypeId);
}
objvSqlDataSynEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.PrimaryTypeId) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.PrimaryTypeId, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.PrimaryTypeId] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetFieldNum(this clsvSqlDataSynEN objvSqlDataSynEN, int? intFieldNum, string strComparisonOp="")
	{
objvSqlDataSynEN.FieldNum = intFieldNum; //FieldNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.FieldNum) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.FieldNum, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.FieldNum] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabId(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convSqlDataSyn.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convSqlDataSyn.TabId);
}
objvSqlDataSynEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.TabId) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.TabId, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.TabId] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetFuncModuleAgcId(this clsvSqlDataSynEN objvSqlDataSynEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convSqlDataSyn.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convSqlDataSyn.FuncModuleAgcId);
}
objvSqlDataSynEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.FuncModuleAgcId) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.FuncModuleAgcId, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.FuncModuleAgcId] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetKeyword(this clsvSqlDataSynEN objvSqlDataSynEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, convSqlDataSyn.Keyword);
}
objvSqlDataSynEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.Keyword) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.Keyword, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.Keyword] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabTypeId(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convSqlDataSyn.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convSqlDataSyn.TabTypeId);
}
objvSqlDataSynEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.TabTypeId) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.TabTypeId, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.TabTypeId] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabTypeName(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convSqlDataSyn.TabTypeName);
}
objvSqlDataSynEN.TabTypeName = strTabTypeName; //表类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.TabTypeName) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.TabTypeName, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.TabTypeName] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetFuncModuleName(this clsvSqlDataSynEN objvSqlDataSynEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convSqlDataSyn.FuncModuleName);
}
objvSqlDataSynEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.FuncModuleName) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.FuncModuleName, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.FuncModuleName] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabName(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convSqlDataSyn.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convSqlDataSyn.TabName);
}
objvSqlDataSynEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.TabName) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.TabName, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.TabName] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabCnName(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convSqlDataSyn.TabCnName);
}
objvSqlDataSynEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.TabCnName) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.TabCnName, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.TabCnName] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetSqlData(this clsvSqlDataSynEN objvSqlDataSynEN, string strSqlData, string strComparisonOp="")
	{
objvSqlDataSynEN.SqlData = strSqlData; //Sql表数据
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.SqlData) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.SqlData, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.SqlData] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetSqlCommandTypeName(this clsvSqlDataSynEN objvSqlDataSynEN, string strSqlCommandTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlCommandTypeName, 30, convSqlDataSyn.SqlCommandTypeName);
}
objvSqlDataSynEN.SqlCommandTypeName = strSqlCommandTypeName; //Sql命令类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.SqlCommandTypeName) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.SqlCommandTypeName, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.SqlCommandTypeName] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetRecExclusiveWayName(this clsvSqlDataSynEN objvSqlDataSynEN, string strRecExclusiveWayName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecExclusiveWayName, 30, convSqlDataSyn.RecExclusiveWayName);
}
objvSqlDataSynEN.RecExclusiveWayName = strRecExclusiveWayName; //记录排他方式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.RecExclusiveWayName) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.RecExclusiveWayName, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.RecExclusiveWayName] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetPrjName(this clsvSqlDataSynEN objvSqlDataSynEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convSqlDataSyn.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convSqlDataSyn.PrjName);
}
objvSqlDataSynEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.PrjName) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.PrjName, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.PrjName] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetPrimaryTypeName(this clsvSqlDataSynEN objvSqlDataSynEN, string strPrimaryTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convSqlDataSyn.PrimaryTypeName);
}
objvSqlDataSynEN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.PrimaryTypeName) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.PrimaryTypeName, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.PrimaryTypeName] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetSqlCommandTypeId(this clsvSqlDataSynEN objvSqlDataSynEN, string strSqlCommandTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlCommandTypeId, 2, convSqlDataSyn.SqlCommandTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlCommandTypeId, 2, convSqlDataSyn.SqlCommandTypeId);
}
objvSqlDataSynEN.SqlCommandTypeId = strSqlCommandTypeId; //Sql命令类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.SqlCommandTypeId) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.SqlCommandTypeId, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.SqlCommandTypeId] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetSqlCommandText(this clsvSqlDataSynEN objvSqlDataSynEN, string strSqlCommandText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlCommandText, 200, convSqlDataSyn.SqlCommandText);
}
objvSqlDataSynEN.SqlCommandText = strSqlCommandText; //Sql命令内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.SqlCommandText) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.SqlCommandText, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.SqlCommandText] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetSqlDataRecNum(this clsvSqlDataSynEN objvSqlDataSynEN, int? intSqlDataRecNum, string strComparisonOp="")
	{
objvSqlDataSynEN.SqlDataRecNum = intSqlDataRecNum; //Sql数据记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.SqlDataRecNum) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.SqlDataRecNum, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.SqlDataRecNum] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTargetTabCondition(this clsvSqlDataSynEN objvSqlDataSynEN, string strTargetTabCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTargetTabCondition, 300, convSqlDataSyn.TargetTabCondition);
}
objvSqlDataSynEN.TargetTabCondition = strTargetTabCondition; //目标表有效记录条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.TargetTabCondition) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.TargetTabCondition, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.TargetTabCondition] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTargetTabRecNum(this clsvSqlDataSynEN objvSqlDataSynEN, int? intTargetTabRecNum, string strComparisonOp="")
	{
objvSqlDataSynEN.TargetTabRecNum = intTargetTabRecNum; //目标表记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.TargetTabRecNum) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.TargetTabRecNum, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.TargetTabRecNum] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetDataSynDate(this clsvSqlDataSynEN objvSqlDataSynEN, string strDataSynDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataSynDate, 14, convSqlDataSyn.DataSynDate);
}
objvSqlDataSynEN.DataSynDate = strDataSynDate; //数据同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.DataSynDate) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.DataSynDate, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.DataSynDate] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetRecExclusiveWayId(this clsvSqlDataSynEN objvSqlDataSynEN, string strRecExclusiveWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecExclusiveWayId, convSqlDataSyn.RecExclusiveWayId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecExclusiveWayId, 4, convSqlDataSyn.RecExclusiveWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecExclusiveWayId, 4, convSqlDataSyn.RecExclusiveWayId);
}
objvSqlDataSynEN.RecExclusiveWayId = strRecExclusiveWayId; //记录排他方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.RecExclusiveWayId) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.RecExclusiveWayId, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.RecExclusiveWayId] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTextResouce(this clsvSqlDataSynEN objvSqlDataSynEN, string strTextResouce, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResouce, convSqlDataSyn.TextResouce);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResouce, 100, convSqlDataSyn.TextResouce);
}
objvSqlDataSynEN.TextResouce = strTextResouce; //文本来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.TextResouce) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.TextResouce, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.TextResouce] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTextResourceTypeId(this clsvSqlDataSynEN objvSqlDataSynEN, string strTextResourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeId, convSqlDataSyn.TextResourceTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, convSqlDataSyn.TextResourceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, convSqlDataSyn.TextResourceTypeId);
}
objvSqlDataSynEN.TextResourceTypeId = strTextResourceTypeId; //文本来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.TextResourceTypeId) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.TextResourceTypeId, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.TextResourceTypeId] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetAnalysisDate(this clsvSqlDataSynEN objvSqlDataSynEN, string strAnalysisDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, convSqlDataSyn.AnalysisDate);
}
objvSqlDataSynEN.AnalysisDate = strAnalysisDate; //分析日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.AnalysisDate) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.AnalysisDate, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.AnalysisDate] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetPrjId(this clsvSqlDataSynEN objvSqlDataSynEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlDataSyn.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlDataSyn.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlDataSyn.PrjId);
}
objvSqlDataSynEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.PrjId) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.PrjId, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.PrjId] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetErrMsg(this clsvSqlDataSynEN objvSqlDataSynEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convSqlDataSyn.ErrMsg);
}
objvSqlDataSynEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.ErrMsg) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.ErrMsg, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.ErrMsg] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetUpdDate(this clsvSqlDataSynEN objvSqlDataSynEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlDataSyn.UpdDate);
}
objvSqlDataSynEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.UpdDate) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.UpdDate, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.UpdDate] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetUpdUserId(this clsvSqlDataSynEN objvSqlDataSynEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlDataSyn.UpdUserId);
}
objvSqlDataSynEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.UpdUserId) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.UpdUserId, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.UpdUserId] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetMemo(this clsvSqlDataSynEN objvSqlDataSynEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlDataSyn.Memo);
}
objvSqlDataSynEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlDataSynEN.dicFldComparisonOp.ContainsKey(convSqlDataSyn.Memo) == false)
{
objvSqlDataSynEN.dicFldComparisonOp.Add(convSqlDataSyn.Memo, strComparisonOp);
}
else
{
objvSqlDataSynEN.dicFldComparisonOp[convSqlDataSyn.Memo] = strComparisonOp;
}
}
return objvSqlDataSynEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSqlDataSynENS">源对象</param>
 /// <param name = "objvSqlDataSynENT">目标对象</param>
 public static void CopyTo(this clsvSqlDataSynEN objvSqlDataSynENS, clsvSqlDataSynEN objvSqlDataSynENT)
{
try
{
objvSqlDataSynENT.PrimaryTypeId = objvSqlDataSynENS.PrimaryTypeId; //主键类型ID
objvSqlDataSynENT.FieldNum = objvSqlDataSynENS.FieldNum; //FieldNum
objvSqlDataSynENT.TabId = objvSqlDataSynENS.TabId; //表ID
objvSqlDataSynENT.FuncModuleAgcId = objvSqlDataSynENS.FuncModuleAgcId; //功能模块Id
objvSqlDataSynENT.Keyword = objvSqlDataSynENS.Keyword; //关键字
objvSqlDataSynENT.TabTypeId = objvSqlDataSynENS.TabTypeId; //表类型Id
objvSqlDataSynENT.TabTypeName = objvSqlDataSynENS.TabTypeName; //表类型名
objvSqlDataSynENT.FuncModuleName = objvSqlDataSynENS.FuncModuleName; //功能模块名称
objvSqlDataSynENT.TabName = objvSqlDataSynENS.TabName; //表名
objvSqlDataSynENT.TabCnName = objvSqlDataSynENS.TabCnName; //表中文名
objvSqlDataSynENT.SqlData = objvSqlDataSynENS.SqlData; //Sql表数据
objvSqlDataSynENT.SqlCommandTypeName = objvSqlDataSynENS.SqlCommandTypeName; //Sql命令类型名称
objvSqlDataSynENT.RecExclusiveWayName = objvSqlDataSynENS.RecExclusiveWayName; //记录排他方式名称
objvSqlDataSynENT.PrjName = objvSqlDataSynENS.PrjName; //工程名称
objvSqlDataSynENT.PrimaryTypeName = objvSqlDataSynENS.PrimaryTypeName; //主键类型名
objvSqlDataSynENT.SqlCommandTypeId = objvSqlDataSynENS.SqlCommandTypeId; //Sql命令类型Id
objvSqlDataSynENT.SqlCommandText = objvSqlDataSynENS.SqlCommandText; //Sql命令内容
objvSqlDataSynENT.SqlDataRecNum = objvSqlDataSynENS.SqlDataRecNum; //Sql数据记录数
objvSqlDataSynENT.TargetTabCondition = objvSqlDataSynENS.TargetTabCondition; //目标表有效记录条件
objvSqlDataSynENT.TargetTabRecNum = objvSqlDataSynENS.TargetTabRecNum; //目标表记录数
objvSqlDataSynENT.DataSynDate = objvSqlDataSynENS.DataSynDate; //数据同步日期
objvSqlDataSynENT.RecExclusiveWayId = objvSqlDataSynENS.RecExclusiveWayId; //记录排他方式Id
objvSqlDataSynENT.TextResouce = objvSqlDataSynENS.TextResouce; //文本来源
objvSqlDataSynENT.TextResourceTypeId = objvSqlDataSynENS.TextResourceTypeId; //文本来源类型Id
objvSqlDataSynENT.AnalysisDate = objvSqlDataSynENS.AnalysisDate; //分析日期
objvSqlDataSynENT.PrjId = objvSqlDataSynENS.PrjId; //工程Id
objvSqlDataSynENT.ErrMsg = objvSqlDataSynENS.ErrMsg; //错误信息
objvSqlDataSynENT.UpdDate = objvSqlDataSynENS.UpdDate; //修改日期
objvSqlDataSynENT.UpdUserId = objvSqlDataSynENS.UpdUserId; //修改用户Id
objvSqlDataSynENT.Memo = objvSqlDataSynENS.Memo; //说明
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
 /// <param name = "objvSqlDataSynENS">源对象</param>
 /// <returns>目标对象=>clsvSqlDataSynEN:objvSqlDataSynENT</returns>
 public static clsvSqlDataSynEN CopyTo(this clsvSqlDataSynEN objvSqlDataSynENS)
{
try
{
 clsvSqlDataSynEN objvSqlDataSynENT = new clsvSqlDataSynEN()
{
PrimaryTypeId = objvSqlDataSynENS.PrimaryTypeId, //主键类型ID
FieldNum = objvSqlDataSynENS.FieldNum, //FieldNum
TabId = objvSqlDataSynENS.TabId, //表ID
FuncModuleAgcId = objvSqlDataSynENS.FuncModuleAgcId, //功能模块Id
Keyword = objvSqlDataSynENS.Keyword, //关键字
TabTypeId = objvSqlDataSynENS.TabTypeId, //表类型Id
TabTypeName = objvSqlDataSynENS.TabTypeName, //表类型名
FuncModuleName = objvSqlDataSynENS.FuncModuleName, //功能模块名称
TabName = objvSqlDataSynENS.TabName, //表名
TabCnName = objvSqlDataSynENS.TabCnName, //表中文名
SqlData = objvSqlDataSynENS.SqlData, //Sql表数据
SqlCommandTypeName = objvSqlDataSynENS.SqlCommandTypeName, //Sql命令类型名称
RecExclusiveWayName = objvSqlDataSynENS.RecExclusiveWayName, //记录排他方式名称
PrjName = objvSqlDataSynENS.PrjName, //工程名称
PrimaryTypeName = objvSqlDataSynENS.PrimaryTypeName, //主键类型名
SqlCommandTypeId = objvSqlDataSynENS.SqlCommandTypeId, //Sql命令类型Id
SqlCommandText = objvSqlDataSynENS.SqlCommandText, //Sql命令内容
SqlDataRecNum = objvSqlDataSynENS.SqlDataRecNum, //Sql数据记录数
TargetTabCondition = objvSqlDataSynENS.TargetTabCondition, //目标表有效记录条件
TargetTabRecNum = objvSqlDataSynENS.TargetTabRecNum, //目标表记录数
DataSynDate = objvSqlDataSynENS.DataSynDate, //数据同步日期
RecExclusiveWayId = objvSqlDataSynENS.RecExclusiveWayId, //记录排他方式Id
TextResouce = objvSqlDataSynENS.TextResouce, //文本来源
TextResourceTypeId = objvSqlDataSynENS.TextResourceTypeId, //文本来源类型Id
AnalysisDate = objvSqlDataSynENS.AnalysisDate, //分析日期
PrjId = objvSqlDataSynENS.PrjId, //工程Id
ErrMsg = objvSqlDataSynENS.ErrMsg, //错误信息
UpdDate = objvSqlDataSynENS.UpdDate, //修改日期
UpdUserId = objvSqlDataSynENS.UpdUserId, //修改用户Id
Memo = objvSqlDataSynENS.Memo, //说明
};
 return objvSqlDataSynENT;
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
public static void CheckProperty4Condition(this clsvSqlDataSynEN objvSqlDataSynEN)
{
 clsvSqlDataSynBL.vSqlDataSynDA.CheckProperty4Condition(objvSqlDataSynEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSqlDataSynEN objvSqlDataSynCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.PrimaryTypeId, objvSqlDataSynCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.FieldNum) == true)
{
string strComparisonOpFieldNum = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.FieldNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSqlDataSyn.FieldNum, objvSqlDataSynCond.FieldNum, strComparisonOpFieldNum);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.TabId) == true)
{
string strComparisonOpTabId = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.TabId, objvSqlDataSynCond.TabId, strComparisonOpTabId);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.FuncModuleAgcId, objvSqlDataSynCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.Keyword) == true)
{
string strComparisonOpKeyword = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.Keyword, objvSqlDataSynCond.Keyword, strComparisonOpKeyword);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.TabTypeId, objvSqlDataSynCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.TabTypeName) == true)
{
string strComparisonOpTabTypeName = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.TabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.TabTypeName, objvSqlDataSynCond.TabTypeName, strComparisonOpTabTypeName);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.FuncModuleName, objvSqlDataSynCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.TabName) == true)
{
string strComparisonOpTabName = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.TabName, objvSqlDataSynCond.TabName, strComparisonOpTabName);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.TabCnName) == true)
{
string strComparisonOpTabCnName = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.TabCnName, objvSqlDataSynCond.TabCnName, strComparisonOpTabCnName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.SqlCommandTypeName) == true)
{
string strComparisonOpSqlCommandTypeName = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.SqlCommandTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.SqlCommandTypeName, objvSqlDataSynCond.SqlCommandTypeName, strComparisonOpSqlCommandTypeName);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.RecExclusiveWayName) == true)
{
string strComparisonOpRecExclusiveWayName = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.RecExclusiveWayName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.RecExclusiveWayName, objvSqlDataSynCond.RecExclusiveWayName, strComparisonOpRecExclusiveWayName);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.PrjName) == true)
{
string strComparisonOpPrjName = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.PrjName, objvSqlDataSynCond.PrjName, strComparisonOpPrjName);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.PrimaryTypeName, objvSqlDataSynCond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.SqlCommandTypeId) == true)
{
string strComparisonOpSqlCommandTypeId = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.SqlCommandTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.SqlCommandTypeId, objvSqlDataSynCond.SqlCommandTypeId, strComparisonOpSqlCommandTypeId);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.SqlCommandText) == true)
{
string strComparisonOpSqlCommandText = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.SqlCommandText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.SqlCommandText, objvSqlDataSynCond.SqlCommandText, strComparisonOpSqlCommandText);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.SqlDataRecNum) == true)
{
string strComparisonOpSqlDataRecNum = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.SqlDataRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSqlDataSyn.SqlDataRecNum, objvSqlDataSynCond.SqlDataRecNum, strComparisonOpSqlDataRecNum);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.TargetTabCondition) == true)
{
string strComparisonOpTargetTabCondition = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.TargetTabCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.TargetTabCondition, objvSqlDataSynCond.TargetTabCondition, strComparisonOpTargetTabCondition);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.TargetTabRecNum) == true)
{
string strComparisonOpTargetTabRecNum = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.TargetTabRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSqlDataSyn.TargetTabRecNum, objvSqlDataSynCond.TargetTabRecNum, strComparisonOpTargetTabRecNum);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.DataSynDate) == true)
{
string strComparisonOpDataSynDate = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.DataSynDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.DataSynDate, objvSqlDataSynCond.DataSynDate, strComparisonOpDataSynDate);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.RecExclusiveWayId) == true)
{
string strComparisonOpRecExclusiveWayId = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.RecExclusiveWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.RecExclusiveWayId, objvSqlDataSynCond.RecExclusiveWayId, strComparisonOpRecExclusiveWayId);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.TextResouce) == true)
{
string strComparisonOpTextResouce = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.TextResouce];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.TextResouce, objvSqlDataSynCond.TextResouce, strComparisonOpTextResouce);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.TextResourceTypeId) == true)
{
string strComparisonOpTextResourceTypeId = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.TextResourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.TextResourceTypeId, objvSqlDataSynCond.TextResourceTypeId, strComparisonOpTextResourceTypeId);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.AnalysisDate) == true)
{
string strComparisonOpAnalysisDate = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.AnalysisDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.AnalysisDate, objvSqlDataSynCond.AnalysisDate, strComparisonOpAnalysisDate);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.PrjId) == true)
{
string strComparisonOpPrjId = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.PrjId, objvSqlDataSynCond.PrjId, strComparisonOpPrjId);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.ErrMsg) == true)
{
string strComparisonOpErrMsg = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.ErrMsg, objvSqlDataSynCond.ErrMsg, strComparisonOpErrMsg);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.UpdDate, objvSqlDataSynCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.UpdUserId, objvSqlDataSynCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvSqlDataSynCond.IsUpdated(convSqlDataSyn.Memo) == true)
{
string strComparisonOpMemo = objvSqlDataSynCond.dicFldComparisonOp[convSqlDataSyn.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlDataSyn.Memo, objvSqlDataSynCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSqlDataSyn
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vSql数据同步(vSqlDataSyn)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSqlDataSynBL
{
public static RelatedActions_vSqlDataSyn relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSqlDataSynDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSqlDataSynDA vSqlDataSynDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSqlDataSynDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSqlDataSynBL()
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
if (string.IsNullOrEmpty(clsvSqlDataSynEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlDataSynEN._ConnectString);
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
public static DataTable GetDataTable_vSqlDataSyn(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSqlDataSynDA.GetDataTable_vSqlDataSyn(strWhereCond);
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
objDT = vSqlDataSynDA.GetDataTable(strWhereCond);
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
objDT = vSqlDataSynDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSqlDataSynDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSqlDataSynDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSqlDataSynDA.GetDataTable_Top(objTopPara);
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
objDT = vSqlDataSynDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSqlDataSynDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSqlDataSynDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvSqlDataSynEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
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
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSqlDataSynEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst)
{
string strKey = string.Format("{0}", clsvSqlDataSynEN._CurrTabName);
List<clsvSqlDataSynEN> arrvSqlDataSynObjLstCache = GetObjLstCache();
IEnumerable <clsvSqlDataSynEN> arrvSqlDataSynObjLst_Sel =
arrvSqlDataSynObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrvSqlDataSynObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlDataSynEN> GetObjLst(string strWhereCond)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
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
public static List<clsvSqlDataSynEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSqlDataSynCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSqlDataSynEN> GetSubObjLstCache(clsvSqlDataSynEN objvSqlDataSynCond)
{
List<clsvSqlDataSynEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSqlDataSynEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlDataSyn._AttributeName)
{
if (objvSqlDataSynCond.IsUpdated(strFldName) == false) continue;
if (objvSqlDataSynCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlDataSynCond[strFldName].ToString());
}
else
{
if (objvSqlDataSynCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlDataSynCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlDataSynCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlDataSynCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlDataSynCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlDataSynCond[strFldName]));
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
public static List<clsvSqlDataSynEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
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
public static List<clsvSqlDataSynEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
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
List<clsvSqlDataSynEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSqlDataSynEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlDataSynEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSqlDataSynEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
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
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
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
public static List<clsvSqlDataSynEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSqlDataSynEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSqlDataSynEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
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
public static List<clsvSqlDataSynEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlDataSynEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlDataSynEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSqlDataSyn(ref clsvSqlDataSynEN objvSqlDataSynEN)
{
bool bolResult = vSqlDataSynDA.GetvSqlDataSyn(ref objvSqlDataSynEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlDataSynEN GetObjByTabId(string strTabId)
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
clsvSqlDataSynEN objvSqlDataSynEN = vSqlDataSynDA.GetObjByTabId(strTabId);
return objvSqlDataSynEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSqlDataSynEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSqlDataSynEN objvSqlDataSynEN = vSqlDataSynDA.GetFirstObj(strWhereCond);
 return objvSqlDataSynEN;
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
public static clsvSqlDataSynEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSqlDataSynEN objvSqlDataSynEN = vSqlDataSynDA.GetObjByDataRow(objRow);
 return objvSqlDataSynEN;
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
public static clsvSqlDataSynEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSqlDataSynEN objvSqlDataSynEN = vSqlDataSynDA.GetObjByDataRow(objRow);
 return objvSqlDataSynEN;
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
 /// <param name = "lstvSqlDataSynObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlDataSynEN GetObjByTabIdFromList(string strTabId, List<clsvSqlDataSynEN> lstvSqlDataSynObjLst)
{
foreach (clsvSqlDataSynEN objvSqlDataSynEN in lstvSqlDataSynObjLst)
{
if (objvSqlDataSynEN.TabId == strTabId)
{
return objvSqlDataSynEN;
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
 strTabId = new clsvSqlDataSynDA().GetFirstID(strWhereCond);
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
 arrList = vSqlDataSynDA.GetID(strWhereCond);
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
bool bolIsExist = vSqlDataSynDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vSqlDataSynDA.IsExist(strTabId);
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
 bolIsExist = clsvSqlDataSynDA.IsExistTable();
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
 bolIsExist = vSqlDataSynDA.IsExistTable(strTabName);
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
 /// <param name = "objvSqlDataSynENS">源对象</param>
 /// <param name = "objvSqlDataSynENT">目标对象</param>
 public static void CopyTo(clsvSqlDataSynEN objvSqlDataSynENS, clsvSqlDataSynEN objvSqlDataSynENT)
{
try
{
objvSqlDataSynENT.PrimaryTypeId = objvSqlDataSynENS.PrimaryTypeId; //主键类型ID
objvSqlDataSynENT.FieldNum = objvSqlDataSynENS.FieldNum; //FieldNum
objvSqlDataSynENT.TabId = objvSqlDataSynENS.TabId; //表ID
objvSqlDataSynENT.FuncModuleAgcId = objvSqlDataSynENS.FuncModuleAgcId; //功能模块Id
objvSqlDataSynENT.Keyword = objvSqlDataSynENS.Keyword; //关键字
objvSqlDataSynENT.TabTypeId = objvSqlDataSynENS.TabTypeId; //表类型Id
objvSqlDataSynENT.TabTypeName = objvSqlDataSynENS.TabTypeName; //表类型名
objvSqlDataSynENT.FuncModuleName = objvSqlDataSynENS.FuncModuleName; //功能模块名称
objvSqlDataSynENT.TabName = objvSqlDataSynENS.TabName; //表名
objvSqlDataSynENT.TabCnName = objvSqlDataSynENS.TabCnName; //表中文名
objvSqlDataSynENT.SqlData = objvSqlDataSynENS.SqlData; //Sql表数据
objvSqlDataSynENT.SqlCommandTypeName = objvSqlDataSynENS.SqlCommandTypeName; //Sql命令类型名称
objvSqlDataSynENT.RecExclusiveWayName = objvSqlDataSynENS.RecExclusiveWayName; //记录排他方式名称
objvSqlDataSynENT.PrjName = objvSqlDataSynENS.PrjName; //工程名称
objvSqlDataSynENT.PrimaryTypeName = objvSqlDataSynENS.PrimaryTypeName; //主键类型名
objvSqlDataSynENT.SqlCommandTypeId = objvSqlDataSynENS.SqlCommandTypeId; //Sql命令类型Id
objvSqlDataSynENT.SqlCommandText = objvSqlDataSynENS.SqlCommandText; //Sql命令内容
objvSqlDataSynENT.SqlDataRecNum = objvSqlDataSynENS.SqlDataRecNum; //Sql数据记录数
objvSqlDataSynENT.TargetTabCondition = objvSqlDataSynENS.TargetTabCondition; //目标表有效记录条件
objvSqlDataSynENT.TargetTabRecNum = objvSqlDataSynENS.TargetTabRecNum; //目标表记录数
objvSqlDataSynENT.DataSynDate = objvSqlDataSynENS.DataSynDate; //数据同步日期
objvSqlDataSynENT.RecExclusiveWayId = objvSqlDataSynENS.RecExclusiveWayId; //记录排他方式Id
objvSqlDataSynENT.TextResouce = objvSqlDataSynENS.TextResouce; //文本来源
objvSqlDataSynENT.TextResourceTypeId = objvSqlDataSynENS.TextResourceTypeId; //文本来源类型Id
objvSqlDataSynENT.AnalysisDate = objvSqlDataSynENS.AnalysisDate; //分析日期
objvSqlDataSynENT.PrjId = objvSqlDataSynENS.PrjId; //工程Id
objvSqlDataSynENT.ErrMsg = objvSqlDataSynENS.ErrMsg; //错误信息
objvSqlDataSynENT.UpdDate = objvSqlDataSynENS.UpdDate; //修改日期
objvSqlDataSynENT.UpdUserId = objvSqlDataSynENS.UpdUserId; //修改用户Id
objvSqlDataSynENT.Memo = objvSqlDataSynENS.Memo; //说明
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
 /// <param name = "objvSqlDataSynEN">源简化对象</param>
 public static void SetUpdFlag(clsvSqlDataSynEN objvSqlDataSynEN)
{
try
{
objvSqlDataSynEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSqlDataSynEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSqlDataSyn.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.PrimaryTypeId = objvSqlDataSynEN.PrimaryTypeId == "[null]" ? null :  objvSqlDataSynEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(convSqlDataSyn.FieldNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.FieldNum = objvSqlDataSynEN.FieldNum; //FieldNum
}
if (arrFldSet.Contains(convSqlDataSyn.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.TabId = objvSqlDataSynEN.TabId; //表ID
}
if (arrFldSet.Contains(convSqlDataSyn.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.FuncModuleAgcId = objvSqlDataSynEN.FuncModuleAgcId == "[null]" ? null :  objvSqlDataSynEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convSqlDataSyn.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.Keyword = objvSqlDataSynEN.Keyword == "[null]" ? null :  objvSqlDataSynEN.Keyword; //关键字
}
if (arrFldSet.Contains(convSqlDataSyn.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.TabTypeId = objvSqlDataSynEN.TabTypeId == "[null]" ? null :  objvSqlDataSynEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(convSqlDataSyn.TabTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.TabTypeName = objvSqlDataSynEN.TabTypeName == "[null]" ? null :  objvSqlDataSynEN.TabTypeName; //表类型名
}
if (arrFldSet.Contains(convSqlDataSyn.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.FuncModuleName = objvSqlDataSynEN.FuncModuleName == "[null]" ? null :  objvSqlDataSynEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convSqlDataSyn.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.TabName = objvSqlDataSynEN.TabName; //表名
}
if (arrFldSet.Contains(convSqlDataSyn.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.TabCnName = objvSqlDataSynEN.TabCnName == "[null]" ? null :  objvSqlDataSynEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convSqlDataSyn.SqlData, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.SqlData = objvSqlDataSynEN.SqlData == "[null]" ? null :  objvSqlDataSynEN.SqlData; //Sql表数据
}
if (arrFldSet.Contains(convSqlDataSyn.SqlCommandTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.SqlCommandTypeName = objvSqlDataSynEN.SqlCommandTypeName == "[null]" ? null :  objvSqlDataSynEN.SqlCommandTypeName; //Sql命令类型名称
}
if (arrFldSet.Contains(convSqlDataSyn.RecExclusiveWayName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.RecExclusiveWayName = objvSqlDataSynEN.RecExclusiveWayName == "[null]" ? null :  objvSqlDataSynEN.RecExclusiveWayName; //记录排他方式名称
}
if (arrFldSet.Contains(convSqlDataSyn.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.PrjName = objvSqlDataSynEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convSqlDataSyn.PrimaryTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.PrimaryTypeName = objvSqlDataSynEN.PrimaryTypeName == "[null]" ? null :  objvSqlDataSynEN.PrimaryTypeName; //主键类型名
}
if (arrFldSet.Contains(convSqlDataSyn.SqlCommandTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.SqlCommandTypeId = objvSqlDataSynEN.SqlCommandTypeId == "[null]" ? null :  objvSqlDataSynEN.SqlCommandTypeId; //Sql命令类型Id
}
if (arrFldSet.Contains(convSqlDataSyn.SqlCommandText, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.SqlCommandText = objvSqlDataSynEN.SqlCommandText == "[null]" ? null :  objvSqlDataSynEN.SqlCommandText; //Sql命令内容
}
if (arrFldSet.Contains(convSqlDataSyn.SqlDataRecNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.SqlDataRecNum = objvSqlDataSynEN.SqlDataRecNum; //Sql数据记录数
}
if (arrFldSet.Contains(convSqlDataSyn.TargetTabCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.TargetTabCondition = objvSqlDataSynEN.TargetTabCondition == "[null]" ? null :  objvSqlDataSynEN.TargetTabCondition; //目标表有效记录条件
}
if (arrFldSet.Contains(convSqlDataSyn.TargetTabRecNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.TargetTabRecNum = objvSqlDataSynEN.TargetTabRecNum; //目标表记录数
}
if (arrFldSet.Contains(convSqlDataSyn.DataSynDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.DataSynDate = objvSqlDataSynEN.DataSynDate == "[null]" ? null :  objvSqlDataSynEN.DataSynDate; //数据同步日期
}
if (arrFldSet.Contains(convSqlDataSyn.RecExclusiveWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.RecExclusiveWayId = objvSqlDataSynEN.RecExclusiveWayId; //记录排他方式Id
}
if (arrFldSet.Contains(convSqlDataSyn.TextResouce, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.TextResouce = objvSqlDataSynEN.TextResouce; //文本来源
}
if (arrFldSet.Contains(convSqlDataSyn.TextResourceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.TextResourceTypeId = objvSqlDataSynEN.TextResourceTypeId; //文本来源类型Id
}
if (arrFldSet.Contains(convSqlDataSyn.AnalysisDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.AnalysisDate = objvSqlDataSynEN.AnalysisDate == "[null]" ? null :  objvSqlDataSynEN.AnalysisDate; //分析日期
}
if (arrFldSet.Contains(convSqlDataSyn.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.PrjId = objvSqlDataSynEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convSqlDataSyn.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.ErrMsg = objvSqlDataSynEN.ErrMsg == "[null]" ? null :  objvSqlDataSynEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(convSqlDataSyn.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.UpdDate = objvSqlDataSynEN.UpdDate == "[null]" ? null :  objvSqlDataSynEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSqlDataSyn.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.UpdUserId = objvSqlDataSynEN.UpdUserId == "[null]" ? null :  objvSqlDataSynEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convSqlDataSyn.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlDataSynEN.Memo = objvSqlDataSynEN.Memo == "[null]" ? null :  objvSqlDataSynEN.Memo; //说明
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
 /// <param name = "objvSqlDataSynEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSqlDataSynEN objvSqlDataSynEN)
{
try
{
if (objvSqlDataSynEN.PrimaryTypeId == "[null]") objvSqlDataSynEN.PrimaryTypeId = null; //主键类型ID
if (objvSqlDataSynEN.FuncModuleAgcId == "[null]") objvSqlDataSynEN.FuncModuleAgcId = null; //功能模块Id
if (objvSqlDataSynEN.Keyword == "[null]") objvSqlDataSynEN.Keyword = null; //关键字
if (objvSqlDataSynEN.TabTypeId == "[null]") objvSqlDataSynEN.TabTypeId = null; //表类型Id
if (objvSqlDataSynEN.TabTypeName == "[null]") objvSqlDataSynEN.TabTypeName = null; //表类型名
if (objvSqlDataSynEN.FuncModuleName == "[null]") objvSqlDataSynEN.FuncModuleName = null; //功能模块名称
if (objvSqlDataSynEN.TabCnName == "[null]") objvSqlDataSynEN.TabCnName = null; //表中文名
if (objvSqlDataSynEN.SqlData == "[null]") objvSqlDataSynEN.SqlData = null; //Sql表数据
if (objvSqlDataSynEN.SqlCommandTypeName == "[null]") objvSqlDataSynEN.SqlCommandTypeName = null; //Sql命令类型名称
if (objvSqlDataSynEN.RecExclusiveWayName == "[null]") objvSqlDataSynEN.RecExclusiveWayName = null; //记录排他方式名称
if (objvSqlDataSynEN.PrimaryTypeName == "[null]") objvSqlDataSynEN.PrimaryTypeName = null; //主键类型名
if (objvSqlDataSynEN.SqlCommandTypeId == "[null]") objvSqlDataSynEN.SqlCommandTypeId = null; //Sql命令类型Id
if (objvSqlDataSynEN.SqlCommandText == "[null]") objvSqlDataSynEN.SqlCommandText = null; //Sql命令内容
if (objvSqlDataSynEN.TargetTabCondition == "[null]") objvSqlDataSynEN.TargetTabCondition = null; //目标表有效记录条件
if (objvSqlDataSynEN.DataSynDate == "[null]") objvSqlDataSynEN.DataSynDate = null; //数据同步日期
if (objvSqlDataSynEN.AnalysisDate == "[null]") objvSqlDataSynEN.AnalysisDate = null; //分析日期
if (objvSqlDataSynEN.ErrMsg == "[null]") objvSqlDataSynEN.ErrMsg = null; //错误信息
if (objvSqlDataSynEN.UpdDate == "[null]") objvSqlDataSynEN.UpdDate = null; //修改日期
if (objvSqlDataSynEN.UpdUserId == "[null]") objvSqlDataSynEN.UpdUserId = null; //修改用户Id
if (objvSqlDataSynEN.Memo == "[null]") objvSqlDataSynEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvSqlDataSynEN objvSqlDataSynEN)
{
 vSqlDataSynDA.CheckProperty4Condition(objvSqlDataSynEN);
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrimaryTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrimaryTypeBL没有刷新缓存机制(clsPrimaryTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSqlDataSynBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlDataSynBL没有刷新缓存机制(clsSqlDataSynBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSqlCommandTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlCommandTypeBL没有刷新缓存机制(clsSqlCommandTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecExclusiveWayBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecExclusiveWayBL没有刷新缓存机制(clsRecExclusiveWayBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrvSqlDataSynObjLstCache == null)
//{
//arrvSqlDataSynObjLstCache = vSqlDataSynDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlDataSynEN GetObjByTabIdCache(string strTabId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSqlDataSynEN._CurrTabName);
List<clsvSqlDataSynEN> arrvSqlDataSynObjLstCache = GetObjLstCache();
IEnumerable <clsvSqlDataSynEN> arrvSqlDataSynObjLst_Sel =
arrvSqlDataSynObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrvSqlDataSynObjLst_Sel.Count() == 0)
{
   clsvSqlDataSynEN obj = clsvSqlDataSynBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSqlDataSynObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlDataSynEN> GetAllvSqlDataSynObjLstCache()
{
//获取缓存中的对象列表
List<clsvSqlDataSynEN> arrvSqlDataSynObjLstCache = GetObjLstCache(); 
return arrvSqlDataSynObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlDataSynEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSqlDataSynEN._CurrTabName);
List<clsvSqlDataSynEN> arrvSqlDataSynObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSqlDataSynObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvSqlDataSynEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvSqlDataSynEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvSqlDataSynEN._RefreshTimeLst.Count == 0) return "";
return clsvSqlDataSynEN._RefreshTimeLst[clsvSqlDataSynEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTabId)
{
if (strInFldName != convSqlDataSyn.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSqlDataSyn._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSqlDataSyn._AttributeName));
throw new Exception(strMsg);
}
var objvSqlDataSyn = clsvSqlDataSynBL.GetObjByTabIdCache(strTabId);
if (objvSqlDataSyn == null) return "";
return objvSqlDataSyn[strOutFldName].ToString();
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
int intRecCount = clsvSqlDataSynDA.GetRecCount(strTabName);
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
int intRecCount = clsvSqlDataSynDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSqlDataSynDA.GetRecCount();
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
int intRecCount = clsvSqlDataSynDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSqlDataSynCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSqlDataSynEN objvSqlDataSynCond)
{
List<clsvSqlDataSynEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSqlDataSynEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlDataSyn._AttributeName)
{
if (objvSqlDataSynCond.IsUpdated(strFldName) == false) continue;
if (objvSqlDataSynCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlDataSynCond[strFldName].ToString());
}
else
{
if (objvSqlDataSynCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlDataSynCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlDataSynCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlDataSynCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlDataSynCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlDataSynCond[strFldName]));
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
 List<string> arrList = clsvSqlDataSynDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSqlDataSynDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSqlDataSynDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}