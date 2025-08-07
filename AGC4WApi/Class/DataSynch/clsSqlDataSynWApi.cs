
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlDataSynWApi
 表名:SqlDataSyn(00050269)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:15
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
public static class  clsSqlDataSynWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTabId(this clsSqlDataSynEN objSqlDataSynEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, conSqlDataSyn.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conSqlDataSyn.TabId);
objSqlDataSynEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TabId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TabId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TabId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTabName(this clsSqlDataSynEN objSqlDataSynEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, conSqlDataSyn.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, conSqlDataSyn.TabName);
objSqlDataSynEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TabName) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TabName, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TabName] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTabCnName(this clsSqlDataSynEN objSqlDataSynEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCnName, conSqlDataSyn.TabCnName);
clsCheckSql.CheckFieldLen(strTabCnName, 200, conSqlDataSyn.TabCnName);
objSqlDataSynEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TabCnName) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TabCnName, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TabCnName] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabEnName">表英文详细名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTabEnName(this clsSqlDataSynEN objSqlDataSynEN, string strTabEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabEnName, 200, conSqlDataSyn.TabEnName);
objSqlDataSynEN.TabEnName = strTabEnName; //表英文详细名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TabEnName) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TabEnName, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TabEnName] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlData">Sql表数据</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetSqlData(this clsSqlDataSynEN objSqlDataSynEN, string strSqlData, string strComparisonOp="")
	{
objSqlDataSynEN.SqlData = strSqlData; //Sql表数据
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.SqlData) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.SqlData, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.SqlData] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlCommandTypeId">Sql命令类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetSqlCommandTypeId(this clsSqlDataSynEN objSqlDataSynEN, string strSqlCommandTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlCommandTypeId, 2, conSqlDataSyn.SqlCommandTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlCommandTypeId, 2, conSqlDataSyn.SqlCommandTypeId);
objSqlDataSynEN.SqlCommandTypeId = strSqlCommandTypeId; //Sql命令类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.SqlCommandTypeId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.SqlCommandTypeId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.SqlCommandTypeId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlCommandText">Sql命令内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetSqlCommandText(this clsSqlDataSynEN objSqlDataSynEN, string strSqlCommandText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlCommandText, 200, conSqlDataSyn.SqlCommandText);
objSqlDataSynEN.SqlCommandText = strSqlCommandText; //Sql命令内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.SqlCommandText) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.SqlCommandText, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.SqlCommandText] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "intSqlDataRecNum">Sql数据记录数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetSqlDataRecNum(this clsSqlDataSynEN objSqlDataSynEN, int intSqlDataRecNum, string strComparisonOp="")
	{
objSqlDataSynEN.SqlDataRecNum = intSqlDataRecNum; //Sql数据记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.SqlDataRecNum) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.SqlDataRecNum, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.SqlDataRecNum] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTargetTabCondition">目标表有效记录条件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTargetTabCondition(this clsSqlDataSynEN objSqlDataSynEN, string strTargetTabCondition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTargetTabCondition, 300, conSqlDataSyn.TargetTabCondition);
objSqlDataSynEN.TargetTabCondition = strTargetTabCondition; //目标表有效记录条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TargetTabCondition) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TargetTabCondition, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TargetTabCondition] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "intTargetTabRecNum">目标表记录数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTargetTabRecNum(this clsSqlDataSynEN objSqlDataSynEN, int intTargetTabRecNum, string strComparisonOp="")
	{
objSqlDataSynEN.TargetTabRecNum = intTargetTabRecNum; //目标表记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TargetTabRecNum) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TargetTabRecNum, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TargetTabRecNum] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataSynDate">数据同步日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetDataSynDate(this clsSqlDataSynEN objSqlDataSynEN, string strDataSynDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataSynDate, 14, conSqlDataSyn.DataSynDate);
objSqlDataSynEN.DataSynDate = strDataSynDate; //数据同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.DataSynDate) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.DataSynDate, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.DataSynDate] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetPrimaryTypeId(this clsSqlDataSynEN objSqlDataSynEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, conSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, conSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, conSqlDataSyn.PrimaryTypeId);
objSqlDataSynEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.PrimaryTypeId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.PrimaryTypeId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.PrimaryTypeId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strRecExclusiveWayId">记录排他方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetRecExclusiveWayId(this clsSqlDataSynEN objSqlDataSynEN, string strRecExclusiveWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecExclusiveWayId, conSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckFieldLen(strRecExclusiveWayId, 4, conSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckFieldForeignKey(strRecExclusiveWayId, 4, conSqlDataSyn.RecExclusiveWayId);
objSqlDataSynEN.RecExclusiveWayId = strRecExclusiveWayId; //记录排他方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.RecExclusiveWayId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.RecExclusiveWayId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.RecExclusiveWayId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResouce">文本来源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTextResouce(this clsSqlDataSynEN objSqlDataSynEN, string strTextResouce, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextResouce, 100, conSqlDataSyn.TextResouce);
objSqlDataSynEN.TextResouce = strTextResouce; //文本来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TextResouce) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TextResouce, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TextResouce] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResourceTypeId">文本来源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTextResourceTypeId(this clsSqlDataSynEN objSqlDataSynEN, string strTextResourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, conSqlDataSyn.TextResourceTypeId);
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, conSqlDataSyn.TextResourceTypeId);
objSqlDataSynEN.TextResourceTypeId = strTextResourceTypeId; //文本来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TextResourceTypeId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TextResourceTypeId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TextResourceTypeId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strAnalysisDate">分析日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetAnalysisDate(this clsSqlDataSynEN objSqlDataSynEN, string strAnalysisDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, conSqlDataSyn.AnalysisDate);
objSqlDataSynEN.AnalysisDate = strAnalysisDate; //分析日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.AnalysisDate) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.AnalysisDate, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.AnalysisDate] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetPrjId(this clsSqlDataSynEN objSqlDataSynEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSqlDataSyn.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conSqlDataSyn.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSqlDataSyn.PrjId);
objSqlDataSynEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.PrjId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.PrjId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.PrjId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetErrMsg(this clsSqlDataSynEN objSqlDataSynEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conSqlDataSyn.ErrMsg);
objSqlDataSynEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.ErrMsg) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.ErrMsg, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.ErrMsg] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetUpdDate(this clsSqlDataSynEN objSqlDataSynEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSqlDataSyn.UpdDate);
objSqlDataSynEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.UpdDate) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.UpdDate, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.UpdDate] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetUpdUserId(this clsSqlDataSynEN objSqlDataSynEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSqlDataSyn.UpdUserId);
objSqlDataSynEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.UpdUserId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.UpdUserId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.UpdUserId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetMemo(this clsSqlDataSynEN objSqlDataSynEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSqlDataSyn.Memo);
objSqlDataSynEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.Memo) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.Memo, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.Memo] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSqlDataSynEN objSqlDataSynCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TabId) == true)
{
string strComparisonOpTabId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TabId, objSqlDataSynCond.TabId, strComparisonOpTabId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TabName) == true)
{
string strComparisonOpTabName = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TabName, objSqlDataSynCond.TabName, strComparisonOpTabName);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TabCnName) == true)
{
string strComparisonOpTabCnName = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TabCnName, objSqlDataSynCond.TabCnName, strComparisonOpTabCnName);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TabEnName) == true)
{
string strComparisonOpTabEnName = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TabEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TabEnName, objSqlDataSynCond.TabEnName, strComparisonOpTabEnName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.SqlCommandTypeId) == true)
{
string strComparisonOpSqlCommandTypeId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.SqlCommandTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.SqlCommandTypeId, objSqlDataSynCond.SqlCommandTypeId, strComparisonOpSqlCommandTypeId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.SqlCommandText) == true)
{
string strComparisonOpSqlCommandText = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.SqlCommandText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.SqlCommandText, objSqlDataSynCond.SqlCommandText, strComparisonOpSqlCommandText);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.SqlDataRecNum) == true)
{
string strComparisonOpSqlDataRecNum = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.SqlDataRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlDataSyn.SqlDataRecNum, objSqlDataSynCond.SqlDataRecNum, strComparisonOpSqlDataRecNum);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TargetTabCondition) == true)
{
string strComparisonOpTargetTabCondition = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TargetTabCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TargetTabCondition, objSqlDataSynCond.TargetTabCondition, strComparisonOpTargetTabCondition);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TargetTabRecNum) == true)
{
string strComparisonOpTargetTabRecNum = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TargetTabRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlDataSyn.TargetTabRecNum, objSqlDataSynCond.TargetTabRecNum, strComparisonOpTargetTabRecNum);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.DataSynDate) == true)
{
string strComparisonOpDataSynDate = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.DataSynDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.DataSynDate, objSqlDataSynCond.DataSynDate, strComparisonOpDataSynDate);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.PrimaryTypeId, objSqlDataSynCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.RecExclusiveWayId) == true)
{
string strComparisonOpRecExclusiveWayId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.RecExclusiveWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.RecExclusiveWayId, objSqlDataSynCond.RecExclusiveWayId, strComparisonOpRecExclusiveWayId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TextResouce) == true)
{
string strComparisonOpTextResouce = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TextResouce];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TextResouce, objSqlDataSynCond.TextResouce, strComparisonOpTextResouce);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TextResourceTypeId) == true)
{
string strComparisonOpTextResourceTypeId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TextResourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TextResourceTypeId, objSqlDataSynCond.TextResourceTypeId, strComparisonOpTextResourceTypeId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.AnalysisDate) == true)
{
string strComparisonOpAnalysisDate = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.AnalysisDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.AnalysisDate, objSqlDataSynCond.AnalysisDate, strComparisonOpAnalysisDate);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.PrjId) == true)
{
string strComparisonOpPrjId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.PrjId, objSqlDataSynCond.PrjId, strComparisonOpPrjId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.ErrMsg) == true)
{
string strComparisonOpErrMsg = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.ErrMsg, objSqlDataSynCond.ErrMsg, strComparisonOpErrMsg);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.UpdDate) == true)
{
string strComparisonOpUpdDate = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.UpdDate, objSqlDataSynCond.UpdDate, strComparisonOpUpdDate);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.UpdUserId, objSqlDataSynCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.Memo) == true)
{
string strComparisonOpMemo = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.Memo, objSqlDataSynCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlDataSynEN objSqlDataSynEN)
{
 if (string.IsNullOrEmpty(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSqlDataSynEN.sfUpdFldSetStr = objSqlDataSynEN.getsfUpdFldSetStr();
clsSqlDataSynWApi.CheckPropertyNew(objSqlDataSynEN); 
bool bolResult = clsSqlDataSynWApi.UpdateRecord(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSqlDataSynEN objSqlDataSynEN)
{
 if (string.IsNullOrEmpty(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSqlDataSynWApi.IsExist(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSqlDataSynEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsSqlDataSynWApi.CheckPropertyNew(objSqlDataSynEN); 
bool bolResult = clsSqlDataSynWApi.AddNewRecord(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSqlDataSynEN objSqlDataSynEN)
{
try
{
clsSqlDataSynWApi.CheckPropertyNew(objSqlDataSynEN); 
string strTabId = clsSqlDataSynWApi.AddNewRecordWithMaxId(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objSqlDataSynEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlDataSynEN objSqlDataSynEN, string strWhereCond)
{
try
{
clsSqlDataSynWApi.CheckPropertyNew(objSqlDataSynEN); 
bool bolResult = clsSqlDataSynWApi.UpdateWithCondition(objSqlDataSynEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// Sql数据同步(SqlDataSyn)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSqlDataSynWApi
{
private static readonly string mstrApiControllerName = "SqlDataSynApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsSqlDataSynWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSqlDataSynEN objSqlDataSynEN)
{
if (!Object.Equals(null, objSqlDataSynEN.TabId) && GetStrLen(objSqlDataSynEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlDataSynEN.TabName) && GetStrLen(objSqlDataSynEN.TabName) > 100)
{
 throw new Exception("字段[表名]的长度不能超过100!");
}
if (!Object.Equals(null, objSqlDataSynEN.TabCnName) && GetStrLen(objSqlDataSynEN.TabCnName) > 200)
{
 throw new Exception("字段[表中文名]的长度不能超过200!");
}
if (!Object.Equals(null, objSqlDataSynEN.TabEnName) && GetStrLen(objSqlDataSynEN.TabEnName) > 200)
{
 throw new Exception("字段[表英文详细名]的长度不能超过200!");
}
if (!Object.Equals(null, objSqlDataSynEN.SqlCommandTypeId) && GetStrLen(objSqlDataSynEN.SqlCommandTypeId) > 2)
{
 throw new Exception("字段[Sql命令类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objSqlDataSynEN.SqlCommandText) && GetStrLen(objSqlDataSynEN.SqlCommandText) > 200)
{
 throw new Exception("字段[Sql命令内容]的长度不能超过200!");
}
if (!Object.Equals(null, objSqlDataSynEN.TargetTabCondition) && GetStrLen(objSqlDataSynEN.TargetTabCondition) > 300)
{
 throw new Exception("字段[目标表有效记录条件]的长度不能超过300!");
}
if (!Object.Equals(null, objSqlDataSynEN.DataSynDate) && GetStrLen(objSqlDataSynEN.DataSynDate) > 14)
{
 throw new Exception("字段[数据同步日期]的长度不能超过14!");
}
if (!Object.Equals(null, objSqlDataSynEN.PrimaryTypeId) && GetStrLen(objSqlDataSynEN.PrimaryTypeId) > 2)
{
 throw new Exception("字段[主键类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objSqlDataSynEN.RecExclusiveWayId) && GetStrLen(objSqlDataSynEN.RecExclusiveWayId) > 4)
{
 throw new Exception("字段[记录排他方式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSqlDataSynEN.TextResouce) && GetStrLen(objSqlDataSynEN.TextResouce) > 100)
{
 throw new Exception("字段[文本来源]的长度不能超过100!");
}
if (!Object.Equals(null, objSqlDataSynEN.TextResourceTypeId) && GetStrLen(objSqlDataSynEN.TextResourceTypeId) > 2)
{
 throw new Exception("字段[文本来源类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objSqlDataSynEN.AnalysisDate) && GetStrLen(objSqlDataSynEN.AnalysisDate) > 20)
{
 throw new Exception("字段[分析日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlDataSynEN.PrjId) && GetStrLen(objSqlDataSynEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSqlDataSynEN.ErrMsg) && GetStrLen(objSqlDataSynEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objSqlDataSynEN.UpdDate) && GetStrLen(objSqlDataSynEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlDataSynEN.UpdUserId) && GetStrLen(objSqlDataSynEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlDataSynEN.Memo) && GetStrLen(objSqlDataSynEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objSqlDataSynEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlDataSynEN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsSqlDataSynEN objSqlDataSynEN;
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
objSqlDataSynEN = JsonConvert.DeserializeObject<clsSqlDataSynEN>(strJson);
return objSqlDataSynEN;
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
public static clsSqlDataSynEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsSqlDataSynEN objSqlDataSynEN;
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
objSqlDataSynEN = JsonConvert.DeserializeObject<clsSqlDataSynEN>(strJson);
return objSqlDataSynEN;
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
public static List<clsSqlDataSynEN> GetObjLst(string strWhereCond)
{
 List<clsSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlDataSynEN>>(strJson);
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
public static List<clsSqlDataSynEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlDataSynEN>>(strJson);
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
public static List<clsSqlDataSynEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlDataSynEN>>(strJson);
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
public static List<clsSqlDataSynEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlDataSynEN>>(strJson);
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
public static List<clsSqlDataSynEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlDataSynEN>>(strJson);
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
public static List<clsSqlDataSynEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsSqlDataSynEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlDataSynEN>>(strJson);
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
 clsSqlDataSynEN objSqlDataSynEN = clsSqlDataSynWApi.GetObjByTabId(strTabId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strTabId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelSqlDataSyns(List<string> arrTabId)
{
string strAction = "DelSqlDataSyns";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTabId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelSqlDataSynsByCond(string strWhereCond)
{
string strAction = "DelSqlDataSynsByCond";
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
public static bool AddNewRecord(clsSqlDataSynEN objSqlDataSynEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlDataSynEN>(objSqlDataSynEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static string AddNewRecordWithMaxId(clsSqlDataSynEN objSqlDataSynEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlDataSynEN>(objSqlDataSynEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static bool UpdateRecord(clsSqlDataSynEN objSqlDataSynEN)
{
if (string.IsNullOrEmpty(objSqlDataSynEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlDataSynEN.TabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlDataSynEN>(objSqlDataSynEN);
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
 /// <param name = "objSqlDataSynEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSqlDataSynEN objSqlDataSynEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSqlDataSynEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlDataSynEN.TabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlDataSynEN.TabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlDataSynEN>(objSqlDataSynEN);
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
 /// <param name = "objSqlDataSynENS">源对象</param>
 /// <param name = "objSqlDataSynENT">目标对象</param>
 public static void CopyTo(clsSqlDataSynEN objSqlDataSynENS, clsSqlDataSynEN objSqlDataSynENT)
{
try
{
objSqlDataSynENT.TabId = objSqlDataSynENS.TabId; //表ID
objSqlDataSynENT.TabName = objSqlDataSynENS.TabName; //表名
objSqlDataSynENT.TabCnName = objSqlDataSynENS.TabCnName; //表中文名
objSqlDataSynENT.TabEnName = objSqlDataSynENS.TabEnName; //表英文详细名
objSqlDataSynENT.SqlData = objSqlDataSynENS.SqlData; //Sql表数据
objSqlDataSynENT.SqlCommandTypeId = objSqlDataSynENS.SqlCommandTypeId; //Sql命令类型Id
objSqlDataSynENT.SqlCommandText = objSqlDataSynENS.SqlCommandText; //Sql命令内容
objSqlDataSynENT.SqlDataRecNum = objSqlDataSynENS.SqlDataRecNum; //Sql数据记录数
objSqlDataSynENT.TargetTabCondition = objSqlDataSynENS.TargetTabCondition; //目标表有效记录条件
objSqlDataSynENT.TargetTabRecNum = objSqlDataSynENS.TargetTabRecNum; //目标表记录数
objSqlDataSynENT.DataSynDate = objSqlDataSynENS.DataSynDate; //数据同步日期
objSqlDataSynENT.PrimaryTypeId = objSqlDataSynENS.PrimaryTypeId; //主键类型ID
objSqlDataSynENT.RecExclusiveWayId = objSqlDataSynENS.RecExclusiveWayId; //记录排他方式Id
objSqlDataSynENT.TextResouce = objSqlDataSynENS.TextResouce; //文本来源
objSqlDataSynENT.TextResourceTypeId = objSqlDataSynENS.TextResourceTypeId; //文本来源类型Id
objSqlDataSynENT.AnalysisDate = objSqlDataSynENS.AnalysisDate; //分析日期
objSqlDataSynENT.PrjId = objSqlDataSynENS.PrjId; //工程Id
objSqlDataSynENT.ErrMsg = objSqlDataSynENS.ErrMsg; //错误信息
objSqlDataSynENT.UpdDate = objSqlDataSynENS.UpdDate; //修改日期
objSqlDataSynENT.UpdUserId = objSqlDataSynENS.UpdUserId; //修改用户Id
objSqlDataSynENT.Memo = objSqlDataSynENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsSqlDataSynEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSqlDataSynEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSqlDataSynEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSqlDataSynEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSqlDataSynEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSqlDataSynEN._AttributeName)
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
string strKey = string.Format("{0}", clsSqlDataSynEN._CurrTabName);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsSqlDataSynWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSqlDataSynEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSqlDataSynWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsSqlDataSynEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSqlDataSyn.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.TabName, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.TabEnName, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.SqlData, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.SqlCommandTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.SqlCommandText, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.SqlDataRecNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conSqlDataSyn.TargetTabCondition, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.TargetTabRecNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conSqlDataSyn.DataSynDate, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.RecExclusiveWayId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.TextResouce, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.TextResourceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.AnalysisDate, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlDataSyn.Memo, Type.GetType("System.String"));
foreach (clsSqlDataSynEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSqlDataSyn.TabId] = objInFor[conSqlDataSyn.TabId];
objDR[conSqlDataSyn.TabName] = objInFor[conSqlDataSyn.TabName];
objDR[conSqlDataSyn.TabCnName] = objInFor[conSqlDataSyn.TabCnName];
objDR[conSqlDataSyn.TabEnName] = objInFor[conSqlDataSyn.TabEnName];
objDR[conSqlDataSyn.SqlData] = objInFor[conSqlDataSyn.SqlData];
objDR[conSqlDataSyn.SqlCommandTypeId] = objInFor[conSqlDataSyn.SqlCommandTypeId];
objDR[conSqlDataSyn.SqlCommandText] = objInFor[conSqlDataSyn.SqlCommandText];
objDR[conSqlDataSyn.SqlDataRecNum] = objInFor[conSqlDataSyn.SqlDataRecNum];
objDR[conSqlDataSyn.TargetTabCondition] = objInFor[conSqlDataSyn.TargetTabCondition];
objDR[conSqlDataSyn.TargetTabRecNum] = objInFor[conSqlDataSyn.TargetTabRecNum];
objDR[conSqlDataSyn.DataSynDate] = objInFor[conSqlDataSyn.DataSynDate];
objDR[conSqlDataSyn.PrimaryTypeId] = objInFor[conSqlDataSyn.PrimaryTypeId];
objDR[conSqlDataSyn.RecExclusiveWayId] = objInFor[conSqlDataSyn.RecExclusiveWayId];
objDR[conSqlDataSyn.TextResouce] = objInFor[conSqlDataSyn.TextResouce];
objDR[conSqlDataSyn.TextResourceTypeId] = objInFor[conSqlDataSyn.TextResourceTypeId];
objDR[conSqlDataSyn.AnalysisDate] = objInFor[conSqlDataSyn.AnalysisDate];
objDR[conSqlDataSyn.PrjId] = objInFor[conSqlDataSyn.PrjId];
objDR[conSqlDataSyn.ErrMsg] = objInFor[conSqlDataSyn.ErrMsg];
objDR[conSqlDataSyn.UpdDate] = objInFor[conSqlDataSyn.UpdDate];
objDR[conSqlDataSyn.UpdUserId] = objInFor[conSqlDataSyn.UpdUserId];
objDR[conSqlDataSyn.Memo] = objInFor[conSqlDataSyn.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// Sql数据同步(SqlDataSyn)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4SqlDataSyn : clsCommFun4BL
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
clsSqlDataSynWApi.ReFreshThisCache();
}
}

}