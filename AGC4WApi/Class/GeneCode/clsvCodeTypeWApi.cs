
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeTypeWApi
 表名:vCodeType(00050410)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvCodeTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetCodeTypeId(this clsvCodeTypeEN objvCodeTypeEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCodeType.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCodeType.CodeTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetCodeTypeName(this clsvCodeTypeEN objvCodeTypeEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convCodeType.CodeTypeName);
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convCodeType.CodeTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeSimName">简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetCodeTypeSimName(this clsvCodeTypeEN objvCodeTypeEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, convCodeType.CodeTypeSimName);
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convCodeType.CodeTypeSimName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeENName">代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetCodeTypeENName(this clsvCodeTypeEN objvCodeTypeEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convCodeType.CodeTypeENName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetGroupName(this clsvCodeTypeEN objvCodeTypeEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convCodeType.GroupName);
clsCheckSql.CheckFieldLen(strGroupName, 30, convCodeType.GroupName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetProgLangTypeId(this clsvCodeTypeEN objvCodeTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCodeType.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCodeType.ProgLangTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetProgLangTypeName(this clsvCodeTypeEN objvCodeTypeEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convCodeType.ProgLangTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeSimName">编程语言类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetProgLangTypeSimName(this clsvCodeTypeEN objvCodeTypeEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convCodeType.ProgLangTypeSimName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetRegionTypeId(this clsvCodeTypeEN objvCodeTypeEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convCodeType.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convCodeType.RegionTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetRegionTypeName(this clsvCodeTypeEN objvCodeTypeEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convCodeType.RegionTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrefix">前缀</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetPrefix(this clsvCodeTypeEN objvCodeTypeEN, string strPrefix, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrefix, 10, convCodeType.Prefix);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDependsOn">依赖于</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetDependsOn(this clsvCodeTypeEN objvCodeTypeEN, string strDependsOn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDependsOn, 50, convCodeType.DependsOn);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFrontOrBack">前台Or后台</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetFrontOrBack(this clsvCodeTypeEN objvCodeTypeEN, string strFrontOrBack, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFrontOrBack, 50, convCodeType.FrontOrBack);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetSqlDsTypeId(this clsvCodeTypeEN objvCodeTypeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convCodeType.SqlDsTypeId);
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convCodeType.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convCodeType.SqlDsTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetSqlDsTypeName(this clsvCodeTypeEN objvCodeTypeEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convCodeType.SqlDsTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassNameFormat">类名格式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetClassNameFormat(this clsvCodeTypeEN objvCodeTypeEN, string strClassNameFormat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClassNameFormat, 50, convCodeType.ClassNameFormat);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCSharp">是否CSharp语言</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsJava">是否Java语言</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsJavaScript">是否JavaScript语言</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTypeScript">是否TypeScript语言</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSilverLight">是否SilverLight语言</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSwift">是否Swift语言</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVB">IsVB语言</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTableFldConst">IsTableFldConst</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsPubApp4WinWeb">IsPubApp4WinWeb</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWeb">是否Web应用</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAspMvc">是否AspMvc</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWebSrvAccess">IsWebSrvAccess</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWin">是否Win应用</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsMobileApp">是否移动终端应用</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strWinOrWeb">WinOrWeb</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetWinOrWeb(this clsvCodeTypeEN objvCodeTypeEN, string strWinOrWeb, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWinOrWeb, 50, convCodeType.WinOrWeb);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDirByTabName">是否用表名作为路径</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefaultOverride">是否默认覆盖</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetUpdDate(this clsvCodeTypeEN objvCodeTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCodeType.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetUpdUser(this clsvCodeTypeEN objvCodeTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCodeType.UpdUser);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetMemo(this clsvCodeTypeEN objvCodeTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCodeType.Memo);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intFuncCount">函数数目</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetFuncCount(this clsvCodeTypeEN objvCodeTypeEN, int intFuncCount, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intAppCount">应用数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeTypeEN SetAppCount(this clsvCodeTypeEN objvCodeTypeEN, int intAppCount, string strComparisonOp="")
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v代码类型(vCodeType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCodeTypeWApi
{
private static readonly string mstrApiControllerName = "vCodeTypeApi";

 public clsvCodeTypeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCodeTypeEN GetObjByCodeTypeId(string strCodeTypeId)
{
if (strCodeTypeId == "") return null;
string strAction = "GetObjByCodeTypeId";
clsvCodeTypeEN objvCodeTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCodeTypeId"] = strCodeTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCodeTypeEN = JsonConvert.DeserializeObject<clsvCodeTypeEN>(strJson);
return objvCodeTypeEN;
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
public static clsvCodeTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCodeTypeEN objvCodeTypeEN;
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
objvCodeTypeEN = JsonConvert.DeserializeObject<clsvCodeTypeEN>(strJson);
return objvCodeTypeEN;
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
public static List<clsvCodeTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeTypeEN>>(strJson);
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
 /// <param name = "arrCodeTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeTypeEN> GetObjLstByCodeTypeIdLst(List<string> arrCodeTypeId)
{
 List<clsvCodeTypeEN> arrObjLst; 
string strAction = "GetObjLstByCodeTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCodeTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeTypeEN>>(strJson);
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
public static List<clsvCodeTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeTypeEN>>(strJson);
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
public static List<clsvCodeTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeTypeEN>>(strJson);
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
public static List<clsvCodeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeTypeEN>>(strJson);
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
public static List<clsvCodeTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeTypeEN>>(strJson);
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
public static bool IsExist(string strCodeTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCodeTypeId"] = strCodeTypeId
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
public static DataTable ToDataTable(List<clsvCodeTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCodeTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCodeTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCodeTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCodeTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCodeTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsvCodeTypeEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvCodeTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCodeType.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.CodeTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.ProgLangTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.Prefix, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.DependsOn, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.FrontOrBack, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.ClassNameFormat, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.IsCSharp, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsJava, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsJavaScript, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsTypeScript, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsSilverLight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsSwift, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsVB, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsTableFldConst, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsPubApp4WinWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsAspMvc, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsWebSrvAccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsWin, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsMobileApp, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCodeType.WinOrWeb, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.IsDirByTabName, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.IsDefaultOverride, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType.FuncCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCodeType.AppCount, Type.GetType("System.Int32"));
foreach (clsvCodeTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCodeType.CodeTypeId] = objInFor[convCodeType.CodeTypeId];
objDR[convCodeType.CodeTypeName] = objInFor[convCodeType.CodeTypeName];
objDR[convCodeType.CodeTypeSimName] = objInFor[convCodeType.CodeTypeSimName];
objDR[convCodeType.CodeTypeENName] = objInFor[convCodeType.CodeTypeENName];
objDR[convCodeType.GroupName] = objInFor[convCodeType.GroupName];
objDR[convCodeType.ProgLangTypeId] = objInFor[convCodeType.ProgLangTypeId];
objDR[convCodeType.ProgLangTypeName] = objInFor[convCodeType.ProgLangTypeName];
objDR[convCodeType.ProgLangTypeSimName] = objInFor[convCodeType.ProgLangTypeSimName];
objDR[convCodeType.RegionTypeId] = objInFor[convCodeType.RegionTypeId];
objDR[convCodeType.RegionTypeName] = objInFor[convCodeType.RegionTypeName];
objDR[convCodeType.Prefix] = objInFor[convCodeType.Prefix];
objDR[convCodeType.DependsOn] = objInFor[convCodeType.DependsOn];
objDR[convCodeType.FrontOrBack] = objInFor[convCodeType.FrontOrBack];
objDR[convCodeType.SqlDsTypeId] = objInFor[convCodeType.SqlDsTypeId];
objDR[convCodeType.SqlDsTypeName] = objInFor[convCodeType.SqlDsTypeName];
objDR[convCodeType.ClassNameFormat] = objInFor[convCodeType.ClassNameFormat];
objDR[convCodeType.IsCSharp] = objInFor[convCodeType.IsCSharp];
objDR[convCodeType.IsJava] = objInFor[convCodeType.IsJava];
objDR[convCodeType.IsJavaScript] = objInFor[convCodeType.IsJavaScript];
objDR[convCodeType.IsTypeScript] = objInFor[convCodeType.IsTypeScript];
objDR[convCodeType.IsSilverLight] = objInFor[convCodeType.IsSilverLight];
objDR[convCodeType.IsSwift] = objInFor[convCodeType.IsSwift];
objDR[convCodeType.IsVB] = objInFor[convCodeType.IsVB];
objDR[convCodeType.IsTableFldConst] = objInFor[convCodeType.IsTableFldConst];
objDR[convCodeType.IsPubApp4WinWeb] = objInFor[convCodeType.IsPubApp4WinWeb];
objDR[convCodeType.IsWeb] = objInFor[convCodeType.IsWeb];
objDR[convCodeType.IsAspMvc] = objInFor[convCodeType.IsAspMvc];
objDR[convCodeType.IsWebSrvAccess] = objInFor[convCodeType.IsWebSrvAccess];
objDR[convCodeType.IsWin] = objInFor[convCodeType.IsWin];
objDR[convCodeType.IsMobileApp] = objInFor[convCodeType.IsMobileApp];
objDR[convCodeType.OrderNum] = objInFor[convCodeType.OrderNum];
objDR[convCodeType.WinOrWeb] = objInFor[convCodeType.WinOrWeb];
objDR[convCodeType.IsDirByTabName] = objInFor[convCodeType.IsDirByTabName];
objDR[convCodeType.InUse] = objInFor[convCodeType.InUse];
objDR[convCodeType.IsDefaultOverride] = objInFor[convCodeType.IsDefaultOverride];
objDR[convCodeType.UpdDate] = objInFor[convCodeType.UpdDate];
objDR[convCodeType.UpdUser] = objInFor[convCodeType.UpdUser];
objDR[convCodeType.Memo] = objInFor[convCodeType.Memo];
objDR[convCodeType.FuncCount] = objInFor[convCodeType.FuncCount];
objDR[convCodeType.AppCount] = objInFor[convCodeType.AppCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}