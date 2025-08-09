
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeTypeBL
 表名:vCodeType(00050410)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:39
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvCodeTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCodeTypeEN GetObj(this K_CodeTypeId_vCodeType myKey)
{
clsvCodeTypeEN objvCodeTypeEN = clsvCodeTypeBL.vCodeTypeDA.GetObjByCodeTypeId(myKey.Value);
return objvCodeTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetCodeTypeId(this clsvCodeTypeEN objvCodeTypeEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCodeType.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCodeType.CodeTypeId);
}
objvCodeTypeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.CodeTypeId) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.CodeTypeId, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.CodeTypeId] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetCodeTypeName(this clsvCodeTypeEN objvCodeTypeEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convCodeType.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convCodeType.CodeTypeName);
}
objvCodeTypeEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.CodeTypeName) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.CodeTypeName, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.CodeTypeName] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetCodeTypeSimName(this clsvCodeTypeEN objvCodeTypeEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, convCodeType.CodeTypeSimName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convCodeType.CodeTypeSimName);
}
objvCodeTypeEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.CodeTypeSimName) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.CodeTypeSimName, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.CodeTypeSimName] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetCodeTypeENName(this clsvCodeTypeEN objvCodeTypeEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convCodeType.CodeTypeENName);
}
objvCodeTypeEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.CodeTypeENName) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.CodeTypeENName, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.CodeTypeENName] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetGroupName(this clsvCodeTypeEN objvCodeTypeEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convCodeType.GroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, convCodeType.GroupName);
}
objvCodeTypeEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.GroupName) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.GroupName, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.GroupName] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetProgLangTypeId(this clsvCodeTypeEN objvCodeTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCodeType.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCodeType.ProgLangTypeId);
}
objvCodeTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.ProgLangTypeId) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.ProgLangTypeId, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.ProgLangTypeId] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetProgLangTypeName(this clsvCodeTypeEN objvCodeTypeEN, string strProgLangTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convCodeType.ProgLangTypeName);
}
objvCodeTypeEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.ProgLangTypeName) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.ProgLangTypeName, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.ProgLangTypeName] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetProgLangTypeSimName(this clsvCodeTypeEN objvCodeTypeEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convCodeType.ProgLangTypeSimName);
}
objvCodeTypeEN.ProgLangTypeSimName = strProgLangTypeSimName; //编程语言类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.ProgLangTypeSimName) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.ProgLangTypeSimName, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.ProgLangTypeSimName] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetRegionTypeId(this clsvCodeTypeEN objvCodeTypeEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convCodeType.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convCodeType.RegionTypeId);
}
objvCodeTypeEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.RegionTypeId) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.RegionTypeId, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.RegionTypeId] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetRegionTypeName(this clsvCodeTypeEN objvCodeTypeEN, string strRegionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convCodeType.RegionTypeName);
}
objvCodeTypeEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.RegionTypeName) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.RegionTypeName, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.RegionTypeName] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetPrefix(this clsvCodeTypeEN objvCodeTypeEN, string strPrefix, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefix, 10, convCodeType.Prefix);
}
objvCodeTypeEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.Prefix) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.Prefix, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.Prefix] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetDependsOn(this clsvCodeTypeEN objvCodeTypeEN, string strDependsOn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDependsOn, 50, convCodeType.DependsOn);
}
objvCodeTypeEN.DependsOn = strDependsOn; //依赖于
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.DependsOn) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.DependsOn, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.DependsOn] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetFrontOrBack(this clsvCodeTypeEN objvCodeTypeEN, string strFrontOrBack, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFrontOrBack, 50, convCodeType.FrontOrBack);
}
objvCodeTypeEN.FrontOrBack = strFrontOrBack; //前台Or后台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.FrontOrBack) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.FrontOrBack, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.FrontOrBack] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetSqlDsTypeId(this clsvCodeTypeEN objvCodeTypeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convCodeType.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convCodeType.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convCodeType.SqlDsTypeId);
}
objvCodeTypeEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.SqlDsTypeId) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.SqlDsTypeId, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.SqlDsTypeId] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetSqlDsTypeName(this clsvCodeTypeEN objvCodeTypeEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convCodeType.SqlDsTypeName);
}
objvCodeTypeEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.SqlDsTypeName) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.SqlDsTypeName, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.SqlDsTypeName] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetClassNameFormat(this clsvCodeTypeEN objvCodeTypeEN, string strClassNameFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassNameFormat, 50, convCodeType.ClassNameFormat);
}
objvCodeTypeEN.ClassNameFormat = strClassNameFormat; //类名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.ClassNameFormat) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.ClassNameFormat, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.ClassNameFormat] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsCSharp(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsCSharp, string strComparisonOp="")
	{
objvCodeTypeEN.IsCSharp = bolIsCSharp; //是否CSharp语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsCSharp) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsCSharp, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsCSharp] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsJava(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsJava, string strComparisonOp="")
	{
objvCodeTypeEN.IsJava = bolIsJava; //是否Java语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsJava) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsJava, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsJava] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsJavaScript(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsJavaScript, string strComparisonOp="")
	{
objvCodeTypeEN.IsJavaScript = bolIsJavaScript; //是否JavaScript语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsJavaScript) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsJavaScript, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsJavaScript] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsTypeScript(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsTypeScript, string strComparisonOp="")
	{
objvCodeTypeEN.IsTypeScript = bolIsTypeScript; //是否TypeScript语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsTypeScript) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsTypeScript, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsTypeScript] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsSilverLight(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsSilverLight, string strComparisonOp="")
	{
objvCodeTypeEN.IsSilverLight = bolIsSilverLight; //是否SilverLight语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsSilverLight) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsSilverLight, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsSilverLight] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsSwift(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsSwift, string strComparisonOp="")
	{
objvCodeTypeEN.IsSwift = bolIsSwift; //是否Swift语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsSwift) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsSwift, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsSwift] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsVB(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsVB, string strComparisonOp="")
	{
objvCodeTypeEN.IsVB = bolIsVB; //IsVB语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsVB) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsVB, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsVB] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsTableFldConst(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsTableFldConst, string strComparisonOp="")
	{
objvCodeTypeEN.IsTableFldConst = bolIsTableFldConst; //IsTableFldConst
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsTableFldConst) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsTableFldConst, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsTableFldConst] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsPubApp4WinWeb(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsPubApp4WinWeb, string strComparisonOp="")
	{
objvCodeTypeEN.IsPubApp4WinWeb = bolIsPubApp4WinWeb; //IsPubApp4WinWeb
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsPubApp4WinWeb) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsPubApp4WinWeb, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsPubApp4WinWeb] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsWeb(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsWeb, string strComparisonOp="")
	{
objvCodeTypeEN.IsWeb = bolIsWeb; //是否Web应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsWeb) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsWeb, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsWeb] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsAspMvc(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsAspMvc, string strComparisonOp="")
	{
objvCodeTypeEN.IsAspMvc = bolIsAspMvc; //是否AspMvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsAspMvc) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsAspMvc, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsAspMvc] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsWebSrvAccess(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsWebSrvAccess, string strComparisonOp="")
	{
objvCodeTypeEN.IsWebSrvAccess = bolIsWebSrvAccess; //IsWebSrvAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsWebSrvAccess) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsWebSrvAccess, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsWebSrvAccess] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsWin(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsWin, string strComparisonOp="")
	{
objvCodeTypeEN.IsWin = bolIsWin; //是否Win应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsWin) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsWin, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsWin] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsMobileApp(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsMobileApp, string strComparisonOp="")
	{
objvCodeTypeEN.IsMobileApp = bolIsMobileApp; //是否移动终端应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsMobileApp) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsMobileApp, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsMobileApp] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetOrderNum(this clsvCodeTypeEN objvCodeTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCodeType.OrderNum);
objvCodeTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.OrderNum) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.OrderNum, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.OrderNum] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetWinOrWeb(this clsvCodeTypeEN objvCodeTypeEN, string strWinOrWeb, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWinOrWeb, 50, convCodeType.WinOrWeb);
}
objvCodeTypeEN.WinOrWeb = strWinOrWeb; //WinOrWeb
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.WinOrWeb) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.WinOrWeb, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.WinOrWeb] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsDirByTabName(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsDirByTabName, string strComparisonOp="")
	{
objvCodeTypeEN.IsDirByTabName = bolIsDirByTabName; //是否用表名作为路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsDirByTabName) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsDirByTabName, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsDirByTabName] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetInUse(this clsvCodeTypeEN objvCodeTypeEN, bool bolInUse, string strComparisonOp="")
	{
objvCodeTypeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.InUse) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.InUse, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.InUse] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetIsDefaultOverride(this clsvCodeTypeEN objvCodeTypeEN, bool bolIsDefaultOverride, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultOverride, convCodeType.IsDefaultOverride);
objvCodeTypeEN.IsDefaultOverride = bolIsDefaultOverride; //是否默认覆盖
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.IsDefaultOverride) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.IsDefaultOverride, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.IsDefaultOverride] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetUpdDate(this clsvCodeTypeEN objvCodeTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCodeType.UpdDate);
}
objvCodeTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.UpdDate) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.UpdDate, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.UpdDate] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetUpdUser(this clsvCodeTypeEN objvCodeTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCodeType.UpdUser);
}
objvCodeTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.UpdUser) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.UpdUser, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.UpdUser] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetMemo(this clsvCodeTypeEN objvCodeTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCodeType.Memo);
}
objvCodeTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.Memo) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.Memo, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.Memo] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetFuncCount(this clsvCodeTypeEN objvCodeTypeEN, int? intFuncCount, string strComparisonOp="")
	{
objvCodeTypeEN.FuncCount = intFuncCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.FuncCount) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.FuncCount, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.FuncCount] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetAppCount(this clsvCodeTypeEN objvCodeTypeEN, int? intAppCount, string strComparisonOp="")
	{
objvCodeTypeEN.AppCount = intAppCount; //应用数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeTypeEN.dicFldComparisonOp.ContainsKey(convCodeType.AppCount) == false)
{
objvCodeTypeEN.dicFldComparisonOp.Add(convCodeType.AppCount, strComparisonOp);
}
else
{
objvCodeTypeEN.dicFldComparisonOp[convCodeType.AppCount] = strComparisonOp;
}
}
return objvCodeTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCodeTypeENS">源对象</param>
 /// <param name = "objvCodeTypeENT">目标对象</param>
 public static void CopyTo(this clsvCodeTypeEN objvCodeTypeENS, clsvCodeTypeEN objvCodeTypeENT)
{
try
{
objvCodeTypeENT.CodeTypeId = objvCodeTypeENS.CodeTypeId; //代码类型Id
objvCodeTypeENT.CodeTypeName = objvCodeTypeENS.CodeTypeName; //代码类型名
objvCodeTypeENT.CodeTypeSimName = objvCodeTypeENS.CodeTypeSimName; //简称
objvCodeTypeENT.CodeTypeENName = objvCodeTypeENS.CodeTypeENName; //代码类型英文名
objvCodeTypeENT.GroupName = objvCodeTypeENS.GroupName; //组名
objvCodeTypeENT.ProgLangTypeId = objvCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objvCodeTypeENT.ProgLangTypeName = objvCodeTypeENS.ProgLangTypeName; //编程语言类型名
objvCodeTypeENT.ProgLangTypeSimName = objvCodeTypeENS.ProgLangTypeSimName; //编程语言类型简称
objvCodeTypeENT.RegionTypeId = objvCodeTypeENS.RegionTypeId; //区域类型Id
objvCodeTypeENT.RegionTypeName = objvCodeTypeENS.RegionTypeName; //区域类型名称
objvCodeTypeENT.Prefix = objvCodeTypeENS.Prefix; //前缀
objvCodeTypeENT.DependsOn = objvCodeTypeENS.DependsOn; //依赖于
objvCodeTypeENT.FrontOrBack = objvCodeTypeENS.FrontOrBack; //前台Or后台
objvCodeTypeENT.SqlDsTypeId = objvCodeTypeENS.SqlDsTypeId; //数据源类型Id
objvCodeTypeENT.SqlDsTypeName = objvCodeTypeENS.SqlDsTypeName; //Sql数据源名
objvCodeTypeENT.ClassNameFormat = objvCodeTypeENS.ClassNameFormat; //类名格式
objvCodeTypeENT.IsCSharp = objvCodeTypeENS.IsCSharp; //是否CSharp语言
objvCodeTypeENT.IsJava = objvCodeTypeENS.IsJava; //是否Java语言
objvCodeTypeENT.IsJavaScript = objvCodeTypeENS.IsJavaScript; //是否JavaScript语言
objvCodeTypeENT.IsTypeScript = objvCodeTypeENS.IsTypeScript; //是否TypeScript语言
objvCodeTypeENT.IsSilverLight = objvCodeTypeENS.IsSilverLight; //是否SilverLight语言
objvCodeTypeENT.IsSwift = objvCodeTypeENS.IsSwift; //是否Swift语言
objvCodeTypeENT.IsVB = objvCodeTypeENS.IsVB; //IsVB语言
objvCodeTypeENT.IsTableFldConst = objvCodeTypeENS.IsTableFldConst; //IsTableFldConst
objvCodeTypeENT.IsPubApp4WinWeb = objvCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objvCodeTypeENT.IsWeb = objvCodeTypeENS.IsWeb; //是否Web应用
objvCodeTypeENT.IsAspMvc = objvCodeTypeENS.IsAspMvc; //是否AspMvc
objvCodeTypeENT.IsWebSrvAccess = objvCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objvCodeTypeENT.IsWin = objvCodeTypeENS.IsWin; //是否Win应用
objvCodeTypeENT.IsMobileApp = objvCodeTypeENS.IsMobileApp; //是否移动终端应用
objvCodeTypeENT.OrderNum = objvCodeTypeENS.OrderNum; //序号
objvCodeTypeENT.WinOrWeb = objvCodeTypeENS.WinOrWeb; //WinOrWeb
objvCodeTypeENT.IsDirByTabName = objvCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objvCodeTypeENT.InUse = objvCodeTypeENS.InUse; //是否在用
objvCodeTypeENT.IsDefaultOverride = objvCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objvCodeTypeENT.UpdDate = objvCodeTypeENS.UpdDate; //修改日期
objvCodeTypeENT.UpdUser = objvCodeTypeENS.UpdUser; //修改者
objvCodeTypeENT.Memo = objvCodeTypeENS.Memo; //说明
objvCodeTypeENT.FuncCount = objvCodeTypeENS.FuncCount; //函数数目
objvCodeTypeENT.AppCount = objvCodeTypeENS.AppCount; //应用数
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
 /// <param name = "objvCodeTypeENS">源对象</param>
 /// <returns>目标对象=>clsvCodeTypeEN:objvCodeTypeENT</returns>
 public static clsvCodeTypeEN CopyTo(this clsvCodeTypeEN objvCodeTypeENS)
{
try
{
 clsvCodeTypeEN objvCodeTypeENT = new clsvCodeTypeEN()
{
CodeTypeId = objvCodeTypeENS.CodeTypeId, //代码类型Id
CodeTypeName = objvCodeTypeENS.CodeTypeName, //代码类型名
CodeTypeSimName = objvCodeTypeENS.CodeTypeSimName, //简称
CodeTypeENName = objvCodeTypeENS.CodeTypeENName, //代码类型英文名
GroupName = objvCodeTypeENS.GroupName, //组名
ProgLangTypeId = objvCodeTypeENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvCodeTypeENS.ProgLangTypeName, //编程语言类型名
ProgLangTypeSimName = objvCodeTypeENS.ProgLangTypeSimName, //编程语言类型简称
RegionTypeId = objvCodeTypeENS.RegionTypeId, //区域类型Id
RegionTypeName = objvCodeTypeENS.RegionTypeName, //区域类型名称
Prefix = objvCodeTypeENS.Prefix, //前缀
DependsOn = objvCodeTypeENS.DependsOn, //依赖于
FrontOrBack = objvCodeTypeENS.FrontOrBack, //前台Or后台
SqlDsTypeId = objvCodeTypeENS.SqlDsTypeId, //数据源类型Id
SqlDsTypeName = objvCodeTypeENS.SqlDsTypeName, //Sql数据源名
ClassNameFormat = objvCodeTypeENS.ClassNameFormat, //类名格式
IsCSharp = objvCodeTypeENS.IsCSharp, //是否CSharp语言
IsJava = objvCodeTypeENS.IsJava, //是否Java语言
IsJavaScript = objvCodeTypeENS.IsJavaScript, //是否JavaScript语言
IsTypeScript = objvCodeTypeENS.IsTypeScript, //是否TypeScript语言
IsSilverLight = objvCodeTypeENS.IsSilverLight, //是否SilverLight语言
IsSwift = objvCodeTypeENS.IsSwift, //是否Swift语言
IsVB = objvCodeTypeENS.IsVB, //IsVB语言
IsTableFldConst = objvCodeTypeENS.IsTableFldConst, //IsTableFldConst
IsPubApp4WinWeb = objvCodeTypeENS.IsPubApp4WinWeb, //IsPubApp4WinWeb
IsWeb = objvCodeTypeENS.IsWeb, //是否Web应用
IsAspMvc = objvCodeTypeENS.IsAspMvc, //是否AspMvc
IsWebSrvAccess = objvCodeTypeENS.IsWebSrvAccess, //IsWebSrvAccess
IsWin = objvCodeTypeENS.IsWin, //是否Win应用
IsMobileApp = objvCodeTypeENS.IsMobileApp, //是否移动终端应用
OrderNum = objvCodeTypeENS.OrderNum, //序号
WinOrWeb = objvCodeTypeENS.WinOrWeb, //WinOrWeb
IsDirByTabName = objvCodeTypeENS.IsDirByTabName, //是否用表名作为路径
InUse = objvCodeTypeENS.InUse, //是否在用
IsDefaultOverride = objvCodeTypeENS.IsDefaultOverride, //是否默认覆盖
UpdDate = objvCodeTypeENS.UpdDate, //修改日期
UpdUser = objvCodeTypeENS.UpdUser, //修改者
Memo = objvCodeTypeENS.Memo, //说明
FuncCount = objvCodeTypeENS.FuncCount, //函数数目
AppCount = objvCodeTypeENS.AppCount, //应用数
};
 return objvCodeTypeENT;
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
public static void CheckProperty4Condition(this clsvCodeTypeEN objvCodeTypeEN)
{
 clsvCodeTypeBL.vCodeTypeDA.CheckProperty4Condition(objvCodeTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCodeTypeEN objvCodeTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCodeTypeCond.IsUpdated(convCodeType.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvCodeTypeCond.dicFldComparisonOp[convCodeType.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.CodeTypeId, objvCodeTypeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvCodeTypeCond.dicFldComparisonOp[convCodeType.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.CodeTypeName, objvCodeTypeCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.CodeTypeSimName) == true)
{
string strComparisonOpCodeTypeSimName = objvCodeTypeCond.dicFldComparisonOp[convCodeType.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.CodeTypeSimName, objvCodeTypeCond.CodeTypeSimName, strComparisonOpCodeTypeSimName);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvCodeTypeCond.dicFldComparisonOp[convCodeType.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.CodeTypeENName, objvCodeTypeCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.GroupName) == true)
{
string strComparisonOpGroupName = objvCodeTypeCond.dicFldComparisonOp[convCodeType.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.GroupName, objvCodeTypeCond.GroupName, strComparisonOpGroupName);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvCodeTypeCond.dicFldComparisonOp[convCodeType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.ProgLangTypeId, objvCodeTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvCodeTypeCond.dicFldComparisonOp[convCodeType.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.ProgLangTypeName, objvCodeTypeCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.ProgLangTypeSimName) == true)
{
string strComparisonOpProgLangTypeSimName = objvCodeTypeCond.dicFldComparisonOp[convCodeType.ProgLangTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.ProgLangTypeSimName, objvCodeTypeCond.ProgLangTypeSimName, strComparisonOpProgLangTypeSimName);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvCodeTypeCond.dicFldComparisonOp[convCodeType.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.RegionTypeId, objvCodeTypeCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvCodeTypeCond.dicFldComparisonOp[convCodeType.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.RegionTypeName, objvCodeTypeCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.Prefix) == true)
{
string strComparisonOpPrefix = objvCodeTypeCond.dicFldComparisonOp[convCodeType.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.Prefix, objvCodeTypeCond.Prefix, strComparisonOpPrefix);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.DependsOn) == true)
{
string strComparisonOpDependsOn = objvCodeTypeCond.dicFldComparisonOp[convCodeType.DependsOn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.DependsOn, objvCodeTypeCond.DependsOn, strComparisonOpDependsOn);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.FrontOrBack) == true)
{
string strComparisonOpFrontOrBack = objvCodeTypeCond.dicFldComparisonOp[convCodeType.FrontOrBack];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.FrontOrBack, objvCodeTypeCond.FrontOrBack, strComparisonOpFrontOrBack);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvCodeTypeCond.dicFldComparisonOp[convCodeType.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.SqlDsTypeId, objvCodeTypeCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvCodeTypeCond.dicFldComparisonOp[convCodeType.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.SqlDsTypeName, objvCodeTypeCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.ClassNameFormat) == true)
{
string strComparisonOpClassNameFormat = objvCodeTypeCond.dicFldComparisonOp[convCodeType.ClassNameFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.ClassNameFormat, objvCodeTypeCond.ClassNameFormat, strComparisonOpClassNameFormat);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsCSharp) == true)
{
if (objvCodeTypeCond.IsCSharp == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsCSharp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsCSharp);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsJava) == true)
{
if (objvCodeTypeCond.IsJava == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsJava);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsJava);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsJavaScript) == true)
{
if (objvCodeTypeCond.IsJavaScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsJavaScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsJavaScript);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsTypeScript) == true)
{
if (objvCodeTypeCond.IsTypeScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsTypeScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsTypeScript);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsSilverLight) == true)
{
if (objvCodeTypeCond.IsSilverLight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsSilverLight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsSilverLight);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsSwift) == true)
{
if (objvCodeTypeCond.IsSwift == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsSwift);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsSwift);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsVB) == true)
{
if (objvCodeTypeCond.IsVB == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsVB);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsVB);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsTableFldConst) == true)
{
if (objvCodeTypeCond.IsTableFldConst == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsTableFldConst);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsTableFldConst);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsPubApp4WinWeb) == true)
{
if (objvCodeTypeCond.IsPubApp4WinWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsPubApp4WinWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsPubApp4WinWeb);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsWeb) == true)
{
if (objvCodeTypeCond.IsWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsWeb);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsAspMvc) == true)
{
if (objvCodeTypeCond.IsAspMvc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsAspMvc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsAspMvc);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsWebSrvAccess) == true)
{
if (objvCodeTypeCond.IsWebSrvAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsWebSrvAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsWebSrvAccess);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsWin) == true)
{
if (objvCodeTypeCond.IsWin == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsWin);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsWin);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsMobileApp) == true)
{
if (objvCodeTypeCond.IsMobileApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsMobileApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsMobileApp);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCodeTypeCond.dicFldComparisonOp[convCodeType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCodeType.OrderNum, objvCodeTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.WinOrWeb) == true)
{
string strComparisonOpWinOrWeb = objvCodeTypeCond.dicFldComparisonOp[convCodeType.WinOrWeb];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.WinOrWeb, objvCodeTypeCond.WinOrWeb, strComparisonOpWinOrWeb);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsDirByTabName) == true)
{
if (objvCodeTypeCond.IsDirByTabName == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsDirByTabName);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsDirByTabName);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.InUse) == true)
{
if (objvCodeTypeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.InUse);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.IsDefaultOverride) == true)
{
if (objvCodeTypeCond.IsDefaultOverride == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType.IsDefaultOverride);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType.IsDefaultOverride);
}
}
if (objvCodeTypeCond.IsUpdated(convCodeType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCodeTypeCond.dicFldComparisonOp[convCodeType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.UpdDate, objvCodeTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCodeTypeCond.dicFldComparisonOp[convCodeType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.UpdUser, objvCodeTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.Memo) == true)
{
string strComparisonOpMemo = objvCodeTypeCond.dicFldComparisonOp[convCodeType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType.Memo, objvCodeTypeCond.Memo, strComparisonOpMemo);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.FuncCount) == true)
{
string strComparisonOpFuncCount = objvCodeTypeCond.dicFldComparisonOp[convCodeType.FuncCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCodeType.FuncCount, objvCodeTypeCond.FuncCount, strComparisonOpFuncCount);
}
if (objvCodeTypeCond.IsUpdated(convCodeType.AppCount) == true)
{
string strComparisonOpAppCount = objvCodeTypeCond.dicFldComparisonOp[convCodeType.AppCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCodeType.AppCount, objvCodeTypeCond.AppCount, strComparisonOpAppCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCodeType
{
public virtual bool UpdRelaTabDate(string strCodeTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v代码类型(vCodeType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCodeTypeBL
{
public static RelatedActions_vCodeType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCodeTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCodeTypeDA vCodeTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCodeTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCodeTypeBL()
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
if (string.IsNullOrEmpty(clsvCodeTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCodeTypeEN._ConnectString);
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
public static DataTable GetDataTable_vCodeType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCodeTypeDA.GetDataTable_vCodeType(strWhereCond);
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
objDT = vCodeTypeDA.GetDataTable(strWhereCond);
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
objDT = vCodeTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCodeTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCodeTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCodeTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vCodeTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCodeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCodeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCodeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCodeTypeEN> GetObjLstByCodeTypeIdLst(List<string> arrCodeTypeIdLst)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCodeTypeIdLst, true);
 string strWhereCond = string.Format("CodeTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCodeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCodeTypeEN> GetObjLstByCodeTypeIdLstCache(List<string> arrCodeTypeIdLst)
{
string strKey = string.Format("{0}", clsvCodeTypeEN._CurrTabName);
List<clsvCodeTypeEN> arrvCodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeTypeEN> arrvCodeTypeObjLst_Sel =
arrvCodeTypeObjLstCache
.Where(x => arrCodeTypeIdLst.Contains(x.CodeTypeId));
return arrvCodeTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeTypeEN> GetObjLst(string strWhereCond)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
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
public static List<clsvCodeTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCodeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCodeTypeEN> GetSubObjLstCache(clsvCodeTypeEN objvCodeTypeCond)
{
List<clsvCodeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCodeType._AttributeName)
{
if (objvCodeTypeCond.IsUpdated(strFldName) == false) continue;
if (objvCodeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeTypeCond[strFldName].ToString());
}
else
{
if (objvCodeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCodeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCodeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCodeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCodeTypeCond[strFldName]));
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
public static List<clsvCodeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
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
public static List<clsvCodeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
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
List<clsvCodeTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCodeTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCodeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
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
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
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
public static List<clsvCodeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCodeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCodeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
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
public static List<clsvCodeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCodeTypeEN> arrObjLst = new List<clsvCodeTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeTypeEN objvCodeTypeEN = new clsvCodeTypeEN();
try
{
objvCodeTypeEN.CodeTypeId = objRow[convCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeTypeEN.CodeTypeName = objRow[convCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeTypeEN.CodeTypeSimName = objRow[convCodeType.CodeTypeSimName].ToString().Trim(); //简称
objvCodeTypeEN.CodeTypeENName = objRow[convCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeTypeEN.GroupName = objRow[convCodeType.GroupName].ToString().Trim(); //组名
objvCodeTypeEN.ProgLangTypeId = objRow[convCodeType.ProgLangTypeId] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeTypeEN.ProgLangTypeName = objRow[convCodeType.ProgLangTypeName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvCodeTypeEN.ProgLangTypeSimName = objRow[convCodeType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convCodeType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvCodeTypeEN.RegionTypeId = objRow[convCodeType.RegionTypeId] == DBNull.Value ? null : objRow[convCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeTypeEN.RegionTypeName = objRow[convCodeType.RegionTypeName] == DBNull.Value ? null : objRow[convCodeType.RegionTypeName].ToString().Trim(); //区域类型名称
objvCodeTypeEN.Prefix = objRow[convCodeType.Prefix] == DBNull.Value ? null : objRow[convCodeType.Prefix].ToString().Trim(); //前缀
objvCodeTypeEN.DependsOn = objRow[convCodeType.DependsOn] == DBNull.Value ? null : objRow[convCodeType.DependsOn].ToString().Trim(); //依赖于
objvCodeTypeEN.FrontOrBack = objRow[convCodeType.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeTypeEN.SqlDsTypeId = objRow[convCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeTypeEN.SqlDsTypeName = objRow[convCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[convCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCodeTypeEN.ClassNameFormat = objRow[convCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objvCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJava].ToString().Trim()); //是否Java语言
objvCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objvCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objvCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objvCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objvCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsVB].ToString().Trim()); //IsVB语言
objvCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objvCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objvCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWeb].ToString().Trim()); //是否Web应用
objvCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objvCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objvCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsWin].ToString().Trim()); //是否Win应用
objvCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objvCodeTypeEN.OrderNum = Int32.Parse(objRow[convCodeType.OrderNum].ToString().Trim()); //序号
objvCodeTypeEN.WinOrWeb = objRow[convCodeType.WinOrWeb] == DBNull.Value ? null : objRow[convCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objvCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objvCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.InUse].ToString().Trim()); //是否在用
objvCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeTypeEN.UpdDate = objRow[convCodeType.UpdDate] == DBNull.Value ? null : objRow[convCodeType.UpdDate].ToString().Trim(); //修改日期
objvCodeTypeEN.UpdUser = objRow[convCodeType.UpdUser] == DBNull.Value ? null : objRow[convCodeType.UpdUser].ToString().Trim(); //修改者
objvCodeTypeEN.Memo = objRow[convCodeType.Memo] == DBNull.Value ? null : objRow[convCodeType.Memo].ToString().Trim(); //说明
objvCodeTypeEN.FuncCount = objRow[convCodeType.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.FuncCount].ToString().Trim()); //函数数目
objvCodeTypeEN.AppCount = objRow[convCodeType.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCodeTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCodeType(ref clsvCodeTypeEN objvCodeTypeEN)
{
bool bolResult = vCodeTypeDA.GetvCodeType(ref objvCodeTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCodeTypeEN GetObjByCodeTypeId(string strCodeTypeId)
{
if (strCodeTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCodeTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCodeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCodeTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCodeTypeEN objvCodeTypeEN = vCodeTypeDA.GetObjByCodeTypeId(strCodeTypeId);
return objvCodeTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCodeTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCodeTypeEN objvCodeTypeEN = vCodeTypeDA.GetFirstObj(strWhereCond);
 return objvCodeTypeEN;
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
public static clsvCodeTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCodeTypeEN objvCodeTypeEN = vCodeTypeDA.GetObjByDataRow(objRow);
 return objvCodeTypeEN;
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
public static clsvCodeTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCodeTypeEN objvCodeTypeEN = vCodeTypeDA.GetObjByDataRow(objRow);
 return objvCodeTypeEN;
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
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <param name = "lstvCodeTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCodeTypeEN GetObjByCodeTypeIdFromList(string strCodeTypeId, List<clsvCodeTypeEN> lstvCodeTypeObjLst)
{
foreach (clsvCodeTypeEN objvCodeTypeEN in lstvCodeTypeObjLst)
{
if (objvCodeTypeEN.CodeTypeId == strCodeTypeId)
{
return objvCodeTypeEN;
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
 string strCodeTypeId;
 try
 {
 strCodeTypeId = new clsvCodeTypeDA().GetFirstID(strWhereCond);
 return strCodeTypeId;
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
 arrList = vCodeTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vCodeTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCodeTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCodeTypeDA.IsExist(strCodeTypeId);
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
 bolIsExist = clsvCodeTypeDA.IsExistTable();
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
 bolIsExist = vCodeTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvCodeTypeENS">源对象</param>
 /// <param name = "objvCodeTypeENT">目标对象</param>
 public static void CopyTo(clsvCodeTypeEN objvCodeTypeENS, clsvCodeTypeEN objvCodeTypeENT)
{
try
{
objvCodeTypeENT.CodeTypeId = objvCodeTypeENS.CodeTypeId; //代码类型Id
objvCodeTypeENT.CodeTypeName = objvCodeTypeENS.CodeTypeName; //代码类型名
objvCodeTypeENT.CodeTypeSimName = objvCodeTypeENS.CodeTypeSimName; //简称
objvCodeTypeENT.CodeTypeENName = objvCodeTypeENS.CodeTypeENName; //代码类型英文名
objvCodeTypeENT.GroupName = objvCodeTypeENS.GroupName; //组名
objvCodeTypeENT.ProgLangTypeId = objvCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objvCodeTypeENT.ProgLangTypeName = objvCodeTypeENS.ProgLangTypeName; //编程语言类型名
objvCodeTypeENT.ProgLangTypeSimName = objvCodeTypeENS.ProgLangTypeSimName; //编程语言类型简称
objvCodeTypeENT.RegionTypeId = objvCodeTypeENS.RegionTypeId; //区域类型Id
objvCodeTypeENT.RegionTypeName = objvCodeTypeENS.RegionTypeName; //区域类型名称
objvCodeTypeENT.Prefix = objvCodeTypeENS.Prefix; //前缀
objvCodeTypeENT.DependsOn = objvCodeTypeENS.DependsOn; //依赖于
objvCodeTypeENT.FrontOrBack = objvCodeTypeENS.FrontOrBack; //前台Or后台
objvCodeTypeENT.SqlDsTypeId = objvCodeTypeENS.SqlDsTypeId; //数据源类型Id
objvCodeTypeENT.SqlDsTypeName = objvCodeTypeENS.SqlDsTypeName; //Sql数据源名
objvCodeTypeENT.ClassNameFormat = objvCodeTypeENS.ClassNameFormat; //类名格式
objvCodeTypeENT.IsCSharp = objvCodeTypeENS.IsCSharp; //是否CSharp语言
objvCodeTypeENT.IsJava = objvCodeTypeENS.IsJava; //是否Java语言
objvCodeTypeENT.IsJavaScript = objvCodeTypeENS.IsJavaScript; //是否JavaScript语言
objvCodeTypeENT.IsTypeScript = objvCodeTypeENS.IsTypeScript; //是否TypeScript语言
objvCodeTypeENT.IsSilverLight = objvCodeTypeENS.IsSilverLight; //是否SilverLight语言
objvCodeTypeENT.IsSwift = objvCodeTypeENS.IsSwift; //是否Swift语言
objvCodeTypeENT.IsVB = objvCodeTypeENS.IsVB; //IsVB语言
objvCodeTypeENT.IsTableFldConst = objvCodeTypeENS.IsTableFldConst; //IsTableFldConst
objvCodeTypeENT.IsPubApp4WinWeb = objvCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objvCodeTypeENT.IsWeb = objvCodeTypeENS.IsWeb; //是否Web应用
objvCodeTypeENT.IsAspMvc = objvCodeTypeENS.IsAspMvc; //是否AspMvc
objvCodeTypeENT.IsWebSrvAccess = objvCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objvCodeTypeENT.IsWin = objvCodeTypeENS.IsWin; //是否Win应用
objvCodeTypeENT.IsMobileApp = objvCodeTypeENS.IsMobileApp; //是否移动终端应用
objvCodeTypeENT.OrderNum = objvCodeTypeENS.OrderNum; //序号
objvCodeTypeENT.WinOrWeb = objvCodeTypeENS.WinOrWeb; //WinOrWeb
objvCodeTypeENT.IsDirByTabName = objvCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objvCodeTypeENT.InUse = objvCodeTypeENS.InUse; //是否在用
objvCodeTypeENT.IsDefaultOverride = objvCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objvCodeTypeENT.UpdDate = objvCodeTypeENS.UpdDate; //修改日期
objvCodeTypeENT.UpdUser = objvCodeTypeENS.UpdUser; //修改者
objvCodeTypeENT.Memo = objvCodeTypeENS.Memo; //说明
objvCodeTypeENT.FuncCount = objvCodeTypeENS.FuncCount; //函数数目
objvCodeTypeENT.AppCount = objvCodeTypeENS.AppCount; //应用数
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
 /// <param name = "objvCodeTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvCodeTypeEN objvCodeTypeEN)
{
try
{
objvCodeTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCodeTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCodeType.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.CodeTypeId = objvCodeTypeEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convCodeType.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.CodeTypeName = objvCodeTypeEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convCodeType.CodeTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.CodeTypeSimName = objvCodeTypeEN.CodeTypeSimName; //简称
}
if (arrFldSet.Contains(convCodeType.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.CodeTypeENName = objvCodeTypeEN.CodeTypeENName == "[null]" ? null :  objvCodeTypeEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(convCodeType.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.GroupName = objvCodeTypeEN.GroupName; //组名
}
if (arrFldSet.Contains(convCodeType.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.ProgLangTypeId = objvCodeTypeEN.ProgLangTypeId == "[null]" ? null :  objvCodeTypeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convCodeType.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.ProgLangTypeName = objvCodeTypeEN.ProgLangTypeName == "[null]" ? null :  objvCodeTypeEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convCodeType.ProgLangTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.ProgLangTypeSimName = objvCodeTypeEN.ProgLangTypeSimName == "[null]" ? null :  objvCodeTypeEN.ProgLangTypeSimName; //编程语言类型简称
}
if (arrFldSet.Contains(convCodeType.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.RegionTypeId = objvCodeTypeEN.RegionTypeId == "[null]" ? null :  objvCodeTypeEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convCodeType.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.RegionTypeName = objvCodeTypeEN.RegionTypeName == "[null]" ? null :  objvCodeTypeEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convCodeType.Prefix, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.Prefix = objvCodeTypeEN.Prefix == "[null]" ? null :  objvCodeTypeEN.Prefix; //前缀
}
if (arrFldSet.Contains(convCodeType.DependsOn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.DependsOn = objvCodeTypeEN.DependsOn == "[null]" ? null :  objvCodeTypeEN.DependsOn; //依赖于
}
if (arrFldSet.Contains(convCodeType.FrontOrBack, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.FrontOrBack = objvCodeTypeEN.FrontOrBack == "[null]" ? null :  objvCodeTypeEN.FrontOrBack; //前台Or后台
}
if (arrFldSet.Contains(convCodeType.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.SqlDsTypeId = objvCodeTypeEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convCodeType.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.SqlDsTypeName = objvCodeTypeEN.SqlDsTypeName == "[null]" ? null :  objvCodeTypeEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convCodeType.ClassNameFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.ClassNameFormat = objvCodeTypeEN.ClassNameFormat == "[null]" ? null :  objvCodeTypeEN.ClassNameFormat; //类名格式
}
if (arrFldSet.Contains(convCodeType.IsCSharp, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsCSharp = objvCodeTypeEN.IsCSharp; //是否CSharp语言
}
if (arrFldSet.Contains(convCodeType.IsJava, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsJava = objvCodeTypeEN.IsJava; //是否Java语言
}
if (arrFldSet.Contains(convCodeType.IsJavaScript, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsJavaScript = objvCodeTypeEN.IsJavaScript; //是否JavaScript语言
}
if (arrFldSet.Contains(convCodeType.IsTypeScript, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsTypeScript = objvCodeTypeEN.IsTypeScript; //是否TypeScript语言
}
if (arrFldSet.Contains(convCodeType.IsSilverLight, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsSilverLight = objvCodeTypeEN.IsSilverLight; //是否SilverLight语言
}
if (arrFldSet.Contains(convCodeType.IsSwift, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsSwift = objvCodeTypeEN.IsSwift; //是否Swift语言
}
if (arrFldSet.Contains(convCodeType.IsVB, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsVB = objvCodeTypeEN.IsVB; //IsVB语言
}
if (arrFldSet.Contains(convCodeType.IsTableFldConst, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsTableFldConst = objvCodeTypeEN.IsTableFldConst; //IsTableFldConst
}
if (arrFldSet.Contains(convCodeType.IsPubApp4WinWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsPubApp4WinWeb = objvCodeTypeEN.IsPubApp4WinWeb; //IsPubApp4WinWeb
}
if (arrFldSet.Contains(convCodeType.IsWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsWeb = objvCodeTypeEN.IsWeb; //是否Web应用
}
if (arrFldSet.Contains(convCodeType.IsAspMvc, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsAspMvc = objvCodeTypeEN.IsAspMvc; //是否AspMvc
}
if (arrFldSet.Contains(convCodeType.IsWebSrvAccess, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsWebSrvAccess = objvCodeTypeEN.IsWebSrvAccess; //IsWebSrvAccess
}
if (arrFldSet.Contains(convCodeType.IsWin, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsWin = objvCodeTypeEN.IsWin; //是否Win应用
}
if (arrFldSet.Contains(convCodeType.IsMobileApp, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsMobileApp = objvCodeTypeEN.IsMobileApp; //是否移动终端应用
}
if (arrFldSet.Contains(convCodeType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.OrderNum = objvCodeTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCodeType.WinOrWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.WinOrWeb = objvCodeTypeEN.WinOrWeb == "[null]" ? null :  objvCodeTypeEN.WinOrWeb; //WinOrWeb
}
if (arrFldSet.Contains(convCodeType.IsDirByTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsDirByTabName = objvCodeTypeEN.IsDirByTabName; //是否用表名作为路径
}
if (arrFldSet.Contains(convCodeType.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.InUse = objvCodeTypeEN.InUse; //是否在用
}
if (arrFldSet.Contains(convCodeType.IsDefaultOverride, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.IsDefaultOverride = objvCodeTypeEN.IsDefaultOverride; //是否默认覆盖
}
if (arrFldSet.Contains(convCodeType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.UpdDate = objvCodeTypeEN.UpdDate == "[null]" ? null :  objvCodeTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCodeType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.UpdUser = objvCodeTypeEN.UpdUser == "[null]" ? null :  objvCodeTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCodeType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.Memo = objvCodeTypeEN.Memo == "[null]" ? null :  objvCodeTypeEN.Memo; //说明
}
if (arrFldSet.Contains(convCodeType.FuncCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.FuncCount = objvCodeTypeEN.FuncCount; //函数数目
}
if (arrFldSet.Contains(convCodeType.AppCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeTypeEN.AppCount = objvCodeTypeEN.AppCount; //应用数
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
 /// <param name = "objvCodeTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCodeTypeEN objvCodeTypeEN)
{
try
{
if (objvCodeTypeEN.CodeTypeENName == "[null]") objvCodeTypeEN.CodeTypeENName = null; //代码类型英文名
if (objvCodeTypeEN.ProgLangTypeId == "[null]") objvCodeTypeEN.ProgLangTypeId = null; //编程语言类型Id
if (objvCodeTypeEN.ProgLangTypeName == "[null]") objvCodeTypeEN.ProgLangTypeName = null; //编程语言类型名
if (objvCodeTypeEN.ProgLangTypeSimName == "[null]") objvCodeTypeEN.ProgLangTypeSimName = null; //编程语言类型简称
if (objvCodeTypeEN.RegionTypeId == "[null]") objvCodeTypeEN.RegionTypeId = null; //区域类型Id
if (objvCodeTypeEN.RegionTypeName == "[null]") objvCodeTypeEN.RegionTypeName = null; //区域类型名称
if (objvCodeTypeEN.Prefix == "[null]") objvCodeTypeEN.Prefix = null; //前缀
if (objvCodeTypeEN.DependsOn == "[null]") objvCodeTypeEN.DependsOn = null; //依赖于
if (objvCodeTypeEN.FrontOrBack == "[null]") objvCodeTypeEN.FrontOrBack = null; //前台Or后台
if (objvCodeTypeEN.SqlDsTypeName == "[null]") objvCodeTypeEN.SqlDsTypeName = null; //Sql数据源名
if (objvCodeTypeEN.ClassNameFormat == "[null]") objvCodeTypeEN.ClassNameFormat = null; //类名格式
if (objvCodeTypeEN.WinOrWeb == "[null]") objvCodeTypeEN.WinOrWeb = null; //WinOrWeb
if (objvCodeTypeEN.UpdDate == "[null]") objvCodeTypeEN.UpdDate = null; //修改日期
if (objvCodeTypeEN.UpdUser == "[null]") objvCodeTypeEN.UpdUser = null; //修改者
if (objvCodeTypeEN.Memo == "[null]") objvCodeTypeEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCodeTypeEN objvCodeTypeEN)
{
 vCodeTypeDA.CheckProperty4Condition(objvCodeTypeEN);
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
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CodeTypeId");
//if (arrvCodeTypeObjLstCache == null)
//{
//arrvCodeTypeObjLstCache = vCodeTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCodeTypeEN GetObjByCodeTypeIdCache(string strCodeTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCodeTypeEN._CurrTabName);
List<clsvCodeTypeEN> arrvCodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeTypeEN> arrvCodeTypeObjLst_Sel =
arrvCodeTypeObjLstCache
.Where(x=> x.CodeTypeId == strCodeTypeId 
);
if (arrvCodeTypeObjLst_Sel.Count() == 0)
{
   clsvCodeTypeEN obj = clsvCodeTypeBL.GetObjByCodeTypeId(strCodeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCodeTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCodeTypeEN> GetAllvCodeTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvCodeTypeEN> arrvCodeTypeObjLstCache = GetObjLstCache(); 
return arrvCodeTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCodeTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCodeTypeEN._CurrTabName);
List<clsvCodeTypeEN> arrvCodeTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCodeTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvCodeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvCodeTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCodeTypeEN._RefreshTimeLst.Count == 0) return "";
return clsvCodeTypeEN._RefreshTimeLst[clsvCodeTypeEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strCodeTypeId)
{
if (strInFldName != convCodeType.CodeTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCodeType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCodeType._AttributeName));
throw new Exception(strMsg);
}
var objvCodeType = clsvCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
if (objvCodeType == null) return "";
return objvCodeType[strOutFldName].ToString();
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
int intRecCount = clsvCodeTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvCodeTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCodeTypeDA.GetRecCount();
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
int intRecCount = clsvCodeTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCodeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCodeTypeEN objvCodeTypeCond)
{
List<clsvCodeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCodeType._AttributeName)
{
if (objvCodeTypeCond.IsUpdated(strFldName) == false) continue;
if (objvCodeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeTypeCond[strFldName].ToString());
}
else
{
if (objvCodeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCodeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCodeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCodeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCodeTypeCond[strFldName]));
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
 List<string> arrList = clsvCodeTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCodeTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCodeTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}