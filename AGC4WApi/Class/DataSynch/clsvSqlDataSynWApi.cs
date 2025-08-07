
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlDataSynWApi
 表名:vSqlDataSyn(00050271)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:17
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
public static class  clsvSqlDataSynWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetPrimaryTypeId(this clsvSqlDataSynEN objvSqlDataSynEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convSqlDataSyn.PrimaryTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "intFieldNum">FieldNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetFieldNum(this clsvSqlDataSynEN objvSqlDataSynEN, int intFieldNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabId(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convSqlDataSyn.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convSqlDataSyn.TabId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetFuncModuleAgcId(this clsvSqlDataSynEN objvSqlDataSynEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convSqlDataSyn.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convSqlDataSyn.FuncModuleAgcId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetKeyword(this clsvSqlDataSynEN objvSqlDataSynEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 50, convSqlDataSyn.Keyword);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabTypeId(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convSqlDataSyn.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convSqlDataSyn.TabTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeName">表类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabTypeName(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convSqlDataSyn.TabTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetFuncModuleName(this clsvSqlDataSynEN objvSqlDataSynEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convSqlDataSyn.FuncModuleName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabName(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convSqlDataSyn.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convSqlDataSyn.TabName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTabCnName(this clsvSqlDataSynEN objvSqlDataSynEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convSqlDataSyn.TabCnName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlData">Sql表数据</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlCommandTypeName">Sql命令类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetSqlCommandTypeName(this clsvSqlDataSynEN objvSqlDataSynEN, string strSqlCommandTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlCommandTypeName, 30, convSqlDataSyn.SqlCommandTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strRecExclusiveWayName">记录排他方式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetRecExclusiveWayName(this clsvSqlDataSynEN objvSqlDataSynEN, string strRecExclusiveWayName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecExclusiveWayName, 30, convSqlDataSyn.RecExclusiveWayName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetPrjName(this clsvSqlDataSynEN objvSqlDataSynEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convSqlDataSyn.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convSqlDataSyn.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeName">主键类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetPrimaryTypeName(this clsvSqlDataSynEN objvSqlDataSynEN, string strPrimaryTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convSqlDataSyn.PrimaryTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlCommandTypeId">Sql命令类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetSqlCommandTypeId(this clsvSqlDataSynEN objvSqlDataSynEN, string strSqlCommandTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlCommandTypeId, 2, convSqlDataSyn.SqlCommandTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlCommandTypeId, 2, convSqlDataSyn.SqlCommandTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlCommandText">Sql命令内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetSqlCommandText(this clsvSqlDataSynEN objvSqlDataSynEN, string strSqlCommandText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlCommandText, 200, convSqlDataSyn.SqlCommandText);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "intSqlDataRecNum">Sql数据记录数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetSqlDataRecNum(this clsvSqlDataSynEN objvSqlDataSynEN, int intSqlDataRecNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTargetTabCondition">目标表有效记录条件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTargetTabCondition(this clsvSqlDataSynEN objvSqlDataSynEN, string strTargetTabCondition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTargetTabCondition, 300, convSqlDataSyn.TargetTabCondition);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "intTargetTabRecNum">目标表记录数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTargetTabRecNum(this clsvSqlDataSynEN objvSqlDataSynEN, int intTargetTabRecNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataSynDate">数据同步日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetDataSynDate(this clsvSqlDataSynEN objvSqlDataSynEN, string strDataSynDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataSynDate, 14, convSqlDataSyn.DataSynDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strRecExclusiveWayId">记录排他方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetRecExclusiveWayId(this clsvSqlDataSynEN objvSqlDataSynEN, string strRecExclusiveWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecExclusiveWayId, convSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckFieldLen(strRecExclusiveWayId, 4, convSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckFieldForeignKey(strRecExclusiveWayId, 4, convSqlDataSyn.RecExclusiveWayId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResouce">文本来源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTextResouce(this clsvSqlDataSynEN objvSqlDataSynEN, string strTextResouce, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResouce, convSqlDataSyn.TextResouce);
clsCheckSql.CheckFieldLen(strTextResouce, 100, convSqlDataSyn.TextResouce);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResourceTypeId">文本来源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetTextResourceTypeId(this clsvSqlDataSynEN objvSqlDataSynEN, string strTextResourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeId, convSqlDataSyn.TextResourceTypeId);
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, convSqlDataSyn.TextResourceTypeId);
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, convSqlDataSyn.TextResourceTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strAnalysisDate">分析日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetAnalysisDate(this clsvSqlDataSynEN objvSqlDataSynEN, string strAnalysisDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, convSqlDataSyn.AnalysisDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetPrjId(this clsvSqlDataSynEN objvSqlDataSynEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlDataSyn.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlDataSyn.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlDataSyn.PrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetErrMsg(this clsvSqlDataSynEN objvSqlDataSynEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convSqlDataSyn.ErrMsg);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetUpdDate(this clsvSqlDataSynEN objvSqlDataSynEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlDataSyn.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetUpdUserId(this clsvSqlDataSynEN objvSqlDataSynEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlDataSyn.UpdUserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlDataSynEN SetMemo(this clsvSqlDataSynEN objvSqlDataSynEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlDataSyn.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
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
 /// vSql数据同步(vSqlDataSyn)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSqlDataSynWApi
{
private static readonly string mstrApiControllerName = "vSqlDataSynApi";

 public clsvSqlDataSynWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlDataSynEN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsvSqlDataSynEN objvSqlDataSynEN;
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
objvSqlDataSynEN = JsonConvert.DeserializeObject<clsvSqlDataSynEN>(strJson);
return objvSqlDataSynEN;
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
public static clsvSqlDataSynEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvSqlDataSynEN objvSqlDataSynEN;
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
objvSqlDataSynEN = JsonConvert.DeserializeObject<clsvSqlDataSynEN>(strJson);
return objvSqlDataSynEN;
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
public static List<clsvSqlDataSynEN> GetObjLst(string strWhereCond)
{
 List<clsvSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlDataSynEN>>(strJson);
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
public static List<clsvSqlDataSynEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsvSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlDataSynEN>>(strJson);
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
public static List<clsvSqlDataSynEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlDataSynEN>>(strJson);
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
public static List<clsvSqlDataSynEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlDataSynEN>>(strJson);
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
public static List<clsvSqlDataSynEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlDataSynEN>>(strJson);
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
public static List<clsvSqlDataSynEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlDataSynEN>>(strJson);
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
public static DataTable ToDataTable(List<clsvSqlDataSynEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSqlDataSynEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSqlDataSynEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSqlDataSynEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSqlDataSynEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSqlDataSynEN._AttributeName)
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
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvSqlDataSynEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvSqlDataSynEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSqlDataSyn.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.FieldNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convSqlDataSyn.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.TabTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.SqlData, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.SqlCommandTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.RecExclusiveWayName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.PrimaryTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.SqlCommandTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.SqlCommandText, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.SqlDataRecNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convSqlDataSyn.TargetTabCondition, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.TargetTabRecNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convSqlDataSyn.DataSynDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.RecExclusiveWayId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.TextResouce, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.TextResourceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.AnalysisDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlDataSyn.Memo, Type.GetType("System.String"));
foreach (clsvSqlDataSynEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSqlDataSyn.PrimaryTypeId] = objInFor[convSqlDataSyn.PrimaryTypeId];
objDR[convSqlDataSyn.FieldNum] = objInFor[convSqlDataSyn.FieldNum];
objDR[convSqlDataSyn.TabId] = objInFor[convSqlDataSyn.TabId];
objDR[convSqlDataSyn.FuncModuleAgcId] = objInFor[convSqlDataSyn.FuncModuleAgcId];
objDR[convSqlDataSyn.Keyword] = objInFor[convSqlDataSyn.Keyword];
objDR[convSqlDataSyn.TabTypeId] = objInFor[convSqlDataSyn.TabTypeId];
objDR[convSqlDataSyn.TabTypeName] = objInFor[convSqlDataSyn.TabTypeName];
objDR[convSqlDataSyn.FuncModuleName] = objInFor[convSqlDataSyn.FuncModuleName];
objDR[convSqlDataSyn.TabName] = objInFor[convSqlDataSyn.TabName];
objDR[convSqlDataSyn.TabCnName] = objInFor[convSqlDataSyn.TabCnName];
objDR[convSqlDataSyn.SqlData] = objInFor[convSqlDataSyn.SqlData];
objDR[convSqlDataSyn.SqlCommandTypeName] = objInFor[convSqlDataSyn.SqlCommandTypeName];
objDR[convSqlDataSyn.RecExclusiveWayName] = objInFor[convSqlDataSyn.RecExclusiveWayName];
objDR[convSqlDataSyn.PrjName] = objInFor[convSqlDataSyn.PrjName];
objDR[convSqlDataSyn.PrimaryTypeName] = objInFor[convSqlDataSyn.PrimaryTypeName];
objDR[convSqlDataSyn.SqlCommandTypeId] = objInFor[convSqlDataSyn.SqlCommandTypeId];
objDR[convSqlDataSyn.SqlCommandText] = objInFor[convSqlDataSyn.SqlCommandText];
objDR[convSqlDataSyn.SqlDataRecNum] = objInFor[convSqlDataSyn.SqlDataRecNum];
objDR[convSqlDataSyn.TargetTabCondition] = objInFor[convSqlDataSyn.TargetTabCondition];
objDR[convSqlDataSyn.TargetTabRecNum] = objInFor[convSqlDataSyn.TargetTabRecNum];
objDR[convSqlDataSyn.DataSynDate] = objInFor[convSqlDataSyn.DataSynDate];
objDR[convSqlDataSyn.RecExclusiveWayId] = objInFor[convSqlDataSyn.RecExclusiveWayId];
objDR[convSqlDataSyn.TextResouce] = objInFor[convSqlDataSyn.TextResouce];
objDR[convSqlDataSyn.TextResourceTypeId] = objInFor[convSqlDataSyn.TextResourceTypeId];
objDR[convSqlDataSyn.AnalysisDate] = objInFor[convSqlDataSyn.AnalysisDate];
objDR[convSqlDataSyn.PrjId] = objInFor[convSqlDataSyn.PrjId];
objDR[convSqlDataSyn.ErrMsg] = objInFor[convSqlDataSyn.ErrMsg];
objDR[convSqlDataSyn.UpdDate] = objInFor[convSqlDataSyn.UpdDate];
objDR[convSqlDataSyn.UpdUserId] = objInFor[convSqlDataSyn.UpdUserId];
objDR[convSqlDataSyn.Memo] = objInFor[convSqlDataSyn.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}