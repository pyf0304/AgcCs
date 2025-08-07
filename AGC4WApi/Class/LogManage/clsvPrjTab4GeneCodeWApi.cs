
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4GeneCodeWApi
 表名:vPrjTab4GeneCode(00050284)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:12
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsvPrjTab4GeneCodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab4GeneCode.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab4GeneCode.TabId);
objvPrjTab4GeneCodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabId) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabId, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabId] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldNum">字段数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetFldNum(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, int intFldNum, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.FldNum) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.FldNum, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.FldNum] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetGeneCodeDate(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convPrjTab4GeneCode.GeneCodeDate);
objvPrjTab4GeneCodeEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.GeneCodeDate) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.GeneCodeDate, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.GeneCodeDate] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGene">是否需要生成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetIsNeedGene(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, bool bolIsNeedGene, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.IsNeedGene = bolIsNeedGene; //是否需要生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.IsNeedGene) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.IsNeedGene, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.IsNeedGene] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strVersionGeneCode">生成代码版本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetVersionGeneCode(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convPrjTab4GeneCode.VersionGeneCode);
objvPrjTab4GeneCodeEN.VersionGeneCode = strVersionGeneCode; //生成代码版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.VersionGeneCode) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.VersionGeneCode, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.VersionGeneCode] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetApplicationTypeId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, int intApplicationTypeId, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.ApplicationTypeId) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.ApplicationTypeId, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.ApplicationTypeId] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab4GeneCode.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab4GeneCode.TabName);
objvPrjTab4GeneCodeEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabName) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabName, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabName] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabCnName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjTab4GeneCode.TabCnName);
objvPrjTab4GeneCodeEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabCnName) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabCnName, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabCnName] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetPrjId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTab4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTab4GeneCode.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTab4GeneCode.PrjId);
objvPrjTab4GeneCodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.PrjId) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.PrjId, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.PrjId] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetPrjName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjTab4GeneCode.PrjName);
objvPrjTab4GeneCodeEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.PrjName) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.PrjName, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.PrjName] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetIsNeedTransCode(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, convPrjTab4GeneCode.IsNeedTransCode);
objvPrjTab4GeneCodeEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.IsNeedTransCode) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.IsNeedTransCode, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.IsNeedTransCode] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetSqlDsTypeId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab4GeneCode.SqlDsTypeId);
objvPrjTab4GeneCodeEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.SqlDsTypeId) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.SqlDsTypeId, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.SqlDsTypeId] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetSqlDsTypeName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convPrjTab4GeneCode.SqlDsTypeName);
objvPrjTab4GeneCodeEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.SqlDsTypeName) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.SqlDsTypeName, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.SqlDsTypeName] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabStateId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab4GeneCode.TabStateId);
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab4GeneCode.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab4GeneCode.TabStateId);
objvPrjTab4GeneCodeEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabStateId) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabStateId, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabStateId] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateName">表状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabStateName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabStateName, 30, convPrjTab4GeneCode.TabStateName);
objvPrjTab4GeneCodeEN.TabStateName = strTabStateName; //表状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabStateName) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabStateName, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabStateName] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabNameB">表名_后备</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabNameB(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabNameB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabNameB, 50, convPrjTab4GeneCode.TabNameB);
objvPrjTab4GeneCodeEN.TabNameB = strTabNameB; //表名_后备
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabNameB) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabNameB, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabNameB] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsParaTab">是否参数表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetIsParaTab(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, bool bolIsParaTab, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.IsParaTab = bolIsParaTab; //是否参数表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.IsParaTab) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.IsParaTab, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.IsParaTab] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNationStandard">是否国标</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetIsNationStandard(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, bool bolIsNationStandard, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.IsNationStandard = bolIsNationStandard; //是否国标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.IsNationStandard) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.IsNationStandard, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.IsNationStandard] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsArchive">是否存档</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetIsArchive(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, bool bolIsArchive, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.IsArchive) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.IsArchive, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.IsArchive] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsChecked">是否核实</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetIsChecked(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, bool bolIsChecked, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.IsChecked) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.IsChecked, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.IsChecked] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetFuncModuleAgcId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab4GeneCode.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab4GeneCode.FuncModuleAgcId);
objvPrjTab4GeneCodeEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.FuncModuleAgcId) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.FuncModuleAgcId, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.FuncModuleAgcId] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetFuncModuleName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convPrjTab4GeneCode.FuncModuleName);
objvPrjTab4GeneCodeEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.FuncModuleName) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.FuncModuleName, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.FuncModuleName] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetFuncModuleEnName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convPrjTab4GeneCode.FuncModuleEnName);
objvPrjTab4GeneCodeEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.FuncModuleEnName) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.FuncModuleEnName, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.FuncModuleEnName] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strOwner">拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetOwner(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwner, 50, convPrjTab4GeneCode.Owner);
objvPrjTab4GeneCodeEN.Owner = strOwner; //拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.Owner) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.Owner, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.Owner] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsReleToSqlTab">是否与SQL表相关</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetIsReleToSqlTab(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, bool bolIsReleToSqlTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsReleToSqlTab, convPrjTab4GeneCode.IsReleToSqlTab);
objvPrjTab4GeneCodeEN.IsReleToSqlTab = bolIsReleToSqlTab; //是否与SQL表相关
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.IsReleToSqlTab) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.IsReleToSqlTab, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.IsReleToSqlTab] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetKeyword(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 50, convPrjTab4GeneCode.Keyword);
objvPrjTab4GeneCodeEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.Keyword) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.Keyword, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.Keyword] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabTypeId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab4GeneCode.TabTypeId);
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab4GeneCode.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab4GeneCode.TabTypeId);
objvPrjTab4GeneCodeEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabTypeId) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabTypeId, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabTypeId] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeName">表类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabTypeName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convPrjTab4GeneCode.TabTypeName);
objvPrjTab4GeneCodeEN.TabTypeName = strTabTypeName; //表类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabTypeName) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabTypeName, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabTypeName] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeId">表主类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabMainTypeId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabMainTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, convPrjTab4GeneCode.TabMainTypeId);
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, convPrjTab4GeneCode.TabMainTypeId);
objvPrjTab4GeneCodeEN.TabMainTypeId = strTabMainTypeId; //表主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabMainTypeId) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabMainTypeId, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabMainTypeId] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeName">表主类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabMainTypeName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabMainTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabMainTypeName, 30, convPrjTab4GeneCode.TabMainTypeName);
objvPrjTab4GeneCodeEN.TabMainTypeName = strTabMainTypeName; //表主类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.TabMainTypeName) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.TabMainTypeName, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.TabMainTypeName] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId4View">视图的相关表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetRelaTabId4View(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strRelaTabId4View, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId4View, 8, convPrjTab4GeneCode.RelaTabId4View);
clsCheckSql.CheckFieldForeignKey(strRelaTabId4View, 8, convPrjTab4GeneCode.RelaTabId4View);
objvPrjTab4GeneCodeEN.RelaTabId4View = strRelaTabId4View; //视图的相关表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.RelaTabId4View) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.RelaTabId4View, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.RelaTabId4View] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetOrderNum4Refer(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.OrderNum4Refer) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.OrderNum4Refer, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.OrderNum4Refer] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGeneIndexer">是否需要生成索引器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetIsNeedGeneIndexer(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, bool bolIsNeedGeneIndexer, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = bolIsNeedGeneIndexer; //是否需要生成索引器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.IsNeedGeneIndexer) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.IsNeedGeneIndexer, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.IsNeedGeneIndexer] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUseCache">是否使用Cache</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetIsUseCache(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, bool bolIsUseCache, string strComparisonOp="")
	{
objvPrjTab4GeneCodeEN.IsUseCache = bolIsUseCache; //是否使用Cache
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.IsUseCache) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.IsUseCache, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.IsUseCache] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheClassifyField">缓存分类字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetCacheClassifyField(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strCacheClassifyField, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheClassifyField, 8, convPrjTab4GeneCode.CacheClassifyField);
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField, 8, convPrjTab4GeneCode.CacheClassifyField);
objvPrjTab4GeneCodeEN.CacheClassifyField = strCacheClassifyField; //缓存分类字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.CacheClassifyField) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.CacheClassifyField, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.CacheClassifyField] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetUpdUserId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convPrjTab4GeneCode.UpdUserId);
objvPrjTab4GeneCodeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.UpdUserId) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.UpdUserId, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.UpdUserId] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetUpdDate(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjTab4GeneCode.UpdDate);
objvPrjTab4GeneCodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.UpdDate) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.UpdDate, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.UpdDate] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetMemo(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjTab4GeneCode.Memo);
objvPrjTab4GeneCodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.Memo) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.Memo, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.Memo] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg2">ErrMsg2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetErrMsg2(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strErrMsg2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg2, 8000, convPrjTab4GeneCode.ErrMsg2);
objvPrjTab4GeneCodeEN.ErrMsg2 = strErrMsg2; //ErrMsg2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.ErrMsg2) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.ErrMsg2, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.ErrMsg2] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseNameTab">DataBaseName_Tab</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetDataBaseNameTab(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strDataBaseNameTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseNameTab, 50, convPrjTab4GeneCode.DataBaseNameTab);
objvPrjTab4GeneCodeEN.DataBaseNameTab = strDataBaseNameTab; //DataBaseName_Tab
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.DataBaseNameTab) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.DataBaseNameTab, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.DataBaseNameTab] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId4GeneCode">UserId4GeneCode</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetUserId4GeneCode(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strUserId4GeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId4GeneCode, 18, convPrjTab4GeneCode.UserId4GeneCode);
objvPrjTab4GeneCodeEN.UserId4GeneCode = strUserId4GeneCode; //UserId4GeneCode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4GeneCodeEN.dicFldComparisonOp.ContainsKey(convPrjTab4GeneCode.UserId4GeneCode) == false)
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp.Add(convPrjTab4GeneCode.UserId4GeneCode, strComparisonOp);
}
else
{
objvPrjTab4GeneCodeEN.dicFldComparisonOp[convPrjTab4GeneCode.UserId4GeneCode] = strComparisonOp;
}
}
return objvPrjTab4GeneCodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabId) == true)
{
string strComparisonOpTabId = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabId, objvPrjTab4GeneCodeCond.TabId, strComparisonOpTabId);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.FldNum) == true)
{
string strComparisonOpFldNum = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab4GeneCode.FldNum, objvPrjTab4GeneCodeCond.FldNum, strComparisonOpFldNum);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.GeneCodeDate, objvPrjTab4GeneCodeCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.IsNeedGene) == true)
{
if (objvPrjTab4GeneCodeCond.IsNeedGene == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4GeneCode.IsNeedGene);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4GeneCode.IsNeedGene);
}
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.VersionGeneCode) == true)
{
string strComparisonOpVersionGeneCode = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.VersionGeneCode, objvPrjTab4GeneCodeCond.VersionGeneCode, strComparisonOpVersionGeneCode);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab4GeneCode.ApplicationTypeId, objvPrjTab4GeneCodeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabName) == true)
{
string strComparisonOpTabName = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabName, objvPrjTab4GeneCodeCond.TabName, strComparisonOpTabName);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabCnName) == true)
{
string strComparisonOpTabCnName = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabCnName, objvPrjTab4GeneCodeCond.TabCnName, strComparisonOpTabCnName);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.PrjId, objvPrjTab4GeneCodeCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.PrjName, objvPrjTab4GeneCodeCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.IsNeedTransCode) == true)
{
if (objvPrjTab4GeneCodeCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4GeneCode.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4GeneCode.IsNeedTransCode);
}
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.SqlDsTypeId, objvPrjTab4GeneCodeCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.SqlDsTypeName, objvPrjTab4GeneCodeCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabStateId) == true)
{
string strComparisonOpTabStateId = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabStateId, objvPrjTab4GeneCodeCond.TabStateId, strComparisonOpTabStateId);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabStateName) == true)
{
string strComparisonOpTabStateName = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabStateName, objvPrjTab4GeneCodeCond.TabStateName, strComparisonOpTabStateName);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabNameB) == true)
{
string strComparisonOpTabNameB = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabNameB];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabNameB, objvPrjTab4GeneCodeCond.TabNameB, strComparisonOpTabNameB);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.IsParaTab) == true)
{
if (objvPrjTab4GeneCodeCond.IsParaTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4GeneCode.IsParaTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4GeneCode.IsParaTab);
}
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.IsNationStandard) == true)
{
if (objvPrjTab4GeneCodeCond.IsNationStandard == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4GeneCode.IsNationStandard);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4GeneCode.IsNationStandard);
}
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.IsArchive) == true)
{
if (objvPrjTab4GeneCodeCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4GeneCode.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4GeneCode.IsArchive);
}
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.IsChecked) == true)
{
if (objvPrjTab4GeneCodeCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4GeneCode.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4GeneCode.IsChecked);
}
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.FuncModuleAgcId, objvPrjTab4GeneCodeCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.FuncModuleName, objvPrjTab4GeneCodeCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.FuncModuleEnName, objvPrjTab4GeneCodeCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.Owner) == true)
{
string strComparisonOpOwner = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.Owner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.Owner, objvPrjTab4GeneCodeCond.Owner, strComparisonOpOwner);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.IsReleToSqlTab) == true)
{
if (objvPrjTab4GeneCodeCond.IsReleToSqlTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4GeneCode.IsReleToSqlTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4GeneCode.IsReleToSqlTab);
}
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.Keyword) == true)
{
string strComparisonOpKeyword = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.Keyword, objvPrjTab4GeneCodeCond.Keyword, strComparisonOpKeyword);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabTypeId, objvPrjTab4GeneCodeCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabTypeName) == true)
{
string strComparisonOpTabTypeName = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabTypeName, objvPrjTab4GeneCodeCond.TabTypeName, strComparisonOpTabTypeName);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabMainTypeId) == true)
{
string strComparisonOpTabMainTypeId = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabMainTypeId, objvPrjTab4GeneCodeCond.TabMainTypeId, strComparisonOpTabMainTypeId);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.TabMainTypeName) == true)
{
string strComparisonOpTabMainTypeName = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.TabMainTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.TabMainTypeName, objvPrjTab4GeneCodeCond.TabMainTypeName, strComparisonOpTabMainTypeName);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.RelaTabId4View) == true)
{
string strComparisonOpRelaTabId4View = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.RelaTabId4View];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.RelaTabId4View, objvPrjTab4GeneCodeCond.RelaTabId4View, strComparisonOpRelaTabId4View);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab4GeneCode.OrderNum4Refer, objvPrjTab4GeneCodeCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.IsNeedGeneIndexer) == true)
{
if (objvPrjTab4GeneCodeCond.IsNeedGeneIndexer == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4GeneCode.IsNeedGeneIndexer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4GeneCode.IsNeedGeneIndexer);
}
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.IsUseCache) == true)
{
if (objvPrjTab4GeneCodeCond.IsUseCache == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4GeneCode.IsUseCache);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4GeneCode.IsUseCache);
}
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.CacheClassifyField) == true)
{
string strComparisonOpCacheClassifyField = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.CacheClassifyField];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.CacheClassifyField, objvPrjTab4GeneCodeCond.CacheClassifyField, strComparisonOpCacheClassifyField);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.UpdUserId, objvPrjTab4GeneCodeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.UpdDate, objvPrjTab4GeneCodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.Memo) == true)
{
string strComparisonOpMemo = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.Memo, objvPrjTab4GeneCodeCond.Memo, strComparisonOpMemo);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.ErrMsg2) == true)
{
string strComparisonOpErrMsg2 = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.ErrMsg2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.ErrMsg2, objvPrjTab4GeneCodeCond.ErrMsg2, strComparisonOpErrMsg2);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.DataBaseNameTab) == true)
{
string strComparisonOpDataBaseNameTab = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.DataBaseNameTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.DataBaseNameTab, objvPrjTab4GeneCodeCond.DataBaseNameTab, strComparisonOpDataBaseNameTab);
}
if (objvPrjTab4GeneCodeCond.IsUpdated(convPrjTab4GeneCode.UserId4GeneCode) == true)
{
string strComparisonOpUserId4GeneCode = objvPrjTab4GeneCodeCond.dicFldComparisonOp[convPrjTab4GeneCode.UserId4GeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4GeneCode.UserId4GeneCode, objvPrjTab4GeneCodeCond.UserId4GeneCode, strComparisonOpUserId4GeneCode);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vPrjTab4GeneCode(vPrjTab4GeneCode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTab4GeneCodeWApi
{
private static readonly string mstrApiControllerName = "vPrjTab4GeneCodeApi";

 public clsvPrjTab4GeneCodeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPrjTab4GeneCode]...","0");
List<clsvPrjTab4GeneCodeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TabId";
objDDL.DataTextField="TabName";
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

 /// <param name = "strPrjId"></param>
public static void BindCbo_TabId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjTab4GeneCode.TabId); 
List<clsvPrjTab4GeneCodeEN> arrObjLst = clsvPrjTab4GeneCodeWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN()
{
TabId = "0",
TabName = "选[vPrjTab4GeneCode]..."
};
arrObjLstSel.Insert(0, objvPrjTab4GeneCodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjTab4GeneCode.TabId;
objComboBox.DisplayMember = convPrjTab4GeneCode.TabName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab4GeneCodeEN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN;
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
objvPrjTab4GeneCodeEN = JsonConvert.DeserializeObject<clsvPrjTab4GeneCodeEN>(strJson);
return objvPrjTab4GeneCodeEN;
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
public static clsvPrjTab4GeneCodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN;
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
objvPrjTab4GeneCodeEN = JsonConvert.DeserializeObject<clsvPrjTab4GeneCodeEN>(strJson);
return objvPrjTab4GeneCodeEN;
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
//该表没有使用Cache,不需要生成[GetTabNameByTabIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab4GeneCodeEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjTab4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4GeneCodeEN>>(strJson);
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsvPrjTab4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4GeneCodeEN>>(strJson);
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
public static List<clsvPrjTab4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjTab4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4GeneCodeEN>>(strJson);
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjTab4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4GeneCodeEN>>(strJson);
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjTab4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4GeneCodeEN>>(strJson);
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjTab4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4GeneCodeEN>>(strJson);
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
 /// <param name = "objvPrjTab4GeneCodeENS">源对象</param>
 /// <param name = "objvPrjTab4GeneCodeENT">目标对象</param>
 public static void CopyTo(clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeENS, clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeENT)
{
try
{
objvPrjTab4GeneCodeENT.TabId = objvPrjTab4GeneCodeENS.TabId; //表ID
objvPrjTab4GeneCodeENT.FldNum = objvPrjTab4GeneCodeENS.FldNum; //字段数
objvPrjTab4GeneCodeENT.GeneCodeDate = objvPrjTab4GeneCodeENS.GeneCodeDate; //生成代码日期
objvPrjTab4GeneCodeENT.IsNeedGene = objvPrjTab4GeneCodeENS.IsNeedGene; //是否需要生成
objvPrjTab4GeneCodeENT.VersionGeneCode = objvPrjTab4GeneCodeENS.VersionGeneCode; //生成代码版本
objvPrjTab4GeneCodeENT.ApplicationTypeId = objvPrjTab4GeneCodeENS.ApplicationTypeId; //应用程序类型ID
objvPrjTab4GeneCodeENT.TabName = objvPrjTab4GeneCodeENS.TabName; //表名
objvPrjTab4GeneCodeENT.TabCnName = objvPrjTab4GeneCodeENS.TabCnName; //表中文名
objvPrjTab4GeneCodeENT.PrjId = objvPrjTab4GeneCodeENS.PrjId; //工程Id
objvPrjTab4GeneCodeENT.PrjName = objvPrjTab4GeneCodeENS.PrjName; //工程名称
objvPrjTab4GeneCodeENT.IsNeedTransCode = objvPrjTab4GeneCodeENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4GeneCodeENT.SqlDsTypeId = objvPrjTab4GeneCodeENS.SqlDsTypeId; //数据源类型Id
objvPrjTab4GeneCodeENT.SqlDsTypeName = objvPrjTab4GeneCodeENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4GeneCodeENT.TabStateId = objvPrjTab4GeneCodeENS.TabStateId; //表状态ID
objvPrjTab4GeneCodeENT.TabStateName = objvPrjTab4GeneCodeENS.TabStateName; //表状态名称
objvPrjTab4GeneCodeENT.TabNameB = objvPrjTab4GeneCodeENS.TabNameB; //表名_后备
objvPrjTab4GeneCodeENT.IsParaTab = objvPrjTab4GeneCodeENS.IsParaTab; //是否参数表
objvPrjTab4GeneCodeENT.IsNationStandard = objvPrjTab4GeneCodeENS.IsNationStandard; //是否国标
objvPrjTab4GeneCodeENT.IsArchive = objvPrjTab4GeneCodeENS.IsArchive; //是否存档
objvPrjTab4GeneCodeENT.IsChecked = objvPrjTab4GeneCodeENS.IsChecked; //是否核实
objvPrjTab4GeneCodeENT.FuncModuleAgcId = objvPrjTab4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4GeneCodeENT.FuncModuleName = objvPrjTab4GeneCodeENS.FuncModuleName; //功能模块名称
objvPrjTab4GeneCodeENT.FuncModuleEnName = objvPrjTab4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4GeneCodeENT.Owner = objvPrjTab4GeneCodeENS.Owner; //拥有者
objvPrjTab4GeneCodeENT.IsReleToSqlTab = objvPrjTab4GeneCodeENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4GeneCodeENT.Keyword = objvPrjTab4GeneCodeENS.Keyword; //关键字
objvPrjTab4GeneCodeENT.TabTypeId = objvPrjTab4GeneCodeENS.TabTypeId; //表类型Id
objvPrjTab4GeneCodeENT.TabTypeName = objvPrjTab4GeneCodeENS.TabTypeName; //表类型名
objvPrjTab4GeneCodeENT.TabMainTypeId = objvPrjTab4GeneCodeENS.TabMainTypeId; //表主类型Id
objvPrjTab4GeneCodeENT.TabMainTypeName = objvPrjTab4GeneCodeENS.TabMainTypeName; //表主类型名
objvPrjTab4GeneCodeENT.RelaTabId4View = objvPrjTab4GeneCodeENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4GeneCodeENT.OrderNum4Refer = objvPrjTab4GeneCodeENS.OrderNum4Refer; //引用序号
objvPrjTab4GeneCodeENT.IsNeedGeneIndexer = objvPrjTab4GeneCodeENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4GeneCodeENT.IsUseCache = objvPrjTab4GeneCodeENS.IsUseCache; //是否使用Cache
objvPrjTab4GeneCodeENT.CacheClassifyField = objvPrjTab4GeneCodeENS.CacheClassifyField; //缓存分类字段
objvPrjTab4GeneCodeENT.UpdUserId = objvPrjTab4GeneCodeENS.UpdUserId; //修改用户Id
objvPrjTab4GeneCodeENT.UpdDate = objvPrjTab4GeneCodeENS.UpdDate; //修改日期
objvPrjTab4GeneCodeENT.Memo = objvPrjTab4GeneCodeENS.Memo; //说明
objvPrjTab4GeneCodeENT.ErrMsg2 = objvPrjTab4GeneCodeENS.ErrMsg2; //ErrMsg2
objvPrjTab4GeneCodeENT.DataBaseNameTab = objvPrjTab4GeneCodeENS.DataBaseNameTab; //DataBaseName_Tab
objvPrjTab4GeneCodeENT.UserId4GeneCode = objvPrjTab4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
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
public static DataTable ToDataTable(List<clsvPrjTab4GeneCodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjTab4GeneCodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjTab4GeneCodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjTab4GeneCodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjTab4GeneCodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjTab4GeneCodeEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTab4GeneCodeWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTab4GeneCodeWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab4GeneCodeEN._CurrTabName, strPrjId);
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
public static DataTable GetDataTableByObjLst(List<clsvPrjTab4GeneCodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjTab4GeneCode.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.FldNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTab4GeneCode.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.IsNeedGene, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4GeneCode.VersionGeneCode, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTab4GeneCode.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4GeneCode.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.TabStateName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.TabNameB, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.IsParaTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4GeneCode.IsNationStandard, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4GeneCode.IsArchive, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4GeneCode.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4GeneCode.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.Owner, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.IsReleToSqlTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4GeneCode.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.TabTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.TabMainTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.TabMainTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.RelaTabId4View, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.OrderNum4Refer, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTab4GeneCode.IsNeedGeneIndexer, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4GeneCode.IsUseCache, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4GeneCode.CacheClassifyField, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.ErrMsg2, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.DataBaseNameTab, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4GeneCode.UserId4GeneCode, Type.GetType("System.String"));
foreach (clsvPrjTab4GeneCodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjTab4GeneCode.TabId] = objInFor[convPrjTab4GeneCode.TabId];
objDR[convPrjTab4GeneCode.FldNum] = objInFor[convPrjTab4GeneCode.FldNum];
objDR[convPrjTab4GeneCode.GeneCodeDate] = objInFor[convPrjTab4GeneCode.GeneCodeDate];
objDR[convPrjTab4GeneCode.IsNeedGene] = objInFor[convPrjTab4GeneCode.IsNeedGene];
objDR[convPrjTab4GeneCode.VersionGeneCode] = objInFor[convPrjTab4GeneCode.VersionGeneCode];
objDR[convPrjTab4GeneCode.ApplicationTypeId] = objInFor[convPrjTab4GeneCode.ApplicationTypeId];
objDR[convPrjTab4GeneCode.TabName] = objInFor[convPrjTab4GeneCode.TabName];
objDR[convPrjTab4GeneCode.TabCnName] = objInFor[convPrjTab4GeneCode.TabCnName];
objDR[convPrjTab4GeneCode.PrjId] = objInFor[convPrjTab4GeneCode.PrjId];
objDR[convPrjTab4GeneCode.PrjName] = objInFor[convPrjTab4GeneCode.PrjName];
objDR[convPrjTab4GeneCode.IsNeedTransCode] = objInFor[convPrjTab4GeneCode.IsNeedTransCode];
objDR[convPrjTab4GeneCode.SqlDsTypeId] = objInFor[convPrjTab4GeneCode.SqlDsTypeId];
objDR[convPrjTab4GeneCode.SqlDsTypeName] = objInFor[convPrjTab4GeneCode.SqlDsTypeName];
objDR[convPrjTab4GeneCode.TabStateId] = objInFor[convPrjTab4GeneCode.TabStateId];
objDR[convPrjTab4GeneCode.TabStateName] = objInFor[convPrjTab4GeneCode.TabStateName];
objDR[convPrjTab4GeneCode.TabNameB] = objInFor[convPrjTab4GeneCode.TabNameB];
objDR[convPrjTab4GeneCode.IsParaTab] = objInFor[convPrjTab4GeneCode.IsParaTab];
objDR[convPrjTab4GeneCode.IsNationStandard] = objInFor[convPrjTab4GeneCode.IsNationStandard];
objDR[convPrjTab4GeneCode.IsArchive] = objInFor[convPrjTab4GeneCode.IsArchive];
objDR[convPrjTab4GeneCode.IsChecked] = objInFor[convPrjTab4GeneCode.IsChecked];
objDR[convPrjTab4GeneCode.FuncModuleAgcId] = objInFor[convPrjTab4GeneCode.FuncModuleAgcId];
objDR[convPrjTab4GeneCode.FuncModuleName] = objInFor[convPrjTab4GeneCode.FuncModuleName];
objDR[convPrjTab4GeneCode.FuncModuleEnName] = objInFor[convPrjTab4GeneCode.FuncModuleEnName];
objDR[convPrjTab4GeneCode.Owner] = objInFor[convPrjTab4GeneCode.Owner];
objDR[convPrjTab4GeneCode.IsReleToSqlTab] = objInFor[convPrjTab4GeneCode.IsReleToSqlTab];
objDR[convPrjTab4GeneCode.Keyword] = objInFor[convPrjTab4GeneCode.Keyword];
objDR[convPrjTab4GeneCode.TabTypeId] = objInFor[convPrjTab4GeneCode.TabTypeId];
objDR[convPrjTab4GeneCode.TabTypeName] = objInFor[convPrjTab4GeneCode.TabTypeName];
objDR[convPrjTab4GeneCode.TabMainTypeId] = objInFor[convPrjTab4GeneCode.TabMainTypeId];
objDR[convPrjTab4GeneCode.TabMainTypeName] = objInFor[convPrjTab4GeneCode.TabMainTypeName];
objDR[convPrjTab4GeneCode.RelaTabId4View] = objInFor[convPrjTab4GeneCode.RelaTabId4View];
objDR[convPrjTab4GeneCode.OrderNum4Refer] = objInFor[convPrjTab4GeneCode.OrderNum4Refer];
objDR[convPrjTab4GeneCode.IsNeedGeneIndexer] = objInFor[convPrjTab4GeneCode.IsNeedGeneIndexer];
objDR[convPrjTab4GeneCode.IsUseCache] = objInFor[convPrjTab4GeneCode.IsUseCache];
objDR[convPrjTab4GeneCode.CacheClassifyField] = objInFor[convPrjTab4GeneCode.CacheClassifyField];
objDR[convPrjTab4GeneCode.UpdUserId] = objInFor[convPrjTab4GeneCode.UpdUserId];
objDR[convPrjTab4GeneCode.UpdDate] = objInFor[convPrjTab4GeneCode.UpdDate];
objDR[convPrjTab4GeneCode.Memo] = objInFor[convPrjTab4GeneCode.Memo];
objDR[convPrjTab4GeneCode.ErrMsg2] = objInFor[convPrjTab4GeneCode.ErrMsg2];
objDR[convPrjTab4GeneCode.DataBaseNameTab] = objInFor[convPrjTab4GeneCode.DataBaseNameTab];
objDR[convPrjTab4GeneCode.UserId4GeneCode] = objInFor[convPrjTab4GeneCode.UserId4GeneCode];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}