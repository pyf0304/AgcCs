
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4ErrMsgWApi
 表名:vPrjTab4ErrMsg(00050206)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvPrjTab4ErrMsgWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab4ErrMsg.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab4ErrMsg.TabId);
objvPrjTab4ErrMsgEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldNum">字段数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetFldNum(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, int intFldNum, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.FldNum) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.FldNum, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.FldNum] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab4ErrMsg.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab4ErrMsg.TabName);
objvPrjTab4ErrMsgEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabCnName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjTab4ErrMsg.TabCnName);
objvPrjTab4ErrMsgEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabCnName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabCnName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabCnName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetPrjId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTab4ErrMsg.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTab4ErrMsg.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTab4ErrMsg.PrjId);
objvPrjTab4ErrMsgEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.PrjId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.PrjId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.PrjId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetPrjName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjTab4ErrMsg.PrjName);
objvPrjTab4ErrMsgEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.PrjName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.PrjName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.PrjName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsNeedTransCode(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, convPrjTab4ErrMsg.IsNeedTransCode);
objvPrjTab4ErrMsgEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsNeedTransCode) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsNeedTransCode, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsNeedTransCode] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetSqlDsTypeId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab4ErrMsg.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab4ErrMsg.SqlDsTypeId);
objvPrjTab4ErrMsgEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.SqlDsTypeId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.SqlDsTypeId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.SqlDsTypeId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetSqlDsTypeName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convPrjTab4ErrMsg.SqlDsTypeName);
objvPrjTab4ErrMsgEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.SqlDsTypeName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.SqlDsTypeName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.SqlDsTypeName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabStateId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab4ErrMsg.TabStateId);
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab4ErrMsg.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab4ErrMsg.TabStateId);
objvPrjTab4ErrMsgEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabStateId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabStateId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabStateId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateName">表状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabStateName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabStateName, 30, convPrjTab4ErrMsg.TabStateName);
objvPrjTab4ErrMsgEN.TabStateName = strTabStateName; //表状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabStateName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabStateName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabStateName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabNameB">表名_后备</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabNameB(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabNameB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabNameB, 50, convPrjTab4ErrMsg.TabNameB);
objvPrjTab4ErrMsgEN.TabNameB = strTabNameB; //表名_后备
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabNameB) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabNameB, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabNameB] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsParaTab">是否参数表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsParaTab(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsParaTab, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsParaTab = bolIsParaTab; //是否参数表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsParaTab) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsParaTab, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsParaTab] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNationStandard">是否国标</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsNationStandard(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsNationStandard, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsNationStandard = bolIsNationStandard; //是否国标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsNationStandard) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsNationStandard, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsNationStandard] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsArchive">是否存档</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsArchive(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsArchive, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsArchive) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsArchive, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsArchive] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsChecked">是否核实</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsChecked(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsChecked, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsChecked) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsChecked, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsChecked] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetErrMsg(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convPrjTab4ErrMsg.ErrMsg);
objvPrjTab4ErrMsgEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.ErrMsg) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.ErrMsg, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.ErrMsg] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetFuncModuleAgcId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab4ErrMsg.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab4ErrMsg.FuncModuleAgcId);
objvPrjTab4ErrMsgEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.FuncModuleAgcId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.FuncModuleAgcId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleAgcId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetFuncModuleName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convPrjTab4ErrMsg.FuncModuleName);
objvPrjTab4ErrMsgEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.FuncModuleName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.FuncModuleName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetFuncModuleEnName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convPrjTab4ErrMsg.FuncModuleEnName);
objvPrjTab4ErrMsgEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.FuncModuleEnName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.FuncModuleEnName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleEnName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strOwner">拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetOwner(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwner, 50, convPrjTab4ErrMsg.Owner);
objvPrjTab4ErrMsgEN.Owner = strOwner; //拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.Owner) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.Owner, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.Owner] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsReleToSqlTab">是否与SQL表相关</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsReleToSqlTab(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsReleToSqlTab, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsReleToSqlTab = bolIsReleToSqlTab; //是否与SQL表相关
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsReleToSqlTab) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsReleToSqlTab, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsReleToSqlTab] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetKeyword(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 50, convPrjTab4ErrMsg.Keyword);
objvPrjTab4ErrMsgEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.Keyword) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.Keyword, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.Keyword] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabTypeId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab4ErrMsg.TabTypeId);
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab4ErrMsg.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab4ErrMsg.TabTypeId);
objvPrjTab4ErrMsgEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabTypeId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabTypeId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabTypeId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeName">表类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabTypeName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convPrjTab4ErrMsg.TabTypeName);
objvPrjTab4ErrMsgEN.TabTypeName = strTabTypeName; //表类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabTypeName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabTypeName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabTypeName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId4View">视图的相关表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetRelaTabId4View(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strRelaTabId4View, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabId4View, 8, convPrjTab4ErrMsg.RelaTabId4View);
clsCheckSql.CheckFieldForeignKey(strRelaTabId4View, 8, convPrjTab4ErrMsg.RelaTabId4View);
objvPrjTab4ErrMsgEN.RelaTabId4View = strRelaTabId4View; //视图的相关表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.RelaTabId4View) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.RelaTabId4View, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.RelaTabId4View] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetOrderNum4Refer(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.OrderNum4Refer) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.OrderNum4Refer, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.OrderNum4Refer] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGeneIndexer">是否需要生成索引器</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsNeedGeneIndexer(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsNeedGeneIndexer, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = bolIsNeedGeneIndexer; //是否需要生成索引器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsNeedGeneIndexer) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsNeedGeneIndexer, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsNeedGeneIndexer] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetUpdUserId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convPrjTab4ErrMsg.UpdUserId);
objvPrjTab4ErrMsgEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.UpdUserId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.UpdUserId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.UpdUserId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetUpdDate(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjTab4ErrMsg.UpdDate);
objvPrjTab4ErrMsgEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.UpdDate) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.UpdDate, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.UpdDate] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetMemo(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjTab4ErrMsg.Memo);
objvPrjTab4ErrMsgEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.Memo) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.Memo, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.Memo] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg2">ErrMsg2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetErrMsg2(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strErrMsg2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg2, 8000, convPrjTab4ErrMsg.ErrMsg2);
objvPrjTab4ErrMsgEN.ErrMsg2 = strErrMsg2; //ErrMsg2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.ErrMsg2) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.ErrMsg2, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.ErrMsg2] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabName4View">RelaTabName4View</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetRelaTabName4View(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strRelaTabName4View, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaTabName4View, 100, convPrjTab4ErrMsg.RelaTabName4View);
objvPrjTab4ErrMsgEN.RelaTabName4View = strRelaTabName4View; //RelaTabName4View
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.RelaTabName4View) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.RelaTabName4View, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.RelaTabName4View] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataBaseNameTab">DataBaseName_Tab</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetDataBaseNameTab(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strDataBaseNameTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataBaseNameTab, 50, convPrjTab4ErrMsg.DataBaseNameTab);
objvPrjTab4ErrMsgEN.DataBaseNameTab = strDataBaseNameTab; //DataBaseName_Tab
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.DataBaseNameTab) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.DataBaseNameTab, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.DataBaseNameTab] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabId) == true)
{
string strComparisonOpTabId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabId, objvPrjTab4ErrMsgCond.TabId, strComparisonOpTabId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.FldNum) == true)
{
string strComparisonOpFldNum = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab4ErrMsg.FldNum, objvPrjTab4ErrMsgCond.FldNum, strComparisonOpFldNum);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabName) == true)
{
string strComparisonOpTabName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabName, objvPrjTab4ErrMsgCond.TabName, strComparisonOpTabName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabCnName) == true)
{
string strComparisonOpTabCnName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabCnName, objvPrjTab4ErrMsgCond.TabCnName, strComparisonOpTabCnName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.PrjId, objvPrjTab4ErrMsgCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.PrjName, objvPrjTab4ErrMsgCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsNeedTransCode) == true)
{
if (objvPrjTab4ErrMsgCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsNeedTransCode);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.SqlDsTypeId, objvPrjTab4ErrMsgCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.SqlDsTypeName, objvPrjTab4ErrMsgCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabStateId) == true)
{
string strComparisonOpTabStateId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabStateId, objvPrjTab4ErrMsgCond.TabStateId, strComparisonOpTabStateId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabStateName) == true)
{
string strComparisonOpTabStateName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabStateName, objvPrjTab4ErrMsgCond.TabStateName, strComparisonOpTabStateName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabNameB) == true)
{
string strComparisonOpTabNameB = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabNameB];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabNameB, objvPrjTab4ErrMsgCond.TabNameB, strComparisonOpTabNameB);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsParaTab) == true)
{
if (objvPrjTab4ErrMsgCond.IsParaTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsParaTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsParaTab);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsNationStandard) == true)
{
if (objvPrjTab4ErrMsgCond.IsNationStandard == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsNationStandard);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsNationStandard);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsArchive) == true)
{
if (objvPrjTab4ErrMsgCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsArchive);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsChecked) == true)
{
if (objvPrjTab4ErrMsgCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsChecked);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.ErrMsg) == true)
{
string strComparisonOpErrMsg = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.ErrMsg, objvPrjTab4ErrMsgCond.ErrMsg, strComparisonOpErrMsg);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.FuncModuleAgcId, objvPrjTab4ErrMsgCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.FuncModuleName, objvPrjTab4ErrMsgCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.FuncModuleEnName, objvPrjTab4ErrMsgCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.Owner) == true)
{
string strComparisonOpOwner = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.Owner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.Owner, objvPrjTab4ErrMsgCond.Owner, strComparisonOpOwner);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsReleToSqlTab) == true)
{
if (objvPrjTab4ErrMsgCond.IsReleToSqlTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsReleToSqlTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsReleToSqlTab);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.Keyword) == true)
{
string strComparisonOpKeyword = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.Keyword, objvPrjTab4ErrMsgCond.Keyword, strComparisonOpKeyword);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabTypeId, objvPrjTab4ErrMsgCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabTypeName) == true)
{
string strComparisonOpTabTypeName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabTypeName, objvPrjTab4ErrMsgCond.TabTypeName, strComparisonOpTabTypeName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.RelaTabId4View) == true)
{
string strComparisonOpRelaTabId4View = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.RelaTabId4View];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.RelaTabId4View, objvPrjTab4ErrMsgCond.RelaTabId4View, strComparisonOpRelaTabId4View);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab4ErrMsg.OrderNum4Refer, objvPrjTab4ErrMsgCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsNeedGeneIndexer) == true)
{
if (objvPrjTab4ErrMsgCond.IsNeedGeneIndexer == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsNeedGeneIndexer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsNeedGeneIndexer);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.UpdUserId, objvPrjTab4ErrMsgCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.UpdDate, objvPrjTab4ErrMsgCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.Memo) == true)
{
string strComparisonOpMemo = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.Memo, objvPrjTab4ErrMsgCond.Memo, strComparisonOpMemo);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.ErrMsg2) == true)
{
string strComparisonOpErrMsg2 = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.ErrMsg2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.ErrMsg2, objvPrjTab4ErrMsgCond.ErrMsg2, strComparisonOpErrMsg2);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.RelaTabName4View) == true)
{
string strComparisonOpRelaTabName4View = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.RelaTabName4View];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.RelaTabName4View, objvPrjTab4ErrMsgCond.RelaTabName4View, strComparisonOpRelaTabName4View);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.DataBaseNameTab) == true)
{
string strComparisonOpDataBaseNameTab = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.DataBaseNameTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.DataBaseNameTab, objvPrjTab4ErrMsgCond.DataBaseNameTab, strComparisonOpDataBaseNameTab);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vPrjTab4ErrMsg(vPrjTab4ErrMsg)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTab4ErrMsgWApi
{
private static readonly string mstrApiControllerName = "vPrjTab4ErrMsgApi";

 public clsvPrjTab4ErrMsgWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPrjTab4ErrMsg]...","0");
