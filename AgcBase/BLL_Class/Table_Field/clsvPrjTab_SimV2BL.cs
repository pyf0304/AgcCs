
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab_SimV2BL
 表名:vPrjTab_SimV2(00050610)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvPrjTab_SimV2BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab_SimV2EN GetObj(this K_TabId_vPrjTab_SimV2 myKey)
{
clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = clsvPrjTab_SimV2BL.vPrjTab_SimV2DA.GetObjByTabId(myKey.Value);
return objvPrjTab_SimV2EN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetTabId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab_SimV2.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab_SimV2.TabId);
}
objvPrjTab_SimV2EN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.TabId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.TabId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.TabId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetTabName(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab_SimV2.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab_SimV2.TabName);
}
objvPrjTab_SimV2EN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.TabName) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.TabName, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.TabName] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetSqlDsTypeId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convPrjTab_SimV2.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab_SimV2.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab_SimV2.SqlDsTypeId);
}
objvPrjTab_SimV2EN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.SqlDsTypeId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.SqlDsTypeId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.SqlDsTypeId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetFuncModuleAgcId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convPrjTab_SimV2.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab_SimV2.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab_SimV2.FuncModuleAgcId);
}
objvPrjTab_SimV2EN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.FuncModuleAgcId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.FuncModuleAgcId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.FuncModuleAgcId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetTabTypeId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab_SimV2.TabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab_SimV2.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab_SimV2.TabTypeId);
}
objvPrjTab_SimV2EN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.TabTypeId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.TabTypeId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.TabTypeId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetCacheModeId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strCacheModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, convPrjTab_SimV2.CacheModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, convPrjTab_SimV2.CacheModeId);
}
objvPrjTab_SimV2EN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.CacheModeId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.CacheModeId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.CacheModeId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetTabStateId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab_SimV2.TabStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab_SimV2.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab_SimV2.TabStateId);
}
objvPrjTab_SimV2EN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.TabStateId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.TabStateId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.TabStateId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetCmPrjId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convPrjTab_SimV2.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convPrjTab_SimV2.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convPrjTab_SimV2.CmPrjId);
}
objvPrjTab_SimV2EN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.CmPrjId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.CmPrjId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.CmPrjId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2ENS">源对象</param>
 /// <param name = "objvPrjTab_SimV2ENT">目标对象</param>
 public static void CopyTo(this clsvPrjTab_SimV2EN objvPrjTab_SimV2ENS, clsvPrjTab_SimV2EN objvPrjTab_SimV2ENT)
{
try
{
objvPrjTab_SimV2ENT.TabId = objvPrjTab_SimV2ENS.TabId; //表ID
objvPrjTab_SimV2ENT.TabName = objvPrjTab_SimV2ENS.TabName; //表名
objvPrjTab_SimV2ENT.SqlDsTypeId = objvPrjTab_SimV2ENS.SqlDsTypeId; //数据源类型Id
objvPrjTab_SimV2ENT.FuncModuleAgcId = objvPrjTab_SimV2ENS.FuncModuleAgcId; //功能模块Id
objvPrjTab_SimV2ENT.TabTypeId = objvPrjTab_SimV2ENS.TabTypeId; //表类型Id
objvPrjTab_SimV2ENT.CacheModeId = objvPrjTab_SimV2ENS.CacheModeId; //缓存方式Id
objvPrjTab_SimV2ENT.TabStateId = objvPrjTab_SimV2ENS.TabStateId; //表状态ID
objvPrjTab_SimV2ENT.CmPrjId = objvPrjTab_SimV2ENS.CmPrjId; //Cm工程Id
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
 /// <param name = "objvPrjTab_SimV2ENS">源对象</param>
 /// <returns>目标对象=>clsvPrjTab_SimV2EN:objvPrjTab_SimV2ENT</returns>
 public static clsvPrjTab_SimV2EN CopyTo(this clsvPrjTab_SimV2EN objvPrjTab_SimV2ENS)
{
try
{
 clsvPrjTab_SimV2EN objvPrjTab_SimV2ENT = new clsvPrjTab_SimV2EN()
{
TabId = objvPrjTab_SimV2ENS.TabId, //表ID
TabName = objvPrjTab_SimV2ENS.TabName, //表名
SqlDsTypeId = objvPrjTab_SimV2ENS.SqlDsTypeId, //数据源类型Id
FuncModuleAgcId = objvPrjTab_SimV2ENS.FuncModuleAgcId, //功能模块Id
TabTypeId = objvPrjTab_SimV2ENS.TabTypeId, //表类型Id
CacheModeId = objvPrjTab_SimV2ENS.CacheModeId, //缓存方式Id
TabStateId = objvPrjTab_SimV2ENS.TabStateId, //表状态ID
CmPrjId = objvPrjTab_SimV2ENS.CmPrjId, //Cm工程Id
};
 return objvPrjTab_SimV2ENT;
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
public static void CheckProperty4Condition(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN)
{
 clsvPrjTab_SimV2BL.vPrjTab_SimV2DA.CheckProperty4Condition(objvPrjTab_SimV2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTab_SimV2EN objvPrjTab_SimV2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.TabId) == true)
{
string strComparisonOpTabId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.TabId, objvPrjTab_SimV2Cond.TabId, strComparisonOpTabId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.TabName) == true)
{
string strComparisonOpTabName = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.TabName, objvPrjTab_SimV2Cond.TabName, strComparisonOpTabName);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.SqlDsTypeId, objvPrjTab_SimV2Cond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.FuncModuleAgcId, objvPrjTab_SimV2Cond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.TabTypeId, objvPrjTab_SimV2Cond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.CacheModeId, objvPrjTab_SimV2Cond.CacheModeId, strComparisonOpCacheModeId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.TabStateId) == true)
{
string strComparisonOpTabStateId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.TabStateId, objvPrjTab_SimV2Cond.TabStateId, strComparisonOpTabStateId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.CmPrjId, objvPrjTab_SimV2Cond.CmPrjId, strComparisonOpCmPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjTab_SimV2
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程表_SimV2(vPrjTab_SimV2)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTab_SimV2BL
{
public static RelatedActions_vPrjTab_SimV2 relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjTab_SimV2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjTab_SimV2DA vPrjTab_SimV2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjTab_SimV2DA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjTab_SimV2BL()
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
if (string.IsNullOrEmpty(clsvPrjTab_SimV2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTab_SimV2EN._ConnectString);
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
public static DataTable GetDataTable_vPrjTab_SimV2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTab_SimV2DA.GetDataTable_vPrjTab_SimV2(strWhereCond);
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
objDT = vPrjTab_SimV2DA.GetDataTable(strWhereCond);
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
objDT = vPrjTab_SimV2DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjTab_SimV2DA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjTab_SimV2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjTab_SimV2DA.GetDataTable_Top(objTopPara);
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
objDT = vPrjTab_SimV2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjTab_SimV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjTab_SimV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvPrjTab_SimV2EN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
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
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjTab_SimV2EN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst, string strCmPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLst_Sel =
arrvPrjTab_SimV2ObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrvPrjTab_SimV2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetObjLst(string strWhereCond)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
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
public static List<clsvPrjTab_SimV2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjTab_SimV2EN> GetSubObjLstCache(clsvPrjTab_SimV2EN objvPrjTab_SimV2Cond)
{
 string strCmPrjId = objvPrjTab_SimV2Cond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPrjTab_SimV2BL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPrjTab_SimV2EN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTab_SimV2._AttributeName)
{
if (objvPrjTab_SimV2Cond.IsUpdated(strFldName) == false) continue;
if (objvPrjTab_SimV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab_SimV2Cond[strFldName].ToString());
}
else
{
if (objvPrjTab_SimV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTab_SimV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab_SimV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTab_SimV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTab_SimV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTab_SimV2Cond[strFldName]));
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
public static List<clsvPrjTab_SimV2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
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
public static List<clsvPrjTab_SimV2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
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
List<clsvPrjTab_SimV2EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjTab_SimV2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjTab_SimV2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
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
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
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
public static List<clsvPrjTab_SimV2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjTab_SimV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
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
public static List<clsvPrjTab_SimV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjTab_SimV2EN> arrObjLst = new List<clsvPrjTab_SimV2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = new clsvPrjTab_SimV2EN();
try
{
objvPrjTab_SimV2EN.TabId = objRow[convPrjTab_SimV2.TabId].ToString().Trim(); //表ID
objvPrjTab_SimV2EN.TabName = objRow[convPrjTab_SimV2.TabName].ToString().Trim(); //表名
objvPrjTab_SimV2EN.SqlDsTypeId = objRow[convPrjTab_SimV2.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimV2EN.FuncModuleAgcId = objRow[convPrjTab_SimV2.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimV2EN.TabTypeId = objRow[convPrjTab_SimV2.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimV2EN.CacheModeId = objRow[convPrjTab_SimV2.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_SimV2.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimV2EN.TabStateId = objRow[convPrjTab_SimV2.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimV2EN.CmPrjId = objRow[convPrjTab_SimV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab_SimV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab_SimV2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjTab_SimV2(ref clsvPrjTab_SimV2EN objvPrjTab_SimV2EN)
{
bool bolResult = vPrjTab_SimV2DA.GetvPrjTab_SimV2(ref objvPrjTab_SimV2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab_SimV2EN GetObjByTabId(string strTabId)
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
clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = vPrjTab_SimV2DA.GetObjByTabId(strTabId);
return objvPrjTab_SimV2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjTab_SimV2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = vPrjTab_SimV2DA.GetFirstObj(strWhereCond);
 return objvPrjTab_SimV2EN;
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
public static clsvPrjTab_SimV2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = vPrjTab_SimV2DA.GetObjByDataRow(objRow);
 return objvPrjTab_SimV2EN;
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
public static clsvPrjTab_SimV2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjTab_SimV2EN objvPrjTab_SimV2EN = vPrjTab_SimV2DA.GetObjByDataRow(objRow);
 return objvPrjTab_SimV2EN;
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
 /// <param name = "lstvPrjTab_SimV2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab_SimV2EN GetObjByTabIdFromList(string strTabId, List<clsvPrjTab_SimV2EN> lstvPrjTab_SimV2ObjLst)
{
foreach (clsvPrjTab_SimV2EN objvPrjTab_SimV2EN in lstvPrjTab_SimV2ObjLst)
{
if (objvPrjTab_SimV2EN.TabId == strTabId)
{
return objvPrjTab_SimV2EN;
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
 strTabId = new clsvPrjTab_SimV2DA().GetFirstID(strWhereCond);
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
 arrList = vPrjTab_SimV2DA.GetID(strWhereCond);
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
bool bolIsExist = vPrjTab_SimV2DA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vPrjTab_SimV2DA.IsExist(strTabId);
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
 bolIsExist = clsvPrjTab_SimV2DA.IsExistTable();
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
 bolIsExist = vPrjTab_SimV2DA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjTab_SimV2ENS">源对象</param>
 /// <param name = "objvPrjTab_SimV2ENT">目标对象</param>
 public static void CopyTo(clsvPrjTab_SimV2EN objvPrjTab_SimV2ENS, clsvPrjTab_SimV2EN objvPrjTab_SimV2ENT)
{
try
{
objvPrjTab_SimV2ENT.TabId = objvPrjTab_SimV2ENS.TabId; //表ID
objvPrjTab_SimV2ENT.TabName = objvPrjTab_SimV2ENS.TabName; //表名
objvPrjTab_SimV2ENT.SqlDsTypeId = objvPrjTab_SimV2ENS.SqlDsTypeId; //数据源类型Id
objvPrjTab_SimV2ENT.FuncModuleAgcId = objvPrjTab_SimV2ENS.FuncModuleAgcId; //功能模块Id
objvPrjTab_SimV2ENT.TabTypeId = objvPrjTab_SimV2ENS.TabTypeId; //表类型Id
objvPrjTab_SimV2ENT.CacheModeId = objvPrjTab_SimV2ENS.CacheModeId; //缓存方式Id
objvPrjTab_SimV2ENT.TabStateId = objvPrjTab_SimV2ENS.TabStateId; //表状态ID
objvPrjTab_SimV2ENT.CmPrjId = objvPrjTab_SimV2ENS.CmPrjId; //Cm工程Id
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
 /// <param name = "objvPrjTab_SimV2EN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjTab_SimV2EN objvPrjTab_SimV2EN)
{
try
{
objvPrjTab_SimV2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjTab_SimV2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjTab_SimV2.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimV2EN.TabId = objvPrjTab_SimV2EN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjTab_SimV2.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimV2EN.TabName = objvPrjTab_SimV2EN.TabName; //表名
}
if (arrFldSet.Contains(convPrjTab_SimV2.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimV2EN.SqlDsTypeId = objvPrjTab_SimV2EN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convPrjTab_SimV2.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimV2EN.FuncModuleAgcId = objvPrjTab_SimV2EN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convPrjTab_SimV2.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimV2EN.TabTypeId = objvPrjTab_SimV2EN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(convPrjTab_SimV2.CacheModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimV2EN.CacheModeId = objvPrjTab_SimV2EN.CacheModeId == "[null]" ? null :  objvPrjTab_SimV2EN.CacheModeId; //缓存方式Id
}
if (arrFldSet.Contains(convPrjTab_SimV2.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimV2EN.TabStateId = objvPrjTab_SimV2EN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convPrjTab_SimV2.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab_SimV2EN.CmPrjId = objvPrjTab_SimV2EN.CmPrjId; //Cm工程Id
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
 /// <param name = "objvPrjTab_SimV2EN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjTab_SimV2EN objvPrjTab_SimV2EN)
{
try
{
if (objvPrjTab_SimV2EN.CacheModeId == "[null]") objvPrjTab_SimV2EN.CacheModeId = null; //缓存方式Id
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
public static void CheckProperty4Condition(clsvPrjTab_SimV2EN objvPrjTab_SimV2EN)
{
 vPrjTab_SimV2DA.CheckProperty4Condition(objvPrjTab_SimV2EN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCmPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程表_SimV2]...","0");
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLst = GetAllvPrjTab_SimV2ObjLstCache(strCmPrjId); 
objDDL.DataValueField = convPrjTab_SimV2.TabId;
objDDL.DataTextField = convPrjTab_SimV2.TabName;
objDDL.DataSource = arrvPrjTab_SimV2ObjLst;
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrvPrjTab_SimV2ObjLstCache == null)
//{
//arrvPrjTab_SimV2ObjLstCache = vPrjTab_SimV2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab_SimV2EN GetObjByTabIdCache(string strTabId, string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLst_Sel =
arrvPrjTab_SimV2ObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrvPrjTab_SimV2ObjLst_Sel.Count() == 0)
{
   clsvPrjTab_SimV2EN obj = clsvPrjTab_SimV2BL.GetObjByTabId(strTabId);
   if (obj != null)
 {
if (obj.CmPrjId == strCmPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabId, strCmPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPrjTab_SimV2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabNameByTabIdCache(string strTabId, string strCmPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsvPrjTab_SimV2EN objvPrjTab_SimV2 = GetObjByTabIdCache(strTabId, strCmPrjId);
if (objvPrjTab_SimV2 == null) return "";
return objvPrjTab_SimV2.TabName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabIdCache(string strTabId, string strCmPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsvPrjTab_SimV2EN objvPrjTab_SimV2 = GetObjByTabIdCache(strTabId, strCmPrjId);
if (objvPrjTab_SimV2 == null) return "";
return objvPrjTab_SimV2.TabName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetAllvPrjTab_SimV2ObjLstCache(string strCmPrjId)
{
//获取缓存中的对象列表
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = GetObjLstCache(strCmPrjId); 
return arrvPrjTab_SimV2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetObjLstCache(string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimV2EN._CurrTabName, strCmPrjId);
string strCondition = string.Format("CmPrjId='{0}'", strCmPrjId);
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjTab_SimV2ObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCmPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimV2EN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsvPrjTab_SimV2EN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjTab_SimV2EN._RefreshTimeLst.Count == 0) return "";
return clsvPrjTab_SimV2EN._RefreshTimeLst[clsvPrjTab_SimV2EN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTabId, string strCmPrjId)
{
if (strInFldName != convPrjTab_SimV2.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjTab_SimV2._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjTab_SimV2._AttributeName));
throw new Exception(strMsg);
}
var objvPrjTab_SimV2 = clsvPrjTab_SimV2BL.GetObjByTabIdCache(strTabId, strCmPrjId);
if (objvPrjTab_SimV2 == null) return "";
return objvPrjTab_SimV2[strOutFldName].ToString();
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
int intRecCount = clsvPrjTab_SimV2DA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjTab_SimV2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjTab_SimV2DA.GetRecCount();
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
int intRecCount = clsvPrjTab_SimV2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjTab_SimV2EN objvPrjTab_SimV2Cond)
{
 string strCmPrjId = objvPrjTab_SimV2Cond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPrjTab_SimV2BL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPrjTab_SimV2EN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTab_SimV2._AttributeName)
{
if (objvPrjTab_SimV2Cond.IsUpdated(strFldName) == false) continue;
if (objvPrjTab_SimV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab_SimV2Cond[strFldName].ToString());
}
else
{
if (objvPrjTab_SimV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTab_SimV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab_SimV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTab_SimV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTab_SimV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTab_SimV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTab_SimV2Cond[strFldName]));
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
 List<string> arrList = clsvPrjTab_SimV2DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjTab_SimV2DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjTab_SimV2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}