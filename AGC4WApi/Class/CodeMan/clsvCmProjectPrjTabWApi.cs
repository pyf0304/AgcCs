
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCmProjectPrjTabWApi
 表名:vCmProjectPrjTab(00050531)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:39
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCmProjectPrjTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetmId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, long lngmId, string strComparisonOp="")
	{
objvCmProjectPrjTabEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.mId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.mId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.mId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetCmPrjId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCmProjectPrjTab.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCmProjectPrjTab.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCmProjectPrjTab.CmPrjId);
objvCmProjectPrjTabEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.CmPrjId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.CmPrjId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.CmPrjId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetCmPrjName(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCmProjectPrjTab.CmPrjName);
objvCmProjectPrjTabEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.CmPrjName) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.CmPrjName, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.CmPrjName] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetPrjId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCmProjectPrjTab.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCmProjectPrjTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCmProjectPrjTab.PrjId);
objvCmProjectPrjTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.PrjId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.PrjId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.PrjId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convCmProjectPrjTab.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convCmProjectPrjTab.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convCmProjectPrjTab.TabId);
objvCmProjectPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabName(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convCmProjectPrjTab.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convCmProjectPrjTab.TabName);
objvCmProjectPrjTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabName) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabName, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabName] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetFuncModuleAgcId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCmProjectPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCmProjectPrjTab.FuncModuleAgcId);
objvCmProjectPrjTabEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.FuncModuleAgcId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.FuncModuleAgcId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.FuncModuleAgcId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetFuncModuleName(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCmProjectPrjTab.FuncModuleName);
objvCmProjectPrjTabEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.FuncModuleName) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.FuncModuleName, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.FuncModuleName] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetOrderNum(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCmProjectPrjTab.OrderNum);
objvCmProjectPrjTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.OrderNum) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.OrderNum, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.OrderNum] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetUpdDate(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCmProjectPrjTab.UpdDate);
objvCmProjectPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.UpdDate) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.UpdDate, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.UpdDate] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetUpdUser(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCmProjectPrjTab.UpdUser);
objvCmProjectPrjTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.UpdUser) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.UpdUser, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.UpdUser] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetMemo(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCmProjectPrjTab.Memo);
objvCmProjectPrjTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.Memo) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.Memo, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.Memo] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetSqlDsTypeId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convCmProjectPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convCmProjectPrjTab.SqlDsTypeId);
objvCmProjectPrjTabEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.SqlDsTypeId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.SqlDsTypeId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.SqlDsTypeId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetSqlDsTypeName(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convCmProjectPrjTab.SqlDsTypeName);
objvCmProjectPrjTabEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.SqlDsTypeName) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.SqlDsTypeName, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.SqlDsTypeName] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabRecNum">记录数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabRecNum(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, int intTabRecNum, string strComparisonOp="")
	{
objvCmProjectPrjTabEN.TabRecNum = intTabRecNum; //记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabRecNum) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabRecNum, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabRecNum] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabTypeId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convCmProjectPrjTab.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convCmProjectPrjTab.TabTypeId);
objvCmProjectPrjTabEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabTypeId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabTypeId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabTypeId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabStateId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convCmProjectPrjTab.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convCmProjectPrjTab.TabStateId);
objvCmProjectPrjTabEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabStateId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabStateId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabStateId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCmProjectPrjTabEN objvCmProjectPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.mId) == true)
{
string strComparisonOpmId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectPrjTab.mId, objvCmProjectPrjTabCond.mId, strComparisonOpmId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.CmPrjId, objvCmProjectPrjTabCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.CmPrjName, objvCmProjectPrjTabCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.PrjId) == true)
{
string strComparisonOpPrjId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.PrjId, objvCmProjectPrjTabCond.PrjId, strComparisonOpPrjId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabId) == true)
{
string strComparisonOpTabId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.TabId, objvCmProjectPrjTabCond.TabId, strComparisonOpTabId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabName) == true)
{
string strComparisonOpTabName = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.TabName, objvCmProjectPrjTabCond.TabName, strComparisonOpTabName);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.FuncModuleAgcId, objvCmProjectPrjTabCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.FuncModuleName, objvCmProjectPrjTabCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectPrjTab.OrderNum, objvCmProjectPrjTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.UpdDate, objvCmProjectPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.UpdUser, objvCmProjectPrjTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.Memo) == true)
{
string strComparisonOpMemo = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.Memo, objvCmProjectPrjTabCond.Memo, strComparisonOpMemo);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.SqlDsTypeId, objvCmProjectPrjTabCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.SqlDsTypeName, objvCmProjectPrjTabCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabRecNum) == true)
{
string strComparisonOpTabRecNum = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectPrjTab.TabRecNum, objvCmProjectPrjTabCond.TabRecNum, strComparisonOpTabRecNum);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.TabTypeId, objvCmProjectPrjTabCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabStateId) == true)
{
string strComparisonOpTabStateId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.TabStateId, objvCmProjectPrjTabCond.TabStateId, strComparisonOpTabStateId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCmProjectPrjTab(vCmProjectPrjTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCmProjectPrjTabWApi
{
private static readonly string mstrApiControllerName = "vCmProjectPrjTabApi";

 public clsvCmProjectPrjTabWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCmProjectPrjTabEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvCmProjectPrjTabEN objvCmProjectPrjTabEN;
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
objvCmProjectPrjTabEN = JsonConvert.DeserializeObject<clsvCmProjectPrjTabEN>(strJson);
return objvCmProjectPrjTabEN;
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
public static clsvCmProjectPrjTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCmProjectPrjTabEN objvCmProjectPrjTabEN;
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
objvCmProjectPrjTabEN = JsonConvert.DeserializeObject<clsvCmProjectPrjTabEN>(strJson);
return objvCmProjectPrjTabEN;
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
public static clsvCmProjectPrjTabEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCmProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLst_Sel =
from objvCmProjectPrjTabEN in arrvCmProjectPrjTabObjLstCache
where objvCmProjectPrjTabEN.mId == lngmId 
select objvCmProjectPrjTabEN;
if (arrvCmProjectPrjTabObjLst_Sel.Count() == 0)
{
   clsvCmProjectPrjTabEN obj = clsvCmProjectPrjTabWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCmProjectPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectPrjTabEN> GetObjLst(string strWhereCond)
{
 List<clsvCmProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectPrjTabEN>>(strJson);
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
public static List<clsvCmProjectPrjTabEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCmProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectPrjTabEN>>(strJson);
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
public static IEnumerable<clsvCmProjectPrjTabEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCmProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLst_Sel =
from objvCmProjectPrjTabEN in arrvCmProjectPrjTabObjLstCache
where arrMId.Contains(objvCmProjectPrjTabEN.mId)
select objvCmProjectPrjTabEN;
return arrvCmProjectPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCmProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectPrjTabEN>>(strJson);
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
public static List<clsvCmProjectPrjTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCmProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectPrjTabEN>>(strJson);
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
public static List<clsvCmProjectPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCmProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectPrjTabEN>>(strJson);
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
public static List<clsvCmProjectPrjTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCmProjectPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectPrjTabEN>>(strJson);
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
 /// <param name = "objvCmProjectPrjTabENS">源对象</param>
 /// <param name = "objvCmProjectPrjTabENT">目标对象</param>
 public static void CopyTo(clsvCmProjectPrjTabEN objvCmProjectPrjTabENS, clsvCmProjectPrjTabEN objvCmProjectPrjTabENT)
{
try
{
objvCmProjectPrjTabENT.mId = objvCmProjectPrjTabENS.mId; //mId
objvCmProjectPrjTabENT.CmPrjId = objvCmProjectPrjTabENS.CmPrjId; //Cm工程Id
objvCmProjectPrjTabENT.CmPrjName = objvCmProjectPrjTabENS.CmPrjName; //CM工程名
objvCmProjectPrjTabENT.PrjId = objvCmProjectPrjTabENS.PrjId; //工程Id
objvCmProjectPrjTabENT.TabId = objvCmProjectPrjTabENS.TabId; //表ID
objvCmProjectPrjTabENT.TabName = objvCmProjectPrjTabENS.TabName; //表名
objvCmProjectPrjTabENT.FuncModuleAgcId = objvCmProjectPrjTabENS.FuncModuleAgcId; //功能模块Id
objvCmProjectPrjTabENT.FuncModuleName = objvCmProjectPrjTabENS.FuncModuleName; //功能模块名称
objvCmProjectPrjTabENT.OrderNum = objvCmProjectPrjTabENS.OrderNum; //序号
objvCmProjectPrjTabENT.UpdDate = objvCmProjectPrjTabENS.UpdDate; //修改日期
objvCmProjectPrjTabENT.UpdUser = objvCmProjectPrjTabENS.UpdUser; //修改者
objvCmProjectPrjTabENT.Memo = objvCmProjectPrjTabENS.Memo; //说明
objvCmProjectPrjTabENT.SqlDsTypeId = objvCmProjectPrjTabENS.SqlDsTypeId; //数据源类型Id
objvCmProjectPrjTabENT.SqlDsTypeName = objvCmProjectPrjTabENS.SqlDsTypeName; //Sql数据源名
objvCmProjectPrjTabENT.TabRecNum = objvCmProjectPrjTabENS.TabRecNum; //记录数
objvCmProjectPrjTabENT.TabTypeId = objvCmProjectPrjTabENS.TabTypeId; //表类型Id
objvCmProjectPrjTabENT.TabStateId = objvCmProjectPrjTabENS.TabStateId; //表状态ID
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
public static DataTable ToDataTable(List<clsvCmProjectPrjTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCmProjectPrjTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCmProjectPrjTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCmProjectPrjTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCmProjectPrjTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCmProjectPrjTabEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCmProjectPrjTabWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCmProjectPrjTabWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCmProjectPrjTabEN._CurrTabName, strPrjId);
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
public static List<clsvCmProjectPrjTabEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCmProjectPrjTabWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCmProjectPrjTabWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCmProjectPrjTabEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCmProjectPrjTabEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCmProjectPrjTab.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvCmProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCmProjectPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCmProjectPrjTabEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvCmProjectPrjTabEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCmProjectPrjTabWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCmProjectPrjTabWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvCmProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCmProjectPrjTabObjLstCache = CacheHelper.Get<List<clsvCmProjectPrjTabEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCmProjectPrjTabObjLstCache = CacheHelper.Get<List<clsvCmProjectPrjTabEN>>(strKey);
}
return arrvCmProjectPrjTabObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCmProjectPrjTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCmProjectPrjTab.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCmProjectPrjTab.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCmProjectPrjTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.TabRecNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCmProjectPrjTab.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectPrjTab.TabStateId, Type.GetType("System.String"));
foreach (clsvCmProjectPrjTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCmProjectPrjTab.mId] = objInFor[convCmProjectPrjTab.mId];
objDR[convCmProjectPrjTab.CmPrjId] = objInFor[convCmProjectPrjTab.CmPrjId];
objDR[convCmProjectPrjTab.CmPrjName] = objInFor[convCmProjectPrjTab.CmPrjName];
objDR[convCmProjectPrjTab.PrjId] = objInFor[convCmProjectPrjTab.PrjId];
objDR[convCmProjectPrjTab.TabId] = objInFor[convCmProjectPrjTab.TabId];
objDR[convCmProjectPrjTab.TabName] = objInFor[convCmProjectPrjTab.TabName];
objDR[convCmProjectPrjTab.FuncModuleAgcId] = objInFor[convCmProjectPrjTab.FuncModuleAgcId];
objDR[convCmProjectPrjTab.FuncModuleName] = objInFor[convCmProjectPrjTab.FuncModuleName];
objDR[convCmProjectPrjTab.OrderNum] = objInFor[convCmProjectPrjTab.OrderNum];
objDR[convCmProjectPrjTab.UpdDate] = objInFor[convCmProjectPrjTab.UpdDate];
objDR[convCmProjectPrjTab.UpdUser] = objInFor[convCmProjectPrjTab.UpdUser];
objDR[convCmProjectPrjTab.Memo] = objInFor[convCmProjectPrjTab.Memo];
objDR[convCmProjectPrjTab.SqlDsTypeId] = objInFor[convCmProjectPrjTab.SqlDsTypeId];
objDR[convCmProjectPrjTab.SqlDsTypeName] = objInFor[convCmProjectPrjTab.SqlDsTypeName];
objDR[convCmProjectPrjTab.TabRecNum] = objInFor[convCmProjectPrjTab.TabRecNum];
objDR[convCmProjectPrjTab.TabTypeId] = objInFor[convCmProjectPrjTab.TabTypeId];
objDR[convCmProjectPrjTab.TabStateId] = objInFor[convCmProjectPrjTab.TabStateId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}