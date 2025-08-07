
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewFldBL
 表名:vSqlViewFld(00050252)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvSqlViewFldBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlViewFldEN GetObj(this K_mId_vSqlViewFld myKey)
{
clsvSqlViewFldEN objvSqlViewFldEN = clsvSqlViewFldBL.vSqlViewFldDA.GetObjBymId(myKey.Value);
return objvSqlViewFldEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetSqlViewId(this clsvSqlViewFldEN objvSqlViewFldEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, convSqlViewFld.SqlViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convSqlViewFld.SqlViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convSqlViewFld.SqlViewId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetSqlViewName(this clsvSqlViewFldEN objvSqlViewFldEN, string strSqlViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewName, convSqlViewFld.SqlViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewName, 100, convSqlViewFld.SqlViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetSqlViewCNName(this clsvSqlViewFldEN objvSqlViewFldEN, string strSqlViewCNName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewCNName, 200, convSqlViewFld.SqlViewCNName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetRelaTabId(this clsvSqlViewFldEN objvSqlViewFldEN, string strRelaTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, convSqlViewFld.RelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, convSqlViewFld.RelaTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabId(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convSqlViewFld.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convSqlViewFld.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabName(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convSqlViewFld.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convSqlViewFld.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabCnName(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convSqlViewFld.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabAliases(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabAliases, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabAliases, 100, convSqlViewFld.TabAliases);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetTabRelationText(this clsvSqlViewFldEN objvSqlViewFldEN, string strTabRelationText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabRelationText, 500, convSqlViewFld.TabRelationText);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFldId(this clsvSqlViewFldEN objvSqlViewFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convSqlViewFld.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convSqlViewFld.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convSqlViewFld.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFldName(this clsvSqlViewFldEN objvSqlViewFldEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convSqlViewFld.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convSqlViewFld.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFldCnName(this clsvSqlViewFldEN objvSqlViewFldEN, string strFldCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convSqlViewFld.FldCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFldExpression(this clsvSqlViewFldEN objvSqlViewFldEN, string strFldExpression, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldExpression, 500, convSqlViewFld.FldExpression);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFieldAliases(this clsvSqlViewFldEN objvSqlViewFldEN, string strFieldAliases, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldAliases, 50, convSqlViewFld.FieldAliases);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetFilters(this clsvSqlViewFldEN objvSqlViewFldEN, string strFilters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilters, 50, convSqlViewFld.Filters);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetPrjId(this clsvSqlViewFldEN objvSqlViewFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlViewFld.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlViewFld.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlViewFld.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetUpdDate(this clsvSqlViewFldEN objvSqlViewFldEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlViewFld.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetUpdUserId(this clsvSqlViewFldEN objvSqlViewFldEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlViewFld.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetMemo(this clsvSqlViewFldEN objvSqlViewFldEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlViewFld.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewFldEN SetRelaTabId4SqlView(this clsvSqlViewFldEN objvSqlViewFldEN, string strRelaTabId4SqlView, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId4SqlView, 8, convSqlViewFld.RelaTabId4SqlView);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId4SqlView, 8, convSqlViewFld.RelaTabId4SqlView);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSqlViewFldENS">源对象</param>
 /// <param name = "objvSqlViewFldENT">目标对象</param>
 public static void CopyTo(this clsvSqlViewFldEN objvSqlViewFldENS, clsvSqlViewFldEN objvSqlViewFldENT)
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
 /// <param name = "objvSqlViewFldENS">源对象</param>
 /// <returns>目标对象=>clsvSqlViewFldEN:objvSqlViewFldENT</returns>
 public static clsvSqlViewFldEN CopyTo(this clsvSqlViewFldEN objvSqlViewFldENS)
{
try
{
 clsvSqlViewFldEN objvSqlViewFldENT = new clsvSqlViewFldEN()
{
mId = objvSqlViewFldENS.mId, //mId
SqlViewId = objvSqlViewFldENS.SqlViewId, //Sql视图Id
SqlViewName = objvSqlViewFldENS.SqlViewName, //数据视图名称
SqlViewCNName = objvSqlViewFldENS.SqlViewCNName, //Sql视图中文名
RelaTabId = objvSqlViewFldENS.RelaTabId, //相关表Id
TabId = objvSqlViewFldENS.TabId, //表ID
TabName = objvSqlViewFldENS.TabName, //表名
TabCnName = objvSqlViewFldENS.TabCnName, //表中文名
TabAliases = objvSqlViewFldENS.TabAliases, //表别名
TabRelationText = objvSqlViewFldENS.TabRelationText, //表关系文本
FldId = objvSqlViewFldENS.FldId, //字段Id
FldName = objvSqlViewFldENS.FldName, //字段名
FldCnName = objvSqlViewFldENS.FldCnName, //字段中文详名
FldExpression = objvSqlViewFldENS.FldExpression, //字段表达式
FieldAliases = objvSqlViewFldENS.FieldAliases, //字段别名
Filters = objvSqlViewFldENS.Filters, //筛选器
OrderNum = objvSqlViewFldENS.OrderNum, //序号
PrjId = objvSqlViewFldENS.PrjId, //工程Id
UpdDate = objvSqlViewFldENS.UpdDate, //修改日期
UpdUserId = objvSqlViewFldENS.UpdUserId, //修改用户Id
Memo = objvSqlViewFldENS.Memo, //说明
RelaTabId4SqlView = objvSqlViewFldENS.RelaTabId4SqlView, //RelaTabId4SqlView
};
 return objvSqlViewFldENT;
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
public static void CheckProperty4Condition(this clsvSqlViewFldEN objvSqlViewFldEN)
{
 clsvSqlViewFldBL.vSqlViewFldDA.CheckProperty4Condition(objvSqlViewFldEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSqlViewFld
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vSql视图字段(vSqlViewFld)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSqlViewFldBL
{
public static RelatedActions_vSqlViewFld relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSqlViewFldDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSqlViewFldDA vSqlViewFldDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSqlViewFldDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSqlViewFldBL()
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
if (string.IsNullOrEmpty(clsvSqlViewFldEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlViewFldEN._ConnectString);
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
public static DataTable GetDataTable_vSqlViewFld(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSqlViewFldDA.GetDataTable_vSqlViewFld(strWhereCond);
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
objDT = vSqlViewFldDA.GetDataTable(strWhereCond);
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
objDT = vSqlViewFldDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSqlViewFldDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSqlViewFldDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSqlViewFldDA.GetDataTable_Top(objTopPara);
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
objDT = vSqlViewFldDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSqlViewFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSqlViewFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvSqlViewFldEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
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
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSqlViewFldEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvSqlViewFldEN._CurrTabName, strPrjId);
List<clsvSqlViewFldEN> arrvSqlViewFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel =
arrvSqlViewFldObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvSqlViewFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewFldEN> GetObjLst(string strWhereCond)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
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
public static List<clsvSqlViewFldEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSqlViewFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSqlViewFldEN> GetSubObjLstCache(clsvSqlViewFldEN objvSqlViewFldCond)
{
 string strPrjId = objvSqlViewFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvSqlViewFldBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvSqlViewFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlViewFld._AttributeName)
{
if (objvSqlViewFldCond.IsUpdated(strFldName) == false) continue;
if (objvSqlViewFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewFldCond[strFldName].ToString());
}
else
{
if (objvSqlViewFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlViewFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlViewFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlViewFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlViewFldCond[strFldName]));
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
public static List<clsvSqlViewFldEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
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
public static List<clsvSqlViewFldEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
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
List<clsvSqlViewFldEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSqlViewFldEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewFldEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSqlViewFldEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
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
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
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
public static List<clsvSqlViewFldEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSqlViewFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSqlViewFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
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
public static List<clsvSqlViewFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewFldEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSqlViewFldEN> arrObjLst = new List<clsvSqlViewFldEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewFldEN objvSqlViewFldEN = new clsvSqlViewFldEN();
try
{
objvSqlViewFldEN.mId = Int32.Parse(objRow[convSqlViewFld.mId].ToString().Trim()); //mId
objvSqlViewFldEN.SqlViewId = objRow[convSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewFldEN.SqlViewName = objRow[convSqlViewFld.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewFldEN.SqlViewCNName = objRow[convSqlViewFld.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewFld.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewFldEN.RelaTabId = objRow[convSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewFldEN.TabId = objRow[convSqlViewFld.TabId] == DBNull.Value ? null : objRow[convSqlViewFld.TabId].ToString().Trim(); //表ID
objvSqlViewFldEN.TabName = objRow[convSqlViewFld.TabName].ToString().Trim(); //表名
objvSqlViewFldEN.TabCnName = objRow[convSqlViewFld.TabCnName] == DBNull.Value ? null : objRow[convSqlViewFld.TabCnName].ToString().Trim(); //表中文名
objvSqlViewFldEN.TabAliases = objRow[convSqlViewFld.TabAliases] == DBNull.Value ? null : objRow[convSqlViewFld.TabAliases].ToString().Trim(); //表别名
objvSqlViewFldEN.TabRelationText = objRow[convSqlViewFld.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewFld.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewFldEN.FldId = objRow[convSqlViewFld.FldId].ToString().Trim(); //字段Id
objvSqlViewFldEN.FldName = objRow[convSqlViewFld.FldName].ToString().Trim(); //字段名
objvSqlViewFldEN.FldCnName = objRow[convSqlViewFld.FldCnName] == DBNull.Value ? null : objRow[convSqlViewFld.FldCnName].ToString().Trim(); //字段中文详名
objvSqlViewFldEN.FldExpression = objRow[convSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[convSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objvSqlViewFldEN.FieldAliases = objRow[convSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[convSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objvSqlViewFldEN.Filters = objRow[convSqlViewFld.Filters] == DBNull.Value ? null : objRow[convSqlViewFld.Filters].ToString().Trim(); //筛选器
objvSqlViewFldEN.OrderNum = Int32.Parse(objRow[convSqlViewFld.OrderNum].ToString().Trim()); //序号
objvSqlViewFldEN.PrjId = objRow[convSqlViewFld.PrjId].ToString().Trim(); //工程Id
objvSqlViewFldEN.UpdDate = objRow[convSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[convSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objvSqlViewFldEN.UpdUserId = objRow[convSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewFldEN.Memo = objRow[convSqlViewFld.Memo] == DBNull.Value ? null : objRow[convSqlViewFld.Memo].ToString().Trim(); //说明
objvSqlViewFldEN.RelaTabId4SqlView = objRow[convSqlViewFld.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewFld.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewFldEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSqlViewFldEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSqlViewFld(ref clsvSqlViewFldEN objvSqlViewFldEN)
{
bool bolResult = vSqlViewFldDA.GetvSqlViewFld(ref objvSqlViewFldEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlViewFldEN GetObjBymId(long lngmId)
{
clsvSqlViewFldEN objvSqlViewFldEN = vSqlViewFldDA.GetObjBymId(lngmId);
return objvSqlViewFldEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSqlViewFldEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSqlViewFldEN objvSqlViewFldEN = vSqlViewFldDA.GetFirstObj(strWhereCond);
 return objvSqlViewFldEN;
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
public static clsvSqlViewFldEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSqlViewFldEN objvSqlViewFldEN = vSqlViewFldDA.GetObjByDataRow(objRow);
 return objvSqlViewFldEN;
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
public static clsvSqlViewFldEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSqlViewFldEN objvSqlViewFldEN = vSqlViewFldDA.GetObjByDataRow(objRow);
 return objvSqlViewFldEN;
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
 /// <param name = "lstvSqlViewFldObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlViewFldEN GetObjBymIdFromList(long lngmId, List<clsvSqlViewFldEN> lstvSqlViewFldObjLst)
{
foreach (clsvSqlViewFldEN objvSqlViewFldEN in lstvSqlViewFldObjLst)
{
if (objvSqlViewFldEN.mId == lngmId)
{
return objvSqlViewFldEN;
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
 lngmId = new clsvSqlViewFldDA().GetFirstID(strWhereCond);
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
 arrList = vSqlViewFldDA.GetID(strWhereCond);
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
bool bolIsExist = vSqlViewFldDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vSqlViewFldDA.IsExist(lngmId);
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
 bolIsExist = clsvSqlViewFldDA.IsExistTable();
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
 bolIsExist = vSqlViewFldDA.IsExistTable(strTabName);
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
 /// <param name = "objvSqlViewFldEN">源简化对象</param>
 public static void SetUpdFlag(clsvSqlViewFldEN objvSqlViewFldEN)
{
try
{
objvSqlViewFldEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSqlViewFldEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSqlViewFld.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.mId = objvSqlViewFldEN.mId; //mId
}
if (arrFldSet.Contains(convSqlViewFld.SqlViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.SqlViewId = objvSqlViewFldEN.SqlViewId; //Sql视图Id
}
if (arrFldSet.Contains(convSqlViewFld.SqlViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.SqlViewName = objvSqlViewFldEN.SqlViewName; //数据视图名称
}
if (arrFldSet.Contains(convSqlViewFld.SqlViewCNName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.SqlViewCNName = objvSqlViewFldEN.SqlViewCNName == "[null]" ? null :  objvSqlViewFldEN.SqlViewCNName; //Sql视图中文名
}
if (arrFldSet.Contains(convSqlViewFld.RelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.RelaTabId = objvSqlViewFldEN.RelaTabId == "[null]" ? null :  objvSqlViewFldEN.RelaTabId; //相关表Id
}
if (arrFldSet.Contains(convSqlViewFld.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.TabId = objvSqlViewFldEN.TabId == "[null]" ? null :  objvSqlViewFldEN.TabId; //表ID
}
if (arrFldSet.Contains(convSqlViewFld.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.TabName = objvSqlViewFldEN.TabName; //表名
}
if (arrFldSet.Contains(convSqlViewFld.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.TabCnName = objvSqlViewFldEN.TabCnName == "[null]" ? null :  objvSqlViewFldEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convSqlViewFld.TabAliases, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.TabAliases = objvSqlViewFldEN.TabAliases == "[null]" ? null :  objvSqlViewFldEN.TabAliases; //表别名
}
if (arrFldSet.Contains(convSqlViewFld.TabRelationText, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.TabRelationText = objvSqlViewFldEN.TabRelationText == "[null]" ? null :  objvSqlViewFldEN.TabRelationText; //表关系文本
}
if (arrFldSet.Contains(convSqlViewFld.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.FldId = objvSqlViewFldEN.FldId; //字段Id
}
if (arrFldSet.Contains(convSqlViewFld.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.FldName = objvSqlViewFldEN.FldName; //字段名
}
if (arrFldSet.Contains(convSqlViewFld.FldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.FldCnName = objvSqlViewFldEN.FldCnName == "[null]" ? null :  objvSqlViewFldEN.FldCnName; //字段中文详名
}
if (arrFldSet.Contains(convSqlViewFld.FldExpression, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.FldExpression = objvSqlViewFldEN.FldExpression == "[null]" ? null :  objvSqlViewFldEN.FldExpression; //字段表达式
}
if (arrFldSet.Contains(convSqlViewFld.FieldAliases, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.FieldAliases = objvSqlViewFldEN.FieldAliases == "[null]" ? null :  objvSqlViewFldEN.FieldAliases; //字段别名
}
if (arrFldSet.Contains(convSqlViewFld.Filters, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.Filters = objvSqlViewFldEN.Filters == "[null]" ? null :  objvSqlViewFldEN.Filters; //筛选器
}
if (arrFldSet.Contains(convSqlViewFld.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.OrderNum = objvSqlViewFldEN.OrderNum; //序号
}
if (arrFldSet.Contains(convSqlViewFld.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.PrjId = objvSqlViewFldEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convSqlViewFld.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.UpdDate = objvSqlViewFldEN.UpdDate == "[null]" ? null :  objvSqlViewFldEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSqlViewFld.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.UpdUserId = objvSqlViewFldEN.UpdUserId == "[null]" ? null :  objvSqlViewFldEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convSqlViewFld.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.Memo = objvSqlViewFldEN.Memo == "[null]" ? null :  objvSqlViewFldEN.Memo; //说明
}
if (arrFldSet.Contains(convSqlViewFld.RelaTabId4SqlView, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewFldEN.RelaTabId4SqlView = objvSqlViewFldEN.RelaTabId4SqlView == "[null]" ? null :  objvSqlViewFldEN.RelaTabId4SqlView; //RelaTabId4SqlView
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
 /// <param name = "objvSqlViewFldEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSqlViewFldEN objvSqlViewFldEN)
{
try
{
if (objvSqlViewFldEN.SqlViewCNName == "[null]") objvSqlViewFldEN.SqlViewCNName = null; //Sql视图中文名
if (objvSqlViewFldEN.RelaTabId == "[null]") objvSqlViewFldEN.RelaTabId = null; //相关表Id
if (objvSqlViewFldEN.TabId == "[null]") objvSqlViewFldEN.TabId = null; //表ID
if (objvSqlViewFldEN.TabCnName == "[null]") objvSqlViewFldEN.TabCnName = null; //表中文名
if (objvSqlViewFldEN.TabAliases == "[null]") objvSqlViewFldEN.TabAliases = null; //表别名
if (objvSqlViewFldEN.TabRelationText == "[null]") objvSqlViewFldEN.TabRelationText = null; //表关系文本
if (objvSqlViewFldEN.FldCnName == "[null]") objvSqlViewFldEN.FldCnName = null; //字段中文详名
if (objvSqlViewFldEN.FldExpression == "[null]") objvSqlViewFldEN.FldExpression = null; //字段表达式
if (objvSqlViewFldEN.FieldAliases == "[null]") objvSqlViewFldEN.FieldAliases = null; //字段别名
if (objvSqlViewFldEN.Filters == "[null]") objvSqlViewFldEN.Filters = null; //筛选器
if (objvSqlViewFldEN.UpdDate == "[null]") objvSqlViewFldEN.UpdDate = null; //修改日期
if (objvSqlViewFldEN.UpdUserId == "[null]") objvSqlViewFldEN.UpdUserId = null; //修改用户Id
if (objvSqlViewFldEN.Memo == "[null]") objvSqlViewFldEN.Memo = null; //说明
if (objvSqlViewFldEN.RelaTabId4SqlView == "[null]") objvSqlViewFldEN.RelaTabId4SqlView = null; //RelaTabId4SqlView
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
public static void CheckProperty4Condition(clsvSqlViewFldEN objvSqlViewFldEN)
{
 vSqlViewFldDA.CheckProperty4Condition(objvSqlViewFldEN);
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
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSqlViewFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlViewFldBL没有刷新缓存机制(clsSqlViewFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvSqlViewFldObjLstCache == null)
//{
//arrvSqlViewFldObjLstCache = vSqlViewFldDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlViewFldEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvSqlViewFldEN._CurrTabName, strPrjId);
List<clsvSqlViewFldEN> arrvSqlViewFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewFldEN> arrvSqlViewFldObjLst_Sel =
arrvSqlViewFldObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvSqlViewFldObjLst_Sel.Count() == 0)
{
   clsvSqlViewFldEN obj = clsvSqlViewFldBL.GetObjBymId(lngmId);
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
return arrvSqlViewFldObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlViewFldEN> GetAllvSqlViewFldObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvSqlViewFldEN> arrvSqlViewFldObjLstCache = GetObjLstCache(strPrjId); 
return arrvSqlViewFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlViewFldEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvSqlViewFldEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvSqlViewFldEN> arrvSqlViewFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvSqlViewFldObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvSqlViewFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvSqlViewFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvSqlViewFldEN._RefreshTimeLst.Count == 0) return "";
return clsvSqlViewFldEN._RefreshTimeLst[clsvSqlViewFldEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convSqlViewFld.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSqlViewFld._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSqlViewFld._AttributeName));
throw new Exception(strMsg);
}
var objvSqlViewFld = clsvSqlViewFldBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvSqlViewFld == null) return "";
return objvSqlViewFld[strOutFldName].ToString();
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
int intRecCount = clsvSqlViewFldDA.GetRecCount(strTabName);
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
int intRecCount = clsvSqlViewFldDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSqlViewFldDA.GetRecCount();
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
int intRecCount = clsvSqlViewFldDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSqlViewFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSqlViewFldEN objvSqlViewFldCond)
{
 string strPrjId = objvSqlViewFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvSqlViewFldBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvSqlViewFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlViewFld._AttributeName)
{
if (objvSqlViewFldCond.IsUpdated(strFldName) == false) continue;
if (objvSqlViewFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewFldCond[strFldName].ToString());
}
else
{
if (objvSqlViewFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlViewFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlViewFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlViewFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlViewFldCond[strFldName]));
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
 List<string> arrList = clsvSqlViewFldDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSqlViewFldDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSqlViewFldDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}