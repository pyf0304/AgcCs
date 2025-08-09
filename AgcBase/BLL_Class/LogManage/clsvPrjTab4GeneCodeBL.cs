
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4GeneCodeBL
 表名:vPrjTab4GeneCode(00050284)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsvPrjTab4GeneCodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab4GeneCodeEN GetObj(this K_TabId_vPrjTab4GeneCode myKey)
{
clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = clsvPrjTab4GeneCodeBL.vPrjTab4GeneCodeDA.GetObjByTabId(myKey.Value);
return objvPrjTab4GeneCodeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab4GeneCode.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab4GeneCode.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetFldNum(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, int? intFldNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetGeneCodeDate(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convPrjTab4GeneCode.GeneCodeDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetVersionGeneCode(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convPrjTab4GeneCode.VersionGeneCode);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetApplicationTypeId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, int? intApplicationTypeId, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab4GeneCode.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab4GeneCode.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabCnName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjTab4GeneCode.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetPrjId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTab4GeneCode.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTab4GeneCode.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTab4GeneCode.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetPrjName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjTab4GeneCode.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetSqlDsTypeId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab4GeneCode.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab4GeneCode.SqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetSqlDsTypeName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convPrjTab4GeneCode.SqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabStateId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab4GeneCode.TabStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab4GeneCode.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab4GeneCode.TabStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabStateName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateName, 30, convPrjTab4GeneCode.TabStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabNameB(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabNameB, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabNameB, 50, convPrjTab4GeneCode.TabNameB);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetFuncModuleAgcId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab4GeneCode.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab4GeneCode.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetFuncModuleName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convPrjTab4GeneCode.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetFuncModuleEnName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convPrjTab4GeneCode.FuncModuleEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetOwner(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwner, 50, convPrjTab4GeneCode.Owner);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetKeyword(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, convPrjTab4GeneCode.Keyword);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabTypeId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab4GeneCode.TabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab4GeneCode.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab4GeneCode.TabTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabTypeName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convPrjTab4GeneCode.TabTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabMainTypeId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabMainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, convPrjTab4GeneCode.TabMainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, convPrjTab4GeneCode.TabMainTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetTabMainTypeName(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strTabMainTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeName, 30, convPrjTab4GeneCode.TabMainTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetRelaTabId4View(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strRelaTabId4View, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId4View, 8, convPrjTab4GeneCode.RelaTabId4View);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId4View, 8, convPrjTab4GeneCode.RelaTabId4View);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetOrderNum4Refer(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, int? intOrderNum4Refer, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetCacheClassifyField(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strCacheClassifyField, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheClassifyField, 8, convPrjTab4GeneCode.CacheClassifyField);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField, 8, convPrjTab4GeneCode.CacheClassifyField);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetUpdUserId(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convPrjTab4GeneCode.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetUpdDate(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjTab4GeneCode.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetMemo(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjTab4GeneCode.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetErrMsg2(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strErrMsg2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg2, 8000, convPrjTab4GeneCode.ErrMsg2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetDataBaseNameTab(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strDataBaseNameTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseNameTab, 50, convPrjTab4GeneCode.DataBaseNameTab);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4GeneCodeEN SetUserId4GeneCode(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN, string strUserId4GeneCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId4GeneCode, 18, convPrjTab4GeneCode.UserId4GeneCode);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeENS">源对象</param>
 /// <param name = "objvPrjTab4GeneCodeENT">目标对象</param>
 public static void CopyTo(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeENS, clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeENT)
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
 /// <param name = "objvPrjTab4GeneCodeENS">源对象</param>
 /// <returns>目标对象=>clsvPrjTab4GeneCodeEN:objvPrjTab4GeneCodeENT</returns>
 public static clsvPrjTab4GeneCodeEN CopyTo(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeENS)
{
try
{
 clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeENT = new clsvPrjTab4GeneCodeEN()
{
TabId = objvPrjTab4GeneCodeENS.TabId, //表ID
FldNum = objvPrjTab4GeneCodeENS.FldNum, //字段数
GeneCodeDate = objvPrjTab4GeneCodeENS.GeneCodeDate, //生成代码日期
IsNeedGene = objvPrjTab4GeneCodeENS.IsNeedGene, //是否需要生成
VersionGeneCode = objvPrjTab4GeneCodeENS.VersionGeneCode, //生成代码版本
ApplicationTypeId = objvPrjTab4GeneCodeENS.ApplicationTypeId, //应用程序类型ID
TabName = objvPrjTab4GeneCodeENS.TabName, //表名
TabCnName = objvPrjTab4GeneCodeENS.TabCnName, //表中文名
PrjId = objvPrjTab4GeneCodeENS.PrjId, //工程Id
PrjName = objvPrjTab4GeneCodeENS.PrjName, //工程名称
IsNeedTransCode = objvPrjTab4GeneCodeENS.IsNeedTransCode, //是否需要转换代码
SqlDsTypeId = objvPrjTab4GeneCodeENS.SqlDsTypeId, //数据源类型Id
SqlDsTypeName = objvPrjTab4GeneCodeENS.SqlDsTypeName, //Sql数据源名
TabStateId = objvPrjTab4GeneCodeENS.TabStateId, //表状态ID
TabStateName = objvPrjTab4GeneCodeENS.TabStateName, //表状态名称
TabNameB = objvPrjTab4GeneCodeENS.TabNameB, //表名_后备
IsParaTab = objvPrjTab4GeneCodeENS.IsParaTab, //是否参数表
IsNationStandard = objvPrjTab4GeneCodeENS.IsNationStandard, //是否国标
IsArchive = objvPrjTab4GeneCodeENS.IsArchive, //是否存档
IsChecked = objvPrjTab4GeneCodeENS.IsChecked, //是否核实
FuncModuleAgcId = objvPrjTab4GeneCodeENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvPrjTab4GeneCodeENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objvPrjTab4GeneCodeENS.FuncModuleEnName, //功能模块英文名称
Owner = objvPrjTab4GeneCodeENS.Owner, //拥有者
IsReleToSqlTab = objvPrjTab4GeneCodeENS.IsReleToSqlTab, //是否与SQL表相关
Keyword = objvPrjTab4GeneCodeENS.Keyword, //关键字
TabTypeId = objvPrjTab4GeneCodeENS.TabTypeId, //表类型Id
TabTypeName = objvPrjTab4GeneCodeENS.TabTypeName, //表类型名
TabMainTypeId = objvPrjTab4GeneCodeENS.TabMainTypeId, //表主类型Id
TabMainTypeName = objvPrjTab4GeneCodeENS.TabMainTypeName, //表主类型名
RelaTabId4View = objvPrjTab4GeneCodeENS.RelaTabId4View, //视图的相关表ID
OrderNum4Refer = objvPrjTab4GeneCodeENS.OrderNum4Refer, //引用序号
IsNeedGeneIndexer = objvPrjTab4GeneCodeENS.IsNeedGeneIndexer, //是否需要生成索引器
IsUseCache = objvPrjTab4GeneCodeENS.IsUseCache, //是否使用Cache
CacheClassifyField = objvPrjTab4GeneCodeENS.CacheClassifyField, //缓存分类字段
UpdUserId = objvPrjTab4GeneCodeENS.UpdUserId, //修改用户Id
UpdDate = objvPrjTab4GeneCodeENS.UpdDate, //修改日期
Memo = objvPrjTab4GeneCodeENS.Memo, //说明
ErrMsg2 = objvPrjTab4GeneCodeENS.ErrMsg2, //ErrMsg2
DataBaseNameTab = objvPrjTab4GeneCodeENS.DataBaseNameTab, //DataBaseName_Tab
UserId4GeneCode = objvPrjTab4GeneCodeENS.UserId4GeneCode, //UserId4GeneCode
};
 return objvPrjTab4GeneCodeENT;
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
public static void CheckProperty4Condition(this clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN)
{
 clsvPrjTab4GeneCodeBL.vPrjTab4GeneCodeDA.CheckProperty4Condition(objvPrjTab4GeneCodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjTab4GeneCode
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPrjTab4GeneCode(vPrjTab4GeneCode)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTab4GeneCodeBL
{
public static RelatedActions_vPrjTab4GeneCode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjTab4GeneCodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjTab4GeneCodeDA vPrjTab4GeneCodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjTab4GeneCodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjTab4GeneCodeBL()
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
if (string.IsNullOrEmpty(clsvPrjTab4GeneCodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTab4GeneCodeEN._ConnectString);
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
public static DataTable GetDataTable_vPrjTab4GeneCode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTab4GeneCodeDA.GetDataTable_vPrjTab4GeneCode(strWhereCond);
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
objDT = vPrjTab4GeneCodeDA.GetDataTable(strWhereCond);
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
objDT = vPrjTab4GeneCodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjTab4GeneCodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjTab4GeneCodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjTab4GeneCodeDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjTab4GeneCodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjTab4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjTab4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
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
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjTab4GeneCodeEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab4GeneCodeEN._CurrTabName, strPrjId);
List<clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLst_Sel =
arrvPrjTab4GeneCodeObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrvPrjTab4GeneCodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab4GeneCodeEN> GetObjLst(string strWhereCond)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjTab4GeneCodeEN> GetSubObjLstCache(clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeCond)
{
 string strPrjId = objvPrjTab4GeneCodeCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPrjTab4GeneCodeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPrjTab4GeneCodeEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTab4GeneCode._AttributeName)
{
if (objvPrjTab4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTab4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab4GeneCodeCond[strFldName].ToString());
}
else
{
if (objvPrjTab4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTab4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTab4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTab4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTab4GeneCodeCond[strFldName]));
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
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
List<clsvPrjTab4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjTab4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjTab4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
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
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
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
public static List<clsvPrjTab4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
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
public static List<clsvPrjTab4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab4GeneCodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4GeneCodeEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjTab4GeneCode(ref clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN)
{
bool bolResult = vPrjTab4GeneCodeDA.GetvPrjTab4GeneCode(ref objvPrjTab4GeneCodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab4GeneCodeEN GetObjByTabId(string strTabId)
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
clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = vPrjTab4GeneCodeDA.GetObjByTabId(strTabId);
return objvPrjTab4GeneCodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjTab4GeneCodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = vPrjTab4GeneCodeDA.GetFirstObj(strWhereCond);
 return objvPrjTab4GeneCodeEN;
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
public static clsvPrjTab4GeneCodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = vPrjTab4GeneCodeDA.GetObjByDataRow(objRow);
 return objvPrjTab4GeneCodeEN;
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
public static clsvPrjTab4GeneCodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = vPrjTab4GeneCodeDA.GetObjByDataRow(objRow);
 return objvPrjTab4GeneCodeEN;
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
 /// <param name = "lstvPrjTab4GeneCodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab4GeneCodeEN GetObjByTabIdFromList(string strTabId, List<clsvPrjTab4GeneCodeEN> lstvPrjTab4GeneCodeObjLst)
{
foreach (clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN in lstvPrjTab4GeneCodeObjLst)
{
if (objvPrjTab4GeneCodeEN.TabId == strTabId)
{
return objvPrjTab4GeneCodeEN;
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
 strTabId = new clsvPrjTab4GeneCodeDA().GetFirstID(strWhereCond);
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
 arrList = vPrjTab4GeneCodeDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjTab4GeneCodeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vPrjTab4GeneCodeDA.IsExist(strTabId);
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
 bolIsExist = clsvPrjTab4GeneCodeDA.IsExistTable();
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
 bolIsExist = vPrjTab4GeneCodeDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjTab4GeneCodeEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN)
{
try
{
objvPrjTab4GeneCodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjTab4GeneCodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjTab4GeneCode.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabId = objvPrjTab4GeneCodeEN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjTab4GeneCode.FldNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.FldNum = objvPrjTab4GeneCodeEN.FldNum; //字段数
}
if (arrFldSet.Contains(convPrjTab4GeneCode.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.GeneCodeDate = objvPrjTab4GeneCodeEN.GeneCodeDate == "[null]" ? null :  objvPrjTab4GeneCodeEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(convPrjTab4GeneCode.IsNeedGene, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.IsNeedGene = objvPrjTab4GeneCodeEN.IsNeedGene; //是否需要生成
}
if (arrFldSet.Contains(convPrjTab4GeneCode.VersionGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.VersionGeneCode = objvPrjTab4GeneCodeEN.VersionGeneCode == "[null]" ? null :  objvPrjTab4GeneCodeEN.VersionGeneCode; //生成代码版本
}
if (arrFldSet.Contains(convPrjTab4GeneCode.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.ApplicationTypeId = objvPrjTab4GeneCodeEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convPrjTab4GeneCode.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabName = objvPrjTab4GeneCodeEN.TabName; //表名
}
if (arrFldSet.Contains(convPrjTab4GeneCode.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabCnName = objvPrjTab4GeneCodeEN.TabCnName == "[null]" ? null :  objvPrjTab4GeneCodeEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convPrjTab4GeneCode.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.PrjId = objvPrjTab4GeneCodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjTab4GeneCode.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.PrjName = objvPrjTab4GeneCodeEN.PrjName == "[null]" ? null :  objvPrjTab4GeneCodeEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convPrjTab4GeneCode.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.IsNeedTransCode = objvPrjTab4GeneCodeEN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(convPrjTab4GeneCode.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.SqlDsTypeId = objvPrjTab4GeneCodeEN.SqlDsTypeId == "[null]" ? null :  objvPrjTab4GeneCodeEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convPrjTab4GeneCode.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.SqlDsTypeName = objvPrjTab4GeneCodeEN.SqlDsTypeName == "[null]" ? null :  objvPrjTab4GeneCodeEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convPrjTab4GeneCode.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabStateId = objvPrjTab4GeneCodeEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convPrjTab4GeneCode.TabStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabStateName = objvPrjTab4GeneCodeEN.TabStateName == "[null]" ? null :  objvPrjTab4GeneCodeEN.TabStateName; //表状态名称
}
if (arrFldSet.Contains(convPrjTab4GeneCode.TabNameB, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabNameB = objvPrjTab4GeneCodeEN.TabNameB == "[null]" ? null :  objvPrjTab4GeneCodeEN.TabNameB; //表名_后备
}
if (arrFldSet.Contains(convPrjTab4GeneCode.IsParaTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.IsParaTab = objvPrjTab4GeneCodeEN.IsParaTab; //是否参数表
}
if (arrFldSet.Contains(convPrjTab4GeneCode.IsNationStandard, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.IsNationStandard = objvPrjTab4GeneCodeEN.IsNationStandard; //是否国标
}
if (arrFldSet.Contains(convPrjTab4GeneCode.IsArchive, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.IsArchive = objvPrjTab4GeneCodeEN.IsArchive; //是否存档
}
if (arrFldSet.Contains(convPrjTab4GeneCode.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.IsChecked = objvPrjTab4GeneCodeEN.IsChecked; //是否核实
}
if (arrFldSet.Contains(convPrjTab4GeneCode.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objvPrjTab4GeneCodeEN.FuncModuleAgcId == "[null]" ? null :  objvPrjTab4GeneCodeEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convPrjTab4GeneCode.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.FuncModuleName = objvPrjTab4GeneCodeEN.FuncModuleName == "[null]" ? null :  objvPrjTab4GeneCodeEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convPrjTab4GeneCode.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.FuncModuleEnName = objvPrjTab4GeneCodeEN.FuncModuleEnName == "[null]" ? null :  objvPrjTab4GeneCodeEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convPrjTab4GeneCode.Owner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.Owner = objvPrjTab4GeneCodeEN.Owner == "[null]" ? null :  objvPrjTab4GeneCodeEN.Owner; //拥有者
}
if (arrFldSet.Contains(convPrjTab4GeneCode.IsReleToSqlTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.IsReleToSqlTab = objvPrjTab4GeneCodeEN.IsReleToSqlTab; //是否与SQL表相关
}
if (arrFldSet.Contains(convPrjTab4GeneCode.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.Keyword = objvPrjTab4GeneCodeEN.Keyword == "[null]" ? null :  objvPrjTab4GeneCodeEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPrjTab4GeneCode.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabTypeId = objvPrjTab4GeneCodeEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(convPrjTab4GeneCode.TabTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabTypeName = objvPrjTab4GeneCodeEN.TabTypeName == "[null]" ? null :  objvPrjTab4GeneCodeEN.TabTypeName; //表类型名
}
if (arrFldSet.Contains(convPrjTab4GeneCode.TabMainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabMainTypeId = objvPrjTab4GeneCodeEN.TabMainTypeId == "[null]" ? null :  objvPrjTab4GeneCodeEN.TabMainTypeId; //表主类型Id
}
if (arrFldSet.Contains(convPrjTab4GeneCode.TabMainTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.TabMainTypeName = objvPrjTab4GeneCodeEN.TabMainTypeName == "[null]" ? null :  objvPrjTab4GeneCodeEN.TabMainTypeName; //表主类型名
}
if (arrFldSet.Contains(convPrjTab4GeneCode.RelaTabId4View, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.RelaTabId4View = objvPrjTab4GeneCodeEN.RelaTabId4View == "[null]" ? null :  objvPrjTab4GeneCodeEN.RelaTabId4View; //视图的相关表ID
}
if (arrFldSet.Contains(convPrjTab4GeneCode.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.OrderNum4Refer = objvPrjTab4GeneCodeEN.OrderNum4Refer; //引用序号
}
if (arrFldSet.Contains(convPrjTab4GeneCode.IsNeedGeneIndexer, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = objvPrjTab4GeneCodeEN.IsNeedGeneIndexer; //是否需要生成索引器
}
if (arrFldSet.Contains(convPrjTab4GeneCode.IsUseCache, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.IsUseCache = objvPrjTab4GeneCodeEN.IsUseCache; //是否使用Cache
}
if (arrFldSet.Contains(convPrjTab4GeneCode.CacheClassifyField, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.CacheClassifyField = objvPrjTab4GeneCodeEN.CacheClassifyField == "[null]" ? null :  objvPrjTab4GeneCodeEN.CacheClassifyField; //缓存分类字段
}
if (arrFldSet.Contains(convPrjTab4GeneCode.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.UpdUserId = objvPrjTab4GeneCodeEN.UpdUserId == "[null]" ? null :  objvPrjTab4GeneCodeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convPrjTab4GeneCode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.UpdDate = objvPrjTab4GeneCodeEN.UpdDate == "[null]" ? null :  objvPrjTab4GeneCodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjTab4GeneCode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.Memo = objvPrjTab4GeneCodeEN.Memo == "[null]" ? null :  objvPrjTab4GeneCodeEN.Memo; //说明
}
if (arrFldSet.Contains(convPrjTab4GeneCode.ErrMsg2, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.ErrMsg2 = objvPrjTab4GeneCodeEN.ErrMsg2 == "[null]" ? null :  objvPrjTab4GeneCodeEN.ErrMsg2; //ErrMsg2
}
if (arrFldSet.Contains(convPrjTab4GeneCode.DataBaseNameTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.DataBaseNameTab = objvPrjTab4GeneCodeEN.DataBaseNameTab == "[null]" ? null :  objvPrjTab4GeneCodeEN.DataBaseNameTab; //DataBaseName_Tab
}
if (arrFldSet.Contains(convPrjTab4GeneCode.UserId4GeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4GeneCodeEN.UserId4GeneCode = objvPrjTab4GeneCodeEN.UserId4GeneCode == "[null]" ? null :  objvPrjTab4GeneCodeEN.UserId4GeneCode; //UserId4GeneCode
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
 /// <param name = "objvPrjTab4GeneCodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN)
{
try
{
if (objvPrjTab4GeneCodeEN.GeneCodeDate == "[null]") objvPrjTab4GeneCodeEN.GeneCodeDate = null; //生成代码日期
if (objvPrjTab4GeneCodeEN.VersionGeneCode == "[null]") objvPrjTab4GeneCodeEN.VersionGeneCode = null; //生成代码版本
if (objvPrjTab4GeneCodeEN.TabCnName == "[null]") objvPrjTab4GeneCodeEN.TabCnName = null; //表中文名
if (objvPrjTab4GeneCodeEN.PrjName == "[null]") objvPrjTab4GeneCodeEN.PrjName = null; //工程名称
if (objvPrjTab4GeneCodeEN.SqlDsTypeId == "[null]") objvPrjTab4GeneCodeEN.SqlDsTypeId = null; //数据源类型Id
if (objvPrjTab4GeneCodeEN.SqlDsTypeName == "[null]") objvPrjTab4GeneCodeEN.SqlDsTypeName = null; //Sql数据源名
if (objvPrjTab4GeneCodeEN.TabStateName == "[null]") objvPrjTab4GeneCodeEN.TabStateName = null; //表状态名称
if (objvPrjTab4GeneCodeEN.TabNameB == "[null]") objvPrjTab4GeneCodeEN.TabNameB = null; //表名_后备
if (objvPrjTab4GeneCodeEN.FuncModuleAgcId == "[null]") objvPrjTab4GeneCodeEN.FuncModuleAgcId = null; //功能模块Id
if (objvPrjTab4GeneCodeEN.FuncModuleName == "[null]") objvPrjTab4GeneCodeEN.FuncModuleName = null; //功能模块名称
if (objvPrjTab4GeneCodeEN.FuncModuleEnName == "[null]") objvPrjTab4GeneCodeEN.FuncModuleEnName = null; //功能模块英文名称
if (objvPrjTab4GeneCodeEN.Owner == "[null]") objvPrjTab4GeneCodeEN.Owner = null; //拥有者
if (objvPrjTab4GeneCodeEN.Keyword == "[null]") objvPrjTab4GeneCodeEN.Keyword = null; //关键字
if (objvPrjTab4GeneCodeEN.TabTypeName == "[null]") objvPrjTab4GeneCodeEN.TabTypeName = null; //表类型名
if (objvPrjTab4GeneCodeEN.TabMainTypeId == "[null]") objvPrjTab4GeneCodeEN.TabMainTypeId = null; //表主类型Id
if (objvPrjTab4GeneCodeEN.TabMainTypeName == "[null]") objvPrjTab4GeneCodeEN.TabMainTypeName = null; //表主类型名
if (objvPrjTab4GeneCodeEN.RelaTabId4View == "[null]") objvPrjTab4GeneCodeEN.RelaTabId4View = null; //视图的相关表ID
if (objvPrjTab4GeneCodeEN.CacheClassifyField == "[null]") objvPrjTab4GeneCodeEN.CacheClassifyField = null; //缓存分类字段
if (objvPrjTab4GeneCodeEN.UpdUserId == "[null]") objvPrjTab4GeneCodeEN.UpdUserId = null; //修改用户Id
if (objvPrjTab4GeneCodeEN.UpdDate == "[null]") objvPrjTab4GeneCodeEN.UpdDate = null; //修改日期
if (objvPrjTab4GeneCodeEN.Memo == "[null]") objvPrjTab4GeneCodeEN.Memo = null; //说明
if (objvPrjTab4GeneCodeEN.ErrMsg2 == "[null]") objvPrjTab4GeneCodeEN.ErrMsg2 = null; //ErrMsg2
if (objvPrjTab4GeneCodeEN.DataBaseNameTab == "[null]") objvPrjTab4GeneCodeEN.DataBaseNameTab = null; //DataBaseName_Tab
if (objvPrjTab4GeneCodeEN.UserId4GeneCode == "[null]") objvPrjTab4GeneCodeEN.UserId4GeneCode = null; //UserId4GeneCode
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
public static void CheckProperty4Condition(clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN)
{
 vPrjTab4GeneCodeDA.CheckProperty4Condition(objvPrjTab4GeneCodeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_TabId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjTab4GeneCode.TabId); 
List<clsvPrjTab4GeneCodeEN> arrObjLst = clsvPrjTab4GeneCodeBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPrjTab4GeneCode]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convPrjTab4GeneCode.TabId); 
IEnumerable<clsvPrjTab4GeneCodeEN> arrObjLst = clsvPrjTab4GeneCodeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convPrjTab4GeneCode.TabId;
objDDL.DataTextField = convPrjTab4GeneCode.TabName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPrjTab4GeneCode]...","0");
List<clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLst = GetAllvPrjTab4GeneCodeObjLstCache(strPrjId); 
objDDL.DataValueField = convPrjTab4GeneCode.TabId;
objDDL.DataTextField = convPrjTab4GeneCode.TabName;
objDDL.DataSource = arrvPrjTab4GeneCodeObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLog4GeneTabCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLog4GeneTabCodeBL没有刷新缓存机制(clsLog4GeneTabCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrvPrjTab4GeneCodeObjLstCache == null)
//{
//arrvPrjTab4GeneCodeObjLstCache = vPrjTab4GeneCodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab4GeneCodeEN GetObjByTabIdCache(string strTabId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvPrjTab4GeneCodeEN._CurrTabName, strPrjId);
List<clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLst_Sel =
arrvPrjTab4GeneCodeObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrvPrjTab4GeneCodeObjLst_Sel.Count() == 0)
{
   clsvPrjTab4GeneCodeEN obj = clsvPrjTab4GeneCodeBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPrjTab4GeneCodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabNameByTabIdCache(string strTabId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsvPrjTab4GeneCodeEN objvPrjTab4GeneCode = GetObjByTabIdCache(strTabId, strPrjId);
if (objvPrjTab4GeneCode == null) return "";
return objvPrjTab4GeneCode.TabName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabIdCache(string strTabId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsvPrjTab4GeneCodeEN objvPrjTab4GeneCode = GetObjByTabIdCache(strTabId, strPrjId);
if (objvPrjTab4GeneCode == null) return "";
return objvPrjTab4GeneCode.TabName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab4GeneCodeEN> GetAllvPrjTab4GeneCodeObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLstCache = GetObjLstCache(strPrjId); 
return arrvPrjTab4GeneCodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab4GeneCodeEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvPrjTab4GeneCodeEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjTab4GeneCodeObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvPrjTab4GeneCodeEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvPrjTab4GeneCodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjTab4GeneCodeEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjTab4GeneCodeEN._RefreshTimeLst[clsvPrjTab4GeneCodeEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTabId, string strPrjId)
{
if (strInFldName != convPrjTab4GeneCode.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjTab4GeneCode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjTab4GeneCode._AttributeName));
throw new Exception(strMsg);
}
var objvPrjTab4GeneCode = clsvPrjTab4GeneCodeBL.GetObjByTabIdCache(strTabId, strPrjId);
if (objvPrjTab4GeneCode == null) return "";
return objvPrjTab4GeneCode[strOutFldName].ToString();
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
int intRecCount = clsvPrjTab4GeneCodeDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjTab4GeneCodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjTab4GeneCodeDA.GetRecCount();
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
int intRecCount = clsvPrjTab4GeneCodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeCond)
{
 string strPrjId = objvPrjTab4GeneCodeCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPrjTab4GeneCodeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPrjTab4GeneCodeEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTab4GeneCode._AttributeName)
{
if (objvPrjTab4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTab4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab4GeneCodeCond[strFldName].ToString());
}
else
{
if (objvPrjTab4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTab4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTab4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTab4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTab4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTab4GeneCodeCond[strFldName]));
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
 List<string> arrList = clsvPrjTab4GeneCodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjTab4GeneCodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjTab4GeneCodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}