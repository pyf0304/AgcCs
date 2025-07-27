
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4CreateView4SqlBL
 表名:vLog4CreateView4Sql(00050295)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class clsvLog4CreateView4SqlBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4CreateView4SqlEN GetObj(this K_mId_vLog4CreateView4Sql myKey)
{
clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = clsvLog4CreateView4SqlBL.vLog4CreateView4SqlDA.GetObjBymId(myKey.Value);
return objvLog4CreateView4SqlEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetmId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, long lngmId, string strComparisonOp="")
	{
objvLog4CreateView4SqlEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.mId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.mId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.mId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetSqlViewId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, convLog4CreateView4Sql.SqlViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convLog4CreateView4Sql.SqlViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convLog4CreateView4Sql.SqlViewId);
}
objvLog4CreateView4SqlEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.SqlViewId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.SqlViewId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.SqlViewId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetPrjDataBaseId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convLog4CreateView4Sql.PrjDataBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convLog4CreateView4Sql.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convLog4CreateView4Sql.PrjDataBaseId);
}
objvLog4CreateView4SqlEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.PrjDataBaseId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.PrjDataBaseId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.PrjDataBaseId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetPrjDataBaseName(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strPrjDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convLog4CreateView4Sql.PrjDataBaseName);
}
objvLog4CreateView4SqlEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.PrjDataBaseName) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.PrjDataBaseName, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.PrjDataBaseName] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetCreateViewDate(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strCreateViewDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateViewDate, 14, convLog4CreateView4Sql.CreateViewDate);
}
objvLog4CreateView4SqlEN.CreateViewDate = strCreateViewDate; //建立视图日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.CreateViewDate) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.CreateViewDate, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.CreateViewDate] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetPrjId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convLog4CreateView4Sql.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convLog4CreateView4Sql.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convLog4CreateView4Sql.PrjId);
}
objvLog4CreateView4SqlEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.PrjId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.PrjId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.PrjId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetPrjName(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convLog4CreateView4Sql.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convLog4CreateView4Sql.PrjName);
}
objvLog4CreateView4SqlEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.PrjName) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.PrjName, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.PrjName] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetUserId(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convLog4CreateView4Sql.UserId);
}
objvLog4CreateView4SqlEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.UserId) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.UserId, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.UserId] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4CreateView4SqlEN SetMemo(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convLog4CreateView4Sql.Memo);
}
objvLog4CreateView4SqlEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4CreateView4SqlEN.dicFldComparisonOp.ContainsKey(convLog4CreateView4Sql.Memo) == false)
{
objvLog4CreateView4SqlEN.dicFldComparisonOp.Add(convLog4CreateView4Sql.Memo, strComparisonOp);
}
else
{
objvLog4CreateView4SqlEN.dicFldComparisonOp[convLog4CreateView4Sql.Memo] = strComparisonOp;
}
}
return objvLog4CreateView4SqlEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlENS">源对象</param>
 /// <param name = "objvLog4CreateView4SqlENT">目标对象</param>
 public static void CopyTo(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENS, clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENT)
{
try
{
objvLog4CreateView4SqlENT.mId = objvLog4CreateView4SqlENS.mId; //mId
objvLog4CreateView4SqlENT.SqlViewId = objvLog4CreateView4SqlENS.SqlViewId; //Sql视图Id
objvLog4CreateView4SqlENT.PrjDataBaseId = objvLog4CreateView4SqlENS.PrjDataBaseId; //项目数据库Id
objvLog4CreateView4SqlENT.PrjDataBaseName = objvLog4CreateView4SqlENS.PrjDataBaseName; //项目数据库名
objvLog4CreateView4SqlENT.CreateViewDate = objvLog4CreateView4SqlENS.CreateViewDate; //建立视图日期
objvLog4CreateView4SqlENT.PrjId = objvLog4CreateView4SqlENS.PrjId; //工程ID
objvLog4CreateView4SqlENT.PrjName = objvLog4CreateView4SqlENS.PrjName; //工程名称
objvLog4CreateView4SqlENT.UserId = objvLog4CreateView4SqlENS.UserId; //用户Id
objvLog4CreateView4SqlENT.Memo = objvLog4CreateView4SqlENS.Memo; //说明
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
 /// <param name = "objvLog4CreateView4SqlENS">源对象</param>
 /// <returns>目标对象=>clsvLog4CreateView4SqlEN:objvLog4CreateView4SqlENT</returns>
 public static clsvLog4CreateView4SqlEN CopyTo(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENS)
{
try
{
 clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENT = new clsvLog4CreateView4SqlEN()
{
mId = objvLog4CreateView4SqlENS.mId, //mId
SqlViewId = objvLog4CreateView4SqlENS.SqlViewId, //Sql视图Id
PrjDataBaseId = objvLog4CreateView4SqlENS.PrjDataBaseId, //项目数据库Id
PrjDataBaseName = objvLog4CreateView4SqlENS.PrjDataBaseName, //项目数据库名
CreateViewDate = objvLog4CreateView4SqlENS.CreateViewDate, //建立视图日期
PrjId = objvLog4CreateView4SqlENS.PrjId, //工程ID
PrjName = objvLog4CreateView4SqlENS.PrjName, //工程名称
UserId = objvLog4CreateView4SqlENS.UserId, //用户Id
Memo = objvLog4CreateView4SqlENS.Memo, //说明
};
 return objvLog4CreateView4SqlENT;
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
public static void CheckProperty4Condition(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
 clsvLog4CreateView4SqlBL.vLog4CreateView4SqlDA.CheckProperty4Condition(objvLog4CreateView4SqlEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvLog4CreateView4SqlEN objvLog4CreateView4SqlCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvLog4CreateView4SqlCond.IsUpdated(convLog4CreateView4Sql.mId) == true)
{
string strComparisonOpmId = objvLog4CreateView4SqlCond.dicFldComparisonOp[convLog4CreateView4Sql.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convLog4CreateView4Sql.mId, objvLog4CreateView4SqlCond.mId, strComparisonOpmId);
}
if (objvLog4CreateView4SqlCond.IsUpdated(convLog4CreateView4Sql.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objvLog4CreateView4SqlCond.dicFldComparisonOp[convLog4CreateView4Sql.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.SqlViewId, objvLog4CreateView4SqlCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objvLog4CreateView4SqlCond.IsUpdated(convLog4CreateView4Sql.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvLog4CreateView4SqlCond.dicFldComparisonOp[convLog4CreateView4Sql.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.PrjDataBaseId, objvLog4CreateView4SqlCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objvLog4CreateView4SqlCond.IsUpdated(convLog4CreateView4Sql.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvLog4CreateView4SqlCond.dicFldComparisonOp[convLog4CreateView4Sql.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.PrjDataBaseName, objvLog4CreateView4SqlCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvLog4CreateView4SqlCond.IsUpdated(convLog4CreateView4Sql.CreateViewDate) == true)
{
string strComparisonOpCreateViewDate = objvLog4CreateView4SqlCond.dicFldComparisonOp[convLog4CreateView4Sql.CreateViewDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.CreateViewDate, objvLog4CreateView4SqlCond.CreateViewDate, strComparisonOpCreateViewDate);
}
if (objvLog4CreateView4SqlCond.IsUpdated(convLog4CreateView4Sql.PrjId) == true)
{
string strComparisonOpPrjId = objvLog4CreateView4SqlCond.dicFldComparisonOp[convLog4CreateView4Sql.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.PrjId, objvLog4CreateView4SqlCond.PrjId, strComparisonOpPrjId);
}
if (objvLog4CreateView4SqlCond.IsUpdated(convLog4CreateView4Sql.PrjName) == true)
{
string strComparisonOpPrjName = objvLog4CreateView4SqlCond.dicFldComparisonOp[convLog4CreateView4Sql.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.PrjName, objvLog4CreateView4SqlCond.PrjName, strComparisonOpPrjName);
}
if (objvLog4CreateView4SqlCond.IsUpdated(convLog4CreateView4Sql.UserId) == true)
{
string strComparisonOpUserId = objvLog4CreateView4SqlCond.dicFldComparisonOp[convLog4CreateView4Sql.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.UserId, objvLog4CreateView4SqlCond.UserId, strComparisonOpUserId);
}
if (objvLog4CreateView4SqlCond.IsUpdated(convLog4CreateView4Sql.Memo) == true)
{
string strComparisonOpMemo = objvLog4CreateView4SqlCond.dicFldComparisonOp[convLog4CreateView4Sql.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4CreateView4Sql.Memo, objvLog4CreateView4SqlCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vLog4CreateView4Sql
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v建立视图日志(vLog4CreateView4Sql)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvLog4CreateView4SqlBL
{
public static RelatedActions_vLog4CreateView4Sql relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vLog4CreateView4SqlListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vLog4CreateView4SqlList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvLog4CreateView4SqlDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvLog4CreateView4SqlDA vLog4CreateView4SqlDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvLog4CreateView4SqlDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvLog4CreateView4SqlBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsvLog4CreateView4SqlEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvLog4CreateView4SqlEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vLog4CreateView4SqlDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vLog4CreateView4SqlDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vLog4CreateView4SqlDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vLog4CreateView4Sql(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vLog4CreateView4SqlDA.GetDataTable_vLog4CreateView4Sql(strWhereCond);
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
objDT = vLog4CreateView4SqlDA.GetDataTable(strWhereCond);
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
objDT = vLog4CreateView4SqlDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vLog4CreateView4SqlDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vLog4CreateView4SqlDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vLog4CreateView4SqlDA.GetDataTable_Top(objTopPara);
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
objDT = vLog4CreateView4SqlDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vLog4CreateView4SqlDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vLog4CreateView4SqlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vLog4CreateView4SqlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vLog4CreateView4SqlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vLog4CreateView4SqlDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vLog4CreateView4SqlDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vLog4CreateView4SqlDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
public static List<clsvLog4CreateView4SqlEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
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
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvLog4CreateView4SqlEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvLog4CreateView4SqlEN._CurrTabName);
List<clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLst_Sel =
arrvLog4CreateView4SqlObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvLog4CreateView4SqlObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetObjLst(string strWhereCond)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
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
public static List<clsvLog4CreateView4SqlEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvLog4CreateView4SqlEN> GetSubObjLstCache(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlCond)
{
List<clsvLog4CreateView4SqlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4CreateView4SqlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convLog4CreateView4Sql.AttributeName)
{
if (objvLog4CreateView4SqlCond.IsUpdated(strFldName) == false) continue;
if (objvLog4CreateView4SqlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4CreateView4SqlCond[strFldName].ToString());
}
else
{
if (objvLog4CreateView4SqlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvLog4CreateView4SqlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4CreateView4SqlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvLog4CreateView4SqlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvLog4CreateView4SqlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvLog4CreateView4SqlCond[strFldName]));
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
public static List<clsvLog4CreateView4SqlEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
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
public static List<clsvLog4CreateView4SqlEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
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
List<clsvLog4CreateView4SqlEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvLog4CreateView4SqlEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvLog4CreateView4SqlEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
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
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
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
public static List<clsvLog4CreateView4SqlEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvLog4CreateView4SqlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
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
public static List<clsvLog4CreateView4SqlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvLog4CreateView4SqlEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvLog4CreateView4SqlEN objvLog4CreateView4SqlCond, string strOrderBy)
{
List<clsvLog4CreateView4SqlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4CreateView4SqlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convLog4CreateView4Sql.AttributeName)
{
if (objvLog4CreateView4SqlCond.IsUpdated(strFldName) == false) continue;
if (objvLog4CreateView4SqlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4CreateView4SqlCond[strFldName].ToString());
}
else
{
if (objvLog4CreateView4SqlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvLog4CreateView4SqlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4CreateView4SqlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvLog4CreateView4SqlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvLog4CreateView4SqlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvLog4CreateView4SqlCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvLog4CreateView4SqlEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvLog4CreateView4SqlEN objvLog4CreateView4SqlCond = JsonConvert.DeserializeObject<clsvLog4CreateView4SqlEN>(objPagerPara.whereCond);
if (objvLog4CreateView4SqlCond.sfFldComparisonOp == null)
{
objvLog4CreateView4SqlCond.dicFldComparisonOp = null;
}
else
{
objvLog4CreateView4SqlCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvLog4CreateView4SqlCond.sfFldComparisonOp);
}
clsvLog4CreateView4SqlBL.SetUpdFlag(objvLog4CreateView4SqlCond);
 try
{
CheckProperty4Condition(objvLog4CreateView4SqlCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvLog4CreateView4SqlCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvLog4CreateView4SqlEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvLog4CreateView4SqlEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvLog4CreateView4Sql(ref clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
bool bolResult = vLog4CreateView4SqlDA.GetvLog4CreateView4Sql(ref objvLog4CreateView4SqlEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4CreateView4SqlEN GetObjBymId(long lngmId)
{
clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = vLog4CreateView4SqlDA.GetObjBymId(lngmId);
return objvLog4CreateView4SqlEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvLog4CreateView4SqlEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = vLog4CreateView4SqlDA.GetFirstObj(strWhereCond);
 return objvLog4CreateView4SqlEN;
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
public static clsvLog4CreateView4SqlEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = vLog4CreateView4SqlDA.GetObjByDataRow(objRow);
 return objvLog4CreateView4SqlEN;
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
public static clsvLog4CreateView4SqlEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = vLog4CreateView4SqlDA.GetObjByDataRow(objRow);
 return objvLog4CreateView4SqlEN;
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
 /// <param name = "lstvLog4CreateView4SqlObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvLog4CreateView4SqlEN GetObjBymIdFromList(long lngmId, List<clsvLog4CreateView4SqlEN> lstvLog4CreateView4SqlObjLst)
{
foreach (clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN in lstvLog4CreateView4SqlObjLst)
{
if (objvLog4CreateView4SqlEN.mId == lngmId)
{
return objvLog4CreateView4SqlEN;
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
 lngmId = new clsvLog4CreateView4SqlDA().GetFirstID(strWhereCond);
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
 arrList = vLog4CreateView4SqlDA.GetID(strWhereCond);
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
bool bolIsExist = vLog4CreateView4SqlDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vLog4CreateView4SqlDA.IsExist(lngmId);
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
 bolIsExist = clsvLog4CreateView4SqlDA.IsExistTable();
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
 bolIsExist = vLog4CreateView4SqlDA.IsExistTable(strTabName);
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
 /// <param name = "objvLog4CreateView4SqlENS">源对象</param>
 /// <param name = "objvLog4CreateView4SqlENT">目标对象</param>
 public static void CopyTo(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENS, clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENT)
{
try
{
objvLog4CreateView4SqlENT.mId = objvLog4CreateView4SqlENS.mId; //mId
objvLog4CreateView4SqlENT.SqlViewId = objvLog4CreateView4SqlENS.SqlViewId; //Sql视图Id
objvLog4CreateView4SqlENT.PrjDataBaseId = objvLog4CreateView4SqlENS.PrjDataBaseId; //项目数据库Id
objvLog4CreateView4SqlENT.PrjDataBaseName = objvLog4CreateView4SqlENS.PrjDataBaseName; //项目数据库名
objvLog4CreateView4SqlENT.CreateViewDate = objvLog4CreateView4SqlENS.CreateViewDate; //建立视图日期
objvLog4CreateView4SqlENT.PrjId = objvLog4CreateView4SqlENS.PrjId; //工程ID
objvLog4CreateView4SqlENT.PrjName = objvLog4CreateView4SqlENS.PrjName; //工程名称
objvLog4CreateView4SqlENT.UserId = objvLog4CreateView4SqlENS.UserId; //用户Id
objvLog4CreateView4SqlENT.Memo = objvLog4CreateView4SqlENS.Memo; //说明
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
 /// <param name = "objvLog4CreateView4SqlEN">源简化对象</param>
 public static void SetUpdFlag(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
try
{
objvLog4CreateView4SqlEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvLog4CreateView4SqlEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convLog4CreateView4Sql.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4CreateView4SqlEN.mId = objvLog4CreateView4SqlEN.mId; //mId
}
if (arrFldSet.Contains(convLog4CreateView4Sql.SqlViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4CreateView4SqlEN.SqlViewId = objvLog4CreateView4SqlEN.SqlViewId; //Sql视图Id
}
if (arrFldSet.Contains(convLog4CreateView4Sql.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4CreateView4SqlEN.PrjDataBaseId = objvLog4CreateView4SqlEN.PrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(convLog4CreateView4Sql.PrjDataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4CreateView4SqlEN.PrjDataBaseName = objvLog4CreateView4SqlEN.PrjDataBaseName == "[null]" ? null :  objvLog4CreateView4SqlEN.PrjDataBaseName; //项目数据库名
}
if (arrFldSet.Contains(convLog4CreateView4Sql.CreateViewDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4CreateView4SqlEN.CreateViewDate = objvLog4CreateView4SqlEN.CreateViewDate == "[null]" ? null :  objvLog4CreateView4SqlEN.CreateViewDate; //建立视图日期
}
if (arrFldSet.Contains(convLog4CreateView4Sql.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4CreateView4SqlEN.PrjId = objvLog4CreateView4SqlEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convLog4CreateView4Sql.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4CreateView4SqlEN.PrjName = objvLog4CreateView4SqlEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convLog4CreateView4Sql.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4CreateView4SqlEN.UserId = objvLog4CreateView4SqlEN.UserId == "[null]" ? null :  objvLog4CreateView4SqlEN.UserId; //用户Id
}
if (arrFldSet.Contains(convLog4CreateView4Sql.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvLog4CreateView4SqlEN.Memo = objvLog4CreateView4SqlEN.Memo == "[null]" ? null :  objvLog4CreateView4SqlEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">源简化对象</param>
 public static void AccessFldValueNull(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
try
{
if (objvLog4CreateView4SqlEN.PrjDataBaseName == "[null]") objvLog4CreateView4SqlEN.PrjDataBaseName = null; //项目数据库名
if (objvLog4CreateView4SqlEN.CreateViewDate == "[null]") objvLog4CreateView4SqlEN.CreateViewDate = null; //建立视图日期
if (objvLog4CreateView4SqlEN.UserId == "[null]") objvLog4CreateView4SqlEN.UserId = null; //用户Id
if (objvLog4CreateView4SqlEN.Memo == "[null]") objvLog4CreateView4SqlEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
 vLog4CreateView4SqlDA.CheckProperty4Condition(objvLog4CreateView4SqlEN);
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjDataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjDataBaseBL没有刷新缓存机制(clsPrjDataBaseBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLog4CreateView4SqlBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLog4CreateView4SqlBL没有刷新缓存机制(clsLog4CreateView4SqlBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvLog4CreateView4SqlObjLstCache == null)
//{
//arrvLog4CreateView4SqlObjLstCache = vLog4CreateView4SqlDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvLog4CreateView4SqlEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvLog4CreateView4SqlEN._CurrTabName);
List<clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLst_Sel =
arrvLog4CreateView4SqlObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvLog4CreateView4SqlObjLst_Sel.Count() == 0)
{
   clsvLog4CreateView4SqlEN obj = clsvLog4CreateView4SqlBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvLog4CreateView4SqlObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetAllvLog4CreateView4SqlObjLstCache()
{
//获取缓存中的对象列表
List<clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLstCache = GetObjLstCache(); 
return arrvLog4CreateView4SqlObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvLog4CreateView4SqlEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvLog4CreateView4SqlEN._CurrTabName);
List<clsvLog4CreateView4SqlEN> arrvLog4CreateView4SqlObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvLog4CreateView4SqlObjLstCache;
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
string strKey = string.Format("{0}", clsvLog4CreateView4SqlEN._CurrTabName);
CacheHelper.Remove(strKey);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvLog4CreateView4SqlObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvLog4CreateView4SqlEN> lstvLog4CreateView4SqlObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvLog4CreateView4SqlObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvLog4CreateView4SqlObjLst">[clsvLog4CreateView4SqlEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvLog4CreateView4SqlEN> lstvLog4CreateView4SqlObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvLog4CreateView4SqlBL.listXmlNode);
writer.WriteStartElement(clsvLog4CreateView4SqlBL.itemsXmlNode);
foreach (clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN in lstvLog4CreateView4SqlObjLst)
{
clsvLog4CreateView4SqlBL.SerializeXML(writer, objvLog4CreateView4SqlEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvLog4CreateView4SqlEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
writer.WriteStartElement(clsvLog4CreateView4SqlBL.itemXmlNode);
 
writer.WriteElementString(convLog4CreateView4Sql.mId, objvLog4CreateView4SqlEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvLog4CreateView4SqlEN.SqlViewId != null)
{
writer.WriteElementString(convLog4CreateView4Sql.SqlViewId, objvLog4CreateView4SqlEN.SqlViewId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4CreateView4SqlEN.PrjDataBaseId != null)
{
writer.WriteElementString(convLog4CreateView4Sql.PrjDataBaseId, objvLog4CreateView4SqlEN.PrjDataBaseId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4CreateView4SqlEN.PrjDataBaseName != null)
{
writer.WriteElementString(convLog4CreateView4Sql.PrjDataBaseName, objvLog4CreateView4SqlEN.PrjDataBaseName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4CreateView4SqlEN.CreateViewDate != null)
{
writer.WriteElementString(convLog4CreateView4Sql.CreateViewDate, objvLog4CreateView4SqlEN.CreateViewDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4CreateView4SqlEN.PrjId != null)
{
writer.WriteElementString(convLog4CreateView4Sql.PrjId, objvLog4CreateView4SqlEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4CreateView4SqlEN.PrjName != null)
{
writer.WriteElementString(convLog4CreateView4Sql.PrjName, objvLog4CreateView4SqlEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4CreateView4SqlEN.UserId != null)
{
writer.WriteElementString(convLog4CreateView4Sql.UserId, objvLog4CreateView4SqlEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvLog4CreateView4SqlEN.Memo != null)
{
writer.WriteElementString(convLog4CreateView4Sql.Memo, objvLog4CreateView4SqlEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvLog4CreateView4SqlEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
reader.Read();
while (!(reader.Name == clsvLog4CreateView4SqlBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convLog4CreateView4Sql.mId))
{
objvLog4CreateView4SqlEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convLog4CreateView4Sql.SqlViewId))
{
objvLog4CreateView4SqlEN.SqlViewId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4CreateView4Sql.PrjDataBaseId))
{
objvLog4CreateView4SqlEN.PrjDataBaseId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4CreateView4Sql.PrjDataBaseName))
{
objvLog4CreateView4SqlEN.PrjDataBaseName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4CreateView4Sql.CreateViewDate))
{
objvLog4CreateView4SqlEN.CreateViewDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4CreateView4Sql.PrjId))
{
objvLog4CreateView4SqlEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4CreateView4Sql.PrjName))
{
objvLog4CreateView4SqlEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4CreateView4Sql.UserId))
{
objvLog4CreateView4SqlEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convLog4CreateView4Sql.Memo))
{
objvLog4CreateView4SqlEN.Memo = reader.ReadElementContentAsString();
}
}
return objvLog4CreateView4SqlEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvLog4CreateView4SqlObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvLog4CreateView4SqlEN GetObjFromXmlStr(string strvLog4CreateView4SqlObjXmlStr)
{
clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvLog4CreateView4SqlObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvLog4CreateView4SqlBL.itemXmlNode))
{
objvLog4CreateView4SqlEN = GetObjFromXml(reader);
return objvLog4CreateView4SqlEN;
}
}
return objvLog4CreateView4SqlEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvLog4CreateView4SqlEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convLog4CreateView4Sql.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convLog4CreateView4Sql.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convLog4CreateView4Sql.AttributeName));
throw new Exception(strMsg);
}
var objvLog4CreateView4Sql = clsvLog4CreateView4SqlBL.GetObjBymIdCache(lngmId);
if (objvLog4CreateView4Sql == null) return "";
return objvLog4CreateView4Sql[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvLog4CreateView4SqlEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvLog4CreateView4SqlEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvLog4CreateView4SqlObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvLog4CreateView4SqlEN> lstvLog4CreateView4SqlObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvLog4CreateView4SqlObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN in lstvLog4CreateView4SqlObjLst)
{
string strJSON_One = SerializeObjToJSON(objvLog4CreateView4SqlEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsvLog4CreateView4SqlDA.GetRecCount(strTabName);
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
int intRecCount = clsvLog4CreateView4SqlDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvLog4CreateView4SqlDA.GetRecCount();
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
int intRecCount = clsvLog4CreateView4SqlDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlCond)
{
List<clsvLog4CreateView4SqlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvLog4CreateView4SqlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convLog4CreateView4Sql.AttributeName)
{
if (objvLog4CreateView4SqlCond.IsUpdated(strFldName) == false) continue;
if (objvLog4CreateView4SqlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4CreateView4SqlCond[strFldName].ToString());
}
else
{
if (objvLog4CreateView4SqlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvLog4CreateView4SqlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvLog4CreateView4SqlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvLog4CreateView4SqlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvLog4CreateView4SqlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvLog4CreateView4SqlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvLog4CreateView4SqlCond[strFldName]));
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
 List<string> arrList = clsvLog4CreateView4SqlDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vLog4CreateView4SqlDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vLog4CreateView4SqlDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}