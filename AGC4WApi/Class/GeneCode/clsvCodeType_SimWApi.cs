
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeType_SimWApi
 表名:vCodeType_Sim(00050623)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:01
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
public static class  clsvCodeType_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetCodeTypeId(this clsvCodeType_SimEN objvCodeType_SimEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCodeType_Sim.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCodeType_Sim.CodeTypeId);
objvCodeType_SimEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.CodeTypeId) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.CodeTypeId, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.CodeTypeId] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetCodeTypeName(this clsvCodeType_SimEN objvCodeType_SimEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convCodeType_Sim.CodeTypeName);
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convCodeType_Sim.CodeTypeName);
objvCodeType_SimEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.CodeTypeName) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.CodeTypeName, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.CodeTypeName] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeENName">代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetCodeTypeENName(this clsvCodeType_SimEN objvCodeType_SimEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convCodeType_Sim.CodeTypeENName);
objvCodeType_SimEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.CodeTypeENName) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.CodeTypeENName, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.CodeTypeENName] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetGroupName(this clsvCodeType_SimEN objvCodeType_SimEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convCodeType_Sim.GroupName);
clsCheckSql.CheckFieldLen(strGroupName, 30, convCodeType_Sim.GroupName);
objvCodeType_SimEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.GroupName) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.GroupName, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.GroupName] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDependsOn">依赖于</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetDependsOn(this clsvCodeType_SimEN objvCodeType_SimEN, string strDependsOn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDependsOn, 50, convCodeType_Sim.DependsOn);
objvCodeType_SimEN.DependsOn = strDependsOn; //依赖于
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.DependsOn) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.DependsOn, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.DependsOn] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFrontOrBack">前台Or后台</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetFrontOrBack(this clsvCodeType_SimEN objvCodeType_SimEN, string strFrontOrBack, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFrontOrBack, 50, convCodeType_Sim.FrontOrBack);
objvCodeType_SimEN.FrontOrBack = strFrontOrBack; //前台Or后台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.FrontOrBack) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.FrontOrBack, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.FrontOrBack] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetOrderNum(this clsvCodeType_SimEN objvCodeType_SimEN, int intOrderNum, string strComparisonOp="")
	{
objvCodeType_SimEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.OrderNum) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.OrderNum, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.OrderNum] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetProgLangTypeId(this clsvCodeType_SimEN objvCodeType_SimEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convCodeType_Sim.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCodeType_Sim.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCodeType_Sim.ProgLangTypeId);
objvCodeType_SimEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.ProgLangTypeId) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.ProgLangTypeId, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.ProgLangTypeId] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrefix">前缀</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetPrefix(this clsvCodeType_SimEN objvCodeType_SimEN, string strPrefix, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrefix, 10, convCodeType_Sim.Prefix);
objvCodeType_SimEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.Prefix) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.Prefix, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.Prefix] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intAppCount">应用数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetAppCount(this clsvCodeType_SimEN objvCodeType_SimEN, int intAppCount, string strComparisonOp="")
	{
objvCodeType_SimEN.AppCount = intAppCount; //应用数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.AppCount) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.AppCount, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.AppCount] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intFuncCount">函数数目</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetFuncCount(this clsvCodeType_SimEN objvCodeType_SimEN, int intFuncCount, string strComparisonOp="")
	{
objvCodeType_SimEN.FuncCount = intFuncCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.FuncCount) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.FuncCount, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.FuncCount] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassNameFormat">类名格式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetClassNameFormat(this clsvCodeType_SimEN objvCodeType_SimEN, string strClassNameFormat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClassNameFormat, 50, convCodeType_Sim.ClassNameFormat);
objvCodeType_SimEN.ClassNameFormat = strClassNameFormat; //类名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.ClassNameFormat) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.ClassNameFormat, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.ClassNameFormat] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeSimName">简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetCodeTypeSimName(this clsvCodeType_SimEN objvCodeType_SimEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, convCodeType_Sim.CodeTypeSimName);
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convCodeType_Sim.CodeTypeSimName);
objvCodeType_SimEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.CodeTypeSimName) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.CodeTypeSimName, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.CodeTypeSimName] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetRegionTypeId(this clsvCodeType_SimEN objvCodeType_SimEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convCodeType_Sim.RegionTypeId);
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convCodeType_Sim.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convCodeType_Sim.RegionTypeId);
objvCodeType_SimEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.RegionTypeId) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.RegionTypeId, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.RegionTypeId] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetInUse(this clsvCodeType_SimEN objvCodeType_SimEN, bool bolInUse, string strComparisonOp="")
	{
objvCodeType_SimEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.InUse) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.InUse, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.InUse] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetSqlDsTypeId(this clsvCodeType_SimEN objvCodeType_SimEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convCodeType_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convCodeType_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convCodeType_Sim.SqlDsTypeId);
objvCodeType_SimEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.SqlDsTypeId) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.SqlDsTypeId, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.SqlDsTypeId] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefaultOverride">是否默认覆盖</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetIsDefaultOverride(this clsvCodeType_SimEN objvCodeType_SimEN, bool bolIsDefaultOverride, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultOverride, convCodeType_Sim.IsDefaultOverride);
objvCodeType_SimEN.IsDefaultOverride = bolIsDefaultOverride; //是否默认覆盖
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.IsDefaultOverride) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.IsDefaultOverride, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.IsDefaultOverride] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExtend">是否扩展类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetIsExtend(this clsvCodeType_SimEN objvCodeType_SimEN, bool bolIsExtend, string strComparisonOp="")
	{
objvCodeType_SimEN.IsExtend = bolIsExtend; //是否扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.IsExtend) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.IsExtend, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.IsExtend] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAutoParseFile">是否自动分析文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetIsAutoParseFile(this clsvCodeType_SimEN objvCodeType_SimEN, bool bolIsAutoParseFile, string strComparisonOp="")
	{
objvCodeType_SimEN.IsAutoParseFile = bolIsAutoParseFile; //是否自动分析文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.IsAutoParseFile) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.IsAutoParseFile, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.IsAutoParseFile] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileNameFormat">文件名格式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetFileNameFormat(this clsvCodeType_SimEN objvCodeType_SimEN, string strFileNameFormat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNameFormat, 50, convCodeType_Sim.FileNameFormat);
objvCodeType_SimEN.FileNameFormat = strFileNameFormat; //文件名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeType_SimEN.dicFldComparisonOp.ContainsKey(convCodeType_Sim.FileNameFormat) == false)
{
objvCodeType_SimEN.dicFldComparisonOp.Add(convCodeType_Sim.FileNameFormat, strComparisonOp);
}
else
{
objvCodeType_SimEN.dicFldComparisonOp[convCodeType_Sim.FileNameFormat] = strComparisonOp;
}
}
return objvCodeType_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCodeType_SimEN objvCodeType_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.CodeTypeId, objvCodeType_SimCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.CodeTypeName, objvCodeType_SimCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.CodeTypeENName, objvCodeType_SimCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.GroupName) == true)
{
string strComparisonOpGroupName = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.GroupName, objvCodeType_SimCond.GroupName, strComparisonOpGroupName);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.DependsOn) == true)
{
string strComparisonOpDependsOn = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.DependsOn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.DependsOn, objvCodeType_SimCond.DependsOn, strComparisonOpDependsOn);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.FrontOrBack) == true)
{
string strComparisonOpFrontOrBack = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.FrontOrBack];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.FrontOrBack, objvCodeType_SimCond.FrontOrBack, strComparisonOpFrontOrBack);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCodeType_Sim.OrderNum, objvCodeType_SimCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.ProgLangTypeId, objvCodeType_SimCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.Prefix) == true)
{
string strComparisonOpPrefix = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.Prefix, objvCodeType_SimCond.Prefix, strComparisonOpPrefix);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.AppCount) == true)
{
string strComparisonOpAppCount = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.AppCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCodeType_Sim.AppCount, objvCodeType_SimCond.AppCount, strComparisonOpAppCount);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.FuncCount) == true)
{
string strComparisonOpFuncCount = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.FuncCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCodeType_Sim.FuncCount, objvCodeType_SimCond.FuncCount, strComparisonOpFuncCount);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.ClassNameFormat) == true)
{
string strComparisonOpClassNameFormat = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.ClassNameFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.ClassNameFormat, objvCodeType_SimCond.ClassNameFormat, strComparisonOpClassNameFormat);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.CodeTypeSimName) == true)
{
string strComparisonOpCodeTypeSimName = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.CodeTypeSimName, objvCodeType_SimCond.CodeTypeSimName, strComparisonOpCodeTypeSimName);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.RegionTypeId, objvCodeType_SimCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.InUse) == true)
{
if (objvCodeType_SimCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType_Sim.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType_Sim.InUse);
}
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.SqlDsTypeId, objvCodeType_SimCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.IsDefaultOverride) == true)
{
if (objvCodeType_SimCond.IsDefaultOverride == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType_Sim.IsDefaultOverride);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType_Sim.IsDefaultOverride);
}
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.IsExtend) == true)
{
if (objvCodeType_SimCond.IsExtend == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType_Sim.IsExtend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType_Sim.IsExtend);
}
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.IsAutoParseFile) == true)
{
if (objvCodeType_SimCond.IsAutoParseFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCodeType_Sim.IsAutoParseFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCodeType_Sim.IsAutoParseFile);
}
}
if (objvCodeType_SimCond.IsUpdated(convCodeType_Sim.FileNameFormat) == true)
{
string strComparisonOpFileNameFormat = objvCodeType_SimCond.dicFldComparisonOp[convCodeType_Sim.FileNameFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeType_Sim.FileNameFormat, objvCodeType_SimCond.FileNameFormat, strComparisonOpFileNameFormat);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCodeType_Sim(vCodeType_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCodeType_SimWApi
{
private static readonly string mstrApiControllerName = "vCodeType_SimApi";

 public clsvCodeType_SimWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCodeType_Sim]...","0");
List<clsvCodeType_SimEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convCodeType_Sim.CodeTypeId); 
List<clsvCodeType_SimEN> arrObjLst = clsvCodeType_SimWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.ProgLangTypeId == strProgLangTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN()
{
CodeTypeId = "0",
CodeTypeName = "选[vCodeType_Sim]..."
};
arrObjLstSel.Insert(0, objvCodeType_SimEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCodeType_Sim.CodeTypeId;
objComboBox.DisplayMember = convCodeType_Sim.CodeTypeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCodeType_SimEN GetObjByCodeTypeId(string strCodeTypeId)
{
if (strCodeTypeId == "") return null;
string strAction = "GetObjByCodeTypeId";
clsvCodeType_SimEN objvCodeType_SimEN;
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
objvCodeType_SimEN = JsonConvert.DeserializeObject<clsvCodeType_SimEN>(strJson);
return objvCodeType_SimEN;
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
public static clsvCodeType_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCodeType_SimEN objvCodeType_SimEN;
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
objvCodeType_SimEN = JsonConvert.DeserializeObject<clsvCodeType_SimEN>(strJson);
return objvCodeType_SimEN;
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
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCodeType_SimEN GetObjByCodeTypeIdCache(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCodeType_SimEN._CurrTabName);
List<clsvCodeType_SimEN> arrvCodeType_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeType_SimEN> arrvCodeType_SimObjLst_Sel =
from objvCodeType_SimEN in arrvCodeType_SimObjLstCache
where objvCodeType_SimEN.CodeTypeId == strCodeTypeId 
select objvCodeType_SimEN;
if (arrvCodeType_SimObjLst_Sel.Count() == 0)
{
   clsvCodeType_SimEN obj = clsvCodeType_SimWApi.GetObjByCodeTypeId(strCodeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCodeType_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCodeTypeNameByCodeTypeIdCache(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return "";
//初始化列表缓存
List<clsvCodeType_SimEN> arrvCodeType_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeType_SimEN> arrvCodeType_SimObjLst_Sel1 =
from objvCodeType_SimEN in arrvCodeType_SimObjLstCache
where objvCodeType_SimEN.CodeTypeId == strCodeTypeId 
select objvCodeType_SimEN;
List <clsvCodeType_SimEN> arrvCodeType_SimObjLst_Sel = new List<clsvCodeType_SimEN>();
foreach (clsvCodeType_SimEN obj in arrvCodeType_SimObjLst_Sel1)
{
arrvCodeType_SimObjLst_Sel.Add(obj);
}
if (arrvCodeType_SimObjLst_Sel.Count > 0)
{
return arrvCodeType_SimObjLst_Sel[0].CodeTypeName;
}
string strErrMsgForGetObjById = string.Format("在vCodeType_Sim对象缓存列表中,找不到记录[CodeTypeId = {0}](函数:{1})", strCodeTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCodeType_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCodeTypeIdCache(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return "";
//初始化列表缓存
List<clsvCodeType_SimEN> arrvCodeType_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeType_SimEN> arrvCodeType_SimObjLst_Sel1 =
from objvCodeType_SimEN in arrvCodeType_SimObjLstCache
where objvCodeType_SimEN.CodeTypeId == strCodeTypeId 
select objvCodeType_SimEN;
List <clsvCodeType_SimEN> arrvCodeType_SimObjLst_Sel = new List<clsvCodeType_SimEN>();
foreach (clsvCodeType_SimEN obj in arrvCodeType_SimObjLst_Sel1)
{
arrvCodeType_SimObjLst_Sel.Add(obj);
}
if (arrvCodeType_SimObjLst_Sel.Count > 0)
{
return arrvCodeType_SimObjLst_Sel[0].CodeTypeName;
}
string strErrMsgForGetObjById = string.Format("在vCodeType_Sim对象缓存列表中,找不到记录的相关名称[CodeTypeId = {0}](函数:{1})", strCodeTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCodeType_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeType_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvCodeType_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeType_SimEN>>(strJson);
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
public static List<clsvCodeType_SimEN> GetObjLstByCodeTypeIdLst(List<string> arrCodeTypeId)
{
 List<clsvCodeType_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeType_SimEN>>(strJson);
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
 /// <param name = "arrCodeTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCodeType_SimEN> GetObjLstByCodeTypeIdLstCache(List<string> arrCodeTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCodeType_SimEN._CurrTabName);
List<clsvCodeType_SimEN> arrvCodeType_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeType_SimEN> arrvCodeType_SimObjLst_Sel =
from objvCodeType_SimEN in arrvCodeType_SimObjLstCache
where arrCodeTypeId.Contains(objvCodeType_SimEN.CodeTypeId)
select objvCodeType_SimEN;
return arrvCodeType_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeType_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCodeType_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeType_SimEN>>(strJson);
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
public static List<clsvCodeType_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCodeType_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeType_SimEN>>(strJson);
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
public static List<clsvCodeType_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCodeType_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeType_SimEN>>(strJson);
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
public static List<clsvCodeType_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCodeType_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeType_SimEN>>(strJson);
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
 /// <param name = "objvCodeType_SimENS">源对象</param>
 /// <param name = "objvCodeType_SimENT">目标对象</param>
 public static void CopyTo(clsvCodeType_SimEN objvCodeType_SimENS, clsvCodeType_SimEN objvCodeType_SimENT)
{
try
{
objvCodeType_SimENT.CodeTypeId = objvCodeType_SimENS.CodeTypeId; //代码类型Id
objvCodeType_SimENT.CodeTypeName = objvCodeType_SimENS.CodeTypeName; //代码类型名
objvCodeType_SimENT.CodeTypeENName = objvCodeType_SimENS.CodeTypeENName; //代码类型英文名
objvCodeType_SimENT.GroupName = objvCodeType_SimENS.GroupName; //组名
objvCodeType_SimENT.DependsOn = objvCodeType_SimENS.DependsOn; //依赖于
objvCodeType_SimENT.FrontOrBack = objvCodeType_SimENS.FrontOrBack; //前台Or后台
objvCodeType_SimENT.OrderNum = objvCodeType_SimENS.OrderNum; //序号
objvCodeType_SimENT.ProgLangTypeId = objvCodeType_SimENS.ProgLangTypeId; //编程语言类型Id
objvCodeType_SimENT.Prefix = objvCodeType_SimENS.Prefix; //前缀
objvCodeType_SimENT.AppCount = objvCodeType_SimENS.AppCount; //应用数
objvCodeType_SimENT.FuncCount = objvCodeType_SimENS.FuncCount; //函数数目
objvCodeType_SimENT.ClassNameFormat = objvCodeType_SimENS.ClassNameFormat; //类名格式
objvCodeType_SimENT.CodeTypeSimName = objvCodeType_SimENS.CodeTypeSimName; //简称
objvCodeType_SimENT.RegionTypeId = objvCodeType_SimENS.RegionTypeId; //区域类型Id
objvCodeType_SimENT.InUse = objvCodeType_SimENS.InUse; //是否在用
objvCodeType_SimENT.SqlDsTypeId = objvCodeType_SimENS.SqlDsTypeId; //数据源类型Id
objvCodeType_SimENT.IsDefaultOverride = objvCodeType_SimENS.IsDefaultOverride; //是否默认覆盖
objvCodeType_SimENT.IsExtend = objvCodeType_SimENS.IsExtend; //是否扩展类
objvCodeType_SimENT.IsAutoParseFile = objvCodeType_SimENS.IsAutoParseFile; //是否自动分析文件
objvCodeType_SimENT.FileNameFormat = objvCodeType_SimENS.FileNameFormat; //文件名格式
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
public static DataTable ToDataTable(List<clsvCodeType_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCodeType_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCodeType_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCodeType_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCodeType_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCodeType_SimEN._AttributeName)
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
string strKey = string.Format("{0}", clsvCodeType_SimEN._CurrTabName);
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
public static List<clsvCodeType_SimEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvCodeType_SimEN._CurrTabName;
List<clsvCodeType_SimEN> arrvCodeType_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCodeType_SimObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCodeType_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCodeType_Sim.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.DependsOn, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.FrontOrBack, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCodeType_Sim.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.Prefix, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.AppCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCodeType_Sim.FuncCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCodeType_Sim.ClassNameFormat, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.CodeTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType_Sim.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeType_Sim.IsDefaultOverride, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType_Sim.IsExtend, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType_Sim.IsAutoParseFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCodeType_Sim.FileNameFormat, Type.GetType("System.String"));
foreach (clsvCodeType_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCodeType_Sim.CodeTypeId] = objInFor[convCodeType_Sim.CodeTypeId];
objDR[convCodeType_Sim.CodeTypeName] = objInFor[convCodeType_Sim.CodeTypeName];
objDR[convCodeType_Sim.CodeTypeENName] = objInFor[convCodeType_Sim.CodeTypeENName];
objDR[convCodeType_Sim.GroupName] = objInFor[convCodeType_Sim.GroupName];
objDR[convCodeType_Sim.DependsOn] = objInFor[convCodeType_Sim.DependsOn];
objDR[convCodeType_Sim.FrontOrBack] = objInFor[convCodeType_Sim.FrontOrBack];
objDR[convCodeType_Sim.OrderNum] = objInFor[convCodeType_Sim.OrderNum];
objDR[convCodeType_Sim.ProgLangTypeId] = objInFor[convCodeType_Sim.ProgLangTypeId];
objDR[convCodeType_Sim.Prefix] = objInFor[convCodeType_Sim.Prefix];
objDR[convCodeType_Sim.AppCount] = objInFor[convCodeType_Sim.AppCount];
objDR[convCodeType_Sim.FuncCount] = objInFor[convCodeType_Sim.FuncCount];
objDR[convCodeType_Sim.ClassNameFormat] = objInFor[convCodeType_Sim.ClassNameFormat];
objDR[convCodeType_Sim.CodeTypeSimName] = objInFor[convCodeType_Sim.CodeTypeSimName];
objDR[convCodeType_Sim.RegionTypeId] = objInFor[convCodeType_Sim.RegionTypeId];
objDR[convCodeType_Sim.InUse] = objInFor[convCodeType_Sim.InUse];
objDR[convCodeType_Sim.SqlDsTypeId] = objInFor[convCodeType_Sim.SqlDsTypeId];
objDR[convCodeType_Sim.IsDefaultOverride] = objInFor[convCodeType_Sim.IsDefaultOverride];
objDR[convCodeType_Sim.IsExtend] = objInFor[convCodeType_Sim.IsExtend];
objDR[convCodeType_Sim.IsAutoParseFile] = objInFor[convCodeType_Sim.IsAutoParseFile];
objDR[convCodeType_Sim.FileNameFormat] = objInFor[convCodeType_Sim.FileNameFormat];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}