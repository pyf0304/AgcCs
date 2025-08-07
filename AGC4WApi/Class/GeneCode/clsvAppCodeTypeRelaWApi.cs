
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppCodeTypeRelaWApi
 表名:vAppCodeTypeRela(00050419)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:00
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
public static class  clsvAppCodeTypeRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetmId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, long lngmId, string strComparisonOp="")
	{
objvAppCodeTypeRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.mId) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.mId, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.mId] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetApplicationTypeId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convAppCodeTypeRela.ApplicationTypeId);
objvAppCodeTypeRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.ApplicationTypeId) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetApplicationTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convAppCodeTypeRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convAppCodeTypeRela.ApplicationTypeName);
objvAppCodeTypeRelaEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.ApplicationTypeName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.ApplicationTypeName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.ApplicationTypeName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetApplicationTypeENName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convAppCodeTypeRela.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convAppCodeTypeRela.ApplicationTypeENName);
objvAppCodeTypeRelaEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.ApplicationTypeENName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.ApplicationTypeENName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.ApplicationTypeENName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetCodeTypeId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convAppCodeTypeRela.CodeTypeId);
objvAppCodeTypeRelaEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.CodeTypeId) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.CodeTypeId, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.CodeTypeId] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetCodeTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convAppCodeTypeRela.CodeTypeName);
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convAppCodeTypeRela.CodeTypeName);
objvAppCodeTypeRelaEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.CodeTypeName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.CodeTypeName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.CodeTypeName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeSimName">简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetCodeTypeSimName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convAppCodeTypeRela.CodeTypeSimName);
objvAppCodeTypeRelaEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.CodeTypeSimName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.CodeTypeSimName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.CodeTypeSimName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeENName">代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetCodeTypeENName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convAppCodeTypeRela.CodeTypeENName);
objvAppCodeTypeRelaEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.CodeTypeENName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.CodeTypeENName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.CodeTypeENName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetGroupName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convAppCodeTypeRela.GroupName);
clsCheckSql.CheckFieldLen(strGroupName, 30, convAppCodeTypeRela.GroupName);
objvAppCodeTypeRelaEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.GroupName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.GroupName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.GroupName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetProgLangTypeId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convAppCodeTypeRela.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convAppCodeTypeRela.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convAppCodeTypeRela.ProgLangTypeId);
objvAppCodeTypeRelaEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.ProgLangTypeId) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.ProgLangTypeId, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.ProgLangTypeId] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetProgLangTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convAppCodeTypeRela.ProgLangTypeName);
objvAppCodeTypeRelaEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.ProgLangTypeName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.ProgLangTypeName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.ProgLangTypeName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeSimName">编程语言类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetProgLangTypeSimName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convAppCodeTypeRela.ProgLangTypeSimName);
objvAppCodeTypeRelaEN.ProgLangTypeSimName = strProgLangTypeSimName; //编程语言类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.ProgLangTypeSimName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.ProgLangTypeSimName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.ProgLangTypeSimName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetRegionTypeId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convAppCodeTypeRela.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convAppCodeTypeRela.RegionTypeId);
objvAppCodeTypeRelaEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.RegionTypeId) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.RegionTypeId, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.RegionTypeId] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeName">区域类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetRegionTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convAppCodeTypeRela.RegionTypeName);
objvAppCodeTypeRelaEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.RegionTypeName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.RegionTypeName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.RegionTypeName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDependsOn">依赖于</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetDependsOn(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strDependsOn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDependsOn, 50, convAppCodeTypeRela.DependsOn);
objvAppCodeTypeRelaEN.DependsOn = strDependsOn; //依赖于
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.DependsOn) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.DependsOn, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.DependsOn] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFrontOrBack">前台Or后台</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetFrontOrBack(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strFrontOrBack, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFrontOrBack, 50, convAppCodeTypeRela.FrontOrBack);
objvAppCodeTypeRelaEN.FrontOrBack = strFrontOrBack; //前台Or后台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.FrontOrBack) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.FrontOrBack, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.FrontOrBack] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intAppCount">应用数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetAppCount(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, int intAppCount, string strComparisonOp="")
	{
objvAppCodeTypeRelaEN.AppCount = intAppCount; //应用数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.AppCount) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.AppCount, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.AppCount] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intViewTypeCode">界面类型码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetViewTypeCode(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, int intViewTypeCode, string strComparisonOp="")
	{
objvAppCodeTypeRelaEN.ViewTypeCode = intViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.ViewTypeCode) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.ViewTypeCode, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.ViewTypeCode] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewTypeName">界面类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetViewTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strViewTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewTypeName, 40, convAppCodeTypeRela.ViewTypeName);
objvAppCodeTypeRelaEN.ViewTypeName = strViewTypeName; //界面类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.ViewTypeName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.ViewTypeName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.ViewTypeName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeId">表主类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetTabMainTypeId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strTabMainTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, convAppCodeTypeRela.TabMainTypeId);
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, convAppCodeTypeRela.TabMainTypeId);
objvAppCodeTypeRelaEN.TabMainTypeId = strTabMainTypeId; //表主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.TabMainTypeId) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.TabMainTypeId, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.TabMainTypeId] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeName">表主类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetTabMainTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strTabMainTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabMainTypeName, 30, convAppCodeTypeRela.TabMainTypeName);
objvAppCodeTypeRelaEN.TabMainTypeName = strTabMainTypeName; //表主类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.TabMainTypeName) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.TabMainTypeName, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.TabMainTypeName] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetIsVisible(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, bool bolIsVisible, string strComparisonOp="")
	{
objvAppCodeTypeRelaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.IsVisible) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.IsVisible, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.IsVisible] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsInGroupGeneCode">是否参与组生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetIsInGroupGeneCode(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, bool bolIsInGroupGeneCode, string strComparisonOp="")
	{
objvAppCodeTypeRelaEN.IsInGroupGeneCode = bolIsInGroupGeneCode; //是否参与组生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.IsInGroupGeneCode) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.IsInGroupGeneCode, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.IsInGroupGeneCode] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetOrderNum(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convAppCodeTypeRela.OrderNum);
objvAppCodeTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.OrderNum) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.OrderNum, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.OrderNum] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetUpdDate(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convAppCodeTypeRela.UpdDate);
objvAppCodeTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.UpdDate) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.UpdDate, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.UpdDate] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetUpdUser(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convAppCodeTypeRela.UpdUser);
objvAppCodeTypeRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.UpdUser) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.UpdUser, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.UpdUser] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetMemo(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convAppCodeTypeRela.Memo);
objvAppCodeTypeRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(convAppCodeTypeRela.Memo) == false)
{
objvAppCodeTypeRelaEN.dicFldComparisonOp.Add(convAppCodeTypeRela.Memo, strComparisonOp);
}
else
{
objvAppCodeTypeRelaEN.dicFldComparisonOp[convAppCodeTypeRela.Memo] = strComparisonOp;
}
}
return objvAppCodeTypeRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.mId) == true)
{
string strComparisonOpmId = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convAppCodeTypeRela.mId, objvAppCodeTypeRelaCond.mId, strComparisonOpmId);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convAppCodeTypeRela.ApplicationTypeId, objvAppCodeTypeRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.ApplicationTypeName, objvAppCodeTypeRelaCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.ApplicationTypeENName, objvAppCodeTypeRelaCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.CodeTypeId, objvAppCodeTypeRelaCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.CodeTypeName, objvAppCodeTypeRelaCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.CodeTypeSimName) == true)
{
string strComparisonOpCodeTypeSimName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.CodeTypeSimName, objvAppCodeTypeRelaCond.CodeTypeSimName, strComparisonOpCodeTypeSimName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.CodeTypeENName, objvAppCodeTypeRelaCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.GroupName) == true)
{
string strComparisonOpGroupName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.GroupName, objvAppCodeTypeRelaCond.GroupName, strComparisonOpGroupName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.ProgLangTypeId, objvAppCodeTypeRelaCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.ProgLangTypeName, objvAppCodeTypeRelaCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.ProgLangTypeSimName) == true)
{
string strComparisonOpProgLangTypeSimName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.ProgLangTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.ProgLangTypeSimName, objvAppCodeTypeRelaCond.ProgLangTypeSimName, strComparisonOpProgLangTypeSimName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.RegionTypeId, objvAppCodeTypeRelaCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.RegionTypeName, objvAppCodeTypeRelaCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.DependsOn) == true)
{
string strComparisonOpDependsOn = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.DependsOn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.DependsOn, objvAppCodeTypeRelaCond.DependsOn, strComparisonOpDependsOn);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.FrontOrBack) == true)
{
string strComparisonOpFrontOrBack = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.FrontOrBack];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.FrontOrBack, objvAppCodeTypeRelaCond.FrontOrBack, strComparisonOpFrontOrBack);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.AppCount) == true)
{
string strComparisonOpAppCount = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.AppCount];
strWhereCond += string.Format(" And {0} {2} {1}", convAppCodeTypeRela.AppCount, objvAppCodeTypeRelaCond.AppCount, strComparisonOpAppCount);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} {1}", convAppCodeTypeRela.ViewTypeCode, objvAppCodeTypeRelaCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.ViewTypeName) == true)
{
string strComparisonOpViewTypeName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.ViewTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.ViewTypeName, objvAppCodeTypeRelaCond.ViewTypeName, strComparisonOpViewTypeName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.TabMainTypeId) == true)
{
string strComparisonOpTabMainTypeId = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.TabMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.TabMainTypeId, objvAppCodeTypeRelaCond.TabMainTypeId, strComparisonOpTabMainTypeId);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.TabMainTypeName) == true)
{
string strComparisonOpTabMainTypeName = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.TabMainTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.TabMainTypeName, objvAppCodeTypeRelaCond.TabMainTypeName, strComparisonOpTabMainTypeName);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.IsVisible) == true)
{
if (objvAppCodeTypeRelaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAppCodeTypeRela.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAppCodeTypeRela.IsVisible);
}
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.IsInGroupGeneCode) == true)
{
if (objvAppCodeTypeRelaCond.IsInGroupGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAppCodeTypeRela.IsInGroupGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAppCodeTypeRela.IsInGroupGeneCode);
}
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convAppCodeTypeRela.OrderNum, objvAppCodeTypeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.UpdDate, objvAppCodeTypeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.UpdUser, objvAppCodeTypeRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvAppCodeTypeRelaCond.IsUpdated(convAppCodeTypeRela.Memo) == true)
{
string strComparisonOpMemo = objvAppCodeTypeRelaCond.dicFldComparisonOp[convAppCodeTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppCodeTypeRela.Memo, objvAppCodeTypeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v应用程序代码类型关系(vAppCodeTypeRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvAppCodeTypeRelaWApi
{
private static readonly string mstrApiControllerName = "vAppCodeTypeRelaApi";

 public clsvAppCodeTypeRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAppCodeTypeRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvAppCodeTypeRelaEN = JsonConvert.DeserializeObject<clsvAppCodeTypeRelaEN>(strJson);
return objvAppCodeTypeRelaEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvAppCodeTypeRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN;
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
objvAppCodeTypeRelaEN = JsonConvert.DeserializeObject<clsvAppCodeTypeRelaEN>(strJson);
return objvAppCodeTypeRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAppCodeTypeRelaEN GetObjBymIdCache(long lngmId,int intApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvAppCodeTypeRelaEN._CurrTabName, intApplicationTypeId);
List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLstCache = GetObjLstCache(intApplicationTypeId);
IEnumerable <clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLst_Sel =
from objvAppCodeTypeRelaEN in arrvAppCodeTypeRelaObjLstCache
where objvAppCodeTypeRelaEN.mId == lngmId 
select objvAppCodeTypeRelaEN;
if (arrvAppCodeTypeRelaObjLst_Sel.Count() == 0)
{
   clsvAppCodeTypeRelaEN obj = clsvAppCodeTypeRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvAppCodeTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppCodeTypeRelaEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvAppCodeTypeRelaEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppCodeTypeRelaEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvAppCodeTypeRelaEN> GetObjLstByMIdLstCache(List<long> arrMId, int intApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvAppCodeTypeRelaEN._CurrTabName, intApplicationTypeId);
List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLstCache = GetObjLstCache(intApplicationTypeId);
IEnumerable <clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLst_Sel =
from objvAppCodeTypeRelaEN in arrvAppCodeTypeRelaObjLstCache
where arrMId.Contains(objvAppCodeTypeRelaEN.mId)
select objvAppCodeTypeRelaEN;
return arrvAppCodeTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppCodeTypeRelaEN>>(strJson);
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
public static List<clsvAppCodeTypeRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppCodeTypeRelaEN>>(strJson);
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
public static List<clsvAppCodeTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppCodeTypeRelaEN>>(strJson);
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
public static List<clsvAppCodeTypeRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppCodeTypeRelaEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvAppCodeTypeRelaENS">源对象</param>
 /// <param name = "objvAppCodeTypeRelaENT">目标对象</param>
 public static void CopyTo(clsvAppCodeTypeRelaEN objvAppCodeTypeRelaENS, clsvAppCodeTypeRelaEN objvAppCodeTypeRelaENT)
{
try
{
objvAppCodeTypeRelaENT.mId = objvAppCodeTypeRelaENS.mId; //mId
objvAppCodeTypeRelaENT.ApplicationTypeId = objvAppCodeTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objvAppCodeTypeRelaENT.ApplicationTypeName = objvAppCodeTypeRelaENS.ApplicationTypeName; //应用程序类型名称
objvAppCodeTypeRelaENT.ApplicationTypeENName = objvAppCodeTypeRelaENS.ApplicationTypeENName; //应用类型英文名
objvAppCodeTypeRelaENT.CodeTypeId = objvAppCodeTypeRelaENS.CodeTypeId; //代码类型Id
objvAppCodeTypeRelaENT.CodeTypeName = objvAppCodeTypeRelaENS.CodeTypeName; //代码类型名
objvAppCodeTypeRelaENT.CodeTypeSimName = objvAppCodeTypeRelaENS.CodeTypeSimName; //简称
objvAppCodeTypeRelaENT.CodeTypeENName = objvAppCodeTypeRelaENS.CodeTypeENName; //代码类型英文名
objvAppCodeTypeRelaENT.GroupName = objvAppCodeTypeRelaENS.GroupName; //组名
objvAppCodeTypeRelaENT.ProgLangTypeId = objvAppCodeTypeRelaENS.ProgLangTypeId; //编程语言类型Id
objvAppCodeTypeRelaENT.ProgLangTypeName = objvAppCodeTypeRelaENS.ProgLangTypeName; //编程语言类型名
objvAppCodeTypeRelaENT.ProgLangTypeSimName = objvAppCodeTypeRelaENS.ProgLangTypeSimName; //编程语言类型简称
objvAppCodeTypeRelaENT.RegionTypeId = objvAppCodeTypeRelaENS.RegionTypeId; //区域类型Id
objvAppCodeTypeRelaENT.RegionTypeName = objvAppCodeTypeRelaENS.RegionTypeName; //区域类型名称
objvAppCodeTypeRelaENT.DependsOn = objvAppCodeTypeRelaENS.DependsOn; //依赖于
objvAppCodeTypeRelaENT.FrontOrBack = objvAppCodeTypeRelaENS.FrontOrBack; //前台Or后台
objvAppCodeTypeRelaENT.AppCount = objvAppCodeTypeRelaENS.AppCount; //应用数
objvAppCodeTypeRelaENT.ViewTypeCode = objvAppCodeTypeRelaENS.ViewTypeCode; //界面类型码
objvAppCodeTypeRelaENT.ViewTypeName = objvAppCodeTypeRelaENS.ViewTypeName; //界面类型名称
objvAppCodeTypeRelaENT.TabMainTypeId = objvAppCodeTypeRelaENS.TabMainTypeId; //表主类型Id
objvAppCodeTypeRelaENT.TabMainTypeName = objvAppCodeTypeRelaENS.TabMainTypeName; //表主类型名
objvAppCodeTypeRelaENT.IsVisible = objvAppCodeTypeRelaENS.IsVisible; //是否显示
objvAppCodeTypeRelaENT.IsInGroupGeneCode = objvAppCodeTypeRelaENS.IsInGroupGeneCode; //是否参与组生成代码
objvAppCodeTypeRelaENT.OrderNum = objvAppCodeTypeRelaENS.OrderNum; //序号
objvAppCodeTypeRelaENT.UpdDate = objvAppCodeTypeRelaENS.UpdDate; //修改日期
objvAppCodeTypeRelaENT.UpdUser = objvAppCodeTypeRelaENS.UpdUser; //修改者
objvAppCodeTypeRelaENT.Memo = objvAppCodeTypeRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvAppCodeTypeRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvAppCodeTypeRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvAppCodeTypeRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvAppCodeTypeRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvAppCodeTypeRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvAppCodeTypeRelaEN._AttributeName)
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
public static void ReFreshThisCache(string intApplicationTypeId = "")
{


if (intApplicationTypeId == 0)
{
  var strMsg = string.Format("参数:[intApplicationTypeId]不能为空！(In clsvAppCodeTypeRelaWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvAppCodeTypeRelaEN._CurrTabName, intApplicationTypeId);
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
public static List<clsvAppCodeTypeRelaEN> GetObjLstCache(int intApplicationTypeId)
{


if (intApplicationTypeId == 0)
{
  var strMsg = string.Format("参数:[intApplicationTypeId]不能为空！(In clsvAppCodeTypeRelaWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvAppCodeTypeRelaEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvAppCodeTypeRelaEN._WhereFormat, intApplicationTypeId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId);
}
var strKey = string.Format("{0}_{1}", clsvAppCodeTypeRelaEN._CurrTabName, intApplicationTypeId);
List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvAppCodeTypeRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetObjLstCacheFromObjLst(int intApplicationTypeId,List<clsvAppCodeTypeRelaEN> arrObjLst_P)
{


if (intApplicationTypeId == 0)
{
  var strMsg = string.Format("参数:[intApplicationTypeId]不能为空！(In clsvAppCodeTypeRelaWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvAppCodeTypeRelaEN._CurrTabName, intApplicationTypeId);
List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvAppCodeTypeRelaObjLstCache = CacheHelper.Get<List<clsvAppCodeTypeRelaEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.ApplicationTypeId == intApplicationTypeId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvAppCodeTypeRelaObjLstCache = CacheHelper.Get<List<clsvAppCodeTypeRelaEN>>(strKey);
}
return arrvAppCodeTypeRelaObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvAppCodeTypeRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convAppCodeTypeRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convAppCodeTypeRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convAppCodeTypeRela.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.CodeTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.ProgLangTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.RegionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.DependsOn, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.FrontOrBack, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.AppCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convAppCodeTypeRela.ViewTypeCode, Type.GetType("System.Int32"));
objDT.Columns.Add(convAppCodeTypeRela.ViewTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.TabMainTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.TabMainTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convAppCodeTypeRela.IsInGroupGeneCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convAppCodeTypeRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convAppCodeTypeRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convAppCodeTypeRela.Memo, Type.GetType("System.String"));
foreach (clsvAppCodeTypeRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convAppCodeTypeRela.mId] = objInFor[convAppCodeTypeRela.mId];
objDR[convAppCodeTypeRela.ApplicationTypeId] = objInFor[convAppCodeTypeRela.ApplicationTypeId];
objDR[convAppCodeTypeRela.ApplicationTypeName] = objInFor[convAppCodeTypeRela.ApplicationTypeName];
objDR[convAppCodeTypeRela.ApplicationTypeENName] = objInFor[convAppCodeTypeRela.ApplicationTypeENName];
objDR[convAppCodeTypeRela.CodeTypeId] = objInFor[convAppCodeTypeRela.CodeTypeId];
objDR[convAppCodeTypeRela.CodeTypeName] = objInFor[convAppCodeTypeRela.CodeTypeName];
objDR[convAppCodeTypeRela.CodeTypeSimName] = objInFor[convAppCodeTypeRela.CodeTypeSimName];
objDR[convAppCodeTypeRela.CodeTypeENName] = objInFor[convAppCodeTypeRela.CodeTypeENName];
objDR[convAppCodeTypeRela.GroupName] = objInFor[convAppCodeTypeRela.GroupName];
objDR[convAppCodeTypeRela.ProgLangTypeId] = objInFor[convAppCodeTypeRela.ProgLangTypeId];
objDR[convAppCodeTypeRela.ProgLangTypeName] = objInFor[convAppCodeTypeRela.ProgLangTypeName];
objDR[convAppCodeTypeRela.ProgLangTypeSimName] = objInFor[convAppCodeTypeRela.ProgLangTypeSimName];
objDR[convAppCodeTypeRela.RegionTypeId] = objInFor[convAppCodeTypeRela.RegionTypeId];
objDR[convAppCodeTypeRela.RegionTypeName] = objInFor[convAppCodeTypeRela.RegionTypeName];
objDR[convAppCodeTypeRela.DependsOn] = objInFor[convAppCodeTypeRela.DependsOn];
objDR[convAppCodeTypeRela.FrontOrBack] = objInFor[convAppCodeTypeRela.FrontOrBack];
objDR[convAppCodeTypeRela.AppCount] = objInFor[convAppCodeTypeRela.AppCount];
objDR[convAppCodeTypeRela.ViewTypeCode] = objInFor[convAppCodeTypeRela.ViewTypeCode];
objDR[convAppCodeTypeRela.ViewTypeName] = objInFor[convAppCodeTypeRela.ViewTypeName];
objDR[convAppCodeTypeRela.TabMainTypeId] = objInFor[convAppCodeTypeRela.TabMainTypeId];
objDR[convAppCodeTypeRela.TabMainTypeName] = objInFor[convAppCodeTypeRela.TabMainTypeName];
objDR[convAppCodeTypeRela.IsVisible] = objInFor[convAppCodeTypeRela.IsVisible];
objDR[convAppCodeTypeRela.IsInGroupGeneCode] = objInFor[convAppCodeTypeRela.IsInGroupGeneCode];
objDR[convAppCodeTypeRela.OrderNum] = objInFor[convAppCodeTypeRela.OrderNum];
objDR[convAppCodeTypeRela.UpdDate] = objInFor[convAppCodeTypeRela.UpdDate];
objDR[convAppCodeTypeRela.UpdUser] = objInFor[convAppCodeTypeRela.UpdUser];
objDR[convAppCodeTypeRela.Memo] = objInFor[convAppCodeTypeRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}