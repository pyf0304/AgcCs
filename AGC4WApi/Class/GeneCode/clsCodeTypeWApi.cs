
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeTypeWApi
 表名:CodeType(00050203)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:28
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
public static class  clsCodeTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeId(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conCodeType.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conCodeType.CodeTypeId);
objCodeTypeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeName(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, conCodeType.CodeTypeName);
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, conCodeType.CodeTypeName);
objCodeTypeEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeSimName">简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeSimName(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, conCodeType.CodeTypeSimName);
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, conCodeType.CodeTypeSimName);
objCodeTypeEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeSimName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeSimName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeSimName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeENName">代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeENName(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, conCodeType.CodeTypeENName);
objCodeTypeEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeENName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeENName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeENName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetGroupName(this clsCodeTypeEN objCodeTypeEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupName, 30, conCodeType.GroupName);
objCodeTypeEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.GroupName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.GroupName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.GroupName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetProgLangTypeId(this clsCodeTypeEN objCodeTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, conCodeType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conCodeType.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conCodeType.ProgLangTypeId);
objCodeTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ProgLangTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ProgLangTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ProgLangTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetRegionTypeId(this clsCodeTypeEN objCodeTypeEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, conCodeType.RegionTypeId);
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, conCodeType.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, conCodeType.RegionTypeId);
objCodeTypeEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.RegionTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.RegionTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.RegionTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrefix">前缀</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetPrefix(this clsCodeTypeEN objCodeTypeEN, string strPrefix, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrefix, 10, conCodeType.Prefix);
objCodeTypeEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.Prefix) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.Prefix, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.Prefix] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDependsOn">依赖于</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetDependsOn(this clsCodeTypeEN objCodeTypeEN, string strDependsOn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDependsOn, 50, conCodeType.DependsOn);
objCodeTypeEN.DependsOn = strDependsOn; //依赖于
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.DependsOn) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.DependsOn, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.DependsOn] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFrontOrBack">前台Or后台</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetFrontOrBack(this clsCodeTypeEN objCodeTypeEN, string strFrontOrBack, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFrontOrBack, 50, conCodeType.FrontOrBack);
objCodeTypeEN.FrontOrBack = strFrontOrBack; //前台Or后台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.FrontOrBack) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.FrontOrBack, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.FrontOrBack] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetSqlDsTypeId(this clsCodeTypeEN objCodeTypeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, conCodeType.SqlDsTypeId);
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, conCodeType.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, conCodeType.SqlDsTypeId);
objCodeTypeEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.SqlDsTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.SqlDsTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.SqlDsTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassNameFormat">类名格式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetClassNameFormat(this clsCodeTypeEN objCodeTypeEN, string strClassNameFormat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClassNameFormat, 50, conCodeType.ClassNameFormat);
objCodeTypeEN.ClassNameFormat = strClassNameFormat; //类名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ClassNameFormat) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ClassNameFormat, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ClassNameFormat] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileNameFormat">文件名格式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetFileNameFormat(this clsCodeTypeEN objCodeTypeEN, string strFileNameFormat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNameFormat, 50, conCodeType.FileNameFormat);
objCodeTypeEN.FileNameFormat = strFileNameFormat; //文件名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.FileNameFormat) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.FileNameFormat, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.FileNameFormat] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassNamePattern">类名模式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetClassNamePattern(this clsCodeTypeEN objCodeTypeEN, string strClassNamePattern, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClassNamePattern, 50, conCodeType.ClassNamePattern);
objCodeTypeEN.ClassNamePattern = strClassNamePattern; //类名模式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ClassNamePattern) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ClassNamePattern, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ClassNamePattern] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCSharp">是否CSharp语言</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsCSharp(this clsCodeTypeEN objCodeTypeEN, bool bolIsCSharp, string strComparisonOp="")
	{
objCodeTypeEN.IsCSharp = bolIsCSharp; //是否CSharp语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsCSharp) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsCSharp, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsCSharp] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsJava">是否Java语言</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsJava(this clsCodeTypeEN objCodeTypeEN, bool bolIsJava, string strComparisonOp="")
	{
objCodeTypeEN.IsJava = bolIsJava; //是否Java语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsJava) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsJava, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsJava] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsJavaScript">是否JavaScript语言</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsJavaScript(this clsCodeTypeEN objCodeTypeEN, bool bolIsJavaScript, string strComparisonOp="")
	{
objCodeTypeEN.IsJavaScript = bolIsJavaScript; //是否JavaScript语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsJavaScript) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsJavaScript, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsJavaScript] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTypeScript">是否TypeScript语言</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsTypeScript(this clsCodeTypeEN objCodeTypeEN, bool bolIsTypeScript, string strComparisonOp="")
	{
objCodeTypeEN.IsTypeScript = bolIsTypeScript; //是否TypeScript语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsTypeScript) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsTypeScript, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsTypeScript] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSilverLight">是否SilverLight语言</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsSilverLight(this clsCodeTypeEN objCodeTypeEN, bool bolIsSilverLight, string strComparisonOp="")
	{
objCodeTypeEN.IsSilverLight = bolIsSilverLight; //是否SilverLight语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsSilverLight) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsSilverLight, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsSilverLight] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSwift">是否Swift语言</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsSwift(this clsCodeTypeEN objCodeTypeEN, bool bolIsSwift, string strComparisonOp="")
	{
objCodeTypeEN.IsSwift = bolIsSwift; //是否Swift语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsSwift) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsSwift, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsSwift] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVB">IsVB语言</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsVB(this clsCodeTypeEN objCodeTypeEN, bool bolIsVB, string strComparisonOp="")
	{
objCodeTypeEN.IsVB = bolIsVB; //IsVB语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsVB) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsVB, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsVB] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTableFldConst">IsTableFldConst</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsTableFldConst(this clsCodeTypeEN objCodeTypeEN, bool bolIsTableFldConst, string strComparisonOp="")
	{
objCodeTypeEN.IsTableFldConst = bolIsTableFldConst; //IsTableFldConst
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsTableFldConst) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsTableFldConst, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsTableFldConst] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsPubApp4WinWeb">IsPubApp4WinWeb</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsPubApp4WinWeb(this clsCodeTypeEN objCodeTypeEN, bool bolIsPubApp4WinWeb, string strComparisonOp="")
	{
objCodeTypeEN.IsPubApp4WinWeb = bolIsPubApp4WinWeb; //IsPubApp4WinWeb
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsPubApp4WinWeb) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsPubApp4WinWeb, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsPubApp4WinWeb] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWeb">是否Web应用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsWeb(this clsCodeTypeEN objCodeTypeEN, bool bolIsWeb, string strComparisonOp="")
	{
objCodeTypeEN.IsWeb = bolIsWeb; //是否Web应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsWeb) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsWeb, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsWeb] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAspMvc">是否AspMvc</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsAspMvc(this clsCodeTypeEN objCodeTypeEN, bool bolIsAspMvc, string strComparisonOp="")
	{
objCodeTypeEN.IsAspMvc = bolIsAspMvc; //是否AspMvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsAspMvc) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsAspMvc, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsAspMvc] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWebSrvAccess">IsWebSrvAccess</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsWebSrvAccess(this clsCodeTypeEN objCodeTypeEN, bool bolIsWebSrvAccess, string strComparisonOp="")
	{
objCodeTypeEN.IsWebSrvAccess = bolIsWebSrvAccess; //IsWebSrvAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsWebSrvAccess) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsWebSrvAccess, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsWebSrvAccess] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsWin">是否Win应用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsWin(this clsCodeTypeEN objCodeTypeEN, bool bolIsWin, string strComparisonOp="")
	{
objCodeTypeEN.IsWin = bolIsWin; //是否Win应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsWin) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsWin, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsWin] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsMobileApp">是否移动终端应用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsMobileApp(this clsCodeTypeEN objCodeTypeEN, bool bolIsMobileApp, string strComparisonOp="")
	{
objCodeTypeEN.IsMobileApp = bolIsMobileApp; //是否移动终端应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsMobileApp) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsMobileApp, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsMobileApp] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExtend">是否扩展类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsExtend(this clsCodeTypeEN objCodeTypeEN, bool bolIsExtend, string strComparisonOp="")
	{
objCodeTypeEN.IsExtend = bolIsExtend; //是否扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsExtend) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsExtend, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsExtend] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetOrderNum(this clsCodeTypeEN objCodeTypeEN, int intOrderNum, string strComparisonOp="")
	{
objCodeTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.OrderNum) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.OrderNum, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.OrderNum] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strWinOrWeb">WinOrWeb</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetWinOrWeb(this clsCodeTypeEN objCodeTypeEN, string strWinOrWeb, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWinOrWeb, 50, conCodeType.WinOrWeb);
objCodeTypeEN.WinOrWeb = strWinOrWeb; //WinOrWeb
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.WinOrWeb) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.WinOrWeb, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.WinOrWeb] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDirByTabName">是否用表名作为路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsDirByTabName(this clsCodeTypeEN objCodeTypeEN, bool bolIsDirByTabName, string strComparisonOp="")
	{
objCodeTypeEN.IsDirByTabName = bolIsDirByTabName; //是否用表名作为路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsDirByTabName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsDirByTabName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsDirByTabName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefaultOverride">是否默认覆盖</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsDefaultOverride(this clsCodeTypeEN objCodeTypeEN, bool bolIsDefaultOverride, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultOverride, conCodeType.IsDefaultOverride);
objCodeTypeEN.IsDefaultOverride = bolIsDefaultOverride; //是否默认覆盖
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsDefaultOverride) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsDefaultOverride, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsDefaultOverride] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetInUse(this clsCodeTypeEN objCodeTypeEN, bool bolInUse, string strComparisonOp="")
	{
objCodeTypeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.InUse) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.InUse, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.InUse] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAutoParseFile">是否自动分析文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsAutoParseFile(this clsCodeTypeEN objCodeTypeEN, bool bolIsAutoParseFile, string strComparisonOp="")
	{
objCodeTypeEN.IsAutoParseFile = bolIsAutoParseFile; //是否自动分析文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsAutoParseFile) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsAutoParseFile, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsAutoParseFile] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetUpdDate(this clsCodeTypeEN objCodeTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCodeType.UpdDate);
objCodeTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.UpdDate) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.UpdDate, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.UpdDate] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetUpdUser(this clsCodeTypeEN objCodeTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCodeType.UpdUser);
objCodeTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.UpdUser) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.UpdUser, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.UpdUser] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetMemo(this clsCodeTypeEN objCodeTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCodeType.Memo);
objCodeTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.Memo) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.Memo, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.Memo] = strComparisonOp;
}
}
return objCodeTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCodeTypeEN objCodeTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCodeTypeCond.IsUpdated(conCodeType.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objCodeTypeCond.dicFldComparisonOp[conCodeType.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeId, objCodeTypeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objCodeTypeCond.IsUpdated(conCodeType.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objCodeTypeCond.dicFldComparisonOp[conCodeType.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeName, objCodeTypeCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objCodeTypeCond.IsUpdated(conCodeType.CodeTypeSimName) == true)
{
string strComparisonOpCodeTypeSimName = objCodeTypeCond.dicFldComparisonOp[conCodeType.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeSimName, objCodeTypeCond.CodeTypeSimName, strComparisonOpCodeTypeSimName);
}
if (objCodeTypeCond.IsUpdated(conCodeType.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objCodeTypeCond.dicFldComparisonOp[conCodeType.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeENName, objCodeTypeCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objCodeTypeCond.IsUpdated(conCodeType.GroupName) == true)
{
string strComparisonOpGroupName = objCodeTypeCond.dicFldComparisonOp[conCodeType.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.GroupName, objCodeTypeCond.GroupName, strComparisonOpGroupName);
}
if (objCodeTypeCond.IsUpdated(conCodeType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objCodeTypeCond.dicFldComparisonOp[conCodeType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ProgLangTypeId, objCodeTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objCodeTypeCond.IsUpdated(conCodeType.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objCodeTypeCond.dicFldComparisonOp[conCodeType.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.RegionTypeId, objCodeTypeCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objCodeTypeCond.IsUpdated(conCodeType.Prefix) == true)
{
string strComparisonOpPrefix = objCodeTypeCond.dicFldComparisonOp[conCodeType.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.Prefix, objCodeTypeCond.Prefix, strComparisonOpPrefix);
}
if (objCodeTypeCond.IsUpdated(conCodeType.DependsOn) == true)
{
string strComparisonOpDependsOn = objCodeTypeCond.dicFldComparisonOp[conCodeType.DependsOn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.DependsOn, objCodeTypeCond.DependsOn, strComparisonOpDependsOn);
}
if (objCodeTypeCond.IsUpdated(conCodeType.FrontOrBack) == true)
{
string strComparisonOpFrontOrBack = objCodeTypeCond.dicFldComparisonOp[conCodeType.FrontOrBack];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.FrontOrBack, objCodeTypeCond.FrontOrBack, strComparisonOpFrontOrBack);
}
if (objCodeTypeCond.IsUpdated(conCodeType.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objCodeTypeCond.dicFldComparisonOp[conCodeType.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.SqlDsTypeId, objCodeTypeCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objCodeTypeCond.IsUpdated(conCodeType.ClassNameFormat) == true)
{
string strComparisonOpClassNameFormat = objCodeTypeCond.dicFldComparisonOp[conCodeType.ClassNameFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ClassNameFormat, objCodeTypeCond.ClassNameFormat, strComparisonOpClassNameFormat);
}
if (objCodeTypeCond.IsUpdated(conCodeType.FileNameFormat) == true)
{
string strComparisonOpFileNameFormat = objCodeTypeCond.dicFldComparisonOp[conCodeType.FileNameFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.FileNameFormat, objCodeTypeCond.FileNameFormat, strComparisonOpFileNameFormat);
}
if (objCodeTypeCond.IsUpdated(conCodeType.ClassNamePattern) == true)
{
string strComparisonOpClassNamePattern = objCodeTypeCond.dicFldComparisonOp[conCodeType.ClassNamePattern];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ClassNamePattern, objCodeTypeCond.ClassNamePattern, strComparisonOpClassNamePattern);
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsCSharp) == true)
{
if (objCodeTypeCond.IsCSharp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsCSharp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsCSharp);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsJava) == true)
{
if (objCodeTypeCond.IsJava == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsJava);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsJava);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsJavaScript) == true)
{
if (objCodeTypeCond.IsJavaScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsJavaScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsJavaScript);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsTypeScript) == true)
{
if (objCodeTypeCond.IsTypeScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsTypeScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsTypeScript);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsSilverLight) == true)
{
if (objCodeTypeCond.IsSilverLight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsSilverLight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsSilverLight);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsSwift) == true)
{
if (objCodeTypeCond.IsSwift == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsSwift);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsSwift);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsVB) == true)
{
if (objCodeTypeCond.IsVB == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsVB);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsVB);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsTableFldConst) == true)
{
if (objCodeTypeCond.IsTableFldConst == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsTableFldConst);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsTableFldConst);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsPubApp4WinWeb) == true)
{
if (objCodeTypeCond.IsPubApp4WinWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsPubApp4WinWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsPubApp4WinWeb);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsWeb) == true)
{
if (objCodeTypeCond.IsWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsWeb);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsAspMvc) == true)
{
if (objCodeTypeCond.IsAspMvc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsAspMvc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsAspMvc);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsWebSrvAccess) == true)
{
if (objCodeTypeCond.IsWebSrvAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsWebSrvAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsWebSrvAccess);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsWin) == true)
{
if (objCodeTypeCond.IsWin == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsWin);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsWin);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsMobileApp) == true)
{
if (objCodeTypeCond.IsMobileApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsMobileApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsMobileApp);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsExtend) == true)
{
if (objCodeTypeCond.IsExtend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsExtend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsExtend);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.OrderNum) == true)
{
string strComparisonOpOrderNum = objCodeTypeCond.dicFldComparisonOp[conCodeType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCodeType.OrderNum, objCodeTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objCodeTypeCond.IsUpdated(conCodeType.WinOrWeb) == true)
{
string strComparisonOpWinOrWeb = objCodeTypeCond.dicFldComparisonOp[conCodeType.WinOrWeb];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.WinOrWeb, objCodeTypeCond.WinOrWeb, strComparisonOpWinOrWeb);
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsDirByTabName) == true)
{
if (objCodeTypeCond.IsDirByTabName == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsDirByTabName);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsDirByTabName);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsDefaultOverride) == true)
{
if (objCodeTypeCond.IsDefaultOverride == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsDefaultOverride);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsDefaultOverride);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.InUse) == true)
{
if (objCodeTypeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.InUse);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsAutoParseFile) == true)
{
if (objCodeTypeCond.IsAutoParseFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsAutoParseFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsAutoParseFile);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.UpdDate) == true)
{
string strComparisonOpUpdDate = objCodeTypeCond.dicFldComparisonOp[conCodeType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.UpdDate, objCodeTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objCodeTypeCond.IsUpdated(conCodeType.UpdUser) == true)
{
string strComparisonOpUpdUser = objCodeTypeCond.dicFldComparisonOp[conCodeType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.UpdUser, objCodeTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objCodeTypeCond.IsUpdated(conCodeType.Memo) == true)
{
string strComparisonOpMemo = objCodeTypeCond.dicFldComparisonOp[conCodeType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.Memo, objCodeTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeTypeEN objCodeTypeEN)
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCodeTypeEN.sfUpdFldSetStr = objCodeTypeEN.getsfUpdFldSetStr();
clsCodeTypeWApi.CheckPropertyNew(objCodeTypeEN); 
bool bolResult = clsCodeTypeWApi.UpdateRecord(objCodeTypeEN);
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
 /// 获取唯一性条件串--CodeType(代码类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CodeTypeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCodeTypeEN objCodeTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCodeTypeEN == null) return "";
if (objCodeTypeEN.CodeTypeId == null || objCodeTypeEN.CodeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CodeTypeId !=  '{0}'", objCodeTypeEN.CodeTypeId);
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCodeTypeEN objCodeTypeEN)
{
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeWApi.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeWApi.GetMaxStrId();
 }
clsCodeTypeWApi.CheckPropertyNew(objCodeTypeEN); 
bool bolResult = clsCodeTypeWApi.AddNewRecord(objCodeTypeEN);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCodeTypeEN objCodeTypeEN)
{
try
{
clsCodeTypeWApi.CheckPropertyNew(objCodeTypeEN); 
string strCodeTypeId = clsCodeTypeWApi.AddNewRecordWithMaxId(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return strCodeTypeId;
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
 /// <param name = "objCodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeTypeEN objCodeTypeEN, string strWhereCond)
{
try
{
clsCodeTypeWApi.CheckPropertyNew(objCodeTypeEN); 
bool bolResult = clsCodeTypeWApi.UpdateWithCondition(objCodeTypeEN, strWhereCond);
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumCodeTypeWA
{
 /// <summary>
 /// 未知(CS)
 /// </summary>
public const string Unknown_0000 = "0000";
 /// <summary>
 /// 实体层(CS)
 /// </summary>
public const string EntityLayer_0001 = "0001";
 /// <summary>
 /// 数据处理层(CS)
 /// </summary>
public const string DALCode_0002 = "0002";
 /// <summary>
 /// 业务逻辑层(CS)
 /// </summary>
public const string BusinessLogic_0003 = "0003";
 /// <summary>
 /// WEB界面前台脚本(Html)
 /// </summary>
public const string WebViewCode_0004 = "0004";
 /// <summary>
 /// Web用户控件前台脚本(Html)
 /// </summary>
public const string WebCtlViewCode_0005 = "0005";
 /// <summary>
 /// Win界面层_QD(CS)
 /// </summary>
public const string WinViewCode_QD_0006 = "0006";
 /// <summary>
 /// WEB服务层(CS)
 /// </summary>
public const string WS_Srv_0009 = "0009";
 /// <summary>
 /// WEB服务访问层(CS)
 /// </summary>
public const string WS_Access_0010 = "0010";
 /// <summary>
 /// 简化实体层(CS)
 /// </summary>
public const string EntityLayer_Sim_0011 = "0011";
 /// <summary>
 /// Web服务访问高层(JAVA)
 /// </summary>
public const string WS_AccessHigh_0012 = "0012";
 /// <summary>
 /// App控制层(JAVA)
 /// </summary>
public const string AppController_0013 = "0013";
 /// <summary>
 /// Web界面后台(CS)
 /// </summary>
public const string WebViewControlCode_0014 = "0014";
 /// <summary>
 /// Web用户控件后台(CS)
 /// </summary>
public const string WebCtlControlCode_0015 = "0015";
 /// <summary>
 /// Win界面层_UI(CS)
 /// </summary>
public const string WinViewCode_UI_0016 = "0016";
 /// <summary>
 /// Web服务前台(CS)
 /// </summary>
public const string WS_Srv4Front_0017 = "0017";
 /// <summary>
 /// Win界面层_QD_设计(CS)
 /// </summary>
public const string WinViewCode_QD_Design_0018 = "0018";
 /// <summary>
 /// Win界面层_UI_设计(CS)
 /// </summary>
public const string WinViewCode_UI_Design_0019 = "0019";
 /// <summary>
 /// 逻辑层公共函数类扩展(CS)
 /// </summary>
public const string CommFun4BL_0020 = "0020";
 /// <summary>
 /// 业务逻辑扩展层(CS)
 /// </summary>
public const string BusinessLogicEx_0021 = "0021";
 /// <summary>
 /// 数据处理扩展层(CS)
 /// </summary>
public const string DALExCode_0022 = "0022";
 /// <summary>
 /// Mvc界面层(CS)
 /// </summary>
public const string Mvc_View_0023 = "0023";
 /// <summary>
 /// Mvc控制层Base(CS)
 /// </summary>
public const string Mvc_ControllerBase_0024 = "0024";
 /// <summary>
 /// App界面UT(JAVA)
 /// </summary>
public const string AppViewUnitTest_0025 = "0025";
 /// <summary>
 /// App界面UT脚本(JAVA)
 /// </summary>
public const string AppViewUTScript_0026 = "0026";
 /// <summary>
 /// App界面UT脚本后台(JAVA)
 /// </summary>
public const string AppViewUTScriptCS_0027 = "0027";
 /// <summary>
 /// 条件实体层(CS)
 /// </summary>
public const string CondEntityLayer_0028 = "0028";
 /// <summary>
 /// App界面脚本内容页(JAVA)
 /// </summary>
public const string AppViewScriptContent_0029 = "0029";
 /// <summary>
 /// App界面脚本后台(JAVA)
 /// </summary>
public const string AppViewScriptCS_0030 = "0030";
 /// <summary>
 /// App界面查询控件脚本(JAVA)
 /// </summary>
public const string AppViewQryScript_0031 = "0031";
 /// <summary>
 /// App界面编辑控件脚本(JAVA)
 /// </summary>
public const string AppViewEdtScript_0032 = "0032";
 /// <summary>
 /// Web用户Gv控件后台(CS)
 /// </summary>
public const string WebCtlControlCode4Gv_0033 = "0033";
 /// <summary>
 /// Web用户Gv控件前台脚本(Html)
 /// </summary>
public const string WebCtlViewCode4Gv_0034 = "0034";
 /// <summary>
 /// App界面脚本主页(JAVA)
 /// </summary>
public const string AppViewScriptMain_0035 = "0035";
 /// <summary>
 /// App界面ListViewItem控件脚本(JAVA)
 /// </summary>
public const string AppViewLvItemScript_0036 = "0036";
 /// <summary>
 /// App界面ListViewAdapter(JAVA)
 /// </summary>
public const string AppViewListViewAdapter_0037 = "0037";
 /// <summary>
 /// App界面Ddl绑定(JAVA)
 /// </summary>
public const string AppViewDdlBind_0038 = "0038";
 /// <summary>
 /// App界面Ddl适配器(JAVA)
 /// </summary>
public const string AppViewDdlAdapter_0039 = "0039";
 /// <summary>
 /// App界面ListView头控件脚本(JAVA)
 /// </summary>
public const string AppViewLvHeadScript_0040 = "0040";
 /// <summary>
 /// 表字段常量CSharp(CS)
 /// </summary>
public const string TableFldConst_0041 = "0041";
 /// <summary>
 /// 实体扩展层(CS)
 /// </summary>
public const string EntityLayerEx_0042 = "0042";
 /// <summary>
 /// App业务逻辑层(JAVA)
 /// </summary>
public const string AppBusiness_0043 = "0043";
 /// <summary>
 /// WA_服务层(CS)
 /// </summary>
public const string WA_Srv_0044 = "0044";
 /// <summary>
 /// WA_访问层(CS)
 /// </summary>
public const string WA_Access_0045 = "0045";
 /// <summary>
 /// Mvc界面模型(CS)
 /// </summary>
public const string Mvc_Model_View_0046 = "0046";
 /// <summary>
 /// Mvc查询区模型(CS)
 /// </summary>
public const string Mvc_Model_Query_0047 = "0047";
 /// <summary>
 /// Mvc界面层Ajax(CS)
 /// </summary>
public const string Mvc_ViewAjax_0048 = "0048";
 /// <summary>
 /// Mvc界面-列表Ajax(CS)
 /// </summary>
public const string Mvc_ViewLstAjax_0049 = "0049";
 /// <summary>
 /// Mvc界面层Spa(CS)
 /// </summary>
public const string Mvc_ViewSpa_0050 = "0050";
 /// <summary>
 /// 业务逻辑层4Mvc(CS)
 /// </summary>
public const string BusinessLogic4Mvc_0051 = "0051";
 /// <summary>
 /// WA_界面UT(CS)
 /// </summary>
public const string WA_ViewUTScript_0052 = "0052";
 /// <summary>
 /// WA_界面UT后台(CS)
 /// </summary>
public const string WA_ViewUTScriptCS_0053 = "0053";
 /// <summary>
 /// WA_界面UT_TS(Html)
 /// </summary>
public const string WA_ViewUTScript_TS_0054 = "0054";
 /// <summary>
 /// 实体层(JAVA)
 /// </summary>
public const string EntityLayer_0056 = "0056";
 /// <summary>
 /// 数据处理层(JAVA)
 /// </summary>
public const string DALCode_0057 = "0057";
 /// <summary>
 /// 业务逻辑层(JAVA)
 /// </summary>
public const string BusinessLogic_0058 = "0058";
 /// <summary>
 /// WEB界面前台脚本(JAVA)
 /// </summary>
public const string WebViewCode_0059 = "0059";
 /// <summary>
 /// Web用户控件前台脚本(JAVA)
 /// </summary>
public const string WebCtlViewCode_0060 = "0060";
 /// <summary>
 /// Win界面层_QD(JAVA)
 /// </summary>
public const string WinViewCode_QD_0061 = "0061";
 /// <summary>
 /// WEB服务访问层(JAVA)
 /// </summary>
public const string WS_Access_0062 = "0062";
 /// <summary>
 /// Web服务访问高层(JS)
 /// </summary>
public const string WS_AccessHigh_0063 = "0063";
 /// <summary>
 /// App控制层(JS)
 /// </summary>
public const string AppController_0064 = "0064";
 /// <summary>
 /// Web界面后台2(JAVA)
 /// </summary>
public const string WebViewControlCode_0065 = "0065";
 /// <summary>
 /// Web用户控件后台(JAVA)
 /// </summary>
public const string WebCtlControlCode_0066 = "0066";
 /// <summary>
 /// App界面UT(JS)
 /// </summary>
public const string AppViewUnitTest_0067 = "0067";
 /// <summary>
 /// App界面UT脚本(JS)
 /// </summary>
public const string AppViewUTScript_0068 = "0068";
 /// <summary>
 /// App界面UT脚本后台(JS)
 /// </summary>
public const string AppViewUTScriptCS_0069 = "0069";
 /// <summary>
 /// App界面脚本内容页(JS)
 /// </summary>
public const string AppViewScriptContent_0070 = "0070";
 /// <summary>
 /// App界面脚本后台(JS)
 /// </summary>
public const string AppViewScriptCS_0071 = "0071";
 /// <summary>
 /// App界面查询控件脚本(JS)
 /// </summary>
public const string AppViewQryScript_0072 = "0072";
 /// <summary>
 /// App界面编辑控件脚本(JS)
 /// </summary>
public const string AppViewEdtScript_0073 = "0073";
 /// <summary>
 /// Web用户Gv控件后台(JAVA)
 /// </summary>
public const string WebCtlControlCode4Gv_0074 = "0074";
 /// <summary>
 /// Web用户Gv控件前台脚本(JAVA)
 /// </summary>
public const string WebCtlViewCode4Gv_0075 = "0075";
 /// <summary>
 /// App界面脚本主页(JS)
 /// </summary>
public const string AppViewScriptMain_0076 = "0076";
 /// <summary>
 /// App界面ListViewItem控件脚本(JS)
 /// </summary>
public const string AppViewLvItemScript_0077 = "0077";
 /// <summary>
 /// App界面ListViewAdapter(JS)
 /// </summary>
public const string AppViewListViewAdapter_0078 = "0078";
 /// <summary>
 /// App界面Ddl绑定(JS)
 /// </summary>
public const string AppViewDdlBind_0079 = "0079";
 /// <summary>
 /// App界面Ddl适配器(JS)
 /// </summary>
public const string AppViewDdlAdapter_0080 = "0080";
 /// <summary>
 /// App界面ListView头控件脚本(JS)
 /// </summary>
public const string AppViewLvHeadScript_0081 = "0081";
 /// <summary>
 /// 表字段常量(JAVA)
 /// </summary>
public const string TableFldConst_0082 = "0082";
 /// <summary>
 /// 实体扩展层(JAVA)
 /// </summary>
public const string EntityLayerEx_0083 = "0083";
 /// <summary>
 /// App业务逻辑层(JS)
 /// </summary>
public const string AppBusiness_0084 = "0084";
 /// <summary>
 /// WA_访问层(JAVA)
 /// </summary>
public const string WA_Access_0085 = "0085";
 /// <summary>
 /// WA_界面UT(JAVA)
 /// </summary>
public const string WA_ViewUTScript_0086 = "0086";
 /// <summary>
 /// WA_界面UT后台(JAVA)
 /// </summary>
public const string WA_ViewUTScriptCS_0087 = "0087";
 /// <summary>
 /// WA_界面UT_TS(JAVA)
 /// </summary>
public const string WA_ViewUTScript_TS_0088 = "0088";
 /// <summary>
 /// 实体层(JS)
 /// </summary>
public const string EntityLayer_0090 = "0090";
 /// <summary>
 /// 业务逻辑层(JS)
 /// </summary>
public const string BusinessLogic_0091 = "0091";
 /// <summary>
 /// WEB服务访问层(JS)
 /// </summary>
public const string WS_Access_0092 = "0092";
 /// <summary>
 /// Web服务访问高层(Swift4)
 /// </summary>
public const string WS_AccessHigh_0093 = "0093";
 /// <summary>
 /// App控制层(Swift4)
 /// </summary>
public const string AppController_0094 = "0094";
 /// <summary>
 /// App界面UT(Swift4)
 /// </summary>
public const string AppViewUnitTest_0095 = "0095";
 /// <summary>
 /// App界面UT脚本(Swift4)
 /// </summary>
public const string AppViewUTScript_0096 = "0096";
 /// <summary>
 /// App界面UT脚本后台(Swift4)
 /// </summary>
public const string AppViewUTScriptCS_0097 = "0097";
 /// <summary>
 /// App界面脚本内容页(Swift4)
 /// </summary>
public const string AppViewScriptContent_0098 = "0098";
 /// <summary>
 /// App界面脚本后台(Swift4)
 /// </summary>
public const string AppViewScriptCS_0099 = "0099";
 /// <summary>
 /// App界面查询控件脚本(Swift4)
 /// </summary>
public const string AppViewQryScript_0100 = "0100";
 /// <summary>
 /// App界面编辑控件脚本(Swift4)
 /// </summary>
public const string AppViewEdtScript_0101 = "0101";
 /// <summary>
 /// App界面脚本主页(Swift4)
 /// </summary>
public const string AppViewScriptMain_0102 = "0102";
 /// <summary>
 /// App界面ListViewItem控件脚本(Swift4)
 /// </summary>
public const string AppViewLvItemScript_0103 = "0103";
 /// <summary>
 /// App界面ListViewAdapter(Swift4)
 /// </summary>
public const string AppViewListViewAdapter_0104 = "0104";
 /// <summary>
 /// App界面ListView头控件脚本(Swift4)
 /// </summary>
public const string AppViewLvHeadScript_0107 = "0107";
 /// <summary>
 /// 表字段常量(JS)
 /// </summary>
public const string TableFldConst_0108 = "0108";
 /// <summary>
 /// 实体扩展层(JS)
 /// </summary>
public const string EntityLayerEx_0109 = "0109";
 /// <summary>
 /// App业务逻辑层(Swift4)
 /// </summary>
public const string AppBusiness_0110 = "0110";
 /// <summary>
 /// WA_访问层(JS)
 /// </summary>
public const string WA_Access_0111 = "0111";
 /// <summary>
 /// WA_界面UT(Html)
 /// </summary>
public const string WA_ViewUTScript_0112 = "0112";
 /// <summary>
 /// WA_界面UT后台(JS)
 /// </summary>
public const string WA_ViewUTScriptCS_0113 = "0113";
 /// <summary>
 /// 实体层(Swift4)
 /// </summary>
public const string EntityLayer_0116 = "0116";
 /// <summary>
 /// 业务逻辑层(Swift4)
 /// </summary>
public const string BusinessLogic_0117 = "0117";
 /// <summary>
 /// WEB服务访问层(Swift4)
 /// </summary>
public const string WS_Access_0118 = "0118";
 /// <summary>
 /// 实体层(TS)
 /// </summary>
public const string EntityLayer_0121 = "0121";
 /// <summary>
 /// 业务逻辑层(TS)
 /// </summary>
public const string BusinessLogic_0122 = "0122";
 /// <summary>
 /// 表字段常量(Swift4)
 /// </summary>
public const string TableFldConst_0135 = "0135";
 /// <summary>
 /// 实体扩展层(Swift4)
 /// </summary>
public const string EntityLayerEx_0136 = "0136";
 /// <summary>
 /// WA_访问层(Swift4)
 /// </summary>
public const string WA_Access_0138 = "0138";
 /// <summary>
 /// WA_界面UT(Swift4)
 /// </summary>
public const string WA_ViewUTScript_0139 = "0139";
 /// <summary>
 /// WA_界面UT后台(Swift4)
 /// </summary>
public const string WA_ViewUTScriptCS_0140 = "0140";
 /// <summary>
 /// WA_界面UT_TS(Swift4)
 /// </summary>
public const string WA_ViewUTScript_TS_0141 = "0141";
 /// <summary>
 /// WEB服务访问层(Swift3)
 /// </summary>
public const string WS_Access_0143 = "0143";
 /// <summary>
 /// WEB服务访问层(Swift)
 /// </summary>
public const string WS_Access_0144 = "0144";
 /// <summary>
 /// WEB服务访问层(SL)
 /// </summary>
public const string WS_Access_0145 = "0145";
 /// <summary>
 /// 业务逻辑层(Swift3)
 /// </summary>
public const string BusinessLogic_0146 = "0146";
 /// <summary>
 /// 业务逻辑层(Swift)
 /// </summary>
public const string BusinessLogic_0147 = "0147";
 /// <summary>
 /// 业务逻辑层(SL)
 /// </summary>
public const string BusinessLogic_0148 = "0148";
 /// <summary>
 /// App控制层(Swift3)
 /// </summary>
public const string AppController_0149 = "0149";
 /// <summary>
 /// App控制层(Swift)
 /// </summary>
public const string AppController_0150 = "0150";
 /// <summary>
 /// App控制层(SL)
 /// </summary>
public const string AppController_0151 = "0151";
 /// <summary>
 /// 实体层(Swift3)
 /// </summary>
public const string EntityLayer_0152 = "0152";
 /// <summary>
 /// 实体层(Swift)
 /// </summary>
public const string EntityLayer_0153 = "0153";
 /// <summary>
 /// 实体层(SL)
 /// </summary>
public const string EntityLayer_0154 = "0154";
 /// <summary>
 /// WA_访问层(TS)
 /// </summary>
public const string WA_Access_0155 = "0155";
 /// <summary>
 /// Web服务访问高层(Swift3)
 /// </summary>
public const string WS_AccessHigh_0157 = "0157";
 /// <summary>
 /// Web服务访问高层(Swift)
 /// </summary>
public const string WS_AccessHigh_0158 = "0158";
 /// <summary>
 /// Web服务访问高层(SL)
 /// </summary>
public const string WS_AccessHigh_0159 = "0159";
 /// <summary>
 /// App界面UT(Swift3)
 /// </summary>
public const string AppViewUnitTest_0160 = "0160";
 /// <summary>
 /// WA_界面UT后台_TS(TS)
 /// </summary>
public const string WA_ViewUTScriptCS_TS_0161 = "0161";
 /// <summary>
 /// 简化实体层(JAVA)
 /// </summary>
public const string EntityLayer_Sim_0162 = "0162";
 /// <summary>
 /// 简化实体层(Swift)
 /// </summary>
public const string EntityLayer_Sim_0163 = "0163";
 /// <summary>
 /// 简化实体层(Swift3)
 /// </summary>
public const string EntityLayer_Sim_0164 = "0164";
 /// <summary>
 /// 简化实体层(Swift4)
 /// </summary>
public const string EntityLayer_Sim_0165 = "0165";
 /// <summary>
 /// 简化实体层(JS)
 /// </summary>
public const string EntityLayer_Sim_0166 = "0166";
 /// <summary>
 /// 简化实体层(SL)
 /// </summary>
public const string EntityLayer_Sim_0167 = "0167";
 /// <summary>
 /// Win界面层_QD_Gv(CS)
 /// </summary>
public const string WinViewCode_QD_Gv_0168 = "0168";
 /// <summary>
 /// Win界面层_QD_Gv_设计(CS)
 /// </summary>
public const string WinViewCode_QD_Gv_Design_0169 = "0169";
 /// <summary>
 /// WA_界面后台(老)_TS(TS)
 /// </summary>
public const string WA_ViewScriptCS_Old_TS_0170 = "0170";
 /// <summary>
 /// WA_界面脚本_TS(Html)
 /// </summary>
public const string WA_ViewScript_TS_0171 = "0171";
 /// <summary>
 /// WA_访问高层(JAVA)
 /// </summary>
public const string WA_AccessHigh_0172 = "0172";
 /// <summary>
 /// WA_App控制层(JAVA)
 /// </summary>
public const string WA_AppController_0173 = "0173";
 /// <summary>
 /// WA_App界面UT(JAVA)
 /// </summary>
public const string WA_AppViewUT_0174 = "0174";
 /// <summary>
 /// WA_App界面UT脚本(JAVA)
 /// </summary>
public const string WA_AppViewUTScript_0175 = "0175";
 /// <summary>
 /// WA_App界面UT脚本后台(JAVA)
 /// </summary>
public const string WA_AppViewUTScriptCS_0176 = "0176";
 /// <summary>
 /// 简化实体层(TS)
 /// </summary>
public const string EntityLayer_Sim_0177 = "0177";
 /// <summary>
 /// Mvc控制层(CS)
 /// </summary>
public const string Mvc_Controller_0178 = "0178";
 /// <summary>
 /// Mvc界面-编辑区(CS)
 /// </summary>
public const string Mvc_View_Edit_0179 = "0179";
 /// <summary>
 /// Mvc界面-查询区(CS)
 /// </summary>
public const string Mvc_View_Query_0180 = "0180";
 /// <summary>
 /// Mvc界面-编辑区Ajax(CS)
 /// </summary>
public const string Mvc_View_EditAjax_0181 = "0181";
 /// <summary>
 /// Mvc界面-查询区Ajax(CS)
 /// </summary>
public const string Mvc_View_QueryAjax_0182 = "0182";
 /// <summary>
 /// Mvc列表模型(CS)
 /// </summary>
public const string Mvc_Model_List_0183 = "0183";
 /// <summary>
 /// Mvc编辑模型(CS)
 /// </summary>
public const string Mvc_Model_Edit_0184 = "0184";
 /// <summary>
 /// WA_服务扩展层(CS)
 /// </summary>
public const string WA_SrvEx_0185 = "0185";
 /// <summary>
 /// WA_访问扩展层(CS)
 /// </summary>
public const string WA_AccessEx_0186 = "0186";
 /// <summary>
 /// Mvc功能区模型(CS)
 /// </summary>
public const string Mvc_Model_Feature_0187 = "0187";
 /// <summary>
 /// WA_界面后台模型_TS(CS)
 /// </summary>
public const string WA_ViewScriptCSModel_TS_0188 = "0188";
 /// <summary>
 /// WA_界面后台Ex_TS(TS)
 /// </summary>
public const string WA_ViewScriptCSEx_TS_0189 = "0189";
 /// <summary>
 /// WA_访问扩展层(TS)
 /// </summary>
public const string WA_AccessEx_0190 = "0190";
 /// <summary>
 /// 实体扩展层(TS)
 /// </summary>
public const string EntityLayerEx_0191 = "0191";
 /// <summary>
 /// 纯粹类(CS)
 /// </summary>
public const string PureClass_0192 = "0192";
 /// <summary>
 /// 纯粹类处理层(CS)
 /// </summary>
public const string PureClassAccess_0193 = "0193";
 /// <summary>
 /// 静态业务逻辑扩展层(CS)
 /// </summary>
public const string BusinessLogicEx_Static_0194 = "0194";
 /// <summary>
 /// 静态业务逻辑层(CS)
 /// </summary>
public const string BusinessLogic_Static_0195 = "0195";
 /// <summary>
 /// WA_访问层公共函数类扩展(CS)
 /// </summary>
public const string CommFun4WA_0196 = "0196";
 /// <summary>
 /// 结点实体层(CS)
 /// </summary>
public const string NodeEntityLayer_0197 = "0197";
 /// <summary>
 /// 结点数据处理层(CS)
 /// </summary>
public const string NodeDALCode_0198 = "0198";
 /// <summary>
 /// 结点业务逻辑层(CS)
 /// </summary>
public const string NodeBusinessLogic_0199 = "0199";
 /// <summary>
 /// 结点Web界面后台(CS)
 /// </summary>
public const string NodeWVCCode_0200 = "0200";
 /// <summary>
 /// 结点WEB界面脚本(Html)
 /// </summary>
public const string NodeWVCode_0201 = "0201";
 /// <summary>
 /// 关系Web用户控件前台脚本(Html)
 /// </summary>
public const string RelaWCVCode_0202 = "0202";
 /// <summary>
 /// 结点Web用户控件后台(CS)
 /// </summary>
public const string NodeWCCCode_0203 = "0203";
 /// <summary>
 /// 结点Web用户Gv控件前台脚本(Html)
 /// </summary>
public const string NodeWCVCode4Gv_0204 = "0204";
 /// <summary>
 /// 结点Web用户Gv控件后台(CS)
 /// </summary>
public const string NodeWCCCode4Gv_0205 = "0205";
 /// <summary>
 /// 结点实体扩展层(CS)
 /// </summary>
public const string NodeEntityLayerEx_0206 = "0206";
 /// <summary>
 /// 结点数据处理扩展层(CS)
 /// </summary>
public const string NodeDALExCode_0207 = "0207";
 /// <summary>
 /// 结点业务逻辑扩展层(CS)
 /// </summary>
public const string NodeBusinessLogicEx_0208 = "0208";
 /// <summary>
 /// 结点WA_服务层(CS)
 /// </summary>
public const string NodeWA_Srv_0209 = "0209";
 /// <summary>
 /// 结点WA_服务扩展层(CS)
 /// </summary>
public const string NodeWA_SrvEx_0210 = "0210";
 /// <summary>
 /// 结点WA_访问层(CS)
 /// </summary>
public const string NodeWA_Access_0211 = "0211";
 /// <summary>
 /// 结点WA_访问扩展层(CS)
 /// </summary>
public const string NodeWA_AccessEx_0212 = "0212";
 /// <summary>
 /// 关系实体层(CS)
 /// </summary>
public const string RelaEntityLayer_0213 = "0213";
 /// <summary>
 /// 关系实体扩展层(CS)
 /// </summary>
public const string RelaEntityLayerEx_0214 = "0214";
 /// <summary>
 /// 关系数据处理层(CS)
 /// </summary>
public const string RelaDALCode_0215 = "0215";
 /// <summary>
 /// 关系数据处理扩展层(CS)
 /// </summary>
public const string RelaDALExCode_0216 = "0216";
 /// <summary>
 /// 关系业务逻辑层(CS)
 /// </summary>
public const string RelaBusinessLogic_0217 = "0217";
 /// <summary>
 /// 关系业务逻辑扩展层(CS)
 /// </summary>
public const string RelaBusinessLogicEx_0218 = "0218";
 /// <summary>
 /// 关系WA_服务层(CS)
 /// </summary>
public const string RelaWA_Srv_0219 = "0219";
 /// <summary>
 /// 关系WA_服务扩展层(CS)
 /// </summary>
public const string RelaWA_SrvEx_0220 = "0220";
 /// <summary>
 /// 关系WA_访问层(CS)
 /// </summary>
public const string RelaWA_Access_0221 = "0221";
 /// <summary>
 /// 关系WA_访问扩展层(CS)
 /// </summary>
public const string RelaWA_AccessEx_0222 = "0222";
 /// <summary>
 /// 关系WEB界面前台脚本(Html)
 /// </summary>
public const string RelaWVCode_0223 = "0223";
 /// <summary>
 /// 关系Web界面后台(CS)
 /// </summary>
public const string RelaWVCCode_0224 = "0224";
 /// <summary>
 /// 关系Web用户控件后台(CS)
 /// </summary>
public const string RelaWCCCode_0225 = "0225";
 /// <summary>
 /// 关系Web用户Gv控件前台脚本(Html)
 /// </summary>
public const string RelaWCVCode4Gv_0226 = "0226";
 /// <summary>
 /// 关系Web用户Gv控件后台(CS)
 /// </summary>
public const string RelaWCCCode4Gv_0227 = "0227";
 /// <summary>
 /// 结点Web用户控件前台脚本(Html)
 /// </summary>
public const string NodeWCVCode_0228 = "0228";
 /// <summary>
 /// WA_访问层公共函数类扩展(TS)
 /// </summary>
public const string CommFun4WA_0229 = "0229";
 /// <summary>
 /// WA_访问扩展层(JS)
 /// </summary>
public const string WA_AccessEx_0230 = "0230";
 /// <summary>
 /// WA_界面UT后台RJ(JS)
 /// </summary>
public const string WA_ViewUTScriptCSRJ_0231 = "0231";
 /// <summary>
 /// WA_访问层RJ(JS)
 /// </summary>
public const string WA_AccessRJ_0232 = "0232";
 /// <summary>
 /// 实体层RJ(JS)
 /// </summary>
public const string EntityLayerRJ_0233 = "0233";
 /// <summary>
 /// 实体扩展层RJ(JS)
 /// </summary>
public const string EntityLayerRJEx_0234 = "0234";
 /// <summary>
 /// 简化实体层RJ(JS)
 /// </summary>
public const string EntityLayerRJ_Sim_0235 = "0235";
 /// <summary>
 /// 业务逻辑层RJ(JS)
 /// </summary>
public const string BusinessLogicRJ_0236 = "0236";
 /// <summary>
 /// WA_访问公共函数扩展(JS)
 /// </summary>
public const string CommFun4WARJ_0237 = "0237";
 /// <summary>
 /// WA_界面脚本_JS(Html)
 /// </summary>
public const string WA_ViewScript_JS_0238 = "0238";
 /// <summary>
 /// WA_界面后台_JS(JS)
 /// </summary>
public const string WA_ViewScriptCS_JS_0239 = "0239";
 /// <summary>
 /// WA_界面后台Ex_JS(JS)
 /// </summary>
public const string WA_ViewScriptCSEx_JS_0240 = "0240";
 /// <summary>
 /// WA_访问扩展层RJ(JS)
 /// </summary>
public const string WA_AccessRJEx_0241 = "0241";
 /// <summary>
 /// WA_编辑区_JS(Html)
 /// </summary>
public const string WA_ViewScript_Edit_JS_0242 = "0242";
 /// <summary>
 /// WA_编辑区_TS(Html)
 /// </summary>
public const string WA_ViewScript_Edit_TS_0243 = "0243";
 /// <summary>
 /// WA_详细信息_TS(Html)
 /// </summary>
public const string WA_ViewScript_Detail_TS_0244 = "0244";
 /// <summary>
 /// 纯粹类(TS)
 /// </summary>
public const string PureClass_0245 = "0245";
 /// <summary>
 /// 纯粹类处理层(TS)
 /// </summary>
public const string PureClassAccess_0246 = "0246";
 /// <summary>
 /// Copy_纯粹类(TS)
 /// </summary>
public const string PureClass_0247 = "0247";
 /// <summary>
 /// WA_编辑区后台_TS(TS)
 /// </summary>
public const string WA_ViewScript_EditCS_TS_0248 = "0248";
 /// <summary>
 /// WA_编辑区后台Ex_TS(TS)
 /// </summary>
public const string WA_ViewScript_EditCSEx_TS_0249 = "0249";
 /// <summary>
 /// WA_界面后台_TS(TS)
 /// </summary>
public const string WA_ViewScriptCS_TS_0250 = "0250";
 /// <summary>
 /// WA_详细信息后台_TS(TS)
 /// </summary>
public const string WA_ViewScript_DetailCS_TS_0251 = "0251";
 /// <summary>
 /// WA_详细信息后台Ex_TS(TS)
 /// </summary>
public const string WA_ViewScript_DetailCSEx_TS_0252 = "0252";
 /// <summary>
 /// Vue_界面脚本_TS(Html)
 /// </summary>
public const string Vue_ViewScript_TS_0253 = "0253";
 /// <summary>
 /// Vue_界面后台_TS(TS)
 /// </summary>
public const string Vue_ViewScriptCS_TS_0254 = "0254";
 /// <summary>
 /// Vue_界面后台Ex_TS(TS)
 /// </summary>
public const string Vue_ViewScriptCSEx_TS_0255 = "0255";
 /// <summary>
 /// Vue_编辑区_TS(Html)
 /// </summary>
public const string Vue_ViewScript_Edit_TS_0256 = "0256";
 /// <summary>
 /// Vue_编辑区后台_TS(TS)
 /// </summary>
public const string Vue_ViewScript_EditCS_TS_0257 = "0257";
 /// <summary>
 /// Vue_编辑区后台Ex_TS(TS)
 /// </summary>
public const string Vue_ViewScript_EditCSEx_TS_0258 = "0258";
 /// <summary>
 /// Vue_详细信息_TS(Html)
 /// </summary>
public const string Vue_ViewScript_Detail_TS_0259 = "0259";
 /// <summary>
 /// Vue_详细信息后台_TS(TS)
 /// </summary>
public const string Vue_ViewScript_DetailCS_TS_0260 = "0260";
 /// <summary>
 /// Vue_详细信息后台Ex_TS(TS)
 /// </summary>
public const string Vue_ViewScript_DetailCSEx_TS_0261 = "0261";
 /// <summary>
 /// 实体层Store(TS)
 /// </summary>
public const string StoreEntityLayer_0262 = "0262";
 /// <summary>
 /// Vue_列表区_TS(Html)
 /// </summary>
public const string Vue_ViewScript_List_TS_0263 = "0263";
 /// <summary>
 /// Vue共享(TS)
 /// </summary>
public const string Vue_Share_TS_0264 = "0264";
}
 /// <summary>
 /// 代码类型(CodeType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCodeTypeWApi
{
private static readonly string mstrApiControllerName = "CodeTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCodeTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CodeTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[代码类型]...","0");
List<clsCodeTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CodeTypeId";
objDDL.DataTextField="CodeTypeName";
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

 /// <param name = "strProgLangTypeId"></param>
public static void BindCbo_CodeTypeId(System.Windows.Forms.ComboBox objComboBox , string strProgLangTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCodeType.CodeTypeId); 
List<clsCodeTypeEN> arrObjLst = clsCodeTypeWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.ProgLangTypeId == strProgLangTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN()
{
CodeTypeId = "0",
CodeTypeName = "选[代码类型]..."
};
arrObjLstSel.Insert(0, objCodeTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCodeType.CodeTypeId;
objComboBox.DisplayMember = conCodeType.CodeTypeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCodeTypeEN objCodeTypeEN)
{
if (!Object.Equals(null, objCodeTypeEN.CodeTypeId) && GetStrLen(objCodeTypeEN.CodeTypeId) > 4)
{
 throw new Exception("字段[代码类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCodeTypeEN.CodeTypeName) && GetStrLen(objCodeTypeEN.CodeTypeName) > 50)
{
 throw new Exception("字段[代码类型名]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeTypeEN.CodeTypeSimName) && GetStrLen(objCodeTypeEN.CodeTypeSimName) > 50)
{
 throw new Exception("字段[简称]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeTypeEN.CodeTypeENName) && GetStrLen(objCodeTypeEN.CodeTypeENName) > 50)
{
 throw new Exception("字段[代码类型英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeTypeEN.GroupName) && GetStrLen(objCodeTypeEN.GroupName) > 30)
{
 throw new Exception("字段[组名]的长度不能超过30!");
}
if (!Object.Equals(null, objCodeTypeEN.ProgLangTypeId) && GetStrLen(objCodeTypeEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCodeTypeEN.RegionTypeId) && GetStrLen(objCodeTypeEN.RegionTypeId) > 4)
{
 throw new Exception("字段[区域类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCodeTypeEN.Prefix) && GetStrLen(objCodeTypeEN.Prefix) > 10)
{
 throw new Exception("字段[前缀]的长度不能超过10!");
}
if (!Object.Equals(null, objCodeTypeEN.DependsOn) && GetStrLen(objCodeTypeEN.DependsOn) > 50)
{
 throw new Exception("字段[依赖于]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeTypeEN.FrontOrBack) && GetStrLen(objCodeTypeEN.FrontOrBack) > 50)
{
 throw new Exception("字段[前台Or后台]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeTypeEN.SqlDsTypeId) && GetStrLen(objCodeTypeEN.SqlDsTypeId) > 2)
{
 throw new Exception("字段[数据源类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCodeTypeEN.ClassNameFormat) && GetStrLen(objCodeTypeEN.ClassNameFormat) > 50)
{
 throw new Exception("字段[类名格式]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeTypeEN.FileNameFormat) && GetStrLen(objCodeTypeEN.FileNameFormat) > 50)
{
 throw new Exception("字段[文件名格式]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeTypeEN.ClassNamePattern) && GetStrLen(objCodeTypeEN.ClassNamePattern) > 50)
{
 throw new Exception("字段[类名模式]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeTypeEN.WinOrWeb) && GetStrLen(objCodeTypeEN.WinOrWeb) > 50)
{
 throw new Exception("字段[WinOrWeb]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeTypeEN.UpdDate) && GetStrLen(objCodeTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCodeTypeEN.UpdUser) && GetStrLen(objCodeTypeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCodeTypeEN.Memo) && GetStrLen(objCodeTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objCodeTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeTypeEN GetObjByCodeTypeId(string strCodeTypeId)
{
if (strCodeTypeId == "") return null;
string strAction = "GetObjByCodeTypeId";
clsCodeTypeEN objCodeTypeEN;
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
objCodeTypeEN = JsonConvert.DeserializeObject<clsCodeTypeEN>(strJson);
return objCodeTypeEN;
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
public static clsCodeTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCodeTypeEN objCodeTypeEN;
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
objCodeTypeEN = JsonConvert.DeserializeObject<clsCodeTypeEN>(strJson);
return objCodeTypeEN;
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
//该表没有使用Cache,不需要生成[GetCodeTypeNameByCodeTypeIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeTypeEN> GetObjLst(string strWhereCond)
{
 List<clsCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeTypeEN>>(strJson);
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
public static List<clsCodeTypeEN> GetObjLstByCodeTypeIdLst(List<string> arrCodeTypeId)
{
 List<clsCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeTypeEN>>(strJson);
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
public static List<clsCodeTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeTypeEN>>(strJson);
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
public static List<clsCodeTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeTypeEN>>(strJson);
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
public static List<clsCodeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeTypeEN>>(strJson);
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
public static List<clsCodeTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeTypeEN>>(strJson);
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
public static int DelRecord(string strCodeTypeId)
{
string strAction = "DelRecord";
try
{
 clsCodeTypeEN objCodeTypeEN = clsCodeTypeWApi.GetObjByCodeTypeId(strCodeTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCodeTypeId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelCodeTypes(List<string> arrCodeTypeId)
{
string strAction = "DelCodeTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCodeTypeId);
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
public static int DelCodeTypesByCond(string strWhereCond)
{
string strAction = "DelCodeTypesByCond";
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
public static bool AddNewRecord(clsCodeTypeEN objCodeTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCodeTypeEN>(objCodeTypeEN);
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
public static string AddNewRecordWithMaxId(clsCodeTypeEN objCodeTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCodeTypeEN>(objCodeTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strCodeTypeId = (string)jobjReturn0["returnStr"];
return strCodeTypeId;
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
public static bool UpdateRecord(clsCodeTypeEN objCodeTypeEN)
{
if (string.IsNullOrEmpty(objCodeTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCodeTypeEN.CodeTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCodeTypeEN>(objCodeTypeEN);
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
 /// <param name = "objCodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCodeTypeEN objCodeTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCodeTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCodeTypeEN.CodeTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCodeTypeEN.CodeTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCodeTypeEN>(objCodeTypeEN);
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
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
 public static void CopyTo(clsCodeTypeEN objCodeTypeENS, clsCodeTypeEN objCodeTypeENT)
{
try
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SqlDsTypeId = objCodeTypeENS.SqlDsTypeId; //数据源类型Id
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //序号
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改者
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsCodeTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCodeTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCodeTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCodeTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCodeTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCodeTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
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
if (clsCodeTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCodeTypeWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsCodeTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCodeType.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.CodeTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.Prefix, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.DependsOn, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.FrontOrBack, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.ClassNameFormat, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.FileNameFormat, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.ClassNamePattern, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.IsCSharp, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsJava, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsJavaScript, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsTypeScript, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsSilverLight, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsSwift, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsVB, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsTableFldConst, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsPubApp4WinWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsAspMvc, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsWebSrvAccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsWin, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsMobileApp, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsExtend, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCodeType.WinOrWeb, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.IsDirByTabName, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsDefaultOverride, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.IsAutoParseFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCodeType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCodeType.Memo, Type.GetType("System.String"));
foreach (clsCodeTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCodeType.CodeTypeId] = objInFor[conCodeType.CodeTypeId];
objDR[conCodeType.CodeTypeName] = objInFor[conCodeType.CodeTypeName];
objDR[conCodeType.CodeTypeSimName] = objInFor[conCodeType.CodeTypeSimName];
objDR[conCodeType.CodeTypeENName] = objInFor[conCodeType.CodeTypeENName];
objDR[conCodeType.GroupName] = objInFor[conCodeType.GroupName];
objDR[conCodeType.ProgLangTypeId] = objInFor[conCodeType.ProgLangTypeId];
objDR[conCodeType.RegionTypeId] = objInFor[conCodeType.RegionTypeId];
objDR[conCodeType.Prefix] = objInFor[conCodeType.Prefix];
objDR[conCodeType.DependsOn] = objInFor[conCodeType.DependsOn];
objDR[conCodeType.FrontOrBack] = objInFor[conCodeType.FrontOrBack];
objDR[conCodeType.SqlDsTypeId] = objInFor[conCodeType.SqlDsTypeId];
objDR[conCodeType.ClassNameFormat] = objInFor[conCodeType.ClassNameFormat];
objDR[conCodeType.FileNameFormat] = objInFor[conCodeType.FileNameFormat];
objDR[conCodeType.ClassNamePattern] = objInFor[conCodeType.ClassNamePattern];
objDR[conCodeType.IsCSharp] = objInFor[conCodeType.IsCSharp];
objDR[conCodeType.IsJava] = objInFor[conCodeType.IsJava];
objDR[conCodeType.IsJavaScript] = objInFor[conCodeType.IsJavaScript];
objDR[conCodeType.IsTypeScript] = objInFor[conCodeType.IsTypeScript];
objDR[conCodeType.IsSilverLight] = objInFor[conCodeType.IsSilverLight];
objDR[conCodeType.IsSwift] = objInFor[conCodeType.IsSwift];
objDR[conCodeType.IsVB] = objInFor[conCodeType.IsVB];
objDR[conCodeType.IsTableFldConst] = objInFor[conCodeType.IsTableFldConst];
objDR[conCodeType.IsPubApp4WinWeb] = objInFor[conCodeType.IsPubApp4WinWeb];
objDR[conCodeType.IsWeb] = objInFor[conCodeType.IsWeb];
objDR[conCodeType.IsAspMvc] = objInFor[conCodeType.IsAspMvc];
objDR[conCodeType.IsWebSrvAccess] = objInFor[conCodeType.IsWebSrvAccess];
objDR[conCodeType.IsWin] = objInFor[conCodeType.IsWin];
objDR[conCodeType.IsMobileApp] = objInFor[conCodeType.IsMobileApp];
objDR[conCodeType.IsExtend] = objInFor[conCodeType.IsExtend];
objDR[conCodeType.OrderNum] = objInFor[conCodeType.OrderNum];
objDR[conCodeType.WinOrWeb] = objInFor[conCodeType.WinOrWeb];
objDR[conCodeType.IsDirByTabName] = objInFor[conCodeType.IsDirByTabName];
objDR[conCodeType.IsDefaultOverride] = objInFor[conCodeType.IsDefaultOverride];
objDR[conCodeType.InUse] = objInFor[conCodeType.InUse];
objDR[conCodeType.IsAutoParseFile] = objInFor[conCodeType.IsAutoParseFile];
objDR[conCodeType.UpdDate] = objInFor[conCodeType.UpdDate];
objDR[conCodeType.UpdUser] = objInFor[conCodeType.UpdUser];
objDR[conCodeType.Memo] = objInFor[conCodeType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 代码类型(CodeType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CodeType : clsCommFun4BL
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
clsCodeTypeWApi.ReFreshThisCache();
}
}

}