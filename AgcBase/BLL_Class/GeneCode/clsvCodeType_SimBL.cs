
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeType_SimBL
 表名:vCodeType_Sim(00050623)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:45
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
public static class  clsvCodeType_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCodeType_SimEN GetObj(this K_CodeTypeId_vCodeType_Sim myKey)
{
clsvCodeType_SimEN objvCodeType_SimEN = clsvCodeType_SimBL.vCodeType_SimDA.GetObjByCodeTypeId(myKey.Value);
return objvCodeType_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetCodeTypeId(this clsvCodeType_SimEN objvCodeType_SimEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convCodeType_Sim.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convCodeType_Sim.CodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetCodeTypeName(this clsvCodeType_SimEN objvCodeType_SimEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convCodeType_Sim.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convCodeType_Sim.CodeTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetCodeTypeENName(this clsvCodeType_SimEN objvCodeType_SimEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convCodeType_Sim.CodeTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetGroupName(this clsvCodeType_SimEN objvCodeType_SimEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convCodeType_Sim.GroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, convCodeType_Sim.GroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetDependsOn(this clsvCodeType_SimEN objvCodeType_SimEN, string strDependsOn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDependsOn, 50, convCodeType_Sim.DependsOn);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetFrontOrBack(this clsvCodeType_SimEN objvCodeType_SimEN, string strFrontOrBack, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFrontOrBack, 50, convCodeType_Sim.FrontOrBack);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetOrderNum(this clsvCodeType_SimEN objvCodeType_SimEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetProgLangTypeId(this clsvCodeType_SimEN objvCodeType_SimEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convCodeType_Sim.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCodeType_Sim.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCodeType_Sim.ProgLangTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetPrefix(this clsvCodeType_SimEN objvCodeType_SimEN, string strPrefix, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefix, 10, convCodeType_Sim.Prefix);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetAppCount(this clsvCodeType_SimEN objvCodeType_SimEN, int? intAppCount, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetFuncCount(this clsvCodeType_SimEN objvCodeType_SimEN, int? intFuncCount, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetClassNameFormat(this clsvCodeType_SimEN objvCodeType_SimEN, string strClassNameFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassNameFormat, 50, convCodeType_Sim.ClassNameFormat);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetCodeTypeSimName(this clsvCodeType_SimEN objvCodeType_SimEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, convCodeType_Sim.CodeTypeSimName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convCodeType_Sim.CodeTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetRegionTypeId(this clsvCodeType_SimEN objvCodeType_SimEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convCodeType_Sim.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convCodeType_Sim.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convCodeType_Sim.RegionTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetSqlDsTypeId(this clsvCodeType_SimEN objvCodeType_SimEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convCodeType_Sim.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convCodeType_Sim.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convCodeType_Sim.SqlDsTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeType_SimEN SetFileNameFormat(this clsvCodeType_SimEN objvCodeType_SimEN, string strFileNameFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNameFormat, 50, convCodeType_Sim.FileNameFormat);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCodeType_SimENS">源对象</param>
 /// <param name = "objvCodeType_SimENT">目标对象</param>
 public static void CopyTo(this clsvCodeType_SimEN objvCodeType_SimENS, clsvCodeType_SimEN objvCodeType_SimENT)
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
 /// <param name = "objvCodeType_SimENS">源对象</param>
 /// <returns>目标对象=>clsvCodeType_SimEN:objvCodeType_SimENT</returns>
 public static clsvCodeType_SimEN CopyTo(this clsvCodeType_SimEN objvCodeType_SimENS)
{
try
{
 clsvCodeType_SimEN objvCodeType_SimENT = new clsvCodeType_SimEN()
{
CodeTypeId = objvCodeType_SimENS.CodeTypeId, //代码类型Id
CodeTypeName = objvCodeType_SimENS.CodeTypeName, //代码类型名
CodeTypeENName = objvCodeType_SimENS.CodeTypeENName, //代码类型英文名
GroupName = objvCodeType_SimENS.GroupName, //组名
DependsOn = objvCodeType_SimENS.DependsOn, //依赖于
FrontOrBack = objvCodeType_SimENS.FrontOrBack, //前台Or后台
OrderNum = objvCodeType_SimENS.OrderNum, //序号
ProgLangTypeId = objvCodeType_SimENS.ProgLangTypeId, //编程语言类型Id
Prefix = objvCodeType_SimENS.Prefix, //前缀
AppCount = objvCodeType_SimENS.AppCount, //应用数
FuncCount = objvCodeType_SimENS.FuncCount, //函数数目
ClassNameFormat = objvCodeType_SimENS.ClassNameFormat, //类名格式
CodeTypeSimName = objvCodeType_SimENS.CodeTypeSimName, //简称
RegionTypeId = objvCodeType_SimENS.RegionTypeId, //区域类型Id
InUse = objvCodeType_SimENS.InUse, //是否在用
SqlDsTypeId = objvCodeType_SimENS.SqlDsTypeId, //数据源类型Id
IsDefaultOverride = objvCodeType_SimENS.IsDefaultOverride, //是否默认覆盖
IsExtend = objvCodeType_SimENS.IsExtend, //是否扩展类
IsAutoParseFile = objvCodeType_SimENS.IsAutoParseFile, //是否自动分析文件
FileNameFormat = objvCodeType_SimENS.FileNameFormat, //文件名格式
};
 return objvCodeType_SimENT;
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
public static void CheckProperty4Condition(this clsvCodeType_SimEN objvCodeType_SimEN)
{
 clsvCodeType_SimBL.vCodeType_SimDA.CheckProperty4Condition(objvCodeType_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCodeType_Sim
{
public virtual bool UpdRelaTabDate(string strCodeTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCodeType_Sim(vCodeType_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCodeType_SimBL
{
public static RelatedActions_vCodeType_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCodeType_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCodeType_SimDA vCodeType_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCodeType_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCodeType_SimBL()
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
if (string.IsNullOrEmpty(clsvCodeType_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCodeType_SimEN._ConnectString);
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
public static DataTable GetDataTable_vCodeType_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCodeType_SimDA.GetDataTable_vCodeType_Sim(strWhereCond);
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
objDT = vCodeType_SimDA.GetDataTable(strWhereCond);
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
objDT = vCodeType_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCodeType_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCodeType_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCodeType_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vCodeType_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCodeType_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCodeType_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCodeType_SimEN> GetObjLstByCodeTypeIdLst(List<string> arrCodeTypeIdLst)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
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
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCodeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCodeType_SimEN> GetObjLstByCodeTypeIdLstCache(List<string> arrCodeTypeIdLst)
{
string strKey = string.Format("{0}", clsvCodeType_SimEN._CurrTabName);
List<clsvCodeType_SimEN> arrvCodeType_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeType_SimEN> arrvCodeType_SimObjLst_Sel =
arrvCodeType_SimObjLstCache
.Where(x => arrCodeTypeIdLst.Contains(x.CodeTypeId));
return arrvCodeType_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeType_SimEN> GetObjLst(string strWhereCond)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
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
public static List<clsvCodeType_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCodeType_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCodeType_SimEN> GetSubObjLstCache(clsvCodeType_SimEN objvCodeType_SimCond)
{
List<clsvCodeType_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeType_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCodeType_Sim._AttributeName)
{
if (objvCodeType_SimCond.IsUpdated(strFldName) == false) continue;
if (objvCodeType_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeType_SimCond[strFldName].ToString());
}
else
{
if (objvCodeType_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCodeType_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeType_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCodeType_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCodeType_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCodeType_SimCond[strFldName]));
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
public static List<clsvCodeType_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
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
public static List<clsvCodeType_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
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
List<clsvCodeType_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCodeType_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeType_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCodeType_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
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
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
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
public static List<clsvCodeType_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCodeType_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCodeType_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
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
public static List<clsvCodeType_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeType_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeType_SimEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeType_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCodeType_Sim(ref clsvCodeType_SimEN objvCodeType_SimEN)
{
bool bolResult = vCodeType_SimDA.GetvCodeType_Sim(ref objvCodeType_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCodeType_SimEN GetObjByCodeTypeId(string strCodeTypeId)
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
clsvCodeType_SimEN objvCodeType_SimEN = vCodeType_SimDA.GetObjByCodeTypeId(strCodeTypeId);
return objvCodeType_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCodeType_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCodeType_SimEN objvCodeType_SimEN = vCodeType_SimDA.GetFirstObj(strWhereCond);
 return objvCodeType_SimEN;
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
public static clsvCodeType_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCodeType_SimEN objvCodeType_SimEN = vCodeType_SimDA.GetObjByDataRow(objRow);
 return objvCodeType_SimEN;
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
public static clsvCodeType_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCodeType_SimEN objvCodeType_SimEN = vCodeType_SimDA.GetObjByDataRow(objRow);
 return objvCodeType_SimEN;
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
 /// <param name = "lstvCodeType_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCodeType_SimEN GetObjByCodeTypeIdFromList(string strCodeTypeId, List<clsvCodeType_SimEN> lstvCodeType_SimObjLst)
{
foreach (clsvCodeType_SimEN objvCodeType_SimEN in lstvCodeType_SimObjLst)
{
if (objvCodeType_SimEN.CodeTypeId == strCodeTypeId)
{
return objvCodeType_SimEN;
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
 strCodeTypeId = new clsvCodeType_SimDA().GetFirstID(strWhereCond);
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
 arrList = vCodeType_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vCodeType_SimDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCodeType_SimDA.IsExist(strCodeTypeId);
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
 bolIsExist = clsvCodeType_SimDA.IsExistTable();
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
 bolIsExist = vCodeType_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvCodeType_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvCodeType_SimEN objvCodeType_SimEN)
{
try
{
objvCodeType_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCodeType_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCodeType_Sim.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.CodeTypeId = objvCodeType_SimEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convCodeType_Sim.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.CodeTypeName = objvCodeType_SimEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convCodeType_Sim.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.CodeTypeENName = objvCodeType_SimEN.CodeTypeENName == "[null]" ? null :  objvCodeType_SimEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(convCodeType_Sim.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.GroupName = objvCodeType_SimEN.GroupName; //组名
}
if (arrFldSet.Contains(convCodeType_Sim.DependsOn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.DependsOn = objvCodeType_SimEN.DependsOn == "[null]" ? null :  objvCodeType_SimEN.DependsOn; //依赖于
}
if (arrFldSet.Contains(convCodeType_Sim.FrontOrBack, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.FrontOrBack = objvCodeType_SimEN.FrontOrBack == "[null]" ? null :  objvCodeType_SimEN.FrontOrBack; //前台Or后台
}
if (arrFldSet.Contains(convCodeType_Sim.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.OrderNum = objvCodeType_SimEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCodeType_Sim.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.ProgLangTypeId = objvCodeType_SimEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convCodeType_Sim.Prefix, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.Prefix = objvCodeType_SimEN.Prefix == "[null]" ? null :  objvCodeType_SimEN.Prefix; //前缀
}
if (arrFldSet.Contains(convCodeType_Sim.AppCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.AppCount = objvCodeType_SimEN.AppCount; //应用数
}
if (arrFldSet.Contains(convCodeType_Sim.FuncCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.FuncCount = objvCodeType_SimEN.FuncCount; //函数数目
}
if (arrFldSet.Contains(convCodeType_Sim.ClassNameFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.ClassNameFormat = objvCodeType_SimEN.ClassNameFormat == "[null]" ? null :  objvCodeType_SimEN.ClassNameFormat; //类名格式
}
if (arrFldSet.Contains(convCodeType_Sim.CodeTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.CodeTypeSimName = objvCodeType_SimEN.CodeTypeSimName; //简称
}
if (arrFldSet.Contains(convCodeType_Sim.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.RegionTypeId = objvCodeType_SimEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convCodeType_Sim.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.InUse = objvCodeType_SimEN.InUse; //是否在用
}
if (arrFldSet.Contains(convCodeType_Sim.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.SqlDsTypeId = objvCodeType_SimEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convCodeType_Sim.IsDefaultOverride, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.IsDefaultOverride = objvCodeType_SimEN.IsDefaultOverride; //是否默认覆盖
}
if (arrFldSet.Contains(convCodeType_Sim.IsExtend, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.IsExtend = objvCodeType_SimEN.IsExtend; //是否扩展类
}
if (arrFldSet.Contains(convCodeType_Sim.IsAutoParseFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.IsAutoParseFile = objvCodeType_SimEN.IsAutoParseFile; //是否自动分析文件
}
if (arrFldSet.Contains(convCodeType_Sim.FileNameFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeType_SimEN.FileNameFormat = objvCodeType_SimEN.FileNameFormat == "[null]" ? null :  objvCodeType_SimEN.FileNameFormat; //文件名格式
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
 /// <param name = "objvCodeType_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCodeType_SimEN objvCodeType_SimEN)
{
try
{
if (objvCodeType_SimEN.CodeTypeENName == "[null]") objvCodeType_SimEN.CodeTypeENName = null; //代码类型英文名
if (objvCodeType_SimEN.DependsOn == "[null]") objvCodeType_SimEN.DependsOn = null; //依赖于
if (objvCodeType_SimEN.FrontOrBack == "[null]") objvCodeType_SimEN.FrontOrBack = null; //前台Or后台
if (objvCodeType_SimEN.Prefix == "[null]") objvCodeType_SimEN.Prefix = null; //前缀
if (objvCodeType_SimEN.ClassNameFormat == "[null]") objvCodeType_SimEN.ClassNameFormat = null; //类名格式
if (objvCodeType_SimEN.FileNameFormat == "[null]") objvCodeType_SimEN.FileNameFormat = null; //文件名格式
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
public static void CheckProperty4Condition(clsvCodeType_SimEN objvCodeType_SimEN)
{
 vCodeType_SimDA.CheckProperty4Condition(objvCodeType_SimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CodeTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCodeType_Sim]...","0");
List<clsvCodeType_SimEN> arrvCodeType_SimObjLst = GetAllvCodeType_SimObjLstCache(); 
arrvCodeType_SimObjLst = arrvCodeType_SimObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = convCodeType_Sim.CodeTypeId;
objDDL.DataTextField = convCodeType_Sim.CodeTypeName;
objDDL.DataSource = arrvCodeType_SimObjLst;
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
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CodeTypeId");
//if (arrvCodeType_SimObjLstCache == null)
//{
//arrvCodeType_SimObjLstCache = vCodeType_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCodeType_SimEN GetObjByCodeTypeIdCache(string strCodeTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCodeType_SimEN._CurrTabName);
List<clsvCodeType_SimEN> arrvCodeType_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeType_SimEN> arrvCodeType_SimObjLst_Sel =
arrvCodeType_SimObjLstCache
.Where(x=> x.CodeTypeId == strCodeTypeId 
);
if (arrvCodeType_SimObjLst_Sel.Count() == 0)
{
   clsvCodeType_SimEN obj = clsvCodeType_SimBL.GetObjByCodeTypeId(strCodeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCodeType_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCodeTypeNameByCodeTypeIdCache(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return "";
//获取缓存中的对象列表
clsvCodeType_SimEN objvCodeType_Sim = GetObjByCodeTypeIdCache(strCodeTypeId);
if (objvCodeType_Sim == null) return "";
return objvCodeType_Sim.CodeTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCodeTypeIdCache(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return "";
//获取缓存中的对象列表
clsvCodeType_SimEN objvCodeType_Sim = GetObjByCodeTypeIdCache(strCodeTypeId);
if (objvCodeType_Sim == null) return "";
return objvCodeType_Sim.CodeTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCodeType_SimEN> GetAllvCodeType_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvCodeType_SimEN> arrvCodeType_SimObjLstCache = GetObjLstCache(); 
return arrvCodeType_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCodeType_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCodeType_SimEN._CurrTabName);
List<clsvCodeType_SimEN> arrvCodeType_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCodeType_SimObjLstCache;
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
string strKey = string.Format("{0}", clsvCodeType_SimEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvCodeType_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCodeType_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvCodeType_SimEN._RefreshTimeLst[clsvCodeType_SimEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convCodeType_Sim.CodeTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCodeType_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCodeType_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvCodeType_Sim = clsvCodeType_SimBL.GetObjByCodeTypeIdCache(strCodeTypeId);
if (objvCodeType_Sim == null) return "";
return objvCodeType_Sim[strOutFldName].ToString();
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
int intRecCount = clsvCodeType_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvCodeType_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCodeType_SimDA.GetRecCount();
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
int intRecCount = clsvCodeType_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCodeType_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCodeType_SimEN objvCodeType_SimCond)
{
List<clsvCodeType_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCodeType_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCodeType_Sim._AttributeName)
{
if (objvCodeType_SimCond.IsUpdated(strFldName) == false) continue;
if (objvCodeType_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeType_SimCond[strFldName].ToString());
}
else
{
if (objvCodeType_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCodeType_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeType_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCodeType_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCodeType_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCodeType_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCodeType_SimCond[strFldName]));
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
 List<string> arrList = clsvCodeType_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCodeType_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCodeType_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}