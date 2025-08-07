
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab_SimWApi
 表名:vPrjTab_Sim(00050597)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:11
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvPrjTab_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetTabId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab_Sim.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab_Sim.TabId);
objvPrjTab_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.TabId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.TabId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.TabId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetTabName(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab_Sim.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab_Sim.TabName);
objvPrjTab_SimEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.TabName) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.TabName, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.TabName] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetSqlDsTypeId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convPrjTab_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab_Sim.SqlDsTypeId);
objvPrjTab_SimEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.SqlDsTypeId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.SqlDsTypeId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.SqlDsTypeId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetFuncModuleAgcId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convPrjTab_Sim.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab_Sim.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab_Sim.FuncModuleAgcId);
objvPrjTab_SimEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.FuncModuleAgcId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.FuncModuleAgcId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.FuncModuleAgcId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetTabTypeId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab_Sim.TabTypeId);
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab_Sim.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab_Sim.TabTypeId);
objvPrjTab_SimEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.TabTypeId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.TabTypeId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.TabTypeId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheModeId">缓存方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetCacheModeId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strCacheModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, convPrjTab_Sim.CacheModeId);
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, convPrjTab_Sim.CacheModeId);
objvPrjTab_SimEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.CacheModeId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.CacheModeId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.CacheModeId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetTabStateId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab_Sim.TabStateId);
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab_Sim.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab_Sim.TabStateId);
objvPrjTab_SimEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.TabStateId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.TabStateId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.TabStateId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetPrjId(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTab_Sim.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTab_Sim.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTab_Sim.PrjId);
objvPrjTab_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.PrjId) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.PrjId, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.PrjId] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseName">数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetDataBaseName(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convPrjTab_Sim.DataBaseName);
objvPrjTab_SimEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.DataBaseName) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.DataBaseName, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.DataBaseName] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetUpdDate(this clsvPrjTab_SimEN objvPrjTab_SimEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjTab_Sim.UpdDate);
objvPrjTab_SimEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.UpdDate) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.UpdDate, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.UpdDate] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldNum">字段数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetFldNum(this clsvPrjTab_SimEN objvPrjTab_SimEN, int intFldNum, string strComparisonOp="")
	{
objvPrjTab_SimEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.FldNum) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.FldNum, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.FldNum] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsShare">是否共享</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimEN SetIsShare(this clsvPrjTab_SimEN objvPrjTab_SimEN, bool bolIsShare, string strComparisonOp="")
	{
objvPrjTab_SimEN.IsShare = bolIsShare; //是否共享
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimEN.dicFldComparisonOp.ContainsKey(convPrjTab_Sim.IsShare) == false)
{
objvPrjTab_SimEN.dicFldComparisonOp.Add(convPrjTab_Sim.IsShare, strComparisonOp);
}
else
{
objvPrjTab_SimEN.dicFldComparisonOp[convPrjTab_Sim.IsShare] = strComparisonOp;
}
}
return objvPrjTab_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTab_SimEN objvPrjTab_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.TabId) == true)
{
string strComparisonOpTabId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.TabId, objvPrjTab_SimCond.TabId, strComparisonOpTabId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.TabName) == true)
{
string strComparisonOpTabName = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.TabName, objvPrjTab_SimCond.TabName, strComparisonOpTabName);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.SqlDsTypeId, objvPrjTab_SimCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.FuncModuleAgcId, objvPrjTab_SimCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.TabTypeId, objvPrjTab_SimCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.CacheModeId, objvPrjTab_SimCond.CacheModeId, strComparisonOpCacheModeId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.TabStateId) == true)
{
string strComparisonOpTabStateId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.TabStateId, objvPrjTab_SimCond.TabStateId, strComparisonOpTabStateId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.PrjId, objvPrjTab_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.DataBaseName, objvPrjTab_SimCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_Sim.UpdDate, objvPrjTab_SimCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.FldNum) == true)
{
string strComparisonOpFldNum = objvPrjTab_SimCond.dicFldComparisonOp[convPrjTab_Sim.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab_Sim.FldNum, objvPrjTab_SimCond.FldNum, strComparisonOpFldNum);
}
if (objvPrjTab_SimCond.IsUpdated(convPrjTab_Sim.IsShare) == true)
{
if (objvPrjTab_SimCond.IsShare == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab_Sim.IsShare);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab_Sim.IsShare);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程表_Sim(vPrjTab_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTab_SimWApi
{
private static readonly string mstrApiControllerName = "vPrjTab_SimApi";

 public clsvPrjTab_SimWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程表_Sim]...","0");
List<clsvPrjTab_SimEN> arrObjLst = GetObjLst("1=1");
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

 /// <param name = "strCmPrjId"></param>
 /// <param name = "strPrjId"></param>
public static void BindCbo_TabId(System.Windows.Forms.ComboBox objComboBox , string strCmPrjId,string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjTab_Sim.TabId); 
List<clsvPrjTab_SimEN> arrObjLst = clsvPrjTab_SimWApi.GetObjLst(strCondition).OrderBy(x=>x.TabName).ToList();
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN()
{
TabId = "0",
TabName = "选[v工程表_Sim]..."
};
arrObjLstSel.Insert(0, objvPrjTab_SimEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjTab_Sim.TabId;
objComboBox.DisplayMember = convPrjTab_Sim.TabName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}
//该表下拉框功能不需要生成;

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab_SimEN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsvPrjTab_SimEN objvPrjTab_SimEN;
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
objvPrjTab_SimEN = JsonConvert.DeserializeObject<clsvPrjTab_SimEN>(strJson);
return objvPrjTab_SimEN;
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
public static clsvPrjTab_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjTab_SimEN objvPrjTab_SimEN;
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
objvPrjTab_SimEN = JsonConvert.DeserializeObject<clsvPrjTab_SimEN>(strJson);
return objvPrjTab_SimEN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab_SimEN GetObjByTabIdCache(string strTabId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimEN._CurrTabName, strPrjId);
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab_SimEN> arrvPrjTab_SimObjLst_Sel =
from objvPrjTab_SimEN in arrvPrjTab_SimObjLstCache
where objvPrjTab_SimEN.TabId == strTabId 
select objvPrjTab_SimEN;
if (arrvPrjTab_SimObjLst_Sel.Count() == 0)
{
   clsvPrjTab_SimEN obj = clsvPrjTab_SimWApi.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjTab_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabNameByTabIdCache(string strTabId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//初始化列表缓存
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab_SimEN> arrvPrjTab_SimObjLst_Sel1 =
from objvPrjTab_SimEN in arrvPrjTab_SimObjLstCache
where objvPrjTab_SimEN.TabId == strTabId 
select objvPrjTab_SimEN;
List <clsvPrjTab_SimEN> arrvPrjTab_SimObjLst_Sel = new List<clsvPrjTab_SimEN>();
foreach (clsvPrjTab_SimEN obj in arrvPrjTab_SimObjLst_Sel1)
{
arrvPrjTab_SimObjLst_Sel.Add(obj);
}
if (arrvPrjTab_SimObjLst_Sel.Count > 0)
{
return arrvPrjTab_SimObjLst_Sel[0].TabName;
}
string strErrMsgForGetObjById = string.Format("在vPrjTab_Sim对象缓存列表中,找不到记录[TabId = {0}](函数:{1})", strTabId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvPrjTab_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabIdCache(string strTabId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//初始化列表缓存
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab_SimEN> arrvPrjTab_SimObjLst_Sel1 =
from objvPrjTab_SimEN in arrvPrjTab_SimObjLstCache
where objvPrjTab_SimEN.TabId == strTabId 
select objvPrjTab_SimEN;
List <clsvPrjTab_SimEN> arrvPrjTab_SimObjLst_Sel = new List<clsvPrjTab_SimEN>();
foreach (clsvPrjTab_SimEN obj in arrvPrjTab_SimObjLst_Sel1)
{
arrvPrjTab_SimObjLst_Sel.Add(obj);
}
if (arrvPrjTab_SimObjLst_Sel.Count > 0)
{
return arrvPrjTab_SimObjLst_Sel[0].TabName;
}
string strErrMsgForGetObjById = string.Format("在vPrjTab_Sim对象缓存列表中,找不到记录的相关名称[TabId = {0}](函数:{1})", strTabId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvPrjTab_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimEN>>(strJson);
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
public static List<clsvPrjTab_SimEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsvPrjTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimEN>>(strJson);
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
 /// <param name = "arrTabId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvPrjTab_SimEN> GetObjLstByTabIdLstCache(List<string> arrTabId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimEN._CurrTabName, strPrjId);
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab_SimEN> arrvPrjTab_SimObjLst_Sel =
from objvPrjTab_SimEN in arrvPrjTab_SimObjLstCache
where arrTabId.Contains(objvPrjTab_SimEN.TabId)
select objvPrjTab_SimEN;
return arrvPrjTab_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimEN>>(strJson);
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
public static List<clsvPrjTab_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimEN>>(strJson);
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
public static List<clsvPrjTab_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimEN>>(strJson);
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
public static List<clsvPrjTab_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimEN>>(strJson);
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
 /// <param name = "objvPrjTab_SimENS">源对象</param>
 /// <param name = "objvPrjTab_SimENT">目标对象</param>
 public static void CopyTo(clsvPrjTab_SimEN objvPrjTab_SimENS, clsvPrjTab_SimEN objvPrjTab_SimENT)
{
try
{
objvPrjTab_SimENT.TabId = objvPrjTab_SimENS.TabId; //表ID
objvPrjTab_SimENT.TabName = objvPrjTab_SimENS.TabName; //表名
objvPrjTab_SimENT.SqlDsTypeId = objvPrjTab_SimENS.SqlDsTypeId; //数据源类型Id
objvPrjTab_SimENT.FuncModuleAgcId = objvPrjTab_SimENS.FuncModuleAgcId; //功能模块Id
objvPrjTab_SimENT.TabTypeId = objvPrjTab_SimENS.TabTypeId; //表类型Id
objvPrjTab_SimENT.CacheModeId = objvPrjTab_SimENS.CacheModeId; //缓存方式Id
objvPrjTab_SimENT.TabStateId = objvPrjTab_SimENS.TabStateId; //表状态ID
objvPrjTab_SimENT.PrjId = objvPrjTab_SimENS.PrjId; //工程Id
objvPrjTab_SimENT.DataBaseName = objvPrjTab_SimENS.DataBaseName; //数据库名
objvPrjTab_SimENT.UpdDate = objvPrjTab_SimENS.UpdDate; //修改日期
objvPrjTab_SimENT.FldNum = objvPrjTab_SimENS.FldNum; //字段数
objvPrjTab_SimENT.IsShare = objvPrjTab_SimENS.IsShare; //是否共享
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
public static DataTable ToDataTable(List<clsvPrjTab_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjTab_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjTab_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjTab_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjTab_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjTab_SimEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTab_SimWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTab_SimWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimEN._CurrTabName, strPrjId);
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
public static List<clsvPrjTab_SimEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTab_SimWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTab_SimWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvPrjTab_SimEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvPrjTab_SimEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convPrjTab_Sim.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvPrjTab_SimEN._CurrTabName, strPrjId);
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjTab_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab_SimEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvPrjTab_SimEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTab_SimWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTab_SimWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvPrjTab_SimEN._CurrTabName, strPrjId);
List<clsvPrjTab_SimEN> arrvPrjTab_SimObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvPrjTab_SimObjLstCache = CacheHelper.Get<List<clsvPrjTab_SimEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvPrjTab_SimObjLstCache = CacheHelper.Get<List<clsvPrjTab_SimEN>>(strKey);
}
return arrvPrjTab_SimObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjTab_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjTab_Sim.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.CacheModeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.DataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_Sim.FldNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTab_Sim.IsShare, Type.GetType("System.Boolean"));
foreach (clsvPrjTab_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjTab_Sim.TabId] = objInFor[convPrjTab_Sim.TabId];
objDR[convPrjTab_Sim.TabName] = objInFor[convPrjTab_Sim.TabName];
objDR[convPrjTab_Sim.SqlDsTypeId] = objInFor[convPrjTab_Sim.SqlDsTypeId];
objDR[convPrjTab_Sim.FuncModuleAgcId] = objInFor[convPrjTab_Sim.FuncModuleAgcId];
objDR[convPrjTab_Sim.TabTypeId] = objInFor[convPrjTab_Sim.TabTypeId];
objDR[convPrjTab_Sim.CacheModeId] = objInFor[convPrjTab_Sim.CacheModeId];
objDR[convPrjTab_Sim.TabStateId] = objInFor[convPrjTab_Sim.TabStateId];
objDR[convPrjTab_Sim.PrjId] = objInFor[convPrjTab_Sim.PrjId];
objDR[convPrjTab_Sim.DataBaseName] = objInFor[convPrjTab_Sim.DataBaseName];
objDR[convPrjTab_Sim.UpdDate] = objInFor[convPrjTab_Sim.UpdDate];
objDR[convPrjTab_Sim.FldNum] = objInFor[convPrjTab_Sim.FldNum];
objDR[convPrjTab_Sim.IsShare] = objInFor[convPrjTab_Sim.IsShare];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}