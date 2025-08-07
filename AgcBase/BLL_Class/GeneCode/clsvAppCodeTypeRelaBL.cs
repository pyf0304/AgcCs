
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppCodeTypeRelaBL
 表名:vAppCodeTypeRela(00050419)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:40:59
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvAppCodeTypeRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAppCodeTypeRelaEN GetObj(this K_mId_vAppCodeTypeRela myKey)
{
clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = clsvAppCodeTypeRelaBL.vAppCodeTypeRelaDA.GetObjBymId(myKey.Value);
return objvAppCodeTypeRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetApplicationTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convAppCodeTypeRela.ApplicationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convAppCodeTypeRela.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetApplicationTypeENName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convAppCodeTypeRela.ApplicationTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convAppCodeTypeRela.ApplicationTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetCodeTypeId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convAppCodeTypeRela.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convAppCodeTypeRela.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convAppCodeTypeRela.CodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetCodeTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convAppCodeTypeRela.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convAppCodeTypeRela.CodeTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetCodeTypeSimName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strCodeTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convAppCodeTypeRela.CodeTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetCodeTypeENName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convAppCodeTypeRela.CodeTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetGroupName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convAppCodeTypeRela.GroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, convAppCodeTypeRela.GroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetProgLangTypeId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convAppCodeTypeRela.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convAppCodeTypeRela.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convAppCodeTypeRela.ProgLangTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetProgLangTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convAppCodeTypeRela.ProgLangTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetProgLangTypeSimName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convAppCodeTypeRela.ProgLangTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetRegionTypeId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convAppCodeTypeRela.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convAppCodeTypeRela.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetRegionTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strRegionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, convAppCodeTypeRela.RegionTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetDependsOn(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strDependsOn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDependsOn, 50, convAppCodeTypeRela.DependsOn);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetFrontOrBack(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strFrontOrBack, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFrontOrBack, 50, convAppCodeTypeRela.FrontOrBack);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetAppCount(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, int? intAppCount, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetViewTypeCode(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, int? intViewTypeCode, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetViewTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strViewTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTypeName, 40, convAppCodeTypeRela.ViewTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetTabMainTypeId(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strTabMainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, convAppCodeTypeRela.TabMainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, convAppCodeTypeRela.TabMainTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetTabMainTypeName(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strTabMainTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeName, 30, convAppCodeTypeRela.TabMainTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetUpdDate(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convAppCodeTypeRela.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetUpdUser(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convAppCodeTypeRela.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppCodeTypeRelaEN SetMemo(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convAppCodeTypeRela.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaENS">源对象</param>
 /// <param name = "objvAppCodeTypeRelaENT">目标对象</param>
 public static void CopyTo(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaENS, clsvAppCodeTypeRelaEN objvAppCodeTypeRelaENT)
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
 /// <param name = "objvAppCodeTypeRelaENS">源对象</param>
 /// <returns>目标对象=>clsvAppCodeTypeRelaEN:objvAppCodeTypeRelaENT</returns>
 public static clsvAppCodeTypeRelaEN CopyTo(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaENS)
{
try
{
 clsvAppCodeTypeRelaEN objvAppCodeTypeRelaENT = new clsvAppCodeTypeRelaEN()
{
mId = objvAppCodeTypeRelaENS.mId, //mId
ApplicationTypeId = objvAppCodeTypeRelaENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvAppCodeTypeRelaENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeENName = objvAppCodeTypeRelaENS.ApplicationTypeENName, //应用类型英文名
CodeTypeId = objvAppCodeTypeRelaENS.CodeTypeId, //代码类型Id
CodeTypeName = objvAppCodeTypeRelaENS.CodeTypeName, //代码类型名
CodeTypeSimName = objvAppCodeTypeRelaENS.CodeTypeSimName, //简称
CodeTypeENName = objvAppCodeTypeRelaENS.CodeTypeENName, //代码类型英文名
GroupName = objvAppCodeTypeRelaENS.GroupName, //组名
ProgLangTypeId = objvAppCodeTypeRelaENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvAppCodeTypeRelaENS.ProgLangTypeName, //编程语言类型名
ProgLangTypeSimName = objvAppCodeTypeRelaENS.ProgLangTypeSimName, //编程语言类型简称
RegionTypeId = objvAppCodeTypeRelaENS.RegionTypeId, //区域类型Id
RegionTypeName = objvAppCodeTypeRelaENS.RegionTypeName, //区域类型名称
DependsOn = objvAppCodeTypeRelaENS.DependsOn, //依赖于
FrontOrBack = objvAppCodeTypeRelaENS.FrontOrBack, //前台Or后台
AppCount = objvAppCodeTypeRelaENS.AppCount, //应用数
ViewTypeCode = objvAppCodeTypeRelaENS.ViewTypeCode, //界面类型码
ViewTypeName = objvAppCodeTypeRelaENS.ViewTypeName, //界面类型名称
TabMainTypeId = objvAppCodeTypeRelaENS.TabMainTypeId, //表主类型Id
TabMainTypeName = objvAppCodeTypeRelaENS.TabMainTypeName, //表主类型名
IsVisible = objvAppCodeTypeRelaENS.IsVisible, //是否显示
IsInGroupGeneCode = objvAppCodeTypeRelaENS.IsInGroupGeneCode, //是否参与组生成代码
OrderNum = objvAppCodeTypeRelaENS.OrderNum, //序号
UpdDate = objvAppCodeTypeRelaENS.UpdDate, //修改日期
UpdUser = objvAppCodeTypeRelaENS.UpdUser, //修改者
Memo = objvAppCodeTypeRelaENS.Memo, //说明
};
 return objvAppCodeTypeRelaENT;
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
public static void CheckProperty4Condition(this clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN)
{
 clsvAppCodeTypeRelaBL.vAppCodeTypeRelaDA.CheckProperty4Condition(objvAppCodeTypeRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vAppCodeTypeRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v应用程序代码类型关系(vAppCodeTypeRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvAppCodeTypeRelaBL
{
public static RelatedActions_vAppCodeTypeRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvAppCodeTypeRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvAppCodeTypeRelaDA vAppCodeTypeRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvAppCodeTypeRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvAppCodeTypeRelaBL()
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
if (string.IsNullOrEmpty(clsvAppCodeTypeRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvAppCodeTypeRelaEN._ConnectString);
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
public static DataTable GetDataTable_vAppCodeTypeRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vAppCodeTypeRelaDA.GetDataTable_vAppCodeTypeRela(strWhereCond);
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
objDT = vAppCodeTypeRelaDA.GetDataTable(strWhereCond);
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
objDT = vAppCodeTypeRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vAppCodeTypeRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vAppCodeTypeRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vAppCodeTypeRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vAppCodeTypeRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vAppCodeTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vAppCodeTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvAppCodeTypeRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
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
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvAppCodeTypeRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvAppCodeTypeRelaEN._CurrTabName);
List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLst_Sel =
arrvAppCodeTypeRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvAppCodeTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetObjLst(string strWhereCond)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
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
public static List<clsvAppCodeTypeRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvAppCodeTypeRelaEN> GetSubObjLstCache(clsvAppCodeTypeRelaEN objvAppCodeTypeRelaCond)
{
List<clsvAppCodeTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvAppCodeTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convAppCodeTypeRela._AttributeName)
{
if (objvAppCodeTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objvAppCodeTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppCodeTypeRelaCond[strFldName].ToString());
}
else
{
if (objvAppCodeTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvAppCodeTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppCodeTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvAppCodeTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvAppCodeTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvAppCodeTypeRelaCond[strFldName]));
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
public static List<clsvAppCodeTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
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
public static List<clsvAppCodeTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
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
List<clsvAppCodeTypeRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvAppCodeTypeRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvAppCodeTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
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
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
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
public static List<clsvAppCodeTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvAppCodeTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
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
public static List<clsvAppCodeTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvAppCodeTypeRelaEN> arrObjLst = new List<clsvAppCodeTypeRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = new clsvAppCodeTypeRelaEN();
try
{
objvAppCodeTypeRelaEN.mId = Int32.Parse(objRow[convAppCodeTypeRela.mId].ToString().Trim()); //mId
objvAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvAppCodeTypeRelaEN.ApplicationTypeName = objRow[convAppCodeTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvAppCodeTypeRelaEN.ApplicationTypeENName = objRow[convAppCodeTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvAppCodeTypeRelaEN.CodeTypeId = objRow[convAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objvAppCodeTypeRelaEN.CodeTypeName = objRow[convAppCodeTypeRela.CodeTypeName].ToString().Trim(); //代码类型名
objvAppCodeTypeRelaEN.CodeTypeSimName = objRow[convAppCodeTypeRela.CodeTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeSimName].ToString().Trim(); //简称
objvAppCodeTypeRelaEN.CodeTypeENName = objRow[convAppCodeTypeRela.CodeTypeENName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvAppCodeTypeRelaEN.GroupName = objRow[convAppCodeTypeRela.GroupName].ToString().Trim(); //组名
objvAppCodeTypeRelaEN.ProgLangTypeId = objRow[convAppCodeTypeRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvAppCodeTypeRelaEN.ProgLangTypeName = objRow[convAppCodeTypeRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objRow[convAppCodeTypeRela.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvAppCodeTypeRelaEN.RegionTypeId = objRow[convAppCodeTypeRela.RegionTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeId].ToString().Trim(); //区域类型Id
objvAppCodeTypeRelaEN.RegionTypeName = objRow[convAppCodeTypeRela.RegionTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.RegionTypeName].ToString().Trim(); //区域类型名称
objvAppCodeTypeRelaEN.DependsOn = objRow[convAppCodeTypeRela.DependsOn] == DBNull.Value ? null : objRow[convAppCodeTypeRela.DependsOn].ToString().Trim(); //依赖于
objvAppCodeTypeRelaEN.FrontOrBack = objRow[convAppCodeTypeRela.FrontOrBack] == DBNull.Value ? null : objRow[convAppCodeTypeRela.FrontOrBack].ToString().Trim(); //前台Or后台
objvAppCodeTypeRelaEN.AppCount = objRow[convAppCodeTypeRela.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.AppCount].ToString().Trim()); //应用数
objvAppCodeTypeRelaEN.ViewTypeCode = objRow[convAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objvAppCodeTypeRelaEN.ViewTypeName = objRow[convAppCodeTypeRela.ViewTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.ViewTypeName].ToString().Trim(); //界面类型名称
objvAppCodeTypeRelaEN.TabMainTypeId = objRow[convAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objvAppCodeTypeRelaEN.TabMainTypeName = objRow[convAppCodeTypeRela.TabMainTypeName] == DBNull.Value ? null : objRow[convAppCodeTypeRela.TabMainTypeName].ToString().Trim(); //表主类型名
objvAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objvAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objvAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[convAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objvAppCodeTypeRelaEN.UpdDate = objRow[convAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objvAppCodeTypeRelaEN.UpdUser = objRow[convAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[convAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objvAppCodeTypeRelaEN.Memo = objRow[convAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[convAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppCodeTypeRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvAppCodeTypeRela(ref clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN)
{
bool bolResult = vAppCodeTypeRelaDA.GetvAppCodeTypeRela(ref objvAppCodeTypeRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAppCodeTypeRelaEN GetObjBymId(long lngmId)
{
clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = vAppCodeTypeRelaDA.GetObjBymId(lngmId);
return objvAppCodeTypeRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvAppCodeTypeRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = vAppCodeTypeRelaDA.GetFirstObj(strWhereCond);
 return objvAppCodeTypeRelaEN;
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
public static clsvAppCodeTypeRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = vAppCodeTypeRelaDA.GetObjByDataRow(objRow);
 return objvAppCodeTypeRelaEN;
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
public static clsvAppCodeTypeRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN = vAppCodeTypeRelaDA.GetObjByDataRow(objRow);
 return objvAppCodeTypeRelaEN;
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
 /// <param name = "lstvAppCodeTypeRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAppCodeTypeRelaEN GetObjBymIdFromList(long lngmId, List<clsvAppCodeTypeRelaEN> lstvAppCodeTypeRelaObjLst)
{
foreach (clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN in lstvAppCodeTypeRelaObjLst)
{
if (objvAppCodeTypeRelaEN.mId == lngmId)
{
return objvAppCodeTypeRelaEN;
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
 lngmId = new clsvAppCodeTypeRelaDA().GetFirstID(strWhereCond);
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
 arrList = vAppCodeTypeRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vAppCodeTypeRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vAppCodeTypeRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvAppCodeTypeRelaDA.IsExistTable();
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
 bolIsExist = vAppCodeTypeRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvAppCodeTypeRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN)
{
try
{
objvAppCodeTypeRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvAppCodeTypeRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convAppCodeTypeRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.mId = objvAppCodeTypeRelaEN.mId; //mId
}
if (arrFldSet.Contains(convAppCodeTypeRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.ApplicationTypeId = objvAppCodeTypeRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convAppCodeTypeRela.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.ApplicationTypeName = objvAppCodeTypeRelaEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convAppCodeTypeRela.ApplicationTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.ApplicationTypeENName = objvAppCodeTypeRelaEN.ApplicationTypeENName; //应用类型英文名
}
if (arrFldSet.Contains(convAppCodeTypeRela.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.CodeTypeId = objvAppCodeTypeRelaEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convAppCodeTypeRela.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.CodeTypeName = objvAppCodeTypeRelaEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convAppCodeTypeRela.CodeTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.CodeTypeSimName = objvAppCodeTypeRelaEN.CodeTypeSimName == "[null]" ? null :  objvAppCodeTypeRelaEN.CodeTypeSimName; //简称
}
if (arrFldSet.Contains(convAppCodeTypeRela.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.CodeTypeENName = objvAppCodeTypeRelaEN.CodeTypeENName == "[null]" ? null :  objvAppCodeTypeRelaEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(convAppCodeTypeRela.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.GroupName = objvAppCodeTypeRelaEN.GroupName; //组名
}
if (arrFldSet.Contains(convAppCodeTypeRela.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.ProgLangTypeId = objvAppCodeTypeRelaEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convAppCodeTypeRela.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.ProgLangTypeName = objvAppCodeTypeRelaEN.ProgLangTypeName == "[null]" ? null :  objvAppCodeTypeRelaEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convAppCodeTypeRela.ProgLangTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.ProgLangTypeSimName = objvAppCodeTypeRelaEN.ProgLangTypeSimName == "[null]" ? null :  objvAppCodeTypeRelaEN.ProgLangTypeSimName; //编程语言类型简称
}
if (arrFldSet.Contains(convAppCodeTypeRela.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.RegionTypeId = objvAppCodeTypeRelaEN.RegionTypeId == "[null]" ? null :  objvAppCodeTypeRelaEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convAppCodeTypeRela.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.RegionTypeName = objvAppCodeTypeRelaEN.RegionTypeName == "[null]" ? null :  objvAppCodeTypeRelaEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(convAppCodeTypeRela.DependsOn, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.DependsOn = objvAppCodeTypeRelaEN.DependsOn == "[null]" ? null :  objvAppCodeTypeRelaEN.DependsOn; //依赖于
}
if (arrFldSet.Contains(convAppCodeTypeRela.FrontOrBack, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.FrontOrBack = objvAppCodeTypeRelaEN.FrontOrBack == "[null]" ? null :  objvAppCodeTypeRelaEN.FrontOrBack; //前台Or后台
}
if (arrFldSet.Contains(convAppCodeTypeRela.AppCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.AppCount = objvAppCodeTypeRelaEN.AppCount; //应用数
}
if (arrFldSet.Contains(convAppCodeTypeRela.ViewTypeCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.ViewTypeCode = objvAppCodeTypeRelaEN.ViewTypeCode; //界面类型码
}
if (arrFldSet.Contains(convAppCodeTypeRela.ViewTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.ViewTypeName = objvAppCodeTypeRelaEN.ViewTypeName == "[null]" ? null :  objvAppCodeTypeRelaEN.ViewTypeName; //界面类型名称
}
if (arrFldSet.Contains(convAppCodeTypeRela.TabMainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.TabMainTypeId = objvAppCodeTypeRelaEN.TabMainTypeId == "[null]" ? null :  objvAppCodeTypeRelaEN.TabMainTypeId; //表主类型Id
}
if (arrFldSet.Contains(convAppCodeTypeRela.TabMainTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.TabMainTypeName = objvAppCodeTypeRelaEN.TabMainTypeName == "[null]" ? null :  objvAppCodeTypeRelaEN.TabMainTypeName; //表主类型名
}
if (arrFldSet.Contains(convAppCodeTypeRela.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.IsVisible = objvAppCodeTypeRelaEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convAppCodeTypeRela.IsInGroupGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.IsInGroupGeneCode = objvAppCodeTypeRelaEN.IsInGroupGeneCode; //是否参与组生成代码
}
if (arrFldSet.Contains(convAppCodeTypeRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.OrderNum = objvAppCodeTypeRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convAppCodeTypeRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.UpdDate = objvAppCodeTypeRelaEN.UpdDate == "[null]" ? null :  objvAppCodeTypeRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convAppCodeTypeRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.UpdUser = objvAppCodeTypeRelaEN.UpdUser == "[null]" ? null :  objvAppCodeTypeRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convAppCodeTypeRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppCodeTypeRelaEN.Memo = objvAppCodeTypeRelaEN.Memo == "[null]" ? null :  objvAppCodeTypeRelaEN.Memo; //说明
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
 /// <param name = "objvAppCodeTypeRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN)
{
try
{
if (objvAppCodeTypeRelaEN.CodeTypeSimName == "[null]") objvAppCodeTypeRelaEN.CodeTypeSimName = null; //简称
if (objvAppCodeTypeRelaEN.CodeTypeENName == "[null]") objvAppCodeTypeRelaEN.CodeTypeENName = null; //代码类型英文名
if (objvAppCodeTypeRelaEN.ProgLangTypeName == "[null]") objvAppCodeTypeRelaEN.ProgLangTypeName = null; //编程语言类型名
if (objvAppCodeTypeRelaEN.ProgLangTypeSimName == "[null]") objvAppCodeTypeRelaEN.ProgLangTypeSimName = null; //编程语言类型简称
if (objvAppCodeTypeRelaEN.RegionTypeId == "[null]") objvAppCodeTypeRelaEN.RegionTypeId = null; //区域类型Id
if (objvAppCodeTypeRelaEN.RegionTypeName == "[null]") objvAppCodeTypeRelaEN.RegionTypeName = null; //区域类型名称
if (objvAppCodeTypeRelaEN.DependsOn == "[null]") objvAppCodeTypeRelaEN.DependsOn = null; //依赖于
if (objvAppCodeTypeRelaEN.FrontOrBack == "[null]") objvAppCodeTypeRelaEN.FrontOrBack = null; //前台Or后台
if (objvAppCodeTypeRelaEN.ViewTypeName == "[null]") objvAppCodeTypeRelaEN.ViewTypeName = null; //界面类型名称
if (objvAppCodeTypeRelaEN.TabMainTypeId == "[null]") objvAppCodeTypeRelaEN.TabMainTypeId = null; //表主类型Id
if (objvAppCodeTypeRelaEN.TabMainTypeName == "[null]") objvAppCodeTypeRelaEN.TabMainTypeName = null; //表主类型名
if (objvAppCodeTypeRelaEN.UpdDate == "[null]") objvAppCodeTypeRelaEN.UpdDate = null; //修改日期
if (objvAppCodeTypeRelaEN.UpdUser == "[null]") objvAppCodeTypeRelaEN.UpdUser = null; //修改者
if (objvAppCodeTypeRelaEN.Memo == "[null]") objvAppCodeTypeRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvAppCodeTypeRelaEN objvAppCodeTypeRelaEN)
{
 vAppCodeTypeRelaDA.CheckProperty4Condition(objvAppCodeTypeRelaEN);
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
if (clsViewTypeCodeTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewTypeCodeTabBL没有刷新缓存机制(clsViewTypeCodeTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppCodeTypeRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppCodeTypeRelaBL没有刷新缓存机制(clsAppCodeTypeRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabMainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabMainTypeBL没有刷新缓存机制(clsTabMainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvAppCodeTypeRelaObjLstCache == null)
//{
//arrvAppCodeTypeRelaObjLstCache = vAppCodeTypeRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAppCodeTypeRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvAppCodeTypeRelaEN._CurrTabName);
List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLst_Sel =
arrvAppCodeTypeRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvAppCodeTypeRelaObjLst_Sel.Count() == 0)
{
   clsvAppCodeTypeRelaEN obj = clsvAppCodeTypeRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvAppCodeTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetAllvAppCodeTypeRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLstCache = GetObjLstCache(); 
return arrvAppCodeTypeRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvAppCodeTypeRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvAppCodeTypeRelaEN._CurrTabName);
List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvAppCodeTypeRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvAppCodeTypeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvAppCodeTypeRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvAppCodeTypeRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvAppCodeTypeRelaEN._RefreshTimeLst[clsvAppCodeTypeRelaEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convAppCodeTypeRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convAppCodeTypeRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convAppCodeTypeRela._AttributeName));
throw new Exception(strMsg);
}
var objvAppCodeTypeRela = clsvAppCodeTypeRelaBL.GetObjBymIdCache(lngmId);
if (objvAppCodeTypeRela == null) return "";
return objvAppCodeTypeRela[strOutFldName].ToString();
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
int intRecCount = clsvAppCodeTypeRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvAppCodeTypeRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvAppCodeTypeRelaDA.GetRecCount();
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
int intRecCount = clsvAppCodeTypeRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvAppCodeTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvAppCodeTypeRelaEN objvAppCodeTypeRelaCond)
{
List<clsvAppCodeTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvAppCodeTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convAppCodeTypeRela._AttributeName)
{
if (objvAppCodeTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objvAppCodeTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppCodeTypeRelaCond[strFldName].ToString());
}
else
{
if (objvAppCodeTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvAppCodeTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppCodeTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvAppCodeTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvAppCodeTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvAppCodeTypeRelaCond[strFldName]));
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
 List<string> arrList = clsvAppCodeTypeRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vAppCodeTypeRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vAppCodeTypeRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}