List<clsvPrjTab4ErrMsgEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", convPrjTab4ErrMsg.TabId); 
List<clsvPrjTab4ErrMsgEN> arrObjLst = clsvPrjTab4ErrMsgWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN()
{
TabId = "0",
TabName = "选[vPrjTab4ErrMsg]..."
};
arrObjLstSel.Insert(0, objvPrjTab4ErrMsgEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjTab4ErrMsg.TabId;
objComboBox.DisplayMember = convPrjTab4ErrMsg.TabName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab4ErrMsgEN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN;
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
objvPrjTab4ErrMsgEN = JsonConvert.DeserializeObject<clsvPrjTab4ErrMsgEN>(strJson);
return objvPrjTab4ErrMsgEN;
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
public static clsvPrjTab4ErrMsgEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN;
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
objvPrjTab4ErrMsgEN = JsonConvert.DeserializeObject<clsvPrjTab4ErrMsgEN>(strJson);
return objvPrjTab4ErrMsgEN;
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
public static clsvPrjTab4ErrMsgEN GetObjByTabIdCache(string strTabId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTab4ErrMsgEN._CurrTabName, strPrjId);
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLst_Sel =
from objvPrjTab4ErrMsgEN in arrvPrjTab4ErrMsgObjLstCache
where objvPrjTab4ErrMsgEN.TabId == strTabId 
select objvPrjTab4ErrMsgEN;
if (arrvPrjTab4ErrMsgObjLst_Sel.Count() == 0)
{
   clsvPrjTab4ErrMsgEN obj = clsvPrjTab4ErrMsgWApi.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjTab4ErrMsgObjLst_Sel.First();
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
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLst_Sel1 =
from objvPrjTab4ErrMsgEN in arrvPrjTab4ErrMsgObjLstCache
where objvPrjTab4ErrMsgEN.TabId == strTabId 
select objvPrjTab4ErrMsgEN;
List <clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLst_Sel = new List<clsvPrjTab4ErrMsgEN>();
foreach (clsvPrjTab4ErrMsgEN obj in arrvPrjTab4ErrMsgObjLst_Sel1)
{
arrvPrjTab4ErrMsgObjLst_Sel.Add(obj);
}
if (arrvPrjTab4ErrMsgObjLst_Sel.Count > 0)
{
return arrvPrjTab4ErrMsgObjLst_Sel[0].TabName;
}
string strErrMsgForGetObjById = string.Format("在vPrjTab4ErrMsg对象缓存列表中,找不到记录[TabId = {0}](函数:{1})", strTabId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvPrjTab4ErrMsgBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLst_Sel1 =
from objvPrjTab4ErrMsgEN in arrvPrjTab4ErrMsgObjLstCache
where objvPrjTab4ErrMsgEN.TabId == strTabId 
select objvPrjTab4ErrMsgEN;
List <clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLst_Sel = new List<clsvPrjTab4ErrMsgEN>();
foreach (clsvPrjTab4ErrMsgEN obj in arrvPrjTab4ErrMsgObjLst_Sel1)
{
arrvPrjTab4ErrMsgObjLst_Sel.Add(obj);
}
if (arrvPrjTab4ErrMsgObjLst_Sel.Count > 0)
{
return arrvPrjTab4ErrMsgObjLst_Sel[0].TabName;
}
string strErrMsgForGetObjById = string.Format("在vPrjTab4ErrMsg对象缓存列表中,找不到记录的相关名称[TabId = {0}](函数:{1})", strTabId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvPrjTab4ErrMsgBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjTab4ErrMsgEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4ErrMsgEN>>(strJson);
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsvPrjTab4ErrMsgEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4ErrMsgEN>>(strJson);
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
public static IEnumerable<clsvPrjTab4ErrMsgEN> GetObjLstByTabIdLstCache(List<string> arrTabId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTab4ErrMsgEN._CurrTabName, strPrjId);
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLst_Sel =
from objvPrjTab4ErrMsgEN in arrvPrjTab4ErrMsgObjLstCache
where arrTabId.Contains(objvPrjTab4ErrMsgEN.TabId)
select objvPrjTab4ErrMsgEN;
return arrvPrjTab4ErrMsgObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjTab4ErrMsgEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4ErrMsgEN>>(strJson);
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjTab4ErrMsgEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4ErrMsgEN>>(strJson);
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjTab4ErrMsgEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4ErrMsgEN>>(strJson);
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjTab4ErrMsgEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab4ErrMsgEN>>(strJson);
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
 /// <param name = "objvPrjTab4ErrMsgENS">源对象</param>
 /// <param name = "objvPrjTab4ErrMsgENT">目标对象</param>
 public static void CopyTo(clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENS, clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENT)
{
try
{
objvPrjTab4ErrMsgENT.TabId = objvPrjTab4ErrMsgENS.TabId; //表ID
objvPrjTab4ErrMsgENT.FldNum = objvPrjTab4ErrMsgENS.FldNum; //字段数
objvPrjTab4ErrMsgENT.TabName = objvPrjTab4ErrMsgENS.TabName; //表名
objvPrjTab4ErrMsgENT.TabCnName = objvPrjTab4ErrMsgENS.TabCnName; //表中文名
objvPrjTab4ErrMsgENT.PrjId = objvPrjTab4ErrMsgENS.PrjId; //工程Id
objvPrjTab4ErrMsgENT.PrjName = objvPrjTab4ErrMsgENS.PrjName; //工程名称
objvPrjTab4ErrMsgENT.IsNeedTransCode = objvPrjTab4ErrMsgENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4ErrMsgENT.SqlDsTypeId = objvPrjTab4ErrMsgENS.SqlDsTypeId; //数据源类型Id
objvPrjTab4ErrMsgENT.SqlDsTypeName = objvPrjTab4ErrMsgENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4ErrMsgENT.TabStateId = objvPrjTab4ErrMsgENS.TabStateId; //表状态ID
objvPrjTab4ErrMsgENT.TabStateName = objvPrjTab4ErrMsgENS.TabStateName; //表状态名称
objvPrjTab4ErrMsgENT.TabNameB = objvPrjTab4ErrMsgENS.TabNameB; //表名_后备
objvPrjTab4ErrMsgENT.IsParaTab = objvPrjTab4ErrMsgENS.IsParaTab; //是否参数表
objvPrjTab4ErrMsgENT.IsNationStandard = objvPrjTab4ErrMsgENS.IsNationStandard; //是否国标
objvPrjTab4ErrMsgENT.IsArchive = objvPrjTab4ErrMsgENS.IsArchive; //是否存档
objvPrjTab4ErrMsgENT.IsChecked = objvPrjTab4ErrMsgENS.IsChecked; //是否核实
objvPrjTab4ErrMsgENT.ErrMsg = objvPrjTab4ErrMsgENS.ErrMsg; //错误信息
objvPrjTab4ErrMsgENT.FuncModuleAgcId = objvPrjTab4ErrMsgENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4ErrMsgENT.FuncModuleName = objvPrjTab4ErrMsgENS.FuncModuleName; //功能模块名称
objvPrjTab4ErrMsgENT.FuncModuleEnName = objvPrjTab4ErrMsgENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4ErrMsgENT.Owner = objvPrjTab4ErrMsgENS.Owner; //拥有者
objvPrjTab4ErrMsgENT.IsReleToSqlTab = objvPrjTab4ErrMsgENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4ErrMsgENT.Keyword = objvPrjTab4ErrMsgENS.Keyword; //关键字
objvPrjTab4ErrMsgENT.TabTypeId = objvPrjTab4ErrMsgENS.TabTypeId; //表类型Id
objvPrjTab4ErrMsgENT.TabTypeName = objvPrjTab4ErrMsgENS.TabTypeName; //表类型名
objvPrjTab4ErrMsgENT.RelaTabId4View = objvPrjTab4ErrMsgENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4ErrMsgENT.OrderNum4Refer = objvPrjTab4ErrMsgENS.OrderNum4Refer; //引用序号
objvPrjTab4ErrMsgENT.IsNeedGeneIndexer = objvPrjTab4ErrMsgENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4ErrMsgENT.UpdUserId = objvPrjTab4ErrMsgENS.UpdUserId; //修改用户Id
objvPrjTab4ErrMsgENT.UpdDate = objvPrjTab4ErrMsgENS.UpdDate; //修改日期
objvPrjTab4ErrMsgENT.Memo = objvPrjTab4ErrMsgENS.Memo; //说明
objvPrjTab4ErrMsgENT.ErrMsg2 = objvPrjTab4ErrMsgENS.ErrMsg2; //ErrMsg2
objvPrjTab4ErrMsgENT.RelaTabName4View = objvPrjTab4ErrMsgENS.RelaTabName4View; //RelaTabName4View
objvPrjTab4ErrMsgENT.DataBaseNameTab = objvPrjTab4ErrMsgENS.DataBaseNameTab; //DataBaseName_Tab
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
public static DataTable ToDataTable(List<clsvPrjTab4ErrMsgEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjTab4ErrMsgEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjTab4ErrMsgEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjTab4ErrMsgEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjTab4ErrMsgEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjTab4ErrMsgEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTab4ErrMsgWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTab4ErrMsgWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab4ErrMsgEN._CurrTabName, strPrjId);
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTab4ErrMsgWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTab4ErrMsgWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvPrjTab4ErrMsgEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvPrjTab4ErrMsgEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convPrjTab4ErrMsg.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvPrjTab4ErrMsgEN._CurrTabName, strPrjId);
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjTab4ErrMsgObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvPrjTab4ErrMsgEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTab4ErrMsgWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTab4ErrMsgWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvPrjTab4ErrMsgEN._CurrTabName, strPrjId);
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvPrjTab4ErrMsgObjLstCache = CacheHelper.Get<List<clsvPrjTab4ErrMsgEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvPrjTab4ErrMsgObjLstCache = CacheHelper.Get<List<clsvPrjTab4ErrMsgEN>>(strKey);
}
return arrvPrjTab4ErrMsgObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjTab4ErrMsgEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjTab4ErrMsg.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.FldNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTab4ErrMsg.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4ErrMsg.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.TabStateName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.TabNameB, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.IsParaTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4ErrMsg.IsNationStandard, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4ErrMsg.IsArchive, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4ErrMsg.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4ErrMsg.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.Owner, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.IsReleToSqlTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4ErrMsg.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.TabTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.RelaTabId4View, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.OrderNum4Refer, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTab4ErrMsg.IsNeedGeneIndexer, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPrjTab4ErrMsg.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.ErrMsg2, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.RelaTabName4View, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab4ErrMsg.DataBaseNameTab, Type.GetType("System.String"));
foreach (clsvPrjTab4ErrMsgEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjTab4ErrMsg.TabId] = objInFor[convPrjTab4ErrMsg.TabId];
objDR[convPrjTab4ErrMsg.FldNum] = objInFor[convPrjTab4ErrMsg.FldNum];
objDR[convPrjTab4ErrMsg.TabName] = objInFor[convPrjTab4ErrMsg.TabName];
objDR[convPrjTab4ErrMsg.TabCnName] = objInFor[convPrjTab4ErrMsg.TabCnName];
objDR[convPrjTab4ErrMsg.PrjId] = objInFor[convPrjTab4ErrMsg.PrjId];
objDR[convPrjTab4ErrMsg.PrjName] = objInFor[convPrjTab4ErrMsg.PrjName];
objDR[convPrjTab4ErrMsg.IsNeedTransCode] = objInFor[convPrjTab4ErrMsg.IsNeedTransCode];
objDR[convPrjTab4ErrMsg.SqlDsTypeId] = objInFor[convPrjTab4ErrMsg.SqlDsTypeId];
objDR[convPrjTab4ErrMsg.SqlDsTypeName] = objInFor[convPrjTab4ErrMsg.SqlDsTypeName];
objDR[convPrjTab4ErrMsg.TabStateId] = objInFor[convPrjTab4ErrMsg.TabStateId];
objDR[convPrjTab4ErrMsg.TabStateName] = objInFor[convPrjTab4ErrMsg.TabStateName];
objDR[convPrjTab4ErrMsg.TabNameB] = objInFor[convPrjTab4ErrMsg.TabNameB];
objDR[convPrjTab4ErrMsg.IsParaTab] = objInFor[convPrjTab4ErrMsg.IsParaTab];
objDR[convPrjTab4ErrMsg.IsNationStandard] = objInFor[convPrjTab4ErrMsg.IsNationStandard];
objDR[convPrjTab4ErrMsg.IsArchive] = objInFor[convPrjTab4ErrMsg.IsArchive];
objDR[convPrjTab4ErrMsg.IsChecked] = objInFor[convPrjTab4ErrMsg.IsChecked];
objDR[convPrjTab4ErrMsg.ErrMsg] = objInFor[convPrjTab4ErrMsg.ErrMsg];
objDR[convPrjTab4ErrMsg.FuncModuleAgcId] = objInFor[convPrjTab4ErrMsg.FuncModuleAgcId];
objDR[convPrjTab4ErrMsg.FuncModuleName] = objInFor[convPrjTab4ErrMsg.FuncModuleName];
objDR[convPrjTab4ErrMsg.FuncModuleEnName] = objInFor[convPrjTab4ErrMsg.FuncModuleEnName];
objDR[convPrjTab4ErrMsg.Owner] = objInFor[convPrjTab4ErrMsg.Owner];
objDR[convPrjTab4ErrMsg.IsReleToSqlTab] = objInFor[convPrjTab4ErrMsg.IsReleToSqlTab];
objDR[convPrjTab4ErrMsg.Keyword] = objInFor[convPrjTab4ErrMsg.Keyword];
objDR[convPrjTab4ErrMsg.TabTypeId] = objInFor[convPrjTab4ErrMsg.TabTypeId];
objDR[convPrjTab4ErrMsg.TabTypeName] = objInFor[convPrjTab4ErrMsg.TabTypeName];
objDR[convPrjTab4ErrMsg.RelaTabId4View] = objInFor[convPrjTab4ErrMsg.RelaTabId4View];
objDR[convPrjTab4ErrMsg.OrderNum4Refer] = objInFor[convPrjTab4ErrMsg.OrderNum4Refer];
objDR[convPrjTab4ErrMsg.IsNeedGeneIndexer] = objInFor[convPrjTab4ErrMsg.IsNeedGeneIndexer];
objDR[convPrjTab4ErrMsg.UpdUserId] = objInFor[convPrjTab4ErrMsg.UpdUserId];
objDR[convPrjTab4ErrMsg.UpdDate] = objInFor[convPrjTab4ErrMsg.UpdDate];
objDR[convPrjTab4ErrMsg.Memo] = objInFor[convPrjTab4ErrMsg.Memo];
objDR[convPrjTab4ErrMsg.ErrMsg2] = objInFor[convPrjTab4ErrMsg.ErrMsg2];
objDR[convPrjTab4ErrMsg.RelaTabName4View] = objInFor[convPrjTab4ErrMsg.RelaTabName4View];
objDR[convPrjTab4ErrMsg.DataBaseNameTab] = objInFor[convPrjTab4ErrMsg.DataBaseNameTab];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}